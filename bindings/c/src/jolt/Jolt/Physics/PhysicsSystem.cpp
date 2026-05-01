// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/PhysicsSystem.h"

#include <Jolt/Core/JobSystem.h>
#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/TempAllocator.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyActivationListener.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Body/BodyInterface.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseQuery.h>
#include <Jolt/Physics/Collision/CollideShape.h>
#include <Jolt/Physics/Collision/ContactListener.h>
#include <Jolt/Physics/Collision/NarrowPhaseQuery.h>
#include <Jolt/Physics/Collision/ObjectLayer.h>
#include <Jolt/Physics/Constraints/Constraint.h>
#include <Jolt/Physics/EPhysicsUpdateError.h>
#include <Jolt/Physics/PhysicsSettings.h>
#include <Jolt/Physics/PhysicsStepListener.h>
#include <Jolt/Physics/PhysicsSystem.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


const unsigned int *JPH_PhysicsSystem_Get_cMaxBodiesLimit(void)
{
    return std::addressof(JPH::PhysicsSystem::cMaxBodiesLimit);
}

const unsigned int *JPH_PhysicsSystem_Get_cMaxBodyPairsLimit(void)
{
    return std::addressof(JPH::PhysicsSystem::cMaxBodyPairsLimit);
}

const unsigned int *JPH_PhysicsSystem_Get_cMaxContactConstraintsLimit(void)
{
    return std::addressof(JPH::PhysicsSystem::cMaxContactConstraintsLimit);
}

JPH_PhysicsSystem *JPH_PhysicsSystem_DefaultConstruct(void)
{
    return (JPH_PhysicsSystem *)new JPH::PhysicsSystem(JPH::PhysicsSystem());
}

JPH_PhysicsSystem *JPH_PhysicsSystem_DefaultConstructArray(size_t num_elems)
{
    return (JPH_PhysicsSystem *)(new JPH::PhysicsSystem[num_elems]{});
}

const JPH_PhysicsSystem *JPH_PhysicsSystem_OffsetPtr(const JPH_PhysicsSystem *ptr, ptrdiff_t i)
{
    return (const JPH_PhysicsSystem *)(((const JPH::PhysicsSystem *)ptr) + i);
}

JPH_PhysicsSystem *JPH_PhysicsSystem_OffsetMutablePtr(JPH_PhysicsSystem *ptr, ptrdiff_t i)
{
    return (JPH_PhysicsSystem *)(((JPH::PhysicsSystem *)ptr) + i);
}

const JPH_NonCopyable *JPH_PhysicsSystem_UpcastTo_JPH_NonCopyable(const JPH_PhysicsSystem *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::PhysicsSystem *)object)
    ));
}

JPH_NonCopyable *JPH_PhysicsSystem_MutableUpcastTo_JPH_NonCopyable(JPH_PhysicsSystem *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::PhysicsSystem *)object)
    ));
}

const JPH_PhysicsSystem *JPH_PhysicsSystem_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_PhysicsSystem *)(static_cast<const JPH::PhysicsSystem *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_PhysicsSystem *JPH_PhysicsSystem_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_PhysicsSystem *)(static_cast<JPH::PhysicsSystem *>(
        ((JPH::NonCopyable *)object)
    ));
}

void JPH_PhysicsSystem_Destroy(const JPH_PhysicsSystem *_this)
{
    delete ((const JPH::PhysicsSystem *)_this);
}

void JPH_PhysicsSystem_DestroyArray(const JPH_PhysicsSystem *_this)
{
    delete[] ((const JPH::PhysicsSystem *)_this);
}

void *Jolt_new_JPH_PhysicsSystem_size_t(size_t inCount)
{
    return JPH::PhysicsSystem::operator new(
        inCount
    );
}

void Jolt_delete_JPH_PhysicsSystem_void_ptr(void *inPointer)
{
    JPH::PhysicsSystem::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_PhysicsSystem_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PhysicsSystem::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_PhysicsSystem_size_t(size_t inCount)
{
    return JPH::PhysicsSystem::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_PhysicsSystem_void_ptr(void *inPointer)
{
    JPH::PhysicsSystem::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_PhysicsSystem_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::PhysicsSystem::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_PhysicsSystem_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PhysicsSystem::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_PhysicsSystem_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PhysicsSystem::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_PhysicsSystem_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::PhysicsSystem::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_PhysicsSystem_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::PhysicsSystem::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_PhysicsSystem_Init(JPH_PhysicsSystem *_this, unsigned int inMaxBodies, unsigned int inNumBodyMutexes, unsigned int inMaxBodyPairs, unsigned int inMaxContactConstraints, const JPH_BroadPhaseLayerInterface *inBroadPhaseLayerInterface, const JPH_ObjectVsBroadPhaseLayerFilter *inObjectVsBroadPhaseLayerFilter, const JPH_ObjectLayerPairFilter *inObjectLayerPairFilter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).Init(
        inMaxBodies,
        inNumBodyMutexes,
        inMaxBodyPairs,
        inMaxContactConstraints,
        ((inBroadPhaseLayerInterface ? void() : MRBINDC_THROW("Parameter `inBroadPhaseLayerInterface` can not be null.", void)), *(const JPH::BroadPhaseLayerInterface *)(inBroadPhaseLayerInterface)),
        ((inObjectVsBroadPhaseLayerFilter ? void() : MRBINDC_THROW("Parameter `inObjectVsBroadPhaseLayerFilter` can not be null.", void)), *(const JPH::ObjectVsBroadPhaseLayerFilter *)(inObjectVsBroadPhaseLayerFilter)),
        ((inObjectLayerPairFilter ? void() : MRBINDC_THROW("Parameter `inObjectLayerPairFilter` can not be null.", void)), *(const JPH::ObjectLayerPairFilter *)(inObjectLayerPairFilter))
    );
}

void JPH_PhysicsSystem_SetBodyActivationListener(JPH_PhysicsSystem *_this, JPH_BodyActivationListener *inListener)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).SetBodyActivationListener(
        ((JPH::BodyActivationListener *)inListener)
    );
}

JPH_BodyActivationListener *JPH_PhysicsSystem_GetBodyActivationListener(const JPH_PhysicsSystem *_this)
{
    return (JPH_BodyActivationListener *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetBodyActivationListener());
}

void JPH_PhysicsSystem_SetContactListener(JPH_PhysicsSystem *_this, JPH_ContactListener *inListener)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).SetContactListener(
        ((JPH::ContactListener *)inListener)
    );
}

JPH_ContactListener *JPH_PhysicsSystem_GetContactListener(const JPH_PhysicsSystem *_this)
{
    return (JPH_ContactListener *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetContactListener());
}

void JPH_PhysicsSystem_SetPhysicsSettings(JPH_PhysicsSystem *_this, const JPH_PhysicsSettings *inSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).SetPhysicsSettings(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::PhysicsSettings *)(inSettings))
    );
}

const JPH_PhysicsSettings *JPH_PhysicsSystem_GetPhysicsSettings(const JPH_PhysicsSystem *_this)
{
    return (const JPH_PhysicsSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetPhysicsSettings());
}

const JPH_BodyInterface *JPH_PhysicsSystem_GetBodyInterface(const JPH_PhysicsSystem *_this)
{
    return (const JPH_BodyInterface *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetBodyInterface());
}

JPH_BodyInterface *JPH_PhysicsSystem_GetBodyInterface_mut(JPH_PhysicsSystem *_this)
{
    return (JPH_BodyInterface *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).GetBodyInterface());
}

const JPH_BodyInterface *JPH_PhysicsSystem_GetBodyInterfaceNoLock(const JPH_PhysicsSystem *_this)
{
    return (const JPH_BodyInterface *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetBodyInterfaceNoLock());
}

JPH_BodyInterface *JPH_PhysicsSystem_GetBodyInterfaceNoLock_mut(JPH_PhysicsSystem *_this)
{
    return (JPH_BodyInterface *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).GetBodyInterfaceNoLock());
}

const JPH_BroadPhaseQuery *JPH_PhysicsSystem_GetBroadPhaseQuery(const JPH_PhysicsSystem *_this)
{
    return (const JPH_BroadPhaseQuery *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetBroadPhaseQuery());
}

const JPH_NarrowPhaseQuery *JPH_PhysicsSystem_GetNarrowPhaseQuery(const JPH_PhysicsSystem *_this)
{
    return (const JPH_NarrowPhaseQuery *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetNarrowPhaseQuery());
}

const JPH_NarrowPhaseQuery *JPH_PhysicsSystem_GetNarrowPhaseQueryNoLock(const JPH_PhysicsSystem *_this)
{
    return (const JPH_NarrowPhaseQuery *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetNarrowPhaseQueryNoLock());
}

void JPH_PhysicsSystem_AddConstraint(JPH_PhysicsSystem *_this, JPH_Constraint *inConstraint)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).AddConstraint(
        ((JPH::Constraint *)inConstraint)
    );
}

void JPH_PhysicsSystem_RemoveConstraint(JPH_PhysicsSystem *_this, JPH_Constraint *inConstraint)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).RemoveConstraint(
        ((JPH::Constraint *)inConstraint)
    );
}

void JPH_PhysicsSystem_AddConstraints(JPH_PhysicsSystem *_this, JPH_Constraint **inConstraints, int inNumber)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).AddConstraints(
        ((JPH::Constraint **)inConstraints),
        inNumber
    );
}

void JPH_PhysicsSystem_RemoveConstraints(JPH_PhysicsSystem *_this, JPH_Constraint **inConstraints, int inNumber)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).RemoveConstraints(
        ((JPH::Constraint **)inConstraints),
        inNumber
    );
}

void JPH_PhysicsSystem_OptimizeBroadPhase(JPH_PhysicsSystem *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).OptimizeBroadPhase();
}

void JPH_PhysicsSystem_AddStepListener(JPH_PhysicsSystem *_this, JPH_PhysicsStepListener *inListener)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).AddStepListener(
        ((JPH::PhysicsStepListener *)inListener)
    );
}

void JPH_PhysicsSystem_RemoveStepListener(JPH_PhysicsSystem *_this, JPH_PhysicsStepListener *inListener)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).RemoveStepListener(
        ((JPH::PhysicsStepListener *)inListener)
    );
}

JPH_EPhysicsUpdateError JPH_PhysicsSystem_Update(JPH_PhysicsSystem *_this, float inDeltaTime, int inCollisionSteps, JPH_TempAllocator *inTempAllocator, JPH_JobSystem *inJobSystem)
{
    return (JPH_EPhysicsUpdateError)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).Update(
        inDeltaTime,
        inCollisionSteps,
        ((JPH::TempAllocator *)inTempAllocator),
        ((JPH::JobSystem *)inJobSystem)
    ));
}

void JPH_PhysicsSystem_SetGravity(JPH_PhysicsSystem *_this, const JPH_Vec3 *inGravity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::PhysicsSystem *)(_this)).SetGravity(
        ((inGravity ? void() : MRBINDC_THROW("Parameter `inGravity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inGravity))
    );
}

JPH_Vec3 *JPH_PhysicsSystem_GetGravity(const JPH_PhysicsSystem *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetGravity());
}

const JPH_ObjectVsBroadPhaseLayerFilter *JPH_PhysicsSystem_GetObjectVsBroadPhaseLayerFilter(const JPH_PhysicsSystem *_this)
{
    return (const JPH_ObjectVsBroadPhaseLayerFilter *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetObjectVsBroadPhaseLayerFilter());
}

const JPH_ObjectLayerPairFilter *JPH_PhysicsSystem_GetObjectLayerPairFilter(const JPH_PhysicsSystem *_this)
{
    return (const JPH_ObjectLayerPairFilter *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetObjectLayerPairFilter());
}

JPH_DefaultBroadPhaseLayerFilter *JPH_PhysicsSystem_GetDefaultBroadPhaseLayerFilter(const JPH_PhysicsSystem *_this, unsigned short inLayer)
{
    return (JPH_DefaultBroadPhaseLayerFilter *)new JPH::DefaultBroadPhaseLayerFilter(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetDefaultBroadPhaseLayerFilter(
        inLayer
    ));
}

JPH_DefaultObjectLayerFilter *JPH_PhysicsSystem_GetDefaultLayerFilter(const JPH_PhysicsSystem *_this, unsigned short inLayer)
{
    return (JPH_DefaultObjectLayerFilter *)new JPH::DefaultObjectLayerFilter(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetDefaultLayerFilter(
        inLayer
    ));
}

unsigned int JPH_PhysicsSystem_GetNumBodies(const JPH_PhysicsSystem *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetNumBodies();
}

unsigned int JPH_PhysicsSystem_GetMaxBodies(const JPH_PhysicsSystem *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetMaxBodies();
}

bool JPH_PhysicsSystem_WereBodiesInContact(const JPH_PhysicsSystem *_this, const JPH_BodyID *inBody1ID, const JPH_BodyID *inBody2ID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).WereBodiesInContact(
        ((inBody1ID ? void() : MRBINDC_THROW("Parameter `inBody1ID` can not be null.", void)), *(const JPH::BodyID *)(inBody1ID)),
        ((inBody2ID ? void() : MRBINDC_THROW("Parameter `inBody2ID` can not be null.", void)), *(const JPH::BodyID *)(inBody2ID))
    );
}

JPH_AABox *JPH_PhysicsSystem_GetBounds(const JPH_PhysicsSystem *_this)
{
    return (JPH_AABox *)new JPH::AABox(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::PhysicsSystem *)(_this)).GetBounds());
}

