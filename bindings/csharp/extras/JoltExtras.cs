// Hand-written additions to the generated JPH bindings.
// This file is NOT machine-generated and will NOT be overwritten by generate.sh.
// Location: csharp/extras/ (outside csharp/src/ which clean.sh deletes).
//
// It lives in the same assembly as the generated code, which allows it to call
// the internal constructors used to wrap raw C pointers into managed objects.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// ---------------------------------------------------------------------------
// Extension methods on generated JPH inner classes.
// Must live in a non-nested static class to qualify as extension methods.
// ---------------------------------------------------------------------------
public static unsafe partial class JoltExtensions
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

    public static int GetJointIndex(this JPH.Const_Skeleton skeleton, string name)
    {
        #if __IOS__
        [DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_SkeletonGetJointIndex", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [DllImport("cjolt", EntryPoint = "JoltHelpers_SkeletonGetJointIndex", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static int __impl(JPH.Const_Skeleton._Underlying* s, byte* n);
        var p = Utf8Alloc(name);
        try { return __impl(skeleton._UnderlyingPtr, (byte*)p); }
        finally { Marshal.FreeCoTaskMem(p); }
    }

    // ---- VehicleTransmissionSettings gear ratio setters ----------------------
    //
    // The generated JoltHelpers.VehicleTransmissionSettingsSetGearRatios takes
    // float? (mrbind treats const float* as an optional-pointer-to-scalar), so
    // it cannot pass a float array.  These overloads pin a managed float[] and
    // call the native function directly.

    public static unsafe void SetGearRatios(
        this JPH.VehicleTransmissionSettings trans, float[] ratios)
    {
        #if __IOS__
        [DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_VehicleTransmissionSettingsSetGearRatios", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [DllImport("cjolt", EntryPoint = "JoltHelpers_VehicleTransmissionSettingsSetGearRatios", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static void __impl(JPH.VehicleTransmissionSettings._Underlying* s, float* r, uint n);

        fixed (float* p = ratios)
            __impl(trans._UnderlyingPtr, p, (uint)ratios.Length);
    }

    public static unsafe void SetReverseGearRatios(
        this JPH.VehicleTransmissionSettings trans, float[] ratios)
    {
        #if __IOS__
        [DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_VehicleTransmissionSettingsSetReverseGearRatios", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [DllImport("cjolt", EntryPoint = "JoltHelpers_VehicleTransmissionSettingsSetReverseGearRatios", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static void __impl(JPH.VehicleTransmissionSettings._Underlying* s, float* r, uint n);

        fixed (float* p = ratios)
            __impl(trans._UnderlyingPtr, p, (uint)ratios.Length);
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
    // Wraps ContactListenerTrampoline and provides managed-typed callbacks.
    //
    // WASM/NativeAOT compatibility: uses [UnmanagedCallersOnly] static methods
    // and SetContext(GCHandle) instead of Marshal.GetFunctionPointerForDelegate,
    // which requires a JIT thunk and is unsupported on WebAssembly.
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

        // Holds all user callbacks; passed to the static trampolines via SetContext.
        private sealed class Callbacks
        {
            public ValidateCallback?  OnValidate;
            public AddedCallback?     OnAdded;
            public PersistedCallback? OnPersisted;
            public RemovedCallback?   OnRemoved;
        }

        public readonly ContactListenerTrampoline Inner;
        private GCHandle _callbacksHandle;

        public unsafe ContactListenerTrampolineManaged()
        {
            Inner = new ContactListenerTrampoline();
            var cbs = new Callbacks();
            _callbacksHandle = GCHandle.Alloc(cbs);
            Inner.SetContext((void*)GCHandle.ToIntPtr(_callbacksHandle));
        }

        private Callbacks GetCallbacks() => (Callbacks)_callbacksHandle.Target!;

        public unsafe void SetOnContactValidate(ValidateCallback callback)
        {
            GetCallbacks().OnValidate = callback;
            Inner.SetOnContactValidateFn(
                (void*)(delegate* unmanaged[Cdecl]<void*, void*, void*, void*, void*, int>)
                    &OnContactValidateStatic);
        }

        public unsafe void SetOnContactAdded(AddedCallback callback)
        {
            GetCallbacks().OnAdded = callback;
            Inner.SetOnContactAddedFn(
                (void*)(delegate* unmanaged[Cdecl]<void*, void*, void*, void*, void*, void>)
                    &OnContactAddedStatic);
        }

        public unsafe void SetOnContactPersisted(PersistedCallback callback)
        {
            GetCallbacks().OnPersisted = callback;
            Inner.SetOnContactPersistedFn(
                (void*)(delegate* unmanaged[Cdecl]<void*, void*, void*, void*, void*, void>)
                    &OnContactPersistedStatic);
        }

        public unsafe void SetOnContactRemoved(RemovedCallback callback)
        {
            GetCallbacks().OnRemoved = callback;
            Inner.SetOnContactRemovedFn(
                (void*)(delegate* unmanaged[Cdecl]<void*, void*, void>)
                    &OnContactRemovedStatic);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        private static unsafe int OnContactValidateStatic(
            void* ctx, void* b1, void* b2, void* off, void* res)
        {
            var cbs = (Callbacks)GCHandle.FromIntPtr((IntPtr)ctx).Target!;
            if (cbs.OnValidate == null)
                return (int)ValidateResult.AcceptAllContactsForThisBodyPair;
            return (int)cbs.OnValidate(
                new Const_Body((Const_Body._Underlying*)b1, false),
                new Const_Body((Const_Body._Underlying*)b2, false),
                new Const_Vec3((Vec3._Underlying*)off, false),
                new Const_CollideShapeResult((Const_CollideShapeResult._Underlying*)res, false));
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        private static unsafe void OnContactAddedStatic(
            void* ctx, void* b1, void* b2, void* m, void* s)
        {
            var cbs = (Callbacks)GCHandle.FromIntPtr((IntPtr)ctx).Target!;
            cbs.OnAdded?.Invoke(
                new Const_Body((Const_Body._Underlying*)b1, false),
                new Const_Body((Const_Body._Underlying*)b2, false),
                new Const_ContactManifold((Const_ContactManifold._Underlying*)m, false),
                new ContactSettings((ContactSettings._Underlying*)s, false));
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        private static unsafe void OnContactPersistedStatic(
            void* ctx, void* b1, void* b2, void* m, void* s)
        {
            var cbs = (Callbacks)GCHandle.FromIntPtr((IntPtr)ctx).Target!;
            cbs.OnPersisted?.Invoke(
                new Const_Body((Const_Body._Underlying*)b1, false),
                new Const_Body((Const_Body._Underlying*)b2, false),
                new Const_ContactManifold((Const_ContactManifold._Underlying*)m, false),
                new ContactSettings((ContactSettings._Underlying*)s, false));
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        private static unsafe void OnContactRemovedStatic(void* ctx, void* pair)
        {
            var cbs = (Callbacks)GCHandle.FromIntPtr((IntPtr)ctx).Target!;
            cbs.OnRemoved?.Invoke(
                new Const_SubShapeIDPair((Const_SubShapeIDPair._Underlying*)pair, false));
        }

        public void Dispose()
        {
            if (_callbacksHandle.IsAllocated) _callbacksHandle.Free();
            Inner.Dispose();
        }
    }

    // ---- SoftBodyContactListenerTrampolineManaged ----------------------------
    //
    // Wraps SoftBodyContactListenerTrampoline and provides managed-typed callbacks.
    //
    // Usage:
    //   using var listener = new JPH.SoftBodyContactListenerTrampolineManaged();
    //   listener.SetOnValidate((softBody, otherBody, settings) =>
    //   {
    //       settings.mInvMassScale2 = 0.1f;
    //       return SoftBodyValidateResult.AcceptContact;
    //   });
    //   listener.SetOnAdded((softBody, manifold) =>
    //   {
    //       uint count = JoltHelpers.SoftBodyManifoldGetVertexCount(manifold);
    //       for (uint i = 0; i < count; i++) { … }
    //   });
    //   physicsSystem.SetSoftBodyContactListener(listener.Inner);

    public sealed class SoftBodyContactListenerTrampolineManaged : IDisposable
    {
        public delegate SoftBodyValidateResult ValidateCallback(
            Const_Body softBody, Const_Body otherBody, SoftBodyContactSettings ioSettings);

        public delegate void AddedCallback(
            Const_Body softBody, Const_SoftBodyManifold manifold);

        private sealed class Callbacks
        {
            public ValidateCallback? OnValidate;
            public AddedCallback?    OnAdded;
        }

        public readonly SoftBodyContactListenerTrampoline Inner;
        private GCHandle _callbacksHandle;

        public unsafe SoftBodyContactListenerTrampolineManaged()
        {
            Inner = new SoftBodyContactListenerTrampoline();
            var cbs = new Callbacks();
            _callbacksHandle = GCHandle.Alloc(cbs);
            Inner.SetContext((void*)GCHandle.ToIntPtr(_callbacksHandle));
        }

        private Callbacks GetCallbacks() => (Callbacks)_callbacksHandle.Target!;

        public unsafe void SetOnValidate(ValidateCallback callback)
        {
            GetCallbacks().OnValidate = callback;
            Inner.SetOnValidateFn(
                (void*)(delegate* unmanaged[Cdecl]<void*, void*, void*, void*, int>)
                    &OnValidateStatic);
        }

        public unsafe void SetOnAdded(AddedCallback callback)
        {
            GetCallbacks().OnAdded = callback;
            Inner.SetOnAddedFn(
                (void*)(delegate* unmanaged[Cdecl]<void*, void*, void*, void>)
                    &OnAddedStatic);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        private static unsafe int OnValidateStatic(
            void* ctx, void* softBody, void* otherBody, void* settings)
        {
            var cbs = (Callbacks)GCHandle.FromIntPtr((IntPtr)ctx).Target!;
            if (cbs.OnValidate == null)
                return (int)SoftBodyValidateResult.AcceptContact;
            return (int)cbs.OnValidate(
                new Const_Body((Const_Body._Underlying*)softBody, false),
                new Const_Body((Const_Body._Underlying*)otherBody, false),
                new SoftBodyContactSettings((SoftBodyContactSettings._Underlying*)settings, false));
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        private static unsafe void OnAddedStatic(void* ctx, void* softBody, void* manifold)
        {
            var cbs = (Callbacks)GCHandle.FromIntPtr((IntPtr)ctx).Target!;
            cbs.OnAdded?.Invoke(
                new Const_Body((Const_Body._Underlying*)softBody, false),
                new Const_SoftBodyManifold((Const_SoftBodyManifold._Underlying*)manifold, false));
        }

        public void Dispose()
        {
            if (_callbacksHandle.IsAllocated) _callbacksHandle.Free();
            Inner.Dispose();
        }
    }
}
