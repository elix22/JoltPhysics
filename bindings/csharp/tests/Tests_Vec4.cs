// Vec4 math tests, modelled on Jolt's Vec4Tests.cpp.
// Covers construction, equality, arithmetic, min/max/clamp,
// comparisons (→UVec4), FMA, dot/length, abs/reciprocal,
// IsClose/IsNearZero/IsNormalized, reduce, and the five bound swizzles.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Vec4
{
    // ── Construction ─────────────────────────────────────────────────────────

    [Fact]
    public void Vec4_SZero_AllComponentsZero()
    {
        var v = JPH.Vec4.SZero();
        Assert.Equal(0f, v.GetX());
        Assert.Equal(0f, v.GetY());
        Assert.Equal(0f, v.GetZ());
        Assert.Equal(0f, v.GetW());
    }

    [Fact]
    public void Vec4_SOne_AllComponentsOne()
    {
        var v = JPH.Vec4.SOne();
        Assert.Equal(1f, v.GetX());
        Assert.Equal(1f, v.GetY());
        Assert.Equal(1f, v.GetZ());
        Assert.Equal(1f, v.GetW());
    }

    [Theory]
    [InlineData(0f)]
    [InlineData(2f)]
    [InlineData(-3.14f)]
    public void Vec4_SReplicate_AllComponentsEqual(float val)
    {
        var v = JPH.Vec4.SReplicate(val);
        Assert.Equal(val, v.GetX());
        Assert.Equal(val, v.GetY());
        Assert.Equal(val, v.GetZ());
        Assert.Equal(val, v.GetW());
    }

    [Fact]
    public void Vec4_ConstructFromFloats_ComponentsMatch()
    {
        var v = new JPH.Vec4(1f, 2f, 3f, 4f);
        Assert.Equal(1f, v.GetX());
        Assert.Equal(2f, v.GetY());
        Assert.Equal(3f, v.GetZ());
        Assert.Equal(4f, v.GetW());
    }

    [Fact]
    public void Vec4_ConstructFromVec3_XYZMatch()
    {
        // Vec4(Vec3) copies the XYZ components; W is SIMD-implementation-defined
        // (Jolt's Vec3 stores W = Z in the underlying SIMD register, so W == Z here).
        var xyz = new JPH.Vec3(5f, 6f, 7f);
        var v = new JPH.Vec4(xyz);
        Assert.Equal(5f, v.GetX());
        Assert.Equal(6f, v.GetY());
        Assert.Equal(7f, v.GetZ());
    }

    [Fact]
    public void Vec4_ConstructFromVec3AndW_AllMatch()
    {
        var xyz = new JPH.Vec3(1f, 2f, 3f);
        var v = new JPH.Vec4(xyz, 4f);
        Assert.Equal(1f, v.GetX());
        Assert.Equal(2f, v.GetY());
        Assert.Equal(3f, v.GetZ());
        Assert.Equal(4f, v.GetW());
    }

    // ── Indexer ───────────────────────────────────────────────────────────────

    [Fact]
    public void Vec4_Indexer_MatchesGetXYZW()
    {
        var v = new JPH.Vec4(1f, 2f, 3f, 4f);
        Assert.Equal(v.GetX(), v[0]);
        Assert.Equal(v.GetY(), v[1]);
        Assert.Equal(v.GetZ(), v[2]);
        Assert.Equal(v.GetW(), v[3]);
    }

    // ── Equality ──────────────────────────────────────────────────────────────

    [Fact]
    public void Vec4_EqualityOp_SameVector_IsTrue()
    {
        var a = new JPH.Vec4(1f, 2f, 3f, 4f);
        var b = new JPH.Vec4(1f, 2f, 3f, 4f);
        Assert.True(a == b);
    }

    [Fact]
    public void Vec4_InequalityOp_DifferentComponents_IsTrue()
    {
        var a = new JPH.Vec4(1f, 2f, 3f, 4f);
        var b = new JPH.Vec4(1f, 2f, 4f, 3f);
        Assert.True(a != b);
    }

    // ── Arithmetic ────────────────────────────────────────────────────────────

    [Fact]
    public void Vec4_UnaryMinus_NegatesAll()
    {
        var r = -new JPH.Vec4(1f, 2f, 3f, 4f);
        Assert.True(r == new JPH.Vec4(-1f, -2f, -3f, -4f));
    }

    [Fact]
    public void Vec4_Add_ComponentwiseSum()
    {
        var r = new JPH.Vec4(1f, 2f, 3f, 4f) + new JPH.Vec4(5f, 6f, 7f, 8f);
        Assert.True(r == new JPH.Vec4(6f, 8f, 10f, 12f));
    }

    [Fact]
    public void Vec4_Subtract_ComponentwiseDiff()
    {
        var r = new JPH.Vec4(1f, 2f, 3f, 4f) - new JPH.Vec4(8f, 7f, 6f, 5f);
        Assert.True(r == new JPH.Vec4(-7f, -5f, -3f, -1f));
    }

    [Fact]
    public void Vec4_MultiplyVecVec_ComponentwiseMul()
    {
        var r = new JPH.Vec4(1f, 2f, 3f, 4f) * new JPH.Vec4(5f, 6f, 7f, 8f);
        Assert.True(r == new JPH.Vec4(5f, 12f, 21f, 32f));
    }

    [Fact]
    public void Vec4_MultiplyVecScalar_ScalesAll()
    {
        Assert.True(new JPH.Vec4(1f, 2f, 3f, 4f) * 2f == new JPH.Vec4(2f, 4f, 6f, 8f));
    }

    [Fact]
    public void Vec4_ScalarMultiplyVec_ScalesAll()
    {
        Assert.True(4f * new JPH.Vec4(1f, 2f, 3f, 4f) == new JPH.Vec4(4f, 8f, 12f, 16f));
    }

    [Fact]
    public void Vec4_DivideByScalar_DividesAll()
    {
        Assert.True(new JPH.Vec4(1f, 2f, 3f, 4f) / 2f == new JPH.Vec4(0.5f, 1f, 1.5f, 2f));
    }

    [Fact]
    public void Vec4_DivideByVec_ComponentwiseDiv()
    {
        var r = new JPH.Vec4(1f, 2f, 3f, 4f) / new JPH.Vec4(2f, 8f, 24f, 64f);
        Assert.True(r == new JPH.Vec4(0.5f, 0.25f, 0.125f, 0.0625f));
    }

    [Fact]
    public void Vec4_CompoundOperators_CorrectResults()
    {
        var v = new JPH.Vec4(1f, 2f, 3f, 4f);
        v *= new JPH.Vec4(5f, 6f, 7f, 8f);
        Assert.True(v == new JPH.Vec4(5f, 12f, 21f, 32f));
        v *= 2f;
        Assert.True(v == new JPH.Vec4(10f, 24f, 42f, 64f));
        v /= 2f;
        Assert.True(v == new JPH.Vec4(5f, 12f, 21f, 32f));
        v += new JPH.Vec4(1f, 2f, 3f, 4f);
        Assert.True(v == new JPH.Vec4(6f, 14f, 24f, 36f));
    }

    // ── Static min/max/clamp/reduce ──────────────────────────────────────────

    [Fact]
    public void Vec4_SMin_TakesMinPerComponent()
    {
        var v1 = new JPH.Vec4(1f, 6f, 3f, 8f);
        var v2 = new JPH.Vec4(5f, 2f, 7f, 4f);
        Assert.True(JPH.Vec4.SMin(v1, v2) == new JPH.Vec4(1f, 2f, 3f, 4f));
    }

    [Fact]
    public void Vec4_SMax_TakesMaxPerComponent()
    {
        var v1 = new JPH.Vec4(1f, 6f, 3f, 8f);
        var v2 = new JPH.Vec4(5f, 2f, 7f, 4f);
        Assert.True(JPH.Vec4.SMax(v1, v2) == new JPH.Vec4(5f, 6f, 7f, 8f));
    }

    [Fact]
    public void Vec4_SClamp_ClampsToRange()
    {
        var v  = new JPH.Vec4(-1f,  3f,  9f, -11f);
        var lo = new JPH.Vec4( 1f,  2f,  3f,   4f);
        var hi = new JPH.Vec4( 5f,  6f,  7f,   8f);
        Assert.True(JPH.Vec4.SClamp(v, lo, hi) == new JPH.Vec4(1f, 3f, 7f, 4f));
    }

    [Fact]
    public void Vec4_ReduceMin_ReturnsSmallestComponent()
    {
        Assert.Equal(1f, new JPH.Vec4(1f, 6f, 3f, 8f).ReduceMin(), precision: 6);
    }

    [Fact]
    public void Vec4_ReduceMax_ReturnsLargestComponent()
    {
        Assert.Equal(8f, new JPH.Vec4(1f, 6f, 3f, 8f).ReduceMax(), precision: 6);
    }

    // ── Comparisons (→ UVec4) ────────────────────────────────────────────────

    [Fact]
    public void Vec4_SEquals_IdentifiesEqualComponents()
    {
        // SEquals(1,2,3,4 ; 2,1,3,4): X→0, Y→0, Z→0xffffffff, W→0xffffffff
        var r = JPH.Vec4.SEquals(new JPH.Vec4(1f, 2f, 3f, 4f), new JPH.Vec4(2f, 1f, 3f, 4f));
        Assert.Equal(0u,           r.GetX());
        Assert.Equal(0u,           r.GetY());
        Assert.Equal(0xffffffffu,  r.GetZ());
        Assert.Equal(0xffffffffu,  r.GetW());
    }

    [Fact]
    public void Vec4_SLess_IdentifiesLessComponents()
    {
        // SLess(1,2,3,4 ; 2,1,3,4): X→true, Y→false, Z→false, W→false
        var r = JPH.Vec4.SLess(new JPH.Vec4(1f, 2f, 3f, 4f), new JPH.Vec4(2f, 1f, 3f, 4f));
        Assert.Equal(0xffffffffu, r.GetX());
        Assert.Equal(0u,          r.GetY());
        Assert.Equal(0u,          r.GetZ());
        Assert.Equal(0u,          r.GetW());
    }

    [Fact]
    public void Vec4_SLessOrEqual_IdentifiesLeqComponents()
    {
        // SLessOrEqual(1,2,3,4 ; 2,1,3,4): X→true, Y→false, Z→true, W→true
        var r = JPH.Vec4.SLessOrEqual(new JPH.Vec4(1f, 2f, 3f, 4f), new JPH.Vec4(2f, 1f, 3f, 4f));
        Assert.Equal(0xffffffffu, r.GetX());
        Assert.Equal(0u,          r.GetY());
        Assert.Equal(0xffffffffu, r.GetZ());
        Assert.Equal(0xffffffffu, r.GetW());
    }

    [Fact]
    public void Vec4_SGreater_IdentifiesGreaterComponents()
    {
        // SGreater(1,2,3,4 ; 2,1,3,4): X→false, Y→true, Z→false, W→false
        var r = JPH.Vec4.SGreater(new JPH.Vec4(1f, 2f, 3f, 4f), new JPH.Vec4(2f, 1f, 3f, 4f));
        Assert.Equal(0u,          r.GetX());
        Assert.Equal(0xffffffffu, r.GetY());
        Assert.Equal(0u,          r.GetZ());
        Assert.Equal(0u,          r.GetW());
    }

    [Fact]
    public void Vec4_SGreaterOrEqual_IdentifiesGeqComponents()
    {
        // SGreaterOrEqual(1,2,3,4 ; 2,1,3,4): X→false, Y→true, Z→true, W→true
        var r = JPH.Vec4.SGreaterOrEqual(new JPH.Vec4(1f, 2f, 3f, 4f), new JPH.Vec4(2f, 1f, 3f, 4f));
        Assert.Equal(0u,          r.GetX());
        Assert.Equal(0xffffffffu, r.GetY());
        Assert.Equal(0xffffffffu, r.GetZ());
        Assert.Equal(0xffffffffu, r.GetW());
    }

    // ── SFusedMultiplyAdd ────────────────────────────────────────────────────

    [Fact]
    public void Vec4_SFusedMultiplyAdd_ComputesATimesBPlusC()
    {
        // FMA(a, b, c) = a*b + c
        // (1*5+9, 2*6+10, 3*7+11, 4*8+12) = (14, 22, 32, 44)
        var r = JPH.Vec4.SFusedMultiplyAdd(
            new JPH.Vec4(1f, 2f, 3f, 4f),
            new JPH.Vec4(5f, 6f, 7f, 8f),
            new JPH.Vec4(9f, 10f, 11f, 12f));
        Assert.True(r == new JPH.Vec4(14f, 22f, 32f, 44f));
    }

    // ── Dot, Length ──────────────────────────────────────────────────────────

    [Fact]
    public void Vec4_Dot_CorrectResult()
    {
        // 1*5 + 2*6 + 3*7 + 4*8 = 5+12+21+32 = 70
        float d = new JPH.Vec4(1f, 2f, 3f, 4f).Dot(new JPH.Vec4(5f, 6f, 7f, 8f));
        Assert.Equal(70f, d, precision: 5);
    }

    [Fact]
    public void Vec4_LengthSq_CorrectResult()
    {
        // 1+4+9+16 = 30
        Assert.Equal(30f, new JPH.Vec4(1f, 2f, 3f, 4f).LengthSq(), precision: 5);
    }

    [Fact]
    public void Vec4_Length_CorrectResult()
    {
        // (0,3,4,0) → length = 5
        Assert.Equal(5f, new JPH.Vec4(0f, 3f, 4f, 0f).Length(), precision: 5);
    }

    [Fact]
    public void Vec4_Normalized_LengthIsOne()
    {
        Assert.Equal(1f, new JPH.Vec4(1f, 2f, 3f, 4f).Normalized().Length(), precision: 5);
    }

    // ── Abs, Reciprocal ──────────────────────────────────────────────────────

    [Fact]
    public void Vec4_Abs_NegativesToPositives()
    {
        Assert.True(new JPH.Vec4(-1f, 2f, -3f, 4f).Abs() == new JPH.Vec4(1f, 2f, 3f, 4f));
    }

    [Fact]
    public void Vec4_Reciprocal_InvertedComponents()
    {
        Assert.True(new JPH.Vec4(2f, 4f, 8f, 16f).Reciprocal() == new JPH.Vec4(0.5f, 0.25f, 0.125f, 0.0625f));
    }

    // ── IsClose / IsNearZero / IsNormalized ──────────────────────────────────

    [Fact]
    public void Vec4_IsClose_WithinTolerance_IsTrue()
    {
        var a = new JPH.Vec4(1f, 2f, 3f, 4f);
        var b = new JPH.Vec4(1.001f, 2.001f, 3.001f, 4.001f);
        Assert.True(a.IsClose(b, 1e-4f));
        Assert.False(a.IsClose(b, 1e-6f));
    }

    [Fact]
    public void Vec4_IsNearZero_ZeroVector_IsTrue()
    {
        Assert.True(JPH.Vec4.SZero().IsNearZero());
    }

    [Fact]
    public void Vec4_IsNearZero_SmallComponents_IsTrue()
    {
        Assert.True(new JPH.Vec4(-1e-7f, 1e-7f, 1e-8f, -1e-8f).IsNearZero());
    }

    [Fact]
    public void Vec4_IsNearZero_LargerComponents_IsFalse()
    {
        Assert.False(new JPH.Vec4(-1e-7f, 1e-7f, -1e-5f, 1e-5f).IsNearZero());
    }

    [Fact]
    public void Vec4_IsNormalized_AlmostNormalized_IsTrue()
    {
        Assert.True(new JPH.Vec4(1.001f, 0f, 0f, 0f).IsNormalized(1e-2f));
    }

    [Fact]
    public void Vec4_IsNormalized_OffNormalization_IsFalse()
    {
        Assert.False(new JPH.Vec4(0f, 1.001f, 0f, 0f).IsNormalized(1e-4f));
    }

    // ── Swizzle (5 bound variants) ────────────────────────────────────────────

    [Fact]
    public void Vec4_Swizzle_2_3_0_1_OutputIsZWXY()
    {
        // (z, w, x, y) = (3, 4, 1, 2)
        Assert.True(new JPH.Vec4(1f, 2f, 3f, 4f).Swizzle_2_3_0_1() == new JPH.Vec4(3f, 4f, 1f, 2f));
    }

    [Fact]
    public void Vec4_Swizzle_1_0_3_2_OutputIsYXWZ()
    {
        // (y, x, w, z) = (2, 1, 4, 3)
        Assert.True(new JPH.Vec4(1f, 2f, 3f, 4f).Swizzle_1_0_3_2() == new JPH.Vec4(2f, 1f, 4f, 3f));
    }

    [Fact]
    public void Vec4_Swizzle_0_2_1_3_OutputIsXZYW()
    {
        // (x, z, y, w) = (1, 3, 2, 4)
        Assert.True(new JPH.Vec4(1f, 2f, 3f, 4f).Swizzle_0_2_1_3() == new JPH.Vec4(1f, 3f, 2f, 4f));
    }

    [Fact]
    public void Vec4_Swizzle_1_2_3_2_OutputIsYZWZ()
    {
        // (y, z, w, z) = (2, 3, 4, 3)
        Assert.True(new JPH.Vec4(1f, 2f, 3f, 4f).Swizzle_1_2_3_2() == new JPH.Vec4(2f, 3f, 4f, 3f));
    }

    [Fact]
    public void Vec4_Swizzle_2_2_2_2_BroadcastsZ()
    {
        // (z, z, z, z) = (3, 3, 3, 3)
        Assert.True(new JPH.Vec4(1f, 2f, 3f, 4f).Swizzle_2_2_2_2() == new JPH.Vec4(3f, 3f, 3f, 3f));
    }
}
