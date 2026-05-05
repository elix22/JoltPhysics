// machine generated, do not edit
public static partial class JPH
{
    /// An interface to query which vertices of a soft body are colliding with other bodies
    /// Generated from class `JPH::SoftBodyManifold`.
    /// This is the const half of the class.
    public class Const_SoftBodyManifold : JPH.Object<Const_SoftBodyManifold>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyManifold_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyManifold_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyManifold_Destroy(_Underlying *_this);
            __JPH_SoftBodyManifold_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SoftBodyManifold() {Dispose(false);}

        internal unsafe Const_SoftBodyManifold(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JPH::SoftBodyManifold::SoftBodyManifold`.
        public unsafe Const_SoftBodyManifold(JPH.Const_SoftBodyManifold _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyManifold_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyManifold_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyManifold._Underlying *__JPH_SoftBodyManifold_ConstructFromAnother(JPH.SoftBodyManifold._Underlying *_other);
            _UnderlyingPtr = __JPH_SoftBodyManifold_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::SoftBodyManifold::SoftBodyManifold`.
        public Const_SoftBodyManifold(SoftBodyManifold _other) : this((Const_SoftBodyManifold)_other) {}

        /// Check if a vertex has collided with something in this update
        /// Generated from method `JPH::SoftBodyManifold::HasContact`.
        public unsafe bool HasContact(JPH.Const_SoftBodyVertex inVertex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyManifold_HasContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyManifold_HasContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SoftBodyManifold_HasContact(_Underlying *_this, JPH.Const_SoftBodyVertex._Underlying *inVertex);
            return __JPH_SoftBodyManifold_HasContact(_UnderlyingPtr, inVertex._UnderlyingPtr) != 0;
        }

        /// Get the local space contact point (multiply by GetCenterOfMassTransform() of the soft body to get world space)
        /// Generated from method `JPH::SoftBodyManifold::GetLocalContactPoint`.
        public unsafe JPH.Vec3 GetLocalContactPoint(JPH.Const_SoftBodyVertex inVertex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyManifold_GetLocalContactPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyManifold_GetLocalContactPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SoftBodyManifold_GetLocalContactPoint(_Underlying *_this, JPH.Const_SoftBodyVertex._Underlying *inVertex);
            return new(__JPH_SoftBodyManifold_GetLocalContactPoint(_UnderlyingPtr, inVertex._UnderlyingPtr), is_owning: true);
        }

        /// Get the contact normal for the vertex (assumes there is a contact).
        /// Generated from method `JPH::SoftBodyManifold::GetContactNormal`.
        public unsafe JPH.Vec3 GetContactNormal(JPH.Const_SoftBodyVertex inVertex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyManifold_GetContactNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyManifold_GetContactNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SoftBodyManifold_GetContactNormal(_Underlying *_this, JPH.Const_SoftBodyVertex._Underlying *inVertex);
            return new(__JPH_SoftBodyManifold_GetContactNormal(_UnderlyingPtr, inVertex._UnderlyingPtr), is_owning: true);
        }

        /// Get the body with which the vertex has collided in this update
        /// Generated from method `JPH::SoftBodyManifold::GetContactBodyID`.
        public unsafe JPH.BodyID GetContactBodyID(JPH.Const_SoftBodyVertex inVertex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyManifold_GetContactBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyManifold_GetContactBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID __JPH_SoftBodyManifold_GetContactBodyID(_Underlying *_this, JPH.Const_SoftBodyVertex._Underlying *inVertex);
            return __JPH_SoftBodyManifold_GetContactBodyID(_UnderlyingPtr, inVertex._UnderlyingPtr);
        }

        /// Get the number of sensors that are in contact with the soft body
        /// Generated from method `JPH::SoftBodyManifold::GetNumSensorContacts`.
        public unsafe uint GetNumSensorContacts()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyManifold_GetNumSensorContacts", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyManifold_GetNumSensorContacts", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SoftBodyManifold_GetNumSensorContacts(_Underlying *_this);
            return __JPH_SoftBodyManifold_GetNumSensorContacts(_UnderlyingPtr);
        }

        /// Get the i-th sensor that is in contact with the soft body
        /// Generated from method `JPH::SoftBodyManifold::GetSensorContactBodyID`.
        public unsafe JPH.BodyID GetSensorContactBodyID(uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyManifold_GetSensorContactBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyManifold_GetSensorContactBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID __JPH_SoftBodyManifold_GetSensorContactBodyID(_Underlying *_this, uint inIndex);
            return __JPH_SoftBodyManifold_GetSensorContactBodyID(_UnderlyingPtr, inIndex);
        }
    }

    /// An interface to query which vertices of a soft body are colliding with other bodies
    /// Generated from class `JPH::SoftBodyManifold`.
    /// This is the non-const half of the class.
    public class SoftBodyManifold : Const_SoftBodyManifold
    {
        internal unsafe SoftBodyManifold(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JPH::SoftBodyManifold::SoftBodyManifold`.
        public unsafe SoftBodyManifold(JPH.Const_SoftBodyManifold _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyManifold_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyManifold_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyManifold._Underlying *__JPH_SoftBodyManifold_ConstructFromAnother(JPH.SoftBodyManifold._Underlying *_other);
            _UnderlyingPtr = __JPH_SoftBodyManifold_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::SoftBodyManifold::SoftBodyManifold`.
        public SoftBodyManifold(SoftBodyManifold _other) : this((Const_SoftBodyManifold)_other) {}
    }

    /// This is used for optional parameters of class `SoftBodyManifold` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SoftBodyManifold`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SoftBodyManifold`/`Const_SoftBodyManifold` directly.
    public class _InOptMut_SoftBodyManifold
    {
        public SoftBodyManifold? Opt;

        public _InOptMut_SoftBodyManifold() {}
        public _InOptMut_SoftBodyManifold(SoftBodyManifold value) {Opt = value;}
        public static implicit operator _InOptMut_SoftBodyManifold(SoftBodyManifold value) {return new(value);}
    }

    /// This is used for optional parameters of class `SoftBodyManifold` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SoftBodyManifold`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SoftBodyManifold`/`Const_SoftBodyManifold` to pass it to the function.
    public class _InOptConst_SoftBodyManifold
    {
        public Const_SoftBodyManifold? Opt;

        public _InOptConst_SoftBodyManifold() {}
        public _InOptConst_SoftBodyManifold(Const_SoftBodyManifold value) {Opt = value;}
        public static implicit operator _InOptConst_SoftBodyManifold(Const_SoftBodyManifold value) {return new(value);}
    }
}
