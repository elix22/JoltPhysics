// Tests focused on the intrinsic ref-counting lifecycle introduced by the
// --intrinsic-ref-counted-base flag.  The core invariant:
//
//   C# constructor  → AddRef  (count goes 0→1)
//   C# Dispose()    → Release (count goes 1→0 → Jolt deletes the object)

using Xunit;
//
// If AddRef/Release are mismatched the Jolt RefTarget destructor assertion
// fires (debug) or the process heap is corrupted (release).  These tests
// exercise the scenarios that were previously broken.

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_RefCounting(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // 1. Basic: construct and dispose a ShapeSettings subclass
    //    (was broken before --intrinsic-ref-counted-base: GC.SuppressFinalize
    //    was required manually)
    // -------------------------------------------------------------------------

    [Fact]
    public void ShapeSettings_DisposeCalledOnce_NoCrash()
    {
        var s = new JPH.SphereShapeSettings();
        s.mRadius = 1.0f;
        s.Dispose();   // explicit; second implicit call via finalizer must be a no-op
    }

    [Fact]
    public void ShapeSettings_UsingBlock_NoCrash()
    {
        using var s = new JPH.SphereShapeSettings();
        s.mRadius = 0.5f;
        // Dispose fires at end of block — must not double-free.
    }

    // -------------------------------------------------------------------------
    // 2. Shape settings handed to BodyCreationSettings (C++ takes a Ref<>).
    //    Without AddRef the shape could be deleted by the C# GC while the body
    //    creation settings still holds a live reference.
    // -------------------------------------------------------------------------

    [Fact]
    public void ShapeSettings_PassedToBodyCreationSettings_RemainsValid()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var ss = new JPH.SphereShapeSettings();
        ss.mRadius = 0.5f;

        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 5f, 0f);

        // The C++ side increments the ref-count when SetShapeSettings is called.
        // The C# 'ss' object holds its own ref.  Both must release cleanly.
        var id = bi.CreateAndAddBody(cs, JPH.EActivation.Activate);
        Assert.False(id.IsInvalid());

        bi.RemoveBody(id);
        bi.DestroyBody(id);
        // ss.Dispose() fires here — count goes from 1 to 0 → Jolt deletes it.
    }

    // -------------------------------------------------------------------------
    // 3. Same shape settings object reused for two bodies.
    //    The ref-count must correctly track both alive bodies.
    // -------------------------------------------------------------------------

    [Fact]
    public void ShapeSettings_SharedAcrossTwoBodies_RemainsValid()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var ss = new JPH.SphereShapeSettings();
        ss.mRadius = 0.3f;

        using var cs1 = new JPH.BodyCreationSettings();
        cs1.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        cs1.mMotionType  = JPH.EMotionType.Dynamic;
        cs1.mObjectLayer = JoltFixture.LayerMoving;
        cs1.mPosition.Set(-2f, 10f, 0f);

        using var cs2 = new JPH.BodyCreationSettings();
        cs2.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        cs2.mMotionType  = JPH.EMotionType.Dynamic;
        cs2.mObjectLayer = JoltFixture.LayerMoving;
        cs2.mPosition.Set(2f, 10f, 0f);

        var id1 = bi.CreateAndAddBody(cs1, JPH.EActivation.Activate);
        var id2 = bi.CreateAndAddBody(cs2, JPH.EActivation.Activate);

        Assert.False(id1.IsInvalid());
        Assert.False(id2.IsInvalid());

        bi.RemoveBody(id1); bi.DestroyBody(id1);
        bi.RemoveBody(id2); bi.DestroyBody(id2);
        // ss.Dispose() at end of using — should reach refcount 0 correctly.
    }

    // -------------------------------------------------------------------------
    // 4. ConstraintSettings ref-counting (different RefTarget instantiation).
    // -------------------------------------------------------------------------

    [Fact]
    public void ConstraintSettings_DisposeCalledExplicitly_NoCrash()
    {
        var cs = new JPH.FixedConstraintSettings();
        cs.Dispose();
    }

    [Fact]
    public void ConstraintSettings_UsingBlock_NoCrash()
    {
        using var cs = new JPH.HingeConstraintSettings();
        using var axis = new JPH.Vec3(0f, 1f, 0f);
        cs.mHingeAxis1.Set(0f, 1f, 0f);
        // Dispose fires at end of block.
    }

    // -------------------------------------------------------------------------
    // 5. Stress: allocate and dispose many shape settings objects rapidly.
    //    If the ref-count implementation races or double-frees, Jolt asserts.
    // -------------------------------------------------------------------------

    [Fact]
    public void ShapeSettings_AllocateDisposeStress_NoCorruption()
    {
        for (int i = 0; i < 500; i++)
        {
            using var box = new JPH.BoxShapeSettings(new JPH.Vec3(0.5f, 0.5f, 0.5f));
            using var sph = new JPH.SphereShapeSettings();
            sph.mRadius = 0.25f;
            using var cap = new JPH.CapsuleShapeSettings();
            cap.mRadius = 0.2f;
            cap.mHalfHeightOfCylinder = 0.4f;
        }
        Assert.True(true);
    }

    // -------------------------------------------------------------------------
    // 6. GC.Collect after dropping an unDisposed reference — the finalizer
    //    (via ~Const_XXXShapeSettings → Dispose(false)) must call Release once.
    // -------------------------------------------------------------------------

    [Fact]
    public void ShapeSettings_Finalized_NoCrash()
    {
        // Allocate without 'using' — let GC collect it.
        CreateAndForget();
        GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced, blocking: true);
        GC.WaitForPendingFinalizers();
        GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced, blocking: true);
        Assert.True(true);
    }

    [System.Runtime.CompilerServices.MethodImpl(
        System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
    private static void CreateAndForget()
    {
        var s = new JPH.BoxShapeSettings(new JPH.Vec3(1f, 1f, 1f));
        _ = s; // suppress unused-variable warning; s goes out of scope here
    }
}
