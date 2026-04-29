// Tests for JPH::CollisionGroup API: static constants, getters/setters,
// and the no-filter CanCollide behaviour.
// Mirrors JoltPhysics/UnitTests/Physics/CollisionGroupTests.cpp coverage
// that does not require GroupFilterTable.

using Xunit;

namespace JoltTests;

// No physics system needed — pure data tests.
public sealed class Tests_CollisionGroups
{
    // ─────────────────────────────────────────────────────────────────────────
    // Static constants
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CollisionGroup_CInvalidGroup_IsMaxUInt()
    {
        // Jolt defines CInvalidGroup = 0xffffffff
        Assert.Equal(uint.MaxValue, JPH.Const_CollisionGroup.CInvalidGroup);
    }

    [Fact]
    public void CollisionGroup_CInvalidSubGroup_IsMaxUInt()
    {
        Assert.Equal(uint.MaxValue, JPH.Const_CollisionGroup.CInvalidSubGroup);
    }

    [Fact]
    public void CollisionGroup_SInvalid_HasInvalidGroupID()
    {
        using var inv = JPH.Const_CollisionGroup.SInvalid;
        Assert.Equal(JPH.Const_CollisionGroup.CInvalidGroup, inv.GetGroupID());
    }

    [Fact]
    public void CollisionGroup_SInvalid_HasInvalidSubGroupID()
    {
        using var inv = JPH.Const_CollisionGroup.SInvalid;
        Assert.Equal(JPH.Const_CollisionGroup.CInvalidSubGroup, inv.GetSubGroupID());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Default construction
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CollisionGroup_DefaultConstruct_DoesNotThrow()
    {
        using var g = new JPH.CollisionGroup();
        Assert.NotNull(g);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // SetGroupID / GetGroupID round-trip
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CollisionGroup_SetGetGroupID_RoundTrips()
    {
        using var g = new JPH.CollisionGroup();
        g.SetGroupID(42u);
        Assert.Equal(42u, g.GetGroupID());
    }

    [Theory]
    [InlineData(0u)]
    [InlineData(1u)]
    [InlineData(255u)]
    [InlineData(uint.MaxValue - 1)]
    public void CollisionGroup_SetGetGroupID_MultipleValues(uint id)
    {
        using var g = new JPH.CollisionGroup();
        g.SetGroupID(id);
        Assert.Equal(id, g.GetGroupID());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // SetSubGroupID / GetSubGroupID round-trip
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CollisionGroup_SetGetSubGroupID_RoundTrips()
    {
        using var g = new JPH.CollisionGroup();
        g.SetSubGroupID(7u);
        Assert.Equal(7u, g.GetSubGroupID());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // CanCollide — no group filter
    //
    // When both groups have null GroupFilter, Jolt always returns true.
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CollisionGroup_NoFilter_CanCollide_ReturnsTrue()
    {
        using var g1 = new JPH.CollisionGroup();
        using var g2 = new JPH.CollisionGroup();
        Assert.True(g1.CanCollide(g2));
    }

    [Fact]
    public void CollisionGroup_NoFilter_SameGroup_CanCollide_ReturnsTrue()
    {
        using var g1 = new JPH.CollisionGroup();
        using var g2 = new JPH.CollisionGroup();
        g1.SetGroupID(5u);
        g2.SetGroupID(5u);
        g1.SetSubGroupID(0u);
        g2.SetSubGroupID(1u);
        Assert.True(g1.CanCollide(g2));
    }

    [Fact]
    public void CollisionGroup_NoFilter_DifferentGroups_CanCollide_ReturnsTrue()
    {
        using var g1 = new JPH.CollisionGroup();
        using var g2 = new JPH.CollisionGroup();
        g1.SetGroupID(1u);
        g2.SetGroupID(2u);
        Assert.True(g1.CanCollide(g2));
    }

    // ─────────────────────────────────────────────────────────────────────────
    // CollisionGroup attached to a body affects physics system layer filter
    // (These tests verify the body creation settings carry the group correctly.)
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CollisionGroup_CopyConstruct_PreservesGroupID()
    {
        using var orig = new JPH.CollisionGroup();
        orig.SetGroupID(99u);
        using var copy = new JPH.CollisionGroup(orig);
        Assert.Equal(99u, copy.GetGroupID());
    }

    [Fact]
    public void CollisionGroup_CopyConstruct_PreservesSubGroupID()
    {
        using var orig = new JPH.CollisionGroup();
        orig.SetSubGroupID(33u);
        using var copy = new JPH.CollisionGroup(orig);
        Assert.Equal(33u, copy.GetSubGroupID());
    }
}
