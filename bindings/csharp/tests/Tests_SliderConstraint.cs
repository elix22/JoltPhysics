// Tests for SliderConstraintSettings and SliderConstraint:
// field round-trips, limits, and a basic simulation.

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_SliderConstraint(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // Helper: create a box body
    // -------------------------------------------------------------------------

    private static (JPH.Body body, JPH.BodyID id) MakeBox(
        JPH.BodyInterface bi,
        float x, float y, float z,
        JPH.EMotionType motion)
    {
        using var ss = new JPH.BoxShapeSettings(new JPH.Vec3(0.5f, 0.5f, 0.5f));
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
        var body = bi.CreateBody(cs)!;
        var id   = body.GetID();
        bi.AddBody(id, activation);
        return (body, id);
    }

    // -------------------------------------------------------------------------
    // Settings lifecycle
    // -------------------------------------------------------------------------

    [Fact]
    public void SliderConstraintSettings_DefaultConstruct_NoCrash()
    {
        var s = new JPH.SliderConstraintSettings();
        s.Dispose();
    }

    [Fact]
    public void SliderConstraintSettings_LimitsMin_DefaultIsNegativeInfinity()
    {
        using var s = new JPH.SliderConstraintSettings();
        Assert.True(float.IsNegativeInfinity(s.mLimitsMin) || s.mLimitsMin < -1e30f);
    }

    [Fact]
    public void SliderConstraintSettings_LimitsMax_DefaultIsPositiveInfinity()
    {
        using var s = new JPH.SliderConstraintSettings();
        Assert.True(float.IsPositiveInfinity(s.mLimitsMax) || s.mLimitsMax > 1e30f);
    }

    [Fact]
    public void SliderConstraintSettings_LimitsMin_RoundTrips()
    {
        using var s = new JPH.SliderConstraintSettings();
        s.mLimitsMin = -2.5f;
        Assert.Equal(-2.5f, s.mLimitsMin, precision: 5);
    }

    [Fact]
    public void SliderConstraintSettings_LimitsMax_RoundTrips()
    {
        using var s = new JPH.SliderConstraintSettings();
        s.mLimitsMax = 3.0f;
        Assert.Equal(3.0f, s.mLimitsMax, precision: 5);
    }

    [Fact]
    public void SliderConstraintSettings_MaxFrictionForce_DefaultIsZero()
    {
        using var s = new JPH.SliderConstraintSettings();
        Assert.Equal(0f, s.mMaxFrictionForce, precision: 5);
    }

    [Fact]
    public void SliderConstraintSettings_MaxFrictionForce_RoundTrips()
    {
        using var s = new JPH.SliderConstraintSettings();
        s.mMaxFrictionForce = 10f;
        Assert.Equal(10f, s.mMaxFrictionForce, precision: 5);
    }

    [Fact]
    public void SliderConstraintSettings_AutoDetectPoint_DefaultIsFalse()
    {
        using var s = new JPH.SliderConstraintSettings();
        Assert.False(s.mAutoDetectPoint);
    }

    [Fact]
    public void SliderConstraintSettings_SliderAxis1_DefaultIsUnitVector()
    {
        using var s    = new JPH.SliderConstraintSettings();
        using var axis = s.mSliderAxis1;
        float len = (float)Math.Sqrt(
            axis.GetX() * axis.GetX() +
            axis.GetY() * axis.GetY() +
            axis.GetZ() * axis.GetZ());
        Assert.Equal(1f, len, precision: 4);
    }

    // -------------------------------------------------------------------------
    // Constraint creation
    // -------------------------------------------------------------------------

    [Fact]
    public void SliderConstraint_Create_ReturnsNonNull()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 0f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeBox(bi, 1f, 0f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.SliderConstraintSettings();
        settings.mAutoDetectPoint = true;
        var constraint = settings.Create(body1, body2);
        Assert.NotNull(constraint);

        sys.AddConstraint(constraint!);
        sys.RemoveConstraint(constraint!);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void SliderConstraint_HasLimits_WhenLimitsSet_IsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 0f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeBox(bi, 1f, 0f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.SliderConstraintSettings();
        settings.mAutoDetectPoint = true;
        settings.mLimitsMin = -1f;
        settings.mLimitsMax =  1f;
        var constraint = new JPH.SliderConstraint(body1, body2, (JPH.Const_SliderConstraintSettings)settings);

        Assert.True(constraint.HasLimits());

        sys.AddConstraint(constraint);
        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void SliderConstraint_GetLimitsMin_ReflectsSettings()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 0f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeBox(bi, 1f, 0f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.SliderConstraintSettings();
        settings.mAutoDetectPoint = true;
        settings.mLimitsMin = -2f;
        settings.mLimitsMax =  2f;
        var constraint = new JPH.SliderConstraint(body1, body2, (JPH.Const_SliderConstraintSettings)settings);

        Assert.Equal(-2f, constraint.GetLimitsMin(), precision: 4);

        sys.AddConstraint(constraint);
        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void SliderConstraint_GetLimitsMax_ReflectsSettings()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 0f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeBox(bi, 1f, 0f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.SliderConstraintSettings();
        settings.mAutoDetectPoint = true;
        settings.mLimitsMin = -2f;
        settings.mLimitsMax =  2f;
        var constraint = new JPH.SliderConstraint(body1, body2, (JPH.Const_SliderConstraintSettings)settings);

        Assert.Equal(2f, constraint.GetLimitsMax(), precision: 4);

        sys.AddConstraint(constraint);
        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    // -------------------------------------------------------------------------
    // Simulation: sliding body respects limits
    // -------------------------------------------------------------------------

    [Fact]
    public void SliderConstraint_DynamicBody_DoesNotCrashUnderSimulation()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        var (body1, id1) = MakeBox(bi, 0f, 0f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeBox(bi, 0f, 2f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.SliderConstraintSettings();
        settings.mAutoDetectPoint = true;
        // Allow sliding 5 units in each direction along the axis.
        settings.mLimitsMin = -5f;
        settings.mLimitsMax =  5f;
        var constraint = settings.Create(body1, body2)!;
        sys.AddConstraint(constraint);

        for (int i = 0; i < 60; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        // Just verify no crash and body is in a sane position.
        float y2;
        using (var p = bi.GetCenterOfMassPosition(id2)) y2 = p.GetY();
        Assert.True(y2 > -10f, $"Body2 fell too far: y={y2}");

        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }
}
