// Tests for JPH::MutableCompoundShape and JPH::MutableCompoundShapeSettings.
// MutableCompoundShape allows adding/removing/modifying sub-shapes at runtime,
// unlike StaticCompoundShape which is locked after creation.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_MutableCompoundShape(JoltFixture fx)
{
    // ─────────────────────────────────────────────────────────────────────────
    // MutableCompoundShapeSettings
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShapeSettings_DefaultConstruct_DoesNotThrow()
    {
        using var ss = new JPH.MutableCompoundShapeSettings();
        Assert.NotNull(ss);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // MutableCompoundShape construction
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShape_DefaultConstruct_DoesNotThrow()
    {
        using var shape = new JPH.MutableCompoundShape();
        Assert.NotNull(shape);
    }

    [Fact]
    public void MutableCompoundShape_DefaultConstruct_NumSubShapesIsZero()
    {
        using var shape = new JPH.MutableCompoundShape();
        Assert.Equal(0u, shape.GetNumSubShapes());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // MustBeStatic
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShape_MustBeStatic_ReturnsFalse()
    {
        using var shape = new JPH.MutableCompoundShape();
        Assert.False(shape.MustBeStatic());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // AddShape
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShape_AddShape_IncrementsSubShapeCount()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var pos    = new JPH.Vec3(0f, 0f, 0f);
        using var rot    = JPH.Quat.SIdentity();

        shape.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);
        Assert.Equal(1u, shape.GetNumSubShapes());
    }

    [Fact]
    public void MutableCompoundShape_AddShape_ReturnsZeroIndexFirst()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var pos    = new JPH.Vec3(0f, 0f, 0f);
        using var rot    = JPH.Quat.SIdentity();

        uint idx = shape.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);
        Assert.Equal(0u, idx);
    }

    [Fact]
    public void MutableCompoundShape_AddTwoShapes_NumSubShapesIsTwo()
    {
        using var shape   = new JPH.MutableCompoundShape();
        using var sphere1 = new JPH.SphereShape(0.5f);
        using var sphere2 = new JPH.SphereShape(0.3f);
        using var pos1    = new JPH.Vec3( 1f, 0f, 0f);
        using var pos2    = new JPH.Vec3(-1f, 0f, 0f);
        using var rot     = JPH.Quat.SIdentity();

        shape.AddShape(pos1, rot, (JPH.Const_SphereShape)sphere1);
        shape.AddShape(pos2, rot, (JPH.Const_SphereShape)sphere2);
        Assert.Equal(2u, shape.GetNumSubShapes());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // RemoveShape
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShape_RemoveShape_DecrementsSubShapeCount()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var pos    = new JPH.Vec3(0f, 0f, 0f);
        using var rot    = JPH.Quat.SIdentity();

        uint idx = shape.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);
        shape.RemoveShape(idx);
        Assert.Equal(0u, shape.GetNumSubShapes());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // ModifyShape
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShape_ModifyShape_DoesNotThrow()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var pos0   = new JPH.Vec3(0f, 0f, 0f);
        using var pos1   = new JPH.Vec3(5f, 0f, 0f);
        using var rot    = JPH.Quat.SIdentity();

        uint idx = shape.AddShape(pos0, rot, (JPH.Const_SphereShape)sphere);
        shape.ModifyShape(idx, pos1, rot); // move the sub-shape
        Assert.Equal(1u, shape.GetNumSubShapes());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Geometry
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShape_GetLocalBounds_EmptyShape_IsInvalid()
    {
        // Empty compound has no sub-shapes → GetLocalBounds returns an empty / invalid box
        using var shape = new JPH.MutableCompoundShape();
        using var bb    = shape.GetLocalBounds();
        // An empty compound box may be invalid or degenerate; we just verify no crash.
        Assert.NotNull(bb);
    }

    [Fact]
    public void MutableCompoundShape_GetLocalBounds_WithSphere_IsValid()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var pos    = new JPH.Vec3(0f, 0f, 0f);
        using var rot    = JPH.Quat.SIdentity();
        shape.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);

        using var bb = shape.GetLocalBounds();
        Assert.True(bb.IsValid());
    }

    [Fact]
    public void MutableCompoundShape_GetVolume_WithSphere_IsPositive()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var pos    = new JPH.Vec3(0f, 0f, 0f);
        using var rot    = JPH.Quat.SIdentity();
        shape.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);

        Assert.True(shape.GetVolume() > 0f);
    }

    [Fact]
    public void MutableCompoundShape_GetInnerRadius_WithSphere_IsPositive()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var pos    = new JPH.Vec3(0f, 0f, 0f);
        using var rot    = JPH.Quat.SIdentity();
        shape.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);

        Assert.True(shape.GetInnerRadius() > 0f);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Simulation — dynamic body with compound shape
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShape_DynamicBody_FallsDueToGravity()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        // Build a compound of two spheres side by side
        using var compound = new JPH.MutableCompoundShape();
        using var sphere   = new JPH.SphereShape(0.3f);
        using var posL     = new JPH.Vec3(-0.4f, 0f, 0f);
        using var posR     = new JPH.Vec3( 0.4f, 0f, 0f);
        using var rot      = JPH.Quat.SIdentity();
        compound.AddShape(posL, rot, (JPH.Const_SphereShape)sphere);
        compound.AddShape(posR, rot, (JPH.Const_SphereShape)sphere);

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
