// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/MotorSettings.h"

#include <Jolt/Physics/Constraints/MotorSettings.h>
#include <Jolt/Physics/Constraints/SpringSettings.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_SpringSettings *JPH_MotorSettings_Get_mSpringSettings(const JPH_MotorSettings *_this)
{
    return (const JPH_SpringSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorSettings *)(_this)).mSpringSettings);
}

JPH_SpringSettings *JPH_MotorSettings_GetMutable_mSpringSettings(JPH_MotorSettings *_this)
{
    return (JPH_SpringSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorSettings *)(_this)).mSpringSettings);
}

const float *JPH_MotorSettings_Get_mMinForceLimit(const JPH_MotorSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorSettings *)(_this)).mMinForceLimit);
}

void JPH_MotorSettings_Set_mMinForceLimit(JPH_MotorSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorSettings *)(_this)).mMinForceLimit = value;
}

float *JPH_MotorSettings_GetMutable_mMinForceLimit(JPH_MotorSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorSettings *)(_this)).mMinForceLimit);
}

const float *JPH_MotorSettings_Get_mMaxForceLimit(const JPH_MotorSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorSettings *)(_this)).mMaxForceLimit);
}

void JPH_MotorSettings_Set_mMaxForceLimit(JPH_MotorSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorSettings *)(_this)).mMaxForceLimit = value;
}

float *JPH_MotorSettings_GetMutable_mMaxForceLimit(JPH_MotorSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorSettings *)(_this)).mMaxForceLimit);
}

const float *JPH_MotorSettings_Get_mMinTorqueLimit(const JPH_MotorSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorSettings *)(_this)).mMinTorqueLimit);
}

void JPH_MotorSettings_Set_mMinTorqueLimit(JPH_MotorSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorSettings *)(_this)).mMinTorqueLimit = value;
}

float *JPH_MotorSettings_GetMutable_mMinTorqueLimit(JPH_MotorSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorSettings *)(_this)).mMinTorqueLimit);
}

const float *JPH_MotorSettings_Get_mMaxTorqueLimit(const JPH_MotorSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorSettings *)(_this)).mMaxTorqueLimit);
}

void JPH_MotorSettings_Set_mMaxTorqueLimit(JPH_MotorSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorSettings *)(_this)).mMaxTorqueLimit = value;
}

float *JPH_MotorSettings_GetMutable_mMaxTorqueLimit(JPH_MotorSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorSettings *)(_this)).mMaxTorqueLimit);
}

JPH_MotorSettings *JPH_MotorSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::MotorSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_MotorSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_MotorSettings *JPH_MotorSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_MotorSettings *)(new JPH::MotorSettings[num_elems]{});
}

const JPH_MotorSettings *JPH_MotorSettings_OffsetPtr(const JPH_MotorSettings *ptr, ptrdiff_t i)
{
    return (const JPH_MotorSettings *)(((const JPH::MotorSettings *)ptr) + i);
}

JPH_MotorSettings *JPH_MotorSettings_OffsetMutablePtr(JPH_MotorSettings *ptr, ptrdiff_t i)
{
    return (JPH_MotorSettings *)(((JPH::MotorSettings *)ptr) + i);
}

JPH_MotorSettings *JPH_MotorSettings_ConstructFromAnother(const JPH_MotorSettings *_other)
{
    return (JPH_MotorSettings *)new JPH::MotorSettings(JPH::MotorSettings(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::MotorSettings(*(JPH::MotorSettings *)_other))
    ));
}

JPH_MotorSettings *JPH_MotorSettings_Construct_2(float inFrequency, float inDamping)
{
    return (JPH_MotorSettings *)new JPH::MotorSettings(JPH::MotorSettings(
        inFrequency,
        inDamping
    ));
}

JPH_MotorSettings *JPH_MotorSettings_Construct_4(float inFrequency, float inDamping, float inForceLimit, float inTorqueLimit)
{
    return (JPH_MotorSettings *)new JPH::MotorSettings(JPH::MotorSettings(
        inFrequency,
        inDamping,
        inForceLimit,
        inTorqueLimit
    ));
}

void JPH_MotorSettings_Destroy(const JPH_MotorSettings *_this)
{
    delete ((const JPH::MotorSettings *)_this);
}

void JPH_MotorSettings_DestroyArray(const JPH_MotorSettings *_this)
{
    delete[] ((const JPH::MotorSettings *)_this);
}

JPH_MotorSettings *JPH_MotorSettings_AssignFromAnother(JPH_MotorSettings *_this, const JPH_MotorSettings *_other)
{
    return (JPH_MotorSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorSettings *)(_this)).operator=(
        mrbindc_details::unmove(((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::MotorSettings(*(JPH::MotorSettings *)_other)))
    ));
}

void *Jolt_new_JPH_MotorSettings_size_t(size_t inCount)
{
    return JPH::MotorSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_MotorSettings_void_ptr(void *inPointer)
{
    JPH::MotorSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_MotorSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::MotorSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_MotorSettings_size_t(size_t inCount)
{
    return JPH::MotorSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_MotorSettings_void_ptr(void *inPointer)
{
    JPH::MotorSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_MotorSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::MotorSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_MotorSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::MotorSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_MotorSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MotorSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_MotorSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::MotorSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_MotorSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MotorSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_MotorSettings_SetForceLimits(JPH_MotorSettings *_this, float inMin, float inMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorSettings *)(_this)).SetForceLimits(
        inMin,
        inMax
    );
}

void JPH_MotorSettings_SetTorqueLimits(JPH_MotorSettings *_this, float inMin, float inMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorSettings *)(_this)).SetTorqueLimits(
        inMin,
        inMax
    );
}

void JPH_MotorSettings_SetForceLimit(JPH_MotorSettings *_this, float inLimit)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorSettings *)(_this)).SetForceLimit(
        inLimit
    );
}

void JPH_MotorSettings_SetTorqueLimit(JPH_MotorSettings *_this, float inLimit)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorSettings *)(_this)).SetTorqueLimit(
        inLimit
    );
}

bool JPH_MotorSettings_IsValid(const JPH_MotorSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorSettings *)(_this)).IsValid();
}

