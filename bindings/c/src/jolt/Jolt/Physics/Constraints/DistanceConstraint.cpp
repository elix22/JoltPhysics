// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/DistanceConstraint.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/Constraints/DistanceConstraint.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_DistanceConstraintSettings_Get_mPoint1(const JPH_DistanceConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).mPoint1);
}

JPH_Vec3 *JPH_DistanceConstraintSettings_GetMutable_mPoint1(JPH_DistanceConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mPoint1);
}

const JPH_Vec3 *JPH_DistanceConstraintSettings_Get_mPoint2(const JPH_DistanceConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).mPoint2);
}

JPH_Vec3 *JPH_DistanceConstraintSettings_GetMutable_mPoint2(JPH_DistanceConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mPoint2);
}

const float *JPH_DistanceConstraintSettings_Get_mMinDistance(const JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).mMinDistance);
}

void JPH_DistanceConstraintSettings_Set_mMinDistance(JPH_DistanceConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mMinDistance = value;
}

float *JPH_DistanceConstraintSettings_GetMutable_mMinDistance(JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mMinDistance);
}

const float *JPH_DistanceConstraintSettings_Get_mMaxDistance(const JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).mMaxDistance);
}

void JPH_DistanceConstraintSettings_Set_mMaxDistance(JPH_DistanceConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mMaxDistance = value;
}

float *JPH_DistanceConstraintSettings_GetMutable_mMaxDistance(JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mMaxDistance);
}

const bool *JPH_DistanceConstraintSettings_Get_mEnabled(const JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).mEnabled);
}

void JPH_DistanceConstraintSettings_Set_mEnabled(JPH_DistanceConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mEnabled = value;
}

bool *JPH_DistanceConstraintSettings_GetMutable_mEnabled(JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mEnabled);
}

const unsigned int *JPH_DistanceConstraintSettings_Get_mConstraintPriority(const JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).mConstraintPriority);
}

void JPH_DistanceConstraintSettings_Set_mConstraintPriority(JPH_DistanceConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mConstraintPriority = value;
}

unsigned int *JPH_DistanceConstraintSettings_GetMutable_mConstraintPriority(JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mConstraintPriority);
}

const unsigned int *JPH_DistanceConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_DistanceConstraintSettings_Set_mNumVelocityStepsOverride(JPH_DistanceConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_DistanceConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_DistanceConstraintSettings_Get_mNumPositionStepsOverride(const JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_DistanceConstraintSettings_Set_mNumPositionStepsOverride(JPH_DistanceConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_DistanceConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_DistanceConstraintSettings_Get_mDrawConstraintSize(const JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).mDrawConstraintSize);
}

void JPH_DistanceConstraintSettings_Set_mDrawConstraintSize(JPH_DistanceConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mDrawConstraintSize = value;
}

float *JPH_DistanceConstraintSettings_GetMutable_mDrawConstraintSize(JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mDrawConstraintSize);
}

const uint64_t *JPH_DistanceConstraintSettings_Get_mUserData(const JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).mUserData);
}

void JPH_DistanceConstraintSettings_Set_mUserData(JPH_DistanceConstraintSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_DistanceConstraintSettings_GetMutable_mUserData(JPH_DistanceConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).mUserData);
}

JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::DistanceConstraintSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_DistanceConstraintSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_DistanceConstraintSettings *)(new JPH::DistanceConstraintSettings[num_elems]{});
}

const JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_OffsetPtr(const JPH_DistanceConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_DistanceConstraintSettings *)(((const JPH::DistanceConstraintSettings *)ptr) + i);
}

JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_OffsetMutablePtr(JPH_DistanceConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_DistanceConstraintSettings *)(((JPH::DistanceConstraintSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_DistanceConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_DistanceConstraintSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::DistanceConstraintSettings *)object)
    ));
}

JPH_SerializableObject *JPH_DistanceConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_DistanceConstraintSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::DistanceConstraintSettings *)object)
    ));
}

const JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_DistanceConstraintSettings *)(static_cast<const JPH::DistanceConstraintSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_DistanceConstraintSettings *)(static_cast<JPH::DistanceConstraintSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_DistanceConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_DistanceConstraintSettings *object)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<const JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((const JPH::DistanceConstraintSettings *)object)
    ));
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_DistanceConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_DistanceConstraintSettings *object)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((JPH::DistanceConstraintSettings *)object)
    ));
}

const JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (const JPH_DistanceConstraintSettings *)(static_cast<const JPH::DistanceConstraintSettings *>(
        ((const JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (JPH_DistanceConstraintSettings *)(static_cast<JPH::DistanceConstraintSettings *>(
        ((JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

const JPH_ConstraintSettings *JPH_DistanceConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_DistanceConstraintSettings *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::DistanceConstraintSettings *)object)
    ));
}

JPH_ConstraintSettings *JPH_DistanceConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_DistanceConstraintSettings *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::DistanceConstraintSettings *)object)
    ));
}

const JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object)
{
    return (const JPH_DistanceConstraintSettings *)(static_cast<const JPH::DistanceConstraintSettings *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object)
{
    return (JPH_DistanceConstraintSettings *)(static_cast<JPH::DistanceConstraintSettings *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

const JPH_TwoBodyConstraintSettings *JPH_DistanceConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_DistanceConstraintSettings *object)
{
    return (const JPH_TwoBodyConstraintSettings *)(static_cast<const JPH::TwoBodyConstraintSettings *>(
        ((const JPH::DistanceConstraintSettings *)object)
    ));
}

JPH_TwoBodyConstraintSettings *JPH_DistanceConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_DistanceConstraintSettings *object)
{
    return (JPH_TwoBodyConstraintSettings *)(static_cast<JPH::TwoBodyConstraintSettings *>(
        ((JPH::DistanceConstraintSettings *)object)
    ));
}

const JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object)
{
    return (const JPH_DistanceConstraintSettings *)(static_cast<const JPH::DistanceConstraintSettings *>(
        ((const JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object)
{
    return (JPH_DistanceConstraintSettings *)(static_cast<JPH::DistanceConstraintSettings *>(
        ((JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_DistanceConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::DistanceConstraintSettings);
    return (JPH_DistanceConstraintSettings *)new JPH::DistanceConstraintSettings(JPH::DistanceConstraintSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::DistanceConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::DistanceConstraintSettings), JPH::DistanceConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::DistanceConstraintSettings), JPH::DistanceConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::DistanceConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::DistanceConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::DistanceConstraintSettings))
    ));
}

void JPH_DistanceConstraintSettings_Destroy(const JPH_DistanceConstraintSettings *_this)
{
    delete ((const JPH::DistanceConstraintSettings *)_this);
}

void JPH_DistanceConstraintSettings_DestroyArray(const JPH_DistanceConstraintSettings *_this)
{
    delete[] ((const JPH::DistanceConstraintSettings *)_this);
}

JPH_DistanceConstraintSettings *JPH_DistanceConstraintSettings_AssignFromAnother(JPH_DistanceConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_DistanceConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::DistanceConstraintSettings);
    return (JPH_DistanceConstraintSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraintSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::DistanceConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::DistanceConstraintSettings), JPH::DistanceConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::DistanceConstraintSettings), JPH::DistanceConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::DistanceConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::DistanceConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::DistanceConstraintSettings))
    ));
}

void *Jolt_new_JPH_DistanceConstraintSettings_size_t(size_t inCount)
{
    return JPH::DistanceConstraintSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_DistanceConstraintSettings_void_ptr(void *inPointer)
{
    JPH::DistanceConstraintSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_DistanceConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::DistanceConstraintSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_DistanceConstraintSettings_size_t(size_t inCount)
{
    return JPH::DistanceConstraintSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr(void *inPointer)
{
    JPH::DistanceConstraintSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::DistanceConstraintSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_DistanceConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::DistanceConstraintSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_DistanceConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DistanceConstraintSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_DistanceConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::DistanceConstraintSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DistanceConstraintSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_TwoBodyConstraint *JPH_DistanceConstraintSettings_Create(const JPH_DistanceConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2)
{
    return (JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).Create(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2))
    ));
}

void JPH_DistanceConstraintSettings_SetEmbedded(const JPH_DistanceConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_DistanceConstraintSettings_GetRefCount(const JPH_DistanceConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).GetRefCount();
}

void JPH_DistanceConstraintSettings_AddRef(const JPH_DistanceConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).AddRef();
}

void JPH_DistanceConstraintSettings_Release(const JPH_DistanceConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(_this)).Release();
}

int JPH_DistanceConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::DistanceConstraintSettings::sInternalGetRefCountOffset();
}

JPH_DistanceConstraint *JPH_DistanceConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_DistanceConstraintSettings *inSettings)
{
    return (JPH_DistanceConstraint *)new JPH::DistanceConstraint(JPH::DistanceConstraint(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::DistanceConstraintSettings *)(inSettings))
    ));
}

const JPH_DistanceConstraint *JPH_DistanceConstraint_OffsetPtr(const JPH_DistanceConstraint *ptr, ptrdiff_t i)
{
    return (const JPH_DistanceConstraint *)(((const JPH::DistanceConstraint *)ptr) + i);
}

JPH_DistanceConstraint *JPH_DistanceConstraint_OffsetMutablePtr(JPH_DistanceConstraint *ptr, ptrdiff_t i)
{
    return (JPH_DistanceConstraint *)(((JPH::DistanceConstraint *)ptr) + i);
}

const JPH_RefTarget_JPH_Constraint *JPH_DistanceConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_DistanceConstraint *object)
{
    return (const JPH_RefTarget_JPH_Constraint *)(static_cast<const JPH::RefTarget<JPH::Constraint> *>(
        ((const JPH::DistanceConstraint *)object)
    ));
}

JPH_RefTarget_JPH_Constraint *JPH_DistanceConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_DistanceConstraint *object)
{
    return (JPH_RefTarget_JPH_Constraint *)(static_cast<JPH::RefTarget<JPH::Constraint> *>(
        ((JPH::DistanceConstraint *)object)
    ));
}

const JPH_DistanceConstraint *JPH_DistanceConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object)
{
    return (const JPH_DistanceConstraint *)(static_cast<const JPH::DistanceConstraint *>(
        ((const JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

JPH_DistanceConstraint *JPH_DistanceConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object)
{
    return (JPH_DistanceConstraint *)(static_cast<JPH::DistanceConstraint *>(
        ((JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

const JPH_NonCopyable *JPH_DistanceConstraint_UpcastTo_JPH_NonCopyable(const JPH_DistanceConstraint *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::DistanceConstraint *)object)
    ));
}

JPH_NonCopyable *JPH_DistanceConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_DistanceConstraint *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::DistanceConstraint *)object)
    ));
}

const JPH_DistanceConstraint *JPH_DistanceConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_DistanceConstraint *)(static_cast<const JPH::DistanceConstraint *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_DistanceConstraint *JPH_DistanceConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_DistanceConstraint *)(static_cast<JPH::DistanceConstraint *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Constraint *JPH_DistanceConstraint_UpcastTo_JPH_Constraint(const JPH_DistanceConstraint *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::DistanceConstraint *)object)
    ));
}

JPH_Constraint *JPH_DistanceConstraint_MutableUpcastTo_JPH_Constraint(JPH_DistanceConstraint *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::DistanceConstraint *)object)
    ));
}

const JPH_DistanceConstraint *JPH_DistanceConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object)
{
    return (const JPH_DistanceConstraint *)(static_cast<const JPH::DistanceConstraint *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_DistanceConstraint *JPH_DistanceConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object)
{
    return (JPH_DistanceConstraint *)(static_cast<JPH::DistanceConstraint *>(
        ((JPH::Constraint *)object)
    ));
}

const JPH_TwoBodyConstraint *JPH_DistanceConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_DistanceConstraint *object)
{
    return (const JPH_TwoBodyConstraint *)(static_cast<const JPH::TwoBodyConstraint *>(
        ((const JPH::DistanceConstraint *)object)
    ));
}

JPH_TwoBodyConstraint *JPH_DistanceConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_DistanceConstraint *object)
{
    return (JPH_TwoBodyConstraint *)(static_cast<JPH::TwoBodyConstraint *>(
        ((JPH::DistanceConstraint *)object)
    ));
}

const JPH_DistanceConstraint *JPH_DistanceConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object)
{
    return (const JPH_DistanceConstraint *)(static_cast<const JPH::DistanceConstraint *>(
        ((const JPH::TwoBodyConstraint *)object)
    ));
}

JPH_DistanceConstraint *JPH_DistanceConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object)
{
    return (JPH_DistanceConstraint *)(static_cast<JPH::DistanceConstraint *>(
        ((JPH::TwoBodyConstraint *)object)
    ));
}

void JPH_DistanceConstraint_Destroy(const JPH_DistanceConstraint *_this)
{
    delete ((const JPH::DistanceConstraint *)_this);
}

void JPH_DistanceConstraint_DestroyArray(const JPH_DistanceConstraint *_this)
{
    delete[] ((const JPH::DistanceConstraint *)_this);
}

void *Jolt_new_JPH_DistanceConstraint_size_t(size_t inCount)
{
    return JPH::DistanceConstraint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_DistanceConstraint_void_ptr(void *inPointer)
{
    JPH::DistanceConstraint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_DistanceConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::DistanceConstraint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_DistanceConstraint_size_t(size_t inCount)
{
    return JPH::DistanceConstraint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_DistanceConstraint_void_ptr(void *inPointer)
{
    JPH::DistanceConstraint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_DistanceConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::DistanceConstraint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_DistanceConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::DistanceConstraint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_DistanceConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DistanceConstraint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_DistanceConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::DistanceConstraint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_DistanceConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::DistanceConstraint::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_DistanceConstraint_NotifyShapeChanged(JPH_DistanceConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraint *)(_this)).NotifyShapeChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inDeltaCOM ? void() : MRBINDC_THROW("Parameter `inDeltaCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaCOM))
    );
}

void JPH_DistanceConstraint_SetupVelocityConstraint(JPH_DistanceConstraint *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraint *)(_this)).SetupVelocityConstraint(
        inDeltaTime
    );
}

void JPH_DistanceConstraint_ResetWarmStart(JPH_DistanceConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraint *)(_this)).ResetWarmStart();
}

void JPH_DistanceConstraint_WarmStartVelocityConstraint(JPH_DistanceConstraint *_this, float inWarmStartImpulseRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraint *)(_this)).WarmStartVelocityConstraint(
        inWarmStartImpulseRatio
    );
}

bool JPH_DistanceConstraint_SolveVelocityConstraint(JPH_DistanceConstraint *_this, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraint *)(_this)).SolveVelocityConstraint(
        inDeltaTime
    );
}

bool JPH_DistanceConstraint_SolvePositionConstraint(JPH_DistanceConstraint *_this, float inDeltaTime, float inBaumgarte)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraint *)(_this)).SolvePositionConstraint(
        inDeltaTime,
        inBaumgarte
    );
}

JPH_Mat44 *JPH_DistanceConstraint_GetConstraintToBody1Matrix(const JPH_DistanceConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).GetConstraintToBody1Matrix());
}

JPH_Mat44 *JPH_DistanceConstraint_GetConstraintToBody2Matrix(const JPH_DistanceConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).GetConstraintToBody2Matrix());
}

void JPH_DistanceConstraint_SetDistance(JPH_DistanceConstraint *_this, float inMinDistance, float inMaxDistance)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraint *)(_this)).SetDistance(
        inMinDistance,
        inMaxDistance
    );
}

float JPH_DistanceConstraint_GetMinDistance(const JPH_DistanceConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).GetMinDistance();
}

float JPH_DistanceConstraint_GetMaxDistance(const JPH_DistanceConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).GetMaxDistance();
}

float JPH_DistanceConstraint_GetTotalLambdaPosition(const JPH_DistanceConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).GetTotalLambdaPosition();
}

bool JPH_DistanceConstraint_IsActive(const JPH_DistanceConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).IsActive();
}

JPH_Body *JPH_DistanceConstraint_GetBody1(const JPH_DistanceConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).GetBody1());
}

JPH_Body *JPH_DistanceConstraint_GetBody2(const JPH_DistanceConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).GetBody2());
}

unsigned int JPH_DistanceConstraint_GetConstraintPriority(const JPH_DistanceConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).GetConstraintPriority();
}

void JPH_DistanceConstraint_SetConstraintPriority(JPH_DistanceConstraint *_this, unsigned int inPriority)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraint *)(_this)).SetConstraintPriority(
        inPriority
    );
}

void JPH_DistanceConstraint_SetNumVelocityStepsOverride(JPH_DistanceConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraint *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_DistanceConstraint_GetNumVelocityStepsOverride(const JPH_DistanceConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_DistanceConstraint_SetNumPositionStepsOverride(JPH_DistanceConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraint *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_DistanceConstraint_GetNumPositionStepsOverride(const JPH_DistanceConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).GetNumPositionStepsOverride();
}

void JPH_DistanceConstraint_SetEnabled(JPH_DistanceConstraint *_this, bool inEnabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraint *)(_this)).SetEnabled(
        inEnabled
    );
}

bool JPH_DistanceConstraint_GetEnabled(const JPH_DistanceConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).GetEnabled();
}

uint64_t JPH_DistanceConstraint_GetUserData(const JPH_DistanceConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).GetUserData();
}

void JPH_DistanceConstraint_SetUserData(JPH_DistanceConstraint *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::DistanceConstraint *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_DistanceConstraint_SetEmbedded(const JPH_DistanceConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).SetEmbedded();
}

unsigned int JPH_DistanceConstraint_GetRefCount(const JPH_DistanceConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).GetRefCount();
}

void JPH_DistanceConstraint_AddRef(const JPH_DistanceConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).AddRef();
}

void JPH_DistanceConstraint_Release(const JPH_DistanceConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::DistanceConstraint *)(_this)).Release();
}

int JPH_DistanceConstraint_sInternalGetRefCountOffset(void)
{
    return JPH::DistanceConstraint::sInternalGetRefCountOffset();
}

