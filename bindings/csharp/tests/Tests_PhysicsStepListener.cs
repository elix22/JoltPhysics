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

    // ─────────────────────────────────────────────────────────────────────────
    // CountingPhysicsStepListener — simulation
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void StepListener_OnStep_Called_AfterUpdate()
    {
        using var sys = fx.MakePhysicsSystem();
        using var listener = new JPH.CountingPhysicsStepListener();
        sys.AddStepListener(listener);
        Assert.Equal(0, listener.GetCount());
        sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);
        Assert.True(listener.GetCount() > 0);
        sys.RemoveStepListener(listener);
    }

    [Fact]
    public void StepListener_GetLastDeltaTime_MatchesUpdate()
    {
        using var sys = fx.MakePhysicsSystem();
        using var listener = new JPH.CountingPhysicsStepListener();
        sys.AddStepListener(listener);
        float dt = 1f / 60f;
        sys.Update(dt, 1, fx.Alloc, fx.Jobs);
        Assert.Equal(dt, listener.GetLastDeltaTime(), 1e-4f);
        sys.RemoveStepListener(listener);
    }

    [Fact]
    public void StepListener_MultipleSubsteps_IncreasesCount()
    {
        using var sys = fx.MakePhysicsSystem();
        using var listener = new JPH.CountingPhysicsStepListener();
        sys.AddStepListener(listener);
        sys.Update(1f / 60f, 3, fx.Alloc, fx.Jobs);
        // Each substep calls OnStep once
        Assert.Equal(3, listener.GetCount());
        sys.RemoveStepListener(listener);
    }

    [Fact]
    public void StepListener_AddRemove_NoCrash()
    {
        using var sys = fx.MakePhysicsSystem();
        using var listener = new JPH.CountingPhysicsStepListener();
        sys.AddStepListener(listener);
        sys.RemoveStepListener(listener);
        sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);
        // Listener was removed before Update — count should still be 0
        Assert.Equal(0, listener.GetCount());
    }

    [Fact]
    public void StepListener_Reset_ClearsCount()
    {
        using var sys = fx.MakePhysicsSystem();
        using var listener = new JPH.CountingPhysicsStepListener();
        sys.AddStepListener(listener);
        sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);
        Assert.True(listener.GetCount() > 0);
        listener.Reset();
        Assert.Equal(0, listener.GetCount());
        sys.RemoveStepListener(listener);
    }
}
