// Tests for JPH::CylinderShapeSettings field defaults + round-trips and
// JPH::CylinderShape direct construction with geometry getters and density.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_CylinderShape(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // CylinderShapeSettings — defaults
    // -------------------------------------------------------------------------

    [Fact]
    public void CylinderShapeSettings_DefaultConstruct_DoesNotThrow()
    {
        using var s = new JPH.CylinderShapeSettings();
        Assert.NotNull(s);
    }

    [Fact]
    public void CylinderShapeSettings_ParameterizedConstruct_DoesNotThrow()
    {
        using var s = new JPH.CylinderShapeSettings(0.5f, 0.4f);
        Assert.NotNull(s);
    }

    [Fact]
    public void CylinderShapeSettings_Density_DefaultIs1000()
    {
        using var s = new JPH.CylinderShapeSettings();
        Assert.Equal(1000f, s.mDensity, precision: 3);
    }

    // -------------------------------------------------------------------------
    // CylinderShapeSettings — field round-trips
    // -------------------------------------------------------------------------

    [Fact]
    public void CylinderShapeSettings_mHalfHeight_RoundTrips()
    {
        using var s = new JPH.CylinderShapeSettings();
        s.mHalfHeight = 1.5f;
        Assert.Equal(1.5f, s.mHalfHeight, precision: 5);
    }

    [Fact]
    public void CylinderShapeSettings_mRadius_RoundTrips()
    {
        using var s = new JPH.CylinderShapeSettings();
        s.mRadius = 0.75f;
        Assert.Equal(0.75f, s.mRadius, precision: 5);
    }

    [Fact]
    public void CylinderShapeSettings_mConvexRadius_RoundTrips()
    {
        using var s = new JPH.CylinderShapeSettings();
        s.mConvexRadius = 0.02f;
        Assert.Equal(0.02f, s.mConvexRadius, precision: 5);
    }

    [Fact]
    public void CylinderShapeSettings_mDensity_RoundTrips()
    {
        using var s = new JPH.CylinderShapeSettings();
        s.mDensity = 800f;
        Assert.Equal(800f, s.mDensity, precision: 3);
    }

    // -------------------------------------------------------------------------
    // CylinderShape — construction
    // -------------------------------------------------------------------------

    [Fact]
    public void CylinderShape_DirectConstruct_DoesNotThrow()
    {
        using var shape = new JPH.CylinderShape(0.5f, 0.4f);
        Assert.NotNull(shape);
    }

    // -------------------------------------------------------------------------
    // CylinderShape — geometry getters
    // -------------------------------------------------------------------------

    [Fact]
    public void CylinderShape_GetHalfHeight_MatchesInput()
    {
        using var shape = new JPH.CylinderShape(0.6f, 0.3f);
        Assert.Equal(0.6f, shape.GetHalfHeight(), precision: 5);
    }

    [Fact]
    public void CylinderShape_GetRadius_MatchesInput()
    {
        using var shape = new JPH.CylinderShape(0.6f, 0.3f);
        Assert.Equal(0.3f, shape.GetRadius(), precision: 5);
    }

    [Fact]
    public void CylinderShape_GetLocalBounds_IsValid()
    {
        using var shape = new JPH.CylinderShape(0.5f, 0.4f);
        using var bb    = shape.GetLocalBounds();
        Assert.True(bb.IsValid());
    }

    [Fact]
    public void CylinderShape_GetLocalBounds_HeightMatchesHalfHeight()
    {
        // Total height = 2 * halfHeight = 2 * 0.5 = 1.0
        using var shape = new JPH.CylinderShape(0.5f, 0.4f);
        using var bb    = shape.GetLocalBounds();
        using var size  = bb.GetSize();
        Assert.Equal(1.0f, size.GetY(), precision: 4);
    }

    [Fact]
    public void CylinderShape_GetLocalBounds_WidthMatchesDiameter()
    {
        // Width = 2 * radius = 2 * 0.4 = 0.8
        using var shape = new JPH.CylinderShape(0.5f, 0.4f);
        using var bb    = shape.GetLocalBounds();
        using var size  = bb.GetSize();
        Assert.Equal(0.8f, size.GetX(), precision: 4);
        Assert.Equal(0.8f, size.GetZ(), precision: 4);
    }

    [Fact]
    public void CylinderShape_GetInnerRadius_IsPositive()
    {
        using var shape = new JPH.CylinderShape(0.5f, 0.4f);
        Assert.True(shape.GetInnerRadius() > 0f);
    }

    [Fact]
    public void CylinderShape_GetVolume_IsPositive()
    {
        using var shape = new JPH.CylinderShape(0.5f, 0.4f);
        Assert.True(shape.GetVolume() > 0f);
    }

    // -------------------------------------------------------------------------
    // CylinderShape — density
    // -------------------------------------------------------------------------

    [Fact]
    public void CylinderShape_GetDensity_DefaultIs1000()
    {
        using var shape = new JPH.CylinderShape(0.5f, 0.4f);
        Assert.Equal(1000f, shape.GetDensity(), precision: 3);
    }

    [Fact]
    public void CylinderShape_SetDensity_RoundTrips()
    {
        using var shape = new JPH.CylinderShape(0.5f, 0.4f);
        shape.SetDensity(600f);
        Assert.Equal(600f, shape.GetDensity(), precision: 3);
    }

    // -------------------------------------------------------------------------
    // Simulation
    // -------------------------------------------------------------------------

    [Fact]
    public void CylinderShape_DynamicBody_FallsDueToGravity()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var ss = new JPH.CylinderShapeSettings(0.5f, 0.4f);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_CylinderShapeSettings)ss);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 10f, 0f);
        var id = bi.CreateAndAddBody(cs, JPH.EActivation.Activate);

        for (int i = 0; i < 60; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        using var pos = bi.GetCenterOfMassPosition(id);
        Assert.True(pos.GetY() < 10f, $"Expected body to fall below y=10, got {pos.GetY()}");

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }
}
