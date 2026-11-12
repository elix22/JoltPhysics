// machine generated, do not edit
public static partial class JPH
{
    /// Structure that holds a ray cast or other object cast hit
    /// Generated from class `JPH::BroadPhaseCastResult`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RayCastResult`
    /// This is the const half of the class.
    public class Const_BroadPhaseCastResult : JPH.Object<Const_BroadPhaseCastResult>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseCastResult_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseCastResult_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BroadPhaseCastResult_Destroy(_Underlying *_this);
            __JPH_BroadPhaseCastResult_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BroadPhaseCastResult() {Dispose(false);}

        ///< Body that was hit
        public unsafe ref readonly JPH.BodyID mBodyID
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseCastResult_Get_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseCastResult_Get_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_BroadPhaseCastResult_Get_mBodyID(_Underlying *_this);
                return ref *__JPH_BroadPhaseCastResult_Get_mBodyID(_UnderlyingPtr);
            }
        }

        ///< Hit fraction of the ray/object [0, 1], HitPoint = Start + mFraction * (End - Start)
        public unsafe float mFraction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseCastResult_Get_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseCastResult_Get_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BroadPhaseCastResult_Get_mFraction(_Underlying *_this);
                return *__JPH_BroadPhaseCastResult_Get_mFraction(_UnderlyingPtr);
            }
        }

        internal unsafe Const_BroadPhaseCastResult(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_BroadPhaseCastResult() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseCastResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseCastResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseCastResult._Underlying *__JPH_BroadPhaseCastResult_DefaultConstruct();
            _UnderlyingPtr = __JPH_BroadPhaseCastResult_DefaultConstruct();
        }

        /// Constructs `JPH::BroadPhaseCastResult` elementwise.
        public unsafe Const_BroadPhaseCastResult(JPH.BodyID mBodyID, float mFraction) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseCastResult_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseCastResult_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseCastResult._Underlying *__JPH_BroadPhaseCastResult_ConstructFrom(JPH.BodyID mBodyID, float mFraction);
            _UnderlyingPtr = __JPH_BroadPhaseCastResult_ConstructFrom(mBodyID, mFraction);
        }

        /// Generated from constructor `JPH::BroadPhaseCastResult::BroadPhaseCastResult`.
        public unsafe Const_BroadPhaseCastResult(JPH.Const_BroadPhaseCastResult _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseCastResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseCastResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseCastResult._Underlying *__JPH_BroadPhaseCastResult_ConstructFromAnother(JPH.BroadPhaseCastResult._Underlying *_other);
            _UnderlyingPtr = __JPH_BroadPhaseCastResult_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::BroadPhaseCastResult::BroadPhaseCastResult`.
        public Const_BroadPhaseCastResult(BroadPhaseCastResult _other) : this((Const_BroadPhaseCastResult)_other) {}

        /// Generated from method `JPH::BroadPhaseCastResult::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_BroadPhaseCastResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_BroadPhaseCastResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_BroadPhaseCastResult_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_BroadPhaseCastResult_size_t(inCount);
        }

        /// Generated from method `JPH::BroadPhaseCastResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseCastResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseCastResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_BroadPhaseCastResult_void_ptr(void *inPointer);
            __Jolt_delete_JPH_BroadPhaseCastResult_void_ptr(inPointer);
        }

        /// Generated from method `JPH::BroadPhaseCastResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseCastResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseCastResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_BroadPhaseCastResult_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_BroadPhaseCastResult_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::BroadPhaseCastResult::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_BroadPhaseCastResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_BroadPhaseCastResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_BroadPhaseCastResult_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_BroadPhaseCastResult_size_t(inCount);
        }

        /// Generated from method `JPH::BroadPhaseCastResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr(inPointer);
        }

        /// Generated from method `JPH::BroadPhaseCastResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::BroadPhaseCastResult::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_BroadPhaseCastResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_BroadPhaseCastResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_BroadPhaseCastResult_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_BroadPhaseCastResult_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::BroadPhaseCastResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseCastResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseCastResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_BroadPhaseCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_BroadPhaseCastResult_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::BroadPhaseCastResult::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_BroadPhaseCastResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_BroadPhaseCastResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_BroadPhaseCastResult_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_BroadPhaseCastResult_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::BroadPhaseCastResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_BroadPhaseCastResult_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Function required by the CollisionCollector. A smaller fraction is considered to be a 'better hit'. For rays/cast shapes we can just use the collision fraction.
        /// Generated from method `JPH::BroadPhaseCastResult::GetEarlyOutFraction`.
        public unsafe float GetEarlyOutFraction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseCastResult_GetEarlyOutFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseCastResult_GetEarlyOutFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_BroadPhaseCastResult_GetEarlyOutFraction(_Underlying *_this);
            return __JPH_BroadPhaseCastResult_GetEarlyOutFraction(_UnderlyingPtr);
        }
    }

    /// Structure that holds a ray cast or other object cast hit
    /// Generated from class `JPH::BroadPhaseCastResult`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RayCastResult`
    /// This is the non-const half of the class.
    public class BroadPhaseCastResult : Const_BroadPhaseCastResult
    {
        ///< Body that was hit
        public new unsafe ref JPH.BodyID mBodyID
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseCastResult_GetMutable_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseCastResult_GetMutable_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_BroadPhaseCastResult_GetMutable_mBodyID(_Underlying *_this);
                return ref *__JPH_BroadPhaseCastResult_GetMutable_mBodyID(_UnderlyingPtr);
            }
        }

        ///< Hit fraction of the ray/object [0, 1], HitPoint = Start + mFraction * (End - Start)
        public new unsafe ref float mFraction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseCastResult_GetMutable_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseCastResult_GetMutable_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BroadPhaseCastResult_GetMutable_mFraction(_Underlying *_this);
                return ref *__JPH_BroadPhaseCastResult_GetMutable_mFraction(_UnderlyingPtr);
            }
        }

        internal unsafe BroadPhaseCastResult(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe BroadPhaseCastResult() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseCastResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseCastResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseCastResult._Underlying *__JPH_BroadPhaseCastResult_DefaultConstruct();
            _UnderlyingPtr = __JPH_BroadPhaseCastResult_DefaultConstruct();
        }

        /// Constructs `JPH::BroadPhaseCastResult` elementwise.
        public unsafe BroadPhaseCastResult(JPH.BodyID mBodyID, float mFraction) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseCastResult_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseCastResult_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseCastResult._Underlying *__JPH_BroadPhaseCastResult_ConstructFrom(JPH.BodyID mBodyID, float mFraction);
            _UnderlyingPtr = __JPH_BroadPhaseCastResult_ConstructFrom(mBodyID, mFraction);
        }

        /// Generated from constructor `JPH::BroadPhaseCastResult::BroadPhaseCastResult`.
        public unsafe BroadPhaseCastResult(JPH.Const_BroadPhaseCastResult _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseCastResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseCastResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseCastResult._Underlying *__JPH_BroadPhaseCastResult_ConstructFromAnother(JPH.BroadPhaseCastResult._Underlying *_other);
            _UnderlyingPtr = __JPH_BroadPhaseCastResult_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::BroadPhaseCastResult::BroadPhaseCastResult`.
        public BroadPhaseCastResult(BroadPhaseCastResult _other) : this((Const_BroadPhaseCastResult)_other) {}

        /// Generated from method `JPH::BroadPhaseCastResult::operator=`.
        public unsafe JPH.BroadPhaseCastResult Assign(JPH.Const_BroadPhaseCastResult _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseCastResult_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseCastResult_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseCastResult._Underlying *__JPH_BroadPhaseCastResult_AssignFromAnother(_Underlying *_this, JPH.BroadPhaseCastResult._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_BroadPhaseCastResult_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Reset this result so it can be reused for a new cast.
        /// Generated from method `JPH::BroadPhaseCastResult::Reset`.
        public unsafe void Reset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseCastResult_Reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseCastResult_Reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BroadPhaseCastResult_Reset(_Underlying *_this);
            __JPH_BroadPhaseCastResult_Reset(_UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `BroadPhaseCastResult` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BroadPhaseCastResult`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BroadPhaseCastResult`/`Const_BroadPhaseCastResult` directly.
    public class _InOptMut_BroadPhaseCastResult
    {
        public BroadPhaseCastResult? Opt;

        public _InOptMut_BroadPhaseCastResult() {}
        public _InOptMut_BroadPhaseCastResult(BroadPhaseCastResult value) {Opt = value;}
        public static implicit operator _InOptMut_BroadPhaseCastResult(BroadPhaseCastResult value) {return new(value);}
    }

    /// This is used for optional parameters of class `BroadPhaseCastResult` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BroadPhaseCastResult`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BroadPhaseCastResult`/`Const_BroadPhaseCastResult` to pass it to the function.
    public class _InOptConst_BroadPhaseCastResult
    {
        public Const_BroadPhaseCastResult? Opt;

        public _InOptConst_BroadPhaseCastResult() {}
        public _InOptConst_BroadPhaseCastResult(Const_BroadPhaseCastResult value) {Opt = value;}
        public static implicit operator _InOptConst_BroadPhaseCastResult(Const_BroadPhaseCastResult value) {return new(value);}
    }

    /// Specialization of cast result against a shape
    /// Generated from class `JPH::RayCastResult`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BroadPhaseCastResult`
    /// This is the const half of the class.
    public class Const_RayCastResult : JPH.Object<Const_RayCastResult>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RayCastResult_Destroy(_Underlying *_this);
            __JPH_RayCastResult_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RayCastResult() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_BroadPhaseCastResult(Const_RayCastResult self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_UpcastTo_JPH_BroadPhaseCastResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_UpcastTo_JPH_BroadPhaseCastResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BroadPhaseCastResult._Underlying *__JPH_RayCastResult_UpcastTo_JPH_BroadPhaseCastResult(_Underlying *_this);
            JPH.Const_BroadPhaseCastResult ret = new(__JPH_RayCastResult_UpcastTo_JPH_BroadPhaseCastResult(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_RayCastResult(JPH.Const_BroadPhaseCastResult parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_StaticDowncastFrom_JPH_BroadPhaseCastResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_StaticDowncastFrom_JPH_BroadPhaseCastResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_RayCastResult_StaticDowncastFrom_JPH_BroadPhaseCastResult(JPH.Const_BroadPhaseCastResult._Underlying *_this);
            Const_RayCastResult ret = new(__JPH_RayCastResult_StaticDowncastFrom_JPH_BroadPhaseCastResult(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Sub shape ID of shape that we collided against
        public unsafe JPH.Const_SubShapeID mSubShapeID2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_Get_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_Get_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_SubShapeID._Underlying *__JPH_RayCastResult_Get_mSubShapeID2(_Underlying *_this);
                JPH.Const_SubShapeID __ret;
                __ret = new(__JPH_RayCastResult_Get_mSubShapeID2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Body that was hit
        public unsafe ref readonly JPH.BodyID mBodyID
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_Get_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_Get_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_RayCastResult_Get_mBodyID(_Underlying *_this);
                return ref *__JPH_RayCastResult_Get_mBodyID(_UnderlyingPtr);
            }
        }

        ///< Hit fraction of the ray/object [0, 1], HitPoint = Start + mFraction * (End - Start)
        public unsafe float mFraction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_Get_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_Get_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_RayCastResult_Get_mFraction(_Underlying *_this);
                return *__JPH_RayCastResult_Get_mFraction(_UnderlyingPtr);
            }
        }

        internal unsafe Const_RayCastResult(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RayCastResult() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastResult._Underlying *__JPH_RayCastResult_DefaultConstruct();
            _UnderlyingPtr = __JPH_RayCastResult_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RayCastResult::RayCastResult`.
        public unsafe Const_RayCastResult(JPH.Const_RayCastResult _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastResult._Underlying *__JPH_RayCastResult_ConstructFromAnother(JPH.RayCastResult._Underlying *_other);
            _UnderlyingPtr = __JPH_RayCastResult_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RayCastResult::RayCastResult`.
        public Const_RayCastResult(RayCastResult _other) : this((Const_RayCastResult)_other) {}

        /// Generated from method `JPH::RayCastResult::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RayCastResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RayCastResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_RayCastResult_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_RayCastResult_size_t(inCount);
        }

        /// Generated from method `JPH::RayCastResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RayCastResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RayCastResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RayCastResult_void_ptr(void *inPointer);
            __Jolt_delete_JPH_RayCastResult_void_ptr(inPointer);
        }

        /// Generated from method `JPH::RayCastResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RayCastResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RayCastResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RayCastResult_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_RayCastResult_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::RayCastResult::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_RayCastResult_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_RayCastResult_size_t(inCount);
        }

        /// Generated from method `JPH::RayCastResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RayCastResult_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_RayCastResult_void_ptr(inPointer);
        }

        /// Generated from method `JPH::RayCastResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RayCastResult_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_RayCastResult_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::RayCastResult::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RayCastResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RayCastResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_RayCastResult_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_RayCastResult_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::RayCastResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RayCastResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RayCastResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RayCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_RayCastResult_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::RayCastResult::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_RayCastResult_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_RayCastResult_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::RayCastResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RayCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_RayCastResult_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Function required by the CollisionCollector. A smaller fraction is considered to be a 'better hit'. For rays/cast shapes we can just use the collision fraction.
        /// Generated from method `JPH::RayCastResult::GetEarlyOutFraction`.
        public unsafe float GetEarlyOutFraction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_GetEarlyOutFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_GetEarlyOutFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_RayCastResult_GetEarlyOutFraction(_Underlying *_this);
            return __JPH_RayCastResult_GetEarlyOutFraction(_UnderlyingPtr);
        }
    }

    /// Specialization of cast result against a shape
    /// Generated from class `JPH::RayCastResult`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BroadPhaseCastResult`
    /// This is the non-const half of the class.
    public class RayCastResult : Const_RayCastResult
    {
        // Upcasts:
        public static unsafe implicit operator JPH.BroadPhaseCastResult(RayCastResult self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_UpcastTo_JPH_BroadPhaseCastResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_UpcastTo_JPH_BroadPhaseCastResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseCastResult._Underlying *__JPH_RayCastResult_UpcastTo_JPH_BroadPhaseCastResult(_Underlying *_this);
            JPH.BroadPhaseCastResult ret = new(__JPH_RayCastResult_UpcastTo_JPH_BroadPhaseCastResult(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_BroadPhaseCastResult(RayCastResult self)
            => (JPH.Const_BroadPhaseCastResult)(JPH.Const_RayCastResult)self;

        // Downcasts:
        public static unsafe explicit operator RayCastResult(JPH.BroadPhaseCastResult parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_StaticDowncastFrom_JPH_BroadPhaseCastResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_StaticDowncastFrom_JPH_BroadPhaseCastResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_RayCastResult_StaticDowncastFrom_JPH_BroadPhaseCastResult(JPH.BroadPhaseCastResult._Underlying *_this);
            RayCastResult ret = new(__JPH_RayCastResult_StaticDowncastFrom_JPH_BroadPhaseCastResult(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Sub shape ID of shape that we collided against
        public new unsafe JPH.SubShapeID mSubShapeID2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_GetMutable_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_GetMutable_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SubShapeID._Underlying *__JPH_RayCastResult_GetMutable_mSubShapeID2(_Underlying *_this);
                JPH.SubShapeID __ret;
                __ret = new(__JPH_RayCastResult_GetMutable_mSubShapeID2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Body that was hit
        public new unsafe ref JPH.BodyID mBodyID
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_GetMutable_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_GetMutable_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_RayCastResult_GetMutable_mBodyID(_Underlying *_this);
                return ref *__JPH_RayCastResult_GetMutable_mBodyID(_UnderlyingPtr);
            }
        }

        ///< Hit fraction of the ray/object [0, 1], HitPoint = Start + mFraction * (End - Start)
        public new unsafe ref float mFraction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_GetMutable_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_GetMutable_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_RayCastResult_GetMutable_mFraction(_Underlying *_this);
                return ref *__JPH_RayCastResult_GetMutable_mFraction(_UnderlyingPtr);
            }
        }

        internal unsafe RayCastResult(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RayCastResult() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastResult._Underlying *__JPH_RayCastResult_DefaultConstruct();
            _UnderlyingPtr = __JPH_RayCastResult_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RayCastResult::RayCastResult`.
        public unsafe RayCastResult(JPH.Const_RayCastResult _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastResult._Underlying *__JPH_RayCastResult_ConstructFromAnother(JPH.RayCastResult._Underlying *_other);
            _UnderlyingPtr = __JPH_RayCastResult_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RayCastResult::RayCastResult`.
        public RayCastResult(RayCastResult _other) : this((Const_RayCastResult)_other) {}

        /// Generated from method `JPH::RayCastResult::operator=`.
        public unsafe JPH.RayCastResult Assign(JPH.Const_RayCastResult _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastResult._Underlying *__JPH_RayCastResult_AssignFromAnother(_Underlying *_this, JPH.RayCastResult._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_RayCastResult_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Reset this result so it can be reused for a new cast.
        /// Generated from method `JPH::RayCastResult::Reset`.
        public unsafe void Reset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastResult_Reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastResult_Reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RayCastResult_Reset(_Underlying *_this);
            __JPH_RayCastResult_Reset(_UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `RayCastResult` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RayCastResult`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RayCastResult`/`Const_RayCastResult` directly.
    public class _InOptMut_RayCastResult
    {
        public RayCastResult? Opt;

        public _InOptMut_RayCastResult() {}
        public _InOptMut_RayCastResult(RayCastResult value) {Opt = value;}
        public static implicit operator _InOptMut_RayCastResult(RayCastResult value) {return new(value);}
    }

    /// This is used for optional parameters of class `RayCastResult` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RayCastResult`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RayCastResult`/`Const_RayCastResult` to pass it to the function.
    public class _InOptConst_RayCastResult
    {
        public Const_RayCastResult? Opt;

        public _InOptConst_RayCastResult() {}
        public _InOptConst_RayCastResult(Const_RayCastResult value) {Opt = value;}
        public static implicit operator _InOptConst_RayCastResult(Const_RayCastResult value) {return new(value);}
    }
}
