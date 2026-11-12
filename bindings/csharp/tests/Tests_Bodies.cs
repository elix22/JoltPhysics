// Body-level tests: BodyInterface API, activation state, velocity, friction,
// restitution, sensors, and body ID management.
// Modelled on Jolt's BodyTests.cpp and SensorTests.cpp.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Bodies(JoltFixture fx)
{
    // ── IsActive ──────────────────────────────────────────────────────────────

    [Fact]
    public void Body_StaticBody_IsNotActive()
    {
        using var sys  = fx.MakePhysicsSystem();
        var       bi   = sys.GetBodyInterface();

        using var shape = new JPH.BoxShapeSettings(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        using var bcs   = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)shape, new JPH.Vec3(0f, 0f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);

        JPH.BodyID id = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        try
        {
            Assert.False(bi.IsActive(id));
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }

    [Fact]
    public void Body_DynamicBody_IsActiveAfterActivate()
    {
        using var sys = fx.MakePhysicsSystem();
        var       bi  = sys.GetBodyInterface();

        using var shape = new JPH.SphereShapeSettings(0.5f);
        using var bcs   = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)shape, new JPH.Vec3(0f, 10f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);

        JPH.BodyID id = bi.CreateAndAddBody(bcs, JPH.EActivation.Activate);
        try
        {
            Assert.True(bi.IsActive(id));
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }

    // ── DeactivateBody / ActivateBody ─────────────────────────────────────────

    [Fact]
    public void Body_DeactivateThenActivate_TogglesActiveState()
    {
        using var sys = fx.MakePhysicsSystem();
        var       bi  = sys.GetBodyInterface();

        using var shape = new JPH.SphereShapeSettings(0.5f);
        using var bcs   = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)shape, new JPH.Vec3(0f, 10f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);

        JPH.BodyID id = bi.CreateAndAddBody(bcs, JPH.EActivation.Activate);
        try
        {
            Assert.True(bi.IsActive(id));
            bi.DeactivateBody(id);
            Assert.False(bi.IsActive(id));
            bi.ActivateBody(id);
            Assert.True(bi.IsActive(id));
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }

    // ── GetPosition / GetCenterOfMassPosition ─────────────────────────────────

    [Fact]
    public void Body_GetPosition_MatchesCreationPosition()
    {
        using var sys = fx.MakePhysicsSystem();
        var       bi  = sys.GetBodyInterface();

        using var shape = new JPH.BoxShapeSettings(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        using var bcs   = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)shape, new JPH.Vec3(3f, -1f, 5f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);

        JPH.BodyID id = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        try
        {
            using var pos = bi.GetPosition(id);
            Assert.Equal(3f,  pos.GetX(), precision: 4);
            Assert.Equal(-1f, pos.GetY(), precision: 4);
            Assert.Equal(5f,  pos.GetZ(), precision: 4);
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }

    [Fact]
    public void Body_CenterOfMass_EqualToPositionForSymmetricShape()
    {
        using var sys = fx.MakePhysicsSystem();
        var       bi  = sys.GetBodyInterface();

        using var shape = new JPH.SphereShapeSettings(1f);
        using var bcs   = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)shape, new JPH.Vec3(0f, 0f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);

        JPH.BodyID id = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        try
        {
            using var pos = bi.GetPosition(id);
            using var com = bi.GetCenterOfMassPosition(id);
            Assert.Equal(pos.GetX(), com.GetX(), precision: 4);
            Assert.Equal(pos.GetY(), com.GetY(), precision: 4);
            Assert.Equal(pos.GetZ(), com.GetZ(), precision: 4);
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }

    // ── Linear / angular velocity ─────────────────────────────────────────────

    [Fact]
    public void Body_SetLinearVelocity_GetLinearVelocity_RoundTrip()
    {
        using var sys = fx.MakePhysicsSystem();
        var       bi  = sys.GetBodyInterface();

        using var shape = new JPH.SphereShapeSettings(0.5f);
        using var bcs   = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)shape, new JPH.Vec3(0f, 0f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);

        JPH.BodyID id = bi.CreateAndAddBody(bcs, JPH.EActivation.Activate);
        try
        {
            using var vel = new JPH.Vec3(1f, 2f, 3f);
            bi.SetLinearVelocity(id, vel);
            using var got = bi.GetLinearVelocity(id);
            Assert.Equal(1f, got.GetX(), precision: 4);
            Assert.Equal(2f, got.GetY(), precision: 4);
            Assert.Equal(3f, got.GetZ(), precision: 4);
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }

    [Fact]
    public void Body_SetAngularVelocity_GetAngularVelocity_RoundTrip()
    {
        using var sys = fx.MakePhysicsSystem();
        var       bi  = sys.GetBodyInterface();

        using var shape = new JPH.BoxShapeSettings(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        using var bcs   = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)shape, new JPH.Vec3(0f, 0f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);

        JPH.BodyID id = bi.CreateAndAddBody(bcs, JPH.EActivation.Activate);
        try
        {
            using var angVel = new JPH.Vec3(0f, 1f, 0f);
            bi.SetAngularVelocity(id, angVel);
            using var got = bi.GetAngularVelocity(id);
            Assert.Equal(0f, got.GetX(), precision: 4);
            Assert.Equal(1f, got.GetY(), precision: 4);
            Assert.Equal(0f, got.GetZ(), precision: 4);
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }

    [Fact]
    public void Body_ZeroLinearVelocity_AfterDeactivate()
    {
        using var sys = fx.MakePhysicsSystem();
        var       bi  = sys.GetBodyInterface();

        using var shape = new JPH.SphereShapeSettings(0.5f);
        using var bcs   = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)shape, new JPH.Vec3(0f, 0f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);

        JPH.BodyID id = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        try
        {
            using var vel = bi.GetLinearVelocity(id);
            Assert.Equal(0f, vel.GetX(), precision: 6);
            Assert.Equal(0f, vel.GetY(), precision: 6);
            Assert.Equal(0f, vel.GetZ(), precision: 6);
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }

    // ── Friction / Restitution ────────────────────────────────────────────────

    [Fact]
    public void Body_SetFriction_GetFriction_RoundTrip()
    {
        using var sys = fx.MakePhysicsSystem();
        var       bi  = sys.GetBodyInterface();

        using var shape = new JPH.BoxShapeSettings(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        using var bcs   = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)shape, new JPH.Vec3(0f, 0f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);

        JPH.BodyID id = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        try
        {
            bi.SetFriction(id, 0.75f);
            Assert.Equal(0.75f, bi.GetFriction(id), precision: 5);
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }

    [Fact]
    public void Body_SetRestitution_GetRestitution_RoundTrip()
    {
        using var sys = fx.MakePhysicsSystem();
        var       bi  = sys.GetBodyInterface();

        using var shape = new JPH.SphereShapeSettings(0.5f);
        using var bcs   = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)shape, new JPH.Vec3(0f, 0f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);

        JPH.BodyID id = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        try
        {
            bi.SetRestitution(id, 0.3f);
            Assert.Equal(0.3f, bi.GetRestitution(id), precision: 5);
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }

    // ── Sensor body ───────────────────────────────────────────────────────────

    [Fact]
    public void Body_SensorBody_DoesNotBlockDynamicBody()
    {
        // A sensor should not physically block a dynamic body falling through it.
        using var sys = fx.MakePhysicsSystem();
        var       bi  = sys.GetBodyInterface();

        // Large sensor box at origin
        using var sensorShape = new JPH.BoxShapeSettings(new JPH.Vec3(5f, 5f, 5f));
        using var sensorBcs   = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)sensorShape, new JPH.Vec3(0f, 0f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);
        sensorBcs.mIsSensor = true;
        JPH.BodyID sensorId = bi.CreateAndAddBody(sensorBcs, JPH.EActivation.DontActivate);

        // Dynamic sphere that starts just above the sensor centre
        using var dynShape = new JPH.SphereShapeSettings(0.2f);
        using var dynBcs   = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)dynShape, new JPH.Vec3(0f, 3f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);
        JPH.BodyID dynId = bi.CreateAndAddBody(dynBcs, JPH.EActivation.Activate);

        try
        {
            // Simulate 60 steps at 1/60 s
            for (int i = 0; i < 60; i++)
                sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

            // Dynamic body should have fallen well below its starting position
            using var pos = bi.GetPosition(dynId);
            Assert.True(pos.GetY() < 2.5f, $"Body Y={pos.GetY()} — expected it to fall through the sensor");
        }
        finally
        {
            bi.RemoveBody(sensorId);
            bi.DestroyBody(sensorId);
            bi.RemoveBody(dynId);
            bi.DestroyBody(dynId);
        }
    }

    // ── BodyID validity ───────────────────────────────────────────────────────

    [Fact]
    public void BodyID_InvalidID_IsInvalid()
    {
        var id = new JPH.BodyID();
        Assert.True(id.IsInvalid());
    }

    [Fact]
    public void BodyID_CreatedBody_NotInvalid()
    {
        using var sys = fx.MakePhysicsSystem();
        var       bi  = sys.GetBodyInterface();

        using var shape = new JPH.SphereShapeSettings(0.5f);
        using var bcs   = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)shape, new JPH.Vec3(0f, 0f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);

        JPH.BodyID id = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        try
        {
            Assert.False(id.IsInvalid());
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }

    // ── Gravity ───────────────────────────────────────────────────────────────

    [Fact]
    public void PhysicsSystem_SetGravity_GetGravity_RoundTrip()
    {
        using var sys   = fx.MakePhysicsSystem();
        using var newG  = new JPH.Vec3(0f, -20f, 0f);
        sys.SetGravity(newG);
        using var got = sys.GetGravity();
        Assert.Equal(0f,   got.GetX(), precision: 5);
        Assert.Equal(-20f, got.GetY(), precision: 5);
        Assert.Equal(0f,   got.GetZ(), precision: 5);
    }

    [Fact]
    public void PhysicsSystem_DefaultGravity_IsDownward()
    {
        using var sys = fx.MakePhysicsSystem();
        using var g   = sys.GetGravity();
        Assert.True(g.GetY() < 0f, "Default gravity should be downward (negative Y)");
    }

    // ── GetLinearAndAngularVelocity ───────────────────────────────────────────

    [Fact]
    public void Body_GetLinearAndAngularVelocity_MatchesSetCall()
    {
        using var sys = fx.MakePhysicsSystem();
        var       bi  = sys.GetBodyInterface();

        using var shape = new JPH.SphereShapeSettings(0.5f);
        using var bcs   = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)shape, new JPH.Vec3(0f, 0f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);

        JPH.BodyID id = bi.CreateAndAddBody(bcs, JPH.EActivation.Activate);
        try
        {
            using var linVel = new JPH.Vec3(4f, 5f, 6f);
            using var angVel = new JPH.Vec3(0.1f, 0.2f, 0.3f);
            bi.SetLinearAndAngularVelocity(id, linVel, angVel);

            using var outLin = JPH.Vec3.SZero();
            using var outAng = JPH.Vec3.SZero();
            bi.GetLinearAndAngularVelocity(id, outLin, outAng);

            Assert.Equal(4f, outLin.GetX(), precision: 4);
            Assert.Equal(5f, outLin.GetY(), precision: 4);
            Assert.Equal(6f, outLin.GetZ(), precision: 4);

            Assert.Equal(0.1f, outAng.GetX(), precision: 4);
            Assert.Equal(0.2f, outAng.GetY(), precision: 4);
            Assert.Equal(0.3f, outAng.GetZ(), precision: 4);
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }
}
