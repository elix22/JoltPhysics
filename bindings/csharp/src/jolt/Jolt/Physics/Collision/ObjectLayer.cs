// machine generated, do not edit
public static partial class JPH
{
    /// Filter class for object layers
    /// Generated from class `JPH::ObjectLayerFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DefaultObjectLayerFilter`
    ///     `JPH::SpecifiedObjectLayerFilter`
    /// This is the const half of the class.
    public class Const_ObjectLayerFilter : JPH.Object<Const_ObjectLayerFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ObjectLayerFilter_Destroy(_Underlying *_this);
            __JPH_ObjectLayerFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ObjectLayerFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_ObjectLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_ObjectLayerFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_ObjectLayerFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_ObjectLayerFilter(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_ObjectLayerFilter ret = new(__JPH_ObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_ObjectLayerFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_ObjectLayerFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectLayerFilter._Underlying *__JPH_ObjectLayerFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_ObjectLayerFilter_DefaultConstruct();
        }

        /// Function to filter out object layers when doing collision query test (return true to allow testing against objects with this layer)
        /// Generated from method `JPH::ObjectLayerFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(ushort inLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_ObjectLayerFilter_ShouldCollide(_Underlying *_this, ushort inLayer);
            return __JPH_ObjectLayerFilter_ShouldCollide(_UnderlyingPtr, inLayer) != 0;
        }
    }

    /// Filter class for object layers
    /// Generated from class `JPH::ObjectLayerFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DefaultObjectLayerFilter`
    ///     `JPH::SpecifiedObjectLayerFilter`
    /// This is the non-const half of the class.
    public class ObjectLayerFilter : Const_ObjectLayerFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(ObjectLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_ObjectLayerFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_ObjectLayerFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(ObjectLayerFilter self)
            => (JPH.Const_NonCopyable)(JPH.Const_ObjectLayerFilter)self;

        // Downcasts:
        public static unsafe explicit operator ObjectLayerFilter(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            ObjectLayerFilter ret = new(__JPH_ObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe ObjectLayerFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe ObjectLayerFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectLayerFilter._Underlying *__JPH_ObjectLayerFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_ObjectLayerFilter_DefaultConstruct();
        }
    }

    /// This is used as a function parameter when the underlying function receives `ObjectLayerFilter` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_ObjectLayerFilter
    {
        #pragma warning disable CS0649
        internal readonly Const_ObjectLayerFilter? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_ObjectLayerFilter() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `ObjectLayerFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ObjectLayerFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ObjectLayerFilter`/`Const_ObjectLayerFilter` directly.
    public class _InOptMut_ObjectLayerFilter
    {
        public ObjectLayerFilter? Opt;

        public _InOptMut_ObjectLayerFilter() {}
        public _InOptMut_ObjectLayerFilter(ObjectLayerFilter value) {Opt = value;}
        public static implicit operator _InOptMut_ObjectLayerFilter(ObjectLayerFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `ObjectLayerFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ObjectLayerFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ObjectLayerFilter`/`Const_ObjectLayerFilter` to pass it to the function.
    public class _InOptConst_ObjectLayerFilter
    {
        public Const_ObjectLayerFilter? Opt;

        public _InOptConst_ObjectLayerFilter() {}
        public _InOptConst_ObjectLayerFilter(Const_ObjectLayerFilter value) {Opt = value;}
        public static implicit operator _InOptConst_ObjectLayerFilter(Const_ObjectLayerFilter value) {return new(value);}
    }

    /// Filter class to test if two objects can collide based on their object layer. Used while finding collision pairs.
    /// Generated from class `JPH::ObjectLayerPairFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectLayerPairFilterMask`
    ///     `JPH::ObjectLayerPairFilterTable`
    /// This is the const half of the class.
    public class Const_ObjectLayerPairFilter : JPH.Object<Const_ObjectLayerPairFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ObjectLayerPairFilter_Destroy(_Underlying *_this);
            __JPH_ObjectLayerPairFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ObjectLayerPairFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_ObjectLayerPairFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_ObjectLayerPairFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_ObjectLayerPairFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_ObjectLayerPairFilter(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectLayerPairFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_ObjectLayerPairFilter ret = new(__JPH_ObjectLayerPairFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_ObjectLayerPairFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_ObjectLayerPairFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectLayerPairFilter._Underlying *__JPH_ObjectLayerPairFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_ObjectLayerPairFilter_DefaultConstruct();
        }

        /// Returns true if two layers can collide
        /// Generated from method `JPH::ObjectLayerPairFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(ushort inLayer1, ushort inLayer2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_ObjectLayerPairFilter_ShouldCollide(_Underlying *_this, ushort inLayer1, ushort inLayer2);
            return __JPH_ObjectLayerPairFilter_ShouldCollide(_UnderlyingPtr, inLayer1, inLayer2) != 0;
        }
    }

    /// Filter class to test if two objects can collide based on their object layer. Used while finding collision pairs.
    /// Generated from class `JPH::ObjectLayerPairFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectLayerPairFilterMask`
    ///     `JPH::ObjectLayerPairFilterTable`
    /// This is the non-const half of the class.
    public class ObjectLayerPairFilter : Const_ObjectLayerPairFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(ObjectLayerPairFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_ObjectLayerPairFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_ObjectLayerPairFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(ObjectLayerPairFilter self)
            => (JPH.Const_NonCopyable)(JPH.Const_ObjectLayerPairFilter)self;

        // Downcasts:
        public static unsafe explicit operator ObjectLayerPairFilter(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectLayerPairFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            ObjectLayerPairFilter ret = new(__JPH_ObjectLayerPairFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe ObjectLayerPairFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe ObjectLayerPairFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectLayerPairFilter._Underlying *__JPH_ObjectLayerPairFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_ObjectLayerPairFilter_DefaultConstruct();
        }
    }

    /// This is used as a function parameter when the underlying function receives `ObjectLayerPairFilter` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_ObjectLayerPairFilter
    {
        #pragma warning disable CS0649
        internal readonly Const_ObjectLayerPairFilter? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_ObjectLayerPairFilter() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `ObjectLayerPairFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ObjectLayerPairFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ObjectLayerPairFilter`/`Const_ObjectLayerPairFilter` directly.
    public class _InOptMut_ObjectLayerPairFilter
    {
        public ObjectLayerPairFilter? Opt;

        public _InOptMut_ObjectLayerPairFilter() {}
        public _InOptMut_ObjectLayerPairFilter(ObjectLayerPairFilter value) {Opt = value;}
        public static implicit operator _InOptMut_ObjectLayerPairFilter(ObjectLayerPairFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `ObjectLayerPairFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ObjectLayerPairFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ObjectLayerPairFilter`/`Const_ObjectLayerPairFilter` to pass it to the function.
    public class _InOptConst_ObjectLayerPairFilter
    {
        public Const_ObjectLayerPairFilter? Opt;

        public _InOptConst_ObjectLayerPairFilter() {}
        public _InOptConst_ObjectLayerPairFilter(Const_ObjectLayerPairFilter value) {Opt = value;}
        public static implicit operator _InOptConst_ObjectLayerPairFilter(Const_ObjectLayerPairFilter value) {return new(value);}
    }

    /// Default filter class that uses the pair filter in combination with a specified layer to filter layers
    /// Generated from class `JPH::DefaultObjectLayerFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectLayerFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_DefaultObjectLayerFilter : JPH.Object<Const_DefaultObjectLayerFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DefaultObjectLayerFilter_Destroy(_Underlying *_this);
            __JPH_DefaultObjectLayerFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_DefaultObjectLayerFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_DefaultObjectLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_DefaultObjectLayerFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_DefaultObjectLayerFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ObjectLayerFilter(Const_DefaultObjectLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ObjectLayerFilter._Underlying *__JPH_DefaultObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter(_Underlying *_this);
            JPH.Const_ObjectLayerFilter ret = new(__JPH_DefaultObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_DefaultObjectLayerFilter(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_DefaultObjectLayerFilter ret = new(__JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_DefaultObjectLayerFilter(JPH.Const_ObjectLayerFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter(JPH.Const_ObjectLayerFilter._Underlying *_this);
            Const_DefaultObjectLayerFilter ret = new(__JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_DefaultObjectLayerFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Copy constructor
        /// Generated from constructor `JPH::DefaultObjectLayerFilter::DefaultObjectLayerFilter`.
        public unsafe Const_DefaultObjectLayerFilter(JPH._ByValue_DefaultObjectLayerFilter inRHS) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DefaultObjectLayerFilter._Underlying *__JPH_DefaultObjectLayerFilter_ConstructFromAnother(JPH._PassBy inRHS_pass_by, JPH.DefaultObjectLayerFilter._Underlying *inRHS);
            _UnderlyingPtr = __JPH_DefaultObjectLayerFilter_ConstructFromAnother(inRHS.PassByMode, inRHS.Value is not null ? inRHS.Value._UnderlyingPtr : null);
            if (inRHS.Value is not null) _KeepAlive(inRHS.Value);
        }

        /// Copy constructor
        /// Generated from constructor `JPH::DefaultObjectLayerFilter::DefaultObjectLayerFilter`.
        public Const_DefaultObjectLayerFilter(Const_DefaultObjectLayerFilter inRHS) : this(new _ByValue_DefaultObjectLayerFilter(inRHS)) {}

        /// Copy constructor
        /// Generated from constructor `JPH::DefaultObjectLayerFilter::DefaultObjectLayerFilter`.
        public Const_DefaultObjectLayerFilter(DefaultObjectLayerFilter inRHS) : this((Const_DefaultObjectLayerFilter)inRHS) {}

        /// Constructor
        /// Generated from constructor `JPH::DefaultObjectLayerFilter::DefaultObjectLayerFilter`.
        public unsafe Const_DefaultObjectLayerFilter(JPH.Const_ObjectLayerPairFilter inObjectLayerPairFilter, ushort inLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DefaultObjectLayerFilter._Underlying *__JPH_DefaultObjectLayerFilter_Construct(JPH.Const_ObjectLayerPairFilter._Underlying *inObjectLayerPairFilter, ushort inLayer);
            _UnderlyingPtr = __JPH_DefaultObjectLayerFilter_Construct(inObjectLayerPairFilter._UnderlyingPtr, inLayer);
        }

        // See ObjectLayerFilter::ShouldCollide
        /// Generated from method `JPH::DefaultObjectLayerFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(ushort inLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_DefaultObjectLayerFilter_ShouldCollide(_Underlying *_this, ushort inLayer);
            return __JPH_DefaultObjectLayerFilter_ShouldCollide(_UnderlyingPtr, inLayer) != 0;
        }
    }

    /// Default filter class that uses the pair filter in combination with a specified layer to filter layers
    /// Generated from class `JPH::DefaultObjectLayerFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectLayerFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class DefaultObjectLayerFilter : Const_DefaultObjectLayerFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(DefaultObjectLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_DefaultObjectLayerFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_DefaultObjectLayerFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(DefaultObjectLayerFilter self)
            => (JPH.Const_NonCopyable)(JPH.Const_DefaultObjectLayerFilter)self;
        public static unsafe implicit operator JPH.ObjectLayerFilter(DefaultObjectLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectLayerFilter._Underlying *__JPH_DefaultObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter(_Underlying *_this);
            JPH.ObjectLayerFilter ret = new(__JPH_DefaultObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ObjectLayerFilter(DefaultObjectLayerFilter self)
            => (JPH.Const_ObjectLayerFilter)(JPH.Const_DefaultObjectLayerFilter)self;

        // Downcasts:
        public static unsafe explicit operator DefaultObjectLayerFilter(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            DefaultObjectLayerFilter ret = new(__JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator DefaultObjectLayerFilter(JPH.ObjectLayerFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter(JPH.ObjectLayerFilter._Underlying *_this);
            DefaultObjectLayerFilter ret = new(__JPH_DefaultObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe DefaultObjectLayerFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Copy constructor
        /// Generated from constructor `JPH::DefaultObjectLayerFilter::DefaultObjectLayerFilter`.
        public unsafe DefaultObjectLayerFilter(JPH._ByValue_DefaultObjectLayerFilter inRHS) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DefaultObjectLayerFilter._Underlying *__JPH_DefaultObjectLayerFilter_ConstructFromAnother(JPH._PassBy inRHS_pass_by, JPH.DefaultObjectLayerFilter._Underlying *inRHS);
            _UnderlyingPtr = __JPH_DefaultObjectLayerFilter_ConstructFromAnother(inRHS.PassByMode, inRHS.Value is not null ? inRHS.Value._UnderlyingPtr : null);
            if (inRHS.Value is not null) _KeepAlive(inRHS.Value);
        }

        /// Copy constructor
        /// Generated from constructor `JPH::DefaultObjectLayerFilter::DefaultObjectLayerFilter`.
        public DefaultObjectLayerFilter(Const_DefaultObjectLayerFilter inRHS) : this(new _ByValue_DefaultObjectLayerFilter(inRHS)) {}

        /// Copy constructor
        /// Generated from constructor `JPH::DefaultObjectLayerFilter::DefaultObjectLayerFilter`.
        public DefaultObjectLayerFilter(DefaultObjectLayerFilter inRHS) : this((Const_DefaultObjectLayerFilter)inRHS) {}

        /// Constructor
        /// Generated from constructor `JPH::DefaultObjectLayerFilter::DefaultObjectLayerFilter`.
        public unsafe DefaultObjectLayerFilter(JPH.Const_ObjectLayerPairFilter inObjectLayerPairFilter, ushort inLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DefaultObjectLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DefaultObjectLayerFilter._Underlying *__JPH_DefaultObjectLayerFilter_Construct(JPH.Const_ObjectLayerPairFilter._Underlying *inObjectLayerPairFilter, ushort inLayer);
            _UnderlyingPtr = __JPH_DefaultObjectLayerFilter_Construct(inObjectLayerPairFilter._UnderlyingPtr, inLayer);
        }
    }

    /// This is used as a function parameter when the underlying function receives `DefaultObjectLayerFilter` by value.
    /// Usage:
    /// * Pass an instance of `DefaultObjectLayerFilter`/`Const_DefaultObjectLayerFilter` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_DefaultObjectLayerFilter
    {
        #pragma warning disable CS0649
        internal readonly Const_DefaultObjectLayerFilter? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_DefaultObjectLayerFilter(Const_DefaultObjectLayerFilter new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_DefaultObjectLayerFilter(Const_DefaultObjectLayerFilter arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `DefaultObjectLayerFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_DefaultObjectLayerFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `DefaultObjectLayerFilter`/`Const_DefaultObjectLayerFilter` directly.
    public class _InOptMut_DefaultObjectLayerFilter
    {
        public DefaultObjectLayerFilter? Opt;

        public _InOptMut_DefaultObjectLayerFilter() {}
        public _InOptMut_DefaultObjectLayerFilter(DefaultObjectLayerFilter value) {Opt = value;}
        public static implicit operator _InOptMut_DefaultObjectLayerFilter(DefaultObjectLayerFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `DefaultObjectLayerFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_DefaultObjectLayerFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `DefaultObjectLayerFilter`/`Const_DefaultObjectLayerFilter` to pass it to the function.
    public class _InOptConst_DefaultObjectLayerFilter
    {
        public Const_DefaultObjectLayerFilter? Opt;

        public _InOptConst_DefaultObjectLayerFilter() {}
        public _InOptConst_DefaultObjectLayerFilter(Const_DefaultObjectLayerFilter value) {Opt = value;}
        public static implicit operator _InOptConst_DefaultObjectLayerFilter(Const_DefaultObjectLayerFilter value) {return new(value);}
    }

    /// Allows objects from a specific layer only
    /// Generated from class `JPH::SpecifiedObjectLayerFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectLayerFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_SpecifiedObjectLayerFilter : JPH.Object<Const_SpecifiedObjectLayerFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SpecifiedObjectLayerFilter_Destroy(_Underlying *_this);
            __JPH_SpecifiedObjectLayerFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SpecifiedObjectLayerFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_SpecifiedObjectLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ObjectLayerFilter(Const_SpecifiedObjectLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ObjectLayerFilter._Underlying *__JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter(_Underlying *_this);
            JPH.Const_ObjectLayerFilter ret = new(__JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_SpecifiedObjectLayerFilter(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_SpecifiedObjectLayerFilter ret = new(__JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_SpecifiedObjectLayerFilter(JPH.Const_ObjectLayerFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter(JPH.Const_ObjectLayerFilter._Underlying *_this);
            Const_SpecifiedObjectLayerFilter ret = new(__JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_SpecifiedObjectLayerFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// Generated from constructor `JPH::SpecifiedObjectLayerFilter::SpecifiedObjectLayerFilter`.
        public unsafe Const_SpecifiedObjectLayerFilter(ushort inLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SpecifiedObjectLayerFilter._Underlying *__JPH_SpecifiedObjectLayerFilter_Construct(ushort inLayer);
            _UnderlyingPtr = __JPH_SpecifiedObjectLayerFilter_Construct(inLayer);
        }

        // See ObjectLayerFilter::ShouldCollide
        /// Generated from method `JPH::SpecifiedObjectLayerFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(ushort inLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SpecifiedObjectLayerFilter_ShouldCollide(_Underlying *_this, ushort inLayer);
            return __JPH_SpecifiedObjectLayerFilter_ShouldCollide(_UnderlyingPtr, inLayer) != 0;
        }
    }

    /// Allows objects from a specific layer only
    /// Generated from class `JPH::SpecifiedObjectLayerFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectLayerFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class SpecifiedObjectLayerFilter : Const_SpecifiedObjectLayerFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(SpecifiedObjectLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(SpecifiedObjectLayerFilter self)
            => (JPH.Const_NonCopyable)(JPH.Const_SpecifiedObjectLayerFilter)self;
        public static unsafe implicit operator JPH.ObjectLayerFilter(SpecifiedObjectLayerFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectLayerFilter._Underlying *__JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter(_Underlying *_this);
            JPH.ObjectLayerFilter ret = new(__JPH_SpecifiedObjectLayerFilter_UpcastTo_JPH_ObjectLayerFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ObjectLayerFilter(SpecifiedObjectLayerFilter self)
            => (JPH.Const_ObjectLayerFilter)(JPH.Const_SpecifiedObjectLayerFilter)self;

        // Downcasts:
        public static unsafe explicit operator SpecifiedObjectLayerFilter(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            SpecifiedObjectLayerFilter ret = new(__JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator SpecifiedObjectLayerFilter(JPH.ObjectLayerFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter(JPH.ObjectLayerFilter._Underlying *_this);
            SpecifiedObjectLayerFilter ret = new(__JPH_SpecifiedObjectLayerFilter_StaticDowncastFrom_JPH_ObjectLayerFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe SpecifiedObjectLayerFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// Generated from constructor `JPH::SpecifiedObjectLayerFilter::SpecifiedObjectLayerFilter`.
        public unsafe SpecifiedObjectLayerFilter(ushort inLayer) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpecifiedObjectLayerFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SpecifiedObjectLayerFilter._Underlying *__JPH_SpecifiedObjectLayerFilter_Construct(ushort inLayer);
            _UnderlyingPtr = __JPH_SpecifiedObjectLayerFilter_Construct(inLayer);
        }
    }

    /// This is used for optional parameters of class `SpecifiedObjectLayerFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SpecifiedObjectLayerFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SpecifiedObjectLayerFilter`/`Const_SpecifiedObjectLayerFilter` directly.
    public class _InOptMut_SpecifiedObjectLayerFilter
    {
        public SpecifiedObjectLayerFilter? Opt;

        public _InOptMut_SpecifiedObjectLayerFilter() {}
        public _InOptMut_SpecifiedObjectLayerFilter(SpecifiedObjectLayerFilter value) {Opt = value;}
        public static implicit operator _InOptMut_SpecifiedObjectLayerFilter(SpecifiedObjectLayerFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `SpecifiedObjectLayerFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SpecifiedObjectLayerFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SpecifiedObjectLayerFilter`/`Const_SpecifiedObjectLayerFilter` to pass it to the function.
    public class _InOptConst_SpecifiedObjectLayerFilter
    {
        public Const_SpecifiedObjectLayerFilter? Opt;

        public _InOptConst_SpecifiedObjectLayerFilter() {}
        public _InOptConst_SpecifiedObjectLayerFilter(Const_SpecifiedObjectLayerFilter value) {Opt = value;}
        public static implicit operator _InOptConst_SpecifiedObjectLayerFilter(Const_SpecifiedObjectLayerFilter value) {return new(value);}
    }
}
