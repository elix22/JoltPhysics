// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_NonCopyable JPH_NonCopyable; // Defined in `#include <jolt/Jolt/Core/NonCopyable.h>`.
typedef struct JPH_RefTarget_JPH_VehicleControllerSettings JPH_RefTarget_JPH_VehicleControllerSettings; // Defined in `#include <jolt/Jolt/Core/Reference.h>`.
typedef struct JPH_SerializableObject JPH_SerializableObject; // Defined in `#include <jolt/Jolt/ObjectStream/SerializableObject.h>`.
typedef struct JPH_VehicleConstraint JPH_VehicleConstraint; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleConstraint.h>`.


/// Basic settings object for interface that controls acceleration / deceleration of the vehicle
/// Generated from class `JPH::VehicleControllerSettings`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::SerializableObject`
///     `JPH::RefTarget<JPH::VehicleControllerSettings>`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::TrackedVehicleControllerSettings`
///     `JPH::WheeledVehicleControllerSettings`
///   Indirect: (non-virtual)
///     `JPH::MotorcycleControllerSettings`
typedef struct JPH_VehicleControllerSettings JPH_VehicleControllerSettings;

/// Runtime data for interface that controls acceleration / deceleration of the vehicle
/// Generated from class `JPH::VehicleController`.
/// Base classes:
///   Direct: (non-virtual)
///     `JPH::NonCopyable`
/// Derived classes:
///   Direct: (non-virtual)
///     `JPH::TrackedVehicleController`
///     `JPH::WheeledVehicleController`
///   Indirect: (non-virtual)
///     `JPH::MotorcycleController`
typedef struct JPH_VehicleController JPH_VehicleController;

/// Destroys a heap-allocated instance of `JPH_VehicleControllerSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleControllerSettings_Destroy(const JPH_VehicleControllerSettings *_this);

/// Destroys a heap-allocated array of `JPH_VehicleControllerSettings`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleControllerSettings_DestroyArray(const JPH_VehicleControllerSettings *_this);

/// Generated from method `JPH::VehicleControllerSettings::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleControllerSettings_size_t(size_t inCount);

/// Generated from method `JPH::VehicleControllerSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleControllerSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleControllerSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleControllerSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleControllerSettings_size_t(size_t inCount);

/// Generated from method `JPH::VehicleControllerSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleControllerSettings_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleControllerSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleControllerSettings_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleControllerSettings::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleControllerSettings::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::VehicleControllerSettings::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleControllerSettings_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleControllerSettings::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Create an instance of the vehicle controller class
/// Generated from method `JPH::VehicleControllerSettings::ConstructController`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inConstraint` can not be null. It is a single object.
JOLT_API JPH_VehicleController *JPH_VehicleControllerSettings_ConstructController(const JPH_VehicleControllerSettings *_this, JPH_VehicleConstraint *inConstraint);

/// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
/// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
/// the object and at that point in time it is checked that no references are left to the structure.
/// Generated from method `JPH::VehicleControllerSettings::SetEmbedded`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleControllerSettings_SetEmbedded(const JPH_VehicleControllerSettings *_this);

/// Get current refcount of this object
/// Generated from method `JPH::VehicleControllerSettings::GetRefCount`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API unsigned int JPH_VehicleControllerSettings_GetRefCount(const JPH_VehicleControllerSettings *_this);

/// Add or release a reference to this object
/// Generated from method `JPH::VehicleControllerSettings::AddRef`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleControllerSettings_AddRef(const JPH_VehicleControllerSettings *_this);

/// Generated from method `JPH::VehicleControllerSettings::Release`.
/// Parameter `_this` can not be null. It is a single object.
JOLT_API void JPH_VehicleControllerSettings_Release(const JPH_VehicleControllerSettings *_this);

/// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
/// Generated from method `JPH::VehicleControllerSettings::sInternalGetRefCountOffset`.
JOLT_API int JPH_VehicleControllerSettings_sInternalGetRefCountOffset(void);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_OffsetPtr(const JPH_VehicleControllerSettings *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_OffsetMutablePtr(JPH_VehicleControllerSettings *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::VehicleControllerSettings` to its base class `JPH::SerializableObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_SerializableObject *JPH_VehicleControllerSettings_UpcastTo_JPH_SerializableObject(const JPH_VehicleControllerSettings *object);

/// Upcasts an instance of `JPH::VehicleControllerSettings` to its base class `JPH::SerializableObject`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_SerializableObject *JPH_VehicleControllerSettings_MutableUpcastTo_JPH_SerializableObject(JPH_VehicleControllerSettings *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::VehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(const JPH_SerializableObject *object);

/// Downcasts an instance of `JPH::SerializableObject` to a derived class `JPH::VehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_MutableStaticDowncastFrom_JPH_SerializableObject(JPH_SerializableObject *object);

/// Upcasts an instance of `JPH::VehicleControllerSettings` to its base class `JPH::RefTarget<JPH::VehicleControllerSettings>`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_RefTarget_JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_VehicleControllerSettings *object);

/// Upcasts an instance of `JPH::VehicleControllerSettings` to its base class `JPH::RefTarget<JPH::VehicleControllerSettings>`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_RefTarget_JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_MutableUpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_VehicleControllerSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleControllerSettings>` to a derived class `JPH::VehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(const JPH_RefTarget_JPH_VehicleControllerSettings *object);

/// Downcasts an instance of `JPH::RefTarget<JPH::VehicleControllerSettings>` to a derived class `JPH::VehicleControllerSettings`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleControllerSettings *JPH_VehicleControllerSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(JPH_RefTarget_JPH_VehicleControllerSettings *object);

/// Destroys a heap-allocated instance of `JPH_VehicleController`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleController_Destroy(const JPH_VehicleController *_this);

/// Destroys a heap-allocated array of `JPH_VehicleController`. Does nothing if the pointer is null.
JOLT_API void JPH_VehicleController_DestroyArray(const JPH_VehicleController *_this);

/// Generated from method `JPH::VehicleController::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleController_size_t(size_t inCount);

/// Generated from method `JPH::VehicleController::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleController_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleController::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleController_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleController::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleController_size_t(size_t inCount);

/// Generated from method `JPH::VehicleController::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleController_void_ptr(void *inPointer);

/// Generated from method `JPH::VehicleController::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleController_void_ptr_size_t(void *inPointer, size_t inSize);

/// Generated from method `JPH::VehicleController::operator new`.
JOLT_API void *Jolt_new_JPH_VehicleController_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleController::operator delete`.
JOLT_API void Jolt_delete_JPH_VehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Generated from method `JPH::VehicleController::operator new[]`.
JOLT_API void *Jolt_new_array_JPH_VehicleController_size_t_void_ptr(size_t inCount, void *inPointer);

/// Generated from method `JPH::VehicleController::operator delete[]`.
JOLT_API void Jolt_delete_array_JPH_VehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace);

/// Access the vehicle constraint that this controller is part of
/// Generated from method `JPH::VehicleController::GetConstraint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API JPH_VehicleConstraint *JPH_VehicleController_GetConstraint_mut(JPH_VehicleController *_this);

/// Generated from method `JPH::VehicleController::GetConstraint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API const JPH_VehicleConstraint *JPH_VehicleController_GetConstraint(const JPH_VehicleController *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JPH_VehicleController *JPH_VehicleController_OffsetPtr(const JPH_VehicleController *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JPH_VehicleController *JPH_VehicleController_OffsetMutablePtr(JPH_VehicleController *ptr, ptrdiff_t i);

/// Upcasts an instance of `JPH::VehicleController` to its base class `JPH::NonCopyable`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_NonCopyable *JPH_VehicleController_UpcastTo_JPH_NonCopyable(const JPH_VehicleController *object);

/// Upcasts an instance of `JPH::VehicleController` to its base class `JPH::NonCopyable`.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_NonCopyable *JPH_VehicleController_MutableUpcastTo_JPH_NonCopyable(JPH_VehicleController *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::VehicleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API const JPH_VehicleController *JPH_VehicleController_StaticDowncastFrom_JPH_NonCopyable(const JPH_NonCopyable *object);

/// Downcasts an instance of `JPH::NonCopyable` to a derived class `JPH::VehicleController`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
JOLT_API JPH_VehicleController *JPH_VehicleController_MutableStaticDowncastFrom_JPH_NonCopyable(JPH_NonCopyable *object);

#ifdef __cplusplus
} // extern "C"
#endif
