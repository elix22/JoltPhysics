using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_BodyID(JoltFixture fx)
{
    // ── Constants ─────────────────────────────────────────────────────────────

    [Fact]
    public void BodyID_CInvalidBodyID_IsUIntMax()
    {
        Assert.Equal(0xFFFFFFFFu, JPH.ConstBox_BodyID.CInvalidBodyID);
    }

    [Fact]
    public void BodyID_CBroadPhaseBit_IsCorrect()
    {
        Assert.Equal(0x80000000u, JPH.ConstBox_BodyID.CBroadPhaseBit);
    }

    [Fact]
    public void BodyID_CMaxBodyIndex_IsCorrect()
    {
        Assert.Equal(0x7FFFFFu, JPH.ConstBox_BodyID.CMaxBodyIndex);
    }

    [Fact]
    public void BodyID_CMaxSequenceNumber_IsCorrect()
    {
        Assert.Equal((byte)0xFF, JPH.ConstBox_BodyID.CMaxSequenceNumber);
    }

    [Fact]
    public void BodyID_CSequenceNumberShift_Is23()
    {
        Assert.Equal(23u, JPH.ConstBox_BodyID.CSequenceNumberShift);
    }

    // ── Default construction ──────────────────────────────────────────────────

    [Fact]
    public void BodyID_DefaultConstruct_IsInvalid()
    {
        var id = new JPH.BodyID();
        Assert.True(id.IsInvalid());
    }

    [Fact]
    public void BodyID_DefaultConstruct_GetIndexAndSequenceNumber_IsMax()
    {
        var id = new JPH.BodyID();
        Assert.Equal(0xFFFFFFFFu, id.GetIndexAndSequenceNumber());
    }

    // ── Construction from uint index ──────────────────────────────────────────

    [Fact]
    public void BodyID_ConstructFromUInt_IsNotInvalid()
    {
        var id = new JPH.BodyID(42u);
        Assert.False(id.IsInvalid());
    }

    [Fact]
    public void BodyID_ConstructFromUInt_GetIndexAndSequenceNumber()
    {
        var id = new JPH.BodyID(42u);
        Assert.Equal(42u, id.GetIndexAndSequenceNumber());
    }

    [Fact]
    public void BodyID_ConstructFromUInt_GetIndex()
    {
        var id = new JPH.BodyID(42u);
        Assert.Equal(42u, id.GetIndex());
    }

    [Fact]
    public void BodyID_ConstructFromUInt_GetSequenceNumber_IsZero()
    {
        var id = new JPH.BodyID(42u);
        Assert.Equal((byte)0, id.GetSequenceNumber());
    }

    // ── Construction from index + sequence number ─────────────────────────────

    [Fact]
    public void BodyID_ConstructFromIndexAndSeqNum_GetIndex()
    {
        var id = new JPH.BodyID(10u, 2);
        Assert.Equal(10u, id.GetIndex());
    }

    [Fact]
    public void BodyID_ConstructFromIndexAndSeqNum_GetSequenceNumber()
    {
        var id = new JPH.BodyID(10u, 2);
        Assert.Equal((byte)2, id.GetSequenceNumber());
    }

    [Fact]
    public void BodyID_ConstructFromIndexAndSeqNum_GetIndexAndSequenceNumber()
    {
        var id = new JPH.BodyID(10u, 2);
        uint expected = (2u << 23) | 10u;
        Assert.Equal(expected, id.GetIndexAndSequenceNumber());
    }

    [Fact]
    public void BodyID_ConstructFromIndexAndSeqNum_IsNotInvalid()
    {
        var id = new JPH.BodyID(10u, 2);
        Assert.False(id.IsInvalid());
    }

    // ── Equality and comparison operators ─────────────────────────────────────

    [Fact]
    public void BodyID_Equality_SameValues_IsEqual()
    {
        var a = new JPH.BodyID(5u);
        var b = new JPH.BodyID(5u);
        Assert.True(a == b);
    }

    [Fact]
    public void BodyID_Inequality_DifferentValues_IsNotEqual()
    {
        var a = new JPH.BodyID(5u);
        var b = new JPH.BodyID(7u);
        Assert.True(a != b);
    }

    [Fact]
    public void BodyID_LessThan_Ordering()
    {
        var lo = new JPH.BodyID(1u);
        var hi = new JPH.BodyID(2u);
        Assert.True(lo < hi);
        Assert.False(hi < lo);
    }

    [Fact]
    public void BodyID_GreaterThan_Ordering()
    {
        var lo = new JPH.BodyID(1u);
        var hi = new JPH.BodyID(2u);
        Assert.True(hi > lo);
        Assert.False(lo > hi);
    }

    [Fact]
    public void BodyID_Copy_PreservesValue()
    {
        var original = new JPH.BodyID(99u, 7);
        var copy = original;
        Assert.Equal(original.GetIndexAndSequenceNumber(), copy.GetIndexAndSequenceNumber());
        Assert.True(original == copy);
    }
}
