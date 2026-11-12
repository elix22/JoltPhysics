using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_StaticCompoundShape(JoltFixture fx)
{
    // ────────────────────────────────────────────────────────────────────────
    // StaticCompoundShapeSettings
    // ────────────────────────────────────────────────────────────────────────

    [Fact]
    public void StaticCompoundShapeSettings_DefaultConstruct_NoCrash()
    {
        using var s = new JPH.StaticCompoundShapeSettings();
        Assert.NotNull(s);
    }

    [Fact]
    public void StaticCompoundShapeSettings_mUserData_DefaultIsZero()
    {
        using var s = new JPH.StaticCompoundShapeSettings();
        Assert.Equal(UIntPtr.Zero, s.mUserData);
    }

    [Fact]
    public void StaticCompoundShapeSettings_mUserData_RoundTrip()
    {
        using var s = new JPH.StaticCompoundShapeSettings();
        s.mUserData = (UIntPtr)77u;
        Assert.Equal((UIntPtr)77u, s.mUserData);
    }

    [Fact]
    public void StaticCompoundShapeSettings_AddShape_NoCrash()
    {
        using var scs = new JPH.StaticCompoundShapeSettings();
        JPH.CompoundShapeSettings cs = scs;           // implicit non-owning upcast

        using var ss  = new JPH.SphereShapeSettings(0.5f);
        using var pos = new JPH.Vec3(0f, 0f, 0f);
        using var rot = JPH.Quat.SIdentity();
        cs.AddShape(pos, rot, (JPH.Const_SphereShapeSettings)ss);
        // no assertion needed — just verifying it doesn't crash
    }

    [Fact]
    public void StaticCompoundShapeSettings_AddTwoShapes_NoCrash()
    {
        using var scs = new JPH.StaticCompoundShapeSettings();
        JPH.CompoundShapeSettings cs = scs;

        using var ss  = new JPH.SphereShapeSettings(0.5f);
        using var rot = JPH.Quat.SIdentity();
        using var p1  = new JPH.Vec3(-1f, 0f, 0f);
        using var p2  = new JPH.Vec3( 1f, 0f, 0f);
        cs.AddShape(p1, rot, (JPH.Const_SphereShapeSettings)ss);
        cs.AddShape(p2, rot, (JPH.Const_SphereShapeSettings)ss);
        // two shapes added — no crash expected
    }

    // ────────────────────────────────────────────────────────────────────────
    // StaticCompoundShape (default-constructed, no sub-shapes)
    // ────────────────────────────────────────────────────────────────────────

    [Fact]
    public void StaticCompoundShape_DefaultConstruct_NoCrash()
    {
        using var shape = new JPH.StaticCompoundShape();
        Assert.NotNull(shape);
    }

    [Fact]
    public void StaticCompoundShape_DefaultConstruct_GetNumSubShapes_IsZero()
    {
        using var shape = new JPH.StaticCompoundShape();
        Assert.Equal(0u, shape.GetNumSubShapes());
    }

    [Fact]
    public void StaticCompoundShape_DefaultConstruct_GetLocalBounds_IsZeroSize()
    {
        using var shape  = new JPH.StaticCompoundShape();
        using var bounds = shape.GetLocalBounds();
        using var size   = bounds.GetSize();
        Assert.Equal(0f, size.GetX());
        Assert.Equal(0f, size.GetY());
        Assert.Equal(0f, size.GetZ());
    }

    [Fact]
    public void StaticCompoundShape_MustBeStatic_IsFalse()
    {
        using var shape = new JPH.StaticCompoundShape();
        Assert.False(shape.MustBeStatic());
    }

    // ────────────────────────────────────────────────────────────────────────
    // Static body creation via StaticCompoundShapeSettings
    // ────────────────────────────────────────────────────────────────────────

    [Fact]
    public void StaticCompoundShape_StaticBody_WithTwoSubShapes_IsValid()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var scs = new JPH.StaticCompoundShapeSettings();
        JPH.CompoundShapeSettings cs = scs;

        using var ss  = new JPH.SphereShapeSettings(0.5f);
        using var rot = JPH.Quat.SIdentity();
        using var p1  = new JPH.Vec3(-1f, 0f, 0f);
        using var p2  = new JPH.Vec3( 1f, 0f, 0f);
        cs.AddShape(p1, rot, (JPH.Const_SphereShapeSettings)ss);
        cs.AddShape(p2, rot, (JPH.Const_SphereShapeSettings)ss);

        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_StaticCompoundShapeSettings)scs);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;

        var bodyId = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        Assert.False(bodyId.IsInvalid());

        bi.RemoveBody(bodyId);
        bi.DestroyBody(bodyId);
    }

    [Fact]
    public void StaticCompoundShape_StaticBody_GetNumBodies_IncrementsAndDecrements()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        Assert.Equal(0u, sys.GetNumBodies());

        using var scs = new JPH.StaticCompoundShapeSettings();
        JPH.CompoundShapeSettings cs = scs;

        using var ss  = new JPH.SphereShapeSettings(0.5f);
        using var rot = JPH.Quat.SIdentity();
        using var pos = new JPH.Vec3(0f, 0f, 0f);
        cs.AddShape(pos, rot, (JPH.Const_SphereShapeSettings)ss);

        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_StaticCompoundShapeSettings)scs);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;

        var bodyId = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        Assert.Equal(1u, sys.GetNumBodies());

        bi.RemoveBody(bodyId);
        bi.DestroyBody(bodyId);
        Assert.Equal(0u, sys.GetNumBodies());
    }

    [Fact]
    public void StaticCompoundShape_StaticBody_GetShapeInnerRadius_MatchesSphere()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var scs = new JPH.StaticCompoundShapeSettings();
        JPH.CompoundShapeSettings cs = scs;

        using var ss  = new JPH.SphereShapeSettings(0.5f);
        using var rot = JPH.Quat.SIdentity();
        using var pos = new JPH.Vec3(0f, 0f, 0f);
        cs.AddShape(pos, rot, (JPH.Const_SphereShapeSettings)ss);

        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_StaticCompoundShapeSettings)scs);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;

        var body = bi.CreateBody(bcs);
        Assert.NotNull(body);
        var shape = body!.GetShape();
        Assert.NotNull(shape);
        Assert.Equal(0.5f, shape!.GetInnerRadius(), precision: 4);

        var bodyId = body.GetID();
        bi.DestroyBody(bodyId);
    }

    [Fact]
    public void StaticCompoundShape_StaticBody_GetShapeVolume_IsPositive()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var scs = new JPH.StaticCompoundShapeSettings();
        JPH.CompoundShapeSettings cs = scs;

        using var ss  = new JPH.SphereShapeSettings(0.5f);
        using var rot = JPH.Quat.SIdentity();
        using var pos = new JPH.Vec3(0f, 0f, 0f);
        cs.AddShape(pos, rot, (JPH.Const_SphereShapeSettings)ss);

        using var bcs = new JPH.BodyCreationSettings();
        bcs.SetShapeSettings((JPH.Const_StaticCompoundShapeSettings)scs);
        bcs.mMotionType  = JPH.EMotionType.Static;
        bcs.mObjectLayer = JoltFixture.LayerNonMoving;

        var body  = bi.CreateBody(bcs);
        var shape = body!.GetShape();
        Assert.True(shape!.GetVolume() > 0f);

        var bodyId = body.GetID();
        bi.DestroyBody(bodyId);
    }
}
