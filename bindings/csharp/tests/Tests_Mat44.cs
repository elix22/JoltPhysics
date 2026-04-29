// Mat44 tests based on Jolt's Mat44Tests.cpp.
// Covers identity, translation, scale, rotation factories,
// matrix multiplication, vector transformation, transposed,
// inversed, determinant, quaternion extraction, and GetTranslation.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Mat44
{
    // ── Factory methods ───────────────────────────────────────────────────────

    [Fact]
    public void Mat44_SIdentity_DiagonalOnesRestZero()
    {
        using var m = JPH.Mat44.SIdentity();
        // diagonal
        Assert.Equal(1f, m.Call(0, 0), precision: 6);
        Assert.Equal(1f, m.Call(1, 1), precision: 6);
        Assert.Equal(1f, m.Call(2, 2), precision: 6);
        Assert.Equal(1f, m.Call(3, 3), precision: 6);
        // off-diagonal sample
        Assert.Equal(0f, m.Call(0, 1), precision: 6);
        Assert.Equal(0f, m.Call(1, 0), precision: 6);
    }

    [Fact]
    public void Mat44_SZero_AllEntriesZero()
    {
        using var m = JPH.Mat44.SZero();
        for (uint r = 0; r < 4; r++)
            for (uint c = 0; c < 4; c++)
                Assert.Equal(0f, m.Call(r, c), precision: 6);
    }

    [Fact]
    public void Mat44_STranslation_GetTranslationRoundTrip()
    {
        using var t  = new JPH.Vec3(3f, -2f, 7f);
        using var m  = JPH.Mat44.STranslation(t);
        using var gt = m.GetTranslation();
        Assert.Equal(3f,  gt.GetX(), precision: 5);
        Assert.Equal(-2f, gt.GetY(), precision: 5);
        Assert.Equal(7f,  gt.GetZ(), precision: 5);
    }

    [Fact]
    public void Mat44_SRotationX_90Deg_TransformsY_to_Z()
    {
        float halfPi = MathF.PI / 2f;
        using var m  = JPH.Mat44.SRotationX(halfPi);
        using var y  = new JPH.Vec3(0f, 1f, 0f);
        using var r  = m * y;
        Assert.Equal(0f,  r.GetX(), precision: 5);
        Assert.Equal(0f,  r.GetY(), precision: 5);
        Assert.Equal(1f,  r.GetZ(), precision: 5);
    }

    [Fact]
    public void Mat44_SRotationY_90Deg_TransformsZ_to_X()
    {
        float halfPi = MathF.PI / 2f;
        using var m  = JPH.Mat44.SRotationY(halfPi);
        using var z  = new JPH.Vec3(0f, 0f, 1f);
        using var r  = m * z;
        Assert.Equal(1f,  r.GetX(), precision: 5);
        Assert.Equal(0f,  r.GetY(), precision: 5);
        Assert.Equal(0f,  r.GetZ(), precision: 5);
    }

    [Fact]
    public void Mat44_SRotationZ_90Deg_TransformsX_to_Y()
    {
        float halfPi = MathF.PI / 2f;
        using var m  = JPH.Mat44.SRotationZ(halfPi);
        using var x  = new JPH.Vec3(1f, 0f, 0f);
        using var r  = m * x;
        Assert.Equal(0f,  r.GetX(), precision: 5);
        Assert.Equal(1f,  r.GetY(), precision: 5);
        Assert.Equal(0f,  r.GetZ(), precision: 5);
    }

    [Fact]
    public void Mat44_SScale_UniformScalesVector()
    {
        using var m = JPH.Mat44.SScale(3f);
        using var v = new JPH.Vec3(1f, 2f, 3f);
        using var r = m.Multiply3x3(v);
        Assert.Equal(3f, r.GetX(), precision: 5);
        Assert.Equal(6f, r.GetY(), precision: 5);
        Assert.Equal(9f, r.GetZ(), precision: 5);
    }

    [Fact]
    public void Mat44_SScaleVec_NonUniformScalesVector()
    {
        using var s = new JPH.Vec3(2f, 3f, 4f);
        using var m = JPH.Mat44.SScale(s);
        using var v = new JPH.Vec3(1f, 1f, 1f);
        using var r = m.Multiply3x3(v);
        Assert.Equal(2f, r.GetX(), precision: 5);
        Assert.Equal(3f, r.GetY(), precision: 5);
        Assert.Equal(4f, r.GetZ(), precision: 5);
    }

    // ── Matrix–vector multiplication ──────────────────────────────────────────

    [Fact]
    public void Mat44_Identity_TimesVec_IsVec()
    {
        using var m = JPH.Mat44.SIdentity();
        using var v = new JPH.Vec3(5f, -3f, 2f);
        using var r = m * v;
        Assert.Equal(5f,  r.GetX(), precision: 5);
        Assert.Equal(-3f, r.GetY(), precision: 5);
        Assert.Equal(2f,  r.GetZ(), precision: 5);
    }

    [Fact]
    public void Mat44_Translation_TimesVec_AddsTranslation()
    {
        using var t = new JPH.Vec3(10f, 20f, 30f);
        using var m = JPH.Mat44.STranslation(t);
        using var v = new JPH.Vec3(1f, 2f, 3f);
        using var r = m * v;
        Assert.Equal(11f, r.GetX(), precision: 5);
        Assert.Equal(22f, r.GetY(), precision: 5);
        Assert.Equal(33f, r.GetZ(), precision: 5);
    }

    // ── Matrix–matrix multiplication ──────────────────────────────────────────

    [Fact]
    public void Mat44_Identity_TimesIdentity_IsIdentity()
    {
        using var a = JPH.Mat44.SIdentity();
        using var b = JPH.Mat44.SIdentity();
        using var r = a * b;
        Assert.Equal(1f, r.Call(0, 0), precision: 6);
        Assert.Equal(1f, r.Call(1, 1), precision: 6);
        Assert.Equal(1f, r.Call(2, 2), precision: 6);
        Assert.Equal(1f, r.Call(3, 3), precision: 6);
        Assert.Equal(0f, r.Call(0, 1), precision: 6);
    }

    [Fact]
    public void Mat44_TwoTranslations_Compose()
    {
        using var t1 = new JPH.Vec3(1f, 0f, 0f);
        using var t2 = new JPH.Vec3(0f, 2f, 0f);
        using var m1 = JPH.Mat44.STranslation(t1);
        using var m2 = JPH.Mat44.STranslation(t2);
        using var m  = m1 * m2;
        using var tr = m.GetTranslation();
        Assert.Equal(1f, tr.GetX(), precision: 5);
        Assert.Equal(2f, tr.GetY(), precision: 5);
        Assert.Equal(0f, tr.GetZ(), precision: 5);
    }

    // ── Transposed ───────────────────────────────────────────────────────────

    [Fact]
    public void Mat44_Transposed_SwapsOffDiagonalElements()
    {
        using var m  = JPH.Mat44.SRotationX(0.7f);
        using var mt = m.Transposed();
        for (uint r = 0; r < 4; r++)
            for (uint c = 0; c < 4; c++)
                Assert.Equal(m.Call(r, c), mt.Call(c, r), precision: 5);
    }

    [Fact]
    public void Mat44_TransposedTwice_IsOriginal()
    {
        using var m   = JPH.Mat44.SRotationY(1.0f);
        using var mt  = m.Transposed();
        using var mtt = mt.Transposed();
        for (uint r = 0; r < 4; r++)
            for (uint c = 0; c < 4; c++)
                Assert.Equal(m.Call(r, c), mtt.Call(r, c), precision: 5);
    }

    // ── Inversed ─────────────────────────────────────────────────────────────

    [Fact]
    public void Mat44_Inversed_TimesOriginal_IsIdentity()
    {
        using var t  = new JPH.Vec3(5f, -3f, 2f);
        using var m  = JPH.Mat44.STranslation(t);
        using var mi = m.Inversed();
        using var r  = m * mi;
        for (uint i = 0; i < 4; i++)
            Assert.Equal(1f, r.Call(i, i), precision: 4);
        Assert.Equal(0f, r.Call(0, 1), precision: 4);
        Assert.Equal(0f, r.Call(1, 0), precision: 4);
    }

    [Fact]
    public void Mat44_RotationMatrix_Inversed_IsTranspose()
    {
        using var axis = JPH.Vec3.SAxisY();
        using var q    = JPH.Quat.SRotation(axis, 0.6f);
        using var m    = JPH.Mat44.SRotation(q);
        using var mi   = m.Inversed3x3();
        using var mt   = m.Transposed3x3();
        for (uint r = 0; r < 3; r++)
            for (uint c = 0; c < 3; c++)
                Assert.Equal(mi.Call(r, c), mt.Call(r, c), precision: 4);
    }

    // ── Determinant ──────────────────────────────────────────────────────────

    [Fact]
    public void Mat44_Identity_Determinant3x3_IsOne()
    {
        using var m = JPH.Mat44.SIdentity();
        Assert.Equal(1f, m.GetDeterminant3x3(), precision: 6);
    }

    [Fact]
    public void Mat44_Scale2_Determinant3x3_Is8()
    {
        // uniform scale by 2 → det = 2^3 = 8
        using var m = JPH.Mat44.SScale(2f);
        Assert.Equal(8f, m.GetDeterminant3x3(), precision: 5);
    }

    // ── GetQuaternion ─────────────────────────────────────────────────────────

    [Theory]
    [InlineData(1f, 0f, 0f, 0.5f)]
    [InlineData(0f, 1f, 0f, 1.0f)]
    [InlineData(0f, 0f, 1f, 1.5f)]
    public void Mat44_SRotation_GetQuaternion_RoundTrip(float ax, float ay, float az, float angle)
    {
        using var axis = new JPH.Vec3(ax, ay, az);
        using var q    = JPH.Quat.SRotation(axis, angle);
        using var m    = JPH.Mat44.SRotation(q);
        using var q2   = m.GetQuaternion();
        // q and q2 may differ by sign but represent the same rotation
        float dot = q.GetX() * q2.GetX() + q.GetY() * q2.GetY()
                  + q.GetZ() * q2.GetZ() + q.GetW() * q2.GetW();
        Assert.Equal(1f, MathF.Abs(dot), precision: 5);
    }

    // ── GetAxisX/Y/Z ─────────────────────────────────────────────────────────

    [Fact]
    public void Mat44_Identity_AxisX_IsUnitX()
    {
        using var m = JPH.Mat44.SIdentity();
        using var a = m.GetAxisX();
        Assert.Equal(1f, a.GetX(), precision: 6);
        Assert.Equal(0f, a.GetY(), precision: 6);
        Assert.Equal(0f, a.GetZ(), precision: 6);
    }

    [Fact]
    public void Mat44_Identity_AxisY_IsUnitY()
    {
        using var m = JPH.Mat44.SIdentity();
        using var a = m.GetAxisY();
        Assert.Equal(0f, a.GetX(), precision: 6);
        Assert.Equal(1f, a.GetY(), precision: 6);
        Assert.Equal(0f, a.GetZ(), precision: 6);
    }

    [Fact]
    public void Mat44_Identity_AxisZ_IsUnitZ()
    {
        using var m = JPH.Mat44.SIdentity();
        using var a = m.GetAxisZ();
        Assert.Equal(0f, a.GetX(), precision: 6);
        Assert.Equal(0f, a.GetY(), precision: 6);
        Assert.Equal(1f, a.GetZ(), precision: 6);
    }

    // ── Multiply3x3 (ignores translation) ────────────────────────────────────

    [Fact]
    public void Mat44_Multiply3x3_IgnoresTranslationColumn()
    {
        using var t  = new JPH.Vec3(100f, 200f, 300f);
        using var m  = JPH.Mat44.STranslation(t);
        using var v  = new JPH.Vec3(1f, 0f, 0f);
        using var r  = m.Multiply3x3(v);
        // identity 3×3 block, so result should equal v
        Assert.Equal(1f, r.GetX(), precision: 5);
        Assert.Equal(0f, r.GetY(), precision: 5);
        Assert.Equal(0f, r.GetZ(), precision: 5);
    }

    // ── SRotationTranslation combined ────────────────────────────────────────

    [Fact]
    public void Mat44_SRotationTranslation_GetTranslation_IsTranslation()
    {
        using var axis = JPH.Vec3.SAxisY();
        using var q    = JPH.Quat.SRotation(axis, 1.0f);
        using var t    = new JPH.Vec3(5f, 6f, 7f);
        using var m    = JPH.Mat44.SRotationTranslation(q, t);
        using var gt   = m.GetTranslation();
        Assert.Equal(5f, gt.GetX(), precision: 5);
        Assert.Equal(6f, gt.GetY(), precision: 5);
        Assert.Equal(7f, gt.GetZ(), precision: 5);
    }
}
