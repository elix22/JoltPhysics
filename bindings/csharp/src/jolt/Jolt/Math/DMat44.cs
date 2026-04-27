// machine generated, do not edit
public static partial class JPH
{
    /// Holds a 4x4 matrix of floats with the last column consisting of doubles
    /// Generated from class `JPH::DMat44`.
    /// This is the const half of the class.
    public class Const_DMat44 : JPH.Object<Const_DMat44>, System.IDisposable, System.IEquatable<JPH.Const_DMat44>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DMat44_Destroy(_Underlying *_this);
            __JPH_DMat44_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_DMat44() {Dispose(false);}

        internal unsafe Const_DMat44(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_DMat44() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_DefaultConstruct();
            _UnderlyingPtr = __JPH_DMat44_DefaultConstruct();
        }

        /// Generated from constructor `JPH::DMat44::DMat44`.
        public unsafe Const_DMat44(JPH.Const_DMat44 inM2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_ConstructFromAnother(JPH.DMat44._Underlying *inM2);
            _UnderlyingPtr = __JPH_DMat44_ConstructFromAnother(inM2._UnderlyingPtr);
            _KeepAlive(inM2);
        }

        /// Generated from constructor `JPH::DMat44::DMat44`.
        public Const_DMat44(DMat44 inM2) : this((Const_DMat44)inM2) {}

        /// Generated from constructor `JPH::DMat44::DMat44`.
        public unsafe Const_DMat44(JPH.Const_Vec4 inC1, JPH.Const_Vec4 inC2, JPH.Const_Vec4 inC3, JPH.Const_DVec3 inC4) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_Construct_4_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_Construct_4_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_Construct_4_JPH_Vec4(JPH.Vec4._Underlying *inC1, JPH.Vec4._Underlying *inC2, JPH.Vec4._Underlying *inC3, JPH.Const_DVec3._Underlying *inC4);
            _UnderlyingPtr = __JPH_DMat44_Construct_4_JPH_Vec4(inC1._UnderlyingPtr, inC2._UnderlyingPtr, inC3._UnderlyingPtr, inC4._UnderlyingPtr);
        }

        /// Generated from constructor `JPH::DMat44::DMat44`.
        public unsafe Const_DMat44(JPH.Const_Mat44 inM) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_Construct_1(JPH.Const_Mat44._Underlying *inM);
            _UnderlyingPtr = __JPH_DMat44_Construct_1(inM._UnderlyingPtr);
        }

        /// Generated from constructor `JPH::DMat44::DMat44`.
        public unsafe Const_DMat44(JPH.Const_Mat44 inRot, JPH.Const_DVec3 inT) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_Construct_2(JPH.Const_Mat44._Underlying *inRot, JPH.Const_DVec3._Underlying *inT);
            _UnderlyingPtr = __JPH_DMat44_Construct_2(inRot._UnderlyingPtr, inT._UnderlyingPtr);
        }

        /// Generated from method `JPH::DMat44::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_DMat44_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_DMat44_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_DMat44_size_t(ulong inCount);
            return __Jolt_new_JPH_DMat44_size_t(inCount);
        }

        /// Generated from method `JPH::DMat44::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DMat44_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DMat44_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_DMat44_void_ptr(void *inPointer);
            __Jolt_delete_JPH_DMat44_void_ptr(inPointer);
        }

        /// Generated from method `JPH::DMat44::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DMat44_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DMat44_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_DMat44_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_JPH_DMat44_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::DMat44::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_DMat44_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_DMat44_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_DMat44_size_t(ulong inCount);
            return __Jolt_new_array_JPH_DMat44_size_t(inCount);
        }

        /// Generated from method `JPH::DMat44::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DMat44_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DMat44_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_DMat44_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_DMat44_void_ptr(inPointer);
        }

        /// Generated from method `JPH::DMat44::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DMat44_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DMat44_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_DMat44_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_array_JPH_DMat44_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::DMat44::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_DMat44_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_DMat44_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_DMat44_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_JPH_DMat44_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::DMat44::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DMat44_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DMat44_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_DMat44_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_DMat44_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::DMat44::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_DMat44_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_DMat44_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_DMat44_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_array_JPH_DMat44_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::DMat44::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DMat44_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DMat44_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_DMat44_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_DMat44_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Zero matrix
        /// Generated from method `JPH::DMat44::sZero`.
        public static unsafe JPH.DMat44 SZero()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_sZero();
            return new(__JPH_DMat44_sZero(), is_owning: true);
        }

        /// Identity matrix
        /// Generated from method `JPH::DMat44::sIdentity`.
        public static unsafe JPH.DMat44 SIdentity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_sIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_sIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_sIdentity();
            return new(__JPH_DMat44_sIdentity(), is_owning: true);
        }

        /// Rotate from quaternion
        /// Generated from method `JPH::DMat44::sRotation`.
        public static unsafe JPH.DMat44 SRotation(JPH.Const_Quat inQuat)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_sRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_sRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_sRotation(JPH.Quat._Underlying *inQuat);
            return new(__JPH_DMat44_sRotation(inQuat._UnderlyingPtr), is_owning: true);
        }

        /// Get matrix that translates
        /// Generated from method `JPH::DMat44::sTranslation`.
        public static unsafe JPH.DMat44 STranslation(JPH.Const_DVec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_sTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_sTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_sTranslation(JPH.Const_DVec3._Underlying *inV);
            return new(__JPH_DMat44_sTranslation(inV._UnderlyingPtr), is_owning: true);
        }

        /// Get matrix that rotates and translates
        /// Generated from method `JPH::DMat44::sRotationTranslation`.
        public static unsafe JPH.DMat44 SRotationTranslation(JPH.Const_Quat inR, JPH.Const_DVec3 inT)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_sRotationTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_sRotationTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_sRotationTranslation(JPH.Quat._Underlying *inR, JPH.Const_DVec3._Underlying *inT);
            return new(__JPH_DMat44_sRotationTranslation(inR._UnderlyingPtr, inT._UnderlyingPtr), is_owning: true);
        }

        /// Get inverse matrix of sRotationTranslation
        /// Generated from method `JPH::DMat44::sInverseRotationTranslation`.
        public static unsafe JPH.DMat44 SInverseRotationTranslation(JPH.Const_Quat inR, JPH.Const_DVec3 inT)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_sInverseRotationTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_sInverseRotationTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_sInverseRotationTranslation(JPH.Quat._Underlying *inR, JPH.Const_DVec3._Underlying *inT);
            return new(__JPH_DMat44_sInverseRotationTranslation(inR._UnderlyingPtr, inT._UnderlyingPtr), is_owning: true);
        }

        /// Get matrix that scales (produces a matrix with (inV, 1) on its diagonal)
        /// Generated from method `JPH::DMat44::sScale`.
        public static unsafe JPH.DMat44 SScale(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_sScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_sScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_sScale(JPH.Vec3._Underlying *inV);
            return new(__JPH_DMat44_sScale(inV._UnderlyingPtr), is_owning: true);
        }

        /// Convert to Mat44 rounding to nearest
        /// Generated from method `JPH::DMat44::ToMat44`.
        public unsafe JPH.Mat44 ToMat44()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_ToMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_ToMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_DMat44_ToMat44(_Underlying *_this);
            return new(__JPH_DMat44_ToMat44(_UnderlyingPtr), is_owning: true);
        }

        /// Comparison
        /// Generated from method `JPH::DMat44::operator==`.
        public static unsafe bool operator==(JPH.Const_DMat44 _this, JPH.Const_DMat44 inM2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_equal_JPH_DMat44(JPH.Const_DMat44._Underlying *_this, JPH.Const_DMat44._Underlying *inM2);
            return __Jolt_equal_JPH_DMat44(_this._UnderlyingPtr, inM2._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(JPH.Const_DMat44 _this, JPH.Const_DMat44 inM2)
        {
            return !(_this == inM2);
        }

        /// Test if two matrices are close
        /// Generated from method `JPH::DMat44::IsClose`.
        /// Parameter `inMaxDistSq` defaults to `9.99999996e-13f`.
        public unsafe bool IsClose(JPH.Const_DMat44 inM2, float? inMaxDistSq = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_IsClose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_IsClose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_DMat44_IsClose(_Underlying *_this, JPH.Const_DMat44._Underlying *inM2, float *inMaxDistSq);
            float __deref_inMaxDistSq = inMaxDistSq.GetValueOrDefault();
            return __JPH_DMat44_IsClose(_UnderlyingPtr, inM2._UnderlyingPtr, inMaxDistSq.HasValue ? &__deref_inMaxDistSq : null) != 0;
        }

        /// Multiply matrix by matrix
        /// Generated from method `JPH::DMat44::operator*`.
        public static unsafe JPH.DMat44 operator*(JPH.Const_DMat44 _this, JPH.Const_Mat44 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_DMat44_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_DMat44_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__Jolt_mul_JPH_DMat44_JPH_Mat44(JPH.Const_DMat44._Underlying *_this, JPH.Const_Mat44._Underlying *inM);
            return new(__Jolt_mul_JPH_DMat44_JPH_Mat44(_this._UnderlyingPtr, inM._UnderlyingPtr), is_owning: true);
        }

        /// Multiply matrix by matrix
        /// Generated from method `JPH::DMat44::operator*`.
        public static unsafe JPH.DMat44 operator*(JPH.Const_DMat44 _this, JPH.Const_DMat44 inM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__Jolt_mul_JPH_DMat44(JPH.Const_DMat44._Underlying *_this, JPH.Const_DMat44._Underlying *inM);
            return new(__Jolt_mul_JPH_DMat44(_this._UnderlyingPtr, inM._UnderlyingPtr), is_owning: true);
        }

        /// Multiply vector by matrix
        /// Generated from method `JPH::DMat44::operator*`.
        public static unsafe JPH.DVec3 operator*(JPH.Const_DMat44 _this, JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_DMat44_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_DMat44_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DVec3._Underlying *__Jolt_mul_JPH_DMat44_JPH_Vec3(JPH.Const_DMat44._Underlying *_this, JPH.Vec3._Underlying *inV);
            return new(__Jolt_mul_JPH_DMat44_JPH_Vec3(_this._UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Multiply vector by matrix
        /// Generated from method `JPH::DMat44::operator*`.
        public static unsafe JPH.DVec3 operator*(JPH.Const_DMat44 _this, JPH.Const_DVec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_DMat44_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_DMat44_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DVec3._Underlying *__Jolt_mul_JPH_DMat44_JPH_DVec3(JPH.Const_DMat44._Underlying *_this, JPH.Const_DVec3._Underlying *inV);
            return new(__Jolt_mul_JPH_DMat44_JPH_DVec3(_this._UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Multiply vector by only 3x3 part of the matrix
        /// Generated from method `JPH::DMat44::Multiply3x3`.
        public unsafe JPH.Vec3 Multiply3x3(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_Multiply3x3_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_Multiply3x3_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_DMat44_Multiply3x3_JPH_Vec3(_Underlying *_this, JPH.Vec3._Underlying *inV);
            return new(__JPH_DMat44_Multiply3x3_JPH_Vec3(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Multiply vector by only 3x3 part of the matrix
        /// Generated from method `JPH::DMat44::Multiply3x3`.
        public unsafe JPH.DVec3 Multiply3x3(JPH.Const_DVec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_Multiply3x3_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_Multiply3x3_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DVec3._Underlying *__JPH_DMat44_Multiply3x3_JPH_DVec3(_Underlying *_this, JPH.Const_DVec3._Underlying *inV);
            return new(__JPH_DMat44_Multiply3x3_JPH_DVec3(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Multiply vector by only 3x3 part of the transpose of the matrix (\f$result = this^T \: inV\f$)
        /// Generated from method `JPH::DMat44::Multiply3x3Transposed`.
        public unsafe JPH.Vec3 Multiply3x3Transposed(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_Multiply3x3Transposed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_Multiply3x3Transposed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_DMat44_Multiply3x3Transposed(_Underlying *_this, JPH.Vec3._Underlying *inV);
            return new(__JPH_DMat44_Multiply3x3Transposed(_UnderlyingPtr, inV._UnderlyingPtr), is_owning: true);
        }

        /// Scale a matrix: result = this * Mat44::sScale(inScale)
        /// Generated from method `JPH::DMat44::PreScaled`.
        public unsafe JPH.DMat44 PreScaled(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_PreScaled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_PreScaled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_PreScaled(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return new(__JPH_DMat44_PreScaled(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// Scale a matrix: result = Mat44::sScale(inScale) * this
        /// Generated from method `JPH::DMat44::PostScaled`.
        public unsafe JPH.DMat44 PostScaled(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_PostScaled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_PostScaled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_PostScaled(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return new(__JPH_DMat44_PostScaled(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// Pre multiply by translation matrix: result = this * Mat44::sTranslation(inTranslation)
        /// Generated from method `JPH::DMat44::PreTranslated`.
        public unsafe JPH.DMat44 PreTranslated(JPH.Const_Vec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_PreTranslated_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_PreTranslated_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_PreTranslated_JPH_Vec3(_Underlying *_this, JPH.Vec3._Underlying *inTranslation);
            return new(__JPH_DMat44_PreTranslated_JPH_Vec3(_UnderlyingPtr, inTranslation._UnderlyingPtr), is_owning: true);
        }

        /// Pre multiply by translation matrix: result = this * Mat44::sTranslation(inTranslation)
        /// Generated from method `JPH::DMat44::PreTranslated`.
        public unsafe JPH.DMat44 PreTranslated(JPH.Const_DVec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_PreTranslated_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_PreTranslated_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_PreTranslated_JPH_DVec3(_Underlying *_this, JPH.Const_DVec3._Underlying *inTranslation);
            return new(__JPH_DMat44_PreTranslated_JPH_DVec3(_UnderlyingPtr, inTranslation._UnderlyingPtr), is_owning: true);
        }

        /// Post multiply by translation matrix: result = Mat44::sTranslation(inTranslation) * this (i.e. add inTranslation to the 4-th column)
        /// Generated from method `JPH::DMat44::PostTranslated`.
        public unsafe JPH.DMat44 PostTranslated(JPH.Const_Vec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_PostTranslated_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_PostTranslated_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_PostTranslated_JPH_Vec3(_Underlying *_this, JPH.Vec3._Underlying *inTranslation);
            return new(__JPH_DMat44_PostTranslated_JPH_Vec3(_UnderlyingPtr, inTranslation._UnderlyingPtr), is_owning: true);
        }

        /// Post multiply by translation matrix: result = Mat44::sTranslation(inTranslation) * this (i.e. add inTranslation to the 4-th column)
        /// Generated from method `JPH::DMat44::PostTranslated`.
        public unsafe JPH.DMat44 PostTranslated(JPH.Const_DVec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_PostTranslated_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_PostTranslated_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_PostTranslated_JPH_DVec3(_Underlying *_this, JPH.Const_DVec3._Underlying *inTranslation);
            return new(__JPH_DMat44_PostTranslated_JPH_DVec3(_UnderlyingPtr, inTranslation._UnderlyingPtr), is_owning: true);
        }

        /// Access to the columns
        /// Generated from method `JPH::DMat44::GetAxisX`.
        public unsafe JPH.Vec3 GetAxisX()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_GetAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_GetAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_DMat44_GetAxisX(_Underlying *_this);
            return new(__JPH_DMat44_GetAxisX(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::DMat44::GetAxisY`.
        public unsafe JPH.Vec3 GetAxisY()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_GetAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_GetAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_DMat44_GetAxisY(_Underlying *_this);
            return new(__JPH_DMat44_GetAxisY(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::DMat44::GetAxisZ`.
        public unsafe JPH.Vec3 GetAxisZ()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_GetAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_GetAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_DMat44_GetAxisZ(_Underlying *_this);
            return new(__JPH_DMat44_GetAxisZ(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::DMat44::GetTranslation`.
        public unsafe JPH.DVec3 GetTranslation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_GetTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_GetTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DVec3._Underlying *__JPH_DMat44_GetTranslation(_Underlying *_this);
            return new(__JPH_DMat44_GetTranslation(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::DMat44::GetColumn3`.
        public unsafe JPH.Vec3 GetColumn3(uint inCol)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_GetColumn3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_GetColumn3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_DMat44_GetColumn3(_Underlying *_this, uint inCol);
            return new(__JPH_DMat44_GetColumn3(_UnderlyingPtr, inCol), is_owning: true);
        }

        /// Generated from method `JPH::DMat44::GetColumn4`.
        public unsafe JPH.Vec4 GetColumn4(uint inCol)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_GetColumn4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_GetColumn4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec4._Underlying *__JPH_DMat44_GetColumn4(_Underlying *_this, uint inCol);
            return new(__JPH_DMat44_GetColumn4(_UnderlyingPtr, inCol), is_owning: true);
        }

        /// Transpose 3x3 subpart of matrix
        /// Generated from method `JPH::DMat44::Transposed3x3`.
        public unsafe JPH.Mat44 Transposed3x3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_Transposed3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_Transposed3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_DMat44_Transposed3x3(_Underlying *_this);
            return new(__JPH_DMat44_Transposed3x3(_UnderlyingPtr), is_owning: true);
        }

        /// Inverse 4x4 matrix
        /// Generated from method `JPH::DMat44::Inversed`.
        public unsafe JPH.DMat44 Inversed()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_Inversed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_Inversed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_Inversed(_Underlying *_this);
            return new(__JPH_DMat44_Inversed(_UnderlyingPtr), is_owning: true);
        }

        /// Inverse 4x4 matrix when it only contains rotation and translation
        /// Generated from method `JPH::DMat44::InversedRotationTranslation`.
        public unsafe JPH.DMat44 InversedRotationTranslation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_InversedRotationTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_InversedRotationTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_InversedRotationTranslation(_Underlying *_this);
            return new(__JPH_DMat44_InversedRotationTranslation(_UnderlyingPtr), is_owning: true);
        }

        /// Get rotation part only (note: retains the first 3 values from the bottom row)
        /// Generated from method `JPH::DMat44::GetRotation`.
        public unsafe JPH.Mat44 GetRotation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_DMat44_GetRotation(_Underlying *_this);
            return new(__JPH_DMat44_GetRotation(_UnderlyingPtr), is_owning: true);
        }

        /// Convert to quaternion
        /// Generated from method `JPH::DMat44::GetQuaternion`.
        public unsafe JPH.Quat GetQuaternion()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_GetQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_GetQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_DMat44_GetQuaternion(_Underlying *_this);
            return new(__JPH_DMat44_GetQuaternion(_UnderlyingPtr), is_owning: true);
        }

        /// Get matrix that transforms a direction with the same transform as this matrix (length is not preserved)
        /// Generated from method `JPH::DMat44::GetDirectionPreservingMatrix`.
        public unsafe JPH.Mat44 GetDirectionPreservingMatrix()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_GetDirectionPreservingMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_GetDirectionPreservingMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_DMat44_GetDirectionPreservingMatrix(_Underlying *_this);
            return new(__JPH_DMat44_GetDirectionPreservingMatrix(_UnderlyingPtr), is_owning: true);
        }

        /// Works identical to Mat44::Decompose
        /// Generated from method `JPH::DMat44::Decompose`.
        public unsafe JPH.DMat44 Decompose(JPH.Vec3 outScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_Decompose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_Decompose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_Decompose(_Underlying *_this, JPH.Vec3._Underlying *outScale);
            return new(__JPH_DMat44_Decompose(_UnderlyingPtr, outScale._UnderlyingPtr), is_owning: true);
        }

        // IEquatable:

        public bool Equals(JPH.Const_DMat44? inM2)
        {
            if (inM2 is null)
                return false;
            return this == inM2;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is JPH.Const_DMat44)
                return this == (JPH.Const_DMat44)other;
            return false;
        }
    }

    /// Holds a 4x4 matrix of floats with the last column consisting of doubles
    /// Generated from class `JPH::DMat44`.
    /// This is the non-const half of the class.
    public class DMat44 : Const_DMat44
    {
        internal unsafe DMat44(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe DMat44() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_DefaultConstruct();
            _UnderlyingPtr = __JPH_DMat44_DefaultConstruct();
        }

        /// Generated from constructor `JPH::DMat44::DMat44`.
        public unsafe DMat44(JPH.Const_DMat44 inM2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_ConstructFromAnother(JPH.DMat44._Underlying *inM2);
            _UnderlyingPtr = __JPH_DMat44_ConstructFromAnother(inM2._UnderlyingPtr);
            _KeepAlive(inM2);
        }

        /// Generated from constructor `JPH::DMat44::DMat44`.
        public DMat44(DMat44 inM2) : this((Const_DMat44)inM2) {}

        /// Generated from constructor `JPH::DMat44::DMat44`.
        public unsafe DMat44(JPH.Const_Vec4 inC1, JPH.Const_Vec4 inC2, JPH.Const_Vec4 inC3, JPH.Const_DVec3 inC4) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_Construct_4_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_Construct_4_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_Construct_4_JPH_Vec4(JPH.Vec4._Underlying *inC1, JPH.Vec4._Underlying *inC2, JPH.Vec4._Underlying *inC3, JPH.Const_DVec3._Underlying *inC4);
            _UnderlyingPtr = __JPH_DMat44_Construct_4_JPH_Vec4(inC1._UnderlyingPtr, inC2._UnderlyingPtr, inC3._UnderlyingPtr, inC4._UnderlyingPtr);
        }

        /// Generated from constructor `JPH::DMat44::DMat44`.
        public unsafe DMat44(JPH.Const_Mat44 inM) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_Construct_1(JPH.Const_Mat44._Underlying *inM);
            _UnderlyingPtr = __JPH_DMat44_Construct_1(inM._UnderlyingPtr);
        }

        /// Generated from constructor `JPH::DMat44::DMat44`.
        public unsafe DMat44(JPH.Const_Mat44 inRot, JPH.Const_DVec3 inT) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_Construct_2(JPH.Const_Mat44._Underlying *inRot, JPH.Const_DVec3._Underlying *inT);
            _UnderlyingPtr = __JPH_DMat44_Construct_2(inRot._UnderlyingPtr, inT._UnderlyingPtr);
        }

        /// Generated from method `JPH::DMat44::operator=`.
        public unsafe JPH.DMat44 Assign(JPH.Const_DMat44 inM2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DMat44._Underlying *__JPH_DMat44_AssignFromAnother(_Underlying *_this, JPH.DMat44._Underlying *inM2);
            JPH.DMat44 __ret;
            __ret = new(__JPH_DMat44_AssignFromAnother(_UnderlyingPtr, inM2._UnderlyingPtr), is_owning: false);
            _DiscardKeepAlive();
            _KeepAlive(inM2);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Generated from method `JPH::DMat44::SetAxisX`.
        public unsafe void SetAxisX(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_SetAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_SetAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DMat44_SetAxisX(_Underlying *_this, JPH.Vec3._Underlying *inV);
            __JPH_DMat44_SetAxisX(_UnderlyingPtr, inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::DMat44::SetAxisY`.
        public unsafe void SetAxisY(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_SetAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_SetAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DMat44_SetAxisY(_Underlying *_this, JPH.Vec3._Underlying *inV);
            __JPH_DMat44_SetAxisY(_UnderlyingPtr, inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::DMat44::SetAxisZ`.
        public unsafe void SetAxisZ(JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_SetAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_SetAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DMat44_SetAxisZ(_Underlying *_this, JPH.Vec3._Underlying *inV);
            __JPH_DMat44_SetAxisZ(_UnderlyingPtr, inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::DMat44::SetTranslation`.
        public unsafe void SetTranslation(JPH.Const_DVec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_SetTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_SetTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DMat44_SetTranslation(_Underlying *_this, JPH.Const_DVec3._Underlying *inV);
            __JPH_DMat44_SetTranslation(_UnderlyingPtr, inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::DMat44::SetColumn3`.
        public unsafe void SetColumn3(uint inCol, JPH.Const_Vec3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_SetColumn3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_SetColumn3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DMat44_SetColumn3(_Underlying *_this, uint inCol, JPH.Vec3._Underlying *inV);
            __JPH_DMat44_SetColumn3(_UnderlyingPtr, inCol, inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::DMat44::SetColumn4`.
        public unsafe void SetColumn4(uint inCol, JPH.Const_Vec4 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_SetColumn4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_SetColumn4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DMat44_SetColumn4(_Underlying *_this, uint inCol, JPH.Vec4._Underlying *inV);
            __JPH_DMat44_SetColumn4(_UnderlyingPtr, inCol, inV._UnderlyingPtr);
        }

        /// Updates the rotation part of this matrix (the first 3 columns)
        /// Generated from method `JPH::DMat44::SetRotation`.
        public unsafe void SetRotation(JPH.Const_Mat44 inRotation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DMat44_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DMat44_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DMat44_SetRotation(_Underlying *_this, JPH.Const_Mat44._Underlying *inRotation);
            __JPH_DMat44_SetRotation(_UnderlyingPtr, inRotation._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `DMat44` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_DMat44`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `DMat44`/`Const_DMat44` directly.
    public class _InOptMut_DMat44
    {
        public DMat44? Opt;

        public _InOptMut_DMat44() {}
        public _InOptMut_DMat44(DMat44 value) {Opt = value;}
        public static implicit operator _InOptMut_DMat44(DMat44 value) {return new(value);}
    }

    /// This is used for optional parameters of class `DMat44` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_DMat44`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `DMat44`/`Const_DMat44` to pass it to the function.
    public class _InOptConst_DMat44
    {
        public Const_DMat44? Opt;

        public _InOptConst_DMat44() {}
        public _InOptConst_DMat44(Const_DMat44 value) {Opt = value;}
        public static implicit operator _InOptConst_DMat44(Const_DMat44 value) {return new(value);}
    }
}
