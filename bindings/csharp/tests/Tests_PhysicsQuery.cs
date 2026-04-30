using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_PhysicsQuery(JoltFixture fx)
{
    // ────────────────────────────────────────────────────────────────────────
    // Gravity
    // ────────────────────────────────────────────────────────────────────────

    [Fact]
    public void PhysicsSystem_GetGravity_DefaultFromFixture_IsDownward()
    {
        using var sys = fx.MakePhysicsSystem();
        using var g   = sys.GetGravity();
        Assert.Equal( 0f,    g.GetX());
        Assert.Equal(-9.81f, g.GetY(), precision: 3);
        Assert.Equal( 0f,    g.GetZ());
    }

    [Fact]
    public void PhysicsSystem_SetGravity_GetGravity_RoundTrips()
    {
        using var sys = fx.MakePhysicsSystem();
        using var g2  = new JPH.Vec3(0f, -5f, 0f);
        sys.SetGravity(g2);

        using var got = sys.GetGravity();
        Assert.Equal( 0f, got.GetX());
        Assert.Equal(-5f, got.GetY(), precision: 4);
        Assert.Equal( 0f, got.GetZ());
    }

    [Fact]
    public void PhysicsSystem_SetGravity_ZeroGravity_ReturnsZero()
    {
        using var sys  = fx.MakePhysicsSystem();
        using var zero = new JPH.Vec3(0f, 0f, 0f);
        sys.SetGravity(zero);

        using var got = sys.GetGravity();
        Assert.Equal(0f, got.GetX());
        Assert.Equal(0f, got.GetY());
        Assert.Equal(0f, got.GetZ());
    }

    // ────────────────────────────────────────────────────────────────────────
    // GetNumBodies / GetMaxBodies
    // ────────────────────────────────────────────────────────────────────────

    [Fact]
    public void PhysicsSystem_GetNumBodies_Initially_IsZero()
    {
        using var sys = fx.MakePhysicsSystem();
        Assert.Equal(0u, sys.GetNumBodies());
    }

    [Fact]
    public void PhysicsSystem_GetMaxBodies_EqualsRequestedLimit()
    {
        using var sys = fx.MakePhysicsSystem(512u);
        Assert.Equal(512u, sys.GetMaxBodies());
    }

    [Fact]
    public void PhysicsSystem_GetNumBodies_AfterAddingOneBody_IsOne()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var ss  = new JPH.SphereShapeSettings(0.5f);
        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;

        var id = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        Assert.Equal(1u, sys.GetNumBodies());

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void PhysicsSystem_GetNumBodies_AfterRemovingBody_IsZero()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var ss  = new JPH.SphereShapeSettings(0.5f);
        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;

        var id = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        bi.RemoveBody(id);
        bi.DestroyBody(id);

        Assert.Equal(0u, sys.GetNumBodies());
    }

    // ────────────────────────────────────────────────────────────────────────
    // WereBodiesInContact
    // ────────────────────────────────────────────────────────────────────────

    [Fact]
    public void PhysicsSystem_WereBodiesInContact_SeparateBodies_IsFalse()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var ss  = new JPH.SphereShapeSettings(0.5f);
        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;

        // Place bodies far apart
        bcs.mPosition.Set( 0f, 0f,  0f); var id1 = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        bcs.mPosition.Set(10f, 0f, 10f); var id2 = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);

        Assert.False(sys.WereBodiesInContact(id1, id2));

        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
    }

    [Fact]
    public void PhysicsSystem_WereBodiesInContact_AfterCollision_IsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        // Floor (static box, y=0)
        using var floorHalf = new JPH.Vec3(10f, 0.5f, 10f);
        using var floorSS   = new JPH.BoxShapeSettings(floorHalf);
        using var floorBCS  = new JPH.BodyCreationSettings();
        floorBCS.SetShapeSettings((JPH.Const_BoxShapeSettings)floorSS);
        floorBCS.mMotionType  = JPH.EMotionType.Static;
        floorBCS.mObjectLayer = JoltFixture.LayerNonMoving;
        floorBCS.mPosition.Set(0f, -0.5f, 0f);
        var floorId = bi.CreateAndAddBody(floorBCS, JPH.EActivation.DontActivate);

        // Sphere (dynamic, starts just above floor)
        using var sphereSS  = new JPH.SphereShapeSettings(0.5f);
        using var sphereBCS = new JPH.BodyCreationSettings();
        sphereBCS.SetShapeSettings((JPH.Const_SphereShapeSettings)sphereSS);
        sphereBCS.mMotionType  = JPH.EMotionType.Dynamic;
        sphereBCS.mObjectLayer = JoltFixture.LayerMoving;
        sphereBCS.mPosition.Set(0f, 2.0f, 0f);
        var sphereId = bi.CreateAndAddBody(sphereBCS, JPH.EActivation.Activate);

        // Run enough steps for the sphere to settle on the floor
        for (int i = 0; i < 60; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        Assert.True(sys.WereBodiesInContact(floorId, sphereId));

        bi.RemoveBody(floorId);  bi.DestroyBody(floorId);
        bi.RemoveBody(sphereId); bi.DestroyBody(sphereId);
    }

    // ────────────────────────────────────────────────────────────────────────
    // BroadPhaseQuery
    // ────────────────────────────────────────────────────────────────────────

    [Fact]
    public void PhysicsSystem_GetBroadPhaseQuery_IsNotNull()
    {
        using var sys = fx.MakePhysicsSystem();
        var bpq = sys.GetBroadPhaseQuery();
        Assert.NotNull(bpq);
    }

    [Fact]
    public void BroadPhaseQuery_GetBounds_EmptyWorld_DoesNotCrash()
    {
        using var sys    = fx.MakePhysicsSystem();
        var bpq   = sys.GetBroadPhaseQuery();
        using var bounds = bpq.GetBounds();
        // An empty world has an inverted (inside-out) bounding box — just check no crash
        Assert.NotNull(bounds);
    }

    [Fact]
    public void BroadPhaseQuery_GetBounds_AfterAddingBody_IsLargerThanEmpty()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var bpq = sys.GetBroadPhaseQuery();
        using var emptyBounds = bpq.GetBounds();
        using var emptySize   = emptyBounds.GetSize();
        float emptyVol = emptySize.GetX() * emptySize.GetY() * emptySize.GetZ();

        // Add a sphere body
        using var ss  = new JPH.SphereShapeSettings(1f);
        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;
        var id = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);

        using var filledBounds = bpq.GetBounds();
        using var filledSize   = filledBounds.GetSize();
        float filledVol = filledSize.GetX() * filledSize.GetY() * filledSize.GetZ();

        Assert.True(filledVol > emptyVol);

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    // ────────────────────────────────────────────────────────────────────────
    // NarrowPhaseQuery / listener defaults
    // ────────────────────────────────────────────────────────────────────────

    [Fact]
    public void PhysicsSystem_GetNarrowPhaseQuery_IsNotNull()
    {
        using var sys = fx.MakePhysicsSystem();
        var npq = sys.GetNarrowPhaseQuery();
        Assert.NotNull(npq);
    }

    [Fact]
    public void PhysicsSystem_GetBodyActivationListener_DefaultIsNull()
    {
        using var sys = fx.MakePhysicsSystem();
        Assert.Null(sys.GetBodyActivationListener());
    }

    [Fact]
    public void PhysicsSystem_GetContactListener_DefaultIsNull()
    {
        using var sys = fx.MakePhysicsSystem();
        Assert.Null(sys.GetContactListener());
    }
}
