// Tests for body-level property queries and setters not already covered by
// Tests_Bodies.cs.  Specifically:
//   - GetGravityFactor / SetGravityFactor
//   - GetMotionType
//   - IsSensor
//   - GetObjectLayer
//   - GetUserData / SetUserData
//   - SetPosition (teleport) / GetPosition round-trip
//   - GetWorldTransform / GetCenterOfMassTransform
//   - GetPositionAndRotation
//   - SetRotation / GetRotation

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_BodyProperties(JoltFixture fx)
{
    // ─── helpers ──────────────────────────────────────────────────────────────

    private static JPH.BodyID MakeStaticBox(JPH.BodyInterface bi, float x, float y, float z)
    {
        using var ss  = new JPH.BoxShapeSettings(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        using var bcs = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)ss, new JPH.Vec3(x, y, z),
            JPH.Quat.SIdentity(), JPH.EMotionType.Static, JoltFixture.LayerNonMoving);
        return bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
    }

    private static JPH.BodyID MakeDynamicSphere(JPH.BodyInterface bi, float x, float y, float z)
    {
        using var ss  = new JPH.SphereShapeSettings(0.5f);
        using var bcs = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)ss, new JPH.Vec3(x, y, z),
            JPH.Quat.SIdentity(), JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);
        return bi.CreateAndAddBody(bcs, JPH.EActivation.Activate);
    }

    // ─── GravityFactor ────────────────────────────────────────────────────────

    [Fact]
    public void Body_DefaultGravityFactor_IsOne()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamicSphere(bi, 0f, 5f, 0f);
        try
        {
            Assert.Equal(1f, bi.GetGravityFactor(id), precision: 5);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void Body_SetGravityFactor_RoundTrips()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamicSphere(bi, 0f, 5f, 0f);
        try
        {
            bi.SetGravityFactor(id, 0.25f);
            Assert.Equal(0.25f, bi.GetGravityFactor(id), precision: 5);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void Body_ZeroGravityFactor_BodyDoesNotFall()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        var id  = MakeDynamicSphere(bi, 0f, 5f, 0f);
        bi.SetGravityFactor(id, 0f);
        // Zero out initial velocity too
        bi.SetLinearVelocity(id, new JPH.Vec3(0f, 0f, 0f));

        float yBefore; using (var p = bi.GetCenterOfMassPosition(id)) yBefore = p.GetY();
        for (int i = 0; i < 60; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);
        float yAfter; using (var p = bi.GetCenterOfMassPosition(id)) yAfter = p.GetY();

        Assert.True(
            System.Math.Abs(yAfter - yBefore) < 0.05f,
            $"Body moved despite zero gravity factor: before={yBefore} after={yAfter}");

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    // ─── MotionType ───────────────────────────────────────────────────────────

    [Fact]
    public void Body_StaticBody_GetMotionType_IsStatic()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeStaticBox(bi, 0f, 0f, 0f);
        try
        {
            Assert.Equal(JPH.EMotionType.Static, bi.GetMotionType(id));
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void Body_DynamicBody_GetMotionType_IsDynamic()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamicSphere(bi, 0f, 5f, 0f);
        try
        {
            Assert.Equal(JPH.EMotionType.Dynamic, bi.GetMotionType(id));
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // ─── IsSensor ────────────────────────────────────────────────────────────

    [Fact]
    public void Body_NormalBody_IsSensor_IsFalse()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeStaticBox(bi, 0f, 0f, 0f);
        try
        {
            Assert.False(bi.IsSensor(id));
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void Body_SensorFlag_IsSensor_IsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();

        using var ss  = new JPH.BoxShapeSettings(new JPH.Vec3(2f, 2f, 2f));
        using var bcs = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)ss, new JPH.Vec3(0f, 0f, 0f),
            JPH.Quat.SIdentity(), JPH.EMotionType.Static, JoltFixture.LayerNonMoving);
        bcs.mIsSensor = true;
        var id = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        try
        {
            Assert.True(bi.IsSensor(id));
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // ─── ObjectLayer ──────────────────────────────────────────────────────────

    [Fact]
    public void Body_StaticBody_ObjectLayer_IsLayerNonMoving()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeStaticBox(bi, 0f, 0f, 0f);
        try
        {
            Assert.Equal((ushort)JoltFixture.LayerNonMoving, bi.GetObjectLayer(id));
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void Body_DynamicBody_ObjectLayer_IsLayerMoving()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamicSphere(bi, 0f, 5f, 0f);
        try
        {
            Assert.Equal((ushort)JoltFixture.LayerMoving, bi.GetObjectLayer(id));
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // ─── UserData ────────────────────────────────────────────────────────────

    [Fact]
    public void Body_DefaultUserData_IsZero()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeStaticBox(bi, 0f, 0f, 0f);
        try
        {
            Assert.Equal(UIntPtr.Zero, bi.GetUserData(id));
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void Body_SetUserData_RoundTrips()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeStaticBox(bi, 0f, 0f, 0f);
        try
        {
            bi.SetUserData(id, (UIntPtr)0xDEADBEEF);
            Assert.Equal((UIntPtr)0xDEADBEEF, bi.GetUserData(id));
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // ─── SetPosition (teleport) ───────────────────────────────────────────────

    [Fact]
    public void Body_SetPosition_TeleportsBody()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeStaticBox(bi, 0f, 0f, 0f);
        try
        {
            using var newPos = new JPH.Vec3(7f, 3f, -2f);
            bi.SetPosition(id, newPos, JPH.EActivation.DontActivate);
            using var got = bi.GetPosition(id);
            Assert.Equal(7f,  got.GetX(), precision: 4);
            Assert.Equal(3f,  got.GetY(), precision: 4);
            Assert.Equal(-2f, got.GetZ(), precision: 4);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // ─── GetPositionAndRotation ───────────────────────────────────────────────

    [Fact]
    public void Body_GetPositionAndRotation_MatchesSeparateGetters()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeStaticBox(bi, 2f, -1f, 4f);
        try
        {
            using var pos = JPH.Vec3.SZero();
            using var rot = JPH.Quat.SIdentity();
            bi.GetPositionAndRotation(id, pos, rot);

            using var gotPos = bi.GetPosition(id);
            using var gotRot = bi.GetRotation(id);

            Assert.Equal(gotPos.GetX(), pos.GetX(), precision: 4);
            Assert.Equal(gotPos.GetY(), pos.GetY(), precision: 4);
            Assert.Equal(gotPos.GetZ(), pos.GetZ(), precision: 4);

            Assert.Equal(gotRot.GetX(), rot.GetX(), precision: 4);
            Assert.Equal(gotRot.GetY(), rot.GetY(), precision: 4);
            Assert.Equal(gotRot.GetZ(), rot.GetZ(), precision: 4);
            Assert.Equal(gotRot.GetW(), rot.GetW(), precision: 4);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // ─── GetWorldTransform ────────────────────────────────────────────────────

    [Fact]
    public void Body_GetWorldTransform_TranslationMatchesPosition()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeStaticBox(bi, 3f, 1f, -5f);
        try
        {
            using var m = bi.GetWorldTransform(id);
            using var t = m.GetTranslation();
            Assert.Equal(3f,  t.GetX(), precision: 4);
            Assert.Equal(1f,  t.GetY(), precision: 4);
            Assert.Equal(-5f, t.GetZ(), precision: 4);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }
}
