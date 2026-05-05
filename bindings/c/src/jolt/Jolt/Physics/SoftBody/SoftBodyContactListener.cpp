// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/SoftBody/SoftBodyContactListener.h"

#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/SoftBody/SoftBodyContactListener.h>
#include <Jolt/Physics/SoftBody/SoftBodyManifold.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const float *JPH_SoftBodyContactSettings_Get_mInvMassScale1(const JPH_SoftBodyContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyContactSettings *)(_this)).mInvMassScale1);
}

void JPH_SoftBodyContactSettings_Set_mInvMassScale1(JPH_SoftBodyContactSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyContactSettings *)(_this)).mInvMassScale1 = value;
}

float *JPH_SoftBodyContactSettings_GetMutable_mInvMassScale1(JPH_SoftBodyContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyContactSettings *)(_this)).mInvMassScale1);
}

const float *JPH_SoftBodyContactSettings_Get_mInvMassScale2(const JPH_SoftBodyContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyContactSettings *)(_this)).mInvMassScale2);
}

void JPH_SoftBodyContactSettings_Set_mInvMassScale2(JPH_SoftBodyContactSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyContactSettings *)(_this)).mInvMassScale2 = value;
}

float *JPH_SoftBodyContactSettings_GetMutable_mInvMassScale2(JPH_SoftBodyContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyContactSettings *)(_this)).mInvMassScale2);
}

const float *JPH_SoftBodyContactSettings_Get_mInvInertiaScale2(const JPH_SoftBodyContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyContactSettings *)(_this)).mInvInertiaScale2);
}

void JPH_SoftBodyContactSettings_Set_mInvInertiaScale2(JPH_SoftBodyContactSettings *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyContactSettings *)(_this)).mInvInertiaScale2 = value;
}

float *JPH_SoftBodyContactSettings_GetMutable_mInvInertiaScale2(JPH_SoftBodyContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyContactSettings *)(_this)).mInvInertiaScale2);
}

const bool *JPH_SoftBodyContactSettings_Get_mIsSensor(const JPH_SoftBodyContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyContactSettings *)(_this)).mIsSensor);
}

void JPH_SoftBodyContactSettings_Set_mIsSensor(JPH_SoftBodyContactSettings *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyContactSettings *)(_this)).mIsSensor = value;
}

bool *JPH_SoftBodyContactSettings_GetMutable_mIsSensor(JPH_SoftBodyContactSettings *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyContactSettings *)(_this)).mIsSensor);
}

JPH_SoftBodyContactSettings *JPH_SoftBodyContactSettings_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SoftBodyContactSettings;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SoftBodyContactSettings*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SoftBodyContactSettings *JPH_SoftBodyContactSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodyContactSettings *)(new JPH::SoftBodyContactSettings[num_elems]);
}

JPH_SoftBodyContactSettings *JPH_SoftBodyContactSettings_ConstructFrom(float mInvMassScale1, float mInvMassScale2, float mInvInertiaScale2, bool mIsSensor)
{
    return (JPH_SoftBodyContactSettings *)new JPH::SoftBodyContactSettings(JPH::SoftBodyContactSettings{
        mInvMassScale1,
        mInvMassScale2,
        mInvInertiaScale2,
        mIsSensor
    });
}

const JPH_SoftBodyContactSettings *JPH_SoftBodyContactSettings_OffsetPtr(const JPH_SoftBodyContactSettings *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodyContactSettings *)(((const JPH::SoftBodyContactSettings *)ptr) + i);
}

JPH_SoftBodyContactSettings *JPH_SoftBodyContactSettings_OffsetMutablePtr(JPH_SoftBodyContactSettings *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodyContactSettings *)(((JPH::SoftBodyContactSettings *)ptr) + i);
}

JPH_SoftBodyContactSettings *JPH_SoftBodyContactSettings_ConstructFromAnother(const JPH_SoftBodyContactSettings *_other)
{
    return (JPH_SoftBodyContactSettings *)new JPH::SoftBodyContactSettings(JPH::SoftBodyContactSettings(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodyContactSettings(*(JPH::SoftBodyContactSettings *)_other))
    ));
}

void JPH_SoftBodyContactSettings_Destroy(const JPH_SoftBodyContactSettings *_this)
{
    delete ((const JPH::SoftBodyContactSettings *)_this);
}

void JPH_SoftBodyContactSettings_DestroyArray(const JPH_SoftBodyContactSettings *_this)
{
    delete[] ((const JPH::SoftBodyContactSettings *)_this);
}

JPH_SoftBodyContactSettings *JPH_SoftBodyContactSettings_AssignFromAnother(JPH_SoftBodyContactSettings *_this, const JPH_SoftBodyContactSettings *_other)
{
    return (JPH_SoftBodyContactSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyContactSettings *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodyContactSettings(*(JPH::SoftBodyContactSettings *)_other))
    ));
}

JPH_SoftBodyContactListener *JPH_SoftBodyContactListener_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SoftBodyContactListener;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SoftBodyContactListener*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SoftBodyContactListener *JPH_SoftBodyContactListener_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodyContactListener *)(new JPH::SoftBodyContactListener[num_elems]);
}

const JPH_SoftBodyContactListener *JPH_SoftBodyContactListener_OffsetPtr(const JPH_SoftBodyContactListener *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodyContactListener *)(((const JPH::SoftBodyContactListener *)ptr) + i);
}

JPH_SoftBodyContactListener *JPH_SoftBodyContactListener_OffsetMutablePtr(JPH_SoftBodyContactListener *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodyContactListener *)(((JPH::SoftBodyContactListener *)ptr) + i);
}

JPH_SoftBodyContactListener *JPH_SoftBodyContactListener_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SoftBodyContactListener *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SoftBodyContactListener);
    return (JPH_SoftBodyContactListener *)new JPH::SoftBodyContactListener(JPH::SoftBodyContactListener(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SoftBodyContactListener) MRBINDC_CLASSARG_COPY(_other, (JPH::SoftBodyContactListener), JPH::SoftBodyContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SoftBodyContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SoftBodyContactListener) MRBINDC_CLASSARG_END(_other, JPH::SoftBodyContactListener))
    ));
}

void JPH_SoftBodyContactListener_Destroy(const JPH_SoftBodyContactListener *_this)
{
    delete ((const JPH::SoftBodyContactListener *)_this);
}

void JPH_SoftBodyContactListener_DestroyArray(const JPH_SoftBodyContactListener *_this)
{
    delete[] ((const JPH::SoftBodyContactListener *)_this);
}

JPH_SoftBodyContactListener *JPH_SoftBodyContactListener_AssignFromAnother(JPH_SoftBodyContactListener *_this, Jolt_PassBy _other_pass_by, JPH_SoftBodyContactListener *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SoftBodyContactListener);
    return (JPH_SoftBodyContactListener *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyContactListener *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SoftBodyContactListener) MRBINDC_CLASSARG_COPY(_other, (JPH::SoftBodyContactListener), JPH::SoftBodyContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SoftBodyContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SoftBodyContactListener) MRBINDC_CLASSARG_END(_other, JPH::SoftBodyContactListener)))
    ));
}

JPH_SoftBodyValidateResult JPH_SoftBodyContactListener_OnSoftBodyContactValidate(JPH_SoftBodyContactListener *_this, const JPH_Body *inSoftBody, const JPH_Body *inOtherBody, JPH_SoftBodyContactSettings *ioSettings)
{
    return (JPH_SoftBodyValidateResult)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyContactListener *)(_this)).OnSoftBodyContactValidate(
        ((inSoftBody ? void() : MRBINDC_THROW("Parameter `inSoftBody` can not be null.", void)), *(const JPH::Body *)(inSoftBody)),
        ((inOtherBody ? void() : MRBINDC_THROW("Parameter `inOtherBody` can not be null.", void)), *(const JPH::Body *)(inOtherBody)),
        ((ioSettings ? void() : MRBINDC_THROW("Parameter `ioSettings` can not be null.", void)), *(JPH::SoftBodyContactSettings *)(ioSettings))
    ));
}

void JPH_SoftBodyContactListener_OnSoftBodyContactAdded(JPH_SoftBodyContactListener *_this, const JPH_Body *inSoftBody, const JPH_SoftBodyManifold *inManifold)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyContactListener *)(_this)).OnSoftBodyContactAdded(
        ((inSoftBody ? void() : MRBINDC_THROW("Parameter `inSoftBody` can not be null.", void)), *(const JPH::Body *)(inSoftBody)),
        ((inManifold ? void() : MRBINDC_THROW("Parameter `inManifold` can not be null.", void)), *(const JPH::SoftBodyManifold *)(inManifold))
    );
}

