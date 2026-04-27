// machine generated, do not edit
public static partial class JPH
{
    /// Holds a 4x4 matrix of floats, but supports also operations on the 3x3 upper left part of the matrix.
    /// Generated from class `JPH::Mat44`.
    /// This is the const half of the class.
    public class Const_Mat44 : JPH.Object<Const_Mat44>, System.IDisposable, System.IEquatable<JPH.Const_Mat44>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Mat44_Destroy(_Underlying *_this);
            __JPH_Mat44_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Mat44() {Dispose(false);}

        internal unsafe Const_Mat44(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Mat44() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_DefaultConstruct();
            _UnderlyingPtr = __JPH_Mat44_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Mat44::Mat44`.
        public unsafe Const_Mat44(JPH.Const_Mat44 inM2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_ConstructFromAnother(JPH.Mat44._Underlying *inM2);
            _UnderlyingPtr = __JPH_Mat44_ConstructFromAnother(inM2._UnderlyingPtr);
            _KeepAlive(inM2);
        }

        /// Generated from constructor `JPH::Mat44::Mat44`.
        public Const_Mat44(Mat44 inM2) : this((Const_Mat44)inM2) {}

        /// Generated from constructor `JPH::Mat44::Mat44`.
        public unsafe Const_Mat44(JPH.Const_Vec4 inC1, JPH.Const_Vec4 inC2, JPH.Const_Vec4 inC3, JPH.Const_Vec4 inC4) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec4(JPH.Vec4._Underlying *inC1, JPH.Vec4._Underlying *inC2, JPH.Vec4._Underlying *inC3, JPH.Vec4._Underlying *inC4);
            _UnderlyingPtr = __JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec4(inC1._UnderlyingPtr, inC2._UnderlyingPtr, inC3._UnderlyingPtr, inC4._UnderlyingPtr);
        }

        /// Generated from constructor `JPH::Mat44::Mat44`.
        public unsafe Const_Mat44(JPH.Const_Vec4 inC1, JPH.Const_Vec4 inC2, JPH.Const_Vec4 inC3, JPH.Const_Vec3 inC4) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec3(JPH.Vec4._Underlying *inC1, JPH.Vec4._Underlying *inC2, JPH.Vec4._Underlying *inC3, JPH.Vec3._Underlying *inC4);
            _UnderlyingPtr = __JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec3(inC1._UnderlyingPtr, inC2._UnderlyingPtr, inC3._UnderlyingPtr, inC4._UnderlyingPtr);
        }

        /// Generated from method `JPH::Mat44::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Mat44_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Mat44_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Mat44_size_t(ulong inCount);
            return __Jolt_new_JPH_Mat44_size_t(inCount);
        }

        /// Generated from method `JPH::Mat44::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Mat44_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Mat44_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Mat44_void_ptr(void *inPointer);
            __Jolt_delete_JPH_Mat44_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Mat44::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Mat44_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Mat44_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Mat44_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_JPH_Mat44_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Mat44::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Mat44_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Mat44_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Mat44_size_t(ulong inCount);
            return __Jolt_new_array_JPH_Mat44_size_t(inCount);
        }

        /// Generated from method `JPH::Mat44::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Mat44_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Mat44_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Mat44_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_Mat44_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Mat44::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Mat44_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Mat44_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Mat44_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_array_JPH_Mat44_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Mat44::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Mat44_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Mat44_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Mat44_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_JPH_Mat44_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Mat44::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Mat44_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Mat44_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Mat44_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_Mat44_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::Mat44::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Mat44_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Mat44_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Mat44_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_array_JPH_Mat44_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Mat44::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Mat44_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Mat44_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Mat44_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_Mat44_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Zero matrix
        /// Generated from method `JPH::Mat44::sZero`.
        public static unsafe JPH.Mat44 SZero()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sZero();
            return new(__JPH_Mat44_sZero(), is_owning: true);
        }

        /// Identity matrix
        /// Generated from method `JPH::Mat44::sIdentity`.
        public static unsafe JPH.Mat44 SIdentity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sIdentity();
            return new(__JPH_Mat44_sIdentity(), is_owning: true);
        }

        /// Matrix filled with NaN's
        /// Generated from method `JPH::Mat44::sNaN`.
        public static unsafe JPH.Mat44 SNaN()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sNaN();
            return new(__JPH_Mat44_sNaN(), is_owning: true);
        }

        /// Load 16 floats from memory
        /// Generated from method `JPH::Mat44::sLoadFloat4x4`.
        public static unsafe JPH.Mat44 SLoadFloat4x4(JPH.Const_Float4? inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sLoadFloat4x4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sLoadFloat4x4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sLoadFloat4x4(JPH.Const_Float4._Underlying *inV);
            return new(__JPH_Mat44_sLoadFloat4x4(inV is not null ? inV._UnderlyingPtr : null), is_owning: true);
        }

        /// Load 16 floats from memory, 16 bytes aligned
        /// Generated from method `JPH::Mat44::sLoadFloat4x4Aligned`.
        public static unsafe JPH.Mat44 SLoadFloat4x4Aligned(JPH.Const_Float4? inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sLoadFloat4x4Aligned", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sLoadFloat4x4Aligned", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sLoadFloat4x4Aligned(JPH.Const_Float4._Underlying *inV);
            return new(__JPH_Mat44_sLoadFloat4x4Aligned(inV is not null ? inV._UnderlyingPtr : null), is_owning: true);
        }

        /// Rotate around X, Y or Z axis (angle in radians)
        /// Generated from method `JPH::Mat44::sRotationX`.
        public static unsafe JPH.Mat44 SRotationX(float inX)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sRotationX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sRotationX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sRotationX(float inX);
            return new(__JPH_Mat44_sRotationX(inX), is_owning: true);
        }

        /// Generated from method `JPH::Mat44::sRotationY`.
        public static unsafe JPH.Mat44 SRotationY(float inY)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sRotationY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sRotationY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sRotationY(float inY);
            return new(__JPH_Mat44_sRotationY(inY), is_owning: true);
        }

        /// Generated from method `JPH::Mat44::sRotationZ`.
        public static unsafe JPH.Mat44 SRotationZ(float inZ)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sRotationZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sRotationZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sRotationZ(float inZ);
            return new(__JPH_Mat44_sRotationZ(inZ), is_owning: true);
        }

        /// Rotate around arbitrary axis
        /// Generated from method `JPH::Mat44::sRotation`.
        public static unsafe JPH.Mat44 SRotation(JPH.Const_Vec3 inAxis, float inAngle)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sRotation_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sRotation_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sRotation_2(JPH.Vec3._Underlying *inAxis, float inAngle);
            return new(__JPH_Mat44_sRotation_2(inAxis._UnderlyingPtr, inAngle), is_owning: true);
        }

        /// Rotate from quaternion
        /// Generated from method `JPH::Mat44::sRotation`.
        public static unsafe JPH.Mat44 SRotation(JPH.Const_Quat inQuat)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sRotation_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sRotation_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sRotation_1(JPH.Quat._Underlying *inQuat);
            return new(__JPH_Mat44_sRotation_1(inQuat._UnderlyingPtr), is_owning: true);
        }

        /// Get matrix that translates
        /// Generated from method `JPH::Mat44::sTranslation`.
        public static unsafe JPH.Mat44 STranslation(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sTranslation(JPH.Vec3._Underlying *inV);
            return new(__JPH_Mat44_sTranslation(inV._UnderlyingPtr), is_owning: true);
        }

        /// Get matrix that rotates and translates
        /// Generated from method `JPH::Mat44::sRotationTranslation`.
        public static unsafe JPH.Mat44 SRotationTranslation(JPH.Const_Quat inR, JPH.Const_Vec3 inT)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sRotationTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sRotationTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sRotationTranslation(JPH.Quat._Underlying *inR, JPH.Vec3._Underlying *inT);
            return new(__JPH_Mat44_sRotationTranslation(inR._UnderlyingPtr, inT._UnderlyingPtr), is_owning: true);
        }

        /// Get inverse matrix of sRotationTranslation
        /// Generated from method `JPH::Mat44::sInverseRotationTranslation`.
        public static unsafe JPH.Mat44 SInverseRotationTranslation(JPH.Const_Quat inR, JPH.Const_Vec3 inT)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sInverseRotationTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sInverseRotationTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sInverseRotationTranslation(JPH.Quat._Underlying *inR, JPH.Vec3._Underlying *inT);
            return new(__JPH_Mat44_sInverseRotationTranslation(inR._UnderlyingPtr, inT._UnderlyingPtr), is_owning: true);
        }

        /// Get matrix that scales uniformly
        /// Generated from method `JPH::Mat44::sScale`.
        public static unsafe JPH.Mat44 SScale(float inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sScale_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sScale_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sScale_float(float inScale);
            return new(__JPH_Mat44_sScale_float(inScale), is_owning: true);
        }

        /// Get matrix that scales (produces a matrix with (inV, 1) on its diagonal)
        /// Generated from method `JPH::Mat44::sScale`.
        public static unsafe JPH.Mat44 SScale(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sScale_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sScale_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sScale_JPH_Vec3(JPH.Vec3._Underlying *inV);
            return new(__JPH_Mat44_sScale_JPH_Vec3(inV._UnderlyingPtr), is_owning: true);
        }

        /// Get outer product of inV and inV2 (equivalent to \f$inV1 \otimes inV2\f$)
        /// Generated from method `JPH::Mat44::sOuterProduct`.
        public static unsafe JPH.Mat44 SOuterProduct(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sOuterProduct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sOuterProduct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sOuterProduct(JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2);
            return new(__JPH_Mat44_sOuterProduct(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
        }

        /// Get matrix that represents a cross product \f$A \times B = \text{sCrossProduct}(A) \: B\f$
        /// Generated from method `JPH::Mat44::sCrossProduct`.
        public static unsafe JPH.Mat44 SCrossProduct(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sCrossProduct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sCrossProduct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sCrossProduct(JPH.Vec3._Underlying *inV);
            return new(__JPH_Mat44_sCrossProduct(inV._UnderlyingPtr), is_owning: true);
        }

        /// Returns matrix ML so that \f$ML(q) \: p = q \: p\f$ (where p and q are quaternions)
        /// Generated from method `JPH::Mat44::sQuatLeftMultiply`.
        public static unsafe JPH.Mat44 SQuatLeftMultiply(JPH.Const_Quat inQ)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sQuatLeftMultiply", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sQuatLeftMultiply", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sQuatLeftMultiply(JPH.Quat._Underlying *inQ);
            return new(__JPH_Mat44_sQuatLeftMultiply(inQ._UnderlyingPtr), is_owning: true);
        }

        /// Returns matrix MR so that \f$MR(q) \: p = p \: q\f$ (where p and q are quaternions)
        /// Generated from method `JPH::Mat44::sQuatRightMultiply`.
        public static unsafe JPH.Mat44 SQuatRightMultiply(JPH.Const_Quat inQ)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sQuatRightMultiply", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sQuatRightMultiply", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sQuatRightMultiply(JPH.Quat._Underlying *inQ);
            return new(__JPH_Mat44_sQuatRightMultiply(inQ._UnderlyingPtr), is_owning: true);
        }

        /// Returns a look at matrix that transforms from world space to view space
        /// @param inPos Position of the camera
        /// @param inTarget Target of the camera
        /// @param inUp Up vector
        /// Generated from method `JPH::Mat44::sLookAt`.
        public static unsafe JPH.Mat44 SLookAt(JPH.Const_Vec3 inPos, JPH.Const_Vec3 inTarget, JPH.Const_Vec3 inUp)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sLookAt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sLookAt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sLookAt(JPH.Vec3._Underlying *inPos, JPH.Vec3._Underlying *inTarget, JPH.Vec3._Underlying *inUp);
            return new(__JPH_Mat44_sLookAt(inPos._UnderlyingPtr, inTarget._UnderlyingPtr, inUp._UnderlyingPtr), is_owning: true);
        }

        /// Returns a right-handed perspective projection matrix
        /// Generated from method `JPH::Mat44::sPerspective`.
        public static unsafe JPH.Mat44 SPerspective(float inFovY, float inAspect, float inNear, float inFar)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_sPerspective", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_sPerspective", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_sPerspective(float inFovY, float inAspect, float inNear, float inFar);
            return new(__JPH_Mat44_sPerspective(inFovY, inAspect, inNear, inFar), is_owning: true);
        }

        /// Get float component by element index
        /// Generated from method `JPH::Mat44::operator()`.
        public unsafe float Call(uint inRow, uint inColumn)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Mat44_call(_Underlying *_this, uint inRow, uint inColumn);
            return __JPH_Mat44_call(_UnderlyingPtr, inRow, inColumn);
        }

        /// Comparison
        /// Generated from method `JPH::Mat44::operator==`.
        public static unsafe bool operator==(JPH.Const_Mat44 _this, JPH.Const_Mat44 inM2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_equal_JPH_Mat44(JPH.Const_Mat44._Underlying *_this, JPH.Const_Mat44._Underlying *inM2);
            return __Jolt_equal_JPH_Mat44(_this._UnderlyingPtr, inM2._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(JPH.Const_Mat44 _this, JPH.Const_Mat44 inM2)
        {
            return !(_this == inM2);
        }

        /// Test if two matrices are close
        /// Generated from method `JPH::Mat44::IsClose`.
        /// Parameter `inMaxDistSq` defaults to `9.99999996e-13f`.
        public unsafe bool IsClose(JPH.Const_Mat44 inM2, float? inMaxDistSq = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_IsClose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_IsClose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Mat44_IsClose(_Underlying *_this, JPH.Const_Mat44._Underlying *inM2, float *inMaxDistSq);
            float __deref_inMaxDistSq = inMaxDistSq.GetValueOrDefault();
            return __JPH_Mat44_IsClose(_UnderlyingPtr, inM2._UnderlyingPtr, inMaxDistSq.HasValue ? &__deref_inMaxDistSq : null) != 0;
        }

        /// Multiply matrix by matrix
        /// Generated from method `JPH::Mat44::operator*`.
        public static unsafe JPH.Mat44 operator*(JPH.Const_Mat44 _this, JPH.Const_Mat44 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__Jolt_mul_JPH_Mat44(JPH.Const_Mat44._Underlying *_this, JPH.Const_Mat44._Underlying *inM);
            return new(__Jolt_mul_JPH_Mat44(_this._UnderlyingPtr, inM._UnderlyingPtr), is_owning: true);
        }

        /// Multiply vector by matrix
        /// Generated from method `JPH::Mat44::operator*`.
        public static unsafe JPH.Vec3 operator*(JPH.Const_Mat44 _this, JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Mat44_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Mat44_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__Jolt_mul_JPH_Mat44_JPH_Vec3(JPH.Const_Mat44._Underlying *_this, JPH.Vec3._Underlying *inV);
            return new(__Jolt_mul_JPH_Mat44_JPH_Vec3(_this._UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Mat44::operator*`.
        public static unsafe JPH.Vec4 operator*(JPH.Const_Mat44 _this, JPH.Const_Vec4 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Mat44_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Mat44_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec4._Underlying *__Jolt_mul_JPH_Mat44_JPH_Vec4(JPH.Const_Mat44._Underlying *_this, JPH.Vec4._Underlying *inV);
            return new(__Jolt_mul_JPH_Mat44_JPH_Vec4(_this._UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Multiply vector by only 3x3 part of the matrix
        /// Generated from method `JPH::Mat44::Multiply3x3`.
        public unsafe JPH.Vec3 Multiply3x3(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Multiply3x3_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Multiply3x3_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Mat44_Multiply3x3_JPH_Vec3(_Underlying *_this, JPH.Vec3._Underlying *inV);
            return new(__JPH_Mat44_Multiply3x3_JPH_Vec3(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Multiply vector by only 3x3 part of the transpose of the matrix (\f$result = this^T \: inV\f$)
        /// Generated from method `JPH::Mat44::Multiply3x3Transposed`.
        public unsafe JPH.Vec3 Multiply3x3Transposed(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Multiply3x3Transposed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Multiply3x3Transposed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Mat44_Multiply3x3Transposed(_Underlying *_this, JPH.Vec3._Underlying *inV);
            return new(__JPH_Mat44_Multiply3x3Transposed(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Multiply 3x3 matrix by 3x3 matrix
        /// Generated from method `JPH::Mat44::Multiply3x3`.
        public unsafe JPH.Mat44 Multiply3x3(JPH.Const_Mat44 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Multiply3x3_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Multiply3x3_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_Multiply3x3_JPH_Mat44(_Underlying *_this, JPH.Const_Mat44._Underlying *inM);
            return new(__JPH_Mat44_Multiply3x3_JPH_Mat44(_UnderlyingPtr, inM._UnderlyingPtr), is_owning: true);
        }

        /// Multiply transpose of 3x3 matrix by 3x3 matrix (\f$result = this^T \: inM\f$)
        /// Generated from method `JPH::Mat44::Multiply3x3LeftTransposed`.
        public unsafe JPH.Mat44 Multiply3x3LeftTransposed(JPH.Const_Mat44 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Multiply3x3LeftTransposed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Multiply3x3LeftTransposed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_Multiply3x3LeftTransposed(_Underlying *_this, JPH.Const_Mat44._Underlying *inM);
            return new(__JPH_Mat44_Multiply3x3LeftTransposed(_UnderlyingPtr, inM._UnderlyingPtr), is_owning: true);
        }

        /// Multiply 3x3 matrix by the transpose of a 3x3 matrix (\f$result = this \: inM^T\f$)
        /// Generated from method `JPH::Mat44::Multiply3x3RightTransposed`.
        public unsafe JPH.Mat44 Multiply3x3RightTransposed(JPH.Const_Mat44 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Multiply3x3RightTransposed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Multiply3x3RightTransposed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_Multiply3x3RightTransposed(_Underlying *_this, JPH.Const_Mat44._Underlying *inM);
            return new(__JPH_Mat44_Multiply3x3RightTransposed(_UnderlyingPtr, inM._UnderlyingPtr), is_owning: true);
        }

        /// Multiply matrix with float
        /// Generated from method `JPH::Mat44::operator*`.
        public static unsafe JPH.Mat44 operator*(JPH.Const_Mat44 _this, float inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Mat44_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Mat44_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__Jolt_mul_JPH_Mat44_float(JPH.Const_Mat44._Underlying *_this, float inV);
            return new(__Jolt_mul_JPH_Mat44_float(_this._UnderlyingPtr, inV), is_owning: true);
        }

        /// Per element addition of matrix
        /// Generated from method `JPH::Mat44::operator+`.
        public static unsafe JPH.Mat44 operator+(JPH.Const_Mat44 _this, JPH.Const_Mat44 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_add_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_add_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__Jolt_add_JPH_Mat44(JPH.Const_Mat44._Underlying *_this, JPH.Const_Mat44._Underlying *inM);
            return new(__Jolt_add_JPH_Mat44(_this._UnderlyingPtr, inM._UnderlyingPtr), is_owning: true);
        }

        /// Negate
        /// Generated from method `JPH::Mat44::operator-`.
        public static unsafe JPH.Mat44 operator-(JPH.Const_Mat44 _this)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_neg_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_neg_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__Jolt_neg_JPH_Mat44(JPH.Const_Mat44._Underlying *_this);
            return new(__Jolt_neg_JPH_Mat44(_this._UnderlyingPtr), is_owning: true);
        }

        /// Per element subtraction of matrix
        /// Generated from method `JPH::Mat44::operator-`.
        public static unsafe JPH.Mat44 operator-(JPH.Const_Mat44 _this, JPH.Const_Mat44 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_sub_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_sub_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__Jolt_sub_JPH_Mat44(JPH.Const_Mat44._Underlying *_this, JPH.Const_Mat44._Underlying *inM);
            return new(__Jolt_sub_JPH_Mat44(_this._UnderlyingPtr, inM._UnderlyingPtr), is_owning: true);
        }

        /// Access to the columns
        /// Generated from method `JPH::Mat44::GetAxisX`.
        public unsafe JPH.Vec3 GetAxisX()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_GetAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_GetAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Mat44_GetAxisX(_Underlying *_this);
            return new(__JPH_Mat44_GetAxisX(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Mat44::GetAxisY`.
        public unsafe JPH.Vec3 GetAxisY()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_GetAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_GetAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Mat44_GetAxisY(_Underlying *_this);
            return new(__JPH_Mat44_GetAxisY(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Mat44::GetAxisZ`.
        public unsafe JPH.Vec3 GetAxisZ()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_GetAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_GetAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Mat44_GetAxisZ(_Underlying *_this);
            return new(__JPH_Mat44_GetAxisZ(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Mat44::GetTranslation`.
        public unsafe JPH.Vec3 GetTranslation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_GetTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_GetTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Mat44_GetTranslation(_Underlying *_this);
            return new(__JPH_Mat44_GetTranslation(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Mat44::GetDiagonal3`.
        public unsafe JPH.Vec3 GetDiagonal3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_GetDiagonal3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_GetDiagonal3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Mat44_GetDiagonal3(_Underlying *_this);
            return new(__JPH_Mat44_GetDiagonal3(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Mat44::GetDiagonal4`.
        public unsafe JPH.Vec4 GetDiagonal4()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_GetDiagonal4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_GetDiagonal4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec4._Underlying *__JPH_Mat44_GetDiagonal4(_Underlying *_this);
            return new(__JPH_Mat44_GetDiagonal4(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Mat44::GetColumn3`.
        public unsafe JPH.Vec3 GetColumn3(uint inCol)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_GetColumn3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_GetColumn3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Mat44_GetColumn3(_Underlying *_this, uint inCol);
            return new(__JPH_Mat44_GetColumn3(_UnderlyingPtr, inCol), is_owning: true);
        }

        /// Generated from method `JPH::Mat44::GetColumn4`.
        public unsafe JPH.Vec4 GetColumn4(uint inCol)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_GetColumn4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_GetColumn4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec4._Underlying *__JPH_Mat44_GetColumn4(_Underlying *_this, uint inCol);
            return new(__JPH_Mat44_GetColumn4(_UnderlyingPtr, inCol), is_owning: true);
        }

        /// Store matrix to memory
        /// Generated from method `JPH::Mat44::StoreFloat4x4`.
        public unsafe void StoreFloat4x4(JPH.Float4? outV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_StoreFloat4x4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_StoreFloat4x4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Mat44_StoreFloat4x4(_Underlying *_this, JPH.Float4._Underlying *outV);
            __JPH_Mat44_StoreFloat4x4(_UnderlyingPtr, outV is not null ? outV._UnderlyingPtr : null);
        }

        /// Transpose matrix
        /// Generated from method `JPH::Mat44::Transposed`.
        public unsafe JPH.Mat44 Transposed()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Transposed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Transposed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_Transposed(_Underlying *_this);
            return new(__JPH_Mat44_Transposed(_UnderlyingPtr), is_owning: true);
        }

        /// Transpose 3x3 subpart of matrix
        /// Generated from method `JPH::Mat44::Transposed3x3`.
        public unsafe JPH.Mat44 Transposed3x3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Transposed3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Transposed3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_Transposed3x3(_Underlying *_this);
            return new(__JPH_Mat44_Transposed3x3(_UnderlyingPtr), is_owning: true);
        }

        /// Inverse 4x4 matrix
        /// Generated from method `JPH::Mat44::Inversed`.
        public unsafe JPH.Mat44 Inversed()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Inversed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Inversed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_Inversed(_Underlying *_this);
            return new(__JPH_Mat44_Inversed(_UnderlyingPtr), is_owning: true);
        }

        /// Inverse 4x4 matrix when it only contains rotation and translation
        /// Generated from method `JPH::Mat44::InversedRotationTranslation`.
        public unsafe JPH.Mat44 InversedRotationTranslation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_InversedRotationTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_InversedRotationTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_InversedRotationTranslation(_Underlying *_this);
            return new(__JPH_Mat44_InversedRotationTranslation(_UnderlyingPtr), is_owning: true);
        }

        /// Get the determinant of a 3x3 matrix
        /// Generated from method `JPH::Mat44::GetDeterminant3x3`.
        public unsafe float GetDeterminant3x3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_GetDeterminant3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_GetDeterminant3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Mat44_GetDeterminant3x3(_Underlying *_this);
            return __JPH_Mat44_GetDeterminant3x3(_UnderlyingPtr);
        }

        /// Get the adjoint of a 3x3 matrix
        /// Generated from method `JPH::Mat44::Adjointed3x3`.
        public unsafe JPH.Mat44 Adjointed3x3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Adjointed3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Adjointed3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_Adjointed3x3(_Underlying *_this);
            return new(__JPH_Mat44_Adjointed3x3(_UnderlyingPtr), is_owning: true);
        }

        /// Inverse 3x3 matrix
        /// Generated from method `JPH::Mat44::Inversed3x3`.
        public unsafe JPH.Mat44 Inversed3x3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Inversed3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Inversed3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_Inversed3x3(_Underlying *_this);
            return new(__JPH_Mat44_Inversed3x3(_UnderlyingPtr), is_owning: true);
        }

        /// Get rotation part only (note: retains the first 3 values from the bottom row)
        /// Generated from method `JPH::Mat44::GetRotation`.
        public unsafe JPH.Mat44 GetRotation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_GetRotation(_Underlying *_this);
            return new(__JPH_Mat44_GetRotation(_UnderlyingPtr), is_owning: true);
        }

        /// Get rotation part only (note: also clears the bottom row)
        /// Generated from method `JPH::Mat44::GetRotationSafe`.
        public unsafe JPH.Mat44 GetRotationSafe()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_GetRotationSafe", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_GetRotationSafe", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_GetRotationSafe(_Underlying *_this);
            return new(__JPH_Mat44_GetRotationSafe(_UnderlyingPtr), is_owning: true);
        }

        /// Convert to quaternion
        /// Generated from method `JPH::Mat44::GetQuaternion`.
        public unsafe JPH.Quat GetQuaternion()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_GetQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_GetQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Mat44_GetQuaternion(_Underlying *_this);
            return new(__JPH_Mat44_GetQuaternion(_UnderlyingPtr), is_owning: true);
        }

        /// Get matrix that transforms a direction with the same transform as this matrix (length is not preserved)
        /// Generated from method `JPH::Mat44::GetDirectionPreservingMatrix`.
        public unsafe JPH.Mat44 GetDirectionPreservingMatrix()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_GetDirectionPreservingMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_GetDirectionPreservingMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_GetDirectionPreservingMatrix(_Underlying *_this);
            return new(__JPH_Mat44_GetDirectionPreservingMatrix(_UnderlyingPtr), is_owning: true);
        }

        /// Pre multiply by translation matrix: result = this * Mat44::sTranslation(inTranslation)
        /// Generated from method `JPH::Mat44::PreTranslated`.
        public unsafe JPH.Mat44 PreTranslated(JPH.Const_Vec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_PreTranslated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_PreTranslated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_PreTranslated(_Underlying *_this, JPH.Vec3._Underlying *inTranslation);
            return new(__JPH_Mat44_PreTranslated(_UnderlyingPtr, inTranslation._UnderlyingPtr), is_owning: true);
        }

        /// Post multiply by translation matrix: result = Mat44::sTranslation(inTranslation) * this (i.e. add inTranslation to the 4-th column)
        /// Generated from method `JPH::Mat44::PostTranslated`.
        public unsafe JPH.Mat44 PostTranslated(JPH.Const_Vec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_PostTranslated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_PostTranslated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_PostTranslated(_Underlying *_this, JPH.Vec3._Underlying *inTranslation);
            return new(__JPH_Mat44_PostTranslated(_UnderlyingPtr, inTranslation._UnderlyingPtr), is_owning: true);
        }

        /// Scale a matrix: result = this * Mat44::sScale(inScale)
        /// Generated from method `JPH::Mat44::PreScaled`.
        public unsafe JPH.Mat44 PreScaled(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_PreScaled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_PreScaled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_PreScaled(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return new(__JPH_Mat44_PreScaled(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// Scale a matrix: result = Mat44::sScale(inScale) * this
        /// Generated from method `JPH::Mat44::PostScaled`.
        public unsafe JPH.Mat44 PostScaled(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_PostScaled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_PostScaled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_PostScaled(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return new(__JPH_Mat44_PostScaled(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// Decompose a matrix into a rotation & translation part and into a scale part so that:
        /// this = return_value * Mat44::sScale(outScale).
        /// This equation only holds when the matrix is orthogonal, if it is not the returned matrix
        /// will be made orthogonal using the modified Gram-Schmidt algorithm (see: https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process)
        /// Generated from method `JPH::Mat44::Decompose`.
        public unsafe JPH.Mat44 Decompose(JPH.Vec3 outScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Decompose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Decompose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_Decompose(_Underlying *_this, JPH.Vec3._Underlying *outScale);
            return new(__JPH_Mat44_Decompose(_UnderlyingPtr, outScale._UnderlyingPtr), is_owning: true);
        }

        /// In single precision mode just return the matrix itself
        /// Generated from method `JPH::Mat44::ToMat44`.
        public unsafe JPH.Mat44 ToMat44()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_ToMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_ToMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_ToMat44(_Underlying *_this);
            return new(__JPH_Mat44_ToMat44(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from function `JPH::operator*`.
        public static unsafe JPH.Mat44 operator*(float inV, JPH.Const_Mat44 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_float_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_float_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__Jolt_mul_float_JPH_Mat44(float inV, JPH.Const_Mat44._Underlying *inM);
            return new(__Jolt_mul_float_JPH_Mat44(inV, inM._UnderlyingPtr), is_owning: true);
        }

        // IEquatable:

        public bool Equals(JPH.Const_Mat44? inM2)
        {
            if (inM2 is null)
                return false;
            return this == inM2;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is JPH.Const_Mat44)
                return this == (JPH.Const_Mat44)other;
            return false;
        }
    }

    /// Holds a 4x4 matrix of floats, but supports also operations on the 3x3 upper left part of the matrix.
    /// Generated from class `JPH::Mat44`.
    /// This is the non-const half of the class.
    public class Mat44 : Const_Mat44
    {
        internal unsafe Mat44(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Mat44() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_DefaultConstruct();
            _UnderlyingPtr = __JPH_Mat44_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Mat44::Mat44`.
        public unsafe Mat44(JPH.Const_Mat44 inM2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_ConstructFromAnother(JPH.Mat44._Underlying *inM2);
            _UnderlyingPtr = __JPH_Mat44_ConstructFromAnother(inM2._UnderlyingPtr);
            _KeepAlive(inM2);
        }

        /// Generated from constructor `JPH::Mat44::Mat44`.
        public Mat44(Mat44 inM2) : this((Const_Mat44)inM2) {}

        /// Generated from constructor `JPH::Mat44::Mat44`.
        public unsafe Mat44(JPH.Const_Vec4 inC1, JPH.Const_Vec4 inC2, JPH.Const_Vec4 inC3, JPH.Const_Vec4 inC4) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec4(JPH.Vec4._Underlying *inC1, JPH.Vec4._Underlying *inC2, JPH.Vec4._Underlying *inC3, JPH.Vec4._Underlying *inC4);
            _UnderlyingPtr = __JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec4(inC1._UnderlyingPtr, inC2._UnderlyingPtr, inC3._UnderlyingPtr, inC4._UnderlyingPtr);
        }

        /// Generated from constructor `JPH::Mat44::Mat44`.
        public unsafe Mat44(JPH.Const_Vec4 inC1, JPH.Const_Vec4 inC2, JPH.Const_Vec4 inC3, JPH.Const_Vec3 inC4) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec3(JPH.Vec4._Underlying *inC1, JPH.Vec4._Underlying *inC2, JPH.Vec4._Underlying *inC3, JPH.Vec3._Underlying *inC4);
            _UnderlyingPtr = __JPH_Mat44_Construct_const_JPH_Vec4_JPH_Vec3(inC1._UnderlyingPtr, inC2._UnderlyingPtr, inC3._UnderlyingPtr, inC4._UnderlyingPtr);
        }

        /// Generated from method `JPH::Mat44::operator=`.
        public unsafe JPH.Mat44 Assign(JPH.Const_Mat44 inM2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_AssignFromAnother(_Underlying *_this, JPH.Mat44._Underlying *inM2);
            JPH.Mat44 __ret;
            __ret = new(__JPH_Mat44_AssignFromAnother(_UnderlyingPtr, inM2._UnderlyingPtr), is_owning: false);
            _DiscardKeepAlive();
            _KeepAlive(inM2);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Generated from method `JPH::Mat44::operator()`.
        public unsafe new ref float Call(uint inRow, uint inColumn)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_call_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_call_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float *__JPH_Mat44_call_mut(_Underlying *_this, uint inRow, uint inColumn);
            return ref *__JPH_Mat44_call_mut(_UnderlyingPtr, inRow, inColumn);
        }

        /// Multiply matrix with float
        /// Generated from method `JPH::Mat44::operator*=`.
        public unsafe JPH.Mat44 MulAssign(float inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_mul_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_mul_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_mul_assign(_Underlying *_this, float inV);
            JPH.Mat44 __ret;
            __ret = new(__JPH_Mat44_mul_assign(_UnderlyingPtr, inV), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Per element addition of matrix
        /// Generated from method `JPH::Mat44::operator+=`.
        public unsafe JPH.Mat44 AddAssign(JPH.Const_Mat44 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Mat44_add_assign(_Underlying *_this, JPH.Const_Mat44._Underlying *inM);
            JPH.Mat44 __ret;
            __ret = new(__JPH_Mat44_add_assign(_UnderlyingPtr, inM._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Generated from method `JPH::Mat44::SetAxisX`.
        public unsafe void SetAxisX(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_SetAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_SetAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Mat44_SetAxisX(_Underlying *_this, JPH.Vec3._Underlying *inV);
            __JPH_Mat44_SetAxisX(_UnderlyingPtr, inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::Mat44::SetAxisY`.
        public unsafe void SetAxisY(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_SetAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_SetAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Mat44_SetAxisY(_Underlying *_this, JPH.Vec3._Underlying *inV);
            __JPH_Mat44_SetAxisY(_UnderlyingPtr, inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::Mat44::SetAxisZ`.
        public unsafe void SetAxisZ(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_SetAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_SetAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Mat44_SetAxisZ(_Underlying *_this, JPH.Vec3._Underlying *inV);
            __JPH_Mat44_SetAxisZ(_UnderlyingPtr, inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::Mat44::SetTranslation`.
        public unsafe void SetTranslation(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_SetTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_SetTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Mat44_SetTranslation(_Underlying *_this, JPH.Vec3._Underlying *inV);
            __JPH_Mat44_SetTranslation(_UnderlyingPtr, inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::Mat44::SetDiagonal3`.
        public unsafe void SetDiagonal3(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_SetDiagonal3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_SetDiagonal3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Mat44_SetDiagonal3(_Underlying *_this, JPH.Vec3._Underlying *inV);
            __JPH_Mat44_SetDiagonal3(_UnderlyingPtr, inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::Mat44::SetDiagonal4`.
        public unsafe void SetDiagonal4(JPH.Const_Vec4 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_SetDiagonal4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_SetDiagonal4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Mat44_SetDiagonal4(_Underlying *_this, JPH.Vec4._Underlying *inV);
            __JPH_Mat44_SetDiagonal4(_UnderlyingPtr, inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::Mat44::SetColumn3`.
        public unsafe void SetColumn3(uint inCol, JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_SetColumn3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_SetColumn3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Mat44_SetColumn3(_Underlying *_this, uint inCol, JPH.Vec3._Underlying *inV);
            __JPH_Mat44_SetColumn3(_UnderlyingPtr, inCol, inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::Mat44::SetColumn4`.
        public unsafe void SetColumn4(uint inCol, JPH.Const_Vec4 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_SetColumn4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_SetColumn4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Mat44_SetColumn4(_Underlying *_this, uint inCol, JPH.Vec4._Underlying *inV);
            __JPH_Mat44_SetColumn4(_UnderlyingPtr, inCol, inV._UnderlyingPtr);
        }

        /// *this = inM.Inversed3x3(), returns false if the matrix is singular in which case *this is unchanged
        /// Generated from method `JPH::Mat44::SetInversed3x3`.
        public unsafe bool SetInversed3x3(JPH.Const_Mat44 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_SetInversed3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_SetInversed3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Mat44_SetInversed3x3(_Underlying *_this, JPH.Const_Mat44._Underlying *inM);
            return __JPH_Mat44_SetInversed3x3(_UnderlyingPtr, inM._UnderlyingPtr) != 0;
        }

        /// Updates the rotation part of this matrix (the first 3 columns)
        /// Generated from method `JPH::Mat44::SetRotation`.
        public unsafe void SetRotation(JPH.Const_Mat44 inRotation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Mat44_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Mat44_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Mat44_SetRotation(_Underlying *_this, JPH.Const_Mat44._Underlying *inRotation);
            __JPH_Mat44_SetRotation(_UnderlyingPtr, inRotation._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `Mat44` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Mat44`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Mat44`/`Const_Mat44` directly.
    public class _InOptMut_Mat44
    {
        public Mat44? Opt;

        public _InOptMut_Mat44() {}
        public _InOptMut_Mat44(Mat44 value) {Opt = value;}
        public static implicit operator _InOptMut_Mat44(Mat44 value) {return new(value);}
    }

    /// This is used for optional parameters of class `Mat44` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Mat44`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Mat44`/`Const_Mat44` to pass it to the function.
    public class _InOptConst_Mat44
    {
        public Const_Mat44? Opt;

        public _InOptConst_Mat44() {}
        public _InOptConst_Mat44(Const_Mat44 value) {Opt = value;}
        public static implicit operator _InOptConst_Mat44(Const_Mat44 value) {return new(value);}
    }
}
