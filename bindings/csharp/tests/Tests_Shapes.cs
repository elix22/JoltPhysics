// Tests for shape settings construction, property round-trips, and lifecycle.
// Each shape type is constructed, its fields verified, and it is disposed
// cleanly — exercising the ref-count AddRef/Release path.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Shapes
{
    // -------------------------------------------------------------------------
    // BoxShapeSettings
    // -------------------------------------------------------------------------

    [Fact]
    public void BoxShapeSettings_DefaultConstruct_DoesNotThrow()
    {
        using var s = new JPH.BoxShapeSettings();
        Assert.NotNull(s);
    }

    [Fact]
    public void BoxShapeSettings_ConstructWithHalfExtent_StoresValues()
    {
        using var half = new JPH.Vec3(1f, 2f, 3f);
        using var s    = new JPH.BoxShapeSettings(half);
        // Read back via the mutable half-extent field.
        using var got = s.mHalfExtent;
        Assert.Equal(1f, got.GetX(), precision: 4);
        Assert.Equal(2f, got.GetY(), precision: 4);
        Assert.Equal(3f, got.GetZ(), precision: 4);
    }

    [Fact]
    public void BoxShapeSettings_ConvexRadiusDefault_IsNonNegative()
    {
        using var half = new JPH.Vec3(1f, 1f, 1f);
        using var s    = new JPH.BoxShapeSettings(half);
        Assert.True(s.mConvexRadius >= 0f);
    }

    // -------------------------------------------------------------------------
    // SphereShapeSettings
    // -------------------------------------------------------------------------

    [Fact]
    public void SphereShapeSettings_DefaultConstruct_RadiusIsZeroOrPositive()
    {
        using var s = new JPH.SphereShapeSettings();
        Assert.True(s.mRadius >= 0f);
    }

    [Fact]
    public void SphereShapeSettings_SetRadius_RoundTrips()
    {
        using var s = new JPH.SphereShapeSettings();
        s.mRadius = 2.5f;
        Assert.Equal(2.5f, s.mRadius, precision: 5);
    }

    [Theory]
    [InlineData(0.1f)]
    [InlineData(1.0f)]
    [InlineData(100.0f)]
    public void SphereShapeSettings_VariousRadii_RoundTrip(float r)
    {
        using var s = new JPH.SphereShapeSettings();
        s.mRadius = r;
        Assert.Equal(r, s.mRadius, precision: 5);
    }

    // -------------------------------------------------------------------------
    // CapsuleShapeSettings
    // -------------------------------------------------------------------------

    [Fact]
    public void CapsuleShapeSettings_DefaultConstruct_DoesNotThrow()
    {
        using var s = new JPH.CapsuleShapeSettings();
        Assert.NotNull(s);
    }

    [Fact]
    public void CapsuleShapeSettings_SetFields_RoundTrip()
    {
        using var s = new JPH.CapsuleShapeSettings();
        s.mRadius     = 0.4f;
        s.mHalfHeightOfCylinder = 1.0f;
        Assert.Equal(0.4f, s.mRadius,     precision: 5);
        Assert.Equal(1.0f, s.mHalfHeightOfCylinder, precision: 5);
    }

    // -------------------------------------------------------------------------
    // CylinderShapeSettings
    // -------------------------------------------------------------------------

    [Fact]
    public void CylinderShapeSettings_SetFields_RoundTrip()
    {
        using var s = new JPH.CylinderShapeSettings();
        s.mRadius     = 0.3f;
        s.mHalfHeight = 0.8f;
        Assert.Equal(0.3f, s.mRadius,     precision: 5);
        Assert.Equal(0.8f, s.mHalfHeight, precision: 5);
    }

    // -------------------------------------------------------------------------
    // Multiple shapes constructed then disposed (stress the ref-count path)
    // -------------------------------------------------------------------------

    [Fact]
    public void MultipleShapeSettings_ConstructAndDisposeRepeatedly_NoLeak()
    {
        for (int i = 0; i < 100; i++)
        {
            using var ss = new JPH.SphereShapeSettings();
            ss.mRadius = i * 0.1f + 0.1f;
            using var bs = new JPH.BoxShapeSettings(new JPH.Vec3(1f, 1f, 1f));
        }
        // If ref-counting is broken, Jolt's destructor assertion fires before
        // we reach this line.
        Assert.True(true);
    }
}
