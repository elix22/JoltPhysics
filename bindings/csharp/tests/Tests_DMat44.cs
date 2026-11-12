// DMat44 (double-precision 4×4 matrix) tests, modelled on Jolt's DMat44Tests.cpp.
// Covers: SZero/SIdentity, construction from Vec4+DVec3 columns, SScale, GetRotation,
// SetRotation, SRotation, STranslation, SRotationTranslation, matrix multiplication
// (DMat44 * Mat44, DMat44 * DMat44), vector multiply (Vec3, DVec3), Multiply3x3,
// axis/translation getters and setters, Inversed, InversedRotationTranslation,
// IsClose, and equality operators.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_DMat44
{
    private const float  Feps = 1e-5f;
    private const double Deps = 1e-10;

    // ── Zero / Identity ───────────────────────────────────────────────────────

    [Fact]
    public void DMat44_SZero_AllZero()
    {
        var m = JPH.DMat44.SZero();
        for (uint col = 0; col < 3; col++)
        {
            var c = m.GetColumn3(col);
            Assert.Equal(0f, c.GetX());
            Assert.Equal(0f, c.GetY());
            Assert.Equal(0f, c.GetZ());
        }
        var t = m.GetTranslation();
        Assert.Equal(0.0, t.GetX());
        Assert.Equal(0.0, t.GetY());
        Assert.Equal(0.0, t.GetZ());
    }

    [Fact]
    public void DMat44_SIdentity_DiagonalOnes_TranslationZero()
    {
        var m = JPH.DMat44.SIdentity();
        Assert.Equal(new JPH.Vec3(1, 0, 0), m.GetAxisX());
        Assert.Equal(new JPH.Vec3(0, 1, 0), m.GetAxisY());
        Assert.Equal(new JPH.Vec3(0, 0, 1), m.GetAxisZ());
        Assert.Equal(0.0, m.GetTranslation().GetX());
        Assert.Equal(0.0, m.GetTranslation().GetY());
        Assert.Equal(0.0, m.GetTranslation().GetZ());
    }

    // ── Construction from Vec4 columns + DVec3 translation ───────────────────

    [Fact]
    public void DMat44_Construct_ColumnsAndTranslationMatch()
    {
        var c1 = new JPH.Vec4(1, 0, 0, 0);
        var c2 = new JPH.Vec4(0, 2, 0, 0);
        var c3 = new JPH.Vec4(0, 0, 3, 0);
        var t  = new JPH.DVec3(10.0, 20.0, 30.0);
        var m  = new JPH.DMat44(c1, c2, c3, t);

        Assert.Equal(1f, m.GetAxisX().GetX());
        Assert.Equal(0f, m.GetAxisX().GetY());
        Assert.Equal(0f, m.GetAxisX().GetZ());

        Assert.Equal(2f, m.GetAxisY().GetY());
        Assert.Equal(3f, m.GetAxisZ().GetZ());

        Assert.Equal(10.0, m.GetTranslation().GetX());
        Assert.Equal(20.0, m.GetTranslation().GetY());
        Assert.Equal(30.0, m.GetTranslation().GetZ());
    }

    // ── GetColumn4 ────────────────────────────────────────────────────────────

    [Fact]
    public void DMat44_GetColumn4_FirstThreeColumnsMatchVec4()
    {
        var c1 = new JPH.Vec4(1, 2, 3, 0);
        var c2 = new JPH.Vec4(4, 5, 6, 0);
        var c3 = new JPH.Vec4(7, 8, 9, 0);
        var t  = new JPH.DVec3(10.0, 11.0, 12.0);
        var m  = new JPH.DMat44(c1, c2, c3, t);

        var r0 = m.GetColumn4(0);
        Assert.Equal(1f, r0.GetX());
        Assert.Equal(2f, r0.GetY());
        Assert.Equal(3f, r0.GetZ());
        Assert.Equal(0f, r0.GetW());
    }

    // ── SScale ────────────────────────────────────────────────────────────────

    [Fact]
    public void DMat44_SScale_ScalesAxes()
    {
        var m = JPH.DMat44.SScale(new JPH.Vec3(2, 3, 4));
        Assert.Equal(2f, m.GetAxisX().GetX());
        Assert.Equal(3f, m.GetAxisY().GetY());
        Assert.Equal(4f, m.GetAxisZ().GetZ());
        Assert.Equal(0f, m.GetAxisX().GetY());
    }

    // ── GetRotation / SetRotation ─────────────────────────────────────────────

    [Fact]
    public void DMat44_GetRotation_ExcludesTranslation()
    {
        var q = JPH.Quat.SRotation(new JPH.Vec3(0, 0, 1), 1.0f);
        var m = JPH.DMat44.SRotationTranslation(q, new JPH.DVec3(5, 6, 7));
        var rot = m.GetRotation();
        // GetRotation() returns Mat44 with 4th column = (0,0,0,1)
        var last = rot.GetColumn4(3);
        Assert.Equal(0f, last.GetX());
        Assert.Equal(0f, last.GetY());
        Assert.Equal(0f, last.GetZ());
        Assert.Equal(1f, last.GetW());
    }

    [Fact]
    public void DMat44_SetRotation_UpdatesRotationAxes()
    {
        var q = JPH.Quat.SRotation(new JPH.Vec3(0, 1, 0), 1.5f);
        var src = JPH.Mat44.SRotation(q);
        var dm  = JPH.DMat44.SIdentity();
        dm.SetRotation(src);
        Assert.True(dm.GetRotation().IsClose(src, 1e-6f));
    }

    // ── SRotation ────────────────────────────────────────────────────────────

    [Fact]
    public void DMat44_SRotation_MatchesMat44SRotation()
    {
        var q = JPH.Quat.SRotation(new JPH.Vec3(1, 0, 0), 0.5f);
        var dm = JPH.DMat44.SRotation(q);
        var m  = JPH.Mat44.SRotation(q);
        Assert.True(dm.ToMat44().IsClose(m, 1e-6f));
    }

    // ── STranslation ─────────────────────────────────────────────────────────

    [Fact]
    public void DMat44_STranslation_IdentityWithTranslation()
    {
        var m = JPH.DMat44.STranslation(new JPH.DVec3(1.0, 2.0, 3.0));
        Assert.Equal(new JPH.Vec3(1, 0, 0), m.GetAxisX());
        Assert.Equal(new JPH.Vec3(0, 1, 0), m.GetAxisY());
        Assert.Equal(new JPH.Vec3(0, 0, 1), m.GetAxisZ());
        Assert.Equal(1.0, m.GetTranslation().GetX());
        Assert.Equal(2.0, m.GetTranslation().GetY());
        Assert.Equal(3.0, m.GetTranslation().GetZ());
    }

    // ── SRotationTranslation ──────────────────────────────────────────────────

    [Fact]
    public void DMat44_SRotationTranslation_Correct()
    {
        var q = JPH.Quat.SRotation(new JPH.Vec3(0, 0, 1), 0.5f);
        var t = new JPH.DVec3(1.0, 2.0, 3.0);
        var m = JPH.DMat44.SRotationTranslation(q, t);
        Assert.True(m.GetRotation().IsClose(JPH.Mat44.SRotation(q), 1e-6f));
        Assert.Equal(1.0, m.GetTranslation().GetX());
        Assert.Equal(2.0, m.GetTranslation().GetY());
        Assert.Equal(3.0, m.GetTranslation().GetZ());
    }

    // ── Matrix multiplication ─────────────────────────────────────────────────

    [Fact]
    public void DMat44_MultiplyMat44_TranslationSumsUpCorrectly()
    {
        var t1 = new JPH.DVec3(1.0, 2.0, 3.0);
        var t2 = new JPH.Vec3(4.0f, 5.0f, 6.0f);
        var m1 = JPH.DMat44.STranslation(t1);
        var m2 = JPH.Mat44.STranslation(t2);
        var r  = m1 * m2;
        Assert.Equal(5.0, r.GetTranslation().GetX());
        Assert.Equal(7.0, r.GetTranslation().GetY());
        Assert.Equal(9.0, r.GetTranslation().GetZ());
    }

    [Fact]
    public void DMat44_MultiplyDMat44_TranslationSumsUpCorrectly()
    {
        var m1 = JPH.DMat44.STranslation(new JPH.DVec3(1.0, 2.0, 3.0));
        var m2 = JPH.DMat44.STranslation(new JPH.DVec3(4.0, 5.0, 6.0));
        var r  = m1 * m2;
        Assert.Equal(5.0, r.GetTranslation().GetX());
        Assert.Equal(7.0, r.GetTranslation().GetY());
        Assert.Equal(9.0, r.GetTranslation().GetZ());
    }

    // ── Vector transform ──────────────────────────────────────────────────────

    [Fact]
    public void DMat44_TransformVec3_TranslationApplied()
    {
        var m = JPH.DMat44.STranslation(new JPH.DVec3(1.0, 2.0, 3.0));
        var r = m * new JPH.Vec3(4, 5, 6);
        Assert.Equal(5.0, r.GetX());
        Assert.Equal(7.0, r.GetY());
        Assert.Equal(9.0, r.GetZ());
    }

    [Fact]
    public void DMat44_TransformDVec3_TranslationApplied()
    {
        var m = JPH.DMat44.STranslation(new JPH.DVec3(1.0, 2.0, 3.0));
        var r = m * new JPH.DVec3(4.0, 5.0, 6.0);
        Assert.Equal(5.0, r.GetX());
        Assert.Equal(7.0, r.GetY());
        Assert.Equal(9.0, r.GetZ());
    }

    // ── Multiply3x3 (direction, ignores translation) ──────────────────────────

    [Fact]
    public void DMat44_Multiply3x3_IgnoresTranslation()
    {
        var q = JPH.Quat.SRotation(new JPH.Vec3(0, 0, 1), 1.5707963f); // 90 deg
        var m = JPH.DMat44.SRotationTranslation(q, new JPH.DVec3(100.0, 200.0, 300.0));
        var dir  = new JPH.Vec3(1, 0, 0);
        var r    = m.Multiply3x3(dir);
        // 90-deg around Z: (1,0,0) → (0,1,0) (approximately)
        Assert.Equal(0f,  r.GetX(), 5);
        Assert.Equal(1f,  r.GetY(), 5);
        Assert.Equal(0f,  r.GetZ(), 5);
    }

    [Fact]
    public void DMat44_Multiply3x3_DVec3_IgnoresTranslation()
    {
        var q = JPH.Quat.SRotation(new JPH.Vec3(0, 0, 1), 1.5707963f); // 90 deg
        var m = JPH.DMat44.SRotationTranslation(q, new JPH.DVec3(100.0, 200.0, 300.0));
        var r = m.Multiply3x3(new JPH.DVec3(1.0, 0.0, 0.0));
        Assert.Equal(0.0, r.GetX(), 5);
        Assert.Equal(1.0, r.GetY(), 5);
        Assert.Equal(0.0, r.GetZ(), 5);
    }

    // ── Axis / Translation setters ────────────────────────────────────────────

    [Fact]
    public void DMat44_SetAxisX_UpdatesX()
    {
        var m = JPH.DMat44.SIdentity();
        m.SetAxisX(new JPH.Vec3(2, 3, 4));
        Assert.Equal(2f, m.GetAxisX().GetX());
        Assert.Equal(3f, m.GetAxisX().GetY());
        Assert.Equal(4f, m.GetAxisX().GetZ());
    }

    [Fact]
    public void DMat44_SetTranslation_UpdatesTranslation()
    {
        var m = JPH.DMat44.SIdentity();
        m.SetTranslation(new JPH.DVec3(7.0, 8.0, 9.0));
        Assert.Equal(7.0, m.GetTranslation().GetX());
        Assert.Equal(8.0, m.GetTranslation().GetY());
        Assert.Equal(9.0, m.GetTranslation().GetZ());
    }

    // ── Inversed / InversedRotationTranslation ────────────────────────────────

    [Fact]
    public void DMat44_InversedRotationTranslation_RoundTrip()
    {
        var q = JPH.Quat.SRotation(new JPH.Vec3(0, 1, 0), 1.2f);
        var t = new JPH.DVec3(5.0, -3.0, 2.5);
        var m = JPH.DMat44.SRotationTranslation(q, t);
        var mi = m.InversedRotationTranslation();
        var identity = m * mi.ToMat44();
        Assert.True(identity.ToMat44().IsClose(JPH.Mat44.SIdentity(), 1e-5f));
    }

    // ── IsClose / equality ────────────────────────────────────────────────────

    [Fact]
    public void DMat44_IsClose_IdenticalMatrices()
    {
        var m = JPH.DMat44.SRotationTranslation(
            JPH.Quat.SRotation(new JPH.Vec3(1, 0, 0), 0.7f),
            new JPH.DVec3(1.0, 2.0, 3.0));
        Assert.True(m.IsClose(m));
    }

    [Fact]
    public void DMat44_IsClose_SlightlyDifferent_WithLooseTolerance()
    {
        var m1 = JPH.DMat44.STranslation(new JPH.DVec3(1.0, 2.0, 3.0));
        var m2 = JPH.DMat44.STranslation(new JPH.DVec3(1.001, 2.0, 3.0));
        Assert.True(m1.IsClose(m2, 1e-4f));
        Assert.False(m1.IsClose(m2, 1e-8f));
    }

    [Fact]
    public void DMat44_Equality_Correct()
    {
        var m1 = JPH.DMat44.SIdentity();
        var m2 = JPH.DMat44.SIdentity();
        Assert.True(m1 == m2);
        Assert.False(m1 != m2);

        m2.SetTranslation(new JPH.DVec3(1.0, 0.0, 0.0));
        Assert.False(m1 == m2);
        Assert.True(m1 != m2);
    }
}
