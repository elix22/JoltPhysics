// machine generated, do not edit
public static partial class JPH
{
    /// Implementation of a JobSystem without threads, runs jobs as soon as they are added
    /// Generated from class `JPH::JobSystemSingleThreaded`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::JobSystem`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_JobSystemSingleThreaded : JPH.Object<Const_JobSystemSingleThreaded>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_JobSystemSingleThreaded_Destroy(_Underlying *_this);
            __JPH_JobSystemSingleThreaded_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JobSystemSingleThreaded() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_JobSystemSingleThreaded self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_JobSystemSingleThreaded_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_JobSystemSingleThreaded_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_JobSystem(Const_JobSystemSingleThreaded self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_JobSystem._Underlying *__JPH_JobSystemSingleThreaded_UpcastTo_JPH_JobSystem(_Underlying *_this);
            JPH.Const_JobSystem ret = new(__JPH_JobSystemSingleThreaded_UpcastTo_JPH_JobSystem(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JobSystemSingleThreaded(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_JobSystemSingleThreaded ret = new(__JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_JobSystemSingleThreaded(JPH.Const_JobSystem parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_JobSystem(JPH.Const_JobSystem._Underlying *_this);
            Const_JobSystemSingleThreaded ret = new(__JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_JobSystem(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JobSystemSingleThreaded(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JobSystemSingleThreaded() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JobSystemSingleThreaded._Underlying *__JPH_JobSystemSingleThreaded_DefaultConstruct();
            _UnderlyingPtr = __JPH_JobSystemSingleThreaded_DefaultConstruct();
        }

        /// Generated from constructor `JPH::JobSystemSingleThreaded::JobSystemSingleThreaded`.
        public unsafe Const_JobSystemSingleThreaded(uint inMaxJobs) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JobSystemSingleThreaded._Underlying *__JPH_JobSystemSingleThreaded_Construct(uint inMaxJobs);
            _UnderlyingPtr = __JPH_JobSystemSingleThreaded_Construct(inMaxJobs);
        }

        /// Generated from method `JPH::JobSystemSingleThreaded::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_JobSystemSingleThreaded_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_JobSystemSingleThreaded_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_JobSystemSingleThreaded_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_JobSystemSingleThreaded_size_t(inCount);
        }

        /// Generated from method `JPH::JobSystemSingleThreaded::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr(void *inPointer);
            __Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr(inPointer);
        }

        /// Generated from method `JPH::JobSystemSingleThreaded::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::JobSystemSingleThreaded::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemSingleThreaded_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemSingleThreaded_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_JobSystemSingleThreaded_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_JobSystemSingleThreaded_size_t(inCount);
        }

        /// Generated from method `JPH::JobSystemSingleThreaded::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr(inPointer);
        }

        /// Generated from method `JPH::JobSystemSingleThreaded::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::JobSystemSingleThreaded::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_JobSystemSingleThreaded_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_JobSystemSingleThreaded_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_JobSystemSingleThreaded_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_JobSystemSingleThreaded_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::JobSystemSingleThreaded::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_JobSystemSingleThreaded_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::JobSystemSingleThreaded::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemSingleThreaded_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemSingleThreaded_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_JobSystemSingleThreaded_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_JobSystemSingleThreaded_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::JobSystemSingleThreaded::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_JobSystemSingleThreaded_void_ptr_void_ptr(inPointer, inPlace);
        }

        // See JobSystem
        /// Generated from method `JPH::JobSystemSingleThreaded::GetMaxConcurrency`.
        public unsafe int GetMaxConcurrency()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_GetMaxConcurrency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_GetMaxConcurrency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_JobSystemSingleThreaded_GetMaxConcurrency(_Underlying *_this);
            return __JPH_JobSystemSingleThreaded_GetMaxConcurrency(_UnderlyingPtr);
        }
    }

    /// Implementation of a JobSystem without threads, runs jobs as soon as they are added
    /// Generated from class `JPH::JobSystemSingleThreaded`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::JobSystem`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class JobSystemSingleThreaded : Const_JobSystemSingleThreaded
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(JobSystemSingleThreaded self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_JobSystemSingleThreaded_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_JobSystemSingleThreaded_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(JobSystemSingleThreaded self)
            => (JPH.Const_NonCopyable)(JPH.Const_JobSystemSingleThreaded)self;
        public static unsafe implicit operator JPH.JobSystem(JobSystemSingleThreaded self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JobSystem._Underlying *__JPH_JobSystemSingleThreaded_UpcastTo_JPH_JobSystem(_Underlying *_this);
            JPH.JobSystem ret = new(__JPH_JobSystemSingleThreaded_UpcastTo_JPH_JobSystem(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_JobSystem(JobSystemSingleThreaded self)
            => (JPH.Const_JobSystem)(JPH.Const_JobSystemSingleThreaded)self;

        // Downcasts:
        public static unsafe explicit operator JobSystemSingleThreaded(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            JobSystemSingleThreaded ret = new(__JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator JobSystemSingleThreaded(JPH.JobSystem parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_JobSystem(JPH.JobSystem._Underlying *_this);
            JobSystemSingleThreaded ret = new(__JPH_JobSystemSingleThreaded_StaticDowncastFrom_JPH_JobSystem(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JobSystemSingleThreaded(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JobSystemSingleThreaded() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JobSystemSingleThreaded._Underlying *__JPH_JobSystemSingleThreaded_DefaultConstruct();
            _UnderlyingPtr = __JPH_JobSystemSingleThreaded_DefaultConstruct();
        }

        /// Generated from constructor `JPH::JobSystemSingleThreaded::JobSystemSingleThreaded`.
        public unsafe JobSystemSingleThreaded(uint inMaxJobs) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JobSystemSingleThreaded._Underlying *__JPH_JobSystemSingleThreaded_Construct(uint inMaxJobs);
            _UnderlyingPtr = __JPH_JobSystemSingleThreaded_Construct(inMaxJobs);
        }

        /// Initialize the job system
        /// @param inMaxJobs Max number of jobs that can be allocated at any time
        /// Generated from method `JPH::JobSystemSingleThreaded::Init`.
        public unsafe void Init(uint inMaxJobs)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_Init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_Init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_JobSystemSingleThreaded_Init(_Underlying *_this, uint inMaxJobs);
            __JPH_JobSystemSingleThreaded_Init(_UnderlyingPtr, inMaxJobs);
        }

        /// Generated from method `JPH::JobSystemSingleThreaded::CreateJob`.
        /// Parameter `inNumDependencies` defaults to `0`.
        public unsafe JPH.JobSystem.JobHandle CreateJob(byte? inName, JPH.Const_Color inColor, JPH.Std.Const_Function_Void inJobFunction, uint? inNumDependencies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_CreateJob", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_CreateJob", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JobSystem.JobHandle._Underlying *__JPH_JobSystemSingleThreaded_CreateJob(_Underlying *_this, byte *inName, JPH.Color._Underlying *inColor, JPH.Std.Const_Function_Void._Underlying *inJobFunction, uint *inNumDependencies);
            byte __deref_inName = inName.GetValueOrDefault();
            uint __deref_inNumDependencies = inNumDependencies.GetValueOrDefault();
            return new(__JPH_JobSystemSingleThreaded_CreateJob(_UnderlyingPtr, inName.HasValue ? &__deref_inName : null, inColor._UnderlyingPtr, inJobFunction._UnderlyingPtr, inNumDependencies.HasValue ? &__deref_inNumDependencies : null), is_owning: true);
        }

        /// Generated from method `JPH::JobSystemSingleThreaded::CreateBarrier`.
        public unsafe JPH.JobSystem.Barrier? CreateBarrier()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_CreateBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_CreateBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JobSystem.Barrier._Underlying *__JPH_JobSystemSingleThreaded_CreateBarrier(_Underlying *_this);
            var __c_ret = __JPH_JobSystemSingleThreaded_CreateBarrier(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.JobSystem.Barrier(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::JobSystemSingleThreaded::DestroyBarrier`.
        public unsafe void DestroyBarrier(JPH.JobSystem.Barrier? inBarrier)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_DestroyBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_DestroyBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_JobSystemSingleThreaded_DestroyBarrier(_Underlying *_this, JPH.JobSystem.Barrier._Underlying *inBarrier);
            __JPH_JobSystemSingleThreaded_DestroyBarrier(_UnderlyingPtr, inBarrier is not null ? inBarrier._UnderlyingPtr : null);
        }

        /// Generated from method `JPH::JobSystemSingleThreaded::WaitForJobs`.
        public unsafe void WaitForJobs(JPH.JobSystem.Barrier? inBarrier)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_WaitForJobs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemSingleThreaded_WaitForJobs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_JobSystemSingleThreaded_WaitForJobs(_Underlying *_this, JPH.JobSystem.Barrier._Underlying *inBarrier);
            __JPH_JobSystemSingleThreaded_WaitForJobs(_UnderlyingPtr, inBarrier is not null ? inBarrier._UnderlyingPtr : null);
        }
    }

    /// This is used as a function parameter when the underlying function receives `JobSystemSingleThreaded` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_JobSystemSingleThreaded
    {
        #pragma warning disable CS0649
        internal readonly Const_JobSystemSingleThreaded? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_JobSystemSingleThreaded() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `JobSystemSingleThreaded` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JobSystemSingleThreaded`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JobSystemSingleThreaded`/`Const_JobSystemSingleThreaded` directly.
    public class _InOptMut_JobSystemSingleThreaded
    {
        public JobSystemSingleThreaded? Opt;

        public _InOptMut_JobSystemSingleThreaded() {}
        public _InOptMut_JobSystemSingleThreaded(JobSystemSingleThreaded value) {Opt = value;}
        public static implicit operator _InOptMut_JobSystemSingleThreaded(JobSystemSingleThreaded value) {return new(value);}
    }

    /// This is used for optional parameters of class `JobSystemSingleThreaded` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JobSystemSingleThreaded`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JobSystemSingleThreaded`/`Const_JobSystemSingleThreaded` to pass it to the function.
    public class _InOptConst_JobSystemSingleThreaded
    {
        public Const_JobSystemSingleThreaded? Opt;

        public _InOptConst_JobSystemSingleThreaded() {}
        public _InOptConst_JobSystemSingleThreaded(Const_JobSystemSingleThreaded value) {Opt = value;}
        public static implicit operator _InOptConst_JobSystemSingleThreaded(Const_JobSystemSingleThreaded value) {return new(value);}
    }
}
