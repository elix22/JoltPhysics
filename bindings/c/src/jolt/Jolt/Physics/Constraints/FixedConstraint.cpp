// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/FixedConstraint.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/Constraints/FixedConstraint.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const bool *JPH_FixedConstraintSettings_Get_mAutoDetectPoint(const JPH_FixedConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).mAutoDetectPoint);
}

void JPH_FixedConstraintSettings_Set_mAutoDetectPoint(JPH_FixedConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mAutoDetectPoint = value;
}

bool *JPH_FixedConstraintSettings_GetMutable_mAutoDetectPoint(JPH_FixedConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mAutoDetectPoint);
}

const JPH_Vec3 *JPH_FixedConstraintSettings_Get_mPoint1(const JPH_FixedConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).mPoint1);
}

JPH_Vec3 *JPH_FixedConstraintSettings_GetMutable_mPoint1(JPH_FixedConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mPoint1);
}

const JPH_Vec3 *JPH_FixedConstraintSettings_Get_mAxisX1(const JPH_FixedConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).mAxisX1);
}

JPH_Vec3 *JPH_FixedConstraintSettings_GetMutable_mAxisX1(JPH_FixedConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mAxisX1);
}

const JPH_Vec3 *JPH_FixedConstraintSettings_Get_mAxisY1(const JPH_FixedConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).mAxisY1);
}

JPH_Vec3 *JPH_FixedConstraintSettings_GetMutable_mAxisY1(JPH_FixedConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mAxisY1);
}

const JPH_Vec3 *JPH_FixedConstraintSettings_Get_mPoint2(const JPH_FixedConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).mPoint2);
}

JPH_Vec3 *JPH_FixedConstraintSettings_GetMutable_mPoint2(JPH_FixedConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mPoint2);
}

const JPH_Vec3 *JPH_FixedConstraintSettings_Get_mAxisX2(const JPH_FixedConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).mAxisX2);
}

JPH_Vec3 *JPH_FixedConstraintSettings_GetMutable_mAxisX2(JPH_FixedConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mAxisX2);
}

const JPH_Vec3 *JPH_FixedConstraintSettings_Get_mAxisY2(const JPH_FixedConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).mAxisY2);
}

JPH_Vec3 *JPH_FixedConstraintSettings_GetMutable_mAxisY2(JPH_FixedConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mAxisY2);
}

const bool *JPH_FixedConstraintSettings_Get_mEnabled(const JPH_FixedConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).mEnabled);
}

void JPH_FixedConstraintSettings_Set_mEnabled(JPH_FixedConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mEnabled = value;
}

bool *JPH_FixedConstraintSettings_GetMutable_mEnabled(JPH_FixedConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mEnabled);
}

const unsigned int *JPH_FixedConstraintSettings_Get_mConstraintPriority(const JPH_FixedConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).mConstraintPriority);
}

void JPH_FixedConstraintSettings_Set_mConstraintPriority(JPH_FixedConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mConstraintPriority = value;
}

unsigned int *JPH_FixedConstraintSettings_GetMutable_mConstraintPriority(JPH_FixedConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mConstraintPriority);
}

const unsigned int *JPH_FixedConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_FixedConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_FixedConstraintSettings_Set_mNumVelocityStepsOverride(JPH_FixedConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_FixedConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_FixedConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_FixedConstraintSettings_Get_mNumPositionStepsOverride(const JPH_FixedConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_FixedConstraintSettings_Set_mNumPositionStepsOverride(JPH_FixedConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_FixedConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_FixedConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_FixedConstraintSettings_Get_mDrawConstraintSize(const JPH_FixedConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).mDrawConstraintSize);
}

void JPH_FixedConstraintSettings_Set_mDrawConstraintSize(JPH_FixedConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mDrawConstraintSize = value;
}

float *JPH_FixedConstraintSettings_GetMutable_mDrawConstraintSize(JPH_FixedConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mDrawConstraintSize);
}

const uint64_t *JPH_FixedConstraintSettings_Get_mUserData(const JPH_FixedConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).mUserData);
}

void JPH_FixedConstraintSettings_Set_mUserData(JPH_FixedConstraintSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_FixedConstraintSettings_GetMutable_mUserData(JPH_FixedConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).mUserData);
}

JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_DefaultConstruct(void)
{
    return (JPH_FixedConstraintSettings *)new JPH::FixedConstraintSettings(JPH::FixedConstraintSettings());
}

JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_FixedConstraintSettings *)(new JPH::FixedConstraintSettings[num_elems]{});
}

const JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_OffsetPtr(const JPH_FixedConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_FixedConstraintSettings *)(((const JPH::FixedConstraintSettings *)ptr) + i);
}

JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_OffsetMutablePtr(JPH_FixedConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_FixedConstraintSettings *)(((JPH::FixedConstraintSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_FixedConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_FixedConstraintSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::FixedConstraintSettings *)object)
    ));
}

JPH_SerializableObject *JPH_FixedConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_FixedConstraintSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::FixedConstraintSettings *)object)
    ));
}

const JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_FixedConstraintSettings *)(static_cast<const JPH::FixedConstraintSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_FixedConstraintSettings *)(static_cast<JPH::FixedConstraintSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_FixedConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_FixedConstraintSettings *object)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<const JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((const JPH::FixedConstraintSettings *)object)
    ));
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_FixedConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_FixedConstraintSettings *object)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((JPH::FixedConstraintSettings *)object)
    ));
}

const JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (const JPH_FixedConstraintSettings *)(static_cast<const JPH::FixedConstraintSettings *>(
        ((const JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (JPH_FixedConstraintSettings *)(static_cast<JPH::FixedConstraintSettings *>(
        ((JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

const JPH_ConstraintSettings *JPH_FixedConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_FixedConstraintSettings *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::FixedConstraintSettings *)object)
    ));
}

JPH_ConstraintSettings *JPH_FixedConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_FixedConstraintSettings *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::FixedConstraintSettings *)object)
    ));
}

const JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object)
{
    return (const JPH_FixedConstraintSettings *)(static_cast<const JPH::FixedConstraintSettings *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object)
{
    return (JPH_FixedConstraintSettings *)(static_cast<JPH::FixedConstraintSettings *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

const JPH_TwoBodyConstraintSettings *JPH_FixedConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_FixedConstraintSettings *object)
{
    return (const JPH_TwoBodyConstraintSettings *)(static_cast<const JPH::TwoBodyConstraintSettings *>(
        ((const JPH::FixedConstraintSettings *)object)
    ));
}

JPH_TwoBodyConstraintSettings *JPH_FixedConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_FixedConstraintSettings *object)
{
    return (JPH_TwoBodyConstraintSettings *)(static_cast<JPH::TwoBodyConstraintSettings *>(
        ((JPH::FixedConstraintSettings *)object)
    ));
}

const JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object)
{
    return (const JPH_FixedConstraintSettings *)(static_cast<const JPH::FixedConstraintSettings *>(
        ((const JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object)
{
    return (JPH_FixedConstraintSettings *)(static_cast<JPH::FixedConstraintSettings *>(
        ((JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_FixedConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::FixedConstraintSettings);
    return (JPH_FixedConstraintSettings *)new JPH::FixedConstraintSettings(JPH::FixedConstraintSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::FixedConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::FixedConstraintSettings), JPH::FixedConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::FixedConstraintSettings), JPH::FixedConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::FixedConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::FixedConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::FixedConstraintSettings))
    ));
}

void JPH_FixedConstraintSettings_Destroy(const JPH_FixedConstraintSettings *_this)
{
    delete ((const JPH::FixedConstraintSettings *)_this);
}

void JPH_FixedConstraintSettings_DestroyArray(const JPH_FixedConstraintSettings *_this)
{
    delete[] ((const JPH::FixedConstraintSettings *)_this);
}

JPH_FixedConstraintSettings *JPH_FixedConstraintSettings_AssignFromAnother(JPH_FixedConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_FixedConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::FixedConstraintSettings);
    return (JPH_FixedConstraintSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraintSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::FixedConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::FixedConstraintSettings), JPH::FixedConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::FixedConstraintSettings), JPH::FixedConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::FixedConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::FixedConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::FixedConstraintSettings))
    ));
}

void *Jolt_new_JPH_FixedConstraintSettings_size_t(size_t inCount)
{
    return JPH::FixedConstraintSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_FixedConstraintSettings_void_ptr(void *inPointer)
{
    JPH::FixedConstraintSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_FixedConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::FixedConstraintSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_FixedConstraintSettings_size_t(size_t inCount)
{
    return JPH::FixedConstraintSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr(void *inPointer)
{
    JPH::FixedConstraintSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::FixedConstraintSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_FixedConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::FixedConstraintSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_FixedConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::FixedConstraintSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_FixedConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::FixedConstraintSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::FixedConstraintSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_TwoBodyConstraint *JPH_FixedConstraintSettings_Create(const JPH_FixedConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2)
{
    return (JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).Create(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2))
    ));
}

void JPH_FixedConstraintSettings_SetEmbedded(const JPH_FixedConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_FixedConstraintSettings_GetRefCount(const JPH_FixedConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).GetRefCount();
}

void JPH_FixedConstraintSettings_AddRef(const JPH_FixedConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).AddRef();
}

void JPH_FixedConstraintSettings_Release(const JPH_FixedConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(_this)).Release();
}

int JPH_FixedConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::FixedConstraintSettings::sInternalGetRefCountOffset();
}

JPH_FixedConstraint *JPH_FixedConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_FixedConstraintSettings *inSettings)
{
    return (JPH_FixedConstraint *)new JPH::FixedConstraint(JPH::FixedConstraint(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::FixedConstraintSettings *)(inSettings))
    ));
}

const JPH_FixedConstraint *JPH_FixedConstraint_OffsetPtr(const JPH_FixedConstraint *ptr, ptrdiff_t i)
{
    return (const JPH_FixedConstraint *)(((const JPH::FixedConstraint *)ptr) + i);
}

JPH_FixedConstraint *JPH_FixedConstraint_OffsetMutablePtr(JPH_FixedConstraint *ptr, ptrdiff_t i)
{
    return (JPH_FixedConstraint *)(((JPH::FixedConstraint *)ptr) + i);
}

const JPH_RefTarget_JPH_Constraint *JPH_FixedConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_FixedConstraint *object)
{
    return (const JPH_RefTarget_JPH_Constraint *)(static_cast<const JPH::RefTarget<JPH::Constraint> *>(
        ((const JPH::FixedConstraint *)object)
    ));
}

JPH_RefTarget_JPH_Constraint *JPH_FixedConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_FixedConstraint *object)
{
    return (JPH_RefTarget_JPH_Constraint *)(static_cast<JPH::RefTarget<JPH::Constraint> *>(
        ((JPH::FixedConstraint *)object)
    ));
}

const JPH_FixedConstraint *JPH_FixedConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object)
{
    return (const JPH_FixedConstraint *)(static_cast<const JPH::FixedConstraint *>(
        ((const JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

JPH_FixedConstraint *JPH_FixedConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object)
{
    return (JPH_FixedConstraint *)(static_cast<JPH::FixedConstraint *>(
        ((JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

const JPH_NonCopyable *JPH_FixedConstraint_UpcastTo_JPH_NonCopyable(const JPH_FixedConstraint *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::FixedConstraint *)object)
    ));
}

JPH_NonCopyable *JPH_FixedConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_FixedConstraint *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::FixedConstraint *)object)
    ));
}

const JPH_FixedConstraint *JPH_FixedConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_FixedConstraint *)(static_cast<const JPH::FixedConstraint *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_FixedConstraint *JPH_FixedConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_FixedConstraint *)(static_cast<JPH::FixedConstraint *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Constraint *JPH_FixedConstraint_UpcastTo_JPH_Constraint(const JPH_FixedConstraint *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::FixedConstraint *)object)
    ));
}

JPH_Constraint *JPH_FixedConstraint_MutableUpcastTo_JPH_Constraint(JPH_FixedConstraint *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::FixedConstraint *)object)
    ));
}

const JPH_FixedConstraint *JPH_FixedConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object)
{
    return (const JPH_FixedConstraint *)(static_cast<const JPH::FixedConstraint *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_FixedConstraint *JPH_FixedConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object)
{
    return (JPH_FixedConstraint *)(static_cast<JPH::FixedConstraint *>(
        ((JPH::Constraint *)object)
    ));
}

const JPH_TwoBodyConstraint *JPH_FixedConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_FixedConstraint *object)
{
    return (const JPH_TwoBodyConstraint *)(static_cast<const JPH::TwoBodyConstraint *>(
        ((const JPH::FixedConstraint *)object)
    ));
}

JPH_TwoBodyConstraint *JPH_FixedConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_FixedConstraint *object)
{
    return (JPH_TwoBodyConstraint *)(static_cast<JPH::TwoBodyConstraint *>(
        ((JPH::FixedConstraint *)object)
    ));
}

const JPH_FixedConstraint *JPH_FixedConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object)
{
    return (const JPH_FixedConstraint *)(static_cast<const JPH::FixedConstraint *>(
        ((const JPH::TwoBodyConstraint *)object)
    ));
}

JPH_FixedConstraint *JPH_FixedConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object)
{
    return (JPH_FixedConstraint *)(static_cast<JPH::FixedConstraint *>(
        ((JPH::TwoBodyConstraint *)object)
    ));
}

void JPH_FixedConstraint_Destroy(const JPH_FixedConstraint *_this)
{
    delete ((const JPH::FixedConstraint *)_this);
}

void JPH_FixedConstraint_DestroyArray(const JPH_FixedConstraint *_this)
{
    delete[] ((const JPH::FixedConstraint *)_this);
}

void *Jolt_new_JPH_FixedConstraint_size_t(size_t inCount)
{
    return JPH::FixedConstraint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_FixedConstraint_void_ptr(void *inPointer)
{
    JPH::FixedConstraint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_FixedConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::FixedConstraint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_FixedConstraint_size_t(size_t inCount)
{
    return JPH::FixedConstraint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_FixedConstraint_void_ptr(void *inPointer)
{
    JPH::FixedConstraint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_FixedConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::FixedConstraint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_FixedConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::FixedConstraint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_FixedConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::FixedConstraint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_FixedConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::FixedConstraint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_FixedConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::FixedConstraint::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_FixedConstraint_NotifyShapeChanged(JPH_FixedConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraint *)(_this)).NotifyShapeChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inDeltaCOM ? void() : MRBINDC_THROW("Parameter `inDeltaCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaCOM))
    );
}

void JPH_FixedConstraint_SetupVelocityConstraint(JPH_FixedConstraint *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraint *)(_this)).SetupVelocityConstraint(
        inDeltaTime
    );
}

void JPH_FixedConstraint_ResetWarmStart(JPH_FixedConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraint *)(_this)).ResetWarmStart();
}

void JPH_FixedConstraint_WarmStartVelocityConstraint(JPH_FixedConstraint *_this, float inWarmStartImpulseRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraint *)(_this)).WarmStartVelocityConstraint(
        inWarmStartImpulseRatio
    );
}

bool JPH_FixedConstraint_SolveVelocityConstraint(JPH_FixedConstraint *_this, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraint *)(_this)).SolveVelocityConstraint(
        inDeltaTime
    );
}

bool JPH_FixedConstraint_SolvePositionConstraint(JPH_FixedConstraint *_this, float inDeltaTime, float inBaumgarte)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraint *)(_this)).SolvePositionConstraint(
        inDeltaTime,
        inBaumgarte
    );
}

JPH_Mat44 *JPH_FixedConstraint_GetConstraintToBody1Matrix(const JPH_FixedConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).GetConstraintToBody1Matrix());
}

JPH_Mat44 *JPH_FixedConstraint_GetConstraintToBody2Matrix(const JPH_FixedConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).GetConstraintToBody2Matrix());
}

JPH_Vec3 *JPH_FixedConstraint_GetTotalLambdaPosition(const JPH_FixedConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).GetTotalLambdaPosition());
}

JPH_Vec3 *JPH_FixedConstraint_GetTotalLambdaRotation(const JPH_FixedConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).GetTotalLambdaRotation());
}

bool JPH_FixedConstraint_IsActive(const JPH_FixedConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).IsActive();
}

JPH_Body *JPH_FixedConstraint_GetBody1(const JPH_FixedConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).GetBody1());
}

JPH_Body *JPH_FixedConstraint_GetBody2(const JPH_FixedConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).GetBody2());
}

unsigned int JPH_FixedConstraint_GetConstraintPriority(const JPH_FixedConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).GetConstraintPriority();
}

void JPH_FixedConstraint_SetConstraintPriority(JPH_FixedConstraint *_this, unsigned int inPriority)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraint *)(_this)).SetConstraintPriority(
        inPriority
    );
}

void JPH_FixedConstraint_SetNumVelocityStepsOverride(JPH_FixedConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraint *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_FixedConstraint_GetNumVelocityStepsOverride(const JPH_FixedConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_FixedConstraint_SetNumPositionStepsOverride(JPH_FixedConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraint *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_FixedConstraint_GetNumPositionStepsOverride(const JPH_FixedConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).GetNumPositionStepsOverride();
}

void JPH_FixedConstraint_SetEnabled(JPH_FixedConstraint *_this, bool inEnabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraint *)(_this)).SetEnabled(
        inEnabled
    );
}

bool JPH_FixedConstraint_GetEnabled(const JPH_FixedConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).GetEnabled();
}

uint64_t JPH_FixedConstraint_GetUserData(const JPH_FixedConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).GetUserData();
}

void JPH_FixedConstraint_SetUserData(JPH_FixedConstraint *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::FixedConstraint *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_FixedConstraint_SetEmbedded(const JPH_FixedConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).SetEmbedded();
}

unsigned int JPH_FixedConstraint_GetRefCount(const JPH_FixedConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).GetRefCount();
}

void JPH_FixedConstraint_AddRef(const JPH_FixedConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).AddRef();
}

void JPH_FixedConstraint_Release(const JPH_FixedConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::FixedConstraint *)(_this)).Release();
}

int JPH_FixedConstraint_sInternalGetRefCountOffset(void)
{
    return JPH::FixedConstraint::sInternalGetRefCountOffset();
}

