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

        // Downcasts:
        public static unsafe explicit operator Const_NarrowPhaseQuery(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_NarrowPhaseQuery_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_NarrowPhaseQuery_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_NarrowPhaseQuery_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_NarrowPhaseQuery ret = new(__JPH_NarrowPhaseQuery_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
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

        /// Cast a ray and find the closest hit. Returns true if it finds a hit. Hits further than ioHit.mFraction will not be considered and in this case ioHit will remain unmodified (and the function will return false).
        /// Convex objects will be treated as solid (meaning if the ray starts inside, you'll get a hit fraction of 0) and back face hits against triangles are returned.
        /// If you want the surface normal of the hit use Body::GetWorldSpaceSurfaceNormal(ioHit.mSubShapeID2, inRay.GetPointOnRay(ioHit.mFraction)) on body with ID ioHit.mBodyID.
        /// Generated from method `JPH::NarrowPhaseQuery::CastRay`.
        /// Parameter `inBroadPhaseLayerFilter` defaults to `{}`.
        /// Parameter `inObjectLayerFilter` defaults to `{}`.
        /// Parameter `inBodyFilter` defaults to `{}`.
        public unsafe bool CastRay(JPH.Const_RRayCast inRay, JPH.RayCastResult ioHit, JPH.Const_BroadPhaseLayerFilter? inBroadPhaseLayerFilter = null, JPH.Const_ObjectLayerFilter? inObjectLayerFilter = null, JPH.Const_BodyFilter? inBodyFilter = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_NarrowPhaseQuery_CastRay_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_NarrowPhaseQuery_CastRay_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_NarrowPhaseQuery_CastRay_5(_Underlying *_this, JPH.Const_RRayCast._Underlying *inRay, JPH.RayCastResult._Underlying *ioHit, JPH.Const_BroadPhaseLayerFilter._Underlying *inBroadPhaseLayerFilter, JPH.Const_ObjectLayerFilter._Underlying *inObjectLayerFilter, JPH.Const_BodyFilter._Underlying *inBodyFilter);
            return __JPH_NarrowPhaseQuery_CastRay_5(_UnderlyingPtr, inRay._UnderlyingPtr, ioHit._UnderlyingPtr, inBroadPhaseLayerFilter is not null ? inBroadPhaseLayerFilter._UnderlyingPtr : null, inObjectLayerFilter is not null ? inObjectLayerFilter._UnderlyingPtr : null, inBodyFilter is not null ? inBodyFilter._UnderlyingPtr : null) != 0;
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

        // Downcasts:
        public static unsafe explicit operator NarrowPhaseQuery(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_NarrowPhaseQuery_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_NarrowPhaseQuery_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_NarrowPhaseQuery_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            NarrowPhaseQuery ret = new(__JPH_NarrowPhaseQuery_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
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
