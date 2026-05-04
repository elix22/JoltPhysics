// machine generated, do not edit
public static partial class JPH
{
    /// Base class for wheel settings, each VehicleController can implement a derived class of this
    /// Generated from class `JPH::WheelSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::WheelSettings>`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::WheelSettingsWV`
    /// This is the const half of the class.
    public class Const_WheelSettings : JPH.Object<Const_WheelSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_Release(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_Release(__JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_WheelSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_WheelSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_WheelSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_WheelSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHWheelSettings(Const_WheelSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHWheelSettings._Underlying *__JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHWheelSettings ret = new(__JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_WheelSettings(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettings_StaticDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            Const_WheelSettings ret = new(__JPH_WheelSettings_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_WheelSettings(JPH.Const_RefTarget_JPHWheelSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettings_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(JPH.Const_RefTarget_JPHWheelSettings._Underlying *_this);
            Const_WheelSettings ret = new(__JPH_WheelSettings_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Attachment point of wheel suspension in local space of the body
        public unsafe JPH.Const_Vec3 mPosition
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettings_Get_mPosition(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettings_Get_mPosition(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Where tire forces (suspension and traction) are applied, in local space of the body. A good default is the center of the wheel in its neutral pose. See mEnableSuspensionForcePoint.
        public unsafe JPH.Const_Vec3 mSuspensionForcePoint
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_Get_mSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_Get_mSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettings_Get_mSuspensionForcePoint(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettings_Get_mSuspensionForcePoint(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction of the suspension in local space of the body, should point down
        public unsafe JPH.Const_Vec3 mSuspensionDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_Get_mSuspensionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_Get_mSuspensionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettings_Get_mSuspensionDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettings_Get_mSuspensionDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction of the steering axis in local space of the body, should point up (e.g. for a bike would be -mSuspensionDirection)
        public unsafe JPH.Const_Vec3 mSteeringAxis
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_Get_mSteeringAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_Get_mSteeringAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettings_Get_mSteeringAxis(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettings_Get_mSteeringAxis(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Up direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mUp but can be used to give the wheel camber or for a bike would be -mSuspensionDirection)
        public unsafe JPH.Const_Vec3 mWheelUp
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_Get_mWheelUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_Get_mWheelUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettings_Get_mWheelUp(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettings_Get_mWheelUp(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Forward direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mForward but can be used to give the wheel toe, does not need to be perpendicular to mWheelUp)
        public unsafe JPH.Const_Vec3 mWheelForward
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_Get_mWheelForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_Get_mWheelForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettings_Get_mWheelForward(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettings_Get_mWheelForward(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< How long the suspension is in max raised position relative to the attachment point (m)
        public unsafe float mSuspensionMinLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_Get_mSuspensionMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_Get_mSuspensionMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettings_Get_mSuspensionMinLength(_Underlying *_this);
                return *__JPH_WheelSettings_Get_mSuspensionMinLength(_UnderlyingPtr);
            }
        }

        ///< How long the suspension is in max droop position relative to the attachment point (m)
        public unsafe float mSuspensionMaxLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_Get_mSuspensionMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_Get_mSuspensionMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettings_Get_mSuspensionMaxLength(_Underlying *_this);
                return *__JPH_WheelSettings_Get_mSuspensionMaxLength(_UnderlyingPtr);
            }
        }

        ///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
        public unsafe float mSuspensionPreloadLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_Get_mSuspensionPreloadLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_Get_mSuspensionPreloadLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettings_Get_mSuspensionPreloadLength(_Underlying *_this);
                return *__JPH_WheelSettings_Get_mSuspensionPreloadLength(_UnderlyingPtr);
            }
        }

        ///< Settings for the suspension spring
        public unsafe JPH.Const_SpringSettings mSuspensionSpring
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_Get_mSuspensionSpring", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_Get_mSuspensionSpring", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_SpringSettings._Underlying *__JPH_WheelSettings_Get_mSuspensionSpring(_Underlying *_this);
                JPH.Const_SpringSettings __ret;
                __ret = new(__JPH_WheelSettings_Get_mSuspensionSpring(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Radius of the wheel (m)
        public unsafe float mRadius
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_Get_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_Get_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettings_Get_mRadius(_Underlying *_this);
                return *__JPH_WheelSettings_Get_mRadius(_UnderlyingPtr);
            }
        }

        ///< Width of the wheel (m)
        public unsafe float mWidth
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_Get_mWidth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_Get_mWidth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettings_Get_mWidth(_Underlying *_this);
                return *__JPH_WheelSettings_Get_mWidth(_UnderlyingPtr);
            }
        }

        ///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
        public unsafe bool mEnableSuspensionForcePoint
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_Get_mEnableSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_Get_mEnableSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_WheelSettings_Get_mEnableSuspensionForcePoint(_Underlying *_this);
                return *__JPH_WheelSettings_Get_mEnableSuspensionForcePoint(_UnderlyingPtr);
            }
        }

        internal unsafe Const_WheelSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_WheelSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettings._Underlying *__JPH_WheelSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_WheelSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_AddRef(__JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::WheelSettings::WheelSettings`.
        public unsafe Const_WheelSettings(JPH._ByValue_WheelSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettings._Underlying *__JPH_WheelSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.WheelSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_WheelSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_AddRef(__JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::WheelSettings::WheelSettings`.
        public Const_WheelSettings(Const_WheelSettings _other) : this(new _ByValue_WheelSettings(_other)) {}

        /// Generated from constructor `JPH::WheelSettings::WheelSettings`.
        public Const_WheelSettings(WheelSettings _other) : this((Const_WheelSettings)_other) {}

        /// Generated from method `JPH::WheelSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_WheelSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_WheelSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_WheelSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_WheelSettings_size_t(inCount);
        }

        /// Generated from method `JPH::WheelSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_WheelSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::WheelSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_WheelSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::WheelSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_WheelSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_WheelSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_WheelSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_WheelSettings_size_t(inCount);
        }

        /// Generated from method `JPH::WheelSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_WheelSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::WheelSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_WheelSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::WheelSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_WheelSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_WheelSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_WheelSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_WheelSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::WheelSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_WheelSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::WheelSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_WheelSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_WheelSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_WheelSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_WheelSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::WheelSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_WheelSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::WheelSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelSettings_SetEmbedded(_Underlying *_this);
            __JPH_WheelSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::WheelSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_WheelSettings_GetRefCount(_Underlying *_this);
            return __JPH_WheelSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::WheelSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelSettings_AddRef(_Underlying *_this);
            __JPH_WheelSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::WheelSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelSettings_Release(_Underlying *_this);
            __JPH_WheelSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::WheelSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_WheelSettings_sInternalGetRefCountOffset();
            return __JPH_WheelSettings_sInternalGetRefCountOffset();
        }
    }

    /// Base class for wheel settings, each VehicleController can implement a derived class of this
    /// Generated from class `JPH::WheelSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::WheelSettings>`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::WheelSettingsWV`
    /// This is the non-const half of the class.
    public class WheelSettings : Const_WheelSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(WheelSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_WheelSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_WheelSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.RefTarget_JPHWheelSettings(WheelSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHWheelSettings._Underlying *__JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            JPH.RefTarget_JPHWheelSettings ret = new(__JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator WheelSettings(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettings_StaticDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            WheelSettings ret = new(__JPH_WheelSettings_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator WheelSettings(JPH.RefTarget_JPHWheelSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettings_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(JPH.RefTarget_JPHWheelSettings._Underlying *_this);
            WheelSettings ret = new(__JPH_WheelSettings_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Attachment point of wheel suspension in local space of the body
        public new unsafe JPH.Vec3 mPosition
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettings_GetMutable_mPosition(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettings_GetMutable_mPosition(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Where tire forces (suspension and traction) are applied, in local space of the body. A good default is the center of the wheel in its neutral pose. See mEnableSuspensionForcePoint.
        public new unsafe JPH.Vec3 mSuspensionForcePoint
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettings_GetMutable_mSuspensionForcePoint(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettings_GetMutable_mSuspensionForcePoint(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction of the suspension in local space of the body, should point down
        public new unsafe JPH.Vec3 mSuspensionDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mSuspensionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mSuspensionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettings_GetMutable_mSuspensionDirection(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettings_GetMutable_mSuspensionDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction of the steering axis in local space of the body, should point up (e.g. for a bike would be -mSuspensionDirection)
        public new unsafe JPH.Vec3 mSteeringAxis
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mSteeringAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mSteeringAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettings_GetMutable_mSteeringAxis(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettings_GetMutable_mSteeringAxis(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Up direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mUp but can be used to give the wheel camber or for a bike would be -mSuspensionDirection)
        public new unsafe JPH.Vec3 mWheelUp
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mWheelUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mWheelUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettings_GetMutable_mWheelUp(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettings_GetMutable_mWheelUp(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Forward direction when the wheel is in the neutral steering position (usually VehicleConstraintSettings::mForward but can be used to give the wheel toe, does not need to be perpendicular to mWheelUp)
        public new unsafe JPH.Vec3 mWheelForward
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mWheelForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mWheelForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettings_GetMutable_mWheelForward(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettings_GetMutable_mWheelForward(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< How long the suspension is in max raised position relative to the attachment point (m)
        public new unsafe ref float mSuspensionMinLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mSuspensionMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mSuspensionMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettings_GetMutable_mSuspensionMinLength(_Underlying *_this);
                return ref *__JPH_WheelSettings_GetMutable_mSuspensionMinLength(_UnderlyingPtr);
            }
        }

        ///< How long the suspension is in max droop position relative to the attachment point (m)
        public new unsafe ref float mSuspensionMaxLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mSuspensionMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mSuspensionMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettings_GetMutable_mSuspensionMaxLength(_Underlying *_this);
                return ref *__JPH_WheelSettings_GetMutable_mSuspensionMaxLength(_UnderlyingPtr);
            }
        }

        ///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
        public new unsafe ref float mSuspensionPreloadLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mSuspensionPreloadLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mSuspensionPreloadLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettings_GetMutable_mSuspensionPreloadLength(_Underlying *_this);
                return ref *__JPH_WheelSettings_GetMutable_mSuspensionPreloadLength(_UnderlyingPtr);
            }
        }

        ///< Settings for the suspension spring
        public new unsafe JPH.SpringSettings mSuspensionSpring
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mSuspensionSpring", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mSuspensionSpring", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SpringSettings._Underlying *__JPH_WheelSettings_GetMutable_mSuspensionSpring(_Underlying *_this);
                JPH.SpringSettings __ret;
                __ret = new(__JPH_WheelSettings_GetMutable_mSuspensionSpring(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Radius of the wheel (m)
        public new unsafe ref float mRadius
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettings_GetMutable_mRadius(_Underlying *_this);
                return ref *__JPH_WheelSettings_GetMutable_mRadius(_UnderlyingPtr);
            }
        }

        ///< Width of the wheel (m)
        public new unsafe ref float mWidth
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mWidth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mWidth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettings_GetMutable_mWidth(_Underlying *_this);
                return ref *__JPH_WheelSettings_GetMutable_mWidth(_UnderlyingPtr);
            }
        }

        ///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
        public new unsafe ref bool mEnableSuspensionForcePoint
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mEnableSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_GetMutable_mEnableSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_WheelSettings_GetMutable_mEnableSuspensionForcePoint(_Underlying *_this);
                return ref *__JPH_WheelSettings_GetMutable_mEnableSuspensionForcePoint(_UnderlyingPtr);
            }
        }

        internal unsafe WheelSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe WheelSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettings._Underlying *__JPH_WheelSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_WheelSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_AddRef(__JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::WheelSettings::WheelSettings`.
        public unsafe WheelSettings(JPH._ByValue_WheelSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettings._Underlying *__JPH_WheelSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.WheelSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_WheelSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_AddRef(__JPH_WheelSettings_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::WheelSettings::WheelSettings`.
        public WheelSettings(Const_WheelSettings _other) : this(new _ByValue_WheelSettings(_other)) {}

        /// Generated from constructor `JPH::WheelSettings::WheelSettings`.
        public WheelSettings(WheelSettings _other) : this((Const_WheelSettings)_other) {}

        /// Generated from method `JPH::WheelSettings::operator=`.
        public unsafe JPH.WheelSettings Assign(JPH._ByValue_WheelSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettings._Underlying *__JPH_WheelSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.WheelSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_WheelSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `WheelSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `WheelSettings`/`Const_WheelSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_WheelSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_WheelSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_WheelSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_WheelSettings(Const_WheelSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_WheelSettings(Const_WheelSettings arg) {return new(arg);}
        public _ByValue_WheelSettings(JPH._Moved<WheelSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_WheelSettings(JPH._Moved<WheelSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `WheelSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_WheelSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `WheelSettings`/`Const_WheelSettings` directly.
    public class _InOptMut_WheelSettings
    {
        public WheelSettings? Opt;

        public _InOptMut_WheelSettings() {}
        public _InOptMut_WheelSettings(WheelSettings value) {Opt = value;}
        public static implicit operator _InOptMut_WheelSettings(WheelSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `WheelSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_WheelSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `WheelSettings`/`Const_WheelSettings` to pass it to the function.
    public class _InOptConst_WheelSettings
    {
        public Const_WheelSettings? Opt;

        public _InOptConst_WheelSettings() {}
        public _InOptConst_WheelSettings(Const_WheelSettings value) {Opt = value;}
        public static implicit operator _InOptConst_WheelSettings(Const_WheelSettings value) {return new(value);}
    }

    /// Base class for runtime data for a wheel, each VehicleController can implement a derived class of this
    /// Generated from class `JPH::Wheel`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::WheelWV`
    /// This is the const half of the class.
    public class Const_Wheel : JPH.Object<Const_Wheel>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Wheel_Destroy(_Underlying *_this);
            __JPH_Wheel_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Wheel() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_Wheel self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_Wheel_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_Wheel_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_Wheel(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Wheel_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_Wheel ret = new(__JPH_Wheel_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_Wheel(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor / destructor
        /// Generated from constructor `JPH::Wheel::Wheel`.
        public unsafe Const_Wheel(JPH.Const_WheelSettings inSettings) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Wheel._Underlying *__JPH_Wheel_Construct(JPH.Const_WheelSettings._Underlying *inSettings);
            _UnderlyingPtr = __JPH_Wheel_Construct(inSettings._UnderlyingPtr);
        }

        /// Generated from method `JPH::Wheel::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Wheel_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Wheel_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Wheel_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_Wheel_size_t(inCount);
        }

        /// Generated from method `JPH::Wheel::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Wheel_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Wheel_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Wheel_void_ptr(void *inPointer);
            __Jolt_delete_JPH_Wheel_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Wheel::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Wheel_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Wheel_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Wheel_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_Wheel_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Wheel::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Wheel_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Wheel_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Wheel_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_Wheel_size_t(inCount);
        }

        /// Generated from method `JPH::Wheel::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Wheel_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Wheel_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Wheel_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_Wheel_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Wheel::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Wheel_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Wheel_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Wheel_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_Wheel_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Wheel::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Wheel_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Wheel_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Wheel_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_Wheel_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Wheel::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Wheel_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Wheel_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Wheel_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_Wheel_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::Wheel::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Wheel_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Wheel_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Wheel_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_Wheel_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Wheel::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Wheel_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Wheel_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Wheel_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_Wheel_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Get settings for the wheel
        /// Generated from method `JPH::Wheel::GetSettings`.
        public unsafe JPH.Const_WheelSettings? GetSettings()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_WheelSettings._Underlying *__JPH_Wheel_GetSettings(_Underlying *_this);
            var __c_ret = __JPH_Wheel_GetSettings(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_WheelSettings(__c_ret, is_owning: false) : null;
        }

        /// Get the angular velocity (rad/s) for this wheel, note that positive means the wheel is rotating such that the car moves forward
        /// Generated from method `JPH::Wheel::GetAngularVelocity`.
        public unsafe float GetAngularVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Wheel_GetAngularVelocity(_Underlying *_this);
            return __JPH_Wheel_GetAngularVelocity(_UnderlyingPtr);
        }

        /// Get the current rotation angle of the wheel in radians [0, 2 pi]
        /// Generated from method `JPH::Wheel::GetRotationAngle`.
        public unsafe float GetRotationAngle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetRotationAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetRotationAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Wheel_GetRotationAngle(_Underlying *_this);
            return __JPH_Wheel_GetRotationAngle(_UnderlyingPtr);
        }

        /// Get the current steer angle of the wheel in radians [-pi, pi], positive is to the left
        /// Generated from method `JPH::Wheel::GetSteerAngle`.
        public unsafe float GetSteerAngle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Wheel_GetSteerAngle(_Underlying *_this);
            return __JPH_Wheel_GetSteerAngle(_UnderlyingPtr);
        }

        /// Returns true if the wheel is touching an object
        /// Generated from method `JPH::Wheel::HasContact`.
        public unsafe bool HasContact()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_HasContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_HasContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Wheel_HasContact(_Underlying *_this);
            return __JPH_Wheel_HasContact(_UnderlyingPtr) != 0;
        }

        /// Returns the body ID of the body that this wheel is touching
        /// Generated from method `JPH::Wheel::GetContactBodyID`.
        public unsafe JPH.BodyID GetContactBodyID()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetContactBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetContactBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID __JPH_Wheel_GetContactBodyID(_Underlying *_this);
            return __JPH_Wheel_GetContactBodyID(_UnderlyingPtr);
        }

        /// Returns the sub shape ID where we're contacting the body
        /// Generated from method `JPH::Wheel::GetContactSubShapeID`.
        public unsafe JPH.SubShapeID GetContactSubShapeID()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetContactSubShapeID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetContactSubShapeID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SubShapeID._Underlying *__JPH_Wheel_GetContactSubShapeID(_Underlying *_this);
            return new(__JPH_Wheel_GetContactSubShapeID(_UnderlyingPtr), is_owning: true);
        }

        /// Returns the current contact position in world space (note by the time you call this the vehicle has moved)
        /// Generated from method `JPH::Wheel::GetContactPosition`.
        public unsafe JPH.Vec3 GetContactPosition()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetContactPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetContactPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Wheel_GetContactPosition(_Underlying *_this);
            return new(__JPH_Wheel_GetContactPosition(_UnderlyingPtr), is_owning: true);
        }

        /// Velocity of the contact point (m / s, not relative to the wheel but in world space)
        /// Generated from method `JPH::Wheel::GetContactPointVelocity`.
        public unsafe JPH.Vec3 GetContactPointVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetContactPointVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetContactPointVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Wheel_GetContactPointVelocity(_Underlying *_this);
            return new(__JPH_Wheel_GetContactPointVelocity(_UnderlyingPtr), is_owning: true);
        }

        /// Returns the current contact normal in world space (note by the time you call this the vehicle has moved)
        /// Generated from method `JPH::Wheel::GetContactNormal`.
        public unsafe JPH.Vec3 GetContactNormal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetContactNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetContactNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Wheel_GetContactNormal(_Underlying *_this);
            return new(__JPH_Wheel_GetContactNormal(_UnderlyingPtr), is_owning: true);
        }

        /// Returns longitudinal direction (direction along the wheel relative to floor) in world space (note by the time you call this the vehicle has moved)
        /// Generated from method `JPH::Wheel::GetContactLongitudinal`.
        public unsafe JPH.Vec3 GetContactLongitudinal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetContactLongitudinal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetContactLongitudinal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Wheel_GetContactLongitudinal(_Underlying *_this);
            return new(__JPH_Wheel_GetContactLongitudinal(_UnderlyingPtr), is_owning: true);
        }

        /// Returns lateral direction (sideways direction) in world space (note by the time you call this the vehicle has moved)
        /// Generated from method `JPH::Wheel::GetContactLateral`.
        public unsafe JPH.Vec3 GetContactLateral()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetContactLateral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetContactLateral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Wheel_GetContactLateral(_Underlying *_this);
            return new(__JPH_Wheel_GetContactLateral(_UnderlyingPtr), is_owning: true);
        }

        /// Get the length of the suspension for a wheel (m) relative to the suspension attachment point (hard point)
        /// Generated from method `JPH::Wheel::GetSuspensionLength`.
        public unsafe float GetSuspensionLength()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetSuspensionLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetSuspensionLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Wheel_GetSuspensionLength(_Underlying *_this);
            return __JPH_Wheel_GetSuspensionLength(_UnderlyingPtr);
        }

        /// Check if the suspension hit its upper limit
        /// Generated from method `JPH::Wheel::HasHitHardPoint`.
        public unsafe bool HasHitHardPoint()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_HasHitHardPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_HasHitHardPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Wheel_HasHitHardPoint(_Underlying *_this);
            return __JPH_Wheel_HasHitHardPoint(_UnderlyingPtr) != 0;
        }

        /// Get the total impulse (N s) that was applied by the suspension
        /// Generated from method `JPH::Wheel::GetSuspensionLambda`.
        public unsafe float GetSuspensionLambda()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetSuspensionLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetSuspensionLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Wheel_GetSuspensionLambda(_Underlying *_this);
            return __JPH_Wheel_GetSuspensionLambda(_UnderlyingPtr);
        }

        /// Get total impulse (N s) applied along the forward direction of the wheel
        /// Generated from method `JPH::Wheel::GetLongitudinalLambda`.
        public unsafe float GetLongitudinalLambda()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetLongitudinalLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetLongitudinalLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Wheel_GetLongitudinalLambda(_Underlying *_this);
            return __JPH_Wheel_GetLongitudinalLambda(_UnderlyingPtr);
        }

        /// Get total impulse (N s) applied along the sideways direction of the wheel
        /// Generated from method `JPH::Wheel::GetLateralLambda`.
        public unsafe float GetLateralLambda()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_GetLateralLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_GetLateralLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Wheel_GetLateralLambda(_Underlying *_this);
            return __JPH_Wheel_GetLateralLambda(_UnderlyingPtr);
        }
    }

    /// Base class for runtime data for a wheel, each VehicleController can implement a derived class of this
    /// Generated from class `JPH::Wheel`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::WheelWV`
    /// This is the non-const half of the class.
    public class Wheel : Const_Wheel
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(Wheel self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_Wheel_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_Wheel_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Wheel(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Wheel_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            Wheel ret = new(__JPH_Wheel_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Wheel(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor / destructor
        /// Generated from constructor `JPH::Wheel::Wheel`.
        public unsafe Wheel(JPH.Const_WheelSettings inSettings) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Wheel._Underlying *__JPH_Wheel_Construct(JPH.Const_WheelSettings._Underlying *inSettings);
            _UnderlyingPtr = __JPH_Wheel_Construct(inSettings._UnderlyingPtr);
        }

        /// Update the angular velocity (rad/s)
        /// Generated from method `JPH::Wheel::SetAngularVelocity`.
        public unsafe void SetAngularVelocity(float inVel)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Wheel_SetAngularVelocity(_Underlying *_this, float inVel);
            __JPH_Wheel_SetAngularVelocity(_UnderlyingPtr, inVel);
        }

        /// Set the current rotation angle of the wheel in radians [0, 2 pi]
        /// Generated from method `JPH::Wheel::SetRotationAngle`.
        public unsafe void SetRotationAngle(float inAngle)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_SetRotationAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_SetRotationAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Wheel_SetRotationAngle(_Underlying *_this, float inAngle);
            __JPH_Wheel_SetRotationAngle(_UnderlyingPtr, inAngle);
        }

        /// Set the current steer angle of the wheel in radians [-pi, pi]
        /// Generated from method `JPH::Wheel::SetSteerAngle`.
        public unsafe void SetSteerAngle(float inAngle)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_SetSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_SetSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Wheel_SetSteerAngle(_Underlying *_this, float inAngle);
            __JPH_Wheel_SetSteerAngle(_UnderlyingPtr, inAngle);
        }

        /// Internal function that should only be called by the controller. Used to apply impulses in the forward direction of the vehicle.
        /// Generated from method `JPH::Wheel::SolveLongitudinalConstraintPart`.
        public unsafe bool SolveLongitudinalConstraintPart(JPH.Const_VehicleConstraint inConstraint, float inMinImpulse, float inMaxImpulse)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_SolveLongitudinalConstraintPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_SolveLongitudinalConstraintPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Wheel_SolveLongitudinalConstraintPart(_Underlying *_this, JPH.Const_VehicleConstraint._Underlying *inConstraint, float inMinImpulse, float inMaxImpulse);
            return __JPH_Wheel_SolveLongitudinalConstraintPart(_UnderlyingPtr, inConstraint._UnderlyingPtr, inMinImpulse, inMaxImpulse) != 0;
        }

        /// Internal function that should only be called by the controller. Used to apply impulses in the sideways direction of the vehicle.
        /// Generated from method `JPH::Wheel::SolveLateralConstraintPart`.
        public unsafe bool SolveLateralConstraintPart(JPH.Const_VehicleConstraint inConstraint, float inMinImpulse, float inMaxImpulse)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Wheel_SolveLateralConstraintPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Wheel_SolveLateralConstraintPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Wheel_SolveLateralConstraintPart(_Underlying *_this, JPH.Const_VehicleConstraint._Underlying *inConstraint, float inMinImpulse, float inMaxImpulse);
            return __JPH_Wheel_SolveLateralConstraintPart(_UnderlyingPtr, inConstraint._UnderlyingPtr, inMinImpulse, inMaxImpulse) != 0;
        }
    }

    /// This is used for optional parameters of class `Wheel` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Wheel`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Wheel`/`Const_Wheel` directly.
    public class _InOptMut_Wheel
    {
        public Wheel? Opt;

        public _InOptMut_Wheel() {}
        public _InOptMut_Wheel(Wheel value) {Opt = value;}
        public static implicit operator _InOptMut_Wheel(Wheel value) {return new(value);}
    }

    /// This is used for optional parameters of class `Wheel` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Wheel`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Wheel`/`Const_Wheel` to pass it to the function.
    public class _InOptConst_Wheel
    {
        public Const_Wheel? Opt;

        public _InOptConst_Wheel() {}
        public _InOptConst_Wheel(Const_Wheel value) {Opt = value;}
        public static implicit operator _InOptConst_Wheel(Const_Wheel value) {return new(value);}
    }
}
