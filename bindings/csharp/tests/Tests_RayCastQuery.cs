// Tests for:
//   - JPH::RayCast / RRayCast construction and field access
//   - JPH::NarrowPhaseQuery::CastRay (single hit)
//   - JPH::BodyInterface::GetTransformedShape
//   - JPH::TransformedShape::CastRay, GetWorldSpaceBounds, GetCenterOfMassTransform

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_RayCastQuery(JoltFixture fx)
{
    // Helper — creates and adds a static box at given position.
    static JPH.BodyID AddStaticBox(JPH.BodyInterface bi, float x, float y, float z, float halfExtent = 1.0f)
    {
        using var bs = new JPH.BoxShapeSettings(new JPH.Vec3(halfExtent, halfExtent, halfExtent));
        using var cs = new JPH.BodyCreationSettings();
        cs.SetShapeSettings((JPH.Const_BoxShapeSettings)bs);
        cs.mMotionType  = JPH.EMotionType.Static;
        cs.mObjectLayer = JoltFixture.LayerNonMoving;
        cs.mPosition.Set(x, y, z);
        return bi.CreateAndAddBody(cs, JPH.EActivation.DontActivate);
    }

    // -------------------------------------------------------------------------
    // RRayCast construction
    // -------------------------------------------------------------------------

    [Fact]
    public void RRayCast_DefaultConstruct_NoCrash()
    {
        using var r = new JPH.RRayCast();
        Assert.NotNull(r);
    }

    [Fact]
    public void RRayCast_ConstructWithOriginDir_Fields()
    {
        using var origin = new JPH.Vec3(1.0f, 2.0f, 3.0f);
        using var dir    = new JPH.Vec3(0.0f, -1.0f, 0.0f);
        using var r = new JPH.RRayCast(origin, dir);
        Assert.Equal(1.0f, r.mOrigin.GetX(), 1e-5f);
        Assert.Equal(2.0f, r.mOrigin.GetY(), 1e-5f);
        Assert.Equal(3.0f, r.mOrigin.GetZ(), 1e-5f);
        Assert.Equal(0.0f,  r.mDirection.GetX(), 1e-5f);
        Assert.Equal(-1.0f, r.mDirection.GetY(), 1e-5f);
        Assert.Equal(0.0f,  r.mDirection.GetZ(), 1e-5f);
    }

    // -------------------------------------------------------------------------
    // NarrowPhaseQuery.CastRay — miss (empty world)
    // -------------------------------------------------------------------------

    [Fact]
    public void NarrowPhaseQuery_CastRay_EmptyWorld_ReturnsFalse()
    {
        using var sys = fx.MakePhysicsSystem();
        var npq = sys.GetNarrowPhaseQuery();
        using var origin = new JPH.Vec3(0.0f, 10.0f, 0.0f);
        using var dir    = new JPH.Vec3(0.0f, -20.0f, 0.0f);
        using var ray    = new JPH.RRayCast(origin, dir);
        using var hit    = new JPH.RayCastResult();
        bool found = npq.CastRay(ray, hit);
        Assert.False(found);
    }

    // -------------------------------------------------------------------------
    // NarrowPhaseQuery.CastRay — hit a static box
    // -------------------------------------------------------------------------

    [Fact]
    public void NarrowPhaseQuery_CastRay_HitsStaticBox_ReturnsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddStaticBox(bi, 0.0f, 0.0f, 0.0f);

        var npq = sys.GetNarrowPhaseQuery();
        using var origin = new JPH.Vec3(0.0f, 5.0f, 0.0f);
        using var dir    = new JPH.Vec3(0.0f, -10.0f, 0.0f);
        using var ray    = new JPH.RRayCast(origin, dir);
        using var hit    = new JPH.RayCastResult();
        bool found = npq.CastRay(ray, hit);

        Assert.True(found);
        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void NarrowPhaseQuery_CastRay_Hit_FractionInRange()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddStaticBox(bi, 0.0f, 0.0f, 0.0f);

        var npq = sys.GetNarrowPhaseQuery();
        using var origin = new JPH.Vec3(0.0f, 5.0f, 0.0f);
        using var dir    = new JPH.Vec3(0.0f, -10.0f, 0.0f);
        using var ray    = new JPH.RRayCast(origin, dir);
        using var hit    = new JPH.RayCastResult();
        npq.CastRay(ray, hit);

        Assert.True(hit.mFraction >= 0.0f);
        Assert.True(hit.mFraction <= 1.0f);

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void NarrowPhaseQuery_CastRay_Hit_BodyIDMatchesAdded()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddStaticBox(bi, 0.0f, 0.0f, 0.0f);

        var npq = sys.GetNarrowPhaseQuery();
        using var origin = new JPH.Vec3(0.0f, 5.0f, 0.0f);
        using var dir    = new JPH.Vec3(0.0f, -10.0f, 0.0f);
        using var ray    = new JPH.RRayCast(origin, dir);
        using var hit    = new JPH.RayCastResult();
        npq.CastRay(ray, hit);

        Assert.Equal(id.GetIndexAndSequenceNumber(), hit.mBodyID.GetIndexAndSequenceNumber());

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    // -------------------------------------------------------------------------
    // NarrowPhaseQuery.CastRay — miss (ray parallel, offset)
    // -------------------------------------------------------------------------

    [Fact]
    public void NarrowPhaseQuery_CastRay_MissSide_ReturnsFalse()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddStaticBox(bi, 0.0f, 0.0f, 0.0f);

        var npq = sys.GetNarrowPhaseQuery();
        // Ray fired far to the side — box has half-extent 1, so X=5 is a clear miss
        using var origin = new JPH.Vec3(5.0f, 5.0f, 0.0f);
        using var dir    = new JPH.Vec3(0.0f, -10.0f, 0.0f);
        using var ray    = new JPH.RRayCast(origin, dir);
        using var hit    = new JPH.RayCastResult();
        bool found = npq.CastRay(ray, hit);

        Assert.False(found);

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    // -------------------------------------------------------------------------
    // BodyInterface.GetTransformedShape
    // -------------------------------------------------------------------------

    [Fact]
    public void BodyInterface_GetTransformedShape_NoCrash()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddStaticBox(bi, 1.0f, 2.0f, 3.0f);

        using var ts = bi.GetTransformedShape(id);
        Assert.NotNull(ts);

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void BodyInterface_GetTransformedShape_BodyIDMatches()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddStaticBox(bi, 1.0f, 2.0f, 3.0f);

        using var ts = bi.GetTransformedShape(id);
        Assert.Equal(id.GetIndexAndSequenceNumber(), ts.mBodyID.GetIndexAndSequenceNumber());

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void BodyInterface_GetTransformedShape_PositionMatchesCreation()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddStaticBox(bi, 1.0f, 2.0f, 3.0f);

        using var ts = bi.GetTransformedShape(id);
        var pos = ts.mShapePositionCOM;
        // Center of mass for a box is at its center
        Assert.Equal(1.0f, pos.GetX(), 1e-4f);
        Assert.Equal(2.0f, pos.GetY(), 1e-4f);
        Assert.Equal(3.0f, pos.GetZ(), 1e-4f);

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    // -------------------------------------------------------------------------
    // TransformedShape.GetWorldSpaceBounds
    // -------------------------------------------------------------------------

    [Fact]
    public void TransformedShape_GetWorldSpaceBounds_Valid()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddStaticBox(bi, 0.0f, 0.0f, 0.0f, 1.0f);

        using var ts     = bi.GetTransformedShape(id);
        using var bounds = ts.GetWorldSpaceBounds();
        // Box half-extent=1, centered at origin → min≈(-1,-1,-1), max≈(1,1,1)
        Assert.True(bounds.mMin.GetX() < 0.0f);
        Assert.True(bounds.mMax.GetX() > 0.0f);
        Assert.True(bounds.mMax.GetX() > bounds.mMin.GetX());

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    // -------------------------------------------------------------------------
    // TransformedShape.CastRay
    // -------------------------------------------------------------------------

    [Fact]
    public void TransformedShape_CastRay_HitsShape_ReturnsTrue()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddStaticBox(bi, 0.0f, 0.0f, 0.0f);

        using var ts = bi.GetTransformedShape(id);

        using var origin = new JPH.Vec3(0.0f, 5.0f, 0.0f);
        using var dir    = new JPH.Vec3(0.0f, -10.0f, 0.0f);
        using var ray    = new JPH.RRayCast(origin, dir);
        using var hit    = new JPH.RayCastResult();
        bool found = ts.CastRay(ray, hit);

        Assert.True(found);
        Assert.True(hit.mFraction >= 0.0f && hit.mFraction <= 1.0f);

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }

    [Fact]
    public void TransformedShape_CastRay_MissesShape_ReturnsFalse()
    {
        using var sys = fx.MakePhysicsSystem();
        var bi  = sys.GetBodyInterface();
        var id  = AddStaticBox(bi, 0.0f, 0.0f, 0.0f);

        using var ts = bi.GetTransformedShape(id);

        using var origin = new JPH.Vec3(5.0f, 5.0f, 0.0f);
        using var dir    = new JPH.Vec3(0.0f, -10.0f, 0.0f);
        using var ray    = new JPH.RRayCast(origin, dir);
        using var hit    = new JPH.RayCastResult();
        bool found = ts.CastRay(ray, hit);

        Assert.False(found);

        bi.RemoveBody(id);
        bi.DestroyBody(id);
    }
}
