// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Body/BodyCreationSettings.h"

#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/BodyCreationSettings.h>
#include <Jolt/Physics/Body/MotionQuality.h>
#include <Jolt/Physics/Body/MotionType.h>
#include <Jolt/Physics/Collision/CollisionGroup.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_BodyCreationSettings_Get_mPosition(const JPH_BodyCreationSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mPosition);
}

JPH_Vec3 *JPH_BodyCreationSettings_GetMutable_mPosition(JPH_BodyCreationSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mPosition);
}

const JPH_Quat *JPH_BodyCreationSettings_Get_mRotation(const JPH_BodyCreationSettings *_this)
{
    return (const JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mRotation);
}

JPH_Quat *JPH_BodyCreationSettings_GetMutable_mRotation(JPH_BodyCreationSettings *_this)
{
    return (JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mRotation);
}

const JPH_Vec3 *JPH_BodyCreationSettings_Get_mLinearVelocity(const JPH_BodyCreationSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mLinearVelocity);
}

JPH_Vec3 *JPH_BodyCreationSettings_GetMutable_mLinearVelocity(JPH_BodyCreationSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mLinearVelocity);
}

const JPH_Vec3 *JPH_BodyCreationSettings_Get_mAngularVelocity(const JPH_BodyCreationSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mAngularVelocity);
}

JPH_Vec3 *JPH_BodyCreationSettings_GetMutable_mAngularVelocity(JPH_BodyCreationSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mAngularVelocity);
}

const uint64_t *JPH_BodyCreationSettings_Get_mUserData(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mUserData);
}

void JPH_BodyCreationSettings_Set_mUserData(JPH_BodyCreationSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_BodyCreationSettings_GetMutable_mUserData(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mUserData);
}

const unsigned short *JPH_BodyCreationSettings_Get_mObjectLayer(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mObjectLayer);
}

void JPH_BodyCreationSettings_Set_mObjectLayer(JPH_BodyCreationSettings *_this, unsigned short value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mObjectLayer = value;
}

unsigned short *JPH_BodyCreationSettings_GetMutable_mObjectLayer(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mObjectLayer);
}

const JPH_CollisionGroup *JPH_BodyCreationSettings_Get_mCollisionGroup(const JPH_BodyCreationSettings *_this)
{
    return (const JPH_CollisionGroup *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mCollisionGroup);
}

void JPH_BodyCreationSettings_Set_mCollisionGroup(JPH_BodyCreationSettings *_this, Jolt_PassBy value_pass_by, JPH_CollisionGroup *value)
{
    MRBINDC_CLASSARG_GUARD(value, JPH::CollisionGroup);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mCollisionGroup = (MRBINDC_CLASSARG_DEF_CTOR(value, JPH::CollisionGroup) MRBINDC_CLASSARG_COPY(value, (JPH::CollisionGroup), JPH::CollisionGroup) MRBINDC_CLASSARG_MOVE(value, (JPH::CollisionGroup), JPH::CollisionGroup) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_DefaultArgument, JPH::CollisionGroup) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_NoObject, JPH::CollisionGroup) MRBINDC_CLASSARG_END(value, JPH::CollisionGroup));
}

JPH_CollisionGroup *JPH_BodyCreationSettings_GetMutable_mCollisionGroup(JPH_BodyCreationSettings *_this)
{
    return (JPH_CollisionGroup *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mCollisionGroup);
}

const JPH_EMotionType *JPH_BodyCreationSettings_Get_mMotionType(const JPH_BodyCreationSettings *_this)
{
    return (const JPH_EMotionType *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mMotionType);
}

void JPH_BodyCreationSettings_Set_mMotionType(JPH_BodyCreationSettings *_this, JPH_EMotionType value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mMotionType = ((JPH::EMotionType)value);
}

JPH_EMotionType *JPH_BodyCreationSettings_GetMutable_mMotionType(JPH_BodyCreationSettings *_this)
{
    return (JPH_EMotionType *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mMotionType);
}

const bool *JPH_BodyCreationSettings_Get_mAllowDynamicOrKinematic(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mAllowDynamicOrKinematic);
}

void JPH_BodyCreationSettings_Set_mAllowDynamicOrKinematic(JPH_BodyCreationSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mAllowDynamicOrKinematic = value;
}

bool *JPH_BodyCreationSettings_GetMutable_mAllowDynamicOrKinematic(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mAllowDynamicOrKinematic);
}

const bool *JPH_BodyCreationSettings_Get_mIsSensor(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mIsSensor);
}

void JPH_BodyCreationSettings_Set_mIsSensor(JPH_BodyCreationSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mIsSensor = value;
}

bool *JPH_BodyCreationSettings_GetMutable_mIsSensor(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mIsSensor);
}

const bool *JPH_BodyCreationSettings_Get_mCollideKinematicVsNonDynamic(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mCollideKinematicVsNonDynamic);
}

void JPH_BodyCreationSettings_Set_mCollideKinematicVsNonDynamic(JPH_BodyCreationSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mCollideKinematicVsNonDynamic = value;
}

bool *JPH_BodyCreationSettings_GetMutable_mCollideKinematicVsNonDynamic(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mCollideKinematicVsNonDynamic);
}

const bool *JPH_BodyCreationSettings_Get_mUseManifoldReduction(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mUseManifoldReduction);
}

void JPH_BodyCreationSettings_Set_mUseManifoldReduction(JPH_BodyCreationSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mUseManifoldReduction = value;
}

bool *JPH_BodyCreationSettings_GetMutable_mUseManifoldReduction(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mUseManifoldReduction);
}

const bool *JPH_BodyCreationSettings_Get_mApplyGyroscopicForce(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mApplyGyroscopicForce);
}

void JPH_BodyCreationSettings_Set_mApplyGyroscopicForce(JPH_BodyCreationSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mApplyGyroscopicForce = value;
}

bool *JPH_BodyCreationSettings_GetMutable_mApplyGyroscopicForce(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mApplyGyroscopicForce);
}

const JPH_EMotionQuality *JPH_BodyCreationSettings_Get_mMotionQuality(const JPH_BodyCreationSettings *_this)
{
    return (const JPH_EMotionQuality *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mMotionQuality);
}

void JPH_BodyCreationSettings_Set_mMotionQuality(JPH_BodyCreationSettings *_this, JPH_EMotionQuality value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mMotionQuality = ((JPH::EMotionQuality)value);
}

JPH_EMotionQuality *JPH_BodyCreationSettings_GetMutable_mMotionQuality(JPH_BodyCreationSettings *_this)
{
    return (JPH_EMotionQuality *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mMotionQuality);
}

const bool *JPH_BodyCreationSettings_Get_mEnhancedInternalEdgeRemoval(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mEnhancedInternalEdgeRemoval);
}

void JPH_BodyCreationSettings_Set_mEnhancedInternalEdgeRemoval(JPH_BodyCreationSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mEnhancedInternalEdgeRemoval = value;
}

bool *JPH_BodyCreationSettings_GetMutable_mEnhancedInternalEdgeRemoval(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mEnhancedInternalEdgeRemoval);
}

const bool *JPH_BodyCreationSettings_Get_mAllowSleeping(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mAllowSleeping);
}

void JPH_BodyCreationSettings_Set_mAllowSleeping(JPH_BodyCreationSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mAllowSleeping = value;
}

bool *JPH_BodyCreationSettings_GetMutable_mAllowSleeping(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mAllowSleeping);
}

const float *JPH_BodyCreationSettings_Get_mFriction(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mFriction);
}

void JPH_BodyCreationSettings_Set_mFriction(JPH_BodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mFriction = value;
}

float *JPH_BodyCreationSettings_GetMutable_mFriction(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mFriction);
}

const float *JPH_BodyCreationSettings_Get_mRestitution(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mRestitution);
}

void JPH_BodyCreationSettings_Set_mRestitution(JPH_BodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mRestitution = value;
}

float *JPH_BodyCreationSettings_GetMutable_mRestitution(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mRestitution);
}

const float *JPH_BodyCreationSettings_Get_mLinearDamping(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mLinearDamping);
}

void JPH_BodyCreationSettings_Set_mLinearDamping(JPH_BodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mLinearDamping = value;
}

float *JPH_BodyCreationSettings_GetMutable_mLinearDamping(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mLinearDamping);
}

const float *JPH_BodyCreationSettings_Get_mAngularDamping(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mAngularDamping);
}

void JPH_BodyCreationSettings_Set_mAngularDamping(JPH_BodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mAngularDamping = value;
}

float *JPH_BodyCreationSettings_GetMutable_mAngularDamping(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mAngularDamping);
}

const float *JPH_BodyCreationSettings_Get_mMaxLinearVelocity(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mMaxLinearVelocity);
}

void JPH_BodyCreationSettings_Set_mMaxLinearVelocity(JPH_BodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mMaxLinearVelocity = value;
}

float *JPH_BodyCreationSettings_GetMutable_mMaxLinearVelocity(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mMaxLinearVelocity);
}

const float *JPH_BodyCreationSettings_Get_mMaxAngularVelocity(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mMaxAngularVelocity);
}

void JPH_BodyCreationSettings_Set_mMaxAngularVelocity(JPH_BodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mMaxAngularVelocity = value;
}

float *JPH_BodyCreationSettings_GetMutable_mMaxAngularVelocity(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mMaxAngularVelocity);
}

const float *JPH_BodyCreationSettings_Get_mGravityFactor(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mGravityFactor);
}

void JPH_BodyCreationSettings_Set_mGravityFactor(JPH_BodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mGravityFactor = value;
}

float *JPH_BodyCreationSettings_GetMutable_mGravityFactor(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mGravityFactor);
}

const unsigned int *JPH_BodyCreationSettings_Get_mNumVelocityStepsOverride(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_BodyCreationSettings_Set_mNumVelocityStepsOverride(JPH_BodyCreationSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_BodyCreationSettings_GetMutable_mNumVelocityStepsOverride(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_BodyCreationSettings_Get_mNumPositionStepsOverride(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_BodyCreationSettings_Set_mNumPositionStepsOverride(JPH_BodyCreationSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_BodyCreationSettings_GetMutable_mNumPositionStepsOverride(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_BodyCreationSettings_Get_mInertiaMultiplier(const JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).mInertiaMultiplier);
}

void JPH_BodyCreationSettings_Set_mInertiaMultiplier(JPH_BodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mInertiaMultiplier = value;
}

float *JPH_BodyCreationSettings_GetMutable_mInertiaMultiplier(JPH_BodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).mInertiaMultiplier);
}

JPH_BodyCreationSettings *JPH_BodyCreationSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::BodyCreationSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_BodyCreationSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_BodyCreationSettings *JPH_BodyCreationSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_BodyCreationSettings *)(new JPH::BodyCreationSettings[num_elems]{});
}

const JPH_BodyCreationSettings *JPH_BodyCreationSettings_OffsetPtr(const JPH_BodyCreationSettings *ptr, ptrdiff_t i)
{
    return (const JPH_BodyCreationSettings *)(((const JPH::BodyCreationSettings *)ptr) + i);
}

JPH_BodyCreationSettings *JPH_BodyCreationSettings_OffsetMutablePtr(JPH_BodyCreationSettings *ptr, ptrdiff_t i)
{
    return (JPH_BodyCreationSettings *)(((JPH::BodyCreationSettings *)ptr) + i);
}

JPH_BodyCreationSettings *JPH_BodyCreationSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_BodyCreationSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::BodyCreationSettings);
    return (JPH_BodyCreationSettings *)new JPH::BodyCreationSettings(JPH::BodyCreationSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::BodyCreationSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::BodyCreationSettings), JPH::BodyCreationSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::BodyCreationSettings), JPH::BodyCreationSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::BodyCreationSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::BodyCreationSettings) MRBINDC_CLASSARG_END(_other, JPH::BodyCreationSettings))
    ));
}

JPH_BodyCreationSettings *JPH_BodyCreationSettings_Construct_const_JPH_ShapeSettings_ptr(const JPH_ShapeSettings *inShape, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, JPH_EMotionType inMotionType, unsigned short inObjectLayer)
{
    return (JPH_BodyCreationSettings *)new JPH::BodyCreationSettings(JPH::BodyCreationSettings(
        ((const JPH::ShapeSettings *)inShape),
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((JPH::EMotionType)inMotionType),
        inObjectLayer
    ));
}

JPH_BodyCreationSettings *JPH_BodyCreationSettings_Construct_const_JPH_Shape_ptr(const JPH_Shape *inShape, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, JPH_EMotionType inMotionType, unsigned short inObjectLayer)
{
    return (JPH_BodyCreationSettings *)new JPH::BodyCreationSettings(JPH::BodyCreationSettings(
        ((const JPH::Shape *)inShape),
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((JPH::EMotionType)inMotionType),
        inObjectLayer
    ));
}

void JPH_BodyCreationSettings_Destroy(const JPH_BodyCreationSettings *_this)
{
    delete ((const JPH::BodyCreationSettings *)_this);
}

void JPH_BodyCreationSettings_DestroyArray(const JPH_BodyCreationSettings *_this)
{
    delete[] ((const JPH::BodyCreationSettings *)_this);
}

JPH_BodyCreationSettings *JPH_BodyCreationSettings_AssignFromAnother(JPH_BodyCreationSettings *_this, Jolt_PassBy _other_pass_by, JPH_BodyCreationSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::BodyCreationSettings);
    return (JPH_BodyCreationSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::BodyCreationSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::BodyCreationSettings), JPH::BodyCreationSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::BodyCreationSettings), JPH::BodyCreationSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::BodyCreationSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::BodyCreationSettings) MRBINDC_CLASSARG_END(_other, JPH::BodyCreationSettings))
    ));
}

void *Jolt_new_JPH_BodyCreationSettings_size_t(size_t inCount)
{
    return JPH::BodyCreationSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_BodyCreationSettings_void_ptr(void *inPointer)
{
    JPH::BodyCreationSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_BodyCreationSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BodyCreationSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_BodyCreationSettings_size_t(size_t inCount)
{
    return JPH::BodyCreationSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_BodyCreationSettings_void_ptr(void *inPointer)
{
    JPH::BodyCreationSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_BodyCreationSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BodyCreationSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_BodyCreationSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BodyCreationSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_BodyCreationSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BodyCreationSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_BodyCreationSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BodyCreationSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_BodyCreationSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BodyCreationSettings::operator delete[](
        inPointer,
        inPlace
    );
}

const JPH_ShapeSettings *JPH_BodyCreationSettings_GetShapeSettings(const JPH_BodyCreationSettings *_this)
{
    return (const JPH_ShapeSettings *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).GetShapeSettings());
}

void JPH_BodyCreationSettings_SetShapeSettings(JPH_BodyCreationSettings *_this, const JPH_ShapeSettings *inShape)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).SetShapeSettings(
        ((const JPH::ShapeSettings *)inShape)
    );
}

const JPH_Shape *JPH_BodyCreationSettings_GetShape(const JPH_BodyCreationSettings *_this)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).GetShape());
}

void JPH_BodyCreationSettings_SetShape(JPH_BodyCreationSettings *_this, const JPH_Shape *inShape)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyCreationSettings *)(_this)).SetShape(
        ((const JPH::Shape *)inShape)
    );
}

bool JPH_BodyCreationSettings_HasMassProperties(const JPH_BodyCreationSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyCreationSettings *)(_this)).HasMassProperties();
}

