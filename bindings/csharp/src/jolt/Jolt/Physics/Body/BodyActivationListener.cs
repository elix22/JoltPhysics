// machine generated, do not edit
public static partial class JPH
{
    /// A listener class that receives events when a body activates or deactivates.
    /// It can be registered with the BodyManager (or PhysicsSystem).
    /// Generated from class `JPH::BodyActivationListener`.
    /// This is the const half of the class.
    public class Const_BodyActivationListener : JPH.Object<Const_BodyActivationListener>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyActivationListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyActivationListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyActivationListener_Destroy(_Underlying *_this);
            __JPH_BodyActivationListener_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BodyActivationListener() {Dispose(false);}

        internal unsafe Const_BodyActivationListener(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}
    }

    /// A listener class that receives events when a body activates or deactivates.
    /// It can be registered with the BodyManager (or PhysicsSystem).
    /// Generated from class `JPH::BodyActivationListener`.
    /// This is the non-const half of the class.
    public class BodyActivationListener : Const_BodyActivationListener
    {
        internal unsafe BodyActivationListener(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Called whenever a body activates, note this can be called from any thread so make sure your code is thread safe.
        /// At the time of the callback the body inBodyID will be locked and no bodies can be written/activated/deactivated from the callback.
        /// Generated from method `JPH::BodyActivationListener::OnBodyActivated`.
        public unsafe void OnBodyActivated(in JPH.BodyID inBodyID, UIntPtr inBodyUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyActivationListener_OnBodyActivated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyActivationListener_OnBodyActivated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyActivationListener_OnBodyActivated(_Underlying *_this, JPH.BodyID *inBodyID, UIntPtr inBodyUserData);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyActivationListener_OnBodyActivated(_UnderlyingPtr, __ptr_inBodyID, inBodyUserData);
            }
        }

        /// Called whenever a body deactivates, note this can be called from any thread so make sure your code is thread safe.
        /// At the time of the callback the body inBodyID will be locked and no bodies can be written/activated/deactivated from the callback.
        /// Generated from method `JPH::BodyActivationListener::OnBodyDeactivated`.
        public unsafe void OnBodyDeactivated(in JPH.BodyID inBodyID, UIntPtr inBodyUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyActivationListener_OnBodyDeactivated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyActivationListener_OnBodyDeactivated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyActivationListener_OnBodyDeactivated(_Underlying *_this, JPH.BodyID *inBodyID, UIntPtr inBodyUserData);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyActivationListener_OnBodyDeactivated(_UnderlyingPtr, __ptr_inBodyID, inBodyUserData);
            }
        }
    }

    /// This is used for optional parameters of class `BodyActivationListener` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BodyActivationListener`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BodyActivationListener`/`Const_BodyActivationListener` directly.
    public class _InOptMut_BodyActivationListener
    {
        public BodyActivationListener? Opt;

        public _InOptMut_BodyActivationListener() {}
        public _InOptMut_BodyActivationListener(BodyActivationListener value) {Opt = value;}
        public static implicit operator _InOptMut_BodyActivationListener(BodyActivationListener value) {return new(value);}
    }

    /// This is used for optional parameters of class `BodyActivationListener` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BodyActivationListener`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BodyActivationListener`/`Const_BodyActivationListener` to pass it to the function.
    public class _InOptConst_BodyActivationListener
    {
        public Const_BodyActivationListener? Opt;

        public _InOptConst_BodyActivationListener() {}
        public _InOptConst_BodyActivationListener(Const_BodyActivationListener value) {Opt = value;}
        public static implicit operator _InOptConst_BodyActivationListener(Const_BodyActivationListener value) {return new(value);}
    }
}
