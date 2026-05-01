// Tests for physics simulation determinism.
// Runs two identical simulations (same bodies, same initial state, same steps)
// and verifies that the final body positions are bit-for-bit identical.
// This mirrors JoltPhysics/UnitTests/Physics/PhysicsDeterminismTests.cpp.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_PhysicsDeterminism(JoltFixture fx)
{
    // ── Helper: run a deterministic simulation and return the final position ──

    private JPH.Vec3 RunSimulation(int numSteps)
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        // Static floor
        using var floorSettings = new JPH.BoxShapeSettings(new JPH.Vec3(50f, 1f, 50f));
        using var floorCS = new JPH.BodyCreationSettings();
        floorCS.SetShapeSettings((JPH.Const_BoxShapeSettings)floorSettings);
        floorCS.mMotionType  = JPH.EMotionType.Static;
        floorCS.mObjectLayer = JoltFixture.LayerNonMoving;
        floorCS.mPosition.Set(0f, -1f, 0f);
        var floorId = bi.CreateAndAddBody(floorCS, JPH.EActivation.DontActivate);

        // Dynamic sphere
        using var sphereSettings = new JPH.SphereShapeSettings(0.5f);
        using var sphereCS = new JPH.BodyCreationSettings();
        sphereCS.SetShapeSettings((JPH.Const_SphereShapeSettings)sphereSettings);
        sphereCS.mMotionType  = JPH.EMotionType.Dynamic;
        sphereCS.mObjectLayer = JoltFixture.LayerMoving;
        sphereCS.mPosition.Set(0f, 5f, 0f);
        var sphereId = bi.CreateAndAddBody(sphereCS, JPH.EActivation.Activate);

        const float dt = 1f / 60f;
        for (int i = 0; i < numSteps; i++)
            sys.Update(dt, 1, fx.Alloc, fx.Jobs);

        using var pos = bi.GetPosition(sphereId);
        var result = new JPH.Vec3(pos.GetX(), pos.GetY(), pos.GetZ());

        bi.RemoveBody(sphereId);  bi.DestroyBody(sphereId);
        bi.RemoveBody(floorId);   bi.DestroyBody(floorId);

        return result;
    }

    // ── Determinism tests ─────────────────────────────────────────────────────

    [Fact]
    public void Determinism_TwoIdenticalRuns_ProduceSamePosition()
    {
        using var pos1 = RunSimulation(60);
        using var pos2 = RunSimulation(60);
        Assert.Equal(pos1.GetX(), pos2.GetX());
        Assert.Equal(pos1.GetY(), pos2.GetY());
        Assert.Equal(pos1.GetZ(), pos2.GetZ());
    }

    [Fact]
    public void Determinism_SingleStep_ProducesSamePosition()
    {
        using var pos1 = RunSimulation(1);
        using var pos2 = RunSimulation(1);
        Assert.Equal(pos1.GetX(), pos2.GetX());
        Assert.Equal(pos1.GetY(), pos2.GetY());
        Assert.Equal(pos1.GetZ(), pos2.GetZ());
    }

    [Fact]
    public void Determinism_ManySteps_ProducesSamePosition()
    {
        using var pos1 = RunSimulation(180);
        using var pos2 = RunSimulation(180);
        Assert.Equal(pos1.GetX(), pos2.GetX());
        Assert.Equal(pos1.GetY(), pos2.GetY());
        Assert.Equal(pos1.GetZ(), pos2.GetZ());
    }

    // ── mDeterministicSimulation flag ─────────────────────────────────────────

    [Fact]
    public void PhysicsSettings_mDeterministicSimulation_DefaultIsTrue()
    {
        using var settings = new JPH.PhysicsSettings();
        Assert.True(settings.mDeterministicSimulation);
    }

    [Fact]
    public void PhysicsSettings_mDeterministicSimulation_CanBeDisabled()
    {
        using var settings = new JPH.PhysicsSettings();
        settings.mDeterministicSimulation = false;
        Assert.False(settings.mDeterministicSimulation);
    }
}
