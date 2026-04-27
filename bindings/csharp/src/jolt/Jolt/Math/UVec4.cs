// machine generated, do not edit
public static partial class JPH
{
    /// Generated from class `JPH::UVec4`.
    /// This is the const half of the class.
    public class Const_UVec4 : JPH.Object<Const_UVec4>, System.IDisposable, System.IEquatable<JPH.Const_UVec4>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_UVec4_Destroy(_Underlying *_this);
            __JPH_UVec4_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_UVec4() {Dispose(false);}

        internal unsafe Const_UVec4(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_UVec4() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_DefaultConstruct();
            _UnderlyingPtr = __JPH_UVec4_DefaultConstruct();
        }

        /// Generated from constructor `JPH::UVec4::UVec4`.
        public unsafe Const_UVec4(JPH.Const_UVec4 inRHS) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_ConstructFromAnother(JPH.UVec4._Underlying *inRHS);
            _UnderlyingPtr = __JPH_UVec4_ConstructFromAnother(inRHS._UnderlyingPtr);
            _KeepAlive(inRHS);
        }

        /// Generated from constructor `JPH::UVec4::UVec4`.
        public Const_UVec4(UVec4 inRHS) : this((Const_UVec4)inRHS) {}

        /// Create a vector from 4 integer components
        /// Generated from constructor `JPH::UVec4::UVec4`.
        public unsafe Const_UVec4(uint inX, uint inY, uint inZ, uint inW) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Construct_4(uint inX, uint inY, uint inZ, uint inW);
            _UnderlyingPtr = __JPH_UVec4_Construct_4(inX, inY, inZ, inW);
        }

        /// Generated from method `JPH::UVec4::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_UVec4_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_UVec4_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_UVec4_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_UVec4_size_t(inCount);
        }

        /// Generated from method `JPH::UVec4::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_UVec4_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_UVec4_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_UVec4_void_ptr(void *inPointer);
            __Jolt_delete_JPH_UVec4_void_ptr(inPointer);
        }

        /// Generated from method `JPH::UVec4::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_UVec4_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_UVec4_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_UVec4_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_UVec4_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::UVec4::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_UVec4_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_UVec4_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_UVec4_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_UVec4_size_t(inCount);
        }

        /// Generated from method `JPH::UVec4::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_UVec4_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_UVec4_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_UVec4_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_UVec4_void_ptr(inPointer);
        }

        /// Generated from method `JPH::UVec4::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_UVec4_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_UVec4_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_UVec4_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_UVec4_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::UVec4::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_UVec4_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_UVec4_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_UVec4_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_UVec4_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::UVec4::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_UVec4_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_UVec4_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_UVec4_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_UVec4_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::UVec4::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_UVec4_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_UVec4_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_UVec4_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_UVec4_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::UVec4::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_UVec4_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_UVec4_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_UVec4_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_UVec4_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Comparison
        /// Generated from method `JPH::UVec4::operator==`.
        public static unsafe bool operator==(JPH.Const_UVec4 _this, JPH.Const_UVec4 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_UVec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_UVec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_equal_JPH_UVec4(JPH.Const_UVec4._Underlying *_this, JPH.UVec4._Underlying *inV2);
            return __Jolt_equal_JPH_UVec4(_this._UnderlyingPtr, inV2._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(JPH.Const_UVec4 _this, JPH.Const_UVec4 inV2)
        {
            return !(_this == inV2);
        }

        /// Swizzle the elements in inV
        /// Generated from method `JPH::UVec4::Swizzle<0, 1, 3, 3>`.
        public unsafe JPH.UVec4 Swizzle_0_1_3_3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Swizzle_0_1_3_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Swizzle_0_1_3_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Swizzle_0_1_3_3(_Underlying *_this);
            return new(__JPH_UVec4_Swizzle_0_1_3_3(_UnderlyingPtr), is_owning: true);
        }

        /// Swizzle the elements in inV
        /// Generated from method `JPH::UVec4::Swizzle<0, 2, 3, 3>`.
        public unsafe JPH.UVec4 Swizzle_0_2_3_3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Swizzle_0_2_3_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Swizzle_0_2_3_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Swizzle_0_2_3_3(_Underlying *_this);
            return new(__JPH_UVec4_Swizzle_0_2_3_3(_UnderlyingPtr), is_owning: true);
        }

        /// Swizzle the elements in inV
        /// Generated from method `JPH::UVec4::Swizzle<1, 2, 3, 3>`.
        public unsafe JPH.UVec4 Swizzle_1_2_3_3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Swizzle_1_2_3_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Swizzle_1_2_3_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Swizzle_1_2_3_3(_Underlying *_this);
            return new(__JPH_UVec4_Swizzle_1_2_3_3(_UnderlyingPtr), is_owning: true);
        }

        /// Swizzle the elements in inV
        /// Generated from method `JPH::UVec4::Swizzle<1, 2, 2, 2>`.
        public unsafe JPH.UVec4 Swizzle_1_2_2_2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Swizzle_1_2_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Swizzle_1_2_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Swizzle_1_2_2_2(_Underlying *_this);
            return new(__JPH_UVec4_Swizzle_1_2_2_2(_UnderlyingPtr), is_owning: true);
        }

        /// Swizzle the elements in inV
        /// Generated from method `JPH::UVec4::Swizzle<0, 2, 2, 2>`.
        public unsafe JPH.UVec4 Swizzle_0_2_2_2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Swizzle_0_2_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Swizzle_0_2_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Swizzle_0_2_2_2(_Underlying *_this);
            return new(__JPH_UVec4_Swizzle_0_2_2_2(_UnderlyingPtr), is_owning: true);
        }

        /// Swizzle the elements in inV
        /// Generated from method `JPH::UVec4::Swizzle<2, 3, 0, 1>`.
        public unsafe JPH.UVec4 Swizzle_2_3_0_1()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Swizzle_2_3_0_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Swizzle_2_3_0_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Swizzle_2_3_0_1(_Underlying *_this);
            return new(__JPH_UVec4_Swizzle_2_3_0_1(_UnderlyingPtr), is_owning: true);
        }

        /// Swizzle the elements in inV
        /// Generated from method `JPH::UVec4::Swizzle<2, 3, 2, 3>`.
        public unsafe JPH.UVec4 Swizzle_2_3_2_3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Swizzle_2_3_2_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Swizzle_2_3_2_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Swizzle_2_3_2_3(_Underlying *_this);
            return new(__JPH_UVec4_Swizzle_2_3_2_3(_UnderlyingPtr), is_owning: true);
        }

        /// Swizzle the elements in inV
        /// Generated from method `JPH::UVec4::Swizzle<1, 0, 3, 2>`.
        public unsafe JPH.UVec4 Swizzle_1_0_3_2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Swizzle_1_0_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Swizzle_1_0_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Swizzle_1_0_3_2(_Underlying *_this);
            return new(__JPH_UVec4_Swizzle_1_0_3_2(_UnderlyingPtr), is_owning: true);
        }

        /// Swizzle the elements in inV
        /// Generated from method `JPH::UVec4::Swizzle<1, 1, 3, 3>`.
        public unsafe JPH.UVec4 Swizzle_1_1_3_3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Swizzle_1_1_3_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Swizzle_1_1_3_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Swizzle_1_1_3_3(_Underlying *_this);
            return new(__JPH_UVec4_Swizzle_1_1_3_3(_UnderlyingPtr), is_owning: true);
        }

        /// Swizzle the elements in inV
        /// Generated from method `JPH::UVec4::Swizzle<0, 2, 1, 3>`.
        public unsafe JPH.UVec4 Swizzle_0_2_1_3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Swizzle_0_2_1_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Swizzle_0_2_1_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Swizzle_0_2_1_3(_Underlying *_this);
            return new(__JPH_UVec4_Swizzle_0_2_1_3(_UnderlyingPtr), is_owning: true);
        }

        /// Swizzle the elements in inV
        /// Generated from method `JPH::UVec4::Swizzle<0, 2, 2, 3>`.
        public unsafe JPH.UVec4 Swizzle_0_2_2_3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Swizzle_0_2_2_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Swizzle_0_2_2_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Swizzle_0_2_2_3(_Underlying *_this);
            return new(__JPH_UVec4_Swizzle_0_2_2_3(_UnderlyingPtr), is_owning: true);
        }

        /// Swizzle the elements in inV
        /// Generated from method `JPH::UVec4::Swizzle<1, 2, 3, 2>`.
        public unsafe JPH.UVec4 Swizzle_1_2_3_2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Swizzle_1_2_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Swizzle_1_2_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Swizzle_1_2_3_2(_Underlying *_this);
            return new(__JPH_UVec4_Swizzle_1_2_3_2(_UnderlyingPtr), is_owning: true);
        }

        /// Swizzle the elements in inV
        /// Generated from method `JPH::UVec4::Swizzle<0, 2, 3, 2>`.
        public unsafe JPH.UVec4 Swizzle_0_2_3_2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Swizzle_0_2_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Swizzle_0_2_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Swizzle_0_2_3_2(_Underlying *_this);
            return new(__JPH_UVec4_Swizzle_0_2_3_2(_UnderlyingPtr), is_owning: true);
        }

        /// Swizzle the elements in inV
        /// Generated from method `JPH::UVec4::Swizzle<0, 1, 3, 2>`.
        public unsafe JPH.UVec4 Swizzle_0_1_3_2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Swizzle_0_1_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Swizzle_0_1_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Swizzle_0_1_3_2(_Underlying *_this);
            return new(__JPH_UVec4_Swizzle_0_1_3_2(_UnderlyingPtr), is_owning: true);
        }

        /// Vector with all zeros
        /// Generated from method `JPH::UVec4::sZero`.
        public static unsafe JPH.UVec4 SZero()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sZero();
            return new(__JPH_UVec4_sZero(), is_owning: true);
        }

        /// Replicate int inV across all components
        /// Generated from method `JPH::UVec4::sReplicate`.
        public static unsafe JPH.UVec4 SReplicate(uint inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sReplicate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sReplicate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sReplicate(uint inV);
            return new(__JPH_UVec4_sReplicate(inV), is_owning: true);
        }

        /// Load 1 int from memory and place it in the X component, zeros Y, Z and W
        /// Generated from method `JPH::UVec4::sLoadInt`.
        public static unsafe JPH.UVec4 SLoadInt(uint? inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sLoadInt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sLoadInt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sLoadInt(uint *inV);
            uint __deref_inV = inV.GetValueOrDefault();
            return new(__JPH_UVec4_sLoadInt(inV.HasValue ? &__deref_inV : null), is_owning: true);
        }

        /// Load 4 ints from memory
        /// Generated from method `JPH::UVec4::sLoadInt4`.
        public static unsafe JPH.UVec4 SLoadInt4(uint? inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sLoadInt4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sLoadInt4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sLoadInt4(uint *inV);
            uint __deref_inV = inV.GetValueOrDefault();
            return new(__JPH_UVec4_sLoadInt4(inV.HasValue ? &__deref_inV : null), is_owning: true);
        }

        /// Load 4 ints from memory, aligned to 16 bytes
        /// Generated from method `JPH::UVec4::sLoadInt4Aligned`.
        public static unsafe JPH.UVec4 SLoadInt4Aligned(uint? inV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sLoadInt4Aligned", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sLoadInt4Aligned", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sLoadInt4Aligned(uint *inV);
            uint __deref_inV = inV.GetValueOrDefault();
            return new(__JPH_UVec4_sLoadInt4Aligned(inV.HasValue ? &__deref_inV : null), is_owning: true);
        }

        /// Return the minimum value of each of the components
        /// Generated from method `JPH::UVec4::sMin`.
        public static unsafe JPH.UVec4 SMin(JPH.Const_UVec4 inV1, JPH.Const_UVec4 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sMin(JPH.UVec4._Underlying *inV1, JPH.UVec4._Underlying *inV2);
            return new(__JPH_UVec4_sMin(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
        }

        /// Return the maximum of each of the components
        /// Generated from method `JPH::UVec4::sMax`.
        public static unsafe JPH.UVec4 SMax(JPH.Const_UVec4 inV1, JPH.Const_UVec4 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sMax(JPH.UVec4._Underlying *inV1, JPH.UVec4._Underlying *inV2);
            return new(__JPH_UVec4_sMax(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
        }

        /// Equals (component wise)
        /// Generated from method `JPH::UVec4::sEquals`.
        public static unsafe JPH.UVec4 SEquals(JPH.Const_UVec4 inV1, JPH.Const_UVec4 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sEquals", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sEquals", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sEquals(JPH.UVec4._Underlying *inV1, JPH.UVec4._Underlying *inV2);
            return new(__JPH_UVec4_sEquals(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
        }

        /// Component wise select, returns inNotSet when highest bit of inControl = 0 and inSet when highest bit of inControl = 1
        /// Generated from method `JPH::UVec4::sSelect`.
        public static unsafe JPH.UVec4 SSelect(JPH.Const_UVec4 inNotSet, JPH.Const_UVec4 inSet, JPH.Const_UVec4 inControl)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sSelect", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sSelect", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sSelect(JPH.UVec4._Underlying *inNotSet, JPH.UVec4._Underlying *inSet, JPH.UVec4._Underlying *inControl);
            return new(__JPH_UVec4_sSelect(inNotSet._UnderlyingPtr, inSet._UnderlyingPtr, inControl._UnderlyingPtr), is_owning: true);
        }

        /// Logical or (component wise)
        /// Generated from method `JPH::UVec4::sOr`.
        public static unsafe JPH.UVec4 SOr(JPH.Const_UVec4 inV1, JPH.Const_UVec4 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sOr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sOr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sOr(JPH.UVec4._Underlying *inV1, JPH.UVec4._Underlying *inV2);
            return new(__JPH_UVec4_sOr(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
        }

        /// Logical xor (component wise)
        /// Generated from method `JPH::UVec4::sXor`.
        public static unsafe JPH.UVec4 SXor(JPH.Const_UVec4 inV1, JPH.Const_UVec4 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sXor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sXor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sXor(JPH.UVec4._Underlying *inV1, JPH.UVec4._Underlying *inV2);
            return new(__JPH_UVec4_sXor(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
        }

        /// Logical and (component wise)
        /// Generated from method `JPH::UVec4::sAnd`.
        public static unsafe JPH.UVec4 SAnd(JPH.Const_UVec4 inV1, JPH.Const_UVec4 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sAnd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sAnd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sAnd(JPH.UVec4._Underlying *inV1, JPH.UVec4._Underlying *inV2);
            return new(__JPH_UVec4_sAnd(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
        }

        /// Logical not (component wise)
        /// Generated from method `JPH::UVec4::sNot`.
        public static unsafe JPH.UVec4 SNot(JPH.Const_UVec4 inV1)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sNot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sNot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sNot(JPH.UVec4._Underlying *inV1);
            return new(__JPH_UVec4_sNot(inV1._UnderlyingPtr), is_owning: true);
        }

        /// Sorts the elements in inIndex so that the values that correspond to trues in inValue are the first elements.
        /// The remaining elements will be set to inValue.w.
        /// I.e. if inValue = (true, false, true, false) and inIndex = (1, 2, 3, 4) the function returns (1, 3, 4, 4).
        /// Generated from method `JPH::UVec4::sSort4True`.
        public static unsafe JPH.UVec4 SSort4True(JPH.Const_UVec4 inValue, JPH.Const_UVec4 inIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sSort4True", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sSort4True", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sSort4True(JPH.UVec4._Underlying *inValue, JPH.UVec4._Underlying *inIndex);
            return new(__JPH_UVec4_sSort4True(inValue._UnderlyingPtr, inIndex._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::UVec4::GetX`.
        public unsafe uint GetX()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_GetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_GetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_UVec4_GetX(_Underlying *_this);
            return __JPH_UVec4_GetX(_UnderlyingPtr);
        }

        /// Generated from method `JPH::UVec4::GetY`.
        public unsafe uint GetY()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_GetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_GetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_UVec4_GetY(_Underlying *_this);
            return __JPH_UVec4_GetY(_UnderlyingPtr);
        }

        /// Generated from method `JPH::UVec4::GetZ`.
        public unsafe uint GetZ()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_GetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_GetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_UVec4_GetZ(_Underlying *_this);
            return __JPH_UVec4_GetZ(_UnderlyingPtr);
        }

        /// Generated from method `JPH::UVec4::GetW`.
        public unsafe uint GetW()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_GetW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_GetW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_UVec4_GetW(_Underlying *_this);
            return __JPH_UVec4_GetW(_UnderlyingPtr);
        }

        /// Get component by index
        /// Generated from method `JPH::UVec4::operator[]`.
        public unsafe uint this[uint inCoordinate]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_UVec4_index(_Underlying *_this, uint inCoordinate);
                return __JPH_UVec4_index(_UnderlyingPtr, inCoordinate);
            }
        }

        /// Component wise multiplication of two integer vectors (stores low 32 bits of result only)
        /// Generated from method `JPH::UVec4::operator*`.
        public static unsafe JPH.UVec4 operator*(JPH.Const_UVec4 _this, JPH.Const_UVec4 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_UVec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_UVec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__Jolt_mul_JPH_UVec4(JPH.Const_UVec4._Underlying *_this, JPH.UVec4._Underlying *inV2);
            return new(__Jolt_mul_JPH_UVec4(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
        }

        /// Add two integer vectors (component wise)
        /// Generated from method `JPH::UVec4::operator+`.
        public static unsafe JPH.UVec4 operator+(JPH.Const_UVec4 _this, JPH.Const_UVec4 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_add_JPH_UVec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_add_JPH_UVec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__Jolt_add_JPH_UVec4(JPH.Const_UVec4._Underlying *_this, JPH.UVec4._Underlying *inV2);
            return new(__Jolt_add_JPH_UVec4(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
        }

        /// Subtract two integer vectors (component wise)
        /// Generated from method `JPH::UVec4::operator-`.
        public static unsafe JPH.UVec4 operator-(JPH.Const_UVec4 _this, JPH.Const_UVec4 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_sub_JPH_UVec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_sub_JPH_UVec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__Jolt_sub_JPH_UVec4(JPH.Const_UVec4._Underlying *_this, JPH.UVec4._Underlying *inV2);
            return new(__Jolt_sub_JPH_UVec4(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
        }

        /// Replicate the X component to all components
        /// Generated from method `JPH::UVec4::SplatX`.
        public unsafe JPH.UVec4 SplatX()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_SplatX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_SplatX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_SplatX(_Underlying *_this);
            return new(__JPH_UVec4_SplatX(_UnderlyingPtr), is_owning: true);
        }

        /// Replicate the Y component to all components
        /// Generated from method `JPH::UVec4::SplatY`.
        public unsafe JPH.UVec4 SplatY()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_SplatY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_SplatY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_SplatY(_Underlying *_this);
            return new(__JPH_UVec4_SplatY(_UnderlyingPtr), is_owning: true);
        }

        /// Replicate the Z component to all components
        /// Generated from method `JPH::UVec4::SplatZ`.
        public unsafe JPH.UVec4 SplatZ()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_SplatZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_SplatZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_SplatZ(_Underlying *_this);
            return new(__JPH_UVec4_SplatZ(_UnderlyingPtr), is_owning: true);
        }

        /// Replicate the W component to all components
        /// Generated from method `JPH::UVec4::SplatW`.
        public unsafe JPH.UVec4 SplatW()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_SplatW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_SplatW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_SplatW(_Underlying *_this);
            return new(__JPH_UVec4_SplatW(_UnderlyingPtr), is_owning: true);
        }

        /// Convert each component from an int to a float
        /// Generated from method `JPH::UVec4::ToFloat`.
        public unsafe JPH.Vec4 ToFloat()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_ToFloat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_ToFloat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec4._Underlying *__JPH_UVec4_ToFloat(_Underlying *_this);
            return new(__JPH_UVec4_ToFloat(_UnderlyingPtr), is_owning: true);
        }

        /// Reinterpret UVec4 as a Vec4 (doesn't change the bits)
        /// Generated from method `JPH::UVec4::ReinterpretAsFloat`.
        public unsafe JPH.Vec4 ReinterpretAsFloat()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_ReinterpretAsFloat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_ReinterpretAsFloat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec4._Underlying *__JPH_UVec4_ReinterpretAsFloat(_Underlying *_this);
            return new(__JPH_UVec4_ReinterpretAsFloat(_UnderlyingPtr), is_owning: true);
        }

        /// Dot product, returns the dot product in X, Y, Z and W components
        /// Generated from method `JPH::UVec4::DotV`.
        public unsafe JPH.UVec4 DotV(JPH.Const_UVec4 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_DotV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_DotV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_DotV(_Underlying *_this, JPH.UVec4._Underlying *inV2);
            return new(__JPH_UVec4_DotV(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
        }

        /// Dot product
        /// Generated from method `JPH::UVec4::Dot`.
        public unsafe uint Dot(JPH.Const_UVec4 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_UVec4_Dot(_Underlying *_this, JPH.UVec4._Underlying *inV2);
            return __JPH_UVec4_Dot(_UnderlyingPtr, inV2._UnderlyingPtr);
        }

        /// Store 4 ints to memory
        /// Generated from method `JPH::UVec4::StoreInt4`.
        public unsafe void StoreInt4(JPH.InOut<uint>? outV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_StoreInt4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_StoreInt4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_UVec4_StoreInt4(_Underlying *_this, uint *outV);
            uint __value_outV = outV is not null ? outV.Value : default(uint);
            if (outV is not null) outV.Value = __value_outV;
            __JPH_UVec4_StoreInt4(_UnderlyingPtr, outV is not null ? &__value_outV : null);
        }

        /// Store 4 ints to memory, aligned to 16 bytes
        /// Generated from method `JPH::UVec4::StoreInt4Aligned`.
        public unsafe void StoreInt4Aligned(JPH.InOut<uint>? outV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_StoreInt4Aligned", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_StoreInt4Aligned", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_UVec4_StoreInt4Aligned(_Underlying *_this, uint *outV);
            uint __value_outV = outV is not null ? outV.Value : default(uint);
            if (outV is not null) outV.Value = __value_outV;
            __JPH_UVec4_StoreInt4Aligned(_UnderlyingPtr, outV is not null ? &__value_outV : null);
        }

        /// Test if any of the components are true (true is when highest bit of component is set)
        /// Generated from method `JPH::UVec4::TestAnyTrue`.
        public unsafe bool TestAnyTrue()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_TestAnyTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_TestAnyTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_UVec4_TestAnyTrue(_Underlying *_this);
            return __JPH_UVec4_TestAnyTrue(_UnderlyingPtr) != 0;
        }

        /// Test if any of X, Y or Z components are true (true is when highest bit of component is set)
        /// Generated from method `JPH::UVec4::TestAnyXYZTrue`.
        public unsafe bool TestAnyXYZTrue()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_TestAnyXYZTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_TestAnyXYZTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_UVec4_TestAnyXYZTrue(_Underlying *_this);
            return __JPH_UVec4_TestAnyXYZTrue(_UnderlyingPtr) != 0;
        }

        /// Test if all components are true (true is when highest bit of component is set)
        /// Generated from method `JPH::UVec4::TestAllTrue`.
        public unsafe bool TestAllTrue()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_TestAllTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_TestAllTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_UVec4_TestAllTrue(_Underlying *_this);
            return __JPH_UVec4_TestAllTrue(_UnderlyingPtr) != 0;
        }

        /// Test if X, Y and Z components are true (true is when highest bit of component is set)
        /// Generated from method `JPH::UVec4::TestAllXYZTrue`.
        public unsafe bool TestAllXYZTrue()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_TestAllXYZTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_TestAllXYZTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_UVec4_TestAllXYZTrue(_Underlying *_this);
            return __JPH_UVec4_TestAllXYZTrue(_UnderlyingPtr) != 0;
        }

        /// Count the number of components that are true (true is when highest bit of component is set)
        /// Generated from method `JPH::UVec4::CountTrues`.
        public unsafe int CountTrues()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_CountTrues", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_CountTrues", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_UVec4_CountTrues(_Underlying *_this);
            return __JPH_UVec4_CountTrues(_UnderlyingPtr);
        }

        /// Store if X is true in bit 0, Y in bit 1, Z in bit 2 and W in bit 3 (true is when highest bit of component is set)
        /// Generated from method `JPH::UVec4::GetTrues`.
        public unsafe int GetTrues()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_GetTrues", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_GetTrues", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_UVec4_GetTrues(_Underlying *_this);
            return __JPH_UVec4_GetTrues(_UnderlyingPtr);
        }

        /// Shift all components by Count bits to the left (filling with zeros from the left)
        /// Generated from method `JPH::UVec4::LogicalShiftLeft<31>`.
        public unsafe JPH.UVec4 LogicalShiftLeft_31()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_LogicalShiftLeft_31", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_LogicalShiftLeft_31", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_LogicalShiftLeft_31(_Underlying *_this);
            return new(__JPH_UVec4_LogicalShiftLeft_31(_UnderlyingPtr), is_owning: true);
        }

        /// Shift all components by Count bits to the left (filling with zeros from the left)
        /// Generated from method `JPH::UVec4::LogicalShiftLeft<30>`.
        public unsafe JPH.UVec4 LogicalShiftLeft_30()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_LogicalShiftLeft_30", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_LogicalShiftLeft_30", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_LogicalShiftLeft_30(_Underlying *_this);
            return new(__JPH_UVec4_LogicalShiftLeft_30(_UnderlyingPtr), is_owning: true);
        }

        /// Shift all components by Count bits to the left (filling with zeros from the left)
        /// Generated from method `JPH::UVec4::LogicalShiftLeft<13>`.
        public unsafe JPH.UVec4 LogicalShiftLeft_13()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_LogicalShiftLeft_13", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_LogicalShiftLeft_13", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_LogicalShiftLeft_13(_Underlying *_this);
            return new(__JPH_UVec4_LogicalShiftLeft_13(_UnderlyingPtr), is_owning: true);
        }

        /// Shift all components by Count bits to the left (filling with zeros from the left)
        /// Generated from method `JPH::UVec4::LogicalShiftLeft<16>`.
        public unsafe JPH.UVec4 LogicalShiftLeft_16()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_LogicalShiftLeft_16", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_LogicalShiftLeft_16", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_LogicalShiftLeft_16(_Underlying *_this);
            return new(__JPH_UVec4_LogicalShiftLeft_16(_UnderlyingPtr), is_owning: true);
        }

        /// Shift all components by Count bits to the right (shifting in the value of the highest bit)
        /// Generated from method `JPH::UVec4::ArithmeticShiftRight<31>`.
        public unsafe JPH.UVec4 ArithmeticShiftRight()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_ArithmeticShiftRight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_ArithmeticShiftRight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_ArithmeticShiftRight(_Underlying *_this);
            return new(__JPH_UVec4_ArithmeticShiftRight(_UnderlyingPtr), is_owning: true);
        }

        /// Takes the lower 4 16 bits and expands them to X, Y, Z and W
        /// Generated from method `JPH::UVec4::Expand4Uint16Lo`.
        public unsafe JPH.UVec4 Expand4Uint16Lo()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Expand4Uint16Lo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Expand4Uint16Lo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Expand4Uint16Lo(_Underlying *_this);
            return new(__JPH_UVec4_Expand4Uint16Lo(_UnderlyingPtr), is_owning: true);
        }

        /// Takes the upper 4 16 bits and expands them to X, Y, Z and W
        /// Generated from method `JPH::UVec4::Expand4Uint16Hi`.
        public unsafe JPH.UVec4 Expand4Uint16Hi()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Expand4Uint16Hi", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Expand4Uint16Hi", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Expand4Uint16Hi(_Underlying *_this);
            return new(__JPH_UVec4_Expand4Uint16Hi(_UnderlyingPtr), is_owning: true);
        }

        /// Takes byte 0 .. 3 and expands them to X, Y, Z and W
        /// Generated from method `JPH::UVec4::Expand4Byte0`.
        public unsafe JPH.UVec4 Expand4Byte0()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Expand4Byte0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Expand4Byte0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Expand4Byte0(_Underlying *_this);
            return new(__JPH_UVec4_Expand4Byte0(_UnderlyingPtr), is_owning: true);
        }

        /// Takes byte 4 .. 7 and expands them to X, Y, Z and W
        /// Generated from method `JPH::UVec4::Expand4Byte4`.
        public unsafe JPH.UVec4 Expand4Byte4()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Expand4Byte4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Expand4Byte4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Expand4Byte4(_Underlying *_this);
            return new(__JPH_UVec4_Expand4Byte4(_UnderlyingPtr), is_owning: true);
        }

        /// Takes byte 8 .. 11 and expands them to X, Y, Z and W
        /// Generated from method `JPH::UVec4::Expand4Byte8`.
        public unsafe JPH.UVec4 Expand4Byte8()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Expand4Byte8", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Expand4Byte8", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Expand4Byte8(_Underlying *_this);
            return new(__JPH_UVec4_Expand4Byte8(_UnderlyingPtr), is_owning: true);
        }

        /// Takes byte 12 .. 15 and expands them to X, Y, Z and W
        /// Generated from method `JPH::UVec4::Expand4Byte12`.
        public unsafe JPH.UVec4 Expand4Byte12()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Expand4Byte12", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Expand4Byte12", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Expand4Byte12(_Underlying *_this);
            return new(__JPH_UVec4_Expand4Byte12(_UnderlyingPtr), is_owning: true);
        }

        /// Shift vector components by 4 - Count floats to the left, so if Count = 1 the resulting vector is (W, 0, 0, 0), when Count = 3 the resulting vector is (Y, Z, W, 0)
        /// Generated from method `JPH::UVec4::ShiftComponents4Minus`.
        public unsafe JPH.UVec4 ShiftComponents4Minus(int inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_ShiftComponents4Minus", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_ShiftComponents4Minus", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_ShiftComponents4Minus(_Underlying *_this, int inCount);
            return new(__JPH_UVec4_ShiftComponents4Minus(_UnderlyingPtr, inCount), is_owning: true);
        }

        // IEquatable:

        public bool Equals(JPH.Const_UVec4? inV2)
        {
            if (inV2 is null)
                return false;
            return this == inV2;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is JPH.Const_UVec4)
                return this == (JPH.Const_UVec4)other;
            return false;
        }
    }

    /// Generated from class `JPH::UVec4`.
    /// This is the non-const half of the class.
    public class UVec4 : Const_UVec4
    {
        internal unsafe UVec4(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe UVec4() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_DefaultConstruct();
            _UnderlyingPtr = __JPH_UVec4_DefaultConstruct();
        }

        /// Generated from constructor `JPH::UVec4::UVec4`.
        public unsafe UVec4(JPH.Const_UVec4 inRHS) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_ConstructFromAnother(JPH.UVec4._Underlying *inRHS);
            _UnderlyingPtr = __JPH_UVec4_ConstructFromAnother(inRHS._UnderlyingPtr);
            _KeepAlive(inRHS);
        }

        /// Generated from constructor `JPH::UVec4::UVec4`.
        public UVec4(UVec4 inRHS) : this((Const_UVec4)inRHS) {}

        /// Create a vector from 4 integer components
        /// Generated from constructor `JPH::UVec4::UVec4`.
        public unsafe UVec4(uint inX, uint inY, uint inZ, uint inW) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_Construct_4(uint inX, uint inY, uint inZ, uint inW);
            _UnderlyingPtr = __JPH_UVec4_Construct_4(inX, inY, inZ, inW);
        }

        /// Generated from method `JPH::UVec4::operator=`.
        public unsafe JPH.UVec4 Assign(JPH.Const_UVec4 inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_AssignFromAnother(_Underlying *_this, JPH.UVec4._Underlying *inRHS);
            JPH.UVec4 __ret;
            __ret = new(__JPH_UVec4_AssignFromAnother(_UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: false);
            _DiscardKeepAlive();
            _KeepAlive(inRHS);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Set individual components
        /// Generated from method `JPH::UVec4::SetX`.
        public unsafe void SetX(uint inX)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_SetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_SetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_UVec4_SetX(_Underlying *_this, uint inX);
            __JPH_UVec4_SetX(_UnderlyingPtr, inX);
        }

        /// Generated from method `JPH::UVec4::SetY`.
        public unsafe void SetY(uint inY)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_SetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_SetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_UVec4_SetY(_Underlying *_this, uint inY);
            __JPH_UVec4_SetY(_UnderlyingPtr, inY);
        }

        /// Generated from method `JPH::UVec4::SetZ`.
        public unsafe void SetZ(uint inZ)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_SetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_SetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_UVec4_SetZ(_Underlying *_this, uint inZ);
            __JPH_UVec4_SetZ(_UnderlyingPtr, inZ);
        }

        /// Generated from method `JPH::UVec4::SetW`.
        public unsafe void SetW(uint inW)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_SetW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_SetW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_UVec4_SetW(_Underlying *_this, uint inW);
            __JPH_UVec4_SetW(_UnderlyingPtr, inW);
        }

        /// Generated from method `JPH::UVec4::operator[]`.
        public unsafe new ref uint this[uint inCoordinate]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_index_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_index_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_UVec4_index_mut(_Underlying *_this, uint inCoordinate);
                return ref *__JPH_UVec4_index_mut(_UnderlyingPtr, inCoordinate);
            }
        }

        /// Add two integer vectors (component wise)
        /// Generated from method `JPH::UVec4::operator+=`.
        public unsafe JPH.UVec4 AddAssign(JPH.Const_UVec4 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_add_assign(_Underlying *_this, JPH.UVec4._Underlying *inV2);
            JPH.UVec4 __ret;
            __ret = new(__JPH_UVec4_add_assign(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Subtract two integer vectors (component wise)
        /// Generated from method `JPH::UVec4::operator-=`.
        public unsafe JPH.UVec4 SubAssign(JPH.Const_UVec4 inV2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_UVec4_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_UVec4_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.UVec4._Underlying *__JPH_UVec4_sub_assign(_Underlying *_this, JPH.UVec4._Underlying *inV2);
            JPH.UVec4 __ret;
            __ret = new(__JPH_UVec4_sub_assign(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used for optional parameters of class `UVec4` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_UVec4`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `UVec4`/`Const_UVec4` directly.
    public class _InOptMut_UVec4
    {
        public UVec4? Opt;

        public _InOptMut_UVec4() {}
        public _InOptMut_UVec4(UVec4 value) {Opt = value;}
        public static implicit operator _InOptMut_UVec4(UVec4 value) {return new(value);}
    }

    /// This is used for optional parameters of class `UVec4` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_UVec4`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `UVec4`/`Const_UVec4` to pass it to the function.
    public class _InOptConst_UVec4
    {
        public Const_UVec4? Opt;

        public _InOptConst_UVec4() {}
        public _InOptConst_UVec4(Const_UVec4 value) {Opt = value;}
        public static implicit operator _InOptConst_UVec4(Const_UVec4 value) {return new(value);}
    }
}
