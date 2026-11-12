using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_SubShapeIDPair(JoltFixture fx)
{
    // ── Default construction ──────────────────────────────────────────────────

    [Fact]
    public void SubShapeIDPair_DefaultConstruct_NoCrash()
    {
        using var pair = new JPH.SubShapeIDPair();
        Assert.NotNull(pair);
    }

    // ── Parameterized construction ────────────────────────────────────────────

    [Fact]
    public void SubShapeIDPair_Construct_GetBody1ID_MatchesInput()
    {
        var body1 = new JPH.BodyID(42u);
        var body2 = new JPH.BodyID(99u);
        using var sub1 = new JPH.SubShapeID();
        using var sub2 = new JPH.SubShapeID();
        using var pair = new JPH.SubShapeIDPair(body1, sub1, body2, sub2);
        Assert.Equal(42u, pair.GetBody1ID().GetIndexAndSequenceNumber());
    }

    [Fact]
    public void SubShapeIDPair_Construct_GetBody2ID_MatchesInput()
    {
        var body1 = new JPH.BodyID(42u);
        var body2 = new JPH.BodyID(99u);
        using var sub1 = new JPH.SubShapeID();
        using var sub2 = new JPH.SubShapeID();
        using var pair = new JPH.SubShapeIDPair(body1, sub1, body2, sub2);
        Assert.Equal(99u, pair.GetBody2ID().GetIndexAndSequenceNumber());
    }

    [Fact]
    public void SubShapeIDPair_Construct_GetSubShapeID1_MatchesInput()
    {
        var body1 = new JPH.BodyID(1u);
        var body2 = new JPH.BodyID(2u);
        using var sub1 = new JPH.SubShapeID();
        using var sub2 = new JPH.SubShapeID();
        sub1.SetValue(7u);
        sub2.SetValue(13u);
        using var pair = new JPH.SubShapeIDPair(body1, sub1, body2, sub2);
        using var readSub1 = pair.GetSubShapeID1();
        Assert.Equal(7u, readSub1.GetValue());
    }

    [Fact]
    public void SubShapeIDPair_Construct_GetSubShapeID2_MatchesInput()
    {
        var body1 = new JPH.BodyID(1u);
        var body2 = new JPH.BodyID(2u);
        using var sub1 = new JPH.SubShapeID();
        using var sub2 = new JPH.SubShapeID();
        sub1.SetValue(7u);
        sub2.SetValue(13u);
        using var pair = new JPH.SubShapeIDPair(body1, sub1, body2, sub2);
        using var readSub2 = pair.GetSubShapeID2();
        Assert.Equal(13u, readSub2.GetValue());
    }

    // ── Equality operators ────────────────────────────────────────────────────

    [Fact]
    public void SubShapeIDPair_Equality_SamePair_ReturnsTrue()
    {
        var body1 = new JPH.BodyID(10u);
        var body2 = new JPH.BodyID(20u);
        using var sub1 = new JPH.SubShapeID();
        using var sub2 = new JPH.SubShapeID();
        sub1.SetValue(3u);
        sub2.SetValue(5u);
        using var pairA = new JPH.SubShapeIDPair(body1, sub1, body2, sub2);
        using var pairB = new JPH.SubShapeIDPair(body1, sub1, body2, sub2);
        Assert.True(pairA == pairB);
    }

    [Fact]
    public void SubShapeIDPair_Inequality_DifferentBodies_ReturnsTrue()
    {
        var body1 = new JPH.BodyID(10u);
        var body2 = new JPH.BodyID(20u);
        var body3 = new JPH.BodyID(30u);
        using var sub1 = new JPH.SubShapeID();
        using var sub2 = new JPH.SubShapeID();
        using var pairA = new JPH.SubShapeIDPair(body1, sub1, body2, sub2);
        using var pairB = new JPH.SubShapeIDPair(body1, sub1, body3, sub2);
        Assert.True(pairA != pairB);
    }

    // ── Copy construction ─────────────────────────────────────────────────────

    [Fact]
    public void SubShapeIDPair_CopyConstruct_PreservesBody1ID()
    {
        var body1 = new JPH.BodyID(77u);
        var body2 = new JPH.BodyID(88u);
        using var sub1 = new JPH.SubShapeID();
        using var sub2 = new JPH.SubShapeID();
        using var original = new JPH.SubShapeIDPair(body1, sub1, body2, sub2);
        using var copy = new JPH.SubShapeIDPair(original);
        Assert.Equal(77u, copy.GetBody1ID().GetIndexAndSequenceNumber());
    }

    // ── Hashing ───────────────────────────────────────────────────────────────

    [Fact]
    public void SubShapeIDPair_GetHash_SamePairsSameHash()
    {
        var body1 = new JPH.BodyID(1u);
        var body2 = new JPH.BodyID(2u);
        using var sub1 = new JPH.SubShapeID();
        using var sub2 = new JPH.SubShapeID();
        sub1.SetValue(4u);
        sub2.SetValue(8u);
        using var pairA = new JPH.SubShapeIDPair(body1, sub1, body2, sub2);
        using var pairB = new JPH.SubShapeIDPair(body1, sub1, body2, sub2);
        Assert.Equal(pairA.GetHash(), pairB.GetHash());
    }

    [Fact]
    public void SubShapeIDPair_Equals_SamePair_ReturnsTrue()
    {
        var body1 = new JPH.BodyID(5u);
        var body2 = new JPH.BodyID(6u);
        using var sub1 = new JPH.SubShapeID();
        using var sub2 = new JPH.SubShapeID();
        using var pairA = new JPH.SubShapeIDPair(body1, sub1, body2, sub2);
        using var pairB = new JPH.SubShapeIDPair(body1, sub1, body2, sub2);
        Assert.True(pairA.Equals(pairB));
    }
}
