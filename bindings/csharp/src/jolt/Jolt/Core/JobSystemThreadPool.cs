// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Implementation of a JobSystem using a thread pool
        ///
        /// Note that this is considered an example implementation. It is expected that when you integrate
        /// the physics engine into your own project that you'll provide your own implementation of the
        /// JobSystem built on top of whatever job system your project uses.
        /// Generated from class `JPH::JobSystemThreadPool`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::JobSystemWithBarrier`
        ///   Indirect: (non-virtual)
        ///     `JPH::NonCopyable`
        ///     `JPH::JobSystem`
        /// This is the const half of the class.
        public class Const_JobSystemThreadPool : Jolt.Object<Const_JobSystemThreadPool>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_JobSystemThreadPool_Destroy(_Underlying *_this);
                __JPH_JobSystemThreadPool_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_JobSystemThreadPool() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_JobSystemThreadPool self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_JobSystemThreadPool_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_JobSystemThreadPool_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_JobSystem(Const_JobSystemThreadPool self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_JobSystem._Underlying *__JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystem(_Underlying *_this);
                Jolt.JPH.Const_JobSystem ret = new(__JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystem(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_JobSystemWithBarrier(Const_JobSystemThreadPool self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystemWithBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystemWithBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_JobSystemWithBarrier._Underlying *__JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystemWithBarrier(_Underlying *_this);
                Jolt.JPH.Const_JobSystemWithBarrier ret = new(__JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystemWithBarrier(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_JobSystemThreadPool?(Jolt.JPH.Const_JobSystem parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystem(Jolt.JPH.Const_JobSystem._Underlying *_this);
                var ptr = __JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystem(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_JobSystemThreadPool ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_JobSystemThreadPool?(Jolt.JPH.Const_JobSystemWithBarrier parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystemWithBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystemWithBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystemWithBarrier(Jolt.JPH.Const_JobSystemWithBarrier._Underlying *_this);
                var ptr = __JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystemWithBarrier(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_JobSystemThreadPool ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe Const_JobSystemThreadPool(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_JobSystemThreadPool() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.JobSystemThreadPool._Underlying *__JPH_JobSystemThreadPool_DefaultConstruct();
                _UnderlyingPtr = __JPH_JobSystemThreadPool_DefaultConstruct();
            }

            /// Creates a thread pool.
            /// @see JobSystemThreadPool::Init
            /// Generated from constructor `JPH::JobSystemThreadPool::JobSystemThreadPool`.
            /// Parameter `inNumThreads` defaults to `-1`.
            public unsafe Const_JobSystemThreadPool(uint inMaxJobs, uint inMaxBarriers, int? inNumThreads = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.JobSystemThreadPool._Underlying *__JPH_JobSystemThreadPool_Construct(uint inMaxJobs, uint inMaxBarriers, int *inNumThreads);
                int __deref_inNumThreads = inNumThreads.GetValueOrDefault();
                _UnderlyingPtr = __JPH_JobSystemThreadPool_Construct(inMaxJobs, inMaxBarriers, inNumThreads.HasValue ? &__deref_inNumThreads : null);
            }

            /// Generated from method `JPH::JobSystemThreadPool::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_JobSystemThreadPool_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_JobSystemThreadPool_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_JobSystemThreadPool_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_JobSystemThreadPool_unsigned_long(inCount);
            }

            /// Generated from method `JPH::JobSystemThreadPool::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemThreadPool_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemThreadPool_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_JobSystemThreadPool_void_ptr(void *inPointer);
                __Jolt_delete_JPH_JobSystemThreadPool_void_ptr(inPointer);
            }

            /// Generated from method `JPH::JobSystemThreadPool::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemThreadPool_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemThreadPool_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_JobSystemThreadPool_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_JobSystemThreadPool_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::JobSystemThreadPool::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemThreadPool_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemThreadPool_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_JobSystemThreadPool_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_JobSystemThreadPool_unsigned_long(inCount);
            }

            /// Generated from method `JPH::JobSystemThreadPool::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr(inPointer);
            }

            /// Generated from method `JPH::JobSystemThreadPool::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::JobSystemThreadPool::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_JobSystemThreadPool_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_JobSystemThreadPool_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_JobSystemThreadPool_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_JobSystemThreadPool_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::JobSystemThreadPool::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemThreadPool_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_JobSystemThreadPool_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_JobSystemThreadPool_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_JobSystemThreadPool_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::JobSystemThreadPool::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemThreadPool_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_JobSystemThreadPool_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_JobSystemThreadPool_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_JobSystemThreadPool_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::JobSystemThreadPool::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_JobSystemThreadPool_void_ptr_void_ptr(inPointer, inPlace);
            }

            // See JobSystem
            /// Generated from method `JPH::JobSystemThreadPool::GetMaxConcurrency`.
            public unsafe int GetMaxConcurrency()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_GetMaxConcurrency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_GetMaxConcurrency", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_JobSystemThreadPool_GetMaxConcurrency(_Underlying *_this);
                return __JPH_JobSystemThreadPool_GetMaxConcurrency(_UnderlyingPtr);
            }
        }

        /// Implementation of a JobSystem using a thread pool
        ///
        /// Note that this is considered an example implementation. It is expected that when you integrate
        /// the physics engine into your own project that you'll provide your own implementation of the
        /// JobSystem built on top of whatever job system your project uses.
        /// Generated from class `JPH::JobSystemThreadPool`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::JobSystemWithBarrier`
        ///   Indirect: (non-virtual)
        ///     `JPH::NonCopyable`
        ///     `JPH::JobSystem`
        /// This is the non-const half of the class.
        public class JobSystemThreadPool : Const_JobSystemThreadPool
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.NonCopyable(JobSystemThreadPool self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_JobSystemThreadPool_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_JobSystemThreadPool_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.JobSystem(JobSystemThreadPool self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.JobSystem._Underlying *__JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystem(_Underlying *_this);
                Jolt.JPH.JobSystem ret = new(__JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystem(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.JobSystemWithBarrier(JobSystemThreadPool self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystemWithBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystemWithBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.JobSystemWithBarrier._Underlying *__JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystemWithBarrier(_Underlying *_this);
                Jolt.JPH.JobSystemWithBarrier ret = new(__JPH_JobSystemThreadPool_UpcastTo_JPH_JobSystemWithBarrier(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator JobSystemThreadPool?(Jolt.JPH.JobSystem parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystem(Jolt.JPH.JobSystem._Underlying *_this);
                var ptr = __JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystem(parent._UnderlyingPtr);
                if (ptr is null) return null;
                JobSystemThreadPool ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator JobSystemThreadPool?(Jolt.JPH.JobSystemWithBarrier parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystemWithBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystemWithBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystemWithBarrier(Jolt.JPH.JobSystemWithBarrier._Underlying *_this);
                var ptr = __JPH_JobSystemThreadPool_DynamicDowncastFrom_JPH_JobSystemWithBarrier(parent._UnderlyingPtr);
                if (ptr is null) return null;
                JobSystemThreadPool ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe JobSystemThreadPool(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe JobSystemThreadPool() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.JobSystemThreadPool._Underlying *__JPH_JobSystemThreadPool_DefaultConstruct();
                _UnderlyingPtr = __JPH_JobSystemThreadPool_DefaultConstruct();
            }

            /// Creates a thread pool.
            /// @see JobSystemThreadPool::Init
            /// Generated from constructor `JPH::JobSystemThreadPool::JobSystemThreadPool`.
            /// Parameter `inNumThreads` defaults to `-1`.
            public unsafe JobSystemThreadPool(uint inMaxJobs, uint inMaxBarriers, int? inNumThreads = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.JobSystemThreadPool._Underlying *__JPH_JobSystemThreadPool_Construct(uint inMaxJobs, uint inMaxBarriers, int *inNumThreads);
                int __deref_inNumThreads = inNumThreads.GetValueOrDefault();
                _UnderlyingPtr = __JPH_JobSystemThreadPool_Construct(inMaxJobs, inMaxBarriers, inNumThreads.HasValue ? &__deref_inNumThreads : null);
            }

            /// Generated from method `JPH::JobSystemThreadPool::SetThreadInitFunction`.
            public unsafe void SetThreadInitFunction(Jolt.Std.Const_Function_Void_From_Int inInitFunction)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_SetThreadInitFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_SetThreadInitFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_JobSystemThreadPool_SetThreadInitFunction(_Underlying *_this, Jolt.Std.Const_Function_Void_From_Int._Underlying *inInitFunction);
                __JPH_JobSystemThreadPool_SetThreadInitFunction(_UnderlyingPtr, inInitFunction._UnderlyingPtr);
            }

            /// Generated from method `JPH::JobSystemThreadPool::SetThreadExitFunction`.
            public unsafe void SetThreadExitFunction(Jolt.Std.Const_Function_Void_From_Int inExitFunction)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_SetThreadExitFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_SetThreadExitFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_JobSystemThreadPool_SetThreadExitFunction(_Underlying *_this, Jolt.Std.Const_Function_Void_From_Int._Underlying *inExitFunction);
                __JPH_JobSystemThreadPool_SetThreadExitFunction(_UnderlyingPtr, inExitFunction._UnderlyingPtr);
            }

            /// Initialize the thread pool
            /// @param inMaxJobs Max number of jobs that can be allocated at any time
            /// @param inMaxBarriers Max number of barriers that can be allocated at any time
            /// @param inNumThreads Number of threads to start (the number of concurrent jobs is 1 more because the main thread will also run jobs while waiting for a barrier to complete). Use -1 to auto detect the amount of CPU's.
            /// Generated from method `JPH::JobSystemThreadPool::Init`.
            /// Parameter `inNumThreads` defaults to `-1`.
            public unsafe void Init(uint inMaxJobs, uint inMaxBarriers, int? inNumThreads = null)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_Init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_Init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_JobSystemThreadPool_Init(_Underlying *_this, uint inMaxJobs, uint inMaxBarriers, int *inNumThreads);
                int __deref_inNumThreads = inNumThreads.GetValueOrDefault();
                __JPH_JobSystemThreadPool_Init(_UnderlyingPtr, inMaxJobs, inMaxBarriers, inNumThreads.HasValue ? &__deref_inNumThreads : null);
            }

            /// Change the max concurrency after initialization
            /// Generated from method `JPH::JobSystemThreadPool::SetNumThreads`.
            public unsafe void SetNumThreads(int inNumThreads)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_SetNumThreads", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_SetNumThreads", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_JobSystemThreadPool_SetNumThreads(_Underlying *_this, int inNumThreads);
                __JPH_JobSystemThreadPool_SetNumThreads(_UnderlyingPtr, inNumThreads);
            }

            // See JobSystem
            /// Generated from method `JPH::JobSystemThreadPool::CreateBarrier`.
            public unsafe Jolt.JPH.JobSystem.Barrier? CreateBarrier()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_CreateBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_CreateBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.JobSystem.Barrier._Underlying *__JPH_JobSystemThreadPool_CreateBarrier(_Underlying *_this);
                var __c_ret = __JPH_JobSystemThreadPool_CreateBarrier(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.JobSystem.Barrier(__c_ret, is_owning: false) : null;
            }

            /// Generated from method `JPH::JobSystemThreadPool::DestroyBarrier`.
            public unsafe void DestroyBarrier(Jolt.JPH.JobSystem.Barrier? inBarrier)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_DestroyBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_DestroyBarrier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_JobSystemThreadPool_DestroyBarrier(_Underlying *_this, Jolt.JPH.JobSystem.Barrier._Underlying *inBarrier);
                __JPH_JobSystemThreadPool_DestroyBarrier(_UnderlyingPtr, inBarrier is not null ? inBarrier._UnderlyingPtr : null);
            }

            /// Generated from method `JPH::JobSystemThreadPool::WaitForJobs`.
            public unsafe void WaitForJobs(Jolt.JPH.JobSystem.Barrier? inBarrier)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_JobSystemThreadPool_WaitForJobs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_JobSystemThreadPool_WaitForJobs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_JobSystemThreadPool_WaitForJobs(_Underlying *_this, Jolt.JPH.JobSystem.Barrier._Underlying *inBarrier);
                __JPH_JobSystemThreadPool_WaitForJobs(_UnderlyingPtr, inBarrier is not null ? inBarrier._UnderlyingPtr : null);
            }
        }

        /// This is used as a function parameter when the underlying function receives `JobSystemThreadPool` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_JobSystemThreadPool
        {
            #pragma warning disable CS0649
            internal readonly Const_JobSystemThreadPool? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_JobSystemThreadPool() {PassByMode = Jolt._PassBy.default_construct;}
        }

        /// This is used for optional parameters of class `JobSystemThreadPool` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_JobSystemThreadPool`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `JobSystemThreadPool`/`Const_JobSystemThreadPool` directly.
        public class _InOptMut_JobSystemThreadPool
        {
            public JobSystemThreadPool? Opt;

            public _InOptMut_JobSystemThreadPool() {}
            public _InOptMut_JobSystemThreadPool(JobSystemThreadPool value) {Opt = value;}
            public static implicit operator _InOptMut_JobSystemThreadPool(JobSystemThreadPool value) {return new(value);}
        }

        /// This is used for optional parameters of class `JobSystemThreadPool` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_JobSystemThreadPool`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `JobSystemThreadPool`/`Const_JobSystemThreadPool` to pass it to the function.
        public class _InOptConst_JobSystemThreadPool
        {
            public Const_JobSystemThreadPool? Opt;

            public _InOptConst_JobSystemThreadPool() {}
            public _InOptConst_JobSystemThreadPool(Const_JobSystemThreadPool value) {Opt = value;}
            public static implicit operator _InOptConst_JobSystemThreadPool(Const_JobSystemThreadPool value) {return new(value);}
        }
    }
}
