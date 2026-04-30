using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_ContactSettings(JoltFixture fx)
{
    // ── Default construction ──────────────────────────────────────────────────

    [Fact]
    public void ContactSettings_DefaultConstruct_NoCrash()
    {
        using var cs = new JPH.ContactSettings();
        Assert.NotNull(cs);
    }

    [Fact]
    public void ContactSettings_DefaultConstruct_mInvMassScale1_IsOne()
    {
        using var cs = new JPH.ContactSettings();
        Assert.Equal(1.0f, cs.mInvMassScale1);
    }

    [Fact]
    public void ContactSettings_DefaultConstruct_mInvInertiaScale1_IsOne()
    {
        using var cs = new JPH.ContactSettings();
        Assert.Equal(1.0f, cs.mInvInertiaScale1);
    }

    [Fact]
    public void ContactSettings_DefaultConstruct_mInvMassScale2_IsOne()
    {
        using var cs = new JPH.ContactSettings();
        Assert.Equal(1.0f, cs.mInvMassScale2);
    }

    [Fact]
    public void ContactSettings_DefaultConstruct_mInvInertiaScale2_IsOne()
    {
        using var cs = new JPH.ContactSettings();
        Assert.Equal(1.0f, cs.mInvInertiaScale2);
    }

    // ── Field round-trips ─────────────────────────────────────────────────────

    [Fact]
    public void ContactSettings_mInvMassScale1_RoundTrip()
    {
        using var cs = new JPH.ContactSettings();
        cs.mInvMassScale1 = 0.0f;
        Assert.Equal(0.0f, cs.mInvMassScale1);
    }

    [Fact]
    public void ContactSettings_mInvInertiaScale1_RoundTrip()
    {
        using var cs = new JPH.ContactSettings();
        cs.mInvInertiaScale1 = 2.0f;
        Assert.Equal(2.0f, cs.mInvInertiaScale1);
    }

    [Fact]
    public void ContactSettings_mInvMassScale2_RoundTrip()
    {
        using var cs = new JPH.ContactSettings();
        cs.mInvMassScale2 = 0.5f;
        Assert.Equal(0.5f, cs.mInvMassScale2);
    }

    [Fact]
    public void ContactSettings_mInvInertiaScale2_RoundTrip()
    {
        using var cs = new JPH.ContactSettings();
        cs.mInvInertiaScale2 = 3.0f;
        Assert.Equal(3.0f, cs.mInvInertiaScale2);
    }

    [Fact]
    public void ContactSettings_mIsSensor_RoundTrip()
    {
        using var cs = new JPH.ContactSettings();
        cs.mIsSensor = true;
        Assert.True(cs.mIsSensor);
    }

    [Fact]
    public void ContactSettings_mIsSensor_SetFalse_RoundTrip()
    {
        using var cs = new JPH.ContactSettings();
        cs.mIsSensor = true;
        cs.mIsSensor = false;
        Assert.False(cs.mIsSensor);
    }

    // ── Copy construction ─────────────────────────────────────────────────────

    [Fact]
    public void ContactSettings_CopyConstruct_PreservesInvMassScale()
    {
        using var original = new JPH.ContactSettings();
        original.mInvMassScale1 = 4.0f;
        original.mInvMassScale2 = 0.25f;
        using var copy = new JPH.ContactSettings(original);
        Assert.Equal(4.0f, copy.mInvMassScale1);
        Assert.Equal(0.25f, copy.mInvMassScale2);
    }

    // ── Const_ContactSettings ─────────────────────────────────────────────────

    [Fact]
    public void Const_ContactSettings_DefaultConstruct_NoCrash()
    {
        using var cs = new JPH.Const_ContactSettings();
        Assert.NotNull(cs);
    }

    [Fact]
    public void Const_ContactSettings_DefaultConstruct_mInvMassScale1_IsOne()
    {
        using var cs = new JPH.Const_ContactSettings();
        Assert.Equal(1.0f, cs.mInvMassScale1);
    }
}
