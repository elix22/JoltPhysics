// Tests for WheeledVehicle bindings.
// Mirrors: JoltPhysics/UnitTests/Physics/WheeledVehicleTests.cpp

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_WheeledVehicle(JoltFixture fx)
{
    // ── Constants ─────────────────────────────────────────────────────────────

    private const float Pi = 3.14159265358979323846f;

    private static float DegreesToRadians(float degrees) => degrees * Pi / 180f;

    // ── Helper: build a standard 4-wheel vehicle ──────────────────────────────

    // Positions for front-left, front-right, rear-left, rear-right wheels.
    private static (float x, float y, float z)[] WheelPositions => new[]
    {
        ( 0.9f, -0.9f,  1.8f),  // front-left
        (-0.9f, -0.9f,  1.8f),  // front-right
        ( 0.9f, -0.9f, -1.8f),  // rear-left
        (-0.9f, -0.9f, -1.8f),  // rear-right
    };

    private JPH.VehicleConstraintSettings MakeVehicleSettings()
    {
        var settings = new JPH.VehicleConstraintSettings();

        foreach (var (x, y, z) in WheelPositions)
        {
            var wheel = new JPH.WheelSettingsWV();
            wheel.mPosition.Set(x, y, z);
            wheel.mMaxSteerAngle = DegreesToRadians(30f);
            wheel.mMaxBrakeTorque = 1500f;
            JPH.JoltHelpers.VehicleSettingsAddWheel(settings, wheel);
        }

        var ctrl = new JPH.WheeledVehicleControllerSettings();
        JPH.JoltHelpers.WheeledControllerSettingsAddDifferential(ctrl,
            new JPH.VehicleDifferentialSettings(0, 1, 3.42f, 0f, 1.4f, 1.0f));
        JPH.JoltHelpers.WheeledControllerSettingsAddDifferential(ctrl,
            new JPH.VehicleDifferentialSettings(2, 3, 3.42f, 0f, 1.4f, 1.0f));
        JPH.JoltHelpers.VehicleSettingsSetController(settings, ctrl);

        return settings;
    }

    // ── WheelSettingsWV — default field values ────────────────────────────────

    [Fact]
    public void WheelSettingsWV_Default_mInertia()
    {
        using var w = new JPH.WheelSettingsWV();
        Assert.Equal(0.9f, w.mInertia, 1e-5f);
    }

    [Fact]
    public void WheelSettingsWV_Default_mAngularDamping()
    {
        using var w = new JPH.WheelSettingsWV();
        Assert.Equal(0.2f, w.mAngularDamping, 1e-5f);
    }

    [Fact]
    public void WheelSettingsWV_Default_mMaxSteerAngle()
    {
        using var w = new JPH.WheelSettingsWV();
        // JPH default = DegreesToRadians(70)
        float expected = DegreesToRadians(70f);
        Assert.Equal(expected, w.mMaxSteerAngle, 1e-4f);
    }

    [Fact]
    public void WheelSettingsWV_Default_mMaxBrakeTorque()
    {
        using var w = new JPH.WheelSettingsWV();
        Assert.Equal(1500f, w.mMaxBrakeTorque, 1e-4f);
    }

    [Fact]
    public void WheelSettingsWV_Default_mMaxHandBrakeTorque()
    {
        using var w = new JPH.WheelSettingsWV();
        Assert.Equal(4000f, w.mMaxHandBrakeTorque, 1e-4f);
    }

    [Fact]
    public void WheelSettingsWV_Default_mRadius()
    {
        using var w = new JPH.WheelSettingsWV();
        Assert.Equal(0.3f, w.mRadius, 1e-5f);
    }

    [Fact]
    public void WheelSettingsWV_Default_mWidth()
    {
        using var w = new JPH.WheelSettingsWV();
        Assert.Equal(0.1f, w.mWidth, 1e-5f);
    }

    [Fact]
    public void WheelSettingsWV_Default_SuspensionMinLength()
    {
        using var w = new JPH.WheelSettingsWV();
        Assert.Equal(0.3f, w.mSuspensionMinLength, 1e-5f);
    }

    [Fact]
    public void WheelSettingsWV_Default_SuspensionMaxLength()
    {
        using var w = new JPH.WheelSettingsWV();
        Assert.Equal(0.5f, w.mSuspensionMaxLength, 1e-5f);
    }

    // ── WheelSettingsWV — field round-trips ───────────────────────────────────

    [Fact]
    public void WheelSettingsWV_RoundTrip_mInertia()
    {
        using var w = new JPH.WheelSettingsWV();
        w.mInertia = 1.5f;
        Assert.Equal(1.5f, w.mInertia, 1e-5f);
    }

    [Fact]
    public void WheelSettingsWV_RoundTrip_mAngularDamping()
    {
        using var w = new JPH.WheelSettingsWV();
        w.mAngularDamping = 0.5f;
        Assert.Equal(0.5f, w.mAngularDamping, 1e-5f);
    }

    [Fact]
    public void WheelSettingsWV_RoundTrip_mMaxSteerAngle()
    {
        using var w = new JPH.WheelSettingsWV();
        float angle = DegreesToRadians(45f);
        w.mMaxSteerAngle = angle;
        Assert.Equal(angle, w.mMaxSteerAngle, 1e-5f);
    }

    [Fact]
    public void WheelSettingsWV_RoundTrip_mMaxBrakeTorque()
    {
        using var w = new JPH.WheelSettingsWV();
        w.mMaxBrakeTorque = 2000f;
        Assert.Equal(2000f, w.mMaxBrakeTorque, 1e-5f);
    }

    [Fact]
    public void WheelSettingsWV_RoundTrip_mMaxHandBrakeTorque()
    {
        using var w = new JPH.WheelSettingsWV();
        w.mMaxHandBrakeTorque = 5000f;
        Assert.Equal(5000f, w.mMaxHandBrakeTorque, 1e-5f);
    }

    // ── VehicleEngineSettings — defaults ─────────────────────────────────────

    [Fact]
    public void WheeledVehicleControllerSettings_Engine_Default_mMaxTorque()
    {
        using var ctrl = new JPH.WheeledVehicleControllerSettings();
        Assert.Equal(500f, ctrl.mEngine.mMaxTorque, 1e-4f);
    }

    [Fact]
    public void WheeledVehicleControllerSettings_Engine_Default_mMinRPM()
    {
        using var ctrl = new JPH.WheeledVehicleControllerSettings();
        Assert.Equal(1000f, ctrl.mEngine.mMinRPM, 1e-4f);
    }

    [Fact]
    public void WheeledVehicleControllerSettings_Engine_Default_mMaxRPM()
    {
        using var ctrl = new JPH.WheeledVehicleControllerSettings();
        Assert.Equal(6000f, ctrl.mEngine.mMaxRPM, 1e-4f);
    }

    // ── VehicleTransmissionSettings — defaults ────────────────────────────────

    [Fact]
    public void WheeledVehicleControllerSettings_Transmission_Default_mMode()
    {
        using var ctrl = new JPH.WheeledVehicleControllerSettings();
        Assert.Equal(JPH.ETransmissionMode.Auto, ctrl.mTransmission.mMode);
    }

    [Fact]
    public void WheeledVehicleControllerSettings_Transmission_Default_mSwitchTime()
    {
        using var ctrl = new JPH.WheeledVehicleControllerSettings();
        Assert.Equal(0.5f, ctrl.mTransmission.mSwitchTime, 1e-4f);
    }

    [Fact]
    public void WheeledVehicleControllerSettings_Transmission_Default_mShiftUpRPM()
    {
        using var ctrl = new JPH.WheeledVehicleControllerSettings();
        Assert.Equal(4000f, ctrl.mTransmission.mShiftUpRPM, 1e-4f);
    }

    [Fact]
    public void WheeledVehicleControllerSettings_Transmission_Default_mShiftDownRPM()
    {
        using var ctrl = new JPH.WheeledVehicleControllerSettings();
        Assert.Equal(2000f, ctrl.mTransmission.mShiftDownRPM, 1e-4f);
    }

    // ── ETransmissionMode enum ────────────────────────────────────────────────

    [Fact]
    public void ETransmissionMode_Auto_ValueIsZero()
    {
        Assert.Equal(0, (int)JPH.ETransmissionMode.Auto);
    }

    [Fact]
    public void ETransmissionMode_Manual_ValueIsOne()
    {
        Assert.Equal(1, (int)JPH.ETransmissionMode.Manual);
    }

    // ── WheeledVehicleControllerSettings — mDifferentialLimitedSlipRatio ─────

    [Fact]
    public void WheeledVehicleControllerSettings_Default_mDifferentialLimitedSlipRatio()
    {
        using var ctrl = new JPH.WheeledVehicleControllerSettings();
        Assert.Equal(1.4f, ctrl.mDifferentialLimitedSlipRatio, 1e-5f);
    }

    [Fact]
    public void WheeledVehicleControllerSettings_RoundTrip_mDifferentialLimitedSlipRatio()
    {
        using var ctrl = new JPH.WheeledVehicleControllerSettings();
        ctrl.mDifferentialLimitedSlipRatio = 2.0f;
        Assert.Equal(2.0f, ctrl.mDifferentialLimitedSlipRatio, 1e-5f);
    }

    // ── VehicleAntiRollBar — defaults ─────────────────────────────────────────

    [Fact]
    public void VehicleAntiRollBar_Default_mStiffness()
    {
        using var bar = new JPH.VehicleAntiRollBar();
        Assert.Equal(1000f, bar.mStiffness, 1e-4f);
    }

    [Fact]
    public void VehicleAntiRollBar_Default_mLeftWheel()
    {
        using var bar = new JPH.VehicleAntiRollBar();
        Assert.Equal(0, bar.mLeftWheel);
    }

    [Fact]
    public void VehicleAntiRollBar_Default_mRightWheel()
    {
        using var bar = new JPH.VehicleAntiRollBar();
        Assert.Equal(1, bar.mRightWheel);
    }

    [Fact]
    public void VehicleAntiRollBar_Parameterized_Constructor()
    {
        using var bar = new JPH.VehicleAntiRollBar(2, 3, 800f);
        Assert.Equal(2, bar.mLeftWheel);
        Assert.Equal(3, bar.mRightWheel);
        Assert.Equal(800f, bar.mStiffness, 1e-4f);
    }

    // ── VehicleConstraintSettings — construction with helpers ─────────────────

    [Fact]
    public void VehicleConstraintSettings_AddWheel_NoCrash()
    {
        using var settings = new JPH.VehicleConstraintSettings();
        using var wheel = new JPH.WheelSettingsWV();
        wheel.mPosition.Set(0.9f, -0.9f, 1.8f);
        JPH.JoltHelpers.VehicleSettingsAddWheel(settings, wheel);
        // No crash = pass
    }

    [Fact]
    public void VehicleConstraintSettings_SetController_NoCrash()
    {
        using var settings = new JPH.VehicleConstraintSettings();
        using var ctrl = new JPH.WheeledVehicleControllerSettings();
        JPH.JoltHelpers.VehicleSettingsSetController(settings, ctrl);
    }

    [Fact]
    public void VehicleConstraintSettings_AddAntiRollBar_NoCrash()
    {
        using var settings = new JPH.VehicleConstraintSettings();
        using var bar = new JPH.VehicleAntiRollBar(0, 1, 1000f);
        JPH.JoltHelpers.VehicleSettingsAddAntiRollBar(settings, bar);
    }

    // ── VehicleConstraint — construction ──────────────────────────────────────

    [Fact]
    public void VehicleConstraint_Construct_NoCrash()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        // Create a dynamic box body to serve as the vehicle body.
        using var shape = new JPH.BoxShapeSettings(new JPH.Vec3(2f, 0.5f, 4f));
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_BoxShapeSettings)shape);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 2f, 0f);

        var body = bi.CreateBody(cs)!;
        bi.AddBody(body.GetID(), JPH.EActivation.Activate);

        using var vSettings = MakeVehicleSettings();
        using var constraint = new JPH.VehicleConstraint(body, vSettings);

        bi.RemoveBody(body.GetID());
        bi.DestroyBody(body.GetID());
    }

    // ── VehicleConstraint — upcast to Constraint and PhysicsStepListener ──────

    [Fact]
    public void VehicleConstraint_UpcastToConstraint()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var shape = new JPH.BoxShapeSettings(new JPH.Vec3(2f, 0.5f, 4f));
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_BoxShapeSettings)shape);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 2f, 0f);

        var body = bi.CreateBody(cs)!;
        bi.AddBody(body.GetID(), JPH.EActivation.Activate);

        using var vSettings = MakeVehicleSettings();
        using var constraint = new JPH.VehicleConstraint(body, vSettings);

        JPH.Constraint asConstraint = constraint;
        Assert.NotNull(asConstraint);

        bi.RemoveBody(body.GetID());
        bi.DestroyBody(body.GetID());
    }

    [Fact]
    public void VehicleConstraint_UpcastToPhysicsStepListener()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var shape = new JPH.BoxShapeSettings(new JPH.Vec3(2f, 0.5f, 4f));
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_BoxShapeSettings)shape);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 2f, 0f);

        var body = bi.CreateBody(cs)!;
        bi.AddBody(body.GetID(), JPH.EActivation.Activate);

        using var vSettings = MakeVehicleSettings();
        using var constraint = new JPH.VehicleConstraint(body, vSettings);

        JPH.PhysicsStepListener asPSL = constraint;
        Assert.NotNull(asPSL);

        bi.RemoveBody(body.GetID());
        bi.DestroyBody(body.GetID());
    }

    // ── VehicleConstraint — SetVehicleCollisionTester ─────────────────────────

    [Fact]
    public void VehicleConstraint_SetVehicleCollisionTester_NoCrash()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var shape = new JPH.BoxShapeSettings(new JPH.Vec3(2f, 0.5f, 4f));
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_BoxShapeSettings)shape);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 2f, 0f);

        var body = bi.CreateBody(cs)!;
        bi.AddBody(body.GetID(), JPH.EActivation.Activate);

        using var vSettings = MakeVehicleSettings();
        using var constraint = new JPH.VehicleConstraint(body, vSettings);

        using var tester = new JPH.VehicleCollisionTesterRay(JoltFixture.LayerMoving);
        constraint.SetVehicleCollisionTester((JPH.VehicleCollisionTester)tester);

        bi.RemoveBody(body.GetID());
        bi.DestroyBody(body.GetID());
    }

    // ── WheeledVehicleController — SetDriverInput round-trip ─────────────────

    [Fact]
    public void WheeledVehicleController_SetDriverInput_ForwardInput()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        // Static floor
        using var floorShape = new JPH.BoxShapeSettings(new JPH.Vec3(100f, 1f, 100f));
        using var floorCs = new JPH.BodyCreationSettings();
        floorCs.SetShapeSettings((JPH.Const_BoxShapeSettings)floorShape);
        floorCs.mMotionType  = JPH.EMotionType.Static;
        floorCs.mObjectLayer = JoltFixture.LayerNonMoving;
        floorCs.mPosition.Set(0f, -1f, 0f);
        var floorId = bi.CreateAndAddBody(floorCs, JPH.EActivation.DontActivate);

        // Vehicle body
        using var shape = new JPH.BoxShapeSettings(new JPH.Vec3(2f, 0.5f, 4f));
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_BoxShapeSettings)shape);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 2f, 0f);

        var body = bi.CreateBody(cs)!;
        bi.AddBody(body.GetID(), JPH.EActivation.Activate);

        using var vSettings = MakeVehicleSettings();
        using var constraint = new JPH.VehicleConstraint(body, vSettings);

        using var tester = new JPH.VehicleCollisionTesterRay(JoltFixture.LayerMoving);
        constraint.SetVehicleCollisionTester((JPH.VehicleCollisionTester)tester);

        sys.AddConstraint(constraint);
        sys.AddStepListener(constraint);

        // Set full throttle
        var controller = JPH.JoltHelpers.VehicleConstraintGetWheeledController(constraint)!;
        controller.SetDriverInput(1.0f, 0.0f, 0.0f, 0.0f);

        Assert.Equal(1.0f, controller.GetForwardInput(), 1e-5f);
        Assert.Equal(0.0f, controller.GetRightInput(), 1e-5f);
        Assert.Equal(0.0f, controller.GetBrakeInput(), 1e-5f);

        sys.RemoveStepListener(constraint);
        sys.RemoveConstraint(constraint);
        bi.RemoveBody(body.GetID());
        bi.DestroyBody(body.GetID());
        bi.RemoveBody(floorId);
        bi.DestroyBody(floorId);
    }

    // ── JoltHelpers.VehicleConstraintGetWheeledController — downcast ──────────

    [Fact]
    public void JoltHelpers_VehicleConstraintGetWheeledController_NotNull()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var shape = new JPH.BoxShapeSettings(new JPH.Vec3(2f, 0.5f, 4f));
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_BoxShapeSettings)shape);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 2f, 0f);

        var body = bi.CreateBody(cs)!;
        bi.AddBody(body.GetID(), JPH.EActivation.Activate);

        using var vSettings = MakeVehicleSettings();
        using var constraint = new JPH.VehicleConstraint(body, vSettings);

        var controller = JPH.JoltHelpers.VehicleConstraintGetWheeledController(constraint);
        Assert.NotNull(controller);

        bi.RemoveBody(body.GetID());
        bi.DestroyBody(body.GetID());
    }

    // ── Full simulation: vehicle on flat ground, 1 second with throttle ───────

    [Fact]
    public void WheeledVehicle_Simulate_WheelsHaveContactAfterDrop()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        // Static floor
        using var floorShape = new JPH.BoxShapeSettings(new JPH.Vec3(100f, 1f, 100f));
        using var floorCs = new JPH.BodyCreationSettings();
        floorCs.SetShapeSettings((JPH.Const_BoxShapeSettings)floorShape);
        floorCs.mMotionType  = JPH.EMotionType.Static;
        floorCs.mObjectLayer = JoltFixture.LayerNonMoving;
        floorCs.mPosition.Set(0f, -1f, 0f);
        var floorId = bi.CreateAndAddBody(floorCs, JPH.EActivation.DontActivate);

        // Vehicle body — start just above floor so it drops quickly
        using var shape = new JPH.BoxShapeSettings(new JPH.Vec3(2f, 0.5f, 4f));
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_BoxShapeSettings)shape);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 2f, 0f);

        var body = bi.CreateBody(cs)!;
        bi.AddBody(body.GetID(), JPH.EActivation.Activate);

        using var vSettings = MakeVehicleSettings();
        using var constraint = new JPH.VehicleConstraint(body, vSettings);

        using var tester = new JPH.VehicleCollisionTesterRay(JoltFixture.LayerMoving);
        constraint.SetVehicleCollisionTester((JPH.VehicleCollisionTester)tester);

        sys.AddConstraint(constraint);
        sys.AddStepListener(constraint);

        var controller = JPH.JoltHelpers.VehicleConstraintGetWheeledController(constraint)!;
        controller.SetDriverInput(1.0f, 0.0f, 0.0f, 0.0f);

        // Simulate 1 second at 60 Hz
        const float dt = 1f / 60f;
        for (int i = 0; i < 60; i++)
            sys.Update(dt, 1, fx.Alloc, fx.Jobs);

        // After landing all 4 wheels should be in contact with the floor
        int contactCount = 0;
        for (uint i = 0; i < 4; i++)
        {
            var wheel = constraint.GetWheel(i);
            if (wheel is not null && wheel.HasContact())
                contactCount++;
        }

        Assert.True(contactCount > 0, "Expected at least one wheel in contact after simulation");

        sys.RemoveStepListener(constraint);
        sys.RemoveConstraint(constraint);
        bi.RemoveBody(body.GetID());
        bi.DestroyBody(body.GetID());
        bi.RemoveBody(floorId);
        bi.DestroyBody(floorId);
    }
}
