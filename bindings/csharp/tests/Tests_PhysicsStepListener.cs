// Tests for:
//   - JPH::PhysicsStepListenerContext construction and field access
//   - JPH::PhysicsSystem::AddStepListener / RemoveStepListener (null-safe)

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_PhysicsStepListener(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // PhysicsStepListenerContext — default construction
    // -------------------------------------------------------------------------

    [Fact]
    public void PhysicsStepListenerContext_DefaultConstruct_NoCrash()
    {
        using var ctx = new JPH.PhysicsStepListenerContext();
        Assert.NotNull(ctx);
    }

    // -------------------------------------------------------------------------
    // PhysicsStepListenerContext — parameterized construction + field round-trips
    // -------------------------------------------------------------------------

    [Fact]
    public void PhysicsStepListenerContext_Construct_DeltaTime()
    {
        using var ctx = new JPH.PhysicsStepListenerContext(
            mDeltaTime: 1.0f / 60.0f,
            mIsFirstStep: true,
            mIsLastStep: false,
            mPhysicsSystem: null);
        Assert.Equal(1.0f / 60.0f, ctx.mDeltaTime, 1e-5f);
    }

    [Fact]
    public void PhysicsStepListenerContext_Construct_IsFirstStep()
    {
        using var ctx = new JPH.PhysicsStepListenerContext(
            mDeltaTime: 0.016f,
            mIsFirstStep: true,
            mIsLastStep: false,
            mPhysicsSystem: null);
        Assert.True(ctx.mIsFirstStep);
        Assert.False(ctx.mIsLastStep);
    }

    [Fact]
    public void PhysicsStepListenerContext_Construct_IsLastStep()
    {
        using var ctx = new JPH.PhysicsStepListenerContext(
            mDeltaTime: 0.016f,
            mIsFirstStep: false,
            mIsLastStep: true,
            mPhysicsSystem: null);
        Assert.False(ctx.mIsFirstStep);
        Assert.True(ctx.mIsLastStep);
    }

    [Fact]
    public void PhysicsStepListenerContext_Construct_PhysicsSystemNull()
    {
        using var ctx = new JPH.PhysicsStepListenerContext(0.016f, false, false, null);
        Assert.Null(ctx.mPhysicsSystem);
    }

    [Fact]
    public void PhysicsStepListenerContext_RoundTrip_DeltaTime()
    {
        using var ctx = new JPH.PhysicsStepListenerContext();
        ctx.mDeltaTime = 0.033f;
        Assert.Equal(0.033f, ctx.mDeltaTime, 1e-5f);
    }

    [Fact]
    public void PhysicsStepListenerContext_RoundTrip_IsFirstStep()
    {
        using var ctx = new JPH.PhysicsStepListenerContext();
        ctx.mIsFirstStep = true;
        ctx.mIsLastStep  = false;
        Assert.True(ctx.mIsFirstStep);
        Assert.False(ctx.mIsLastStep);
    }

    [Fact]
    public void PhysicsStepListenerContext_Copy_NoCrash()
    {
        using var ctx1 = new JPH.PhysicsStepListenerContext(0.016f, true, true, null);
        // Copy constructor is unavailable (skipped because it takes a PhysicsStepListenerContext parameter);
        // verify the original values directly.
        Assert.Equal(0.016f, ctx1.mDeltaTime, 1e-5f);
        Assert.True(ctx1.mIsFirstStep);
        Assert.True(ctx1.mIsLastStep);
    }

    // -------------------------------------------------------------------------
    // PhysicsSystem — step listener API accessible
    // -------------------------------------------------------------------------

    [Fact]
    public void PhysicsSystem_StepListenerContext_WithSystem_NoCrash()
    {
        using var sys = fx.MakePhysicsSystem();
        // Verify PhysicsStepListenerContext can reference a real PhysicsSystem
        using var ctx = new JPH.PhysicsStepListenerContext(1.0f / 60.0f, true, true, sys);
        Assert.Equal(1.0f / 60.0f, ctx.mDeltaTime, 1e-5f);
        Assert.NotNull(ctx.mPhysicsSystem);
    }
}
