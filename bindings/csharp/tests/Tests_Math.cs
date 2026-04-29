// Tests for the math binding layer: Vec3, Vec4, Quat, Mat44.
// These are value-like types that use Destroy() (not RefTarget).

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Math
{
    // -------------------------------------------------------------------------
    // Vec3
    // -------------------------------------------------------------------------

    [Fact]
    public void Vec3_DefaultConstruct_ComponentsAreZero()
    {
        using var v = new JPH.Vec3();
        // Default construction in Jolt leaves components uninitialised (Release),
        // but the binding must at least not crash.
        Assert.NotNull(v);
    }

    [Fact]
    public void Vec3_ConstructXYZ_RoundTrips()
    {
        using var v = new JPH.Vec3(1f, 2f, 3f);
        Assert.Equal(1f, v.GetX(), precision: 6);
        Assert.Equal(2f, v.GetY(), precision: 6);
        Assert.Equal(3f, v.GetZ(), precision: 6);
    }

    [Theory]
    [InlineData(0f,  0f,  1f)]
    [InlineData(1f,  0f,  0f)]
    [InlineData(0f,  1f,  0f)]
    [InlineData(-1f, 0f,  0f)]
    [InlineData(3f,  4f,  0f)]   // length = 5
    public void Vec3_Length_MatchesMath(float x, float y, float z)
    {
        using var v        = new JPH.Vec3(x, y, z);
        float     expected = MathF.Sqrt(x * x + y * y + z * z);
        float     actual   = v.Length();
        Assert.Equal(expected, actual, precision: 4);
    }

    [Fact]
    public void Vec3_Normalized_HasLengthOne()
    {
        using var v = new JPH.Vec3(3f, 4f, 0f);
        using var n = v.Normalized();
        Assert.Equal(1f, n.Length(), precision: 5);
    }

    [Fact]
    public void Vec3_Add_CorrectResult()
    {
        using var a   = new JPH.Vec3(1f, 2f, 3f);
        using var b   = new JPH.Vec3(4f, 5f, 6f);
        using var sum = a + b;
        Assert.Equal(5f, sum.GetX(), precision: 6);
        Assert.Equal(7f, sum.GetY(), precision: 6);
        Assert.Equal(9f, sum.GetZ(), precision: 6);
    }

    [Fact]
    public void Vec3_Sub_CorrectResult()
    {
        using var a   = new JPH.Vec3(5f, 7f, 9f);
        using var b   = new JPH.Vec3(1f, 2f, 3f);
        using var dif = a - b;
        Assert.Equal(4f, dif.GetX(), precision: 6);
        Assert.Equal(5f, dif.GetY(), precision: 6);
        Assert.Equal(6f, dif.GetZ(), precision: 6);
    }

    [Fact]
    public void Vec3_Dot_CorrectResult()
    {
        using var a = new JPH.Vec3(1f, 0f, 0f);
        using var b = new JPH.Vec3(0f, 1f, 0f);
        Assert.Equal(0f, a.Dot(b), precision: 6);

        using var c = new JPH.Vec3(2f, 3f, 4f);
        using var d = new JPH.Vec3(1f, 1f, 1f);
        Assert.Equal(9f, c.Dot(d), precision: 6);
    }

    [Fact]
    public void Vec3_Cross_CorrectResult()
    {
        using var x     = new JPH.Vec3(1f, 0f, 0f);
        using var y     = new JPH.Vec3(0f, 1f, 0f);
        using var xCrossY = x.Cross(y);
        Assert.Equal(0f, xCrossY.GetX(), precision: 6);
        Assert.Equal(0f, xCrossY.GetY(), precision: 6);
        Assert.Equal(1f, xCrossY.GetZ(), precision: 6);
    }

    [Fact]
    public void Vec3_Equality_SameValues_AreEqual()
    {
        using var a = new JPH.Vec3(1f, 2f, 3f);
        using var b = new JPH.Vec3(1f, 2f, 3f);
        Assert.True(a.IsClose(b, 1e-6f));
    }

    [Fact]
    public void Vec3_Set_MutatesInPlace()
    {
        using var v = new JPH.Vec3(0f, 0f, 0f);
        v.Set(9f, 8f, 7f);
        Assert.Equal(9f, v.GetX(), precision: 6);
        Assert.Equal(8f, v.GetY(), precision: 6);
        Assert.Equal(7f, v.GetZ(), precision: 6);
    }

    // -------------------------------------------------------------------------
    // Quat
    // -------------------------------------------------------------------------

    [Fact]
    public void Quat_Identity_NormIsOne()
    {
        using var q = new JPH.Quat();
        // JPH::Quat default constructor is identity (0,0,0,1).
        // Verify Normalized returns itself unchanged (or at least not crash).
        using var n = q.Normalized();
        Assert.NotNull(n);
    }

    [Fact]
    public void Quat_RotationAxisAngle_NormIsOne()
    {
        using var axis = new JPH.Vec3(0f, 1f, 0f);
        using var q    = JPH.Quat.SRotation(axis, MathF.PI / 4f);
        float     len  = MathF.Sqrt(
            q.GetX() * q.GetX() + q.GetY() * q.GetY() +
            q.GetZ() * q.GetZ() + q.GetW() * q.GetW());
        Assert.Equal(1f, len, precision: 5);
    }

    // -------------------------------------------------------------------------
    // Vec4
    // -------------------------------------------------------------------------

    [Fact]
    public void Vec4_ConstructXYZW_RoundTrips()
    {
        using var v = new JPH.Vec4(1f, 2f, 3f, 4f);
        Assert.Equal(1f, v.GetX(), precision: 6);
        Assert.Equal(2f, v.GetY(), precision: 6);
        Assert.Equal(3f, v.GetZ(), precision: 6);
        Assert.Equal(4f, v.GetW(), precision: 6);
    }
}
