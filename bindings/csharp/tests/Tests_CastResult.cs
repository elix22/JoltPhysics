using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_CastResult(JoltFixture fx)
{
    // ── BroadPhaseCastResult — default construction ───────────────────────────

    [Fact]
    public void BroadPhaseCastResult_DefaultConstruct_NoCrash()
    {
        using var r = new JPH.BroadPhaseCastResult();
        Assert.NotNull(r);
    }

    [Fact]
    public void BroadPhaseCastResult_DefaultConstruct_mBodyID_IsInvalid()
    {
        using var r = new JPH.BroadPhaseCastResult();
        Assert.True(r.mBodyID.IsInvalid());
    }

    [Fact]
    public void BroadPhaseCastResult_DefaultConstruct_mFraction_IsGreaterThanOne()
    {
        // Default mFraction = 1.0f + FLT_EPSILON (slightly > 1)
        using var r = new JPH.BroadPhaseCastResult();
        Assert.True(r.mFraction > 1.0f);
    }

    [Fact]
    public void BroadPhaseCastResult_DefaultConstruct_GetEarlyOutFraction_EqualsDefaultFraction()
    {
        using var r = new JPH.BroadPhaseCastResult();
        Assert.Equal(r.mFraction, r.GetEarlyOutFraction());
    }

    // ── BroadPhaseCastResult — construction with values ───────────────────────

    [Fact]
    public void BroadPhaseCastResult_ConstructWithValues_mBodyID_Matches()
    {
        var id = new JPH.BodyID(7u);
        using var r = new JPH.BroadPhaseCastResult(id, 0.5f);
        Assert.Equal(id.GetIndexAndSequenceNumber(), r.mBodyID.GetIndexAndSequenceNumber());
    }

    [Fact]
    public void BroadPhaseCastResult_ConstructWithValues_mFraction_Matches()
    {
        var id = new JPH.BodyID(7u);
        using var r = new JPH.BroadPhaseCastResult(id, 0.5f);
        Assert.Equal(0.5f, r.mFraction);
    }

    [Fact]
    public void BroadPhaseCastResult_ConstructWithValues_GetEarlyOutFraction_Equalsfraction()
    {
        var id = new JPH.BodyID(2u);
        using var r = new JPH.BroadPhaseCastResult(id, 0.25f);
        Assert.Equal(0.25f, r.GetEarlyOutFraction());
    }

    // ── BroadPhaseCastResult — Reset ──────────────────────────────────────────

    [Fact]
    public void BroadPhaseCastResult_Reset_mBodyID_BecomesInvalid()
    {
        var id = new JPH.BodyID(9u);
        using var r = new JPH.BroadPhaseCastResult(id, 0.3f);
        r.Reset();
        Assert.True(r.mBodyID.IsInvalid());
    }

    [Fact]
    public void BroadPhaseCastResult_Reset_mFraction_IsGreaterThanOne()
    {
        var id = new JPH.BodyID(9u);
        using var r = new JPH.BroadPhaseCastResult(id, 0.3f);
        r.Reset();
        Assert.True(r.mFraction > 1.0f);
    }

    // ── BroadPhaseCastResult — copy construction ──────────────────────────────

    [Fact]
    public void BroadPhaseCastResult_CopyConstruct_PreservesBodyID()
    {
        var id = new JPH.BodyID(11u);
        using var original = new JPH.BroadPhaseCastResult(id, 0.75f);
        using var copy = new JPH.BroadPhaseCastResult(original);
        Assert.Equal(original.mBodyID.GetIndexAndSequenceNumber(), copy.mBodyID.GetIndexAndSequenceNumber());
    }

    [Fact]
    public void BroadPhaseCastResult_CopyConstruct_PreservesFraction()
    {
        var id = new JPH.BodyID(11u);
        using var original = new JPH.BroadPhaseCastResult(id, 0.75f);
        using var copy = new JPH.BroadPhaseCastResult(original);
        Assert.Equal(original.mFraction, copy.mFraction);
    }

    // ── RayCastResult — default construction ─────────────────────────────────

    [Fact]
    public void RayCastResult_DefaultConstruct_NoCrash()
    {
        using var r = new JPH.RayCastResult();
        Assert.NotNull(r);
    }

    [Fact]
    public void RayCastResult_DefaultConstruct_mBodyID_IsInvalid()
    {
        using var r = new JPH.RayCastResult();
        Assert.True(r.mBodyID.IsInvalid());
    }

    [Fact]
    public void RayCastResult_DefaultConstruct_mFraction_IsGreaterThanOne()
    {
        using var r = new JPH.RayCastResult();
        Assert.True(r.mFraction > 1.0f);
    }

    [Fact]
    public void RayCastResult_DefaultConstruct_mSubShapeID2_IsEmpty()
    {
        using var r = new JPH.RayCastResult();
        Assert.True(r.mSubShapeID2.IsEmpty());
    }
}
