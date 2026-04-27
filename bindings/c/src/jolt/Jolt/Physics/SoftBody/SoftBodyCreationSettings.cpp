// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/SoftBody/SoftBodyCreationSettings.h"

#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Collision/CollisionGroup.h>
#include <Jolt/Physics/SoftBody/SoftBodyCreationSettings.h>
#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const JPH_Vec3 *JPH_SoftBodyCreationSettings_Get_mPosition(const JPH_SoftBodyCreationSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mPosition);
}

JPH_Vec3 *JPH_SoftBodyCreationSettings_GetMutable_mPosition(JPH_SoftBodyCreationSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mPosition);
}

const JPH_Quat *JPH_SoftBodyCreationSettings_Get_mRotation(const JPH_SoftBodyCreationSettings *_this)
{
    return (const JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mRotation);
}

JPH_Quat *JPH_SoftBodyCreationSettings_GetMutable_mRotation(JPH_SoftBodyCreationSettings *_this)
{
    return (JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mRotation);
}

const uint64_t *JPH_SoftBodyCreationSettings_Get_mUserData(const JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mUserData);
}

void JPH_SoftBodyCreationSettings_Set_mUserData(JPH_SoftBodyCreationSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_SoftBodyCreationSettings_GetMutable_mUserData(JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mUserData);
}

const unsigned short *JPH_SoftBodyCreationSettings_Get_mObjectLayer(const JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mObjectLayer);
}

void JPH_SoftBodyCreationSettings_Set_mObjectLayer(JPH_SoftBodyCreationSettings *_this, unsigned short value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mObjectLayer = value;
}

unsigned short *JPH_SoftBodyCreationSettings_GetMutable_mObjectLayer(JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mObjectLayer);
}

const JPH_CollisionGroup *JPH_SoftBodyCreationSettings_Get_mCollisionGroup(const JPH_SoftBodyCreationSettings *_this)
{
    return (const JPH_CollisionGroup *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mCollisionGroup);
}

void JPH_SoftBodyCreationSettings_Set_mCollisionGroup(JPH_SoftBodyCreationSettings *_this, Jolt_PassBy value_pass_by, JPH_CollisionGroup *value)
{
    MRBINDC_CLASSARG_GUARD(value, JPH::CollisionGroup);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mCollisionGroup = (MRBINDC_CLASSARG_DEF_CTOR(value, JPH::CollisionGroup) MRBINDC_CLASSARG_COPY(value, (JPH::CollisionGroup), JPH::CollisionGroup) MRBINDC_CLASSARG_MOVE(value, (JPH::CollisionGroup), JPH::CollisionGroup) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_DefaultArgument, JPH::CollisionGroup) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_NoObject, JPH::CollisionGroup) MRBINDC_CLASSARG_END(value, JPH::CollisionGroup));
}

JPH_CollisionGroup *JPH_SoftBodyCreationSettings_GetMutable_mCollisionGroup(JPH_SoftBodyCreationSettings *_this)
{
    return (JPH_CollisionGroup *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mCollisionGroup);
}

const unsigned int *JPH_SoftBodyCreationSettings_Get_mNumIterations(const JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mNumIterations);
}

void JPH_SoftBodyCreationSettings_Set_mNumIterations(JPH_SoftBodyCreationSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mNumIterations = value;
}

unsigned int *JPH_SoftBodyCreationSettings_GetMutable_mNumIterations(JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mNumIterations);
}

const float *JPH_SoftBodyCreationSettings_Get_mLinearDamping(const JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mLinearDamping);
}

void JPH_SoftBodyCreationSettings_Set_mLinearDamping(JPH_SoftBodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mLinearDamping = value;
}

float *JPH_SoftBodyCreationSettings_GetMutable_mLinearDamping(JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mLinearDamping);
}

const float *JPH_SoftBodyCreationSettings_Get_mMaxLinearVelocity(const JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mMaxLinearVelocity);
}

void JPH_SoftBodyCreationSettings_Set_mMaxLinearVelocity(JPH_SoftBodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mMaxLinearVelocity = value;
}

float *JPH_SoftBodyCreationSettings_GetMutable_mMaxLinearVelocity(JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mMaxLinearVelocity);
}

const float *JPH_SoftBodyCreationSettings_Get_mRestitution(const JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mRestitution);
}

void JPH_SoftBodyCreationSettings_Set_mRestitution(JPH_SoftBodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mRestitution = value;
}

float *JPH_SoftBodyCreationSettings_GetMutable_mRestitution(JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mRestitution);
}

const float *JPH_SoftBodyCreationSettings_Get_mFriction(const JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mFriction);
}

void JPH_SoftBodyCreationSettings_Set_mFriction(JPH_SoftBodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mFriction = value;
}

float *JPH_SoftBodyCreationSettings_GetMutable_mFriction(JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mFriction);
}

const float *JPH_SoftBodyCreationSettings_Get_mPressure(const JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mPressure);
}

void JPH_SoftBodyCreationSettings_Set_mPressure(JPH_SoftBodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mPressure = value;
}

float *JPH_SoftBodyCreationSettings_GetMutable_mPressure(JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mPressure);
}

const float *JPH_SoftBodyCreationSettings_Get_mGravityFactor(const JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mGravityFactor);
}

void JPH_SoftBodyCreationSettings_Set_mGravityFactor(JPH_SoftBodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mGravityFactor = value;
}

float *JPH_SoftBodyCreationSettings_GetMutable_mGravityFactor(JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mGravityFactor);
}

const float *JPH_SoftBodyCreationSettings_Get_mVertexRadius(const JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mVertexRadius);
}

void JPH_SoftBodyCreationSettings_Set_mVertexRadius(JPH_SoftBodyCreationSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mVertexRadius = value;
}

float *JPH_SoftBodyCreationSettings_GetMutable_mVertexRadius(JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mVertexRadius);
}

const bool *JPH_SoftBodyCreationSettings_Get_mUpdatePosition(const JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mUpdatePosition);
}

void JPH_SoftBodyCreationSettings_Set_mUpdatePosition(JPH_SoftBodyCreationSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mUpdatePosition = value;
}

bool *JPH_SoftBodyCreationSettings_GetMutable_mUpdatePosition(JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mUpdatePosition);
}

const bool *JPH_SoftBodyCreationSettings_Get_mMakeRotationIdentity(const JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mMakeRotationIdentity);
}

void JPH_SoftBodyCreationSettings_Set_mMakeRotationIdentity(JPH_SoftBodyCreationSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mMakeRotationIdentity = value;
}

bool *JPH_SoftBodyCreationSettings_GetMutable_mMakeRotationIdentity(JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mMakeRotationIdentity);
}

const bool *JPH_SoftBodyCreationSettings_Get_mAllowSleeping(const JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mAllowSleeping);
}

void JPH_SoftBodyCreationSettings_Set_mAllowSleeping(JPH_SoftBodyCreationSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mAllowSleeping = value;
}

bool *JPH_SoftBodyCreationSettings_GetMutable_mAllowSleeping(JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mAllowSleeping);
}

const bool *JPH_SoftBodyCreationSettings_Get_mFacesDoubleSided(const JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(_this)).mFacesDoubleSided);
}

void JPH_SoftBodyCreationSettings_Set_mFacesDoubleSided(JPH_SoftBodyCreationSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mFacesDoubleSided = value;
}

bool *JPH_SoftBodyCreationSettings_GetMutable_mFacesDoubleSided(JPH_SoftBodyCreationSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).mFacesDoubleSided);
}

JPH_SoftBodyCreationSettings *JPH_SoftBodyCreationSettings_DefaultConstruct(void)
{
    return (JPH_SoftBodyCreationSettings *)new JPH::SoftBodyCreationSettings(JPH::SoftBodyCreationSettings());
}

JPH_SoftBodyCreationSettings *JPH_SoftBodyCreationSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodyCreationSettings *)(new JPH::SoftBodyCreationSettings[num_elems]{});
}

const JPH_SoftBodyCreationSettings *JPH_SoftBodyCreationSettings_OffsetPtr(const JPH_SoftBodyCreationSettings *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodyCreationSettings *)(((const JPH::SoftBodyCreationSettings *)ptr) + i);
}

JPH_SoftBodyCreationSettings *JPH_SoftBodyCreationSettings_OffsetMutablePtr(JPH_SoftBodyCreationSettings *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodyCreationSettings *)(((JPH::SoftBodyCreationSettings *)ptr) + i);
}

JPH_SoftBodyCreationSettings *JPH_SoftBodyCreationSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SoftBodyCreationSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SoftBodyCreationSettings);
    return (JPH_SoftBodyCreationSettings *)new JPH::SoftBodyCreationSettings(JPH::SoftBodyCreationSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SoftBodyCreationSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::SoftBodyCreationSettings), JPH::SoftBodyCreationSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::SoftBodyCreationSettings), JPH::SoftBodyCreationSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SoftBodyCreationSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SoftBodyCreationSettings) MRBINDC_CLASSARG_END(_other, JPH::SoftBodyCreationSettings))
    ));
}

JPH_SoftBodyCreationSettings *JPH_SoftBodyCreationSettings_Construct(const JPH_SoftBodySharedSettings *inSettings, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, unsigned short inObjectLayer)
{
    return (JPH_SoftBodyCreationSettings *)new JPH::SoftBodyCreationSettings(JPH::SoftBodyCreationSettings(
        ((const JPH::SoftBodySharedSettings *)inSettings),
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        inObjectLayer
    ));
}

void JPH_SoftBodyCreationSettings_Destroy(const JPH_SoftBodyCreationSettings *_this)
{
    delete ((const JPH::SoftBodyCreationSettings *)_this);
}

void JPH_SoftBodyCreationSettings_DestroyArray(const JPH_SoftBodyCreationSettings *_this)
{
    delete[] ((const JPH::SoftBodyCreationSettings *)_this);
}

JPH_SoftBodyCreationSettings *JPH_SoftBodyCreationSettings_AssignFromAnother(JPH_SoftBodyCreationSettings *_this, Jolt_PassBy _other_pass_by, JPH_SoftBodyCreationSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SoftBodyCreationSettings);
    return (JPH_SoftBodyCreationSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyCreationSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SoftBodyCreationSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::SoftBodyCreationSettings), JPH::SoftBodyCreationSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::SoftBodyCreationSettings), JPH::SoftBodyCreationSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SoftBodyCreationSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SoftBodyCreationSettings) MRBINDC_CLASSARG_END(_other, JPH::SoftBodyCreationSettings))
    ));
}

void *Jolt_new_JPH_SoftBodyCreationSettings_size_t(size_t inCount)
{
    return JPH::SoftBodyCreationSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr(void *inPointer)
{
    JPH::SoftBodyCreationSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SoftBodyCreationSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SoftBodyCreationSettings_size_t(size_t inCount)
{
    return JPH::SoftBodyCreationSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr(void *inPointer)
{
    JPH::SoftBodyCreationSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SoftBodyCreationSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SoftBodyCreationSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SoftBodyCreationSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodyCreationSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SoftBodyCreationSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SoftBodyCreationSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodyCreationSettings::operator delete[](
        inPointer,
        inPlace
    );
}

