// Tests for JoltExtras.cs — the hand-written additions to the generated JPH bindings.
// Covers: Skeleton.AddJoint(string) overloads, ConvexHullShapeSettingsFromPoints, and
// ContactListenerTrampolineManaged.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_JoltExtras(JoltFixture fx)
{
    // ─────────────────────────────────────────────────────────────────────────
    // JoltExtensions.AddJoint(string) — Skeleton.AddJoint overloads
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void AddJoint_ByName_IncreasesJointCount()
    {
        using var s = new JPH.Skeleton();
        s.AddJoint("Root");
        Assert.Equal(1, s.GetJointCount());
    }

    [Fact]
    public void AddJoint_ByName_MultipleJoints_CountsCorrectly()
    {
        using var s = new JPH.Skeleton();
        s.AddJoint("Hip");
        s.AddJoint("Spine");
        s.AddJoint("Head");
        Assert.Equal(3, s.GetJointCount());
    }

    [Fact]
    public void AddJoint_ByName_ReturnsExpectedIndex()
    {
        using var s = new JPH.Skeleton();
        uint idx0 = s.AddJoint("Joint0");
        uint idx1 = s.AddJoint("Joint1");
        Assert.Equal(0u, idx0);
        Assert.Equal(1u, idx1);
    }

    [Fact]
    public void AddJoint_ByNameAndParentName_SetsParentCorrectly()
    {
        using var s = new JPH.Skeleton();
        s.AddJoint("Root");
        uint childIdx = s.AddJoint("Child", "Root");
        // AddJoint(name, parentName) stores the name but leaves mParentJointIndex = -1
        // until CalculateParentJointIndices() is called.
        s.CalculateParentJointIndices();
        using var joint = s.GetJoint((int)childIdx);
        Assert.Equal(0, joint.mParentJointIndex); // Root was index 0
    }

    [Fact]
    public void AddJoint_ByNameAndParentIndex_SetsParentCorrectly()
    {
        using var s = new JPH.Skeleton();
        s.AddJoint("Root");
        uint childIdx = s.AddJoint("Child", 0 /*parentIndex*/);
        using var joint = s.GetJoint((int)childIdx);
        Assert.Equal(0, joint.mParentJointIndex);
    }

    [Fact]
    public void AddJoint_AreJointsCorrectlyOrdered_AfterOrdering_ReturnsTrue()
    {
        // Build a simple parent-before-child hierarchy and verify ordering.
        using var s = new JPH.Skeleton();
        s.AddJoint("Root");          // index 0, no parent
        s.AddJoint("Spine", 0);      // index 1, parent=0
        s.AddJoint("Head",  1);      // index 2, parent=1
        Assert.True(s.AreJointsCorrectlyOrdered());
    }

    [Fact]
    public void AddJoint_EmptyName_DoesNotCrash()
    {
        using var s = new JPH.Skeleton();
        s.AddJoint("");  // empty string — null-terminator at byte 0
        Assert.Equal(1, s.GetJointCount());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // JPH.Vec3f
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void Vec3f_Constructor_SetsFields()
    {
        var v = new JPH.Vec3f(1f, 2f, 3f);
        Assert.Equal(1f, v.X);
        Assert.Equal(2f, v.Y);
        Assert.Equal(3f, v.Z);
    }

    [Fact]
    public void Vec3f_DefaultFields_AreZero()
    {
        var v = new JPH.Vec3f();
        Assert.Equal(0f, v.X);
        Assert.Equal(0f, v.Y);
        Assert.Equal(0f, v.Z);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // JPH.ConvexHullShapeSettingsFromPoints
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void ConvexHullShapeSettingsFromPoints_Tetrahedron_NoCrash()
    {
        var pts = new JPH.Vec3f[]
        {
            new(0f, 0f, 0f),
            new(1f, 0f, 0f),
            new(0f, 1f, 0f),
            new(0f, 0f, 1f),
        };
        using var settings = JPH.ConvexHullShapeSettingsFromPoints(pts);
        Assert.NotNull(settings);
    }

    [Fact]
    public void ConvexHullShapeSettingsFromPoints_MaxConvexRadiusRoundTrips()
    {
        var pts = new JPH.Vec3f[]
        {
            new(0f, 0f, 0f), new(1f, 0f, 0f),
            new(0f, 1f, 0f), new(0f, 0f, 1f),
        };
        using var settings = JPH.ConvexHullShapeSettingsFromPoints(pts, maxConvexRadius: 0.02f);
        Assert.Equal(0.02f, settings.mMaxConvexRadius, precision: 5);
    }

    [Fact]
    public void ConvexHullShapeSettingsFromPoints_CreateShape_Succeeds()
    {
        // A unit cube — 8 points, should form a valid convex hull.
        var pts = new JPH.Vec3f[]
        {
            new(0f,0f,0f), new(1f,0f,0f), new(0f,1f,0f), new(1f,1f,0f),
            new(0f,0f,1f), new(1f,0f,1f), new(0f,1f,1f), new(1f,1f,1f),
        };
        using var settings = JPH.ConvexHullShapeSettingsFromPoints(pts, maxConvexRadius: 0.0f);
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();
        using var bcs = new JPH.BodyCreationSettings(
            (JPH.Const_ConvexHullShapeSettings)settings,
            new JPH.Vec3(0f, 0f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);
        var body = bi.CreateBodyWithoutID(bcs);
        Assert.NotNull(body);
        bi.DestroyBodyWithoutID(body);
    }

    [Fact]
    public void ConvexHullShapeSettingsFromPoints_Shape_GetVolume_Positive()
    {
        var pts = new JPH.Vec3f[]
        {
            new(0f,0f,0f), new(1f,0f,0f), new(0f,1f,0f), new(0f,0f,1f),
        };
        using var settings = JPH.ConvexHullShapeSettingsFromPoints(pts, maxConvexRadius: 0.0f);
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();
        using var bcs = new JPH.BodyCreationSettings(
            (JPH.Const_ConvexHullShapeSettings)settings,
            new JPH.Vec3(0f, 0f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);
        var body = bi.CreateBodyWithoutID(bcs);
        Assert.NotNull(body);
        var shape = body!.GetShape();
        Assert.NotNull(shape);
        Assert.True(shape!.GetVolume() > 0f);
        bi.DestroyBodyWithoutID(body);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // JPH.ContactListenerTrampolineManaged
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void ContactListenerTrampolineManaged_Construct_NoCrash()
    {
        using var listener = new JPH.ContactListenerTrampolineManaged();
        Assert.NotNull(listener.Inner);
    }

    [Fact]
    public void ContactListenerTrampolineManaged_OnContactAdded_Invoked_OnCollision()
    {
        using var sys      = fx.MakePhysicsSystem();
        using var listener = new JPH.ContactListenerTrampolineManaged();
        int addedCount = 0;

        listener.SetOnContactAdded((body1, body2, manifold, settings) =>
        {
            addedCount++;
        });
        sys.SetContactListener(listener.Inner);

        var bi = sys.GetBodyInterface();
        using var floorShape = new JPH.BoxShapeSettings(new JPH.Vec3(50f, 0.5f, 50f));
        using var floorBcs   = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)floorShape,
            new JPH.Vec3(0f, -0.5f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);
        JPH.BodyID floorId = bi.CreateAndAddBody(floorBcs, JPH.EActivation.DontActivate);

        using var sphereShape = new JPH.SphereShapeSettings(0.5f);
        using var sphereBcs   = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)sphereShape,
            new JPH.Vec3(0f, 0.6f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);
        JPH.BodyID sphereId = bi.CreateAndAddBody(sphereBcs, JPH.EActivation.Activate);

        try
        {
            for (int i = 0; i < 10; i++)
                sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

            Assert.True(addedCount > 0, "OnContactAdded was never called");
        }
        finally
        {
            sys.SetContactListener(null);
            bi.RemoveBody(sphereId); bi.DestroyBody(sphereId);
            bi.RemoveBody(floorId);  bi.DestroyBody(floorId);
        }
    }

    [Fact]
    public void ContactListenerTrampolineManaged_OnContactAdded_BodyArgs_AreNonNull()
    {
        using var sys      = fx.MakePhysicsSystem();
        using var listener = new JPH.ContactListenerTrampolineManaged();
        JPH.BodyID? seenId1 = null;
        JPH.BodyID? seenId2 = null;

        listener.SetOnContactAdded((body1, body2, manifold, settings) =>
        {
            if (seenId1 == null)
            {
                seenId1 = body1.GetID();
                seenId2 = body2.GetID();
            }
        });
        sys.SetContactListener(listener.Inner);

        var bi = sys.GetBodyInterface();
        using var floorBcs = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)new JPH.BoxShapeSettings(new JPH.Vec3(50f, 0.5f, 50f)),
            new JPH.Vec3(0f, -0.5f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);
        JPH.BodyID floorId = bi.CreateAndAddBody(floorBcs, JPH.EActivation.DontActivate);

        using var sphereBcs = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)new JPH.SphereShapeSettings(0.5f),
            new JPH.Vec3(0f, 0.6f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);
        JPH.BodyID sphereId = bi.CreateAndAddBody(sphereBcs, JPH.EActivation.Activate);

        try
        {
            for (int i = 0; i < 10; i++)
                sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

            Assert.NotNull(seenId1);
            Assert.NotNull(seenId2);
            // The two IDs should be the floor and sphere we created.
            Assert.True(seenId1!.Value == floorId || seenId1.Value == sphereId);
            Assert.True(seenId2!.Value == floorId || seenId2.Value == sphereId);
            Assert.NotEqual(seenId1!.Value, seenId2!.Value);
        }
        finally
        {
            sys.SetContactListener(null);
            bi.RemoveBody(sphereId); bi.DestroyBody(sphereId);
            bi.RemoveBody(floorId);  bi.DestroyBody(floorId);
        }
    }

    [Fact]
    public void ContactListenerTrampolineManaged_OnContactValidate_CanAcceptOrReject()
    {
        using var sys      = fx.MakePhysicsSystem();
        using var listener = new JPH.ContactListenerTrampolineManaged();
        int validateCount = 0;

        listener.SetOnContactValidate((body1, body2, baseOffset, result) =>
        {
            validateCount++;
            return JPH.ValidateResult.AcceptAllContactsForThisBodyPair;
        });
        sys.SetContactListener(listener.Inner);

        var bi = sys.GetBodyInterface();
        using var floorBcs = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)new JPH.BoxShapeSettings(new JPH.Vec3(50f, 0.5f, 50f)),
            new JPH.Vec3(0f, -0.5f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);
        JPH.BodyID floorId = bi.CreateAndAddBody(floorBcs, JPH.EActivation.DontActivate);

        using var sphereBcs = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)new JPH.SphereShapeSettings(0.5f),
            new JPH.Vec3(0f, 0.6f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);
        JPH.BodyID sphereId = bi.CreateAndAddBody(sphereBcs, JPH.EActivation.Activate);

        try
        {
            for (int i = 0; i < 10; i++)
                sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

            Assert.True(validateCount > 0, "OnContactValidate was never called");
        }
        finally
        {
            sys.SetContactListener(null);
            bi.RemoveBody(sphereId); bi.DestroyBody(sphereId);
            bi.RemoveBody(floorId);  bi.DestroyBody(floorId);
        }
    }

    [Fact]
    public void ContactListenerTrampolineManaged_OnContactRemoved_CalledAfterBodyRemoved()
    {
        using var sys      = fx.MakePhysicsSystem();
        using var listener = new JPH.ContactListenerTrampolineManaged();
        int removedCount = 0;

        listener.SetOnContactRemoved(pair => { removedCount++; });
        sys.SetContactListener(listener.Inner);

        var bi = sys.GetBodyInterface();
        using var floorBcs = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)new JPH.BoxShapeSettings(new JPH.Vec3(50f, 0.5f, 50f)),
            new JPH.Vec3(0f, -0.5f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);
        JPH.BodyID floorId = bi.CreateAndAddBody(floorBcs, JPH.EActivation.DontActivate);

        using var sphereBcs = new JPH.BodyCreationSettings(
            (JPH.Const_SphereShapeSettings)new JPH.SphereShapeSettings(0.5f),
            new JPH.Vec3(0f, 0.6f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Dynamic, JoltFixture.LayerMoving);
        JPH.BodyID sphereId = bi.CreateAndAddBody(sphereBcs, JPH.EActivation.Activate);

        // Step until contact is established.
        for (int i = 0; i < 10; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        bi.RemoveBody(sphereId); bi.DestroyBody(sphereId);
        sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);
        bi.RemoveBody(floorId);  bi.DestroyBody(floorId);

        sys.SetContactListener(null);

        Assert.True(removedCount > 0, "OnContactRemoved was never called");
    }

    [Fact]
    public void ContactListenerTrampolineManaged_Dispose_DoesNotCrash()
    {
        var listener = new JPH.ContactListenerTrampolineManaged();
        int count = 0;
        listener.SetOnContactAdded((b1, b2, m, s) => { count++; });
        listener.Dispose(); // should free GCHandles and dispose Inner without crashing
        Assert.Equal(0, count);
    }
}
