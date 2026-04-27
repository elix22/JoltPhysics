// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Generated from class `JPH::Vec4`.
        /// This is the const half of the class.
        public class Const_Vec4 : Jolt.Object<Const_Vec4>, System.IDisposable, System.IEquatable<Jolt.JPH.Const_Vec4>
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec4_Destroy(_Underlying *_this);
                __JPH_Vec4_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Vec4() {Dispose(false);}

            internal unsafe Const_Vec4(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Vec4() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_DefaultConstruct();
                _UnderlyingPtr = __JPH_Vec4_DefaultConstruct();
            }

            /// Generated from constructor `JPH::Vec4::Vec4`.
            public unsafe Const_Vec4(Jolt.JPH.Const_Vec4 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_ConstructFromAnother(Jolt.JPH.Vec4._Underlying *inRHS);
                _UnderlyingPtr = __JPH_Vec4_ConstructFromAnother(inRHS._UnderlyingPtr);
                _KeepAlive(inRHS);
            }

            /// Generated from constructor `JPH::Vec4::Vec4`.
            public Const_Vec4(Vec4 inRHS) : this((Const_Vec4)inRHS) {}

            // Constructor
            /// Generated from constructor `JPH::Vec4::Vec4`.
            public unsafe Const_Vec4(Jolt.JPH.Const_Vec3 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Construct_1_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Construct_1_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Construct_1_JPH_Vec3(Jolt.JPH.Vec3._Underlying *inRHS);
                _UnderlyingPtr = __JPH_Vec4_Construct_1_JPH_Vec3(inRHS._UnderlyingPtr);
            }

            /// Generated from constructor `JPH::Vec4::Vec4`.
            public unsafe Const_Vec4(Jolt.JPH.Const_Vec3 inRHS, float inW) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Construct_2(Jolt.JPH.Vec3._Underlying *inRHS, float inW);
                _UnderlyingPtr = __JPH_Vec4_Construct_2(inRHS._UnderlyingPtr, inW);
            }

            /// Create a vector from 4 components
            /// Generated from constructor `JPH::Vec4::Vec4`.
            public unsafe Const_Vec4(float inX, float inY, float inZ, float inW) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Construct_4(float inX, float inY, float inZ, float inW);
                _UnderlyingPtr = __JPH_Vec4_Construct_4(inX, inY, inZ, inW);
            }

            /// Generated from method `JPH::Vec4::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Vec4_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Vec4_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_Vec4_size_t(ulong inCount);
                return __Jolt_new_JPH_Vec4_size_t(inCount);
            }

            /// Generated from method `JPH::Vec4::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Vec4_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Vec4_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Vec4_void_ptr(void *inPointer);
                __Jolt_delete_JPH_Vec4_void_ptr(inPointer);
            }

            /// Generated from method `JPH::Vec4::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Vec4_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Vec4_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Vec4_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_Vec4_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::Vec4::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Vec4_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Vec4_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_Vec4_size_t(ulong inCount);
                return __Jolt_new_array_JPH_Vec4_size_t(inCount);
            }

            /// Generated from method `JPH::Vec4::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Vec4_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Vec4_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Vec4_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_Vec4_void_ptr(inPointer);
            }

            /// Generated from method `JPH::Vec4::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Vec4_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Vec4_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Vec4_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_Vec4_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::Vec4::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Vec4_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Vec4_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_Vec4_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_Vec4_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::Vec4::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Vec4_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Vec4_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Vec4_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_Vec4_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::Vec4::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Vec4_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Vec4_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_Vec4_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_Vec4_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::Vec4::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Vec4_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Vec4_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Vec4_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_Vec4_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Vector with all zeros
            /// Generated from method `JPH::Vec4::sZero`.
            public static unsafe Jolt.JPH.Vec4 SZero()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sZero();
                return new(__JPH_Vec4_sZero(), is_owning: true);
            }

            /// Vector with all ones
            /// Generated from method `JPH::Vec4::sOne`.
            public static unsafe Jolt.JPH.Vec4 SOne()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sOne", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sOne", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sOne();
                return new(__JPH_Vec4_sOne(), is_owning: true);
            }

            /// Vector with all NaN's
            /// Generated from method `JPH::Vec4::sNaN`.
            public static unsafe Jolt.JPH.Vec4 SNaN()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sNaN();
                return new(__JPH_Vec4_sNaN(), is_owning: true);
            }

            /// Replicate inV across all components
            /// Generated from method `JPH::Vec4::sReplicate`.
            public static unsafe Jolt.JPH.Vec4 SReplicate(float inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sReplicate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sReplicate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sReplicate(float inV);
                return new(__JPH_Vec4_sReplicate(inV), is_owning: true);
            }

            /// Load 4 floats from memory
            /// Generated from method `JPH::Vec4::sLoadFloat4`.
            public static unsafe Jolt.JPH.Vec4 SLoadFloat4(Jolt.JPH.Const_Float4? inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sLoadFloat4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sLoadFloat4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sLoadFloat4(Jolt.JPH.Const_Float4._Underlying *inV);
                return new(__JPH_Vec4_sLoadFloat4(inV is not null ? inV._UnderlyingPtr : null), is_owning: true);
            }

            /// Load 4 floats from memory, 16 bytes aligned
            /// Generated from method `JPH::Vec4::sLoadFloat4Aligned`.
            public static unsafe Jolt.JPH.Vec4 SLoadFloat4Aligned(Jolt.JPH.Const_Float4? inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sLoadFloat4Aligned", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sLoadFloat4Aligned", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sLoadFloat4Aligned(Jolt.JPH.Const_Float4._Underlying *inV);
                return new(__JPH_Vec4_sLoadFloat4Aligned(inV is not null ? inV._UnderlyingPtr : null), is_owning: true);
            }

            /// Return the minimum value of each of the components
            /// Generated from method `JPH::Vec4::sMin`.
            public static unsafe Jolt.JPH.Vec4 SMin(Jolt.JPH.Const_Vec4 inV1, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sMin(Jolt.JPH.Vec4._Underlying *inV1, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__JPH_Vec4_sMin(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Return the maximum of each of the components
            /// Generated from method `JPH::Vec4::sMax`.
            public static unsafe Jolt.JPH.Vec4 SMax(Jolt.JPH.Const_Vec4 inV1, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sMax(Jolt.JPH.Vec4._Underlying *inV1, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__JPH_Vec4_sMax(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Clamp a vector between min and max (component wise)
            /// Generated from method `JPH::Vec4::sClamp`.
            public static unsafe Jolt.JPH.Vec4 SClamp(Jolt.JPH.Const_Vec4 inV, Jolt.JPH.Const_Vec4 inMin, Jolt.JPH.Const_Vec4 inMax)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sClamp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sClamp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sClamp(Jolt.JPH.Vec4._Underlying *inV, Jolt.JPH.Vec4._Underlying *inMin, Jolt.JPH.Vec4._Underlying *inMax);
                return new(__JPH_Vec4_sClamp(inV._UnderlyingPtr, inMin._UnderlyingPtr, inMax._UnderlyingPtr), is_owning: true);
            }

            /// Equals (component wise)
            /// Generated from method `JPH::Vec4::sEquals`.
            public static unsafe Jolt.JPH.UVec4 SEquals(Jolt.JPH.Const_Vec4 inV1, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sEquals", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sEquals", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.UVec4._Underlying *__JPH_Vec4_sEquals(Jolt.JPH.Vec4._Underlying *inV1, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__JPH_Vec4_sEquals(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Less than (component wise)
            /// Generated from method `JPH::Vec4::sLess`.
            public static unsafe Jolt.JPH.UVec4 SLess(Jolt.JPH.Const_Vec4 inV1, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sLess", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sLess", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.UVec4._Underlying *__JPH_Vec4_sLess(Jolt.JPH.Vec4._Underlying *inV1, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__JPH_Vec4_sLess(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Less than or equal (component wise)
            /// Generated from method `JPH::Vec4::sLessOrEqual`.
            public static unsafe Jolt.JPH.UVec4 SLessOrEqual(Jolt.JPH.Const_Vec4 inV1, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sLessOrEqual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sLessOrEqual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.UVec4._Underlying *__JPH_Vec4_sLessOrEqual(Jolt.JPH.Vec4._Underlying *inV1, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__JPH_Vec4_sLessOrEqual(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Greater than (component wise)
            /// Generated from method `JPH::Vec4::sGreater`.
            public static unsafe Jolt.JPH.UVec4 SGreater(Jolt.JPH.Const_Vec4 inV1, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sGreater", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sGreater", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.UVec4._Underlying *__JPH_Vec4_sGreater(Jolt.JPH.Vec4._Underlying *inV1, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__JPH_Vec4_sGreater(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Greater than or equal (component wise)
            /// Generated from method `JPH::Vec4::sGreaterOrEqual`.
            public static unsafe Jolt.JPH.UVec4 SGreaterOrEqual(Jolt.JPH.Const_Vec4 inV1, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sGreaterOrEqual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sGreaterOrEqual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.UVec4._Underlying *__JPH_Vec4_sGreaterOrEqual(Jolt.JPH.Vec4._Underlying *inV1, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__JPH_Vec4_sGreaterOrEqual(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Calculates inMul1 * inMul2 + inAdd
            /// Generated from method `JPH::Vec4::sFusedMultiplyAdd`.
            public static unsafe Jolt.JPH.Vec4 SFusedMultiplyAdd(Jolt.JPH.Const_Vec4 inMul1, Jolt.JPH.Const_Vec4 inMul2, Jolt.JPH.Const_Vec4 inAdd)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sFusedMultiplyAdd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sFusedMultiplyAdd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sFusedMultiplyAdd(Jolt.JPH.Vec4._Underlying *inMul1, Jolt.JPH.Vec4._Underlying *inMul2, Jolt.JPH.Vec4._Underlying *inAdd);
                return new(__JPH_Vec4_sFusedMultiplyAdd(inMul1._UnderlyingPtr, inMul2._UnderlyingPtr, inAdd._UnderlyingPtr), is_owning: true);
            }

            /// Component wise select, returns inNotSet when highest bit of inControl = 0 and inSet when highest bit of inControl = 1
            /// Generated from method `JPH::Vec4::sSelect`.
            public static unsafe Jolt.JPH.Vec4 SSelect(Jolt.JPH.Const_Vec4 inNotSet, Jolt.JPH.Const_Vec4 inSet, Jolt.JPH.Const_UVec4 inControl)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sSelect", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sSelect", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sSelect(Jolt.JPH.Vec4._Underlying *inNotSet, Jolt.JPH.Vec4._Underlying *inSet, Jolt.JPH.UVec4._Underlying *inControl);
                return new(__JPH_Vec4_sSelect(inNotSet._UnderlyingPtr, inSet._UnderlyingPtr, inControl._UnderlyingPtr), is_owning: true);
            }

            /// Logical or (component wise)
            /// Generated from method `JPH::Vec4::sOr`.
            public static unsafe Jolt.JPH.Vec4 SOr(Jolt.JPH.Const_Vec4 inV1, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sOr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sOr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sOr(Jolt.JPH.Vec4._Underlying *inV1, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__JPH_Vec4_sOr(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Logical xor (component wise)
            /// Generated from method `JPH::Vec4::sXor`.
            public static unsafe Jolt.JPH.Vec4 SXor(Jolt.JPH.Const_Vec4 inV1, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sXor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sXor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sXor(Jolt.JPH.Vec4._Underlying *inV1, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__JPH_Vec4_sXor(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Logical and (component wise)
            /// Generated from method `JPH::Vec4::sAnd`.
            public static unsafe Jolt.JPH.Vec4 SAnd(Jolt.JPH.Const_Vec4 inV1, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sAnd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sAnd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sAnd(Jolt.JPH.Vec4._Underlying *inV1, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__JPH_Vec4_sAnd(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Sort the four elements of ioValue and sort ioIndex at the same time.
            /// Based on a sorting network: http://en.wikipedia.org/wiki/Sorting_network
            /// Generated from method `JPH::Vec4::sSort4`.
            public static unsafe void SSort4(Jolt.JPH.Vec4 ioValue, Jolt.JPH.UVec4 ioIndex)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sSort4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sSort4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec4_sSort4(Jolt.JPH.Vec4._Underlying *ioValue, Jolt.JPH.UVec4._Underlying *ioIndex);
                __JPH_Vec4_sSort4(ioValue._UnderlyingPtr, ioIndex._UnderlyingPtr);
            }

            /// Reverse sort the four elements of ioValue (highest first) and sort ioIndex at the same time.
            /// Based on a sorting network: http://en.wikipedia.org/wiki/Sorting_network
            /// Generated from method `JPH::Vec4::sSort4Reverse`.
            public static unsafe void SSort4Reverse(Jolt.JPH.Vec4 ioValue, Jolt.JPH.UVec4 ioIndex)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sSort4Reverse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sSort4Reverse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec4_sSort4Reverse(Jolt.JPH.Vec4._Underlying *ioValue, Jolt.JPH.UVec4._Underlying *ioIndex);
                __JPH_Vec4_sSort4Reverse(ioValue._UnderlyingPtr, ioIndex._UnderlyingPtr);
            }

            /// Generated from method `JPH::Vec4::GetX`.
            public unsafe float GetX()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_GetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_GetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec4_GetX(_Underlying *_this);
                return __JPH_Vec4_GetX(_UnderlyingPtr);
            }

            /// Generated from method `JPH::Vec4::GetY`.
            public unsafe float GetY()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_GetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_GetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec4_GetY(_Underlying *_this);
                return __JPH_Vec4_GetY(_UnderlyingPtr);
            }

            /// Generated from method `JPH::Vec4::GetZ`.
            public unsafe float GetZ()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_GetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_GetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec4_GetZ(_Underlying *_this);
                return __JPH_Vec4_GetZ(_UnderlyingPtr);
            }

            /// Generated from method `JPH::Vec4::GetW`.
            public unsafe float GetW()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_GetW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_GetW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec4_GetW(_Underlying *_this);
                return __JPH_Vec4_GetW(_UnderlyingPtr);
            }

            /// Get float component by index
            /// Generated from method `JPH::Vec4::operator[]`.
            public unsafe float this[uint inCoordinate]
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float __JPH_Vec4_index(_Underlying *_this, uint inCoordinate);
                    return __JPH_Vec4_index(_UnderlyingPtr, inCoordinate);
                }
            }

            /// Comparison
            /// Generated from method `JPH::Vec4::operator==`.
            public static unsafe bool operator==(Jolt.JPH.Const_Vec4 _this, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_equal_JPH_Vec4(Jolt.JPH.Const_Vec4._Underlying *_this, Jolt.JPH.Vec4._Underlying *inV2);
                return __Jolt_equal_JPH_Vec4(_this._UnderlyingPtr, inV2._UnderlyingPtr) != 0;
            }

            public static unsafe bool operator!=(Jolt.JPH.Const_Vec4 _this, Jolt.JPH.Const_Vec4 inV2)
            {
                return !(_this == inV2);
            }

            /// Test if two vectors are close
            /// Generated from method `JPH::Vec4::IsClose`.
            /// Parameter `inMaxDistSq` defaults to `9.99999996e-13f`.
            public unsafe bool IsClose(Jolt.JPH.Const_Vec4 inV2, float? inMaxDistSq = null)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_IsClose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_IsClose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Vec4_IsClose(_Underlying *_this, Jolt.JPH.Vec4._Underlying *inV2, float *inMaxDistSq);
                float __deref_inMaxDistSq = inMaxDistSq.GetValueOrDefault();
                return __JPH_Vec4_IsClose(_UnderlyingPtr, inV2._UnderlyingPtr, inMaxDistSq.HasValue ? &__deref_inMaxDistSq : null) != 0;
            }

            /// Test if vector is near zero
            /// Generated from method `JPH::Vec4::IsNearZero`.
            /// Parameter `inMaxDistSq` defaults to `9.99999996e-13f`.
            public unsafe bool IsNearZero(float? inMaxDistSq = null)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_IsNearZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_IsNearZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Vec4_IsNearZero(_Underlying *_this, float *inMaxDistSq);
                float __deref_inMaxDistSq = inMaxDistSq.GetValueOrDefault();
                return __JPH_Vec4_IsNearZero(_UnderlyingPtr, inMaxDistSq.HasValue ? &__deref_inMaxDistSq : null) != 0;
            }

            /// Test if vector is normalized
            /// Generated from method `JPH::Vec4::IsNormalized`.
            /// Parameter `inTolerance` defaults to `9.99999997e-7f`.
            public unsafe bool IsNormalized(float? inTolerance = null)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_IsNormalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_IsNormalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Vec4_IsNormalized(_Underlying *_this, float *inTolerance);
                float __deref_inTolerance = inTolerance.GetValueOrDefault();
                return __JPH_Vec4_IsNormalized(_UnderlyingPtr, inTolerance.HasValue ? &__deref_inTolerance : null) != 0;
            }

            /// Test if vector contains NaN elements
            /// Generated from method `JPH::Vec4::IsNaN`.
            public unsafe bool IsNaN()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_IsNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_IsNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Vec4_IsNaN(_Underlying *_this);
                return __JPH_Vec4_IsNaN(_UnderlyingPtr) != 0;
            }

            /// Multiply two float vectors (component wise)
            /// Generated from method `JPH::Vec4::operator*`.
            public static unsafe Jolt.JPH.Vec4 operator*(Jolt.JPH.Const_Vec4 _this, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__Jolt_mul_JPH_Vec4(Jolt.JPH.Const_Vec4._Underlying *_this, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__Jolt_mul_JPH_Vec4(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Multiply vector with float
            /// Generated from method `JPH::Vec4::operator*`.
            public static unsafe Jolt.JPH.Vec4 operator*(Jolt.JPH.Const_Vec4 _this, float inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Vec4_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Vec4_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__Jolt_mul_JPH_Vec4_float(Jolt.JPH.Const_Vec4._Underlying *_this, float inV2);
                return new(__Jolt_mul_JPH_Vec4_float(_this._UnderlyingPtr, inV2), is_owning: true);
            }

            /// Divide vector by float
            /// Generated from method `JPH::Vec4::operator/`.
            public static unsafe Jolt.JPH.Vec4 operator/(Jolt.JPH.Const_Vec4 _this, float inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_div_JPH_Vec4_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_div_JPH_Vec4_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__Jolt_div_JPH_Vec4_float(Jolt.JPH.Const_Vec4._Underlying *_this, float inV2);
                return new(__Jolt_div_JPH_Vec4_float(_this._UnderlyingPtr, inV2), is_owning: true);
            }

            /// Add two float vectors (component wise)
            /// Generated from method `JPH::Vec4::operator+`.
            public static unsafe Jolt.JPH.Vec4 operator+(Jolt.JPH.Const_Vec4 _this, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_add_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_add_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__Jolt_add_JPH_Vec4(Jolt.JPH.Const_Vec4._Underlying *_this, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__Jolt_add_JPH_Vec4(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Negate
            /// Generated from method `JPH::Vec4::operator-`.
            public static unsafe Jolt.JPH.Vec4 operator-(Jolt.JPH.Const_Vec4 _this)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_neg_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_neg_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__Jolt_neg_JPH_Vec4(Jolt.JPH.Const_Vec4._Underlying *_this);
                return new(__Jolt_neg_JPH_Vec4(_this._UnderlyingPtr), is_owning: true);
            }

            /// Subtract two float vectors (component wise)
            /// Generated from method `JPH::Vec4::operator-`.
            public static unsafe Jolt.JPH.Vec4 operator-(Jolt.JPH.Const_Vec4 _this, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_sub_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_sub_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__Jolt_sub_JPH_Vec4(Jolt.JPH.Const_Vec4._Underlying *_this, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__Jolt_sub_JPH_Vec4(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Divide (component wise)
            /// Generated from method `JPH::Vec4::operator/`.
            public static unsafe Jolt.JPH.Vec4 operator/(Jolt.JPH.Const_Vec4 _this, Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_div_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_div_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__Jolt_div_JPH_Vec4(Jolt.JPH.Const_Vec4._Underlying *_this, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__Jolt_div_JPH_Vec4(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<2, 3, 0, 1>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_2_3_0_1()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_2_3_0_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_2_3_0_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_2_3_0_1(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_2_3_0_1(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<1, 0, 3, 2>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_1_0_3_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_1_0_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_1_0_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_1_0_3_2(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_1_0_3_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<0, 2, 1, 3>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_0_2_1_3()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_0_2_1_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_0_2_1_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_0_2_1_3(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_0_2_1_3(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<1, 2, 3, 2>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_1_2_3_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_1_2_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_1_2_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_1_2_3_2(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_1_2_3_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<2, 2, 2, 2>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_2_2_2_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_2_2_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_2_2_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_2_2_2_2(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_2_2_2_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<3, 0, 1, 2>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_3_0_1_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_3_0_1_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_3_0_1_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_3_0_1_2(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_3_0_1_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<0, 3, 1, 2>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_0_3_1_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_0_3_1_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_0_3_1_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_0_3_1_2(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_0_3_1_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<0, 1, 3, 2>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_0_1_3_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_0_1_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_0_1_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_0_1_3_2(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_0_1_3_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<3, 2, 1, 0>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_3_2_1_0()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_3_2_1_0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_3_2_1_0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_3_2_1_0(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_3_2_1_0(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<2, 0, 1, 2>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_2_0_1_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_2_0_1_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_2_0_1_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_2_0_1_2(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_2_0_1_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<1, 2, 0, 2>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_1_2_0_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_1_2_0_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_1_2_0_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_1_2_0_2(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_1_2_0_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<1, 0, 0, 2>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_1_0_0_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_1_0_0_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_1_0_0_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_1_0_0_2(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_1_0_0_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<3, 2, 3, 2>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_3_2_3_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_3_2_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_3_2_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_3_2_3_2(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_3_2_3_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<2, 3, 1, 2>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_2_3_1_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_2_3_1_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_2_3_1_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_2_3_1_2(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_2_3_1_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<2, 2, 1, 2>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_2_2_1_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_2_2_1_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_2_2_1_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_2_2_1_2(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_2_2_1_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<1, 3, 0, 2>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_1_3_0_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_1_3_0_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_1_3_0_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_1_3_0_2(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_1_3_0_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec4::Swizzle<3, 0, 3, 2>`.
            public unsafe Jolt.JPH.Vec4 Swizzle_3_0_3_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Swizzle_3_0_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Swizzle_3_0_3_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Swizzle_3_0_3_2(_Underlying *_this);
                return new(__JPH_Vec4_Swizzle_3_0_3_2(_UnderlyingPtr), is_owning: true);
            }

            /// Replicate the X component to all components
            /// Generated from method `JPH::Vec4::SplatX`.
            public unsafe Jolt.JPH.Vec4 SplatX()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_SplatX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_SplatX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_SplatX(_Underlying *_this);
                return new(__JPH_Vec4_SplatX(_UnderlyingPtr), is_owning: true);
            }

            /// Replicate the Y component to all components
            /// Generated from method `JPH::Vec4::SplatY`.
            public unsafe Jolt.JPH.Vec4 SplatY()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_SplatY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_SplatY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_SplatY(_Underlying *_this);
                return new(__JPH_Vec4_SplatY(_UnderlyingPtr), is_owning: true);
            }

            /// Replicate the Z component to all components
            /// Generated from method `JPH::Vec4::SplatZ`.
            public unsafe Jolt.JPH.Vec4 SplatZ()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_SplatZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_SplatZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_SplatZ(_Underlying *_this);
                return new(__JPH_Vec4_SplatZ(_UnderlyingPtr), is_owning: true);
            }

            /// Replicate the W component to all components
            /// Generated from method `JPH::Vec4::SplatW`.
            public unsafe Jolt.JPH.Vec4 SplatW()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_SplatW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_SplatW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_SplatW(_Underlying *_this);
                return new(__JPH_Vec4_SplatW(_UnderlyingPtr), is_owning: true);
            }

            /// Replicate the X component to all components
            /// Generated from method `JPH::Vec4::SplatX3`.
            public unsafe Jolt.JPH.Vec3 SplatX3()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_SplatX3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_SplatX3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec4_SplatX3(_Underlying *_this);
                return new(__JPH_Vec4_SplatX3(_UnderlyingPtr), is_owning: true);
            }

            /// Replicate the Y component to all components
            /// Generated from method `JPH::Vec4::SplatY3`.
            public unsafe Jolt.JPH.Vec3 SplatY3()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_SplatY3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_SplatY3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec4_SplatY3(_Underlying *_this);
                return new(__JPH_Vec4_SplatY3(_UnderlyingPtr), is_owning: true);
            }

            /// Replicate the Z component to all components
            /// Generated from method `JPH::Vec4::SplatZ3`.
            public unsafe Jolt.JPH.Vec3 SplatZ3()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_SplatZ3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_SplatZ3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec4_SplatZ3(_Underlying *_this);
                return new(__JPH_Vec4_SplatZ3(_UnderlyingPtr), is_owning: true);
            }

            /// Replicate the W component to all components
            /// Generated from method `JPH::Vec4::SplatW3`.
            public unsafe Jolt.JPH.Vec3 SplatW3()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_SplatW3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_SplatW3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec4_SplatW3(_Underlying *_this);
                return new(__JPH_Vec4_SplatW3(_UnderlyingPtr), is_owning: true);
            }

            /// Get index of component with lowest value
            /// Generated from method `JPH::Vec4::GetLowestComponentIndex`.
            public unsafe int GetLowestComponentIndex()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_GetLowestComponentIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_GetLowestComponentIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_Vec4_GetLowestComponentIndex(_Underlying *_this);
                return __JPH_Vec4_GetLowestComponentIndex(_UnderlyingPtr);
            }

            /// Get index of component with highest value
            /// Generated from method `JPH::Vec4::GetHighestComponentIndex`.
            public unsafe int GetHighestComponentIndex()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_GetHighestComponentIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_GetHighestComponentIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_Vec4_GetHighestComponentIndex(_Underlying *_this);
                return __JPH_Vec4_GetHighestComponentIndex(_UnderlyingPtr);
            }

            /// Return the absolute value of each of the components
            /// Generated from method `JPH::Vec4::Abs`.
            public unsafe Jolt.JPH.Vec4 Abs()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Abs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Abs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Abs(_Underlying *_this);
                return new(__JPH_Vec4_Abs(_UnderlyingPtr), is_owning: true);
            }

            /// Reciprocal vector (1 / value) for each of the components
            /// Generated from method `JPH::Vec4::Reciprocal`.
            public unsafe Jolt.JPH.Vec4 Reciprocal()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Reciprocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Reciprocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Reciprocal(_Underlying *_this);
                return new(__JPH_Vec4_Reciprocal(_UnderlyingPtr), is_owning: true);
            }

            /// Dot product, returns the dot product in X, Y, Z and W components
            /// Generated from method `JPH::Vec4::DotV`.
            public unsafe Jolt.JPH.Vec4 DotV(Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_DotV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_DotV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_DotV(_Underlying *_this, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__JPH_Vec4_DotV(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Dot product
            /// Generated from method `JPH::Vec4::Dot`.
            public unsafe float Dot(Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec4_Dot(_Underlying *_this, Jolt.JPH.Vec4._Underlying *inV2);
                return __JPH_Vec4_Dot(_UnderlyingPtr, inV2._UnderlyingPtr);
            }

            /// Squared length of vector
            /// Generated from method `JPH::Vec4::LengthSq`.
            public unsafe float LengthSq()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_LengthSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_LengthSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec4_LengthSq(_Underlying *_this);
                return __JPH_Vec4_LengthSq(_UnderlyingPtr);
            }

            /// Length of vector
            /// Generated from method `JPH::Vec4::Length`.
            public unsafe float Length()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Length", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Length", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec4_Length(_Underlying *_this);
                return __JPH_Vec4_Length(_UnderlyingPtr);
            }

            /// Normalize vector
            /// Generated from method `JPH::Vec4::Normalized`.
            public unsafe Jolt.JPH.Vec4 Normalized()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Normalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Normalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Normalized(_Underlying *_this);
                return new(__JPH_Vec4_Normalized(_UnderlyingPtr), is_owning: true);
            }

            /// Store 4 floats to memory
            /// Generated from method `JPH::Vec4::StoreFloat4`.
            public unsafe void StoreFloat4(Jolt.JPH.Float4? outV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_StoreFloat4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_StoreFloat4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec4_StoreFloat4(_Underlying *_this, Jolt.JPH.Float4._Underlying *outV);
                __JPH_Vec4_StoreFloat4(_UnderlyingPtr, outV is not null ? outV._UnderlyingPtr : null);
            }

            /// Convert each component from a float to an int
            /// Generated from method `JPH::Vec4::ToInt`.
            public unsafe Jolt.JPH.UVec4 ToInt()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_ToInt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_ToInt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.UVec4._Underlying *__JPH_Vec4_ToInt(_Underlying *_this);
                return new(__JPH_Vec4_ToInt(_UnderlyingPtr), is_owning: true);
            }

            /// Reinterpret Vec4 as a UVec4 (doesn't change the bits)
            /// Generated from method `JPH::Vec4::ReinterpretAsInt`.
            public unsafe Jolt.JPH.UVec4 ReinterpretAsInt()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_ReinterpretAsInt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_ReinterpretAsInt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.UVec4._Underlying *__JPH_Vec4_ReinterpretAsInt(_Underlying *_this);
                return new(__JPH_Vec4_ReinterpretAsInt(_UnderlyingPtr), is_owning: true);
            }

            /// Store if X is negative in bit 0, Y in bit 1, Z in bit 2 and W in bit 3
            /// Generated from method `JPH::Vec4::GetSignBits`.
            public unsafe int GetSignBits()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_GetSignBits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_GetSignBits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_Vec4_GetSignBits(_Underlying *_this);
                return __JPH_Vec4_GetSignBits(_UnderlyingPtr);
            }

            /// Get the minimum of X, Y, Z and W
            /// Generated from method `JPH::Vec4::ReduceMin`.
            public unsafe float ReduceMin()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_ReduceMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_ReduceMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec4_ReduceMin(_Underlying *_this);
                return __JPH_Vec4_ReduceMin(_UnderlyingPtr);
            }

            /// Get the maximum of X, Y, Z and W
            /// Generated from method `JPH::Vec4::ReduceMax`.
            public unsafe float ReduceMax()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_ReduceMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_ReduceMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec4_ReduceMax(_Underlying *_this);
                return __JPH_Vec4_ReduceMax(_UnderlyingPtr);
            }

            /// Component wise square root
            /// Generated from method `JPH::Vec4::Sqrt`.
            public unsafe Jolt.JPH.Vec4 Sqrt()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Sqrt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Sqrt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Sqrt(_Underlying *_this);
                return new(__JPH_Vec4_Sqrt(_UnderlyingPtr), is_owning: true);
            }

            /// Get vector that contains the sign of each element (returns 1.0f if positive, -1.0f if negative)
            /// Generated from method `JPH::Vec4::GetSign`.
            public unsafe Jolt.JPH.Vec4 GetSign()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_GetSign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_GetSign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_GetSign(_Underlying *_this);
                return new(__JPH_Vec4_GetSign(_UnderlyingPtr), is_owning: true);
            }

            /// Flips the signs of the components, e.g. FlipSign<-1, 1, -1, 1>() will flip the signs of the X and Z components
            /// Generated from method `JPH::Vec4::FlipSign<-1, -1, -1, 1>`.
            public unsafe Jolt.JPH.Vec4 FlipSign_Sub1_Sub1_Sub1_1()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_FlipSign_sub_1_sub_1_sub_1_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_FlipSign_sub_1_sub_1_sub_1_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_FlipSign_sub_1_sub_1_sub_1_1(_Underlying *_this);
                return new(__JPH_Vec4_FlipSign_sub_1_sub_1_sub_1_1(_UnderlyingPtr), is_owning: true);
            }

            /// Flips the signs of the components, e.g. FlipSign<-1, 1, -1, 1>() will flip the signs of the X and Z components
            /// Generated from method `JPH::Vec4::FlipSign<1, -1, 1, -1>`.
            public unsafe Jolt.JPH.Vec4 FlipSign_1_Sub1_1_Sub1()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_FlipSign_1_sub_1_1_sub_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_FlipSign_1_sub_1_1_sub_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_FlipSign_1_sub_1_1_sub_1(_Underlying *_this);
                return new(__JPH_Vec4_FlipSign_1_sub_1_1_sub_1(_UnderlyingPtr), is_owning: true);
            }

            /// Flips the signs of the components, e.g. FlipSign<-1, 1, -1, 1>() will flip the signs of the X and Z components
            /// Generated from method `JPH::Vec4::FlipSign<1, 1, -1, 1>`.
            public unsafe Jolt.JPH.Vec4 FlipSign_1_1_Sub1_1()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_FlipSign_1_1_sub_1_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_FlipSign_1_1_sub_1_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_FlipSign_1_1_sub_1_1(_Underlying *_this);
                return new(__JPH_Vec4_FlipSign_1_1_sub_1_1(_UnderlyingPtr), is_owning: true);
            }

            /// Flips the signs of the components, e.g. FlipSign<-1, 1, -1, 1>() will flip the signs of the X and Z components
            /// Generated from method `JPH::Vec4::FlipSign<-1, 1, 1, 1>`.
            public unsafe Jolt.JPH.Vec4 FlipSign_Sub1_1_1_1()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_FlipSign_sub_1_1_1_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_FlipSign_sub_1_1_1_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_FlipSign_sub_1_1_1_1(_Underlying *_this);
                return new(__JPH_Vec4_FlipSign_sub_1_1_1_1(_UnderlyingPtr), is_owning: true);
            }

            /// Flips the signs of the components, e.g. FlipSign<-1, 1, -1, 1>() will flip the signs of the X and Z components
            /// Generated from method `JPH::Vec4::FlipSign<1, -1, 1, 1>`.
            public unsafe Jolt.JPH.Vec4 FlipSign_1_Sub1_1_1()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_FlipSign_1_sub_1_1_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_FlipSign_1_sub_1_1_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_FlipSign_1_sub_1_1_1(_Underlying *_this);
                return new(__JPH_Vec4_FlipSign_1_sub_1_1_1(_UnderlyingPtr), is_owning: true);
            }

            /// Flips the signs of the components, e.g. FlipSign<-1, 1, -1, 1>() will flip the signs of the X and Z components
            /// Generated from method `JPH::Vec4::FlipSign<1, 1, -1, -1>`.
            public unsafe Jolt.JPH.Vec4 FlipSign_1_1_Sub1_Sub1()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_FlipSign_1_1_sub_1_sub_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_FlipSign_1_1_sub_1_sub_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_FlipSign_1_1_sub_1_sub_1(_Underlying *_this);
                return new(__JPH_Vec4_FlipSign_1_1_sub_1_sub_1(_UnderlyingPtr), is_owning: true);
            }

            /// Flips the signs of the components, e.g. FlipSign<-1, 1, -1, 1>() will flip the signs of the X and Z components
            /// Generated from method `JPH::Vec4::FlipSign<-1, 1, 1, -1>`.
            public unsafe Jolt.JPH.Vec4 FlipSign_Sub1_1_1_Sub1()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_FlipSign_sub_1_1_1_sub_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_FlipSign_sub_1_1_1_sub_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_FlipSign_sub_1_1_1_sub_1(_Underlying *_this);
                return new(__JPH_Vec4_FlipSign_sub_1_1_1_sub_1(_UnderlyingPtr), is_owning: true);
            }

            /// Calculate the sine and cosine for each element of this vector (input in radians)
            /// Generated from method `JPH::Vec4::SinCos`.
            public unsafe void SinCos(Jolt.JPH.Vec4 outSin, Jolt.JPH.Vec4 outCos)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_SinCos", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_SinCos", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec4_SinCos(_Underlying *_this, Jolt.JPH.Vec4._Underlying *outSin, Jolt.JPH.Vec4._Underlying *outCos);
                __JPH_Vec4_SinCos(_UnderlyingPtr, outSin._UnderlyingPtr, outCos._UnderlyingPtr);
            }

            /// Calculate the tangent for each element of this vector (input in radians)
            /// Generated from method `JPH::Vec4::Tan`.
            public unsafe Jolt.JPH.Vec4 Tan()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Tan", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Tan", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Tan(_Underlying *_this);
                return new(__JPH_Vec4_Tan(_UnderlyingPtr), is_owning: true);
            }

            /// Calculate the arc sine for each element of this vector (returns value in the range [-PI / 2, PI / 2])
            /// Note that all input values will be clamped to the range [-1, 1] and this function will not return NaNs like std::asin
            /// Generated from method `JPH::Vec4::ASin`.
            public unsafe Jolt.JPH.Vec4 ASin()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_ASin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_ASin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_ASin(_Underlying *_this);
                return new(__JPH_Vec4_ASin(_UnderlyingPtr), is_owning: true);
            }

            /// Calculate the arc cosine for each element of this vector (returns value in the range [0, PI])
            /// Note that all input values will be clamped to the range [-1, 1] and this function will not return NaNs like std::acos
            /// Generated from method `JPH::Vec4::ACos`.
            public unsafe Jolt.JPH.Vec4 ACos()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_ACos", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_ACos", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_ACos(_Underlying *_this);
                return new(__JPH_Vec4_ACos(_UnderlyingPtr), is_owning: true);
            }

            /// Calculate the arc tangent for each element of this vector (returns value in the range [-PI / 2, PI / 2])
            /// Generated from method `JPH::Vec4::ATan`.
            public unsafe Jolt.JPH.Vec4 ATan()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_ATan", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_ATan", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_ATan(_Underlying *_this);
                return new(__JPH_Vec4_ATan(_UnderlyingPtr), is_owning: true);
            }

            /// Calculate the arc tangent of y / x using the signs of the arguments to determine the correct quadrant (returns value in the range [-PI, PI])
            /// Generated from method `JPH::Vec4::sATan2`.
            public static unsafe Jolt.JPH.Vec4 SATan2(Jolt.JPH.Const_Vec4 inY, Jolt.JPH.Const_Vec4 inX)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sATan2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sATan2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sATan2(Jolt.JPH.Vec4._Underlying *inY, Jolt.JPH.Vec4._Underlying *inX);
                return new(__JPH_Vec4_sATan2(inY._UnderlyingPtr, inX._UnderlyingPtr), is_owning: true);
            }

            /// Compress a unit vector to a 32 bit value, precision is around 0.5 * 10^-3
            /// Generated from method `JPH::Vec4::CompressUnitVector`.
            public unsafe uint CompressUnitVector()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_CompressUnitVector", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_CompressUnitVector", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_Vec4_CompressUnitVector(_Underlying *_this);
                return __JPH_Vec4_CompressUnitVector(_UnderlyingPtr);
            }

            /// Decompress a unit vector from a 32 bit value
            /// Generated from method `JPH::Vec4::sDecompressUnitVector`.
            public static unsafe Jolt.JPH.Vec4 SDecompressUnitVector(uint inValue)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sDecompressUnitVector", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sDecompressUnitVector", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sDecompressUnitVector(uint inValue);
                return new(__JPH_Vec4_sDecompressUnitVector(inValue), is_owning: true);
            }

            /// Multiply vector with float
            /// Generated from function `JPH::operator*`.
            public static unsafe Jolt.JPH.Vec4 operator*(float inV1, Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_float_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_float_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__Jolt_mul_float_JPH_Vec4(float inV1, Jolt.JPH.Vec4._Underlying *inV2);
                return new(__Jolt_mul_float_JPH_Vec4(inV1, inV2._UnderlyingPtr), is_owning: true);
            }

            // IEquatable:

            public bool Equals(Jolt.JPH.Const_Vec4? inV2)
            {
                if (inV2 is null)
                    return false;
                return this == inV2;
            }

            public override bool Equals(object? other)
            {
                if (other is null)
                    return false;
                if (other is Jolt.JPH.Const_Vec4)
                    return this == (Jolt.JPH.Const_Vec4)other;
                return false;
            }
        }

        /// Generated from class `JPH::Vec4`.
        /// This is the non-const half of the class.
        public class Vec4 : Const_Vec4
        {
            internal unsafe Vec4(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Vec4() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_DefaultConstruct();
                _UnderlyingPtr = __JPH_Vec4_DefaultConstruct();
            }

            /// Generated from constructor `JPH::Vec4::Vec4`.
            public unsafe Vec4(Jolt.JPH.Const_Vec4 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_ConstructFromAnother(Jolt.JPH.Vec4._Underlying *inRHS);
                _UnderlyingPtr = __JPH_Vec4_ConstructFromAnother(inRHS._UnderlyingPtr);
                _KeepAlive(inRHS);
            }

            /// Generated from constructor `JPH::Vec4::Vec4`.
            public Vec4(Vec4 inRHS) : this((Const_Vec4)inRHS) {}

            // Constructor
            /// Generated from constructor `JPH::Vec4::Vec4`.
            public unsafe Vec4(Jolt.JPH.Const_Vec3 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Construct_1_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Construct_1_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Construct_1_JPH_Vec3(Jolt.JPH.Vec3._Underlying *inRHS);
                _UnderlyingPtr = __JPH_Vec4_Construct_1_JPH_Vec3(inRHS._UnderlyingPtr);
            }

            /// Generated from constructor `JPH::Vec4::Vec4`.
            public unsafe Vec4(Jolt.JPH.Const_Vec3 inRHS, float inW) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Construct_2(Jolt.JPH.Vec3._Underlying *inRHS, float inW);
                _UnderlyingPtr = __JPH_Vec4_Construct_2(inRHS._UnderlyingPtr, inW);
            }

            /// Create a vector from 4 components
            /// Generated from constructor `JPH::Vec4::Vec4`.
            public unsafe Vec4(float inX, float inY, float inZ, float inW) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_Construct_4(float inX, float inY, float inZ, float inW);
                _UnderlyingPtr = __JPH_Vec4_Construct_4(inX, inY, inZ, inW);
            }

            /// Generated from method `JPH::Vec4::operator=`.
            public unsafe Jolt.JPH.Vec4 Assign(Jolt.JPH.Const_Vec4 inRHS)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_AssignFromAnother(_Underlying *_this, Jolt.JPH.Vec4._Underlying *inRHS);
                Jolt.JPH.Vec4 __ret;
                __ret = new(__JPH_Vec4_AssignFromAnother(_UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: false);
                _DiscardKeepAlive();
                _KeepAlive(inRHS);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Set individual components
            /// Generated from method `JPH::Vec4::SetX`.
            public unsafe void SetX(float inX)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_SetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_SetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec4_SetX(_Underlying *_this, float inX);
                __JPH_Vec4_SetX(_UnderlyingPtr, inX);
            }

            /// Generated from method `JPH::Vec4::SetY`.
            public unsafe void SetY(float inY)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_SetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_SetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec4_SetY(_Underlying *_this, float inY);
                __JPH_Vec4_SetY(_UnderlyingPtr, inY);
            }

            /// Generated from method `JPH::Vec4::SetZ`.
            public unsafe void SetZ(float inZ)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_SetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_SetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec4_SetZ(_Underlying *_this, float inZ);
                __JPH_Vec4_SetZ(_UnderlyingPtr, inZ);
            }

            /// Generated from method `JPH::Vec4::SetW`.
            public unsafe void SetW(float inW)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_SetW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_SetW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec4_SetW(_Underlying *_this, float inW);
                __JPH_Vec4_SetW(_UnderlyingPtr, inW);
            }

            /// Set all components
            /// Generated from method `JPH::Vec4::Set`.
            public unsafe void Set(float inX, float inY, float inZ, float inW)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_Set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_Set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec4_Set(_Underlying *_this, float inX, float inY, float inZ, float inW);
                __JPH_Vec4_Set(_UnderlyingPtr, inX, inY, inZ, inW);
            }

            /// Generated from method `JPH::Vec4::operator[]`.
            public unsafe new ref float this[uint inCoordinate]
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_index_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_index_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_Vec4_index_mut(_Underlying *_this, uint inCoordinate);
                    return ref *__JPH_Vec4_index_mut(_UnderlyingPtr, inCoordinate);
                }
            }

            /// Multiply vector with float
            /// Generated from method `JPH::Vec4::operator*=`.
            public unsafe Jolt.JPH.Vec4 MulAssign(float inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_mul_assign_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_mul_assign_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_mul_assign_float(_Underlying *_this, float inV2);
                Jolt.JPH.Vec4 __ret;
                __ret = new(__JPH_Vec4_mul_assign_float(_UnderlyingPtr, inV2), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Multiply vector with vector
            /// Generated from method `JPH::Vec4::operator*=`.
            public unsafe Jolt.JPH.Vec4 MulAssign(Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_mul_assign_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_mul_assign_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_mul_assign_JPH_Vec4(_Underlying *_this, Jolt.JPH.Vec4._Underlying *inV2);
                Jolt.JPH.Vec4 __ret;
                __ret = new(__JPH_Vec4_mul_assign_JPH_Vec4(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Divide vector by float
            /// Generated from method `JPH::Vec4::operator/=`.
            public unsafe Jolt.JPH.Vec4 DivAssign(float inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_div_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_div_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_div_assign(_Underlying *_this, float inV2);
                Jolt.JPH.Vec4 __ret;
                __ret = new(__JPH_Vec4_div_assign(_UnderlyingPtr, inV2), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Add two float vectors (component wise)
            /// Generated from method `JPH::Vec4::operator+=`.
            public unsafe Jolt.JPH.Vec4 AddAssign(Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_add_assign(_Underlying *_this, Jolt.JPH.Vec4._Underlying *inV2);
                Jolt.JPH.Vec4 __ret;
                __ret = new(__JPH_Vec4_add_assign(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Subtract two float vectors (component wise)
            /// Generated from method `JPH::Vec4::operator-=`.
            public unsafe Jolt.JPH.Vec4 SubAssign(Jolt.JPH.Const_Vec4 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec4_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec4_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec4_sub_assign(_Underlying *_this, Jolt.JPH.Vec4._Underlying *inV2);
                Jolt.JPH.Vec4 __ret;
                __ret = new(__JPH_Vec4_sub_assign(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }
        }

        /// This is used for optional parameters of class `Vec4` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Vec4`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Vec4`/`Const_Vec4` directly.
        public class _InOptMut_Vec4
        {
            public Vec4? Opt;

            public _InOptMut_Vec4() {}
            public _InOptMut_Vec4(Vec4 value) {Opt = value;}
            public static implicit operator _InOptMut_Vec4(Vec4 value) {return new(value);}
        }

        /// This is used for optional parameters of class `Vec4` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Vec4`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Vec4`/`Const_Vec4` to pass it to the function.
        public class _InOptConst_Vec4
        {
            public Const_Vec4? Opt;

            public _InOptConst_Vec4() {}
            public _InOptConst_Vec4(Const_Vec4 value) {Opt = value;}
            public static implicit operator _InOptConst_Vec4(Const_Vec4 value) {return new(value);}
        }
    }
}
