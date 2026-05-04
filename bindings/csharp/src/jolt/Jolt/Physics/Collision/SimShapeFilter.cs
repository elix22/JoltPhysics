// machine generated, do not edit
public static partial class JPH
{
    /// Filter class used during the simulation (PhysicsSystem::Update) to filter out collisions at shape level
    /// Generated from class `JPH::SimShapeFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_SimShapeFilter : JPH.Object<Const_SimShapeFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SimShapeFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SimShapeFilter_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SimShapeFilter_Destroy(_Underlying *_this);
            __JPH_SimShapeFilter_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SimShapeFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_SimShapeFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SimShapeFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SimShapeFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_SimShapeFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_SimShapeFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_SimShapeFilter(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SimShapeFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SimShapeFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SimShapeFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_SimShapeFilter ret = new(__JPH_SimShapeFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_SimShapeFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_SimShapeFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SimShapeFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SimShapeFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SimShapeFilter._Underlying *__JPH_SimShapeFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_SimShapeFilter_DefaultConstruct();
        }

        /// Filter function to determine if two shapes should collide. Returns true if the filter passes.
        /// This overload is called during the simulation (PhysicsSystem::Update) and must be registered with PhysicsSystem::SetSimShapeFilter.
        /// It is called at each level of the shape hierarchy, so if you have a compound shape with a box, this function will be called twice.
        /// It will not be called on triangles that are part of another shape, i.e a mesh shape will not trigger a callback per triangle.
        /// Note that this function is called from multiple threads and must be thread safe. All properties are read only.
        /// @param inBody1 1st body that is colliding
        /// @param inShape1 1st shape that is colliding
        /// @param inSubShapeIDOfShape1 The sub shape ID that will lead from inBody1.GetShape() to inShape1
        /// @param inBody2 2nd body that is colliding
        /// @param inShape2 2nd shape that is colliding
        /// @param inSubShapeIDOfShape2 The sub shape ID that will lead from inBody2.GetShape() to inShape2
        /// Generated from method `JPH::SimShapeFilter::ShouldCollide`.
        public unsafe bool ShouldCollide(JPH.Const_Body inBody1, JPH.Const_Shape? inShape1, JPH.Const_SubShapeID inSubShapeIDOfShape1, JPH.Const_Body inBody2, JPH.Const_Shape? inShape2, JPH.Const_SubShapeID inSubShapeIDOfShape2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SimShapeFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SimShapeFilter_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SimShapeFilter_ShouldCollide(_Underlying *_this, JPH.Const_Body._Underlying *inBody1, JPH.Const_Shape._Underlying *inShape1, JPH.Const_SubShapeID._Underlying *inSubShapeIDOfShape1, JPH.Const_Body._Underlying *inBody2, JPH.Const_Shape._Underlying *inShape2, JPH.Const_SubShapeID._Underlying *inSubShapeIDOfShape2);
            return __JPH_SimShapeFilter_ShouldCollide(_UnderlyingPtr, inBody1._UnderlyingPtr, inShape1 is not null ? inShape1._UnderlyingPtr : null, inSubShapeIDOfShape1._UnderlyingPtr, inBody2._UnderlyingPtr, inShape2 is not null ? inShape2._UnderlyingPtr : null, inSubShapeIDOfShape2._UnderlyingPtr) != 0;
        }
    }

    /// Filter class used during the simulation (PhysicsSystem::Update) to filter out collisions at shape level
    /// Generated from class `JPH::SimShapeFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class SimShapeFilter : Const_SimShapeFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(SimShapeFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SimShapeFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SimShapeFilter_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_SimShapeFilter_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_SimShapeFilter_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator SimShapeFilter(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SimShapeFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SimShapeFilter_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SimShapeFilter_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            SimShapeFilter ret = new(__JPH_SimShapeFilter_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe SimShapeFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe SimShapeFilter() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SimShapeFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SimShapeFilter_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SimShapeFilter._Underlying *__JPH_SimShapeFilter_DefaultConstruct();
            _UnderlyingPtr = __JPH_SimShapeFilter_DefaultConstruct();
        }
    }

    /// This is used as a function parameter when the underlying function receives `SimShapeFilter` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_SimShapeFilter
    {
        #pragma warning disable CS0649
        internal readonly Const_SimShapeFilter? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_SimShapeFilter() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `SimShapeFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SimShapeFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SimShapeFilter`/`Const_SimShapeFilter` directly.
    public class _InOptMut_SimShapeFilter
    {
        public SimShapeFilter? Opt;

        public _InOptMut_SimShapeFilter() {}
        public _InOptMut_SimShapeFilter(SimShapeFilter value) {Opt = value;}
        public static implicit operator _InOptMut_SimShapeFilter(SimShapeFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `SimShapeFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SimShapeFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SimShapeFilter`/`Const_SimShapeFilter` to pass it to the function.
    public class _InOptConst_SimShapeFilter
    {
        public Const_SimShapeFilter? Opt;

        public _InOptConst_SimShapeFilter() {}
        public _InOptConst_SimShapeFilter(Const_SimShapeFilter value) {Opt = value;}
        public static implicit operator _InOptConst_SimShapeFilter(Const_SimShapeFilter value) {return new(value);}
    }
}
