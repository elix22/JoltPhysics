// Tests for RecordingDebugRenderer — a concrete implementation of
// JPH::DebugRendererSimple that records DrawLine / DrawTriangle calls.

using Xunit;

namespace JoltTests;

[Collection("Jolt")]
public sealed class Tests_DebugRenderer
{
    // -------------------------------------------------------------------------
    // Construction / singleton
    // -------------------------------------------------------------------------

    [Fact]
    public void RecordingDebugRenderer_Construct_SetsSingleton()
    {
        using var r = new JPH.RecordingDebugRenderer();
        Assert.NotNull(JPH.Const_DebugRenderer.SInstance);
    }

    [Fact]
    public void RecordingDebugRenderer_AfterDispose_SingletonCleared()
    {
        {
            using var r = new JPH.RecordingDebugRenderer();
            Assert.NotNull(JPH.Const_DebugRenderer.SInstance);
        }
        Assert.Null(JPH.Const_DebugRenderer.SInstance);
    }

    [Fact]
    public void RecordingDebugRenderer_InitialCounts_AreZero()
    {
        using var r = new JPH.RecordingDebugRenderer();
        Assert.Equal(0u, r.GetLineCount());
        Assert.Equal(0u, r.GetTriangleCount());
    }

    // -------------------------------------------------------------------------
    // DrawLine → GetLine
    // -------------------------------------------------------------------------

    [Fact]
    public void DrawLine_SingleCall_IncreasesLineCount()
    {
        using var r    = new JPH.RecordingDebugRenderer();
        using var from = new JPH.Vec3(0f, 0f, 0f);
        using var to   = new JPH.Vec3(1f, 0f, 0f);
        using var col  = JPH.Const_Color.SRed;

        JPH.Const_DebugRenderer.SInstance!.DrawLine(from, to, col);

        Assert.Equal(1u, r.GetLineCount());
    }

    [Fact]
    public void DrawLine_RecordsFromToColor()
    {
        using var r    = new JPH.RecordingDebugRenderer();
        using var from = new JPH.Vec3(1f, 2f, 3f);
        using var to   = new JPH.Vec3(4f, 5f, 6f);
        using var col  = JPH.Const_Color.SGreen;

        JPH.Const_DebugRenderer.SInstance!.DrawLine(from, to, col);

        using var rec = r.GetLine(0);
        using var recFrom  = rec.mFrom;
        using var recTo    = rec.mTo;
        using var recColor = rec.mColor;

        Assert.Equal(1f, recFrom.GetX(), precision: 4);
        Assert.Equal(2f, recFrom.GetY(), precision: 4);
        Assert.Equal(3f, recFrom.GetZ(), precision: 4);

        Assert.Equal(4f, recTo.GetX(), precision: 4);
        Assert.Equal(5f, recTo.GetY(), precision: 4);
        Assert.Equal(6f, recTo.GetZ(), precision: 4);

        // Green == (r=0, g=255, b=0, a=255) — just confirm it is green
        Assert.Equal(col, recColor);
    }

    [Fact]
    public void DrawLine_MultipleCalls_AllRecorded()
    {
        using var r   = new JPH.RecordingDebugRenderer();
        using var p0  = new JPH.Vec3(0f, 0f, 0f);
        using var p1  = new JPH.Vec3(1f, 0f, 0f);
        using var p2  = new JPH.Vec3(2f, 0f, 0f);
        using var col = JPH.Const_Color.SBlue;

        var inst = JPH.Const_DebugRenderer.SInstance!;
        inst.DrawLine(p0, p1, col);
        inst.DrawLine(p1, p2, col);
        inst.DrawLine(p0, p2, col);

        Assert.Equal(3u, r.GetLineCount());
    }

    // -------------------------------------------------------------------------
    // DrawWireBox → accumulates lines
    // -------------------------------------------------------------------------

    [Fact]
    public void DrawWireBox_ProducesLines()
    {
        using var r    = new JPH.RecordingDebugRenderer();
        using var min  = new JPH.Vec3(-1f, -1f, -1f);
        using var max  = new JPH.Vec3( 1f,  1f,  1f);
        using var box  = new JPH.AABox(min, max);
        using var col  = JPH.Const_Color.SWhite;

        JPH.Const_DebugRenderer.SInstance!.DrawWireBox(box, col);

        // A wireframe box has 12 edges
        Assert.Equal(12u, r.GetLineCount());
    }

    // -------------------------------------------------------------------------
    // DrawMarker → produces lines
    // -------------------------------------------------------------------------

    [Fact]
    public void DrawMarker_ProducesLines()
    {
        using var r   = new JPH.RecordingDebugRenderer();
        using var pos = new JPH.Vec3(0f, 1f, 0f);
        using var col = JPH.Const_Color.SRed;

        JPH.Const_DebugRenderer.SInstance!.DrawMarker(pos, col, 1f);

        Assert.True(r.GetLineCount() > 0);
    }

    // -------------------------------------------------------------------------
    // DrawArrow → produces lines
    // -------------------------------------------------------------------------

    [Fact]
    public void DrawArrow_ProducesLines()
    {
        using var r    = new JPH.RecordingDebugRenderer();
        using var from = new JPH.Vec3(0f, 0f, 0f);
        using var to   = new JPH.Vec3(0f, 5f, 0f);
        using var col  = JPH.Const_Color.SGreen;

        JPH.Const_DebugRenderer.SInstance!.DrawArrow(from, to, col, 0.5f);

        Assert.True(r.GetLineCount() > 0);
    }

    // -------------------------------------------------------------------------
    // Clear
    // -------------------------------------------------------------------------

    [Fact]
    public void Clear_ResetsLineCounts()
    {
        using var r    = new JPH.RecordingDebugRenderer();
        using var from = new JPH.Vec3(0f, 0f, 0f);
        using var to   = new JPH.Vec3(1f, 1f, 1f);
        using var col  = JPH.Const_Color.SRed;

        JPH.Const_DebugRenderer.SInstance!.DrawLine(from, to, col);
        Assert.Equal(1u, r.GetLineCount());

        r.Clear();
        Assert.Equal(0u, r.GetLineCount());
    }

    [Fact]
    public void Clear_ResetsTriangleCounts()
    {
        using var r    = new JPH.RecordingDebugRenderer();
        using var min  = new JPH.Vec3(-1f, -1f, -1f);
        using var max  = new JPH.Vec3( 1f,  1f,  1f);
        using var box  = new JPH.AABox(min, max);
        using var col  = JPH.Const_Color.SBlue;

        // DrawBox goes through the geometry pipeline → records triangles
        JPH.Const_DebugRenderer.SInstance!.DrawBox(box, col);
        uint trisBefore = r.GetTriangleCount();

        r.Clear();
        Assert.Equal(0u, r.GetTriangleCount());
        Assert.True(trisBefore > 0);
    }

    // -------------------------------------------------------------------------
    // DrawBox → records triangles
    // -------------------------------------------------------------------------

    [Fact]
    public void DrawBox_ProducesTriangles()
    {
        using var r    = new JPH.RecordingDebugRenderer();
        using var min  = new JPH.Vec3(-1f, -1f, -1f);
        using var max  = new JPH.Vec3( 1f,  1f,  1f);
        using var box  = new JPH.AABox(min, max);
        using var col  = JPH.Const_Color.SWhite;

        JPH.Const_DebugRenderer.SInstance!.DrawBox(box, col);

        // A solid box = 6 faces × 2 triangles = 12
        Assert.Equal(12u, r.GetTriangleCount());
    }

    [Fact]
    public void GetTriangle_ReturnsValidVertices()
    {
        using var r    = new JPH.RecordingDebugRenderer();
        using var min  = new JPH.Vec3(-1f, -1f, -1f);
        using var max  = new JPH.Vec3( 1f,  1f,  1f);
        using var box  = new JPH.AABox(min, max);
        using var col  = JPH.Const_Color.SWhite;

        JPH.Const_DebugRenderer.SInstance!.DrawBox(box, col);

        using var tri = r.GetTriangle(0);
        using var v1  = tri.mv1;
        using var v2  = tri.mv2;
        using var v3  = tri.mv3;

        // Each vertex should be on the surface of the unit box (±1)
        static void InRange(float v) => Assert.InRange(v, -1f, 1f);
        InRange(v1.GetX()); InRange(v1.GetY()); InRange(v1.GetZ());
        InRange(v2.GetX()); InRange(v2.GetY()); InRange(v2.GetZ());
        InRange(v3.GetX()); InRange(v3.GetY()); InRange(v3.GetZ());
    }
}
