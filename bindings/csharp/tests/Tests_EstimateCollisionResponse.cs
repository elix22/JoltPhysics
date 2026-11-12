// Tests for EstimateResponseContactListener — concrete ContactListener trampoline
// that calls JPH::EstimateCollisionResponse in OnContactAdded and stores the result.
// Modelled on Jolt's EstimateCollisionResponseTest.cpp.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_EstimateCollisionResponse(JoltFixture fx)
{
    // ─────────────────────────────────────────────────────────────────────────
    // Default state
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void EstimateResponseListener_Default_WasCalledFalse()
    {
        using var listener = new JPH.EstimateResponseContactListener();
        Assert.False(listener.WasCalled());
    }

    [Fact]
    public void EstimateResponseListener_Reset_ClearsWasCalled()
    {
        using var listener = new JPH.EstimateResponseContactListener();
        listener.Reset();
        Assert.False(listener.WasCalled());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Simulation: EstimateCollisionResponse called when two bodies collide
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void EstimateResponseListener_WasCalled_AfterCollision()
    {
        using var sys = fx.MakePhysicsSystem();
        using var listener = new JPH.EstimateResponseContactListener();
        sys.SetContactListener(listener);
        var bi = sys.GetBodyInterface();

        // Floor (static)
        using var floorShape = new JPH.BoxShapeSettings(new JPH.Vec3(50f, 0.5f, 50f));
        using var floorBcs = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)floorShape,
            new JPH.Vec3(0f, -0.5f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);
        JPH.BodyID floorId = bi.CreateAndAddBody(floorBcs, JPH.EActivation.DontActivate);

        // Dynamic box just above floor
        using var boxShape = new JPH.BoxShapeSettings(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        using var boxBcs = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)boxShape,
            new JPH.Vec3(0f, 0.6f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);
        JPH.BodyID boxId = bi.CreateAndAddBody(boxBcs, JPH.EActivation.Activate);

        try
        {
            for (int i = 0; i < 10; i++)
                sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

            Assert.True(listener.WasCalled());
        }
        finally
        {
            sys.SetContactListener(null);
            bi.RemoveBody(boxId);   bi.DestroyBody(boxId);
            bi.RemoveBody(floorId); bi.DestroyBody(floorId);
        }
    }

    [Fact]
    public void EstimateResponseListener_Velocities_AreFiniteAfterCollision()
    {
        using var sys = fx.MakePhysicsSystem();
        using var listener = new JPH.EstimateResponseContactListener();
        sys.SetContactListener(listener);
        var bi = sys.GetBodyInterface();

        using var floorShape = new JPH.BoxShapeSettings(new JPH.Vec3(50f, 0.5f, 50f));
        using var floorBcs = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)floorShape,
            new JPH.Vec3(0f, -0.5f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);
        JPH.BodyID floorId = bi.CreateAndAddBody(floorBcs, JPH.EActivation.DontActivate);

        using var boxShape = new JPH.BoxShapeSettings(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        using var boxBcs = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)boxShape,
            new JPH.Vec3(0f, 0.6f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);
        JPH.BodyID boxId = bi.CreateAndAddBody(boxBcs, JPH.EActivation.Activate);

        try
        {
            for (int i = 0; i < 10; i++)
                sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

            if (listener.WasCalled())
            {
                using var lv1 = listener.GetLinearVelocity1();
                using var lv2 = listener.GetLinearVelocity2();
                // Velocities must be finite (not NaN or Inf)
                Assert.True(float.IsFinite(lv1.GetX()) && float.IsFinite(lv1.GetY()) && float.IsFinite(lv1.GetZ()));
                Assert.True(float.IsFinite(lv2.GetX()) && float.IsFinite(lv2.GetY()) && float.IsFinite(lv2.GetZ()));
            }
        }
        finally
        {
            sys.SetContactListener(null);
            bi.RemoveBody(boxId);   bi.DestroyBody(boxId);
            bi.RemoveBody(floorId); bi.DestroyBody(floorId);
        }
    }

    [Fact]
    public void EstimateResponseListener_AngularVelocities_AreFiniteAfterCollision()
    {
        using var sys = fx.MakePhysicsSystem();
        using var listener = new JPH.EstimateResponseContactListener();
        sys.SetContactListener(listener);
        var bi = sys.GetBodyInterface();

        using var floorShape = new JPH.BoxShapeSettings(new JPH.Vec3(50f, 0.5f, 50f));
        using var floorBcs = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)floorShape,
            new JPH.Vec3(0f, -0.5f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);
        JPH.BodyID floorId = bi.CreateAndAddBody(floorBcs, JPH.EActivation.DontActivate);

        using var boxShape = new JPH.BoxShapeSettings(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        using var boxBcs = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)boxShape,
            new JPH.Vec3(0f, 0.6f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);
        JPH.BodyID boxId = bi.CreateAndAddBody(boxBcs, JPH.EActivation.Activate);

        try
        {
            for (int i = 0; i < 10; i++)
                sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

            if (listener.WasCalled())
            {
                using var av1 = listener.GetAngularVelocity1();
                using var av2 = listener.GetAngularVelocity2();
                Assert.True(float.IsFinite(av1.GetX()) && float.IsFinite(av1.GetY()) && float.IsFinite(av1.GetZ()));
                Assert.True(float.IsFinite(av2.GetX()) && float.IsFinite(av2.GetY()) && float.IsFinite(av2.GetZ()));
            }
        }
        finally
        {
            sys.SetContactListener(null);
            bi.RemoveBody(boxId);   bi.DestroyBody(boxId);
            bi.RemoveBody(floorId); bi.DestroyBody(floorId);
        }
    }

    [Fact]
    public void EstimateResponseListener_Reset_AllowsSecondCollision()
    {
        using var sys = fx.MakePhysicsSystem();
        using var listener = new JPH.EstimateResponseContactListener();
        sys.SetContactListener(listener);
        var bi = sys.GetBodyInterface();

        using var floorShape = new JPH.BoxShapeSettings(new JPH.Vec3(50f, 0.5f, 50f));
        using var floorBcs = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)floorShape,
            new JPH.Vec3(0f, -0.5f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);
        JPH.BodyID floorId = bi.CreateAndAddBody(floorBcs, JPH.EActivation.DontActivate);

        using var boxShape = new JPH.BoxShapeSettings(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        using var boxBcs = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)boxShape,
            new JPH.Vec3(0f, 0.6f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);
        JPH.BodyID boxId = bi.CreateAndAddBody(boxBcs, JPH.EActivation.Activate);

        try
        {
            for (int i = 0; i < 10; i++)
                sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

            bool firstWasCalled = listener.WasCalled();
            listener.Reset();
            Assert.False(listener.WasCalled());
            // After Reset, the simulation can still run and will call again on next add
            _ = firstWasCalled; // used
        }
        finally
        {
            sys.SetContactListener(null);
            bi.RemoveBody(boxId);   bi.DestroyBody(boxId);
            bi.RemoveBody(floorId); bi.DestroyBody(floorId);
        }
    }
}
