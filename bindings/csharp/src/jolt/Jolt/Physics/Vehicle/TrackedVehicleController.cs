// machine generated, do not edit
public static partial class JPH
{
    /// WheelSettings object specifically for TrackedVehicleController
    /// Generated from class `JPH::WheelSettingsTV`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::WheelSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::WheelSettings>`
    /// This is the const half of the class.
    public class Const_WheelSettingsTV : JPH.Object<Const_WheelSettingsTV>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_Release(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_Release(__JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_WheelSettingsTV() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_WheelSettingsTV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_WheelSettingsTV_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_WheelSettingsTV_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHWheelSettings(Const_WheelSettingsTV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHWheelSettings._Underlying *__JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHWheelSettings ret = new(__JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_WheelSettings(Const_WheelSettingsTV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_WheelSettings._Underlying *__JPH_WheelSettingsTV_UpcastTo_JPH_WheelSettings(_Underlying *_this);
            JPH.Const_WheelSettings ret = new(__JPH_WheelSettingsTV_UpcastTo_JPH_WheelSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_WheelSettingsTV(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettingsTV_StaticDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            Const_WheelSettingsTV ret = new(__JPH_WheelSettingsTV_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_WheelSettingsTV(JPH.Const_RefTarget_JPHWheelSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettingsTV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(JPH.Const_RefTarget_JPHWheelSettings._Underlying *_this);
            Const_WheelSettingsTV ret = new(__JPH_WheelSettingsTV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_WheelSettingsTV(JPH.Const_WheelSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_StaticDowncastFrom_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_StaticDowncastFrom_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettingsTV_StaticDowncastFrom_JPH_WheelSettings(JPH.Const_WheelSettings._Underlying *_this);
            Const_WheelSettingsTV ret = new(__JPH_WheelSettingsTV_StaticDowncastFrom_JPH_WheelSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Friction in forward direction of tire
        public unsafe float mLongitudinalFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mLongitudinalFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mLongitudinalFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsTV_Get_mLongitudinalFriction(_Underlying *_this);
                return *__JPH_WheelSettingsTV_Get_mLongitudinalFriction(_UnderlyingPtr);
            }
        }

        ///< Friction in sideways direction of tire
        public unsafe float mLateralFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mLateralFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mLateralFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsTV_Get_mLateralFriction(_Underlying *_this);
                return *__JPH_WheelSettingsTV_Get_mLateralFriction(_UnderlyingPtr);
            }
        }

        ///< Attachment point of wheel suspension in local space of the body
        public unsafe JPH.Const_Vec3 mPosition
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettingsTV_Get_mPosition(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettingsTV_Get_mPosition(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettingsTV_Get_mSuspensionForcePoint(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettingsTV_Get_mSuspensionForcePoint(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mSuspensionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mSuspensionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettingsTV_Get_mSuspensionDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettingsTV_Get_mSuspensionDirection(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mSteeringAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mSteeringAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettingsTV_Get_mSteeringAxis(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettingsTV_Get_mSteeringAxis(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mWheelUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mWheelUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettingsTV_Get_mWheelUp(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettingsTV_Get_mWheelUp(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mWheelForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mWheelForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettingsTV_Get_mWheelForward(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettingsTV_Get_mWheelForward(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mSuspensionMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mSuspensionMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsTV_Get_mSuspensionMinLength(_Underlying *_this);
                return *__JPH_WheelSettingsTV_Get_mSuspensionMinLength(_UnderlyingPtr);
            }
        }

        ///< How long the suspension is in max droop position relative to the attachment point (m)
        public unsafe float mSuspensionMaxLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mSuspensionMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mSuspensionMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsTV_Get_mSuspensionMaxLength(_Underlying *_this);
                return *__JPH_WheelSettingsTV_Get_mSuspensionMaxLength(_UnderlyingPtr);
            }
        }

        ///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
        public unsafe float mSuspensionPreloadLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mSuspensionPreloadLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mSuspensionPreloadLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsTV_Get_mSuspensionPreloadLength(_Underlying *_this);
                return *__JPH_WheelSettingsTV_Get_mSuspensionPreloadLength(_UnderlyingPtr);
            }
        }

        ///< Settings for the suspension spring
        public unsafe JPH.Const_SpringSettings mSuspensionSpring
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mSuspensionSpring", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mSuspensionSpring", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_SpringSettings._Underlying *__JPH_WheelSettingsTV_Get_mSuspensionSpring(_Underlying *_this);
                JPH.Const_SpringSettings __ret;
                __ret = new(__JPH_WheelSettingsTV_Get_mSuspensionSpring(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsTV_Get_mRadius(_Underlying *_this);
                return *__JPH_WheelSettingsTV_Get_mRadius(_UnderlyingPtr);
            }
        }

        ///< Width of the wheel (m)
        public unsafe float mWidth
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mWidth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mWidth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsTV_Get_mWidth(_Underlying *_this);
                return *__JPH_WheelSettingsTV_Get_mWidth(_UnderlyingPtr);
            }
        }

        ///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
        public unsafe bool mEnableSuspensionForcePoint
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mEnableSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Get_mEnableSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_WheelSettingsTV_Get_mEnableSuspensionForcePoint(_Underlying *_this);
                return *__JPH_WheelSettingsTV_Get_mEnableSuspensionForcePoint(_UnderlyingPtr);
            }
        }

        internal unsafe Const_WheelSettingsTV(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_WheelSettingsTV() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettingsTV._Underlying *__JPH_WheelSettingsTV_DefaultConstruct();
            _UnderlyingPtr = __JPH_WheelSettingsTV_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_AddRef(__JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::WheelSettingsTV::WheelSettingsTV`.
        public unsafe Const_WheelSettingsTV(JPH._ByValue_WheelSettingsTV _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettingsTV._Underlying *__JPH_WheelSettingsTV_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.WheelSettingsTV._Underlying *_other);
            _UnderlyingPtr = __JPH_WheelSettingsTV_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_AddRef(__JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::WheelSettingsTV::WheelSettingsTV`.
        public Const_WheelSettingsTV(Const_WheelSettingsTV _other) : this(new _ByValue_WheelSettingsTV(_other)) {}

        /// Generated from constructor `JPH::WheelSettingsTV::WheelSettingsTV`.
        public Const_WheelSettingsTV(WheelSettingsTV _other) : this((Const_WheelSettingsTV)_other) {}

        /// Generated from method `JPH::WheelSettingsTV::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_WheelSettingsTV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_WheelSettingsTV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_WheelSettingsTV_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_WheelSettingsTV_size_t(inCount);
        }

        /// Generated from method `JPH::WheelSettingsTV::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettingsTV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettingsTV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelSettingsTV_void_ptr(void *inPointer);
            __Jolt_delete_JPH_WheelSettingsTV_void_ptr(inPointer);
        }

        /// Generated from method `JPH::WheelSettingsTV::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettingsTV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettingsTV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelSettingsTV_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_WheelSettingsTV_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::WheelSettingsTV::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_WheelSettingsTV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_WheelSettingsTV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_WheelSettingsTV_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_WheelSettingsTV_size_t(inCount);
        }

        /// Generated from method `JPH::WheelSettingsTV::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettingsTV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettingsTV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelSettingsTV_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_WheelSettingsTV_void_ptr(inPointer);
        }

        /// Generated from method `JPH::WheelSettingsTV::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettingsTV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettingsTV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelSettingsTV_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_WheelSettingsTV_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::WheelSettingsTV::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_WheelSettingsTV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_WheelSettingsTV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_WheelSettingsTV_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_WheelSettingsTV_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::WheelSettingsTV::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettingsTV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettingsTV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelSettingsTV_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_WheelSettingsTV_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::WheelSettingsTV::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_WheelSettingsTV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_WheelSettingsTV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_WheelSettingsTV_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_WheelSettingsTV_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::WheelSettingsTV::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettingsTV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettingsTV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelSettingsTV_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_WheelSettingsTV_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::WheelSettingsTV::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelSettingsTV_SetEmbedded(_Underlying *_this);
            __JPH_WheelSettingsTV_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::WheelSettingsTV::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_WheelSettingsTV_GetRefCount(_Underlying *_this);
            return __JPH_WheelSettingsTV_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::WheelSettingsTV::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelSettingsTV_AddRef(_Underlying *_this);
            __JPH_WheelSettingsTV_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::WheelSettingsTV::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelSettingsTV_Release(_Underlying *_this);
            __JPH_WheelSettingsTV_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::WheelSettingsTV::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_WheelSettingsTV_sInternalGetRefCountOffset();
            return __JPH_WheelSettingsTV_sInternalGetRefCountOffset();
        }
    }

    /// WheelSettings object specifically for TrackedVehicleController
    /// Generated from class `JPH::WheelSettingsTV`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::WheelSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::WheelSettings>`
    /// This is the non-const half of the class.
    public class WheelSettingsTV : Const_WheelSettingsTV
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(WheelSettingsTV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_WheelSettingsTV_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_WheelSettingsTV_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_SerializableObject(WheelSettingsTV self)
            => (JPH.Const_SerializableObject)(JPH.Const_WheelSettingsTV)self;
        public static unsafe implicit operator JPH.RefTarget_JPHWheelSettings(WheelSettingsTV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHWheelSettings._Underlying *__JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            JPH.RefTarget_JPHWheelSettings ret = new(__JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHWheelSettings(WheelSettingsTV self)
            => (JPH.Const_RefTarget_JPHWheelSettings)(JPH.Const_WheelSettingsTV)self;
        public static unsafe implicit operator JPH.WheelSettings(WheelSettingsTV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettings._Underlying *__JPH_WheelSettingsTV_UpcastTo_JPH_WheelSettings(_Underlying *_this);
            JPH.WheelSettings ret = new(__JPH_WheelSettingsTV_UpcastTo_JPH_WheelSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_WheelSettings(WheelSettingsTV self)
            => (JPH.Const_WheelSettings)(JPH.Const_WheelSettingsTV)self;

        // Downcasts:
        public static unsafe explicit operator WheelSettingsTV(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettingsTV_StaticDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            WheelSettingsTV ret = new(__JPH_WheelSettingsTV_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator WheelSettingsTV(JPH.RefTarget_JPHWheelSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettingsTV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(JPH.RefTarget_JPHWheelSettings._Underlying *_this);
            WheelSettingsTV ret = new(__JPH_WheelSettingsTV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator WheelSettingsTV(JPH.WheelSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_StaticDowncastFrom_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_StaticDowncastFrom_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettingsTV_StaticDowncastFrom_JPH_WheelSettings(JPH.WheelSettings._Underlying *_this);
            WheelSettingsTV ret = new(__JPH_WheelSettingsTV_StaticDowncastFrom_JPH_WheelSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Friction in forward direction of tire
        public new unsafe ref float mLongitudinalFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mLongitudinalFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mLongitudinalFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsTV_GetMutable_mLongitudinalFriction(_Underlying *_this);
                return ref *__JPH_WheelSettingsTV_GetMutable_mLongitudinalFriction(_UnderlyingPtr);
            }
        }

        ///< Friction in sideways direction of tire
        public new unsafe ref float mLateralFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mLateralFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mLateralFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsTV_GetMutable_mLateralFriction(_Underlying *_this);
                return ref *__JPH_WheelSettingsTV_GetMutable_mLateralFriction(_UnderlyingPtr);
            }
        }

        ///< Attachment point of wheel suspension in local space of the body
        public new unsafe JPH.Vec3 mPosition
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettingsTV_GetMutable_mPosition(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettingsTV_GetMutable_mPosition(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettingsTV_GetMutable_mSuspensionForcePoint(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettingsTV_GetMutable_mSuspensionForcePoint(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mSuspensionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mSuspensionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettingsTV_GetMutable_mSuspensionDirection(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettingsTV_GetMutable_mSuspensionDirection(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mSteeringAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mSteeringAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettingsTV_GetMutable_mSteeringAxis(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettingsTV_GetMutable_mSteeringAxis(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mWheelUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mWheelUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettingsTV_GetMutable_mWheelUp(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettingsTV_GetMutable_mWheelUp(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mWheelForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mWheelForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettingsTV_GetMutable_mWheelForward(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettingsTV_GetMutable_mWheelForward(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mSuspensionMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mSuspensionMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsTV_GetMutable_mSuspensionMinLength(_Underlying *_this);
                return ref *__JPH_WheelSettingsTV_GetMutable_mSuspensionMinLength(_UnderlyingPtr);
            }
        }

        ///< How long the suspension is in max droop position relative to the attachment point (m)
        public new unsafe ref float mSuspensionMaxLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mSuspensionMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mSuspensionMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsTV_GetMutable_mSuspensionMaxLength(_Underlying *_this);
                return ref *__JPH_WheelSettingsTV_GetMutable_mSuspensionMaxLength(_UnderlyingPtr);
            }
        }

        ///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
        public new unsafe ref float mSuspensionPreloadLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mSuspensionPreloadLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mSuspensionPreloadLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsTV_GetMutable_mSuspensionPreloadLength(_Underlying *_this);
                return ref *__JPH_WheelSettingsTV_GetMutable_mSuspensionPreloadLength(_UnderlyingPtr);
            }
        }

        ///< Settings for the suspension spring
        public new unsafe JPH.SpringSettings mSuspensionSpring
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mSuspensionSpring", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mSuspensionSpring", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SpringSettings._Underlying *__JPH_WheelSettingsTV_GetMutable_mSuspensionSpring(_Underlying *_this);
                JPH.SpringSettings __ret;
                __ret = new(__JPH_WheelSettingsTV_GetMutable_mSuspensionSpring(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsTV_GetMutable_mRadius(_Underlying *_this);
                return ref *__JPH_WheelSettingsTV_GetMutable_mRadius(_UnderlyingPtr);
            }
        }

        ///< Width of the wheel (m)
        public new unsafe ref float mWidth
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mWidth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mWidth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsTV_GetMutable_mWidth(_Underlying *_this);
                return ref *__JPH_WheelSettingsTV_GetMutable_mWidth(_UnderlyingPtr);
            }
        }

        ///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
        public new unsafe ref bool mEnableSuspensionForcePoint
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mEnableSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_GetMutable_mEnableSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_WheelSettingsTV_GetMutable_mEnableSuspensionForcePoint(_Underlying *_this);
                return ref *__JPH_WheelSettingsTV_GetMutable_mEnableSuspensionForcePoint(_UnderlyingPtr);
            }
        }

        internal unsafe WheelSettingsTV(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe WheelSettingsTV() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettingsTV._Underlying *__JPH_WheelSettingsTV_DefaultConstruct();
            _UnderlyingPtr = __JPH_WheelSettingsTV_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_AddRef(__JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::WheelSettingsTV::WheelSettingsTV`.
        public unsafe WheelSettingsTV(JPH._ByValue_WheelSettingsTV _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettingsTV._Underlying *__JPH_WheelSettingsTV_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.WheelSettingsTV._Underlying *_other);
            _UnderlyingPtr = __JPH_WheelSettingsTV_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_AddRef(__JPH_WheelSettingsTV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::WheelSettingsTV::WheelSettingsTV`.
        public WheelSettingsTV(Const_WheelSettingsTV _other) : this(new _ByValue_WheelSettingsTV(_other)) {}

        /// Generated from constructor `JPH::WheelSettingsTV::WheelSettingsTV`.
        public WheelSettingsTV(WheelSettingsTV _other) : this((Const_WheelSettingsTV)_other) {}

        /// Generated from method `JPH::WheelSettingsTV::operator=`.
        public unsafe JPH.WheelSettingsTV Assign(JPH._ByValue_WheelSettingsTV _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsTV_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsTV_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettingsTV._Underlying *__JPH_WheelSettingsTV_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.WheelSettingsTV._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_WheelSettingsTV_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `WheelSettingsTV` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `WheelSettingsTV`/`Const_WheelSettingsTV` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_WheelSettingsTV
    {
        #pragma warning disable CS0649
        internal readonly Const_WheelSettingsTV? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_WheelSettingsTV() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_WheelSettingsTV(Const_WheelSettingsTV new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_WheelSettingsTV(Const_WheelSettingsTV arg) {return new(arg);}
        public _ByValue_WheelSettingsTV(JPH._Moved<WheelSettingsTV> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_WheelSettingsTV(JPH._Moved<WheelSettingsTV> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `WheelSettingsTV` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_WheelSettingsTV`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `WheelSettingsTV`/`Const_WheelSettingsTV` directly.
    public class _InOptMut_WheelSettingsTV
    {
        public WheelSettingsTV? Opt;

        public _InOptMut_WheelSettingsTV() {}
        public _InOptMut_WheelSettingsTV(WheelSettingsTV value) {Opt = value;}
        public static implicit operator _InOptMut_WheelSettingsTV(WheelSettingsTV value) {return new(value);}
    }

    /// This is used for optional parameters of class `WheelSettingsTV` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_WheelSettingsTV`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `WheelSettingsTV`/`Const_WheelSettingsTV` to pass it to the function.
    public class _InOptConst_WheelSettingsTV
    {
        public Const_WheelSettingsTV? Opt;

        public _InOptConst_WheelSettingsTV() {}
        public _InOptConst_WheelSettingsTV(Const_WheelSettingsTV value) {Opt = value;}
        public static implicit operator _InOptConst_WheelSettingsTV(Const_WheelSettingsTV value) {return new(value);}
    }

    /// Wheel object specifically for TrackedVehicleController
    /// Generated from class `JPH::WheelTV`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Wheel`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_WheelTV : JPH.Object<Const_WheelTV>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelTV_Destroy(_Underlying *_this);
            __JPH_WheelTV_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_WheelTV() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_WheelTV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_WheelTV_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_WheelTV_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Wheel(Const_WheelTV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_UpcastTo_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_UpcastTo_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Wheel._Underlying *__JPH_WheelTV_UpcastTo_JPH_Wheel(_Underlying *_this);
            JPH.Const_Wheel ret = new(__JPH_WheelTV_UpcastTo_JPH_Wheel(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_WheelTV(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelTV_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_WheelTV ret = new(__JPH_WheelTV_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_WheelTV(JPH.Const_Wheel parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_StaticDowncastFrom_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_StaticDowncastFrom_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelTV_StaticDowncastFrom_JPH_Wheel(JPH.Const_Wheel._Underlying *_this);
            Const_WheelTV ret = new(__JPH_WheelTV_StaticDowncastFrom_JPH_Wheel(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Index in mTracks to which this wheel is attached (calculated on initialization)
        public unsafe int mTrackIndex
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_Get_mTrackIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_Get_mTrackIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_WheelTV_Get_mTrackIndex(_Underlying *_this);
                return *__JPH_WheelTV_Get_mTrackIndex(_UnderlyingPtr);
            }
        }

        ///< Combined friction coefficient in longitudinal direction (combines terrain and track)
        public unsafe float mCombinedLongitudinalFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_Get_mCombinedLongitudinalFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_Get_mCombinedLongitudinalFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelTV_Get_mCombinedLongitudinalFriction(_Underlying *_this);
                return *__JPH_WheelTV_Get_mCombinedLongitudinalFriction(_UnderlyingPtr);
            }
        }

        ///< Combined friction coefficient in lateral direction (combines terrain and track)
        public unsafe float mCombinedLateralFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_Get_mCombinedLateralFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_Get_mCombinedLateralFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelTV_Get_mCombinedLateralFriction(_Underlying *_this);
                return *__JPH_WheelTV_Get_mCombinedLateralFriction(_UnderlyingPtr);
            }
        }

        ///< Amount of impulse that the brakes can apply to the floor (excluding friction), spread out from brake impulse applied on track
        public unsafe float mBrakeImpulse
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_Get_mBrakeImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_Get_mBrakeImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelTV_Get_mBrakeImpulse(_Underlying *_this);
                return *__JPH_WheelTV_Get_mBrakeImpulse(_UnderlyingPtr);
            }
        }

        internal unsafe Const_WheelTV(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// Generated from constructor `JPH::WheelTV::WheelTV`.
        public unsafe Const_WheelTV(JPH.Const_WheelSettingsTV inWheel) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelTV._Underlying *__JPH_WheelTV_Construct(JPH.Const_WheelSettingsTV._Underlying *inWheel);
            _UnderlyingPtr = __JPH_WheelTV_Construct(inWheel._UnderlyingPtr);
        }

        /// Generated from method `JPH::WheelTV::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_WheelTV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_WheelTV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_WheelTV_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_WheelTV_size_t(inCount);
        }

        /// Generated from method `JPH::WheelTV::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelTV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelTV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelTV_void_ptr(void *inPointer);
            __Jolt_delete_JPH_WheelTV_void_ptr(inPointer);
        }

        /// Generated from method `JPH::WheelTV::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelTV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelTV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelTV_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_WheelTV_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::WheelTV::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_WheelTV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_WheelTV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_WheelTV_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_WheelTV_size_t(inCount);
        }

        /// Generated from method `JPH::WheelTV::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelTV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelTV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelTV_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_WheelTV_void_ptr(inPointer);
        }

        /// Generated from method `JPH::WheelTV::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelTV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelTV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelTV_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_WheelTV_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::WheelTV::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_WheelTV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_WheelTV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_WheelTV_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_WheelTV_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::WheelTV::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelTV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelTV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelTV_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_WheelTV_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::WheelTV::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_WheelTV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_WheelTV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_WheelTV_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_WheelTV_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::WheelTV::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelTV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelTV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelTV_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_WheelTV_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Override GetSettings and cast to the correct class
        /// Generated from method `JPH::WheelTV::GetSettings`.
        public unsafe JPH.Const_WheelSettingsTV? GetSettings()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_WheelSettingsTV._Underlying *__JPH_WheelTV_GetSettings(_Underlying *_this);
            var __c_ret = __JPH_WheelTV_GetSettings(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_WheelSettingsTV(__c_ret, is_owning: false) : null;
        }

        /// Get the angular velocity (rad/s) for this wheel, note that positive means the wheel is rotating such that the car moves forward
        /// Generated from method `JPH::WheelTV::GetAngularVelocity`.
        public unsafe float GetAngularVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheelTV_GetAngularVelocity(_Underlying *_this);
            return __JPH_WheelTV_GetAngularVelocity(_UnderlyingPtr);
        }

        /// Get the current rotation angle of the wheel in radians [0, 2 pi]
        /// Generated from method `JPH::WheelTV::GetRotationAngle`.
        public unsafe float GetRotationAngle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetRotationAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetRotationAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheelTV_GetRotationAngle(_Underlying *_this);
            return __JPH_WheelTV_GetRotationAngle(_UnderlyingPtr);
        }

        /// Get the current steer angle of the wheel in radians [-pi, pi], positive is to the left
        /// Generated from method `JPH::WheelTV::GetSteerAngle`.
        public unsafe float GetSteerAngle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheelTV_GetSteerAngle(_Underlying *_this);
            return __JPH_WheelTV_GetSteerAngle(_UnderlyingPtr);
        }

        /// Returns true if the wheel is touching an object
        /// Generated from method `JPH::WheelTV::HasContact`.
        public unsafe bool HasContact()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_HasContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_HasContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_WheelTV_HasContact(_Underlying *_this);
            return __JPH_WheelTV_HasContact(_UnderlyingPtr) != 0;
        }

        /// Returns the body ID of the body that this wheel is touching
        /// Generated from method `JPH::WheelTV::GetContactBodyID`.
        public unsafe JPH.BodyID GetContactBodyID()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetContactBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetContactBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID __JPH_WheelTV_GetContactBodyID(_Underlying *_this);
            return __JPH_WheelTV_GetContactBodyID(_UnderlyingPtr);
        }

        /// Returns the sub shape ID where we're contacting the body
        /// Generated from method `JPH::WheelTV::GetContactSubShapeID`.
        public unsafe JPH.SubShapeID GetContactSubShapeID()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetContactSubShapeID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetContactSubShapeID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SubShapeID._Underlying *__JPH_WheelTV_GetContactSubShapeID(_Underlying *_this);
            return new(__JPH_WheelTV_GetContactSubShapeID(_UnderlyingPtr), is_owning: true);
        }

        /// Returns the current contact position in world space (note by the time you call this the vehicle has moved)
        /// Generated from method `JPH::WheelTV::GetContactPosition`.
        public unsafe JPH.Vec3 GetContactPosition()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetContactPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetContactPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_WheelTV_GetContactPosition(_Underlying *_this);
            return new(__JPH_WheelTV_GetContactPosition(_UnderlyingPtr), is_owning: true);
        }

        /// Velocity of the contact point (m / s, not relative to the wheel but in world space)
        /// Generated from method `JPH::WheelTV::GetContactPointVelocity`.
        public unsafe JPH.Vec3 GetContactPointVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetContactPointVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetContactPointVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_WheelTV_GetContactPointVelocity(_Underlying *_this);
            return new(__JPH_WheelTV_GetContactPointVelocity(_UnderlyingPtr), is_owning: true);
        }

        /// Returns the current contact normal in world space (note by the time you call this the vehicle has moved)
        /// Generated from method `JPH::WheelTV::GetContactNormal`.
        public unsafe JPH.Vec3 GetContactNormal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetContactNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetContactNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_WheelTV_GetContactNormal(_Underlying *_this);
            return new(__JPH_WheelTV_GetContactNormal(_UnderlyingPtr), is_owning: true);
        }

        /// Returns longitudinal direction (direction along the wheel relative to floor) in world space (note by the time you call this the vehicle has moved)
        /// Generated from method `JPH::WheelTV::GetContactLongitudinal`.
        public unsafe JPH.Vec3 GetContactLongitudinal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetContactLongitudinal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetContactLongitudinal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_WheelTV_GetContactLongitudinal(_Underlying *_this);
            return new(__JPH_WheelTV_GetContactLongitudinal(_UnderlyingPtr), is_owning: true);
        }

        /// Returns lateral direction (sideways direction) in world space (note by the time you call this the vehicle has moved)
        /// Generated from method `JPH::WheelTV::GetContactLateral`.
        public unsafe JPH.Vec3 GetContactLateral()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetContactLateral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetContactLateral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_WheelTV_GetContactLateral(_Underlying *_this);
            return new(__JPH_WheelTV_GetContactLateral(_UnderlyingPtr), is_owning: true);
        }

        /// Get the length of the suspension for a wheel (m) relative to the suspension attachment point (hard point)
        /// Generated from method `JPH::WheelTV::GetSuspensionLength`.
        public unsafe float GetSuspensionLength()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetSuspensionLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetSuspensionLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheelTV_GetSuspensionLength(_Underlying *_this);
            return __JPH_WheelTV_GetSuspensionLength(_UnderlyingPtr);
        }

        /// Check if the suspension hit its upper limit
        /// Generated from method `JPH::WheelTV::HasHitHardPoint`.
        public unsafe bool HasHitHardPoint()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_HasHitHardPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_HasHitHardPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_WheelTV_HasHitHardPoint(_Underlying *_this);
            return __JPH_WheelTV_HasHitHardPoint(_UnderlyingPtr) != 0;
        }

        /// Get the total impulse (N s) that was applied by the suspension
        /// Generated from method `JPH::WheelTV::GetSuspensionLambda`.
        public unsafe float GetSuspensionLambda()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetSuspensionLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetSuspensionLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheelTV_GetSuspensionLambda(_Underlying *_this);
            return __JPH_WheelTV_GetSuspensionLambda(_UnderlyingPtr);
        }

        /// Get total impulse (N s) applied along the forward direction of the wheel
        /// Generated from method `JPH::WheelTV::GetLongitudinalLambda`.
        public unsafe float GetLongitudinalLambda()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetLongitudinalLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetLongitudinalLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheelTV_GetLongitudinalLambda(_Underlying *_this);
            return __JPH_WheelTV_GetLongitudinalLambda(_UnderlyingPtr);
        }

        /// Get total impulse (N s) applied along the sideways direction of the wheel
        /// Generated from method `JPH::WheelTV::GetLateralLambda`.
        public unsafe float GetLateralLambda()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetLateralLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetLateralLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheelTV_GetLateralLambda(_Underlying *_this);
            return __JPH_WheelTV_GetLateralLambda(_UnderlyingPtr);
        }
    }

    /// Wheel object specifically for TrackedVehicleController
    /// Generated from class `JPH::WheelTV`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Wheel`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class WheelTV : Const_WheelTV
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(WheelTV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_WheelTV_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_WheelTV_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(WheelTV self)
            => (JPH.Const_NonCopyable)(JPH.Const_WheelTV)self;
        public static unsafe implicit operator JPH.Wheel(WheelTV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_UpcastTo_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_UpcastTo_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Wheel._Underlying *__JPH_WheelTV_UpcastTo_JPH_Wheel(_Underlying *_this);
            JPH.Wheel ret = new(__JPH_WheelTV_UpcastTo_JPH_Wheel(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Wheel(WheelTV self)
            => (JPH.Const_Wheel)(JPH.Const_WheelTV)self;

        // Downcasts:
        public static unsafe explicit operator WheelTV(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelTV_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            WheelTV ret = new(__JPH_WheelTV_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator WheelTV(JPH.Wheel parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_StaticDowncastFrom_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_StaticDowncastFrom_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelTV_StaticDowncastFrom_JPH_Wheel(JPH.Wheel._Underlying *_this);
            WheelTV ret = new(__JPH_WheelTV_StaticDowncastFrom_JPH_Wheel(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Index in mTracks to which this wheel is attached (calculated on initialization)
        public new unsafe ref int mTrackIndex
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetMutable_mTrackIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetMutable_mTrackIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_WheelTV_GetMutable_mTrackIndex(_Underlying *_this);
                return ref *__JPH_WheelTV_GetMutable_mTrackIndex(_UnderlyingPtr);
            }
        }

        ///< Combined friction coefficient in longitudinal direction (combines terrain and track)
        public new unsafe ref float mCombinedLongitudinalFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetMutable_mCombinedLongitudinalFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetMutable_mCombinedLongitudinalFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelTV_GetMutable_mCombinedLongitudinalFriction(_Underlying *_this);
                return ref *__JPH_WheelTV_GetMutable_mCombinedLongitudinalFriction(_UnderlyingPtr);
            }
        }

        ///< Combined friction coefficient in lateral direction (combines terrain and track)
        public new unsafe ref float mCombinedLateralFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetMutable_mCombinedLateralFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetMutable_mCombinedLateralFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelTV_GetMutable_mCombinedLateralFriction(_Underlying *_this);
                return ref *__JPH_WheelTV_GetMutable_mCombinedLateralFriction(_UnderlyingPtr);
            }
        }

        ///< Amount of impulse that the brakes can apply to the floor (excluding friction), spread out from brake impulse applied on track
        public new unsafe ref float mBrakeImpulse
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_GetMutable_mBrakeImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_GetMutable_mBrakeImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelTV_GetMutable_mBrakeImpulse(_Underlying *_this);
                return ref *__JPH_WheelTV_GetMutable_mBrakeImpulse(_UnderlyingPtr);
            }
        }

        internal unsafe WheelTV(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// Generated from constructor `JPH::WheelTV::WheelTV`.
        public unsafe WheelTV(JPH.Const_WheelSettingsTV inWheel) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelTV._Underlying *__JPH_WheelTV_Construct(JPH.Const_WheelSettingsTV._Underlying *inWheel);
            _UnderlyingPtr = __JPH_WheelTV_Construct(inWheel._UnderlyingPtr);
        }

        /// Update the angular velocity of the wheel based on the angular velocity of the track
        /// Generated from method `JPH::WheelTV::CalculateAngularVelocity`.
        public unsafe void CalculateAngularVelocity(JPH.Const_VehicleConstraint inConstraint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_CalculateAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_CalculateAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelTV_CalculateAngularVelocity(_Underlying *_this, JPH.Const_VehicleConstraint._Underlying *inConstraint);
            __JPH_WheelTV_CalculateAngularVelocity(_UnderlyingPtr, inConstraint._UnderlyingPtr);
        }

        /// Update the wheel rotation based on the current angular velocity
        /// Generated from method `JPH::WheelTV::Update`.
        public unsafe void Update(uint inWheelIndex, float inDeltaTime, JPH.Const_VehicleConstraint inConstraint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_Update", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_Update", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelTV_Update(_Underlying *_this, uint inWheelIndex, float inDeltaTime, JPH.Const_VehicleConstraint._Underlying *inConstraint);
            __JPH_WheelTV_Update(_UnderlyingPtr, inWheelIndex, inDeltaTime, inConstraint._UnderlyingPtr);
        }

        /// Update the angular velocity (rad/s)
        /// Generated from method `JPH::WheelTV::SetAngularVelocity`.
        public unsafe void SetAngularVelocity(float inVel)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelTV_SetAngularVelocity(_Underlying *_this, float inVel);
            __JPH_WheelTV_SetAngularVelocity(_UnderlyingPtr, inVel);
        }

        /// Set the current rotation angle of the wheel in radians [0, 2 pi]
        /// Generated from method `JPH::WheelTV::SetRotationAngle`.
        public unsafe void SetRotationAngle(float inAngle)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_SetRotationAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_SetRotationAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelTV_SetRotationAngle(_Underlying *_this, float inAngle);
            __JPH_WheelTV_SetRotationAngle(_UnderlyingPtr, inAngle);
        }

        /// Set the current steer angle of the wheel in radians [-pi, pi]
        /// Generated from method `JPH::WheelTV::SetSteerAngle`.
        public unsafe void SetSteerAngle(float inAngle)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_SetSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_SetSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelTV_SetSteerAngle(_Underlying *_this, float inAngle);
            __JPH_WheelTV_SetSteerAngle(_UnderlyingPtr, inAngle);
        }

        /// Internal function that should only be called by the controller. Used to apply impulses in the forward direction of the vehicle.
        /// Generated from method `JPH::WheelTV::SolveLongitudinalConstraintPart`.
        public unsafe bool SolveLongitudinalConstraintPart(JPH.Const_VehicleConstraint inConstraint, float inMinImpulse, float inMaxImpulse)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_SolveLongitudinalConstraintPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_SolveLongitudinalConstraintPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_WheelTV_SolveLongitudinalConstraintPart(_Underlying *_this, JPH.Const_VehicleConstraint._Underlying *inConstraint, float inMinImpulse, float inMaxImpulse);
            return __JPH_WheelTV_SolveLongitudinalConstraintPart(_UnderlyingPtr, inConstraint._UnderlyingPtr, inMinImpulse, inMaxImpulse) != 0;
        }

        /// Internal function that should only be called by the controller. Used to apply impulses in the sideways direction of the vehicle.
        /// Generated from method `JPH::WheelTV::SolveLateralConstraintPart`.
        public unsafe bool SolveLateralConstraintPart(JPH.Const_VehicleConstraint inConstraint, float inMinImpulse, float inMaxImpulse)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelTV_SolveLateralConstraintPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelTV_SolveLateralConstraintPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_WheelTV_SolveLateralConstraintPart(_Underlying *_this, JPH.Const_VehicleConstraint._Underlying *inConstraint, float inMinImpulse, float inMaxImpulse);
            return __JPH_WheelTV_SolveLateralConstraintPart(_UnderlyingPtr, inConstraint._UnderlyingPtr, inMinImpulse, inMaxImpulse) != 0;
        }
    }

    /// This is used for optional parameters of class `WheelTV` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_WheelTV`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `WheelTV`/`Const_WheelTV` directly.
    public class _InOptMut_WheelTV
    {
        public WheelTV? Opt;

        public _InOptMut_WheelTV() {}
        public _InOptMut_WheelTV(WheelTV value) {Opt = value;}
        public static implicit operator _InOptMut_WheelTV(WheelTV value) {return new(value);}
    }

    /// This is used for optional parameters of class `WheelTV` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_WheelTV`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `WheelTV`/`Const_WheelTV` to pass it to the function.
    public class _InOptConst_WheelTV
    {
        public Const_WheelTV? Opt;

        public _InOptConst_WheelTV() {}
        public _InOptConst_WheelTV(Const_WheelTV value) {Opt = value;}
        public static implicit operator _InOptConst_WheelTV(Const_WheelTV value) {return new(value);}
    }

    /// Settings of a vehicle with tank tracks
    ///
    /// Default settings are based around what I could find about the M1 Abrams tank.
    /// Note to avoid issues with very heavy objects vs very light objects the mass of the tank should be a lot lower (say 10x) than that of a real tank. That means that the engine/brake torque is also 10x less.
    /// Generated from class `JPH::TrackedVehicleControllerSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleControllerSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::VehicleControllerSettings>`
    /// This is the const half of the class.
    public class Const_TrackedVehicleControllerSettings : JPH.Object<Const_TrackedVehicleControllerSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_Release(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_Release(__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_TrackedVehicleControllerSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_TrackedVehicleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHVehicleControllerSettings(Const_TrackedVehicleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHVehicleControllerSettings._Underlying *__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHVehicleControllerSettings ret = new(__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_VehicleControllerSettings(Const_TrackedVehicleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleControllerSettings._Underlying *__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(_Underlying *_this);
            JPH.Const_VehicleControllerSettings ret = new(__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_TrackedVehicleControllerSettings(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            Const_TrackedVehicleControllerSettings ret = new(__JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TrackedVehicleControllerSettings(JPH.Const_RefTarget_JPHVehicleControllerSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(JPH.Const_RefTarget_JPHVehicleControllerSettings._Underlying *_this);
            Const_TrackedVehicleControllerSettings ret = new(__JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TrackedVehicleControllerSettings(JPH.Const_VehicleControllerSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(JPH.Const_VehicleControllerSettings._Underlying *_this);
            Const_TrackedVehicleControllerSettings ret = new(__JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< The properties of the engine
        public unsafe JPH.Const_VehicleEngineSettings mEngine
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_Get_mEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_Get_mEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_VehicleEngineSettings._Underlying *__JPH_TrackedVehicleControllerSettings_Get_mEngine(_Underlying *_this);
                JPH.Const_VehicleEngineSettings __ret;
                __ret = new(__JPH_TrackedVehicleControllerSettings_Get_mEngine(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< The properties of the transmission (aka gear box)
        public unsafe JPH.Const_VehicleTransmissionSettings mTransmission
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_Get_mTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_Get_mTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_VehicleTransmissionSettings._Underlying *__JPH_TrackedVehicleControllerSettings_Get_mTransmission(_Underlying *_this);
                JPH.Const_VehicleTransmissionSettings __ret;
                __ret = new(__JPH_TrackedVehicleControllerSettings_Get_mTransmission(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< List of tracks and their properties
        public unsafe JPH.ArrayVehicleTrackSettings2 mTracks
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_Get_mTracks", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_Get_mTracks", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.VehicleTrackSettings._Underlying *__JPH_TrackedVehicleControllerSettings_Get_mTracks(_Underlying *_this);
                return new(__JPH_TrackedVehicleControllerSettings_Get_mTracks(_UnderlyingPtr));
            }
        }

        internal unsafe Const_TrackedVehicleControllerSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_TrackedVehicleControllerSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TrackedVehicleControllerSettings._Underlying *__JPH_TrackedVehicleControllerSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_TrackedVehicleControllerSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::TrackedVehicleControllerSettings::TrackedVehicleControllerSettings`.
        public unsafe Const_TrackedVehicleControllerSettings(JPH._ByValue_TrackedVehicleControllerSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TrackedVehicleControllerSettings._Underlying *__JPH_TrackedVehicleControllerSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.TrackedVehicleControllerSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_TrackedVehicleControllerSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::TrackedVehicleControllerSettings::TrackedVehicleControllerSettings`.
        public Const_TrackedVehicleControllerSettings(Const_TrackedVehicleControllerSettings _other) : this(new _ByValue_TrackedVehicleControllerSettings(_other)) {}

        /// Generated from constructor `JPH::TrackedVehicleControllerSettings::TrackedVehicleControllerSettings`.
        public Const_TrackedVehicleControllerSettings(TrackedVehicleControllerSettings _other) : this((Const_TrackedVehicleControllerSettings)_other) {}

        /// Generated from method `JPH::TrackedVehicleControllerSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TrackedVehicleControllerSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TrackedVehicleControllerSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TrackedVehicleControllerSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_TrackedVehicleControllerSettings_size_t(inCount);
        }

        /// Generated from method `JPH::TrackedVehicleControllerSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TrackedVehicleControllerSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TrackedVehicleControllerSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TrackedVehicleControllerSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TrackedVehicleControllerSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TrackedVehicleControllerSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_TrackedVehicleControllerSettings_size_t(inCount);
        }

        /// Generated from method `JPH::TrackedVehicleControllerSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TrackedVehicleControllerSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TrackedVehicleControllerSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TrackedVehicleControllerSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TrackedVehicleControllerSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TrackedVehicleControllerSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_TrackedVehicleControllerSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TrackedVehicleControllerSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_TrackedVehicleControllerSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::TrackedVehicleControllerSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TrackedVehicleControllerSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TrackedVehicleControllerSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TrackedVehicleControllerSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_TrackedVehicleControllerSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TrackedVehicleControllerSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_TrackedVehicleControllerSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        // See: VehicleControllerSettings
        /// Generated from method `JPH::TrackedVehicleControllerSettings::ConstructController`.
        public unsafe JPH.VehicleController? ConstructController(JPH.VehicleConstraint inConstraint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_ConstructController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_ConstructController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleController._Underlying *__JPH_TrackedVehicleControllerSettings_ConstructController(_Underlying *_this, JPH.VehicleConstraint._Underlying *inConstraint);
            var __c_ret = __JPH_TrackedVehicleControllerSettings_ConstructController(_UnderlyingPtr, inConstraint._UnderlyingPtr);
            return __c_ret is not null ? new JPH.VehicleController(__c_ret, is_owning: false) : null;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::TrackedVehicleControllerSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TrackedVehicleControllerSettings_SetEmbedded(_Underlying *_this);
            __JPH_TrackedVehicleControllerSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::TrackedVehicleControllerSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_TrackedVehicleControllerSettings_GetRefCount(_Underlying *_this);
            return __JPH_TrackedVehicleControllerSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::TrackedVehicleControllerSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TrackedVehicleControllerSettings_AddRef(_Underlying *_this);
            __JPH_TrackedVehicleControllerSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::TrackedVehicleControllerSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TrackedVehicleControllerSettings_Release(_Underlying *_this);
            __JPH_TrackedVehicleControllerSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::TrackedVehicleControllerSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_TrackedVehicleControllerSettings_sInternalGetRefCountOffset();
            return __JPH_TrackedVehicleControllerSettings_sInternalGetRefCountOffset();
        }
    }

    /// Settings of a vehicle with tank tracks
    ///
    /// Default settings are based around what I could find about the M1 Abrams tank.
    /// Note to avoid issues with very heavy objects vs very light objects the mass of the tank should be a lot lower (say 10x) than that of a real tank. That means that the engine/brake torque is also 10x less.
    /// Generated from class `JPH::TrackedVehicleControllerSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleControllerSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::VehicleControllerSettings>`
    /// This is the non-const half of the class.
    public class TrackedVehicleControllerSettings : Const_TrackedVehicleControllerSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(TrackedVehicleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_SerializableObject(TrackedVehicleControllerSettings self)
            => (JPH.Const_SerializableObject)(JPH.Const_TrackedVehicleControllerSettings)self;
        public static unsafe implicit operator JPH.RefTarget_JPHVehicleControllerSettings(TrackedVehicleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleControllerSettings._Underlying *__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            JPH.RefTarget_JPHVehicleControllerSettings ret = new(__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHVehicleControllerSettings(TrackedVehicleControllerSettings self)
            => (JPH.Const_RefTarget_JPHVehicleControllerSettings)(JPH.Const_TrackedVehicleControllerSettings)self;
        public static unsafe implicit operator JPH.VehicleControllerSettings(TrackedVehicleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleControllerSettings._Underlying *__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(_Underlying *_this);
            JPH.VehicleControllerSettings ret = new(__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_VehicleControllerSettings(TrackedVehicleControllerSettings self)
            => (JPH.Const_VehicleControllerSettings)(JPH.Const_TrackedVehicleControllerSettings)self;

        // Downcasts:
        public static unsafe explicit operator TrackedVehicleControllerSettings(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            TrackedVehicleControllerSettings ret = new(__JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TrackedVehicleControllerSettings(JPH.RefTarget_JPHVehicleControllerSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(JPH.RefTarget_JPHVehicleControllerSettings._Underlying *_this);
            TrackedVehicleControllerSettings ret = new(__JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TrackedVehicleControllerSettings(JPH.VehicleControllerSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(JPH.VehicleControllerSettings._Underlying *_this);
            TrackedVehicleControllerSettings ret = new(__JPH_TrackedVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< The properties of the engine
        public new unsafe JPH.VehicleEngineSettings mEngine
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_GetMutable_mEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_GetMutable_mEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.VehicleEngineSettings._Underlying *__JPH_TrackedVehicleControllerSettings_GetMutable_mEngine(_Underlying *_this);
                JPH.VehicleEngineSettings __ret;
                __ret = new(__JPH_TrackedVehicleControllerSettings_GetMutable_mEngine(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< The properties of the transmission (aka gear box)
        public new unsafe JPH.VehicleTransmissionSettings mTransmission
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_GetMutable_mTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_GetMutable_mTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.VehicleTransmissionSettings._Underlying *__JPH_TrackedVehicleControllerSettings_GetMutable_mTransmission(_Underlying *_this);
                JPH.VehicleTransmissionSettings __ret;
                __ret = new(__JPH_TrackedVehicleControllerSettings_GetMutable_mTransmission(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< List of tracks and their properties
        new public unsafe JPH.ArrayVehicleTrackSettings2 mTracks
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_GetMutable_mTracks", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_GetMutable_mTracks", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.VehicleTrackSettings._Underlying *__JPH_TrackedVehicleControllerSettings_GetMutable_mTracks(_Underlying *_this);
                return new(__JPH_TrackedVehicleControllerSettings_GetMutable_mTracks(_UnderlyingPtr));
            }
        }

        internal unsafe TrackedVehicleControllerSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe TrackedVehicleControllerSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TrackedVehicleControllerSettings._Underlying *__JPH_TrackedVehicleControllerSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_TrackedVehicleControllerSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::TrackedVehicleControllerSettings::TrackedVehicleControllerSettings`.
        public unsafe TrackedVehicleControllerSettings(JPH._ByValue_TrackedVehicleControllerSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TrackedVehicleControllerSettings._Underlying *__JPH_TrackedVehicleControllerSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.TrackedVehicleControllerSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_TrackedVehicleControllerSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(__JPH_TrackedVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::TrackedVehicleControllerSettings::TrackedVehicleControllerSettings`.
        public TrackedVehicleControllerSettings(Const_TrackedVehicleControllerSettings _other) : this(new _ByValue_TrackedVehicleControllerSettings(_other)) {}

        /// Generated from constructor `JPH::TrackedVehicleControllerSettings::TrackedVehicleControllerSettings`.
        public TrackedVehicleControllerSettings(TrackedVehicleControllerSettings _other) : this((Const_TrackedVehicleControllerSettings)_other) {}

        /// Generated from method `JPH::TrackedVehicleControllerSettings::operator=`.
        public unsafe JPH.TrackedVehicleControllerSettings Assign(JPH._ByValue_TrackedVehicleControllerSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleControllerSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TrackedVehicleControllerSettings._Underlying *__JPH_TrackedVehicleControllerSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.TrackedVehicleControllerSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_TrackedVehicleControllerSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `TrackedVehicleControllerSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `TrackedVehicleControllerSettings`/`Const_TrackedVehicleControllerSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_TrackedVehicleControllerSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_TrackedVehicleControllerSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_TrackedVehicleControllerSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_TrackedVehicleControllerSettings(Const_TrackedVehicleControllerSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_TrackedVehicleControllerSettings(Const_TrackedVehicleControllerSettings arg) {return new(arg);}
        public _ByValue_TrackedVehicleControllerSettings(JPH._Moved<TrackedVehicleControllerSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_TrackedVehicleControllerSettings(JPH._Moved<TrackedVehicleControllerSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `TrackedVehicleControllerSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_TrackedVehicleControllerSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TrackedVehicleControllerSettings`/`Const_TrackedVehicleControllerSettings` directly.
    public class _InOptMut_TrackedVehicleControllerSettings
    {
        public TrackedVehicleControllerSettings? Opt;

        public _InOptMut_TrackedVehicleControllerSettings() {}
        public _InOptMut_TrackedVehicleControllerSettings(TrackedVehicleControllerSettings value) {Opt = value;}
        public static implicit operator _InOptMut_TrackedVehicleControllerSettings(TrackedVehicleControllerSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `TrackedVehicleControllerSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_TrackedVehicleControllerSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TrackedVehicleControllerSettings`/`Const_TrackedVehicleControllerSettings` to pass it to the function.
    public class _InOptConst_TrackedVehicleControllerSettings
    {
        public Const_TrackedVehicleControllerSettings? Opt;

        public _InOptConst_TrackedVehicleControllerSettings() {}
        public _InOptConst_TrackedVehicleControllerSettings(Const_TrackedVehicleControllerSettings value) {Opt = value;}
        public static implicit operator _InOptConst_TrackedVehicleControllerSettings(Const_TrackedVehicleControllerSettings value) {return new(value);}
    }

    /// Runtime controller class for vehicle with tank tracks
    /// Generated from class `JPH::TrackedVehicleController`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleController`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_TrackedVehicleController : JPH.Object<Const_TrackedVehicleController>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TrackedVehicleController_Destroy(_Underlying *_this);
            __JPH_TrackedVehicleController_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_TrackedVehicleController() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_TrackedVehicleController self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_TrackedVehicleController_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_TrackedVehicleController_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_VehicleController(Const_TrackedVehicleController self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_UpcastTo_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_UpcastTo_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleController._Underlying *__JPH_TrackedVehicleController_UpcastTo_JPH_VehicleController(_Underlying *_this);
            JPH.Const_VehicleController ret = new(__JPH_TrackedVehicleController_UpcastTo_JPH_VehicleController(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_TrackedVehicleController(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TrackedVehicleController_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_TrackedVehicleController ret = new(__JPH_TrackedVehicleController_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TrackedVehicleController(JPH.Const_VehicleController parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_StaticDowncastFrom_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_StaticDowncastFrom_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TrackedVehicleController_StaticDowncastFrom_JPH_VehicleController(JPH.Const_VehicleController._Underlying *_this);
            Const_TrackedVehicleController ret = new(__JPH_TrackedVehicleController_StaticDowncastFrom_JPH_VehicleController(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_TrackedVehicleController(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// Generated from constructor `JPH::TrackedVehicleController::TrackedVehicleController`.
        public unsafe Const_TrackedVehicleController(JPH.Const_TrackedVehicleControllerSettings inSettings, JPH.VehicleConstraint inConstraint) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TrackedVehicleController._Underlying *__JPH_TrackedVehicleController_Construct(JPH.Const_TrackedVehicleControllerSettings._Underlying *inSettings, JPH.VehicleConstraint._Underlying *inConstraint);
            _UnderlyingPtr = __JPH_TrackedVehicleController_Construct(inSettings._UnderlyingPtr, inConstraint._UnderlyingPtr);
        }

        /// Generated from method `JPH::TrackedVehicleController::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TrackedVehicleController_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TrackedVehicleController_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TrackedVehicleController_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_TrackedVehicleController_size_t(inCount);
        }

        /// Generated from method `JPH::TrackedVehicleController::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TrackedVehicleController_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TrackedVehicleController_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TrackedVehicleController_void_ptr(void *inPointer);
            __Jolt_delete_JPH_TrackedVehicleController_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TrackedVehicleController::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TrackedVehicleController_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TrackedVehicleController_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TrackedVehicleController_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_TrackedVehicleController_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TrackedVehicleController::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TrackedVehicleController_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TrackedVehicleController_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TrackedVehicleController_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_TrackedVehicleController_size_t(inCount);
        }

        /// Generated from method `JPH::TrackedVehicleController::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TrackedVehicleController_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TrackedVehicleController_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TrackedVehicleController_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_TrackedVehicleController_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TrackedVehicleController::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TrackedVehicleController_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TrackedVehicleController_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TrackedVehicleController_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_TrackedVehicleController_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TrackedVehicleController::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TrackedVehicleController_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TrackedVehicleController_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TrackedVehicleController_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_TrackedVehicleController_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TrackedVehicleController::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TrackedVehicleController_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TrackedVehicleController_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TrackedVehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_TrackedVehicleController_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::TrackedVehicleController::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TrackedVehicleController_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TrackedVehicleController_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TrackedVehicleController_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_TrackedVehicleController_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TrackedVehicleController::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TrackedVehicleController_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TrackedVehicleController_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TrackedVehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_TrackedVehicleController_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::TrackedVehicleController::GetForwardInput`.
        public unsafe float GetForwardInput()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_GetForwardInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_GetForwardInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TrackedVehicleController_GetForwardInput(_Underlying *_this);
            return __JPH_TrackedVehicleController_GetForwardInput(_UnderlyingPtr);
        }

        /// Generated from method `JPH::TrackedVehicleController::GetLeftRatio`.
        public unsafe float GetLeftRatio()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_GetLeftRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_GetLeftRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TrackedVehicleController_GetLeftRatio(_Underlying *_this);
            return __JPH_TrackedVehicleController_GetLeftRatio(_UnderlyingPtr);
        }

        /// Generated from method `JPH::TrackedVehicleController::GetRightRatio`.
        public unsafe float GetRightRatio()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_GetRightRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_GetRightRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TrackedVehicleController_GetRightRatio(_Underlying *_this);
            return __JPH_TrackedVehicleController_GetRightRatio(_UnderlyingPtr);
        }

        /// Generated from method `JPH::TrackedVehicleController::GetBrakeInput`.
        public unsafe float GetBrakeInput()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_GetBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_GetBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_TrackedVehicleController_GetBrakeInput(_Underlying *_this);
            return __JPH_TrackedVehicleController_GetBrakeInput(_UnderlyingPtr);
        }

        /// Get current engine state
        /// Generated from method `JPH::TrackedVehicleController::GetEngine`.
        public unsafe JPH.Const_VehicleEngine GetEngine()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_GetEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_GetEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleEngine._Underlying *__JPH_TrackedVehicleController_GetEngine(_Underlying *_this);
            return new(__JPH_TrackedVehicleController_GetEngine(_UnderlyingPtr), is_owning: false);
        }

        /// Get current transmission state
        /// Generated from method `JPH::TrackedVehicleController::GetTransmission`.
        public unsafe JPH.Const_VehicleTransmission GetTransmission()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_GetTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_GetTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleTransmission._Underlying *__JPH_TrackedVehicleController_GetTransmission(_Underlying *_this);
            return new(__JPH_TrackedVehicleController_GetTransmission(_UnderlyingPtr), is_owning: false);
        }
    }

    /// Runtime controller class for vehicle with tank tracks
    /// Generated from class `JPH::TrackedVehicleController`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleController`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class TrackedVehicleController : Const_TrackedVehicleController
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(TrackedVehicleController self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_TrackedVehicleController_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_TrackedVehicleController_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(TrackedVehicleController self)
            => (JPH.Const_NonCopyable)(JPH.Const_TrackedVehicleController)self;
        public static unsafe implicit operator JPH.VehicleController(TrackedVehicleController self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_UpcastTo_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_UpcastTo_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleController._Underlying *__JPH_TrackedVehicleController_UpcastTo_JPH_VehicleController(_Underlying *_this);
            JPH.VehicleController ret = new(__JPH_TrackedVehicleController_UpcastTo_JPH_VehicleController(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_VehicleController(TrackedVehicleController self)
            => (JPH.Const_VehicleController)(JPH.Const_TrackedVehicleController)self;

        // Downcasts:
        public static unsafe explicit operator TrackedVehicleController(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TrackedVehicleController_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            TrackedVehicleController ret = new(__JPH_TrackedVehicleController_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TrackedVehicleController(JPH.VehicleController parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_StaticDowncastFrom_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_StaticDowncastFrom_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TrackedVehicleController_StaticDowncastFrom_JPH_VehicleController(JPH.VehicleController._Underlying *_this);
            TrackedVehicleController ret = new(__JPH_TrackedVehicleController_StaticDowncastFrom_JPH_VehicleController(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe TrackedVehicleController(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// Generated from constructor `JPH::TrackedVehicleController::TrackedVehicleController`.
        public unsafe TrackedVehicleController(JPH.Const_TrackedVehicleControllerSettings inSettings, JPH.VehicleConstraint inConstraint) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TrackedVehicleController._Underlying *__JPH_TrackedVehicleController_Construct(JPH.Const_TrackedVehicleControllerSettings._Underlying *inSettings, JPH.VehicleConstraint._Underlying *inConstraint);
            _UnderlyingPtr = __JPH_TrackedVehicleController_Construct(inSettings._UnderlyingPtr, inConstraint._UnderlyingPtr);
        }

        /// Set input from driver
        /// @param inForward Value between -1 and 1 for auto transmission and value between 0 and 1 indicating desired driving direction and amount the gas pedal is pressed
        /// @param inLeftRatio Value between -1 and 1 indicating an extra multiplier to the rotation rate of the left track (used for steering)
        /// @param inRightRatio Value between -1 and 1 indicating an extra multiplier to the rotation rate of the right track (used for steering)
        /// @param inBrake Value between 0 and 1 indicating how strong the brake pedal is pressed
        /// Generated from method `JPH::TrackedVehicleController::SetDriverInput`.
        public unsafe void SetDriverInput(float inForward, float inLeftRatio, float inRightRatio, float inBrake)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_SetDriverInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_SetDriverInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TrackedVehicleController_SetDriverInput(_Underlying *_this, float inForward, float inLeftRatio, float inRightRatio, float inBrake);
            __JPH_TrackedVehicleController_SetDriverInput(_UnderlyingPtr, inForward, inLeftRatio, inRightRatio, inBrake);
        }

        /// Value between -1 and 1 for auto transmission and value between 0 and 1 indicating desired driving direction and amount the gas pedal is pressed
        /// Generated from method `JPH::TrackedVehicleController::SetForwardInput`.
        public unsafe void SetForwardInput(float inForward)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_SetForwardInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_SetForwardInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TrackedVehicleController_SetForwardInput(_Underlying *_this, float inForward);
            __JPH_TrackedVehicleController_SetForwardInput(_UnderlyingPtr, inForward);
        }

        /// Value between -1 and 1 indicating an extra multiplier to the rotation rate of the left track (used for steering)
        /// Generated from method `JPH::TrackedVehicleController::SetLeftRatio`.
        public unsafe void SetLeftRatio(float inLeftRatio)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_SetLeftRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_SetLeftRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TrackedVehicleController_SetLeftRatio(_Underlying *_this, float inLeftRatio);
            __JPH_TrackedVehicleController_SetLeftRatio(_UnderlyingPtr, inLeftRatio);
        }

        /// Value between -1 and 1 indicating an extra multiplier to the rotation rate of the right track (used for steering)
        /// Generated from method `JPH::TrackedVehicleController::SetRightRatio`.
        public unsafe void SetRightRatio(float inRightRatio)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_SetRightRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_SetRightRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TrackedVehicleController_SetRightRatio(_Underlying *_this, float inRightRatio);
            __JPH_TrackedVehicleController_SetRightRatio(_UnderlyingPtr, inRightRatio);
        }

        /// Value between 0 and 1 indicating how strong the brake pedal is pressed
        /// Generated from method `JPH::TrackedVehicleController::SetBrakeInput`.
        public unsafe void SetBrakeInput(float inBrake)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_SetBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_SetBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TrackedVehicleController_SetBrakeInput(_Underlying *_this, float inBrake);
            __JPH_TrackedVehicleController_SetBrakeInput(_UnderlyingPtr, inBrake);
        }

        /// Get current engine state (writable interface, allows you to make changes to the configuration which will take effect the next time step)
        /// Generated from method `JPH::TrackedVehicleController::GetEngine`.
        public unsafe new JPH.VehicleEngine GetEngine()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_GetEngine_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_GetEngine_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleEngine._Underlying *__JPH_TrackedVehicleController_GetEngine_mut(_Underlying *_this);
            return new(__JPH_TrackedVehicleController_GetEngine_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Get current transmission state (writable interface, allows you to make changes to the configuration which will take effect the next time step)
        /// Generated from method `JPH::TrackedVehicleController::GetTransmission`.
        public unsafe new JPH.VehicleTransmission GetTransmission()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_GetTransmission_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_GetTransmission_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmission._Underlying *__JPH_TrackedVehicleController_GetTransmission_mut(_Underlying *_this);
            return new(__JPH_TrackedVehicleController_GetTransmission_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Debug drawing of RPM meter
        /// Generated from method `JPH::TrackedVehicleController::SetRPMMeter`.
        public unsafe void SetRPMMeter(JPH.Const_Vec3 inPosition, float inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TrackedVehicleController_SetRPMMeter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TrackedVehicleController_SetRPMMeter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TrackedVehicleController_SetRPMMeter(_Underlying *_this, JPH.Vec3._Underlying *inPosition, float inSize);
            __JPH_TrackedVehicleController_SetRPMMeter(_UnderlyingPtr, inPosition._UnderlyingPtr, inSize);
        }
    }

    /// This is used for optional parameters of class `TrackedVehicleController` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_TrackedVehicleController`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TrackedVehicleController`/`Const_TrackedVehicleController` directly.
    public class _InOptMut_TrackedVehicleController
    {
        public TrackedVehicleController? Opt;

        public _InOptMut_TrackedVehicleController() {}
        public _InOptMut_TrackedVehicleController(TrackedVehicleController value) {Opt = value;}
        public static implicit operator _InOptMut_TrackedVehicleController(TrackedVehicleController value) {return new(value);}
    }

    /// This is used for optional parameters of class `TrackedVehicleController` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_TrackedVehicleController`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TrackedVehicleController`/`Const_TrackedVehicleController` to pass it to the function.
    public class _InOptConst_TrackedVehicleController
    {
        public Const_TrackedVehicleController? Opt;

        public _InOptConst_TrackedVehicleController() {}
        public _InOptConst_TrackedVehicleController(Const_TrackedVehicleController value) {Opt = value;}
        public static implicit operator _InOptConst_TrackedVehicleController(Const_TrackedVehicleController value) {return new(value);}
    }
}
