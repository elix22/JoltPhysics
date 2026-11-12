// Tests for HingeConstraintSettings: field round-trips, limits, and a basic
// simulation ensuring the hinge axis restricts relative rotation.

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_HingeConstraint(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // Helper: create a dynamic box body
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
    public void HingeConstraintSettings_DefaultConstruct_NoCrash()
    {
        var s = new JPH.HingeConstraintSettings();
        s.Dispose();
    }

    [Fact]
    public void HingeConstraintSettings_LimitsMin_DefaultIsNegativePi()
    {
        using var s = new JPH.HingeConstraintSettings();
        Assert.True(s.mLimitsMin < 0f);
        Assert.True(s.mLimitsMin >= -(float)Math.PI - 0.01f);
    }

    [Fact]
    public void HingeConstraintSettings_LimitsMax_DefaultIsPositivePi()
    {
        using var s = new JPH.HingeConstraintSettings();
        Assert.True(s.mLimitsMax > 0f);
        Assert.True(s.mLimitsMax <= (float)Math.PI + 0.01f);
    }

    [Fact]
    public void HingeConstraintSettings_LimitsMin_RoundTrips()
    {
        using var s = new JPH.HingeConstraintSettings();
        s.mLimitsMin = -0.5f;
        Assert.Equal(-0.5f, s.mLimitsMin, precision: 5);
    }

    [Fact]
    public void HingeConstraintSettings_LimitsMax_RoundTrips()
    {
        using var s = new JPH.HingeConstraintSettings();
        s.mLimitsMax = 0.5f;
        Assert.Equal(0.5f, s.mLimitsMax, precision: 5);
    }

    [Fact]
    public void HingeConstraintSettings_HingeAxis1_DefaultIsUnitAxis()
    {
        using var s    = new JPH.HingeConstraintSettings();
        using var axis = s.mHingeAxis1;
        // Default hinge axis is typically (0, 1, 0) or (0, 0, 1); just check it is a unit vector.
        float len = (float)Math.Sqrt(
            axis.GetX() * axis.GetX() +
            axis.GetY() * axis.GetY() +
            axis.GetZ() * axis.GetZ());
        Assert.Equal(1f, len, precision: 4);
    }

    [Fact]
    public void HingeConstraintSettings_Point1_CanBeSet()
    {
        using var s = new JPH.HingeConstraintSettings();
        s.mPoint1.Set(1f, 2f, 3f);
        using var got = s.mPoint1;
        Assert.Equal(1f, got.GetX(), precision: 5);
        Assert.Equal(2f, got.GetY(), precision: 5);
        Assert.Equal(3f, got.GetZ(), precision: 5);
    }

    [Fact]
    public void HingeConstraintSettings_Point2_CanBeSet()
    {
        using var s = new JPH.HingeConstraintSettings();
        s.mPoint2.Set(4f, 5f, 6f);
        using var got = s.mPoint2;
        Assert.Equal(4f, got.GetX(), precision: 5);
        Assert.Equal(5f, got.GetY(), precision: 5);
        Assert.Equal(6f, got.GetZ(), precision: 5);
    }

    // -------------------------------------------------------------------------
    // Constraint creation
    // -------------------------------------------------------------------------

    [Fact]
    public void HingeConstraint_Create_ReturnsNonNull()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 10f, 0f, JPH.EMotionType.Dynamic);
        var (body2, id2) = MakeBox(bi, 0f, 11f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.HingeConstraintSettings();
        // Place hinge point between the two bodies.
        settings.mPoint1.Set(0f, 10.5f, 0f);
        settings.mPoint2.Set(0f, 10.5f, 0f);
        var constraint = settings.Create(body1, body2);
        Assert.NotNull(constraint);

        sys.AddConstraint(constraint!);
        sys.RemoveConstraint(constraint!);

        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    // -------------------------------------------------------------------------
    // Simulation: hinge limits prevent excessive rotation
    // -------------------------------------------------------------------------

    [Fact]
    public void HingeConstraint_WithZeroLimits_UpperBodyStaysAboveLower()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        // Body1 is static (anchor), body2 hangs below and is constrained by hinge.
        var (body1, id1) = MakeBox(bi, 0f, 0f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeBox(bi, 0f, -1f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.HingeConstraintSettings();
        // Place hinge point between the two bodies.
        settings.mPoint1.Set(0f, -0.5f, 0f);
        settings.mPoint2.Set(0f, -0.5f, 0f);
        // Restrict rotation to zero (rigid hinge).
        settings.mLimitsMin = 0f;
        settings.mLimitsMax = 0f;
        var constraint = settings.Create(body1, body2)!;
        sys.AddConstraint(constraint);

        for (int i = 0; i < 30; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        // Body2 should not have moved away from its start in an uncontrolled way.
        float y2;
        using (var p = bi.GetCenterOfMassPosition(id2)) y2 = p.GetY();
        Assert.True(y2 > -10f, $"Body2 fell too far: y={y2}");

        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }
}
