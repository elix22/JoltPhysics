// Tests for DistanceConstraintSettings field round-trips and DistanceConstraint
// direct construction, GetMinDistance/MaxDistance, SetDistance, SetEnabled,
// and lambda accumulation after simulation.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_DistanceConstraint(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // Helper: create a sphere body
    // -------------------------------------------------------------------------

    private static (JPH.Body body, JPH.BodyID id) MakeSphere(
        JPH.BodyInterface bi,
        float x, float y, float z,
        JPH.EMotionType motion)
    {
        using var ss = new JPH.SphereShapeSettings(0.5f);
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
        var body = bi.CreateBody(cs)!;
        var id   = body.GetID();
        bi.AddBody(id, activation);
        return (body, id);
    }

    // -------------------------------------------------------------------------
    // DistanceConstraintSettings — defaults
    // -------------------------------------------------------------------------

    [Fact]
    public void DistanceConstraintSettings_MinDistance_DefaultIsNegativeOne()
    {
        using var s = new JPH.DistanceConstraintSettings();
        Assert.Equal(-1f, s.mMinDistance, precision: 5);
    }

    [Fact]
    public void DistanceConstraintSettings_MaxDistance_DefaultIsNegativeOne()
    {
        using var s = new JPH.DistanceConstraintSettings();
        Assert.Equal(-1f, s.mMaxDistance, precision: 5);
    }

    [Fact]
    public void DistanceConstraintSettings_MinDistance_RoundTrips()
    {
        using var s = new JPH.DistanceConstraintSettings();
        s.mMinDistance = 0.5f;
        Assert.Equal(0.5f, s.mMinDistance, precision: 5);
    }

    [Fact]
    public void DistanceConstraintSettings_MaxDistance_RoundTrips()
    {
        using var s = new JPH.DistanceConstraintSettings();
        s.mMaxDistance = 3.0f;
        Assert.Equal(3.0f, s.mMaxDistance, precision: 5);
    }

    [Fact]
    public void DistanceConstraintSettings_Enabled_DefaultIsTrue()
    {
        using var s = new JPH.DistanceConstraintSettings();
        Assert.True(s.mEnabled);
    }

    [Fact]
    public void DistanceConstraintSettings_ConstraintPriority_DefaultIsZero()
    {
        using var s = new JPH.DistanceConstraintSettings();
        Assert.Equal(0u, s.mConstraintPriority);
    }

    // -------------------------------------------------------------------------
    // DistanceConstraint — direct construction and getter methods
    // -------------------------------------------------------------------------

    [Fact]
    public void DistanceConstraint_DirectConstruct_GetMinDistance_MatchesSettings()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeSphere(bi, 0f, 10f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeSphere(bi, 0f,  8f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.DistanceConstraintSettings();
        settings.mMinDistance = 1.0f;
        settings.mMaxDistance = 4.0f;
        var constraint = new JPH.DistanceConstraint(body1, body2, (JPH.Const_DistanceConstraintSettings)settings);

        Assert.Equal(1.0f, constraint.GetMinDistance(), precision: 5);

        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void DistanceConstraint_DirectConstruct_GetMaxDistance_MatchesSettings()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeSphere(bi, 0f, 10f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeSphere(bi, 0f,  8f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.DistanceConstraintSettings();
        settings.mMinDistance = 1.0f;
        settings.mMaxDistance = 4.0f;
        var constraint = new JPH.DistanceConstraint(body1, body2, (JPH.Const_DistanceConstraintSettings)settings);

        Assert.Equal(4.0f, constraint.GetMaxDistance(), precision: 5);

        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void DistanceConstraint_GetBody1_IsNotNull()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeSphere(bi, 0f, 10f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeSphere(bi, 0f,  8f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.DistanceConstraintSettings();
        var constraint = new JPH.DistanceConstraint(body1, body2, (JPH.Const_DistanceConstraintSettings)settings);

        Assert.NotNull(constraint.GetBody1());

        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void DistanceConstraint_GetBody2_IsNotNull()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeSphere(bi, 0f, 10f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeSphere(bi, 0f,  8f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.DistanceConstraintSettings();
        var constraint = new JPH.DistanceConstraint(body1, body2, (JPH.Const_DistanceConstraintSettings)settings);

        Assert.NotNull(constraint.GetBody2());

        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    // -------------------------------------------------------------------------
    // DistanceConstraint — SetDistance
    // -------------------------------------------------------------------------

    [Fact]
    public void DistanceConstraint_SetDistance_ChangesMinDistance()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeSphere(bi, 0f, 10f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeSphere(bi, 0f,  8f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.DistanceConstraintSettings();
        settings.mMinDistance = 0.0f;
        settings.mMaxDistance = 5.0f;
        var constraint = new JPH.DistanceConstraint(body1, body2, (JPH.Const_DistanceConstraintSettings)settings);

        constraint.SetDistance(0.5f, 3.0f);
        Assert.Equal(0.5f, constraint.GetMinDistance(), precision: 5);

        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void DistanceConstraint_SetDistance_ChangesMaxDistance()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeSphere(bi, 0f, 10f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeSphere(bi, 0f,  8f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.DistanceConstraintSettings();
        settings.mMinDistance = 0.0f;
        settings.mMaxDistance = 5.0f;
        var constraint = new JPH.DistanceConstraint(body1, body2, (JPH.Const_DistanceConstraintSettings)settings);

        constraint.SetDistance(0.5f, 3.0f);
        Assert.Equal(3.0f, constraint.GetMaxDistance(), precision: 5);

        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    // -------------------------------------------------------------------------
    // DistanceConstraint — GetEnabled / SetEnabled
    // -------------------------------------------------------------------------

    [Fact]
    public void DistanceConstraint_GetEnabled_DefaultIsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeSphere(bi, 0f, 10f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeSphere(bi, 0f,  8f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.DistanceConstraintSettings();
        var constraint = new JPH.DistanceConstraint(body1, body2, (JPH.Const_DistanceConstraintSettings)settings);

        Assert.True(constraint.GetEnabled());

        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void DistanceConstraint_SetEnabled_False_GetEnabled_ReturnsFalse()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeSphere(bi, 0f, 10f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeSphere(bi, 0f,  8f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.DistanceConstraintSettings();
        var constraint = new JPH.DistanceConstraint(body1, body2, (JPH.Const_DistanceConstraintSettings)settings);

        constraint.SetEnabled(false);
        Assert.False(constraint.GetEnabled());

        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    // -------------------------------------------------------------------------
    // DistanceConstraint — lambda after simulation
    // -------------------------------------------------------------------------

    [Fact]
    public void DistanceConstraint_AfterSim_AtMaxDistance_LambdaIsNonZero()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        // Static anchor; dynamic ball hangs 2 m below. Rope length = 2 m so
        // the rope is immediately taut and the constraint must apply a force.
        var (body1, id1) = MakeSphere(bi, 0f, 10f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeSphere(bi, 0f,  8f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.DistanceConstraintSettings();
        settings.mMinDistance = 0.0f;
        settings.mMaxDistance = 2.0f;   // ball starts exactly at max — will be pulled taut
        var constraint = new JPH.DistanceConstraint(body1, body2, (JPH.Const_DistanceConstraintSettings)settings);
        sys.AddConstraint((JPH.Constraint)constraint);

        for (int i = 0; i < 30; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        float lambda = constraint.GetTotalLambdaPosition();
        Assert.True(lambda != 0f, $"Expected non-zero lambda after simulation, got {lambda}");

        sys.RemoveConstraint((JPH.Constraint)constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }
}
