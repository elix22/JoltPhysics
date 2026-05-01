// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/PhysicsStepListener.h"

#include <Jolt/Physics/PhysicsStepListener.h>
#include <Jolt/Physics/PhysicsSystem.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const float *JPH_PhysicsStepListenerContext_Get_mDeltaTime(const JPH_PhysicsStepListenerContext *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsStepListenerContext *)(_this)).mDeltaTime);
}

void JPH_PhysicsStepListenerContext_Set_mDeltaTime(JPH_PhysicsStepListenerContext *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsStepListenerContext *)(_this)).mDeltaTime = value;
}

float *JPH_PhysicsStepListenerContext_GetMutable_mDeltaTime(JPH_PhysicsStepListenerContext *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsStepListenerContext *)(_this)).mDeltaTime);
}

const bool *JPH_PhysicsStepListenerContext_Get_mIsFirstStep(const JPH_PhysicsStepListenerContext *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsStepListenerContext *)(_this)).mIsFirstStep);
}

void JPH_PhysicsStepListenerContext_Set_mIsFirstStep(JPH_PhysicsStepListenerContext *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsStepListenerContext *)(_this)).mIsFirstStep = value;
}

bool *JPH_PhysicsStepListenerContext_GetMutable_mIsFirstStep(JPH_PhysicsStepListenerContext *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsStepListenerContext *)(_this)).mIsFirstStep);
}

const bool *JPH_PhysicsStepListenerContext_Get_mIsLastStep(const JPH_PhysicsStepListenerContext *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsStepListenerContext *)(_this)).mIsLastStep);
}

void JPH_PhysicsStepListenerContext_Set_mIsLastStep(JPH_PhysicsStepListenerContext *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsStepListenerContext *)(_this)).mIsLastStep = value;
}

bool *JPH_PhysicsStepListenerContext_GetMutable_mIsLastStep(JPH_PhysicsStepListenerContext *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsStepListenerContext *)(_this)).mIsLastStep);
}

JPH_PhysicsSystem *const *JPH_PhysicsStepListenerContext_Get_mPhysicsSystem(const JPH_PhysicsStepListenerContext *_this)
{
    return (JPH_PhysicsSystem *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsStepListenerContext *)(_this)).mPhysicsSystem);
}

void JPH_PhysicsStepListenerContext_Set_mPhysicsSystem(JPH_PhysicsStepListenerContext *_this, JPH_PhysicsSystem *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsStepListenerContext *)(_this)).mPhysicsSystem = ((JPH::PhysicsSystem *)value);
}

JPH_PhysicsSystem **JPH_PhysicsStepListenerContext_GetMutable_mPhysicsSystem(JPH_PhysicsStepListenerContext *_this)
{
    return (JPH_PhysicsSystem **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsStepListenerContext *)(_this)).mPhysicsSystem);
}

JPH_PhysicsStepListenerContext *JPH_PhysicsStepListenerContext_DefaultConstruct(void)
{
    using _mrbind_T = JPH::PhysicsStepListenerContext;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_PhysicsStepListenerContext*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_PhysicsStepListenerContext *JPH_PhysicsStepListenerContext_DefaultConstructArray(size_t num_elems)
{
    return (JPH_PhysicsStepListenerContext *)(new JPH::PhysicsStepListenerContext[num_elems]{});
}

JPH_PhysicsStepListenerContext *JPH_PhysicsStepListenerContext_ConstructFrom(float mDeltaTime, bool mIsFirstStep, bool mIsLastStep, JPH_PhysicsSystem *mPhysicsSystem)
{
    return (JPH_PhysicsStepListenerContext *)new JPH::PhysicsStepListenerContext(JPH::PhysicsStepListenerContext{
        mDeltaTime,
        mIsFirstStep,
        mIsLastStep,
        ((JPH::PhysicsSystem *)mPhysicsSystem)
    });
}

const JPH_PhysicsStepListenerContext *JPH_PhysicsStepListenerContext_OffsetPtr(const JPH_PhysicsStepListenerContext *ptr, ptrdiff_t i)
{
    return (const JPH_PhysicsStepListenerContext *)(((const JPH::PhysicsStepListenerContext *)ptr) + i);
}

JPH_PhysicsStepListenerContext *JPH_PhysicsStepListenerContext_OffsetMutablePtr(JPH_PhysicsStepListenerContext *ptr, ptrdiff_t i)
{
    return (JPH_PhysicsStepListenerContext *)(((JPH::PhysicsStepListenerContext *)ptr) + i);
}

JPH_PhysicsStepListenerContext *JPH_PhysicsStepListenerContext_ConstructFromAnother(const JPH_PhysicsStepListenerContext *_other)
{
    return (JPH_PhysicsStepListenerContext *)new JPH::PhysicsStepListenerContext(JPH::PhysicsStepListenerContext(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::PhysicsStepListenerContext(*(JPH::PhysicsStepListenerContext *)_other))
    ));
}

void JPH_PhysicsStepListenerContext_Destroy(const JPH_PhysicsStepListenerContext *_this)
{
    delete ((const JPH::PhysicsStepListenerContext *)_this);
}

void JPH_PhysicsStepListenerContext_DestroyArray(const JPH_PhysicsStepListenerContext *_this)
{
    delete[] ((const JPH::PhysicsStepListenerContext *)_this);
}

JPH_PhysicsStepListenerContext *JPH_PhysicsStepListenerContext_AssignFromAnother(JPH_PhysicsStepListenerContext *_this, const JPH_PhysicsStepListenerContext *_other)
{
    return (JPH_PhysicsStepListenerContext *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsStepListenerContext *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::PhysicsStepListenerContext(*(JPH::PhysicsStepListenerContext *)_other))
    ));
}

void JPH_PhysicsStepListener_Destroy(const JPH_PhysicsStepListener *_this)
{
    delete ((const JPH::PhysicsStepListener *)_this);
}

void JPH_PhysicsStepListener_DestroyArray(const JPH_PhysicsStepListener *_this)
{
    delete[] ((const JPH::PhysicsStepListener *)_this);
}

void JPH_PhysicsStepListener_OnStep(JPH_PhysicsStepListener *_this, const JPH_PhysicsStepListenerContext *inContext)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsStepListener *)(_this)).OnStep(
        ((inContext ? void() : MRBINDC_THROW("Parameter `inContext` can not be null.", void)), *(const JPH::PhysicsStepListenerContext *)(inContext))
    );
}

const JPH_PhysicsStepListener *JPH_PhysicsStepListener_OffsetPtr(const JPH_PhysicsStepListener *ptr, ptrdiff_t i)
{
    return (const JPH_PhysicsStepListener *)(((const JPH::PhysicsStepListener *)ptr) + i);
}

JPH_PhysicsStepListener *JPH_PhysicsStepListener_OffsetMutablePtr(JPH_PhysicsStepListener *ptr, ptrdiff_t i)
{
    return (JPH_PhysicsStepListener *)(((JPH::PhysicsStepListener *)ptr) + i);
}

