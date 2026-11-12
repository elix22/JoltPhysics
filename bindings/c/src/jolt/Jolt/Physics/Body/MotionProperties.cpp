// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Body/MotionProperties.h"

#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Math/UVec4.h>
#include <Jolt/Math/Vec3.h>
#include <Jolt/Physics/Body/MotionProperties.h>
#include <Jolt/Physics/Body/MotionQuality.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <memory>
#include <new>
#include <stdexcept>


const unsigned int *JPH_MotionProperties_Get_cInactiveIndex(void)
{
    return std::addressof(JPH::MotionProperties::cInactiveIndex);
}

JPH_MotionProperties *JPH_MotionProperties_DefaultConstruct(void)
{
    using _mrbind_T = JPH::MotionProperties;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (JPH_MotionProperties*)(::new(_mrbind_ptr) _mrbind_T());
}

JPH_MotionProperties *JPH_MotionProperties_DefaultConstructArray(size_t num_elems)
{
    return (JPH_MotionProperties *)(new JPH::MotionProperties[num_elems]);
}

const JPH_MotionProperties *JPH_MotionProperties_OffsetPtr(const JPH_MotionProperties *ptr, ptrdiff_t i)
{
    return (const JPH_MotionProperties *)(((const JPH::MotionProperties *)ptr) + i);
}

JPH_MotionProperties *JPH_MotionProperties_OffsetMutablePtr(JPH_MotionProperties *ptr, ptrdiff_t i)
{
    return (JPH_MotionProperties *)(((JPH::MotionProperties *)ptr) + i);
}

JPH_MotionProperties *JPH_MotionProperties_ConstructFromAnother(const JPH_MotionProperties *_other)
{
    return (JPH_MotionProperties *)new JPH::MotionProperties(JPH::MotionProperties(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::MotionProperties(*(JPH::MotionProperties *)_other))
    ));
}

void JPH_MotionProperties_Destroy(const JPH_MotionProperties *_this)
{
    delete ((const JPH::MotionProperties *)_this);
}

void JPH_MotionProperties_DestroyArray(const JPH_MotionProperties *_this)
{
    delete[] ((const JPH::MotionProperties *)_this);
}

JPH_MotionProperties *JPH_MotionProperties_AssignFromAnother(JPH_MotionProperties *_this, const JPH_MotionProperties *_other)
{
    return (JPH_MotionProperties *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::MotionProperties(*(JPH::MotionProperties *)_other))
    ));
}

void *Jolt_new_JPH_MotionProperties_size_t(size_t inCount)
{
    return JPH::MotionProperties::operator new(
        inCount
    );
}

void Jolt_delete_JPH_MotionProperties_void_ptr(void *inPointer)
{
    JPH::MotionProperties::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_MotionProperties_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::MotionProperties::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_MotionProperties_size_t(size_t inCount)
{
    return JPH::MotionProperties::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_MotionProperties_void_ptr(void *inPointer)
{
    JPH::MotionProperties::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_MotionProperties_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::MotionProperties::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_MotionProperties_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::MotionProperties::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_MotionProperties_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MotionProperties::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_MotionProperties_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::MotionProperties::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_MotionProperties_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::MotionProperties::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_EMotionQuality JPH_MotionProperties_GetMotionQuality(const JPH_MotionProperties *_this)
{
    return (JPH_EMotionQuality)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetMotionQuality());
}

bool JPH_MotionProperties_GetAllowSleeping(const JPH_MotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetAllowSleeping();
}

JPH_Vec3 *JPH_MotionProperties_GetLinearVelocity(const JPH_MotionProperties *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetLinearVelocity());
}

void JPH_MotionProperties_SetLinearVelocity(JPH_MotionProperties *_this, const JPH_Vec3 *inLinearVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SetLinearVelocity(
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity))
    );
}

void JPH_MotionProperties_SetLinearVelocityClamped(JPH_MotionProperties *_this, const JPH_Vec3 *inLinearVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SetLinearVelocityClamped(
        ((inLinearVelocity ? void() : MRBINDC_THROW("Parameter `inLinearVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocity))
    );
}

JPH_Vec3 *JPH_MotionProperties_GetAngularVelocity(const JPH_MotionProperties *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetAngularVelocity());
}

void JPH_MotionProperties_SetAngularVelocity(JPH_MotionProperties *_this, const JPH_Vec3 *inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SetAngularVelocity(
        ((inAngularVelocity ? void() : MRBINDC_THROW("Parameter `inAngularVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocity))
    );
}

void JPH_MotionProperties_SetAngularVelocityClamped(JPH_MotionProperties *_this, const JPH_Vec3 *inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SetAngularVelocityClamped(
        ((inAngularVelocity ? void() : MRBINDC_THROW("Parameter `inAngularVelocity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocity))
    );
}

void JPH_MotionProperties_MoveKinematic(JPH_MotionProperties *_this, const JPH_Vec3 *inDeltaPosition, const JPH_Quat *inDeltaRotation, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).MoveKinematic(
        ((inDeltaPosition ? void() : MRBINDC_THROW("Parameter `inDeltaPosition` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDeltaPosition)),
        ((inDeltaRotation ? void() : MRBINDC_THROW("Parameter `inDeltaRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inDeltaRotation)),
        inDeltaTime
    );
}

float JPH_MotionProperties_GetMaxLinearVelocity(const JPH_MotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetMaxLinearVelocity();
}

void JPH_MotionProperties_SetMaxLinearVelocity(JPH_MotionProperties *_this, float inLinearVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SetMaxLinearVelocity(
        inLinearVelocity
    );
}

float JPH_MotionProperties_GetMaxAngularVelocity(const JPH_MotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetMaxAngularVelocity();
}

void JPH_MotionProperties_SetMaxAngularVelocity(JPH_MotionProperties *_this, float inAngularVelocity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SetMaxAngularVelocity(
        inAngularVelocity
    );
}

void JPH_MotionProperties_ClampLinearVelocity(JPH_MotionProperties *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).ClampLinearVelocity();
}

void JPH_MotionProperties_ClampAngularVelocity(JPH_MotionProperties *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).ClampAngularVelocity();
}

float JPH_MotionProperties_GetLinearDamping(const JPH_MotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetLinearDamping();
}

void JPH_MotionProperties_SetLinearDamping(JPH_MotionProperties *_this, float inLinearDamping)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SetLinearDamping(
        inLinearDamping
    );
}

float JPH_MotionProperties_GetAngularDamping(const JPH_MotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetAngularDamping();
}

void JPH_MotionProperties_SetAngularDamping(JPH_MotionProperties *_this, float inAngularDamping)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SetAngularDamping(
        inAngularDamping
    );
}

float JPH_MotionProperties_GetGravityFactor(const JPH_MotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetGravityFactor();
}

void JPH_MotionProperties_SetGravityFactor(JPH_MotionProperties *_this, float inGravityFactor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SetGravityFactor(
        inGravityFactor
    );
}

float JPH_MotionProperties_GetInverseMass(const JPH_MotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetInverseMass();
}

float JPH_MotionProperties_GetInverseMassUnchecked(const JPH_MotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetInverseMassUnchecked();
}

void JPH_MotionProperties_SetInverseMass(JPH_MotionProperties *_this, float inInverseMass)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SetInverseMass(
        inInverseMass
    );
}

JPH_Vec3 *JPH_MotionProperties_GetInverseInertiaDiagonal(const JPH_MotionProperties *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetInverseInertiaDiagonal());
}

JPH_Quat *JPH_MotionProperties_GetInertiaRotation(const JPH_MotionProperties *_this)
{
    return (JPH_Quat *)new JPH::Quat(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetInertiaRotation());
}

void JPH_MotionProperties_SetInverseInertia(JPH_MotionProperties *_this, const JPH_Vec3 *inDiagonal, const JPH_Quat *inRot)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SetInverseInertia(
        ((inDiagonal ? void() : MRBINDC_THROW("Parameter `inDiagonal` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inDiagonal)),
        ((inRot ? void() : MRBINDC_THROW("Parameter `inRot` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inRot))
    );
}

void JPH_MotionProperties_ScaleToMass(JPH_MotionProperties *_this, float inMass)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).ScaleToMass(
        inMass
    );
}

JPH_Mat44 *JPH_MotionProperties_GetLocalSpaceInverseInertia(const JPH_MotionProperties *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetLocalSpaceInverseInertia());
}

JPH_Mat44 *JPH_MotionProperties_GetLocalSpaceInverseInertiaUnchecked(const JPH_MotionProperties *_this)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetLocalSpaceInverseInertiaUnchecked());
}

JPH_Mat44 *JPH_MotionProperties_GetInverseInertiaForRotation(const JPH_MotionProperties *_this, const JPH_Mat44 *inRotation)
{
    return (JPH_Mat44 *)new JPH::Mat44(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetInverseInertiaForRotation(
        ((inRotation ? void() : MRBINDC_THROW("Parameter `inRotation` can not be null.", void)), *(const JPH::Mat44 *)(inRotation))
    ));
}

JPH_Vec3 *JPH_MotionProperties_MultiplyWorldSpaceInverseInertiaByVector(const JPH_MotionProperties *_this, const JPH_Quat *inBodyRotation, const JPH_Vec3 *inV)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).MultiplyWorldSpaceInverseInertiaByVector(
        ((inBodyRotation ? void() : MRBINDC_THROW("Parameter `inBodyRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inBodyRotation)),
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

JPH_Vec3 *JPH_MotionProperties_GetPointVelocityCOM(const JPH_MotionProperties *_this, const JPH_Vec3 *inPointRelativeToCOM)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetPointVelocityCOM(
        ((inPointRelativeToCOM ? void() : MRBINDC_THROW("Parameter `inPointRelativeToCOM` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inPointRelativeToCOM))
    ));
}

JPH_Vec3 *JPH_MotionProperties_GetAccumulatedForce(const JPH_MotionProperties *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetAccumulatedForce());
}

JPH_Vec3 *JPH_MotionProperties_GetAccumulatedTorque(const JPH_MotionProperties *_this)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetAccumulatedTorque());
}

void JPH_MotionProperties_ResetForce(JPH_MotionProperties *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).ResetForce();
}

void JPH_MotionProperties_ResetTorque(JPH_MotionProperties *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).ResetTorque();
}

void JPH_MotionProperties_ResetMotion(JPH_MotionProperties *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).ResetMotion();
}

JPH_UVec4 *JPH_MotionProperties_GetLinearDOFsMask(const JPH_MotionProperties *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetLinearDOFsMask());
}

JPH_Vec3 *JPH_MotionProperties_LockTranslation(const JPH_MotionProperties *_this, const JPH_Vec3 *inV)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).LockTranslation(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

JPH_UVec4 *JPH_MotionProperties_GetAngularDOFsMask(const JPH_MotionProperties *_this)
{
    return (JPH_UVec4 *)new JPH::UVec4(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetAngularDOFsMask());
}

JPH_Vec3 *JPH_MotionProperties_LockAngular(const JPH_MotionProperties *_this, const JPH_Vec3 *inV)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).LockAngular(
        ((inV ? void() : MRBINDC_THROW("Parameter `inV` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inV))
    ));
}

void JPH_MotionProperties_SetNumVelocityStepsOverride(JPH_MotionProperties *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SetNumVelocityStepsOverride(
        inN
    );
}

unsigned int JPH_MotionProperties_GetNumVelocityStepsOverride(const JPH_MotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetNumVelocityStepsOverride();
}

void JPH_MotionProperties_SetNumPositionStepsOverride(JPH_MotionProperties *_this, unsigned int inN)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SetNumPositionStepsOverride(
        inN
    );
}

unsigned int JPH_MotionProperties_GetNumPositionStepsOverride(const JPH_MotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetNumPositionStepsOverride();
}

void JPH_MotionProperties_AddLinearVelocityStep(JPH_MotionProperties *_this, const JPH_Vec3 *inLinearVelocityChange)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).AddLinearVelocityStep(
        ((inLinearVelocityChange ? void() : MRBINDC_THROW("Parameter `inLinearVelocityChange` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocityChange))
    );
}

void JPH_MotionProperties_SubLinearVelocityStep(JPH_MotionProperties *_this, const JPH_Vec3 *inLinearVelocityChange)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SubLinearVelocityStep(
        ((inLinearVelocityChange ? void() : MRBINDC_THROW("Parameter `inLinearVelocityChange` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inLinearVelocityChange))
    );
}

void JPH_MotionProperties_AddAngularVelocityStep(JPH_MotionProperties *_this, const JPH_Vec3 *inAngularVelocityChange)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).AddAngularVelocityStep(
        ((inAngularVelocityChange ? void() : MRBINDC_THROW("Parameter `inAngularVelocityChange` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocityChange))
    );
}

void JPH_MotionProperties_SubAngularVelocityStep(JPH_MotionProperties *_this, const JPH_Vec3 *inAngularVelocityChange)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SubAngularVelocityStep(
        ((inAngularVelocityChange ? void() : MRBINDC_THROW("Parameter `inAngularVelocityChange` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inAngularVelocityChange))
    );
}

void JPH_MotionProperties_ApplyGyroscopicForceInternal(JPH_MotionProperties *_this, const JPH_Quat *inBodyRotation, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).ApplyGyroscopicForceInternal(
        ((inBodyRotation ? void() : MRBINDC_THROW("Parameter `inBodyRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inBodyRotation)),
        inDeltaTime
    );
}

void JPH_MotionProperties_ApplyForceTorqueAndDragInternal(JPH_MotionProperties *_this, const JPH_Quat *inBodyRotation, const JPH_Vec3 *inGravity, float inDeltaTime)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).ApplyForceTorqueAndDragInternal(
        ((inBodyRotation ? void() : MRBINDC_THROW("Parameter `inBodyRotation` can not be null.", void)), JPH::Quat(*(JPH::Quat *)inBodyRotation)),
        ((inGravity ? void() : MRBINDC_THROW("Parameter `inGravity` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)inGravity)),
        inDeltaTime
    );
}

unsigned int JPH_MotionProperties_GetIslandIndexInternal(const JPH_MotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetIslandIndexInternal();
}

void JPH_MotionProperties_SetIslandIndexInternal(JPH_MotionProperties *_this, unsigned int inIndex)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).SetIslandIndexInternal(
        inIndex
    );
}

unsigned int JPH_MotionProperties_GetIndexInActiveBodiesInternal(const JPH_MotionProperties *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::MotionProperties *)(_this)).GetIndexInActiveBodiesInternal();
}

void JPH_MotionProperties_ResetSleepTestSpheres(JPH_MotionProperties *_this, const JPH_Vec3 *inPoints)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).ResetSleepTestSpheres(
        ((const JPH::Vec3 *)inPoints)
    );
}

void JPH_MotionProperties_ResetSleepTestTimer(JPH_MotionProperties *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::MotionProperties *)(_this)).ResetSleepTestTimer();
}

