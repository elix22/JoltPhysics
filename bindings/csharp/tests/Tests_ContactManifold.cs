// Tests for JPH::ContactManifold: construction, field defaults, mutation,
// copy construction, and SwapShapes.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_ContactManifold(JoltFixture fx)
{
    // ── Construction ──────────────────────────────────────────────────────────

    [Fact]
    public void ContactManifold_DefaultConstruct_NoCrash()
    {
        using var m = new JPH.ContactManifold();
        Assert.NotNull(m);
    }

    [Fact]
    public void Const_ContactManifold_DefaultConstruct_NoCrash()
    {
        using var m = new JPH.Const_ContactManifold();
        Assert.NotNull(m);
    }

    // ── Default field values ──────────────────────────────────────────────────

    [Fact]
    public void ContactManifold_DefaultConstruct_mPenetrationDepth_IsZero()
    {
        using var m = new JPH.ContactManifold();
        Assert.Equal(0.0f, m.mPenetrationDepth);
    }

    [Fact]
    public void ContactManifold_DefaultConstruct_mSubShapeID1_IsEmpty()
    {
        using var m = new JPH.ContactManifold();
        Assert.True(m.mSubShapeID1.IsEmpty());
    }

    [Fact]
    public void ContactManifold_DefaultConstruct_mSubShapeID2_IsEmpty()
    {
        using var m = new JPH.ContactManifold();
        Assert.True(m.mSubShapeID2.IsEmpty());
    }

    // ── Mutable field round-trips ─────────────────────────────────────────────

    [Fact]
    public void ContactManifold_mPenetrationDepth_Mutable_RoundTrip()
    {
        using var m = new JPH.ContactManifold();
        m.mPenetrationDepth = 1.5f;
        Assert.Equal(1.5f, m.mPenetrationDepth);
    }

    [Fact]
    public void ContactManifold_mSubShapeID1_Mutable_SetValue_RoundTrip()
    {
        using var m = new JPH.ContactManifold();
        m.mSubShapeID1.SetValue(42u);
        Assert.Equal(42u, m.mSubShapeID1.GetValue());
    }

    [Fact]
    public void ContactManifold_mSubShapeID2_Mutable_SetValue_RoundTrip()
    {
        using var m = new JPH.ContactManifold();
        m.mSubShapeID2.SetValue(99u);
        Assert.Equal(99u, m.mSubShapeID2.GetValue());
    }

    // ── Copy construction ─────────────────────────────────────────────────────

    [Fact]
    public void ContactManifold_CopyConstruct_PreservesPenetrationDepth()
    {
        using var original = new JPH.ContactManifold();
        original.mPenetrationDepth = 2.5f;
        using var copy = new JPH.ContactManifold(original);
        Assert.Equal(2.5f, copy.mPenetrationDepth);
    }

    [Fact]
    public void ContactManifold_CopyConstruct_PreservesSubShapeIDs()
    {
        using var original = new JPH.ContactManifold();
        original.mSubShapeID1.SetValue(10u);
        original.mSubShapeID2.SetValue(20u);
        using var copy = new JPH.ContactManifold(original);
        Assert.Equal(10u, copy.mSubShapeID1.GetValue());
        Assert.Equal(20u, copy.mSubShapeID2.GetValue());
    }

    // ── SwapShapes ────────────────────────────────────────────────────────────

    [Fact]
    public void ContactManifold_SwapShapes_NoCrash()
    {
        using var m = new JPH.ContactManifold();
        using var swapped = m.SwapShapes();
        Assert.NotNull(swapped);
    }

    [Fact]
    public void ContactManifold_SwapShapes_ExchangesSubShapeIDs()
    {
        using var m = new JPH.ContactManifold();
        m.mSubShapeID1.SetValue(7u);
        m.mSubShapeID2.SetValue(13u);
        using var swapped = m.SwapShapes();
        Assert.Equal(13u, swapped.mSubShapeID1.GetValue());
        Assert.Equal(7u,  swapped.mSubShapeID2.GetValue());
    }

    [Fact]
    public void ContactManifold_SwapShapes_PreservesPenetrationDepth()
    {
        using var m = new JPH.ContactManifold();
        m.mPenetrationDepth = 0.75f;
        using var swapped = m.SwapShapes();
        Assert.Equal(0.75f, swapped.mPenetrationDepth);
    }
}
