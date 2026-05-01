/* jolt_init.cpp — implementation of JoltHelpers.
   Compiled with -include Jolt/Jolt.h (force-included by run.sh). */

#define JOLT_BUILD_LIBRARY

#include <Jolt/Core/Factory.h>
#include <Jolt/RegisterTypes.h>
#include <Jolt/Physics/PhysicsSystem.h>

#include <cstdarg>
#include <cstdio>

#include "jolt_init_wrapper.h"

using namespace JPH;

static void sTrace(const char *fmt, ...)
{
    va_list args;
    va_start(args, fmt);
    vprintf(fmt, args);
    va_end(args);
    putchar('\n');
}

JPH_IF_ENABLE_ASSERTS(
static bool sAssertFailed(const char *inExpr, const char *inMsg,
                          const char *inFile, uint inLine)
{
    sTrace("%s:%u: (%s) %s", inFile, inLine, inExpr, inMsg ? inMsg : "");
    return true;
}
)

void JoltHelpers::Init()
{
    Trace = sTrace;
    JPH_IF_ENABLE_ASSERTS(AssertFailed = sAssertFailed;)
    RegisterDefaultAllocator();
    Factory::sInstance = new Factory();
    RegisterTypes();
}

void JoltHelpers::Shutdown()
{
    UnregisterTypes();
    delete Factory::sInstance;
    Factory::sInstance = nullptr;
}

float JoltHelpers::RayAABox(JPH::Vec3Arg inOrigin, const JPH::RayInvDirection& inInvDirection, JPH::Vec3Arg inBoundsMin, JPH::Vec3Arg inBoundsMax)
{
    return JPH::RayAABox(inOrigin, inInvDirection, inBoundsMin, inBoundsMax);
}

void JoltHelpers::VehicleSettingsAddWheel(JPH::VehicleConstraintSettings& settings, JPH::WheelSettingsWV* wheel)
{
    settings.mWheels.push_back(wheel);
}

void JoltHelpers::VehicleSettingsSetController(JPH::VehicleConstraintSettings& settings, JPH::WheeledVehicleControllerSettings* ctrl)
{
    settings.mController = ctrl;
}

void JoltHelpers::VehicleSettingsAddAntiRollBar(JPH::VehicleConstraintSettings& settings, const JPH::VehicleAntiRollBar& bar)
{
    settings.mAntiRollBars.push_back(bar);
}

void JoltHelpers::WheeledControllerSettingsAddDifferential(JPH::WheeledVehicleControllerSettings& settings, const JPH::VehicleDifferentialSettings& diff)
{
    settings.mDifferentials.push_back(diff);
}

JPH::WheeledVehicleController* JoltHelpers::VehicleConstraintGetWheeledController(JPH::VehicleConstraint& constraint)
{
    // Jolt is compiled without RTTI; use static_cast since the caller is responsible
    // for only calling this when the vehicle uses a WheeledVehicleControllerSettings.
    return static_cast<JPH::WheeledVehicleController*>(constraint.GetController());
}

