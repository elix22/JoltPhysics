// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/PointConstraint.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/Constraints/PointConstraint.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const bool *JPH_PointConstraintSettings_Get_mEnabled(const JPH_PointConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraintSettings *)(_this)).mEnabled);
}

void JPH_PointConstraintSettings_Set_mEnabled(JPH_PointConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraintSettings *)(_this)).mEnabled = value;
}

bool *JPH_PointConstraintSettings_GetMutable_mEnabled(JPH_PointConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraintSettings *)(_this)).mEnabled);
}

const unsigned int *JPH_PointConstraintSettings_Get_mConstraintPriority(const JPH_PointConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraintSettings *)(_this)).mConstraintPriority);
}

void JPH_PointConstraintSettings_Set_mConstraintPriority(JPH_PointConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraintSettings *)(_this)).mConstraintPriority = value;
}

unsigned int *JPH_PointConstraintSettings_GetMutable_mConstraintPriority(JPH_PointConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraintSettings *)(_this)).mConstraintPriority);
}

const unsigned int *JPH_PointConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_PointConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_PointConstraintSettings_Set_mNumVelocityStepsOverride(JPH_PointConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraintSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_PointConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_PointConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_PointConstraintSettings_Get_mNumPositionStepsOverride(const JPH_PointConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_PointConstraintSettings_Set_mNumPositionStepsOverride(JPH_PointConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraintSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_PointConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_PointConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_PointConstraintSettings_Get_mDrawConstraintSize(const JPH_PointConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraintSettings *)(_this)).mDrawConstraintSize);
}

void JPH_PointConstraintSettings_Set_mDrawConstraintSize(JPH_PointConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraintSettings *)(_this)).mDrawConstraintSize = value;
}

float *JPH_PointConstraintSettings_GetMutable_mDrawConstraintSize(JPH_PointConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraintSettings *)(_this)).mDrawConstraintSize);
}

const uint64_t *JPH_PointConstraintSettings_Get_mUserData(const JPH_PointConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraintSettings *)(_this)).mUserData);
}

void JPH_PointConstraintSettings_Set_mUserData(JPH_PointConstraintSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraintSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_PointConstraintSettings_GetMutable_mUserData(JPH_PointConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraintSettings *)(_this)).mUserData);
}

JPH_PointConstraintSettings *JPH_PointConstraintSettings_DefaultConstruct(void)
{
    return (JPH_PointConstraintSettings *)new JPH::PointConstraintSettings(JPH::PointConstraintSettings());
}

JPH_PointConstraintSettings *JPH_PointConstraintSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_PointConstraintSettings *)(new JPH::PointConstraintSettings[num_elems]{});
}

const JPH_PointConstraintSettings *JPH_PointConstraintSettings_OffsetPtr(const JPH_PointConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_PointConstraintSettings *)(((const JPH::PointConstraintSettings *)ptr) + i);
}

JPH_PointConstraintSettings *JPH_PointConstraintSettings_OffsetMutablePtr(JPH_PointConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_PointConstraintSettings *)(((JPH::PointConstraintSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_PointConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_PointConstraintSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::PointConstraintSettings *)object)
    ));
}

JPH_SerializableObject *JPH_PointConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_PointConstraintSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::PointConstraintSettings *)object)
    ));
}

const JPH_PointConstraintSettings *JPH_PointConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_PointConstraintSettings *)(static_cast<const JPH::PointConstraintSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_PointConstraintSettings *JPH_PointConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_PointConstraintSettings *)(static_cast<JPH::PointConstraintSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_PointConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_PointConstraintSettings *object)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<const JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((const JPH::PointConstraintSettings *)object)
    ));
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_PointConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_PointConstraintSettings *object)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((JPH::PointConstraintSettings *)object)
    ));
}

const JPH_PointConstraintSettings *JPH_PointConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (const JPH_PointConstraintSettings *)(static_cast<const JPH::PointConstraintSettings *>(
        ((const JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

JPH_PointConstraintSettings *JPH_PointConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (JPH_PointConstraintSettings *)(static_cast<JPH::PointConstraintSettings *>(
        ((JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

const JPH_ConstraintSettings *JPH_PointConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_PointConstraintSettings *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::PointConstraintSettings *)object)
    ));
}

JPH_ConstraintSettings *JPH_PointConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_PointConstraintSettings *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::PointConstraintSettings *)object)
    ));
}

const JPH_PointConstraintSettings *JPH_PointConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object)
{
    return (const JPH_PointConstraintSettings *)(static_cast<const JPH::PointConstraintSettings *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_PointConstraintSettings *JPH_PointConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object)
{
    return (JPH_PointConstraintSettings *)(static_cast<JPH::PointConstraintSettings *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

const JPH_TwoBodyConstraintSettings *JPH_PointConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(const JPH_PointConstraintSettings *object)
{
    return (const JPH_TwoBodyConstraintSettings *)(static_cast<const JPH::TwoBodyConstraintSettings *>(
        ((const JPH::PointConstraintSettings *)object)
    ));
}

JPH_TwoBodyConstraintSettings *JPH_PointConstraintSettings_MutableUpcastTo_JPH_TwoBodyConstraintSettings(JPH_PointConstraintSettings *object)
{
    return (JPH_TwoBodyConstraintSettings *)(static_cast<JPH::TwoBodyConstraintSettings *>(
        ((JPH::PointConstraintSettings *)object)
    ));
}

const JPH_PointConstraintSettings *JPH_PointConstraintSettings_StaticDowncastFrom_JPH_TwoBodyConstraintSettings(const JPH_TwoBodyConstraintSettings *object)
{
    return (const JPH_PointConstraintSettings *)(static_cast<const JPH::PointConstraintSettings *>(
        ((const JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_PointConstraintSettings *JPH_PointConstraintSettings_MutableStaticDowncastFrom_JPH_TwoBodyConstraintSettings(JPH_TwoBodyConstraintSettings *object)
{
    return (JPH_PointConstraintSettings *)(static_cast<JPH::PointConstraintSettings *>(
        ((JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_PointConstraintSettings *JPH_PointConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_PointConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::PointConstraintSettings);
    return (JPH_PointConstraintSettings *)new JPH::PointConstraintSettings(JPH::PointConstraintSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::PointConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::PointConstraintSettings), JPH::PointConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::PointConstraintSettings), JPH::PointConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::PointConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::PointConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::PointConstraintSettings))
    ));
}

void JPH_PointConstraintSettings_Destroy(const JPH_PointConstraintSettings *_this)
{
    delete ((const JPH::PointConstraintSettings *)_this);
}

void JPH_PointConstraintSettings_DestroyArray(const JPH_PointConstraintSettings *_this)
{
    delete[] ((const JPH::PointConstraintSettings *)_this);
}

JPH_PointConstraintSettings *JPH_PointConstraintSettings_AssignFromAnother(JPH_PointConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_PointConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::PointConstraintSettings);
    return (JPH_PointConstraintSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraintSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::PointConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::PointConstraintSettings), JPH::PointConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::PointConstraintSettings), JPH::PointConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::PointConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::PointConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::PointConstraintSettings))
    ));
}

void *Jolt_new_JPH_PointConstraintSettings_unsigned_long(unsigned long inCount)
{
    return JPH::PointConstraintSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_PointConstraintSettings_void_ptr(void *inPointer)
{
    JPH::PointConstraintSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_PointConstraintSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize)
{
    JPH::PointConstraintSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_PointConstraintSettings_unsigned_long(unsigned long inCount)
{
    return JPH::PointConstraintSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_PointConstraintSettings_void_ptr(void *inPointer)
{
    JPH::PointConstraintSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_PointConstraintSettings_void_ptr_unsigned_long(void *inPointer, unsigned long inSize)
{
    JPH::PointConstraintSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_PointConstraintSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::PointConstraintSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_PointConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PointConstraintSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_PointConstraintSettings_unsigned_long_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::PointConstraintSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_PointConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PointConstraintSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_TwoBodyConstraint *JPH_PointConstraintSettings_Create(const JPH_PointConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2)
{
    return (JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraintSettings *)(_this)).Create(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2))
    ));
}

void JPH_PointConstraintSettings_SetEmbedded(const JPH_PointConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraintSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_PointConstraintSettings_GetRefCount(const JPH_PointConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraintSettings *)(_this)).GetRefCount();
}

void JPH_PointConstraintSettings_AddRef(const JPH_PointConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraintSettings *)(_this)).AddRef();
}

void JPH_PointConstraintSettings_Release(const JPH_PointConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraintSettings *)(_this)).Release();
}

int JPH_PointConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::PointConstraintSettings::sInternalGetRefCountOffset();
}

JPH_PointConstraint *JPH_PointConstraint_Construct(JPH_Body *inBody1, JPH_Body *inBody2, const JPH_PointConstraintSettings *inSettings)
{
    return (JPH_PointConstraint *)new JPH::PointConstraint(JPH::PointConstraint(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::PointConstraintSettings *)(inSettings))
    ));
}

const JPH_PointConstraint *JPH_PointConstraint_OffsetPtr(const JPH_PointConstraint *ptr, ptrdiff_t i)
{
    return (const JPH_PointConstraint *)(((const JPH::PointConstraint *)ptr) + i);
}

JPH_PointConstraint *JPH_PointConstraint_OffsetMutablePtr(JPH_PointConstraint *ptr, ptrdiff_t i)
{
    return (JPH_PointConstraint *)(((JPH::PointConstraint *)ptr) + i);
}

const JPH_RefTarget_JPH_Constraint *JPH_PointConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_PointConstraint *object)
{
    return (const JPH_RefTarget_JPH_Constraint *)(static_cast<const JPH::RefTarget<JPH::Constraint> *>(
        ((const JPH::PointConstraint *)object)
    ));
}

JPH_RefTarget_JPH_Constraint *JPH_PointConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_PointConstraint *object)
{
    return (JPH_RefTarget_JPH_Constraint *)(static_cast<JPH::RefTarget<JPH::Constraint> *>(
        ((JPH::PointConstraint *)object)
    ));
}

const JPH_PointConstraint *JPH_PointConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object)
{
    return (const JPH_PointConstraint *)(static_cast<const JPH::PointConstraint *>(
        ((const JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

JPH_PointConstraint *JPH_PointConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object)
{
    return (JPH_PointConstraint *)(static_cast<JPH::PointConstraint *>(
        ((JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

const JPH_NonCopyable *JPH_PointConstraint_UpcastTo_JPH_NonCopyable(const JPH_PointConstraint *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::PointConstraint *)object)
    ));
}

JPH_NonCopyable *JPH_PointConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_PointConstraint *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::PointConstraint *)object)
    ));
}

const JPH_PointConstraint *JPH_PointConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_PointConstraint *)(static_cast<const JPH::PointConstraint *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_PointConstraint *JPH_PointConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_PointConstraint *)(static_cast<JPH::PointConstraint *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Constraint *JPH_PointConstraint_UpcastTo_JPH_Constraint(const JPH_PointConstraint *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::PointConstraint *)object)
    ));
}

JPH_Constraint *JPH_PointConstraint_MutableUpcastTo_JPH_Constraint(JPH_PointConstraint *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::PointConstraint *)object)
    ));
}

const JPH_PointConstraint *JPH_PointConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object)
{
    return (const JPH_PointConstraint *)(static_cast<const JPH::PointConstraint *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_PointConstraint *JPH_PointConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object)
{
    return (JPH_PointConstraint *)(static_cast<JPH::PointConstraint *>(
        ((JPH::Constraint *)object)
    ));
}

const JPH_TwoBodyConstraint *JPH_PointConstraint_UpcastTo_JPH_TwoBodyConstraint(const JPH_PointConstraint *object)
{
    return (const JPH_TwoBodyConstraint *)(static_cast<const JPH::TwoBodyConstraint *>(
        ((const JPH::PointConstraint *)object)
    ));
}

JPH_TwoBodyConstraint *JPH_PointConstraint_MutableUpcastTo_JPH_TwoBodyConstraint(JPH_PointConstraint *object)
{
    return (JPH_TwoBodyConstraint *)(static_cast<JPH::TwoBodyConstraint *>(
        ((JPH::PointConstraint *)object)
    ));
}

const JPH_PointConstraint *JPH_PointConstraint_StaticDowncastFrom_JPH_TwoBodyConstraint(const JPH_TwoBodyConstraint *object)
{
    return (const JPH_PointConstraint *)(static_cast<const JPH::PointConstraint *>(
        ((const JPH::TwoBodyConstraint *)object)
    ));
}

JPH_PointConstraint *JPH_PointConstraint_MutableStaticDowncastFrom_JPH_TwoBodyConstraint(JPH_TwoBodyConstraint *object)
{
    return (JPH_PointConstraint *)(static_cast<JPH::PointConstraint *>(
        ((JPH::TwoBodyConstraint *)object)
    ));
}

void JPH_PointConstraint_Destroy(const JPH_PointConstraint *_this)
{
    delete ((const JPH::PointConstraint *)_this);
}

void JPH_PointConstraint_DestroyArray(const JPH_PointConstraint *_this)
{
    delete[] ((const JPH::PointConstraint *)_this);
}

void *Jolt_new_JPH_PointConstraint_unsigned_long(unsigned long inCount)
{
    return JPH::PointConstraint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_PointConstraint_void_ptr(void *inPointer)
{
    JPH::PointConstraint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_PointConstraint_void_ptr_unsigned_long(void *inPointer, unsigned long inSize)
{
    JPH::PointConstraint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_PointConstraint_unsigned_long(unsigned long inCount)
{
    return JPH::PointConstraint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_PointConstraint_void_ptr(void *inPointer)
{
    JPH::PointConstraint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_PointConstraint_void_ptr_unsigned_long(void *inPointer, unsigned long inSize)
{
    JPH::PointConstraint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_PointConstraint_unsigned_long_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::PointConstraint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_PointConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PointConstraint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_PointConstraint_unsigned_long_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::PointConstraint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_PointConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PointConstraint::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_PointConstraint_SetupVelocityConstraint(JPH_PointConstraint *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraint *)(_this)).SetupVelocityConstraint(
        inDeltaTime
    );
}

void JPH_PointConstraint_ResetWarmStart(JPH_PointConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraint *)(_this)).ResetWarmStart();
}

void JPH_PointConstraint_WarmStartVelocityConstraint(JPH_PointConstraint *_this, float inWarmStartImpulseRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraint *)(_this)).WarmStartVelocityConstraint(
        inWarmStartImpulseRatio
    );
}

bool JPH_PointConstraint_SolveVelocityConstraint(JPH_PointConstraint *_this, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraint *)(_this)).SolveVelocityConstraint(
        inDeltaTime
    );
}

bool JPH_PointConstraint_SolvePositionConstraint(JPH_PointConstraint *_this, float inDeltaTime, float inBaumgarte)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraint *)(_this)).SolvePositionConstraint(
        inDeltaTime,
        inBaumgarte
    );
}

bool JPH_PointConstraint_IsActive(const JPH_PointConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraint *)(_this)).IsActive();
}

JPH_Body *JPH_PointConstraint_GetBody1(const JPH_PointConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraint *)(_this)).GetBody1());
}

JPH_Body *JPH_PointConstraint_GetBody2(const JPH_PointConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraint *)(_this)).GetBody2());
}

unsigned int JPH_PointConstraint_GetConstraintPriority(const JPH_PointConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraint *)(_this)).GetConstraintPriority();
}

void JPH_PointConstraint_SetConstraintPriority(JPH_PointConstraint *_this, unsigned int inPriority)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraint *)(_this)).SetConstraintPriority(
        inPriority
    );
}

void JPH_PointConstraint_SetNumVelocityStepsOverride(JPH_PointConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraint *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_PointConstraint_GetNumVelocityStepsOverride(const JPH_PointConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraint *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_PointConstraint_SetNumPositionStepsOverride(JPH_PointConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraint *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_PointConstraint_GetNumPositionStepsOverride(const JPH_PointConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraint *)(_this)).GetNumPositionStepsOverride();
}

void JPH_PointConstraint_SetEnabled(JPH_PointConstraint *_this, bool inEnabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraint *)(_this)).SetEnabled(
        inEnabled
    );
}

bool JPH_PointConstraint_GetEnabled(const JPH_PointConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraint *)(_this)).GetEnabled();
}

uint64_t JPH_PointConstraint_GetUserData(const JPH_PointConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraint *)(_this)).GetUserData();
}

void JPH_PointConstraint_SetUserData(JPH_PointConstraint *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PointConstraint *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_PointConstraint_SetEmbedded(const JPH_PointConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraint *)(_this)).SetEmbedded();
}

unsigned int JPH_PointConstraint_GetRefCount(const JPH_PointConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraint *)(_this)).GetRefCount();
}

void JPH_PointConstraint_AddRef(const JPH_PointConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraint *)(_this)).AddRef();
}

void JPH_PointConstraint_Release(const JPH_PointConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PointConstraint *)(_this)).Release();
}

int JPH_PointConstraint_sInternalGetRefCountOffset(void)
{
    return JPH::PointConstraint::sInternalGetRefCountOffset();
}

