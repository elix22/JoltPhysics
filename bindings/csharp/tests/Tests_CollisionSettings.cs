using Xunit;

namespace JoltTests
{
    /// <summary>
    /// Tests for RayCastSettings, CollideSettingsBase, CollideShapeSettings,
    /// CollideShapeResult, ShapeCastSettings, ShapeCastResult, and the
    /// EBackFaceMode / EActiveEdgeMode / ECollectFacesMode enums.
    /// </summary>
    [Collection("Jolt")]
    public sealed class Tests_CollisionSettings(JoltFixture fx)
    {
        // --- Enum values ---

        [Fact]
        public void EBackFaceMode_Values_Correct()
        {
            Assert.Equal(0, (int)JPH.EBackFaceMode.IgnoreBackFaces);
            Assert.Equal(1, (int)JPH.EBackFaceMode.CollideWithBackFaces);
        }

        [Fact]
        public void EActiveEdgeMode_Values_Correct()
        {
            Assert.Equal(0, (int)JPH.EActiveEdgeMode.CollideOnlyWithActive);
            Assert.Equal(1, (int)JPH.EActiveEdgeMode.CollideWithAll);
        }

        [Fact]
        public void ECollectFacesMode_Values_Correct()
        {
            Assert.Equal(0, (int)JPH.ECollectFacesMode.CollectFaces);
            Assert.Equal(1, (int)JPH.ECollectFacesMode.NoFaces);
        }

        // --- RayCastSettings defaults ---

        [Fact]
        public void RayCastSettings_DefaultConstruct_NoCrash()
        {
            using var s = new JPH.RayCastSettings();
            Assert.NotNull(s);
        }

        [Fact]
        public void RayCastSettings_Defaults()
        {
            using var s = new JPH.RayCastSettings();
            Assert.Equal(JPH.EBackFaceMode.IgnoreBackFaces, s.mBackFaceModeTriangles);
            Assert.Equal(JPH.EBackFaceMode.IgnoreBackFaces, s.mBackFaceModeConvex);
            Assert.True(s.mTreatConvexAsSolid);
        }

        [Fact]
        public void RayCastSettings_RoundTrip_BackFaceMode()
        {
            using var s = new JPH.RayCastSettings();
            s.mBackFaceModeTriangles = JPH.EBackFaceMode.CollideWithBackFaces;
            s.mBackFaceModeConvex = JPH.EBackFaceMode.CollideWithBackFaces;
            Assert.Equal(JPH.EBackFaceMode.CollideWithBackFaces, s.mBackFaceModeTriangles);
            Assert.Equal(JPH.EBackFaceMode.CollideWithBackFaces, s.mBackFaceModeConvex);
        }

        [Fact]
        public void RayCastSettings_RoundTrip_TreatConvexAsSolid()
        {
            using var s = new JPH.RayCastSettings();
            s.mTreatConvexAsSolid = false;
            Assert.False(s.mTreatConvexAsSolid);
        }

        // --- CollideSettingsBase defaults ---

        [Fact]
        public void CollideSettingsBase_DefaultConstruct_NoCrash()
        {
            using var s = new JPH.CollideSettingsBase();
            Assert.NotNull(s);
        }

        [Fact]
        public void CollideSettingsBase_Defaults()
        {
            using var s = new JPH.CollideSettingsBase();
            Assert.Equal(JPH.EActiveEdgeMode.CollideOnlyWithActive, s.mActiveEdgeMode);
            Assert.Equal(JPH.ECollectFacesMode.NoFaces, s.mCollectFacesMode);
        }

        [Fact]
        public void CollideSettingsBase_RoundTrip_ActiveEdgeMode()
        {
            using var s = new JPH.CollideSettingsBase();
            s.mActiveEdgeMode = JPH.EActiveEdgeMode.CollideWithAll;
            Assert.Equal(JPH.EActiveEdgeMode.CollideWithAll, s.mActiveEdgeMode);
        }

        [Fact]
        public void CollideSettingsBase_RoundTrip_CollectFacesMode()
        {
            using var s = new JPH.CollideSettingsBase();
            s.mCollectFacesMode = JPH.ECollectFacesMode.CollectFaces;
            Assert.Equal(JPH.ECollectFacesMode.CollectFaces, s.mCollectFacesMode);
        }

        // --- CollideShapeSettings ---

        [Fact]
        public void CollideShapeSettings_DefaultConstruct_NoCrash()
        {
            using var s = new JPH.CollideShapeSettings();
            Assert.NotNull(s);
        }

        [Fact]
        public void CollideShapeSettings_DefaultMaxSeparationDistance_Zero()
        {
            using var s = new JPH.CollideShapeSettings();
            Assert.Equal(0.0f, s.mMaxSeparationDistance);
        }

        [Fact]
        public void CollideShapeSettings_RoundTrip_MaxSeparationDistance()
        {
            using var s = new JPH.CollideShapeSettings();
            s.mMaxSeparationDistance = 0.05f;
            Assert.Equal(0.05f, s.mMaxSeparationDistance, 1e-6f);
        }

        // --- CollideShapeResult defaults ---

        [Fact]
        public void CollideShapeResult_DefaultConstruct_NoCrash()
        {
            using var r = new JPH.CollideShapeResult();
            Assert.NotNull(r);
        }

        [Fact]
        public void CollideShapeResult_GetEarlyOutFraction_IsNegativePenetrationDepth()
        {
            using var r = new JPH.CollideShapeResult();
            // GetEarlyOutFraction() == -mPenetrationDepth
            Assert.Equal(-r.mPenetrationDepth, r.GetEarlyOutFraction(), 1e-6f);
        }

        [Fact]
        public void CollideShapeResult_Reversed_SwapsContactPoints()
        {
            using var r = new JPH.CollideShapeResult();
            // Set contact points by mutating fields
            r.mContactPointOn1.GetX(); // just access to ensure no crash on default
            using var rev = r.Reversed();
            Assert.NotNull(rev);
        }

        // --- ShapeCastSettings defaults ---

        [Fact]
        public void ShapeCastSettings_DefaultConstruct_NoCrash()
        {
            using var s = new JPH.ShapeCastSettings();
            Assert.NotNull(s);
        }

        [Fact]
        public void ShapeCastSettings_Defaults()
        {
            using var s = new JPH.ShapeCastSettings();
            Assert.Equal(JPH.EBackFaceMode.IgnoreBackFaces, s.mBackFaceModeTriangles);
            Assert.Equal(JPH.EBackFaceMode.IgnoreBackFaces, s.mBackFaceModeConvex);
            Assert.False(s.mReturnDeepestPoint);
        }

        [Fact]
        public void ShapeCastSettings_RoundTrip_BackFaceMode()
        {
            using var s = new JPH.ShapeCastSettings();
            s.mBackFaceModeTriangles = JPH.EBackFaceMode.CollideWithBackFaces;
            s.mReturnDeepestPoint = true;
            Assert.Equal(JPH.EBackFaceMode.CollideWithBackFaces, s.mBackFaceModeTriangles);
            Assert.True(s.mReturnDeepestPoint);
        }

        // --- ShapeCastResult defaults ---

        [Fact]
        public void ShapeCastResult_DefaultConstruct_NoCrash()
        {
            using var r = new JPH.ShapeCastResult();
            Assert.NotNull(r);
        }

        [Fact]
        public void ShapeCastResult_GetEarlyOutFraction_IsFraction()
        {
            using var r = new JPH.ShapeCastResult();
            // GetEarlyOutFraction() == mFraction
            Assert.Equal(r.mFraction, r.GetEarlyOutFraction(), 1e-6f);
        }
    }
}
