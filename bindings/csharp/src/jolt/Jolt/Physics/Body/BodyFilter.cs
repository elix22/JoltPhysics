// machine generated, do not edit
public static partial class JPH
{
    /// Class function to filter out bodies, returns true if test should collide with body
    /// Generated from class `JPH::BodyFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::IgnoreMultipleBodiesFilter`
    ///     `JPH::IgnoreSingleBodyFilter`
    /// This is the const half of the class.
    public class Const_BodyFilter : JPH.Object<Const_BodyFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyFilter_Destroy(_Underlying *_this);
            __JPH_BodyFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BodyFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_BodyFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_BodyFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_BodyFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BodyFilter(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_BodyFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_BodyFilter ret = new(__JPH_BodyFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BodyFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_BodyFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyFilter._Underlying *__JPH_BodyFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_BodyFilter_DefaultConstruct();
        }

        /// Filter function. Returns true if we should collide with inBodyID
        /// Generated from method `JPH::BodyFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_BodyFilter_ShouldCollide(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyFilter_ShouldCollide(_UnderlyingPtr, __ptr_inBodyID) != 0;
            }
        }

        /// Filter function. Returns true if we should collide with inBody (this is called after the body is locked and makes it possible to filter based on body members)
        /// Generated from method `JPH::BodyFilter::ShouldCollideLocked`.
        public unsafe bool ShouldCollideLocked(JPH.Const_Body inBody)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyFilter_ShouldCollideLocked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyFilter_ShouldCollideLocked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_BodyFilter_ShouldCollideLocked(_Underlying *_this, JPH.Const_Body._Underlying *inBody);
            return __JPH_BodyFilter_ShouldCollideLocked(_UnderlyingPtr, inBody._UnderlyingPtr) != 0;
        }
    }

    /// Class function to filter out bodies, returns true if test should collide with body
    /// Generated from class `JPH::BodyFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::IgnoreMultipleBodiesFilter`
    ///     `JPH::IgnoreSingleBodyFilter`
    /// This is the non-const half of the class.
    public class BodyFilter : Const_BodyFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(BodyFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_BodyFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_BodyFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(BodyFilter self)
            => (JPH.Const_NonCopyable)(JPH.Const_BodyFilter)self;

        // Downcasts:
        public static unsafe explicit operator BodyFilter(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_BodyFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            BodyFilter ret = new(__JPH_BodyFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BodyFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe BodyFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyFilter._Underlying *__JPH_BodyFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_BodyFilter_DefaultConstruct();
        }
    }

    /// This is used as a function parameter when the underlying function receives `BodyFilter` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BodyFilter
    {
        #pragma warning disable CS0649
        internal readonly Const_BodyFilter? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_BodyFilter() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `BodyFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BodyFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BodyFilter`/`Const_BodyFilter` directly.
    public class _InOptMut_BodyFilter
    {
        public BodyFilter? Opt;

        public _InOptMut_BodyFilter() {}
        public _InOptMut_BodyFilter(BodyFilter value) {Opt = value;}
        public static implicit operator _InOptMut_BodyFilter(BodyFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `BodyFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BodyFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BodyFilter`/`Const_BodyFilter` to pass it to the function.
    public class _InOptConst_BodyFilter
    {
        public Const_BodyFilter? Opt;

        public _InOptConst_BodyFilter() {}
        public _InOptConst_BodyFilter(Const_BodyFilter value) {Opt = value;}
        public static implicit operator _InOptConst_BodyFilter(Const_BodyFilter value) {return new(value);}
    }

    /// A simple body filter implementation that ignores a single, specified body
    /// Generated from class `JPH::IgnoreSingleBodyFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BodyFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_IgnoreSingleBodyFilter : JPH.Object<Const_IgnoreSingleBodyFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_IgnoreSingleBodyFilter_Destroy(_Underlying *_this);
            __JPH_IgnoreSingleBodyFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_IgnoreSingleBodyFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_IgnoreSingleBodyFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_BodyFilter(Const_IgnoreSingleBodyFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BodyFilter._Underlying *__JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_BodyFilter(_Underlying *_this);
            JPH.Const_BodyFilter ret = new(__JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_BodyFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_IgnoreSingleBodyFilter(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_IgnoreSingleBodyFilter ret = new(__JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_IgnoreSingleBodyFilter(JPH.Const_BodyFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_BodyFilter(JPH.Const_BodyFilter._Underlying *_this);
            Const_IgnoreSingleBodyFilter ret = new(__JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_BodyFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_IgnoreSingleBodyFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor, pass the body you want to ignore
        /// Generated from constructor `JPH::IgnoreSingleBodyFilter::IgnoreSingleBodyFilter`.
        public unsafe Const_IgnoreSingleBodyFilter(in JPH.BodyID inBodyID) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.IgnoreSingleBodyFilter._Underlying *__JPH_IgnoreSingleBodyFilter_Construct(JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                _UnderlyingPtr = __JPH_IgnoreSingleBodyFilter_Construct(__ptr_inBodyID);
            }
        }

        /// Filter function. Returns true if we should collide with inBodyID
        /// Generated from method `JPH::IgnoreSingleBodyFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_IgnoreSingleBodyFilter_ShouldCollide(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_IgnoreSingleBodyFilter_ShouldCollide(_UnderlyingPtr, __ptr_inBodyID) != 0;
            }
        }

        /// Filter function. Returns true if we should collide with inBody (this is called after the body is locked and makes it possible to filter based on body members)
        /// Generated from method `JPH::IgnoreSingleBodyFilter::ShouldCollideLocked`.
        public unsafe bool ShouldCollideLocked(JPH.Const_Body inBody)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_ShouldCollideLocked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_ShouldCollideLocked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_IgnoreSingleBodyFilter_ShouldCollideLocked(_Underlying *_this, JPH.Const_Body._Underlying *inBody);
            return __JPH_IgnoreSingleBodyFilter_ShouldCollideLocked(_UnderlyingPtr, inBody._UnderlyingPtr) != 0;
        }
    }

    /// A simple body filter implementation that ignores a single, specified body
    /// Generated from class `JPH::IgnoreSingleBodyFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BodyFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class IgnoreSingleBodyFilter : Const_IgnoreSingleBodyFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(IgnoreSingleBodyFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(IgnoreSingleBodyFilter self)
            => (JPH.Const_NonCopyable)(JPH.Const_IgnoreSingleBodyFilter)self;
        public static unsafe implicit operator JPH.BodyFilter(IgnoreSingleBodyFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyFilter._Underlying *__JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_BodyFilter(_Underlying *_this);
            JPH.BodyFilter ret = new(__JPH_IgnoreSingleBodyFilter_UpcastTo_JPH_BodyFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_BodyFilter(IgnoreSingleBodyFilter self)
            => (JPH.Const_BodyFilter)(JPH.Const_IgnoreSingleBodyFilter)self;

        // Downcasts:
        public static unsafe explicit operator IgnoreSingleBodyFilter(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            IgnoreSingleBodyFilter ret = new(__JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator IgnoreSingleBodyFilter(JPH.BodyFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_BodyFilter(JPH.BodyFilter._Underlying *_this);
            IgnoreSingleBodyFilter ret = new(__JPH_IgnoreSingleBodyFilter_StaticDowncastFrom_JPH_BodyFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe IgnoreSingleBodyFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor, pass the body you want to ignore
        /// Generated from constructor `JPH::IgnoreSingleBodyFilter::IgnoreSingleBodyFilter`.
        public unsafe IgnoreSingleBodyFilter(in JPH.BodyID inBodyID) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreSingleBodyFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.IgnoreSingleBodyFilter._Underlying *__JPH_IgnoreSingleBodyFilter_Construct(JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                _UnderlyingPtr = __JPH_IgnoreSingleBodyFilter_Construct(__ptr_inBodyID);
            }
        }
    }

    /// This is used for optional parameters of class `IgnoreSingleBodyFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_IgnoreSingleBodyFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `IgnoreSingleBodyFilter`/`Const_IgnoreSingleBodyFilter` directly.
    public class _InOptMut_IgnoreSingleBodyFilter
    {
        public IgnoreSingleBodyFilter? Opt;

        public _InOptMut_IgnoreSingleBodyFilter() {}
        public _InOptMut_IgnoreSingleBodyFilter(IgnoreSingleBodyFilter value) {Opt = value;}
        public static implicit operator _InOptMut_IgnoreSingleBodyFilter(IgnoreSingleBodyFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `IgnoreSingleBodyFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_IgnoreSingleBodyFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `IgnoreSingleBodyFilter`/`Const_IgnoreSingleBodyFilter` to pass it to the function.
    public class _InOptConst_IgnoreSingleBodyFilter
    {
        public Const_IgnoreSingleBodyFilter? Opt;

        public _InOptConst_IgnoreSingleBodyFilter() {}
        public _InOptConst_IgnoreSingleBodyFilter(Const_IgnoreSingleBodyFilter value) {Opt = value;}
        public static implicit operator _InOptConst_IgnoreSingleBodyFilter(Const_IgnoreSingleBodyFilter value) {return new(value);}
    }

    /// A simple body filter implementation that ignores multiple, specified bodies
    /// Generated from class `JPH::IgnoreMultipleBodiesFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BodyFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_IgnoreMultipleBodiesFilter : JPH.Object<Const_IgnoreMultipleBodiesFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_IgnoreMultipleBodiesFilter_Destroy(_Underlying *_this);
            __JPH_IgnoreMultipleBodiesFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_IgnoreMultipleBodiesFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_IgnoreMultipleBodiesFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_BodyFilter(Const_IgnoreMultipleBodiesFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BodyFilter._Underlying *__JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_BodyFilter(_Underlying *_this);
            JPH.Const_BodyFilter ret = new(__JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_BodyFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_IgnoreMultipleBodiesFilter(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_IgnoreMultipleBodiesFilter ret = new(__JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_IgnoreMultipleBodiesFilter(JPH.Const_BodyFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_BodyFilter(JPH.Const_BodyFilter._Underlying *_this);
            Const_IgnoreMultipleBodiesFilter ret = new(__JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_BodyFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_IgnoreMultipleBodiesFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_IgnoreMultipleBodiesFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.IgnoreMultipleBodiesFilter._Underlying *__JPH_IgnoreMultipleBodiesFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_IgnoreMultipleBodiesFilter_DefaultConstruct();
        }

        /// Filter function. Returns true if we should collide with inBodyID
        /// Generated from method `JPH::IgnoreMultipleBodiesFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_IgnoreMultipleBodiesFilter_ShouldCollide(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_IgnoreMultipleBodiesFilter_ShouldCollide(_UnderlyingPtr, __ptr_inBodyID) != 0;
            }
        }

        /// Filter function. Returns true if we should collide with inBody (this is called after the body is locked and makes it possible to filter based on body members)
        /// Generated from method `JPH::IgnoreMultipleBodiesFilter::ShouldCollideLocked`.
        public unsafe bool ShouldCollideLocked(JPH.Const_Body inBody)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_ShouldCollideLocked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_ShouldCollideLocked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_IgnoreMultipleBodiesFilter_ShouldCollideLocked(_Underlying *_this, JPH.Const_Body._Underlying *inBody);
            return __JPH_IgnoreMultipleBodiesFilter_ShouldCollideLocked(_UnderlyingPtr, inBody._UnderlyingPtr) != 0;
        }
    }

    /// A simple body filter implementation that ignores multiple, specified bodies
    /// Generated from class `JPH::IgnoreMultipleBodiesFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BodyFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class IgnoreMultipleBodiesFilter : Const_IgnoreMultipleBodiesFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(IgnoreMultipleBodiesFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(IgnoreMultipleBodiesFilter self)
            => (JPH.Const_NonCopyable)(JPH.Const_IgnoreMultipleBodiesFilter)self;
        public static unsafe implicit operator JPH.BodyFilter(IgnoreMultipleBodiesFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyFilter._Underlying *__JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_BodyFilter(_Underlying *_this);
            JPH.BodyFilter ret = new(__JPH_IgnoreMultipleBodiesFilter_UpcastTo_JPH_BodyFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_BodyFilter(IgnoreMultipleBodiesFilter self)
            => (JPH.Const_BodyFilter)(JPH.Const_IgnoreMultipleBodiesFilter)self;

        // Downcasts:
        public static unsafe explicit operator IgnoreMultipleBodiesFilter(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            IgnoreMultipleBodiesFilter ret = new(__JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator IgnoreMultipleBodiesFilter(JPH.BodyFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_BodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_BodyFilter(JPH.BodyFilter._Underlying *_this);
            IgnoreMultipleBodiesFilter ret = new(__JPH_IgnoreMultipleBodiesFilter_StaticDowncastFrom_JPH_BodyFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe IgnoreMultipleBodiesFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe IgnoreMultipleBodiesFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.IgnoreMultipleBodiesFilter._Underlying *__JPH_IgnoreMultipleBodiesFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_IgnoreMultipleBodiesFilter_DefaultConstruct();
        }

        /// Remove all bodies from the filter
        /// Generated from method `JPH::IgnoreMultipleBodiesFilter::Clear`.
        public unsafe void Clear()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_Clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_Clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_IgnoreMultipleBodiesFilter_Clear(_Underlying *_this);
            __JPH_IgnoreMultipleBodiesFilter_Clear(_UnderlyingPtr);
        }

        /// Reserve space for inSize body ID's
        /// Generated from method `JPH::IgnoreMultipleBodiesFilter::Reserve`.
        public unsafe void Reserve(uint inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_Reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_Reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_IgnoreMultipleBodiesFilter_Reserve(_Underlying *_this, uint inSize);
            __JPH_IgnoreMultipleBodiesFilter_Reserve(_UnderlyingPtr, inSize);
        }

        /// Add a body to be ignored
        /// Generated from method `JPH::IgnoreMultipleBodiesFilter::IgnoreBody`.
        public unsafe void IgnoreBody(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_IgnoreBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_IgnoreMultipleBodiesFilter_IgnoreBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_IgnoreMultipleBodiesFilter_IgnoreBody(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_IgnoreMultipleBodiesFilter_IgnoreBody(_UnderlyingPtr, __ptr_inBodyID);
            }
        }
    }

    /// This is used as a function parameter when the underlying function receives `IgnoreMultipleBodiesFilter` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_IgnoreMultipleBodiesFilter
    {
        #pragma warning disable CS0649
        internal readonly Const_IgnoreMultipleBodiesFilter? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_IgnoreMultipleBodiesFilter() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `IgnoreMultipleBodiesFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_IgnoreMultipleBodiesFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `IgnoreMultipleBodiesFilter`/`Const_IgnoreMultipleBodiesFilter` directly.
    public class _InOptMut_IgnoreMultipleBodiesFilter
    {
        public IgnoreMultipleBodiesFilter? Opt;

        public _InOptMut_IgnoreMultipleBodiesFilter() {}
        public _InOptMut_IgnoreMultipleBodiesFilter(IgnoreMultipleBodiesFilter value) {Opt = value;}
        public static implicit operator _InOptMut_IgnoreMultipleBodiesFilter(IgnoreMultipleBodiesFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `IgnoreMultipleBodiesFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_IgnoreMultipleBodiesFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `IgnoreMultipleBodiesFilter`/`Const_IgnoreMultipleBodiesFilter` to pass it to the function.
    public class _InOptConst_IgnoreMultipleBodiesFilter
    {
        public Const_IgnoreMultipleBodiesFilter? Opt;

        public _InOptConst_IgnoreMultipleBodiesFilter() {}
        public _InOptConst_IgnoreMultipleBodiesFilter(Const_IgnoreMultipleBodiesFilter value) {Opt = value;}
        public static implicit operator _InOptConst_IgnoreMultipleBodiesFilter(Const_IgnoreMultipleBodiesFilter value) {return new(value);}
    }
}
