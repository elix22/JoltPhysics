// machine generated, do not edit
public static partial class JPH
{
    /// Structure that holds the result of colliding a point against a shape
    /// Generated from class `JPH::CollidePointResult`.
    /// This is the const half of the class.
    public class Const_CollidePointResult : JPH.Object<Const_CollidePointResult>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollidePointResult_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollidePointResult_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CollidePointResult_Destroy(_Underlying *_this);
            __JPH_CollidePointResult_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_CollidePointResult() {Dispose(false);}

        ///< Body that was hit
        public unsafe ref readonly JPH.BodyID mBodyID
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollidePointResult_Get_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollidePointResult_Get_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_CollidePointResult_Get_mBodyID(_Underlying *_this);
                return ref *__JPH_CollidePointResult_Get_mBodyID(_UnderlyingPtr);
            }
        }

        ///< Sub shape ID of shape that we collided against
        public unsafe JPH.Const_SubShapeID mSubShapeID2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollidePointResult_Get_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollidePointResult_Get_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_SubShapeID._Underlying *__JPH_CollidePointResult_Get_mSubShapeID2(_Underlying *_this);
                JPH.Const_SubShapeID __ret;
                __ret = new(__JPH_CollidePointResult_Get_mSubShapeID2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_CollidePointResult(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_CollidePointResult() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollidePointResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollidePointResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollidePointResult._Underlying *__JPH_CollidePointResult_DefaultConstruct();
            _UnderlyingPtr = __JPH_CollidePointResult_DefaultConstruct();
        }

        /// Constructs `JPH::CollidePointResult` elementwise.
        public unsafe Const_CollidePointResult(JPH.BodyID mBodyID, JPH.Const_SubShapeID mSubShapeID2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollidePointResult_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollidePointResult_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollidePointResult._Underlying *__JPH_CollidePointResult_ConstructFrom(JPH.BodyID mBodyID, JPH.SubShapeID._Underlying *mSubShapeID2);
            _UnderlyingPtr = __JPH_CollidePointResult_ConstructFrom(mBodyID, mSubShapeID2._UnderlyingPtr);
            _KeepAlive(mSubShapeID2);
        }

        /// Generated from constructor `JPH::CollidePointResult::CollidePointResult`.
        public unsafe Const_CollidePointResult(JPH.Const_CollidePointResult _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollidePointResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollidePointResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollidePointResult._Underlying *__JPH_CollidePointResult_ConstructFromAnother(JPH.CollidePointResult._Underlying *_other);
            _UnderlyingPtr = __JPH_CollidePointResult_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::CollidePointResult::CollidePointResult`.
        public Const_CollidePointResult(CollidePointResult _other) : this((Const_CollidePointResult)_other) {}

        /// Generated from method `JPH::CollidePointResult::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CollidePointResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CollidePointResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CollidePointResult_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_CollidePointResult_size_t(inCount);
        }

        /// Generated from method `JPH::CollidePointResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollidePointResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollidePointResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollidePointResult_void_ptr(void *inPointer);
            __Jolt_delete_JPH_CollidePointResult_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CollidePointResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollidePointResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollidePointResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollidePointResult_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_CollidePointResult_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CollidePointResult::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CollidePointResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CollidePointResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CollidePointResult_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_CollidePointResult_size_t(inCount);
        }

        /// Generated from method `JPH::CollidePointResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollidePointResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollidePointResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollidePointResult_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_CollidePointResult_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CollidePointResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollidePointResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollidePointResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollidePointResult_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_CollidePointResult_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CollidePointResult::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CollidePointResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CollidePointResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CollidePointResult_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_CollidePointResult_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CollidePointResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollidePointResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollidePointResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollidePointResult_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_CollidePointResult_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::CollidePointResult::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CollidePointResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CollidePointResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CollidePointResult_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_CollidePointResult_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CollidePointResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollidePointResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollidePointResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollidePointResult_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_CollidePointResult_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Function required by the CollisionCollector. A smaller fraction is considered to be a 'better hit'. For point queries there is no sensible return value.
        /// Generated from method `JPH::CollidePointResult::GetEarlyOutFraction`.
        public unsafe float GetEarlyOutFraction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollidePointResult_GetEarlyOutFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollidePointResult_GetEarlyOutFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_CollidePointResult_GetEarlyOutFraction(_Underlying *_this);
            return __JPH_CollidePointResult_GetEarlyOutFraction(_UnderlyingPtr);
        }
    }

    /// Structure that holds the result of colliding a point against a shape
    /// Generated from class `JPH::CollidePointResult`.
    /// This is the non-const half of the class.
    public class CollidePointResult : Const_CollidePointResult
    {
        ///< Body that was hit
        public new unsafe ref JPH.BodyID mBodyID
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollidePointResult_GetMutable_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollidePointResult_GetMutable_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_CollidePointResult_GetMutable_mBodyID(_Underlying *_this);
                return ref *__JPH_CollidePointResult_GetMutable_mBodyID(_UnderlyingPtr);
            }
        }

        ///< Sub shape ID of shape that we collided against
        public new unsafe JPH.SubShapeID mSubShapeID2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollidePointResult_GetMutable_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollidePointResult_GetMutable_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SubShapeID._Underlying *__JPH_CollidePointResult_GetMutable_mSubShapeID2(_Underlying *_this);
                JPH.SubShapeID __ret;
                __ret = new(__JPH_CollidePointResult_GetMutable_mSubShapeID2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe CollidePointResult(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe CollidePointResult() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollidePointResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollidePointResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollidePointResult._Underlying *__JPH_CollidePointResult_DefaultConstruct();
            _UnderlyingPtr = __JPH_CollidePointResult_DefaultConstruct();
        }

        /// Constructs `JPH::CollidePointResult` elementwise.
        public unsafe CollidePointResult(JPH.BodyID mBodyID, JPH.Const_SubShapeID mSubShapeID2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollidePointResult_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollidePointResult_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollidePointResult._Underlying *__JPH_CollidePointResult_ConstructFrom(JPH.BodyID mBodyID, JPH.SubShapeID._Underlying *mSubShapeID2);
            _UnderlyingPtr = __JPH_CollidePointResult_ConstructFrom(mBodyID, mSubShapeID2._UnderlyingPtr);
            _KeepAlive(mSubShapeID2);
        }

        /// Generated from constructor `JPH::CollidePointResult::CollidePointResult`.
        public unsafe CollidePointResult(JPH.Const_CollidePointResult _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollidePointResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollidePointResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollidePointResult._Underlying *__JPH_CollidePointResult_ConstructFromAnother(JPH.CollidePointResult._Underlying *_other);
            _UnderlyingPtr = __JPH_CollidePointResult_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::CollidePointResult::CollidePointResult`.
        public CollidePointResult(CollidePointResult _other) : this((Const_CollidePointResult)_other) {}

        /// Generated from method `JPH::CollidePointResult::operator=`.
        public unsafe JPH.CollidePointResult Assign(JPH.Const_CollidePointResult _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollidePointResult_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollidePointResult_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollidePointResult._Underlying *__JPH_CollidePointResult_AssignFromAnother(_Underlying *_this, JPH.CollidePointResult._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_CollidePointResult_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `CollidePointResult` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_CollidePointResult`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CollidePointResult`/`Const_CollidePointResult` directly.
    public class _InOptMut_CollidePointResult
    {
        public CollidePointResult? Opt;

        public _InOptMut_CollidePointResult() {}
        public _InOptMut_CollidePointResult(CollidePointResult value) {Opt = value;}
        public static implicit operator _InOptMut_CollidePointResult(CollidePointResult value) {return new(value);}
    }

    /// This is used for optional parameters of class `CollidePointResult` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_CollidePointResult`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CollidePointResult`/`Const_CollidePointResult` to pass it to the function.
    public class _InOptConst_CollidePointResult
    {
        public Const_CollidePointResult? Opt;

        public _InOptConst_CollidePointResult() {}
        public _InOptConst_CollidePointResult(Const_CollidePointResult value) {Opt = value;}
        public static implicit operator _InOptConst_CollidePointResult(Const_CollidePointResult value) {return new(value);}
    }
}
