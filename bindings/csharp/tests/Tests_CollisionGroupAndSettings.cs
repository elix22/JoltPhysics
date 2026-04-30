// Tests for JPH::CollisionGroup and JPH::PhysicsSettings.
// CollisionGroup carries group/sub-group IDs used by GroupFilterTable.
// PhysicsSettings holds simulation tuning knobs exposed via
// PhysicsSystem::GetPhysicsSettings / SetPhysicsSettings.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_CollisionGroupAndSettings(JoltFixture fx)
{
    // ─────────────────────────────────────────────────────────────────────────
    // CollisionGroup — static constants
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CollisionGroup_CInvalidGroup_IsUIntMax()
    {
        Assert.Equal(uint.MaxValue, JPH.Const_CollisionGroup.CInvalidGroup);
    }

    [Fact]
    public void CollisionGroup_CInvalidSubGroup_IsUIntMax()
    {
        Assert.Equal(uint.MaxValue, JPH.Const_CollisionGroup.CInvalidSubGroup);
    }

    [Fact]
    public void CollisionGroup_SInvalid_IsNotNull()
    {
        using var inv = JPH.Const_CollisionGroup.SInvalid;
        Assert.NotNull(inv);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // CollisionGroup — default construction
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CollisionGroup_DefaultConstruct_DoesNotThrow()
    {
        using var g = new JPH.CollisionGroup();
        Assert.NotNull(g);
    }

    [Fact]
    public void CollisionGroup_DefaultGroupID_IsCInvalidGroup()
    {
        using var g = new JPH.CollisionGroup();
        Assert.Equal(JPH.Const_CollisionGroup.CInvalidGroup, g.GetGroupID());
    }

    [Fact]
    public void CollisionGroup_DefaultSubGroupID_IsCInvalidSubGroup()
    {
        using var g = new JPH.CollisionGroup();
        Assert.Equal(JPH.Const_CollisionGroup.CInvalidSubGroup, g.GetSubGroupID());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // CollisionGroup — SetGroupID / SetSubGroupID round-trips
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CollisionGroup_SetGroupID_RoundTrips()
    {
        using var g = new JPH.CollisionGroup();
        g.SetGroupID(42u);
        Assert.Equal(42u, g.GetGroupID());
    }

    [Fact]
    public void CollisionGroup_SetSubGroupID_RoundTrips()
    {
        using var g = new JPH.CollisionGroup();
        g.SetSubGroupID(7u);
        Assert.Equal(7u, g.GetSubGroupID());
    }

    [Fact]
    public void CollisionGroup_SetBothIDs_IndependentRoundTrips()
    {
        using var g = new JPH.CollisionGroup();
        g.SetGroupID(100u);
        g.SetSubGroupID(200u);
        Assert.Equal(100u, g.GetGroupID());
        Assert.Equal(200u, g.GetSubGroupID());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // CollisionGroup — CanCollide (no group filter → always true)
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CollisionGroup_CanCollide_NoFilter_ReturnsTrue()
    {
        using var g1 = new JPH.CollisionGroup();
        using var g2 = new JPH.CollisionGroup();
        Assert.True(g1.CanCollide(g2));
    }

    [Fact]
    public void CollisionGroup_CanCollide_DifferentGroups_NoFilter_ReturnsTrue()
    {
        using var g1 = new JPH.CollisionGroup();
        using var g2 = new JPH.CollisionGroup();
        g1.SetGroupID(1u);
        g2.SetGroupID(2u);
        // Without a group filter, groups always collide.
        Assert.True(g1.CanCollide(g2));
    }

    // ─────────────────────────────────────────────────────────────────────────
    // PhysicsSettings — default values
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void PhysicsSettings_DefaultConstruct_DoesNotThrow()
    {
        using var ps = new JPH.PhysicsSettings();
        Assert.NotNull(ps);
    }

    [Fact]
    public void PhysicsSettings_mNumVelocitySteps_DefaultIs10()
    {
        using var ps = new JPH.PhysicsSettings();
        Assert.Equal(10u, ps.mNumVelocitySteps);
    }

    [Fact]
    public void PhysicsSettings_mNumPositionSteps_DefaultIs2()
    {
        using var ps = new JPH.PhysicsSettings();
        Assert.Equal(2u, ps.mNumPositionSteps);
    }

    [Fact]
    public void PhysicsSettings_mAllowSleeping_DefaultIsTrue()
    {
        using var ps = new JPH.PhysicsSettings();
        Assert.True(ps.mAllowSleeping);
    }

    [Fact]
    public void PhysicsSettings_mDeterministicSimulation_DefaultIsTrue()
    {
        using var ps = new JPH.PhysicsSettings();
        Assert.True(ps.mDeterministicSimulation);
    }

    [Fact]
    public void PhysicsSettings_mBaumgarte_Default_IsApprox0p2()
    {
        using var ps = new JPH.PhysicsSettings();
        Assert.Equal(0.2f, ps.mBaumgarte, precision: 4);
    }

    [Fact]
    public void PhysicsSettings_mConstraintWarmStart_DefaultIsTrue()
    {
        using var ps = new JPH.PhysicsSettings();
        Assert.True(ps.mConstraintWarmStart);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // PhysicsSettings — round-trip via PhysicsSystem
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void PhysicsSystem_GetPhysicsSettings_ReturnsNonNull()
    {
        using var sys = fx.MakePhysicsSystem();
        using var ps  = sys.GetPhysicsSettings();
        Assert.NotNull(ps);
    }

    [Fact]
    public void PhysicsSystem_SetPhysicsSettings_NumVelocitySteps_RoundTrips()
    {
        using var sys = fx.MakePhysicsSystem();
        using var ps  = new JPH.PhysicsSettings();
        ps.mNumVelocitySteps = 5u;
        sys.SetPhysicsSettings(ps);

        using var ps2 = sys.GetPhysicsSettings();
        Assert.Equal(5u, ps2.mNumVelocitySteps);
    }

    [Fact]
    public void PhysicsSystem_SetPhysicsSettings_AllowSleeping_RoundTrips()
    {
        using var sys = fx.MakePhysicsSystem();
        using var ps  = new JPH.PhysicsSettings();
        ps.mAllowSleeping = false;
        sys.SetPhysicsSettings(ps);

        using var ps2 = sys.GetPhysicsSettings();
        Assert.False(ps2.mAllowSleeping);
    }
}
