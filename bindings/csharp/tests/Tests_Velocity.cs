// Tests for BodyInterface velocity and material property getters/setters:
// linear and angular velocity, impulse application, friction, restitution,
// max velocity limits, and linear damping.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Velocity(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // Helper: create a dynamic sphere body at the given position
    // -------------------------------------------------------------------------

    private static JPH.BodyID MakeDynamic(
        JPH.BodyInterface bi,
        float x, float y, float z)
    {
        using var ss = new JPH.SphereShapeSettings(0.5f);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(x, y, z);
        return bi.CreateAndAddBody(cs, JPH.EActivation.Activate);
    }

    // -------------------------------------------------------------------------
    // Linear velocity — default, get/set, add
    // -------------------------------------------------------------------------

    [Fact]
    public void DynamicBody_DefaultLinearVelocity_IsZero()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamic(bi, 0f, 10f, 0f);

        using var v = bi.GetLinearVelocity(id);
        Assert.Equal(0f, v.GetX(), precision: 5);
        Assert.Equal(0f, v.GetY(), precision: 5);
        Assert.Equal(0f, v.GetZ(), precision: 5);

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    [Fact]
    public void DynamicBody_SetLinearVelocity_RoundTrips()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamic(bi, 0f, 10f, 0f);

        using var vel = new JPH.Vec3(1f, 2f, 3f);
        bi.SetLinearVelocity(id, vel);

        using var got = bi.GetLinearVelocity(id);
        Assert.Equal(1f, got.GetX(), precision: 4);
        Assert.Equal(2f, got.GetY(), precision: 4);
        Assert.Equal(3f, got.GetZ(), precision: 4);

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    [Fact]
    public void DynamicBody_AddImpulse_ChangesLinearVelocity()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamic(bi, 0f, 10f, 0f);

        // Zero initial velocity.
        using (var v0 = bi.GetLinearVelocity(id))
            Assert.Equal(0f, v0.GetX(), precision: 5);

        // Apply impulse along X.
        using var impulse = new JPH.Vec3(100f, 0f, 0f);
        bi.AddImpulse(id, impulse);

        using var v1 = bi.GetLinearVelocity(id);
        Assert.True(v1.GetX() > 0f, $"Expected positive X velocity after impulse, got {v1.GetX()}");

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    [Fact]
    public void DynamicBody_AddLinearVelocity_IncreasesSpeed()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamic(bi, 0f, 10f, 0f);

        using var vel = new JPH.Vec3(5f, 0f, 0f);
        bi.SetLinearVelocity(id, vel);

        using var delta = new JPH.Vec3(3f, 0f, 0f);
        bi.AddLinearVelocity(id, delta);

        using var got = bi.GetLinearVelocity(id);
        Assert.Equal(8f, got.GetX(), precision: 4);

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    // -------------------------------------------------------------------------
    // Angular velocity — default, get/set
    // -------------------------------------------------------------------------

    [Fact]
    public void DynamicBody_DefaultAngularVelocity_IsZero()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamic(bi, 0f, 10f, 0f);

        using var v = bi.GetAngularVelocity(id);
        Assert.Equal(0f, v.GetX(), precision: 5);
        Assert.Equal(0f, v.GetY(), precision: 5);
        Assert.Equal(0f, v.GetZ(), precision: 5);

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    [Fact]
    public void DynamicBody_SetAngularVelocity_RoundTrips()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamic(bi, 0f, 10f, 0f);

        using var omega = new JPH.Vec3(0f, 1f, 0f);
        bi.SetAngularVelocity(id, omega);

        using var got = bi.GetAngularVelocity(id);
        Assert.Equal(0f, got.GetX(), precision: 4);
        Assert.Equal(1f, got.GetY(), precision: 4);
        Assert.Equal(0f, got.GetZ(), precision: 4);

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    // -------------------------------------------------------------------------
    // GetLinearAndAngularVelocity — matches separate getters
    // -------------------------------------------------------------------------

    [Fact]
    public void DynamicBody_GetLinearAndAngularVelocity_MatchesSeparateGetters()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamic(bi, 0f, 10f, 0f);

        using var setLin = new JPH.Vec3(1f, 2f, 3f);
        using var setAng = new JPH.Vec3(0f, 0.5f, 0f);
        bi.SetLinearVelocity(id, setLin);
        bi.SetAngularVelocity(id, setAng);

        using var outLin = new JPH.Vec3(0f, 0f, 0f);
        using var outAng = new JPH.Vec3(0f, 0f, 0f);
        bi.GetLinearAndAngularVelocity(id, outLin, outAng);

        using var getLin = bi.GetLinearVelocity(id);
        using var getAng = bi.GetAngularVelocity(id);

        Assert.Equal(getLin.GetX(), outLin.GetX(), precision: 4);
        Assert.Equal(getLin.GetY(), outLin.GetY(), precision: 4);
        Assert.Equal(getLin.GetZ(), outLin.GetZ(), precision: 4);

        Assert.Equal(getAng.GetX(), outAng.GetX(), precision: 4);
        Assert.Equal(getAng.GetY(), outAng.GetY(), precision: 4);
        Assert.Equal(getAng.GetZ(), outAng.GetZ(), precision: 4);

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    // -------------------------------------------------------------------------
    // Friction — default and round-trip via BodyCreationSettings
    // -------------------------------------------------------------------------

    [Fact]
    public void DynamicBody_DefaultFriction_IsNonNegative()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamic(bi, 0f, 10f, 0f);

        float friction = bi.GetFriction(id);
        Assert.True(friction >= 0f, $"Expected non-negative friction, got {friction}");

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    [Fact]
    public void DynamicBody_CustomFriction_RoundTripsViaBodyCreationSettings()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();

        using var ss = new JPH.SphereShapeSettings(0.5f);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 10f, 0f);
        cs.mFriction    = 0.75f;
        var id = bi.CreateAndAddBody(cs, JPH.EActivation.Activate);

        Assert.Equal(0.75f, bi.GetFriction(id), precision: 5);

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    // -------------------------------------------------------------------------
    // Restitution — default and round-trip via BodyCreationSettings
    // -------------------------------------------------------------------------

    [Fact]
    public void DynamicBody_DefaultRestitution_IsNonNegative()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamic(bi, 0f, 10f, 0f);

        float restitution = bi.GetRestitution(id);
        Assert.True(restitution >= 0f, $"Expected non-negative restitution, got {restitution}");

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    [Fact]
    public void DynamicBody_CustomRestitution_RoundTripsViaBodyCreationSettings()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();

        using var ss = new JPH.SphereShapeSettings(0.5f);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 10f, 0f);
        cs.mRestitution = 0.8f;
        var id = bi.CreateAndAddBody(cs, JPH.EActivation.Activate);

        Assert.Equal(0.8f, bi.GetRestitution(id), precision: 5);

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    // -------------------------------------------------------------------------
    // MaxLinearVelocity — default and round-trip via BodyCreationSettings
    // -------------------------------------------------------------------------

    [Fact]
    public void DynamicBody_DefaultMaxLinearVelocity_IsLargePositive()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamic(bi, 0f, 10f, 0f);

        float maxV = bi.GetMaxLinearVelocity(id);
        Assert.True(maxV > 0f, $"Expected positive max linear velocity, got {maxV}");

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    [Fact]
    public void DynamicBody_CustomMaxLinearVelocity_RoundTripsViaBodyCreationSettings()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();

        using var ss = new JPH.SphereShapeSettings(0.5f);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        cs.mMotionType        = JPH.EMotionType.Dynamic;
        cs.mObjectLayer       = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 10f, 0f);
        cs.mMaxLinearVelocity = 10.0f;
        var id = bi.CreateAndAddBody(cs, JPH.EActivation.Activate);

        Assert.Equal(10.0f, bi.GetMaxLinearVelocity(id), precision: 5);

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    // -------------------------------------------------------------------------
    // Body moves when given an initial velocity
    // -------------------------------------------------------------------------

    [Fact]
    public void DynamicBody_WithInitialVelocity_MovesInThatDirection()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        var id = MakeDynamic(bi, 0f, 100f, 0f);   // high up so no ground contact

        using var vel = new JPH.Vec3(10f, 0f, 0f);
        bi.SetLinearVelocity(id, vel);

        // Simulate 1 second.
        for (int i = 0; i < 60; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        using var pos = bi.GetPosition(id);
        Assert.True(pos.GetX() > 5f, $"Expected body to have moved in X, got X={pos.GetX():F3}");

        bi.RemoveBody(id); bi.DestroyBody(id);
    }
}
