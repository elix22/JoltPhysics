// Tests for JPH::Vector<2> (Vector_2) and JPH::Matrix<2,2> (Matrix_2_2).
//
// Tested APIs (Vector_2):
//   - Default construct
//   - Copy construct
//   - SetZero / IsZero
//   - Indexer get/set (uint-indexed)
//   - IsClose
//   - Dot product
//   - LengthSq / Length
//   - Normalized
//   - operator== / !=
//   - MulAssign / AddAssign / SubAssign
//   - GetRows
//   - IsNormalized
//
// Tested APIs (Matrix_2_2):
//   - Default construct
//   - SetZero / IsZero
//   - SetIdentity / IsIdentity
//   - Transposed
//   - GetRows / GetCols
//   - GetColumn
//   - mCol indexer

using System;
using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Vector2Matrix(JoltFixture fx)
{
    // -------------------------------------------------------------------------
    // Vector_2
    // -------------------------------------------------------------------------

    [Fact]
    public void Vector2_DefaultConstruct_NoCrash()
    {
        var ex = Record.Exception(() => { using var v = new JPH.Vector_2(); });
        Assert.Null(ex);
    }

    [Fact]
    public void Vector2_SetZero_IsZeroTrue()
    {
        using var v = new JPH.Vector_2();
        v.SetZero();
        Assert.True(v.IsZero());
    }

    [Fact]
    public void Vector2_IndexSet_IndexGet_RoundTrip()
    {
        using var v = new JPH.Vector_2();
        v[0u] = 3f;
        v[1u] = 4f;
        Assert.Equal(3f, v[0u], precision: 5);
        Assert.Equal(4f, v[1u], precision: 5);
    }

    [Fact]
    public void Vector2_GetRows_IsTwo()
    {
        using var v = new JPH.Vector_2();
        Assert.Equal(2u, v.GetRows());
    }

    [Fact]
    public void Vector2_CopyConstruct_PreservesValues()
    {
        using var v = new JPH.Vector_2();
        v[0u] = 1f; v[1u] = 2f;
        using var w = new JPH.Vector_2(v);
        Assert.Equal(1f, w[0u], precision: 5);
        Assert.Equal(2f, w[1u], precision: 5);
    }

    [Fact]
    public void Vector2_Equality_SameValues_Equal()
    {
        using var a = new JPH.Vector_2(); a[0u] = 1f; a[1u] = 2f;
        using var b = new JPH.Vector_2(a);
        Assert.True(a == b);
    }

    [Fact]
    public void Vector2_Inequality_DifferentValues_NotEqual()
    {
        using var a = new JPH.Vector_2(); a[0u] = 1f; a[1u] = 2f;
        using var b = new JPH.Vector_2(); b[0u] = 3f; b[1u] = 4f;
        Assert.True(a != b);
    }

    [Fact]
    public void Vector2_Dot_ThreeAndFour_IsTwentyFive()
    {
        using var a = new JPH.Vector_2(); a[0u] = 3f; a[1u] = 4f;
        using var b = new JPH.Vector_2(); b[0u] = 3f; b[1u] = 4f;
        Assert.Equal(25f, a.Dot(b), precision: 5);
    }

    [Fact]
    public void Vector2_LengthSq_ThreeAndFour_IsTwentyFive()
    {
        using var v = new JPH.Vector_2(); v[0u] = 3f; v[1u] = 4f;
        Assert.Equal(25f, v.LengthSq(), precision: 5);
    }

    [Fact]
    public void Vector2_Length_ThreeAndFour_IsFive()
    {
        using var v = new JPH.Vector_2(); v[0u] = 3f; v[1u] = 4f;
        Assert.Equal(5f, v.Length(), precision: 4);
    }

    [Fact]
    public void Vector2_Normalized_LengthIsOne()
    {
        using var v = new JPH.Vector_2(); v[0u] = 3f; v[1u] = 4f;
        using var n = v.Normalized();
        Assert.Equal(1f, n.Length(), precision: 5);
    }

    [Fact]
    public void Vector2_IsNormalized_AfterNormalized_IsTrue()
    {
        using var v = new JPH.Vector_2(); v[0u] = 3f; v[1u] = 4f;
        using var n = v.Normalized();
        Assert.True(n.IsNormalized());
    }

    [Fact]
    public void Vector2_MulAssign_ScalesComponents()
    {
        using var v = new JPH.Vector_2(); v[0u] = 2f; v[1u] = 3f;
        v.MulAssign(2f);
        Assert.Equal(4f, v[0u], precision: 5);
        Assert.Equal(6f, v[1u], precision: 5);
    }

    [Fact]
    public void Vector2_AddAssign_AddsComponents()
    {
        using var a = new JPH.Vector_2(); a[0u] = 1f; a[1u] = 2f;
        using var b = new JPH.Vector_2(); b[0u] = 3f; b[1u] = 4f;
        a.AddAssign(b);
        Assert.Equal(4f, a[0u], precision: 5);
        Assert.Equal(6f, a[1u], precision: 5);
    }

    [Fact]
    public void Vector2_SubAssign_SubtractsComponents()
    {
        using var a = new JPH.Vector_2(); a[0u] = 5f; a[1u] = 7f;
        using var b = new JPH.Vector_2(); b[0u] = 2f; b[1u] = 3f;
        a.SubAssign(b);
        Assert.Equal(3f, a[0u], precision: 5);
        Assert.Equal(4f, a[1u], precision: 5);
    }

    [Fact]
    public void Vector2_IsClose_IdenticalVectors_IsTrue()
    {
        using var a = new JPH.Vector_2(); a[0u] = 1f; a[1u] = 0f;
        using var b = new JPH.Vector_2(a);
        Assert.True(a.IsClose(b));
    }

    // -------------------------------------------------------------------------
    // Matrix_2_2
    // -------------------------------------------------------------------------

    [Fact]
    public void Matrix22_DefaultConstruct_NoCrash()
    {
        var ex = Record.Exception(() => { using var m = new JPH.Matrix_2_2(); });
        Assert.Null(ex);
    }

    [Fact]
    public void Matrix22_SetZero_IsZeroTrue()
    {
        using var m = new JPH.Matrix_2_2();
        m.SetZero();
        Assert.True(m.IsZero());
    }

    [Fact]
    public void Matrix22_SetIdentity_IsIdentityTrue()
    {
        using var m = new JPH.Matrix_2_2();
        m.SetIdentity();
        Assert.True(m.IsIdentity());
    }

    [Fact]
    public void Matrix22_SetIdentity_IsZeroFalse()
    {
        using var m = new JPH.Matrix_2_2();
        m.SetIdentity();
        Assert.False(m.IsZero());
    }

    [Fact]
    public void Matrix22_GetRows_IsTwo()
    {
        using var m = new JPH.Matrix_2_2();
        Assert.Equal(2u, m.GetRows());
    }

    [Fact]
    public void Matrix22_GetCols_IsTwo()
    {
        using var m = new JPH.Matrix_2_2();
        Assert.Equal(2u, m.GetCols());
    }

    [Fact]
    public void Matrix22_GetColumn_AfterSetIdentity_FirstColumnIsE1()
    {
        using var m = new JPH.Matrix_2_2();
        m.SetIdentity();
        using var col0 = m.GetColumn(0);
        // Identity matrix column 0 = (1, 0)
        Assert.Equal(1f, col0[0u], precision: 5);
        Assert.Equal(0f, col0[1u], precision: 5);
    }

    [Fact]
    public void Matrix22_GetColumn_AfterSetIdentity_SecondColumnIsE2()
    {
        using var m = new JPH.Matrix_2_2();
        m.SetIdentity();
        using var col1 = m.GetColumn(1);
        // Identity matrix column 1 = (0, 1)
        Assert.Equal(0f, col1[0u], precision: 5);
        Assert.Equal(1f, col1[1u], precision: 5);
    }

    [Fact]
    public void Matrix22_Transposed_IdentityIsIdentity()
    {
        using var m = new JPH.Matrix_2_2();
        m.SetIdentity();
        using var t = m.Transposed();
        Assert.True(t.IsIdentity());
    }
}
