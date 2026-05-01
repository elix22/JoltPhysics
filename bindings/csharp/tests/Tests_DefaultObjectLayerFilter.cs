// Tests for JPH::DefaultObjectLayerFilter: construction from a pair filter
// and ShouldCollide logic.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_DefaultObjectLayerFilter(JoltFixture fx)
{
    // ── Helper: build a 2-layer ObjectLayerPairFilterTable ────────────────────
    // Layer 0 = non-moving, Layer 1 = moving.
    // Collision enabled between layer 0 and layer 1.

    private static JPH.ObjectLayerPairFilterTable MakePairFilter()
    {
        var table = new JPH.ObjectLayerPairFilterTable(2u);
        table.EnableCollision(JoltFixture.LayerNonMoving, JoltFixture.LayerMoving);
        return table;
    }

    // Cast ObjectLayerPairFilterTable to Const_ObjectLayerPairFilterTable first to
    // resolve the implicit-conversion ambiguity (CS0457) when passing to
    // DefaultObjectLayerFilter's constructor which expects Const_ObjectLayerPairFilter.
    private static JPH.Const_ObjectLayerPairFilterTable AsConst(JPH.ObjectLayerPairFilterTable pf)
        => pf;

    // ── Construction ──────────────────────────────────────────────────────────

    [Fact]
    public void DefaultObjectLayerFilter_Construct_NoCrash()
    {
        using var pf = MakePairFilter();
        using var f = new JPH.DefaultObjectLayerFilter(AsConst(pf), JoltFixture.LayerNonMoving);
        Assert.NotNull(f);
    }

    // ── ShouldCollide ─────────────────────────────────────────────────────────

    [Fact]
    public void DefaultObjectLayerFilter_ShouldCollide_MovingLayer_ReturnsTrue()
    {
        // Filter is configured for layer 0 (non-moving).
        // Layer 0 <-> Layer 1 is enabled, so ShouldCollide(1) should be true.
        using var pf = MakePairFilter();
        using var f = new JPH.DefaultObjectLayerFilter(AsConst(pf), JoltFixture.LayerNonMoving);
        Assert.True(f.ShouldCollide(JoltFixture.LayerMoving));
    }

    [Fact]
    public void DefaultObjectLayerFilter_ShouldCollide_SameLayer_ReturnsFalse()
    {
        // Layer 0 <-> Layer 0 is NOT enabled in MakePairFilter(), so false.
        using var pf = MakePairFilter();
        using var f = new JPH.DefaultObjectLayerFilter(AsConst(pf), JoltFixture.LayerNonMoving);
        Assert.False(f.ShouldCollide(JoltFixture.LayerNonMoving));
    }

    [Fact]
    public void DefaultObjectLayerFilter_MovingLayer_ShouldCollide_NonMoving_ReturnsTrue()
    {
        // Symmetric: filter built for layer 1, ShouldCollide(0) should be true.
        using var pf = MakePairFilter();
        using var f = new JPH.DefaultObjectLayerFilter(AsConst(pf), JoltFixture.LayerMoving);
        Assert.True(f.ShouldCollide(JoltFixture.LayerNonMoving));
    }

    [Fact]
    public void DefaultObjectLayerFilter_MovingLayer_ShouldCollide_MovingLayer_ReturnsFalse()
    {
        // Layer 1 <-> Layer 1 is NOT enabled, so false.
        using var pf = MakePairFilter();
        using var f = new JPH.DefaultObjectLayerFilter(AsConst(pf), JoltFixture.LayerMoving);
        Assert.False(f.ShouldCollide(JoltFixture.LayerMoving));
    }

    [Fact]
    public void DefaultObjectLayerFilter_NoCollisionEnabled_ShouldCollide_ReturnsFalse()
    {
        // A pair filter with no enabled pairs — nothing should collide.
        using var pf = new JPH.ObjectLayerPairFilterTable(2u);
        using var f = new JPH.DefaultObjectLayerFilter(AsConst(pf), JoltFixture.LayerNonMoving);
        Assert.False(f.ShouldCollide(JoltFixture.LayerMoving));
        Assert.False(f.ShouldCollide(JoltFixture.LayerNonMoving));
    }
}
