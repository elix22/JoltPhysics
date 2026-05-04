// Hand-written additions to the generated JPH bindings.
// This file is NOT machine-generated and will NOT be overwritten by generate.sh.
// Location: csharp/extras/ (outside csharp/src/ which clean.sh deletes).
//
// It lives in the same assembly as the generated code, which allows it to call
// the internal constructors used to wrap raw C pointers into managed objects.

using System;
using System.Runtime.InteropServices;
using System.Text;

// ---------------------------------------------------------------------------
// Extension methods on generated JPH inner classes.
// Must live in a non-nested static class to qualify as extension methods.
// ---------------------------------------------------------------------------
public static unsafe class JoltExtensions
{
    // ---- Skeleton.AddJoint(string) overloads ----------------------------------
    //
    // The auto-generated JoltHelpers.SkeletonAddJoint takes 'byte?' (a nullable
    // pointer to a single byte — not a null-terminated C string). These overloads
    // marshal a managed string to a UTF-8 null-terminated byte* and call the C
    // function directly.

    public static uint AddJoint(this JPH.Skeleton skeleton, string name)
    {
        #if __IOS__
        [DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_SkeletonAddJoint", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [DllImport("cjolt", EntryPoint = "JoltHelpers_SkeletonAddJoint", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static uint __impl(JPH.Skeleton._Underlying* s, byte* n);

        var p = Utf8Alloc(name);
        try { return __impl(skeleton._UnderlyingPtr, (byte*)p); }
        finally { Marshal.FreeCoTaskMem(p); }
    }

    public static uint AddJoint(this JPH.Skeleton skeleton, string name, string parentName)
    {
        #if __IOS__
        [DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_SkeletonAddJointWithParentName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [DllImport("cjolt", EntryPoint = "JoltHelpers_SkeletonAddJointWithParentName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static uint __impl(JPH.Skeleton._Underlying* s, byte* n, byte* pn);

        var p  = Utf8Alloc(name);
        var pp = Utf8Alloc(parentName);
        try { return __impl(skeleton._UnderlyingPtr, (byte*)p, (byte*)pp); }
        finally { Marshal.FreeCoTaskMem(p); Marshal.FreeCoTaskMem(pp); }
    }

    public static uint AddJoint(this JPH.Skeleton skeleton, string name, int parentIndex)
    {
        #if __IOS__
        [DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_SkeletonAddJointWithParentIndex", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [DllImport("cjolt", EntryPoint = "JoltHelpers_SkeletonAddJointWithParentIndex", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static uint __impl(JPH.Skeleton._Underlying* s, byte* n, int idx);

        var p = Utf8Alloc(name);
        try { return __impl(skeleton._UnderlyingPtr, (byte*)p, parentIndex); }
        finally { Marshal.FreeCoTaskMem(p); }
    }

    // Allocate a null-terminated UTF-8 copy of s on the CoTaskMem heap.
    // Caller must free with Marshal.FreeCoTaskMem.
    // Avoids Marshal.StringToCoTaskMemUTF8 which is only in .NET 5+.
    private static IntPtr Utf8Alloc(string s)
    {
        var bytes = Encoding.UTF8.GetBytes(s);
        var ptr   = Marshal.AllocCoTaskMem(bytes.Length + 1);
        Marshal.Copy(bytes, 0, ptr, bytes.Length);
        Marshal.WriteByte(ptr, bytes.Length, 0);
        return ptr;
    }
}

// ---------------------------------------------------------------------------
// Additions to the JPH partial class.
// ---------------------------------------------------------------------------
public static partial class JPH
{
    // ---- Vec3f: blittable value-type for ConvexHullShapeSettingsFromPoints ----
    //
    // Same sequential {float X, Y, Z} layout as JPH::Float3.
    // Defined here to avoid a System.Numerics.Vectors dependency not otherwise
    // needed by the library.

    [StructLayout(LayoutKind.Sequential)]
    public struct Vec3f
    {
        public float X, Y, Z;
        public Vec3f(float x, float y, float z) { X = x; Y = y; Z = z; }
    }

    // ---- ConvexHullShapeSettings from Vec3f[] ----------------------------------
    //
    // Vec3f has the same sequential layout as JPH::Float3 (float x, y, z),
    // so pinning the managed array and passing the pointer directly is safe.

    public static unsafe ConvexHullShapeSettings ConvexHullShapeSettingsFromPoints(
        Vec3f[] points,
        float maxConvexRadius = 0.05f,
        Const_PhysicsMaterial? material = null)
    {
        #if __IOS__
        [DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_ConvexHullShapeSettingsFromFloat3Array", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [DllImport("cjolt", EntryPoint = "JoltHelpers_ConvexHullShapeSettingsFromFloat3Array", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static ConvexHullShapeSettings._Underlying* __create(Vec3f* pts, int n, float r, Const_PhysicsMaterial._Underlying* mat);

        #if __IOS__
        [DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ConvexHullShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [DllImport("cjolt", EntryPoint = "JPH_ConvexHullShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static void* __upcast(ConvexHullShapeSettings._Underlying* p);

        #if __IOS__
        [DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static void __addref(void* p);

        ConvexHullShapeSettings._Underlying* ptr;
        fixed (Vec3f* p = points)
            ptr = __create(p, points.Length, maxConvexRadius, material != null ? material._UnderlyingPtr : null);
        __addref(__upcast(ptr));
        return new ConvexHullShapeSettings(ptr, is_owning: true);
    }

    // ---- ContactListenerTrampolineManaged -------------------------------------
    //
    // Wraps ContactListenerTrampoline and provides:
    //   - GCHandle management: pinned delegate references stay alive while the
    //     C side holds raw function pointers into them.
    //   - Managed-typed callbacks: raw C pointers are wrapped in non-owning
    //     JPH managed objects before the user delegate is invoked.
    //
    // Usage:
    //   using var listener = new JPH.ContactListenerTrampolineManaged();
    //   listener.SetOnContactAdded((body1, body2, manifold, settings) => { ... });
    //   physicsSystem.SetContactListener(listener.Inner);

    public sealed class ContactListenerTrampolineManaged : IDisposable
    {
        public delegate ValidateResult ValidateCallback(
            Const_Body body1, Const_Body body2,
            Const_Vec3 baseOffset, Const_CollideShapeResult result);

        public delegate void AddedCallback(
            Const_Body body1, Const_Body body2,
            Const_ContactManifold manifold, ContactSettings settings);

        public delegate void PersistedCallback(
            Const_Body body1, Const_Body body2,
            Const_ContactManifold manifold, ContactSettings settings);

        public delegate void RemovedCallback(Const_SubShapeIDPair pair);

        // Raw C-compatible delegate types using void* to avoid exposing internal
        // _Underlying types in delegate signatures (which C# forbids in public/internal
        // delegates due to accessibility rules).
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate ValidateResult RawValidate(void* ctx, void* b1, void* b2, void* off, void* res);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void RawAdded(void* ctx, void* b1, void* b2, void* m, void* s);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void RawPersisted(void* ctx, void* b1, void* b2, void* m, void* s);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private unsafe delegate void RawRemoved(void* ctx, void* pair);

        public readonly ContactListenerTrampoline Inner;

        private GCHandle _validateHandle;
        private GCHandle _addedHandle;
        private GCHandle _persistedHandle;
        private GCHandle _removedHandle;

        public ContactListenerTrampolineManaged() { Inner = new ContactListenerTrampoline(); }

        public unsafe void SetOnContactValidate(ValidateCallback callback)
        {
            RawValidate raw = (ctx, b1, b2, off, res) =>
                callback(
                    new Const_Body((Const_Body._Underlying*)b1, false),
                    new Const_Body((Const_Body._Underlying*)b2, false),
                    new Const_Vec3((Vec3._Underlying*)off, false),
                    new Const_CollideShapeResult((Const_CollideShapeResult._Underlying*)res, false));
            if (_validateHandle.IsAllocated) _validateHandle.Free();
            _validateHandle = GCHandle.Alloc(raw);
            Inner.SetOnContactValidateFn((void*)Marshal.GetFunctionPointerForDelegate(raw));
        }

        public unsafe void SetOnContactAdded(AddedCallback callback)
        {
            RawAdded raw = (ctx, b1, b2, m, s) =>
                callback(
                    new Const_Body((Const_Body._Underlying*)b1, false),
                    new Const_Body((Const_Body._Underlying*)b2, false),
                    new Const_ContactManifold((Const_ContactManifold._Underlying*)m, false),
                    new ContactSettings((ContactSettings._Underlying*)s, false));
            if (_addedHandle.IsAllocated) _addedHandle.Free();
            _addedHandle = GCHandle.Alloc(raw);
            Inner.SetOnContactAddedFn((void*)Marshal.GetFunctionPointerForDelegate(raw));
        }

        public unsafe void SetOnContactPersisted(PersistedCallback callback)
        {
            RawPersisted raw = (ctx, b1, b2, m, s) =>
                callback(
                    new Const_Body((Const_Body._Underlying*)b1, false),
                    new Const_Body((Const_Body._Underlying*)b2, false),
                    new Const_ContactManifold((Const_ContactManifold._Underlying*)m, false),
                    new ContactSettings((ContactSettings._Underlying*)s, false));
            if (_persistedHandle.IsAllocated) _persistedHandle.Free();
            _persistedHandle = GCHandle.Alloc(raw);
            Inner.SetOnContactPersistedFn((void*)Marshal.GetFunctionPointerForDelegate(raw));
        }

        public unsafe void SetOnContactRemoved(RemovedCallback callback)
        {
            RawRemoved raw = (ctx, pair) =>
                callback(new Const_SubShapeIDPair((Const_SubShapeIDPair._Underlying*)pair, false));
            if (_removedHandle.IsAllocated) _removedHandle.Free();
            _removedHandle = GCHandle.Alloc(raw);
            Inner.SetOnContactRemovedFn((void*)Marshal.GetFunctionPointerForDelegate(raw));
        }

        public void Dispose()
        {
            if (_validateHandle.IsAllocated)  _validateHandle.Free();
            if (_addedHandle.IsAllocated)     _addedHandle.Free();
            if (_persistedHandle.IsAllocated) _persistedHandle.Free();
            if (_removedHandle.IsAllocated)   _removedHandle.Free();
            Inner.Dispose();
        }
    }
}
