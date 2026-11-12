using Xunit;

namespace JoltTests
{
    [Collection("Jolt")]
    public sealed class Tests_Ellipse(JoltFixture fx)
    {
        // --- Construction ---

        [Fact]
        public void Ellipse_Construct_NoCrash()
        {
            using var e = new JPH.Ellipse(2.0f, 1.0f);
            Assert.NotNull(e);
        }

        [Fact]
        public void Ellipse_Copy_NoCrash()
        {
            using var e1 = new JPH.Ellipse(3.0f, 2.0f);
            using var e2 = new JPH.Ellipse(e1);
            Assert.NotNull(e2);
        }

        // --- IsInside ---

        [Fact]
        public void Ellipse_IsInside_Origin_True()
        {
            using var e = new JPH.Ellipse(2.0f, 1.0f);
            using var p = new JPH.Float2(0.0f, 0.0f);
            Assert.True(e.IsInside(p));
        }

        [Fact]
        public void Ellipse_IsInside_InsidePoint_True()
        {
            using var e = new JPH.Ellipse(2.0f, 1.0f);
            using var p = new JPH.Float2(1.0f, 0.0f);
            // point on x-axis at x=1 is inside an ellipse with a=2
            Assert.True(e.IsInside(p));
        }

        [Fact]
        public void Ellipse_IsInside_OutsidePoint_False()
        {
            using var e = new JPH.Ellipse(2.0f, 1.0f);
            using var p = new JPH.Float2(3.0f, 0.0f);
            Assert.False(e.IsInside(p));
        }

        [Fact]
        public void Ellipse_IsInside_OnBoundary_TreatedAsInside()
        {
            // IsInside uses <= 1, so a boundary point is considered inside
            using var e = new JPH.Ellipse(2.0f, 1.0f);
            using var p = new JPH.Float2(2.0f, 0.0f);
            Assert.True(e.IsInside(p));
        }

        [Fact]
        public void Ellipse_IsInside_YAxis_Inside()
        {
            using var e = new JPH.Ellipse(2.0f, 3.0f);
            using var p = new JPH.Float2(0.0f, 2.0f);
            // (0/2)² + (2/3)² = 0.444 < 1 → inside
            Assert.True(e.IsInside(p));
        }

        // --- GetClosestPoint ---

        [Fact]
        public void Ellipse_GetClosestPoint_OnXAxis_ReturnsPointOnEllipse()
        {
            using var e = new JPH.Ellipse(2.0f, 1.0f);
            using var p = new JPH.Float2(5.0f, 0.0f);
            using var closest = e.GetClosestPoint(p);
            // closest point on ellipse along x-axis should be at x≈2, y≈0
            Assert.True(MathF.Abs(closest.x - 2.0f) < 0.01f);
            Assert.True(MathF.Abs(closest.y) < 0.01f);
        }

        [Fact]
        public void Ellipse_GetClosestPoint_OnYAxis_ReturnsPointOnEllipse()
        {
            using var e = new JPH.Ellipse(2.0f, 1.0f);
            using var p = new JPH.Float2(0.0f, 5.0f);
            using var closest = e.GetClosestPoint(p);
            // closest point on ellipse along y-axis should be at x≈0, y≈1
            Assert.True(MathF.Abs(closest.x) < 0.01f);
            Assert.True(MathF.Abs(closest.y - 1.0f) < 0.01f);
        }

        // --- GetNormal ---

        [Fact]
        public void Ellipse_GetNormal_XAxisPoint_PointsOutward()
        {
            // GetNormal returns NON-normalized (x/a², y/b²). At (2,0) with a=2,b=1 → (0.5, 0)
            using var e = new JPH.Ellipse(2.0f, 1.0f);
            using var p = new JPH.Float2(2.0f, 0.0f);
            using var normal = e.GetNormal(p);
            Assert.True(normal.x > 0.0f);         // points in +X
            Assert.True(MathF.Abs(normal.y) < 0.01f); // no Y component
        }

        [Fact]
        public void Ellipse_GetNormal_YAxisPoint_PointsOutward()
        {
            using var e = new JPH.Ellipse(2.0f, 1.0f);
            using var p = new JPH.Float2(0.0f, 1.0f);
            using var normal = e.GetNormal(p);
            // normal at (0,1) should point in +Y direction
            Assert.True(MathF.Abs(normal.x) < 0.5f);
            Assert.True(normal.y > 0.5f);
        }
    }
}
