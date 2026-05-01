// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/SoftBody/SoftBodyVertex.h"

#include <Jolt/Geometry/Plane.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/SoftBody/SoftBodyVertex.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const JPH_Vec3 *JPH_SoftBodyVertex_Get_mPreviousPosition(const JPH_SoftBodyVertex *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyVertex *)(_this)).mPreviousPosition);
}

JPH_Vec3 *JPH_SoftBodyVertex_GetMutable_mPreviousPosition(JPH_SoftBodyVertex *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).mPreviousPosition);
}

const JPH_Vec3 *JPH_SoftBodyVertex_Get_mPosition(const JPH_SoftBodyVertex *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyVertex *)(_this)).mPosition);
}

JPH_Vec3 *JPH_SoftBodyVertex_GetMutable_mPosition(JPH_SoftBodyVertex *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).mPosition);
}

const JPH_Vec3 *JPH_SoftBodyVertex_Get_mVelocity(const JPH_SoftBodyVertex *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyVertex *)(_this)).mVelocity);
}

JPH_Vec3 *JPH_SoftBodyVertex_GetMutable_mVelocity(JPH_SoftBodyVertex *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).mVelocity);
}

const JPH_Plane *JPH_SoftBodyVertex_Get_mCollisionPlane(const JPH_SoftBodyVertex *_this)
{
    return (const JPH_Plane *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyVertex *)(_this)).mCollisionPlane);
}

void JPH_SoftBodyVertex_Set_mCollisionPlane(JPH_SoftBodyVertex *_this, const JPH_Plane *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).mCollisionPlane = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), JPH::Plane(*(JPH::Plane *)value));
}

JPH_Plane *JPH_SoftBodyVertex_GetMutable_mCollisionPlane(JPH_SoftBodyVertex *_this)
{
    return (JPH_Plane *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).mCollisionPlane);
}

const int *JPH_SoftBodyVertex_Get_mCollidingShapeIndex(const JPH_SoftBodyVertex *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyVertex *)(_this)).mCollidingShapeIndex);
}

void JPH_SoftBodyVertex_Set_mCollidingShapeIndex(JPH_SoftBodyVertex *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).mCollidingShapeIndex = value;
}

int *JPH_SoftBodyVertex_GetMutable_mCollidingShapeIndex(JPH_SoftBodyVertex *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).mCollidingShapeIndex);
}

const bool *JPH_SoftBodyVertex_Get_mHasContact(const JPH_SoftBodyVertex *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyVertex *)(_this)).mHasContact);
}

void JPH_SoftBodyVertex_Set_mHasContact(JPH_SoftBodyVertex *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).mHasContact = value;
}

bool *JPH_SoftBodyVertex_GetMutable_mHasContact(JPH_SoftBodyVertex *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).mHasContact);
}

const float *JPH_SoftBodyVertex_Get_mLargestPenetration(const JPH_SoftBodyVertex *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyVertex *)(_this)).mLargestPenetration);
}

void JPH_SoftBodyVertex_Set_mLargestPenetration(JPH_SoftBodyVertex *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).mLargestPenetration = value;
}

float *JPH_SoftBodyVertex_GetMutable_mLargestPenetration(JPH_SoftBodyVertex *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).mLargestPenetration);
}

const float *JPH_SoftBodyVertex_Get_mInvMass(const JPH_SoftBodyVertex *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyVertex *)(_this)).mInvMass);
}

void JPH_SoftBodyVertex_Set_mInvMass(JPH_SoftBodyVertex *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).mInvMass = value;
}

float *JPH_SoftBodyVertex_GetMutable_mInvMass(JPH_SoftBodyVertex *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).mInvMass);
}

JPH_SoftBodyVertex *JPH_SoftBodyVertex_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SoftBodyVertex;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SoftBodyVertex*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SoftBodyVertex *JPH_SoftBodyVertex_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodyVertex *)(new JPH::SoftBodyVertex[num_elems]{});
}

JPH_SoftBodyVertex *JPH_SoftBodyVertex_ConstructFrom(const JPH_Vec3 *mPreviousPosition, const JPH_Vec3 *mPosition, const JPH_Vec3 *mVelocity, const JPH_Plane *mCollisionPlane, int mCollidingShapeIndex, bool mHasContact, float mLargestPenetration, float mInvMass)
{
    return (JPH_SoftBodyVertex *)new JPH::SoftBodyVertex(JPH::SoftBodyVertex{
        ((mPreviousPosition ? void() : MRBINDC_THROW("Parameter `mPreviousPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mPreviousPosition)),
        ((mPosition ? void() : MRBINDC_THROW("Parameter `mPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mPosition)),
        ((mVelocity ? void() : MRBINDC_THROW("Parameter `mVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mVelocity)),
        ((mCollisionPlane ? void() : MRBINDC_THROW("Parameter `mCollisionPlane` can not be null.", void)), JPH::Plane(*(JPH::Plane *)mCollisionPlane)),
        mCollidingShapeIndex,
        mHasContact,
        mLargestPenetration,
        mInvMass
    });
}

const JPH_SoftBodyVertex *JPH_SoftBodyVertex_OffsetPtr(const JPH_SoftBodyVertex *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodyVertex *)(((const JPH::SoftBodyVertex *)ptr) + i);
}

JPH_SoftBodyVertex *JPH_SoftBodyVertex_OffsetMutablePtr(JPH_SoftBodyVertex *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodyVertex *)(((JPH::SoftBodyVertex *)ptr) + i);
}

JPH_SoftBodyVertex *JPH_SoftBodyVertex_ConstructFromAnother(const JPH_SoftBodyVertex *_other)
{
    return (JPH_SoftBodyVertex *)new JPH::SoftBodyVertex(JPH::SoftBodyVertex(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodyVertex(*(JPH::SoftBodyVertex *)_other))
    ));
}

void JPH_SoftBodyVertex_Destroy(const JPH_SoftBodyVertex *_this)
{
    delete ((const JPH::SoftBodyVertex *)_this);
}

void JPH_SoftBodyVertex_DestroyArray(const JPH_SoftBodyVertex *_this)
{
    delete[] ((const JPH::SoftBodyVertex *)_this);
}

JPH_SoftBodyVertex *JPH_SoftBodyVertex_AssignFromAnother(JPH_SoftBodyVertex *_this, const JPH_SoftBodyVertex *_other)
{
    return (JPH_SoftBodyVertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodyVertex(*(JPH::SoftBodyVertex *)_other))
    ));
}

void JPH_SoftBodyVertex_ResetCollision(JPH_SoftBodyVertex *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyVertex *)(_this)).ResetCollision();
}

