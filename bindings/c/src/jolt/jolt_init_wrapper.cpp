// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/jolt_init_wrapper.h"

#include <Jolt/Geometry/RayAABox.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Collision/CollideShape.h>
#include <Jolt/Physics/Collision/ContactListener.h>
#include <Jolt/Physics/Collision/Shape/HeightFieldShape.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeIDPair.h>
#include <Jolt/Physics/PhysicsStepListener.h>
#include <Jolt/Physics/PhysicsSystem.h>
#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <Jolt/Physics/Vehicle/VehicleAntiRollBar.h>
#include <Jolt/Physics/Vehicle/VehicleConstraint.h>
#include <Jolt/Physics/Vehicle/VehicleDifferential.h>
#include <Jolt/Physics/Vehicle/WheeledVehicleController.h>
#include <__mrbind_c_details.h>
#include <jolt_init_wrapper.h>

#include <cstddef>
#include <cstring>
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
    return (JoltHelpers *)(new JoltHelpers[num_elems]{});
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

void JoltHelpers_VehicleSettingsSetController(JPH_VehicleConstraintSettings *settings, JPH_WheeledVehicleControllerSettings *ctrl)
{
    JoltHelpers::VehicleSettingsSetController(
        ((settings ? void() : MRBINDC_THROW("Parameter `settings` can not be null.", void)), *(JPH::VehicleConstraintSettings *)(settings)),
        ((JPH::WheeledVehicleControllerSettings *)ctrl)
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
    return (CountingPhysicsStepListener *)(new CountingPhysicsStepListener[num_elems]{});
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
    return (SimpleContactEventListener *)(new SimpleContactEventListener[num_elems]{});
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
    return (EstimateResponseContactListener *)(new EstimateResponseContactListener[num_elems]{});
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

