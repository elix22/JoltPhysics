// machine generated, do not edit
public static partial class Jolt
{
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
        public class Const_JobSystemWithBarrier : Jolt.Object<Const_JobSystemWithBarrier>, System.IDisposable
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
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_JobSystemWithBarrier self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_JobSystem(Const_JobSystemWithBarrier self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_JobSystem._Underlying *__JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem(_Underlying *_this);
                Jolt.JPH.Const_JobSystem ret = new(__JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_JobSystemWithBarrier?(Jolt.JPH.Const_JobSystem parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_DynamicDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_DynamicDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_JobSystemWithBarrier_DynamicDowncastFrom_JPH_JobSystem(Jolt.JPH.Const_JobSystem._Underlying *_this);
                var ptr = __JPH_JobSystemWithBarrier_DynamicDowncastFrom_JPH_JobSystem(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_JobSystemWithBarrier ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe Const_JobSystemWithBarrier(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from method `JPH::JobSystemWithBarrier::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_JobSystemWithBarrier_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_JobSystemWithBarrier_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_JobSystemWithBarrier_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_JobSystemWithBarrier_unsigned_long(inCount);
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
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_JobSystemWithBarrier_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::JobSystemWithBarrier::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemWithBarrier_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemWithBarrier_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_JobSystemWithBarrier_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_JobSystemWithBarrier_unsigned_long(inCount);
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
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_JobSystemWithBarrier_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::JobSystemWithBarrier::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_JobSystemWithBarrier_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_JobSystemWithBarrier_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_JobSystemWithBarrier_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_JobSystemWithBarrier_unsigned_long_void_ptr(inCount, inPointer);
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
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemWithBarrier_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemWithBarrier_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_JobSystemWithBarrier_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_JobSystemWithBarrier_unsigned_long_void_ptr(inCount, inPointer);
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
            public static unsafe implicit operator Jolt.JPH.NonCopyable(JobSystemWithBarrier self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_JobSystemWithBarrier_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.JobSystem(JobSystemWithBarrier self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.JobSystem._Underlying *__JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem(_Underlying *_this);
                Jolt.JPH.JobSystem ret = new(__JPH_JobSystemWithBarrier_UpcastTo_JPH_JobSystem(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator JobSystemWithBarrier?(Jolt.JPH.JobSystem parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_DynamicDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_DynamicDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_JobSystemWithBarrier_DynamicDowncastFrom_JPH_JobSystem(Jolt.JPH.JobSystem._Underlying *_this);
                var ptr = __JPH_JobSystemWithBarrier_DynamicDowncastFrom_JPH_JobSystem(parent._UnderlyingPtr);
                if (ptr is null) return null;
                JobSystemWithBarrier ret = new(ptr, is_owning: false);
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
            public unsafe Jolt.JPH.JobSystem.Barrier? CreateBarrier()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_CreateBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_CreateBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.JobSystem.Barrier._Underlying *__JPH_JobSystemWithBarrier_CreateBarrier(_Underlying *_this);
                var __c_ret = __JPH_JobSystemWithBarrier_CreateBarrier(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.JobSystem.Barrier(__c_ret, is_owning: false) : null;
            }

            /// Generated from method `JPH::JobSystemWithBarrier::DestroyBarrier`.
            public unsafe void DestroyBarrier(Jolt.JPH.JobSystem.Barrier? inBarrier)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_DestroyBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_DestroyBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_JobSystemWithBarrier_DestroyBarrier(_Underlying *_this, Jolt.JPH.JobSystem.Barrier._Underlying *inBarrier);
                __JPH_JobSystemWithBarrier_DestroyBarrier(_UnderlyingPtr, inBarrier is not null ? inBarrier._UnderlyingPtr : null);
            }

            /// Generated from method `JPH::JobSystemWithBarrier::WaitForJobs`.
            public unsafe void WaitForJobs(Jolt.JPH.JobSystem.Barrier? inBarrier)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemWithBarrier_WaitForJobs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemWithBarrier_WaitForJobs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_JobSystemWithBarrier_WaitForJobs(_Underlying *_this, Jolt.JPH.JobSystem.Barrier._Underlying *inBarrier);
                __JPH_JobSystemWithBarrier_WaitForJobs(_UnderlyingPtr, inBarrier is not null ? inBarrier._UnderlyingPtr : null);
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
}
