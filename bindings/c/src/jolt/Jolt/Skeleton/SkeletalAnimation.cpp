// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Skeleton/SkeletalAnimation.h"

#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Skeleton/SkeletalAnimation.h>
#include <Jolt/Skeleton/SkeletonPose.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


JPH_SkeletalAnimation *JPH_SkeletalAnimation_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SkeletalAnimation;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SkeletalAnimation*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SkeletalAnimation *JPH_SkeletalAnimation_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SkeletalAnimation *)(new JPH::SkeletalAnimation[num_elems]);
}

const JPH_SkeletalAnimation *JPH_SkeletalAnimation_OffsetPtr(const JPH_SkeletalAnimation *ptr, ptrdiff_t i)
{
    return (const JPH_SkeletalAnimation *)(((const JPH::SkeletalAnimation *)ptr) + i);
}

JPH_SkeletalAnimation *JPH_SkeletalAnimation_OffsetMutablePtr(JPH_SkeletalAnimation *ptr, ptrdiff_t i)
{
    return (JPH_SkeletalAnimation *)(((JPH::SkeletalAnimation *)ptr) + i);
}

const JPH_RefTarget_JPH_SkeletalAnimation *JPH_SkeletalAnimation_UpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(const JPH_SkeletalAnimation *object)
{
    return (const JPH_RefTarget_JPH_SkeletalAnimation *)(static_cast<const JPH::RefTarget<JPH::SkeletalAnimation> *>(
        ((const JPH::SkeletalAnimation *)object)
    ));
}

JPH_RefTarget_JPH_SkeletalAnimation *JPH_SkeletalAnimation_MutableUpcastTo_JPH_RefTarget_JPH_SkeletalAnimation(JPH_SkeletalAnimation *object)
{
    return (JPH_RefTarget_JPH_SkeletalAnimation *)(static_cast<JPH::RefTarget<JPH::SkeletalAnimation> *>(
        ((JPH::SkeletalAnimation *)object)
    ));
}

const JPH_SkeletalAnimation *JPH_SkeletalAnimation_StaticDowncastFrom_JPH_RefTarget_JPH_SkeletalAnimation(const JPH_RefTarget_JPH_SkeletalAnimation *object)
{
    return (const JPH_SkeletalAnimation *)(static_cast<const JPH::SkeletalAnimation *>(
        ((const JPH::RefTarget<JPH::SkeletalAnimation> *)object)
    ));
}

JPH_SkeletalAnimation *JPH_SkeletalAnimation_MutableStaticDowncastFrom_JPH_RefTarget_JPH_SkeletalAnimation(JPH_RefTarget_JPH_SkeletalAnimation *object)
{
    return (JPH_SkeletalAnimation *)(static_cast<JPH::SkeletalAnimation *>(
        ((JPH::RefTarget<JPH::SkeletalAnimation> *)object)
    ));
}

JPH_SkeletalAnimation *JPH_SkeletalAnimation_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SkeletalAnimation *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SkeletalAnimation);
    return (JPH_SkeletalAnimation *)new JPH::SkeletalAnimation(JPH::SkeletalAnimation(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SkeletalAnimation) MRBINDC_CLASSARG_COPY(_other, (JPH::SkeletalAnimation), JPH::SkeletalAnimation) MRBINDC_CLASSARG_MOVE(_other, (JPH::SkeletalAnimation), JPH::SkeletalAnimation) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SkeletalAnimation) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SkeletalAnimation) MRBINDC_CLASSARG_END(_other, JPH::SkeletalAnimation))
    ));
}

void JPH_SkeletalAnimation_Destroy(const JPH_SkeletalAnimation *_this)
{
    delete ((const JPH::SkeletalAnimation *)_this);
}

void JPH_SkeletalAnimation_DestroyArray(const JPH_SkeletalAnimation *_this)
{
    delete[] ((const JPH::SkeletalAnimation *)_this);
}

JPH_SkeletalAnimation *JPH_SkeletalAnimation_AssignFromAnother(JPH_SkeletalAnimation *_this, Jolt_PassBy _other_pass_by, JPH_SkeletalAnimation *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SkeletalAnimation);
    return (JPH_SkeletalAnimation *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletalAnimation *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SkeletalAnimation) MRBINDC_CLASSARG_COPY(_other, (JPH::SkeletalAnimation), JPH::SkeletalAnimation) MRBINDC_CLASSARG_MOVE(_other, (JPH::SkeletalAnimation), JPH::SkeletalAnimation) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SkeletalAnimation) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SkeletalAnimation) MRBINDC_CLASSARG_END(_other, JPH::SkeletalAnimation))
    ));
}

void *Jolt_new_JPH_SkeletalAnimation_size_t(size_t inCount)
{
    return JPH::SkeletalAnimation::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SkeletalAnimation_void_ptr(void *inPointer)
{
    JPH::SkeletalAnimation::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SkeletalAnimation_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SkeletalAnimation::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SkeletalAnimation_size_t(size_t inCount)
{
    return JPH::SkeletalAnimation::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SkeletalAnimation_void_ptr(void *inPointer)
{
    JPH::SkeletalAnimation::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SkeletalAnimation_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SkeletalAnimation::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SkeletalAnimation_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SkeletalAnimation::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SkeletalAnimation_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SkeletalAnimation::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SkeletalAnimation_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SkeletalAnimation::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SkeletalAnimation_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SkeletalAnimation::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_SkeletalAnimation_GetDuration(const JPH_SkeletalAnimation *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletalAnimation *)(_this)).GetDuration();
}

void JPH_SkeletalAnimation_ScaleJoints(JPH_SkeletalAnimation *_this, float inScale)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletalAnimation *)(_this)).ScaleJoints(
        inScale
    );
}

void JPH_SkeletalAnimation_SetIsLooping(JPH_SkeletalAnimation *_this, bool inIsLooping)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletalAnimation *)(_this)).SetIsLooping(
        inIsLooping
    );
}

bool JPH_SkeletalAnimation_IsLooping(const JPH_SkeletalAnimation *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletalAnimation *)(_this)).IsLooping();
}

void JPH_SkeletalAnimation_Sample(const JPH_SkeletalAnimation *_this, float inTime, JPH_SkeletonPose *ioPose)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletalAnimation *)(_this)).Sample(
        inTime,
        ((ioPose ? void() : MRBINDC_THROW("Parameter `ioPose` can not be null.", void)), *(JPH::SkeletonPose *)(ioPose))
    );
}

void JPH_SkeletalAnimation_SetEmbedded(const JPH_SkeletalAnimation *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletalAnimation *)(_this)).SetEmbedded();
}

unsigned int JPH_SkeletalAnimation_GetRefCount(const JPH_SkeletalAnimation *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletalAnimation *)(_this)).GetRefCount();
}

void JPH_SkeletalAnimation_AddRef(const JPH_SkeletalAnimation *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletalAnimation *)(_this)).AddRef();
}

void JPH_SkeletalAnimation_Release(const JPH_SkeletalAnimation *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletalAnimation *)(_this)).Release();
}

int JPH_SkeletalAnimation_sInternalGetRefCountOffset(void)
{
    return JPH::SkeletalAnimation::sInternalGetRefCountOffset();
}

const JPH_Quat *JPH_SkeletalAnimation_JointState_Get_mRotation(const JPH_SkeletalAnimation_JointState *_this)
{
    return (const JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletalAnimation::JointState *)(_this)).mRotation);
}

JPH_Quat *JPH_SkeletalAnimation_JointState_GetMutable_mRotation(JPH_SkeletalAnimation_JointState *_this)
{
    return (JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletalAnimation::JointState *)(_this)).mRotation);
}

const JPH_Vec3 *JPH_SkeletalAnimation_JointState_Get_mTranslation(const JPH_SkeletalAnimation_JointState *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletalAnimation::JointState *)(_this)).mTranslation);
}

JPH_Vec3 *JPH_SkeletalAnimation_JointState_GetMutable_mTranslation(JPH_SkeletalAnimation_JointState *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletalAnimation::JointState *)(_this)).mTranslation);
}

JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_JointState_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SkeletalAnimation::JointState;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SkeletalAnimation_JointState*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_JointState_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SkeletalAnimation_JointState *)(new JPH::SkeletalAnimation::JointState[num_elems]);
}

JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_JointState_ConstructFrom(const JPH_Quat *mRotation, const JPH_Vec3 *mTranslation)
{
    return (JPH_SkeletalAnimation_JointState *)new JPH::SkeletalAnimation::JointState(JPH::SkeletalAnimation::JointState{
        ((mRotation ? void() : MRBINDC_THROW("Parameter `mRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)mRotation)),
        ((mTranslation ? void() : MRBINDC_THROW("Parameter `mTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mTranslation))
    });
}

const JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_JointState_OffsetPtr(const JPH_SkeletalAnimation_JointState *ptr, ptrdiff_t i)
{
    return (const JPH_SkeletalAnimation_JointState *)(((const JPH::SkeletalAnimation::JointState *)ptr) + i);
}

JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_JointState_OffsetMutablePtr(JPH_SkeletalAnimation_JointState *ptr, ptrdiff_t i)
{
    return (JPH_SkeletalAnimation_JointState *)(((JPH::SkeletalAnimation::JointState *)ptr) + i);
}

JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_JointState_ConstructFromAnother(const JPH_SkeletalAnimation_JointState *_other)
{
    return (JPH_SkeletalAnimation_JointState *)new JPH::SkeletalAnimation::JointState(JPH::SkeletalAnimation::JointState(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SkeletalAnimation::JointState(*(JPH::SkeletalAnimation::JointState *)_other))
    ));
}

void JPH_SkeletalAnimation_JointState_Destroy(const JPH_SkeletalAnimation_JointState *_this)
{
    delete ((const JPH::SkeletalAnimation::JointState *)_this);
}

void JPH_SkeletalAnimation_JointState_DestroyArray(const JPH_SkeletalAnimation_JointState *_this)
{
    delete[] ((const JPH::SkeletalAnimation::JointState *)_this);
}

JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_JointState_AssignFromAnother(JPH_SkeletalAnimation_JointState *_this, const JPH_SkeletalAnimation_JointState *_other)
{
    return (JPH_SkeletalAnimation_JointState *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletalAnimation::JointState *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SkeletalAnimation::JointState(*(JPH::SkeletalAnimation::JointState *)_other))
    ));
}

void *Jolt_new_JPH_SkeletalAnimation_JointState_size_t(size_t inCount)
{
    return JPH::SkeletalAnimation::JointState::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr(void *inPointer)
{
    JPH::SkeletalAnimation::JointState::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SkeletalAnimation::JointState::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SkeletalAnimation_JointState_size_t(size_t inCount)
{
    return JPH::SkeletalAnimation::JointState::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr(void *inPointer)
{
    JPH::SkeletalAnimation::JointState::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SkeletalAnimation::JointState::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SkeletalAnimation_JointState_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SkeletalAnimation::JointState::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SkeletalAnimation_JointState_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SkeletalAnimation::JointState::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SkeletalAnimation_JointState_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SkeletalAnimation::JointState::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SkeletalAnimation_JointState_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SkeletalAnimation::JointState::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_SkeletalAnimation_JointState_FromMatrix(JPH_SkeletalAnimation_JointState *_this, const JPH_Mat44 *inMatrix)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletalAnimation::JointState *)(_this)).FromMatrix(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix))
    );
}

JPH_Mat44 *JPH_SkeletalAnimation_JointState_ToMatrix(const JPH_SkeletalAnimation_JointState *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletalAnimation::JointState *)(_this)).ToMatrix());
}

const float *JPH_SkeletalAnimation_Keyframe_Get_mTime(const JPH_SkeletalAnimation_Keyframe *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletalAnimation::Keyframe *)(_this)).mTime);
}

void JPH_SkeletalAnimation_Keyframe_Set_mTime(JPH_SkeletalAnimation_Keyframe *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletalAnimation::Keyframe *)(_this)).mTime = value;
}

float *JPH_SkeletalAnimation_Keyframe_GetMutable_mTime(JPH_SkeletalAnimation_Keyframe *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletalAnimation::Keyframe *)(_this)).mTime);
}

const JPH_Quat *JPH_SkeletalAnimation_Keyframe_Get_mRotation(const JPH_SkeletalAnimation_Keyframe *_this)
{
    return (const JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletalAnimation::Keyframe *)(_this)).mRotation);
}

JPH_Quat *JPH_SkeletalAnimation_Keyframe_GetMutable_mRotation(JPH_SkeletalAnimation_Keyframe *_this)
{
    return (JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletalAnimation::Keyframe *)(_this)).mRotation);
}

const JPH_Vec3 *JPH_SkeletalAnimation_Keyframe_Get_mTranslation(const JPH_SkeletalAnimation_Keyframe *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletalAnimation::Keyframe *)(_this)).mTranslation);
}

JPH_Vec3 *JPH_SkeletalAnimation_Keyframe_GetMutable_mTranslation(JPH_SkeletalAnimation_Keyframe *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletalAnimation::Keyframe *)(_this)).mTranslation);
}

JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SkeletalAnimation::Keyframe;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SkeletalAnimation_Keyframe*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SkeletalAnimation_Keyframe *)(new JPH::SkeletalAnimation::Keyframe[num_elems]);
}

const JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_OffsetPtr(const JPH_SkeletalAnimation_Keyframe *ptr, ptrdiff_t i)
{
    return (const JPH_SkeletalAnimation_Keyframe *)(((const JPH::SkeletalAnimation::Keyframe *)ptr) + i);
}

JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_OffsetMutablePtr(JPH_SkeletalAnimation_Keyframe *ptr, ptrdiff_t i)
{
    return (JPH_SkeletalAnimation_Keyframe *)(((JPH::SkeletalAnimation::Keyframe *)ptr) + i);
}

const JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_Keyframe_UpcastTo_JPH_SkeletalAnimation_JointState(const JPH_SkeletalAnimation_Keyframe *object)
{
    return (const JPH_SkeletalAnimation_JointState *)(static_cast<const JPH::SkeletalAnimation::JointState *>(
        ((const JPH::SkeletalAnimation::Keyframe *)object)
    ));
}

JPH_SkeletalAnimation_JointState *JPH_SkeletalAnimation_Keyframe_MutableUpcastTo_JPH_SkeletalAnimation_JointState(JPH_SkeletalAnimation_Keyframe *object)
{
    return (JPH_SkeletalAnimation_JointState *)(static_cast<JPH::SkeletalAnimation::JointState *>(
        ((JPH::SkeletalAnimation::Keyframe *)object)
    ));
}

const JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_StaticDowncastFrom_JPH_SkeletalAnimation_JointState(const JPH_SkeletalAnimation_JointState *object)
{
    return (const JPH_SkeletalAnimation_Keyframe *)(static_cast<const JPH::SkeletalAnimation::Keyframe *>(
        ((const JPH::SkeletalAnimation::JointState *)object)
    ));
}

JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_MutableStaticDowncastFrom_JPH_SkeletalAnimation_JointState(JPH_SkeletalAnimation_JointState *object)
{
    return (JPH_SkeletalAnimation_Keyframe *)(static_cast<JPH::SkeletalAnimation::Keyframe *>(
        ((JPH::SkeletalAnimation::JointState *)object)
    ));
}

JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_ConstructFromAnother(const JPH_SkeletalAnimation_Keyframe *_other)
{
    return (JPH_SkeletalAnimation_Keyframe *)new JPH::SkeletalAnimation::Keyframe(JPH::SkeletalAnimation::Keyframe(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SkeletalAnimation::Keyframe(*(JPH::SkeletalAnimation::Keyframe *)_other))
    ));
}

void JPH_SkeletalAnimation_Keyframe_Destroy(const JPH_SkeletalAnimation_Keyframe *_this)
{
    delete ((const JPH::SkeletalAnimation::Keyframe *)_this);
}

void JPH_SkeletalAnimation_Keyframe_DestroyArray(const JPH_SkeletalAnimation_Keyframe *_this)
{
    delete[] ((const JPH::SkeletalAnimation::Keyframe *)_this);
}

JPH_SkeletalAnimation_Keyframe *JPH_SkeletalAnimation_Keyframe_AssignFromAnother(JPH_SkeletalAnimation_Keyframe *_this, const JPH_SkeletalAnimation_Keyframe *_other)
{
    return (JPH_SkeletalAnimation_Keyframe *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletalAnimation::Keyframe *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SkeletalAnimation::Keyframe(*(JPH::SkeletalAnimation::Keyframe *)_other))
    ));
}

void *Jolt_new_JPH_SkeletalAnimation_Keyframe_size_t(size_t inCount)
{
    return JPH::SkeletalAnimation::Keyframe::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr(void *inPointer)
{
    JPH::SkeletalAnimation::Keyframe::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SkeletalAnimation::Keyframe::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SkeletalAnimation_Keyframe_size_t(size_t inCount)
{
    return JPH::SkeletalAnimation::Keyframe::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr(void *inPointer)
{
    JPH::SkeletalAnimation::Keyframe::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SkeletalAnimation::Keyframe::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SkeletalAnimation_Keyframe_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SkeletalAnimation::Keyframe::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SkeletalAnimation_Keyframe_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SkeletalAnimation::Keyframe::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SkeletalAnimation_Keyframe_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SkeletalAnimation::Keyframe::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SkeletalAnimation_Keyframe_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SkeletalAnimation::Keyframe::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_SkeletalAnimation_Keyframe_FromMatrix(JPH_SkeletalAnimation_Keyframe *_this, const JPH_Mat44 *inMatrix)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletalAnimation::Keyframe *)(_this)).FromMatrix(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix))
    );
}

JPH_Mat44 *JPH_SkeletalAnimation_Keyframe_ToMatrix(const JPH_SkeletalAnimation_Keyframe *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletalAnimation::Keyframe *)(_this)).ToMatrix());
}

JPH_SkeletalAnimation_AnimatedJoint *JPH_SkeletalAnimation_AnimatedJoint_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SkeletalAnimation::AnimatedJoint;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SkeletalAnimation_AnimatedJoint*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SkeletalAnimation_AnimatedJoint *JPH_SkeletalAnimation_AnimatedJoint_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SkeletalAnimation_AnimatedJoint *)(new JPH::SkeletalAnimation::AnimatedJoint[num_elems]);
}

const JPH_SkeletalAnimation_AnimatedJoint *JPH_SkeletalAnimation_AnimatedJoint_OffsetPtr(const JPH_SkeletalAnimation_AnimatedJoint *ptr, ptrdiff_t i)
{
    return (const JPH_SkeletalAnimation_AnimatedJoint *)(((const JPH::SkeletalAnimation::AnimatedJoint *)ptr) + i);
}

JPH_SkeletalAnimation_AnimatedJoint *JPH_SkeletalAnimation_AnimatedJoint_OffsetMutablePtr(JPH_SkeletalAnimation_AnimatedJoint *ptr, ptrdiff_t i)
{
    return (JPH_SkeletalAnimation_AnimatedJoint *)(((JPH::SkeletalAnimation::AnimatedJoint *)ptr) + i);
}

JPH_SkeletalAnimation_AnimatedJoint *JPH_SkeletalAnimation_AnimatedJoint_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SkeletalAnimation_AnimatedJoint *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SkeletalAnimation::AnimatedJoint);
    return (JPH_SkeletalAnimation_AnimatedJoint *)new JPH::SkeletalAnimation::AnimatedJoint(JPH::SkeletalAnimation::AnimatedJoint(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_COPY(_other, (JPH::SkeletalAnimation::AnimatedJoint), JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_MOVE(_other, (JPH::SkeletalAnimation::AnimatedJoint), JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_END(_other, JPH::SkeletalAnimation::AnimatedJoint))
    ));
}

void JPH_SkeletalAnimation_AnimatedJoint_Destroy(const JPH_SkeletalAnimation_AnimatedJoint *_this)
{
    delete ((const JPH::SkeletalAnimation::AnimatedJoint *)_this);
}

void JPH_SkeletalAnimation_AnimatedJoint_DestroyArray(const JPH_SkeletalAnimation_AnimatedJoint *_this)
{
    delete[] ((const JPH::SkeletalAnimation::AnimatedJoint *)_this);
}

JPH_SkeletalAnimation_AnimatedJoint *JPH_SkeletalAnimation_AnimatedJoint_AssignFromAnother(JPH_SkeletalAnimation_AnimatedJoint *_this, Jolt_PassBy _other_pass_by, JPH_SkeletalAnimation_AnimatedJoint *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SkeletalAnimation::AnimatedJoint);
    return (JPH_SkeletalAnimation_AnimatedJoint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletalAnimation::AnimatedJoint *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_COPY(_other, (JPH::SkeletalAnimation::AnimatedJoint), JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_MOVE(_other, (JPH::SkeletalAnimation::AnimatedJoint), JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SkeletalAnimation::AnimatedJoint) MRBINDC_CLASSARG_END(_other, JPH::SkeletalAnimation::AnimatedJoint))
    ));
}

void *Jolt_new_JPH_SkeletalAnimation_AnimatedJoint_size_t(size_t inCount)
{
    return JPH::SkeletalAnimation::AnimatedJoint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr(void *inPointer)
{
    JPH::SkeletalAnimation::AnimatedJoint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SkeletalAnimation::AnimatedJoint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SkeletalAnimation_AnimatedJoint_size_t(size_t inCount)
{
    return JPH::SkeletalAnimation::AnimatedJoint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr(void *inPointer)
{
    JPH::SkeletalAnimation::AnimatedJoint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SkeletalAnimation::AnimatedJoint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SkeletalAnimation_AnimatedJoint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SkeletalAnimation::AnimatedJoint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SkeletalAnimation::AnimatedJoint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SkeletalAnimation_AnimatedJoint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SkeletalAnimation::AnimatedJoint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SkeletalAnimation_AnimatedJoint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SkeletalAnimation::AnimatedJoint::operator delete[](
        inPointer,
        inPlace
    );
}

