// machine generated, do not edit
public static partial class JPH
{
    /// How gears are shifted
    public enum ETransmissionMode : byte
    {
        ///< Automatically shift gear up and down
        Auto = 0,
        ///< Manual gear shift (call SetTransmissionInput)
        Manual = 1,
    }

    /// Configuration for the transmission of a vehicle (gear box)
    /// Generated from class `JPH::VehicleTransmissionSettings`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleTransmission`
    /// This is the const half of the class.
    public class Const_VehicleTransmissionSettings : JPH.Object<Const_VehicleTransmissionSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleTransmissionSettings_Destroy(_Underlying *_this);
            __JPH_VehicleTransmissionSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_VehicleTransmissionSettings() {Dispose(false);}

        ///< How to switch gears
        public unsafe JPH.ETransmissionMode mMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ETransmissionMode *__JPH_VehicleTransmissionSettings_Get_mMode(_Underlying *_this);
                return *__JPH_VehicleTransmissionSettings_Get_mMode(_UnderlyingPtr);
            }
        }

        ///< Ratio in rotation rate between engine and gear box, first element is 1st gear, 2nd element 2nd gear etc.
        public unsafe JPH.Const_Array_Float mGearRatios
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Array_Float._Underlying *__JPH_VehicleTransmissionSettings_Get_mGearRatios(_Underlying *_this);
                JPH.Const_Array_Float __ret;
                __ret = new(__JPH_VehicleTransmissionSettings_Get_mGearRatios(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Ratio in rotation rate between engine and gear box when driving in reverse
        public unsafe JPH.Const_Array_Float mReverseGearRatios
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mReverseGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mReverseGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Array_Float._Underlying *__JPH_VehicleTransmissionSettings_Get_mReverseGearRatios(_Underlying *_this);
                JPH.Const_Array_Float __ret;
                __ret = new(__JPH_VehicleTransmissionSettings_Get_mReverseGearRatios(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< How long it takes to switch gears (s), only used in auto mode
        public unsafe float mSwitchTime
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mSwitchTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mSwitchTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmissionSettings_Get_mSwitchTime(_Underlying *_this);
                return *__JPH_VehicleTransmissionSettings_Get_mSwitchTime(_UnderlyingPtr);
            }
        }

        ///< How long it takes to release the clutch (go to full friction), only used in auto mode
        public unsafe float mClutchReleaseTime
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mClutchReleaseTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mClutchReleaseTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmissionSettings_Get_mClutchReleaseTime(_Underlying *_this);
                return *__JPH_VehicleTransmissionSettings_Get_mClutchReleaseTime(_UnderlyingPtr);
            }
        }

        ///< How long to wait after releasing the clutch before another switch is attempted (s), only used in auto mode
        public unsafe float mSwitchLatency
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mSwitchLatency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mSwitchLatency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmissionSettings_Get_mSwitchLatency(_Underlying *_this);
                return *__JPH_VehicleTransmissionSettings_Get_mSwitchLatency(_UnderlyingPtr);
            }
        }

        ///< If RPM of engine is bigger then this we will shift a gear up, only used in auto mode
        public unsafe float mShiftUpRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mShiftUpRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mShiftUpRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmissionSettings_Get_mShiftUpRPM(_Underlying *_this);
                return *__JPH_VehicleTransmissionSettings_Get_mShiftUpRPM(_UnderlyingPtr);
            }
        }

        ///< If RPM of engine is smaller then this we will shift a gear down, only used in auto mode
        public unsafe float mShiftDownRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mShiftDownRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mShiftDownRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmissionSettings_Get_mShiftDownRPM(_Underlying *_this);
                return *__JPH_VehicleTransmissionSettings_Get_mShiftDownRPM(_UnderlyingPtr);
            }
        }

        ///< Strength of the clutch when fully engaged. Total torque a clutch applies is Torque = ClutchStrength * (Velocity Engine - Avg Velocity Wheels At Clutch) (units: k m^2 s^-1)
        public unsafe float mClutchStrength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mClutchStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_Get_mClutchStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmissionSettings_Get_mClutchStrength(_Underlying *_this);
                return *__JPH_VehicleTransmissionSettings_Get_mClutchStrength(_UnderlyingPtr);
            }
        }

        internal unsafe Const_VehicleTransmissionSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_VehicleTransmissionSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmissionSettings._Underlying *__JPH_VehicleTransmissionSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleTransmissionSettings_DefaultConstruct();
        }

        /// Constructs `JPH::VehicleTransmissionSettings` elementwise.
        public unsafe Const_VehicleTransmissionSettings(JPH.ETransmissionMode mMode, JPH._ByValue_Array_Float mGearRatios, JPH._ByValue_Array_Float mReverseGearRatios, float mSwitchTime, float mClutchReleaseTime, float mSwitchLatency, float mShiftUpRPM, float mShiftDownRPM, float mClutchStrength) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmissionSettings._Underlying *__JPH_VehicleTransmissionSettings_ConstructFrom(JPH.ETransmissionMode mMode, JPH._PassBy mGearRatios_pass_by, JPH.Array_Float._Underlying *mGearRatios, JPH._PassBy mReverseGearRatios_pass_by, JPH.Array_Float._Underlying *mReverseGearRatios, float mSwitchTime, float mClutchReleaseTime, float mSwitchLatency, float mShiftUpRPM, float mShiftDownRPM, float mClutchStrength);
            _UnderlyingPtr = __JPH_VehicleTransmissionSettings_ConstructFrom(mMode, mGearRatios.PassByMode, mGearRatios.Value is not null ? mGearRatios.Value._UnderlyingPtr : null, mReverseGearRatios.PassByMode, mReverseGearRatios.Value is not null ? mReverseGearRatios.Value._UnderlyingPtr : null, mSwitchTime, mClutchReleaseTime, mSwitchLatency, mShiftUpRPM, mShiftDownRPM, mClutchStrength);
            if (mGearRatios.Value is not null) _KeepAlive(mGearRatios.Value);
            if (mReverseGearRatios.Value is not null) _KeepAlive(mReverseGearRatios.Value);
        }

        /// Generated from constructor `JPH::VehicleTransmissionSettings::VehicleTransmissionSettings`.
        public unsafe Const_VehicleTransmissionSettings(JPH._ByValue_VehicleTransmissionSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmissionSettings._Underlying *__JPH_VehicleTransmissionSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.VehicleTransmissionSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleTransmissionSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::VehicleTransmissionSettings::VehicleTransmissionSettings`.
        public Const_VehicleTransmissionSettings(Const_VehicleTransmissionSettings _other) : this(new _ByValue_VehicleTransmissionSettings(_other)) {}

        /// Generated from constructor `JPH::VehicleTransmissionSettings::VehicleTransmissionSettings`.
        public Const_VehicleTransmissionSettings(VehicleTransmissionSettings _other) : this((Const_VehicleTransmissionSettings)_other) {}

        /// Generated from method `JPH::VehicleTransmissionSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleTransmissionSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleTransmissionSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleTransmissionSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_VehicleTransmissionSettings_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleTransmissionSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleTransmissionSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleTransmissionSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleTransmissionSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleTransmissionSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleTransmissionSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_VehicleTransmissionSettings_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleTransmissionSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleTransmissionSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleTransmissionSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleTransmissionSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleTransmissionSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleTransmissionSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_VehicleTransmissionSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleTransmissionSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_VehicleTransmissionSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::VehicleTransmissionSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleTransmissionSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleTransmissionSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleTransmissionSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_VehicleTransmissionSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleTransmissionSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_VehicleTransmissionSettings_void_ptr_void_ptr(inPointer, inPlace);
        }
    }

    /// Configuration for the transmission of a vehicle (gear box)
    /// Generated from class `JPH::VehicleTransmissionSettings`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleTransmission`
    /// This is the non-const half of the class.
    public class VehicleTransmissionSettings : Const_VehicleTransmissionSettings
    {
        ///< How to switch gears
        public new unsafe ref JPH.ETransmissionMode mMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ETransmissionMode *__JPH_VehicleTransmissionSettings_GetMutable_mMode(_Underlying *_this);
                return ref *__JPH_VehicleTransmissionSettings_GetMutable_mMode(_UnderlyingPtr);
            }
        }

        ///< Ratio in rotation rate between engine and gear box, first element is 1st gear, 2nd element 2nd gear etc.
        public new unsafe JPH.Array_Float mGearRatios
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Array_Float._Underlying *__JPH_VehicleTransmissionSettings_GetMutable_mGearRatios(_Underlying *_this);
                JPH.Array_Float __ret;
                __ret = new(__JPH_VehicleTransmissionSettings_GetMutable_mGearRatios(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Ratio in rotation rate between engine and gear box when driving in reverse
        public new unsafe JPH.Array_Float mReverseGearRatios
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mReverseGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mReverseGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Array_Float._Underlying *__JPH_VehicleTransmissionSettings_GetMutable_mReverseGearRatios(_Underlying *_this);
                JPH.Array_Float __ret;
                __ret = new(__JPH_VehicleTransmissionSettings_GetMutable_mReverseGearRatios(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< How long it takes to switch gears (s), only used in auto mode
        public new unsafe ref float mSwitchTime
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mSwitchTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mSwitchTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmissionSettings_GetMutable_mSwitchTime(_Underlying *_this);
                return ref *__JPH_VehicleTransmissionSettings_GetMutable_mSwitchTime(_UnderlyingPtr);
            }
        }

        ///< How long it takes to release the clutch (go to full friction), only used in auto mode
        public new unsafe ref float mClutchReleaseTime
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mClutchReleaseTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mClutchReleaseTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmissionSettings_GetMutable_mClutchReleaseTime(_Underlying *_this);
                return ref *__JPH_VehicleTransmissionSettings_GetMutable_mClutchReleaseTime(_UnderlyingPtr);
            }
        }

        ///< How long to wait after releasing the clutch before another switch is attempted (s), only used in auto mode
        public new unsafe ref float mSwitchLatency
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mSwitchLatency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mSwitchLatency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmissionSettings_GetMutable_mSwitchLatency(_Underlying *_this);
                return ref *__JPH_VehicleTransmissionSettings_GetMutable_mSwitchLatency(_UnderlyingPtr);
            }
        }

        ///< If RPM of engine is bigger then this we will shift a gear up, only used in auto mode
        public new unsafe ref float mShiftUpRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mShiftUpRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mShiftUpRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmissionSettings_GetMutable_mShiftUpRPM(_Underlying *_this);
                return ref *__JPH_VehicleTransmissionSettings_GetMutable_mShiftUpRPM(_UnderlyingPtr);
            }
        }

        ///< If RPM of engine is smaller then this we will shift a gear down, only used in auto mode
        public new unsafe ref float mShiftDownRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mShiftDownRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mShiftDownRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmissionSettings_GetMutable_mShiftDownRPM(_Underlying *_this);
                return ref *__JPH_VehicleTransmissionSettings_GetMutable_mShiftDownRPM(_UnderlyingPtr);
            }
        }

        ///< Strength of the clutch when fully engaged. Total torque a clutch applies is Torque = ClutchStrength * (Velocity Engine - Avg Velocity Wheels At Clutch) (units: k m^2 s^-1)
        public new unsafe ref float mClutchStrength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mClutchStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_GetMutable_mClutchStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmissionSettings_GetMutable_mClutchStrength(_Underlying *_this);
                return ref *__JPH_VehicleTransmissionSettings_GetMutable_mClutchStrength(_UnderlyingPtr);
            }
        }

        internal unsafe VehicleTransmissionSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe VehicleTransmissionSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmissionSettings._Underlying *__JPH_VehicleTransmissionSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleTransmissionSettings_DefaultConstruct();
        }

        /// Constructs `JPH::VehicleTransmissionSettings` elementwise.
        public unsafe VehicleTransmissionSettings(JPH.ETransmissionMode mMode, JPH._ByValue_Array_Float mGearRatios, JPH._ByValue_Array_Float mReverseGearRatios, float mSwitchTime, float mClutchReleaseTime, float mSwitchLatency, float mShiftUpRPM, float mShiftDownRPM, float mClutchStrength) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmissionSettings._Underlying *__JPH_VehicleTransmissionSettings_ConstructFrom(JPH.ETransmissionMode mMode, JPH._PassBy mGearRatios_pass_by, JPH.Array_Float._Underlying *mGearRatios, JPH._PassBy mReverseGearRatios_pass_by, JPH.Array_Float._Underlying *mReverseGearRatios, float mSwitchTime, float mClutchReleaseTime, float mSwitchLatency, float mShiftUpRPM, float mShiftDownRPM, float mClutchStrength);
            _UnderlyingPtr = __JPH_VehicleTransmissionSettings_ConstructFrom(mMode, mGearRatios.PassByMode, mGearRatios.Value is not null ? mGearRatios.Value._UnderlyingPtr : null, mReverseGearRatios.PassByMode, mReverseGearRatios.Value is not null ? mReverseGearRatios.Value._UnderlyingPtr : null, mSwitchTime, mClutchReleaseTime, mSwitchLatency, mShiftUpRPM, mShiftDownRPM, mClutchStrength);
            if (mGearRatios.Value is not null) _KeepAlive(mGearRatios.Value);
            if (mReverseGearRatios.Value is not null) _KeepAlive(mReverseGearRatios.Value);
        }

        /// Generated from constructor `JPH::VehicleTransmissionSettings::VehicleTransmissionSettings`.
        public unsafe VehicleTransmissionSettings(JPH._ByValue_VehicleTransmissionSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmissionSettings._Underlying *__JPH_VehicleTransmissionSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.VehicleTransmissionSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleTransmissionSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::VehicleTransmissionSettings::VehicleTransmissionSettings`.
        public VehicleTransmissionSettings(Const_VehicleTransmissionSettings _other) : this(new _ByValue_VehicleTransmissionSettings(_other)) {}

        /// Generated from constructor `JPH::VehicleTransmissionSettings::VehicleTransmissionSettings`.
        public VehicleTransmissionSettings(VehicleTransmissionSettings _other) : this((Const_VehicleTransmissionSettings)_other) {}

        /// Generated from method `JPH::VehicleTransmissionSettings::operator=`.
        public unsafe JPH.VehicleTransmissionSettings Assign(JPH._ByValue_VehicleTransmissionSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmissionSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmissionSettings._Underlying *__JPH_VehicleTransmissionSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.VehicleTransmissionSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_VehicleTransmissionSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `VehicleTransmissionSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `VehicleTransmissionSettings`/`Const_VehicleTransmissionSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_VehicleTransmissionSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_VehicleTransmissionSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_VehicleTransmissionSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_VehicleTransmissionSettings(Const_VehicleTransmissionSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_VehicleTransmissionSettings(Const_VehicleTransmissionSettings arg) {return new(arg);}
        public _ByValue_VehicleTransmissionSettings(JPH._Moved<VehicleTransmissionSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_VehicleTransmissionSettings(JPH._Moved<VehicleTransmissionSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `VehicleTransmissionSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_VehicleTransmissionSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleTransmissionSettings`/`Const_VehicleTransmissionSettings` directly.
    public class _InOptMut_VehicleTransmissionSettings
    {
        public VehicleTransmissionSettings? Opt;

        public _InOptMut_VehicleTransmissionSettings() {}
        public _InOptMut_VehicleTransmissionSettings(VehicleTransmissionSettings value) {Opt = value;}
        public static implicit operator _InOptMut_VehicleTransmissionSettings(VehicleTransmissionSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `VehicleTransmissionSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_VehicleTransmissionSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleTransmissionSettings`/`Const_VehicleTransmissionSettings` to pass it to the function.
    public class _InOptConst_VehicleTransmissionSettings
    {
        public Const_VehicleTransmissionSettings? Opt;

        public _InOptConst_VehicleTransmissionSettings() {}
        public _InOptConst_VehicleTransmissionSettings(Const_VehicleTransmissionSettings value) {Opt = value;}
        public static implicit operator _InOptConst_VehicleTransmissionSettings(Const_VehicleTransmissionSettings value) {return new(value);}
    }

    /// Runtime data for transmission
    /// Generated from class `JPH::VehicleTransmission`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleTransmissionSettings`
    /// This is the const half of the class.
    public class Const_VehicleTransmission : JPH.Object<Const_VehicleTransmission>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleTransmission_Destroy(_Underlying *_this);
            __JPH_VehicleTransmission_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_VehicleTransmission() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_VehicleTransmissionSettings(Const_VehicleTransmission self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_UpcastTo_JPH_VehicleTransmissionSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_UpcastTo_JPH_VehicleTransmissionSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleTransmissionSettings._Underlying *__JPH_VehicleTransmission_UpcastTo_JPH_VehicleTransmissionSettings(_Underlying *_this);
            JPH.Const_VehicleTransmissionSettings ret = new(__JPH_VehicleTransmission_UpcastTo_JPH_VehicleTransmissionSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_VehicleTransmission(JPH.Const_VehicleTransmissionSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_StaticDowncastFrom_JPH_VehicleTransmissionSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_StaticDowncastFrom_JPH_VehicleTransmissionSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleTransmission_StaticDowncastFrom_JPH_VehicleTransmissionSettings(JPH.Const_VehicleTransmissionSettings._Underlying *_this);
            Const_VehicleTransmission ret = new(__JPH_VehicleTransmission_StaticDowncastFrom_JPH_VehicleTransmissionSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< How to switch gears
        public unsafe JPH.ETransmissionMode mMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ETransmissionMode *__JPH_VehicleTransmission_Get_mMode(_Underlying *_this);
                return *__JPH_VehicleTransmission_Get_mMode(_UnderlyingPtr);
            }
        }

        ///< Ratio in rotation rate between engine and gear box, first element is 1st gear, 2nd element 2nd gear etc.
        public unsafe JPH.Const_Array_Float mGearRatios
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Array_Float._Underlying *__JPH_VehicleTransmission_Get_mGearRatios(_Underlying *_this);
                JPH.Const_Array_Float __ret;
                __ret = new(__JPH_VehicleTransmission_Get_mGearRatios(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Ratio in rotation rate between engine and gear box when driving in reverse
        public unsafe JPH.Const_Array_Float mReverseGearRatios
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mReverseGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mReverseGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Array_Float._Underlying *__JPH_VehicleTransmission_Get_mReverseGearRatios(_Underlying *_this);
                JPH.Const_Array_Float __ret;
                __ret = new(__JPH_VehicleTransmission_Get_mReverseGearRatios(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< How long it takes to switch gears (s), only used in auto mode
        public unsafe float mSwitchTime
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mSwitchTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mSwitchTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmission_Get_mSwitchTime(_Underlying *_this);
                return *__JPH_VehicleTransmission_Get_mSwitchTime(_UnderlyingPtr);
            }
        }

        ///< How long it takes to release the clutch (go to full friction), only used in auto mode
        public unsafe float mClutchReleaseTime
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mClutchReleaseTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mClutchReleaseTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmission_Get_mClutchReleaseTime(_Underlying *_this);
                return *__JPH_VehicleTransmission_Get_mClutchReleaseTime(_UnderlyingPtr);
            }
        }

        ///< How long to wait after releasing the clutch before another switch is attempted (s), only used in auto mode
        public unsafe float mSwitchLatency
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mSwitchLatency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mSwitchLatency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmission_Get_mSwitchLatency(_Underlying *_this);
                return *__JPH_VehicleTransmission_Get_mSwitchLatency(_UnderlyingPtr);
            }
        }

        ///< If RPM of engine is bigger then this we will shift a gear up, only used in auto mode
        public unsafe float mShiftUpRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mShiftUpRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mShiftUpRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmission_Get_mShiftUpRPM(_Underlying *_this);
                return *__JPH_VehicleTransmission_Get_mShiftUpRPM(_UnderlyingPtr);
            }
        }

        ///< If RPM of engine is smaller then this we will shift a gear down, only used in auto mode
        public unsafe float mShiftDownRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mShiftDownRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mShiftDownRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmission_Get_mShiftDownRPM(_Underlying *_this);
                return *__JPH_VehicleTransmission_Get_mShiftDownRPM(_UnderlyingPtr);
            }
        }

        ///< Strength of the clutch when fully engaged. Total torque a clutch applies is Torque = ClutchStrength * (Velocity Engine - Avg Velocity Wheels At Clutch) (units: k m^2 s^-1)
        public unsafe float mClutchStrength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mClutchStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_Get_mClutchStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmission_Get_mClutchStrength(_Underlying *_this);
                return *__JPH_VehicleTransmission_Get_mClutchStrength(_UnderlyingPtr);
            }
        }

        internal unsafe Const_VehicleTransmission(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_VehicleTransmission() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmission._Underlying *__JPH_VehicleTransmission_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleTransmission_DefaultConstruct();
        }

        /// Generated from constructor `JPH::VehicleTransmission::VehicleTransmission`.
        public unsafe Const_VehicleTransmission(JPH._ByValue_VehicleTransmission _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmission._Underlying *__JPH_VehicleTransmission_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.VehicleTransmission._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleTransmission_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::VehicleTransmission::VehicleTransmission`.
        public Const_VehicleTransmission(Const_VehicleTransmission _other) : this(new _ByValue_VehicleTransmission(_other)) {}

        /// Generated from constructor `JPH::VehicleTransmission::VehicleTransmission`.
        public Const_VehicleTransmission(VehicleTransmission _other) : this((Const_VehicleTransmission)_other) {}

        /// Current gear, -1 = reverse, 0 = neutral, 1 = 1st gear etc.
        /// Generated from method `JPH::VehicleTransmission::GetCurrentGear`.
        public unsafe int GetCurrentGear()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_GetCurrentGear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_GetCurrentGear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_VehicleTransmission_GetCurrentGear(_Underlying *_this);
            return __JPH_VehicleTransmission_GetCurrentGear(_UnderlyingPtr);
        }

        /// Value between 0 and 1 indicating how much friction the clutch gives (0 = no friction, 1 = full friction)
        /// Generated from method `JPH::VehicleTransmission::GetClutchFriction`.
        public unsafe float GetClutchFriction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_GetClutchFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_GetClutchFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_VehicleTransmission_GetClutchFriction(_Underlying *_this);
            return __JPH_VehicleTransmission_GetClutchFriction(_UnderlyingPtr);
        }

        /// If the auto box is currently switching gears
        /// Generated from method `JPH::VehicleTransmission::IsSwitchingGear`.
        public unsafe bool IsSwitchingGear()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_IsSwitchingGear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_IsSwitchingGear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_VehicleTransmission_IsSwitchingGear(_Underlying *_this);
            return __JPH_VehicleTransmission_IsSwitchingGear(_UnderlyingPtr) != 0;
        }

        /// Return the transmission ratio based on the current gear (ratio between engine and differential)
        /// Generated from method `JPH::VehicleTransmission::GetCurrentRatio`.
        public unsafe float GetCurrentRatio()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_GetCurrentRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_GetCurrentRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_VehicleTransmission_GetCurrentRatio(_Underlying *_this);
            return __JPH_VehicleTransmission_GetCurrentRatio(_UnderlyingPtr);
        }

        /// Only allow sleeping when the transmission is idle
        /// Generated from method `JPH::VehicleTransmission::AllowSleep`.
        public unsafe bool AllowSleep()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_AllowSleep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_AllowSleep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_VehicleTransmission_AllowSleep(_Underlying *_this);
            return __JPH_VehicleTransmission_AllowSleep(_UnderlyingPtr) != 0;
        }
    }

    /// Runtime data for transmission
    /// Generated from class `JPH::VehicleTransmission`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleTransmissionSettings`
    /// This is the non-const half of the class.
    public class VehicleTransmission : Const_VehicleTransmission
    {
        // Upcasts:
        public static unsafe implicit operator JPH.VehicleTransmissionSettings(VehicleTransmission self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_UpcastTo_JPH_VehicleTransmissionSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_UpcastTo_JPH_VehicleTransmissionSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmissionSettings._Underlying *__JPH_VehicleTransmission_UpcastTo_JPH_VehicleTransmissionSettings(_Underlying *_this);
            JPH.VehicleTransmissionSettings ret = new(__JPH_VehicleTransmission_UpcastTo_JPH_VehicleTransmissionSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator VehicleTransmission(JPH.VehicleTransmissionSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_StaticDowncastFrom_JPH_VehicleTransmissionSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_StaticDowncastFrom_JPH_VehicleTransmissionSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleTransmission_StaticDowncastFrom_JPH_VehicleTransmissionSettings(JPH.VehicleTransmissionSettings._Underlying *_this);
            VehicleTransmission ret = new(__JPH_VehicleTransmission_StaticDowncastFrom_JPH_VehicleTransmissionSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< How to switch gears
        public new unsafe ref JPH.ETransmissionMode mMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ETransmissionMode *__JPH_VehicleTransmission_GetMutable_mMode(_Underlying *_this);
                return ref *__JPH_VehicleTransmission_GetMutable_mMode(_UnderlyingPtr);
            }
        }

        ///< Ratio in rotation rate between engine and gear box, first element is 1st gear, 2nd element 2nd gear etc.
        public new unsafe JPH.Array_Float mGearRatios
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Array_Float._Underlying *__JPH_VehicleTransmission_GetMutable_mGearRatios(_Underlying *_this);
                JPH.Array_Float __ret;
                __ret = new(__JPH_VehicleTransmission_GetMutable_mGearRatios(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Ratio in rotation rate between engine and gear box when driving in reverse
        public new unsafe JPH.Array_Float mReverseGearRatios
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mReverseGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mReverseGearRatios", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Array_Float._Underlying *__JPH_VehicleTransmission_GetMutable_mReverseGearRatios(_Underlying *_this);
                JPH.Array_Float __ret;
                __ret = new(__JPH_VehicleTransmission_GetMutable_mReverseGearRatios(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< How long it takes to switch gears (s), only used in auto mode
        public new unsafe ref float mSwitchTime
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mSwitchTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mSwitchTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmission_GetMutable_mSwitchTime(_Underlying *_this);
                return ref *__JPH_VehicleTransmission_GetMutable_mSwitchTime(_UnderlyingPtr);
            }
        }

        ///< How long it takes to release the clutch (go to full friction), only used in auto mode
        public new unsafe ref float mClutchReleaseTime
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mClutchReleaseTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mClutchReleaseTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmission_GetMutable_mClutchReleaseTime(_Underlying *_this);
                return ref *__JPH_VehicleTransmission_GetMutable_mClutchReleaseTime(_UnderlyingPtr);
            }
        }

        ///< How long to wait after releasing the clutch before another switch is attempted (s), only used in auto mode
        public new unsafe ref float mSwitchLatency
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mSwitchLatency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mSwitchLatency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmission_GetMutable_mSwitchLatency(_Underlying *_this);
                return ref *__JPH_VehicleTransmission_GetMutable_mSwitchLatency(_UnderlyingPtr);
            }
        }

        ///< If RPM of engine is bigger then this we will shift a gear up, only used in auto mode
        public new unsafe ref float mShiftUpRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mShiftUpRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mShiftUpRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmission_GetMutable_mShiftUpRPM(_Underlying *_this);
                return ref *__JPH_VehicleTransmission_GetMutable_mShiftUpRPM(_UnderlyingPtr);
            }
        }

        ///< If RPM of engine is smaller then this we will shift a gear down, only used in auto mode
        public new unsafe ref float mShiftDownRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mShiftDownRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mShiftDownRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmission_GetMutable_mShiftDownRPM(_Underlying *_this);
                return ref *__JPH_VehicleTransmission_GetMutable_mShiftDownRPM(_UnderlyingPtr);
            }
        }

        ///< Strength of the clutch when fully engaged. Total torque a clutch applies is Torque = ClutchStrength * (Velocity Engine - Avg Velocity Wheels At Clutch) (units: k m^2 s^-1)
        public new unsafe ref float mClutchStrength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mClutchStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_GetMutable_mClutchStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTransmission_GetMutable_mClutchStrength(_Underlying *_this);
                return ref *__JPH_VehicleTransmission_GetMutable_mClutchStrength(_UnderlyingPtr);
            }
        }

        internal unsafe VehicleTransmission(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe VehicleTransmission() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmission._Underlying *__JPH_VehicleTransmission_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleTransmission_DefaultConstruct();
        }

        /// Generated from constructor `JPH::VehicleTransmission::VehicleTransmission`.
        public unsafe VehicleTransmission(JPH._ByValue_VehicleTransmission _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmission._Underlying *__JPH_VehicleTransmission_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.VehicleTransmission._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleTransmission_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::VehicleTransmission::VehicleTransmission`.
        public VehicleTransmission(Const_VehicleTransmission _other) : this(new _ByValue_VehicleTransmission(_other)) {}

        /// Generated from constructor `JPH::VehicleTransmission::VehicleTransmission`.
        public VehicleTransmission(VehicleTransmission _other) : this((Const_VehicleTransmission)_other) {}

        /// Generated from method `JPH::VehicleTransmission::operator=`.
        public unsafe JPH.VehicleTransmission Assign(JPH._ByValue_VehicleTransmission _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTransmission._Underlying *__JPH_VehicleTransmission_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.VehicleTransmission._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_VehicleTransmission_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Set input from driver regarding the transmission (only relevant when transmission is set to manual mode)
        /// @param inCurrentGear Current gear, -1 = reverse, 0 = neutral, 1 = 1st gear etc.
        /// @param inClutchFriction Value between 0 and 1 indicating how much friction the clutch gives (0 = no friction, 1 = full friction)
        /// Generated from method `JPH::VehicleTransmission::Set`.
        public unsafe void Set(int inCurrentGear, float inClutchFriction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_Set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_Set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleTransmission_Set(_Underlying *_this, int inCurrentGear, float inClutchFriction);
            __JPH_VehicleTransmission_Set(_UnderlyingPtr, inCurrentGear, inClutchFriction);
        }

        /// Update the current gear and clutch friction if the transmission is in auto mode
        /// @param inDeltaTime Time step delta time in s
        /// @param inCurrentRPM Current RPM for engine
        /// @param inForwardInput Hint if the user wants to drive forward (> 0) or backwards (< 0)
        /// @param inCanShiftUp Indicates if we want to allow the transmission to shift up (e.g. pass false if wheels are slipping)
        /// Generated from method `JPH::VehicleTransmission::Update`.
        public unsafe void Update(float inDeltaTime, float inCurrentRPM, float inForwardInput, bool inCanShiftUp)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTransmission_Update", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTransmission_Update", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleTransmission_Update(_Underlying *_this, float inDeltaTime, float inCurrentRPM, float inForwardInput, byte inCanShiftUp);
            __JPH_VehicleTransmission_Update(_UnderlyingPtr, inDeltaTime, inCurrentRPM, inForwardInput, inCanShiftUp ? (byte)1 : (byte)0);
        }
    }

    /// This is used as a function parameter when the underlying function receives `VehicleTransmission` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `VehicleTransmission`/`Const_VehicleTransmission` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_VehicleTransmission
    {
        #pragma warning disable CS0649
        internal readonly Const_VehicleTransmission? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_VehicleTransmission() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_VehicleTransmission(Const_VehicleTransmission new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_VehicleTransmission(Const_VehicleTransmission arg) {return new(arg);}
        public _ByValue_VehicleTransmission(JPH._Moved<VehicleTransmission> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_VehicleTransmission(JPH._Moved<VehicleTransmission> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `VehicleTransmission` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_VehicleTransmission`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleTransmission`/`Const_VehicleTransmission` directly.
    public class _InOptMut_VehicleTransmission
    {
        public VehicleTransmission? Opt;

        public _InOptMut_VehicleTransmission() {}
        public _InOptMut_VehicleTransmission(VehicleTransmission value) {Opt = value;}
        public static implicit operator _InOptMut_VehicleTransmission(VehicleTransmission value) {return new(value);}
    }

    /// This is used for optional parameters of class `VehicleTransmission` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_VehicleTransmission`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleTransmission`/`Const_VehicleTransmission` to pass it to the function.
    public class _InOptConst_VehicleTransmission
    {
        public Const_VehicleTransmission? Opt;

        public _InOptConst_VehicleTransmission() {}
        public _InOptConst_VehicleTransmission(Const_VehicleTransmission value) {Opt = value;}
        public static implicit operator _InOptConst_VehicleTransmission(Const_VehicleTransmission value) {return new(value);}
    }
}
