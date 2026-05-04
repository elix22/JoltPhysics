// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Vehicle/Wheel.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Constraints/SpringSettings.h>
#include <Jolt/Physics/Vehicle/VehicleConstraint.h>
#include <Jolt/Physics/Vehicle/Wheel.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_WheelSettings_Get_mPosition(const JPH_WheelSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).mPosition);
}

JPH_Vec3 *JPH_WheelSettings_GetMutable_mPosition(JPH_WheelSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mPosition);
}

const JPH_Vec3 *JPH_WheelSettings_Get_mSuspensionForcePoint(const JPH_WheelSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).mSuspensionForcePoint);
}

JPH_Vec3 *JPH_WheelSettings_GetMutable_mSuspensionForcePoint(JPH_WheelSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mSuspensionForcePoint);
}

const JPH_Vec3 *JPH_WheelSettings_Get_mSuspensionDirection(const JPH_WheelSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).mSuspensionDirection);
}

JPH_Vec3 *JPH_WheelSettings_GetMutable_mSuspensionDirection(JPH_WheelSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mSuspensionDirection);
}

const JPH_Vec3 *JPH_WheelSettings_Get_mSteeringAxis(const JPH_WheelSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).mSteeringAxis);
}

JPH_Vec3 *JPH_WheelSettings_GetMutable_mSteeringAxis(JPH_WheelSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mSteeringAxis);
}

const JPH_Vec3 *JPH_WheelSettings_Get_mWheelUp(const JPH_WheelSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).mWheelUp);
}

JPH_Vec3 *JPH_WheelSettings_GetMutable_mWheelUp(JPH_WheelSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mWheelUp);
}

const JPH_Vec3 *JPH_WheelSettings_Get_mWheelForward(const JPH_WheelSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).mWheelForward);
}

JPH_Vec3 *JPH_WheelSettings_GetMutable_mWheelForward(JPH_WheelSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mWheelForward);
}

const float *JPH_WheelSettings_Get_mSuspensionMinLength(const JPH_WheelSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).mSuspensionMinLength);
}

void JPH_WheelSettings_Set_mSuspensionMinLength(JPH_WheelSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mSuspensionMinLength = value;
}

float *JPH_WheelSettings_GetMutable_mSuspensionMinLength(JPH_WheelSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mSuspensionMinLength);
}

const float *JPH_WheelSettings_Get_mSuspensionMaxLength(const JPH_WheelSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).mSuspensionMaxLength);
}

void JPH_WheelSettings_Set_mSuspensionMaxLength(JPH_WheelSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mSuspensionMaxLength = value;
}

float *JPH_WheelSettings_GetMutable_mSuspensionMaxLength(JPH_WheelSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mSuspensionMaxLength);
}

const float *JPH_WheelSettings_Get_mSuspensionPreloadLength(const JPH_WheelSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).mSuspensionPreloadLength);
}

void JPH_WheelSettings_Set_mSuspensionPreloadLength(JPH_WheelSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mSuspensionPreloadLength = value;
}

float *JPH_WheelSettings_GetMutable_mSuspensionPreloadLength(JPH_WheelSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mSuspensionPreloadLength);
}

const JPH_SpringSettings *JPH_WheelSettings_Get_mSuspensionSpring(const JPH_WheelSettings *_this)
{
    return (const JPH_SpringSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).mSuspensionSpring);
}

JPH_SpringSettings *JPH_WheelSettings_GetMutable_mSuspensionSpring(JPH_WheelSettings *_this)
{
    return (JPH_SpringSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mSuspensionSpring);
}

const float *JPH_WheelSettings_Get_mRadius(const JPH_WheelSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).mRadius);
}

void JPH_WheelSettings_Set_mRadius(JPH_WheelSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mRadius = value;
}

float *JPH_WheelSettings_GetMutable_mRadius(JPH_WheelSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mRadius);
}

const float *JPH_WheelSettings_Get_mWidth(const JPH_WheelSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).mWidth);
}

void JPH_WheelSettings_Set_mWidth(JPH_WheelSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mWidth = value;
}

float *JPH_WheelSettings_GetMutable_mWidth(JPH_WheelSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mWidth);
}

const bool *JPH_WheelSettings_Get_mEnableSuspensionForcePoint(const JPH_WheelSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).mEnableSuspensionForcePoint);
}

void JPH_WheelSettings_Set_mEnableSuspensionForcePoint(JPH_WheelSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mEnableSuspensionForcePoint = value;
}

bool *JPH_WheelSettings_GetMutable_mEnableSuspensionForcePoint(JPH_WheelSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).mEnableSuspensionForcePoint);
}

JPH_WheelSettings *JPH_WheelSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::WheelSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_WheelSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_WheelSettings *JPH_WheelSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_WheelSettings *)(new JPH::WheelSettings[num_elems]);
}

const JPH_WheelSettings *JPH_WheelSettings_OffsetPtr(const JPH_WheelSettings *ptr, ptrdiff_t i)
{
    return (const JPH_WheelSettings *)(((const JPH::WheelSettings *)ptr) + i);
}

JPH_WheelSettings *JPH_WheelSettings_OffsetMutablePtr(JPH_WheelSettings *ptr, ptrdiff_t i)
{
    return (JPH_WheelSettings *)(((JPH::WheelSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_WheelSettings_UpcastTo_JPH_SerializableObject(const JPH_WheelSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::WheelSettings *)object)
    ));
}

JPH_SerializableObject *JPH_WheelSettings_MutableUpcastTo_JPH_SerializableObject(JPH_WheelSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::WheelSettings *)object)
    ));
}

const JPH_WheelSettings *JPH_WheelSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_WheelSettings *)(static_cast<const JPH::WheelSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_WheelSettings *JPH_WheelSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_WheelSettings *)(static_cast<JPH::WheelSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_WheelSettings *JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(const JPH_WheelSettings *object)
{
    return (const JPH_RefTarget_JPH_WheelSettings *)(static_cast<const JPH::RefTarget<JPH::WheelSettings> *>(
        ((const JPH::WheelSettings *)object)
    ));
}

JPH_RefTarget_JPH_WheelSettings *JPH_WheelSettings_MutableUpcastTo_JPH_RefTarget_JPH_WheelSettings(JPH_WheelSettings *object)
{
    return (JPH_RefTarget_JPH_WheelSettings *)(static_cast<JPH::RefTarget<JPH::WheelSettings> *>(
        ((JPH::WheelSettings *)object)
    ));
}

const JPH_WheelSettings *JPH_WheelSettings_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(const JPH_RefTarget_JPH_WheelSettings *object)
{
    return (const JPH_WheelSettings *)(static_cast<const JPH::WheelSettings *>(
        ((const JPH::RefTarget<JPH::WheelSettings> *)object)
    ));
}

JPH_WheelSettings *JPH_WheelSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(JPH_RefTarget_JPH_WheelSettings *object)
{
    return (JPH_WheelSettings *)(static_cast<JPH::WheelSettings *>(
        ((JPH::RefTarget<JPH::WheelSettings> *)object)
    ));
}

JPH_WheelSettings *JPH_WheelSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_WheelSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::WheelSettings);
    return (JPH_WheelSettings *)new JPH::WheelSettings(JPH::WheelSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::WheelSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::WheelSettings), JPH::WheelSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::WheelSettings), JPH::WheelSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::WheelSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::WheelSettings) MRBINDC_CLASSARG_END(_other, JPH::WheelSettings))
    ));
}

void JPH_WheelSettings_Destroy(const JPH_WheelSettings *_this)
{
    delete ((const JPH::WheelSettings *)_this);
}

void JPH_WheelSettings_DestroyArray(const JPH_WheelSettings *_this)
{
    delete[] ((const JPH::WheelSettings *)_this);
}

JPH_WheelSettings *JPH_WheelSettings_AssignFromAnother(JPH_WheelSettings *_this, Jolt_PassBy _other_pass_by, JPH_WheelSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::WheelSettings);
    return (JPH_WheelSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::WheelSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::WheelSettings), JPH::WheelSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::WheelSettings), JPH::WheelSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::WheelSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::WheelSettings) MRBINDC_CLASSARG_END(_other, JPH::WheelSettings))
    ));
}

void *Jolt_new_JPH_WheelSettings_size_t(size_t inCount)
{
    return JPH::WheelSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_WheelSettings_void_ptr(void *inPointer)
{
    JPH::WheelSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_WheelSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::WheelSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_WheelSettings_size_t(size_t inCount)
{
    return JPH::WheelSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_WheelSettings_void_ptr(void *inPointer)
{
    JPH::WheelSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_WheelSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::WheelSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_WheelSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::WheelSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_WheelSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::WheelSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_WheelSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::WheelSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_WheelSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::WheelSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_WheelSettings_SetEmbedded(const JPH_WheelSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_WheelSettings_GetRefCount(const JPH_WheelSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).GetRefCount();
}

void JPH_WheelSettings_AddRef(const JPH_WheelSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).AddRef();
}

void JPH_WheelSettings_Release(const JPH_WheelSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettings *)(_this)).Release();
}

int JPH_WheelSettings_sInternalGetRefCountOffset(void)
{
    return JPH::WheelSettings::sInternalGetRefCountOffset();
}

JPH_Wheel *JPH_Wheel_Construct(const JPH_WheelSettings *inSettings)
{
    return (JPH_Wheel *)new JPH::Wheel(JPH::Wheel(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::WheelSettings *)(inSettings))
    ));
}

const JPH_Wheel *JPH_Wheel_OffsetPtr(const JPH_Wheel *ptr, ptrdiff_t i)
{
    return (const JPH_Wheel *)(((const JPH::Wheel *)ptr) + i);
}

JPH_Wheel *JPH_Wheel_OffsetMutablePtr(JPH_Wheel *ptr, ptrdiff_t i)
{
    return (JPH_Wheel *)(((JPH::Wheel *)ptr) + i);
}

const JPH_NonCopyable *JPH_Wheel_UpcastTo_JPH_NonCopyable(const JPH_Wheel *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::Wheel *)object)
    ));
}

JPH_NonCopyable *JPH_Wheel_MutableUpcastTo_JPH_NonCopyable(JPH_Wheel *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::Wheel *)object)
    ));
}

const JPH_Wheel *JPH_Wheel_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_Wheel *)(static_cast<const JPH::Wheel *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_Wheel *JPH_Wheel_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_Wheel *)(static_cast<JPH::Wheel *>(
        ((JPH::NonCopyable *)object)
    ));
}

void JPH_Wheel_Destroy(const JPH_Wheel *_this)
{
    delete ((const JPH::Wheel *)_this);
}

void JPH_Wheel_DestroyArray(const JPH_Wheel *_this)
{
    delete[] ((const JPH::Wheel *)_this);
}

void *Jolt_new_JPH_Wheel_size_t(size_t inCount)
{
    return JPH::Wheel::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Wheel_void_ptr(void *inPointer)
{
    JPH::Wheel::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Wheel_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Wheel::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Wheel_size_t(size_t inCount)
{
    return JPH::Wheel::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Wheel_void_ptr(void *inPointer)
{
    JPH::Wheel::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Wheel_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Wheel::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Wheel_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Wheel::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Wheel_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Wheel::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Wheel_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Wheel::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Wheel_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Wheel::operator delete[](
        inPointer,
        inPlace
    );
}

const JPH_WheelSettings *JPH_Wheel_GetSettings(const JPH_Wheel *_this)
{
    return (const JPH_WheelSettings *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetSettings());
}

float JPH_Wheel_GetAngularVelocity(const JPH_Wheel *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetAngularVelocity();
}

void JPH_Wheel_SetAngularVelocity(JPH_Wheel *_this, float inVel)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Wheel *)(_this)).SetAngularVelocity(
        inVel
    );
}

float JPH_Wheel_GetRotationAngle(const JPH_Wheel *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetRotationAngle();
}

void JPH_Wheel_SetRotationAngle(JPH_Wheel *_this, float inAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Wheel *)(_this)).SetRotationAngle(
        inAngle
    );
}

float JPH_Wheel_GetSteerAngle(const JPH_Wheel *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetSteerAngle();
}

void JPH_Wheel_SetSteerAngle(JPH_Wheel *_this, float inAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Wheel *)(_this)).SetSteerAngle(
        inAngle
    );
}

bool JPH_Wheel_HasContact(const JPH_Wheel *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).HasContact();
}

JPH_BodyID JPH_Wheel_GetContactBodyID(const JPH_Wheel *_this)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetContactBodyID());
}

JPH_SubShapeID *JPH_Wheel_GetContactSubShapeID(const JPH_Wheel *_this)
{
    return (JPH_SubShapeID *)new JPH::SubShapeID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetContactSubShapeID());
}

JPH_Vec3 *JPH_Wheel_GetContactPosition(const JPH_Wheel *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetContactPosition());
}

JPH_Vec3 *JPH_Wheel_GetContactPointVelocity(const JPH_Wheel *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetContactPointVelocity());
}

JPH_Vec3 *JPH_Wheel_GetContactNormal(const JPH_Wheel *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetContactNormal());
}

JPH_Vec3 *JPH_Wheel_GetContactLongitudinal(const JPH_Wheel *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetContactLongitudinal());
}

JPH_Vec3 *JPH_Wheel_GetContactLateral(const JPH_Wheel *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetContactLateral());
}

float JPH_Wheel_GetSuspensionLength(const JPH_Wheel *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetSuspensionLength();
}

bool JPH_Wheel_HasHitHardPoint(const JPH_Wheel *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).HasHitHardPoint();
}

float JPH_Wheel_GetSuspensionLambda(const JPH_Wheel *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetSuspensionLambda();
}

float JPH_Wheel_GetLongitudinalLambda(const JPH_Wheel *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetLongitudinalLambda();
}

float JPH_Wheel_GetLateralLambda(const JPH_Wheel *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Wheel *)(_this)).GetLateralLambda();
}

bool JPH_Wheel_SolveLongitudinalConstraintPart(JPH_Wheel *_this, const JPH_VehicleConstraint *inConstraint, float inMinImpulse, float inMaxImpulse)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Wheel *)(_this)).SolveLongitudinalConstraintPart(
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inConstraint)),
        inMinImpulse,
        inMaxImpulse
    );
}

bool JPH_Wheel_SolveLateralConstraintPart(JPH_Wheel *_this, const JPH_VehicleConstraint *inConstraint, float inMinImpulse, float inMaxImpulse)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Wheel *)(_this)).SolveLateralConstraintPart(
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inConstraint)),
        inMinImpulse,
        inMaxImpulse
    );
}

