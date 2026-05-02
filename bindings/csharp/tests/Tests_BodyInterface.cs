// Tests for JPH::BodyInterface methods not yet covered by other test files:
//   - IsAdded (before and after AddBody)
//   - SetObjectLayer / GetObjectLayer
//   - GetMaxLinearVelocity / SetMaxLinearVelocity
//   - GetMaxAngularVelocity / SetMaxAngularVelocity
//   - GetUseManifoldReduction / SetUseManifoldReduction
//   - GetPointVelocity
//   - SetRotation
//   - GetCenterOfMassTransform
//   - GetMotionQuality
//   - CreateBodyWithoutID + AssignBodyID
//   - ResetSleepTimer

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_BodyInterface(JoltFixture fx)
{
    // Helper — creates a sphere dynamic body WITHOUT adding it to the simulation.
    static JPH.BodyID MakeDynamicSphereNotAdded(JPH.BodyInterface bi, float x, float y, float z)
    {
        using var ss = new JPH.SphereShapeSettings(0.5f);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(x, y, z);
        var body = bi.CreateBody(cs);
        return body!.GetID();
    }

    // Helper — creates and adds a dynamic sphere.
    static JPH.BodyID AddDynamicSphere(JPH.BodyInterface bi, float x, float y, float z)
    {
        using var ss = new JPH.SphereShapeSettings(0.5f);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(x, y, z);
        return bi.CreateAndAddBody(cs, JPH.EActivation.Activate);
    }

    // -------------------------------------------------------------------------
    // IsAdded
    // -------------------------------------------------------------------------

    [Fact]
    public void BI_IsAdded_BeforeAdd_ReturnsFalse()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamicSphereNotAdded(bi, 0f, 0f, 0f);

        Assert.False(bi.IsAdded(id));

        bi.DestroyBody(id);
    }

    [Fact]
    public void BI_IsAdded_AfterAdd_ReturnsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = MakeDynamicSphereNotAdded(bi, 0f, 0f, 0f);
        bi.AddBody(id, JPH.EActivation.Activate);

        Assert.True(bi.IsAdded(id));

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    // -------------------------------------------------------------------------
    // SetObjectLayer / GetObjectLayer
    // -------------------------------------------------------------------------

    [Fact]
    public void BI_SetObjectLayer_RoundTrips()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddDynamicSphere(bi, 0f, 0f, 0f);
        try
        {
            // Change layer and verify it is reflected
            bi.SetObjectLayer(id, JoltFixture.LayerNonMoving);
            Assert.Equal(JoltFixture.LayerNonMoving, bi.GetObjectLayer(id));
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // SetMaxLinearVelocity / GetMaxLinearVelocity
    // -------------------------------------------------------------------------

    [Fact]
    public void BI_GetMaxLinearVelocity_Default_IsPositive()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddDynamicSphere(bi, 0f, 0f, 0f);
        try
        {
            Assert.True(bi.GetMaxLinearVelocity(id) > 0f);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void BI_SetMaxLinearVelocity_RoundTrips()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddDynamicSphere(bi, 0f, 0f, 0f);
        try
        {
            bi.SetMaxLinearVelocity(id, 50f);
            Assert.Equal(50f, bi.GetMaxLinearVelocity(id), precision: 4);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // SetMaxAngularVelocity / GetMaxAngularVelocity
    // -------------------------------------------------------------------------

    [Fact]
    public void BI_GetMaxAngularVelocity_Default_IsPositive()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddDynamicSphere(bi, 0f, 0f, 0f);
        try
        {
            Assert.True(bi.GetMaxAngularVelocity(id) > 0f);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void BI_SetMaxAngularVelocity_RoundTrips()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddDynamicSphere(bi, 0f, 0f, 0f);
        try
        {
            bi.SetMaxAngularVelocity(id, 20f);
            Assert.Equal(20f, bi.GetMaxAngularVelocity(id), precision: 4);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // GetUseManifoldReduction / SetUseManifoldReduction
    // -------------------------------------------------------------------------

    [Fact]
    public void BI_GetUseManifoldReduction_DefaultIsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddDynamicSphere(bi, 0f, 0f, 0f);
        try
        {
            Assert.True(bi.GetUseManifoldReduction(id));
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    [Fact]
    public void BI_SetUseManifoldReduction_CanDisable()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddDynamicSphere(bi, 0f, 0f, 0f);
        try
        {
            bi.SetUseManifoldReduction(id, false);
            Assert.False(bi.GetUseManifoldReduction(id));
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // GetPointVelocity
    // -------------------------------------------------------------------------

    [Fact]
    public void BI_GetPointVelocity_StaticBody_IsZero()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();

        using var he = new JPH.Vec3(5f, 0.5f, 5f);
        using var ss = new JPH.BoxShapeSettings(he);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_BoxShapeSettings)ss);
        cs.mMotionType  = JPH.EMotionType.Static;
        cs.mObjectLayer = JoltFixture.LayerNonMoving;
        cs.mPosition.Set(0f, 0f, 0f);
        var id = bi.CreateAndAddBody(cs, JPH.EActivation.DontActivate);
        try
        {
            using var pt  = new JPH.Vec3(1f, 0f, 0f);
            using var vel = bi.GetPointVelocity(id, pt);
            Assert.Equal(0f, vel.GetX(), precision: 5);
            Assert.Equal(0f, vel.GetY(), precision: 5);
            Assert.Equal(0f, vel.GetZ(), precision: 5);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // SetRotation
    // -------------------------------------------------------------------------

    [Fact]
    public void BI_SetRotation_ChangesRotation()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddDynamicSphere(bi, 0f, 5f, 0f);
        try
        {
            // Rotate 90° around Y-axis: W = cos(45°) ≈ 0.7071
            using var yAxis  = new JPH.Vec3(0f, 1f, 0f);
            using var newRot = JPH.Quat.SRotation(yAxis, MathF.PI / 2f);
            bi.SetRotation(id, newRot, JPH.EActivation.DontActivate);

            using var gotRot = bi.GetRotation(id);
            Assert.Equal(MathF.Cos(MathF.PI / 4f), gotRot.GetW(), precision: 4);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // GetCenterOfMassTransform
    // -------------------------------------------------------------------------

    [Fact]
    public void BI_GetCenterOfMassTransform_TranslationMatchesPosition()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddDynamicSphere(bi, 3f, -2f, 7f);
        try
        {
            using var xf  = bi.GetCenterOfMassTransform(id);
            using var pos = xf.GetTranslation();
            Assert.Equal(3f,  pos.GetX(), precision: 3);
            Assert.Equal(-2f, pos.GetY(), precision: 3);
            Assert.Equal(7f,  pos.GetZ(), precision: 3);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // GetMotionQuality
    // -------------------------------------------------------------------------

    [Fact]
    public void BI_GetMotionQuality_Dynamic_IsDiscreteByDefault()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddDynamicSphere(bi, 0f, 0f, 0f);
        try
        {
            Assert.Equal(JPH.EMotionQuality.Discrete, bi.GetMotionQuality(id));
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // -------------------------------------------------------------------------
    // CreateBodyWithoutID + AssignBodyID
    // -------------------------------------------------------------------------

    [Fact]
    public void BI_CreateBodyWithoutID_AssignBodyID_CanBeAdded()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();

        using var ss = new JPH.SphereShapeSettings(0.5f);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 5f, 0f);

        var body = bi.CreateBodyWithoutID(cs);
        Assert.NotNull(body);

        bool assigned = bi.AssignBodyID(body);
        Assert.True(assigned);

        var id = body.GetID();
        bi.AddBody(id, JPH.EActivation.Activate);
        Assert.True(bi.IsAdded(id));

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    // -------------------------------------------------------------------------
    // ResetSleepTimer
    // -------------------------------------------------------------------------

    [Fact]
    public void BI_ResetSleepTimer_DoesNotThrow()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddDynamicSphere(bi, 0f, 0f, 0f);
        try
        {
            // No return value; just verify no crash
            bi.ResetSleepTimer(id);
        }
        finally { bi.RemoveBody(id); bi.DestroyBody(id); }
    }

    // =========================================================================
    // Batch array overloads (generated by --array-overload-param)
    // =========================================================================

    // -------------------------------------------------------------------------
    // AddBodiesPrepare (array) — returns non-null handle
    // -------------------------------------------------------------------------

    [Fact]
    public unsafe void BI_AddBodiesPrepare_Array_ReturnsNonNullHandle()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var ids = new JPH.BodyID[]
        {
            MakeDynamicSphereNotAdded(bi, 0f, 0f, 0f),
            MakeDynamicSphereNotAdded(bi, 2f, 0f, 0f),
        };

        void* addState = bi.AddBodiesPrepare(ids);
        Assert.True(addState != null);

        // Abort to keep the simulation clean, then destroy bodies.
        bi.AddBodiesAbort(ids, addState);
        bi.DestroyBodies(ids);
    }

    // -------------------------------------------------------------------------
    // AddBodiesFinalize (array) — bodies are added to the simulation
    // -------------------------------------------------------------------------

    [Fact]
    public unsafe void BI_AddBodiesFinalize_Array_BodiesAreAdded()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var ids = new JPH.BodyID[]
        {
            MakeDynamicSphereNotAdded(bi, 0f,  0f, 0f),
            MakeDynamicSphereNotAdded(bi, 2f,  0f, 0f),
            MakeDynamicSphereNotAdded(bi, 4f,  0f, 0f),
        };

        void* addState = bi.AddBodiesPrepare(ids);
        bi.AddBodiesFinalize(ids, addState, JPH.EActivation.Activate);

        foreach (var id in ids)
            Assert.True(bi.IsAdded(id));

        bi.RemoveBodies(ids);
        bi.DestroyBodies(ids);
    }

    // -------------------------------------------------------------------------
    // AddBodiesAbort (array) — bodies remain un-added
    // -------------------------------------------------------------------------

    [Fact]
    public unsafe void BI_AddBodiesAbort_Array_BodiesNotAdded()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var ids = new JPH.BodyID[]
        {
            MakeDynamicSphereNotAdded(bi, 0f, 0f, 0f),
            MakeDynamicSphereNotAdded(bi, 2f, 0f, 0f),
        };

        void* addState = bi.AddBodiesPrepare(ids);
        bi.AddBodiesAbort(ids, addState);

        foreach (var id in ids)
            Assert.False(bi.IsAdded(id));

        bi.DestroyBodies(ids);
    }

    // -------------------------------------------------------------------------
    // RemoveBodies (array) — bodies are removed from the simulation
    // -------------------------------------------------------------------------

    [Fact]
    public unsafe void BI_RemoveBodies_Array_BodiesNoLongerAdded()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var ids = new JPH.BodyID[]
        {
            AddDynamicSphere(bi, 0f, 0f, 0f),
            AddDynamicSphere(bi, 2f, 0f, 0f),
            AddDynamicSphere(bi, 4f, 0f, 0f),
        };

        foreach (var id in ids)
            Assert.True(bi.IsAdded(id));

        bi.RemoveBodies(ids);

        foreach (var id in ids)
            Assert.False(bi.IsAdded(id));

        bi.DestroyBodies(ids);
    }

    // -------------------------------------------------------------------------
    // DestroyBodies (array) — destroys multiple un-added bodies without crashing
    // -------------------------------------------------------------------------

    [Fact]
    public unsafe void BI_DestroyBodies_Array_NoCrash()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var ids = new JPH.BodyID[]
        {
            MakeDynamicSphereNotAdded(bi, 0f, 0f, 0f),
            MakeDynamicSphereNotAdded(bi, 2f, 0f, 0f),
            MakeDynamicSphereNotAdded(bi, 4f, 0f, 0f),
        };

        // Bodies must not be in the simulation when destroyed.
        bi.DestroyBodies(ids);
    }

    // -------------------------------------------------------------------------
    // UnassignBodyIDs (array) — unassigns multiple body IDs without crashing
    // -------------------------------------------------------------------------

    [Fact]
    public unsafe void BI_UnassignBodyIDs_Array_NoCrash()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var ids = new JPH.BodyID[]
        {
            MakeDynamicSphereNotAdded(bi, 0f, 0f, 0f),
            MakeDynamicSphereNotAdded(bi, 2f, 0f, 0f),
        };

        // Pass null for outBodies — Jolt handles this gracefully.
        // The Body objects are freed by BodyManager when PhysicsSystem is disposed.
        bi.UnassignBodyIDs(ids, (void**)null);
    }
}
