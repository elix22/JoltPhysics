// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Interface to the broadphase that can perform collision queries. These queries will only test the bounding box of the body to quickly determine a potential set of colliding bodies.
        /// The shapes of the bodies are not tested, if you want this then you should use the NarrowPhaseQuery interface.
        /// Generated from class `JPH::BroadPhaseQuery`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::NonCopyable`
        /// This is the const half of the class.
        public class Const_BroadPhaseQuery : Jolt.Object<Const_BroadPhaseQuery>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseQuery_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseQuery_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_BroadPhaseQuery_Destroy(_Underlying *_this);
                __JPH_BroadPhaseQuery_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_BroadPhaseQuery() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_BroadPhaseQuery self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseQuery_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseQuery_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_BroadPhaseQuery_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_BroadPhaseQuery_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            internal unsafe Const_BroadPhaseQuery(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Get the bounding box of all objects in the broadphase
            /// Generated from method `JPH::BroadPhaseQuery::GetBounds`.
            public unsafe Jolt.JPH.AABox GetBounds()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseQuery_GetBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseQuery_GetBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.AABox._Underlying *__JPH_BroadPhaseQuery_GetBounds(_Underlying *_this);
                return new(__JPH_BroadPhaseQuery_GetBounds(_UnderlyingPtr), is_owning: true);
            }
        }

        /// Interface to the broadphase that can perform collision queries. These queries will only test the bounding box of the body to quickly determine a potential set of colliding bodies.
        /// The shapes of the bodies are not tested, if you want this then you should use the NarrowPhaseQuery interface.
        /// Generated from class `JPH::BroadPhaseQuery`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::NonCopyable`
        /// This is the non-const half of the class.
        public class BroadPhaseQuery : Const_BroadPhaseQuery
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.NonCopyable(BroadPhaseQuery self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseQuery_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseQuery_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_BroadPhaseQuery_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_BroadPhaseQuery_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            internal unsafe BroadPhaseQuery(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}
        }

        /// This is used for optional parameters of class `BroadPhaseQuery` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_BroadPhaseQuery`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `BroadPhaseQuery`/`Const_BroadPhaseQuery` directly.
        public class _InOptMut_BroadPhaseQuery
        {
            public BroadPhaseQuery? Opt;

            public _InOptMut_BroadPhaseQuery() {}
            public _InOptMut_BroadPhaseQuery(BroadPhaseQuery value) {Opt = value;}
            public static implicit operator _InOptMut_BroadPhaseQuery(BroadPhaseQuery value) {return new(value);}
        }

        /// This is used for optional parameters of class `BroadPhaseQuery` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_BroadPhaseQuery`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `BroadPhaseQuery`/`Const_BroadPhaseQuery` to pass it to the function.
        public class _InOptConst_BroadPhaseQuery
        {
            public Const_BroadPhaseQuery? Opt;

            public _InOptConst_BroadPhaseQuery() {}
            public _InOptConst_BroadPhaseQuery(Const_BroadPhaseQuery value) {Opt = value;}
            public static implicit operator _InOptConst_BroadPhaseQuery(Const_BroadPhaseQuery value) {return new(value);}
        }
    }
}
