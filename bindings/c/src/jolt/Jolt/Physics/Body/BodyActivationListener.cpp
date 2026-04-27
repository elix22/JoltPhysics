// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Body/BodyActivationListener.h"

#include <Jolt/Physics/Body/BodyActivationListener.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <stdexcept>


void JPH_BodyActivationListener_Destroy(const JPH_BodyActivationListener *_this)
{
    delete ((const JPH::BodyActivationListener *)_this);
}

void JPH_BodyActivationListener_DestroyArray(const JPH_BodyActivationListener *_this)
{
    delete[] ((const JPH::BodyActivationListener *)_this);
}

void JPH_BodyActivationListener_OnBodyActivated(JPH_BodyActivationListener *_this, const JPH_BodyID *inBodyID, uint64_t inBodyUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyActivationListener *)(_this)).OnBodyActivated(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        inBodyUserData
    );
}

void JPH_BodyActivationListener_OnBodyDeactivated(JPH_BodyActivationListener *_this, const JPH_BodyID *inBodyID, uint64_t inBodyUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyActivationListener *)(_this)).OnBodyDeactivated(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        inBodyUserData
    );
}

const JPH_BodyActivationListener *JPH_BodyActivationListener_OffsetPtr(const JPH_BodyActivationListener *ptr, ptrdiff_t i)
{
    return (const JPH_BodyActivationListener *)(((const JPH::BodyActivationListener *)ptr) + i);
}

JPH_BodyActivationListener *JPH_BodyActivationListener_OffsetMutablePtr(JPH_BodyActivationListener *ptr, ptrdiff_t i)
{
    return (JPH_BodyActivationListener *)(((JPH::BodyActivationListener *)ptr) + i);
}

