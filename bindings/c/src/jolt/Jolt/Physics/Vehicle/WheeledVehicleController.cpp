// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Vehicle/WheeledVehicleController.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Constraints/SpringSettings.h>
#include <Jolt/Physics/Vehicle/VehicleConstraint.h>
#include <Jolt/Physics/Vehicle/VehicleController.h>
#include <Jolt/Physics/Vehicle/VehicleEngine.h>
#include <Jolt/Physics/Vehicle/VehicleTransmission.h>
#include <Jolt/Physics/Vehicle/Wheel.h>
#include <Jolt/Physics/Vehicle/WheeledVehicleController.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <functional>
#include <memory>
#include <new>
#include <stdexcept>


const float *JPH_WheelSettingsWV_Get_mInertia(const JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mInertia);
}

void JPH_WheelSettingsWV_Set_mInertia(JPH_WheelSettingsWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mInertia = value;
}

float *JPH_WheelSettingsWV_GetMutable_mInertia(JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mInertia);
}

const float *JPH_WheelSettingsWV_Get_mAngularDamping(const JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mAngularDamping);
}

void JPH_WheelSettingsWV_Set_mAngularDamping(JPH_WheelSettingsWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mAngularDamping = value;
}

float *JPH_WheelSettingsWV_GetMutable_mAngularDamping(JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mAngularDamping);
}

const float *JPH_WheelSettingsWV_Get_mMaxSteerAngle(const JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mMaxSteerAngle);
}

void JPH_WheelSettingsWV_Set_mMaxSteerAngle(JPH_WheelSettingsWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mMaxSteerAngle = value;
}

float *JPH_WheelSettingsWV_GetMutable_mMaxSteerAngle(JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mMaxSteerAngle);
}

const float *JPH_WheelSettingsWV_Get_mMaxBrakeTorque(const JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mMaxBrakeTorque);
}

void JPH_WheelSettingsWV_Set_mMaxBrakeTorque(JPH_WheelSettingsWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mMaxBrakeTorque = value;
}

float *JPH_WheelSettingsWV_GetMutable_mMaxBrakeTorque(JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mMaxBrakeTorque);
}

const float *JPH_WheelSettingsWV_Get_mMaxHandBrakeTorque(const JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mMaxHandBrakeTorque);
}

void JPH_WheelSettingsWV_Set_mMaxHandBrakeTorque(JPH_WheelSettingsWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mMaxHandBrakeTorque = value;
}

float *JPH_WheelSettingsWV_GetMutable_mMaxHandBrakeTorque(JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mMaxHandBrakeTorque);
}

const JPH_Vec3 *JPH_WheelSettingsWV_Get_mPosition(const JPH_WheelSettingsWV *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mPosition);
}

JPH_Vec3 *JPH_WheelSettingsWV_GetMutable_mPosition(JPH_WheelSettingsWV *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mPosition);
}

const JPH_Vec3 *JPH_WheelSettingsWV_Get_mSuspensionForcePoint(const JPH_WheelSettingsWV *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mSuspensionForcePoint);
}

JPH_Vec3 *JPH_WheelSettingsWV_GetMutable_mSuspensionForcePoint(JPH_WheelSettingsWV *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mSuspensionForcePoint);
}

const JPH_Vec3 *JPH_WheelSettingsWV_Get_mSuspensionDirection(const JPH_WheelSettingsWV *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mSuspensionDirection);
}

JPH_Vec3 *JPH_WheelSettingsWV_GetMutable_mSuspensionDirection(JPH_WheelSettingsWV *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mSuspensionDirection);
}

const JPH_Vec3 *JPH_WheelSettingsWV_Get_mSteeringAxis(const JPH_WheelSettingsWV *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mSteeringAxis);
}

JPH_Vec3 *JPH_WheelSettingsWV_GetMutable_mSteeringAxis(JPH_WheelSettingsWV *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mSteeringAxis);
}

const JPH_Vec3 *JPH_WheelSettingsWV_Get_mWheelUp(const JPH_WheelSettingsWV *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mWheelUp);
}

JPH_Vec3 *JPH_WheelSettingsWV_GetMutable_mWheelUp(JPH_WheelSettingsWV *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mWheelUp);
}

const JPH_Vec3 *JPH_WheelSettingsWV_Get_mWheelForward(const JPH_WheelSettingsWV *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mWheelForward);
}

JPH_Vec3 *JPH_WheelSettingsWV_GetMutable_mWheelForward(JPH_WheelSettingsWV *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mWheelForward);
}

const float *JPH_WheelSettingsWV_Get_mSuspensionMinLength(const JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mSuspensionMinLength);
}

void JPH_WheelSettingsWV_Set_mSuspensionMinLength(JPH_WheelSettingsWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mSuspensionMinLength = value;
}

float *JPH_WheelSettingsWV_GetMutable_mSuspensionMinLength(JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mSuspensionMinLength);
}

const float *JPH_WheelSettingsWV_Get_mSuspensionMaxLength(const JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mSuspensionMaxLength);
}

void JPH_WheelSettingsWV_Set_mSuspensionMaxLength(JPH_WheelSettingsWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mSuspensionMaxLength = value;
}

float *JPH_WheelSettingsWV_GetMutable_mSuspensionMaxLength(JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mSuspensionMaxLength);
}

const float *JPH_WheelSettingsWV_Get_mSuspensionPreloadLength(const JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mSuspensionPreloadLength);
}

void JPH_WheelSettingsWV_Set_mSuspensionPreloadLength(JPH_WheelSettingsWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mSuspensionPreloadLength = value;
}

float *JPH_WheelSettingsWV_GetMutable_mSuspensionPreloadLength(JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mSuspensionPreloadLength);
}

const JPH_SpringSettings *JPH_WheelSettingsWV_Get_mSuspensionSpring(const JPH_WheelSettingsWV *_this)
{
    return (const JPH_SpringSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mSuspensionSpring);
}

JPH_SpringSettings *JPH_WheelSettingsWV_GetMutable_mSuspensionSpring(JPH_WheelSettingsWV *_this)
{
    return (JPH_SpringSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mSuspensionSpring);
}

const float *JPH_WheelSettingsWV_Get_mRadius(const JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mRadius);
}

void JPH_WheelSettingsWV_Set_mRadius(JPH_WheelSettingsWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mRadius = value;
}

float *JPH_WheelSettingsWV_GetMutable_mRadius(JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mRadius);
}

const float *JPH_WheelSettingsWV_Get_mWidth(const JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mWidth);
}

void JPH_WheelSettingsWV_Set_mWidth(JPH_WheelSettingsWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mWidth = value;
}

float *JPH_WheelSettingsWV_GetMutable_mWidth(JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mWidth);
}

const bool *JPH_WheelSettingsWV_Get_mEnableSuspensionForcePoint(const JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).mEnableSuspensionForcePoint);
}

void JPH_WheelSettingsWV_Set_mEnableSuspensionForcePoint(JPH_WheelSettingsWV *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mEnableSuspensionForcePoint = value;
}

bool *JPH_WheelSettingsWV_GetMutable_mEnableSuspensionForcePoint(JPH_WheelSettingsWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).mEnableSuspensionForcePoint);
}

JPH_WheelSettingsWV *JPH_WheelSettingsWV_DefaultConstruct(void)
{
    using _mrbind_T = JPH::WheelSettingsWV;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_WheelSettingsWV*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_WheelSettingsWV *JPH_WheelSettingsWV_DefaultConstructArray(size_t num_elems)
{
    return (JPH_WheelSettingsWV *)(new JPH::WheelSettingsWV[num_elems]{});
}

const JPH_WheelSettingsWV *JPH_WheelSettingsWV_OffsetPtr(const JPH_WheelSettingsWV *ptr, ptrdiff_t i)
{
    return (const JPH_WheelSettingsWV *)(((const JPH::WheelSettingsWV *)ptr) + i);
}

JPH_WheelSettingsWV *JPH_WheelSettingsWV_OffsetMutablePtr(JPH_WheelSettingsWV *ptr, ptrdiff_t i)
{
    return (JPH_WheelSettingsWV *)(((JPH::WheelSettingsWV *)ptr) + i);
}

const JPH_SerializableObject *JPH_WheelSettingsWV_UpcastTo_JPH_SerializableObject(const JPH_WheelSettingsWV *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::WheelSettingsWV *)object)
    ));
}

JPH_SerializableObject *JPH_WheelSettingsWV_MutableUpcastTo_JPH_SerializableObject(JPH_WheelSettingsWV *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::WheelSettingsWV *)object)
    ));
}

const JPH_WheelSettingsWV *JPH_WheelSettingsWV_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_WheelSettingsWV *)(static_cast<const JPH::WheelSettingsWV *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_WheelSettingsWV *JPH_WheelSettingsWV_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_WheelSettingsWV *)(static_cast<JPH::WheelSettingsWV *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_WheelSettings *JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(const JPH_WheelSettingsWV *object)
{
    return (const JPH_RefTarget_JPH_WheelSettings *)(static_cast<const JPH::RefTarget<JPH::WheelSettings> *>(
        ((const JPH::WheelSettingsWV *)object)
    ));
}

JPH_RefTarget_JPH_WheelSettings *JPH_WheelSettingsWV_MutableUpcastTo_JPH_RefTarget_JPH_WheelSettings(JPH_WheelSettingsWV *object)
{
    return (JPH_RefTarget_JPH_WheelSettings *)(static_cast<JPH::RefTarget<JPH::WheelSettings> *>(
        ((JPH::WheelSettingsWV *)object)
    ));
}

const JPH_WheelSettingsWV *JPH_WheelSettingsWV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(const JPH_RefTarget_JPH_WheelSettings *object)
{
    return (const JPH_WheelSettingsWV *)(static_cast<const JPH::WheelSettingsWV *>(
        ((const JPH::RefTarget<JPH::WheelSettings> *)object)
    ));
}

JPH_WheelSettingsWV *JPH_WheelSettingsWV_MutableStaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(JPH_RefTarget_JPH_WheelSettings *object)
{
    return (JPH_WheelSettingsWV *)(static_cast<JPH::WheelSettingsWV *>(
        ((JPH::RefTarget<JPH::WheelSettings> *)object)
    ));
}

const JPH_WheelSettings *JPH_WheelSettingsWV_UpcastTo_JPH_WheelSettings(const JPH_WheelSettingsWV *object)
{
    return (const JPH_WheelSettings *)(static_cast<const JPH::WheelSettings *>(
        ((const JPH::WheelSettingsWV *)object)
    ));
}

JPH_WheelSettings *JPH_WheelSettingsWV_MutableUpcastTo_JPH_WheelSettings(JPH_WheelSettingsWV *object)
{
    return (JPH_WheelSettings *)(static_cast<JPH::WheelSettings *>(
        ((JPH::WheelSettingsWV *)object)
    ));
}

const JPH_WheelSettingsWV *JPH_WheelSettingsWV_StaticDowncastFrom_JPH_WheelSettings(const JPH_WheelSettings *object)
{
    return (const JPH_WheelSettingsWV *)(static_cast<const JPH::WheelSettingsWV *>(
        ((const JPH::WheelSettings *)object)
    ));
}

JPH_WheelSettingsWV *JPH_WheelSettingsWV_MutableStaticDowncastFrom_JPH_WheelSettings(JPH_WheelSettings *object)
{
    return (JPH_WheelSettingsWV *)(static_cast<JPH::WheelSettingsWV *>(
        ((JPH::WheelSettings *)object)
    ));
}

JPH_WheelSettingsWV *JPH_WheelSettingsWV_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_WheelSettingsWV *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::WheelSettingsWV);
    return (JPH_WheelSettingsWV *)new JPH::WheelSettingsWV(JPH::WheelSettingsWV(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::WheelSettingsWV) MRBINDC_CLASSARG_COPY(_other, (JPH::WheelSettingsWV), JPH::WheelSettingsWV) MRBINDC_CLASSARG_MOVE(_other, (JPH::WheelSettingsWV), JPH::WheelSettingsWV) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::WheelSettingsWV) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::WheelSettingsWV) MRBINDC_CLASSARG_END(_other, JPH::WheelSettingsWV))
    ));
}

void JPH_WheelSettingsWV_Destroy(const JPH_WheelSettingsWV *_this)
{
    delete ((const JPH::WheelSettingsWV *)_this);
}

void JPH_WheelSettingsWV_DestroyArray(const JPH_WheelSettingsWV *_this)
{
    delete[] ((const JPH::WheelSettingsWV *)_this);
}

JPH_WheelSettingsWV *JPH_WheelSettingsWV_AssignFromAnother(JPH_WheelSettingsWV *_this, Jolt_PassBy _other_pass_by, JPH_WheelSettingsWV *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::WheelSettingsWV);
    return (JPH_WheelSettingsWV *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsWV *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::WheelSettingsWV) MRBINDC_CLASSARG_COPY(_other, (JPH::WheelSettingsWV), JPH::WheelSettingsWV) MRBINDC_CLASSARG_MOVE(_other, (JPH::WheelSettingsWV), JPH::WheelSettingsWV) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::WheelSettingsWV) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::WheelSettingsWV) MRBINDC_CLASSARG_END(_other, JPH::WheelSettingsWV))
    ));
}

void *Jolt_new_JPH_WheelSettingsWV_size_t(size_t inCount)
{
    return JPH::WheelSettingsWV::operator new(
        inCount
    );
}

void Jolt_delete_JPH_WheelSettingsWV_void_ptr(void *inPointer)
{
    JPH::WheelSettingsWV::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_WheelSettingsWV_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::WheelSettingsWV::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_WheelSettingsWV_size_t(size_t inCount)
{
    return JPH::WheelSettingsWV::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_WheelSettingsWV_void_ptr(void *inPointer)
{
    JPH::WheelSettingsWV::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_WheelSettingsWV_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::WheelSettingsWV::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_WheelSettingsWV_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::WheelSettingsWV::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_WheelSettingsWV_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::WheelSettingsWV::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_WheelSettingsWV_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::WheelSettingsWV::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_WheelSettingsWV_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::WheelSettingsWV::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_WheelSettingsWV_SetEmbedded(const JPH_WheelSettingsWV *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).SetEmbedded();
}

unsigned int JPH_WheelSettingsWV_GetRefCount(const JPH_WheelSettingsWV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).GetRefCount();
}

void JPH_WheelSettingsWV_AddRef(const JPH_WheelSettingsWV *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).AddRef();
}

void JPH_WheelSettingsWV_Release(const JPH_WheelSettingsWV *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsWV *)(_this)).Release();
}

int JPH_WheelSettingsWV_sInternalGetRefCountOffset(void)
{
    return JPH::WheelSettingsWV::sInternalGetRefCountOffset();
}

const float *JPH_WheelWV_Get_mLongitudinalSlip(const JPH_WheelWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).mLongitudinalSlip);
}

void JPH_WheelWV_Set_mLongitudinalSlip(JPH_WheelWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).mLongitudinalSlip = value;
}

float *JPH_WheelWV_GetMutable_mLongitudinalSlip(JPH_WheelWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).mLongitudinalSlip);
}

const float *JPH_WheelWV_Get_mLateralSlip(const JPH_WheelWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).mLateralSlip);
}

void JPH_WheelWV_Set_mLateralSlip(JPH_WheelWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).mLateralSlip = value;
}

float *JPH_WheelWV_GetMutable_mLateralSlip(JPH_WheelWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).mLateralSlip);
}

const float *JPH_WheelWV_Get_mCombinedLongitudinalFriction(const JPH_WheelWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).mCombinedLongitudinalFriction);
}

void JPH_WheelWV_Set_mCombinedLongitudinalFriction(JPH_WheelWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).mCombinedLongitudinalFriction = value;
}

float *JPH_WheelWV_GetMutable_mCombinedLongitudinalFriction(JPH_WheelWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).mCombinedLongitudinalFriction);
}

const float *JPH_WheelWV_Get_mCombinedLateralFriction(const JPH_WheelWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).mCombinedLateralFriction);
}

void JPH_WheelWV_Set_mCombinedLateralFriction(JPH_WheelWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).mCombinedLateralFriction = value;
}

float *JPH_WheelWV_GetMutable_mCombinedLateralFriction(JPH_WheelWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).mCombinedLateralFriction);
}

const float *JPH_WheelWV_Get_mBrakeImpulse(const JPH_WheelWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).mBrakeImpulse);
}

void JPH_WheelWV_Set_mBrakeImpulse(JPH_WheelWV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).mBrakeImpulse = value;
}

float *JPH_WheelWV_GetMutable_mBrakeImpulse(JPH_WheelWV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).mBrakeImpulse);
}

JPH_WheelWV *JPH_WheelWV_Construct(const JPH_WheelSettingsWV *inWheel)
{
    return (JPH_WheelWV *)new JPH::WheelWV(JPH::WheelWV(
        ((inWheel ? void() : MRBINDC_THROW("Parameter `inWheel` can not be null.", void)), *(const JPH::WheelSettingsWV *)(inWheel))
    ));
}

const JPH_WheelWV *JPH_WheelWV_OffsetPtr(const JPH_WheelWV *ptr, ptrdiff_t i)
{
    return (const JPH_WheelWV *)(((const JPH::WheelWV *)ptr) + i);
}

JPH_WheelWV *JPH_WheelWV_OffsetMutablePtr(JPH_WheelWV *ptr, ptrdiff_t i)
{
    return (JPH_WheelWV *)(((JPH::WheelWV *)ptr) + i);
}

const JPH_NonCopyable *JPH_WheelWV_UpcastTo_JPH_NonCopyable(const JPH_WheelWV *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::WheelWV *)object)
    ));
}

JPH_NonCopyable *JPH_WheelWV_MutableUpcastTo_JPH_NonCopyable(JPH_WheelWV *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::WheelWV *)object)
    ));
}

const JPH_WheelWV *JPH_WheelWV_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_WheelWV *)(static_cast<const JPH::WheelWV *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_WheelWV *JPH_WheelWV_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_WheelWV *)(static_cast<JPH::WheelWV *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Wheel *JPH_WheelWV_UpcastTo_JPH_Wheel(const JPH_WheelWV *object)
{
    return (const JPH_Wheel *)(static_cast<const JPH::Wheel *>(
        ((const JPH::WheelWV *)object)
    ));
}

JPH_Wheel *JPH_WheelWV_MutableUpcastTo_JPH_Wheel(JPH_WheelWV *object)
{
    return (JPH_Wheel *)(static_cast<JPH::Wheel *>(
        ((JPH::WheelWV *)object)
    ));
}

const JPH_WheelWV *JPH_WheelWV_StaticDowncastFrom_JPH_Wheel(const JPH_Wheel *object)
{
    return (const JPH_WheelWV *)(static_cast<const JPH::WheelWV *>(
        ((const JPH::Wheel *)object)
    ));
}

JPH_WheelWV *JPH_WheelWV_MutableStaticDowncastFrom_JPH_Wheel(JPH_Wheel *object)
{
    return (JPH_WheelWV *)(static_cast<JPH::WheelWV *>(
        ((JPH::Wheel *)object)
    ));
}

void JPH_WheelWV_Destroy(const JPH_WheelWV *_this)
{
    delete ((const JPH::WheelWV *)_this);
}

void JPH_WheelWV_DestroyArray(const JPH_WheelWV *_this)
{
    delete[] ((const JPH::WheelWV *)_this);
}

void *Jolt_new_JPH_WheelWV_size_t(size_t inCount)
{
    return JPH::WheelWV::operator new(
        inCount
    );
}

void Jolt_delete_JPH_WheelWV_void_ptr(void *inPointer)
{
    JPH::WheelWV::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_WheelWV_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::WheelWV::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_WheelWV_size_t(size_t inCount)
{
    return JPH::WheelWV::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_WheelWV_void_ptr(void *inPointer)
{
    JPH::WheelWV::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_WheelWV_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::WheelWV::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_WheelWV_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::WheelWV::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_WheelWV_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::WheelWV::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_WheelWV_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::WheelWV::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_WheelWV_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::WheelWV::operator delete[](
        inPointer,
        inPlace
    );
}

const JPH_WheelSettingsWV *JPH_WheelWV_GetSettings(const JPH_WheelWV *_this)
{
    return (const JPH_WheelSettingsWV *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetSettings());
}

void JPH_WheelWV_ApplyTorque(JPH_WheelWV *_this, float inTorque, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).ApplyTorque(
        inTorque,
        inDeltaTime
    );
}

void JPH_WheelWV_Update(JPH_WheelWV *_this, unsigned int inWheelIndex, float inDeltaTime, const JPH_VehicleConstraint *inConstraint)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).Update(
        inWheelIndex,
        inDeltaTime,
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inConstraint))
    );
}

float JPH_WheelWV_GetAngularVelocity(const JPH_WheelWV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetAngularVelocity();
}

void JPH_WheelWV_SetAngularVelocity(JPH_WheelWV *_this, float inVel)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).SetAngularVelocity(
        inVel
    );
}

float JPH_WheelWV_GetRotationAngle(const JPH_WheelWV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetRotationAngle();
}

void JPH_WheelWV_SetRotationAngle(JPH_WheelWV *_this, float inAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).SetRotationAngle(
        inAngle
    );
}

float JPH_WheelWV_GetSteerAngle(const JPH_WheelWV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetSteerAngle();
}

void JPH_WheelWV_SetSteerAngle(JPH_WheelWV *_this, float inAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).SetSteerAngle(
        inAngle
    );
}

bool JPH_WheelWV_HasContact(const JPH_WheelWV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).HasContact();
}

JPH_BodyID JPH_WheelWV_GetContactBodyID(const JPH_WheelWV *_this)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetContactBodyID());
}

JPH_SubShapeID *JPH_WheelWV_GetContactSubShapeID(const JPH_WheelWV *_this)
{
    return (JPH_SubShapeID *)new JPH::SubShapeID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetContactSubShapeID());
}

JPH_Vec3 *JPH_WheelWV_GetContactPosition(const JPH_WheelWV *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetContactPosition());
}

JPH_Vec3 *JPH_WheelWV_GetContactPointVelocity(const JPH_WheelWV *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetContactPointVelocity());
}

JPH_Vec3 *JPH_WheelWV_GetContactNormal(const JPH_WheelWV *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetContactNormal());
}

JPH_Vec3 *JPH_WheelWV_GetContactLongitudinal(const JPH_WheelWV *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetContactLongitudinal());
}

JPH_Vec3 *JPH_WheelWV_GetContactLateral(const JPH_WheelWV *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetContactLateral());
}

float JPH_WheelWV_GetSuspensionLength(const JPH_WheelWV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetSuspensionLength();
}

bool JPH_WheelWV_HasHitHardPoint(const JPH_WheelWV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).HasHitHardPoint();
}

float JPH_WheelWV_GetSuspensionLambda(const JPH_WheelWV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetSuspensionLambda();
}

float JPH_WheelWV_GetLongitudinalLambda(const JPH_WheelWV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetLongitudinalLambda();
}

float JPH_WheelWV_GetLateralLambda(const JPH_WheelWV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelWV *)(_this)).GetLateralLambda();
}

bool JPH_WheelWV_SolveLongitudinalConstraintPart(JPH_WheelWV *_this, const JPH_VehicleConstraint *inConstraint, float inMinImpulse, float inMaxImpulse)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).SolveLongitudinalConstraintPart(
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inConstraint)),
        inMinImpulse,
        inMaxImpulse
    );
}

bool JPH_WheelWV_SolveLateralConstraintPart(JPH_WheelWV *_this, const JPH_VehicleConstraint *inConstraint, float inMinImpulse, float inMaxImpulse)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelWV *)(_this)).SolveLateralConstraintPart(
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inConstraint)),
        inMinImpulse,
        inMaxImpulse
    );
}

const JPH_VehicleEngineSettings *JPH_WheeledVehicleControllerSettings_Get_mEngine(const JPH_WheeledVehicleControllerSettings *_this)
{
    return (const JPH_VehicleEngineSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleControllerSettings *)(_this)).mEngine);
}

void JPH_WheeledVehicleControllerSettings_Set_mEngine(JPH_WheeledVehicleControllerSettings *_this, Jolt_PassBy value_pass_by, JPH_VehicleEngineSettings *value)
{
    MRBINDC_CLASSARG_GUARD(value, JPH::VehicleEngineSettings);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleControllerSettings *)(_this)).mEngine = (MRBINDC_CLASSARG_DEF_CTOR(value, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_COPY(value, (JPH::VehicleEngineSettings), JPH::VehicleEngineSettings) MRBINDC_CLASSARG_MOVE(value, (JPH::VehicleEngineSettings), JPH::VehicleEngineSettings) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_DefaultArgument, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_NoObject, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_END(value, JPH::VehicleEngineSettings));
}

JPH_VehicleEngineSettings *JPH_WheeledVehicleControllerSettings_GetMutable_mEngine(JPH_WheeledVehicleControllerSettings *_this)
{
    return (JPH_VehicleEngineSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleControllerSettings *)(_this)).mEngine);
}

const JPH_VehicleTransmissionSettings *JPH_WheeledVehicleControllerSettings_Get_mTransmission(const JPH_WheeledVehicleControllerSettings *_this)
{
    return (const JPH_VehicleTransmissionSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleControllerSettings *)(_this)).mTransmission);
}

void JPH_WheeledVehicleControllerSettings_Set_mTransmission(JPH_WheeledVehicleControllerSettings *_this, Jolt_PassBy value_pass_by, JPH_VehicleTransmissionSettings *value)
{
    MRBINDC_CLASSARG_GUARD(value, JPH::VehicleTransmissionSettings);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleControllerSettings *)(_this)).mTransmission = (MRBINDC_CLASSARG_DEF_CTOR(value, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_COPY(value, (JPH::VehicleTransmissionSettings), JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_MOVE(value, (JPH::VehicleTransmissionSettings), JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_DefaultArgument, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_NoObject, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_END(value, JPH::VehicleTransmissionSettings));
}

JPH_VehicleTransmissionSettings *JPH_WheeledVehicleControllerSettings_GetMutable_mTransmission(JPH_WheeledVehicleControllerSettings *_this)
{
    return (JPH_VehicleTransmissionSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleControllerSettings *)(_this)).mTransmission);
}

const float *JPH_WheeledVehicleControllerSettings_Get_mDifferentialLimitedSlipRatio(const JPH_WheeledVehicleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleControllerSettings *)(_this)).mDifferentialLimitedSlipRatio);
}

void JPH_WheeledVehicleControllerSettings_Set_mDifferentialLimitedSlipRatio(JPH_WheeledVehicleControllerSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleControllerSettings *)(_this)).mDifferentialLimitedSlipRatio = value;
}

float *JPH_WheeledVehicleControllerSettings_GetMutable_mDifferentialLimitedSlipRatio(JPH_WheeledVehicleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleControllerSettings *)(_this)).mDifferentialLimitedSlipRatio);
}

JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::WheeledVehicleControllerSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_WheeledVehicleControllerSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_WheeledVehicleControllerSettings *)(new JPH::WheeledVehicleControllerSettings[num_elems]{});
}

const JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_OffsetPtr(const JPH_WheeledVehicleControllerSettings *ptr, ptrdiff_t i)
{
    return (const JPH_WheeledVehicleControllerSettings *)(((const JPH::WheeledVehicleControllerSettings *)ptr) + i);
}

JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_OffsetMutablePtr(JPH_WheeledVehicleControllerSettings *ptr, ptrdiff_t i)
{
    return (JPH_WheeledVehicleControllerSettings *)(((JPH::WheeledVehicleControllerSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_SerializableObject(const JPH_WheeledVehicleControllerSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::WheeledVehicleControllerSettings *)object)
    ));
}

JPH_SerializableObject *JPH_WheeledVehicleControllerSettings_MutableUpcastTo_JPH_SerializableObject(JPH_WheeledVehicleControllerSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::WheeledVehicleControllerSettings *)object)
    ));
}

const JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_WheeledVehicleControllerSettings *)(static_cast<const JPH::WheeledVehicleControllerSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_WheeledVehicleControllerSettings *)(static_cast<JPH::WheeledVehicleControllerSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_VehicleControllerSettings *JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_WheeledVehicleControllerSettings *object)
{
    return (const JPH_RefTarget_JPH_VehicleControllerSettings *)(static_cast<const JPH::RefTarget<JPH::VehicleControllerSettings> *>(
        ((const JPH::WheeledVehicleControllerSettings *)object)
    ));
}

JPH_RefTarget_JPH_VehicleControllerSettings *JPH_WheeledVehicleControllerSettings_MutableUpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_WheeledVehicleControllerSettings *object)
{
    return (JPH_RefTarget_JPH_VehicleControllerSettings *)(static_cast<JPH::RefTarget<JPH::VehicleControllerSettings> *>(
        ((JPH::WheeledVehicleControllerSettings *)object)
    ));
}

const JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_RefTarget_JPH_VehicleControllerSettings *object)
{
    return (const JPH_WheeledVehicleControllerSettings *)(static_cast<const JPH::WheeledVehicleControllerSettings *>(
        ((const JPH::RefTarget<JPH::VehicleControllerSettings> *)object)
    ));
}

JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_RefTarget_JPH_VehicleControllerSettings *object)
{
    return (JPH_WheeledVehicleControllerSettings *)(static_cast<JPH::WheeledVehicleControllerSettings *>(
        ((JPH::RefTarget<JPH::VehicleControllerSettings> *)object)
    ));
}

const JPH_VehicleControllerSettings *JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(const JPH_WheeledVehicleControllerSettings *object)
{
    return (const JPH_VehicleControllerSettings *)(static_cast<const JPH::VehicleControllerSettings *>(
        ((const JPH::WheeledVehicleControllerSettings *)object)
    ));
}

JPH_VehicleControllerSettings *JPH_WheeledVehicleControllerSettings_MutableUpcastTo_JPH_VehicleControllerSettings(JPH_WheeledVehicleControllerSettings *object)
{
    return (JPH_VehicleControllerSettings *)(static_cast<JPH::VehicleControllerSettings *>(
        ((JPH::WheeledVehicleControllerSettings *)object)
    ));
}

const JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(const JPH_VehicleControllerSettings *object)
{
    return (const JPH_WheeledVehicleControllerSettings *)(static_cast<const JPH::WheeledVehicleControllerSettings *>(
        ((const JPH::VehicleControllerSettings *)object)
    ));
}

JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_MutableStaticDowncastFrom_JPH_VehicleControllerSettings(JPH_VehicleControllerSettings *object)
{
    return (JPH_WheeledVehicleControllerSettings *)(static_cast<JPH::WheeledVehicleControllerSettings *>(
        ((JPH::VehicleControllerSettings *)object)
    ));
}

JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_WheeledVehicleControllerSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::WheeledVehicleControllerSettings);
    return (JPH_WheeledVehicleControllerSettings *)new JPH::WheeledVehicleControllerSettings(JPH::WheeledVehicleControllerSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::WheeledVehicleControllerSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::WheeledVehicleControllerSettings), JPH::WheeledVehicleControllerSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::WheeledVehicleControllerSettings), JPH::WheeledVehicleControllerSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::WheeledVehicleControllerSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::WheeledVehicleControllerSettings) MRBINDC_CLASSARG_END(_other, JPH::WheeledVehicleControllerSettings))
    ));
}

void JPH_WheeledVehicleControllerSettings_Destroy(const JPH_WheeledVehicleControllerSettings *_this)
{
    delete ((const JPH::WheeledVehicleControllerSettings *)_this);
}

void JPH_WheeledVehicleControllerSettings_DestroyArray(const JPH_WheeledVehicleControllerSettings *_this)
{
    delete[] ((const JPH::WheeledVehicleControllerSettings *)_this);
}

JPH_WheeledVehicleControllerSettings *JPH_WheeledVehicleControllerSettings_AssignFromAnother(JPH_WheeledVehicleControllerSettings *_this, Jolt_PassBy _other_pass_by, JPH_WheeledVehicleControllerSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::WheeledVehicleControllerSettings);
    return (JPH_WheeledVehicleControllerSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleControllerSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::WheeledVehicleControllerSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::WheeledVehicleControllerSettings), JPH::WheeledVehicleControllerSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::WheeledVehicleControllerSettings), JPH::WheeledVehicleControllerSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::WheeledVehicleControllerSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::WheeledVehicleControllerSettings) MRBINDC_CLASSARG_END(_other, JPH::WheeledVehicleControllerSettings))
    ));
}

void *Jolt_new_JPH_WheeledVehicleControllerSettings_size_t(size_t inCount)
{
    return JPH::WheeledVehicleControllerSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr(void *inPointer)
{
    JPH::WheeledVehicleControllerSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::WheeledVehicleControllerSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_WheeledVehicleControllerSettings_size_t(size_t inCount)
{
    return JPH::WheeledVehicleControllerSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr(void *inPointer)
{
    JPH::WheeledVehicleControllerSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::WheeledVehicleControllerSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_WheeledVehicleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::WheeledVehicleControllerSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::WheeledVehicleControllerSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_WheeledVehicleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::WheeledVehicleControllerSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::WheeledVehicleControllerSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_VehicleController *JPH_WheeledVehicleControllerSettings_ConstructController(const JPH_WheeledVehicleControllerSettings *_this, JPH_VehicleConstraint *inConstraint)
{
    return (JPH_VehicleController *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleControllerSettings *)(_this)).ConstructController(
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(JPH::VehicleConstraint *)(inConstraint))
    ));
}

void JPH_WheeledVehicleControllerSettings_SetEmbedded(const JPH_WheeledVehicleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleControllerSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_WheeledVehicleControllerSettings_GetRefCount(const JPH_WheeledVehicleControllerSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleControllerSettings *)(_this)).GetRefCount();
}

void JPH_WheeledVehicleControllerSettings_AddRef(const JPH_WheeledVehicleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleControllerSettings *)(_this)).AddRef();
}

void JPH_WheeledVehicleControllerSettings_Release(const JPH_WheeledVehicleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleControllerSettings *)(_this)).Release();
}

int JPH_WheeledVehicleControllerSettings_sInternalGetRefCountOffset(void)
{
    return JPH::WheeledVehicleControllerSettings::sInternalGetRefCountOffset();
}

JPH_WheeledVehicleController *JPH_WheeledVehicleController_Construct(const JPH_WheeledVehicleControllerSettings *inSettings, JPH_VehicleConstraint *inConstraint)
{
    return (JPH_WheeledVehicleController *)new JPH::WheeledVehicleController(JPH::WheeledVehicleController(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::WheeledVehicleControllerSettings *)(inSettings)),
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(JPH::VehicleConstraint *)(inConstraint))
    ));
}

const JPH_WheeledVehicleController *JPH_WheeledVehicleController_OffsetPtr(const JPH_WheeledVehicleController *ptr, ptrdiff_t i)
{
    return (const JPH_WheeledVehicleController *)(((const JPH::WheeledVehicleController *)ptr) + i);
}

JPH_WheeledVehicleController *JPH_WheeledVehicleController_OffsetMutablePtr(JPH_WheeledVehicleController *ptr, ptrdiff_t i)
{
    return (JPH_WheeledVehicleController *)(((JPH::WheeledVehicleController *)ptr) + i);
}

const JPH_NonCopyable *JPH_WheeledVehicleController_UpcastTo_JPH_NonCopyable(const JPH_WheeledVehicleController *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::WheeledVehicleController *)object)
    ));
}

JPH_NonCopyable *JPH_WheeledVehicleController_MutableUpcastTo_JPH_NonCopyable(JPH_WheeledVehicleController *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::WheeledVehicleController *)object)
    ));
}

const JPH_WheeledVehicleController *JPH_WheeledVehicleController_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_WheeledVehicleController *)(static_cast<const JPH::WheeledVehicleController *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_WheeledVehicleController *JPH_WheeledVehicleController_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_WheeledVehicleController *)(static_cast<JPH::WheeledVehicleController *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_VehicleController *JPH_WheeledVehicleController_UpcastTo_JPH_VehicleController(const JPH_WheeledVehicleController *object)
{
    return (const JPH_VehicleController *)(static_cast<const JPH::VehicleController *>(
        ((const JPH::WheeledVehicleController *)object)
    ));
}

JPH_VehicleController *JPH_WheeledVehicleController_MutableUpcastTo_JPH_VehicleController(JPH_WheeledVehicleController *object)
{
    return (JPH_VehicleController *)(static_cast<JPH::VehicleController *>(
        ((JPH::WheeledVehicleController *)object)
    ));
}

const JPH_WheeledVehicleController *JPH_WheeledVehicleController_StaticDowncastFrom_JPH_VehicleController(const JPH_VehicleController *object)
{
    return (const JPH_WheeledVehicleController *)(static_cast<const JPH::WheeledVehicleController *>(
        ((const JPH::VehicleController *)object)
    ));
}

JPH_WheeledVehicleController *JPH_WheeledVehicleController_MutableStaticDowncastFrom_JPH_VehicleController(JPH_VehicleController *object)
{
    return (JPH_WheeledVehicleController *)(static_cast<JPH::WheeledVehicleController *>(
        ((JPH::VehicleController *)object)
    ));
}

void JPH_WheeledVehicleController_Destroy(const JPH_WheeledVehicleController *_this)
{
    delete ((const JPH::WheeledVehicleController *)_this);
}

void JPH_WheeledVehicleController_DestroyArray(const JPH_WheeledVehicleController *_this)
{
    delete[] ((const JPH::WheeledVehicleController *)_this);
}

void *Jolt_new_JPH_WheeledVehicleController_size_t(size_t inCount)
{
    return JPH::WheeledVehicleController::operator new(
        inCount
    );
}

void Jolt_delete_JPH_WheeledVehicleController_void_ptr(void *inPointer)
{
    JPH::WheeledVehicleController::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_WheeledVehicleController_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::WheeledVehicleController::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_WheeledVehicleController_size_t(size_t inCount)
{
    return JPH::WheeledVehicleController::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_WheeledVehicleController_void_ptr(void *inPointer)
{
    JPH::WheeledVehicleController::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_WheeledVehicleController_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::WheeledVehicleController::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_WheeledVehicleController_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::WheeledVehicleController::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_WheeledVehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::WheeledVehicleController::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_WheeledVehicleController_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::WheeledVehicleController::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_WheeledVehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::WheeledVehicleController::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_WheeledVehicleController_SetDriverInput(JPH_WheeledVehicleController *_this, float inForward, float inRight, float inBrake, float inHandBrake)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleController *)(_this)).SetDriverInput(
        inForward,
        inRight,
        inBrake,
        inHandBrake
    );
}

void JPH_WheeledVehicleController_SetForwardInput(JPH_WheeledVehicleController *_this, float inForward)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleController *)(_this)).SetForwardInput(
        inForward
    );
}

float JPH_WheeledVehicleController_GetForwardInput(const JPH_WheeledVehicleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleController *)(_this)).GetForwardInput();
}

void JPH_WheeledVehicleController_SetRightInput(JPH_WheeledVehicleController *_this, float inRight)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleController *)(_this)).SetRightInput(
        inRight
    );
}

float JPH_WheeledVehicleController_GetRightInput(const JPH_WheeledVehicleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleController *)(_this)).GetRightInput();
}

void JPH_WheeledVehicleController_SetBrakeInput(JPH_WheeledVehicleController *_this, float inBrake)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleController *)(_this)).SetBrakeInput(
        inBrake
    );
}

float JPH_WheeledVehicleController_GetBrakeInput(const JPH_WheeledVehicleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleController *)(_this)).GetBrakeInput();
}

void JPH_WheeledVehicleController_SetHandBrakeInput(JPH_WheeledVehicleController *_this, float inHandBrake)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleController *)(_this)).SetHandBrakeInput(
        inHandBrake
    );
}

float JPH_WheeledVehicleController_GetHandBrakeInput(const JPH_WheeledVehicleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleController *)(_this)).GetHandBrakeInput();
}

const JPH_VehicleEngine *JPH_WheeledVehicleController_GetEngine(const JPH_WheeledVehicleController *_this)
{
    return (const JPH_VehicleEngine *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleController *)(_this)).GetEngine());
}

JPH_VehicleEngine *JPH_WheeledVehicleController_GetEngine_mut(JPH_WheeledVehicleController *_this)
{
    return (JPH_VehicleEngine *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleController *)(_this)).GetEngine());
}

const JPH_VehicleTransmission *JPH_WheeledVehicleController_GetTransmission(const JPH_WheeledVehicleController *_this)
{
    return (const JPH_VehicleTransmission *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleController *)(_this)).GetTransmission());
}

JPH_VehicleTransmission *JPH_WheeledVehicleController_GetTransmission_mut(JPH_WheeledVehicleController *_this)
{
    return (JPH_VehicleTransmission *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleController *)(_this)).GetTransmission());
}

float JPH_WheeledVehicleController_GetDifferentialLimitedSlipRatio(const JPH_WheeledVehicleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleController *)(_this)).GetDifferentialLimitedSlipRatio();
}

void JPH_WheeledVehicleController_SetDifferentialLimitedSlipRatio(JPH_WheeledVehicleController *_this, float inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleController *)(_this)).SetDifferentialLimitedSlipRatio(
        inV
    );
}

float JPH_WheeledVehicleController_GetWheelSpeedAtClutch(const JPH_WheeledVehicleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleController *)(_this)).GetWheelSpeedAtClutch();
}

const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *JPH_WheeledVehicleController_GetTireMaxImpulseCallback(const JPH_WheeledVehicleController *_this)
{
    return (const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheeledVehicleController *)(_this)).GetTireMaxImpulseCallback());
}

void JPH_WheeledVehicleController_SetTireMaxImpulseCallback(JPH_WheeledVehicleController *_this, const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *inTireMaxImpulseCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleController *)(_this)).SetTireMaxImpulseCallback(
        ((inTireMaxImpulseCallback ? void() : MRBINDC_THROW("Parameter `inTireMaxImpulseCallback` can not be null.", void)), *(const std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)> *)(inTireMaxImpulseCallback))
    );
}

void JPH_WheeledVehicleController_SetRPMMeter(JPH_WheeledVehicleController *_this, const JPH_Vec3 *inPosition, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheeledVehicleController *)(_this)).SetRPMMeter(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        inSize
    );
}

