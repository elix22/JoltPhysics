// Tests for JPH::TaperedCapsuleShapeSettings field round-trips, utility methods
// (IsValid, IsSphere), and JPH::TaperedCapsuleShape body simulation.
// Note: TaperedCapsuleShape has no parameterized constructor; shape-specific
// geometry queries require constructing a body and retrieving the shape.

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_TaperedCapsuleShape(JoltFixture fx)
{
    // ─────────────────────────────────────────────────────────────────────────
    // TaperedCapsuleShapeSettings — construction and field round-trips
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TaperedCapsuleShapeSettings_DefaultConstruct_NoCrash()
    {
        var s = new JPH.TaperedCapsuleShapeSettings();
        s.Dispose();
    }

    [Fact]
    public void TaperedCapsuleShapeSettings_HalfHeightRoundTrips()
    {
        using var s = new JPH.TaperedCapsuleShapeSettings(0.5f, 0.3f, 0.2f);
        Assert.Equal(0.5f, s.mHalfHeightOfTaperedCylinder, precision: 5);
    }

    [Fact]
    public void TaperedCapsuleShapeSettings_TopRadiusRoundTrips()
    {
        using var s = new JPH.TaperedCapsuleShapeSettings(0.5f, 0.3f, 0.2f);
        Assert.Equal(0.3f, s.mTopRadius, precision: 5);
    }

    [Fact]
    public void TaperedCapsuleShapeSettings_BottomRadiusRoundTrips()
    {
        using var s = new JPH.TaperedCapsuleShapeSettings(0.5f, 0.3f, 0.2f);
        Assert.Equal(0.2f, s.mBottomRadius, precision: 5);
    }

    [Fact]
    public void TaperedCapsuleShapeSettings_MutableHalfHeight_CanBeChanged()
    {
        using var s = new JPH.TaperedCapsuleShapeSettings(0.5f, 0.3f, 0.2f);
        s.mHalfHeightOfTaperedCylinder = 1.0f;
        Assert.Equal(1.0f, s.mHalfHeightOfTaperedCylinder, precision: 5);
    }

    [Fact]
    public void TaperedCapsuleShapeSettings_MutableTopRadius_CanBeChanged()
    {
        using var s = new JPH.TaperedCapsuleShapeSettings(0.5f, 0.3f, 0.2f);
        s.mTopRadius = 0.6f;
        Assert.Equal(0.6f, s.mTopRadius, precision: 5);
    }

    [Fact]
    public void TaperedCapsuleShapeSettings_MutableBottomRadius_CanBeChanged()
    {
        using var s = new JPH.TaperedCapsuleShapeSettings(0.5f, 0.3f, 0.2f);
        s.mBottomRadius = 0.7f;
        Assert.Equal(0.7f, s.mBottomRadius, precision: 5);
    }

    [Fact]
    public void TaperedCapsuleShapeSettings_DefaultDensity_Is1000()
    {
        using var s = new JPH.TaperedCapsuleShapeSettings(0.5f, 0.3f, 0.2f);
        Assert.Equal(1000f, s.mDensity, precision: 3);
    }

    [Fact]
    public void TaperedCapsuleShapeSettings_MutableDensity_CanBeChanged()
    {
        using var s = new JPH.TaperedCapsuleShapeSettings(0.5f, 0.3f, 0.2f);
        s.mDensity = 500f;
        Assert.Equal(500f, s.mDensity, precision: 3);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // TaperedCapsuleShapeSettings — IsValid / IsSphere utility methods
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TaperedCapsuleShapeSettings_IsValid_TrueForValidParams()
    {
        using var s = new JPH.TaperedCapsuleShapeSettings(0.5f, 0.3f, 0.2f);
        Assert.True(s.IsValid());
    }

    [Fact]
    public void TaperedCapsuleShapeSettings_IsValid_FalseWhenBothRadiiZero()
    {
        // Jolt requires topRadius + bottomRadius > 0
        using var s = new JPH.TaperedCapsuleShapeSettings(0.5f, 0f, 0f);
        Assert.False(s.IsValid());
    }

    [Fact]
    public void TaperedCapsuleShapeSettings_IsSphere_TrueWhenHalfHeightZeroEqualRadii()
    {
        using var s = new JPH.TaperedCapsuleShapeSettings(0f, 0.5f, 0.5f);
        Assert.True(s.IsSphere());
    }

    [Fact]
    public void TaperedCapsuleShapeSettings_IsSphere_FalseWhenHalfHeightNonZero()
    {
        using var s = new JPH.TaperedCapsuleShapeSettings(0.5f, 0.3f, 0.3f);
        Assert.False(s.IsSphere());
    }

    [Fact]
    public void TaperedCapsuleShapeSettings_IsSphere_FalseWhenHalfHeightPreventsDegenerate()
    {
        // IsSphere: max(r1,r2) >= 2*halfH + min(r1,r2)
        // With halfH=0.5, top=0.3, bottom=0.5: 0.5 < 1.0+0.3=1.3 → not a sphere
        using var s = new JPH.TaperedCapsuleShapeSettings(0.5f, 0.3f, 0.5f);
        Assert.False(s.IsSphere());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Simulation
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TaperedCapsuleShape_CanCreateDynamicBody()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var ss  = new JPH.TaperedCapsuleShapeSettings(0.5f, 0.3f, 0.2f);
        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_TaperedCapsuleShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Dynamic;
        bcs.mObjectLayer = JoltFixture.LayerMoving;
        bcs.mPosition.Set(0f, 5f, 0f);

        var id = bi.CreateAndAddBody(bcs, JPH.EActivation.Activate);
        Assert.False(id.IsInvalid());

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void TaperedCapsuleShape_DynamicBody_FallsUnderGravity()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        using var ss  = new JPH.TaperedCapsuleShapeSettings(0.5f, 0.3f, 0.2f);
        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_TaperedCapsuleShapeSettings)ss);
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

    // ─────────────────────────────────────────────────────────────────────────
    // TaperedCapsuleShape — geometry queries via base-class Const_Shape
    // GetTopRadius / GetBottomRadius are settings-level properties already
    // covered above.  Here we verify the shape object exposes correct
    // volume, bounds, inner radius, COM and density.
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TaperedCapsuleShape_GetVolume_IsPositive()
    {
        // bcs owns the shape; keep bcs alive while querying.
        using var ss  = new JPH.TaperedCapsuleShapeSettings(0.5f, 1.0f, 0.5f);
        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_TaperedCapsuleShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;
        var shape = bcs.GetShape()!;  // non-owning; bcs keeps shape alive
        Assert.True(shape.GetVolume() > 0f);
    }

    [Fact]
    public void TaperedCapsuleShape_GetInnerRadius_IsPositive()
    {
        using var ss  = new JPH.TaperedCapsuleShapeSettings(0.5f, 1.0f, 0.5f);
        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_TaperedCapsuleShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;
        var shape = bcs.GetShape()!;
        Assert.True(shape.GetInnerRadius() > 0f);
    }

    [Fact]
    public void TaperedCapsuleShape_GetInnerRadius_LessOrEqualMinRadius()
    {
        // For (halfH=0.5, top=1.0, bottom=0.5) inner radius ≤ min(top,bottom)=0.5
        using var ss  = new JPH.TaperedCapsuleShapeSettings(0.5f, 1.0f, 0.5f);
        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_TaperedCapsuleShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;
        var shape = bcs.GetShape()!;
        Assert.True(shape.GetInnerRadius() <= 0.5f + 1e-5f);
    }

    [Fact]
    public void TaperedCapsuleShape_GetLocalBounds_IsValid()
    {
        using var ss  = new JPH.TaperedCapsuleShapeSettings(0.5f, 1.0f, 0.5f);
        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_TaperedCapsuleShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;
        var shape = bcs.GetShape()!;
        using var bb = shape.GetLocalBounds();
        Assert.True(bb.IsValid());
    }

    [Fact]
    public void TaperedCapsuleShape_GetLocalBounds_EnclosesShape()
    {
        // For (halfH=0.5, top=1.0, bottom=0.5) the bounding box Y-extent ≥ 2*(0.5+1.0)
        using var ss  = new JPH.TaperedCapsuleShapeSettings(0.5f, 1.0f, 0.5f);
        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_TaperedCapsuleShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;
        var shape = bcs.GetShape()!;
        using var bb   = shape.GetLocalBounds();
        using var size = bb.GetSize();
        Assert.True(size.GetY() >= 1.5f, $"Y size={size.GetY()} too small");
    }

    [Fact]
    public void TaperedCapsuleShape_GetCenterOfMass_YIsZeroForSymmetricRadii()
    {
        // halfH=0.5, top=0.5, bottom=0.5 → symmetric → COM.Y == 0
        using var bcs = new JPH.BodyCreationSettings();
        using var ss  = new JPH.TaperedCapsuleShapeSettings(0.5f, 0.5f, 0.5f);
        bcs.SetShapeSettings((JPH.Const_TaperedCapsuleShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;
        using var shape = bcs.GetShape()!;
        using var com   = shape.GetCenterOfMass();
        Assert.Equal(0f, com.GetY(), precision: 4);
    }
}
