// Tests for ObjectLayerPairFilterMask:
// construction, static helpers sGetObjectLayer/sGetGroup/sGetMask,
// and ShouldCollide logic.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_ObjectLayerPairFilterMask(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // Lifecycle
    // -------------------------------------------------------------------------

    [Fact]
    public void ObjectLayerPairFilterMask_DefaultConstruct_NoCrash()
    {
        var f = new JPH.ObjectLayerPairFilterMask();
        f.Dispose();
    }

    // -------------------------------------------------------------------------
    // Static constants
    // -------------------------------------------------------------------------

    [Fact]
    public void ObjectLayerPairFilterMask_CNumbBits_IsGreaterThanZero()
    {
        Assert.True(JPH.Const_ObjectLayerPairFilterMask.CNumBits > 0u);
    }

    [Fact]
    public void ObjectLayerPairFilterMask_CMask_IsAllLowBitsSet()
    {
        uint bits = JPH.Const_ObjectLayerPairFilterMask.CNumBits;
        uint expectedMask = (1u << (int)bits) - 1u;
        Assert.Equal(expectedMask, JPH.Const_ObjectLayerPairFilterMask.CMask);
    }

    // -------------------------------------------------------------------------
    // sGetObjectLayer / sGetGroup / sGetMask round-trips
    // -------------------------------------------------------------------------

    [Fact]
    public void ObjectLayerPairFilterMask_SGetGroup_ReturnsGroupBits()
    {
        // Build a layer from group=1 and default mask, then extract the group.
        ushort layer = JPH.ObjectLayerPairFilterMask.SGetObjectLayer(1u);
        uint group = JPH.ObjectLayerPairFilterMask.SGetGroup(layer);
        Assert.Equal(1u, group);
    }

    [Fact]
    public void ObjectLayerPairFilterMask_SGetMask_ReturnsDefaultMaskWhenNotSpecified()
    {
        // Default mask should be cMask (all bits set in lower half).
        ushort layer = JPH.ObjectLayerPairFilterMask.SGetObjectLayer(1u);
        uint mask = JPH.ObjectLayerPairFilterMask.SGetMask(layer);
        Assert.Equal(JPH.Const_ObjectLayerPairFilterMask.CMask, mask);
    }

    [Fact]
    public void ObjectLayerPairFilterMask_SGetObjectLayer_GroupAndMaskRoundTrip()
    {
        uint g = 2u;
        uint m = 3u;
        ushort layer = JPH.ObjectLayerPairFilterMask.SGetObjectLayer(g, m);
        Assert.Equal(g, JPH.ObjectLayerPairFilterMask.SGetGroup(layer));
        Assert.Equal(m, JPH.ObjectLayerPairFilterMask.SGetMask(layer));
    }

    // -------------------------------------------------------------------------
    // ShouldCollide logic
    // -------------------------------------------------------------------------

    [Fact]
    public void ObjectLayerPairFilterMask_ShouldCollide_MatchingGroupAndMask_IsTrue()
    {
        using var f = new JPH.ObjectLayerPairFilterMask();
        // Layer A: group=1, mask=1 (can collide with group=1)
        // Layer B: group=1, mask=1
        ushort layerA = JPH.ObjectLayerPairFilterMask.SGetObjectLayer(1u, 1u);
        ushort layerB = JPH.ObjectLayerPairFilterMask.SGetObjectLayer(1u, 1u);
        Assert.True(f.ShouldCollide(layerA, layerB));
    }

    [Fact]
    public void ObjectLayerPairFilterMask_ShouldCollide_NonMatchingGroups_IsFalse()
    {
        using var f = new JPH.ObjectLayerPairFilterMask();
        // Layer A: group=1, mask=2 (expects group 2)
        // Layer B: group=2, mask=4 (expects group 4, not 1)
        ushort layerA = JPH.ObjectLayerPairFilterMask.SGetObjectLayer(1u, 2u);
        ushort layerB = JPH.ObjectLayerPairFilterMask.SGetObjectLayer(2u, 4u);
        // A.group(1) & B.mask(4) = 0 → no collision
        Assert.False(f.ShouldCollide(layerA, layerB));
    }

    [Fact]
    public void ObjectLayerPairFilterMask_ShouldCollide_ZeroMask_IsFalse()
    {
        using var f = new JPH.ObjectLayerPairFilterMask();
        // Layer A: group=1, mask=0 (blocks all)
        ushort layerA = JPH.ObjectLayerPairFilterMask.SGetObjectLayer(1u, 0u);
        ushort layerB = JPH.ObjectLayerPairFilterMask.SGetObjectLayer(1u, 1u);
        Assert.False(f.ShouldCollide(layerA, layerB));
    }

    [Fact]
    public void ObjectLayerPairFilterMask_ShouldCollide_AsymmetricMask_IsCorrect()
    {
        using var f = new JPH.ObjectLayerPairFilterMask();
        // A: group=1, mask=2 — wants to collide with group 2
        // B: group=2, mask=1 — wants to collide with group 1
        // Both conditions satisfied → true
        ushort layerA = JPH.ObjectLayerPairFilterMask.SGetObjectLayer(1u, 2u);
        ushort layerB = JPH.ObjectLayerPairFilterMask.SGetObjectLayer(2u, 1u);
        Assert.True(f.ShouldCollide(layerA, layerB));
    }
}
