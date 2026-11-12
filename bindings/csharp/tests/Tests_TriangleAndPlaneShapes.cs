// Tests for JPH::TriangleShape (geometry queries, settings fields) and
// JPH::PlaneShape (construction, geometry queries).

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_TriangleAndPlaneShapes
{
    // ─────────────────────────────────────────────────────────────────────────
    // TriangleShape — construction
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TriangleShape_Construct_DoesNotThrow()
    {
        using var v1    = new JPH.Vec3(0f, 0f, 0f);
        using var v2    = new JPH.Vec3(1f, 0f, 0f);
        using var v3    = new JPH.Vec3(0f, 0f, 1f);
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        Assert.NotNull(shape);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // TriangleShape — geometry getters
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TriangleShape_GetVertex1_MatchesInput()
    {
        using var v1    = new JPH.Vec3(1f, 2f, 3f);
        using var v2    = new JPH.Vec3(4f, 0f, 0f);
        using var v3    = new JPH.Vec3(0f, 0f, 4f);
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        using var got   = shape.GetVertex1();
        Assert.Equal(1f, got.GetX(), precision: 4);
        Assert.Equal(2f, got.GetY(), precision: 4);
        Assert.Equal(3f, got.GetZ(), precision: 4);
    }

    [Fact]
    public void TriangleShape_GetVertex2_MatchesInput()
    {
        using var v1    = new JPH.Vec3(0f, 0f, 0f);
        using var v2    = new JPH.Vec3(1f, 0f, 0f);
        using var v3    = new JPH.Vec3(0f, 0f, 1f);
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        using var got   = shape.GetVertex2();
        Assert.Equal(1f, got.GetX(), precision: 4);
        Assert.Equal(0f, got.GetY(), precision: 4);
        Assert.Equal(0f, got.GetZ(), precision: 4);
    }

    [Fact]
    public void TriangleShape_GetVertex3_MatchesInput()
    {
        using var v1    = new JPH.Vec3(0f, 0f, 0f);
        using var v2    = new JPH.Vec3(1f, 0f, 0f);
        using var v3    = new JPH.Vec3(0f, 0f, 1f);
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        using var got   = shape.GetVertex3();
        Assert.Equal(0f, got.GetX(), precision: 4);
        Assert.Equal(0f, got.GetY(), precision: 4);
        Assert.Equal(1f, got.GetZ(), precision: 4);
    }

    [Fact]
    public void TriangleShape_GetLocalBounds_IsValid()
    {
        using var v1    = new JPH.Vec3(0f, 0f, 0f);
        using var v2    = new JPH.Vec3(1f, 0f, 0f);
        using var v3    = new JPH.Vec3(0f, 0f, 1f);
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        using var bb    = shape.GetLocalBounds();
        Assert.True(bb.IsValid());
    }

    [Fact]
    public void TriangleShape_GetConvexRadius_IsNonNegative()
    {
        using var v1    = new JPH.Vec3(0f, 0f, 0f);
        using var v2    = new JPH.Vec3(1f, 0f, 0f);
        using var v3    = new JPH.Vec3(0f, 0f, 1f);
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        Assert.True(shape.GetConvexRadius() >= 0f);
    }

    [Fact]
    public void TriangleShape_GetInnerRadius_IsNonNegative()
    {
        // Triangle is a 2D degenerate shape (no volume) so inner radius may be 0
        using var v1    = new JPH.Vec3(0f, 0f, 0f);
        using var v2    = new JPH.Vec3(2f, 0f, 0f);
        using var v3    = new JPH.Vec3(0f, 0f, 2f);
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        Assert.True(shape.GetInnerRadius() >= 0f);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // TriangleShapeSettings — field round-trips
    // Note: field names are mv1/mv2/mv3 (lowercase v), NOT mV1/mV2/mV3
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TriangleShapeSettings_mv1_RoundTrips()
    {
        using var s  = new JPH.TriangleShapeSettings();
        using var w1 = s.mv1;
        w1.Set(1f, 2f, 3f);
        using var got = s.mv1;
        Assert.Equal(1f, got.GetX(), precision: 4);
        Assert.Equal(2f, got.GetY(), precision: 4);
        Assert.Equal(3f, got.GetZ(), precision: 4);
    }

    [Fact]
    public void TriangleShapeSettings_mv2_RoundTrips()
    {
        using var s  = new JPH.TriangleShapeSettings();
        using var w2 = s.mv2;
        w2.Set(4f, 5f, 6f);
        using var got = s.mv2;
        Assert.Equal(4f, got.GetX(), precision: 4);
        Assert.Equal(5f, got.GetY(), precision: 4);
        Assert.Equal(6f, got.GetZ(), precision: 4);
    }

    [Fact]
    public void TriangleShapeSettings_mv3_RoundTrips()
    {
        using var s  = new JPH.TriangleShapeSettings();
        using var w3 = s.mv3;
        w3.Set(7f, 8f, 9f);
        using var got = s.mv3;
        Assert.Equal(7f, got.GetX(), precision: 4);
        Assert.Equal(8f, got.GetY(), precision: 4);
        Assert.Equal(9f, got.GetZ(), precision: 4);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // PlaneShape — construction
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void PlaneShape_Construct_DoesNotThrow()
    {
        using var normal = new JPH.Vec3(0f, 1f, 0f);
        using var plane  = new JPH.Plane(normal, 0f);
        using var shape  = new JPH.PlaneShape(plane);
        Assert.NotNull(shape);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // PlaneShape — geometry getters
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void PlaneShape_GetPlane_NormalMatchesInput()
    {
        using var normal = new JPH.Vec3(0f, 1f, 0f);
        using var plane  = new JPH.Plane(normal, 0f);
        using var shape  = new JPH.PlaneShape(plane);
        var       got    = shape.GetPlane();   // non-owning — do not use 'using'
        using var n      = got.GetNormal();
        Assert.Equal(0f, n.GetX(), precision: 4);
        Assert.Equal(1f, n.GetY(), precision: 4);
        Assert.Equal(0f, n.GetZ(), precision: 4);
    }

    [Fact]
    public void PlaneShape_GetPlane_ConstantMatchesInput()
    {
        using var normal = new JPH.Vec3(0f, 1f, 0f);
        using var plane  = new JPH.Plane(normal, -3f);
        using var shape  = new JPH.PlaneShape(plane);
        var got = shape.GetPlane();
        Assert.Equal(-3f, got.GetConstant(), precision: 4);
    }

    [Fact]
    public void PlaneShape_GetHalfExtent_DefaultIsLarge()
    {
        // cDefaultHalfExtent = 1000.0f
        using var normal = new JPH.Vec3(0f, 1f, 0f);
        using var plane  = new JPH.Plane(normal, 0f);
        using var shape  = new JPH.PlaneShape(plane);
        Assert.True(shape.GetHalfExtent() > 100f);
    }

    [Fact]
    public void PlaneShape_GetHalfExtent_ExplicitValueRoundTrips()
    {
        using var normal = new JPH.Vec3(0f, 1f, 0f);
        using var plane  = new JPH.Plane(normal, 0f);
        using var shape  = new JPH.PlaneShape(plane, null, 50f);
        Assert.Equal(50f, shape.GetHalfExtent(), precision: 3);
    }

    [Fact]
    public void PlaneShape_GetLocalBounds_IsValid()
    {
        using var normal = new JPH.Vec3(0f, 1f, 0f);
        using var plane  = new JPH.Plane(normal, 0f);
        using var shape  = new JPH.PlaneShape(plane, null, 10f);
        using var bb     = shape.GetLocalBounds();
        Assert.True(bb.IsValid());
    }
}
