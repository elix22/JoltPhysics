// machine generated, do not edit
public static partial class JPH
{
    /// Helper structure holding the reciprocal of a ray for Ray vs AABox testing
    /// Generated from class `JPH::RayInvDirection`.
    /// This is the const half of the class.
    public class Const_RayInvDirection : JPH.Object<Const_RayInvDirection>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayInvDirection_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayInvDirection_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RayInvDirection_Destroy(_Underlying *_this);
            __JPH_RayInvDirection_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RayInvDirection() {Dispose(false);}

        ///< 1 / ray direction
        public unsafe JPH.Const_Vec3 mInvDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayInvDirection_Get_mInvDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayInvDirection_Get_mInvDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_RayInvDirection_Get_mInvDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_RayInvDirection_Get_mInvDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< for each component if it is parallel to the coordinate axis
        public unsafe JPH.Const_UVec4 mIsParallel
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayInvDirection_Get_mIsParallel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayInvDirection_Get_mIsParallel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_UVec4._Underlying *__JPH_RayInvDirection_Get_mIsParallel(_Underlying *_this);
                JPH.Const_UVec4 __ret;
                __ret = new(__JPH_RayInvDirection_Get_mIsParallel(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_RayInvDirection(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RayInvDirection() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayInvDirection_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayInvDirection_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayInvDirection._Underlying *__JPH_RayInvDirection_DefaultConstruct();
            _UnderlyingPtr = __JPH_RayInvDirection_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RayInvDirection::RayInvDirection`.
        public unsafe Const_RayInvDirection(JPH.Const_RayInvDirection _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayInvDirection_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayInvDirection_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayInvDirection._Underlying *__JPH_RayInvDirection_ConstructFromAnother(JPH.RayInvDirection._Underlying *_other);
            _UnderlyingPtr = __JPH_RayInvDirection_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RayInvDirection::RayInvDirection`.
        public Const_RayInvDirection(RayInvDirection _other) : this((Const_RayInvDirection)_other) {}

        /// Generated from constructor `JPH::RayInvDirection::RayInvDirection`.
        public unsafe Const_RayInvDirection(JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayInvDirection_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayInvDirection_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayInvDirection._Underlying *__JPH_RayInvDirection_Construct(JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_RayInvDirection_Construct(inDirection._UnderlyingPtr);
        }
    }

    /// Helper structure holding the reciprocal of a ray for Ray vs AABox testing
    /// Generated from class `JPH::RayInvDirection`.
    /// This is the non-const half of the class.
    public class RayInvDirection : Const_RayInvDirection
    {
        ///< 1 / ray direction
        public new unsafe JPH.Vec3 mInvDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayInvDirection_GetMutable_mInvDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayInvDirection_GetMutable_mInvDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_RayInvDirection_GetMutable_mInvDirection(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_RayInvDirection_GetMutable_mInvDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< for each component if it is parallel to the coordinate axis
        public new unsafe JPH.UVec4 mIsParallel
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayInvDirection_GetMutable_mIsParallel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayInvDirection_GetMutable_mIsParallel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.UVec4._Underlying *__JPH_RayInvDirection_GetMutable_mIsParallel(_Underlying *_this);
                JPH.UVec4 __ret;
                __ret = new(__JPH_RayInvDirection_GetMutable_mIsParallel(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe RayInvDirection(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RayInvDirection() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayInvDirection_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayInvDirection_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayInvDirection._Underlying *__JPH_RayInvDirection_DefaultConstruct();
            _UnderlyingPtr = __JPH_RayInvDirection_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RayInvDirection::RayInvDirection`.
        public unsafe RayInvDirection(JPH.Const_RayInvDirection _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayInvDirection_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayInvDirection_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayInvDirection._Underlying *__JPH_RayInvDirection_ConstructFromAnother(JPH.RayInvDirection._Underlying *_other);
            _UnderlyingPtr = __JPH_RayInvDirection_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RayInvDirection::RayInvDirection`.
        public RayInvDirection(RayInvDirection _other) : this((Const_RayInvDirection)_other) {}

        /// Generated from constructor `JPH::RayInvDirection::RayInvDirection`.
        public unsafe RayInvDirection(JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayInvDirection_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayInvDirection_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayInvDirection._Underlying *__JPH_RayInvDirection_Construct(JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_RayInvDirection_Construct(inDirection._UnderlyingPtr);
        }

        /// Generated from method `JPH::RayInvDirection::operator=`.
        public unsafe JPH.RayInvDirection Assign(JPH.Const_RayInvDirection _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayInvDirection_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayInvDirection_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayInvDirection._Underlying *__JPH_RayInvDirection_AssignFromAnother(_Underlying *_this, JPH.RayInvDirection._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_RayInvDirection_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Set reciprocal from ray direction
        /// Generated from method `JPH::RayInvDirection::Set`.
        public unsafe void Set(JPH.Const_Vec3 inDirection)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayInvDirection_Set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayInvDirection_Set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RayInvDirection_Set(_Underlying *_this, JPH.Vec3._Underlying *inDirection);
            __JPH_RayInvDirection_Set(_UnderlyingPtr, inDirection._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `RayInvDirection` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RayInvDirection`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RayInvDirection`/`Const_RayInvDirection` directly.
    public class _InOptMut_RayInvDirection
    {
        public RayInvDirection? Opt;

        public _InOptMut_RayInvDirection() {}
        public _InOptMut_RayInvDirection(RayInvDirection value) {Opt = value;}
        public static implicit operator _InOptMut_RayInvDirection(RayInvDirection value) {return new(value);}
    }

    /// This is used for optional parameters of class `RayInvDirection` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RayInvDirection`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RayInvDirection`/`Const_RayInvDirection` to pass it to the function.
    public class _InOptConst_RayInvDirection
    {
        public Const_RayInvDirection? Opt;

        public _InOptConst_RayInvDirection() {}
        public _InOptConst_RayInvDirection(Const_RayInvDirection value) {Opt = value;}
        public static implicit operator _InOptConst_RayInvDirection(Const_RayInvDirection value) {return new(value);}
    }
}
