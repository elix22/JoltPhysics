// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/HingeConstraint.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Math/Vector.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/Constraints/HingeConstraint.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const JPH_Vec3 *JPH_HingeConstraintSettings_Get_mPoint1(const JPH_HingeConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mPoint1);
}

JPH_Vec3 *JPH_HingeConstraintSettings_GetMutable_mPoint1(JPH_HingeConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mPoint1);
}

const JPH_Vec3 *JPH_HingeConstraintSettings_Get_mHingeAxis1(const JPH_HingeConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mHingeAxis1);
}

JPH_Vec3 *JPH_HingeConstraintSettings_GetMutable_mHingeAxis1(JPH_HingeConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mHingeAxis1);
}

const JPH_Vec3 *JPH_HingeConstraintSettings_Get_mNormalAxis1(const JPH_HingeConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mNormalAxis1);
}

JPH_Vec3 *JPH_HingeConstraintSettings_GetMutable_mNormalAxis1(JPH_HingeConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mNormalAxis1);
}

const JPH_Vec3 *JPH_HingeConstraintSettings_Get_mPoint2(const JPH_HingeConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mPoint2);
}

JPH_Vec3 *JPH_HingeConstraintSettings_GetMutable_mPoint2(JPH_HingeConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mPoint2);
}

const JPH_Vec3 *JPH_HingeConstraintSettings_Get_mHingeAxis2(const JPH_HingeConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mHingeAxis2);
}

JPH_Vec3 *JPH_HingeConstraintSettings_GetMutable_mHingeAxis2(JPH_HingeConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mHingeAxis2);
}

const JPH_Vec3 *JPH_HingeConstraintSettings_Get_mNormalAxis2(const JPH_HingeConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mNormalAxis2);
}

JPH_Vec3 *JPH_HingeConstraintSettings_GetMutable_mNormalAxis2(JPH_HingeConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mNormalAxis2);
}

const float *JPH_HingeConstraintSettings_Get_mLimitsMin(const JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mLimitsMin);
}

void JPH_HingeConstraintSettings_Set_mLimitsMin(JPH_HingeConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mLimitsMin = value;
}

float *JPH_HingeConstraintSettings_GetMutable_mLimitsMin(JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mLimitsMin);
}

const float *JPH_HingeConstraintSettings_Get_mLimitsMax(const JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mLimitsMax);
}

void JPH_HingeConstraintSettings_Set_mLimitsMax(JPH_HingeConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mLimitsMax = value;
}

float *JPH_HingeConstraintSettings_GetMutable_mLimitsMax(JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mLimitsMax);
}

const float *JPH_HingeConstraintSettings_Get_mMaxFrictionTorque(const JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mMaxFrictionTorque);
}

void JPH_HingeConstraintSettings_Set_mMaxFrictionTorque(JPH_HingeConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mMaxFrictionTorque = value;
}

float *JPH_HingeConstraintSettings_GetMutable_mMaxFrictionTorque(JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mMaxFrictionTorque);
}

const bool *JPH_HingeConstraintSettings_Get_mEnabled(const JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mEnabled);
}

void JPH_HingeConstraintSettings_Set_mEnabled(JPH_HingeConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mEnabled = value;
}

bool *JPH_HingeConstraintSettings_GetMutable_mEnabled(JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mEnabled);
}

const unsigned int *JPH_HingeConstraintSettings_Get_mConstraintPriority(const JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mConstraintPriority);
}

void JPH_HingeConstraintSettings_Set_mConstraintPriority(JPH_HingeConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mConstraintPriority = value;
}

unsigned int *JPH_HingeConstraintSettings_GetMutable_mConstraintPriority(JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mConstraintPriority);
}

const unsigned int *JPH_HingeConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_HingeConstraintSettings_Set_mNumVelocityStepsOverride(JPH_HingeConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_HingeConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_HingeConstraintSettings_Get_mNumPositionStepsOverride(const JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_HingeConstraintSettings_Set_mNumPositionStepsOverride(JPH_HingeConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_HingeConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_HingeConstraintSettings_Get_mDrawConstraintSize(const JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mDrawConstraintSize);
}

void JPH_HingeConstraintSettings_Set_mDrawConstraintSize(JPH_HingeConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mDrawConstraintSize = value;
}

float *JPH_HingeConstraintSettings_GetMutable_mDrawConstraintSize(JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mDrawConstraintSize);
}

const uint64_t *JPH_HingeConstraintSettings_Get_mUserData(const JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).mUserData);
}

void JPH_HingeConstraintSettings_Set_mUserData(JPH_HingeConstraintSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_HingeConstraintSettings_GetMutable_mUserData(JPH_HingeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).mUserData);
}

JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_DefaultConstruct(void)
{
    return (JPH_HingeConstraintSettings *)new JPH::HingeConstraintSettings(JPH::HingeConstraintSettings());
}

JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_HingeConstraintSettings *)(new JPH::HingeConstraintSettings[num_elems]{});
}

const JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_OffsetPtr(const JPH_HingeConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_HingeConstraintSettings *)(((const JPH::HingeConstraintSettings *)ptr) + i);
}

JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_OffsetMutablePtr(JPH_HingeConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_HingeConstraintSettings *)(((JPH::HingeConstraintSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_HingeConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_HingeConstraintSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::HingeConstraintSettings *)object)
    ));
}

JPH_SerializableObject *JPH_HingeConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_HingeConstraintSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::HingeConstraintSettings *)object)
    ));
}

const JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_HingeConstraintSettings *)(static_cast<const JPH::HingeConstraintSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_HingeConstraintSettings *)(static_cast<JPH::HingeConstraintSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_HingeConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_HingeConstraintSettings *object)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<const JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((const JPH::HingeConstraintSettings *)object)
    ));
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_HingeConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_HingeConstraintSettings *object)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((JPH::HingeConstraintSettings *)object)
    ));
}

const JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (const JPH_HingeConstraintSettings *)(static_cast<const JPH::HingeConstraintSettings *>(
        ((const JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (JPH_HingeConstraintSettings *)(static_cast<JPH::HingeConstraintSettings *>(
        ((JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

const JPH_ConstraintSettings *JPH_HingeConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_HingeConstraintSettings *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::HingeConstraintSettings *)object)
    ));
}

JPH_ConstraintSettings *JPH_HingeConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_HingeConstraintSettings *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::HingeConstraintSettings *)object)
    ));
}

const JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object)
{
    return (const JPH_HingeConstraintSettings *)(static_cast<const JPH::HingeConstraintSettings *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object)
{
    return (JPH_HingeConstraintSettings *)(static_cast<JPH::HingeConstraintSettings *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

const JPH_TwoBodyConstraintSettings *JPH_HingeConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_HingeConstraintSettings *object)
{
    return (const JPH_TwoBodyConstraintSettings *)(static_cast<const JPH::TwoBodyConstraintSettings *>(
        ((const JPH::HingeConstraintSettings *)object)
    ));
}

JPH_TwoBodyConstraintSettings *JPH_HingeConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_HingeConstraintSettings *object)
{
    return (JPH_TwoBodyConstraintSettings *)(static_cast<JPH::TwoBodyConstraintSettings *>(
        ((JPH::HingeConstraintSettings *)object)
    ));
}

const JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object)
{
    return (const JPH_HingeConstraintSettings *)(static_cast<const JPH::HingeConstraintSettings *>(
        ((const JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object)
{
    return (JPH_HingeConstraintSettings *)(static_cast<JPH::HingeConstraintSettings *>(
        ((JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_HingeConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::HingeConstraintSettings);
    return (JPH_HingeConstraintSettings *)new JPH::HingeConstraintSettings(JPH::HingeConstraintSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::HingeConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::HingeConstraintSettings), JPH::HingeConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::HingeConstraintSettings), JPH::HingeConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::HingeConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::HingeConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::HingeConstraintSettings))
    ));
}

void JPH_HingeConstraintSettings_Destroy(const JPH_HingeConstraintSettings *_this)
{
    delete ((const JPH::HingeConstraintSettings *)_this);
}

void JPH_HingeConstraintSettings_DestroyArray(const JPH_HingeConstraintSettings *_this)
{
    delete[] ((const JPH::HingeConstraintSettings *)_this);
}

JPH_HingeConstraintSettings *JPH_HingeConstraintSettings_AssignFromAnother(JPH_HingeConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_HingeConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::HingeConstraintSettings);
    return (JPH_HingeConstraintSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraintSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::HingeConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::HingeConstraintSettings), JPH::HingeConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::HingeConstraintSettings), JPH::HingeConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::HingeConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::HingeConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::HingeConstraintSettings))
    ));
}

void *Jolt_new_JPH_HingeConstraintSettings_size_t(size_t inCount)
{
    return JPH::HingeConstraintSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_HingeConstraintSettings_void_ptr(void *inPointer)
{
    JPH::HingeConstraintSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_HingeConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::HingeConstraintSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_HingeConstraintSettings_size_t(size_t inCount)
{
    return JPH::HingeConstraintSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr(void *inPointer)
{
    JPH::HingeConstraintSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::HingeConstraintSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_HingeConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::HingeConstraintSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_HingeConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::HingeConstraintSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_HingeConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::HingeConstraintSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::HingeConstraintSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_TwoBodyConstraint *JPH_HingeConstraintSettings_Create(const JPH_HingeConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2)
{
    return (JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).Create(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2))
    ));
}

void JPH_HingeConstraintSettings_SetEmbedded(const JPH_HingeConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_HingeConstraintSettings_GetRefCount(const JPH_HingeConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).GetRefCount();
}

void JPH_HingeConstraintSettings_AddRef(const JPH_HingeConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).AddRef();
}

void JPH_HingeConstraintSettings_Release(const JPH_HingeConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(_this)).Release();
}

int JPH_HingeConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::HingeConstraintSettings::sInternalGetRefCountOffset();
}

JPH_HingeConstraint *JPH_HingeConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_HingeConstraintSettings *inSettings)
{
    return (JPH_HingeConstraint *)new JPH::HingeConstraint(JPH::HingeConstraint(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::HingeConstraintSettings *)(inSettings))
    ));
}

const JPH_HingeConstraint *JPH_HingeConstraint_OffsetPtr(const JPH_HingeConstraint *ptr, ptrdiff_t i)
{
    return (const JPH_HingeConstraint *)(((const JPH::HingeConstraint *)ptr) + i);
}

JPH_HingeConstraint *JPH_HingeConstraint_OffsetMutablePtr(JPH_HingeConstraint *ptr, ptrdiff_t i)
{
    return (JPH_HingeConstraint *)(((JPH::HingeConstraint *)ptr) + i);
}

const JPH_RefTarget_JPH_Constraint *JPH_HingeConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_HingeConstraint *object)
{
    return (const JPH_RefTarget_JPH_Constraint *)(static_cast<const JPH::RefTarget<JPH::Constraint> *>(
        ((const JPH::HingeConstraint *)object)
    ));
}

JPH_RefTarget_JPH_Constraint *JPH_HingeConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_HingeConstraint *object)
{
    return (JPH_RefTarget_JPH_Constraint *)(static_cast<JPH::RefTarget<JPH::Constraint> *>(
        ((JPH::HingeConstraint *)object)
    ));
}

const JPH_HingeConstraint *JPH_HingeConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object)
{
    return (const JPH_HingeConstraint *)(static_cast<const JPH::HingeConstraint *>(
        ((const JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

JPH_HingeConstraint *JPH_HingeConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object)
{
    return (JPH_HingeConstraint *)(static_cast<JPH::HingeConstraint *>(
        ((JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

const JPH_NonCopyable *JPH_HingeConstraint_UpcastTo_JPH_NonCopyable(const JPH_HingeConstraint *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::HingeConstraint *)object)
    ));
}

JPH_NonCopyable *JPH_HingeConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_HingeConstraint *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::HingeConstraint *)object)
    ));
}

const JPH_HingeConstraint *JPH_HingeConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_HingeConstraint *)(static_cast<const JPH::HingeConstraint *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_HingeConstraint *JPH_HingeConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_HingeConstraint *)(static_cast<JPH::HingeConstraint *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Constraint *JPH_HingeConstraint_UpcastTo_JPH_Constraint(const JPH_HingeConstraint *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::HingeConstraint *)object)
    ));
}

JPH_Constraint *JPH_HingeConstraint_MutableUpcastTo_JPH_Constraint(JPH_HingeConstraint *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::HingeConstraint *)object)
    ));
}

const JPH_HingeConstraint *JPH_HingeConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object)
{
    return (const JPH_HingeConstraint *)(static_cast<const JPH::HingeConstraint *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_HingeConstraint *JPH_HingeConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object)
{
    return (JPH_HingeConstraint *)(static_cast<JPH::HingeConstraint *>(
        ((JPH::Constraint *)object)
    ));
}

const JPH_TwoBodyConstraint *JPH_HingeConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_HingeConstraint *object)
{
    return (const JPH_TwoBodyConstraint *)(static_cast<const JPH::TwoBodyConstraint *>(
        ((const JPH::HingeConstraint *)object)
    ));
}

JPH_TwoBodyConstraint *JPH_HingeConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_HingeConstraint *object)
{
    return (JPH_TwoBodyConstraint *)(static_cast<JPH::TwoBodyConstraint *>(
        ((JPH::HingeConstraint *)object)
    ));
}

const JPH_HingeConstraint *JPH_HingeConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object)
{
    return (const JPH_HingeConstraint *)(static_cast<const JPH::HingeConstraint *>(
        ((const JPH::TwoBodyConstraint *)object)
    ));
}

JPH_HingeConstraint *JPH_HingeConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object)
{
    return (JPH_HingeConstraint *)(static_cast<JPH::HingeConstraint *>(
        ((JPH::TwoBodyConstraint *)object)
    ));
}

void JPH_HingeConstraint_Destroy(const JPH_HingeConstraint *_this)
{
    delete ((const JPH::HingeConstraint *)_this);
}

void JPH_HingeConstraint_DestroyArray(const JPH_HingeConstraint *_this)
{
    delete[] ((const JPH::HingeConstraint *)_this);
}

void *Jolt_new_JPH_HingeConstraint_size_t(size_t inCount)
{
    return JPH::HingeConstraint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_HingeConstraint_void_ptr(void *inPointer)
{
    JPH::HingeConstraint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_HingeConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::HingeConstraint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_HingeConstraint_size_t(size_t inCount)
{
    return JPH::HingeConstraint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_HingeConstraint_void_ptr(void *inPointer)
{
    JPH::HingeConstraint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_HingeConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::HingeConstraint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_HingeConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::HingeConstraint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_HingeConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::HingeConstraint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_HingeConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::HingeConstraint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_HingeConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::HingeConstraint::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_HingeConstraint_NotifyShapeChanged(JPH_HingeConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).NotifyShapeChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inDeltaCOM ? void() : MRBINDC_THROW("Parameter `inDeltaCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaCOM))
    );
}

void JPH_HingeConstraint_SetupVelocityConstraint(JPH_HingeConstraint *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).SetupVelocityConstraint(
        inDeltaTime
    );
}

void JPH_HingeConstraint_ResetWarmStart(JPH_HingeConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).ResetWarmStart();
}

void JPH_HingeConstraint_WarmStartVelocityConstraint(JPH_HingeConstraint *_this, float inWarmStartImpulseRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).WarmStartVelocityConstraint(
        inWarmStartImpulseRatio
    );
}

bool JPH_HingeConstraint_SolveVelocityConstraint(JPH_HingeConstraint *_this, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).SolveVelocityConstraint(
        inDeltaTime
    );
}

bool JPH_HingeConstraint_SolvePositionConstraint(JPH_HingeConstraint *_this, float inDeltaTime, float inBaumgarte)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).SolvePositionConstraint(
        inDeltaTime,
        inBaumgarte
    );
}

JPH_Mat44 *JPH_HingeConstraint_GetConstraintToBody1Matrix(const JPH_HingeConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetConstraintToBody1Matrix());
}

JPH_Mat44 *JPH_HingeConstraint_GetConstraintToBody2Matrix(const JPH_HingeConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetConstraintToBody2Matrix());
}

JPH_Vec3 *JPH_HingeConstraint_GetLocalSpacePoint1(const JPH_HingeConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetLocalSpacePoint1());
}

JPH_Vec3 *JPH_HingeConstraint_GetLocalSpacePoint2(const JPH_HingeConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetLocalSpacePoint2());
}

JPH_Vec3 *JPH_HingeConstraint_GetLocalSpaceHingeAxis1(const JPH_HingeConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetLocalSpaceHingeAxis1());
}

JPH_Vec3 *JPH_HingeConstraint_GetLocalSpaceHingeAxis2(const JPH_HingeConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetLocalSpaceHingeAxis2());
}

JPH_Vec3 *JPH_HingeConstraint_GetLocalSpaceNormalAxis1(const JPH_HingeConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetLocalSpaceNormalAxis1());
}

JPH_Vec3 *JPH_HingeConstraint_GetLocalSpaceNormalAxis2(const JPH_HingeConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetLocalSpaceNormalAxis2());
}

float JPH_HingeConstraint_GetCurrentAngle(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetCurrentAngle();
}

void JPH_HingeConstraint_SetMaxFrictionTorque(JPH_HingeConstraint *_this, float inFrictionTorque)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).SetMaxFrictionTorque(
        inFrictionTorque
    );
}

float JPH_HingeConstraint_GetMaxFrictionTorque(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetMaxFrictionTorque();
}

void JPH_HingeConstraint_SetTargetAngularVelocity(JPH_HingeConstraint *_this, float inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).SetTargetAngularVelocity(
        inAngularVelocity
    );
}

float JPH_HingeConstraint_GetTargetAngularVelocity(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetTargetAngularVelocity();
}

void JPH_HingeConstraint_SetTargetAngle(JPH_HingeConstraint *_this, float inAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).SetTargetAngle(
        inAngle
    );
}

float JPH_HingeConstraint_GetTargetAngle(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetTargetAngle();
}

void JPH_HingeConstraint_SetTargetOrientationBS(JPH_HingeConstraint *_this, const JPH_Quat *inOrientation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).SetTargetOrientationBS(
        ((inOrientation ? void() : MRBINDC_THROW("Parameter `inOrientation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inOrientation))
    );
}

void JPH_HingeConstraint_SetLimits(JPH_HingeConstraint *_this, float inLimitsMin, float inLimitsMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).SetLimits(
        inLimitsMin,
        inLimitsMax
    );
}

float JPH_HingeConstraint_GetLimitsMin(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetLimitsMin();
}

float JPH_HingeConstraint_GetLimitsMax(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetLimitsMax();
}

bool JPH_HingeConstraint_HasLimits(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).HasLimits();
}

JPH_Vec3 *JPH_HingeConstraint_GetTotalLambdaPosition(const JPH_HingeConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetTotalLambdaPosition());
}

JPH_Vector_2 *JPH_HingeConstraint_GetTotalLambdaRotation(const JPH_HingeConstraint *_this)
{
    return (JPH_Vector_2 *)new JPH::Vector<2>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetTotalLambdaRotation());
}

float JPH_HingeConstraint_GetTotalLambdaRotationLimits(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetTotalLambdaRotationLimits();
}

float JPH_HingeConstraint_GetTotalLambdaMotor(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetTotalLambdaMotor();
}

bool JPH_HingeConstraint_IsActive(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).IsActive();
}

JPH_Body *JPH_HingeConstraint_GetBody1(const JPH_HingeConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetBody1());
}

JPH_Body *JPH_HingeConstraint_GetBody2(const JPH_HingeConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetBody2());
}

unsigned int JPH_HingeConstraint_GetConstraintPriority(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetConstraintPriority();
}

void JPH_HingeConstraint_SetConstraintPriority(JPH_HingeConstraint *_this, unsigned int inPriority)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).SetConstraintPriority(
        inPriority
    );
}

void JPH_HingeConstraint_SetNumVelocityStepsOverride(JPH_HingeConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_HingeConstraint_GetNumVelocityStepsOverride(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_HingeConstraint_SetNumPositionStepsOverride(JPH_HingeConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_HingeConstraint_GetNumPositionStepsOverride(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetNumPositionStepsOverride();
}

void JPH_HingeConstraint_SetEnabled(JPH_HingeConstraint *_this, bool inEnabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).SetEnabled(
        inEnabled
    );
}

bool JPH_HingeConstraint_GetEnabled(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetEnabled();
}

uint64_t JPH_HingeConstraint_GetUserData(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetUserData();
}

void JPH_HingeConstraint_SetUserData(JPH_HingeConstraint *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::HingeConstraint *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_HingeConstraint_SetEmbedded(const JPH_HingeConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).SetEmbedded();
}

unsigned int JPH_HingeConstraint_GetRefCount(const JPH_HingeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).GetRefCount();
}

void JPH_HingeConstraint_AddRef(const JPH_HingeConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).AddRef();
}

void JPH_HingeConstraint_Release(const JPH_HingeConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::HingeConstraint *)(_this)).Release();
}

int JPH_HingeConstraint_sInternalGetRefCountOffset(void)
{
    return JPH::HingeConstraint::sInternalGetRefCountOffset();
}

