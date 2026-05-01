// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Skeleton/SkeletonPose.h"

#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <Jolt/Skeleton/SkeletalAnimation.h>
#include <Jolt/Skeleton/Skeleton.h>
#include <Jolt/Skeleton/SkeletonPose.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


JPH_SkeletonPose *JPH_SkeletonPose_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SkeletonPose;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SkeletonPose*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SkeletonPose *JPH_SkeletonPose_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SkeletonPose *)(new JPH::SkeletonPose[num_elems]{});
}

const JPH_SkeletonPose *JPH_SkeletonPose_OffsetPtr(const JPH_SkeletonPose *ptr, ptrdiff_t i)
{
    return (const JPH_SkeletonPose *)(((const JPH::SkeletonPose *)ptr) + i);
}

JPH_SkeletonPose *JPH_SkeletonPose_OffsetMutablePtr(JPH_SkeletonPose *ptr, ptrdiff_t i)
{
    return (JPH_SkeletonPose *)(((JPH::SkeletonPose *)ptr) + i);
}

JPH_SkeletonPose *JPH_SkeletonPose_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SkeletonPose *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SkeletonPose);
    return (JPH_SkeletonPose *)new JPH::SkeletonPose(JPH::SkeletonPose(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SkeletonPose) MRBINDC_CLASSARG_COPY(_other, (JPH::SkeletonPose), JPH::SkeletonPose) MRBINDC_CLASSARG_MOVE(_other, (JPH::SkeletonPose), JPH::SkeletonPose) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SkeletonPose) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SkeletonPose) MRBINDC_CLASSARG_END(_other, JPH::SkeletonPose))
    ));
}

void JPH_SkeletonPose_Destroy(const JPH_SkeletonPose *_this)
{
    delete ((const JPH::SkeletonPose *)_this);
}

void JPH_SkeletonPose_DestroyArray(const JPH_SkeletonPose *_this)
{
    delete[] ((const JPH::SkeletonPose *)_this);
}

JPH_SkeletonPose *JPH_SkeletonPose_AssignFromAnother(JPH_SkeletonPose *_this, Jolt_PassBy _other_pass_by, JPH_SkeletonPose *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SkeletonPose);
    return (JPH_SkeletonPose *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonPose *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SkeletonPose) MRBINDC_CLASSARG_COPY(_other, (JPH::SkeletonPose), JPH::SkeletonPose) MRBINDC_CLASSARG_MOVE(_other, (JPH::SkeletonPose), JPH::SkeletonPose) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SkeletonPose) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SkeletonPose) MRBINDC_CLASSARG_END(_other, JPH::SkeletonPose))
    ));
}

void *Jolt_new_JPH_SkeletonPose_size_t(size_t inCount)
{
    return JPH::SkeletonPose::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SkeletonPose_void_ptr(void *inPointer)
{
    JPH::SkeletonPose::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SkeletonPose_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SkeletonPose::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SkeletonPose_size_t(size_t inCount)
{
    return JPH::SkeletonPose::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SkeletonPose_void_ptr(void *inPointer)
{
    JPH::SkeletonPose::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SkeletonPose_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SkeletonPose::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SkeletonPose_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SkeletonPose::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SkeletonPose_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SkeletonPose::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SkeletonPose_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SkeletonPose::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SkeletonPose_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SkeletonPose::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_SkeletonPose_SetSkeleton(JPH_SkeletonPose *_this, const JPH_Skeleton *inSkeleton)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonPose *)(_this)).SetSkeleton(
        ((const JPH::Skeleton *)inSkeleton)
    );
}

const JPH_Skeleton *JPH_SkeletonPose_GetSkeleton(const JPH_SkeletonPose *_this)
{
    return (const JPH_Skeleton *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonPose *)(_this)).GetSkeleton());
}

void JPH_SkeletonPose_SetRootOffset(JPH_SkeletonPose *_this, const JPH_Vec3 *inOffset)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonPose *)(_this)).SetRootOffset(
        ((inOffset ? void() : MRBINDC_THROW("Parameter `inOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOffset))
    );
}

JPH_Vec3 *JPH_SkeletonPose_GetRootOffset(const JPH_SkeletonPose *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonPose *)(_this)).GetRootOffset());
}

unsigned int JPH_SkeletonPose_GetJointCount(const JPH_SkeletonPose *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonPose *)(_this)).GetJointCount();
}

const JPH_SkeletalAnimation_JointState *JPH_SkeletonPose_GetJoint(const JPH_SkeletonPose *_this, int inJoint)
{
    return (const JPH_SkeletalAnimation_JointState *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonPose *)(_this)).GetJoint(
        inJoint
    ));
}

JPH_SkeletalAnimation_JointState *JPH_SkeletonPose_GetJoint_mut(JPH_SkeletonPose *_this, int inJoint)
{
    return (JPH_SkeletalAnimation_JointState *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonPose *)(_this)).GetJoint(
        inJoint
    ));
}

const JPH_Mat44 *JPH_SkeletonPose_GetJointMatrix(const JPH_SkeletonPose *_this, int inJoint)
{
    return (const JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonPose *)(_this)).GetJointMatrix(
        inJoint
    ));
}

JPH_Mat44 *JPH_SkeletonPose_GetJointMatrix_mut(JPH_SkeletonPose *_this, int inJoint)
{
    return (JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonPose *)(_this)).GetJointMatrix(
        inJoint
    ));
}

void JPH_SkeletonPose_CalculateJointMatrices(JPH_SkeletonPose *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonPose *)(_this)).CalculateJointMatrices();
}

void JPH_SkeletonPose_CalculateJointStates(JPH_SkeletonPose *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonPose *)(_this)).CalculateJointStates();
}

void JPH_SkeletonPose_CalculateLocalSpaceJointMatrices(const JPH_SkeletonPose *_this, JPH_Mat44 *outMatrices)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonPose *)(_this)).CalculateLocalSpaceJointMatrices(
        ((JPH::Mat44 *)outMatrices)
    );
}

void JPH_SkeletonPose_Draw(const JPH_SkeletonPose *_this, const JPH_SkeletonPose_DrawSettings *inDrawSettings, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inOffset)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonPose *)(_this)).Draw(
        ((inDrawSettings ? void() : MRBINDC_THROW("Parameter `inDrawSettings` can not be null.", void)), *(const JPH::SkeletonPose::DrawSettings *)(inDrawSettings)),
        ((JPH::DebugRenderer *)inRenderer),
        (inOffset ? *(const JPH::Mat44 *)(inOffset) : static_cast<const JPH::Mat44 &>(RMat44::sIdentity()))
    );
}

const bool *JPH_SkeletonPose_DrawSettings_Get_mDrawJoints(const JPH_SkeletonPose_DrawSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonPose::DrawSettings *)(_this)).mDrawJoints);
}

void JPH_SkeletonPose_DrawSettings_Set_mDrawJoints(JPH_SkeletonPose_DrawSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonPose::DrawSettings *)(_this)).mDrawJoints = value;
}

bool *JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJoints(JPH_SkeletonPose_DrawSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonPose::DrawSettings *)(_this)).mDrawJoints);
}

const bool *JPH_SkeletonPose_DrawSettings_Get_mDrawJointOrientations(const JPH_SkeletonPose_DrawSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonPose::DrawSettings *)(_this)).mDrawJointOrientations);
}

void JPH_SkeletonPose_DrawSettings_Set_mDrawJointOrientations(JPH_SkeletonPose_DrawSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonPose::DrawSettings *)(_this)).mDrawJointOrientations = value;
}

bool *JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJointOrientations(JPH_SkeletonPose_DrawSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonPose::DrawSettings *)(_this)).mDrawJointOrientations);
}

const bool *JPH_SkeletonPose_DrawSettings_Get_mDrawJointNames(const JPH_SkeletonPose_DrawSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonPose::DrawSettings *)(_this)).mDrawJointNames);
}

void JPH_SkeletonPose_DrawSettings_Set_mDrawJointNames(JPH_SkeletonPose_DrawSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonPose::DrawSettings *)(_this)).mDrawJointNames = value;
}

bool *JPH_SkeletonPose_DrawSettings_GetMutable_mDrawJointNames(JPH_SkeletonPose_DrawSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonPose::DrawSettings *)(_this)).mDrawJointNames);
}

JPH_SkeletonPose_DrawSettings *JPH_SkeletonPose_DrawSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SkeletonPose::DrawSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SkeletonPose_DrawSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SkeletonPose_DrawSettings *JPH_SkeletonPose_DrawSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SkeletonPose_DrawSettings *)(new JPH::SkeletonPose::DrawSettings[num_elems]{});
}

JPH_SkeletonPose_DrawSettings *JPH_SkeletonPose_DrawSettings_ConstructFrom(bool mDrawJoints, bool mDrawJointOrientations, bool mDrawJointNames)
{
    return (JPH_SkeletonPose_DrawSettings *)new JPH::SkeletonPose::DrawSettings(JPH::SkeletonPose::DrawSettings{
        mDrawJoints,
        mDrawJointOrientations,
        mDrawJointNames
    });
}

const JPH_SkeletonPose_DrawSettings *JPH_SkeletonPose_DrawSettings_OffsetPtr(const JPH_SkeletonPose_DrawSettings *ptr, ptrdiff_t i)
{
    return (const JPH_SkeletonPose_DrawSettings *)(((const JPH::SkeletonPose::DrawSettings *)ptr) + i);
}

JPH_SkeletonPose_DrawSettings *JPH_SkeletonPose_DrawSettings_OffsetMutablePtr(JPH_SkeletonPose_DrawSettings *ptr, ptrdiff_t i)
{
    return (JPH_SkeletonPose_DrawSettings *)(((JPH::SkeletonPose::DrawSettings *)ptr) + i);
}

JPH_SkeletonPose_DrawSettings *JPH_SkeletonPose_DrawSettings_ConstructFromAnother(const JPH_SkeletonPose_DrawSettings *_other)
{
    return (JPH_SkeletonPose_DrawSettings *)new JPH::SkeletonPose::DrawSettings(JPH::SkeletonPose::DrawSettings(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SkeletonPose::DrawSettings(*(JPH::SkeletonPose::DrawSettings *)_other))
    ));
}

void JPH_SkeletonPose_DrawSettings_Destroy(const JPH_SkeletonPose_DrawSettings *_this)
{
    delete ((const JPH::SkeletonPose::DrawSettings *)_this);
}

void JPH_SkeletonPose_DrawSettings_DestroyArray(const JPH_SkeletonPose_DrawSettings *_this)
{
    delete[] ((const JPH::SkeletonPose::DrawSettings *)_this);
}

JPH_SkeletonPose_DrawSettings *JPH_SkeletonPose_DrawSettings_AssignFromAnother(JPH_SkeletonPose_DrawSettings *_this, const JPH_SkeletonPose_DrawSettings *_other)
{
    return (JPH_SkeletonPose_DrawSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonPose::DrawSettings *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SkeletonPose::DrawSettings(*(JPH::SkeletonPose::DrawSettings *)_other))
    ));
}

