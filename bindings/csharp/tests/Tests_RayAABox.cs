using Xunit;

namespace JoltTests
{
    // Tests ported from UnitTests/Geometry/RayAABoxTests.cpp
    [Collection("Jolt")]
    public sealed class Tests_RayAABox(JoltFixture fx)
    {
        // AABox from (-1,-1,-1) to (1,1,1).
        private static (JPH.Vec3 min, JPH.Vec3 max) BoxBounds()
            => (new JPH.Vec3(-1f, -1f, -1f), new JPH.Vec3(1f, 1f, 1f));

        // --- RayInvDirection construction ---

        [Fact]
        public void RayInvDirection_DefaultConstruct_NoCrash()
        {
            using var inv = new JPH.RayInvDirection();
            Assert.NotNull(inv);
        }

        [Fact]
        public void RayInvDirection_FromDirection_NoCrash()
        {
            using var dir = new JPH.Vec3(1f, 0f, 0f);
            using var inv = new JPH.RayInvDirection(dir);
            Assert.NotNull(inv);
        }

        [Fact]
        public void RayInvDirection_FromAxisDir_InvDirectionIsReciprocal()
        {
            // direction (2, 0, 0) → mInvDirection.x should be 0.5
            using var dir = new JPH.Vec3(2f, 0f, 0f);
            using var inv = new JPH.RayInvDirection(dir);
            // mInvDirection is a Const_Vec3 property
            using var invDir = inv.mInvDirection;
            Assert.True(MathF.Abs(invDir.GetX() - 0.5f) < 1e-6f);
        }

        // --- RayAABox: ray starting inside box (should return negative) ---

        [Fact]
        public void RayAABox_InsideBox_AxisX_Positive_ReturnsNegative()
        {
            var (min, max) = BoxBounds();
            using var origin = JPH.Vec3.SZero();
            using var dir = new JPH.Vec3(1f, 0f, 0f);
            using var inv = new JPH.RayInvDirection(dir);
            float t = JPH.Const_JoltHelpers.RayAABox(origin, inv, min, max);
            Assert.True(t < 0f, $"Expected negative fraction for ray inside box, got {t}");
            min.Dispose(); max.Dispose();
        }

        [Fact]
        public void RayAABox_InsideBox_AxisX_Negative_ReturnsNegative()
        {
            var (min, max) = BoxBounds();
            using var origin = JPH.Vec3.SZero();
            using var dir = new JPH.Vec3(-1f, 0f, 0f);
            using var inv = new JPH.RayInvDirection(dir);
            float t = JPH.Const_JoltHelpers.RayAABox(origin, inv, min, max);
            Assert.True(t < 0f, $"Expected negative fraction for ray inside box, got {t}");
            min.Dispose(); max.Dispose();
        }

        [Fact]
        public void RayAABox_InsideBox_AxisY_Positive_ReturnsNegative()
        {
            var (min, max) = BoxBounds();
            using var origin = JPH.Vec3.SZero();
            using var dir = new JPH.Vec3(0f, 1f, 0f);
            using var inv = new JPH.RayInvDirection(dir);
            float t = JPH.Const_JoltHelpers.RayAABox(origin, inv, min, max);
            Assert.True(t < 0f);
            min.Dispose(); max.Dispose();
        }

        [Fact]
        public void RayAABox_InsideBox_AxisZ_Positive_ReturnsNegative()
        {
            var (min, max) = BoxBounds();
            using var origin = JPH.Vec3.SZero();
            using var dir = new JPH.Vec3(0f, 0f, 1f);
            using var inv = new JPH.RayInvDirection(dir);
            float t = JPH.Const_JoltHelpers.RayAABox(origin, inv, min, max);
            Assert.True(t < 0f);
            min.Dispose(); max.Dispose();
        }

        // --- RayAABox: ray starting outside, pointing toward box (should hit) ---

        [Fact]
        public void RayAABox_OutsideHigh_PointingLow_AxisX_HitsAtExpected()
        {
            // Origin.x = 1.1, direction = -X → should hit at fraction 0.1
            var (min, max) = BoxBounds();
            using var origin = new JPH.Vec3(1.1f, 0f, 0f);
            using var dir = new JPH.Vec3(-1f, 0f, 0f);
            using var inv = new JPH.RayInvDirection(dir);
            float t = JPH.Const_JoltHelpers.RayAABox(origin, inv, min, max);
            Assert.True(MathF.Abs(t - 0.1f) < 1e-5f, $"Expected ~0.1 got {t}");
            min.Dispose(); max.Dispose();
        }

        [Fact]
        public void RayAABox_OutsideLow_PointingHigh_AxisX_HitsAtExpected()
        {
            // Origin.x = -1.1, direction = +X → should hit at fraction 0.1
            var (min, max) = BoxBounds();
            using var origin = new JPH.Vec3(-1.1f, 0f, 0f);
            using var dir = new JPH.Vec3(1f, 0f, 0f);
            using var inv = new JPH.RayInvDirection(dir);
            float t = JPH.Const_JoltHelpers.RayAABox(origin, inv, min, max);
            Assert.True(MathF.Abs(t - 0.1f) < 1e-5f, $"Expected ~0.1 got {t}");
            min.Dispose(); max.Dispose();
        }

        [Fact]
        public void RayAABox_OutsideHigh_PointingLow_AxisY_HitsAtExpected()
        {
            var (min, max) = BoxBounds();
            using var origin = new JPH.Vec3(0f, 1.1f, 0f);
            using var dir = new JPH.Vec3(0f, -1f, 0f);
            using var inv = new JPH.RayInvDirection(dir);
            float t = JPH.Const_JoltHelpers.RayAABox(origin, inv, min, max);
            Assert.True(MathF.Abs(t - 0.1f) < 1e-5f);
            min.Dispose(); max.Dispose();
        }

        [Fact]
        public void RayAABox_OutsideHigh_PointingLow_AxisZ_HitsAtExpected()
        {
            var (min, max) = BoxBounds();
            using var origin = new JPH.Vec3(0f, 0f, 1.1f);
            using var dir = new JPH.Vec3(0f, 0f, -1f);
            using var inv = new JPH.RayInvDirection(dir);
            float t = JPH.Const_JoltHelpers.RayAABox(origin, inv, min, max);
            Assert.True(MathF.Abs(t - 0.1f) < 1e-5f);
            min.Dispose(); max.Dispose();
        }

        // --- RayAABox: ray starting outside, pointing away (should miss → FLT_MAX) ---

        [Fact]
        public void RayAABox_OutsideHigh_PointingHigher_AxisX_ReturnsFltMax()
        {
            var (min, max) = BoxBounds();
            using var origin = new JPH.Vec3(1.1f, 0f, 0f);
            using var dir = new JPH.Vec3(1f, 0f, 0f);
            using var inv = new JPH.RayInvDirection(dir);
            float t = JPH.Const_JoltHelpers.RayAABox(origin, inv, min, max);
            Assert.Equal(float.MaxValue, t);
            min.Dispose(); max.Dispose();
        }

        [Fact]
        public void RayAABox_OutsideLow_PointingLower_AxisX_ReturnsFltMax()
        {
            var (min, max) = BoxBounds();
            using var origin = new JPH.Vec3(-1.1f, 0f, 0f);
            using var dir = new JPH.Vec3(-1f, 0f, 0f);
            using var inv = new JPH.RayInvDirection(dir);
            float t = JPH.Const_JoltHelpers.RayAABox(origin, inv, min, max);
            Assert.Equal(float.MaxValue, t);
            min.Dispose(); max.Dispose();
        }

        [Fact]
        public void RayAABox_OutsideHigh_PointingHigher_AxisY_ReturnsFltMax()
        {
            var (min, max) = BoxBounds();
            using var origin = new JPH.Vec3(0f, 1.1f, 0f);
            using var dir = new JPH.Vec3(0f, 1f, 0f);
            using var inv = new JPH.RayInvDirection(dir);
            float t = JPH.Const_JoltHelpers.RayAABox(origin, inv, min, max);
            Assert.Equal(float.MaxValue, t);
            min.Dispose(); max.Dispose();
        }

        [Fact]
        public void RayAABox_OutsideHigh_PointingHigher_AxisZ_ReturnsFltMax()
        {
            var (min, max) = BoxBounds();
            using var origin = new JPH.Vec3(0f, 0f, 1.1f);
            using var dir = new JPH.Vec3(0f, 0f, 1f);
            using var inv = new JPH.RayInvDirection(dir);
            float t = JPH.Const_JoltHelpers.RayAABox(origin, inv, min, max);
            Assert.Equal(float.MaxValue, t);
            min.Dispose(); max.Dispose();
        }

        // --- RayAABox: angled ray hitting top face ---

        [Fact]
        public void RayAABox_AngledRay_HitsTopFace_CorrectFraction()
        {
            // Expected hit = (0,1,0), expected_fraction = 0.123, direction = (4,-4,0)
            // origin = expected_hit - expected_fraction * direction
            var (min, max) = BoxBounds();
            const float expectedFraction = 0.123f;
            using var expectedHit = new JPH.Vec3(0f, 1f, 0f);
            using var dir = new JPH.Vec3(4f, -4f, 0f);
            // origin = expectedHit - expectedFraction * dir = (0 - 0.492, 1 + 0.492, 0) = (-0.492, 1.492, 0)
            using var origin = new JPH.Vec3(
                0f - expectedFraction * 4f,
                1f - expectedFraction * -4f,
                0f);
            using var inv = new JPH.RayInvDirection(dir);
            float t = JPH.Const_JoltHelpers.RayAABox(origin, inv, min, max);
            Assert.True(MathF.Abs(t - expectedFraction) < 1e-5f, $"Expected ~{expectedFraction} got {t}");
            min.Dispose(); max.Dispose();
        }
    }
}
