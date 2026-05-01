// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Vehicle/VehicleCollisionTester.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Body/BodyFilter.h>
#include <Jolt/Physics/Body/BodyID.h>
#include <Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h>
#include <Jolt/Physics/Collision/ObjectLayer.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <Jolt/Physics/PhysicsSystem.h>
#include <Jolt/Physics/Vehicle/VehicleCollisionTester.h>
#include <Jolt/Physics/Vehicle/VehicleConstraint.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


void JPH_VehicleCollisionTester_Destroy(const JPH_VehicleCollisionTester *_this)
{
    delete ((const JPH::VehicleCollisionTester *)_this);
}

void JPH_VehicleCollisionTester_DestroyArray(const JPH_VehicleCollisionTester *_this)
{
    delete[] ((const JPH::VehicleCollisionTester *)_this);
}

void *Jolt_new_JPH_VehicleCollisionTester_size_t(size_t inCount)
{
    return JPH::VehicleCollisionTester::operator new(
        inCount
    );
}

void Jolt_delete_JPH_VehicleCollisionTester_void_ptr(void *inPointer)
{
    JPH::VehicleCollisionTester::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_VehicleCollisionTester_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleCollisionTester::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_VehicleCollisionTester_size_t(size_t inCount)
{
    return JPH::VehicleCollisionTester::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr(void *inPointer)
{
    JPH::VehicleCollisionTester::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleCollisionTester::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_VehicleCollisionTester_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleCollisionTester::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_VehicleCollisionTester_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleCollisionTester::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_VehicleCollisionTester_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleCollisionTester::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleCollisionTester::operator delete[](
        inPointer,
        inPlace
    );
}

unsigned short JPH_VehicleCollisionTester_GetObjectLayer(const JPH_VehicleCollisionTester *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTester *)(_this)).GetObjectLayer();
}

void JPH_VehicleCollisionTester_SetObjectLayer(JPH_VehicleCollisionTester *_this, unsigned short inObjectLayer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTester *)(_this)).SetObjectLayer(
        inObjectLayer
    );
}

void JPH_VehicleCollisionTester_SetBroadPhaseLayerFilter(JPH_VehicleCollisionTester *_this, const JPH_BroadPhaseLayerFilter *inFilter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTester *)(_this)).SetBroadPhaseLayerFilter(
        ((const JPH::BroadPhaseLayerFilter *)inFilter)
    );
}

const JPH_BroadPhaseLayerFilter *JPH_VehicleCollisionTester_GetBroadPhaseLayerFilter(const JPH_VehicleCollisionTester *_this)
{
    return (const JPH_BroadPhaseLayerFilter *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTester *)(_this)).GetBroadPhaseLayerFilter());
}

void JPH_VehicleCollisionTester_SetObjectLayerFilter(JPH_VehicleCollisionTester *_this, const JPH_ObjectLayerFilter *inFilter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTester *)(_this)).SetObjectLayerFilter(
        ((const JPH::ObjectLayerFilter *)inFilter)
    );
}

const JPH_ObjectLayerFilter *JPH_VehicleCollisionTester_GetObjectLayerFilter(const JPH_VehicleCollisionTester *_this)
{
    return (const JPH_ObjectLayerFilter *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTester *)(_this)).GetObjectLayerFilter());
}

void JPH_VehicleCollisionTester_SetBodyFilter(JPH_VehicleCollisionTester *_this, const JPH_BodyFilter *inFilter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTester *)(_this)).SetBodyFilter(
        ((const JPH::BodyFilter *)inFilter)
    );
}

const JPH_BodyFilter *JPH_VehicleCollisionTester_GetBodyFilter(const JPH_VehicleCollisionTester *_this)
{
    return (const JPH_BodyFilter *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTester *)(_this)).GetBodyFilter());
}

bool JPH_VehicleCollisionTester_Collide(const JPH_VehicleCollisionTester *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **outBody, JPH_SubShapeID *outSubShapeID, JPH_Vec3 *outContactPosition, JPH_Vec3 *outContactNormal, float *outSuspensionLength)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTester *)(_this)).Collide(
        ((inPhysicsSystem ? void() : MRBINDC_THROW("Parameter `inPhysicsSystem` can not be null.", void)), *(JPH::PhysicsSystem *)(inPhysicsSystem)),
        ((inVehicleConstraint ? void() : MRBINDC_THROW("Parameter `inVehicleConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inVehicleConstraint)),
        inWheelIndex,
        ((inOrigin ? void() : MRBINDC_THROW("Parameter `inOrigin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOrigin)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection)),
        ((inVehicleBodyID ? void() : MRBINDC_THROW("Parameter `inVehicleBodyID` can not be null.", void)), *(const JPH::BodyID *)(inVehicleBodyID)),
        ((outBody ? void() : MRBINDC_THROW("Parameter `outBody` can not be null.", void)), *(JPH::Body **)(outBody)),
        ((outSubShapeID ? void() : MRBINDC_THROW("Parameter `outSubShapeID` can not be null.", void)), *(JPH::SubShapeID *)(outSubShapeID)),
        ((outContactPosition ? void() : MRBINDC_THROW("Parameter `outContactPosition` can not be null.", void)), *(JPH::Vec3 *)(outContactPosition)),
        ((outContactNormal ? void() : MRBINDC_THROW("Parameter `outContactNormal` can not be null.", void)), *(JPH::Vec3 *)(outContactNormal)),
        ((outSuspensionLength ? void() : MRBINDC_THROW("Parameter `outSuspensionLength` can not be null.", void)), *outSuspensionLength)
    );
}

void JPH_VehicleCollisionTester_PredictContactProperties(const JPH_VehicleCollisionTester *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **ioBody, JPH_SubShapeID *ioSubShapeID, JPH_Vec3 *ioContactPosition, JPH_Vec3 *ioContactNormal, float *ioSuspensionLength)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTester *)(_this)).PredictContactProperties(
        ((inPhysicsSystem ? void() : MRBINDC_THROW("Parameter `inPhysicsSystem` can not be null.", void)), *(JPH::PhysicsSystem *)(inPhysicsSystem)),
        ((inVehicleConstraint ? void() : MRBINDC_THROW("Parameter `inVehicleConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inVehicleConstraint)),
        inWheelIndex,
        ((inOrigin ? void() : MRBINDC_THROW("Parameter `inOrigin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOrigin)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection)),
        ((inVehicleBodyID ? void() : MRBINDC_THROW("Parameter `inVehicleBodyID` can not be null.", void)), *(const JPH::BodyID *)(inVehicleBodyID)),
        ((ioBody ? void() : MRBINDC_THROW("Parameter `ioBody` can not be null.", void)), *(JPH::Body **)(ioBody)),
        ((ioSubShapeID ? void() : MRBINDC_THROW("Parameter `ioSubShapeID` can not be null.", void)), *(JPH::SubShapeID *)(ioSubShapeID)),
        ((ioContactPosition ? void() : MRBINDC_THROW("Parameter `ioContactPosition` can not be null.", void)), *(JPH::Vec3 *)(ioContactPosition)),
        ((ioContactNormal ? void() : MRBINDC_THROW("Parameter `ioContactNormal` can not be null.", void)), *(JPH::Vec3 *)(ioContactNormal)),
        ((ioSuspensionLength ? void() : MRBINDC_THROW("Parameter `ioSuspensionLength` can not be null.", void)), *ioSuspensionLength)
    );
}

void JPH_VehicleCollisionTester_SetEmbedded(const JPH_VehicleCollisionTester *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTester *)(_this)).SetEmbedded();
}

unsigned int JPH_VehicleCollisionTester_GetRefCount(const JPH_VehicleCollisionTester *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTester *)(_this)).GetRefCount();
}

void JPH_VehicleCollisionTester_AddRef(const JPH_VehicleCollisionTester *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTester *)(_this)).AddRef();
}

void JPH_VehicleCollisionTester_Release(const JPH_VehicleCollisionTester *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTester *)(_this)).Release();
}

int JPH_VehicleCollisionTester_sInternalGetRefCountOffset(void)
{
    return JPH::VehicleCollisionTester::sInternalGetRefCountOffset();
}

const JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_OffsetPtr(const JPH_VehicleCollisionTester *ptr, ptrdiff_t i)
{
    return (const JPH_VehicleCollisionTester *)(((const JPH::VehicleCollisionTester *)ptr) + i);
}

JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_OffsetMutablePtr(JPH_VehicleCollisionTester *ptr, ptrdiff_t i)
{
    return (JPH_VehicleCollisionTester *)(((JPH::VehicleCollisionTester *)ptr) + i);
}

const JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTester *object)
{
    return (const JPH_RefTarget_JPH_VehicleCollisionTester *)(static_cast<const JPH::RefTarget<JPH::VehicleCollisionTester> *>(
        ((const JPH::VehicleCollisionTester *)object)
    ));
}

JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_MutableUpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_VehicleCollisionTester *object)
{
    return (JPH_RefTarget_JPH_VehicleCollisionTester *)(static_cast<JPH::RefTarget<JPH::VehicleCollisionTester> *>(
        ((JPH::VehicleCollisionTester *)object)
    ));
}

const JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_RefTarget_JPH_VehicleCollisionTester *object)
{
    return (const JPH_VehicleCollisionTester *)(static_cast<const JPH::VehicleCollisionTester *>(
        ((const JPH::RefTarget<JPH::VehicleCollisionTester> *)object)
    ));
}

JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_RefTarget_JPH_VehicleCollisionTester *object)
{
    return (JPH_VehicleCollisionTester *)(static_cast<JPH::VehicleCollisionTester *>(
        ((JPH::RefTarget<JPH::VehicleCollisionTester> *)object)
    ));
}

const JPH_NonCopyable *JPH_VehicleCollisionTester_UpcastTo_JPH_NonCopyable(const JPH_VehicleCollisionTester *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::VehicleCollisionTester *)object)
    ));
}

JPH_NonCopyable *JPH_VehicleCollisionTester_MutableUpcastTo_JPH_NonCopyable(JPH_VehicleCollisionTester *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::VehicleCollisionTester *)object)
    ));
}

const JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_VehicleCollisionTester *)(static_cast<const JPH::VehicleCollisionTester *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_VehicleCollisionTester *JPH_VehicleCollisionTester_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_VehicleCollisionTester *)(static_cast<JPH::VehicleCollisionTester *>(
        ((JPH::NonCopyable *)object)
    ));
}

JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_Construct(unsigned short inObjectLayer, const JPH_Vec3 *inUp, const float *inMaxSlopeAngle)
{
    using namespace JPH;
    return (JPH_VehicleCollisionTesterRay *)new JPH::VehicleCollisionTesterRay(JPH::VehicleCollisionTesterRay(
        inObjectLayer,
        (inUp ? JPH::Vec3(*(JPH::Vec3 *)inUp) : static_cast<JPH::Vec3>(Vec3::sAxisY())),
        (inMaxSlopeAngle ? *inMaxSlopeAngle : static_cast<float>(DegreesToRadians(80.F)))
    ));
}

const JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_OffsetPtr(const JPH_VehicleCollisionTesterRay *ptr, ptrdiff_t i)
{
    return (const JPH_VehicleCollisionTesterRay *)(((const JPH::VehicleCollisionTesterRay *)ptr) + i);
}

JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_OffsetMutablePtr(JPH_VehicleCollisionTesterRay *ptr, ptrdiff_t i)
{
    return (JPH_VehicleCollisionTesterRay *)(((JPH::VehicleCollisionTesterRay *)ptr) + i);
}

const JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTesterRay *object)
{
    return (const JPH_RefTarget_JPH_VehicleCollisionTester *)(static_cast<const JPH::RefTarget<JPH::VehicleCollisionTester> *>(
        ((const JPH::VehicleCollisionTesterRay *)object)
    ));
}

JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterRay_MutableUpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_VehicleCollisionTesterRay *object)
{
    return (JPH_RefTarget_JPH_VehicleCollisionTester *)(static_cast<JPH::RefTarget<JPH::VehicleCollisionTester> *>(
        ((JPH::VehicleCollisionTesterRay *)object)
    ));
}

const JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_RefTarget_JPH_VehicleCollisionTester *object)
{
    return (const JPH_VehicleCollisionTesterRay *)(static_cast<const JPH::VehicleCollisionTesterRay *>(
        ((const JPH::RefTarget<JPH::VehicleCollisionTester> *)object)
    ));
}

JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_RefTarget_JPH_VehicleCollisionTester *object)
{
    return (JPH_VehicleCollisionTesterRay *)(static_cast<JPH::VehicleCollisionTesterRay *>(
        ((JPH::RefTarget<JPH::VehicleCollisionTester> *)object)
    ));
}

const JPH_NonCopyable *JPH_VehicleCollisionTesterRay_UpcastTo_JPH_NonCopyable(const JPH_VehicleCollisionTesterRay *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::VehicleCollisionTesterRay *)object)
    ));
}

JPH_NonCopyable *JPH_VehicleCollisionTesterRay_MutableUpcastTo_JPH_NonCopyable(JPH_VehicleCollisionTesterRay *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::VehicleCollisionTesterRay *)object)
    ));
}

const JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_VehicleCollisionTesterRay *)(static_cast<const JPH::VehicleCollisionTesterRay *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_VehicleCollisionTesterRay *)(static_cast<JPH::VehicleCollisionTesterRay *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterRay_UpcastTo_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTesterRay *object)
{
    return (const JPH_VehicleCollisionTester *)(static_cast<const JPH::VehicleCollisionTester *>(
        ((const JPH::VehicleCollisionTesterRay *)object)
    ));
}

JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterRay_MutableUpcastTo_JPH_VehicleCollisionTester(JPH_VehicleCollisionTesterRay *object)
{
    return (JPH_VehicleCollisionTester *)(static_cast<JPH::VehicleCollisionTester *>(
        ((JPH::VehicleCollisionTesterRay *)object)
    ));
}

const JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTester *object)
{
    return (const JPH_VehicleCollisionTesterRay *)(static_cast<const JPH::VehicleCollisionTesterRay *>(
        ((const JPH::VehicleCollisionTester *)object)
    ));
}

JPH_VehicleCollisionTesterRay *JPH_VehicleCollisionTesterRay_MutableStaticDowncastFrom_JPH_VehicleCollisionTester(JPH_VehicleCollisionTester *object)
{
    return (JPH_VehicleCollisionTesterRay *)(static_cast<JPH::VehicleCollisionTesterRay *>(
        ((JPH::VehicleCollisionTester *)object)
    ));
}

void JPH_VehicleCollisionTesterRay_Destroy(const JPH_VehicleCollisionTesterRay *_this)
{
    delete ((const JPH::VehicleCollisionTesterRay *)_this);
}

void JPH_VehicleCollisionTesterRay_DestroyArray(const JPH_VehicleCollisionTesterRay *_this)
{
    delete[] ((const JPH::VehicleCollisionTesterRay *)_this);
}

void *Jolt_new_JPH_VehicleCollisionTesterRay_size_t(size_t inCount)
{
    return JPH::VehicleCollisionTesterRay::operator new(
        inCount
    );
}

void Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr(void *inPointer)
{
    JPH::VehicleCollisionTesterRay::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleCollisionTesterRay::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_VehicleCollisionTesterRay_size_t(size_t inCount)
{
    return JPH::VehicleCollisionTesterRay::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr(void *inPointer)
{
    JPH::VehicleCollisionTesterRay::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleCollisionTesterRay::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_VehicleCollisionTesterRay_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleCollisionTesterRay::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleCollisionTesterRay::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_VehicleCollisionTesterRay_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleCollisionTesterRay::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleCollisionTesterRay::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_VehicleCollisionTesterRay_Collide(const JPH_VehicleCollisionTesterRay *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **outBody, JPH_SubShapeID *outSubShapeID, JPH_Vec3 *outContactPosition, JPH_Vec3 *outContactNormal, float *outSuspensionLength)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterRay *)(_this)).Collide(
        ((inPhysicsSystem ? void() : MRBINDC_THROW("Parameter `inPhysicsSystem` can not be null.", void)), *(JPH::PhysicsSystem *)(inPhysicsSystem)),
        ((inVehicleConstraint ? void() : MRBINDC_THROW("Parameter `inVehicleConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inVehicleConstraint)),
        inWheelIndex,
        ((inOrigin ? void() : MRBINDC_THROW("Parameter `inOrigin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOrigin)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection)),
        ((inVehicleBodyID ? void() : MRBINDC_THROW("Parameter `inVehicleBodyID` can not be null.", void)), *(const JPH::BodyID *)(inVehicleBodyID)),
        ((outBody ? void() : MRBINDC_THROW("Parameter `outBody` can not be null.", void)), *(JPH::Body **)(outBody)),
        ((outSubShapeID ? void() : MRBINDC_THROW("Parameter `outSubShapeID` can not be null.", void)), *(JPH::SubShapeID *)(outSubShapeID)),
        ((outContactPosition ? void() : MRBINDC_THROW("Parameter `outContactPosition` can not be null.", void)), *(JPH::Vec3 *)(outContactPosition)),
        ((outContactNormal ? void() : MRBINDC_THROW("Parameter `outContactNormal` can not be null.", void)), *(JPH::Vec3 *)(outContactNormal)),
        ((outSuspensionLength ? void() : MRBINDC_THROW("Parameter `outSuspensionLength` can not be null.", void)), *outSuspensionLength)
    );
}

void JPH_VehicleCollisionTesterRay_PredictContactProperties(const JPH_VehicleCollisionTesterRay *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **ioBody, JPH_SubShapeID *ioSubShapeID, JPH_Vec3 *ioContactPosition, JPH_Vec3 *ioContactNormal, float *ioSuspensionLength)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterRay *)(_this)).PredictContactProperties(
        ((inPhysicsSystem ? void() : MRBINDC_THROW("Parameter `inPhysicsSystem` can not be null.", void)), *(JPH::PhysicsSystem *)(inPhysicsSystem)),
        ((inVehicleConstraint ? void() : MRBINDC_THROW("Parameter `inVehicleConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inVehicleConstraint)),
        inWheelIndex,
        ((inOrigin ? void() : MRBINDC_THROW("Parameter `inOrigin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOrigin)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection)),
        ((inVehicleBodyID ? void() : MRBINDC_THROW("Parameter `inVehicleBodyID` can not be null.", void)), *(const JPH::BodyID *)(inVehicleBodyID)),
        ((ioBody ? void() : MRBINDC_THROW("Parameter `ioBody` can not be null.", void)), *(JPH::Body **)(ioBody)),
        ((ioSubShapeID ? void() : MRBINDC_THROW("Parameter `ioSubShapeID` can not be null.", void)), *(JPH::SubShapeID *)(ioSubShapeID)),
        ((ioContactPosition ? void() : MRBINDC_THROW("Parameter `ioContactPosition` can not be null.", void)), *(JPH::Vec3 *)(ioContactPosition)),
        ((ioContactNormal ? void() : MRBINDC_THROW("Parameter `ioContactNormal` can not be null.", void)), *(JPH::Vec3 *)(ioContactNormal)),
        ((ioSuspensionLength ? void() : MRBINDC_THROW("Parameter `ioSuspensionLength` can not be null.", void)), *ioSuspensionLength)
    );
}

unsigned short JPH_VehicleCollisionTesterRay_GetObjectLayer(const JPH_VehicleCollisionTesterRay *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterRay *)(_this)).GetObjectLayer();
}

void JPH_VehicleCollisionTesterRay_SetObjectLayer(JPH_VehicleCollisionTesterRay *_this, unsigned short inObjectLayer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTesterRay *)(_this)).SetObjectLayer(
        inObjectLayer
    );
}

void JPH_VehicleCollisionTesterRay_SetBroadPhaseLayerFilter(JPH_VehicleCollisionTesterRay *_this, const JPH_BroadPhaseLayerFilter *inFilter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTesterRay *)(_this)).SetBroadPhaseLayerFilter(
        ((const JPH::BroadPhaseLayerFilter *)inFilter)
    );
}

const JPH_BroadPhaseLayerFilter *JPH_VehicleCollisionTesterRay_GetBroadPhaseLayerFilter(const JPH_VehicleCollisionTesterRay *_this)
{
    return (const JPH_BroadPhaseLayerFilter *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterRay *)(_this)).GetBroadPhaseLayerFilter());
}

void JPH_VehicleCollisionTesterRay_SetObjectLayerFilter(JPH_VehicleCollisionTesterRay *_this, const JPH_ObjectLayerFilter *inFilter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTesterRay *)(_this)).SetObjectLayerFilter(
        ((const JPH::ObjectLayerFilter *)inFilter)
    );
}

const JPH_ObjectLayerFilter *JPH_VehicleCollisionTesterRay_GetObjectLayerFilter(const JPH_VehicleCollisionTesterRay *_this)
{
    return (const JPH_ObjectLayerFilter *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterRay *)(_this)).GetObjectLayerFilter());
}

void JPH_VehicleCollisionTesterRay_SetBodyFilter(JPH_VehicleCollisionTesterRay *_this, const JPH_BodyFilter *inFilter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTesterRay *)(_this)).SetBodyFilter(
        ((const JPH::BodyFilter *)inFilter)
    );
}

const JPH_BodyFilter *JPH_VehicleCollisionTesterRay_GetBodyFilter(const JPH_VehicleCollisionTesterRay *_this)
{
    return (const JPH_BodyFilter *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterRay *)(_this)).GetBodyFilter());
}

void JPH_VehicleCollisionTesterRay_SetEmbedded(const JPH_VehicleCollisionTesterRay *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterRay *)(_this)).SetEmbedded();
}

unsigned int JPH_VehicleCollisionTesterRay_GetRefCount(const JPH_VehicleCollisionTesterRay *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterRay *)(_this)).GetRefCount();
}

void JPH_VehicleCollisionTesterRay_AddRef(const JPH_VehicleCollisionTesterRay *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterRay *)(_this)).AddRef();
}

void JPH_VehicleCollisionTesterRay_Release(const JPH_VehicleCollisionTesterRay *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterRay *)(_this)).Release();
}

int JPH_VehicleCollisionTesterRay_sInternalGetRefCountOffset(void)
{
    return JPH::VehicleCollisionTesterRay::sInternalGetRefCountOffset();
}

JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_Construct(unsigned short inObjectLayer, float inRadius, const JPH_Vec3 *inUp, const float *inMaxSlopeAngle)
{
    using namespace JPH;
    return (JPH_VehicleCollisionTesterCastSphere *)new JPH::VehicleCollisionTesterCastSphere(JPH::VehicleCollisionTesterCastSphere(
        inObjectLayer,
        inRadius,
        (inUp ? JPH::Vec3(*(JPH::Vec3 *)inUp) : static_cast<JPH::Vec3>(Vec3::sAxisY())),
        (inMaxSlopeAngle ? *inMaxSlopeAngle : static_cast<float>(DegreesToRadians(80.F)))
    ));
}

const JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_OffsetPtr(const JPH_VehicleCollisionTesterCastSphere *ptr, ptrdiff_t i)
{
    return (const JPH_VehicleCollisionTesterCastSphere *)(((const JPH::VehicleCollisionTesterCastSphere *)ptr) + i);
}

JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_OffsetMutablePtr(JPH_VehicleCollisionTesterCastSphere *ptr, ptrdiff_t i)
{
    return (JPH_VehicleCollisionTesterCastSphere *)(((JPH::VehicleCollisionTesterCastSphere *)ptr) + i);
}

const JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTesterCastSphere *object)
{
    return (const JPH_RefTarget_JPH_VehicleCollisionTester *)(static_cast<const JPH::RefTarget<JPH::VehicleCollisionTester> *>(
        ((const JPH::VehicleCollisionTesterCastSphere *)object)
    ));
}

JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastSphere_MutableUpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_VehicleCollisionTesterCastSphere *object)
{
    return (JPH_RefTarget_JPH_VehicleCollisionTester *)(static_cast<JPH::RefTarget<JPH::VehicleCollisionTester> *>(
        ((JPH::VehicleCollisionTesterCastSphere *)object)
    ));
}

const JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_RefTarget_JPH_VehicleCollisionTester *object)
{
    return (const JPH_VehicleCollisionTesterCastSphere *)(static_cast<const JPH::VehicleCollisionTesterCastSphere *>(
        ((const JPH::RefTarget<JPH::VehicleCollisionTester> *)object)
    ));
}

JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_RefTarget_JPH_VehicleCollisionTester *object)
{
    return (JPH_VehicleCollisionTesterCastSphere *)(static_cast<JPH::VehicleCollisionTesterCastSphere *>(
        ((JPH::RefTarget<JPH::VehicleCollisionTester> *)object)
    ));
}

const JPH_NonCopyable *JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_NonCopyable(const JPH_VehicleCollisionTesterCastSphere *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::VehicleCollisionTesterCastSphere *)object)
    ));
}

JPH_NonCopyable *JPH_VehicleCollisionTesterCastSphere_MutableUpcastTo_JPH_NonCopyable(JPH_VehicleCollisionTesterCastSphere *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::VehicleCollisionTesterCastSphere *)object)
    ));
}

const JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_VehicleCollisionTesterCastSphere *)(static_cast<const JPH::VehicleCollisionTesterCastSphere *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_VehicleCollisionTesterCastSphere *)(static_cast<JPH::VehicleCollisionTesterCastSphere *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTesterCastSphere *object)
{
    return (const JPH_VehicleCollisionTester *)(static_cast<const JPH::VehicleCollisionTester *>(
        ((const JPH::VehicleCollisionTesterCastSphere *)object)
    ));
}

JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastSphere_MutableUpcastTo_JPH_VehicleCollisionTester(JPH_VehicleCollisionTesterCastSphere *object)
{
    return (JPH_VehicleCollisionTester *)(static_cast<JPH::VehicleCollisionTester *>(
        ((JPH::VehicleCollisionTesterCastSphere *)object)
    ));
}

const JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTester *object)
{
    return (const JPH_VehicleCollisionTesterCastSphere *)(static_cast<const JPH::VehicleCollisionTesterCastSphere *>(
        ((const JPH::VehicleCollisionTester *)object)
    ));
}

JPH_VehicleCollisionTesterCastSphere *JPH_VehicleCollisionTesterCastSphere_MutableStaticDowncastFrom_JPH_VehicleCollisionTester(JPH_VehicleCollisionTester *object)
{
    return (JPH_VehicleCollisionTesterCastSphere *)(static_cast<JPH::VehicleCollisionTesterCastSphere *>(
        ((JPH::VehicleCollisionTester *)object)
    ));
}

void JPH_VehicleCollisionTesterCastSphere_Destroy(const JPH_VehicleCollisionTesterCastSphere *_this)
{
    delete ((const JPH::VehicleCollisionTesterCastSphere *)_this);
}

void JPH_VehicleCollisionTesterCastSphere_DestroyArray(const JPH_VehicleCollisionTesterCastSphere *_this)
{
    delete[] ((const JPH::VehicleCollisionTesterCastSphere *)_this);
}

void *Jolt_new_JPH_VehicleCollisionTesterCastSphere_size_t(size_t inCount)
{
    return JPH::VehicleCollisionTesterCastSphere::operator new(
        inCount
    );
}

void Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr(void *inPointer)
{
    JPH::VehicleCollisionTesterCastSphere::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleCollisionTesterCastSphere::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_VehicleCollisionTesterCastSphere_size_t(size_t inCount)
{
    return JPH::VehicleCollisionTesterCastSphere::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr(void *inPointer)
{
    JPH::VehicleCollisionTesterCastSphere::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleCollisionTesterCastSphere::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_VehicleCollisionTesterCastSphere_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleCollisionTesterCastSphere::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleCollisionTesterCastSphere::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_VehicleCollisionTesterCastSphere_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleCollisionTesterCastSphere::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleCollisionTesterCastSphere::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_VehicleCollisionTesterCastSphere_Collide(const JPH_VehicleCollisionTesterCastSphere *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **outBody, JPH_SubShapeID *outSubShapeID, JPH_Vec3 *outContactPosition, JPH_Vec3 *outContactNormal, float *outSuspensionLength)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastSphere *)(_this)).Collide(
        ((inPhysicsSystem ? void() : MRBINDC_THROW("Parameter `inPhysicsSystem` can not be null.", void)), *(JPH::PhysicsSystem *)(inPhysicsSystem)),
        ((inVehicleConstraint ? void() : MRBINDC_THROW("Parameter `inVehicleConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inVehicleConstraint)),
        inWheelIndex,
        ((inOrigin ? void() : MRBINDC_THROW("Parameter `inOrigin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOrigin)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection)),
        ((inVehicleBodyID ? void() : MRBINDC_THROW("Parameter `inVehicleBodyID` can not be null.", void)), *(const JPH::BodyID *)(inVehicleBodyID)),
        ((outBody ? void() : MRBINDC_THROW("Parameter `outBody` can not be null.", void)), *(JPH::Body **)(outBody)),
        ((outSubShapeID ? void() : MRBINDC_THROW("Parameter `outSubShapeID` can not be null.", void)), *(JPH::SubShapeID *)(outSubShapeID)),
        ((outContactPosition ? void() : MRBINDC_THROW("Parameter `outContactPosition` can not be null.", void)), *(JPH::Vec3 *)(outContactPosition)),
        ((outContactNormal ? void() : MRBINDC_THROW("Parameter `outContactNormal` can not be null.", void)), *(JPH::Vec3 *)(outContactNormal)),
        ((outSuspensionLength ? void() : MRBINDC_THROW("Parameter `outSuspensionLength` can not be null.", void)), *outSuspensionLength)
    );
}

void JPH_VehicleCollisionTesterCastSphere_PredictContactProperties(const JPH_VehicleCollisionTesterCastSphere *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **ioBody, JPH_SubShapeID *ioSubShapeID, JPH_Vec3 *ioContactPosition, JPH_Vec3 *ioContactNormal, float *ioSuspensionLength)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastSphere *)(_this)).PredictContactProperties(
        ((inPhysicsSystem ? void() : MRBINDC_THROW("Parameter `inPhysicsSystem` can not be null.", void)), *(JPH::PhysicsSystem *)(inPhysicsSystem)),
        ((inVehicleConstraint ? void() : MRBINDC_THROW("Parameter `inVehicleConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inVehicleConstraint)),
        inWheelIndex,
        ((inOrigin ? void() : MRBINDC_THROW("Parameter `inOrigin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOrigin)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection)),
        ((inVehicleBodyID ? void() : MRBINDC_THROW("Parameter `inVehicleBodyID` can not be null.", void)), *(const JPH::BodyID *)(inVehicleBodyID)),
        ((ioBody ? void() : MRBINDC_THROW("Parameter `ioBody` can not be null.", void)), *(JPH::Body **)(ioBody)),
        ((ioSubShapeID ? void() : MRBINDC_THROW("Parameter `ioSubShapeID` can not be null.", void)), *(JPH::SubShapeID *)(ioSubShapeID)),
        ((ioContactPosition ? void() : MRBINDC_THROW("Parameter `ioContactPosition` can not be null.", void)), *(JPH::Vec3 *)(ioContactPosition)),
        ((ioContactNormal ? void() : MRBINDC_THROW("Parameter `ioContactNormal` can not be null.", void)), *(JPH::Vec3 *)(ioContactNormal)),
        ((ioSuspensionLength ? void() : MRBINDC_THROW("Parameter `ioSuspensionLength` can not be null.", void)), *ioSuspensionLength)
    );
}

unsigned short JPH_VehicleCollisionTesterCastSphere_GetObjectLayer(const JPH_VehicleCollisionTesterCastSphere *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastSphere *)(_this)).GetObjectLayer();
}

void JPH_VehicleCollisionTesterCastSphere_SetObjectLayer(JPH_VehicleCollisionTesterCastSphere *_this, unsigned short inObjectLayer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTesterCastSphere *)(_this)).SetObjectLayer(
        inObjectLayer
    );
}

void JPH_VehicleCollisionTesterCastSphere_SetBroadPhaseLayerFilter(JPH_VehicleCollisionTesterCastSphere *_this, const JPH_BroadPhaseLayerFilter *inFilter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTesterCastSphere *)(_this)).SetBroadPhaseLayerFilter(
        ((const JPH::BroadPhaseLayerFilter *)inFilter)
    );
}

const JPH_BroadPhaseLayerFilter *JPH_VehicleCollisionTesterCastSphere_GetBroadPhaseLayerFilter(const JPH_VehicleCollisionTesterCastSphere *_this)
{
    return (const JPH_BroadPhaseLayerFilter *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastSphere *)(_this)).GetBroadPhaseLayerFilter());
}

void JPH_VehicleCollisionTesterCastSphere_SetObjectLayerFilter(JPH_VehicleCollisionTesterCastSphere *_this, const JPH_ObjectLayerFilter *inFilter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTesterCastSphere *)(_this)).SetObjectLayerFilter(
        ((const JPH::ObjectLayerFilter *)inFilter)
    );
}

const JPH_ObjectLayerFilter *JPH_VehicleCollisionTesterCastSphere_GetObjectLayerFilter(const JPH_VehicleCollisionTesterCastSphere *_this)
{
    return (const JPH_ObjectLayerFilter *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastSphere *)(_this)).GetObjectLayerFilter());
}

void JPH_VehicleCollisionTesterCastSphere_SetBodyFilter(JPH_VehicleCollisionTesterCastSphere *_this, const JPH_BodyFilter *inFilter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTesterCastSphere *)(_this)).SetBodyFilter(
        ((const JPH::BodyFilter *)inFilter)
    );
}

const JPH_BodyFilter *JPH_VehicleCollisionTesterCastSphere_GetBodyFilter(const JPH_VehicleCollisionTesterCastSphere *_this)
{
    return (const JPH_BodyFilter *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastSphere *)(_this)).GetBodyFilter());
}

void JPH_VehicleCollisionTesterCastSphere_SetEmbedded(const JPH_VehicleCollisionTesterCastSphere *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastSphere *)(_this)).SetEmbedded();
}

unsigned int JPH_VehicleCollisionTesterCastSphere_GetRefCount(const JPH_VehicleCollisionTesterCastSphere *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastSphere *)(_this)).GetRefCount();
}

void JPH_VehicleCollisionTesterCastSphere_AddRef(const JPH_VehicleCollisionTesterCastSphere *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastSphere *)(_this)).AddRef();
}

void JPH_VehicleCollisionTesterCastSphere_Release(const JPH_VehicleCollisionTesterCastSphere *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastSphere *)(_this)).Release();
}

int JPH_VehicleCollisionTesterCastSphere_sInternalGetRefCountOffset(void)
{
    return JPH::VehicleCollisionTesterCastSphere::sInternalGetRefCountOffset();
}

JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_Construct(unsigned short inObjectLayer, const float *inConvexRadiusFraction)
{
    using namespace JPH;
    return (JPH_VehicleCollisionTesterCastCylinder *)new JPH::VehicleCollisionTesterCastCylinder(JPH::VehicleCollisionTesterCastCylinder(
        inObjectLayer,
        (inConvexRadiusFraction ? *inConvexRadiusFraction : static_cast<float>(0.100000001F))
    ));
}

const JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_OffsetPtr(const JPH_VehicleCollisionTesterCastCylinder *ptr, ptrdiff_t i)
{
    return (const JPH_VehicleCollisionTesterCastCylinder *)(((const JPH::VehicleCollisionTesterCastCylinder *)ptr) + i);
}

JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_OffsetMutablePtr(JPH_VehicleCollisionTesterCastCylinder *ptr, ptrdiff_t i)
{
    return (JPH_VehicleCollisionTesterCastCylinder *)(((JPH::VehicleCollisionTesterCastCylinder *)ptr) + i);
}

const JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTesterCastCylinder *object)
{
    return (const JPH_RefTarget_JPH_VehicleCollisionTester *)(static_cast<const JPH::RefTarget<JPH::VehicleCollisionTester> *>(
        ((const JPH::VehicleCollisionTesterCastCylinder *)object)
    ));
}

JPH_RefTarget_JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastCylinder_MutableUpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_VehicleCollisionTesterCastCylinder *object)
{
    return (JPH_RefTarget_JPH_VehicleCollisionTester *)(static_cast<JPH::RefTarget<JPH::VehicleCollisionTester> *>(
        ((JPH::VehicleCollisionTesterCastCylinder *)object)
    ));
}

const JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(const JPH_RefTarget_JPH_VehicleCollisionTester *object)
{
    return (const JPH_VehicleCollisionTesterCastCylinder *)(static_cast<const JPH::VehicleCollisionTesterCastCylinder *>(
        ((const JPH::RefTarget<JPH::VehicleCollisionTester> *)object)
    ));
}

JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH_RefTarget_JPH_VehicleCollisionTester *object)
{
    return (JPH_VehicleCollisionTesterCastCylinder *)(static_cast<JPH::VehicleCollisionTesterCastCylinder *>(
        ((JPH::RefTarget<JPH::VehicleCollisionTester> *)object)
    ));
}

const JPH_NonCopyable *JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_NonCopyable(const JPH_VehicleCollisionTesterCastCylinder *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::VehicleCollisionTesterCastCylinder *)object)
    ));
}

JPH_NonCopyable *JPH_VehicleCollisionTesterCastCylinder_MutableUpcastTo_JPH_NonCopyable(JPH_VehicleCollisionTesterCastCylinder *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::VehicleCollisionTesterCastCylinder *)object)
    ));
}

const JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_VehicleCollisionTesterCastCylinder *)(static_cast<const JPH::VehicleCollisionTesterCastCylinder *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_VehicleCollisionTesterCastCylinder *)(static_cast<JPH::VehicleCollisionTesterCastCylinder *>(
        ((JPH::NonCopyable *)object)
    ));
}

const JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTesterCastCylinder *object)
{
    return (const JPH_VehicleCollisionTester *)(static_cast<const JPH::VehicleCollisionTester *>(
        ((const JPH::VehicleCollisionTesterCastCylinder *)object)
    ));
}

JPH_VehicleCollisionTester *JPH_VehicleCollisionTesterCastCylinder_MutableUpcastTo_JPH_VehicleCollisionTester(JPH_VehicleCollisionTesterCastCylinder *object)
{
    return (JPH_VehicleCollisionTester *)(static_cast<JPH::VehicleCollisionTester *>(
        ((JPH::VehicleCollisionTesterCastCylinder *)object)
    ));
}

const JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_VehicleCollisionTester(const JPH_VehicleCollisionTester *object)
{
    return (const JPH_VehicleCollisionTesterCastCylinder *)(static_cast<const JPH::VehicleCollisionTesterCastCylinder *>(
        ((const JPH::VehicleCollisionTester *)object)
    ));
}

JPH_VehicleCollisionTesterCastCylinder *JPH_VehicleCollisionTesterCastCylinder_MutableStaticDowncastFrom_JPH_VehicleCollisionTester(JPH_VehicleCollisionTester *object)
{
    return (JPH_VehicleCollisionTesterCastCylinder *)(static_cast<JPH::VehicleCollisionTesterCastCylinder *>(
        ((JPH::VehicleCollisionTester *)object)
    ));
}

void JPH_VehicleCollisionTesterCastCylinder_Destroy(const JPH_VehicleCollisionTesterCastCylinder *_this)
{
    delete ((const JPH::VehicleCollisionTesterCastCylinder *)_this);
}

void JPH_VehicleCollisionTesterCastCylinder_DestroyArray(const JPH_VehicleCollisionTesterCastCylinder *_this)
{
    delete[] ((const JPH::VehicleCollisionTesterCastCylinder *)_this);
}

void *Jolt_new_JPH_VehicleCollisionTesterCastCylinder_size_t(size_t inCount)
{
    return JPH::VehicleCollisionTesterCastCylinder::operator new(
        inCount
    );
}

void Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr(void *inPointer)
{
    JPH::VehicleCollisionTesterCastCylinder::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleCollisionTesterCastCylinder::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_VehicleCollisionTesterCastCylinder_size_t(size_t inCount)
{
    return JPH::VehicleCollisionTesterCastCylinder::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr(void *inPointer)
{
    JPH::VehicleCollisionTesterCastCylinder::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleCollisionTesterCastCylinder::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_VehicleCollisionTesterCastCylinder_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleCollisionTesterCastCylinder::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleCollisionTesterCastCylinder::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_VehicleCollisionTesterCastCylinder_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleCollisionTesterCastCylinder::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleCollisionTesterCastCylinder::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_VehicleCollisionTesterCastCylinder_Collide(const JPH_VehicleCollisionTesterCastCylinder *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **outBody, JPH_SubShapeID *outSubShapeID, JPH_Vec3 *outContactPosition, JPH_Vec3 *outContactNormal, float *outSuspensionLength)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastCylinder *)(_this)).Collide(
        ((inPhysicsSystem ? void() : MRBINDC_THROW("Parameter `inPhysicsSystem` can not be null.", void)), *(JPH::PhysicsSystem *)(inPhysicsSystem)),
        ((inVehicleConstraint ? void() : MRBINDC_THROW("Parameter `inVehicleConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inVehicleConstraint)),
        inWheelIndex,
        ((inOrigin ? void() : MRBINDC_THROW("Parameter `inOrigin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOrigin)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection)),
        ((inVehicleBodyID ? void() : MRBINDC_THROW("Parameter `inVehicleBodyID` can not be null.", void)), *(const JPH::BodyID *)(inVehicleBodyID)),
        ((outBody ? void() : MRBINDC_THROW("Parameter `outBody` can not be null.", void)), *(JPH::Body **)(outBody)),
        ((outSubShapeID ? void() : MRBINDC_THROW("Parameter `outSubShapeID` can not be null.", void)), *(JPH::SubShapeID *)(outSubShapeID)),
        ((outContactPosition ? void() : MRBINDC_THROW("Parameter `outContactPosition` can not be null.", void)), *(JPH::Vec3 *)(outContactPosition)),
        ((outContactNormal ? void() : MRBINDC_THROW("Parameter `outContactNormal` can not be null.", void)), *(JPH::Vec3 *)(outContactNormal)),
        ((outSuspensionLength ? void() : MRBINDC_THROW("Parameter `outSuspensionLength` can not be null.", void)), *outSuspensionLength)
    );
}

void JPH_VehicleCollisionTesterCastCylinder_PredictContactProperties(const JPH_VehicleCollisionTesterCastCylinder *_this, JPH_PhysicsSystem *inPhysicsSystem, const JPH_VehicleConstraint *inVehicleConstraint, unsigned int inWheelIndex, const JPH_Vec3 *inOrigin, const JPH_Vec3 *inDirection, const JPH_BodyID *inVehicleBodyID, JPH_Body **ioBody, JPH_SubShapeID *ioSubShapeID, JPH_Vec3 *ioContactPosition, JPH_Vec3 *ioContactNormal, float *ioSuspensionLength)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastCylinder *)(_this)).PredictContactProperties(
        ((inPhysicsSystem ? void() : MRBINDC_THROW("Parameter `inPhysicsSystem` can not be null.", void)), *(JPH::PhysicsSystem *)(inPhysicsSystem)),
        ((inVehicleConstraint ? void() : MRBINDC_THROW("Parameter `inVehicleConstraint` can not be null.", void)), *(const JPH::VehicleConstraint *)(inVehicleConstraint)),
        inWheelIndex,
        ((inOrigin ? void() : MRBINDC_THROW("Parameter `inOrigin` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inOrigin)),
        ((inDirection ? void() : MRBINDC_THROW("Parameter `inDirection` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDirection)),
        ((inVehicleBodyID ? void() : MRBINDC_THROW("Parameter `inVehicleBodyID` can not be null.", void)), *(const JPH::BodyID *)(inVehicleBodyID)),
        ((ioBody ? void() : MRBINDC_THROW("Parameter `ioBody` can not be null.", void)), *(JPH::Body **)(ioBody)),
        ((ioSubShapeID ? void() : MRBINDC_THROW("Parameter `ioSubShapeID` can not be null.", void)), *(JPH::SubShapeID *)(ioSubShapeID)),
        ((ioContactPosition ? void() : MRBINDC_THROW("Parameter `ioContactPosition` can not be null.", void)), *(JPH::Vec3 *)(ioContactPosition)),
        ((ioContactNormal ? void() : MRBINDC_THROW("Parameter `ioContactNormal` can not be null.", void)), *(JPH::Vec3 *)(ioContactNormal)),
        ((ioSuspensionLength ? void() : MRBINDC_THROW("Parameter `ioSuspensionLength` can not be null.", void)), *ioSuspensionLength)
    );
}

unsigned short JPH_VehicleCollisionTesterCastCylinder_GetObjectLayer(const JPH_VehicleCollisionTesterCastCylinder *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastCylinder *)(_this)).GetObjectLayer();
}

void JPH_VehicleCollisionTesterCastCylinder_SetObjectLayer(JPH_VehicleCollisionTesterCastCylinder *_this, unsigned short inObjectLayer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTesterCastCylinder *)(_this)).SetObjectLayer(
        inObjectLayer
    );
}

void JPH_VehicleCollisionTesterCastCylinder_SetBroadPhaseLayerFilter(JPH_VehicleCollisionTesterCastCylinder *_this, const JPH_BroadPhaseLayerFilter *inFilter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTesterCastCylinder *)(_this)).SetBroadPhaseLayerFilter(
        ((const JPH::BroadPhaseLayerFilter *)inFilter)
    );
}

const JPH_BroadPhaseLayerFilter *JPH_VehicleCollisionTesterCastCylinder_GetBroadPhaseLayerFilter(const JPH_VehicleCollisionTesterCastCylinder *_this)
{
    return (const JPH_BroadPhaseLayerFilter *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastCylinder *)(_this)).GetBroadPhaseLayerFilter());
}

void JPH_VehicleCollisionTesterCastCylinder_SetObjectLayerFilter(JPH_VehicleCollisionTesterCastCylinder *_this, const JPH_ObjectLayerFilter *inFilter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTesterCastCylinder *)(_this)).SetObjectLayerFilter(
        ((const JPH::ObjectLayerFilter *)inFilter)
    );
}

const JPH_ObjectLayerFilter *JPH_VehicleCollisionTesterCastCylinder_GetObjectLayerFilter(const JPH_VehicleCollisionTesterCastCylinder *_this)
{
    return (const JPH_ObjectLayerFilter *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastCylinder *)(_this)).GetObjectLayerFilter());
}

void JPH_VehicleCollisionTesterCastCylinder_SetBodyFilter(JPH_VehicleCollisionTesterCastCylinder *_this, const JPH_BodyFilter *inFilter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleCollisionTesterCastCylinder *)(_this)).SetBodyFilter(
        ((const JPH::BodyFilter *)inFilter)
    );
}

const JPH_BodyFilter *JPH_VehicleCollisionTesterCastCylinder_GetBodyFilter(const JPH_VehicleCollisionTesterCastCylinder *_this)
{
    return (const JPH_BodyFilter *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastCylinder *)(_this)).GetBodyFilter());
}

void JPH_VehicleCollisionTesterCastCylinder_SetEmbedded(const JPH_VehicleCollisionTesterCastCylinder *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastCylinder *)(_this)).SetEmbedded();
}

unsigned int JPH_VehicleCollisionTesterCastCylinder_GetRefCount(const JPH_VehicleCollisionTesterCastCylinder *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastCylinder *)(_this)).GetRefCount();
}

void JPH_VehicleCollisionTesterCastCylinder_AddRef(const JPH_VehicleCollisionTesterCastCylinder *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastCylinder *)(_this)).AddRef();
}

void JPH_VehicleCollisionTesterCastCylinder_Release(const JPH_VehicleCollisionTesterCastCylinder *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleCollisionTesterCastCylinder *)(_this)).Release();
}

int JPH_VehicleCollisionTesterCastCylinder_sInternalGetRefCountOffset(void)
{
    return JPH::VehicleCollisionTesterCastCylinder::sInternalGetRefCountOffset();
}

