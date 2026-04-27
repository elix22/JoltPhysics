// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/CollisionGroup.h"

#include <Jolt/Physics/Collision/CollisionGroup.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


const unsigned int *JPH_CollisionGroup_Get_cInvalidGroup(void)
{
    return std::addressof(JPH::CollisionGroup::cInvalidGroup);
}

const unsigned int *JPH_CollisionGroup_Get_cInvalidSubGroup(void)
{
    return std::addressof(JPH::CollisionGroup::cInvalidSubGroup);
}

const JPH_CollisionGroup *JPH_CollisionGroup_Get_sInvalid(void)
{
    return (const JPH_CollisionGroup *)std::addressof(JPH::CollisionGroup::sInvalid);
}

JPH_CollisionGroup *JPH_CollisionGroup_DefaultConstruct(void)
{
    return (JPH_CollisionGroup *)new JPH::CollisionGroup(JPH::CollisionGroup());
}

JPH_CollisionGroup *JPH_CollisionGroup_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CollisionGroup *)(new JPH::CollisionGroup[num_elems]{});
}

const JPH_CollisionGroup *JPH_CollisionGroup_OffsetPtr(const JPH_CollisionGroup *ptr, ptrdiff_t i)
{
    return (const JPH_CollisionGroup *)(((const JPH::CollisionGroup *)ptr) + i);
}

JPH_CollisionGroup *JPH_CollisionGroup_OffsetMutablePtr(JPH_CollisionGroup *ptr, ptrdiff_t i)
{
    return (JPH_CollisionGroup *)(((JPH::CollisionGroup *)ptr) + i);
}

JPH_CollisionGroup *JPH_CollisionGroup_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CollisionGroup *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CollisionGroup);
    return (JPH_CollisionGroup *)new JPH::CollisionGroup(JPH::CollisionGroup(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CollisionGroup) MRBINDC_CLASSARG_COPY(_other, (JPH::CollisionGroup), JPH::CollisionGroup) MRBINDC_CLASSARG_MOVE(_other, (JPH::CollisionGroup), JPH::CollisionGroup) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CollisionGroup) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CollisionGroup) MRBINDC_CLASSARG_END(_other, JPH::CollisionGroup))
    ));
}

void JPH_CollisionGroup_Destroy(const JPH_CollisionGroup *_this)
{
    delete ((const JPH::CollisionGroup *)_this);
}

void JPH_CollisionGroup_DestroyArray(const JPH_CollisionGroup *_this)
{
    delete[] ((const JPH::CollisionGroup *)_this);
}

JPH_CollisionGroup *JPH_CollisionGroup_AssignFromAnother(JPH_CollisionGroup *_this, Jolt_PassBy _other_pass_by, JPH_CollisionGroup *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CollisionGroup);
    return (JPH_CollisionGroup *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollisionGroup *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CollisionGroup) MRBINDC_CLASSARG_COPY(_other, (JPH::CollisionGroup), JPH::CollisionGroup) MRBINDC_CLASSARG_MOVE(_other, (JPH::CollisionGroup), JPH::CollisionGroup) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CollisionGroup) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CollisionGroup) MRBINDC_CLASSARG_END(_other, JPH::CollisionGroup))
    ));
}

void *Jolt_new_JPH_CollisionGroup_size_t(unsigned long inCount)
{
    return JPH::CollisionGroup::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CollisionGroup_void_ptr(void *inPointer)
{
    JPH::CollisionGroup::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CollisionGroup_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::CollisionGroup::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CollisionGroup_size_t(unsigned long inCount)
{
    return JPH::CollisionGroup::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CollisionGroup_void_ptr(void *inPointer)
{
    JPH::CollisionGroup::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CollisionGroup_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::CollisionGroup::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CollisionGroup_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::CollisionGroup::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CollisionGroup_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CollisionGroup::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CollisionGroup_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::CollisionGroup::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CollisionGroup_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CollisionGroup::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_CollisionGroup_SetGroupID(JPH_CollisionGroup *_this, unsigned int inID)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollisionGroup *)(_this)).SetGroupID(
        inID
    );
}

unsigned int JPH_CollisionGroup_GetGroupID(const JPH_CollisionGroup *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollisionGroup *)(_this)).GetGroupID();
}

void JPH_CollisionGroup_SetSubGroupID(JPH_CollisionGroup *_this, unsigned int inID)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollisionGroup *)(_this)).SetSubGroupID(
        inID
    );
}

unsigned int JPH_CollisionGroup_GetSubGroupID(const JPH_CollisionGroup *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollisionGroup *)(_this)).GetSubGroupID();
}

bool JPH_CollisionGroup_CanCollide(const JPH_CollisionGroup *_this, const JPH_CollisionGroup *inOther)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollisionGroup *)(_this)).CanCollide(
        ((inOther ? void() : MRBINDC_THROW("Parameter `inOther` can not be null.", void)), *(const JPH::CollisionGroup *)(inOther))
    );
}

