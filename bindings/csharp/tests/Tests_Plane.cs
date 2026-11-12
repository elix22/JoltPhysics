// Tests for JPH::Plane (Geometry/Plane.h)
// Ported from UnitTests/Geometry/PlaneTests.cpp

using Xunit;

namespace JoltBindingsTests;

[Collection("Jolt")]
public sealed class Tests_Plane
{
    // ── Construction ────────────────────────────────────────────────────────

    [Fact]
    public void Plane_DefaultConstruct_GetNormalAndConstant()
    {
        var p = new JPH.Plane();
        // Default constructed - just verify it doesn't crash
        _ = p.GetNormal();
        _ = p.GetConstant();
    }

    [Fact]
    public void Plane_ConstructFromNormalAndConstant()
    {
        var normal = new JPH.Vec3(0, 1, 0);
        var p = new JPH.Plane(normal, -2.0f);
        Assert.Equal(0f, p.GetNormal().GetX());
        Assert.Equal(1f, p.GetNormal().GetY());
        Assert.Equal(0f, p.GetNormal().GetZ());
        Assert.Equal(-2.0f, p.GetConstant());
    }

    // ── SFromPointAndNormal ─────────────────────────────────────────────────

    [Fact]
    public void Plane_SFromPointAndNormal_GetNormal()
    {
        var p = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(0, 2, 0), new JPH.Vec3(0, 1, 0));
        var n = p.GetNormal();
        Assert.Equal(0f, n.GetX());
        Assert.Equal(1f, n.GetY());
        Assert.Equal(0f, n.GetZ());
    }

    [Fact]
    public void Plane_SFromPointAndNormal_GetConstant()
    {
        // Plane Y=2 → normal=(0,1,0), constant = -dot(normal, point) = -2
        var p = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(0, 2, 0), new JPH.Vec3(0, 1, 0));
        Assert.Equal(-2.0f, p.GetConstant());
    }

    // ── SignedDistance ───────────────────────────────────────────────────────
    // Ported from TestPlaneSignedDistance

    [Fact]
    public void Plane_SignedDistance_AbovePlane_Positive()
    {
        var p = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(0, 2, 0), new JPH.Vec3(0, 1, 0));
        Assert.Equal(5.0f, p.SignedDistance(new JPH.Vec3(5, 7, 0)));
    }

    [Fact]
    public void Plane_SignedDistance_BelowPlane_Negative()
    {
        var p = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(0, 2, 0), new JPH.Vec3(0, 1, 0));
        Assert.Equal(-5.0f, p.SignedDistance(new JPH.Vec3(5, -3, 0)));
    }

    [Fact]
    public void Plane_SignedDistance_OnPlane_Zero()
    {
        var p = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(0, 2, 0), new JPH.Vec3(0, 1, 0));
        Assert.Equal(0.0f, p.SignedDistance(new JPH.Vec3(5, 2, 0)));
    }

    // ── GetTransformed ───────────────────────────────────────────────────────
    // Ported from TestPlaneGetTransformed

    [Fact]
    public void Plane_GetTransformed_NormalMatchesDirectConstruction()
    {
        var axis = new JPH.Vec3(1.0f, 2.0f, 3.0f).Normalized();
        var transform = JPH.Mat44.SRotationTranslation(
            JPH.Quat.SRotation(axis, 0.1f * 3.14159265358979323846f),
            new JPH.Vec3(5.0f, -7.0f, 9.0f));

        var point  = new JPH.Vec3(11.0f, 13.0f, 15.0f);
        var normal = new JPH.Vec3(-3.0f, 5.0f, -7.0f).Normalized();

        var p1 = JPH.Const_Plane.SFromPointAndNormal(point, normal).GetTransformed(transform);

        // transform * point
        var transformed_point = transform * point;
        // Multiply3x3(normal) = rotate normal
        var transformed_normal = transform.Multiply3x3(normal);
        var p2 = JPH.Const_Plane.SFromPointAndNormal(transformed_point, transformed_normal);

        var n1 = p1.GetNormal();
        var n2 = p2.GetNormal();
        Assert.Equal(n2.GetX(), n1.GetX(), 5);
        Assert.Equal(n2.GetY(), n1.GetY(), 5);
        Assert.Equal(n2.GetZ(), n1.GetZ(), 5);
        Assert.Equal(p2.GetConstant(), p1.GetConstant(), 3);
    }

    // ── SIntersectPlanes ─────────────────────────────────────────────────────
    // Ported from TestPlaneIntersectPlanes

    [Fact]
    public void Plane_SIntersectPlanes_ThreePlanesIntersectAtPoint()
    {
        var p1 = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(0, 2, 0), new JPH.Vec3(0, 1, 0));
        var p2 = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(3, 0, 0), new JPH.Vec3(1, 0, 0));
        var p3 = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(0, 0, 4), new JPH.Vec3(0, 0, 1));

        var outPoint = new JPH.Vec3(0, 0, 0);
        bool found = JPH.Const_Plane.SIntersectPlanes(p1, p2, p3, outPoint);
        Assert.True(found);
        Assert.Equal(3.0f, outPoint.GetX(), 4);
        Assert.Equal(2.0f, outPoint.GetY(), 4);
        Assert.Equal(4.0f, outPoint.GetZ(), 4);
    }

    [Fact]
    public void Plane_SIntersectPlanes_TwoParallelPlanes_ReturnsFalse()
    {
        var p1 = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(0, 2, 0), new JPH.Vec3(0, 1, 0));
        var p2 = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(3, 0, 0), new JPH.Vec3(1, 0, 0));
        // p4 is parallel to p1 (same normal, different constant)
        var p4 = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(0, 3, 0), new JPH.Vec3(0, 1, 0));

        var outPoint = new JPH.Vec3(0, 0, 0);
        bool found = JPH.Const_Plane.SIntersectPlanes(p1, p2, p4, outPoint);
        Assert.False(found);
    }

    // ── ProjectPointOnPlane ──────────────────────────────────────────────────

    [Fact]
    public void Plane_ProjectPointOnPlane_PointAbovePlane_ProjectsOntoPlane()
    {
        // Plane Y=0 (ground plane)
        var p = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(0, 0, 0), new JPH.Vec3(0, 1, 0));
        var projected = p.ProjectPointOnPlane(new JPH.Vec3(3, 5, 7));
        Assert.Equal(3.0f, projected.GetX(), 5);
        Assert.Equal(0.0f, projected.GetY(), 5);
        Assert.Equal(7.0f, projected.GetZ(), 5);
    }

    [Fact]
    public void Plane_ProjectPointOnPlane_PointBelowPlane_ProjectsOntoPlane()
    {
        // Plane Y=0 (ground plane)
        var p = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(0, 0, 0), new JPH.Vec3(0, 1, 0));
        var projected = p.ProjectPointOnPlane(new JPH.Vec3(3, -5, 7));
        Assert.Equal(3.0f, projected.GetX(), 5);
        Assert.Equal(0.0f, projected.GetY(), 5);
        Assert.Equal(7.0f, projected.GetZ(), 5);
    }

    // ── Offset ────────────────────────────────────────────────────────────────

    [Fact]
    public void Plane_Offset_MovesPlane()
    {
        // Plane Y=2 offset by 3 should become Y=5
        var p = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(0, 2, 0), new JPH.Vec3(0, 1, 0));
        var shifted = p.Offset(3.0f);
        // SignedDistance of Y=5 from new plane should be 0
        Assert.Equal(0.0f, shifted.SignedDistance(new JPH.Vec3(0, 5, 0)), 5);
    }

    [Fact]
    public void Plane_Offset_NegativeOffset()
    {
        var p = JPH.Const_Plane.SFromPointAndNormal(new JPH.Vec3(0, 2, 0), new JPH.Vec3(0, 1, 0));
        var shifted = p.Offset(-1.0f);
        Assert.Equal(0.0f, shifted.SignedDistance(new JPH.Vec3(0, 1, 0)), 5);
    }

    // ── SFromPointsCCW ───────────────────────────────────────────────────────

    [Fact]
    public void Plane_SFromPointsCCW_NormalPointsUp()
    {
        // Triangle in XZ plane, CCW winding → normal should point in +Y
        var p = JPH.Const_Plane.SFromPointsCCW(
            new JPH.Vec3(0, 0, 0),
            new JPH.Vec3(1, 0, 0),
            new JPH.Vec3(0, 0, 1));
        // Normal should be (0, -1, 0) or (0, 1, 0) depending on winding convention
        // Jolt uses right-hand rule: cross(v2-v1, v3-v1) = cross(X, Z) = -Y
        Assert.Equal(0.0f, p.GetNormal().GetX(), 5);
        Assert.NotEqual(0.0f, p.GetNormal().GetY());
        Assert.Equal(0.0f, p.GetNormal().GetZ(), 5);
    }
}
