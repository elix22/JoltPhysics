#pragma once
/* jolt_init_wrapper.h — Parsed by mrbind to auto-generate C and C# bindings.
 * Only contains APIs that cannot be expressed through Jolt's own headers:
 *   - Global lifecycle (mrbind only binds named types, not free functions)
 *   - Vec3/RVec3 bridge methods (SIMD types mrbind cannot bind directly)
 *   - Free function wrappers (mrbind only binds named types, not free functions) */

#include <Jolt/Jolt.h>
#include <Jolt/Geometry/RayAABox.h>
#include <Jolt/Physics/Vehicle/WheeledVehicleController.h>

/// Minimal helpers for Jolt global lifecycle.
/// These are the only hand-implemented methods; their C/C# bindings are machine-generated.
struct JoltHelpers
{
    /// Initialize Jolt: set Trace, RegisterDefaultAllocator, create Factory, RegisterTypes.
    static void Init();
    static void Shutdown();

    /// Wrapper for the free function JPH::RayAABox (mrbind only binds named types).
    /// Returns the minimal distance along the ray, or FLT_MAX if no hit.
    /// Note: can return a negative value if the ray starts inside the box.
    static float RayAABox(JPH::Vec3Arg inOrigin, const JPH::RayInvDirection& inInvDirection, JPH::Vec3Arg inBoundsMin, JPH::Vec3Arg inBoundsMax);

    // -----------------------------------------------------------------------
    // Vehicle helpers — expose Array field manipulation to C# (mrbind cannot
    // bind std::vector / JPH::Array directly).
    // -----------------------------------------------------------------------

    /// Append a WheelSettingsWV to VehicleConstraintSettings::mWheels.
    static void VehicleSettingsAddWheel(JPH::VehicleConstraintSettings& settings, JPH::WheelSettingsWV* wheel);

    /// Set VehicleConstraintSettings::mController to a WheeledVehicleControllerSettings.
    static void VehicleSettingsSetController(JPH::VehicleConstraintSettings& settings, JPH::WheeledVehicleControllerSettings* ctrl);

    /// Append a VehicleAntiRollBar to VehicleConstraintSettings::mAntiRollBars.
    static void VehicleSettingsAddAntiRollBar(JPH::VehicleConstraintSettings& settings, const JPH::VehicleAntiRollBar& bar);

    /// Append a VehicleDifferentialSettings to WheeledVehicleControllerSettings::mDifferentials.
    static void WheeledControllerSettingsAddDifferential(JPH::WheeledVehicleControllerSettings& settings, const JPH::VehicleDifferentialSettings& diff);

    /// Cast the VehicleController on a VehicleConstraint to WheeledVehicleController.
    /// Returns nullptr if the controller is not a WheeledVehicleController.
    static JPH::WheeledVehicleController* VehicleConstraintGetWheeledController(JPH::VehicleConstraint& constraint);
};
