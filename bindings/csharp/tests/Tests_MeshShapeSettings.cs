// Tests for JPH::MeshShapeSettings fields and their defaults / round-trips.
// Note: actually constructing a MeshShape requires vertex+triangle arrays,
// which are not easily marshalled from C# without unsafe pointers. These tests
// therefore cover only the settings object, not the shape itself.
//
// Defaults (from Jolt/Physics/Collision/Shape/MeshShape.h):
//   mMaxTrianglesPerLeaf          = 8
//   mActiveEdgeCosThresholdAngle  = 0.996195f  (cos 5°)
//   mPerTriangleUserData          = false
//   mBuildQuality                 = EBuildQuality.FavorRuntimePerformance (0)

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_MeshShapeSettings(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // Construction
    // -------------------------------------------------------------------------

    [Fact]
    public void MeshShapeSettings_DefaultConstruct_DoesNotThrow()
    {
        var ex = Record.Exception(() =>
        {
            using var s = new JPH.MeshShapeSettings();
        });
        Assert.Null(ex);
    }

    // -------------------------------------------------------------------------
    // mMaxTrianglesPerLeaf default and round-trip
    // -------------------------------------------------------------------------

    [Fact]
    public void MeshShapeSettings_mMaxTrianglesPerLeaf_DefaultIsEight()
    {
        using var s = new JPH.MeshShapeSettings();
        Assert.Equal(8u, s.mMaxTrianglesPerLeaf);
    }

    [Fact]
    public void MeshShapeSettings_mMaxTrianglesPerLeaf_RoundTrips()
    {
        using var s = new JPH.MeshShapeSettings();
        s.mMaxTrianglesPerLeaf = 4u;
        Assert.Equal(4u, s.mMaxTrianglesPerLeaf);
    }

    // -------------------------------------------------------------------------
    // mActiveEdgeCosThresholdAngle default and round-trip
    // -------------------------------------------------------------------------

    [Fact]
    public void MeshShapeSettings_mActiveEdgeCosThresholdAngle_DefaultIsCos5Degrees()
    {
        using var s = new JPH.MeshShapeSettings();
        // Default = cos(5°) ≈ 0.996195
        Assert.Equal(0.996195f, s.mActiveEdgeCosThresholdAngle, precision: 4);
    }

    [Fact]
    public void MeshShapeSettings_mActiveEdgeCosThresholdAngle_RoundTrips()
    {
        using var s = new JPH.MeshShapeSettings();
        s.mActiveEdgeCosThresholdAngle = 0.9f;
        Assert.Equal(0.9f, s.mActiveEdgeCosThresholdAngle, precision: 5);
    }

    // -------------------------------------------------------------------------
    // mPerTriangleUserData default and round-trip
    // -------------------------------------------------------------------------

    [Fact]
    public void MeshShapeSettings_mPerTriangleUserData_DefaultIsFalse()
    {
        using var s = new JPH.MeshShapeSettings();
        Assert.False(s.mPerTriangleUserData);
    }

    [Fact]
    public void MeshShapeSettings_mPerTriangleUserData_RoundTrips()
    {
        using var s = new JPH.MeshShapeSettings();
        s.mPerTriangleUserData = true;
        Assert.True(s.mPerTriangleUserData);
        s.mPerTriangleUserData = false;
        Assert.False(s.mPerTriangleUserData);
    }

    // -------------------------------------------------------------------------
    // mBuildQuality default and round-trip
    // -------------------------------------------------------------------------

    [Fact]
    public void MeshShapeSettings_mBuildQuality_DefaultIsFavorRuntimePerformance()
    {
        using var s = new JPH.MeshShapeSettings();
        Assert.Equal(JPH.MeshShapeSettings.EBuildQuality.FavorRuntimePerformance, s.mBuildQuality);
    }

    [Fact]
    public void MeshShapeSettings_mBuildQuality_RoundTrips()
    {
        using var s = new JPH.MeshShapeSettings();
        s.mBuildQuality = JPH.MeshShapeSettings.EBuildQuality.FavorBuildSpeed;
        Assert.Equal(JPH.MeshShapeSettings.EBuildQuality.FavorBuildSpeed, s.mBuildQuality);
    }
}
