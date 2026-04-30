// Tests for FixedConstraintSettings field round-trips and FixedConstraint
// lifecycle / property getters + setters.

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_FixedConstraint(JoltFixture fx)
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
    // FixedConstraintSettings — defaults
    // -------------------------------------------------------------------------

    [Fact]
    public void FixedConstraintSettings_AutoDetectPoint_DefaultIsFalse()
    {
        using var s = new JPH.FixedConstraintSettings();
        Assert.False(s.mAutoDetectPoint);
    }

    [Fact]
    public void FixedConstraintSettings_AutoDetectPoint_RoundTrips()
    {
        using var s = new JPH.FixedConstraintSettings();
        s.mAutoDetectPoint = false;
        Assert.False(s.mAutoDetectPoint);
    }

    [Fact]
    public void FixedConstraintSettings_Enabled_DefaultIsTrue()
    {
        using var s = new JPH.FixedConstraintSettings();
        Assert.True(s.mEnabled);
    }

    [Fact]
    public void FixedConstraintSettings_Enabled_RoundTrips()
    {
        using var s = new JPH.FixedConstraintSettings();
        s.mEnabled = false;
        Assert.False(s.mEnabled);
    }

    [Fact]
    public void FixedConstraintSettings_ConstraintPriority_DefaultIsZero()
    {
        using var s = new JPH.FixedConstraintSettings();
        Assert.Equal(0u, s.mConstraintPriority);
    }

    [Fact]
    public void FixedConstraintSettings_ConstraintPriority_RoundTrips()
    {
        using var s = new JPH.FixedConstraintSettings();
        s.mConstraintPriority = 42u;
        Assert.Equal(42u, s.mConstraintPriority);
    }

    [Fact]
    public void FixedConstraintSettings_UserData_DefaultIsZero()
    {
        using var s = new JPH.FixedConstraintSettings();
        Assert.Equal(UIntPtr.Zero, s.mUserData);
    }

    [Fact]
    public void FixedConstraintSettings_UserData_RoundTrips()
    {
        using var s = new JPH.FixedConstraintSettings();
        s.mUserData = (UIntPtr)1234;
        Assert.Equal((UIntPtr)1234, s.mUserData);
    }

    [Fact]
    public void FixedConstraintSettings_NumVelocityStepsOverride_DefaultIsZero()
    {
        using var s = new JPH.FixedConstraintSettings();
        Assert.Equal(0u, s.mNumVelocityStepsOverride);
    }

    [Fact]
    public void FixedConstraintSettings_NumVelocityStepsOverride_RoundTrips()
    {
        using var s = new JPH.FixedConstraintSettings();
        s.mNumVelocityStepsOverride = 8u;
        Assert.Equal(8u, s.mNumVelocityStepsOverride);
    }

    // -------------------------------------------------------------------------
    // FixedConstraint — GetBody1 / GetBody2
    // -------------------------------------------------------------------------

    [Fact]
    public void FixedConstraint_GetBody1_IsNotNull()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 10f, 0f, JPH.EMotionType.Dynamic);
        var (body2, id2) = MakeBox(bi, 0f, 11f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.FixedConstraintSettings();
        settings.mAutoDetectPoint = true;
        var constraint = settings.Create(body1, body2)!;
        sys.AddConstraint(constraint);

        Assert.NotNull(constraint.GetBody1());

        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void FixedConstraint_GetBody2_IsNotNull()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 10f, 0f, JPH.EMotionType.Dynamic);
        var (body2, id2) = MakeBox(bi, 0f, 11f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.FixedConstraintSettings();
        settings.mAutoDetectPoint = true;
        var constraint = settings.Create(body1, body2)!;
        sys.AddConstraint(constraint);

        Assert.NotNull(constraint.GetBody2());

        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    // -------------------------------------------------------------------------
    // FixedConstraint — GetEnabled / SetEnabled
    // -------------------------------------------------------------------------

    [Fact]
    public void FixedConstraint_GetEnabled_DefaultIsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 10f, 0f, JPH.EMotionType.Dynamic);
        var (body2, id2) = MakeBox(bi, 0f, 11f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.FixedConstraintSettings();
        settings.mAutoDetectPoint = true;
        var constraint = settings.Create(body1, body2)!;
        sys.AddConstraint(constraint);

        Assert.True(constraint.GetEnabled());

        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void FixedConstraint_SetEnabled_False_GetEnabled_ReturnsFalse()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 10f, 0f, JPH.EMotionType.Dynamic);
        var (body2, id2) = MakeBox(bi, 0f, 11f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.FixedConstraintSettings();
        settings.mAutoDetectPoint = true;
        var constraint = settings.Create(body1, body2)!;
        sys.AddConstraint(constraint);

        constraint.SetEnabled(false);
        Assert.False(constraint.GetEnabled());

        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    // -------------------------------------------------------------------------
    // FixedConstraint — GetConstraintPriority / SetConstraintPriority
    // -------------------------------------------------------------------------

    [Fact]
    public void FixedConstraint_GetConstraintPriority_DefaultIsZero()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 10f, 0f, JPH.EMotionType.Dynamic);
        var (body2, id2) = MakeBox(bi, 0f, 11f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.FixedConstraintSettings();
        settings.mAutoDetectPoint = true;
        var constraint = settings.Create(body1, body2)!;

        Assert.Equal(0u, constraint.GetConstraintPriority());

        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void FixedConstraint_SetConstraintPriority_RoundTrips()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 10f, 0f, JPH.EMotionType.Dynamic);
        var (body2, id2) = MakeBox(bi, 0f, 11f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.FixedConstraintSettings();
        settings.mAutoDetectPoint = true;
        var constraint = settings.Create(body1, body2)!;

        constraint.SetConstraintPriority(7u);
        Assert.Equal(7u, constraint.GetConstraintPriority());

        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    // -------------------------------------------------------------------------
    // FixedConstraint — lambda impulse after simulation
    // -------------------------------------------------------------------------

    [Fact]
    public void FixedConstraint_AfterSim_TotalLambdaPosition_IsNonZero()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        // Static anchor; dynamic body hangs from it — gravity forces a non-zero impulse.
        var (body1, id1) = MakeBox(bi, 0f, 0f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeBox(bi, 0f, 1f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.FixedConstraintSettings();
        settings.mAutoDetectPoint = true;
        var constraint = new JPH.FixedConstraint(body1, body2, (JPH.Const_FixedConstraintSettings)settings);
        sys.AddConstraint((JPH.Constraint)constraint);

        for (int i = 0; i < 10; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        using var lambda = constraint.GetTotalLambdaPosition();
        float len = MathF.Sqrt(
            lambda.GetX() * lambda.GetX() +
            lambda.GetY() * lambda.GetY() +
            lambda.GetZ() * lambda.GetZ());
        Assert.True(len > 0f, $"Expected non-zero lambda after simulation, got {len}");

        sys.RemoveConstraint((JPH.Constraint)constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }
}
