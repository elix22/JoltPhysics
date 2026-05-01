// machine generated, do not edit
public static partial class JPH
{
    /// Context information for the step listener
    /// Generated from class `JPH::PhysicsStepListenerContext`.
    /// This is the const half of the class.
    public class Const_PhysicsStepListenerContext : JPH.Object<Const_PhysicsStepListenerContext>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsStepListenerContext_Destroy(_Underlying *_this);
            __JPH_PhysicsStepListenerContext_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_PhysicsStepListenerContext() {Dispose(false);}

        ///< Delta time of the current step
        public unsafe float mDeltaTime
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_Get_mDeltaTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_Get_mDeltaTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsStepListenerContext_Get_mDeltaTime(_Underlying *_this);
                return *__JPH_PhysicsStepListenerContext_Get_mDeltaTime(_UnderlyingPtr);
            }
        }

        ///< True if this is the first step
        public unsafe bool mIsFirstStep
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_Get_mIsFirstStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_Get_mIsFirstStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsStepListenerContext_Get_mIsFirstStep(_Underlying *_this);
                return *__JPH_PhysicsStepListenerContext_Get_mIsFirstStep(_UnderlyingPtr);
            }
        }

        ///< True if this is the last step
        public unsafe bool mIsLastStep
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_Get_mIsLastStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_Get_mIsLastStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsStepListenerContext_Get_mIsLastStep(_Underlying *_this);
                return *__JPH_PhysicsStepListenerContext_Get_mIsLastStep(_UnderlyingPtr);
            }
        }

        ///< The physics system that is being stepped
        public unsafe JPH.PhysicsSystem? mPhysicsSystem
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_Get_mPhysicsSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_Get_mPhysicsSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.PhysicsSystem._Underlying **__JPH_PhysicsStepListenerContext_Get_mPhysicsSystem(Const_PhysicsStepListenerContext._Underlying *_this);
                var ptr = __JPH_PhysicsStepListenerContext_Get_mPhysicsSystem(_UnderlyingPtr);
                JPH.PhysicsSystem? value = null;
                if (*ptr is not null)
                {
                    value = new(*ptr, is_owning: false);
                    value._KeepAliveEnclosingObject = this;
                }
                return value;
            }
        }

        internal unsafe Const_PhysicsStepListenerContext(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_PhysicsStepListenerContext() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsStepListenerContext._Underlying *__JPH_PhysicsStepListenerContext_DefaultConstruct();
            _UnderlyingPtr = __JPH_PhysicsStepListenerContext_DefaultConstruct();
        }

        /// Constructs `JPH::PhysicsStepListenerContext` elementwise.
        public unsafe Const_PhysicsStepListenerContext(float mDeltaTime, bool mIsFirstStep, bool mIsLastStep, JPH.PhysicsSystem? mPhysicsSystem) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsStepListenerContext._Underlying *__JPH_PhysicsStepListenerContext_ConstructFrom(float mDeltaTime, byte mIsFirstStep, byte mIsLastStep, JPH.PhysicsSystem._Underlying *mPhysicsSystem);
            _UnderlyingPtr = __JPH_PhysicsStepListenerContext_ConstructFrom(mDeltaTime, mIsFirstStep ? (byte)1 : (byte)0, mIsLastStep ? (byte)1 : (byte)0, mPhysicsSystem is not null ? mPhysicsSystem._UnderlyingPtr : null);
            if (mPhysicsSystem is not null) _KeepAlive(mPhysicsSystem);
        }
    }

    /// Context information for the step listener
    /// Generated from class `JPH::PhysicsStepListenerContext`.
    /// This is the non-const half of the class.
    public class PhysicsStepListenerContext : Const_PhysicsStepListenerContext
    {
        ///< Delta time of the current step
        public new unsafe ref float mDeltaTime
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_GetMutable_mDeltaTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_GetMutable_mDeltaTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsStepListenerContext_GetMutable_mDeltaTime(_Underlying *_this);
                return ref *__JPH_PhysicsStepListenerContext_GetMutable_mDeltaTime(_UnderlyingPtr);
            }
        }

        ///< True if this is the first step
        public new unsafe ref bool mIsFirstStep
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_GetMutable_mIsFirstStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_GetMutable_mIsFirstStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsStepListenerContext_GetMutable_mIsFirstStep(_Underlying *_this);
                return ref *__JPH_PhysicsStepListenerContext_GetMutable_mIsFirstStep(_UnderlyingPtr);
            }
        }

        ///< True if this is the last step
        public new unsafe ref bool mIsLastStep
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_GetMutable_mIsLastStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_GetMutable_mIsLastStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsStepListenerContext_GetMutable_mIsLastStep(_Underlying *_this);
                return ref *__JPH_PhysicsStepListenerContext_GetMutable_mIsLastStep(_UnderlyingPtr);
            }
        }

        ///< The physics system that is being stepped
        public new unsafe JPH.PhysicsSystem? mPhysicsSystem
        {
            get => base.mPhysicsSystem;
            set
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_GetMutable_mPhysicsSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_GetMutable_mPhysicsSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.PhysicsSystem._Underlying **__JPH_PhysicsStepListenerContext_GetMutable_mPhysicsSystem(PhysicsStepListenerContext._Underlying *_this);
                var ptr = __JPH_PhysicsStepListenerContext_GetMutable_mPhysicsSystem(_UnderlyingPtr);
                _DiscardKeepAlive("mPhysicsSystem");
                if (value is not null)
                    _KeepAlive(value, "mPhysicsSystem");
                *ptr = (value is not null ? value._UnderlyingPtr : null);
            }
        }

        internal unsafe PhysicsStepListenerContext(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe PhysicsStepListenerContext() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsStepListenerContext._Underlying *__JPH_PhysicsStepListenerContext_DefaultConstruct();
            _UnderlyingPtr = __JPH_PhysicsStepListenerContext_DefaultConstruct();
        }

        /// Constructs `JPH::PhysicsStepListenerContext` elementwise.
        public unsafe PhysicsStepListenerContext(float mDeltaTime, bool mIsFirstStep, bool mIsLastStep, JPH.PhysicsSystem? mPhysicsSystem) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsStepListenerContext_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsStepListenerContext._Underlying *__JPH_PhysicsStepListenerContext_ConstructFrom(float mDeltaTime, byte mIsFirstStep, byte mIsLastStep, JPH.PhysicsSystem._Underlying *mPhysicsSystem);
            _UnderlyingPtr = __JPH_PhysicsStepListenerContext_ConstructFrom(mDeltaTime, mIsFirstStep ? (byte)1 : (byte)0, mIsLastStep ? (byte)1 : (byte)0, mPhysicsSystem is not null ? mPhysicsSystem._UnderlyingPtr : null);
            if (mPhysicsSystem is not null) _KeepAlive(mPhysicsSystem);
        }
    }

    /// This is used as a function parameter when the underlying function receives `PhysicsStepListenerContext` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_PhysicsStepListenerContext
    {
        #pragma warning disable CS0649
        internal readonly Const_PhysicsStepListenerContext? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_PhysicsStepListenerContext() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `PhysicsStepListenerContext` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_PhysicsStepListenerContext`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PhysicsStepListenerContext`/`Const_PhysicsStepListenerContext` directly.
    public class _InOptMut_PhysicsStepListenerContext
    {
        public PhysicsStepListenerContext? Opt;

        public _InOptMut_PhysicsStepListenerContext() {}
        public _InOptMut_PhysicsStepListenerContext(PhysicsStepListenerContext value) {Opt = value;}
        public static implicit operator _InOptMut_PhysicsStepListenerContext(PhysicsStepListenerContext value) {return new(value);}
    }

    /// This is used for optional parameters of class `PhysicsStepListenerContext` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_PhysicsStepListenerContext`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PhysicsStepListenerContext`/`Const_PhysicsStepListenerContext` to pass it to the function.
    public class _InOptConst_PhysicsStepListenerContext
    {
        public Const_PhysicsStepListenerContext? Opt;

        public _InOptConst_PhysicsStepListenerContext() {}
        public _InOptConst_PhysicsStepListenerContext(Const_PhysicsStepListenerContext value) {Opt = value;}
        public static implicit operator _InOptConst_PhysicsStepListenerContext(Const_PhysicsStepListenerContext value) {return new(value);}
    }

    /// A listener class that receives a callback before every physics simulation step
    /// Generated from class `JPH::PhysicsStepListener`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `CountingPhysicsStepListener`
    ///     `JPH::VehicleConstraint`
    /// This is the const half of the class.
    public class Const_PhysicsStepListener : JPH.Object<Const_PhysicsStepListener>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsStepListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsStepListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsStepListener_Destroy(_Underlying *_this);
            __JPH_PhysicsStepListener_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_PhysicsStepListener() {Dispose(false);}

        internal unsafe Const_PhysicsStepListener(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}
    }

    /// A listener class that receives a callback before every physics simulation step
    /// Generated from class `JPH::PhysicsStepListener`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `CountingPhysicsStepListener`
    ///     `JPH::VehicleConstraint`
    /// This is the non-const half of the class.
    public class PhysicsStepListener : Const_PhysicsStepListener
    {
        internal unsafe PhysicsStepListener(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}
    }

    /// This is used for optional parameters of class `PhysicsStepListener` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_PhysicsStepListener`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PhysicsStepListener`/`Const_PhysicsStepListener` directly.
    public class _InOptMut_PhysicsStepListener
    {
        public PhysicsStepListener? Opt;

        public _InOptMut_PhysicsStepListener() {}
        public _InOptMut_PhysicsStepListener(PhysicsStepListener value) {Opt = value;}
        public static implicit operator _InOptMut_PhysicsStepListener(PhysicsStepListener value) {return new(value);}
    }

    /// This is used for optional parameters of class `PhysicsStepListener` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_PhysicsStepListener`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PhysicsStepListener`/`Const_PhysicsStepListener` to pass it to the function.
    public class _InOptConst_PhysicsStepListener
    {
        public Const_PhysicsStepListener? Opt;

        public _InOptConst_PhysicsStepListener() {}
        public _InOptConst_PhysicsStepListener(Const_PhysicsStepListener value) {Opt = value;}
        public static implicit operator _InOptConst_PhysicsStepListener(Const_PhysicsStepListener value) {return new(value);}
    }
}
