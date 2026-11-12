// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/Vehicle/VehicleController.h"

#include <Jolt/Core/NonCopyable.h>
#include <Jolt/Core/Reference.h>
#include <Jolt/ObjectStream/SerializableObject.h>
#include <Jolt/Physics/Vehicle/VehicleConstraint.h>
#include <Jolt/Physics/Vehicle/VehicleController.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


void JPH_VehicleControllerSettings_Destroy(const JPH_VehicleControllerSettings *_this)
{
    delete ((const JPH::VehicleControllerSettings *)_this);
}

void JPH_VehicleControllerSettings_DestroyArray(const JPH_VehicleControllerSettings *_this)
{
    delete[] ((const JPH::VehicleControllerSettings *)_this);
}

void *Jolt_new_JPH_VehicleControllerSettings_size_t(size_t inCount)
{
    return JPH::VehicleControllerSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_VehicleControllerSettings_void_ptr(void *inPointer)
{
    JPH::VehicleControllerSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_VehicleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleControllerSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_VehicleControllerSettings_size_t(size_t inCount)
{
    return JPH::VehicleControllerSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_VehicleControllerSettings_void_ptr(void *inPointer)
{
    JPH::VehicleControllerSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleControllerSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_VehicleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleControllerSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_VehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleControllerSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_VehicleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleControllerSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleControllerSettings::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_VehicleController *JPH_VehicleControllerSettings_ConstructController(const JPH_VehicleControllerSettings *_this, JPH_VehicleConstraint *inConstraint)
{
    return (JPH_VehicleController *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleControllerSettings *)(_this)).ConstructController(
        ((inConstraint ? void() : MRBINDC_THROW("Parameter `inConstraint` can not be null.", void)), *(JPH::VehicleConstraint *)(inConstraint))
    ));
}

void JPH_VehicleControllerSettings_SetEmbedded(const JPH_VehicleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleControllerSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_VehicleControllerSettings_GetRefCount(const JPH_VehicleControllerSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleControllerSettings *)(_this)).GetRefCount();
}

void JPH_VehicleControllerSettings_AddRef(const JPH_VehicleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleControllerSettings *)(_this)).AddRef();
}

void JPH_VehicleControllerSettings_Release(const JPH_VehicleControllerSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleControllerSettings *)(_this)).Release();
}

int JPH_VehicleControllerSettings_sInternalGetRefCountOffset(void)
{
    return JPH::VehicleControllerSettings::sInternalGetRefCountOffset();
}

const JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_OffsetPtr(const JPH_VehicleControllerSettings *ptr, ptrdiff_t i)
{
    return (const JPH_VehicleControllerSettings *)(((const JPH::VehicleControllerSettings *)ptr) + i);
}

JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_OffsetMutablePtr(JPH_VehicleControllerSettings *ptr, ptrdiff_t i)
{
    return (JPH_VehicleControllerSettings *)(((JPH::VehicleControllerSettings *)ptr) + i);
}

const JPH_SerializableObject *JPH_VehicleControllerSettings_UpcastTo_JPH_SerializableObject(const JPH_VehicleControllerSettings *object)
{
    return (const JPH_SerializableObject *)(static_cast<const JPH::SerializableObject *>(
        ((const JPH::VehicleControllerSettings *)object)
    ));
}

JPH_SerializableObject *JPH_VehicleControllerSettings_MutableUpcastTo_JPH_SerializableObject(JPH_VehicleControllerSettings *object)
{
    return (JPH_SerializableObject *)(static_cast<JPH::SerializableObject *>(
        ((JPH::VehicleControllerSettings *)object)
    ));
}

const JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object)
{
    return (const JPH_VehicleControllerSettings *)(static_cast<const JPH::VehicleControllerSettings *>(
        ((const JPH::SerializableObject *)object)
    ));
}

JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object)
{
    return (JPH_VehicleControllerSettings *)(static_cast<JPH::VehicleControllerSettings *>(
        ((JPH::SerializableObject *)object)
    ));
}

const JPH_RefTarget_JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_VehicleControllerSettings *object)
{
    return (const JPH_RefTarget_JPH_VehicleControllerSettings *)(static_cast<const JPH::RefTarget<JPH::VehicleControllerSettings> *>(
        ((const JPH::VehicleControllerSettings *)object)
    ));
}

JPH_RefTarget_JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_MutableUpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_VehicleControllerSettings *object)
{
    return (JPH_RefTarget_JPH_VehicleControllerSettings *)(static_cast<JPH::RefTarget<JPH::VehicleControllerSettings> *>(
        ((JPH::VehicleControllerSettings *)object)
    ));
}

const JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_RefTarget_JPH_VehicleControllerSettings *object)
{
    return (const JPH_VehicleControllerSettings *)(static_cast<const JPH::VehicleControllerSettings *>(
        ((const JPH::RefTarget<JPH::VehicleControllerSettings> *)object)
    ));
}

JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_RefTarget_JPH_VehicleControllerSettings *object)
{
    return (JPH_VehicleControllerSettings *)(static_cast<JPH::VehicleControllerSettings *>(
        ((JPH::RefTarget<JPH::VehicleControllerSettings> *)object)
    ));
}

void JPH_VehicleController_Destroy(const JPH_VehicleController *_this)
{
    delete ((const JPH::VehicleController *)_this);
}

void JPH_VehicleController_DestroyArray(const JPH_VehicleController *_this)
{
    delete[] ((const JPH::VehicleController *)_this);
}

void *Jolt_new_JPH_VehicleController_size_t(size_t inCount)
{
    return JPH::VehicleController::operator new(
        inCount
    );
}

void Jolt_delete_JPH_VehicleController_void_ptr(void *inPointer)
{
    JPH::VehicleController::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_VehicleController_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleController::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_VehicleController_size_t(size_t inCount)
{
    return JPH::VehicleController::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_VehicleController_void_ptr(void *inPointer)
{
    JPH::VehicleController::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleController_void_ptr_size_t(void *inPointer, size_t inSize)
{
    JPH::VehicleController::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_VehicleController_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleController::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_VehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleController::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_VehicleController_size_t_void_ptr(size_t inCount, void *inPointer)
{
    return JPH::VehicleController::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_VehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::VehicleController::operator delete[](
        inPointer,
        inPlace
    );
}

JPH_VehicleConstraint *JPH_VehicleController_GetConstraint_mut(JPH_VehicleController *_this)
{
    return (JPH_VehicleConstraint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::VehicleController *)(_this)).GetConstraint());
}

const JPH_VehicleConstraint *JPH_VehicleController_GetConstraint(const JPH_VehicleController *_this)
{
    return (const JPH_VehicleConstraint *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::VehicleController *)(_this)).GetConstraint());
}

const JPH_VehicleController *JPH_VehicleController_OffsetPtr(const JPH_VehicleController *ptr, ptrdiff_t i)
{
    return (const JPH_VehicleController *)(((const JPH::VehicleController *)ptr) + i);
}

JPH_VehicleController *JPH_VehicleController_OffsetMutablePtr(JPH_VehicleController *ptr, ptrdiff_t i)
{
    return (JPH_VehicleController *)(((JPH::VehicleController *)ptr) + i);
}

const JPH_NonCopyable *JPH_VehicleController_UpcastTo_JPH_NonCopyable(const JPH_VehicleController *object)
{
    return (const JPH_NonCopyable *)(static_cast<const JPH::NonCopyable *>(
        ((const JPH::VehicleController *)object)
    ));
}

JPH_NonCopyable *JPH_VehicleController_MutableUpcastTo_JPH_NonCopyable(JPH_VehicleController *object)
{
    return (JPH_NonCopyable *)(static_cast<JPH::NonCopyable *>(
        ((JPH::VehicleController *)object)
    ));
}

const JPH_VehicleController *JPH_VehicleController_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object)
{
    return (const JPH_VehicleController *)(static_cast<const JPH::VehicleController *>(
        ((const JPH::NonCopyable *)object)
    ));
}

JPH_VehicleController *JPH_VehicleController_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object)
{
    return (JPH_VehicleController *)(static_cast<JPH::VehicleController *>(
        ((JPH::NonCopyable *)object)
    ));
}

