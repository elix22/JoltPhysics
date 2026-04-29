// Tests for concrete shape objects: geometry queries (volume, bounds, inner
// radius, center of mass, density) and type-specific accessors.
// Mirrors coverage in JoltPhysics/UnitTests/Physics/ShapeTests.cpp.

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_ShapeGeometry
{
    const float Eps = 1e-4f;

    // ─────────────────────────────────────────────────────────────────────────
    // BoxShape
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void BoxShape_GetHalfExtent_RoundTrips()
    {
        using var half  = new JPH.Vec3(1f, 2f, 3f);
        using var shape = new JPH.BoxShape(half);
        using var got   = shape.GetHalfExtent();
        Assert.Equal(1f, got.GetX(), precision: 4);
        Assert.Equal(2f, got.GetY(), precision: 4);
        Assert.Equal(3f, got.GetZ(), precision: 4);
    }

    [Fact]
    public void BoxShape_Volume_MatchesFormula()
    {
        // V = (2*hx)*(2*hy)*(2*hz)
        using var half  = new JPH.Vec3(1f, 2f, 3f);
        using var shape = new JPH.BoxShape(half);
        float v = shape.GetVolume();
        Assert.Equal(48f, v, precision: 3);
    }

    [Fact]
    public void BoxShape_InnerRadius_LessThanOrEqualToSmallestHalfExtent()
    {
        using var half  = new JPH.Vec3(1f, 2f, 3f);
        using var shape = new JPH.BoxShape(half);
        Assert.True(shape.GetInnerRadius() <= 1f);
    }

    [Fact]
    public void BoxShape_DefaultDensity_IsPositive()
    {
        using var half  = new JPH.Vec3(0.5f, 0.5f, 0.5f);
        using var shape = new JPH.BoxShape(half);
        Assert.True(shape.GetDensity() > 0f);
    }

    [Fact]
    public void BoxShape_SetDensity_RoundTrips()
    {
        using var half  = new JPH.Vec3(0.5f, 0.5f, 0.5f);
        using var shape = new JPH.BoxShape(half);
        shape.SetDensity(500f);
        Assert.Equal(500f, shape.GetDensity(), precision: 3);
    }

    [Fact]
    public void BoxShape_GetLocalBounds_IsValid()
    {
        using var half  = new JPH.Vec3(1f, 1f, 1f);
        using var shape = new JPH.BoxShape(half);
        using var bb    = shape.GetLocalBounds();
        Assert.True(bb.IsValid());
        using var size  = bb.GetSize();
        // Each dimension should be 2 * half-extent = 2
        Assert.Equal(2f, size.GetX(), precision: 3);
        Assert.Equal(2f, size.GetY(), precision: 3);
        Assert.Equal(2f, size.GetZ(), precision: 3);
    }

    [Fact]
    public void BoxShape_GetCenterOfMass_IsOriginForSymmetricBox()
    {
        using var half  = new JPH.Vec3(1f, 1f, 1f);
        using var shape = new JPH.BoxShape(half);
        using var com   = shape.GetCenterOfMass();
        Assert.Equal(0f, com.GetX(), precision: 5);
        Assert.Equal(0f, com.GetY(), precision: 5);
        Assert.Equal(0f, com.GetZ(), precision: 5);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // SphereShape
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void SphereShape_GetRadius_RoundTrips()
    {
        using var shape = new JPH.SphereShape(2.5f);
        Assert.Equal(2.5f, shape.GetRadius(), precision: 5);
    }

    [Fact]
    public void SphereShape_InnerRadius_EqualsRadius()
    {
        // For a sphere the inner radius equals the sphere radius
        using var shape = new JPH.SphereShape(1.5f);
        Assert.Equal(shape.GetRadius(), shape.GetInnerRadius(), precision: 5);
    }

    [Fact]
    public void SphereShape_Volume_MatchesFormula()
    {
        float r = 2f;
        using var shape = new JPH.SphereShape(r);
        float expected  = (4f / 3f) * MathF.PI * r * r * r;
        Assert.Equal(expected, shape.GetVolume(), precision: 2);
    }

    [Fact]
    public void SphereShape_GetCenterOfMass_IsOrigin()
    {
        using var shape = new JPH.SphereShape(1f);
        using var com   = shape.GetCenterOfMass();
        Assert.Equal(0f, com.GetX(), precision: 5);
        Assert.Equal(0f, com.GetY(), precision: 5);
        Assert.Equal(0f, com.GetZ(), precision: 5);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // CapsuleShape
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CapsuleShape_GetRadius_RoundTrips()
    {
        using var shape = new JPH.CapsuleShape(1f, 0.5f);
        Assert.Equal(0.5f, shape.GetRadius(), precision: 5);
    }

    [Fact]
    public void CapsuleShape_GetHalfHeight_RoundTrips()
    {
        using var shape = new JPH.CapsuleShape(1.5f, 0.5f);
        Assert.Equal(1.5f, shape.GetHalfHeightOfCylinder(), precision: 5);
    }

    [Fact]
    public void CapsuleShape_InnerRadius_EqualsRadius()
    {
        using var shape = new JPH.CapsuleShape(1f, 0.4f);
        Assert.Equal(shape.GetRadius(), shape.GetInnerRadius(), precision: 5);
    }

    [Fact]
    public void CapsuleShape_Volume_IsPositive()
    {
        using var shape = new JPH.CapsuleShape(1f, 0.5f);
        Assert.True(shape.GetVolume() > 0f);
    }

    [Fact]
    public void CapsuleShape_GetCenterOfMass_IsOrigin()
    {
        using var shape = new JPH.CapsuleShape(1f, 0.5f);
        using var com   = shape.GetCenterOfMass();
        Assert.Equal(0f, com.GetX(), precision: 5);
        Assert.Equal(0f, com.GetY(), precision: 5);
        Assert.Equal(0f, com.GetZ(), precision: 5);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // CylinderShape
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CylinderShape_GetHalfHeight_RoundTrips()
    {
        using var shape = new JPH.CylinderShape(2f, 1f);
        Assert.Equal(2f, shape.GetHalfHeight(), precision: 5);
    }

    [Fact]
    public void CylinderShape_GetRadius_RoundTrips()
    {
        using var shape = new JPH.CylinderShape(2f, 1f);
        Assert.Equal(1f, shape.GetRadius(), precision: 5);
    }

    [Fact]
    public void CylinderShape_Volume_MatchesFormula()
    {
        float h = 2f, r = 1f;
        using var shape    = new JPH.CylinderShape(h, r);
        float expected     = MathF.PI * r * r * (2f * h);
        Assert.Equal(expected, shape.GetVolume(), precision: 2);
    }

    [Fact]
    public void CylinderShape_GetCenterOfMass_IsOrigin()
    {
        using var shape = new JPH.CylinderShape(1f, 0.5f);
        using var com   = shape.GetCenterOfMass();
        Assert.Equal(0f, com.GetX(), precision: 5);
        Assert.Equal(0f, com.GetY(), precision: 5);
        Assert.Equal(0f, com.GetZ(), precision: 5);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // RotatedTranslatedShape
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void RotatedTranslatedShape_GetPosition_RoundTrips()
    {
        using var inner = new JPH.SphereShape(0.5f);
        using var pos   = new JPH.Vec3(1f, 2f, 3f);
        using var rot   = JPH.Quat.SIdentity();
        using var shape = new JPH.RotatedTranslatedShape(pos, rot, (JPH.Const_SphereShape)inner);
        using var got   = shape.GetPosition();
        Assert.Equal(1f, got.GetX(), precision: 4);
        Assert.Equal(2f, got.GetY(), precision: 4);
        Assert.Equal(3f, got.GetZ(), precision: 4);
    }

    [Fact]
    public void RotatedTranslatedShape_GetRotation_IdentityRoundTrips()
    {
        using var inner = new JPH.SphereShape(0.5f);
        using var pos   = new JPH.Vec3(0f, 0f, 0f);
        using var rot   = JPH.Quat.SIdentity();
        using var shape = new JPH.RotatedTranslatedShape(pos, rot, (JPH.Const_SphereShape)inner);
        using var got   = shape.GetRotation();
        using var id    = JPH.Quat.SIdentity();
        Assert.Equal(id.GetX(), got.GetX(), precision: 5);
        Assert.Equal(id.GetY(), got.GetY(), precision: 5);
        Assert.Equal(id.GetZ(), got.GetZ(), precision: 5);
        Assert.Equal(id.GetW(), got.GetW(), precision: 5);
    }

    [Fact]
    public void RotatedTranslatedShape_GetInnerShape_IsNotNull()
    {
        using var inner = new JPH.SphereShape(0.5f);
        using var pos   = new JPH.Vec3(0f, 0f, 0f);
        using var rot   = JPH.Quat.SIdentity();
        using var shape = new JPH.RotatedTranslatedShape(pos, rot, (JPH.Const_SphereShape)inner);
        var got = shape.GetInnerShape();
        Assert.NotNull(got);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // ScaledShape
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void ScaledShape_GetScale_RoundTrips()
    {
        using var inner = new JPH.SphereShape(0.5f);
        using var scale = new JPH.Vec3(2f, 2f, 2f);
        using var shape = new JPH.ScaledShape((JPH.Const_SphereShape)inner, scale);
        using var got   = shape.GetScale();
        Assert.Equal(2f, got.GetX(), precision: 5);
        Assert.Equal(2f, got.GetY(), precision: 5);
        Assert.Equal(2f, got.GetZ(), precision: 5);
    }

    [Fact]
    public void ScaledShape_Volume_ScalesCubed()
    {
        // Scaling uniformly by k scales volume by k^3
        using var inner  = new JPH.SphereShape(1f);
        float     k      = 2f;
        using var scale  = new JPH.Vec3(k, k, k);
        using var shape  = new JPH.ScaledShape((JPH.Const_SphereShape)inner, scale);
        float vOrig      = inner.GetVolume();
        float vScaled    = shape.GetVolume();
        Assert.Equal(vOrig * k * k * k, vScaled, precision: 2);
    }

    [Fact]
    public void ScaledShape_GetInnerShape_IsNotNull()
    {
        using var inner = new JPH.BoxShape(new JPH.Vec3(1f, 1f, 1f));
        using var scale = new JPH.Vec3(1f, 1f, 1f);
        using var shape = new JPH.ScaledShape((JPH.Const_BoxShape)inner, scale);
        var got = shape.GetInnerShape();
        Assert.NotNull(got);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // OffsetCenterOfMassShape
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void OffsetCOMShape_GetOffset_RoundTrips()
    {
        using var inner  = new JPH.SphereShape(0.5f);
        using var offset = new JPH.Vec3(1f, 2f, 3f);
        using var shape  = new JPH.OffsetCenterOfMassShape((JPH.Const_SphereShape)inner, offset);
        using var got    = shape.GetOffset();
        Assert.Equal(1f, got.GetX(), precision: 4);
        Assert.Equal(2f, got.GetY(), precision: 4);
        Assert.Equal(3f, got.GetZ(), precision: 4);
    }

    [Fact]
    public void OffsetCOMShape_GetCenterOfMass_EqualsOffset()
    {
        // For a sphere centred at origin, offsetting its COM by (1,2,3) should
        // shift the shape's reported center of mass by that amount.
        using var inner  = new JPH.SphereShape(0.5f);
        using var offset = new JPH.Vec3(1f, 2f, 3f);
        using var shape  = new JPH.OffsetCenterOfMassShape((JPH.Const_SphereShape)inner, offset);
        using var com    = shape.GetCenterOfMass();
        Assert.Equal(1f, com.GetX(), precision: 4);
        Assert.Equal(2f, com.GetY(), precision: 4);
        Assert.Equal(3f, com.GetZ(), precision: 4);
    }

    [Fact]
    public void OffsetCOMShape_GetInnerShape_IsNotNull()
    {
        using var inner  = new JPH.SphereShape(0.5f);
        using var offset = new JPH.Vec3(0f, 0f, 0f);
        using var shape  = new JPH.OffsetCenterOfMassShape((JPH.Const_SphereShape)inner, offset);
        var got = shape.GetInnerShape();
        Assert.NotNull(got);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Shape inner radius — cross-type checks (mirrors ShapeTests.cpp)
    // ─────────────────────────────────────────────────────────────────────────

    [Theory]
    [InlineData(0.5f)]
    [InlineData(1.0f)]
    [InlineData(2.0f)]
    public void SphereShape_InnerRadius_EqualsRadius_MultipleValues(float r)
    {
        using var shape = new JPH.SphereShape(r);
        Assert.Equal(r, shape.GetInnerRadius(), precision: 5);
    }

    [Theory]
    [InlineData(1f, 0.5f, 0.3f)]  // min half-extent = 0.3 (minus convex radius)
    [InlineData(2f, 2f, 2f)]
    public void BoxShape_InnerRadius_LessThanOrEqualSmallestExtent(float hx, float hy, float hz)
    {
        using var half  = new JPH.Vec3(hx, hy, hz);
        using var shape = new JPH.BoxShape(half);
        float minHalf   = MathF.Min(hx, MathF.Min(hy, hz));
        Assert.True(shape.GetInnerRadius() <= minHalf + Eps);
        Assert.True(shape.GetInnerRadius() > 0f);
    }
}
