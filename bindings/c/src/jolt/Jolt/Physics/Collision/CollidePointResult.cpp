// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/CollidePointResult.h"

#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Collision/CollidePointResult.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_BodyID *JPH_CollidePointResult_Get_mBodyID(const JPH_CollidePointResult *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollidePointResult *)(_this)).mBodyID);
}

void JPH_CollidePointResult_Set_mBodyID(JPH_CollidePointResult *_this, JPH_BodyID value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollidePointResult *)(_this)).mBodyID = MRBINDC_BIT_CAST((JPH::BodyID), value);
}

JPH_BodyID *JPH_CollidePointResult_GetMutable_mBodyID(JPH_CollidePointResult *_this)
{
    return (JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollidePointResult *)(_this)).mBodyID);
}

const JPH_SubShapeID *JPH_CollidePointResult_Get_mSubShapeID2(const JPH_CollidePointResult *_this)
{
    return (const JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollidePointResult *)(_this)).mSubShapeID2);
}

void JPH_CollidePointResult_Set_mSubShapeID2(JPH_CollidePointResult *_this, const JPH_SubShapeID *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollidePointResult *)(_this)).mSubShapeID2 = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)value));
}

JPH_SubShapeID *JPH_CollidePointResult_GetMutable_mSubShapeID2(JPH_CollidePointResult *_this)
{
    return (JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollidePointResult *)(_this)).mSubShapeID2);
}

JPH_CollidePointResult *JPH_CollidePointResult_DefaultConstruct(void)
{
    using _mrbind_T = JPH::CollidePointResult;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_CollidePointResult*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_CollidePointResult *JPH_CollidePointResult_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CollidePointResult *)(new JPH::CollidePointResult[num_elems]{});
}

JPH_CollidePointResult *JPH_CollidePointResult_ConstructFrom(JPH_BodyID mBodyID, const JPH_SubShapeID *mSubShapeID2)
{
    return (JPH_CollidePointResult *)new JPH::CollidePointResult(JPH::CollidePointResult{
        MRBINDC_BIT_CAST((JPH::BodyID), mBodyID),
        ((mSubShapeID2 ? void() : MRBINDC_THROW("Parameter `mSubShapeID2` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)mSubShapeID2))
    });
}

const JPH_CollidePointResult *JPH_CollidePointResult_OffsetPtr(const JPH_CollidePointResult *ptr, ptrdiff_t i)
{
    return (const JPH_CollidePointResult *)(((const JPH::CollidePointResult *)ptr) + i);
}

JPH_CollidePointResult *JPH_CollidePointResult_OffsetMutablePtr(JPH_CollidePointResult *ptr, ptrdiff_t i)
{
    return (JPH_CollidePointResult *)(((JPH::CollidePointResult *)ptr) + i);
}

JPH_CollidePointResult *JPH_CollidePointResult_ConstructFromAnother(const JPH_CollidePointResult *_other)
{
    return (JPH_CollidePointResult *)new JPH::CollidePointResult(JPH::CollidePointResult(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::CollidePointResult(*(JPH::CollidePointResult *)_other))
    ));
}

void JPH_CollidePointResult_Destroy(const JPH_CollidePointResult *_this)
{
    delete ((const JPH::CollidePointResult *)_this);
}

void JPH_CollidePointResult_DestroyArray(const JPH_CollidePointResult *_this)
{
    delete[] ((const JPH::CollidePointResult *)_this);
}

JPH_CollidePointResult *JPH_CollidePointResult_AssignFromAnother(JPH_CollidePointResult *_this, const JPH_CollidePointResult *_other)
{
    return (JPH_CollidePointResult *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollidePointResult *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::CollidePointResult(*(JPH::CollidePointResult *)_other))
    ));
}

void *Jolt_new_JPH_CollidePointResult_size_t(size_t inCount)
{
    return JPH::CollidePointResult::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CollidePointResult_void_ptr(void *inPointer)
{
    JPH::CollidePointResult::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CollidePointResult_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CollidePointResult::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CollidePointResult_size_t(size_t inCount)
{
    return JPH::CollidePointResult::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CollidePointResult_void_ptr(void *inPointer)
{
    JPH::CollidePointResult::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CollidePointResult_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CollidePointResult::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CollidePointResult_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CollidePointResult::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CollidePointResult_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CollidePointResult::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CollidePointResult_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CollidePointResult::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CollidePointResult_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CollidePointResult::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_CollidePointResult_GetEarlyOutFraction(const JPH_CollidePointResult *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollidePointResult *)(_this)).GetEarlyOutFraction();
}

