// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/SoftBody/SoftBodyMotionProperties.h"

#include <Jolt/Core/TempAllocator.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/UVec4.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/MotionProperties.h>
#include <Jolt/Physics/Body/MotionQuality.h>
#include <Jolt/Physics/PhysicsSystem.h>
#include <Jolt/Physics/SoftBody/SoftBodyCreationSettings.h>
#include <Jolt/Physics/SoftBody/SoftBodyMotionProperties.h>
#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <Jolt/Physics/SoftBody/SoftBodyVertex.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <__mrbind_c_details.h>

#include <Jolt/Core/Array.h>
#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const unsigned int *JPH_SoftBodyMotionProperties_Get_cInactiveIndex(void)
{
    return std::addressof(JPH::SoftBodyMotionProperties::cInactiveIndex);
}

JPH_SoftBodyMotionProperties *JPH_SoftBodyMotionProperties_DefaultConstruct(void)
{
    using _mrbind_T = JPH::SoftBodyMotionProperties;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_SoftBodyMotionProperties*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_SoftBodyMotionProperties *JPH_SoftBodyMotionProperties_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodyMotionProperties *)(new JPH::SoftBodyMotionProperties[num_elems]);
}

const JPH_SoftBodyMotionProperties *JPH_SoftBodyMotionProperties_OffsetPtr(const JPH_SoftBodyMotionProperties *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodyMotionProperties *)(((const JPH::SoftBodyMotionProperties *)ptr) + i);
}

JPH_SoftBodyMotionProperties *JPH_SoftBodyMotionProperties_OffsetMutablePtr(JPH_SoftBodyMotionProperties *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodyMotionProperties *)(((JPH::SoftBodyMotionProperties *)ptr) + i);
}

const JPH_MotionProperties *JPH_SoftBodyMotionProperties_UpcastTo_JPH_MotionProperties(const JPH_SoftBodyMotionProperties *object)
{
    return (const JPH_MotionProperties *)(static_cast<const JPH::MotionProperties *>(
        ((const JPH::SoftBodyMotionProperties *)object)
    ));
}

JPH_MotionProperties *JPH_SoftBodyMotionProperties_MutableUpcastTo_JPH_MotionProperties(JPH_SoftBodyMotionProperties *object)
{
    return (JPH_MotionProperties *)(static_cast<JPH::MotionProperties *>(
        ((JPH::SoftBodyMotionProperties *)object)
    ));
}

const JPH_SoftBodyMotionProperties *JPH_SoftBodyMotionProperties_StaticDowncastFrom_JPH_MotionProperties(const JPH_MotionProperties *object)
{
    return (const JPH_SoftBodyMotionProperties *)(static_cast<const JPH::SoftBodyMotionProperties *>(
        ((const JPH::MotionProperties *)object)
    ));
}

JPH_SoftBodyMotionProperties *JPH_SoftBodyMotionProperties_MutableStaticDowncastFrom_JPH_MotionProperties(JPH_MotionProperties *object)
{
    return (JPH_SoftBodyMotionProperties *)(static_cast<JPH::SoftBodyMotionProperties *>(
        ((JPH::MotionProperties *)object)
    ));
}

void JPH_SoftBodyMotionProperties_Destroy(const JPH_SoftBodyMotionProperties *_this)
{
    delete ((const JPH::SoftBodyMotionProperties *)_this);
}

void JPH_SoftBodyMotionProperties_DestroyArray(const JPH_SoftBodyMotionProperties *_this)
{
    delete[] ((const JPH::SoftBodyMotionProperties *)_this);
}

void JPH_SoftBodyMotionProperties_Initialize(JPH_SoftBodyMotionProperties *_this, const JPH_SoftBodyCreationSettings *inSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).Initialize(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(inSettings))
    );
}

const JPH_SoftBodySharedSettings *JPH_SoftBodyMotionProperties_GetSettings(const JPH_SoftBodyMotionProperties *_this)
{
    return (const JPH_SoftBodySharedSettings *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetSettings());
}

const Jolt_JPH_Array_JPH_SoftBodyVertex *JPH_SoftBodyMotionProperties_GetVertices(const JPH_SoftBodyMotionProperties *_this)
{
    return (const Jolt_JPH_Array_JPH_SoftBodyVertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetVertices());
}

Jolt_JPH_Array_JPH_SoftBodyVertex *JPH_SoftBodyMotionProperties_GetVertices_mut(JPH_SoftBodyMotionProperties *_this)
{
    return (Jolt_JPH_Array_JPH_SoftBodyVertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).GetVertices());
}

const JPH_SoftBodyVertex *JPH_SoftBodyMotionProperties_GetVertex(const JPH_SoftBodyMotionProperties *_this, unsigned int inIndex)
{
    return (const JPH_SoftBodyVertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetVertex(
        inIndex
    ));
}

JPH_SoftBodyVertex *JPH_SoftBodyMotionProperties_GetVertex_mut(JPH_SoftBodyMotionProperties *_this, unsigned int inIndex)
{
    return (JPH_SoftBodyVertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).GetVertex(
        inIndex
    ));
}

JPH_Quat *JPH_SoftBodyMotionProperties_GetRodRotation(const JPH_SoftBodyMotionProperties *_this, unsigned int inIndex)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetRodRotation(
        inIndex
    ));
}

JPH_Vec3 *JPH_SoftBodyMotionProperties_GetRodAngularVelocity(const JPH_SoftBodyMotionProperties *_this, unsigned int inIndex)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetRodAngularVelocity(
        inIndex
    ));
}

const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *JPH_SoftBodyMotionProperties_GetFaces(const JPH_SoftBodyMotionProperties *_this)
{
    return (const Jolt_JPH_Array_JPH_SoftBodySharedSettings_Face *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetFaces());
}

const JPH_SoftBodySharedSettings_Face *JPH_SoftBodyMotionProperties_GetFace(const JPH_SoftBodyMotionProperties *_this, unsigned int inIndex)
{
    return (const JPH_SoftBodySharedSettings_Face *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetFace(
        inIndex
    ));
}

unsigned int JPH_SoftBodyMotionProperties_GetNumIterations(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetNumIterations();
}

void JPH_SoftBodyMotionProperties_SetNumIterations(JPH_SoftBodyMotionProperties *_this, unsigned int inNumIterations)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetNumIterations(
        inNumIterations
    );
}

float JPH_SoftBodyMotionProperties_GetPressure(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetPressure();
}

void JPH_SoftBodyMotionProperties_SetPressure(JPH_SoftBodyMotionProperties *_this, float inPressure)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetPressure(
        inPressure
    );
}

bool JPH_SoftBodyMotionProperties_GetUpdatePosition(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetUpdatePosition();
}

void JPH_SoftBodyMotionProperties_SetUpdatePosition(JPH_SoftBodyMotionProperties *_this, bool inUpdatePosition)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetUpdatePosition(
        inUpdatePosition
    );
}

bool JPH_SoftBodyMotionProperties_GetFacesDoubleSided(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetFacesDoubleSided();
}

void JPH_SoftBodyMotionProperties_SetFacesDoubleSided(JPH_SoftBodyMotionProperties *_this, bool inDoubleSided)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetFacesDoubleSided(
        inDoubleSided
    );
}

bool JPH_SoftBodyMotionProperties_GetEnableSkinConstraints(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetEnableSkinConstraints();
}

void JPH_SoftBodyMotionProperties_SetEnableSkinConstraints(JPH_SoftBodyMotionProperties *_this, bool inEnableSkinConstraints)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetEnableSkinConstraints(
        inEnableSkinConstraints
    );
}

float JPH_SoftBodyMotionProperties_GetSkinnedMaxDistanceMultiplier(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetSkinnedMaxDistanceMultiplier();
}

void JPH_SoftBodyMotionProperties_SetSkinnedMaxDistanceMultiplier(JPH_SoftBodyMotionProperties *_this, float inSkinnedMaxDistanceMultiplier)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetSkinnedMaxDistanceMultiplier(
        inSkinnedMaxDistanceMultiplier
    );
}

float JPH_SoftBodyMotionProperties_GetVertexRadius(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetVertexRadius();
}

void JPH_SoftBodyMotionProperties_SetVertexRadius(JPH_SoftBodyMotionProperties *_this, float inVertexRadius)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetVertexRadius(
        inVertexRadius
    );
}

const JPH_AABox *JPH_SoftBodyMotionProperties_GetLocalBounds(const JPH_SoftBodyMotionProperties *_this)
{
    return (const JPH_AABox *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetLocalBounds());
}

float JPH_SoftBodyMotionProperties_GetVolume(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetVolume();
}

void JPH_SoftBodyMotionProperties_CalculateMassAndInertia(JPH_SoftBodyMotionProperties *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).CalculateMassAndInertia();
}

void JPH_SoftBodyMotionProperties_DrawVertices(const JPH_SoftBodyMotionProperties *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).DrawVertices(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform))
    );
}

void JPH_SoftBodyMotionProperties_DrawVertexVelocities(const JPH_SoftBodyMotionProperties *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).DrawVertexVelocities(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform))
    );
}

void JPH_SoftBodyMotionProperties_DrawPredictedBounds(const JPH_SoftBodyMotionProperties *_this, JPH_DebugRenderer *inRenderer, const JPH_Mat44 *inCenterOfMassTransform)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).DrawPredictedBounds(
        ((JPH::DebugRenderer *)inRenderer),
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform))
    );
}

void JPH_SoftBodyMotionProperties_SkinVertices(JPH_SoftBodyMotionProperties *_this, const JPH_Mat44 *inCenterOfMassTransform, const JPH_Mat44 *inJointMatrices, unsigned int inNumJoints, bool inHardSkinAll, JPH_TempAllocator *ioTempAllocator)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SkinVertices(
        ((inCenterOfMassTransform ? void() : MRBINDC_THROW("Parameter `inCenterOfMassTransform` can not be null.", void)), *(const JPH::Mat44 *)(inCenterOfMassTransform)),
        ((const JPH::Mat44 *)inJointMatrices),
        inNumJoints,
        inHardSkinAll,
        ((ioTempAllocator ? void() : MRBINDC_THROW("Parameter `ioTempAllocator` can not be null.", void)), *(JPH::TempAllocator *)(ioTempAllocator))
    );
}

void JPH_SoftBodyMotionProperties_CustomUpdate(JPH_SoftBodyMotionProperties *_this, float inDeltaTime, JPH_Body *ioSoftBody, JPH_PhysicsSystem *inSystem)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).CustomUpdate(
        inDeltaTime,
        ((ioSoftBody ? void() : MRBINDC_THROW("Parameter `ioSoftBody` can not be null.", void)), *(JPH::Body *)(ioSoftBody)),
        ((inSystem ? void() : MRBINDC_THROW("Parameter `inSystem` can not be null.", void)), *(JPH::PhysicsSystem *)(inSystem))
    );
}

JPH_EMotionQuality JPH_SoftBodyMotionProperties_GetMotionQuality(const JPH_SoftBodyMotionProperties *_this)
{
    return (JPH_EMotionQuality)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetMotionQuality());
}

bool JPH_SoftBodyMotionProperties_GetAllowSleeping(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetAllowSleeping();
}

JPH_Vec3 *JPH_SoftBodyMotionProperties_GetLinearVelocity(const JPH_SoftBodyMotionProperties *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetLinearVelocity());
}

void JPH_SoftBodyMotionProperties_SetLinearVelocity(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inLinearVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetLinearVelocity(
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity))
    );
}

void JPH_SoftBodyMotionProperties_SetLinearVelocityClamped(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inLinearVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetLinearVelocityClamped(
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity))
    );
}

JPH_Vec3 *JPH_SoftBodyMotionProperties_GetAngularVelocity(const JPH_SoftBodyMotionProperties *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetAngularVelocity());
}

void JPH_SoftBodyMotionProperties_SetAngularVelocity(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetAngularVelocity(
        ((inAngularVelocity ? void() : MRBINDC_THROW("Parameter `inAngularVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocity))
    );
}

void JPH_SoftBodyMotionProperties_SetAngularVelocityClamped(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetAngularVelocityClamped(
        ((inAngularVelocity ? void() : MRBINDC_THROW("Parameter `inAngularVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocity))
    );
}

void JPH_SoftBodyMotionProperties_MoveKinematic(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inDeltaPosition, const JPH_Quat *inDeltaRotation, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).MoveKinematic(
        ((inDeltaPosition ? void() : MRBINDC_THROW("Parameter `inDeltaPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaPosition)),
        ((inDeltaRotation ? void() : MRBINDC_THROW("Parameter `inDeltaRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inDeltaRotation)),
        inDeltaTime
    );
}

float JPH_SoftBodyMotionProperties_GetMaxLinearVelocity(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetMaxLinearVelocity();
}

void JPH_SoftBodyMotionProperties_SetMaxLinearVelocity(JPH_SoftBodyMotionProperties *_this, float inLinearVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetMaxLinearVelocity(
        inLinearVelocity
    );
}

float JPH_SoftBodyMotionProperties_GetMaxAngularVelocity(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetMaxAngularVelocity();
}

void JPH_SoftBodyMotionProperties_SetMaxAngularVelocity(JPH_SoftBodyMotionProperties *_this, float inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetMaxAngularVelocity(
        inAngularVelocity
    );
}

void JPH_SoftBodyMotionProperties_ClampLinearVelocity(JPH_SoftBodyMotionProperties *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).ClampLinearVelocity();
}

void JPH_SoftBodyMotionProperties_ClampAngularVelocity(JPH_SoftBodyMotionProperties *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).ClampAngularVelocity();
}

float JPH_SoftBodyMotionProperties_GetLinearDamping(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetLinearDamping();
}

void JPH_SoftBodyMotionProperties_SetLinearDamping(JPH_SoftBodyMotionProperties *_this, float inLinearDamping)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetLinearDamping(
        inLinearDamping
    );
}

float JPH_SoftBodyMotionProperties_GetAngularDamping(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetAngularDamping();
}

void JPH_SoftBodyMotionProperties_SetAngularDamping(JPH_SoftBodyMotionProperties *_this, float inAngularDamping)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetAngularDamping(
        inAngularDamping
    );
}

float JPH_SoftBodyMotionProperties_GetGravityFactor(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetGravityFactor();
}

void JPH_SoftBodyMotionProperties_SetGravityFactor(JPH_SoftBodyMotionProperties *_this, float inGravityFactor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetGravityFactor(
        inGravityFactor
    );
}

float JPH_SoftBodyMotionProperties_GetInverseMass(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetInverseMass();
}

float JPH_SoftBodyMotionProperties_GetInverseMassUnchecked(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetInverseMassUnchecked();
}

void JPH_SoftBodyMotionProperties_SetInverseMass(JPH_SoftBodyMotionProperties *_this, float inInverseMass)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetInverseMass(
        inInverseMass
    );
}

JPH_Vec3 *JPH_SoftBodyMotionProperties_GetInverseInertiaDiagonal(const JPH_SoftBodyMotionProperties *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetInverseInertiaDiagonal());
}

JPH_Quat *JPH_SoftBodyMotionProperties_GetInertiaRotation(const JPH_SoftBodyMotionProperties *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetInertiaRotation());
}

void JPH_SoftBodyMotionProperties_SetInverseInertia(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inDiagonal, const JPH_Quat *inRot)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetInverseInertia(
        ((inDiagonal ? void() : MRBINDC_THROW("Parameter `inDiagonal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDiagonal)),
        ((inRot ? void() : MRBINDC_THROW("Parameter `inRot` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRot))
    );
}

void JPH_SoftBodyMotionProperties_ScaleToMass(JPH_SoftBodyMotionProperties *_this, float inMass)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).ScaleToMass(
        inMass
    );
}

JPH_Mat44 *JPH_SoftBodyMotionProperties_GetLocalSpaceInverseInertia(const JPH_SoftBodyMotionProperties *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetLocalSpaceInverseInertia());
}

JPH_Mat44 *JPH_SoftBodyMotionProperties_GetLocalSpaceInverseInertiaUnchecked(const JPH_SoftBodyMotionProperties *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetLocalSpaceInverseInertiaUnchecked());
}

JPH_Mat44 *JPH_SoftBodyMotionProperties_GetInverseInertiaForRotation(const JPH_SoftBodyMotionProperties *_this, const JPH_Mat44 *inRotation)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetInverseInertiaForRotation(
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), *(const JPH::Mat44 *)(inRotation))
    ));
}

JPH_Vec3 *JPH_SoftBodyMotionProperties_MultiplyWorldSpaceInverseInertiaByVector(const JPH_SoftBodyMotionProperties *_this, const JPH_Quat *inBodyRotation, const JPH_Vec3 *inV)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).MultiplyWorldSpaceInverseInertiaByVector(
        ((inBodyRotation ? void() : MRBINDC_THROW("Parameter `inBodyRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inBodyRotation)),
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

JPH_Vec3 *JPH_SoftBodyMotionProperties_GetPointVelocityCOM(const JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inPointRelativeToCOM)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetPointVelocityCOM(
        ((inPointRelativeToCOM ? void() : MRBINDC_THROW("Parameter `inPointRelativeToCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPointRelativeToCOM))
    ));
}

JPH_Vec3 *JPH_SoftBodyMotionProperties_GetAccumulatedForce(const JPH_SoftBodyMotionProperties *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetAccumulatedForce());
}

JPH_Vec3 *JPH_SoftBodyMotionProperties_GetAccumulatedTorque(const JPH_SoftBodyMotionProperties *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetAccumulatedTorque());
}

void JPH_SoftBodyMotionProperties_ResetForce(JPH_SoftBodyMotionProperties *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).ResetForce();
}

void JPH_SoftBodyMotionProperties_ResetTorque(JPH_SoftBodyMotionProperties *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).ResetTorque();
}

void JPH_SoftBodyMotionProperties_ResetMotion(JPH_SoftBodyMotionProperties *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).ResetMotion();
}

JPH_UVec4 *JPH_SoftBodyMotionProperties_GetLinearDOFsMask(const JPH_SoftBodyMotionProperties *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetLinearDOFsMask());
}

JPH_Vec3 *JPH_SoftBodyMotionProperties_LockTranslation(const JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inV)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).LockTranslation(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

JPH_UVec4 *JPH_SoftBodyMotionProperties_GetAngularDOFsMask(const JPH_SoftBodyMotionProperties *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetAngularDOFsMask());
}

JPH_Vec3 *JPH_SoftBodyMotionProperties_LockAngular(const JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inV)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).LockAngular(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

void JPH_SoftBodyMotionProperties_SetNumVelocityStepsOverride(JPH_SoftBodyMotionProperties *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_SoftBodyMotionProperties_GetNumVelocityStepsOverride(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_SoftBodyMotionProperties_SetNumPositionStepsOverride(JPH_SoftBodyMotionProperties *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_SoftBodyMotionProperties_GetNumPositionStepsOverride(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetNumPositionStepsOverride();
}

void JPH_SoftBodyMotionProperties_AddLinearVelocityStep(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inLinearVelocityChange)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).AddLinearVelocityStep(
        ((inLinearVelocityChange ? void() : MRBINDC_THROW("Parameter `inLinearVelocityChange` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocityChange))
    );
}

void JPH_SoftBodyMotionProperties_SubLinearVelocityStep(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inLinearVelocityChange)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SubLinearVelocityStep(
        ((inLinearVelocityChange ? void() : MRBINDC_THROW("Parameter `inLinearVelocityChange` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocityChange))
    );
}

void JPH_SoftBodyMotionProperties_AddAngularVelocityStep(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inAngularVelocityChange)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).AddAngularVelocityStep(
        ((inAngularVelocityChange ? void() : MRBINDC_THROW("Parameter `inAngularVelocityChange` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocityChange))
    );
}

void JPH_SoftBodyMotionProperties_SubAngularVelocityStep(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inAngularVelocityChange)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SubAngularVelocityStep(
        ((inAngularVelocityChange ? void() : MRBINDC_THROW("Parameter `inAngularVelocityChange` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocityChange))
    );
}

void JPH_SoftBodyMotionProperties_ApplyGyroscopicForceInternal(JPH_SoftBodyMotionProperties *_this, const JPH_Quat *inBodyRotation, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).ApplyGyroscopicForceInternal(
        ((inBodyRotation ? void() : MRBINDC_THROW("Parameter `inBodyRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inBodyRotation)),
        inDeltaTime
    );
}

void JPH_SoftBodyMotionProperties_ApplyForceTorqueAndDragInternal(JPH_SoftBodyMotionProperties *_this, const JPH_Quat *inBodyRotation, const JPH_Vec3 *inGravity, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).ApplyForceTorqueAndDragInternal(
        ((inBodyRotation ? void() : MRBINDC_THROW("Parameter `inBodyRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inBodyRotation)),
        ((inGravity ? void() : MRBINDC_THROW("Parameter `inGravity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inGravity)),
        inDeltaTime
    );
}

unsigned int JPH_SoftBodyMotionProperties_GetIslandIndexInternal(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetIslandIndexInternal();
}

void JPH_SoftBodyMotionProperties_SetIslandIndexInternal(JPH_SoftBodyMotionProperties *_this, unsigned int inIndex)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).SetIslandIndexInternal(
        inIndex
    );
}

unsigned int JPH_SoftBodyMotionProperties_GetIndexInActiveBodiesInternal(const JPH_SoftBodyMotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodyMotionProperties *)(_this)).GetIndexInActiveBodiesInternal();
}

void JPH_SoftBodyMotionProperties_ResetSleepTestSpheres(JPH_SoftBodyMotionProperties *_this, const JPH_Vec3 *inPoints)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).ResetSleepTestSpheres(
        ((const JPH::Vec3 *)inPoints)
    );
}

void JPH_SoftBodyMotionProperties_ResetSleepTestTimer(JPH_SoftBodyMotionProperties *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodyMotionProperties *)(_this)).ResetSleepTestTimer();
}

