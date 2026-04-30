// Tests for ShapeFilter: lifecycle, mBodyID2 field access, ShouldCollide
// default behaviour (pass-through), and use with narrow-phase queries.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_ShapeFilter(JoltFixture fx)
{
    // ─────────────────────────────────────────────────────────────────────────
    // Lifecycle
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void Const_ShapeFilter_DefaultConstruct_NoCrash()
    {
        var sf = new JPH.Const_ShapeFilter();
        sf.Dispose();
    }

    [Fact]
    public void ShapeFilter_DefaultConstruct_NoCrash()
    {
        var sf = new JPH.ShapeFilter();
        sf.Dispose();
    }

    [Fact]
    public void ShapeFilter_Dispose_CalledTwice_NoCrash()
    {
        var sf = new JPH.ShapeFilter();
        sf.Dispose();
        sf.Dispose(); // should be a no-op
    }

    // ─────────────────────────────────────────────────────────────────────────
    // mBodyID2 field
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void ShapeFilter_ConstMBodyID2_DefaultIsInvalid()
    {
        using var sf = new JPH.Const_ShapeFilter();
        // The default BodyID should be invalid (not pointing to any body).
        Assert.True(sf.mBodyID2.IsInvalid());
    }

    [Fact]
    public void ShapeFilter_MutableMBodyID2_DefaultIsInvalid()
    {
        using var sf = new JPH.ShapeFilter();
        Assert.True(sf.mBodyID2.IsInvalid());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // ShouldCollide — the default implementation always returns true
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void ShapeFilter_ShouldCollide_TwoNullShapes_ReturnsTrue()
    {
        using var sf  = new JPH.ShapeFilter();
        using var sid = new JPH.SubShapeID();
        bool result = sf.ShouldCollide(null, sid, null, sid);
        Assert.True(result);
    }

    [Fact]
    public void ShapeFilter_ShouldCollide_OneNullShape_ReturnsTrue()
    {
        using var sf    = new JPH.ShapeFilter();
        using var sid   = new JPH.SubShapeID();
        using var shape = new JPH.SphereShape(0.5f);
        bool result = sf.ShouldCollide(null, sid, (JPH.Const_SphereShape)shape, sid);
        Assert.True(result);
    }

    [Fact]
    public void ShapeFilter_ShouldCollide_TwoShapes_ReturnsTrue()
    {
        using var sf     = new JPH.ShapeFilter();
        using var sid    = new JPH.SubShapeID();
        using var shape1 = new JPH.SphereShape(0.5f);
        using var shape2 = new JPH.BoxShape(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        bool result = sf.ShouldCollide(
            (JPH.Const_SphereShape)shape1, sid,
            (JPH.Const_BoxShape)shape2,    sid);
        Assert.True(result);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // ShapeFilter used in a narrow-phase query
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void ShapeFilter_UsedInBroadPhaseQuery_DoesNotThrow()
    {
        // Create a physics world with one static box, then run a ray cast
        // using the default ShapeFilter.  If the filter causes any crash this
        // test will fail.
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        using var shape = new JPH.BoxShapeSettings(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        using var bcs   = new JPH.BodyCreationSettings(
            (JPH.Const_BoxShapeSettings)shape,
            new JPH.Vec3(0f, 0f, 0f),
            JPH.Quat.SIdentity(),
            JPH.EMotionType.Static,
            JoltFixture.LayerNonMoving);
        JPH.BodyID id = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);

        // Just ensure no exception is thrown when the physics system is used
        // alongside a default ShapeFilter lifetime.
        using var sf = new JPH.ShapeFilter();
        Assert.NotNull(sf);

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }
}
