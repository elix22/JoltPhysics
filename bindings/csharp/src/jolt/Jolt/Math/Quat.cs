// machine generated, do not edit
public static partial class JPH
{
    /// Quaternion class, quaternions are 4 dimensional vectors which can describe rotations in 3 dimensional
    /// space if their length is 1.
    ///
    /// They are written as:
    ///
    /// \f$q = w + x \: i + y \: j + z \: k\f$
    ///
    /// or in vector notation:
    ///
    /// \f$q = [w, v] = [w, x, y, z]\f$
    ///
    /// Where:
    ///
    /// w = the real part
    /// v = the imaginary part, (x, y, z)
    ///
    /// Note that we store the quaternion in a Vec4 as [x, y, z, w] because that makes
    /// it easy to extract the rotation axis of the quaternion:
    ///
    /// q = [cos(angle / 2), sin(angle / 2) * rotation_axis]
    /// Generated from class `JPH::Quat`.
    /// This is the const half of the class.
    public class Const_Quat : JPH.Object<Const_Quat>, System.IDisposable, System.IEquatable<JPH.Const_Quat>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Quat_Destroy(_Underlying *_this);
            __JPH_Quat_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Quat() {Dispose(false);}

        /// 4 vector that stores [x, y, z, w] parts of the quaternion
        public unsafe JPH.Const_Vec4 mValue
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_Get_mValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_Get_mValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec4._Underlying *__JPH_Quat_Get_mValue(_Underlying *_this);
                JPH.Const_Vec4 __ret;
                __ret = new(__JPH_Quat_Get_mValue(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_Quat(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Quat() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_DefaultConstruct();
            _UnderlyingPtr = __JPH_Quat_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Quat::Quat`.
        public unsafe Const_Quat(JPH.Const_Quat inRHS) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_ConstructFromAnother(JPH.Quat._Underlying *inRHS);
            _UnderlyingPtr = __JPH_Quat_ConstructFromAnother(inRHS._UnderlyingPtr);
            _KeepAlive(inRHS);
        }

        /// Generated from constructor `JPH::Quat::Quat`.
        public Const_Quat(Quat inRHS) : this((Const_Quat)inRHS) {}

        /// Generated from constructor `JPH::Quat::Quat`.
        public unsafe Const_Quat(float inX, float inY, float inZ, float inW) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_Construct_4(float inX, float inY, float inZ, float inW);
            _UnderlyingPtr = __JPH_Quat_Construct_4(inX, inY, inZ, inW);
        }

        /// Generated from constructor `JPH::Quat::Quat`.
        public unsafe Const_Quat(JPH.Const_Float4 inV) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_Construct_1_JPH_Float4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_Construct_1_JPH_Float4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_Construct_1_JPH_Float4(JPH.Const_Float4._Underlying *inV);
            _UnderlyingPtr = __JPH_Quat_Construct_1_JPH_Float4(inV._UnderlyingPtr);
        }

        /// Generated from constructor `JPH::Quat::Quat`.
        public unsafe Const_Quat(JPH.Const_Vec4 inV) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_Construct_1_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_Construct_1_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_Construct_1_JPH_Vec4(JPH.Vec4._Underlying *inV);
            _UnderlyingPtr = __JPH_Quat_Construct_1_JPH_Vec4(inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::Quat::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Quat_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Quat_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Quat_size_t(ulong inCount);
            return __Jolt_new_JPH_Quat_size_t(inCount);
        }

        /// Generated from method `JPH::Quat::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Quat_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Quat_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Quat_void_ptr(void *inPointer);
            __Jolt_delete_JPH_Quat_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Quat::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Quat_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Quat_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Quat_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_JPH_Quat_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Quat::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Quat_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Quat_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Quat_size_t(ulong inCount);
            return __Jolt_new_array_JPH_Quat_size_t(inCount);
        }

        /// Generated from method `JPH::Quat::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Quat_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Quat_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Quat_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_Quat_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Quat::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Quat_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Quat_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Quat_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_array_JPH_Quat_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Quat::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Quat_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Quat_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Quat_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_JPH_Quat_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Quat::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Quat_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Quat_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Quat_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_Quat_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::Quat::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Quat_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Quat_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Quat_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_array_JPH_Quat_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Quat::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Quat_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Quat_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Quat_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_Quat_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Check if two quaternions are exactly equal
        /// Generated from method `JPH::Quat::operator==`.
        public static unsafe bool operator==(JPH.Const_Quat _this, JPH.Const_Quat inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_Quat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_Quat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_equal_JPH_Quat(JPH.Const_Quat._Underlying *_this, JPH.Quat._Underlying *inRHS);
            return __Jolt_equal_JPH_Quat(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(JPH.Const_Quat _this, JPH.Const_Quat inRHS)
        {
            return !(_this == inRHS);
        }

        /// If this quaternion is close to inRHS. Note that q and -q represent the same rotation, this is not checked here.
        /// Generated from method `JPH::Quat::IsClose`.
        /// Parameter `inMaxDistSq` defaults to `9.99999996e-13f`.
        public unsafe bool IsClose(JPH.Const_Quat inRHS, float? inMaxDistSq = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_IsClose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_IsClose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Quat_IsClose(_Underlying *_this, JPH.Quat._Underlying *inRHS, float *inMaxDistSq);
            float __deref_inMaxDistSq = inMaxDistSq.GetValueOrDefault();
            return __JPH_Quat_IsClose(_UnderlyingPtr, inRHS._UnderlyingPtr, inMaxDistSq.HasValue ? &__deref_inMaxDistSq : null) != 0;
        }

        /// If the length of this quaternion is 1 +/- inTolerance
        /// Generated from method `JPH::Quat::IsNormalized`.
        /// Parameter `inTolerance` defaults to `9.99999974e-6f`.
        public unsafe bool IsNormalized(float? inTolerance = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_IsNormalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_IsNormalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Quat_IsNormalized(_Underlying *_this, float *inTolerance);
            float __deref_inTolerance = inTolerance.GetValueOrDefault();
            return __JPH_Quat_IsNormalized(_UnderlyingPtr, inTolerance.HasValue ? &__deref_inTolerance : null) != 0;
        }

        /// If any component of this quaternion is a NaN (not a number)
        /// Generated from method `JPH::Quat::IsNaN`.
        public unsafe bool IsNaN()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_IsNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_IsNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Quat_IsNaN(_Underlying *_this);
            return __JPH_Quat_IsNaN(_UnderlyingPtr) != 0;
        }

        /// Get X component (imaginary part i)
        /// Generated from method `JPH::Quat::GetX`.
        public unsafe float GetX()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_GetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_GetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Quat_GetX(_Underlying *_this);
            return __JPH_Quat_GetX(_UnderlyingPtr);
        }

        /// Get Y component (imaginary part j)
        /// Generated from method `JPH::Quat::GetY`.
        public unsafe float GetY()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_GetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_GetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Quat_GetY(_Underlying *_this);
            return __JPH_Quat_GetY(_UnderlyingPtr);
        }

        /// Get Z component (imaginary part k)
        /// Generated from method `JPH::Quat::GetZ`.
        public unsafe float GetZ()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_GetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_GetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Quat_GetZ(_Underlying *_this);
            return __JPH_Quat_GetZ(_UnderlyingPtr);
        }

        /// Get W component (real part)
        /// Generated from method `JPH::Quat::GetW`.
        public unsafe float GetW()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_GetW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_GetW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Quat_GetW(_Underlying *_this);
            return __JPH_Quat_GetW(_UnderlyingPtr);
        }

        /// Get the imaginary part of the quaternion
        /// Generated from method `JPH::Quat::GetXYZ`.
        public unsafe JPH.Vec3 GetXYZ()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_GetXYZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_GetXYZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Quat_GetXYZ(_Underlying *_this);
            return new(__JPH_Quat_GetXYZ(_UnderlyingPtr), is_owning: true);
        }

        /// Get the quaternion as a Vec4
        /// Generated from method `JPH::Quat::GetXYZW`.
        public unsafe JPH.Vec4 GetXYZW()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_GetXYZW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_GetXYZW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec4._Underlying *__JPH_Quat_GetXYZW(_Underlying *_this);
            return new(__JPH_Quat_GetXYZW(_UnderlyingPtr), is_owning: true);
        }

        /// @return [0, 0, 0, 0]
        /// Generated from method `JPH::Quat::sZero`.
        public static unsafe JPH.Quat SZero()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_sZero();
            return new(__JPH_Quat_sZero(), is_owning: true);
        }

        /// @return [1, 0, 0, 0] (or in storage format Quat(0, 0, 0, 1))
        /// Generated from method `JPH::Quat::sIdentity`.
        public static unsafe JPH.Quat SIdentity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_sIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_sIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_sIdentity();
            return new(__JPH_Quat_sIdentity(), is_owning: true);
        }

        /// Rotation from axis and angle
        /// Generated from method `JPH::Quat::sRotation`.
        public static unsafe JPH.Quat SRotation(JPH.Const_Vec3 inAxis, float inAngle)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_sRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_sRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_sRotation(JPH.Vec3._Underlying *inAxis, float inAngle);
            return new(__JPH_Quat_sRotation(inAxis._UnderlyingPtr, inAngle), is_owning: true);
        }

        /// Get axis and angle that represents this quaternion, outAngle will always be in the range \f$[0, \pi]\f$
        /// Generated from method `JPH::Quat::GetAxisAngle`.
        public unsafe void GetAxisAngle(JPH.Vec3 outAxis, ref float outAngle)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_GetAxisAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_GetAxisAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Quat_GetAxisAngle(_Underlying *_this, JPH.Vec3._Underlying *outAxis, float *outAngle);
            fixed (float *__ptr_outAngle = &outAngle)
            {
                __JPH_Quat_GetAxisAngle(_UnderlyingPtr, outAxis._UnderlyingPtr, __ptr_outAngle);
            }
        }

        /// Create quaternion that rotates a vector from the direction of inFrom to the direction of inTo along the shortest path
        /// @see https://www.euclideanspace.com/maths/algebra/vectors/angleBetween/index.htm
        /// Generated from method `JPH::Quat::sFromTo`.
        public static unsafe JPH.Quat SFromTo(JPH.Const_Vec3 inFrom, JPH.Const_Vec3 inTo)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_sFromTo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_sFromTo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_sFromTo(JPH.Vec3._Underlying *inFrom, JPH.Vec3._Underlying *inTo);
            return new(__JPH_Quat_sFromTo(inFrom._UnderlyingPtr, inTo._UnderlyingPtr), is_owning: true);
        }

        /// Conversion from Euler angles. Rotation order is X then Y then Z (RotZ * RotY * RotX). Angles in radians.
        /// Generated from method `JPH::Quat::sEulerAngles`.
        public static unsafe JPH.Quat SEulerAngles(JPH.Const_Vec3 inAngles)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_sEulerAngles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_sEulerAngles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_sEulerAngles(JPH.Vec3._Underlying *inAngles);
            return new(__JPH_Quat_sEulerAngles(inAngles._UnderlyingPtr), is_owning: true);
        }

        /// Conversion to Euler angles. Rotation order is X then Y then Z (RotZ * RotY * RotX). Angles in radians.
        /// Generated from method `JPH::Quat::GetEulerAngles`.
        public unsafe JPH.Vec3 GetEulerAngles()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_GetEulerAngles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_GetEulerAngles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Quat_GetEulerAngles(_Underlying *_this);
            return new(__JPH_Quat_GetEulerAngles(_UnderlyingPtr), is_owning: true);
        }

        /// Squared length of quaternion.
        /// @return Squared length of quaternion (\f$|v|^2\f$)
        /// Generated from method `JPH::Quat::LengthSq`.
        public unsafe float LengthSq()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_LengthSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_LengthSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Quat_LengthSq(_Underlying *_this);
            return __JPH_Quat_LengthSq(_UnderlyingPtr);
        }

        /// Length of quaternion.
        /// @return Length of quaternion (\f$|v|\f$)
        /// Generated from method `JPH::Quat::Length`.
        public unsafe float Length()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_Length", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_Length", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Quat_Length(_Underlying *_this);
            return __JPH_Quat_Length(_UnderlyingPtr);
        }

        /// Normalize the quaternion (make it length 1)
        /// Generated from method `JPH::Quat::Normalized`.
        public unsafe JPH.Quat Normalized()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_Normalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_Normalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_Normalized(_Underlying *_this);
            return new(__JPH_Quat_Normalized(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Quat::operator-`.
        public static unsafe JPH.Quat operator-(JPH.Const_Quat _this)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_neg_JPH_Quat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_neg_JPH_Quat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__Jolt_neg_JPH_Quat(JPH.Const_Quat._Underlying *_this);
            return new(__Jolt_neg_JPH_Quat(_this._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Quat::operator+`.
        public static unsafe JPH.Quat operator+(JPH.Const_Quat _this, JPH.Const_Quat inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_add_JPH_Quat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_add_JPH_Quat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__Jolt_add_JPH_Quat(JPH.Const_Quat._Underlying *_this, JPH.Quat._Underlying *inRHS);
            return new(__Jolt_add_JPH_Quat(_this._UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Quat::operator-`.
        public static unsafe JPH.Quat operator-(JPH.Const_Quat _this, JPH.Const_Quat inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_sub_JPH_Quat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_sub_JPH_Quat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__Jolt_sub_JPH_Quat(JPH.Const_Quat._Underlying *_this, JPH.Quat._Underlying *inRHS);
            return new(__Jolt_sub_JPH_Quat(_this._UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: true);
        }

        // Jolt Physics Library (https://github.com/jrouwe/JoltPhysics)
        // SPDX-FileCopyrightText: 2021 Jorrit Rouwe
        // SPDX-License-Identifier: MIT
        /// Generated from method `JPH::Quat::operator*`.
        public static unsafe JPH.Quat operator*(JPH.Const_Quat _this, JPH.Const_Quat inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Quat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Quat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__Jolt_mul_JPH_Quat(JPH.Const_Quat._Underlying *_this, JPH.Quat._Underlying *inRHS);
            return new(__Jolt_mul_JPH_Quat(_this._UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Quat::operator*`.
        public static unsafe JPH.Quat operator*(JPH.Const_Quat _this, float inValue)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Quat_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Quat_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__Jolt_mul_JPH_Quat_float(JPH.Const_Quat._Underlying *_this, float inValue);
            return new(__Jolt_mul_JPH_Quat_float(_this._UnderlyingPtr, inValue), is_owning: true);
        }

        /// Generated from method `JPH::Quat::operator/`.
        public static unsafe JPH.Quat operator/(JPH.Const_Quat _this, float inValue)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_div_JPH_Quat_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_div_JPH_Quat_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__Jolt_div_JPH_Quat_float(JPH.Const_Quat._Underlying *_this, float inValue);
            return new(__Jolt_div_JPH_Quat_float(_this._UnderlyingPtr, inValue), is_owning: true);
        }

        /// Rotate a vector by this quaternion
        /// Generated from method `JPH::Quat::operator*`.
        public static unsafe JPH.Vec3 operator*(JPH.Const_Quat _this, JPH.Const_Vec3 inValue)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Quat_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Quat_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__Jolt_mul_JPH_Quat_JPH_Vec3(JPH.Const_Quat._Underlying *_this, JPH.Vec3._Underlying *inValue);
            return new(__Jolt_mul_JPH_Quat_JPH_Vec3(_this._UnderlyingPtr, inValue._UnderlyingPtr), is_owning: true);
        }

        /// Multiply a quaternion with imaginary components and no real component (x, y, z, 0) with a quaternion
        /// Generated from method `JPH::Quat::sMultiplyImaginary`.
        public static unsafe JPH.Quat SMultiplyImaginary(JPH.Const_Vec3 inLHS, JPH.Const_Quat inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_sMultiplyImaginary", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_sMultiplyImaginary", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_sMultiplyImaginary(JPH.Vec3._Underlying *inLHS, JPH.Quat._Underlying *inRHS);
            return new(__JPH_Quat_sMultiplyImaginary(inLHS._UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: true);
        }

        /// Rotate a vector by the inverse of this quaternion
        /// Generated from method `JPH::Quat::InverseRotate`.
        public unsafe JPH.Vec3 InverseRotate(JPH.Const_Vec3 inValue)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_InverseRotate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_InverseRotate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Quat_InverseRotate(_Underlying *_this, JPH.Vec3._Underlying *inValue);
            return new(__JPH_Quat_InverseRotate(_UnderlyingPtr, inValue._UnderlyingPtr), is_owning: true);
        }

        /// Rotate a the vector (1, 0, 0) with this quaternion
        /// Generated from method `JPH::Quat::RotateAxisX`.
        public unsafe JPH.Vec3 RotateAxisX()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_RotateAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_RotateAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Quat_RotateAxisX(_Underlying *_this);
            return new(__JPH_Quat_RotateAxisX(_UnderlyingPtr), is_owning: true);
        }

        /// Rotate a the vector (0, 1, 0) with this quaternion
        /// Generated from method `JPH::Quat::RotateAxisY`.
        public unsafe JPH.Vec3 RotateAxisY()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_RotateAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_RotateAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Quat_RotateAxisY(_Underlying *_this);
            return new(__JPH_Quat_RotateAxisY(_UnderlyingPtr), is_owning: true);
        }

        /// Rotate a the vector (0, 0, 1) with this quaternion
        /// Generated from method `JPH::Quat::RotateAxisZ`.
        public unsafe JPH.Vec3 RotateAxisZ()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_RotateAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_RotateAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Quat_RotateAxisZ(_Underlying *_this);
            return new(__JPH_Quat_RotateAxisZ(_UnderlyingPtr), is_owning: true);
        }

        /// Dot product
        /// Generated from method `JPH::Quat::Dot`.
        public unsafe float Dot(JPH.Const_Quat inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_Dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_Dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Quat_Dot(_Underlying *_this, JPH.Quat._Underlying *inRHS);
            return __JPH_Quat_Dot(_UnderlyingPtr, inRHS._UnderlyingPtr);
        }

        /// The conjugate [w, -x, -y, -z] is the same as the inverse for unit quaternions
        /// Generated from method `JPH::Quat::Conjugated`.
        public unsafe JPH.Quat Conjugated()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_Conjugated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_Conjugated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_Conjugated(_Underlying *_this);
            return new(__JPH_Quat_Conjugated(_UnderlyingPtr), is_owning: true);
        }

        /// Get inverse quaternion
        /// Generated from method `JPH::Quat::Inversed`.
        public unsafe JPH.Quat Inversed()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_Inversed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_Inversed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_Inversed(_Underlying *_this);
            return new(__JPH_Quat_Inversed(_UnderlyingPtr), is_owning: true);
        }

        /// Ensures that the W component is positive by negating the entire quaternion if it is not. This is useful when you want to store a quaternion as a 3 vector by discarding W and reconstructing it as sqrt(1 - x^2 - y^2 - z^2).
        /// Generated from method `JPH::Quat::EnsureWPositive`.
        public unsafe JPH.Quat EnsureWPositive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_EnsureWPositive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_EnsureWPositive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_EnsureWPositive(_Underlying *_this);
            return new(__JPH_Quat_EnsureWPositive(_UnderlyingPtr), is_owning: true);
        }

        /// Get a quaternion that is perpendicular to this quaternion
        /// Generated from method `JPH::Quat::GetPerpendicular`.
        public unsafe JPH.Quat GetPerpendicular()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_GetPerpendicular", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_GetPerpendicular", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_GetPerpendicular(_Underlying *_this);
            return new(__JPH_Quat_GetPerpendicular(_UnderlyingPtr), is_owning: true);
        }

        /// Get rotation angle around inAxis (uses Swing Twist Decomposition to get the twist quaternion and uses q(axis, angle) = [cos(angle / 2), axis * sin(angle / 2)])
        /// Generated from method `JPH::Quat::GetRotationAngle`.
        public unsafe float GetRotationAngle(JPH.Const_Vec3 inAxis)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_GetRotationAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_GetRotationAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Quat_GetRotationAngle(_Underlying *_this, JPH.Vec3._Underlying *inAxis);
            return __JPH_Quat_GetRotationAngle(_UnderlyingPtr, inAxis._UnderlyingPtr);
        }

        /// Swing Twist Decomposition: any quaternion can be split up as:
        ///
        /// \f[q = q_{swing} \: q_{twist}\f]
        ///
        /// where \f$q_{twist}\f$ rotates only around axis v.
        ///
        /// \f$q_{twist}\f$ is:
        ///
        /// \f[q_{twist} = \frac{[q_w, q_{ijk} \cdot v \: v]}{\left|[q_w, q_{ijk} \cdot v \: v]\right|}\f]
        ///
        /// where q_w is the real part of the quaternion and q_i the imaginary part (a 3 vector).
        ///
        /// The swing can then be calculated as:
        ///
        /// \f[q_{swing} = q \: q_{twist}^* \f]
        ///
        /// Where \f$q_{twist}^*\f$ = complex conjugate of \f$q_{twist}\f$
        /// Generated from method `JPH::Quat::GetTwist`.
        public unsafe JPH.Quat GetTwist(JPH.Const_Vec3 inAxis)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_GetTwist", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_GetTwist", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_GetTwist(_Underlying *_this, JPH.Vec3._Underlying *inAxis);
            return new(__JPH_Quat_GetTwist(_UnderlyingPtr, inAxis._UnderlyingPtr), is_owning: true);
        }

        /// Decomposes quaternion into swing and twist component:
        ///
        /// \f$q = q_{swing} \: q_{twist}\f$
        ///
        /// where \f$q_{swing} \: \hat{x} = q_{twist} \: \hat{y} = q_{twist} \: \hat{z} = 0\f$
        ///
        /// In other words:
        ///
        /// - \f$q_{twist}\f$ only rotates around the X-axis.
        /// - \f$q_{swing}\f$ only rotates around the Y and Z-axis.
        ///
        /// @see Gino van den Bergen - Rotational Joint Limits in Quaternion Space - GDC 2016
        /// Generated from method `JPH::Quat::GetSwingTwist`.
        public unsafe void GetSwingTwist(JPH.Quat outSwing, JPH.Quat outTwist)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_GetSwingTwist", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_GetSwingTwist", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Quat_GetSwingTwist(_Underlying *_this, JPH.Quat._Underlying *outSwing, JPH.Quat._Underlying *outTwist);
            __JPH_Quat_GetSwingTwist(_UnderlyingPtr, outSwing._UnderlyingPtr, outTwist._UnderlyingPtr);
        }

        /// Linear interpolation between two quaternions (for small steps).
        /// @param inFraction is in the range [0, 1]
        /// @param inDestination The destination quaternion
        /// @return (1 - inFraction) * this + fraction * inDestination
        /// Generated from method `JPH::Quat::LERP`.
        public unsafe JPH.Quat LERP(JPH.Const_Quat inDestination, float inFraction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_LERP", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_LERP", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_LERP(_Underlying *_this, JPH.Quat._Underlying *inDestination, float inFraction);
            return new(__JPH_Quat_LERP(_UnderlyingPtr, inDestination._UnderlyingPtr, inFraction), is_owning: true);
        }

        /// Spherical linear interpolation between two quaternions.
        /// @param inFraction is in the range [0, 1]
        /// @param inDestination The destination quaternion
        /// @return When fraction is zero this quaternion is returned, when fraction is 1 inDestination is returned.
        /// When fraction is between 0 and 1 an interpolation along the shortest path is returned.
        /// Generated from method `JPH::Quat::SLERP`.
        public unsafe JPH.Quat SLERP(JPH.Const_Quat inDestination, float inFraction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_SLERP", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_SLERP", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_SLERP(_Underlying *_this, JPH.Quat._Underlying *inDestination, float inFraction);
            return new(__JPH_Quat_SLERP(_UnderlyingPtr, inDestination._UnderlyingPtr, inFraction), is_owning: true);
        }

        /// Load 3 floats from memory (X, Y and Z component and then calculates W) reads 32 bits extra which it doesn't use
        /// Generated from method `JPH::Quat::sLoadFloat3Unsafe`.
        public static unsafe JPH.Quat SLoadFloat3Unsafe(JPH.Const_Float3 inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_sLoadFloat3Unsafe", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_sLoadFloat3Unsafe", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_sLoadFloat3Unsafe(JPH.Const_Float3._Underlying *inV);
            return new(__JPH_Quat_sLoadFloat3Unsafe(inV._UnderlyingPtr), is_owning: true);
        }

        /// Store as 3 floats to memory (X, Y and Z component). Ensures that W is positive before storing.
        /// Generated from method `JPH::Quat::StoreFloat3`.
        public unsafe void StoreFloat3(JPH.Float3? outV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_StoreFloat3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_StoreFloat3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Quat_StoreFloat3(_Underlying *_this, JPH.Float3._Underlying *outV);
            __JPH_Quat_StoreFloat3(_UnderlyingPtr, outV is not null ? outV._UnderlyingPtr : null);
        }

        /// Store as 4 floats
        /// Generated from method `JPH::Quat::StoreFloat4`.
        public unsafe void StoreFloat4(JPH.Float4? outV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_StoreFloat4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_StoreFloat4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Quat_StoreFloat4(_Underlying *_this, JPH.Float4._Underlying *outV);
            __JPH_Quat_StoreFloat4(_UnderlyingPtr, outV is not null ? outV._UnderlyingPtr : null);
        }

        /// Compress a unit quaternion to a 32 bit value, precision is around 0.5 degree
        /// Generated from method `JPH::Quat::CompressUnitQuat`.
        public unsafe uint CompressUnitQuat()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_CompressUnitQuat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_CompressUnitQuat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_Quat_CompressUnitQuat(_Underlying *_this);
            return __JPH_Quat_CompressUnitQuat(_UnderlyingPtr);
        }

        /// Decompress a unit quaternion from a 32 bit value
        /// Generated from method `JPH::Quat::sDecompressUnitQuat`.
        public static unsafe JPH.Quat SDecompressUnitQuat(uint inValue)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_sDecompressUnitQuat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_sDecompressUnitQuat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_sDecompressUnitQuat(uint inValue);
            return new(__JPH_Quat_sDecompressUnitQuat(inValue), is_owning: true);
        }

        /// Generated from function `JPH::operator*`.
        public static unsafe JPH.Quat operator*(float inValue, Const_Quat inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_float_JPH_Quat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_float_JPH_Quat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__Jolt_mul_float_JPH_Quat(float inValue, JPH.Quat._Underlying *inRHS);
            return new(__Jolt_mul_float_JPH_Quat(inValue, inRHS._UnderlyingPtr), is_owning: true);
        }

        // IEquatable:

        public bool Equals(JPH.Const_Quat? inRHS)
        {
            if (inRHS is null)
                return false;
            return this == inRHS;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is JPH.Const_Quat)
                return this == (JPH.Const_Quat)other;
            return false;
        }
    }

    /// Quaternion class, quaternions are 4 dimensional vectors which can describe rotations in 3 dimensional
    /// space if their length is 1.
    ///
    /// They are written as:
    ///
    /// \f$q = w + x \: i + y \: j + z \: k\f$
    ///
    /// or in vector notation:
    ///
    /// \f$q = [w, v] = [w, x, y, z]\f$
    ///
    /// Where:
    ///
    /// w = the real part
    /// v = the imaginary part, (x, y, z)
    ///
    /// Note that we store the quaternion in a Vec4 as [x, y, z, w] because that makes
    /// it easy to extract the rotation axis of the quaternion:
    ///
    /// q = [cos(angle / 2), sin(angle / 2) * rotation_axis]
    /// Generated from class `JPH::Quat`.
    /// This is the non-const half of the class.
    public class Quat : Const_Quat
    {
        /// 4 vector that stores [x, y, z, w] parts of the quaternion
        public new unsafe JPH.Vec4 mValue
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_GetMutable_mValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_GetMutable_mValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec4._Underlying *__JPH_Quat_GetMutable_mValue(_Underlying *_this);
                JPH.Vec4 __ret;
                __ret = new(__JPH_Quat_GetMutable_mValue(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Quat(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Quat() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_DefaultConstruct();
            _UnderlyingPtr = __JPH_Quat_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Quat::Quat`.
        public unsafe Quat(JPH.Const_Quat inRHS) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_ConstructFromAnother(JPH.Quat._Underlying *inRHS);
            _UnderlyingPtr = __JPH_Quat_ConstructFromAnother(inRHS._UnderlyingPtr);
            _KeepAlive(inRHS);
        }

        /// Generated from constructor `JPH::Quat::Quat`.
        public Quat(Quat inRHS) : this((Const_Quat)inRHS) {}

        /// Generated from constructor `JPH::Quat::Quat`.
        public unsafe Quat(float inX, float inY, float inZ, float inW) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_Construct_4(float inX, float inY, float inZ, float inW);
            _UnderlyingPtr = __JPH_Quat_Construct_4(inX, inY, inZ, inW);
        }

        /// Generated from constructor `JPH::Quat::Quat`.
        public unsafe Quat(JPH.Const_Float4 inV) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_Construct_1_JPH_Float4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_Construct_1_JPH_Float4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_Construct_1_JPH_Float4(JPH.Const_Float4._Underlying *inV);
            _UnderlyingPtr = __JPH_Quat_Construct_1_JPH_Float4(inV._UnderlyingPtr);
        }

        /// Generated from constructor `JPH::Quat::Quat`.
        public unsafe Quat(JPH.Const_Vec4 inV) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_Construct_1_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_Construct_1_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_Construct_1_JPH_Vec4(JPH.Vec4._Underlying *inV);
            _UnderlyingPtr = __JPH_Quat_Construct_1_JPH_Vec4(inV._UnderlyingPtr);
        }

        /// Generated from method `JPH::Quat::operator=`.
        public unsafe JPH.Quat Assign(JPH.Const_Quat inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Quat_AssignFromAnother(_Underlying *_this, JPH.Quat._Underlying *inRHS);
            JPH.Quat __ret;
            __ret = new(__JPH_Quat_AssignFromAnother(_UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: false);
            _DiscardKeepAlive();
            _KeepAlive(inRHS);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Set individual components
        /// Generated from method `JPH::Quat::SetX`.
        public unsafe void SetX(float inX)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_SetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_SetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Quat_SetX(_Underlying *_this, float inX);
            __JPH_Quat_SetX(_UnderlyingPtr, inX);
        }

        /// Generated from method `JPH::Quat::SetY`.
        public unsafe void SetY(float inY)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_SetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_SetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Quat_SetY(_Underlying *_this, float inY);
            __JPH_Quat_SetY(_UnderlyingPtr, inY);
        }

        /// Generated from method `JPH::Quat::SetZ`.
        public unsafe void SetZ(float inZ)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_SetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_SetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Quat_SetZ(_Underlying *_this, float inZ);
            __JPH_Quat_SetZ(_UnderlyingPtr, inZ);
        }

        /// Generated from method `JPH::Quat::SetW`.
        public unsafe void SetW(float inW)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_SetW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_SetW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Quat_SetW(_Underlying *_this, float inW);
            __JPH_Quat_SetW(_UnderlyingPtr, inW);
        }

        /// Set all components
        /// Generated from method `JPH::Quat::Set`.
        public unsafe void Set(float inX, float inY, float inZ, float inW)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_Set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_Set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Quat_Set(_Underlying *_this, float inX, float inY, float inZ, float inW);
            __JPH_Quat_Set(_UnderlyingPtr, inX, inY, inZ, inW);
        }

        ///@}
        ///@name Additions / multiplications
        ///@{
        /// Generated from method `JPH::Quat::operator+=`.
        public unsafe void AddAssign(JPH.Const_Quat inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Quat_add_assign(_Underlying *_this, JPH.Quat._Underlying *inRHS);
            __JPH_Quat_add_assign(_UnderlyingPtr, inRHS._UnderlyingPtr);
        }

        /// Generated from method `JPH::Quat::operator-=`.
        public unsafe void SubAssign(JPH.Const_Quat inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Quat_sub_assign(_Underlying *_this, JPH.Quat._Underlying *inRHS);
            __JPH_Quat_sub_assign(_UnderlyingPtr, inRHS._UnderlyingPtr);
        }

        /// Generated from method `JPH::Quat::operator*=`.
        public unsafe void MulAssign(float inValue)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_mul_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_mul_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Quat_mul_assign(_Underlying *_this, float inValue);
            __JPH_Quat_mul_assign(_UnderlyingPtr, inValue);
        }

        /// Generated from method `JPH::Quat::operator/=`.
        public unsafe void DivAssign(float inValue)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Quat_div_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Quat_div_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Quat_div_assign(_Underlying *_this, float inValue);
            __JPH_Quat_div_assign(_UnderlyingPtr, inValue);
        }
    }

    /// This is used for optional parameters of class `Quat` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Quat`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Quat`/`Const_Quat` directly.
    public class _InOptMut_Quat
    {
        public Quat? Opt;

        public _InOptMut_Quat() {}
        public _InOptMut_Quat(Quat value) {Opt = value;}
        public static implicit operator _InOptMut_Quat(Quat value) {return new(value);}
    }

    /// This is used for optional parameters of class `Quat` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Quat`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Quat`/`Const_Quat` to pass it to the function.
    public class _InOptConst_Quat
    {
        public Const_Quat? Opt;

        public _InOptConst_Quat() {}
        public _InOptConst_Quat(Const_Quat value) {Opt = value;}
        public static implicit operator _InOptConst_Quat(Const_Quat value) {return new(value);}
    }
}
