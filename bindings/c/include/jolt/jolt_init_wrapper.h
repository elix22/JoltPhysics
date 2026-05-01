// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct JPH_RayInvDirection JPH_RayInvDirection; // Defined in `#include <jolt/Jolt/Geometry/RayAABox.h>`.
typedef struct JPH_Vec3 JPH_Vec3; // Defined in `#include <jolt/Jolt/Math/Vec3.h>`.
typedef struct JPH_VehicleAntiRollBar JPH_VehicleAntiRollBar; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleAntiRollBar.h>`.
typedef struct JPH_VehicleConstraint JPH_VehicleConstraint; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleConstraint.h>`.
typedef struct JPH_VehicleConstraintSettings JPH_VehicleConstraintSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleConstraint.h>`.
typedef struct JPH_VehicleDifferentialSettings JPH_VehicleDifferentialSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/VehicleDifferential.h>`.
typedef struct JPH_WheelSettingsWV JPH_WheelSettingsWV; // Defined in `#include <jolt/Jolt/Physics/Vehicle/WheeledVehicleController.h>`.
typedef struct JPH_WheeledVehicleController JPH_WheeledVehicleController; // Defined in `#include <jolt/Jolt/Physics/Vehicle/WheeledVehicleController.h>`.
typedef struct JPH_WheeledVehicleControllerSettings JPH_WheeledVehicleControllerSettings; // Defined in `#include <jolt/Jolt/Physics/Vehicle/WheeledVehicleController.h>`.


/// Minimal helpers for Jolt global lifecycle.
/// These are the only hand-implemented methods; their C/C# bindings are machine-generated.
/// Generated from class `JoltHelpers`.
/// Supported `Jolt_PassBy` modes: `Jolt_PassBy_DefaultConstruct`, `Jolt_PassBy_Copy`, `Jolt_PassBy_Move` (and `Jolt_PassBy_DefaultArgument` and `Jolt_PassBy_NoObject` if supported by the callee).
typedef struct JoltHelpers JoltHelpers;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltHelpers_Destroy()` to free it when you're done using it.
JOLT_API JoltHelpers *JoltHelpers_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `JoltHelpers_DestroyArray()`.
/// Use `JoltHelpers_OffsetMutablePtr()` and `JoltHelpers_OffsetPtr()` to access the array elements.
JOLT_API JoltHelpers *JoltHelpers_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API const JoltHelpers *JoltHelpers_OffsetPtr(const JoltHelpers *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
JOLT_API JoltHelpers *JoltHelpers_OffsetMutablePtr(JoltHelpers *ptr, ptrdiff_t i);

/// Generated from constructor `JoltHelpers::JoltHelpers`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `JoltHelpers_Destroy()` to free it when you're done using it.
JOLT_API JoltHelpers *JoltHelpers_ConstructFromAnother(const JoltHelpers *_other);

/// Destroys a heap-allocated instance of `JoltHelpers`. Does nothing if the pointer is null.
JOLT_API void JoltHelpers_Destroy(const JoltHelpers *_this);

/// Destroys a heap-allocated array of `JoltHelpers`. Does nothing if the pointer is null.
JOLT_API void JoltHelpers_DestroyArray(const JoltHelpers *_this);

/// Generated from method `JoltHelpers::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
JOLT_API JoltHelpers *JoltHelpers_AssignFromAnother(JoltHelpers *_this, const JoltHelpers *_other);

/// Initialize Jolt: set Trace, RegisterDefaultAllocator, create Factory, RegisterTypes.
/// Generated from method `JoltHelpers::Init`.
JOLT_API void JoltHelpers_Init(void);

/// Generated from method `JoltHelpers::Shutdown`.
JOLT_API void JoltHelpers_Shutdown(void);

/// Wrapper for the free function JPH::RayAABox (mrbind only binds named types).
/// Returns the minimal distance along the ray, or FLT_MAX if no hit.
/// Note: can return a negative value if the ray starts inside the box.
/// Generated from method `JoltHelpers::RayAABox`.
/// Parameter `inOrigin` can not be null. It is a single object.
/// Parameter `inInvDirection` can not be null. It is a single object.
/// Parameter `inBoundsMin` can not be null. It is a single object.
/// Parameter `inBoundsMax` can not be null. It is a single object.
JOLT_API float JoltHelpers_RayAABox(const JPH_Vec3 *inOrigin, const JPH_RayInvDirection *inInvDirection, const JPH_Vec3 *inBoundsMin, const JPH_Vec3 *inBoundsMax);

/// Append a WheelSettingsWV to VehicleConstraintSettings::mWheels.
/// Generated from method `JoltHelpers::VehicleSettingsAddWheel`.
/// Parameter `settings` can not be null. It is a single object.
JOLT_API void JoltHelpers_VehicleSettingsAddWheel(JPH_VehicleConstraintSettings *settings, JPH_WheelSettingsWV *wheel);

/// Set VehicleConstraintSettings::mController to a WheeledVehicleControllerSettings.
/// Generated from method `JoltHelpers::VehicleSettingsSetController`.
/// Parameter `settings` can not be null. It is a single object.
JOLT_API void JoltHelpers_VehicleSettingsSetController(JPH_VehicleConstraintSettings *settings, JPH_WheeledVehicleControllerSettings *ctrl);

/// Append a VehicleAntiRollBar to VehicleConstraintSettings::mAntiRollBars.
/// Generated from method `JoltHelpers::VehicleSettingsAddAntiRollBar`.
/// Parameter `settings` can not be null. It is a single object.
/// Parameter `bar` can not be null. It is a single object.
JOLT_API void JoltHelpers_VehicleSettingsAddAntiRollBar(JPH_VehicleConstraintSettings *settings, const JPH_VehicleAntiRollBar *bar);

/// Append a VehicleDifferentialSettings to WheeledVehicleControllerSettings::mDifferentials.
/// Generated from method `JoltHelpers::WheeledControllerSettingsAddDifferential`.
/// Parameter `settings` can not be null. It is a single object.
/// Parameter `diff` can not be null. It is a single object.
JOLT_API void JoltHelpers_WheeledControllerSettingsAddDifferential(JPH_WheeledVehicleControllerSettings *settings, const JPH_VehicleDifferentialSettings *diff);

/// Cast the VehicleController on a VehicleConstraint to WheeledVehicleController.
/// Returns nullptr if the controller is not a WheeledVehicleController.
/// Generated from method `JoltHelpers::VehicleConstraintGetWheeledController`.
/// Parameter `constraint` can not be null. It is a single object.
JOLT_API JPH_WheeledVehicleController *JoltHelpers_VehicleConstraintGetWheeledController(JPH_VehicleConstraint *constraint);

#ifdef __cplusplus
} // extern "C"
#endif
