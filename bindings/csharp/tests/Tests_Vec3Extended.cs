// Extended Vec3 tests based on Jolt's own Vec3Tests.cpp.
// Covers factories, arithmetic operators, min/max, clamp, FMA,
// dot/cross, normalization, and compression round-trips.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Vec3Extended
{
    // ── Factory methods ───────────────────────────────────────────────────────

    [Fact]
    public void Vec3_SZero_AllComponentsZero()
    {
        using var v = JPH.Vec3.SZero();
        Assert.Equal(0f, v.GetX());
        Assert.Equal(0f, v.GetY());
        Assert.Equal(0f, v.GetZ());
    }

    [Fact]
    public void Vec3_SOne_AllComponentsOne()
    {
        using var v = JPH.Vec3.SOne();
        Assert.Equal(1f, v.GetX());
        Assert.Equal(1f, v.GetY());
        Assert.Equal(1f, v.GetZ());
    }

    [Fact]
    public void Vec3_SAxisX_IsUnitX()
    {
        using var v = JPH.Vec3.SAxisX();
        Assert.Equal(1f, v.GetX());
        Assert.Equal(0f, v.GetY());
        Assert.Equal(0f, v.GetZ());
    }

    [Fact]
    public void Vec3_SAxisY_IsUnitY()
    {
        using var v = JPH.Vec3.SAxisY();
        Assert.Equal(0f, v.GetX());
        Assert.Equal(1f, v.GetY());
        Assert.Equal(0f, v.GetZ());
    }

    [Fact]
    public void Vec3_SAxisZ_IsUnitZ()
    {
        using var v = JPH.Vec3.SAxisZ();
        Assert.Equal(0f, v.GetX());
        Assert.Equal(0f, v.GetY());
        Assert.Equal(1f, v.GetZ());
    }

    [Fact]
    public void Vec3_SReplicate_AllComponentsEqual()
    {
        using var v = JPH.Vec3.SReplicate(7f);
        Assert.Equal(7f, v.GetX());
        Assert.Equal(7f, v.GetY());
        Assert.Equal(7f, v.GetZ());
    }

    // ── Indexer ───────────────────────────────────────────────────────────────

    [Fact]
    public void Vec3_Indexer_MatchesGetXYZ()
    {
        using var v = new JPH.Vec3(1f, 2f, 3f);
        Assert.Equal(v.GetX(), v[0]);
        Assert.Equal(v.GetY(), v[1]);
        Assert.Equal(v.GetZ(), v[2]);
    }

    // ── LengthSq / Length ─────────────────────────────────────────────────────

    [Fact]
    public void Vec3_LengthSq_CorrectValue()
    {
        using var v = new JPH.Vec3(1f, 2f, 3f);  // 1+4+9 = 14
        Assert.Equal(14f, v.LengthSq(), precision: 5);
    }

    [Theory]
    [InlineData(3f, 4f, 0f,  5f)]
    [InlineData(1f, 0f, 0f,  1f)]
    [InlineData(0f, 0f, 0f,  0f)]
    [InlineData(1f, 1f, 1f,  1.7320508f)]
    public void Vec3_Length_KnownValues(float x, float y, float z, float expected)
    {
        using var v = new JPH.Vec3(x, y, z);
        Assert.Equal(expected, v.Length(), precision: 4);
    }

    // ── Dot / Cross ───────────────────────────────────────────────────────────

    [Fact]
    public void Vec3_Dot_CorrectValue()
    {
        // (1,2,3)·(4,5,6) = 4+10+18 = 32
        using var a = new JPH.Vec3(1f, 2f, 3f);
        using var b = new JPH.Vec3(4f, 5f, 6f);
        Assert.Equal(32f, a.Dot(b), precision: 5);
    }

    [Fact]
    public void Vec3_DotOrthogonal_IsZero()
    {
        using var a = JPH.Vec3.SAxisX();
        using var b = JPH.Vec3.SAxisY();
        Assert.Equal(0f, a.Dot(b), precision: 6);
    }

    [Fact]
    public void Vec3_Cross_XcrossY_IsZ()
    {
        using var x = JPH.Vec3.SAxisX();
        using var y = JPH.Vec3.SAxisY();
        using var z = x.Cross(y);
        Assert.Equal(0f, z.GetX(), precision: 6);
        Assert.Equal(0f, z.GetY(), precision: 6);
        Assert.Equal(1f, z.GetZ(), precision: 6);
    }

    [Fact]
    public void Vec3_Cross_YcrossZ_IsX()
    {
        using var y = JPH.Vec3.SAxisY();
        using var z = JPH.Vec3.SAxisZ();
        using var x = y.Cross(z);
        Assert.Equal(1f, x.GetX(), precision: 6);
        Assert.Equal(0f, x.GetY(), precision: 6);
        Assert.Equal(0f, x.GetZ(), precision: 6);
    }

    [Fact]
    public void Vec3_Cross_AntiCommutative()
    {
        using var a   = new JPH.Vec3(1f, 2f, 3f);
        using var b   = new JPH.Vec3(4f, 5f, 6f);
        using var ab  = a.Cross(b);
        using var ba  = b.Cross(a);
        Assert.Equal(-ab.GetX(), ba.GetX(), precision: 5);
        Assert.Equal(-ab.GetY(), ba.GetY(), precision: 5);
        Assert.Equal(-ab.GetZ(), ba.GetZ(), precision: 5);
    }

    // ── Min / Max / Clamp ─────────────────────────────────────────────────────

    [Fact]
    public void Vec3_SMin_TakesComponentWiseMin()
    {
        using var a   = new JPH.Vec3(1f, 5f, 3f);
        using var b   = new JPH.Vec3(4f, 2f, 6f);
        using var r   = JPH.Vec3.SMin(a, b);
        Assert.Equal(1f, r.GetX());
        Assert.Equal(2f, r.GetY());
        Assert.Equal(3f, r.GetZ());
    }

    [Fact]
    public void Vec3_SMax_TakesComponentWiseMax()
    {
        using var a = new JPH.Vec3(1f, 5f, 3f);
        using var b = new JPH.Vec3(4f, 2f, 6f);
        using var r = JPH.Vec3.SMax(a, b);
        Assert.Equal(4f, r.GetX());
        Assert.Equal(5f, r.GetY());
        Assert.Equal(6f, r.GetZ());
    }

    [Fact]
    public void Vec3_SClamp_ClampsBelowAndAbove()
    {
        // From Jolt's TestVec3Clamp: SClamp((0,4,8), (1,3,6), (2,5,7)) = (1,4,7)
        using var v   = new JPH.Vec3(0f, 4f, 8f);
        using var lo  = new JPH.Vec3(1f, 3f, 6f);
        using var hi  = new JPH.Vec3(2f, 5f, 7f);
        using var r   = JPH.Vec3.SClamp(v, lo, hi);
        Assert.Equal(1f, r.GetX());
        Assert.Equal(4f, r.GetY());
        Assert.Equal(7f, r.GetZ());
    }

    [Fact]
    public void Vec3_ReduceMin_IsMinComponent()
    {
        using var v = new JPH.Vec3(5f, 2f, 8f);
        Assert.Equal(2f, v.ReduceMin());
    }

    [Fact]
    public void Vec3_ReduceMax_IsMaxComponent()
    {
        using var v = new JPH.Vec3(5f, 2f, 8f);
        Assert.Equal(8f, v.ReduceMax());
    }

    // ── Fused multiply-add ───────────────────────────────────────────────────

    [Fact]
    public void Vec3_SFusedMultiplyAdd_CorrectResult()
    {
        // From Jolt: FMA((1,2,3),(4,5,6),(7,8,9)) = (1*4+7, 2*5+8, 3*6+9) = (11,18,27)
        using var a = new JPH.Vec3(1f, 2f, 3f);
        using var b = new JPH.Vec3(4f, 5f, 6f);
        using var c = new JPH.Vec3(7f, 8f, 9f);
        using var r = JPH.Vec3.SFusedMultiplyAdd(a, b, c);
        Assert.Equal(11f, r.GetX(), precision: 5);
        Assert.Equal(18f, r.GetY(), precision: 5);
        Assert.Equal(27f, r.GetZ(), precision: 5);
    }

    // ── Normalization ─────────────────────────────────────────────────────────

    [Fact]
    public void Vec3_Normalized_HasUnitLength()
    {
        using var v = new JPH.Vec3(3f, 4f, 0f);
        using var n = v.Normalized();
        Assert.Equal(1f, n.Length(), precision: 6);
    }

    [Fact]
    public void Vec3_IsNormalized_TrueForUnitVector()
    {
        using var v = JPH.Vec3.SAxisX();
        Assert.True(v.IsNormalized());
    }

    [Fact]
    public void Vec3_IsNormalized_FalseForNonUnit()
    {
        using var v = new JPH.Vec3(2f, 0f, 0f);
        Assert.False(v.IsNormalized());
    }

    [Fact]
    public void Vec3_NormalizedOr_FallsBackForZeroVector()
    {
        using var zero     = JPH.Vec3.SZero();
        using var fallback = JPH.Vec3.SAxisX();
        using var result   = zero.NormalizedOr(fallback);
        Assert.Equal(1f, result.GetX(), precision: 6);
        Assert.Equal(0f, result.GetY(), precision: 6);
        Assert.Equal(0f, result.GetZ(), precision: 6);
    }

    // ── IsClose / IsNearZero ──────────────────────────────────────────────────

    [Fact]
    public void Vec3_IsClose_TrueWhenWithinTolerance()
    {
        using var a = new JPH.Vec3(1f,   0f, 0f);
        using var b = new JPH.Vec3(1.0001f, 0f, 0f);
        Assert.True(a.IsClose(b, 1.0e-4f));
    }

    [Fact]
    public void Vec3_IsClose_FalseWhenOutsideTolerance()
    {
        using var a = new JPH.Vec3(1f, 0f, 0f);
        using var b = new JPH.Vec3(2f, 0f, 0f);
        Assert.False(a.IsClose(b, 1.0e-4f));
    }

    [Fact]
    public void Vec3_IsNearZero_TrueForZeroVector()
    {
        using var v = JPH.Vec3.SZero();
        Assert.True(v.IsNearZero());
    }

    // ── Abs / Reciprocal / GetSign ────────────────────────────────────────────

    [Fact]
    public void Vec3_Abs_NegatesNegativeComponents()
    {
        using var v = new JPH.Vec3(-1f, 2f, -3f);
        using var r = v.Abs();
        Assert.Equal(1f, r.GetX());
        Assert.Equal(2f, r.GetY());
        Assert.Equal(3f, r.GetZ());
    }

    [Fact]
    public void Vec3_Reciprocal_CorrectValues()
    {
        using var v = new JPH.Vec3(2f, 4f, 8f);
        using var r = v.Reciprocal();
        Assert.Equal(0.5f,   r.GetX(), precision: 6);
        Assert.Equal(0.25f,  r.GetY(), precision: 6);
        Assert.Equal(0.125f, r.GetZ(), precision: 6);
    }

    // ── Arithmetic operators ──────────────────────────────────────────────────

    [Fact]
    public void Vec3_Negation_FlipsAllComponents()
    {
        using var v = new JPH.Vec3(1f, -2f, 3f);
        using var r = -v;
        Assert.Equal(-1f,  r.GetX());
        Assert.Equal( 2f,  r.GetY());
        Assert.Equal(-3f,  r.GetZ());
    }

    [Fact]
    public void Vec3_ScalarMultiply_ScalesAllComponents()
    {
        using var v = new JPH.Vec3(1f, 2f, 3f);
        using var r = v * 3f;
        Assert.Equal(3f, r.GetX());
        Assert.Equal(6f, r.GetY());
        Assert.Equal(9f, r.GetZ());
    }

    [Fact]
    public void Vec3_ScalarDivide_DividesAllComponents()
    {
        using var v = new JPH.Vec3(6f, 4f, 2f);
        using var r = v / 2f;
        Assert.Equal(3f, r.GetX());
        Assert.Equal(2f, r.GetY());
        Assert.Equal(1f, r.GetZ());
    }

    [Fact]
    public void Vec3_ComponentWiseMultiply_CorrectResult()
    {
        using var a = new JPH.Vec3(2f, 3f, 4f);
        using var b = new JPH.Vec3(5f, 6f, 7f);
        using var r = a * b;
        Assert.Equal(10f, r.GetX());
        Assert.Equal(18f, r.GetY());
        Assert.Equal(28f, r.GetZ());
    }

    // ── CompressUnitVector round-trip ─────────────────────────────────────────

    [Theory]
    [InlineData(1f,  0f,  0f)]
    [InlineData(0f,  1f,  0f)]
    [InlineData(0f,  0f,  1f)]
    [InlineData(-1f, 0f,  0f)]
    [InlineData(0f, -1f,  0f)]
    [InlineData(0f,  0f, -1f)]
    public void Vec3_CompressDecompressUnitVector_AxesRoundTrip(float x, float y, float z)
    {
        using var v         = new JPH.Vec3(x, y, z);
        uint      compressed = v.CompressUnitVector();
        using var back      = JPH.Vec3.SDecompressUnitVector(compressed);
        Assert.Equal(x, back.GetX(), precision: 3);
        Assert.Equal(y, back.GetY(), precision: 3);
        Assert.Equal(z, back.GetZ(), precision: 3);
    }
}
