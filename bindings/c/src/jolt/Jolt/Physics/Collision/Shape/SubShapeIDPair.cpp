// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/Shape/SubShapeIDPair.h"

#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/Shape/SubShapeIDPair.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


JPH_SubShapeIDPair *JPH_SubShapeIDPair_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SubShapeIDPair;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SubShapeIDPair*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SubShapeIDPair *JPH_SubShapeIDPair_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SubShapeIDPair *)(new JPH::SubShapeIDPair[num_elems]);
}

const JPH_SubShapeIDPair *JPH_SubShapeIDPair_OffsetPtr(const JPH_SubShapeIDPair *ptr, ptrdiff_t i)
{
    return (const JPH_SubShapeIDPair *)(((const JPH::SubShapeIDPair *)ptr) + i);
}

JPH_SubShapeIDPair *JPH_SubShapeIDPair_OffsetMutablePtr(JPH_SubShapeIDPair *ptr, ptrdiff_t i)
{
    return (JPH_SubShapeIDPair *)(((JPH::SubShapeIDPair *)ptr) + i);
}

JPH_SubShapeIDPair *JPH_SubShapeIDPair_ConstructFromAnother(const JPH_SubShapeIDPair *_other)
{
    return (JPH_SubShapeIDPair *)new JPH::SubShapeIDPair(JPH::SubShapeIDPair(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SubShapeIDPair(*(JPH::SubShapeIDPair *)_other))
    ));
}

JPH_SubShapeIDPair *JPH_SubShapeIDPair_Construct(const JPH_BodyID *inBody1ID, const JPH_SubShapeID *inSubShapeID1, const JPH_BodyID *inBody2ID, const JPH_SubShapeID *inSubShapeID2)
{
    return (JPH_SubShapeIDPair *)new JPH::SubShapeIDPair(JPH::SubShapeIDPair(
        ((inBody1ID ? void() : MRBINDC_THROW("Parameter `inBody1ID` can not be null.", void)), *(const JPH::BodyID *)(inBody1ID)),
        ((inSubShapeID1 ? void() : MRBINDC_THROW("Parameter `inSubShapeID1` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID1)),
        ((inBody2ID ? void() : MRBINDC_THROW("Parameter `inBody2ID` can not be null.", void)), *(const JPH::BodyID *)(inBody2ID)),
        ((inSubShapeID2 ? void() : MRBINDC_THROW("Parameter `inSubShapeID2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID2))
    ));
}

void JPH_SubShapeIDPair_Destroy(const JPH_SubShapeIDPair *_this)
{
    delete ((const JPH::SubShapeIDPair *)_this);
}

void JPH_SubShapeIDPair_DestroyArray(const JPH_SubShapeIDPair *_this)
{
    delete[] ((const JPH::SubShapeIDPair *)_this);
}

JPH_SubShapeIDPair *JPH_SubShapeIDPair_AssignFromAnother(JPH_SubShapeIDPair *_this, const JPH_SubShapeIDPair *_other)
{
    return (JPH_SubShapeIDPair *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SubShapeIDPair *)(_this)).operator=(
        mrbindc_details::unmove(((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SubShapeIDPair(*(JPH::SubShapeIDPair *)_other)))
    ));
}

void *Jolt_new_JPH_SubShapeIDPair_size_t(size_t inCount)
{
    return JPH::SubShapeIDPair::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SubShapeIDPair_void_ptr(void *inPointer)
{
    JPH::SubShapeIDPair::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SubShapeIDPair_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SubShapeIDPair::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SubShapeIDPair_size_t(size_t inCount)
{
    return JPH::SubShapeIDPair::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SubShapeIDPair_void_ptr(void *inPointer)
{
    JPH::SubShapeIDPair::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SubShapeIDPair_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::SubShapeIDPair::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SubShapeIDPair_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SubShapeIDPair::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SubShapeIDPair_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SubShapeIDPair::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SubShapeIDPair_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::SubShapeIDPair::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SubShapeIDPair_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SubShapeIDPair::operator delete[](
        inPointer,
        inPlace
    );
}

bool Jolt_equal_JPH_SubShapeIDPair(const JPH_SubShapeIDPair *_this, const JPH_SubShapeIDPair *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeIDPair *)(_this)).operator==(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::SubShapeIDPair *)(inRHS))
    );
}

bool Jolt_less_JPH_SubShapeIDPair(const JPH_SubShapeIDPair *_this, const JPH_SubShapeIDPair *inRHS)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeIDPair *)(_this)).operator<(
        ((inRHS ? void() : MRBINDC_THROW("Parameter `inRHS` can not be null.", void)), *(const JPH::SubShapeIDPair *)(inRHS))
    );
}

const JPH_BodyID *JPH_SubShapeIDPair_GetBody1ID(const JPH_SubShapeIDPair *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeIDPair *)(_this)).GetBody1ID());
}

const JPH_SubShapeID *JPH_SubShapeIDPair_GetSubShapeID1(const JPH_SubShapeIDPair *_this)
{
    return (const JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeIDPair *)(_this)).GetSubShapeID1());
}

const JPH_BodyID *JPH_SubShapeIDPair_GetBody2ID(const JPH_SubShapeIDPair *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeIDPair *)(_this)).GetBody2ID());
}

const JPH_SubShapeID *JPH_SubShapeIDPair_GetSubShapeID2(const JPH_SubShapeIDPair *_this)
{
    return (const JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeIDPair *)(_this)).GetSubShapeID2());
}

uint64_t JPH_SubShapeIDPair_GetHash(const JPH_SubShapeIDPair *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SubShapeIDPair *)(_this)).GetHash();
}

