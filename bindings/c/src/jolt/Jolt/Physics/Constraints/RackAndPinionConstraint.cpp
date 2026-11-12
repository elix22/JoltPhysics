// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/RackAndPinionConstraint.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/Constraints/RackAndPinionConstraint.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_RackAndPinionConstraintSettings_Get_mHingeAxis(const JPH_RackAndPinionConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(_this)).mHingeAxis);
}

JPH_Vec3 *JPH_RackAndPinionConstraintSettings_GetMutable_mHingeAxis(JPH_RackAndPinionConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mHingeAxis);
}

const JPH_Vec3 *JPH_RackAndPinionConstraintSettings_Get_mSliderAxis(const JPH_RackAndPinionConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(_this)).mSliderAxis);
}

JPH_Vec3 *JPH_RackAndPinionConstraintSettings_GetMutable_mSliderAxis(JPH_RackAndPinionConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mSliderAxis);
}

const float *JPH_RackAndPinionConstraintSettings_Get_mRatio(const JPH_RackAndPinionConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(_this)).mRatio);
}

void JPH_RackAndPinionConstraintSettings_Set_mRatio(JPH_RackAndPinionConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mRatio = value;
}

float *JPH_RackAndPinionConstraintSettings_GetMutable_mRatio(JPH_RackAndPinionConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mRatio);
}

const bool *JPH_RackAndPinionConstraintSettings_Get_mEnabled(const JPH_RackAndPinionConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(_this)).mEnabled);
}

void JPH_RackAndPinionConstraintSettings_Set_mEnabled(JPH_RackAndPinionConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mEnabled = value;
}

bool *JPH_RackAndPinionConstraintSettings_GetMutable_mEnabled(JPH_RackAndPinionConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mEnabled);
}

const unsigned int *JPH_RackAndPinionConstraintSettings_Get_mConstraintPriority(const JPH_RackAndPinionConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(_this)).mConstraintPriority);
}

void JPH_RackAndPinionConstraintSettings_Set_mConstraintPriority(JPH_RackAndPinionConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mConstraintPriority = value;
}

unsigned int *JPH_RackAndPinionConstraintSettings_GetMutable_mConstraintPriority(JPH_RackAndPinionConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mConstraintPriority);
}

const unsigned int *JPH_RackAndPinionConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_RackAndPinionConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_RackAndPinionConstraintSettings_Set_mNumVelocityStepsOverride(JPH_RackAndPinionConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_RackAndPinionConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_RackAndPinionConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_RackAndPinionConstraintSettings_Get_mNumPositionStepsOverride(const JPH_RackAndPinionConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_RackAndPinionConstraintSettings_Set_mNumPositionStepsOverride(JPH_RackAndPinionConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_RackAndPinionConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_RackAndPinionConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_RackAndPinionConstraintSettings_Get_mDrawConstraintSize(const JPH_RackAndPinionConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(_this)).mDrawConstraintSize);
}

void JPH_RackAndPinionConstraintSettings_Set_mDrawConstraintSize(JPH_RackAndPinionConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mDrawConstraintSize = value;
}

float *JPH_RackAndPinionConstraintSettings_GetMutable_mDrawConstraintSize(JPH_RackAndPinionConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mDrawConstraintSize);
}

const uint64_t *JPH_RackAndPinionConstraintSettings_Get_mUserData(const JPH_RackAndPinionConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(_this)).mUserData);
}

void JPH_RackAndPinionConstraintSettings_Set_mUserData(JPH_RackAndPinionConstraintSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_RackAndPinionConstraintSettings_GetMutable_mUserData(JPH_RackAndPinionConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).mUserData);
}

JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RackAndPinionConstraintSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RackAndPinionConstraintSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RackAndPinionConstraintSettings *)(new JPH::RackAndPinionConstraintSettings[num_elems]);
}

const JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_OffsetPtr(const JPH_RackAndPinionConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_RackAndPinionConstraintSettings *)(((const JPH::RackAndPinionConstraintSettings *)ptr) + i);
}

JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_OffsetMutablePtr(JPH_RackAndPinionConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_RackAndPinionConstraintSettings *)(((JPH::RackAndPinionConstraintSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_RackAndPinionConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_RackAndPinionConstraintSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::RackAndPinionConstraintSettings *)object)
    ));
}

JPH_SerializableObject *JPH_RackAndPinionConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_RackAndPinionConstraintSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::RackAndPinionConstraintSettings *)object)
    ));
}

const JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_RackAndPinionConstraintSettings *)(static_cast<const JPH::RackAndPinionConstraintSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_RackAndPinionConstraintSettings *)(static_cast<JPH::RackAndPinionConstraintSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_RackAndPinionConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RackAndPinionConstraintSettings *object)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<const JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((const JPH::RackAndPinionConstraintSettings *)object)
    ));
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_RackAndPinionConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_RackAndPinionConstraintSettings *object)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((JPH::RackAndPinionConstraintSettings *)object)
    ));
}

const JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (const JPH_RackAndPinionConstraintSettings *)(static_cast<const JPH::RackAndPinionConstraintSettings *>(
        ((const JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (JPH_RackAndPinionConstraintSettings *)(static_cast<JPH::RackAndPinionConstraintSettings *>(
        ((JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

const JPH_ConstraintSettings *JPH_RackAndPinionConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_RackAndPinionConstraintSettings *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::RackAndPinionConstraintSettings *)object)
    ));
}

JPH_ConstraintSettings *JPH_RackAndPinionConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_RackAndPinionConstraintSettings *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::RackAndPinionConstraintSettings *)object)
    ));
}

const JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object)
{
    return (const JPH_RackAndPinionConstraintSettings *)(static_cast<const JPH::RackAndPinionConstraintSettings *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object)
{
    return (JPH_RackAndPinionConstraintSettings *)(static_cast<JPH::RackAndPinionConstraintSettings *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

const JPH_TwoBodyConstraintSettings *JPH_RackAndPinionConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_RackAndPinionConstraintSettings *object)
{
    return (const JPH_TwoBodyConstraintSettings *)(static_cast<const JPH::TwoBodyConstraintSettings *>(
        ((const JPH::RackAndPinionConstraintSettings *)object)
    ));
}

JPH_TwoBodyConstraintSettings *JPH_RackAndPinionConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_RackAndPinionConstraintSettings *object)
{
    return (JPH_TwoBodyConstraintSettings *)(static_cast<JPH::TwoBodyConstraintSettings *>(
        ((JPH::RackAndPinionConstraintSettings *)object)
    ));
}

const JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object)
{
    return (const JPH_RackAndPinionConstraintSettings *)(static_cast<const JPH::RackAndPinionConstraintSettings *>(
        ((const JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object)
{
    return (JPH_RackAndPinionConstraintSettings *)(static_cast<JPH::RackAndPinionConstraintSettings *>(
        ((JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RackAndPinionConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RackAndPinionConstraintSettings);
    return (JPH_RackAndPinionConstraintSettings *)new JPH::RackAndPinionConstraintSettings(JPH::RackAndPinionConstraintSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RackAndPinionConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::RackAndPinionConstraintSettings), JPH::RackAndPinionConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::RackAndPinionConstraintSettings), JPH::RackAndPinionConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RackAndPinionConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RackAndPinionConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::RackAndPinionConstraintSettings))
    ));
}

void JPH_RackAndPinionConstraintSettings_Destroy(const JPH_RackAndPinionConstraintSettings *_this)
{
    delete ((const JPH::RackAndPinionConstraintSettings *)_this);
}

void JPH_RackAndPinionConstraintSettings_DestroyArray(const JPH_RackAndPinionConstraintSettings *_this)
{
    delete[] ((const JPH::RackAndPinionConstraintSettings *)_this);
}

JPH_RackAndPinionConstraintSettings *JPH_RackAndPinionConstraintSettings_AssignFromAnother(JPH_RackAndPinionConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_RackAndPinionConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RackAndPinionConstraintSettings);
    return (JPH_RackAndPinionConstraintSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RackAndPinionConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::RackAndPinionConstraintSettings), JPH::RackAndPinionConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::RackAndPinionConstraintSettings), JPH::RackAndPinionConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RackAndPinionConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RackAndPinionConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::RackAndPinionConstraintSettings))
    ));
}

void *Jolt_new_JPH_RackAndPinionConstraintSettings_size_t(size_t inCount)
{
    return JPH::RackAndPinionConstraintSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_RackAndPinionConstraintSettings_void_ptr(void *inPointer)
{
    JPH::RackAndPinionConstraintSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_RackAndPinionConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RackAndPinionConstraintSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_RackAndPinionConstraintSettings_size_t(size_t inCount)
{
    return JPH::RackAndPinionConstraintSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_RackAndPinionConstraintSettings_void_ptr(void *inPointer)
{
    JPH::RackAndPinionConstraintSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_RackAndPinionConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RackAndPinionConstraintSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_RackAndPinionConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RackAndPinionConstraintSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_RackAndPinionConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RackAndPinionConstraintSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_RackAndPinionConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RackAndPinionConstraintSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_RackAndPinionConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RackAndPinionConstraintSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_TwoBodyConstraint *JPH_RackAndPinionConstraintSettings_Create(const JPH_RackAndPinionConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2)
{
    return (JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(_this)).Create(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2))
    ));
}

void JPH_RackAndPinionConstraintSettings_SetRatio(JPH_RackAndPinionConstraintSettings *_this, int inNumTeethRack, float inRackLength, int inNumTeethPinion)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraintSettings *)(_this)).SetRatio(
        inNumTeethRack,
        inRackLength,
        inNumTeethPinion
    );
}

void JPH_RackAndPinionConstraintSettings_SetEmbedded(const JPH_RackAndPinionConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_RackAndPinionConstraintSettings_GetRefCount(const JPH_RackAndPinionConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(_this)).GetRefCount();
}

void JPH_RackAndPinionConstraintSettings_AddRef(const JPH_RackAndPinionConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(_this)).AddRef();
}

void JPH_RackAndPinionConstraintSettings_Release(const JPH_RackAndPinionConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(_this)).Release();
}

int JPH_RackAndPinionConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::RackAndPinionConstraintSettings::sInternalGetRefCountOffset();
}

JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_RackAndPinionConstraintSettings *inSettings)
{
    return (JPH_RackAndPinionConstraint *)new JPH::RackAndPinionConstraint(JPH::RackAndPinionConstraint(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::RackAndPinionConstraintSettings *)(inSettings))
    ));
}

const JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_OffsetPtr(const JPH_RackAndPinionConstraint *ptr, ptrdiff_t i)
{
    return (const JPH_RackAndPinionConstraint *)(((const JPH::RackAndPinionConstraint *)ptr) + i);
}

JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_OffsetMutablePtr(JPH_RackAndPinionConstraint *ptr, ptrdiff_t i)
{
    return (JPH_RackAndPinionConstraint *)(((JPH::RackAndPinionConstraint *)ptr) + i);
}

const JPH_RefTarget_JPH_Constraint *JPH_RackAndPinionConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_RackAndPinionConstraint *object)
{
    return (const JPH_RefTarget_JPH_Constraint *)(static_cast<const JPH::RefTarget<JPH::Constraint> *>(
        ((const JPH::RackAndPinionConstraint *)object)
    ));
}

JPH_RefTarget_JPH_Constraint *JPH_RackAndPinionConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_RackAndPinionConstraint *object)
{
    return (JPH_RefTarget_JPH_Constraint *)(static_cast<JPH::RefTarget<JPH::Constraint> *>(
        ((JPH::RackAndPinionConstraint *)object)
    ));
}

const JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object)
{
    return (const JPH_RackAndPinionConstraint *)(static_cast<const JPH::RackAndPinionConstraint *>(
        ((const JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object)
{
    return (JPH_RackAndPinionConstraint *)(static_cast<JPH::RackAndPinionConstraint *>(
        ((JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

const JPH_NonCopyable *JPH_RackAndPinionConstraint_UpcastTo_JPH_NonCopyable(const JPH_RackAndPinionConstraint *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::RackAndPinionConstraint *)object)
    ));
}

JPH_NonCopyable *JPH_RackAndPinionConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_RackAndPinionConstraint *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::RackAndPinionConstraint *)object)
    ));
}

const JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_RackAndPinionConstraint *)(static_cast<const JPH::RackAndPinionConstraint *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_RackAndPinionConstraint *)(static_cast<JPH::RackAndPinionConstraint *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Constraint *JPH_RackAndPinionConstraint_UpcastTo_JPH_Constraint(const JPH_RackAndPinionConstraint *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::RackAndPinionConstraint *)object)
    ));
}

JPH_Constraint *JPH_RackAndPinionConstraint_MutableUpcastTo_JPH_Constraint(JPH_RackAndPinionConstraint *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::RackAndPinionConstraint *)object)
    ));
}

const JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object)
{
    return (const JPH_RackAndPinionConstraint *)(static_cast<const JPH::RackAndPinionConstraint *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object)
{
    return (JPH_RackAndPinionConstraint *)(static_cast<JPH::RackAndPinionConstraint *>(
        ((JPH::Constraint *)object)
    ));
}

const JPH_TwoBodyConstraint *JPH_RackAndPinionConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_RackAndPinionConstraint *object)
{
    return (const JPH_TwoBodyConstraint *)(static_cast<const JPH::TwoBodyConstraint *>(
        ((const JPH::RackAndPinionConstraint *)object)
    ));
}

JPH_TwoBodyConstraint *JPH_RackAndPinionConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_RackAndPinionConstraint *object)
{
    return (JPH_TwoBodyConstraint *)(static_cast<JPH::TwoBodyConstraint *>(
        ((JPH::RackAndPinionConstraint *)object)
    ));
}

const JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object)
{
    return (const JPH_RackAndPinionConstraint *)(static_cast<const JPH::RackAndPinionConstraint *>(
        ((const JPH::TwoBodyConstraint *)object)
    ));
}

JPH_RackAndPinionConstraint *JPH_RackAndPinionConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object)
{
    return (JPH_RackAndPinionConstraint *)(static_cast<JPH::RackAndPinionConstraint *>(
        ((JPH::TwoBodyConstraint *)object)
    ));
}

void JPH_RackAndPinionConstraint_Destroy(const JPH_RackAndPinionConstraint *_this)
{
    delete ((const JPH::RackAndPinionConstraint *)_this);
}

void JPH_RackAndPinionConstraint_DestroyArray(const JPH_RackAndPinionConstraint *_this)
{
    delete[] ((const JPH::RackAndPinionConstraint *)_this);
}

void *Jolt_new_JPH_RackAndPinionConstraint_size_t(size_t inCount)
{
    return JPH::RackAndPinionConstraint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_RackAndPinionConstraint_void_ptr(void *inPointer)
{
    JPH::RackAndPinionConstraint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_RackAndPinionConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RackAndPinionConstraint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_RackAndPinionConstraint_size_t(size_t inCount)
{
    return JPH::RackAndPinionConstraint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_RackAndPinionConstraint_void_ptr(void *inPointer)
{
    JPH::RackAndPinionConstraint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_RackAndPinionConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RackAndPinionConstraint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_RackAndPinionConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RackAndPinionConstraint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_RackAndPinionConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RackAndPinionConstraint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_RackAndPinionConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RackAndPinionConstraint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_RackAndPinionConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RackAndPinionConstraint::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_RackAndPinionConstraint_NotifyShapeChanged(JPH_RackAndPinionConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraint *)(_this)).NotifyShapeChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inDeltaCOM ? void() : MRBINDC_THROW("Parameter `inDeltaCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaCOM))
    );
}

void JPH_RackAndPinionConstraint_SetupVelocityConstraint(JPH_RackAndPinionConstraint *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraint *)(_this)).SetupVelocityConstraint(
        inDeltaTime
    );
}

void JPH_RackAndPinionConstraint_ResetWarmStart(JPH_RackAndPinionConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraint *)(_this)).ResetWarmStart();
}

void JPH_RackAndPinionConstraint_WarmStartVelocityConstraint(JPH_RackAndPinionConstraint *_this, float inWarmStartImpulseRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraint *)(_this)).WarmStartVelocityConstraint(
        inWarmStartImpulseRatio
    );
}

bool JPH_RackAndPinionConstraint_SolveVelocityConstraint(JPH_RackAndPinionConstraint *_this, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraint *)(_this)).SolveVelocityConstraint(
        inDeltaTime
    );
}

bool JPH_RackAndPinionConstraint_SolvePositionConstraint(JPH_RackAndPinionConstraint *_this, float inDeltaTime, float inBaumgarte)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraint *)(_this)).SolvePositionConstraint(
        inDeltaTime,
        inBaumgarte
    );
}

void JPH_RackAndPinionConstraint_DrawConstraint(const JPH_RackAndPinionConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).DrawConstraint(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

JPH_Mat44 *JPH_RackAndPinionConstraint_GetConstraintToBody1Matrix(const JPH_RackAndPinionConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).GetConstraintToBody1Matrix());
}

JPH_Mat44 *JPH_RackAndPinionConstraint_GetConstraintToBody2Matrix(const JPH_RackAndPinionConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).GetConstraintToBody2Matrix());
}

void JPH_RackAndPinionConstraint_SetConstraints(JPH_RackAndPinionConstraint *_this, const JPH_Constraint *inPinion, const JPH_Constraint *inRack)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraint *)(_this)).SetConstraints(
        ((const JPH::Constraint *)inPinion),
        ((const JPH::Constraint *)inRack)
    );
}

float JPH_RackAndPinionConstraint_GetTotalLambda(const JPH_RackAndPinionConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).GetTotalLambda();
}

bool JPH_RackAndPinionConstraint_IsActive(const JPH_RackAndPinionConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).IsActive();
}

void JPH_RackAndPinionConstraint_DrawConstraintReferenceFrame(const JPH_RackAndPinionConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).DrawConstraintReferenceFrame(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

JPH_Body *JPH_RackAndPinionConstraint_GetBody1(const JPH_RackAndPinionConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).GetBody1());
}

JPH_Body *JPH_RackAndPinionConstraint_GetBody2(const JPH_RackAndPinionConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).GetBody2());
}

unsigned int JPH_RackAndPinionConstraint_GetConstraintPriority(const JPH_RackAndPinionConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).GetConstraintPriority();
}

void JPH_RackAndPinionConstraint_SetConstraintPriority(JPH_RackAndPinionConstraint *_this, unsigned int inPriority)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraint *)(_this)).SetConstraintPriority(
        inPriority
    );
}

void JPH_RackAndPinionConstraint_SetNumVelocityStepsOverride(JPH_RackAndPinionConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraint *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_RackAndPinionConstraint_GetNumVelocityStepsOverride(const JPH_RackAndPinionConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_RackAndPinionConstraint_SetNumPositionStepsOverride(JPH_RackAndPinionConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraint *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_RackAndPinionConstraint_GetNumPositionStepsOverride(const JPH_RackAndPinionConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).GetNumPositionStepsOverride();
}

void JPH_RackAndPinionConstraint_SetEnabled(JPH_RackAndPinionConstraint *_this, bool inEnabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraint *)(_this)).SetEnabled(
        inEnabled
    );
}

bool JPH_RackAndPinionConstraint_GetEnabled(const JPH_RackAndPinionConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).GetEnabled();
}

uint64_t JPH_RackAndPinionConstraint_GetUserData(const JPH_RackAndPinionConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).GetUserData();
}

void JPH_RackAndPinionConstraint_SetUserData(JPH_RackAndPinionConstraint *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraint *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_RackAndPinionConstraint_DrawConstraintLimits(const JPH_RackAndPinionConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).DrawConstraintLimits(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

float JPH_RackAndPinionConstraint_GetDrawConstraintSize(const JPH_RackAndPinionConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).GetDrawConstraintSize();
}

void JPH_RackAndPinionConstraint_SetDrawConstraintSize(JPH_RackAndPinionConstraint *_this, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RackAndPinionConstraint *)(_this)).SetDrawConstraintSize(
        inSize
    );
}

void JPH_RackAndPinionConstraint_SetEmbedded(const JPH_RackAndPinionConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).SetEmbedded();
}

unsigned int JPH_RackAndPinionConstraint_GetRefCount(const JPH_RackAndPinionConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).GetRefCount();
}

void JPH_RackAndPinionConstraint_AddRef(const JPH_RackAndPinionConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).AddRef();
}

void JPH_RackAndPinionConstraint_Release(const JPH_RackAndPinionConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RackAndPinionConstraint *)(_this)).Release();
}

int JPH_RackAndPinionConstraint_sInternalGetRefCountOffset(void)
{
    return JPH::RackAndPinionConstraint::sInternalGetRefCountOffset();
}

