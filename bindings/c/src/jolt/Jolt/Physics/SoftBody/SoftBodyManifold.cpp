// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/SoftBody/SoftBodyManifold.h"

#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/SoftBody/SoftBodyManifold.h>
#include <Jolt/Physics/SoftBody/SoftBodyVertex.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <memory>
#include <stdexcept>


JPH_SoftBodyManifold *JPH_SoftBodyManifold_ConstructFromAnother(const JPH_SoftBodyManifold *_other)
{
    return (JPH_SoftBodyManifold *)new JPH::SoftBodyManifold(JPH::SoftBodyManifold(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodyManifold(*(JPH::SoftBodyManifold *)_other))
    ));
}

const JPH_SoftBodyManifold *JPH_SoftBodyManifold_OffsetPtr(const JPH_SoftBodyManifold *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodyManifold *)(((const JPH::SoftBodyManifold *)ptr) + i);
}

JPH_SoftBodyManifold *JPH_SoftBodyManifold_OffsetMutablePtr(JPH_SoftBodyManifold *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodyManifold *)(((JPH::SoftBodyManifold *)ptr) + i);
}

void JPH_SoftBodyManifold_Destroy(const JPH_SoftBodyManifold *_this)
{
    delete ((const JPH::SoftBodyManifold *)_this);
}

void JPH_SoftBodyManifold_DestroyArray(const JPH_SoftBodyManifold *_this)
{
    delete[] ((const JPH::SoftBodyManifold *)_this);
}

const Jolt_JPH_Array_JPH_SoftBodyVertex *JPH_SoftBodyManifold_GetVertices(const JPH_SoftBodyManifold *_this)
{
    return (const Jolt_JPH_Array_JPH_SoftBodyVertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyManifold *)(_this)).GetVertices());
}

bool JPH_SoftBodyManifold_HasContact(const JPH_SoftBodyManifold *_this, const JPH_SoftBodyVertex *inVertex)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyManifold *)(_this)).HasContact(
        ((inVertex ? void() : MRBINDC_THROW("Parameter `inVertex` can not be null.", void)), *(const JPH::SoftBodyVertex *)(inVertex))
    );
}

JPH_Vec3 *JPH_SoftBodyManifold_GetLocalContactPoint(const JPH_SoftBodyManifold *_this, const JPH_SoftBodyVertex *inVertex)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyManifold *)(_this)).GetLocalContactPoint(
        ((inVertex ? void() : MRBINDC_THROW("Parameter `inVertex` can not be null.", void)), *(const JPH::SoftBodyVertex *)(inVertex))
    ));
}

JPH_Vec3 *JPH_SoftBodyManifold_GetContactNormal(const JPH_SoftBodyManifold *_this, const JPH_SoftBodyVertex *inVertex)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyManifold *)(_this)).GetContactNormal(
        ((inVertex ? void() : MRBINDC_THROW("Parameter `inVertex` can not be null.", void)), *(const JPH::SoftBodyVertex *)(inVertex))
    ));
}

JPH_BodyID JPH_SoftBodyManifold_GetContactBodyID(const JPH_SoftBodyManifold *_this, const JPH_SoftBodyVertex *inVertex)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyManifold *)(_this)).GetContactBodyID(
        ((inVertex ? void() : MRBINDC_THROW("Parameter `inVertex` can not be null.", void)), *(const JPH::SoftBodyVertex *)(inVertex))
    ));
}

unsigned int JPH_SoftBodyManifold_GetNumSensorContacts(const JPH_SoftBodyManifold *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyManifold *)(_this)).GetNumSensorContacts();
}

JPH_BodyID JPH_SoftBodyManifold_GetSensorContactBodyID(const JPH_SoftBodyManifold *_this, unsigned int inIndex)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyManifold *)(_this)).GetSensorContactBodyID(
        inIndex
    ));
}

