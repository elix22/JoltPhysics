// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Ragdoll/Ragdoll.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/BodyCreationSettings.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Body/MotionQuality.h>
#include <Jolt/Physics/Body/MotionType.h>
#include <Jolt/Physics/Collision/CollisionGroup.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <Jolt/Physics/EActivation.h>
#include <Jolt/Physics/PhysicsSystem.h>
#include <Jolt/Physics/Ragdoll/Ragdoll.h>
#include <Jolt/Skeleton/Skeleton.h>
#include <Jolt/Skeleton/SkeletonPose.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>
#include <type_traits>
#include <utility>


const Jolt_JPH_Array_JPH_RagdollSettings_Part *JPH_RagdollSettings_Get_mParts(const JPH_RagdollSettings *_this)
{
    return (const Jolt_JPH_Array_JPH_RagdollSettings_Part *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings *)(_this)).mParts);
}

void JPH_RagdollSettings_Set_mParts(JPH_RagdollSettings *_this, Jolt_PassBy value_pass_by, Jolt_JPH_Array_JPH_RagdollSettings_Part *value)
{
    MRBINDC_CLASSARG_GUARD(value, JPH::Array<JPH::RagdollSettings::Part>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings *)(_this)).mParts = (MRBINDC_CLASSARG_DEF_CTOR(value, JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_COPY(value, (JPH::Array<JPH::RagdollSettings::Part>), JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_MOVE(value, (JPH::Array<JPH::RagdollSettings::Part>), JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_NoObject, JPH::Array<JPH::RagdollSettings::Part>) MRBINDC_CLASSARG_END(value, JPH::Array<JPH::RagdollSettings::Part>));
}

Jolt_JPH_Array_JPH_RagdollSettings_Part *JPH_RagdollSettings_GetMutable_mParts(JPH_RagdollSettings *_this)
{
    return (Jolt_JPH_Array_JPH_RagdollSettings_Part *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings *)(_this)).mParts);
}

const Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_Get_mAdditionalConstraints(const JPH_RagdollSettings *_this)
{
    return (const Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings *)(_this)).mAdditionalConstraints);
}

void JPH_RagdollSettings_Set_mAdditionalConstraints(JPH_RagdollSettings *_this, Jolt_PassBy value_pass_by, Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *value)
{
    MRBINDC_CLASSARG_GUARD(value, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings *)(_this)).mAdditionalConstraints = (MRBINDC_CLASSARG_DEF_CTOR(value, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_COPY(value, (JPH::Array<JPH::RagdollSettings::AdditionalConstraint>), JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_MOVE(value, (JPH::Array<JPH::RagdollSettings::AdditionalConstraint>), JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_DefaultArgument, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_NoObject, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>) MRBINDC_CLASSARG_END(value, JPH::Array<JPH::RagdollSettings::AdditionalConstraint>));
}

Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_GetMutable_mAdditionalConstraints(JPH_RagdollSettings *_this)
{
    return (Jolt_JPH_Array_JPH_RagdollSettings_AdditionalConstraint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings *)(_this)).mAdditionalConstraints);
}

JPH_RagdollSettings *JPH_RagdollSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RagdollSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RagdollSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RagdollSettings *JPH_RagdollSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RagdollSettings *)(new JPH::RagdollSettings[num_elems]);
}

const JPH_RagdollSettings *JPH_RagdollSettings_OffsetPtr(const JPH_RagdollSettings *ptr, ptrdiff_t i)
{
    return (const JPH_RagdollSettings *)(((const JPH::RagdollSettings *)ptr) + i);
}

JPH_RagdollSettings *JPH_RagdollSettings_OffsetMutablePtr(JPH_RagdollSettings *ptr, ptrdiff_t i)
{
    return (JPH_RagdollSettings *)(((JPH::RagdollSettings *)ptr) + i);
}

const JPH_RefTarget_JPH_RagdollSettings *JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(const JPH_RagdollSettings *object)
{
    return (const JPH_RefTarget_JPH_RagdollSettings *)(static_cast<const JPH::RefTarget<JPH::RagdollSettings> *>(
        ((const JPH::RagdollSettings *)object)
    ));
}

JPH_RefTarget_JPH_RagdollSettings *JPH_RagdollSettings_MutableUpcastTo_JPH_RefTarget_JPH_RagdollSettings(JPH_RagdollSettings *object)
{
    return (JPH_RefTarget_JPH_RagdollSettings *)(static_cast<JPH::RefTarget<JPH::RagdollSettings> *>(
        ((JPH::RagdollSettings *)object)
    ));
}

const JPH_RagdollSettings *JPH_RagdollSettings_StaticDowncastFrom_JPH_RefTarget_JPH_RagdollSettings(const JPH_RefTarget_JPH_RagdollSettings *object)
{
    return (const JPH_RagdollSettings *)(static_cast<const JPH::RagdollSettings *>(
        ((const JPH::RefTarget<JPH::RagdollSettings> *)object)
    ));
}

JPH_RagdollSettings *JPH_RagdollSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_RagdollSettings(JPH_RefTarget_JPH_RagdollSettings *object)
{
    return (JPH_RagdollSettings *)(static_cast<JPH::RagdollSettings *>(
        ((JPH::RefTarget<JPH::RagdollSettings> *)object)
    ));
}

JPH_RagdollSettings *JPH_RagdollSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RagdollSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RagdollSettings);
    return (JPH_RagdollSettings *)new JPH::RagdollSettings(JPH::RagdollSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RagdollSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::RagdollSettings), JPH::RagdollSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::RagdollSettings), JPH::RagdollSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RagdollSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RagdollSettings) MRBINDC_CLASSARG_END(_other, JPH::RagdollSettings))
    ));
}

void JPH_RagdollSettings_Destroy(const JPH_RagdollSettings *_this)
{
    delete ((const JPH::RagdollSettings *)_this);
}

void JPH_RagdollSettings_DestroyArray(const JPH_RagdollSettings *_this)
{
    delete[] ((const JPH::RagdollSettings *)_this);
}

JPH_RagdollSettings *JPH_RagdollSettings_AssignFromAnother(JPH_RagdollSettings *_this, Jolt_PassBy _other_pass_by, JPH_RagdollSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RagdollSettings);
    return (JPH_RagdollSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RagdollSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::RagdollSettings), JPH::RagdollSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::RagdollSettings), JPH::RagdollSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RagdollSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RagdollSettings) MRBINDC_CLASSARG_END(_other, JPH::RagdollSettings))
    ));
}

void *Jolt_new_JPH_RagdollSettings_size_t(size_t inCount)
{
    return JPH::RagdollSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_RagdollSettings_void_ptr(void *inPointer)
{
    JPH::RagdollSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_RagdollSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RagdollSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_RagdollSettings_size_t(size_t inCount)
{
    return JPH::RagdollSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_RagdollSettings_void_ptr(void *inPointer)
{
    JPH::RagdollSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_RagdollSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RagdollSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_RagdollSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RagdollSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_RagdollSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RagdollSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_RagdollSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RagdollSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_RagdollSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RagdollSettings::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_RagdollSettings_Stabilize(JPH_RagdollSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings *)(_this)).Stabilize();
}

void JPH_RagdollSettings_CalculateConstraintPriorities(JPH_RagdollSettings *_this, const unsigned int *inBasePriority)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings *)(_this)).CalculateConstraintPriorities(
        (inBasePriority ? *inBasePriority : static_cast<unsigned int>(0))
    );
}

void JPH_RagdollSettings_DisableParentChildCollisions(JPH_RagdollSettings *_this, const JPH_Mat44 *inJointMatrices, const float *inMinSeparationDistance)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings *)(_this)).DisableParentChildCollisions(
        ((const JPH::Mat44 *)inJointMatrices),
        (inMinSeparationDistance ? *inMinSeparationDistance : static_cast<float>(0.F))
    );
}

JPH_Ragdoll *JPH_RagdollSettings_CreateRagdoll(const JPH_RagdollSettings *_this, unsigned int inCollisionGroup, uint64_t inUserData, JPH_PhysicsSystem *inSystem)
{
    return (JPH_Ragdoll *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings *)(_this)).CreateRagdoll(
        inCollisionGroup,
        inUserData,
        ((JPH::PhysicsSystem *)inSystem)
    ));
}

const JPH_Skeleton *JPH_RagdollSettings_GetSkeleton(const JPH_RagdollSettings *_this)
{
    return (const JPH_Skeleton *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings *)(_this)).GetSkeleton());
}

JPH_Skeleton *JPH_RagdollSettings_GetSkeleton_mut(JPH_RagdollSettings *_this)
{
    return (JPH_Skeleton *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings *)(_this)).GetSkeleton());
}

void JPH_RagdollSettings_CalculateBodyIndexToConstraintIndex(JPH_RagdollSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings *)(_this)).CalculateBodyIndexToConstraintIndex();
}

const Jolt_JPH_Array_int *JPH_RagdollSettings_GetBodyIndexToConstraintIndex(const JPH_RagdollSettings *_this)
{
    return (const Jolt_JPH_Array_int *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings *)(_this)).GetBodyIndexToConstraintIndex());
}

int JPH_RagdollSettings_GetConstraintIndexForBodyIndex(const JPH_RagdollSettings *_this, int inBodyIndex)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings *)(_this)).GetConstraintIndexForBodyIndex(
        inBodyIndex
    );
}

void JPH_RagdollSettings_CalculateConstraintIndexToBodyIdxPair(JPH_RagdollSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings *)(_this)).CalculateConstraintIndexToBodyIdxPair();
}

const Jolt_JPH_Array_std_pair_int_int *JPH_RagdollSettings_GetConstraintIndexToBodyIdxPair(const JPH_RagdollSettings *_this)
{
    return (const Jolt_JPH_Array_std_pair_int_int *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings *)(_this)).GetConstraintIndexToBodyIdxPair());
}

Jolt_std_pair_int_int *JPH_RagdollSettings_GetBodyIndicesForConstraintIndex(const JPH_RagdollSettings *_this, int inConstraintIndex)
{
    return (Jolt_std_pair_int_int *)new std::pair<int, int>(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings *)(_this)).GetBodyIndicesForConstraintIndex(
        inConstraintIndex
    ));
}

void JPH_RagdollSettings_SetEmbedded(const JPH_RagdollSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_RagdollSettings_GetRefCount(const JPH_RagdollSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings *)(_this)).GetRefCount();
}

void JPH_RagdollSettings_AddRef(const JPH_RagdollSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings *)(_this)).AddRef();
}

void JPH_RagdollSettings_Release(const JPH_RagdollSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings *)(_this)).Release();
}

int JPH_RagdollSettings_sInternalGetRefCountOffset(void)
{
    return JPH::RagdollSettings::sInternalGetRefCountOffset();
}

const JPH_Vec3 *JPH_RagdollSettings_Part_Get_mPosition(const JPH_RagdollSettings_Part *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mPosition);
}

JPH_Vec3 *JPH_RagdollSettings_Part_GetMutable_mPosition(JPH_RagdollSettings_Part *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mPosition);
}

const JPH_Quat *JPH_RagdollSettings_Part_Get_mRotation(const JPH_RagdollSettings_Part *_this)
{
    return (const JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mRotation);
}

JPH_Quat *JPH_RagdollSettings_Part_GetMutable_mRotation(JPH_RagdollSettings_Part *_this)
{
    return (JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mRotation);
}

const JPH_Vec3 *JPH_RagdollSettings_Part_Get_mLinearVelocity(const JPH_RagdollSettings_Part *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mLinearVelocity);
}

JPH_Vec3 *JPH_RagdollSettings_Part_GetMutable_mLinearVelocity(JPH_RagdollSettings_Part *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mLinearVelocity);
}

const JPH_Vec3 *JPH_RagdollSettings_Part_Get_mAngularVelocity(const JPH_RagdollSettings_Part *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mAngularVelocity);
}

JPH_Vec3 *JPH_RagdollSettings_Part_GetMutable_mAngularVelocity(JPH_RagdollSettings_Part *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mAngularVelocity);
}

const uint64_t *JPH_RagdollSettings_Part_Get_mUserData(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mUserData);
}

void JPH_RagdollSettings_Part_Set_mUserData(JPH_RagdollSettings_Part *_this, uint64_t value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mUserData = value;
}

uint64_t *JPH_RagdollSettings_Part_GetMutable_mUserData(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mUserData);
}

const unsigned short *JPH_RagdollSettings_Part_Get_mObjectLayer(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mObjectLayer);
}

void JPH_RagdollSettings_Part_Set_mObjectLayer(JPH_RagdollSettings_Part *_this, unsigned short value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mObjectLayer = value;
}

unsigned short *JPH_RagdollSettings_Part_GetMutable_mObjectLayer(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mObjectLayer);
}

const JPH_CollisionGroup *JPH_RagdollSettings_Part_Get_mCollisionGroup(const JPH_RagdollSettings_Part *_this)
{
    return (const JPH_CollisionGroup *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mCollisionGroup);
}

void JPH_RagdollSettings_Part_Set_mCollisionGroup(JPH_RagdollSettings_Part *_this, Jolt_PassBy value_pass_by, JPH_CollisionGroup *value)
{
    MRBINDC_CLASSARG_GUARD(value, JPH::CollisionGroup);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mCollisionGroup = (MRBINDC_CLASSARG_DEF_CTOR(value, JPH::CollisionGroup) MRBINDC_CLASSARG_COPY(value, (JPH::CollisionGroup), JPH::CollisionGroup) MRBINDC_CLASSARG_MOVE(value, (JPH::CollisionGroup), JPH::CollisionGroup) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_DefaultArgument, JPH::CollisionGroup) MRBINDC_CLASSARG_NO_DEF_ARG(value, Jolt_PassBy_NoObject, JPH::CollisionGroup) MRBINDC_CLASSARG_END(value, JPH::CollisionGroup));
}

JPH_CollisionGroup *JPH_RagdollSettings_Part_GetMutable_mCollisionGroup(JPH_RagdollSettings_Part *_this)
{
    return (JPH_CollisionGroup *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mCollisionGroup);
}

const JPH_EMotionType *JPH_RagdollSettings_Part_Get_mMotionType(const JPH_RagdollSettings_Part *_this)
{
    return (const JPH_EMotionType *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mMotionType);
}

void JPH_RagdollSettings_Part_Set_mMotionType(JPH_RagdollSettings_Part *_this, JPH_EMotionType value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mMotionType = ((JPH::EMotionType)value);
}

JPH_EMotionType *JPH_RagdollSettings_Part_GetMutable_mMotionType(JPH_RagdollSettings_Part *_this)
{
    return (JPH_EMotionType *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mMotionType);
}

const bool *JPH_RagdollSettings_Part_Get_mAllowDynamicOrKinematic(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mAllowDynamicOrKinematic);
}

void JPH_RagdollSettings_Part_Set_mAllowDynamicOrKinematic(JPH_RagdollSettings_Part *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mAllowDynamicOrKinematic = value;
}

bool *JPH_RagdollSettings_Part_GetMutable_mAllowDynamicOrKinematic(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mAllowDynamicOrKinematic);
}

const bool *JPH_RagdollSettings_Part_Get_mIsSensor(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mIsSensor);
}

void JPH_RagdollSettings_Part_Set_mIsSensor(JPH_RagdollSettings_Part *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mIsSensor = value;
}

bool *JPH_RagdollSettings_Part_GetMutable_mIsSensor(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mIsSensor);
}

const bool *JPH_RagdollSettings_Part_Get_mCollideKinematicVsNonDynamic(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mCollideKinematicVsNonDynamic);
}

void JPH_RagdollSettings_Part_Set_mCollideKinematicVsNonDynamic(JPH_RagdollSettings_Part *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mCollideKinematicVsNonDynamic = value;
}

bool *JPH_RagdollSettings_Part_GetMutable_mCollideKinematicVsNonDynamic(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mCollideKinematicVsNonDynamic);
}

const bool *JPH_RagdollSettings_Part_Get_mUseManifoldReduction(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mUseManifoldReduction);
}

void JPH_RagdollSettings_Part_Set_mUseManifoldReduction(JPH_RagdollSettings_Part *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mUseManifoldReduction = value;
}

bool *JPH_RagdollSettings_Part_GetMutable_mUseManifoldReduction(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mUseManifoldReduction);
}

const bool *JPH_RagdollSettings_Part_Get_mApplyGyroscopicForce(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mApplyGyroscopicForce);
}

void JPH_RagdollSettings_Part_Set_mApplyGyroscopicForce(JPH_RagdollSettings_Part *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mApplyGyroscopicForce = value;
}

bool *JPH_RagdollSettings_Part_GetMutable_mApplyGyroscopicForce(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mApplyGyroscopicForce);
}

const JPH_EMotionQuality *JPH_RagdollSettings_Part_Get_mMotionQuality(const JPH_RagdollSettings_Part *_this)
{
    return (const JPH_EMotionQuality *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mMotionQuality);
}

void JPH_RagdollSettings_Part_Set_mMotionQuality(JPH_RagdollSettings_Part *_this, JPH_EMotionQuality value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mMotionQuality = ((JPH::EMotionQuality)value);
}

JPH_EMotionQuality *JPH_RagdollSettings_Part_GetMutable_mMotionQuality(JPH_RagdollSettings_Part *_this)
{
    return (JPH_EMotionQuality *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mMotionQuality);
}

const bool *JPH_RagdollSettings_Part_Get_mEnhancedInternalEdgeRemoval(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mEnhancedInternalEdgeRemoval);
}

void JPH_RagdollSettings_Part_Set_mEnhancedInternalEdgeRemoval(JPH_RagdollSettings_Part *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mEnhancedInternalEdgeRemoval = value;
}

bool *JPH_RagdollSettings_Part_GetMutable_mEnhancedInternalEdgeRemoval(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mEnhancedInternalEdgeRemoval);
}

const bool *JPH_RagdollSettings_Part_Get_mAllowSleeping(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mAllowSleeping);
}

void JPH_RagdollSettings_Part_Set_mAllowSleeping(JPH_RagdollSettings_Part *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mAllowSleeping = value;
}

bool *JPH_RagdollSettings_Part_GetMutable_mAllowSleeping(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mAllowSleeping);
}

const float *JPH_RagdollSettings_Part_Get_mFriction(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mFriction);
}

void JPH_RagdollSettings_Part_Set_mFriction(JPH_RagdollSettings_Part *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mFriction = value;
}

float *JPH_RagdollSettings_Part_GetMutable_mFriction(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mFriction);
}

const float *JPH_RagdollSettings_Part_Get_mRestitution(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mRestitution);
}

void JPH_RagdollSettings_Part_Set_mRestitution(JPH_RagdollSettings_Part *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mRestitution = value;
}

float *JPH_RagdollSettings_Part_GetMutable_mRestitution(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mRestitution);
}

const float *JPH_RagdollSettings_Part_Get_mLinearDamping(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mLinearDamping);
}

void JPH_RagdollSettings_Part_Set_mLinearDamping(JPH_RagdollSettings_Part *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mLinearDamping = value;
}

float *JPH_RagdollSettings_Part_GetMutable_mLinearDamping(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mLinearDamping);
}

const float *JPH_RagdollSettings_Part_Get_mAngularDamping(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mAngularDamping);
}

void JPH_RagdollSettings_Part_Set_mAngularDamping(JPH_RagdollSettings_Part *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mAngularDamping = value;
}

float *JPH_RagdollSettings_Part_GetMutable_mAngularDamping(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mAngularDamping);
}

const float *JPH_RagdollSettings_Part_Get_mMaxLinearVelocity(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mMaxLinearVelocity);
}

void JPH_RagdollSettings_Part_Set_mMaxLinearVelocity(JPH_RagdollSettings_Part *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mMaxLinearVelocity = value;
}

float *JPH_RagdollSettings_Part_GetMutable_mMaxLinearVelocity(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mMaxLinearVelocity);
}

const float *JPH_RagdollSettings_Part_Get_mMaxAngularVelocity(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mMaxAngularVelocity);
}

void JPH_RagdollSettings_Part_Set_mMaxAngularVelocity(JPH_RagdollSettings_Part *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mMaxAngularVelocity = value;
}

float *JPH_RagdollSettings_Part_GetMutable_mMaxAngularVelocity(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mMaxAngularVelocity);
}

const float *JPH_RagdollSettings_Part_Get_mGravityFactor(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mGravityFactor);
}

void JPH_RagdollSettings_Part_Set_mGravityFactor(JPH_RagdollSettings_Part *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mGravityFactor = value;
}

float *JPH_RagdollSettings_Part_GetMutable_mGravityFactor(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mGravityFactor);
}

const unsigned int *JPH_RagdollSettings_Part_Get_mNumVelocityStepsOverride(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mNumVelocityStepsOverride);
}

void JPH_RagdollSettings_Part_Set_mNumVelocityStepsOverride(JPH_RagdollSettings_Part *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mNumVelocityStepsOverride = value;
}

unsigned int *JPH_RagdollSettings_Part_GetMutable_mNumVelocityStepsOverride(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mNumVelocityStepsOverride);
}

const unsigned int *JPH_RagdollSettings_Part_Get_mNumPositionStepsOverride(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mNumPositionStepsOverride);
}

void JPH_RagdollSettings_Part_Set_mNumPositionStepsOverride(JPH_RagdollSettings_Part *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mNumPositionStepsOverride = value;
}

unsigned int *JPH_RagdollSettings_Part_GetMutable_mNumPositionStepsOverride(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mNumPositionStepsOverride);
}

const float *JPH_RagdollSettings_Part_Get_mInertiaMultiplier(const JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).mInertiaMultiplier);
}

void JPH_RagdollSettings_Part_Set_mInertiaMultiplier(JPH_RagdollSettings_Part *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mInertiaMultiplier = value;
}

float *JPH_RagdollSettings_Part_GetMutable_mInertiaMultiplier(JPH_RagdollSettings_Part *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).mInertiaMultiplier);
}

JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RagdollSettings::Part;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RagdollSettings_Part*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RagdollSettings_Part *)(new JPH::RagdollSettings::Part[num_elems]);
}

const JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_OffsetPtr(const JPH_RagdollSettings_Part *ptr, ptrdiff_t i)
{
    return (const JPH_RagdollSettings_Part *)(((const JPH::RagdollSettings::Part *)ptr) + i);
}

JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_OffsetMutablePtr(JPH_RagdollSettings_Part *ptr, ptrdiff_t i)
{
    return (JPH_RagdollSettings_Part *)(((JPH::RagdollSettings::Part *)ptr) + i);
}

const JPH_BodyCreationSettings *JPH_RagdollSettings_Part_UpcastTo_JPH_BodyCreationSettings(const JPH_RagdollSettings_Part *object)
{
    return (const JPH_BodyCreationSettings *)(static_cast<const JPH::BodyCreationSettings *>(
        ((const JPH::RagdollSettings::Part *)object)
    ));
}

JPH_BodyCreationSettings *JPH_RagdollSettings_Part_MutableUpcastTo_JPH_BodyCreationSettings(JPH_RagdollSettings_Part *object)
{
    return (JPH_BodyCreationSettings *)(static_cast<JPH::BodyCreationSettings *>(
        ((JPH::RagdollSettings::Part *)object)
    ));
}

const JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_StaticDowncastFrom_JPH_BodyCreationSettings(const JPH_BodyCreationSettings *object)
{
    return (const JPH_RagdollSettings_Part *)(static_cast<const JPH::RagdollSettings::Part *>(
        ((const JPH::BodyCreationSettings *)object)
    ));
}

JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_MutableStaticDowncastFrom_JPH_BodyCreationSettings(JPH_BodyCreationSettings *object)
{
    return (JPH_RagdollSettings_Part *)(static_cast<JPH::RagdollSettings::Part *>(
        ((JPH::BodyCreationSettings *)object)
    ));
}

JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RagdollSettings_Part *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RagdollSettings::Part);
    return (JPH_RagdollSettings_Part *)new JPH::RagdollSettings::Part(JPH::RagdollSettings::Part(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RagdollSettings::Part) MRBINDC_CLASSARG_COPY(_other, (JPH::RagdollSettings::Part), JPH::RagdollSettings::Part) MRBINDC_CLASSARG_MOVE(_other, (JPH::RagdollSettings::Part), JPH::RagdollSettings::Part) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RagdollSettings::Part) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RagdollSettings::Part) MRBINDC_CLASSARG_END(_other, JPH::RagdollSettings::Part))
    ));
}

void JPH_RagdollSettings_Part_Destroy(const JPH_RagdollSettings_Part *_this)
{
    delete ((const JPH::RagdollSettings::Part *)_this);
}

void JPH_RagdollSettings_Part_DestroyArray(const JPH_RagdollSettings_Part *_this)
{
    delete[] ((const JPH::RagdollSettings::Part *)_this);
}

JPH_RagdollSettings_Part *JPH_RagdollSettings_Part_AssignFromAnother(JPH_RagdollSettings_Part *_this, Jolt_PassBy _other_pass_by, JPH_RagdollSettings_Part *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RagdollSettings::Part);
    return (JPH_RagdollSettings_Part *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RagdollSettings::Part) MRBINDC_CLASSARG_COPY(_other, (JPH::RagdollSettings::Part), JPH::RagdollSettings::Part) MRBINDC_CLASSARG_MOVE(_other, (JPH::RagdollSettings::Part), JPH::RagdollSettings::Part) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RagdollSettings::Part) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RagdollSettings::Part) MRBINDC_CLASSARG_END(_other, JPH::RagdollSettings::Part))
    ));
}

void *Jolt_new_JPH_RagdollSettings_Part_size_t(size_t inCount)
{
    return JPH::RagdollSettings::Part::operator new(
        inCount
    );
}

void Jolt_delete_JPH_RagdollSettings_Part_void_ptr(void *inPointer)
{
    JPH::RagdollSettings::Part::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_RagdollSettings_Part_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RagdollSettings::Part::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_RagdollSettings_Part_size_t(size_t inCount)
{
    return JPH::RagdollSettings::Part::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr(void *inPointer)
{
    JPH::RagdollSettings::Part::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RagdollSettings::Part::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_RagdollSettings_Part_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RagdollSettings::Part::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_RagdollSettings_Part_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RagdollSettings::Part::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_RagdollSettings_Part_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RagdollSettings::Part::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RagdollSettings::Part::operator delete[](
        inPointer,
        inPlace
    );
}

const JPH_ShapeSettings *JPH_RagdollSettings_Part_GetShapeSettings(const JPH_RagdollSettings_Part *_this)
{
    return (const JPH_ShapeSettings *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).GetShapeSettings());
}

void JPH_RagdollSettings_Part_SetShapeSettings(JPH_RagdollSettings_Part *_this, const JPH_ShapeSettings *inShape)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).SetShapeSettings(
        ((const JPH::ShapeSettings *)inShape)
    );
}

const JPH_Shape *JPH_RagdollSettings_Part_GetShape(const JPH_RagdollSettings_Part *_this)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).GetShape());
}

void JPH_RagdollSettings_Part_SetShape(JPH_RagdollSettings_Part *_this, const JPH_Shape *inShape)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::Part *)(_this)).SetShape(
        ((const JPH::Shape *)inShape)
    );
}

bool JPH_RagdollSettings_Part_HasMassProperties(const JPH_RagdollSettings_Part *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(_this)).HasMassProperties();
}

const int *JPH_RagdollSettings_AdditionalConstraint_Get_mBodyIdx(const JPH_RagdollSettings_AdditionalConstraint *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RagdollSettings::AdditionalConstraint *)(_this)).mBodyIdx[0]);
}

int *JPH_RagdollSettings_AdditionalConstraint_GetMutable_mBodyIdx(JPH_RagdollSettings_AdditionalConstraint *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::AdditionalConstraint *)(_this)).mBodyIdx[0]);
}

size_t JPH_RagdollSettings_AdditionalConstraint_GetSize_mBodyIdx(void)
{
    return std::extent_v<decltype(JPH::RagdollSettings::AdditionalConstraint::mBodyIdx)>;
}

JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_AdditionalConstraint_DefaultConstruct(void)
{
    using _mrbind_T = JPH::RagdollSettings::AdditionalConstraint;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_RagdollSettings_AdditionalConstraint*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_AdditionalConstraint_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RagdollSettings_AdditionalConstraint *)(new JPH::RagdollSettings::AdditionalConstraint[num_elems]);
}

const JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_AdditionalConstraint_OffsetPtr(const JPH_RagdollSettings_AdditionalConstraint *ptr, ptrdiff_t i)
{
    return (const JPH_RagdollSettings_AdditionalConstraint *)(((const JPH::RagdollSettings::AdditionalConstraint *)ptr) + i);
}

JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_AdditionalConstraint_OffsetMutablePtr(JPH_RagdollSettings_AdditionalConstraint *ptr, ptrdiff_t i)
{
    return (JPH_RagdollSettings_AdditionalConstraint *)(((JPH::RagdollSettings::AdditionalConstraint *)ptr) + i);
}

JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_AdditionalConstraint_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_RagdollSettings_AdditionalConstraint *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RagdollSettings::AdditionalConstraint);
    return (JPH_RagdollSettings_AdditionalConstraint *)new JPH::RagdollSettings::AdditionalConstraint(JPH::RagdollSettings::AdditionalConstraint(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_COPY(_other, (JPH::RagdollSettings::AdditionalConstraint), JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_MOVE(_other, (JPH::RagdollSettings::AdditionalConstraint), JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_END(_other, JPH::RagdollSettings::AdditionalConstraint))
    ));
}

JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_AdditionalConstraint_Construct(int inBodyIdx1, int inBodyIdx2, JPH_TwoBodyConstraintSettings *inConstraint)
{
    return (JPH_RagdollSettings_AdditionalConstraint *)new JPH::RagdollSettings::AdditionalConstraint(JPH::RagdollSettings::AdditionalConstraint(
        inBodyIdx1,
        inBodyIdx2,
        ((JPH::TwoBodyConstraintSettings *)inConstraint)
    ));
}

void JPH_RagdollSettings_AdditionalConstraint_Destroy(const JPH_RagdollSettings_AdditionalConstraint *_this)
{
    delete ((const JPH::RagdollSettings::AdditionalConstraint *)_this);
}

void JPH_RagdollSettings_AdditionalConstraint_DestroyArray(const JPH_RagdollSettings_AdditionalConstraint *_this)
{
    delete[] ((const JPH::RagdollSettings::AdditionalConstraint *)_this);
}

JPH_RagdollSettings_AdditionalConstraint *JPH_RagdollSettings_AdditionalConstraint_AssignFromAnother(JPH_RagdollSettings_AdditionalConstraint *_this, Jolt_PassBy _other_pass_by, JPH_RagdollSettings_AdditionalConstraint *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::RagdollSettings::AdditionalConstraint);
    return (JPH_RagdollSettings_AdditionalConstraint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RagdollSettings::AdditionalConstraint *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_COPY(_other, (JPH::RagdollSettings::AdditionalConstraint), JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_MOVE(_other, (JPH::RagdollSettings::AdditionalConstraint), JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::RagdollSettings::AdditionalConstraint) MRBINDC_CLASSARG_END(_other, JPH::RagdollSettings::AdditionalConstraint))
    ));
}

void *Jolt_new_JPH_RagdollSettings_AdditionalConstraint_size_t(size_t inCount)
{
    return JPH::RagdollSettings::AdditionalConstraint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr(void *inPointer)
{
    JPH::RagdollSettings::AdditionalConstraint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RagdollSettings::AdditionalConstraint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_RagdollSettings_AdditionalConstraint_size_t(size_t inCount)
{
    return JPH::RagdollSettings::AdditionalConstraint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr(void *inPointer)
{
    JPH::RagdollSettings::AdditionalConstraint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RagdollSettings::AdditionalConstraint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_RagdollSettings_AdditionalConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RagdollSettings::AdditionalConstraint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RagdollSettings::AdditionalConstraint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_RagdollSettings_AdditionalConstraint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RagdollSettings::AdditionalConstraint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RagdollSettings::AdditionalConstraint::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_Ragdoll *JPH_Ragdoll_Construct(JPH_PhysicsSystem *inSystem)
{
    return (JPH_Ragdoll *)new JPH::Ragdoll(JPH::Ragdoll(
        ((JPH::PhysicsSystem *)inSystem)
    ));
}

const JPH_Ragdoll *JPH_Ragdoll_OffsetPtr(const JPH_Ragdoll *ptr, ptrdiff_t i)
{
    return (const JPH_Ragdoll *)(((const JPH::Ragdoll *)ptr) + i);
}

JPH_Ragdoll *JPH_Ragdoll_OffsetMutablePtr(JPH_Ragdoll *ptr, ptrdiff_t i)
{
    return (JPH_Ragdoll *)(((JPH::Ragdoll *)ptr) + i);
}

const JPH_RefTarget_JPH_Ragdoll *JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll(const JPH_Ragdoll *object)
{
    return (const JPH_RefTarget_JPH_Ragdoll *)(static_cast<const JPH::RefTarget<JPH::Ragdoll> *>(
        ((const JPH::Ragdoll *)object)
    ));
}

JPH_RefTarget_JPH_Ragdoll *JPH_Ragdoll_MutableUpcastTo_JPH_RefTarget_JPH_Ragdoll(JPH_Ragdoll *object)
{
    return (JPH_RefTarget_JPH_Ragdoll *)(static_cast<JPH::RefTarget<JPH::Ragdoll> *>(
        ((JPH::Ragdoll *)object)
    ));
}

const JPH_Ragdoll *JPH_Ragdoll_StaticDowncastFrom_JPH_RefTarget_JPH_Ragdoll(const JPH_RefTarget_JPH_Ragdoll *object)
{
    return (const JPH_Ragdoll *)(static_cast<const JPH::Ragdoll *>(
        ((const JPH::RefTarget<JPH::Ragdoll> *)object)
    ));
}

JPH_Ragdoll *JPH_Ragdoll_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Ragdoll(JPH_RefTarget_JPH_Ragdoll *object)
{
    return (JPH_Ragdoll *)(static_cast<JPH::Ragdoll *>(
        ((JPH::RefTarget<JPH::Ragdoll> *)object)
    ));
}

const JPH_NonCopyable *JPH_Ragdoll_UpcastTo_JPH_NonCopyable(const JPH_Ragdoll *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::Ragdoll *)object)
    ));
}

JPH_NonCopyable *JPH_Ragdoll_MutableUpcastTo_JPH_NonCopyable(JPH_Ragdoll *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::Ragdoll *)object)
    ));
}

const JPH_Ragdoll *JPH_Ragdoll_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_Ragdoll *)(static_cast<const JPH::Ragdoll *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_Ragdoll *JPH_Ragdoll_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_Ragdoll *)(static_cast<JPH::Ragdoll *>(
        ((JPH::NonCopyable *)object)
    ));
}

void JPH_Ragdoll_Destroy(const JPH_Ragdoll *_this)
{
    delete ((const JPH::Ragdoll *)_this);
}

void JPH_Ragdoll_DestroyArray(const JPH_Ragdoll *_this)
{
    delete[] ((const JPH::Ragdoll *)_this);
}

void *Jolt_new_JPH_Ragdoll_size_t(size_t inCount)
{
    return JPH::Ragdoll::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Ragdoll_void_ptr(void *inPointer)
{
    JPH::Ragdoll::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Ragdoll_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Ragdoll::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Ragdoll_size_t(size_t inCount)
{
    return JPH::Ragdoll::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Ragdoll_void_ptr(void *inPointer)
{
    JPH::Ragdoll::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Ragdoll_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Ragdoll::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Ragdoll_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Ragdoll::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Ragdoll_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Ragdoll::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Ragdoll_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Ragdoll::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Ragdoll_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Ragdoll::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_Ragdoll_AddToPhysicsSystem(JPH_Ragdoll *_this, JPH_EActivation inActivationMode, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).AddToPhysicsSystem(
        ((JPH::EActivation)inActivationMode),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Ragdoll_RemoveFromPhysicsSystem(JPH_Ragdoll *_this, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).RemoveFromPhysicsSystem(
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Ragdoll_Activate(JPH_Ragdoll *_this, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).Activate(
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

bool JPH_Ragdoll_IsActive(const JPH_Ragdoll *_this, const bool *inLockBodies)
{
    using namespace JPH;
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ragdoll *)(_this)).IsActive(
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Ragdoll_SetGroupID(JPH_Ragdoll *_this, unsigned int inGroupID, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).SetGroupID(
        inGroupID,
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Ragdoll_SetPose_2(JPH_Ragdoll *_this, const JPH_SkeletonPose *inPose, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).SetPose(
        ((inPose ? void() : MRBINDC_THROW("Parameter `inPose` can not be null.", void)), *(const JPH::SkeletonPose *)(inPose)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Ragdoll_SetPose_3(JPH_Ragdoll *_this, const JPH_Vec3 *inRootOffset, const JPH_Mat44 *inJointMatrices, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).SetPose(
        ((inRootOffset ? void() : MRBINDC_THROW("Parameter `inRootOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inRootOffset)),
        ((const JPH::Mat44 *)inJointMatrices),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Ragdoll_GetPose_2(JPH_Ragdoll *_this, JPH_SkeletonPose *outPose, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).GetPose(
        ((outPose ? void() : MRBINDC_THROW("Parameter `outPose` can not be null.", void)), *(JPH::SkeletonPose *)(outPose)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Ragdoll_GetPose_3(JPH_Ragdoll *_this, JPH_Vec3 *outRootOffset, JPH_Mat44 *outJointMatrices, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).GetPose(
        ((outRootOffset ? void() : MRBINDC_THROW("Parameter `outRootOffset` can not be null.", void)), *(JPH::Vec3 *)(outRootOffset)),
        ((JPH::Mat44 *)outJointMatrices),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Ragdoll_ResetWarmStart(JPH_Ragdoll *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).ResetWarmStart();
}

void JPH_Ragdoll_DriveToPoseUsingKinematics_3(JPH_Ragdoll *_this, const JPH_SkeletonPose *inPose, float inDeltaTime, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).DriveToPoseUsingKinematics(
        ((inPose ? void() : MRBINDC_THROW("Parameter `inPose` can not be null.", void)), *(const JPH::SkeletonPose *)(inPose)),
        inDeltaTime,
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Ragdoll_DriveToPoseUsingKinematics_4(JPH_Ragdoll *_this, const JPH_Vec3 *inRootOffset, const JPH_Mat44 *inJointMatrices, float inDeltaTime, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).DriveToPoseUsingKinematics(
        ((inRootOffset ? void() : MRBINDC_THROW("Parameter `inRootOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inRootOffset)),
        ((const JPH::Mat44 *)inJointMatrices),
        inDeltaTime,
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Ragdoll_DriveToPoseUsingMotors(JPH_Ragdoll *_this, const JPH_SkeletonPose *inPose)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).DriveToPoseUsingMotors(
        ((inPose ? void() : MRBINDC_THROW("Parameter `inPose` can not be null.", void)), *(const JPH::SkeletonPose *)(inPose))
    );
}

void JPH_Ragdoll_SetLinearAndAngularVelocity(JPH_Ragdoll *_this, const JPH_Vec3 *inLinearVelocity, const JPH_Vec3 *inAngularVelocity, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).SetLinearAndAngularVelocity(
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity)),
        ((inAngularVelocity ? void() : MRBINDC_THROW("Parameter `inAngularVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocity)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Ragdoll_SetLinearVelocity(JPH_Ragdoll *_this, const JPH_Vec3 *inLinearVelocity, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).SetLinearVelocity(
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Ragdoll_AddLinearVelocity(JPH_Ragdoll *_this, const JPH_Vec3 *inLinearVelocity, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).AddLinearVelocity(
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Ragdoll_AddImpulse(JPH_Ragdoll *_this, const JPH_Vec3 *inImpulse, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).AddImpulse(
        ((inImpulse ? void() : MRBINDC_THROW("Parameter `inImpulse` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inImpulse)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

void JPH_Ragdoll_GetRootTransform(const JPH_Ragdoll *_this, JPH_Vec3 *outPosition, JPH_Quat *outRotation, const bool *inLockBodies)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ragdoll *)(_this)).GetRootTransform(
        ((outPosition ? void() : MRBINDC_THROW("Parameter `outPosition` can not be null.", void)), *(JPH::Vec3 *)(outPosition)),
        ((outRotation ? void() : MRBINDC_THROW("Parameter `outRotation` can not be null.", void)), *(JPH::Quat *)(outRotation)),
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    );
}

size_t JPH_Ragdoll_GetBodyCount(const JPH_Ragdoll *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ragdoll *)(_this)).GetBodyCount();
}

JPH_BodyID JPH_Ragdoll_GetBodyID(const JPH_Ragdoll *_this, int inBodyIndex)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ragdoll *)(_this)).GetBodyID(
        inBodyIndex
    ));
}

const Jolt_JPH_Array_JPH_BodyID *JPH_Ragdoll_GetBodyIDs(const JPH_Ragdoll *_this)
{
    return (const Jolt_JPH_Array_JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ragdoll *)(_this)).GetBodyIDs());
}

size_t JPH_Ragdoll_GetConstraintCount(const JPH_Ragdoll *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ragdoll *)(_this)).GetConstraintCount();
}

JPH_TwoBodyConstraint *JPH_Ragdoll_GetConstraint_mut(JPH_Ragdoll *_this, int inConstraintIndex)
{
    return (JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Ragdoll *)(_this)).GetConstraint(
        inConstraintIndex
    ));
}

const JPH_TwoBodyConstraint *JPH_Ragdoll_GetConstraint(const JPH_Ragdoll *_this, int inConstraintIndex)
{
    return (const JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ragdoll *)(_this)).GetConstraint(
        inConstraintIndex
    ));
}

JPH_AABox *JPH_Ragdoll_GetWorldSpaceBounds(const JPH_Ragdoll *_this, const bool *inLockBodies)
{
    using namespace JPH;
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ragdoll *)(_this)).GetWorldSpaceBounds(
        (inLockBodies ? *inLockBodies : static_cast<bool>(true))
    ));
}

const JPH_RagdollSettings *JPH_Ragdoll_GetRagdollSettings(const JPH_Ragdoll *_this)
{
    return (const JPH_RagdollSettings *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ragdoll *)(_this)).GetRagdollSettings());
}

void JPH_Ragdoll_SetEmbedded(const JPH_Ragdoll *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ragdoll *)(_this)).SetEmbedded();
}

unsigned int JPH_Ragdoll_GetRefCount(const JPH_Ragdoll *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ragdoll *)(_this)).GetRefCount();
}

void JPH_Ragdoll_AddRef(const JPH_Ragdoll *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ragdoll *)(_this)).AddRef();
}

void JPH_Ragdoll_Release(const JPH_Ragdoll *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Ragdoll *)(_this)).Release();
}

int JPH_Ragdoll_sInternalGetRefCountOffset(void)
{
    return JPH::Ragdoll::sInternalGetRefCountOffset();
}

