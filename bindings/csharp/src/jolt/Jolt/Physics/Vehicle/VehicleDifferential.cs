// machine generated, do not edit
public static partial class JPH
{
    /// Generated from class `JPH::VehicleDifferentialSettings`.
    /// This is the const half of the class.
    public class Const_VehicleDifferentialSettings : JPH.Object<Const_VehicleDifferentialSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleDifferentialSettings_Destroy(_Underlying *_this);
            __JPH_VehicleDifferentialSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_VehicleDifferentialSettings() {Dispose(false);}

        ///< Index (in mWheels) that represents the left wheel of this differential (can be -1 to indicate no wheel)
        public unsafe int mLeftWheel
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_Get_mLeftWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_Get_mLeftWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_VehicleDifferentialSettings_Get_mLeftWheel(_Underlying *_this);
                return *__JPH_VehicleDifferentialSettings_Get_mLeftWheel(_UnderlyingPtr);
            }
        }

        ///< Index (in mWheels) that represents the right wheel of this differential (can be -1 to indicate no wheel)
        public unsafe int mRightWheel
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_Get_mRightWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_Get_mRightWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_VehicleDifferentialSettings_Get_mRightWheel(_Underlying *_this);
                return *__JPH_VehicleDifferentialSettings_Get_mRightWheel(_UnderlyingPtr);
            }
        }

        ///< Ratio between rotation speed of gear box and wheels
        public unsafe float mDifferentialRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_Get_mDifferentialRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_Get_mDifferentialRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleDifferentialSettings_Get_mDifferentialRatio(_Underlying *_this);
                return *__JPH_VehicleDifferentialSettings_Get_mDifferentialRatio(_UnderlyingPtr);
            }
        }

        ///< Defines how the engine torque is split across the left and right wheel (0 = left, 0.5 = center, 1 = right)
        public unsafe float mLeftRightSplit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_Get_mLeftRightSplit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_Get_mLeftRightSplit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleDifferentialSettings_Get_mLeftRightSplit(_Underlying *_this);
                return *__JPH_VehicleDifferentialSettings_Get_mLeftRightSplit(_UnderlyingPtr);
            }
        }

        ///< Ratio max / min wheel speed. When this ratio is exceeded, all torque gets distributed to the slowest moving wheel. This allows implementing a limited slip differential. Set to FLT_MAX for an open differential. Value should be > 1.
        public unsafe float mLimitedSlipRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_Get_mLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_Get_mLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleDifferentialSettings_Get_mLimitedSlipRatio(_Underlying *_this);
                return *__JPH_VehicleDifferentialSettings_Get_mLimitedSlipRatio(_UnderlyingPtr);
            }
        }

        ///< How much of the engines torque is applied to this differential (0 = none, 1 = full), make sure the sum of all differentials is 1.
        public unsafe float mEngineTorqueRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_Get_mEngineTorqueRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_Get_mEngineTorqueRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleDifferentialSettings_Get_mEngineTorqueRatio(_Underlying *_this);
                return *__JPH_VehicleDifferentialSettings_Get_mEngineTorqueRatio(_UnderlyingPtr);
            }
        }

        internal unsafe Const_VehicleDifferentialSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_VehicleDifferentialSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleDifferentialSettings._Underlying *__JPH_VehicleDifferentialSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleDifferentialSettings_DefaultConstruct();
        }

        /// Constructs `JPH::VehicleDifferentialSettings` elementwise.
        public unsafe Const_VehicleDifferentialSettings(int mLeftWheel, int mRightWheel, float mDifferentialRatio, float mLeftRightSplit, float mLimitedSlipRatio, float mEngineTorqueRatio) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleDifferentialSettings._Underlying *__JPH_VehicleDifferentialSettings_ConstructFrom(int mLeftWheel, int mRightWheel, float mDifferentialRatio, float mLeftRightSplit, float mLimitedSlipRatio, float mEngineTorqueRatio);
            _UnderlyingPtr = __JPH_VehicleDifferentialSettings_ConstructFrom(mLeftWheel, mRightWheel, mDifferentialRatio, mLeftRightSplit, mLimitedSlipRatio, mEngineTorqueRatio);
        }

        /// Generated from constructor `JPH::VehicleDifferentialSettings::VehicleDifferentialSettings`.
        public unsafe Const_VehicleDifferentialSettings(JPH.Const_VehicleDifferentialSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleDifferentialSettings._Underlying *__JPH_VehicleDifferentialSettings_ConstructFromAnother(JPH.VehicleDifferentialSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleDifferentialSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::VehicleDifferentialSettings::VehicleDifferentialSettings`.
        public Const_VehicleDifferentialSettings(VehicleDifferentialSettings _other) : this((Const_VehicleDifferentialSettings)_other) {}

        /// Generated from method `JPH::VehicleDifferentialSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleDifferentialSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleDifferentialSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleDifferentialSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_VehicleDifferentialSettings_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleDifferentialSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleDifferentialSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleDifferentialSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleDifferentialSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleDifferentialSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleDifferentialSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_VehicleDifferentialSettings_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleDifferentialSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleDifferentialSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleDifferentialSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleDifferentialSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleDifferentialSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleDifferentialSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_VehicleDifferentialSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleDifferentialSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_VehicleDifferentialSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::VehicleDifferentialSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleDifferentialSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleDifferentialSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleDifferentialSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_VehicleDifferentialSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleDifferentialSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_VehicleDifferentialSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Calculate the torque ratio between left and right wheel
        /// @param inLeftAngularVelocity Angular velocity of left wheel (rad / s)
        /// @param inRightAngularVelocity Angular velocity of right wheel (rad / s)
        /// @param outLeftTorqueFraction Fraction of torque that should go to the left wheel
        /// @param outRightTorqueFraction Fraction of torque that should go to the right wheel
        /// Generated from method `JPH::VehicleDifferentialSettings::CalculateTorqueRatio`.
        public unsafe void CalculateTorqueRatio(float inLeftAngularVelocity, float inRightAngularVelocity, ref float outLeftTorqueFraction, ref float outRightTorqueFraction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_CalculateTorqueRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_CalculateTorqueRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleDifferentialSettings_CalculateTorqueRatio(_Underlying *_this, float inLeftAngularVelocity, float inRightAngularVelocity, float *outLeftTorqueFraction, float *outRightTorqueFraction);
            fixed (float *__ptr_outLeftTorqueFraction = &outLeftTorqueFraction)
            {
                fixed (float *__ptr_outRightTorqueFraction = &outRightTorqueFraction)
                {
                    __JPH_VehicleDifferentialSettings_CalculateTorqueRatio(_UnderlyingPtr, inLeftAngularVelocity, inRightAngularVelocity, __ptr_outLeftTorqueFraction, __ptr_outRightTorqueFraction);
                }
            }
        }
    }

    /// Generated from class `JPH::VehicleDifferentialSettings`.
    /// This is the non-const half of the class.
    public class VehicleDifferentialSettings : Const_VehicleDifferentialSettings
    {
        ///< Index (in mWheels) that represents the left wheel of this differential (can be -1 to indicate no wheel)
        public new unsafe ref int mLeftWheel
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_GetMutable_mLeftWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_GetMutable_mLeftWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_VehicleDifferentialSettings_GetMutable_mLeftWheel(_Underlying *_this);
                return ref *__JPH_VehicleDifferentialSettings_GetMutable_mLeftWheel(_UnderlyingPtr);
            }
        }

        ///< Index (in mWheels) that represents the right wheel of this differential (can be -1 to indicate no wheel)
        public new unsafe ref int mRightWheel
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_GetMutable_mRightWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_GetMutable_mRightWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_VehicleDifferentialSettings_GetMutable_mRightWheel(_Underlying *_this);
                return ref *__JPH_VehicleDifferentialSettings_GetMutable_mRightWheel(_UnderlyingPtr);
            }
        }

        ///< Ratio between rotation speed of gear box and wheels
        public new unsafe ref float mDifferentialRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_GetMutable_mDifferentialRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_GetMutable_mDifferentialRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleDifferentialSettings_GetMutable_mDifferentialRatio(_Underlying *_this);
                return ref *__JPH_VehicleDifferentialSettings_GetMutable_mDifferentialRatio(_UnderlyingPtr);
            }
        }

        ///< Defines how the engine torque is split across the left and right wheel (0 = left, 0.5 = center, 1 = right)
        public new unsafe ref float mLeftRightSplit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_GetMutable_mLeftRightSplit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_GetMutable_mLeftRightSplit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleDifferentialSettings_GetMutable_mLeftRightSplit(_Underlying *_this);
                return ref *__JPH_VehicleDifferentialSettings_GetMutable_mLeftRightSplit(_UnderlyingPtr);
            }
        }

        ///< Ratio max / min wheel speed. When this ratio is exceeded, all torque gets distributed to the slowest moving wheel. This allows implementing a limited slip differential. Set to FLT_MAX for an open differential. Value should be > 1.
        public new unsafe ref float mLimitedSlipRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_GetMutable_mLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_GetMutable_mLimitedSlipRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleDifferentialSettings_GetMutable_mLimitedSlipRatio(_Underlying *_this);
                return ref *__JPH_VehicleDifferentialSettings_GetMutable_mLimitedSlipRatio(_UnderlyingPtr);
            }
        }

        ///< How much of the engines torque is applied to this differential (0 = none, 1 = full), make sure the sum of all differentials is 1.
        public new unsafe ref float mEngineTorqueRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_GetMutable_mEngineTorqueRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_GetMutable_mEngineTorqueRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleDifferentialSettings_GetMutable_mEngineTorqueRatio(_Underlying *_this);
                return ref *__JPH_VehicleDifferentialSettings_GetMutable_mEngineTorqueRatio(_UnderlyingPtr);
            }
        }

        internal unsafe VehicleDifferentialSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe VehicleDifferentialSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleDifferentialSettings._Underlying *__JPH_VehicleDifferentialSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleDifferentialSettings_DefaultConstruct();
        }

        /// Constructs `JPH::VehicleDifferentialSettings` elementwise.
        public unsafe VehicleDifferentialSettings(int mLeftWheel, int mRightWheel, float mDifferentialRatio, float mLeftRightSplit, float mLimitedSlipRatio, float mEngineTorqueRatio) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleDifferentialSettings._Underlying *__JPH_VehicleDifferentialSettings_ConstructFrom(int mLeftWheel, int mRightWheel, float mDifferentialRatio, float mLeftRightSplit, float mLimitedSlipRatio, float mEngineTorqueRatio);
            _UnderlyingPtr = __JPH_VehicleDifferentialSettings_ConstructFrom(mLeftWheel, mRightWheel, mDifferentialRatio, mLeftRightSplit, mLimitedSlipRatio, mEngineTorqueRatio);
        }

        /// Generated from constructor `JPH::VehicleDifferentialSettings::VehicleDifferentialSettings`.
        public unsafe VehicleDifferentialSettings(JPH.Const_VehicleDifferentialSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleDifferentialSettings._Underlying *__JPH_VehicleDifferentialSettings_ConstructFromAnother(JPH.VehicleDifferentialSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleDifferentialSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::VehicleDifferentialSettings::VehicleDifferentialSettings`.
        public VehicleDifferentialSettings(VehicleDifferentialSettings _other) : this((Const_VehicleDifferentialSettings)_other) {}

        /// Generated from method `JPH::VehicleDifferentialSettings::operator=`.
        public unsafe JPH.VehicleDifferentialSettings Assign(JPH.Const_VehicleDifferentialSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleDifferentialSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleDifferentialSettings._Underlying *__JPH_VehicleDifferentialSettings_AssignFromAnother(_Underlying *_this, JPH.VehicleDifferentialSettings._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_VehicleDifferentialSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `VehicleDifferentialSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_VehicleDifferentialSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleDifferentialSettings`/`Const_VehicleDifferentialSettings` directly.
    public class _InOptMut_VehicleDifferentialSettings
    {
        public VehicleDifferentialSettings? Opt;

        public _InOptMut_VehicleDifferentialSettings() {}
        public _InOptMut_VehicleDifferentialSettings(VehicleDifferentialSettings value) {Opt = value;}
        public static implicit operator _InOptMut_VehicleDifferentialSettings(VehicleDifferentialSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `VehicleDifferentialSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_VehicleDifferentialSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleDifferentialSettings`/`Const_VehicleDifferentialSettings` to pass it to the function.
    public class _InOptConst_VehicleDifferentialSettings
    {
        public Const_VehicleDifferentialSettings? Opt;

        public _InOptConst_VehicleDifferentialSettings() {}
        public _InOptConst_VehicleDifferentialSettings(Const_VehicleDifferentialSettings value) {Opt = value;}
        public static implicit operator _InOptConst_VehicleDifferentialSettings(Const_VehicleDifferentialSettings value) {return new(value);}
    }
}
