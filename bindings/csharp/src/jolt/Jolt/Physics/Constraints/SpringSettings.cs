// machine generated, do not edit
public static partial class JPH
{
    /// Enum used by constraints to specify how the spring is defined
    public enum ESpringMode : byte
    {
        ///< Frequency and damping are specified
        FrequencyAndDamping = 0,
        ///< Stiffness and damping are specified
        StiffnessAndDamping = 1,
    }

    /// Settings for a linear or angular spring
    /// Generated from class `JPH::SpringSettings`.
    /// This is the const half of the class.
    public class Const_SpringSettings : JPH.Object<Const_SpringSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SpringSettings_Destroy(_Underlying *_this);
            __JPH_SpringSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SpringSettings() {Dispose(false);}

        /// Selects the way in which the spring is defined
        /// If the mode is StiffnessAndDamping then mFrequency becomes the stiffness (k) and mDamping becomes the damping ratio (c) in the spring equation F = -k * x - c * v. Otherwise the properties are as documented.
        public unsafe JPH.ESpringMode mMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_Get_mMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_Get_mMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ESpringMode *__JPH_SpringSettings_Get_mMode(_Underlying *_this);
                return *__JPH_SpringSettings_Get_mMode(_UnderlyingPtr);
            }
        }

        /// Valid when mSpringMode = ESpringMode::FrequencyAndDamping.
        /// If mFrequency > 0 the constraint will be soft and mFrequency specifies the oscillation frequency in Hz.
        /// If mFrequency <= 0, mDamping is ignored and the constraint will have hard limits (as hard as the time step / the number of velocity / position solver steps allows).
        public unsafe float mFrequency
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_Get_mFrequency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_Get_mFrequency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SpringSettings_Get_mFrequency(_Underlying *_this);
                return *__JPH_SpringSettings_Get_mFrequency(_UnderlyingPtr);
            }
        }

        /// Valid when mSpringMode = ESpringMode::StiffnessAndDamping.
        /// If mStiffness > 0 the constraint will be soft and mStiffness specifies the stiffness (k) in the spring equation F = -k * x - c * v for a linear or T = -k * theta - c * w for an angular spring.
        /// If mStiffness <= 0, mDamping is ignored and the constraint will have hard limits (as hard as the time step / the number of velocity / position solver steps allows).
        ///
        /// Note that stiffness values are large numbers. To calculate a ballpark value for the needed stiffness you can use:
        /// force = stiffness * delta_spring_length = mass * gravity <=> stiffness = mass * gravity / delta_spring_length.
        /// So if your object weighs 1500 kg and the spring compresses by 2 meters, you need a stiffness in the order of 1500 * 9.81 / 2 ~ 7500 N/m.
        public unsafe float mStiffness
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_Get_mStiffness", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_Get_mStiffness", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SpringSettings_Get_mStiffness(_Underlying *_this);
                return *__JPH_SpringSettings_Get_mStiffness(_UnderlyingPtr);
            }
        }

        /// When mSpringMode = ESpringMode::FrequencyAndDamping mDamping is the damping ratio (0 = no damping, 1 = critical damping).
        /// When mSpringMode = ESpringMode::StiffnessAndDamping mDamping is the damping (c) in the spring equation F = -k * x - c * v for a linear or T = -k * theta - c * w for an angular spring.
        /// Note that if you set mDamping = 0, you will not get an infinite oscillation. Because we integrate physics using an explicit Euler scheme, there is always energy loss.
        /// This is done to keep the simulation from exploding, because with a damping of 0 and even the slightest rounding error, the oscillation could become bigger and bigger until the simulation explodes.
        public unsafe float mDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_Get_mDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_Get_mDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SpringSettings_Get_mDamping(_Underlying *_this);
                return *__JPH_SpringSettings_Get_mDamping(_UnderlyingPtr);
            }
        }

        internal unsafe Const_SpringSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_SpringSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SpringSettings._Underlying *__JPH_SpringSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_SpringSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::SpringSettings::SpringSettings`.
        public unsafe Const_SpringSettings(JPH.Const_SpringSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SpringSettings._Underlying *__JPH_SpringSettings_ConstructFromAnother(JPH.SpringSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_SpringSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::SpringSettings::SpringSettings`.
        public Const_SpringSettings(SpringSettings _other) : this((Const_SpringSettings)_other) {}

        /// Generated from constructor `JPH::SpringSettings::SpringSettings`.
        public unsafe Const_SpringSettings(JPH.ESpringMode inMode, float inFrequencyOrStiffness, float inDamping) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SpringSettings._Underlying *__JPH_SpringSettings_Construct(JPH.ESpringMode inMode, float inFrequencyOrStiffness, float inDamping);
            _UnderlyingPtr = __JPH_SpringSettings_Construct(inMode, inFrequencyOrStiffness, inDamping);
        }

        /// Generated from method `JPH::SpringSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SpringSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SpringSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SpringSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_SpringSettings_size_t(inCount);
        }

        /// Generated from method `JPH::SpringSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SpringSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SpringSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SpringSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_SpringSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SpringSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SpringSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SpringSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SpringSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_SpringSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SpringSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SpringSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SpringSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SpringSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_SpringSettings_size_t(inCount);
        }

        /// Generated from method `JPH::SpringSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SpringSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SpringSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SpringSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_SpringSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SpringSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SpringSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SpringSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SpringSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_SpringSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SpringSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SpringSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SpringSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SpringSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_SpringSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SpringSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SpringSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SpringSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SpringSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_SpringSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::SpringSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SpringSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SpringSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SpringSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_SpringSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SpringSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SpringSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SpringSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SpringSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_SpringSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Check if the spring has a valid frequency / stiffness, if not the spring will be hard
        /// Generated from method `JPH::SpringSettings::HasStiffness`.
        public unsafe bool HasStiffness()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_HasStiffness", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_HasStiffness", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SpringSettings_HasStiffness(_Underlying *_this);
            return __JPH_SpringSettings_HasStiffness(_UnderlyingPtr) != 0;
        }
    }

    /// Settings for a linear or angular spring
    /// Generated from class `JPH::SpringSettings`.
    /// This is the non-const half of the class.
    public class SpringSettings : Const_SpringSettings
    {
        /// Selects the way in which the spring is defined
        /// If the mode is StiffnessAndDamping then mFrequency becomes the stiffness (k) and mDamping becomes the damping ratio (c) in the spring equation F = -k * x - c * v. Otherwise the properties are as documented.
        public new unsafe ref JPH.ESpringMode mMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_GetMutable_mMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_GetMutable_mMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ESpringMode *__JPH_SpringSettings_GetMutable_mMode(_Underlying *_this);
                return ref *__JPH_SpringSettings_GetMutable_mMode(_UnderlyingPtr);
            }
        }

        /// Valid when mSpringMode = ESpringMode::FrequencyAndDamping.
        /// If mFrequency > 0 the constraint will be soft and mFrequency specifies the oscillation frequency in Hz.
        /// If mFrequency <= 0, mDamping is ignored and the constraint will have hard limits (as hard as the time step / the number of velocity / position solver steps allows).
        public new unsafe ref float mFrequency
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_GetMutable_mFrequency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_GetMutable_mFrequency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SpringSettings_GetMutable_mFrequency(_Underlying *_this);
                return ref *__JPH_SpringSettings_GetMutable_mFrequency(_UnderlyingPtr);
            }
        }

        /// Valid when mSpringMode = ESpringMode::StiffnessAndDamping.
        /// If mStiffness > 0 the constraint will be soft and mStiffness specifies the stiffness (k) in the spring equation F = -k * x - c * v for a linear or T = -k * theta - c * w for an angular spring.
        /// If mStiffness <= 0, mDamping is ignored and the constraint will have hard limits (as hard as the time step / the number of velocity / position solver steps allows).
        ///
        /// Note that stiffness values are large numbers. To calculate a ballpark value for the needed stiffness you can use:
        /// force = stiffness * delta_spring_length = mass * gravity <=> stiffness = mass * gravity / delta_spring_length.
        /// So if your object weighs 1500 kg and the spring compresses by 2 meters, you need a stiffness in the order of 1500 * 9.81 / 2 ~ 7500 N/m.
        public new unsafe ref float mStiffness
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_GetMutable_mStiffness", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_GetMutable_mStiffness", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SpringSettings_GetMutable_mStiffness(_Underlying *_this);
                return ref *__JPH_SpringSettings_GetMutable_mStiffness(_UnderlyingPtr);
            }
        }

        /// When mSpringMode = ESpringMode::FrequencyAndDamping mDamping is the damping ratio (0 = no damping, 1 = critical damping).
        /// When mSpringMode = ESpringMode::StiffnessAndDamping mDamping is the damping (c) in the spring equation F = -k * x - c * v for a linear or T = -k * theta - c * w for an angular spring.
        /// Note that if you set mDamping = 0, you will not get an infinite oscillation. Because we integrate physics using an explicit Euler scheme, there is always energy loss.
        /// This is done to keep the simulation from exploding, because with a damping of 0 and even the slightest rounding error, the oscillation could become bigger and bigger until the simulation explodes.
        public new unsafe ref float mDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_GetMutable_mDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_GetMutable_mDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SpringSettings_GetMutable_mDamping(_Underlying *_this);
                return ref *__JPH_SpringSettings_GetMutable_mDamping(_UnderlyingPtr);
            }
        }

        internal unsafe SpringSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe SpringSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SpringSettings._Underlying *__JPH_SpringSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_SpringSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::SpringSettings::SpringSettings`.
        public unsafe SpringSettings(JPH.Const_SpringSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SpringSettings._Underlying *__JPH_SpringSettings_ConstructFromAnother(JPH.SpringSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_SpringSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::SpringSettings::SpringSettings`.
        public SpringSettings(SpringSettings _other) : this((Const_SpringSettings)_other) {}

        /// Generated from constructor `JPH::SpringSettings::SpringSettings`.
        public unsafe SpringSettings(JPH.ESpringMode inMode, float inFrequencyOrStiffness, float inDamping) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SpringSettings._Underlying *__JPH_SpringSettings_Construct(JPH.ESpringMode inMode, float inFrequencyOrStiffness, float inDamping);
            _UnderlyingPtr = __JPH_SpringSettings_Construct(inMode, inFrequencyOrStiffness, inDamping);
        }

        /// Generated from method `JPH::SpringSettings::operator=`.
        public unsafe JPH.SpringSettings Assign(JPH.Const_SpringSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SpringSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SpringSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SpringSettings._Underlying *__JPH_SpringSettings_AssignFromAnother(_Underlying *_this, JPH.SpringSettings._Underlying *_other);
            JPH.SpringSettings __ret;
            __ret = new(__JPH_SpringSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used for optional parameters of class `SpringSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SpringSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SpringSettings`/`Const_SpringSettings` directly.
    public class _InOptMut_SpringSettings
    {
        public SpringSettings? Opt;

        public _InOptMut_SpringSettings() {}
        public _InOptMut_SpringSettings(SpringSettings value) {Opt = value;}
        public static implicit operator _InOptMut_SpringSettings(SpringSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `SpringSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SpringSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SpringSettings`/`Const_SpringSettings` to pass it to the function.
    public class _InOptConst_SpringSettings
    {
        public Const_SpringSettings? Opt;

        public _InOptConst_SpringSettings() {}
        public _InOptConst_SpringSettings(Const_SpringSettings value) {Opt = value;}
        public static implicit operator _InOptConst_SpringSettings(Const_SpringSettings value) {return new(value);}
    }
}
