// Tests for JPH::PhysicsSettings default values and mutable field round-trips.
// Default values come from PhysicsSettings.h.

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_PhysicsSettings
{
    // ─────────────────────────────────────────────────────────────────────────
    // Construction
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void PhysicsSettings_DefaultConstruct_DoesNotThrow()
    {
        var ps = new JPH.PhysicsSettings();
        Assert.NotNull(ps);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Default values
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void PhysicsSettings_mMaxInFlightBodyPairs_DefaultIs16384()
    {
        var ps = new JPH.PhysicsSettings();
        Assert.Equal(16384, ps.mMaxInFlightBodyPairs);
    }

    [Fact]
    public void PhysicsSettings_mStepListenersBatchSize_DefaultIs8()
    {
        var ps = new JPH.PhysicsSettings();
        Assert.Equal(8, ps.mStepListenersBatchSize);
    }

    [Fact]
    public void PhysicsSettings_mBaumgarte_DefaultIs0Point2()
    {
        var ps = new JPH.PhysicsSettings();
        Assert.Equal(0.2f, ps.mBaumgarte, precision: 5);
    }

    [Fact]
    public void PhysicsSettings_mSpeculativeContactDistance_DefaultIs0Point02()
    {
        var ps = new JPH.PhysicsSettings();
        Assert.Equal(0.02f, ps.mSpeculativeContactDistance, precision: 5);
    }

    [Fact]
    public void PhysicsSettings_mPenetrationSlop_DefaultIs0Point02()
    {
        var ps = new JPH.PhysicsSettings();
        Assert.Equal(0.02f, ps.mPenetrationSlop, precision: 5);
    }

    [Fact]
    public void PhysicsSettings_mNumVelocitySteps_DefaultIs10()
    {
        var ps = new JPH.PhysicsSettings();
        Assert.Equal(10u, ps.mNumVelocitySteps);
    }

    [Fact]
    public void PhysicsSettings_mNumPositionSteps_DefaultIs2()
    {
        var ps = new JPH.PhysicsSettings();
        Assert.Equal(2u, ps.mNumPositionSteps);
    }

    [Fact]
    public void PhysicsSettings_mMinVelocityForRestitution_DefaultIs1()
    {
        var ps = new JPH.PhysicsSettings();
        Assert.Equal(1.0f, ps.mMinVelocityForRestitution, precision: 5);
    }

    [Fact]
    public void PhysicsSettings_mTimeBeforeSleep_DefaultIs0Point5()
    {
        var ps = new JPH.PhysicsSettings();
        Assert.Equal(0.5f, ps.mTimeBeforeSleep, precision: 5);
    }

    [Fact]
    public void PhysicsSettings_mPointVelocitySleepThreshold_DefaultIs0Point03()
    {
        var ps = new JPH.PhysicsSettings();
        Assert.Equal(0.03f, ps.mPointVelocitySleepThreshold, precision: 5);
    }

    [Fact]
    public void PhysicsSettings_mDeterministicSimulation_DefaultIsTrue()
    {
        var ps = new JPH.PhysicsSettings();
        Assert.True(ps.mDeterministicSimulation);
    }

    [Fact]
    public void PhysicsSettings_mConstraintWarmStart_DefaultIsTrue()
    {
        var ps = new JPH.PhysicsSettings();
        Assert.True(ps.mConstraintWarmStart);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Mutable field round-trips
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void PhysicsSettings_mBaumgarte_RoundTrip()
    {
        var ps = new JPH.PhysicsSettings();
        ps.mBaumgarte = 0.5f;
        Assert.Equal(0.5f, ps.mBaumgarte, precision: 5);
    }

    [Fact]
    public void PhysicsSettings_mNumVelocitySteps_RoundTrip()
    {
        var ps = new JPH.PhysicsSettings();
        ps.mNumVelocitySteps = 20u;
        Assert.Equal(20u, ps.mNumVelocitySteps);
    }

    [Fact]
    public void PhysicsSettings_mDeterministicSimulation_RoundTrip()
    {
        var ps = new JPH.PhysicsSettings();
        ps.mDeterministicSimulation = false;
        Assert.False(ps.mDeterministicSimulation);
    }
}
