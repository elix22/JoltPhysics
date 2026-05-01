// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Vehicle/VehicleEngine.h"

#include <Jolt/Physics/Vehicle/VehicleEngine.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const float *JPH_VehicleEngineSettings_Get_mMaxTorque(const JPH_VehicleEngineSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleEngineSettings *)(_this)).mMaxTorque);
}

void JPH_VehicleEngineSettings_Set_mMaxTorque(JPH_VehicleEngineSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngineSettings *)(_this)).mMaxTorque = value;
}

float *JPH_VehicleEngineSettings_GetMutable_mMaxTorque(JPH_VehicleEngineSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngineSettings *)(_this)).mMaxTorque);
}

const float *JPH_VehicleEngineSettings_Get_mMinRPM(const JPH_VehicleEngineSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleEngineSettings *)(_this)).mMinRPM);
}

void JPH_VehicleEngineSettings_Set_mMinRPM(JPH_VehicleEngineSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngineSettings *)(_this)).mMinRPM = value;
}

float *JPH_VehicleEngineSettings_GetMutable_mMinRPM(JPH_VehicleEngineSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngineSettings *)(_this)).mMinRPM);
}

const float *JPH_VehicleEngineSettings_Get_mMaxRPM(const JPH_VehicleEngineSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleEngineSettings *)(_this)).mMaxRPM);
}

void JPH_VehicleEngineSettings_Set_mMaxRPM(JPH_VehicleEngineSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngineSettings *)(_this)).mMaxRPM = value;
}

float *JPH_VehicleEngineSettings_GetMutable_mMaxRPM(JPH_VehicleEngineSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngineSettings *)(_this)).mMaxRPM);
}

const float *JPH_VehicleEngineSettings_Get_mInertia(const JPH_VehicleEngineSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleEngineSettings *)(_this)).mInertia);
}

void JPH_VehicleEngineSettings_Set_mInertia(JPH_VehicleEngineSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngineSettings *)(_this)).mInertia = value;
}

float *JPH_VehicleEngineSettings_GetMutable_mInertia(JPH_VehicleEngineSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngineSettings *)(_this)).mInertia);
}

const float *JPH_VehicleEngineSettings_Get_mAngularDamping(const JPH_VehicleEngineSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleEngineSettings *)(_this)).mAngularDamping);
}

void JPH_VehicleEngineSettings_Set_mAngularDamping(JPH_VehicleEngineSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngineSettings *)(_this)).mAngularDamping = value;
}

float *JPH_VehicleEngineSettings_GetMutable_mAngularDamping(JPH_VehicleEngineSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngineSettings *)(_this)).mAngularDamping);
}

JPH_VehicleEngineSettings *JPH_VehicleEngineSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::VehicleEngineSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_VehicleEngineSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_VehicleEngineSettings *JPH_VehicleEngineSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_VehicleEngineSettings *)(new JPH::VehicleEngineSettings[num_elems]{});
}

const JPH_VehicleEngineSettings *JPH_VehicleEngineSettings_OffsetPtr(const JPH_VehicleEngineSettings *ptr, ptrdiff_t i)
{
    return (const JPH_VehicleEngineSettings *)(((const JPH::VehicleEngineSettings *)ptr) + i);
}

JPH_VehicleEngineSettings *JPH_VehicleEngineSettings_OffsetMutablePtr(JPH_VehicleEngineSettings *ptr, ptrdiff_t i)
{
    return (JPH_VehicleEngineSettings *)(((JPH::VehicleEngineSettings *)ptr) + i);
}

JPH_VehicleEngineSettings *JPH_VehicleEngineSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_VehicleEngineSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::VehicleEngineSettings);
    return (JPH_VehicleEngineSettings *)new JPH::VehicleEngineSettings(JPH::VehicleEngineSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::VehicleEngineSettings), JPH::VehicleEngineSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::VehicleEngineSettings), JPH::VehicleEngineSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_END(_other, JPH::VehicleEngineSettings))
    ));
}

void JPH_VehicleEngineSettings_Destroy(const JPH_VehicleEngineSettings *_this)
{
    delete ((const JPH::VehicleEngineSettings *)_this);
}

void JPH_VehicleEngineSettings_DestroyArray(const JPH_VehicleEngineSettings *_this)
{
    delete[] ((const JPH::VehicleEngineSettings *)_this);
}

JPH_VehicleEngineSettings *JPH_VehicleEngineSettings_AssignFromAnother(JPH_VehicleEngineSettings *_this, Jolt_PassBy _other_pass_by, JPH_VehicleEngineSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::VehicleEngineSettings);
    return (JPH_VehicleEngineSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngineSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::VehicleEngineSettings), JPH::VehicleEngineSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::VehicleEngineSettings), JPH::VehicleEngineSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_END(_other, JPH::VehicleEngineSettings))
    ));
}

void *Jolt_new_JPH_VehicleEngineSettings_size_t(size_t inCount)
{
    return JPH::VehicleEngineSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_VehicleEngineSettings_void_ptr(void *inPointer)
{
    JPH::VehicleEngineSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_VehicleEngineSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleEngineSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_VehicleEngineSettings_size_t(size_t inCount)
{
    return JPH::VehicleEngineSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr(void *inPointer)
{
    JPH::VehicleEngineSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleEngineSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_VehicleEngineSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleEngineSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_VehicleEngineSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleEngineSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_VehicleEngineSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleEngineSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleEngineSettings::operator delete[](
        inPointer,
        inPlace
    );
}

const float *JPH_VehicleEngine_Get_cAngularVelocityToRPM(void)
{
    return std::addressof(JPH::VehicleEngine::cAngularVelocityToRPM);
}

const float *JPH_VehicleEngine_Get_mMaxTorque(const JPH_VehicleEngine *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleEngine *)(_this)).mMaxTorque);
}

void JPH_VehicleEngine_Set_mMaxTorque(JPH_VehicleEngine *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).mMaxTorque = value;
}

float *JPH_VehicleEngine_GetMutable_mMaxTorque(JPH_VehicleEngine *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).mMaxTorque);
}

const float *JPH_VehicleEngine_Get_mMinRPM(const JPH_VehicleEngine *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleEngine *)(_this)).mMinRPM);
}

void JPH_VehicleEngine_Set_mMinRPM(JPH_VehicleEngine *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).mMinRPM = value;
}

float *JPH_VehicleEngine_GetMutable_mMinRPM(JPH_VehicleEngine *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).mMinRPM);
}

const float *JPH_VehicleEngine_Get_mMaxRPM(const JPH_VehicleEngine *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleEngine *)(_this)).mMaxRPM);
}

void JPH_VehicleEngine_Set_mMaxRPM(JPH_VehicleEngine *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).mMaxRPM = value;
}

float *JPH_VehicleEngine_GetMutable_mMaxRPM(JPH_VehicleEngine *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).mMaxRPM);
}

const float *JPH_VehicleEngine_Get_mInertia(const JPH_VehicleEngine *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleEngine *)(_this)).mInertia);
}

void JPH_VehicleEngine_Set_mInertia(JPH_VehicleEngine *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).mInertia = value;
}

float *JPH_VehicleEngine_GetMutable_mInertia(JPH_VehicleEngine *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).mInertia);
}

const float *JPH_VehicleEngine_Get_mAngularDamping(const JPH_VehicleEngine *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleEngine *)(_this)).mAngularDamping);
}

void JPH_VehicleEngine_Set_mAngularDamping(JPH_VehicleEngine *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).mAngularDamping = value;
}

float *JPH_VehicleEngine_GetMutable_mAngularDamping(JPH_VehicleEngine *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).mAngularDamping);
}

JPH_VehicleEngine *JPH_VehicleEngine_DefaultConstruct(void)
{
    using _mrbind_T = JPH::VehicleEngine;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_VehicleEngine*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_VehicleEngine *JPH_VehicleEngine_DefaultConstructArray(size_t num_elems)
{
    return (JPH_VehicleEngine *)(new JPH::VehicleEngine[num_elems]{});
}

const JPH_VehicleEngine *JPH_VehicleEngine_OffsetPtr(const JPH_VehicleEngine *ptr, ptrdiff_t i)
{
    return (const JPH_VehicleEngine *)(((const JPH::VehicleEngine *)ptr) + i);
}

JPH_VehicleEngine *JPH_VehicleEngine_OffsetMutablePtr(JPH_VehicleEngine *ptr, ptrdiff_t i)
{
    return (JPH_VehicleEngine *)(((JPH::VehicleEngine *)ptr) + i);
}

const JPH_VehicleEngineSettings *JPH_VehicleEngine_UpcastTo_JPH_VehicleEngineSettings(const JPH_VehicleEngine *object)
{
    return (const JPH_VehicleEngineSettings *)(static_cast<const JPH::VehicleEngineSettings *>(
        ((const JPH::VehicleEngine *)object)
    ));
}

JPH_VehicleEngineSettings *JPH_VehicleEngine_MutableUpcastTo_JPH_VehicleEngineSettings(JPH_VehicleEngine *object)
{
    return (JPH_VehicleEngineSettings *)(static_cast<JPH::VehicleEngineSettings *>(
        ((JPH::VehicleEngine *)object)
    ));
}

const JPH_VehicleEngine *JPH_VehicleEngine_StaticDowncastFrom_JPH_VehicleEngineSettings(const JPH_VehicleEngineSettings *object)
{
    return (const JPH_VehicleEngine *)(static_cast<const JPH::VehicleEngine *>(
        ((const JPH::VehicleEngineSettings *)object)
    ));
}

JPH_VehicleEngine *JPH_VehicleEngine_MutableStaticDowncastFrom_JPH_VehicleEngineSettings(JPH_VehicleEngineSettings *object)
{
    return (JPH_VehicleEngine *)(static_cast<JPH::VehicleEngine *>(
        ((JPH::VehicleEngineSettings *)object)
    ));
}

JPH_VehicleEngine *JPH_VehicleEngine_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_VehicleEngine *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::VehicleEngine);
    return (JPH_VehicleEngine *)new JPH::VehicleEngine(JPH::VehicleEngine(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::VehicleEngine) MRBINDC_CLASSARG_COPY(_other, (JPH::VehicleEngine), JPH::VehicleEngine) MRBINDC_CLASSARG_MOVE(_other, (JPH::VehicleEngine), JPH::VehicleEngine) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::VehicleEngine) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::VehicleEngine) MRBINDC_CLASSARG_END(_other, JPH::VehicleEngine))
    ));
}

void JPH_VehicleEngine_Destroy(const JPH_VehicleEngine *_this)
{
    delete ((const JPH::VehicleEngine *)_this);
}

void JPH_VehicleEngine_DestroyArray(const JPH_VehicleEngine *_this)
{
    delete[] ((const JPH::VehicleEngine *)_this);
}

JPH_VehicleEngine *JPH_VehicleEngine_AssignFromAnother(JPH_VehicleEngine *_this, Jolt_PassBy _other_pass_by, JPH_VehicleEngine *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::VehicleEngine);
    return (JPH_VehicleEngine *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::VehicleEngine) MRBINDC_CLASSARG_COPY(_other, (JPH::VehicleEngine), JPH::VehicleEngine) MRBINDC_CLASSARG_MOVE(_other, (JPH::VehicleEngine), JPH::VehicleEngine) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::VehicleEngine) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::VehicleEngine) MRBINDC_CLASSARG_END(_other, JPH::VehicleEngine))
    ));
}

void JPH_VehicleEngine_ClampRPM(JPH_VehicleEngine *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).ClampRPM();
}

float JPH_VehicleEngine_GetCurrentRPM(const JPH_VehicleEngine *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleEngine *)(_this)).GetCurrentRPM();
}

void JPH_VehicleEngine_SetCurrentRPM(JPH_VehicleEngine *_this, float inRPM)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).SetCurrentRPM(
        inRPM
    );
}

float JPH_VehicleEngine_GetAngularVelocity(const JPH_VehicleEngine *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleEngine *)(_this)).GetAngularVelocity();
}

float JPH_VehicleEngine_GetTorque(const JPH_VehicleEngine *_this, float inAcceleration)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleEngine *)(_this)).GetTorque(
        inAcceleration
    );
}

void JPH_VehicleEngine_ApplyTorque(JPH_VehicleEngine *_this, float inTorque, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).ApplyTorque(
        inTorque,
        inDeltaTime
    );
}

void JPH_VehicleEngine_ApplyDamping(JPH_VehicleEngine *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleEngine *)(_this)).ApplyDamping(
        inDeltaTime
    );
}

bool JPH_VehicleEngine_AllowSleep(const JPH_VehicleEngine *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleEngine *)(_this)).AllowSleep();
}

