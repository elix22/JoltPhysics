// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Body/BodyInterface.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Geometry/AABox.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyCreationSettings.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Body/BodyInterface.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>
#include <Jolt/Physics/Collision/CollisionGroup.h>
#include <Jolt/Physics/Collision/ObjectLayer.h>
#include <Jolt/Physics/Collision/PhysicsMaterial.h>
#include <Jolt/Physics/Collision/Shape/Shape.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/Constraints/TwoBodyConstraint.h>
#include <Jolt/Physics/EActivation.h>
#include <Jolt/Physics/SoftBody/SoftBodyCreationSettings.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstdint>
#include <memory>
#include <stdexcept>


JPH_BodyInterface *JPH_BodyInterface_DefaultConstruct(void)
{
    return (JPH_BodyInterface *)new JPH::BodyInterface(JPH::BodyInterface());
}

JPH_BodyInterface *JPH_BodyInterface_DefaultConstructArray(size_t num_elems)
{
    return (JPH_BodyInterface *)(new JPH::BodyInterface[num_elems]{});
}

const JPH_BodyInterface *JPH_BodyInterface_OffsetPtr(const JPH_BodyInterface *ptr, ptrdiff_t i)
{
    return (const JPH_BodyInterface *)(((const JPH::BodyInterface *)ptr) + i);
}

JPH_BodyInterface *JPH_BodyInterface_OffsetMutablePtr(JPH_BodyInterface *ptr, ptrdiff_t i)
{
    return (JPH_BodyInterface *)(((JPH::BodyInterface *)ptr) + i);
}

const JPH_NonCopyable *JPH_BodyInterface_UpcastTo_JPH_NonCopyable(const JPH_BodyInterface *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::BodyInterface *)object)
    ));
}

JPH_NonCopyable *JPH_BodyInterface_MutableUpcastTo_JPH_NonCopyable(JPH_BodyInterface *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::BodyInterface *)object)
    ));
}

const JPH_BodyInterface *JPH_BodyInterface_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_BodyInterface *)(static_cast<const JPH::BodyInterface *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_BodyInterface *JPH_BodyInterface_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_BodyInterface *)(static_cast<JPH::BodyInterface *>(
        ((JPH::NonCopyable *)object)
    ));
}

void JPH_BodyInterface_Destroy(const JPH_BodyInterface *_this)
{
    delete ((const JPH::BodyInterface *)_this);
}

void JPH_BodyInterface_DestroyArray(const JPH_BodyInterface *_this)
{
    delete[] ((const JPH::BodyInterface *)_this);
}

JPH_Body *JPH_BodyInterface_CreateBody(JPH_BodyInterface *_this, const JPH_BodyCreationSettings *inSettings)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).CreateBody(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::BodyCreationSettings *)(inSettings))
    ));
}

JPH_Body *JPH_BodyInterface_CreateSoftBody(JPH_BodyInterface *_this, const JPH_SoftBodyCreationSettings *inSettings)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).CreateSoftBody(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(inSettings))
    ));
}

JPH_Body *JPH_BodyInterface_CreateBodyWithID(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_BodyCreationSettings *inSettings)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).CreateBodyWithID(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::BodyCreationSettings *)(inSettings))
    ));
}

JPH_Body *JPH_BodyInterface_CreateSoftBodyWithID(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_SoftBodyCreationSettings *inSettings)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).CreateSoftBodyWithID(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(inSettings))
    ));
}

JPH_Body *JPH_BodyInterface_CreateBodyWithoutID(const JPH_BodyInterface *_this, const JPH_BodyCreationSettings *inSettings)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).CreateBodyWithoutID(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::BodyCreationSettings *)(inSettings))
    ));
}

JPH_Body *JPH_BodyInterface_CreateSoftBodyWithoutID(const JPH_BodyInterface *_this, const JPH_SoftBodyCreationSettings *inSettings)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).CreateSoftBodyWithoutID(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(inSettings))
    ));
}

void JPH_BodyInterface_DestroyBodyWithoutID(const JPH_BodyInterface *_this, JPH_Body *inBody)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).DestroyBodyWithoutID(
        ((JPH::Body *)inBody)
    );
}

bool JPH_BodyInterface_AssignBodyID_1(JPH_BodyInterface *_this, JPH_Body *ioBody)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AssignBodyID(
        ((JPH::Body *)ioBody)
    );
}

bool JPH_BodyInterface_AssignBodyID_2(JPH_BodyInterface *_this, JPH_Body *ioBody, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AssignBodyID(
        ((JPH::Body *)ioBody),
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

JPH_Body *JPH_BodyInterface_UnassignBodyID(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return (JPH_Body *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).UnassignBodyID(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    ));
}

void JPH_BodyInterface_UnassignBodyIDs(JPH_BodyInterface *_this, const JPH_BodyID *inBodyIDs, int inNumber, JPH_Body **outBodies)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).UnassignBodyIDs(
        ((const JPH::BodyID *)inBodyIDs),
        inNumber,
        ((JPH::Body **)outBodies)
    );
}

void JPH_BodyInterface_DestroyBody(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).DestroyBody(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

void JPH_BodyInterface_DestroyBodies(JPH_BodyInterface *_this, const JPH_BodyID *inBodyIDs, int inNumber)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).DestroyBodies(
        ((const JPH::BodyID *)inBodyIDs),
        inNumber
    );
}

void JPH_BodyInterface_AddBody(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, JPH_EActivation inActivationMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AddBody(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((JPH::EActivation)inActivationMode)
    );
}

void JPH_BodyInterface_RemoveBody(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).RemoveBody(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

bool JPH_BodyInterface_IsAdded(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).IsAdded(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

JPH_BodyID JPH_BodyInterface_CreateAndAddBody(JPH_BodyInterface *_this, const JPH_BodyCreationSettings *inSettings, JPH_EActivation inActivationMode)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).CreateAndAddBody(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::BodyCreationSettings *)(inSettings)),
        ((JPH::EActivation)inActivationMode)
    ));
}

JPH_BodyID JPH_BodyInterface_CreateAndAddSoftBody(JPH_BodyInterface *_this, const JPH_SoftBodyCreationSettings *inSettings, JPH_EActivation inActivationMode)
{
    return MRBINDC_BIT_CAST((JPH_BodyID), ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).CreateAndAddSoftBody(
        ((inSettings ? void() : MRBINDC_THROW("Parameter `inSettings` can not be null.", void)), *(const JPH::SoftBodyCreationSettings *)(inSettings)),
        ((JPH::EActivation)inActivationMode)
    ));
}

void *JPH_BodyInterface_AddBodiesPrepare(JPH_BodyInterface *_this, JPH_BodyID *ioBodies, int inNumber)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AddBodiesPrepare(
        ((JPH::BodyID *)ioBodies),
        inNumber
    );
}

void JPH_BodyInterface_AddBodiesFinalize(JPH_BodyInterface *_this, JPH_BodyID *ioBodies, int inNumber, void *inAddState, JPH_EActivation inActivationMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AddBodiesFinalize(
        ((JPH::BodyID *)ioBodies),
        inNumber,
        inAddState,
        ((JPH::EActivation)inActivationMode)
    );
}

void JPH_BodyInterface_AddBodiesAbort(JPH_BodyInterface *_this, JPH_BodyID *ioBodies, int inNumber, void *inAddState)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AddBodiesAbort(
        ((JPH::BodyID *)ioBodies),
        inNumber,
        inAddState
    );
}

void JPH_BodyInterface_RemoveBodies(JPH_BodyInterface *_this, JPH_BodyID *ioBodies, int inNumber)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).RemoveBodies(
        ((JPH::BodyID *)ioBodies),
        inNumber
    );
}

void JPH_BodyInterface_ActivateBody(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).ActivateBody(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

void JPH_BodyInterface_ActivateBodies(JPH_BodyInterface *_this, const JPH_BodyID *inBodyIDs, int inNumber)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).ActivateBodies(
        ((const JPH::BodyID *)inBodyIDs),
        inNumber
    );
}

void JPH_BodyInterface_ActivateBodiesInAABox(JPH_BodyInterface *_this, const JPH_AABox *inBox, const JPH_BroadPhaseLayerFilter *inBroadPhaseLayerFilter, const JPH_ObjectLayerFilter *inObjectLayerFilter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).ActivateBodiesInAABox(
        ((inBox ? void() : MRBINDC_THROW("Parameter `inBox` can not be null.", void)), *(const JPH::AABox *)(inBox)),
        ((inBroadPhaseLayerFilter ? void() : MRBINDC_THROW("Parameter `inBroadPhaseLayerFilter` can not be null.", void)), *(const JPH::BroadPhaseLayerFilter *)(inBroadPhaseLayerFilter)),
        ((inObjectLayerFilter ? void() : MRBINDC_THROW("Parameter `inObjectLayerFilter` can not be null.", void)), *(const JPH::ObjectLayerFilter *)(inObjectLayerFilter))
    );
}

void JPH_BodyInterface_DeactivateBody(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).DeactivateBody(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

void JPH_BodyInterface_DeactivateBodies(JPH_BodyInterface *_this, const JPH_BodyID *inBodyIDs, int inNumber)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).DeactivateBodies(
        ((const JPH::BodyID *)inBodyIDs),
        inNumber
    );
}

bool JPH_BodyInterface_IsActive(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).IsActive(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

void JPH_BodyInterface_ResetSleepTimer(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).ResetSleepTimer(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

JPH_TwoBodyConstraint *JPH_BodyInterface_CreateConstraint(JPH_BodyInterface *_this, const JPH_TwoBodyConstraintSettings *inSettings, const JPH_BodyID *inBodyID1, const JPH_BodyID *inBodyID2)
{
    return (JPH_TwoBodyConstraint *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).CreateConstraint(
        ((const JPH::TwoBodyConstraintSettings *)inSettings),
        ((inBodyID1 ? void() : MRBINDC_THROW("Parameter `inBodyID1` can not be null.", void)), *(const JPH::BodyID *)(inBodyID1)),
        ((inBodyID2 ? void() : MRBINDC_THROW("Parameter `inBodyID2` can not be null.", void)), *(const JPH::BodyID *)(inBodyID2))
    ));
}

void JPH_BodyInterface_ActivateConstraint(JPH_BodyInterface *_this, const JPH_TwoBodyConstraint *inConstraint)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).ActivateConstraint(
        ((const JPH::TwoBodyConstraint *)inConstraint)
    );
}

void JPH_BodyInterface_SetShape(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Shape *inShape, bool inUpdateMassProperties, JPH_EActivation inActivationMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).SetShape(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((const JPH::Shape *)inShape),
        inUpdateMassProperties,
        ((JPH::EActivation)inActivationMode)
    );
}

void JPH_BodyInterface_NotifyShapeChanged(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inPreviousCenterOfMass, bool inUpdateMassProperties, JPH_EActivation inActivationMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).NotifyShapeChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inPreviousCenterOfMass ? void() : MRBINDC_THROW("Parameter `inPreviousCenterOfMass` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPreviousCenterOfMass)),
        inUpdateMassProperties,
        ((JPH::EActivation)inActivationMode)
    );
}

void JPH_BodyInterface_SetObjectLayer(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, unsigned short inLayer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetObjectLayer(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        inLayer
    );
}

unsigned short JPH_BodyInterface_GetObjectLayer(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetObjectLayer(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

void JPH_BodyInterface_SetPositionAndRotation(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, JPH_EActivation inActivationMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetPositionAndRotation(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((JPH::EActivation)inActivationMode)
    );
}

void JPH_BodyInterface_SetPositionAndRotationWhenChanged(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, JPH_EActivation inActivationMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetPositionAndRotationWhenChanged(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((JPH::EActivation)inActivationMode)
    );
}

void JPH_BodyInterface_GetPositionAndRotation(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, JPH_Vec3 *outPosition, JPH_Quat *outRotation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetPositionAndRotation(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((outPosition ? void() : MRBINDC_THROW("Parameter `outPosition` can not be null.", void)), *(JPH::Vec3 *)(outPosition)),
        ((outRotation ? void() : MRBINDC_THROW("Parameter `outRotation` can not be null.", void)), *(JPH::Quat *)(outRotation))
    );
}

void JPH_BodyInterface_SetPosition(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inPosition, JPH_EActivation inActivationMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetPosition(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((JPH::EActivation)inActivationMode)
    );
}

JPH_Vec3 *JPH_BodyInterface_GetPosition(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetPosition(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    ));
}

JPH_Vec3 *JPH_BodyInterface_GetCenterOfMassPosition(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetCenterOfMassPosition(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    ));
}

void JPH_BodyInterface_SetRotation(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Quat *inRotation, JPH_EActivation inActivationMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetRotation(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((JPH::EActivation)inActivationMode)
    );
}

JPH_Quat *JPH_BodyInterface_GetRotation(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetRotation(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    ));
}

JPH_Mat44 *JPH_BodyInterface_GetWorldTransform(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetWorldTransform(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    ));
}

JPH_Mat44 *JPH_BodyInterface_GetCenterOfMassTransform(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetCenterOfMassTransform(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    ));
}

void JPH_BodyInterface_MoveKinematic(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inTargetPosition, const JPH_Quat *inTargetRotation, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).MoveKinematic(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inTargetPosition ? void() : MRBINDC_THROW("Parameter `inTargetPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTargetPosition)),
        ((inTargetRotation ? void() : MRBINDC_THROW("Parameter `inTargetRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inTargetRotation)),
        inDeltaTime
    );
}

void JPH_BodyInterface_SetLinearAndAngularVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inLinearVelocity, const JPH_Vec3 *inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetLinearAndAngularVelocity(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity)),
        ((inAngularVelocity ? void() : MRBINDC_THROW("Parameter `inAngularVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocity))
    );
}

void JPH_BodyInterface_GetLinearAndAngularVelocity(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, JPH_Vec3 *outLinearVelocity, JPH_Vec3 *outAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetLinearAndAngularVelocity(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((outLinearVelocity ? void() : MRBINDC_THROW("Parameter `outLinearVelocity` can not be null.", void)), *(JPH::Vec3 *)(outLinearVelocity)),
        ((outAngularVelocity ? void() : MRBINDC_THROW("Parameter `outAngularVelocity` can not be null.", void)), *(JPH::Vec3 *)(outAngularVelocity))
    );
}

void JPH_BodyInterface_SetLinearVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inLinearVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetLinearVelocity(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity))
    );
}

JPH_Vec3 *JPH_BodyInterface_GetLinearVelocity(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetLinearVelocity(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    ));
}

void JPH_BodyInterface_AddLinearVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inLinearVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AddLinearVelocity(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity))
    );
}

void JPH_BodyInterface_AddLinearAndAngularVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inLinearVelocity, const JPH_Vec3 *inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AddLinearAndAngularVelocity(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity)),
        ((inAngularVelocity ? void() : MRBINDC_THROW("Parameter `inAngularVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocity))
    );
}

void JPH_BodyInterface_SetAngularVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetAngularVelocity(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inAngularVelocity ? void() : MRBINDC_THROW("Parameter `inAngularVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocity))
    );
}

JPH_Vec3 *JPH_BodyInterface_GetAngularVelocity(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetAngularVelocity(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    ));
}

JPH_Vec3 *JPH_BodyInterface_GetPointVelocity(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inPoint)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetPointVelocity(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPoint))
    ));
}

void JPH_BodyInterface_SetPositionRotationAndVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inPosition, const JPH_Quat *inRotation, const JPH_Vec3 *inLinearVelocity, const JPH_Vec3 *inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetPositionRotationAndVelocity(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPosition)),
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRotation)),
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity)),
        ((inAngularVelocity ? void() : MRBINDC_THROW("Parameter `inAngularVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocity))
    );
}

void JPH_BodyInterface_AddForce_3(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inForce, const JPH_EActivation *inActivationMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AddForce(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inForce ? void() : MRBINDC_THROW("Parameter `inForce` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inForce)),
        (inActivationMode ? (JPH::EActivation)(*inActivationMode) : static_cast<JPH::EActivation>(JPH::EActivation::Activate))
    );
}

void JPH_BodyInterface_AddForce_4(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inForce, const JPH_Vec3 *inPoint, const JPH_EActivation *inActivationMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AddForce(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inForce ? void() : MRBINDC_THROW("Parameter `inForce` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inForce)),
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPoint)),
        (inActivationMode ? (JPH::EActivation)(*inActivationMode) : static_cast<JPH::EActivation>(JPH::EActivation::Activate))
    );
}

void JPH_BodyInterface_AddTorque(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inTorque, const JPH_EActivation *inActivationMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AddTorque(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inTorque ? void() : MRBINDC_THROW("Parameter `inTorque` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTorque)),
        (inActivationMode ? (JPH::EActivation)(*inActivationMode) : static_cast<JPH::EActivation>(JPH::EActivation::Activate))
    );
}

void JPH_BodyInterface_AddForceAndTorque(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inForce, const JPH_Vec3 *inTorque, const JPH_EActivation *inActivationMode)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AddForceAndTorque(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inForce ? void() : MRBINDC_THROW("Parameter `inForce` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inForce)),
        ((inTorque ? void() : MRBINDC_THROW("Parameter `inTorque` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inTorque)),
        (inActivationMode ? (JPH::EActivation)(*inActivationMode) : static_cast<JPH::EActivation>(JPH::EActivation::Activate))
    );
}

void JPH_BodyInterface_AddImpulse_2(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inImpulse)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AddImpulse(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inImpulse ? void() : MRBINDC_THROW("Parameter `inImpulse` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inImpulse))
    );
}

void JPH_BodyInterface_AddImpulse_3(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inImpulse, const JPH_Vec3 *inPoint)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AddImpulse(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inImpulse ? void() : MRBINDC_THROW("Parameter `inImpulse` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inImpulse)),
        ((inPoint ? void() : MRBINDC_THROW("Parameter `inPoint` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPoint))
    );
}

void JPH_BodyInterface_AddAngularImpulse(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inAngularImpulse)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).AddAngularImpulse(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inAngularImpulse ? void() : MRBINDC_THROW("Parameter `inAngularImpulse` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularImpulse))
    );
}

bool JPH_BodyInterface_ApplyBuoyancyImpulse(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_Vec3 *inSurfacePosition, const JPH_Vec3 *inSurfaceNormal, float inBuoyancy, float inLinearDrag, float inAngularDrag, const JPH_Vec3 *inFluidVelocity, const JPH_Vec3 *inGravity, float inDeltaTime)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).ApplyBuoyancyImpulse(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
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

JPH_Mat44 *JPH_BodyInterface_GetInverseInertia(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetInverseInertia(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    ));
}

void JPH_BodyInterface_SetRestitution(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, float inRestitution)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetRestitution(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        inRestitution
    );
}

float JPH_BodyInterface_GetRestitution(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetRestitution(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

void JPH_BodyInterface_SetFriction(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, float inFriction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetFriction(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        inFriction
    );
}

float JPH_BodyInterface_GetFriction(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetFriction(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

void JPH_BodyInterface_SetGravityFactor(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, float inGravityFactor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetGravityFactor(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        inGravityFactor
    );
}

float JPH_BodyInterface_GetGravityFactor(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetGravityFactor(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

void JPH_BodyInterface_SetMaxLinearVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, float inLinearVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetMaxLinearVelocity(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        inLinearVelocity
    );
}

float JPH_BodyInterface_GetMaxLinearVelocity(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetMaxLinearVelocity(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

void JPH_BodyInterface_SetMaxAngularVelocity(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, float inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetMaxAngularVelocity(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        inAngularVelocity
    );
}

float JPH_BodyInterface_GetMaxAngularVelocity(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetMaxAngularVelocity(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

void JPH_BodyInterface_SetUseManifoldReduction(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, bool inUseReduction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetUseManifoldReduction(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        inUseReduction
    );
}

bool JPH_BodyInterface_GetUseManifoldReduction(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetUseManifoldReduction(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

void JPH_BodyInterface_SetIsSensor(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, bool inIsSensor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetIsSensor(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        inIsSensor
    );
}

bool JPH_BodyInterface_IsSensor(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).IsSensor(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

void JPH_BodyInterface_SetCollisionGroup(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_CollisionGroup *inCollisionGroup)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).SetCollisionGroup(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inCollisionGroup ? void() : MRBINDC_THROW("Parameter `inCollisionGroup` can not be null.", void)), *(const JPH::CollisionGroup *)(inCollisionGroup))
    );
}

const JPH_CollisionGroup *JPH_BodyInterface_GetCollisionGroup(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return (const JPH_CollisionGroup *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetCollisionGroup(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    ));
}

uint64_t JPH_BodyInterface_GetUserData(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetUserData(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

void JPH_BodyInterface_SetUserData(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, uint64_t inUserData)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).SetUserData(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        inUserData
    );
}

const JPH_PhysicsMaterial *JPH_BodyInterface_GetMaterial(const JPH_BodyInterface *_this, const JPH_BodyID *inBodyID, const JPH_SubShapeID *inSubShapeID)
{
    return (const JPH_PhysicsMaterial *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::BodyInterface *)(_this)).GetMaterial(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID)),
        ((inSubShapeID ? void() : MRBINDC_THROW("Parameter `inSubShapeID` can not be null.", void)), *(const JPH::SubShapeID *)(inSubShapeID))
    ));
}

void JPH_BodyInterface_InvalidateContactCache(JPH_BodyInterface *_this, const JPH_BodyID *inBodyID)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::BodyInterface *)(_this)).InvalidateContactCache(
        ((inBodyID ? void() : MRBINDC_THROW("Parameter `inBodyID` can not be null.", void)), *(const JPH::BodyID *)(inBodyID))
    );
}

