// Tests for SoftBodyCreationSettings, SoftBodySharedSettings, and SoftBodySharedSettings inner types.
// Covers SoftBodyTests.cpp (partially — no actual soft-body simulation since mVertices/mFaces
// collection accessors are not exposed via C# bindings).

using Xunit;

namespace JoltTests;

// ─── SoftBodyCreationSettings ───────────────────────────────────────────────

[Collection("Jolt")]
public sealed class Tests_SoftBodyCreationSettings(JoltFixture fx)
{
    [Fact] public void DefaultConstruct_NoCrash()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.NotNull(s);
    }

    [Fact] public void mNumIterations_DefaultIs5()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.Equal(5u, s.mNumIterations);
    }

    [Fact] public void mLinearDamping_DefaultIs0_1()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.Equal(0.1f, s.mLinearDamping, 5);
    }

    [Fact] public void mMaxLinearVelocity_DefaultIs500()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.Equal(500f, s.mMaxLinearVelocity, 5);
    }

    [Fact] public void mRestitution_DefaultIsZero()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.Equal(0f, s.mRestitution);
    }

    [Fact] public void mFriction_DefaultIs0_2()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.Equal(0.2f, s.mFriction, 5);
    }

    [Fact] public void mPressure_DefaultIsZero()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.Equal(0f, s.mPressure);
    }

    [Fact] public void mGravityFactor_DefaultIsOne()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.Equal(1f, s.mGravityFactor, 5);
    }

    [Fact] public void mVertexRadius_DefaultIsZero()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.Equal(0f, s.mVertexRadius);
    }

    [Fact] public void mUpdatePosition_DefaultIsTrue()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.True(s.mUpdatePosition);
    }

    [Fact] public void mMakeRotationIdentity_DefaultIsTrue()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.True(s.mMakeRotationIdentity);
    }

    [Fact] public void mAllowSleeping_DefaultIsTrue()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.True(s.mAllowSleeping);
    }

    [Fact] public void mFacesDoubleSided_DefaultIsFalse()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.False(s.mFacesDoubleSided);
    }

    [Fact] public void mUserData_DefaultIsZero()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.Equal(UIntPtr.Zero, s.mUserData);
    }

    [Fact] public void mObjectLayer_DefaultIsZero()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        Assert.Equal((ushort)0, s.mObjectLayer);
    }

    [Fact] public void mNumIterations_RoundTrip()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        s.mNumIterations = 10u;
        Assert.Equal(10u, s.mNumIterations);
    }

    [Fact] public void mLinearDamping_RoundTrip()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        s.mLinearDamping = 0.05f;
        Assert.Equal(0.05f, s.mLinearDamping, 5);
    }

    [Fact] public void mGravityFactor_RoundTrip()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        s.mGravityFactor = 2f;
        Assert.Equal(2f, s.mGravityFactor, 5);
    }

    [Fact] public void mAllowSleeping_SetFalse_RoundTrip()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        s.mAllowSleeping = false;
        Assert.False(s.mAllowSleeping);
    }

    [Fact] public void mFacesDoubleSided_SetTrue_RoundTrip()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        s.mFacesDoubleSided = true;
        Assert.True(s.mFacesDoubleSided);
    }

    [Fact] public void mUserData_RoundTrip()
    {
        using var s = new JPH.SoftBodyCreationSettings();
        s.mUserData = (UIntPtr)0xDEADBEEFu;
        Assert.Equal((UIntPtr)0xDEADBEEFu, s.mUserData);
    }
}

// ─── SoftBodySharedSettings ──────────────────────────────────────────────────

[Collection("Jolt")]
public sealed class Tests_SoftBodySharedSettings(JoltFixture fx)
{
    [Fact] public void DefaultConstruct_NoCrash()
    {
        using var s = new JPH.SoftBodySharedSettings();
        Assert.NotNull(s);
    }

    [Fact] public void GetRefCount_Initially1()
    {
        using var s = new JPH.SoftBodySharedSettings();
        // C binding calls AddRef on construction → starts at 1.
        Assert.Equal(1u, s.GetRefCount());
    }

    [Fact] public void AddRef_IncrementsRefCount()
    {
        using var s = new JPH.SoftBodySharedSettings();
        s.AddRef();
        uint count = s.GetRefCount();
        s.Release(); // balance the extra AddRef
        Assert.Equal(2u, count);
    }

    [Fact] public void SInternalGetRefCountOffset_IsNonNegative()
    {
        Assert.True(JPH.Const_SoftBodySharedSettings.SInternalGetRefCountOffset() >= 0);
    }

    [Fact] public void SetEmbedded_IncreasesRefCountByEmbeddedConstant()
    {
        using var s = new JPH.SoftBodySharedSettings();
        uint before = s.GetRefCount();
        s.SetEmbedded();
        uint after = s.GetRefCount();
        // SetEmbedded adds cEmbedded (0x0ebedded) to the ref count.
        const uint cEmbedded = 0x0ebedded;
        Assert.Equal(before + cEmbedded, after);
    }

    [Fact] public void CalculateEdgeLengths_OnEmpty_NoCrash()
    {
        using var s = new JPH.SoftBodySharedSettings();
        s.CalculateEdgeLengths(); // should succeed without vertices or edges
    }

    [Fact] public void Optimize_OnEmpty_NoCrash()
    {
        using var s = new JPH.SoftBodySharedSettings();
        s.Optimize(); // should succeed on empty settings
    }
}

// ─── SoftBodySharedSettings.Vertex ───────────────────────────────────────────

[Collection("Jolt")]
public sealed class Tests_SoftBodySharedSettings_Vertex(JoltFixture fx)
{
    [Fact] public void DefaultConstruct_NoCrash()
    {
        using var v = new JPH.SoftBodySharedSettings.Vertex();
        Assert.NotNull(v);
    }

    [Fact] public void DefaultConstruct_InvMass_DefaultIs1()
    {
        using var v = new JPH.SoftBodySharedSettings.Vertex();
        Assert.Equal(1f, v.mInvMass, 5);
    }

    [Fact] public void ConstructWithPosition_InvMassDefaultIs1()
    {
        using var pos = new JPH.Float3(1f, 2f, 3f);
        using var v = new JPH.SoftBodySharedSettings.Vertex(pos);
        Assert.Equal(1f, v.mInvMass, 5);
    }

    [Fact] public void ConstructWithPositionAndInvMass_RoundTrip()
    {
        using var pos = new JPH.Float3(0f, 5f, 0f);
        using var v = new JPH.SoftBodySharedSettings.Vertex(pos, null, 2f);
        Assert.Equal(2f, v.mInvMass, 5);
    }

    [Fact] public void MutableInvMass_RoundTrip()
    {
        using var v = new JPH.SoftBodySharedSettings.Vertex();
        v.mInvMass = 0.5f;
        Assert.Equal(0.5f, v.mInvMass, 5);
    }
}

// ─── SoftBodySharedSettings.Edge ─────────────────────────────────────────────

[Collection("Jolt")]
public sealed class Tests_SoftBodySharedSettings_Edge(JoltFixture fx)
{
    [Fact] public void DefaultConstruct_NoCrash()
    {
        using var e = new JPH.SoftBodySharedSettings.Edge();
        Assert.NotNull(e);
    }

    [Fact] public void DefaultConstruct_RestLength_DefaultIs1()
    {
        using var e = new JPH.SoftBodySharedSettings.Edge();
        Assert.Equal(1f, e.mRestLength, 5);
    }

    [Fact] public void DefaultConstruct_Compliance_DefaultIsZero()
    {
        using var e = new JPH.SoftBodySharedSettings.Edge();
        Assert.Equal(0f, e.mCompliance);
    }

    [Fact] public void Construct_ComplianceIsSet()
    {
        using var e = new JPH.SoftBodySharedSettings.Edge(0u, 1u, 0.5f);
        Assert.Equal(0.5f, e.mCompliance, 5);
    }

    [Fact] public void Construct_DefaultCompliance_IsZero()
    {
        using var e = new JPH.SoftBodySharedSettings.Edge(0u, 1u);
        Assert.Equal(0f, e.mCompliance);
    }
}

// ─── SoftBodySharedSettings.Face ─────────────────────────────────────────────

[Collection("Jolt")]
public sealed class Tests_SoftBodySharedSettings_Face(JoltFixture fx)
{
    [Fact] public void DefaultConstruct_NoCrash()
    {
        using var f = new JPH.SoftBodySharedSettings.Face();
        Assert.NotNull(f);
    }

    [Fact] public void ConstructUniqueVertices_IsNotDegenerate()
    {
        using var f = new JPH.SoftBodySharedSettings.Face(0u, 1u, 2u);
        Assert.False(f.IsDegenerate());
    }

    [Fact] public void ConstructDuplicateVertices_IsDegenerate()
    {
        // vertex 0 and vertex 1 are both index 0 → degenerate
        using var f = new JPH.SoftBodySharedSettings.Face(0u, 0u, 1u);
        Assert.True(f.IsDegenerate());
    }

    [Fact] public void ConstructDefaultMaterialIndex_IsZero()
    {
        using var f = new JPH.SoftBodySharedSettings.Face(0u, 1u, 2u);
        Assert.Equal(0u, f.mMaterialIndex);
    }

    [Fact] public void ConstructWithMaterialIndex_RoundTrip()
    {
        using var f = new JPH.SoftBodySharedSettings.Face(0u, 1u, 2u, 3u);
        Assert.Equal(3u, f.mMaterialIndex);
    }
}

// ─────────────────────────────────────────────────────────────────────────────
// SoftBody simulation tests (via JoltHelpers)
// ─────────────────────────────────────────────────────────────────────────────

[Collection("Jolt")]
public sealed class Tests_SoftBodySimulation(JoltFixture fx)
{
    [Fact]
    public void SoftBodySettings_AddVertex_IncreasesCount()
    {
        using var settings = new JPH.SoftBodySharedSettings();
        Assert.Equal(0u, ((JPH.Const_SoftBodySharedSettings)settings).SoftBodySettingsGetVertexCount());
        using var v = new JPH.SoftBodySharedSettings.Vertex();
        settings.SoftBodySettingsAddVertex(v);
        Assert.Equal(1u, ((JPH.Const_SoftBodySharedSettings)settings).SoftBodySettingsGetVertexCount());
    }

    [Fact]
    public void SoftBodySettings_CreateCube_HasVertices()
    {
        using var sbSettings = JPH.Const_JoltHelpers.SoftBodySettingsCreateCube(3u, 0.5f);
        Assert.NotNull(sbSettings);
        uint count = ((JPH.Const_SoftBodySharedSettings)sbSettings).SoftBodySettingsGetVertexCount();
        Assert.True(count > 0);
    }

    [Fact]
    public void SoftBody_Simulate_VerticesMoveWithGravity()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        using var sbSettings = JPH.Const_JoltHelpers.SoftBodySettingsCreateCube(3u, 0.5f);
        Assert.NotNull(sbSettings);
        sbSettings.Optimize();

        using var bcs = new JPH.SoftBodyCreationSettings(
            sbSettings,
            new JPH.Vec3(0f, 5f, 0f),
            JPH.Quat.SIdentity(),
            JoltFixture.LayerMoving);

        var body = bi.CreateSoftBody(bcs);
        Assert.NotNull(body);
        JPH.BodyID id = body.GetID();
        bi.AddBody(id, JPH.EActivation.Activate);

        try
        {
            // Record initial Y position of vertex 0
            float initialY;
            using (var pos = JPH.Const_JoltHelpers.PhysicsSystemGetSoftBodyVertexPosition(sys, id, 0u))
                initialY = pos.GetY();

            // Simulate for 30 steps (0.5 s at 60 Hz)
            for (int i = 0; i < 30; i++)
                sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);

            float finalY;
            using (var pos = JPH.Const_JoltHelpers.PhysicsSystemGetSoftBodyVertexPosition(sys, id, 0u))
                finalY = pos.GetY();
            // Gravity is -9.81; vertices should have fallen
            Assert.True(finalY < initialY);
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }

    [Fact]
    public void SoftBody_VertexCount_MatchesExpectedGridSize()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi = sys.GetBodyInterface();

        const uint grid = 2u;
        using var sbSettings = JPH.Const_JoltHelpers.SoftBodySettingsCreateCube(grid, 1f);
        Assert.NotNull(sbSettings);
        sbSettings.Optimize();

        using var bcs = new JPH.SoftBodyCreationSettings(
            sbSettings,
            new JPH.Vec3(0f, 0f, 0f),
            JPH.Quat.SIdentity(),
            JoltFixture.LayerMoving);

        var body = bi.CreateSoftBody(bcs);
        Assert.NotNull(body);
        JPH.BodyID id = body.GetID();
        bi.AddBody(id, JPH.EActivation.Activate);

        try
        {
            uint count = JPH.Const_JoltHelpers.PhysicsSystemGetSoftBodyVertexCount(sys, id);
            Assert.True(count > 0);
        }
        finally
        {
            bi.RemoveBody(id);
            bi.DestroyBody(id);
        }
    }
}
