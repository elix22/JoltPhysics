// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Vehicle/VehicleDifferential.h"

#include <Jolt/Physics/Vehicle/VehicleDifferential.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const int *JPH_VehicleDifferentialSettings_Get_mLeftWheel(const JPH_VehicleDifferentialSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleDifferentialSettings *)(_this)).mLeftWheel);
}

void JPH_VehicleDifferentialSettings_Set_mLeftWheel(JPH_VehicleDifferentialSettings *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleDifferentialSettings *)(_this)).mLeftWheel = value;
}

int *JPH_VehicleDifferentialSettings_GetMutable_mLeftWheel(JPH_VehicleDifferentialSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleDifferentialSettings *)(_this)).mLeftWheel);
}

const int *JPH_VehicleDifferentialSettings_Get_mRightWheel(const JPH_VehicleDifferentialSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleDifferentialSettings *)(_this)).mRightWheel);
}

void JPH_VehicleDifferentialSettings_Set_mRightWheel(JPH_VehicleDifferentialSettings *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleDifferentialSettings *)(_this)).mRightWheel = value;
}

int *JPH_VehicleDifferentialSettings_GetMutable_mRightWheel(JPH_VehicleDifferentialSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleDifferentialSettings *)(_this)).mRightWheel);
}

const float *JPH_VehicleDifferentialSettings_Get_mDifferentialRatio(const JPH_VehicleDifferentialSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleDifferentialSettings *)(_this)).mDifferentialRatio);
}

void JPH_VehicleDifferentialSettings_Set_mDifferentialRatio(JPH_VehicleDifferentialSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleDifferentialSettings *)(_this)).mDifferentialRatio = value;
}

float *JPH_VehicleDifferentialSettings_GetMutable_mDifferentialRatio(JPH_VehicleDifferentialSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleDifferentialSettings *)(_this)).mDifferentialRatio);
}

const float *JPH_VehicleDifferentialSettings_Get_mLeftRightSplit(const JPH_VehicleDifferentialSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleDifferentialSettings *)(_this)).mLeftRightSplit);
}

void JPH_VehicleDifferentialSettings_Set_mLeftRightSplit(JPH_VehicleDifferentialSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleDifferentialSettings *)(_this)).mLeftRightSplit = value;
}

float *JPH_VehicleDifferentialSettings_GetMutable_mLeftRightSplit(JPH_VehicleDifferentialSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleDifferentialSettings *)(_this)).mLeftRightSplit);
}

const float *JPH_VehicleDifferentialSettings_Get_mLimitedSlipRatio(const JPH_VehicleDifferentialSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleDifferentialSettings *)(_this)).mLimitedSlipRatio);
}

void JPH_VehicleDifferentialSettings_Set_mLimitedSlipRatio(JPH_VehicleDifferentialSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleDifferentialSettings *)(_this)).mLimitedSlipRatio = value;
}

float *JPH_VehicleDifferentialSettings_GetMutable_mLimitedSlipRatio(JPH_VehicleDifferentialSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleDifferentialSettings *)(_this)).mLimitedSlipRatio);
}

const float *JPH_VehicleDifferentialSettings_Get_mEngineTorqueRatio(const JPH_VehicleDifferentialSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleDifferentialSettings *)(_this)).mEngineTorqueRatio);
}

void JPH_VehicleDifferentialSettings_Set_mEngineTorqueRatio(JPH_VehicleDifferentialSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleDifferentialSettings *)(_this)).mEngineTorqueRatio = value;
}

float *JPH_VehicleDifferentialSettings_GetMutable_mEngineTorqueRatio(JPH_VehicleDifferentialSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleDifferentialSettings *)(_this)).mEngineTorqueRatio);
}

JPH_VehicleDifferentialSettings *JPH_VehicleDifferentialSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::VehicleDifferentialSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_VehicleDifferentialSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_VehicleDifferentialSettings *JPH_VehicleDifferentialSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_VehicleDifferentialSettings *)(new JPH::VehicleDifferentialSettings[num_elems]);
}

JPH_VehicleDifferentialSettings *JPH_VehicleDifferentialSettings_ConstructFrom(int mLeftWheel, int mRightWheel, float mDifferentialRatio, float mLeftRightSplit, float mLimitedSlipRatio, float mEngineTorqueRatio)
{
    return (JPH_VehicleDifferentialSettings *)new JPH::VehicleDifferentialSettings(JPH::VehicleDifferentialSettings{
        mLeftWheel,
        mRightWheel,
        mDifferentialRatio,
        mLeftRightSplit,
        mLimitedSlipRatio,
        mEngineTorqueRatio
    });
}

const JPH_VehicleDifferentialSettings *JPH_VehicleDifferentialSettings_OffsetPtr(const JPH_VehicleDifferentialSettings *ptr, ptrdiff_t i)
{
    return (const JPH_VehicleDifferentialSettings *)(((const JPH::VehicleDifferentialSettings *)ptr) + i);
}

JPH_VehicleDifferentialSettings *JPH_VehicleDifferentialSettings_OffsetMutablePtr(JPH_VehicleDifferentialSettings *ptr, ptrdiff_t i)
{
    return (JPH_VehicleDifferentialSettings *)(((JPH::VehicleDifferentialSettings *)ptr) + i);
}

JPH_VehicleDifferentialSettings *JPH_VehicleDifferentialSettings_ConstructFromAnother(const JPH_VehicleDifferentialSettings *_other)
{
    return (JPH_VehicleDifferentialSettings *)new JPH::VehicleDifferentialSettings(JPH::VehicleDifferentialSettings(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::VehicleDifferentialSettings(*(JPH::VehicleDifferentialSettings *)_other))
    ));
}

void JPH_VehicleDifferentialSettings_Destroy(const JPH_VehicleDifferentialSettings *_this)
{
    delete ((const JPH::VehicleDifferentialSettings *)_this);
}

void JPH_VehicleDifferentialSettings_DestroyArray(const JPH_VehicleDifferentialSettings *_this)
{
    delete[] ((const JPH::VehicleDifferentialSettings *)_this);
}

JPH_VehicleDifferentialSettings *JPH_VehicleDifferentialSettings_AssignFromAnother(JPH_VehicleDifferentialSettings *_this, const JPH_VehicleDifferentialSettings *_other)
{
    return (JPH_VehicleDifferentialSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleDifferentialSettings *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::VehicleDifferentialSettings(*(JPH::VehicleDifferentialSettings *)_other))
    ));
}

void *Jolt_new_JPH_VehicleDifferentialSettings_size_t(size_t inCount)
{
    return JPH::VehicleDifferentialSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr(void *inPointer)
{
    JPH::VehicleDifferentialSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleDifferentialSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_VehicleDifferentialSettings_size_t(size_t inCount)
{
    return JPH::VehicleDifferentialSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr(void *inPointer)
{
    JPH::VehicleDifferentialSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleDifferentialSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_VehicleDifferentialSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleDifferentialSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleDifferentialSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_VehicleDifferentialSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleDifferentialSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleDifferentialSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_VehicleDifferentialSettings_CalculateTorqueRatio(const JPH_VehicleDifferentialSettings *_this, float inLeftAngularVelocity, float inRightAngularVelocity, float *outLeftTorqueFraction, float *outRightTorqueFraction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleDifferentialSettings *)(_this)).CalculateTorqueRatio(
        inLeftAngularVelocity,
        inRightAngularVelocity,
        ((outLeftTorqueFraction ? void() : MRBINDC_THROW("Parameter `outLeftTorqueFraction` can not be null.", void)), *outLeftTorqueFraction),
        ((outRightTorqueFraction ? void() : MRBINDC_THROW("Parameter `outRightTorqueFraction` can not be null.", void)), *outRightTorqueFraction)
    );
}

