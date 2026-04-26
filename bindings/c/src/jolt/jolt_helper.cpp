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

