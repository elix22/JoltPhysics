// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Collision/ContactListener.h"

#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Collision/CollideShape.h>
#include <Jolt/Physics/Collision/ContactListener.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Collision/Shape/SubShapeIDPair.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_ContactManifold_Get_mBaseOffset(const JPH_ContactManifold *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactManifold *)(_this)).mBaseOffset);
}

JPH_Vec3 *JPH_ContactManifold_GetMutable_mBaseOffset(JPH_ContactManifold *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactManifold *)(_this)).mBaseOffset);
}

const JPH_Vec3 *JPH_ContactManifold_Get_mWorldSpaceNormal(const JPH_ContactManifold *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactManifold *)(_this)).mWorldSpaceNormal);
}

JPH_Vec3 *JPH_ContactManifold_GetMutable_mWorldSpaceNormal(JPH_ContactManifold *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactManifold *)(_this)).mWorldSpaceNormal);
}

const float *JPH_ContactManifold_Get_mPenetrationDepth(const JPH_ContactManifold *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactManifold *)(_this)).mPenetrationDepth);
}

void JPH_ContactManifold_Set_mPenetrationDepth(JPH_ContactManifold *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactManifold *)(_this)).mPenetrationDepth = value;
}

float *JPH_ContactManifold_GetMutable_mPenetrationDepth(JPH_ContactManifold *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactManifold *)(_this)).mPenetrationDepth);
}

const JPH_SubShapeID *JPH_ContactManifold_Get_mSubShapeID1(const JPH_ContactManifold *_this)
{
    return (const JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactManifold *)(_this)).mSubShapeID1);
}

void JPH_ContactManifold_Set_mSubShapeID1(JPH_ContactManifold *_this, const JPH_SubShapeID *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactManifold *)(_this)).mSubShapeID1 = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)value));
}

JPH_SubShapeID *JPH_ContactManifold_GetMutable_mSubShapeID1(JPH_ContactManifold *_this)
{
    return (JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactManifold *)(_this)).mSubShapeID1);
}

const JPH_SubShapeID *JPH_ContactManifold_Get_mSubShapeID2(const JPH_ContactManifold *_this)
{
    return (const JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactManifold *)(_this)).mSubShapeID2);
}

void JPH_ContactManifold_Set_mSubShapeID2(JPH_ContactManifold *_this, const JPH_SubShapeID *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactManifold *)(_this)).mSubShapeID2 = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::SubShapeID(*(JPH::SubShapeID *)value));
}

JPH_SubShapeID *JPH_ContactManifold_GetMutable_mSubShapeID2(JPH_ContactManifold *_this)
{
    return (JPH_SubShapeID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactManifold *)(_this)).mSubShapeID2);
}

JPH_ContactManifold *JPH_ContactManifold_DefaultConstruct(void)
{
    using _mrbind_T = JPH::ContactManifold;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_ContactManifold*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_ContactManifold *JPH_ContactManifold_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ContactManifold *)(new JPH::ContactManifold[num_elems]);
}

JPH_ContactManifold *JPH_ContactManifold_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_ContactManifold *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::ContactManifold);
    return (JPH_ContactManifold *)new JPH::ContactManifold(JPH::ContactManifold(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::ContactManifold) MRBINDC_CLASSARG_COPY(_other, (JPH::ContactManifold), JPH::ContactManifold) MRBINDC_CLASSARG_MOVE(_other, (JPH::ContactManifold), JPH::ContactManifold) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::ContactManifold) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::ContactManifold) MRBINDC_CLASSARG_END(_other, JPH::ContactManifold))
    ));
}

void JPH_ContactManifold_Destroy(const JPH_ContactManifold *_this)
{
    delete ((const JPH::ContactManifold *)_this);
}

void JPH_ContactManifold_DestroyArray(const JPH_ContactManifold *_this)
{
    delete[] ((const JPH::ContactManifold *)_this);
}

JPH_ContactManifold *JPH_ContactManifold_AssignFromAnother(JPH_ContactManifold *_this, Jolt_PassBy _other_pass_by, JPH_ContactManifold *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::ContactManifold);
    return (JPH_ContactManifold *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactManifold *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::ContactManifold) MRBINDC_CLASSARG_COPY(_other, (JPH::ContactManifold), JPH::ContactManifold) MRBINDC_CLASSARG_MOVE(_other, (JPH::ContactManifold), JPH::ContactManifold) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::ContactManifold) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::ContactManifold) MRBINDC_CLASSARG_END(_other, JPH::ContactManifold))
    ));
}

JPH_ContactManifold *JPH_ContactManifold_SwapShapes(const JPH_ContactManifold *_this)
{
    return (JPH_ContactManifold *)new JPH::ContactManifold(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactManifold *)(_this)).SwapShapes());
}

JPH_Vec3 *JPH_ContactManifold_GetWorldSpaceContactPointOn1(const JPH_ContactManifold *_this, unsigned int inIndex)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactManifold *)(_this)).GetWorldSpaceContactPointOn1(
        inIndex
    ));
}

JPH_Vec3 *JPH_ContactManifold_GetWorldSpaceContactPointOn2(const JPH_ContactManifold *_this, unsigned int inIndex)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactManifold *)(_this)).GetWorldSpaceContactPointOn2(
        inIndex
    ));
}

const float *JPH_ContactSettings_Get_mCombinedFriction(const JPH_ContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactSettings *)(_this)).mCombinedFriction);
}

void JPH_ContactSettings_Set_mCombinedFriction(JPH_ContactSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mCombinedFriction = value;
}

float *JPH_ContactSettings_GetMutable_mCombinedFriction(JPH_ContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mCombinedFriction);
}

const float *JPH_ContactSettings_Get_mCombinedRestitution(const JPH_ContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactSettings *)(_this)).mCombinedRestitution);
}

void JPH_ContactSettings_Set_mCombinedRestitution(JPH_ContactSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mCombinedRestitution = value;
}

float *JPH_ContactSettings_GetMutable_mCombinedRestitution(JPH_ContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mCombinedRestitution);
}

const float *JPH_ContactSettings_Get_mInvMassScale1(const JPH_ContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactSettings *)(_this)).mInvMassScale1);
}

void JPH_ContactSettings_Set_mInvMassScale1(JPH_ContactSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mInvMassScale1 = value;
}

float *JPH_ContactSettings_GetMutable_mInvMassScale1(JPH_ContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mInvMassScale1);
}

const float *JPH_ContactSettings_Get_mInvInertiaScale1(const JPH_ContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactSettings *)(_this)).mInvInertiaScale1);
}

void JPH_ContactSettings_Set_mInvInertiaScale1(JPH_ContactSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mInvInertiaScale1 = value;
}

float *JPH_ContactSettings_GetMutable_mInvInertiaScale1(JPH_ContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mInvInertiaScale1);
}

const float *JPH_ContactSettings_Get_mInvMassScale2(const JPH_ContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactSettings *)(_this)).mInvMassScale2);
}

void JPH_ContactSettings_Set_mInvMassScale2(JPH_ContactSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mInvMassScale2 = value;
}

float *JPH_ContactSettings_GetMutable_mInvMassScale2(JPH_ContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mInvMassScale2);
}

const float *JPH_ContactSettings_Get_mInvInertiaScale2(const JPH_ContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactSettings *)(_this)).mInvInertiaScale2);
}

void JPH_ContactSettings_Set_mInvInertiaScale2(JPH_ContactSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mInvInertiaScale2 = value;
}

float *JPH_ContactSettings_GetMutable_mInvInertiaScale2(JPH_ContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mInvInertiaScale2);
}

const bool *JPH_ContactSettings_Get_mIsSensor(const JPH_ContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactSettings *)(_this)).mIsSensor);
}

void JPH_ContactSettings_Set_mIsSensor(JPH_ContactSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mIsSensor = value;
}

bool *JPH_ContactSettings_GetMutable_mIsSensor(JPH_ContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mIsSensor);
}

const JPH_Vec3 *JPH_ContactSettings_Get_mRelativeLinearSurfaceVelocity(const JPH_ContactSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactSettings *)(_this)).mRelativeLinearSurfaceVelocity);
}

JPH_Vec3 *JPH_ContactSettings_GetMutable_mRelativeLinearSurfaceVelocity(JPH_ContactSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mRelativeLinearSurfaceVelocity);
}

const JPH_Vec3 *JPH_ContactSettings_Get_mRelativeAngularSurfaceVelocity(const JPH_ContactSettings *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::ContactSettings *)(_this)).mRelativeAngularSurfaceVelocity);
}

JPH_Vec3 *JPH_ContactSettings_GetMutable_mRelativeAngularSurfaceVelocity(JPH_ContactSettings *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).mRelativeAngularSurfaceVelocity);
}

JPH_ContactSettings *JPH_ContactSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::ContactSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_ContactSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_ContactSettings *JPH_ContactSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ContactSettings *)(new JPH::ContactSettings[num_elems]);
}

JPH_ContactSettings *JPH_ContactSettings_ConstructFrom(float mCombinedFriction, float mCombinedRestitution, float mInvMassScale1, float mInvInertiaScale1, float mInvMassScale2, float mInvInertiaScale2, bool mIsSensor, const JPH_Vec3 *mRelativeLinearSurfaceVelocity, const JPH_Vec3 *mRelativeAngularSurfaceVelocity)
{
    return (JPH_ContactSettings *)new JPH::ContactSettings(JPH::ContactSettings{
        mCombinedFriction,
        mCombinedRestitution,
        mInvMassScale1,
        mInvInertiaScale1,
        mInvMassScale2,
        mInvInertiaScale2,
        mIsSensor,
        ((mRelativeLinearSurfaceVelocity ? void() : MRBINDC_THROW("Parameter `mRelativeLinearSurfaceVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mRelativeLinearSurfaceVelocity)),
        ((mRelativeAngularSurfaceVelocity ? void() : MRBINDC_THROW("Parameter `mRelativeAngularSurfaceVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mRelativeAngularSurfaceVelocity))
    });
}

const JPH_ContactSettings *JPH_ContactSettings_OffsetPtr(const JPH_ContactSettings *ptr, ptrdiff_t i)
{
    return (const JPH_ContactSettings *)(((const JPH::ContactSettings *)ptr) + i);
}

JPH_ContactSettings *JPH_ContactSettings_OffsetMutablePtr(JPH_ContactSettings *ptr, ptrdiff_t i)
{
    return (JPH_ContactSettings *)(((JPH::ContactSettings *)ptr) + i);
}

JPH_ContactSettings *JPH_ContactSettings_ConstructFromAnother(const JPH_ContactSettings *_other)
{
    return (JPH_ContactSettings *)new JPH::ContactSettings(JPH::ContactSettings(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::ContactSettings(*(JPH::ContactSettings *)_other))
    ));
}

void JPH_ContactSettings_Destroy(const JPH_ContactSettings *_this)
{
    delete ((const JPH::ContactSettings *)_this);
}

void JPH_ContactSettings_DestroyArray(const JPH_ContactSettings *_this)
{
    delete[] ((const JPH::ContactSettings *)_this);
}

JPH_ContactSettings *JPH_ContactSettings_AssignFromAnother(JPH_ContactSettings *_this, const JPH_ContactSettings *_other)
{
    return (JPH_ContactSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactSettings *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::ContactSettings(*(JPH::ContactSettings *)_other))
    ));
}

JPH_ContactListener *JPH_ContactListener_DefaultConstruct(void)
{
    using _mrbind_T = JPH::ContactListener;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_ContactListener*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_ContactListener *JPH_ContactListener_DefaultConstructArray(size_t num_elems)
{
    return (JPH_ContactListener *)(new JPH::ContactListener[num_elems]);
}

const JPH_ContactListener *JPH_ContactListener_OffsetPtr(const JPH_ContactListener *ptr, ptrdiff_t i)
{
    return (const JPH_ContactListener *)(((const JPH::ContactListener *)ptr) + i);
}

JPH_ContactListener *JPH_ContactListener_OffsetMutablePtr(JPH_ContactListener *ptr, ptrdiff_t i)
{
    return (JPH_ContactListener *)(((JPH::ContactListener *)ptr) + i);
}

JPH_ContactListener *JPH_ContactListener_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_ContactListener *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::ContactListener);
    return (JPH_ContactListener *)new JPH::ContactListener(JPH::ContactListener(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::ContactListener) MRBINDC_CLASSARG_COPY(_other, (JPH::ContactListener), JPH::ContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::ContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::ContactListener) MRBINDC_CLASSARG_END(_other, JPH::ContactListener))
    ));
}

void JPH_ContactListener_Destroy(const JPH_ContactListener *_this)
{
    delete ((const JPH::ContactListener *)_this);
}

void JPH_ContactListener_DestroyArray(const JPH_ContactListener *_this)
{
    delete[] ((const JPH::ContactListener *)_this);
}

JPH_ContactListener *JPH_ContactListener_AssignFromAnother(JPH_ContactListener *_this, Jolt_PassBy _other_pass_by, JPH_ContactListener *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::ContactListener);
    return (JPH_ContactListener *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactListener *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::ContactListener) MRBINDC_CLASSARG_COPY(_other, (JPH::ContactListener), JPH::ContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::ContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::ContactListener) MRBINDC_CLASSARG_END(_other, JPH::ContactListener)))
    ));
}

JPH_ValidateResult JPH_ContactListener_OnContactValidate(JPH_ContactListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_Vec3 *inBaseOffset, const JPH_CollideShapeResult *inCollisionResult)
{
    return (JPH_ValidateResult)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactListener *)(_this)).OnContactValidate(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(const JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2)),
        ((inBaseOffset ? void() : MRBINDC_THROW("Parameter `inBaseOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBaseOffset)),
        ((inCollisionResult ? void() : MRBINDC_THROW("Parameter `inCollisionResult` can not be null.", void)), *(const JPH::CollideShapeResult *)(inCollisionResult))
    ));
}

void JPH_ContactListener_OnContactAdded(JPH_ContactListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactListener *)(_this)).OnContactAdded(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(const JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2)),
        ((inManifold ? void() : MRBINDC_THROW("Parameter `inManifold` can not be null.", void)), *(const JPH::ContactManifold *)(inManifold)),
        ((ioSettings ? void() : MRBINDC_THROW("Parameter `ioSettings` can not be null.", void)), *(JPH::ContactSettings *)(ioSettings))
    );
}

void JPH_ContactListener_OnContactPersisted(JPH_ContactListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactListener *)(_this)).OnContactPersisted(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(const JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2)),
        ((inManifold ? void() : MRBINDC_THROW("Parameter `inManifold` can not be null.", void)), *(const JPH::ContactManifold *)(inManifold)),
        ((ioSettings ? void() : MRBINDC_THROW("Parameter `ioSettings` can not be null.", void)), *(JPH::ContactSettings *)(ioSettings))
    );
}

void JPH_ContactListener_OnContactRemoved(JPH_ContactListener *_this, const JPH_SubShapeIDPair *inSubShapePair)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::ContactListener *)(_this)).OnContactRemoved(
        ((inSubShapePair ? void() : MRBINDC_THROW("Parameter `inSubShapePair` can not be null.", void)), *(const JPH::SubShapeIDPair *)(inSubShapePair))
    );
}

