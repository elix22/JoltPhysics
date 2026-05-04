// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/SwingTwistConstraint.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/Constraints/MotorSettings.h>
#include <Jolt/Physics/Constraints/SwingTwistConstraint.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_SwingTwistConstraintSettings_Get_mPosition1(const JPH_SwingTwistConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mPosition1);
}

JPH_Vec3 *JPH_SwingTwistConstraintSettings_GetMutable_mPosition1(JPH_SwingTwistConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mPosition1);
}

const JPH_Vec3 *JPH_SwingTwistConstraintSettings_Get_mTwistAxis1(const JPH_SwingTwistConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mTwistAxis1);
}

JPH_Vec3 *JPH_SwingTwistConstraintSettings_GetMutable_mTwistAxis1(JPH_SwingTwistConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mTwistAxis1);
}

const JPH_Vec3 *JPH_SwingTwistConstraintSettings_Get_mPlaneAxis1(const JPH_SwingTwistConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mPlaneAxis1);
}

JPH_Vec3 *JPH_SwingTwistConstraintSettings_GetMutable_mPlaneAxis1(JPH_SwingTwistConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mPlaneAxis1);
}

const JPH_Vec3 *JPH_SwingTwistConstraintSettings_Get_mPosition2(const JPH_SwingTwistConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mPosition2);
}

JPH_Vec3 *JPH_SwingTwistConstraintSettings_GetMutable_mPosition2(JPH_SwingTwistConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mPosition2);
}

const JPH_Vec3 *JPH_SwingTwistConstraintSettings_Get_mTwistAxis2(const JPH_SwingTwistConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mTwistAxis2);
}

JPH_Vec3 *JPH_SwingTwistConstraintSettings_GetMutable_mTwistAxis2(JPH_SwingTwistConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mTwistAxis2);
}

const JPH_Vec3 *JPH_SwingTwistConstraintSettings_Get_mPlaneAxis2(const JPH_SwingTwistConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mPlaneAxis2);
}

JPH_Vec3 *JPH_SwingTwistConstraintSettings_GetMutable_mPlaneAxis2(JPH_SwingTwistConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mPlaneAxis2);
}

const float *JPH_SwingTwistConstraintSettings_Get_mNormalHalfConeAngle(const JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mNormalHalfConeAngle);
}

void JPH_SwingTwistConstraintSettings_Set_mNormalHalfConeAngle(JPH_SwingTwistConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mNormalHalfConeAngle = value;
}

float *JPH_SwingTwistConstraintSettings_GetMutable_mNormalHalfConeAngle(JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mNormalHalfConeAngle);
}

const float *JPH_SwingTwistConstraintSettings_Get_mPlaneHalfConeAngle(const JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mPlaneHalfConeAngle);
}

void JPH_SwingTwistConstraintSettings_Set_mPlaneHalfConeAngle(JPH_SwingTwistConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mPlaneHalfConeAngle = value;
}

float *JPH_SwingTwistConstraintSettings_GetMutable_mPlaneHalfConeAngle(JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mPlaneHalfConeAngle);
}

const float *JPH_SwingTwistConstraintSettings_Get_mTwistMinAngle(const JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mTwistMinAngle);
}

void JPH_SwingTwistConstraintSettings_Set_mTwistMinAngle(JPH_SwingTwistConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mTwistMinAngle = value;
}

float *JPH_SwingTwistConstraintSettings_GetMutable_mTwistMinAngle(JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mTwistMinAngle);
}

const float *JPH_SwingTwistConstraintSettings_Get_mTwistMaxAngle(const JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mTwistMaxAngle);
}

void JPH_SwingTwistConstraintSettings_Set_mTwistMaxAngle(JPH_SwingTwistConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mTwistMaxAngle = value;
}

float *JPH_SwingTwistConstraintSettings_GetMutable_mTwistMaxAngle(JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mTwistMaxAngle);
}

const float *JPH_SwingTwistConstraintSettings_Get_mMaxFrictionTorque(const JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mMaxFrictionTorque);
}

void JPH_SwingTwistConstraintSettings_Set_mMaxFrictionTorque(JPH_SwingTwistConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mMaxFrictionTorque = value;
}

float *JPH_SwingTwistConstraintSettings_GetMutable_mMaxFrictionTorque(JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mMaxFrictionTorque);
}

const JPH_MotorSettings *JPH_SwingTwistConstraintSettings_Get_mSwingMotorSettings(const JPH_SwingTwistConstraintSettings *_this)
{
    return (const JPH_MotorSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mSwingMotorSettings);
}

JPH_MotorSettings *JPH_SwingTwistConstraintSettings_GetMutable_mSwingMotorSettings(JPH_SwingTwistConstraintSettings *_this)
{
    return (JPH_MotorSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mSwingMotorSettings);
}

const JPH_MotorSettings *JPH_SwingTwistConstraintSettings_Get_mTwistMotorSettings(const JPH_SwingTwistConstraintSettings *_this)
{
    return (const JPH_MotorSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mTwistMotorSettings);
}

JPH_MotorSettings *JPH_SwingTwistConstraintSettings_GetMutable_mTwistMotorSettings(JPH_SwingTwistConstraintSettings *_this)
{
    return (JPH_MotorSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mTwistMotorSettings);
}

const bool *JPH_SwingTwistConstraintSettings_Get_mEnabled(const JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mEnabled);
}

void JPH_SwingTwistConstraintSettings_Set_mEnabled(JPH_SwingTwistConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mEnabled = value;
}

bool *JPH_SwingTwistConstraintSettings_GetMutable_mEnabled(JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mEnabled);
}

const unsigned int *JPH_SwingTwistConstraintSettings_Get_mConstraintPriority(const JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mConstraintPriority);
}

void JPH_SwingTwistConstraintSettings_Set_mConstraintPriority(JPH_SwingTwistConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mConstraintPriority = value;
}

unsigned int *JPH_SwingTwistConstraintSettings_GetMutable_mConstraintPriority(JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mConstraintPriority);
}

const unsigned int *JPH_SwingTwistConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_SwingTwistConstraintSettings_Set_mNumVelocityStepsOverride(JPH_SwingTwistConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_SwingTwistConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_SwingTwistConstraintSettings_Get_mNumPositionStepsOverride(const JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_SwingTwistConstraintSettings_Set_mNumPositionStepsOverride(JPH_SwingTwistConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_SwingTwistConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_SwingTwistConstraintSettings_Get_mDrawConstraintSize(const JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mDrawConstraintSize);
}

void JPH_SwingTwistConstraintSettings_Set_mDrawConstraintSize(JPH_SwingTwistConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mDrawConstraintSize = value;
}

float *JPH_SwingTwistConstraintSettings_GetMutable_mDrawConstraintSize(JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mDrawConstraintSize);
}

const uint64_t *JPH_SwingTwistConstraintSettings_Get_mUserData(const JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).mUserData);
}

void JPH_SwingTwistConstraintSettings_Set_mUserData(JPH_SwingTwistConstraintSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_SwingTwistConstraintSettings_GetMutable_mUserData(JPH_SwingTwistConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).mUserData);
}

JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SwingTwistConstraintSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SwingTwistConstraintSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SwingTwistConstraintSettings *)(new JPH::SwingTwistConstraintSettings[num_elems]);
}

const JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_OffsetPtr(const JPH_SwingTwistConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_SwingTwistConstraintSettings *)(((const JPH::SwingTwistConstraintSettings *)ptr) + i);
}

JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_OffsetMutablePtr(JPH_SwingTwistConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_SwingTwistConstraintSettings *)(((JPH::SwingTwistConstraintSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_SwingTwistConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_SwingTwistConstraintSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::SwingTwistConstraintSettings *)object)
    ));
}

JPH_SerializableObject *JPH_SwingTwistConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_SwingTwistConstraintSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::SwingTwistConstraintSettings *)object)
    ));
}

const JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_SwingTwistConstraintSettings *)(static_cast<const JPH::SwingTwistConstraintSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_SwingTwistConstraintSettings *)(static_cast<JPH::SwingTwistConstraintSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_SwingTwistConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_SwingTwistConstraintSettings *object)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<const JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((const JPH::SwingTwistConstraintSettings *)object)
    ));
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_SwingTwistConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_SwingTwistConstraintSettings *object)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((JPH::SwingTwistConstraintSettings *)object)
    ));
}

const JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (const JPH_SwingTwistConstraintSettings *)(static_cast<const JPH::SwingTwistConstraintSettings *>(
        ((const JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (JPH_SwingTwistConstraintSettings *)(static_cast<JPH::SwingTwistConstraintSettings *>(
        ((JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

const JPH_ConstraintSettings *JPH_SwingTwistConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_SwingTwistConstraintSettings *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::SwingTwistConstraintSettings *)object)
    ));
}

JPH_ConstraintSettings *JPH_SwingTwistConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_SwingTwistConstraintSettings *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::SwingTwistConstraintSettings *)object)
    ));
}

const JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object)
{
    return (const JPH_SwingTwistConstraintSettings *)(static_cast<const JPH::SwingTwistConstraintSettings *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object)
{
    return (JPH_SwingTwistConstraintSettings *)(static_cast<JPH::SwingTwistConstraintSettings *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

const JPH_TwoBodyConstraintSettings *JPH_SwingTwistConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_SwingTwistConstraintSettings *object)
{
    return (const JPH_TwoBodyConstraintSettings *)(static_cast<const JPH::TwoBodyConstraintSettings *>(
        ((const JPH::SwingTwistConstraintSettings *)object)
    ));
}

JPH_TwoBodyConstraintSettings *JPH_SwingTwistConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_SwingTwistConstraintSettings *object)
{
    return (JPH_TwoBodyConstraintSettings *)(static_cast<JPH::TwoBodyConstraintSettings *>(
        ((JPH::SwingTwistConstraintSettings *)object)
    ));
}

const JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object)
{
    return (const JPH_SwingTwistConstraintSettings *)(static_cast<const JPH::SwingTwistConstraintSettings *>(
        ((const JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object)
{
    return (JPH_SwingTwistConstraintSettings *)(static_cast<JPH::SwingTwistConstraintSettings *>(
        ((JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SwingTwistConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SwingTwistConstraintSettings);
    return (JPH_SwingTwistConstraintSettings *)new JPH::SwingTwistConstraintSettings(JPH::SwingTwistConstraintSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SwingTwistConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::SwingTwistConstraintSettings), JPH::SwingTwistConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::SwingTwistConstraintSettings), JPH::SwingTwistConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SwingTwistConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SwingTwistConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::SwingTwistConstraintSettings))
    ));
}

void JPH_SwingTwistConstraintSettings_Destroy(const JPH_SwingTwistConstraintSettings *_this)
{
    delete ((const JPH::SwingTwistConstraintSettings *)_this);
}

void JPH_SwingTwistConstraintSettings_DestroyArray(const JPH_SwingTwistConstraintSettings *_this)
{
    delete[] ((const JPH::SwingTwistConstraintSettings *)_this);
}

JPH_SwingTwistConstraintSettings *JPH_SwingTwistConstraintSettings_AssignFromAnother(JPH_SwingTwistConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_SwingTwistConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SwingTwistConstraintSettings);
    return (JPH_SwingTwistConstraintSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraintSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SwingTwistConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::SwingTwistConstraintSettings), JPH::SwingTwistConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::SwingTwistConstraintSettings), JPH::SwingTwistConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SwingTwistConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SwingTwistConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::SwingTwistConstraintSettings))
    ));
}

void *Jolt_new_JPH_SwingTwistConstraintSettings_size_t(size_t inCount)
{
    return JPH::SwingTwistConstraintSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SwingTwistConstraintSettings_void_ptr(void *inPointer)
{
    JPH::SwingTwistConstraintSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SwingTwistConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SwingTwistConstraintSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SwingTwistConstraintSettings_size_t(size_t inCount)
{
    return JPH::SwingTwistConstraintSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SwingTwistConstraintSettings_void_ptr(void *inPointer)
{
    JPH::SwingTwistConstraintSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SwingTwistConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SwingTwistConstraintSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SwingTwistConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SwingTwistConstraintSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SwingTwistConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SwingTwistConstraintSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SwingTwistConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SwingTwistConstraintSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SwingTwistConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SwingTwistConstraintSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_TwoBodyConstraint *JPH_SwingTwistConstraintSettings_Create(const JPH_SwingTwistConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2)
{
    return (JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).Create(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2))
    ));
}

void JPH_SwingTwistConstraintSettings_SetEmbedded(const JPH_SwingTwistConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_SwingTwistConstraintSettings_GetRefCount(const JPH_SwingTwistConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).GetRefCount();
}

void JPH_SwingTwistConstraintSettings_AddRef(const JPH_SwingTwistConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).AddRef();
}

void JPH_SwingTwistConstraintSettings_Release(const JPH_SwingTwistConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(_this)).Release();
}

int JPH_SwingTwistConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::SwingTwistConstraintSettings::sInternalGetRefCountOffset();
}

JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_SwingTwistConstraintSettings *inSettings)
{
    return (JPH_SwingTwistConstraint *)new JPH::SwingTwistConstraint(JPH::SwingTwistConstraint(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::SwingTwistConstraintSettings *)(inSettings))
    ));
}

const JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_OffsetPtr(const JPH_SwingTwistConstraint *ptr, ptrdiff_t i)
{
    return (const JPH_SwingTwistConstraint *)(((const JPH::SwingTwistConstraint *)ptr) + i);
}

JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_OffsetMutablePtr(JPH_SwingTwistConstraint *ptr, ptrdiff_t i)
{
    return (JPH_SwingTwistConstraint *)(((JPH::SwingTwistConstraint *)ptr) + i);
}

const JPH_RefTarget_JPH_Constraint *JPH_SwingTwistConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_SwingTwistConstraint *object)
{
    return (const JPH_RefTarget_JPH_Constraint *)(static_cast<const JPH::RefTarget<JPH::Constraint> *>(
        ((const JPH::SwingTwistConstraint *)object)
    ));
}

JPH_RefTarget_JPH_Constraint *JPH_SwingTwistConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_SwingTwistConstraint *object)
{
    return (JPH_RefTarget_JPH_Constraint *)(static_cast<JPH::RefTarget<JPH::Constraint> *>(
        ((JPH::SwingTwistConstraint *)object)
    ));
}

const JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object)
{
    return (const JPH_SwingTwistConstraint *)(static_cast<const JPH::SwingTwistConstraint *>(
        ((const JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object)
{
    return (JPH_SwingTwistConstraint *)(static_cast<JPH::SwingTwistConstraint *>(
        ((JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

const JPH_NonCopyable *JPH_SwingTwistConstraint_UpcastTo_JPH_NonCopyable(const JPH_SwingTwistConstraint *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::SwingTwistConstraint *)object)
    ));
}

JPH_NonCopyable *JPH_SwingTwistConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_SwingTwistConstraint *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::SwingTwistConstraint *)object)
    ));
}

const JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_SwingTwistConstraint *)(static_cast<const JPH::SwingTwistConstraint *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_SwingTwistConstraint *)(static_cast<JPH::SwingTwistConstraint *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Constraint *JPH_SwingTwistConstraint_UpcastTo_JPH_Constraint(const JPH_SwingTwistConstraint *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::SwingTwistConstraint *)object)
    ));
}

JPH_Constraint *JPH_SwingTwistConstraint_MutableUpcastTo_JPH_Constraint(JPH_SwingTwistConstraint *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::SwingTwistConstraint *)object)
    ));
}

const JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object)
{
    return (const JPH_SwingTwistConstraint *)(static_cast<const JPH::SwingTwistConstraint *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object)
{
    return (JPH_SwingTwistConstraint *)(static_cast<JPH::SwingTwistConstraint *>(
        ((JPH::Constraint *)object)
    ));
}

const JPH_TwoBodyConstraint *JPH_SwingTwistConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_SwingTwistConstraint *object)
{
    return (const JPH_TwoBodyConstraint *)(static_cast<const JPH::TwoBodyConstraint *>(
        ((const JPH::SwingTwistConstraint *)object)
    ));
}

JPH_TwoBodyConstraint *JPH_SwingTwistConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_SwingTwistConstraint *object)
{
    return (JPH_TwoBodyConstraint *)(static_cast<JPH::TwoBodyConstraint *>(
        ((JPH::SwingTwistConstraint *)object)
    ));
}

const JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object)
{
    return (const JPH_SwingTwistConstraint *)(static_cast<const JPH::SwingTwistConstraint *>(
        ((const JPH::TwoBodyConstraint *)object)
    ));
}

JPH_SwingTwistConstraint *JPH_SwingTwistConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object)
{
    return (JPH_SwingTwistConstraint *)(static_cast<JPH::SwingTwistConstraint *>(
        ((JPH::TwoBodyConstraint *)object)
    ));
}

void JPH_SwingTwistConstraint_Destroy(const JPH_SwingTwistConstraint *_this)
{
    delete ((const JPH::SwingTwistConstraint *)_this);
}

void JPH_SwingTwistConstraint_DestroyArray(const JPH_SwingTwistConstraint *_this)
{
    delete[] ((const JPH::SwingTwistConstraint *)_this);
}

void *Jolt_new_JPH_SwingTwistConstraint_size_t(size_t inCount)
{
    return JPH::SwingTwistConstraint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SwingTwistConstraint_void_ptr(void *inPointer)
{
    JPH::SwingTwistConstraint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SwingTwistConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SwingTwistConstraint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SwingTwistConstraint_size_t(size_t inCount)
{
    return JPH::SwingTwistConstraint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SwingTwistConstraint_void_ptr(void *inPointer)
{
    JPH::SwingTwistConstraint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SwingTwistConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SwingTwistConstraint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SwingTwistConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SwingTwistConstraint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SwingTwistConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SwingTwistConstraint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SwingTwistConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SwingTwistConstraint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SwingTwistConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SwingTwistConstraint::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_SwingTwistConstraint_NotifyShapeChanged(JPH_SwingTwistConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).NotifyShapeChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inDeltaCOM ? void() : MRBINDC_THROW("Parameter `inDeltaCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaCOM))
    );
}

void JPH_SwingTwistConstraint_SetupVelocityConstraint(JPH_SwingTwistConstraint *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetupVelocityConstraint(
        inDeltaTime
    );
}

void JPH_SwingTwistConstraint_ResetWarmStart(JPH_SwingTwistConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).ResetWarmStart();
}

void JPH_SwingTwistConstraint_WarmStartVelocityConstraint(JPH_SwingTwistConstraint *_this, float inWarmStartImpulseRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).WarmStartVelocityConstraint(
        inWarmStartImpulseRatio
    );
}

bool JPH_SwingTwistConstraint_SolveVelocityConstraint(JPH_SwingTwistConstraint *_this, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SolveVelocityConstraint(
        inDeltaTime
    );
}

bool JPH_SwingTwistConstraint_SolvePositionConstraint(JPH_SwingTwistConstraint *_this, float inDeltaTime, float inBaumgarte)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SolvePositionConstraint(
        inDeltaTime,
        inBaumgarte
    );
}

void JPH_SwingTwistConstraint_DrawConstraint(const JPH_SwingTwistConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).DrawConstraint(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

void JPH_SwingTwistConstraint_DrawConstraintLimits(const JPH_SwingTwistConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).DrawConstraintLimits(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

JPH_Mat44 *JPH_SwingTwistConstraint_GetConstraintToBody1Matrix(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetConstraintToBody1Matrix());
}

JPH_Mat44 *JPH_SwingTwistConstraint_GetConstraintToBody2Matrix(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetConstraintToBody2Matrix());
}

JPH_Vec3 *JPH_SwingTwistConstraint_GetLocalSpacePosition1(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetLocalSpacePosition1());
}

JPH_Vec3 *JPH_SwingTwistConstraint_GetLocalSpacePosition2(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetLocalSpacePosition2());
}

JPH_Quat *JPH_SwingTwistConstraint_GetConstraintToBody1(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetConstraintToBody1());
}

JPH_Quat *JPH_SwingTwistConstraint_GetConstraintToBody2(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetConstraintToBody2());
}

float JPH_SwingTwistConstraint_GetNormalHalfConeAngle(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetNormalHalfConeAngle();
}

void JPH_SwingTwistConstraint_SetNormalHalfConeAngle(JPH_SwingTwistConstraint *_this, float inAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetNormalHalfConeAngle(
        inAngle
    );
}

float JPH_SwingTwistConstraint_GetPlaneHalfConeAngle(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetPlaneHalfConeAngle();
}

void JPH_SwingTwistConstraint_SetPlaneHalfConeAngle(JPH_SwingTwistConstraint *_this, float inAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetPlaneHalfConeAngle(
        inAngle
    );
}

float JPH_SwingTwistConstraint_GetTwistMinAngle(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetTwistMinAngle();
}

void JPH_SwingTwistConstraint_SetTwistMinAngle(JPH_SwingTwistConstraint *_this, float inAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetTwistMinAngle(
        inAngle
    );
}

float JPH_SwingTwistConstraint_GetTwistMaxAngle(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetTwistMaxAngle();
}

void JPH_SwingTwistConstraint_SetTwistMaxAngle(JPH_SwingTwistConstraint *_this, float inAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetTwistMaxAngle(
        inAngle
    );
}

const JPH_MotorSettings *JPH_SwingTwistConstraint_GetSwingMotorSettings(const JPH_SwingTwistConstraint *_this)
{
    return (const JPH_MotorSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetSwingMotorSettings());
}

JPH_MotorSettings *JPH_SwingTwistConstraint_GetSwingMotorSettings_mut(JPH_SwingTwistConstraint *_this)
{
    return (JPH_MotorSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).GetSwingMotorSettings());
}

const JPH_MotorSettings *JPH_SwingTwistConstraint_GetTwistMotorSettings(const JPH_SwingTwistConstraint *_this)
{
    return (const JPH_MotorSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetTwistMotorSettings());
}

JPH_MotorSettings *JPH_SwingTwistConstraint_GetTwistMotorSettings_mut(JPH_SwingTwistConstraint *_this)
{
    return (JPH_MotorSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).GetTwistMotorSettings());
}

void JPH_SwingTwistConstraint_SetMaxFrictionTorque(JPH_SwingTwistConstraint *_this, float inFrictionTorque)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetMaxFrictionTorque(
        inFrictionTorque
    );
}

float JPH_SwingTwistConstraint_GetMaxFrictionTorque(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetMaxFrictionTorque();
}

void JPH_SwingTwistConstraint_SetSwingMotorState(JPH_SwingTwistConstraint *_this, JPH_EMotorState inState)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetSwingMotorState(
        ((JPH::EMotorState)inState)
    );
}

JPH_EMotorState JPH_SwingTwistConstraint_GetSwingMotorState(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_EMotorState)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetSwingMotorState());
}

void JPH_SwingTwistConstraint_SetTwistMotorState(JPH_SwingTwistConstraint *_this, JPH_EMotorState inState)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetTwistMotorState(
        ((JPH::EMotorState)inState)
    );
}

JPH_EMotorState JPH_SwingTwistConstraint_GetTwistMotorState(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_EMotorState)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetTwistMotorState());
}

void JPH_SwingTwistConstraint_SetTargetAngularVelocityCS(JPH_SwingTwistConstraint *_this, const JPH_Vec3 *inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetTargetAngularVelocityCS(
        ((inAngularVelocity ? void() : MRBINDC_THROW("Parameter `inAngularVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocity))
    );
}

JPH_Vec3 *JPH_SwingTwistConstraint_GetTargetAngularVelocityCS(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetTargetAngularVelocityCS());
}

void JPH_SwingTwistConstraint_SetTargetOrientationCS(JPH_SwingTwistConstraint *_this, const JPH_Quat *inOrientation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetTargetOrientationCS(
        ((inOrientation ? void() : MRBINDC_THROW("Parameter `inOrientation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inOrientation))
    );
}

JPH_Quat *JPH_SwingTwistConstraint_GetTargetOrientationCS(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetTargetOrientationCS());
}

void JPH_SwingTwistConstraint_SetTargetOrientationBS(JPH_SwingTwistConstraint *_this, const JPH_Quat *inOrientation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetTargetOrientationBS(
        ((inOrientation ? void() : MRBINDC_THROW("Parameter `inOrientation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inOrientation))
    );
}

JPH_Quat *JPH_SwingTwistConstraint_GetRotationInConstraintSpace(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetRotationInConstraintSpace());
}

JPH_Vec3 *JPH_SwingTwistConstraint_GetTotalLambdaPosition(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetTotalLambdaPosition());
}

float JPH_SwingTwistConstraint_GetTotalLambdaTwist(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetTotalLambdaTwist();
}

float JPH_SwingTwistConstraint_GetTotalLambdaSwingY(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetTotalLambdaSwingY();
}

float JPH_SwingTwistConstraint_GetTotalLambdaSwingZ(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetTotalLambdaSwingZ();
}

JPH_Vec3 *JPH_SwingTwistConstraint_GetTotalLambdaMotor(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetTotalLambdaMotor());
}

bool JPH_SwingTwistConstraint_IsActive(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).IsActive();
}

void JPH_SwingTwistConstraint_DrawConstraintReferenceFrame(const JPH_SwingTwistConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).DrawConstraintReferenceFrame(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

JPH_Body *JPH_SwingTwistConstraint_GetBody1(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetBody1());
}

JPH_Body *JPH_SwingTwistConstraint_GetBody2(const JPH_SwingTwistConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetBody2());
}

unsigned int JPH_SwingTwistConstraint_GetConstraintPriority(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetConstraintPriority();
}

void JPH_SwingTwistConstraint_SetConstraintPriority(JPH_SwingTwistConstraint *_this, unsigned int inPriority)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetConstraintPriority(
        inPriority
    );
}

void JPH_SwingTwistConstraint_SetNumVelocityStepsOverride(JPH_SwingTwistConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_SwingTwistConstraint_GetNumVelocityStepsOverride(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_SwingTwistConstraint_SetNumPositionStepsOverride(JPH_SwingTwistConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_SwingTwistConstraint_GetNumPositionStepsOverride(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetNumPositionStepsOverride();
}

void JPH_SwingTwistConstraint_SetEnabled(JPH_SwingTwistConstraint *_this, bool inEnabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetEnabled(
        inEnabled
    );
}

bool JPH_SwingTwistConstraint_GetEnabled(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetEnabled();
}

uint64_t JPH_SwingTwistConstraint_GetUserData(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetUserData();
}

void JPH_SwingTwistConstraint_SetUserData(JPH_SwingTwistConstraint *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetUserData(
        inUserData
    );
}

float JPH_SwingTwistConstraint_GetDrawConstraintSize(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetDrawConstraintSize();
}

void JPH_SwingTwistConstraint_SetDrawConstraintSize(JPH_SwingTwistConstraint *_this, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SwingTwistConstraint *)(_this)).SetDrawConstraintSize(
        inSize
    );
}

void JPH_SwingTwistConstraint_SetEmbedded(const JPH_SwingTwistConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).SetEmbedded();
}

unsigned int JPH_SwingTwistConstraint_GetRefCount(const JPH_SwingTwistConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).GetRefCount();
}

void JPH_SwingTwistConstraint_AddRef(const JPH_SwingTwistConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).AddRef();
}

void JPH_SwingTwistConstraint_Release(const JPH_SwingTwistConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SwingTwistConstraint *)(_this)).Release();
}

int JPH_SwingTwistConstraint_sInternalGetRefCountOffset(void)
{
    return JPH::SwingTwistConstraint::sInternalGetRefCountOffset();
}

