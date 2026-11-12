// Tests for TaperedCylinderShapeSettings field round-trips, and
// TaperedCylinderShape geometry queries.

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_TaperedCylinder(JoltFixture fx)
{
    // ─────────────────────────────────────────────────────────────────────────
    // TaperedCylinderShapeSettings
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TaperedCylinderShapeSettings_DefaultConstruct_NoCrash()
    {
        var s = new JPH.TaperedCylinderShapeSettings();
        s.Dispose();
    }

    [Fact]
    public void TaperedCylinderShapeSettings_ParameterizedConstruct_HalfHeightRoundTrips()
    {
        using var s = new JPH.TaperedCylinderShapeSettings(1.5f, 0.8f, 1.2f);
        Assert.Equal(1.5f, s.mHalfHeight, precision: 5);
    }

    [Fact]
    public void TaperedCylinderShapeSettings_ParameterizedConstruct_TopRadiusRoundTrips()
    {
        using var s = new JPH.TaperedCylinderShapeSettings(1.0f, 0.4f, 0.6f);
        Assert.Equal(0.4f, s.mTopRadius, precision: 5);
    }

    [Fact]
    public void TaperedCylinderShapeSettings_ParameterizedConstruct_BottomRadiusRoundTrips()
    {
        using var s = new JPH.TaperedCylinderShapeSettings(1.0f, 0.4f, 0.6f);
        Assert.Equal(0.6f, s.mBottomRadius, precision: 5);
    }

    [Fact]
    public void TaperedCylinderShapeSettings_MutableHalfHeight_CanBeChanged()
    {
        using var s = new JPH.TaperedCylinderShapeSettings(1.0f, 0.5f, 0.5f);
        s.mHalfHeight = 2.0f;
        Assert.Equal(2.0f, s.mHalfHeight, precision: 5);
    }

    [Fact]
    public void TaperedCylinderShapeSettings_MutableTopRadius_CanBeChanged()
    {
        using var s = new JPH.TaperedCylinderShapeSettings(1.0f, 0.5f, 0.5f);
        s.mTopRadius = 0.3f;
        Assert.Equal(0.3f, s.mTopRadius, precision: 5);
    }

    [Fact]
    public void TaperedCylinderShapeSettings_MutableBottomRadius_CanBeChanged()
    {
        using var s = new JPH.TaperedCylinderShapeSettings(1.0f, 0.5f, 0.5f);
        s.mBottomRadius = 0.9f;
        Assert.Equal(0.9f, s.mBottomRadius, precision: 5);
    }

    [Fact]
    public void TaperedCylinderShapeSettings_MutableDensity_CanBeChanged()
    {
        using var s = new JPH.TaperedCylinderShapeSettings(1.0f, 0.5f, 0.5f);
        s.mDensity = 800f;
        Assert.Equal(800f, s.mDensity, precision: 3);
    }

    [Fact]
    public void TaperedCylinderShapeSettings_SetDensity_RoundTrips()
    {
        using var s = new JPH.TaperedCylinderShapeSettings(1.0f, 0.5f, 0.5f);
        s.SetDensity(1200f);
        Assert.Equal(1200f, s.mDensity, precision: 3);
    }

    [Fact]
    public void TaperedCylinderShapeSettings_EqualRadii_ConvexRadiusIsNonNegative()
    {
        using var s = new JPH.TaperedCylinderShapeSettings(1.0f, 0.5f, 0.5f);
        Assert.True(s.mConvexRadius >= 0f);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Body creation with TaperedCylinderShapeSettings
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TaperedCylinder_CanCreateDynamicBody()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var ss  = new JPH.TaperedCylinderShapeSettings(1.0f, 0.4f, 0.6f);
        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_TaperedCylinderShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Dynamic;
        bcs.mObjectLayer = JoltFixture.LayerMoving;
        bcs.mPosition.Set(0f, 5f, 0f);

        var id = bi.CreateAndAddBody(bcs, JPH.EActivation.Activate);
        Assert.False(id.IsInvalid());

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void TaperedCylinder_DynamicBody_FallsUnderGravity()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        using var ss  = new JPH.TaperedCylinderShapeSettings(1.0f, 0.5f, 0.5f);
        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_TaperedCylinderShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Dynamic;
        bcs.mObjectLayer = JoltFixture.LayerMoving;
        bcs.mPosition.Set(0f, 10f, 0f);

        var id = bi.CreateAndAddBody(bcs, JPH.EActivation.Activate);

        float yBefore; using (var p = bi.GetCenterOfMassPosition(id)) yBefore = p.GetY();
        for (int i = 0; i < 30; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);
        float yAfter; using (var p = bi.GetCenterOfMassPosition(id)) yAfter = p.GetY();

        Assert.True(yAfter < yBefore, $"Body did not fall: before={yBefore} after={yAfter}");

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }
}
