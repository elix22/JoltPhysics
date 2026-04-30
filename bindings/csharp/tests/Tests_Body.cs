// Tests for JPH::Body direct method access (not via BodyInterface):
//   - IsRigidBody, IsDynamic, IsStatic, IsKinematic, CanBeKinematicOrDynamic
//   - GetShape returns non-null
//   - GetCollisionGroup
//   - GetInverseInertia (zero for static, non-zero for dynamic)
//   - GetInverseInertia on static body throws InvalidOperationException (precondition guard)
//   - GetWorldSpaceBounds (valid AABox after placement)
//   - IsInBroadPhase (false before add, true after add)
//   - GetInverseCenterOfMassTransform
//   - GetPosition / GetCenterOfMassPosition / GetRotation
//   - GetFriction / GetRestitution
//   - GetAllowSleeping

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Body(JoltFixture fx)
{
    // Helper — create a body and hand back (Body*, BodyID). Body is added to
    // the simulation; caller must RemoveBody + DestroyBody.
    private static (JPH.Body body, JPH.BodyID id) MakeSphere(
        JPH.BodyInterface bi, JPH.EMotionType motion, float x, float y, float z)
    {
        using var ss = new JPH.SphereShapeSettings(0.5f);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        cs.mMotionType  = motion;
        cs.mObjectLayer = motion == JPH.EMotionType.Static
            ? JoltFixture.LayerNonMoving
            : JoltFixture.LayerMoving;
        cs.mPosition.Set(x, y, z);
        var body = bi.CreateBody(cs)!;
        var id   = body.GetID();
        bi.AddBody(id, motion == JPH.EMotionType.Static
            ? JPH.EActivation.DontActivate
            : JPH.EActivation.Activate);
        return (body, id);
    }

    // -------------------------------------------------------------------------
    // Body type predicates
    // -------------------------------------------------------------------------

    [Fact]
    public void Body_DynamicBody_IsRigidBody_IsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Dynamic, 0f, 5f, 0f);
        try { Assert.True(body.IsRigidBody()); }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void Body_DynamicBody_IsDynamic_IsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Dynamic, 0f, 5f, 0f);
        try { Assert.True(body.IsDynamic()); }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void Body_StaticBody_IsStatic_IsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Static, 0f, 0f, 0f);
        try { Assert.True(body.IsStatic()); }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void Body_DynamicBody_IsKinematic_IsFalse()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Dynamic, 0f, 5f, 0f);
        try { Assert.False(body.IsKinematic()); }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void Body_DynamicBody_CanBeKinematicOrDynamic_IsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Dynamic, 0f, 5f, 0f);
        try { Assert.True(body.CanBeKinematicOrDynamic()); }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void Body_StaticBody_CanBeKinematicOrDynamic_IsFalse()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Static, 0f, 0f, 0f);
        try { Assert.False(body.CanBeKinematicOrDynamic()); }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // GetShape
    // -------------------------------------------------------------------------

    [Fact]
    public void Body_GetShape_ReturnsNonNull()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Dynamic, 0f, 5f, 0f);
        try { Assert.NotNull(body.GetShape()); }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // GetInverseInertia  (only valid on dynamic/kinematic bodies)
    // -------------------------------------------------------------------------

    [Fact]
    public void Body_DynamicBody_InverseInertia_IsNonZero()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Dynamic, 0f, 5f, 0f);
        try
        {
            using var m = body.GetInverseInertia();
            // Dynamic sphere has finite inertia → at least one diagonal element != 0
            bool anyNonZero = m.Call(0u, 0u) != 0f || m.Call(1u, 1u) != 0f || m.Call(2u, 2u) != 0f;
            Assert.True(anyNonZero);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void Body_StaticBody_GetInverseInertia_ThrowsInvalidOperationException()
    {
        // The generated precondition guard must throw before reaching the native call,
        // which would otherwise trigger a Jolt assert and hang the process.
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Static, 0f, 0f, 0f);
        try
        {
            Assert.Throws<System.InvalidOperationException>(() => body.GetInverseInertia());
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // GetWorldSpaceBounds
    // -------------------------------------------------------------------------

    [Fact]
    public void Body_GetWorldSpaceBounds_IsValid()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Static, 0f, 0f, 0f);
        try
        {
            var bb = body.GetWorldSpaceBounds();
            Assert.True(bb.IsValid());
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // IsInBroadPhase
    // -------------------------------------------------------------------------

    [Fact]
    public void Body_BeforeAdd_IsInBroadPhase_IsFalse()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();

        using var ss = new JPH.SphereShapeSettings(0.5f);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 5f, 0f);
        var body = bi.CreateBody(cs)!;
        var id   = body.GetID();

        Assert.False(body.IsInBroadPhase());

        bi.DestroyBody(id);
    }

    [Fact]
    public void Body_AfterAdd_IsInBroadPhase_IsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Dynamic, 0f, 5f, 0f);
        try { Assert.True(body.IsInBroadPhase()); }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // GetInverseCenterOfMassTransform
    // -------------------------------------------------------------------------

    [Fact]
    public void Body_GetInverseCenterOfMassTransform_IsValid()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Dynamic, 3f, 1f, -2f);
        try
        {
            using var m = body.GetInverseCenterOfMassTransform();
            Assert.NotNull(m);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // GetPosition / GetCenterOfMassPosition
    // -------------------------------------------------------------------------

    [Fact]
    public void Body_GetPosition_MatchesCreation()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Static, 4f, -3f, 7f);
        try
        {
            using var pos = body.GetPosition();
            Assert.Equal(4f,  pos.GetX(), precision: 4);
            Assert.Equal(-3f, pos.GetY(), precision: 4);
            Assert.Equal(7f,  pos.GetZ(), precision: 4);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // GetFriction / GetRestitution
    // -------------------------------------------------------------------------

    [Fact]
    public void Body_GetFriction_DefaultIsNotNegative()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Dynamic, 0f, 5f, 0f);
        try { Assert.True(body.GetFriction() >= 0f); }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void Body_GetRestitution_DefaultIsNotNegative()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Dynamic, 0f, 5f, 0f);
        try { Assert.True(body.GetRestitution() >= 0f); }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // GetAllowSleeping
    // -------------------------------------------------------------------------

    [Fact]
    public void Body_GetAllowSleeping_DefaultIsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var (body, id) = MakeSphere(bi, JPH.EMotionType.Dynamic, 0f, 5f, 0f);
        try { Assert.True(body.GetAllowSleeping()); }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }
}
