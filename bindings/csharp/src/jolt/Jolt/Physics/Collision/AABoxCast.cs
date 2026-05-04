// machine generated, do not edit
public static partial class JPH
{
    /// Structure that holds AABox moving linearly through 3d space
    /// Generated from class `JPH::AABoxCast`.
    /// This is the const half of the class.
    public class Const_AABoxCast : JPH.Object<Const_AABoxCast>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABoxCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABoxCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_AABoxCast_Destroy(_Underlying *_this);
            __JPH_AABoxCast_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_AABoxCast() {Dispose(false);}

        ///< Axis aligned box at starting location
        public unsafe JPH.Const_AABox mBox
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABoxCast_Get_mBox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABoxCast_Get_mBox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_AABox._Underlying *__JPH_AABoxCast_Get_mBox(_Underlying *_this);
                JPH.Const_AABox __ret;
                __ret = new(__JPH_AABoxCast_Get_mBox(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction and length of the cast (anything beyond this length will not be reported as a hit)
        public unsafe JPH.Const_Vec3 mDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABoxCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABoxCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_AABoxCast_Get_mDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_AABoxCast_Get_mDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_AABoxCast(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_AABoxCast() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABoxCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABoxCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABoxCast._Underlying *__JPH_AABoxCast_DefaultConstruct();
            _UnderlyingPtr = __JPH_AABoxCast_DefaultConstruct();
        }

        /// Constructs `JPH::AABoxCast` elementwise.
        public unsafe Const_AABoxCast(JPH.Const_AABox mBox, JPH.Const_Vec3 mDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABoxCast_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABoxCast_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABoxCast._Underlying *__JPH_AABoxCast_ConstructFrom(JPH.AABox._Underlying *mBox, JPH.Vec3._Underlying *mDirection);
            _UnderlyingPtr = __JPH_AABoxCast_ConstructFrom(mBox._UnderlyingPtr, mDirection._UnderlyingPtr);
            _KeepAlive(mBox);
            _KeepAlive(mDirection);
        }

        /// Generated from constructor `JPH::AABoxCast::AABoxCast`.
        public unsafe Const_AABoxCast(JPH.Const_AABoxCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABoxCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABoxCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABoxCast._Underlying *__JPH_AABoxCast_ConstructFromAnother(JPH.AABoxCast._Underlying *_other);
            _UnderlyingPtr = __JPH_AABoxCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::AABoxCast::AABoxCast`.
        public Const_AABoxCast(AABoxCast _other) : this((Const_AABoxCast)_other) {}

        /// Generated from method `JPH::AABoxCast::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_AABoxCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_AABoxCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_AABoxCast_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_AABoxCast_size_t(inCount);
        }

        /// Generated from method `JPH::AABoxCast::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_AABoxCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_AABoxCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_AABoxCast_void_ptr(void *inPointer);
            __Jolt_delete_JPH_AABoxCast_void_ptr(inPointer);
        }

        /// Generated from method `JPH::AABoxCast::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_AABoxCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_AABoxCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_AABoxCast_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_AABoxCast_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::AABoxCast::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_AABoxCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_AABoxCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_AABoxCast_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_AABoxCast_size_t(inCount);
        }

        /// Generated from method `JPH::AABoxCast::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_AABoxCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_AABoxCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_AABoxCast_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_AABoxCast_void_ptr(inPointer);
        }

        /// Generated from method `JPH::AABoxCast::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_AABoxCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_AABoxCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_AABoxCast_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_AABoxCast_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::AABoxCast::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_AABoxCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_AABoxCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_AABoxCast_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_AABoxCast_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::AABoxCast::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_AABoxCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_AABoxCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_AABoxCast_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_AABoxCast_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::AABoxCast::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_AABoxCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_AABoxCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_AABoxCast_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_AABoxCast_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::AABoxCast::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_AABoxCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_AABoxCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_AABoxCast_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_AABoxCast_void_ptr_void_ptr(inPointer, inPlace);
        }
    }

    /// Structure that holds AABox moving linearly through 3d space
    /// Generated from class `JPH::AABoxCast`.
    /// This is the non-const half of the class.
    public class AABoxCast : Const_AABoxCast
    {
        ///< Axis aligned box at starting location
        public new unsafe JPH.AABox mBox
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABoxCast_GetMutable_mBox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABoxCast_GetMutable_mBox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.AABox._Underlying *__JPH_AABoxCast_GetMutable_mBox(_Underlying *_this);
                JPH.AABox __ret;
                __ret = new(__JPH_AABoxCast_GetMutable_mBox(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction and length of the cast (anything beyond this length will not be reported as a hit)
        public new unsafe JPH.Vec3 mDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABoxCast_GetMutable_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABoxCast_GetMutable_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_AABoxCast_GetMutable_mDirection(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_AABoxCast_GetMutable_mDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe AABoxCast(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe AABoxCast() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABoxCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABoxCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABoxCast._Underlying *__JPH_AABoxCast_DefaultConstruct();
            _UnderlyingPtr = __JPH_AABoxCast_DefaultConstruct();
        }

        /// Constructs `JPH::AABoxCast` elementwise.
        public unsafe AABoxCast(JPH.Const_AABox mBox, JPH.Const_Vec3 mDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABoxCast_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABoxCast_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABoxCast._Underlying *__JPH_AABoxCast_ConstructFrom(JPH.AABox._Underlying *mBox, JPH.Vec3._Underlying *mDirection);
            _UnderlyingPtr = __JPH_AABoxCast_ConstructFrom(mBox._UnderlyingPtr, mDirection._UnderlyingPtr);
            _KeepAlive(mBox);
            _KeepAlive(mDirection);
        }

        /// Generated from constructor `JPH::AABoxCast::AABoxCast`.
        public unsafe AABoxCast(JPH.Const_AABoxCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABoxCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABoxCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABoxCast._Underlying *__JPH_AABoxCast_ConstructFromAnother(JPH.AABoxCast._Underlying *_other);
            _UnderlyingPtr = __JPH_AABoxCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::AABoxCast::AABoxCast`.
        public AABoxCast(AABoxCast _other) : this((Const_AABoxCast)_other) {}

        /// Generated from method `JPH::AABoxCast::operator=`.
        public unsafe JPH.AABoxCast Assign(JPH.Const_AABoxCast _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABoxCast_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABoxCast_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABoxCast._Underlying *__JPH_AABoxCast_AssignFromAnother(_Underlying *_this, JPH.AABoxCast._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_AABoxCast_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `AABoxCast` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_AABoxCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `AABoxCast`/`Const_AABoxCast` directly.
    public class _InOptMut_AABoxCast
    {
        public AABoxCast? Opt;

        public _InOptMut_AABoxCast() {}
        public _InOptMut_AABoxCast(AABoxCast value) {Opt = value;}
        public static implicit operator _InOptMut_AABoxCast(AABoxCast value) {return new(value);}
    }

    /// This is used for optional parameters of class `AABoxCast` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_AABoxCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `AABoxCast`/`Const_AABoxCast` to pass it to the function.
    public class _InOptConst_AABoxCast
    {
        public Const_AABoxCast? Opt;

        public _InOptConst_AABoxCast() {}
        public _InOptConst_AABoxCast(Const_AABoxCast value) {Opt = value;}
        public static implicit operator _InOptConst_AABoxCast(Const_AABoxCast value) {return new(value);}
    }
}
