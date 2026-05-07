// machine generated, do not edit
public static partial class JPH
{
    /// WheelSettings object specifically for WheeledVehicleController
    /// Generated from class `JPH::WheelSettingsWV`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::WheelSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::WheelSettings>`
    /// This is the const half of the class.
    public class Const_WheelSettingsWV : JPH.Object<Const_WheelSettingsWV>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_Release(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_Release(__JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_WheelSettingsWV() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_WheelSettingsWV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_WheelSettingsWV_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_WheelSettingsWV_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHWheelSettings(Const_WheelSettingsWV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHWheelSettings._Underlying *__JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHWheelSettings ret = new(__JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_WheelSettings(Const_WheelSettingsWV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_WheelSettings._Underlying *__JPH_WheelSettingsWV_UpcastTo_JPH_WheelSettings(_Underlying *_this);
            JPH.Const_WheelSettings ret = new(__JPH_WheelSettingsWV_UpcastTo_JPH_WheelSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_WheelSettingsWV(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettingsWV_StaticDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            Const_WheelSettingsWV ret = new(__JPH_WheelSettingsWV_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_WheelSettingsWV(JPH.Const_RefTarget_JPHWheelSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettingsWV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(JPH.Const_RefTarget_JPHWheelSettings._Underlying *_this);
            Const_WheelSettingsWV ret = new(__JPH_WheelSettingsWV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_WheelSettingsWV(JPH.Const_WheelSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_StaticDowncastFrom_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_StaticDowncastFrom_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettingsWV_StaticDowncastFrom_JPH_WheelSettings(JPH.Const_WheelSettings._Underlying *_this);
            Const_WheelSettingsWV ret = new(__JPH_WheelSettingsWV_StaticDowncastFrom_JPH_WheelSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Moment of inertia (kg m^2), for a cylinder this would be 0.5 * M * R^2 which is 0.9 for a wheel with a mass of 20 kg and radius 0.3 m
        public unsafe float mInertia
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_Get_mInertia(_Underlying *_this);
                return *__JPH_WheelSettingsWV_Get_mInertia(_UnderlyingPtr);
            }
        }

        ///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
        public unsafe float mAngularDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_Get_mAngularDamping(_Underlying *_this);
                return *__JPH_WheelSettingsWV_Get_mAngularDamping(_UnderlyingPtr);
            }
        }

        ///< How much this wheel can steer (radians)
        public unsafe float mMaxSteerAngle
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mMaxSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mMaxSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_Get_mMaxSteerAngle(_Underlying *_this);
                return *__JPH_WheelSettingsWV_Get_mMaxSteerAngle(_UnderlyingPtr);
            }
        }

        ///< How much torque (Nm) the brakes can apply to this wheel
        public unsafe float mMaxBrakeTorque
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mMaxBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mMaxBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_Get_mMaxBrakeTorque(_Underlying *_this);
                return *__JPH_WheelSettingsWV_Get_mMaxBrakeTorque(_UnderlyingPtr);
            }
        }

        ///< How much torque (Nm) the hand brake can apply to this wheel (usually only applied to the rear wheels)
        public unsafe float mMaxHandBrakeTorque
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mMaxHandBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mMaxHandBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_Get_mMaxHandBrakeTorque(_Underlying *_this);
                return *__JPH_WheelSettingsWV_Get_mMaxHandBrakeTorque(_UnderlyingPtr);
            }
        }

        ///< Attachment point of wheel suspension in local space of the body
        public unsafe JPH.Const_Vec3 mPosition
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettingsWV_Get_mPosition(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettingsWV_Get_mPosition(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettingsWV_Get_mSuspensionForcePoint(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettingsWV_Get_mSuspensionForcePoint(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mSuspensionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mSuspensionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettingsWV_Get_mSuspensionDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettingsWV_Get_mSuspensionDirection(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mSteeringAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mSteeringAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettingsWV_Get_mSteeringAxis(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettingsWV_Get_mSteeringAxis(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mWheelUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mWheelUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettingsWV_Get_mWheelUp(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettingsWV_Get_mWheelUp(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mWheelForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mWheelForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_WheelSettingsWV_Get_mWheelForward(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_WheelSettingsWV_Get_mWheelForward(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mSuspensionMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mSuspensionMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_Get_mSuspensionMinLength(_Underlying *_this);
                return *__JPH_WheelSettingsWV_Get_mSuspensionMinLength(_UnderlyingPtr);
            }
        }

        ///< How long the suspension is in max droop position relative to the attachment point (m)
        public unsafe float mSuspensionMaxLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mSuspensionMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mSuspensionMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_Get_mSuspensionMaxLength(_Underlying *_this);
                return *__JPH_WheelSettingsWV_Get_mSuspensionMaxLength(_UnderlyingPtr);
            }
        }

        ///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
        public unsafe float mSuspensionPreloadLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mSuspensionPreloadLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mSuspensionPreloadLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_Get_mSuspensionPreloadLength(_Underlying *_this);
                return *__JPH_WheelSettingsWV_Get_mSuspensionPreloadLength(_UnderlyingPtr);
            }
        }

        ///< Settings for the suspension spring
        public unsafe JPH.Const_SpringSettings mSuspensionSpring
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mSuspensionSpring", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mSuspensionSpring", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_SpringSettings._Underlying *__JPH_WheelSettingsWV_Get_mSuspensionSpring(_Underlying *_this);
                JPH.Const_SpringSettings __ret;
                __ret = new(__JPH_WheelSettingsWV_Get_mSuspensionSpring(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_Get_mRadius(_Underlying *_this);
                return *__JPH_WheelSettingsWV_Get_mRadius(_UnderlyingPtr);
            }
        }

        ///< Width of the wheel (m)
        public unsafe float mWidth
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mWidth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mWidth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_Get_mWidth(_Underlying *_this);
                return *__JPH_WheelSettingsWV_Get_mWidth(_UnderlyingPtr);
            }
        }

        ///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
        public unsafe bool mEnableSuspensionForcePoint
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mEnableSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Get_mEnableSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_WheelSettingsWV_Get_mEnableSuspensionForcePoint(_Underlying *_this);
                return *__JPH_WheelSettingsWV_Get_mEnableSuspensionForcePoint(_UnderlyingPtr);
            }
        }

        internal unsafe Const_WheelSettingsWV(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_WheelSettingsWV() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettingsWV._Underlying *__JPH_WheelSettingsWV_DefaultConstruct();
            _UnderlyingPtr = __JPH_WheelSettingsWV_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_AddRef(__JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::WheelSettingsWV::WheelSettingsWV`.
        public unsafe Const_WheelSettingsWV(JPH._ByValue_WheelSettingsWV _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettingsWV._Underlying *__JPH_WheelSettingsWV_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.WheelSettingsWV._Underlying *_other);
            _UnderlyingPtr = __JPH_WheelSettingsWV_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_AddRef(__JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::WheelSettingsWV::WheelSettingsWV`.
        public Const_WheelSettingsWV(Const_WheelSettingsWV _other) : this(new _ByValue_WheelSettingsWV(_other)) {}

        /// Generated from constructor `JPH::WheelSettingsWV::WheelSettingsWV`.
        public Const_WheelSettingsWV(WheelSettingsWV _other) : this((Const_WheelSettingsWV)_other) {}

        /// Generated from method `JPH::WheelSettingsWV::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_WheelSettingsWV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_WheelSettingsWV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_WheelSettingsWV_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_WheelSettingsWV_size_t(inCount);
        }

        /// Generated from method `JPH::WheelSettingsWV::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettingsWV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettingsWV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelSettingsWV_void_ptr(void *inPointer);
            __Jolt_delete_JPH_WheelSettingsWV_void_ptr(inPointer);
        }

        /// Generated from method `JPH::WheelSettingsWV::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettingsWV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettingsWV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelSettingsWV_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_WheelSettingsWV_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::WheelSettingsWV::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_WheelSettingsWV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_WheelSettingsWV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_WheelSettingsWV_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_WheelSettingsWV_size_t(inCount);
        }

        /// Generated from method `JPH::WheelSettingsWV::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettingsWV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettingsWV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelSettingsWV_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_WheelSettingsWV_void_ptr(inPointer);
        }

        /// Generated from method `JPH::WheelSettingsWV::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettingsWV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettingsWV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelSettingsWV_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_WheelSettingsWV_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::WheelSettingsWV::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_WheelSettingsWV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_WheelSettingsWV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_WheelSettingsWV_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_WheelSettingsWV_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::WheelSettingsWV::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettingsWV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelSettingsWV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelSettingsWV_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_WheelSettingsWV_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::WheelSettingsWV::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_WheelSettingsWV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_WheelSettingsWV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_WheelSettingsWV_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_WheelSettingsWV_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::WheelSettingsWV::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettingsWV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelSettingsWV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelSettingsWV_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_WheelSettingsWV_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::WheelSettingsWV::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelSettingsWV_SetEmbedded(_Underlying *_this);
            __JPH_WheelSettingsWV_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::WheelSettingsWV::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_WheelSettingsWV_GetRefCount(_Underlying *_this);
            return __JPH_WheelSettingsWV_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::WheelSettingsWV::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelSettingsWV_AddRef(_Underlying *_this);
            __JPH_WheelSettingsWV_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::WheelSettingsWV::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelSettingsWV_Release(_Underlying *_this);
            __JPH_WheelSettingsWV_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::WheelSettingsWV::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_WheelSettingsWV_sInternalGetRefCountOffset();
            return __JPH_WheelSettingsWV_sInternalGetRefCountOffset();
        }
    }

    /// WheelSettings object specifically for WheeledVehicleController
    /// Generated from class `JPH::WheelSettingsWV`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::WheelSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::WheelSettings>`
    /// This is the non-const half of the class.
    public class WheelSettingsWV : Const_WheelSettingsWV
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(WheelSettingsWV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_WheelSettingsWV_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_WheelSettingsWV_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.RefTarget_JPHWheelSettings(WheelSettingsWV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHWheelSettings._Underlying *__JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            JPH.RefTarget_JPHWheelSettings ret = new(__JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.WheelSettings(WheelSettingsWV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettings._Underlying *__JPH_WheelSettingsWV_UpcastTo_JPH_WheelSettings(_Underlying *_this);
            JPH.WheelSettings ret = new(__JPH_WheelSettingsWV_UpcastTo_JPH_WheelSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator WheelSettingsWV(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettingsWV_StaticDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            WheelSettingsWV ret = new(__JPH_WheelSettingsWV_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator WheelSettingsWV(JPH.RefTarget_JPHWheelSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettingsWV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(JPH.RefTarget_JPHWheelSettings._Underlying *_this);
            WheelSettingsWV ret = new(__JPH_WheelSettingsWV_StaticDowncastFrom_JPH_RefTarget_JPH_WheelSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator WheelSettingsWV(JPH.WheelSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_StaticDowncastFrom_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_StaticDowncastFrom_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelSettingsWV_StaticDowncastFrom_JPH_WheelSettings(JPH.WheelSettings._Underlying *_this);
            WheelSettingsWV ret = new(__JPH_WheelSettingsWV_StaticDowncastFrom_JPH_WheelSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Moment of inertia (kg m^2), for a cylinder this would be 0.5 * M * R^2 which is 0.9 for a wheel with a mass of 20 kg and radius 0.3 m
        public new unsafe ref float mInertia
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_GetMutable_mInertia(_Underlying *_this);
                return ref *__JPH_WheelSettingsWV_GetMutable_mInertia(_UnderlyingPtr);
            }
        }

        ///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
        public new unsafe ref float mAngularDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_GetMutable_mAngularDamping(_Underlying *_this);
                return ref *__JPH_WheelSettingsWV_GetMutable_mAngularDamping(_UnderlyingPtr);
            }
        }

        ///< How much this wheel can steer (radians)
        public new unsafe ref float mMaxSteerAngle
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mMaxSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mMaxSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_GetMutable_mMaxSteerAngle(_Underlying *_this);
                return ref *__JPH_WheelSettingsWV_GetMutable_mMaxSteerAngle(_UnderlyingPtr);
            }
        }

        ///< How much torque (Nm) the brakes can apply to this wheel
        public new unsafe ref float mMaxBrakeTorque
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mMaxBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mMaxBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_GetMutable_mMaxBrakeTorque(_Underlying *_this);
                return ref *__JPH_WheelSettingsWV_GetMutable_mMaxBrakeTorque(_UnderlyingPtr);
            }
        }

        ///< How much torque (Nm) the hand brake can apply to this wheel (usually only applied to the rear wheels)
        public new unsafe ref float mMaxHandBrakeTorque
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mMaxHandBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mMaxHandBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_GetMutable_mMaxHandBrakeTorque(_Underlying *_this);
                return ref *__JPH_WheelSettingsWV_GetMutable_mMaxHandBrakeTorque(_UnderlyingPtr);
            }
        }

        ///< Attachment point of wheel suspension in local space of the body
        public new unsafe JPH.Vec3 mPosition
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettingsWV_GetMutable_mPosition(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettingsWV_GetMutable_mPosition(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettingsWV_GetMutable_mSuspensionForcePoint(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettingsWV_GetMutable_mSuspensionForcePoint(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mSuspensionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mSuspensionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettingsWV_GetMutable_mSuspensionDirection(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettingsWV_GetMutable_mSuspensionDirection(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mSteeringAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mSteeringAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettingsWV_GetMutable_mSteeringAxis(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettingsWV_GetMutable_mSteeringAxis(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mWheelUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mWheelUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettingsWV_GetMutable_mWheelUp(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettingsWV_GetMutable_mWheelUp(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mWheelForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mWheelForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_WheelSettingsWV_GetMutable_mWheelForward(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_WheelSettingsWV_GetMutable_mWheelForward(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mSuspensionMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mSuspensionMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_GetMutable_mSuspensionMinLength(_Underlying *_this);
                return ref *__JPH_WheelSettingsWV_GetMutable_mSuspensionMinLength(_UnderlyingPtr);
            }
        }

        ///< How long the suspension is in max droop position relative to the attachment point (m)
        public new unsafe ref float mSuspensionMaxLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mSuspensionMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mSuspensionMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_GetMutable_mSuspensionMaxLength(_Underlying *_this);
                return ref *__JPH_WheelSettingsWV_GetMutable_mSuspensionMaxLength(_UnderlyingPtr);
            }
        }

        ///< The natural length (m) of the suspension spring is defined as mSuspensionMaxLength + mSuspensionPreloadLength. Can be used to preload the suspension as the spring is compressed by mSuspensionPreloadLength when the suspension is in max droop position. Note that this means when the vehicle touches the ground there is a discontinuity so it will also make the vehicle more bouncy as we're updating with discrete time steps.
        public new unsafe ref float mSuspensionPreloadLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mSuspensionPreloadLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mSuspensionPreloadLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_GetMutable_mSuspensionPreloadLength(_Underlying *_this);
                return ref *__JPH_WheelSettingsWV_GetMutable_mSuspensionPreloadLength(_UnderlyingPtr);
            }
        }

        ///< Settings for the suspension spring
        public new unsafe JPH.SpringSettings mSuspensionSpring
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mSuspensionSpring", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mSuspensionSpring", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SpringSettings._Underlying *__JPH_WheelSettingsWV_GetMutable_mSuspensionSpring(_Underlying *_this);
                JPH.SpringSettings __ret;
                __ret = new(__JPH_WheelSettingsWV_GetMutable_mSuspensionSpring(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_GetMutable_mRadius(_Underlying *_this);
                return ref *__JPH_WheelSettingsWV_GetMutable_mRadius(_UnderlyingPtr);
            }
        }

        ///< Width of the wheel (m)
        public new unsafe ref float mWidth
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mWidth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mWidth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelSettingsWV_GetMutable_mWidth(_Underlying *_this);
                return ref *__JPH_WheelSettingsWV_GetMutable_mWidth(_UnderlyingPtr);
            }
        }

        ///< Enables mSuspensionForcePoint, if disabled, the forces are applied at the collision contact point. This leads to a more accurate simulation when interacting with dynamic objects but makes the vehicle less stable. When setting this to true, all forces will be applied to a fixed point on the vehicle body.
        public new unsafe ref bool mEnableSuspensionForcePoint
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mEnableSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_GetMutable_mEnableSuspensionForcePoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_WheelSettingsWV_GetMutable_mEnableSuspensionForcePoint(_Underlying *_this);
                return ref *__JPH_WheelSettingsWV_GetMutable_mEnableSuspensionForcePoint(_UnderlyingPtr);
            }
        }

        internal unsafe WheelSettingsWV(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe WheelSettingsWV() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettingsWV._Underlying *__JPH_WheelSettingsWV_DefaultConstruct();
            _UnderlyingPtr = __JPH_WheelSettingsWV_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_AddRef(__JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::WheelSettingsWV::WheelSettingsWV`.
        public unsafe WheelSettingsWV(JPH._ByValue_WheelSettingsWV _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettingsWV._Underlying *__JPH_WheelSettingsWV_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.WheelSettingsWV._Underlying *_other);
            _UnderlyingPtr = __JPH_WheelSettingsWV_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_WheelSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_WheelSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_WheelSettings_AddRef(__JPH_WheelSettingsWV_UpcastTo_JPH_RefTarget_JPH_WheelSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::WheelSettingsWV::WheelSettingsWV`.
        public WheelSettingsWV(Const_WheelSettingsWV _other) : this(new _ByValue_WheelSettingsWV(_other)) {}

        /// Generated from constructor `JPH::WheelSettingsWV::WheelSettingsWV`.
        public WheelSettingsWV(WheelSettingsWV _other) : this((Const_WheelSettingsWV)_other) {}

        /// Generated from method `JPH::WheelSettingsWV::operator=`.
        public unsafe JPH.WheelSettingsWV Assign(JPH._ByValue_WheelSettingsWV _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelSettingsWV_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelSettingsWV_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelSettingsWV._Underlying *__JPH_WheelSettingsWV_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.WheelSettingsWV._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_WheelSettingsWV_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `WheelSettingsWV` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `WheelSettingsWV`/`Const_WheelSettingsWV` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_WheelSettingsWV
    {
        #pragma warning disable CS0649
        internal readonly Const_WheelSettingsWV? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_WheelSettingsWV() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_WheelSettingsWV(Const_WheelSettingsWV new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_WheelSettingsWV(Const_WheelSettingsWV arg) {return new(arg);}
        public _ByValue_WheelSettingsWV(JPH._Moved<WheelSettingsWV> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_WheelSettingsWV(JPH._Moved<WheelSettingsWV> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `WheelSettingsWV` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_WheelSettingsWV`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `WheelSettingsWV`/`Const_WheelSettingsWV` directly.
    public class _InOptMut_WheelSettingsWV
    {
        public WheelSettingsWV? Opt;

        public _InOptMut_WheelSettingsWV() {}
        public _InOptMut_WheelSettingsWV(WheelSettingsWV value) {Opt = value;}
        public static implicit operator _InOptMut_WheelSettingsWV(WheelSettingsWV value) {return new(value);}
    }

    /// This is used for optional parameters of class `WheelSettingsWV` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_WheelSettingsWV`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `WheelSettingsWV`/`Const_WheelSettingsWV` to pass it to the function.
    public class _InOptConst_WheelSettingsWV
    {
        public Const_WheelSettingsWV? Opt;

        public _InOptConst_WheelSettingsWV() {}
        public _InOptConst_WheelSettingsWV(Const_WheelSettingsWV value) {Opt = value;}
        public static implicit operator _InOptConst_WheelSettingsWV(Const_WheelSettingsWV value) {return new(value);}
    }

    /// Wheel object specifically for WheeledVehicleController
    /// Generated from class `JPH::WheelWV`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Wheel`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_WheelWV : JPH.Object<Const_WheelWV>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelWV_Destroy(_Underlying *_this);
            __JPH_WheelWV_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_WheelWV() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_WheelWV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_WheelWV_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_WheelWV_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Wheel(Const_WheelWV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_UpcastTo_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_UpcastTo_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Wheel._Underlying *__JPH_WheelWV_UpcastTo_JPH_Wheel(_Underlying *_this);
            JPH.Const_Wheel ret = new(__JPH_WheelWV_UpcastTo_JPH_Wheel(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_WheelWV(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelWV_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_WheelWV ret = new(__JPH_WheelWV_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_WheelWV(JPH.Const_Wheel parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_StaticDowncastFrom_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_StaticDowncastFrom_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelWV_StaticDowncastFrom_JPH_Wheel(JPH.Const_Wheel._Underlying *_this);
            Const_WheelWV ret = new(__JPH_WheelWV_StaticDowncastFrom_JPH_Wheel(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Velocity difference between ground and wheel relative to ground velocity
        public unsafe float mLongitudinalSlip
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_Get_mLongitudinalSlip", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_Get_mLongitudinalSlip", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelWV_Get_mLongitudinalSlip(_Underlying *_this);
                return *__JPH_WheelWV_Get_mLongitudinalSlip(_UnderlyingPtr);
            }
        }

        ///< Angular difference (in radians) between ground and wheel relative to ground velocity
        public unsafe float mLateralSlip
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_Get_mLateralSlip", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_Get_mLateralSlip", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelWV_Get_mLateralSlip(_Underlying *_this);
                return *__JPH_WheelWV_Get_mLateralSlip(_UnderlyingPtr);
            }
        }

        ///< Combined friction coefficient in longitudinal direction (combines terrain and tires)
        public unsafe float mCombinedLongitudinalFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_Get_mCombinedLongitudinalFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_Get_mCombinedLongitudinalFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelWV_Get_mCombinedLongitudinalFriction(_Underlying *_this);
                return *__JPH_WheelWV_Get_mCombinedLongitudinalFriction(_UnderlyingPtr);
            }
        }

        ///< Combined friction coefficient in lateral direction (combines terrain and tires)
        public unsafe float mCombinedLateralFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_Get_mCombinedLateralFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_Get_mCombinedLateralFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelWV_Get_mCombinedLateralFriction(_Underlying *_this);
                return *__JPH_WheelWV_Get_mCombinedLateralFriction(_UnderlyingPtr);
            }
        }

        ///< Amount of impulse that the brakes can apply to the floor (excluding friction)
        public unsafe float mBrakeImpulse
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_Get_mBrakeImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_Get_mBrakeImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelWV_Get_mBrakeImpulse(_Underlying *_this);
                return *__JPH_WheelWV_Get_mBrakeImpulse(_UnderlyingPtr);
            }
        }

        internal unsafe Const_WheelWV(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// Generated from constructor `JPH::WheelWV::WheelWV`.
        public unsafe Const_WheelWV(JPH.Const_WheelSettingsWV inWheel) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelWV._Underlying *__JPH_WheelWV_Construct(JPH.Const_WheelSettingsWV._Underlying *inWheel);
            _UnderlyingPtr = __JPH_WheelWV_Construct(inWheel._UnderlyingPtr);
        }

        /// Generated from method `JPH::WheelWV::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_WheelWV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_WheelWV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_WheelWV_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_WheelWV_size_t(inCount);
        }

        /// Generated from method `JPH::WheelWV::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelWV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelWV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelWV_void_ptr(void *inPointer);
            __Jolt_delete_JPH_WheelWV_void_ptr(inPointer);
        }

        /// Generated from method `JPH::WheelWV::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelWV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelWV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelWV_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_WheelWV_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::WheelWV::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_WheelWV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_WheelWV_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_WheelWV_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_WheelWV_size_t(inCount);
        }

        /// Generated from method `JPH::WheelWV::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelWV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelWV_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelWV_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_WheelWV_void_ptr(inPointer);
        }

        /// Generated from method `JPH::WheelWV::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelWV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelWV_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelWV_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_WheelWV_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::WheelWV::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_WheelWV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_WheelWV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_WheelWV_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_WheelWV_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::WheelWV::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheelWV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheelWV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheelWV_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_WheelWV_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::WheelWV::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_WheelWV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_WheelWV_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_WheelWV_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_WheelWV_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::WheelWV::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelWV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheelWV_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheelWV_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_WheelWV_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Override GetSettings and cast to the correct class
        /// Generated from method `JPH::WheelWV::GetSettings`.
        public unsafe JPH.Const_WheelSettingsWV? GetSettings()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_WheelSettingsWV._Underlying *__JPH_WheelWV_GetSettings(_Underlying *_this);
            var __c_ret = __JPH_WheelWV_GetSettings(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_WheelSettingsWV(__c_ret, is_owning: false) : null;
        }

        /// Get the angular velocity (rad/s) for this wheel, note that positive means the wheel is rotating such that the car moves forward
        /// Generated from method `JPH::WheelWV::GetAngularVelocity`.
        public unsafe float GetAngularVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheelWV_GetAngularVelocity(_Underlying *_this);
            return __JPH_WheelWV_GetAngularVelocity(_UnderlyingPtr);
        }

        /// Get the current rotation angle of the wheel in radians [0, 2 pi]
        /// Generated from method `JPH::WheelWV::GetRotationAngle`.
        public unsafe float GetRotationAngle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetRotationAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetRotationAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheelWV_GetRotationAngle(_Underlying *_this);
            return __JPH_WheelWV_GetRotationAngle(_UnderlyingPtr);
        }

        /// Get the current steer angle of the wheel in radians [-pi, pi], positive is to the left
        /// Generated from method `JPH::WheelWV::GetSteerAngle`.
        public unsafe float GetSteerAngle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheelWV_GetSteerAngle(_Underlying *_this);
            return __JPH_WheelWV_GetSteerAngle(_UnderlyingPtr);
        }

        /// Returns true if the wheel is touching an object
        /// Generated from method `JPH::WheelWV::HasContact`.
        public unsafe bool HasContact()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_HasContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_HasContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_WheelWV_HasContact(_Underlying *_this);
            return __JPH_WheelWV_HasContact(_UnderlyingPtr) != 0;
        }

        /// Returns the body ID of the body that this wheel is touching
        /// Generated from method `JPH::WheelWV::GetContactBodyID`.
        public unsafe JPH.BodyID GetContactBodyID()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetContactBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetContactBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID __JPH_WheelWV_GetContactBodyID(_Underlying *_this);
            return __JPH_WheelWV_GetContactBodyID(_UnderlyingPtr);
        }

        /// Returns the sub shape ID where we're contacting the body
        /// Generated from method `JPH::WheelWV::GetContactSubShapeID`.
        public unsafe JPH.SubShapeID GetContactSubShapeID()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetContactSubShapeID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetContactSubShapeID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SubShapeID._Underlying *__JPH_WheelWV_GetContactSubShapeID(_Underlying *_this);
            return new(__JPH_WheelWV_GetContactSubShapeID(_UnderlyingPtr), is_owning: true);
        }

        /// Returns the current contact position in world space (note by the time you call this the vehicle has moved)
        /// Generated from method `JPH::WheelWV::GetContactPosition`.
        public unsafe JPH.Vec3 GetContactPosition()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetContactPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetContactPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_WheelWV_GetContactPosition(_Underlying *_this);
            return new(__JPH_WheelWV_GetContactPosition(_UnderlyingPtr), is_owning: true);
        }

        /// Velocity of the contact point (m / s, not relative to the wheel but in world space)
        /// Generated from method `JPH::WheelWV::GetContactPointVelocity`.
        public unsafe JPH.Vec3 GetContactPointVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetContactPointVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetContactPointVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_WheelWV_GetContactPointVelocity(_Underlying *_this);
            return new(__JPH_WheelWV_GetContactPointVelocity(_UnderlyingPtr), is_owning: true);
        }

        /// Returns the current contact normal in world space (note by the time you call this the vehicle has moved)
        /// Generated from method `JPH::WheelWV::GetContactNormal`.
        public unsafe JPH.Vec3 GetContactNormal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetContactNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetContactNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_WheelWV_GetContactNormal(_Underlying *_this);
            return new(__JPH_WheelWV_GetContactNormal(_UnderlyingPtr), is_owning: true);
        }

        /// Returns longitudinal direction (direction along the wheel relative to floor) in world space (note by the time you call this the vehicle has moved)
        /// Generated from method `JPH::WheelWV::GetContactLongitudinal`.
        public unsafe JPH.Vec3 GetContactLongitudinal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetContactLongitudinal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetContactLongitudinal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_WheelWV_GetContactLongitudinal(_Underlying *_this);
            return new(__JPH_WheelWV_GetContactLongitudinal(_UnderlyingPtr), is_owning: true);
        }

        /// Returns lateral direction (sideways direction) in world space (note by the time you call this the vehicle has moved)
        /// Generated from method `JPH::WheelWV::GetContactLateral`.
        public unsafe JPH.Vec3 GetContactLateral()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetContactLateral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetContactLateral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_WheelWV_GetContactLateral(_Underlying *_this);
            return new(__JPH_WheelWV_GetContactLateral(_UnderlyingPtr), is_owning: true);
        }

        /// Get the length of the suspension for a wheel (m) relative to the suspension attachment point (hard point)
        /// Generated from method `JPH::WheelWV::GetSuspensionLength`.
        public unsafe float GetSuspensionLength()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetSuspensionLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetSuspensionLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheelWV_GetSuspensionLength(_Underlying *_this);
            return __JPH_WheelWV_GetSuspensionLength(_UnderlyingPtr);
        }

        /// Check if the suspension hit its upper limit
        /// Generated from method `JPH::WheelWV::HasHitHardPoint`.
        public unsafe bool HasHitHardPoint()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_HasHitHardPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_HasHitHardPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_WheelWV_HasHitHardPoint(_Underlying *_this);
            return __JPH_WheelWV_HasHitHardPoint(_UnderlyingPtr) != 0;
        }

        /// Get the total impulse (N s) that was applied by the suspension
        /// Generated from method `JPH::WheelWV::GetSuspensionLambda`.
        public unsafe float GetSuspensionLambda()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetSuspensionLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetSuspensionLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheelWV_GetSuspensionLambda(_Underlying *_this);
            return __JPH_WheelWV_GetSuspensionLambda(_UnderlyingPtr);
        }

        /// Get total impulse (N s) applied along the forward direction of the wheel
        /// Generated from method `JPH::WheelWV::GetLongitudinalLambda`.
        public unsafe float GetLongitudinalLambda()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetLongitudinalLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetLongitudinalLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheelWV_GetLongitudinalLambda(_Underlying *_this);
            return __JPH_WheelWV_GetLongitudinalLambda(_UnderlyingPtr);
        }

        /// Get total impulse (N s) applied along the sideways direction of the wheel
        /// Generated from method `JPH::WheelWV::GetLateralLambda`.
        public unsafe float GetLateralLambda()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetLateralLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetLateralLambda", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheelWV_GetLateralLambda(_Underlying *_this);
            return __JPH_WheelWV_GetLateralLambda(_UnderlyingPtr);
        }
    }

    /// Wheel object specifically for WheeledVehicleController
    /// Generated from class `JPH::WheelWV`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Wheel`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class WheelWV : Const_WheelWV
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(WheelWV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_WheelWV_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_WheelWV_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Wheel(WheelWV self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_UpcastTo_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_UpcastTo_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Wheel._Underlying *__JPH_WheelWV_UpcastTo_JPH_Wheel(_Underlying *_this);
            JPH.Wheel ret = new(__JPH_WheelWV_UpcastTo_JPH_Wheel(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator WheelWV(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelWV_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            WheelWV ret = new(__JPH_WheelWV_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator WheelWV(JPH.Wheel parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_StaticDowncastFrom_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_StaticDowncastFrom_JPH_Wheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheelWV_StaticDowncastFrom_JPH_Wheel(JPH.Wheel._Underlying *_this);
            WheelWV ret = new(__JPH_WheelWV_StaticDowncastFrom_JPH_Wheel(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Velocity difference between ground and wheel relative to ground velocity
        public new unsafe ref float mLongitudinalSlip
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetMutable_mLongitudinalSlip", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetMutable_mLongitudinalSlip", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelWV_GetMutable_mLongitudinalSlip(_Underlying *_this);
                return ref *__JPH_WheelWV_GetMutable_mLongitudinalSlip(_UnderlyingPtr);
            }
        }

        ///< Angular difference (in radians) between ground and wheel relative to ground velocity
        public new unsafe ref float mLateralSlip
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetMutable_mLateralSlip", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetMutable_mLateralSlip", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelWV_GetMutable_mLateralSlip(_Underlying *_this);
                return ref *__JPH_WheelWV_GetMutable_mLateralSlip(_UnderlyingPtr);
            }
        }

        ///< Combined friction coefficient in longitudinal direction (combines terrain and tires)
        public new unsafe ref float mCombinedLongitudinalFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetMutable_mCombinedLongitudinalFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetMutable_mCombinedLongitudinalFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelWV_GetMutable_mCombinedLongitudinalFriction(_Underlying *_this);
                return ref *__JPH_WheelWV_GetMutable_mCombinedLongitudinalFriction(_UnderlyingPtr);
            }
        }

        ///< Combined friction coefficient in lateral direction (combines terrain and tires)
        public new unsafe ref float mCombinedLateralFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetMutable_mCombinedLateralFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetMutable_mCombinedLateralFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelWV_GetMutable_mCombinedLateralFriction(_Underlying *_this);
                return ref *__JPH_WheelWV_GetMutable_mCombinedLateralFriction(_UnderlyingPtr);
            }
        }

        ///< Amount of impulse that the brakes can apply to the floor (excluding friction)
        public new unsafe ref float mBrakeImpulse
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_GetMutable_mBrakeImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_GetMutable_mBrakeImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheelWV_GetMutable_mBrakeImpulse(_Underlying *_this);
                return ref *__JPH_WheelWV_GetMutable_mBrakeImpulse(_UnderlyingPtr);
            }
        }

        internal unsafe WheelWV(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// Generated from constructor `JPH::WheelWV::WheelWV`.
        public unsafe WheelWV(JPH.Const_WheelSettingsWV inWheel) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheelWV._Underlying *__JPH_WheelWV_Construct(JPH.Const_WheelSettingsWV._Underlying *inWheel);
            _UnderlyingPtr = __JPH_WheelWV_Construct(inWheel._UnderlyingPtr);
        }

        /// Apply a torque (N m) to the wheel for a particular delta time
        /// Generated from method `JPH::WheelWV::ApplyTorque`.
        public unsafe void ApplyTorque(float inTorque, float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_ApplyTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_ApplyTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelWV_ApplyTorque(_Underlying *_this, float inTorque, float inDeltaTime);
            __JPH_WheelWV_ApplyTorque(_UnderlyingPtr, inTorque, inDeltaTime);
        }

        /// Update the wheel rotation based on the current angular velocity
        /// Generated from method `JPH::WheelWV::Update`.
        public unsafe void Update(uint inWheelIndex, float inDeltaTime, JPH.Const_VehicleConstraint inConstraint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_Update", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_Update", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelWV_Update(_Underlying *_this, uint inWheelIndex, float inDeltaTime, JPH.Const_VehicleConstraint._Underlying *inConstraint);
            __JPH_WheelWV_Update(_UnderlyingPtr, inWheelIndex, inDeltaTime, inConstraint._UnderlyingPtr);
        }

        /// Update the angular velocity (rad/s)
        /// Generated from method `JPH::WheelWV::SetAngularVelocity`.
        public unsafe void SetAngularVelocity(float inVel)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelWV_SetAngularVelocity(_Underlying *_this, float inVel);
            __JPH_WheelWV_SetAngularVelocity(_UnderlyingPtr, inVel);
        }

        /// Set the current rotation angle of the wheel in radians [0, 2 pi]
        /// Generated from method `JPH::WheelWV::SetRotationAngle`.
        public unsafe void SetRotationAngle(float inAngle)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_SetRotationAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_SetRotationAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelWV_SetRotationAngle(_Underlying *_this, float inAngle);
            __JPH_WheelWV_SetRotationAngle(_UnderlyingPtr, inAngle);
        }

        /// Set the current steer angle of the wheel in radians [-pi, pi]
        /// Generated from method `JPH::WheelWV::SetSteerAngle`.
        public unsafe void SetSteerAngle(float inAngle)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_SetSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_SetSteerAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheelWV_SetSteerAngle(_Underlying *_this, float inAngle);
            __JPH_WheelWV_SetSteerAngle(_UnderlyingPtr, inAngle);
        }

        /// Internal function that should only be called by the controller. Used to apply impulses in the forward direction of the vehicle.
        /// Generated from method `JPH::WheelWV::SolveLongitudinalConstraintPart`.
        public unsafe bool SolveLongitudinalConstraintPart(JPH.Const_VehicleConstraint inConstraint, float inMinImpulse, float inMaxImpulse)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_SolveLongitudinalConstraintPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_SolveLongitudinalConstraintPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_WheelWV_SolveLongitudinalConstraintPart(_Underlying *_this, JPH.Const_VehicleConstraint._Underlying *inConstraint, float inMinImpulse, float inMaxImpulse);
            return __JPH_WheelWV_SolveLongitudinalConstraintPart(_UnderlyingPtr, inConstraint._UnderlyingPtr, inMinImpulse, inMaxImpulse) != 0;
        }

        /// Internal function that should only be called by the controller. Used to apply impulses in the sideways direction of the vehicle.
        /// Generated from method `JPH::WheelWV::SolveLateralConstraintPart`.
        public unsafe bool SolveLateralConstraintPart(JPH.Const_VehicleConstraint inConstraint, float inMinImpulse, float inMaxImpulse)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheelWV_SolveLateralConstraintPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheelWV_SolveLateralConstraintPart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_WheelWV_SolveLateralConstraintPart(_Underlying *_this, JPH.Const_VehicleConstraint._Underlying *inConstraint, float inMinImpulse, float inMaxImpulse);
            return __JPH_WheelWV_SolveLateralConstraintPart(_UnderlyingPtr, inConstraint._UnderlyingPtr, inMinImpulse, inMaxImpulse) != 0;
        }
    }

    /// This is used for optional parameters of class `WheelWV` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_WheelWV`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `WheelWV`/`Const_WheelWV` directly.
    public class _InOptMut_WheelWV
    {
        public WheelWV? Opt;

        public _InOptMut_WheelWV() {}
        public _InOptMut_WheelWV(WheelWV value) {Opt = value;}
        public static implicit operator _InOptMut_WheelWV(WheelWV value) {return new(value);}
    }

    /// This is used for optional parameters of class `WheelWV` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_WheelWV`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `WheelWV`/`Const_WheelWV` to pass it to the function.
    public class _InOptConst_WheelWV
    {
        public Const_WheelWV? Opt;

        public _InOptConst_WheelWV() {}
        public _InOptConst_WheelWV(Const_WheelWV value) {Opt = value;}
        public static implicit operator _InOptConst_WheelWV(Const_WheelWV value) {return new(value);}
    }

    /// Settings of a vehicle with regular wheels
    ///
    /// The properties in this controller are largely based on "Car Physics for Games" by Marco Monster.
    /// See: https://www.asawicki.info/Mirror/Car%20Physics%20for%20Games/Car%20Physics%20for%20Games.html
    /// Generated from class `JPH::WheeledVehicleControllerSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleControllerSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::VehicleControllerSettings>`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::MotorcycleControllerSettings`
    /// This is the const half of the class.
    public class Const_WheeledVehicleControllerSettings : JPH.Object<Const_WheeledVehicleControllerSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_Release(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_Release(__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_WheeledVehicleControllerSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_WheeledVehicleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHVehicleControllerSettings(Const_WheeledVehicleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHVehicleControllerSettings._Underlying *__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHVehicleControllerSettings ret = new(__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_VehicleControllerSettings(Const_WheeledVehicleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleControllerSettings._Underlying *__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(_Underlying *_this);
            JPH.Const_VehicleControllerSettings ret = new(__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_WheeledVehicleControllerSettings(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            Const_WheeledVehicleControllerSettings ret = new(__JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_WheeledVehicleControllerSettings(JPH.Const_RefTarget_JPHVehicleControllerSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(JPH.Const_RefTarget_JPHVehicleControllerSettings._Underlying *_this);
            Const_WheeledVehicleControllerSettings ret = new(__JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_WheeledVehicleControllerSettings(JPH.Const_VehicleControllerSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(JPH.Const_VehicleControllerSettings._Underlying *_this);
            Const_WheeledVehicleControllerSettings ret = new(__JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< The properties of the engine
        public unsafe JPH.Const_VehicleEngineSettings mEngine
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_Get_mEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_Get_mEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_VehicleEngineSettings._Underlying *__JPH_WheeledVehicleControllerSettings_Get_mEngine(_Underlying *_this);
                JPH.Const_VehicleEngineSettings __ret;
                __ret = new(__JPH_WheeledVehicleControllerSettings_Get_mEngine(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_Get_mTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_Get_mTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_VehicleTransmissionSettings._Underlying *__JPH_WheeledVehicleControllerSettings_Get_mTransmission(_Underlying *_this);
                JPH.Const_VehicleTransmissionSettings __ret;
                __ret = new(__JPH_WheeledVehicleControllerSettings_Get_mTransmission(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< List of differentials and their properties
        public unsafe JPH.Const_Array_JPHVehicleDifferentialSettings mDifferentials
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_Get_mDifferentials", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_Get_mDifferentials", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Array_JPHVehicleDifferentialSettings._Underlying *__JPH_WheeledVehicleControllerSettings_Get_mDifferentials(_Underlying *_this);
                JPH.Const_Array_JPHVehicleDifferentialSettings __ret;
                __ret = new(__JPH_WheeledVehicleControllerSettings_Get_mDifferentials(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Ratio max / min average wheel speed of each differential (measured at the clutch). When the ratio is exceeded all torque gets distributed to the differential with the minimal average velocity. This allows implementing a limited slip differential between differentials. Set to FLT_MAX for an open differential. Value should be > 1.
        public unsafe float mDifferentialLimitedSlipRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_Get_mDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_Get_mDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheeledVehicleControllerSettings_Get_mDifferentialLimitedSlipRatio(_Underlying *_this);
                return *__JPH_WheeledVehicleControllerSettings_Get_mDifferentialLimitedSlipRatio(_UnderlyingPtr);
            }
        }

        internal unsafe Const_WheeledVehicleControllerSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_WheeledVehicleControllerSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheeledVehicleControllerSettings._Underlying *__JPH_WheeledVehicleControllerSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_WheeledVehicleControllerSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::WheeledVehicleControllerSettings::WheeledVehicleControllerSettings`.
        public unsafe Const_WheeledVehicleControllerSettings(JPH._ByValue_WheeledVehicleControllerSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheeledVehicleControllerSettings._Underlying *__JPH_WheeledVehicleControllerSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.WheeledVehicleControllerSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_WheeledVehicleControllerSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::WheeledVehicleControllerSettings::WheeledVehicleControllerSettings`.
        public Const_WheeledVehicleControllerSettings(Const_WheeledVehicleControllerSettings _other) : this(new _ByValue_WheeledVehicleControllerSettings(_other)) {}

        /// Generated from constructor `JPH::WheeledVehicleControllerSettings::WheeledVehicleControllerSettings`.
        public Const_WheeledVehicleControllerSettings(WheeledVehicleControllerSettings _other) : this((Const_WheeledVehicleControllerSettings)_other) {}

        /// Generated from method `JPH::WheeledVehicleControllerSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_WheeledVehicleControllerSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_WheeledVehicleControllerSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_WheeledVehicleControllerSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_WheeledVehicleControllerSettings_size_t(inCount);
        }

        /// Generated from method `JPH::WheeledVehicleControllerSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::WheeledVehicleControllerSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::WheeledVehicleControllerSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_WheeledVehicleControllerSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_WheeledVehicleControllerSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_WheeledVehicleControllerSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_WheeledVehicleControllerSettings_size_t(inCount);
        }

        /// Generated from method `JPH::WheeledVehicleControllerSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::WheeledVehicleControllerSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::WheeledVehicleControllerSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_WheeledVehicleControllerSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_WheeledVehicleControllerSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_WheeledVehicleControllerSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_WheeledVehicleControllerSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::WheeledVehicleControllerSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_WheeledVehicleControllerSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::WheeledVehicleControllerSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_WheeledVehicleControllerSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_WheeledVehicleControllerSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_WheeledVehicleControllerSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_WheeledVehicleControllerSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::WheeledVehicleControllerSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_WheeledVehicleControllerSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        // See: VehicleControllerSettings
        /// Generated from method `JPH::WheeledVehicleControllerSettings::ConstructController`.
        public unsafe JPH.VehicleController? ConstructController(JPH.VehicleConstraint inConstraint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_ConstructController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_ConstructController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleController._Underlying *__JPH_WheeledVehicleControllerSettings_ConstructController(_Underlying *_this, JPH.VehicleConstraint._Underlying *inConstraint);
            var __c_ret = __JPH_WheeledVehicleControllerSettings_ConstructController(_UnderlyingPtr, inConstraint._UnderlyingPtr);
            return __c_ret is not null ? new JPH.VehicleController(__c_ret, is_owning: false) : null;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::WheeledVehicleControllerSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheeledVehicleControllerSettings_SetEmbedded(_Underlying *_this);
            __JPH_WheeledVehicleControllerSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::WheeledVehicleControllerSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_WheeledVehicleControllerSettings_GetRefCount(_Underlying *_this);
            return __JPH_WheeledVehicleControllerSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::WheeledVehicleControllerSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheeledVehicleControllerSettings_AddRef(_Underlying *_this);
            __JPH_WheeledVehicleControllerSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::WheeledVehicleControllerSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheeledVehicleControllerSettings_Release(_Underlying *_this);
            __JPH_WheeledVehicleControllerSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::WheeledVehicleControllerSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_WheeledVehicleControllerSettings_sInternalGetRefCountOffset();
            return __JPH_WheeledVehicleControllerSettings_sInternalGetRefCountOffset();
        }
    }

    /// Settings of a vehicle with regular wheels
    ///
    /// The properties in this controller are largely based on "Car Physics for Games" by Marco Monster.
    /// See: https://www.asawicki.info/Mirror/Car%20Physics%20for%20Games/Car%20Physics%20for%20Games.html
    /// Generated from class `JPH::WheeledVehicleControllerSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleControllerSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::VehicleControllerSettings>`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::MotorcycleControllerSettings`
    /// This is the non-const half of the class.
    public class WheeledVehicleControllerSettings : Const_WheeledVehicleControllerSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(WheeledVehicleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.RefTarget_JPHVehicleControllerSettings(WheeledVehicleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleControllerSettings._Underlying *__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            JPH.RefTarget_JPHVehicleControllerSettings ret = new(__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.VehicleControllerSettings(WheeledVehicleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleControllerSettings._Underlying *__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(_Underlying *_this);
            JPH.VehicleControllerSettings ret = new(__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator WheeledVehicleControllerSettings(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            WheeledVehicleControllerSettings ret = new(__JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator WheeledVehicleControllerSettings(JPH.RefTarget_JPHVehicleControllerSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(JPH.RefTarget_JPHVehicleControllerSettings._Underlying *_this);
            WheeledVehicleControllerSettings ret = new(__JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator WheeledVehicleControllerSettings(JPH.VehicleControllerSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(JPH.VehicleControllerSettings._Underlying *_this);
            WheeledVehicleControllerSettings ret = new(__JPH_WheeledVehicleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< The properties of the engine
        public new unsafe JPH.VehicleEngineSettings mEngine
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_GetMutable_mEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_GetMutable_mEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.VehicleEngineSettings._Underlying *__JPH_WheeledVehicleControllerSettings_GetMutable_mEngine(_Underlying *_this);
                JPH.VehicleEngineSettings __ret;
                __ret = new(__JPH_WheeledVehicleControllerSettings_GetMutable_mEngine(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_GetMutable_mTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_GetMutable_mTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.VehicleTransmissionSettings._Underlying *__JPH_WheeledVehicleControllerSettings_GetMutable_mTransmission(_Underlying *_this);
                JPH.VehicleTransmissionSettings __ret;
                __ret = new(__JPH_WheeledVehicleControllerSettings_GetMutable_mTransmission(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< List of differentials and their properties
        public new unsafe JPH.Array_JPHVehicleDifferentialSettings mDifferentials
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_GetMutable_mDifferentials", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_GetMutable_mDifferentials", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Array_JPHVehicleDifferentialSettings._Underlying *__JPH_WheeledVehicleControllerSettings_GetMutable_mDifferentials(_Underlying *_this);
                JPH.Array_JPHVehicleDifferentialSettings __ret;
                __ret = new(__JPH_WheeledVehicleControllerSettings_GetMutable_mDifferentials(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Ratio max / min average wheel speed of each differential (measured at the clutch). When the ratio is exceeded all torque gets distributed to the differential with the minimal average velocity. This allows implementing a limited slip differential between differentials. Set to FLT_MAX for an open differential. Value should be > 1.
        public new unsafe ref float mDifferentialLimitedSlipRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_GetMutable_mDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_GetMutable_mDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_WheeledVehicleControllerSettings_GetMutable_mDifferentialLimitedSlipRatio(_Underlying *_this);
                return ref *__JPH_WheeledVehicleControllerSettings_GetMutable_mDifferentialLimitedSlipRatio(_UnderlyingPtr);
            }
        }

        internal unsafe WheeledVehicleControllerSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe WheeledVehicleControllerSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheeledVehicleControllerSettings._Underlying *__JPH_WheeledVehicleControllerSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_WheeledVehicleControllerSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::WheeledVehicleControllerSettings::WheeledVehicleControllerSettings`.
        public unsafe WheeledVehicleControllerSettings(JPH._ByValue_WheeledVehicleControllerSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheeledVehicleControllerSettings._Underlying *__JPH_WheeledVehicleControllerSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.WheeledVehicleControllerSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_WheeledVehicleControllerSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(__JPH_WheeledVehicleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::WheeledVehicleControllerSettings::WheeledVehicleControllerSettings`.
        public WheeledVehicleControllerSettings(Const_WheeledVehicleControllerSettings _other) : this(new _ByValue_WheeledVehicleControllerSettings(_other)) {}

        /// Generated from constructor `JPH::WheeledVehicleControllerSettings::WheeledVehicleControllerSettings`.
        public WheeledVehicleControllerSettings(WheeledVehicleControllerSettings _other) : this((Const_WheeledVehicleControllerSettings)_other) {}

        /// Generated from method `JPH::WheeledVehicleControllerSettings::operator=`.
        public unsafe JPH.WheeledVehicleControllerSettings Assign(JPH._ByValue_WheeledVehicleControllerSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleControllerSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheeledVehicleControllerSettings._Underlying *__JPH_WheeledVehicleControllerSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.WheeledVehicleControllerSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_WheeledVehicleControllerSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `WheeledVehicleControllerSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `WheeledVehicleControllerSettings`/`Const_WheeledVehicleControllerSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_WheeledVehicleControllerSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_WheeledVehicleControllerSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_WheeledVehicleControllerSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_WheeledVehicleControllerSettings(Const_WheeledVehicleControllerSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_WheeledVehicleControllerSettings(Const_WheeledVehicleControllerSettings arg) {return new(arg);}
        public _ByValue_WheeledVehicleControllerSettings(JPH._Moved<WheeledVehicleControllerSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_WheeledVehicleControllerSettings(JPH._Moved<WheeledVehicleControllerSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `WheeledVehicleControllerSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_WheeledVehicleControllerSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `WheeledVehicleControllerSettings`/`Const_WheeledVehicleControllerSettings` directly.
    public class _InOptMut_WheeledVehicleControllerSettings
    {
        public WheeledVehicleControllerSettings? Opt;

        public _InOptMut_WheeledVehicleControllerSettings() {}
        public _InOptMut_WheeledVehicleControllerSettings(WheeledVehicleControllerSettings value) {Opt = value;}
        public static implicit operator _InOptMut_WheeledVehicleControllerSettings(WheeledVehicleControllerSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `WheeledVehicleControllerSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_WheeledVehicleControllerSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `WheeledVehicleControllerSettings`/`Const_WheeledVehicleControllerSettings` to pass it to the function.
    public class _InOptConst_WheeledVehicleControllerSettings
    {
        public Const_WheeledVehicleControllerSettings? Opt;

        public _InOptConst_WheeledVehicleControllerSettings() {}
        public _InOptConst_WheeledVehicleControllerSettings(Const_WheeledVehicleControllerSettings value) {Opt = value;}
        public static implicit operator _InOptConst_WheeledVehicleControllerSettings(Const_WheeledVehicleControllerSettings value) {return new(value);}
    }

    /// Runtime controller class
    /// Generated from class `JPH::WheeledVehicleController`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleController`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::MotorcycleController`
    /// This is the const half of the class.
    public class Const_WheeledVehicleController : JPH.Object<Const_WheeledVehicleController>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheeledVehicleController_Destroy(_Underlying *_this);
            __JPH_WheeledVehicleController_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_WheeledVehicleController() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_WheeledVehicleController self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_WheeledVehicleController_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_WheeledVehicleController_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_VehicleController(Const_WheeledVehicleController self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_UpcastTo_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_UpcastTo_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleController._Underlying *__JPH_WheeledVehicleController_UpcastTo_JPH_VehicleController(_Underlying *_this);
            JPH.Const_VehicleController ret = new(__JPH_WheeledVehicleController_UpcastTo_JPH_VehicleController(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_WheeledVehicleController(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheeledVehicleController_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_WheeledVehicleController ret = new(__JPH_WheeledVehicleController_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_WheeledVehicleController(JPH.Const_VehicleController parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_StaticDowncastFrom_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_StaticDowncastFrom_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheeledVehicleController_StaticDowncastFrom_JPH_VehicleController(JPH.Const_VehicleController._Underlying *_this);
            Const_WheeledVehicleController ret = new(__JPH_WheeledVehicleController_StaticDowncastFrom_JPH_VehicleController(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_WheeledVehicleController(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// Generated from constructor `JPH::WheeledVehicleController::WheeledVehicleController`.
        public unsafe Const_WheeledVehicleController(JPH.Const_WheeledVehicleControllerSettings inSettings, JPH.VehicleConstraint inConstraint) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheeledVehicleController._Underlying *__JPH_WheeledVehicleController_Construct(JPH.Const_WheeledVehicleControllerSettings._Underlying *inSettings, JPH.VehicleConstraint._Underlying *inConstraint);
            _UnderlyingPtr = __JPH_WheeledVehicleController_Construct(inSettings._UnderlyingPtr, inConstraint._UnderlyingPtr);
        }

        /// Generated from method `JPH::WheeledVehicleController::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_WheeledVehicleController_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_WheeledVehicleController_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_WheeledVehicleController_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_WheeledVehicleController_size_t(inCount);
        }

        /// Generated from method `JPH::WheeledVehicleController::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheeledVehicleController_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheeledVehicleController_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheeledVehicleController_void_ptr(void *inPointer);
            __Jolt_delete_JPH_WheeledVehicleController_void_ptr(inPointer);
        }

        /// Generated from method `JPH::WheeledVehicleController::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheeledVehicleController_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheeledVehicleController_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheeledVehicleController_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_WheeledVehicleController_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::WheeledVehicleController::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_WheeledVehicleController_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_WheeledVehicleController_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_WheeledVehicleController_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_WheeledVehicleController_size_t(inCount);
        }

        /// Generated from method `JPH::WheeledVehicleController::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheeledVehicleController_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheeledVehicleController_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheeledVehicleController_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_WheeledVehicleController_void_ptr(inPointer);
        }

        /// Generated from method `JPH::WheeledVehicleController::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheeledVehicleController_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheeledVehicleController_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheeledVehicleController_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_WheeledVehicleController_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::WheeledVehicleController::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_WheeledVehicleController_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_WheeledVehicleController_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_WheeledVehicleController_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_WheeledVehicleController_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::WheeledVehicleController::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_WheeledVehicleController_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_WheeledVehicleController_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_WheeledVehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_WheeledVehicleController_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::WheeledVehicleController::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_WheeledVehicleController_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_WheeledVehicleController_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_WheeledVehicleController_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_WheeledVehicleController_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::WheeledVehicleController::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_WheeledVehicleController_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_WheeledVehicleController_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_WheeledVehicleController_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_WheeledVehicleController_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::WheeledVehicleController::GetForwardInput`.
        public unsafe float GetForwardInput()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_GetForwardInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_GetForwardInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheeledVehicleController_GetForwardInput(_Underlying *_this);
            return __JPH_WheeledVehicleController_GetForwardInput(_UnderlyingPtr);
        }

        /// Generated from method `JPH::WheeledVehicleController::GetRightInput`.
        public unsafe float GetRightInput()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_GetRightInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_GetRightInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheeledVehicleController_GetRightInput(_Underlying *_this);
            return __JPH_WheeledVehicleController_GetRightInput(_UnderlyingPtr);
        }

        /// Generated from method `JPH::WheeledVehicleController::GetBrakeInput`.
        public unsafe float GetBrakeInput()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_GetBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_GetBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheeledVehicleController_GetBrakeInput(_Underlying *_this);
            return __JPH_WheeledVehicleController_GetBrakeInput(_UnderlyingPtr);
        }

        /// Generated from method `JPH::WheeledVehicleController::GetHandBrakeInput`.
        public unsafe float GetHandBrakeInput()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_GetHandBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_GetHandBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheeledVehicleController_GetHandBrakeInput(_Underlying *_this);
            return __JPH_WheeledVehicleController_GetHandBrakeInput(_UnderlyingPtr);
        }

        /// Get current engine state
        /// Generated from method `JPH::WheeledVehicleController::GetEngine`.
        public unsafe JPH.Const_VehicleEngine GetEngine()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_GetEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_GetEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleEngine._Underlying *__JPH_WheeledVehicleController_GetEngine(_Underlying *_this);
            return new(__JPH_WheeledVehicleController_GetEngine(_UnderlyingPtr), is_owning: false);
        }

        /// Get current transmission state
        /// Generated from method `JPH::WheeledVehicleController::GetTransmission`.
        public unsafe JPH.Const_VehicleTransmission GetTransmission()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_GetTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_GetTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleTransmission._Underlying *__JPH_WheeledVehicleController_GetTransmission(_Underlying *_this);
            return new(__JPH_WheeledVehicleController_GetTransmission(_UnderlyingPtr), is_owning: false);
        }

        /// Get the differentials this vehicle has
        /// Generated from method `JPH::WheeledVehicleController::GetDifferentials`.
        public unsafe JPH.Const_Array_JPHVehicleDifferentialSettings GetDifferentials()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_GetDifferentials", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_GetDifferentials", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Array_JPHVehicleDifferentialSettings._Underlying *__JPH_WheeledVehicleController_GetDifferentials(_Underlying *_this);
            return new(__JPH_WheeledVehicleController_GetDifferentials(_UnderlyingPtr), is_owning: false);
        }

        /// Ratio max / min average wheel speed of each differential (measured at the clutch).
        /// Generated from method `JPH::WheeledVehicleController::GetDifferentialLimitedSlipRatio`.
        public unsafe float GetDifferentialLimitedSlipRatio()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_GetDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_GetDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheeledVehicleController_GetDifferentialLimitedSlipRatio(_Underlying *_this);
            return __JPH_WheeledVehicleController_GetDifferentialLimitedSlipRatio(_UnderlyingPtr);
        }

        /// Get the average wheel speed of all driven wheels (measured at the clutch)
        /// Generated from method `JPH::WheeledVehicleController::GetWheelSpeedAtClutch`.
        public unsafe float GetWheelSpeedAtClutch()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_GetWheelSpeedAtClutch", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_GetWheelSpeedAtClutch", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_WheeledVehicleController_GetWheelSpeedAtClutch(_Underlying *_this);
            return __JPH_WheeledVehicleController_GetWheelSpeedAtClutch(_UnderlyingPtr);
        }

        /// Generated from method `JPH::WheeledVehicleController::GetTireMaxImpulseCallback`.
        public unsafe JPH.Std.Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float GetTireMaxImpulseCallback()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_GetTireMaxImpulseCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_GetTireMaxImpulseCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Std.Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float._Underlying *__JPH_WheeledVehicleController_GetTireMaxImpulseCallback(_Underlying *_this);
            return new(__JPH_WheeledVehicleController_GetTireMaxImpulseCallback(_UnderlyingPtr), is_owning: false);
        }
    }

    /// Runtime controller class
    /// Generated from class `JPH::WheeledVehicleController`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleController`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::MotorcycleController`
    /// This is the non-const half of the class.
    public class WheeledVehicleController : Const_WheeledVehicleController
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(WheeledVehicleController self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_WheeledVehicleController_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_WheeledVehicleController_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.VehicleController(WheeledVehicleController self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_UpcastTo_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_UpcastTo_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleController._Underlying *__JPH_WheeledVehicleController_UpcastTo_JPH_VehicleController(_Underlying *_this);
            JPH.VehicleController ret = new(__JPH_WheeledVehicleController_UpcastTo_JPH_VehicleController(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator WheeledVehicleController(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheeledVehicleController_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            WheeledVehicleController ret = new(__JPH_WheeledVehicleController_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator WheeledVehicleController(JPH.VehicleController parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_StaticDowncastFrom_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_StaticDowncastFrom_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_WheeledVehicleController_StaticDowncastFrom_JPH_VehicleController(JPH.VehicleController._Underlying *_this);
            WheeledVehicleController ret = new(__JPH_WheeledVehicleController_StaticDowncastFrom_JPH_VehicleController(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe WheeledVehicleController(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// Generated from constructor `JPH::WheeledVehicleController::WheeledVehicleController`.
        public unsafe WheeledVehicleController(JPH.Const_WheeledVehicleControllerSettings inSettings, JPH.VehicleConstraint inConstraint) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheeledVehicleController._Underlying *__JPH_WheeledVehicleController_Construct(JPH.Const_WheeledVehicleControllerSettings._Underlying *inSettings, JPH.VehicleConstraint._Underlying *inConstraint);
            _UnderlyingPtr = __JPH_WheeledVehicleController_Construct(inSettings._UnderlyingPtr, inConstraint._UnderlyingPtr);
        }

        /// Set input from driver
        /// @param inForward Value between -1 and 1 for auto transmission and value between 0 and 1 indicating desired driving direction and amount the gas pedal is pressed
        /// @param inRight Value between -1 and 1 indicating desired steering angle (1 = right)
        /// @param inBrake Value between 0 and 1 indicating how strong the brake pedal is pressed
        /// @param inHandBrake Value between 0 and 1 indicating how strong the hand brake is pulled
        /// Generated from method `JPH::WheeledVehicleController::SetDriverInput`.
        public unsafe void SetDriverInput(float inForward, float inRight, float inBrake, float inHandBrake)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_SetDriverInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_SetDriverInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheeledVehicleController_SetDriverInput(_Underlying *_this, float inForward, float inRight, float inBrake, float inHandBrake);
            __JPH_WheeledVehicleController_SetDriverInput(_UnderlyingPtr, inForward, inRight, inBrake, inHandBrake);
        }

        /// Value between -1 and 1 for auto transmission and value between 0 and 1 indicating desired driving direction and amount the gas pedal is pressed
        /// Generated from method `JPH::WheeledVehicleController::SetForwardInput`.
        public unsafe void SetForwardInput(float inForward)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_SetForwardInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_SetForwardInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheeledVehicleController_SetForwardInput(_Underlying *_this, float inForward);
            __JPH_WheeledVehicleController_SetForwardInput(_UnderlyingPtr, inForward);
        }

        /// Value between -1 and 1 indicating desired steering angle (1 = right)
        /// Generated from method `JPH::WheeledVehicleController::SetRightInput`.
        public unsafe void SetRightInput(float inRight)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_SetRightInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_SetRightInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheeledVehicleController_SetRightInput(_Underlying *_this, float inRight);
            __JPH_WheeledVehicleController_SetRightInput(_UnderlyingPtr, inRight);
        }

        /// Value between 0 and 1 indicating how strong the brake pedal is pressed
        /// Generated from method `JPH::WheeledVehicleController::SetBrakeInput`.
        public unsafe void SetBrakeInput(float inBrake)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_SetBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_SetBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheeledVehicleController_SetBrakeInput(_Underlying *_this, float inBrake);
            __JPH_WheeledVehicleController_SetBrakeInput(_UnderlyingPtr, inBrake);
        }

        /// Value between 0 and 1 indicating how strong the hand brake is pulled
        /// Generated from method `JPH::WheeledVehicleController::SetHandBrakeInput`.
        public unsafe void SetHandBrakeInput(float inHandBrake)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_SetHandBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_SetHandBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheeledVehicleController_SetHandBrakeInput(_Underlying *_this, float inHandBrake);
            __JPH_WheeledVehicleController_SetHandBrakeInput(_UnderlyingPtr, inHandBrake);
        }

        /// Get current engine state (writable interface, allows you to make changes to the configuration which will take effect the next time step)
        /// Generated from method `JPH::WheeledVehicleController::GetEngine`.
        public unsafe new JPH.VehicleEngine GetEngine()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_GetEngine_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_GetEngine_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleEngine._Underlying *__JPH_WheeledVehicleController_GetEngine_mut(_Underlying *_this);
            return new(__JPH_WheeledVehicleController_GetEngine_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Get current transmission state (writable interface, allows you to make changes to the configuration which will take effect the next time step)
        /// Generated from method `JPH::WheeledVehicleController::GetTransmission`.
        public unsafe new JPH.VehicleTransmission GetTransmission()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_GetTransmission_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_GetTransmission_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmission._Underlying *__JPH_WheeledVehicleController_GetTransmission_mut(_Underlying *_this);
            return new(__JPH_WheeledVehicleController_GetTransmission_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Get the differentials this vehicle has (writable interface, allows you to make changes to the configuration which will take effect the next time step)
        /// Generated from method `JPH::WheeledVehicleController::GetDifferentials`.
        public unsafe new JPH.Array_JPHVehicleDifferentialSettings GetDifferentials()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_GetDifferentials_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_GetDifferentials_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHVehicleDifferentialSettings._Underlying *__JPH_WheeledVehicleController_GetDifferentials_mut(_Underlying *_this);
            return new(__JPH_WheeledVehicleController_GetDifferentials_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::WheeledVehicleController::SetDifferentialLimitedSlipRatio`.
        public unsafe void SetDifferentialLimitedSlipRatio(float inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_SetDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_SetDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheeledVehicleController_SetDifferentialLimitedSlipRatio(_Underlying *_this, float inV);
            __JPH_WheeledVehicleController_SetDifferentialLimitedSlipRatio(_UnderlyingPtr, inV);
        }

        /// Generated from method `JPH::WheeledVehicleController::SetTireMaxImpulseCallback`.
        public unsafe void SetTireMaxImpulseCallback(JPH.Std.Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float inTireMaxImpulseCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_SetTireMaxImpulseCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_SetTireMaxImpulseCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheeledVehicleController_SetTireMaxImpulseCallback(_Underlying *_this, JPH.Std.Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float._Underlying *inTireMaxImpulseCallback);
            __JPH_WheeledVehicleController_SetTireMaxImpulseCallback(_UnderlyingPtr, inTireMaxImpulseCallback._UnderlyingPtr);
        }

        /// Debug drawing of RPM meter
        /// Generated from method `JPH::WheeledVehicleController::SetRPMMeter`.
        public unsafe void SetRPMMeter(JPH.Const_Vec3 inPosition, float inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_WheeledVehicleController_SetRPMMeter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_WheeledVehicleController_SetRPMMeter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_WheeledVehicleController_SetRPMMeter(_Underlying *_this, JPH.Vec3._Underlying *inPosition, float inSize);
            __JPH_WheeledVehicleController_SetRPMMeter(_UnderlyingPtr, inPosition._UnderlyingPtr, inSize);
        }
    }

    /// This is used for optional parameters of class `WheeledVehicleController` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_WheeledVehicleController`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `WheeledVehicleController`/`Const_WheeledVehicleController` directly.
    public class _InOptMut_WheeledVehicleController
    {
        public WheeledVehicleController? Opt;

        public _InOptMut_WheeledVehicleController() {}
        public _InOptMut_WheeledVehicleController(WheeledVehicleController value) {Opt = value;}
        public static implicit operator _InOptMut_WheeledVehicleController(WheeledVehicleController value) {return new(value);}
    }

    /// This is used for optional parameters of class `WheeledVehicleController` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_WheeledVehicleController`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `WheeledVehicleController`/`Const_WheeledVehicleController` to pass it to the function.
    public class _InOptConst_WheeledVehicleController
    {
        public Const_WheeledVehicleController? Opt;

        public _InOptConst_WheeledVehicleController() {}
        public _InOptConst_WheeledVehicleController(Const_WheeledVehicleController value) {Opt = value;}
        public static implicit operator _InOptConst_WheeledVehicleController(Const_WheeledVehicleController value) {return new(value);}
    }
}
