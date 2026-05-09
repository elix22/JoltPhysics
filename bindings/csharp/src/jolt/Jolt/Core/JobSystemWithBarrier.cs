// machine generated, do not edit
public static partial class JPH
{
    /// Implementation of the Barrier class for a JobSystem
    ///
    /// This class can be used to make it easier to create a new JobSystem implementation that integrates with your own job system.
    /// It will implement all functionality relating to barriers, so the only functions that are left to be implemented are:
    ///
    /// * JobSystem::GetMaxConcurrency
    /// * JobSystem::CreateJob
    /// * JobSystem::FreeJob
    /// * JobSystem::QueueJob/QueueJobs
    ///
    /// See instructions in JobSystem for more information on how to implement these.
    /// Generated from class `JPH::JobSystemWithBarrier`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::JobSystem`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::JobSystemThreadPool`
    /// This is the const half of the class.
    public class Const_JobSystemWithBarrier : JPH.Object<Const_JobSystemWithBarrier>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_JobSystemWithBarrier_Destroy(_Underlying *_this);
            __JPH_JobSystemWithBarrier_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JobSystemWithBarrier() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_JobSystemWithBarrier self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_JobSystem(Const_JobSystemWithBarrier self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_JobSystem._Underlying *__JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem(_Underlying *_this);
            JPH.Const_JobSystem ret = new(__JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_JobSystemWithBarrier(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_JobSystemWithBarrier ret = new(__JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_JobSystemWithBarrier(JPH.Const_JobSystem parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_JobSystem(JPH.Const_JobSystem._Underlying *_this);
            Const_JobSystemWithBarrier ret = new(__JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_JobSystem(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_JobSystemWithBarrier(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `JPH::JobSystemWithBarrier::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_JobSystemWithBarrier_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_JobSystemWithBarrier_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_JobSystemWithBarrier_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_JobSystemWithBarrier_size_t(inCount);
        }

        /// Generated from method `JPH::JobSystemWithBarrier::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemWithBarrier_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemWithBarrier_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_JobSystemWithBarrier_void_ptr(void *inPointer);
            __Jolt_delete_JPH_JobSystemWithBarrier_void_ptr(inPointer);
        }

        /// Generated from method `JPH::JobSystemWithBarrier::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::JobSystemWithBarrier::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemWithBarrier_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemWithBarrier_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_JobSystemWithBarrier_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_JobSystemWithBarrier_size_t(inCount);
        }

        /// Generated from method `JPH::JobSystemWithBarrier::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr(inPointer);
        }

        /// Generated from method `JPH::JobSystemWithBarrier::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::JobSystemWithBarrier::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_JobSystemWithBarrier_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_JobSystemWithBarrier_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_JobSystemWithBarrier_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_JobSystemWithBarrier_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::JobSystemWithBarrier::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::JobSystemWithBarrier::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemWithBarrier_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemWithBarrier_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_JobSystemWithBarrier_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_JobSystemWithBarrier_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::JobSystemWithBarrier::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Get maximum number of concurrently executing jobs
        /// Generated from method `JPH::JobSystemWithBarrier::GetMaxConcurrency`.
        public unsafe int GetMaxConcurrency()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_GetMaxConcurrency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_GetMaxConcurrency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_JobSystemWithBarrier_GetMaxConcurrency(_Underlying *_this);
            return __JPH_JobSystemWithBarrier_GetMaxConcurrency(_UnderlyingPtr);
        }
    }

    /// Implementation of the Barrier class for a JobSystem
    ///
    /// This class can be used to make it easier to create a new JobSystem implementation that integrates with your own job system.
    /// It will implement all functionality relating to barriers, so the only functions that are left to be implemented are:
    ///
    /// * JobSystem::GetMaxConcurrency
    /// * JobSystem::CreateJob
    /// * JobSystem::FreeJob
    /// * JobSystem::QueueJob/QueueJobs
    ///
    /// See instructions in JobSystem for more information on how to implement these.
    /// Generated from class `JPH::JobSystemWithBarrier`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::JobSystem`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::JobSystemThreadPool`
    /// This is the non-const half of the class.
    public class JobSystemWithBarrier : Const_JobSystemWithBarrier
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(JobSystemWithBarrier self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(JobSystemWithBarrier self)
            => (JPH.Const_NonCopyable)(JPH.Const_JobSystemWithBarrier)self;
        public static unsafe implicit operator JPH.JobSystem(JobSystemWithBarrier self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JobSystem._Underlying *__JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem(_Underlying *_this);
            JPH.JobSystem ret = new(__JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_JobSystem(JobSystemWithBarrier self)
            => (JPH.Const_JobSystem)(JPH.Const_JobSystemWithBarrier)self;

        // Downcasts:
        public static unsafe explicit operator JobSystemWithBarrier(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            JobSystemWithBarrier ret = new(__JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator JobSystemWithBarrier(JPH.JobSystem parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_JobSystem(JPH.JobSystem._Underlying *_this);
            JobSystemWithBarrier ret = new(__JPH_JobSystemWithBarrier_StaticDowncastFrom_JPH_JobSystem(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe JobSystemWithBarrier(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Initialize the barriers
        /// @param inMaxBarriers Max number of barriers that can be allocated at any time
        /// Generated from method `JPH::JobSystemWithBarrier::Init`.
        public unsafe void Init(uint inMaxBarriers)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_Init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_Init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_JobSystemWithBarrier_Init(_Underlying *_this, uint inMaxBarriers);
            __JPH_JobSystemWithBarrier_Init(_UnderlyingPtr, inMaxBarriers);
        }

        // See JobSystem
        /// Generated from method `JPH::JobSystemWithBarrier::CreateBarrier`.
        public unsafe JPH.JobSystem.Barrier? CreateBarrier()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_CreateBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_CreateBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JobSystem.Barrier._Underlying *__JPH_JobSystemWithBarrier_CreateBarrier(_Underlying *_this);
            var __c_ret = __JPH_JobSystemWithBarrier_CreateBarrier(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.JobSystem.Barrier(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::JobSystemWithBarrier::DestroyBarrier`.
        public unsafe void DestroyBarrier(JPH.JobSystem.Barrier? inBarrier)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_DestroyBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_DestroyBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_JobSystemWithBarrier_DestroyBarrier(_Underlying *_this, JPH.JobSystem.Barrier._Underlying *inBarrier);
            __JPH_JobSystemWithBarrier_DestroyBarrier(_UnderlyingPtr, inBarrier is not null ? inBarrier._UnderlyingPtr : null);
        }

        /// Generated from method `JPH::JobSystemWithBarrier::WaitForJobs`.
        public unsafe void WaitForJobs(JPH.JobSystem.Barrier? inBarrier)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_WaitForJobs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_WaitForJobs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_JobSystemWithBarrier_WaitForJobs(_Underlying *_this, JPH.JobSystem.Barrier._Underlying *inBarrier);
            __JPH_JobSystemWithBarrier_WaitForJobs(_UnderlyingPtr, inBarrier is not null ? inBarrier._UnderlyingPtr : null);
        }

        /// Create a new job, the job is started immediately if inNumDependencies == 0 otherwise it starts when
        /// RemoveDependency causes the dependency counter to reach 0.
        /// Generated from method `JPH::JobSystemWithBarrier::CreateJob`.
        /// Parameter `inNumDependencies` defaults to `0`.
        public unsafe JPH.JobSystem.JobHandle CreateJob(byte? inName, JPH.Const_Color inColor, JPH.Std.Const_Function_Void inJobFunction, uint? inNumDependencies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_CreateJob", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_CreateJob", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.JobSystem.JobHandle._Underlying *__JPH_JobSystemWithBarrier_CreateJob(_Underlying *_this, byte *inName, JPH.Color._Underlying *inColor, JPH.Std.Const_Function_Void._Underlying *inJobFunction, uint *inNumDependencies);
            byte __deref_inName = inName.GetValueOrDefault();
            uint __deref_inNumDependencies = inNumDependencies.GetValueOrDefault();
            return new(__JPH_JobSystemWithBarrier_CreateJob(_UnderlyingPtr, inName.HasValue ? &__deref_inName : null, inColor._UnderlyingPtr, inJobFunction._UnderlyingPtr, inNumDependencies.HasValue ? &__deref_inNumDependencies : null), is_owning: true);
        }
    }

    /// This is used for optional parameters of class `JobSystemWithBarrier` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JobSystemWithBarrier`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JobSystemWithBarrier`/`Const_JobSystemWithBarrier` directly.
    public class _InOptMut_JobSystemWithBarrier
    {
        public JobSystemWithBarrier? Opt;

        public _InOptMut_JobSystemWithBarrier() {}
        public _InOptMut_JobSystemWithBarrier(JobSystemWithBarrier value) {Opt = value;}
        public static implicit operator _InOptMut_JobSystemWithBarrier(JobSystemWithBarrier value) {return new(value);}
    }

    /// This is used for optional parameters of class `JobSystemWithBarrier` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JobSystemWithBarrier`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JobSystemWithBarrier`/`Const_JobSystemWithBarrier` to pass it to the function.
    public class _InOptConst_JobSystemWithBarrier
    {
        public Const_JobSystemWithBarrier? Opt;

        public _InOptConst_JobSystemWithBarrier() {}
        public _InOptConst_JobSystemWithBarrier(Const_JobSystemWithBarrier value) {Opt = value;}
        public static implicit operator _InOptConst_JobSystemWithBarrier(Const_JobSystemWithBarrier value) {return new(value);}
    }
}
