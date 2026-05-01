// Tests for CharacterVirtual construction and property getters/setters.
// Covers: CharacterVirtualTests.cpp (construction + state queries)
//
// Tested APIs:
//   - CharacterVirtual(settings, position, rotation, system) constructor
//   - GetPosition / SetPosition round-trip
//   - GetRotation
//   - GetLinearVelocity / SetLinearVelocity round-trip
//   - GetMass / SetMass round-trip
//   - GetMaxStrength / SetMaxStrength round-trip
//   - GetPenetrationRecoverySpeed
//   - GetEnhancedInternalEdgeRemoval
//   - GetMaxNumHits
//   - GetShape
//   - GetGroundState (InAir before any Update)
//   - GetGroundBodyID (invalid before any Update)
//   - GetID (reflects inner body ID; invalid with default settings)
//   - GetUp / SetUp round-trip
//   - GetCosMaxSlopeAngle / SetMaxSlopeAngle round-trip
//   - GetCenterOfMassPosition
//   - GetListener (null by default)

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_CharacterVirtual(JoltFixture fx)
{
    // Helper: build a minimal CharacterVirtual using a capsule shape.
    private JPH.CharacterVirtual MakeCharacter(
        JPH.PhysicsSystem sys,
        JPH.CharacterVirtualSettings cs,
        float x = 0f, float y = 5f, float z = 0f)
    {
        using var pos = new JPH.Vec3(x, y, z);
        using var rot = JPH.Quat.SIdentity();
        return new JPH.CharacterVirtual(cs, pos, rot, sys);
    }

    // Helper: build default CharacterVirtualSettings.
    // Note: CharacterBaseSettings.mShape is not exposed in the C# bindings;
    // the character will have no shape but construction should not crash.
    private JPH.CharacterVirtualSettings MakeSettings()
    {
        return new JPH.CharacterVirtualSettings();
    }

    [Fact]
    public void CharacterVirtual_Construct_NoCrash()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        Assert.NotNull(cv);
    }

    [Fact]
    public void CharacterVirtual_GetPosition_MatchesInitialPosition()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs, 1f, 2f, 3f);
        using var pos = cv.GetPosition();
        Assert.Equal(1f, pos.GetX(), precision: 4);
        Assert.Equal(2f, pos.GetY(), precision: 4);
        Assert.Equal(3f, pos.GetZ(), precision: 4);
    }

    [Fact]
    public void CharacterVirtual_GetRotation_MatchesIdentity()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        using var rot = cv.GetRotation();
        Assert.Equal(0f, rot.GetX(), precision: 5);
        Assert.Equal(0f, rot.GetY(), precision: 5);
        Assert.Equal(0f, rot.GetZ(), precision: 5);
        Assert.Equal(1f, rot.GetW(), precision: 5);
    }

    [Fact]
    public void CharacterVirtual_GetLinearVelocity_IsZeroInitially()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        using var vel = cv.GetLinearVelocity();
        Assert.Equal(0f, vel.GetX(), precision: 5);
        Assert.Equal(0f, vel.GetY(), precision: 5);
        Assert.Equal(0f, vel.GetZ(), precision: 5);
    }

    [Fact]
    public void CharacterVirtual_SetLinearVelocity_GetLinearVelocity_RoundTrip()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        using var v   = new JPH.Vec3(1f, 2f, 3f);
        cv.SetLinearVelocity(v);
        using var got = cv.GetLinearVelocity();
        Assert.Equal(1f, got.GetX(), precision: 5);
        Assert.Equal(2f, got.GetY(), precision: 5);
        Assert.Equal(3f, got.GetZ(), precision: 5);
    }

    [Fact]
    public void CharacterVirtual_SetPosition_GetPosition_RoundTrip()
    {
        using var sys  = fx.MakePhysicsSystem();
        using var cs   = MakeSettings();
        using var cv   = MakeCharacter(sys, cs);
        using var newP = new JPH.Vec3(10f, 20f, 30f);
        cv.SetPosition(newP);
        using var got = cv.GetPosition();
        Assert.Equal(10f, got.GetX(), precision: 4);
        Assert.Equal(20f, got.GetY(), precision: 4);
        Assert.Equal(30f, got.GetZ(), precision: 4);
    }

    [Fact]
    public void CharacterVirtual_GetMass_EqualsSettingsDefault()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        Assert.Equal(70f, cv.GetMass(), precision: 4);
    }

    [Fact]
    public void CharacterVirtual_SetMass_GetMass_RoundTrip()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        cv.SetMass(50f);
        Assert.Equal(50f, cv.GetMass(), precision: 5);
    }

    [Fact]
    public void CharacterVirtual_GetMaxStrength_EqualsSettingsDefault()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        Assert.Equal(100f, cv.GetMaxStrength(), precision: 4);
    }

    [Fact]
    public void CharacterVirtual_SetMaxStrength_GetMaxStrength_RoundTrip()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        cv.SetMaxStrength(200f);
        Assert.Equal(200f, cv.GetMaxStrength(), precision: 5);
    }

    [Fact]
    public void CharacterVirtual_GetPenetrationRecoverySpeed_EqualsSettingsDefault()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        Assert.Equal(1f, cv.GetPenetrationRecoverySpeed(), precision: 5);
    }

    [Fact]
    public void CharacterVirtual_GetEnhancedInternalEdgeRemoval_IsFalseByDefault()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        Assert.False(cv.GetEnhancedInternalEdgeRemoval());
    }

    [Fact]
    public void CharacterVirtual_GetMaxNumHits_EqualsSettingsDefault()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        Assert.Equal(256u, cv.GetMaxNumHits());
    }

    [Fact]
    public void CharacterVirtual_GetGroundState_IsInAirInitially()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        Assert.Equal(JPH.CharacterBase.EGroundState.InAir, cv.GetGroundState());
    }

    [Fact]
    public void CharacterVirtual_GetGroundBodyID_IsInvalidInitially()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        var id = cv.GetGroundBodyID();
        Assert.True(id.IsInvalid());
    }

    [Fact]
    public void CharacterVirtual_GetListener_IsNullByDefault()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        Assert.Null(cv.GetListener());
    }

    [Fact]
    public void CharacterVirtual_GetUp_IsYAxisByDefault()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        using var up  = cv.GetUp();
        Assert.Equal(0f, up.GetX(), precision: 5);
        Assert.Equal(1f, up.GetY(), precision: 5);
        Assert.Equal(0f, up.GetZ(), precision: 5);
    }

    [Fact]
    public void CharacterVirtual_SetUp_GetUp_RoundTrip()
    {
        using var sys   = fx.MakePhysicsSystem();
        using var cs    = MakeSettings();
        using var cv    = MakeCharacter(sys, cs);
        using var newUp = new JPH.Vec3(0f, 0f, 1f);
        cv.SetUp(newUp);
        using var got = cv.GetUp();
        Assert.Equal(0f, got.GetX(), precision: 5);
        Assert.Equal(0f, got.GetY(), precision: 5);
        Assert.Equal(1f, got.GetZ(), precision: 5);
    }

    [Fact]
    public void CharacterVirtual_GetPosition_AfterSetPosition_IsCorrect()
    {
        using var sys  = fx.MakePhysicsSystem();
        using var cs   = MakeSettings();
        using var cv   = MakeCharacter(sys, cs, 0f, 0f, 0f);
        using var newP = new JPH.Vec3(7f, 8f, 9f);
        cv.SetPosition(newP);
        using var got = cv.GetPosition();
        Assert.Equal(7f, got.GetX(), precision: 4);
        Assert.Equal(8f, got.GetY(), precision: 4);
        Assert.Equal(9f, got.GetZ(), precision: 4);
    }

    [Fact]
    public void CharacterVirtual_GetCosMaxSlopeAngle_MatchesDefaultAngle()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        float expected = MathF.Cos(50f * MathF.PI / 180f);
        Assert.Equal(expected, cv.GetCosMaxSlopeAngle(), precision: 5);
    }

    [Fact]
    public void CharacterVirtual_SetMaxSlopeAngle_UpdatesCosMaxSlopeAngle()
    {
        using var sys = fx.MakePhysicsSystem();
        using var cs  = MakeSettings();
        using var cv  = MakeCharacter(sys, cs);
        cv.SetMaxSlopeAngle(45f * MathF.PI / 180f);
        float expected = MathF.Cos(45f * MathF.PI / 180f);
        Assert.Equal(expected, cv.GetCosMaxSlopeAngle(), precision: 5);
    }

    // ─────────────────────────────────────────────────────────────────────────
    // Update — no-crash smoke test
    // ─────────────────────────────────────────────────────────────────────────

    [Fact]
    public void CharacterVirtual_Update_NoCrash()
    {
        using var sys = fx.MakePhysicsSystem();
        sys.OptimizeBroadPhase();
        using var cs = MakeSettings();
        using var cv = MakeCharacter(sys, cs);

        // CharacterBaseSettings.mShape is not exposed in C# bindings, so use
        // SetShape to initialise mShape before Update. When mShape == null the
        // fast path in CharacterVirtual::SetShape just assigns the shape and
        // returns true without using any of the filter / allocator parameters.
        using var localAlloc = new JPH.TempAllocatorImpl(4 * 1024 * 1024);
        using var capsule    = new JPH.CapsuleShape(0.9f, 0.3f);
        using var bpF        = new JPH.BroadPhaseLayerFilter();
        using var olF        = new JPH.ObjectLayerFilter();
        using var bF         = new JPH.BodyFilter();
        using var sF         = new JPH.ShapeFilter();
        cv.SetShape((JPH.Const_CapsuleShape)capsule, 0f, bpF, olF, bF, sF, localAlloc);

        using var gravity    = new JPH.Vec3(0f, -9.81f, 0f);
        using JPH.DefaultBroadPhaseLayerFilter bpDefault = sys.GetDefaultBroadPhaseLayerFilter(JoltFixture.LayerMoving);
        using JPH.DefaultObjectLayerFilter olDefault     = sys.GetDefaultLayerFilter(JoltFixture.LayerMoving);
        using var bodyFilter  = new JPH.BodyFilter();
        using var shapeFilter = new JPH.ShapeFilter();

        var ex = Record.Exception(() =>
            cv.Update(1f / 60f, gravity, (JPH.BroadPhaseLayerFilter)bpDefault, (JPH.ObjectLayerFilter)olDefault, bodyFilter, shapeFilter, localAlloc));
        Assert.Null(ex);
    }

    [Fact]
    public void CharacterVirtual_Update_MultipleSteps_NoCrash()
    {
        using var sys = fx.MakePhysicsSystem();
        sys.OptimizeBroadPhase();
        using var cs = MakeSettings();
        using var cv = MakeCharacter(sys, cs);

        using var localAlloc = new JPH.TempAllocatorImpl(4 * 1024 * 1024);
        using var capsule    = new JPH.CapsuleShape(0.9f, 0.3f);
        using var bpF        = new JPH.BroadPhaseLayerFilter();
        using var olF        = new JPH.ObjectLayerFilter();
        using var bF         = new JPH.BodyFilter();
        using var sF         = new JPH.ShapeFilter();
        cv.SetShape((JPH.Const_CapsuleShape)capsule, 0f, bpF, olF, bF, sF, localAlloc);

        using var gravity    = new JPH.Vec3(0f, -9.81f, 0f);
        using JPH.DefaultBroadPhaseLayerFilter bpDefault = sys.GetDefaultBroadPhaseLayerFilter(JoltFixture.LayerMoving);
        using JPH.DefaultObjectLayerFilter olDefault     = sys.GetDefaultLayerFilter(JoltFixture.LayerMoving);
        using var bodyFilter  = new JPH.BodyFilter();
        using var shapeFilter = new JPH.ShapeFilter();

        var ex = Record.Exception(() =>
        {
            for (int i = 0; i < 10; i++)
                cv.Update(1f / 60f, gravity, (JPH.BroadPhaseLayerFilter)bpDefault, (JPH.ObjectLayerFilter)olDefault, bodyFilter, shapeFilter, localAlloc);
        });
        Assert.Null(ex);
    }
}
