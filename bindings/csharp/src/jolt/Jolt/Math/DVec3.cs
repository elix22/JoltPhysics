// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// 3 component vector of doubles (stored as 4 vectors).
        /// Note that we keep the 4th component the same as the 3rd component to avoid divisions by zero when JPH_FLOATING_POINT_EXCEPTIONS_ENABLED defined
        /// Generated from class `JPH::DVec3`.
        /// This is the const half of the class.
        public class Const_DVec3 : Jolt.Object<Const_DVec3>, System.IDisposable, System.IEquatable<Jolt.JPH.Const_DVec3>
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DVec3_Destroy(_Underlying *_this);
                __JPH_DVec3_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_DVec3() {Dispose(false);}

            /// Representations of true and false for boolean operations
            public static unsafe double CTrue
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Get_cTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Get_cTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__JPH_DVec3_Get_cTrue();
                    return *__JPH_DVec3_Get_cTrue();
                }
            }

            public static unsafe double CFalse
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Get_cFalse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Get_cFalse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__JPH_DVec3_Get_cFalse();
                    return *__JPH_DVec3_Get_cFalse();
                }
            }

            internal unsafe Const_DVec3(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_DVec3() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_DefaultConstruct();
                _UnderlyingPtr = __JPH_DVec3_DefaultConstruct();
            }

            /// Generated from constructor `JPH::DVec3::DVec3`.
            public unsafe Const_DVec3(Jolt.JPH.Const_DVec3 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_ConstructFromAnother(Jolt.JPH.DVec3._Underlying *inRHS);
                _UnderlyingPtr = __JPH_DVec3_ConstructFromAnother(inRHS._UnderlyingPtr);
                _KeepAlive(inRHS);
            }

            /// Generated from constructor `JPH::DVec3::DVec3`.
            public Const_DVec3(DVec3 inRHS) : this((Const_DVec3)inRHS) {}

            // Create a std::hash/JPH::Hash for DVec3
            /// Generated from constructor `JPH::DVec3::DVec3`.
            public unsafe Const_DVec3(Jolt.JPH.Const_Vec3 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Construct_1_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Construct_1_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_Construct_1_JPH_Vec3(Jolt.JPH.Vec3._Underlying *inRHS);
                _UnderlyingPtr = __JPH_DVec3_Construct_1_JPH_Vec3(inRHS._UnderlyingPtr);
            }

            /// Generated from constructor `JPH::DVec3::DVec3`.
            public unsafe Const_DVec3(Jolt.JPH.Const_Vec4 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Construct_1_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Construct_1_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_Construct_1_JPH_Vec4(Jolt.JPH.Vec4._Underlying *inRHS);
                _UnderlyingPtr = __JPH_DVec3_Construct_1_JPH_Vec4(inRHS._UnderlyingPtr);
            }

            /// Create a vector from 3 components
            /// Generated from constructor `JPH::DVec3::DVec3`.
            public unsafe Const_DVec3(double inX, double inY, double inZ) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_Construct_3(double inX, double inY, double inZ);
                _UnderlyingPtr = __JPH_DVec3_Construct_3(inX, inY, inZ);
            }

            /// Load 3 doubles from memory
            /// Generated from constructor `JPH::DVec3::DVec3`.
            public unsafe Const_DVec3(Jolt.JPH.Const_Double3 inV) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Construct_1_JPH_Double3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Construct_1_JPH_Double3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_Construct_1_JPH_Double3(Jolt.JPH.Const_Double3._Underlying *inV);
                _UnderlyingPtr = __JPH_DVec3_Construct_1_JPH_Double3(inV._UnderlyingPtr);
            }

            /// Convert to float vector 3 rounding to nearest
            /// Generated from conversion operator `JPH::DVec3::operator JPH::Vec3`.
            public static unsafe explicit operator Jolt.JPH.Vec3(Jolt.JPH.Const_DVec3 _this)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_ConvertTo_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_ConvertTo_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_DVec3_ConvertTo_JPH_Vec3(Jolt.JPH.Const_DVec3._Underlying *_this);
                return new(__JPH_DVec3_ConvertTo_JPH_Vec3(_this._UnderlyingPtr), is_owning: true);
            }

            /// Generated from method `JPH::DVec3::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_DVec3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_DVec3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_DVec3_size_t(ulong inCount);
                return __Jolt_new_JPH_DVec3_size_t(inCount);
            }

            /// Generated from method `JPH::DVec3::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DVec3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DVec3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_DVec3_void_ptr(void *inPointer);
                __Jolt_delete_JPH_DVec3_void_ptr(inPointer);
            }

            /// Generated from method `JPH::DVec3::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DVec3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DVec3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_DVec3_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_DVec3_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::DVec3::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_DVec3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_DVec3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_DVec3_size_t(ulong inCount);
                return __Jolt_new_array_JPH_DVec3_size_t(inCount);
            }

            /// Generated from method `JPH::DVec3::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DVec3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DVec3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_DVec3_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_DVec3_void_ptr(inPointer);
            }

            /// Generated from method `JPH::DVec3::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DVec3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DVec3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_DVec3_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_DVec3_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::DVec3::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_DVec3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_DVec3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_DVec3_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_DVec3_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::DVec3::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DVec3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DVec3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_DVec3_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_DVec3_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::DVec3::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_DVec3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_DVec3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_DVec3_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_DVec3_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::DVec3::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DVec3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DVec3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_DVec3_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_DVec3_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Vector with all zeros
            /// Generated from method `JPH::DVec3::sZero`.
            public static unsafe Jolt.JPH.DVec3 SZero()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sZero();
                return new(__JPH_DVec3_sZero(), is_owning: true);
            }

            /// Vector with all ones
            /// Generated from method `JPH::DVec3::sOne`.
            public static unsafe Jolt.JPH.DVec3 SOne()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sOne", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sOne", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sOne();
                return new(__JPH_DVec3_sOne(), is_owning: true);
            }

            /// Vectors with the principal axis
            /// Generated from method `JPH::DVec3::sAxisX`.
            public static unsafe Jolt.JPH.DVec3 SAxisX()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sAxisX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sAxisX();
                return new(__JPH_DVec3_sAxisX(), is_owning: true);
            }

            /// Generated from method `JPH::DVec3::sAxisY`.
            public static unsafe Jolt.JPH.DVec3 SAxisY()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sAxisY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sAxisY();
                return new(__JPH_DVec3_sAxisY(), is_owning: true);
            }

            /// Generated from method `JPH::DVec3::sAxisZ`.
            public static unsafe Jolt.JPH.DVec3 SAxisZ()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sAxisZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sAxisZ();
                return new(__JPH_DVec3_sAxisZ(), is_owning: true);
            }

            /// Replicate inV across all components
            /// Generated from method `JPH::DVec3::sReplicate`.
            public static unsafe Jolt.JPH.DVec3 SReplicate(double inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sReplicate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sReplicate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sReplicate(double inV);
                return new(__JPH_DVec3_sReplicate(inV), is_owning: true);
            }

            /// Vector with all NaN's
            /// Generated from method `JPH::DVec3::sNaN`.
            public static unsafe Jolt.JPH.DVec3 SNaN()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sNaN();
                return new(__JPH_DVec3_sNaN(), is_owning: true);
            }

            /// Load 3 doubles from memory (reads 64 bits extra which it doesn't use)
            /// Generated from method `JPH::DVec3::sLoadDouble3Unsafe`.
            public static unsafe Jolt.JPH.DVec3 SLoadDouble3Unsafe(Jolt.JPH.Const_Double3 inV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sLoadDouble3Unsafe", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sLoadDouble3Unsafe", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sLoadDouble3Unsafe(Jolt.JPH.Const_Double3._Underlying *inV);
                return new(__JPH_DVec3_sLoadDouble3Unsafe(inV._UnderlyingPtr), is_owning: true);
            }

            /// Store 3 doubles to memory
            /// Generated from method `JPH::DVec3::StoreDouble3`.
            public unsafe void StoreDouble3(Jolt.JPH.Double3? outV)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_StoreDouble3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_StoreDouble3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DVec3_StoreDouble3(_Underlying *_this, Jolt.JPH.Double3._Underlying *outV);
                __JPH_DVec3_StoreDouble3(_UnderlyingPtr, outV is not null ? outV._UnderlyingPtr : null);
            }

            /// Prepare to convert to float vector 3 rounding towards zero (returns DVec3 that can be converted to a Vec3 to get the rounding)
            /// Generated from method `JPH::DVec3::PrepareRoundToZero`.
            public unsafe Jolt.JPH.DVec3 PrepareRoundToZero()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_PrepareRoundToZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_PrepareRoundToZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_PrepareRoundToZero(_Underlying *_this);
                return new(__JPH_DVec3_PrepareRoundToZero(_UnderlyingPtr), is_owning: true);
            }

            /// Prepare to convert to float vector 3 rounding towards positive/negative inf (returns DVec3 that can be converted to a Vec3 to get the rounding)
            /// Generated from method `JPH::DVec3::PrepareRoundToInf`.
            public unsafe Jolt.JPH.DVec3 PrepareRoundToInf()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_PrepareRoundToInf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_PrepareRoundToInf", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_PrepareRoundToInf(_Underlying *_this);
                return new(__JPH_DVec3_PrepareRoundToInf(_UnderlyingPtr), is_owning: true);
            }

            /// Convert to float vector 3 rounding down
            /// Generated from method `JPH::DVec3::ToVec3RoundDown`.
            public unsafe Jolt.JPH.Vec3 ToVec3RoundDown()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_ToVec3RoundDown", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_ToVec3RoundDown", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_DVec3_ToVec3RoundDown(_Underlying *_this);
                return new(__JPH_DVec3_ToVec3RoundDown(_UnderlyingPtr), is_owning: true);
            }

            /// Convert to float vector 3 rounding up
            /// Generated from method `JPH::DVec3::ToVec3RoundUp`.
            public unsafe Jolt.JPH.Vec3 ToVec3RoundUp()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_ToVec3RoundUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_ToVec3RoundUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_DVec3_ToVec3RoundUp(_Underlying *_this);
                return new(__JPH_DVec3_ToVec3RoundUp(_UnderlyingPtr), is_owning: true);
            }

            /// Return the minimum value of each of the components
            /// Generated from method `JPH::DVec3::sMin`.
            public static unsafe Jolt.JPH.DVec3 SMin(Jolt.JPH.Const_DVec3 inV1, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sMin(Jolt.JPH.Const_DVec3._Underlying *inV1, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__JPH_DVec3_sMin(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Return the maximum of each of the components
            /// Generated from method `JPH::DVec3::sMax`.
            public static unsafe Jolt.JPH.DVec3 SMax(Jolt.JPH.Const_DVec3 inV1, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sMax(Jolt.JPH.Const_DVec3._Underlying *inV1, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__JPH_DVec3_sMax(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Clamp a vector between min and max (component wise)
            /// Generated from method `JPH::DVec3::sClamp`.
            public static unsafe Jolt.JPH.DVec3 SClamp(Jolt.JPH.Const_DVec3 inV, Jolt.JPH.Const_DVec3 inMin, Jolt.JPH.Const_DVec3 inMax)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sClamp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sClamp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sClamp(Jolt.JPH.Const_DVec3._Underlying *inV, Jolt.JPH.Const_DVec3._Underlying *inMin, Jolt.JPH.Const_DVec3._Underlying *inMax);
                return new(__JPH_DVec3_sClamp(inV._UnderlyingPtr, inMin._UnderlyingPtr, inMax._UnderlyingPtr), is_owning: true);
            }

            /// Equals (component wise)
            /// Generated from method `JPH::DVec3::sEquals`.
            public static unsafe Jolt.JPH.DVec3 SEquals(Jolt.JPH.Const_DVec3 inV1, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sEquals", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sEquals", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sEquals(Jolt.JPH.Const_DVec3._Underlying *inV1, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__JPH_DVec3_sEquals(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Less than (component wise)
            /// Generated from method `JPH::DVec3::sLess`.
            public static unsafe Jolt.JPH.DVec3 SLess(Jolt.JPH.Const_DVec3 inV1, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sLess", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sLess", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sLess(Jolt.JPH.Const_DVec3._Underlying *inV1, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__JPH_DVec3_sLess(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Less than or equal (component wise)
            /// Generated from method `JPH::DVec3::sLessOrEqual`.
            public static unsafe Jolt.JPH.DVec3 SLessOrEqual(Jolt.JPH.Const_DVec3 inV1, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sLessOrEqual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sLessOrEqual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sLessOrEqual(Jolt.JPH.Const_DVec3._Underlying *inV1, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__JPH_DVec3_sLessOrEqual(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Greater than (component wise)
            /// Generated from method `JPH::DVec3::sGreater`.
            public static unsafe Jolt.JPH.DVec3 SGreater(Jolt.JPH.Const_DVec3 inV1, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sGreater", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sGreater", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sGreater(Jolt.JPH.Const_DVec3._Underlying *inV1, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__JPH_DVec3_sGreater(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Greater than or equal (component wise)
            /// Generated from method `JPH::DVec3::sGreaterOrEqual`.
            public static unsafe Jolt.JPH.DVec3 SGreaterOrEqual(Jolt.JPH.Const_DVec3 inV1, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sGreaterOrEqual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sGreaterOrEqual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sGreaterOrEqual(Jolt.JPH.Const_DVec3._Underlying *inV1, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__JPH_DVec3_sGreaterOrEqual(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Calculates inMul1 * inMul2 + inAdd
            /// Generated from method `JPH::DVec3::sFusedMultiplyAdd`.
            public static unsafe Jolt.JPH.DVec3 SFusedMultiplyAdd(Jolt.JPH.Const_DVec3 inMul1, Jolt.JPH.Const_DVec3 inMul2, Jolt.JPH.Const_DVec3 inAdd)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sFusedMultiplyAdd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sFusedMultiplyAdd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sFusedMultiplyAdd(Jolt.JPH.Const_DVec3._Underlying *inMul1, Jolt.JPH.Const_DVec3._Underlying *inMul2, Jolt.JPH.Const_DVec3._Underlying *inAdd);
                return new(__JPH_DVec3_sFusedMultiplyAdd(inMul1._UnderlyingPtr, inMul2._UnderlyingPtr, inAdd._UnderlyingPtr), is_owning: true);
            }

            /// Component wise select, returns inNotSet when highest bit of inControl = 0 and inSet when highest bit of inControl = 1
            /// Generated from method `JPH::DVec3::sSelect`.
            public static unsafe Jolt.JPH.DVec3 SSelect(Jolt.JPH.Const_DVec3 inNotSet, Jolt.JPH.Const_DVec3 inSet, Jolt.JPH.Const_DVec3 inControl)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sSelect", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sSelect", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sSelect(Jolt.JPH.Const_DVec3._Underlying *inNotSet, Jolt.JPH.Const_DVec3._Underlying *inSet, Jolt.JPH.Const_DVec3._Underlying *inControl);
                return new(__JPH_DVec3_sSelect(inNotSet._UnderlyingPtr, inSet._UnderlyingPtr, inControl._UnderlyingPtr), is_owning: true);
            }

            /// Logical or (component wise)
            /// Generated from method `JPH::DVec3::sOr`.
            public static unsafe Jolt.JPH.DVec3 SOr(Jolt.JPH.Const_DVec3 inV1, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sOr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sOr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sOr(Jolt.JPH.Const_DVec3._Underlying *inV1, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__JPH_DVec3_sOr(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Logical xor (component wise)
            /// Generated from method `JPH::DVec3::sXor`.
            public static unsafe Jolt.JPH.DVec3 SXor(Jolt.JPH.Const_DVec3 inV1, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sXor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sXor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sXor(Jolt.JPH.Const_DVec3._Underlying *inV1, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__JPH_DVec3_sXor(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Logical and (component wise)
            /// Generated from method `JPH::DVec3::sAnd`.
            public static unsafe Jolt.JPH.DVec3 SAnd(Jolt.JPH.Const_DVec3 inV1, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sAnd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sAnd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sAnd(Jolt.JPH.Const_DVec3._Underlying *inV1, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__JPH_DVec3_sAnd(inV1._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Store if X is true in bit 0, Y in bit 1, Z in bit 2 and W in bit 3 (true is when highest bit of component is set)
            /// Generated from method `JPH::DVec3::GetTrues`.
            public unsafe int GetTrues()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_GetTrues", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_GetTrues", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_DVec3_GetTrues(_Underlying *_this);
                return __JPH_DVec3_GetTrues(_UnderlyingPtr);
            }

            /// Test if any of the components are true (true is when highest bit of component is set)
            /// Generated from method `JPH::DVec3::TestAnyTrue`.
            public unsafe bool TestAnyTrue()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_TestAnyTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_TestAnyTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_DVec3_TestAnyTrue(_Underlying *_this);
                return __JPH_DVec3_TestAnyTrue(_UnderlyingPtr) != 0;
            }

            /// Test if all components are true (true is when highest bit of component is set)
            /// Generated from method `JPH::DVec3::TestAllTrue`.
            public unsafe bool TestAllTrue()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_TestAllTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_TestAllTrue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_DVec3_TestAllTrue(_Underlying *_this);
                return __JPH_DVec3_TestAllTrue(_UnderlyingPtr) != 0;
            }

            /// Generated from method `JPH::DVec3::GetX`.
            public unsafe double GetX()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_GetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_GetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double __JPH_DVec3_GetX(_Underlying *_this);
                return __JPH_DVec3_GetX(_UnderlyingPtr);
            }

            /// Generated from method `JPH::DVec3::GetY`.
            public unsafe double GetY()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_GetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_GetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double __JPH_DVec3_GetY(_Underlying *_this);
                return __JPH_DVec3_GetY(_UnderlyingPtr);
            }

            /// Generated from method `JPH::DVec3::GetZ`.
            public unsafe double GetZ()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_GetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_GetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double __JPH_DVec3_GetZ(_Underlying *_this);
                return __JPH_DVec3_GetZ(_UnderlyingPtr);
            }

            /// Get double component by index
            /// Generated from method `JPH::DVec3::operator[]`.
            public unsafe double this[uint inCoordinate]
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double __JPH_DVec3_index(_Underlying *_this, uint inCoordinate);
                    return __JPH_DVec3_index(_UnderlyingPtr, inCoordinate);
                }
            }

            /// Comparison
            /// Generated from method `JPH::DVec3::operator==`.
            public static unsafe bool operator==(Jolt.JPH.Const_DVec3 _this, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_equal_JPH_DVec3(Jolt.JPH.Const_DVec3._Underlying *_this, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return __Jolt_equal_JPH_DVec3(_this._UnderlyingPtr, inV2._UnderlyingPtr) != 0;
            }

            public static unsafe bool operator!=(Jolt.JPH.Const_DVec3 _this, Jolt.JPH.Const_DVec3 inV2)
            {
                return !(_this == inV2);
            }

            /// Test if two vectors are close
            /// Generated from method `JPH::DVec3::IsClose`.
            /// Parameter `inMaxDistSq` defaults to `9.9999999999999992e-25`.
            public unsafe bool IsClose(Jolt.JPH.Const_DVec3 inV2, double? inMaxDistSq = null)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_IsClose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_IsClose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_DVec3_IsClose(_Underlying *_this, Jolt.JPH.Const_DVec3._Underlying *inV2, double *inMaxDistSq);
                double __deref_inMaxDistSq = inMaxDistSq.GetValueOrDefault();
                return __JPH_DVec3_IsClose(_UnderlyingPtr, inV2._UnderlyingPtr, inMaxDistSq.HasValue ? &__deref_inMaxDistSq : null) != 0;
            }

            /// Test if vector is near zero
            /// Generated from method `JPH::DVec3::IsNearZero`.
            /// Parameter `inMaxDistSq` defaults to `9.9999999999999992e-25`.
            public unsafe bool IsNearZero(double? inMaxDistSq = null)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_IsNearZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_IsNearZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_DVec3_IsNearZero(_Underlying *_this, double *inMaxDistSq);
                double __deref_inMaxDistSq = inMaxDistSq.GetValueOrDefault();
                return __JPH_DVec3_IsNearZero(_UnderlyingPtr, inMaxDistSq.HasValue ? &__deref_inMaxDistSq : null) != 0;
            }

            /// Test if vector is normalized
            /// Generated from method `JPH::DVec3::IsNormalized`.
            /// Parameter `inTolerance` defaults to `9.9999999999999998e-13`.
            public unsafe bool IsNormalized(double? inTolerance = null)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_IsNormalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_IsNormalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_DVec3_IsNormalized(_Underlying *_this, double *inTolerance);
                double __deref_inTolerance = inTolerance.GetValueOrDefault();
                return __JPH_DVec3_IsNormalized(_UnderlyingPtr, inTolerance.HasValue ? &__deref_inTolerance : null) != 0;
            }

            /// Test if vector contains NaN elements
            /// Generated from method `JPH::DVec3::IsNaN`.
            public unsafe bool IsNaN()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_IsNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_IsNaN", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_DVec3_IsNaN(_Underlying *_this);
                return __JPH_DVec3_IsNaN(_UnderlyingPtr) != 0;
            }

            /// Multiply two double vectors (component wise)
            /// Generated from method `JPH::DVec3::operator*`.
            public static unsafe Jolt.JPH.DVec3 operator*(Jolt.JPH.Const_DVec3 _this, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__Jolt_mul_JPH_DVec3(Jolt.JPH.Const_DVec3._Underlying *_this, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__Jolt_mul_JPH_DVec3(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Multiply vector with double
            /// Generated from method `JPH::DVec3::operator*`.
            public static unsafe Jolt.JPH.DVec3 operator*(Jolt.JPH.Const_DVec3 _this, double inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_JPH_DVec3_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_JPH_DVec3_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__Jolt_mul_JPH_DVec3_double(Jolt.JPH.Const_DVec3._Underlying *_this, double inV2);
                return new(__Jolt_mul_JPH_DVec3_double(_this._UnderlyingPtr, inV2), is_owning: true);
            }

            /// Divide vector by double
            /// Generated from method `JPH::DVec3::operator/`.
            public static unsafe Jolt.JPH.DVec3 operator/(Jolt.JPH.Const_DVec3 _this, double inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_div_JPH_DVec3_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_div_JPH_DVec3_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__Jolt_div_JPH_DVec3_double(Jolt.JPH.Const_DVec3._Underlying *_this, double inV2);
                return new(__Jolt_div_JPH_DVec3_double(_this._UnderlyingPtr, inV2), is_owning: true);
            }

            /// Add two vectors (component wise)
            /// Generated from method `JPH::DVec3::operator+`.
            public static unsafe Jolt.JPH.DVec3 operator+(Jolt.JPH.Const_DVec3 _this, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_add_JPH_DVec3_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_add_JPH_DVec3_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__Jolt_add_JPH_DVec3_JPH_Vec3(Jolt.JPH.Const_DVec3._Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__Jolt_add_JPH_DVec3_JPH_Vec3(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Add two double vectors (component wise)
            /// Generated from method `JPH::DVec3::operator+`.
            public static unsafe Jolt.JPH.DVec3 operator+(Jolt.JPH.Const_DVec3 _this, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_add_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_add_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__Jolt_add_JPH_DVec3(Jolt.JPH.Const_DVec3._Underlying *_this, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__Jolt_add_JPH_DVec3(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Negate
            /// Generated from method `JPH::DVec3::operator-`.
            public static unsafe Jolt.JPH.DVec3 operator-(Jolt.JPH.Const_DVec3 _this)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_neg_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_neg_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__Jolt_neg_JPH_DVec3(Jolt.JPH.Const_DVec3._Underlying *_this);
                return new(__Jolt_neg_JPH_DVec3(_this._UnderlyingPtr), is_owning: true);
            }

            /// Subtract two vectors (component wise)
            /// Generated from method `JPH::DVec3::operator-`.
            public static unsafe Jolt.JPH.DVec3 operator-(Jolt.JPH.Const_DVec3 _this, Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_sub_JPH_DVec3_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_sub_JPH_DVec3_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__Jolt_sub_JPH_DVec3_JPH_Vec3(Jolt.JPH.Const_DVec3._Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                return new(__Jolt_sub_JPH_DVec3_JPH_Vec3(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Subtract two double vectors (component wise)
            /// Generated from method `JPH::DVec3::operator-`.
            public static unsafe Jolt.JPH.DVec3 operator-(Jolt.JPH.Const_DVec3 _this, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_sub_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_sub_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__Jolt_sub_JPH_DVec3(Jolt.JPH.Const_DVec3._Underlying *_this, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__Jolt_sub_JPH_DVec3(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Divide (component wise)
            /// Generated from method `JPH::DVec3::operator/`.
            public static unsafe Jolt.JPH.DVec3 operator/(Jolt.JPH.Const_DVec3 _this, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_div_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_div_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__Jolt_div_JPH_DVec3(Jolt.JPH.Const_DVec3._Underlying *_this, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__Jolt_div_JPH_DVec3(_this._UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Return the absolute value of each of the components
            /// Generated from method `JPH::DVec3::Abs`.
            public unsafe Jolt.JPH.DVec3 Abs()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Abs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Abs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_Abs(_Underlying *_this);
                return new(__JPH_DVec3_Abs(_UnderlyingPtr), is_owning: true);
            }

            /// Reciprocal vector (1 / value) for each of the components
            /// Generated from method `JPH::DVec3::Reciprocal`.
            public unsafe Jolt.JPH.DVec3 Reciprocal()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Reciprocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Reciprocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_Reciprocal(_Underlying *_this);
                return new(__JPH_DVec3_Reciprocal(_UnderlyingPtr), is_owning: true);
            }

            /// Cross product
            /// Generated from method `JPH::DVec3::Cross`.
            public unsafe Jolt.JPH.DVec3 Cross(Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Cross", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Cross", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_Cross(_Underlying *_this, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__JPH_DVec3_Cross(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: true);
            }

            /// Dot product
            /// Generated from method `JPH::DVec3::Dot`.
            public unsafe double Dot(Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double __JPH_DVec3_Dot(_Underlying *_this, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return __JPH_DVec3_Dot(_UnderlyingPtr, inV2._UnderlyingPtr);
            }

            /// Squared length of vector
            /// Generated from method `JPH::DVec3::LengthSq`.
            public unsafe double LengthSq()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_LengthSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_LengthSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double __JPH_DVec3_LengthSq(_Underlying *_this);
                return __JPH_DVec3_LengthSq(_UnderlyingPtr);
            }

            /// Length of vector
            /// Generated from method `JPH::DVec3::Length`.
            public unsafe double Length()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Length", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Length", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double __JPH_DVec3_Length(_Underlying *_this);
                return __JPH_DVec3_Length(_UnderlyingPtr);
            }

            /// Normalize vector
            /// Generated from method `JPH::DVec3::Normalized`.
            public unsafe Jolt.JPH.DVec3 Normalized()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Normalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Normalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_Normalized(_Underlying *_this);
                return new(__JPH_DVec3_Normalized(_UnderlyingPtr), is_owning: true);
            }

            /// Component wise square root
            /// Generated from method `JPH::DVec3::Sqrt`.
            public unsafe Jolt.JPH.DVec3 Sqrt()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Sqrt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Sqrt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_Sqrt(_Underlying *_this);
                return new(__JPH_DVec3_Sqrt(_UnderlyingPtr), is_owning: true);
            }

            /// Get vector that contains the sign of each element (returns 1 if positive, -1 if negative)
            /// Generated from method `JPH::DVec3::GetSign`.
            public unsafe Jolt.JPH.DVec3 GetSign()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_GetSign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_GetSign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_GetSign(_Underlying *_this);
                return new(__JPH_DVec3_GetSign(_UnderlyingPtr), is_owning: true);
            }

            /// Internal helper function that checks that W is equal to Z, so e.g. dividing by it should not generate div by 0
            /// Generated from method `JPH::DVec3::CheckW`.
            public unsafe void CheckW()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_CheckW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_CheckW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DVec3_CheckW(_Underlying *_this);
                __JPH_DVec3_CheckW(_UnderlyingPtr);
            }

            /// Multiply vector with double
            /// Generated from function `JPH::operator*`.
            public static unsafe Jolt.JPH.DVec3 operator*(double inV1, Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_mul_double_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_mul_double_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__Jolt_mul_double_JPH_DVec3(double inV1, Jolt.JPH.Const_DVec3._Underlying *inV2);
                return new(__Jolt_mul_double_JPH_DVec3(inV1, inV2._UnderlyingPtr), is_owning: true);
            }

            // IEquatable:

            public bool Equals(Jolt.JPH.Const_DVec3? inV2)
            {
                if (inV2 is null)
                    return false;
                return this == inV2;
            }

            public override bool Equals(object? other)
            {
                if (other is null)
                    return false;
                if (other is Jolt.JPH.Const_DVec3)
                    return this == (Jolt.JPH.Const_DVec3)other;
                return false;
            }
        }

        /// 3 component vector of doubles (stored as 4 vectors).
        /// Note that we keep the 4th component the same as the 3rd component to avoid divisions by zero when JPH_FLOATING_POINT_EXCEPTIONS_ENABLED defined
        /// Generated from class `JPH::DVec3`.
        /// This is the non-const half of the class.
        public class DVec3 : Const_DVec3
        {
            internal unsafe DVec3(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe DVec3() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_DefaultConstruct();
                _UnderlyingPtr = __JPH_DVec3_DefaultConstruct();
            }

            /// Generated from constructor `JPH::DVec3::DVec3`.
            public unsafe DVec3(Jolt.JPH.Const_DVec3 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_ConstructFromAnother(Jolt.JPH.DVec3._Underlying *inRHS);
                _UnderlyingPtr = __JPH_DVec3_ConstructFromAnother(inRHS._UnderlyingPtr);
                _KeepAlive(inRHS);
            }

            /// Generated from constructor `JPH::DVec3::DVec3`.
            public DVec3(DVec3 inRHS) : this((Const_DVec3)inRHS) {}

            // Create a std::hash/JPH::Hash for DVec3
            /// Generated from constructor `JPH::DVec3::DVec3`.
            public unsafe DVec3(Jolt.JPH.Const_Vec3 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Construct_1_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Construct_1_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_Construct_1_JPH_Vec3(Jolt.JPH.Vec3._Underlying *inRHS);
                _UnderlyingPtr = __JPH_DVec3_Construct_1_JPH_Vec3(inRHS._UnderlyingPtr);
            }

            /// Generated from constructor `JPH::DVec3::DVec3`.
            public unsafe DVec3(Jolt.JPH.Const_Vec4 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Construct_1_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Construct_1_JPH_Vec4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_Construct_1_JPH_Vec4(Jolt.JPH.Vec4._Underlying *inRHS);
                _UnderlyingPtr = __JPH_DVec3_Construct_1_JPH_Vec4(inRHS._UnderlyingPtr);
            }

            /// Create a vector from 3 components
            /// Generated from constructor `JPH::DVec3::DVec3`.
            public unsafe DVec3(double inX, double inY, double inZ) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_Construct_3(double inX, double inY, double inZ);
                _UnderlyingPtr = __JPH_DVec3_Construct_3(inX, inY, inZ);
            }

            /// Load 3 doubles from memory
            /// Generated from constructor `JPH::DVec3::DVec3`.
            public unsafe DVec3(Jolt.JPH.Const_Double3 inV) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Construct_1_JPH_Double3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Construct_1_JPH_Double3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_Construct_1_JPH_Double3(Jolt.JPH.Const_Double3._Underlying *inV);
                _UnderlyingPtr = __JPH_DVec3_Construct_1_JPH_Double3(inV._UnderlyingPtr);
            }

            /// Generated from method `JPH::DVec3::operator=`.
            public unsafe Jolt.JPH.DVec3 Assign(Jolt.JPH.Const_DVec3 inRHS)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_AssignFromAnother(_Underlying *_this, Jolt.JPH.DVec3._Underlying *inRHS);
                Jolt.JPH.DVec3 __ret;
                __ret = new(__JPH_DVec3_AssignFromAnother(_UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: false);
                _DiscardKeepAlive();
                _KeepAlive(inRHS);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Set individual components
            /// Generated from method `JPH::DVec3::SetX`.
            public unsafe void SetX(double inX)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_SetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_SetX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DVec3_SetX(_Underlying *_this, double inX);
                __JPH_DVec3_SetX(_UnderlyingPtr, inX);
            }

            /// Generated from method `JPH::DVec3::SetY`.
            public unsafe void SetY(double inY)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_SetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_SetY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DVec3_SetY(_Underlying *_this, double inY);
                __JPH_DVec3_SetY(_UnderlyingPtr, inY);
            }

            /// Generated from method `JPH::DVec3::SetZ`.
            public unsafe void SetZ(double inZ)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_SetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_SetZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DVec3_SetZ(_Underlying *_this, double inZ);
                __JPH_DVec3_SetZ(_UnderlyingPtr, inZ);
            }

            /// Set all components
            /// Generated from method `JPH::DVec3::Set`.
            public unsafe void Set(double inX, double inY, double inZ)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_Set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_Set", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DVec3_Set(_Underlying *_this, double inX, double inY, double inZ);
                __JPH_DVec3_Set(_UnderlyingPtr, inX, inY, inZ);
            }

            /// Set double component by index
            /// Generated from method `JPH::DVec3::SetComponent`.
            public unsafe void SetComponent(uint inCoordinate, double inValue)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_SetComponent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_SetComponent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DVec3_SetComponent(_Underlying *_this, uint inCoordinate, double inValue);
                __JPH_DVec3_SetComponent(_UnderlyingPtr, inCoordinate, inValue);
            }

            /// Multiply vector with double
            /// Generated from method `JPH::DVec3::operator*=`.
            public unsafe Jolt.JPH.DVec3 MulAssign(double inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_mul_assign_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_mul_assign_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_mul_assign_double(_Underlying *_this, double inV2);
                Jolt.JPH.DVec3 __ret;
                __ret = new(__JPH_DVec3_mul_assign_double(_UnderlyingPtr, inV2), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Multiply vector with vector
            /// Generated from method `JPH::DVec3::operator*=`.
            public unsafe Jolt.JPH.DVec3 MulAssign(Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_mul_assign_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_mul_assign_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_mul_assign_JPH_DVec3(_Underlying *_this, Jolt.JPH.Const_DVec3._Underlying *inV2);
                Jolt.JPH.DVec3 __ret;
                __ret = new(__JPH_DVec3_mul_assign_JPH_DVec3(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Divide vector by double
            /// Generated from method `JPH::DVec3::operator/=`.
            public unsafe Jolt.JPH.DVec3 DivAssign(double inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_div_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_div_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_div_assign(_Underlying *_this, double inV2);
                Jolt.JPH.DVec3 __ret;
                __ret = new(__JPH_DVec3_div_assign(_UnderlyingPtr, inV2), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Add two vectors (component wise)
            /// Generated from method `JPH::DVec3::operator+=`.
            public unsafe Jolt.JPH.DVec3 AddAssign(Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_add_assign_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_add_assign_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_add_assign_JPH_Vec3(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                Jolt.JPH.DVec3 __ret;
                __ret = new(__JPH_DVec3_add_assign_JPH_Vec3(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Add two double vectors (component wise)
            /// Generated from method `JPH::DVec3::operator+=`.
            public unsafe Jolt.JPH.DVec3 AddAssign(Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_add_assign_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_add_assign_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_add_assign_JPH_DVec3(_Underlying *_this, Jolt.JPH.Const_DVec3._Underlying *inV2);
                Jolt.JPH.DVec3 __ret;
                __ret = new(__JPH_DVec3_add_assign_JPH_DVec3(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Subtract two vectors (component wise)
            /// Generated from method `JPH::DVec3::operator-=`.
            public unsafe Jolt.JPH.DVec3 SubAssign(Jolt.JPH.Const_Vec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sub_assign_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sub_assign_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sub_assign_JPH_Vec3(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inV2);
                Jolt.JPH.DVec3 __ret;
                __ret = new(__JPH_DVec3_sub_assign_JPH_Vec3(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }

            /// Subtract two vectors (component wise)
            /// Generated from method `JPH::DVec3::operator-=`.
            public unsafe Jolt.JPH.DVec3 SubAssign(Jolt.JPH.Const_DVec3 inV2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DVec3_sub_assign_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DVec3_sub_assign_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DVec3._Underlying *__JPH_DVec3_sub_assign_JPH_DVec3(_Underlying *_this, Jolt.JPH.Const_DVec3._Underlying *inV2);
                Jolt.JPH.DVec3 __ret;
                __ret = new(__JPH_DVec3_sub_assign_JPH_DVec3(_UnderlyingPtr, inV2._UnderlyingPtr), is_owning: false);
                __ret._KeepAlive(this);
                return __ret;
            }
        }

        /// This is used for optional parameters of class `DVec3` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_DVec3`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `DVec3`/`Const_DVec3` directly.
        public class _InOptMut_DVec3
        {
            public DVec3? Opt;

            public _InOptMut_DVec3() {}
            public _InOptMut_DVec3(DVec3 value) {Opt = value;}
            public static implicit operator _InOptMut_DVec3(DVec3 value) {return new(value);}
        }

        /// This is used for optional parameters of class `DVec3` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_DVec3`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `DVec3`/`Const_DVec3` to pass it to the function.
        public class _InOptConst_DVec3
        {
            public Const_DVec3? Opt;

            public _InOptConst_DVec3() {}
            public _InOptConst_DVec3(Const_DVec3 value) {Opt = value;}
            public static implicit operator _InOptConst_DVec3(Const_DVec3 value) {return new(value);}
        }
    }
}
