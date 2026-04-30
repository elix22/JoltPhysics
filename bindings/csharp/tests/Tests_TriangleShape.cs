// Tests for JPH::TriangleShape and JPH::TriangleShapeSettings.
// Note: TriangleShape::MustBeStatic() returns false — it is a convex shape and
// can be used with both static and dynamic bodies.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_TriangleShape(JoltFixture fx)
{
    // Helpers — a flat triangle in the XZ plane
    static JPH.Vec3 V1() => new JPH.Vec3(-1f, 0f,  0f);
    static JPH.Vec3 V2() => new JPH.Vec3( 1f, 0f,  0f);
    static JPH.Vec3 V3() => new JPH.Vec3( 0f, 0f,  1f);

    // ─────────────────────────────────────────────────────────────────────────
    // TriangleShapeSettings
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TriangleShapeSettings_DefaultConstruct_DoesNotThrow()
    {
        using var ss = new JPH.TriangleShapeSettings();
        Assert.NotNull(ss);
    }

    [Fact]
    public void TriangleShapeSettings_ParameterizedConstruct_DoesNotThrow()
    {
        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var ss = new JPH.TriangleShapeSettings(v1, v2, v3);
        Assert.NotNull(ss);
    }

    [Fact]
    public void TriangleShapeSettings_mV1_MatchesInput()
    {
        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var ss = new JPH.TriangleShapeSettings(v1, v2, v3);
        Assert.Equal(-1f, ss.mv1.GetX(), precision: 5);
        Assert.Equal( 0f, ss.mv1.GetY(), precision: 5);
        Assert.Equal( 0f, ss.mv1.GetZ(), precision: 5);
    }

    [Fact]
    public void TriangleShapeSettings_mV2_MatchesInput()
    {
        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var ss = new JPH.TriangleShapeSettings(v1, v2, v3);
        Assert.Equal(1f, ss.mv2.GetX(), precision: 5);
        Assert.Equal(0f, ss.mv2.GetY(), precision: 5);
        Assert.Equal(0f, ss.mv2.GetZ(), precision: 5);
    }

    [Fact]
    public void TriangleShapeSettings_mV3_MatchesInput()
    {
        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var ss = new JPH.TriangleShapeSettings(v1, v2, v3);
        Assert.Equal(0f, ss.mv3.GetX(), precision: 5);
        Assert.Equal(0f, ss.mv3.GetY(), precision: 5);
        Assert.Equal(1f, ss.mv3.GetZ(), precision: 5);
    }

    [Fact]
    public void TriangleShapeSettings_mConvexRadius_IsNonNegative()
    {
        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var ss = new JPH.TriangleShapeSettings(v1, v2, v3);
        Assert.True(ss.mConvexRadius >= 0f);
    }

    [Fact]
    public void TriangleShapeSettings_mDensity_Default_Is1000()
    {
        using var ss = new JPH.TriangleShapeSettings();
        Assert.Equal(1000f, ss.mDensity, precision: 3);
    }

    [Fact]
    public void TriangleShapeSettings_SetDensity_UpdatesmDensity()
    {
        using var ss = new JPH.TriangleShapeSettings();
        ss.SetDensity(750f);
        Assert.Equal(750f, ss.mDensity, precision: 3);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // TriangleShape construction
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TriangleShape_DirectConstruct_DoesNotThrow()
    {
        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        Assert.NotNull(shape);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // MustBeStatic
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TriangleShape_MustBeStatic_ReturnsFalse()
    {
        // TriangleShape is a convex shape and does NOT require static motion.
        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        Assert.False(shape.MustBeStatic());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Geometry
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TriangleShape_GetLocalBounds_IsValid()
    {
        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        using var bb = shape.GetLocalBounds();
        Assert.True(bb.IsValid());
    }

    [Fact]
    public void TriangleShape_GetLocalBounds_SpansXAxis()
    {
        // v1=-1 and v2=+1 on X → width >= 2
        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        using var bb   = shape.GetLocalBounds();
        using var size = bb.GetSize();
        Assert.True(size.GetX() >= 2f, $"X span should be >= 2 but got {size.GetX()}");
    }

    [Fact]
    public void TriangleShape_GetInnerRadius_IsNonNegative()
    {
        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        Assert.True(shape.GetInnerRadius() >= 0f);
    }

    [Fact]
    public void TriangleShape_GetVolume_IsZero()
    {
        // A triangle is 2-D; its volume is 0.
        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        Assert.Equal(0f, shape.GetVolume(), precision: 6);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Density
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TriangleShape_GetDensity_Default_Is1000()
    {
        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        Assert.Equal(1000f, shape.GetDensity(), precision: 3);
    }

    [Fact]
    public void TriangleShape_SetDensity_RoundTrips()
    {
        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var shape = new JPH.TriangleShape(v1, v2, v3);
        shape.SetDensity(500f);
        Assert.Equal(500f, shape.GetDensity(), precision: 3);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Body creation
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void TriangleShape_StaticBody_CanBeCreated()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var bcs = new JPH.BodyCreationSettings();
        using var ss  = new JPH.TriangleShapeSettings(v1, v2, v3);
        bcs.SetShapeSettings((JPH.Const_TriangleShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;
        bcs.mPosition.Set(0f, 0f, 0f);

        var id = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        Assert.True(id.IsInvalid() == false);
        Assert.Equal(1u, sys.GetNumBodies());

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void TriangleShape_DynamicBody_CanBeCreated()
    {
        // TriangleShape is convex (MustBeStatic=false), so it is legal to create
        // a dynamic body with it. We verify creation succeeds without simulating
        // (a zero-volume flat triangle is numerically degenerate under dynamics).
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var v1 = V1(); using var v2 = V2(); using var v3 = V3();
        using var bcs = new JPH.BodyCreationSettings();
        using var ss  = new JPH.TriangleShapeSettings(v1, v2, v3);
        bcs.SetShapeSettings((JPH.Const_TriangleShapeSettings)ss);
        bcs.mMotionType  = JPH.EMotionType.Dynamic;
        bcs.mObjectLayer = JoltFixture.LayerMoving;
        bcs.mPosition.Set(0f, 10f, 0f);

        var id = bi.CreateAndAddBody(bcs, JPH.EActivation.Activate);
        Assert.True(id.IsInvalid() == false);

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void TriangleShape_InCompound_DynamicBody_FallsDueToGravity()
    {
        // A bare TriangleShape has zero volume so Jolt cannot compute a valid
        // inertia tensor for it as a dynamic body.  Wrapping it alongside a
        // sphere in a MutableCompoundShape gives the body a well-defined inertia
        // tensor and makes the gravity test numerically stable.
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var v1       = V1(); using var v2 = V2(); using var v3 = V3();
        using var tri      = new JPH.TriangleShape(v1, v2, v3);
        using var sphere   = new JPH.SphereShape(0.3f);
        using var compound = new JPH.MutableCompoundShape();
        using var origin   = new JPH.Vec3(0f, 0f, 0f);
        using var rot      = JPH.Quat.SIdentity();
        compound.AddShape(origin, rot, (JPH.Const_TriangleShape)tri);
        compound.AddShape(origin, rot, (JPH.Const_SphereShape)sphere);

        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShape((JPH.Const_MutableCompoundShape)compound);
        bcs.mMotionType  = JPH.EMotionType.Dynamic;
        bcs.mObjectLayer = JoltFixture.LayerMoving;
        bcs.mPosition.Set(0f, 10f, 0f);

        var id = bi.CreateAndAddBody(bcs, JPH.EActivation.Activate);

        for (int i = 0; i < 60; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        using var pos = bi.GetCenterOfMassPosition(id);
        Assert.True(pos.GetY() < 10f, $"Expected body to fall below y=10, got {pos.GetY()}");

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }
}
