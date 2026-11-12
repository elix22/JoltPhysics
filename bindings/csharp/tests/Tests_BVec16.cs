// BVec16 (16-component boolean vector) math tests, modelled on Jolt's BVec16Tests.cpp.
// Each byte component is 0x00 (false) or 0xff (true).
// Covers construction, index access, equality/inequality, SZero, SReplicate,
// SEquals + GetTrues, TestAnyTrue, TestAllTrue, and bitwise ops (SOr, SXor, SAnd, SNot).

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_BVec16
{
    private static JPH.BVec16 All(byte b)
        => new JPH.BVec16(b, b, b, b, b, b, b, b, b, b, b, b, b, b, b, b);

    // ── Construction ─────────────────────────────────────────────────────────

    [Fact]
    public void BVec16_Construct_ComponentsMatch()
    {
        var v = new JPH.BVec16(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
        for (byte i = 0; i < 16; i++)
            Assert.Equal(i, v[i]);
    }

    [Fact]
    public void BVec16_Construct_EqualityAndInequality()
    {
        var a = new JPH.BVec16(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
        var b = new JPH.BVec16(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
        var c = new JPH.BVec16(0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
        Assert.True(a == b);
        Assert.False(a == c);
        Assert.True(a != c);
    }

    // ── Static constructors ───────────────────────────────────────────────────

    [Fact]
    public void BVec16_SZero_AllZero()
    {
        var v = JPH.BVec16.SZero();
        for (byte i = 0; i < 16; i++)
            Assert.Equal(0, v[i]);
    }

    [Fact]
    public void BVec16_SReplicate_AllSame()
    {
        var v = JPH.BVec16.SReplicate(0x42);
        for (byte i = 0; i < 16; i++)
            Assert.Equal(0x42, v[i]);
    }

    // ── SEquals + GetTrues ───────────────────────────────────────────────────

    [Fact]
    public void BVec16_SEquals_GetTrues_MatchesExpectedBits()
    {
        // From Jolt BVec16Tests.cpp:
        // BVec16(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16) vs
        // BVec16(6,7,3,4,5,6,7,5,9,10,11,12,13,14,15,13)
        //  idx:  0 1 2 3 4 5 6 7 8  9 10 11 12 13 14 15
        //  eq:   F F T T T T T F T  T  T  T  T  T  T  F
        //  bits: 0 0 1 1 1 1 1 0 1  1  1  1  1  1  1  0
        //  binary from bit0 (idx0) to bit15: 0b0111111101111100 = 32636
        var v1 = new JPH.BVec16(1,  2,  3,  4,  5,  6,  7,  8,  9,  10, 11, 12, 13, 14, 15, 16);
        var v2 = new JPH.BVec16(6,  7,  3,  4,  5,  6,  7,  5,  9,  10, 11, 12, 13, 14, 15, 13);
        var eq = JPH.Const_BVec16.SEquals(v1, v2);
        Assert.Equal(32636, eq.GetTrues()); // 0b0111111101111100
    }

    [Fact]
    public void BVec16_SEquals_AllMatch_AllTrues()
    {
        var v = new JPH.BVec16(5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5);
        var eq = JPH.Const_BVec16.SEquals(v, v);
        Assert.Equal(0xffff, eq.GetTrues()); // all 16 bits set
    }

    [Fact]
    public void BVec16_SEquals_AllMismatch_ZeroTrues()
    {
        var v1 = All(0x00);
        var v2 = All(0xff);
        var eq = JPH.Const_BVec16.SEquals(v1, v2);
        Assert.Equal(0, eq.GetTrues());
    }

    // ── TestAnyTrue / TestAllTrue ─────────────────────────────────────────────

    [Fact]
    public void BVec16_TestAnyTrue_FalseWhenAllZero()
    {
        // GetTrues() uses the high bit of each byte; 0x00 has bit7=0 → false
        Assert.False(JPH.BVec16.SZero().TestAnyTrue());
    }

    [Fact]
    public void BVec16_TestAnyTrue_TrueWhenAnyHasHighBit()
    {
        // Only one byte with bit7 set (0x80 / 0xff)
        var v = new JPH.BVec16(0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00);
        Assert.True(v.TestAnyTrue());
    }

    [Fact]
    public void BVec16_TestAllTrue_OnlyWhenAllHaveHighBit()
    {
        // All 0xff → all high bits set → TestAllTrue true
        Assert.True(All(0xff).TestAllTrue());
        // Mostly 0xff but one 0x00
        var v = new JPH.BVec16(0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
                                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00);
        Assert.False(v.TestAllTrue());
    }

    // ── Bitwise operations ────────────────────────────────────────────────────

    [Fact]
    public void BVec16_SOr_PerformsBitwiseOr()
    {
        var v1 = All(0b00110011);
        var v2 = All(0b01010101);
        var r  = JPH.Const_BVec16.SOr(v1, v2);
        for (byte i = 0; i < 16; i++)
            Assert.Equal(0b01110111, r[i]);
    }

    [Fact]
    public void BVec16_SXor_PerformsBitwiseXor()
    {
        var v1 = All(0b00110011);
        var v2 = All(0b01010101);
        var r  = JPH.Const_BVec16.SXor(v1, v2);
        for (byte i = 0; i < 16; i++)
            Assert.Equal(0b01100110, r[i]);
    }

    [Fact]
    public void BVec16_SAnd_PerformsBitwiseAnd()
    {
        var v1 = All(0b00110011);
        var v2 = All(0b01010101);
        var r  = JPH.Const_BVec16.SAnd(v1, v2);
        for (byte i = 0; i < 16; i++)
            Assert.Equal(0b00010001, r[i]);
    }

    [Fact]
    public void BVec16_SNot_InvertsAllBits()
    {
        var v = All(0b00110011);
        var r = JPH.Const_BVec16.SNot(v);
        for (byte i = 0; i < 16; i++)
            Assert.Equal(unchecked((byte)~0b00110011), r[i]);
    }
}
