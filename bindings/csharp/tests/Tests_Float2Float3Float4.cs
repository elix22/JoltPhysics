// Tests for JPH::Float2, JPH::Float3, and JPH::Float4:
// construction, field accessors (x/y/z/w), indexer (Float3), equality
// operators (== / != / Equals).

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Float2Float3Float4(JoltFixture fx)
{
    // =========================================================================
    // Float2
    // =========================================================================

    [Fact]
    public void Float2_DefaultConstruct_DoesNotThrow()
    {
        using var v = new JPH.Float2();
        Assert.NotNull(v);
    }

    [Fact]
    public void Float2_ParameterizedConstruct_XYCorrect()
    {
        using var v = new JPH.Float2(1.5f, -2.3f);
        Assert.Equal(1.5f,  v.x, precision: 5);
        Assert.Equal(-2.3f, v.y, precision: 5);
    }

    [Fact]
    public void Float2_Mutable_SetXY()
    {
        using var v = new JPH.Float2(0f, 0f);
        v.x = 3.0f;
        v.y = 7.0f;
        Assert.Equal(3.0f, v.x, precision: 5);
        Assert.Equal(7.0f, v.y, precision: 5);
    }

    [Fact]
    public void Float2_EqualityOperator_SameValues_IsTrue()
    {
        using var a = new JPH.Float2(1.0f, 2.0f);
        using var b = new JPH.Float2(1.0f, 2.0f);
        Assert.True(a == b);
    }

    [Fact]
    public void Float2_EqualityOperator_DifferentValues_IsFalse()
    {
        using var a = new JPH.Float2(1.0f, 2.0f);
        using var b = new JPH.Float2(1.0f, 3.0f);
        Assert.False(a == b);
    }

    [Fact]
    public void Float2_InequalityOperator_DifferentValues_IsTrue()
    {
        using var a = new JPH.Float2(1.0f, 2.0f);
        using var b = new JPH.Float2(9.0f, 2.0f);
        Assert.True(a != b);
    }

    [Fact]
    public void Float2_Equals_Method_SameValues_IsTrue()
    {
        using var a = new JPH.Float2(5.0f, 6.0f);
        using var b = new JPH.Float2(5.0f, 6.0f);
        Assert.True(a.Equals(b));
    }

    // =========================================================================
    // Float3
    // =========================================================================

    [Fact]
    public void Float3_DefaultConstruct_DoesNotThrow()
    {
        using var v = new JPH.Float3();
        Assert.NotNull(v);
    }

    [Fact]
    public void Float3_ParameterizedConstruct_XYZCorrect()
    {
        using var v = new JPH.Float3(1.0f, 2.0f, 3.0f);
        Assert.Equal(1.0f, v.x, precision: 5);
        Assert.Equal(2.0f, v.y, precision: 5);
        Assert.Equal(3.0f, v.z, precision: 5);
    }

    [Fact]
    public void Float3_Mutable_SetXYZ()
    {
        using var v = new JPH.Float3(0f, 0f, 0f);
        v.x = 4.0f;
        v.y = 5.0f;
        v.z = 6.0f;
        Assert.Equal(4.0f, v.x, precision: 5);
        Assert.Equal(5.0f, v.y, precision: 5);
        Assert.Equal(6.0f, v.z, precision: 5);
    }

    [Fact]
    public void Float3_Indexer_ReturnsCorrectComponent()
    {
        using var v = new JPH.Float3(10f, 20f, 30f);
        Assert.Equal(10f, v[0], precision: 5);
        Assert.Equal(20f, v[1], precision: 5);
        Assert.Equal(30f, v[2], precision: 5);
    }

    [Fact]
    public void Float3_EqualityOperator_SameValues_IsTrue()
    {
        using var a = new JPH.Float3(1.0f, 2.0f, 3.0f);
        using var b = new JPH.Float3(1.0f, 2.0f, 3.0f);
        Assert.True(a == b);
    }

    [Fact]
    public void Float3_EqualityOperator_DifferentValues_IsFalse()
    {
        using var a = new JPH.Float3(1.0f, 2.0f, 3.0f);
        using var b = new JPH.Float3(1.0f, 2.0f, 4.0f);
        Assert.False(a == b);
    }

    [Fact]
    public void Float3_InequalityOperator_DifferentValues_IsTrue()
    {
        using var a = new JPH.Float3(1.0f, 2.0f, 3.0f);
        using var b = new JPH.Float3(1.0f, 0.0f, 3.0f);
        Assert.True(a != b);
    }

    [Fact]
    public void Float3_CopyConstruct_ValuesMatch()
    {
        using var a = new JPH.Float3(7.0f, 8.0f, 9.0f);
        using var b = new JPH.Float3((JPH.Const_Float3)a);
        Assert.True(a == b);
    }

    // =========================================================================
    // Float4
    // =========================================================================

    [Fact]
    public void Float4_DefaultConstruct_DoesNotThrow()
    {
        using var v = new JPH.Float4();
        Assert.NotNull(v);
    }

    [Fact]
    public void Float4_ParameterizedConstruct_XYZWCorrect()
    {
        using var v = new JPH.Float4(1.0f, 2.0f, 3.0f, 4.0f);
        Assert.Equal(1.0f, v.x, precision: 5);
        Assert.Equal(2.0f, v.y, precision: 5);
        Assert.Equal(3.0f, v.z, precision: 5);
        Assert.Equal(4.0f, v.w, precision: 5);
    }

    [Fact]
    public void Float4_Mutable_SetXYZW()
    {
        using var v = new JPH.Float4(0f, 0f, 0f, 0f);
        v.x = 1.5f;
        v.y = 2.5f;
        v.z = 3.5f;
        v.w = 4.5f;
        Assert.Equal(1.5f, v.x, precision: 5);
        Assert.Equal(2.5f, v.y, precision: 5);
        Assert.Equal(3.5f, v.z, precision: 5);
        Assert.Equal(4.5f, v.w, precision: 5);
    }

    [Fact]
    public void Float4_EqualityOperator_SameValues_IsTrue()
    {
        using var a = new JPH.Float4(1f, 2f, 3f, 4f);
        using var b = new JPH.Float4(1f, 2f, 3f, 4f);
        Assert.True(a == b);
    }

    [Fact]
    public void Float4_EqualityOperator_DifferentValues_IsFalse()
    {
        using var a = new JPH.Float4(1f, 2f, 3f, 4f);
        using var b = new JPH.Float4(1f, 2f, 3f, 5f);
        Assert.False(a == b);
    }

    [Fact]
    public void Float4_InequalityOperator_DifferentValues_IsTrue()
    {
        using var a = new JPH.Float4(1f, 2f, 3f, 4f);
        using var b = new JPH.Float4(0f, 2f, 3f, 4f);
        Assert.True(a != b);
    }

    [Fact]
    public void Float4_Equals_Method_SameValues_IsTrue()
    {
        using var a = new JPH.Float4(9f, 8f, 7f, 6f);
        using var b = new JPH.Float4(9f, 8f, 7f, 6f);
        Assert.True(a.Equals(b));
    }
}
