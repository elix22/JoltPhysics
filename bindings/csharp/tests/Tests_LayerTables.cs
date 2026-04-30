using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_LayerTables(JoltFixture fx)
{
    // ── BroadPhaseLayer ───────────────────────────────────────────────────────

    [Fact]
    public void BroadPhaseLayer_ConstructFromByte_GetValueRoundTrip()
    {
        using var layer = new JPH.BroadPhaseLayer((byte)3);
        Assert.Equal((byte)3, layer.GetValue());
    }

    [Fact]
    public void BroadPhaseLayer_Equality_SameValue_ReturnsTrue()
    {
        using var a = new JPH.BroadPhaseLayer((byte)1);
        using var b = new JPH.BroadPhaseLayer((byte)1);
        Assert.True(a == b);
    }

    [Fact]
    public void BroadPhaseLayer_Inequality_DifferentValues_ReturnsTrue()
    {
        using var a = new JPH.BroadPhaseLayer((byte)0);
        using var b = new JPH.BroadPhaseLayer((byte)1);
        Assert.True(a != b);
    }

    [Fact]
    public void BroadPhaseLayer_ExplicitByteCast_ReturnsValue()
    {
        using var layer = new JPH.BroadPhaseLayer((byte)7);
        Assert.Equal((byte)7, (byte)layer);
    }

    [Fact]
    public void BroadPhaseLayer_LessThan_LowerFirst_ReturnsTrue()
    {
        using var a = new JPH.BroadPhaseLayer((byte)0);
        using var b = new JPH.BroadPhaseLayer((byte)1);
        Assert.True(a < b);
    }

    // ── BroadPhaseLayerInterfaceTable ─────────────────────────────────────────

    [Fact]
    public void BroadPhaseLayerInterfaceTable_Construct_GetNumBroadPhaseLayers()
    {
        using var table = new JPH.BroadPhaseLayerInterfaceTable(3u, 2u);
        Assert.Equal(2u, table.GetNumBroadPhaseLayers());
    }

    [Fact]
    public void BroadPhaseLayerInterfaceTable_MapObjectToBroadPhaseLayer_GetBroadPhaseLayer_RoundTrip()
    {
        using var table = new JPH.BroadPhaseLayerInterfaceTable(2u, 2u);
        using var bpLayer1 = new JPH.BroadPhaseLayer((byte)1);
        table.MapObjectToBroadPhaseLayer(0, bpLayer1);
        using var result = table.GetBroadPhaseLayer(0);
        Assert.Equal((byte)1, result.GetValue());
    }

    [Fact]
    public void BroadPhaseLayerInterfaceTable_MapTwoLayers_GetBroadPhaseLayer_Correct()
    {
        using var table = new JPH.BroadPhaseLayerInterfaceTable(2u, 2u);
        using var bpLayer0 = new JPH.BroadPhaseLayer((byte)0);
        using var bpLayer1 = new JPH.BroadPhaseLayer((byte)1);
        table.MapObjectToBroadPhaseLayer(0, bpLayer0);
        table.MapObjectToBroadPhaseLayer(1, bpLayer1);
        using var r0 = table.GetBroadPhaseLayer(0);
        using var r1 = table.GetBroadPhaseLayer(1);
        Assert.Equal((byte)0, r0.GetValue());
        Assert.Equal((byte)1, r1.GetValue());
    }

    // ── ObjectVsBroadPhaseLayerFilterTable ────────────────────────────────────

    [Fact]
    public void ObjectVsBroadPhaseLayerFilterTable_Construct_NoCrash()
    {
        using var bpli = new JPH.BroadPhaseLayerInterfaceTable(2u, 2u);
        using var olpf = new JPH.ObjectLayerPairFilterTable(2u);
        // Cast to const base types to resolve ambiguous implicit conversion
        JPH.Const_BroadPhaseLayerInterfaceTable bpliConst = bpli;
        JPH.Const_ObjectLayerPairFilterTable olpfConst = olpf;
        using var filter = new JPH.ObjectVsBroadPhaseLayerFilterTable(bpliConst, 2u, olpfConst, 2u);
        Assert.NotNull(filter);
    }

    [Fact]
    public void ObjectVsBroadPhaseLayerFilterTable_NoCollisionEnabled_ShouldCollideReturnsFalse()
    {
        using var bpli = new JPH.BroadPhaseLayerInterfaceTable(2u, 2u);
        using var bpLayer0 = new JPH.BroadPhaseLayer((byte)0);
        using var bpLayer1 = new JPH.BroadPhaseLayer((byte)1);
        bpli.MapObjectToBroadPhaseLayer(0, bpLayer0);
        bpli.MapObjectToBroadPhaseLayer(1, bpLayer1);
        using var olpf = new JPH.ObjectLayerPairFilterTable(2u);
        // No EnableCollision calls — all pairs disabled
        JPH.Const_BroadPhaseLayerInterfaceTable bpliConst = bpli;
        JPH.Const_ObjectLayerPairFilterTable olpfConst = olpf;
        using var filter = new JPH.ObjectVsBroadPhaseLayerFilterTable(bpliConst, 2u, olpfConst, 2u);
        Assert.False(filter.ShouldCollide(0, bpLayer0));
        Assert.False(filter.ShouldCollide(0, bpLayer1));
    }

    [Fact]
    public void ObjectVsBroadPhaseLayerFilterTable_WithCollisionEnabled_ShouldCollideReturnsTrue()
    {
        using var bpli = new JPH.BroadPhaseLayerInterfaceTable(2u, 2u);
        using var bpLayer0 = new JPH.BroadPhaseLayer((byte)0);
        using var bpLayer1 = new JPH.BroadPhaseLayer((byte)1);
        // Layer 0 (non-moving) → broadphase layer 0; layer 1 (moving) → broadphase layer 1
        bpli.MapObjectToBroadPhaseLayer(0, bpLayer0);
        bpli.MapObjectToBroadPhaseLayer(1, bpLayer1);
        using var olpf = new JPH.ObjectLayerPairFilterTable(2u);
        // Moving objects (1) collide with non-moving (0)
        olpf.EnableCollision(0, 1);
        JPH.Const_BroadPhaseLayerInterfaceTable bpliConst = bpli;
        JPH.Const_ObjectLayerPairFilterTable olpfConst = olpf;
        using var filter = new JPH.ObjectVsBroadPhaseLayerFilterTable(bpliConst, 2u, olpfConst, 2u);
        // Object layer 0 should collide with broadphase layer 1 (which contains layer 1)
        Assert.True(filter.ShouldCollide(0, bpLayer1));
        // Object layer 0 should NOT collide with broadphase layer 0 (contains only 0; 0+0 not enabled)
        Assert.False(filter.ShouldCollide(0, bpLayer0));
    }

    [Fact]
    public void ObjectVsBroadPhaseLayerFilterTable_MovingLayerVsNonMovingBroadPhase_ShouldCollide()
    {
        using var bpli = new JPH.BroadPhaseLayerInterfaceTable(2u, 2u);
        using var bpLayer0 = new JPH.BroadPhaseLayer((byte)0);
        using var bpLayer1 = new JPH.BroadPhaseLayer((byte)1);
        bpli.MapObjectToBroadPhaseLayer(0, bpLayer0);
        bpli.MapObjectToBroadPhaseLayer(1, bpLayer1);
        using var olpf = new JPH.ObjectLayerPairFilterTable(2u);
        olpf.EnableCollision(0, 1);
        JPH.Const_BroadPhaseLayerInterfaceTable bpliConst = bpli;
        JPH.Const_ObjectLayerPairFilterTable olpfConst = olpf;
        using var filter = new JPH.ObjectVsBroadPhaseLayerFilterTable(bpliConst, 2u, olpfConst, 2u);
        // Symmetric: object layer 1 should also collide with broadphase layer 0
        Assert.True(filter.ShouldCollide(1, bpLayer0));
    }
}
