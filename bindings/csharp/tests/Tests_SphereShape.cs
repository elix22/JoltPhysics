// Tests for JPH::SphereShapeSettings field defaults + round-trips and
// JPH::SphereShape direct construction with geometry getters and density.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_SphereShape(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // SphereShapeSettings — defaults
    // -------------------------------------------------------------------------

    [Fact]
    public void SphereShapeSettings_DefaultConstruct_DoesNotThrow()
    {
        using var s = new JPH.SphereShapeSettings();
        Assert.NotNull(s);
    }

    [Fact]
    public void SphereShapeSettings_ParameterizedConstruct_DoesNotThrow()
    {
        using var s = new JPH.SphereShapeSettings(0.5f);
        Assert.NotNull(s);
    }

    [Fact]
    public void SphereShapeSettings_mDensity_DefaultIs1000()
    {
        using var s = new JPH.SphereShapeSettings();
        Assert.Equal(1000f, s.mDensity, precision: 3);
    }

    // -------------------------------------------------------------------------
    // SphereShapeSettings — field round-trips
    // -------------------------------------------------------------------------

    [Fact]
    public void SphereShapeSettings_mRadius_RoundTrips()
    {
        using var s = new JPH.SphereShapeSettings();
        s.mRadius = 0.75f;
        Assert.Equal(0.75f, s.mRadius, precision: 5);
    }

    [Fact]
    public void SphereShapeSettings_mDensity_RoundTrips()
    {
        using var s = new JPH.SphereShapeSettings();
        s.mDensity = 800f;
        Assert.Equal(800f, s.mDensity, precision: 3);
    }

    [Fact]
    public void SphereShapeSettings_SetDensity_RoundTrips()
    {
        using var s = new JPH.SphereShapeSettings();
        s.SetDensity(500f);
        Assert.Equal(500f, s.mDensity, precision: 3);
    }

    // -------------------------------------------------------------------------
    // SphereShape — construction
    // -------------------------------------------------------------------------

    [Fact]
    public void SphereShape_DirectConstruct_DoesNotThrow()
    {
        using var shape = new JPH.SphereShape(0.5f);
        Assert.NotNull(shape);
    }

    // -------------------------------------------------------------------------
    // SphereShape — geometry getters
    // -------------------------------------------------------------------------

    [Fact]
    public void SphereShape_GetRadius_MatchesInput()
    {
        using var shape = new JPH.SphereShape(0.5f);
        Assert.Equal(0.5f, shape.GetRadius(), precision: 5);
    }

    [Fact]
    public void SphereShape_GetLocalBounds_DiameterMatchesRadius()
    {
        // Bounding box side = 2 * radius in every dimension
        using var shape = new JPH.SphereShape(1f);
        using var bb    = shape.GetLocalBounds();
        using var size  = bb.GetSize();
        Assert.Equal(2f, size.GetX(), precision: 4);
        Assert.Equal(2f, size.GetY(), precision: 4);
        Assert.Equal(2f, size.GetZ(), precision: 4);
    }

    [Fact]
    public void SphereShape_GetInnerRadius_EqualsRadius()
    {
        // For a sphere, inner radius == outer radius
        using var shape = new JPH.SphereShape(0.5f);
        Assert.Equal(0.5f, shape.GetInnerRadius(), precision: 4);
    }

    [Fact]
    public void SphereShape_GetVolume_IsPositive()
    {
        using var shape = new JPH.SphereShape(0.5f);
        Assert.True(shape.GetVolume() > 0f);
    }

    [Fact]
    public void SphereShape_GetVolume_UnitSphere_IsApprox4PiOver3()
    {
        // V = (4/3) * π * r^3 = 4.18879… for r = 1
        using var shape = new JPH.SphereShape(1f);
        Assert.Equal(4.189f, shape.GetVolume(), precision: 1);
    }

    [Fact]
    public void SphereShape_MustBeStatic_ReturnsFalse()
    {
        using var shape = new JPH.SphereShape(0.5f);
        Assert.False(shape.MustBeStatic());
    }

    // -------------------------------------------------------------------------
    // SphereShape — density
    // -------------------------------------------------------------------------

    [Fact]
    public void SphereShape_GetDensity_DefaultIs1000()
    {
        using var shape = new JPH.SphereShape(0.5f);
        Assert.Equal(1000f, shape.GetDensity(), precision: 3);
    }

    [Fact]
    public void SphereShape_SetDensity_RoundTrips()
    {
        using var shape = new JPH.SphereShape(0.5f);
        shape.SetDensity(600f);
        Assert.Equal(600f, shape.GetDensity(), precision: 3);
    }

    // -------------------------------------------------------------------------
    // Simulation
    // -------------------------------------------------------------------------

    [Fact]
    public void SphereShape_DynamicBody_FallsDueToGravity()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var ss = new JPH.SphereShapeSettings(0.5f);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
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
