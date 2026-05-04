// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Skeleton/SkeletonMapper.h"

#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Skeleton/Skeleton.h>
#include <Jolt/Skeleton/SkeletonMapper.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


JPH_SkeletonMapper *JPH_SkeletonMapper_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SkeletonMapper;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SkeletonMapper*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SkeletonMapper *JPH_SkeletonMapper_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SkeletonMapper *)(new JPH::SkeletonMapper[num_elems]);
}

const JPH_SkeletonMapper *JPH_SkeletonMapper_OffsetPtr(const JPH_SkeletonMapper *ptr, ptrdiff_t i)
{
    return (const JPH_SkeletonMapper *)(((const JPH::SkeletonMapper *)ptr) + i);
}

JPH_SkeletonMapper *JPH_SkeletonMapper_OffsetMutablePtr(JPH_SkeletonMapper *ptr, ptrdiff_t i)
{
    return (JPH_SkeletonMapper *)(((JPH::SkeletonMapper *)ptr) + i);
}

const JPH_RefTarget_JPH_SkeletonMapper *JPH_SkeletonMapper_UpcastTo_JPH_RefTarget_JPH_SkeletonMapper(const JPH_SkeletonMapper *object)
{
    return (const JPH_RefTarget_JPH_SkeletonMapper *)(static_cast<const JPH::RefTarget<JPH::SkeletonMapper> *>(
        ((const JPH::SkeletonMapper *)object)
    ));
}

JPH_RefTarget_JPH_SkeletonMapper *JPH_SkeletonMapper_MutableUpcastTo_JPH_RefTarget_JPH_SkeletonMapper(JPH_SkeletonMapper *object)
{
    return (JPH_RefTarget_JPH_SkeletonMapper *)(static_cast<JPH::RefTarget<JPH::SkeletonMapper> *>(
        ((JPH::SkeletonMapper *)object)
    ));
}

const JPH_SkeletonMapper *JPH_SkeletonMapper_StaticDowncastFrom_JPH_RefTarget_JPH_SkeletonMapper(const JPH_RefTarget_JPH_SkeletonMapper *object)
{
    return (const JPH_SkeletonMapper *)(static_cast<const JPH::SkeletonMapper *>(
        ((const JPH::RefTarget<JPH::SkeletonMapper> *)object)
    ));
}

JPH_SkeletonMapper *JPH_SkeletonMapper_MutableStaticDowncastFrom_JPH_RefTarget_JPH_SkeletonMapper(JPH_RefTarget_JPH_SkeletonMapper *object)
{
    return (JPH_SkeletonMapper *)(static_cast<JPH::SkeletonMapper *>(
        ((JPH::RefTarget<JPH::SkeletonMapper> *)object)
    ));
}

JPH_SkeletonMapper *JPH_SkeletonMapper_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SkeletonMapper *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SkeletonMapper);
    return (JPH_SkeletonMapper *)new JPH::SkeletonMapper(JPH::SkeletonMapper(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SkeletonMapper) MRBINDC_CLASSARG_COPY(_other, (JPH::SkeletonMapper), JPH::SkeletonMapper) MRBINDC_CLASSARG_MOVE(_other, (JPH::SkeletonMapper), JPH::SkeletonMapper) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SkeletonMapper) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SkeletonMapper) MRBINDC_CLASSARG_END(_other, JPH::SkeletonMapper))
    ));
}

void JPH_SkeletonMapper_Destroy(const JPH_SkeletonMapper *_this)
{
    delete ((const JPH::SkeletonMapper *)_this);
}

void JPH_SkeletonMapper_DestroyArray(const JPH_SkeletonMapper *_this)
{
    delete[] ((const JPH::SkeletonMapper *)_this);
}

JPH_SkeletonMapper *JPH_SkeletonMapper_AssignFromAnother(JPH_SkeletonMapper *_this, Jolt_PassBy _other_pass_by, JPH_SkeletonMapper *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SkeletonMapper);
    return (JPH_SkeletonMapper *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SkeletonMapper) MRBINDC_CLASSARG_COPY(_other, (JPH::SkeletonMapper), JPH::SkeletonMapper) MRBINDC_CLASSARG_MOVE(_other, (JPH::SkeletonMapper), JPH::SkeletonMapper) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SkeletonMapper) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SkeletonMapper) MRBINDC_CLASSARG_END(_other, JPH::SkeletonMapper))
    ));
}

bool JPH_SkeletonMapper_sDefaultCanMapJoint(const JPH_Skeleton *inSkeleton1, int inIndex1, const JPH_Skeleton *inSkeleton2, int inIndex2)
{
    return JPH::SkeletonMapper::sDefaultCanMapJoint(
        ((const JPH::Skeleton *)inSkeleton1),
        inIndex1,
        ((const JPH::Skeleton *)inSkeleton2),
        inIndex2
    );
}

void JPH_SkeletonMapper_LockTranslations(JPH_SkeletonMapper *_this, const JPH_Skeleton *inSkeleton2, const bool *inLockedTranslations, const JPH_Mat44 *inNeutralPose2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper *)(_this)).LockTranslations(
        ((const JPH::Skeleton *)inSkeleton2),
        inLockedTranslations,
        ((const JPH::Mat44 *)inNeutralPose2)
    );
}

void JPH_SkeletonMapper_LockAllTranslations(JPH_SkeletonMapper *_this, const JPH_Skeleton *inSkeleton2, const JPH_Mat44 *inNeutralPose2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper *)(_this)).LockAllTranslations(
        ((const JPH::Skeleton *)inSkeleton2),
        ((const JPH::Mat44 *)inNeutralPose2)
    );
}

void JPH_SkeletonMapper_Map(const JPH_SkeletonMapper *_this, const JPH_Mat44 *inPose1ModelSpace, const JPH_Mat44 *inPose2LocalSpace, JPH_Mat44 *outPose2ModelSpace)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper *)(_this)).Map(
        ((const JPH::Mat44 *)inPose1ModelSpace),
        ((const JPH::Mat44 *)inPose2LocalSpace),
        ((JPH::Mat44 *)outPose2ModelSpace)
    );
}

void JPH_SkeletonMapper_MapReverse(const JPH_SkeletonMapper *_this, const JPH_Mat44 *inPose2ModelSpace, JPH_Mat44 *outPose1ModelSpace)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper *)(_this)).MapReverse(
        ((const JPH::Mat44 *)inPose2ModelSpace),
        ((JPH::Mat44 *)outPose1ModelSpace)
    );
}

int JPH_SkeletonMapper_GetMappedJointIdx(const JPH_SkeletonMapper *_this, int inJoint1Idx)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper *)(_this)).GetMappedJointIdx(
        inJoint1Idx
    );
}

bool JPH_SkeletonMapper_IsJointTranslationLocked(const JPH_SkeletonMapper *_this, int inJoint2Idx)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper *)(_this)).IsJointTranslationLocked(
        inJoint2Idx
    );
}

void JPH_SkeletonMapper_SetEmbedded(const JPH_SkeletonMapper *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper *)(_this)).SetEmbedded();
}

unsigned int JPH_SkeletonMapper_GetRefCount(const JPH_SkeletonMapper *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper *)(_this)).GetRefCount();
}

void JPH_SkeletonMapper_AddRef(const JPH_SkeletonMapper *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper *)(_this)).AddRef();
}

void JPH_SkeletonMapper_Release(const JPH_SkeletonMapper *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper *)(_this)).Release();
}

int JPH_SkeletonMapper_sInternalGetRefCountOffset(void)
{
    return JPH::SkeletonMapper::sInternalGetRefCountOffset();
}

const int *JPH_SkeletonMapper_Mapping_Get_mJointIdx1(const JPH_SkeletonMapper_Mapping *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper::Mapping *)(_this)).mJointIdx1);
}

void JPH_SkeletonMapper_Mapping_Set_mJointIdx1(JPH_SkeletonMapper_Mapping *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Mapping *)(_this)).mJointIdx1 = value;
}

int *JPH_SkeletonMapper_Mapping_GetMutable_mJointIdx1(JPH_SkeletonMapper_Mapping *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Mapping *)(_this)).mJointIdx1);
}

const int *JPH_SkeletonMapper_Mapping_Get_mJointIdx2(const JPH_SkeletonMapper_Mapping *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper::Mapping *)(_this)).mJointIdx2);
}

void JPH_SkeletonMapper_Mapping_Set_mJointIdx2(JPH_SkeletonMapper_Mapping *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Mapping *)(_this)).mJointIdx2 = value;
}

int *JPH_SkeletonMapper_Mapping_GetMutable_mJointIdx2(JPH_SkeletonMapper_Mapping *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Mapping *)(_this)).mJointIdx2);
}

const JPH_Mat44 *JPH_SkeletonMapper_Mapping_Get_mJoint1To2(const JPH_SkeletonMapper_Mapping *_this)
{
    return (const JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper::Mapping *)(_this)).mJoint1To2);
}

JPH_Mat44 *JPH_SkeletonMapper_Mapping_GetMutable_mJoint1To2(JPH_SkeletonMapper_Mapping *_this)
{
    return (JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Mapping *)(_this)).mJoint1To2);
}

const JPH_Mat44 *JPH_SkeletonMapper_Mapping_Get_mJoint2To1(const JPH_SkeletonMapper_Mapping *_this)
{
    return (const JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper::Mapping *)(_this)).mJoint2To1);
}

JPH_Mat44 *JPH_SkeletonMapper_Mapping_GetMutable_mJoint2To1(JPH_SkeletonMapper_Mapping *_this)
{
    return (JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Mapping *)(_this)).mJoint2To1);
}

JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_Mapping_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SkeletonMapper::Mapping;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SkeletonMapper_Mapping*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_Mapping_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SkeletonMapper_Mapping *)(new JPH::SkeletonMapper::Mapping[num_elems]);
}

const JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_Mapping_OffsetPtr(const JPH_SkeletonMapper_Mapping *ptr, ptrdiff_t i)
{
    return (const JPH_SkeletonMapper_Mapping *)(((const JPH::SkeletonMapper::Mapping *)ptr) + i);
}

JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_Mapping_OffsetMutablePtr(JPH_SkeletonMapper_Mapping *ptr, ptrdiff_t i)
{
    return (JPH_SkeletonMapper_Mapping *)(((JPH::SkeletonMapper::Mapping *)ptr) + i);
}

JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_Mapping_ConstructFromAnother(const JPH_SkeletonMapper_Mapping *_other)
{
    return (JPH_SkeletonMapper_Mapping *)new JPH::SkeletonMapper::Mapping(JPH::SkeletonMapper::Mapping(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SkeletonMapper::Mapping(*(JPH::SkeletonMapper::Mapping *)_other))
    ));
}

JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_Mapping_Construct(int inJointIdx1, int inJointIdx2, const JPH_Mat44 *inJoint1To2)
{
    return (JPH_SkeletonMapper_Mapping *)new JPH::SkeletonMapper::Mapping(JPH::SkeletonMapper::Mapping(
        inJointIdx1,
        inJointIdx2,
        ((inJoint1To2 ? void() : MRBINDC_THROW("Parameter `inJoint1To2` can not be null.", void)), *(const JPH::Mat44 *)(inJoint1To2))
    ));
}

void JPH_SkeletonMapper_Mapping_Destroy(const JPH_SkeletonMapper_Mapping *_this)
{
    delete ((const JPH::SkeletonMapper::Mapping *)_this);
}

void JPH_SkeletonMapper_Mapping_DestroyArray(const JPH_SkeletonMapper_Mapping *_this)
{
    delete[] ((const JPH::SkeletonMapper::Mapping *)_this);
}

JPH_SkeletonMapper_Mapping *JPH_SkeletonMapper_Mapping_AssignFromAnother(JPH_SkeletonMapper_Mapping *_this, const JPH_SkeletonMapper_Mapping *_other)
{
    return (JPH_SkeletonMapper_Mapping *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Mapping *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SkeletonMapper::Mapping(*(JPH::SkeletonMapper::Mapping *)_other))
    ));
}

JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_Chain_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SkeletonMapper::Chain;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SkeletonMapper_Chain*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_Chain_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SkeletonMapper_Chain *)(new JPH::SkeletonMapper::Chain[num_elems]);
}

const JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_Chain_OffsetPtr(const JPH_SkeletonMapper_Chain *ptr, ptrdiff_t i)
{
    return (const JPH_SkeletonMapper_Chain *)(((const JPH::SkeletonMapper::Chain *)ptr) + i);
}

JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_Chain_OffsetMutablePtr(JPH_SkeletonMapper_Chain *ptr, ptrdiff_t i)
{
    return (JPH_SkeletonMapper_Chain *)(((JPH::SkeletonMapper::Chain *)ptr) + i);
}

JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_Chain_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SkeletonMapper_Chain *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SkeletonMapper::Chain);
    return (JPH_SkeletonMapper_Chain *)new JPH::SkeletonMapper::Chain(JPH::SkeletonMapper::Chain(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_COPY(_other, (JPH::SkeletonMapper::Chain), JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_MOVE(_other, (JPH::SkeletonMapper::Chain), JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_END(_other, JPH::SkeletonMapper::Chain))
    ));
}

void JPH_SkeletonMapper_Chain_Destroy(const JPH_SkeletonMapper_Chain *_this)
{
    delete ((const JPH::SkeletonMapper::Chain *)_this);
}

void JPH_SkeletonMapper_Chain_DestroyArray(const JPH_SkeletonMapper_Chain *_this)
{
    delete[] ((const JPH::SkeletonMapper::Chain *)_this);
}

JPH_SkeletonMapper_Chain *JPH_SkeletonMapper_Chain_AssignFromAnother(JPH_SkeletonMapper_Chain *_this, Jolt_PassBy _other_pass_by, JPH_SkeletonMapper_Chain *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SkeletonMapper::Chain);
    return (JPH_SkeletonMapper_Chain *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Chain *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_COPY(_other, (JPH::SkeletonMapper::Chain), JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_MOVE(_other, (JPH::SkeletonMapper::Chain), JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SkeletonMapper::Chain) MRBINDC_CLASSARG_END(_other, JPH::SkeletonMapper::Chain))
    ));
}

const int *JPH_SkeletonMapper_Unmapped_Get_mJointIdx(const JPH_SkeletonMapper_Unmapped *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper::Unmapped *)(_this)).mJointIdx);
}

void JPH_SkeletonMapper_Unmapped_Set_mJointIdx(JPH_SkeletonMapper_Unmapped *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Unmapped *)(_this)).mJointIdx = value;
}

int *JPH_SkeletonMapper_Unmapped_GetMutable_mJointIdx(JPH_SkeletonMapper_Unmapped *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Unmapped *)(_this)).mJointIdx);
}

const int *JPH_SkeletonMapper_Unmapped_Get_mParentJointIdx(const JPH_SkeletonMapper_Unmapped *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper::Unmapped *)(_this)).mParentJointIdx);
}

void JPH_SkeletonMapper_Unmapped_Set_mParentJointIdx(JPH_SkeletonMapper_Unmapped *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Unmapped *)(_this)).mParentJointIdx = value;
}

int *JPH_SkeletonMapper_Unmapped_GetMutable_mParentJointIdx(JPH_SkeletonMapper_Unmapped *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Unmapped *)(_this)).mParentJointIdx);
}

JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_Unmapped_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SkeletonMapper::Unmapped;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SkeletonMapper_Unmapped*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_Unmapped_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SkeletonMapper_Unmapped *)(new JPH::SkeletonMapper::Unmapped[num_elems]);
}

const JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_Unmapped_OffsetPtr(const JPH_SkeletonMapper_Unmapped *ptr, ptrdiff_t i)
{
    return (const JPH_SkeletonMapper_Unmapped *)(((const JPH::SkeletonMapper::Unmapped *)ptr) + i);
}

JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_Unmapped_OffsetMutablePtr(JPH_SkeletonMapper_Unmapped *ptr, ptrdiff_t i)
{
    return (JPH_SkeletonMapper_Unmapped *)(((JPH::SkeletonMapper::Unmapped *)ptr) + i);
}

JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_Unmapped_ConstructFromAnother(const JPH_SkeletonMapper_Unmapped *_other)
{
    return (JPH_SkeletonMapper_Unmapped *)new JPH::SkeletonMapper::Unmapped(JPH::SkeletonMapper::Unmapped(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SkeletonMapper::Unmapped(*(JPH::SkeletonMapper::Unmapped *)_other))
    ));
}

JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_Unmapped_Construct(int inJointIdx, int inParentJointIdx)
{
    return (JPH_SkeletonMapper_Unmapped *)new JPH::SkeletonMapper::Unmapped(JPH::SkeletonMapper::Unmapped(
        inJointIdx,
        inParentJointIdx
    ));
}

void JPH_SkeletonMapper_Unmapped_Destroy(const JPH_SkeletonMapper_Unmapped *_this)
{
    delete ((const JPH::SkeletonMapper::Unmapped *)_this);
}

void JPH_SkeletonMapper_Unmapped_DestroyArray(const JPH_SkeletonMapper_Unmapped *_this)
{
    delete[] ((const JPH::SkeletonMapper::Unmapped *)_this);
}

JPH_SkeletonMapper_Unmapped *JPH_SkeletonMapper_Unmapped_AssignFromAnother(JPH_SkeletonMapper_Unmapped *_this, const JPH_SkeletonMapper_Unmapped *_other)
{
    return (JPH_SkeletonMapper_Unmapped *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Unmapped *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SkeletonMapper::Unmapped(*(JPH::SkeletonMapper::Unmapped *)_other))
    ));
}

const int *JPH_SkeletonMapper_Locked_Get_mJointIdx(const JPH_SkeletonMapper_Locked *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper::Locked *)(_this)).mJointIdx);
}

void JPH_SkeletonMapper_Locked_Set_mJointIdx(JPH_SkeletonMapper_Locked *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Locked *)(_this)).mJointIdx = value;
}

int *JPH_SkeletonMapper_Locked_GetMutable_mJointIdx(JPH_SkeletonMapper_Locked *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Locked *)(_this)).mJointIdx);
}

const int *JPH_SkeletonMapper_Locked_Get_mParentJointIdx(const JPH_SkeletonMapper_Locked *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper::Locked *)(_this)).mParentJointIdx);
}

void JPH_SkeletonMapper_Locked_Set_mParentJointIdx(JPH_SkeletonMapper_Locked *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Locked *)(_this)).mParentJointIdx = value;
}

int *JPH_SkeletonMapper_Locked_GetMutable_mParentJointIdx(JPH_SkeletonMapper_Locked *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Locked *)(_this)).mParentJointIdx);
}

const JPH_Vec3 *JPH_SkeletonMapper_Locked_Get_mTranslation(const JPH_SkeletonMapper_Locked *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SkeletonMapper::Locked *)(_this)).mTranslation);
}

JPH_Vec3 *JPH_SkeletonMapper_Locked_GetMutable_mTranslation(JPH_SkeletonMapper_Locked *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Locked *)(_this)).mTranslation);
}

JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_Locked_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SkeletonMapper::Locked;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SkeletonMapper_Locked*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_Locked_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SkeletonMapper_Locked *)(new JPH::SkeletonMapper::Locked[num_elems]);
}

JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_Locked_ConstructFrom(int mJointIdx, int mParentJointIdx, const JPH_Vec3 *mTranslation)
{
    return (JPH_SkeletonMapper_Locked *)new JPH::SkeletonMapper::Locked(JPH::SkeletonMapper::Locked{
        mJointIdx,
        mParentJointIdx,
        ((mTranslation ? void() : MRBINDC_THROW("Parameter `mTranslation` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mTranslation))
    });
}

const JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_Locked_OffsetPtr(const JPH_SkeletonMapper_Locked *ptr, ptrdiff_t i)
{
    return (const JPH_SkeletonMapper_Locked *)(((const JPH::SkeletonMapper::Locked *)ptr) + i);
}

JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_Locked_OffsetMutablePtr(JPH_SkeletonMapper_Locked *ptr, ptrdiff_t i)
{
    return (JPH_SkeletonMapper_Locked *)(((JPH::SkeletonMapper::Locked *)ptr) + i);
}

JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_Locked_ConstructFromAnother(const JPH_SkeletonMapper_Locked *_other)
{
    return (JPH_SkeletonMapper_Locked *)new JPH::SkeletonMapper::Locked(JPH::SkeletonMapper::Locked(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SkeletonMapper::Locked(*(JPH::SkeletonMapper::Locked *)_other))
    ));
}

void JPH_SkeletonMapper_Locked_Destroy(const JPH_SkeletonMapper_Locked *_this)
{
    delete ((const JPH::SkeletonMapper::Locked *)_this);
}

void JPH_SkeletonMapper_Locked_DestroyArray(const JPH_SkeletonMapper_Locked *_this)
{
    delete[] ((const JPH::SkeletonMapper::Locked *)_this);
}

JPH_SkeletonMapper_Locked *JPH_SkeletonMapper_Locked_AssignFromAnother(JPH_SkeletonMapper_Locked *_this, const JPH_SkeletonMapper_Locked *_other)
{
    return (JPH_SkeletonMapper_Locked *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SkeletonMapper::Locked *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SkeletonMapper::Locked(*(JPH::SkeletonMapper::Locked *)_other))
    ));
}

