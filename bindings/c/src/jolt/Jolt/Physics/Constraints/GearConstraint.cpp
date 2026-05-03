// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/GearConstraint.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/Constraints/GearConstraint.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_GearConstraintSettings_Get_mHingeAxis1(const JPH_GearConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraintSettings *)(_this)).mHingeAxis1);
}

JPH_Vec3 *JPH_GearConstraintSettings_GetMutable_mHingeAxis1(JPH_GearConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mHingeAxis1);
}

const JPH_Vec3 *JPH_GearConstraintSettings_Get_mHingeAxis2(const JPH_GearConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraintSettings *)(_this)).mHingeAxis2);
}

JPH_Vec3 *JPH_GearConstraintSettings_GetMutable_mHingeAxis2(JPH_GearConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mHingeAxis2);
}

const float *JPH_GearConstraintSettings_Get_mRatio(const JPH_GearConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraintSettings *)(_this)).mRatio);
}

void JPH_GearConstraintSettings_Set_mRatio(JPH_GearConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mRatio = value;
}

float *JPH_GearConstraintSettings_GetMutable_mRatio(JPH_GearConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mRatio);
}

const bool *JPH_GearConstraintSettings_Get_mEnabled(const JPH_GearConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraintSettings *)(_this)).mEnabled);
}

void JPH_GearConstraintSettings_Set_mEnabled(JPH_GearConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mEnabled = value;
}

bool *JPH_GearConstraintSettings_GetMutable_mEnabled(JPH_GearConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mEnabled);
}

const unsigned int *JPH_GearConstraintSettings_Get_mConstraintPriority(const JPH_GearConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraintSettings *)(_this)).mConstraintPriority);
}

void JPH_GearConstraintSettings_Set_mConstraintPriority(JPH_GearConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mConstraintPriority = value;
}

unsigned int *JPH_GearConstraintSettings_GetMutable_mConstraintPriority(JPH_GearConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mConstraintPriority);
}

const unsigned int *JPH_GearConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_GearConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_GearConstraintSettings_Set_mNumVelocityStepsOverride(JPH_GearConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_GearConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_GearConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_GearConstraintSettings_Get_mNumPositionStepsOverride(const JPH_GearConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_GearConstraintSettings_Set_mNumPositionStepsOverride(JPH_GearConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_GearConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_GearConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_GearConstraintSettings_Get_mDrawConstraintSize(const JPH_GearConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraintSettings *)(_this)).mDrawConstraintSize);
}

void JPH_GearConstraintSettings_Set_mDrawConstraintSize(JPH_GearConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mDrawConstraintSize = value;
}

float *JPH_GearConstraintSettings_GetMutable_mDrawConstraintSize(JPH_GearConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mDrawConstraintSize);
}

const uint64_t *JPH_GearConstraintSettings_Get_mUserData(const JPH_GearConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraintSettings *)(_this)).mUserData);
}

void JPH_GearConstraintSettings_Set_mUserData(JPH_GearConstraintSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_GearConstraintSettings_GetMutable_mUserData(JPH_GearConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).mUserData);
}

JPH_GearConstraintSettings *JPH_GearConstraintSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::GearConstraintSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_GearConstraintSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_GearConstraintSettings *JPH_GearConstraintSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_GearConstraintSettings *)(new JPH::GearConstraintSettings[num_elems]{});
}

const JPH_GearConstraintSettings *JPH_GearConstraintSettings_OffsetPtr(const JPH_GearConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_GearConstraintSettings *)(((const JPH::GearConstraintSettings *)ptr) + i);
}

JPH_GearConstraintSettings *JPH_GearConstraintSettings_OffsetMutablePtr(JPH_GearConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_GearConstraintSettings *)(((JPH::GearConstraintSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_GearConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_GearConstraintSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::GearConstraintSettings *)object)
    ));
}

JPH_SerializableObject *JPH_GearConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_GearConstraintSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::GearConstraintSettings *)object)
    ));
}

const JPH_GearConstraintSettings *JPH_GearConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_GearConstraintSettings *)(static_cast<const JPH::GearConstraintSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_GearConstraintSettings *JPH_GearConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_GearConstraintSettings *)(static_cast<JPH::GearConstraintSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_GearConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_GearConstraintSettings *object)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<const JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((const JPH::GearConstraintSettings *)object)
    ));
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_GearConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_GearConstraintSettings *object)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((JPH::GearConstraintSettings *)object)
    ));
}

const JPH_GearConstraintSettings *JPH_GearConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (const JPH_GearConstraintSettings *)(static_cast<const JPH::GearConstraintSettings *>(
        ((const JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

JPH_GearConstraintSettings *JPH_GearConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (JPH_GearConstraintSettings *)(static_cast<JPH::GearConstraintSettings *>(
        ((JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

const JPH_ConstraintSettings *JPH_GearConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_GearConstraintSettings *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::GearConstraintSettings *)object)
    ));
}

JPH_ConstraintSettings *JPH_GearConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_GearConstraintSettings *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::GearConstraintSettings *)object)
    ));
}

const JPH_GearConstraintSettings *JPH_GearConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object)
{
    return (const JPH_GearConstraintSettings *)(static_cast<const JPH::GearConstraintSettings *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_GearConstraintSettings *JPH_GearConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object)
{
    return (JPH_GearConstraintSettings *)(static_cast<JPH::GearConstraintSettings *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

const JPH_TwoBodyConstraintSettings *JPH_GearConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_GearConstraintSettings *object)
{
    return (const JPH_TwoBodyConstraintSettings *)(static_cast<const JPH::TwoBodyConstraintSettings *>(
        ((const JPH::GearConstraintSettings *)object)
    ));
}

JPH_TwoBodyConstraintSettings *JPH_GearConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_GearConstraintSettings *object)
{
    return (JPH_TwoBodyConstraintSettings *)(static_cast<JPH::TwoBodyConstraintSettings *>(
        ((JPH::GearConstraintSettings *)object)
    ));
}

const JPH_GearConstraintSettings *JPH_GearConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object)
{
    return (const JPH_GearConstraintSettings *)(static_cast<const JPH::GearConstraintSettings *>(
        ((const JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_GearConstraintSettings *JPH_GearConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object)
{
    return (JPH_GearConstraintSettings *)(static_cast<JPH::GearConstraintSettings *>(
        ((JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_GearConstraintSettings *JPH_GearConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_GearConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::GearConstraintSettings);
    return (JPH_GearConstraintSettings *)new JPH::GearConstraintSettings(JPH::GearConstraintSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::GearConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::GearConstraintSettings), JPH::GearConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::GearConstraintSettings), JPH::GearConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::GearConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::GearConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::GearConstraintSettings))
    ));
}

void JPH_GearConstraintSettings_Destroy(const JPH_GearConstraintSettings *_this)
{
    delete ((const JPH::GearConstraintSettings *)_this);
}

void JPH_GearConstraintSettings_DestroyArray(const JPH_GearConstraintSettings *_this)
{
    delete[] ((const JPH::GearConstraintSettings *)_this);
}

JPH_GearConstraintSettings *JPH_GearConstraintSettings_AssignFromAnother(JPH_GearConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_GearConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::GearConstraintSettings);
    return (JPH_GearConstraintSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::GearConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::GearConstraintSettings), JPH::GearConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::GearConstraintSettings), JPH::GearConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::GearConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::GearConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::GearConstraintSettings))
    ));
}

void *Jolt_new_JPH_GearConstraintSettings_size_t(size_t inCount)
{
    return JPH::GearConstraintSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_GearConstraintSettings_void_ptr(void *inPointer)
{
    JPH::GearConstraintSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_GearConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::GearConstraintSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_GearConstraintSettings_size_t(size_t inCount)
{
    return JPH::GearConstraintSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_GearConstraintSettings_void_ptr(void *inPointer)
{
    JPH::GearConstraintSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_GearConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::GearConstraintSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_GearConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::GearConstraintSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_GearConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::GearConstraintSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_GearConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::GearConstraintSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_GearConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::GearConstraintSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_TwoBodyConstraint *JPH_GearConstraintSettings_Create(const JPH_GearConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2)
{
    return (JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraintSettings *)(_this)).Create(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2))
    ));
}

void JPH_GearConstraintSettings_SetRatio(JPH_GearConstraintSettings *_this, int inNumTeethGear1, int inNumTeethGear2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraintSettings *)(_this)).SetRatio(
        inNumTeethGear1,
        inNumTeethGear2
    );
}

void JPH_GearConstraintSettings_SetEmbedded(const JPH_GearConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraintSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_GearConstraintSettings_GetRefCount(const JPH_GearConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraintSettings *)(_this)).GetRefCount();
}

void JPH_GearConstraintSettings_AddRef(const JPH_GearConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraintSettings *)(_this)).AddRef();
}

void JPH_GearConstraintSettings_Release(const JPH_GearConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraintSettings *)(_this)).Release();
}

int JPH_GearConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::GearConstraintSettings::sInternalGetRefCountOffset();
}

JPH_GearConstraint *JPH_GearConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_GearConstraintSettings *inSettings)
{
    return (JPH_GearConstraint *)new JPH::GearConstraint(JPH::GearConstraint(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::GearConstraintSettings *)(inSettings))
    ));
}

const JPH_GearConstraint *JPH_GearConstraint_OffsetPtr(const JPH_GearConstraint *ptr, ptrdiff_t i)
{
    return (const JPH_GearConstraint *)(((const JPH::GearConstraint *)ptr) + i);
}

JPH_GearConstraint *JPH_GearConstraint_OffsetMutablePtr(JPH_GearConstraint *ptr, ptrdiff_t i)
{
    return (JPH_GearConstraint *)(((JPH::GearConstraint *)ptr) + i);
}

const JPH_RefTarget_JPH_Constraint *JPH_GearConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_GearConstraint *object)
{
    return (const JPH_RefTarget_JPH_Constraint *)(static_cast<const JPH::RefTarget<JPH::Constraint> *>(
        ((const JPH::GearConstraint *)object)
    ));
}

JPH_RefTarget_JPH_Constraint *JPH_GearConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_GearConstraint *object)
{
    return (JPH_RefTarget_JPH_Constraint *)(static_cast<JPH::RefTarget<JPH::Constraint> *>(
        ((JPH::GearConstraint *)object)
    ));
}

const JPH_GearConstraint *JPH_GearConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object)
{
    return (const JPH_GearConstraint *)(static_cast<const JPH::GearConstraint *>(
        ((const JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

JPH_GearConstraint *JPH_GearConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object)
{
    return (JPH_GearConstraint *)(static_cast<JPH::GearConstraint *>(
        ((JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

const JPH_NonCopyable *JPH_GearConstraint_UpcastTo_JPH_NonCopyable(const JPH_GearConstraint *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::GearConstraint *)object)
    ));
}

JPH_NonCopyable *JPH_GearConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_GearConstraint *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::GearConstraint *)object)
    ));
}

const JPH_GearConstraint *JPH_GearConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_GearConstraint *)(static_cast<const JPH::GearConstraint *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_GearConstraint *JPH_GearConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_GearConstraint *)(static_cast<JPH::GearConstraint *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Constraint *JPH_GearConstraint_UpcastTo_JPH_Constraint(const JPH_GearConstraint *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::GearConstraint *)object)
    ));
}

JPH_Constraint *JPH_GearConstraint_MutableUpcastTo_JPH_Constraint(JPH_GearConstraint *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::GearConstraint *)object)
    ));
}

const JPH_GearConstraint *JPH_GearConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object)
{
    return (const JPH_GearConstraint *)(static_cast<const JPH::GearConstraint *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_GearConstraint *JPH_GearConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object)
{
    return (JPH_GearConstraint *)(static_cast<JPH::GearConstraint *>(
        ((JPH::Constraint *)object)
    ));
}

const JPH_TwoBodyConstraint *JPH_GearConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_GearConstraint *object)
{
    return (const JPH_TwoBodyConstraint *)(static_cast<const JPH::TwoBodyConstraint *>(
        ((const JPH::GearConstraint *)object)
    ));
}

JPH_TwoBodyConstraint *JPH_GearConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_GearConstraint *object)
{
    return (JPH_TwoBodyConstraint *)(static_cast<JPH::TwoBodyConstraint *>(
        ((JPH::GearConstraint *)object)
    ));
}

const JPH_GearConstraint *JPH_GearConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object)
{
    return (const JPH_GearConstraint *)(static_cast<const JPH::GearConstraint *>(
        ((const JPH::TwoBodyConstraint *)object)
    ));
}

JPH_GearConstraint *JPH_GearConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object)
{
    return (JPH_GearConstraint *)(static_cast<JPH::GearConstraint *>(
        ((JPH::TwoBodyConstraint *)object)
    ));
}

void JPH_GearConstraint_Destroy(const JPH_GearConstraint *_this)
{
    delete ((const JPH::GearConstraint *)_this);
}

void JPH_GearConstraint_DestroyArray(const JPH_GearConstraint *_this)
{
    delete[] ((const JPH::GearConstraint *)_this);
}

void *Jolt_new_JPH_GearConstraint_size_t(size_t inCount)
{
    return JPH::GearConstraint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_GearConstraint_void_ptr(void *inPointer)
{
    JPH::GearConstraint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_GearConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::GearConstraint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_GearConstraint_size_t(size_t inCount)
{
    return JPH::GearConstraint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_GearConstraint_void_ptr(void *inPointer)
{
    JPH::GearConstraint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_GearConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::GearConstraint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_GearConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::GearConstraint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_GearConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::GearConstraint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_GearConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::GearConstraint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_GearConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::GearConstraint::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_GearConstraint_NotifyShapeChanged(JPH_GearConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraint *)(_this)).NotifyShapeChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inDeltaCOM ? void() : MRBINDC_THROW("Parameter `inDeltaCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaCOM))
    );
}

void JPH_GearConstraint_SetupVelocityConstraint(JPH_GearConstraint *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraint *)(_this)).SetupVelocityConstraint(
        inDeltaTime
    );
}

void JPH_GearConstraint_ResetWarmStart(JPH_GearConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraint *)(_this)).ResetWarmStart();
}

void JPH_GearConstraint_WarmStartVelocityConstraint(JPH_GearConstraint *_this, float inWarmStartImpulseRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraint *)(_this)).WarmStartVelocityConstraint(
        inWarmStartImpulseRatio
    );
}

bool JPH_GearConstraint_SolveVelocityConstraint(JPH_GearConstraint *_this, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraint *)(_this)).SolveVelocityConstraint(
        inDeltaTime
    );
}

bool JPH_GearConstraint_SolvePositionConstraint(JPH_GearConstraint *_this, float inDeltaTime, float inBaumgarte)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraint *)(_this)).SolvePositionConstraint(
        inDeltaTime,
        inBaumgarte
    );
}

void JPH_GearConstraint_DrawConstraint(const JPH_GearConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).DrawConstraint(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

JPH_Mat44 *JPH_GearConstraint_GetConstraintToBody1Matrix(const JPH_GearConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).GetConstraintToBody1Matrix());
}

JPH_Mat44 *JPH_GearConstraint_GetConstraintToBody2Matrix(const JPH_GearConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).GetConstraintToBody2Matrix());
}

void JPH_GearConstraint_SetConstraints(JPH_GearConstraint *_this, const JPH_Constraint *inGear1, const JPH_Constraint *inGear2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraint *)(_this)).SetConstraints(
        ((const JPH::Constraint *)inGear1),
        ((const JPH::Constraint *)inGear2)
    );
}

float JPH_GearConstraint_GetTotalLambda(const JPH_GearConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).GetTotalLambda();
}

bool JPH_GearConstraint_IsActive(const JPH_GearConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).IsActive();
}

void JPH_GearConstraint_DrawConstraintReferenceFrame(const JPH_GearConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).DrawConstraintReferenceFrame(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

JPH_Body *JPH_GearConstraint_GetBody1(const JPH_GearConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).GetBody1());
}

JPH_Body *JPH_GearConstraint_GetBody2(const JPH_GearConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).GetBody2());
}

unsigned int JPH_GearConstraint_GetConstraintPriority(const JPH_GearConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).GetConstraintPriority();
}

void JPH_GearConstraint_SetConstraintPriority(JPH_GearConstraint *_this, unsigned int inPriority)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraint *)(_this)).SetConstraintPriority(
        inPriority
    );
}

void JPH_GearConstraint_SetNumVelocityStepsOverride(JPH_GearConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraint *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_GearConstraint_GetNumVelocityStepsOverride(const JPH_GearConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_GearConstraint_SetNumPositionStepsOverride(JPH_GearConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraint *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_GearConstraint_GetNumPositionStepsOverride(const JPH_GearConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).GetNumPositionStepsOverride();
}

void JPH_GearConstraint_SetEnabled(JPH_GearConstraint *_this, bool inEnabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraint *)(_this)).SetEnabled(
        inEnabled
    );
}

bool JPH_GearConstraint_GetEnabled(const JPH_GearConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).GetEnabled();
}

uint64_t JPH_GearConstraint_GetUserData(const JPH_GearConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).GetUserData();
}

void JPH_GearConstraint_SetUserData(JPH_GearConstraint *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraint *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_GearConstraint_DrawConstraintLimits(const JPH_GearConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).DrawConstraintLimits(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

float JPH_GearConstraint_GetDrawConstraintSize(const JPH_GearConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).GetDrawConstraintSize();
}

void JPH_GearConstraint_SetDrawConstraintSize(JPH_GearConstraint *_this, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GearConstraint *)(_this)).SetDrawConstraintSize(
        inSize
    );
}

void JPH_GearConstraint_SetEmbedded(const JPH_GearConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).SetEmbedded();
}

unsigned int JPH_GearConstraint_GetRefCount(const JPH_GearConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).GetRefCount();
}

void JPH_GearConstraint_AddRef(const JPH_GearConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).AddRef();
}

void JPH_GearConstraint_Release(const JPH_GearConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GearConstraint *)(_this)).Release();
}

int JPH_GearConstraint_sInternalGetRefCountOffset(void)
{
    return JPH::GearConstraint::sInternalGetRefCountOffset();
}

