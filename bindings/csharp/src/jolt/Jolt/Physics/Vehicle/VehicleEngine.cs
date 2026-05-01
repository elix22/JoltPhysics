// machine generated, do not edit
public static partial class JPH
{
    /// Generic properties for a vehicle engine
    /// Generated from class `JPH::VehicleEngineSettings`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleEngine`
    /// This is the const half of the class.
    public class Const_VehicleEngineSettings : JPH.Object<Const_VehicleEngineSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleEngineSettings_Destroy(_Underlying *_this);
            __JPH_VehicleEngineSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_VehicleEngineSettings() {Dispose(false);}

        ///< Max amount of torque (Nm) that the engine can deliver
        public unsafe float mMaxTorque
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_Get_mMaxTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_Get_mMaxTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngineSettings_Get_mMaxTorque(_Underlying *_this);
                return *__JPH_VehicleEngineSettings_Get_mMaxTorque(_UnderlyingPtr);
            }
        }

        ///< Min amount of revolutions per minute (rpm) the engine can produce without stalling
        public unsafe float mMinRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_Get_mMinRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_Get_mMinRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngineSettings_Get_mMinRPM(_Underlying *_this);
                return *__JPH_VehicleEngineSettings_Get_mMinRPM(_UnderlyingPtr);
            }
        }

        ///< Max amount of revolutions per minute (rpm) the engine can generate
        public unsafe float mMaxRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_Get_mMaxRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_Get_mMaxRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngineSettings_Get_mMaxRPM(_Underlying *_this);
                return *__JPH_VehicleEngineSettings_Get_mMaxRPM(_UnderlyingPtr);
            }
        }

        ///< Moment of inertia (kg m^2) of the engine
        public unsafe float mInertia
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_Get_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_Get_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngineSettings_Get_mInertia(_Underlying *_this);
                return *__JPH_VehicleEngineSettings_Get_mInertia(_UnderlyingPtr);
            }
        }

        ///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
        public unsafe float mAngularDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_Get_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_Get_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngineSettings_Get_mAngularDamping(_Underlying *_this);
                return *__JPH_VehicleEngineSettings_Get_mAngularDamping(_UnderlyingPtr);
            }
        }

        internal unsafe Const_VehicleEngineSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_VehicleEngineSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleEngineSettings._Underlying *__JPH_VehicleEngineSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleEngineSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::VehicleEngineSettings::VehicleEngineSettings`.
        public unsafe Const_VehicleEngineSettings(JPH._ByValue_VehicleEngineSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleEngineSettings._Underlying *__JPH_VehicleEngineSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.VehicleEngineSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleEngineSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::VehicleEngineSettings::VehicleEngineSettings`.
        public Const_VehicleEngineSettings(Const_VehicleEngineSettings _other) : this(new _ByValue_VehicleEngineSettings(_other)) {}

        /// Generated from constructor `JPH::VehicleEngineSettings::VehicleEngineSettings`.
        public Const_VehicleEngineSettings(VehicleEngineSettings _other) : this((Const_VehicleEngineSettings)_other) {}

        /// Generated from method `JPH::VehicleEngineSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleEngineSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleEngineSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleEngineSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_VehicleEngineSettings_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleEngineSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleEngineSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleEngineSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleEngineSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_VehicleEngineSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleEngineSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleEngineSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleEngineSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleEngineSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_VehicleEngineSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleEngineSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleEngineSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleEngineSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleEngineSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_VehicleEngineSettings_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleEngineSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleEngineSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleEngineSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleEngineSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleEngineSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleEngineSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_VehicleEngineSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleEngineSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleEngineSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleEngineSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleEngineSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_VehicleEngineSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::VehicleEngineSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleEngineSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleEngineSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleEngineSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_VehicleEngineSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleEngineSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_VehicleEngineSettings_void_ptr_void_ptr(inPointer, inPlace);
        }
    }

    /// Generic properties for a vehicle engine
    /// Generated from class `JPH::VehicleEngineSettings`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleEngine`
    /// This is the non-const half of the class.
    public class VehicleEngineSettings : Const_VehicleEngineSettings
    {
        ///< Max amount of torque (Nm) that the engine can deliver
        public new unsafe ref float mMaxTorque
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_GetMutable_mMaxTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_GetMutable_mMaxTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngineSettings_GetMutable_mMaxTorque(_Underlying *_this);
                return ref *__JPH_VehicleEngineSettings_GetMutable_mMaxTorque(_UnderlyingPtr);
            }
        }

        ///< Min amount of revolutions per minute (rpm) the engine can produce without stalling
        public new unsafe ref float mMinRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_GetMutable_mMinRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_GetMutable_mMinRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngineSettings_GetMutable_mMinRPM(_Underlying *_this);
                return ref *__JPH_VehicleEngineSettings_GetMutable_mMinRPM(_UnderlyingPtr);
            }
        }

        ///< Max amount of revolutions per minute (rpm) the engine can generate
        public new unsafe ref float mMaxRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_GetMutable_mMaxRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_GetMutable_mMaxRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngineSettings_GetMutable_mMaxRPM(_Underlying *_this);
                return ref *__JPH_VehicleEngineSettings_GetMutable_mMaxRPM(_UnderlyingPtr);
            }
        }

        ///< Moment of inertia (kg m^2) of the engine
        public new unsafe ref float mInertia
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_GetMutable_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_GetMutable_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngineSettings_GetMutable_mInertia(_Underlying *_this);
                return ref *__JPH_VehicleEngineSettings_GetMutable_mInertia(_UnderlyingPtr);
            }
        }

        ///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
        public new unsafe ref float mAngularDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_GetMutable_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_GetMutable_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngineSettings_GetMutable_mAngularDamping(_Underlying *_this);
                return ref *__JPH_VehicleEngineSettings_GetMutable_mAngularDamping(_UnderlyingPtr);
            }
        }

        internal unsafe VehicleEngineSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe VehicleEngineSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleEngineSettings._Underlying *__JPH_VehicleEngineSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleEngineSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::VehicleEngineSettings::VehicleEngineSettings`.
        public unsafe VehicleEngineSettings(JPH._ByValue_VehicleEngineSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleEngineSettings._Underlying *__JPH_VehicleEngineSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.VehicleEngineSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleEngineSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::VehicleEngineSettings::VehicleEngineSettings`.
        public VehicleEngineSettings(Const_VehicleEngineSettings _other) : this(new _ByValue_VehicleEngineSettings(_other)) {}

        /// Generated from constructor `JPH::VehicleEngineSettings::VehicleEngineSettings`.
        public VehicleEngineSettings(VehicleEngineSettings _other) : this((Const_VehicleEngineSettings)_other) {}

        /// Generated from method `JPH::VehicleEngineSettings::operator=`.
        public unsafe JPH.VehicleEngineSettings Assign(JPH._ByValue_VehicleEngineSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngineSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngineSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleEngineSettings._Underlying *__JPH_VehicleEngineSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.VehicleEngineSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_VehicleEngineSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `VehicleEngineSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `VehicleEngineSettings`/`Const_VehicleEngineSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_VehicleEngineSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_VehicleEngineSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_VehicleEngineSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_VehicleEngineSettings(Const_VehicleEngineSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_VehicleEngineSettings(Const_VehicleEngineSettings arg) {return new(arg);}
        public _ByValue_VehicleEngineSettings(JPH._Moved<VehicleEngineSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_VehicleEngineSettings(JPH._Moved<VehicleEngineSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `VehicleEngineSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_VehicleEngineSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleEngineSettings`/`Const_VehicleEngineSettings` directly.
    public class _InOptMut_VehicleEngineSettings
    {
        public VehicleEngineSettings? Opt;

        public _InOptMut_VehicleEngineSettings() {}
        public _InOptMut_VehicleEngineSettings(VehicleEngineSettings value) {Opt = value;}
        public static implicit operator _InOptMut_VehicleEngineSettings(VehicleEngineSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `VehicleEngineSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_VehicleEngineSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleEngineSettings`/`Const_VehicleEngineSettings` to pass it to the function.
    public class _InOptConst_VehicleEngineSettings
    {
        public Const_VehicleEngineSettings? Opt;

        public _InOptConst_VehicleEngineSettings() {}
        public _InOptConst_VehicleEngineSettings(Const_VehicleEngineSettings value) {Opt = value;}
        public static implicit operator _InOptConst_VehicleEngineSettings(Const_VehicleEngineSettings value) {return new(value);}
    }

    /// Runtime data for engine
    /// Generated from class `JPH::VehicleEngine`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleEngineSettings`
    /// This is the const half of the class.
    public class Const_VehicleEngine : JPH.Object<Const_VehicleEngine>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleEngine_Destroy(_Underlying *_this);
            __JPH_VehicleEngine_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_VehicleEngine() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_VehicleEngineSettings(Const_VehicleEngine self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_UpcastTo_JPH_VehicleEngineSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_UpcastTo_JPH_VehicleEngineSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleEngineSettings._Underlying *__JPH_VehicleEngine_UpcastTo_JPH_VehicleEngineSettings(_Underlying *_this);
            JPH.Const_VehicleEngineSettings ret = new(__JPH_VehicleEngine_UpcastTo_JPH_VehicleEngineSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        /// Multiply an angular velocity (rad/s) with this value to get rounds per minute (RPM)
        public static unsafe float CAngularVelocityToRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_Get_cAngularVelocityToRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_Get_cAngularVelocityToRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngine_Get_cAngularVelocityToRPM();
                return *__JPH_VehicleEngine_Get_cAngularVelocityToRPM();
            }
        }

        ///< Max amount of torque (Nm) that the engine can deliver
        public unsafe float mMaxTorque
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_Get_mMaxTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_Get_mMaxTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngine_Get_mMaxTorque(_Underlying *_this);
                return *__JPH_VehicleEngine_Get_mMaxTorque(_UnderlyingPtr);
            }
        }

        ///< Min amount of revolutions per minute (rpm) the engine can produce without stalling
        public unsafe float mMinRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_Get_mMinRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_Get_mMinRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngine_Get_mMinRPM(_Underlying *_this);
                return *__JPH_VehicleEngine_Get_mMinRPM(_UnderlyingPtr);
            }
        }

        ///< Max amount of revolutions per minute (rpm) the engine can generate
        public unsafe float mMaxRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_Get_mMaxRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_Get_mMaxRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngine_Get_mMaxRPM(_Underlying *_this);
                return *__JPH_VehicleEngine_Get_mMaxRPM(_UnderlyingPtr);
            }
        }

        ///< Moment of inertia (kg m^2) of the engine
        public unsafe float mInertia
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_Get_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_Get_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngine_Get_mInertia(_Underlying *_this);
                return *__JPH_VehicleEngine_Get_mInertia(_UnderlyingPtr);
            }
        }

        ///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
        public unsafe float mAngularDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_Get_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_Get_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngine_Get_mAngularDamping(_Underlying *_this);
                return *__JPH_VehicleEngine_Get_mAngularDamping(_UnderlyingPtr);
            }
        }

        internal unsafe Const_VehicleEngine(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_VehicleEngine() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleEngine._Underlying *__JPH_VehicleEngine_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleEngine_DefaultConstruct();
        }

        /// Generated from constructor `JPH::VehicleEngine::VehicleEngine`.
        public unsafe Const_VehicleEngine(JPH._ByValue_VehicleEngine _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleEngine._Underlying *__JPH_VehicleEngine_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.VehicleEngine._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleEngine_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::VehicleEngine::VehicleEngine`.
        public Const_VehicleEngine(Const_VehicleEngine _other) : this(new _ByValue_VehicleEngine(_other)) {}

        /// Generated from constructor `JPH::VehicleEngine::VehicleEngine`.
        public Const_VehicleEngine(VehicleEngine _other) : this((Const_VehicleEngine)_other) {}

        /// Current rotation speed of engine in rounds per minute
        /// Generated from method `JPH::VehicleEngine::GetCurrentRPM`.
        public unsafe float GetCurrentRPM()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_GetCurrentRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_GetCurrentRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_VehicleEngine_GetCurrentRPM(_Underlying *_this);
            return __JPH_VehicleEngine_GetCurrentRPM(_UnderlyingPtr);
        }

        /// Get current angular velocity of the engine in radians / second
        /// Generated from method `JPH::VehicleEngine::GetAngularVelocity`.
        public unsafe float GetAngularVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_VehicleEngine_GetAngularVelocity(_Underlying *_this);
            return __JPH_VehicleEngine_GetAngularVelocity(_UnderlyingPtr);
        }

        /// Get the amount of torque (N m) that the engine can supply
        /// @param inAcceleration How much the gas pedal is pressed [0, 1]
        /// Generated from method `JPH::VehicleEngine::GetTorque`.
        public unsafe float GetTorque(float inAcceleration)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_GetTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_GetTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_VehicleEngine_GetTorque(_Underlying *_this, float inAcceleration);
            return __JPH_VehicleEngine_GetTorque(_UnderlyingPtr, inAcceleration);
        }

        // Function that converts RPM to an angle in radians for debugging purposes
        /// Generated from method `JPH::VehicleEngine::ConvertRPMToAngle`.
        public unsafe float ConvertRPMToAngle(float inRPM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_ConvertRPMToAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_ConvertRPMToAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_VehicleEngine_ConvertRPMToAngle(_Underlying *_this, float inRPM);
            return __JPH_VehicleEngine_ConvertRPMToAngle(_UnderlyingPtr, inRPM);
        }

        /// Debug draw a RPM meter
        /// Generated from method `JPH::VehicleEngine::DrawRPM`.
        public unsafe void DrawRPM(JPH.DebugRenderer? inRenderer, JPH.Const_Vec3 inPosition, JPH.Const_Vec3 inForward, JPH.Const_Vec3 inUp, float inSize, float inShiftDownRPM, float inShiftUpRPM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_DrawRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_DrawRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleEngine_DrawRPM(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer, JPH.Vec3._Underlying *inPosition, JPH.Vec3._Underlying *inForward, JPH.Vec3._Underlying *inUp, float inSize, float inShiftDownRPM, float inShiftUpRPM);
            __JPH_VehicleEngine_DrawRPM(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inPosition._UnderlyingPtr, inForward._UnderlyingPtr, inUp._UnderlyingPtr, inSize, inShiftDownRPM, inShiftUpRPM);
        }

        /// If the engine is idle we allow the vehicle to sleep
        /// Generated from method `JPH::VehicleEngine::AllowSleep`.
        public unsafe bool AllowSleep()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_AllowSleep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_AllowSleep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_VehicleEngine_AllowSleep(_Underlying *_this);
            return __JPH_VehicleEngine_AllowSleep(_UnderlyingPtr) != 0;
        }
    }

    /// Runtime data for engine
    /// Generated from class `JPH::VehicleEngine`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleEngineSettings`
    /// This is the non-const half of the class.
    public class VehicleEngine : Const_VehicleEngine
    {
        // Upcasts:
        public static unsafe implicit operator JPH.VehicleEngineSettings(VehicleEngine self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_UpcastTo_JPH_VehicleEngineSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_UpcastTo_JPH_VehicleEngineSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleEngineSettings._Underlying *__JPH_VehicleEngine_UpcastTo_JPH_VehicleEngineSettings(_Underlying *_this);
            JPH.VehicleEngineSettings ret = new(__JPH_VehicleEngine_UpcastTo_JPH_VehicleEngineSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        ///< Max amount of torque (Nm) that the engine can deliver
        public new unsafe ref float mMaxTorque
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_GetMutable_mMaxTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_GetMutable_mMaxTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngine_GetMutable_mMaxTorque(_Underlying *_this);
                return ref *__JPH_VehicleEngine_GetMutable_mMaxTorque(_UnderlyingPtr);
            }
        }

        ///< Min amount of revolutions per minute (rpm) the engine can produce without stalling
        public new unsafe ref float mMinRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_GetMutable_mMinRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_GetMutable_mMinRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngine_GetMutable_mMinRPM(_Underlying *_this);
                return ref *__JPH_VehicleEngine_GetMutable_mMinRPM(_UnderlyingPtr);
            }
        }

        ///< Max amount of revolutions per minute (rpm) the engine can generate
        public new unsafe ref float mMaxRPM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_GetMutable_mMaxRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_GetMutable_mMaxRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngine_GetMutable_mMaxRPM(_Underlying *_this);
                return ref *__JPH_VehicleEngine_GetMutable_mMaxRPM(_UnderlyingPtr);
            }
        }

        ///< Moment of inertia (kg m^2) of the engine
        public new unsafe ref float mInertia
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_GetMutable_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_GetMutable_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngine_GetMutable_mInertia(_Underlying *_this);
                return ref *__JPH_VehicleEngine_GetMutable_mInertia(_UnderlyingPtr);
            }
        }

        ///< Angular damping factor of the wheel: dw/dt = -c * w. Value should be zero or positive and is usually close to 0.
        public new unsafe ref float mAngularDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_GetMutable_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_GetMutable_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleEngine_GetMutable_mAngularDamping(_Underlying *_this);
                return ref *__JPH_VehicleEngine_GetMutable_mAngularDamping(_UnderlyingPtr);
            }
        }

        internal unsafe VehicleEngine(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe VehicleEngine() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleEngine._Underlying *__JPH_VehicleEngine_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleEngine_DefaultConstruct();
        }

        /// Generated from constructor `JPH::VehicleEngine::VehicleEngine`.
        public unsafe VehicleEngine(JPH._ByValue_VehicleEngine _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleEngine._Underlying *__JPH_VehicleEngine_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.VehicleEngine._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleEngine_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::VehicleEngine::VehicleEngine`.
        public VehicleEngine(Const_VehicleEngine _other) : this(new _ByValue_VehicleEngine(_other)) {}

        /// Generated from constructor `JPH::VehicleEngine::VehicleEngine`.
        public VehicleEngine(VehicleEngine _other) : this((Const_VehicleEngine)_other) {}

        /// Generated from method `JPH::VehicleEngine::operator=`.
        public unsafe JPH.VehicleEngine Assign(JPH._ByValue_VehicleEngine _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleEngine._Underlying *__JPH_VehicleEngine_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.VehicleEngine._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_VehicleEngine_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Clamp the RPM between min and max RPM
        /// Generated from method `JPH::VehicleEngine::ClampRPM`.
        public unsafe void ClampRPM()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_ClampRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_ClampRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleEngine_ClampRPM(_Underlying *_this);
            __JPH_VehicleEngine_ClampRPM(_UnderlyingPtr);
        }

        /// Update rotation speed of engine in rounds per minute
        /// Generated from method `JPH::VehicleEngine::SetCurrentRPM`.
        public unsafe void SetCurrentRPM(float inRPM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_SetCurrentRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_SetCurrentRPM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleEngine_SetCurrentRPM(_Underlying *_this, float inRPM);
            __JPH_VehicleEngine_SetCurrentRPM(_UnderlyingPtr, inRPM);
        }

        /// Apply a torque to the engine rotation speed
        /// @param inTorque Torque in N m
        /// @param inDeltaTime Delta time in seconds
        /// Generated from method `JPH::VehicleEngine::ApplyTorque`.
        public unsafe void ApplyTorque(float inTorque, float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_ApplyTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_ApplyTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleEngine_ApplyTorque(_Underlying *_this, float inTorque, float inDeltaTime);
            __JPH_VehicleEngine_ApplyTorque(_UnderlyingPtr, inTorque, inDeltaTime);
        }

        /// Update the engine RPM for damping
        /// @param inDeltaTime Delta time in seconds
        /// Generated from method `JPH::VehicleEngine::ApplyDamping`.
        public unsafe void ApplyDamping(float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleEngine_ApplyDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleEngine_ApplyDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleEngine_ApplyDamping(_Underlying *_this, float inDeltaTime);
            __JPH_VehicleEngine_ApplyDamping(_UnderlyingPtr, inDeltaTime);
        }
    }

    /// This is used as a function parameter when the underlying function receives `VehicleEngine` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `VehicleEngine`/`Const_VehicleEngine` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_VehicleEngine
    {
        #pragma warning disable CS0649
        internal readonly Const_VehicleEngine? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_VehicleEngine() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_VehicleEngine(Const_VehicleEngine new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_VehicleEngine(Const_VehicleEngine arg) {return new(arg);}
        public _ByValue_VehicleEngine(JPH._Moved<VehicleEngine> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_VehicleEngine(JPH._Moved<VehicleEngine> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `VehicleEngine` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_VehicleEngine`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleEngine`/`Const_VehicleEngine` directly.
    public class _InOptMut_VehicleEngine
    {
        public VehicleEngine? Opt;

        public _InOptMut_VehicleEngine() {}
        public _InOptMut_VehicleEngine(VehicleEngine value) {Opt = value;}
        public static implicit operator _InOptMut_VehicleEngine(VehicleEngine value) {return new(value);}
    }

    /// This is used for optional parameters of class `VehicleEngine` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_VehicleEngine`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleEngine`/`Const_VehicleEngine` to pass it to the function.
    public class _InOptConst_VehicleEngine
    {
        public Const_VehicleEngine? Opt;

        public _InOptConst_VehicleEngine() {}
        public _InOptConst_VehicleEngine(Const_VehicleEngine value) {Opt = value;}
        public static implicit operator _InOptConst_VehicleEngine(Const_VehicleEngine value) {return new(value);}
    }
}
