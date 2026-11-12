// Tests for JPH::BodyCreationSettings field defaults and round-trips.
// These tests exercise only the settings object — no physics system required.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_BodyCreationSettings(JoltFixture fx)
{
    // ── Default-construct ─────────────────────────────────────────────────────

    [Fact]
    public void BodyCreationSettings_DefaultConstruct_NoCrash()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.NotNull(cs);
    }

    // ── Motion type & mass properties ─────────────────────────────────────────

    [Fact]
    public void BodyCreationSettings_DefaultMotionType_IsDynamic()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.Equal(JPH.EMotionType.Dynamic, cs.mMotionType);
    }

    [Fact]
    public void BodyCreationSettings_mMotionType_RoundTrips()
    {
        using var cs = new JPH.BodyCreationSettings();
        cs.mMotionType = JPH.EMotionType.Kinematic;
        Assert.Equal(JPH.EMotionType.Kinematic, cs.mMotionType);
    }

    [Fact]
    public void BodyCreationSettings_HasMassProperties_TrueByDefault()
    {
        // Default mMotionType = Dynamic → HasMassProperties = true
        using var cs = new JPH.BodyCreationSettings();
        Assert.True(cs.HasMassProperties());
    }

    [Fact]
    public void BodyCreationSettings_HasMassProperties_FalseForStatic()
    {
        using var cs = new JPH.BodyCreationSettings();
        cs.mMotionType = JPH.EMotionType.Static;
        Assert.False(cs.HasMassProperties());
    }

    [Fact]
    public void BodyCreationSettings_HasMassProperties_TrueForStaticWithAllowDynamic()
    {
        using var cs = new JPH.BodyCreationSettings();
        cs.mMotionType            = JPH.EMotionType.Static;
        cs.mAllowDynamicOrKinematic = true;
        Assert.True(cs.HasMassProperties());
    }

    // ── Boolean flags ─────────────────────────────────────────────────────────

    [Fact]
    public void BodyCreationSettings_DefaultIsSensor_IsFalse()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.False(cs.mIsSensor);
    }

    [Fact]
    public void BodyCreationSettings_DefaultAllowSleeping_IsTrue()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.True(cs.mAllowSleeping);
    }

    [Fact]
    public void BodyCreationSettings_DefaultApplyGyroscopicForce_IsFalse()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.False(cs.mApplyGyroscopicForce);
    }

    [Fact]
    public void BodyCreationSettings_DefaultUseManifoldReduction_IsTrue()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.True(cs.mUseManifoldReduction);
    }

    [Fact]
    public void BodyCreationSettings_DefaultCollideKinematicVsNonDynamic_IsFalse()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.False(cs.mCollideKinematicVsNonDynamic);
    }

    [Fact]
    public void BodyCreationSettings_DefaultEnhancedInternalEdgeRemoval_IsFalse()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.False(cs.mEnhancedInternalEdgeRemoval);
    }

    // ── Float fields ──────────────────────────────────────────────────────────

    [Fact]
    public void BodyCreationSettings_DefaultFriction_Is0_2()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.Equal(0.2f, cs.mFriction, precision: 5);
    }

    [Fact]
    public void BodyCreationSettings_DefaultRestitution_IsZero()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.Equal(0.0f, cs.mRestitution);
    }

    [Fact]
    public void BodyCreationSettings_DefaultLinearDamping_Is0_05()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.Equal(0.05f, cs.mLinearDamping, precision: 5);
    }

    [Fact]
    public void BodyCreationSettings_DefaultAngularDamping_Is0_05()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.Equal(0.05f, cs.mAngularDamping, precision: 5);
    }

    [Fact]
    public void BodyCreationSettings_DefaultMaxLinearVelocity_Is500()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.Equal(500.0f, cs.mMaxLinearVelocity);
    }

    [Fact]
    public void BodyCreationSettings_DefaultGravityFactor_Is1()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.Equal(1.0f, cs.mGravityFactor);
    }

    [Fact]
    public void BodyCreationSettings_DefaultInertiaMultiplier_Is1()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.Equal(1.0f, cs.mInertiaMultiplier);
    }

    // ── uint fields ───────────────────────────────────────────────────────────

    [Fact]
    public void BodyCreationSettings_DefaultNumVelocityStepsOverride_IsZero()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.Equal(0u, cs.mNumVelocityStepsOverride);
    }

    [Fact]
    public void BodyCreationSettings_DefaultNumPositionStepsOverride_IsZero()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.Equal(0u, cs.mNumPositionStepsOverride);
    }

    // ── Motion quality ────────────────────────────────────────────────────────

    [Fact]
    public void BodyCreationSettings_DefaultMotionQuality_IsDiscrete()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.Equal(JPH.EMotionQuality.Discrete, cs.mMotionQuality);
    }

    // ── Field round-trips ─────────────────────────────────────────────────────

    [Fact]
    public void BodyCreationSettings_mFriction_RoundTrips()
    {
        using var cs = new JPH.BodyCreationSettings();
        cs.mFriction = 0.75f;
        Assert.Equal(0.75f, cs.mFriction);
    }

    [Fact]
    public void BodyCreationSettings_mRestitution_RoundTrips()
    {
        using var cs = new JPH.BodyCreationSettings();
        cs.mRestitution = 0.5f;
        Assert.Equal(0.5f, cs.mRestitution);
    }

    [Fact]
    public void BodyCreationSettings_mGravityFactor_RoundTrips()
    {
        using var cs = new JPH.BodyCreationSettings();
        cs.mGravityFactor = 2.0f;
        Assert.Equal(2.0f, cs.mGravityFactor);
    }

    [Fact]
    public void BodyCreationSettings_mUserData_RoundTrips()
    {
        using var cs = new JPH.BodyCreationSettings();
        cs.mUserData = (UIntPtr)0xDEADBEEFu;
        Assert.Equal((UIntPtr)0xDEADBEEFu, cs.mUserData);
    }

    [Fact]
    public void BodyCreationSettings_mAllowSleeping_RoundTrips()
    {
        using var cs = new JPH.BodyCreationSettings();
        cs.mAllowSleeping = false;
        Assert.False(cs.mAllowSleeping);
    }

    [Fact]
    public void BodyCreationSettings_mInertiaMultiplier_RoundTrips()
    {
        using var cs = new JPH.BodyCreationSettings();
        cs.mInertiaMultiplier = 2.5f;
        Assert.Equal(2.5f, cs.mInertiaMultiplier);
    }

    // ── Constructor with shape ─────────────────────────────────────────────────

    [Fact]
    public void BodyCreationSettings_ConstructWithShape_GetShape_ReturnsNonNull()
    {
        using var shape = new JPH.SphereShapeSettings(0.5f);
        using var cs = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)shape, new JPH.Vec3(0f, 0f, 0f),
            JPH.Quat.SIdentity(), JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);
        Assert.NotNull(cs.GetShapeSettings());
    }
}
