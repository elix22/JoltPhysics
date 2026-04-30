using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_PhysicsMaterial(JoltFixture fx)
{
    // ── Default construction ──────────────────────────────────────────────────

    [Fact]
    public void PhysicsMaterial_DefaultConstruct_NoCrash()
    {
        using var mat = new JPH.PhysicsMaterial();
        Assert.NotNull(mat);
    }

    [Fact]
    public void Const_PhysicsMaterial_DefaultConstruct_NoCrash()
    {
        using var mat = new JPH.Const_PhysicsMaterial();
        Assert.NotNull(mat);
    }

    // ── Reference counting ────────────────────────────────────────────────────

    [Fact]
    public void PhysicsMaterial_GetRefCount_InitiallyOne()
    {
        using var mat = new JPH.PhysicsMaterial();
        // C binding calls AddRef on construction, giving ownership to the wrapper
        Assert.Equal(1u, mat.GetRefCount());
    }

    [Fact]
    public void PhysicsMaterial_AddRef_IncrementsRefCount()
    {
        // Deliberately not using 'using' — AddRef increments refcount;
        // Dispose calls the C++ destructor directly and does not call Release.
        var mat = new JPH.PhysicsMaterial();
        mat.AddRef(); // now 2
        Assert.Equal(2u, mat.GetRefCount());
        mat.Dispose();
    }

    [Fact]
    public void PhysicsMaterial_SetEmbedded_MakesRefCountLarge()
    {
        using var mat = new JPH.PhysicsMaterial();
        mat.SetEmbedded();
        // cEmbedded = 0x0ebedded (a pun) is added to mRefCount; starting from 1 → ≥ 0x0ebedded
        Assert.True(mat.GetRefCount() >= 0x0EBEDDEDu);
    }

    // ── SInternalGetRefCountOffset ────────────────────────────────────────────

    [Fact]
    public void PhysicsMaterial_SInternalGetRefCountOffset_NonNegative()
    {
        int offset = JPH.Const_PhysicsMaterial.SInternalGetRefCountOffset();
        Assert.True(offset >= 0);
    }

    // ── Const accessor ────────────────────────────────────────────────────────

    [Fact]
    public void PhysicsMaterial_GetRefCount_IsOneOnConstVariant()
    {
        using var mat = new JPH.Const_PhysicsMaterial();
        Assert.Equal(1u, mat.GetRefCount());
    }
}
