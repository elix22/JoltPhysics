// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Vehicle/TrackedVehicleController.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Constraints/SpringSettings.h>
#include <Jolt/Physics/Vehicle/TrackedVehicleController.h>
#include <Jolt/Physics/Vehicle/VehicleConstraint.h>
#include <Jolt/Physics/Vehicle/VehicleController.h>
#include <Jolt/Physics/Vehicle/VehicleEngine.h>
#include <Jolt/Physics/Vehicle/VehicleTrack.h>
#include <Jolt/Physics/Vehicle/VehicleTransmission.h>
#include <Jolt/Physics/Vehicle/Wheel.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>
#include <type_traits>


const float *JPH_WheelSettingsTV_Get_mLongitudinalFriction(const JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mLongitudinalFriction);
}

void JPH_WheelSettingsTV_Set_mLongitudinalFriction(JPH_WheelSettingsTV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mLongitudinalFriction = value;
}

float *JPH_WheelSettingsTV_GetMutable_mLongitudinalFriction(JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mLongitudinalFriction);
}

const float *JPH_WheelSettingsTV_Get_mLateralFriction(const JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mLateralFriction);
}

void JPH_WheelSettingsTV_Set_mLateralFriction(JPH_WheelSettingsTV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mLateralFriction = value;
}

float *JPH_WheelSettingsTV_GetMutable_mLateralFriction(JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mLateralFriction);
}

const JPH_Vec3 *JPH_WheelSettingsTV_Get_mPosition(const JPH_WheelSettingsTV *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mPosition);
}

JPH_Vec3 *JPH_WheelSettingsTV_GetMutable_mPosition(JPH_WheelSettingsTV *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mPosition);
}

const JPH_Vec3 *JPH_WheelSettingsTV_Get_mSuspensionForcePoint(const JPH_WheelSettingsTV *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mSuspensionForcePoint);
}

JPH_Vec3 *JPH_WheelSettingsTV_GetMutable_mSuspensionForcePoint(JPH_WheelSettingsTV *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mSuspensionForcePoint);
}

const JPH_Vec3 *JPH_WheelSettingsTV_Get_mSuspensionDirection(const JPH_WheelSettingsTV *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mSuspensionDirection);
}

JPH_Vec3 *JPH_WheelSettingsTV_GetMutable_mSuspensionDirection(JPH_WheelSettingsTV *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mSuspensionDirection);
}

const JPH_Vec3 *JPH_WheelSettingsTV_Get_mSteeringAxis(const JPH_WheelSettingsTV *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mSteeringAxis);
}

JPH_Vec3 *JPH_WheelSettingsTV_GetMutable_mSteeringAxis(JPH_WheelSettingsTV *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mSteeringAxis);
}

const JPH_Vec3 *JPH_WheelSettingsTV_Get_mWheelUp(const JPH_WheelSettingsTV *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mWheelUp);
}

JPH_Vec3 *JPH_WheelSettingsTV_GetMutable_mWheelUp(JPH_WheelSettingsTV *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mWheelUp);
}

const JPH_Vec3 *JPH_WheelSettingsTV_Get_mWheelForward(const JPH_WheelSettingsTV *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mWheelForward);
}

JPH_Vec3 *JPH_WheelSettingsTV_GetMutable_mWheelForward(JPH_WheelSettingsTV *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mWheelForward);
}

const float *JPH_WheelSettingsTV_Get_mSuspensionMinLength(const JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mSuspensionMinLength);
}

void JPH_WheelSettingsTV_Set_mSuspensionMinLength(JPH_WheelSettingsTV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mSuspensionMinLength = value;
}

float *JPH_WheelSettingsTV_GetMutable_mSuspensionMinLength(JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mSuspensionMinLength);
}

const float *JPH_WheelSettingsTV_Get_mSuspensionMaxLength(const JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mSuspensionMaxLength);
}

void JPH_WheelSettingsTV_Set_mSuspensionMaxLength(JPH_WheelSettingsTV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mSuspensionMaxLength = value;
}

float *JPH_WheelSettingsTV_GetMutable_mSuspensionMaxLength(JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mSuspensionMaxLength);
}

const float *JPH_WheelSettingsTV_Get_mSuspensionPreloadLength(const JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mSuspensionPreloadLength);
}

void JPH_WheelSettingsTV_Set_mSuspensionPreloadLength(JPH_WheelSettingsTV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mSuspensionPreloadLength = value;
}

float *JPH_WheelSettingsTV_GetMutable_mSuspensionPreloadLength(JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mSuspensionPreloadLength);
}

const JPH_SpringSettings *JPH_WheelSettingsTV_Get_mSuspensionSpring(const JPH_WheelSettingsTV *_this)
{
    return (const JPH_SpringSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mSuspensionSpring);
}

JPH_SpringSettings *JPH_WheelSettingsTV_GetMutable_mSuspensionSpring(JPH_WheelSettingsTV *_this)
{
    return (JPH_SpringSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mSuspensionSpring);
}

const float *JPH_WheelSettingsTV_Get_mRadius(const JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mRadius);
}

void JPH_WheelSettingsTV_Set_mRadius(JPH_WheelSettingsTV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mRadius = value;
}

float *JPH_WheelSettingsTV_GetMutable_mRadius(JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mRadius);
}

const float *JPH_WheelSettingsTV_Get_mWidth(const JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mWidth);
}

void JPH_WheelSettingsTV_Set_mWidth(JPH_WheelSettingsTV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mWidth = value;
}

float *JPH_WheelSettingsTV_GetMutable_mWidth(JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mWidth);
}

const bool *JPH_WheelSettingsTV_Get_mEnableSuspensionForcePoint(const JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).mEnableSuspensionForcePoint);
}

void JPH_WheelSettingsTV_Set_mEnableSuspensionForcePoint(JPH_WheelSettingsTV *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mEnableSuspensionForcePoint = value;
}

bool *JPH_WheelSettingsTV_GetMutable_mEnableSuspensionForcePoint(JPH_WheelSettingsTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).mEnableSuspensionForcePoint);
}

JPH_WheelSettingsTV *JPH_WheelSettingsTV_DefaultConstruct(void)
{
    using _mrbind_T = JPH::WheelSettingsTV;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_WheelSettingsTV*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_WheelSettingsTV *JPH_WheelSettingsTV_DefaultConstructArray(size_t num_elems)
{
    return (JPH_WheelSettingsTV *)(new JPH::WheelSettingsTV[num_elems]);
}

const JPH_WheelSettingsTV *JPH_WheelSettingsTV_OffsetPtr(const JPH_WheelSettingsTV *ptr, ptrdiff_t i)
{
    return (const JPH_WheelSettingsTV *)(((const JPH::WheelSettingsTV *)ptr) + i);
}

JPH_WheelSettingsTV *JPH_WheelSettingsTV_OffsetMutablePtr(JPH_WheelSettingsTV *ptr, ptrdiff_t i)
{
    return (JPH_WheelSettingsTV *)(((JPH::WheelSettingsTV *)ptr) + i);
}

const JPH_SerializableObject *JPH_WheelSettingsTV_UpcastTo_JPH_SerializableObject(const JPH_WheelSettingsTV *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::WheelSettingsTV *)object)
    ));
}

JPH_SerializableObject *JPH_WheelSettingsTV_MutableUpcastTo_JPH_SerializableObject(JPH_WheelSettingsTV *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::WheelSettingsTV *)object)
    ));
}

const JPH_WheelSettingsTV *JPH_WheelSettingsTV_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_WheelSettingsTV *)(static_cast<const JPH::WheelSettingsTV *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_WheelSettingsTV *JPH_WheelSettingsTV_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_WheelSettingsTV *)(static_cast<JPH::WheelSettingsTV *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_WheelSettings *JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(const JPH_WheelSettingsTV *object)
{
    return (const JPH_RefTarget_JPH_WheelSettings *)(static_cast<const JPH::RefTarget<JPH::WheelSettings> *>(
        ((const JPH::WheelSettingsTV *)object)
    ));
}

JPH_RefTarget_JPH_WheelSettings *JPH_WheelSettingsTV_MutableUpcastTo_JPH_RefTarget_JPH_WheelSettings(JPH_WheelSettingsTV *object)
{
    return (JPH_RefTarget_JPH_WheelSettings *)(static_cast<JPH::RefTarget<JPH::WheelSettings> *>(
        ((JPH::WheelSettingsTV *)object)
    ));
}

const JPH_WheelSettingsTV *JPH_WheelSettingsTV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(const JPH_RefTarget_JPH_WheelSettings *object)
{
    return (const JPH_WheelSettingsTV *)(static_cast<const JPH::WheelSettingsTV *>(
        ((const JPH::RefTarget<JPH::WheelSettings> *)object)
    ));
}

JPH_WheelSettingsTV *JPH_WheelSettingsTV_MutableStaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(JPH_RefTarget_JPH_WheelSettings *object)
{
    return (JPH_WheelSettingsTV *)(static_cast<JPH::WheelSettingsTV *>(
        ((JPH::RefTarget<JPH::WheelSettings> *)object)
    ));
}

const JPH_WheelSettings *JPH_WheelSettingsTV_UpcastTo_JPH_WheelSettings(const JPH_WheelSettingsTV *object)
{
    return (const JPH_WheelSettings *)(static_cast<const JPH::WheelSettings *>(
        ((const JPH::WheelSettingsTV *)object)
    ));
}

JPH_WheelSettings *JPH_WheelSettingsTV_MutableUpcastTo_JPH_WheelSettings(JPH_WheelSettingsTV *object)
{
    return (JPH_WheelSettings *)(static_cast<JPH::WheelSettings *>(
        ((JPH::WheelSettingsTV *)object)
    ));
}

const JPH_WheelSettingsTV *JPH_WheelSettingsTV_StaticDowncastFrom_JPH_WheelSettings(const JPH_WheelSettings *object)
{
    return (const JPH_WheelSettingsTV *)(static_cast<const JPH::WheelSettingsTV *>(
        ((const JPH::WheelSettings *)object)
    ));
}

JPH_WheelSettingsTV *JPH_WheelSettingsTV_MutableStaticDowncastFrom_JPH_WheelSettings(JPH_WheelSettings *object)
{
    return (JPH_WheelSettingsTV *)(static_cast<JPH::WheelSettingsTV *>(
        ((JPH::WheelSettings *)object)
    ));
}

JPH_WheelSettingsTV *JPH_WheelSettingsTV_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_WheelSettingsTV *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::WheelSettingsTV);
    return (JPH_WheelSettingsTV *)new JPH::WheelSettingsTV(JPH::WheelSettingsTV(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::WheelSettingsTV) MRBINDC_CLASSARG_COPY(_other, (JPH::WheelSettingsTV), JPH::WheelSettingsTV) MRBINDC_CLASSARG_MOVE(_other, (JPH::WheelSettingsTV), JPH::WheelSettingsTV) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::WheelSettingsTV) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::WheelSettingsTV) MRBINDC_CLASSARG_END(_other, JPH::WheelSettingsTV))
    ));
}

void JPH_WheelSettingsTV_Destroy(const JPH_WheelSettingsTV *_this)
{
    delete ((const JPH::WheelSettingsTV *)_this);
}

void JPH_WheelSettingsTV_DestroyArray(const JPH_WheelSettingsTV *_this)
{
    delete[] ((const JPH::WheelSettingsTV *)_this);
}

JPH_WheelSettingsTV *JPH_WheelSettingsTV_AssignFromAnother(JPH_WheelSettingsTV *_this, Jolt_PassBy _other_pass_by, JPH_WheelSettingsTV *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::WheelSettingsTV);
    return (JPH_WheelSettingsTV *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelSettingsTV *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::WheelSettingsTV) MRBINDC_CLASSARG_COPY(_other, (JPH::WheelSettingsTV), JPH::WheelSettingsTV) MRBINDC_CLASSARG_MOVE(_other, (JPH::WheelSettingsTV), JPH::WheelSettingsTV) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::WheelSettingsTV) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::WheelSettingsTV) MRBINDC_CLASSARG_END(_other, JPH::WheelSettingsTV))
    ));
}

void *Jolt_new_JPH_WheelSettingsTV_size_t(size_t inCount)
{
    return JPH::WheelSettingsTV::operator new(
        inCount
    );
}

void Jolt_delete_JPH_WheelSettingsTV_void_ptr(void *inPointer)
{
    JPH::WheelSettingsTV::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_WheelSettingsTV_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::WheelSettingsTV::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_WheelSettingsTV_size_t(size_t inCount)
{
    return JPH::WheelSettingsTV::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_WheelSettingsTV_void_ptr(void *inPointer)
{
    JPH::WheelSettingsTV::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_WheelSettingsTV_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::WheelSettingsTV::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_WheelSettingsTV_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::WheelSettingsTV::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_WheelSettingsTV_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::WheelSettingsTV::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_WheelSettingsTV_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::WheelSettingsTV::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_WheelSettingsTV_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::WheelSettingsTV::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_WheelSettingsTV_SetEmbedded(const JPH_WheelSettingsTV *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).SetEmbedded();
}

unsigned int JPH_WheelSettingsTV_GetRefCount(const JPH_WheelSettingsTV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).GetRefCount();
}

void JPH_WheelSettingsTV_AddRef(const JPH_WheelSettingsTV *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).AddRef();
}

void JPH_WheelSettingsTV_Release(const JPH_WheelSettingsTV *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelSettingsTV *)(_this)).Release();
}

int JPH_WheelSettingsTV_sInternalGetRefCountOffset(void)
{
    return JPH::WheelSettingsTV::sInternalGetRefCountOffset();
}

const int *JPH_WheelTV_Get_mTrackIndex(const JPH_WheelTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).mTrackIndex);
}

void JPH_WheelTV_Set_mTrackIndex(JPH_WheelTV *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).mTrackIndex = value;
}

int *JPH_WheelTV_GetMutable_mTrackIndex(JPH_WheelTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).mTrackIndex);
}

const float *JPH_WheelTV_Get_mCombinedLongitudinalFriction(const JPH_WheelTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).mCombinedLongitudinalFriction);
}

void JPH_WheelTV_Set_mCombinedLongitudinalFriction(JPH_WheelTV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).mCombinedLongitudinalFriction = value;
}

float *JPH_WheelTV_GetMutable_mCombinedLongitudinalFriction(JPH_WheelTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).mCombinedLongitudinalFriction);
}

const float *JPH_WheelTV_Get_mCombinedLateralFriction(const JPH_WheelTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).mCombinedLateralFriction);
}

void JPH_WheelTV_Set_mCombinedLateralFriction(JPH_WheelTV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).mCombinedLateralFriction = value;
}

float *JPH_WheelTV_GetMutable_mCombinedLateralFriction(JPH_WheelTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).mCombinedLateralFriction);
}

const float *JPH_WheelTV_Get_mBrakeImpulse(const JPH_WheelTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).mBrakeImpulse);
}

void JPH_WheelTV_Set_mBrakeImpulse(JPH_WheelTV *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).mBrakeImpulse = value;
}

float *JPH_WheelTV_GetMutable_mBrakeImpulse(JPH_WheelTV *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).mBrakeImpulse);
}

JPH_WheelTV *JPH_WheelTV_Construct(const JPH_WheelSettingsTV *inWheel)
{
    return (JPH_WheelTV *)new JPH::WheelTV(JPH::WheelTV(
        ((inWheel ? void() : MRBINDC_THROW("Parameter `inWheel` can not be null.", void)), *(const JPH::WheelSettingsTV *)(inWheel))
    ));
}

const JPH_WheelTV *JPH_WheelTV_OffsetPtr(const JPH_WheelTV *ptr, ptrdiff_t i)
{
    return (const JPH_WheelTV *)(((const JPH::WheelTV *)ptr) + i);
}

JPH_WheelTV *JPH_WheelTV_OffsetMutablePtr(JPH_WheelTV *ptr, ptrdiff_t i)
{
    return (JPH_WheelTV *)(((JPH::WheelTV *)ptr) + i);
}

const JPH_NonCopyable *JPH_WheelTV_UpcastTo_JPH_NonCopyable(const JPH_WheelTV *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::WheelTV *)object)
    ));
}

JPH_NonCopyable *JPH_WheelTV_MutableUpcastTo_JPH_NonCopyable(JPH_WheelTV *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::WheelTV *)object)
    ));
}

const JPH_WheelTV *JPH_WheelTV_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_WheelTV *)(static_cast<const JPH::WheelTV *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_WheelTV *JPH_WheelTV_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_WheelTV *)(static_cast<JPH::WheelTV *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Wheel *JPH_WheelTV_UpcastTo_JPH_Wheel(const JPH_WheelTV *object)
{
    return (const JPH_Wheel *)(static_cast<const JPH::Wheel *>(
        ((const JPH::WheelTV *)object)
    ));
}

JPH_Wheel *JPH_WheelTV_MutableUpcastTo_JPH_Wheel(JPH_WheelTV *object)
{
    return (JPH_Wheel *)(static_cast<JPH::Wheel *>(
        ((JPH::WheelTV *)object)
    ));
}

const JPH_WheelTV *JPH_WheelTV_StaticDowncastFrom_JPH_Wheel(const JPH_Wheel *object)
{
    return (const JPH_WheelTV *)(static_cast<const JPH::WheelTV *>(
        ((const JPH::Wheel *)object)
    ));
}

JPH_WheelTV *JPH_WheelTV_MutableStaticDowncastFrom_JPH_Wheel(JPH_Wheel *object)
{
    return (JPH_WheelTV *)(static_cast<JPH::WheelTV *>(
        ((JPH::Wheel *)object)
    ));
}

void JPH_WheelTV_Destroy(const JPH_WheelTV *_this)
{
    delete ((const JPH::WheelTV *)_this);
}

void JPH_WheelTV_DestroyArray(const JPH_WheelTV *_this)
{
    delete[] ((const JPH::WheelTV *)_this);
}

void *Jolt_new_JPH_WheelTV_size_t(size_t inCount)
{
    return JPH::WheelTV::operator new(
        inCount
    );
}

void Jolt_delete_JPH_WheelTV_void_ptr(void *inPointer)
{
    JPH::WheelTV::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_WheelTV_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::WheelTV::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_WheelTV_size_t(size_t inCount)
{
    return JPH::WheelTV::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_WheelTV_void_ptr(void *inPointer)
{
    JPH::WheelTV::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_WheelTV_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::WheelTV::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_WheelTV_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::WheelTV::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_WheelTV_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::WheelTV::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_WheelTV_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::WheelTV::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_WheelTV_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::WheelTV::operator delete[](
        inPointer,
        inPlace
    );
}

const JPH_WheelSettingsTV *JPH_WheelTV_GetSettings(const JPH_WheelTV *_this)
{
    return (const JPH_WheelSettingsTV *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetSettings());
}

void JPH_WheelTV_CalculateAngularVelocity(JPH_WheelTV *_this, const JPH_VehicleConstraint *inConstraint)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).CalculateAngularVelocity(
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inConstraint))
    );
}

void JPH_WheelTV_Update(JPH_WheelTV *_this, unsigned int inWheelIndex, float inDeltaTime, const JPH_VehicleConstraint *inConstraint)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).Update(
        inWheelIndex,
        inDeltaTime,
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inConstraint))
    );
}

float JPH_WheelTV_GetAngularVelocity(const JPH_WheelTV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetAngularVelocity();
}

void JPH_WheelTV_SetAngularVelocity(JPH_WheelTV *_this, float inVel)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).SetAngularVelocity(
        inVel
    );
}

float JPH_WheelTV_GetRotationAngle(const JPH_WheelTV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetRotationAngle();
}

void JPH_WheelTV_SetRotationAngle(JPH_WheelTV *_this, float inAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).SetRotationAngle(
        inAngle
    );
}

float JPH_WheelTV_GetSteerAngle(const JPH_WheelTV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetSteerAngle();
}

void JPH_WheelTV_SetSteerAngle(JPH_WheelTV *_this, float inAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).SetSteerAngle(
        inAngle
    );
}

bool JPH_WheelTV_HasContact(const JPH_WheelTV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).HasContact();
}

JPH_BodyID JPH_WheelTV_GetContactBodyID(const JPH_WheelTV *_this)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetContactBodyID());
}

JPH_SubShapeID *JPH_WheelTV_GetContactSubShapeID(const JPH_WheelTV *_this)
{
    return (JPH_SubShapeID *)new JPH::SubShapeID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetContactSubShapeID());
}

JPH_Vec3 *JPH_WheelTV_GetContactPosition(const JPH_WheelTV *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetContactPosition());
}

JPH_Vec3 *JPH_WheelTV_GetContactPointVelocity(const JPH_WheelTV *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetContactPointVelocity());
}

JPH_Vec3 *JPH_WheelTV_GetContactNormal(const JPH_WheelTV *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetContactNormal());
}

JPH_Vec3 *JPH_WheelTV_GetContactLongitudinal(const JPH_WheelTV *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetContactLongitudinal());
}

JPH_Vec3 *JPH_WheelTV_GetContactLateral(const JPH_WheelTV *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetContactLateral());
}

float JPH_WheelTV_GetSuspensionLength(const JPH_WheelTV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetSuspensionLength();
}

bool JPH_WheelTV_HasHitHardPoint(const JPH_WheelTV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).HasHitHardPoint();
}

float JPH_WheelTV_GetSuspensionLambda(const JPH_WheelTV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetSuspensionLambda();
}

float JPH_WheelTV_GetLongitudinalLambda(const JPH_WheelTV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetLongitudinalLambda();
}

float JPH_WheelTV_GetLateralLambda(const JPH_WheelTV *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::WheelTV *)(_this)).GetLateralLambda();
}

bool JPH_WheelTV_SolveLongitudinalConstraintPart(JPH_WheelTV *_this, const JPH_VehicleConstraint *inConstraint, float inMinImpulse, float inMaxImpulse)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).SolveLongitudinalConstraintPart(
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inConstraint)),
        inMinImpulse,
        inMaxImpulse
    );
}

bool JPH_WheelTV_SolveLateralConstraintPart(JPH_WheelTV *_this, const JPH_VehicleConstraint *inConstraint, float inMinImpulse, float inMaxImpulse)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::WheelTV *)(_this)).SolveLateralConstraintPart(
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inConstraint)),
        inMinImpulse,
        inMaxImpulse
    );
}

const JPH_VehicleEngineSettings *JPH_TrackedVehicleControllerSettings_Get_mEngine(const JPH_TrackedVehicleControllerSettings *_this)
{
    return (const JPH_VehicleEngineSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TrackedVehicleControllerSettings *)(_this)).mEngine);
}

void JPH_TrackedVehicleControllerSettings_Set_mEngine(JPH_TrackedVehicleControllerSettings *_this, Jolt_PassBy value_pass_by, JPH_VehicleEngineSettings *value)
{
    MRBINDC_CLASSARG_GUARD(value, JPH::VehicleEngineSettings);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TrackedVehicleControllerSettings *)(_this)).mEngine = (MRBINDC_CLASSARG_DEF_CTOR(value, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_COPY(value, (JPH::VehicleEngineSettings), JPH::VehicleEngineSettings) MRBINDC_CLASSARG_MOVE(value, (JPH::VehicleEngineSettings), JPH::VehicleEngineSettings) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_DefaultArgument, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_NoObject, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_END(value, JPH::VehicleEngineSettings));
}

JPH_VehicleEngineSettings *JPH_TrackedVehicleControllerSettings_GetMutable_mEngine(JPH_TrackedVehicleControllerSettings *_this)
{
    return (JPH_VehicleEngineSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TrackedVehicleControllerSettings *)(_this)).mEngine);
}

const JPH_VehicleTransmissionSettings *JPH_TrackedVehicleControllerSettings_Get_mTransmission(const JPH_TrackedVehicleControllerSettings *_this)
{
    return (const JPH_VehicleTransmissionSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TrackedVehicleControllerSettings *)(_this)).mTransmission);
}

void JPH_TrackedVehicleControllerSettings_Set_mTransmission(JPH_TrackedVehicleControllerSettings *_this, Jolt_PassBy value_pass_by, JPH_VehicleTransmissionSettings *value)
{
    MRBINDC_CLASSARG_GUARD(value, JPH::VehicleTransmissionSettings);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TrackedVehicleControllerSettings *)(_this)).mTransmission = (MRBINDC_CLASSARG_DEF_CTOR(value, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_COPY(value, (JPH::VehicleTransmissionSettings), JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_MOVE(value, (JPH::VehicleTransmissionSettings), JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_DefaultArgument, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_NoObject, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_END(value, JPH::VehicleTransmissionSettings));
}

JPH_VehicleTransmissionSettings *JPH_TrackedVehicleControllerSettings_GetMutable_mTransmission(JPH_TrackedVehicleControllerSettings *_this)
{
    return (JPH_VehicleTransmissionSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TrackedVehicleControllerSettings *)(_this)).mTransmission);
}

const JPH_VehicleTrackSettings *JPH_TrackedVehicleControllerSettings_Get_mTracks(const JPH_TrackedVehicleControllerSettings *_this)
{
    return (const JPH_VehicleTrackSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TrackedVehicleControllerSettings *)(_this)).mTracks[0]);
}

JPH_VehicleTrackSettings *JPH_TrackedVehicleControllerSettings_GetMutable_mTracks(JPH_TrackedVehicleControllerSettings *_this)
{
    return (JPH_VehicleTrackSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TrackedVehicleControllerSettings *)(_this)).mTracks[0]);
}

size_t JPH_TrackedVehicleControllerSettings_GetSize_mTracks(void)
{
    return std::extent_v<decltype(JPH::TrackedVehicleControllerSettings::mTracks)>;
}

JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::TrackedVehicleControllerSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_TrackedVehicleControllerSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_TrackedVehicleControllerSettings *)(new JPH::TrackedVehicleControllerSettings[num_elems]);
}

const JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_OffsetPtr(const JPH_TrackedVehicleControllerSettings *ptr, ptrdiff_t i)
{
    return (const JPH_TrackedVehicleControllerSettings *)(((const JPH::TrackedVehicleControllerSettings *)ptr) + i);
}

JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_OffsetMutablePtr(JPH_TrackedVehicleControllerSettings *ptr, ptrdiff_t i)
{
    return (JPH_TrackedVehicleControllerSettings *)(((JPH::TrackedVehicleControllerSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_SerializableObject(const JPH_TrackedVehicleControllerSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::TrackedVehicleControllerSettings *)object)
    ));
}

JPH_SerializableObject *JPH_TrackedVehicleControllerSettings_MutableUpcastTo_JPH_SerializableObject(JPH_TrackedVehicleControllerSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::TrackedVehicleControllerSettings *)object)
    ));
}

const JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_TrackedVehicleControllerSettings *)(static_cast<const JPH::TrackedVehicleControllerSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_TrackedVehicleControllerSettings *)(static_cast<JPH::TrackedVehicleControllerSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_VehicleControllerSettings *JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_TrackedVehicleControllerSettings *object)
{
    return (const JPH_RefTarget_JPH_VehicleControllerSettings *)(static_cast<const JPH::RefTarget<JPH::VehicleControllerSettings> *>(
        ((const JPH::TrackedVehicleControllerSettings *)object)
    ));
}

JPH_RefTarget_JPH_VehicleControllerSettings *JPH_TrackedVehicleControllerSettings_MutableUpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_TrackedVehicleControllerSettings *object)
{
    return (JPH_RefTarget_JPH_VehicleControllerSettings *)(static_cast<JPH::RefTarget<JPH::VehicleControllerSettings> *>(
        ((JPH::TrackedVehicleControllerSettings *)object)
    ));
}

const JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_RefTarget_JPH_VehicleControllerSettings *object)
{
    return (const JPH_TrackedVehicleControllerSettings *)(static_cast<const JPH::TrackedVehicleControllerSettings *>(
        ((const JPH::RefTarget<JPH::VehicleControllerSettings> *)object)
    ));
}

JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_RefTarget_JPH_VehicleControllerSettings *object)
{
    return (JPH_TrackedVehicleControllerSettings *)(static_cast<JPH::TrackedVehicleControllerSettings *>(
        ((JPH::RefTarget<JPH::VehicleControllerSettings> *)object)
    ));
}

const JPH_VehicleControllerSettings *JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(const JPH_TrackedVehicleControllerSettings *object)
{
    return (const JPH_VehicleControllerSettings *)(static_cast<const JPH::VehicleControllerSettings *>(
        ((const JPH::TrackedVehicleControllerSettings *)object)
    ));
}

JPH_VehicleControllerSettings *JPH_TrackedVehicleControllerSettings_MutableUpcastTo_JPH_VehicleControllerSettings(JPH_TrackedVehicleControllerSettings *object)
{
    return (JPH_VehicleControllerSettings *)(static_cast<JPH::VehicleControllerSettings *>(
        ((JPH::TrackedVehicleControllerSettings *)object)
    ));
}

const JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(const JPH_VehicleControllerSettings *object)
{
    return (const JPH_TrackedVehicleControllerSettings *)(static_cast<const JPH::TrackedVehicleControllerSettings *>(
        ((const JPH::VehicleControllerSettings *)object)
    ));
}

JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_MutableStaticDowncastFrom_JPH_VehicleControllerSettings(JPH_VehicleControllerSettings *object)
{
    return (JPH_TrackedVehicleControllerSettings *)(static_cast<JPH::TrackedVehicleControllerSettings *>(
        ((JPH::VehicleControllerSettings *)object)
    ));
}

JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_TrackedVehicleControllerSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::TrackedVehicleControllerSettings);
    return (JPH_TrackedVehicleControllerSettings *)new JPH::TrackedVehicleControllerSettings(JPH::TrackedVehicleControllerSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::TrackedVehicleControllerSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::TrackedVehicleControllerSettings), JPH::TrackedVehicleControllerSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::TrackedVehicleControllerSettings), JPH::TrackedVehicleControllerSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::TrackedVehicleControllerSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::TrackedVehicleControllerSettings) MRBINDC_CLASSARG_END(_other, JPH::TrackedVehicleControllerSettings))
    ));
}

void JPH_TrackedVehicleControllerSettings_Destroy(const JPH_TrackedVehicleControllerSettings *_this)
{
    delete ((const JPH::TrackedVehicleControllerSettings *)_this);
}

void JPH_TrackedVehicleControllerSettings_DestroyArray(const JPH_TrackedVehicleControllerSettings *_this)
{
    delete[] ((const JPH::TrackedVehicleControllerSettings *)_this);
}

JPH_TrackedVehicleControllerSettings *JPH_TrackedVehicleControllerSettings_AssignFromAnother(JPH_TrackedVehicleControllerSettings *_this, Jolt_PassBy _other_pass_by, JPH_TrackedVehicleControllerSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::TrackedVehicleControllerSettings);
    return (JPH_TrackedVehicleControllerSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TrackedVehicleControllerSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::TrackedVehicleControllerSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::TrackedVehicleControllerSettings), JPH::TrackedVehicleControllerSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::TrackedVehicleControllerSettings), JPH::TrackedVehicleControllerSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::TrackedVehicleControllerSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::TrackedVehicleControllerSettings) MRBINDC_CLASSARG_END(_other, JPH::TrackedVehicleControllerSettings))
    ));
}

void *Jolt_new_JPH_TrackedVehicleControllerSettings_size_t(size_t inCount)
{
    return JPH::TrackedVehicleControllerSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr(void *inPointer)
{
    JPH::TrackedVehicleControllerSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TrackedVehicleControllerSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TrackedVehicleControllerSettings_size_t(size_t inCount)
{
    return JPH::TrackedVehicleControllerSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr(void *inPointer)
{
    JPH::TrackedVehicleControllerSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TrackedVehicleControllerSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TrackedVehicleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TrackedVehicleControllerSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TrackedVehicleControllerSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TrackedVehicleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TrackedVehicleControllerSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TrackedVehicleControllerSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_VehicleController *JPH_TrackedVehicleControllerSettings_ConstructController(const JPH_TrackedVehicleControllerSettings *_this, JPH_VehicleConstraint *inConstraint)
{
    return (JPH_VehicleController *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TrackedVehicleControllerSettings *)(_this)).ConstructController(
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(JPH::VehicleConstraint *)(inConstraint))
    ));
}

void JPH_TrackedVehicleControllerSettings_SetEmbedded(const JPH_TrackedVehicleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TrackedVehicleControllerSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_TrackedVehicleControllerSettings_GetRefCount(const JPH_TrackedVehicleControllerSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TrackedVehicleControllerSettings *)(_this)).GetRefCount();
}

void JPH_TrackedVehicleControllerSettings_AddRef(const JPH_TrackedVehicleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TrackedVehicleControllerSettings *)(_this)).AddRef();
}

void JPH_TrackedVehicleControllerSettings_Release(const JPH_TrackedVehicleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TrackedVehicleControllerSettings *)(_this)).Release();
}

int JPH_TrackedVehicleControllerSettings_sInternalGetRefCountOffset(void)
{
    return JPH::TrackedVehicleControllerSettings::sInternalGetRefCountOffset();
}

JPH_TrackedVehicleController *JPH_TrackedVehicleController_Construct(const JPH_TrackedVehicleControllerSettings *inSettings, JPH_VehicleConstraint *inConstraint)
{
    return (JPH_TrackedVehicleController *)new JPH::TrackedVehicleController(JPH::TrackedVehicleController(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::TrackedVehicleControllerSettings *)(inSettings)),
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(JPH::VehicleConstraint *)(inConstraint))
    ));
}

const JPH_TrackedVehicleController *JPH_TrackedVehicleController_OffsetPtr(const JPH_TrackedVehicleController *ptr, ptrdiff_t i)
{
    return (const JPH_TrackedVehicleController *)(((const JPH::TrackedVehicleController *)ptr) + i);
}

JPH_TrackedVehicleController *JPH_TrackedVehicleController_OffsetMutablePtr(JPH_TrackedVehicleController *ptr, ptrdiff_t i)
{
    return (JPH_TrackedVehicleController *)(((JPH::TrackedVehicleController *)ptr) + i);
}

const JPH_NonCopyable *JPH_TrackedVehicleController_UpcastTo_JPH_NonCopyable(const JPH_TrackedVehicleController *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::TrackedVehicleController *)object)
    ));
}

JPH_NonCopyable *JPH_TrackedVehicleController_MutableUpcastTo_JPH_NonCopyable(JPH_TrackedVehicleController *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::TrackedVehicleController *)object)
    ));
}

const JPH_TrackedVehicleController *JPH_TrackedVehicleController_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_TrackedVehicleController *)(static_cast<const JPH::TrackedVehicleController *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_TrackedVehicleController *JPH_TrackedVehicleController_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_TrackedVehicleController *)(static_cast<JPH::TrackedVehicleController *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_VehicleController *JPH_TrackedVehicleController_UpcastTo_JPH_VehicleController(const JPH_TrackedVehicleController *object)
{
    return (const JPH_VehicleController *)(static_cast<const JPH::VehicleController *>(
        ((const JPH::TrackedVehicleController *)object)
    ));
}

JPH_VehicleController *JPH_TrackedVehicleController_MutableUpcastTo_JPH_VehicleController(JPH_TrackedVehicleController *object)
{
    return (JPH_VehicleController *)(static_cast<JPH::VehicleController *>(
        ((JPH::TrackedVehicleController *)object)
    ));
}

const JPH_TrackedVehicleController *JPH_TrackedVehicleController_StaticDowncastFrom_JPH_VehicleController(const JPH_VehicleController *object)
{
    return (const JPH_TrackedVehicleController *)(static_cast<const JPH::TrackedVehicleController *>(
        ((const JPH::VehicleController *)object)
    ));
}

JPH_TrackedVehicleController *JPH_TrackedVehicleController_MutableStaticDowncastFrom_JPH_VehicleController(JPH_VehicleController *object)
{
    return (JPH_TrackedVehicleController *)(static_cast<JPH::TrackedVehicleController *>(
        ((JPH::VehicleController *)object)
    ));
}

void JPH_TrackedVehicleController_Destroy(const JPH_TrackedVehicleController *_this)
{
    delete ((const JPH::TrackedVehicleController *)_this);
}

void JPH_TrackedVehicleController_DestroyArray(const JPH_TrackedVehicleController *_this)
{
    delete[] ((const JPH::TrackedVehicleController *)_this);
}

void *Jolt_new_JPH_TrackedVehicleController_size_t(size_t inCount)
{
    return JPH::TrackedVehicleController::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TrackedVehicleController_void_ptr(void *inPointer)
{
    JPH::TrackedVehicleController::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TrackedVehicleController_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TrackedVehicleController::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TrackedVehicleController_size_t(size_t inCount)
{
    return JPH::TrackedVehicleController::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TrackedVehicleController_void_ptr(void *inPointer)
{
    JPH::TrackedVehicleController::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TrackedVehicleController_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TrackedVehicleController::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TrackedVehicleController_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TrackedVehicleController::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TrackedVehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TrackedVehicleController::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TrackedVehicleController_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TrackedVehicleController::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TrackedVehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TrackedVehicleController::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_TrackedVehicleController_SetDriverInput(JPH_TrackedVehicleController *_this, float inForward, float inLeftRatio, float inRightRatio, float inBrake)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TrackedVehicleController *)(_this)).SetDriverInput(
        inForward,
        inLeftRatio,
        inRightRatio,
        inBrake
    );
}

void JPH_TrackedVehicleController_SetForwardInput(JPH_TrackedVehicleController *_this, float inForward)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TrackedVehicleController *)(_this)).SetForwardInput(
        inForward
    );
}

float JPH_TrackedVehicleController_GetForwardInput(const JPH_TrackedVehicleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TrackedVehicleController *)(_this)).GetForwardInput();
}

void JPH_TrackedVehicleController_SetLeftRatio(JPH_TrackedVehicleController *_this, float inLeftRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TrackedVehicleController *)(_this)).SetLeftRatio(
        inLeftRatio
    );
}

float JPH_TrackedVehicleController_GetLeftRatio(const JPH_TrackedVehicleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TrackedVehicleController *)(_this)).GetLeftRatio();
}

void JPH_TrackedVehicleController_SetRightRatio(JPH_TrackedVehicleController *_this, float inRightRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TrackedVehicleController *)(_this)).SetRightRatio(
        inRightRatio
    );
}

float JPH_TrackedVehicleController_GetRightRatio(const JPH_TrackedVehicleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TrackedVehicleController *)(_this)).GetRightRatio();
}

void JPH_TrackedVehicleController_SetBrakeInput(JPH_TrackedVehicleController *_this, float inBrake)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TrackedVehicleController *)(_this)).SetBrakeInput(
        inBrake
    );
}

float JPH_TrackedVehicleController_GetBrakeInput(const JPH_TrackedVehicleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TrackedVehicleController *)(_this)).GetBrakeInput();
}

const JPH_VehicleEngine *JPH_TrackedVehicleController_GetEngine(const JPH_TrackedVehicleController *_this)
{
    return (const JPH_VehicleEngine *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TrackedVehicleController *)(_this)).GetEngine());
}

JPH_VehicleEngine *JPH_TrackedVehicleController_GetEngine_mut(JPH_TrackedVehicleController *_this)
{
    return (JPH_VehicleEngine *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TrackedVehicleController *)(_this)).GetEngine());
}

const JPH_VehicleTransmission *JPH_TrackedVehicleController_GetTransmission(const JPH_TrackedVehicleController *_this)
{
    return (const JPH_VehicleTransmission *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TrackedVehicleController *)(_this)).GetTransmission());
}

JPH_VehicleTransmission *JPH_TrackedVehicleController_GetTransmission_mut(JPH_TrackedVehicleController *_this)
{
    return (JPH_VehicleTransmission *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TrackedVehicleController *)(_this)).GetTransmission());
}

void JPH_TrackedVehicleController_SetRPMMeter(JPH_TrackedVehicleController *_this, const JPH_Vec3 *inPosition, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TrackedVehicleController *)(_this)).SetRPMMeter(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        inSize
    );
}

