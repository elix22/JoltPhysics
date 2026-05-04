// machine generated, do not edit
public static partial class JPH
{
    /// Filter class
    /// Generated from class `JPH::ShapeFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ReversedShapeFilter`
    /// This is the const half of the class.
    public class Const_ShapeFilter : JPH.Object<Const_ShapeFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ShapeFilter_Destroy(_Underlying *_this);
            __JPH_ShapeFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ShapeFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_ShapeFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_ShapeFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_ShapeFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_ShapeFilter(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ShapeFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_ShapeFilter ret = new(__JPH_ShapeFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// Used during NarrowPhase queries and TransformedShape queries. Set to the body ID of inShape2 before calling ShouldCollide.
        /// Provides context to the filter to indicate which body is colliding.
        public unsafe ref readonly JPH.BodyID mBodyID2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeFilter_Get_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeFilter_Get_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_ShapeFilter_Get_mBodyID2(_Underlying *_this);
                return ref *__JPH_ShapeFilter_Get_mBodyID2(_UnderlyingPtr);
            }
        }

        internal unsafe Const_ShapeFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_ShapeFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeFilter._Underlying *__JPH_ShapeFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_ShapeFilter_DefaultConstruct();
        }

        /// Filter function to determine if we should collide with a shape. Returns true if the filter passes.
        /// This overload is called when the query doesn't have a source shape (e.g. ray cast / collide point)
        /// @param inShape2 Shape we're colliding against
        /// @param inSubShapeIDOfShape2 The sub shape ID that will lead from the root shape to inShape2 (i.e. the shape of mBodyID2)
        /// Generated from method `JPH::ShapeFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(JPH.Const_Shape? inShape2, JPH.Const_SubShapeID inSubShapeIDOfShape2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeFilter_ShouldCollide_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeFilter_ShouldCollide_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_ShapeFilter_ShouldCollide_2(_Underlying *_this, JPH.Const_Shape._Underlying *inShape2, JPH.Const_SubShapeID._Underlying *inSubShapeIDOfShape2);
            return __JPH_ShapeFilter_ShouldCollide_2(_UnderlyingPtr, inShape2 is not null ? inShape2._UnderlyingPtr : null, inSubShapeIDOfShape2._UnderlyingPtr) != 0;
        }

        /// Filter function to determine if two shapes should collide. Returns true if the filter passes.
        /// This overload is called when querying a shape vs a shape (e.g. collide object / cast object).
        /// It is called at each level of the shape hierarchy, so if you have a compound shape with a box, this function will be called twice.
        /// It will not be called on triangles that are part of another shape, i.e a mesh shape will not trigger a callback per triangle. You can filter out individual triangles in the CollisionCollector::AddHit function by their sub shape ID.
        /// @param inShape1 1st shape that is colliding
        /// @param inSubShapeIDOfShape1 The sub shape ID that will lead from the root shape to inShape1 (i.e. the shape that is used to collide or cast against shape 2)
        /// @param inShape2 2nd shape that is colliding
        /// @param inSubShapeIDOfShape2 The sub shape ID that will lead from the root shape to inShape2 (i.e. the shape of mBodyID2)
        /// Generated from method `JPH::ShapeFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(JPH.Const_Shape? inShape1, JPH.Const_SubShapeID inSubShapeIDOfShape1, JPH.Const_Shape? inShape2, JPH.Const_SubShapeID inSubShapeIDOfShape2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeFilter_ShouldCollide_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeFilter_ShouldCollide_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_ShapeFilter_ShouldCollide_4(_Underlying *_this, JPH.Const_Shape._Underlying *inShape1, JPH.Const_SubShapeID._Underlying *inSubShapeIDOfShape1, JPH.Const_Shape._Underlying *inShape2, JPH.Const_SubShapeID._Underlying *inSubShapeIDOfShape2);
            return __JPH_ShapeFilter_ShouldCollide_4(_UnderlyingPtr, inShape1 is not null ? inShape1._UnderlyingPtr : null, inSubShapeIDOfShape1._UnderlyingPtr, inShape2 is not null ? inShape2._UnderlyingPtr : null, inSubShapeIDOfShape2._UnderlyingPtr) != 0;
        }
    }

    /// Filter class
    /// Generated from class `JPH::ShapeFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ReversedShapeFilter`
    /// This is the non-const half of the class.
    public class ShapeFilter : Const_ShapeFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(ShapeFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_ShapeFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_ShapeFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator ShapeFilter(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ShapeFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            ShapeFilter ret = new(__JPH_ShapeFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// Used during NarrowPhase queries and TransformedShape queries. Set to the body ID of inShape2 before calling ShouldCollide.
        /// Provides context to the filter to indicate which body is colliding.
        public new unsafe ref JPH.BodyID mBodyID2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeFilter_GetMutable_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeFilter_GetMutable_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_ShapeFilter_GetMutable_mBodyID2(_Underlying *_this);
                return ref *__JPH_ShapeFilter_GetMutable_mBodyID2(_UnderlyingPtr);
            }
        }

        internal unsafe ShapeFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe ShapeFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeFilter._Underlying *__JPH_ShapeFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_ShapeFilter_DefaultConstruct();
        }
    }

    /// This is used as a function parameter when the underlying function receives `ShapeFilter` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_ShapeFilter
    {
        #pragma warning disable CS0649
        internal readonly Const_ShapeFilter? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_ShapeFilter() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `ShapeFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ShapeFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ShapeFilter`/`Const_ShapeFilter` directly.
    public class _InOptMut_ShapeFilter
    {
        public ShapeFilter? Opt;

        public _InOptMut_ShapeFilter() {}
        public _InOptMut_ShapeFilter(ShapeFilter value) {Opt = value;}
        public static implicit operator _InOptMut_ShapeFilter(ShapeFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `ShapeFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ShapeFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ShapeFilter`/`Const_ShapeFilter` to pass it to the function.
    public class _InOptConst_ShapeFilter
    {
        public Const_ShapeFilter? Opt;

        public _InOptConst_ShapeFilter() {}
        public _InOptConst_ShapeFilter(Const_ShapeFilter value) {Opt = value;}
        public static implicit operator _InOptConst_ShapeFilter(Const_ShapeFilter value) {return new(value);}
    }

    /// Helper class to reverse the order of the shapes in the ShouldCollide function
    /// Generated from class `JPH::ReversedShapeFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_ReversedShapeFilter : JPH.Object<Const_ReversedShapeFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ReversedShapeFilter_Destroy(_Underlying *_this);
            __JPH_ReversedShapeFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ReversedShapeFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_ReversedShapeFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_ReversedShapeFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_ReversedShapeFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ShapeFilter(Const_ReversedShapeFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_UpcastTo_JPH_ShapeFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_UpcastTo_JPH_ShapeFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ShapeFilter._Underlying *__JPH_ReversedShapeFilter_UpcastTo_JPH_ShapeFilter(_Underlying *_this);
            JPH.Const_ShapeFilter ret = new(__JPH_ReversedShapeFilter_UpcastTo_JPH_ShapeFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_ReversedShapeFilter(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_ReversedShapeFilter ret = new(__JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_ReversedShapeFilter(JPH.Const_ShapeFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_ShapeFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_ShapeFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_ShapeFilter(JPH.Const_ShapeFilter._Underlying *_this);
            Const_ReversedShapeFilter ret = new(__JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_ShapeFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// Used during NarrowPhase queries and TransformedShape queries. Set to the body ID of inShape2 before calling ShouldCollide.
        /// Provides context to the filter to indicate which body is colliding.
        public unsafe ref readonly JPH.BodyID mBodyID2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_Get_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_Get_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_ReversedShapeFilter_Get_mBodyID2(_Underlying *_this);
                return ref *__JPH_ReversedShapeFilter_Get_mBodyID2(_UnderlyingPtr);
            }
        }

        internal unsafe Const_ReversedShapeFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// Generated from constructor `JPH::ReversedShapeFilter::ReversedShapeFilter`.
        public unsafe Const_ReversedShapeFilter(JPH.Const_ShapeFilter inFilter) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ReversedShapeFilter._Underlying *__JPH_ReversedShapeFilter_Construct(JPH.Const_ShapeFilter._Underlying *inFilter);
            _UnderlyingPtr = __JPH_ReversedShapeFilter_Construct(inFilter._UnderlyingPtr);
        }

        /// Generated from method `JPH::ReversedShapeFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(JPH.Const_Shape? inShape2, JPH.Const_SubShapeID inSubShapeIDOfShape2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_ShouldCollide_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_ShouldCollide_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_ReversedShapeFilter_ShouldCollide_2(_Underlying *_this, JPH.Const_Shape._Underlying *inShape2, JPH.Const_SubShapeID._Underlying *inSubShapeIDOfShape2);
            return __JPH_ReversedShapeFilter_ShouldCollide_2(_UnderlyingPtr, inShape2 is not null ? inShape2._UnderlyingPtr : null, inSubShapeIDOfShape2._UnderlyingPtr) != 0;
        }

        /// Generated from method `JPH::ReversedShapeFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(JPH.Const_Shape? inShape1, JPH.Const_SubShapeID inSubShapeIDOfShape1, JPH.Const_Shape? inShape2, JPH.Const_SubShapeID inSubShapeIDOfShape2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_ShouldCollide_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_ShouldCollide_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_ReversedShapeFilter_ShouldCollide_4(_Underlying *_this, JPH.Const_Shape._Underlying *inShape1, JPH.Const_SubShapeID._Underlying *inSubShapeIDOfShape1, JPH.Const_Shape._Underlying *inShape2, JPH.Const_SubShapeID._Underlying *inSubShapeIDOfShape2);
            return __JPH_ReversedShapeFilter_ShouldCollide_4(_UnderlyingPtr, inShape1 is not null ? inShape1._UnderlyingPtr : null, inSubShapeIDOfShape1._UnderlyingPtr, inShape2 is not null ? inShape2._UnderlyingPtr : null, inSubShapeIDOfShape2._UnderlyingPtr) != 0;
        }
    }

    /// Helper class to reverse the order of the shapes in the ShouldCollide function
    /// Generated from class `JPH::ReversedShapeFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class ReversedShapeFilter : Const_ReversedShapeFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(ReversedShapeFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_ReversedShapeFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_ReversedShapeFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ShapeFilter(ReversedShapeFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_UpcastTo_JPH_ShapeFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_UpcastTo_JPH_ShapeFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeFilter._Underlying *__JPH_ReversedShapeFilter_UpcastTo_JPH_ShapeFilter(_Underlying *_this);
            JPH.ShapeFilter ret = new(__JPH_ReversedShapeFilter_UpcastTo_JPH_ShapeFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator ReversedShapeFilter(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            ReversedShapeFilter ret = new(__JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator ReversedShapeFilter(JPH.ShapeFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_ShapeFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_ShapeFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_ShapeFilter(JPH.ShapeFilter._Underlying *_this);
            ReversedShapeFilter ret = new(__JPH_ReversedShapeFilter_StaticDowncastFrom_JPH_ShapeFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// Used during NarrowPhase queries and TransformedShape queries. Set to the body ID of inShape2 before calling ShouldCollide.
        /// Provides context to the filter to indicate which body is colliding.
        public new unsafe ref JPH.BodyID mBodyID2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_GetMutable_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_GetMutable_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_ReversedShapeFilter_GetMutable_mBodyID2(_Underlying *_this);
                return ref *__JPH_ReversedShapeFilter_GetMutable_mBodyID2(_UnderlyingPtr);
            }
        }

        internal unsafe ReversedShapeFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// Generated from constructor `JPH::ReversedShapeFilter::ReversedShapeFilter`.
        public unsafe ReversedShapeFilter(JPH.Const_ShapeFilter inFilter) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ReversedShapeFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ReversedShapeFilter_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ReversedShapeFilter._Underlying *__JPH_ReversedShapeFilter_Construct(JPH.Const_ShapeFilter._Underlying *inFilter);
            _UnderlyingPtr = __JPH_ReversedShapeFilter_Construct(inFilter._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `ReversedShapeFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ReversedShapeFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ReversedShapeFilter`/`Const_ReversedShapeFilter` directly.
    public class _InOptMut_ReversedShapeFilter
    {
        public ReversedShapeFilter? Opt;

        public _InOptMut_ReversedShapeFilter() {}
        public _InOptMut_ReversedShapeFilter(ReversedShapeFilter value) {Opt = value;}
        public static implicit operator _InOptMut_ReversedShapeFilter(ReversedShapeFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `ReversedShapeFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ReversedShapeFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ReversedShapeFilter`/`Const_ReversedShapeFilter` to pass it to the function.
    public class _InOptConst_ReversedShapeFilter
    {
        public Const_ReversedShapeFilter? Opt;

        public _InOptConst_ReversedShapeFilter() {}
        public _InOptConst_ReversedShapeFilter(Const_ReversedShapeFilter value) {Opt = value;}
        public static implicit operator _InOptConst_ReversedShapeFilter(Const_ReversedShapeFilter value) {return new(value);}
    }
}
