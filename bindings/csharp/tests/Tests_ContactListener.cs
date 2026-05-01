// Tests for SimpleContactEventListener — concrete ContactListener trampoline
// that counts validate/add/persist/remove callbacks and tracks the last pair.
// Modelled on Jolt's ContactListenerTests.cpp.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_ContactListener(JoltFixture fx)
{
    // ─────────────────────────────────────────────────────────────────────────
    // Default state
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void ContactListener_DefaultCounts_AreZero()
    {
        using var listener = new JPH.SimpleContactEventListener();
        Assert.Equal(0, listener.GetAddedCount());
        Assert.Equal(0, listener.GetValidateCount());
        Assert.Equal(0, listener.GetPersistedCount());
        Assert.Equal(0, listener.GetRemovedCount());
    }

    [Fact]
    public void ContactListener_Reset_ClearsAllCounts()
    {
        using var listener = new JPH.SimpleContactEventListener();
        listener.Reset();
        Assert.Equal(0, listener.GetAddedCount());
        Assert.Equal(0, listener.GetValidateCount());
        Assert.Equal(0, listener.GetPersistedCount());
        Assert.Equal(0, listener.GetRemovedCount());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Simulation: OnContactAdded called when two bodies collide
    // ─────────────────────────────────────────────────────────────────────────

    private static (JPH.BodyID floor, JPH.BodyID sphere) CreateCollidingBodies(
        JPH.BodyInterface bi, int layerNonMoving, int layerMoving)
    {
        using var floorShape = new JPH.BoxShapeSettings(new JPH.Vec3(50f, 0.5f, 50f));
        using var floorBcs = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)floorShape,
            new JPH.Vec3(0f, -0.5f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, (ushort)layerNonMoving);
        JPH.BodyID floorId = bi.CreateAndAddBody(floorBcs, JPH.EActivation.DontActivate);

        using var sphereShape = new JPH.SphereShapeSettings(0.5f);
        using var sphereBcs = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)sphereShape,
            new JPH.Vec3(0f, 0.6f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, (ushort)layerMoving);
        JPH.BodyID sphereId = bi.CreateAndAddBody(sphereBcs, JPH.EActivation.Activate);

        return (floorId, sphereId);
    }

    [Fact]
    public void ContactListener_OnContactAdded_CalledOnCollision()
    {
        using var sys = fx.MakePhysicsSystem();
        using var listener = new JPH.SimpleContactEventListener();
        sys.SetContactListener(listener);
        var bi = sys.GetBodyInterface();

        var (floorId, sphereId) = CreateCollidingBodies(bi, JoltFixture.LayerNonMoving, JoltFixture.LayerMoving);
        try
        {
            for (int i = 0; i < 10; i++)
                sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

            Assert.True(listener.GetAddedCount() > 0);
            Assert.True(listener.GetValidateCount() > 0);
        }
        finally
        {
            sys.SetContactListener(null);
            bi.RemoveBody(sphereId); bi.DestroyBody(sphereId);
            bi.RemoveBody(floorId);  bi.DestroyBody(floorId);
        }
    }

    [Fact]
    public void ContactListener_OnContactPersisted_CalledOnSubsequentSteps()
    {
        using var sys = fx.MakePhysicsSystem();
        using var listener = new JPH.SimpleContactEventListener();
        sys.SetContactListener(listener);
        var bi = sys.GetBodyInterface();

        var (floorId, sphereId) = CreateCollidingBodies(bi, JoltFixture.LayerNonMoving, JoltFixture.LayerMoving);
        try
        {
            // Step enough for contact to persist over multiple frames
            for (int i = 0; i < 20; i++)
                sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

            Assert.True(listener.GetPersistedCount() > 0);
        }
        finally
        {
            sys.SetContactListener(null);
            bi.RemoveBody(sphereId); bi.DestroyBody(sphereId);
            bi.RemoveBody(floorId);  bi.DestroyBody(floorId);
        }
    }

    [Fact]
    public void ContactListener_LastAddedBodyIDs_AreValid()
    {
        using var sys = fx.MakePhysicsSystem();
        using var listener = new JPH.SimpleContactEventListener();
        sys.SetContactListener(listener);
        var bi = sys.GetBodyInterface();

        var (floorId, sphereId) = CreateCollidingBodies(bi, JoltFixture.LayerNonMoving, JoltFixture.LayerMoving);
        try
        {
            for (int i = 0; i < 10; i++)
                sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

            if (listener.GetAddedCount() > 0)
            {
                var id1 = listener.GetLastAddedBody1();
                var id2 = listener.GetLastAddedBody2();
                // Both IDs should be one of the two bodies we created
                Assert.True(id1 == floorId || id1 == sphereId);
                Assert.True(id2 == floorId || id2 == sphereId);
                Assert.NotEqual(id1, id2);
            }
        }
        finally
        {
            sys.SetContactListener(null);
            bi.RemoveBody(sphereId); bi.DestroyBody(sphereId);
            bi.RemoveBody(floorId);  bi.DestroyBody(floorId);
        }
    }

    [Fact]
    public void ContactListener_OnContactRemoved_CalledAfterBodyRemoved()
    {
        using var sys = fx.MakePhysicsSystem();
        using var listener = new JPH.SimpleContactEventListener();
        sys.SetContactListener(listener);
        var bi = sys.GetBodyInterface();

        var (floorId, sphereId) = CreateCollidingBodies(bi, JoltFixture.LayerNonMoving, JoltFixture.LayerMoving);

        // Step until contact is established
        for (int i = 0; i < 10; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        int removedBefore = listener.GetRemovedCount();

        // Remove the sphere body — should trigger OnContactRemoved
        bi.RemoveBody(sphereId); bi.DestroyBody(sphereId);
        sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);
        bi.RemoveBody(floorId);  bi.DestroyBody(floorId);

        sys.SetContactListener(null);

        Assert.True(listener.GetRemovedCount() > removedBefore);
    }
}
