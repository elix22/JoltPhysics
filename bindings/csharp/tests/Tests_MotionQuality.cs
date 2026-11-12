// Tests for EMotionQuality:
// enum values, BodyCreationSettings.mMotionQuality default,
// BodyInterface.GetMotionQuality/SetMotionQuality round-trip.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_MotionQuality(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // Helper: create a dynamic sphere body
    // -------------------------------------------------------------------------

    private static (JPH.Body body, JPH.BodyID id) MakeSphere(
        JPH.BodyInterface bi,
        float x, float y, float z,
        JPH.EMotionQuality quality = JPH.EMotionQuality.Discrete)
    {
        using var ss = new JPH.SphereShapeSettings(0.5f);
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_SphereShapeSettings)ss);
        cs.mMotionType    = JPH.EMotionType.Dynamic;
        cs.mObjectLayer   = JoltFixture.LayerMoving;
        cs.mMotionQuality = quality;
        cs.mPosition.Set(x, y, z);
        var body = bi.CreateBody(cs)!;
        var id   = body.GetID();
        bi.AddBody(id, JPH.EActivation.Activate);
        return (body, id);
    }

    // -------------------------------------------------------------------------
    // EMotionQuality enum
    // -------------------------------------------------------------------------

    [Fact]
    public void EMotionQuality_Discrete_ValueIsZero()
    {
        Assert.Equal((byte)0, (byte)JPH.EMotionQuality.Discrete);
    }

    [Fact]
    public void EMotionQuality_LinearCast_ValueIsOne()
    {
        Assert.Equal((byte)1, (byte)JPH.EMotionQuality.LinearCast);
    }

    // -------------------------------------------------------------------------
    // BodyCreationSettings.mMotionQuality
    // -------------------------------------------------------------------------

    [Fact]
    public void BodyCreationSettings_MMotionQuality_DefaultIsDiscrete()
    {
        using var cs = new JPH.BodyCreationSettings();
        Assert.Equal(JPH.EMotionQuality.Discrete, cs.mMotionQuality);
    }

    [Fact]
    public void BodyCreationSettings_MMotionQuality_CanBeSetToLinearCast()
    {
        using var cs = new JPH.BodyCreationSettings();
        cs.mMotionQuality = JPH.EMotionQuality.LinearCast;
        Assert.Equal(JPH.EMotionQuality.LinearCast, cs.mMotionQuality);
    }

    [Fact]
    public void BodyCreationSettings_MMotionQuality_RoundTrips()
    {
        using var cs = new JPH.BodyCreationSettings();
        cs.mMotionQuality = JPH.EMotionQuality.Discrete;
        Assert.Equal(JPH.EMotionQuality.Discrete, cs.mMotionQuality);
    }

    // -------------------------------------------------------------------------
    // BodyInterface.GetMotionQuality / SetMotionQuality
    // -------------------------------------------------------------------------

    [Fact]
    public void BodyInterface_GetMotionQuality_DiscreteBody_ReturnsDiscrete()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (_, id) = MakeSphere(bi, 0f, 5f, 0f, JPH.EMotionQuality.Discrete);
        Assert.Equal(JPH.EMotionQuality.Discrete, bi.GetMotionQuality(id));

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    [Fact]
    public void BodyInterface_GetMotionQuality_LinearCastBody_ReturnsLinearCast()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (_, id) = MakeSphere(bi, 0f, 5f, 0f, JPH.EMotionQuality.LinearCast);
        Assert.Equal(JPH.EMotionQuality.LinearCast, bi.GetMotionQuality(id));

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    [Fact]
    public void BodyInterface_SetMotionQuality_ChangesQuality()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (_, id) = MakeSphere(bi, 0f, 5f, 0f, JPH.EMotionQuality.Discrete);
        Assert.Equal(JPH.EMotionQuality.Discrete, bi.GetMotionQuality(id));

        bi.SetMotionQuality(id, JPH.EMotionQuality.LinearCast);
        Assert.Equal(JPH.EMotionQuality.LinearCast, bi.GetMotionQuality(id));

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    [Fact]
    public void BodyInterface_SetMotionQuality_RoundTrip_BackToDiscrete()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        var (_, id) = MakeSphere(bi, 0f, 5f, 0f, JPH.EMotionQuality.LinearCast);
        bi.SetMotionQuality(id, JPH.EMotionQuality.Discrete);
        Assert.Equal(JPH.EMotionQuality.Discrete, bi.GetMotionQuality(id));

        bi.RemoveBody(id); bi.DestroyBody(id);
    }

    // -------------------------------------------------------------------------
    // Simulation: LinearCast body does not crash
    // -------------------------------------------------------------------------

    [Fact]
    public void BodyInterface_LinearCastBody_SimulatesWithoutCrash()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();
        sys.OptimizeBroadPhase();

        var (_, id) = MakeSphere(bi, 0f, 10f, 0f, JPH.EMotionQuality.LinearCast);

        for (int i = 0; i < 60; i++)
            sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

        float y;
        using (var p = bi.GetCenterOfMassPosition(id)) y = p.GetY();
        // Should have fallen under gravity.
        Assert.True(y < 10f, $"Body didn't fall: y={y}");

        bi.RemoveBody(id); bi.DestroyBody(id);
    }
}
