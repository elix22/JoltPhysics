// DVec3 (double-precision 3-vector) math tests, modelled on Jolt's DVec3Tests.cpp.
// Covers construction, setters, zero/axis/NaN statics, replicate, min/max/clamp,
// boolean masks (GetTrues/TestAnyTrue/TestAllTrue), comparisons (SEquals/SLess/…),
// FMA, select, bitwise ops, close/near-zero/normalized predicates, arithmetic
// operators, compound assign, dot, cross, length, normalize, sqrt, sign, and
// round-trip conversions to/from Vec3 and Vec4.

using Xunit;
using System;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_DVec3
{
    private const double Eps = 1e-10;

    // ── Static constants / constructors ───────────────────────────────────────

    [Fact]
    public void DVec3_SZero_AllZero()
    {
        var v = JPH.DVec3.SZero();
        Assert.Equal(0.0, v.GetX());
        Assert.Equal(0.0, v.GetY());
        Assert.Equal(0.0, v.GetZ());
    }

    [Fact]
    public void DVec3_SAxisX_Is_1_0_0()
    {
        var v = JPH.DVec3.SAxisX();
        Assert.Equal(1.0, v.GetX());
        Assert.Equal(0.0, v.GetY());
        Assert.Equal(0.0, v.GetZ());
    }

    [Fact]
    public void DVec3_SAxisY_Is_0_1_0()
    {
        var v = JPH.DVec3.SAxisY();
        Assert.Equal(0.0, v.GetX());
        Assert.Equal(1.0, v.GetY());
        Assert.Equal(0.0, v.GetZ());
    }

    [Fact]
    public void DVec3_SAxisZ_Is_0_0_1()
    {
        var v = JPH.DVec3.SAxisZ();
        Assert.Equal(0.0, v.GetX());
        Assert.Equal(0.0, v.GetY());
        Assert.Equal(1.0, v.GetZ());
    }

    [Fact]
    public void DVec3_SNaN_AllComponentsNaN()
    {
        var v = JPH.DVec3.SNaN();
        Assert.True(double.IsNaN(v.GetX()));
        Assert.True(double.IsNaN(v.GetY()));
        Assert.True(double.IsNaN(v.GetZ()));
        Assert.True(v.IsNaN());
    }

    // ── Construction & component access ──────────────────────────────────────

    [Fact]
    public void DVec3_Construct_ComponentsMatch()
    {
        var v = new JPH.DVec3(1.0, 2.0, 3.0);
        Assert.Equal(1.0, v.GetX());
        Assert.Equal(2.0, v.GetY());
        Assert.Equal(3.0, v.GetZ());

        // Index accessor
        Assert.Equal(1.0, v[0]);
        Assert.Equal(2.0, v[1]);
        Assert.Equal(3.0, v[2]);

        // Equality operators
        Assert.True(v == new JPH.DVec3(1.0, 2.0, 3.0));
        Assert.True(v != new JPH.DVec3(1.0, 2.0, 4.0));
    }

    [Fact]
    public void DVec3_SetComponent_UpdatesCorrectComponent()
    {
        var v = new JPH.DVec3(1.0, 2.0, 3.0);
        v.SetComponent(0, 4.0);
        v.SetComponent(1, 5.0);
        v.SetComponent(2, 6.0);
        Assert.Equal(4.0, v.GetX());
        Assert.Equal(5.0, v.GetY());
        Assert.Equal(6.0, v.GetZ());
    }

    [Fact]
    public void DVec3_SetXYZ_UpdatesComponents()
    {
        var v = new JPH.DVec3(1.0, 2.0, 3.0);
        v.SetX(7.0);
        v.SetY(8.0);
        v.SetZ(9.0);
        Assert.Equal(7.0, v.GetX());
        Assert.Equal(8.0, v.GetY());
        Assert.Equal(9.0, v.GetZ());
    }

    [Fact]
    public void DVec3_Set_UpdatesAllComponents()
    {
        var v = new JPH.DVec3(0.0, 0.0, 0.0);
        v.Set(10.0, 11.0, 12.0);
        Assert.Equal(10.0, v.GetX());
        Assert.Equal(11.0, v.GetY());
        Assert.Equal(12.0, v.GetZ());
    }

    // ── Construct from other vector types ─────────────────────────────────────

    [Fact]
    public void DVec3_ConstructFromVec4_XYZMatch()
    {
        var v4 = new JPH.Vec4(1f, 3f, 5f, 7f);
        var dv = new JPH.DVec3(v4);
        Assert.Equal(1.0, dv.GetX());
        Assert.Equal(3.0, dv.GetY());
        Assert.Equal(5.0, dv.GetZ());
    }

    [Fact]
    public void DVec3_ExplicitToVec3_XYZMatch()
    {
        var dv = new JPH.DVec3(1.0, 3.0, 5.0);
        var v = (JPH.Vec3)dv; // explicit cast
        Assert.Equal(1f, v.GetX());
        Assert.Equal(3f, v.GetY());
        Assert.Equal(5f, v.GetZ());
    }

    [Fact]
    public void DVec3_ToVec3RoundUp_RoundsTowardPositiveInfinity()
    {
        // 2.0 is exact in float; 0x1.0000000000001p1 is slightly above 2.0 → round up to next float
        double slightly_above_2 = BitConverter.Int64BitsToDouble(BitConverter.DoubleToInt64Bits(2.0) + 1);
        var dv = new JPH.DVec3(2.0, slightly_above_2, -slightly_above_2);
        var up  = dv.ToVec3RoundUp();
        var dn  = dv.ToVec3RoundDown();

        // X = 2.0 is exact; round-up and round-down must both give 2f
        Assert.Equal(2f, up.GetX());
        Assert.Equal(2f, dn.GetX());

        // Y: next float above 2.0 → round-up must be > 2f, round-down must be 2f
        Assert.True(up.GetY() > 2f);
        Assert.Equal(2f, dn.GetY());

        // Z: negative slightly-above-2 → round-down must be < -2f, round-up must be -2f
        Assert.Equal(-2f, up.GetZ());
        Assert.True(dn.GetZ() < -2f);
    }

    // ── Replicate / min / max / clamp ────────────────────────────────────────

    [Fact]
    public void DVec3_SReplicate_AllSame()
    {
        var v = JPH.DVec3.SReplicate(3.5);
        Assert.Equal(3.5, v.GetX());
        Assert.Equal(3.5, v.GetY());
        Assert.Equal(3.5, v.GetZ());
    }

    [Fact]
    public void DVec3_SMin_PicksSmaller()
    {
        var v1 = new JPH.DVec3(1.0, 5.0, 3.0);
        var v2 = new JPH.DVec3(4.0, 2.0, 6.0);
        var r  = JPH.Const_DVec3.SMin(v1, v2);
        Assert.Equal(1.0, r.GetX());
        Assert.Equal(2.0, r.GetY());
        Assert.Equal(3.0, r.GetZ());
    }

    [Fact]
    public void DVec3_SMax_PicksLarger()
    {
        var v1 = new JPH.DVec3(1.0, 5.0, 3.0);
        var v2 = new JPH.DVec3(4.0, 2.0, 6.0);
        var r  = JPH.Const_DVec3.SMax(v1, v2);
        Assert.Equal(4.0, r.GetX());
        Assert.Equal(5.0, r.GetY());
        Assert.Equal(6.0, r.GetZ());
    }

    [Fact]
    public void DVec3_SClamp_ClampedToRange()
    {
        var lo = new JPH.DVec3(1.0, 2.0, 3.0);
        var hi = new JPH.DVec3(4.0, 5.0, 6.0);
        var v  = new JPH.DVec3(-1.0, 3.0, 7.0);
        var r  = JPH.Const_DVec3.SClamp(v, lo, hi);
        Assert.Equal(1.0, r.GetX()); // clamped up
        Assert.Equal(3.0, r.GetY()); // in range
        Assert.Equal(6.0, r.GetZ()); // clamped down
    }

    // ── Boolean mask (GetTrues / TestAnyTrue / TestAllTrue) ──────────────────

    [Fact]
    public void DVec3_GetTrues_MatchesBitPattern()
    {
        double T = JPH.Const_DVec3.CTrue;
        double F = JPH.Const_DVec3.CFalse;

        Assert.Equal(0b000, new JPH.DVec3(F, F, F).GetTrues());
        Assert.Equal(0b001, new JPH.DVec3(T, F, F).GetTrues());
        Assert.Equal(0b010, new JPH.DVec3(F, T, F).GetTrues());
        Assert.Equal(0b011, new JPH.DVec3(T, T, F).GetTrues());
        Assert.Equal(0b100, new JPH.DVec3(F, F, T).GetTrues());
        Assert.Equal(0b101, new JPH.DVec3(T, F, T).GetTrues());
        Assert.Equal(0b110, new JPH.DVec3(F, T, T).GetTrues());
        Assert.Equal(0b111, new JPH.DVec3(T, T, T).GetTrues());
    }

    [Fact]
    public void DVec3_TestAnyTrue_ReturnsTrueIfAnyBitSet()
    {
        double T = JPH.Const_DVec3.CTrue;
        double F = JPH.Const_DVec3.CFalse;

        Assert.False(new JPH.DVec3(F, F, F).TestAnyTrue());
        Assert.True( new JPH.DVec3(T, F, F).TestAnyTrue());
        Assert.True( new JPH.DVec3(F, T, T).TestAnyTrue());
        Assert.True( new JPH.DVec3(T, T, T).TestAnyTrue());
    }

    [Fact]
    public void DVec3_TestAllTrue_OnlyWhenAllBitsSet()
    {
        double T = JPH.Const_DVec3.CTrue;
        double F = JPH.Const_DVec3.CFalse;

        Assert.False(new JPH.DVec3(F, F, F).TestAllTrue());
        Assert.False(new JPH.DVec3(T, T, F).TestAllTrue());
        Assert.True( new JPH.DVec3(T, T, T).TestAllTrue());
    }

    // ── Comparisons → mask ───────────────────────────────────────────────────

    [Fact]
    public void DVec3_SEquals_CorrectBits()
    {
        // Equals at indices 0 (1==1) and 2 (3==3), not 1 (2 vs 4) → bits 101 = 5
        var r = JPH.Const_DVec3.SEquals(new JPH.DVec3(1.0, 2.0, 3.0), new JPH.DVec3(1.0, 4.0, 3.0));
        Assert.Equal(0b101, r.GetTrues());
    }

    [Fact]
    public void DVec3_SLess_CorrectBits()
    {
        // v1=(1,2,4) < v2=(1,4,3): Y<Y → true (bit1), Z>Z → false, X==X → false → 0b010
        var r = JPH.Const_DVec3.SLess(new JPH.DVec3(1.0, 2.0, 4.0), new JPH.DVec3(1.0, 4.0, 3.0));
        Assert.Equal(0b010, r.GetTrues());
    }

    [Fact]
    public void DVec3_SLessOrEqual_CorrectBits()
    {
        // v1=(1,2,4) <= v2=(1,4,3): X<=X→T(bit0), Y<Y→T(bit1), Z>Z→F → 0b011
        var r = JPH.Const_DVec3.SLessOrEqual(new JPH.DVec3(1.0, 2.0, 4.0), new JPH.DVec3(1.0, 4.0, 3.0));
        Assert.Equal(0b011, r.GetTrues());
    }

    [Fact]
    public void DVec3_SGreater_CorrectBits()
    {
        // v1=(1,2,4) > v2=(1,4,3): Z>Z→T(bit2), others→F → 0b100
        var r = JPH.Const_DVec3.SGreater(new JPH.DVec3(1.0, 2.0, 4.0), new JPH.DVec3(1.0, 4.0, 3.0));
        Assert.Equal(0b100, r.GetTrues());
    }

    [Fact]
    public void DVec3_SGreaterOrEqual_CorrectBits()
    {
        // v1=(1,2,4) >= v2=(1,4,3): X==X→T(bit0), Z>Z→T(bit2) → 0b101
        var r = JPH.Const_DVec3.SGreaterOrEqual(new JPH.DVec3(1.0, 2.0, 4.0), new JPH.DVec3(1.0, 4.0, 3.0));
        Assert.Equal(0b101, r.GetTrues());
    }

    // ── FMA / Select / Bitwise ────────────────────────────────────────────────

    [Fact]
    public void DVec3_SFusedMultiplyAdd_Correct()
    {
        var r = JPH.Const_DVec3.SFusedMultiplyAdd(
            new JPH.DVec3(1.0, 2.0, 3.0),
            new JPH.DVec3(4.0, 5.0, 6.0),
            new JPH.DVec3(7.0, 8.0, 9.0));
        Assert.Equal(1.0 * 4.0 + 7.0, r.GetX());
        Assert.Equal(2.0 * 5.0 + 8.0, r.GetY());
        Assert.Equal(3.0 * 6.0 + 9.0, r.GetZ());
    }

    [Fact]
    public void DVec3_SSelect_HighBitSelectsSecond()
    {
        double T = JPH.Const_DVec3.CTrue;
        double F = JPH.Const_DVec3.CFalse;
        var r = JPH.Const_DVec3.SSelect(
            new JPH.DVec3(1.0, 2.0, 3.0), // inNotSet
            new JPH.DVec3(4.0, 5.0, 6.0), // inSet
            new JPH.DVec3(T,   F,   T));   // control
        Assert.Equal(4.0, r.GetX());
        Assert.Equal(2.0, r.GetY());
        Assert.Equal(6.0, r.GetZ());
    }

    // ── Predicates ────────────────────────────────────────────────────────────

    [Fact]
    public void DVec3_IsClose_TightTolerance()
    {
        Assert.True( new JPH.DVec3(1.0, 2.0, 3.0).IsClose(new JPH.DVec3(1.001, 2.001, 3.001), 1e-4));
        Assert.False(new JPH.DVec3(1.0, 2.0, 3.0).IsClose(new JPH.DVec3(1.001, 2.001, 3.001), 1e-6));
    }

    [Fact]
    public void DVec3_IsNormalized_SemiNormalized()
    {
        Assert.True( new JPH.DVec3(1.001, 0.0, 0.0).IsNormalized(1e-2));
        Assert.False(new JPH.DVec3(0.0, 1.001, 0.0).IsNormalized(1e-4));
    }

    [Fact]
    public void DVec3_IsNearZero_SmallComponents()
    {
        Assert.True( new JPH.DVec3(-1e-7, 1e-7, 1e-8).IsNearZero(1e-12));
        Assert.False(new JPH.DVec3(-1e-7, 1e-7, -1e-5).IsNearZero(1e-12));
    }

    [Fact]
    public void DVec3_IsNaN_FalseForNormal_TrueForNaN()
    {
        Assert.False(new JPH.DVec3(1.0, 2.0, 3.0).IsNaN());
        var nan = JPH.DVec3.SNaN();
        Assert.True(nan.IsNaN());
    }

    // ── Arithmetic operators ──────────────────────────────────────────────────

    [Fact]
    public void DVec3_Negate_Correct()
    {
        var r = -new JPH.DVec3(1.0, 2.0, 3.0);
        Assert.Equal(-1.0, r.GetX());
        Assert.Equal(-2.0, r.GetY());
        Assert.Equal(-3.0, r.GetZ());
    }

    [Fact]
    public void DVec3_Add_DVec3_Correct()
    {
        var r = new JPH.DVec3(1.0, 2.0, 3.0) + new JPH.DVec3(4.0, 5.0, 6.0);
        Assert.Equal(5.0, r.GetX());
        Assert.Equal(7.0, r.GetY());
        Assert.Equal(9.0, r.GetZ());
    }

    [Fact]
    public void DVec3_Add_Vec3_Correct()
    {
        var r = new JPH.DVec3(1.0, 2.0, 3.0) + new JPH.Vec3(4f, 5f, 6f);
        Assert.Equal(5.0, r.GetX());
        Assert.Equal(7.0, r.GetY());
        Assert.Equal(9.0, r.GetZ());
    }

    [Fact]
    public void DVec3_Subtract_DVec3_Correct()
    {
        var r = new JPH.DVec3(1.0, 2.0, 3.0) - new JPH.DVec3(6.0, 5.0, 4.0);
        Assert.Equal(-5.0, r.GetX());
        Assert.Equal(-3.0, r.GetY());
        Assert.Equal(-1.0, r.GetZ());
    }

    [Fact]
    public void DVec3_Subtract_Vec3_Correct()
    {
        var r = new JPH.DVec3(1.0, 2.0, 3.0) - new JPH.Vec3(6f, 5f, 4f);
        Assert.Equal(-5.0, r.GetX());
        Assert.Equal(-3.0, r.GetY());
        Assert.Equal(-1.0, r.GetZ());
    }

    [Fact]
    public void DVec3_Multiply_ByDVec3_Correct()
    {
        var r = new JPH.DVec3(1.0, 2.0, 3.0) * new JPH.DVec3(4.0, 5.0, 6.0);
        Assert.Equal(4.0,  r.GetX());
        Assert.Equal(10.0, r.GetY());
        Assert.Equal(18.0, r.GetZ());
    }

    [Fact]
    public void DVec3_Multiply_ByScalar_Correct()
    {
        var r = new JPH.DVec3(1.0, 2.0, 3.0) * 2.0;
        Assert.Equal(2.0, r.GetX());
        Assert.Equal(4.0, r.GetY());
        Assert.Equal(6.0, r.GetZ());
    }

    [Fact]
    public void DVec3_Multiply_ScalarLeft_Correct()
    {
        var r = 4.0 * new JPH.DVec3(1.0, 2.0, 3.0);
        Assert.Equal(4.0,  r.GetX());
        Assert.Equal(8.0,  r.GetY());
        Assert.Equal(12.0, r.GetZ());
    }

    [Fact]
    public void DVec3_Divide_ByScalar_Correct()
    {
        var r = new JPH.DVec3(1.0, 2.0, 3.0) / 2.0;
        Assert.Equal(0.5, r.GetX());
        Assert.Equal(1.0, r.GetY());
        Assert.Equal(1.5, r.GetZ());
    }

    [Fact]
    public void DVec3_Divide_ByDVec3_Correct()
    {
        var r = new JPH.DVec3(1.0, 2.0, 3.0) / new JPH.DVec3(2.0, 8.0, 24.0);
        Assert.Equal(0.5,    r.GetX());
        Assert.Equal(0.25,   r.GetY());
        Assert.Equal(0.125,  r.GetZ());
    }

    // ── Compound-assign methods ───────────────────────────────────────────────

    [Fact]
    public void DVec3_CompoundAssign_MulDivAddSub()
    {
        var v = new JPH.DVec3(1.0, 2.0, 3.0);
        v.MulAssign(new JPH.DVec3(4.0, 5.0, 6.0));
        Assert.Equal(4.0,  v.GetX());
        Assert.Equal(10.0, v.GetY());
        Assert.Equal(18.0, v.GetZ());

        v.MulAssign(2.0);
        Assert.Equal(8.0,  v.GetX());
        Assert.Equal(20.0, v.GetY());
        Assert.Equal(36.0, v.GetZ());

        v.DivAssign(2.0);
        Assert.Equal(4.0,  v.GetX());
        Assert.Equal(10.0, v.GetY());
        Assert.Equal(18.0, v.GetZ());

        v.AddAssign(new JPH.DVec3(1.0, 2.0, 3.0));
        Assert.Equal(5.0,  v.GetX());
        Assert.Equal(12.0, v.GetY());
        Assert.Equal(21.0, v.GetZ());

        v.SubAssign(new JPH.DVec3(1.0, 2.0, 3.0));
        Assert.Equal(4.0,  v.GetX());
        Assert.Equal(10.0, v.GetY());
        Assert.Equal(18.0, v.GetZ());
    }

    // ── Math operations ───────────────────────────────────────────────────────

    [Fact]
    public void DVec3_Reciprocal_Correct()
    {
        var r = new JPH.DVec3(2.0, 4.0, 8.0).Reciprocal();
        Assert.Equal(0.5,   r.GetX());
        Assert.Equal(0.25,  r.GetY());
        Assert.Equal(0.125, r.GetZ());
    }

    [Fact]
    public void DVec3_Abs_RemovesSign()
    {
        var r1 = new JPH.DVec3(1.0, -2.0, 3.0).Abs();
        Assert.Equal(1.0, r1.GetX());
        Assert.Equal(2.0, r1.GetY());
        Assert.Equal(3.0, r1.GetZ());

        var r2 = new JPH.DVec3(-1.0, 2.0, -3.0).Abs();
        Assert.Equal(1.0, r2.GetX());
        Assert.Equal(2.0, r2.GetY());
        Assert.Equal(3.0, r2.GetZ());
    }

    [Fact]
    public void DVec3_Dot_CorrectResult()
    {
        double dot = new JPH.DVec3(2.0, 3.0, 4.0).Dot(new JPH.DVec3(5.0, 6.0, 7.0));
        Assert.Equal(2.0 * 5.0 + 3.0 * 6.0 + 4.0 * 7.0, dot);
    }

    [Fact]
    public void DVec3_LengthSq_And_Length_Correct()
    {
        var v = new JPH.DVec3(2.0, 3.0, 4.0);
        Assert.Equal(4.0 + 9.0 + 16.0, v.LengthSq());
        Assert.Equal(Math.Sqrt(4.0 + 9.0 + 16.0), v.Length());
    }

    [Fact]
    public void DVec3_Normalized_UnitLength()
    {
        var v = new JPH.DVec3(3.0, 2.0, 1.0);
        double len = Math.Sqrt(9.0 + 4.0 + 1.0);
        var n = v.Normalized();
        Assert.Equal(3.0 / len, n.GetX(), 10);
        Assert.Equal(2.0 / len, n.GetY(), 10);
        Assert.Equal(1.0 / len, n.GetZ(), 10);
    }

    [Fact]
    public void DVec3_Cross_Correct()
    {
        Assert.True(new JPH.DVec3(1, 0, 0).Cross(new JPH.DVec3(0, 1, 0)) == new JPH.DVec3(0, 0, 1));
        Assert.True(new JPH.DVec3(0, 1, 0).Cross(new JPH.DVec3(1, 0, 0)) == new JPH.DVec3(0, 0, -1));
        Assert.True(new JPH.DVec3(0, 1, 0).Cross(new JPH.DVec3(0, 0, 1)) == new JPH.DVec3(1, 0, 0));
        Assert.True(new JPH.DVec3(0, 0, 1).Cross(new JPH.DVec3(0, 1, 0)) == new JPH.DVec3(-1, 0, 0));
    }

    [Fact]
    public void DVec3_Sqrt_Correct()
    {
        var r = new JPH.DVec3(13.0, 15.0, 17.0).Sqrt();
        Assert.Equal(Math.Sqrt(13.0), r.GetX(), 10);
        Assert.Equal(Math.Sqrt(15.0), r.GetY(), 10);
        Assert.Equal(Math.Sqrt(17.0), r.GetZ(), 10);
    }

    [Fact]
    public void DVec3_GetSign_Correct()
    {
        var r1 = new JPH.DVec3(1.2345, -6.7891, 0.0).GetSign();
        Assert.Equal(1.0,  r1.GetX());
        Assert.Equal(-1.0, r1.GetY());
        Assert.Equal(1.0,  r1.GetZ()); // 0 → +1 per Jolt convention
    }
}
