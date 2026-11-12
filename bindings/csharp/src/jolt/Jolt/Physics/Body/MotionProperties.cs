// machine generated, do not edit
public static partial class JPH
{
    /// The Body class only keeps track of state for static bodies, the MotionProperties class keeps the additional state needed for a moving Body. It has a 1-on-1 relationship with the body.
    /// Generated from class `JPH::MotionProperties`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SoftBodyMotionProperties`
    /// This is the const half of the class.
    public class Const_MotionProperties : JPH.Object<Const_MotionProperties>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_Destroy(_Underlying *_this);
            __JPH_MotionProperties_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_MotionProperties() {Dispose(false);}

        ///< Constant indicating that body is not active
        public static unsafe uint CInactiveIndex
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_Get_cInactiveIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_Get_cInactiveIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_MotionProperties_Get_cInactiveIndex();
                return *__JPH_MotionProperties_Get_cInactiveIndex();
            }
        }

        internal unsafe Const_MotionProperties(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_MotionProperties() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotionProperties._Underlying *__JPH_MotionProperties_DefaultConstruct();
            _UnderlyingPtr = __JPH_MotionProperties_DefaultConstruct();
        }

        /// Generated from constructor `JPH::MotionProperties::MotionProperties`.
        public unsafe Const_MotionProperties(JPH.Const_MotionProperties _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotionProperties._Underlying *__JPH_MotionProperties_ConstructFromAnother(JPH.MotionProperties._Underlying *_other);
            _UnderlyingPtr = __JPH_MotionProperties_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::MotionProperties::MotionProperties`.
        public Const_MotionProperties(MotionProperties _other) : this((Const_MotionProperties)_other) {}

        /// Generated from method `JPH::MotionProperties::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_MotionProperties_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_MotionProperties_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_MotionProperties_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_MotionProperties_size_t(inCount);
        }

        /// Generated from method `JPH::MotionProperties::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_MotionProperties_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_MotionProperties_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_MotionProperties_void_ptr(void *inPointer);
            __Jolt_delete_JPH_MotionProperties_void_ptr(inPointer);
        }

        /// Generated from method `JPH::MotionProperties::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_MotionProperties_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_MotionProperties_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_MotionProperties_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_MotionProperties_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::MotionProperties::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_MotionProperties_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_MotionProperties_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_MotionProperties_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_MotionProperties_size_t(inCount);
        }

        /// Generated from method `JPH::MotionProperties::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_MotionProperties_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_MotionProperties_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_MotionProperties_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_MotionProperties_void_ptr(inPointer);
        }

        /// Generated from method `JPH::MotionProperties::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_MotionProperties_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_MotionProperties_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_MotionProperties_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_MotionProperties_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::MotionProperties::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_MotionProperties_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_MotionProperties_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_MotionProperties_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_MotionProperties_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::MotionProperties::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_MotionProperties_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_MotionProperties_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_MotionProperties_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_MotionProperties_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::MotionProperties::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_MotionProperties_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_MotionProperties_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_MotionProperties_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_MotionProperties_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::MotionProperties::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_MotionProperties_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_MotionProperties_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_MotionProperties_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_MotionProperties_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Motion quality, or how well it detects collisions when it has a high velocity
        /// Generated from method `JPH::MotionProperties::GetMotionQuality`.
        public unsafe JPH.EMotionQuality GetMotionQuality()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.EMotionQuality __JPH_MotionProperties_GetMotionQuality(_Underlying *_this);
            return __JPH_MotionProperties_GetMotionQuality(_UnderlyingPtr);
        }

        /// If this body can go to sleep.
        /// Generated from method `JPH::MotionProperties::GetAllowSleeping`.
        public unsafe bool GetAllowSleeping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_MotionProperties_GetAllowSleeping(_Underlying *_this);
            return __JPH_MotionProperties_GetAllowSleeping(_UnderlyingPtr) != 0;
        }

        /// Get world space linear velocity of the center of mass
        /// Generated from method `JPH::MotionProperties::GetLinearVelocity`.
        public unsafe JPH.Vec3 GetLinearVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_MotionProperties_GetLinearVelocity(_Underlying *_this);
            return new(__JPH_MotionProperties_GetLinearVelocity(_UnderlyingPtr), is_owning: true);
        }

        /// Get world space angular velocity of the center of mass
        /// Generated from method `JPH::MotionProperties::GetAngularVelocity`.
        public unsafe JPH.Vec3 GetAngularVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_MotionProperties_GetAngularVelocity(_Underlying *_this);
            return new(__JPH_MotionProperties_GetAngularVelocity(_UnderlyingPtr), is_owning: true);
        }

        /// Maximum linear velocity that a body can achieve. Used to prevent the system from exploding.
        /// Generated from method `JPH::MotionProperties::GetMaxLinearVelocity`.
        public unsafe float GetMaxLinearVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotionProperties_GetMaxLinearVelocity(_Underlying *_this);
            return __JPH_MotionProperties_GetMaxLinearVelocity(_UnderlyingPtr);
        }

        /// Maximum angular velocity that a body can achieve. Used to prevent the system from exploding.
        /// Generated from method `JPH::MotionProperties::GetMaxAngularVelocity`.
        public unsafe float GetMaxAngularVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotionProperties_GetMaxAngularVelocity(_Underlying *_this);
            return __JPH_MotionProperties_GetMaxAngularVelocity(_UnderlyingPtr);
        }

        /// Get linear damping: dv/dt = -c * v. c. Value should be zero or positive and is usually close to 0.
        /// Generated from method `JPH::MotionProperties::GetLinearDamping`.
        public unsafe float GetLinearDamping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotionProperties_GetLinearDamping(_Underlying *_this);
            return __JPH_MotionProperties_GetLinearDamping(_UnderlyingPtr);
        }

        /// Get angular damping: dw/dt = -c * w. c. Value should be zero or positive and is usually close to 0.
        /// Generated from method `JPH::MotionProperties::GetAngularDamping`.
        public unsafe float GetAngularDamping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotionProperties_GetAngularDamping(_Underlying *_this);
            return __JPH_MotionProperties_GetAngularDamping(_UnderlyingPtr);
        }

        /// Get gravity factor (1 = normal gravity, 0 = no gravity)
        /// Generated from method `JPH::MotionProperties::GetGravityFactor`.
        public unsafe float GetGravityFactor()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotionProperties_GetGravityFactor(_Underlying *_this);
            return __JPH_MotionProperties_GetGravityFactor(_UnderlyingPtr);
        }

        /// Get inverse mass (1 / mass). Should only be called on a dynamic object (static or kinematic bodies have infinite mass so should be treated as 1 / mass = 0)
        /// Generated from method `JPH::MotionProperties::GetInverseMass`.
        public unsafe float GetInverseMass()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetInverseMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetInverseMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotionProperties_GetInverseMass(_Underlying *_this);
            return __JPH_MotionProperties_GetInverseMass(_UnderlyingPtr);
        }

        /// Generated from method `JPH::MotionProperties::GetInverseMassUnchecked`.
        public unsafe float GetInverseMassUnchecked()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetInverseMassUnchecked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetInverseMassUnchecked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_MotionProperties_GetInverseMassUnchecked(_Underlying *_this);
            return __JPH_MotionProperties_GetInverseMassUnchecked(_UnderlyingPtr);
        }

        /// Diagonal of inverse inertia matrix: D. Should only be called on a dynamic object (static or kinematic bodies have infinite mass so should be treated as D = 0)
        /// Generated from method `JPH::MotionProperties::GetInverseInertiaDiagonal`.
        public unsafe JPH.Vec3 GetInverseInertiaDiagonal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetInverseInertiaDiagonal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetInverseInertiaDiagonal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_MotionProperties_GetInverseInertiaDiagonal(_Underlying *_this);
            return new(__JPH_MotionProperties_GetInverseInertiaDiagonal(_UnderlyingPtr), is_owning: true);
        }

        /// Rotation (R) that takes inverse inertia diagonal to local space: \f$I_{body}^{-1} = R \: D \: R^{-1}\f$
        /// Generated from method `JPH::MotionProperties::GetInertiaRotation`.
        public unsafe JPH.Quat GetInertiaRotation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetInertiaRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetInertiaRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_MotionProperties_GetInertiaRotation(_Underlying *_this);
            return new(__JPH_MotionProperties_GetInertiaRotation(_UnderlyingPtr), is_owning: true);
        }

        /// Get inverse inertia matrix (\f$I_{body}^{-1}\f$). Will be a matrix of zeros for a static or kinematic object.
        /// Generated from method `JPH::MotionProperties::GetLocalSpaceInverseInertia`.
        public unsafe JPH.Mat44 GetLocalSpaceInverseInertia()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetLocalSpaceInverseInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetLocalSpaceInverseInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_MotionProperties_GetLocalSpaceInverseInertia(_Underlying *_this);
            return new(__JPH_MotionProperties_GetLocalSpaceInverseInertia(_UnderlyingPtr), is_owning: true);
        }

        /// Same as GetLocalSpaceInverseInertia() but doesn't check if the body is dynamic
        /// Generated from method `JPH::MotionProperties::GetLocalSpaceInverseInertiaUnchecked`.
        public unsafe JPH.Mat44 GetLocalSpaceInverseInertiaUnchecked()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetLocalSpaceInverseInertiaUnchecked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetLocalSpaceInverseInertiaUnchecked", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_MotionProperties_GetLocalSpaceInverseInertiaUnchecked(_Underlying *_this);
            return new(__JPH_MotionProperties_GetLocalSpaceInverseInertiaUnchecked(_UnderlyingPtr), is_owning: true);
        }

        /// Get inverse inertia matrix (\f$I^{-1}\f$) for a given object rotation (translation will be ignored). Zero if object is static or kinematic.
        /// Generated from method `JPH::MotionProperties::GetInverseInertiaForRotation`.
        public unsafe JPH.Mat44 GetInverseInertiaForRotation(JPH.Const_Mat44 inRotation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetInverseInertiaForRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetInverseInertiaForRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_MotionProperties_GetInverseInertiaForRotation(_Underlying *_this, JPH.Const_Mat44._Underlying *inRotation);
            return new(__JPH_MotionProperties_GetInverseInertiaForRotation(_UnderlyingPtr, inRotation._UnderlyingPtr), is_owning: true);
        }

        /// Multiply a vector with the inverse world space inertia tensor (\f$I_{world}^{-1}\f$). Zero if object is static or kinematic.
        /// Generated from method `JPH::MotionProperties::MultiplyWorldSpaceInverseInertiaByVector`.
        public unsafe JPH.Vec3 MultiplyWorldSpaceInverseInertiaByVector(JPH.Const_Quat inBodyRotation, JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_MultiplyWorldSpaceInverseInertiaByVector", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_MultiplyWorldSpaceInverseInertiaByVector", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_MotionProperties_MultiplyWorldSpaceInverseInertiaByVector(_Underlying *_this, JPH.Quat._Underlying *inBodyRotation, JPH.Vec3._Underlying *inV);
            return new(__JPH_MotionProperties_MultiplyWorldSpaceInverseInertiaByVector(_UnderlyingPtr, inBodyRotation._UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Velocity of point inPoint (in center of mass space, e.g. on the surface of the body) of the body (unit: m/s)
        /// Generated from method `JPH::MotionProperties::GetPointVelocityCOM`.
        public unsafe JPH.Vec3 GetPointVelocityCOM(JPH.Const_Vec3 inPointRelativeToCOM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetPointVelocityCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetPointVelocityCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_MotionProperties_GetPointVelocityCOM(_Underlying *_this, JPH.Vec3._Underlying *inPointRelativeToCOM);
            return new(__JPH_MotionProperties_GetPointVelocityCOM(_UnderlyingPtr, inPointRelativeToCOM._UnderlyingPtr), is_owning: true);
        }

        // Get the total amount of force applied to the center of mass this time step (through Body::AddForce calls). Note that it will reset to zero after PhysicsSystem::Update.
        /// Generated from method `JPH::MotionProperties::GetAccumulatedForce`.
        public unsafe JPH.Vec3 GetAccumulatedForce()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetAccumulatedForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetAccumulatedForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_MotionProperties_GetAccumulatedForce(_Underlying *_this);
            return new(__JPH_MotionProperties_GetAccumulatedForce(_UnderlyingPtr), is_owning: true);
        }

        // Get the total amount of torque applied to the center of mass this time step (through Body::AddForce/Body::AddTorque calls). Note that it will reset to zero after PhysicsSystem::Update.
        /// Generated from method `JPH::MotionProperties::GetAccumulatedTorque`.
        public unsafe JPH.Vec3 GetAccumulatedTorque()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetAccumulatedTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetAccumulatedTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_MotionProperties_GetAccumulatedTorque(_Underlying *_this);
            return new(__JPH_MotionProperties_GetAccumulatedTorque(_UnderlyingPtr), is_owning: true);
        }

        /// Returns a vector where the linear components that are not allowed by mAllowedDOFs are set to 0 and the rest to 0xffffffff
        /// Generated from method `JPH::MotionProperties::GetLinearDOFsMask`.
        public unsafe JPH.UVec4 GetLinearDOFsMask()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetLinearDOFsMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetLinearDOFsMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_MotionProperties_GetLinearDOFsMask(_Underlying *_this);
            return new(__JPH_MotionProperties_GetLinearDOFsMask(_UnderlyingPtr), is_owning: true);
        }

        /// Takes a translation vector inV and returns a vector where the components that are not allowed by mAllowedDOFs are set to 0
        /// Generated from method `JPH::MotionProperties::LockTranslation`.
        public unsafe JPH.Vec3 LockTranslation(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_LockTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_LockTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_MotionProperties_LockTranslation(_Underlying *_this, JPH.Vec3._Underlying *inV);
            return new(__JPH_MotionProperties_LockTranslation(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Returns a vector where the angular components that are not allowed by mAllowedDOFs are set to 0 and the rest to 0xffffffff
        /// Generated from method `JPH::MotionProperties::GetAngularDOFsMask`.
        public unsafe JPH.UVec4 GetAngularDOFsMask()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetAngularDOFsMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetAngularDOFsMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_MotionProperties_GetAngularDOFsMask(_Underlying *_this);
            return new(__JPH_MotionProperties_GetAngularDOFsMask(_UnderlyingPtr), is_owning: true);
        }

        /// Takes an angular velocity / torque vector inV and returns a vector where the components that are not allowed by mAllowedDOFs are set to 0
        /// Generated from method `JPH::MotionProperties::LockAngular`.
        public unsafe JPH.Vec3 LockAngular(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_LockAngular", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_LockAngular", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_MotionProperties_LockAngular(_Underlying *_this, JPH.Vec3._Underlying *inV);
            return new(__JPH_MotionProperties_LockAngular(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::MotionProperties::GetNumVelocityStepsOverride`.
        public unsafe uint GetNumVelocityStepsOverride()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_MotionProperties_GetNumVelocityStepsOverride(_Underlying *_this);
            return __JPH_MotionProperties_GetNumVelocityStepsOverride(_UnderlyingPtr);
        }

        /// Generated from method `JPH::MotionProperties::GetNumPositionStepsOverride`.
        public unsafe uint GetNumPositionStepsOverride()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_MotionProperties_GetNumPositionStepsOverride(_Underlying *_this);
            return __JPH_MotionProperties_GetNumPositionStepsOverride(_UnderlyingPtr);
        }

        /// Access to the island index
        /// Generated from method `JPH::MotionProperties::GetIslandIndexInternal`.
        public unsafe uint GetIslandIndexInternal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetIslandIndexInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetIslandIndexInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_MotionProperties_GetIslandIndexInternal(_Underlying *_this);
            return __JPH_MotionProperties_GetIslandIndexInternal(_UnderlyingPtr);
        }

        /// Access to the index in the active bodies array
        /// Generated from method `JPH::MotionProperties::GetIndexInActiveBodiesInternal`.
        public unsafe uint GetIndexInActiveBodiesInternal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_GetIndexInActiveBodiesInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_GetIndexInActiveBodiesInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_MotionProperties_GetIndexInActiveBodiesInternal(_Underlying *_this);
            return __JPH_MotionProperties_GetIndexInActiveBodiesInternal(_UnderlyingPtr);
        }
    }

    /// The Body class only keeps track of state for static bodies, the MotionProperties class keeps the additional state needed for a moving Body. It has a 1-on-1 relationship with the body.
    /// Generated from class `JPH::MotionProperties`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SoftBodyMotionProperties`
    /// This is the non-const half of the class.
    public class MotionProperties : Const_MotionProperties
    {
        internal unsafe MotionProperties(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe MotionProperties() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotionProperties._Underlying *__JPH_MotionProperties_DefaultConstruct();
            _UnderlyingPtr = __JPH_MotionProperties_DefaultConstruct();
        }

        /// Generated from constructor `JPH::MotionProperties::MotionProperties`.
        public unsafe MotionProperties(JPH.Const_MotionProperties _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotionProperties._Underlying *__JPH_MotionProperties_ConstructFromAnother(JPH.MotionProperties._Underlying *_other);
            _UnderlyingPtr = __JPH_MotionProperties_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::MotionProperties::MotionProperties`.
        public MotionProperties(MotionProperties _other) : this((Const_MotionProperties)_other) {}

        /// Generated from method `JPH::MotionProperties::operator=`.
        public unsafe JPH.MotionProperties Assign(JPH.Const_MotionProperties _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.MotionProperties._Underlying *__JPH_MotionProperties_AssignFromAnother(_Underlying *_this, JPH.MotionProperties._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_MotionProperties_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Set world space linear velocity of the center of mass
        /// Generated from method `JPH::MotionProperties::SetLinearVelocity`.
        public unsafe void SetLinearVelocity(JPH.Const_Vec3 inLinearVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SetLinearVelocity(_Underlying *_this, JPH.Vec3._Underlying *inLinearVelocity);
            __JPH_MotionProperties_SetLinearVelocity(_UnderlyingPtr, inLinearVelocity._UnderlyingPtr);
        }

        /// Set world space linear velocity of the center of mass, will make sure the value is clamped against the maximum linear velocity
        /// Generated from method `JPH::MotionProperties::SetLinearVelocityClamped`.
        public unsafe void SetLinearVelocityClamped(JPH.Const_Vec3 inLinearVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SetLinearVelocityClamped", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SetLinearVelocityClamped", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SetLinearVelocityClamped(_Underlying *_this, JPH.Vec3._Underlying *inLinearVelocity);
            __JPH_MotionProperties_SetLinearVelocityClamped(_UnderlyingPtr, inLinearVelocity._UnderlyingPtr);
        }

        /// Set world space angular velocity of the center of mass
        /// Generated from method `JPH::MotionProperties::SetAngularVelocity`.
        public unsafe void SetAngularVelocity(JPH.Const_Vec3 inAngularVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SetAngularVelocity(_Underlying *_this, JPH.Vec3._Underlying *inAngularVelocity);
            __JPH_MotionProperties_SetAngularVelocity(_UnderlyingPtr, inAngularVelocity._UnderlyingPtr);
        }

        /// Set world space angular velocity of the center of mass, will make sure the value is clamped against the maximum angular velocity
        /// Generated from method `JPH::MotionProperties::SetAngularVelocityClamped`.
        public unsafe void SetAngularVelocityClamped(JPH.Const_Vec3 inAngularVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SetAngularVelocityClamped", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SetAngularVelocityClamped", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SetAngularVelocityClamped(_Underlying *_this, JPH.Vec3._Underlying *inAngularVelocity);
            __JPH_MotionProperties_SetAngularVelocityClamped(_UnderlyingPtr, inAngularVelocity._UnderlyingPtr);
        }

        /// Set velocity of body such that it will be rotate/translate by inDeltaPosition/Rotation in inDeltaTime seconds.
        /// Generated from method `JPH::MotionProperties::MoveKinematic`.
        public unsafe void MoveKinematic(JPH.Const_Vec3 inDeltaPosition, JPH.Const_Quat inDeltaRotation, float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_MoveKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_MoveKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_MoveKinematic(_Underlying *_this, JPH.Vec3._Underlying *inDeltaPosition, JPH.Quat._Underlying *inDeltaRotation, float inDeltaTime);
            __JPH_MotionProperties_MoveKinematic(_UnderlyingPtr, inDeltaPosition._UnderlyingPtr, inDeltaRotation._UnderlyingPtr, inDeltaTime);
        }

        /// Generated from method `JPH::MotionProperties::SetMaxLinearVelocity`.
        public unsafe void SetMaxLinearVelocity(float inLinearVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SetMaxLinearVelocity(_Underlying *_this, float inLinearVelocity);
            __JPH_MotionProperties_SetMaxLinearVelocity(_UnderlyingPtr, inLinearVelocity);
        }

        /// Generated from method `JPH::MotionProperties::SetMaxAngularVelocity`.
        public unsafe void SetMaxAngularVelocity(float inAngularVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SetMaxAngularVelocity(_Underlying *_this, float inAngularVelocity);
            __JPH_MotionProperties_SetMaxAngularVelocity(_UnderlyingPtr, inAngularVelocity);
        }

        /// Clamp velocity according to limit
        /// Generated from method `JPH::MotionProperties::ClampLinearVelocity`.
        public unsafe void ClampLinearVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_ClampLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_ClampLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_ClampLinearVelocity(_Underlying *_this);
            __JPH_MotionProperties_ClampLinearVelocity(_UnderlyingPtr);
        }

        /// Generated from method `JPH::MotionProperties::ClampAngularVelocity`.
        public unsafe void ClampAngularVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_ClampAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_ClampAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_ClampAngularVelocity(_Underlying *_this);
            __JPH_MotionProperties_ClampAngularVelocity(_UnderlyingPtr);
        }

        /// Generated from method `JPH::MotionProperties::SetLinearDamping`.
        public unsafe void SetLinearDamping(float inLinearDamping)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SetLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SetLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SetLinearDamping(_Underlying *_this, float inLinearDamping);
            __JPH_MotionProperties_SetLinearDamping(_UnderlyingPtr, inLinearDamping);
        }

        /// Generated from method `JPH::MotionProperties::SetAngularDamping`.
        public unsafe void SetAngularDamping(float inAngularDamping)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SetAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SetAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SetAngularDamping(_Underlying *_this, float inAngularDamping);
            __JPH_MotionProperties_SetAngularDamping(_UnderlyingPtr, inAngularDamping);
        }

        /// Generated from method `JPH::MotionProperties::SetGravityFactor`.
        public unsafe void SetGravityFactor(float inGravityFactor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SetGravityFactor(_Underlying *_this, float inGravityFactor);
            __JPH_MotionProperties_SetGravityFactor(_UnderlyingPtr, inGravityFactor);
        }

        /// Set the inverse mass (1 / mass).
        /// Note that mass and inertia are linearly related (e.g. inertia of a sphere with mass m and radius r is \f$2/5 \: m \: r^2\f$).
        /// If you change mass, inertia should probably change as well. You can use ScaleToMass to update mass and inertia at the same time.
        /// If all your translation degrees of freedom are restricted, make sure this is zero (see EAllowedDOFs).
        /// Generated from method `JPH::MotionProperties::SetInverseMass`.
        public unsafe void SetInverseMass(float inInverseMass)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SetInverseMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SetInverseMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SetInverseMass(_Underlying *_this, float inInverseMass);
            __JPH_MotionProperties_SetInverseMass(_UnderlyingPtr, inInverseMass);
        }

        /// Set the inverse inertia tensor in local space by setting the diagonal and the rotation: \f$I_{body}^{-1} = R \: D \: R^{-1}\f$.
        /// Note that mass and inertia are linearly related (e.g. inertia of a sphere with mass m and radius r is \f$2/5 \: m \: r^2\f$).
        /// If you change inertia, mass should probably change as well. You can use ScaleToMass to update mass and inertia at the same time.
        /// If all your rotation degrees of freedom are restricted, make sure this is zero (see EAllowedDOFs).
        /// Generated from method `JPH::MotionProperties::SetInverseInertia`.
        public unsafe void SetInverseInertia(JPH.Const_Vec3 inDiagonal, JPH.Const_Quat inRot)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SetInverseInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SetInverseInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SetInverseInertia(_Underlying *_this, JPH.Vec3._Underlying *inDiagonal, JPH.Quat._Underlying *inRot);
            __JPH_MotionProperties_SetInverseInertia(_UnderlyingPtr, inDiagonal._UnderlyingPtr, inRot._UnderlyingPtr);
        }

        /// Sets the mass to inMass and scale the inertia tensor based on the ratio between the old and new mass.
        /// Note that this only works when the current mass is finite (i.e. the body is dynamic and translational degrees of freedom are not restricted).
        /// Generated from method `JPH::MotionProperties::ScaleToMass`.
        public unsafe void ScaleToMass(float inMass)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_ScaleToMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_ScaleToMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_ScaleToMass(_Underlying *_this, float inMass);
            __JPH_MotionProperties_ScaleToMass(_UnderlyingPtr, inMass);
        }

        // Reset the total accumulated force, note that this will be done automatically after every time step.
        /// Generated from method `JPH::MotionProperties::ResetForce`.
        public unsafe void ResetForce()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_ResetForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_ResetForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_ResetForce(_Underlying *_this);
            __JPH_MotionProperties_ResetForce(_UnderlyingPtr);
        }

        // Reset the total accumulated torque, note that this will be done automatically after every time step.
        /// Generated from method `JPH::MotionProperties::ResetTorque`.
        public unsafe void ResetTorque()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_ResetTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_ResetTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_ResetTorque(_Underlying *_this);
            __JPH_MotionProperties_ResetTorque(_UnderlyingPtr);
        }

        // Reset the current velocity and accumulated force and torque.
        /// Generated from method `JPH::MotionProperties::ResetMotion`.
        public unsafe void ResetMotion()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_ResetMotion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_ResetMotion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_ResetMotion(_Underlying *_this);
            __JPH_MotionProperties_ResetMotion(_UnderlyingPtr);
        }

        /// Used only when this body is dynamic and colliding. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
        /// Generated from method `JPH::MotionProperties::SetNumVelocityStepsOverride`.
        public unsafe void SetNumVelocityStepsOverride(uint inN)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SetNumVelocityStepsOverride(_Underlying *_this, uint inN);
            __JPH_MotionProperties_SetNumVelocityStepsOverride(_UnderlyingPtr, inN);
        }

        /// Used only when this body is dynamic and colliding. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
        /// Generated from method `JPH::MotionProperties::SetNumPositionStepsOverride`.
        public unsafe void SetNumPositionStepsOverride(uint inN)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SetNumPositionStepsOverride(_Underlying *_this, uint inN);
            __JPH_MotionProperties_SetNumPositionStepsOverride(_UnderlyingPtr, inN);
        }

        ///@name Update linear and angular velocity (used during constraint solving)
        ///@{
        /// Generated from method `JPH::MotionProperties::AddLinearVelocityStep`.
        public unsafe void AddLinearVelocityStep(JPH.Const_Vec3 inLinearVelocityChange)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_AddLinearVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_AddLinearVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_AddLinearVelocityStep(_Underlying *_this, JPH.Vec3._Underlying *inLinearVelocityChange);
            __JPH_MotionProperties_AddLinearVelocityStep(_UnderlyingPtr, inLinearVelocityChange._UnderlyingPtr);
        }

        /// Generated from method `JPH::MotionProperties::SubLinearVelocityStep`.
        public unsafe void SubLinearVelocityStep(JPH.Const_Vec3 inLinearVelocityChange)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SubLinearVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SubLinearVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SubLinearVelocityStep(_Underlying *_this, JPH.Vec3._Underlying *inLinearVelocityChange);
            __JPH_MotionProperties_SubLinearVelocityStep(_UnderlyingPtr, inLinearVelocityChange._UnderlyingPtr);
        }

        /// Generated from method `JPH::MotionProperties::AddAngularVelocityStep`.
        public unsafe void AddAngularVelocityStep(JPH.Const_Vec3 inAngularVelocityChange)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_AddAngularVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_AddAngularVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_AddAngularVelocityStep(_Underlying *_this, JPH.Vec3._Underlying *inAngularVelocityChange);
            __JPH_MotionProperties_AddAngularVelocityStep(_UnderlyingPtr, inAngularVelocityChange._UnderlyingPtr);
        }

        /// Generated from method `JPH::MotionProperties::SubAngularVelocityStep`.
        public unsafe void SubAngularVelocityStep(JPH.Const_Vec3 inAngularVelocityChange)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SubAngularVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SubAngularVelocityStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SubAngularVelocityStep(_Underlying *_this, JPH.Vec3._Underlying *inAngularVelocityChange);
            __JPH_MotionProperties_SubAngularVelocityStep(_UnderlyingPtr, inAngularVelocityChange._UnderlyingPtr);
        }

        /// Apply the gyroscopic force (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
        /// Generated from method `JPH::MotionProperties::ApplyGyroscopicForceInternal`.
        public unsafe void ApplyGyroscopicForceInternal(JPH.Const_Quat inBodyRotation, float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_ApplyGyroscopicForceInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_ApplyGyroscopicForceInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_ApplyGyroscopicForceInternal(_Underlying *_this, JPH.Quat._Underlying *inBodyRotation, float inDeltaTime);
            __JPH_MotionProperties_ApplyGyroscopicForceInternal(_UnderlyingPtr, inBodyRotation._UnderlyingPtr, inDeltaTime);
        }

        /// Apply all accumulated forces, torques and drag (should only be called by the PhysicsSystem)
        /// Generated from method `JPH::MotionProperties::ApplyForceTorqueAndDragInternal`.
        public unsafe void ApplyForceTorqueAndDragInternal(JPH.Const_Quat inBodyRotation, JPH.Const_Vec3 inGravity, float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_ApplyForceTorqueAndDragInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_ApplyForceTorqueAndDragInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_ApplyForceTorqueAndDragInternal(_Underlying *_this, JPH.Quat._Underlying *inBodyRotation, JPH.Vec3._Underlying *inGravity, float inDeltaTime);
            __JPH_MotionProperties_ApplyForceTorqueAndDragInternal(_UnderlyingPtr, inBodyRotation._UnderlyingPtr, inGravity._UnderlyingPtr, inDeltaTime);
        }

        /// Generated from method `JPH::MotionProperties::SetIslandIndexInternal`.
        public unsafe void SetIslandIndexInternal(uint inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_SetIslandIndexInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_SetIslandIndexInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_SetIslandIndexInternal(_Underlying *_this, uint inIndex);
            __JPH_MotionProperties_SetIslandIndexInternal(_UnderlyingPtr, inIndex);
        }

        /// Reset spheres to center around inPoints with radius 0
        /// Generated from method `JPH::MotionProperties::ResetSleepTestSpheres`.
        public unsafe void ResetSleepTestSpheres(JPH.Const_Vec3? inPoints)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_ResetSleepTestSpheres", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_ResetSleepTestSpheres", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_ResetSleepTestSpheres(_Underlying *_this, JPH.Const_Vec3._Underlying *inPoints);
            __JPH_MotionProperties_ResetSleepTestSpheres(_UnderlyingPtr, inPoints is not null ? inPoints._UnderlyingPtr : null);
        }

        /// Reset the sleep test timer without resetting the sleep test spheres
        /// Generated from method `JPH::MotionProperties::ResetSleepTestTimer`.
        public unsafe void ResetSleepTestTimer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_MotionProperties_ResetSleepTestTimer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_MotionProperties_ResetSleepTestTimer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_MotionProperties_ResetSleepTestTimer(_Underlying *_this);
            __JPH_MotionProperties_ResetSleepTestTimer(_UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `MotionProperties` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_MotionProperties`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `MotionProperties`/`Const_MotionProperties` directly.
    public class _InOptMut_MotionProperties
    {
        public MotionProperties? Opt;

        public _InOptMut_MotionProperties() {}
        public _InOptMut_MotionProperties(MotionProperties value) {Opt = value;}
        public static implicit operator _InOptMut_MotionProperties(MotionProperties value) {return new(value);}
    }

    /// This is used for optional parameters of class `MotionProperties` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_MotionProperties`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `MotionProperties`/`Const_MotionProperties` to pass it to the function.
    public class _InOptConst_MotionProperties
    {
        public Const_MotionProperties? Opt;

        public _InOptConst_MotionProperties() {}
        public _InOptConst_MotionProperties(Const_MotionProperties value) {Opt = value;}
        public static implicit operator _InOptConst_MotionProperties(Const_MotionProperties value) {return new(value);}
    }
}
