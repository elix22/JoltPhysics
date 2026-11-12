// Shared xUnit collection fixture that initialises and shuts down Jolt once
// per test run, and provides a ready-to-use PhysicsSystem together with a
// BodyInterface to every test class that needs it.

using Xunit;

namespace JoltTests;

/// <summary>
/// One-time Jolt runtime initialisation / shutdown for the whole test assembly.
/// xUnit creates this once, shared across all collection members.
/// </summary>
public sealed class JoltFixture : IDisposable
{
    // Layer indices used by all tests.
    public const ushort LayerNonMoving = 0;
    public const ushort LayerMoving    = 1;

    public JPH.TempAllocatorImpl   Alloc   { get; }
    public JPH.JobSystemThreadPool Jobs    { get; }

    // Broad-phase infrastructure (shared, read-only after construction).
    public JPH.BroadPhaseLayerInterfaceTable          BpInterface  { get; }
    public JPH.ObjectLayerPairFilterTable             PairFilter   { get; }
    public JPH.ObjectVsBroadPhaseLayerFilterTable     ObjVsBP      { get; }

    public JoltFixture()
    {
        JPH.Const_JoltHelpers.Init();

        Alloc = new JPH.TempAllocatorImpl(64 * 1024 * 1024);
        Jobs  = new JPH.JobSystemThreadPool(2048, 8, -1);

        BpInterface = new JPH.BroadPhaseLayerInterfaceTable(2, 2);
        using var bp0 = new JPH.BroadPhaseLayer(0);
        using var bp1 = new JPH.BroadPhaseLayer(1);
        BpInterface.MapObjectToBroadPhaseLayer(LayerNonMoving, bp0);
        BpInterface.MapObjectToBroadPhaseLayer(LayerMoving,    bp1);

        PairFilter = new JPH.ObjectLayerPairFilterTable(2);
        PairFilter.EnableCollision(LayerMoving, LayerNonMoving);
        PairFilter.EnableCollision(LayerMoving, LayerMoving);

        ObjVsBP = new JPH.ObjectVsBroadPhaseLayerFilterTable(
            (JPH.Const_BroadPhaseLayerInterfaceTable)BpInterface, 2,
            (JPH.Const_ObjectLayerPairFilterTable)PairFilter, 2);
    }

    /// <summary>
    /// Create a fresh PhysicsSystem pre-configured with the shared layer tables.
    /// Each test that mutates the world should create its own system.
    /// </summary>
    public JPH.PhysicsSystem MakePhysicsSystem(uint maxBodies = 1024)
    {
        var sys = new JPH.PhysicsSystem();
        sys.Init(maxBodies, 0, maxBodies, maxBodies,
            (JPH.Const_BroadPhaseLayerInterfaceTable)BpInterface,
            (JPH.Const_ObjectVsBroadPhaseLayerFilterTable)ObjVsBP,
            (JPH.Const_ObjectLayerPairFilterTable)PairFilter);
        using var gravity = new JPH.Vec3(0f, -9.81f, 0f);
        sys.SetGravity(gravity);
        return sys;
    }

    public void Dispose()
    {
        ObjVsBP.Dispose();
        PairFilter.Dispose();
        BpInterface.Dispose();
        Jobs.Dispose();
        Alloc.Dispose();
        JPH.Const_JoltHelpers.Shutdown();
    }
}

/// <summary>
/// xUnit collection definition.  All test classes decorated with
/// [Collection("Jolt")] share one JoltFixture instance.
/// </summary>
[CollectionDefinition("Jolt")]
public sealed class JoltCollection : ICollectionFixture<JoltFixture> {}
