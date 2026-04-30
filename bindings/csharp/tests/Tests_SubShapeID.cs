using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_SubShapeID(JoltFixture fx)
{
    // ── Static constant ───────────────────────────────────────────────────────

    [Fact]
    public void SubShapeID_MaxBits_Is32()
    {
        Assert.Equal(32u, JPH.Const_SubShapeID.MaxBits);
    }

    // ── Default construction ──────────────────────────────────────────────────

    [Fact]
    public void SubShapeID_DefaultConstruct_NoCrash()
    {
        using var id = new JPH.SubShapeID();
        Assert.NotNull(id);
    }

    [Fact]
    public void SubShapeID_DefaultConstruct_IsEmpty()
    {
        using var id = new JPH.SubShapeID();
        Assert.True(id.IsEmpty());
    }

    [Fact]
    public void SubShapeID_DefaultConstruct_GetValue_IsCEmpty()
    {
        using var id = new JPH.SubShapeID();
        Assert.Equal(0xFFFFFFFFu, id.GetValue());
    }

    // ── SetValue / GetValue ───────────────────────────────────────────────────

    [Fact]
    public void SubShapeID_SetValue_RoundTrips()
    {
        using var id = new JPH.SubShapeID();
        id.SetValue(42u);
        Assert.Equal(42u, id.GetValue());
    }

    [Fact]
    public void SubShapeID_SetValue_Zero_IsNotEmpty()
    {
        using var id = new JPH.SubShapeID();
        id.SetValue(0u);
        Assert.False(id.IsEmpty());
    }

    [Fact]
    public void SubShapeID_SetValue_CEmpty_IsEmpty()
    {
        using var id = new JPH.SubShapeID();
        id.SetValue(0xFFFFFFFFu);
        Assert.True(id.IsEmpty());
    }

    // ── Equality operators ────────────────────────────────────────────────────

    [Fact]
    public void SubShapeID_Equality_SameValues_IsEqual()
    {
        using var a = new JPH.SubShapeID();
        using var b = new JPH.SubShapeID();
        a.SetValue(77u);
        b.SetValue(77u);
        Assert.True(a == b);
    }

    [Fact]
    public void SubShapeID_Inequality_DifferentValues_IsNotEqual()
    {
        using var a = new JPH.SubShapeID();
        using var b = new JPH.SubShapeID();
        a.SetValue(10u);
        b.SetValue(20u);
        Assert.True(a != b);
    }

    [Fact]
    public void SubShapeID_EqualityWithDefault_BothEmpty()
    {
        using var a = new JPH.SubShapeID();
        using var b = new JPH.SubShapeID();
        // Both start as cEmpty, so they should be equal
        Assert.True(a == b);
    }
}
