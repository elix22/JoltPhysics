// Tests for MeshShape and MeshShapeSettings (shape object, beyond settings tests).
// Note: constructing a fully populated MeshShape requires vertex+triangle arrays
// which are not exposed through the C/C# bindings (mTriangleVertices and
// mIndexedTriangles fields on MeshShapeSettings are not bound). These tests
// cover the default-constructed MeshShape and its static constant.
//
// INVESTIGATION: MeshShape_GetLocalBounds, GetStats, GetSubShapeIDBitsRecursive
// crash on default-constructed MeshShape. Root cause is C++ (NOT a C# binding
// bug): MeshShape::GetLocalBounds/GetStats/GetSubShapeIDBitsRecursive all call
// sGetNodeHeader(mTree) -> mTree.at(0) on an empty ByteBuffer (std::vector<uint8>)
// which is UB / crash in release mode. The C binding forwards the call directly
// with only a null-pointer check on `this`, not on the tree contents.
// Skipped with [Fact(Skip=...)] to document the gap; restore when bindings
// expose a way to build a populated MeshShape.
//
// Tested APIs:
//   - MeshShape default constructor
//   - CGetTrianglesMinTrianglesRequested static constant
//   - MustBeStatic() returns true
//   - GetUserData round-trip
//   - GetLocalBounds of default shape   [SKIPPED — empty tree crash in C++]
//   - GetStats size field               [SKIPPED — empty tree crash in C++]
//   - GetSubShapeIDBitsRecursive        [SKIPPED — empty tree crash in C++]

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_MeshShape(JoltFixture fx)
{
    [Fact]
    public void MeshShape_DefaultConstruct_NoCrash()
    {
        var ex = Record.Exception(() => { using var s = new JPH.MeshShape(); });
        Assert.Null(ex);
    }

    [Fact]
    public void MeshShape_CGetTrianglesMinTrianglesRequested_IsPositive()
    {
        int v = JPH.Const_MeshShape.CGetTrianglesMinTrianglesRequested;
        Assert.True(v > 0);
    }

    [Fact]
    public void MeshShape_MustBeStatic_IsTrue()
    {
        using var s = new JPH.MeshShape();
        Assert.True(s.MustBeStatic());
    }

    [Fact]
    public void MeshShape_GetUserData_DefaultIsZero()
    {
        using var s = new JPH.MeshShape();
        Assert.Equal(UIntPtr.Zero, s.GetUserData());
    }

    // SKIPPED: GetLocalBounds crashes on default-constructed MeshShape.
    // C++ root cause: MeshShape::GetLocalBounds() calls sGetNodeHeader(mTree) which
    // calls mTree.at(0) on an empty ByteBuffer. This is not a C# binding bug.
    // Needs a populated MeshShape (triangle data) to be safe; triangle arrays are
    // not yet exposed through the bindings.
    [Fact(Skip = "Default MeshShape has empty BVH tree; GetLocalBounds calls sGetNodeHeader(mTree) -> at(0) on empty ByteBuffer (C++ UB/crash, not a binding bug)")]
    public void MeshShape_GetLocalBounds_NoCrash()
    {
        using var s  = new JPH.MeshShape();
        using var bb = s.GetLocalBounds();
        Assert.NotNull(bb);
    }

    // SKIPPED: GetStats crashes on default-constructed MeshShape.
    // C++ root cause: MeshShape::GetStats() calls WalkTree() -> sGetNodeHeader(mTree)
    // -> mTree.at(0) on empty ByteBuffer. Same root cause as GetLocalBounds.
    [Fact(Skip = "Default MeshShape has empty BVH tree; GetStats calls WalkTree -> sGetNodeHeader(mTree) -> at(0) on empty ByteBuffer (C++ UB/crash, not a binding bug)")]
    public void MeshShape_GetStats_NoCrash()
    {
        using var s    = new JPH.MeshShape();
        var       stat = s.GetStats();
        Assert.True(stat.mSizeBytes > 0);
    }

    // SKIPPED: GetSubShapeIDBitsRecursive crashes on default-constructed MeshShape.
    // C++ root cause: same sGetNodeHeader(mTree) -> at(0) issue.
    [Fact(Skip = "Default MeshShape has empty BVH tree; GetSubShapeIDBitsRecursive calls sGetNodeHeader(mTree) -> at(0) on empty ByteBuffer (C++ UB/crash, not a binding bug)")]
    public void MeshShape_GetSubShapeIDBitsRecursive_NoCrash()
    {
        using var s = new JPH.MeshShape();
        var _ = s.GetSubShapeIDBitsRecursive();
    }
}
