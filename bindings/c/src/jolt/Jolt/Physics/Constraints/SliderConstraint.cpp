// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/SliderConstraint.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Math/Vector.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/Constraints/MotorSettings.h>
#include <Jolt/Physics/Constraints/SliderConstraint.h>
#include <Jolt/Physics/Constraints/SpringSettings.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const bool *JPH_SliderConstraintSettings_Get_mAutoDetectPoint(const JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mAutoDetectPoint);
}

void JPH_SliderConstraintSettings_Set_mAutoDetectPoint(JPH_SliderConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mAutoDetectPoint = value;
}

bool *JPH_SliderConstraintSettings_GetMutable_mAutoDetectPoint(JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mAutoDetectPoint);
}

const JPH_Vec3 *JPH_SliderConstraintSettings_Get_mPoint1(const JPH_SliderConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mPoint1);
}

JPH_Vec3 *JPH_SliderConstraintSettings_GetMutable_mPoint1(JPH_SliderConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mPoint1);
}

const JPH_Vec3 *JPH_SliderConstraintSettings_Get_mSliderAxis1(const JPH_SliderConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mSliderAxis1);
}

JPH_Vec3 *JPH_SliderConstraintSettings_GetMutable_mSliderAxis1(JPH_SliderConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mSliderAxis1);
}

const JPH_Vec3 *JPH_SliderConstraintSettings_Get_mNormalAxis1(const JPH_SliderConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mNormalAxis1);
}

JPH_Vec3 *JPH_SliderConstraintSettings_GetMutable_mNormalAxis1(JPH_SliderConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mNormalAxis1);
}

const JPH_Vec3 *JPH_SliderConstraintSettings_Get_mPoint2(const JPH_SliderConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mPoint2);
}

JPH_Vec3 *JPH_SliderConstraintSettings_GetMutable_mPoint2(JPH_SliderConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mPoint2);
}

const JPH_Vec3 *JPH_SliderConstraintSettings_Get_mSliderAxis2(const JPH_SliderConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mSliderAxis2);
}

JPH_Vec3 *JPH_SliderConstraintSettings_GetMutable_mSliderAxis2(JPH_SliderConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mSliderAxis2);
}

const JPH_Vec3 *JPH_SliderConstraintSettings_Get_mNormalAxis2(const JPH_SliderConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mNormalAxis2);
}

JPH_Vec3 *JPH_SliderConstraintSettings_GetMutable_mNormalAxis2(JPH_SliderConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mNormalAxis2);
}

const float *JPH_SliderConstraintSettings_Get_mLimitsMin(const JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mLimitsMin);
}

void JPH_SliderConstraintSettings_Set_mLimitsMin(JPH_SliderConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mLimitsMin = value;
}

float *JPH_SliderConstraintSettings_GetMutable_mLimitsMin(JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mLimitsMin);
}

const float *JPH_SliderConstraintSettings_Get_mLimitsMax(const JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mLimitsMax);
}

void JPH_SliderConstraintSettings_Set_mLimitsMax(JPH_SliderConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mLimitsMax = value;
}

float *JPH_SliderConstraintSettings_GetMutable_mLimitsMax(JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mLimitsMax);
}

const JPH_SpringSettings *JPH_SliderConstraintSettings_Get_mLimitsSpringSettings(const JPH_SliderConstraintSettings *_this)
{
    return (const JPH_SpringSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mLimitsSpringSettings);
}

JPH_SpringSettings *JPH_SliderConstraintSettings_GetMutable_mLimitsSpringSettings(JPH_SliderConstraintSettings *_this)
{
    return (JPH_SpringSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mLimitsSpringSettings);
}

const float *JPH_SliderConstraintSettings_Get_mMaxFrictionForce(const JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mMaxFrictionForce);
}

void JPH_SliderConstraintSettings_Set_mMaxFrictionForce(JPH_SliderConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mMaxFrictionForce = value;
}

float *JPH_SliderConstraintSettings_GetMutable_mMaxFrictionForce(JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mMaxFrictionForce);
}

const JPH_MotorSettings *JPH_SliderConstraintSettings_Get_mMotorSettings(const JPH_SliderConstraintSettings *_this)
{
    return (const JPH_MotorSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mMotorSettings);
}

JPH_MotorSettings *JPH_SliderConstraintSettings_GetMutable_mMotorSettings(JPH_SliderConstraintSettings *_this)
{
    return (JPH_MotorSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mMotorSettings);
}

const bool *JPH_SliderConstraintSettings_Get_mEnabled(const JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mEnabled);
}

void JPH_SliderConstraintSettings_Set_mEnabled(JPH_SliderConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mEnabled = value;
}

bool *JPH_SliderConstraintSettings_GetMutable_mEnabled(JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mEnabled);
}

const unsigned int *JPH_SliderConstraintSettings_Get_mConstraintPriority(const JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mConstraintPriority);
}

void JPH_SliderConstraintSettings_Set_mConstraintPriority(JPH_SliderConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mConstraintPriority = value;
}

unsigned int *JPH_SliderConstraintSettings_GetMutable_mConstraintPriority(JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mConstraintPriority);
}

const unsigned int *JPH_SliderConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_SliderConstraintSettings_Set_mNumVelocityStepsOverride(JPH_SliderConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_SliderConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_SliderConstraintSettings_Get_mNumPositionStepsOverride(const JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_SliderConstraintSettings_Set_mNumPositionStepsOverride(JPH_SliderConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_SliderConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_SliderConstraintSettings_Get_mDrawConstraintSize(const JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mDrawConstraintSize);
}

void JPH_SliderConstraintSettings_Set_mDrawConstraintSize(JPH_SliderConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mDrawConstraintSize = value;
}

float *JPH_SliderConstraintSettings_GetMutable_mDrawConstraintSize(JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mDrawConstraintSize);
}

const uint64_t *JPH_SliderConstraintSettings_Get_mUserData(const JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).mUserData);
}

void JPH_SliderConstraintSettings_Set_mUserData(JPH_SliderConstraintSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_SliderConstraintSettings_GetMutable_mUserData(JPH_SliderConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).mUserData);
}

JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SliderConstraintSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SliderConstraintSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SliderConstraintSettings *)(new JPH::SliderConstraintSettings[num_elems]{});
}

const JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_OffsetPtr(const JPH_SliderConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_SliderConstraintSettings *)(((const JPH::SliderConstraintSettings *)ptr) + i);
}

JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_OffsetMutablePtr(JPH_SliderConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_SliderConstraintSettings *)(((JPH::SliderConstraintSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_SliderConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_SliderConstraintSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::SliderConstraintSettings *)object)
    ));
}

JPH_SerializableObject *JPH_SliderConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_SliderConstraintSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::SliderConstraintSettings *)object)
    ));
}

const JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_SliderConstraintSettings *)(static_cast<const JPH::SliderConstraintSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_SliderConstraintSettings *)(static_cast<JPH::SliderConstraintSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_SliderConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_SliderConstraintSettings *object)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<const JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((const JPH::SliderConstraintSettings *)object)
    ));
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_SliderConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_SliderConstraintSettings *object)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((JPH::SliderConstraintSettings *)object)
    ));
}

const JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (const JPH_SliderConstraintSettings *)(static_cast<const JPH::SliderConstraintSettings *>(
        ((const JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (JPH_SliderConstraintSettings *)(static_cast<JPH::SliderConstraintSettings *>(
        ((JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

const JPH_ConstraintSettings *JPH_SliderConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_SliderConstraintSettings *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::SliderConstraintSettings *)object)
    ));
}

JPH_ConstraintSettings *JPH_SliderConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_SliderConstraintSettings *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::SliderConstraintSettings *)object)
    ));
}

const JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object)
{
    return (const JPH_SliderConstraintSettings *)(static_cast<const JPH::SliderConstraintSettings *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object)
{
    return (JPH_SliderConstraintSettings *)(static_cast<JPH::SliderConstraintSettings *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

const JPH_TwoBodyConstraintSettings *JPH_SliderConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_SliderConstraintSettings *object)
{
    return (const JPH_TwoBodyConstraintSettings *)(static_cast<const JPH::TwoBodyConstraintSettings *>(
        ((const JPH::SliderConstraintSettings *)object)
    ));
}

JPH_TwoBodyConstraintSettings *JPH_SliderConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_SliderConstraintSettings *object)
{
    return (JPH_TwoBodyConstraintSettings *)(static_cast<JPH::TwoBodyConstraintSettings *>(
        ((JPH::SliderConstraintSettings *)object)
    ));
}

const JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object)
{
    return (const JPH_SliderConstraintSettings *)(static_cast<const JPH::SliderConstraintSettings *>(
        ((const JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object)
{
    return (JPH_SliderConstraintSettings *)(static_cast<JPH::SliderConstraintSettings *>(
        ((JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SliderConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SliderConstraintSettings);
    return (JPH_SliderConstraintSettings *)new JPH::SliderConstraintSettings(JPH::SliderConstraintSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SliderConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::SliderConstraintSettings), JPH::SliderConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::SliderConstraintSettings), JPH::SliderConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SliderConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SliderConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::SliderConstraintSettings))
    ));
}

void JPH_SliderConstraintSettings_Destroy(const JPH_SliderConstraintSettings *_this)
{
    delete ((const JPH::SliderConstraintSettings *)_this);
}

void JPH_SliderConstraintSettings_DestroyArray(const JPH_SliderConstraintSettings *_this)
{
    delete[] ((const JPH::SliderConstraintSettings *)_this);
}

JPH_SliderConstraintSettings *JPH_SliderConstraintSettings_AssignFromAnother(JPH_SliderConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_SliderConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SliderConstraintSettings);
    return (JPH_SliderConstraintSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SliderConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::SliderConstraintSettings), JPH::SliderConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::SliderConstraintSettings), JPH::SliderConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SliderConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SliderConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::SliderConstraintSettings))
    ));
}

void *Jolt_new_JPH_SliderConstraintSettings_size_t(size_t inCount)
{
    return JPH::SliderConstraintSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SliderConstraintSettings_void_ptr(void *inPointer)
{
    JPH::SliderConstraintSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SliderConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SliderConstraintSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SliderConstraintSettings_size_t(size_t inCount)
{
    return JPH::SliderConstraintSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SliderConstraintSettings_void_ptr(void *inPointer)
{
    JPH::SliderConstraintSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SliderConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SliderConstraintSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SliderConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SliderConstraintSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SliderConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SliderConstraintSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SliderConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SliderConstraintSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SliderConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SliderConstraintSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_TwoBodyConstraint *JPH_SliderConstraintSettings_Create(const JPH_SliderConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2)
{
    return (JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).Create(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2))
    ));
}

void JPH_SliderConstraintSettings_SetSliderAxis(JPH_SliderConstraintSettings *_this, const JPH_Vec3 *inSliderAxis)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraintSettings *)(_this)).SetSliderAxis(
        ((inSliderAxis ? void() : MRBINDC_THROW("Parameter `inSliderAxis` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inSliderAxis))
    );
}

void JPH_SliderConstraintSettings_SetEmbedded(const JPH_SliderConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_SliderConstraintSettings_GetRefCount(const JPH_SliderConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).GetRefCount();
}

void JPH_SliderConstraintSettings_AddRef(const JPH_SliderConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).AddRef();
}

void JPH_SliderConstraintSettings_Release(const JPH_SliderConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(_this)).Release();
}

int JPH_SliderConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::SliderConstraintSettings::sInternalGetRefCountOffset();
}

JPH_SliderConstraint *JPH_SliderConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_SliderConstraintSettings *inSettings)
{
    return (JPH_SliderConstraint *)new JPH::SliderConstraint(JPH::SliderConstraint(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::SliderConstraintSettings *)(inSettings))
    ));
}

const JPH_SliderConstraint *JPH_SliderConstraint_OffsetPtr(const JPH_SliderConstraint *ptr, ptrdiff_t i)
{
    return (const JPH_SliderConstraint *)(((const JPH::SliderConstraint *)ptr) + i);
}

JPH_SliderConstraint *JPH_SliderConstraint_OffsetMutablePtr(JPH_SliderConstraint *ptr, ptrdiff_t i)
{
    return (JPH_SliderConstraint *)(((JPH::SliderConstraint *)ptr) + i);
}

const JPH_RefTarget_JPH_Constraint *JPH_SliderConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_SliderConstraint *object)
{
    return (const JPH_RefTarget_JPH_Constraint *)(static_cast<const JPH::RefTarget<JPH::Constraint> *>(
        ((const JPH::SliderConstraint *)object)
    ));
}

JPH_RefTarget_JPH_Constraint *JPH_SliderConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_SliderConstraint *object)
{
    return (JPH_RefTarget_JPH_Constraint *)(static_cast<JPH::RefTarget<JPH::Constraint> *>(
        ((JPH::SliderConstraint *)object)
    ));
}

const JPH_SliderConstraint *JPH_SliderConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object)
{
    return (const JPH_SliderConstraint *)(static_cast<const JPH::SliderConstraint *>(
        ((const JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

JPH_SliderConstraint *JPH_SliderConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object)
{
    return (JPH_SliderConstraint *)(static_cast<JPH::SliderConstraint *>(
        ((JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

const JPH_NonCopyable *JPH_SliderConstraint_UpcastTo_JPH_NonCopyable(const JPH_SliderConstraint *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::SliderConstraint *)object)
    ));
}

JPH_NonCopyable *JPH_SliderConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_SliderConstraint *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::SliderConstraint *)object)
    ));
}

const JPH_SliderConstraint *JPH_SliderConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_SliderConstraint *)(static_cast<const JPH::SliderConstraint *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_SliderConstraint *JPH_SliderConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_SliderConstraint *)(static_cast<JPH::SliderConstraint *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Constraint *JPH_SliderConstraint_UpcastTo_JPH_Constraint(const JPH_SliderConstraint *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::SliderConstraint *)object)
    ));
}

JPH_Constraint *JPH_SliderConstraint_MutableUpcastTo_JPH_Constraint(JPH_SliderConstraint *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::SliderConstraint *)object)
    ));
}

const JPH_SliderConstraint *JPH_SliderConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object)
{
    return (const JPH_SliderConstraint *)(static_cast<const JPH::SliderConstraint *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_SliderConstraint *JPH_SliderConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object)
{
    return (JPH_SliderConstraint *)(static_cast<JPH::SliderConstraint *>(
        ((JPH::Constraint *)object)
    ));
}

const JPH_TwoBodyConstraint *JPH_SliderConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_SliderConstraint *object)
{
    return (const JPH_TwoBodyConstraint *)(static_cast<const JPH::TwoBodyConstraint *>(
        ((const JPH::SliderConstraint *)object)
    ));
}

JPH_TwoBodyConstraint *JPH_SliderConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_SliderConstraint *object)
{
    return (JPH_TwoBodyConstraint *)(static_cast<JPH::TwoBodyConstraint *>(
        ((JPH::SliderConstraint *)object)
    ));
}

const JPH_SliderConstraint *JPH_SliderConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object)
{
    return (const JPH_SliderConstraint *)(static_cast<const JPH::SliderConstraint *>(
        ((const JPH::TwoBodyConstraint *)object)
    ));
}

JPH_SliderConstraint *JPH_SliderConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object)
{
    return (JPH_SliderConstraint *)(static_cast<JPH::SliderConstraint *>(
        ((JPH::TwoBodyConstraint *)object)
    ));
}

void JPH_SliderConstraint_Destroy(const JPH_SliderConstraint *_this)
{
    delete ((const JPH::SliderConstraint *)_this);
}

void JPH_SliderConstraint_DestroyArray(const JPH_SliderConstraint *_this)
{
    delete[] ((const JPH::SliderConstraint *)_this);
}

void *Jolt_new_JPH_SliderConstraint_size_t(size_t inCount)
{
    return JPH::SliderConstraint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SliderConstraint_void_ptr(void *inPointer)
{
    JPH::SliderConstraint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SliderConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SliderConstraint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SliderConstraint_size_t(size_t inCount)
{
    return JPH::SliderConstraint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SliderConstraint_void_ptr(void *inPointer)
{
    JPH::SliderConstraint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SliderConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SliderConstraint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SliderConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SliderConstraint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SliderConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SliderConstraint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SliderConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SliderConstraint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SliderConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SliderConstraint::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_SliderConstraint_NotifyShapeChanged(JPH_SliderConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).NotifyShapeChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inDeltaCOM ? void() : MRBINDC_THROW("Parameter `inDeltaCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaCOM))
    );
}

void JPH_SliderConstraint_SetupVelocityConstraint(JPH_SliderConstraint *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SetupVelocityConstraint(
        inDeltaTime
    );
}

void JPH_SliderConstraint_ResetWarmStart(JPH_SliderConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).ResetWarmStart();
}

void JPH_SliderConstraint_WarmStartVelocityConstraint(JPH_SliderConstraint *_this, float inWarmStartImpulseRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).WarmStartVelocityConstraint(
        inWarmStartImpulseRatio
    );
}

bool JPH_SliderConstraint_SolveVelocityConstraint(JPH_SliderConstraint *_this, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SolveVelocityConstraint(
        inDeltaTime
    );
}

bool JPH_SliderConstraint_SolvePositionConstraint(JPH_SliderConstraint *_this, float inDeltaTime, float inBaumgarte)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SolvePositionConstraint(
        inDeltaTime,
        inBaumgarte
    );
}

void JPH_SliderConstraint_DrawConstraint(const JPH_SliderConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).DrawConstraint(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

void JPH_SliderConstraint_DrawConstraintLimits(const JPH_SliderConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).DrawConstraintLimits(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

JPH_Mat44 *JPH_SliderConstraint_GetConstraintToBody1Matrix(const JPH_SliderConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetConstraintToBody1Matrix());
}

JPH_Mat44 *JPH_SliderConstraint_GetConstraintToBody2Matrix(const JPH_SliderConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetConstraintToBody2Matrix());
}

float JPH_SliderConstraint_GetCurrentPosition(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetCurrentPosition();
}

void JPH_SliderConstraint_SetMaxFrictionForce(JPH_SliderConstraint *_this, float inFrictionForce)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SetMaxFrictionForce(
        inFrictionForce
    );
}

float JPH_SliderConstraint_GetMaxFrictionForce(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetMaxFrictionForce();
}

JPH_MotorSettings *JPH_SliderConstraint_GetMotorSettings_mut(JPH_SliderConstraint *_this)
{
    return (JPH_MotorSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).GetMotorSettings());
}

const JPH_MotorSettings *JPH_SliderConstraint_GetMotorSettings(const JPH_SliderConstraint *_this)
{
    return (const JPH_MotorSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetMotorSettings());
}

void JPH_SliderConstraint_SetMotorState(JPH_SliderConstraint *_this, JPH_EMotorState inState)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SetMotorState(
        ((JPH::EMotorState)inState)
    );
}

JPH_EMotorState JPH_SliderConstraint_GetMotorState(const JPH_SliderConstraint *_this)
{
    return (JPH_EMotorState)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetMotorState());
}

void JPH_SliderConstraint_SetTargetVelocity(JPH_SliderConstraint *_this, float inVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SetTargetVelocity(
        inVelocity
    );
}

float JPH_SliderConstraint_GetTargetVelocity(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetTargetVelocity();
}

void JPH_SliderConstraint_SetTargetPosition(JPH_SliderConstraint *_this, float inPosition)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SetTargetPosition(
        inPosition
    );
}

float JPH_SliderConstraint_GetTargetPosition(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetTargetPosition();
}

void JPH_SliderConstraint_SetLimits(JPH_SliderConstraint *_this, float inLimitsMin, float inLimitsMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SetLimits(
        inLimitsMin,
        inLimitsMax
    );
}

float JPH_SliderConstraint_GetLimitsMin(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetLimitsMin();
}

float JPH_SliderConstraint_GetLimitsMax(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetLimitsMax();
}

bool JPH_SliderConstraint_HasLimits(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).HasLimits();
}

const JPH_SpringSettings *JPH_SliderConstraint_GetLimitsSpringSettings(const JPH_SliderConstraint *_this)
{
    return (const JPH_SpringSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetLimitsSpringSettings());
}

JPH_SpringSettings *JPH_SliderConstraint_GetLimitsSpringSettings_mut(JPH_SliderConstraint *_this)
{
    return (JPH_SpringSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).GetLimitsSpringSettings());
}

void JPH_SliderConstraint_SetLimitsSpringSettings(JPH_SliderConstraint *_this, const JPH_SpringSettings *inLimitsSpringSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SetLimitsSpringSettings(
        ((inLimitsSpringSettings ? void() : MRBINDC_THROW("Parameter `inLimitsSpringSettings` can not be null.", void)), *(const JPH::SpringSettings *)(inLimitsSpringSettings))
    );
}

JPH_Vector_2 *JPH_SliderConstraint_GetTotalLambdaPosition(const JPH_SliderConstraint *_this)
{
    return (JPH_Vector_2 *)new JPH::Vector<2>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetTotalLambdaPosition());
}

float JPH_SliderConstraint_GetTotalLambdaPositionLimits(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetTotalLambdaPositionLimits();
}

JPH_Vec3 *JPH_SliderConstraint_GetTotalLambdaRotation(const JPH_SliderConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetTotalLambdaRotation());
}

float JPH_SliderConstraint_GetTotalLambdaMotor(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetTotalLambdaMotor();
}

bool JPH_SliderConstraint_IsActive(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).IsActive();
}

void JPH_SliderConstraint_DrawConstraintReferenceFrame(const JPH_SliderConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).DrawConstraintReferenceFrame(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

JPH_Body *JPH_SliderConstraint_GetBody1(const JPH_SliderConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetBody1());
}

JPH_Body *JPH_SliderConstraint_GetBody2(const JPH_SliderConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetBody2());
}

unsigned int JPH_SliderConstraint_GetConstraintPriority(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetConstraintPriority();
}

void JPH_SliderConstraint_SetConstraintPriority(JPH_SliderConstraint *_this, unsigned int inPriority)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SetConstraintPriority(
        inPriority
    );
}

void JPH_SliderConstraint_SetNumVelocityStepsOverride(JPH_SliderConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_SliderConstraint_GetNumVelocityStepsOverride(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_SliderConstraint_SetNumPositionStepsOverride(JPH_SliderConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_SliderConstraint_GetNumPositionStepsOverride(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetNumPositionStepsOverride();
}

void JPH_SliderConstraint_SetEnabled(JPH_SliderConstraint *_this, bool inEnabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SetEnabled(
        inEnabled
    );
}

bool JPH_SliderConstraint_GetEnabled(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetEnabled();
}

uint64_t JPH_SliderConstraint_GetUserData(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetUserData();
}

void JPH_SliderConstraint_SetUserData(JPH_SliderConstraint *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SetUserData(
        inUserData
    );
}

float JPH_SliderConstraint_GetDrawConstraintSize(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetDrawConstraintSize();
}

void JPH_SliderConstraint_SetDrawConstraintSize(JPH_SliderConstraint *_this, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SliderConstraint *)(_this)).SetDrawConstraintSize(
        inSize
    );
}

void JPH_SliderConstraint_SetEmbedded(const JPH_SliderConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).SetEmbedded();
}

unsigned int JPH_SliderConstraint_GetRefCount(const JPH_SliderConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).GetRefCount();
}

void JPH_SliderConstraint_AddRef(const JPH_SliderConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).AddRef();
}

void JPH_SliderConstraint_Release(const JPH_SliderConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SliderConstraint *)(_this)).Release();
}

int JPH_SliderConstraint_sInternalGetRefCountOffset(void)
{
    return JPH::SliderConstraint::sInternalGetRefCountOffset();
}

