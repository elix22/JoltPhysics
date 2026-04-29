// Physics simulation tests: gravity, collision, body creation/removal.
// Each test uses its own PhysicsSystem to stay independent.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Physics(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // Body creation helpers
    // -------------------------------------------------------------------------

    private static JPH.BodyID AddSphere(JPH.BodyInterface bi, float radius,
        float x, float y, float z, JPH.EMotionType motion)
    {
        using var ss = new JPH.SphereShapeSettings();
        ss.mRadius = radius;
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        cs.mMotionType  = motion;
        cs.mObjectLayer = motion == JPH.EMotionType.Static
            ? JoltFixture.LayerNonMoving
            : JoltFixture.LayerMoving;
        cs.mPosition.Set(x, y, z);
        var activation = motion == JPH.EMotionType.Static
            ? JPH.EActivation.DontActivate
            : JPH.EActivation.Activate;
        return bi.CreateAndAddBody(cs, activation);
    }

    private static JPH.BodyID AddBox(JPH.BodyInterface bi, float hx, float hy, float hz,
        float x, float y, float z, JPH.EMotionType motion)
    {
        using var ss = new JPH.BoxShapeSettings(new JPH.Vec3(hx, hy, hz));
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_BoxShapeSettings)ss);
        cs.mMotionType  = motion;
        cs.mObjectLayer = motion == JPH.EMotionType.Static
            ? JoltFixture.LayerNonMoving
            : JoltFixture.LayerMoving;
        cs.mPosition.Set(x, y, z);
        var activation = motion == JPH.EMotionType.Static
            ? JPH.EActivation.DontActivate
            : JPH.EActivation.Activate;
        return bi.CreateAndAddBody(cs, activation);
    }

    // -------------------------------------------------------------------------
    // Basic body management
    // -------------------------------------------------------------------------

    [Fact]
    public void CreateAndAddBody_ValidId_NotInvalid()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddSphere(bi, 0.5f, 0f, 5f, 0f, JPH.EMotionType.Dynamic);
        Assert.False(id.IsInvalid());
        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void CreateBody_StaticAndDynamic_BothValid()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var floor  = AddBox(bi, 50f, 1f, 50f, 0f, -1f, 0f, JPH.EMotionType.Static);
        var sphere = AddSphere(bi, 0.5f, 0f, 5f, 0f, JPH.EMotionType.Dynamic);
        Assert.False(floor.IsInvalid());
        Assert.False(sphere.IsInvalid());
        bi.RemoveBody(sphere); bi.DestroyBody(sphere);
        bi.RemoveBody(floor);  bi.DestroyBody(floor);
    }

    [Fact]
    public void GetNumBodies_AfterAddingTwoBodies_IsTwo()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();
        var id1 = AddSphere(bi, 0.5f, 0f,  5f, 0f, JPH.EMotionType.Dynamic);
        var id2 = AddSphere(bi, 0.5f, 2f, 10f, 0f, JPH.EMotionType.Dynamic);
        Assert.Equal(2u, sys.GetNumBodies());
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void DestroyBody_DecrementsBodyCount()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddSphere(bi, 0.5f, 0f, 5f, 0f, JPH.EMotionType.Dynamic);
        Assert.Equal(1u, sys.GetNumBodies());
        bi.RemoveBody(id);
        bi.DestroyBody(id);
        Assert.Equal(0u, sys.GetNumBodies());
    }

    // -------------------------------------------------------------------------
    // Gravity / simulation correctness
    // -------------------------------------------------------------------------

    [Fact]
    public void SimulateGravity_SphereFalls_YDecreases()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        var id = AddSphere(bi, 0.5f, 0f, 20f, 0f, JPH.EMotionType.Dynamic);

        float yStart;
        using (var p = bi.GetCenterOfMassPosition(id)) yStart = p.GetY();

        // Simulate 60 steps (1 second at 60 Hz).
        for (int i = 0; i < 60; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        float yEnd;
        using (var p = bi.GetCenterOfMassPosition(id)) yEnd = p.GetY();

        Assert.True(yEnd < yStart, $"Expected y to decrease under gravity. yStart={yStart}, yEnd={yEnd}");

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    [Fact]
    public void SimulateGravity_ApproximatelyMatchesKinematics()
    {
        // s = s0 + v0*t - 0.5*g*t^2 with g=9.81, v0=0, t=1s
        const float g     = 9.81f;
        const float t     = 1.0f;
        const float yInit = 20.0f;

        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        var id = AddSphere(bi, 0.5f, 0f, yInit, 0f, JPH.EMotionType.Dynamic);

        int   steps = (int)(t * 60);
        float dt    = t / steps;
        for (int i = 0; i < steps; i++)
            sys.Update(dt, 1, fx.Alloc, fx.Jobs);

        float yExpected = yInit - 0.5f * g * t * t;  // ≈ 15.095
        float yActual;
        using (var p = bi.GetCenterOfMassPosition(id)) yActual = p.GetY();

        Assert.InRange(yActual, yExpected - 0.5f, yExpected + 0.5f);

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    [Fact]
    public void SphereOnGround_EventuallyComesToRest()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        var floor  = AddBox(bi,  50f, 1f, 50f,  0f, -1f, 0f, JPH.EMotionType.Static);
        var sphere = AddSphere(bi, 0.5f,  0f,  5f, 0f, JPH.EMotionType.Dynamic);

        // Simulate 5 seconds.
        for (int i = 0; i < 300; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        bool active = bi.IsActive(sphere);
        Assert.False(active, "Sphere should have come to rest on the ground.");

        bi.RemoveBody(sphere); bi.DestroyBody(sphere);
        bi.RemoveBody(floor);  bi.DestroyBody(floor);
    }

    // -------------------------------------------------------------------------
    // Body properties
    // -------------------------------------------------------------------------

    [Fact]
    public void SetLinearVelocity_IsReflectedByGetLinearVelocity()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        var id = AddSphere(bi, 0.5f, 0f, 5f, 0f, JPH.EMotionType.Dynamic);
        using var vel = new JPH.Vec3(1f, 0f, 0f);
        bi.SetLinearVelocity(id, vel);

        using var got = bi.GetLinearVelocity(id);
        Assert.Equal(1f, got.GetX(), precision: 4);
        Assert.Equal(0f, got.GetY(), precision: 4);

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    [Fact]
    public void SetPosition_IsReflectedByCenterOfMassPosition()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        var id = AddSphere(bi, 0.5f, 0f, 0f, 0f, JPH.EMotionType.Dynamic);
        using var pos = new JPH.Vec3(3f, 7f, -2f);
        bi.SetPositionAndRotationWhenChanged(id, pos, new JPH.Quat(), JPH.EActivation.DontActivate);

        using var got = bi.GetCenterOfMassPosition(id);
        Assert.Equal(3f,  got.GetX(), precision: 2);
        Assert.Equal(7f,  got.GetY(), precision: 2);
        Assert.Equal(-2f, got.GetZ(), precision: 2);

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    // -------------------------------------------------------------------------
    // Many bodies stress test
    // -------------------------------------------------------------------------

    [Fact]
    public void CreateManyBodies_SimulateAndDestroy_NoCorruption()
    {
        using var sys = fx.MakePhysicsSystem(2048);
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        const int N = 50;
        var ids = new JPH.BodyID[N];
        for (int i = 0; i < N; i++)
        {
            float x = (i % 10) * 2f - 9f;
            float z = (i / 10) * 2f - 4f;
            ids[i] = AddSphere(bi, 0.4f, x, 10f + i * 0.1f, z, JPH.EMotionType.Dynamic);
        }

        Assert.Equal((uint)N, sys.GetNumBodies());

        for (int step = 0; step < 30; step++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        foreach (var id in ids)
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }

        Assert.Equal(0u, sys.GetNumBodies());
    }
}
