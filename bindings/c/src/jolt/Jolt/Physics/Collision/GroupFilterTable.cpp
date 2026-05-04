// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/GroupFilterTable.h"

#include <Jolt/Core/Reference.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Collision/CollisionGroup.h>
#include <Jolt/Physics/Collision/GroupFilter.h>
#include <Jolt/Physics/Collision/GroupFilterTable.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


JPH_GroupFilterTable *JPH_GroupFilterTable_Construct(const unsigned int *inNumSubGroups)
{
    using namespace JPH;
    return (JPH_GroupFilterTable *)new JPH::GroupFilterTable(JPH::GroupFilterTable(
        (inNumSubGroups ? *inNumSubGroups : static_cast<unsigned int>(0))
    ));
}

JPH_GroupFilterTable *JPH_GroupFilterTable_DefaultConstructArray(size_t num_elems)
{
    return (JPH_GroupFilterTable *)(new JPH::GroupFilterTable[num_elems]);
}

const JPH_GroupFilterTable *JPH_GroupFilterTable_OffsetPtr(const JPH_GroupFilterTable *ptr, ptrdiff_t i)
{
    return (const JPH_GroupFilterTable *)(((const JPH::GroupFilterTable *)ptr) + i);
}

JPH_GroupFilterTable *JPH_GroupFilterTable_OffsetMutablePtr(JPH_GroupFilterTable *ptr, ptrdiff_t i)
{
    return (JPH_GroupFilterTable *)(((JPH::GroupFilterTable *)ptr) + i);
}

const JPH_SerializableObject *JPH_GroupFilterTable_UpcastTo_JPH_SerializableObject(const JPH_GroupFilterTable *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::GroupFilterTable *)object)
    ));
}

JPH_SerializableObject *JPH_GroupFilterTable_MutableUpcastTo_JPH_SerializableObject(JPH_GroupFilterTable *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::GroupFilterTable *)object)
    ));
}

const JPH_GroupFilterTable *JPH_GroupFilterTable_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_GroupFilterTable *)(static_cast<const JPH::GroupFilterTable *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_GroupFilterTable *JPH_GroupFilterTable_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_GroupFilterTable *)(static_cast<JPH::GroupFilterTable *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_GroupFilter *JPH_GroupFilterTable_UpcastTo_JPH_RefTarget_JPH_GroupFilter(const JPH_GroupFilterTable *object)
{
    return (const JPH_RefTarget_JPH_GroupFilter *)(static_cast<const JPH::RefTarget<JPH::GroupFilter> *>(
        ((const JPH::GroupFilterTable *)object)
    ));
}

JPH_RefTarget_JPH_GroupFilter *JPH_GroupFilterTable_MutableUpcastTo_JPH_RefTarget_JPH_GroupFilter(JPH_GroupFilterTable *object)
{
    return (JPH_RefTarget_JPH_GroupFilter *)(static_cast<JPH::RefTarget<JPH::GroupFilter> *>(
        ((JPH::GroupFilterTable *)object)
    ));
}

const JPH_GroupFilterTable *JPH_GroupFilterTable_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(const JPH_RefTarget_JPH_GroupFilter *object)
{
    return (const JPH_GroupFilterTable *)(static_cast<const JPH::GroupFilterTable *>(
        ((const JPH::RefTarget<JPH::GroupFilter> *)object)
    ));
}

JPH_GroupFilterTable *JPH_GroupFilterTable_MutableStaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(JPH_RefTarget_JPH_GroupFilter *object)
{
    return (JPH_GroupFilterTable *)(static_cast<JPH::GroupFilterTable *>(
        ((JPH::RefTarget<JPH::GroupFilter> *)object)
    ));
}

const JPH_GroupFilter *JPH_GroupFilterTable_UpcastTo_JPH_GroupFilter(const JPH_GroupFilterTable *object)
{
    return (const JPH_GroupFilter *)(static_cast<const JPH::GroupFilter *>(
        ((const JPH::GroupFilterTable *)object)
    ));
}

JPH_GroupFilter *JPH_GroupFilterTable_MutableUpcastTo_JPH_GroupFilter(JPH_GroupFilterTable *object)
{
    return (JPH_GroupFilter *)(static_cast<JPH::GroupFilter *>(
        ((JPH::GroupFilterTable *)object)
    ));
}

const JPH_GroupFilterTable *JPH_GroupFilterTable_StaticDowncastFrom_JPH_GroupFilter(const JPH_GroupFilter *object)
{
    return (const JPH_GroupFilterTable *)(static_cast<const JPH::GroupFilterTable *>(
        ((const JPH::GroupFilter *)object)
    ));
}

JPH_GroupFilterTable *JPH_GroupFilterTable_MutableStaticDowncastFrom_JPH_GroupFilter(JPH_GroupFilter *object)
{
    return (JPH_GroupFilterTable *)(static_cast<JPH::GroupFilterTable *>(
        ((JPH::GroupFilter *)object)
    ));
}

JPH_GroupFilterTable *JPH_GroupFilterTable_ConstructFromAnother(Jolt_PassBy inRHS_pass_by, JPH_GroupFilterTable *inRHS)
{
    MRBINDC_CLASSARG_GUARD(inRHS, JPH::GroupFilterTable);
    return (JPH_GroupFilterTable *)new JPH::GroupFilterTable(JPH::GroupFilterTable(
        (MRBINDC_CLASSARG_DEF_CTOR(inRHS, JPH::GroupFilterTable) MRBINDC_CLASSARG_COPY(inRHS, (JPH::GroupFilterTable), JPH::GroupFilterTable) MRBINDC_CLASSARG_NO_DEF_ARG(inRHS, Jolt_PassBy_DefaultArgument, JPH::GroupFilterTable) MRBINDC_CLASSARG_NO_DEF_ARG(inRHS, Jolt_PassBy_NoObject, JPH::GroupFilterTable) MRBINDC_CLASSARG_END(inRHS, JPH::GroupFilterTable))
    ));
}

void JPH_GroupFilterTable_Destroy(const JPH_GroupFilterTable *_this)
{
    delete ((const JPH::GroupFilterTable *)_this);
}

void JPH_GroupFilterTable_DestroyArray(const JPH_GroupFilterTable *_this)
{
    delete[] ((const JPH::GroupFilterTable *)_this);
}

JPH_GroupFilterTable *JPH_GroupFilterTable_AssignFromAnother(JPH_GroupFilterTable *_this, Jolt_PassBy _other_pass_by, JPH_GroupFilterTable *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::GroupFilterTable);
    return (JPH_GroupFilterTable *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::GroupFilterTable *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::GroupFilterTable) MRBINDC_CLASSARG_COPY(_other, (JPH::GroupFilterTable), JPH::GroupFilterTable) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::GroupFilterTable) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::GroupFilterTable) MRBINDC_CLASSARG_END(_other, JPH::GroupFilterTable)))
    ));
}

void *Jolt_new_JPH_GroupFilterTable_size_t(size_t inCount)
{
    return JPH::GroupFilterTable::operator new(
        inCount
    );
}

void Jolt_delete_JPH_GroupFilterTable_void_ptr(void *inPointer)
{
    JPH::GroupFilterTable::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_GroupFilterTable_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::GroupFilterTable::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_GroupFilterTable_size_t(size_t inCount)
{
    return JPH::GroupFilterTable::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_GroupFilterTable_void_ptr(void *inPointer)
{
    JPH::GroupFilterTable::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_GroupFilterTable_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::GroupFilterTable::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_GroupFilterTable_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::GroupFilterTable::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_GroupFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::GroupFilterTable::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_GroupFilterTable_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::GroupFilterTable::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_GroupFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::GroupFilterTable::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_GroupFilterTable_CanCollide(const JPH_GroupFilterTable *_this, const JPH_CollisionGroup *inGroup1, const JPH_CollisionGroup *inGroup2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GroupFilterTable *)(_this)).CanCollide(
        ((inGroup1 ? void() : MRBINDC_THROW("Parameter `inGroup1` can not be null.", void)), *(const JPH::CollisionGroup *)(inGroup1)),
        ((inGroup2 ? void() : MRBINDC_THROW("Parameter `inGroup2` can not be null.", void)), *(const JPH::CollisionGroup *)(inGroup2))
    );
}

void JPH_GroupFilterTable_SetEmbedded(const JPH_GroupFilterTable *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GroupFilterTable *)(_this)).SetEmbedded();
}

unsigned int JPH_GroupFilterTable_GetRefCount(const JPH_GroupFilterTable *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GroupFilterTable *)(_this)).GetRefCount();
}

void JPH_GroupFilterTable_AddRef(const JPH_GroupFilterTable *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GroupFilterTable *)(_this)).AddRef();
}

void JPH_GroupFilterTable_Release(const JPH_GroupFilterTable *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::GroupFilterTable *)(_this)).Release();
}

int JPH_GroupFilterTable_sInternalGetRefCountOffset(void)
{
    return JPH::GroupFilterTable::sInternalGetRefCountOffset();
}

