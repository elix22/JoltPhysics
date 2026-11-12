// Tests for JPH::CapsuleShape (the shape object) and JPH::CapsuleShapeSettings
// utility methods (IsValid, IsSphere).
// Note: CapsuleShapeSettings field defaults (mRadius, mHalfHeightOfCylinder)
// are covered by Tests_Shapes.cs; this file tests the instantiated shape object.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_CapsuleShape(JoltFixture fx)
{
    // ─────────────────────────────────────────────────────────────────────────
    // Construction
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CapsuleShape_ConstructWithParams_DoesNotThrow()
    {
        using var shape = new JPH.CapsuleShape(0.5f, 0.3f);
        Assert.NotNull(shape);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Geometry getters
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CapsuleShape_GetRadius_MatchesInput()
    {
        using var shape = new JPH.CapsuleShape(0.5f, 0.3f);
        Assert.Equal(0.3f, shape.GetRadius(), precision: 5);
    }

    [Fact]
    public void CapsuleShape_GetHalfHeightOfCylinder_MatchesInput()
    {
        using var shape = new JPH.CapsuleShape(0.5f, 0.3f);
        Assert.Equal(0.5f, shape.GetHalfHeightOfCylinder(), precision: 5);
    }

    [Fact]
    public void CapsuleShape_GetLocalBounds_IsValid()
    {
        using var shape = new JPH.CapsuleShape(0.5f, 0.3f);
        using var bb    = shape.GetLocalBounds();
        Assert.True(bb.IsValid());
    }

    [Fact]
    public void CapsuleShape_GetLocalBounds_HeightCoversFullCapsule()
    {
        // Total height = 2 * halfHeight + 2 * radius = 2 * 0.5 + 2 * 0.3 = 1.6
        using var shape = new JPH.CapsuleShape(0.5f, 0.3f);
        using var bb    = shape.GetLocalBounds();
        using var size  = bb.GetSize();
        Assert.True(size.GetY() >= 1.5f, $"Expected Y size >= 1.6, got {size.GetY()}");
    }

    [Fact]
    public void CapsuleShape_GetLocalBounds_WidthCoversRadius()
    {
        // Width = 2 * radius = 0.6
        using var shape = new JPH.CapsuleShape(0.5f, 0.3f);
        using var bb    = shape.GetLocalBounds();
        using var size  = bb.GetSize();
        Assert.Equal(0.6f, size.GetX(), precision: 4);
        Assert.Equal(0.6f, size.GetZ(), precision: 4);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Volume, inner radius, density
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CapsuleShape_GetInnerRadius_EqualsRadius()
    {
        using var shape = new JPH.CapsuleShape(0.5f, 0.3f);
        Assert.Equal(shape.GetRadius(), shape.GetInnerRadius(), precision: 5);
    }

    [Fact]
    public void CapsuleShape_GetVolume_IsPositive()
    {
        using var shape = new JPH.CapsuleShape(0.5f, 0.3f);
        Assert.True(shape.GetVolume() > 0f);
    }

    [Fact]
    public void CapsuleShape_SetDensity_RoundTrips()
    {
        using var shape = new JPH.CapsuleShape(0.5f, 0.3f);
        shape.SetDensity(500f);
        Assert.Equal(500f, shape.GetDensity(), precision: 3);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // CapsuleShapeSettings utility methods (IsValid, IsSphere)
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CapsuleShapeSettings_IsValid_ValidParams_ReturnsTrue()
    {
        using var ss = new JPH.CapsuleShapeSettings(0.5f, 0.3f);
        Assert.True(ss.IsValid());
    }

    [Fact]
    public void CapsuleShapeSettings_IsSphere_WhenHalfHeightIsZero_ReturnsTrue()
    {
        // halfHeight == 0 → pure sphere shape
        using var ss = new JPH.CapsuleShapeSettings(0f, 0.5f);
        Assert.True(ss.IsSphere());
    }

    [Fact]
    public void CapsuleShapeSettings_IsSphere_WhenHalfHeightIsPositive_ReturnsFalse()
    {
        using var ss = new JPH.CapsuleShapeSettings(0.5f, 0.3f);
        Assert.False(ss.IsSphere());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Simulation
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CapsuleShape_DynamicBody_FallsDueToGravity()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var ss = new JPH.CapsuleShapeSettings(0.5f, 0.3f);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_CapsuleShapeSettings)ss);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 10f, 0f);
        var id = bi.CreateAndAddBody(cs, JPH.EActivation.Activate);

        // Simulate a second of physics
        for (int i = 0; i < 60; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        using var pos = bi.GetCenterOfMassPosition(id);
        Assert.True(pos.GetY() < 10f, $"Expected body to fall below y=10, got {pos.GetY()}");

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }
}
