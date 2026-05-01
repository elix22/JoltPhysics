// Tests for JobSystemSingleThreaded and JobSystemThreadPool.
// The JoltFixture already creates a JobSystemThreadPool; these tests exercise
// both job system types directly.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_JobSystem(JoltFixture fx)
{
    // ── JobSystemSingleThreaded ────────────────────────────────────────────

    [Fact] public void SingleThreaded_DefaultConstruct_NoCrash()
    {
        using var js = new JPH.JobSystemSingleThreaded();
        Assert.NotNull(js);
    }

    [Fact] public void SingleThreaded_ConstructWithMaxJobs_NoCrash()
    {
        using var js = new JPH.JobSystemSingleThreaded(1024u);
        Assert.NotNull(js);
    }

    [Fact] public void SingleThreaded_GetMaxConcurrency_IsOne()
    {
        using var js = new JPH.JobSystemSingleThreaded(1024u);
        // Single-threaded job system always reports concurrency of 1.
        Assert.Equal(1, js.GetMaxConcurrency());
    }

    [Fact] public void SingleThreaded_Init_ThenGetMaxConcurrency_IsOne()
    {
        using var js = new JPH.JobSystemSingleThreaded();
        js.Init(512u);
        Assert.Equal(1, js.GetMaxConcurrency());
    }

    // ── JobSystemThreadPool ────────────────────────────────────────────────

    [Fact] public void ThreadPool_FixtureJobs_GetMaxConcurrency_Positive()
    {
        // The fixture creates JobSystemThreadPool(2048, 8, -1).
        Assert.True(fx.Jobs.GetMaxConcurrency() > 0);
    }

    [Fact] public void ThreadPool_DefaultConstruct_NoCrash()
    {
        using var js = new JPH.JobSystemThreadPool();
        Assert.NotNull(js);
    }

    [Fact] public void ThreadPool_ConstructWithArgs_GetMaxConcurrency_Positive()
    {
        using var js = new JPH.JobSystemThreadPool(1024u, 4u, 2);
        Assert.True(js.GetMaxConcurrency() > 0);
    }
}
