// Tests for CharacterSettings construction and property getters/setters.
//
// Tested APIs:
//   - CharacterSettings() default constructor
//   - mLayer default and round-trip
//   - mMass default and round-trip
//   - mFriction default and round-trip
//   - mGravityFactor default and round-trip
//   - mMaxSlopeAngle default (50 degrees) and round-trip
//   - mEnhancedInternalEdgeRemoval default and round-trip
//   - mUp default (Y-axis) getter

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_CharacterSettings(JoltFixture fx)
{
    // ── CharacterSettings — default construction ──────────────────────────────

    [Fact]
    public void CharacterSettings_DefaultConstruct_NoCrash()
    {
        using var cs = new JPH.CharacterSettings();
        Assert.NotNull(cs);
    }

    [Fact]
    public void CharacterSettings_mLayer_DefaultIsZero()
    {
        using var cs = new JPH.CharacterSettings();
        Assert.Equal((ushort)0, cs.mLayer);
    }

    [Fact]
    public void CharacterSettings_mMass_DefaultIs80()
    {
        using var cs = new JPH.CharacterSettings();
        Assert.Equal(80.0f, cs.mMass);
    }

    [Fact]
    public void CharacterSettings_mFriction_DefaultIs0Point2()
    {
        using var cs = new JPH.CharacterSettings();
        Assert.Equal(0.2f, cs.mFriction, precision: 5);
    }

    [Fact]
    public void CharacterSettings_mGravityFactor_DefaultIs1()
    {
        using var cs = new JPH.CharacterSettings();
        Assert.Equal(1.0f, cs.mGravityFactor);
    }

    [Fact]
    public void CharacterSettings_mMaxSlopeAngle_DefaultIs50Degrees()
    {
        using var cs = new JPH.CharacterSettings();
        float expected = 50.0f * MathF.PI / 180.0f;
        Assert.Equal(expected, cs.mMaxSlopeAngle, precision: 5);
    }

    [Fact]
    public void CharacterSettings_mEnhancedInternalEdgeRemoval_DefaultIsFalse()
    {
        using var cs = new JPH.CharacterSettings();
        Assert.False(cs.mEnhancedInternalEdgeRemoval);
    }

    [Fact]
    public void CharacterSettings_mUp_DefaultIsYAxis()
    {
        using var cs = new JPH.CharacterSettings();
        using var up = cs.mUp;
        Assert.Equal(0.0f, up.GetX(), precision: 5);
        Assert.Equal(1.0f, up.GetY(), precision: 5);
        Assert.Equal(0.0f, up.GetZ(), precision: 5);
    }

    // ── CharacterSettings — field round-trips ────────────────────────────────

    [Fact]
    public void CharacterSettings_mLayer_RoundTrip()
    {
        using var cs = new JPH.CharacterSettings();
        cs.mLayer = JoltFixture.LayerMoving;
        Assert.Equal(JoltFixture.LayerMoving, cs.mLayer);
    }

    [Fact]
    public void CharacterSettings_mMass_RoundTrip()
    {
        using var cs = new JPH.CharacterSettings();
        cs.mMass = 60.0f;
        Assert.Equal(60.0f, cs.mMass);
    }

    [Fact]
    public void CharacterSettings_mFriction_RoundTrip()
    {
        using var cs = new JPH.CharacterSettings();
        cs.mFriction = 0.5f;
        Assert.Equal(0.5f, cs.mFriction, precision: 5);
    }

    [Fact]
    public void CharacterSettings_mGravityFactor_RoundTrip()
    {
        using var cs = new JPH.CharacterSettings();
        cs.mGravityFactor = 2.0f;
        Assert.Equal(2.0f, cs.mGravityFactor);
    }

    [Fact]
    public void CharacterSettings_mMaxSlopeAngle_RoundTrip()
    {
        using var cs = new JPH.CharacterSettings();
        float angle = 45.0f * MathF.PI / 180.0f;
        cs.mMaxSlopeAngle = angle;
        Assert.Equal(angle, cs.mMaxSlopeAngle, precision: 5);
    }

    [Fact]
    public void CharacterSettings_mEnhancedInternalEdgeRemoval_RoundTrip()
    {
        using var cs = new JPH.CharacterSettings();
        cs.mEnhancedInternalEdgeRemoval = true;
        Assert.True(cs.mEnhancedInternalEdgeRemoval);
    }
}
