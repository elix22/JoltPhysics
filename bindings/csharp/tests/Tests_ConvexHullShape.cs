// Tests for JPH::ConvexHullShapeSettings field defaults / round-trips and
// JPH::ConvexHullShape queries on a default-constructed instance.
// Note: The points-based constructor is not tested because Vec3 is an opaque
// heap type in the C binding and a contiguous C array cannot be built from C#.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_ConvexHullShape(JoltFixture fx)
{
    // ── ConvexHullShapeSettings — defaults ────────────────────────────────────

    [Fact]
    public void ConvexHullShapeSettings_DefaultConstruct_NoCrash()
    {
        using var s = new JPH.ConvexHullShapeSettings();
        Assert.NotNull(s);
    }

    [Fact]
    public void ConvexHullShapeSettings_Default_mMaxConvexRadius_IsZero()
    {
        using var s = new JPH.ConvexHullShapeSettings();
        Assert.Equal(0.0f, s.mMaxConvexRadius);
    }

    [Fact]
    public void ConvexHullShapeSettings_Default_mMaxErrorConvexRadius_Is0_05()
    {
        using var s = new JPH.ConvexHullShapeSettings();
        Assert.Equal(0.05f, s.mMaxErrorConvexRadius, precision: 5);
    }

    [Fact]
    public void ConvexHullShapeSettings_Default_mHullTolerance_Is0_001()
    {
        using var s = new JPH.ConvexHullShapeSettings();
        Assert.Equal(1e-3f, s.mHullTolerance, precision: 5);
    }

    [Fact]
    public void ConvexHullShapeSettings_Default_mDensity_Is1000()
    {
        using var s = new JPH.ConvexHullShapeSettings();
        Assert.Equal(1000.0f, s.mDensity);
    }

    [Fact]
    public void ConvexHullShapeSettings_Default_mUserData_IsZero()
    {
        using var s = new JPH.ConvexHullShapeSettings();
        Assert.Equal((UIntPtr)0u, s.mUserData);
    }

    // ── ConvexHullShapeSettings — field round-trips ───────────────────────────

    [Fact]
    public void ConvexHullShapeSettings_mMaxConvexRadius_RoundTrips()
    {
        using var s = new JPH.ConvexHullShapeSettings();
        s.mMaxConvexRadius = 0.1f;
        Assert.Equal(0.1f, s.mMaxConvexRadius);
    }

    [Fact]
    public void ConvexHullShapeSettings_mMaxErrorConvexRadius_RoundTrips()
    {
        using var s = new JPH.ConvexHullShapeSettings();
        s.mMaxErrorConvexRadius = 0.2f;
        Assert.Equal(0.2f, s.mMaxErrorConvexRadius);
    }

    [Fact]
    public void ConvexHullShapeSettings_mHullTolerance_RoundTrips()
    {
        using var s = new JPH.ConvexHullShapeSettings();
        s.mHullTolerance = 0.01f;
        Assert.Equal(0.01f, s.mHullTolerance);
    }

    [Fact]
    public void ConvexHullShapeSettings_mDensity_RoundTrips()
    {
        using var s = new JPH.ConvexHullShapeSettings();
        s.mDensity = 500.0f;
        Assert.Equal(500.0f, s.mDensity);
    }

    [Fact]
    public void ConvexHullShapeSettings_SetDensity_UpdatesMDensity()
    {
        using var s = new JPH.ConvexHullShapeSettings();
        s.SetDensity(800.0f);
        Assert.Equal(800.0f, s.mDensity);
    }

    [Fact]
    public void ConvexHullShapeSettings_mUserData_RoundTrips()
    {
        using var s = new JPH.ConvexHullShapeSettings();
        s.mUserData = (UIntPtr)42u;
        Assert.Equal((UIntPtr)42u, s.mUserData);
    }

    // ── ConvexHullShape static constants ──────────────────────────────────────

    [Fact]
    public void ConvexHullShape_CMaxPointsInHull_IsPositive()
    {
        Assert.True(JPH.ConvexHullShape.CMaxPointsInHull > 0);
    }

    [Fact]
    public void ConvexHullShape_CGetTrianglesMinTrianglesRequested_IsPositive()
    {
        Assert.True(JPH.ConvexHullShape.CGetTrianglesMinTrianglesRequested > 0);
    }

    // ── ConvexHullShape default-constructed queries ────────────────────────────

    [Fact]
    public void ConvexHullShape_DefaultConstruct_NoCrash()
    {
        using var shape = new JPH.ConvexHullShape();
        Assert.NotNull(shape);
    }

    [Fact]
    public void ConvexHullShape_DefaultConstruct_GetNumPoints_IsZero()
    {
        using var shape = new JPH.ConvexHullShape();
        Assert.Equal(0u, shape.GetNumPoints());
    }

    [Fact]
    public void ConvexHullShape_DefaultConstruct_GetNumFaces_IsZero()
    {
        using var shape = new JPH.ConvexHullShape();
        Assert.Equal(0u, shape.GetNumFaces());
    }

    [Fact]
    public void ConvexHullShape_DefaultConstruct_GetDensity_Is1000()
    {
        using var shape = new JPH.ConvexHullShape();
        Assert.Equal(1000.0f, shape.GetDensity());
    }

    [Fact]
    public void ConvexHullShape_DefaultConstruct_GetUserData_IsZero()
    {
        using var shape = new JPH.ConvexHullShape();
        Assert.Equal((UIntPtr)0u, shape.GetUserData());
    }

    [Fact]
    public void ConvexHullShape_DefaultConstruct_MustBeStatic_IsFalse()
    {
        using var shape = new JPH.ConvexHullShape();
        Assert.False(shape.MustBeStatic());
    }

    [Fact]
    public void ConvexHullShape_DefaultConstruct_GetConvexRadius_IsZero()
    {
        using var shape = new JPH.ConvexHullShape();
        Assert.Equal(0.0f, shape.GetConvexRadius());
    }

    [Fact]
    public void ConvexHullShape_DefaultConstruct_GetInnerRadius_IsFloatMaxValue()
    {
        using var shape = new JPH.ConvexHullShape();
        Assert.Equal(float.MaxValue, shape.GetInnerRadius());
    }

    [Fact]
    public void ConvexHullShape_SetDensity_UpdatesValue()
    {
        using var shape = new JPH.ConvexHullShape();
        shape.SetDensity(500.0f);
        Assert.Equal(500.0f, shape.GetDensity());
    }

    [Fact]
    public void ConvexHullShape_SetUserData_UpdatesValue()
    {
        using var shape = new JPH.ConvexHullShape();
        shape.SetUserData((UIntPtr)99u);
        Assert.Equal((UIntPtr)99u, shape.GetUserData());
    }
}
