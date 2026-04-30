using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_EmptyShape(JoltFixture fx)
{
    // ---------- EmptyShapeSettings ----------

    [Fact]
    public void EmptyShapeSettings_DefaultConstruct_NoCrash()
    {
        using var s = new JPH.EmptyShapeSettings();
        Assert.NotNull(s);
    }

    [Fact]
    public void EmptyShapeSettings_ConstructWithCoM_NoCrash()
    {
        using var com = new JPH.Vec3(1f, 2f, 3f);
        using var s   = new JPH.EmptyShapeSettings(com);
        Assert.NotNull(s);
    }

    [Fact]
    public void EmptyShapeSettings_mCenterOfMass_DefaultIsOrigin()
    {
        using var s   = new JPH.EmptyShapeSettings();
        var       com = s.mCenterOfMass;           // non-owning
        Assert.Equal(0f, com.GetX());
        Assert.Equal(0f, com.GetY());
        Assert.Equal(0f, com.GetZ());
    }

    [Fact]
    public void EmptyShapeSettings_mCenterOfMass_RoundTrip()
    {
        using var s = new JPH.EmptyShapeSettings();
        s.mCenterOfMass.Set(4f, 5f, 6f);
        var com = s.mCenterOfMass;
        Assert.Equal(4f, com.GetX());
        Assert.Equal(5f, com.GetY());
        Assert.Equal(6f, com.GetZ());
    }

    [Fact]
    public void EmptyShapeSettings_mUserData_DefaultIsZero()
    {
        using var s = new JPH.EmptyShapeSettings();
        Assert.Equal(UIntPtr.Zero, s.mUserData);
    }

    [Fact]
    public void EmptyShapeSettings_mUserData_RoundTrip()
    {
        using var s = new JPH.EmptyShapeSettings();
        s.mUserData = (UIntPtr)99u;
        Assert.Equal((UIntPtr)99u, s.mUserData);
    }

    // ---------- EmptyShape ----------

    [Fact]
    public void EmptyShape_DefaultConstruct_NoCrash()
    {
        using var shape = new JPH.EmptyShape();
        Assert.NotNull(shape);
    }

    [Fact]
    public void EmptyShape_ConstructWithCoM_GetCenterOfMassRoundTrip()
    {
        using var com   = new JPH.Vec3(7f, 8f, 9f);
        using var shape = new JPH.EmptyShape(com);
        using var got   = shape.GetCenterOfMass();
        Assert.Equal(7f, got.GetX());
        Assert.Equal(8f, got.GetY());
        Assert.Equal(9f, got.GetZ());
    }

    [Fact]
    public void EmptyShape_GetCenterOfMass_DefaultIsOrigin()
    {
        using var shape = new JPH.EmptyShape();
        using var com   = shape.GetCenterOfMass();
        Assert.Equal(0f, com.GetX());
        Assert.Equal(0f, com.GetY());
        Assert.Equal(0f, com.GetZ());
    }

    [Fact]
    public void EmptyShape_GetLocalBounds_IsZeroSize()
    {
        using var shape  = new JPH.EmptyShape();
        using var bounds = shape.GetLocalBounds();
        using var size   = bounds.GetSize();
        Assert.Equal(0f, size.GetX());
        Assert.Equal(0f, size.GetY());
        Assert.Equal(0f, size.GetZ());
    }

    [Fact]
    public void EmptyShape_GetInnerRadius_IsZero()
    {
        using var shape = new JPH.EmptyShape();
        Assert.Equal(0f, shape.GetInnerRadius());
    }

    [Fact]
    public void EmptyShape_GetVolume_IsZero()
    {
        using var shape = new JPH.EmptyShape();
        Assert.Equal(0f, shape.GetVolume());
    }

    [Fact]
    public void EmptyShape_MustBeStatic_IsFalse()
    {
        using var shape = new JPH.EmptyShape();
        Assert.False(shape.MustBeStatic());
    }

    [Fact]
    public void EmptyShape_SetUserData_GetUserDataRoundTrips()
    {
        using var shape = new JPH.EmptyShape();
        shape.SetUserData((UIntPtr)42u);
        Assert.Equal((UIntPtr)42u, shape.GetUserData());
    }

    [Fact]
    public void EmptyShape_StaticBody_CanBeCreated()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var settings = new JPH.EmptyShapeSettings();
        using var bcs      = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_EmptyShapeSettings)settings);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;

        var bodyId = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        Assert.False(bodyId.IsInvalid());

        bi.RemoveBody(bodyId);
        bi.DestroyBody(bodyId);
    }
}
