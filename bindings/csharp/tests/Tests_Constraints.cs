// Tests for constraint creation, ref-counting of ConstraintSettings, and
// basic simulation with constraints attached.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Constraints(JoltFixture fx)
{
    // Helper: create a body and return the Body* (unowned view — BodyInterface owns it).
    private static (JPH.Body body, JPH.BodyID id) CreateBody(
        JPH.BodyInterface bi,
        float hx, float hy, float hz,
        float x, float y, float z,
        JPH.EMotionType motion)
    {
        using var ss = new JPH.BoxShapeSettings(new JPH.Vec3(hx, hy, hz));
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_BoxShapeSettings)ss);
        cs.mMotionType  = motion;
        cs.mObjectLayer = motion == JPH.EMotionType.Static
            ? JoltFixture.LayerNonMoving
            : JoltFixture.LayerMoving;
        cs.mPosition.Set(x, y, z);

        // CreateBody returns a Body* that is NOT owned by C# — BodyInterface owns it.
        var body = bi.CreateBody(cs)!;
        var id   = body.GetID();
        var activation = motion == JPH.EMotionType.Static
            ? JPH.EActivation.DontActivate
            : JPH.EActivation.Activate;
        bi.AddBody(id, activation);
        return (body, id);
    }

    // -------------------------------------------------------------------------
    // ConstraintSettings lifecycle (ref-counting via --intrinsic-ref-counted-base)
    // -------------------------------------------------------------------------

    [Fact]
    public void FixedConstraintSettings_DisposeExplicit_NoCrash()
    {
        var cs = new JPH.FixedConstraintSettings();
        cs.Dispose();
    }

    [Fact]
    public void HingeConstraintSettings_DisposeExplicit_NoCrash()
    {
        var cs = new JPH.HingeConstraintSettings();
        cs.Dispose();
    }

    [Fact]
    public void DistanceConstraintSettings_DisposeExplicit_NoCrash()
    {
        var cs = new JPH.DistanceConstraintSettings();
        cs.Dispose();
    }

    [Fact]
    public void PointConstraintSettings_DisposeExplicit_NoCrash()
    {
        var cs = new JPH.PointConstraintSettings();
        cs.Dispose();
    }

    // -------------------------------------------------------------------------
    // Fixed constraint: two bodies linked together should move as one.
    // -------------------------------------------------------------------------

    [Fact]
    public void FixedConstraint_TwoDynamicBodies_AreLinkedTogether()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        // Two boxes separated by 1 unit vertically.
        var (body1, id1) = CreateBody(bi, 0.5f, 0.5f, 0.5f, 0f, 10f,  0f, JPH.EMotionType.Dynamic);
        var (body2, id2) = CreateBody(bi, 0.5f, 0.5f, 0.5f, 0f, 11f,  0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.FixedConstraintSettings();
        settings.mAutoDetectPoint = true;

        var constraint = settings.Create(body1, body2)!;
        sys.AddConstraint(constraint);

        // Simulate a few steps — both bodies should fall together.
        for (int i = 0; i < 60; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        float y1; using (var p = bi.GetCenterOfMassPosition(id1)) y1 = p.GetY();
        float y2; using (var p = bi.GetCenterOfMassPosition(id2)) y2 = p.GetY();

        // They started 1 unit apart; fixed constraint should preserve that separation.
        Assert.Equal(1f, y2 - y1, precision: 1);

        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    // -------------------------------------------------------------------------
    // Distance constraint: separation stays within [min, max].
    // -------------------------------------------------------------------------

    [Fact]
    public void DistanceConstraint_BodyCannotExceedMaxDistance()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        // Anchor: static body.  Ball: dynamic, starts 0.5 m below anchor.
        var (anchor, anchorId) = CreateBody(bi, 0.2f, 0.2f, 0.2f, 0f, 10f, 0f, JPH.EMotionType.Static);
        var (ball,   ballId  ) = CreateBody(bi, 0.2f, 0.2f, 0.2f, 0f,  9f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.DistanceConstraintSettings();
        settings.mMinDistance = 0.0f;
        settings.mMaxDistance = 2.0f;  // rope length

        var constraint = settings.Create(anchor, ball)!;
        sys.AddConstraint(constraint);

        // Simulate 3 seconds.
        for (int i = 0; i < 180; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        float anchorY; using (var p = bi.GetCenterOfMassPosition(anchorId)) anchorY = p.GetY();
        float ballY;   using (var p = bi.GetCenterOfMassPosition(ballId))   ballY   = p.GetY();

        float dist = MathF.Abs(ballY - anchorY);
        Assert.True(dist <= 2.0f + 0.1f,
            $"Ball exceeded max rope length. dist={dist:F3}");

        sys.RemoveConstraint(constraint);
        bi.RemoveBody(ballId);   bi.DestroyBody(ballId);
        bi.RemoveBody(anchorId); bi.DestroyBody(anchorId);
    }

    // -------------------------------------------------------------------------
    // ConstraintSettings stress: create many, dispose, no corruption.
    // -------------------------------------------------------------------------

    [Fact]
    public void ConstraintSettings_AllocateDisposeStress_NoCorruption()
    {
        for (int i = 0; i < 200; i++)
        {
            using var f = new JPH.FixedConstraintSettings();
            using var h = new JPH.HingeConstraintSettings();
            using var d = new JPH.DistanceConstraintSettings();
            using var p = new JPH.PointConstraintSettings();
        }
        Assert.True(true);
    }
}
