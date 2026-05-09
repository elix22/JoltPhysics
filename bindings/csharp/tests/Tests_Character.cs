// Tests for Character construction and property getters/setters.
//
// All tests use a CapsuleShape; JPH::Character always creates a body in the
// physics system at construction time and requires a valid shape.
//
// Tested APIs:
//   - Character(settings, position, rotation, userData, system) constructor
//   - GetUp / SetUp round-trip
//   - GetCosMaxSlopeAngle / SetMaxSlopeAngle round-trip
//   - GetGroundState (InAir before any Update)
//   - IsSupported (false before any Update)
//   - GetGroundBodyID (invalid before any Update)
//   - AddToPhysicsSystem / RemoveFromPhysicsSystem
//   - GetBodyID (valid after construction)
//   - GetPosition (matches initial position after add)
//   - GetLinearVelocity / SetLinearVelocity round-trip
//   - GetShape (not null after construction)
//   - PostSimulation (no crash)

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Character(JoltFixture fx)
{
    // Helper: creates a Character with a CapsuleShape. The body is created in
    // the physics system but NOT added to the simulation (not yet broadphased).
    private JPH.Character MakeCharacter(
        JPH.PhysicsSystem sys,
        float x = 0f, float y = 5f, float z = 0f)
    {
        using var cs      = new JPH.CharacterSettings();
        cs.mLayer         = JoltFixture.LayerMoving;
        using var capsule = new JPH.CapsuleShape(0.9f, 0.3f);
        cs.SetShape((JPH.Const_CapsuleShape)capsule);
        using var pos = new JPH.Vec3(x, y, z);
        using var rot = JPH.Quat.SIdentity();
        return new JPH.Character(cs, pos, rot, UIntPtr.Zero, sys);
    }

    // ── Construction ─────────────────────────────────────────────────────────

    [Fact]
    public void Character_Construct_NoCrash()
    {
        using var sys = fx.MakePhysicsSystem();
        using var ch  = MakeCharacter(sys);
        Assert.NotNull(ch);
    }

    // ── Up direction ─────────────────────────────────────────────────────────

    [Fact]
    public void Character_GetUp_DefaultIsYAxis()
    {
        using var sys = fx.MakePhysicsSystem();
        using var ch  = MakeCharacter(sys);
        using var up  = ch.GetUp();
        Assert.Equal(0f, up.GetX(), precision: 5);
        Assert.Equal(1f, up.GetY(), precision: 5);
        Assert.Equal(0f, up.GetZ(), precision: 5);
    }

    [Fact]
    public void Character_SetUp_RoundTrip()
    {
        using var sys   = fx.MakePhysicsSystem();
        using var ch    = MakeCharacter(sys);
        using var newUp = new JPH.Vec3(0f, 0f, 1f);
        ch.SetUp(newUp);
        using var up = ch.GetUp();
        Assert.Equal(0f, up.GetX(), precision: 5);
        Assert.Equal(0f, up.GetY(), precision: 5);
        Assert.Equal(1f, up.GetZ(), precision: 5);
    }

    // ── Slope angle ──────────────────────────────────────────────────────────

    [Fact]
    public void Character_GetCosMaxSlopeAngle_MatchesDefault()
    {
        using var sys = fx.MakePhysicsSystem();
        using var ch  = MakeCharacter(sys);
        float expected = MathF.Cos(50.0f * MathF.PI / 180.0f);
        Assert.Equal(expected, ch.GetCosMaxSlopeAngle(), precision: 5);
    }

    [Fact]
    public void Character_SetMaxSlopeAngle_UpdatesCos()
    {
        using var sys   = fx.MakePhysicsSystem();
        using var ch    = MakeCharacter(sys);
        float angle     = 45.0f * MathF.PI / 180.0f;
        ch.SetMaxSlopeAngle(angle);
        Assert.Equal(MathF.Cos(angle), ch.GetCosMaxSlopeAngle(), precision: 5);
    }

    // ── Ground state (before any Update) ─────────────────────────────────────

    [Fact]
    public void Character_GetGroundState_InAirBeforeUpdate()
    {
        using var sys = fx.MakePhysicsSystem();
        using var ch  = MakeCharacter(sys);
        Assert.Equal(JPH.CharacterBase.EGroundState.InAir, ch.GetGroundState());
    }

    [Fact]
    public void Character_IsSupported_FalseBeforeUpdate()
    {
        using var sys = fx.MakePhysicsSystem();
        using var ch  = MakeCharacter(sys);
        Assert.False(ch.IsSupported());
    }

    [Fact]
    public void Character_GetGroundBodyID_InvalidBeforeUpdate()
    {
        using var sys = fx.MakePhysicsSystem();
        using var ch  = MakeCharacter(sys);
        var id = ch.GetGroundBodyID();
        Assert.True(id.IsInvalid());
    }

    // ── Body ID ───────────────────────────────────────────────────────────────

    [Fact]
    public void Character_GetBodyID_ValidAfterConstruct()
    {
        using var sys = fx.MakePhysicsSystem();
        using var ch  = MakeCharacter(sys);
        var id = ch.GetBodyID();
        Assert.False(id.IsInvalid());
    }

    // ── AddToPhysicsSystem / RemoveFromPhysicsSystem ──────────────────────────

    [Fact]
    public void Character_AddRemove_NoCrash()
    {
        using var sys = fx.MakePhysicsSystem();
        sys.OptimizeBroadPhase();
        using var ch = MakeCharacter(sys);
        ch.AddToPhysicsSystem();
        ch.RemoveFromPhysicsSystem();
    }

    // ── Position ──────────────────────────────────────────────────────────────

    [Fact]
    public void Character_GetPosition_MatchesInitial()
    {
        using var sys = fx.MakePhysicsSystem();
        sys.OptimizeBroadPhase();
        using var ch = MakeCharacter(sys, x: 1f, y: 2f, z: 3f);
        ch.AddToPhysicsSystem();
        using var pos = ch.GetPosition();
        Assert.Equal(1f, pos.GetX(), precision: 4);
        Assert.Equal(2f, pos.GetY(), precision: 4);
        Assert.Equal(3f, pos.GetZ(), precision: 4);
        ch.RemoveFromPhysicsSystem();
    }

    // ── Linear velocity ───────────────────────────────────────────────────────

    [Fact]
    public void Character_SetLinearVelocity_GetLinearVelocity_RoundTrip()
    {
        using var sys = fx.MakePhysicsSystem();
        sys.OptimizeBroadPhase();
        using var ch = MakeCharacter(sys);
        ch.AddToPhysicsSystem();
        using var v = new JPH.Vec3(1f, 2f, 3f);
        ch.SetLinearVelocity(v);
        using var got = ch.GetLinearVelocity();
        Assert.Equal(1f, got.GetX(), precision: 4);
        Assert.Equal(2f, got.GetY(), precision: 4);
        Assert.Equal(3f, got.GetZ(), precision: 4);
        ch.RemoveFromPhysicsSystem();
    }

    // ── Shape ─────────────────────────────────────────────────────────────────

    [Fact]
    public void Character_GetShape_NotNullAfterConstruct()
    {
        using var sys = fx.MakePhysicsSystem();
        using var ch  = MakeCharacter(sys);
        var shape = ch.GetShape();
        Assert.NotNull(shape);
    }

    // ── PostSimulation ────────────────────────────────────────────────────────

    [Fact]
    public void Character_PostSimulation_NoCrash()
    {
        using var sys = fx.MakePhysicsSystem();
        sys.OptimizeBroadPhase();
        using var ch = MakeCharacter(sys);
        ch.AddToPhysicsSystem();
        sys.Update(1f / 60f, 1, fx.Alloc, fx.Jobs);
        var ex = Record.Exception(() => ch.PostSimulation(0.05f));
        Assert.Null(ex);
        ch.RemoveFromPhysicsSystem();
    }
}
