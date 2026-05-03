// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/ConeConstraint.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Constraints/ConeConstraint.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_ConeConstraintSettings_Get_mPoint1(const JPH_ConeConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).mPoint1);
}

JPH_Vec3 *JPH_ConeConstraintSettings_GetMutable_mPoint1(JPH_ConeConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mPoint1);
}

const JPH_Vec3 *JPH_ConeConstraintSettings_Get_mTwistAxis1(const JPH_ConeConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).mTwistAxis1);
}

JPH_Vec3 *JPH_ConeConstraintSettings_GetMutable_mTwistAxis1(JPH_ConeConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mTwistAxis1);
}

const JPH_Vec3 *JPH_ConeConstraintSettings_Get_mPoint2(const JPH_ConeConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).mPoint2);
}

JPH_Vec3 *JPH_ConeConstraintSettings_GetMutable_mPoint2(JPH_ConeConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mPoint2);
}

const JPH_Vec3 *JPH_ConeConstraintSettings_Get_mTwistAxis2(const JPH_ConeConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).mTwistAxis2);
}

JPH_Vec3 *JPH_ConeConstraintSettings_GetMutable_mTwistAxis2(JPH_ConeConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mTwistAxis2);
}

const float *JPH_ConeConstraintSettings_Get_mHalfConeAngle(const JPH_ConeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).mHalfConeAngle);
}

void JPH_ConeConstraintSettings_Set_mHalfConeAngle(JPH_ConeConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mHalfConeAngle = value;
}

float *JPH_ConeConstraintSettings_GetMutable_mHalfConeAngle(JPH_ConeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mHalfConeAngle);
}

const bool *JPH_ConeConstraintSettings_Get_mEnabled(const JPH_ConeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).mEnabled);
}

void JPH_ConeConstraintSettings_Set_mEnabled(JPH_ConeConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mEnabled = value;
}

bool *JPH_ConeConstraintSettings_GetMutable_mEnabled(JPH_ConeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mEnabled);
}

const unsigned int *JPH_ConeConstraintSettings_Get_mConstraintPriority(const JPH_ConeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).mConstraintPriority);
}

void JPH_ConeConstraintSettings_Set_mConstraintPriority(JPH_ConeConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mConstraintPriority = value;
}

unsigned int *JPH_ConeConstraintSettings_GetMutable_mConstraintPriority(JPH_ConeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mConstraintPriority);
}

const unsigned int *JPH_ConeConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_ConeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_ConeConstraintSettings_Set_mNumVelocityStepsOverride(JPH_ConeConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_ConeConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_ConeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_ConeConstraintSettings_Get_mNumPositionStepsOverride(const JPH_ConeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_ConeConstraintSettings_Set_mNumPositionStepsOverride(JPH_ConeConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_ConeConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_ConeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_ConeConstraintSettings_Get_mDrawConstraintSize(const JPH_ConeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).mDrawConstraintSize);
}

void JPH_ConeConstraintSettings_Set_mDrawConstraintSize(JPH_ConeConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mDrawConstraintSize = value;
}

float *JPH_ConeConstraintSettings_GetMutable_mDrawConstraintSize(JPH_ConeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mDrawConstraintSize);
}

const uint64_t *JPH_ConeConstraintSettings_Get_mUserData(const JPH_ConeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).mUserData);
}

void JPH_ConeConstraintSettings_Set_mUserData(JPH_ConeConstraintSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_ConeConstraintSettings_GetMutable_mUserData(JPH_ConeConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).mUserData);
}

JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::ConeConstraintSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_ConeConstraintSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ConeConstraintSettings *)(new JPH::ConeConstraintSettings[num_elems]{});
}

const JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_OffsetPtr(const JPH_ConeConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_ConeConstraintSettings *)(((const JPH::ConeConstraintSettings *)ptr) + i);
}

JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_OffsetMutablePtr(JPH_ConeConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_ConeConstraintSettings *)(((JPH::ConeConstraintSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_ConeConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_ConeConstraintSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::ConeConstraintSettings *)object)
    ));
}

JPH_SerializableObject *JPH_ConeConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_ConeConstraintSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::ConeConstraintSettings *)object)
    ));
}

const JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_ConeConstraintSettings *)(static_cast<const JPH::ConeConstraintSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_ConeConstraintSettings *)(static_cast<JPH::ConeConstraintSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_ConeConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_ConeConstraintSettings *object)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<const JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((const JPH::ConeConstraintSettings *)object)
    ));
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_ConeConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_ConeConstraintSettings *object)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((JPH::ConeConstraintSettings *)object)
    ));
}

const JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (const JPH_ConeConstraintSettings *)(static_cast<const JPH::ConeConstraintSettings *>(
        ((const JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (JPH_ConeConstraintSettings *)(static_cast<JPH::ConeConstraintSettings *>(
        ((JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

const JPH_ConstraintSettings *JPH_ConeConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_ConeConstraintSettings *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::ConeConstraintSettings *)object)
    ));
}

JPH_ConstraintSettings *JPH_ConeConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_ConeConstraintSettings *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::ConeConstraintSettings *)object)
    ));
}

const JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object)
{
    return (const JPH_ConeConstraintSettings *)(static_cast<const JPH::ConeConstraintSettings *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object)
{
    return (JPH_ConeConstraintSettings *)(static_cast<JPH::ConeConstraintSettings *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

const JPH_TwoBodyConstraintSettings *JPH_ConeConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_ConeConstraintSettings *object)
{
    return (const JPH_TwoBodyConstraintSettings *)(static_cast<const JPH::TwoBodyConstraintSettings *>(
        ((const JPH::ConeConstraintSettings *)object)
    ));
}

JPH_TwoBodyConstraintSettings *JPH_ConeConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_ConeConstraintSettings *object)
{
    return (JPH_TwoBodyConstraintSettings *)(static_cast<JPH::TwoBodyConstraintSettings *>(
        ((JPH::ConeConstraintSettings *)object)
    ));
}

const JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object)
{
    return (const JPH_ConeConstraintSettings *)(static_cast<const JPH::ConeConstraintSettings *>(
        ((const JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object)
{
    return (JPH_ConeConstraintSettings *)(static_cast<JPH::ConeConstraintSettings *>(
        ((JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_ConeConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::ConeConstraintSettings);
    return (JPH_ConeConstraintSettings *)new JPH::ConeConstraintSettings(JPH::ConeConstraintSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::ConeConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::ConeConstraintSettings), JPH::ConeConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::ConeConstraintSettings), JPH::ConeConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::ConeConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::ConeConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::ConeConstraintSettings))
    ));
}

void JPH_ConeConstraintSettings_Destroy(const JPH_ConeConstraintSettings *_this)
{
    delete ((const JPH::ConeConstraintSettings *)_this);
}

void JPH_ConeConstraintSettings_DestroyArray(const JPH_ConeConstraintSettings *_this)
{
    delete[] ((const JPH::ConeConstraintSettings *)_this);
}

JPH_ConeConstraintSettings *JPH_ConeConstraintSettings_AssignFromAnother(JPH_ConeConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_ConeConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::ConeConstraintSettings);
    return (JPH_ConeConstraintSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraintSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::ConeConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::ConeConstraintSettings), JPH::ConeConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::ConeConstraintSettings), JPH::ConeConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::ConeConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::ConeConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::ConeConstraintSettings))
    ));
}

void *Jolt_new_JPH_ConeConstraintSettings_size_t(size_t inCount)
{
    return JPH::ConeConstraintSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ConeConstraintSettings_void_ptr(void *inPointer)
{
    JPH::ConeConstraintSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ConeConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ConeConstraintSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ConeConstraintSettings_size_t(size_t inCount)
{
    return JPH::ConeConstraintSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ConeConstraintSettings_void_ptr(void *inPointer)
{
    JPH::ConeConstraintSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ConeConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ConeConstraintSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ConeConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ConeConstraintSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ConeConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ConeConstraintSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ConeConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ConeConstraintSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ConeConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ConeConstraintSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_TwoBodyConstraint *JPH_ConeConstraintSettings_Create(const JPH_ConeConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2)
{
    return (JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).Create(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2))
    ));
}

void JPH_ConeConstraintSettings_SetEmbedded(const JPH_ConeConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_ConeConstraintSettings_GetRefCount(const JPH_ConeConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).GetRefCount();
}

void JPH_ConeConstraintSettings_AddRef(const JPH_ConeConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).AddRef();
}

void JPH_ConeConstraintSettings_Release(const JPH_ConeConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(_this)).Release();
}

int JPH_ConeConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::ConeConstraintSettings::sInternalGetRefCountOffset();
}

JPH_ConeConstraint *JPH_ConeConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_ConeConstraintSettings *inSettings)
{
    return (JPH_ConeConstraint *)new JPH::ConeConstraint(JPH::ConeConstraint(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::ConeConstraintSettings *)(inSettings))
    ));
}

const JPH_ConeConstraint *JPH_ConeConstraint_OffsetPtr(const JPH_ConeConstraint *ptr, ptrdiff_t i)
{
    return (const JPH_ConeConstraint *)(((const JPH::ConeConstraint *)ptr) + i);
}

JPH_ConeConstraint *JPH_ConeConstraint_OffsetMutablePtr(JPH_ConeConstraint *ptr, ptrdiff_t i)
{
    return (JPH_ConeConstraint *)(((JPH::ConeConstraint *)ptr) + i);
}

const JPH_RefTarget_JPH_Constraint *JPH_ConeConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_ConeConstraint *object)
{
    return (const JPH_RefTarget_JPH_Constraint *)(static_cast<const JPH::RefTarget<JPH::Constraint> *>(
        ((const JPH::ConeConstraint *)object)
    ));
}

JPH_RefTarget_JPH_Constraint *JPH_ConeConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_ConeConstraint *object)
{
    return (JPH_RefTarget_JPH_Constraint *)(static_cast<JPH::RefTarget<JPH::Constraint> *>(
        ((JPH::ConeConstraint *)object)
    ));
}

const JPH_ConeConstraint *JPH_ConeConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object)
{
    return (const JPH_ConeConstraint *)(static_cast<const JPH::ConeConstraint *>(
        ((const JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

JPH_ConeConstraint *JPH_ConeConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object)
{
    return (JPH_ConeConstraint *)(static_cast<JPH::ConeConstraint *>(
        ((JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

const JPH_NonCopyable *JPH_ConeConstraint_UpcastTo_JPH_NonCopyable(const JPH_ConeConstraint *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::ConeConstraint *)object)
    ));
}

JPH_NonCopyable *JPH_ConeConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_ConeConstraint *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::ConeConstraint *)object)
    ));
}

const JPH_ConeConstraint *JPH_ConeConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_ConeConstraint *)(static_cast<const JPH::ConeConstraint *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_ConeConstraint *JPH_ConeConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_ConeConstraint *)(static_cast<JPH::ConeConstraint *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Constraint *JPH_ConeConstraint_UpcastTo_JPH_Constraint(const JPH_ConeConstraint *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::ConeConstraint *)object)
    ));
}

JPH_Constraint *JPH_ConeConstraint_MutableUpcastTo_JPH_Constraint(JPH_ConeConstraint *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::ConeConstraint *)object)
    ));
}

const JPH_ConeConstraint *JPH_ConeConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object)
{
    return (const JPH_ConeConstraint *)(static_cast<const JPH::ConeConstraint *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_ConeConstraint *JPH_ConeConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object)
{
    return (JPH_ConeConstraint *)(static_cast<JPH::ConeConstraint *>(
        ((JPH::Constraint *)object)
    ));
}

const JPH_TwoBodyConstraint *JPH_ConeConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_ConeConstraint *object)
{
    return (const JPH_TwoBodyConstraint *)(static_cast<const JPH::TwoBodyConstraint *>(
        ((const JPH::ConeConstraint *)object)
    ));
}

JPH_TwoBodyConstraint *JPH_ConeConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_ConeConstraint *object)
{
    return (JPH_TwoBodyConstraint *)(static_cast<JPH::TwoBodyConstraint *>(
        ((JPH::ConeConstraint *)object)
    ));
}

const JPH_ConeConstraint *JPH_ConeConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object)
{
    return (const JPH_ConeConstraint *)(static_cast<const JPH::ConeConstraint *>(
        ((const JPH::TwoBodyConstraint *)object)
    ));
}

JPH_ConeConstraint *JPH_ConeConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object)
{
    return (JPH_ConeConstraint *)(static_cast<JPH::ConeConstraint *>(
        ((JPH::TwoBodyConstraint *)object)
    ));
}

void JPH_ConeConstraint_Destroy(const JPH_ConeConstraint *_this)
{
    delete ((const JPH::ConeConstraint *)_this);
}

void JPH_ConeConstraint_DestroyArray(const JPH_ConeConstraint *_this)
{
    delete[] ((const JPH::ConeConstraint *)_this);
}

void *Jolt_new_JPH_ConeConstraint_size_t(size_t inCount)
{
    return JPH::ConeConstraint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ConeConstraint_void_ptr(void *inPointer)
{
    JPH::ConeConstraint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ConeConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ConeConstraint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ConeConstraint_size_t(size_t inCount)
{
    return JPH::ConeConstraint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ConeConstraint_void_ptr(void *inPointer)
{
    JPH::ConeConstraint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ConeConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ConeConstraint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ConeConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ConeConstraint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ConeConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ConeConstraint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ConeConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ConeConstraint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ConeConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ConeConstraint::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_ConeConstraint_NotifyShapeChanged(JPH_ConeConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraint *)(_this)).NotifyShapeChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inDeltaCOM ? void() : MRBINDC_THROW("Parameter `inDeltaCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaCOM))
    );
}

void JPH_ConeConstraint_SetupVelocityConstraint(JPH_ConeConstraint *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraint *)(_this)).SetupVelocityConstraint(
        inDeltaTime
    );
}

void JPH_ConeConstraint_ResetWarmStart(JPH_ConeConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraint *)(_this)).ResetWarmStart();
}

void JPH_ConeConstraint_WarmStartVelocityConstraint(JPH_ConeConstraint *_this, float inWarmStartImpulseRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraint *)(_this)).WarmStartVelocityConstraint(
        inWarmStartImpulseRatio
    );
}

bool JPH_ConeConstraint_SolveVelocityConstraint(JPH_ConeConstraint *_this, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraint *)(_this)).SolveVelocityConstraint(
        inDeltaTime
    );
}

bool JPH_ConeConstraint_SolvePositionConstraint(JPH_ConeConstraint *_this, float inDeltaTime, float inBaumgarte)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraint *)(_this)).SolvePositionConstraint(
        inDeltaTime,
        inBaumgarte
    );
}

void JPH_ConeConstraint_DrawConstraint(const JPH_ConeConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).DrawConstraint(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

void JPH_ConeConstraint_DrawConstraintLimits(const JPH_ConeConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).DrawConstraintLimits(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

JPH_Mat44 *JPH_ConeConstraint_GetConstraintToBody1Matrix(const JPH_ConeConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).GetConstraintToBody1Matrix());
}

JPH_Mat44 *JPH_ConeConstraint_GetConstraintToBody2Matrix(const JPH_ConeConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).GetConstraintToBody2Matrix());
}

void JPH_ConeConstraint_SetHalfConeAngle(JPH_ConeConstraint *_this, float inHalfConeAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraint *)(_this)).SetHalfConeAngle(
        inHalfConeAngle
    );
}

float JPH_ConeConstraint_GetCosHalfConeAngle(const JPH_ConeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).GetCosHalfConeAngle();
}

JPH_Vec3 *JPH_ConeConstraint_GetTotalLambdaPosition(const JPH_ConeConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).GetTotalLambdaPosition());
}

float JPH_ConeConstraint_GetTotalLambdaRotation(const JPH_ConeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).GetTotalLambdaRotation();
}

bool JPH_ConeConstraint_IsActive(const JPH_ConeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).IsActive();
}

void JPH_ConeConstraint_DrawConstraintReferenceFrame(const JPH_ConeConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).DrawConstraintReferenceFrame(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

JPH_Body *JPH_ConeConstraint_GetBody1(const JPH_ConeConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).GetBody1());
}

JPH_Body *JPH_ConeConstraint_GetBody2(const JPH_ConeConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).GetBody2());
}

unsigned int JPH_ConeConstraint_GetConstraintPriority(const JPH_ConeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).GetConstraintPriority();
}

void JPH_ConeConstraint_SetConstraintPriority(JPH_ConeConstraint *_this, unsigned int inPriority)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraint *)(_this)).SetConstraintPriority(
        inPriority
    );
}

void JPH_ConeConstraint_SetNumVelocityStepsOverride(JPH_ConeConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraint *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_ConeConstraint_GetNumVelocityStepsOverride(const JPH_ConeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_ConeConstraint_SetNumPositionStepsOverride(JPH_ConeConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraint *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_ConeConstraint_GetNumPositionStepsOverride(const JPH_ConeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).GetNumPositionStepsOverride();
}

void JPH_ConeConstraint_SetEnabled(JPH_ConeConstraint *_this, bool inEnabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraint *)(_this)).SetEnabled(
        inEnabled
    );
}

bool JPH_ConeConstraint_GetEnabled(const JPH_ConeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).GetEnabled();
}

uint64_t JPH_ConeConstraint_GetUserData(const JPH_ConeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).GetUserData();
}

void JPH_ConeConstraint_SetUserData(JPH_ConeConstraint *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraint *)(_this)).SetUserData(
        inUserData
    );
}

float JPH_ConeConstraint_GetDrawConstraintSize(const JPH_ConeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).GetDrawConstraintSize();
}

void JPH_ConeConstraint_SetDrawConstraintSize(JPH_ConeConstraint *_this, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConeConstraint *)(_this)).SetDrawConstraintSize(
        inSize
    );
}

void JPH_ConeConstraint_SetEmbedded(const JPH_ConeConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).SetEmbedded();
}

unsigned int JPH_ConeConstraint_GetRefCount(const JPH_ConeConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).GetRefCount();
}

void JPH_ConeConstraint_AddRef(const JPH_ConeConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).AddRef();
}

void JPH_ConeConstraint_Release(const JPH_ConeConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConeConstraint *)(_this)).Release();
}

int JPH_ConeConstraint_sInternalGetRefCountOffset(void)
{
    return JPH::ConeConstraint::sInternalGetRefCountOffset();
}

