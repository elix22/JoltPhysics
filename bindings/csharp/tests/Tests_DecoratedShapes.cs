// Tests for JPH::RotatedTranslatedShape and JPH::ScaledShape (decorated shapes).
// Covers construction, geometry getters, and body creation with decorated shapes.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_DecoratedShapes(JoltFixture fx)
{
    // ─────────────────────────────────────────────────────────────────────────
    // RotatedTranslatedShape — construction
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void RotatedTranslatedShape_Construct_DoesNotThrow()
    {
        using var inner = new JPH.SphereShape(0.5f);
        using var pos   = new JPH.Vec3(1f, 2f, 3f);
        using var rot   = JPH.Quat.SIdentity();
        using var rts   = new JPH.RotatedTranslatedShape(pos, rot, (JPH.Const_SphereShape)inner);
        Assert.NotNull(rts);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // RotatedTranslatedShape — getters
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void RotatedTranslatedShape_GetPosition_MatchesInput()
    {
        using var inner = new JPH.SphereShape(0.5f);
        using var pos   = new JPH.Vec3(1f, 2f, 3f);
        using var rot   = JPH.Quat.SIdentity();
        using var rts   = new JPH.RotatedTranslatedShape(pos, rot, (JPH.Const_SphereShape)inner);
        using var got   = rts.GetPosition();
        Assert.Equal(1f, got.GetX(), precision: 5);
        Assert.Equal(2f, got.GetY(), precision: 5);
        Assert.Equal(3f, got.GetZ(), precision: 5);
    }

    [Fact]
    public void RotatedTranslatedShape_GetRotation_IdentityRotation_ComponentsMatch()
    {
        using var inner = new JPH.SphereShape(0.5f);
        using var pos   = new JPH.Vec3(0f, 0f, 0f);
        using var rot   = JPH.Quat.SIdentity();
        using var rts   = new JPH.RotatedTranslatedShape(pos, rot, (JPH.Const_SphereShape)inner);
        using var got   = rts.GetRotation();
        // Identity quaternion: (x=0, y=0, z=0, w=1)
        Assert.Equal(0f, got.GetX(), precision: 5);
        Assert.Equal(0f, got.GetY(), precision: 5);
        Assert.Equal(0f, got.GetZ(), precision: 5);
        Assert.Equal(1f, got.GetW(), precision: 5);
    }

    [Fact]
    public void RotatedTranslatedShape_GetLocalBounds_IsValid()
    {
        using var inner = new JPH.SphereShape(0.5f);
        using var pos   = new JPH.Vec3(2f, 0f, 0f);
        using var rot   = JPH.Quat.SIdentity();
        using var rts   = new JPH.RotatedTranslatedShape(pos, rot, (JPH.Const_SphereShape)inner);
        using var bb    = rts.GetLocalBounds();
        Assert.True(bb.IsValid());
    }

    [Fact]
    public void RotatedTranslatedShape_GetLocalBounds_SizeMatchesInnerShape()
    {
        // GetLocalBounds returns bounds in the RT-shape's own frame (centered at mPosition),
        // so the bounds size should equal the inner sphere's bounds size (2 * radius = 1.0).
        using var inner = new JPH.SphereShape(0.5f);
        using var pos   = new JPH.Vec3(5f, 0f, 0f);
        using var rot   = JPH.Quat.SIdentity();
        using var rts   = new JPH.RotatedTranslatedShape(pos, rot, (JPH.Const_SphereShape)inner);
        using var bb    = rts.GetLocalBounds();
        using var size  = bb.GetSize();
        Assert.Equal(1.0f, size.GetX(), precision: 3);
        Assert.Equal(1.0f, size.GetY(), precision: 3);
        Assert.Equal(1.0f, size.GetZ(), precision: 3);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // RotatedTranslatedShape — simulation
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void RotatedTranslatedShape_DynamicBody_FallsDueToGravity()
    {
        using var sys   = fx.MakePhysicsSystem();
        var bi          = sys.GetBodyInterface();

        using var inner = new JPH.SphereShapeSettings(0.5f);
        using var pos   = new JPH.Vec3(0f, 0f, 0f);
        using var rot   = JPH.Quat.SIdentity();
        using var rtss  = new JPH.RotatedTranslatedShapeSettings(
            pos, rot, (JPH.Const_SphereShapeSettings)inner);

        using var cs    = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_RotatedTranslatedShapeSettings)rtss);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 10f, 0f);
        var id = bi.CreateAndAddBody(cs, JPH.EActivation.Activate);

        for (int i = 0; i < 60; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        using var bodyPos = bi.GetCenterOfMassPosition(id);
        Assert.True(bodyPos.GetY() < 10f, $"Expected body to fall below y=10, got {bodyPos.GetY()}");

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // ScaledShape — construction
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void ScaledShape_Construct_DoesNotThrow()
    {
        using var inner = new JPH.SphereShape(0.5f);
        using var scale = new JPH.Vec3(2f, 2f, 2f);
        using var ss    = new JPH.ScaledShape((JPH.Const_SphereShape)inner, scale);
        Assert.NotNull(ss);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // ScaledShape — getters
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void ScaledShape_GetScale_MatchesInput()
    {
        using var inner = new JPH.SphereShape(0.5f);
        using var scale = new JPH.Vec3(2f, 3f, 4f);
        using var ss    = new JPH.ScaledShape((JPH.Const_SphereShape)inner, scale);
        using var got   = ss.GetScale();
        Assert.Equal(2f, got.GetX(), precision: 5);
        Assert.Equal(3f, got.GetY(), precision: 5);
        Assert.Equal(4f, got.GetZ(), precision: 5);
    }

    [Fact]
    public void ScaledShape_GetLocalBounds_IsValid()
    {
        using var inner = new JPH.SphereShape(0.5f);
        using var scale = new JPH.Vec3(2f, 2f, 2f);
        using var ss    = new JPH.ScaledShape((JPH.Const_SphereShape)inner, scale);
        using var bb    = ss.GetLocalBounds();
        Assert.True(bb.IsValid());
    }

    [Fact]
    public void ScaledShape_GetLocalBounds_LargerThanInnerShape()
    {
        // Inner sphere radius 0.5 → bounds [-0.5, 0.5] in each axis
        // Scaled by 3 → bounds [-1.5, 1.5] in each axis → size = 3.0
        using var inner   = new JPH.SphereShape(0.5f);
        using var scale   = new JPH.Vec3(3f, 3f, 3f);
        using var scaled  = new JPH.ScaledShape((JPH.Const_SphereShape)inner, scale);
        using var innerBB = inner.GetLocalBounds();
        using var scaledBB = scaled.GetLocalBounds();
        using var innerSize  = innerBB.GetSize();
        using var scaledSize = scaledBB.GetSize();
        Assert.True(scaledSize.GetX() > innerSize.GetX(),
            $"Scaled width {scaledSize.GetX()} should be > inner width {innerSize.GetX()}");
    }

    // ─────────────────────────────────────────────────────────────────────────
    // ScaledShape — simulation
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void ScaledShape_StaticBody_CreateAndAddBody_ReturnsValidId()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var innerSS = new JPH.SphereShapeSettings(1f);
        using var scale   = new JPH.Vec3(1f, 1f, 1f);
        using var scaledSS = new JPH.ScaledShapeSettings((JPH.Const_SphereShapeSettings)innerSS, scale);

        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_ScaledShapeSettings)scaledSS);
        cs.mMotionType  = JPH.EMotionType.Static;
        cs.mObjectLayer = JoltFixture.LayerNonMoving;
        cs.mPosition.Set(0f, 0f, 0f);
        var id = bi.CreateAndAddBody(cs, JPH.EActivation.DontActivate);

        Assert.False(id.IsInvalid());

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }
}
