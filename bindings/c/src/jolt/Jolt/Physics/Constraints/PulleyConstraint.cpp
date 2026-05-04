// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/PulleyConstraint.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/Constraints/PulleyConstraint.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_PulleyConstraintSettings_Get_mBodyPoint1(const JPH_PulleyConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).mBodyPoint1);
}

JPH_Vec3 *JPH_PulleyConstraintSettings_GetMutable_mBodyPoint1(JPH_PulleyConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mBodyPoint1);
}

const JPH_Vec3 *JPH_PulleyConstraintSettings_Get_mFixedPoint1(const JPH_PulleyConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).mFixedPoint1);
}

JPH_Vec3 *JPH_PulleyConstraintSettings_GetMutable_mFixedPoint1(JPH_PulleyConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mFixedPoint1);
}

const JPH_Vec3 *JPH_PulleyConstraintSettings_Get_mBodyPoint2(const JPH_PulleyConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).mBodyPoint2);
}

JPH_Vec3 *JPH_PulleyConstraintSettings_GetMutable_mBodyPoint2(JPH_PulleyConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mBodyPoint2);
}

const JPH_Vec3 *JPH_PulleyConstraintSettings_Get_mFixedPoint2(const JPH_PulleyConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).mFixedPoint2);
}

JPH_Vec3 *JPH_PulleyConstraintSettings_GetMutable_mFixedPoint2(JPH_PulleyConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mFixedPoint2);
}

const float *JPH_PulleyConstraintSettings_Get_mRatio(const JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).mRatio);
}

void JPH_PulleyConstraintSettings_Set_mRatio(JPH_PulleyConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mRatio = value;
}

float *JPH_PulleyConstraintSettings_GetMutable_mRatio(JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mRatio);
}

const float *JPH_PulleyConstraintSettings_Get_mMinLength(const JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).mMinLength);
}

void JPH_PulleyConstraintSettings_Set_mMinLength(JPH_PulleyConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mMinLength = value;
}

float *JPH_PulleyConstraintSettings_GetMutable_mMinLength(JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mMinLength);
}

const float *JPH_PulleyConstraintSettings_Get_mMaxLength(const JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).mMaxLength);
}

void JPH_PulleyConstraintSettings_Set_mMaxLength(JPH_PulleyConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mMaxLength = value;
}

float *JPH_PulleyConstraintSettings_GetMutable_mMaxLength(JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mMaxLength);
}

const bool *JPH_PulleyConstraintSettings_Get_mEnabled(const JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).mEnabled);
}

void JPH_PulleyConstraintSettings_Set_mEnabled(JPH_PulleyConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mEnabled = value;
}

bool *JPH_PulleyConstraintSettings_GetMutable_mEnabled(JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mEnabled);
}

const unsigned int *JPH_PulleyConstraintSettings_Get_mConstraintPriority(const JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).mConstraintPriority);
}

void JPH_PulleyConstraintSettings_Set_mConstraintPriority(JPH_PulleyConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mConstraintPriority = value;
}

unsigned int *JPH_PulleyConstraintSettings_GetMutable_mConstraintPriority(JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mConstraintPriority);
}

const unsigned int *JPH_PulleyConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_PulleyConstraintSettings_Set_mNumVelocityStepsOverride(JPH_PulleyConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_PulleyConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_PulleyConstraintSettings_Get_mNumPositionStepsOverride(const JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_PulleyConstraintSettings_Set_mNumPositionStepsOverride(JPH_PulleyConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_PulleyConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_PulleyConstraintSettings_Get_mDrawConstraintSize(const JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).mDrawConstraintSize);
}

void JPH_PulleyConstraintSettings_Set_mDrawConstraintSize(JPH_PulleyConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mDrawConstraintSize = value;
}

float *JPH_PulleyConstraintSettings_GetMutable_mDrawConstraintSize(JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mDrawConstraintSize);
}

const uint64_t *JPH_PulleyConstraintSettings_Get_mUserData(const JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).mUserData);
}

void JPH_PulleyConstraintSettings_Set_mUserData(JPH_PulleyConstraintSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_PulleyConstraintSettings_GetMutable_mUserData(JPH_PulleyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).mUserData);
}

JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::PulleyConstraintSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_PulleyConstraintSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_PulleyConstraintSettings *)(new JPH::PulleyConstraintSettings[num_elems]);
}

const JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_OffsetPtr(const JPH_PulleyConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_PulleyConstraintSettings *)(((const JPH::PulleyConstraintSettings *)ptr) + i);
}

JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_OffsetMutablePtr(JPH_PulleyConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_PulleyConstraintSettings *)(((JPH::PulleyConstraintSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_PulleyConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_PulleyConstraintSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::PulleyConstraintSettings *)object)
    ));
}

JPH_SerializableObject *JPH_PulleyConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_PulleyConstraintSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::PulleyConstraintSettings *)object)
    ));
}

const JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_PulleyConstraintSettings *)(static_cast<const JPH::PulleyConstraintSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_PulleyConstraintSettings *)(static_cast<JPH::PulleyConstraintSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_PulleyConstraintSettings *object)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<const JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((const JPH::PulleyConstraintSettings *)object)
    ));
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_PulleyConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_PulleyConstraintSettings *object)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((JPH::PulleyConstraintSettings *)object)
    ));
}

const JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (const JPH_PulleyConstraintSettings *)(static_cast<const JPH::PulleyConstraintSettings *>(
        ((const JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (JPH_PulleyConstraintSettings *)(static_cast<JPH::PulleyConstraintSettings *>(
        ((JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

const JPH_ConstraintSettings *JPH_PulleyConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_PulleyConstraintSettings *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::PulleyConstraintSettings *)object)
    ));
}

JPH_ConstraintSettings *JPH_PulleyConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_PulleyConstraintSettings *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::PulleyConstraintSettings *)object)
    ));
}

const JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object)
{
    return (const JPH_PulleyConstraintSettings *)(static_cast<const JPH::PulleyConstraintSettings *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object)
{
    return (JPH_PulleyConstraintSettings *)(static_cast<JPH::PulleyConstraintSettings *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

const JPH_TwoBodyConstraintSettings *JPH_PulleyConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_PulleyConstraintSettings *object)
{
    return (const JPH_TwoBodyConstraintSettings *)(static_cast<const JPH::TwoBodyConstraintSettings *>(
        ((const JPH::PulleyConstraintSettings *)object)
    ));
}

JPH_TwoBodyConstraintSettings *JPH_PulleyConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_PulleyConstraintSettings *object)
{
    return (JPH_TwoBodyConstraintSettings *)(static_cast<JPH::TwoBodyConstraintSettings *>(
        ((JPH::PulleyConstraintSettings *)object)
    ));
}

const JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object)
{
    return (const JPH_PulleyConstraintSettings *)(static_cast<const JPH::PulleyConstraintSettings *>(
        ((const JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object)
{
    return (JPH_PulleyConstraintSettings *)(static_cast<JPH::PulleyConstraintSettings *>(
        ((JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_PulleyConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::PulleyConstraintSettings);
    return (JPH_PulleyConstraintSettings *)new JPH::PulleyConstraintSettings(JPH::PulleyConstraintSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::PulleyConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::PulleyConstraintSettings), JPH::PulleyConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::PulleyConstraintSettings), JPH::PulleyConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::PulleyConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::PulleyConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::PulleyConstraintSettings))
    ));
}

void JPH_PulleyConstraintSettings_Destroy(const JPH_PulleyConstraintSettings *_this)
{
    delete ((const JPH::PulleyConstraintSettings *)_this);
}

void JPH_PulleyConstraintSettings_DestroyArray(const JPH_PulleyConstraintSettings *_this)
{
    delete[] ((const JPH::PulleyConstraintSettings *)_this);
}

JPH_PulleyConstraintSettings *JPH_PulleyConstraintSettings_AssignFromAnother(JPH_PulleyConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_PulleyConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::PulleyConstraintSettings);
    return (JPH_PulleyConstraintSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraintSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::PulleyConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::PulleyConstraintSettings), JPH::PulleyConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::PulleyConstraintSettings), JPH::PulleyConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::PulleyConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::PulleyConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::PulleyConstraintSettings))
    ));
}

void *Jolt_new_JPH_PulleyConstraintSettings_size_t(size_t inCount)
{
    return JPH::PulleyConstraintSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_PulleyConstraintSettings_void_ptr(void *inPointer)
{
    JPH::PulleyConstraintSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_PulleyConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PulleyConstraintSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_PulleyConstraintSettings_size_t(size_t inCount)
{
    return JPH::PulleyConstraintSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr(void *inPointer)
{
    JPH::PulleyConstraintSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PulleyConstraintSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_PulleyConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PulleyConstraintSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_PulleyConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PulleyConstraintSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_PulleyConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PulleyConstraintSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PulleyConstraintSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_TwoBodyConstraint *JPH_PulleyConstraintSettings_Create(const JPH_PulleyConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2)
{
    return (JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).Create(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2))
    ));
}

void JPH_PulleyConstraintSettings_SetEmbedded(const JPH_PulleyConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_PulleyConstraintSettings_GetRefCount(const JPH_PulleyConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).GetRefCount();
}

void JPH_PulleyConstraintSettings_AddRef(const JPH_PulleyConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).AddRef();
}

void JPH_PulleyConstraintSettings_Release(const JPH_PulleyConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(_this)).Release();
}

int JPH_PulleyConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::PulleyConstraintSettings::sInternalGetRefCountOffset();
}

JPH_PulleyConstraint *JPH_PulleyConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_PulleyConstraintSettings *inSettings)
{
    return (JPH_PulleyConstraint *)new JPH::PulleyConstraint(JPH::PulleyConstraint(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::PulleyConstraintSettings *)(inSettings))
    ));
}

const JPH_PulleyConstraint *JPH_PulleyConstraint_OffsetPtr(const JPH_PulleyConstraint *ptr, ptrdiff_t i)
{
    return (const JPH_PulleyConstraint *)(((const JPH::PulleyConstraint *)ptr) + i);
}

JPH_PulleyConstraint *JPH_PulleyConstraint_OffsetMutablePtr(JPH_PulleyConstraint *ptr, ptrdiff_t i)
{
    return (JPH_PulleyConstraint *)(((JPH::PulleyConstraint *)ptr) + i);
}

const JPH_RefTarget_JPH_Constraint *JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_PulleyConstraint *object)
{
    return (const JPH_RefTarget_JPH_Constraint *)(static_cast<const JPH::RefTarget<JPH::Constraint> *>(
        ((const JPH::PulleyConstraint *)object)
    ));
}

JPH_RefTarget_JPH_Constraint *JPH_PulleyConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_PulleyConstraint *object)
{
    return (JPH_RefTarget_JPH_Constraint *)(static_cast<JPH::RefTarget<JPH::Constraint> *>(
        ((JPH::PulleyConstraint *)object)
    ));
}

const JPH_PulleyConstraint *JPH_PulleyConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object)
{
    return (const JPH_PulleyConstraint *)(static_cast<const JPH::PulleyConstraint *>(
        ((const JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

JPH_PulleyConstraint *JPH_PulleyConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object)
{
    return (JPH_PulleyConstraint *)(static_cast<JPH::PulleyConstraint *>(
        ((JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

const JPH_NonCopyable *JPH_PulleyConstraint_UpcastTo_JPH_NonCopyable(const JPH_PulleyConstraint *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::PulleyConstraint *)object)
    ));
}

JPH_NonCopyable *JPH_PulleyConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_PulleyConstraint *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::PulleyConstraint *)object)
    ));
}

const JPH_PulleyConstraint *JPH_PulleyConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_PulleyConstraint *)(static_cast<const JPH::PulleyConstraint *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_PulleyConstraint *JPH_PulleyConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_PulleyConstraint *)(static_cast<JPH::PulleyConstraint *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Constraint *JPH_PulleyConstraint_UpcastTo_JPH_Constraint(const JPH_PulleyConstraint *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::PulleyConstraint *)object)
    ));
}

JPH_Constraint *JPH_PulleyConstraint_MutableUpcastTo_JPH_Constraint(JPH_PulleyConstraint *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::PulleyConstraint *)object)
    ));
}

const JPH_PulleyConstraint *JPH_PulleyConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object)
{
    return (const JPH_PulleyConstraint *)(static_cast<const JPH::PulleyConstraint *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_PulleyConstraint *JPH_PulleyConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object)
{
    return (JPH_PulleyConstraint *)(static_cast<JPH::PulleyConstraint *>(
        ((JPH::Constraint *)object)
    ));
}

const JPH_TwoBodyConstraint *JPH_PulleyConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_PulleyConstraint *object)
{
    return (const JPH_TwoBodyConstraint *)(static_cast<const JPH::TwoBodyConstraint *>(
        ((const JPH::PulleyConstraint *)object)
    ));
}

JPH_TwoBodyConstraint *JPH_PulleyConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_PulleyConstraint *object)
{
    return (JPH_TwoBodyConstraint *)(static_cast<JPH::TwoBodyConstraint *>(
        ((JPH::PulleyConstraint *)object)
    ));
}

const JPH_PulleyConstraint *JPH_PulleyConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object)
{
    return (const JPH_PulleyConstraint *)(static_cast<const JPH::PulleyConstraint *>(
        ((const JPH::TwoBodyConstraint *)object)
    ));
}

JPH_PulleyConstraint *JPH_PulleyConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object)
{
    return (JPH_PulleyConstraint *)(static_cast<JPH::PulleyConstraint *>(
        ((JPH::TwoBodyConstraint *)object)
    ));
}

void JPH_PulleyConstraint_Destroy(const JPH_PulleyConstraint *_this)
{
    delete ((const JPH::PulleyConstraint *)_this);
}

void JPH_PulleyConstraint_DestroyArray(const JPH_PulleyConstraint *_this)
{
    delete[] ((const JPH::PulleyConstraint *)_this);
}

void *Jolt_new_JPH_PulleyConstraint_size_t(size_t inCount)
{
    return JPH::PulleyConstraint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_PulleyConstraint_void_ptr(void *inPointer)
{
    JPH::PulleyConstraint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_PulleyConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PulleyConstraint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_PulleyConstraint_size_t(size_t inCount)
{
    return JPH::PulleyConstraint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_PulleyConstraint_void_ptr(void *inPointer)
{
    JPH::PulleyConstraint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_PulleyConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PulleyConstraint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_PulleyConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PulleyConstraint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_PulleyConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PulleyConstraint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_PulleyConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PulleyConstraint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_PulleyConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PulleyConstraint::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_PulleyConstraint_NotifyShapeChanged(JPH_PulleyConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraint *)(_this)).NotifyShapeChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inDeltaCOM ? void() : MRBINDC_THROW("Parameter `inDeltaCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaCOM))
    );
}

void JPH_PulleyConstraint_SetupVelocityConstraint(JPH_PulleyConstraint *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraint *)(_this)).SetupVelocityConstraint(
        inDeltaTime
    );
}

void JPH_PulleyConstraint_ResetWarmStart(JPH_PulleyConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraint *)(_this)).ResetWarmStart();
}

void JPH_PulleyConstraint_WarmStartVelocityConstraint(JPH_PulleyConstraint *_this, float inWarmStartImpulseRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraint *)(_this)).WarmStartVelocityConstraint(
        inWarmStartImpulseRatio
    );
}

bool JPH_PulleyConstraint_SolveVelocityConstraint(JPH_PulleyConstraint *_this, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraint *)(_this)).SolveVelocityConstraint(
        inDeltaTime
    );
}

bool JPH_PulleyConstraint_SolvePositionConstraint(JPH_PulleyConstraint *_this, float inDeltaTime, float inBaumgarte)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraint *)(_this)).SolvePositionConstraint(
        inDeltaTime,
        inBaumgarte
    );
}

void JPH_PulleyConstraint_DrawConstraint(const JPH_PulleyConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).DrawConstraint(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

JPH_Mat44 *JPH_PulleyConstraint_GetConstraintToBody1Matrix(const JPH_PulleyConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetConstraintToBody1Matrix());
}

JPH_Mat44 *JPH_PulleyConstraint_GetConstraintToBody2Matrix(const JPH_PulleyConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetConstraintToBody2Matrix());
}

void JPH_PulleyConstraint_SetLength(JPH_PulleyConstraint *_this, float inMinLength, float inMaxLength)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraint *)(_this)).SetLength(
        inMinLength,
        inMaxLength
    );
}

float JPH_PulleyConstraint_GetMinLength(const JPH_PulleyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetMinLength();
}

float JPH_PulleyConstraint_GetMaxLength(const JPH_PulleyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetMaxLength();
}

float JPH_PulleyConstraint_GetCurrentLength(const JPH_PulleyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetCurrentLength();
}

float JPH_PulleyConstraint_GetTotalLambdaPosition(const JPH_PulleyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetTotalLambdaPosition();
}

bool JPH_PulleyConstraint_IsActive(const JPH_PulleyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).IsActive();
}

void JPH_PulleyConstraint_DrawConstraintReferenceFrame(const JPH_PulleyConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).DrawConstraintReferenceFrame(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

JPH_Body *JPH_PulleyConstraint_GetBody1(const JPH_PulleyConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetBody1());
}

JPH_Body *JPH_PulleyConstraint_GetBody2(const JPH_PulleyConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetBody2());
}

unsigned int JPH_PulleyConstraint_GetConstraintPriority(const JPH_PulleyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetConstraintPriority();
}

void JPH_PulleyConstraint_SetConstraintPriority(JPH_PulleyConstraint *_this, unsigned int inPriority)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraint *)(_this)).SetConstraintPriority(
        inPriority
    );
}

void JPH_PulleyConstraint_SetNumVelocityStepsOverride(JPH_PulleyConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraint *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_PulleyConstraint_GetNumVelocityStepsOverride(const JPH_PulleyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_PulleyConstraint_SetNumPositionStepsOverride(JPH_PulleyConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraint *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_PulleyConstraint_GetNumPositionStepsOverride(const JPH_PulleyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetNumPositionStepsOverride();
}

void JPH_PulleyConstraint_SetEnabled(JPH_PulleyConstraint *_this, bool inEnabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraint *)(_this)).SetEnabled(
        inEnabled
    );
}

bool JPH_PulleyConstraint_GetEnabled(const JPH_PulleyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetEnabled();
}

uint64_t JPH_PulleyConstraint_GetUserData(const JPH_PulleyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetUserData();
}

void JPH_PulleyConstraint_SetUserData(JPH_PulleyConstraint *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraint *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_PulleyConstraint_DrawConstraintLimits(const JPH_PulleyConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).DrawConstraintLimits(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

float JPH_PulleyConstraint_GetDrawConstraintSize(const JPH_PulleyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetDrawConstraintSize();
}

void JPH_PulleyConstraint_SetDrawConstraintSize(JPH_PulleyConstraint *_this, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PulleyConstraint *)(_this)).SetDrawConstraintSize(
        inSize
    );
}

void JPH_PulleyConstraint_SetEmbedded(const JPH_PulleyConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).SetEmbedded();
}

unsigned int JPH_PulleyConstraint_GetRefCount(const JPH_PulleyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).GetRefCount();
}

void JPH_PulleyConstraint_AddRef(const JPH_PulleyConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).AddRef();
}

void JPH_PulleyConstraint_Release(const JPH_PulleyConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PulleyConstraint *)(_this)).Release();
}

int JPH_PulleyConstraint_sInternalGetRefCountOffset(void)
{
    return JPH::PulleyConstraint::sInternalGetRefCountOffset();
}

