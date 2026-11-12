using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_CharacterID(JoltFixture fx)
{
    // ── Constants ─────────────────────────────────────────────────────────────

    [Fact]
    public void CharacterID_CInvalidCharacterID_IsMaxUint()
    {
        Assert.Equal(0xFFFFFFFFu, JPH.Const_CharacterID.CInvalidCharacterID);
    }

    // ── Default construction ──────────────────────────────────────────────────

    [Fact]
    public void CharacterID_DefaultConstruct_NoCrash()
    {
        using var id = new JPH.CharacterID();
        Assert.NotNull(id);
    }

    [Fact]
    public void CharacterID_DefaultConstruct_IsInvalid()
    {
        using var id = new JPH.CharacterID();
        Assert.True(id.IsInvalid());
    }

    [Fact]
    public void CharacterID_DefaultConstruct_GetValueEqualsInvalidConstant()
    {
        using var id = new JPH.CharacterID();
        Assert.Equal(JPH.Const_CharacterID.CInvalidCharacterID, id.GetValue());
    }

    // ── Parameterized construction ────────────────────────────────────────────

    [Fact]
    public void CharacterID_ConstructFromUint_GetValueRoundTrip()
    {
        using var id = new JPH.CharacterID(999u);
        Assert.Equal(999u, id.GetValue());
    }

    [Fact]
    public void CharacterID_ConstructFromUint_IsNotInvalid()
    {
        using var id = new JPH.CharacterID(1u);
        Assert.False(id.IsInvalid());
    }

    // ── Equality operators ────────────────────────────────────────────────────

    [Fact]
    public void CharacterID_Equality_SameValue_ReturnsTrue()
    {
        using var a = new JPH.CharacterID(42u);
        using var b = new JPH.CharacterID(42u);
        Assert.True(a == b);
    }

    [Fact]
    public void CharacterID_Inequality_DifferentValues_ReturnsTrue()
    {
        using var a = new JPH.CharacterID(1u);
        using var b = new JPH.CharacterID(2u);
        Assert.True(a != b);
    }

    [Fact]
    public void CharacterID_LessThan_LowerFirst_ReturnsTrue()
    {
        using var a = new JPH.CharacterID(10u);
        using var b = new JPH.CharacterID(20u);
        Assert.True(a < b);
    }

    [Fact]
    public void CharacterID_GreaterThan_HigherFirst_ReturnsTrue()
    {
        using var a = new JPH.CharacterID(20u);
        using var b = new JPH.CharacterID(10u);
        Assert.True(a > b);
    }

    // ── Copy construction ─────────────────────────────────────────────────────

    [Fact]
    public void CharacterID_CopyConstruct_PreservesValue()
    {
        using var original = new JPH.CharacterID(555u);
        using var copy = new JPH.CharacterID(original);
        Assert.Equal(original.GetValue(), copy.GetValue());
    }

    // ── Hashing ───────────────────────────────────────────────────────────────

    [Fact]
    public void CharacterID_GetHash_SameIDsSameHash()
    {
        using var a = new JPH.CharacterID(77u);
        using var b = new JPH.CharacterID(77u);
        Assert.Equal(a.GetHash(), b.GetHash());
    }

    [Fact]
    public void CharacterID_Equals_SameValue_ReturnsTrue()
    {
        using var a = new JPH.CharacterID(100u);
        using var b = new JPH.CharacterID(100u);
        Assert.True(a.Equals(b));
    }
}
