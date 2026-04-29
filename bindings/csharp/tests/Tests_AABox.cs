// Tests for JPH::AABox: construction, validity, centre/size/contains/overlaps.
// Mirrors coverage in JoltPhysics/UnitTests/Geometry/*Tests.cpp.

using Xunit;

namespace JoltTests;

// Pure geometry — no physics system needed.
public sealed class Tests_AABox
{
    // ─────────────────────────────────────────────────────────────────────────
    // Construction
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void AABox_DefaultConstruct_IsNotValid()
    {
        // A default-constructed AABox is invalid (min > max per Jolt convention)
        using var box = new JPH.AABox();
        Assert.False(box.IsValid());
    }

    [Fact]
    public void AABox_MinMax_IsValid()
    {
        using var min = new JPH.Vec3(-1f, -1f, -1f);
        using var max = new JPH.Vec3( 1f,  1f,  1f);
        using var box = new JPH.AABox(min, max);
        Assert.True(box.IsValid());
    }

    [Fact]
    public void AABox_CenterRadius_IsValid()
    {
        using var center = new JPH.Vec3(0f, 0f, 0f);
        using var box    = new JPH.AABox(center, 2f);
        Assert.True(box.IsValid());
    }

    [Fact]
    public void AABox_Biggest_IsValid()
    {
        using var box = JPH.AABox.SBiggest();
        Assert.True(box.IsValid());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // GetCenter / GetSize
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void AABox_GetCenter_MatchesMidpoint()
    {
        using var min = new JPH.Vec3(0f, 0f, 0f);
        using var max = new JPH.Vec3(2f, 4f, 6f);
        using var box = new JPH.AABox(min, max);
        using var c   = box.GetCenter();
        Assert.Equal(1f, c.GetX(), precision: 5);
        Assert.Equal(2f, c.GetY(), precision: 5);
        Assert.Equal(3f, c.GetZ(), precision: 5);
    }

    [Fact]
    public void AABox_GetSize_MatchesDimensions()
    {
        using var min = new JPH.Vec3(0f, 0f, 0f);
        using var max = new JPH.Vec3(2f, 4f, 6f);
        using var box = new JPH.AABox(min, max);
        using var s   = box.GetSize();
        Assert.Equal(2f, s.GetX(), precision: 5);
        Assert.Equal(4f, s.GetY(), precision: 5);
        Assert.Equal(6f, s.GetZ(), precision: 5);
    }

    [Fact]
    public void AABox_CenterRadius_GetCenter_IsOrigin()
    {
        using var center = new JPH.Vec3(0f, 0f, 0f);
        using var box    = new JPH.AABox(center, 1f);
        using var c      = box.GetCenter();
        Assert.Equal(0f, c.GetX(), precision: 5);
        Assert.Equal(0f, c.GetY(), precision: 5);
        Assert.Equal(0f, c.GetZ(), precision: 5);
    }

    [Fact]
    public void AABox_CenterRadius_GetSize_IsTwiceRadius()
    {
        using var center = new JPH.Vec3(0f, 0f, 0f);
        using var box    = new JPH.AABox(center, 3f);
        using var s      = box.GetSize();
        Assert.Equal(6f, s.GetX(), precision: 5);
        Assert.Equal(6f, s.GetY(), precision: 5);
        Assert.Equal(6f, s.GetZ(), precision: 5);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // mMin / mMax fields
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void AABox_mMin_mMax_FieldsRoundTrip()
    {
        using var min = new JPH.Vec3(-2f, -3f, -4f);
        using var max = new JPH.Vec3( 2f,  3f,  4f);
        using var box = new JPH.Const_AABox(min, max);
        using var m   = box.mMin;
        using var M   = box.mMax;
        Assert.Equal(-2f, m.GetX(), precision: 5);
        Assert.Equal(-3f, m.GetY(), precision: 5);
        Assert.Equal(-4f, m.GetZ(), precision: 5);
        Assert.Equal( 2f, M.GetX(), precision: 5);
        Assert.Equal( 3f, M.GetY(), precision: 5);
        Assert.Equal( 4f, M.GetZ(), precision: 5);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Contains
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void AABox_Contains_Point_InsideBox_ReturnsTrue()
    {
        using var min = new JPH.Vec3(-1f, -1f, -1f);
        using var max = new JPH.Vec3( 1f,  1f,  1f);
        using var box = new JPH.Const_AABox(min, max);
        using var pt  = new JPH.Vec3(0f, 0f, 0f);
        Assert.True(box.Contains(pt));
    }

    [Fact]
    public void AABox_Contains_Point_OutsideBox_ReturnsFalse()
    {
        using var min = new JPH.Vec3(-1f, -1f, -1f);
        using var max = new JPH.Vec3( 1f,  1f,  1f);
        using var box = new JPH.Const_AABox(min, max);
        using var pt  = new JPH.Vec3(2f, 0f, 0f);
        Assert.False(box.Contains(pt));
    }

    [Fact]
    public void AABox_Contains_SmallerBox_ReturnsTrue()
    {
        using var min  = new JPH.Vec3(-2f, -2f, -2f);
        using var max  = new JPH.Vec3( 2f,  2f,  2f);
        using var big  = new JPH.Const_AABox(min, max);
        using var min2 = new JPH.Vec3(-1f, -1f, -1f);
        using var max2 = new JPH.Vec3( 1f,  1f,  1f);
        using var sml  = new JPH.Const_AABox(min2, max2);
        Assert.True(big.Contains(sml));
    }

    [Fact]
    public void AABox_Contains_LargerBox_ReturnsFalse()
    {
        using var min  = new JPH.Vec3(-1f, -1f, -1f);
        using var max  = new JPH.Vec3( 1f,  1f,  1f);
        using var sml  = new JPH.Const_AABox(min, max);
        using var min2 = new JPH.Vec3(-2f, -2f, -2f);
        using var max2 = new JPH.Vec3( 2f,  2f,  2f);
        using var big  = new JPH.Const_AABox(min2, max2);
        Assert.False(sml.Contains(big));
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Overlaps
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void AABox_Overlaps_OverlappingBoxes_ReturnsTrue()
    {
        using var min1 = new JPH.Vec3(0f, 0f, 0f);
        using var max1 = new JPH.Vec3(2f, 2f, 2f);
        using var b1   = new JPH.Const_AABox(min1, max1);
        using var min2 = new JPH.Vec3(1f, 1f, 1f);
        using var max2 = new JPH.Vec3(3f, 3f, 3f);
        using var b2   = new JPH.Const_AABox(min2, max2);
        Assert.True(b1.Overlaps(b2));
    }

    [Fact]
    public void AABox_Overlaps_DisjointBoxes_ReturnsFalse()
    {
        using var min1 = new JPH.Vec3(0f, 0f, 0f);
        using var max1 = new JPH.Vec3(1f, 1f, 1f);
        using var b1   = new JPH.Const_AABox(min1, max1);
        using var min2 = new JPH.Vec3(2f, 0f, 0f);
        using var max2 = new JPH.Vec3(3f, 1f, 1f);
        using var b2   = new JPH.Const_AABox(min2, max2);
        Assert.False(b1.Overlaps(b2));
    }

    [Fact]
    public void AABox_Overlaps_Self_ReturnsTrue()
    {
        using var min = new JPH.Vec3(-1f, -1f, -1f);
        using var max = new JPH.Vec3( 1f,  1f,  1f);
        using var box = new JPH.Const_AABox(min, max);
        Assert.True(box.Overlaps(box));
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Equality operator
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void AABox_EqualityOperator_SameBox_IsEqual()
    {
        using var min = new JPH.Vec3(-1f, -2f, -3f);
        using var max = new JPH.Vec3( 1f,  2f,  3f);
        using var b1  = new JPH.Const_AABox(min, max);
        using var b2  = new JPH.Const_AABox(min, max);
        Assert.True(b1 == b2);
    }

    [Fact]
    public void AABox_EqualityOperator_DifferentBox_IsNotEqual()
    {
        using var min1 = new JPH.Vec3(0f, 0f, 0f);
        using var max1 = new JPH.Vec3(1f, 1f, 1f);
        using var b1   = new JPH.Const_AABox(min1, max1);
        using var min2 = new JPH.Vec3(0f, 0f, 0f);
        using var max2 = new JPH.Vec3(2f, 2f, 2f);
        using var b2   = new JPH.Const_AABox(min2, max2);
        Assert.False(b1 == b2);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // SFromTwoPoints
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void AABox_SFromTwoPoints_CreatesCorrectBox()
    {
        using var p1  = new JPH.Vec3(3f, 1f, -2f);
        using var p2  = new JPH.Vec3(1f, 4f,  0f);
        using var box = JPH.AABox.SFromTwoPoints(p1, p2);
        using var c   = box.GetCenter();
        Assert.Equal(2f,  c.GetX(), precision: 5);
        Assert.Equal(2.5f, c.GetY(), precision: 5);
        Assert.Equal(-1f, c.GetZ(), precision: 5);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Intersect
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void AABox_Intersect_OverlappingBoxes_IsSmaller()
    {
        using var min1 = new JPH.Vec3(-2f, -2f, -2f);
        using var max1 = new JPH.Vec3( 2f,  2f,  2f);
        using var b1   = new JPH.Const_AABox(min1, max1);
        using var min2 = new JPH.Vec3( 1f,  1f,  1f);
        using var max2 = new JPH.Vec3( 3f,  3f,  3f);
        using var b2   = new JPH.Const_AABox(min2, max2);
        using var i    = b1.Intersect(b2);
        using var s    = i.GetSize();
        // intersection is [1,2]^3 — size (1,1,1)
        Assert.Equal(1f, s.GetX(), precision: 4);
        Assert.Equal(1f, s.GetY(), precision: 4);
        Assert.Equal(1f, s.GetZ(), precision: 4);
    }
}
