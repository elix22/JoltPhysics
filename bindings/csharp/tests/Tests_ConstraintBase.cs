// Tests for Constraint base class methods (via DistanceConstraint) and
// TwoBodyConstraint-specific methods, covering:
//   - GetNumVelocityStepsOverride (default=0, round-trip)
//   - GetNumPositionStepsOverride (default=0, round-trip)
//   - GetEnabled (default=true)
//   - IsActive (true when enabled + bodies active)
//   - SetEnabled / IsActive changes
//   - ResetWarmStart (no-crash)
//   - TwoBodyConstraint.GetBody1 / GetBody2 (non-null)
//   - TwoBodyConstraint.GetConstraintToBody1Matrix / Body2Matrix

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_ConstraintBase(JoltFixture fx)
{
    // Helper — create a box body, add to sim, return (Body, BodyID).
    private static (JPH.Body body, JPH.BodyID id) MakeBox(
        JPH.BodyInterface bi, JPH.EMotionType motion, float x, float y, float z)
    {
        using var ss = new JPH.BoxShapeSettings(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_BoxShapeSettings)ss);
        cs.mMotionType  = motion;
        cs.mObjectLayer = motion == JPH.EMotionType.Static
            ? JoltFixture.LayerNonMoving
            : JoltFixture.LayerMoving;
        cs.mPosition.Set(x, y, z);
        var body = bi.CreateBody(cs)!;
        var id   = body.GetID();
        bi.AddBody(id, motion == JPH.EMotionType.Static
            ? JPH.EActivation.DontActivate
            : JPH.EActivation.Activate);
        return (body, id);
    }

    // Build a distance constraint between two bodies.
    private static JPH.TwoBodyConstraint MakeDistanceConstraint(
        JPH.PhysicsSystem sys, JPH.Body b1, JPH.Body b2, float maxDist = 5f)
    {
        using var settings = new JPH.DistanceConstraintSettings();
        settings.mMinDistance = 0f;
        settings.mMaxDistance = maxDist;
        return settings.Create(b1, b2)!;
    }

    // -------------------------------------------------------------------------
    // ConstraintSettings fields (on the Constraint object side)
    // -------------------------------------------------------------------------

    [Fact]
    public void Constraint_GetNumVelocityStepsOverride_DefaultIsZero()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (b1, id1) = MakeBox(bi, JPH.EMotionType.Static,  0f, 0f, 0f);
        var (b2, id2) = MakeBox(bi, JPH.EMotionType.Dynamic, 0f, 3f, 0f);
        try
        {
            var c = MakeDistanceConstraint(sys, b1, b2);
            sys.AddConstraint(c);
            Assert.Equal(0u, c.GetNumVelocityStepsOverride());
            sys.RemoveConstraint(c);
        }
        finally { bi.RemoveBody(id1); bi.DestroyBody(id1); bi.RemoveBody(id2); bi.DestroyBody(id2); }
    }

    [Fact]
    public void Constraint_SetNumVelocityStepsOverride_RoundTrips()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (b1, id1) = MakeBox(bi, JPH.EMotionType.Static,  0f, 0f, 0f);
        var (b2, id2) = MakeBox(bi, JPH.EMotionType.Dynamic, 0f, 3f, 0f);
        try
        {
            var c = MakeDistanceConstraint(sys, b1, b2);
            sys.AddConstraint(c);
            c.SetNumVelocityStepsOverride(8u);
            Assert.Equal(8u, c.GetNumVelocityStepsOverride());
            sys.RemoveConstraint(c);
        }
        finally { bi.RemoveBody(id1); bi.DestroyBody(id1); bi.RemoveBody(id2); bi.DestroyBody(id2); }
    }

    [Fact]
    public void Constraint_GetNumPositionStepsOverride_DefaultIsZero()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (b1, id1) = MakeBox(bi, JPH.EMotionType.Static,  0f, 0f, 0f);
        var (b2, id2) = MakeBox(bi, JPH.EMotionType.Dynamic, 0f, 3f, 0f);
        try
        {
            var c = MakeDistanceConstraint(sys, b1, b2);
            sys.AddConstraint(c);
            Assert.Equal(0u, c.GetNumPositionStepsOverride());
            sys.RemoveConstraint(c);
        }
        finally { bi.RemoveBody(id1); bi.DestroyBody(id1); bi.RemoveBody(id2); bi.DestroyBody(id2); }
    }

    [Fact]
    public void Constraint_SetNumPositionStepsOverride_RoundTrips()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (b1, id1) = MakeBox(bi, JPH.EMotionType.Static,  0f, 0f, 0f);
        var (b2, id2) = MakeBox(bi, JPH.EMotionType.Dynamic, 0f, 3f, 0f);
        try
        {
            var c = MakeDistanceConstraint(sys, b1, b2);
            sys.AddConstraint(c);
            c.SetNumPositionStepsOverride(4u);
            Assert.Equal(4u, c.GetNumPositionStepsOverride());
            sys.RemoveConstraint(c);
        }
        finally { bi.RemoveBody(id1); bi.DestroyBody(id1); bi.RemoveBody(id2); bi.DestroyBody(id2); }
    }

    // -------------------------------------------------------------------------
    // Enabled / IsActive
    // -------------------------------------------------------------------------

    [Fact]
    public void Constraint_GetEnabled_DefaultIsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (b1, id1) = MakeBox(bi, JPH.EMotionType.Static,  0f, 0f, 0f);
        var (b2, id2) = MakeBox(bi, JPH.EMotionType.Dynamic, 0f, 3f, 0f);
        try
        {
            var c = MakeDistanceConstraint(sys, b1, b2);
            sys.AddConstraint(c);
            Assert.True(c.GetEnabled());
            sys.RemoveConstraint(c);
        }
        finally { bi.RemoveBody(id1); bi.DestroyBody(id1); bi.RemoveBody(id2); bi.DestroyBody(id2); }
    }

    [Fact]
    public void Constraint_SetEnabled_False_GetEnabled_ReturnsFalse()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (b1, id1) = MakeBox(bi, JPH.EMotionType.Static,  0f, 0f, 0f);
        var (b2, id2) = MakeBox(bi, JPH.EMotionType.Dynamic, 0f, 3f, 0f);
        try
        {
            var c = MakeDistanceConstraint(sys, b1, b2);
            sys.AddConstraint(c);
            c.SetEnabled(false);
            Assert.False(c.GetEnabled());
            sys.RemoveConstraint(c);
        }
        finally { bi.RemoveBody(id1); bi.DestroyBody(id1); bi.RemoveBody(id2); bi.DestroyBody(id2); }
    }

    [Fact]
    public void Constraint_IsActive_EnabledWithActiveBodies_ReturnsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();
        var (b1, id1) = MakeBox(bi, JPH.EMotionType.Static,  0f, 0f, 0f);
        var (b2, id2) = MakeBox(bi, JPH.EMotionType.Dynamic, 0f, 3f, 0f);
        try
        {
            var c = MakeDistanceConstraint(sys, b1, b2);
            sys.AddConstraint(c);
            // Step once so bodies are awake/active
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);
            Assert.True(c.IsActive());
            sys.RemoveConstraint(c);
        }
        finally { bi.RemoveBody(id1); bi.DestroyBody(id1); bi.RemoveBody(id2); bi.DestroyBody(id2); }
    }

    // -------------------------------------------------------------------------
    // ResetWarmStart
    // -------------------------------------------------------------------------

    [Fact]
    public void Constraint_ResetWarmStart_DoesNotThrow()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (b1, id1) = MakeBox(bi, JPH.EMotionType.Static,  0f, 0f, 0f);
        var (b2, id2) = MakeBox(bi, JPH.EMotionType.Dynamic, 0f, 3f, 0f);
        try
        {
            var c = MakeDistanceConstraint(sys, b1, b2);
            sys.AddConstraint(c);
            var ex = Record.Exception(() => c.ResetWarmStart());
            Assert.Null(ex);
            sys.RemoveConstraint(c);
        }
        finally { bi.RemoveBody(id1); bi.DestroyBody(id1); bi.RemoveBody(id2); bi.DestroyBody(id2); }
    }

    // -------------------------------------------------------------------------
    // TwoBodyConstraint — GetBody1 / GetBody2
    // -------------------------------------------------------------------------

    [Fact]
    public void TwoBodyConstraint_GetBody1_IsNotNull()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (b1, id1) = MakeBox(bi, JPH.EMotionType.Static,  0f, 0f, 0f);
        var (b2, id2) = MakeBox(bi, JPH.EMotionType.Dynamic, 0f, 3f, 0f);
        try
        {
            var c = MakeDistanceConstraint(sys, b1, b2);
            sys.AddConstraint(c);
            Assert.NotNull(c.GetBody1());
            sys.RemoveConstraint(c);
        }
        finally { bi.RemoveBody(id1); bi.DestroyBody(id1); bi.RemoveBody(id2); bi.DestroyBody(id2); }
    }

    [Fact]
    public void TwoBodyConstraint_GetBody2_IsNotNull()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (b1, id1) = MakeBox(bi, JPH.EMotionType.Static,  0f, 0f, 0f);
        var (b2, id2) = MakeBox(bi, JPH.EMotionType.Dynamic, 0f, 3f, 0f);
        try
        {
            var c = MakeDistanceConstraint(sys, b1, b2);
            sys.AddConstraint(c);
            Assert.NotNull(c.GetBody2());
            sys.RemoveConstraint(c);
        }
        finally { bi.RemoveBody(id1); bi.DestroyBody(id1); bi.RemoveBody(id2); bi.DestroyBody(id2); }
    }

    // -------------------------------------------------------------------------
    // TwoBodyConstraint — GetConstraintToBody1/2Matrix
    // -------------------------------------------------------------------------

    [Fact]
    public void TwoBodyConstraint_GetConstraintToBody1Matrix_IsValid()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (b1, id1) = MakeBox(bi, JPH.EMotionType.Static,  0f, 0f, 0f);
        var (b2, id2) = MakeBox(bi, JPH.EMotionType.Dynamic, 0f, 3f, 0f);
        try
        {
            var c = MakeDistanceConstraint(sys, b1, b2);
            sys.AddConstraint(c);
            using var m = c.GetConstraintToBody1Matrix();
            Assert.NotNull(m);
            sys.RemoveConstraint(c);
        }
        finally { bi.RemoveBody(id1); bi.DestroyBody(id1); bi.RemoveBody(id2); bi.DestroyBody(id2); }
    }

    [Fact]
    public void TwoBodyConstraint_GetConstraintToBody2Matrix_IsValid()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (b1, id1) = MakeBox(bi, JPH.EMotionType.Static,  0f, 0f, 0f);
        var (b2, id2) = MakeBox(bi, JPH.EMotionType.Dynamic, 0f, 3f, 0f);
        try
        {
            var c = MakeDistanceConstraint(sys, b1, b2);
            sys.AddConstraint(c);
            using var m = c.GetConstraintToBody2Matrix();
            Assert.NotNull(m);
            sys.RemoveConstraint(c);
        }
        finally { bi.RemoveBody(id1); bi.DestroyBody(id1); bi.RemoveBody(id2); bi.DestroyBody(id2); }
    }
}
