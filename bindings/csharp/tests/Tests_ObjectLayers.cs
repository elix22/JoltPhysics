// ObjectLayerPairFilterTable tests, modelled on Jolt's CollisionGroupTests.cpp.
// Verifies that EnableCollision/DisableCollision round-trips
// correctly and that ShouldCollide is symmetric.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_ObjectLayers
{
    // ── Default / construction ────────────────────────────────────────────────

    [Fact]
    public void ObjectLayerPairFilter_Constructor_TracksTotalLayers()
    {
        using var f = new JPH.ObjectLayerPairFilterTable(4);
        Assert.Equal(4u, f.GetNumObjectLayers());
    }

    // ── EnableCollision / DisableCollision ────────────────────────────────────

    [Fact]
    public void ObjectLayerPairFilter_EnabledByDefault_ShouldCollide()
    {
        // Freshly created filter — by default nothing collides; explicitly enable.
        using var f = new JPH.ObjectLayerPairFilterTable(3);
        f.EnableCollision(0, 1);
        Assert.True(f.ShouldCollide(0, 1));
    }

    [Fact]
    public void ObjectLayerPairFilter_EnableThenDisable_ShouldNotCollide()
    {
        using var f = new JPH.ObjectLayerPairFilterTable(3);
        f.EnableCollision(0, 1);
        f.DisableCollision(0, 1);
        Assert.False(f.ShouldCollide(0, 1));
    }

    [Fact]
    public void ObjectLayerPairFilter_ShouldCollide_IsSymmetric()
    {
        using var f = new JPH.ObjectLayerPairFilterTable(4);
        f.EnableCollision(1, 2);
        Assert.Equal(f.ShouldCollide(1, 2), f.ShouldCollide(2, 1));
    }

    [Fact]
    public void ObjectLayerPairFilter_DisabledPair_SymmetricFalse()
    {
        using var f = new JPH.ObjectLayerPairFilterTable(4);
        // Enable then disable
        f.EnableCollision(2, 3);
        f.DisableCollision(2, 3);
        Assert.False(f.ShouldCollide(2, 3));
        Assert.False(f.ShouldCollide(3, 2));
    }

    [Fact]
    public void ObjectLayerPairFilter_SelfLayerNotEnabled_ShouldNotCollide()
    {
        using var f = new JPH.ObjectLayerPairFilterTable(3);
        // Nothing enabled → layer 0 does not collide with itself
        Assert.False(f.ShouldCollide(0, 0));
    }

    [Fact]
    public void ObjectLayerPairFilter_MultipleEnables_AllWork()
    {
        using var f = new JPH.ObjectLayerPairFilterTable(4);
        f.EnableCollision(0, 1);
        f.EnableCollision(0, 2);
        f.EnableCollision(1, 3);
        Assert.True(f.ShouldCollide(0, 1));
        Assert.True(f.ShouldCollide(0, 2));
        Assert.True(f.ShouldCollide(1, 3));
        Assert.False(f.ShouldCollide(0, 3));
        Assert.False(f.ShouldCollide(2, 3));
    }

    [Fact]
    public void ObjectLayerPairFilter_DisableDoesNotAffectOtherPairs()
    {
        using var f = new JPH.ObjectLayerPairFilterTable(4);
        f.EnableCollision(0, 1);
        f.EnableCollision(2, 3);
        f.DisableCollision(0, 1);
        Assert.False(f.ShouldCollide(0, 1));
        Assert.True(f.ShouldCollide(2, 3));
    }

    // ── Integration: custom filter drives PhysicsSystem init ─────────────────

    [Fact]
    public void ObjectLayerPairFilter_UsedInPhysicsSystem_CorrectLayerCount()
    {
        // Build a physics system with a 4-layer filter and verify it initialises.
        using var bpInterface = new JPH.BroadPhaseLayerInterfaceTable(4, 2);
        bpInterface.MapObjectToBroadPhaseLayer(0, new JPH.BroadPhaseLayer(0));
        bpInterface.MapObjectToBroadPhaseLayer(1, new JPH.BroadPhaseLayer(1));
        bpInterface.MapObjectToBroadPhaseLayer(2, new JPH.BroadPhaseLayer(0));
        bpInterface.MapObjectToBroadPhaseLayer(3, new JPH.BroadPhaseLayer(1));

        using var pairFilter = new JPH.ObjectLayerPairFilterTable(4);
        pairFilter.EnableCollision(0, 1);
        pairFilter.EnableCollision(2, 3);

        using var objVsBP = new JPH.ObjectVsBroadPhaseLayerFilterTable(
            (JPH.Const_BroadPhaseLayerInterfaceTable)bpInterface, 2,
            (JPH.Const_ObjectLayerPairFilterTable)pairFilter, 4);

        using var sys = new JPH.PhysicsSystem();
        sys.Init(256, 0, 256, 256,
            (JPH.Const_BroadPhaseLayerInterfaceTable)bpInterface,
            (JPH.Const_ObjectVsBroadPhaseLayerFilterTable)objVsBP,
            (JPH.Const_ObjectLayerPairFilterTable)pairFilter);

        Assert.Equal(0u, sys.GetNumBodies());
    }
}
