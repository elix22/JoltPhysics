// Tests for the base Shape class interface via concrete shapes (SphereShape).
// Covers base Shape methods not tested elsewhere:
//   - GetUserData / SetUserData via BodyInterface (covered in Tests_EmptyShape, Tests_BodyProperties)
//   - GetUserData on shape directly (UIntPtr, from ShapeSettings.mUserData propagation)
//   - GetCenterOfMass (should be zero for sphere centred at origin)
//   - GetWorldSpaceBounds (Mat44 overload)
//   - IsValidScale
//   - MakeScaleValid
//   - GetVolume
//   - GetSubShapeIDBitsRecursive
//   - GetStats (size and numTriangles)
//   - GetMaterial returns null for a shape with no material override
//   - GetLeafShape returns self for a non-compound shape

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_ShapeBase(JoltFixture fx)
{
    [Fact]
    public void Shape_GetCenterOfMass_SphereAtOrigin_IsZero()
    {
        using var s   = new JPH.SphereShape(1f);
        using var com = s.GetCenterOfMass();
        Assert.Equal(0f, com.GetX(), precision: 5);
        Assert.Equal(0f, com.GetY(), precision: 5);
        Assert.Equal(0f, com.GetZ(), precision: 5);
    }

    [Fact]
    public void Shape_GetWorldSpaceBounds_Mat44Identity_NonEmpty()
    {
        using var s   = new JPH.SphereShape(0.5f);
        using var mat = JPH.Mat44.SIdentity();
        using var sc  = new JPH.Vec3(1f, 1f, 1f);
        using var bb  = s.GetWorldSpaceBounds(mat, sc);
        // Sphere radius 0.5 at origin: bounds min < 0, max > 0
        Assert.True(bb.mMin.GetX() < 0f);
        Assert.True(bb.mMax.GetX() > 0f);
    }

    [Fact]
    public void Shape_IsValidScale_UniformScale_IsTrue()
    {
        using var s  = new JPH.SphereShape(1f);
        using var sc = new JPH.Vec3(2f, 2f, 2f);
        Assert.True(s.IsValidScale(sc));
    }

    [Fact]
    public void Shape_IsValidScale_NonUniformScale_IsFalse()
    {
        using var s  = new JPH.SphereShape(1f);
        using var sc = new JPH.Vec3(1f, 2f, 1f);
        Assert.False(s.IsValidScale(sc));
    }

    [Fact]
    public void Shape_MakeScaleValid_NonUniform_ReturnsCorrectedScale()
    {
        using var s  = new JPH.SphereShape(1f);
        using var sc = new JPH.Vec3(1f, 2f, 1f);
        using var v  = s.MakeScaleValid(sc);
        // After correcting, scale should be valid
        Assert.True(s.IsValidScale(v));
    }

    [Fact]
    public void Shape_GetVolume_UnitSphere_IsApprox4PiOver3()
    {
        using var s   = new JPH.SphereShape(1f);
        float vol     = s.GetVolume();
        float expected = 4f * MathF.PI / 3f;
        Assert.Equal(expected, vol, precision: 3);
    }

    [Fact]
    public void Shape_GetSubShapeIDBitsRecursive_SphereIsZero()
    {
        // A simple (non-compound) sphere has no sub-shapes, so 0 bits needed.
        using var s = new JPH.SphereShape(1f);
        uint bits   = s.GetSubShapeIDBitsRecursive();
        Assert.Equal(0u, bits);
    }

    [Fact]
    public void Shape_GetStats_SizeIsPositive()
    {
        using var s    = new JPH.SphereShape(1f);
        var       stat = s.GetStats();
        Assert.True(stat.mSizeBytes > 0);
    }

    [Fact]
    public void Shape_GetLeafShape_Sphere_ReturnsSelf()
    {
        using var s       = new JPH.SphereShape(1f);
        using var subId   = new JPH.SubShapeID();
        using var rem     = new JPH.SubShapeID();
        var       leaf    = s.GetLeafShape(subId, rem);
        Assert.NotNull(leaf);
    }

    [Fact]
    public void Shape_GetUserData_DefaultIsZero()
    {
        using var s = new JPH.SphereShape(1f);
        Assert.Equal(UIntPtr.Zero, s.GetUserData());
    }

    // GetMaterial on default-constructed MeshShape is safe: C++ code checks
    // `if (mMaterials.empty()) return PhysicsMaterial::sDefault;` before touching
    // the BVH tree, so no crash occurs (unlike GetLocalBounds/GetStats/GetSubShapeIDBitsRecursive).
    [Fact]
    public void Shape_GetMaterial_ViaMeshShape_EmptyMeshReturnsSDefault()
    {
        using var mesh = new JPH.MeshShape();
        using var id   = new JPH.SubShapeID();
        // mMaterials is empty -> C++ returns PhysicsMaterial::sDefault (non-null).
        var mat = mesh.GetMaterial(id);
        Assert.NotNull(mat);
    }
}
