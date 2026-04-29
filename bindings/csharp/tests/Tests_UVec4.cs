// UVec4 math tests, modelled on Jolt's UVec4Tests.cpp.
// Covers construction, components, zero/replicate, min/max, comparisons,
// GetTrues/CountTrues/TestAllTrue/TestAnyTrue, XYZ variants, select,
// bitwise ops, arithmetic operators, compound add, splat, and swizzles.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_UVec4
{
    // ── Construction ─────────────────────────────────────────────────────────

    [Fact]
    public void UVec4_Construct_ComponentsMatch()
    {
        var v = new JPH.UVec4(1u, 2u, 3u, 4u);
        Assert.Equal(1u, v.GetX());
        Assert.Equal(2u, v.GetY());
        Assert.Equal(3u, v.GetZ());
        Assert.Equal(4u, v.GetW());

        // Index accessor
        Assert.Equal(1u, v[0]);
        Assert.Equal(2u, v[1]);
        Assert.Equal(3u, v[2]);
        Assert.Equal(4u, v[3]);
    }

    [Fact]
    public void UVec4_Construct_EqualityAndInequality()
    {
        var v = new JPH.UVec4(1u, 2u, 3u, 4u);
        Assert.True(v == new JPH.UVec4(1u, 2u, 3u, 4u));
        Assert.False(v == new JPH.UVec4(1u, 2u, 4u, 3u));
        Assert.True(v != new JPH.UVec4(1u, 2u, 4u, 3u));
    }

    [Fact]
    public void UVec4_Components_SetXYZW()
    {
        var v = new JPH.UVec4(1u, 2u, 3u, 4u);
        v.SetX(5u);
        v.SetY(6u);
        v.SetZ(7u);
        v.SetW(8u);
        Assert.Equal(5u, v.GetX());
        Assert.Equal(6u, v.GetY());
        Assert.Equal(7u, v.GetZ());
        Assert.Equal(8u, v.GetW());
    }

    // ── Static constructors ───────────────────────────────────────────────────

    [Fact]
    public void UVec4_SZero_AllZero()
    {
        var v = JPH.UVec4.SZero();
        Assert.Equal(0u, v.GetX());
        Assert.Equal(0u, v.GetY());
        Assert.Equal(0u, v.GetZ());
        Assert.Equal(0u, v.GetW());
    }

    [Fact]
    public void UVec4_SReplicate_AllSame()
    {
        var v = JPH.UVec4.SReplicate(7u);
        Assert.Equal(7u, v.GetX());
        Assert.Equal(7u, v.GetY());
        Assert.Equal(7u, v.GetZ());
        Assert.Equal(7u, v.GetW());
    }

    // ── Min / Max ─────────────────────────────────────────────────────────────

    [Fact]
    public void UVec4_SMin_PicksSmaller()
    {
        var v1 = new JPH.UVec4(1u, 6u, 3u, 8u);
        var v2 = new JPH.UVec4(5u, 2u, 7u, 4u);
        var r = JPH.Const_UVec4.SMin(v1, v2);
        Assert.Equal(1u, r.GetX());
        Assert.Equal(2u, r.GetY());
        Assert.Equal(3u, r.GetZ());
        Assert.Equal(4u, r.GetW());
    }

    [Fact]
    public void UVec4_SMax_PicksLarger()
    {
        var v1 = new JPH.UVec4(1u, 6u, 3u, 8u);
        var v2 = new JPH.UVec4(5u, 2u, 7u, 4u);
        var r = JPH.Const_UVec4.SMax(v1, v2);
        Assert.Equal(5u, r.GetX());
        Assert.Equal(6u, r.GetY());
        Assert.Equal(7u, r.GetZ());
        Assert.Equal(8u, r.GetW());
    }

    // ── Comparisons / boolean masks ───────────────────────────────────────────

    [Fact]
    public void UVec4_SEquals_MatchingElementsAllOnes()
    {
        // SEquals returns 0xffffffff for equal elements, 0 for unequal
        var r = JPH.Const_UVec4.SEquals(new JPH.UVec4(1u, 2u, 3u, 4u), new JPH.UVec4(2u, 1u, 3u, 4u));
        Assert.Equal(0u,          r.GetX()); // 1 != 2
        Assert.Equal(0u,          r.GetY()); // 2 != 1
        Assert.Equal(0xffffffffU, r.GetZ()); // 3 == 3
        Assert.Equal(0xffffffffU, r.GetW()); // 4 == 4
    }

    [Fact]
    public void UVec4_GetTrues_MapsHighBitPerComponent()
    {
        // High bit set (0xffffffff) → bit in GetTrues(); 0 → clear
        // Bit 0 = X, bit 1 = Y, bit 2 = Z, bit 3 = W
        Assert.Equal(0b0000, new JPH.UVec4(0x00000000U, 0x00000000U, 0x00000000U, 0x00000000U).GetTrues());
        Assert.Equal(0b0001, new JPH.UVec4(0xffffffffU, 0x00000000U, 0x00000000U, 0x00000000U).GetTrues());
        Assert.Equal(0b0010, new JPH.UVec4(0x00000000U, 0xffffffffU, 0x00000000U, 0x00000000U).GetTrues());
        Assert.Equal(0b0100, new JPH.UVec4(0x00000000U, 0x00000000U, 0xffffffffU, 0x00000000U).GetTrues());
        Assert.Equal(0b1000, new JPH.UVec4(0x00000000U, 0x00000000U, 0x00000000U, 0xffffffffU).GetTrues());
        Assert.Equal(0b1111, new JPH.UVec4(0xffffffffU, 0xffffffffU, 0xffffffffU, 0xffffffffU).GetTrues());
        Assert.Equal(0b0011, new JPH.UVec4(0xffffffffU, 0xffffffffU, 0x00000000U, 0x00000000U).GetTrues());
        Assert.Equal(0b0101, new JPH.UVec4(0xffffffffU, 0x00000000U, 0xffffffffU, 0x00000000U).GetTrues());
        Assert.Equal(0b1001, new JPH.UVec4(0xffffffffU, 0x00000000U, 0x00000000U, 0xffffffffU).GetTrues());
    }

    [Fact]
    public void UVec4_CountTrues_CountsSetComponents()
    {
        Assert.Equal(0, new JPH.UVec4(0x00000000U, 0x00000000U, 0x00000000U, 0x00000000U).CountTrues());
        Assert.Equal(1, new JPH.UVec4(0xffffffffU, 0x00000000U, 0x00000000U, 0x00000000U).CountTrues());
        Assert.Equal(2, new JPH.UVec4(0xffffffffU, 0xffffffffU, 0x00000000U, 0x00000000U).CountTrues());
        Assert.Equal(3, new JPH.UVec4(0xffffffffU, 0xffffffffU, 0xffffffffU, 0x00000000U).CountTrues());
        Assert.Equal(4, new JPH.UVec4(0xffffffffU, 0xffffffffU, 0xffffffffU, 0xffffffffU).CountTrues());
    }

    [Fact]
    public void UVec4_TestAllTrue_OnlyWhenAll0xffffffff()
    {
        Assert.False(new JPH.UVec4(0x00000000U, 0x00000000U, 0x00000000U, 0x00000000U).TestAllTrue());
        Assert.False(new JPH.UVec4(0xffffffffU, 0xffffffffU, 0xffffffffU, 0x00000000U).TestAllTrue());
        Assert.True( new JPH.UVec4(0xffffffffU, 0xffffffffU, 0xffffffffU, 0xffffffffU).TestAllTrue());
    }

    [Fact]
    public void UVec4_TestAnyTrue_WhenAnyComponentIsAllOnes()
    {
        Assert.False(new JPH.UVec4(0x00000000U, 0x00000000U, 0x00000000U, 0x00000000U).TestAnyTrue());
        Assert.True( new JPH.UVec4(0xffffffffU, 0x00000000U, 0x00000000U, 0x00000000U).TestAnyTrue());
        Assert.True( new JPH.UVec4(0x00000000U, 0x00000000U, 0x00000000U, 0xffffffffU).TestAnyTrue());
    }

    [Fact]
    public void UVec4_TestAllXYZTrue_IgnoresW()
    {
        // XYZ all true, W false → true (W is ignored)
        Assert.True( new JPH.UVec4(0xffffffffU, 0xffffffffU, 0xffffffffU, 0x00000000U).TestAllXYZTrue());
        // XYZ all true, W true → also true
        Assert.True( new JPH.UVec4(0xffffffffU, 0xffffffffU, 0xffffffffU, 0xffffffffU).TestAllXYZTrue());
        // Not all XYZ true
        Assert.False(new JPH.UVec4(0xffffffffU, 0xffffffffU, 0x00000000U, 0x00000000U).TestAllXYZTrue());
        // Only W true → false
        Assert.False(new JPH.UVec4(0x00000000U, 0x00000000U, 0x00000000U, 0xffffffffU).TestAllXYZTrue());
    }

    [Fact]
    public void UVec4_TestAnyXYZTrue_IgnoresW()
    {
        // All zero → false
        Assert.False(new JPH.UVec4(0x00000000U, 0x00000000U, 0x00000000U, 0x00000000U).TestAnyXYZTrue());
        // Only W set → false (W not counted for XYZ)
        Assert.False(new JPH.UVec4(0x00000000U, 0x00000000U, 0x00000000U, 0xffffffffU).TestAnyXYZTrue());
        // X set → true
        Assert.True( new JPH.UVec4(0xffffffffU, 0x00000000U, 0x00000000U, 0x00000000U).TestAnyXYZTrue());
        // Z set → true
        Assert.True( new JPH.UVec4(0x00000000U, 0x00000000U, 0xffffffffU, 0x00000000U).TestAnyXYZTrue());
    }

    // ── Select ────────────────────────────────────────────────────────────────

    [Fact]
    public void UVec4_SSelect_HighBitSelectsSetVector()
    {
        // When control high bit is set (0x80000000) → picks from inSet;
        // when clear (0) → picks from inNotSet.
        var r = JPH.Const_UVec4.SSelect(
            new JPH.UVec4(1u, 2u, 3u, 4u),         // inNotSet
            new JPH.UVec4(5u, 6u, 7u, 8u),         // inSet
            new JPH.UVec4(0x80000000U, 0u, 0x80000000U, 0u)); // control
        Assert.Equal(5u, r.GetX()); // control high bit set → inSet
        Assert.Equal(2u, r.GetY()); // control 0 → inNotSet
        Assert.Equal(7u, r.GetZ()); // control high bit set → inSet
        Assert.Equal(4u, r.GetW()); // control 0 → inNotSet
    }

    // ── Bitwise operations ────────────────────────────────────────────────────

    [Fact]
    public void UVec4_SOr_BitwiseOr()
    {
        var v1 = new JPH.UVec4(0b0011u, 0b0110u, 0b1100u, 0b1001u);
        var v2 = new JPH.UVec4(0b0101u, 0b1010u, 0b0101u, 0b0110u);
        var r = JPH.Const_UVec4.SOr(v1, v2);
        Assert.Equal(0b0111u, r.GetX());
        Assert.Equal(0b1110u, r.GetY());
        Assert.Equal(0b1101u, r.GetZ());
        Assert.Equal(0b1111u, r.GetW());
    }

    [Fact]
    public void UVec4_SXor_BitwiseXor()
    {
        var v1 = new JPH.UVec4(0b0011u, 0b0110u, 0b1100u, 0b1001u);
        var v2 = new JPH.UVec4(0b0101u, 0b1010u, 0b0101u, 0b0110u);
        var r = JPH.Const_UVec4.SXor(v1, v2);
        Assert.Equal(0b0110u, r.GetX());
        Assert.Equal(0b1100u, r.GetY());
        Assert.Equal(0b1001u, r.GetZ());
        Assert.Equal(0b1111u, r.GetW());
    }

    [Fact]
    public void UVec4_SAnd_BitwiseAnd()
    {
        var v1 = new JPH.UVec4(0b0011u, 0b0110u, 0b1100u, 0b1001u);
        var v2 = new JPH.UVec4(0b0101u, 0b1010u, 0b0101u, 0b0110u);
        var r = JPH.Const_UVec4.SAnd(v1, v2);
        Assert.Equal(0b0001u, r.GetX());
        Assert.Equal(0b0010u, r.GetY());
        Assert.Equal(0b0100u, r.GetZ());
        Assert.Equal(0b0000u, r.GetW());
    }

    [Fact]
    public void UVec4_SNot_InvertsBits()
    {
        var v = new JPH.UVec4(3u, 6u, 12u, 24u);
        var r = JPH.Const_UVec4.SNot(v);
        Assert.Equal(0xfffffffcU, r.GetX()); // ~3
        Assert.Equal(0xfffffff9U, r.GetY()); // ~6
        Assert.Equal(0xfffffff3U, r.GetZ()); // ~12
        Assert.Equal(0xffffffe7U, r.GetW()); // ~24
    }

    // ── Arithmetic operators ──────────────────────────────────────────────────

    [Fact]
    public void UVec4_Add_ComponentWise()
    {
        var r = new JPH.UVec4(1u, 2u, 3u, 4u) + new JPH.UVec4(5u, 6u, 7u, 8u);
        Assert.Equal(6u,  r.GetX());
        Assert.Equal(8u,  r.GetY());
        Assert.Equal(10u, r.GetZ());
        Assert.Equal(12u, r.GetW());
    }

    [Fact]
    public void UVec4_Subtract_ComponentWise()
    {
        var r = new JPH.UVec4(5u, 6u, 7u, 8u) - new JPH.UVec4(4u, 3u, 2u, 1u);
        Assert.Equal(1u, r.GetX());
        Assert.Equal(3u, r.GetY());
        Assert.Equal(5u, r.GetZ());
        Assert.Equal(7u, r.GetW());
    }

    [Fact]
    public void UVec4_Multiply_ComponentWise()
    {
        var r = new JPH.UVec4(1u, 2u, 3u, 4u) * new JPH.UVec4(5u, 6u, 7u, 8u);
        Assert.Equal(5u,  r.GetX());
        Assert.Equal(12u, r.GetY());
        Assert.Equal(21u, r.GetZ());
        Assert.Equal(32u, r.GetW());
    }

    [Fact]
    public void UVec4_AddAssign_UpdatesValue()
    {
        var v = new JPH.UVec4(1u, 2u, 3u, 4u);
        v.AddAssign(new JPH.UVec4(5u, 6u, 7u, 8u));
        Assert.Equal(6u,  v.GetX());
        Assert.Equal(8u,  v.GetY());
        Assert.Equal(10u, v.GetZ());
        Assert.Equal(12u, v.GetW());
    }

    // ── Splat ─────────────────────────────────────────────────────────────────

    [Fact]
    public void UVec4_SplatX_ReplicatesX()
    {
        var v = new JPH.UVec4(1u, 2u, 3u, 4u);
        var r = v.SplatX();
        Assert.Equal(1u, r.GetX());
        Assert.Equal(1u, r.GetY());
        Assert.Equal(1u, r.GetZ());
        Assert.Equal(1u, r.GetW());
    }

    [Fact]
    public void UVec4_SplatY_ReplicatesY()
    {
        var r = new JPH.UVec4(1u, 2u, 3u, 4u).SplatY();
        Assert.Equal(2u, r.GetX());
        Assert.Equal(2u, r.GetY());
        Assert.Equal(2u, r.GetZ());
        Assert.Equal(2u, r.GetW());
    }

    [Fact]
    public void UVec4_SplatZ_ReplicatesZ()
    {
        var r = new JPH.UVec4(1u, 2u, 3u, 4u).SplatZ();
        Assert.Equal(3u, r.GetX());
        Assert.Equal(3u, r.GetY());
        Assert.Equal(3u, r.GetZ());
        Assert.Equal(3u, r.GetW());
    }

    [Fact]
    public void UVec4_SplatW_ReplicatesW()
    {
        var r = new JPH.UVec4(1u, 2u, 3u, 4u).SplatW();
        Assert.Equal(4u, r.GetX());
        Assert.Equal(4u, r.GetY());
        Assert.Equal(4u, r.GetZ());
        Assert.Equal(4u, r.GetW());
    }

    // ── Swizzles ──────────────────────────────────────────────────────────────

    [Fact]
    public void UVec4_Swizzle_2_3_0_1_OutputIsZWXY()
    {
        var v = new JPH.UVec4(1u, 2u, 3u, 4u);
        var r = v.Swizzle_2_3_0_1(); // Z, W, X, Y
        Assert.Equal(3u, r.GetX());
        Assert.Equal(4u, r.GetY());
        Assert.Equal(1u, r.GetZ());
        Assert.Equal(2u, r.GetW());
    }

    [Fact]
    public void UVec4_Swizzle_1_0_3_2_OutputIsYXWZ()
    {
        var v = new JPH.UVec4(1u, 2u, 3u, 4u);
        var r = v.Swizzle_1_0_3_2(); // Y, X, W, Z
        Assert.Equal(2u, r.GetX());
        Assert.Equal(1u, r.GetY());
        Assert.Equal(4u, r.GetZ());
        Assert.Equal(3u, r.GetW());
    }
}
