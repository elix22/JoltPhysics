// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/TwoBodyConstraint.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const bool *JPH_TwoBodyConstraintSettings_Get_mEnabled(const JPH_TwoBodyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraintSettings *)(_this)).mEnabled);
}

void JPH_TwoBodyConstraintSettings_Set_mEnabled(JPH_TwoBodyConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraintSettings *)(_this)).mEnabled = value;
}

bool *JPH_TwoBodyConstraintSettings_GetMutable_mEnabled(JPH_TwoBodyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraintSettings *)(_this)).mEnabled);
}

const unsigned int *JPH_TwoBodyConstraintSettings_Get_mConstraintPriority(const JPH_TwoBodyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraintSettings *)(_this)).mConstraintPriority);
}

void JPH_TwoBodyConstraintSettings_Set_mConstraintPriority(JPH_TwoBodyConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraintSettings *)(_this)).mConstraintPriority = value;
}

unsigned int *JPH_TwoBodyConstraintSettings_GetMutable_mConstraintPriority(JPH_TwoBodyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraintSettings *)(_this)).mConstraintPriority);
}

const unsigned int *JPH_TwoBodyConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_TwoBodyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_TwoBodyConstraintSettings_Set_mNumVelocityStepsOverride(JPH_TwoBodyConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraintSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_TwoBodyConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_TwoBodyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_TwoBodyConstraintSettings_Get_mNumPositionStepsOverride(const JPH_TwoBodyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_TwoBodyConstraintSettings_Set_mNumPositionStepsOverride(JPH_TwoBodyConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraintSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_TwoBodyConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_TwoBodyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_TwoBodyConstraintSettings_Get_mDrawConstraintSize(const JPH_TwoBodyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraintSettings *)(_this)).mDrawConstraintSize);
}

void JPH_TwoBodyConstraintSettings_Set_mDrawConstraintSize(JPH_TwoBodyConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraintSettings *)(_this)).mDrawConstraintSize = value;
}

float *JPH_TwoBodyConstraintSettings_GetMutable_mDrawConstraintSize(JPH_TwoBodyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraintSettings *)(_this)).mDrawConstraintSize);
}

const uint64_t *JPH_TwoBodyConstraintSettings_Get_mUserData(const JPH_TwoBodyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraintSettings *)(_this)).mUserData);
}

void JPH_TwoBodyConstraintSettings_Set_mUserData(JPH_TwoBodyConstraintSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraintSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_TwoBodyConstraintSettings_GetMutable_mUserData(JPH_TwoBodyConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraintSettings *)(_this)).mUserData);
}

void JPH_TwoBodyConstraintSettings_Destroy(const JPH_TwoBodyConstraintSettings *_this)
{
    delete ((const JPH::TwoBodyConstraintSettings *)_this);
}

void JPH_TwoBodyConstraintSettings_DestroyArray(const JPH_TwoBodyConstraintSettings *_this)
{
    delete[] ((const JPH::TwoBodyConstraintSettings *)_this);
}

void *Jolt_new_JPH_TwoBodyConstraintSettings_size_t(size_t inCount)
{
    return JPH::TwoBodyConstraintSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TwoBodyConstraintSettings_void_ptr(void *inPointer)
{
    JPH::TwoBodyConstraintSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TwoBodyConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TwoBodyConstraintSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TwoBodyConstraintSettings_size_t(size_t inCount)
{
    return JPH::TwoBodyConstraintSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TwoBodyConstraintSettings_void_ptr(void *inPointer)
{
    JPH::TwoBodyConstraintSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TwoBodyConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TwoBodyConstraintSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TwoBodyConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TwoBodyConstraintSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TwoBodyConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TwoBodyConstraintSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TwoBodyConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TwoBodyConstraintSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TwoBodyConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TwoBodyConstraintSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_TwoBodyConstraint *JPH_TwoBodyConstraintSettings_Create(const JPH_TwoBodyConstraintSettings *_this, JPH_Body *inBody1, JPH_Body *inBody2)
{
    return (JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraintSettings *)(_this)).Create(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(JPH::Body *)(inBody2))
    ));
}

void JPH_TwoBodyConstraintSettings_SetEmbedded(const JPH_TwoBodyConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraintSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_TwoBodyConstraintSettings_GetRefCount(const JPH_TwoBodyConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraintSettings *)(_this)).GetRefCount();
}

void JPH_TwoBodyConstraintSettings_AddRef(const JPH_TwoBodyConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraintSettings *)(_this)).AddRef();
}

void JPH_TwoBodyConstraintSettings_Release(const JPH_TwoBodyConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraintSettings *)(_this)).Release();
}

int JPH_TwoBodyConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::TwoBodyConstraintSettings::sInternalGetRefCountOffset();
}

const JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_OffsetPtr(const JPH_TwoBodyConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_TwoBodyConstraintSettings *)(((const JPH::TwoBodyConstraintSettings *)ptr) + i);
}

JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_OffsetMutablePtr(JPH_TwoBodyConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_TwoBodyConstraintSettings *)(((JPH::TwoBodyConstraintSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_TwoBodyConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_TwoBodyConstraintSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_SerializableObject *JPH_TwoBodyConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_TwoBodyConstraintSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::TwoBodyConstraintSettings *)object)
    ));
}

const JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_TwoBodyConstraintSettings *)(static_cast<const JPH::TwoBodyConstraintSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_TwoBodyConstraintSettings *)(static_cast<JPH::TwoBodyConstraintSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_TwoBodyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_TwoBodyConstraintSettings *object)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<const JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((const JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_TwoBodyConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_TwoBodyConstraintSettings *object)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((JPH::TwoBodyConstraintSettings *)object)
    ));
}

const JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (const JPH_TwoBodyConstraintSettings *)(static_cast<const JPH::TwoBodyConstraintSettings *>(
        ((const JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (JPH_TwoBodyConstraintSettings *)(static_cast<JPH::TwoBodyConstraintSettings *>(
        ((JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

const JPH_ConstraintSettings *JPH_TwoBodyConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_TwoBodyConstraintSettings *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::TwoBodyConstraintSettings *)object)
    ));
}

JPH_ConstraintSettings *JPH_TwoBodyConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_TwoBodyConstraintSettings *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::TwoBodyConstraintSettings *)object)
    ));
}

const JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object)
{
    return (const JPH_TwoBodyConstraintSettings *)(static_cast<const JPH::TwoBodyConstraintSettings *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_TwoBodyConstraintSettings *JPH_TwoBodyConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object)
{
    return (JPH_TwoBodyConstraintSettings *)(static_cast<JPH::TwoBodyConstraintSettings *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

void JPH_TwoBodyConstraint_Destroy(const JPH_TwoBodyConstraint *_this)
{
    delete ((const JPH::TwoBodyConstraint *)_this);
}

void JPH_TwoBodyConstraint_DestroyArray(const JPH_TwoBodyConstraint *_this)
{
    delete[] ((const JPH::TwoBodyConstraint *)_this);
}

void *Jolt_new_JPH_TwoBodyConstraint_size_t(size_t inCount)
{
    return JPH::TwoBodyConstraint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_TwoBodyConstraint_void_ptr(void *inPointer)
{
    JPH::TwoBodyConstraint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_TwoBodyConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TwoBodyConstraint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_TwoBodyConstraint_size_t(size_t inCount)
{
    return JPH::TwoBodyConstraint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_TwoBodyConstraint_void_ptr(void *inPointer)
{
    JPH::TwoBodyConstraint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_TwoBodyConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::TwoBodyConstraint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_TwoBodyConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TwoBodyConstraint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_TwoBodyConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TwoBodyConstraint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_TwoBodyConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::TwoBodyConstraint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_TwoBodyConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::TwoBodyConstraint::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_TwoBodyConstraint_IsActive(const JPH_TwoBodyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraint *)(_this)).IsActive();
}

JPH_Body *JPH_TwoBodyConstraint_GetBody1(const JPH_TwoBodyConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraint *)(_this)).GetBody1());
}

JPH_Body *JPH_TwoBodyConstraint_GetBody2(const JPH_TwoBodyConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraint *)(_this)).GetBody2());
}

JPH_Mat44 *JPH_TwoBodyConstraint_GetConstraintToBody1Matrix(const JPH_TwoBodyConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraint *)(_this)).GetConstraintToBody1Matrix());
}

JPH_Mat44 *JPH_TwoBodyConstraint_GetConstraintToBody2Matrix(const JPH_TwoBodyConstraint *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraint *)(_this)).GetConstraintToBody2Matrix());
}

unsigned int JPH_TwoBodyConstraint_GetConstraintPriority(const JPH_TwoBodyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraint *)(_this)).GetConstraintPriority();
}

void JPH_TwoBodyConstraint_SetConstraintPriority(JPH_TwoBodyConstraint *_this, unsigned int inPriority)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraint *)(_this)).SetConstraintPriority(
        inPriority
    );
}

void JPH_TwoBodyConstraint_SetNumVelocityStepsOverride(JPH_TwoBodyConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraint *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_TwoBodyConstraint_GetNumVelocityStepsOverride(const JPH_TwoBodyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraint *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_TwoBodyConstraint_SetNumPositionStepsOverride(JPH_TwoBodyConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraint *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_TwoBodyConstraint_GetNumPositionStepsOverride(const JPH_TwoBodyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraint *)(_this)).GetNumPositionStepsOverride();
}

void JPH_TwoBodyConstraint_SetEnabled(JPH_TwoBodyConstraint *_this, bool inEnabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraint *)(_this)).SetEnabled(
        inEnabled
    );
}

bool JPH_TwoBodyConstraint_GetEnabled(const JPH_TwoBodyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraint *)(_this)).GetEnabled();
}

uint64_t JPH_TwoBodyConstraint_GetUserData(const JPH_TwoBodyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraint *)(_this)).GetUserData();
}

void JPH_TwoBodyConstraint_SetUserData(JPH_TwoBodyConstraint *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraint *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_TwoBodyConstraint_NotifyShapeChanged(JPH_TwoBodyConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraint *)(_this)).NotifyShapeChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inDeltaCOM ? void() : MRBINDC_THROW("Parameter `inDeltaCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaCOM))
    );
}

void JPH_TwoBodyConstraint_ResetWarmStart(JPH_TwoBodyConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraint *)(_this)).ResetWarmStart();
}

void JPH_TwoBodyConstraint_SetupVelocityConstraint(JPH_TwoBodyConstraint *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraint *)(_this)).SetupVelocityConstraint(
        inDeltaTime
    );
}

void JPH_TwoBodyConstraint_WarmStartVelocityConstraint(JPH_TwoBodyConstraint *_this, float inWarmStartImpulseRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraint *)(_this)).WarmStartVelocityConstraint(
        inWarmStartImpulseRatio
    );
}

bool JPH_TwoBodyConstraint_SolveVelocityConstraint(JPH_TwoBodyConstraint *_this, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraint *)(_this)).SolveVelocityConstraint(
        inDeltaTime
    );
}

bool JPH_TwoBodyConstraint_SolvePositionConstraint(JPH_TwoBodyConstraint *_this, float inDeltaTime, float inBaumgarte)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::TwoBodyConstraint *)(_this)).SolvePositionConstraint(
        inDeltaTime,
        inBaumgarte
    );
}

void JPH_TwoBodyConstraint_SetEmbedded(const JPH_TwoBodyConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraint *)(_this)).SetEmbedded();
}

unsigned int JPH_TwoBodyConstraint_GetRefCount(const JPH_TwoBodyConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraint *)(_this)).GetRefCount();
}

void JPH_TwoBodyConstraint_AddRef(const JPH_TwoBodyConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraint *)(_this)).AddRef();
}

void JPH_TwoBodyConstraint_Release(const JPH_TwoBodyConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::TwoBodyConstraint *)(_this)).Release();
}

int JPH_TwoBodyConstraint_sInternalGetRefCountOffset(void)
{
    return JPH::TwoBodyConstraint::sInternalGetRefCountOffset();
}

const JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_OffsetPtr(const JPH_TwoBodyConstraint *ptr, ptrdiff_t i)
{
    return (const JPH_TwoBodyConstraint *)(((const JPH::TwoBodyConstraint *)ptr) + i);
}

JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_OffsetMutablePtr(JPH_TwoBodyConstraint *ptr, ptrdiff_t i)
{
    return (JPH_TwoBodyConstraint *)(((JPH::TwoBodyConstraint *)ptr) + i);
}

const JPH_RefTarget_JPH_Constraint *JPH_TwoBodyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_TwoBodyConstraint *object)
{
    return (const JPH_RefTarget_JPH_Constraint *)(static_cast<const JPH::RefTarget<JPH::Constraint> *>(
        ((const JPH::TwoBodyConstraint *)object)
    ));
}

JPH_RefTarget_JPH_Constraint *JPH_TwoBodyConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_TwoBodyConstraint *object)
{
    return (JPH_RefTarget_JPH_Constraint *)(static_cast<JPH::RefTarget<JPH::Constraint> *>(
        ((JPH::TwoBodyConstraint *)object)
    ));
}

const JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object)
{
    return (const JPH_TwoBodyConstraint *)(static_cast<const JPH::TwoBodyConstraint *>(
        ((const JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object)
{
    return (JPH_TwoBodyConstraint *)(static_cast<JPH::TwoBodyConstraint *>(
        ((JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

const JPH_NonCopyable *JPH_TwoBodyConstraint_UpcastTo_JPH_NonCopyable(const JPH_TwoBodyConstraint *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::TwoBodyConstraint *)object)
    ));
}

JPH_NonCopyable *JPH_TwoBodyConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_TwoBodyConstraint *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::TwoBodyConstraint *)object)
    ));
}

const JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_TwoBodyConstraint *)(static_cast<const JPH::TwoBodyConstraint *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_TwoBodyConstraint *)(static_cast<JPH::TwoBodyConstraint *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Constraint *JPH_TwoBodyConstraint_UpcastTo_JPH_Constraint(const JPH_TwoBodyConstraint *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::TwoBodyConstraint *)object)
    ));
}

JPH_Constraint *JPH_TwoBodyConstraint_MutableUpcastTo_JPH_Constraint(JPH_TwoBodyConstraint *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::TwoBodyConstraint *)object)
    ));
}

const JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object)
{
    return (const JPH_TwoBodyConstraint *)(static_cast<const JPH::TwoBodyConstraint *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_TwoBodyConstraint *JPH_TwoBodyConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object)
{
    return (JPH_TwoBodyConstraint *)(static_cast<JPH::TwoBodyConstraint *>(
        ((JPH::Constraint *)object)
    ));
}

