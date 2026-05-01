// Tests for TempAllocatorImpl.
// The JoltFixture creates a 64 MB TempAllocatorImpl; these tests exercise
// its inspection API directly.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_TempAllocator(JoltFixture fx)
{
    [Fact] public void Construct_NoCrash()
    {
        using var a = new JPH.TempAllocatorImpl((UIntPtr)(4 * 1024 * 1024));
        Assert.NotNull(a);
    }

    [Fact] public void GetSize_ReturnsRequestedSize()
    {
        UIntPtr requested = (UIntPtr)(8 * 1024 * 1024);
        using var a = new JPH.TempAllocatorImpl(requested);
        Assert.Equal(requested, a.GetSize());
    }

    [Fact] public void IsEmpty_AfterConstruct_IsTrue()
    {
        using var a = new JPH.TempAllocatorImpl((UIntPtr)(4 * 1024 * 1024));
        Assert.True(a.IsEmpty());
    }

    [Fact] public void GetUsage_AfterConstruct_IsZero()
    {
        using var a = new JPH.TempAllocatorImpl((UIntPtr)(4 * 1024 * 1024));
        Assert.Equal(UIntPtr.Zero, a.GetUsage());
    }

    [Fact] public void CanAllocate_SmallSize_IsTrue()
    {
        using var a = new JPH.TempAllocatorImpl((UIntPtr)(4 * 1024 * 1024));
        Assert.True(a.CanAllocate(1024u));
    }

    [Fact] public void CanAllocate_SizeLargerThanTotal_IsFalse()
    {
        using var a = new JPH.TempAllocatorImpl((UIntPtr)(1024));
        // Request more than the allocator holds.
        Assert.False(a.CanAllocate(2048u));
    }

    [Fact] public void FixtureAlloc_GetSize_IsAtLeast64MB()
    {
        // The fixture creates TempAllocatorImpl(64 * 1024 * 1024).
        Assert.True(fx.Alloc.GetSize() >= (UIntPtr)(64 * 1024 * 1024));
    }

    [Fact] public void FixtureAlloc_CanAllocate_1MB_IsTrue()
    {
        Assert.True(fx.Alloc.CanAllocate(1024u * 1024u));
    }
}
