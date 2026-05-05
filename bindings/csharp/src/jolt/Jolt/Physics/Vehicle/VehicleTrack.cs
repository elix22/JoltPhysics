// machine generated, do not edit
public static partial class JPH
{
    /// On which side of the vehicle the track is located (for steering)
    public enum ETrackSide : uint
    {
        Left = 0,
        Right = 1,
        Num = 2,
    }

    /// Generic properties for tank tracks
    /// Generated from class `JPH::VehicleTrackSettings`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleTrack`
    /// This is the const half of the class.
    public class Const_VehicleTrackSettings : JPH.Object<Const_VehicleTrackSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleTrackSettings_Destroy(_Underlying *_this);
            __JPH_VehicleTrackSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_VehicleTrackSettings() {Dispose(false);}

        ///< Which wheel on the track is connected to the engine
        public unsafe uint mDrivenWheel
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_Get_mDrivenWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_Get_mDrivenWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_VehicleTrackSettings_Get_mDrivenWheel(_Underlying *_this);
                return *__JPH_VehicleTrackSettings_Get_mDrivenWheel(_UnderlyingPtr);
            }
        }

        ///< Moment of inertia (kg m^2) of the track and its wheels as seen on the driven wheel
        public unsafe float mInertia
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_Get_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_Get_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrackSettings_Get_mInertia(_Underlying *_this);
                return *__JPH_VehicleTrackSettings_Get_mInertia(_UnderlyingPtr);
            }
        }

        ///< Damping factor of track and its wheels: dw/dt = -c * w as seen on the driven wheel
        public unsafe float mAngularDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_Get_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_Get_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrackSettings_Get_mAngularDamping(_Underlying *_this);
                return *__JPH_VehicleTrackSettings_Get_mAngularDamping(_UnderlyingPtr);
            }
        }

        ///< How much torque (Nm) the brakes can apply on the driven wheel
        public unsafe float mMaxBrakeTorque
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_Get_mMaxBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_Get_mMaxBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrackSettings_Get_mMaxBrakeTorque(_Underlying *_this);
                return *__JPH_VehicleTrackSettings_Get_mMaxBrakeTorque(_UnderlyingPtr);
            }
        }

        ///< Ratio between rotation speed of gear box and driven wheel of track
        public unsafe float mDifferentialRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_Get_mDifferentialRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_Get_mDifferentialRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrackSettings_Get_mDifferentialRatio(_Underlying *_this);
                return *__JPH_VehicleTrackSettings_Get_mDifferentialRatio(_UnderlyingPtr);
            }
        }

        internal unsafe Const_VehicleTrackSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_VehicleTrackSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTrackSettings._Underlying *__JPH_VehicleTrackSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleTrackSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::VehicleTrackSettings::VehicleTrackSettings`.
        public unsafe Const_VehicleTrackSettings(JPH._ByValue_VehicleTrackSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTrackSettings._Underlying *__JPH_VehicleTrackSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.VehicleTrackSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleTrackSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::VehicleTrackSettings::VehicleTrackSettings`.
        public Const_VehicleTrackSettings(Const_VehicleTrackSettings _other) : this(new _ByValue_VehicleTrackSettings(_other)) {}

        /// Generated from constructor `JPH::VehicleTrackSettings::VehicleTrackSettings`.
        public Const_VehicleTrackSettings(VehicleTrackSettings _other) : this((Const_VehicleTrackSettings)_other) {}

        /// Generated from method `JPH::VehicleTrackSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleTrackSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleTrackSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleTrackSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_VehicleTrackSettings_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleTrackSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleTrackSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleTrackSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleTrackSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_VehicleTrackSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleTrackSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleTrackSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleTrackSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleTrackSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_VehicleTrackSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleTrackSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleTrackSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleTrackSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleTrackSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_VehicleTrackSettings_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleTrackSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleTrackSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleTrackSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleTrackSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleTrackSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleTrackSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_VehicleTrackSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleTrackSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleTrackSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleTrackSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleTrackSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_VehicleTrackSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::VehicleTrackSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleTrackSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleTrackSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleTrackSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_VehicleTrackSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleTrackSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_VehicleTrackSettings_void_ptr_void_ptr(inPointer, inPlace);
        }
    }

    /// Generic properties for tank tracks
    /// Generated from class `JPH::VehicleTrackSettings`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleTrack`
    /// This is the non-const half of the class.
    public class VehicleTrackSettings : Const_VehicleTrackSettings
    {
        ///< Which wheel on the track is connected to the engine
        public new unsafe ref uint mDrivenWheel
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_GetMutable_mDrivenWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_GetMutable_mDrivenWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_VehicleTrackSettings_GetMutable_mDrivenWheel(_Underlying *_this);
                return ref *__JPH_VehicleTrackSettings_GetMutable_mDrivenWheel(_UnderlyingPtr);
            }
        }

        ///< Moment of inertia (kg m^2) of the track and its wheels as seen on the driven wheel
        public new unsafe ref float mInertia
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_GetMutable_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_GetMutable_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrackSettings_GetMutable_mInertia(_Underlying *_this);
                return ref *__JPH_VehicleTrackSettings_GetMutable_mInertia(_UnderlyingPtr);
            }
        }

        ///< Damping factor of track and its wheels: dw/dt = -c * w as seen on the driven wheel
        public new unsafe ref float mAngularDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_GetMutable_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_GetMutable_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrackSettings_GetMutable_mAngularDamping(_Underlying *_this);
                return ref *__JPH_VehicleTrackSettings_GetMutable_mAngularDamping(_UnderlyingPtr);
            }
        }

        ///< How much torque (Nm) the brakes can apply on the driven wheel
        public new unsafe ref float mMaxBrakeTorque
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_GetMutable_mMaxBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_GetMutable_mMaxBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrackSettings_GetMutable_mMaxBrakeTorque(_Underlying *_this);
                return ref *__JPH_VehicleTrackSettings_GetMutable_mMaxBrakeTorque(_UnderlyingPtr);
            }
        }

        ///< Ratio between rotation speed of gear box and driven wheel of track
        public new unsafe ref float mDifferentialRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_GetMutable_mDifferentialRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_GetMutable_mDifferentialRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrackSettings_GetMutable_mDifferentialRatio(_Underlying *_this);
                return ref *__JPH_VehicleTrackSettings_GetMutable_mDifferentialRatio(_UnderlyingPtr);
            }
        }

        internal unsafe VehicleTrackSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe VehicleTrackSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTrackSettings._Underlying *__JPH_VehicleTrackSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleTrackSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::VehicleTrackSettings::VehicleTrackSettings`.
        public unsafe VehicleTrackSettings(JPH._ByValue_VehicleTrackSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTrackSettings._Underlying *__JPH_VehicleTrackSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.VehicleTrackSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleTrackSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::VehicleTrackSettings::VehicleTrackSettings`.
        public VehicleTrackSettings(Const_VehicleTrackSettings _other) : this(new _ByValue_VehicleTrackSettings(_other)) {}

        /// Generated from constructor `JPH::VehicleTrackSettings::VehicleTrackSettings`.
        public VehicleTrackSettings(VehicleTrackSettings _other) : this((Const_VehicleTrackSettings)_other) {}

        /// Generated from method `JPH::VehicleTrackSettings::operator=`.
        public unsafe JPH.VehicleTrackSettings Assign(JPH._ByValue_VehicleTrackSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrackSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrackSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTrackSettings._Underlying *__JPH_VehicleTrackSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.VehicleTrackSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_VehicleTrackSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `VehicleTrackSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `VehicleTrackSettings`/`Const_VehicleTrackSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_VehicleTrackSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_VehicleTrackSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_VehicleTrackSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_VehicleTrackSettings(Const_VehicleTrackSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_VehicleTrackSettings(Const_VehicleTrackSettings arg) {return new(arg);}
        public _ByValue_VehicleTrackSettings(JPH._Moved<VehicleTrackSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_VehicleTrackSettings(JPH._Moved<VehicleTrackSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `VehicleTrackSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_VehicleTrackSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleTrackSettings`/`Const_VehicleTrackSettings` directly.
    public class _InOptMut_VehicleTrackSettings
    {
        public VehicleTrackSettings? Opt;

        public _InOptMut_VehicleTrackSettings() {}
        public _InOptMut_VehicleTrackSettings(VehicleTrackSettings value) {Opt = value;}
        public static implicit operator _InOptMut_VehicleTrackSettings(VehicleTrackSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `VehicleTrackSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_VehicleTrackSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleTrackSettings`/`Const_VehicleTrackSettings` to pass it to the function.
    public class _InOptConst_VehicleTrackSettings
    {
        public Const_VehicleTrackSettings? Opt;

        public _InOptConst_VehicleTrackSettings() {}
        public _InOptConst_VehicleTrackSettings(Const_VehicleTrackSettings value) {Opt = value;}
        public static implicit operator _InOptConst_VehicleTrackSettings(Const_VehicleTrackSettings value) {return new(value);}
    }

    /// Runtime data for tank tracks
    /// Generated from class `JPH::VehicleTrack`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleTrackSettings`
    /// This is the const half of the class.
    public class Const_VehicleTrack : JPH.Object<Const_VehicleTrack>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleTrack_Destroy(_Underlying *_this);
            __JPH_VehicleTrack_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_VehicleTrack() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_VehicleTrackSettings(Const_VehicleTrack self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_UpcastTo_JPH_VehicleTrackSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_UpcastTo_JPH_VehicleTrackSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleTrackSettings._Underlying *__JPH_VehicleTrack_UpcastTo_JPH_VehicleTrackSettings(_Underlying *_this);
            JPH.Const_VehicleTrackSettings ret = new(__JPH_VehicleTrack_UpcastTo_JPH_VehicleTrackSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_VehicleTrack(JPH.Const_VehicleTrackSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_StaticDowncastFrom_JPH_VehicleTrackSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_StaticDowncastFrom_JPH_VehicleTrackSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleTrack_StaticDowncastFrom_JPH_VehicleTrackSettings(JPH.Const_VehicleTrackSettings._Underlying *_this);
            Const_VehicleTrack ret = new(__JPH_VehicleTrack_StaticDowncastFrom_JPH_VehicleTrackSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Angular velocity of the driven wheel, will determine the speed of the entire track
        public unsafe float mAngularVelocity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_Get_mAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_Get_mAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrack_Get_mAngularVelocity(_Underlying *_this);
                return *__JPH_VehicleTrack_Get_mAngularVelocity(_UnderlyingPtr);
            }
        }

        ///< Which wheel on the track is connected to the engine
        public unsafe uint mDrivenWheel
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_Get_mDrivenWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_Get_mDrivenWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_VehicleTrack_Get_mDrivenWheel(_Underlying *_this);
                return *__JPH_VehicleTrack_Get_mDrivenWheel(_UnderlyingPtr);
            }
        }

        ///< Moment of inertia (kg m^2) of the track and its wheels as seen on the driven wheel
        public unsafe float mInertia
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_Get_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_Get_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrack_Get_mInertia(_Underlying *_this);
                return *__JPH_VehicleTrack_Get_mInertia(_UnderlyingPtr);
            }
        }

        ///< Damping factor of track and its wheels: dw/dt = -c * w as seen on the driven wheel
        public unsafe float mAngularDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_Get_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_Get_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrack_Get_mAngularDamping(_Underlying *_this);
                return *__JPH_VehicleTrack_Get_mAngularDamping(_UnderlyingPtr);
            }
        }

        ///< How much torque (Nm) the brakes can apply on the driven wheel
        public unsafe float mMaxBrakeTorque
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_Get_mMaxBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_Get_mMaxBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrack_Get_mMaxBrakeTorque(_Underlying *_this);
                return *__JPH_VehicleTrack_Get_mMaxBrakeTorque(_UnderlyingPtr);
            }
        }

        ///< Ratio between rotation speed of gear box and driven wheel of track
        public unsafe float mDifferentialRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_Get_mDifferentialRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_Get_mDifferentialRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrack_Get_mDifferentialRatio(_Underlying *_this);
                return *__JPH_VehicleTrack_Get_mDifferentialRatio(_UnderlyingPtr);
            }
        }

        internal unsafe Const_VehicleTrack(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_VehicleTrack() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTrack._Underlying *__JPH_VehicleTrack_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleTrack_DefaultConstruct();
        }

        /// Generated from constructor `JPH::VehicleTrack::VehicleTrack`.
        public unsafe Const_VehicleTrack(JPH._ByValue_VehicleTrack _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTrack._Underlying *__JPH_VehicleTrack_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.VehicleTrack._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleTrack_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::VehicleTrack::VehicleTrack`.
        public Const_VehicleTrack(Const_VehicleTrack _other) : this(new _ByValue_VehicleTrack(_other)) {}

        /// Generated from constructor `JPH::VehicleTrack::VehicleTrack`.
        public Const_VehicleTrack(VehicleTrack _other) : this((Const_VehicleTrack)_other) {}
    }

    /// Runtime data for tank tracks
    /// Generated from class `JPH::VehicleTrack`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleTrackSettings`
    /// This is the non-const half of the class.
    public class VehicleTrack : Const_VehicleTrack
    {
        // Upcasts:
        public static unsafe implicit operator JPH.VehicleTrackSettings(VehicleTrack self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_UpcastTo_JPH_VehicleTrackSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_UpcastTo_JPH_VehicleTrackSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTrackSettings._Underlying *__JPH_VehicleTrack_UpcastTo_JPH_VehicleTrackSettings(_Underlying *_this);
            JPH.VehicleTrackSettings ret = new(__JPH_VehicleTrack_UpcastTo_JPH_VehicleTrackSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator VehicleTrack(JPH.VehicleTrackSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_StaticDowncastFrom_JPH_VehicleTrackSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_StaticDowncastFrom_JPH_VehicleTrackSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleTrack_StaticDowncastFrom_JPH_VehicleTrackSettings(JPH.VehicleTrackSettings._Underlying *_this);
            VehicleTrack ret = new(__JPH_VehicleTrack_StaticDowncastFrom_JPH_VehicleTrackSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Angular velocity of the driven wheel, will determine the speed of the entire track
        public new unsafe ref float mAngularVelocity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_GetMutable_mAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_GetMutable_mAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrack_GetMutable_mAngularVelocity(_Underlying *_this);
                return ref *__JPH_VehicleTrack_GetMutable_mAngularVelocity(_UnderlyingPtr);
            }
        }

        ///< Which wheel on the track is connected to the engine
        public new unsafe ref uint mDrivenWheel
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_GetMutable_mDrivenWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_GetMutable_mDrivenWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_VehicleTrack_GetMutable_mDrivenWheel(_Underlying *_this);
                return ref *__JPH_VehicleTrack_GetMutable_mDrivenWheel(_UnderlyingPtr);
            }
        }

        ///< Moment of inertia (kg m^2) of the track and its wheels as seen on the driven wheel
        public new unsafe ref float mInertia
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_GetMutable_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_GetMutable_mInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrack_GetMutable_mInertia(_Underlying *_this);
                return ref *__JPH_VehicleTrack_GetMutable_mInertia(_UnderlyingPtr);
            }
        }

        ///< Damping factor of track and its wheels: dw/dt = -c * w as seen on the driven wheel
        public new unsafe ref float mAngularDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_GetMutable_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_GetMutable_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrack_GetMutable_mAngularDamping(_Underlying *_this);
                return ref *__JPH_VehicleTrack_GetMutable_mAngularDamping(_UnderlyingPtr);
            }
        }

        ///< How much torque (Nm) the brakes can apply on the driven wheel
        public new unsafe ref float mMaxBrakeTorque
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_GetMutable_mMaxBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_GetMutable_mMaxBrakeTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrack_GetMutable_mMaxBrakeTorque(_Underlying *_this);
                return ref *__JPH_VehicleTrack_GetMutable_mMaxBrakeTorque(_UnderlyingPtr);
            }
        }

        ///< Ratio between rotation speed of gear box and driven wheel of track
        public new unsafe ref float mDifferentialRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_GetMutable_mDifferentialRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_GetMutable_mDifferentialRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleTrack_GetMutable_mDifferentialRatio(_Underlying *_this);
                return ref *__JPH_VehicleTrack_GetMutable_mDifferentialRatio(_UnderlyingPtr);
            }
        }

        internal unsafe VehicleTrack(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe VehicleTrack() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTrack._Underlying *__JPH_VehicleTrack_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleTrack_DefaultConstruct();
        }

        /// Generated from constructor `JPH::VehicleTrack::VehicleTrack`.
        public unsafe VehicleTrack(JPH._ByValue_VehicleTrack _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTrack._Underlying *__JPH_VehicleTrack_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.VehicleTrack._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleTrack_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::VehicleTrack::VehicleTrack`.
        public VehicleTrack(Const_VehicleTrack _other) : this(new _ByValue_VehicleTrack(_other)) {}

        /// Generated from constructor `JPH::VehicleTrack::VehicleTrack`.
        public VehicleTrack(VehicleTrack _other) : this((Const_VehicleTrack)_other) {}

        /// Generated from method `JPH::VehicleTrack::operator=`.
        public unsafe JPH.VehicleTrack Assign(JPH._ByValue_VehicleTrack _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleTrack_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleTrack_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleTrack._Underlying *__JPH_VehicleTrack_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.VehicleTrack._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_VehicleTrack_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `VehicleTrack` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `VehicleTrack`/`Const_VehicleTrack` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_VehicleTrack
    {
        #pragma warning disable CS0649
        internal readonly Const_VehicleTrack? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_VehicleTrack() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_VehicleTrack(Const_VehicleTrack new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_VehicleTrack(Const_VehicleTrack arg) {return new(arg);}
        public _ByValue_VehicleTrack(JPH._Moved<VehicleTrack> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_VehicleTrack(JPH._Moved<VehicleTrack> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `VehicleTrack` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_VehicleTrack`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleTrack`/`Const_VehicleTrack` directly.
    public class _InOptMut_VehicleTrack
    {
        public VehicleTrack? Opt;

        public _InOptMut_VehicleTrack() {}
        public _InOptMut_VehicleTrack(VehicleTrack value) {Opt = value;}
        public static implicit operator _InOptMut_VehicleTrack(VehicleTrack value) {return new(value);}
    }

    /// This is used for optional parameters of class `VehicleTrack` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_VehicleTrack`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleTrack`/`Const_VehicleTrack` to pass it to the function.
    public class _InOptConst_VehicleTrack
    {
        public Const_VehicleTrack? Opt;

        public _InOptConst_VehicleTrack() {}
        public _InOptConst_VehicleTrack(Const_VehicleTrack value) {Opt = value;}
        public static implicit operator _InOptConst_VehicleTrack(Const_VehicleTrack value) {return new(value);}
    }
}
