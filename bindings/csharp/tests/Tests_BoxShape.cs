// Tests for JPH::BoxShapeSettings field defaults + round-trips and
// JPH::BoxShape direct construction with geometry getters and density.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_BoxShape(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // BoxShapeSettings — defaults
    // -------------------------------------------------------------------------

    [Fact]
    public void BoxShapeSettings_DefaultConstruct_DoesNotThrow()
    {
        using var s = new JPH.BoxShapeSettings();
        Assert.NotNull(s);
    }

    [Fact]
    public void BoxShapeSettings_ParameterizedConstruct_DoesNotThrow()
    {
        using var he = new JPH.Vec3(1f, 2f, 3f);
        using var s  = new JPH.BoxShapeSettings(he);
        Assert.NotNull(s);
    }

    [Fact]
    public void BoxShapeSettings_Density_DefaultIs1000()
    {
        using var s = new JPH.BoxShapeSettings();
        Assert.Equal(1000f, s.mDensity, precision: 3);
    }

    // -------------------------------------------------------------------------
    // BoxShapeSettings — field round-trips
    // -------------------------------------------------------------------------

    [Fact]
    public void BoxShapeSettings_mHalfExtent_RoundTrips()
    {
        using var s = new JPH.BoxShapeSettings();
        s.mHalfExtent.Set(2f, 3f, 4f);
        var he = s.mHalfExtent;
        Assert.Equal(2f, he.GetX(), precision: 4);
        Assert.Equal(3f, he.GetY(), precision: 4);
        Assert.Equal(4f, he.GetZ(), precision: 4);
    }

    [Fact]
    public void BoxShapeSettings_mConvexRadius_RoundTrips()
    {
        using var s = new JPH.BoxShapeSettings();
        s.mConvexRadius = 0.05f;
        Assert.Equal(0.05f, s.mConvexRadius, precision: 5);
    }

    [Fact]
    public void BoxShapeSettings_mDensity_RoundTrips()
    {
        using var s = new JPH.BoxShapeSettings();
        s.mDensity = 800f;
        Assert.Equal(800f, s.mDensity, precision: 3);
    }

    [Fact]
    public void BoxShapeSettings_SetDensity_RoundTrips()
    {
        using var s = new JPH.BoxShapeSettings();
        s.SetDensity(500f);
        Assert.Equal(500f, s.mDensity, precision: 3);
    }

    // -------------------------------------------------------------------------
    // BoxShape — construction
    // -------------------------------------------------------------------------

    [Fact]
    public void BoxShape_DirectConstruct_DoesNotThrow()
    {
        using var he    = new JPH.Vec3(1f, 1f, 1f);
        using var shape = new JPH.BoxShape(he, 0f);
        Assert.NotNull(shape);
    }

    // -------------------------------------------------------------------------
    // BoxShape — geometry getters
    // -------------------------------------------------------------------------

    [Fact]
    public void BoxShape_GetHalfExtent_MatchesInput()
    {
        using var he    = new JPH.Vec3(1f, 2f, 3f);
        using var shape = new JPH.BoxShape(he, 0f);
        using var got   = shape.GetHalfExtent();
        Assert.Equal(1f, got.GetX(), precision: 4);
        Assert.Equal(2f, got.GetY(), precision: 4);
        Assert.Equal(3f, got.GetZ(), precision: 4);
    }

    [Fact]
    public void BoxShape_GetConvexRadius_MatchesInput()
    {
        using var he    = new JPH.Vec3(1f, 1f, 1f);
        using var shape = new JPH.BoxShape(he, 0.05f);
        Assert.Equal(0.05f, shape.GetConvexRadius(), precision: 5);
    }

    [Fact]
    public void BoxShape_GetLocalBounds_ReflectsHalfExtent()
    {
        // With convexRadius=0, bounding box size = 2 * halfExtent in each dim
        using var he    = new JPH.Vec3(1f, 2f, 3f);
        using var shape = new JPH.BoxShape(he, 0f);
        using var bb    = shape.GetLocalBounds();
        using var size  = bb.GetSize();
        Assert.Equal(2f, size.GetX(), precision: 3);
        Assert.Equal(4f, size.GetY(), precision: 3);
        Assert.Equal(6f, size.GetZ(), precision: 3);
    }

    [Fact]
    public void BoxShape_GetInnerRadius_IsPositive()
    {
        using var he    = new JPH.Vec3(1f, 1f, 1f);
        using var shape = new JPH.BoxShape(he, 0f);
        Assert.True(shape.GetInnerRadius() > 0f);
    }

    [Fact]
    public void BoxShape_GetVolume_IsPositive()
    {
        using var he    = new JPH.Vec3(1f, 2f, 3f);
        using var shape = new JPH.BoxShape(he, 0f);
        Assert.True(shape.GetVolume() > 0f);
    }

    [Fact]
    public void BoxShape_GetVolume_Is8ForUnitBox()
    {
        // halfExtent = (1,1,1) with convexRadius=0 → volume = 2*2*2 = 8
        using var he    = new JPH.Vec3(1f, 1f, 1f);
        using var shape = new JPH.BoxShape(he, 0f);
        Assert.Equal(8f, shape.GetVolume(), precision: 3);
    }

    [Fact]
    public void BoxShape_MustBeStatic_ReturnsFalse()
    {
        using var he    = new JPH.Vec3(1f, 1f, 1f);
        using var shape = new JPH.BoxShape(he, 0f);
        Assert.False(shape.MustBeStatic());
    }

    // -------------------------------------------------------------------------
    // BoxShape — density
    // -------------------------------------------------------------------------

    [Fact]
    public void BoxShape_GetDensity_DefaultIs1000()
    {
        using var he    = new JPH.Vec3(1f, 1f, 1f);
        using var shape = new JPH.BoxShape(he, 0f);
        Assert.Equal(1000f, shape.GetDensity(), precision: 3);
    }

    [Fact]
    public void BoxShape_SetDensity_RoundTrips()
    {
        using var he    = new JPH.Vec3(1f, 1f, 1f);
        using var shape = new JPH.BoxShape(he, 0f);
        shape.SetDensity(600f);
        Assert.Equal(600f, shape.GetDensity(), precision: 3);
    }

    // -------------------------------------------------------------------------
    // Simulation
    // -------------------------------------------------------------------------

    [Fact]
    public void BoxShape_StaticBody_CanBeCreated()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var he = new JPH.Vec3(5f, 0.5f, 5f);
        using var ss = new JPH.BoxShapeSettings(he);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_BoxShapeSettings)ss);
        cs.mMotionType  = JPH.EMotionType.Static;
        cs.mObjectLayer = JoltFixture.LayerNonMoving;
        cs.mPosition.Set(0f, 0f, 0f);
        var id = bi.CreateAndAddBody(cs, JPH.EActivation.DontActivate);

        Assert.False(id.IsInvalid());

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void BoxShape_DynamicBody_FallsDueToGravity()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var he = new JPH.Vec3(0.5f, 0.5f, 0.5f);
        using var ss = new JPH.BoxShapeSettings(he);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_BoxShapeSettings)ss);
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
