// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Vehicle/MotorcycleController.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Vehicle/MotorcycleController.h>
#include <Jolt/Physics/Vehicle/VehicleConstraint.h>
#include <Jolt/Physics/Vehicle/VehicleController.h>
#include <Jolt/Physics/Vehicle/VehicleEngine.h>
#include <Jolt/Physics/Vehicle/VehicleTransmission.h>
#include <Jolt/Physics/Vehicle/WheeledVehicleController.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <functional>
#include <memory>
#include <new>
#include <stdexcept>


const float *JPH_MotorcycleControllerSettings_Get_mMaxLeanAngle(const JPH_MotorcycleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(_this)).mMaxLeanAngle);
}

void JPH_MotorcycleControllerSettings_Set_mMaxLeanAngle(JPH_MotorcycleControllerSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mMaxLeanAngle = value;
}

float *JPH_MotorcycleControllerSettings_GetMutable_mMaxLeanAngle(JPH_MotorcycleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mMaxLeanAngle);
}

const float *JPH_MotorcycleControllerSettings_Get_mLeanSpringConstant(const JPH_MotorcycleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(_this)).mLeanSpringConstant);
}

void JPH_MotorcycleControllerSettings_Set_mLeanSpringConstant(JPH_MotorcycleControllerSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mLeanSpringConstant = value;
}

float *JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringConstant(JPH_MotorcycleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mLeanSpringConstant);
}

const float *JPH_MotorcycleControllerSettings_Get_mLeanSpringDamping(const JPH_MotorcycleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(_this)).mLeanSpringDamping);
}

void JPH_MotorcycleControllerSettings_Set_mLeanSpringDamping(JPH_MotorcycleControllerSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mLeanSpringDamping = value;
}

float *JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringDamping(JPH_MotorcycleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mLeanSpringDamping);
}

const float *JPH_MotorcycleControllerSettings_Get_mLeanSpringIntegrationCoefficient(const JPH_MotorcycleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(_this)).mLeanSpringIntegrationCoefficient);
}

void JPH_MotorcycleControllerSettings_Set_mLeanSpringIntegrationCoefficient(JPH_MotorcycleControllerSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mLeanSpringIntegrationCoefficient = value;
}

float *JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringIntegrationCoefficient(JPH_MotorcycleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mLeanSpringIntegrationCoefficient);
}

const float *JPH_MotorcycleControllerSettings_Get_mLeanSpringIntegrationCoefficientDecay(const JPH_MotorcycleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(_this)).mLeanSpringIntegrationCoefficientDecay);
}

void JPH_MotorcycleControllerSettings_Set_mLeanSpringIntegrationCoefficientDecay(JPH_MotorcycleControllerSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mLeanSpringIntegrationCoefficientDecay = value;
}

float *JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringIntegrationCoefficientDecay(JPH_MotorcycleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mLeanSpringIntegrationCoefficientDecay);
}

const float *JPH_MotorcycleControllerSettings_Get_mLeanSmoothingFactor(const JPH_MotorcycleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(_this)).mLeanSmoothingFactor);
}

void JPH_MotorcycleControllerSettings_Set_mLeanSmoothingFactor(JPH_MotorcycleControllerSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mLeanSmoothingFactor = value;
}

float *JPH_MotorcycleControllerSettings_GetMutable_mLeanSmoothingFactor(JPH_MotorcycleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mLeanSmoothingFactor);
}

const JPH_VehicleEngineSettings *JPH_MotorcycleControllerSettings_Get_mEngine(const JPH_MotorcycleControllerSettings *_this)
{
    return (const JPH_VehicleEngineSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(_this)).mEngine);
}

void JPH_MotorcycleControllerSettings_Set_mEngine(JPH_MotorcycleControllerSettings *_this, Jolt_PassBy value_pass_by, JPH_VehicleEngineSettings *value)
{
    MRBINDC_CLASSARG_GUARD(value, JPH::VehicleEngineSettings);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mEngine = (MRBINDC_CLASSARG_DEF_CTOR(value, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_COPY(value, (JPH::VehicleEngineSettings), JPH::VehicleEngineSettings) MRBINDC_CLASSARG_MOVE(value, (JPH::VehicleEngineSettings), JPH::VehicleEngineSettings) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_DefaultArgument, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_NoObject, JPH::VehicleEngineSettings) MRBINDC_CLASSARG_END(value, JPH::VehicleEngineSettings));
}

JPH_VehicleEngineSettings *JPH_MotorcycleControllerSettings_GetMutable_mEngine(JPH_MotorcycleControllerSettings *_this)
{
    return (JPH_VehicleEngineSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mEngine);
}

const JPH_VehicleTransmissionSettings *JPH_MotorcycleControllerSettings_Get_mTransmission(const JPH_MotorcycleControllerSettings *_this)
{
    return (const JPH_VehicleTransmissionSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(_this)).mTransmission);
}

void JPH_MotorcycleControllerSettings_Set_mTransmission(JPH_MotorcycleControllerSettings *_this, Jolt_PassBy value_pass_by, JPH_VehicleTransmissionSettings *value)
{
    MRBINDC_CLASSARG_GUARD(value, JPH::VehicleTransmissionSettings);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mTransmission = (MRBINDC_CLASSARG_DEF_CTOR(value, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_COPY(value, (JPH::VehicleTransmissionSettings), JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_MOVE(value, (JPH::VehicleTransmissionSettings), JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_DefaultArgument, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_NoObject, JPH::VehicleTransmissionSettings) MRBINDC_CLASSARG_END(value, JPH::VehicleTransmissionSettings));
}

JPH_VehicleTransmissionSettings *JPH_MotorcycleControllerSettings_GetMutable_mTransmission(JPH_MotorcycleControllerSettings *_this)
{
    return (JPH_VehicleTransmissionSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mTransmission);
}

const float *JPH_MotorcycleControllerSettings_Get_mDifferentialLimitedSlipRatio(const JPH_MotorcycleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(_this)).mDifferentialLimitedSlipRatio);
}

void JPH_MotorcycleControllerSettings_Set_mDifferentialLimitedSlipRatio(JPH_MotorcycleControllerSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mDifferentialLimitedSlipRatio = value;
}

float *JPH_MotorcycleControllerSettings_GetMutable_mDifferentialLimitedSlipRatio(JPH_MotorcycleControllerSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).mDifferentialLimitedSlipRatio);
}

JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::MotorcycleControllerSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_MotorcycleControllerSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_MotorcycleControllerSettings *)(new JPH::MotorcycleControllerSettings[num_elems]);
}

const JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_OffsetPtr(const JPH_MotorcycleControllerSettings *ptr, ptrdiff_t i)
{
    return (const JPH_MotorcycleControllerSettings *)(((const JPH::MotorcycleControllerSettings *)ptr) + i);
}

JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_OffsetMutablePtr(JPH_MotorcycleControllerSettings *ptr, ptrdiff_t i)
{
    return (JPH_MotorcycleControllerSettings *)(((JPH::MotorcycleControllerSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_MotorcycleControllerSettings_UpcastTo_JPH_SerializableObject(const JPH_MotorcycleControllerSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::MotorcycleControllerSettings *)object)
    ));
}

JPH_SerializableObject *JPH_MotorcycleControllerSettings_MutableUpcastTo_JPH_SerializableObject(JPH_MotorcycleControllerSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::MotorcycleControllerSettings *)object)
    ));
}

const JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_MotorcycleControllerSettings *)(static_cast<const JPH::MotorcycleControllerSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_MotorcycleControllerSettings *)(static_cast<JPH::MotorcycleControllerSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_VehicleControllerSettings *JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_MotorcycleControllerSettings *object)
{
    return (const JPH_RefTarget_JPH_VehicleControllerSettings *)(static_cast<const JPH::RefTarget<JPH::VehicleControllerSettings> *>(
        ((const JPH::MotorcycleControllerSettings *)object)
    ));
}

JPH_RefTarget_JPH_VehicleControllerSettings *JPH_MotorcycleControllerSettings_MutableUpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_MotorcycleControllerSettings *object)
{
    return (JPH_RefTarget_JPH_VehicleControllerSettings *)(static_cast<JPH::RefTarget<JPH::VehicleControllerSettings> *>(
        ((JPH::MotorcycleControllerSettings *)object)
    ));
}

const JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_RefTarget_JPH_VehicleControllerSettings *object)
{
    return (const JPH_MotorcycleControllerSettings *)(static_cast<const JPH::MotorcycleControllerSettings *>(
        ((const JPH::RefTarget<JPH::VehicleControllerSettings> *)object)
    ));
}

JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_RefTarget_JPH_VehicleControllerSettings *object)
{
    return (JPH_MotorcycleControllerSettings *)(static_cast<JPH::MotorcycleControllerSettings *>(
        ((JPH::RefTarget<JPH::VehicleControllerSettings> *)object)
    ));
}

const JPH_VehicleControllerSettings *JPH_MotorcycleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(const JPH_MotorcycleControllerSettings *object)
{
    return (const JPH_VehicleControllerSettings *)(static_cast<const JPH::VehicleControllerSettings *>(
        ((const JPH::MotorcycleControllerSettings *)object)
    ));
}

JPH_VehicleControllerSettings *JPH_MotorcycleControllerSettings_MutableUpcastTo_JPH_VehicleControllerSettings(JPH_MotorcycleControllerSettings *object)
{
    return (JPH_VehicleControllerSettings *)(static_cast<JPH::VehicleControllerSettings *>(
        ((JPH::MotorcycleControllerSettings *)object)
    ));
}

const JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(const JPH_VehicleControllerSettings *object)
{
    return (const JPH_MotorcycleControllerSettings *)(static_cast<const JPH::MotorcycleControllerSettings *>(
        ((const JPH::VehicleControllerSettings *)object)
    ));
}

JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_MutableStaticDowncastFrom_JPH_VehicleControllerSettings(JPH_VehicleControllerSettings *object)
{
    return (JPH_MotorcycleControllerSettings *)(static_cast<JPH::MotorcycleControllerSettings *>(
        ((JPH::VehicleControllerSettings *)object)
    ));
}

const JPH_WheeledVehicleControllerSettings *JPH_MotorcycleControllerSettings_UpcastTo_JPH_WheeledVehicleControllerSettings(const JPH_MotorcycleControllerSettings *object)
{
    return (const JPH_WheeledVehicleControllerSettings *)(static_cast<const JPH::WheeledVehicleControllerSettings *>(
        ((const JPH::MotorcycleControllerSettings *)object)
    ));
}

JPH_WheeledVehicleControllerSettings *JPH_MotorcycleControllerSettings_MutableUpcastTo_JPH_WheeledVehicleControllerSettings(JPH_MotorcycleControllerSettings *object)
{
    return (JPH_WheeledVehicleControllerSettings *)(static_cast<JPH::WheeledVehicleControllerSettings *>(
        ((JPH::MotorcycleControllerSettings *)object)
    ));
}

const JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_WheeledVehicleControllerSettings(const JPH_WheeledVehicleControllerSettings *object)
{
    return (const JPH_MotorcycleControllerSettings *)(static_cast<const JPH::MotorcycleControllerSettings *>(
        ((const JPH::WheeledVehicleControllerSettings *)object)
    ));
}

JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_MutableStaticDowncastFrom_JPH_WheeledVehicleControllerSettings(JPH_WheeledVehicleControllerSettings *object)
{
    return (JPH_MotorcycleControllerSettings *)(static_cast<JPH::MotorcycleControllerSettings *>(
        ((JPH::WheeledVehicleControllerSettings *)object)
    ));
}

JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_MotorcycleControllerSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::MotorcycleControllerSettings);
    return (JPH_MotorcycleControllerSettings *)new JPH::MotorcycleControllerSettings(JPH::MotorcycleControllerSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::MotorcycleControllerSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::MotorcycleControllerSettings), JPH::MotorcycleControllerSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::MotorcycleControllerSettings), JPH::MotorcycleControllerSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::MotorcycleControllerSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::MotorcycleControllerSettings) MRBINDC_CLASSARG_END(_other, JPH::MotorcycleControllerSettings))
    ));
}

void JPH_MotorcycleControllerSettings_Destroy(const JPH_MotorcycleControllerSettings *_this)
{
    delete ((const JPH::MotorcycleControllerSettings *)_this);
}

void JPH_MotorcycleControllerSettings_DestroyArray(const JPH_MotorcycleControllerSettings *_this)
{
    delete[] ((const JPH::MotorcycleControllerSettings *)_this);
}

JPH_MotorcycleControllerSettings *JPH_MotorcycleControllerSettings_AssignFromAnother(JPH_MotorcycleControllerSettings *_this, Jolt_PassBy _other_pass_by, JPH_MotorcycleControllerSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::MotorcycleControllerSettings);
    return (JPH_MotorcycleControllerSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleControllerSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::MotorcycleControllerSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::MotorcycleControllerSettings), JPH::MotorcycleControllerSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::MotorcycleControllerSettings), JPH::MotorcycleControllerSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::MotorcycleControllerSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::MotorcycleControllerSettings) MRBINDC_CLASSARG_END(_other, JPH::MotorcycleControllerSettings))
    ));
}

void *Jolt_new_JPH_MotorcycleControllerSettings_size_t(size_t inCount)
{
    return JPH::MotorcycleControllerSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr(void *inPointer)
{
    JPH::MotorcycleControllerSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::MotorcycleControllerSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_MotorcycleControllerSettings_size_t(size_t inCount)
{
    return JPH::MotorcycleControllerSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr(void *inPointer)
{
    JPH::MotorcycleControllerSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::MotorcycleControllerSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_MotorcycleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::MotorcycleControllerSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MotorcycleControllerSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_MotorcycleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::MotorcycleControllerSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MotorcycleControllerSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_VehicleController *JPH_MotorcycleControllerSettings_ConstructController(const JPH_MotorcycleControllerSettings *_this, JPH_VehicleConstraint *inConstraint)
{
    return (JPH_VehicleController *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(_this)).ConstructController(
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(JPH::VehicleConstraint *)(inConstraint))
    ));
}

void JPH_MotorcycleControllerSettings_SetEmbedded(const JPH_MotorcycleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_MotorcycleControllerSettings_GetRefCount(const JPH_MotorcycleControllerSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(_this)).GetRefCount();
}

void JPH_MotorcycleControllerSettings_AddRef(const JPH_MotorcycleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(_this)).AddRef();
}

void JPH_MotorcycleControllerSettings_Release(const JPH_MotorcycleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(_this)).Release();
}

int JPH_MotorcycleControllerSettings_sInternalGetRefCountOffset(void)
{
    return JPH::MotorcycleControllerSettings::sInternalGetRefCountOffset();
}

JPH_MotorcycleController *JPH_MotorcycleController_Construct(const JPH_MotorcycleControllerSettings *inSettings, JPH_VehicleConstraint *inConstraint)
{
    return (JPH_MotorcycleController *)new JPH::MotorcycleController(JPH::MotorcycleController(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::MotorcycleControllerSettings *)(inSettings)),
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(JPH::VehicleConstraint *)(inConstraint))
    ));
}

const JPH_MotorcycleController *JPH_MotorcycleController_OffsetPtr(const JPH_MotorcycleController *ptr, ptrdiff_t i)
{
    return (const JPH_MotorcycleController *)(((const JPH::MotorcycleController *)ptr) + i);
}

JPH_MotorcycleController *JPH_MotorcycleController_OffsetMutablePtr(JPH_MotorcycleController *ptr, ptrdiff_t i)
{
    return (JPH_MotorcycleController *)(((JPH::MotorcycleController *)ptr) + i);
}

const JPH_NonCopyable *JPH_MotorcycleController_UpcastTo_JPH_NonCopyable(const JPH_MotorcycleController *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::MotorcycleController *)object)
    ));
}

JPH_NonCopyable *JPH_MotorcycleController_MutableUpcastTo_JPH_NonCopyable(JPH_MotorcycleController *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::MotorcycleController *)object)
    ));
}

const JPH_MotorcycleController *JPH_MotorcycleController_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_MotorcycleController *)(static_cast<const JPH::MotorcycleController *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_MotorcycleController *JPH_MotorcycleController_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_MotorcycleController *)(static_cast<JPH::MotorcycleController *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_VehicleController *JPH_MotorcycleController_UpcastTo_JPH_VehicleController(const JPH_MotorcycleController *object)
{
    return (const JPH_VehicleController *)(static_cast<const JPH::VehicleController *>(
        ((const JPH::MotorcycleController *)object)
    ));
}

JPH_VehicleController *JPH_MotorcycleController_MutableUpcastTo_JPH_VehicleController(JPH_MotorcycleController *object)
{
    return (JPH_VehicleController *)(static_cast<JPH::VehicleController *>(
        ((JPH::MotorcycleController *)object)
    ));
}

const JPH_MotorcycleController *JPH_MotorcycleController_StaticDowncastFrom_JPH_VehicleController(const JPH_VehicleController *object)
{
    return (const JPH_MotorcycleController *)(static_cast<const JPH::MotorcycleController *>(
        ((const JPH::VehicleController *)object)
    ));
}

JPH_MotorcycleController *JPH_MotorcycleController_MutableStaticDowncastFrom_JPH_VehicleController(JPH_VehicleController *object)
{
    return (JPH_MotorcycleController *)(static_cast<JPH::MotorcycleController *>(
        ((JPH::VehicleController *)object)
    ));
}

const JPH_WheeledVehicleController *JPH_MotorcycleController_UpcastTo_JPH_WheeledVehicleController(const JPH_MotorcycleController *object)
{
    return (const JPH_WheeledVehicleController *)(static_cast<const JPH::WheeledVehicleController *>(
        ((const JPH::MotorcycleController *)object)
    ));
}

JPH_WheeledVehicleController *JPH_MotorcycleController_MutableUpcastTo_JPH_WheeledVehicleController(JPH_MotorcycleController *object)
{
    return (JPH_WheeledVehicleController *)(static_cast<JPH::WheeledVehicleController *>(
        ((JPH::MotorcycleController *)object)
    ));
}

const JPH_MotorcycleController *JPH_MotorcycleController_StaticDowncastFrom_JPH_WheeledVehicleController(const JPH_WheeledVehicleController *object)
{
    return (const JPH_MotorcycleController *)(static_cast<const JPH::MotorcycleController *>(
        ((const JPH::WheeledVehicleController *)object)
    ));
}

JPH_MotorcycleController *JPH_MotorcycleController_MutableStaticDowncastFrom_JPH_WheeledVehicleController(JPH_WheeledVehicleController *object)
{
    return (JPH_MotorcycleController *)(static_cast<JPH::MotorcycleController *>(
        ((JPH::WheeledVehicleController *)object)
    ));
}

void JPH_MotorcycleController_Destroy(const JPH_MotorcycleController *_this)
{
    delete ((const JPH::MotorcycleController *)_this);
}

void JPH_MotorcycleController_DestroyArray(const JPH_MotorcycleController *_this)
{
    delete[] ((const JPH::MotorcycleController *)_this);
}

void *Jolt_new_JPH_MotorcycleController_size_t(size_t inCount)
{
    return JPH::MotorcycleController::operator new(
        inCount
    );
}

void Jolt_delete_JPH_MotorcycleController_void_ptr(void *inPointer)
{
    JPH::MotorcycleController::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_MotorcycleController_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::MotorcycleController::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_MotorcycleController_size_t(size_t inCount)
{
    return JPH::MotorcycleController::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_MotorcycleController_void_ptr(void *inPointer)
{
    JPH::MotorcycleController::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_MotorcycleController_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::MotorcycleController::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_MotorcycleController_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::MotorcycleController::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_MotorcycleController_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MotorcycleController::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_MotorcycleController_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::MotorcycleController::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_MotorcycleController_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MotorcycleController::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_MotorcycleController_GetWheelBase(const JPH_MotorcycleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).GetWheelBase();
}

void JPH_MotorcycleController_EnableLeanController(JPH_MotorcycleController *_this, bool inEnable)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).EnableLeanController(
        inEnable
    );
}

bool JPH_MotorcycleController_IsLeanControllerEnabled(const JPH_MotorcycleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).IsLeanControllerEnabled();
}

void JPH_MotorcycleController_EnableLeanSteeringLimit(JPH_MotorcycleController *_this, bool inEnable)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).EnableLeanSteeringLimit(
        inEnable
    );
}

bool JPH_MotorcycleController_IsLeanSteeringLimitEnabled(const JPH_MotorcycleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).IsLeanSteeringLimitEnabled();
}

void JPH_MotorcycleController_SetLeanSpringConstant(JPH_MotorcycleController *_this, float inConstant)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).SetLeanSpringConstant(
        inConstant
    );
}

float JPH_MotorcycleController_GetLeanSpringConstant(const JPH_MotorcycleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).GetLeanSpringConstant();
}

void JPH_MotorcycleController_SetLeanSpringDamping(JPH_MotorcycleController *_this, float inDamping)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).SetLeanSpringDamping(
        inDamping
    );
}

float JPH_MotorcycleController_GetLeanSpringDamping(const JPH_MotorcycleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).GetLeanSpringDamping();
}

void JPH_MotorcycleController_SetLeanSpringIntegrationCoefficient(JPH_MotorcycleController *_this, float inCoefficient)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).SetLeanSpringIntegrationCoefficient(
        inCoefficient
    );
}

float JPH_MotorcycleController_GetLeanSpringIntegrationCoefficient(const JPH_MotorcycleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).GetLeanSpringIntegrationCoefficient();
}

void JPH_MotorcycleController_SetLeanSpringIntegrationCoefficientDecay(JPH_MotorcycleController *_this, float inDecay)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).SetLeanSpringIntegrationCoefficientDecay(
        inDecay
    );
}

float JPH_MotorcycleController_GetLeanSpringIntegrationCoefficientDecay(const JPH_MotorcycleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).GetLeanSpringIntegrationCoefficientDecay();
}

void JPH_MotorcycleController_SetLeanSmoothingFactor(JPH_MotorcycleController *_this, float inFactor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).SetLeanSmoothingFactor(
        inFactor
    );
}

float JPH_MotorcycleController_GetLeanSmoothingFactor(const JPH_MotorcycleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).GetLeanSmoothingFactor();
}

void JPH_MotorcycleController_SetDriverInput(JPH_MotorcycleController *_this, float inForward, float inRight, float inBrake, float inHandBrake)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).SetDriverInput(
        inForward,
        inRight,
        inBrake,
        inHandBrake
    );
}

void JPH_MotorcycleController_SetForwardInput(JPH_MotorcycleController *_this, float inForward)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).SetForwardInput(
        inForward
    );
}

float JPH_MotorcycleController_GetForwardInput(const JPH_MotorcycleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).GetForwardInput();
}

void JPH_MotorcycleController_SetRightInput(JPH_MotorcycleController *_this, float inRight)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).SetRightInput(
        inRight
    );
}

float JPH_MotorcycleController_GetRightInput(const JPH_MotorcycleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).GetRightInput();
}

void JPH_MotorcycleController_SetBrakeInput(JPH_MotorcycleController *_this, float inBrake)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).SetBrakeInput(
        inBrake
    );
}

float JPH_MotorcycleController_GetBrakeInput(const JPH_MotorcycleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).GetBrakeInput();
}

void JPH_MotorcycleController_SetHandBrakeInput(JPH_MotorcycleController *_this, float inHandBrake)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).SetHandBrakeInput(
        inHandBrake
    );
}

float JPH_MotorcycleController_GetHandBrakeInput(const JPH_MotorcycleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).GetHandBrakeInput();
}

float JPH_MotorcycleController_GetDifferentialLimitedSlipRatio(const JPH_MotorcycleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).GetDifferentialLimitedSlipRatio();
}

void JPH_MotorcycleController_SetDifferentialLimitedSlipRatio(JPH_MotorcycleController *_this, float inV)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).SetDifferentialLimitedSlipRatio(
        inV
    );
}

float JPH_MotorcycleController_GetWheelSpeedAtClutch(const JPH_MotorcycleController *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).GetWheelSpeedAtClutch();
}

const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *JPH_MotorcycleController_GetTireMaxImpulseCallback(const JPH_MotorcycleController *_this)
{
    return (const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotorcycleController *)(_this)).GetTireMaxImpulseCallback());
}

void JPH_MotorcycleController_SetTireMaxImpulseCallback(JPH_MotorcycleController *_this, const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *inTireMaxImpulseCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).SetTireMaxImpulseCallback(
        ((inTireMaxImpulseCallback ? void() : MRBINDC_THROW("Parameter `inTireMaxImpulseCallback` can not be null.", void)), *(const std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)> *)(inTireMaxImpulseCallback))
    );
}

void JPH_MotorcycleController_SetRPMMeter(JPH_MotorcycleController *_this, const JPH_Vec3 *inPosition, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotorcycleController *)(_this)).SetRPMMeter(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        inSize
    );
}

