// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Body/Body.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
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

JPH_Vec3 *JPH_Body_GetLinearVelocity(const JPH_Body *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetLinearVelocity());
}

void JPH_Body_SetLinearVelocity(JPH_Body *_this, const JPH_Vec3 *inLinearVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetLinearVelocity(
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity))
    );
}

void JPH_Body_SetLinearVelocityClamped(JPH_Body *_this, const JPH_Vec3 *inLinearVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetLinearVelocityClamped(
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity))
    );
}

JPH_Vec3 *JPH_Body_GetAngularVelocity(const JPH_Body *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetAngularVelocity());
}

void JPH_Body_SetAngularVelocity(JPH_Body *_this, const JPH_Vec3 *inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetAngularVelocity(
        ((inAngularVelocity ? void() : MRBINDC_THROW("Parameter `inAngularVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocity))
    );
}

void JPH_Body_SetAngularVelocityClamped(JPH_Body *_this, const JPH_Vec3 *inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetAngularVelocityClamped(
        ((inAngularVelocity ? void() : MRBINDC_THROW("Parameter `inAngularVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocity))
    );
}

JPH_Vec3 *JPH_Body_GetPointVelocityCOM(const JPH_Body *_this, const JPH_Vec3 *inPointRelativeToCOM)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetPointVelocityCOM(
        ((inPointRelativeToCOM ? void() : MRBINDC_THROW("Parameter `inPointRelativeToCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPointRelativeToCOM))
    ));
}

JPH_Vec3 *JPH_Body_GetPointVelocity(const JPH_Body *_this, const JPH_Vec3 *inPoint)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetPointVelocity(
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPoint))
    ));
}

void JPH_Body_AddForce_1(JPH_Body *_this, const JPH_Vec3 *inForce)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).AddForce(
        ((inForce ? void() : MRBINDC_THROW("Parameter `inForce` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inForce))
    );
}

void JPH_Body_AddForce_2(JPH_Body *_this, const JPH_Vec3 *inForce, const JPH_Vec3 *inPosition)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).AddForce(
        ((inForce ? void() : MRBINDC_THROW("Parameter `inForce` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inForce)),
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition))
    );
}

void JPH_Body_AddTorque(JPH_Body *_this, const JPH_Vec3 *inTorque)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).AddTorque(
        ((inTorque ? void() : MRBINDC_THROW("Parameter `inTorque` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTorque))
    );
}

JPH_Vec3 *JPH_Body_GetAccumulatedForce(const JPH_Body *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetAccumulatedForce());
}

JPH_Vec3 *JPH_Body_GetAccumulatedTorque(const JPH_Body *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetAccumulatedTorque());
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

JPH_Mat44 *JPH_Body_GetInverseInertia(const JPH_Body *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetInverseInertia());
}

void JPH_Body_AddImpulse_1(JPH_Body *_this, const JPH_Vec3 *inImpulse)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).AddImpulse(
        ((inImpulse ? void() : MRBINDC_THROW("Parameter `inImpulse` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inImpulse))
    );
}

void JPH_Body_AddImpulse_2(JPH_Body *_this, const JPH_Vec3 *inImpulse, const JPH_Vec3 *inPosition)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).AddImpulse(
        ((inImpulse ? void() : MRBINDC_THROW("Parameter `inImpulse` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inImpulse)),
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition))
    );
}

void JPH_Body_AddAngularImpulse(JPH_Body *_this, const JPH_Vec3 *inAngularImpulse)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).AddAngularImpulse(
        ((inAngularImpulse ? void() : MRBINDC_THROW("Parameter `inAngularImpulse` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularImpulse))
    );
}

void JPH_Body_MoveKinematic(JPH_Body *_this, const JPH_Vec3 *inTargetPosition, const JPH_Quat *inTargetRotation, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).MoveKinematic(
        ((inTargetPosition ? void() : MRBINDC_THROW("Parameter `inTargetPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTargetPosition)),
        ((inTargetRotation ? void() : MRBINDC_THROW("Parameter `inTargetRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inTargetRotation)),
        inDeltaTime
    );
}

void JPH_Body_GetSubmergedVolume(const JPH_Body *_this, const JPH_Vec3 *inSurfacePosition, const JPH_Vec3 *inSurfaceNormal, float *outTotalVolume, float *outSubmergedVolume, JPH_Vec3 *outRelativeCenterOfBuoyancy)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetSubmergedVolume(
        ((inSurfacePosition ? void() : MRBINDC_THROW("Parameter `inSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inSurfacePosition)),
        ((inSurfaceNormal ? void() : MRBINDC_THROW("Parameter `inSurfaceNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inSurfaceNormal)),
        ((outTotalVolume ? void() : MRBINDC_THROW("Parameter `outTotalVolume` can not be null.", void)), *outTotalVolume),
        ((outSubmergedVolume ? void() : MRBINDC_THROW("Parameter `outSubmergedVolume` can not be null.", void)), *outSubmergedVolume),
        ((outRelativeCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `outRelativeCenterOfBuoyancy` can not be null.", void)), *(JPH::Vec3 *)(outRelativeCenterOfBuoyancy))
    );
}

bool JPH_Body_ApplyBuoyancyImpulse_8(JPH_Body *_this, const JPH_Vec3 *inSurfacePosition, const JPH_Vec3 *inSurfaceNormal, float inBuoyancy, float inLinearDrag, float inAngularDrag, const JPH_Vec3 *inFluidVelocity, const JPH_Vec3 *inGravity, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).ApplyBuoyancyImpulse(
        ((inSurfacePosition ? void() : MRBINDC_THROW("Parameter `inSurfacePosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inSurfacePosition)),
        ((inSurfaceNormal ? void() : MRBINDC_THROW("Parameter `inSurfaceNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inSurfaceNormal)),
        inBuoyancy,
        inLinearDrag,
        inAngularDrag,
        ((inFluidVelocity ? void() : MRBINDC_THROW("Parameter `inFluidVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inFluidVelocity)),
        ((inGravity ? void() : MRBINDC_THROW("Parameter `inGravity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inGravity)),
        inDeltaTime
    );
}

bool JPH_Body_ApplyBuoyancyImpulse_9(JPH_Body *_this, float inTotalVolume, float inSubmergedVolume, const JPH_Vec3 *inRelativeCenterOfBuoyancy, float inBuoyancy, float inLinearDrag, float inAngularDrag, const JPH_Vec3 *inFluidVelocity, const JPH_Vec3 *inGravity, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).ApplyBuoyancyImpulse(
        inTotalVolume,
        inSubmergedVolume,
        ((inRelativeCenterOfBuoyancy ? void() : MRBINDC_THROW("Parameter `inRelativeCenterOfBuoyancy` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inRelativeCenterOfBuoyancy)),
        inBuoyancy,
        inLinearDrag,
        inAngularDrag,
        ((inFluidVelocity ? void() : MRBINDC_THROW("Parameter `inFluidVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inFluidVelocity)),
        ((inGravity ? void() : MRBINDC_THROW("Parameter `inGravity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inGravity)),
        inDeltaTime
    );
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

JPH_Vec3 *JPH_Body_GetPosition(const JPH_Body *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetPosition());
}

JPH_Quat *JPH_Body_GetRotation(const JPH_Body *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetRotation());
}

JPH_Mat44 *JPH_Body_GetWorldTransform(const JPH_Body *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetWorldTransform());
}

JPH_Vec3 *JPH_Body_GetCenterOfMassPosition(const JPH_Body *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetCenterOfMassPosition());
}

JPH_Mat44 *JPH_Body_GetCenterOfMassTransform(const JPH_Body *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetCenterOfMassTransform());
}

JPH_Mat44 *JPH_Body_GetInverseCenterOfMassTransform(const JPH_Body *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetInverseCenterOfMassTransform());
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

JPH_Vec3 *JPH_Body_GetWorldSpaceSurfaceNormal(const JPH_Body *_this, const JPH_SubShapeID *inSubShapeID, const JPH_Vec3 *inPosition)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::Body *)(_this)).GetWorldSpaceSurfaceNormal(
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID)),
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition))
    ));
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

void JPH_Body_AddPositionStep(JPH_Body *_this, const JPH_Vec3 *inLinearVelocityTimesDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).AddPositionStep(
        ((inLinearVelocityTimesDeltaTime ? void() : MRBINDC_THROW("Parameter `inLinearVelocityTimesDeltaTime` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocityTimesDeltaTime))
    );
}

void JPH_Body_SubPositionStep(JPH_Body *_this, const JPH_Vec3 *inLinearVelocityTimesDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SubPositionStep(
        ((inLinearVelocityTimesDeltaTime ? void() : MRBINDC_THROW("Parameter `inLinearVelocityTimesDeltaTime` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocityTimesDeltaTime))
    );
}

void JPH_Body_AddRotationStep(JPH_Body *_this, const JPH_Vec3 *inAngularVelocityTimesDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).AddRotationStep(
        ((inAngularVelocityTimesDeltaTime ? void() : MRBINDC_THROW("Parameter `inAngularVelocityTimesDeltaTime` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocityTimesDeltaTime))
    );
}

void JPH_Body_SubRotationStep(JPH_Body *_this, const JPH_Vec3 *inAngularVelocityTimesDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SubRotationStep(
        ((inAngularVelocityTimesDeltaTime ? void() : MRBINDC_THROW("Parameter `inAngularVelocityTimesDeltaTime` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocityTimesDeltaTime))
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

void JPH_Body_SetPositionAndRotationInternal(JPH_Body *_this, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const bool *inResetSleepTimer)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).SetPositionAndRotationInternal(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        (inResetSleepTimer ? *inResetSleepTimer : static_cast<bool>(true))
    );
}

void JPH_Body_UpdateCenterOfMassInternal(JPH_Body *_this, const JPH_Vec3 *inPreviousCenterOfMass, bool inUpdateMassProperties)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::Body *)(_this)).UpdateCenterOfMassInternal(
        ((inPreviousCenterOfMass ? void() : MRBINDC_THROW("Parameter `inPreviousCenterOfMass` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPreviousCenterOfMass)),
        inUpdateMassProperties
    );
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

