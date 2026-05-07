// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Skeleton/Skeleton.h"

#include <Jolt/Core/Reference.h>
#include <Jolt/Skeleton/Skeleton.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


JPH_Skeleton *JPH_Skeleton_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Skeleton;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_Skeleton*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_Skeleton *JPH_Skeleton_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Skeleton *)(new JPH::Skeleton[num_elems]);
}

const JPH_Skeleton *JPH_Skeleton_OffsetPtr(const JPH_Skeleton *ptr, ptrdiff_t i)
{
    return (const JPH_Skeleton *)(((const JPH::Skeleton *)ptr) + i);
}

JPH_Skeleton *JPH_Skeleton_OffsetMutablePtr(JPH_Skeleton *ptr, ptrdiff_t i)
{
    return (JPH_Skeleton *)(((JPH::Skeleton *)ptr) + i);
}

const JPH_RefTarget_JPH_Skeleton *JPH_Skeleton_UpcastTo_JPH_RefTarget_JPH_Skeleton(const JPH_Skeleton *object)
{
    return (const JPH_RefTarget_JPH_Skeleton *)(static_cast<const JPH::RefTarget<JPH::Skeleton> *>(
        ((const JPH::Skeleton *)object)
    ));
}

JPH_RefTarget_JPH_Skeleton *JPH_Skeleton_MutableUpcastTo_JPH_RefTarget_JPH_Skeleton(JPH_Skeleton *object)
{
    return (JPH_RefTarget_JPH_Skeleton *)(static_cast<JPH::RefTarget<JPH::Skeleton> *>(
        ((JPH::Skeleton *)object)
    ));
}

const JPH_Skeleton *JPH_Skeleton_StaticDowncastFrom_JPH_RefTarget_JPH_Skeleton(const JPH_RefTarget_JPH_Skeleton *object)
{
    return (const JPH_Skeleton *)(static_cast<const JPH::Skeleton *>(
        ((const JPH::RefTarget<JPH::Skeleton> *)object)
    ));
}

JPH_Skeleton *JPH_Skeleton_MutableStaticDowncastFrom_JPH_RefTarget_JPH_Skeleton(JPH_RefTarget_JPH_Skeleton *object)
{
    return (JPH_Skeleton *)(static_cast<JPH::Skeleton *>(
        ((JPH::RefTarget<JPH::Skeleton> *)object)
    ));
}

JPH_Skeleton *JPH_Skeleton_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_Skeleton *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::Skeleton);
    return (JPH_Skeleton *)new JPH::Skeleton(JPH::Skeleton(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::Skeleton) MRBINDC_CLASSARG_COPY(_other, (JPH::Skeleton), JPH::Skeleton) MRBINDC_CLASSARG_MOVE(_other, (JPH::Skeleton), JPH::Skeleton) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::Skeleton) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::Skeleton) MRBINDC_CLASSARG_END(_other, JPH::Skeleton))
    ));
}

void JPH_Skeleton_Destroy(const JPH_Skeleton *_this)
{
    delete ((const JPH::Skeleton *)_this);
}

void JPH_Skeleton_DestroyArray(const JPH_Skeleton *_this)
{
    delete[] ((const JPH::Skeleton *)_this);
}

JPH_Skeleton *JPH_Skeleton_AssignFromAnother(JPH_Skeleton *_this, Jolt_PassBy _other_pass_by, JPH_Skeleton *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::Skeleton);
    return (JPH_Skeleton *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Skeleton *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::Skeleton) MRBINDC_CLASSARG_COPY(_other, (JPH::Skeleton), JPH::Skeleton) MRBINDC_CLASSARG_MOVE(_other, (JPH::Skeleton), JPH::Skeleton) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::Skeleton) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::Skeleton) MRBINDC_CLASSARG_END(_other, JPH::Skeleton))
    ));
}

void *Jolt_new_JPH_Skeleton_size_t(size_t inCount)
{
    return JPH::Skeleton::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Skeleton_void_ptr(void *inPointer)
{
    JPH::Skeleton::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Skeleton_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Skeleton::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Skeleton_size_t(size_t inCount)
{
    return JPH::Skeleton::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Skeleton_void_ptr(void *inPointer)
{
    JPH::Skeleton::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Skeleton_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Skeleton::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Skeleton_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Skeleton::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Skeleton_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Skeleton::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Skeleton_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Skeleton::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Skeleton_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Skeleton::operator delete[](
        inPointer,
        inPlace
    );
}

const Jolt_JPH_Array_JPH_Skeleton_Joint *JPH_Skeleton_GetJoints(const JPH_Skeleton *_this)
{
    return (const Jolt_JPH_Array_JPH_Skeleton_Joint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Skeleton *)(_this)).GetJoints());
}

Jolt_JPH_Array_JPH_Skeleton_Joint *JPH_Skeleton_GetJoints_mut(JPH_Skeleton *_this)
{
    return (Jolt_JPH_Array_JPH_Skeleton_Joint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Skeleton *)(_this)).GetJoints());
}

int JPH_Skeleton_GetJointCount(const JPH_Skeleton *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Skeleton *)(_this)).GetJointCount();
}

const JPH_Skeleton_Joint *JPH_Skeleton_GetJoint(const JPH_Skeleton *_this, int inJoint)
{
    return (const JPH_Skeleton_Joint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Skeleton *)(_this)).GetJoint(
        inJoint
    ));
}

JPH_Skeleton_Joint *JPH_Skeleton_GetJoint_mut(JPH_Skeleton *_this, int inJoint)
{
    return (JPH_Skeleton_Joint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Skeleton *)(_this)).GetJoint(
        inJoint
    ));
}

void JPH_Skeleton_CalculateParentJointIndices(JPH_Skeleton *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Skeleton *)(_this)).CalculateParentJointIndices();
}

bool JPH_Skeleton_AreJointsCorrectlyOrdered(const JPH_Skeleton *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Skeleton *)(_this)).AreJointsCorrectlyOrdered();
}

void JPH_Skeleton_SetEmbedded(const JPH_Skeleton *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Skeleton *)(_this)).SetEmbedded();
}

unsigned int JPH_Skeleton_GetRefCount(const JPH_Skeleton *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Skeleton *)(_this)).GetRefCount();
}

void JPH_Skeleton_AddRef(const JPH_Skeleton *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Skeleton *)(_this)).AddRef();
}

void JPH_Skeleton_Release(const JPH_Skeleton *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Skeleton *)(_this)).Release();
}

int JPH_Skeleton_sInternalGetRefCountOffset(void)
{
    return JPH::Skeleton::sInternalGetRefCountOffset();
}

const int *JPH_Skeleton_Joint_Get_mParentJointIndex(const JPH_Skeleton_Joint *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Skeleton::Joint *)(_this)).mParentJointIndex);
}

void JPH_Skeleton_Joint_Set_mParentJointIndex(JPH_Skeleton_Joint *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Skeleton::Joint *)(_this)).mParentJointIndex = value;
}

int *JPH_Skeleton_Joint_GetMutable_mParentJointIndex(JPH_Skeleton_Joint *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Skeleton::Joint *)(_this)).mParentJointIndex);
}

JPH_Skeleton_Joint *JPH_Skeleton_Joint_DefaultConstruct(void)
{
    using _mrbind_T = JPH::Skeleton::Joint;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_Skeleton_Joint*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_Skeleton_Joint *JPH_Skeleton_Joint_DefaultConstructArray(size_t num_elems)
{
    return (JPH_Skeleton_Joint *)(new JPH::Skeleton::Joint[num_elems]);
}

const JPH_Skeleton_Joint *JPH_Skeleton_Joint_OffsetPtr(const JPH_Skeleton_Joint *ptr, ptrdiff_t i)
{
    return (const JPH_Skeleton_Joint *)(((const JPH::Skeleton::Joint *)ptr) + i);
}

JPH_Skeleton_Joint *JPH_Skeleton_Joint_OffsetMutablePtr(JPH_Skeleton_Joint *ptr, ptrdiff_t i)
{
    return (JPH_Skeleton_Joint *)(((JPH::Skeleton::Joint *)ptr) + i);
}

JPH_Skeleton_Joint *JPH_Skeleton_Joint_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_Skeleton_Joint *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::Skeleton::Joint);
    return (JPH_Skeleton_Joint *)new JPH::Skeleton::Joint(JPH::Skeleton::Joint(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::Skeleton::Joint) MRBINDC_CLASSARG_COPY(_other, (JPH::Skeleton::Joint), JPH::Skeleton::Joint) MRBINDC_CLASSARG_MOVE(_other, (JPH::Skeleton::Joint), JPH::Skeleton::Joint) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::Skeleton::Joint) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::Skeleton::Joint) MRBINDC_CLASSARG_END(_other, JPH::Skeleton::Joint))
    ));
}

void JPH_Skeleton_Joint_Destroy(const JPH_Skeleton_Joint *_this)
{
    delete ((const JPH::Skeleton::Joint *)_this);
}

void JPH_Skeleton_Joint_DestroyArray(const JPH_Skeleton_Joint *_this)
{
    delete[] ((const JPH::Skeleton::Joint *)_this);
}

JPH_Skeleton_Joint *JPH_Skeleton_Joint_AssignFromAnother(JPH_Skeleton_Joint *_this, Jolt_PassBy _other_pass_by, JPH_Skeleton_Joint *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::Skeleton::Joint);
    return (JPH_Skeleton_Joint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Skeleton::Joint *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::Skeleton::Joint) MRBINDC_CLASSARG_COPY(_other, (JPH::Skeleton::Joint), JPH::Skeleton::Joint) MRBINDC_CLASSARG_MOVE(_other, (JPH::Skeleton::Joint), JPH::Skeleton::Joint) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::Skeleton::Joint) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::Skeleton::Joint) MRBINDC_CLASSARG_END(_other, JPH::Skeleton::Joint))
    ));
}

void *Jolt_new_JPH_Skeleton_Joint_size_t(size_t inCount)
{
    return JPH::Skeleton::Joint::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Skeleton_Joint_void_ptr(void *inPointer)
{
    JPH::Skeleton::Joint::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Skeleton_Joint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Skeleton::Joint::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Skeleton_Joint_size_t(size_t inCount)
{
    return JPH::Skeleton::Joint::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Skeleton_Joint_void_ptr(void *inPointer)
{
    JPH::Skeleton::Joint::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Skeleton_Joint_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::Skeleton::Joint::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Skeleton_Joint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Skeleton::Joint::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Skeleton_Joint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Skeleton::Joint::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Skeleton_Joint_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::Skeleton::Joint::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Skeleton_Joint_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Skeleton::Joint::operator delete[](
        inPointer,
        inPlace
    );
}

