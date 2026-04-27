// machine generated, do not edit
public static partial class JPH
{
    /// Class that holds 3 doubles. Used as a storage class. Convert to DVec3 for calculations.
    /// Generated from class `JPH::Double3`.
    /// This is the const half of the class.
    public class Const_Double3 : JPH.Object<Const_Double3>, System.IDisposable, System.IEquatable<JPH.Const_Double3>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Double3_Destroy(_Underlying *_this);
            __JPH_Double3_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Double3() {Dispose(false);}

        public unsafe double x
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_Get_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_Get_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JPH_Double3_Get_x(_Underlying *_this);
                return *__JPH_Double3_Get_x(_UnderlyingPtr);
            }
        }

        public unsafe double y
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_Get_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_Get_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JPH_Double3_Get_y(_Underlying *_this);
                return *__JPH_Double3_Get_y(_UnderlyingPtr);
            }
        }

        public unsafe double z
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_Get_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_Get_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JPH_Double3_Get_z(_Underlying *_this);
                return *__JPH_Double3_Get_z(_UnderlyingPtr);
            }
        }

        internal unsafe Const_Double3(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Double3() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Double3._Underlying *__JPH_Double3_DefaultConstruct();
            _UnderlyingPtr = __JPH_Double3_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Double3::Double3`.
        public unsafe Const_Double3(JPH.Const_Double3 inRHS) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Double3._Underlying *__JPH_Double3_ConstructFromAnother(JPH.Double3._Underlying *inRHS);
            _UnderlyingPtr = __JPH_Double3_ConstructFromAnother(inRHS._UnderlyingPtr);
            _KeepAlive(inRHS);
        }

        /// Generated from constructor `JPH::Double3::Double3`.
        public Const_Double3(Double3 inRHS) : this((Const_Double3)inRHS) {}

        /// Generated from constructor `JPH::Double3::Double3`.
        public unsafe Const_Double3(double inX, double inY, double inZ) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Double3._Underlying *__JPH_Double3_Construct(double inX, double inY, double inZ);
            _UnderlyingPtr = __JPH_Double3_Construct(inX, inY, inZ);
        }

        /// Generated from method `JPH::Double3::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Double3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Double3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Double3_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_Double3_size_t(inCount);
        }

        /// Generated from method `JPH::Double3::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Double3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Double3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Double3_void_ptr(void *inPointer);
            __Jolt_delete_JPH_Double3_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Double3::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Double3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Double3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Double3_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_Double3_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Double3::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Double3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Double3_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Double3_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_Double3_size_t(inCount);
        }

        /// Generated from method `JPH::Double3::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Double3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Double3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Double3_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_Double3_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Double3::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Double3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Double3_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Double3_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_Double3_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Double3::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Double3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Double3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Double3_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_Double3_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Double3::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Double3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Double3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Double3_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_Double3_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::Double3::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Double3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Double3_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Double3_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_Double3_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Double3::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Double3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Double3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Double3_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_Double3_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::Double3::operator[]`.
        public unsafe double this[int inCoordinate]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double __JPH_Double3_index(_Underlying *_this, int inCoordinate);
                return __JPH_Double3_index(_UnderlyingPtr, inCoordinate);
            }
        }

        /// Generated from method `JPH::Double3::operator==`.
        public static unsafe bool operator==(JPH.Const_Double3 _this, JPH.Const_Double3 inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_Double3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_Double3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_equal_JPH_Double3(JPH.Const_Double3._Underlying *_this, JPH.Const_Double3._Underlying *inRHS);
            return __Jolt_equal_JPH_Double3(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(JPH.Const_Double3 _this, JPH.Const_Double3 inRHS)
        {
            return !(_this == inRHS);
        }

        // IEquatable:

        public bool Equals(JPH.Const_Double3? inRHS)
        {
            if (inRHS is null)
                return false;
            return this == inRHS;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is JPH.Const_Double3)
                return this == (JPH.Const_Double3)other;
            return false;
        }
    }

    /// Class that holds 3 doubles. Used as a storage class. Convert to DVec3 for calculations.
    /// Generated from class `JPH::Double3`.
    /// This is the non-const half of the class.
    public class Double3 : Const_Double3
    {
        public new unsafe ref double x
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_GetMutable_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_GetMutable_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JPH_Double3_GetMutable_x(_Underlying *_this);
                return ref *__JPH_Double3_GetMutable_x(_UnderlyingPtr);
            }
        }

        public new unsafe ref double y
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_GetMutable_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_GetMutable_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JPH_Double3_GetMutable_y(_Underlying *_this);
                return ref *__JPH_Double3_GetMutable_y(_UnderlyingPtr);
            }
        }

        public new unsafe ref double z
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_GetMutable_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_GetMutable_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__JPH_Double3_GetMutable_z(_Underlying *_this);
                return ref *__JPH_Double3_GetMutable_z(_UnderlyingPtr);
            }
        }

        internal unsafe Double3(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Double3() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Double3._Underlying *__JPH_Double3_DefaultConstruct();
            _UnderlyingPtr = __JPH_Double3_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Double3::Double3`.
        public unsafe Double3(JPH.Const_Double3 inRHS) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Double3._Underlying *__JPH_Double3_ConstructFromAnother(JPH.Double3._Underlying *inRHS);
            _UnderlyingPtr = __JPH_Double3_ConstructFromAnother(inRHS._UnderlyingPtr);
            _KeepAlive(inRHS);
        }

        /// Generated from constructor `JPH::Double3::Double3`.
        public Double3(Double3 inRHS) : this((Const_Double3)inRHS) {}

        /// Generated from constructor `JPH::Double3::Double3`.
        public unsafe Double3(double inX, double inY, double inZ) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Double3._Underlying *__JPH_Double3_Construct(double inX, double inY, double inZ);
            _UnderlyingPtr = __JPH_Double3_Construct(inX, inY, inZ);
        }

        /// Generated from method `JPH::Double3::operator=`.
        public unsafe JPH.Double3 Assign(JPH.Const_Double3 inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Double3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Double3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Double3._Underlying *__JPH_Double3_AssignFromAnother(_Underlying *_this, JPH.Double3._Underlying *inRHS);
            JPH.Double3 __ret;
            __ret = new(__JPH_Double3_AssignFromAnother(_UnderlyingPtr, inRHS._UnderlyingPtr), is_owning: false);
            _DiscardKeepAlive();
            _KeepAlive(inRHS);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used for optional parameters of class `Double3` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Double3`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Double3`/`Const_Double3` directly.
    public class _InOptMut_Double3
    {
        public Double3? Opt;

        public _InOptMut_Double3() {}
        public _InOptMut_Double3(Double3 value) {Opt = value;}
        public static implicit operator _InOptMut_Double3(Double3 value) {return new(value);}
    }

    /// This is used for optional parameters of class `Double3` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Double3`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Double3`/`Const_Double3` to pass it to the function.
    public class _InOptConst_Double3
    {
        public Const_Double3? Opt;

        public _InOptConst_Double3() {}
        public _InOptConst_Double3(Const_Double3 value) {Opt = value;}
        public static implicit operator _InOptConst_Double3(Const_Double3 value) {return new(value);}
    }
}
