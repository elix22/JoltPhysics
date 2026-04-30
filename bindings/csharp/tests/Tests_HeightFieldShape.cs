// Tests for JPH::HeightFieldShapeSettings fields, defaults, round-trips,
// and utility methods (DetermineMinAndMaxSample, CalculateBitsPerSampleForError).
// Note: Constructing an actual HeightFieldShape with height-sample data is not
// supported through the C# bindings (no sample-array constructor is exposed),
// so tests are limited to settings inspection and the default-constructed shape.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_HeightFieldShape
{
    // ─────────────────────────────────────────────────────────────────────────
    // Construction
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void HeightFieldShapeSettings_DefaultConstruct_DoesNotThrow()
    {
        using var s = new JPH.HeightFieldShapeSettings();
        Assert.NotNull(s);
    }

    // NOTE: new JPH.HeightFieldShape() (default-constructed) crashes on Dispose
    // because the default C++ constructor leaves internal state uninitialized.
    // No test for default-constructed HeightFieldShape shape object.

    // ─────────────────────────────────────────────────────────────────────────
    // Default field values
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void HeightFieldShapeSettings_SampleCount_Default_IsZero()
    {
        using var s = new JPH.HeightFieldShapeSettings();
        Assert.Equal(0u, s.mSampleCount);
    }

    [Fact]
    public void HeightFieldShapeSettings_BlockSize_Default_IsTwo()
    {
        // Jolt default for mBlockSize is 2
        using var s = new JPH.HeightFieldShapeSettings();
        Assert.Equal(2u, s.mBlockSize);
    }

    [Fact]
    public void HeightFieldShapeSettings_BitsPerSample_Default_IsEight()
    {
        // Jolt default for mBitsPerSample is 8
        using var s = new JPH.HeightFieldShapeSettings();
        Assert.Equal(8u, s.mBitsPerSample);
    }

    [Fact]
    public void HeightFieldShapeSettings_MinHeightValue_Default_IsLargeFloat()
    {
        // Jolt default: mMinHeightValue = cLargeFloat = 1e15f
        using var s = new JPH.HeightFieldShapeSettings();
        Assert.Equal(1e15f, s.mMinHeightValue);
    }

    [Fact]
    public void HeightFieldShapeSettings_MaxHeightValue_Default_IsNegativeLargeFloat()
    {
        // Jolt default: mMaxHeightValue = -cLargeFloat = -1e15f
        using var s = new JPH.HeightFieldShapeSettings();
        Assert.Equal(-1e15f, s.mMaxHeightValue);
    }

    [Fact]
    public void HeightFieldShapeSettings_ActiveEdgeCosThresholdAngle_Default_IsInRange()
    {
        // Default angle threshold is a cosine value in [-1, 1]
        using var s = new JPH.HeightFieldShapeSettings();
        Assert.True(s.mActiveEdgeCosThresholdAngle >= -1f && s.mActiveEdgeCosThresholdAngle <= 1f);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Field round-trips
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void HeightFieldShapeSettings_SampleCount_RoundTrips()
    {
        using var s = new JPH.HeightFieldShapeSettings();
        s.mSampleCount = 16u;
        Assert.Equal(16u, s.mSampleCount);
    }

    [Fact]
    public void HeightFieldShapeSettings_BlockSize_RoundTrips()
    {
        using var s = new JPH.HeightFieldShapeSettings();
        s.mBlockSize = 4u;
        Assert.Equal(4u, s.mBlockSize);
    }

    [Fact]
    public void HeightFieldShapeSettings_BitsPerSample_RoundTrips()
    {
        using var s = new JPH.HeightFieldShapeSettings();
        s.mBitsPerSample = 4u;
        Assert.Equal(4u, s.mBitsPerSample);
    }

    [Fact]
    public void HeightFieldShapeSettings_MinHeightValue_RoundTrips()
    {
        using var s = new JPH.HeightFieldShapeSettings();
        s.mMinHeightValue = -10f;
        Assert.Equal(-10f, s.mMinHeightValue, precision: 5);
    }

    [Fact]
    public void HeightFieldShapeSettings_MaxHeightValue_RoundTrips()
    {
        using var s = new JPH.HeightFieldShapeSettings();
        s.mMaxHeightValue = 200f;
        Assert.Equal(200f, s.mMaxHeightValue, precision: 5);
    }

    // NOTE: CalculateBitsPerSampleForError requires mHeightSamples to be populated;
    // calling it with mHeightSamples=nullptr (no constructor with sample data exists
    // in the C# bindings) causes a native crash. No tests for that method.
}
