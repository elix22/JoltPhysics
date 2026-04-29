// Extended Quat tests based on Jolt's own QuatTests.cpp.
// Covers identity, conjugation, inversion, LERP/SLERP,
// SFromTo, Euler angles round-trip, axis rotation helpers,
// GetAxisAngle, and compression round-trips.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_QuatExtended
{
    // ── Factory / components ──────────────────────────────────────────────────

    [Fact]
    public void Quat_SIdentity_IsXYZ0W1()
    {
        using var q = JPH.Quat.SIdentity();
        Assert.Equal(0f, q.GetX(), precision: 7);
        Assert.Equal(0f, q.GetY(), precision: 7);
        Assert.Equal(0f, q.GetZ(), precision: 7);
        Assert.Equal(1f, q.GetW(), precision: 7);
    }

    [Fact]
    public void Quat_SIdentity_IsNormalized()
    {
        using var q = JPH.Quat.SIdentity();
        Assert.True(q.IsNormalized());
    }

    [Fact]
    public void Quat_SZero_AllComponentsZero()
    {
        using var q = JPH.Quat.SZero();
        Assert.Equal(0f, q.GetX(), precision: 7);
        Assert.Equal(0f, q.GetY(), precision: 7);
        Assert.Equal(0f, q.GetZ(), precision: 7);
        Assert.Equal(0f, q.GetW(), precision: 7);
    }

    // ── Conjugated ───────────────────────────────────────────────────────────

    [Fact]
    public void Quat_Conjugated_NegatesXYZ()
    {
        // Jolt: Conjugated of (1,2,3,4) = (-1,-2,-3,4)
        using var q = new JPH.Quat(1f, 2f, 3f, 4f);
        using var c = q.Conjugated();
        Assert.Equal(-1f, c.GetX(), precision: 6);
        Assert.Equal(-2f, c.GetY(), precision: 6);
        Assert.Equal(-3f, c.GetZ(), precision: 6);
        Assert.Equal( 4f, c.GetW(), precision: 6);
    }

    [Fact]
    public void Quat_Identity_ConjugatedIsIdentity()
    {
        using var q = JPH.Quat.SIdentity();
        using var c = q.Conjugated();
        Assert.Equal(q.GetX(), c.GetX(), precision: 7);
        Assert.Equal(q.GetY(), c.GetY(), precision: 7);
        Assert.Equal(q.GetZ(), c.GetZ(), precision: 7);
        Assert.Equal(q.GetW(), c.GetW(), precision: 7);
    }

    // ── Inversed ─────────────────────────────────────────────────────────────

    [Theory]
    [InlineData(0f,    0f,    0f,      1f)]         // identity
    [InlineData(0.5f, -0.5f, 0.5f, 0.5f)]          // 90° rotations
    public void Quat_TimesInversed_IsIdentity(float x, float y, float z, float w)
    {
        using var q    = new JPH.Quat(x, y, z, w);
        using var qn   = q.Normalized();
        using var inv  = qn.Inversed();
        using var prod = qn * inv;
        Assert.Equal(0f, prod.GetX(), precision: 5);
        Assert.Equal(0f, prod.GetY(), precision: 5);
        Assert.Equal(0f, prod.GetZ(), precision: 5);
        Assert.Equal(1f, prod.GetW(), precision: 5);
    }

    // ── LERP ─────────────────────────────────────────────────────────────────

    [Fact]
    public void Quat_LERP_Quarter_CorrectResult()
    {
        // Jolt: LERP((1,2,3,4),(5,6,7,8), 0.25) = (2,3,4,5) (un-normalised result)
        using var a = new JPH.Quat(1f, 2f, 3f, 4f);
        using var b = new JPH.Quat(5f, 6f, 7f, 8f);
        using var r = a.LERP(b, 0.25f);
        Assert.Equal(2f, r.GetX(), precision: 5);
        Assert.Equal(3f, r.GetY(), precision: 5);
        Assert.Equal(4f, r.GetZ(), precision: 5);
        Assert.Equal(5f, r.GetW(), precision: 5);
    }

    [Fact]
    public void Quat_LERP_AtZero_IsSource()
    {
        using var a = JPH.Quat.SRotation(JPH.Vec3.SAxisZ(), 0f);
        using var b = JPH.Quat.SRotation(JPH.Vec3.SAxisZ(), 1f);
        using var r = a.LERP(b, 0f);
        Assert.Equal(a.GetX(), r.GetX(), precision: 5);
        Assert.Equal(a.GetW(), r.GetW(), precision: 5);
    }

    // ── SLERP ────────────────────────────────────────────────────────────────

    [Fact]
    public void Quat_SLERP_AtZero_IsSource()
    {
        using var axis = JPH.Vec3.SAxisY();
        using var a    = JPH.Quat.SRotation(axis, 0f);
        using var b    = JPH.Quat.SRotation(axis, 1.5f);
        using var r    = a.SLERP(b, 0f);
        Assert.True(a.IsNormalized());
        Assert.Equal(a.GetX(), r.GetX(), precision: 5);
        Assert.Equal(a.GetW(), r.GetW(), precision: 5);
    }

    [Fact]
    public void Quat_SLERP_AtOne_IsDestination()
    {
        using var axis = JPH.Vec3.SAxisY();
        using var a    = JPH.Quat.SRotation(axis, 0f);
        using var b    = JPH.Quat.SRotation(axis, 1.5f);
        using var r    = a.SLERP(b, 1f);
        Assert.Equal(b.GetX(), r.GetX(), precision: 5);
        Assert.Equal(b.GetW(), r.GetW(), precision: 5);
    }

    // ── SFromTo ──────────────────────────────────────────────────────────────

    [Fact]
    public void Quat_SFromTo_RotatesFromVecToVec()
    {
        using var from = JPH.Vec3.SAxisX();
        using var to   = JPH.Vec3.SAxisY();
        using var q    = JPH.Quat.SFromTo(from, to);

        // q applied to 'from' should give 'to'
        using var rotated = q * from;
        Assert.Equal(to.GetX(), rotated.GetX(), precision: 5);
        Assert.Equal(to.GetY(), rotated.GetY(), precision: 5);
        Assert.Equal(to.GetZ(), rotated.GetZ(), precision: 5);
    }

    [Fact]
    public void Quat_SFromTo_SameVector_IsIdentityOrEquivalent()
    {
        using var v = JPH.Vec3.SAxisZ();
        using var q = JPH.Quat.SFromTo(v, v);

        // Rotating v by q gives v
        using var r = q * v;
        Assert.Equal(v.GetX(), r.GetX(), precision: 5);
        Assert.Equal(v.GetY(), r.GetY(), precision: 5);
        Assert.Equal(v.GetZ(), r.GetZ(), precision: 5);
    }

    // ── SEulerAngles round-trip ───────────────────────────────────────────────

    [Theory]
    [InlineData(0.1f, 0.2f, 0.3f)]
    [InlineData(0f,   0f,   0f)]
    [InlineData(1f,  -0.5f, 0.8f)]
    public void Quat_SEulerAngles_RoundTrip(float ex, float ey, float ez)
    {
        using var angles = new JPH.Vec3(ex, ey, ez);
        using var q      = JPH.Quat.SEulerAngles(angles);
        using var back   = q.GetEulerAngles();
        Assert.Equal(ex, back.GetX(), precision: 4);
        Assert.Equal(ey, back.GetY(), precision: 4);
        Assert.Equal(ez, back.GetZ(), precision: 4);
    }

    // ── RotateAxisX/Y/Z ───────────────────────────────────────────────────────

    [Fact]
    public void Quat_RotateAxisX_MatchesQTimesAxisX()
    {
        using var axis = new JPH.Vec3(0f, 1f, 0f);  // rotate around Y
        using var q    = JPH.Quat.SRotation(axis, 0.5f);
        using var viaHelper = q.RotateAxisX();
        using var axisX     = JPH.Vec3.SAxisX();
        using var viaOp     = q * axisX;
        Assert.Equal(viaOp.GetX(), viaHelper.GetX(), precision: 5);
        Assert.Equal(viaOp.GetY(), viaHelper.GetY(), precision: 5);
        Assert.Equal(viaOp.GetZ(), viaHelper.GetZ(), precision: 5);
    }

    [Fact]
    public void Quat_RotateAxisY_MatchesQTimesAxisY()
    {
        using var axis = new JPH.Vec3(1f, 0f, 0f);  // rotate around X
        using var q    = JPH.Quat.SRotation(axis, 0.5f);
        using var viaHelper = q.RotateAxisY();
        using var axisY     = JPH.Vec3.SAxisY();
        using var viaOp     = q * axisY;
        Assert.Equal(viaOp.GetX(), viaHelper.GetX(), precision: 5);
        Assert.Equal(viaOp.GetY(), viaHelper.GetY(), precision: 5);
        Assert.Equal(viaOp.GetZ(), viaHelper.GetZ(), precision: 5);
    }

    [Fact]
    public void Quat_RotateAxisZ_MatchesQTimesAxisZ()
    {
        using var axis = new JPH.Vec3(0f, 0f, 1f);  // identity around Z
        using var q    = JPH.Quat.SRotation(axis, 0.5f);
        using var viaHelper = q.RotateAxisZ();
        using var axisZ     = JPH.Vec3.SAxisZ();
        using var viaOp     = q * axisZ;
        Assert.Equal(viaOp.GetX(), viaHelper.GetX(), precision: 5);
        Assert.Equal(viaOp.GetY(), viaHelper.GetY(), precision: 5);
        Assert.Equal(viaOp.GetZ(), viaHelper.GetZ(), precision: 5);
    }

    // ── GetAxisAngle round-trip ───────────────────────────────────────────────

    [Theory]
    [InlineData(1f, 0f, 0f, 0.5f)]
    [InlineData(0f, 1f, 0f, 1.0f)]
    [InlineData(0f, 0f, 1f, 1.5f)]
    public void Quat_SRotation_GetAxisAngle_RoundTrip(float ax, float ay, float az, float angle)
    {
        using var inAxis = new JPH.Vec3(ax, ay, az);
        using var q      = JPH.Quat.SRotation(inAxis, angle);
        using var outAxis = JPH.Vec3.SZero();
        float     outAngle = 0f;
        q.GetAxisAngle(outAxis, ref outAngle);
        Assert.Equal(angle, outAngle, precision: 5);
        Assert.Equal(ax, outAxis.GetX(), precision: 5);
        Assert.Equal(ay, outAxis.GetY(), precision: 5);
        Assert.Equal(az, outAxis.GetZ(), precision: 5);
    }

    // ── InverseRotate ─────────────────────────────────────────────────────────

    [Fact]
    public void Quat_InverseRotate_UndoesRotation()
    {
        using var axis    = new JPH.Vec3(0f, 1f, 0f);
        using var q       = JPH.Quat.SRotation(axis, 0.7f);
        using var original = new JPH.Vec3(1f, 2f, 3f);
        using var rotated  = q * original;
        using var back     = q.InverseRotate(rotated);
        Assert.Equal(original.GetX(), back.GetX(), precision: 4);
        Assert.Equal(original.GetY(), back.GetY(), precision: 4);
        Assert.Equal(original.GetZ(), back.GetZ(), precision: 4);
    }

    // ── CompressUnitQuat round-trip ───────────────────────────────────────────

    [Fact]
    public void Quat_CompressDecompress_Identity_RoundTrip()
    {
        using var q          = JPH.Quat.SIdentity();
        uint      compressed = q.CompressUnitQuat();
        using var back       = JPH.Quat.SDecompressUnitQuat(compressed);
        Assert.Equal(q.GetX(), back.GetX(), precision: 3);
        Assert.Equal(q.GetY(), back.GetY(), precision: 3);
        Assert.Equal(q.GetZ(), back.GetZ(), precision: 3);
        Assert.Equal(q.GetW(), back.GetW(), precision: 3);
    }

    [Theory]
    [InlineData(1f, 0f, 0f, 0.8f)]
    [InlineData(0f, 1f, 0f, 1.2f)]
    [InlineData(0f, 0f, 1f, 0.3f)]
    public void Quat_CompressDecompress_Rotations_RoundTrip(float ax, float ay, float az, float angle)
    {
        using var axis = new JPH.Vec3(ax, ay, az);
        using var q    = JPH.Quat.SRotation(axis, angle);
        uint      compressed = q.CompressUnitQuat();
        using var back       = JPH.Quat.SDecompressUnitQuat(compressed);
        // Both represent the same rotation: |q · back| must be ≈ 1
        // (quaternions q and -q represent identical rotations).
        float dot = q.GetX() * back.GetX() + q.GetY() * back.GetY()
                  + q.GetZ() * back.GetZ() + q.GetW() * back.GetW();
        Assert.Equal(1f, MathF.Abs(dot), precision: 2);
    }
}
