// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Constraints/Constraint.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const bool *JPH_ConstraintSettings_Get_mEnabled(const JPH_ConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConstraintSettings *)(_this)).mEnabled);
}

void JPH_ConstraintSettings_Set_mEnabled(JPH_ConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConstraintSettings *)(_this)).mEnabled = value;
}

bool *JPH_ConstraintSettings_GetMutable_mEnabled(JPH_ConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConstraintSettings *)(_this)).mEnabled);
}

const unsigned int *JPH_ConstraintSettings_Get_mConstraintPriority(const JPH_ConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConstraintSettings *)(_this)).mConstraintPriority);
}

void JPH_ConstraintSettings_Set_mConstraintPriority(JPH_ConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConstraintSettings *)(_this)).mConstraintPriority = value;
}

unsigned int *JPH_ConstraintSettings_GetMutable_mConstraintPriority(JPH_ConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConstraintSettings *)(_this)).mConstraintPriority);
}

const unsigned int *JPH_ConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_ConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_ConstraintSettings_Set_mNumVelocityStepsOverride(JPH_ConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConstraintSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_ConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_ConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_ConstraintSettings_Get_mNumPositionStepsOverride(const JPH_ConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_ConstraintSettings_Set_mNumPositionStepsOverride(JPH_ConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConstraintSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_ConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_ConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_ConstraintSettings_Get_mDrawConstraintSize(const JPH_ConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConstraintSettings *)(_this)).mDrawConstraintSize);
}

void JPH_ConstraintSettings_Set_mDrawConstraintSize(JPH_ConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConstraintSettings *)(_this)).mDrawConstraintSize = value;
}

float *JPH_ConstraintSettings_GetMutable_mDrawConstraintSize(JPH_ConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConstraintSettings *)(_this)).mDrawConstraintSize);
}

const uint64_t *JPH_ConstraintSettings_Get_mUserData(const JPH_ConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConstraintSettings *)(_this)).mUserData);
}

void JPH_ConstraintSettings_Set_mUserData(JPH_ConstraintSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConstraintSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_ConstraintSettings_GetMutable_mUserData(JPH_ConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ConstraintSettings *)(_this)).mUserData);
}

void JPH_ConstraintSettings_Destroy(const JPH_ConstraintSettings *_this)
{
    delete ((const JPH::ConstraintSettings *)_this);
}

void JPH_ConstraintSettings_DestroyArray(const JPH_ConstraintSettings *_this)
{
    delete[] ((const JPH::ConstraintSettings *)_this);
}

void *Jolt_new_JPH_ConstraintSettings_size_t(size_t inCount)
{
    return JPH::ConstraintSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_ConstraintSettings_void_ptr(void *inPointer)
{
    JPH::ConstraintSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_ConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ConstraintSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_ConstraintSettings_size_t(size_t inCount)
{
    return JPH::ConstraintSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_ConstraintSettings_void_ptr(void *inPointer)
{
    JPH::ConstraintSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_ConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::ConstraintSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_ConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ConstraintSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_ConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ConstraintSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_ConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::ConstraintSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_ConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::ConstraintSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_ConstraintSettings_SetEmbedded(const JPH_ConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConstraintSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_ConstraintSettings_GetRefCount(const JPH_ConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConstraintSettings *)(_this)).GetRefCount();
}

void JPH_ConstraintSettings_AddRef(const JPH_ConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConstraintSettings *)(_this)).AddRef();
}

void JPH_ConstraintSettings_Release(const JPH_ConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ConstraintSettings *)(_this)).Release();
}

int JPH_ConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::ConstraintSettings::sInternalGetRefCountOffset();
}

const JPH_ConstraintSettings *JPH_ConstraintSettings_OffsetPtr(const JPH_ConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_ConstraintSettings *)(((const JPH::ConstraintSettings *)ptr) + i);
}

JPH_ConstraintSettings *JPH_ConstraintSettings_OffsetMutablePtr(JPH_ConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_ConstraintSettings *)(((JPH::ConstraintSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_ConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_ConstraintSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_SerializableObject *JPH_ConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_ConstraintSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

const JPH_ConstraintSettings *JPH_ConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_ConstraintSettings *JPH_ConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_ConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_ConstraintSettings *object)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<const JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_ConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_ConstraintSettings *object)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

const JPH_ConstraintSettings *JPH_ConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

JPH_ConstraintSettings *JPH_ConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

void JPH_Constraint_Destroy(const JPH_Constraint *_this)
{
    delete ((const JPH::Constraint *)_this);
}

void JPH_Constraint_DestroyArray(const JPH_Constraint *_this)
{
    delete[] ((const JPH::Constraint *)_this);
}

void *Jolt_new_JPH_Constraint_size_t(size_t inCount)
{
    return JPH::Constraint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Constraint_void_ptr(void *inPointer)
{
    JPH::Constraint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Constraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Constraint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Constraint_size_t(size_t inCount)
{
    return JPH::Constraint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Constraint_void_ptr(void *inPointer)
{
    JPH::Constraint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Constraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Constraint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Constraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Constraint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Constraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Constraint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Constraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Constraint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Constraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Constraint::operator delete[](
        inPointer,
        inPlace
    );
}

unsigned int JPH_Constraint_GetConstraintPriority(const JPH_Constraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Constraint *)(_this)).GetConstraintPriority();
}

void JPH_Constraint_SetConstraintPriority(JPH_Constraint *_this, unsigned int inPriority)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Constraint *)(_this)).SetConstraintPriority(
        inPriority
    );
}

void JPH_Constraint_SetNumVelocityStepsOverride(JPH_Constraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Constraint *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_Constraint_GetNumVelocityStepsOverride(const JPH_Constraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Constraint *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_Constraint_SetNumPositionStepsOverride(JPH_Constraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Constraint *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_Constraint_GetNumPositionStepsOverride(const JPH_Constraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Constraint *)(_this)).GetNumPositionStepsOverride();
}

void JPH_Constraint_SetEnabled(JPH_Constraint *_this, bool inEnabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Constraint *)(_this)).SetEnabled(
        inEnabled
    );
}

bool JPH_Constraint_GetEnabled(const JPH_Constraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Constraint *)(_this)).GetEnabled();
}

uint64_t JPH_Constraint_GetUserData(const JPH_Constraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Constraint *)(_this)).GetUserData();
}

void JPH_Constraint_SetUserData(JPH_Constraint *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Constraint *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_Constraint_NotifyShapeChanged(JPH_Constraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Constraint *)(_this)).NotifyShapeChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inDeltaCOM ? void() : MRBINDC_THROW("Parameter `inDeltaCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaCOM))
    );
}

void JPH_Constraint_ResetWarmStart(JPH_Constraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Constraint *)(_this)).ResetWarmStart();
}

bool JPH_Constraint_IsActive(const JPH_Constraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Constraint *)(_this)).IsActive();
}

void JPH_Constraint_SetupVelocityConstraint(JPH_Constraint *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Constraint *)(_this)).SetupVelocityConstraint(
        inDeltaTime
    );
}

void JPH_Constraint_WarmStartVelocityConstraint(JPH_Constraint *_this, float inWarmStartImpulseRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Constraint *)(_this)).WarmStartVelocityConstraint(
        inWarmStartImpulseRatio
    );
}

bool JPH_Constraint_SolveVelocityConstraint(JPH_Constraint *_this, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Constraint *)(_this)).SolveVelocityConstraint(
        inDeltaTime
    );
}

bool JPH_Constraint_SolvePositionConstraint(JPH_Constraint *_this, float inDeltaTime, float inBaumgarte)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Constraint *)(_this)).SolvePositionConstraint(
        inDeltaTime,
        inBaumgarte
    );
}

void JPH_Constraint_SetEmbedded(const JPH_Constraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Constraint *)(_this)).SetEmbedded();
}

unsigned int JPH_Constraint_GetRefCount(const JPH_Constraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Constraint *)(_this)).GetRefCount();
}

void JPH_Constraint_AddRef(const JPH_Constraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Constraint *)(_this)).AddRef();
}

void JPH_Constraint_Release(const JPH_Constraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Constraint *)(_this)).Release();
}

int JPH_Constraint_sInternalGetRefCountOffset(void)
{
    return JPH::Constraint::sInternalGetRefCountOffset();
}

const JPH_Constraint *JPH_Constraint_OffsetPtr(const JPH_Constraint *ptr, ptrdiff_t i)
{
    return (const JPH_Constraint *)(((const JPH::Constraint *)ptr) + i);
}

JPH_Constraint *JPH_Constraint_OffsetMutablePtr(JPH_Constraint *ptr, ptrdiff_t i)
{
    return (JPH_Constraint *)(((JPH::Constraint *)ptr) + i);
}

const JPH_RefTarget_JPH_Constraint *JPH_Constraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_Constraint *object)
{
    return (const JPH_RefTarget_JPH_Constraint *)(static_cast<const JPH::RefTarget<JPH::Constraint> *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_RefTarget_JPH_Constraint *JPH_Constraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_Constraint *object)
{
    return (JPH_RefTarget_JPH_Constraint *)(static_cast<JPH::RefTarget<JPH::Constraint> *>(
        ((JPH::Constraint *)object)
    ));
}

const JPH_Constraint *JPH_Constraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

JPH_Constraint *JPH_Constraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

const JPH_NonCopyable *JPH_Constraint_UpcastTo_JPH_NonCopyable(const JPH_Constraint *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_NonCopyable *JPH_Constraint_MutableUpcastTo_JPH_NonCopyable(JPH_Constraint *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::Constraint *)object)
    ));
}

const JPH_Constraint *JPH_Constraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_Constraint *JPH_Constraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::NonCopyable *)object)
    ));
}

