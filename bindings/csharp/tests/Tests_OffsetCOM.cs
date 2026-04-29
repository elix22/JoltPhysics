// OffsetCenterOfMassShape tests, modelled on Jolt's OffsetCenterOfMassShapeTests.cpp.
// Covers shape geometry (center of mass, offset, volume) and body physics
// (angular impulse activation, linear/angular velocity after impulse).

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_OffsetCOM(JoltFixture fx)
{
    // Tolerance for approximate float equality.
    private const float Eps = 1e-4f;

    // ── Shape geometry ────────────────────────────────────────────────────────

    [Fact]
    public void OffsetCOM_ZeroOffset_GetCenterOfMassIsZero()
    {
        using var box   = new JPH.BoxShape(new JPH.Vec3(0.5f, 1f, 1.5f));
        using var shape = new JPH.OffsetCenterOfMassShape((JPH.Const_BoxShape)box, new JPH.Vec3(0f, 0f, 0f));
        using var com   = shape.GetCenterOfMass();
        Assert.Equal(0f, com.GetX(), precision: 6);
        Assert.Equal(0f, com.GetY(), precision: 6);
        Assert.Equal(0f, com.GetZ(), precision: 6);
    }

    [Fact]
    public void OffsetCOM_NonzeroOffset_GetCenterOfMassAtOffset()
    {
        using var box   = new JPH.BoxShape(new JPH.Vec3(0.5f, 1f, 1.5f));
        using var shape = new JPH.OffsetCenterOfMassShape((JPH.Const_BoxShape)box, new JPH.Vec3(1f, 2f, 3f));
        using var com   = shape.GetCenterOfMass();
        Assert.Equal(1f, com.GetX(), precision: 5);
        Assert.Equal(2f, com.GetY(), precision: 5);
        Assert.Equal(3f, com.GetZ(), precision: 5);
    }

    [Fact]
    public void OffsetCOM_GetOffset_MatchesConstructorArg()
    {
        using var box   = new JPH.BoxShape(new JPH.Vec3(1f, 1f, 1f));
        using var shape = new JPH.OffsetCenterOfMassShape((JPH.Const_BoxShape)box, new JPH.Vec3(5f, -3f, 2f));
        using var off   = shape.GetOffset();
        Assert.Equal(5f,  off.GetX(), precision: 5);
        Assert.Equal(-3f, off.GetY(), precision: 5);
        Assert.Equal(2f,  off.GetZ(), precision: 5);
    }

    [Fact]
    public void OffsetCOM_Volume_MatchesInnerBoxVolume()
    {
        // BoxShape volume = (2*hx)*(2*hy)*(2*hz) = 1*2*3 = 6
        using var box   = new JPH.BoxShape(new JPH.Vec3(0.5f, 1f, 1.5f));
        using var shape = new JPH.OffsetCenterOfMassShape((JPH.Const_BoxShape)box, new JPH.Vec3(5f, 0f, 0f));
        Assert.Equal(box.GetVolume(), shape.GetVolume(), precision: 4);
    }

    // ── Angular impulse on a body (COM offset = 0) ────────────────────────────

    private JPH.BodyID CreateOffsetCOMBody(JPH.BodyInterface bi, float offsetX)
    {
        using var boxSettings = new JPH.BoxShapeSettings(new JPH.Vec3(0.5f, 1f, 1.5f));
        using var comSettings = new JPH.OffsetCenterOfMassShapeSettings(
            new JPH.Vec3(offsetX, 0f, 0f),
            (JPH.Const_BoxShapeSettings)boxSettings);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_OffsetCenterOfMassShapeSettings)comSettings);
        cs.mMotionType  = JPH.EMotionType.Dynamic;
        cs.mObjectLayer = JoltFixture.LayerMoving;
        cs.mPosition.Set(0f, 0f, 0f);
        return bi.CreateAndAddBody(cs, JPH.EActivation.DontActivate);
    }

    [Fact]
    public void OffsetCOM_ZeroOffset_AddAngularImpulse_BodyBecomesActive()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();
        var id = CreateOffsetCOMBody(bi, 0f);

        Assert.False(bi.IsActive(id));
        bi.AddAngularImpulse(id, new JPH.Vec3(0f, 10000f, 0f));
        Assert.True(bi.IsActive(id));

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void OffsetCOM_ZeroOffset_AddAngularImpulse_LinearVelocityIsZero()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();
        var id = CreateOffsetCOMBody(bi, 0f);

        bi.AddAngularImpulse(id, new JPH.Vec3(0f, 10000f, 0f));

        using var linVel = bi.GetLinearVelocity(id);
        Assert.Equal(0f, linVel.GetX(), precision: 5);
        Assert.Equal(0f, linVel.GetY(), precision: 5);
        Assert.Equal(0f, linVel.GetZ(), precision: 5);

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void OffsetCOM_ZeroOffset_AddAngularImpulse_AngularVelocityMatchesExpected()
    {
        // Box half-extents (0.5, 1.0, 1.5), density 1000:
        //   volume = 1*2*3 = 6 m³,  mass = 6000 kg
        //   I_y = m/12 * ((2*hx)² + (2*hz)²) = 500 * (1 + 9) = 5000 kg·m²
        //   impulse = 10000 N·m·s  →  Δω_y = 10000 / 5000 = 2 rad/s
        const float impulseY = 10000f;
        const float inertiaY = 5000f;
        float expectedDv     = impulseY / inertiaY;

        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();
        var id = CreateOffsetCOMBody(bi, 0f);

        bi.AddAngularImpulse(id, new JPH.Vec3(0f, impulseY, 0f));

        using var angVel = bi.GetAngularVelocity(id);
        Assert.Equal(0f,        angVel.GetX(), precision: 3);
        Assert.Equal(expectedDv, angVel.GetY(), precision: 3);
        Assert.Equal(0f,        angVel.GetZ(), precision: 3);

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void OffsetCOM_WithCOMOffset_AddAngularImpulse_AngularVelocityMatchesParallelAxis()
    {
        // Same box, but COM offset +5 on X.
        // Parallel axis theorem: I_y_offset = I_y + m * d_x²
        //   = 5000 + 6000 * 25 = 155000 kg·m²
        //   Δω_y = 10000 / 155000 ≈ 0.06452 rad/s
        const float offsetX    = 5f;
        const float impulseY   = 10000f;
        const float inertiaY   = 5000f + 6000f * offsetX * offsetX;
        float expectedDv       = impulseY / inertiaY;

        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();
        var id = CreateOffsetCOMBody(bi, offsetX);

        bi.AddAngularImpulse(id, new JPH.Vec3(0f, impulseY, 0f));

        using var angVel = bi.GetAngularVelocity(id);
        Assert.Equal(0f,        angVel.GetX(), precision: 3);
        Assert.Equal(expectedDv, angVel.GetY(), precision: 3);
        Assert.Equal(0f,        angVel.GetZ(), precision: 3);

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void OffsetCOM_AddLinearImpulse_AngularVelocityIsZero()
    {
        // A linear impulse at the COM should not produce angular velocity.
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();
        var id = CreateOffsetCOMBody(bi, 0f);

        bi.AddImpulse(id, new JPH.Vec3(1000f, 0f, 0f));

        using var angVel = bi.GetAngularVelocity(id);
        Assert.Equal(0f, angVel.GetX(), precision: 5);
        Assert.Equal(0f, angVel.GetY(), precision: 5);
        Assert.Equal(0f, angVel.GetZ(), precision: 5);

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void OffsetCOM_AddLinearImpulse_LinearVelocityMatchesExpected()
    {
        // F = 6000 kg, impulse = 6000 N·s → Δv = 1 m/s (exactly)
        const float impulseX  = 6000f;   // mass * 1
        const float expectedVx = 1f;

        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();
        var id = CreateOffsetCOMBody(bi, 0f);

        bi.AddImpulse(id, new JPH.Vec3(impulseX, 0f, 0f));

        using var linVel = bi.GetLinearVelocity(id);
        Assert.Equal(expectedVx, linVel.GetX(), precision: 3);
        Assert.Equal(0f,         linVel.GetY(), precision: 5);
        Assert.Equal(0f,         linVel.GetZ(), precision: 5);

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }
}
