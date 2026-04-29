// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Character/CharacterVirtual.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Core/TempAllocator.h>
#include <Jolt/Geometry/Plane.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyFilter.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Body/MotionType.h>
#include <Jolt/Physics/Character/CharacterBase.h>
#include <Jolt/Physics/Character/CharacterID.h>
#include <Jolt/Physics/Character/CharacterVirtual.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>
#include <Jolt/Physics/Collision/ObjectLayer.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/ShapeFilter.h>
#include <Jolt/Physics/PhysicsSystem.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const JPH_CharacterID *JPH_CharacterVirtualSettings_Get_mID(const JPH_CharacterVirtualSettings *_this)
{
    return (const JPH_CharacterID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mID);
}

void JPH_CharacterVirtualSettings_Set_mID(JPH_CharacterVirtualSettings *_this, const JPH_CharacterID *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mID = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::CharacterID(*(JPH::CharacterID *)value));
}

JPH_CharacterID *JPH_CharacterVirtualSettings_GetMutable_mID(JPH_CharacterVirtualSettings *_this)
{
    return (JPH_CharacterID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mID);
}

const float *JPH_CharacterVirtualSettings_Get_mMass(const JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mMass);
}

void JPH_CharacterVirtualSettings_Set_mMass(JPH_CharacterVirtualSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mMass = value;
}

float *JPH_CharacterVirtualSettings_GetMutable_mMass(JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mMass);
}

const float *JPH_CharacterVirtualSettings_Get_mMaxStrength(const JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mMaxStrength);
}

void JPH_CharacterVirtualSettings_Set_mMaxStrength(JPH_CharacterVirtualSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mMaxStrength = value;
}

float *JPH_CharacterVirtualSettings_GetMutable_mMaxStrength(JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mMaxStrength);
}

const JPH_Vec3 *JPH_CharacterVirtualSettings_Get_mShapeOffset(const JPH_CharacterVirtualSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mShapeOffset);
}

JPH_Vec3 *JPH_CharacterVirtualSettings_GetMutable_mShapeOffset(JPH_CharacterVirtualSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mShapeOffset);
}

const float *JPH_CharacterVirtualSettings_Get_mPredictiveContactDistance(const JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mPredictiveContactDistance);
}

void JPH_CharacterVirtualSettings_Set_mPredictiveContactDistance(JPH_CharacterVirtualSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mPredictiveContactDistance = value;
}

float *JPH_CharacterVirtualSettings_GetMutable_mPredictiveContactDistance(JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mPredictiveContactDistance);
}

const unsigned int *JPH_CharacterVirtualSettings_Get_mMaxCollisionIterations(const JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mMaxCollisionIterations);
}

void JPH_CharacterVirtualSettings_Set_mMaxCollisionIterations(JPH_CharacterVirtualSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mMaxCollisionIterations = value;
}

unsigned int *JPH_CharacterVirtualSettings_GetMutable_mMaxCollisionIterations(JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mMaxCollisionIterations);
}

const unsigned int *JPH_CharacterVirtualSettings_Get_mMaxConstraintIterations(const JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mMaxConstraintIterations);
}

void JPH_CharacterVirtualSettings_Set_mMaxConstraintIterations(JPH_CharacterVirtualSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mMaxConstraintIterations = value;
}

unsigned int *JPH_CharacterVirtualSettings_GetMutable_mMaxConstraintIterations(JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mMaxConstraintIterations);
}

const float *JPH_CharacterVirtualSettings_Get_mMinTimeRemaining(const JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mMinTimeRemaining);
}

void JPH_CharacterVirtualSettings_Set_mMinTimeRemaining(JPH_CharacterVirtualSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mMinTimeRemaining = value;
}

float *JPH_CharacterVirtualSettings_GetMutable_mMinTimeRemaining(JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mMinTimeRemaining);
}

const float *JPH_CharacterVirtualSettings_Get_mCollisionTolerance(const JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mCollisionTolerance);
}

void JPH_CharacterVirtualSettings_Set_mCollisionTolerance(JPH_CharacterVirtualSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mCollisionTolerance = value;
}

float *JPH_CharacterVirtualSettings_GetMutable_mCollisionTolerance(JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mCollisionTolerance);
}

const float *JPH_CharacterVirtualSettings_Get_mCharacterPadding(const JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mCharacterPadding);
}

void JPH_CharacterVirtualSettings_Set_mCharacterPadding(JPH_CharacterVirtualSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mCharacterPadding = value;
}

float *JPH_CharacterVirtualSettings_GetMutable_mCharacterPadding(JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mCharacterPadding);
}

const unsigned int *JPH_CharacterVirtualSettings_Get_mMaxNumHits(const JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mMaxNumHits);
}

void JPH_CharacterVirtualSettings_Set_mMaxNumHits(JPH_CharacterVirtualSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mMaxNumHits = value;
}

unsigned int *JPH_CharacterVirtualSettings_GetMutable_mMaxNumHits(JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mMaxNumHits);
}

const float *JPH_CharacterVirtualSettings_Get_mHitReductionCosMaxAngle(const JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mHitReductionCosMaxAngle);
}

void JPH_CharacterVirtualSettings_Set_mHitReductionCosMaxAngle(JPH_CharacterVirtualSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mHitReductionCosMaxAngle = value;
}

float *JPH_CharacterVirtualSettings_GetMutable_mHitReductionCosMaxAngle(JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mHitReductionCosMaxAngle);
}

const float *JPH_CharacterVirtualSettings_Get_mPenetrationRecoverySpeed(const JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mPenetrationRecoverySpeed);
}

void JPH_CharacterVirtualSettings_Set_mPenetrationRecoverySpeed(JPH_CharacterVirtualSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mPenetrationRecoverySpeed = value;
}

float *JPH_CharacterVirtualSettings_GetMutable_mPenetrationRecoverySpeed(JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mPenetrationRecoverySpeed);
}

const JPH_BodyID *JPH_CharacterVirtualSettings_Get_mInnerBodyIDOverride(const JPH_CharacterVirtualSettings *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mInnerBodyIDOverride);
}

void JPH_CharacterVirtualSettings_Set_mInnerBodyIDOverride(JPH_CharacterVirtualSettings *_this, JPH_BodyID value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mInnerBodyIDOverride = MRBINDC_BIT_CAST((JPH::BodyID), value);
}

JPH_BodyID *JPH_CharacterVirtualSettings_GetMutable_mInnerBodyIDOverride(JPH_CharacterVirtualSettings *_this)
{
    return (JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mInnerBodyIDOverride);
}

const unsigned short *JPH_CharacterVirtualSettings_Get_mInnerBodyLayer(const JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mInnerBodyLayer);
}

void JPH_CharacterVirtualSettings_Set_mInnerBodyLayer(JPH_CharacterVirtualSettings *_this, unsigned short value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mInnerBodyLayer = value;
}

unsigned short *JPH_CharacterVirtualSettings_GetMutable_mInnerBodyLayer(JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mInnerBodyLayer);
}

const JPH_Vec3 *JPH_CharacterVirtualSettings_Get_mUp(const JPH_CharacterVirtualSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mUp);
}

JPH_Vec3 *JPH_CharacterVirtualSettings_GetMutable_mUp(JPH_CharacterVirtualSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mUp);
}

const JPH_Plane *JPH_CharacterVirtualSettings_Get_mSupportingVolume(const JPH_CharacterVirtualSettings *_this)
{
    return (const JPH_Plane *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mSupportingVolume);
}

void JPH_CharacterVirtualSettings_Set_mSupportingVolume(JPH_CharacterVirtualSettings *_this, const JPH_Plane *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mSupportingVolume = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::Plane(*(JPH::Plane *)value));
}

JPH_Plane *JPH_CharacterVirtualSettings_GetMutable_mSupportingVolume(JPH_CharacterVirtualSettings *_this)
{
    return (JPH_Plane *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mSupportingVolume);
}

const float *JPH_CharacterVirtualSettings_Get_mMaxSlopeAngle(const JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mMaxSlopeAngle);
}

void JPH_CharacterVirtualSettings_Set_mMaxSlopeAngle(JPH_CharacterVirtualSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mMaxSlopeAngle = value;
}

float *JPH_CharacterVirtualSettings_GetMutable_mMaxSlopeAngle(JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mMaxSlopeAngle);
}

const bool *JPH_CharacterVirtualSettings_Get_mEnhancedInternalEdgeRemoval(const JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).mEnhancedInternalEdgeRemoval);
}

void JPH_CharacterVirtualSettings_Set_mEnhancedInternalEdgeRemoval(JPH_CharacterVirtualSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mEnhancedInternalEdgeRemoval = value;
}

bool *JPH_CharacterVirtualSettings_GetMutable_mEnhancedInternalEdgeRemoval(JPH_CharacterVirtualSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).mEnhancedInternalEdgeRemoval);
}

JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_DefaultConstruct(void)
{
    return (JPH_CharacterVirtualSettings *)new JPH::CharacterVirtualSettings(JPH::CharacterVirtualSettings());
}

JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CharacterVirtualSettings *)(new JPH::CharacterVirtualSettings[num_elems]{});
}

const JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_OffsetPtr(const JPH_CharacterVirtualSettings *ptr, ptrdiff_t i)
{
    return (const JPH_CharacterVirtualSettings *)(((const JPH::CharacterVirtualSettings *)ptr) + i);
}

JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_OffsetMutablePtr(JPH_CharacterVirtualSettings *ptr, ptrdiff_t i)
{
    return (JPH_CharacterVirtualSettings *)(((JPH::CharacterVirtualSettings *)ptr) + i);
}

const JPH_RefTarget_JPH_CharacterBaseSettings *JPH_CharacterVirtualSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(const JPH_CharacterVirtualSettings *object)
{
    return (const JPH_RefTarget_JPH_CharacterBaseSettings *)(static_cast<const JPH::RefTarget<JPH::CharacterBaseSettings> *>(
        ((const JPH::CharacterVirtualSettings *)object)
    ));
}

JPH_RefTarget_JPH_CharacterBaseSettings *JPH_CharacterVirtualSettings_MutableUpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(JPH_CharacterVirtualSettings *object)
{
    return (JPH_RefTarget_JPH_CharacterBaseSettings *)(static_cast<JPH::RefTarget<JPH::CharacterBaseSettings> *>(
        ((JPH::CharacterVirtualSettings *)object)
    ));
}

const JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(const JPH_RefTarget_JPH_CharacterBaseSettings *object)
{
    return (const JPH_CharacterVirtualSettings *)(static_cast<const JPH::CharacterVirtualSettings *>(
        ((const JPH::RefTarget<JPH::CharacterBaseSettings> *)object)
    ));
}

JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(JPH_RefTarget_JPH_CharacterBaseSettings *object)
{
    return (JPH_CharacterVirtualSettings *)(static_cast<JPH::CharacterVirtualSettings *>(
        ((JPH::RefTarget<JPH::CharacterBaseSettings> *)object)
    ));
}

const JPH_CharacterBaseSettings *JPH_CharacterVirtualSettings_UpcastTo_JPH_CharacterBaseSettings(const JPH_CharacterVirtualSettings *object)
{
    return (const JPH_CharacterBaseSettings *)(static_cast<const JPH::CharacterBaseSettings *>(
        ((const JPH::CharacterVirtualSettings *)object)
    ));
}

JPH_CharacterBaseSettings *JPH_CharacterVirtualSettings_MutableUpcastTo_JPH_CharacterBaseSettings(JPH_CharacterVirtualSettings *object)
{
    return (JPH_CharacterBaseSettings *)(static_cast<JPH::CharacterBaseSettings *>(
        ((JPH::CharacterVirtualSettings *)object)
    ));
}

const JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_StaticDowncastFrom_JPH_CharacterBaseSettings(const JPH_CharacterBaseSettings *object)
{
    return (const JPH_CharacterVirtualSettings *)(static_cast<const JPH::CharacterVirtualSettings *>(
        ((const JPH::CharacterBaseSettings *)object)
    ));
}

JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_MutableStaticDowncastFrom_JPH_CharacterBaseSettings(JPH_CharacterBaseSettings *object)
{
    return (JPH_CharacterVirtualSettings *)(static_cast<JPH::CharacterVirtualSettings *>(
        ((JPH::CharacterBaseSettings *)object)
    ));
}

JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CharacterVirtualSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CharacterVirtualSettings);
    return (JPH_CharacterVirtualSettings *)new JPH::CharacterVirtualSettings(JPH::CharacterVirtualSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CharacterVirtualSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::CharacterVirtualSettings), JPH::CharacterVirtualSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CharacterVirtualSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CharacterVirtualSettings) MRBINDC_CLASSARG_END(_other, JPH::CharacterVirtualSettings))
    ));
}

void JPH_CharacterVirtualSettings_Destroy(const JPH_CharacterVirtualSettings *_this)
{
    delete ((const JPH::CharacterVirtualSettings *)_this);
}

void JPH_CharacterVirtualSettings_DestroyArray(const JPH_CharacterVirtualSettings *_this)
{
    delete[] ((const JPH::CharacterVirtualSettings *)_this);
}

JPH_CharacterVirtualSettings *JPH_CharacterVirtualSettings_AssignFromAnother(JPH_CharacterVirtualSettings *_this, Jolt_PassBy _other_pass_by, JPH_CharacterVirtualSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CharacterVirtualSettings);
    return (JPH_CharacterVirtualSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtualSettings *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CharacterVirtualSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::CharacterVirtualSettings), JPH::CharacterVirtualSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CharacterVirtualSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CharacterVirtualSettings) MRBINDC_CLASSARG_END(_other, JPH::CharacterVirtualSettings)))
    ));
}

void *Jolt_new_JPH_CharacterVirtualSettings_size_t(size_t inCount)
{
    return JPH::CharacterVirtualSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CharacterVirtualSettings_void_ptr(void *inPointer)
{
    JPH::CharacterVirtualSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CharacterVirtualSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CharacterVirtualSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CharacterVirtualSettings_size_t(size_t inCount)
{
    return JPH::CharacterVirtualSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr(void *inPointer)
{
    JPH::CharacterVirtualSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CharacterVirtualSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CharacterVirtualSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CharacterVirtualSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CharacterVirtualSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CharacterVirtualSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CharacterVirtualSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CharacterVirtualSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CharacterVirtualSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_CharacterVirtualSettings_SetEmbedded(const JPH_CharacterVirtualSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_CharacterVirtualSettings_GetRefCount(const JPH_CharacterVirtualSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).GetRefCount();
}

void JPH_CharacterVirtualSettings_AddRef(const JPH_CharacterVirtualSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).AddRef();
}

void JPH_CharacterVirtualSettings_Release(const JPH_CharacterVirtualSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtualSettings *)(_this)).Release();
}

int JPH_CharacterVirtualSettings_sInternalGetRefCountOffset(void)
{
    return JPH::CharacterVirtualSettings::sInternalGetRefCountOffset();
}

const bool *JPH_CharacterContactSettings_Get_mCanPushCharacter(const JPH_CharacterContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterContactSettings *)(_this)).mCanPushCharacter);
}

void JPH_CharacterContactSettings_Set_mCanPushCharacter(JPH_CharacterContactSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactSettings *)(_this)).mCanPushCharacter = value;
}

bool *JPH_CharacterContactSettings_GetMutable_mCanPushCharacter(JPH_CharacterContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactSettings *)(_this)).mCanPushCharacter);
}

const bool *JPH_CharacterContactSettings_Get_mCanReceiveImpulses(const JPH_CharacterContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterContactSettings *)(_this)).mCanReceiveImpulses);
}

void JPH_CharacterContactSettings_Set_mCanReceiveImpulses(JPH_CharacterContactSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactSettings *)(_this)).mCanReceiveImpulses = value;
}

bool *JPH_CharacterContactSettings_GetMutable_mCanReceiveImpulses(JPH_CharacterContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactSettings *)(_this)).mCanReceiveImpulses);
}

JPH_CharacterContactSettings *JPH_CharacterContactSettings_DefaultConstruct(void)
{
    return (JPH_CharacterContactSettings *)new JPH::CharacterContactSettings(JPH::CharacterContactSettings());
}

JPH_CharacterContactSettings *JPH_CharacterContactSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CharacterContactSettings *)(new JPH::CharacterContactSettings[num_elems]{});
}

JPH_CharacterContactSettings *JPH_CharacterContactSettings_ConstructFrom(bool mCanPushCharacter, bool mCanReceiveImpulses)
{
    return (JPH_CharacterContactSettings *)new JPH::CharacterContactSettings(JPH::CharacterContactSettings{
        mCanPushCharacter,
        mCanReceiveImpulses
    });
}

const JPH_CharacterContactSettings *JPH_CharacterContactSettings_OffsetPtr(const JPH_CharacterContactSettings *ptr, ptrdiff_t i)
{
    return (const JPH_CharacterContactSettings *)(((const JPH::CharacterContactSettings *)ptr) + i);
}

JPH_CharacterContactSettings *JPH_CharacterContactSettings_OffsetMutablePtr(JPH_CharacterContactSettings *ptr, ptrdiff_t i)
{
    return (JPH_CharacterContactSettings *)(((JPH::CharacterContactSettings *)ptr) + i);
}

JPH_CharacterContactSettings *JPH_CharacterContactSettings_ConstructFromAnother(const JPH_CharacterContactSettings *_other)
{
    return (JPH_CharacterContactSettings *)new JPH::CharacterContactSettings(JPH::CharacterContactSettings(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::CharacterContactSettings(*(JPH::CharacterContactSettings *)_other))
    ));
}

void JPH_CharacterContactSettings_Destroy(const JPH_CharacterContactSettings *_this)
{
    delete ((const JPH::CharacterContactSettings *)_this);
}

void JPH_CharacterContactSettings_DestroyArray(const JPH_CharacterContactSettings *_this)
{
    delete[] ((const JPH::CharacterContactSettings *)_this);
}

JPH_CharacterContactSettings *JPH_CharacterContactSettings_AssignFromAnother(JPH_CharacterContactSettings *_this, const JPH_CharacterContactSettings *_other)
{
    return (JPH_CharacterContactSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactSettings *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::CharacterContactSettings(*(JPH::CharacterContactSettings *)_other))
    ));
}

JPH_CharacterContactListener *JPH_CharacterContactListener_DefaultConstruct(void)
{
    return (JPH_CharacterContactListener *)new JPH::CharacterContactListener(JPH::CharacterContactListener());
}

JPH_CharacterContactListener *JPH_CharacterContactListener_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CharacterContactListener *)(new JPH::CharacterContactListener[num_elems]{});
}

const JPH_CharacterContactListener *JPH_CharacterContactListener_OffsetPtr(const JPH_CharacterContactListener *ptr, ptrdiff_t i)
{
    return (const JPH_CharacterContactListener *)(((const JPH::CharacterContactListener *)ptr) + i);
}

JPH_CharacterContactListener *JPH_CharacterContactListener_OffsetMutablePtr(JPH_CharacterContactListener *ptr, ptrdiff_t i)
{
    return (JPH_CharacterContactListener *)(((JPH::CharacterContactListener *)ptr) + i);
}

JPH_CharacterContactListener *JPH_CharacterContactListener_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CharacterContactListener *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CharacterContactListener);
    return (JPH_CharacterContactListener *)new JPH::CharacterContactListener(JPH::CharacterContactListener(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CharacterContactListener) MRBINDC_CLASSARG_COPY(_other, (JPH::CharacterContactListener), JPH::CharacterContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CharacterContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CharacterContactListener) MRBINDC_CLASSARG_END(_other, JPH::CharacterContactListener))
    ));
}

void JPH_CharacterContactListener_Destroy(const JPH_CharacterContactListener *_this)
{
    delete ((const JPH::CharacterContactListener *)_this);
}

void JPH_CharacterContactListener_DestroyArray(const JPH_CharacterContactListener *_this)
{
    delete[] ((const JPH::CharacterContactListener *)_this);
}

JPH_CharacterContactListener *JPH_CharacterContactListener_AssignFromAnother(JPH_CharacterContactListener *_this, Jolt_PassBy _other_pass_by, JPH_CharacterContactListener *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CharacterContactListener);
    return (JPH_CharacterContactListener *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactListener *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CharacterContactListener) MRBINDC_CLASSARG_COPY(_other, (JPH::CharacterContactListener), JPH::CharacterContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CharacterContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CharacterContactListener) MRBINDC_CLASSARG_END(_other, JPH::CharacterContactListener)))
    ));
}

void JPH_CharacterContactListener_OnAdjustBodyVelocity(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_Body *inBody2, JPH_Vec3 *ioLinearVelocity, JPH_Vec3 *ioAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactListener *)(_this)).OnAdjustBodyVelocity(
        ((const JPH::CharacterVirtual *)inCharacter),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2)),
        ((ioLinearVelocity ? void() : MRBINDC_THROW("Parameter `ioLinearVelocity` can not be null.", void)), *(JPH::Vec3 *)(ioLinearVelocity)),
        ((ioAngularVelocity ? void() : MRBINDC_THROW("Parameter `ioAngularVelocity` can not be null.", void)), *(JPH::Vec3 *)(ioAngularVelocity))
    );
}

bool JPH_CharacterContactListener_OnContactValidate(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_BodyID *inBodyID2, const JPH_SubShapeID *inSubShapeID2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactListener *)(_this)).OnContactValidate(
        ((const JPH::CharacterVirtual *)inCharacter),
        ((inBodyID2 ? void() : MRBINDC_THROW("Parameter `inBodyID2` can not be null.", void)), *(const JPH::BodyID *)(inBodyID2)),
        ((inSubShapeID2 ? void() : MRBINDC_THROW("Parameter `inSubShapeID2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID2))
    );
}

bool JPH_CharacterContactListener_OnCharacterContactValidate(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_CharacterVirtual *inOtherCharacter, const JPH_SubShapeID *inSubShapeID2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactListener *)(_this)).OnCharacterContactValidate(
        ((const JPH::CharacterVirtual *)inCharacter),
        ((const JPH::CharacterVirtual *)inOtherCharacter),
        ((inSubShapeID2 ? void() : MRBINDC_THROW("Parameter `inSubShapeID2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID2))
    );
}

void JPH_CharacterContactListener_OnContactAdded(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_BodyID *inBodyID2, const JPH_SubShapeID *inSubShapeID2, const JPH_Vec3 *inContactPosition, const JPH_Vec3 *inContactNormal, JPH_CharacterContactSettings *ioSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactListener *)(_this)).OnContactAdded(
        ((const JPH::CharacterVirtual *)inCharacter),
        ((inBodyID2 ? void() : MRBINDC_THROW("Parameter `inBodyID2` can not be null.", void)), *(const JPH::BodyID *)(inBodyID2)),
        ((inSubShapeID2 ? void() : MRBINDC_THROW("Parameter `inSubShapeID2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID2)),
        ((inContactPosition ? void() : MRBINDC_THROW("Parameter `inContactPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactPosition)),
        ((inContactNormal ? void() : MRBINDC_THROW("Parameter `inContactNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactNormal)),
        ((ioSettings ? void() : MRBINDC_THROW("Parameter `ioSettings` can not be null.", void)), *(JPH::CharacterContactSettings *)(ioSettings))
    );
}

void JPH_CharacterContactListener_OnContactPersisted(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_BodyID *inBodyID2, const JPH_SubShapeID *inSubShapeID2, const JPH_Vec3 *inContactPosition, const JPH_Vec3 *inContactNormal, JPH_CharacterContactSettings *ioSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactListener *)(_this)).OnContactPersisted(
        ((const JPH::CharacterVirtual *)inCharacter),
        ((inBodyID2 ? void() : MRBINDC_THROW("Parameter `inBodyID2` can not be null.", void)), *(const JPH::BodyID *)(inBodyID2)),
        ((inSubShapeID2 ? void() : MRBINDC_THROW("Parameter `inSubShapeID2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID2)),
        ((inContactPosition ? void() : MRBINDC_THROW("Parameter `inContactPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactPosition)),
        ((inContactNormal ? void() : MRBINDC_THROW("Parameter `inContactNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactNormal)),
        ((ioSettings ? void() : MRBINDC_THROW("Parameter `ioSettings` can not be null.", void)), *(JPH::CharacterContactSettings *)(ioSettings))
    );
}

void JPH_CharacterContactListener_OnContactRemoved(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_BodyID *inBodyID2, const JPH_SubShapeID *inSubShapeID2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactListener *)(_this)).OnContactRemoved(
        ((const JPH::CharacterVirtual *)inCharacter),
        ((inBodyID2 ? void() : MRBINDC_THROW("Parameter `inBodyID2` can not be null.", void)), *(const JPH::BodyID *)(inBodyID2)),
        ((inSubShapeID2 ? void() : MRBINDC_THROW("Parameter `inSubShapeID2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID2))
    );
}

void JPH_CharacterContactListener_OnCharacterContactAdded(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_CharacterVirtual *inOtherCharacter, const JPH_SubShapeID *inSubShapeID2, const JPH_Vec3 *inContactPosition, const JPH_Vec3 *inContactNormal, JPH_CharacterContactSettings *ioSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactListener *)(_this)).OnCharacterContactAdded(
        ((const JPH::CharacterVirtual *)inCharacter),
        ((const JPH::CharacterVirtual *)inOtherCharacter),
        ((inSubShapeID2 ? void() : MRBINDC_THROW("Parameter `inSubShapeID2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID2)),
        ((inContactPosition ? void() : MRBINDC_THROW("Parameter `inContactPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactPosition)),
        ((inContactNormal ? void() : MRBINDC_THROW("Parameter `inContactNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactNormal)),
        ((ioSettings ? void() : MRBINDC_THROW("Parameter `ioSettings` can not be null.", void)), *(JPH::CharacterContactSettings *)(ioSettings))
    );
}

void JPH_CharacterContactListener_OnCharacterContactPersisted(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_CharacterVirtual *inOtherCharacter, const JPH_SubShapeID *inSubShapeID2, const JPH_Vec3 *inContactPosition, const JPH_Vec3 *inContactNormal, JPH_CharacterContactSettings *ioSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactListener *)(_this)).OnCharacterContactPersisted(
        ((const JPH::CharacterVirtual *)inCharacter),
        ((const JPH::CharacterVirtual *)inOtherCharacter),
        ((inSubShapeID2 ? void() : MRBINDC_THROW("Parameter `inSubShapeID2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID2)),
        ((inContactPosition ? void() : MRBINDC_THROW("Parameter `inContactPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactPosition)),
        ((inContactNormal ? void() : MRBINDC_THROW("Parameter `inContactNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactNormal)),
        ((ioSettings ? void() : MRBINDC_THROW("Parameter `ioSettings` can not be null.", void)), *(JPH::CharacterContactSettings *)(ioSettings))
    );
}

void JPH_CharacterContactListener_OnCharacterContactRemoved(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_CharacterID *inOtherCharacterID, const JPH_SubShapeID *inSubShapeID2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactListener *)(_this)).OnCharacterContactRemoved(
        ((const JPH::CharacterVirtual *)inCharacter),
        ((inOtherCharacterID ? void() : MRBINDC_THROW("Parameter `inOtherCharacterID` can not be null.", void)), *(const JPH::CharacterID *)(inOtherCharacterID)),
        ((inSubShapeID2 ? void() : MRBINDC_THROW("Parameter `inSubShapeID2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID2))
    );
}

void JPH_CharacterContactListener_OnContactSolve(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_BodyID *inBodyID2, const JPH_SubShapeID *inSubShapeID2, const JPH_Vec3 *inContactPosition, const JPH_Vec3 *inContactNormal, const JPH_Vec3 *inContactVelocity, const JPH_PhysicsMaterial *inContactMaterial, const JPH_Vec3 *inCharacterVelocity, JPH_Vec3 *ioNewCharacterVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactListener *)(_this)).OnContactSolve(
        ((const JPH::CharacterVirtual *)inCharacter),
        ((inBodyID2 ? void() : MRBINDC_THROW("Parameter `inBodyID2` can not be null.", void)), *(const JPH::BodyID *)(inBodyID2)),
        ((inSubShapeID2 ? void() : MRBINDC_THROW("Parameter `inSubShapeID2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID2)),
        ((inContactPosition ? void() : MRBINDC_THROW("Parameter `inContactPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactPosition)),
        ((inContactNormal ? void() : MRBINDC_THROW("Parameter `inContactNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactNormal)),
        ((inContactVelocity ? void() : MRBINDC_THROW("Parameter `inContactVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactVelocity)),
        ((const JPH::PhysicsMaterial *)inContactMaterial),
        ((inCharacterVelocity ? void() : MRBINDC_THROW("Parameter `inCharacterVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCharacterVelocity)),
        ((ioNewCharacterVelocity ? void() : MRBINDC_THROW("Parameter `ioNewCharacterVelocity` can not be null.", void)), *(JPH::Vec3 *)(ioNewCharacterVelocity))
    );
}

void JPH_CharacterContactListener_OnCharacterContactSolve(JPH_CharacterContactListener *_this, const JPH_CharacterVirtual *inCharacter, const JPH_CharacterVirtual *inOtherCharacter, const JPH_SubShapeID *inSubShapeID2, const JPH_Vec3 *inContactPosition, const JPH_Vec3 *inContactNormal, const JPH_Vec3 *inContactVelocity, const JPH_PhysicsMaterial *inContactMaterial, const JPH_Vec3 *inCharacterVelocity, JPH_Vec3 *ioNewCharacterVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterContactListener *)(_this)).OnCharacterContactSolve(
        ((const JPH::CharacterVirtual *)inCharacter),
        ((const JPH::CharacterVirtual *)inOtherCharacter),
        ((inSubShapeID2 ? void() : MRBINDC_THROW("Parameter `inSubShapeID2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID2)),
        ((inContactPosition ? void() : MRBINDC_THROW("Parameter `inContactPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactPosition)),
        ((inContactNormal ? void() : MRBINDC_THROW("Parameter `inContactNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactNormal)),
        ((inContactVelocity ? void() : MRBINDC_THROW("Parameter `inContactVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactVelocity)),
        ((const JPH::PhysicsMaterial *)inContactMaterial),
        ((inCharacterVelocity ? void() : MRBINDC_THROW("Parameter `inCharacterVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCharacterVelocity)),
        ((ioNewCharacterVelocity ? void() : MRBINDC_THROW("Parameter `ioNewCharacterVelocity` can not be null.", void)), *(JPH::Vec3 *)(ioNewCharacterVelocity))
    );
}

void JPH_CharacterVsCharacterCollision_Destroy(const JPH_CharacterVsCharacterCollision *_this)
{
    delete ((const JPH::CharacterVsCharacterCollision *)_this);
}

void JPH_CharacterVsCharacterCollision_DestroyArray(const JPH_CharacterVsCharacterCollision *_this)
{
    delete[] ((const JPH::CharacterVsCharacterCollision *)_this);
}

const JPH_CharacterVsCharacterCollision *JPH_CharacterVsCharacterCollision_OffsetPtr(const JPH_CharacterVsCharacterCollision *ptr, ptrdiff_t i)
{
    return (const JPH_CharacterVsCharacterCollision *)(((const JPH::CharacterVsCharacterCollision *)ptr) + i);
}

JPH_CharacterVsCharacterCollision *JPH_CharacterVsCharacterCollision_OffsetMutablePtr(JPH_CharacterVsCharacterCollision *ptr, ptrdiff_t i)
{
    return (JPH_CharacterVsCharacterCollision *)(((JPH::CharacterVsCharacterCollision *)ptr) + i);
}

const JPH_NonCopyable *JPH_CharacterVsCharacterCollision_UpcastTo_JPH_NonCopyable(const JPH_CharacterVsCharacterCollision *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::CharacterVsCharacterCollision *)object)
    ));
}

JPH_NonCopyable *JPH_CharacterVsCharacterCollision_MutableUpcastTo_JPH_NonCopyable(JPH_CharacterVsCharacterCollision *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::CharacterVsCharacterCollision *)object)
    ));
}

const JPH_CharacterVsCharacterCollision *JPH_CharacterVsCharacterCollision_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_CharacterVsCharacterCollision *)(static_cast<const JPH::CharacterVsCharacterCollision *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_CharacterVsCharacterCollision *JPH_CharacterVsCharacterCollision_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_CharacterVsCharacterCollision *)(static_cast<JPH::CharacterVsCharacterCollision *>(
        ((JPH::NonCopyable *)object)
    ));
}

JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_DefaultConstruct(void)
{
    return (JPH_CharacterVsCharacterCollisionSimple *)new JPH::CharacterVsCharacterCollisionSimple(JPH::CharacterVsCharacterCollisionSimple());
}

JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CharacterVsCharacterCollisionSimple *)(new JPH::CharacterVsCharacterCollisionSimple[num_elems]{});
}

const JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_OffsetPtr(const JPH_CharacterVsCharacterCollisionSimple *ptr, ptrdiff_t i)
{
    return (const JPH_CharacterVsCharacterCollisionSimple *)(((const JPH::CharacterVsCharacterCollisionSimple *)ptr) + i);
}

JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_OffsetMutablePtr(JPH_CharacterVsCharacterCollisionSimple *ptr, ptrdiff_t i)
{
    return (JPH_CharacterVsCharacterCollisionSimple *)(((JPH::CharacterVsCharacterCollisionSimple *)ptr) + i);
}

const JPH_NonCopyable *JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_NonCopyable(const JPH_CharacterVsCharacterCollisionSimple *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::CharacterVsCharacterCollisionSimple *)object)
    ));
}

JPH_NonCopyable *JPH_CharacterVsCharacterCollisionSimple_MutableUpcastTo_JPH_NonCopyable(JPH_CharacterVsCharacterCollisionSimple *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::CharacterVsCharacterCollisionSimple *)object)
    ));
}

const JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_CharacterVsCharacterCollisionSimple *)(static_cast<const JPH::CharacterVsCharacterCollisionSimple *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_CharacterVsCharacterCollisionSimple *)(static_cast<JPH::CharacterVsCharacterCollisionSimple *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_CharacterVsCharacterCollision *JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_CharacterVsCharacterCollision(const JPH_CharacterVsCharacterCollisionSimple *object)
{
    return (const JPH_CharacterVsCharacterCollision *)(static_cast<const JPH::CharacterVsCharacterCollision *>(
        ((const JPH::CharacterVsCharacterCollisionSimple *)object)
    ));
}

JPH_CharacterVsCharacterCollision *JPH_CharacterVsCharacterCollisionSimple_MutableUpcastTo_JPH_CharacterVsCharacterCollision(JPH_CharacterVsCharacterCollisionSimple *object)
{
    return (JPH_CharacterVsCharacterCollision *)(static_cast<JPH::CharacterVsCharacterCollision *>(
        ((JPH::CharacterVsCharacterCollisionSimple *)object)
    ));
}

const JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_StaticDowncastFrom_JPH_CharacterVsCharacterCollision(const JPH_CharacterVsCharacterCollision *object)
{
    return (const JPH_CharacterVsCharacterCollisionSimple *)(static_cast<const JPH::CharacterVsCharacterCollisionSimple *>(
        ((const JPH::CharacterVsCharacterCollision *)object)
    ));
}

JPH_CharacterVsCharacterCollisionSimple *JPH_CharacterVsCharacterCollisionSimple_MutableStaticDowncastFrom_JPH_CharacterVsCharacterCollision(JPH_CharacterVsCharacterCollision *object)
{
    return (JPH_CharacterVsCharacterCollisionSimple *)(static_cast<JPH::CharacterVsCharacterCollisionSimple *>(
        ((JPH::CharacterVsCharacterCollision *)object)
    ));
}

void JPH_CharacterVsCharacterCollisionSimple_Destroy(const JPH_CharacterVsCharacterCollisionSimple *_this)
{
    delete ((const JPH::CharacterVsCharacterCollisionSimple *)_this);
}

void JPH_CharacterVsCharacterCollisionSimple_DestroyArray(const JPH_CharacterVsCharacterCollisionSimple *_this)
{
    delete[] ((const JPH::CharacterVsCharacterCollisionSimple *)_this);
}

void JPH_CharacterVsCharacterCollisionSimple_Add(JPH_CharacterVsCharacterCollisionSimple *_this, JPH_CharacterVirtual *inCharacter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVsCharacterCollisionSimple *)(_this)).Add(
        ((JPH::CharacterVirtual *)inCharacter)
    );
}

void JPH_CharacterVsCharacterCollisionSimple_Remove(JPH_CharacterVsCharacterCollisionSimple *_this, const JPH_CharacterVirtual *inCharacter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVsCharacterCollisionSimple *)(_this)).Remove(
        ((const JPH::CharacterVirtual *)inCharacter)
    );
}

JPH_CharacterVirtual *JPH_CharacterVirtual_Construct_5(const JPH_CharacterVirtualSettings *inSettings, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, uint64_t inUserData, JPH_PhysicsSystem *inSystem)
{
    return (JPH_CharacterVirtual *)new JPH::CharacterVirtual(JPH::CharacterVirtual(
        ((const JPH::CharacterVirtualSettings *)inSettings),
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        inUserData,
        ((JPH::PhysicsSystem *)inSystem)
    ));
}

const JPH_CharacterVirtual *JPH_CharacterVirtual_OffsetPtr(const JPH_CharacterVirtual *ptr, ptrdiff_t i)
{
    return (const JPH_CharacterVirtual *)(((const JPH::CharacterVirtual *)ptr) + i);
}

JPH_CharacterVirtual *JPH_CharacterVirtual_OffsetMutablePtr(JPH_CharacterVirtual *ptr, ptrdiff_t i)
{
    return (JPH_CharacterVirtual *)(((JPH::CharacterVirtual *)ptr) + i);
}

const JPH_RefTarget_JPH_CharacterBase *JPH_CharacterVirtual_UpcastTo_JPH_RefTarget_JPH_CharacterBase(const JPH_CharacterVirtual *object)
{
    return (const JPH_RefTarget_JPH_CharacterBase *)(static_cast<const JPH::RefTarget<JPH::CharacterBase> *>(
        ((const JPH::CharacterVirtual *)object)
    ));
}

JPH_RefTarget_JPH_CharacterBase *JPH_CharacterVirtual_MutableUpcastTo_JPH_RefTarget_JPH_CharacterBase(JPH_CharacterVirtual *object)
{
    return (JPH_RefTarget_JPH_CharacterBase *)(static_cast<JPH::RefTarget<JPH::CharacterBase> *>(
        ((JPH::CharacterVirtual *)object)
    ));
}

const JPH_CharacterVirtual *JPH_CharacterVirtual_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(const JPH_RefTarget_JPH_CharacterBase *object)
{
    return (const JPH_CharacterVirtual *)(static_cast<const JPH::CharacterVirtual *>(
        ((const JPH::RefTarget<JPH::CharacterBase> *)object)
    ));
}

JPH_CharacterVirtual *JPH_CharacterVirtual_MutableStaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(JPH_RefTarget_JPH_CharacterBase *object)
{
    return (JPH_CharacterVirtual *)(static_cast<JPH::CharacterVirtual *>(
        ((JPH::RefTarget<JPH::CharacterBase> *)object)
    ));
}

const JPH_NonCopyable *JPH_CharacterVirtual_UpcastTo_JPH_NonCopyable(const JPH_CharacterVirtual *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::CharacterVirtual *)object)
    ));
}

JPH_NonCopyable *JPH_CharacterVirtual_MutableUpcastTo_JPH_NonCopyable(JPH_CharacterVirtual *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::CharacterVirtual *)object)
    ));
}

const JPH_CharacterVirtual *JPH_CharacterVirtual_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_CharacterVirtual *)(static_cast<const JPH::CharacterVirtual *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_CharacterVirtual *JPH_CharacterVirtual_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_CharacterVirtual *)(static_cast<JPH::CharacterVirtual *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_CharacterBase *JPH_CharacterVirtual_UpcastTo_JPH_CharacterBase(const JPH_CharacterVirtual *object)
{
    return (const JPH_CharacterBase *)(static_cast<const JPH::CharacterBase *>(
        ((const JPH::CharacterVirtual *)object)
    ));
}

JPH_CharacterBase *JPH_CharacterVirtual_MutableUpcastTo_JPH_CharacterBase(JPH_CharacterVirtual *object)
{
    return (JPH_CharacterBase *)(static_cast<JPH::CharacterBase *>(
        ((JPH::CharacterVirtual *)object)
    ));
}

const JPH_CharacterVirtual *JPH_CharacterVirtual_StaticDowncastFrom_JPH_CharacterBase(const JPH_CharacterBase *object)
{
    return (const JPH_CharacterVirtual *)(static_cast<const JPH::CharacterVirtual *>(
        ((const JPH::CharacterBase *)object)
    ));
}

JPH_CharacterVirtual *JPH_CharacterVirtual_MutableStaticDowncastFrom_JPH_CharacterBase(JPH_CharacterBase *object)
{
    return (JPH_CharacterVirtual *)(static_cast<JPH::CharacterVirtual *>(
        ((JPH::CharacterBase *)object)
    ));
}

JPH_CharacterVirtual *JPH_CharacterVirtual_Construct_4(const JPH_CharacterVirtualSettings *inSettings, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, JPH_PhysicsSystem *inSystem)
{
    return (JPH_CharacterVirtual *)new JPH::CharacterVirtual(JPH::CharacterVirtual(
        ((const JPH::CharacterVirtualSettings *)inSettings),
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((JPH::PhysicsSystem *)inSystem)
    ));
}

void JPH_CharacterVirtual_Destroy(const JPH_CharacterVirtual *_this)
{
    delete ((const JPH::CharacterVirtual *)_this);
}

void JPH_CharacterVirtual_DestroyArray(const JPH_CharacterVirtual *_this)
{
    delete[] ((const JPH::CharacterVirtual *)_this);
}

void *Jolt_new_JPH_CharacterVirtual_size_t(size_t inCount)
{
    return JPH::CharacterVirtual::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CharacterVirtual_void_ptr(void *inPointer)
{
    JPH::CharacterVirtual::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CharacterVirtual_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CharacterVirtual::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CharacterVirtual_size_t(size_t inCount)
{
    return JPH::CharacterVirtual::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CharacterVirtual_void_ptr(void *inPointer)
{
    JPH::CharacterVirtual::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CharacterVirtual_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CharacterVirtual::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CharacterVirtual_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CharacterVirtual::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CharacterVirtual_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CharacterVirtual::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CharacterVirtual_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CharacterVirtual::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CharacterVirtual_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CharacterVirtual::operator delete[](
        inPointer,
        inPlace
    );
}

const JPH_CharacterID *JPH_CharacterVirtual_GetID(const JPH_CharacterVirtual *_this)
{
    return (const JPH_CharacterID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetID());
}

void JPH_CharacterVirtual_SetListener(JPH_CharacterVirtual *_this, JPH_CharacterContactListener *inListener)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetListener(
        ((JPH::CharacterContactListener *)inListener)
    );
}

JPH_CharacterContactListener *JPH_CharacterVirtual_GetListener(const JPH_CharacterVirtual *_this)
{
    return (JPH_CharacterContactListener *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetListener());
}

void JPH_CharacterVirtual_SetCharacterVsCharacterCollision(JPH_CharacterVirtual *_this, JPH_CharacterVsCharacterCollision *inCharacterVsCharacterCollision)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetCharacterVsCharacterCollision(
        ((JPH::CharacterVsCharacterCollision *)inCharacterVsCharacterCollision)
    );
}

JPH_Vec3 *JPH_CharacterVirtual_GetLinearVelocity(const JPH_CharacterVirtual *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetLinearVelocity());
}

void JPH_CharacterVirtual_SetLinearVelocity(JPH_CharacterVirtual *_this, const JPH_Vec3 *inLinearVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetLinearVelocity(
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity))
    );
}

JPH_Vec3 *JPH_CharacterVirtual_GetPosition(const JPH_CharacterVirtual *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetPosition());
}

void JPH_CharacterVirtual_SetPosition(JPH_CharacterVirtual *_this, const JPH_Vec3 *inPosition)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetPosition(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition))
    );
}

JPH_Quat *JPH_CharacterVirtual_GetRotation(const JPH_CharacterVirtual *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetRotation());
}

void JPH_CharacterVirtual_SetRotation(JPH_CharacterVirtual *_this, const JPH_Quat *inRotation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetRotation(
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation))
    );
}

JPH_Vec3 *JPH_CharacterVirtual_GetCenterOfMassPosition(const JPH_CharacterVirtual *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetCenterOfMassPosition());
}

JPH_Mat44 *JPH_CharacterVirtual_GetWorldTransform(const JPH_CharacterVirtual *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetWorldTransform());
}

JPH_Mat44 *JPH_CharacterVirtual_GetCenterOfMassTransform(const JPH_CharacterVirtual *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetCenterOfMassTransform());
}

float JPH_CharacterVirtual_GetMass(const JPH_CharacterVirtual *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetMass();
}

void JPH_CharacterVirtual_SetMass(JPH_CharacterVirtual *_this, float inMass)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetMass(
        inMass
    );
}

float JPH_CharacterVirtual_GetMaxStrength(const JPH_CharacterVirtual *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetMaxStrength();
}

void JPH_CharacterVirtual_SetMaxStrength(JPH_CharacterVirtual *_this, float inMaxStrength)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetMaxStrength(
        inMaxStrength
    );
}

float JPH_CharacterVirtual_GetPenetrationRecoverySpeed(const JPH_CharacterVirtual *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetPenetrationRecoverySpeed();
}

void JPH_CharacterVirtual_SetPenetrationRecoverySpeed(JPH_CharacterVirtual *_this, float inSpeed)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetPenetrationRecoverySpeed(
        inSpeed
    );
}

bool JPH_CharacterVirtual_GetEnhancedInternalEdgeRemoval(const JPH_CharacterVirtual *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetEnhancedInternalEdgeRemoval();
}

void JPH_CharacterVirtual_SetEnhancedInternalEdgeRemoval(JPH_CharacterVirtual *_this, bool inApply)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetEnhancedInternalEdgeRemoval(
        inApply
    );
}

float JPH_CharacterVirtual_GetCharacterPadding(const JPH_CharacterVirtual *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetCharacterPadding();
}

unsigned int JPH_CharacterVirtual_GetMaxNumHits(const JPH_CharacterVirtual *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetMaxNumHits();
}

void JPH_CharacterVirtual_SetMaxNumHits(JPH_CharacterVirtual *_this, unsigned int inMaxHits)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetMaxNumHits(
        inMaxHits
    );
}

float JPH_CharacterVirtual_GetHitReductionCosMaxAngle(const JPH_CharacterVirtual *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetHitReductionCosMaxAngle();
}

void JPH_CharacterVirtual_SetHitReductionCosMaxAngle(JPH_CharacterVirtual *_this, float inCosMaxAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetHitReductionCosMaxAngle(
        inCosMaxAngle
    );
}

bool JPH_CharacterVirtual_GetMaxHitsExceeded(const JPH_CharacterVirtual *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetMaxHitsExceeded();
}

JPH_Vec3 *JPH_CharacterVirtual_GetShapeOffset(const JPH_CharacterVirtual *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetShapeOffset());
}

void JPH_CharacterVirtual_SetShapeOffset(JPH_CharacterVirtual *_this, const JPH_Vec3 *inShapeOffset)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetShapeOffset(
        ((inShapeOffset ? void() : MRBINDC_THROW("Parameter `inShapeOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inShapeOffset))
    );
}

uint64_t JPH_CharacterVirtual_GetUserData(const JPH_CharacterVirtual *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetUserData();
}

void JPH_CharacterVirtual_SetUserData(JPH_CharacterVirtual *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetUserData(
        inUserData
    );
}

JPH_BodyID JPH_CharacterVirtual_GetInnerBodyID(const JPH_CharacterVirtual *_this)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetInnerBodyID());
}

JPH_Vec3 *JPH_CharacterVirtual_CancelVelocityTowardsSteepSlopes(const JPH_CharacterVirtual *_this, const JPH_Vec3 *inDesiredVelocity)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).CancelVelocityTowardsSteepSlopes(
        ((inDesiredVelocity ? void() : MRBINDC_THROW("Parameter `inDesiredVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDesiredVelocity))
    ));
}

void JPH_CharacterVirtual_StartTrackingContactChanges(JPH_CharacterVirtual *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).StartTrackingContactChanges();
}

void JPH_CharacterVirtual_FinishTrackingContactChanges(JPH_CharacterVirtual *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).FinishTrackingContactChanges();
}

void JPH_CharacterVirtual_Update(JPH_CharacterVirtual *_this, float inDeltaTime, const JPH_Vec3 *inGravity, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter, const JPH_BodyFilter *inBodyFilter, const JPH_ShapeFilter *inShapeFilter, JPH_TempAllocator *inAllocator)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).Update(
        inDeltaTime,
        ((inGravity ? void() : MRBINDC_THROW("Parameter `inGravity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inGravity)),
        ((inBroadPhaseLayerFilter ? void() : MRBINDC_THROW("Parameter `inBroadPhaseLayerFilter` can not be null.", void)), *(const JPH::BroadPhaseLayerFilter *)(inBroadPhaseLayerFilter)),
        ((inObjectLayerFilter ? void() : MRBINDC_THROW("Parameter `inObjectLayerFilter` can not be null.", void)), *(const JPH::ObjectLayerFilter *)(inObjectLayerFilter)),
        ((inBodyFilter ? void() : MRBINDC_THROW("Parameter `inBodyFilter` can not be null.", void)), *(const JPH::BodyFilter *)(inBodyFilter)),
        ((inShapeFilter ? void() : MRBINDC_THROW("Parameter `inShapeFilter` can not be null.", void)), *(const JPH::ShapeFilter *)(inShapeFilter)),
        ((inAllocator ? void() : MRBINDC_THROW("Parameter `inAllocator` can not be null.", void)), *(JPH::TempAllocator *)(inAllocator))
    );
}

bool JPH_CharacterVirtual_CanWalkStairs(const JPH_CharacterVirtual *_this, const JPH_Vec3 *inLinearVelocity)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).CanWalkStairs(
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity))
    );
}

bool JPH_CharacterVirtual_WalkStairs(JPH_CharacterVirtual *_this, float inDeltaTime, const JPH_Vec3 *inStepUp, const JPH_Vec3 *inStepForward, const JPH_Vec3 *inStepForwardTest, const JPH_Vec3 *inStepDownExtra, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter, const JPH_BodyFilter *inBodyFilter, const JPH_ShapeFilter *inShapeFilter, JPH_TempAllocator *inAllocator)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).WalkStairs(
        inDeltaTime,
        ((inStepUp ? void() : MRBINDC_THROW("Parameter `inStepUp` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inStepUp)),
        ((inStepForward ? void() : MRBINDC_THROW("Parameter `inStepForward` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inStepForward)),
        ((inStepForwardTest ? void() : MRBINDC_THROW("Parameter `inStepForwardTest` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inStepForwardTest)),
        ((inStepDownExtra ? void() : MRBINDC_THROW("Parameter `inStepDownExtra` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inStepDownExtra)),
        ((inBroadPhaseLayerFilter ? void() : MRBINDC_THROW("Parameter `inBroadPhaseLayerFilter` can not be null.", void)), *(const JPH::BroadPhaseLayerFilter *)(inBroadPhaseLayerFilter)),
        ((inObjectLayerFilter ? void() : MRBINDC_THROW("Parameter `inObjectLayerFilter` can not be null.", void)), *(const JPH::ObjectLayerFilter *)(inObjectLayerFilter)),
        ((inBodyFilter ? void() : MRBINDC_THROW("Parameter `inBodyFilter` can not be null.", void)), *(const JPH::BodyFilter *)(inBodyFilter)),
        ((inShapeFilter ? void() : MRBINDC_THROW("Parameter `inShapeFilter` can not be null.", void)), *(const JPH::ShapeFilter *)(inShapeFilter)),
        ((inAllocator ? void() : MRBINDC_THROW("Parameter `inAllocator` can not be null.", void)), *(JPH::TempAllocator *)(inAllocator))
    );
}

bool JPH_CharacterVirtual_StickToFloor(JPH_CharacterVirtual *_this, const JPH_Vec3 *inStepDown, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter, const JPH_BodyFilter *inBodyFilter, const JPH_ShapeFilter *inShapeFilter, JPH_TempAllocator *inAllocator)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).StickToFloor(
        ((inStepDown ? void() : MRBINDC_THROW("Parameter `inStepDown` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inStepDown)),
        ((inBroadPhaseLayerFilter ? void() : MRBINDC_THROW("Parameter `inBroadPhaseLayerFilter` can not be null.", void)), *(const JPH::BroadPhaseLayerFilter *)(inBroadPhaseLayerFilter)),
        ((inObjectLayerFilter ? void() : MRBINDC_THROW("Parameter `inObjectLayerFilter` can not be null.", void)), *(const JPH::ObjectLayerFilter *)(inObjectLayerFilter)),
        ((inBodyFilter ? void() : MRBINDC_THROW("Parameter `inBodyFilter` can not be null.", void)), *(const JPH::BodyFilter *)(inBodyFilter)),
        ((inShapeFilter ? void() : MRBINDC_THROW("Parameter `inShapeFilter` can not be null.", void)), *(const JPH::ShapeFilter *)(inShapeFilter)),
        ((inAllocator ? void() : MRBINDC_THROW("Parameter `inAllocator` can not be null.", void)), *(JPH::TempAllocator *)(inAllocator))
    );
}

void JPH_CharacterVirtual_ExtendedUpdate(JPH_CharacterVirtual *_this, float inDeltaTime, const JPH_Vec3 *inGravity, const JPH_CharacterVirtual_ExtendedUpdateSettings *inSettings, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter, const JPH_BodyFilter *inBodyFilter, const JPH_ShapeFilter *inShapeFilter, JPH_TempAllocator *inAllocator)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).ExtendedUpdate(
        inDeltaTime,
        ((inGravity ? void() : MRBINDC_THROW("Parameter `inGravity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inGravity)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::CharacterVirtual::ExtendedUpdateSettings *)(inSettings)),
        ((inBroadPhaseLayerFilter ? void() : MRBINDC_THROW("Parameter `inBroadPhaseLayerFilter` can not be null.", void)), *(const JPH::BroadPhaseLayerFilter *)(inBroadPhaseLayerFilter)),
        ((inObjectLayerFilter ? void() : MRBINDC_THROW("Parameter `inObjectLayerFilter` can not be null.", void)), *(const JPH::ObjectLayerFilter *)(inObjectLayerFilter)),
        ((inBodyFilter ? void() : MRBINDC_THROW("Parameter `inBodyFilter` can not be null.", void)), *(const JPH::BodyFilter *)(inBodyFilter)),
        ((inShapeFilter ? void() : MRBINDC_THROW("Parameter `inShapeFilter` can not be null.", void)), *(const JPH::ShapeFilter *)(inShapeFilter)),
        ((inAllocator ? void() : MRBINDC_THROW("Parameter `inAllocator` can not be null.", void)), *(JPH::TempAllocator *)(inAllocator))
    );
}

void JPH_CharacterVirtual_RefreshContacts(JPH_CharacterVirtual *_this, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter, const JPH_BodyFilter *inBodyFilter, const JPH_ShapeFilter *inShapeFilter, JPH_TempAllocator *inAllocator)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).RefreshContacts(
        ((inBroadPhaseLayerFilter ? void() : MRBINDC_THROW("Parameter `inBroadPhaseLayerFilter` can not be null.", void)), *(const JPH::BroadPhaseLayerFilter *)(inBroadPhaseLayerFilter)),
        ((inObjectLayerFilter ? void() : MRBINDC_THROW("Parameter `inObjectLayerFilter` can not be null.", void)), *(const JPH::ObjectLayerFilter *)(inObjectLayerFilter)),
        ((inBodyFilter ? void() : MRBINDC_THROW("Parameter `inBodyFilter` can not be null.", void)), *(const JPH::BodyFilter *)(inBodyFilter)),
        ((inShapeFilter ? void() : MRBINDC_THROW("Parameter `inShapeFilter` can not be null.", void)), *(const JPH::ShapeFilter *)(inShapeFilter)),
        ((inAllocator ? void() : MRBINDC_THROW("Parameter `inAllocator` can not be null.", void)), *(JPH::TempAllocator *)(inAllocator))
    );
}

void JPH_CharacterVirtual_UpdateGroundVelocity(JPH_CharacterVirtual *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).UpdateGroundVelocity();
}

bool JPH_CharacterVirtual_SetShape(JPH_CharacterVirtual *_this, const JPH_Shape *inShape, float inMaxPenetrationDepth, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter, const JPH_BodyFilter *inBodyFilter, const JPH_ShapeFilter *inShapeFilter, JPH_TempAllocator *inAllocator)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetShape(
        ((const JPH::Shape *)inShape),
        inMaxPenetrationDepth,
        ((inBroadPhaseLayerFilter ? void() : MRBINDC_THROW("Parameter `inBroadPhaseLayerFilter` can not be null.", void)), *(const JPH::BroadPhaseLayerFilter *)(inBroadPhaseLayerFilter)),
        ((inObjectLayerFilter ? void() : MRBINDC_THROW("Parameter `inObjectLayerFilter` can not be null.", void)), *(const JPH::ObjectLayerFilter *)(inObjectLayerFilter)),
        ((inBodyFilter ? void() : MRBINDC_THROW("Parameter `inBodyFilter` can not be null.", void)), *(const JPH::BodyFilter *)(inBodyFilter)),
        ((inShapeFilter ? void() : MRBINDC_THROW("Parameter `inShapeFilter` can not be null.", void)), *(const JPH::ShapeFilter *)(inShapeFilter)),
        ((inAllocator ? void() : MRBINDC_THROW("Parameter `inAllocator` can not be null.", void)), *(JPH::TempAllocator *)(inAllocator))
    );
}

void JPH_CharacterVirtual_SetInnerBodyShape(JPH_CharacterVirtual *_this, const JPH_Shape *inShape)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetInnerBodyShape(
        ((const JPH::Shape *)inShape)
    );
}

JPH_CharacterVirtualSettings *JPH_CharacterVirtual_GetCharacterVirtualSettings(const JPH_CharacterVirtual *_this)
{
    return (JPH_CharacterVirtualSettings *)new JPH::CharacterVirtualSettings(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetCharacterVirtualSettings());
}

bool JPH_CharacterVirtual_HasCollidedWith_JPH_BodyID(const JPH_CharacterVirtual *_this, const JPH_BodyID *inBody)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).HasCollidedWith(
        ((inBody ? void() : MRBINDC_THROW("Parameter `inBody` can not be null.", void)), *(const JPH::BodyID *)(inBody))
    );
}

bool JPH_CharacterVirtual_HasCollidedWith_JPH_CharacterID(const JPH_CharacterVirtual *_this, const JPH_CharacterID *inCharacterID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).HasCollidedWith(
        ((inCharacterID ? void() : MRBINDC_THROW("Parameter `inCharacterID` can not be null.", void)), *(const JPH::CharacterID *)(inCharacterID))
    );
}

bool JPH_CharacterVirtual_HasCollidedWith_const_JPH_CharacterVirtual_ptr(const JPH_CharacterVirtual *_this, const JPH_CharacterVirtual *inCharacter)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).HasCollidedWith(
        ((const JPH::CharacterVirtual *)inCharacter)
    );
}

void JPH_CharacterVirtual_SetMaxSlopeAngle(JPH_CharacterVirtual *_this, float inMaxSlopeAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetMaxSlopeAngle(
        inMaxSlopeAngle
    );
}

float JPH_CharacterVirtual_GetCosMaxSlopeAngle(const JPH_CharacterVirtual *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetCosMaxSlopeAngle();
}

void JPH_CharacterVirtual_SetUp(JPH_CharacterVirtual *_this, const JPH_Vec3 *inUp)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual *)(_this)).SetUp(
        ((inUp ? void() : MRBINDC_THROW("Parameter `inUp` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inUp))
    );
}

JPH_Vec3 *JPH_CharacterVirtual_GetUp(const JPH_CharacterVirtual *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetUp());
}

bool JPH_CharacterVirtual_IsSlopeTooSteep(const JPH_CharacterVirtual *_this, const JPH_Vec3 *inNormal)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).IsSlopeTooSteep(
        ((inNormal ? void() : MRBINDC_THROW("Parameter `inNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inNormal))
    );
}

const JPH_Shape *JPH_CharacterVirtual_GetShape(const JPH_CharacterVirtual *_this)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetShape());
}

const char *JPH_CharacterVirtual_sToString(JPH_CharacterBase_EGroundState inState)
{
    return JPH::CharacterVirtual::sToString(
        ((JPH::CharacterBase::EGroundState)inState)
    );
}

JPH_CharacterBase_EGroundState JPH_CharacterVirtual_GetGroundState(const JPH_CharacterVirtual *_this)
{
    return (JPH_CharacterBase_EGroundState)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetGroundState());
}

bool JPH_CharacterVirtual_IsSupported(const JPH_CharacterVirtual *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).IsSupported();
}

JPH_Vec3 *JPH_CharacterVirtual_GetGroundPosition(const JPH_CharacterVirtual *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetGroundPosition());
}

JPH_Vec3 *JPH_CharacterVirtual_GetGroundNormal(const JPH_CharacterVirtual *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetGroundNormal());
}

JPH_Vec3 *JPH_CharacterVirtual_GetGroundVelocity(const JPH_CharacterVirtual *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetGroundVelocity());
}

const JPH_PhysicsMaterial *JPH_CharacterVirtual_GetGroundMaterial(const JPH_CharacterVirtual *_this)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetGroundMaterial());
}

JPH_BodyID JPH_CharacterVirtual_GetGroundBodyID(const JPH_CharacterVirtual *_this)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetGroundBodyID());
}

JPH_SubShapeID *JPH_CharacterVirtual_GetGroundSubShapeID(const JPH_CharacterVirtual *_this)
{
    return (JPH_SubShapeID *)new JPH::SubShapeID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetGroundSubShapeID());
}

uint64_t JPH_CharacterVirtual_GetGroundUserData(const JPH_CharacterVirtual *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetGroundUserData();
}

void JPH_CharacterVirtual_SetEmbedded(const JPH_CharacterVirtual *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).SetEmbedded();
}

unsigned int JPH_CharacterVirtual_GetRefCount(const JPH_CharacterVirtual *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).GetRefCount();
}

void JPH_CharacterVirtual_AddRef(const JPH_CharacterVirtual *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).AddRef();
}

void JPH_CharacterVirtual_Release(const JPH_CharacterVirtual *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual *)(_this)).Release();
}

int JPH_CharacterVirtual_sInternalGetRefCountOffset(void)
{
    return JPH::CharacterVirtual::sInternalGetRefCountOffset();
}

const JPH_Vec3 *JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mStickToFloorStepDown(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mStickToFloorStepDown);
}

JPH_Vec3 *JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mStickToFloorStepDown(JPH_CharacterVirtual_ExtendedUpdateSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mStickToFloorStepDown);
}

const JPH_Vec3 *JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsStepUp(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mWalkStairsStepUp);
}

JPH_Vec3 *JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsStepUp(JPH_CharacterVirtual_ExtendedUpdateSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mWalkStairsStepUp);
}

const float *JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsMinStepForward(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mWalkStairsMinStepForward);
}

void JPH_CharacterVirtual_ExtendedUpdateSettings_Set_mWalkStairsMinStepForward(JPH_CharacterVirtual_ExtendedUpdateSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mWalkStairsMinStepForward = value;
}

float *JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsMinStepForward(JPH_CharacterVirtual_ExtendedUpdateSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mWalkStairsMinStepForward);
}

const float *JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsStepForwardTest(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mWalkStairsStepForwardTest);
}

void JPH_CharacterVirtual_ExtendedUpdateSettings_Set_mWalkStairsStepForwardTest(JPH_CharacterVirtual_ExtendedUpdateSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mWalkStairsStepForwardTest = value;
}

float *JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsStepForwardTest(JPH_CharacterVirtual_ExtendedUpdateSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mWalkStairsStepForwardTest);
}

const float *JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsCosAngleForwardContact(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mWalkStairsCosAngleForwardContact);
}

void JPH_CharacterVirtual_ExtendedUpdateSettings_Set_mWalkStairsCosAngleForwardContact(JPH_CharacterVirtual_ExtendedUpdateSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mWalkStairsCosAngleForwardContact = value;
}

float *JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsCosAngleForwardContact(JPH_CharacterVirtual_ExtendedUpdateSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mWalkStairsCosAngleForwardContact);
}

const JPH_Vec3 *JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsStepDownExtra(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mWalkStairsStepDownExtra);
}

JPH_Vec3 *JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsStepDownExtra(JPH_CharacterVirtual_ExtendedUpdateSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).mWalkStairsStepDownExtra);
}

JPH_CharacterVirtual_ExtendedUpdateSettings *JPH_CharacterVirtual_ExtendedUpdateSettings_DefaultConstruct(void)
{
    return (JPH_CharacterVirtual_ExtendedUpdateSettings *)new JPH::CharacterVirtual::ExtendedUpdateSettings(JPH::CharacterVirtual::ExtendedUpdateSettings());
}

JPH_CharacterVirtual_ExtendedUpdateSettings *JPH_CharacterVirtual_ExtendedUpdateSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CharacterVirtual_ExtendedUpdateSettings *)(new JPH::CharacterVirtual::ExtendedUpdateSettings[num_elems]{});
}

JPH_CharacterVirtual_ExtendedUpdateSettings *JPH_CharacterVirtual_ExtendedUpdateSettings_ConstructFrom(const JPH_Vec3 *mStickToFloorStepDown, const JPH_Vec3 *mWalkStairsStepUp, float mWalkStairsMinStepForward, float mWalkStairsStepForwardTest, float mWalkStairsCosAngleForwardContact, const JPH_Vec3 *mWalkStairsStepDownExtra)
{
    return (JPH_CharacterVirtual_ExtendedUpdateSettings *)new JPH::CharacterVirtual::ExtendedUpdateSettings(JPH::CharacterVirtual::ExtendedUpdateSettings{
        ((mStickToFloorStepDown ? void() : MRBINDC_THROW("Parameter `mStickToFloorStepDown` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mStickToFloorStepDown)),
        ((mWalkStairsStepUp ? void() : MRBINDC_THROW("Parameter `mWalkStairsStepUp` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mWalkStairsStepUp)),
        mWalkStairsMinStepForward,
        mWalkStairsStepForwardTest,
        mWalkStairsCosAngleForwardContact,
        ((mWalkStairsStepDownExtra ? void() : MRBINDC_THROW("Parameter `mWalkStairsStepDownExtra` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mWalkStairsStepDownExtra))
    });
}

const JPH_CharacterVirtual_ExtendedUpdateSettings *JPH_CharacterVirtual_ExtendedUpdateSettings_OffsetPtr(const JPH_CharacterVirtual_ExtendedUpdateSettings *ptr, ptrdiff_t i)
{
    return (const JPH_CharacterVirtual_ExtendedUpdateSettings *)(((const JPH::CharacterVirtual::ExtendedUpdateSettings *)ptr) + i);
}

JPH_CharacterVirtual_ExtendedUpdateSettings *JPH_CharacterVirtual_ExtendedUpdateSettings_OffsetMutablePtr(JPH_CharacterVirtual_ExtendedUpdateSettings *ptr, ptrdiff_t i)
{
    return (JPH_CharacterVirtual_ExtendedUpdateSettings *)(((JPH::CharacterVirtual::ExtendedUpdateSettings *)ptr) + i);
}

JPH_CharacterVirtual_ExtendedUpdateSettings *JPH_CharacterVirtual_ExtendedUpdateSettings_ConstructFromAnother(const JPH_CharacterVirtual_ExtendedUpdateSettings *_other)
{
    return (JPH_CharacterVirtual_ExtendedUpdateSettings *)new JPH::CharacterVirtual::ExtendedUpdateSettings(JPH::CharacterVirtual::ExtendedUpdateSettings(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::CharacterVirtual::ExtendedUpdateSettings(*(JPH::CharacterVirtual::ExtendedUpdateSettings *)_other))
    ));
}

void JPH_CharacterVirtual_ExtendedUpdateSettings_Destroy(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this)
{
    delete ((const JPH::CharacterVirtual::ExtendedUpdateSettings *)_this);
}

void JPH_CharacterVirtual_ExtendedUpdateSettings_DestroyArray(const JPH_CharacterVirtual_ExtendedUpdateSettings *_this)
{
    delete[] ((const JPH::CharacterVirtual::ExtendedUpdateSettings *)_this);
}

JPH_CharacterVirtual_ExtendedUpdateSettings *JPH_CharacterVirtual_ExtendedUpdateSettings_AssignFromAnother(JPH_CharacterVirtual_ExtendedUpdateSettings *_this, const JPH_CharacterVirtual_ExtendedUpdateSettings *_other)
{
    return (JPH_CharacterVirtual_ExtendedUpdateSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ExtendedUpdateSettings *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::CharacterVirtual::ExtendedUpdateSettings(*(JPH::CharacterVirtual::ExtendedUpdateSettings *)_other))
    ));
}

const JPH_BodyID *JPH_CharacterVirtual_ContactKey_Get_mBodyB(const JPH_CharacterVirtual_ContactKey *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::ContactKey *)(_this)).mBodyB);
}

void JPH_CharacterVirtual_ContactKey_Set_mBodyB(JPH_CharacterVirtual_ContactKey *_this, JPH_BodyID value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ContactKey *)(_this)).mBodyB = MRBINDC_BIT_CAST((JPH::BodyID), value);
}

JPH_BodyID *JPH_CharacterVirtual_ContactKey_GetMutable_mBodyB(JPH_CharacterVirtual_ContactKey *_this)
{
    return (JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ContactKey *)(_this)).mBodyB);
}

const JPH_CharacterID *JPH_CharacterVirtual_ContactKey_Get_mCharacterIDB(const JPH_CharacterVirtual_ContactKey *_this)
{
    return (const JPH_CharacterID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::ContactKey *)(_this)).mCharacterIDB);
}

void JPH_CharacterVirtual_ContactKey_Set_mCharacterIDB(JPH_CharacterVirtual_ContactKey *_this, const JPH_CharacterID *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ContactKey *)(_this)).mCharacterIDB = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::CharacterID(*(JPH::CharacterID *)value));
}

JPH_CharacterID *JPH_CharacterVirtual_ContactKey_GetMutable_mCharacterIDB(JPH_CharacterVirtual_ContactKey *_this)
{
    return (JPH_CharacterID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ContactKey *)(_this)).mCharacterIDB);
}

const JPH_SubShapeID *JPH_CharacterVirtual_ContactKey_Get_mSubShapeIDB(const JPH_CharacterVirtual_ContactKey *_this)
{
    return (const JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::ContactKey *)(_this)).mSubShapeIDB);
}

void JPH_CharacterVirtual_ContactKey_Set_mSubShapeIDB(JPH_CharacterVirtual_ContactKey *_this, const JPH_SubShapeID *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ContactKey *)(_this)).mSubShapeIDB = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)value));
}

JPH_SubShapeID *JPH_CharacterVirtual_ContactKey_GetMutable_mSubShapeIDB(JPH_CharacterVirtual_ContactKey *_this)
{
    return (JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ContactKey *)(_this)).mSubShapeIDB);
}

JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_DefaultConstruct(void)
{
    return (JPH_CharacterVirtual_ContactKey *)new JPH::CharacterVirtual::ContactKey(JPH::CharacterVirtual::ContactKey());
}

JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CharacterVirtual_ContactKey *)(new JPH::CharacterVirtual::ContactKey[num_elems]{});
}

const JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_OffsetPtr(const JPH_CharacterVirtual_ContactKey *ptr, ptrdiff_t i)
{
    return (const JPH_CharacterVirtual_ContactKey *)(((const JPH::CharacterVirtual::ContactKey *)ptr) + i);
}

JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_OffsetMutablePtr(JPH_CharacterVirtual_ContactKey *ptr, ptrdiff_t i)
{
    return (JPH_CharacterVirtual_ContactKey *)(((JPH::CharacterVirtual::ContactKey *)ptr) + i);
}

JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_ConstructFromAnother(const JPH_CharacterVirtual_ContactKey *inContact)
{
    return (JPH_CharacterVirtual_ContactKey *)new JPH::CharacterVirtual::ContactKey(JPH::CharacterVirtual::ContactKey(
        ((inContact ? void() : MRBINDC_THROW("Parameter `inContact` can not be null.", void)), JPH::CharacterVirtual::ContactKey(*(JPH::CharacterVirtual::ContactKey *)inContact))
    ));
}

JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_Construct_JPH_BodyID(const JPH_BodyID *inBodyB, const JPH_SubShapeID *inSubShapeID)
{
    return (JPH_CharacterVirtual_ContactKey *)new JPH::CharacterVirtual::ContactKey(JPH::CharacterVirtual::ContactKey(
        ((inBodyB ? void() : MRBINDC_THROW("Parameter `inBodyB` can not be null.", void)), *(const JPH::BodyID *)(inBodyB)),
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_Construct_JPH_CharacterID(const JPH_CharacterID *inCharacterIDB, const JPH_SubShapeID *inSubShapeID)
{
    return (JPH_CharacterVirtual_ContactKey *)new JPH::CharacterVirtual::ContactKey(JPH::CharacterVirtual::ContactKey(
        ((inCharacterIDB ? void() : MRBINDC_THROW("Parameter `inCharacterIDB` can not be null.", void)), *(const JPH::CharacterID *)(inCharacterIDB)),
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

void JPH_CharacterVirtual_ContactKey_Destroy(const JPH_CharacterVirtual_ContactKey *_this)
{
    delete ((const JPH::CharacterVirtual::ContactKey *)_this);
}

void JPH_CharacterVirtual_ContactKey_DestroyArray(const JPH_CharacterVirtual_ContactKey *_this)
{
    delete[] ((const JPH::CharacterVirtual::ContactKey *)_this);
}

JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_ContactKey_AssignFromAnother(JPH_CharacterVirtual_ContactKey *_this, const JPH_CharacterVirtual_ContactKey *inContact)
{
    return (JPH_CharacterVirtual_ContactKey *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::ContactKey *)(_this)).operator=(
        mrbindc_details::unmove(((inContact ? void() : MRBINDC_THROW("Parameter `inContact` can not be null.", void)), JPH::CharacterVirtual::ContactKey(*(JPH::CharacterVirtual::ContactKey *)inContact)))
    ));
}

bool JPH_CharacterVirtual_ContactKey_IsSameBody(const JPH_CharacterVirtual_ContactKey *_this, const JPH_CharacterVirtual_ContactKey *inOther)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::ContactKey *)(_this)).IsSameBody(
        ((inOther ? void() : MRBINDC_THROW("Parameter `inOther` can not be null.", void)), *(const JPH::CharacterVirtual::ContactKey *)(inOther))
    );
}

bool Jolt_equal_JPH_CharacterVirtual_ContactKey(const JPH_CharacterVirtual_ContactKey *_this, const JPH_CharacterVirtual_ContactKey *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::ContactKey *)(_this)).operator==(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::CharacterVirtual::ContactKey *)(inRHS))
    );
}

bool Jolt_not_equal_JPH_CharacterVirtual_ContactKey(const JPH_CharacterVirtual_ContactKey *_this, const JPH_CharacterVirtual_ContactKey *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::ContactKey *)(_this)).operator!=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::CharacterVirtual::ContactKey *)(inRHS))
    );
}

uint64_t JPH_CharacterVirtual_ContactKey_GetHash(const JPH_CharacterVirtual_ContactKey *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::ContactKey *)(_this)).GetHash();
}

const JPH_Vec3 *JPH_CharacterVirtual_Contact_Get_mPosition(const JPH_CharacterVirtual_Contact *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mPosition);
}

JPH_Vec3 *JPH_CharacterVirtual_Contact_GetMutable_mPosition(JPH_CharacterVirtual_Contact *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mPosition);
}

const JPH_Vec3 *JPH_CharacterVirtual_Contact_Get_mLinearVelocity(const JPH_CharacterVirtual_Contact *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mLinearVelocity);
}

JPH_Vec3 *JPH_CharacterVirtual_Contact_GetMutable_mLinearVelocity(JPH_CharacterVirtual_Contact *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mLinearVelocity);
}

const JPH_Vec3 *JPH_CharacterVirtual_Contact_Get_mContactNormal(const JPH_CharacterVirtual_Contact *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mContactNormal);
}

JPH_Vec3 *JPH_CharacterVirtual_Contact_GetMutable_mContactNormal(JPH_CharacterVirtual_Contact *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mContactNormal);
}

const JPH_Vec3 *JPH_CharacterVirtual_Contact_Get_mSurfaceNormal(const JPH_CharacterVirtual_Contact *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mSurfaceNormal);
}

JPH_Vec3 *JPH_CharacterVirtual_Contact_GetMutable_mSurfaceNormal(JPH_CharacterVirtual_Contact *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mSurfaceNormal);
}

const float *JPH_CharacterVirtual_Contact_Get_mDistance(const JPH_CharacterVirtual_Contact *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mDistance);
}

void JPH_CharacterVirtual_Contact_Set_mDistance(JPH_CharacterVirtual_Contact *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mDistance = value;
}

float *JPH_CharacterVirtual_Contact_GetMutable_mDistance(JPH_CharacterVirtual_Contact *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mDistance);
}

const float *JPH_CharacterVirtual_Contact_Get_mFraction(const JPH_CharacterVirtual_Contact *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mFraction);
}

void JPH_CharacterVirtual_Contact_Set_mFraction(JPH_CharacterVirtual_Contact *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mFraction = value;
}

float *JPH_CharacterVirtual_Contact_GetMutable_mFraction(JPH_CharacterVirtual_Contact *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mFraction);
}

const JPH_EMotionType *JPH_CharacterVirtual_Contact_Get_mMotionTypeB(const JPH_CharacterVirtual_Contact *_this)
{
    return (const JPH_EMotionType *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mMotionTypeB);
}

void JPH_CharacterVirtual_Contact_Set_mMotionTypeB(JPH_CharacterVirtual_Contact *_this, JPH_EMotionType value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mMotionTypeB = ((JPH::EMotionType)value);
}

JPH_EMotionType *JPH_CharacterVirtual_Contact_GetMutable_mMotionTypeB(JPH_CharacterVirtual_Contact *_this)
{
    return (JPH_EMotionType *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mMotionTypeB);
}

const bool *JPH_CharacterVirtual_Contact_Get_mIsSensorB(const JPH_CharacterVirtual_Contact *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mIsSensorB);
}

void JPH_CharacterVirtual_Contact_Set_mIsSensorB(JPH_CharacterVirtual_Contact *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mIsSensorB = value;
}

bool *JPH_CharacterVirtual_Contact_GetMutable_mIsSensorB(JPH_CharacterVirtual_Contact *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mIsSensorB);
}

const JPH_CharacterVirtual *const *JPH_CharacterVirtual_Contact_Get_mCharacterB(const JPH_CharacterVirtual_Contact *_this)
{
    return (const JPH_CharacterVirtual *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mCharacterB);
}

void JPH_CharacterVirtual_Contact_Set_mCharacterB(JPH_CharacterVirtual_Contact *_this, const JPH_CharacterVirtual *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mCharacterB = ((const JPH::CharacterVirtual *)value);
}

const JPH_CharacterVirtual **JPH_CharacterVirtual_Contact_GetMutable_mCharacterB(JPH_CharacterVirtual_Contact *_this)
{
    return (const JPH_CharacterVirtual **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mCharacterB);
}

const uint64_t *JPH_CharacterVirtual_Contact_Get_mUserData(const JPH_CharacterVirtual_Contact *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mUserData);
}

void JPH_CharacterVirtual_Contact_Set_mUserData(JPH_CharacterVirtual_Contact *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mUserData = value;
}

uint64_t *JPH_CharacterVirtual_Contact_GetMutable_mUserData(JPH_CharacterVirtual_Contact *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mUserData);
}

const JPH_PhysicsMaterial *const *JPH_CharacterVirtual_Contact_Get_mMaterial(const JPH_CharacterVirtual_Contact *_this)
{
    return (const JPH_PhysicsMaterial *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mMaterial);
}

void JPH_CharacterVirtual_Contact_Set_mMaterial(JPH_CharacterVirtual_Contact *_this, const JPH_PhysicsMaterial *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mMaterial = ((const JPH::PhysicsMaterial *)value);
}

const JPH_PhysicsMaterial **JPH_CharacterVirtual_Contact_GetMutable_mMaterial(JPH_CharacterVirtual_Contact *_this)
{
    return (const JPH_PhysicsMaterial **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mMaterial);
}

const bool *JPH_CharacterVirtual_Contact_Get_mHadCollision(const JPH_CharacterVirtual_Contact *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mHadCollision);
}

void JPH_CharacterVirtual_Contact_Set_mHadCollision(JPH_CharacterVirtual_Contact *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mHadCollision = value;
}

bool *JPH_CharacterVirtual_Contact_GetMutable_mHadCollision(JPH_CharacterVirtual_Contact *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mHadCollision);
}

const bool *JPH_CharacterVirtual_Contact_Get_mWasDiscarded(const JPH_CharacterVirtual_Contact *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mWasDiscarded);
}

void JPH_CharacterVirtual_Contact_Set_mWasDiscarded(JPH_CharacterVirtual_Contact *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mWasDiscarded = value;
}

bool *JPH_CharacterVirtual_Contact_GetMutable_mWasDiscarded(JPH_CharacterVirtual_Contact *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mWasDiscarded);
}

const bool *JPH_CharacterVirtual_Contact_Get_mCanPushCharacter(const JPH_CharacterVirtual_Contact *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mCanPushCharacter);
}

void JPH_CharacterVirtual_Contact_Set_mCanPushCharacter(JPH_CharacterVirtual_Contact *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mCanPushCharacter = value;
}

bool *JPH_CharacterVirtual_Contact_GetMutable_mCanPushCharacter(JPH_CharacterVirtual_Contact *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mCanPushCharacter);
}

const JPH_BodyID *JPH_CharacterVirtual_Contact_Get_mBodyB(const JPH_CharacterVirtual_Contact *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mBodyB);
}

void JPH_CharacterVirtual_Contact_Set_mBodyB(JPH_CharacterVirtual_Contact *_this, JPH_BodyID value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mBodyB = MRBINDC_BIT_CAST((JPH::BodyID), value);
}

JPH_BodyID *JPH_CharacterVirtual_Contact_GetMutable_mBodyB(JPH_CharacterVirtual_Contact *_this)
{
    return (JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mBodyB);
}

const JPH_CharacterID *JPH_CharacterVirtual_Contact_Get_mCharacterIDB(const JPH_CharacterVirtual_Contact *_this)
{
    return (const JPH_CharacterID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mCharacterIDB);
}

void JPH_CharacterVirtual_Contact_Set_mCharacterIDB(JPH_CharacterVirtual_Contact *_this, const JPH_CharacterID *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mCharacterIDB = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::CharacterID(*(JPH::CharacterID *)value));
}

JPH_CharacterID *JPH_CharacterVirtual_Contact_GetMutable_mCharacterIDB(JPH_CharacterVirtual_Contact *_this)
{
    return (JPH_CharacterID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mCharacterIDB);
}

const JPH_SubShapeID *JPH_CharacterVirtual_Contact_Get_mSubShapeIDB(const JPH_CharacterVirtual_Contact *_this)
{
    return (const JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).mSubShapeIDB);
}

void JPH_CharacterVirtual_Contact_Set_mSubShapeIDB(JPH_CharacterVirtual_Contact *_this, const JPH_SubShapeID *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mSubShapeIDB = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)value));
}

JPH_SubShapeID *JPH_CharacterVirtual_Contact_GetMutable_mSubShapeIDB(JPH_CharacterVirtual_Contact *_this)
{
    return (JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).mSubShapeIDB);
}

JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_DefaultConstruct(void)
{
    return (JPH_CharacterVirtual_Contact *)new JPH::CharacterVirtual::Contact(JPH::CharacterVirtual::Contact());
}

JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CharacterVirtual_Contact *)(new JPH::CharacterVirtual::Contact[num_elems]{});
}

const JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_OffsetPtr(const JPH_CharacterVirtual_Contact *ptr, ptrdiff_t i)
{
    return (const JPH_CharacterVirtual_Contact *)(((const JPH::CharacterVirtual::Contact *)ptr) + i);
}

JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_OffsetMutablePtr(JPH_CharacterVirtual_Contact *ptr, ptrdiff_t i)
{
    return (JPH_CharacterVirtual_Contact *)(((JPH::CharacterVirtual::Contact *)ptr) + i);
}

const JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_Contact_UpcastTo_JPH_CharacterVirtual_ContactKey(const JPH_CharacterVirtual_Contact *object)
{
    return (const JPH_CharacterVirtual_ContactKey *)(static_cast<const JPH::CharacterVirtual::ContactKey *>(
        ((const JPH::CharacterVirtual::Contact *)object)
    ));
}

JPH_CharacterVirtual_ContactKey *JPH_CharacterVirtual_Contact_MutableUpcastTo_JPH_CharacterVirtual_ContactKey(JPH_CharacterVirtual_Contact *object)
{
    return (JPH_CharacterVirtual_ContactKey *)(static_cast<JPH::CharacterVirtual::ContactKey *>(
        ((JPH::CharacterVirtual::Contact *)object)
    ));
}

const JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_StaticDowncastFrom_JPH_CharacterVirtual_ContactKey(const JPH_CharacterVirtual_ContactKey *object)
{
    return (const JPH_CharacterVirtual_Contact *)(static_cast<const JPH::CharacterVirtual::Contact *>(
        ((const JPH::CharacterVirtual::ContactKey *)object)
    ));
}

JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_MutableStaticDowncastFrom_JPH_CharacterVirtual_ContactKey(JPH_CharacterVirtual_ContactKey *object)
{
    return (JPH_CharacterVirtual_Contact *)(static_cast<JPH::CharacterVirtual::Contact *>(
        ((JPH::CharacterVirtual::ContactKey *)object)
    ));
}

JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_ConstructFromAnother(const JPH_CharacterVirtual_Contact *_other)
{
    return (JPH_CharacterVirtual_Contact *)new JPH::CharacterVirtual::Contact(JPH::CharacterVirtual::Contact(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::CharacterVirtual::Contact(*(JPH::CharacterVirtual::Contact *)_other))
    ));
}

void JPH_CharacterVirtual_Contact_Destroy(const JPH_CharacterVirtual_Contact *_this)
{
    delete ((const JPH::CharacterVirtual::Contact *)_this);
}

void JPH_CharacterVirtual_Contact_DestroyArray(const JPH_CharacterVirtual_Contact *_this)
{
    delete[] ((const JPH::CharacterVirtual::Contact *)_this);
}

JPH_CharacterVirtual_Contact *JPH_CharacterVirtual_Contact_AssignFromAnother(JPH_CharacterVirtual_Contact *_this, const JPH_CharacterVirtual_Contact *_other)
{
    return (JPH_CharacterVirtual_Contact *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterVirtual::Contact *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::CharacterVirtual::Contact(*(JPH::CharacterVirtual::Contact *)_other))
    ));
}

bool JPH_CharacterVirtual_Contact_IsSameBody(const JPH_CharacterVirtual_Contact *_this, const JPH_CharacterVirtual_ContactKey *inOther)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).IsSameBody(
        ((inOther ? void() : MRBINDC_THROW("Parameter `inOther` can not be null.", void)), *(const JPH::CharacterVirtual::ContactKey *)(inOther))
    );
}

bool Jolt_equal_JPH_CharacterVirtual_Contact_JPH_CharacterVirtual_ContactKey(const JPH_CharacterVirtual_Contact *_this, const JPH_CharacterVirtual_ContactKey *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).operator==(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::CharacterVirtual::ContactKey *)(inRHS))
    );
}

bool Jolt_not_equal_JPH_CharacterVirtual_Contact_JPH_CharacterVirtual_ContactKey(const JPH_CharacterVirtual_Contact *_this, const JPH_CharacterVirtual_ContactKey *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).operator!=(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::CharacterVirtual::ContactKey *)(inRHS))
    );
}

uint64_t JPH_CharacterVirtual_Contact_GetHash(const JPH_CharacterVirtual_Contact *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterVirtual::Contact *)(_this)).GetHash();
}

