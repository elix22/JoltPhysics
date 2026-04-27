// machine generated, do not edit
public static partial class JPH
{
    /// Class that holds 4 float values. Convert to Vec4 to perform calculations.
    /// Generated from class `JPH::Float4`.
    /// This is the const half of the class.
    public class Const_Float4 : JPH.Object<Const_Float4>, System.IDisposable, System.IEquatable<JPH.Const_Float4>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Float4_Destroy(_Underlying *_this);
            __JPH_Float4_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Float4() {Dispose(false);}

        public unsafe float x
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_Get_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_Get_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_Float4_Get_x(_Underlying *_this);
                return *__JPH_Float4_Get_x(_UnderlyingPtr);
            }
        }

        public unsafe float y
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_Get_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_Get_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_Float4_Get_y(_Underlying *_this);
                return *__JPH_Float4_Get_y(_UnderlyingPtr);
            }
        }

        public unsafe float z
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_Get_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_Get_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_Float4_Get_z(_Underlying *_this);
                return *__JPH_Float4_Get_z(_UnderlyingPtr);
            }
        }

        public unsafe float w
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_Get_w", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_Get_w", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_Float4_Get_w(_Underlying *_this);
                return *__JPH_Float4_Get_w(_UnderlyingPtr);
            }
        }

        internal unsafe Const_Float4(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Float4() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Float4._Underlying *__JPH_Float4_DefaultConstruct();
            _UnderlyingPtr = __JPH_Float4_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Float4::Float4`.
        public unsafe Const_Float4(JPH.Const_Float4 inRHS) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Float4._Underlying *__JPH_Float4_ConstructFromAnother(JPH.Float4._Underlying *inRHS);
            _UnderlyingPtr = __JPH_Float4_ConstructFromAnother(inRHS._UnderlyingPtr);
            _KeepAlive(inRHS);
        }

        /// Generated from constructor `JPH::Float4::Float4`.
        public Const_Float4(Float4 inRHS) : this((Const_Float4)inRHS) {}

        /// Generated from constructor `JPH::Float4::Float4`.
        public unsafe Const_Float4(float inX, float inY, float inZ, float inW) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Float4._Underlying *__JPH_Float4_Construct(float inX, float inY, float inZ, float inW);
            _UnderlyingPtr = __JPH_Float4_Construct(inX, inY, inZ, inW);
        }

        /// Generated from method `JPH::Float4::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Float4_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Float4_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Float4_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_Float4_size_t(inCount);
        }

        /// Generated from method `JPH::Float4::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Float4_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Float4_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Float4_void_ptr(void *inPointer);
            __Jolt_delete_JPH_Float4_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Float4::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Float4_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Float4_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Float4_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_Float4_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Float4::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Float4_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Float4_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Float4_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_Float4_size_t(inCount);
        }

        /// Generated from method `JPH::Float4::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Float4_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Float4_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Float4_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_Float4_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Float4::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Float4_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Float4_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Float4_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_Float4_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Float4::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Float4_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Float4_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Float4_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_Float4_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Float4::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Float4_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Float4_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Float4_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_Float4_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::Float4::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Float4_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Float4_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Float4_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_Float4_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Float4::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Float4_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Float4_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Float4_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_Float4_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::Float4::operator[]`.
        public unsafe float this[int inCoordinate]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Float4_index(_Underlying *_this, int inCoordinate);
                return __JPH_Float4_index(_UnderlyingPtr, inCoordinate);
            }
        }

        /// Generated from method `JPH::Float4::operator==`.
        public static unsafe bool operator==(JPH.Const_Float4 _this, JPH.Const_Float4 inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_Float4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_Float4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_equal_JPH_Float4(JPH.Const_Float4._Underlying *_this, JPH.Const_Float4._Underlying *inRHS);
            return __Jolt_equal_JPH_Float4(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(JPH.Const_Float4 _this, JPH.Const_Float4 inRHS)
        {
            return !(_this == inRHS);
        }

        // IEquatable:

        public bool Equals(JPH.Const_Float4? inRHS)
        {
            if (inRHS is null)
                return false;
            return this == inRHS;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is JPH.Const_Float4)
                return this == (JPH.Const_Float4)other;
            return false;
        }
    }

    /// Class that holds 4 float values. Convert to Vec4 to perform calculations.
    /// Generated from class `JPH::Float4`.
    /// This is the non-const half of the class.
    public class Float4 : Const_Float4
    {
        public new unsafe ref float x
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_GetMutable_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_GetMutable_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_Float4_GetMutable_x(_Underlying *_this);
                return ref *__JPH_Float4_GetMutable_x(_UnderlyingPtr);
            }
        }

        public new unsafe ref float y
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_GetMutable_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_GetMutable_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_Float4_GetMutable_y(_Underlying *_this);
                return ref *__JPH_Float4_GetMutable_y(_UnderlyingPtr);
            }
        }

        public new unsafe ref float z
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_GetMutable_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_GetMutable_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_Float4_GetMutable_z(_Underlying *_this);
                return ref *__JPH_Float4_GetMutable_z(_UnderlyingPtr);
            }
        }

        public new unsafe ref float w
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_GetMutable_w", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_GetMutable_w", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_Float4_GetMutable_w(_Underlying *_this);
                return ref *__JPH_Float4_GetMutable_w(_UnderlyingPtr);
            }
        }

        internal unsafe Float4(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Float4() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Float4._Underlying *__JPH_Float4_DefaultConstruct();
            _UnderlyingPtr = __JPH_Float4_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Float4::Float4`.
        public unsafe Float4(JPH.Const_Float4 inRHS) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Float4._Underlying *__JPH_Float4_ConstructFromAnother(JPH.Float4._Underlying *inRHS);
            _UnderlyingPtr = __JPH_Float4_ConstructFromAnother(inRHS._UnderlyingPtr);
            _KeepAlive(inRHS);
        }

        /// Generated from constructor `JPH::Float4::Float4`.
        public Float4(Float4 inRHS) : this((Const_Float4)inRHS) {}

        /// Generated from constructor `JPH::Float4::Float4`.
        public unsafe Float4(float inX, float inY, float inZ, float inW) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Float4._Underlying *__JPH_Float4_Construct(float inX, float inY, float inZ, float inW);
            _UnderlyingPtr = __JPH_Float4_Construct(inX, inY, inZ, inW);
        }

        /// Generated from method `JPH::Float4::operator=`.
        public unsafe JPH.Float4 Assign(JPH.Const_Float4 inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Float4_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Float4_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Float4._Underlying *__JPH_Float4_AssignFromAnother(_Underlying *_this, JPH.Float4._Underlying *inRHS);
            JPH.Float4 __ret;
            __ret = new(__JPH_Float4_AssignFromAnother(_UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: false);
            _DiscardKeepAlive();
            _KeepAlive(inRHS);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used for optional parameters of class `Float4` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Float4`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Float4`/`Const_Float4` directly.
    public class _InOptMut_Float4
    {
        public Float4? Opt;

        public _InOptMut_Float4() {}
        public _InOptMut_Float4(Float4 value) {Opt = value;}
        public static implicit operator _InOptMut_Float4(Float4 value) {return new(value);}
    }

    /// This is used for optional parameters of class `Float4` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Float4`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Float4`/`Const_Float4` to pass it to the function.
    public class _InOptConst_Float4
    {
        public Const_Float4? Opt;

        public _InOptConst_Float4() {}
        public _InOptConst_Float4(Const_Float4 value) {Opt = value;}
        public static implicit operator _InOptConst_Float4(Const_Float4 value) {return new(value);}
    }
}
