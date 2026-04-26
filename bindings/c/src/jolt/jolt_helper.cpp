// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/jolt_helper.h"

#include <__mrbind_c_details.h>
#include <jolt_helper.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


const float *JoltVec3f_Get_x(const JoltVec3f *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltVec3f *)(_this)).x);
}

void JoltVec3f_Set_x(JoltVec3f *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltVec3f *)(_this)).x = value;
}

float *JoltVec3f_GetMutable_x(JoltVec3f *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltVec3f *)(_this)).x);
}

const float *JoltVec3f_Get_y(const JoltVec3f *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltVec3f *)(_this)).y);
}

void JoltVec3f_Set_y(JoltVec3f *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltVec3f *)(_this)).y = value;
}

float *JoltVec3f_GetMutable_y(JoltVec3f *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltVec3f *)(_this)).y);
}

const float *JoltVec3f_Get_z(const JoltVec3f *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltVec3f *)(_this)).z);
}

void JoltVec3f_Set_z(JoltVec3f *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltVec3f *)(_this)).z = value;
}

float *JoltVec3f_GetMutable_z(JoltVec3f *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltVec3f *)(_this)).z);
}

JoltVec3f *JoltVec3f_DefaultConstruct(void)
{
    return (JoltVec3f *)new JoltVec3f(JoltVec3f());
}

JoltVec3f *JoltVec3f_DefaultConstructArray(size_t num_elems)
{
    return (JoltVec3f *)(new JoltVec3f[num_elems]{});
}

const JoltVec3f *JoltVec3f_OffsetPtr(const JoltVec3f *ptr, ptrdiff_t i)
{
    return (const JoltVec3f *)(((const JoltVec3f *)ptr) + i);
}

JoltVec3f *JoltVec3f_OffsetMutablePtr(JoltVec3f *ptr, ptrdiff_t i)
{
    return (JoltVec3f *)(((JoltVec3f *)ptr) + i);
}

JoltVec3f *JoltVec3f_ConstructFromAnother(const JoltVec3f *_other)
{
    return (JoltVec3f *)new JoltVec3f(JoltVec3f(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltVec3f(*(JoltVec3f *)_other))
    ));
}

JoltVec3f *JoltVec3f_Construct(float x, float y, float z)
{
    return (JoltVec3f *)new JoltVec3f(JoltVec3f(
        x,
        y,
        z
    ));
}

void JoltVec3f_Destroy(const JoltVec3f *_this)
{
    delete ((const JoltVec3f *)_this);
}

void JoltVec3f_DestroyArray(const JoltVec3f *_this)
{
    delete[] ((const JoltVec3f *)_this);
}

JoltVec3f *JoltVec3f_AssignFromAnother(JoltVec3f *_this, const JoltVec3f *_other)
{
    return (JoltVec3f *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltVec3f *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltVec3f(*(JoltVec3f *)_other))
    ));
}

const double *JoltVec3_Get_x(const JoltVec3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltVec3 *)(_this)).x);
}

void JoltVec3_Set_x(JoltVec3 *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltVec3 *)(_this)).x = value;
}

double *JoltVec3_GetMutable_x(JoltVec3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltVec3 *)(_this)).x);
}

const double *JoltVec3_Get_y(const JoltVec3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltVec3 *)(_this)).y);
}

void JoltVec3_Set_y(JoltVec3 *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltVec3 *)(_this)).y = value;
}

double *JoltVec3_GetMutable_y(JoltVec3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltVec3 *)(_this)).y);
}

const double *JoltVec3_Get_z(const JoltVec3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltVec3 *)(_this)).z);
}

void JoltVec3_Set_z(JoltVec3 *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltVec3 *)(_this)).z = value;
}

double *JoltVec3_GetMutable_z(JoltVec3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltVec3 *)(_this)).z);
}

JoltVec3 *JoltVec3_DefaultConstruct(void)
{
    return (JoltVec3 *)new JoltVec3(JoltVec3());
}

JoltVec3 *JoltVec3_DefaultConstructArray(size_t num_elems)
{
    return (JoltVec3 *)(new JoltVec3[num_elems]{});
}

const JoltVec3 *JoltVec3_OffsetPtr(const JoltVec3 *ptr, ptrdiff_t i)
{
    return (const JoltVec3 *)(((const JoltVec3 *)ptr) + i);
}

JoltVec3 *JoltVec3_OffsetMutablePtr(JoltVec3 *ptr, ptrdiff_t i)
{
    return (JoltVec3 *)(((JoltVec3 *)ptr) + i);
}

JoltVec3 *JoltVec3_ConstructFromAnother(const JoltVec3 *_other)
{
    return (JoltVec3 *)new JoltVec3(JoltVec3(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltVec3(*(JoltVec3 *)_other))
    ));
}

JoltVec3 *JoltVec3_Construct(double x, double y, double z)
{
    return (JoltVec3 *)new JoltVec3(JoltVec3(
        x,
        y,
        z
    ));
}

void JoltVec3_Destroy(const JoltVec3 *_this)
{
    delete ((const JoltVec3 *)_this);
}

void JoltVec3_DestroyArray(const JoltVec3 *_this)
{
    delete[] ((const JoltVec3 *)_this);
}

JoltVec3 *JoltVec3_AssignFromAnother(JoltVec3 *_this, const JoltVec3 *_other)
{
    return (JoltVec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltVec3 *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltVec3(*(JoltVec3 *)_other))
    ));
}

const float *JoltQuat_Get_x(const JoltQuat *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltQuat *)(_this)).x);
}

void JoltQuat_Set_x(JoltQuat *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltQuat *)(_this)).x = value;
}

float *JoltQuat_GetMutable_x(JoltQuat *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltQuat *)(_this)).x);
}

const float *JoltQuat_Get_y(const JoltQuat *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltQuat *)(_this)).y);
}

void JoltQuat_Set_y(JoltQuat *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltQuat *)(_this)).y = value;
}

float *JoltQuat_GetMutable_y(JoltQuat *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltQuat *)(_this)).y);
}

const float *JoltQuat_Get_z(const JoltQuat *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltQuat *)(_this)).z);
}

void JoltQuat_Set_z(JoltQuat *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltQuat *)(_this)).z = value;
}

float *JoltQuat_GetMutable_z(JoltQuat *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltQuat *)(_this)).z);
}

const float *JoltQuat_Get_w(const JoltQuat *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltQuat *)(_this)).w);
}

void JoltQuat_Set_w(JoltQuat *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltQuat *)(_this)).w = value;
}

float *JoltQuat_GetMutable_w(JoltQuat *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltQuat *)(_this)).w);
}

JoltQuat *JoltQuat_DefaultConstruct(void)
{
    return (JoltQuat *)new JoltQuat(JoltQuat());
}

JoltQuat *JoltQuat_DefaultConstructArray(size_t num_elems)
{
    return (JoltQuat *)(new JoltQuat[num_elems]{});
}

const JoltQuat *JoltQuat_OffsetPtr(const JoltQuat *ptr, ptrdiff_t i)
{
    return (const JoltQuat *)(((const JoltQuat *)ptr) + i);
}

JoltQuat *JoltQuat_OffsetMutablePtr(JoltQuat *ptr, ptrdiff_t i)
{
    return (JoltQuat *)(((JoltQuat *)ptr) + i);
}

JoltQuat *JoltQuat_ConstructFromAnother(const JoltQuat *_other)
{
    return (JoltQuat *)new JoltQuat(JoltQuat(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltQuat(*(JoltQuat *)_other))
    ));
}

JoltQuat *JoltQuat_Construct(float x, float y, float z, float w)
{
    return (JoltQuat *)new JoltQuat(JoltQuat(
        x,
        y,
        z,
        w
    ));
}

void JoltQuat_Destroy(const JoltQuat *_this)
{
    delete ((const JoltQuat *)_this);
}

void JoltQuat_DestroyArray(const JoltQuat *_this)
{
    delete[] ((const JoltQuat *)_this);
}

JoltQuat *JoltQuat_AssignFromAnother(JoltQuat *_this, const JoltQuat *_other)
{
    return (JoltQuat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltQuat *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltQuat(*(JoltQuat *)_other))
    ));
}

JoltQuat *JoltQuat_Identity(void)
{
    return (JoltQuat *)new JoltQuat(JoltQuat::Identity());
}

bool JoltQuat_IsNormalized(const JoltQuat *_this, float tolerance)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltQuat *)(_this)).IsNormalized(
        tolerance
    );
}

JoltVec3f *JoltQuat_RotateAxisX(const JoltQuat *_this)
{
    return (JoltVec3f *)new JoltVec3f(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltQuat *)(_this)).RotateAxisX());
}

JoltVec3f *JoltQuat_RotateAxisY(const JoltQuat *_this)
{
    return (JoltVec3f *)new JoltVec3f(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltQuat *)(_this)).RotateAxisY());
}

JoltVec3f *JoltQuat_RotateAxisZ(const JoltQuat *_this)
{
    return (JoltVec3f *)new JoltVec3f(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltQuat *)(_this)).RotateAxisZ());
}

const float *JoltMat44_Get_e00(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e00);
}

void JoltMat44_Set_e00(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e00 = value;
}

float *JoltMat44_GetMutable_e00(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e00);
}

const float *JoltMat44_Get_e10(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e10);
}

void JoltMat44_Set_e10(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e10 = value;
}

float *JoltMat44_GetMutable_e10(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e10);
}

const float *JoltMat44_Get_e20(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e20);
}

void JoltMat44_Set_e20(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e20 = value;
}

float *JoltMat44_GetMutable_e20(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e20);
}

const float *JoltMat44_Get_e30(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e30);
}

void JoltMat44_Set_e30(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e30 = value;
}

float *JoltMat44_GetMutable_e30(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e30);
}

const float *JoltMat44_Get_e01(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e01);
}

void JoltMat44_Set_e01(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e01 = value;
}

float *JoltMat44_GetMutable_e01(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e01);
}

const float *JoltMat44_Get_e11(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e11);
}

void JoltMat44_Set_e11(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e11 = value;
}

float *JoltMat44_GetMutable_e11(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e11);
}

const float *JoltMat44_Get_e21(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e21);
}

void JoltMat44_Set_e21(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e21 = value;
}

float *JoltMat44_GetMutable_e21(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e21);
}

const float *JoltMat44_Get_e31(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e31);
}

void JoltMat44_Set_e31(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e31 = value;
}

float *JoltMat44_GetMutable_e31(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e31);
}

const float *JoltMat44_Get_e02(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e02);
}

void JoltMat44_Set_e02(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e02 = value;
}

float *JoltMat44_GetMutable_e02(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e02);
}

const float *JoltMat44_Get_e12(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e12);
}

void JoltMat44_Set_e12(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e12 = value;
}

float *JoltMat44_GetMutable_e12(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e12);
}

const float *JoltMat44_Get_e22(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e22);
}

void JoltMat44_Set_e22(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e22 = value;
}

float *JoltMat44_GetMutable_e22(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e22);
}

const float *JoltMat44_Get_e32(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e32);
}

void JoltMat44_Set_e32(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e32 = value;
}

float *JoltMat44_GetMutable_e32(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e32);
}

const float *JoltMat44_Get_e03(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e03);
}

void JoltMat44_Set_e03(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e03 = value;
}

float *JoltMat44_GetMutable_e03(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e03);
}

const float *JoltMat44_Get_e13(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e13);
}

void JoltMat44_Set_e13(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e13 = value;
}

float *JoltMat44_GetMutable_e13(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e13);
}

const float *JoltMat44_Get_e23(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e23);
}

void JoltMat44_Set_e23(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e23 = value;
}

float *JoltMat44_GetMutable_e23(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e23);
}

const float *JoltMat44_Get_e33(const JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).e33);
}

void JoltMat44_Set_e33(JoltMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e33 = value;
}

float *JoltMat44_GetMutable_e33(JoltMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).e33);
}

JoltMat44 *JoltMat44_DefaultConstruct(void)
{
    return (JoltMat44 *)new JoltMat44(JoltMat44());
}

JoltMat44 *JoltMat44_DefaultConstructArray(size_t num_elems)
{
    return (JoltMat44 *)(new JoltMat44[num_elems]{});
}

const JoltMat44 *JoltMat44_OffsetPtr(const JoltMat44 *ptr, ptrdiff_t i)
{
    return (const JoltMat44 *)(((const JoltMat44 *)ptr) + i);
}

JoltMat44 *JoltMat44_OffsetMutablePtr(JoltMat44 *ptr, ptrdiff_t i)
{
    return (JoltMat44 *)(((JoltMat44 *)ptr) + i);
}

JoltMat44 *JoltMat44_ConstructFromAnother(const JoltMat44 *_other)
{
    return (JoltMat44 *)new JoltMat44(JoltMat44(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltMat44(*(JoltMat44 *)_other))
    ));
}

void JoltMat44_Destroy(const JoltMat44 *_this)
{
    delete ((const JoltMat44 *)_this);
}

void JoltMat44_DestroyArray(const JoltMat44 *_this)
{
    delete[] ((const JoltMat44 *)_this);
}

JoltMat44 *JoltMat44_AssignFromAnother(JoltMat44 *_this, const JoltMat44 *_other)
{
    return (JoltMat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltMat44 *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltMat44(*(JoltMat44 *)_other))
    ));
}

JoltMat44 *JoltMat44_Identity(void)
{
    return (JoltMat44 *)new JoltMat44(JoltMat44::Identity());
}

JoltVec3f *JoltMat44_GetTranslation(const JoltMat44 *_this)
{
    return (JoltVec3f *)new JoltVec3f(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).GetTranslation());
}

JoltQuat *JoltMat44_GetRotation(const JoltMat44 *_this)
{
    return (JoltQuat *)new JoltQuat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltMat44 *)(_this)).GetRotation());
}

const float *JoltRMat44_Get_e00(const JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).e00);
}

void JoltRMat44_Set_e00(JoltRMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e00 = value;
}

float *JoltRMat44_GetMutable_e00(JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e00);
}

const float *JoltRMat44_Get_e10(const JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).e10);
}

void JoltRMat44_Set_e10(JoltRMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e10 = value;
}

float *JoltRMat44_GetMutable_e10(JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e10);
}

const float *JoltRMat44_Get_e20(const JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).e20);
}

void JoltRMat44_Set_e20(JoltRMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e20 = value;
}

float *JoltRMat44_GetMutable_e20(JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e20);
}

const float *JoltRMat44_Get_e01(const JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).e01);
}

void JoltRMat44_Set_e01(JoltRMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e01 = value;
}

float *JoltRMat44_GetMutable_e01(JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e01);
}

const float *JoltRMat44_Get_e11(const JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).e11);
}

void JoltRMat44_Set_e11(JoltRMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e11 = value;
}

float *JoltRMat44_GetMutable_e11(JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e11);
}

const float *JoltRMat44_Get_e21(const JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).e21);
}

void JoltRMat44_Set_e21(JoltRMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e21 = value;
}

float *JoltRMat44_GetMutable_e21(JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e21);
}

const float *JoltRMat44_Get_e02(const JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).e02);
}

void JoltRMat44_Set_e02(JoltRMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e02 = value;
}

float *JoltRMat44_GetMutable_e02(JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e02);
}

const float *JoltRMat44_Get_e12(const JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).e12);
}

void JoltRMat44_Set_e12(JoltRMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e12 = value;
}

float *JoltRMat44_GetMutable_e12(JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e12);
}

const float *JoltRMat44_Get_e22(const JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).e22);
}

void JoltRMat44_Set_e22(JoltRMat44 *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e22 = value;
}

float *JoltRMat44_GetMutable_e22(JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).e22);
}

const double *JoltRMat44_Get_tx(const JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).tx);
}

void JoltRMat44_Set_tx(JoltRMat44 *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).tx = value;
}

double *JoltRMat44_GetMutable_tx(JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).tx);
}

const double *JoltRMat44_Get_ty(const JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).ty);
}

void JoltRMat44_Set_ty(JoltRMat44 *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).ty = value;
}

double *JoltRMat44_GetMutable_ty(JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).ty);
}

const double *JoltRMat44_Get_tz(const JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).tz);
}

void JoltRMat44_Set_tz(JoltRMat44 *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).tz = value;
}

double *JoltRMat44_GetMutable_tz(JoltRMat44 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).tz);
}

JoltRMat44 *JoltRMat44_DefaultConstruct(void)
{
    return (JoltRMat44 *)new JoltRMat44(JoltRMat44());
}

JoltRMat44 *JoltRMat44_DefaultConstructArray(size_t num_elems)
{
    return (JoltRMat44 *)(new JoltRMat44[num_elems]{});
}

const JoltRMat44 *JoltRMat44_OffsetPtr(const JoltRMat44 *ptr, ptrdiff_t i)
{
    return (const JoltRMat44 *)(((const JoltRMat44 *)ptr) + i);
}

JoltRMat44 *JoltRMat44_OffsetMutablePtr(JoltRMat44 *ptr, ptrdiff_t i)
{
    return (JoltRMat44 *)(((JoltRMat44 *)ptr) + i);
}

JoltRMat44 *JoltRMat44_ConstructFromAnother(const JoltRMat44 *_other)
{
    return (JoltRMat44 *)new JoltRMat44(JoltRMat44(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltRMat44(*(JoltRMat44 *)_other))
    ));
}

void JoltRMat44_Destroy(const JoltRMat44 *_this)
{
    delete ((const JoltRMat44 *)_this);
}

void JoltRMat44_DestroyArray(const JoltRMat44 *_this)
{
    delete[] ((const JoltRMat44 *)_this);
}

JoltRMat44 *JoltRMat44_AssignFromAnother(JoltRMat44 *_this, const JoltRMat44 *_other)
{
    return (JoltRMat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRMat44 *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltRMat44(*(JoltRMat44 *)_other))
    ));
}

JoltRMat44 *JoltRMat44_Identity(void)
{
    return (JoltRMat44 *)new JoltRMat44(JoltRMat44::Identity());
}

JoltVec3 *JoltRMat44_GetTranslation(const JoltRMat44 *_this)
{
    return (JoltVec3 *)new JoltVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).GetTranslation());
}

JoltVec3f *JoltRMat44_GetTranslationF(const JoltRMat44 *_this)
{
    return (JoltVec3f *)new JoltVec3f(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).GetTranslationF());
}

JoltQuat *JoltRMat44_GetRotation(const JoltRMat44 *_this)
{
    return (JoltQuat *)new JoltQuat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).GetRotation());
}

JoltMat44 *JoltRMat44_ToMat44(const JoltRMat44 *_this)
{
    return (JoltMat44 *)new JoltMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRMat44 *)(_this)).ToMat44());
}

const double *JoltAABox_Get_minX(const JoltAABox *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltAABox *)(_this)).minX);
}

void JoltAABox_Set_minX(JoltAABox *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltAABox *)(_this)).minX = value;
}

double *JoltAABox_GetMutable_minX(JoltAABox *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltAABox *)(_this)).minX);
}

const double *JoltAABox_Get_minY(const JoltAABox *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltAABox *)(_this)).minY);
}

void JoltAABox_Set_minY(JoltAABox *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltAABox *)(_this)).minY = value;
}

double *JoltAABox_GetMutable_minY(JoltAABox *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltAABox *)(_this)).minY);
}

const double *JoltAABox_Get_minZ(const JoltAABox *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltAABox *)(_this)).minZ);
}

void JoltAABox_Set_minZ(JoltAABox *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltAABox *)(_this)).minZ = value;
}

double *JoltAABox_GetMutable_minZ(JoltAABox *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltAABox *)(_this)).minZ);
}

const double *JoltAABox_Get_maxX(const JoltAABox *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltAABox *)(_this)).maxX);
}

void JoltAABox_Set_maxX(JoltAABox *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltAABox *)(_this)).maxX = value;
}

double *JoltAABox_GetMutable_maxX(JoltAABox *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltAABox *)(_this)).maxX);
}

const double *JoltAABox_Get_maxY(const JoltAABox *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltAABox *)(_this)).maxY);
}

void JoltAABox_Set_maxY(JoltAABox *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltAABox *)(_this)).maxY = value;
}

double *JoltAABox_GetMutable_maxY(JoltAABox *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltAABox *)(_this)).maxY);
}

const double *JoltAABox_Get_maxZ(const JoltAABox *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltAABox *)(_this)).maxZ);
}

void JoltAABox_Set_maxZ(JoltAABox *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltAABox *)(_this)).maxZ = value;
}

double *JoltAABox_GetMutable_maxZ(JoltAABox *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltAABox *)(_this)).maxZ);
}

JoltAABox *JoltAABox_DefaultConstruct(void)
{
    return (JoltAABox *)new JoltAABox(JoltAABox());
}

JoltAABox *JoltAABox_DefaultConstructArray(size_t num_elems)
{
    return (JoltAABox *)(new JoltAABox[num_elems]{});
}

const JoltAABox *JoltAABox_OffsetPtr(const JoltAABox *ptr, ptrdiff_t i)
{
    return (const JoltAABox *)(((const JoltAABox *)ptr) + i);
}

JoltAABox *JoltAABox_OffsetMutablePtr(JoltAABox *ptr, ptrdiff_t i)
{
    return (JoltAABox *)(((JoltAABox *)ptr) + i);
}

JoltAABox *JoltAABox_ConstructFromAnother(const JoltAABox *_other)
{
    return (JoltAABox *)new JoltAABox(JoltAABox(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltAABox(*(JoltAABox *)_other))
    ));
}

JoltAABox *JoltAABox_Construct(double minX, double minY, double minZ, double maxX, double maxY, double maxZ)
{
    return (JoltAABox *)new JoltAABox(JoltAABox(
        minX,
        minY,
        minZ,
        maxX,
        maxY,
        maxZ
    ));
}

void JoltAABox_Destroy(const JoltAABox *_this)
{
    delete ((const JoltAABox *)_this);
}

void JoltAABox_DestroyArray(const JoltAABox *_this)
{
    delete[] ((const JoltAABox *)_this);
}

JoltAABox *JoltAABox_AssignFromAnother(JoltAABox *_this, const JoltAABox *_other)
{
    return (JoltAABox *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltAABox *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltAABox(*(JoltAABox *)_other))
    ));
}

JoltVec3 *JoltAABox_GetCenter(const JoltAABox *_this)
{
    return (JoltVec3 *)new JoltVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltAABox *)(_this)).GetCenter());
}

JoltVec3 *JoltAABox_GetExtent(const JoltAABox *_this)
{
    return (JoltVec3 *)new JoltVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltAABox *)(_this)).GetExtent());
}

bool JoltAABox_Contains(const JoltAABox *_this, double x, double y, double z)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltAABox *)(_this)).Contains(
        x,
        y,
        z
    );
}

bool JoltAABox_Overlaps(const JoltAABox *_this, const JoltAABox *other)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltAABox *)(_this)).Overlaps(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), *(const JoltAABox *)(other))
    );
}

void JoltAABox_Encapsulate(JoltAABox *_this, double x, double y, double z)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltAABox *)(_this)).Encapsulate(
        x,
        y,
        z
    );
}

const unsigned int *JoltCollisionGroup_Get_InvalidGroup(void)
{
    return std::addressof(JoltCollisionGroup::InvalidGroup);
}

const unsigned int *JoltCollisionGroup_Get_InvalidSubGroup(void)
{
    return std::addressof(JoltCollisionGroup::InvalidSubGroup);
}

const unsigned int *JoltCollisionGroup_Get_groupID(const JoltCollisionGroup *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltCollisionGroup *)(_this)).groupID);
}

void JoltCollisionGroup_Set_groupID(JoltCollisionGroup *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltCollisionGroup *)(_this)).groupID = value;
}

unsigned int *JoltCollisionGroup_GetMutable_groupID(JoltCollisionGroup *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltCollisionGroup *)(_this)).groupID);
}

const unsigned int *JoltCollisionGroup_Get_subGroupID(const JoltCollisionGroup *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltCollisionGroup *)(_this)).subGroupID);
}

void JoltCollisionGroup_Set_subGroupID(JoltCollisionGroup *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltCollisionGroup *)(_this)).subGroupID = value;
}

unsigned int *JoltCollisionGroup_GetMutable_subGroupID(JoltCollisionGroup *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltCollisionGroup *)(_this)).subGroupID);
}

JoltCollisionGroup *JoltCollisionGroup_DefaultConstruct(void)
{
    return (JoltCollisionGroup *)new JoltCollisionGroup(JoltCollisionGroup());
}

JoltCollisionGroup *JoltCollisionGroup_DefaultConstructArray(size_t num_elems)
{
    return (JoltCollisionGroup *)(new JoltCollisionGroup[num_elems]{});
}

const JoltCollisionGroup *JoltCollisionGroup_OffsetPtr(const JoltCollisionGroup *ptr, ptrdiff_t i)
{
    return (const JoltCollisionGroup *)(((const JoltCollisionGroup *)ptr) + i);
}

JoltCollisionGroup *JoltCollisionGroup_OffsetMutablePtr(JoltCollisionGroup *ptr, ptrdiff_t i)
{
    return (JoltCollisionGroup *)(((JoltCollisionGroup *)ptr) + i);
}

JoltCollisionGroup *JoltCollisionGroup_ConstructFromAnother(const JoltCollisionGroup *_other)
{
    return (JoltCollisionGroup *)new JoltCollisionGroup(JoltCollisionGroup(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltCollisionGroup(*(JoltCollisionGroup *)_other))
    ));
}

JoltCollisionGroup *JoltCollisionGroup_Construct(unsigned int groupID, unsigned int subGroupID)
{
    return (JoltCollisionGroup *)new JoltCollisionGroup(JoltCollisionGroup(
        groupID,
        subGroupID
    ));
}

void JoltCollisionGroup_Destroy(const JoltCollisionGroup *_this)
{
    delete ((const JoltCollisionGroup *)_this);
}

void JoltCollisionGroup_DestroyArray(const JoltCollisionGroup *_this)
{
    delete[] ((const JoltCollisionGroup *)_this);
}

JoltCollisionGroup *JoltCollisionGroup_AssignFromAnother(JoltCollisionGroup *_this, const JoltCollisionGroup *_other)
{
    return (JoltCollisionGroup *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltCollisionGroup *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltCollisionGroup(*(JoltCollisionGroup *)_other))
    ));
}

void *const *JoltPhysicsMaterial_Get_mPtr(const JoltPhysicsMaterial *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltPhysicsMaterial *)(_this)).mPtr);
}

void JoltPhysicsMaterial_Set_mPtr(JoltPhysicsMaterial *_this, void *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsMaterial *)(_this)).mPtr = value;
}

void **JoltPhysicsMaterial_GetMutable_mPtr(JoltPhysicsMaterial *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsMaterial *)(_this)).mPtr);
}

JoltPhysicsMaterial *JoltPhysicsMaterial_DefaultConstruct(void)
{
    return (JoltPhysicsMaterial *)new JoltPhysicsMaterial(JoltPhysicsMaterial());
}

JoltPhysicsMaterial *JoltPhysicsMaterial_DefaultConstructArray(size_t num_elems)
{
    return (JoltPhysicsMaterial *)(new JoltPhysicsMaterial[num_elems]{});
}

const JoltPhysicsMaterial *JoltPhysicsMaterial_OffsetPtr(const JoltPhysicsMaterial *ptr, ptrdiff_t i)
{
    return (const JoltPhysicsMaterial *)(((const JoltPhysicsMaterial *)ptr) + i);
}

JoltPhysicsMaterial *JoltPhysicsMaterial_OffsetMutablePtr(JoltPhysicsMaterial *ptr, ptrdiff_t i)
{
    return (JoltPhysicsMaterial *)(((JoltPhysicsMaterial *)ptr) + i);
}

JoltPhysicsMaterial *JoltPhysicsMaterial_ConstructFromAnother(const JoltPhysicsMaterial *_other)
{
    return (JoltPhysicsMaterial *)new JoltPhysicsMaterial(JoltPhysicsMaterial(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltPhysicsMaterial(*(JoltPhysicsMaterial *)_other))
    ));
}

void JoltPhysicsMaterial_Destroy(const JoltPhysicsMaterial *_this)
{
    delete ((const JoltPhysicsMaterial *)_this);
}

void JoltPhysicsMaterial_DestroyArray(const JoltPhysicsMaterial *_this)
{
    delete[] ((const JoltPhysicsMaterial *)_this);
}

JoltPhysicsMaterial *JoltPhysicsMaterial_AssignFromAnother(JoltPhysicsMaterial *_this, const JoltPhysicsMaterial *_other)
{
    return (JoltPhysicsMaterial *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsMaterial *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltPhysicsMaterial(*(JoltPhysicsMaterial *)_other))
    ));
}

bool JoltPhysicsMaterial_IsValid(const JoltPhysicsMaterial *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltPhysicsMaterial *)(_this)).IsValid();
}

const char *JoltPhysicsMaterial_GetDebugName(const JoltPhysicsMaterial *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltPhysicsMaterial *)(_this)).GetDebugName();
}

void *const *JoltTwoBodyConstraint_Get_mPtr(const JoltTwoBodyConstraint *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltTwoBodyConstraint *)(_this)).mPtr);
}

void JoltTwoBodyConstraint_Set_mPtr(JoltTwoBodyConstraint *_this, void *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltTwoBodyConstraint *)(_this)).mPtr = value;
}

void **JoltTwoBodyConstraint_GetMutable_mPtr(JoltTwoBodyConstraint *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltTwoBodyConstraint *)(_this)).mPtr);
}

JoltTwoBodyConstraint *JoltTwoBodyConstraint_DefaultConstruct(void)
{
    return (JoltTwoBodyConstraint *)new JoltTwoBodyConstraint(JoltTwoBodyConstraint());
}

JoltTwoBodyConstraint *JoltTwoBodyConstraint_DefaultConstructArray(size_t num_elems)
{
    return (JoltTwoBodyConstraint *)(new JoltTwoBodyConstraint[num_elems]{});
}

const JoltTwoBodyConstraint *JoltTwoBodyConstraint_OffsetPtr(const JoltTwoBodyConstraint *ptr, ptrdiff_t i)
{
    return (const JoltTwoBodyConstraint *)(((const JoltTwoBodyConstraint *)ptr) + i);
}

JoltTwoBodyConstraint *JoltTwoBodyConstraint_OffsetMutablePtr(JoltTwoBodyConstraint *ptr, ptrdiff_t i)
{
    return (JoltTwoBodyConstraint *)(((JoltTwoBodyConstraint *)ptr) + i);
}

JoltTwoBodyConstraint *JoltTwoBodyConstraint_ConstructFromAnother(const JoltTwoBodyConstraint *_other)
{
    return (JoltTwoBodyConstraint *)new JoltTwoBodyConstraint(JoltTwoBodyConstraint(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltTwoBodyConstraint(*(JoltTwoBodyConstraint *)_other))
    ));
}

void JoltTwoBodyConstraint_Destroy(const JoltTwoBodyConstraint *_this)
{
    delete ((const JoltTwoBodyConstraint *)_this);
}

void JoltTwoBodyConstraint_DestroyArray(const JoltTwoBodyConstraint *_this)
{
    delete[] ((const JoltTwoBodyConstraint *)_this);
}

JoltTwoBodyConstraint *JoltTwoBodyConstraint_AssignFromAnother(JoltTwoBodyConstraint *_this, const JoltTwoBodyConstraint *_other)
{
    return (JoltTwoBodyConstraint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltTwoBodyConstraint *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltTwoBodyConstraint(*(JoltTwoBodyConstraint *)_other))
    ));
}

bool JoltTwoBodyConstraint_IsValid(const JoltTwoBodyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltTwoBodyConstraint *)(_this)).IsValid();
}

bool JoltTwoBodyConstraint_GetEnabled(const JoltTwoBodyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltTwoBodyConstraint *)(_this)).GetEnabled();
}

void JoltTwoBodyConstraint_SetEnabled(JoltTwoBodyConstraint *_this, bool enabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltTwoBodyConstraint *)(_this)).SetEnabled(
        enabled
    );
}

const unsigned int *JoltBodyID_Get_value(const JoltBodyID *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyID *)(_this)).value);
}

void JoltBodyID_Set_value(JoltBodyID *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyID *)(_this)).value = value;
}

unsigned int *JoltBodyID_GetMutable_value(JoltBodyID *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyID *)(_this)).value);
}

JoltBodyID *JoltBodyID_DefaultConstruct(void)
{
    return (JoltBodyID *)new JoltBodyID(JoltBodyID());
}

JoltBodyID *JoltBodyID_DefaultConstructArray(size_t num_elems)
{
    return (JoltBodyID *)(new JoltBodyID[num_elems]{});
}

const JoltBodyID *JoltBodyID_OffsetPtr(const JoltBodyID *ptr, ptrdiff_t i)
{
    return (const JoltBodyID *)(((const JoltBodyID *)ptr) + i);
}

JoltBodyID *JoltBodyID_OffsetMutablePtr(JoltBodyID *ptr, ptrdiff_t i)
{
    return (JoltBodyID *)(((JoltBodyID *)ptr) + i);
}

JoltBodyID *JoltBodyID_ConstructFromAnother(const JoltBodyID *_other)
{
    return (JoltBodyID *)new JoltBodyID(JoltBodyID(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltBodyID(*(JoltBodyID *)_other))
    ));
}

void JoltBodyID_Destroy(const JoltBodyID *_this)
{
    delete ((const JoltBodyID *)_this);
}

void JoltBodyID_DestroyArray(const JoltBodyID *_this)
{
    delete[] ((const JoltBodyID *)_this);
}

JoltBodyID *JoltBodyID_AssignFromAnother(JoltBodyID *_this, const JoltBodyID *_other)
{
    return (JoltBodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyID *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltBodyID(*(JoltBodyID *)_other))
    ));
}

bool JoltBodyID_IsValid(const JoltBodyID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyID *)(_this)).IsValid();
}

bool JoltBodyID_IsInvalid(const JoltBodyID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyID *)(_this)).IsInvalid();
}

void *const *JoltBodyIDList_Get_mData(const JoltBodyIDList *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyIDList *)(_this)).mData);
}

void JoltBodyIDList_Set_mData(JoltBodyIDList *_this, void *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyIDList *)(_this)).mData = value;
}

void **JoltBodyIDList_GetMutable_mData(JoltBodyIDList *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyIDList *)(_this)).mData);
}

JoltBodyIDList *JoltBodyIDList_DefaultConstruct(void)
{
    return (JoltBodyIDList *)new JoltBodyIDList(JoltBodyIDList());
}

JoltBodyIDList *JoltBodyIDList_DefaultConstructArray(size_t num_elems)
{
    return (JoltBodyIDList *)(new JoltBodyIDList[num_elems]{});
}

const JoltBodyIDList *JoltBodyIDList_OffsetPtr(const JoltBodyIDList *ptr, ptrdiff_t i)
{
    return (const JoltBodyIDList *)(((const JoltBodyIDList *)ptr) + i);
}

JoltBodyIDList *JoltBodyIDList_OffsetMutablePtr(JoltBodyIDList *ptr, ptrdiff_t i)
{
    return (JoltBodyIDList *)(((JoltBodyIDList *)ptr) + i);
}

JoltBodyIDList *JoltBodyIDList_ConstructFromAnother(const JoltBodyIDList *_other)
{
    return (JoltBodyIDList *)new JoltBodyIDList(JoltBodyIDList(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltBodyIDList(*(JoltBodyIDList *)_other))
    ));
}

void JoltBodyIDList_Destroy(const JoltBodyIDList *_this)
{
    delete ((const JoltBodyIDList *)_this);
}

void JoltBodyIDList_DestroyArray(const JoltBodyIDList *_this)
{
    delete[] ((const JoltBodyIDList *)_this);
}

JoltBodyIDList *JoltBodyIDList_AssignFromAnother(JoltBodyIDList *_this, const JoltBodyIDList *_other)
{
    return (JoltBodyIDList *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyIDList *)(_this)).operator=(
        mrbindc_details::unmove(((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltBodyIDList(*(JoltBodyIDList *)_other)))
    ));
}

void JoltBodyIDList_Add(JoltBodyIDList *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyIDList *)(_this)).Add(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyIDList_Clear(JoltBodyIDList *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyIDList *)(_this)).Clear();
}

int JoltBodyIDList_Count(const JoltBodyIDList *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyIDList *)(_this)).Count();
}

JoltBodyID *JoltBodyIDList_Get(const JoltBodyIDList *_this, int index)
{
    return (JoltBodyID *)new JoltBodyID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyIDList *)(_this)).Get(
        index
    ));
}

const unsigned int *JoltConstraintID_Get_value(const JoltConstraintID *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltConstraintID *)(_this)).value);
}

void JoltConstraintID_Set_value(JoltConstraintID *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltConstraintID *)(_this)).value = value;
}

unsigned int *JoltConstraintID_GetMutable_value(JoltConstraintID *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltConstraintID *)(_this)).value);
}

JoltConstraintID *JoltConstraintID_DefaultConstruct(void)
{
    return (JoltConstraintID *)new JoltConstraintID(JoltConstraintID());
}

JoltConstraintID *JoltConstraintID_DefaultConstructArray(size_t num_elems)
{
    return (JoltConstraintID *)(new JoltConstraintID[num_elems]{});
}

const JoltConstraintID *JoltConstraintID_OffsetPtr(const JoltConstraintID *ptr, ptrdiff_t i)
{
    return (const JoltConstraintID *)(((const JoltConstraintID *)ptr) + i);
}

JoltConstraintID *JoltConstraintID_OffsetMutablePtr(JoltConstraintID *ptr, ptrdiff_t i)
{
    return (JoltConstraintID *)(((JoltConstraintID *)ptr) + i);
}

JoltConstraintID *JoltConstraintID_ConstructFromAnother(const JoltConstraintID *_other)
{
    return (JoltConstraintID *)new JoltConstraintID(JoltConstraintID(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltConstraintID(*(JoltConstraintID *)_other))
    ));
}

void JoltConstraintID_Destroy(const JoltConstraintID *_this)
{
    delete ((const JoltConstraintID *)_this);
}

void JoltConstraintID_DestroyArray(const JoltConstraintID *_this)
{
    delete[] ((const JoltConstraintID *)_this);
}

JoltConstraintID *JoltConstraintID_AssignFromAnother(JoltConstraintID *_this, const JoltConstraintID *_other)
{
    return (JoltConstraintID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltConstraintID *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltConstraintID(*(JoltConstraintID *)_other))
    ));
}

bool JoltConstraintID_IsValid(const JoltConstraintID *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltConstraintID *)(_this)).IsValid();
}

JoltBodyInterface *JoltBodyInterface_ConstructFromAnother(const JoltBodyInterface *_other)
{
    return (JoltBodyInterface *)new JoltBodyInterface(JoltBodyInterface(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltBodyInterface(*(JoltBodyInterface *)_other))
    ));
}

const JoltBodyInterface *JoltBodyInterface_OffsetPtr(const JoltBodyInterface *ptr, ptrdiff_t i)
{
    return (const JoltBodyInterface *)(((const JoltBodyInterface *)ptr) + i);
}

JoltBodyInterface *JoltBodyInterface_OffsetMutablePtr(JoltBodyInterface *ptr, ptrdiff_t i)
{
    return (JoltBodyInterface *)(((JoltBodyInterface *)ptr) + i);
}

void JoltBodyInterface_Destroy(const JoltBodyInterface *_this)
{
    delete ((const JoltBodyInterface *)_this);
}

void JoltBodyInterface_DestroyArray(const JoltBodyInterface *_this)
{
    delete[] ((const JoltBodyInterface *)_this);
}

JoltBodyInterface *JoltBodyInterface_AssignFromAnother(JoltBodyInterface *_this, const JoltBodyInterface *_other)
{
    return (JoltBodyInterface *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltBodyInterface(*(JoltBodyInterface *)_other))
    ));
}

bool JoltBodyInterface_IsValid(const JoltBodyInterface *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).IsValid();
}

JoltBodyID *JoltBodyInterface_CreateBody(JoltBodyInterface *_this, JoltBodyCreationSettings *settings)
{
    return (JoltBodyID *)new JoltBodyID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).CreateBody(
        ((JoltBodyCreationSettings *)settings)
    ));
}

JoltBodyID *JoltBodyInterface_CreateBodyWithID(JoltBodyInterface *_this, const JoltBodyID *targetID, JoltBodyCreationSettings *settings)
{
    return (JoltBodyID *)new JoltBodyID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).CreateBodyWithID(
        ((targetID ? void() : MRBINDC_THROW("Parameter `targetID` can not be null.", void)), JoltBodyID(*(JoltBodyID *)targetID)),
        ((JoltBodyCreationSettings *)settings)
    ));
}

JoltBodyID *JoltBodyInterface_CreateAndAddBody(JoltBodyInterface *_this, JoltBodyCreationSettings *settings, int activation)
{
    return (JoltBodyID *)new JoltBodyID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).CreateAndAddBody(
        ((JoltBodyCreationSettings *)settings),
        activation
    ));
}

void JoltBodyInterface_AddBody(JoltBodyInterface *_this, const JoltBodyID *id, int activation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).AddBody(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        activation
    );
}

void JoltBodyInterface_RemoveBody(JoltBodyInterface *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).RemoveBody(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_DestroyBody(JoltBodyInterface *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).DestroyBody(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_RemoveAndDestroyBody(JoltBodyInterface *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).RemoveAndDestroyBody(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

bool JoltBodyInterface_IsAdded(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).IsAdded(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void *JoltBodyInterface_AddBodiesPrepare(JoltBodyInterface *_this, JoltBodyIDList *bodies)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).AddBodiesPrepare(
        ((JoltBodyIDList *)bodies)
    );
}

void JoltBodyInterface_AddBodiesFinalize(JoltBodyInterface *_this, JoltBodyIDList *bodies, void *addState, int activation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).AddBodiesFinalize(
        ((JoltBodyIDList *)bodies),
        addState,
        activation
    );
}

void JoltBodyInterface_AddBodiesAbort(JoltBodyInterface *_this, JoltBodyIDList *bodies, void *addState)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).AddBodiesAbort(
        ((JoltBodyIDList *)bodies),
        addState
    );
}

void JoltBodyInterface_RemoveBodies(JoltBodyInterface *_this, JoltBodyIDList *bodies)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).RemoveBodies(
        ((JoltBodyIDList *)bodies)
    );
}

void JoltBodyInterface_DestroyBodies(JoltBodyInterface *_this, JoltBodyIDList *bodies)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).DestroyBodies(
        ((JoltBodyIDList *)bodies)
    );
}

void JoltBodyInterface_SetShape(const JoltBodyInterface *_this, const JoltBodyID *id, JoltShape *shape, bool updateMassProperties, int activation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).SetShape(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        ((JoltShape *)shape),
        updateMassProperties,
        activation
    );
}

void JoltBodyInterface_NotifyShapeChanged(const JoltBodyInterface *_this, const JoltBodyID *id, double prevComX, double prevComY, double prevComZ, bool updateMassProperties, int activation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).NotifyShapeChanged(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        prevComX,
        prevComY,
        prevComZ,
        updateMassProperties,
        activation
    );
}

void JoltBodyInterface_SetPosition(JoltBodyInterface *_this, const JoltBodyID *id, double x, double y, double z, int activation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetPosition(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        x,
        y,
        z,
        activation
    );
}

JoltVec3 *JoltBodyInterface_GetPosition(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return (JoltVec3 *)new JoltVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetPosition(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

JoltVec3 *JoltBodyInterface_GetCenterOfMassPosition(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return (JoltVec3 *)new JoltVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetCenterOfMassPosition(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

void JoltBodyInterface_SetRotation(JoltBodyInterface *_this, const JoltBodyID *id, float qx, float qy, float qz, float qw, int activation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetRotation(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        qx,
        qy,
        qz,
        qw,
        activation
    );
}

JoltQuat *JoltBodyInterface_GetRotation(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return (JoltQuat *)new JoltQuat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetRotation(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

void JoltBodyInterface_GetPositionAndRotation(const JoltBodyInterface *_this, const JoltBodyID *id, JoltVec3 *outPosition, JoltQuat *outRotation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetPositionAndRotation(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        ((outPosition ? void() : MRBINDC_THROW("Parameter `outPosition` can not be null.", void)), *(JoltVec3 *)(outPosition)),
        ((outRotation ? void() : MRBINDC_THROW("Parameter `outRotation` can not be null.", void)), *(JoltQuat *)(outRotation))
    );
}

void JoltBodyInterface_SetPositionAndRotation(JoltBodyInterface *_this, const JoltBodyID *id, double x, double y, double z, float qx, float qy, float qz, float qw, int activation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetPositionAndRotation(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        x,
        y,
        z,
        qx,
        qy,
        qz,
        qw,
        activation
    );
}

void JoltBodyInterface_SetPositionAndRotationWhenChanged(JoltBodyInterface *_this, const JoltBodyID *id, double x, double y, double z, float qx, float qy, float qz, float qw, int activation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetPositionAndRotationWhenChanged(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        x,
        y,
        z,
        qx,
        qy,
        qz,
        qw,
        activation
    );
}

void JoltBodyInterface_MoveKinematic(JoltBodyInterface *_this, const JoltBodyID *id, double x, double y, double z, float qx, float qy, float qz, float qw, float deltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).MoveKinematic(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        x,
        y,
        z,
        qx,
        qy,
        qz,
        qw,
        deltaTime
    );
}

void JoltBodyInterface_SetPositionRotationAndVelocity(JoltBodyInterface *_this, const JoltBodyID *id, double x, double y, double z, float qx, float qy, float qz, float qw, float lvx, float lvy, float lvz, float avx, float avy, float avz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetPositionRotationAndVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        x,
        y,
        z,
        qx,
        qy,
        qz,
        qw,
        lvx,
        lvy,
        lvz,
        avx,
        avy,
        avz
    );
}

void JoltBodyInterface_SetLinearVelocity(JoltBodyInterface *_this, const JoltBodyID *id, float vx, float vy, float vz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetLinearVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        vx,
        vy,
        vz
    );
}

JoltVec3f *JoltBodyInterface_GetLinearVelocity(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return (JoltVec3f *)new JoltVec3f(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetLinearVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

void JoltBodyInterface_AddLinearVelocity(JoltBodyInterface *_this, const JoltBodyID *id, float vx, float vy, float vz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).AddLinearVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        vx,
        vy,
        vz
    );
}

void JoltBodyInterface_SetAngularVelocity(JoltBodyInterface *_this, const JoltBodyID *id, float vx, float vy, float vz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetAngularVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        vx,
        vy,
        vz
    );
}

JoltVec3f *JoltBodyInterface_GetAngularVelocity(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return (JoltVec3f *)new JoltVec3f(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetAngularVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

void JoltBodyInterface_SetLinearAndAngularVelocity(JoltBodyInterface *_this, const JoltBodyID *id, float lvx, float lvy, float lvz, float avx, float avy, float avz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetLinearAndAngularVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        lvx,
        lvy,
        lvz,
        avx,
        avy,
        avz
    );
}

void JoltBodyInterface_GetLinearAndAngularVelocity(const JoltBodyInterface *_this, const JoltBodyID *id, JoltVec3f *outLinear, JoltVec3f *outAngular)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetLinearAndAngularVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        ((outLinear ? void() : MRBINDC_THROW("Parameter `outLinear` can not be null.", void)), *(JoltVec3f *)(outLinear)),
        ((outAngular ? void() : MRBINDC_THROW("Parameter `outAngular` can not be null.", void)), *(JoltVec3f *)(outAngular))
    );
}

void JoltBodyInterface_AddLinearAndAngularVelocity(JoltBodyInterface *_this, const JoltBodyID *id, float lvx, float lvy, float lvz, float avx, float avy, float avz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).AddLinearAndAngularVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        lvx,
        lvy,
        lvz,
        avx,
        avy,
        avz
    );
}

JoltVec3f *JoltBodyInterface_GetPointVelocity(const JoltBodyInterface *_this, const JoltBodyID *id, double px, double py, double pz)
{
    return (JoltVec3f *)new JoltVec3f(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetPointVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        px,
        py,
        pz
    ));
}

void JoltBodyInterface_AddForce(JoltBodyInterface *_this, const JoltBodyID *id, float fx, float fy, float fz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).AddForce(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        fx,
        fy,
        fz
    );
}

void JoltBodyInterface_AddForceAtPosition(JoltBodyInterface *_this, const JoltBodyID *id, float fx, float fy, float fz, double px, double py, double pz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).AddForceAtPosition(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        fx,
        fy,
        fz,
        px,
        py,
        pz
    );
}

void JoltBodyInterface_AddTorque(JoltBodyInterface *_this, const JoltBodyID *id, float tx, float ty, float tz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).AddTorque(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        tx,
        ty,
        tz
    );
}

void JoltBodyInterface_AddForceAndTorque(JoltBodyInterface *_this, const JoltBodyID *id, float fx, float fy, float fz, float tx, float ty, float tz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).AddForceAndTorque(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        fx,
        fy,
        fz,
        tx,
        ty,
        tz
    );
}

void JoltBodyInterface_AddImpulse(JoltBodyInterface *_this, const JoltBodyID *id, float ix, float iy, float iz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).AddImpulse(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        ix,
        iy,
        iz
    );
}

void JoltBodyInterface_AddImpulseAtPosition(JoltBodyInterface *_this, const JoltBodyID *id, float ix, float iy, float iz, double px, double py, double pz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).AddImpulseAtPosition(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        ix,
        iy,
        iz,
        px,
        py,
        pz
    );
}

void JoltBodyInterface_AddAngularImpulse(JoltBodyInterface *_this, const JoltBodyID *id, float ix, float iy, float iz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).AddAngularImpulse(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        ix,
        iy,
        iz
    );
}

bool JoltBodyInterface_ApplyBuoyancyImpulse(JoltBodyInterface *_this, const JoltBodyID *id, double surfacePosX, double surfacePosY, double surfacePosZ, float surfaceNX, float surfaceNY, float surfaceNZ, float buoyancy, float linearDrag, float angularDrag, float fluidVX, float fluidVY, float fluidVZ, float gravX, float gravY, float gravZ, float deltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).ApplyBuoyancyImpulse(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        surfacePosX,
        surfacePosY,
        surfacePosZ,
        surfaceNX,
        surfaceNY,
        surfaceNZ,
        buoyancy,
        linearDrag,
        angularDrag,
        fluidVX,
        fluidVY,
        fluidVZ,
        gravX,
        gravY,
        gravZ,
        deltaTime
    );
}

int JoltBodyInterface_GetBodyType(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetBodyType(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_SetMotionType(JoltBodyInterface *_this, const JoltBodyID *id, int motionType, int activation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetMotionType(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        motionType,
        activation
    );
}

int JoltBodyInterface_GetMotionType(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetMotionType(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_SetMotionQuality(JoltBodyInterface *_this, const JoltBodyID *id, int motionQuality)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetMotionQuality(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        motionQuality
    );
}

int JoltBodyInterface_GetMotionQuality(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetMotionQuality(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_SetObjectLayer(JoltBodyInterface *_this, const JoltBodyID *id, unsigned int layer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetObjectLayer(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        layer
    );
}

unsigned int JoltBodyInterface_GetObjectLayer(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetObjectLayer(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_SetFriction(JoltBodyInterface *_this, const JoltBodyID *id, float friction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetFriction(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        friction
    );
}

float JoltBodyInterface_GetFriction(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetFriction(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_SetRestitution(JoltBodyInterface *_this, const JoltBodyID *id, float restitution)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetRestitution(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        restitution
    );
}

float JoltBodyInterface_GetRestitution(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetRestitution(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_SetGravityFactor(JoltBodyInterface *_this, const JoltBodyID *id, float factor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetGravityFactor(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        factor
    );
}

float JoltBodyInterface_GetGravityFactor(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetGravityFactor(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_SetMaxLinearVelocity(JoltBodyInterface *_this, const JoltBodyID *id, float v)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetMaxLinearVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        v
    );
}

float JoltBodyInterface_GetMaxLinearVelocity(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetMaxLinearVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_SetMaxAngularVelocity(JoltBodyInterface *_this, const JoltBodyID *id, float v)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetMaxAngularVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        v
    );
}

float JoltBodyInterface_GetMaxAngularVelocity(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetMaxAngularVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_SetIsSensor(JoltBodyInterface *_this, const JoltBodyID *id, bool isSensor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetIsSensor(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        isSensor
    );
}

bool JoltBodyInterface_IsSensor(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).IsSensor(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_SetUseManifoldReduction(JoltBodyInterface *_this, const JoltBodyID *id, bool useReduction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetUseManifoldReduction(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        useReduction
    );
}

bool JoltBodyInterface_GetUseManifoldReduction(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetUseManifoldReduction(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

unsigned long long JoltBodyInterface_GetUserData(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetUserData(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_SetUserData(JoltBodyInterface *_this, const JoltBodyID *id, unsigned long long userData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetUserData(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        userData
    );
}

void JoltBodyInterface_ActivateBody(JoltBodyInterface *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).ActivateBody(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_ActivateBodies(JoltBodyInterface *_this, JoltBodyIDList *bodies)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).ActivateBodies(
        ((JoltBodyIDList *)bodies)
    );
}

void JoltBodyInterface_DeactivateBody(JoltBodyInterface *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).DeactivateBody(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_DeactivateBodies(JoltBodyInterface *_this, JoltBodyIDList *bodies)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).DeactivateBodies(
        ((JoltBodyIDList *)bodies)
    );
}

bool JoltBodyInterface_IsActive(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).IsActive(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_ResetSleepTimer(JoltBodyInterface *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).ResetSleepTimer(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltBodyInterface_InvalidateContactCache(JoltBodyInterface *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).InvalidateContactCache(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

JoltRMat44 *JoltBodyInterface_GetWorldTransform(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return (JoltRMat44 *)new JoltRMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetWorldTransform(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

JoltRMat44 *JoltBodyInterface_GetCenterOfMassTransform(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return (JoltRMat44 *)new JoltRMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetCenterOfMassTransform(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

JoltMat44 *JoltBodyInterface_GetInverseInertia(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return (JoltMat44 *)new JoltMat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetInverseInertia(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

void JoltBodyInterface_SetCollisionGroup(JoltBodyInterface *_this, const JoltBodyID *id, const JoltCollisionGroup *group)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).SetCollisionGroup(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        ((group ? void() : MRBINDC_THROW("Parameter `group` can not be null.", void)), *(const JoltCollisionGroup *)(group))
    );
}

JoltCollisionGroup *JoltBodyInterface_GetCollisionGroup(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return (JoltCollisionGroup *)new JoltCollisionGroup(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetCollisionGroup(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

void JoltBodyInterface_ActivateBodiesInAABox(JoltBodyInterface *_this, const JoltAABox *box)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).ActivateBodiesInAABox(
        ((box ? void() : MRBINDC_THROW("Parameter `box` can not be null.", void)), *(const JoltAABox *)(box))
    );
}

JoltPhysicsMaterial *JoltBodyInterface_GetMaterial(const JoltBodyInterface *_this, const JoltBodyID *id)
{
    return (JoltPhysicsMaterial *)new JoltPhysicsMaterial(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyInterface *)(_this)).GetMaterial(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

void JoltBodyInterface_ActivateConstraint(JoltBodyInterface *_this, const JoltTwoBodyConstraint *constraint)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).ActivateConstraint(
        ((constraint ? void() : MRBINDC_THROW("Parameter `constraint` can not be null.", void)), *(const JoltTwoBodyConstraint *)(constraint))
    );
}

JoltBodyID *JoltBodyInterface_CreateSoftBody(JoltBodyInterface *_this, JoltSoftBodyCreationSettings *settings)
{
    return (JoltBodyID *)new JoltBodyID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).CreateSoftBody(
        ((JoltSoftBodyCreationSettings *)settings)
    ));
}

JoltBodyID *JoltBodyInterface_CreateAndAddSoftBody(JoltBodyInterface *_this, JoltSoftBodyCreationSettings *settings, int activation)
{
    return (JoltBodyID *)new JoltBodyID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyInterface *)(_this)).CreateAndAddSoftBody(
        ((JoltSoftBodyCreationSettings *)settings),
        activation
    ));
}

JoltShape *JoltShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JoltShape);
    return (JoltShape *)new JoltShape(JoltShape(
        (MRBINDC_CLASSARG_COPY(_other, (JoltShape), JoltShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JoltShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JoltShape) MRBINDC_CLASSARG_END(_other, JoltShape))
    ));
}

const JoltShape *JoltShape_OffsetPtr(const JoltShape *ptr, ptrdiff_t i)
{
    return (const JoltShape *)(((const JoltShape *)ptr) + i);
}

JoltShape *JoltShape_OffsetMutablePtr(JoltShape *ptr, ptrdiff_t i)
{
    return (JoltShape *)(((JoltShape *)ptr) + i);
}

void JoltShape_Destroy(const JoltShape *_this)
{
    delete ((const JoltShape *)_this);
}

void JoltShape_DestroyArray(const JoltShape *_this)
{
    delete[] ((const JoltShape *)_this);
}

JoltShape *JoltShape_AssignFromAnother(JoltShape *_this, Jolt_PassBy _other_pass_by, JoltShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JoltShape);
    return (JoltShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltShape *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_COPY(_other, (JoltShape), JoltShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JoltShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JoltShape) MRBINDC_CLASSARG_END(_other, JoltShape)))
    ));
}

void JoltShape_Release(JoltShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltShape *)(_this)).Release();
}

bool JoltShape_IsValid(const JoltShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltShape *)(_this)).IsValid();
}

void *JoltShape_getHandle(const JoltShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltShape *)(_this)).getHandle();
}

JoltBoxShape *JoltBoxShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltBoxShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JoltBoxShape);
    return (JoltBoxShape *)new JoltBoxShape(JoltBoxShape(
        (MRBINDC_CLASSARG_COPY(_other, (JoltBoxShape), JoltBoxShape) MRBINDC_CLASSARG_MOVE(_other, (JoltBoxShape), JoltBoxShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JoltBoxShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JoltBoxShape) MRBINDC_CLASSARG_END(_other, JoltBoxShape))
    ));
}

const JoltBoxShape *JoltBoxShape_OffsetPtr(const JoltBoxShape *ptr, ptrdiff_t i)
{
    return (const JoltBoxShape *)(((const JoltBoxShape *)ptr) + i);
}

JoltBoxShape *JoltBoxShape_OffsetMutablePtr(JoltBoxShape *ptr, ptrdiff_t i)
{
    return (JoltBoxShape *)(((JoltBoxShape *)ptr) + i);
}

const JoltShape *JoltBoxShape_UpcastTo_JoltShape(const JoltBoxShape *object)
{
    return (const JoltShape *)(static_cast<const JoltShape *>(
        ((const JoltBoxShape *)object)
    ));
}

JoltShape *JoltBoxShape_MutableUpcastTo_JoltShape(JoltBoxShape *object)
{
    return (JoltShape *)(static_cast<JoltShape *>(
        ((JoltBoxShape *)object)
    ));
}

const JoltBoxShape *JoltBoxShape_StaticDowncastFrom_JoltShape(const JoltShape *object)
{
    return (const JoltBoxShape *)(static_cast<const JoltBoxShape *>(
        ((const JoltShape *)object)
    ));
}

JoltBoxShape *JoltBoxShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object)
{
    return (JoltBoxShape *)(static_cast<JoltBoxShape *>(
        ((JoltShape *)object)
    ));
}

const JoltBoxShape *JoltBoxShape_DynamicDowncastFrom_JoltShape(const JoltShape *object)
{
    return (const JoltBoxShape *)(dynamic_cast<const JoltBoxShape *>(
        ((const JoltShape *)object)
    ));
}

JoltBoxShape *JoltBoxShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object)
{
    return (JoltBoxShape *)(dynamic_cast<JoltBoxShape *>(
        ((JoltShape *)object)
    ));
}

const JoltBoxShape *JoltBoxShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object)
{
    return (const JoltBoxShape *)std::addressof(dynamic_cast<const JoltBoxShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const JoltShape *)(object))
    ));
}

JoltBoxShape *JoltBoxShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object)
{
    return (JoltBoxShape *)std::addressof(dynamic_cast<JoltBoxShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(JoltShape *)(object))
    ));
}

JoltBoxShape *JoltBoxShape_Construct_4(double halfX, double halfY, double halfZ, float convexRadius)
{
    return (JoltBoxShape *)new JoltBoxShape(JoltBoxShape(
        halfX,
        halfY,
        halfZ,
        convexRadius
    ));
}

JoltBoxShape *JoltBoxShape_Construct_3(double halfX, double halfY, double halfZ)
{
    return (JoltBoxShape *)new JoltBoxShape(JoltBoxShape(
        halfX,
        halfY,
        halfZ
    ));
}

void JoltBoxShape_Destroy(const JoltBoxShape *_this)
{
    delete ((const JoltBoxShape *)_this);
}

void JoltBoxShape_DestroyArray(const JoltBoxShape *_this)
{
    delete[] ((const JoltBoxShape *)_this);
}

JoltBoxShape *JoltBoxShape_AssignFromAnother(JoltBoxShape *_this, Jolt_PassBy _other_pass_by, JoltBoxShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JoltBoxShape);
    return (JoltBoxShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBoxShape *)(_this)).operator=(
        (MRBINDC_CLASSARG_COPY(_other, (JoltBoxShape), JoltBoxShape) MRBINDC_CLASSARG_MOVE(_other, (JoltBoxShape), JoltBoxShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JoltBoxShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JoltBoxShape) MRBINDC_CLASSARG_END(_other, JoltBoxShape))
    ));
}

void JoltBoxShape_Release(JoltBoxShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBoxShape *)(_this)).Release();
}

bool JoltBoxShape_IsValid(const JoltBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBoxShape *)(_this)).IsValid();
}

void *JoltBoxShape_getHandle(const JoltBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBoxShape *)(_this)).getHandle();
}

JoltSphereShape *JoltSphereShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltSphereShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JoltSphereShape);
    return (JoltSphereShape *)new JoltSphereShape(JoltSphereShape(
        (MRBINDC_CLASSARG_COPY(_other, (JoltSphereShape), JoltSphereShape) MRBINDC_CLASSARG_MOVE(_other, (JoltSphereShape), JoltSphereShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JoltSphereShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JoltSphereShape) MRBINDC_CLASSARG_END(_other, JoltSphereShape))
    ));
}

const JoltSphereShape *JoltSphereShape_OffsetPtr(const JoltSphereShape *ptr, ptrdiff_t i)
{
    return (const JoltSphereShape *)(((const JoltSphereShape *)ptr) + i);
}

JoltSphereShape *JoltSphereShape_OffsetMutablePtr(JoltSphereShape *ptr, ptrdiff_t i)
{
    return (JoltSphereShape *)(((JoltSphereShape *)ptr) + i);
}

const JoltShape *JoltSphereShape_UpcastTo_JoltShape(const JoltSphereShape *object)
{
    return (const JoltShape *)(static_cast<const JoltShape *>(
        ((const JoltSphereShape *)object)
    ));
}

JoltShape *JoltSphereShape_MutableUpcastTo_JoltShape(JoltSphereShape *object)
{
    return (JoltShape *)(static_cast<JoltShape *>(
        ((JoltSphereShape *)object)
    ));
}

const JoltSphereShape *JoltSphereShape_StaticDowncastFrom_JoltShape(const JoltShape *object)
{
    return (const JoltSphereShape *)(static_cast<const JoltSphereShape *>(
        ((const JoltShape *)object)
    ));
}

JoltSphereShape *JoltSphereShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object)
{
    return (JoltSphereShape *)(static_cast<JoltSphereShape *>(
        ((JoltShape *)object)
    ));
}

const JoltSphereShape *JoltSphereShape_DynamicDowncastFrom_JoltShape(const JoltShape *object)
{
    return (const JoltSphereShape *)(dynamic_cast<const JoltSphereShape *>(
        ((const JoltShape *)object)
    ));
}

JoltSphereShape *JoltSphereShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object)
{
    return (JoltSphereShape *)(dynamic_cast<JoltSphereShape *>(
        ((JoltShape *)object)
    ));
}

const JoltSphereShape *JoltSphereShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object)
{
    return (const JoltSphereShape *)std::addressof(dynamic_cast<const JoltSphereShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const JoltShape *)(object))
    ));
}

JoltSphereShape *JoltSphereShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object)
{
    return (JoltSphereShape *)std::addressof(dynamic_cast<JoltSphereShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(JoltShape *)(object))
    ));
}

JoltSphereShape *JoltSphereShape_Construct(float radius)
{
    return (JoltSphereShape *)new JoltSphereShape(JoltSphereShape(
        radius
    ));
}

void JoltSphereShape_Destroy(const JoltSphereShape *_this)
{
    delete ((const JoltSphereShape *)_this);
}

void JoltSphereShape_DestroyArray(const JoltSphereShape *_this)
{
    delete[] ((const JoltSphereShape *)_this);
}

JoltSphereShape *JoltSphereShape_AssignFromAnother(JoltSphereShape *_this, Jolt_PassBy _other_pass_by, JoltSphereShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JoltSphereShape);
    return (JoltSphereShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSphereShape *)(_this)).operator=(
        (MRBINDC_CLASSARG_COPY(_other, (JoltSphereShape), JoltSphereShape) MRBINDC_CLASSARG_MOVE(_other, (JoltSphereShape), JoltSphereShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JoltSphereShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JoltSphereShape) MRBINDC_CLASSARG_END(_other, JoltSphereShape))
    ));
}

void JoltSphereShape_Release(JoltSphereShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSphereShape *)(_this)).Release();
}

bool JoltSphereShape_IsValid(const JoltSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltSphereShape *)(_this)).IsValid();
}

void *JoltSphereShape_getHandle(const JoltSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltSphereShape *)(_this)).getHandle();
}

JoltCapsuleShape *JoltCapsuleShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltCapsuleShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JoltCapsuleShape);
    return (JoltCapsuleShape *)new JoltCapsuleShape(JoltCapsuleShape(
        (MRBINDC_CLASSARG_COPY(_other, (JoltCapsuleShape), JoltCapsuleShape) MRBINDC_CLASSARG_MOVE(_other, (JoltCapsuleShape), JoltCapsuleShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JoltCapsuleShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JoltCapsuleShape) MRBINDC_CLASSARG_END(_other, JoltCapsuleShape))
    ));
}

const JoltCapsuleShape *JoltCapsuleShape_OffsetPtr(const JoltCapsuleShape *ptr, ptrdiff_t i)
{
    return (const JoltCapsuleShape *)(((const JoltCapsuleShape *)ptr) + i);
}

JoltCapsuleShape *JoltCapsuleShape_OffsetMutablePtr(JoltCapsuleShape *ptr, ptrdiff_t i)
{
    return (JoltCapsuleShape *)(((JoltCapsuleShape *)ptr) + i);
}

const JoltShape *JoltCapsuleShape_UpcastTo_JoltShape(const JoltCapsuleShape *object)
{
    return (const JoltShape *)(static_cast<const JoltShape *>(
        ((const JoltCapsuleShape *)object)
    ));
}

JoltShape *JoltCapsuleShape_MutableUpcastTo_JoltShape(JoltCapsuleShape *object)
{
    return (JoltShape *)(static_cast<JoltShape *>(
        ((JoltCapsuleShape *)object)
    ));
}

const JoltCapsuleShape *JoltCapsuleShape_StaticDowncastFrom_JoltShape(const JoltShape *object)
{
    return (const JoltCapsuleShape *)(static_cast<const JoltCapsuleShape *>(
        ((const JoltShape *)object)
    ));
}

JoltCapsuleShape *JoltCapsuleShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object)
{
    return (JoltCapsuleShape *)(static_cast<JoltCapsuleShape *>(
        ((JoltShape *)object)
    ));
}

const JoltCapsuleShape *JoltCapsuleShape_DynamicDowncastFrom_JoltShape(const JoltShape *object)
{
    return (const JoltCapsuleShape *)(dynamic_cast<const JoltCapsuleShape *>(
        ((const JoltShape *)object)
    ));
}

JoltCapsuleShape *JoltCapsuleShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object)
{
    return (JoltCapsuleShape *)(dynamic_cast<JoltCapsuleShape *>(
        ((JoltShape *)object)
    ));
}

const JoltCapsuleShape *JoltCapsuleShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object)
{
    return (const JoltCapsuleShape *)std::addressof(dynamic_cast<const JoltCapsuleShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const JoltShape *)(object))
    ));
}

JoltCapsuleShape *JoltCapsuleShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object)
{
    return (JoltCapsuleShape *)std::addressof(dynamic_cast<JoltCapsuleShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(JoltShape *)(object))
    ));
}

JoltCapsuleShape *JoltCapsuleShape_Construct(float halfHeight, float radius)
{
    return (JoltCapsuleShape *)new JoltCapsuleShape(JoltCapsuleShape(
        halfHeight,
        radius
    ));
}

void JoltCapsuleShape_Destroy(const JoltCapsuleShape *_this)
{
    delete ((const JoltCapsuleShape *)_this);
}

void JoltCapsuleShape_DestroyArray(const JoltCapsuleShape *_this)
{
    delete[] ((const JoltCapsuleShape *)_this);
}

JoltCapsuleShape *JoltCapsuleShape_AssignFromAnother(JoltCapsuleShape *_this, Jolt_PassBy _other_pass_by, JoltCapsuleShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JoltCapsuleShape);
    return (JoltCapsuleShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltCapsuleShape *)(_this)).operator=(
        (MRBINDC_CLASSARG_COPY(_other, (JoltCapsuleShape), JoltCapsuleShape) MRBINDC_CLASSARG_MOVE(_other, (JoltCapsuleShape), JoltCapsuleShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JoltCapsuleShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JoltCapsuleShape) MRBINDC_CLASSARG_END(_other, JoltCapsuleShape))
    ));
}

void JoltCapsuleShape_Release(JoltCapsuleShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltCapsuleShape *)(_this)).Release();
}

bool JoltCapsuleShape_IsValid(const JoltCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltCapsuleShape *)(_this)).IsValid();
}

void *JoltCapsuleShape_getHandle(const JoltCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltCapsuleShape *)(_this)).getHandle();
}

JoltCylinderShape *JoltCylinderShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltCylinderShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JoltCylinderShape);
    return (JoltCylinderShape *)new JoltCylinderShape(JoltCylinderShape(
        (MRBINDC_CLASSARG_COPY(_other, (JoltCylinderShape), JoltCylinderShape) MRBINDC_CLASSARG_MOVE(_other, (JoltCylinderShape), JoltCylinderShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JoltCylinderShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JoltCylinderShape) MRBINDC_CLASSARG_END(_other, JoltCylinderShape))
    ));
}

const JoltCylinderShape *JoltCylinderShape_OffsetPtr(const JoltCylinderShape *ptr, ptrdiff_t i)
{
    return (const JoltCylinderShape *)(((const JoltCylinderShape *)ptr) + i);
}

JoltCylinderShape *JoltCylinderShape_OffsetMutablePtr(JoltCylinderShape *ptr, ptrdiff_t i)
{
    return (JoltCylinderShape *)(((JoltCylinderShape *)ptr) + i);
}

const JoltShape *JoltCylinderShape_UpcastTo_JoltShape(const JoltCylinderShape *object)
{
    return (const JoltShape *)(static_cast<const JoltShape *>(
        ((const JoltCylinderShape *)object)
    ));
}

JoltShape *JoltCylinderShape_MutableUpcastTo_JoltShape(JoltCylinderShape *object)
{
    return (JoltShape *)(static_cast<JoltShape *>(
        ((JoltCylinderShape *)object)
    ));
}

const JoltCylinderShape *JoltCylinderShape_StaticDowncastFrom_JoltShape(const JoltShape *object)
{
    return (const JoltCylinderShape *)(static_cast<const JoltCylinderShape *>(
        ((const JoltShape *)object)
    ));
}

JoltCylinderShape *JoltCylinderShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object)
{
    return (JoltCylinderShape *)(static_cast<JoltCylinderShape *>(
        ((JoltShape *)object)
    ));
}

const JoltCylinderShape *JoltCylinderShape_DynamicDowncastFrom_JoltShape(const JoltShape *object)
{
    return (const JoltCylinderShape *)(dynamic_cast<const JoltCylinderShape *>(
        ((const JoltShape *)object)
    ));
}

JoltCylinderShape *JoltCylinderShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object)
{
    return (JoltCylinderShape *)(dynamic_cast<JoltCylinderShape *>(
        ((JoltShape *)object)
    ));
}

const JoltCylinderShape *JoltCylinderShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object)
{
    return (const JoltCylinderShape *)std::addressof(dynamic_cast<const JoltCylinderShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const JoltShape *)(object))
    ));
}

JoltCylinderShape *JoltCylinderShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object)
{
    return (JoltCylinderShape *)std::addressof(dynamic_cast<JoltCylinderShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(JoltShape *)(object))
    ));
}

JoltCylinderShape *JoltCylinderShape_Construct_3(float halfHeight, float radius, float convexRadius)
{
    return (JoltCylinderShape *)new JoltCylinderShape(JoltCylinderShape(
        halfHeight,
        radius,
        convexRadius
    ));
}

JoltCylinderShape *JoltCylinderShape_Construct_2(float halfHeight, float radius)
{
    return (JoltCylinderShape *)new JoltCylinderShape(JoltCylinderShape(
        halfHeight,
        radius
    ));
}

void JoltCylinderShape_Destroy(const JoltCylinderShape *_this)
{
    delete ((const JoltCylinderShape *)_this);
}

void JoltCylinderShape_DestroyArray(const JoltCylinderShape *_this)
{
    delete[] ((const JoltCylinderShape *)_this);
}

JoltCylinderShape *JoltCylinderShape_AssignFromAnother(JoltCylinderShape *_this, Jolt_PassBy _other_pass_by, JoltCylinderShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JoltCylinderShape);
    return (JoltCylinderShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltCylinderShape *)(_this)).operator=(
        (MRBINDC_CLASSARG_COPY(_other, (JoltCylinderShape), JoltCylinderShape) MRBINDC_CLASSARG_MOVE(_other, (JoltCylinderShape), JoltCylinderShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JoltCylinderShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JoltCylinderShape) MRBINDC_CLASSARG_END(_other, JoltCylinderShape))
    ));
}

void JoltCylinderShape_Release(JoltCylinderShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltCylinderShape *)(_this)).Release();
}

bool JoltCylinderShape_IsValid(const JoltCylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltCylinderShape *)(_this)).IsValid();
}

void *JoltCylinderShape_getHandle(const JoltCylinderShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltCylinderShape *)(_this)).getHandle();
}

JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_ConstructFromAnother(Jolt_PassBy _other_pass_by, JoltRotatedTranslatedShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JoltRotatedTranslatedShape);
    return (JoltRotatedTranslatedShape *)new JoltRotatedTranslatedShape(JoltRotatedTranslatedShape(
        (MRBINDC_CLASSARG_COPY(_other, (JoltRotatedTranslatedShape), JoltRotatedTranslatedShape) MRBINDC_CLASSARG_MOVE(_other, (JoltRotatedTranslatedShape), JoltRotatedTranslatedShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JoltRotatedTranslatedShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JoltRotatedTranslatedShape) MRBINDC_CLASSARG_END(_other, JoltRotatedTranslatedShape))
    ));
}

const JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_OffsetPtr(const JoltRotatedTranslatedShape *ptr, ptrdiff_t i)
{
    return (const JoltRotatedTranslatedShape *)(((const JoltRotatedTranslatedShape *)ptr) + i);
}

JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_OffsetMutablePtr(JoltRotatedTranslatedShape *ptr, ptrdiff_t i)
{
    return (JoltRotatedTranslatedShape *)(((JoltRotatedTranslatedShape *)ptr) + i);
}

const JoltShape *JoltRotatedTranslatedShape_UpcastTo_JoltShape(const JoltRotatedTranslatedShape *object)
{
    return (const JoltShape *)(static_cast<const JoltShape *>(
        ((const JoltRotatedTranslatedShape *)object)
    ));
}

JoltShape *JoltRotatedTranslatedShape_MutableUpcastTo_JoltShape(JoltRotatedTranslatedShape *object)
{
    return (JoltShape *)(static_cast<JoltShape *>(
        ((JoltRotatedTranslatedShape *)object)
    ));
}

const JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_StaticDowncastFrom_JoltShape(const JoltShape *object)
{
    return (const JoltRotatedTranslatedShape *)(static_cast<const JoltRotatedTranslatedShape *>(
        ((const JoltShape *)object)
    ));
}

JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_MutableStaticDowncastFrom_JoltShape(JoltShape *object)
{
    return (JoltRotatedTranslatedShape *)(static_cast<JoltRotatedTranslatedShape *>(
        ((JoltShape *)object)
    ));
}

const JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_DynamicDowncastFrom_JoltShape(const JoltShape *object)
{
    return (const JoltRotatedTranslatedShape *)(dynamic_cast<const JoltRotatedTranslatedShape *>(
        ((const JoltShape *)object)
    ));
}

JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_MutableDynamicDowncastFrom_JoltShape(JoltShape *object)
{
    return (JoltRotatedTranslatedShape *)(dynamic_cast<JoltRotatedTranslatedShape *>(
        ((JoltShape *)object)
    ));
}

const JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_DynamicDowncastFromOrFail_JoltShape(const JoltShape *object)
{
    return (const JoltRotatedTranslatedShape *)std::addressof(dynamic_cast<const JoltRotatedTranslatedShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const JoltShape *)(object))
    ));
}

JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_MutableDynamicDowncastFromOrFail_JoltShape(JoltShape *object)
{
    return (JoltRotatedTranslatedShape *)std::addressof(dynamic_cast<JoltRotatedTranslatedShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(JoltShape *)(object))
    ));
}

JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_Construct(JoltShape *inner, double posX, double posY, double posZ, float qx, float qy, float qz, float qw)
{
    return (JoltRotatedTranslatedShape *)new JoltRotatedTranslatedShape(JoltRotatedTranslatedShape(
        ((JoltShape *)inner),
        posX,
        posY,
        posZ,
        qx,
        qy,
        qz,
        qw
    ));
}

void JoltRotatedTranslatedShape_Destroy(const JoltRotatedTranslatedShape *_this)
{
    delete ((const JoltRotatedTranslatedShape *)_this);
}

void JoltRotatedTranslatedShape_DestroyArray(const JoltRotatedTranslatedShape *_this)
{
    delete[] ((const JoltRotatedTranslatedShape *)_this);
}

JoltRotatedTranslatedShape *JoltRotatedTranslatedShape_AssignFromAnother(JoltRotatedTranslatedShape *_this, Jolt_PassBy _other_pass_by, JoltRotatedTranslatedShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JoltRotatedTranslatedShape);
    return (JoltRotatedTranslatedShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRotatedTranslatedShape *)(_this)).operator=(
        (MRBINDC_CLASSARG_COPY(_other, (JoltRotatedTranslatedShape), JoltRotatedTranslatedShape) MRBINDC_CLASSARG_MOVE(_other, (JoltRotatedTranslatedShape), JoltRotatedTranslatedShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JoltRotatedTranslatedShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JoltRotatedTranslatedShape) MRBINDC_CLASSARG_END(_other, JoltRotatedTranslatedShape))
    ));
}

void JoltRotatedTranslatedShape_Release(JoltRotatedTranslatedShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltRotatedTranslatedShape *)(_this)).Release();
}

bool JoltRotatedTranslatedShape_IsValid(const JoltRotatedTranslatedShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRotatedTranslatedShape *)(_this)).IsValid();
}

void *JoltRotatedTranslatedShape_getHandle(const JoltRotatedTranslatedShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltRotatedTranslatedShape *)(_this)).getHandle();
}

void *const *JoltBodyCreationSettings_Get_mHandle(const JoltBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltBodyCreationSettings *)(_this)).mHandle);
}

void JoltBodyCreationSettings_Set_mHandle(JoltBodyCreationSettings *_this, void *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyCreationSettings *)(_this)).mHandle = value;
}

void **JoltBodyCreationSettings_GetMutable_mHandle(JoltBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyCreationSettings *)(_this)).mHandle);
}

JoltBodyCreationSettings *JoltBodyCreationSettings_ConstructFromAnother(const JoltBodyCreationSettings *_other)
{
    return (JoltBodyCreationSettings *)new JoltBodyCreationSettings(JoltBodyCreationSettings(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltBodyCreationSettings(*(JoltBodyCreationSettings *)_other))
    ));
}

const JoltBodyCreationSettings *JoltBodyCreationSettings_OffsetPtr(const JoltBodyCreationSettings *ptr, ptrdiff_t i)
{
    return (const JoltBodyCreationSettings *)(((const JoltBodyCreationSettings *)ptr) + i);
}

JoltBodyCreationSettings *JoltBodyCreationSettings_OffsetMutablePtr(JoltBodyCreationSettings *ptr, ptrdiff_t i)
{
    return (JoltBodyCreationSettings *)(((JoltBodyCreationSettings *)ptr) + i);
}

JoltBodyCreationSettings *JoltBodyCreationSettings_Construct_10(JoltShape *shape, double posX, double posY, double posZ, float qx, float qy, float qz, float qw, int motionType, unsigned int objectLayer)
{
    return (JoltBodyCreationSettings *)new JoltBodyCreationSettings(JoltBodyCreationSettings(
        ((JoltShape *)shape),
        posX,
        posY,
        posZ,
        qx,
        qy,
        qz,
        qw,
        motionType,
        objectLayer
    ));
}

JoltBodyCreationSettings *JoltBodyCreationSettings_Construct_6(JoltShape *shape, double posX, double posY, double posZ, int motionType, unsigned int objectLayer)
{
    return (JoltBodyCreationSettings *)new JoltBodyCreationSettings(JoltBodyCreationSettings(
        ((JoltShape *)shape),
        posX,
        posY,
        posZ,
        motionType,
        objectLayer
    ));
}

void JoltBodyCreationSettings_Destroy(const JoltBodyCreationSettings *_this)
{
    delete ((const JoltBodyCreationSettings *)_this);
}

void JoltBodyCreationSettings_DestroyArray(const JoltBodyCreationSettings *_this)
{
    delete[] ((const JoltBodyCreationSettings *)_this);
}

JoltBodyCreationSettings *JoltBodyCreationSettings_AssignFromAnother(JoltBodyCreationSettings *_this, const JoltBodyCreationSettings *_other)
{
    return (JoltBodyCreationSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyCreationSettings *)(_this)).operator=(
        mrbindc_details::unmove(((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltBodyCreationSettings(*(JoltBodyCreationSettings *)_other)))
    ));
}

void JoltBodyCreationSettings_SetPosition(JoltBodyCreationSettings *_this, double x, double y, double z)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyCreationSettings *)(_this)).SetPosition(
        x,
        y,
        z
    );
}

void JoltBodyCreationSettings_SetRotation(JoltBodyCreationSettings *_this, float qx, float qy, float qz, float qw)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyCreationSettings *)(_this)).SetRotation(
        qx,
        qy,
        qz,
        qw
    );
}

void JoltBodyCreationSettings_SetLinearVelocity(JoltBodyCreationSettings *_this, float vx, float vy, float vz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyCreationSettings *)(_this)).SetLinearVelocity(
        vx,
        vy,
        vz
    );
}

void JoltBodyCreationSettings_SetAngularVelocity(JoltBodyCreationSettings *_this, float vx, float vy, float vz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyCreationSettings *)(_this)).SetAngularVelocity(
        vx,
        vy,
        vz
    );
}

void JoltBodyCreationSettings_SetFriction(JoltBodyCreationSettings *_this, float f)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyCreationSettings *)(_this)).SetFriction(
        f
    );
}

void JoltBodyCreationSettings_SetRestitution(JoltBodyCreationSettings *_this, float r)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyCreationSettings *)(_this)).SetRestitution(
        r
    );
}

void JoltBodyCreationSettings_SetGravityFactor(JoltBodyCreationSettings *_this, float f)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyCreationSettings *)(_this)).SetGravityFactor(
        f
    );
}

void JoltBodyCreationSettings_SetIsSensor(JoltBodyCreationSettings *_this, bool isSensor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyCreationSettings *)(_this)).SetIsSensor(
        isSensor
    );
}

void JoltBodyCreationSettings_SetObjectLayer(JoltBodyCreationSettings *_this, unsigned int layer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltBodyCreationSettings *)(_this)).SetObjectLayer(
        layer
    );
}

void *const *JoltSoftBodySharedSettings_Get_mHandle(const JoltSoftBodySharedSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltSoftBodySharedSettings *)(_this)).mHandle);
}

void JoltSoftBodySharedSettings_Set_mHandle(JoltSoftBodySharedSettings *_this, void *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodySharedSettings *)(_this)).mHandle = value;
}

void **JoltSoftBodySharedSettings_GetMutable_mHandle(JoltSoftBodySharedSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodySharedSettings *)(_this)).mHandle);
}

JoltSoftBodySharedSettings *JoltSoftBodySharedSettings_DefaultConstruct(void)
{
    return (JoltSoftBodySharedSettings *)new JoltSoftBodySharedSettings(JoltSoftBodySharedSettings());
}

JoltSoftBodySharedSettings *JoltSoftBodySharedSettings_DefaultConstructArray(size_t num_elems)
{
    return (JoltSoftBodySharedSettings *)(new JoltSoftBodySharedSettings[num_elems]{});
}

const JoltSoftBodySharedSettings *JoltSoftBodySharedSettings_OffsetPtr(const JoltSoftBodySharedSettings *ptr, ptrdiff_t i)
{
    return (const JoltSoftBodySharedSettings *)(((const JoltSoftBodySharedSettings *)ptr) + i);
}

JoltSoftBodySharedSettings *JoltSoftBodySharedSettings_OffsetMutablePtr(JoltSoftBodySharedSettings *ptr, ptrdiff_t i)
{
    return (JoltSoftBodySharedSettings *)(((JoltSoftBodySharedSettings *)ptr) + i);
}

JoltSoftBodySharedSettings *JoltSoftBodySharedSettings_ConstructFromAnother(const JoltSoftBodySharedSettings *_other)
{
    return (JoltSoftBodySharedSettings *)new JoltSoftBodySharedSettings(JoltSoftBodySharedSettings(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltSoftBodySharedSettings(*(JoltSoftBodySharedSettings *)_other))
    ));
}

void JoltSoftBodySharedSettings_Destroy(const JoltSoftBodySharedSettings *_this)
{
    delete ((const JoltSoftBodySharedSettings *)_this);
}

void JoltSoftBodySharedSettings_DestroyArray(const JoltSoftBodySharedSettings *_this)
{
    delete[] ((const JoltSoftBodySharedSettings *)_this);
}

JoltSoftBodySharedSettings *JoltSoftBodySharedSettings_AssignFromAnother(JoltSoftBodySharedSettings *_this, const JoltSoftBodySharedSettings *_other)
{
    return (JoltSoftBodySharedSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodySharedSettings *)(_this)).operator=(
        mrbindc_details::unmove(((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltSoftBodySharedSettings(*(JoltSoftBodySharedSettings *)_other)))
    ));
}

void JoltSoftBodySharedSettings_AddVertex(JoltSoftBodySharedSettings *_this, float x, float y, float z, float invMass)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodySharedSettings *)(_this)).AddVertex(
        x,
        y,
        z,
        invMass
    );
}

void JoltSoftBodySharedSettings_AddFace(JoltSoftBodySharedSettings *_this, unsigned int v0, unsigned int v1, unsigned int v2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodySharedSettings *)(_this)).AddFace(
        v0,
        v1,
        v2
    );
}

void JoltSoftBodySharedSettings_AddEdgeConstraint(JoltSoftBodySharedSettings *_this, unsigned int v0, unsigned int v1, float compliance, float restLength)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodySharedSettings *)(_this)).AddEdgeConstraint(
        v0,
        v1,
        compliance,
        restLength
    );
}

void JoltSoftBodySharedSettings_AddEdgeConstraintAuto(JoltSoftBodySharedSettings *_this, unsigned int v0, unsigned int v1, float compliance)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodySharedSettings *)(_this)).AddEdgeConstraintAuto(
        v0,
        v1,
        compliance
    );
}

void JoltSoftBodySharedSettings_CalculateEdgeLengths(JoltSoftBodySharedSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodySharedSettings *)(_this)).CalculateEdgeLengths();
}

void JoltSoftBodySharedSettings_Optimize(JoltSoftBodySharedSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodySharedSettings *)(_this)).Optimize();
}

int JoltSoftBodySharedSettings_GetVertexCount(const JoltSoftBodySharedSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltSoftBodySharedSettings *)(_this)).GetVertexCount();
}

int JoltSoftBodySharedSettings_GetFaceCount(const JoltSoftBodySharedSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltSoftBodySharedSettings *)(_this)).GetFaceCount();
}

int JoltSoftBodySharedSettings_GetEdgeCount(const JoltSoftBodySharedSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltSoftBodySharedSettings *)(_this)).GetEdgeCount();
}

void *const *JoltSoftBodyCreationSettings_Get_mHandle(const JoltSoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltSoftBodyCreationSettings *)(_this)).mHandle);
}

void JoltSoftBodyCreationSettings_Set_mHandle(JoltSoftBodyCreationSettings *_this, void *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodyCreationSettings *)(_this)).mHandle = value;
}

void **JoltSoftBodyCreationSettings_GetMutable_mHandle(JoltSoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodyCreationSettings *)(_this)).mHandle);
}

JoltSoftBodyCreationSettings *JoltSoftBodyCreationSettings_ConstructFromAnother(const JoltSoftBodyCreationSettings *_other)
{
    return (JoltSoftBodyCreationSettings *)new JoltSoftBodyCreationSettings(JoltSoftBodyCreationSettings(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltSoftBodyCreationSettings(*(JoltSoftBodyCreationSettings *)_other))
    ));
}

const JoltSoftBodyCreationSettings *JoltSoftBodyCreationSettings_OffsetPtr(const JoltSoftBodyCreationSettings *ptr, ptrdiff_t i)
{
    return (const JoltSoftBodyCreationSettings *)(((const JoltSoftBodyCreationSettings *)ptr) + i);
}

JoltSoftBodyCreationSettings *JoltSoftBodyCreationSettings_OffsetMutablePtr(JoltSoftBodyCreationSettings *ptr, ptrdiff_t i)
{
    return (JoltSoftBodyCreationSettings *)(((JoltSoftBodyCreationSettings *)ptr) + i);
}

JoltSoftBodyCreationSettings *JoltSoftBodyCreationSettings_Construct_9(JoltSoftBodySharedSettings *settings, double posX, double posY, double posZ, float qx, float qy, float qz, float qw, unsigned int objectLayer)
{
    return (JoltSoftBodyCreationSettings *)new JoltSoftBodyCreationSettings(JoltSoftBodyCreationSettings(
        ((JoltSoftBodySharedSettings *)settings),
        posX,
        posY,
        posZ,
        qx,
        qy,
        qz,
        qw,
        objectLayer
    ));
}

JoltSoftBodyCreationSettings *JoltSoftBodyCreationSettings_Construct_5(JoltSoftBodySharedSettings *settings, double posX, double posY, double posZ, unsigned int objectLayer)
{
    return (JoltSoftBodyCreationSettings *)new JoltSoftBodyCreationSettings(JoltSoftBodyCreationSettings(
        ((JoltSoftBodySharedSettings *)settings),
        posX,
        posY,
        posZ,
        objectLayer
    ));
}

void JoltSoftBodyCreationSettings_Destroy(const JoltSoftBodyCreationSettings *_this)
{
    delete ((const JoltSoftBodyCreationSettings *)_this);
}

void JoltSoftBodyCreationSettings_DestroyArray(const JoltSoftBodyCreationSettings *_this)
{
    delete[] ((const JoltSoftBodyCreationSettings *)_this);
}

JoltSoftBodyCreationSettings *JoltSoftBodyCreationSettings_AssignFromAnother(JoltSoftBodyCreationSettings *_this, const JoltSoftBodyCreationSettings *_other)
{
    return (JoltSoftBodyCreationSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodyCreationSettings *)(_this)).operator=(
        mrbindc_details::unmove(((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltSoftBodyCreationSettings(*(JoltSoftBodyCreationSettings *)_other)))
    ));
}

void JoltSoftBodyCreationSettings_SetPosition(JoltSoftBodyCreationSettings *_this, double x, double y, double z)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodyCreationSettings *)(_this)).SetPosition(
        x,
        y,
        z
    );
}

void JoltSoftBodyCreationSettings_SetRotation(JoltSoftBodyCreationSettings *_this, float qx, float qy, float qz, float qw)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodyCreationSettings *)(_this)).SetRotation(
        qx,
        qy,
        qz,
        qw
    );
}

void JoltSoftBodyCreationSettings_SetObjectLayer(JoltSoftBodyCreationSettings *_this, unsigned int layer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodyCreationSettings *)(_this)).SetObjectLayer(
        layer
    );
}

void JoltSoftBodyCreationSettings_SetMakeRotationIdentity(JoltSoftBodyCreationSettings *_this, bool v)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodyCreationSettings *)(_this)).SetMakeRotationIdentity(
        v
    );
}

void JoltSoftBodyCreationSettings_SetNumIterations(JoltSoftBodyCreationSettings *_this, unsigned int n)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltSoftBodyCreationSettings *)(_this)).SetNumIterations(
        n
    );
}

JoltPhysicsSystem *JoltPhysicsSystem_DefaultConstruct(void)
{
    return (JoltPhysicsSystem *)new JoltPhysicsSystem(JoltPhysicsSystem());
}

JoltPhysicsSystem *JoltPhysicsSystem_DefaultConstructArray(size_t num_elems)
{
    return (JoltPhysicsSystem *)(new JoltPhysicsSystem[num_elems]{});
}

const JoltPhysicsSystem *JoltPhysicsSystem_OffsetPtr(const JoltPhysicsSystem *ptr, ptrdiff_t i)
{
    return (const JoltPhysicsSystem *)(((const JoltPhysicsSystem *)ptr) + i);
}

JoltPhysicsSystem *JoltPhysicsSystem_OffsetMutablePtr(JoltPhysicsSystem *ptr, ptrdiff_t i)
{
    return (JoltPhysicsSystem *)(((JoltPhysicsSystem *)ptr) + i);
}

JoltPhysicsSystem *JoltPhysicsSystem_ConstructFromAnother(const JoltPhysicsSystem *_other)
{
    return (JoltPhysicsSystem *)new JoltPhysicsSystem(JoltPhysicsSystem(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltPhysicsSystem(*(JoltPhysicsSystem *)_other))
    ));
}

JoltPhysicsSystem *JoltPhysicsSystem_Construct(unsigned int maxBodies, unsigned int maxBodyPairs, unsigned int maxContactConstraints)
{
    return (JoltPhysicsSystem *)new JoltPhysicsSystem(JoltPhysicsSystem(
        maxBodies,
        maxBodyPairs,
        maxContactConstraints
    ));
}

void JoltPhysicsSystem_Destroy(const JoltPhysicsSystem *_this)
{
    delete ((const JoltPhysicsSystem *)_this);
}

void JoltPhysicsSystem_DestroyArray(const JoltPhysicsSystem *_this)
{
    delete[] ((const JoltPhysicsSystem *)_this);
}

JoltPhysicsSystem *JoltPhysicsSystem_AssignFromAnother(JoltPhysicsSystem *_this, const JoltPhysicsSystem *_other)
{
    return (JoltPhysicsSystem *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).operator=(
        mrbindc_details::unmove(((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltPhysicsSystem(*(JoltPhysicsSystem *)_other)))
    ));
}

void JoltPhysicsSystem_SetGravity(JoltPhysicsSystem *_this, double x, double y, double z)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).SetGravity(
        x,
        y,
        z
    );
}

JoltVec3 *JoltPhysicsSystem_GetGravity(const JoltPhysicsSystem *_this)
{
    return (JoltVec3 *)new JoltVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltPhysicsSystem *)(_this)).GetGravity());
}

void JoltPhysicsSystem_Update(JoltPhysicsSystem *_this, float deltaTime, int collisionSteps)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).Update(
        deltaTime,
        collisionSteps
    );
}

void JoltPhysicsSystem_OptimizeBroadPhase(JoltPhysicsSystem *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).OptimizeBroadPhase();
}

JoltBodyID *JoltPhysicsSystem_CreateAndAddBody(JoltPhysicsSystem *_this, JoltBodyCreationSettings *settings, int activation)
{
    return (JoltBodyID *)new JoltBodyID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).CreateAndAddBody(
        ((JoltBodyCreationSettings *)settings),
        activation
    ));
}

void JoltPhysicsSystem_RemoveBody(JoltPhysicsSystem *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).RemoveBody(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltPhysicsSystem_DestroyBody(JoltPhysicsSystem *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).DestroyBody(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltPhysicsSystem_RemoveAndDestroyBody(JoltPhysicsSystem *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).RemoveAndDestroyBody(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

JoltVec3 *JoltPhysicsSystem_GetBodyPosition(const JoltPhysicsSystem *_this, const JoltBodyID *id)
{
    return (JoltVec3 *)new JoltVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltPhysicsSystem *)(_this)).GetBodyPosition(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

JoltQuat *JoltPhysicsSystem_GetBodyRotation(const JoltPhysicsSystem *_this, const JoltBodyID *id)
{
    return (JoltQuat *)new JoltQuat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltPhysicsSystem *)(_this)).GetBodyRotation(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

JoltVec3f *JoltPhysicsSystem_GetBodyLinearVelocity(const JoltPhysicsSystem *_this, const JoltBodyID *id)
{
    return (JoltVec3f *)new JoltVec3f(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltPhysicsSystem *)(_this)).GetBodyLinearVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

JoltVec3f *JoltPhysicsSystem_GetBodyAngularVelocity(const JoltPhysicsSystem *_this, const JoltBodyID *id)
{
    return (JoltVec3f *)new JoltVec3f(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltPhysicsSystem *)(_this)).GetBodyAngularVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

bool JoltPhysicsSystem_IsBodyActive(const JoltPhysicsSystem *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltPhysicsSystem *)(_this)).IsBodyActive(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltPhysicsSystem_SetBodyPosition(JoltPhysicsSystem *_this, const JoltBodyID *id, double x, double y, double z, int activation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).SetBodyPosition(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        x,
        y,
        z,
        activation
    );
}

void JoltPhysicsSystem_SetBodyRotation(JoltPhysicsSystem *_this, const JoltBodyID *id, float qx, float qy, float qz, float qw, int activation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).SetBodyRotation(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        qx,
        qy,
        qz,
        qw,
        activation
    );
}

void JoltPhysicsSystem_SetBodyPositionAndRotation(JoltPhysicsSystem *_this, const JoltBodyID *id, double x, double y, double z, float qx, float qy, float qz, float qw, int activation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).SetBodyPositionAndRotation(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        x,
        y,
        z,
        qx,
        qy,
        qz,
        qw,
        activation
    );
}

void JoltPhysicsSystem_SetBodyLinearVelocity(JoltPhysicsSystem *_this, const JoltBodyID *id, float vx, float vy, float vz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).SetBodyLinearVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        vx,
        vy,
        vz
    );
}

void JoltPhysicsSystem_SetBodyAngularVelocity(JoltPhysicsSystem *_this, const JoltBodyID *id, float vx, float vy, float vz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).SetBodyAngularVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        vx,
        vy,
        vz
    );
}

void JoltPhysicsSystem_SetBodyLinearAndAngularVelocity(JoltPhysicsSystem *_this, const JoltBodyID *id, float lvx, float lvy, float lvz, float avx, float avy, float avz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).SetBodyLinearAndAngularVelocity(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        lvx,
        lvy,
        lvz,
        avx,
        avy,
        avz
    );
}

void JoltPhysicsSystem_AddForce(JoltPhysicsSystem *_this, const JoltBodyID *id, float fx, float fy, float fz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).AddForce(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        fx,
        fy,
        fz
    );
}

void JoltPhysicsSystem_AddForceAtPosition(JoltPhysicsSystem *_this, const JoltBodyID *id, float fx, float fy, float fz, double px, double py, double pz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).AddForceAtPosition(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        fx,
        fy,
        fz,
        px,
        py,
        pz
    );
}

void JoltPhysicsSystem_AddTorque(JoltPhysicsSystem *_this, const JoltBodyID *id, float tx, float ty, float tz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).AddTorque(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        tx,
        ty,
        tz
    );
}

void JoltPhysicsSystem_AddImpulse(JoltPhysicsSystem *_this, const JoltBodyID *id, float ix, float iy, float iz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).AddImpulse(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        ix,
        iy,
        iz
    );
}

void JoltPhysicsSystem_AddAngularImpulse(JoltPhysicsSystem *_this, const JoltBodyID *id, float ix, float iy, float iz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).AddAngularImpulse(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        ix,
        iy,
        iz
    );
}

void JoltPhysicsSystem_ActivateBody(JoltPhysicsSystem *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).ActivateBody(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltPhysicsSystem_DeactivateBody(JoltPhysicsSystem *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).DeactivateBody(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltPhysicsSystem_SetFriction(JoltPhysicsSystem *_this, const JoltBodyID *id, float friction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).SetFriction(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        friction
    );
}

float JoltPhysicsSystem_GetFriction(const JoltPhysicsSystem *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltPhysicsSystem *)(_this)).GetFriction(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltPhysicsSystem_SetRestitution(JoltPhysicsSystem *_this, const JoltBodyID *id, float restitution)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).SetRestitution(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        restitution
    );
}

float JoltPhysicsSystem_GetRestitution(const JoltPhysicsSystem *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltPhysicsSystem *)(_this)).GetRestitution(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltPhysicsSystem_SetGravityFactor(JoltPhysicsSystem *_this, const JoltBodyID *id, float factor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).SetGravityFactor(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id)),
        factor
    );
}

float JoltPhysicsSystem_GetGravityFactor(const JoltPhysicsSystem *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltPhysicsSystem *)(_this)).GetGravityFactor(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

JoltConstraintID *JoltPhysicsSystem_AddFixedConstraint(JoltPhysicsSystem *_this, const JoltBodyID *body1, const JoltBodyID *body2)
{
    return (JoltConstraintID *)new JoltConstraintID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).AddFixedConstraint(
        ((body1 ? void() : MRBINDC_THROW("Parameter `body1` can not be null.", void)), JoltBodyID(*(JoltBodyID *)body1)),
        ((body2 ? void() : MRBINDC_THROW("Parameter `body2` can not be null.", void)), JoltBodyID(*(JoltBodyID *)body2))
    ));
}

JoltConstraintID *JoltPhysicsSystem_AddDistanceConstraint(JoltPhysicsSystem *_this, const JoltBodyID *body1, const JoltBodyID *body2, float minDist, float maxDist)
{
    return (JoltConstraintID *)new JoltConstraintID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).AddDistanceConstraint(
        ((body1 ? void() : MRBINDC_THROW("Parameter `body1` can not be null.", void)), JoltBodyID(*(JoltBodyID *)body1)),
        ((body2 ? void() : MRBINDC_THROW("Parameter `body2` can not be null.", void)), JoltBodyID(*(JoltBodyID *)body2)),
        minDist,
        maxDist
    ));
}

JoltConstraintID *JoltPhysicsSystem_AddPointConstraint(JoltPhysicsSystem *_this, const JoltBodyID *body1, const JoltBodyID *body2, double pivotX, double pivotY, double pivotZ)
{
    return (JoltConstraintID *)new JoltConstraintID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).AddPointConstraint(
        ((body1 ? void() : MRBINDC_THROW("Parameter `body1` can not be null.", void)), JoltBodyID(*(JoltBodyID *)body1)),
        ((body2 ? void() : MRBINDC_THROW("Parameter `body2` can not be null.", void)), JoltBodyID(*(JoltBodyID *)body2)),
        pivotX,
        pivotY,
        pivotZ
    ));
}

JoltConstraintID *JoltPhysicsSystem_AddHingeConstraint(JoltPhysicsSystem *_this, const JoltBodyID *body1, const JoltBodyID *body2, double pivotX, double pivotY, double pivotZ, float axisX, float axisY, float axisZ)
{
    return (JoltConstraintID *)new JoltConstraintID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).AddHingeConstraint(
        ((body1 ? void() : MRBINDC_THROW("Parameter `body1` can not be null.", void)), JoltBodyID(*(JoltBodyID *)body1)),
        ((body2 ? void() : MRBINDC_THROW("Parameter `body2` can not be null.", void)), JoltBodyID(*(JoltBodyID *)body2)),
        pivotX,
        pivotY,
        pivotZ,
        axisX,
        axisY,
        axisZ
    ));
}

void JoltPhysicsSystem_DestroyConstraint(JoltPhysicsSystem *_this, const JoltConstraintID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).DestroyConstraint(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltConstraintID(*(JoltConstraintID *)id))
    );
}

void JoltPhysicsSystem_SetConstraintEnabled(JoltPhysicsSystem *_this, const JoltConstraintID *id, bool enabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).SetConstraintEnabled(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltConstraintID(*(JoltConstraintID *)id)),
        enabled
    );
}

JoltBodyID *JoltPhysicsSystem_CreateAndAddSoftBody(JoltPhysicsSystem *_this, JoltSoftBodyCreationSettings *settings, int activation)
{
    return (JoltBodyID *)new JoltBodyID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).CreateAndAddSoftBody(
        ((JoltSoftBodyCreationSettings *)settings),
        activation
    ));
}

JoltTwoBodyConstraint *JoltPhysicsSystem_GetConstraintHandle(JoltPhysicsSystem *_this, const JoltConstraintID *id)
{
    return (JoltTwoBodyConstraint *)new JoltTwoBodyConstraint(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).GetConstraintHandle(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltConstraintID(*(JoltConstraintID *)id))
    ));
}

JoltBodyInterface *JoltPhysicsSystem_GetBodyInterface(JoltPhysicsSystem *_this)
{
    return (JoltBodyInterface *)new JoltBodyInterface(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltPhysicsSystem *)(_this)).GetBodyInterface());
}

unsigned int JoltPhysicsSystem_GetNumBodies(const JoltPhysicsSystem *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltPhysicsSystem *)(_this)).GetNumBodies();
}

unsigned int JoltPhysicsSystem_GetNumActiveBodies(const JoltPhysicsSystem *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltPhysicsSystem *)(_this)).GetNumActiveBodies();
}

JoltWorld *JoltWorld_DefaultConstruct(void)
{
    return (JoltWorld *)new JoltWorld(JoltWorld());
}

JoltWorld *JoltWorld_DefaultConstructArray(size_t num_elems)
{
    return (JoltWorld *)(new JoltWorld[num_elems]{});
}

const JoltWorld *JoltWorld_OffsetPtr(const JoltWorld *ptr, ptrdiff_t i)
{
    return (const JoltWorld *)(((const JoltWorld *)ptr) + i);
}

JoltWorld *JoltWorld_OffsetMutablePtr(JoltWorld *ptr, ptrdiff_t i)
{
    return (JoltWorld *)(((JoltWorld *)ptr) + i);
}

JoltWorld *JoltWorld_ConstructFromAnother(const JoltWorld *_other)
{
    return (JoltWorld *)new JoltWorld(JoltWorld(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltWorld(*(JoltWorld *)_other))
    ));
}

void JoltWorld_Destroy(const JoltWorld *_this)
{
    delete ((const JoltWorld *)_this);
}

void JoltWorld_DestroyArray(const JoltWorld *_this)
{
    delete[] ((const JoltWorld *)_this);
}

JoltWorld *JoltWorld_AssignFromAnother(JoltWorld *_this, const JoltWorld *_other)
{
    return (JoltWorld *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltWorld *)(_this)).operator=(
        mrbindc_details::unmove(((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltWorld(*(JoltWorld *)_other)))
    ));
}

void JoltWorld_SetGravity(JoltWorld *_this, double x, double y, double z)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltWorld *)(_this)).SetGravity(
        x,
        y,
        z
    );
}

JoltBodyID *JoltWorld_AddStaticBox(JoltWorld *_this, double halfX, double halfY, double halfZ, double posX, double posY, double posZ)
{
    return (JoltBodyID *)new JoltBodyID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltWorld *)(_this)).AddStaticBox(
        halfX,
        halfY,
        halfZ,
        posX,
        posY,
        posZ
    ));
}

JoltBodyID *JoltWorld_AddDynamicSphere(JoltWorld *_this, double radius, double posX, double posY, double posZ)
{
    return (JoltBodyID *)new JoltBodyID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltWorld *)(_this)).AddDynamicSphere(
        radius,
        posX,
        posY,
        posZ
    ));
}

void JoltWorld_Update(JoltWorld *_this, double deltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltWorld *)(_this)).Update(
        deltaTime
    );
}

void JoltWorld_OptimizeBroadPhase(JoltWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltWorld *)(_this)).OptimizeBroadPhase();
}

JoltVec3 *JoltWorld_GetBodyPosition(const JoltWorld *_this, const JoltBodyID *id)
{
    return (JoltVec3 *)new JoltVec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltWorld *)(_this)).GetBodyPosition(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    ));
}

bool JoltWorld_IsBodyActive(const JoltWorld *_this, const JoltBodyID *id)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JoltWorld *)(_this)).IsBodyActive(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltWorld_RemoveBody(JoltWorld *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltWorld *)(_this)).RemoveBody(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

void JoltWorld_DestroyBody(JoltWorld *_this, const JoltBodyID *id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltWorld *)(_this)).DestroyBody(
        ((id ? void() : MRBINDC_THROW("Parameter `id` can not be null.", void)), JoltBodyID(*(JoltBodyID *)id))
    );
}

