// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// A class that allows units of work (Jobs) to be scheduled across multiple threads.
        /// It allows dependencies between the jobs so that the jobs form a graph.
        ///
        /// The pattern for using this class is:
        ///
        ///		// Create job system
        ///		JobSystem *job_system = new JobSystemThreadPool(...);
        ///
        ///		// Create some jobs
        ///		JobHandle second_job = job_system->CreateJob("SecondJob", Color::sRed, []() { ... }, 1); // Create a job with 1 dependency
        ///		JobHandle first_job = job_system->CreateJob("FirstJob", Color::sGreen, [second_job]() { ....; second_job.RemoveDependency(); }, 0); // Job can start immediately, will start second job when it's done
        ///		JobHandle third_job = job_system->CreateJob("ThirdJob", Color::sBlue, []() { ... }, 0); // This job can run immediately as well and can run in parallel to job 1 and 2
        ///
        ///		// Add the jobs to the barrier so that we can execute them while we're waiting
        ///		Barrier *barrier = job_system->CreateBarrier();
        ///		barrier->AddJob(first_job);
        ///		barrier->AddJob(second_job);
        ///		barrier->AddJob(third_job);
        ///		job_system->WaitForJobs(barrier);
        ///
        ///		// Clean up
        ///		job_system->DestroyBarrier(barrier);
        ///		delete job_system;
        ///
        ///	Jobs are guaranteed to be started in the order that their dependency counter becomes zero (in case they're scheduled on a background thread)
        ///	or in the order they're added to the barrier (when dependency count is zero and when executing on the thread that calls WaitForJobs).
        ///
        /// If you want to implement your own job system, inherit from JobSystem and implement:
        ///
        /// * JobSystem::GetMaxConcurrency - This should return the maximum number of jobs that can run in parallel.
        /// * JobSystem::CreateJob - This should create a Job object and return it to the caller.
        /// * JobSystem::FreeJob - This should free the memory associated with the job object. It is called by the Job destructor when it is Release()-ed for the last time.
        /// * JobSystem::QueueJob/QueueJobs - These should store the job pointer in an internal queue to run immediately (dependencies are tracked internally, this function is called when the job can run).
        /// The Job objects are reference counted and are guaranteed to stay alive during the QueueJob(s) call. If you store the job in your own data structure you need to call AddRef() to take a reference.
        /// After the job has been executed you need to call Release() to release the reference. Make sure you no longer dereference the job pointer after calling Release().
        ///
        /// JobSystem::Barrier is used to track the completion of a set of jobs. Jobs will be created by other jobs and added to the barrier while it is being waited on. This means that you cannot
        /// create a dependency graph beforehand as the graph changes while jobs are running. Implement the following functions:
        ///
        /// * Barrier::AddJob/AddJobs - Add a job to the barrier, any call to WaitForJobs will now also wait for this job to complete.
        /// If you store the job in a data structure in the Barrier you need to call AddRef() on the job to keep it alive and Release() after you're done with it.
        /// * Barrier::OnJobFinished - This function is called when a job has finished executing, you can use this to track completion and remove the job from the list of jobs to wait on.
        ///
        /// The functions on JobSystem that need to be implemented to support barriers are:
        ///
        /// * JobSystem::CreateBarrier - Create a new barrier.
        /// * JobSystem::DestroyBarrier - Destroy a barrier.
        /// * JobSystem::WaitForJobs - This is the main function that is used to wait for all jobs that have been added to a Barrier. WaitForJobs can execute jobs that have
        /// been added to the barrier while waiting. It is not wise to execute other jobs that touch physics structures as this can cause race conditions and deadlocks. Please keep in mind that the barrier is
        /// only intended to wait on the completion of the Jolt jobs added to it, if you scheduled any jobs in your engine's job system to execute the Jolt jobs as part of QueueJob/QueueJobs, you might still need
        /// to wait for these in this function after the barrier is finished waiting.
        ///
        /// An example implementation is JobSystemThreadPool. If you don't want to write the Barrier class you can also inherit from JobSystemWithBarrier.
        /// Generated from class `JPH::JobSystem`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::NonCopyable`
        /// Derived classes:
        ///   Direct: (non-virtual)
        ///     `JPH::JobSystemWithBarrier`
        ///   Indirect: (non-virtual)
        ///     `JPH::JobSystemThreadPool`
        /// This is the const half of the class.
        public class Const_JobSystem : Jolt.Object<Const_JobSystem>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_JobSystem_Destroy(_Underlying *_this);
                __JPH_JobSystem_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_JobSystem() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_JobSystem self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_JobSystem_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_JobSystem_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            internal unsafe Const_JobSystem(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from method `JPH::JobSystem::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_JobSystem_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_JobSystem_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_JobSystem_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_JobSystem_unsigned_long(inCount);
            }

            /// Generated from method `JPH::JobSystem::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystem_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystem_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_JobSystem_void_ptr(void *inPointer);
                __Jolt_delete_JPH_JobSystem_void_ptr(inPointer);
            }

            /// Generated from method `JPH::JobSystem::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystem_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystem_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_JobSystem_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_JobSystem_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::JobSystem::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystem_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystem_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_JobSystem_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_JobSystem_unsigned_long(inCount);
            }

            /// Generated from method `JPH::JobSystem::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystem_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystem_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_JobSystem_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_JobSystem_void_ptr(inPointer);
            }

            /// Generated from method `JPH::JobSystem::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystem_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystem_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_JobSystem_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_JobSystem_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::JobSystem::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_JobSystem_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_JobSystem_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_JobSystem_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_JobSystem_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::JobSystem::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystem_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystem_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_JobSystem_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_JobSystem_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::JobSystem::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystem_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystem_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_JobSystem_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_JobSystem_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::JobSystem::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystem_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystem_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_JobSystem_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_JobSystem_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Get maximum number of concurrently executing jobs
            /// Generated from method `JPH::JobSystem::GetMaxConcurrency`.
            public unsafe int GetMaxConcurrency()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_GetMaxConcurrency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_GetMaxConcurrency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_JobSystem_GetMaxConcurrency(_Underlying *_this);
                return __JPH_JobSystem_GetMaxConcurrency(_UnderlyingPtr);
            }

            /// A job barrier keeps track of a number of jobs and allows waiting until they are all completed.
            /// Generated from class `JPH::JobSystem::Barrier`.
            /// Base classes:
            ///   Direct: (non-virtual)
            ///     `JPH::NonCopyable`
            /// This is the const half of the class.
            public class Const_Barrier : Jolt.Object<Const_Barrier>
            {
                internal struct _Underlying {} // Represents the underlying C++ type.

                internal unsafe _Underlying *_UnderlyingPtr;

                // Upcasts:
                public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_Barrier self)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_Barrier_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_Barrier_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_JobSystem_Barrier_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                    Jolt.JPH.Const_NonCopyable ret = new(__JPH_JobSystem_Barrier_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                    ret._KeepAliveEnclosingObject = self;
                    return ret;
                }

                internal unsafe Const_Barrier(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

                /// Generated from method `JPH::JobSystem::Barrier::operator new`.
                /// Returns a mutable pointer.
                public static unsafe void *New(ulong inCount)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_JobSystem_Barrier_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_JobSystem_Barrier_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void *__Jolt_new_JPH_JobSystem_Barrier_unsigned_long(ulong inCount);
                    return __Jolt_new_JPH_JobSystem_Barrier_unsigned_long(inCount);
                }

                /// Generated from method `JPH::JobSystem::Barrier::operator delete`.
                /// Parameter `inPointer` is a mutable pointer.
                public static unsafe void Delete(void *inPointer)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystem_Barrier_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystem_Barrier_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __Jolt_delete_JPH_JobSystem_Barrier_void_ptr(void *inPointer);
                    __Jolt_delete_JPH_JobSystem_Barrier_void_ptr(inPointer);
                }

                /// Generated from method `JPH::JobSystem::Barrier::operator delete`.
                /// Parameter `inPointer` is a mutable pointer.
                public static unsafe void Delete(void *inPointer, ulong inSize)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystem_Barrier_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystem_Barrier_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __Jolt_delete_JPH_JobSystem_Barrier_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                    __Jolt_delete_JPH_JobSystem_Barrier_void_ptr_unsigned_long(inPointer, inSize);
                }

                /// Generated from method `JPH::JobSystem::Barrier::operator new[]`.
                /// Returns a mutable pointer.
                public static unsafe void *NewArray(ulong inCount)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystem_Barrier_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystem_Barrier_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void *__Jolt_new_array_JPH_JobSystem_Barrier_unsigned_long(ulong inCount);
                    return __Jolt_new_array_JPH_JobSystem_Barrier_unsigned_long(inCount);
                }

                /// Generated from method `JPH::JobSystem::Barrier::operator delete[]`.
                /// Parameter `inPointer` is a mutable pointer.
                public static unsafe void DeleteArray(void *inPointer)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr(void *inPointer);
                    __Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr(inPointer);
                }

                /// Generated from method `JPH::JobSystem::Barrier::operator delete[]`.
                /// Parameter `inPointer` is a mutable pointer.
                public static unsafe void DeleteArray(void *inPointer, ulong inSize)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                    __Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr_unsigned_long(inPointer, inSize);
                }

                /// Generated from method `JPH::JobSystem::Barrier::operator new`.
                /// Parameter `inPointer` is a mutable pointer.
                /// Returns a mutable pointer.
                public static unsafe void *New(ulong inCount, void *inPointer)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_JobSystem_Barrier_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_JobSystem_Barrier_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void *__Jolt_new_JPH_JobSystem_Barrier_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                    return __Jolt_new_JPH_JobSystem_Barrier_unsigned_long_void_ptr(inCount, inPointer);
                }

                /// Generated from method `JPH::JobSystem::Barrier::operator delete`.
                /// Parameter `inPointer` is a mutable pointer.
                /// Parameter `inPlace` is a mutable pointer.
                public static unsafe void Delete(void *inPointer, void *inPlace)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystem_Barrier_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystem_Barrier_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __Jolt_delete_JPH_JobSystem_Barrier_void_ptr_void_ptr(void *inPointer, void *inPlace);
                    __Jolt_delete_JPH_JobSystem_Barrier_void_ptr_void_ptr(inPointer, inPlace);
                }

                /// Generated from method `JPH::JobSystem::Barrier::operator new[]`.
                /// Parameter `inPointer` is a mutable pointer.
                /// Returns a mutable pointer.
                public static unsafe void *NewArray(ulong inCount, void *inPointer)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystem_Barrier_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystem_Barrier_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void *__Jolt_new_array_JPH_JobSystem_Barrier_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                    return __Jolt_new_array_JPH_JobSystem_Barrier_unsigned_long_void_ptr(inCount, inPointer);
                }

                /// Generated from method `JPH::JobSystem::Barrier::operator delete[]`.
                /// Parameter `inPointer` is a mutable pointer.
                /// Parameter `inPlace` is a mutable pointer.
                public static unsafe void DeleteArray(void *inPointer, void *inPlace)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr_void_ptr(void *inPointer, void *inPlace);
                    __Jolt_delete_array_JPH_JobSystem_Barrier_void_ptr_void_ptr(inPointer, inPlace);
                }
            }

            /// A job barrier keeps track of a number of jobs and allows waiting until they are all completed.
            /// Generated from class `JPH::JobSystem::Barrier`.
            /// Base classes:
            ///   Direct: (non-virtual)
            ///     `JPH::NonCopyable`
            /// This is the non-const half of the class.
            public class Barrier : Const_Barrier
            {
                // Upcasts:
                public static unsafe implicit operator Jolt.JPH.NonCopyable(Barrier self)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_Barrier_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_Barrier_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.NonCopyable._Underlying *__JPH_JobSystem_Barrier_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                    Jolt.JPH.NonCopyable ret = new(__JPH_JobSystem_Barrier_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                    ret._KeepAliveEnclosingObject = self;
                    return ret;
                }

                internal unsafe Barrier(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

                /// Add a job to this barrier
                /// Note that jobs can keep being added to the barrier while waiting for the barrier
                /// Generated from method `JPH::JobSystem::Barrier::AddJob`.
                public unsafe void AddJob(Jolt.JPH.JobSystem.Const_JobHandle inJob)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_Barrier_AddJob", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_Barrier_AddJob", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __JPH_JobSystem_Barrier_AddJob(_Underlying *_this, Jolt.JPH.JobSystem.Const_JobHandle._Underlying *inJob);
                    __JPH_JobSystem_Barrier_AddJob(_UnderlyingPtr, inJob._UnderlyingPtr);
                }

                /// Add multiple jobs to this barrier
                /// Note that jobs can keep being added to the barrier while waiting for the barrier
                /// Generated from method `JPH::JobSystem::Barrier::AddJobs`.
                public unsafe void AddJobs(Jolt.JPH.JobSystem.Const_JobHandle? inHandles, uint inNumHandles)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_Barrier_AddJobs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_Barrier_AddJobs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __JPH_JobSystem_Barrier_AddJobs(_Underlying *_this, Jolt.JPH.JobSystem.Const_JobHandle._Underlying *inHandles, uint inNumHandles);
                    __JPH_JobSystem_Barrier_AddJobs(_UnderlyingPtr, inHandles is not null ? inHandles._UnderlyingPtr : null, inNumHandles);
                }
            }

            /// This is used for optional parameters of class `Barrier` with default arguments.
            /// This is only used mutable parameters. For const ones we have `_InOptConst_Barrier`.
            /// Usage:
            /// * Pass `null` to use the default argument.
            /// * Pass `new()` to pass no object.
            /// * Pass an instance of `Barrier`/`Const_Barrier` directly.
            public class _InOptMut_Barrier
            {
                public Barrier? Opt;

                public _InOptMut_Barrier() {}
                public _InOptMut_Barrier(Barrier value) {Opt = value;}
                public static implicit operator _InOptMut_Barrier(Barrier value) {return new(value);}
            }

            /// This is used for optional parameters of class `Barrier` with default arguments.
            /// This is only used const parameters. For non-const ones we have `_InOptMut_Barrier`.
            /// Usage:
            /// * Pass `null` to use the default argument.
            /// * Pass `new()` to pass no object.
            /// * Pass an instance of `Barrier`/`Const_Barrier` to pass it to the function.
            public class _InOptConst_Barrier
            {
                public Const_Barrier? Opt;

                public _InOptConst_Barrier() {}
                public _InOptConst_Barrier(Const_Barrier value) {Opt = value;}
                public static implicit operator _InOptConst_Barrier(Const_Barrier value) {return new(value);}
            }

            /// A job handle contains a reference to a job. The job will be deleted as soon as there are no JobHandles.
            /// referring to the job and when it is not in the job queue / being processed.
            /// Generated from class `JPH::JobSystem::JobHandle`.
            /// This is the const half of the class.
            public class Const_JobHandle : Jolt.Object<Const_JobHandle>, System.IDisposable
            {
                internal struct _Underlying {} // Represents the underlying C++ type.

                internal unsafe _Underlying *_UnderlyingPtr;

                protected virtual unsafe void Dispose(bool disposing)
                {
                    if (_UnderlyingPtr is null || !_IsOwningVal)
                        return;
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_JobHandle_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_JobHandle_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __JPH_JobSystem_JobHandle_Destroy(_Underlying *_this);
                    __JPH_JobSystem_JobHandle_Destroy(_UnderlyingPtr);
                    _UnderlyingPtr = null;
                }
                public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
                ~Const_JobHandle() {Dispose(false);}

                internal unsafe Const_JobHandle(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

                /// Constructs an empty (default-constructed) instance.
                public unsafe Const_JobHandle() : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_JobHandle_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_JobHandle_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.JobSystem.JobHandle._Underlying *__JPH_JobSystem_JobHandle_DefaultConstruct();
                    _UnderlyingPtr = __JPH_JobSystem_JobHandle_DefaultConstruct();
                }

                /// Generated from constructor `JPH::JobSystem::JobHandle::JobHandle`.
                public unsafe Const_JobHandle(Jolt.JPH.JobSystem._ByValue_JobHandle inHandle) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_JobHandle_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_JobHandle_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.JobSystem.JobHandle._Underlying *__JPH_JobSystem_JobHandle_ConstructFromAnother(Jolt._PassBy inHandle_pass_by, Jolt.JPH.JobSystem.JobHandle._Underlying *inHandle);
                    _UnderlyingPtr = __JPH_JobSystem_JobHandle_ConstructFromAnother(inHandle.PassByMode, inHandle.Value is not null ? inHandle.Value._UnderlyingPtr : null);
                    if (inHandle.Value is not null) _KeepAlive(inHandle.Value);
                }

                /// Generated from constructor `JPH::JobSystem::JobHandle::JobHandle`.
                public Const_JobHandle(Const_JobHandle inHandle) : this(new _ByValue_JobHandle(inHandle)) {}

                /// Generated from constructor `JPH::JobSystem::JobHandle::JobHandle`.
                public Const_JobHandle(JobHandle inHandle) : this((Const_JobHandle)inHandle) {}

                /// Check if this handle contains a job
                /// Generated from method `JPH::JobSystem::JobHandle::IsValid`.
                public unsafe bool IsValid()
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_JobHandle_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_JobHandle_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static byte __JPH_JobSystem_JobHandle_IsValid(_Underlying *_this);
                    return __JPH_JobSystem_JobHandle_IsValid(_UnderlyingPtr) != 0;
                }

                /// Check if this job has finished executing
                /// Generated from method `JPH::JobSystem::JobHandle::IsDone`.
                public unsafe bool IsDone()
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_JobHandle_IsDone", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_JobHandle_IsDone", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static byte __JPH_JobSystem_JobHandle_IsDone(_Underlying *_this);
                    return __JPH_JobSystem_JobHandle_IsDone(_UnderlyingPtr) != 0;
                }

                /// Add to the dependency counter.
                /// Generated from method `JPH::JobSystem::JobHandle::AddDependency`.
                /// Parameter `inCount` defaults to `1`.
                public unsafe void AddDependency(int? inCount = null)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_JobHandle_AddDependency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_JobHandle_AddDependency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __JPH_JobSystem_JobHandle_AddDependency(_Underlying *_this, int *inCount);
                    int __deref_inCount = inCount.GetValueOrDefault();
                    __JPH_JobSystem_JobHandle_AddDependency(_UnderlyingPtr, inCount.HasValue ? &__deref_inCount : null);
                }

                /// Remove from the dependency counter. Job will start whenever the dependency counter reaches zero
                /// and if it does it is no longer valid to call the AddDependency/RemoveDependency functions.
                /// Generated from method `JPH::JobSystem::JobHandle::RemoveDependency`.
                /// Parameter `inCount` defaults to `1`.
                public unsafe void RemoveDependency(int? inCount = null)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_JobHandle_RemoveDependency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_JobHandle_RemoveDependency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __JPH_JobSystem_JobHandle_RemoveDependency(_Underlying *_this, int *inCount);
                    int __deref_inCount = inCount.GetValueOrDefault();
                    __JPH_JobSystem_JobHandle_RemoveDependency(_UnderlyingPtr, inCount.HasValue ? &__deref_inCount : null);
                }

                /// Remove a dependency from a batch of jobs at once, this can be more efficient than removing them one by one as it requires less locking
                /// Generated from method `JPH::JobSystem::JobHandle::sRemoveDependencies`.
                /// Parameter `inCount` defaults to `1`.
                public static unsafe void SRemoveDependencies(Jolt.JPH.JobSystem.Const_JobHandle? inHandles, uint inNumHandles, int? inCount = null)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_JobHandle_sRemoveDependencies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_JobHandle_sRemoveDependencies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __JPH_JobSystem_JobHandle_sRemoveDependencies(Jolt.JPH.JobSystem.Const_JobHandle._Underlying *inHandles, uint inNumHandles, int *inCount);
                    int __deref_inCount = inCount.GetValueOrDefault();
                    __JPH_JobSystem_JobHandle_sRemoveDependencies(inHandles is not null ? inHandles._UnderlyingPtr : null, inNumHandles, inCount.HasValue ? &__deref_inCount : null);
                }
            }

            /// A job handle contains a reference to a job. The job will be deleted as soon as there are no JobHandles.
            /// referring to the job and when it is not in the job queue / being processed.
            /// Generated from class `JPH::JobSystem::JobHandle`.
            /// This is the non-const half of the class.
            public class JobHandle : Const_JobHandle
            {
                internal unsafe JobHandle(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

                /// Constructs an empty (default-constructed) instance.
                public unsafe JobHandle() : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_JobHandle_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_JobHandle_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.JobSystem.JobHandle._Underlying *__JPH_JobSystem_JobHandle_DefaultConstruct();
                    _UnderlyingPtr = __JPH_JobSystem_JobHandle_DefaultConstruct();
                }

                /// Generated from constructor `JPH::JobSystem::JobHandle::JobHandle`.
                public unsafe JobHandle(Jolt.JPH.JobSystem._ByValue_JobHandle inHandle) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_JobHandle_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_JobHandle_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.JobSystem.JobHandle._Underlying *__JPH_JobSystem_JobHandle_ConstructFromAnother(Jolt._PassBy inHandle_pass_by, Jolt.JPH.JobSystem.JobHandle._Underlying *inHandle);
                    _UnderlyingPtr = __JPH_JobSystem_JobHandle_ConstructFromAnother(inHandle.PassByMode, inHandle.Value is not null ? inHandle.Value._UnderlyingPtr : null);
                    if (inHandle.Value is not null) _KeepAlive(inHandle.Value);
                }

                /// Generated from constructor `JPH::JobSystem::JobHandle::JobHandle`.
                public JobHandle(Const_JobHandle inHandle) : this(new _ByValue_JobHandle(inHandle)) {}

                /// Generated from constructor `JPH::JobSystem::JobHandle::JobHandle`.
                public JobHandle(JobHandle inHandle) : this((Const_JobHandle)inHandle) {}

                /// Assignment
                /// Generated from method `JPH::JobSystem::JobHandle::operator=`.
                public unsafe Jolt.JPH.JobSystem.JobHandle Assign(Jolt.JPH.JobSystem._ByValue_JobHandle inHandle)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_JobHandle_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_JobHandle_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.JobSystem.JobHandle._Underlying *__JPH_JobSystem_JobHandle_AssignFromAnother(_Underlying *_this, Jolt._PassBy inHandle_pass_by, Jolt.JPH.JobSystem.JobHandle._Underlying *inHandle);
                    Jolt.JPH.JobSystem.JobHandle __ret;
                    __ret = new(__JPH_JobSystem_JobHandle_AssignFromAnother(_UnderlyingPtr, inHandle.PassByMode, inHandle.Value is not null ? inHandle.Value._UnderlyingPtr : null), is_owning: false);
                    _DiscardKeepAlive();
                    if (inHandle.Value is not null) _KeepAlive(inHandle.Value);
                    __ret._KeepAlive(this);
                    return __ret;
                }
            }

            /// This is used as a function parameter when the underlying function receives `JobHandle` by value.
            /// Usage:
            /// * Pass `new()` to default-construct the instance.
            /// * Pass an instance of `JobHandle`/`Const_JobHandle` to copy it into the function.
            /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
            ///   Be careful if your input isn't a unique reference to this object.
            /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
            public class _ByValue_JobHandle
            {
                #pragma warning disable CS0649
                internal readonly Const_JobHandle? Value;
                #pragma warning restore CS0649
                internal readonly Jolt._PassBy PassByMode;
                public _ByValue_JobHandle() {PassByMode = Jolt._PassBy.default_construct;}
                public _ByValue_JobHandle(Const_JobHandle new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
                public static implicit operator _ByValue_JobHandle(Const_JobHandle arg) {return new(arg);}
                public _ByValue_JobHandle(Jolt._Moved<JobHandle> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
                public static implicit operator _ByValue_JobHandle(Jolt._Moved<JobHandle> arg) {return new(arg);}
            }

            /// This is used for optional parameters of class `JobHandle` with default arguments.
            /// This is only used mutable parameters. For const ones we have `_InOptConst_JobHandle`.
            /// Usage:
            /// * Pass `null` to use the default argument.
            /// * Pass `new()` to pass no object.
            /// * Pass an instance of `JobHandle`/`Const_JobHandle` directly.
            public class _InOptMut_JobHandle
            {
                public JobHandle? Opt;

                public _InOptMut_JobHandle() {}
                public _InOptMut_JobHandle(JobHandle value) {Opt = value;}
                public static implicit operator _InOptMut_JobHandle(JobHandle value) {return new(value);}
            }

            /// This is used for optional parameters of class `JobHandle` with default arguments.
            /// This is only used const parameters. For non-const ones we have `_InOptMut_JobHandle`.
            /// Usage:
            /// * Pass `null` to use the default argument.
            /// * Pass `new()` to pass no object.
            /// * Pass an instance of `JobHandle`/`Const_JobHandle` to pass it to the function.
            public class _InOptConst_JobHandle
            {
                public Const_JobHandle? Opt;

                public _InOptConst_JobHandle() {}
                public _InOptConst_JobHandle(Const_JobHandle value) {Opt = value;}
                public static implicit operator _InOptConst_JobHandle(Const_JobHandle value) {return new(value);}
            }
        }

        /// A class that allows units of work (Jobs) to be scheduled across multiple threads.
        /// It allows dependencies between the jobs so that the jobs form a graph.
        ///
        /// The pattern for using this class is:
        ///
        ///		// Create job system
        ///		JobSystem *job_system = new JobSystemThreadPool(...);
        ///
        ///		// Create some jobs
        ///		JobHandle second_job = job_system->CreateJob("SecondJob", Color::sRed, []() { ... }, 1); // Create a job with 1 dependency
        ///		JobHandle first_job = job_system->CreateJob("FirstJob", Color::sGreen, [second_job]() { ....; second_job.RemoveDependency(); }, 0); // Job can start immediately, will start second job when it's done
        ///		JobHandle third_job = job_system->CreateJob("ThirdJob", Color::sBlue, []() { ... }, 0); // This job can run immediately as well and can run in parallel to job 1 and 2
        ///
        ///		// Add the jobs to the barrier so that we can execute them while we're waiting
        ///		Barrier *barrier = job_system->CreateBarrier();
        ///		barrier->AddJob(first_job);
        ///		barrier->AddJob(second_job);
        ///		barrier->AddJob(third_job);
        ///		job_system->WaitForJobs(barrier);
        ///
        ///		// Clean up
        ///		job_system->DestroyBarrier(barrier);
        ///		delete job_system;
        ///
        ///	Jobs are guaranteed to be started in the order that their dependency counter becomes zero (in case they're scheduled on a background thread)
        ///	or in the order they're added to the barrier (when dependency count is zero and when executing on the thread that calls WaitForJobs).
        ///
        /// If you want to implement your own job system, inherit from JobSystem and implement:
        ///
        /// * JobSystem::GetMaxConcurrency - This should return the maximum number of jobs that can run in parallel.
        /// * JobSystem::CreateJob - This should create a Job object and return it to the caller.
        /// * JobSystem::FreeJob - This should free the memory associated with the job object. It is called by the Job destructor when it is Release()-ed for the last time.
        /// * JobSystem::QueueJob/QueueJobs - These should store the job pointer in an internal queue to run immediately (dependencies are tracked internally, this function is called when the job can run).
        /// The Job objects are reference counted and are guaranteed to stay alive during the QueueJob(s) call. If you store the job in your own data structure you need to call AddRef() to take a reference.
        /// After the job has been executed you need to call Release() to release the reference. Make sure you no longer dereference the job pointer after calling Release().
        ///
        /// JobSystem::Barrier is used to track the completion of a set of jobs. Jobs will be created by other jobs and added to the barrier while it is being waited on. This means that you cannot
        /// create a dependency graph beforehand as the graph changes while jobs are running. Implement the following functions:
        ///
        /// * Barrier::AddJob/AddJobs - Add a job to the barrier, any call to WaitForJobs will now also wait for this job to complete.
        /// If you store the job in a data structure in the Barrier you need to call AddRef() on the job to keep it alive and Release() after you're done with it.
        /// * Barrier::OnJobFinished - This function is called when a job has finished executing, you can use this to track completion and remove the job from the list of jobs to wait on.
        ///
        /// The functions on JobSystem that need to be implemented to support barriers are:
        ///
        /// * JobSystem::CreateBarrier - Create a new barrier.
        /// * JobSystem::DestroyBarrier - Destroy a barrier.
        /// * JobSystem::WaitForJobs - This is the main function that is used to wait for all jobs that have been added to a Barrier. WaitForJobs can execute jobs that have
        /// been added to the barrier while waiting. It is not wise to execute other jobs that touch physics structures as this can cause race conditions and deadlocks. Please keep in mind that the barrier is
        /// only intended to wait on the completion of the Jolt jobs added to it, if you scheduled any jobs in your engine's job system to execute the Jolt jobs as part of QueueJob/QueueJobs, you might still need
        /// to wait for these in this function after the barrier is finished waiting.
        ///
        /// An example implementation is JobSystemThreadPool. If you don't want to write the Barrier class you can also inherit from JobSystemWithBarrier.
        /// Generated from class `JPH::JobSystem`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::NonCopyable`
        /// Derived classes:
        ///   Direct: (non-virtual)
        ///     `JPH::JobSystemWithBarrier`
        ///   Indirect: (non-virtual)
        ///     `JPH::JobSystemThreadPool`
        /// This is the non-const half of the class.
        public class JobSystem : Const_JobSystem
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.NonCopyable(JobSystem self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_JobSystem_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_JobSystem_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            internal unsafe JobSystem(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Create a new barrier, used to wait on jobs
            /// Generated from method `JPH::JobSystem::CreateBarrier`.
            public unsafe Jolt.JPH.JobSystem.Barrier? CreateBarrier()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_CreateBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_CreateBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.JobSystem.Barrier._Underlying *__JPH_JobSystem_CreateBarrier(_Underlying *_this);
                var __c_ret = __JPH_JobSystem_CreateBarrier(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.JobSystem.Barrier(__c_ret, is_owning: false) : null;
            }

            /// Destroy a barrier when it is no longer used. The barrier should be empty at this point.
            /// Generated from method `JPH::JobSystem::DestroyBarrier`.
            public unsafe void DestroyBarrier(Jolt.JPH.JobSystem.Barrier? inBarrier)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_DestroyBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_DestroyBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_JobSystem_DestroyBarrier(_Underlying *_this, Jolt.JPH.JobSystem.Barrier._Underlying *inBarrier);
                __JPH_JobSystem_DestroyBarrier(_UnderlyingPtr, inBarrier is not null ? inBarrier._UnderlyingPtr : null);
            }

            /// Wait for a set of jobs to be finished, note that only 1 thread can be waiting on a barrier at a time
            /// Generated from method `JPH::JobSystem::WaitForJobs`.
            public unsafe void WaitForJobs(Jolt.JPH.JobSystem.Barrier? inBarrier)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystem_WaitForJobs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystem_WaitForJobs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_JobSystem_WaitForJobs(_Underlying *_this, Jolt.JPH.JobSystem.Barrier._Underlying *inBarrier);
                __JPH_JobSystem_WaitForJobs(_UnderlyingPtr, inBarrier is not null ? inBarrier._UnderlyingPtr : null);
            }
        }

        /// This is used for optional parameters of class `JobSystem` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_JobSystem`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `JobSystem`/`Const_JobSystem` directly.
        public class _InOptMut_JobSystem
        {
            public JobSystem? Opt;

            public _InOptMut_JobSystem() {}
            public _InOptMut_JobSystem(JobSystem value) {Opt = value;}
            public static implicit operator _InOptMut_JobSystem(JobSystem value) {return new(value);}
        }

        /// This is used for optional parameters of class `JobSystem` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_JobSystem`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `JobSystem`/`Const_JobSystem` to pass it to the function.
        public class _InOptConst_JobSystem
        {
            public Const_JobSystem? Opt;

            public _InOptConst_JobSystem() {}
            public _InOptConst_JobSystem(Const_JobSystem value) {Opt = value;}
            public static implicit operator _InOptConst_JobSystem(Const_JobSystem value) {return new(value);}
        }
    }
}
