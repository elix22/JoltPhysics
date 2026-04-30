// Tests for PointConstraintSettings: field round-trips, and a basic simulation
// verifying that a point constraint keeps two bodies at the same point.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_PointConstraint(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // Helper
    // -------------------------------------------------------------------------

    private static (JPH.Body body, JPH.BodyID id) MakeSphere(
        JPH.BodyInterface bi,
        float x, float y, float z,
        JPH.EMotionType motion)
    {
        using var ss = new JPH.SphereShapeSettings();
        ss.mRadius = 0.5f;
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
    // Settings lifecycle
    // -------------------------------------------------------------------------

    [Fact]
    public void PointConstraintSettings_DefaultConstruct_NoCrash()
    {
        var s = new JPH.PointConstraintSettings();
        s.Dispose();
    }

    [Fact]
    public void PointConstraintSettings_Point1_CanBeSet()
    {
        using var s = new JPH.PointConstraintSettings();
        s.mPoint1.Set(1f, 2f, 3f);
        using var got = s.mPoint1;
        Assert.Equal(1f, got.GetX(), precision: 5);
        Assert.Equal(2f, got.GetY(), precision: 5);
        Assert.Equal(3f, got.GetZ(), precision: 5);
    }

    [Fact]
    public void PointConstraintSettings_Point2_CanBeSet()
    {
        using var s = new JPH.PointConstraintSettings();
        s.mPoint2.Set(-1f, 0f, 5f);
        using var got = s.mPoint2;
        Assert.Equal(-1f, got.GetX(), precision: 5);
        Assert.Equal(0f,  got.GetY(), precision: 5);
        Assert.Equal(5f,  got.GetZ(), precision: 5);
    }

    [Fact]
    public void PointConstraintSettings_BothPoints_CanBeSetIndependently()
    {
        using var s = new JPH.PointConstraintSettings();
        s.mPoint1.Set(1f, 0f, 0f);
        s.mPoint2.Set(0f, 1f, 0f);
        using var p1 = s.mPoint1;
        using var p2 = s.mPoint2;
        Assert.Equal(1f, p1.GetX(), precision: 5);
        Assert.Equal(1f, p2.GetY(), precision: 5);
    }

    // -------------------------------------------------------------------------
    // Constraint creation
    // -------------------------------------------------------------------------

    [Fact]
    public void PointConstraint_Create_ReturnsNonNull()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeSphere(bi, 0f, 10f, 0f, JPH.EMotionType.Dynamic);
        var (body2, id2) = MakeSphere(bi, 0f, 12f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.PointConstraintSettings();
        settings.mPoint1.Set(0f, 11f, 0f);
        settings.mPoint2.Set(0f, 11f, 0f);
        var constraint = settings.Create(body1, body2);
        Assert.NotNull(constraint);

        sys.AddConstraint(constraint!);
        sys.RemoveConstraint(constraint!);

        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    // -------------------------------------------------------------------------
    // Simulation: two bodies linked at the same world-space point should
    // maintain the same relative distance under gravity.
    // -------------------------------------------------------------------------

    [Fact]
    public void PointConstraint_TwoDynamicBodies_FallTogether()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        // Two bodies 2 units apart; constrained at their shared midpoint.
        var (body1, id1) = MakeSphere(bi, 0f, 10f, 0f, JPH.EMotionType.Dynamic);
        var (body2, id2) = MakeSphere(bi, 0f, 12f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.PointConstraintSettings();
        settings.mPoint1.Set(0f, 11f, 0f);
        settings.mPoint2.Set(0f, 11f, 0f);
        var constraint = settings.Create(body1, body2)!;
        sys.AddConstraint(constraint);

        float y1Start; using (var p = bi.GetCenterOfMassPosition(id1)) y1Start = p.GetY();
        float y2Start; using (var p = bi.GetCenterOfMassPosition(id2)) y2Start = p.GetY();

        for (int i = 0; i < 60; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        float y1End; using (var p = bi.GetCenterOfMassPosition(id1)) y1End = p.GetY();
        float y2End; using (var p = bi.GetCenterOfMassPosition(id2)) y2End = p.GetY();

        // Both bodies should have fallen (y decreased).
        Assert.True(y1End < y1Start, $"Body1 did not fall: y1Start={y1Start} y1End={y1End}");
        Assert.True(y2End < y2Start, $"Body2 did not fall: y2Start={y2Start} y2End={y2End}");

        // The gap between them should remain approximately 2 units.
        float gapStart = y2Start - y1Start;
        float gapEnd   = y2End   - y1End;
        Assert.Equal(gapStart, gapEnd, precision: 1);

        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }
}
