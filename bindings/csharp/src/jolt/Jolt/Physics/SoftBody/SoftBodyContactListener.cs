// machine generated, do not edit
public static partial class JPH
{
    /// Return value for the OnSoftBodyContactValidate callback. Determines if the contact will be processed or not.
    public enum SoftBodyValidateResult : int
    {
        ///< Accept this contact
        AcceptContact = 0,
        ///< Reject this contact
        RejectContact = 1,
    }

    /// Contact settings for a soft body contact.
    /// The values are filled in with their defaults by the system so the callback doesn't need to modify anything, but it can if it wants to.
    /// Generated from class `JPH::SoftBodyContactSettings`.
    /// This is the const half of the class.
    public class Const_SoftBodyContactSettings : JPH.Object<Const_SoftBodyContactSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyContactSettings_Destroy(_Underlying *_this);
            __JPH_SoftBodyContactSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SoftBodyContactSettings() {Dispose(false);}

        ///< Scale factor for the inverse mass of the soft body (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
        public unsafe float mInvMassScale1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_Get_mInvMassScale1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_Get_mInvMassScale1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SoftBodyContactSettings_Get_mInvMassScale1(_Underlying *_this);
                return *__JPH_SoftBodyContactSettings_Get_mInvMassScale1(_UnderlyingPtr);
            }
        }

        ///< Scale factor for the inverse mass of the other body (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
        public unsafe float mInvMassScale2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_Get_mInvMassScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_Get_mInvMassScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SoftBodyContactSettings_Get_mInvMassScale2(_Underlying *_this);
                return *__JPH_SoftBodyContactSettings_Get_mInvMassScale2(_UnderlyingPtr);
            }
        }

        ///< Scale factor for the inverse inertia of the other body (usually same as mInvMassScale2)
        public unsafe float mInvInertiaScale2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_Get_mInvInertiaScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_Get_mInvInertiaScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SoftBodyContactSettings_Get_mInvInertiaScale2(_Underlying *_this);
                return *__JPH_SoftBodyContactSettings_Get_mInvInertiaScale2(_UnderlyingPtr);
            }
        }

        ///< If the contact should be treated as a sensor vs body contact (no collision response)
        public unsafe bool mIsSensor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_Get_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_Get_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_SoftBodyContactSettings_Get_mIsSensor(_Underlying *_this);
                return *__JPH_SoftBodyContactSettings_Get_mIsSensor(_UnderlyingPtr);
            }
        }

        internal unsafe Const_SoftBodyContactSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_SoftBodyContactSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyContactSettings._Underlying *__JPH_SoftBodyContactSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_SoftBodyContactSettings_DefaultConstruct();
        }

        /// Constructs `JPH::SoftBodyContactSettings` elementwise.
        public unsafe Const_SoftBodyContactSettings(float mInvMassScale1, float mInvMassScale2, float mInvInertiaScale2, bool mIsSensor) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyContactSettings._Underlying *__JPH_SoftBodyContactSettings_ConstructFrom(float mInvMassScale1, float mInvMassScale2, float mInvInertiaScale2, byte mIsSensor);
            _UnderlyingPtr = __JPH_SoftBodyContactSettings_ConstructFrom(mInvMassScale1, mInvMassScale2, mInvInertiaScale2, mIsSensor ? (byte)1 : (byte)0);
        }

        /// Generated from constructor `JPH::SoftBodyContactSettings::SoftBodyContactSettings`.
        public unsafe Const_SoftBodyContactSettings(JPH.Const_SoftBodyContactSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyContactSettings._Underlying *__JPH_SoftBodyContactSettings_ConstructFromAnother(JPH.SoftBodyContactSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_SoftBodyContactSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::SoftBodyContactSettings::SoftBodyContactSettings`.
        public Const_SoftBodyContactSettings(SoftBodyContactSettings _other) : this((Const_SoftBodyContactSettings)_other) {}
    }

    /// Contact settings for a soft body contact.
    /// The values are filled in with their defaults by the system so the callback doesn't need to modify anything, but it can if it wants to.
    /// Generated from class `JPH::SoftBodyContactSettings`.
    /// This is the non-const half of the class.
    public class SoftBodyContactSettings : Const_SoftBodyContactSettings
    {
        ///< Scale factor for the inverse mass of the soft body (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
        public new unsafe ref float mInvMassScale1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_GetMutable_mInvMassScale1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_GetMutable_mInvMassScale1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SoftBodyContactSettings_GetMutable_mInvMassScale1(_Underlying *_this);
                return ref *__JPH_SoftBodyContactSettings_GetMutable_mInvMassScale1(_UnderlyingPtr);
            }
        }

        ///< Scale factor for the inverse mass of the other body (0 = infinite mass, 1 = use original mass, 2 = body has half the mass). For the same contact pair, you should strive to keep the value the same over time.
        public new unsafe ref float mInvMassScale2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_GetMutable_mInvMassScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_GetMutable_mInvMassScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SoftBodyContactSettings_GetMutable_mInvMassScale2(_Underlying *_this);
                return ref *__JPH_SoftBodyContactSettings_GetMutable_mInvMassScale2(_UnderlyingPtr);
            }
        }

        ///< Scale factor for the inverse inertia of the other body (usually same as mInvMassScale2)
        public new unsafe ref float mInvInertiaScale2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_GetMutable_mInvInertiaScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_GetMutable_mInvInertiaScale2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SoftBodyContactSettings_GetMutable_mInvInertiaScale2(_Underlying *_this);
                return ref *__JPH_SoftBodyContactSettings_GetMutable_mInvInertiaScale2(_UnderlyingPtr);
            }
        }

        ///< If the contact should be treated as a sensor vs body contact (no collision response)
        public new unsafe ref bool mIsSensor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_GetMutable_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_GetMutable_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_SoftBodyContactSettings_GetMutable_mIsSensor(_Underlying *_this);
                return ref *__JPH_SoftBodyContactSettings_GetMutable_mIsSensor(_UnderlyingPtr);
            }
        }

        internal unsafe SoftBodyContactSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe SoftBodyContactSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyContactSettings._Underlying *__JPH_SoftBodyContactSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_SoftBodyContactSettings_DefaultConstruct();
        }

        /// Constructs `JPH::SoftBodyContactSettings` elementwise.
        public unsafe SoftBodyContactSettings(float mInvMassScale1, float mInvMassScale2, float mInvInertiaScale2, bool mIsSensor) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyContactSettings._Underlying *__JPH_SoftBodyContactSettings_ConstructFrom(float mInvMassScale1, float mInvMassScale2, float mInvInertiaScale2, byte mIsSensor);
            _UnderlyingPtr = __JPH_SoftBodyContactSettings_ConstructFrom(mInvMassScale1, mInvMassScale2, mInvInertiaScale2, mIsSensor ? (byte)1 : (byte)0);
        }

        /// Generated from constructor `JPH::SoftBodyContactSettings::SoftBodyContactSettings`.
        public unsafe SoftBodyContactSettings(JPH.Const_SoftBodyContactSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyContactSettings._Underlying *__JPH_SoftBodyContactSettings_ConstructFromAnother(JPH.SoftBodyContactSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_SoftBodyContactSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::SoftBodyContactSettings::SoftBodyContactSettings`.
        public SoftBodyContactSettings(SoftBodyContactSettings _other) : this((Const_SoftBodyContactSettings)_other) {}

        /// Generated from method `JPH::SoftBodyContactSettings::operator=`.
        public unsafe JPH.SoftBodyContactSettings Assign(JPH.Const_SoftBodyContactSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyContactSettings._Underlying *__JPH_SoftBodyContactSettings_AssignFromAnother(_Underlying *_this, JPH.SoftBodyContactSettings._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_SoftBodyContactSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `SoftBodyContactSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SoftBodyContactSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SoftBodyContactSettings`/`Const_SoftBodyContactSettings` directly.
    public class _InOptMut_SoftBodyContactSettings
    {
        public SoftBodyContactSettings? Opt;

        public _InOptMut_SoftBodyContactSettings() {}
        public _InOptMut_SoftBodyContactSettings(SoftBodyContactSettings value) {Opt = value;}
        public static implicit operator _InOptMut_SoftBodyContactSettings(SoftBodyContactSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `SoftBodyContactSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SoftBodyContactSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SoftBodyContactSettings`/`Const_SoftBodyContactSettings` to pass it to the function.
    public class _InOptConst_SoftBodyContactSettings
    {
        public Const_SoftBodyContactSettings? Opt;

        public _InOptConst_SoftBodyContactSettings() {}
        public _InOptConst_SoftBodyContactSettings(Const_SoftBodyContactSettings value) {Opt = value;}
        public static implicit operator _InOptConst_SoftBodyContactSettings(Const_SoftBodyContactSettings value) {return new(value);}
    }

    /// A listener class that receives collision contact events for soft bodies against rigid bodies.
    /// It can be registered with the PhysicsSystem.
    /// Generated from class `JPH::SoftBodyContactListener`.
    /// This is the const half of the class.
    public class Const_SoftBodyContactListener : JPH.Object<Const_SoftBodyContactListener>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyContactListener_Destroy(_Underlying *_this);
            __JPH_SoftBodyContactListener_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SoftBodyContactListener() {Dispose(false);}

        internal unsafe Const_SoftBodyContactListener(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_SoftBodyContactListener() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyContactListener._Underlying *__JPH_SoftBodyContactListener_DefaultConstruct();
            _UnderlyingPtr = __JPH_SoftBodyContactListener_DefaultConstruct();
        }

        /// Generated from constructor `JPH::SoftBodyContactListener::SoftBodyContactListener`.
        public unsafe Const_SoftBodyContactListener(JPH._ByValue_SoftBodyContactListener _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyContactListener._Underlying *__JPH_SoftBodyContactListener_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SoftBodyContactListener._Underlying *_other);
            _UnderlyingPtr = __JPH_SoftBodyContactListener_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::SoftBodyContactListener::SoftBodyContactListener`.
        public Const_SoftBodyContactListener(Const_SoftBodyContactListener _other) : this(new _ByValue_SoftBodyContactListener(_other)) {}

        /// Generated from constructor `JPH::SoftBodyContactListener::SoftBodyContactListener`.
        public Const_SoftBodyContactListener(SoftBodyContactListener _other) : this((Const_SoftBodyContactListener)_other) {}
    }

    /// A listener class that receives collision contact events for soft bodies against rigid bodies.
    /// It can be registered with the PhysicsSystem.
    /// Generated from class `JPH::SoftBodyContactListener`.
    /// This is the non-const half of the class.
    public class SoftBodyContactListener : Const_SoftBodyContactListener
    {
        internal unsafe SoftBodyContactListener(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe SoftBodyContactListener() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyContactListener._Underlying *__JPH_SoftBodyContactListener_DefaultConstruct();
            _UnderlyingPtr = __JPH_SoftBodyContactListener_DefaultConstruct();
        }

        /// Generated from constructor `JPH::SoftBodyContactListener::SoftBodyContactListener`.
        public unsafe SoftBodyContactListener(JPH._ByValue_SoftBodyContactListener _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyContactListener._Underlying *__JPH_SoftBodyContactListener_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SoftBodyContactListener._Underlying *_other);
            _UnderlyingPtr = __JPH_SoftBodyContactListener_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::SoftBodyContactListener::SoftBodyContactListener`.
        public SoftBodyContactListener(Const_SoftBodyContactListener _other) : this(new _ByValue_SoftBodyContactListener(_other)) {}

        /// Generated from constructor `JPH::SoftBodyContactListener::SoftBodyContactListener`.
        public SoftBodyContactListener(SoftBodyContactListener _other) : this((Const_SoftBodyContactListener)_other) {}

        /// Generated from method `JPH::SoftBodyContactListener::operator=`.
        public unsafe JPH.SoftBodyContactListener Assign(JPH._ByValue_SoftBodyContactListener _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactListener_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactListener_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyContactListener._Underlying *__JPH_SoftBodyContactListener_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.SoftBodyContactListener._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_SoftBodyContactListener_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Called whenever the soft body's aabox overlaps with another body's aabox (so receiving this callback doesn't tell if any of the vertices will collide).
        /// This callback can be used to change the behavior of the collision response for all vertices in the soft body or to completely reject the contact.
        /// Note that this callback is called when all bodies are locked, so don't use any locking functions!
        /// @param inSoftBody The soft body that collided. It is safe to access this as the soft body is only updated on the current thread.
        /// @param inOtherBody The other body that collided. Note that accessing the position/orientation/velocity of inOtherBody may result in a race condition as other threads may be modifying the body at the same time.
        /// @param ioSettings The settings for all contact points that are generated by this collision.
        /// @return Whether the contact should be processed or not.
        /// Generated from method `JPH::SoftBodyContactListener::OnSoftBodyContactValidate`.
        public unsafe JPH.SoftBodyValidateResult OnSoftBodyContactValidate(JPH.Const_Body inSoftBody, JPH.Const_Body inOtherBody, JPH.SoftBodyContactSettings ioSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactListener_OnSoftBodyContactValidate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactListener_OnSoftBodyContactValidate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyValidateResult __JPH_SoftBodyContactListener_OnSoftBodyContactValidate(_Underlying *_this, JPH.Const_Body._Underlying *inSoftBody, JPH.Const_Body._Underlying *inOtherBody, JPH.SoftBodyContactSettings._Underlying *ioSettings);
            return __JPH_SoftBodyContactListener_OnSoftBodyContactValidate(_UnderlyingPtr, inSoftBody._UnderlyingPtr, inOtherBody._UnderlyingPtr, ioSettings._UnderlyingPtr);
        }

        /// Called after all contact points for a soft body have been handled.
        /// Note that this callback is called when all bodies are locked, so don't use any locking functions!
        /// You will receive a single callback for a soft body per simulation step for performance reasons, this callback will apply to all vertices in the soft body.
        /// @param inSoftBody The soft body that collided. It is safe to access this as the soft body is only updated on the current thread.
        /// @param inManifold The manifold that describes which vertices collide and with what body they collide. Other bodies may be modified by other threads during this callback.
        /// Generated from method `JPH::SoftBodyContactListener::OnSoftBodyContactAdded`.
        public unsafe void OnSoftBodyContactAdded(JPH.Const_Body inSoftBody, JPH.Const_SoftBodyManifold inManifold)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyContactListener_OnSoftBodyContactAdded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyContactListener_OnSoftBodyContactAdded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyContactListener_OnSoftBodyContactAdded(_Underlying *_this, JPH.Const_Body._Underlying *inSoftBody, JPH.Const_SoftBodyManifold._Underlying *inManifold);
            __JPH_SoftBodyContactListener_OnSoftBodyContactAdded(_UnderlyingPtr, inSoftBody._UnderlyingPtr, inManifold._UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `SoftBodyContactListener` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `SoftBodyContactListener`/`Const_SoftBodyContactListener` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_SoftBodyContactListener
    {
        #pragma warning disable CS0649
        internal readonly Const_SoftBodyContactListener? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_SoftBodyContactListener() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_SoftBodyContactListener(Const_SoftBodyContactListener new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_SoftBodyContactListener(Const_SoftBodyContactListener arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `SoftBodyContactListener` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SoftBodyContactListener`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SoftBodyContactListener`/`Const_SoftBodyContactListener` directly.
    public class _InOptMut_SoftBodyContactListener
    {
        public SoftBodyContactListener? Opt;

        public _InOptMut_SoftBodyContactListener() {}
        public _InOptMut_SoftBodyContactListener(SoftBodyContactListener value) {Opt = value;}
        public static implicit operator _InOptMut_SoftBodyContactListener(SoftBodyContactListener value) {return new(value);}
    }

    /// This is used for optional parameters of class `SoftBodyContactListener` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SoftBodyContactListener`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SoftBodyContactListener`/`Const_SoftBodyContactListener` to pass it to the function.
    public class _InOptConst_SoftBodyContactListener
    {
        public Const_SoftBodyContactListener? Opt;

        public _InOptConst_SoftBodyContactListener() {}
        public _InOptConst_SoftBodyContactListener(Const_SoftBodyContactListener value) {Opt = value;}
        public static implicit operator _InOptConst_SoftBodyContactListener(Const_SoftBodyContactListener value) {return new(value);}
    }
}
