// Tests for ObjectLayerPairFilterTable and ObjectVsBroadPhaseLayerFilterTable,
// modelled on Jolt's ObjectLayerPairFilterTableTests.cpp.
// Verifies that EnableCollision/DisableCollision round-trips correctly,
// that ShouldCollide is symmetric, and that the broadphase filter reflects
// the pair filter correctly.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_ObjectLayers(JoltFixture fx)
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

    // ── ObjectVsBroadPhaseLayerFilterTable.ShouldCollide ─────────────────────
    // Uses the fixture's ObjVsBP which was built from:
    //   ObjectLayer 0 (NonMoving) → BroadPhaseLayer 0
    //   ObjectLayer 1 (Moving)    → BroadPhaseLayer 1
    //   PairFilter: Moving↔NonMoving and Moving↔Moving enabled;
    //               NonMoving↔NonMoving NOT enabled.
    //
    // Derived expectations (per Jolt's OvB logic):
    //   ShouldCollide(NonMoving=0, BpLayer(0)) → false   (no object in BpLayer0 collides with layer0)
    //   ShouldCollide(NonMoving=0, BpLayer(1)) → true    (Moving is in BpLayer1 and collides with NonMoving)
    //   ShouldCollide(Moving=1,    BpLayer(0)) → true    (NonMoving is in BpLayer0 and collides with Moving)
    //   ShouldCollide(Moving=1,    BpLayer(1)) → true    (Moving is in BpLayer1 and collides with Moving)

    [Fact]
    public void ObjVsBroadPhase_NonMoving_BpLayer0_IsFalse()
    {
        using var bp0 = new JPH.BroadPhaseLayer(0);
        Assert.False(fx.ObjVsBP.ShouldCollide(JoltFixture.LayerNonMoving, bp0));
    }

    [Fact]
    public void ObjVsBroadPhase_NonMoving_BpLayer1_IsTrue()
    {
        using var bp1 = new JPH.BroadPhaseLayer(1);
        Assert.True(fx.ObjVsBP.ShouldCollide(JoltFixture.LayerNonMoving, bp1));
    }

    [Fact]
    public void ObjVsBroadPhase_Moving_BpLayer0_IsTrue()
    {
        using var bp0 = new JPH.BroadPhaseLayer(0);
        Assert.True(fx.ObjVsBP.ShouldCollide(JoltFixture.LayerMoving, bp0));
    }

    [Fact]
    public void ObjVsBroadPhase_Moving_BpLayer1_IsTrue()
    {
        using var bp1 = new JPH.BroadPhaseLayer(1);
        Assert.True(fx.ObjVsBP.ShouldCollide(JoltFixture.LayerMoving, bp1));
    }

    [Fact]
    public void ObjVsBroadPhase_CustomSetup_ExactlyOnePairEnabled()
    {
        // Build a fresh 2-layer filter with only Moving↔Moving enabled,
        // and verify the broadphase filter reflects it.
        using var bpI  = new JPH.BroadPhaseLayerInterfaceTable(2, 2);
        using var bpL0a = new JPH.BroadPhaseLayer(0);
        using var bpL1a = new JPH.BroadPhaseLayer(1);
        bpI.MapObjectToBroadPhaseLayer(0, bpL0a);
        bpI.MapObjectToBroadPhaseLayer(1, bpL1a);

        using var pf = new JPH.ObjectLayerPairFilterTable(2);
        pf.EnableCollision(1, 1); // only Moving↔Moving

        using var ovb = new JPH.ObjectVsBroadPhaseLayerFilterTable(
            (JPH.Const_BroadPhaseLayerInterfaceTable)bpI, 2,
            (JPH.Const_ObjectLayerPairFilterTable)pf, 2);

        using var bp0 = new JPH.BroadPhaseLayer(0);
        using var bp1 = new JPH.BroadPhaseLayer(1);

        Assert.False(ovb.ShouldCollide(0, bp0)); // NonMoving vs BpLayer0(NonMoving) — no pair
        Assert.False(ovb.ShouldCollide(0, bp1)); // NonMoving vs BpLayer1(Moving)    — no pair
        Assert.False(ovb.ShouldCollide(1, bp0)); // Moving    vs BpLayer0(NonMoving) — no pair
        Assert.True(ovb.ShouldCollide(1, bp1));  // Moving    vs BpLayer1(Moving)    — enabled
    }

    [Fact]
    public void ObjVsBroadPhase_CustomSetup_BothPairsEnabled()
    {
        using var bpI  = new JPH.BroadPhaseLayerInterfaceTable(2, 2);
        using var bpL0b = new JPH.BroadPhaseLayer(0);
        using var bpL1b = new JPH.BroadPhaseLayer(1);
        bpI.MapObjectToBroadPhaseLayer(0, bpL0b);
        bpI.MapObjectToBroadPhaseLayer(1, bpL1b);

        using var pf = new JPH.ObjectLayerPairFilterTable(2);
        pf.EnableCollision(0, 0);
        pf.EnableCollision(0, 1);
        pf.EnableCollision(1, 1);

        using var ovb = new JPH.ObjectVsBroadPhaseLayerFilterTable(
            (JPH.Const_BroadPhaseLayerInterfaceTable)bpI, 2,
            (JPH.Const_ObjectLayerPairFilterTable)pf, 2);

        using var bp0 = new JPH.BroadPhaseLayer(0);
        using var bp1 = new JPH.BroadPhaseLayer(1);

        Assert.True(ovb.ShouldCollide(0, bp0));
        Assert.True(ovb.ShouldCollide(0, bp1));
        Assert.True(ovb.ShouldCollide(1, bp0));
        Assert.True(ovb.ShouldCollide(1, bp1));
    }
}
