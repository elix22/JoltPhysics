// machine generated, do not edit
public static partial class JPH
{
    /// Settings of a two wheeled motorcycle (adds a spring to balance the motorcycle)
    /// Note: The motor cycle controller is still in development and may need a lot of tweaks/hacks to work properly!
    /// Generated from class `JPH::MotorcycleControllerSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::WheeledVehicleControllerSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::VehicleControllerSettings>`
    ///     `JPH::VehicleControllerSettings`
    /// This is the const half of the class.
    public class Const_MotorcycleControllerSettings : JPH.Object<Const_MotorcycleControllerSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_Release(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_Release(__JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_MotorcycleControllerSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_MotorcycleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_MotorcycleControllerSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_MotorcycleControllerSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHVehicleControllerSettings(Const_MotorcycleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHVehicleControllerSettings._Underlying *__JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHVehicleControllerSettings ret = new(__JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_VehicleControllerSettings(Const_MotorcycleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleControllerSettings._Underlying *__JPH_MotorcycleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(_Underlying *_this);
            JPH.Const_VehicleControllerSettings ret = new(__JPH_MotorcycleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_WheeledVehicleControllerSettings(Const_MotorcycleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_WheeledVehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_WheeledVehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_WheeledVehicleControllerSettings._Underlying *__JPH_MotorcycleControllerSettings_UpcastTo_JPH_WheeledVehicleControllerSettings(_Underlying *_this);
            JPH.Const_WheeledVehicleControllerSettings ret = new(__JPH_MotorcycleControllerSettings_UpcastTo_JPH_WheeledVehicleControllerSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_MotorcycleControllerSettings(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            Const_MotorcycleControllerSettings ret = new(__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_MotorcycleControllerSettings(JPH.Const_RefTarget_JPHVehicleControllerSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(JPH.Const_RefTarget_JPHVehicleControllerSettings._Underlying *_this);
            Const_MotorcycleControllerSettings ret = new(__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_MotorcycleControllerSettings(JPH.Const_VehicleControllerSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(JPH.Const_VehicleControllerSettings._Underlying *_this);
            Const_MotorcycleControllerSettings ret = new(__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_MotorcycleControllerSettings(JPH.Const_WheeledVehicleControllerSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_WheeledVehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_WheeledVehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_WheeledVehicleControllerSettings(JPH.Const_WheeledVehicleControllerSettings._Underlying *_this);
            Const_MotorcycleControllerSettings ret = new(__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_WheeledVehicleControllerSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// How far we're willing to make the bike lean over in turns (in radians)
        public unsafe float mMaxLeanAngle
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mMaxLeanAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mMaxLeanAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorcycleControllerSettings_Get_mMaxLeanAngle(_Underlying *_this);
                return *__JPH_MotorcycleControllerSettings_Get_mMaxLeanAngle(_UnderlyingPtr);
            }
        }

        /// Spring constant for the lean spring
        public unsafe float mLeanSpringConstant
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mLeanSpringConstant", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mLeanSpringConstant", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorcycleControllerSettings_Get_mLeanSpringConstant(_Underlying *_this);
                return *__JPH_MotorcycleControllerSettings_Get_mLeanSpringConstant(_UnderlyingPtr);
            }
        }

        /// Spring damping constant for the lean spring
        public unsafe float mLeanSpringDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mLeanSpringDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mLeanSpringDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorcycleControllerSettings_Get_mLeanSpringDamping(_Underlying *_this);
                return *__JPH_MotorcycleControllerSettings_Get_mLeanSpringDamping(_UnderlyingPtr);
            }
        }

        /// The lean spring applies an additional force equal to this coefficient * Integral(delta angle, 0, t), this effectively makes the lean spring a PID controller
        public unsafe float mLeanSpringIntegrationCoefficient
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mLeanSpringIntegrationCoefficient", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mLeanSpringIntegrationCoefficient", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorcycleControllerSettings_Get_mLeanSpringIntegrationCoefficient(_Underlying *_this);
                return *__JPH_MotorcycleControllerSettings_Get_mLeanSpringIntegrationCoefficient(_UnderlyingPtr);
            }
        }

        /// How much to decay the angle integral when the wheels are not touching the floor: new_value = e^(-decay * t) * initial_value
        public unsafe float mLeanSpringIntegrationCoefficientDecay
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mLeanSpringIntegrationCoefficientDecay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mLeanSpringIntegrationCoefficientDecay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorcycleControllerSettings_Get_mLeanSpringIntegrationCoefficientDecay(_Underlying *_this);
                return *__JPH_MotorcycleControllerSettings_Get_mLeanSpringIntegrationCoefficientDecay(_UnderlyingPtr);
            }
        }

        /// How much to smooth the lean angle (0 = no smoothing, 1 = lean angle never changes)
        /// Note that this is frame rate dependent because the formula is: smoothing_factor * previous + (1 - smoothing_factor) * current
        public unsafe float mLeanSmoothingFactor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mLeanSmoothingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mLeanSmoothingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorcycleControllerSettings_Get_mLeanSmoothingFactor(_Underlying *_this);
                return *__JPH_MotorcycleControllerSettings_Get_mLeanSmoothingFactor(_UnderlyingPtr);
            }
        }

        ///< The properties of the engine
        public unsafe JPH.Const_VehicleEngineSettings mEngine
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_VehicleEngineSettings._Underlying *__JPH_MotorcycleControllerSettings_Get_mEngine(_Underlying *_this);
                JPH.Const_VehicleEngineSettings __ret;
                __ret = new(__JPH_MotorcycleControllerSettings_Get_mEngine(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_VehicleTransmissionSettings._Underlying *__JPH_MotorcycleControllerSettings_Get_mTransmission(_Underlying *_this);
                JPH.Const_VehicleTransmissionSettings __ret;
                __ret = new(__JPH_MotorcycleControllerSettings_Get_mTransmission(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mDifferentials", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mDifferentials", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Array_JPHVehicleDifferentialSettings._Underlying *__JPH_MotorcycleControllerSettings_Get_mDifferentials(_Underlying *_this);
                JPH.Const_Array_JPHVehicleDifferentialSettings __ret;
                __ret = new(__JPH_MotorcycleControllerSettings_Get_mDifferentials(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Get_mDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorcycleControllerSettings_Get_mDifferentialLimitedSlipRatio(_Underlying *_this);
                return *__JPH_MotorcycleControllerSettings_Get_mDifferentialLimitedSlipRatio(_UnderlyingPtr);
            }
        }

        internal unsafe Const_MotorcycleControllerSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_MotorcycleControllerSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorcycleControllerSettings._Underlying *__JPH_MotorcycleControllerSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_MotorcycleControllerSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(__JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::MotorcycleControllerSettings::MotorcycleControllerSettings`.
        public unsafe Const_MotorcycleControllerSettings(JPH._ByValue_MotorcycleControllerSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorcycleControllerSettings._Underlying *__JPH_MotorcycleControllerSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.MotorcycleControllerSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_MotorcycleControllerSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(__JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::MotorcycleControllerSettings::MotorcycleControllerSettings`.
        public Const_MotorcycleControllerSettings(Const_MotorcycleControllerSettings _other) : this(new _ByValue_MotorcycleControllerSettings(_other)) {}

        /// Generated from constructor `JPH::MotorcycleControllerSettings::MotorcycleControllerSettings`.
        public Const_MotorcycleControllerSettings(MotorcycleControllerSettings _other) : this((Const_MotorcycleControllerSettings)_other) {}

        /// Generated from method `JPH::MotorcycleControllerSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_MotorcycleControllerSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_MotorcycleControllerSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_MotorcycleControllerSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_MotorcycleControllerSettings_size_t(inCount);
        }

        /// Generated from method `JPH::MotorcycleControllerSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::MotorcycleControllerSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::MotorcycleControllerSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_MotorcycleControllerSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_MotorcycleControllerSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_MotorcycleControllerSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_MotorcycleControllerSettings_size_t(inCount);
        }

        /// Generated from method `JPH::MotorcycleControllerSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::MotorcycleControllerSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::MotorcycleControllerSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_MotorcycleControllerSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_MotorcycleControllerSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_MotorcycleControllerSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_MotorcycleControllerSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::MotorcycleControllerSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_MotorcycleControllerSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::MotorcycleControllerSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_MotorcycleControllerSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_MotorcycleControllerSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_MotorcycleControllerSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_MotorcycleControllerSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::MotorcycleControllerSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_MotorcycleControllerSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        // See: VehicleControllerSettings
        /// Generated from method `JPH::MotorcycleControllerSettings::ConstructController`.
        public unsafe JPH.VehicleController? ConstructController(JPH.VehicleConstraint inConstraint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_ConstructController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_ConstructController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleController._Underlying *__JPH_MotorcycleControllerSettings_ConstructController(_Underlying *_this, JPH.VehicleConstraint._Underlying *inConstraint);
            var __c_ret = __JPH_MotorcycleControllerSettings_ConstructController(_UnderlyingPtr, inConstraint._UnderlyingPtr);
            return __c_ret is not null ? new JPH.VehicleController(__c_ret, is_owning: false) : null;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::MotorcycleControllerSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleControllerSettings_SetEmbedded(_Underlying *_this);
            __JPH_MotorcycleControllerSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::MotorcycleControllerSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_MotorcycleControllerSettings_GetRefCount(_Underlying *_this);
            return __JPH_MotorcycleControllerSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::MotorcycleControllerSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleControllerSettings_AddRef(_Underlying *_this);
            __JPH_MotorcycleControllerSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::MotorcycleControllerSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleControllerSettings_Release(_Underlying *_this);
            __JPH_MotorcycleControllerSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::MotorcycleControllerSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_MotorcycleControllerSettings_sInternalGetRefCountOffset();
            return __JPH_MotorcycleControllerSettings_sInternalGetRefCountOffset();
        }
    }

    /// Settings of a two wheeled motorcycle (adds a spring to balance the motorcycle)
    /// Note: The motor cycle controller is still in development and may need a lot of tweaks/hacks to work properly!
    /// Generated from class `JPH::MotorcycleControllerSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::WheeledVehicleControllerSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::VehicleControllerSettings>`
    ///     `JPH::VehicleControllerSettings`
    /// This is the non-const half of the class.
    public class MotorcycleControllerSettings : Const_MotorcycleControllerSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(MotorcycleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_MotorcycleControllerSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_MotorcycleControllerSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.RefTarget_JPHVehicleControllerSettings(MotorcycleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleControllerSettings._Underlying *__JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            JPH.RefTarget_JPHVehicleControllerSettings ret = new(__JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.VehicleControllerSettings(MotorcycleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleControllerSettings._Underlying *__JPH_MotorcycleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(_Underlying *_this);
            JPH.VehicleControllerSettings ret = new(__JPH_MotorcycleControllerSettings_UpcastTo_JPH_VehicleControllerSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.WheeledVehicleControllerSettings(MotorcycleControllerSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_WheeledVehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_WheeledVehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheeledVehicleControllerSettings._Underlying *__JPH_MotorcycleControllerSettings_UpcastTo_JPH_WheeledVehicleControllerSettings(_Underlying *_this);
            JPH.WheeledVehicleControllerSettings ret = new(__JPH_MotorcycleControllerSettings_UpcastTo_JPH_WheeledVehicleControllerSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator MotorcycleControllerSettings(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            MotorcycleControllerSettings ret = new(__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator MotorcycleControllerSettings(JPH.RefTarget_JPHVehicleControllerSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(JPH.RefTarget_JPHVehicleControllerSettings._Underlying *_this);
            MotorcycleControllerSettings ret = new(__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleControllerSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator MotorcycleControllerSettings(JPH.VehicleControllerSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(JPH.VehicleControllerSettings._Underlying *_this);
            MotorcycleControllerSettings ret = new(__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_VehicleControllerSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator MotorcycleControllerSettings(JPH.WheeledVehicleControllerSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_WheeledVehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_WheeledVehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_WheeledVehicleControllerSettings(JPH.WheeledVehicleControllerSettings._Underlying *_this);
            MotorcycleControllerSettings ret = new(__JPH_MotorcycleControllerSettings_StaticDowncastFrom_JPH_WheeledVehicleControllerSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// How far we're willing to make the bike lean over in turns (in radians)
        public new unsafe ref float mMaxLeanAngle
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mMaxLeanAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mMaxLeanAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorcycleControllerSettings_GetMutable_mMaxLeanAngle(_Underlying *_this);
                return ref *__JPH_MotorcycleControllerSettings_GetMutable_mMaxLeanAngle(_UnderlyingPtr);
            }
        }

        /// Spring constant for the lean spring
        public new unsafe ref float mLeanSpringConstant
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringConstant", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringConstant", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringConstant(_Underlying *_this);
                return ref *__JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringConstant(_UnderlyingPtr);
            }
        }

        /// Spring damping constant for the lean spring
        public new unsafe ref float mLeanSpringDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringDamping(_Underlying *_this);
                return ref *__JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringDamping(_UnderlyingPtr);
            }
        }

        /// The lean spring applies an additional force equal to this coefficient * Integral(delta angle, 0, t), this effectively makes the lean spring a PID controller
        public new unsafe ref float mLeanSpringIntegrationCoefficient
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringIntegrationCoefficient", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringIntegrationCoefficient", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringIntegrationCoefficient(_Underlying *_this);
                return ref *__JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringIntegrationCoefficient(_UnderlyingPtr);
            }
        }

        /// How much to decay the angle integral when the wheels are not touching the floor: new_value = e^(-decay * t) * initial_value
        public new unsafe ref float mLeanSpringIntegrationCoefficientDecay
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringIntegrationCoefficientDecay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringIntegrationCoefficientDecay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringIntegrationCoefficientDecay(_Underlying *_this);
                return ref *__JPH_MotorcycleControllerSettings_GetMutable_mLeanSpringIntegrationCoefficientDecay(_UnderlyingPtr);
            }
        }

        /// How much to smooth the lean angle (0 = no smoothing, 1 = lean angle never changes)
        /// Note that this is frame rate dependent because the formula is: smoothing_factor * previous + (1 - smoothing_factor) * current
        public new unsafe ref float mLeanSmoothingFactor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mLeanSmoothingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mLeanSmoothingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorcycleControllerSettings_GetMutable_mLeanSmoothingFactor(_Underlying *_this);
                return ref *__JPH_MotorcycleControllerSettings_GetMutable_mLeanSmoothingFactor(_UnderlyingPtr);
            }
        }

        ///< The properties of the engine
        public new unsafe JPH.VehicleEngineSettings mEngine
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mEngine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.VehicleEngineSettings._Underlying *__JPH_MotorcycleControllerSettings_GetMutable_mEngine(_Underlying *_this);
                JPH.VehicleEngineSettings __ret;
                __ret = new(__JPH_MotorcycleControllerSettings_GetMutable_mEngine(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mTransmission", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.VehicleTransmissionSettings._Underlying *__JPH_MotorcycleControllerSettings_GetMutable_mTransmission(_Underlying *_this);
                JPH.VehicleTransmissionSettings __ret;
                __ret = new(__JPH_MotorcycleControllerSettings_GetMutable_mTransmission(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mDifferentials", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mDifferentials", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Array_JPHVehicleDifferentialSettings._Underlying *__JPH_MotorcycleControllerSettings_GetMutable_mDifferentials(_Underlying *_this);
                JPH.Array_JPHVehicleDifferentialSettings __ret;
                __ret = new(__JPH_MotorcycleControllerSettings_GetMutable_mDifferentials(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_GetMutable_mDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorcycleControllerSettings_GetMutable_mDifferentialLimitedSlipRatio(_Underlying *_this);
                return ref *__JPH_MotorcycleControllerSettings_GetMutable_mDifferentialLimitedSlipRatio(_UnderlyingPtr);
            }
        }

        internal unsafe MotorcycleControllerSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe MotorcycleControllerSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorcycleControllerSettings._Underlying *__JPH_MotorcycleControllerSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_MotorcycleControllerSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(__JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::MotorcycleControllerSettings::MotorcycleControllerSettings`.
        public unsafe MotorcycleControllerSettings(JPH._ByValue_MotorcycleControllerSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorcycleControllerSettings._Underlying *__JPH_MotorcycleControllerSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.MotorcycleControllerSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_MotorcycleControllerSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleControllerSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleControllerSettings_AddRef(__JPH_MotorcycleControllerSettings_UpcastTo_JPH_RefTarget_JPH_VehicleControllerSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::MotorcycleControllerSettings::MotorcycleControllerSettings`.
        public MotorcycleControllerSettings(Const_MotorcycleControllerSettings _other) : this(new _ByValue_MotorcycleControllerSettings(_other)) {}

        /// Generated from constructor `JPH::MotorcycleControllerSettings::MotorcycleControllerSettings`.
        public MotorcycleControllerSettings(MotorcycleControllerSettings _other) : this((Const_MotorcycleControllerSettings)_other) {}

        /// Generated from method `JPH::MotorcycleControllerSettings::operator=`.
        public unsafe JPH.MotorcycleControllerSettings Assign(JPH._ByValue_MotorcycleControllerSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleControllerSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorcycleControllerSettings._Underlying *__JPH_MotorcycleControllerSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.MotorcycleControllerSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_MotorcycleControllerSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `MotorcycleControllerSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `MotorcycleControllerSettings`/`Const_MotorcycleControllerSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_MotorcycleControllerSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_MotorcycleControllerSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_MotorcycleControllerSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_MotorcycleControllerSettings(Const_MotorcycleControllerSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_MotorcycleControllerSettings(Const_MotorcycleControllerSettings arg) {return new(arg);}
        public _ByValue_MotorcycleControllerSettings(JPH._Moved<MotorcycleControllerSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_MotorcycleControllerSettings(JPH._Moved<MotorcycleControllerSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `MotorcycleControllerSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_MotorcycleControllerSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `MotorcycleControllerSettings`/`Const_MotorcycleControllerSettings` directly.
    public class _InOptMut_MotorcycleControllerSettings
    {
        public MotorcycleControllerSettings? Opt;

        public _InOptMut_MotorcycleControllerSettings() {}
        public _InOptMut_MotorcycleControllerSettings(MotorcycleControllerSettings value) {Opt = value;}
        public static implicit operator _InOptMut_MotorcycleControllerSettings(MotorcycleControllerSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `MotorcycleControllerSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_MotorcycleControllerSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `MotorcycleControllerSettings`/`Const_MotorcycleControllerSettings` to pass it to the function.
    public class _InOptConst_MotorcycleControllerSettings
    {
        public Const_MotorcycleControllerSettings? Opt;

        public _InOptConst_MotorcycleControllerSettings() {}
        public _InOptConst_MotorcycleControllerSettings(Const_MotorcycleControllerSettings value) {Opt = value;}
        public static implicit operator _InOptConst_MotorcycleControllerSettings(Const_MotorcycleControllerSettings value) {return new(value);}
    }

    /// Runtime controller class
    /// Generated from class `JPH::MotorcycleController`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::WheeledVehicleController`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    ///     `JPH::VehicleController`
    /// This is the const half of the class.
    public class Const_MotorcycleController : JPH.Object<Const_MotorcycleController>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_Destroy(_Underlying *_this);
            __JPH_MotorcycleController_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_MotorcycleController() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_MotorcycleController self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_MotorcycleController_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_MotorcycleController_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_VehicleController(Const_MotorcycleController self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_UpcastTo_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_UpcastTo_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleController._Underlying *__JPH_MotorcycleController_UpcastTo_JPH_VehicleController(_Underlying *_this);
            JPH.Const_VehicleController ret = new(__JPH_MotorcycleController_UpcastTo_JPH_VehicleController(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_WheeledVehicleController(Const_MotorcycleController self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_UpcastTo_JPH_WheeledVehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_UpcastTo_JPH_WheeledVehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_WheeledVehicleController._Underlying *__JPH_MotorcycleController_UpcastTo_JPH_WheeledVehicleController(_Underlying *_this);
            JPH.Const_WheeledVehicleController ret = new(__JPH_MotorcycleController_UpcastTo_JPH_WheeledVehicleController(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_MotorcycleController(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_MotorcycleController_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_MotorcycleController ret = new(__JPH_MotorcycleController_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_MotorcycleController(JPH.Const_VehicleController parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_StaticDowncastFrom_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_StaticDowncastFrom_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_MotorcycleController_StaticDowncastFrom_JPH_VehicleController(JPH.Const_VehicleController._Underlying *_this);
            Const_MotorcycleController ret = new(__JPH_MotorcycleController_StaticDowncastFrom_JPH_VehicleController(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_MotorcycleController(JPH.Const_WheeledVehicleController parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_StaticDowncastFrom_JPH_WheeledVehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_StaticDowncastFrom_JPH_WheeledVehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_MotorcycleController_StaticDowncastFrom_JPH_WheeledVehicleController(JPH.Const_WheeledVehicleController._Underlying *_this);
            Const_MotorcycleController ret = new(__JPH_MotorcycleController_StaticDowncastFrom_JPH_WheeledVehicleController(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_MotorcycleController(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// Generated from constructor `JPH::MotorcycleController::MotorcycleController`.
        public unsafe Const_MotorcycleController(JPH.Const_MotorcycleControllerSettings inSettings, JPH.VehicleConstraint inConstraint) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorcycleController._Underlying *__JPH_MotorcycleController_Construct(JPH.Const_MotorcycleControllerSettings._Underlying *inSettings, JPH.VehicleConstraint._Underlying *inConstraint);
            _UnderlyingPtr = __JPH_MotorcycleController_Construct(inSettings._UnderlyingPtr, inConstraint._UnderlyingPtr);
        }

        /// Generated from method `JPH::MotorcycleController::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_MotorcycleController_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_MotorcycleController_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_MotorcycleController_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_MotorcycleController_size_t(inCount);
        }

        /// Generated from method `JPH::MotorcycleController::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_MotorcycleController_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_MotorcycleController_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_MotorcycleController_void_ptr(void *inPointer);
            __Jolt_delete_JPH_MotorcycleController_void_ptr(inPointer);
        }

        /// Generated from method `JPH::MotorcycleController::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_MotorcycleController_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_MotorcycleController_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_MotorcycleController_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_MotorcycleController_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::MotorcycleController::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_MotorcycleController_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_MotorcycleController_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_MotorcycleController_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_MotorcycleController_size_t(inCount);
        }

        /// Generated from method `JPH::MotorcycleController::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorcycleController_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorcycleController_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_MotorcycleController_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_MotorcycleController_void_ptr(inPointer);
        }

        /// Generated from method `JPH::MotorcycleController::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorcycleController_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorcycleController_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_MotorcycleController_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_MotorcycleController_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::MotorcycleController::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_MotorcycleController_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_MotorcycleController_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_MotorcycleController_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_MotorcycleController_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::MotorcycleController::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_MotorcycleController_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_MotorcycleController_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_MotorcycleController_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_MotorcycleController_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::MotorcycleController::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_MotorcycleController_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_MotorcycleController_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_MotorcycleController_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_MotorcycleController_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::MotorcycleController::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorcycleController_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorcycleController_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_MotorcycleController_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_MotorcycleController_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Get the distance between the front and back wheels
        /// Generated from method `JPH::MotorcycleController::GetWheelBase`.
        public unsafe float GetWheelBase()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_GetWheelBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_GetWheelBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotorcycleController_GetWheelBase(_Underlying *_this);
            return __JPH_MotorcycleController_GetWheelBase(_UnderlyingPtr);
        }

        /// Check if the lean spring is enabled.
        /// Generated from method `JPH::MotorcycleController::IsLeanControllerEnabled`.
        public unsafe bool IsLeanControllerEnabled()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_IsLeanControllerEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_IsLeanControllerEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_MotorcycleController_IsLeanControllerEnabled(_Underlying *_this);
            return __JPH_MotorcycleController_IsLeanControllerEnabled(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JPH::MotorcycleController::IsLeanSteeringLimitEnabled`.
        public unsafe bool IsLeanSteeringLimitEnabled()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_IsLeanSteeringLimitEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_IsLeanSteeringLimitEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_MotorcycleController_IsLeanSteeringLimitEnabled(_Underlying *_this);
            return __JPH_MotorcycleController_IsLeanSteeringLimitEnabled(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JPH::MotorcycleController::GetLeanSpringConstant`.
        public unsafe float GetLeanSpringConstant()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_GetLeanSpringConstant", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_GetLeanSpringConstant", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotorcycleController_GetLeanSpringConstant(_Underlying *_this);
            return __JPH_MotorcycleController_GetLeanSpringConstant(_UnderlyingPtr);
        }

        /// Generated from method `JPH::MotorcycleController::GetLeanSpringDamping`.
        public unsafe float GetLeanSpringDamping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_GetLeanSpringDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_GetLeanSpringDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotorcycleController_GetLeanSpringDamping(_Underlying *_this);
            return __JPH_MotorcycleController_GetLeanSpringDamping(_UnderlyingPtr);
        }

        /// Generated from method `JPH::MotorcycleController::GetLeanSpringIntegrationCoefficient`.
        public unsafe float GetLeanSpringIntegrationCoefficient()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_GetLeanSpringIntegrationCoefficient", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_GetLeanSpringIntegrationCoefficient", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotorcycleController_GetLeanSpringIntegrationCoefficient(_Underlying *_this);
            return __JPH_MotorcycleController_GetLeanSpringIntegrationCoefficient(_UnderlyingPtr);
        }

        /// Generated from method `JPH::MotorcycleController::GetLeanSpringIntegrationCoefficientDecay`.
        public unsafe float GetLeanSpringIntegrationCoefficientDecay()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_GetLeanSpringIntegrationCoefficientDecay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_GetLeanSpringIntegrationCoefficientDecay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotorcycleController_GetLeanSpringIntegrationCoefficientDecay(_Underlying *_this);
            return __JPH_MotorcycleController_GetLeanSpringIntegrationCoefficientDecay(_UnderlyingPtr);
        }

        /// Generated from method `JPH::MotorcycleController::GetLeanSmoothingFactor`.
        public unsafe float GetLeanSmoothingFactor()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_GetLeanSmoothingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_GetLeanSmoothingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotorcycleController_GetLeanSmoothingFactor(_Underlying *_this);
            return __JPH_MotorcycleController_GetLeanSmoothingFactor(_UnderlyingPtr);
        }

        /// Generated from method `JPH::MotorcycleController::GetForwardInput`.
        public unsafe float GetForwardInput()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_GetForwardInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_GetForwardInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotorcycleController_GetForwardInput(_Underlying *_this);
            return __JPH_MotorcycleController_GetForwardInput(_UnderlyingPtr);
        }

        /// Generated from method `JPH::MotorcycleController::GetRightInput`.
        public unsafe float GetRightInput()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_GetRightInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_GetRightInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotorcycleController_GetRightInput(_Underlying *_this);
            return __JPH_MotorcycleController_GetRightInput(_UnderlyingPtr);
        }

        /// Generated from method `JPH::MotorcycleController::GetBrakeInput`.
        public unsafe float GetBrakeInput()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_GetBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_GetBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotorcycleController_GetBrakeInput(_Underlying *_this);
            return __JPH_MotorcycleController_GetBrakeInput(_UnderlyingPtr);
        }

        /// Generated from method `JPH::MotorcycleController::GetHandBrakeInput`.
        public unsafe float GetHandBrakeInput()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_GetHandBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_GetHandBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotorcycleController_GetHandBrakeInput(_Underlying *_this);
            return __JPH_MotorcycleController_GetHandBrakeInput(_UnderlyingPtr);
        }

        /// Ratio max / min average wheel speed of each differential (measured at the clutch).
        /// Generated from method `JPH::MotorcycleController::GetDifferentialLimitedSlipRatio`.
        public unsafe float GetDifferentialLimitedSlipRatio()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_GetDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_GetDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotorcycleController_GetDifferentialLimitedSlipRatio(_Underlying *_this);
            return __JPH_MotorcycleController_GetDifferentialLimitedSlipRatio(_UnderlyingPtr);
        }

        /// Get the average wheel speed of all driven wheels (measured at the clutch)
        /// Generated from method `JPH::MotorcycleController::GetWheelSpeedAtClutch`.
        public unsafe float GetWheelSpeedAtClutch()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_GetWheelSpeedAtClutch", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_GetWheelSpeedAtClutch", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotorcycleController_GetWheelSpeedAtClutch(_Underlying *_this);
            return __JPH_MotorcycleController_GetWheelSpeedAtClutch(_UnderlyingPtr);
        }

        /// Generated from method `JPH::MotorcycleController::GetTireMaxImpulseCallback`.
        public unsafe JPH.Std.Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float GetTireMaxImpulseCallback()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_GetTireMaxImpulseCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_GetTireMaxImpulseCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Std.Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float._Underlying *__JPH_MotorcycleController_GetTireMaxImpulseCallback(_Underlying *_this);
            return new(__JPH_MotorcycleController_GetTireMaxImpulseCallback(_UnderlyingPtr), is_owning: false);
        }
    }

    /// Runtime controller class
    /// Generated from class `JPH::MotorcycleController`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::WheeledVehicleController`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    ///     `JPH::VehicleController`
    /// This is the non-const half of the class.
    public class MotorcycleController : Const_MotorcycleController
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(MotorcycleController self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_MotorcycleController_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_MotorcycleController_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.VehicleController(MotorcycleController self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_UpcastTo_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_UpcastTo_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleController._Underlying *__JPH_MotorcycleController_UpcastTo_JPH_VehicleController(_Underlying *_this);
            JPH.VehicleController ret = new(__JPH_MotorcycleController_UpcastTo_JPH_VehicleController(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.WheeledVehicleController(MotorcycleController self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_UpcastTo_JPH_WheeledVehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_UpcastTo_JPH_WheeledVehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.WheeledVehicleController._Underlying *__JPH_MotorcycleController_UpcastTo_JPH_WheeledVehicleController(_Underlying *_this);
            JPH.WheeledVehicleController ret = new(__JPH_MotorcycleController_UpcastTo_JPH_WheeledVehicleController(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator MotorcycleController(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_MotorcycleController_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            MotorcycleController ret = new(__JPH_MotorcycleController_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator MotorcycleController(JPH.VehicleController parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_StaticDowncastFrom_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_StaticDowncastFrom_JPH_VehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_MotorcycleController_StaticDowncastFrom_JPH_VehicleController(JPH.VehicleController._Underlying *_this);
            MotorcycleController ret = new(__JPH_MotorcycleController_StaticDowncastFrom_JPH_VehicleController(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator MotorcycleController(JPH.WheeledVehicleController parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_StaticDowncastFrom_JPH_WheeledVehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_StaticDowncastFrom_JPH_WheeledVehicleController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_MotorcycleController_StaticDowncastFrom_JPH_WheeledVehicleController(JPH.WheeledVehicleController._Underlying *_this);
            MotorcycleController ret = new(__JPH_MotorcycleController_StaticDowncastFrom_JPH_WheeledVehicleController(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe MotorcycleController(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// Generated from constructor `JPH::MotorcycleController::MotorcycleController`.
        public unsafe MotorcycleController(JPH.Const_MotorcycleControllerSettings inSettings, JPH.VehicleConstraint inConstraint) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorcycleController._Underlying *__JPH_MotorcycleController_Construct(JPH.Const_MotorcycleControllerSettings._Underlying *inSettings, JPH.VehicleConstraint._Underlying *inConstraint);
            _UnderlyingPtr = __JPH_MotorcycleController_Construct(inSettings._UnderlyingPtr, inConstraint._UnderlyingPtr);
        }

        /// Enable or disable the lean spring. This allows you to temporarily disable the lean spring to allow the motorcycle to fall over.
        /// Generated from method `JPH::MotorcycleController::EnableLeanController`.
        public unsafe void EnableLeanController(bool inEnable)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_EnableLeanController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_EnableLeanController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_EnableLeanController(_Underlying *_this, byte inEnable);
            __JPH_MotorcycleController_EnableLeanController(_UnderlyingPtr, inEnable ? (byte)1 : (byte)0);
        }

        /// Enable or disable the lean steering limit. When enabled (default) the steering angle is limited based on the vehicle speed to prevent steering that would cause an inertial force that causes the motorcycle to topple over.
        /// Generated from method `JPH::MotorcycleController::EnableLeanSteeringLimit`.
        public unsafe void EnableLeanSteeringLimit(bool inEnable)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_EnableLeanSteeringLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_EnableLeanSteeringLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_EnableLeanSteeringLimit(_Underlying *_this, byte inEnable);
            __JPH_MotorcycleController_EnableLeanSteeringLimit(_UnderlyingPtr, inEnable ? (byte)1 : (byte)0);
        }

        /// Spring constant for the lean spring
        /// Generated from method `JPH::MotorcycleController::SetLeanSpringConstant`.
        public unsafe void SetLeanSpringConstant(float inConstant)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_SetLeanSpringConstant", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_SetLeanSpringConstant", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_SetLeanSpringConstant(_Underlying *_this, float inConstant);
            __JPH_MotorcycleController_SetLeanSpringConstant(_UnderlyingPtr, inConstant);
        }

        /// Spring damping constant for the lean spring
        /// Generated from method `JPH::MotorcycleController::SetLeanSpringDamping`.
        public unsafe void SetLeanSpringDamping(float inDamping)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_SetLeanSpringDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_SetLeanSpringDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_SetLeanSpringDamping(_Underlying *_this, float inDamping);
            __JPH_MotorcycleController_SetLeanSpringDamping(_UnderlyingPtr, inDamping);
        }

        /// The lean spring applies an additional force equal to this coefficient * Integral(delta angle, 0, t), this effectively makes the lean spring a PID controller
        /// Generated from method `JPH::MotorcycleController::SetLeanSpringIntegrationCoefficient`.
        public unsafe void SetLeanSpringIntegrationCoefficient(float inCoefficient)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_SetLeanSpringIntegrationCoefficient", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_SetLeanSpringIntegrationCoefficient", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_SetLeanSpringIntegrationCoefficient(_Underlying *_this, float inCoefficient);
            __JPH_MotorcycleController_SetLeanSpringIntegrationCoefficient(_UnderlyingPtr, inCoefficient);
        }

        /// How much to decay the angle integral when the wheels are not touching the floor: new_value = e^(-decay * t) * initial_value
        /// Generated from method `JPH::MotorcycleController::SetLeanSpringIntegrationCoefficientDecay`.
        public unsafe void SetLeanSpringIntegrationCoefficientDecay(float inDecay)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_SetLeanSpringIntegrationCoefficientDecay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_SetLeanSpringIntegrationCoefficientDecay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_SetLeanSpringIntegrationCoefficientDecay(_Underlying *_this, float inDecay);
            __JPH_MotorcycleController_SetLeanSpringIntegrationCoefficientDecay(_UnderlyingPtr, inDecay);
        }

        /// How much to smooth the lean angle (0 = no smoothing, 1 = lean angle never changes)
        /// Note that this is frame rate dependent because the formula is: smoothing_factor * previous + (1 - smoothing_factor) * current
        /// Generated from method `JPH::MotorcycleController::SetLeanSmoothingFactor`.
        public unsafe void SetLeanSmoothingFactor(float inFactor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_SetLeanSmoothingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_SetLeanSmoothingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_SetLeanSmoothingFactor(_Underlying *_this, float inFactor);
            __JPH_MotorcycleController_SetLeanSmoothingFactor(_UnderlyingPtr, inFactor);
        }

        /// Set input from driver
        /// @param inForward Value between -1 and 1 for auto transmission and value between 0 and 1 indicating desired driving direction and amount the gas pedal is pressed
        /// @param inRight Value between -1 and 1 indicating desired steering angle (1 = right)
        /// @param inBrake Value between 0 and 1 indicating how strong the brake pedal is pressed
        /// @param inHandBrake Value between 0 and 1 indicating how strong the hand brake is pulled
        /// Generated from method `JPH::MotorcycleController::SetDriverInput`.
        public unsafe void SetDriverInput(float inForward, float inRight, float inBrake, float inHandBrake)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_SetDriverInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_SetDriverInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_SetDriverInput(_Underlying *_this, float inForward, float inRight, float inBrake, float inHandBrake);
            __JPH_MotorcycleController_SetDriverInput(_UnderlyingPtr, inForward, inRight, inBrake, inHandBrake);
        }

        /// Value between -1 and 1 for auto transmission and value between 0 and 1 indicating desired driving direction and amount the gas pedal is pressed
        /// Generated from method `JPH::MotorcycleController::SetForwardInput`.
        public unsafe void SetForwardInput(float inForward)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_SetForwardInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_SetForwardInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_SetForwardInput(_Underlying *_this, float inForward);
            __JPH_MotorcycleController_SetForwardInput(_UnderlyingPtr, inForward);
        }

        /// Value between -1 and 1 indicating desired steering angle (1 = right)
        /// Generated from method `JPH::MotorcycleController::SetRightInput`.
        public unsafe void SetRightInput(float inRight)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_SetRightInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_SetRightInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_SetRightInput(_Underlying *_this, float inRight);
            __JPH_MotorcycleController_SetRightInput(_UnderlyingPtr, inRight);
        }

        /// Value between 0 and 1 indicating how strong the brake pedal is pressed
        /// Generated from method `JPH::MotorcycleController::SetBrakeInput`.
        public unsafe void SetBrakeInput(float inBrake)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_SetBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_SetBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_SetBrakeInput(_Underlying *_this, float inBrake);
            __JPH_MotorcycleController_SetBrakeInput(_UnderlyingPtr, inBrake);
        }

        /// Value between 0 and 1 indicating how strong the hand brake is pulled
        /// Generated from method `JPH::MotorcycleController::SetHandBrakeInput`.
        public unsafe void SetHandBrakeInput(float inHandBrake)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_SetHandBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_SetHandBrakeInput", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_SetHandBrakeInput(_Underlying *_this, float inHandBrake);
            __JPH_MotorcycleController_SetHandBrakeInput(_UnderlyingPtr, inHandBrake);
        }

        /// Generated from method `JPH::MotorcycleController::SetDifferentialLimitedSlipRatio`.
        public unsafe void SetDifferentialLimitedSlipRatio(float inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_SetDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_SetDifferentialLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_SetDifferentialLimitedSlipRatio(_Underlying *_this, float inV);
            __JPH_MotorcycleController_SetDifferentialLimitedSlipRatio(_UnderlyingPtr, inV);
        }

        /// Generated from method `JPH::MotorcycleController::SetTireMaxImpulseCallback`.
        public unsafe void SetTireMaxImpulseCallback(JPH.Std.Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float inTireMaxImpulseCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_SetTireMaxImpulseCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_SetTireMaxImpulseCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_SetTireMaxImpulseCallback(_Underlying *_this, JPH.Std.Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float._Underlying *inTireMaxImpulseCallback);
            __JPH_MotorcycleController_SetTireMaxImpulseCallback(_UnderlyingPtr, inTireMaxImpulseCallback._UnderlyingPtr);
        }

        /// Debug drawing of RPM meter
        /// Generated from method `JPH::MotorcycleController::SetRPMMeter`.
        public unsafe void SetRPMMeter(JPH.Const_Vec3 inPosition, float inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorcycleController_SetRPMMeter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorcycleController_SetRPMMeter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorcycleController_SetRPMMeter(_Underlying *_this, JPH.Vec3._Underlying *inPosition, float inSize);
            __JPH_MotorcycleController_SetRPMMeter(_UnderlyingPtr, inPosition._UnderlyingPtr, inSize);
        }
    }

    /// This is used for optional parameters of class `MotorcycleController` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_MotorcycleController`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `MotorcycleController`/`Const_MotorcycleController` directly.
    public class _InOptMut_MotorcycleController
    {
        public MotorcycleController? Opt;

        public _InOptMut_MotorcycleController() {}
        public _InOptMut_MotorcycleController(MotorcycleController value) {Opt = value;}
        public static implicit operator _InOptMut_MotorcycleController(MotorcycleController value) {return new(value);}
    }

    /// This is used for optional parameters of class `MotorcycleController` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_MotorcycleController`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `MotorcycleController`/`Const_MotorcycleController` to pass it to the function.
    public class _InOptConst_MotorcycleController
    {
        public Const_MotorcycleController? Opt;

        public _InOptConst_MotorcycleController() {}
        public _InOptConst_MotorcycleController(Const_MotorcycleController value) {Opt = value;}
        public static implicit operator _InOptConst_MotorcycleController(Const_MotorcycleController value) {return new(value);}
    }
}
