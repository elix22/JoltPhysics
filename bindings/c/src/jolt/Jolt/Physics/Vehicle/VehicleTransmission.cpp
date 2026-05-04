// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Vehicle/VehicleTransmission.h"

#include <Jolt/Physics/Vehicle/VehicleTransmission.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_ETransmissionMode *JPH_VehicleTransmissionSettings_Get_mMode(const JPH_VehicleTransmissionSettings *_this)
{
    return (const JPH_ETransmissionMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmissionSettings *)(_this)).mMode);
}

void JPH_VehicleTransmissionSettings_Set_mMode(JPH_VehicleTransmissionSettings *_this, JPH_ETransmissionMode value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).mMode = ((JPH::ETransmissionMode)value);
}

JPH_ETransmissionMode *JPH_VehicleTransmissionSettings_GetMutable_mMode(JPH_VehicleTransmissionSettings *_this)
{
    return (JPH_ETransmissionMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).mMode);
}

const float *JPH_VehicleTransmissionSettings_Get_mSwitchTime(const JPH_VehicleTransmissionSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmissionSettings *)(_this)).mSwitchTime);
}

void JPH_VehicleTransmissionSettings_Set_mSwitchTime(JPH_VehicleTransmissionSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).mSwitchTime = value;
}

float *JPH_VehicleTransmissionSettings_GetMutable_mSwitchTime(JPH_VehicleTransmissionSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).mSwitchTime);
}

const float *JPH_VehicleTransmissionSettings_Get_mClutchReleaseTime(const JPH_VehicleTransmissionSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmissionSettings *)(_this)).mClutchReleaseTime);
}

void JPH_VehicleTransmissionSettings_Set_mClutchReleaseTime(JPH_VehicleTransmissionSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).mClutchReleaseTime = value;
}

float *JPH_VehicleTransmissionSettings_GetMutable_mClutchReleaseTime(JPH_VehicleTransmissionSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).mClutchReleaseTime);
}

const float *JPH_VehicleTransmissionSettings_Get_mSwitchLatency(const JPH_VehicleTransmissionSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmissionSettings *)(_this)).mSwitchLatency);
}

void JPH_VehicleTransmissionSettings_Set_mSwitchLatency(JPH_VehicleTransmissionSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).mSwitchLatency = value;
}

float *JPH_VehicleTransmissionSettings_GetMutable_mSwitchLatency(JPH_VehicleTransmissionSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).mSwitchLatency);
}

const float *JPH_VehicleTransmissionSettings_Get_mShiftUpRPM(const JPH_VehicleTransmissionSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmissionSettings *)(_this)).mShiftUpRPM);
}

void JPH_VehicleTransmissionSettings_Set_mShiftUpRPM(JPH_VehicleTransmissionSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).mShiftUpRPM = value;
}

float *JPH_VehicleTransmissionSettings_GetMutable_mShiftUpRPM(JPH_VehicleTransmissionSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).mShiftUpRPM);
}

const float *JPH_VehicleTransmissionSettings_Get_mShiftDownRPM(const JPH_VehicleTransmissionSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmissionSettings *)(_this)).mShiftDownRPM);
}

void JPH_VehicleTransmissionSettings_Set_mShiftDownRPM(JPH_VehicleTransmissionSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).mShiftDownRPM = value;
}

float *JPH_VehicleTransmissionSettings_GetMutable_mShiftDownRPM(JPH_VehicleTransmissionSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).mShiftDownRPM);
}

const float *JPH_VehicleTransmissionSettings_Get_mClutchStrength(const JPH_VehicleTransmissionSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmissionSettings *)(_this)).mClutchStrength);
}

void JPH_VehicleTransmissionSettings_Set_mClutchStrength(JPH_VehicleTransmissionSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).mClutchStrength = value;
}

float *JPH_VehicleTransmissionSettings_GetMutable_mClutchStrength(JPH_VehicleTransmissionSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).mClutchStrength);
}

JPH_VehicleTransmissionSettings *JPH_VehicleTransmissionSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::VehicleTransmissionSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_VehicleTransmissionSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_VehicleTransmissionSettings *JPH_VehicleTransmissionSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_VehicleTransmissionSettings *)(new JPH::VehicleTransmissionSettings[num_elems]);
}

JPH_VehicleTransmissionSettings *JPH_VehicleTransmissionSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_VehicleTransmissionSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::VehicleTransmissionSettings);
    return (JPH_VehicleTransmissionSettings *)new JPH::VehicleTransmissionSettings(JPH::VehicleTransmissionSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::VehicleTransmissionSettings), JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::VehicleTransmissionSettings), JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_END(_other, JPH::VehicleTransmissionSettings))
    ));
}

void JPH_VehicleTransmissionSettings_Destroy(const JPH_VehicleTransmissionSettings *_this)
{
    delete ((const JPH::VehicleTransmissionSettings *)_this);
}

void JPH_VehicleTransmissionSettings_DestroyArray(const JPH_VehicleTransmissionSettings *_this)
{
    delete[] ((const JPH::VehicleTransmissionSettings *)_this);
}

JPH_VehicleTransmissionSettings *JPH_VehicleTransmissionSettings_AssignFromAnother(JPH_VehicleTransmissionSettings *_this, Jolt_PassBy _other_pass_by, JPH_VehicleTransmissionSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::VehicleTransmissionSettings);
    return (JPH_VehicleTransmissionSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::VehicleTransmissionSettings), JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::VehicleTransmissionSettings), JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_END(_other, JPH::VehicleTransmissionSettings))
    ));
}

void *Jolt_new_JPH_VehicleTransmissionSettings_size_t(size_t inCount)
{
    return JPH::VehicleTransmissionSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr(void *inPointer)
{
    JPH::VehicleTransmissionSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleTransmissionSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_VehicleTransmissionSettings_size_t(size_t inCount)
{
    return JPH::VehicleTransmissionSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr(void *inPointer)
{
    JPH::VehicleTransmissionSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleTransmissionSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_VehicleTransmissionSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleTransmissionSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleTransmissionSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_VehicleTransmissionSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleTransmissionSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleTransmissionSettings::operator delete[](
        inPointer,
        inPlace
    );
}

const JPH_ETransmissionMode *JPH_VehicleTransmission_Get_mMode(const JPH_VehicleTransmission *_this)
{
    return (const JPH_ETransmissionMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmission *)(_this)).mMode);
}

void JPH_VehicleTransmission_Set_mMode(JPH_VehicleTransmission *_this, JPH_ETransmissionMode value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).mMode = ((JPH::ETransmissionMode)value);
}

JPH_ETransmissionMode *JPH_VehicleTransmission_GetMutable_mMode(JPH_VehicleTransmission *_this)
{
    return (JPH_ETransmissionMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).mMode);
}

const float *JPH_VehicleTransmission_Get_mSwitchTime(const JPH_VehicleTransmission *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmission *)(_this)).mSwitchTime);
}

void JPH_VehicleTransmission_Set_mSwitchTime(JPH_VehicleTransmission *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).mSwitchTime = value;
}

float *JPH_VehicleTransmission_GetMutable_mSwitchTime(JPH_VehicleTransmission *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).mSwitchTime);
}

const float *JPH_VehicleTransmission_Get_mClutchReleaseTime(const JPH_VehicleTransmission *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmission *)(_this)).mClutchReleaseTime);
}

void JPH_VehicleTransmission_Set_mClutchReleaseTime(JPH_VehicleTransmission *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).mClutchReleaseTime = value;
}

float *JPH_VehicleTransmission_GetMutable_mClutchReleaseTime(JPH_VehicleTransmission *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).mClutchReleaseTime);
}

const float *JPH_VehicleTransmission_Get_mSwitchLatency(const JPH_VehicleTransmission *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmission *)(_this)).mSwitchLatency);
}

void JPH_VehicleTransmission_Set_mSwitchLatency(JPH_VehicleTransmission *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).mSwitchLatency = value;
}

float *JPH_VehicleTransmission_GetMutable_mSwitchLatency(JPH_VehicleTransmission *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).mSwitchLatency);
}

const float *JPH_VehicleTransmission_Get_mShiftUpRPM(const JPH_VehicleTransmission *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmission *)(_this)).mShiftUpRPM);
}

void JPH_VehicleTransmission_Set_mShiftUpRPM(JPH_VehicleTransmission *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).mShiftUpRPM = value;
}

float *JPH_VehicleTransmission_GetMutable_mShiftUpRPM(JPH_VehicleTransmission *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).mShiftUpRPM);
}

const float *JPH_VehicleTransmission_Get_mShiftDownRPM(const JPH_VehicleTransmission *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmission *)(_this)).mShiftDownRPM);
}

void JPH_VehicleTransmission_Set_mShiftDownRPM(JPH_VehicleTransmission *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).mShiftDownRPM = value;
}

float *JPH_VehicleTransmission_GetMutable_mShiftDownRPM(JPH_VehicleTransmission *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).mShiftDownRPM);
}

const float *JPH_VehicleTransmission_Get_mClutchStrength(const JPH_VehicleTransmission *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmission *)(_this)).mClutchStrength);
}

void JPH_VehicleTransmission_Set_mClutchStrength(JPH_VehicleTransmission *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).mClutchStrength = value;
}

float *JPH_VehicleTransmission_GetMutable_mClutchStrength(JPH_VehicleTransmission *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).mClutchStrength);
}

JPH_VehicleTransmission *JPH_VehicleTransmission_DefaultConstruct(void)
{
    using _mrbind_T = JPH::VehicleTransmission;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_VehicleTransmission*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_VehicleTransmission *JPH_VehicleTransmission_DefaultConstructArray(size_t num_elems)
{
    return (JPH_VehicleTransmission *)(new JPH::VehicleTransmission[num_elems]);
}

const JPH_VehicleTransmission *JPH_VehicleTransmission_OffsetPtr(const JPH_VehicleTransmission *ptr, ptrdiff_t i)
{
    return (const JPH_VehicleTransmission *)(((const JPH::VehicleTransmission *)ptr) + i);
}

JPH_VehicleTransmission *JPH_VehicleTransmission_OffsetMutablePtr(JPH_VehicleTransmission *ptr, ptrdiff_t i)
{
    return (JPH_VehicleTransmission *)(((JPH::VehicleTransmission *)ptr) + i);
}

const JPH_VehicleTransmissionSettings *JPH_VehicleTransmission_UpcastTo_JPH_VehicleTransmissionSettings(const JPH_VehicleTransmission *object)
{
    return (const JPH_VehicleTransmissionSettings *)(static_cast<const JPH::VehicleTransmissionSettings *>(
        ((const JPH::VehicleTransmission *)object)
    ));
}

JPH_VehicleTransmissionSettings *JPH_VehicleTransmission_MutableUpcastTo_JPH_VehicleTransmissionSettings(JPH_VehicleTransmission *object)
{
    return (JPH_VehicleTransmissionSettings *)(static_cast<JPH::VehicleTransmissionSettings *>(
        ((JPH::VehicleTransmission *)object)
    ));
}

const JPH_VehicleTransmission *JPH_VehicleTransmission_StaticDowncastFrom_JPH_VehicleTransmissionSettings(const JPH_VehicleTransmissionSettings *object)
{
    return (const JPH_VehicleTransmission *)(static_cast<const JPH::VehicleTransmission *>(
        ((const JPH::VehicleTransmissionSettings *)object)
    ));
}

JPH_VehicleTransmission *JPH_VehicleTransmission_MutableStaticDowncastFrom_JPH_VehicleTransmissionSettings(JPH_VehicleTransmissionSettings *object)
{
    return (JPH_VehicleTransmission *)(static_cast<JPH::VehicleTransmission *>(
        ((JPH::VehicleTransmissionSettings *)object)
    ));
}

JPH_VehicleTransmission *JPH_VehicleTransmission_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_VehicleTransmission *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::VehicleTransmission);
    return (JPH_VehicleTransmission *)new JPH::VehicleTransmission(JPH::VehicleTransmission(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::VehicleTransmission) MRBINDC_CLASSARG_COPY(_other, (JPH::VehicleTransmission), JPH::VehicleTransmission) MRBINDC_CLASSARG_MOVE(_other, (JPH::VehicleTransmission), JPH::VehicleTransmission) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::VehicleTransmission) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::VehicleTransmission) MRBINDC_CLASSARG_END(_other, JPH::VehicleTransmission))
    ));
}

void JPH_VehicleTransmission_Destroy(const JPH_VehicleTransmission *_this)
{
    delete ((const JPH::VehicleTransmission *)_this);
}

void JPH_VehicleTransmission_DestroyArray(const JPH_VehicleTransmission *_this)
{
    delete[] ((const JPH::VehicleTransmission *)_this);
}

JPH_VehicleTransmission *JPH_VehicleTransmission_AssignFromAnother(JPH_VehicleTransmission *_this, Jolt_PassBy _other_pass_by, JPH_VehicleTransmission *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::VehicleTransmission);
    return (JPH_VehicleTransmission *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::VehicleTransmission) MRBINDC_CLASSARG_COPY(_other, (JPH::VehicleTransmission), JPH::VehicleTransmission) MRBINDC_CLASSARG_MOVE(_other, (JPH::VehicleTransmission), JPH::VehicleTransmission) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::VehicleTransmission) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::VehicleTransmission) MRBINDC_CLASSARG_END(_other, JPH::VehicleTransmission))
    ));
}

void JPH_VehicleTransmission_Set(JPH_VehicleTransmission *_this, int inCurrentGear, float inClutchFriction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).Set(
        inCurrentGear,
        inClutchFriction
    );
}

void JPH_VehicleTransmission_Update(JPH_VehicleTransmission *_this, float inDeltaTime, float inCurrentRPM, float inForwardInput, bool inCanShiftUp)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleTransmission *)(_this)).Update(
        inDeltaTime,
        inCurrentRPM,
        inForwardInput,
        inCanShiftUp
    );
}

int JPH_VehicleTransmission_GetCurrentGear(const JPH_VehicleTransmission *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmission *)(_this)).GetCurrentGear();
}

float JPH_VehicleTransmission_GetClutchFriction(const JPH_VehicleTransmission *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmission *)(_this)).GetClutchFriction();
}

bool JPH_VehicleTransmission_IsSwitchingGear(const JPH_VehicleTransmission *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmission *)(_this)).IsSwitchingGear();
}

float JPH_VehicleTransmission_GetCurrentRatio(const JPH_VehicleTransmission *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmission *)(_this)).GetCurrentRatio();
}

bool JPH_VehicleTransmission_AllowSleep(const JPH_VehicleTransmission *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleTransmission *)(_this)).AllowSleep();
}

