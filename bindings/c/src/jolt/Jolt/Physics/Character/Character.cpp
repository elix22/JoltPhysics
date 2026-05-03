// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Character/Character.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Geometry/Plane.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Character/Character.h>
#include <Jolt/Physics/Character/CharacterBase.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/TransformedShape.h>
#include <Jolt/Physics/EActivation.h>
#include <Jolt/Physics/PhysicsSystem.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const unsigned short *JPH_CharacterSettings_Get_mLayer(const JPH_CharacterSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterSettings *)(_this)).mLayer);
}

void JPH_CharacterSettings_Set_mLayer(JPH_CharacterSettings *_this, unsigned short value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mLayer = value;
}

unsigned short *JPH_CharacterSettings_GetMutable_mLayer(JPH_CharacterSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mLayer);
}

const float *JPH_CharacterSettings_Get_mMass(const JPH_CharacterSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterSettings *)(_this)).mMass);
}

void JPH_CharacterSettings_Set_mMass(JPH_CharacterSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mMass = value;
}

float *JPH_CharacterSettings_GetMutable_mMass(JPH_CharacterSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mMass);
}

const float *JPH_CharacterSettings_Get_mFriction(const JPH_CharacterSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterSettings *)(_this)).mFriction);
}

void JPH_CharacterSettings_Set_mFriction(JPH_CharacterSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mFriction = value;
}

float *JPH_CharacterSettings_GetMutable_mFriction(JPH_CharacterSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mFriction);
}

const float *JPH_CharacterSettings_Get_mGravityFactor(const JPH_CharacterSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterSettings *)(_this)).mGravityFactor);
}

void JPH_CharacterSettings_Set_mGravityFactor(JPH_CharacterSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mGravityFactor = value;
}

float *JPH_CharacterSettings_GetMutable_mGravityFactor(JPH_CharacterSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mGravityFactor);
}

const JPH_Vec3 *JPH_CharacterSettings_Get_mUp(const JPH_CharacterSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterSettings *)(_this)).mUp);
}

JPH_Vec3 *JPH_CharacterSettings_GetMutable_mUp(JPH_CharacterSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mUp);
}

const JPH_Plane *JPH_CharacterSettings_Get_mSupportingVolume(const JPH_CharacterSettings *_this)
{
    return (const JPH_Plane *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterSettings *)(_this)).mSupportingVolume);
}

void JPH_CharacterSettings_Set_mSupportingVolume(JPH_CharacterSettings *_this, const JPH_Plane *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mSupportingVolume = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::Plane(*(JPH::Plane *)value));
}

JPH_Plane *JPH_CharacterSettings_GetMutable_mSupportingVolume(JPH_CharacterSettings *_this)
{
    return (JPH_Plane *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mSupportingVolume);
}

const float *JPH_CharacterSettings_Get_mMaxSlopeAngle(const JPH_CharacterSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterSettings *)(_this)).mMaxSlopeAngle);
}

void JPH_CharacterSettings_Set_mMaxSlopeAngle(JPH_CharacterSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mMaxSlopeAngle = value;
}

float *JPH_CharacterSettings_GetMutable_mMaxSlopeAngle(JPH_CharacterSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mMaxSlopeAngle);
}

const bool *JPH_CharacterSettings_Get_mEnhancedInternalEdgeRemoval(const JPH_CharacterSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterSettings *)(_this)).mEnhancedInternalEdgeRemoval);
}

void JPH_CharacterSettings_Set_mEnhancedInternalEdgeRemoval(JPH_CharacterSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mEnhancedInternalEdgeRemoval = value;
}

bool *JPH_CharacterSettings_GetMutable_mEnhancedInternalEdgeRemoval(JPH_CharacterSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).mEnhancedInternalEdgeRemoval);
}

JPH_CharacterSettings *JPH_CharacterSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::CharacterSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_CharacterSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_CharacterSettings *JPH_CharacterSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CharacterSettings *)(new JPH::CharacterSettings[num_elems]{});
}

const JPH_CharacterSettings *JPH_CharacterSettings_OffsetPtr(const JPH_CharacterSettings *ptr, ptrdiff_t i)
{
    return (const JPH_CharacterSettings *)(((const JPH::CharacterSettings *)ptr) + i);
}

JPH_CharacterSettings *JPH_CharacterSettings_OffsetMutablePtr(JPH_CharacterSettings *ptr, ptrdiff_t i)
{
    return (JPH_CharacterSettings *)(((JPH::CharacterSettings *)ptr) + i);
}

const JPH_RefTarget_JPH_CharacterBaseSettings *JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(const JPH_CharacterSettings *object)
{
    return (const JPH_RefTarget_JPH_CharacterBaseSettings *)(static_cast<const JPH::RefTarget<JPH::CharacterBaseSettings> *>(
        ((const JPH::CharacterSettings *)object)
    ));
}

JPH_RefTarget_JPH_CharacterBaseSettings *JPH_CharacterSettings_MutableUpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(JPH_CharacterSettings *object)
{
    return (JPH_RefTarget_JPH_CharacterBaseSettings *)(static_cast<JPH::RefTarget<JPH::CharacterBaseSettings> *>(
        ((JPH::CharacterSettings *)object)
    ));
}

const JPH_CharacterSettings *JPH_CharacterSettings_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(const JPH_RefTarget_JPH_CharacterBaseSettings *object)
{
    return (const JPH_CharacterSettings *)(static_cast<const JPH::CharacterSettings *>(
        ((const JPH::RefTarget<JPH::CharacterBaseSettings> *)object)
    ));
}

JPH_CharacterSettings *JPH_CharacterSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(JPH_RefTarget_JPH_CharacterBaseSettings *object)
{
    return (JPH_CharacterSettings *)(static_cast<JPH::CharacterSettings *>(
        ((JPH::RefTarget<JPH::CharacterBaseSettings> *)object)
    ));
}

const JPH_CharacterBaseSettings *JPH_CharacterSettings_UpcastTo_JPH_CharacterBaseSettings(const JPH_CharacterSettings *object)
{
    return (const JPH_CharacterBaseSettings *)(static_cast<const JPH::CharacterBaseSettings *>(
        ((const JPH::CharacterSettings *)object)
    ));
}

JPH_CharacterBaseSettings *JPH_CharacterSettings_MutableUpcastTo_JPH_CharacterBaseSettings(JPH_CharacterSettings *object)
{
    return (JPH_CharacterBaseSettings *)(static_cast<JPH::CharacterBaseSettings *>(
        ((JPH::CharacterSettings *)object)
    ));
}

const JPH_CharacterSettings *JPH_CharacterSettings_StaticDowncastFrom_JPH_CharacterBaseSettings(const JPH_CharacterBaseSettings *object)
{
    return (const JPH_CharacterSettings *)(static_cast<const JPH::CharacterSettings *>(
        ((const JPH::CharacterBaseSettings *)object)
    ));
}

JPH_CharacterSettings *JPH_CharacterSettings_MutableStaticDowncastFrom_JPH_CharacterBaseSettings(JPH_CharacterBaseSettings *object)
{
    return (JPH_CharacterSettings *)(static_cast<JPH::CharacterSettings *>(
        ((JPH::CharacterBaseSettings *)object)
    ));
}

JPH_CharacterSettings *JPH_CharacterSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CharacterSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CharacterSettings);
    return (JPH_CharacterSettings *)new JPH::CharacterSettings(JPH::CharacterSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CharacterSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::CharacterSettings), JPH::CharacterSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CharacterSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CharacterSettings) MRBINDC_CLASSARG_END(_other, JPH::CharacterSettings))
    ));
}

void JPH_CharacterSettings_Destroy(const JPH_CharacterSettings *_this)
{
    delete ((const JPH::CharacterSettings *)_this);
}

void JPH_CharacterSettings_DestroyArray(const JPH_CharacterSettings *_this)
{
    delete[] ((const JPH::CharacterSettings *)_this);
}

JPH_CharacterSettings *JPH_CharacterSettings_AssignFromAnother(JPH_CharacterSettings *_this, Jolt_PassBy _other_pass_by, JPH_CharacterSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CharacterSettings);
    return (JPH_CharacterSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterSettings *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CharacterSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::CharacterSettings), JPH::CharacterSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CharacterSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CharacterSettings) MRBINDC_CLASSARG_END(_other, JPH::CharacterSettings)))
    ));
}

void *Jolt_new_JPH_CharacterSettings_size_t(size_t inCount)
{
    return JPH::CharacterSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CharacterSettings_void_ptr(void *inPointer)
{
    JPH::CharacterSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CharacterSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CharacterSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CharacterSettings_size_t(size_t inCount)
{
    return JPH::CharacterSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CharacterSettings_void_ptr(void *inPointer)
{
    JPH::CharacterSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CharacterSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CharacterSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CharacterSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CharacterSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CharacterSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CharacterSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CharacterSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CharacterSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CharacterSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CharacterSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_CharacterSettings_SetEmbedded(const JPH_CharacterSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_CharacterSettings_GetRefCount(const JPH_CharacterSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterSettings *)(_this)).GetRefCount();
}

void JPH_CharacterSettings_AddRef(const JPH_CharacterSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterSettings *)(_this)).AddRef();
}

void JPH_CharacterSettings_Release(const JPH_CharacterSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterSettings *)(_this)).Release();
}

int JPH_CharacterSettings_sInternalGetRefCountOffset(void)
{
    return JPH::CharacterSettings::sInternalGetRefCountOffset();
}

JPH_Character *JPH_Character_Construct(const JPH_CharacterSettings *inSettings, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, uint64_t inUserData, JPH_PhysicsSystem *inSystem)
{
    return (JPH_Character *)new JPH::Character(JPH::Character(
        ((const JPH::CharacterSettings *)inSettings),
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        inUserData,
        ((JPH::PhysicsSystem *)inSystem)
    ));
}

const JPH_Character *JPH_Character_OffsetPtr(const JPH_Character *ptr, ptrdiff_t i)
{
    return (const JPH_Character *)(((const JPH::Character *)ptr) + i);
}

JPH_Character *JPH_Character_OffsetMutablePtr(JPH_Character *ptr, ptrdiff_t i)
{
    return (JPH_Character *)(((JPH::Character *)ptr) + i);
}

const JPH_RefTarget_JPH_CharacterBase *JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase(const JPH_Character *object)
{
    return (const JPH_RefTarget_JPH_CharacterBase *)(static_cast<const JPH::RefTarget<JPH::CharacterBase> *>(
        ((const JPH::Character *)object)
    ));
}

JPH_RefTarget_JPH_CharacterBase *JPH_Character_MutableUpcastTo_JPH_RefTarget_JPH_CharacterBase(JPH_Character *object)
{
    return (JPH_RefTarget_JPH_CharacterBase *)(static_cast<JPH::RefTarget<JPH::CharacterBase> *>(
        ((JPH::Character *)object)
    ));
}

const JPH_Character *JPH_Character_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(const JPH_RefTarget_JPH_CharacterBase *object)
{
    return (const JPH_Character *)(static_cast<const JPH::Character *>(
        ((const JPH::RefTarget<JPH::CharacterBase> *)object)
    ));
}

JPH_Character *JPH_Character_MutableStaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(JPH_RefTarget_JPH_CharacterBase *object)
{
    return (JPH_Character *)(static_cast<JPH::Character *>(
        ((JPH::RefTarget<JPH::CharacterBase> *)object)
    ));
}

const JPH_NonCopyable *JPH_Character_UpcastTo_JPH_NonCopyable(const JPH_Character *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::Character *)object)
    ));
}

JPH_NonCopyable *JPH_Character_MutableUpcastTo_JPH_NonCopyable(JPH_Character *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::Character *)object)
    ));
}

const JPH_Character *JPH_Character_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_Character *)(static_cast<const JPH::Character *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_Character *JPH_Character_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_Character *)(static_cast<JPH::Character *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_CharacterBase *JPH_Character_UpcastTo_JPH_CharacterBase(const JPH_Character *object)
{
    return (const JPH_CharacterBase *)(static_cast<const JPH::CharacterBase *>(
        ((const JPH::Character *)object)
    ));
}

JPH_CharacterBase *JPH_Character_MutableUpcastTo_JPH_CharacterBase(JPH_Character *object)
{
    return (JPH_CharacterBase *)(static_cast<JPH::CharacterBase *>(
        ((JPH::Character *)object)
    ));
}

const JPH_Character *JPH_Character_StaticDowncastFrom_JPH_CharacterBase(const JPH_CharacterBase *object)
{
    return (const JPH_Character *)(static_cast<const JPH::Character *>(
        ((const JPH::CharacterBase *)object)
    ));
}

JPH_Character *JPH_Character_MutableStaticDowncastFrom_JPH_CharacterBase(JPH_CharacterBase *object)
{
    return (JPH_Character *)(static_cast<JPH::Character *>(
        ((JPH::CharacterBase *)object)
    ));
}

void JPH_Character_Destroy(const JPH_Character *_this)
{
    delete ((const JPH::Character *)_this);
}

void JPH_Character_DestroyArray(const JPH_Character *_this)
{
    delete[] ((const JPH::Character *)_this);
}

void *Jolt_new_JPH_Character_size_t(size_t inCount)
{
    return JPH::Character::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Character_void_ptr(void *inPointer)
{
    JPH::Character::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Character_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Character::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Character_size_t(size_t inCount)
{
    return JPH::Character::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Character_void_ptr(void *inPointer)
{
    JPH::Character::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Character_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Character::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Character_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Character::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Character_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Character::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Character_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Character::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Character_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Character::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_Character_AddToPhysicsSystem(JPH_Character *_this, const JPH_EActivation *inActivationMode, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Character *)(_this)).AddToPhysicsSystem(
        (inActivationMode ? (JPH::EActivation)(*inActivationMode) : static_cast<JPH::EActivation>(JPH::EActivation::Activate)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Character_RemoveFromPhysicsSystem(JPH_Character *_this, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Character *)(_this)).RemoveFromPhysicsSystem(
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Character_Activate(JPH_Character *_this, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Character *)(_this)).Activate(
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Character_PostSimulation(JPH_Character *_this, float inMaxSeparationDistance, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Character *)(_this)).PostSimulation(
        inMaxSeparationDistance,
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Character_SetLinearAndAngularVelocity(JPH_Character *_this, const JPH_Vec3 *inLinearVelocity, const JPH_Vec3 *inAngularVelocity, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Character *)(_this)).SetLinearAndAngularVelocity(
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity)),
        ((inAngularVelocity ? void() : MRBINDC_THROW("Parameter `inAngularVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocity)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

JPH_Vec3 *JPH_Character_GetLinearVelocity(const JPH_Character *_this, const bool *inLockBodies)
{
    using namespace JPH;
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetLinearVelocity(
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    ));
}

void JPH_Character_SetLinearVelocity(JPH_Character *_this, const JPH_Vec3 *inLinearVelocity, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Character *)(_this)).SetLinearVelocity(
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Character_AddLinearVelocity(JPH_Character *_this, const JPH_Vec3 *inLinearVelocity, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Character *)(_this)).AddLinearVelocity(
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Character_AddImpulse(JPH_Character *_this, const JPH_Vec3 *inImpulse, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Character *)(_this)).AddImpulse(
        ((inImpulse ? void() : MRBINDC_THROW("Parameter `inImpulse` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inImpulse)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

JPH_BodyID JPH_Character_GetBodyID(const JPH_Character *_this)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetBodyID());
}

void JPH_Character_GetPositionAndRotation(const JPH_Character *_this, JPH_Vec3 *outPosition, JPH_Quat *outRotation, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetPositionAndRotation(
        ((outPosition ? void() : MRBINDC_THROW("Parameter `outPosition` can not be null.", void)), *(JPH::Vec3 *)(outPosition)),
        ((outRotation ? void() : MRBINDC_THROW("Parameter `outRotation` can not be null.", void)), *(JPH::Quat *)(outRotation)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Character_SetPositionAndRotation(const JPH_Character *_this, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const JPH_EActivation *inActivationMode, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).SetPositionAndRotation(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        (inActivationMode ? (JPH::EActivation)(*inActivationMode) : static_cast<JPH::EActivation>(JPH::EActivation::Activate)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

JPH_Vec3 *JPH_Character_GetPosition(const JPH_Character *_this, const bool *inLockBodies)
{
    using namespace JPH;
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetPosition(
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    ));
}

void JPH_Character_SetPosition(JPH_Character *_this, const JPH_Vec3 *inPosition, const JPH_EActivation *inActivationMode, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Character *)(_this)).SetPosition(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        (inActivationMode ? (JPH::EActivation)(*inActivationMode) : static_cast<JPH::EActivation>(JPH::EActivation::Activate)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

JPH_Quat *JPH_Character_GetRotation(const JPH_Character *_this, const bool *inLockBodies)
{
    using namespace JPH;
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetRotation(
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    ));
}

void JPH_Character_SetRotation(JPH_Character *_this, const JPH_Quat *inRotation, const JPH_EActivation *inActivationMode, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Character *)(_this)).SetRotation(
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        (inActivationMode ? (JPH::EActivation)(*inActivationMode) : static_cast<JPH::EActivation>(JPH::EActivation::Activate)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

JPH_Vec3 *JPH_Character_GetCenterOfMassPosition(const JPH_Character *_this, const bool *inLockBodies)
{
    using namespace JPH;
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetCenterOfMassPosition(
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    ));
}

JPH_Mat44 *JPH_Character_GetWorldTransform(const JPH_Character *_this, const bool *inLockBodies)
{
    using namespace JPH;
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetWorldTransform(
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    ));
}

unsigned short JPH_Character_GetLayer(const JPH_Character *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetLayer();
}

void JPH_Character_SetLayer(JPH_Character *_this, unsigned short inLayer, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Character *)(_this)).SetLayer(
        inLayer,
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

bool JPH_Character_SetShape(JPH_Character *_this, const JPH_Shape *inShape, float inMaxPenetrationDepth, const bool *inLockBodies)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Character *)(_this)).SetShape(
        ((const JPH::Shape *)inShape),
        inMaxPenetrationDepth,
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

JPH_TransformedShape *JPH_Character_GetTransformedShape(const JPH_Character *_this, const bool *inLockBodies)
{
    using namespace JPH;
    return (JPH_TransformedShape *)new JPH::TransformedShape(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetTransformedShape(
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    ));
}

JPH_CharacterSettings *JPH_Character_GetCharacterSettings(const JPH_Character *_this, const bool *inLockBodies)
{
    using namespace JPH;
    return (JPH_CharacterSettings *)new JPH::CharacterSettings(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetCharacterSettings(
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    ));
}

void JPH_Character_SetMaxSlopeAngle(JPH_Character *_this, float inMaxSlopeAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Character *)(_this)).SetMaxSlopeAngle(
        inMaxSlopeAngle
    );
}

float JPH_Character_GetCosMaxSlopeAngle(const JPH_Character *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetCosMaxSlopeAngle();
}

void JPH_Character_SetUp(JPH_Character *_this, const JPH_Vec3 *inUp)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Character *)(_this)).SetUp(
        ((inUp ? void() : MRBINDC_THROW("Parameter `inUp` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inUp))
    );
}

JPH_Vec3 *JPH_Character_GetUp(const JPH_Character *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetUp());
}

bool JPH_Character_IsSlopeTooSteep(const JPH_Character *_this, const JPH_Vec3 *inNormal)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).IsSlopeTooSteep(
        ((inNormal ? void() : MRBINDC_THROW("Parameter `inNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inNormal))
    );
}

const JPH_Shape *JPH_Character_GetShape(const JPH_Character *_this)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetShape());
}

const char *JPH_Character_sToString(JPH_CharacterBase_EGroundState inState)
{
    return JPH::Character::sToString(
        ((JPH::CharacterBase::EGroundState)inState)
    );
}

JPH_CharacterBase_EGroundState JPH_Character_GetGroundState(const JPH_Character *_this)
{
    return (JPH_CharacterBase_EGroundState)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetGroundState());
}

bool JPH_Character_IsSupported(const JPH_Character *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).IsSupported();
}

JPH_Vec3 *JPH_Character_GetGroundPosition(const JPH_Character *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetGroundPosition());
}

JPH_Vec3 *JPH_Character_GetGroundNormal(const JPH_Character *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetGroundNormal());
}

JPH_Vec3 *JPH_Character_GetGroundVelocity(const JPH_Character *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetGroundVelocity());
}

const JPH_PhysicsMaterial *JPH_Character_GetGroundMaterial(const JPH_Character *_this)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetGroundMaterial());
}

JPH_BodyID JPH_Character_GetGroundBodyID(const JPH_Character *_this)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetGroundBodyID());
}

JPH_SubShapeID *JPH_Character_GetGroundSubShapeID(const JPH_Character *_this)
{
    return (JPH_SubShapeID *)new JPH::SubShapeID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetGroundSubShapeID());
}

uint64_t JPH_Character_GetGroundUserData(const JPH_Character *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetGroundUserData();
}

void JPH_Character_SetEmbedded(const JPH_Character *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).SetEmbedded();
}

unsigned int JPH_Character_GetRefCount(const JPH_Character *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).GetRefCount();
}

void JPH_Character_AddRef(const JPH_Character *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).AddRef();
}

void JPH_Character_Release(const JPH_Character *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Character *)(_this)).Release();
}

int JPH_Character_sInternalGetRefCountOffset(void)
{
    return JPH::Character::sInternalGetRefCountOffset();
}

