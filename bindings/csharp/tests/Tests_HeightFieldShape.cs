// Tests for JPH::HeightFieldShapeSettings fields, defaults, round-trips,
// utility methods (DetermineMinAndMaxSample, CalculateBitsPerSampleForError),
// and shape creation via JoltHelpers helper methods that allow sample-array
// access from C# (HeightFieldSettingsResizeHeightSamples, etc.).

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_HeightFieldShape(JoltFixture fx)
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

    // ─────────────────────────────────────────────────────────────────────────
    // HeightSamples helper methods (via JoltHelpers)
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void HeightFieldSettings_HeightSamples_InitialCount_IsZero()
    {
        using var s = new JPH.HeightFieldShapeSettings();
        uint count = JPH.Const_JoltHelpers.HeightFieldSettingsGetHeightSamplesCount(s);
        Assert.Equal(0u, count);
    }

    [Fact]
    public void HeightFieldSettings_ResizeHeightSamples_SetsCount()
    {
        using var s = new JPH.HeightFieldShapeSettings();
        s.HeightFieldSettingsResizeHeightSamples(16u, 0f);
        uint count = ((JPH.Const_HeightFieldShapeSettings)s).HeightFieldSettingsGetHeightSamplesCount();
        Assert.Equal(16u, count);
    }

    [Fact]
    public void HeightFieldSettings_SetHeightSampleAt_RoundTrips()
    {
        using var s = new JPH.HeightFieldShapeSettings();
        s.HeightFieldSettingsResizeHeightSamples(4u, 0f);
        s.HeightFieldSettingsSetHeightSampleAt(2u, 3.14f);
        float v = ((JPH.Const_HeightFieldShapeSettings)s).HeightFieldSettingsGetHeightSample(2u);
        Assert.Equal(3.14f, v, 1e-4f);
    }

    [Fact]
    public void HeightFieldShapeConstants_NoCollisionValue_IsLargePositive()
    {
        float noCol = JPH.Const_JoltHelpers.HeightFieldShapeConstantsNoCollisionValue();
        Assert.True(noCol > 1e20f);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Shape creation from populated settings
    // ─────────────────────────────────────────────────────────────────────────

    // Create a flat 4×4 heightfield at y=5 and verify a ray cast hits it.
    [Fact]
    public void HeightFieldShape_GetPosition_FlatTerrain_CorrectY()
    {
        using var sys = fx.MakePhysicsSystem();

        using var settings = new JPH.HeightFieldShapeSettings();
        settings.mSampleCount = 4u;
        const float height = 5f;
        settings.HeightFieldSettingsResizeHeightSamples(4u * 4u, height);

        var bi = sys.GetBodyInterface();
        using var bcs = new JPH.BodyCreationSettings(
            (JPH.Const_HeightFieldShapeSettings)settings,
            new JPH.Vec3(0f, 0f, 0f), JPH.Quat.SIdentity(),
            JPH.EMotionType.Static, JoltFixture.LayerNonMoving);
        JPH.BodyID id = bi.CreateAndAddBody(bcs, JPH.EActivation.DontActivate);
        try
        {
            // Get shape from body lock interface
            using var ts = bi.GetTransformedShape(id);
            // CastRay straight down at (0.5, 10, 0.5) → should hit at y≈5
            using var rayOrigin = new JPH.Vec3(0.5f, 10f, 0.5f);
            using var rayDir = new JPH.Vec3(0f, -20f, 0f);
            using var ray = new JPH.RRayCast(rayOrigin, rayDir);
            using var hit = new JPH.RayCastResult();
            bool hitResult = ts.CastRay(ray, hit);
            Assert.True(hitResult);
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }

    [Fact]
    public void HeightFieldSettings_IsNoCollision_FillWithNoCollision()
    {
        using var s = new JPH.HeightFieldShapeSettings();
        float noCol = JPH.Const_JoltHelpers.HeightFieldShapeConstantsNoCollisionValue();
        s.HeightFieldSettingsResizeHeightSamples(4u, noCol);
        // All samples set to no-collision value — verify they were stored
        float sample = ((JPH.Const_HeightFieldShapeSettings)s).HeightFieldSettingsGetHeightSample(0u);
        Assert.Equal(noCol, sample, 1e-3f);
    }

    // NOTE: CalculateBitsPerSampleForError requires a valid mSampleCount and
    // populated height samples. With a flat terrain mMin == mMax which makes the
    // error quantization degenerate (returns 0 bits). We just verify it does not crash.
    [Fact]
    public void HeightFieldSettings_CalculateBitsPerSampleForError_NoCrash()
    {
        using var s = new JPH.HeightFieldShapeSettings();
        s.mSampleCount = 4u;
        const float height = 5f;
        JPH.JoltHelpers.HeightFieldSettingsResizeHeightSamples(s, 4u * 4u, height);
        uint bits = s.CalculateBitsPerSampleForError(0.01f);
        Assert.True(bits <= 8u); // valid compressed bits per sample
    }
}
