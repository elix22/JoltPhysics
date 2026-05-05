// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Vehicle/VehicleTrack.h"

#include <Jolt/Physics/Vehicle/VehicleTrack.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const unsigned int *JPH_VehicleTrackSettings_Get_mDrivenWheel(const JPH_VehicleTrackSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTrackSettings *)(_this)).mDrivenWheel);
}

void JPH_VehicleTrackSettings_Set_mDrivenWheel(JPH_VehicleTrackSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrackSettings *)(_this)).mDrivenWheel = value;
}

unsigned int *JPH_VehicleTrackSettings_GetMutable_mDrivenWheel(JPH_VehicleTrackSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrackSettings *)(_this)).mDrivenWheel);
}

const float *JPH_VehicleTrackSettings_Get_mInertia(const JPH_VehicleTrackSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTrackSettings *)(_this)).mInertia);
}

void JPH_VehicleTrackSettings_Set_mInertia(JPH_VehicleTrackSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrackSettings *)(_this)).mInertia = value;
}

float *JPH_VehicleTrackSettings_GetMutable_mInertia(JPH_VehicleTrackSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrackSettings *)(_this)).mInertia);
}

const float *JPH_VehicleTrackSettings_Get_mAngularDamping(const JPH_VehicleTrackSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTrackSettings *)(_this)).mAngularDamping);
}

void JPH_VehicleTrackSettings_Set_mAngularDamping(JPH_VehicleTrackSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrackSettings *)(_this)).mAngularDamping = value;
}

float *JPH_VehicleTrackSettings_GetMutable_mAngularDamping(JPH_VehicleTrackSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrackSettings *)(_this)).mAngularDamping);
}

const float *JPH_VehicleTrackSettings_Get_mMaxBrakeTorque(const JPH_VehicleTrackSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTrackSettings *)(_this)).mMaxBrakeTorque);
}

void JPH_VehicleTrackSettings_Set_mMaxBrakeTorque(JPH_VehicleTrackSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrackSettings *)(_this)).mMaxBrakeTorque = value;
}

float *JPH_VehicleTrackSettings_GetMutable_mMaxBrakeTorque(JPH_VehicleTrackSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrackSettings *)(_this)).mMaxBrakeTorque);
}

const float *JPH_VehicleTrackSettings_Get_mDifferentialRatio(const JPH_VehicleTrackSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTrackSettings *)(_this)).mDifferentialRatio);
}

void JPH_VehicleTrackSettings_Set_mDifferentialRatio(JPH_VehicleTrackSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrackSettings *)(_this)).mDifferentialRatio = value;
}

float *JPH_VehicleTrackSettings_GetMutable_mDifferentialRatio(JPH_VehicleTrackSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrackSettings *)(_this)).mDifferentialRatio);
}

JPH_VehicleTrackSettings *JPH_VehicleTrackSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::VehicleTrackSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_VehicleTrackSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_VehicleTrackSettings *JPH_VehicleTrackSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_VehicleTrackSettings *)(new JPH::VehicleTrackSettings[num_elems]);
}

JPH_VehicleTrackSettings *JPH_VehicleTrackSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_VehicleTrackSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::VehicleTrackSettings);
    return (JPH_VehicleTrackSettings *)new JPH::VehicleTrackSettings(JPH::VehicleTrackSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::VehicleTrackSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::VehicleTrackSettings), JPH::VehicleTrackSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::VehicleTrackSettings), JPH::VehicleTrackSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::VehicleTrackSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::VehicleTrackSettings) MRBINDC_CLASSARG_END(_other, JPH::VehicleTrackSettings))
    ));
}

void JPH_VehicleTrackSettings_Destroy(const JPH_VehicleTrackSettings *_this)
{
    delete ((const JPH::VehicleTrackSettings *)_this);
}

void JPH_VehicleTrackSettings_DestroyArray(const JPH_VehicleTrackSettings *_this)
{
    delete[] ((const JPH::VehicleTrackSettings *)_this);
}

JPH_VehicleTrackSettings *JPH_VehicleTrackSettings_AssignFromAnother(JPH_VehicleTrackSettings *_this, Jolt_PassBy _other_pass_by, JPH_VehicleTrackSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::VehicleTrackSettings);
    return (JPH_VehicleTrackSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrackSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::VehicleTrackSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::VehicleTrackSettings), JPH::VehicleTrackSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::VehicleTrackSettings), JPH::VehicleTrackSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::VehicleTrackSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::VehicleTrackSettings) MRBINDC_CLASSARG_END(_other, JPH::VehicleTrackSettings))
    ));
}

void *Jolt_new_JPH_VehicleTrackSettings_size_t(size_t inCount)
{
    return JPH::VehicleTrackSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_VehicleTrackSettings_void_ptr(void *inPointer)
{
    JPH::VehicleTrackSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_VehicleTrackSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleTrackSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_VehicleTrackSettings_size_t(size_t inCount)
{
    return JPH::VehicleTrackSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr(void *inPointer)
{
    JPH::VehicleTrackSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleTrackSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_VehicleTrackSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleTrackSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_VehicleTrackSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleTrackSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_VehicleTrackSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleTrackSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleTrackSettings::operator delete[](
        inPointer,
        inPlace
    );
}

const float *JPH_VehicleTrack_Get_mAngularVelocity(const JPH_VehicleTrack *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTrack *)(_this)).mAngularVelocity);
}

void JPH_VehicleTrack_Set_mAngularVelocity(JPH_VehicleTrack *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrack *)(_this)).mAngularVelocity = value;
}

float *JPH_VehicleTrack_GetMutable_mAngularVelocity(JPH_VehicleTrack *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrack *)(_this)).mAngularVelocity);
}

const unsigned int *JPH_VehicleTrack_Get_mDrivenWheel(const JPH_VehicleTrack *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTrack *)(_this)).mDrivenWheel);
}

void JPH_VehicleTrack_Set_mDrivenWheel(JPH_VehicleTrack *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrack *)(_this)).mDrivenWheel = value;
}

unsigned int *JPH_VehicleTrack_GetMutable_mDrivenWheel(JPH_VehicleTrack *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrack *)(_this)).mDrivenWheel);
}

const float *JPH_VehicleTrack_Get_mInertia(const JPH_VehicleTrack *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTrack *)(_this)).mInertia);
}

void JPH_VehicleTrack_Set_mInertia(JPH_VehicleTrack *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrack *)(_this)).mInertia = value;
}

float *JPH_VehicleTrack_GetMutable_mInertia(JPH_VehicleTrack *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrack *)(_this)).mInertia);
}

const float *JPH_VehicleTrack_Get_mAngularDamping(const JPH_VehicleTrack *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTrack *)(_this)).mAngularDamping);
}

void JPH_VehicleTrack_Set_mAngularDamping(JPH_VehicleTrack *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrack *)(_this)).mAngularDamping = value;
}

float *JPH_VehicleTrack_GetMutable_mAngularDamping(JPH_VehicleTrack *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrack *)(_this)).mAngularDamping);
}

const float *JPH_VehicleTrack_Get_mMaxBrakeTorque(const JPH_VehicleTrack *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTrack *)(_this)).mMaxBrakeTorque);
}

void JPH_VehicleTrack_Set_mMaxBrakeTorque(JPH_VehicleTrack *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrack *)(_this)).mMaxBrakeTorque = value;
}

float *JPH_VehicleTrack_GetMutable_mMaxBrakeTorque(JPH_VehicleTrack *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrack *)(_this)).mMaxBrakeTorque);
}

const float *JPH_VehicleTrack_Get_mDifferentialRatio(const JPH_VehicleTrack *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTrack *)(_this)).mDifferentialRatio);
}

void JPH_VehicleTrack_Set_mDifferentialRatio(JPH_VehicleTrack *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrack *)(_this)).mDifferentialRatio = value;
}

float *JPH_VehicleTrack_GetMutable_mDifferentialRatio(JPH_VehicleTrack *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrack *)(_this)).mDifferentialRatio);
}

JPH_VehicleTrack *JPH_VehicleTrack_DefaultConstruct(void)
{
    using _mrbind_T = JPH::VehicleTrack;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_VehicleTrack*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_VehicleTrack *JPH_VehicleTrack_DefaultConstructArray(size_t num_elems)
{
    return (JPH_VehicleTrack *)(new JPH::VehicleTrack[num_elems]);
}

const JPH_VehicleTrack *JPH_VehicleTrack_OffsetPtr(const JPH_VehicleTrack *ptr, ptrdiff_t i)
{
    return (const JPH_VehicleTrack *)(((const JPH::VehicleTrack *)ptr) + i);
}

JPH_VehicleTrack *JPH_VehicleTrack_OffsetMutablePtr(JPH_VehicleTrack *ptr, ptrdiff_t i)
{
    return (JPH_VehicleTrack *)(((JPH::VehicleTrack *)ptr) + i);
}

const JPH_VehicleTrackSettings *JPH_VehicleTrack_UpcastTo_JPH_VehicleTrackSettings(const JPH_VehicleTrack *object)
{
    return (const JPH_VehicleTrackSettings *)(static_cast<const JPH::VehicleTrackSettings *>(
        ((const JPH::VehicleTrack *)object)
    ));
}

JPH_VehicleTrackSettings *JPH_VehicleTrack_MutableUpcastTo_JPH_VehicleTrackSettings(JPH_VehicleTrack *object)
{
    return (JPH_VehicleTrackSettings *)(static_cast<JPH::VehicleTrackSettings *>(
        ((JPH::VehicleTrack *)object)
    ));
}

const JPH_VehicleTrack *JPH_VehicleTrack_StaticDowncastFrom_JPH_VehicleTrackSettings(const JPH_VehicleTrackSettings *object)
{
    return (const JPH_VehicleTrack *)(static_cast<const JPH::VehicleTrack *>(
        ((const JPH::VehicleTrackSettings *)object)
    ));
}

JPH_VehicleTrack *JPH_VehicleTrack_MutableStaticDowncastFrom_JPH_VehicleTrackSettings(JPH_VehicleTrackSettings *object)
{
    return (JPH_VehicleTrack *)(static_cast<JPH::VehicleTrack *>(
        ((JPH::VehicleTrackSettings *)object)
    ));
}

JPH_VehicleTrack *JPH_VehicleTrack_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_VehicleTrack *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::VehicleTrack);
    return (JPH_VehicleTrack *)new JPH::VehicleTrack(JPH::VehicleTrack(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::VehicleTrack) MRBINDC_CLASSARG_COPY(_other, (JPH::VehicleTrack), JPH::VehicleTrack) MRBINDC_CLASSARG_MOVE(_other, (JPH::VehicleTrack), JPH::VehicleTrack) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::VehicleTrack) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::VehicleTrack) MRBINDC_CLASSARG_END(_other, JPH::VehicleTrack))
    ));
}

void JPH_VehicleTrack_Destroy(const JPH_VehicleTrack *_this)
{
    delete ((const JPH::VehicleTrack *)_this);
}

void JPH_VehicleTrack_DestroyArray(const JPH_VehicleTrack *_this)
{
    delete[] ((const JPH::VehicleTrack *)_this);
}

JPH_VehicleTrack *JPH_VehicleTrack_AssignFromAnother(JPH_VehicleTrack *_this, Jolt_PassBy _other_pass_by, JPH_VehicleTrack *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::VehicleTrack);
    return (JPH_VehicleTrack *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTrack *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::VehicleTrack) MRBINDC_CLASSARG_COPY(_other, (JPH::VehicleTrack), JPH::VehicleTrack) MRBINDC_CLASSARG_MOVE(_other, (JPH::VehicleTrack), JPH::VehicleTrack) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::VehicleTrack) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::VehicleTrack) MRBINDC_CLASSARG_END(_other, JPH::VehicleTrack))
    ));
}

