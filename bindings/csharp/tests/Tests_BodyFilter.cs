using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_BodyFilter(JoltFixture fx)
{
    // ── BodyFilter (base) ─────────────────────────────────────────────────────

    [Fact]
    public void BodyFilter_DefaultConstruct_NoCrash()
    {
        using var f = new JPH.BodyFilter();
        Assert.NotNull(f);
    }

    [Fact]
    public void BodyFilter_ShouldCollide_AnyBody_ReturnsTrue()
    {
        using var f = new JPH.BodyFilter();
        var id = new JPH.BodyID(5u);
        Assert.True(f.ShouldCollide(id));
    }

    [Fact]
    public void BodyFilter_ShouldCollide_InvalidBody_ReturnsTrue()
    {
        using var f = new JPH.BodyFilter();
        var id = new JPH.BodyID();  // default invalid ID
        Assert.True(f.ShouldCollide(id));
    }

    // ── IgnoreSingleBodyFilter ────────────────────────────────────────────────

    [Fact]
    public void IgnoreSingleBodyFilter_Construct_NoCrash()
    {
        var id = new JPH.BodyID(10u);
        using var f = new JPH.IgnoreSingleBodyFilter(id);
        Assert.NotNull(f);
    }

    [Fact]
    public void IgnoreSingleBodyFilter_ShouldCollide_IgnoredBody_ReturnsFalse()
    {
        var id = new JPH.BodyID(10u);
        using var f = new JPH.IgnoreSingleBodyFilter(id);
        Assert.False(f.ShouldCollide(id));
    }

    [Fact]
    public void IgnoreSingleBodyFilter_ShouldCollide_OtherBody_ReturnsTrue()
    {
        var id = new JPH.BodyID(10u);
        var otherId = new JPH.BodyID(20u);
        using var f = new JPH.IgnoreSingleBodyFilter(id);
        Assert.True(f.ShouldCollide(otherId));
    }

    [Fact]
    public void IgnoreSingleBodyFilter_ShouldCollide_DifferentSequenceNumber_ReturnsTrue()
    {
        // Same index, different sequence number → different body ID
        var id1 = new JPH.BodyID(10u, 1);
        var id2 = new JPH.BodyID(10u, 2);
        using var f = new JPH.IgnoreSingleBodyFilter(id1);
        Assert.True(f.ShouldCollide(id2));
    }

    // ── IgnoreMultipleBodiesFilter ────────────────────────────────────────────

    [Fact]
    public void IgnoreMultipleBodiesFilter_DefaultConstruct_NoCrash()
    {
        using var f = new JPH.IgnoreMultipleBodiesFilter();
        Assert.NotNull(f);
    }

    [Fact]
    public void IgnoreMultipleBodiesFilter_ShouldCollide_BeforeIgnore_ReturnsTrue()
    {
        using var f = new JPH.IgnoreMultipleBodiesFilter();
        var id = new JPH.BodyID(5u);
        Assert.True(f.ShouldCollide(id));
    }

    [Fact]
    public void IgnoreMultipleBodiesFilter_Reserve_NoCrash()
    {
        using var f = new JPH.IgnoreMultipleBodiesFilter();
        f.Reserve(8u);  // should not crash
    }

    [Fact]
    public void IgnoreMultipleBodiesFilter_IgnoreBody_ShouldCollide_ReturnsFalse()
    {
        using var f = new JPH.IgnoreMultipleBodiesFilter();
        var id = new JPH.BodyID(5u);
        f.IgnoreBody(id);
        Assert.False(f.ShouldCollide(id));
    }

    [Fact]
    public void IgnoreMultipleBodiesFilter_NonIgnoredBody_ShouldCollide_ReturnsTrue()
    {
        using var f = new JPH.IgnoreMultipleBodiesFilter();
        var ignored = new JPH.BodyID(5u);
        var other   = new JPH.BodyID(6u);
        f.IgnoreBody(ignored);
        Assert.True(f.ShouldCollide(other));
    }

    [Fact]
    public void IgnoreMultipleBodiesFilter_MultipleIgnored_AllReturnFalse()
    {
        using var f = new JPH.IgnoreMultipleBodiesFilter();
        var id1 = new JPH.BodyID(1u);
        var id2 = new JPH.BodyID(2u);
        var id3 = new JPH.BodyID(3u);
        f.IgnoreBody(id1);
        f.IgnoreBody(id2);
        f.IgnoreBody(id3);
        Assert.False(f.ShouldCollide(id1));
        Assert.False(f.ShouldCollide(id2));
        Assert.False(f.ShouldCollide(id3));
    }

    [Fact]
    public void IgnoreMultipleBodiesFilter_Clear_ResetsIgnoreList()
    {
        using var f = new JPH.IgnoreMultipleBodiesFilter();
        var id = new JPH.BodyID(5u);
        f.IgnoreBody(id);
        f.Clear();
        // After clear, body should no longer be ignored
        Assert.True(f.ShouldCollide(id));
    }
}
