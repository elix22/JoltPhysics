// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/jolt_init_wrapper.h"

#include <Jolt/Core/Color.h>
#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Geometry/RayAABox.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyCreationSettings.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Character/CharacterBase.h>
#include <Jolt/Physics/Collision/CollideShape.h>
#include <Jolt/Physics/Collision/ContactListener.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/ConvexHullShape.h>
#include <Jolt/Physics/Collision/Shape/HeightFieldShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeIDPair.h>
#include <Jolt/Physics/PhysicsStepListener.h>
#include <Jolt/Physics/PhysicsSystem.h>
#include <Jolt/Physics/Ragdoll/Ragdoll.h>
#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <Jolt/Physics/Vehicle/TrackedVehicleController.h>
#include <Jolt/Physics/Vehicle/VehicleAntiRollBar.h>
#include <Jolt/Physics/Vehicle/VehicleConstraint.h>
#include <Jolt/Physics/Vehicle/VehicleDifferential.h>
#include <Jolt/Physics/Vehicle/VehicleTrack.h>
#include <Jolt/Physics/Vehicle/VehicleTransmission.h>
#include <Jolt/Physics/Vehicle/WheeledVehicleController.h>
#include <Jolt/Renderer/DebugRenderer.h>
#include <Jolt/Renderer/DebugRendererSimple.h>
#include <Jolt/Skeleton/Skeleton.h>
#include <__mrbind_c_details.h>
#include <jolt_init_wrapper.h>

#include <cstddef>
#include <cstring>
#include <functional>
#include <memory>
#include <new>
#include <stdexcept>


JoltHelpers *JoltHelpers_DefaultConstruct(void)
{
    using _mrbind_T = JoltHelpers;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JoltHelpers*)(::new(_mrbind_ptr) _mrbind_T());
}

JoltHelpers *JoltHelpers_DefaultConstructArray(size_t num_elems)
{
    return (JoltHelpers *)(new JoltHelpers[num_elems]);
}

const JoltHelpers *JoltHelpers_OffsetPtr(const JoltHelpers *ptr, ptrdiff_t i)
{
    return (const JoltHelpers *)(((const JoltHelpers *)ptr) + i);
}

JoltHelpers *JoltHelpers_OffsetMutablePtr(JoltHelpers *ptr, ptrdiff_t i)
{
    return (JoltHelpers *)(((JoltHelpers *)ptr) + i);
}

JoltHelpers *JoltHelpers_ConstructFromAnother(const JoltHelpers *_other)
{
    return (JoltHelpers *)new JoltHelpers(JoltHelpers(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltHelpers(*(JoltHelpers *)_other))
    ));
}

void JoltHelpers_Destroy(const JoltHelpers *_this)
{
    delete ((const JoltHelpers *)_this);
}

void JoltHelpers_DestroyArray(const JoltHelpers *_this)
{
    delete[] ((const JoltHelpers *)_this);
}

JoltHelpers *JoltHelpers_AssignFromAnother(JoltHelpers *_this, const JoltHelpers *_other)
{
    return (JoltHelpers *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltHelpers *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltHelpers(*(JoltHelpers *)_other))
    ));
}

void JoltHelpers_Init(void)
{
    JoltHelpers::Init();
}

void JoltHelpers_Shutdown(void)
{
    JoltHelpers::Shutdown();
}

float JoltHelpers_RayAABox(const JPH_Vec3 *inOrigin, const JPH_RayInvDirection *inInvDirection, const JPH_Vec3 *inBoundsMin, const JPH_Vec3 *inBoundsMax)
{
    return JoltHelpers::RayAABox(
        ((inOrigin ? void() : MRBINDC_THROW("Parameter `inOrigin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOrigin)),
        ((inInvDirection ? void() : MRBINDC_THROW("Parameter `inInvDirection` can not be null.", void)), *(const JPH::RayInvDirection *)(inInvDirection)),
        ((inBoundsMin ? void() : MRBINDC_THROW("Parameter `inBoundsMin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBoundsMin)),
        ((inBoundsMax ? void() : MRBINDC_THROW("Parameter `inBoundsMax` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBoundsMax))
    );
}

void JoltHelpers_VehicleSettingsAddWheel(JPH_VehicleConstraintSettings *settings, JPH_WheelSettingsWV *wheel)
{
    JoltHelpers::VehicleSettingsAddWheel(
        ((settings ? void() : MRBINDC_THROW("Parameter `settings` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(settings)),
        ((JPH::WheelSettingsWV *)wheel)
    );
}

void JoltHelpers_VehicleSettingsAddWheelTV(JPH_VehicleConstraintSettings *settings, JPH_WheelSettingsTV *wheel)
{
    JoltHelpers::VehicleSettingsAddWheelTV(
        ((settings ? void() : MRBINDC_THROW("Parameter `settings` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(settings)),
        ((JPH::WheelSettingsTV *)wheel)
    );
}

void JoltHelpers_VehicleSettingsSetController(JPH_VehicleConstraintSettings *settings, JPH_WheeledVehicleControllerSettings *ctrl)
{
    JoltHelpers::VehicleSettingsSetController(
        ((settings ? void() : MRBINDC_THROW("Parameter `settings` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(settings)),
        ((JPH::WheeledVehicleControllerSettings *)ctrl)
    );
}

void JoltHelpers_VehicleSettingsSetTrackedController(JPH_VehicleConstraintSettings *settings, JPH_TrackedVehicleControllerSettings *ctrl)
{
    JoltHelpers::VehicleSettingsSetTrackedController(
        ((settings ? void() : MRBINDC_THROW("Parameter `settings` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(settings)),
        ((JPH::TrackedVehicleControllerSettings *)ctrl)
    );
}

void JoltHelpers_VehicleTrackSettingsAddWheelIndex(JPH_VehicleTrackSettings *track, unsigned int wheelIndex)
{
    JoltHelpers::VehicleTrackSettingsAddWheelIndex(
        ((track ? void() : MRBINDC_THROW("Parameter `track` can not be null.", void)), *(JPH::VehicleTrackSettings *)(track)),
        wheelIndex
    );
}

void JoltHelpers_VehicleSettingsAddAntiRollBar(JPH_VehicleConstraintSettings *settings, const JPH_VehicleAntiRollBar *bar)
{
    JoltHelpers::VehicleSettingsAddAntiRollBar(
        ((settings ? void() : MRBINDC_THROW("Parameter `settings` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(settings)),
        ((bar ? void() : MRBINDC_THROW("Parameter `bar` can not be null.", void)), *(const JPH::VehicleAntiRollBar *)(bar))
    );
}

void JoltHelpers_WheeledControllerSettingsAddDifferential(JPH_WheeledVehicleControllerSettings *settings, const JPH_VehicleDifferentialSettings *diff)
{
    JoltHelpers::WheeledControllerSettingsAddDifferential(
        ((settings ? void() : MRBINDC_THROW("Parameter `settings` can not be null.", void)), *(JPH::WheeledVehicleControllerSettings *)(settings)),
        ((diff ? void() : MRBINDC_THROW("Parameter `diff` can not be null.", void)), *(const JPH::VehicleDifferentialSettings *)(diff))
    );
}

JPH_WheeledVehicleController *JoltHelpers_VehicleConstraintGetWheeledController(JPH_VehicleConstraint *constraint)
{
    return (JPH_WheeledVehicleController *)(JoltHelpers::VehicleConstraintGetWheeledController(
        ((constraint ? void() : MRBINDC_THROW("Parameter `constraint` can not be null.", void)), *(JPH::VehicleConstraint *)(constraint))
    ));
}

void JoltHelpers_VehicleTransmissionSettingsSetGearRatios(JPH_VehicleTransmissionSettings *inSettings, const float *inRatios, unsigned int inCount)
{
    JoltHelpers::VehicleTransmissionSettingsSetGearRatios(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(inSettings)),
        inRatios,
        inCount
    );
}

void JoltHelpers_VehicleTransmissionSettingsSetReverseGearRatios(JPH_VehicleTransmissionSettings *inSettings, const float *inRatios, unsigned int inCount)
{
    JoltHelpers::VehicleTransmissionSettingsSetReverseGearRatios(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(JPH::VehicleTransmissionSettings *)(inSettings)),
        inRatios,
        inCount
    );
}

void JoltHelpers_BodyCreationSettingsSetOverrideMassProperties(JPH_BodyCreationSettings *inSettings, int inMode)
{
    JoltHelpers::BodyCreationSettingsSetOverrideMassProperties(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(JPH::BodyCreationSettings *)(inSettings)),
        inMode
    );
}

void JoltHelpers_BodyCreationSettingsSetMassOverride(JPH_BodyCreationSettings *inSettings, float inMass)
{
    JoltHelpers::BodyCreationSettingsSetMassOverride(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(JPH::BodyCreationSettings *)(inSettings)),
        inMass
    );
}

float JoltHelpers_BodyCreationSettingsGetMassOverride(const JPH_BodyCreationSettings *inSettings)
{
    return JoltHelpers::BodyCreationSettingsGetMassOverride(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::BodyCreationSettings *)(inSettings))
    );
}

void JoltHelpers_HeightFieldSettingsSetHeightSamples(JPH_HeightFieldShapeSettings *inSettings, const float *inSamples, unsigned int inCount)
{
    JoltHelpers::HeightFieldSettingsSetHeightSamples(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(inSettings)),
        inSamples,
        inCount
    );
}

void JoltHelpers_HeightFieldSettingsResizeHeightSamples(JPH_HeightFieldShapeSettings *inSettings, unsigned int inCount, float inFillValue)
{
    JoltHelpers::HeightFieldSettingsResizeHeightSamples(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(inSettings)),
        inCount,
        inFillValue
    );
}

void JoltHelpers_HeightFieldSettingsSetHeightSampleAt(JPH_HeightFieldShapeSettings *inSettings, unsigned int inIndex, float inValue)
{
    JoltHelpers::HeightFieldSettingsSetHeightSampleAt(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(JPH::HeightFieldShapeSettings *)(inSettings)),
        inIndex,
        inValue
    );
}

unsigned int JoltHelpers_HeightFieldSettingsGetHeightSamplesCount(const JPH_HeightFieldShapeSettings *inSettings)
{
    return JoltHelpers::HeightFieldSettingsGetHeightSamplesCount(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(inSettings))
    );
}

float JoltHelpers_HeightFieldSettingsGetHeightSample(const JPH_HeightFieldShapeSettings *inSettings, unsigned int inIndex)
{
    return JoltHelpers::HeightFieldSettingsGetHeightSample(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::HeightFieldShapeSettings *)(inSettings)),
        inIndex
    );
}

float JoltHelpers_HeightFieldShapeConstantsNoCollisionValue(void)
{
    return JoltHelpers::HeightFieldShapeConstantsNoCollisionValue();
}

JPH_Vec3 *JoltHelpers_HeightFieldShapeGetPosition(const JPH_Shape *inShape, unsigned int inX, unsigned int inY)
{
    return (JPH_Vec3 *)new JPH::Vec3(JoltHelpers::HeightFieldShapeGetPosition(
        ((inShape ? void() : MRBINDC_THROW("Parameter `inShape` can not be null.", void)), *(const JPH::Shape *)(inShape)),
        inX,
        inY
    ));
}

bool JoltHelpers_HeightFieldShapeIsNoCollision(const JPH_Shape *inShape, unsigned int inX, unsigned int inY)
{
    return JoltHelpers::HeightFieldShapeIsNoCollision(
        ((inShape ? void() : MRBINDC_THROW("Parameter `inShape` can not be null.", void)), *(const JPH::Shape *)(inShape)),
        inX,
        inY
    );
}

void JoltHelpers_SoftBodySettingsAddVertex(JPH_SoftBodySharedSettings *inSettings, const JPH_SoftBodySharedSettings_Vertex *inVertex)
{
    JoltHelpers::SoftBodySettingsAddVertex(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(JPH::SoftBodySharedSettings *)(inSettings)),
        ((inVertex ? void() : MRBINDC_THROW("Parameter `inVertex` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Vertex *)(inVertex))
    );
}

unsigned int JoltHelpers_SoftBodySettingsGetVertexCount(const JPH_SoftBodySharedSettings *inSettings)
{
    return JoltHelpers::SoftBodySettingsGetVertexCount(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::SoftBodySharedSettings *)(inSettings))
    );
}

JPH_SoftBodySharedSettings *JoltHelpers_SoftBodySettingsCreateCube(unsigned int inGridSize, float inGridSpacing)
{
    return (JPH_SoftBodySharedSettings *)(JoltHelpers::SoftBodySettingsCreateCube(
        inGridSize,
        inGridSpacing
    ));
}

unsigned int JoltHelpers_BodyGetSoftBodyVertexCount(const JPH_Body *inBody)
{
    return JoltHelpers::BodyGetSoftBodyVertexCount(
        ((inBody ? void() : MRBINDC_THROW("Parameter `inBody` can not be null.", void)), *(const JPH::Body *)(inBody))
    );
}

JPH_Vec3 *JoltHelpers_BodyGetSoftBodyVertexPosition(const JPH_Body *inBody, unsigned int inIndex)
{
    return (JPH_Vec3 *)new JPH::Vec3(JoltHelpers::BodyGetSoftBodyVertexPosition(
        ((inBody ? void() : MRBINDC_THROW("Parameter `inBody` can not be null.", void)), *(const JPH::Body *)(inBody)),
        inIndex
    ));
}

void JoltHelpers_BodySetSoftBodyVertexPosition(JPH_Body *inBody, unsigned int inIndex, const JPH_Vec3 *inPosition)
{
    JoltHelpers::BodySetSoftBodyVertexPosition(
        ((inBody ? void() : MRBINDC_THROW("Parameter `inBody` can not be null.", void)), *(JPH::Body *)(inBody)),
        inIndex,
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition))
    );
}

float JoltHelpers_BodyGetInverseMass(const JPH_Body *inBody)
{
    return JoltHelpers::BodyGetInverseMass(
        ((inBody ? void() : MRBINDC_THROW("Parameter `inBody` can not be null.", void)), *(const JPH::Body *)(inBody))
    );
}

unsigned int JoltHelpers_PhysicsSystemGetSoftBodyVertexCount(const JPH_PhysicsSystem *inSystem, const JPH_BodyID *inBodyID)
{
    return JoltHelpers::PhysicsSystemGetSoftBodyVertexCount(
        ((inSystem ? void() : MRBINDC_THROW("Parameter `inSystem` can not be null.", void)), *(const JPH::PhysicsSystem *)(inSystem)),
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

JPH_Vec3 *JoltHelpers_PhysicsSystemGetSoftBodyVertexPosition(const JPH_PhysicsSystem *inSystem, const JPH_BodyID *inBodyID, unsigned int inIndex)
{
    return (JPH_Vec3 *)new JPH::Vec3(JoltHelpers::PhysicsSystemGetSoftBodyVertexPosition(
        ((inSystem ? void() : MRBINDC_THROW("Parameter `inSystem` can not be null.", void)), *(const JPH::PhysicsSystem *)(inSystem)),
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        inIndex
    ));
}

void JoltHelpers_CharacterBaseSettingsSetShape(JPH_CharacterBaseSettings *inSettings, const JPH_Shape *inShape)
{
    JoltHelpers::CharacterBaseSettingsSetShape(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(JPH::CharacterBaseSettings *)(inSettings)),
        ((const JPH::Shape *)inShape)
    );
}

void JoltHelpers_RagdollSettingsSetSkeleton(JPH_RagdollSettings *inSettings, JPH_Skeleton *inSkeleton)
{
    JoltHelpers::RagdollSettingsSetSkeleton(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(JPH::RagdollSettings *)(inSettings)),
        ((JPH::Skeleton *)inSkeleton)
    );
}

JPH_Skeleton *JoltHelpers_RagdollSettingsGetSkeleton(const JPH_RagdollSettings *inSettings)
{
    return (JPH_Skeleton *)(JoltHelpers::RagdollSettingsGetSkeleton(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::RagdollSettings *)(inSettings))
    ));
}

void JoltHelpers_RagdollSettingsAddPart(JPH_RagdollSettings *inSettings, const JPH_RagdollSettings_Part *inPart)
{
    JoltHelpers::RagdollSettingsAddPart(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(JPH::RagdollSettings *)(inSettings)),
        ((inPart ? void() : MRBINDC_THROW("Parameter `inPart` can not be null.", void)), *(const JPH::RagdollSettings::Part *)(inPart))
    );
}

unsigned int JoltHelpers_RagdollSettingsGetPartCount(const JPH_RagdollSettings *inSettings)
{
    return JoltHelpers::RagdollSettingsGetPartCount(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::RagdollSettings *)(inSettings))
    );
}

const JPH_RagdollSettings_Part *JoltHelpers_RagdollSettingsGetPart(const JPH_RagdollSettings *inSettings, unsigned int inIndex)
{
    return (const JPH_RagdollSettings_Part *)std::addressof(JoltHelpers::RagdollSettingsGetPart(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::RagdollSettings *)(inSettings)),
        inIndex
    ));
}

unsigned int JoltHelpers_SkeletonAddJoint(JPH_Skeleton *inSkeleton, const char *inName)
{
    return JoltHelpers::SkeletonAddJoint(
        ((inSkeleton ? void() : MRBINDC_THROW("Parameter `inSkeleton` can not be null.", void)), *(JPH::Skeleton *)(inSkeleton)),
        inName
    );
}

unsigned int JoltHelpers_SkeletonAddJointWithParentName(JPH_Skeleton *inSkeleton, const char *inName, const char *inParentName)
{
    return JoltHelpers::SkeletonAddJointWithParentName(
        ((inSkeleton ? void() : MRBINDC_THROW("Parameter `inSkeleton` can not be null.", void)), *(JPH::Skeleton *)(inSkeleton)),
        inName,
        inParentName
    );
}

unsigned int JoltHelpers_SkeletonAddJointWithParentIndex(JPH_Skeleton *inSkeleton, const char *inName, int inParentIndex)
{
    return JoltHelpers::SkeletonAddJointWithParentIndex(
        ((inSkeleton ? void() : MRBINDC_THROW("Parameter `inSkeleton` can not be null.", void)), *(JPH::Skeleton *)(inSkeleton)),
        inName,
        inParentIndex
    );
}

JPH_ConvexHullShapeSettings *JoltHelpers_ConvexHullShapeSettingsFromFloat3Array(const JPH_Float3 *inPoints, int inNumPoints, float inMaxConvexRadius, const JPH_PhysicsMaterial *inMaterial)
{
    return (JPH_ConvexHullShapeSettings *)(JoltHelpers::ConvexHullShapeSettingsFromFloat3Array(
        ((const JPH::Float3 *)inPoints),
        inNumPoints,
        inMaxConvexRadius,
        ((const JPH::PhysicsMaterial *)inMaterial)
    ));
}

const int *CountingPhysicsStepListener_Get_mCount(const CountingPhysicsStepListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const CountingPhysicsStepListener *)(_this)).mCount);
}

void CountingPhysicsStepListener_Set_mCount(CountingPhysicsStepListener *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(CountingPhysicsStepListener *)(_this)).mCount = value;
}

int *CountingPhysicsStepListener_GetMutable_mCount(CountingPhysicsStepListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(CountingPhysicsStepListener *)(_this)).mCount);
}

const float *CountingPhysicsStepListener_Get_mLastDeltaTime(const CountingPhysicsStepListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const CountingPhysicsStepListener *)(_this)).mLastDeltaTime);
}

void CountingPhysicsStepListener_Set_mLastDeltaTime(CountingPhysicsStepListener *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(CountingPhysicsStepListener *)(_this)).mLastDeltaTime = value;
}

float *CountingPhysicsStepListener_GetMutable_mLastDeltaTime(CountingPhysicsStepListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(CountingPhysicsStepListener *)(_this)).mLastDeltaTime);
}

const bool *CountingPhysicsStepListener_Get_mLastIsFirst(const CountingPhysicsStepListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const CountingPhysicsStepListener *)(_this)).mLastIsFirst);
}

void CountingPhysicsStepListener_Set_mLastIsFirst(CountingPhysicsStepListener *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(CountingPhysicsStepListener *)(_this)).mLastIsFirst = value;
}

bool *CountingPhysicsStepListener_GetMutable_mLastIsFirst(CountingPhysicsStepListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(CountingPhysicsStepListener *)(_this)).mLastIsFirst);
}

const bool *CountingPhysicsStepListener_Get_mLastIsLast(const CountingPhysicsStepListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const CountingPhysicsStepListener *)(_this)).mLastIsLast);
}

void CountingPhysicsStepListener_Set_mLastIsLast(CountingPhysicsStepListener *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(CountingPhysicsStepListener *)(_this)).mLastIsLast = value;
}

bool *CountingPhysicsStepListener_GetMutable_mLastIsLast(CountingPhysicsStepListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(CountingPhysicsStepListener *)(_this)).mLastIsLast);
}

CountingPhysicsStepListener *CountingPhysicsStepListener_DefaultConstruct(void)
{
    using _mrbind_T = CountingPhysicsStepListener;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (CountingPhysicsStepListener*)(::new(_mrbind_ptr) _mrbind_T());
}

CountingPhysicsStepListener *CountingPhysicsStepListener_DefaultConstructArray(size_t num_elems)
{
    return (CountingPhysicsStepListener *)(new CountingPhysicsStepListener[num_elems]);
}

const CountingPhysicsStepListener *CountingPhysicsStepListener_OffsetPtr(const CountingPhysicsStepListener *ptr, ptrdiff_t i)
{
    return (const CountingPhysicsStepListener *)(((const CountingPhysicsStepListener *)ptr) + i);
}

CountingPhysicsStepListener *CountingPhysicsStepListener_OffsetMutablePtr(CountingPhysicsStepListener *ptr, ptrdiff_t i)
{
    return (CountingPhysicsStepListener *)(((CountingPhysicsStepListener *)ptr) + i);
}

const JPH_PhysicsStepListener *CountingPhysicsStepListener_UpcastTo_JPH_PhysicsStepListener(const CountingPhysicsStepListener *object)
{
    return (const JPH_PhysicsStepListener *)(static_cast<const JPH::PhysicsStepListener *>(
        ((const CountingPhysicsStepListener *)object)
    ));
}

JPH_PhysicsStepListener *CountingPhysicsStepListener_MutableUpcastTo_JPH_PhysicsStepListener(CountingPhysicsStepListener *object)
{
    return (JPH_PhysicsStepListener *)(static_cast<JPH::PhysicsStepListener *>(
        ((CountingPhysicsStepListener *)object)
    ));
}

const CountingPhysicsStepListener *CountingPhysicsStepListener_StaticDowncastFrom_JPH_PhysicsStepListener(const JPH_PhysicsStepListener *object)
{
    return (const CountingPhysicsStepListener *)(static_cast<const CountingPhysicsStepListener *>(
        ((const JPH::PhysicsStepListener *)object)
    ));
}

CountingPhysicsStepListener *CountingPhysicsStepListener_MutableStaticDowncastFrom_JPH_PhysicsStepListener(JPH_PhysicsStepListener *object)
{
    return (CountingPhysicsStepListener *)(static_cast<CountingPhysicsStepListener *>(
        ((JPH::PhysicsStepListener *)object)
    ));
}

CountingPhysicsStepListener *CountingPhysicsStepListener_ConstructFromAnother(Jolt_PassBy _other_pass_by, CountingPhysicsStepListener *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, CountingPhysicsStepListener);
    return (CountingPhysicsStepListener *)new CountingPhysicsStepListener(CountingPhysicsStepListener(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, CountingPhysicsStepListener) MRBINDC_CLASSARG_COPY(_other, (CountingPhysicsStepListener), CountingPhysicsStepListener) MRBINDC_CLASSARG_MOVE(_other, (CountingPhysicsStepListener), CountingPhysicsStepListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, CountingPhysicsStepListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, CountingPhysicsStepListener) MRBINDC_CLASSARG_END(_other, CountingPhysicsStepListener))
    ));
}

void CountingPhysicsStepListener_Destroy(const CountingPhysicsStepListener *_this)
{
    delete ((const CountingPhysicsStepListener *)_this);
}

void CountingPhysicsStepListener_DestroyArray(const CountingPhysicsStepListener *_this)
{
    delete[] ((const CountingPhysicsStepListener *)_this);
}

CountingPhysicsStepListener *CountingPhysicsStepListener_AssignFromAnother(CountingPhysicsStepListener *_this, Jolt_PassBy _other_pass_by, CountingPhysicsStepListener *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, CountingPhysicsStepListener);
    return (CountingPhysicsStepListener *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(CountingPhysicsStepListener *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, CountingPhysicsStepListener) MRBINDC_CLASSARG_COPY(_other, (CountingPhysicsStepListener), CountingPhysicsStepListener) MRBINDC_CLASSARG_MOVE(_other, (CountingPhysicsStepListener), CountingPhysicsStepListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, CountingPhysicsStepListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, CountingPhysicsStepListener) MRBINDC_CLASSARG_END(_other, CountingPhysicsStepListener))
    ));
}

void CountingPhysicsStepListener_Reset(CountingPhysicsStepListener *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(CountingPhysicsStepListener *)(_this)).Reset();
}

int CountingPhysicsStepListener_GetCount(const CountingPhysicsStepListener *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const CountingPhysicsStepListener *)(_this)).GetCount();
}

float CountingPhysicsStepListener_GetLastDeltaTime(const CountingPhysicsStepListener *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const CountingPhysicsStepListener *)(_this)).GetLastDeltaTime();
}

bool CountingPhysicsStepListener_GetLastIsFirst(const CountingPhysicsStepListener *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const CountingPhysicsStepListener *)(_this)).GetLastIsFirst();
}

bool CountingPhysicsStepListener_GetLastIsLast(const CountingPhysicsStepListener *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const CountingPhysicsStepListener *)(_this)).GetLastIsLast();
}

const int *SimpleContactEventListener_Get_mValidateCount(const SimpleContactEventListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const SimpleContactEventListener *)(_this)).mValidateCount);
}

void SimpleContactEventListener_Set_mValidateCount(SimpleContactEventListener *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).mValidateCount = value;
}

int *SimpleContactEventListener_GetMutable_mValidateCount(SimpleContactEventListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).mValidateCount);
}

const int *SimpleContactEventListener_Get_mAddedCount(const SimpleContactEventListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const SimpleContactEventListener *)(_this)).mAddedCount);
}

void SimpleContactEventListener_Set_mAddedCount(SimpleContactEventListener *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).mAddedCount = value;
}

int *SimpleContactEventListener_GetMutable_mAddedCount(SimpleContactEventListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).mAddedCount);
}

const int *SimpleContactEventListener_Get_mPersistedCount(const SimpleContactEventListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const SimpleContactEventListener *)(_this)).mPersistedCount);
}

void SimpleContactEventListener_Set_mPersistedCount(SimpleContactEventListener *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).mPersistedCount = value;
}

int *SimpleContactEventListener_GetMutable_mPersistedCount(SimpleContactEventListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).mPersistedCount);
}

const int *SimpleContactEventListener_Get_mRemovedCount(const SimpleContactEventListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const SimpleContactEventListener *)(_this)).mRemovedCount);
}

void SimpleContactEventListener_Set_mRemovedCount(SimpleContactEventListener *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).mRemovedCount = value;
}

int *SimpleContactEventListener_GetMutable_mRemovedCount(SimpleContactEventListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).mRemovedCount);
}

const JPH_BodyID *SimpleContactEventListener_Get_mLastAddedBody1(const SimpleContactEventListener *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const SimpleContactEventListener *)(_this)).mLastAddedBody1);
}

void SimpleContactEventListener_Set_mLastAddedBody1(SimpleContactEventListener *_this, JPH_BodyID value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).mLastAddedBody1 = MRBINDC_BIT_CAST((JPH::BodyID), value);
}

JPH_BodyID *SimpleContactEventListener_GetMutable_mLastAddedBody1(SimpleContactEventListener *_this)
{
    return (JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).mLastAddedBody1);
}

const JPH_BodyID *SimpleContactEventListener_Get_mLastAddedBody2(const SimpleContactEventListener *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const SimpleContactEventListener *)(_this)).mLastAddedBody2);
}

void SimpleContactEventListener_Set_mLastAddedBody2(SimpleContactEventListener *_this, JPH_BodyID value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).mLastAddedBody2 = MRBINDC_BIT_CAST((JPH::BodyID), value);
}

JPH_BodyID *SimpleContactEventListener_GetMutable_mLastAddedBody2(SimpleContactEventListener *_this)
{
    return (JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).mLastAddedBody2);
}

SimpleContactEventListener *SimpleContactEventListener_DefaultConstruct(void)
{
    using _mrbind_T = SimpleContactEventListener;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (SimpleContactEventListener*)(::new(_mrbind_ptr) _mrbind_T());
}

SimpleContactEventListener *SimpleContactEventListener_DefaultConstructArray(size_t num_elems)
{
    return (SimpleContactEventListener *)(new SimpleContactEventListener[num_elems]);
}

const SimpleContactEventListener *SimpleContactEventListener_OffsetPtr(const SimpleContactEventListener *ptr, ptrdiff_t i)
{
    return (const SimpleContactEventListener *)(((const SimpleContactEventListener *)ptr) + i);
}

SimpleContactEventListener *SimpleContactEventListener_OffsetMutablePtr(SimpleContactEventListener *ptr, ptrdiff_t i)
{
    return (SimpleContactEventListener *)(((SimpleContactEventListener *)ptr) + i);
}

const JPH_ContactListener *SimpleContactEventListener_UpcastTo_JPH_ContactListener(const SimpleContactEventListener *object)
{
    return (const JPH_ContactListener *)(static_cast<const JPH::ContactListener *>(
        ((const SimpleContactEventListener *)object)
    ));
}

JPH_ContactListener *SimpleContactEventListener_MutableUpcastTo_JPH_ContactListener(SimpleContactEventListener *object)
{
    return (JPH_ContactListener *)(static_cast<JPH::ContactListener *>(
        ((SimpleContactEventListener *)object)
    ));
}

const SimpleContactEventListener *SimpleContactEventListener_StaticDowncastFrom_JPH_ContactListener(const JPH_ContactListener *object)
{
    return (const SimpleContactEventListener *)(static_cast<const SimpleContactEventListener *>(
        ((const JPH::ContactListener *)object)
    ));
}

SimpleContactEventListener *SimpleContactEventListener_MutableStaticDowncastFrom_JPH_ContactListener(JPH_ContactListener *object)
{
    return (SimpleContactEventListener *)(static_cast<SimpleContactEventListener *>(
        ((JPH::ContactListener *)object)
    ));
}

SimpleContactEventListener *SimpleContactEventListener_ConstructFromAnother(Jolt_PassBy _other_pass_by, SimpleContactEventListener *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, SimpleContactEventListener);
    return (SimpleContactEventListener *)new SimpleContactEventListener(SimpleContactEventListener(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, SimpleContactEventListener) MRBINDC_CLASSARG_COPY(_other, (SimpleContactEventListener), SimpleContactEventListener) MRBINDC_CLASSARG_MOVE(_other, (SimpleContactEventListener), SimpleContactEventListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, SimpleContactEventListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, SimpleContactEventListener) MRBINDC_CLASSARG_END(_other, SimpleContactEventListener))
    ));
}

void SimpleContactEventListener_Destroy(const SimpleContactEventListener *_this)
{
    delete ((const SimpleContactEventListener *)_this);
}

void SimpleContactEventListener_DestroyArray(const SimpleContactEventListener *_this)
{
    delete[] ((const SimpleContactEventListener *)_this);
}

SimpleContactEventListener *SimpleContactEventListener_AssignFromAnother(SimpleContactEventListener *_this, Jolt_PassBy _other_pass_by, SimpleContactEventListener *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, SimpleContactEventListener);
    return (SimpleContactEventListener *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, SimpleContactEventListener) MRBINDC_CLASSARG_COPY(_other, (SimpleContactEventListener), SimpleContactEventListener) MRBINDC_CLASSARG_MOVE(_other, (SimpleContactEventListener), SimpleContactEventListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, SimpleContactEventListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, SimpleContactEventListener) MRBINDC_CLASSARG_END(_other, SimpleContactEventListener))
    ));
}

void SimpleContactEventListener_Reset(SimpleContactEventListener *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).Reset();
}

int SimpleContactEventListener_GetValidateCount(const SimpleContactEventListener *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const SimpleContactEventListener *)(_this)).GetValidateCount();
}

int SimpleContactEventListener_GetAddedCount(const SimpleContactEventListener *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const SimpleContactEventListener *)(_this)).GetAddedCount();
}

int SimpleContactEventListener_GetPersistedCount(const SimpleContactEventListener *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const SimpleContactEventListener *)(_this)).GetPersistedCount();
}

int SimpleContactEventListener_GetRemovedCount(const SimpleContactEventListener *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const SimpleContactEventListener *)(_this)).GetRemovedCount();
}

const JPH_BodyID *SimpleContactEventListener_GetLastAddedBody1(const SimpleContactEventListener *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const SimpleContactEventListener *)(_this)).GetLastAddedBody1());
}

const JPH_BodyID *SimpleContactEventListener_GetLastAddedBody2(const SimpleContactEventListener *_this)
{
    return (const JPH_BodyID *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const SimpleContactEventListener *)(_this)).GetLastAddedBody2());
}

JPH_ValidateResult SimpleContactEventListener_OnContactValidate(SimpleContactEventListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_Vec3 *inBaseOffset, const JPH_CollideShapeResult *inCollisionResult)
{
    return (JPH_ValidateResult)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).OnContactValidate(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(const JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2)),
        ((inBaseOffset ? void() : MRBINDC_THROW("Parameter `inBaseOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBaseOffset)),
        ((inCollisionResult ? void() : MRBINDC_THROW("Parameter `inCollisionResult` can not be null.", void)), *(const JPH::CollideShapeResult *)(inCollisionResult))
    ));
}

void SimpleContactEventListener_OnContactAdded(SimpleContactEventListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).OnContactAdded(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(const JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2)),
        ((inManifold ? void() : MRBINDC_THROW("Parameter `inManifold` can not be null.", void)), *(const JPH::ContactManifold *)(inManifold)),
        ((ioSettings ? void() : MRBINDC_THROW("Parameter `ioSettings` can not be null.", void)), *(JPH::ContactSettings *)(ioSettings))
    );
}

void SimpleContactEventListener_OnContactPersisted(SimpleContactEventListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).OnContactPersisted(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(const JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2)),
        ((inManifold ? void() : MRBINDC_THROW("Parameter `inManifold` can not be null.", void)), *(const JPH::ContactManifold *)(inManifold)),
        ((ioSettings ? void() : MRBINDC_THROW("Parameter `ioSettings` can not be null.", void)), *(JPH::ContactSettings *)(ioSettings))
    );
}

void SimpleContactEventListener_OnContactRemoved(SimpleContactEventListener *_this, const JPH_SubShapeIDPair *inSubShapePair)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(SimpleContactEventListener *)(_this)).OnContactRemoved(
        ((inSubShapePair ? void() : MRBINDC_THROW("Parameter `inSubShapePair` can not be null.", void)), *(const JPH::SubShapeIDPair *)(inSubShapePair))
    );
}

void *const *ContactListenerTrampoline_Get_mContext(const ContactListenerTrampoline *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const ContactListenerTrampoline *)(_this)).mContext);
}

void ContactListenerTrampoline_Set_mContext(ContactListenerTrampoline *_this, void *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).mContext = value;
}

void **ContactListenerTrampoline_GetMutable_mContext(ContactListenerTrampoline *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).mContext);
}

void *const *ContactListenerTrampoline_Get_mOnContactValidateFn(const ContactListenerTrampoline *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const ContactListenerTrampoline *)(_this)).mOnContactValidateFn);
}

void ContactListenerTrampoline_Set_mOnContactValidateFn(ContactListenerTrampoline *_this, void *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).mOnContactValidateFn = value;
}

void **ContactListenerTrampoline_GetMutable_mOnContactValidateFn(ContactListenerTrampoline *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).mOnContactValidateFn);
}

void *const *ContactListenerTrampoline_Get_mOnContactAddedFn(const ContactListenerTrampoline *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const ContactListenerTrampoline *)(_this)).mOnContactAddedFn);
}

void ContactListenerTrampoline_Set_mOnContactAddedFn(ContactListenerTrampoline *_this, void *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).mOnContactAddedFn = value;
}

void **ContactListenerTrampoline_GetMutable_mOnContactAddedFn(ContactListenerTrampoline *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).mOnContactAddedFn);
}

void *const *ContactListenerTrampoline_Get_mOnContactPersistedFn(const ContactListenerTrampoline *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const ContactListenerTrampoline *)(_this)).mOnContactPersistedFn);
}

void ContactListenerTrampoline_Set_mOnContactPersistedFn(ContactListenerTrampoline *_this, void *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).mOnContactPersistedFn = value;
}

void **ContactListenerTrampoline_GetMutable_mOnContactPersistedFn(ContactListenerTrampoline *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).mOnContactPersistedFn);
}

void *const *ContactListenerTrampoline_Get_mOnContactRemovedFn(const ContactListenerTrampoline *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const ContactListenerTrampoline *)(_this)).mOnContactRemovedFn);
}

void ContactListenerTrampoline_Set_mOnContactRemovedFn(ContactListenerTrampoline *_this, void *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).mOnContactRemovedFn = value;
}

void **ContactListenerTrampoline_GetMutable_mOnContactRemovedFn(ContactListenerTrampoline *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).mOnContactRemovedFn);
}

ContactListenerTrampoline *ContactListenerTrampoline_DefaultConstruct(void)
{
    using _mrbind_T = ContactListenerTrampoline;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (ContactListenerTrampoline*)(::new(_mrbind_ptr) _mrbind_T());
}

ContactListenerTrampoline *ContactListenerTrampoline_DefaultConstructArray(size_t num_elems)
{
    return (ContactListenerTrampoline *)(new ContactListenerTrampoline[num_elems]);
}

const ContactListenerTrampoline *ContactListenerTrampoline_OffsetPtr(const ContactListenerTrampoline *ptr, ptrdiff_t i)
{
    return (const ContactListenerTrampoline *)(((const ContactListenerTrampoline *)ptr) + i);
}

ContactListenerTrampoline *ContactListenerTrampoline_OffsetMutablePtr(ContactListenerTrampoline *ptr, ptrdiff_t i)
{
    return (ContactListenerTrampoline *)(((ContactListenerTrampoline *)ptr) + i);
}

const JPH_ContactListener *ContactListenerTrampoline_UpcastTo_JPH_ContactListener(const ContactListenerTrampoline *object)
{
    return (const JPH_ContactListener *)(static_cast<const JPH::ContactListener *>(
        ((const ContactListenerTrampoline *)object)
    ));
}

JPH_ContactListener *ContactListenerTrampoline_MutableUpcastTo_JPH_ContactListener(ContactListenerTrampoline *object)
{
    return (JPH_ContactListener *)(static_cast<JPH::ContactListener *>(
        ((ContactListenerTrampoline *)object)
    ));
}

const ContactListenerTrampoline *ContactListenerTrampoline_StaticDowncastFrom_JPH_ContactListener(const JPH_ContactListener *object)
{
    return (const ContactListenerTrampoline *)(static_cast<const ContactListenerTrampoline *>(
        ((const JPH::ContactListener *)object)
    ));
}

ContactListenerTrampoline *ContactListenerTrampoline_MutableStaticDowncastFrom_JPH_ContactListener(JPH_ContactListener *object)
{
    return (ContactListenerTrampoline *)(static_cast<ContactListenerTrampoline *>(
        ((JPH::ContactListener *)object)
    ));
}

ContactListenerTrampoline *ContactListenerTrampoline_ConstructFromAnother(Jolt_PassBy _other_pass_by, ContactListenerTrampoline *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, ContactListenerTrampoline);
    return (ContactListenerTrampoline *)new ContactListenerTrampoline(ContactListenerTrampoline(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, ContactListenerTrampoline) MRBINDC_CLASSARG_COPY(_other, (ContactListenerTrampoline), ContactListenerTrampoline) MRBINDC_CLASSARG_MOVE(_other, (ContactListenerTrampoline), ContactListenerTrampoline) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, ContactListenerTrampoline) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, ContactListenerTrampoline) MRBINDC_CLASSARG_END(_other, ContactListenerTrampoline))
    ));
}

void ContactListenerTrampoline_Destroy(const ContactListenerTrampoline *_this)
{
    delete ((const ContactListenerTrampoline *)_this);
}

void ContactListenerTrampoline_DestroyArray(const ContactListenerTrampoline *_this)
{
    delete[] ((const ContactListenerTrampoline *)_this);
}

ContactListenerTrampoline *ContactListenerTrampoline_AssignFromAnother(ContactListenerTrampoline *_this, Jolt_PassBy _other_pass_by, ContactListenerTrampoline *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, ContactListenerTrampoline);
    return (ContactListenerTrampoline *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, ContactListenerTrampoline) MRBINDC_CLASSARG_COPY(_other, (ContactListenerTrampoline), ContactListenerTrampoline) MRBINDC_CLASSARG_MOVE(_other, (ContactListenerTrampoline), ContactListenerTrampoline) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, ContactListenerTrampoline) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, ContactListenerTrampoline) MRBINDC_CLASSARG_END(_other, ContactListenerTrampoline))
    ));
}

void *ContactListenerTrampoline_GetContext(const ContactListenerTrampoline *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const ContactListenerTrampoline *)(_this)).GetContext();
}

void ContactListenerTrampoline_SetContext(ContactListenerTrampoline *_this, void *v)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).SetContext(
        v
    );
}

void *ContactListenerTrampoline_GetOnContactValidateFn(const ContactListenerTrampoline *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const ContactListenerTrampoline *)(_this)).GetOnContactValidateFn();
}

void ContactListenerTrampoline_SetOnContactValidateFn(ContactListenerTrampoline *_this, void *v)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).SetOnContactValidateFn(
        v
    );
}

void *ContactListenerTrampoline_GetOnContactAddedFn(const ContactListenerTrampoline *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const ContactListenerTrampoline *)(_this)).GetOnContactAddedFn();
}

void ContactListenerTrampoline_SetOnContactAddedFn(ContactListenerTrampoline *_this, void *v)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).SetOnContactAddedFn(
        v
    );
}

void *ContactListenerTrampoline_GetOnContactPersistedFn(const ContactListenerTrampoline *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const ContactListenerTrampoline *)(_this)).GetOnContactPersistedFn();
}

void ContactListenerTrampoline_SetOnContactPersistedFn(ContactListenerTrampoline *_this, void *v)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).SetOnContactPersistedFn(
        v
    );
}

void *ContactListenerTrampoline_GetOnContactRemovedFn(const ContactListenerTrampoline *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const ContactListenerTrampoline *)(_this)).GetOnContactRemovedFn();
}

void ContactListenerTrampoline_SetOnContactRemovedFn(ContactListenerTrampoline *_this, void *v)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).SetOnContactRemovedFn(
        v
    );
}

JPH_ValidateResult ContactListenerTrampoline_OnContactValidate(ContactListenerTrampoline *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_Vec3 *inBaseOffset, const JPH_CollideShapeResult *inCollisionResult)
{
    return (JPH_ValidateResult)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).OnContactValidate(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(const JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2)),
        ((inBaseOffset ? void() : MRBINDC_THROW("Parameter `inBaseOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBaseOffset)),
        ((inCollisionResult ? void() : MRBINDC_THROW("Parameter `inCollisionResult` can not be null.", void)), *(const JPH::CollideShapeResult *)(inCollisionResult))
    ));
}

void ContactListenerTrampoline_OnContactAdded(ContactListenerTrampoline *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).OnContactAdded(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(const JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2)),
        ((inManifold ? void() : MRBINDC_THROW("Parameter `inManifold` can not be null.", void)), *(const JPH::ContactManifold *)(inManifold)),
        ((ioSettings ? void() : MRBINDC_THROW("Parameter `ioSettings` can not be null.", void)), *(JPH::ContactSettings *)(ioSettings))
    );
}

void ContactListenerTrampoline_OnContactPersisted(ContactListenerTrampoline *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).OnContactPersisted(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(const JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2)),
        ((inManifold ? void() : MRBINDC_THROW("Parameter `inManifold` can not be null.", void)), *(const JPH::ContactManifold *)(inManifold)),
        ((ioSettings ? void() : MRBINDC_THROW("Parameter `ioSettings` can not be null.", void)), *(JPH::ContactSettings *)(ioSettings))
    );
}

void ContactListenerTrampoline_OnContactRemoved(ContactListenerTrampoline *_this, const JPH_SubShapeIDPair *inSubShapePair)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(ContactListenerTrampoline *)(_this)).OnContactRemoved(
        ((inSubShapePair ? void() : MRBINDC_THROW("Parameter `inSubShapePair` can not be null.", void)), *(const JPH::SubShapeIDPair *)(inSubShapePair))
    );
}

const bool *EstimateResponseContactListener_Get_mWasCalled(const EstimateResponseContactListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const EstimateResponseContactListener *)(_this)).mWasCalled);
}

void EstimateResponseContactListener_Set_mWasCalled(EstimateResponseContactListener *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(EstimateResponseContactListener *)(_this)).mWasCalled = value;
}

bool *EstimateResponseContactListener_GetMutable_mWasCalled(EstimateResponseContactListener *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(EstimateResponseContactListener *)(_this)).mWasCalled);
}

const JPH_Vec3 *EstimateResponseContactListener_Get_mLinearVelocity1(const EstimateResponseContactListener *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const EstimateResponseContactListener *)(_this)).mLinearVelocity1);
}

JPH_Vec3 *EstimateResponseContactListener_GetMutable_mLinearVelocity1(EstimateResponseContactListener *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(EstimateResponseContactListener *)(_this)).mLinearVelocity1);
}

const JPH_Vec3 *EstimateResponseContactListener_Get_mAngularVelocity1(const EstimateResponseContactListener *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const EstimateResponseContactListener *)(_this)).mAngularVelocity1);
}

JPH_Vec3 *EstimateResponseContactListener_GetMutable_mAngularVelocity1(EstimateResponseContactListener *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(EstimateResponseContactListener *)(_this)).mAngularVelocity1);
}

const JPH_Vec3 *EstimateResponseContactListener_Get_mLinearVelocity2(const EstimateResponseContactListener *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const EstimateResponseContactListener *)(_this)).mLinearVelocity2);
}

JPH_Vec3 *EstimateResponseContactListener_GetMutable_mLinearVelocity2(EstimateResponseContactListener *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(EstimateResponseContactListener *)(_this)).mLinearVelocity2);
}

const JPH_Vec3 *EstimateResponseContactListener_Get_mAngularVelocity2(const EstimateResponseContactListener *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const EstimateResponseContactListener *)(_this)).mAngularVelocity2);
}

JPH_Vec3 *EstimateResponseContactListener_GetMutable_mAngularVelocity2(EstimateResponseContactListener *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(EstimateResponseContactListener *)(_this)).mAngularVelocity2);
}

EstimateResponseContactListener *EstimateResponseContactListener_DefaultConstruct(void)
{
    using _mrbind_T = EstimateResponseContactListener;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (EstimateResponseContactListener*)(::new(_mrbind_ptr) _mrbind_T());
}

EstimateResponseContactListener *EstimateResponseContactListener_DefaultConstructArray(size_t num_elems)
{
    return (EstimateResponseContactListener *)(new EstimateResponseContactListener[num_elems]);
}

const EstimateResponseContactListener *EstimateResponseContactListener_OffsetPtr(const EstimateResponseContactListener *ptr, ptrdiff_t i)
{
    return (const EstimateResponseContactListener *)(((const EstimateResponseContactListener *)ptr) + i);
}

EstimateResponseContactListener *EstimateResponseContactListener_OffsetMutablePtr(EstimateResponseContactListener *ptr, ptrdiff_t i)
{
    return (EstimateResponseContactListener *)(((EstimateResponseContactListener *)ptr) + i);
}

const JPH_ContactListener *EstimateResponseContactListener_UpcastTo_JPH_ContactListener(const EstimateResponseContactListener *object)
{
    return (const JPH_ContactListener *)(static_cast<const JPH::ContactListener *>(
        ((const EstimateResponseContactListener *)object)
    ));
}

JPH_ContactListener *EstimateResponseContactListener_MutableUpcastTo_JPH_ContactListener(EstimateResponseContactListener *object)
{
    return (JPH_ContactListener *)(static_cast<JPH::ContactListener *>(
        ((EstimateResponseContactListener *)object)
    ));
}

const EstimateResponseContactListener *EstimateResponseContactListener_StaticDowncastFrom_JPH_ContactListener(const JPH_ContactListener *object)
{
    return (const EstimateResponseContactListener *)(static_cast<const EstimateResponseContactListener *>(
        ((const JPH::ContactListener *)object)
    ));
}

EstimateResponseContactListener *EstimateResponseContactListener_MutableStaticDowncastFrom_JPH_ContactListener(JPH_ContactListener *object)
{
    return (EstimateResponseContactListener *)(static_cast<EstimateResponseContactListener *>(
        ((JPH::ContactListener *)object)
    ));
}

EstimateResponseContactListener *EstimateResponseContactListener_ConstructFromAnother(Jolt_PassBy _other_pass_by, EstimateResponseContactListener *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, EstimateResponseContactListener);
    return (EstimateResponseContactListener *)new EstimateResponseContactListener(EstimateResponseContactListener(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, EstimateResponseContactListener) MRBINDC_CLASSARG_COPY(_other, (EstimateResponseContactListener), EstimateResponseContactListener) MRBINDC_CLASSARG_MOVE(_other, (EstimateResponseContactListener), EstimateResponseContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, EstimateResponseContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, EstimateResponseContactListener) MRBINDC_CLASSARG_END(_other, EstimateResponseContactListener))
    ));
}

void EstimateResponseContactListener_Destroy(const EstimateResponseContactListener *_this)
{
    delete ((const EstimateResponseContactListener *)_this);
}

void EstimateResponseContactListener_DestroyArray(const EstimateResponseContactListener *_this)
{
    delete[] ((const EstimateResponseContactListener *)_this);
}

EstimateResponseContactListener *EstimateResponseContactListener_AssignFromAnother(EstimateResponseContactListener *_this, Jolt_PassBy _other_pass_by, EstimateResponseContactListener *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, EstimateResponseContactListener);
    return (EstimateResponseContactListener *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(EstimateResponseContactListener *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, EstimateResponseContactListener) MRBINDC_CLASSARG_COPY(_other, (EstimateResponseContactListener), EstimateResponseContactListener) MRBINDC_CLASSARG_MOVE(_other, (EstimateResponseContactListener), EstimateResponseContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, EstimateResponseContactListener) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, EstimateResponseContactListener) MRBINDC_CLASSARG_END(_other, EstimateResponseContactListener))
    ));
}

void EstimateResponseContactListener_Reset(EstimateResponseContactListener *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(EstimateResponseContactListener *)(_this)).Reset();
}

bool EstimateResponseContactListener_WasCalled(const EstimateResponseContactListener *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const EstimateResponseContactListener *)(_this)).WasCalled();
}

const JPH_Vec3 *EstimateResponseContactListener_GetLinearVelocity1(const EstimateResponseContactListener *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const EstimateResponseContactListener *)(_this)).GetLinearVelocity1());
}

const JPH_Vec3 *EstimateResponseContactListener_GetAngularVelocity1(const EstimateResponseContactListener *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const EstimateResponseContactListener *)(_this)).GetAngularVelocity1());
}

const JPH_Vec3 *EstimateResponseContactListener_GetLinearVelocity2(const EstimateResponseContactListener *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const EstimateResponseContactListener *)(_this)).GetLinearVelocity2());
}

const JPH_Vec3 *EstimateResponseContactListener_GetAngularVelocity2(const EstimateResponseContactListener *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const EstimateResponseContactListener *)(_this)).GetAngularVelocity2());
}

void EstimateResponseContactListener_OnContactAdded(EstimateResponseContactListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(EstimateResponseContactListener *)(_this)).OnContactAdded(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(const JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2)),
        ((inManifold ? void() : MRBINDC_THROW("Parameter `inManifold` can not be null.", void)), *(const JPH::ContactManifold *)(inManifold)),
        ((ioSettings ? void() : MRBINDC_THROW("Parameter `ioSettings` can not be null.", void)), *(JPH::ContactSettings *)(ioSettings))
    );
}

JPH_ValidateResult EstimateResponseContactListener_OnContactValidate(EstimateResponseContactListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_Vec3 *inBaseOffset, const JPH_CollideShapeResult *inCollisionResult)
{
    return (JPH_ValidateResult)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(EstimateResponseContactListener *)(_this)).OnContactValidate(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(const JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2)),
        ((inBaseOffset ? void() : MRBINDC_THROW("Parameter `inBaseOffset` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inBaseOffset)),
        ((inCollisionResult ? void() : MRBINDC_THROW("Parameter `inCollisionResult` can not be null.", void)), *(const JPH::CollideShapeResult *)(inCollisionResult))
    ));
}

void EstimateResponseContactListener_OnContactPersisted(EstimateResponseContactListener *_this, const JPH_Body *inBody1, const JPH_Body *inBody2, const JPH_ContactManifold *inManifold, JPH_ContactSettings *ioSettings)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(EstimateResponseContactListener *)(_this)).OnContactPersisted(
        ((inBody1 ? void() : MRBINDC_THROW("Parameter `inBody1` can not be null.", void)), *(const JPH::Body *)(inBody1)),
        ((inBody2 ? void() : MRBINDC_THROW("Parameter `inBody2` can not be null.", void)), *(const JPH::Body *)(inBody2)),
        ((inManifold ? void() : MRBINDC_THROW("Parameter `inManifold` can not be null.", void)), *(const JPH::ContactManifold *)(inManifold)),
        ((ioSettings ? void() : MRBINDC_THROW("Parameter `ioSettings` can not be null.", void)), *(JPH::ContactSettings *)(ioSettings))
    );
}

void EstimateResponseContactListener_OnContactRemoved(EstimateResponseContactListener *_this, const JPH_SubShapeIDPair *inSubShapePair)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(EstimateResponseContactListener *)(_this)).OnContactRemoved(
        ((inSubShapePair ? void() : MRBINDC_THROW("Parameter `inSubShapePair` can not be null.", void)), *(const JPH::SubShapeIDPair *)(inSubShapePair))
    );
}

const JPH_Vec3 *DebugLineRecord_Get_mFrom(const DebugLineRecord *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const DebugLineRecord *)(_this)).mFrom);
}

JPH_Vec3 *DebugLineRecord_GetMutable_mFrom(DebugLineRecord *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(DebugLineRecord *)(_this)).mFrom);
}

const JPH_Vec3 *DebugLineRecord_Get_mTo(const DebugLineRecord *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const DebugLineRecord *)(_this)).mTo);
}

JPH_Vec3 *DebugLineRecord_GetMutable_mTo(DebugLineRecord *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(DebugLineRecord *)(_this)).mTo);
}

const JPH_Color *DebugLineRecord_Get_mColor(const DebugLineRecord *_this)
{
    return (const JPH_Color *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const DebugLineRecord *)(_this)).mColor);
}

JPH_Color *DebugLineRecord_GetMutable_mColor(DebugLineRecord *_this)
{
    return (JPH_Color *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(DebugLineRecord *)(_this)).mColor);
}

DebugLineRecord *DebugLineRecord_DefaultConstruct(void)
{
    using _mrbind_T = DebugLineRecord;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (DebugLineRecord*)(::new(_mrbind_ptr) _mrbind_T());
}

DebugLineRecord *DebugLineRecord_DefaultConstructArray(size_t num_elems)
{
    return (DebugLineRecord *)(new DebugLineRecord[num_elems]);
}

DebugLineRecord *DebugLineRecord_ConstructFrom(const JPH_Vec3 *mFrom, const JPH_Vec3 *mTo, const JPH_Color *mColor)
{
    return (DebugLineRecord *)new DebugLineRecord(DebugLineRecord{
        ((mFrom ? void() : MRBINDC_THROW("Parameter `mFrom` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mFrom)),
        ((mTo ? void() : MRBINDC_THROW("Parameter `mTo` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mTo)),
        ((mColor ? void() : MRBINDC_THROW("Parameter `mColor` can not be null.", void)), JPH::Color(*(JPH::Color *)mColor))
    });
}

const DebugLineRecord *DebugLineRecord_OffsetPtr(const DebugLineRecord *ptr, ptrdiff_t i)
{
    return (const DebugLineRecord *)(((const DebugLineRecord *)ptr) + i);
}

DebugLineRecord *DebugLineRecord_OffsetMutablePtr(DebugLineRecord *ptr, ptrdiff_t i)
{
    return (DebugLineRecord *)(((DebugLineRecord *)ptr) + i);
}

DebugLineRecord *DebugLineRecord_ConstructFromAnother(const DebugLineRecord *_other)
{
    return (DebugLineRecord *)new DebugLineRecord(DebugLineRecord(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), DebugLineRecord(*(DebugLineRecord *)_other))
    ));
}

void DebugLineRecord_Destroy(const DebugLineRecord *_this)
{
    delete ((const DebugLineRecord *)_this);
}

void DebugLineRecord_DestroyArray(const DebugLineRecord *_this)
{
    delete[] ((const DebugLineRecord *)_this);
}

DebugLineRecord *DebugLineRecord_AssignFromAnother(DebugLineRecord *_this, const DebugLineRecord *_other)
{
    return (DebugLineRecord *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(DebugLineRecord *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), DebugLineRecord(*(DebugLineRecord *)_other))
    ));
}

const JPH_Vec3 *DebugTriangleRecord_Get_mV1(const DebugTriangleRecord *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const DebugTriangleRecord *)(_this)).mV1);
}

JPH_Vec3 *DebugTriangleRecord_GetMutable_mV1(DebugTriangleRecord *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(DebugTriangleRecord *)(_this)).mV1);
}

const JPH_Vec3 *DebugTriangleRecord_Get_mV2(const DebugTriangleRecord *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const DebugTriangleRecord *)(_this)).mV2);
}

JPH_Vec3 *DebugTriangleRecord_GetMutable_mV2(DebugTriangleRecord *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(DebugTriangleRecord *)(_this)).mV2);
}

const JPH_Vec3 *DebugTriangleRecord_Get_mV3(const DebugTriangleRecord *_this)
{
    return (const JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const DebugTriangleRecord *)(_this)).mV3);
}

JPH_Vec3 *DebugTriangleRecord_GetMutable_mV3(DebugTriangleRecord *_this)
{
    return (JPH_Vec3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(DebugTriangleRecord *)(_this)).mV3);
}

const JPH_Color *DebugTriangleRecord_Get_mColor(const DebugTriangleRecord *_this)
{
    return (const JPH_Color *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const DebugTriangleRecord *)(_this)).mColor);
}

JPH_Color *DebugTriangleRecord_GetMutable_mColor(DebugTriangleRecord *_this)
{
    return (JPH_Color *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(DebugTriangleRecord *)(_this)).mColor);
}

DebugTriangleRecord *DebugTriangleRecord_DefaultConstruct(void)
{
    using _mrbind_T = DebugTriangleRecord;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (DebugTriangleRecord*)(::new(_mrbind_ptr) _mrbind_T());
}

DebugTriangleRecord *DebugTriangleRecord_DefaultConstructArray(size_t num_elems)
{
    return (DebugTriangleRecord *)(new DebugTriangleRecord[num_elems]);
}

DebugTriangleRecord *DebugTriangleRecord_ConstructFrom(const JPH_Vec3 *mV1, const JPH_Vec3 *mV2, const JPH_Vec3 *mV3, const JPH_Color *mColor)
{
    return (DebugTriangleRecord *)new DebugTriangleRecord(DebugTriangleRecord{
        ((mV1 ? void() : MRBINDC_THROW("Parameter `mV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mV1)),
        ((mV2 ? void() : MRBINDC_THROW("Parameter `mV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mV2)),
        ((mV3 ? void() : MRBINDC_THROW("Parameter `mV3` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)mV3)),
        ((mColor ? void() : MRBINDC_THROW("Parameter `mColor` can not be null.", void)), JPH::Color(*(JPH::Color *)mColor))
    });
}

const DebugTriangleRecord *DebugTriangleRecord_OffsetPtr(const DebugTriangleRecord *ptr, ptrdiff_t i)
{
    return (const DebugTriangleRecord *)(((const DebugTriangleRecord *)ptr) + i);
}

DebugTriangleRecord *DebugTriangleRecord_OffsetMutablePtr(DebugTriangleRecord *ptr, ptrdiff_t i)
{
    return (DebugTriangleRecord *)(((DebugTriangleRecord *)ptr) + i);
}

DebugTriangleRecord *DebugTriangleRecord_ConstructFromAnother(const DebugTriangleRecord *_other)
{
    return (DebugTriangleRecord *)new DebugTriangleRecord(DebugTriangleRecord(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), DebugTriangleRecord(*(DebugTriangleRecord *)_other))
    ));
}

void DebugTriangleRecord_Destroy(const DebugTriangleRecord *_this)
{
    delete ((const DebugTriangleRecord *)_this);
}

void DebugTriangleRecord_DestroyArray(const DebugTriangleRecord *_this)
{
    delete[] ((const DebugTriangleRecord *)_this);
}

DebugTriangleRecord *DebugTriangleRecord_AssignFromAnother(DebugTriangleRecord *_this, const DebugTriangleRecord *_other)
{
    return (DebugTriangleRecord *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(DebugTriangleRecord *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), DebugTriangleRecord(*(DebugTriangleRecord *)_other))
    ));
}

JPH_DebugRenderer *const *RecordingDebugRenderer_Get_sInstance(void)
{
    return (JPH_DebugRenderer *const *)std::addressof(RecordingDebugRenderer::sInstance);
}

void RecordingDebugRenderer_Set_sInstance(JPH_DebugRenderer *value)
{
    RecordingDebugRenderer::sInstance = ((JPH::DebugRenderer *)value);
}

JPH_DebugRenderer **RecordingDebugRenderer_GetMutable_sInstance(void)
{
    return (JPH_DebugRenderer **)std::addressof(RecordingDebugRenderer::sInstance);
}

RecordingDebugRenderer *RecordingDebugRenderer_DefaultConstruct(void)
{
    using _mrbind_T = RecordingDebugRenderer;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (RecordingDebugRenderer*)(::new(_mrbind_ptr) _mrbind_T());
}

RecordingDebugRenderer *RecordingDebugRenderer_DefaultConstructArray(size_t num_elems)
{
    return (RecordingDebugRenderer *)(new RecordingDebugRenderer[num_elems]);
}

const RecordingDebugRenderer *RecordingDebugRenderer_OffsetPtr(const RecordingDebugRenderer *ptr, ptrdiff_t i)
{
    return (const RecordingDebugRenderer *)(((const RecordingDebugRenderer *)ptr) + i);
}

RecordingDebugRenderer *RecordingDebugRenderer_OffsetMutablePtr(RecordingDebugRenderer *ptr, ptrdiff_t i)
{
    return (RecordingDebugRenderer *)(((RecordingDebugRenderer *)ptr) + i);
}

const JPH_NonCopyable *RecordingDebugRenderer_UpcastTo_JPH_NonCopyable(const RecordingDebugRenderer *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const RecordingDebugRenderer *)object)
    ));
}

JPH_NonCopyable *RecordingDebugRenderer_MutableUpcastTo_JPH_NonCopyable(RecordingDebugRenderer *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((RecordingDebugRenderer *)object)
    ));
}

const RecordingDebugRenderer *RecordingDebugRenderer_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const RecordingDebugRenderer *)(static_cast<const RecordingDebugRenderer *>(
        ((const JPH::NonCopyable *)object)
    ));
}

RecordingDebugRenderer *RecordingDebugRenderer_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (RecordingDebugRenderer *)(static_cast<RecordingDebugRenderer *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_DebugRenderer *RecordingDebugRenderer_UpcastTo_JPH_DebugRenderer(const RecordingDebugRenderer *object)
{
    return (const JPH_DebugRenderer *)(static_cast<const JPH::DebugRenderer *>(
        ((const RecordingDebugRenderer *)object)
    ));
}

JPH_DebugRenderer *RecordingDebugRenderer_MutableUpcastTo_JPH_DebugRenderer(RecordingDebugRenderer *object)
{
    return (JPH_DebugRenderer *)(static_cast<JPH::DebugRenderer *>(
        ((RecordingDebugRenderer *)object)
    ));
}

const RecordingDebugRenderer *RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRenderer(const JPH_DebugRenderer *object)
{
    return (const RecordingDebugRenderer *)(static_cast<const RecordingDebugRenderer *>(
        ((const JPH::DebugRenderer *)object)
    ));
}

RecordingDebugRenderer *RecordingDebugRenderer_MutableStaticDowncastFrom_JPH_DebugRenderer(JPH_DebugRenderer *object)
{
    return (RecordingDebugRenderer *)(static_cast<RecordingDebugRenderer *>(
        ((JPH::DebugRenderer *)object)
    ));
}

const JPH_DebugRendererSimple *RecordingDebugRenderer_UpcastTo_JPH_DebugRendererSimple(const RecordingDebugRenderer *object)
{
    return (const JPH_DebugRendererSimple *)(static_cast<const JPH::DebugRendererSimple *>(
        ((const RecordingDebugRenderer *)object)
    ));
}

JPH_DebugRendererSimple *RecordingDebugRenderer_MutableUpcastTo_JPH_DebugRendererSimple(RecordingDebugRenderer *object)
{
    return (JPH_DebugRendererSimple *)(static_cast<JPH::DebugRendererSimple *>(
        ((RecordingDebugRenderer *)object)
    ));
}

const RecordingDebugRenderer *RecordingDebugRenderer_StaticDowncastFrom_JPH_DebugRendererSimple(const JPH_DebugRendererSimple *object)
{
    return (const RecordingDebugRenderer *)(static_cast<const RecordingDebugRenderer *>(
        ((const JPH::DebugRendererSimple *)object)
    ));
}

RecordingDebugRenderer *RecordingDebugRenderer_MutableStaticDowncastFrom_JPH_DebugRendererSimple(JPH_DebugRendererSimple *object)
{
    return (RecordingDebugRenderer *)(static_cast<RecordingDebugRenderer *>(
        ((JPH::DebugRendererSimple *)object)
    ));
}

void RecordingDebugRenderer_Destroy(const RecordingDebugRenderer *_this)
{
    delete ((const RecordingDebugRenderer *)_this);
}

void RecordingDebugRenderer_DestroyArray(const RecordingDebugRenderer *_this)
{
    delete[] ((const RecordingDebugRenderer *)_this);
}

void RecordingDebugRenderer_Clear(RecordingDebugRenderer *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).Clear();
}

unsigned int RecordingDebugRenderer_GetLineCount(const RecordingDebugRenderer *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const RecordingDebugRenderer *)(_this)).GetLineCount();
}

unsigned int RecordingDebugRenderer_GetTriangleCount(const RecordingDebugRenderer *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const RecordingDebugRenderer *)(_this)).GetTriangleCount();
}

const DebugLineRecord *RecordingDebugRenderer_GetLine(const RecordingDebugRenderer *_this, unsigned int inIndex)
{
    return (const DebugLineRecord *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const RecordingDebugRenderer *)(_this)).GetLine(
        inIndex
    ));
}

const DebugTriangleRecord *RecordingDebugRenderer_GetTriangle(const RecordingDebugRenderer *_this, unsigned int inIndex)
{
    return (const DebugTriangleRecord *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const RecordingDebugRenderer *)(_this)).GetTriangle(
        inIndex
    ));
}

void RecordingDebugRenderer_DrawLine(RecordingDebugRenderer *_this, const JPH_Vec3 *inFrom, const JPH_Vec3 *inTo, const JPH_Color *inColor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawLine(
        ((inFrom ? void() : MRBINDC_THROW("Parameter `inFrom` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inFrom)),
        ((inTo ? void() : MRBINDC_THROW("Parameter `inTo` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTo)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor))
    );
}

void RecordingDebugRenderer_DrawTriangle(RecordingDebugRenderer *_this, const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor, JPH_DebugRenderer_ECastShadow inCastShadow)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawTriangle(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2)),
        ((inV3 ? void() : MRBINDC_THROW("Parameter `inV3` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV3)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        ((JPH::DebugRenderer::ECastShadow)inCastShadow)
    );
}

void RecordingDebugRenderer_SetCameraPos(RecordingDebugRenderer *_this, const JPH_Vec3 *inCameraPos)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).SetCameraPos(
        ((inCameraPos ? void() : MRBINDC_THROW("Parameter `inCameraPos` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCameraPos))
    );
}

void RecordingDebugRenderer_NextFrame(RecordingDebugRenderer *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).NextFrame();
}

void RecordingDebugRenderer_DrawMarker(RecordingDebugRenderer *_this, const JPH_Vec3 *inPosition, const JPH_Color *inColor, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawMarker(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inSize
    );
}

void RecordingDebugRenderer_DrawArrow(RecordingDebugRenderer *_this, const JPH_Vec3 *inFrom, const JPH_Vec3 *inTo, const JPH_Color *inColor, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawArrow(
        ((inFrom ? void() : MRBINDC_THROW("Parameter `inFrom` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inFrom)),
        ((inTo ? void() : MRBINDC_THROW("Parameter `inTo` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTo)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inSize
    );
}

void RecordingDebugRenderer_DrawCoordinateSystem(RecordingDebugRenderer *_this, const JPH_Mat44 *inTransform, const float *inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawCoordinateSystem(
        ((inTransform ? void() : MRBINDC_THROW("Parameter `inTransform` can not be null.", void)), *(const JPH::Mat44 *)(inTransform)),
        (inSize ? *inSize : static_cast<float>(1.F))
    );
}

void RecordingDebugRenderer_DrawPlane(RecordingDebugRenderer *_this, const JPH_Vec3 *inPoint, const JPH_Vec3 *inNormal, const JPH_Color *inColor, float inSize)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawPlane(
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPoint)),
        ((inNormal ? void() : MRBINDC_THROW("Parameter `inNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inNormal)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        inSize
    );
}

void RecordingDebugRenderer_DrawWireTriangle(RecordingDebugRenderer *_this, const JPH_Vec3 *inV1, const JPH_Vec3 *inV2, const JPH_Vec3 *inV3, const JPH_Color *inColor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawWireTriangle(
        ((inV1 ? void() : MRBINDC_THROW("Parameter `inV1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV1)),
        ((inV2 ? void() : MRBINDC_THROW("Parameter `inV2` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV2)),
        ((inV3 ? void() : MRBINDC_THROW("Parameter `inV3` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV3)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor))
    );
}

void RecordingDebugRenderer_DrawWireSphere(RecordingDebugRenderer *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Color *inColor, const int *inLevel)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawWireSphere(
        ((inCenter ? void() : MRBINDC_THROW("Parameter `inCenter` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCenter)),
        inRadius,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inLevel ? *inLevel : static_cast<int>(3))
    );
}

void RecordingDebugRenderer_DrawWireUnitSphere(RecordingDebugRenderer *_this, const JPH_Mat44 *inMatrix, const JPH_Color *inColor, const int *inLevel)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawWireUnitSphere(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inLevel ? *inLevel : static_cast<int>(3))
    );
}

void RecordingDebugRenderer_DrawSphere(RecordingDebugRenderer *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawSphere(
        ((inCenter ? void() : MRBINDC_THROW("Parameter `inCenter` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCenter)),
        inRadius,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void RecordingDebugRenderer_DrawUnitSphere(RecordingDebugRenderer *_this, const JPH_Mat44 *inMatrix, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawUnitSphere(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void RecordingDebugRenderer_DrawCapsule(RecordingDebugRenderer *_this, const JPH_Mat44 *inMatrix, float inHalfHeightOfCylinder, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawCapsule(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        inHalfHeightOfCylinder,
        inRadius,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void RecordingDebugRenderer_DrawCylinder(RecordingDebugRenderer *_this, const JPH_Mat44 *inMatrix, float inHalfHeight, float inRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawCylinder(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        inHalfHeight,
        inRadius,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void RecordingDebugRenderer_DrawOpenCone(RecordingDebugRenderer *_this, const JPH_Vec3 *inTop, const JPH_Vec3 *inAxis, const JPH_Vec3 *inPerpendicular, float inHalfAngle, float inLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawOpenCone(
        ((inTop ? void() : MRBINDC_THROW("Parameter `inTop` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTop)),
        ((inAxis ? void() : MRBINDC_THROW("Parameter `inAxis` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAxis)),
        ((inPerpendicular ? void() : MRBINDC_THROW("Parameter `inPerpendicular` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPerpendicular)),
        inHalfAngle,
        inLength,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void RecordingDebugRenderer_DrawSwingConeLimits(RecordingDebugRenderer *_this, const JPH_Mat44 *inMatrix, float inSwingYHalfAngle, float inSwingZHalfAngle, float inEdgeLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawSwingConeLimits(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        inSwingYHalfAngle,
        inSwingZHalfAngle,
        inEdgeLength,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void RecordingDebugRenderer_DrawSwingPyramidLimits(RecordingDebugRenderer *_this, const JPH_Mat44 *inMatrix, float inMinSwingYAngle, float inMaxSwingYAngle, float inMinSwingZAngle, float inMaxSwingZAngle, float inEdgeLength, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawSwingPyramidLimits(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        inMinSwingYAngle,
        inMaxSwingYAngle,
        inMinSwingZAngle,
        inMaxSwingZAngle,
        inEdgeLength,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void RecordingDebugRenderer_DrawPie(RecordingDebugRenderer *_this, const JPH_Vec3 *inCenter, float inRadius, const JPH_Vec3 *inNormal, const JPH_Vec3 *inAxis, float inMinAngle, float inMaxAngle, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawPie(
        ((inCenter ? void() : MRBINDC_THROW("Parameter `inCenter` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inCenter)),
        inRadius,
        ((inNormal ? void() : MRBINDC_THROW("Parameter `inNormal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inNormal)),
        ((inAxis ? void() : MRBINDC_THROW("Parameter `inAxis` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAxis)),
        inMinAngle,
        inMaxAngle,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

void RecordingDebugRenderer_DrawTaperedCylinder(RecordingDebugRenderer *_this, const JPH_Mat44 *inMatrix, float inTop, float inBottom, float inTopRadius, float inBottomRadius, const JPH_Color *inColor, const JPH_DebugRenderer_ECastShadow *inCastShadow, const JPH_DebugRenderer_EDrawMode *inDrawMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(RecordingDebugRenderer *)(_this)).DrawTaperedCylinder(
        ((inMatrix ? void() : MRBINDC_THROW("Parameter `inMatrix` can not be null.", void)), *(const JPH::Mat44 *)(inMatrix)),
        inTop,
        inBottom,
        inTopRadius,
        inBottomRadius,
        ((inColor ? void() : MRBINDC_THROW("Parameter `inColor` can not be null.", void)), JPH::Color(*(JPH::Color *)inColor)),
        (inCastShadow ? (JPH::DebugRenderer::ECastShadow)(*inCastShadow) : static_cast<JPH::DebugRenderer::ECastShadow>(JPH::DebugRenderer::ECastShadow::On)),
        (inDrawMode ? (JPH::DebugRenderer::EDrawMode)(*inDrawMode) : static_cast<JPH::DebugRenderer::EDrawMode>(JPH::DebugRenderer::EDrawMode::Solid))
    );
}

JPH_AABox *RecordingDebugRenderer_sCalculateBounds(const JPH_DebugRenderer_Vertex *inVertices, int inVertexCount)
{
    return (JPH_AABox *)new JPH::AABox(RecordingDebugRenderer::sCalculateBounds(
        ((const JPH::DebugRenderer::Vertex *)inVertices),
        inVertexCount
    ));
}

