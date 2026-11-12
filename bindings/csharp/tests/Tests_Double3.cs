// Tests for JPH::Double3: construction, field accessors (x/y/z), indexer,
// equality operators (== / != / Equals), and copy construction.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_Double3(JoltFixture fx)
{
    [Fact]
    public void Double3_DefaultConstruct_DoesNotThrow()
    {
        using var v = new JPH.Double3();
        Assert.NotNull(v);
    }

    [Fact]
    public void Double3_ParameterizedConstruct_XYZCorrect()
    {
        using var v = new JPH.Double3(1.0, 2.0, 3.0);
        Assert.Equal(1.0, v.x);
        Assert.Equal(2.0, v.y);
        Assert.Equal(3.0, v.z);
    }

    [Fact]
    public void Double3_NegativeValues_StoredCorrectly()
    {
        using var v = new JPH.Double3(-100.5, 0.0, 999.9);
        Assert.Equal(-100.5, v.x, precision: 10);
        Assert.Equal(0.0,    v.y);
        Assert.Equal(999.9,  v.z, precision: 10);
    }

    [Fact]
    public void Double3_Mutable_SetXYZ()
    {
        using var v = new JPH.Double3(0.0, 0.0, 0.0);
        v.x = 4.0;
        v.y = 5.0;
        v.z = 6.0;
        Assert.Equal(4.0, v.x);
        Assert.Equal(5.0, v.y);
        Assert.Equal(6.0, v.z);
    }

    [Fact]
    public void Double3_Indexer_ReturnsCorrectComponent()
    {
        using var v = new JPH.Double3(10.0, 20.0, 30.0);
        Assert.Equal(10.0, v[0]);
        Assert.Equal(20.0, v[1]);
        Assert.Equal(30.0, v[2]);
    }

    [Fact]
    public void Double3_EqualityOperator_SameValues_IsTrue()
    {
        using var a = new JPH.Double3(1.0, 2.0, 3.0);
        using var b = new JPH.Double3(1.0, 2.0, 3.0);
        Assert.True(a == b);
    }

    [Fact]
    public void Double3_EqualityOperator_DifferentValues_IsFalse()
    {
        using var a = new JPH.Double3(1.0, 2.0, 3.0);
        using var b = new JPH.Double3(1.0, 2.0, 4.0);
        Assert.False(a == b);
    }

    [Fact]
    public void Double3_InequalityOperator_DifferentValues_IsTrue()
    {
        using var a = new JPH.Double3(1.0, 2.0, 3.0);
        using var b = new JPH.Double3(0.0, 2.0, 3.0);
        Assert.True(a != b);
    }

    [Fact]
    public void Double3_InequalityOperator_SameValues_IsFalse()
    {
        using var a = new JPH.Double3(5.0, 6.0, 7.0);
        using var b = new JPH.Double3(5.0, 6.0, 7.0);
        Assert.False(a != b);
    }

    [Fact]
    public void Double3_Equals_Method_SameValues_IsTrue()
    {
        using var a = new JPH.Double3(7.0, 8.0, 9.0);
        using var b = new JPH.Double3(7.0, 8.0, 9.0);
        Assert.True(a.Equals(b));
    }

    [Fact]
    public void Double3_CopyConstruct_ValuesMatch()
    {
        using var a = new JPH.Double3(3.14, 2.71, 1.41);
        using var b = new JPH.Double3((JPH.Const_Double3)a);
        Assert.True(a == b);
    }
}
