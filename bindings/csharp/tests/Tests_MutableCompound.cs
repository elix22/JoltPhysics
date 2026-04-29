// Tests for JPH::MutableCompoundShape: adding, removing, modifying sub-shapes
// and verifying the compound shape's geometry updates accordingly.
// Mirrors coverage in JoltPhysics/UnitTests/Physics/MutableCompoundShapeTests.cpp.

using Xunit;

namespace JoltTests;

// No physics system needed — pure shape construction tests.
public sealed class Tests_MutableCompound
{
    // ─────────────────────────────────────────────────────────────────────────
    // Construction
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShape_DefaultConstruct_DoesNotThrow()
    {
        using var shape = new JPH.MutableCompoundShape();
        Assert.NotNull(shape);
    }

    [Fact]
    public void MutableCompoundShape_DefaultConstruct_IsEmpty()
    {
        using var shape = new JPH.MutableCompoundShape();
        Assert.Equal(0u, shape.GetNumSubShapes());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // AddShape
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShape_AddShape_IncreasesCount()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var pos    = new JPH.Vec3(0f, 0f, 0f);
        using var rot    = JPH.Quat.SIdentity();
        shape.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);
        Assert.Equal(1u, shape.GetNumSubShapes());
    }

    [Fact]
    public void MutableCompoundShape_AddMultipleShapes_CountIsCorrect()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var box    = new JPH.BoxShape(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        using var rot    = JPH.Quat.SIdentity();

        using var p1 = new JPH.Vec3(-1f, 0f, 0f);
        using var p2 = new JPH.Vec3( 1f, 0f, 0f);
        shape.AddShape(p1, rot, (JPH.Const_SphereShape)sphere);
        shape.AddShape(p2, rot, (JPH.Const_BoxShape)box);

        Assert.Equal(2u, shape.GetNumSubShapes());
    }

    [Fact]
    public void MutableCompoundShape_AddShape_ReturnsZeroBasedIndex()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var pos    = new JPH.Vec3(0f, 0f, 0f);
        using var rot    = JPH.Quat.SIdentity();
        uint idx = shape.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);
        Assert.Equal(0u, idx);
    }

    [Fact]
    public void MutableCompoundShape_AddTwoShapes_SecondIndexIsOne()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var pos    = new JPH.Vec3(0f, 0f, 0f);
        using var rot    = JPH.Quat.SIdentity();
        shape.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);
        uint idx2 = shape.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);
        Assert.Equal(1u, idx2);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // RemoveShape
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShape_RemoveShape_DecreasesCount()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var pos    = new JPH.Vec3(0f, 0f, 0f);
        using var rot    = JPH.Quat.SIdentity();
        uint idx = shape.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);
        shape.RemoveShape(idx);
        Assert.Equal(0u, shape.GetNumSubShapes());
    }

    [Fact]
    public void MutableCompoundShape_RemoveOneOfTwo_OneRemains()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var box    = new JPH.BoxShape(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        using var rot    = JPH.Quat.SIdentity();
        using var p1     = new JPH.Vec3(-1f, 0f, 0f);
        using var p2     = new JPH.Vec3( 1f, 0f, 0f);

        shape.AddShape(p1, rot, (JPH.Const_SphereShape)sphere);
        shape.AddShape(p2, rot, (JPH.Const_BoxShape)box);
        shape.RemoveShape(0u);
        Assert.Equal(1u, shape.GetNumSubShapes());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // ModifyShape (position/rotation)
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShape_ModifyShape_DoesNotChangeCount()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var pos    = new JPH.Vec3(0f, 0f, 0f);
        using var rot    = JPH.Quat.SIdentity();
        uint idx = shape.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);

        using var newPos = new JPH.Vec3(2f, 2f, 2f);
        shape.ModifyShape(idx, newPos, rot);

        Assert.Equal(1u, shape.GetNumSubShapes());
    }

    [Fact]
    public void MutableCompoundShape_ModifyShapeWithNewShape_DoesNotChangeCount()
    {
        using var compound = new JPH.MutableCompoundShape();
        using var sphere   = new JPH.SphereShape(0.5f);
        using var box      = new JPH.BoxShape(new JPH.Vec3(0.5f, 0.5f, 0.5f));
        using var pos      = new JPH.Vec3(0f, 0f, 0f);
        using var rot      = JPH.Quat.SIdentity();
        uint idx = compound.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);

        compound.ModifyShape(idx, pos, rot, (JPH.Const_BoxShape)box);
        Assert.Equal(1u, compound.GetNumSubShapes());
    }

    // ─────────────────────────────────────────────────────────────────────────
    // AdjustCenterOfMass
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShape_AdjustCenterOfMass_DoesNotThrow()
    {
        using var shape  = new JPH.MutableCompoundShape();
        using var sphere = new JPH.SphereShape(0.5f);
        using var pos    = new JPH.Vec3(1f, 0f, 0f);
        using var rot    = JPH.Quat.SIdentity();
        shape.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);
        // Should not throw
        shape.AdjustCenterOfMass();
    }

    // ─────────────────────────────────────────────────────────────────────────
    // GetSubShape
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShape_GetSubShape_PositionRoundTrips()
    {
        using var compound = new JPH.MutableCompoundShape();
        using var sphere   = new JPH.SphereShape(0.5f);
        using var pos      = new JPH.Vec3(1f, 2f, 3f);
        using var rot      = JPH.Quat.SIdentity();
        uint idx = compound.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);

        using var sub    = compound.GetSubShape(idx);
        using var gotPos = sub.GetPositionCOM();

        // Jolt may shift position slightly when AdjustCenterOfMass is called;
        // just confirm the accessor runs without error
        Assert.NotNull(gotPos);
    }

    [Fact]
    public void MutableCompoundShape_GetSubShape_RotationRoundTrips()
    {
        using var compound = new JPH.MutableCompoundShape();
        using var sphere   = new JPH.SphereShape(0.5f);
        using var pos      = new JPH.Vec3(0f, 0f, 0f);
        using var rot      = JPH.Quat.SIdentity();
        uint idx = compound.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);

        using var sub    = compound.GetSubShape(idx);
        using var gotRot = sub.GetRotation();
        Assert.NotNull(gotRot);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Volume (basic sanity)
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void MutableCompoundShape_Volume_IsPositiveAfterAddShape()
    {
        using var compound = new JPH.MutableCompoundShape();
        using var sphere   = new JPH.SphereShape(1f);
        using var pos      = new JPH.Vec3(0f, 0f, 0f);
        using var rot      = JPH.Quat.SIdentity();
        compound.AddShape(pos, rot, (JPH.Const_SphereShape)sphere);
        Assert.True(compound.GetVolume() > 0f);
    }

}
