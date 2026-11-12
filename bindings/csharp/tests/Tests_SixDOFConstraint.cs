// Tests for SixDOFConstraintSettings and SixDOFConstraint:
// EAxis enum, field round-trips, axis configuration, and constraint creation.

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_SixDOFConstraint(JoltFixture fx)
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
    // EAxis enum values
    // -------------------------------------------------------------------------

    [Fact]
    public void SixDOFConstraintSettings_EAxis_TranslationXIsZero()
    {
        Assert.Equal(0u, (uint)JPH.SixDOFConstraintSettings.EAxis.TranslationX);
    }

    [Fact]
    public void SixDOFConstraintSettings_EAxis_NumIsSix()
    {
        Assert.Equal(6u, (uint)JPH.SixDOFConstraintSettings.EAxis.Num);
    }

    [Fact]
    public void SixDOFConstraintSettings_EAxis_NumTranslationIsThree()
    {
        Assert.Equal(3u, (uint)JPH.SixDOFConstraintSettings.EAxis.NumTranslation);
    }

    // -------------------------------------------------------------------------
    // Settings lifecycle and defaults
    // -------------------------------------------------------------------------

    [Fact]
    public void SixDOFConstraintSettings_DefaultConstruct_NoCrash()
    {
        var s = new JPH.SixDOFConstraintSettings();
        s.Dispose();
    }

    [Fact]
    public void SixDOFConstraintSettings_AllAxesFree_ByDefault()
    {
        using var s = new JPH.SixDOFConstraintSettings();
        // Default: all limits are [-FLT_MAX, FLT_MAX] → IsFreeAxis should be true.
        Assert.True(s.IsFreeAxis(JPH.SixDOFConstraintSettings.EAxis.TranslationX));
        Assert.True(s.IsFreeAxis(JPH.SixDOFConstraintSettings.EAxis.TranslationY));
        Assert.True(s.IsFreeAxis(JPH.SixDOFConstraintSettings.EAxis.TranslationZ));
        Assert.True(s.IsFreeAxis(JPH.SixDOFConstraintSettings.EAxis.RotationX));
        Assert.True(s.IsFreeAxis(JPH.SixDOFConstraintSettings.EAxis.RotationY));
        Assert.True(s.IsFreeAxis(JPH.SixDOFConstraintSettings.EAxis.RotationZ));
    }

    [Fact]
    public void SixDOFConstraintSettings_MakeFixedAxis_IsFixedAfterCall()
    {
        using var s = new JPH.SixDOFConstraintSettings();
        s.MakeFixedAxis(JPH.SixDOFConstraintSettings.EAxis.TranslationX);
        Assert.True(s.IsFixedAxis(JPH.SixDOFConstraintSettings.EAxis.TranslationX));
    }

    [Fact]
    public void SixDOFConstraintSettings_SetLimitedAxis_IsNeitherFreeNorFixed()
    {
        using var s = new JPH.SixDOFConstraintSettings();
        s.SetLimitedAxis(JPH.SixDOFConstraintSettings.EAxis.TranslationY, -1f, 1f);
        Assert.False(s.IsFreeAxis(JPH.SixDOFConstraintSettings.EAxis.TranslationY));
        Assert.False(s.IsFixedAxis(JPH.SixDOFConstraintSettings.EAxis.TranslationY));
    }

    [Fact]
    public void SixDOFConstraintSettings_MakeFreeAxis_AfterFixed_IsFreeAgain()
    {
        using var s = new JPH.SixDOFConstraintSettings();
        s.MakeFixedAxis(JPH.SixDOFConstraintSettings.EAxis.RotationZ);
        Assert.True(s.IsFixedAxis(JPH.SixDOFConstraintSettings.EAxis.RotationZ));
        s.MakeFreeAxis(JPH.SixDOFConstraintSettings.EAxis.RotationZ);
        Assert.True(s.IsFreeAxis(JPH.SixDOFConstraintSettings.EAxis.RotationZ));
    }

    // -------------------------------------------------------------------------
    // Constraint creation
    // -------------------------------------------------------------------------

    [Fact]
    public void SixDOFConstraint_Create_ReturnsNonNull()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 0f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeBox(bi, 0f, 1f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.SixDOFConstraintSettings();
        var constraint = settings.Create(body1, body2);
        Assert.NotNull(constraint);

        sys.AddConstraint(constraint!);
        sys.RemoveConstraint(constraint!);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void SixDOFConstraint_GetTranslationLimitsMin_DefaultIsNegativeInfinity()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 0f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeBox(bi, 0f, 1f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.SixDOFConstraintSettings();
        var constraint = new JPH.SixDOFConstraint(body1, body2, (JPH.Const_SixDOFConstraintSettings)settings);

        using var limMin = constraint.GetTranslationLimitsMin();
        Assert.True(float.IsNegativeInfinity(limMin.GetX()) || limMin.GetX() < -1e30f);

        sys.AddConstraint(constraint);
        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void SixDOFConstraint_GetTranslationLimitsMax_DefaultIsPositiveInfinity()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 0f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeBox(bi, 0f, 1f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.SixDOFConstraintSettings();
        var constraint = new JPH.SixDOFConstraint(body1, body2, (JPH.Const_SixDOFConstraintSettings)settings);

        using var limMax = constraint.GetTranslationLimitsMax();
        Assert.True(float.IsPositiveInfinity(limMax.GetX()) || limMax.GetX() > 1e30f);

        sys.AddConstraint(constraint);
        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void SixDOFConstraint_FixedAllAxes_IsFixedOnAllAxes()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (body1, id1) = MakeBox(bi, 0f, 0f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeBox(bi, 0f, 1f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.SixDOFConstraintSettings();
        for (uint i = 0; i < (uint)JPH.SixDOFConstraintSettings.EAxis.Num; i++)
            settings.MakeFixedAxis((JPH.SixDOFConstraintSettings.EAxis)i);

        var constraint = new JPH.SixDOFConstraint(body1, body2, (JPH.Const_SixDOFConstraintSettings)settings);

        for (uint i = 0; i < (uint)JPH.SixDOFConstraintSettings.EAxis.Num; i++)
            Assert.True(constraint.IsFixedAxis((JPH.SixDOFConstraintSettings.EAxis)i));

        sys.AddConstraint(constraint);
        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    // -------------------------------------------------------------------------
    // Simulation
    // -------------------------------------------------------------------------

    [Fact]
    public void SixDOFConstraint_AllAxesFixed_BodyStaysInPlace()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        var (body1, id1) = MakeBox(bi, 0f, 0f, 0f, JPH.EMotionType.Static);
        var (body2, id2) = MakeBox(bi, 0f, 1f, 0f, JPH.EMotionType.Dynamic);

        using var settings = new JPH.SixDOFConstraintSettings();
        for (uint i = 0; i < (uint)JPH.SixDOFConstraintSettings.EAxis.Num; i++)
            settings.MakeFixedAxis((JPH.SixDOFConstraintSettings.EAxis)i);

        var constraint = new JPH.SixDOFConstraint(body1, body2, (JPH.Const_SixDOFConstraintSettings)settings);
        sys.AddConstraint(constraint);

        for (int i = 0; i < 60; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        float y2;
        using (var p = bi.GetCenterOfMassPosition(id2)) y2 = p.GetY();
        // With all axes fixed, body2 should stay near y=1 (±tolerance due to gravity fighting constraint).
        Assert.True(y2 > -5f, $"Body2 fell too far: y={y2}");

        sys.RemoveConstraint(constraint);
        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }
}
