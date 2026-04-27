// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// 3 component vector (stored as 4 vectors).
        /// Note that we keep the 4th component the same as the 3rd component to avoid divisions by zero when JPH_FLOATING_POINT_EXCEPTIONS_ENABLED defined
        /// Generated from class `JPH::Vec3`.
        /// This is the const half of the class.
        public class Const_Vec3 : Jolt.Object<Const_Vec3>, System.IDisposable, System.IEquatable<Jolt.JPH.Const_Vec3>
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec3_Destroy(_Underlying *_this);
                __JPH_Vec3_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Vec3() {Dispose(false);}

            internal unsafe Const_Vec3(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Vec3() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_DefaultConstruct();
                _UnderlyingPtr = __JPH_Vec3_DefaultConstruct();
            }

            /// Generated from constructor `JPH::Vec3::Vec3`.
            public unsafe Const_Vec3(Jolt.JPH.Const_Vec3 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_ConstructFromAnother(Jolt.JPH.Vec3._Underlying *inRHS);
                _UnderlyingPtr = __JPH_Vec3_ConstructFromAnother(inRHS._UnderlyingPtr);
                _KeepAlive(inRHS);
            }

            /// Generated from constructor `JPH::Vec3::Vec3`.
            public Const_Vec3(Vec3 inRHS) : this((Const_Vec3)inRHS) {}

            /// Generated from constructor `JPH::Vec3::Vec3`.
            public unsafe Const_Vec3(Jolt.JPH.Const_Vec4 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Construct_1_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Construct_1_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Construct_1_JPH_Vec4(Jolt.JPH.Vec4._Underlying *inRHS);
                _UnderlyingPtr = __JPH_Vec3_Construct_1_JPH_Vec4(inRHS._UnderlyingPtr);
            }

            /// Load 3 floats from memory
            /// Generated from constructor `JPH::Vec3::Vec3`.
            public unsafe Const_Vec3(Jolt.JPH.Const_Float3 inV) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Construct_1_JPH_Float3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Construct_1_JPH_Float3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Construct_1_JPH_Float3(Jolt.JPH.Const_Float3._Underlying *inV);
                _UnderlyingPtr = __JPH_Vec3_Construct_1_JPH_Float3(inV._UnderlyingPtr);
            }

            /// Create a vector from 3 components
            /// Generated from constructor `JPH::Vec3::Vec3`.
            public unsafe Const_Vec3(float inX, float inY, float inZ) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Construct_3(float inX, float inY, float inZ);
                _UnderlyingPtr = __JPH_Vec3_Construct_3(inX, inY, inZ);
            }

            /// Generated from method `JPH::Vec3::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Vec3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Vec3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_Vec3_size_t(ulong inCount);
                return __Jolt_new_JPH_Vec3_size_t(inCount);
            }

            /// Generated from method `JPH::Vec3::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Vec3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Vec3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Vec3_void_ptr(void *inPointer);
                __Jolt_delete_JPH_Vec3_void_ptr(inPointer);
            }

            /// Generated from method `JPH::Vec3::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Vec3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Vec3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Vec3_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_Vec3_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::Vec3::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Vec3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Vec3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_Vec3_size_t(ulong inCount);
                return __Jolt_new_array_JPH_Vec3_size_t(inCount);
            }

            /// Generated from method `JPH::Vec3::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Vec3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Vec3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Vec3_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_Vec3_void_ptr(inPointer);
            }

            /// Generated from method `JPH::Vec3::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Vec3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Vec3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Vec3_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_Vec3_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::Vec3::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Vec3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Vec3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_Vec3_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_Vec3_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::Vec3::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Vec3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Vec3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Vec3_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_Vec3_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::Vec3::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Vec3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Vec3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_Vec3_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_Vec3_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::Vec3::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Vec3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Vec3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Vec3_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_Vec3_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Vector with all zeros
            /// Generated from method `JPH::Vec3::sZero`.
            public static unsafe Jolt.JPH.Vec3 SZero()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sZero();
                return new(__JPH_Vec3_sZero(), is_owning: true);
            }

            /// Vector with all ones
            /// Generated from method `JPH::Vec3::sOne`.
            public static unsafe Jolt.JPH.Vec3 SOne()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sOne", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sOne", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sOne();
                return new(__JPH_Vec3_sOne(), is_owning: true);
            }

            /// Vector with all NaN's
            /// Generated from method `JPH::Vec3::sNaN`.
            public static unsafe Jolt.JPH.Vec3 SNaN()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sNaN();
                return new(__JPH_Vec3_sNaN(), is_owning: true);
            }

            /// Vectors with the principal axis
            /// Generated from method `JPH::Vec3::sAxisX`.
            public static unsafe Jolt.JPH.Vec3 SAxisX()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sAxisX();
                return new(__JPH_Vec3_sAxisX(), is_owning: true);
            }

            /// Generated from method `JPH::Vec3::sAxisY`.
            public static unsafe Jolt.JPH.Vec3 SAxisY()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sAxisY();
                return new(__JPH_Vec3_sAxisY(), is_owning: true);
            }

            /// Generated from method `JPH::Vec3::sAxisZ`.
            public static unsafe Jolt.JPH.Vec3 SAxisZ()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sAxisZ();
                return new(__JPH_Vec3_sAxisZ(), is_owning: true);
            }

            /// Replicate inV across all components
            /// Generated from method `JPH::Vec3::sReplicate`.
            public static unsafe Jolt.JPH.Vec3 SReplicate(float inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sReplicate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sReplicate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sReplicate(float inV);
                return new(__JPH_Vec3_sReplicate(inV), is_owning: true);
            }

            /// Load 3 floats from memory (reads 32 bits extra which it doesn't use)
            /// Generated from method `JPH::Vec3::sLoadFloat3Unsafe`.
            public static unsafe Jolt.JPH.Vec3 SLoadFloat3Unsafe(Jolt.JPH.Const_Float3 inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sLoadFloat3Unsafe", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sLoadFloat3Unsafe", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sLoadFloat3Unsafe(Jolt.JPH.Const_Float3._Underlying *inV);
                return new(__JPH_Vec3_sLoadFloat3Unsafe(inV._UnderlyingPtr), is_owning: true);
            }

            /// Return the minimum value of each of the components
            /// Generated from method `JPH::Vec3::sMin`.
            public static unsafe Jolt.JPH.Vec3 SMin(Jolt.JPH.Const_Vec3 inV1, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sMin(Jolt.JPH.Vec3._Underlying *inV1, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__JPH_Vec3_sMin(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Return the maximum of each of the components
            /// Generated from method `JPH::Vec3::sMax`.
            public static unsafe Jolt.JPH.Vec3 SMax(Jolt.JPH.Const_Vec3 inV1, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sMax(Jolt.JPH.Vec3._Underlying *inV1, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__JPH_Vec3_sMax(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Clamp a vector between min and max (component wise)
            /// Generated from method `JPH::Vec3::sClamp`.
            public static unsafe Jolt.JPH.Vec3 SClamp(Jolt.JPH.Const_Vec3 inV, Jolt.JPH.Const_Vec3 inMin, Jolt.JPH.Const_Vec3 inMax)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sClamp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sClamp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sClamp(Jolt.JPH.Vec3._Underlying *inV, Jolt.JPH.Vec3._Underlying *inMin, Jolt.JPH.Vec3._Underlying *inMax);
                return new(__JPH_Vec3_sClamp(inV._UnderlyingPtr, inMin._UnderlyingPtr, inMax._UnderlyingPtr), is_owning: true);
            }

            /// Equals (component wise)
            /// Generated from method `JPH::Vec3::sEquals`.
            public static unsafe Jolt.JPH.UVec4 SEquals(Jolt.JPH.Const_Vec3 inV1, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sEquals", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sEquals", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.UVec4._Underlying *__JPH_Vec3_sEquals(Jolt.JPH.Vec3._Underlying *inV1, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__JPH_Vec3_sEquals(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Less than (component wise)
            /// Generated from method `JPH::Vec3::sLess`.
            public static unsafe Jolt.JPH.UVec4 SLess(Jolt.JPH.Const_Vec3 inV1, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sLess", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sLess", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.UVec4._Underlying *__JPH_Vec3_sLess(Jolt.JPH.Vec3._Underlying *inV1, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__JPH_Vec3_sLess(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Less than or equal (component wise)
            /// Generated from method `JPH::Vec3::sLessOrEqual`.
            public static unsafe Jolt.JPH.UVec4 SLessOrEqual(Jolt.JPH.Const_Vec3 inV1, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sLessOrEqual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sLessOrEqual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.UVec4._Underlying *__JPH_Vec3_sLessOrEqual(Jolt.JPH.Vec3._Underlying *inV1, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__JPH_Vec3_sLessOrEqual(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Greater than (component wise)
            /// Generated from method `JPH::Vec3::sGreater`.
            public static unsafe Jolt.JPH.UVec4 SGreater(Jolt.JPH.Const_Vec3 inV1, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sGreater", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sGreater", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.UVec4._Underlying *__JPH_Vec3_sGreater(Jolt.JPH.Vec3._Underlying *inV1, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__JPH_Vec3_sGreater(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Greater than or equal (component wise)
            /// Generated from method `JPH::Vec3::sGreaterOrEqual`.
            public static unsafe Jolt.JPH.UVec4 SGreaterOrEqual(Jolt.JPH.Const_Vec3 inV1, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sGreaterOrEqual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sGreaterOrEqual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.UVec4._Underlying *__JPH_Vec3_sGreaterOrEqual(Jolt.JPH.Vec3._Underlying *inV1, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__JPH_Vec3_sGreaterOrEqual(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Calculates inMul1 * inMul2 + inAdd
            /// Generated from method `JPH::Vec3::sFusedMultiplyAdd`.
            public static unsafe Jolt.JPH.Vec3 SFusedMultiplyAdd(Jolt.JPH.Const_Vec3 inMul1, Jolt.JPH.Const_Vec3 inMul2, Jolt.JPH.Const_Vec3 inAdd)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sFusedMultiplyAdd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sFusedMultiplyAdd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sFusedMultiplyAdd(Jolt.JPH.Vec3._Underlying *inMul1, Jolt.JPH.Vec3._Underlying *inMul2, Jolt.JPH.Vec3._Underlying *inAdd);
                return new(__JPH_Vec3_sFusedMultiplyAdd(inMul1._UnderlyingPtr, inMul2._UnderlyingPtr, inAdd._UnderlyingPtr), is_owning: true);
            }

            /// Component wise select, returns inNotSet when highest bit of inControl = 0 and inSet when highest bit of inControl = 1
            /// Generated from method `JPH::Vec3::sSelect`.
            public static unsafe Jolt.JPH.Vec3 SSelect(Jolt.JPH.Const_Vec3 inNotSet, Jolt.JPH.Const_Vec3 inSet, Jolt.JPH.Const_UVec4 inControl)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sSelect", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sSelect", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sSelect(Jolt.JPH.Vec3._Underlying *inNotSet, Jolt.JPH.Vec3._Underlying *inSet, Jolt.JPH.UVec4._Underlying *inControl);
                return new(__JPH_Vec3_sSelect(inNotSet._UnderlyingPtr, inSet._UnderlyingPtr, inControl._UnderlyingPtr), is_owning: true);
            }

            /// Logical or (component wise)
            /// Generated from method `JPH::Vec3::sOr`.
            public static unsafe Jolt.JPH.Vec3 SOr(Jolt.JPH.Const_Vec3 inV1, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sOr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sOr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sOr(Jolt.JPH.Vec3._Underlying *inV1, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__JPH_Vec3_sOr(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Logical xor (component wise)
            /// Generated from method `JPH::Vec3::sXor`.
            public static unsafe Jolt.JPH.Vec3 SXor(Jolt.JPH.Const_Vec3 inV1, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sXor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sXor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sXor(Jolt.JPH.Vec3._Underlying *inV1, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__JPH_Vec3_sXor(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Logical and (component wise)
            /// Generated from method `JPH::Vec3::sAnd`.
            public static unsafe Jolt.JPH.Vec3 SAnd(Jolt.JPH.Const_Vec3 inV1, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sAnd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sAnd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sAnd(Jolt.JPH.Vec3._Underlying *inV1, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__JPH_Vec3_sAnd(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Get unit vector given spherical coordinates
            /// inTheta \f$\in [0, \pi]\f$ is angle between vector and z-axis
            /// inPhi \f$\in [0, 2 \pi]\f$ is the angle in the xy-plane starting from the x axis and rotating counter clockwise around the z-axis
            /// Generated from method `JPH::Vec3::sUnitSpherical`.
            public static unsafe Jolt.JPH.Vec3 SUnitSpherical(float inTheta, float inPhi)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sUnitSpherical", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sUnitSpherical", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sUnitSpherical(float inTheta, float inPhi);
                return new(__JPH_Vec3_sUnitSpherical(inTheta, inPhi), is_owning: true);
            }

            /// Generated from method `JPH::Vec3::GetX`.
            public unsafe float GetX()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_GetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_GetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec3_GetX(_Underlying *_this);
                return __JPH_Vec3_GetX(_UnderlyingPtr);
            }

            /// Generated from method `JPH::Vec3::GetY`.
            public unsafe float GetY()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_GetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_GetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec3_GetY(_Underlying *_this);
                return __JPH_Vec3_GetY(_UnderlyingPtr);
            }

            /// Generated from method `JPH::Vec3::GetZ`.
            public unsafe float GetZ()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_GetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_GetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec3_GetZ(_Underlying *_this);
                return __JPH_Vec3_GetZ(_UnderlyingPtr);
            }

            /// Get float component by index
            /// Generated from method `JPH::Vec3::operator[]`.
            public unsafe float this[uint inCoordinate]
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float __JPH_Vec3_index(_Underlying *_this, uint inCoordinate);
                    return __JPH_Vec3_index(_UnderlyingPtr, inCoordinate);
                }
            }

            /// Comparison
            /// Generated from method `JPH::Vec3::operator==`.
            public static unsafe bool operator==(Jolt.JPH.Const_Vec3 _this, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_equal_JPH_Vec3(Jolt.JPH.Const_Vec3._Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                return __Jolt_equal_JPH_Vec3(_this._UnderlyingPtr, inV2._UnderlyingPtr) != 0;
            }

            public static unsafe bool operator!=(Jolt.JPH.Const_Vec3 _this, Jolt.JPH.Const_Vec3 inV2)
            {
                return !(_this == inV2);
            }

            /// Test if two vectors are close
            /// Generated from method `JPH::Vec3::IsClose`.
            /// Parameter `inMaxDistSq` defaults to `9.99999996e-13f`.
            public unsafe bool IsClose(Jolt.JPH.Const_Vec3 inV2, float? inMaxDistSq = null)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_IsClose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_IsClose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Vec3_IsClose(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2, float *inMaxDistSq);
                float __deref_inMaxDistSq = inMaxDistSq.GetValueOrDefault();
                return __JPH_Vec3_IsClose(_UnderlyingPtr, inV2._UnderlyingPtr, inMaxDistSq.HasValue ? &__deref_inMaxDistSq : null) != 0;
            }

            /// Test if vector is near zero
            /// Generated from method `JPH::Vec3::IsNearZero`.
            /// Parameter `inMaxDistSq` defaults to `9.99999996e-13f`.
            public unsafe bool IsNearZero(float? inMaxDistSq = null)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_IsNearZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_IsNearZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Vec3_IsNearZero(_Underlying *_this, float *inMaxDistSq);
                float __deref_inMaxDistSq = inMaxDistSq.GetValueOrDefault();
                return __JPH_Vec3_IsNearZero(_UnderlyingPtr, inMaxDistSq.HasValue ? &__deref_inMaxDistSq : null) != 0;
            }

            /// Test if vector is normalized
            /// Generated from method `JPH::Vec3::IsNormalized`.
            /// Parameter `inTolerance` defaults to `9.99999997e-7f`.
            public unsafe bool IsNormalized(float? inTolerance = null)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_IsNormalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_IsNormalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Vec3_IsNormalized(_Underlying *_this, float *inTolerance);
                float __deref_inTolerance = inTolerance.GetValueOrDefault();
                return __JPH_Vec3_IsNormalized(_UnderlyingPtr, inTolerance.HasValue ? &__deref_inTolerance : null) != 0;
            }

            /// Test if vector contains NaN elements
            /// Generated from method `JPH::Vec3::IsNaN`.
            public unsafe bool IsNaN()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_IsNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_IsNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Vec3_IsNaN(_Underlying *_this);
                return __JPH_Vec3_IsNaN(_UnderlyingPtr) != 0;
            }

            /// Multiply two float vectors (component wise)
            /// Generated from method `JPH::Vec3::operator*`.
            public static unsafe Jolt.JPH.Vec3 operator*(Jolt.JPH.Const_Vec3 _this, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__Jolt_mul_JPH_Vec3(Jolt.JPH.Const_Vec3._Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__Jolt_mul_JPH_Vec3(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Multiply vector with float
            /// Generated from method `JPH::Vec3::operator*`.
            public static unsafe Jolt.JPH.Vec3 operator*(Jolt.JPH.Const_Vec3 _this, float inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_Vec3_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_Vec3_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__Jolt_mul_JPH_Vec3_float(Jolt.JPH.Const_Vec3._Underlying *_this, float inV2);
                return new(__Jolt_mul_JPH_Vec3_float(_this._UnderlyingPtr, inV2), is_owning: true);
            }

            /// Divide vector by float
            /// Generated from method `JPH::Vec3::operator/`.
            public static unsafe Jolt.JPH.Vec3 operator/(Jolt.JPH.Const_Vec3 _this, float inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_div_JPH_Vec3_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_div_JPH_Vec3_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__Jolt_div_JPH_Vec3_float(Jolt.JPH.Const_Vec3._Underlying *_this, float inV2);
                return new(__Jolt_div_JPH_Vec3_float(_this._UnderlyingPtr, inV2), is_owning: true);
            }

            /// Add two float vectors (component wise)
            /// Generated from method `JPH::Vec3::operator+`.
            public static unsafe Jolt.JPH.Vec3 operator+(Jolt.JPH.Const_Vec3 _this, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_add_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_add_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__Jolt_add_JPH_Vec3(Jolt.JPH.Const_Vec3._Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__Jolt_add_JPH_Vec3(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Negate
            /// Generated from method `JPH::Vec3::operator-`.
            public static unsafe Jolt.JPH.Vec3 operator-(Jolt.JPH.Const_Vec3 _this)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_neg_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_neg_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__Jolt_neg_JPH_Vec3(Jolt.JPH.Const_Vec3._Underlying *_this);
                return new(__Jolt_neg_JPH_Vec3(_this._UnderlyingPtr), is_owning: true);
            }

            /// Subtract two float vectors (component wise)
            /// Generated from method `JPH::Vec3::operator-`.
            public static unsafe Jolt.JPH.Vec3 operator-(Jolt.JPH.Const_Vec3 _this, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_sub_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_sub_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__Jolt_sub_JPH_Vec3(Jolt.JPH.Const_Vec3._Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__Jolt_sub_JPH_Vec3(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Divide (component wise)
            /// Generated from method `JPH::Vec3::operator/`.
            public static unsafe Jolt.JPH.Vec3 operator/(Jolt.JPH.Const_Vec3 _this, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_div_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_div_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__Jolt_div_JPH_Vec3(Jolt.JPH.Const_Vec3._Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__Jolt_div_JPH_Vec3(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec3::Swizzle<1, 2, 2>`.
            public unsafe Jolt.JPH.Vec3 Swizzle_1_2_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Swizzle_1_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Swizzle_1_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Swizzle_1_2_2(_Underlying *_this);
                return new(__JPH_Vec3_Swizzle_1_2_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec3::Swizzle<2, 2, 2>`.
            public unsafe Jolt.JPH.Vec3 Swizzle_2_2_2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Swizzle_2_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Swizzle_2_2_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Swizzle_2_2_2(_Underlying *_this);
                return new(__JPH_Vec3_Swizzle_2_2_2(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec3::Swizzle<2, 0, 1>`.
            public unsafe Jolt.JPH.Vec3 Swizzle_2_0_1()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Swizzle_2_0_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Swizzle_2_0_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Swizzle_2_0_1(_Underlying *_this);
                return new(__JPH_Vec3_Swizzle_2_0_1(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec3::Swizzle<0, 2, 1>`.
            public unsafe Jolt.JPH.Vec3 Swizzle_0_2_1()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Swizzle_0_2_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Swizzle_0_2_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Swizzle_0_2_1(_Underlying *_this);
                return new(__JPH_Vec3_Swizzle_0_2_1(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec3::Swizzle<1, 2, 0>`.
            public unsafe Jolt.JPH.Vec3 Swizzle_1_2_0()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Swizzle_1_2_0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Swizzle_1_2_0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Swizzle_1_2_0(_Underlying *_this);
                return new(__JPH_Vec3_Swizzle_1_2_0(_UnderlyingPtr), is_owning: true);
            }

            /// Swizzle the elements in inV
            /// Generated from method `JPH::Vec3::Swizzle<2, 1, 0>`.
            public unsafe Jolt.JPH.Vec3 Swizzle_2_1_0()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Swizzle_2_1_0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Swizzle_2_1_0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Swizzle_2_1_0(_Underlying *_this);
                return new(__JPH_Vec3_Swizzle_2_1_0(_UnderlyingPtr), is_owning: true);
            }

            /// Replicate the X component to all components
            /// Generated from method `JPH::Vec3::SplatX`.
            public unsafe Jolt.JPH.Vec4 SplatX()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_SplatX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_SplatX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec3_SplatX(_Underlying *_this);
                return new(__JPH_Vec3_SplatX(_UnderlyingPtr), is_owning: true);
            }

            /// Replicate the Y component to all components
            /// Generated from method `JPH::Vec3::SplatY`.
            public unsafe Jolt.JPH.Vec4 SplatY()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_SplatY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_SplatY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec3_SplatY(_Underlying *_this);
                return new(__JPH_Vec3_SplatY(_UnderlyingPtr), is_owning: true);
            }

            /// Replicate the Z component to all components
            /// Generated from method `JPH::Vec3::SplatZ`.
            public unsafe Jolt.JPH.Vec4 SplatZ()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_SplatZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_SplatZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec3_SplatZ(_Underlying *_this);
                return new(__JPH_Vec3_SplatZ(_UnderlyingPtr), is_owning: true);
            }

            /// Get index of component with lowest value
            /// Generated from method `JPH::Vec3::GetLowestComponentIndex`.
            public unsafe int GetLowestComponentIndex()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_GetLowestComponentIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_GetLowestComponentIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_Vec3_GetLowestComponentIndex(_Underlying *_this);
                return __JPH_Vec3_GetLowestComponentIndex(_UnderlyingPtr);
            }

            /// Get index of component with highest value
            /// Generated from method `JPH::Vec3::GetHighestComponentIndex`.
            public unsafe int GetHighestComponentIndex()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_GetHighestComponentIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_GetHighestComponentIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_Vec3_GetHighestComponentIndex(_Underlying *_this);
                return __JPH_Vec3_GetHighestComponentIndex(_UnderlyingPtr);
            }

            /// Return the absolute value of each of the components
            /// Generated from method `JPH::Vec3::Abs`.
            public unsafe Jolt.JPH.Vec3 Abs()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Abs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Abs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Abs(_Underlying *_this);
                return new(__JPH_Vec3_Abs(_UnderlyingPtr), is_owning: true);
            }

            /// Reciprocal vector (1 / value) for each of the components
            /// Generated from method `JPH::Vec3::Reciprocal`.
            public unsafe Jolt.JPH.Vec3 Reciprocal()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Reciprocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Reciprocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Reciprocal(_Underlying *_this);
                return new(__JPH_Vec3_Reciprocal(_UnderlyingPtr), is_owning: true);
            }

            /// Cross product
            /// Generated from method `JPH::Vec3::Cross`.
            public unsafe Jolt.JPH.Vec3 Cross(Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Cross", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Cross", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Cross(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__JPH_Vec3_Cross(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Dot product, returns the dot product in X, Y and Z components
            /// Generated from method `JPH::Vec3::DotV`.
            public unsafe Jolt.JPH.Vec3 DotV(Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_DotV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_DotV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_DotV(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__JPH_Vec3_DotV(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Dot product, returns the dot product in X, Y, Z and W components
            /// Generated from method `JPH::Vec3::DotV4`.
            public unsafe Jolt.JPH.Vec4 DotV4(Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_DotV4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_DotV4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec4._Underlying *__JPH_Vec3_DotV4(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__JPH_Vec3_DotV4(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Dot product
            /// Generated from method `JPH::Vec3::Dot`.
            public unsafe float Dot(Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec3_Dot(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                return __JPH_Vec3_Dot(_UnderlyingPtr, inV2._UnderlyingPtr);
            }

            /// Squared length of vector
            /// Generated from method `JPH::Vec3::LengthSq`.
            public unsafe float LengthSq()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_LengthSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_LengthSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec3_LengthSq(_Underlying *_this);
                return __JPH_Vec3_LengthSq(_UnderlyingPtr);
            }

            /// Length of vector
            /// Generated from method `JPH::Vec3::Length`.
            public unsafe float Length()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Length", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Length", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec3_Length(_Underlying *_this);
                return __JPH_Vec3_Length(_UnderlyingPtr);
            }

            /// Normalize vector
            /// Generated from method `JPH::Vec3::Normalized`.
            public unsafe Jolt.JPH.Vec3 Normalized()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Normalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Normalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Normalized(_Underlying *_this);
                return new(__JPH_Vec3_Normalized(_UnderlyingPtr), is_owning: true);
            }

            /// Normalize vector or return inZeroValue if the length of the vector is zero
            /// Generated from method `JPH::Vec3::NormalizedOr`.
            public unsafe Jolt.JPH.Vec3 NormalizedOr(Jolt.JPH.Const_Vec3 inZeroValue)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_NormalizedOr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_NormalizedOr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_NormalizedOr(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inZeroValue);
                return new(__JPH_Vec3_NormalizedOr(_UnderlyingPtr, inZeroValue._UnderlyingPtr), is_owning: true);
            }

            /// Store 3 floats to memory
            /// Generated from method `JPH::Vec3::StoreFloat3`.
            public unsafe void StoreFloat3(Jolt.JPH.Float3? outV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_StoreFloat3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_StoreFloat3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec3_StoreFloat3(_Underlying *_this, Jolt.JPH.Float3._Underlying *outV);
                __JPH_Vec3_StoreFloat3(_UnderlyingPtr, outV is not null ? outV._UnderlyingPtr : null);
            }

            /// Convert each component from a float to an int
            /// Generated from method `JPH::Vec3::ToInt`.
            public unsafe Jolt.JPH.UVec4 ToInt()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_ToInt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_ToInt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.UVec4._Underlying *__JPH_Vec3_ToInt(_Underlying *_this);
                return new(__JPH_Vec3_ToInt(_UnderlyingPtr), is_owning: true);
            }

            /// Reinterpret Vec3 as a UVec4 (doesn't change the bits)
            /// Generated from method `JPH::Vec3::ReinterpretAsInt`.
            public unsafe Jolt.JPH.UVec4 ReinterpretAsInt()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_ReinterpretAsInt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_ReinterpretAsInt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.UVec4._Underlying *__JPH_Vec3_ReinterpretAsInt(_Underlying *_this);
                return new(__JPH_Vec3_ReinterpretAsInt(_UnderlyingPtr), is_owning: true);
            }

            /// Get the minimum of X, Y and Z
            /// Generated from method `JPH::Vec3::ReduceMin`.
            public unsafe float ReduceMin()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_ReduceMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_ReduceMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec3_ReduceMin(_Underlying *_this);
                return __JPH_Vec3_ReduceMin(_UnderlyingPtr);
            }

            /// Get the maximum of X, Y and Z
            /// Generated from method `JPH::Vec3::ReduceMax`.
            public unsafe float ReduceMax()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_ReduceMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_ReduceMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Vec3_ReduceMax(_Underlying *_this);
                return __JPH_Vec3_ReduceMax(_UnderlyingPtr);
            }

            /// Component wise square root
            /// Generated from method `JPH::Vec3::Sqrt`.
            public unsafe Jolt.JPH.Vec3 Sqrt()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Sqrt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Sqrt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Sqrt(_Underlying *_this);
                return new(__JPH_Vec3_Sqrt(_UnderlyingPtr), is_owning: true);
            }

            /// Get normalized vector that is perpendicular to this vector
            /// Generated from method `JPH::Vec3::GetNormalizedPerpendicular`.
            public unsafe Jolt.JPH.Vec3 GetNormalizedPerpendicular()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_GetNormalizedPerpendicular", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_GetNormalizedPerpendicular", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_GetNormalizedPerpendicular(_Underlying *_this);
                return new(__JPH_Vec3_GetNormalizedPerpendicular(_UnderlyingPtr), is_owning: true);
            }

            /// Get vector that contains the sign of each element (returns 1.0f if positive, -1.0f if negative)
            /// Generated from method `JPH::Vec3::GetSign`.
            public unsafe Jolt.JPH.Vec3 GetSign()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_GetSign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_GetSign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_GetSign(_Underlying *_this);
                return new(__JPH_Vec3_GetSign(_UnderlyingPtr), is_owning: true);
            }

            /// Compress a unit vector to a 32 bit value, precision is around 10^-4
            /// Generated from method `JPH::Vec3::CompressUnitVector`.
            public unsafe uint CompressUnitVector()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_CompressUnitVector", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_CompressUnitVector", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_Vec3_CompressUnitVector(_Underlying *_this);
                return __JPH_Vec3_CompressUnitVector(_UnderlyingPtr);
            }

            /// Decompress a unit vector from a 32 bit value
            /// Generated from method `JPH::Vec3::sDecompressUnitVector`.
            public static unsafe Jolt.JPH.Vec3 SDecompressUnitVector(uint inValue)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sDecompressUnitVector", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sDecompressUnitVector", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sDecompressUnitVector(uint inValue);
                return new(__JPH_Vec3_sDecompressUnitVector(inValue), is_owning: true);
            }

            /// Internal helper function that checks that W is equal to Z, so e.g. dividing by it should not generate div by 0
            /// Generated from method `JPH::Vec3::CheckW`.
            public unsafe void CheckW()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_CheckW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_CheckW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec3_CheckW(_Underlying *_this);
                __JPH_Vec3_CheckW(_UnderlyingPtr);
            }

            /// Multiply vector with float
            /// Generated from function `JPH::operator*`.
            public static unsafe Jolt.JPH.Vec3 operator*(float inV1, Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_float_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_float_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__Jolt_mul_float_JPH_Vec3(float inV1, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__Jolt_mul_float_JPH_Vec3(inV1, inV2._UnderlyingPtr), is_owning: true);
            }

            // IEquatable:

            public bool Equals(Jolt.JPH.Const_Vec3? inV2)
            {
                if (inV2 is null)
                    return false;
                return this == inV2;
            }

            public override bool Equals(object? other)
            {
                if (other is null)
                    return false;
                if (other is Jolt.JPH.Const_Vec3)
                    return this == (Jolt.JPH.Const_Vec3)other;
                return false;
            }
        }

        /// 3 component vector (stored as 4 vectors).
        /// Note that we keep the 4th component the same as the 3rd component to avoid divisions by zero when JPH_FLOATING_POINT_EXCEPTIONS_ENABLED defined
        /// Generated from class `JPH::Vec3`.
        /// This is the non-const half of the class.
        public class Vec3 : Const_Vec3
        {
            internal unsafe Vec3(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Vec3() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_DefaultConstruct();
                _UnderlyingPtr = __JPH_Vec3_DefaultConstruct();
            }

            /// Generated from constructor `JPH::Vec3::Vec3`.
            public unsafe Vec3(Jolt.JPH.Const_Vec3 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_ConstructFromAnother(Jolt.JPH.Vec3._Underlying *inRHS);
                _UnderlyingPtr = __JPH_Vec3_ConstructFromAnother(inRHS._UnderlyingPtr);
                _KeepAlive(inRHS);
            }

            /// Generated from constructor `JPH::Vec3::Vec3`.
            public Vec3(Vec3 inRHS) : this((Const_Vec3)inRHS) {}

            /// Generated from constructor `JPH::Vec3::Vec3`.
            public unsafe Vec3(Jolt.JPH.Const_Vec4 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Construct_1_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Construct_1_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Construct_1_JPH_Vec4(Jolt.JPH.Vec4._Underlying *inRHS);
                _UnderlyingPtr = __JPH_Vec3_Construct_1_JPH_Vec4(inRHS._UnderlyingPtr);
            }

            /// Load 3 floats from memory
            /// Generated from constructor `JPH::Vec3::Vec3`.
            public unsafe Vec3(Jolt.JPH.Const_Float3 inV) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Construct_1_JPH_Float3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Construct_1_JPH_Float3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Construct_1_JPH_Float3(Jolt.JPH.Const_Float3._Underlying *inV);
                _UnderlyingPtr = __JPH_Vec3_Construct_1_JPH_Float3(inV._UnderlyingPtr);
            }

            /// Create a vector from 3 components
            /// Generated from constructor `JPH::Vec3::Vec3`.
            public unsafe Vec3(float inX, float inY, float inZ) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_Construct_3(float inX, float inY, float inZ);
                _UnderlyingPtr = __JPH_Vec3_Construct_3(inX, inY, inZ);
            }

            /// Generated from method `JPH::Vec3::operator=`.
            public unsafe Jolt.JPH.Vec3 Assign(Jolt.JPH.Const_Vec3 inRHS)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_AssignFromAnother(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inRHS);
                Jolt.JPH.Vec3 __ret;
                __ret = new(__JPH_Vec3_AssignFromAnother(_UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: false);
                _DiscardKeepAlive();
                _KeepAlive(inRHS);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Set individual components
            /// Generated from method `JPH::Vec3::SetX`.
            public unsafe void SetX(float inX)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_SetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_SetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec3_SetX(_Underlying *_this, float inX);
                __JPH_Vec3_SetX(_UnderlyingPtr, inX);
            }

            /// Generated from method `JPH::Vec3::SetY`.
            public unsafe void SetY(float inY)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_SetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_SetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec3_SetY(_Underlying *_this, float inY);
                __JPH_Vec3_SetY(_UnderlyingPtr, inY);
            }

            /// Generated from method `JPH::Vec3::SetZ`.
            public unsafe void SetZ(float inZ)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_SetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_SetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec3_SetZ(_Underlying *_this, float inZ);
                __JPH_Vec3_SetZ(_UnderlyingPtr, inZ);
            }

            /// Set all components
            /// Generated from method `JPH::Vec3::Set`.
            public unsafe void Set(float inX, float inY, float inZ)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_Set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_Set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec3_Set(_Underlying *_this, float inX, float inY, float inZ);
                __JPH_Vec3_Set(_UnderlyingPtr, inX, inY, inZ);
            }

            /// Set float component by index
            /// Generated from method `JPH::Vec3::SetComponent`.
            public unsafe void SetComponent(uint inCoordinate, float inValue)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_SetComponent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_SetComponent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Vec3_SetComponent(_Underlying *_this, uint inCoordinate, float inValue);
                __JPH_Vec3_SetComponent(_UnderlyingPtr, inCoordinate, inValue);
            }

            /// Multiply vector with float
            /// Generated from method `JPH::Vec3::operator*=`.
            public unsafe Jolt.JPH.Vec3 MulAssign(float inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_mul_assign_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_mul_assign_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_mul_assign_float(_Underlying *_this, float inV2);
                Jolt.JPH.Vec3 __ret;
                __ret = new(__JPH_Vec3_mul_assign_float(_UnderlyingPtr, inV2), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Multiply vector with vector
            /// Generated from method `JPH::Vec3::operator*=`.
            public unsafe Jolt.JPH.Vec3 MulAssign(Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_mul_assign_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_mul_assign_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_mul_assign_JPH_Vec3(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                Jolt.JPH.Vec3 __ret;
                __ret = new(__JPH_Vec3_mul_assign_JPH_Vec3(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Divide vector by float
            /// Generated from method `JPH::Vec3::operator/=`.
            public unsafe Jolt.JPH.Vec3 DivAssign(float inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_div_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_div_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_div_assign(_Underlying *_this, float inV2);
                Jolt.JPH.Vec3 __ret;
                __ret = new(__JPH_Vec3_div_assign(_UnderlyingPtr, inV2), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Add two float vectors (component wise)
            /// Generated from method `JPH::Vec3::operator+=`.
            public unsafe Jolt.JPH.Vec3 AddAssign(Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_add_assign(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                Jolt.JPH.Vec3 __ret;
                __ret = new(__JPH_Vec3_add_assign(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Subtract two float vectors (component wise)
            /// Generated from method `JPH::Vec3::operator-=`.
            public unsafe Jolt.JPH.Vec3 SubAssign(Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Vec3_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Vec3_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Vec3_sub_assign(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                Jolt.JPH.Vec3 __ret;
                __ret = new(__JPH_Vec3_sub_assign(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }
        }

        /// This is used for optional parameters of class `Vec3` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Vec3`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Vec3`/`Const_Vec3` directly.
        public class _InOptMut_Vec3
        {
            public Vec3? Opt;

            public _InOptMut_Vec3() {}
            public _InOptMut_Vec3(Vec3 value) {Opt = value;}
            public static implicit operator _InOptMut_Vec3(Vec3 value) {return new(value);}
        }

        /// This is used for optional parameters of class `Vec3` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Vec3`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Vec3`/`Const_Vec3` to pass it to the function.
        public class _InOptConst_Vec3
        {
            public Const_Vec3? Opt;

            public _InOptConst_Vec3() {}
            public _InOptConst_Vec3(Const_Vec3 value) {Opt = value;}
            public static implicit operator _InOptConst_Vec3(Const_Vec3 value) {return new(value);}
        }
    }
}
