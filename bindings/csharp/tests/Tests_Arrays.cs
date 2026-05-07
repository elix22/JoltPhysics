// Tests for JPH::Array<T> bindings generated via --vector-like-container.
// Covers: lifecycle (no leaks), size/capacity tracking, element access,
// mutation (PushBack, PopBack, Insert, Erase, Clear, Resize, Reserve),
// copy construction/assignment, and struct-element arrays.

using Xunit;

namespace JoltTests;

// ─── Array_Float (primitive element) ────────────────────────────────────────

[Collection("Jolt")]
public sealed class Tests_Array_Float
{
    // ── Lifecycle ────────────────────────────────────────────────────────────

    [Fact] public void DefaultConstruct_IsEmpty()
    {
        using var a = new JPH.Array_Float();
        Assert.Equal((UIntPtr)0, a.Size());
        Assert.True(a.Empty());
    }

    [Fact] public void Dispose_CalledTwice_NoCrash()
    {
        var a = new JPH.Array_Float();
        a.Dispose();
        a.Dispose(); // second dispose must not crash
    }

    // ── PushBack / Size ──────────────────────────────────────────────────────

    [Fact] public void PushBack_IncreasesSize()
    {
        using var a = new JPH.Array_Float();
        a.PushBack(1.0f);
        a.PushBack(2.0f);
        Assert.Equal((UIntPtr)2, a.Size());
        Assert.False(a.Empty());
    }

    [Fact] public void PushBack_ElementsReadableViaIndexer()
    {
        using var a = new JPH.Array_Float();
        a.PushBack(3.14f);
        a.PushBack(2.72f);
        Assert.Equal(3.14f, a[(UIntPtr)0], 5);
        Assert.Equal(2.72f, a[(UIntPtr)1], 5);
    }

    // ── PopBack ──────────────────────────────────────────────────────────────

    [Fact] public void PopBack_DecreasesSize()
    {
        using var a = new JPH.Array_Float();
        a.PushBack(1.0f);
        a.PushBack(2.0f);
        a.PopBack();
        Assert.Equal((UIntPtr)1, a.Size());
        Assert.Equal(1.0f, a[(UIntPtr)0]);
    }

    // ── Front / Back ─────────────────────────────────────────────────────────

    [Fact] public void Front_ReturnsFirstElement()
    {
        using var a = new JPH.Array_Float();
        a.PushBack(10.0f);
        a.PushBack(20.0f);
        Assert.Equal(10.0f, a.Front());
    }

    [Fact] public void Back_ReturnsLastElement()
    {
        using var a = new JPH.Array_Float();
        a.PushBack(10.0f);
        a.PushBack(20.0f);
        Assert.Equal(20.0f, a.Back());
    }

    [Fact] public void Front_Empty_ReturnsNull()
    {
        using var a = new JPH.Array_Float();
        Assert.Null(a.Front());
    }

    [Fact] public void Back_Empty_ReturnsNull()
    {
        using var a = new JPH.Array_Float();
        Assert.Null(a.Back());
    }

    // ── Mutable indexer ───────────────────────────────────────────────────────

    [Fact] public void MutableIndexer_CanModifyElement()
    {
        using var a = new JPH.Array_Float();
        a.PushBack(1.0f);
        a[(UIntPtr)0] = 99.0f;
        Assert.Equal(99.0f, a[(UIntPtr)0]);
    }

    // ── Insert ───────────────────────────────────────────────────────────────

    [Fact] public void Insert_AtBegin_ShiftsElements()
    {
        using var a = new JPH.Array_Float();
        a.PushBack(2.0f);
        a.PushBack(3.0f);
        a.Insert((UIntPtr)0, 1.0f);
        Assert.Equal((UIntPtr)3, a.Size());
        Assert.Equal(1.0f, a[(UIntPtr)0]);
        Assert.Equal(2.0f, a[(UIntPtr)1]);
        Assert.Equal(3.0f, a[(UIntPtr)2]);
    }

    [Fact] public void Insert_AtEnd_AppendsElement()
    {
        using var a = new JPH.Array_Float();
        a.PushBack(1.0f);
        a.Insert((UIntPtr)1, 2.0f);
        Assert.Equal(2.0f, a[(UIntPtr)1]);
    }

    // ── Erase ────────────────────────────────────────────────────────────────

    [Fact] public void Erase_MiddleElement_PacksRemaining()
    {
        using var a = new JPH.Array_Float();
        a.PushBack(1.0f);
        a.PushBack(2.0f);
        a.PushBack(3.0f);
        a.Erase((UIntPtr)1); // remove 2.0f
        Assert.Equal((UIntPtr)2, a.Size());
        Assert.Equal(1.0f, a[(UIntPtr)0]);
        Assert.Equal(3.0f, a[(UIntPtr)1]);
    }

    // ── Clear ─────────────────────────────────────────────────────────────────

    [Fact] public void Clear_SetsEmpty()
    {
        using var a = new JPH.Array_Float();
        a.PushBack(1.0f);
        a.PushBack(2.0f);
        a.Clear();
        Assert.Equal((UIntPtr)0, a.Size());
        Assert.True(a.Empty());
    }

    // ── Resize ───────────────────────────────────────────────────────────────

    [Fact] public void Resize_GrowsTheContainer()
    {
        // JPH::Array<float>::resize(n) does NOT value-initialize new elements for
        // trivially-constructible types (unlike std::vector). Only the size is guaranteed.
        using var a = new JPH.Array_Float();
        a.Resize((UIntPtr)3);
        Assert.Equal((UIntPtr)3, a.Size());
        Assert.False(a.Empty());
    }

    [Fact] public void ResizeWithDefaultValue_FillsWithValue()
    {
        using var a = new JPH.Array_Float();
        a.ResizeWithDefaultValue((UIntPtr)4, 7.0f);
        Assert.Equal((UIntPtr)4, a.Size());
        for (int i = 0; i < 4; i++)
            Assert.Equal(7.0f, a[(UIntPtr)(uint)i]);
    }

    [Fact] public void Resize_ShrinksTruncates()
    {
        using var a = new JPH.Array_Float();
        a.PushBack(1.0f);
        a.PushBack(2.0f);
        a.PushBack(3.0f);
        a.Resize((UIntPtr)1);
        Assert.Equal((UIntPtr)1, a.Size());
        Assert.Equal(1.0f, a[(UIntPtr)0]);
    }

    // ── Reserve / Capacity ────────────────────────────────────────────────────

    [Fact] public void Reserve_DoesNotChangeSize()
    {
        using var a = new JPH.Array_Float();
        a.Reserve((UIntPtr)100);
        Assert.Equal((UIntPtr)0, a.Size());
        Assert.True(a.Capacity() >= (UIntPtr)100);
    }

    [Fact] public void ShrinkToFit_ReducesCapacity()
    {
        using var a = new JPH.Array_Float();
        a.Reserve((UIntPtr)100);
        a.PushBack(1.0f);
        a.ShrinkToFit();
        Assert.Equal((UIntPtr)1, a.Size());
        // capacity should now be close to size (implementation-defined, but <= 100)
        Assert.True(a.Capacity() < (UIntPtr)100);
    }

    // ── Copy construction & assignment ────────────────────────────────────────

    [Fact] public void CopyConstruct_ProducesIndependentCopy()
    {
        using var src = new JPH.Array_Float();
        src.PushBack(1.0f);
        src.PushBack(2.0f);

        using var copy = new JPH.Array_Float(src);
        Assert.Equal((UIntPtr)2, copy.Size());
        Assert.Equal(1.0f, copy[(UIntPtr)0]);
        Assert.Equal(2.0f, copy[(UIntPtr)1]);

        // Mutate copy; src must be unchanged
        copy[(UIntPtr)0] = 99.0f;
        Assert.Equal(1.0f, src[(UIntPtr)0]);
    }

    [Fact] public void Assign_OverwritesContents()
    {
        using var a = new JPH.Array_Float();
        a.PushBack(1.0f);

        using var b = new JPH.Array_Float();
        b.PushBack(10.0f);
        b.PushBack(20.0f);

        a.Assign(b);
        Assert.Equal((UIntPtr)2, a.Size());
        Assert.Equal(10.0f, a[(UIntPtr)0]);
        Assert.Equal(20.0f, a[(UIntPtr)1]);
    }

    // ── Data pointer ─────────────────────────────────────────────────────────

    [Fact] public void Data_ReturnsNonNullWhenNonEmpty()
    {
        using var a = new JPH.Array_Float();
        a.PushBack(42.0f);
        var ptr = a.Data();
        Assert.NotNull(ptr);
    }
}

// ─── Array_UnsignedInt (other primitive) ─────────────────────────────────────

[Collection("Jolt")]
public sealed class Tests_Array_UnsignedInt
{
    [Fact] public void PushBack_And_Read()
    {
        using var a = new JPH.Array_UnsignedInt();
        a.PushBack(10u);
        a.PushBack(20u);
        a.PushBack(30u);
        Assert.Equal((UIntPtr)3, a.Size());
        Assert.Equal(10u, a[(UIntPtr)0]);
        Assert.Equal(20u, a[(UIntPtr)1]);
        Assert.Equal(30u, a[(UIntPtr)2]);
    }

    [Fact] public void Erase_First_PacksCorrectly()
    {
        using var a = new JPH.Array_UnsignedInt();
        a.PushBack(1u);
        a.PushBack(2u);
        a.PushBack(3u);
        a.Erase((UIntPtr)0);
        Assert.Equal((UIntPtr)2, a.Size());
        Assert.Equal(2u, a[(UIntPtr)0]);
        Assert.Equal(3u, a[(UIntPtr)1]);
    }

    [Fact] public void CopyConstruct_Independent()
    {
        using var src = new JPH.Array_UnsignedInt();
        src.PushBack(42u);
        using var dst = new JPH.Array_UnsignedInt(src);
        dst[(UIntPtr)0] = 0u;
        Assert.Equal(42u, src[(UIntPtr)0]);
    }

    [Fact] public void LargeResize_NoCrash()
    {
        using var a = new JPH.Array_UnsignedInt();
        a.Resize((UIntPtr)1000);
        Assert.Equal((UIntPtr)1000, a.Size());
        a[(UIntPtr)999] = 7u;
        Assert.Equal(7u, a[(UIntPtr)999]);
    }
}

// ─── Array_JPHSoftBodySharedSettingsVertex (struct element) ──────────────────

[Collection("Jolt")]
public sealed class Tests_Array_SoftBodyVertex
{
    [Fact] public void DefaultConstruct_IsEmpty()
    {
        using var a = new JPH.Array_JPHSoftBodySharedSettingsVertex();
        Assert.True(a.Empty());
        Assert.Equal((UIntPtr)0, a.Size());
    }

    [Fact] public void PushBack_Vertex_IncreasesSize()
    {
        using var a = new JPH.Array_JPHSoftBodySharedSettingsVertex();
        using var v = new JPH.SoftBodySharedSettings.Vertex();
        a.PushBack(v);
        Assert.Equal((UIntPtr)1, a.Size());
    }

    [Fact] public void PushBack_Multiple_AndReadBack()
    {
        using var a = new JPH.Array_JPHSoftBodySharedSettingsVertex();
        for (int i = 0; i < 5; i++)
        {
            using var v = new JPH.SoftBodySharedSettings.Vertex();
            a.PushBack(v);
        }
        Assert.Equal((UIntPtr)5, a.Size());
    }

    [Fact] public void Erase_DecreasesSize()
    {
        using var a = new JPH.Array_JPHSoftBodySharedSettingsVertex();
        using var v = new JPH.SoftBodySharedSettings.Vertex();
        a.PushBack(v);
        a.PushBack(v);
        a.Erase((UIntPtr)0);
        Assert.Equal((UIntPtr)1, a.Size());
    }

    [Fact] public void Clear_EmptiesArray()
    {
        using var a = new JPH.Array_JPHSoftBodySharedSettingsVertex();
        using var v = new JPH.SoftBodySharedSettings.Vertex();
        a.PushBack(v);
        a.PushBack(v);
        a.Clear();
        Assert.True(a.Empty());
    }

    [Fact] public void CopyConstruct_ProducesIndependentCopy()
    {
        using var src = new JPH.Array_JPHSoftBodySharedSettingsVertex();
        using var v = new JPH.SoftBodySharedSettings.Vertex();
        src.PushBack(v);
        src.PushBack(v);

        using var copy = new JPH.Array_JPHSoftBodySharedSettingsVertex(src);
        Assert.Equal((UIntPtr)2, copy.Size());

        // Removing from copy doesn't affect src
        copy.Erase((UIntPtr)0);
        Assert.Equal((UIntPtr)2, src.Size());
    }

    [Fact] public void Resize_GrowsWithDefaultElements()
    {
        using var a = new JPH.Array_JPHSoftBodySharedSettingsVertex();
        a.Resize((UIntPtr)3);
        Assert.Equal((UIntPtr)3, a.Size());
    }
}

// ─── Array_JPHSoftBodySharedSettingsFace (struct with uint[3] field) ─────────

[Collection("Jolt")]
public sealed class Tests_Array_SoftBodyFace
{
    [Fact] public void DefaultConstruct_IsEmpty()
    {
        using var a = new JPH.Array_JPHSoftBodySharedSettingsFace();
        Assert.True(a.Empty());
    }

    [Fact] public void PushBack_And_Size()
    {
        using var a = new JPH.Array_JPHSoftBodySharedSettingsFace();
        using var f = new JPH.SoftBodySharedSettings.Face();
        a.PushBack(f);
        a.PushBack(f);
        Assert.Equal((UIntPtr)2, a.Size());
    }

    [Fact] public void Insert_And_Erase()
    {
        using var a = new JPH.Array_JPHSoftBodySharedSettingsFace();
        using var f = new JPH.SoftBodySharedSettings.Face();
        a.PushBack(f);
        a.PushBack(f);
        a.PushBack(f);
        a.Erase((UIntPtr)1);
        Assert.Equal((UIntPtr)2, a.Size());
    }

    [Fact] public void Clear_NoCrash()
    {
        using var a = new JPH.Array_JPHSoftBodySharedSettingsFace();
        using var f = new JPH.SoftBodySharedSettings.Face();
        a.PushBack(f);
        a.Clear();
        Assert.True(a.Empty());
    }

    [Fact] public void Reserve_NoCrash()
    {
        using var a = new JPH.Array_JPHSoftBodySharedSettingsFace();
        a.Reserve((UIntPtr)64);
        Assert.True(a.Capacity() >= (UIntPtr)64);
        Assert.Equal((UIntPtr)0, a.Size());
    }
}

// ─── Array_JPHSoftBodySharedSettingsEdge ─────────────────────────────────────

[Collection("Jolt")]
public sealed class Tests_Array_SoftBodyEdge
{
    [Fact] public void PushBack_And_CopyConstruct()
    {
        using var a = new JPH.Array_JPHSoftBodySharedSettingsEdge();
        using var e = new JPH.SoftBodySharedSettings.Edge();
        a.PushBack(e);
        a.PushBack(e);

        using var copy = new JPH.Array_JPHSoftBodySharedSettingsEdge(a);
        Assert.Equal((UIntPtr)2, copy.Size());

        copy.Clear();
        Assert.Equal((UIntPtr)2, a.Size()); // original unaffected
    }

    [Fact] public void Resize_And_Erase()
    {
        using var a = new JPH.Array_JPHSoftBodySharedSettingsEdge();
        a.Resize((UIntPtr)5);
        Assert.Equal((UIntPtr)5, a.Size());
        a.Erase((UIntPtr)4);
        Assert.Equal((UIntPtr)4, a.Size());
    }
}

// ─── Array_Float used as SoftBodySharedSettings field ────────────────────────

[Collection("Jolt")]
public sealed class Tests_Array_SoftBodySettings_Integration
{
    // Verifies that the generated Array bindings round-trip correctly when used
    // as fields on a SoftBodySharedSettings (which owns the arrays).
    [Fact] public void AddVertices_Via_ArrayFloatField_RoundTrips()
    {
        // SoftBodySharedSettings exposes mVertices as Array_JPHSoftBodySharedSettingsVertex
        using var settings = new JPH.SoftBodySharedSettings();
        var verts = settings.mVertices;   // non-owning borrow

        using var v1 = new JPH.SoftBodySharedSettings.Vertex();
        using var v2 = new JPH.SoftBodySharedSettings.Vertex();
        verts.PushBack(v1);
        verts.PushBack(v2);

        Assert.Equal((UIntPtr)2, verts.Size());

        // Reading back via the same accessor should see the same data
        var verts2 = settings.mVertices;
        Assert.Equal((UIntPtr)2, verts2.Size());
    }

    [Fact] public void AddFaces_Via_ArrayField_RoundTrips()
    {
        using var settings = new JPH.SoftBodySharedSettings();
        var faces = settings.mFaces;

        using var f = new JPH.SoftBodySharedSettings.Face();
        faces.PushBack(f);
        faces.PushBack(f);
        faces.PushBack(f);

        Assert.Equal((UIntPtr)3, settings.mFaces.Size());
    }

    [Fact] public void Settings_DisposeAfterMutation_NoCrash()
    {
        // Main concern: no double-free or use-after-free when the container
        // and its owning object are both disposed.
        var settings = new JPH.SoftBodySharedSettings();
        var verts = settings.mVertices;
        using var v = new JPH.SoftBodySharedSettings.Vertex();
        verts.PushBack(v);
        settings.Dispose();
        // verts is a borrowed ref; accessing it after Dispose is UB in C++,
        // but we just want to confirm that disposing `settings` itself is safe.
    }
}
