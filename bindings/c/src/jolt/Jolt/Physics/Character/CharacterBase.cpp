// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Character/CharacterBase.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Character/CharacterBase.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/PhysicsSystem.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const JPH_Vec3 *JPH_CharacterBaseSettings_Get_mUp(const JPH_CharacterBaseSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBaseSettings *)(_this)).mUp);
}

JPH_Vec3 *JPH_CharacterBaseSettings_GetMutable_mUp(JPH_CharacterBaseSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterBaseSettings *)(_this)).mUp);
}

const float *JPH_CharacterBaseSettings_Get_mMaxSlopeAngle(const JPH_CharacterBaseSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBaseSettings *)(_this)).mMaxSlopeAngle);
}

void JPH_CharacterBaseSettings_Set_mMaxSlopeAngle(JPH_CharacterBaseSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterBaseSettings *)(_this)).mMaxSlopeAngle = value;
}

float *JPH_CharacterBaseSettings_GetMutable_mMaxSlopeAngle(JPH_CharacterBaseSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterBaseSettings *)(_this)).mMaxSlopeAngle);
}

const bool *JPH_CharacterBaseSettings_Get_mEnhancedInternalEdgeRemoval(const JPH_CharacterBaseSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBaseSettings *)(_this)).mEnhancedInternalEdgeRemoval);
}

void JPH_CharacterBaseSettings_Set_mEnhancedInternalEdgeRemoval(JPH_CharacterBaseSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterBaseSettings *)(_this)).mEnhancedInternalEdgeRemoval = value;
}

bool *JPH_CharacterBaseSettings_GetMutable_mEnhancedInternalEdgeRemoval(JPH_CharacterBaseSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterBaseSettings *)(_this)).mEnhancedInternalEdgeRemoval);
}

JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_DefaultConstruct(void)
{
    return (JPH_CharacterBaseSettings *)new JPH::CharacterBaseSettings(JPH::CharacterBaseSettings());
}

JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CharacterBaseSettings *)(new JPH::CharacterBaseSettings[num_elems]{});
}

const JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_OffsetPtr(const JPH_CharacterBaseSettings *ptr, ptrdiff_t i)
{
    return (const JPH_CharacterBaseSettings *)(((const JPH::CharacterBaseSettings *)ptr) + i);
}

JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_OffsetMutablePtr(JPH_CharacterBaseSettings *ptr, ptrdiff_t i)
{
    return (JPH_CharacterBaseSettings *)(((JPH::CharacterBaseSettings *)ptr) + i);
}

const JPH_RefTarget_JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(const JPH_CharacterBaseSettings *object)
{
    return (const JPH_RefTarget_JPH_CharacterBaseSettings *)(static_cast<const JPH::RefTarget<JPH::CharacterBaseSettings> *>(
        ((const JPH::CharacterBaseSettings *)object)
    ));
}

JPH_RefTarget_JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_MutableUpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(JPH_CharacterBaseSettings *object)
{
    return (JPH_RefTarget_JPH_CharacterBaseSettings *)(static_cast<JPH::RefTarget<JPH::CharacterBaseSettings> *>(
        ((JPH::CharacterBaseSettings *)object)
    ));
}

const JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(const JPH_RefTarget_JPH_CharacterBaseSettings *object)
{
    return (const JPH_CharacterBaseSettings *)(static_cast<const JPH::CharacterBaseSettings *>(
        ((const JPH::RefTarget<JPH::CharacterBaseSettings> *)object)
    ));
}

JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(JPH_RefTarget_JPH_CharacterBaseSettings *object)
{
    return (JPH_CharacterBaseSettings *)(static_cast<JPH::CharacterBaseSettings *>(
        ((JPH::RefTarget<JPH::CharacterBaseSettings> *)object)
    ));
}

JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CharacterBaseSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CharacterBaseSettings);
    return (JPH_CharacterBaseSettings *)new JPH::CharacterBaseSettings(JPH::CharacterBaseSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CharacterBaseSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::CharacterBaseSettings), JPH::CharacterBaseSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CharacterBaseSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CharacterBaseSettings) MRBINDC_CLASSARG_END(_other, JPH::CharacterBaseSettings))
    ));
}

void JPH_CharacterBaseSettings_Destroy(const JPH_CharacterBaseSettings *_this)
{
    delete ((const JPH::CharacterBaseSettings *)_this);
}

void JPH_CharacterBaseSettings_DestroyArray(const JPH_CharacterBaseSettings *_this)
{
    delete[] ((const JPH::CharacterBaseSettings *)_this);
}

JPH_CharacterBaseSettings *JPH_CharacterBaseSettings_AssignFromAnother(JPH_CharacterBaseSettings *_this, Jolt_PassBy _other_pass_by, JPH_CharacterBaseSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CharacterBaseSettings);
    return (JPH_CharacterBaseSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterBaseSettings *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CharacterBaseSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::CharacterBaseSettings), JPH::CharacterBaseSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CharacterBaseSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CharacterBaseSettings) MRBINDC_CLASSARG_END(_other, JPH::CharacterBaseSettings)))
    ));
}

void *Jolt_new_JPH_CharacterBaseSettings_size_t(size_t inCount)
{
    return JPH::CharacterBaseSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CharacterBaseSettings_void_ptr(void *inPointer)
{
    JPH::CharacterBaseSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CharacterBaseSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CharacterBaseSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CharacterBaseSettings_size_t(size_t inCount)
{
    return JPH::CharacterBaseSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr(void *inPointer)
{
    JPH::CharacterBaseSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CharacterBaseSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CharacterBaseSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CharacterBaseSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CharacterBaseSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CharacterBaseSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CharacterBaseSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CharacterBaseSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CharacterBaseSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_CharacterBaseSettings_SetEmbedded(const JPH_CharacterBaseSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBaseSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_CharacterBaseSettings_GetRefCount(const JPH_CharacterBaseSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBaseSettings *)(_this)).GetRefCount();
}

void JPH_CharacterBaseSettings_AddRef(const JPH_CharacterBaseSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBaseSettings *)(_this)).AddRef();
}

void JPH_CharacterBaseSettings_Release(const JPH_CharacterBaseSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBaseSettings *)(_this)).Release();
}

int JPH_CharacterBaseSettings_sInternalGetRefCountOffset(void)
{
    return JPH::CharacterBaseSettings::sInternalGetRefCountOffset();
}

JPH_CharacterBase *JPH_CharacterBase_Construct(const JPH_CharacterBaseSettings *inSettings, JPH_PhysicsSystem *inSystem)
{
    return (JPH_CharacterBase *)new JPH::CharacterBase(JPH::CharacterBase(
        ((const JPH::CharacterBaseSettings *)inSettings),
        ((JPH::PhysicsSystem *)inSystem)
    ));
}

const JPH_CharacterBase *JPH_CharacterBase_OffsetPtr(const JPH_CharacterBase *ptr, ptrdiff_t i)
{
    return (const JPH_CharacterBase *)(((const JPH::CharacterBase *)ptr) + i);
}

JPH_CharacterBase *JPH_CharacterBase_OffsetMutablePtr(JPH_CharacterBase *ptr, ptrdiff_t i)
{
    return (JPH_CharacterBase *)(((JPH::CharacterBase *)ptr) + i);
}

const JPH_RefTarget_JPH_CharacterBase *JPH_CharacterBase_UpcastTo_JPH_RefTarget_JPH_CharacterBase(const JPH_CharacterBase *object)
{
    return (const JPH_RefTarget_JPH_CharacterBase *)(static_cast<const JPH::RefTarget<JPH::CharacterBase> *>(
        ((const JPH::CharacterBase *)object)
    ));
}

JPH_RefTarget_JPH_CharacterBase *JPH_CharacterBase_MutableUpcastTo_JPH_RefTarget_JPH_CharacterBase(JPH_CharacterBase *object)
{
    return (JPH_RefTarget_JPH_CharacterBase *)(static_cast<JPH::RefTarget<JPH::CharacterBase> *>(
        ((JPH::CharacterBase *)object)
    ));
}

const JPH_CharacterBase *JPH_CharacterBase_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(const JPH_RefTarget_JPH_CharacterBase *object)
{
    return (const JPH_CharacterBase *)(static_cast<const JPH::CharacterBase *>(
        ((const JPH::RefTarget<JPH::CharacterBase> *)object)
    ));
}

JPH_CharacterBase *JPH_CharacterBase_MutableStaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(JPH_RefTarget_JPH_CharacterBase *object)
{
    return (JPH_CharacterBase *)(static_cast<JPH::CharacterBase *>(
        ((JPH::RefTarget<JPH::CharacterBase> *)object)
    ));
}

const JPH_NonCopyable *JPH_CharacterBase_UpcastTo_JPH_NonCopyable(const JPH_CharacterBase *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::CharacterBase *)object)
    ));
}

JPH_NonCopyable *JPH_CharacterBase_MutableUpcastTo_JPH_NonCopyable(JPH_CharacterBase *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::CharacterBase *)object)
    ));
}

const JPH_CharacterBase *JPH_CharacterBase_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_CharacterBase *)(static_cast<const JPH::CharacterBase *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_CharacterBase *JPH_CharacterBase_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_CharacterBase *)(static_cast<JPH::CharacterBase *>(
        ((JPH::NonCopyable *)object)
    ));
}

void JPH_CharacterBase_Destroy(const JPH_CharacterBase *_this)
{
    delete ((const JPH::CharacterBase *)_this);
}

void JPH_CharacterBase_DestroyArray(const JPH_CharacterBase *_this)
{
    delete[] ((const JPH::CharacterBase *)_this);
}

void *Jolt_new_JPH_CharacterBase_size_t(size_t inCount)
{
    return JPH::CharacterBase::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CharacterBase_void_ptr(void *inPointer)
{
    JPH::CharacterBase::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CharacterBase_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CharacterBase::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CharacterBase_size_t(size_t inCount)
{
    return JPH::CharacterBase::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CharacterBase_void_ptr(void *inPointer)
{
    JPH::CharacterBase::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CharacterBase_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CharacterBase::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CharacterBase_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CharacterBase::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CharacterBase_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CharacterBase::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CharacterBase_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CharacterBase::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CharacterBase_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CharacterBase::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_CharacterBase_SetMaxSlopeAngle(JPH_CharacterBase *_this, float inMaxSlopeAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterBase *)(_this)).SetMaxSlopeAngle(
        inMaxSlopeAngle
    );
}

float JPH_CharacterBase_GetCosMaxSlopeAngle(const JPH_CharacterBase *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).GetCosMaxSlopeAngle();
}

void JPH_CharacterBase_SetUp(JPH_CharacterBase *_this, const JPH_Vec3 *inUp)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CharacterBase *)(_this)).SetUp(
        ((inUp ? void() : MRBINDC_THROW("Parameter `inUp` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inUp))
    );
}

JPH_Vec3 *JPH_CharacterBase_GetUp(const JPH_CharacterBase *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).GetUp());
}

bool JPH_CharacterBase_IsSlopeTooSteep(const JPH_CharacterBase *_this, const JPH_Vec3 *inNormal)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).IsSlopeTooSteep(
        ((inNormal ? void() : MRBINDC_THROW("Parameter `inNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inNormal))
    );
}

const JPH_Shape *JPH_CharacterBase_GetShape(const JPH_CharacterBase *_this)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).GetShape());
}

const char *JPH_CharacterBase_sToString(JPH_CharacterBase_EGroundState inState)
{
    return JPH::CharacterBase::sToString(
        ((JPH::CharacterBase::EGroundState)inState)
    );
}

JPH_CharacterBase_EGroundState JPH_CharacterBase_GetGroundState(const JPH_CharacterBase *_this)
{
    return (JPH_CharacterBase_EGroundState)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).GetGroundState());
}

bool JPH_CharacterBase_IsSupported(const JPH_CharacterBase *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).IsSupported();
}

JPH_Vec3 *JPH_CharacterBase_GetGroundPosition(const JPH_CharacterBase *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).GetGroundPosition());
}

JPH_Vec3 *JPH_CharacterBase_GetGroundNormal(const JPH_CharacterBase *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).GetGroundNormal());
}

JPH_Vec3 *JPH_CharacterBase_GetGroundVelocity(const JPH_CharacterBase *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).GetGroundVelocity());
}

const JPH_PhysicsMaterial *JPH_CharacterBase_GetGroundMaterial(const JPH_CharacterBase *_this)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).GetGroundMaterial());
}

JPH_BodyID JPH_CharacterBase_GetGroundBodyID(const JPH_CharacterBase *_this)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).GetGroundBodyID());
}

JPH_SubShapeID *JPH_CharacterBase_GetGroundSubShapeID(const JPH_CharacterBase *_this)
{
    return (JPH_SubShapeID *)new JPH::SubShapeID(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).GetGroundSubShapeID());
}

uint64_t JPH_CharacterBase_GetGroundUserData(const JPH_CharacterBase *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).GetGroundUserData();
}

void JPH_CharacterBase_SetEmbedded(const JPH_CharacterBase *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).SetEmbedded();
}

unsigned int JPH_CharacterBase_GetRefCount(const JPH_CharacterBase *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).GetRefCount();
}

void JPH_CharacterBase_AddRef(const JPH_CharacterBase *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).AddRef();
}

void JPH_CharacterBase_Release(const JPH_CharacterBase *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CharacterBase *)(_this)).Release();
}

int JPH_CharacterBase_sInternalGetRefCountOffset(void)
{
    return JPH::CharacterBase::sInternalGetRefCountOffset();
}

