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

    // ── Constraint-based determinism ──────────────────────────────────────────

    private (float x1, float y1, float z1, float x2, float y2, float z2) RunConstrainedPair(int numSteps)
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
        var floorId   = bi.CreateAndAddBody(floorCS, JPH.EActivation.DontActivate);

        // Sphere 1 at (-2, 5, 0)
        using var ss1 = new JPH.SphereShapeSettings(0.5f);
        using var cs1 = new JPH.BodyCreationSettings();
        cs1.SetShapeSettings((JPH.Const_SphereShapeSettings)ss1);
        cs1.mMotionType  = JPH.EMotionType.Dynamic;
        cs1.mObjectLayer = JoltFixture.LayerMoving;
        cs1.mPosition.Set(-2f, 5f, 0f);
        var body1 = bi.CreateBody(cs1)!;
        var id1   = body1.GetID();
        bi.AddBody(id1, JPH.EActivation.Activate);

        // Sphere 2 at (2, 5, 0)
        using var ss2 = new JPH.SphereShapeSettings(0.5f);
        using var cs2 = new JPH.BodyCreationSettings();
        cs2.SetShapeSettings((JPH.Const_SphereShapeSettings)ss2);
        cs2.mMotionType  = JPH.EMotionType.Dynamic;
        cs2.mObjectLayer = JoltFixture.LayerMoving;
        cs2.mPosition.Set(2f, 5f, 0f);
        var body2 = bi.CreateBody(cs2)!;
        var id2   = body2.GetID();
        bi.AddBody(id2, JPH.EActivation.Activate);

        // Point constraint linking them at origin
        using var constraintSettings = new JPH.PointConstraintSettings();
        constraintSettings.mPoint1.Set(-2f, 5f, 0f);
        constraintSettings.mPoint2.Set(-2f, 5f, 0f);
        var constraint = constraintSettings.Create(body1, body2)!;
        sys.AddConstraint(constraint);

        sys.OptimizeBroadPhase();

        const float dt = 1f / 60f;
        for (int i = 0; i < numSteps; i++)
            sys.Update(dt, 1, fx.Alloc, fx.Jobs);

        float x1, y1, z1, x2, y2, z2;
        using (var p = bi.GetPosition(id1)) { x1 = p.GetX(); y1 = p.GetY(); z1 = p.GetZ(); }
        using (var p = bi.GetPosition(id2)) { x2 = p.GetX(); y2 = p.GetY(); z2 = p.GetZ(); }

        bi.RemoveBody(id2);   bi.DestroyBody(id2);
        bi.RemoveBody(id1);   bi.DestroyBody(id1);
        bi.RemoveBody(floorId); bi.DestroyBody(floorId);

        return (x1, y1, z1, x2, y2, z2);
    }

    [Fact]
    public void ConstrainedSimulation_TwoIdenticalRuns_BitForBitEqual()
    {
        const int steps = 60;
        var (x1a, y1a, z1a, x2a, y2a, z2a) = RunConstrainedPair(steps);
        var (x1b, y1b, z1b, x2b, y2b, z2b) = RunConstrainedPair(steps);

        Assert.Equal(x1a, x1b);
        Assert.Equal(y1a, y1b);
        Assert.Equal(z1a, z1b);
        Assert.Equal(x2a, x2b);
        Assert.Equal(y2a, y2b);
        Assert.Equal(z2a, z2b);
    }

    [Fact]
    public void ConstrainedSimulation_ConstrainedBodiesMoveTogetherInY()
    {
        // Two spheres linked by a PointConstraint, both start at the same height.
        // After simulation they should have similar Y positions (both fall together).
        const int steps = 30;
        var (_, y1, _, _, y2, _) = RunConstrainedPair(steps);
        Assert.Equal(y1, y2, precision: 3);
    }
}
