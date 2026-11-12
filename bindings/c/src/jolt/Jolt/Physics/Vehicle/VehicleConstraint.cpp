// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Vehicle/VehicleConstraint.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/PhysicsStepListener.h>
#include <Jolt/Physics/Vehicle/VehicleAntiRollBar.h>
#include <Jolt/Physics/Vehicle/VehicleCollisionTester.h>
#include <Jolt/Physics/Vehicle/VehicleConstraint.h>
#include <Jolt/Physics/Vehicle/VehicleController.h>
#include <Jolt/Physics/Vehicle/Wheel.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstdint>
#include <cstring>
#include <functional>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_VehicleConstraintSettings_Get_mUp(const JPH_VehicleConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(_this)).mUp);
}

JPH_Vec3 *JPH_VehicleConstraintSettings_GetMutable_mUp(JPH_VehicleConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mUp);
}

const JPH_Vec3 *JPH_VehicleConstraintSettings_Get_mForward(const JPH_VehicleConstraintSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(_this)).mForward);
}

JPH_Vec3 *JPH_VehicleConstraintSettings_GetMutable_mForward(JPH_VehicleConstraintSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mForward);
}

const float *JPH_VehicleConstraintSettings_Get_mMaxPitchRollAngle(const JPH_VehicleConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(_this)).mMaxPitchRollAngle);
}

void JPH_VehicleConstraintSettings_Set_mMaxPitchRollAngle(JPH_VehicleConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mMaxPitchRollAngle = value;
}

float *JPH_VehicleConstraintSettings_GetMutable_mMaxPitchRollAngle(JPH_VehicleConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mMaxPitchRollAngle);
}

const Jolt_JPH_Array_JPH_VehicleAntiRollBar *JPH_VehicleConstraintSettings_Get_mAntiRollBars(const JPH_VehicleConstraintSettings *_this)
{
    return (const Jolt_JPH_Array_JPH_VehicleAntiRollBar *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(_this)).mAntiRollBars);
}

void JPH_VehicleConstraintSettings_Set_mAntiRollBars(JPH_VehicleConstraintSettings *_this, Jolt_PassBy value_pass_by, Jolt_JPH_Array_JPH_VehicleAntiRollBar *value)
{
    MRBINDC_CLASSARG_GUARD(value, JPH::Array<JPH::VehicleAntiRollBar>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mAntiRollBars = (MRBINDC_CLASSARG_DEF_CTOR(value, JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_COPY(value, (JPH::Array<JPH::VehicleAntiRollBar>), JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_MOVE(value, (JPH::Array<JPH::VehicleAntiRollBar>), JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_NoObject, JPH::Array<JPH::VehicleAntiRollBar>) MRBINDC_CLASSARG_END(value, JPH::Array<JPH::VehicleAntiRollBar>));
}

Jolt_JPH_Array_JPH_VehicleAntiRollBar *JPH_VehicleConstraintSettings_GetMutable_mAntiRollBars(JPH_VehicleConstraintSettings *_this)
{
    return (Jolt_JPH_Array_JPH_VehicleAntiRollBar *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mAntiRollBars);
}

const bool *JPH_VehicleConstraintSettings_Get_mEnabled(const JPH_VehicleConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(_this)).mEnabled);
}

void JPH_VehicleConstraintSettings_Set_mEnabled(JPH_VehicleConstraintSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mEnabled = value;
}

bool *JPH_VehicleConstraintSettings_GetMutable_mEnabled(JPH_VehicleConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mEnabled);
}

const unsigned int *JPH_VehicleConstraintSettings_Get_mConstraintPriority(const JPH_VehicleConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(_this)).mConstraintPriority);
}

void JPH_VehicleConstraintSettings_Set_mConstraintPriority(JPH_VehicleConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mConstraintPriority = value;
}

unsigned int *JPH_VehicleConstraintSettings_GetMutable_mConstraintPriority(JPH_VehicleConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mConstraintPriority);
}

const unsigned int *JPH_VehicleConstraintSettings_Get_mNumVelocityStepsOverride(const JPH_VehicleConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

void JPH_VehicleConstraintSettings_Set_mNumVelocityStepsOverride(JPH_VehicleConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_VehicleConstraintSettings_GetMutable_mNumVelocityStepsOverride(JPH_VehicleConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_VehicleConstraintSettings_Get_mNumPositionStepsOverride(const JPH_VehicleConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

void JPH_VehicleConstraintSettings_Set_mNumPositionStepsOverride(JPH_VehicleConstraintSettings *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_VehicleConstraintSettings_GetMutable_mNumPositionStepsOverride(JPH_VehicleConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_VehicleConstraintSettings_Get_mDrawConstraintSize(const JPH_VehicleConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(_this)).mDrawConstraintSize);
}

void JPH_VehicleConstraintSettings_Set_mDrawConstraintSize(JPH_VehicleConstraintSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mDrawConstraintSize = value;
}

float *JPH_VehicleConstraintSettings_GetMutable_mDrawConstraintSize(JPH_VehicleConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mDrawConstraintSize);
}

const uint64_t *JPH_VehicleConstraintSettings_Get_mUserData(const JPH_VehicleConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(_this)).mUserData);
}

void JPH_VehicleConstraintSettings_Set_mUserData(JPH_VehicleConstraintSettings *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mUserData = value;
}

uint64_t *JPH_VehicleConstraintSettings_GetMutable_mUserData(JPH_VehicleConstraintSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).mUserData);
}

JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::VehicleConstraintSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_VehicleConstraintSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_VehicleConstraintSettings *)(new JPH::VehicleConstraintSettings[num_elems]);
}

const JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_OffsetPtr(const JPH_VehicleConstraintSettings *ptr, ptrdiff_t i)
{
    return (const JPH_VehicleConstraintSettings *)(((const JPH::VehicleConstraintSettings *)ptr) + i);
}

JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_OffsetMutablePtr(JPH_VehicleConstraintSettings *ptr, ptrdiff_t i)
{
    return (JPH_VehicleConstraintSettings *)(((JPH::VehicleConstraintSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_VehicleConstraintSettings_UpcastTo_JPH_SerializableObject(const JPH_VehicleConstraintSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::VehicleConstraintSettings *)object)
    ));
}

JPH_SerializableObject *JPH_VehicleConstraintSettings_MutableUpcastTo_JPH_SerializableObject(JPH_VehicleConstraintSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::VehicleConstraintSettings *)object)
    ));
}

const JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_VehicleConstraintSettings *)(static_cast<const JPH::VehicleConstraintSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_VehicleConstraintSettings *)(static_cast<JPH::VehicleConstraintSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_ConstraintSettings *JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(const JPH_VehicleConstraintSettings *object)
{
    return (const JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<const JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((const JPH::VehicleConstraintSettings *)object)
    ));
}

JPH_RefTarget_JPH_ConstraintSettings *JPH_VehicleConstraintSettings_MutableUpcastTo_JPH_RefTarget_JPH_ConstraintSettings(JPH_VehicleConstraintSettings *object)
{
    return (JPH_RefTarget_JPH_ConstraintSettings *)(static_cast<JPH::RefTarget<JPH::ConstraintSettings> *>(
        ((JPH::VehicleConstraintSettings *)object)
    ));
}

const JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(const JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (const JPH_VehicleConstraintSettings *)(static_cast<const JPH::VehicleConstraintSettings *>(
        ((const JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_ConstraintSettings(JPH_RefTarget_JPH_ConstraintSettings *object)
{
    return (JPH_VehicleConstraintSettings *)(static_cast<JPH::VehicleConstraintSettings *>(
        ((JPH::RefTarget<JPH::ConstraintSettings> *)object)
    ));
}

const JPH_ConstraintSettings *JPH_VehicleConstraintSettings_UpcastTo_JPH_ConstraintSettings(const JPH_VehicleConstraintSettings *object)
{
    return (const JPH_ConstraintSettings *)(static_cast<const JPH::ConstraintSettings *>(
        ((const JPH::VehicleConstraintSettings *)object)
    ));
}

JPH_ConstraintSettings *JPH_VehicleConstraintSettings_MutableUpcastTo_JPH_ConstraintSettings(JPH_VehicleConstraintSettings *object)
{
    return (JPH_ConstraintSettings *)(static_cast<JPH::ConstraintSettings *>(
        ((JPH::VehicleConstraintSettings *)object)
    ));
}

const JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_StaticDowncastFrom_JPH_ConstraintSettings(const JPH_ConstraintSettings *object)
{
    return (const JPH_VehicleConstraintSettings *)(static_cast<const JPH::VehicleConstraintSettings *>(
        ((const JPH::ConstraintSettings *)object)
    ));
}

JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_MutableStaticDowncastFrom_JPH_ConstraintSettings(JPH_ConstraintSettings *object)
{
    return (JPH_VehicleConstraintSettings *)(static_cast<JPH::VehicleConstraintSettings *>(
        ((JPH::ConstraintSettings *)object)
    ));
}

JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_VehicleConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::VehicleConstraintSettings);
    return (JPH_VehicleConstraintSettings *)new JPH::VehicleConstraintSettings(JPH::VehicleConstraintSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::VehicleConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::VehicleConstraintSettings), JPH::VehicleConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::VehicleConstraintSettings), JPH::VehicleConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::VehicleConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::VehicleConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::VehicleConstraintSettings))
    ));
}

void JPH_VehicleConstraintSettings_Destroy(const JPH_VehicleConstraintSettings *_this)
{
    delete ((const JPH::VehicleConstraintSettings *)_this);
}

void JPH_VehicleConstraintSettings_DestroyArray(const JPH_VehicleConstraintSettings *_this)
{
    delete[] ((const JPH::VehicleConstraintSettings *)_this);
}

JPH_VehicleConstraintSettings *JPH_VehicleConstraintSettings_AssignFromAnother(JPH_VehicleConstraintSettings *_this, Jolt_PassBy _other_pass_by, JPH_VehicleConstraintSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::VehicleConstraintSettings);
    return (JPH_VehicleConstraintSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::VehicleConstraintSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::VehicleConstraintSettings), JPH::VehicleConstraintSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::VehicleConstraintSettings), JPH::VehicleConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::VehicleConstraintSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::VehicleConstraintSettings) MRBINDC_CLASSARG_END(_other, JPH::VehicleConstraintSettings))
    ));
}

void *Jolt_new_JPH_VehicleConstraintSettings_size_t(size_t inCount)
{
    return JPH::VehicleConstraintSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_VehicleConstraintSettings_void_ptr(void *inPointer)
{
    JPH::VehicleConstraintSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_VehicleConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleConstraintSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_VehicleConstraintSettings_size_t(size_t inCount)
{
    return JPH::VehicleConstraintSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr(void *inPointer)
{
    JPH::VehicleConstraintSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleConstraintSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_VehicleConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleConstraintSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_VehicleConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleConstraintSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_VehicleConstraintSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleConstraintSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleConstraintSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_VehicleConstraintSettings_SetEmbedded(const JPH_VehicleConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_VehicleConstraintSettings_GetRefCount(const JPH_VehicleConstraintSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(_this)).GetRefCount();
}

void JPH_VehicleConstraintSettings_AddRef(const JPH_VehicleConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(_this)).AddRef();
}

void JPH_VehicleConstraintSettings_Release(const JPH_VehicleConstraintSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(_this)).Release();
}

int JPH_VehicleConstraintSettings_sInternalGetRefCountOffset(void)
{
    return JPH::VehicleConstraintSettings::sInternalGetRefCountOffset();
}

JPH_VehicleConstraint *JPH_VehicleConstraint_Construct(JPH_Body *inVehicleBody, const JPH_VehicleConstraintSettings *inSettings)
{
    return (JPH_VehicleConstraint *)new JPH::VehicleConstraint(JPH::VehicleConstraint(
        ((inVehicleBody ? void() : MRBINDC_THROW("Parameter `inVehicleBody` can not be null.", void)), *(JPH::Body *)(inVehicleBody)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::VehicleConstraintSettings *)(inSettings))
    ));
}

const JPH_VehicleConstraint *JPH_VehicleConstraint_OffsetPtr(const JPH_VehicleConstraint *ptr, ptrdiff_t i)
{
    return (const JPH_VehicleConstraint *)(((const JPH::VehicleConstraint *)ptr) + i);
}

JPH_VehicleConstraint *JPH_VehicleConstraint_OffsetMutablePtr(JPH_VehicleConstraint *ptr, ptrdiff_t i)
{
    return (JPH_VehicleConstraint *)(((JPH::VehicleConstraint *)ptr) + i);
}

const JPH_RefTarget_JPH_Constraint *JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(const JPH_VehicleConstraint *object)
{
    return (const JPH_RefTarget_JPH_Constraint *)(static_cast<const JPH::RefTarget<JPH::Constraint> *>(
        ((const JPH::VehicleConstraint *)object)
    ));
}

JPH_RefTarget_JPH_Constraint *JPH_VehicleConstraint_MutableUpcastTo_JPH_RefTarget_JPH_Constraint(JPH_VehicleConstraint *object)
{
    return (JPH_RefTarget_JPH_Constraint *)(static_cast<JPH::RefTarget<JPH::Constraint> *>(
        ((JPH::VehicleConstraint *)object)
    ));
}

const JPH_VehicleConstraint *JPH_VehicleConstraint_StaticDowncastFrom_JPH_RefTarget_JPH_Constraint(const JPH_RefTarget_JPH_Constraint *object)
{
    return (const JPH_VehicleConstraint *)(static_cast<const JPH::VehicleConstraint *>(
        ((const JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

JPH_VehicleConstraint *JPH_VehicleConstraint_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Constraint(JPH_RefTarget_JPH_Constraint *object)
{
    return (JPH_VehicleConstraint *)(static_cast<JPH::VehicleConstraint *>(
        ((JPH::RefTarget<JPH::Constraint> *)object)
    ));
}

const JPH_NonCopyable *JPH_VehicleConstraint_UpcastTo_JPH_NonCopyable(const JPH_VehicleConstraint *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::VehicleConstraint *)object)
    ));
}

JPH_NonCopyable *JPH_VehicleConstraint_MutableUpcastTo_JPH_NonCopyable(JPH_VehicleConstraint *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::VehicleConstraint *)object)
    ));
}

const JPH_VehicleConstraint *JPH_VehicleConstraint_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_VehicleConstraint *)(static_cast<const JPH::VehicleConstraint *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_VehicleConstraint *JPH_VehicleConstraint_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_VehicleConstraint *)(static_cast<JPH::VehicleConstraint *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_Constraint *JPH_VehicleConstraint_UpcastTo_JPH_Constraint(const JPH_VehicleConstraint *object)
{
    return (const JPH_Constraint *)(static_cast<const JPH::Constraint *>(
        ((const JPH::VehicleConstraint *)object)
    ));
}

JPH_Constraint *JPH_VehicleConstraint_MutableUpcastTo_JPH_Constraint(JPH_VehicleConstraint *object)
{
    return (JPH_Constraint *)(static_cast<JPH::Constraint *>(
        ((JPH::VehicleConstraint *)object)
    ));
}

const JPH_VehicleConstraint *JPH_VehicleConstraint_StaticDowncastFrom_JPH_Constraint(const JPH_Constraint *object)
{
    return (const JPH_VehicleConstraint *)(static_cast<const JPH::VehicleConstraint *>(
        ((const JPH::Constraint *)object)
    ));
}

JPH_VehicleConstraint *JPH_VehicleConstraint_MutableStaticDowncastFrom_JPH_Constraint(JPH_Constraint *object)
{
    return (JPH_VehicleConstraint *)(static_cast<JPH::VehicleConstraint *>(
        ((JPH::Constraint *)object)
    ));
}

const JPH_PhysicsStepListener *JPH_VehicleConstraint_UpcastTo_JPH_PhysicsStepListener(const JPH_VehicleConstraint *object)
{
    return (const JPH_PhysicsStepListener *)(static_cast<const JPH::PhysicsStepListener *>(
        ((const JPH::VehicleConstraint *)object)
    ));
}

JPH_PhysicsStepListener *JPH_VehicleConstraint_MutableUpcastTo_JPH_PhysicsStepListener(JPH_VehicleConstraint *object)
{
    return (JPH_PhysicsStepListener *)(static_cast<JPH::PhysicsStepListener *>(
        ((JPH::VehicleConstraint *)object)
    ));
}

const JPH_VehicleConstraint *JPH_VehicleConstraint_StaticDowncastFrom_JPH_PhysicsStepListener(const JPH_PhysicsStepListener *object)
{
    return (const JPH_VehicleConstraint *)(static_cast<const JPH::VehicleConstraint *>(
        ((const JPH::PhysicsStepListener *)object)
    ));
}

JPH_VehicleConstraint *JPH_VehicleConstraint_MutableStaticDowncastFrom_JPH_PhysicsStepListener(JPH_PhysicsStepListener *object)
{
    return (JPH_VehicleConstraint *)(static_cast<JPH::VehicleConstraint *>(
        ((JPH::PhysicsStepListener *)object)
    ));
}

void JPH_VehicleConstraint_Destroy(const JPH_VehicleConstraint *_this)
{
    delete ((const JPH::VehicleConstraint *)_this);
}

void JPH_VehicleConstraint_DestroyArray(const JPH_VehicleConstraint *_this)
{
    delete[] ((const JPH::VehicleConstraint *)_this);
}

void JPH_VehicleConstraint_SetMaxPitchRollAngle(JPH_VehicleConstraint *_this, float inMaxPitchRollAngle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetMaxPitchRollAngle(
        inMaxPitchRollAngle
    );
}

float JPH_VehicleConstraint_GetMaxPitchRollAngle(const JPH_VehicleConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetMaxPitchRollAngle();
}

void JPH_VehicleConstraint_SetVehicleCollisionTester(JPH_VehicleConstraint *_this, const JPH_VehicleCollisionTester *inTester)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetVehicleCollisionTester(
        ((const JPH::VehicleCollisionTester *)inTester)
    );
}

const JPH_VehicleCollisionTester *JPH_VehicleConstraint_GetVehicleCollisionTester(const JPH_VehicleConstraint *_this)
{
    return (const JPH_VehicleCollisionTester *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetVehicleCollisionTester());
}

void JPH_VehicleConstraint_SetCombineFriction(JPH_VehicleConstraint *_this, const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *inCombineFriction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetCombineFriction(
        ((inCombineFriction ? void() : MRBINDC_THROW("Parameter `inCombineFriction` can not be null.", void)), *(const std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)> *)(inCombineFriction))
    );
}

const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *JPH_VehicleConstraint_GetCombineFriction(const JPH_VehicleConstraint *_this)
{
    return (const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetCombineFriction());
}

const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *JPH_VehicleConstraint_GetPreStepCallback(const JPH_VehicleConstraint *_this)
{
    return (const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetPreStepCallback());
}

void JPH_VehicleConstraint_SetPreStepCallback(JPH_VehicleConstraint *_this, const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *inPreStepCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetPreStepCallback(
        ((inPreStepCallback ? void() : MRBINDC_THROW("Parameter `inPreStepCallback` can not be null.", void)), *(const std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)> *)(inPreStepCallback))
    );
}

const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *JPH_VehicleConstraint_GetPostCollideCallback(const JPH_VehicleConstraint *_this)
{
    return (const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetPostCollideCallback());
}

void JPH_VehicleConstraint_SetPostCollideCallback(JPH_VehicleConstraint *_this, const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *inPostCollideCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetPostCollideCallback(
        ((inPostCollideCallback ? void() : MRBINDC_THROW("Parameter `inPostCollideCallback` can not be null.", void)), *(const std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)> *)(inPostCollideCallback))
    );
}

const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *JPH_VehicleConstraint_GetPostStepCallback(const JPH_VehicleConstraint *_this)
{
    return (const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetPostStepCallback());
}

void JPH_VehicleConstraint_SetPostStepCallback(JPH_VehicleConstraint *_this, const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *inPostStepCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetPostStepCallback(
        ((inPostStepCallback ? void() : MRBINDC_THROW("Parameter `inPostStepCallback` can not be null.", void)), *(const std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)> *)(inPostStepCallback))
    );
}

void JPH_VehicleConstraint_OverrideGravity(JPH_VehicleConstraint *_this, const JPH_Vec3 *inGravity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).OverrideGravity(
        ((inGravity ? void() : MRBINDC_THROW("Parameter `inGravity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inGravity))
    );
}

bool JPH_VehicleConstraint_IsGravityOverridden(const JPH_VehicleConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).IsGravityOverridden();
}

JPH_Vec3 *JPH_VehicleConstraint_GetGravityOverride(const JPH_VehicleConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetGravityOverride());
}

void JPH_VehicleConstraint_ResetGravityOverride(JPH_VehicleConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).ResetGravityOverride();
}

JPH_Vec3 *JPH_VehicleConstraint_GetLocalForward(const JPH_VehicleConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetLocalForward());
}

JPH_Vec3 *JPH_VehicleConstraint_GetLocalUp(const JPH_VehicleConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetLocalUp());
}

JPH_Vec3 *JPH_VehicleConstraint_GetWorldUp(const JPH_VehicleConstraint *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetWorldUp());
}

JPH_Body *JPH_VehicleConstraint_GetVehicleBody(const JPH_VehicleConstraint *_this)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetVehicleBody());
}

const JPH_VehicleController *JPH_VehicleConstraint_GetController(const JPH_VehicleConstraint *_this)
{
    return (const JPH_VehicleController *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetController());
}

JPH_VehicleController *JPH_VehicleConstraint_GetController_mut(JPH_VehicleConstraint *_this)
{
    return (JPH_VehicleController *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).GetController());
}

const Jolt_JPH_Array_JPH_Wheel_ptr *JPH_VehicleConstraint_GetWheels(const JPH_VehicleConstraint *_this)
{
    return (const Jolt_JPH_Array_JPH_Wheel_ptr *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetWheels());
}

Jolt_JPH_Array_JPH_Wheel_ptr *JPH_VehicleConstraint_GetWheels_mut(JPH_VehicleConstraint *_this)
{
    return (Jolt_JPH_Array_JPH_Wheel_ptr *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).GetWheels());
}

JPH_Wheel *JPH_VehicleConstraint_GetWheel_mut(JPH_VehicleConstraint *_this, unsigned int inIdx)
{
    return (JPH_Wheel *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).GetWheel(
        inIdx
    ));
}

const JPH_Wheel *JPH_VehicleConstraint_GetWheel(const JPH_VehicleConstraint *_this, unsigned int inIdx)
{
    return (const JPH_Wheel *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetWheel(
        inIdx
    ));
}

void JPH_VehicleConstraint_GetWheelLocalBasis(const JPH_VehicleConstraint *_this, const JPH_Wheel *inWheel, JPH_Vec3 *outForward, JPH_Vec3 *outUp, JPH_Vec3 *outRight)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetWheelLocalBasis(
        ((const JPH::Wheel *)inWheel),
        ((outForward ? void() : MRBINDC_THROW("Parameter `outForward` can not be null.", void)), *(JPH::Vec3 *)(outForward)),
        ((outUp ? void() : MRBINDC_THROW("Parameter `outUp` can not be null.", void)), *(JPH::Vec3 *)(outUp)),
        ((outRight ? void() : MRBINDC_THROW("Parameter `outRight` can not be null.", void)), *(JPH::Vec3 *)(outRight))
    );
}

JPH_Mat44 *JPH_VehicleConstraint_GetWheelLocalTransform(const JPH_VehicleConstraint *_this, unsigned int inWheelIndex, const JPH_Vec3 *inWheelRight, const JPH_Vec3 *inWheelUp)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetWheelLocalTransform(
        inWheelIndex,
        ((inWheelRight ? void() : MRBINDC_THROW("Parameter `inWheelRight` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inWheelRight)),
        ((inWheelUp ? void() : MRBINDC_THROW("Parameter `inWheelUp` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inWheelUp))
    ));
}

JPH_Mat44 *JPH_VehicleConstraint_GetWheelWorldTransform(const JPH_VehicleConstraint *_this, unsigned int inWheelIndex, const JPH_Vec3 *inWheelRight, const JPH_Vec3 *inWheelUp)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetWheelWorldTransform(
        inWheelIndex,
        ((inWheelRight ? void() : MRBINDC_THROW("Parameter `inWheelRight` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inWheelRight)),
        ((inWheelUp ? void() : MRBINDC_THROW("Parameter `inWheelUp` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inWheelUp))
    ));
}

const Jolt_JPH_Array_JPH_VehicleAntiRollBar *JPH_VehicleConstraint_GetAntiRollBars(const JPH_VehicleConstraint *_this)
{
    return (const Jolt_JPH_Array_JPH_VehicleAntiRollBar *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetAntiRollBars());
}

Jolt_JPH_Array_JPH_VehicleAntiRollBar *JPH_VehicleConstraint_GetAntiRollBars_mut(JPH_VehicleConstraint *_this)
{
    return (Jolt_JPH_Array_JPH_VehicleAntiRollBar *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).GetAntiRollBars());
}

void JPH_VehicleConstraint_SetNumStepsBetweenCollisionTestActive(JPH_VehicleConstraint *_this, unsigned int inSteps)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetNumStepsBetweenCollisionTestActive(
        inSteps
    );
}

unsigned int JPH_VehicleConstraint_GetNumStepsBetweenCollisionTestActive(const JPH_VehicleConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetNumStepsBetweenCollisionTestActive();
}

void JPH_VehicleConstraint_SetNumStepsBetweenCollisionTestInactive(JPH_VehicleConstraint *_this, unsigned int inSteps)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetNumStepsBetweenCollisionTestInactive(
        inSteps
    );
}

unsigned int JPH_VehicleConstraint_GetNumStepsBetweenCollisionTestInactive(const JPH_VehicleConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetNumStepsBetweenCollisionTestInactive();
}

bool JPH_VehicleConstraint_IsActive(const JPH_VehicleConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).IsActive();
}

void JPH_VehicleConstraint_NotifyShapeChanged(JPH_VehicleConstraint *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inDeltaCOM)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).NotifyShapeChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inDeltaCOM ? void() : MRBINDC_THROW("Parameter `inDeltaCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaCOM))
    );
}

void JPH_VehicleConstraint_SetupVelocityConstraint(JPH_VehicleConstraint *_this, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetupVelocityConstraint(
        inDeltaTime
    );
}

void JPH_VehicleConstraint_ResetWarmStart(JPH_VehicleConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).ResetWarmStart();
}

void JPH_VehicleConstraint_WarmStartVelocityConstraint(JPH_VehicleConstraint *_this, float inWarmStartImpulseRatio)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).WarmStartVelocityConstraint(
        inWarmStartImpulseRatio
    );
}

bool JPH_VehicleConstraint_SolveVelocityConstraint(JPH_VehicleConstraint *_this, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SolveVelocityConstraint(
        inDeltaTime
    );
}

bool JPH_VehicleConstraint_SolvePositionConstraint(JPH_VehicleConstraint *_this, float inDeltaTime, float inBaumgarte)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SolvePositionConstraint(
        inDeltaTime,
        inBaumgarte
    );
}

void JPH_VehicleConstraint_DrawConstraint(const JPH_VehicleConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).DrawConstraint(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

void JPH_VehicleConstraint_DrawConstraintLimits(const JPH_VehicleConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).DrawConstraintLimits(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

unsigned int JPH_VehicleConstraint_GetConstraintPriority(const JPH_VehicleConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetConstraintPriority();
}

void JPH_VehicleConstraint_SetConstraintPriority(JPH_VehicleConstraint *_this, unsigned int inPriority)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetConstraintPriority(
        inPriority
    );
}

void JPH_VehicleConstraint_SetNumVelocityStepsOverride(JPH_VehicleConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_VehicleConstraint_GetNumVelocityStepsOverride(const JPH_VehicleConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_VehicleConstraint_SetNumPositionStepsOverride(JPH_VehicleConstraint *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_VehicleConstraint_GetNumPositionStepsOverride(const JPH_VehicleConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetNumPositionStepsOverride();
}

void JPH_VehicleConstraint_SetEnabled(JPH_VehicleConstraint *_this, bool inEnabled)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetEnabled(
        inEnabled
    );
}

bool JPH_VehicleConstraint_GetEnabled(const JPH_VehicleConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetEnabled();
}

uint64_t JPH_VehicleConstraint_GetUserData(const JPH_VehicleConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetUserData();
}

void JPH_VehicleConstraint_SetUserData(JPH_VehicleConstraint *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetUserData(
        inUserData
    );
}

void JPH_VehicleConstraint_DrawConstraintReferenceFrame(const JPH_VehicleConstraint *_this, JPH_DebugRenderer *inRenderer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).DrawConstraintReferenceFrame(
        ((JPH::DebugRenderer *)inRenderer)
    );
}

float JPH_VehicleConstraint_GetDrawConstraintSize(const JPH_VehicleConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetDrawConstraintSize();
}

void JPH_VehicleConstraint_SetDrawConstraintSize(JPH_VehicleConstraint *_this, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleConstraint *)(_this)).SetDrawConstraintSize(
        inSize
    );
}

void JPH_VehicleConstraint_SetEmbedded(const JPH_VehicleConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).SetEmbedded();
}

unsigned int JPH_VehicleConstraint_GetRefCount(const JPH_VehicleConstraint *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).GetRefCount();
}

void JPH_VehicleConstraint_AddRef(const JPH_VehicleConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).AddRef();
}

void JPH_VehicleConstraint_Release(const JPH_VehicleConstraint *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleConstraint *)(_this)).Release();
}

int JPH_VehicleConstraint_sInternalGetRefCountOffset(void)
{
    return JPH::VehicleConstraint::sInternalGetRefCountOffset();
}

