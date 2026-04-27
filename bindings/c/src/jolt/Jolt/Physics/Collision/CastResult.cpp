// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/CastResult.h"

#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Collision/CastResult.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


const JPH_BodyID *JPH_BroadPhaseCastResult_Get_mBodyID(const JPH_BroadPhaseCastResult *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseCastResult *)(_this)).mBodyID);
}

void JPH_BroadPhaseCastResult_Set_mBodyID(JPH_BroadPhaseCastResult *_this, JPH_BodyID value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BroadPhaseCastResult *)(_this)).mBodyID = MRBINDC_BIT_CAST((JPH::BodyID), value);
}

JPH_BodyID *JPH_BroadPhaseCastResult_GetMutable_mBodyID(JPH_BroadPhaseCastResult *_this)
{
    return (JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BroadPhaseCastResult *)(_this)).mBodyID);
}

const float *JPH_BroadPhaseCastResult_Get_mFraction(const JPH_BroadPhaseCastResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseCastResult *)(_this)).mFraction);
}

void JPH_BroadPhaseCastResult_Set_mFraction(JPH_BroadPhaseCastResult *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BroadPhaseCastResult *)(_this)).mFraction = value;
}

float *JPH_BroadPhaseCastResult_GetMutable_mFraction(JPH_BroadPhaseCastResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BroadPhaseCastResult *)(_this)).mFraction);
}

JPH_BroadPhaseCastResult *JPH_BroadPhaseCastResult_DefaultConstruct(void)
{
    return (JPH_BroadPhaseCastResult *)new JPH::BroadPhaseCastResult(JPH::BroadPhaseCastResult());
}

JPH_BroadPhaseCastResult *JPH_BroadPhaseCastResult_DefaultConstructArray(size_t num_elems)
{
    return (JPH_BroadPhaseCastResult *)(new JPH::BroadPhaseCastResult[num_elems]{});
}

JPH_BroadPhaseCastResult *JPH_BroadPhaseCastResult_ConstructFrom(JPH_BodyID mBodyID, float mFraction)
{
    return (JPH_BroadPhaseCastResult *)new JPH::BroadPhaseCastResult(JPH::BroadPhaseCastResult{
        MRBINDC_BIT_CAST((JPH::BodyID), mBodyID),
        mFraction
    });
}

const JPH_BroadPhaseCastResult *JPH_BroadPhaseCastResult_OffsetPtr(const JPH_BroadPhaseCastResult *ptr, ptrdiff_t i)
{
    return (const JPH_BroadPhaseCastResult *)(((const JPH::BroadPhaseCastResult *)ptr) + i);
}

JPH_BroadPhaseCastResult *JPH_BroadPhaseCastResult_OffsetMutablePtr(JPH_BroadPhaseCastResult *ptr, ptrdiff_t i)
{
    return (JPH_BroadPhaseCastResult *)(((JPH::BroadPhaseCastResult *)ptr) + i);
}

JPH_BroadPhaseCastResult *JPH_BroadPhaseCastResult_ConstructFromAnother(const JPH_BroadPhaseCastResult *_other)
{
    return (JPH_BroadPhaseCastResult *)new JPH::BroadPhaseCastResult(JPH::BroadPhaseCastResult(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::BroadPhaseCastResult(*(JPH::BroadPhaseCastResult *)_other))
    ));
}

void JPH_BroadPhaseCastResult_Destroy(const JPH_BroadPhaseCastResult *_this)
{
    delete ((const JPH::BroadPhaseCastResult *)_this);
}

void JPH_BroadPhaseCastResult_DestroyArray(const JPH_BroadPhaseCastResult *_this)
{
    delete[] ((const JPH::BroadPhaseCastResult *)_this);
}

JPH_BroadPhaseCastResult *JPH_BroadPhaseCastResult_AssignFromAnother(JPH_BroadPhaseCastResult *_this, const JPH_BroadPhaseCastResult *_other)
{
    return (JPH_BroadPhaseCastResult *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BroadPhaseCastResult *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::BroadPhaseCastResult(*(JPH::BroadPhaseCastResult *)_other))
    ));
}

void *Jolt_new_JPH_BroadPhaseCastResult_size_t(size_t inCount)
{
    return JPH::BroadPhaseCastResult::operator new(
        inCount
    );
}

void Jolt_delete_JPH_BroadPhaseCastResult_void_ptr(void *inPointer)
{
    JPH::BroadPhaseCastResult::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_BroadPhaseCastResult_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BroadPhaseCastResult::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_BroadPhaseCastResult_size_t(size_t inCount)
{
    return JPH::BroadPhaseCastResult::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr(void *inPointer)
{
    JPH::BroadPhaseCastResult::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::BroadPhaseCastResult::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_BroadPhaseCastResult_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BroadPhaseCastResult::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_BroadPhaseCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BroadPhaseCastResult::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_BroadPhaseCastResult_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::BroadPhaseCastResult::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::BroadPhaseCastResult::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_BroadPhaseCastResult_GetEarlyOutFraction(const JPH_BroadPhaseCastResult *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BroadPhaseCastResult *)(_this)).GetEarlyOutFraction();
}

void JPH_BroadPhaseCastResult_Reset(JPH_BroadPhaseCastResult *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BroadPhaseCastResult *)(_this)).Reset();
}

const JPH_SubShapeID *JPH_RayCastResult_Get_mSubShapeID2(const JPH_RayCastResult *_this)
{
    return (const JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastResult *)(_this)).mSubShapeID2);
}

void JPH_RayCastResult_Set_mSubShapeID2(JPH_RayCastResult *_this, const JPH_SubShapeID *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastResult *)(_this)).mSubShapeID2 = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)value));
}

JPH_SubShapeID *JPH_RayCastResult_GetMutable_mSubShapeID2(JPH_RayCastResult *_this)
{
    return (JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastResult *)(_this)).mSubShapeID2);
}

const JPH_BodyID *JPH_RayCastResult_Get_mBodyID(const JPH_RayCastResult *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastResult *)(_this)).mBodyID);
}

void JPH_RayCastResult_Set_mBodyID(JPH_RayCastResult *_this, JPH_BodyID value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastResult *)(_this)).mBodyID = MRBINDC_BIT_CAST((JPH::BodyID), value);
}

JPH_BodyID *JPH_RayCastResult_GetMutable_mBodyID(JPH_RayCastResult *_this)
{
    return (JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastResult *)(_this)).mBodyID);
}

const float *JPH_RayCastResult_Get_mFraction(const JPH_RayCastResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastResult *)(_this)).mFraction);
}

void JPH_RayCastResult_Set_mFraction(JPH_RayCastResult *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastResult *)(_this)).mFraction = value;
}

float *JPH_RayCastResult_GetMutable_mFraction(JPH_RayCastResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastResult *)(_this)).mFraction);
}

JPH_RayCastResult *JPH_RayCastResult_DefaultConstruct(void)
{
    return (JPH_RayCastResult *)new JPH::RayCastResult(JPH::RayCastResult());
}

JPH_RayCastResult *JPH_RayCastResult_DefaultConstructArray(size_t num_elems)
{
    return (JPH_RayCastResult *)(new JPH::RayCastResult[num_elems]{});
}

const JPH_RayCastResult *JPH_RayCastResult_OffsetPtr(const JPH_RayCastResult *ptr, ptrdiff_t i)
{
    return (const JPH_RayCastResult *)(((const JPH::RayCastResult *)ptr) + i);
}

JPH_RayCastResult *JPH_RayCastResult_OffsetMutablePtr(JPH_RayCastResult *ptr, ptrdiff_t i)
{
    return (JPH_RayCastResult *)(((JPH::RayCastResult *)ptr) + i);
}

const JPH_BroadPhaseCastResult *JPH_RayCastResult_UpcastTo_JPH_BroadPhaseCastResult(const JPH_RayCastResult *object)
{
    return (const JPH_BroadPhaseCastResult *)(static_cast<const JPH::BroadPhaseCastResult *>(
        ((const JPH::RayCastResult *)object)
    ));
}

JPH_BroadPhaseCastResult *JPH_RayCastResult_MutableUpcastTo_JPH_BroadPhaseCastResult(JPH_RayCastResult *object)
{
    return (JPH_BroadPhaseCastResult *)(static_cast<JPH::BroadPhaseCastResult *>(
        ((JPH::RayCastResult *)object)
    ));
}

const JPH_RayCastResult *JPH_RayCastResult_StaticDowncastFrom_JPH_BroadPhaseCastResult(const JPH_BroadPhaseCastResult *object)
{
    return (const JPH_RayCastResult *)(static_cast<const JPH::RayCastResult *>(
        ((const JPH::BroadPhaseCastResult *)object)
    ));
}

JPH_RayCastResult *JPH_RayCastResult_MutableStaticDowncastFrom_JPH_BroadPhaseCastResult(JPH_BroadPhaseCastResult *object)
{
    return (JPH_RayCastResult *)(static_cast<JPH::RayCastResult *>(
        ((JPH::BroadPhaseCastResult *)object)
    ));
}

JPH_RayCastResult *JPH_RayCastResult_ConstructFromAnother(const JPH_RayCastResult *_other)
{
    return (JPH_RayCastResult *)new JPH::RayCastResult(JPH::RayCastResult(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RayCastResult(*(JPH::RayCastResult *)_other))
    ));
}

void JPH_RayCastResult_Destroy(const JPH_RayCastResult *_this)
{
    delete ((const JPH::RayCastResult *)_this);
}

void JPH_RayCastResult_DestroyArray(const JPH_RayCastResult *_this)
{
    delete[] ((const JPH::RayCastResult *)_this);
}

JPH_RayCastResult *JPH_RayCastResult_AssignFromAnother(JPH_RayCastResult *_this, const JPH_RayCastResult *_other)
{
    return (JPH_RayCastResult *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastResult *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::RayCastResult(*(JPH::RayCastResult *)_other))
    ));
}

void *Jolt_new_JPH_RayCastResult_size_t(size_t inCount)
{
    return JPH::RayCastResult::operator new(
        inCount
    );
}

void Jolt_delete_JPH_RayCastResult_void_ptr(void *inPointer)
{
    JPH::RayCastResult::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_RayCastResult_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RayCastResult::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_RayCastResult_size_t(size_t inCount)
{
    return JPH::RayCastResult::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_RayCastResult_void_ptr(void *inPointer)
{
    JPH::RayCastResult::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_RayCastResult_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::RayCastResult::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_RayCastResult_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RayCastResult::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_RayCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RayCastResult::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_RayCastResult_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::RayCastResult::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_RayCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::RayCastResult::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_RayCastResult_GetEarlyOutFraction(const JPH_RayCastResult *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::RayCastResult *)(_this)).GetEarlyOutFraction();
}

void JPH_RayCastResult_Reset(JPH_RayCastResult *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::RayCastResult *)(_this)).Reset();
}

