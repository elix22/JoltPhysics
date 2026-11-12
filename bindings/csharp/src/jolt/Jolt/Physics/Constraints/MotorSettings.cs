// machine generated, do not edit
public static partial class JPH
{
    public enum EMotorState : int
    {
        ///< Motor is off
        Off = 0,
        ///< Motor will drive to target velocity
        Velocity = 1,
        ///< Motor will drive to target position
        Position = 2,
    }

    /// Class that contains the settings for a constraint motor.
    /// See the main page of the API documentation for more information on how to configure a motor.
    /// Generated from class `JPH::MotorSettings`.
    /// This is the const half of the class.
    public class Const_MotorSettings : JPH.Object<Const_MotorSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorSettings_Destroy(_Underlying *_this);
            __JPH_MotorSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_MotorSettings() {Dispose(false);}

        ///< Settings for the spring that is used to drive to the position target (not used when motor is a velocity motor).
        public unsafe JPH.Const_SpringSettings mSpringSettings
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_Get_mSpringSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_Get_mSpringSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_SpringSettings._Underlying *__JPH_MotorSettings_Get_mSpringSettings(_Underlying *_this);
                JPH.Const_SpringSettings __ret;
                __ret = new(__JPH_MotorSettings_Get_mSpringSettings(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Minimum force to apply in case of a linear constraint (N). Usually this is -mMaxForceLimit unless you want a motor that can e.g. push but not pull. Not used when motor is an angular motor.
        public unsafe float mMinForceLimit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_Get_mMinForceLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_Get_mMinForceLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorSettings_Get_mMinForceLimit(_Underlying *_this);
                return *__JPH_MotorSettings_Get_mMinForceLimit(_UnderlyingPtr);
            }
        }

        ///< Maximum force to apply in case of a linear constraint (N). Not used when motor is an angular motor.
        public unsafe float mMaxForceLimit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_Get_mMaxForceLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_Get_mMaxForceLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorSettings_Get_mMaxForceLimit(_Underlying *_this);
                return *__JPH_MotorSettings_Get_mMaxForceLimit(_UnderlyingPtr);
            }
        }

        ///< Minimum torque to apply in case of a angular constraint (N m). Usually this is -mMaxTorqueLimit unless you want a motor that can e.g. push but not pull. Not used when motor is a position motor.
        public unsafe float mMinTorqueLimit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_Get_mMinTorqueLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_Get_mMinTorqueLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorSettings_Get_mMinTorqueLimit(_Underlying *_this);
                return *__JPH_MotorSettings_Get_mMinTorqueLimit(_UnderlyingPtr);
            }
        }

        ///< Maximum torque to apply in case of a angular constraint (N m). Not used when motor is a position motor.
        public unsafe float mMaxTorqueLimit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_Get_mMaxTorqueLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_Get_mMaxTorqueLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorSettings_Get_mMaxTorqueLimit(_Underlying *_this);
                return *__JPH_MotorSettings_Get_mMaxTorqueLimit(_UnderlyingPtr);
            }
        }

        internal unsafe Const_MotorSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_MotorSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorSettings._Underlying *__JPH_MotorSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_MotorSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::MotorSettings::MotorSettings`.
        public unsafe Const_MotorSettings(JPH.Const_MotorSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorSettings._Underlying *__JPH_MotorSettings_ConstructFromAnother(JPH.MotorSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_MotorSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::MotorSettings::MotorSettings`.
        public Const_MotorSettings(MotorSettings _other) : this((Const_MotorSettings)_other) {}

        /// Generated from constructor `JPH::MotorSettings::MotorSettings`.
        public unsafe Const_MotorSettings(float inFrequency, float inDamping) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorSettings._Underlying *__JPH_MotorSettings_Construct_2(float inFrequency, float inDamping);
            _UnderlyingPtr = __JPH_MotorSettings_Construct_2(inFrequency, inDamping);
        }

        /// Generated from constructor `JPH::MotorSettings::MotorSettings`.
        public unsafe Const_MotorSettings(float inFrequency, float inDamping, float inForceLimit, float inTorqueLimit) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorSettings._Underlying *__JPH_MotorSettings_Construct_4(float inFrequency, float inDamping, float inForceLimit, float inTorqueLimit);
            _UnderlyingPtr = __JPH_MotorSettings_Construct_4(inFrequency, inDamping, inForceLimit, inTorqueLimit);
        }

        /// Generated from method `JPH::MotorSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_MotorSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_MotorSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_MotorSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_MotorSettings_size_t(inCount);
        }

        /// Generated from method `JPH::MotorSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_MotorSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_MotorSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_MotorSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_MotorSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::MotorSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_MotorSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_MotorSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_MotorSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_MotorSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::MotorSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_MotorSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_MotorSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_MotorSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_MotorSettings_size_t(inCount);
        }

        /// Generated from method `JPH::MotorSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_MotorSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_MotorSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::MotorSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_MotorSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_MotorSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::MotorSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_MotorSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_MotorSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_MotorSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_MotorSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::MotorSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_MotorSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_MotorSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_MotorSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_MotorSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::MotorSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_MotorSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_MotorSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_MotorSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_MotorSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::MotorSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_MotorSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_MotorSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_MotorSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Check if settings are valid
        /// Generated from method `JPH::MotorSettings::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_MotorSettings_IsValid(_Underlying *_this);
            return __JPH_MotorSettings_IsValid(_UnderlyingPtr) != 0;
        }
    }

    /// Class that contains the settings for a constraint motor.
    /// See the main page of the API documentation for more information on how to configure a motor.
    /// Generated from class `JPH::MotorSettings`.
    /// This is the non-const half of the class.
    public class MotorSettings : Const_MotorSettings
    {
        ///< Settings for the spring that is used to drive to the position target (not used when motor is a velocity motor).
        public new unsafe JPH.SpringSettings mSpringSettings
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_GetMutable_mSpringSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_GetMutable_mSpringSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SpringSettings._Underlying *__JPH_MotorSettings_GetMutable_mSpringSettings(_Underlying *_this);
                JPH.SpringSettings __ret;
                __ret = new(__JPH_MotorSettings_GetMutable_mSpringSettings(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Minimum force to apply in case of a linear constraint (N). Usually this is -mMaxForceLimit unless you want a motor that can e.g. push but not pull. Not used when motor is an angular motor.
        public new unsafe ref float mMinForceLimit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_GetMutable_mMinForceLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_GetMutable_mMinForceLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorSettings_GetMutable_mMinForceLimit(_Underlying *_this);
                return ref *__JPH_MotorSettings_GetMutable_mMinForceLimit(_UnderlyingPtr);
            }
        }

        ///< Maximum force to apply in case of a linear constraint (N). Not used when motor is an angular motor.
        public new unsafe ref float mMaxForceLimit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_GetMutable_mMaxForceLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_GetMutable_mMaxForceLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorSettings_GetMutable_mMaxForceLimit(_Underlying *_this);
                return ref *__JPH_MotorSettings_GetMutable_mMaxForceLimit(_UnderlyingPtr);
            }
        }

        ///< Minimum torque to apply in case of a angular constraint (N m). Usually this is -mMaxTorqueLimit unless you want a motor that can e.g. push but not pull. Not used when motor is a position motor.
        public new unsafe ref float mMinTorqueLimit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_GetMutable_mMinTorqueLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_GetMutable_mMinTorqueLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorSettings_GetMutable_mMinTorqueLimit(_Underlying *_this);
                return ref *__JPH_MotorSettings_GetMutable_mMinTorqueLimit(_UnderlyingPtr);
            }
        }

        ///< Maximum torque to apply in case of a angular constraint (N m). Not used when motor is a position motor.
        public new unsafe ref float mMaxTorqueLimit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_GetMutable_mMaxTorqueLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_GetMutable_mMaxTorqueLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_MotorSettings_GetMutable_mMaxTorqueLimit(_Underlying *_this);
                return ref *__JPH_MotorSettings_GetMutable_mMaxTorqueLimit(_UnderlyingPtr);
            }
        }

        internal unsafe MotorSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe MotorSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorSettings._Underlying *__JPH_MotorSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_MotorSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::MotorSettings::MotorSettings`.
        public unsafe MotorSettings(JPH.Const_MotorSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorSettings._Underlying *__JPH_MotorSettings_ConstructFromAnother(JPH.MotorSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_MotorSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::MotorSettings::MotorSettings`.
        public MotorSettings(MotorSettings _other) : this((Const_MotorSettings)_other) {}

        /// Generated from constructor `JPH::MotorSettings::MotorSettings`.
        public unsafe MotorSettings(float inFrequency, float inDamping) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorSettings._Underlying *__JPH_MotorSettings_Construct_2(float inFrequency, float inDamping);
            _UnderlyingPtr = __JPH_MotorSettings_Construct_2(inFrequency, inDamping);
        }

        /// Generated from constructor `JPH::MotorSettings::MotorSettings`.
        public unsafe MotorSettings(float inFrequency, float inDamping, float inForceLimit, float inTorqueLimit) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorSettings._Underlying *__JPH_MotorSettings_Construct_4(float inFrequency, float inDamping, float inForceLimit, float inTorqueLimit);
            _UnderlyingPtr = __JPH_MotorSettings_Construct_4(inFrequency, inDamping, inForceLimit, inTorqueLimit);
        }

        /// Generated from method `JPH::MotorSettings::operator=`.
        public unsafe JPH.MotorSettings Assign(JPH.Const_MotorSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotorSettings._Underlying *__JPH_MotorSettings_AssignFromAnother(_Underlying *_this, JPH.MotorSettings._Underlying *_other);
            JPH.MotorSettings __ret;
            __ret = new(__JPH_MotorSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Set asymmetric force limits
        /// Generated from method `JPH::MotorSettings::SetForceLimits`.
        public unsafe void SetForceLimits(float inMin, float inMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_SetForceLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_SetForceLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorSettings_SetForceLimits(_Underlying *_this, float inMin, float inMax);
            __JPH_MotorSettings_SetForceLimits(_UnderlyingPtr, inMin, inMax);
        }

        /// Set asymmetric torque limits
        /// Generated from method `JPH::MotorSettings::SetTorqueLimits`.
        public unsafe void SetTorqueLimits(float inMin, float inMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_SetTorqueLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_SetTorqueLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorSettings_SetTorqueLimits(_Underlying *_this, float inMin, float inMax);
            __JPH_MotorSettings_SetTorqueLimits(_UnderlyingPtr, inMin, inMax);
        }

        /// Set symmetric force limits
        /// Generated from method `JPH::MotorSettings::SetForceLimit`.
        public unsafe void SetForceLimit(float inLimit)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_SetForceLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_SetForceLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorSettings_SetForceLimit(_Underlying *_this, float inLimit);
            __JPH_MotorSettings_SetForceLimit(_UnderlyingPtr, inLimit);
        }

        /// Set symmetric torque limits
        /// Generated from method `JPH::MotorSettings::SetTorqueLimit`.
        public unsafe void SetTorqueLimit(float inLimit)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotorSettings_SetTorqueLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotorSettings_SetTorqueLimit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotorSettings_SetTorqueLimit(_Underlying *_this, float inLimit);
            __JPH_MotorSettings_SetTorqueLimit(_UnderlyingPtr, inLimit);
        }
    }

    /// This is used for optional parameters of class `MotorSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_MotorSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `MotorSettings`/`Const_MotorSettings` directly.
    public class _InOptMut_MotorSettings
    {
        public MotorSettings? Opt;

        public _InOptMut_MotorSettings() {}
        public _InOptMut_MotorSettings(MotorSettings value) {Opt = value;}
        public static implicit operator _InOptMut_MotorSettings(MotorSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `MotorSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_MotorSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `MotorSettings`/`Const_MotorSettings` to pass it to the function.
    public class _InOptConst_MotorSettings
    {
        public Const_MotorSettings? Opt;

        public _InOptConst_MotorSettings() {}
        public _InOptConst_MotorSettings(Const_MotorSettings value) {Opt = value;}
        public static implicit operator _InOptConst_MotorSettings(Const_MotorSettings value) {return new(value);}
    }
}
