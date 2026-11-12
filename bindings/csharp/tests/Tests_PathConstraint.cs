using Xunit;

namespace JoltTests
{
    // Tests ported from UnitTests/Physics/PathConstraintTests.cpp
    [Collection("Jolt")]
    public sealed class Tests_PathConstraint(JoltFixture fx)
    {
        // Build the standard two-point Hermite path used throughout the C++ tests.
        // Returns the path — caller must Dispose it.
        private static JPH.PathConstraintPathHermite BuildStraightPath()
        {
            var path = new JPH.PathConstraintPathHermite();

            // Points taken directly from PathConstraintTests.cpp
            using var p1 = new JPH.Vec3(1424.96313f, 468.565399f, 483.655975f);
            using var t1 = new JPH.Vec3(61.4222832f, 42.8926392f, -1.70530257e-13f);
            using var n1 = new JPH.Vec3(0f, 0f, 1f);

            using var p2 = new JPH.Vec3(1445.20105f, 482.364319f, 483.655975f);
            using var t2 = new JPH.Vec3(20.2380009f, 13.7989082f, -5.68434189e-14f);
            using var n2 = new JPH.Vec3(0f, 0f, 1f);

            path.AddPoint(p1, t1, n1);
            path.AddPoint(p2, t2, n2);
            return path;
        }

        // --- Construction ---

        [Fact]
        public void PathConstraintPathHermite_DefaultConstruct_NoCrash()
        {
            using var path = new JPH.PathConstraintPathHermite();
            Assert.NotNull(path);
        }

        [Fact]
        public void PathConstraintPathHermite_SetIsLooping_RoundTrip()
        {
            using var path = new JPH.PathConstraintPathHermite();
            Assert.False(path.IsLooping());
            path.SetIsLooping(true);
            Assert.True(path.IsLooping());
            path.SetIsLooping(false);
            Assert.False(path.IsLooping());
        }

        // --- GetPathMaxFraction ---

        [Fact]
        public void PathConstraintPathHermite_TwoPoints_GetPathMaxFraction_Returns1()
        {
            using var path = BuildStraightPath();
            Assert.Equal(1.0f, path.GetPathMaxFraction());
        }

        // --- GetClosestPoint: before start / after end ---

        [Fact]
        public void PathConstraintPathHermite_GetClosestPoint_BeforeStart_Returns0()
        {
            // Position slightly before the first point (p1 - 0.01 * t1) should clamp to 0.
            using var path = BuildStraightPath();

            // p1 - 0.01 * t1
            using var pos = new JPH.Vec3(
                1424.96313f - 0.01f * 61.4222832f,
                468.565399f - 0.01f * 42.8926392f,
                483.655975f);

            float fraction = path.GetClosestPoint(pos, 0f);
            Assert.Equal(0.0f, fraction);
        }

        [Fact]
        public void PathConstraintPathHermite_GetClosestPoint_AfterEnd_Returns1()
        {
            // Position slightly after the last point (p2 + 0.01 * t2) should clamp to 1.
            using var path = BuildStraightPath();

            // p2 + 0.01 * t2
            using var pos = new JPH.Vec3(
                1445.20105f + 0.01f * 20.2380009f,
                482.364319f + 0.01f * 13.7989082f,
                483.655975f);

            float fraction = path.GetClosestPoint(pos, 0f);
            Assert.Equal(1.0f, fraction);
        }

        // --- GetPointOnPath / GetClosestPoint round-trip ---
        // For each fraction 0.0, 0.1, ..., 1.0: get the point, then ask GetClosestPoint
        // for that point — it should return back the same fraction (within 1e-4).

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void PathConstraintPathHermite_GetPointOnPath_GetClosestPoint_RoundTrip(int step)
        {
            using var path = BuildStraightPath();
            float fraction = 0.1f * step;

            using var pos = JPH.Vec3.SZero();
            using var tgt = JPH.Vec3.SZero();
            using var nrm = JPH.Vec3.SZero();
            using var bin = JPH.Vec3.SZero();

            path.GetPointOnPath(fraction, pos, tgt, nrm, bin);

            float closestFraction = path.GetClosestPoint(pos, 0f);

            Assert.True(
                MathF.Abs(fraction - closestFraction) < 1e-4f,
                $"step={step}: fraction={fraction} closestFraction={closestFraction} diff={MathF.Abs(fraction - closestFraction)}");
        }

        // --- GetPointOnPath: tangent/normal/binormal are non-zero at interior points ---

        [Fact]
        public void PathConstraintPathHermite_GetPointOnPath_MidPoint_TangentNonZero()
        {
            using var path = BuildStraightPath();
            using var pos = JPH.Vec3.SZero();
            using var tgt = JPH.Vec3.SZero();
            using var nrm = JPH.Vec3.SZero();
            using var bin = JPH.Vec3.SZero();

            path.GetPointOnPath(0.5f, pos, tgt, nrm, bin);

            // Tangent should be non-zero
            float tgtLen = MathF.Sqrt(tgt.GetX() * tgt.GetX() + tgt.GetY() * tgt.GetY() + tgt.GetZ() * tgt.GetZ());
            Assert.True(tgtLen > 1e-6f, $"Tangent length should be non-zero, got {tgtLen}");
        }
    }
}
