using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_CharacterVirtualSettings(JoltFixture fx)
{
    // ── CharacterVirtualSettings — default construction ───────────────────────

    [Fact]
    public void CharacterVirtualSettings_DefaultConstruct_NoCrash()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        Assert.NotNull(cs);
    }

    [Fact]
    public void CharacterVirtualSettings_mMass_DefaultIs70()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        Assert.Equal(70.0f, cs.mMass);
    }

    [Fact]
    public void CharacterVirtualSettings_mMaxStrength_DefaultIs100()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        Assert.Equal(100.0f, cs.mMaxStrength);
    }

    [Fact]
    public void CharacterVirtualSettings_mPredictiveContactDistance_DefaultIs0Point1()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        Assert.Equal(0.1f, cs.mPredictiveContactDistance, precision: 5);
    }

    [Fact]
    public void CharacterVirtualSettings_mMaxCollisionIterations_DefaultIs5()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        Assert.Equal(5u, cs.mMaxCollisionIterations);
    }

    [Fact]
    public void CharacterVirtualSettings_mMaxConstraintIterations_DefaultIs15()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        Assert.Equal(15u, cs.mMaxConstraintIterations);
    }

    [Fact]
    public void CharacterVirtualSettings_mCollisionTolerance_DefaultIs1e3()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        Assert.Equal(1e-3f, cs.mCollisionTolerance, precision: 5);
    }

    [Fact]
    public void CharacterVirtualSettings_mCharacterPadding_DefaultIs0Point02()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        Assert.Equal(0.02f, cs.mCharacterPadding, precision: 5);
    }

    [Fact]
    public void CharacterVirtualSettings_mMaxNumHits_DefaultIs256()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        Assert.Equal(256u, cs.mMaxNumHits);
    }

    [Fact]
    public void CharacterVirtualSettings_mHitReductionCosMaxAngle_DefaultIs0Point999()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        Assert.Equal(0.999f, cs.mHitReductionCosMaxAngle, precision: 5);
    }

    [Fact]
    public void CharacterVirtualSettings_mPenetrationRecoverySpeed_DefaultIs1()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        Assert.Equal(1.0f, cs.mPenetrationRecoverySpeed);
    }

    [Fact]
    public void CharacterVirtualSettings_mInnerBodyLayer_DefaultIsZero()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        Assert.Equal((ushort)0, cs.mInnerBodyLayer);
    }

    [Fact]
    public void CharacterVirtualSettings_mEnhancedInternalEdgeRemoval_DefaultIsFalse()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        Assert.False(cs.mEnhancedInternalEdgeRemoval);
    }

    [Fact]
    public void CharacterVirtualSettings_mMaxSlopeAngle_DefaultIsDegreesToRadians50()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        float expected = 50.0f * MathF.PI / 180.0f;
        Assert.Equal(expected, cs.mMaxSlopeAngle, precision: 5);
    }

    // ── CharacterVirtualSettings — field round-trips ──────────────────────────

    [Fact]
    public void CharacterVirtualSettings_mMass_RoundTrip()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        cs.mMass = 50.0f;
        Assert.Equal(50.0f, cs.mMass);
    }

    [Fact]
    public void CharacterVirtualSettings_mMaxNumHits_RoundTrip()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        cs.mMaxNumHits = 128u;
        Assert.Equal(128u, cs.mMaxNumHits);
    }

    [Fact]
    public void CharacterVirtualSettings_mMaxCollisionIterations_RoundTrip()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        cs.mMaxCollisionIterations = 10u;
        Assert.Equal(10u, cs.mMaxCollisionIterations);
    }

    [Fact]
    public void CharacterVirtualSettings_mPenetrationRecoverySpeed_RoundTrip()
    {
        using var cs = new JPH.CharacterVirtualSettings();
        cs.mPenetrationRecoverySpeed = 0.5f;
        Assert.Equal(0.5f, cs.mPenetrationRecoverySpeed);
    }

    // ── CharacterContactSettings ──────────────────────────────────────────────

    [Fact]
    public void CharacterContactSettings_DefaultConstruct_NoCrash()
    {
        using var cs = new JPH.CharacterContactSettings();
        Assert.NotNull(cs);
    }

    [Fact]
    public void CharacterContactSettings_mCanPushCharacter_DefaultIsTrue()
    {
        using var cs = new JPH.CharacterContactSettings();
        Assert.True(cs.mCanPushCharacter);
    }

    [Fact]
    public void CharacterContactSettings_mCanReceiveImpulses_DefaultIsTrue()
    {
        using var cs = new JPH.CharacterContactSettings();
        Assert.True(cs.mCanReceiveImpulses);
    }

    [Fact]
    public void CharacterContactSettings_mCanPushCharacter_RoundTrip()
    {
        using var cs = new JPH.CharacterContactSettings();
        cs.mCanPushCharacter = false;
        Assert.False(cs.mCanPushCharacter);
    }

    [Fact]
    public void CharacterContactSettings_mCanReceiveImpulses_RoundTrip()
    {
        using var cs = new JPH.CharacterContactSettings();
        cs.mCanReceiveImpulses = false;
        Assert.False(cs.mCanReceiveImpulses);
    }
}
