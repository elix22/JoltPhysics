// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Body/Body.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyCreationSettings.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>
#include <Jolt/Physics/Collision/CollisionGroup.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/SoftBody/SoftBodyCreationSettings.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


const JPH_Body *JPH_Body_Get_sFixedToWorld(void)
{
    return (const JPH_Body *)std::addressof(JPH::Body::sFixedToWorld);
}

JPH_Body *JPH_Body_GetMutable_sFixedToWorld(void)
{
    return (JPH_Body *)std::addressof(JPH::Body::sFixedToWorld);
}

const unsigned int *JPH_Body_Get_cInactiveIndex(void)
{
    return std::addressof(JPH::Body::cInactiveIndex);
}

void *Jolt_new_JPH_Body_size_t(unsigned long inCount)
{
    return JPH::Body::operator new(
        inCount
    );
}

void Jolt_delete_JPH_Body_void_ptr(void *inPointer)
{
    JPH::Body::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_Body_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::Body::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_Body_size_t(unsigned long inCount)
{
    return JPH::Body::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_Body_void_ptr(void *inPointer)
{
    JPH::Body::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_Body_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::Body::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_Body_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::Body::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_Body_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Body::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_Body_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::Body::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_Body_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::Body::operator delete[](
        inPointer,
        inPlace
    );
}

const JPH_BodyID *JPH_Body_GetID(const JPH_Body *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetID());
}

bool JPH_Body_IsRigidBody(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).IsRigidBody();
}

bool JPH_Body_IsSoftBody(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).IsSoftBody();
}

bool JPH_Body_IsActive(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).IsActive();
}

bool JPH_Body_IsStatic(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).IsStatic();
}

bool JPH_Body_IsKinematic(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).IsKinematic();
}

bool JPH_Body_IsDynamic(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).IsDynamic();
}

bool JPH_Body_CanBeKinematicOrDynamic(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).CanBeKinematicOrDynamic();
}

void JPH_Body_SetIsSensor(JPH_Body *_this, bool inIsSensor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetIsSensor(
        inIsSensor
    );
}

bool JPH_Body_IsSensor(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).IsSensor();
}

void JPH_Body_SetCollideKinematicVsNonDynamic(JPH_Body *_this, bool inCollide)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetCollideKinematicVsNonDynamic(
        inCollide
    );
}

bool JPH_Body_GetCollideKinematicVsNonDynamic(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetCollideKinematicVsNonDynamic();
}

void JPH_Body_SetUseManifoldReduction(JPH_Body *_this, bool inUseReduction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetUseManifoldReduction(
        inUseReduction
    );
}

bool JPH_Body_GetUseManifoldReduction(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetUseManifoldReduction();
}

bool JPH_Body_GetUseManifoldReductionWithBody(const JPH_Body *_this, const JPH_Body *inBody2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetUseManifoldReductionWithBody(
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2))
    );
}

void JPH_Body_SetApplyGyroscopicForce(JPH_Body *_this, bool inApply)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetApplyGyroscopicForce(
        inApply
    );
}

bool JPH_Body_GetApplyGyroscopicForce(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetApplyGyroscopicForce();
}

void JPH_Body_SetEnhancedInternalEdgeRemoval(JPH_Body *_this, bool inApply)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetEnhancedInternalEdgeRemoval(
        inApply
    );
}

bool JPH_Body_GetEnhancedInternalEdgeRemoval(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetEnhancedInternalEdgeRemoval();
}

bool JPH_Body_GetEnhancedInternalEdgeRemovalWithBody(const JPH_Body *_this, const JPH_Body *inBody2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetEnhancedInternalEdgeRemovalWithBody(
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2))
    );
}

JPH_BroadPhaseLayer *JPH_Body_GetBroadPhaseLayer(const JPH_Body *_this)
{
    return (JPH_BroadPhaseLayer *)new JPH::BroadPhaseLayer(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetBroadPhaseLayer());
}

unsigned short JPH_Body_GetObjectLayer(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetObjectLayer();
}

const JPH_CollisionGroup *JPH_Body_GetCollisionGroup(const JPH_Body *_this)
{
    return (const JPH_CollisionGroup *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetCollisionGroup());
}

JPH_CollisionGroup *JPH_Body_GetCollisionGroup_mut(JPH_Body *_this)
{
    return (JPH_CollisionGroup *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).GetCollisionGroup());
}

void JPH_Body_SetCollisionGroup(JPH_Body *_this, const JPH_CollisionGroup *inGroup)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetCollisionGroup(
        ((inGroup ? void() : MRBINDC_THROW("Parameter `inGroup` can not be null.", void)), *(const JPH::CollisionGroup *)(inGroup))
    );
}

bool JPH_Body_GetAllowSleeping(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetAllowSleeping();
}

void JPH_Body_SetAllowSleeping(JPH_Body *_this, bool inAllow)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetAllowSleeping(
        inAllow
    );
}

void JPH_Body_ResetSleepTimer(JPH_Body *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).ResetSleepTimer();
}

float JPH_Body_GetFriction(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetFriction();
}

void JPH_Body_SetFriction(JPH_Body *_this, float inFriction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetFriction(
        inFriction
    );
}

float JPH_Body_GetRestitution(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetRestitution();
}

void JPH_Body_SetRestitution(JPH_Body *_this, float inRestitution)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetRestitution(
        inRestitution
    );
}

void JPH_Body_ResetForce(JPH_Body *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).ResetForce();
}

void JPH_Body_ResetTorque(JPH_Body *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).ResetTorque();
}

void JPH_Body_ResetMotion(JPH_Body *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).ResetMotion();
}

bool JPH_Body_IsInBroadPhase(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).IsInBroadPhase();
}

bool JPH_Body_IsCollisionCacheInvalid(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).IsCollisionCacheInvalid();
}

const JPH_Shape *JPH_Body_GetShape(const JPH_Body *_this)
{
    return (const JPH_Shape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetShape());
}

const JPH_AABox *JPH_Body_GetWorldSpaceBounds(const JPH_Body *_this)
{
    return (const JPH_AABox *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetWorldSpaceBounds());
}

uint64_t JPH_Body_GetUserData(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetUserData();
}

void JPH_Body_SetUserData(JPH_Body *_this, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetUserData(
        inUserData
    );
}

JPH_BodyCreationSettings *JPH_Body_GetBodyCreationSettings(const JPH_Body *_this)
{
    return (JPH_BodyCreationSettings *)new JPH::BodyCreationSettings(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetBodyCreationSettings());
}

JPH_SoftBodyCreationSettings *JPH_Body_GetSoftBodyCreationSettings(const JPH_Body *_this)
{
    return (JPH_SoftBodyCreationSettings *)new JPH::SoftBodyCreationSettings(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetSoftBodyCreationSettings());
}

bool JPH_Body_sFindCollidingPairsCanCollide(const JPH_Body *inBody1, const JPH_Body *inBody2)
{
    return JPH::Body::sFindCollidingPairsCanCollide(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(const JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2))
    );
}

void JPH_Body_SetInBroadPhaseInternal(JPH_Body *_this, bool inInBroadPhase)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetInBroadPhaseInternal(
        inInBroadPhase
    );
}

bool JPH_Body_InvalidateContactCacheInternal(JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).InvalidateContactCacheInternal();
}

void JPH_Body_ValidateContactCacheInternal(JPH_Body *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).ValidateContactCacheInternal();
}

void JPH_Body_CalculateWorldSpaceBoundsInternal(JPH_Body *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).CalculateWorldSpaceBoundsInternal();
}

void JPH_Body_SetShapeInternal(JPH_Body *_this, const JPH_Shape *inShape, bool inUpdateMassProperties)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetShapeInternal(
        ((const JPH::Shape *)inShape),
        inUpdateMassProperties
    );
}

unsigned int JPH_Body_GetIndexInActiveBodiesInternal(const JPH_Body *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetIndexInActiveBodiesInternal();
}

const JPH_Body *JPH_Body_OffsetPtr(const JPH_Body *ptr, ptrdiff_t i)
{
    return (const JPH_Body *)(((const JPH::Body *)ptr) + i);
}

JPH_Body *JPH_Body_OffsetMutablePtr(JPH_Body *ptr, ptrdiff_t i)
{
    return (JPH_Body *)(((JPH::Body *)ptr) + i);
}

const JPH_NonCopyable *JPH_Body_UpcastTo_JPH_NonCopyable(const JPH_Body *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::Body *)object)
    ));
}

JPH_NonCopyable *JPH_Body_MutableUpcastTo_JPH_NonCopyable(JPH_Body *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::Body *)object)
    ));
}

const JPH_Body *JPH_Body_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_Body *)(static_cast<const JPH::Body *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_Body *JPH_Body_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_Body *)(static_cast<JPH::Body *>(
        ((JPH::NonCopyable *)object)
    ));
}

