// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Class that holds 3 floats. Used as a storage class. Convert to Vec3 for calculations.
        /// Generated from class `JPH::Float3`.
        /// This is the const half of the class.
        public class Const_Float3 : Jolt.Object<Const_Float3>, System.IDisposable, System.IEquatable<Jolt.JPH.Const_Float3>
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Float3_Destroy(_Underlying *_this);
                __JPH_Float3_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Float3() {Dispose(false);}

            public unsafe float x
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_Get_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_Get_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_Float3_Get_x(_Underlying *_this);
                    return *__JPH_Float3_Get_x(_UnderlyingPtr);
                }
            }

            public unsafe float y
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_Get_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_Get_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_Float3_Get_y(_Underlying *_this);
                    return *__JPH_Float3_Get_y(_UnderlyingPtr);
                }
            }

            public unsafe float z
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_Get_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_Get_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_Float3_Get_z(_Underlying *_this);
                    return *__JPH_Float3_Get_z(_UnderlyingPtr);
                }
            }

            internal unsafe Const_Float3(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Float3() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Float3._Underlying *__JPH_Float3_DefaultConstruct();
                _UnderlyingPtr = __JPH_Float3_DefaultConstruct();
            }

            /// Generated from constructor `JPH::Float3::Float3`.
            public unsafe Const_Float3(Jolt.JPH.Const_Float3 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Float3._Underlying *__JPH_Float3_ConstructFromAnother(Jolt.JPH.Float3._Underlying *inRHS);
                _UnderlyingPtr = __JPH_Float3_ConstructFromAnother(inRHS._UnderlyingPtr);
                _KeepAlive(inRHS);
            }

            /// Generated from constructor `JPH::Float3::Float3`.
            public Const_Float3(Float3 inRHS) : this((Const_Float3)inRHS) {}

            /// Generated from constructor `JPH::Float3::Float3`.
            public unsafe Const_Float3(float inX, float inY, float inZ) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Float3._Underlying *__JPH_Float3_Construct(float inX, float inY, float inZ);
                _UnderlyingPtr = __JPH_Float3_Construct(inX, inY, inZ);
            }

            /// Generated from method `JPH::Float3::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Float3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Float3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_Float3_size_t(ulong inCount);
                return __Jolt_new_JPH_Float3_size_t(inCount);
            }

            /// Generated from method `JPH::Float3::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Float3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Float3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Float3_void_ptr(void *inPointer);
                __Jolt_delete_JPH_Float3_void_ptr(inPointer);
            }

            /// Generated from method `JPH::Float3::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Float3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Float3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Float3_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_Float3_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::Float3::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Float3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Float3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_Float3_size_t(ulong inCount);
                return __Jolt_new_array_JPH_Float3_size_t(inCount);
            }

            /// Generated from method `JPH::Float3::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Float3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Float3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Float3_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_Float3_void_ptr(inPointer);
            }

            /// Generated from method `JPH::Float3::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Float3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Float3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Float3_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_Float3_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::Float3::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Float3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Float3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_Float3_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_Float3_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::Float3::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Float3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Float3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Float3_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_Float3_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::Float3::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Float3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Float3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_Float3_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_Float3_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::Float3::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Float3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Float3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Float3_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_Float3_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::Float3::operator[]`.
            public unsafe float this[int inCoordinate]
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float __JPH_Float3_index(_Underlying *_this, int inCoordinate);
                    return __JPH_Float3_index(_UnderlyingPtr, inCoordinate);
                }
            }

            /// Generated from method `JPH::Float3::operator==`.
            public static unsafe bool operator==(Jolt.JPH.Const_Float3 _this, Jolt.JPH.Const_Float3 inRHS)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_Float3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_Float3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_equal_JPH_Float3(Jolt.JPH.Const_Float3._Underlying *_this, Jolt.JPH.Const_Float3._Underlying *inRHS);
                return __Jolt_equal_JPH_Float3(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
            }

            public static unsafe bool operator!=(Jolt.JPH.Const_Float3 _this, Jolt.JPH.Const_Float3 inRHS)
            {
                return !(_this == inRHS);
            }

            // IEquatable:

            public bool Equals(Jolt.JPH.Const_Float3? inRHS)
            {
                if (inRHS is null)
                    return false;
                return this == inRHS;
            }

            public override bool Equals(object? other)
            {
                if (other is null)
                    return false;
                if (other is Jolt.JPH.Const_Float3)
                    return this == (Jolt.JPH.Const_Float3)other;
                return false;
            }
        }

        /// Class that holds 3 floats. Used as a storage class. Convert to Vec3 for calculations.
        /// Generated from class `JPH::Float3`.
        /// This is the non-const half of the class.
        public class Float3 : Const_Float3
        {
            public new unsafe ref float x
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_GetMutable_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_GetMutable_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_Float3_GetMutable_x(_Underlying *_this);
                    return ref *__JPH_Float3_GetMutable_x(_UnderlyingPtr);
                }
            }

            public new unsafe ref float y
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_GetMutable_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_GetMutable_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_Float3_GetMutable_y(_Underlying *_this);
                    return ref *__JPH_Float3_GetMutable_y(_UnderlyingPtr);
                }
            }

            public new unsafe ref float z
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_GetMutable_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_GetMutable_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_Float3_GetMutable_z(_Underlying *_this);
                    return ref *__JPH_Float3_GetMutable_z(_UnderlyingPtr);
                }
            }

            internal unsafe Float3(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Float3() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Float3._Underlying *__JPH_Float3_DefaultConstruct();
                _UnderlyingPtr = __JPH_Float3_DefaultConstruct();
            }

            /// Generated from constructor `JPH::Float3::Float3`.
            public unsafe Float3(Jolt.JPH.Const_Float3 inRHS) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Float3._Underlying *__JPH_Float3_ConstructFromAnother(Jolt.JPH.Float3._Underlying *inRHS);
                _UnderlyingPtr = __JPH_Float3_ConstructFromAnother(inRHS._UnderlyingPtr);
                _KeepAlive(inRHS);
            }

            /// Generated from constructor `JPH::Float3::Float3`.
            public Float3(Float3 inRHS) : this((Const_Float3)inRHS) {}

            /// Generated from constructor `JPH::Float3::Float3`.
            public unsafe Float3(float inX, float inY, float inZ) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Float3._Underlying *__JPH_Float3_Construct(float inX, float inY, float inZ);
                _UnderlyingPtr = __JPH_Float3_Construct(inX, inY, inZ);
            }

            /// Generated from method `JPH::Float3::operator=`.
            public unsafe Jolt.JPH.Float3 Assign(Jolt.JPH.Const_Float3 inRHS)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Float3._Underlying *__JPH_Float3_AssignFromAnother(_Underlying *_this, Jolt.JPH.Float3._Underlying *inRHS);
                Jolt.JPH.Float3 __ret;
                __ret = new(__JPH_Float3_AssignFromAnother(_UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: false);
                _DiscardKeepAlive();
                _KeepAlive(inRHS);
                __ret._KeepAlive(this);
                return __ret;
            }
        }

        /// This is used for optional parameters of class `Float3` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Float3`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Float3`/`Const_Float3` directly.
        public class _InOptMut_Float3
        {
            public Float3? Opt;

            public _InOptMut_Float3() {}
            public _InOptMut_Float3(Float3 value) {Opt = value;}
            public static implicit operator _InOptMut_Float3(Float3 value) {return new(value);}
        }

        /// This is used for optional parameters of class `Float3` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Float3`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Float3`/`Const_Float3` to pass it to the function.
        public class _InOptConst_Float3
        {
            public Const_Float3? Opt;

            public _InOptConst_Float3() {}
            public _InOptConst_Float3(Const_Float3 value) {Opt = value;}
            public static implicit operator _InOptConst_Float3(Const_Float3 value) {return new(value);}
        }
    }
}
