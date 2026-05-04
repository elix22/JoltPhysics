// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/CollideShape.h"

#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Collision/ActiveEdgeMode.h>
#include <Jolt/Physics/Collision/BackFaceMode.h>
#include <Jolt/Physics/Collision/CollectFacesMode.h>
#include <Jolt/Physics/Collision/CollideShape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_CollideShapeResult_Get_mContactPointOn1(const JPH_CollideShapeResult *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeResult *)(_this)).mContactPointOn1);
}

JPH_Vec3 *JPH_CollideShapeResult_GetMutable_mContactPointOn1(JPH_CollideShapeResult *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeResult *)(_this)).mContactPointOn1);
}

const JPH_Vec3 *JPH_CollideShapeResult_Get_mContactPointOn2(const JPH_CollideShapeResult *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeResult *)(_this)).mContactPointOn2);
}

JPH_Vec3 *JPH_CollideShapeResult_GetMutable_mContactPointOn2(JPH_CollideShapeResult *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeResult *)(_this)).mContactPointOn2);
}

const JPH_Vec3 *JPH_CollideShapeResult_Get_mPenetrationAxis(const JPH_CollideShapeResult *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeResult *)(_this)).mPenetrationAxis);
}

JPH_Vec3 *JPH_CollideShapeResult_GetMutable_mPenetrationAxis(JPH_CollideShapeResult *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeResult *)(_this)).mPenetrationAxis);
}

const float *JPH_CollideShapeResult_Get_mPenetrationDepth(const JPH_CollideShapeResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeResult *)(_this)).mPenetrationDepth);
}

void JPH_CollideShapeResult_Set_mPenetrationDepth(JPH_CollideShapeResult *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeResult *)(_this)).mPenetrationDepth = value;
}

float *JPH_CollideShapeResult_GetMutable_mPenetrationDepth(JPH_CollideShapeResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeResult *)(_this)).mPenetrationDepth);
}

const JPH_SubShapeID *JPH_CollideShapeResult_Get_mSubShapeID1(const JPH_CollideShapeResult *_this)
{
    return (const JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeResult *)(_this)).mSubShapeID1);
}

void JPH_CollideShapeResult_Set_mSubShapeID1(JPH_CollideShapeResult *_this, const JPH_SubShapeID *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeResult *)(_this)).mSubShapeID1 = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)value));
}

JPH_SubShapeID *JPH_CollideShapeResult_GetMutable_mSubShapeID1(JPH_CollideShapeResult *_this)
{
    return (JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeResult *)(_this)).mSubShapeID1);
}

const JPH_SubShapeID *JPH_CollideShapeResult_Get_mSubShapeID2(const JPH_CollideShapeResult *_this)
{
    return (const JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeResult *)(_this)).mSubShapeID2);
}

void JPH_CollideShapeResult_Set_mSubShapeID2(JPH_CollideShapeResult *_this, const JPH_SubShapeID *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeResult *)(_this)).mSubShapeID2 = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)value));
}

JPH_SubShapeID *JPH_CollideShapeResult_GetMutable_mSubShapeID2(JPH_CollideShapeResult *_this)
{
    return (JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeResult *)(_this)).mSubShapeID2);
}

const JPH_BodyID *JPH_CollideShapeResult_Get_mBodyID2(const JPH_CollideShapeResult *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeResult *)(_this)).mBodyID2);
}

void JPH_CollideShapeResult_Set_mBodyID2(JPH_CollideShapeResult *_this, JPH_BodyID value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeResult *)(_this)).mBodyID2 = MRBINDC_BIT_CAST((JPH::BodyID), value);
}

JPH_BodyID *JPH_CollideShapeResult_GetMutable_mBodyID2(JPH_CollideShapeResult *_this)
{
    return (JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeResult *)(_this)).mBodyID2);
}

JPH_CollideShapeResult *JPH_CollideShapeResult_DefaultConstruct(void)
{
    using _mrbind_T = JPH::CollideShapeResult;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_CollideShapeResult*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_CollideShapeResult *JPH_CollideShapeResult_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CollideShapeResult *)(new JPH::CollideShapeResult[num_elems]);
}

const JPH_CollideShapeResult *JPH_CollideShapeResult_OffsetPtr(const JPH_CollideShapeResult *ptr, ptrdiff_t i)
{
    return (const JPH_CollideShapeResult *)(((const JPH::CollideShapeResult *)ptr) + i);
}

JPH_CollideShapeResult *JPH_CollideShapeResult_OffsetMutablePtr(JPH_CollideShapeResult *ptr, ptrdiff_t i)
{
    return (JPH_CollideShapeResult *)(((JPH::CollideShapeResult *)ptr) + i);
}

JPH_CollideShapeResult *JPH_CollideShapeResult_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_CollideShapeResult *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CollideShapeResult);
    return (JPH_CollideShapeResult *)new JPH::CollideShapeResult(JPH::CollideShapeResult(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CollideShapeResult) MRBINDC_CLASSARG_COPY(_other, (JPH::CollideShapeResult), JPH::CollideShapeResult) MRBINDC_CLASSARG_MOVE(_other, (JPH::CollideShapeResult), JPH::CollideShapeResult) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CollideShapeResult) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CollideShapeResult) MRBINDC_CLASSARG_END(_other, JPH::CollideShapeResult))
    ));
}

JPH_CollideShapeResult *JPH_CollideShapeResult_Construct(const JPH_Vec3 *inContactPointOn1, const JPH_Vec3 *inContactPointOn2, const JPH_Vec3 *inPenetrationAxis, float inPenetrationDepth, const JPH_SubShapeID *inSubShapeID1, const JPH_SubShapeID *inSubShapeID2, const JPH_BodyID *inBodyID2)
{
    return (JPH_CollideShapeResult *)new JPH::CollideShapeResult(JPH::CollideShapeResult(
        ((inContactPointOn1 ? void() : MRBINDC_THROW("Parameter `inContactPointOn1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactPointOn1)),
        ((inContactPointOn2 ? void() : MRBINDC_THROW("Parameter `inContactPointOn2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inContactPointOn2)),
        ((inPenetrationAxis ? void() : MRBINDC_THROW("Parameter `inPenetrationAxis` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPenetrationAxis)),
        inPenetrationDepth,
        ((inSubShapeID1 ? void() : MRBINDC_THROW("Parameter `inSubShapeID1` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID1)),
        ((inSubShapeID2 ? void() : MRBINDC_THROW("Parameter `inSubShapeID2` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID2)),
        ((inBodyID2 ? void() : MRBINDC_THROW("Parameter `inBodyID2` can not be null.", void)), *(const JPH::BodyID *)(inBodyID2))
    ));
}

void JPH_CollideShapeResult_Destroy(const JPH_CollideShapeResult *_this)
{
    delete ((const JPH::CollideShapeResult *)_this);
}

void JPH_CollideShapeResult_DestroyArray(const JPH_CollideShapeResult *_this)
{
    delete[] ((const JPH::CollideShapeResult *)_this);
}

JPH_CollideShapeResult *JPH_CollideShapeResult_AssignFromAnother(JPH_CollideShapeResult *_this, Jolt_PassBy _other_pass_by, JPH_CollideShapeResult *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::CollideShapeResult);
    return (JPH_CollideShapeResult *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeResult *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::CollideShapeResult) MRBINDC_CLASSARG_COPY(_other, (JPH::CollideShapeResult), JPH::CollideShapeResult) MRBINDC_CLASSARG_MOVE(_other, (JPH::CollideShapeResult), JPH::CollideShapeResult) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::CollideShapeResult) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::CollideShapeResult) MRBINDC_CLASSARG_END(_other, JPH::CollideShapeResult))
    ));
}

void *Jolt_new_JPH_CollideShapeResult_size_t(size_t inCount)
{
    return JPH::CollideShapeResult::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CollideShapeResult_void_ptr(void *inPointer)
{
    JPH::CollideShapeResult::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CollideShapeResult_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CollideShapeResult::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CollideShapeResult_size_t(size_t inCount)
{
    return JPH::CollideShapeResult::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CollideShapeResult_void_ptr(void *inPointer)
{
    JPH::CollideShapeResult::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CollideShapeResult_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CollideShapeResult::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CollideShapeResult_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CollideShapeResult::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CollideShapeResult_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CollideShapeResult::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CollideShapeResult_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CollideShapeResult::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CollideShapeResult_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CollideShapeResult::operator delete[](
        inPointer,
        inPlace
    );
}

float JPH_CollideShapeResult_GetEarlyOutFraction(const JPH_CollideShapeResult *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeResult *)(_this)).GetEarlyOutFraction();
}

JPH_CollideShapeResult *JPH_CollideShapeResult_Reversed(const JPH_CollideShapeResult *_this)
{
    return (JPH_CollideShapeResult *)new JPH::CollideShapeResult(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeResult *)(_this)).Reversed());
}

const JPH_EActiveEdgeMode *JPH_CollideSettingsBase_Get_mActiveEdgeMode(const JPH_CollideSettingsBase *_this)
{
    return (const JPH_EActiveEdgeMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideSettingsBase *)(_this)).mActiveEdgeMode);
}

void JPH_CollideSettingsBase_Set_mActiveEdgeMode(JPH_CollideSettingsBase *_this, JPH_EActiveEdgeMode value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideSettingsBase *)(_this)).mActiveEdgeMode = ((JPH::EActiveEdgeMode)value);
}

JPH_EActiveEdgeMode *JPH_CollideSettingsBase_GetMutable_mActiveEdgeMode(JPH_CollideSettingsBase *_this)
{
    return (JPH_EActiveEdgeMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideSettingsBase *)(_this)).mActiveEdgeMode);
}

const JPH_ECollectFacesMode *JPH_CollideSettingsBase_Get_mCollectFacesMode(const JPH_CollideSettingsBase *_this)
{
    return (const JPH_ECollectFacesMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideSettingsBase *)(_this)).mCollectFacesMode);
}

void JPH_CollideSettingsBase_Set_mCollectFacesMode(JPH_CollideSettingsBase *_this, JPH_ECollectFacesMode value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideSettingsBase *)(_this)).mCollectFacesMode = ((JPH::ECollectFacesMode)value);
}

JPH_ECollectFacesMode *JPH_CollideSettingsBase_GetMutable_mCollectFacesMode(JPH_CollideSettingsBase *_this)
{
    return (JPH_ECollectFacesMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideSettingsBase *)(_this)).mCollectFacesMode);
}

const float *JPH_CollideSettingsBase_Get_mCollisionTolerance(const JPH_CollideSettingsBase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideSettingsBase *)(_this)).mCollisionTolerance);
}

void JPH_CollideSettingsBase_Set_mCollisionTolerance(JPH_CollideSettingsBase *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideSettingsBase *)(_this)).mCollisionTolerance = value;
}

float *JPH_CollideSettingsBase_GetMutable_mCollisionTolerance(JPH_CollideSettingsBase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideSettingsBase *)(_this)).mCollisionTolerance);
}

const float *JPH_CollideSettingsBase_Get_mPenetrationTolerance(const JPH_CollideSettingsBase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideSettingsBase *)(_this)).mPenetrationTolerance);
}

void JPH_CollideSettingsBase_Set_mPenetrationTolerance(JPH_CollideSettingsBase *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideSettingsBase *)(_this)).mPenetrationTolerance = value;
}

float *JPH_CollideSettingsBase_GetMutable_mPenetrationTolerance(JPH_CollideSettingsBase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideSettingsBase *)(_this)).mPenetrationTolerance);
}

const JPH_Vec3 *JPH_CollideSettingsBase_Get_mActiveEdgeMovementDirection(const JPH_CollideSettingsBase *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideSettingsBase *)(_this)).mActiveEdgeMovementDirection);
}

JPH_Vec3 *JPH_CollideSettingsBase_GetMutable_mActiveEdgeMovementDirection(JPH_CollideSettingsBase *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideSettingsBase *)(_this)).mActiveEdgeMovementDirection);
}

JPH_CollideSettingsBase *JPH_CollideSettingsBase_DefaultConstruct(void)
{
    using _mrbind_T = JPH::CollideSettingsBase;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_CollideSettingsBase*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_CollideSettingsBase *JPH_CollideSettingsBase_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CollideSettingsBase *)(new JPH::CollideSettingsBase[num_elems]);
}

JPH_CollideSettingsBase *JPH_CollideSettingsBase_ConstructFrom(JPH_EActiveEdgeMode mActiveEdgeMode, JPH_ECollectFacesMode mCollectFacesMode, float mCollisionTolerance, float mPenetrationTolerance, const JPH_Vec3 *mActiveEdgeMovementDirection)
{
    return (JPH_CollideSettingsBase *)new JPH::CollideSettingsBase(JPH::CollideSettingsBase{
        ((JPH::EActiveEdgeMode)mActiveEdgeMode),
        ((JPH::ECollectFacesMode)mCollectFacesMode),
        mCollisionTolerance,
        mPenetrationTolerance,
        ((mActiveEdgeMovementDirection ? void() : MRBINDC_THROW("Parameter `mActiveEdgeMovementDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mActiveEdgeMovementDirection))
    });
}

const JPH_CollideSettingsBase *JPH_CollideSettingsBase_OffsetPtr(const JPH_CollideSettingsBase *ptr, ptrdiff_t i)
{
    return (const JPH_CollideSettingsBase *)(((const JPH::CollideSettingsBase *)ptr) + i);
}

JPH_CollideSettingsBase *JPH_CollideSettingsBase_OffsetMutablePtr(JPH_CollideSettingsBase *ptr, ptrdiff_t i)
{
    return (JPH_CollideSettingsBase *)(((JPH::CollideSettingsBase *)ptr) + i);
}

JPH_CollideSettingsBase *JPH_CollideSettingsBase_ConstructFromAnother(const JPH_CollideSettingsBase *_other)
{
    return (JPH_CollideSettingsBase *)new JPH::CollideSettingsBase(JPH::CollideSettingsBase(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::CollideSettingsBase(*(JPH::CollideSettingsBase *)_other))
    ));
}

void JPH_CollideSettingsBase_Destroy(const JPH_CollideSettingsBase *_this)
{
    delete ((const JPH::CollideSettingsBase *)_this);
}

void JPH_CollideSettingsBase_DestroyArray(const JPH_CollideSettingsBase *_this)
{
    delete[] ((const JPH::CollideSettingsBase *)_this);
}

JPH_CollideSettingsBase *JPH_CollideSettingsBase_AssignFromAnother(JPH_CollideSettingsBase *_this, const JPH_CollideSettingsBase *_other)
{
    return (JPH_CollideSettingsBase *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideSettingsBase *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::CollideSettingsBase(*(JPH::CollideSettingsBase *)_other))
    ));
}

void *Jolt_new_JPH_CollideSettingsBase_size_t(size_t inCount)
{
    return JPH::CollideSettingsBase::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CollideSettingsBase_void_ptr(void *inPointer)
{
    JPH::CollideSettingsBase::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CollideSettingsBase_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CollideSettingsBase::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CollideSettingsBase_size_t(size_t inCount)
{
    return JPH::CollideSettingsBase::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CollideSettingsBase_void_ptr(void *inPointer)
{
    JPH::CollideSettingsBase::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CollideSettingsBase_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CollideSettingsBase::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CollideSettingsBase_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CollideSettingsBase::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CollideSettingsBase_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CollideSettingsBase::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CollideSettingsBase_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CollideSettingsBase::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CollideSettingsBase_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CollideSettingsBase::operator delete[](
        inPointer,
        inPlace
    );
}

const float *JPH_CollideShapeSettings_Get_mMaxSeparationDistance(const JPH_CollideShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeSettings *)(_this)).mMaxSeparationDistance);
}

void JPH_CollideShapeSettings_Set_mMaxSeparationDistance(JPH_CollideShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeSettings *)(_this)).mMaxSeparationDistance = value;
}

float *JPH_CollideShapeSettings_GetMutable_mMaxSeparationDistance(JPH_CollideShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeSettings *)(_this)).mMaxSeparationDistance);
}

const JPH_EBackFaceMode *JPH_CollideShapeSettings_Get_mBackFaceMode(const JPH_CollideShapeSettings *_this)
{
    return (const JPH_EBackFaceMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeSettings *)(_this)).mBackFaceMode);
}

void JPH_CollideShapeSettings_Set_mBackFaceMode(JPH_CollideShapeSettings *_this, JPH_EBackFaceMode value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeSettings *)(_this)).mBackFaceMode = ((JPH::EBackFaceMode)value);
}

JPH_EBackFaceMode *JPH_CollideShapeSettings_GetMutable_mBackFaceMode(JPH_CollideShapeSettings *_this)
{
    return (JPH_EBackFaceMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeSettings *)(_this)).mBackFaceMode);
}

const JPH_EActiveEdgeMode *JPH_CollideShapeSettings_Get_mActiveEdgeMode(const JPH_CollideShapeSettings *_this)
{
    return (const JPH_EActiveEdgeMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeSettings *)(_this)).mActiveEdgeMode);
}

void JPH_CollideShapeSettings_Set_mActiveEdgeMode(JPH_CollideShapeSettings *_this, JPH_EActiveEdgeMode value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeSettings *)(_this)).mActiveEdgeMode = ((JPH::EActiveEdgeMode)value);
}

JPH_EActiveEdgeMode *JPH_CollideShapeSettings_GetMutable_mActiveEdgeMode(JPH_CollideShapeSettings *_this)
{
    return (JPH_EActiveEdgeMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeSettings *)(_this)).mActiveEdgeMode);
}

const JPH_ECollectFacesMode *JPH_CollideShapeSettings_Get_mCollectFacesMode(const JPH_CollideShapeSettings *_this)
{
    return (const JPH_ECollectFacesMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeSettings *)(_this)).mCollectFacesMode);
}

void JPH_CollideShapeSettings_Set_mCollectFacesMode(JPH_CollideShapeSettings *_this, JPH_ECollectFacesMode value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeSettings *)(_this)).mCollectFacesMode = ((JPH::ECollectFacesMode)value);
}

JPH_ECollectFacesMode *JPH_CollideShapeSettings_GetMutable_mCollectFacesMode(JPH_CollideShapeSettings *_this)
{
    return (JPH_ECollectFacesMode *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeSettings *)(_this)).mCollectFacesMode);
}

const float *JPH_CollideShapeSettings_Get_mCollisionTolerance(const JPH_CollideShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeSettings *)(_this)).mCollisionTolerance);
}

void JPH_CollideShapeSettings_Set_mCollisionTolerance(JPH_CollideShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeSettings *)(_this)).mCollisionTolerance = value;
}

float *JPH_CollideShapeSettings_GetMutable_mCollisionTolerance(JPH_CollideShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeSettings *)(_this)).mCollisionTolerance);
}

const float *JPH_CollideShapeSettings_Get_mPenetrationTolerance(const JPH_CollideShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeSettings *)(_this)).mPenetrationTolerance);
}

void JPH_CollideShapeSettings_Set_mPenetrationTolerance(JPH_CollideShapeSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeSettings *)(_this)).mPenetrationTolerance = value;
}

float *JPH_CollideShapeSettings_GetMutable_mPenetrationTolerance(JPH_CollideShapeSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeSettings *)(_this)).mPenetrationTolerance);
}

const JPH_Vec3 *JPH_CollideShapeSettings_Get_mActiveEdgeMovementDirection(const JPH_CollideShapeSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::CollideShapeSettings *)(_this)).mActiveEdgeMovementDirection);
}

JPH_Vec3 *JPH_CollideShapeSettings_GetMutable_mActiveEdgeMovementDirection(JPH_CollideShapeSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeSettings *)(_this)).mActiveEdgeMovementDirection);
}

JPH_CollideShapeSettings *JPH_CollideShapeSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::CollideShapeSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_CollideShapeSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_CollideShapeSettings *JPH_CollideShapeSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_CollideShapeSettings *)(new JPH::CollideShapeSettings[num_elems]);
}

const JPH_CollideShapeSettings *JPH_CollideShapeSettings_OffsetPtr(const JPH_CollideShapeSettings *ptr, ptrdiff_t i)
{
    return (const JPH_CollideShapeSettings *)(((const JPH::CollideShapeSettings *)ptr) + i);
}

JPH_CollideShapeSettings *JPH_CollideShapeSettings_OffsetMutablePtr(JPH_CollideShapeSettings *ptr, ptrdiff_t i)
{
    return (JPH_CollideShapeSettings *)(((JPH::CollideShapeSettings *)ptr) + i);
}

const JPH_CollideSettingsBase *JPH_CollideShapeSettings_UpcastTo_JPH_CollideSettingsBase(const JPH_CollideShapeSettings *object)
{
    return (const JPH_CollideSettingsBase *)(static_cast<const JPH::CollideSettingsBase *>(
        ((const JPH::CollideShapeSettings *)object)
    ));
}

JPH_CollideSettingsBase *JPH_CollideShapeSettings_MutableUpcastTo_JPH_CollideSettingsBase(JPH_CollideShapeSettings *object)
{
    return (JPH_CollideSettingsBase *)(static_cast<JPH::CollideSettingsBase *>(
        ((JPH::CollideShapeSettings *)object)
    ));
}

const JPH_CollideShapeSettings *JPH_CollideShapeSettings_StaticDowncastFrom_JPH_CollideSettingsBase(const JPH_CollideSettingsBase *object)
{
    return (const JPH_CollideShapeSettings *)(static_cast<const JPH::CollideShapeSettings *>(
        ((const JPH::CollideSettingsBase *)object)
    ));
}

JPH_CollideShapeSettings *JPH_CollideShapeSettings_MutableStaticDowncastFrom_JPH_CollideSettingsBase(JPH_CollideSettingsBase *object)
{
    return (JPH_CollideShapeSettings *)(static_cast<JPH::CollideShapeSettings *>(
        ((JPH::CollideSettingsBase *)object)
    ));
}

JPH_CollideShapeSettings *JPH_CollideShapeSettings_ConstructFromAnother(const JPH_CollideShapeSettings *_other)
{
    return (JPH_CollideShapeSettings *)new JPH::CollideShapeSettings(JPH::CollideShapeSettings(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::CollideShapeSettings(*(JPH::CollideShapeSettings *)_other))
    ));
}

void JPH_CollideShapeSettings_Destroy(const JPH_CollideShapeSettings *_this)
{
    delete ((const JPH::CollideShapeSettings *)_this);
}

void JPH_CollideShapeSettings_DestroyArray(const JPH_CollideShapeSettings *_this)
{
    delete[] ((const JPH::CollideShapeSettings *)_this);
}

JPH_CollideShapeSettings *JPH_CollideShapeSettings_AssignFromAnother(JPH_CollideShapeSettings *_this, const JPH_CollideShapeSettings *_other)
{
    return (JPH_CollideShapeSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::CollideShapeSettings *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::CollideShapeSettings(*(JPH::CollideShapeSettings *)_other))
    ));
}

void *Jolt_new_JPH_CollideShapeSettings_size_t(size_t inCount)
{
    return JPH::CollideShapeSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_CollideShapeSettings_void_ptr(void *inPointer)
{
    JPH::CollideShapeSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_CollideShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CollideShapeSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_CollideShapeSettings_size_t(size_t inCount)
{
    return JPH::CollideShapeSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_CollideShapeSettings_void_ptr(void *inPointer)
{
    JPH::CollideShapeSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_CollideShapeSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::CollideShapeSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_CollideShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CollideShapeSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_CollideShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CollideShapeSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_CollideShapeSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::CollideShapeSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_CollideShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::CollideShapeSettings::operator delete[](
        inPointer,
        inPlace
    );
}

