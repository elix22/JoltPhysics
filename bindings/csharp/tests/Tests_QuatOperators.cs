// Quat operator and utility tests, modelled on Jolt's QuatTests.cpp (remaining coverage).
// Covers mutators, IsNaN, arithmetic operators, compound operators,
// GetPerpendicular, EnsureWPositive, SMultiplyImaginary,
// LERP (exact value), SLERP (sign-invariant), CompressUnitQuat round-trip,
// GetTwist, and GetSwingTwist decomposition.

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_QuatOperators
{
    // ── Mutators ──────────────────────────────────────────────────────────────

    [Fact]
    public void Quat_Set_UpdatesAllComponents()
    {
        var q = JPH.Quat.SIdentity();
        q.Set(1f, 2f, 3f, 4f);
        Assert.Equal(1f, q.GetX());
        Assert.Equal(2f, q.GetY());
        Assert.Equal(3f, q.GetZ());
        Assert.Equal(4f, q.GetW());
    }

    [Fact]
    public void Quat_SetXYZW_UpdatesIndividualComponents()
    {
        var q = JPH.Quat.SIdentity();   // (0, 0, 0, 1)
        q.SetX(5f); q.SetY(6f); q.SetZ(7f); q.SetW(8f);
        Assert.Equal(5f, q.GetX());
        Assert.Equal(6f, q.GetY());
        Assert.Equal(7f, q.GetZ());
        Assert.Equal(8f, q.GetW());
    }

    // ── IsNaN ─────────────────────────────────────────────────────────────────

    [Fact]
    public void Quat_IsNaN_AllFinite_IsFalse()
    {
        Assert.False(JPH.Quat.SZero().IsNaN());
        Assert.False(new JPH.Quat(1f, 2f, 3f, 4f).IsNaN());
    }

    [Fact]
    public void Quat_IsNaN_NaNInX_IsTrue()
    {
        Assert.True(new JPH.Quat(float.NaN, 0f, 0f, 0f).IsNaN());
    }

    [Fact]
    public void Quat_IsNaN_NaNInW_IsTrue()
    {
        Assert.True(new JPH.Quat(0f, 0f, 0f, float.NaN).IsNaN());
    }

    // ── Arithmetic operators ──────────────────────────────────────────────────

    [Fact]
    public void Quat_Negate_AllComponentsNegated()
    {
        var n = -new JPH.Quat(1f, 2f, 3f, 4f);
        Assert.Equal(-1f, n.GetX());
        Assert.Equal(-2f, n.GetY());
        Assert.Equal(-3f, n.GetZ());
        Assert.Equal(-4f, n.GetW());
    }

    [Fact]
    public void Quat_Add_ComponentwiseSum()
    {
        var r = new JPH.Quat(1f, 2f, 3f, 4f) + new JPH.Quat(5f, 6f, 7f, 8f);
        Assert.Equal(6f,  r.GetX());
        Assert.Equal(8f,  r.GetY());
        Assert.Equal(10f, r.GetZ());
        Assert.Equal(12f, r.GetW());
    }

    [Fact]
    public void Quat_Subtract_ComponentwiseDiff()
    {
        var r = new JPH.Quat(5f, 6f, 7f, 8f) - new JPH.Quat(1f, 2f, 3f, 4f);
        Assert.Equal(4f, r.GetX());
        Assert.Equal(4f, r.GetY());
        Assert.Equal(4f, r.GetZ());
        Assert.Equal(4f, r.GetW());
    }

    [Fact]
    public void Quat_MultiplyScalar_ScalesAll()
    {
        var r = new JPH.Quat(1f, 2f, 3f, 4f) * 2f;
        Assert.Equal(2f, r.GetX());
        Assert.Equal(4f, r.GetY());
        Assert.Equal(6f, r.GetZ());
        Assert.Equal(8f, r.GetW());
    }

    [Fact]
    public void Quat_DivideScalar_DividesAll()
    {
        var r = new JPH.Quat(2f, 4f, 6f, 8f) / 2f;
        Assert.Equal(1f, r.GetX());
        Assert.Equal(2f, r.GetY());
        Assert.Equal(3f, r.GetZ());
        Assert.Equal(4f, r.GetW());
    }

    // ── Compound operators ────────────────────────────────────────────────────

    [Fact]
    public void Quat_CompoundAdd_MutatesInPlace()
    {
        var q = new JPH.Quat(1f, 2f, 3f, 4f);
        q += new JPH.Quat(5f, 6f, 7f, 8f);
        Assert.Equal(6f,  q.GetX());
        Assert.Equal(8f,  q.GetY());
        Assert.Equal(10f, q.GetZ());
        Assert.Equal(12f, q.GetW());
    }

    [Fact]
    public void Quat_CompoundSubtract_MutatesInPlace()
    {
        var q = new JPH.Quat(5f, 6f, 7f, 8f);
        q -= new JPH.Quat(1f, 2f, 3f, 4f);
        Assert.Equal(4f, q.GetX());
        Assert.Equal(4f, q.GetY());
        Assert.Equal(4f, q.GetZ());
        Assert.Equal(4f, q.GetW());
    }

    [Fact]
    public void Quat_CompoundMultiplyScalar_MutatesInPlace()
    {
        var q = new JPH.Quat(1f, 2f, 3f, 4f);
        q *= 2f;
        Assert.Equal(2f, q.GetX());
        Assert.Equal(4f, q.GetY());
        Assert.Equal(6f, q.GetZ());
        Assert.Equal(8f, q.GetW());
    }

    [Fact]
    public void Quat_CompoundDivideScalar_MutatesInPlace()
    {
        var q = new JPH.Quat(2f, 4f, 6f, 8f);
        q /= 2f;
        Assert.Equal(1f, q.GetX());
        Assert.Equal(2f, q.GetY());
        Assert.Equal(3f, q.GetZ());
        Assert.Equal(4f, q.GetW());
    }

    // ── GetPerpendicular ──────────────────────────────────────────────────────

    [Fact]
    public void Quat_GetPerpendicular_DotWithOriginalIsZero()
    {
        var q = new JPH.Quat(1f, 2f, 3f, 4f).Normalized();
        var p = q.GetPerpendicular();
        float dot = q.GetX() * p.GetX() + q.GetY() * p.GetY()
                  + q.GetZ() * p.GetZ() + q.GetW() * p.GetW();
        Assert.Equal(0f, dot, precision: 5);
    }

    // ── EnsureWPositive ───────────────────────────────────────────────────────

    [Fact]
    public void Quat_EnsureWPositive_WAlreadyPositive_Unchanged()
    {
        var q = new JPH.Quat(1f, 2f, 3f, 4f);
        var r = q.EnsureWPositive();
        Assert.Equal(q.GetX(), r.GetX());
        Assert.Equal(q.GetY(), r.GetY());
        Assert.Equal(q.GetZ(), r.GetZ());
        Assert.Equal(q.GetW(), r.GetW());
    }

    [Fact]
    public void Quat_EnsureWPositive_WNegative_AllNegated()
    {
        var q = new JPH.Quat(1f, 2f, 3f, -4f);
        var r = q.EnsureWPositive();
        Assert.Equal(-1f, r.GetX());
        Assert.Equal(-2f, r.GetY());
        Assert.Equal(-3f, r.GetZ());
        Assert.Equal( 4f, r.GetW());
    }

    // ── SMultiplyImaginary ────────────────────────────────────────────────────

    [Fact]
    public void Quat_SMultiplyImaginary_MatchesVec4Constructor()
    {
        // sMultiplyImaginary(im, q) == Quat(Vec4(im, 0)) * q
        var im   = new JPH.Vec3(1f, 2f, 3f);
        var quat = new JPH.Quat(0.5f, 0.5f, 0.5f, 0.5f);   // normalized

        var r1 = JPH.Quat.SMultiplyImaginary(im, quat);
        var r2 = new JPH.Quat(new JPH.Vec4(im, 0f)) * quat;

        Assert.Equal((double)r2.GetX(), (double)r1.GetX(), 5);
        Assert.Equal((double)r2.GetY(), (double)r1.GetY(), 5);
        Assert.Equal((double)r2.GetZ(), (double)r1.GetZ(), 5);
        Assert.Equal((double)r2.GetW(), (double)r1.GetW(), 5);
    }

    // ── LERP exact value ─────────────────────────────────────────────────────

    [Fact]
    public void Quat_LERP_Quarter_ExactResult()
    {
        // From QuatTests.cpp: Quat(1,2,3,4).LERP(Quat(5,6,7,8), 0.25) == Quat(2,3,4,5)
        var v1 = new JPH.Quat(1f, 2f, 3f, 4f);
        var v2 = new JPH.Quat(5f, 6f, 7f, 8f);
        var r  = v1.LERP(v2, 0.25f);
        Assert.Equal(2f, r.GetX());
        Assert.Equal(3f, r.GetY());
        Assert.Equal(4f, r.GetZ());
        Assert.Equal(5f, r.GetW());
    }

    // ── SLERP ────────────────────────────────────────────────────────────────

    [Fact]
    public void Quat_SLERP_Quarter_MatchesExpectedRotation()
    {
        var axisX    = new JPH.Vec3(1f, 0f, 0f);
        var v1       = JPH.Quat.SIdentity();
        var v2       = JPH.Quat.SRotation(axisX, 0.99f * MathF.PI);
        var expected = JPH.Quat.SRotation(axisX, 0.25f * 0.99f * MathF.PI);
        Assert.True(v1.SLERP(v2, 0.25f).IsClose(expected, 1e-6f));
    }

    [Fact]
    public void Quat_SLERP_NegatedTarget_SignIgnored()
    {
        // SLERP(q, -q, 0.5) should equal q because -q is the same rotation.
        var v3 = new JPH.Quat(1f, 2f, 3f, 4f).Normalized();
        Assert.True(v3.SLERP(-v3, 0.5f).IsClose(v3, 1e-6f));
    }

    // ── CompressUnitQuat round-trip ───────────────────────────────────────────

    [Fact]
    public void Quat_CompressUnitQuat_AngularErrorBelowThreshold()
    {
        // Compress then decompress: the angular difference must be < 0.009 rad.
        var quat         = JPH.Quat.SRotation(new JPH.Vec3(1f, 0f, 0f), 1.23f);
        uint compressed  = quat.CompressUnitQuat();
        var decompressed = JPH.Quat.SDecompressUnitQuat(compressed);

        var diff     = quat * decompressed.Conjugated();
        var outAxis  = new JPH.Vec3();
        float angle  = 0f;
        diff.GetAxisAngle(outAxis, ref angle);
        Assert.True(MathF.Abs(angle) < 0.009f);
    }

    // ── GetTwist ─────────────────────────────────────────────────────────────

    [Fact]
    public void Quat_GetTwist_AroundRotationAxis_IsFullRotation()
    {
        // For a pure X-axis rotation, the twist around X equals (or negates) the full rotation.
        var q     = JPH.Quat.SRotation(new JPH.Vec3(1f, 0f, 0f), 1.0f);
        var twist = q.GetTwist(new JPH.Vec3(1f, 0f, 0f));
        Assert.True(q.IsClose(twist, 1e-5f) || q.IsClose(-twist, 1e-5f));
    }

    [Fact]
    public void Quat_GetTwist_AroundPerpendicularAxis_IsNearIdentity()
    {
        // For a pure X-axis rotation, the twist around Y should be identity.
        var q     = JPH.Quat.SRotation(new JPH.Vec3(1f, 0f, 0f), 1.0f);
        var twist = q.GetTwist(new JPH.Vec3(0f, 1f, 0f));
        Assert.True(twist.IsClose(JPH.Quat.SIdentity(), 1e-5f));
    }

    // ── GetSwingTwist ────────────────────────────────────────────────────────

    [Fact]
    public void Quat_GetSwingTwist_SwingTimesTwist_RecomposesToOriginal()
    {
        // swing * twist should equal q (or its negation, since q and -q are the same rotation).
        using var normalizedAxis = new JPH.Vec3(1f, 1f, 0f).Normalized();
        var q        = JPH.Quat.SRotation(normalizedAxis, 1.23f);
        var outSwing = new JPH.Quat();
        var outTwist = new JPH.Quat();
        q.GetSwingTwist(outSwing, outTwist);
        var recomposed = outSwing * outTwist;
        Assert.True(q.IsClose(recomposed, 1e-5f) || q.IsClose(-recomposed, 1e-5f));
    }
}
