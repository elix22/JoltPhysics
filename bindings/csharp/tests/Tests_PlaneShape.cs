using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_PlaneShape(JoltFixture fx)
{
    // ── PlaneShapeSettings — constants ────────────────────────────────────────

    [Fact]
    public void PlaneShapeSettings_CDefaultHalfExtent_Is1000()
    {
        Assert.Equal(1000.0f, JPH.Const_PlaneShapeSettings.CDefaultHalfExtent);
    }

    // ── PlaneShapeSettings — default construction ─────────────────────────────

    [Fact]
    public void PlaneShapeSettings_DefaultConstruct_NoCrash()
    {
        using var s = new JPH.PlaneShapeSettings();
        Assert.NotNull(s);
    }

    [Fact]
    public void PlaneShapeSettings_DefaultConstruct_mHalfExtentIsDefault()
    {
        using var s = new JPH.PlaneShapeSettings();
        Assert.Equal(JPH.Const_PlaneShapeSettings.CDefaultHalfExtent, s.mHalfExtent);
    }

    [Fact]
    public void PlaneShapeSettings_DefaultConstruct_mUserDataIsZero()
    {
        using var s = new JPH.PlaneShapeSettings();
        Assert.Equal(UIntPtr.Zero, s.mUserData);
    }

    // ── PlaneShapeSettings — field round-trips ────────────────────────────────

    [Fact]
    public void PlaneShapeSettings_mHalfExtent_RoundTrip()
    {
        using var s = new JPH.PlaneShapeSettings();
        s.mHalfExtent = 500.0f;
        Assert.Equal(500.0f, s.mHalfExtent);
    }

    [Fact]
    public void PlaneShapeSettings_mUserData_RoundTrip()
    {
        using var s = new JPH.PlaneShapeSettings();
        s.mUserData = new UIntPtr(12345u);
        Assert.Equal(new UIntPtr(12345u), s.mUserData);
    }

    // ── PlaneShapeSettings — parameterized construction ───────────────────────

    [Fact]
    public void PlaneShapeSettings_ConstructWithPlaneAndHalfExtent_mHalfExtentMatches()
    {
        using var normal = new JPH.Vec3(0, 1, 0);
        using var plane = new JPH.Plane(normal, 0.0f);
        using var s = new JPH.PlaneShapeSettings(plane, null, 250.0f);
        Assert.Equal(250.0f, s.mHalfExtent);
    }

    // ── PlaneShape — constants ────────────────────────────────────────────────

    [Fact]
    public void PlaneShape_CGetTrianglesMinTrianglesRequested_IsPositive()
    {
        Assert.True(JPH.Const_PlaneShape.CGetTrianglesMinTrianglesRequested > 0);
    }

    // ── PlaneShape — default construction ────────────────────────────────────

    [Fact]
    public void PlaneShape_DefaultConstruct_NoCrash()
    {
        using var shape = new JPH.PlaneShape();
        Assert.NotNull(shape);
    }

    [Fact]
    public void PlaneShape_DefaultConstruct_MustBeStatic()
    {
        using var shape = new JPH.PlaneShape();
        Assert.True(shape.MustBeStatic());
    }

    [Fact]
    public void PlaneShape_DefaultConstruct_GetHalfExtentIsZero()
    {
        // Default-constructed (zero-initialized) PlaneShape has half extent 0,
        // not CDefaultHalfExtent; use the parameterized constructor to set a value.
        using var shape = new JPH.PlaneShape();
        Assert.Equal(0.0f, shape.GetHalfExtent());
    }

    // ── PlaneShape — parameterized construction ───────────────────────────────

    [Fact]
    public void PlaneShape_ConstructWithHalfExtent_GetHalfExtentMatches()
    {
        using var normal = new JPH.Vec3(0, 1, 0);
        using var plane = new JPH.Plane(normal, 0.0f);
        using var shape = new JPH.PlaneShape(plane, null, 400.0f);
        Assert.Equal(400.0f, shape.GetHalfExtent());
    }

    [Fact]
    public void PlaneShape_GetLocalBounds_NoCrash()
    {
        using var shape = new JPH.PlaneShape();
        var bounds = shape.GetLocalBounds();
        // Just verify it doesn't crash; bounds is valid
        Assert.NotNull(bounds);
    }
}
