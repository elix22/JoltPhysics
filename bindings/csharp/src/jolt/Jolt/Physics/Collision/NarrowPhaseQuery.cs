// machine generated, do not edit
public static partial class JPH
{
    /// Class that provides an interface for doing precise collision detection against the broad and then the narrow phase.
    /// Unlike a BroadPhaseQuery, the NarrowPhaseQuery will test against shapes and will return collision information against triangles, spheres etc.
    /// Generated from class `JPH::NarrowPhaseQuery`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_NarrowPhaseQuery : JPH.Object<Const_NarrowPhaseQuery>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_NarrowPhaseQuery_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_NarrowPhaseQuery_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_NarrowPhaseQuery_Destroy(_Underlying *_this);
            __JPH_NarrowPhaseQuery_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_NarrowPhaseQuery() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_NarrowPhaseQuery self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_NarrowPhaseQuery_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_NarrowPhaseQuery_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_NarrowPhaseQuery_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_NarrowPhaseQuery_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe Const_NarrowPhaseQuery(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_NarrowPhaseQuery() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_NarrowPhaseQuery_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_NarrowPhaseQuery_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NarrowPhaseQuery._Underlying *__JPH_NarrowPhaseQuery_DefaultConstruct();
            _UnderlyingPtr = __JPH_NarrowPhaseQuery_DefaultConstruct();
        }
    }

    /// Class that provides an interface for doing precise collision detection against the broad and then the narrow phase.
    /// Unlike a BroadPhaseQuery, the NarrowPhaseQuery will test against shapes and will return collision information against triangles, spheres etc.
    /// Generated from class `JPH::NarrowPhaseQuery`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class NarrowPhaseQuery : Const_NarrowPhaseQuery
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(NarrowPhaseQuery self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_NarrowPhaseQuery_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_NarrowPhaseQuery_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_NarrowPhaseQuery_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_NarrowPhaseQuery_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe NarrowPhaseQuery(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe NarrowPhaseQuery() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_NarrowPhaseQuery_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_NarrowPhaseQuery_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NarrowPhaseQuery._Underlying *__JPH_NarrowPhaseQuery_DefaultConstruct();
            _UnderlyingPtr = __JPH_NarrowPhaseQuery_DefaultConstruct();
        }
    }

    /// This is used as a function parameter when the underlying function receives `NarrowPhaseQuery` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_NarrowPhaseQuery
    {
        #pragma warning disable CS0649
        internal readonly Const_NarrowPhaseQuery? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_NarrowPhaseQuery() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `NarrowPhaseQuery` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_NarrowPhaseQuery`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `NarrowPhaseQuery`/`Const_NarrowPhaseQuery` directly.
    public class _InOptMut_NarrowPhaseQuery
    {
        public NarrowPhaseQuery? Opt;

        public _InOptMut_NarrowPhaseQuery() {}
        public _InOptMut_NarrowPhaseQuery(NarrowPhaseQuery value) {Opt = value;}
        public static implicit operator _InOptMut_NarrowPhaseQuery(NarrowPhaseQuery value) {return new(value);}
    }

    /// This is used for optional parameters of class `NarrowPhaseQuery` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_NarrowPhaseQuery`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `NarrowPhaseQuery`/`Const_NarrowPhaseQuery` to pass it to the function.
    public class _InOptConst_NarrowPhaseQuery
    {
        public Const_NarrowPhaseQuery? Opt;

        public _InOptConst_NarrowPhaseQuery() {}
        public _InOptConst_NarrowPhaseQuery(Const_NarrowPhaseQuery value) {Opt = value;}
        public static implicit operator _InOptConst_NarrowPhaseQuery(Const_NarrowPhaseQuery value) {return new(value);}
    }
}
