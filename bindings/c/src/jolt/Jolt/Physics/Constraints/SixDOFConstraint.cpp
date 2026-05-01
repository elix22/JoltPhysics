// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/SixDOFConstraint.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/Constraints/SixDOFConstraint.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>
#include <type_traits>


const JPH_Vec3 *JPH_SixDOFConstraintSettings_Get_mPosition1(const JPH_SixDOFConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mPosition1);
}

JPH_Vec3 *JPH_SixDOFConstraintSettings_GetMutable_mPosition1(JPH_SixDOFConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mPosition1);
}

const JPH_Vec3 *JPH_SixDOFConstraintSettings_Get_mAxisX1(const JPH_SixDOFConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mAxisX1);
}

JPH_Vec3 *JPH_SixDOFConstraintSettings_GetMutable_mAxisX1(JPH_SixDOFConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mAxisX1);
}

const JPH_Vec3 *JPH_SixDOFConstraintSettings_Get_mAxisY1(const JPH_SixDOFConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mAxisY1);
}

JPH_Vec3 *JPH_SixDOFConstraintSettings_GetMutable_mAxisY1(JPH_SixDOFConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mAxisY1);
}

const JPH_Vec3 *JPH_SixDOFConstraintSettings_Get_mPosition2(const JPH_SixDOFConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mPosition2);
}

JPH_Vec3 *JPH_SixDOFConstraintSettings_GetMutable_mPosition2(JPH_SixDOFConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mPosition2);
}

const JPH_Vec3 *JPH_SixDOFConstraintSettings_Get_mAxisX2(const JPH_SixDOFConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mAxisX2);
}

JPH_Vec3 *JPH_SixDOFConstraintSettings_GetMutable_mAxisX2(JPH_SixDOFConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mAxisX2);
}

const JPH_Vec3 *JPH_SixDOFConstraintSettings_Get_mAxisY2(const JPH_SixDOFConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mAxisY2);
}

JPH_Vec3 *JPH_SixDOFConstraintSettings_GetMutable_mAxisY2(JPH_SixDOFConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mAxisY2);
}

const float *JPH_SixDOFConstraintSettings_Get_mMaxFriction(const JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mMaxFriction[0]);
}

float *JPH_SixDOFConstraintSettings_GetMutable_mMaxFriction(JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mMaxFriction[0]);
}

size_t JPH_SixDOFConstraintSettings_GetSize_mMaxFriction(void)
{
    return std::extent_v<decltype(JPH::SixDOFConstraintSettings::mMaxFriction)>;
}

const float *JPH_SixDOFConstraintSettings_Get_mLimitMin(const JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mLimitMin[0]);
}

float *JPH_SixDOFConstraintSettings_GetMutable_mLimitMin(JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mLimitMin[0]);
}

size_t JPH_SixDOFConstraintSettings_GetSize_mLimitMin(void)
{
    return std::extent_v<decltype(JPH::SixDOFConstraintSettings::mLimitMin)>;
}

const float *JPH_SixDOFConstraintSettings_Get_mLimitMax(const JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mLimitMax[0]);
}

float *JPH_SixDOFConstraintSettings_GetMutable_mLimitMax(JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mLimitMax[0]);
}

size_t JPH_SixDOFConstraintSettings_GetSize_mLimitMax(void)
{
    return std::extent_v<decltype(JPH::SixDOFConstraintSettings::mLimitMax)>;
}

const bool *JPH_SixDOFConstraintSettings_Get_mEnabled(const JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mEnabled);
}

void JPH_SixDOFConstraintSettings_Set_mEnabled(JPH_SixDOFConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mEnabled = value;
}

bool *JPH_SixDOFConstraintSettings_GetMutable_mEnabled(JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mEnabled);
}

const unsigned int *JPH_SixDOFConstraintSettings_Get_mConstraintPriority(const JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mConstraintPriority);
}

void JPH_SixDOFConstraintSettings_Set_mConstraintPriority(JPH_SixDOFConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mConstraintPriority = value;
}

unsigned int *JPH_SixDOFConstraintSettings_GetMutable_mConstraintPriority(JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mConstraintPriority);
}

const unsigned int *JPH_SixDOFConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_SixDOFConstraintSettings_Set_mNumVelocityStepsOverride(JPH_SixDOFConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_SixDOFConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_SixDOFConstraintSettings_Get_mNumPositionStepsOverride(const JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_SixDOFConstraintSettings_Set_mNumPositionStepsOverride(JPH_SixDOFConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_SixDOFConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_SixDOFConstraintSettings_Get_mDrawConstraintSize(const JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mDrawConstraintSize);
}

void JPH_SixDOFConstraintSettings_Set_mDrawConstraintSize(JPH_SixDOFConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mDrawConstraintSize = value;
}

float *JPH_SixDOFConstraintSettings_GetMutable_mDrawConstraintSize(JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mDrawConstraintSize);
}

const uint64_t *JPH_SixDOFConstraintSettings_Get_mUserData(const JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).mUserData);
}

void JPH_SixDOFConstraintSettings_Set_mUserData(JPH_SixDOFConstraintSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_SixDOFConstraintSettings_GetMutable_mUserData(JPH_SixDOFConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).mUserData);
}

JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SixDOFConstraintSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SixDOFConstraintSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SixDOFConstraintSettings *)(new JPH::SixDOFConstraintSettings[num_elems]{});
}

const JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_OffsetPtr(const JPH_SixDOFConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_SixDOFConstraintSettings *)(((const JPH::SixDOFConstraintSettings *)ptr) + i);
}

JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_OffsetMutablePtr(JPH_SixDOFConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_SixDOFConstraintSettings *)(((JPH::SixDOFConstraintSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_SixDOFConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_SixDOFConstraintSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::SixDOFConstraintSettings *)object)
    ));
}

JPH_SerializableObject *JPH_SixDOFConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_SixDOFConstraintSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::SixDOFConstraintSettings *)object)
    ));
}

const JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_SixDOFConstraintSettings *)(static_cast<const JPH::SixDOFConstraintSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_SixDOFConstraintSettings *)(static_cast<JPH::SixDOFConstraintSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_SixDOFConstraintSettings *object)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<const JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((const JPH::SixDOFConstraintSettings *)object)
    ));
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_SixDOFConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_SixDOFConstraintSettings *object)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((JPH::SixDOFConstraintSettings *)object)
    ));
}

const JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (const JPH_SixDOFConstraintSettings *)(static_cast<const JPH::SixDOFConstraintSettings *>(
        ((const JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (JPH_SixDOFConstraintSettings *)(static_cast<JPH::SixDOFConstraintSettings *>(
        ((JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

const JPH_ConstraintSettings *JPH_SixDOFConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_SixDOFConstraintSettings *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::SixDOFConstraintSettings *)object)
    ));
}

JPH_ConstraintSettings *JPH_SixDOFConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_SixDOFConstraintSettings *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::SixDOFConstraintSettings *)object)
    ));
}

const JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object)
{
    return (const JPH_SixDOFConstraintSettings *)(static_cast<const JPH::SixDOFConstraintSettings *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object)
{
    return (JPH_SixDOFConstraintSettings *)(static_cast<JPH::SixDOFConstraintSettings *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

const JPH_TwoBodyConstraintSettings *JPH_SixDOFConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_SixDOFConstraintSettings *object)
{
    return (const JPH_TwoBodyConstraintSettings *)(static_cast<const JPH::TwoBodyConstraintSettings *>(
        ((const JPH::SixDOFConstraintSettings *)object)
    ));
}

JPH_TwoBodyConstraintSettings *JPH_SixDOFConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_SixDOFConstraintSettings *object)
{
    return (JPH_TwoBodyConstraintSettings *)(static_cast<JPH::TwoBodyConstraintSettings *>(
        ((JPH::SixDOFConstraintSettings *)object)
    ));
}

const JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object)
{
    return (const JPH_SixDOFConstraintSettings *)(static_cast<const JPH::SixDOFConstraintSettings *>(
        ((const JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object)
{
    return (JPH_SixDOFConstraintSettings *)(static_cast<JPH::SixDOFConstraintSettings *>(
        ((JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SixDOFConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SixDOFConstraintSettings);
    return (JPH_SixDOFConstraintSettings *)new JPH::SixDOFConstraintSettings(JPH::SixDOFConstraintSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SixDOFConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::SixDOFConstraintSettings), JPH::SixDOFConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::SixDOFConstraintSettings), JPH::SixDOFConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SixDOFConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SixDOFConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::SixDOFConstraintSettings))
    ));
}

void JPH_SixDOFConstraintSettings_Destroy(const JPH_SixDOFConstraintSettings *_this)
{
    delete ((const JPH::SixDOFConstraintSettings *)_this);
}

void JPH_SixDOFConstraintSettings_DestroyArray(const JPH_SixDOFConstraintSettings *_this)
{
    delete[] ((const JPH::SixDOFConstraintSettings *)_this);
}

JPH_SixDOFConstraintSettings *JPH_SixDOFConstraintSettings_AssignFromAnother(JPH_SixDOFConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_SixDOFConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SixDOFConstraintSettings);
    return (JPH_SixDOFConstraintSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SixDOFConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::SixDOFConstraintSettings), JPH::SixDOFConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::SixDOFConstraintSettings), JPH::SixDOFConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SixDOFConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SixDOFConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::SixDOFConstraintSettings))
    ));
}

void *Jolt_new_JPH_SixDOFConstraintSettings_size_t(size_t inCount)
{
    return JPH::SixDOFConstraintSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr(void *inPointer)
{
    JPH::SixDOFConstraintSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SixDOFConstraintSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SixDOFConstraintSettings_size_t(size_t inCount)
{
    return JPH::SixDOFConstraintSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr(void *inPointer)
{
    JPH::SixDOFConstraintSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SixDOFConstraintSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SixDOFConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SixDOFConstraintSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SixDOFConstraintSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SixDOFConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SixDOFConstraintSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SixDOFConstraintSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_TwoBodyConstraint *JPH_SixDOFConstraintSettings_Create(const JPH_SixDOFConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2)
{
    return (JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).Create(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2))
    ));
}

void JPH_SixDOFConstraintSettings_MakeFreeAxis(JPH_SixDOFConstraintSettings *_this, JPH_SixDOFConstraintSettings_EAxis inAxis)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).MakeFreeAxis(
        ((JPH::SixDOFConstraintSettings::EAxis)inAxis)
    );
}

bool JPH_SixDOFConstraintSettings_IsFreeAxis(const JPH_SixDOFConstraintSettings *_this, JPH_SixDOFConstraintSettings_EAxis inAxis)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).IsFreeAxis(
        ((JPH::SixDOFConstraintSettings::EAxis)inAxis)
    );
}

void JPH_SixDOFConstraintSettings_MakeFixedAxis(JPH_SixDOFConstraintSettings *_this, JPH_SixDOFConstraintSettings_EAxis inAxis)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).MakeFixedAxis(
        ((JPH::SixDOFConstraintSettings::EAxis)inAxis)
    );
}

bool JPH_SixDOFConstraintSettings_IsFixedAxis(const JPH_SixDOFConstraintSettings *_this, JPH_SixDOFConstraintSettings_EAxis inAxis)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).IsFixedAxis(
        ((JPH::SixDOFConstraintSettings::EAxis)inAxis)
    );
}

void JPH_SixDOFConstraintSettings_SetLimitedAxis(JPH_SixDOFConstraintSettings *_this, JPH_SixDOFConstraintSettings_EAxis inAxis, float inMin, float inMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraintSettings *)(_this)).SetLimitedAxis(
        ((JPH::SixDOFConstraintSettings::EAxis)inAxis),
        inMin,
        inMax
    );
}

void JPH_SixDOFConstraintSettings_SetEmbedded(const JPH_SixDOFConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_SixDOFConstraintSettings_GetRefCount(const JPH_SixDOFConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).GetRefCount();
}

void JPH_SixDOFConstraintSettings_AddRef(const JPH_SixDOFConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).AddRef();
}

void JPH_SixDOFConstraintSettings_Release(const JPH_SixDOFConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(_this)).Release();
}

int JPH_SixDOFConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::SixDOFConstraintSettings::sInternalGetRefCountOffset();
}

JPH_SixDOFConstraint *JPH_SixDOFConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_SixDOFConstraintSettings *inSettings)
{
    return (JPH_SixDOFConstraint *)new JPH::SixDOFConstraint(JPH::SixDOFConstraint(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::SixDOFConstraintSettings *)(inSettings))
    ));
}

const JPH_SixDOFConstraint *JPH_SixDOFConstraint_OffsetPtr(const JPH_SixDOFConstraint *ptr, ptrdiff_t i)
{
    return (const JPH_SixDOFConstraint *)(((const JPH::SixDOFConstraint *)ptr) + i);
}

JPH_SixDOFConstraint *JPH_SixDOFConstraint_OffsetMutablePtr(JPH_SixDOFConstraint *ptr, ptrdiff_t i)
{
    return (JPH_SixDOFConstraint *)(((JPH::SixDOFConstraint *)ptr) + i);
}

const JPH_RefTarget_JPH_Constraint *JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_SixDOFConstraint *object)
{
    return (const JPH_RefTarget_JPH_Constraint *)(static_cast<const JPH::RefTarget<JPH::Constraint> *>(
        ((const JPH::SixDOFConstraint *)object)
    ));
}

JPH_RefTarget_JPH_Constraint *JPH_SixDOFConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_SixDOFConstraint *object)
{
    return (JPH_RefTarget_JPH_Constraint *)(static_cast<JPH::RefTarget<JPH::Constraint> *>(
        ((JPH::SixDOFConstraint *)object)
    ));
}

const JPH_SixDOFConstraint *JPH_SixDOFConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object)
{
    return (const JPH_SixDOFConstraint *)(static_cast<const JPH::SixDOFConstraint *>(
        ((const JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

JPH_SixDOFConstraint *JPH_SixDOFConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object)
{
    return (JPH_SixDOFConstraint *)(static_cast<JPH::SixDOFConstraint *>(
        ((JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

const JPH_NonCopyable *JPH_SixDOFConstraint_UpcastTo_JPH_NonCopyable(const JPH_SixDOFConstraint *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::SixDOFConstraint *)object)
    ));
}

JPH_NonCopyable *JPH_SixDOFConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_SixDOFConstraint *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::SixDOFConstraint *)object)
    ));
}

const JPH_SixDOFConstraint *JPH_SixDOFConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_SixDOFConstraint *)(static_cast<const JPH::SixDOFConstraint *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_SixDOFConstraint *JPH_SixDOFConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_SixDOFConstraint *)(static_cast<JPH::SixDOFConstraint *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Constraint *JPH_SixDOFConstraint_UpcastTo_JPH_Constraint(const JPH_SixDOFConstraint *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::SixDOFConstraint *)object)
    ));
}

JPH_Constraint *JPH_SixDOFConstraint_MutableUpcastTo_JPH_Constraint(JPH_SixDOFConstraint *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::SixDOFConstraint *)object)
    ));
}

const JPH_SixDOFConstraint *JPH_SixDOFConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object)
{
    return (const JPH_SixDOFConstraint *)(static_cast<const JPH::SixDOFConstraint *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_SixDOFConstraint *JPH_SixDOFConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object)
{
    return (JPH_SixDOFConstraint *)(static_cast<JPH::SixDOFConstraint *>(
        ((JPH::Constraint *)object)
    ));
}

const JPH_TwoBodyConstraint *JPH_SixDOFConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_SixDOFConstraint *object)
{
    return (const JPH_TwoBodyConstraint *)(static_cast<const JPH::TwoBodyConstraint *>(
        ((const JPH::SixDOFConstraint *)object)
    ));
}

JPH_TwoBodyConstraint *JPH_SixDOFConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_SixDOFConstraint *object)
{
    return (JPH_TwoBodyConstraint *)(static_cast<JPH::TwoBodyConstraint *>(
        ((JPH::SixDOFConstraint *)object)
    ));
}

const JPH_SixDOFConstraint *JPH_SixDOFConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object)
{
    return (const JPH_SixDOFConstraint *)(static_cast<const JPH::SixDOFConstraint *>(
        ((const JPH::TwoBodyConstraint *)object)
    ));
}

JPH_SixDOFConstraint *JPH_SixDOFConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object)
{
    return (JPH_SixDOFConstraint *)(static_cast<JPH::SixDOFConstraint *>(
        ((JPH::TwoBodyConstraint *)object)
    ));
}

void JPH_SixDOFConstraint_Destroy(const JPH_SixDOFConstraint *_this)
{
    delete ((const JPH::SixDOFConstraint *)_this);
}

void JPH_SixDOFConstraint_DestroyArray(const JPH_SixDOFConstraint *_this)
{
    delete[] ((const JPH::SixDOFConstraint *)_this);
}

void *Jolt_new_JPH_SixDOFConstraint_size_t(size_t inCount)
{
    return JPH::SixDOFConstraint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SixDOFConstraint_void_ptr(void *inPointer)
{
    JPH::SixDOFConstraint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SixDOFConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SixDOFConstraint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SixDOFConstraint_size_t(size_t inCount)
{
    return JPH::SixDOFConstraint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SixDOFConstraint_void_ptr(void *inPointer)
{
    JPH::SixDOFConstraint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SixDOFConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SixDOFConstraint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SixDOFConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SixDOFConstraint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SixDOFConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SixDOFConstraint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SixDOFConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SixDOFConstraint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SixDOFConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SixDOFConstraint::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_SixDOFConstraint_NotifyShapeChanged(JPH_SixDOFConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).NotifyShapeChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inDeltaCOM ? void() : MRBINDC_THROW("Parameter `inDeltaCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaCOM))
    );
}

void JPH_SixDOFConstraint_SetupVelocityConstraint(JPH_SixDOFConstraint *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetupVelocityConstraint(
        inDeltaTime
    );
}

void JPH_SixDOFConstraint_ResetWarmStart(JPH_SixDOFConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).ResetWarmStart();
}

void JPH_SixDOFConstraint_WarmStartVelocityConstraint(JPH_SixDOFConstraint *_this, float inWarmStartImpulseRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).WarmStartVelocityConstraint(
        inWarmStartImpulseRatio
    );
}

bool JPH_SixDOFConstraint_SolveVelocityConstraint(JPH_SixDOFConstraint *_this, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SolveVelocityConstraint(
        inDeltaTime
    );
}

bool JPH_SixDOFConstraint_SolvePositionConstraint(JPH_SixDOFConstraint *_this, float inDeltaTime, float inBaumgarte)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SolvePositionConstraint(
        inDeltaTime,
        inBaumgarte
    );
}

void JPH_SixDOFConstraint_DrawConstraint(const JPH_SixDOFConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).DrawConstraint(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

void JPH_SixDOFConstraint_DrawConstraintLimits(const JPH_SixDOFConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).DrawConstraintLimits(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

JPH_Mat44 *JPH_SixDOFConstraint_GetConstraintToBody1Matrix(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetConstraintToBody1Matrix());
}

JPH_Mat44 *JPH_SixDOFConstraint_GetConstraintToBody2Matrix(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetConstraintToBody2Matrix());
}

void JPH_SixDOFConstraint_SetTranslationLimits(JPH_SixDOFConstraint *_this, const JPH_Vec3 *inLimitMin, const JPH_Vec3 *inLimitMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetTranslationLimits(
        ((inLimitMin ? void() : MRBINDC_THROW("Parameter `inLimitMin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLimitMin)),
        ((inLimitMax ? void() : MRBINDC_THROW("Parameter `inLimitMax` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLimitMax))
    );
}

void JPH_SixDOFConstraint_SetRotationLimits(JPH_SixDOFConstraint *_this, const JPH_Vec3 *inLimitMin, const JPH_Vec3 *inLimitMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetRotationLimits(
        ((inLimitMin ? void() : MRBINDC_THROW("Parameter `inLimitMin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLimitMin)),
        ((inLimitMax ? void() : MRBINDC_THROW("Parameter `inLimitMax` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLimitMax))
    );
}

float JPH_SixDOFConstraint_GetLimitsMin(const JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetLimitsMin(
        ((JPH::SixDOFConstraintSettings::EAxis)inAxis)
    );
}

float JPH_SixDOFConstraint_GetLimitsMax(const JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetLimitsMax(
        ((JPH::SixDOFConstraintSettings::EAxis)inAxis)
    );
}

JPH_Vec3 *JPH_SixDOFConstraint_GetTranslationLimitsMin(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetTranslationLimitsMin());
}

JPH_Vec3 *JPH_SixDOFConstraint_GetTranslationLimitsMax(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetTranslationLimitsMax());
}

JPH_Vec3 *JPH_SixDOFConstraint_GetRotationLimitsMin(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetRotationLimitsMin());
}

JPH_Vec3 *JPH_SixDOFConstraint_GetRotationLimitsMax(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetRotationLimitsMax());
}

bool JPH_SixDOFConstraint_IsFixedAxis(const JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).IsFixedAxis(
        ((JPH::SixDOFConstraintSettings::EAxis)inAxis)
    );
}

bool JPH_SixDOFConstraint_IsFreeAxis(const JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).IsFreeAxis(
        ((JPH::SixDOFConstraintSettings::EAxis)inAxis)
    );
}

void JPH_SixDOFConstraint_SetMaxFriction(JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis, float inFriction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetMaxFriction(
        ((JPH::SixDOFConstraintSettings::EAxis)inAxis),
        inFriction
    );
}

float JPH_SixDOFConstraint_GetMaxFriction(const JPH_SixDOFConstraint *_this, JPH_SixDOFConstraintSettings_EAxis inAxis)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetMaxFriction(
        ((JPH::SixDOFConstraintSettings::EAxis)inAxis)
    );
}

JPH_Quat *JPH_SixDOFConstraint_GetRotationInConstraintSpace(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetRotationInConstraintSpace());
}

JPH_Vec3 *JPH_SixDOFConstraint_GetTargetVelocityCS(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetTargetVelocityCS());
}

void JPH_SixDOFConstraint_SetTargetVelocityCS(JPH_SixDOFConstraint *_this, const JPH_Vec3 *inVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetTargetVelocityCS(
        ((inVelocity ? void() : MRBINDC_THROW("Parameter `inVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inVelocity))
    );
}

void JPH_SixDOFConstraint_SetTargetAngularVelocityCS(JPH_SixDOFConstraint *_this, const JPH_Vec3 *inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetTargetAngularVelocityCS(
        ((inAngularVelocity ? void() : MRBINDC_THROW("Parameter `inAngularVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocity))
    );
}

JPH_Vec3 *JPH_SixDOFConstraint_GetTargetAngularVelocityCS(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetTargetAngularVelocityCS());
}

JPH_Vec3 *JPH_SixDOFConstraint_GetTargetPositionCS(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetTargetPositionCS());
}

void JPH_SixDOFConstraint_SetTargetPositionCS(JPH_SixDOFConstraint *_this, const JPH_Vec3 *inPosition)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetTargetPositionCS(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition))
    );
}

void JPH_SixDOFConstraint_SetTargetOrientationCS(JPH_SixDOFConstraint *_this, const JPH_Quat *inOrientation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetTargetOrientationCS(
        ((inOrientation ? void() : MRBINDC_THROW("Parameter `inOrientation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inOrientation))
    );
}

JPH_Quat *JPH_SixDOFConstraint_GetTargetOrientationCS(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetTargetOrientationCS());
}

void JPH_SixDOFConstraint_SetTargetOrientationBS(JPH_SixDOFConstraint *_this, const JPH_Quat *inOrientation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetTargetOrientationBS(
        ((inOrientation ? void() : MRBINDC_THROW("Parameter `inOrientation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inOrientation))
    );
}

JPH_Vec3 *JPH_SixDOFConstraint_GetTotalLambdaPosition(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetTotalLambdaPosition());
}

JPH_Vec3 *JPH_SixDOFConstraint_GetTotalLambdaRotation(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetTotalLambdaRotation());
}

JPH_Vec3 *JPH_SixDOFConstraint_GetTotalLambdaMotorTranslation(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetTotalLambdaMotorTranslation());
}

JPH_Vec3 *JPH_SixDOFConstraint_GetTotalLambdaMotorRotation(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetTotalLambdaMotorRotation());
}

bool JPH_SixDOFConstraint_IsActive(const JPH_SixDOFConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).IsActive();
}

void JPH_SixDOFConstraint_DrawConstraintReferenceFrame(const JPH_SixDOFConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).DrawConstraintReferenceFrame(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

JPH_Body *JPH_SixDOFConstraint_GetBody1(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetBody1());
}

JPH_Body *JPH_SixDOFConstraint_GetBody2(const JPH_SixDOFConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetBody2());
}

unsigned int JPH_SixDOFConstraint_GetConstraintPriority(const JPH_SixDOFConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetConstraintPriority();
}

void JPH_SixDOFConstraint_SetConstraintPriority(JPH_SixDOFConstraint *_this, unsigned int inPriority)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetConstraintPriority(
        inPriority
    );
}

void JPH_SixDOFConstraint_SetNumVelocityStepsOverride(JPH_SixDOFConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_SixDOFConstraint_GetNumVelocityStepsOverride(const JPH_SixDOFConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_SixDOFConstraint_SetNumPositionStepsOverride(JPH_SixDOFConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_SixDOFConstraint_GetNumPositionStepsOverride(const JPH_SixDOFConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetNumPositionStepsOverride();
}

void JPH_SixDOFConstraint_SetEnabled(JPH_SixDOFConstraint *_this, bool inEnabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetEnabled(
        inEnabled
    );
}

bool JPH_SixDOFConstraint_GetEnabled(const JPH_SixDOFConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetEnabled();
}

uint64_t JPH_SixDOFConstraint_GetUserData(const JPH_SixDOFConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetUserData();
}

void JPH_SixDOFConstraint_SetUserData(JPH_SixDOFConstraint *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetUserData(
        inUserData
    );
}

float JPH_SixDOFConstraint_GetDrawConstraintSize(const JPH_SixDOFConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetDrawConstraintSize();
}

void JPH_SixDOFConstraint_SetDrawConstraintSize(JPH_SixDOFConstraint *_this, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SixDOFConstraint *)(_this)).SetDrawConstraintSize(
        inSize
    );
}

void JPH_SixDOFConstraint_SetEmbedded(const JPH_SixDOFConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).SetEmbedded();
}

unsigned int JPH_SixDOFConstraint_GetRefCount(const JPH_SixDOFConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).GetRefCount();
}

void JPH_SixDOFConstraint_AddRef(const JPH_SixDOFConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).AddRef();
}

void JPH_SixDOFConstraint_Release(const JPH_SixDOFConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SixDOFConstraint *)(_this)).Release();
}

int JPH_SixDOFConstraint_sInternalGetRefCountOffset(void)
{
    return JPH::SixDOFConstraint::sInternalGetRefCountOffset();
}

