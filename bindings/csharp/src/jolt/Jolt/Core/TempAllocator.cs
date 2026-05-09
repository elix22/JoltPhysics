// machine generated, do not edit
public static partial class JPH
{
    /// Allocator for temporary allocations.
    /// This allocator works as a stack: The blocks must always be freed in the reverse order as they are allocated.
    /// Note that allocations and frees can take place from different threads, but the order is guaranteed though
    /// job dependencies, so it is not needed to use any form of locking.
    /// Generated from class `JPH::TempAllocator`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TempAllocatorImpl`
    ///     `JPH::TempAllocatorImplWithMallocFallback`
    ///     `JPH::TempAllocatorMalloc`
    /// This is the const half of the class.
    public class Const_TempAllocator : JPH.Object<Const_TempAllocator>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocator_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocator_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TempAllocator_Destroy(_Underlying *_this);
            __JPH_TempAllocator_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_TempAllocator() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_TempAllocator self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocator_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocator_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_TempAllocator_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_TempAllocator_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_TempAllocator(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocator_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocator_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TempAllocator_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_TempAllocator ret = new(__JPH_TempAllocator_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// If this allocator needs to fall back to aligned allocations because JPH_RVECTOR_ALIGNMENT is bigger than the platform default
        public static unsafe bool NeedsAlignedAllocate
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocator_Get_needs_aligned_allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocator_Get_needs_aligned_allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_TempAllocator_Get_needs_aligned_allocate();
                return *__JPH_TempAllocator_Get_needs_aligned_allocate();
            }
        }

        internal unsafe Const_TempAllocator(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `JPH::TempAllocator::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TempAllocator_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TempAllocator_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TempAllocator_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_TempAllocator_size_t(inCount);
        }

        /// Generated from method `JPH::TempAllocator::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocator_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocator_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TempAllocator_void_ptr(void *inPointer);
            __Jolt_delete_JPH_TempAllocator_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TempAllocator::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocator_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocator_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TempAllocator_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_TempAllocator_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TempAllocator::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocator_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocator_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TempAllocator_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_TempAllocator_size_t(inCount);
        }

        /// Generated from method `JPH::TempAllocator::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocator_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocator_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TempAllocator_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_TempAllocator_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TempAllocator::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocator_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocator_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TempAllocator_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_TempAllocator_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TempAllocator::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TempAllocator_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TempAllocator_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TempAllocator_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_TempAllocator_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TempAllocator::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocator_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocator_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TempAllocator_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_TempAllocator_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::TempAllocator::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocator_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocator_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TempAllocator_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_TempAllocator_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TempAllocator::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocator_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocator_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TempAllocator_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_TempAllocator_void_ptr_void_ptr(inPointer, inPlace);
        }
    }

    /// Allocator for temporary allocations.
    /// This allocator works as a stack: The blocks must always be freed in the reverse order as they are allocated.
    /// Note that allocations and frees can take place from different threads, but the order is guaranteed though
    /// job dependencies, so it is not needed to use any form of locking.
    /// Generated from class `JPH::TempAllocator`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TempAllocatorImpl`
    ///     `JPH::TempAllocatorImplWithMallocFallback`
    ///     `JPH::TempAllocatorMalloc`
    /// This is the non-const half of the class.
    public class TempAllocator : Const_TempAllocator
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(TempAllocator self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocator_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocator_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_TempAllocator_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_TempAllocator_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(TempAllocator self)
            => (JPH.Const_NonCopyable)(JPH.Const_TempAllocator)self;

        // Downcasts:
        public static unsafe explicit operator TempAllocator(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocator_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocator_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TempAllocator_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            TempAllocator ret = new(__JPH_TempAllocator_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe TempAllocator(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Allocates inSize bytes of memory, returned memory address must be JPH_RVECTOR_ALIGNMENT byte aligned
        /// Generated from method `JPH::TempAllocator::Allocate`.
        /// Returns a mutable pointer.
        public unsafe void *Allocate(uint inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocator_Allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocator_Allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TempAllocator_Allocate(_Underlying *_this, uint inSize);
            return __JPH_TempAllocator_Allocate(_UnderlyingPtr, inSize);
        }

        /// Frees inSize bytes of memory located at inAddress
        /// Generated from method `JPH::TempAllocator::Free`.
        /// Parameter `inAddress` is a mutable pointer.
        public unsafe void Free(void *inAddress, uint inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocator_Free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocator_Free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TempAllocator_Free(_Underlying *_this, void *inAddress, uint inSize);
            __JPH_TempAllocator_Free(_UnderlyingPtr, inAddress, inSize);
        }
    }

    /// This is used for optional parameters of class `TempAllocator` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_TempAllocator`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TempAllocator`/`Const_TempAllocator` directly.
    public class _InOptMut_TempAllocator
    {
        public TempAllocator? Opt;

        public _InOptMut_TempAllocator() {}
        public _InOptMut_TempAllocator(TempAllocator value) {Opt = value;}
        public static implicit operator _InOptMut_TempAllocator(TempAllocator value) {return new(value);}
    }

    /// This is used for optional parameters of class `TempAllocator` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_TempAllocator`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TempAllocator`/`Const_TempAllocator` to pass it to the function.
    public class _InOptConst_TempAllocator
    {
        public Const_TempAllocator? Opt;

        public _InOptConst_TempAllocator() {}
        public _InOptConst_TempAllocator(Const_TempAllocator value) {Opt = value;}
        public static implicit operator _InOptConst_TempAllocator(Const_TempAllocator value) {return new(value);}
    }

    /// Default implementation of the temp allocator that allocates a large block through malloc upfront
    /// Generated from class `JPH::TempAllocatorImpl`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TempAllocator`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_TempAllocatorImpl : JPH.Object<Const_TempAllocatorImpl>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TempAllocatorImpl_Destroy(_Underlying *_this);
            __JPH_TempAllocatorImpl_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_TempAllocatorImpl() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_TempAllocatorImpl self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_TempAllocatorImpl_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_TempAllocatorImpl_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_TempAllocator(Const_TempAllocatorImpl self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_UpcastTo_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_UpcastTo_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_TempAllocator._Underlying *__JPH_TempAllocatorImpl_UpcastTo_JPH_TempAllocator(_Underlying *_this);
            JPH.Const_TempAllocator ret = new(__JPH_TempAllocatorImpl_UpcastTo_JPH_TempAllocator(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_TempAllocatorImpl(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_TempAllocatorImpl ret = new(__JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TempAllocatorImpl(JPH.Const_TempAllocator parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_TempAllocator(JPH.Const_TempAllocator._Underlying *_this);
            Const_TempAllocatorImpl ret = new(__JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_TempAllocator(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// If this allocator needs to fall back to aligned allocations because JPH_RVECTOR_ALIGNMENT is bigger than the platform default
        public static unsafe bool NeedsAlignedAllocate
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_Get_needs_aligned_allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_Get_needs_aligned_allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_TempAllocatorImpl_Get_needs_aligned_allocate();
                return *__JPH_TempAllocatorImpl_Get_needs_aligned_allocate();
            }
        }

        internal unsafe Const_TempAllocatorImpl(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs the allocator with a maximum allocatable size of inSize
        /// Generated from constructor `JPH::TempAllocatorImpl::TempAllocatorImpl`.
        public unsafe Const_TempAllocatorImpl(UIntPtr inSize) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TempAllocatorImpl._Underlying *__JPH_TempAllocatorImpl_Construct(UIntPtr inSize);
            _UnderlyingPtr = __JPH_TempAllocatorImpl_Construct(inSize);
        }

        /// Generated from method `JPH::TempAllocatorImpl::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TempAllocatorImpl_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TempAllocatorImpl_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TempAllocatorImpl_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_TempAllocatorImpl_size_t(inCount);
        }

        /// Generated from method `JPH::TempAllocatorImpl::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorImpl_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorImpl_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TempAllocatorImpl_void_ptr(void *inPointer);
            __Jolt_delete_JPH_TempAllocatorImpl_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TempAllocatorImpl::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorImpl_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorImpl_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TempAllocatorImpl_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_TempAllocatorImpl_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TempAllocatorImpl::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocatorImpl_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocatorImpl_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TempAllocatorImpl_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_TempAllocatorImpl_size_t(inCount);
        }

        /// Generated from method `JPH::TempAllocatorImpl::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TempAllocatorImpl::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TempAllocatorImpl::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TempAllocatorImpl_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TempAllocatorImpl_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TempAllocatorImpl_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_TempAllocatorImpl_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TempAllocatorImpl::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorImpl_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorImpl_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TempAllocatorImpl_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_TempAllocatorImpl_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::TempAllocatorImpl::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocatorImpl_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocatorImpl_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TempAllocatorImpl_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_TempAllocatorImpl_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TempAllocatorImpl::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_TempAllocatorImpl_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Check if no allocations have been made
        /// Generated from method `JPH::TempAllocatorImpl::IsEmpty`.
        public unsafe bool IsEmpty()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_IsEmpty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_IsEmpty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_TempAllocatorImpl_IsEmpty(_Underlying *_this);
            return __JPH_TempAllocatorImpl_IsEmpty(_UnderlyingPtr) != 0;
        }

        /// Get the total size of the fixed buffer
        /// Generated from method `JPH::TempAllocatorImpl::GetSize`.
        public unsafe UIntPtr GetSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_GetSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_GetSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_TempAllocatorImpl_GetSize(_Underlying *_this);
            return __JPH_TempAllocatorImpl_GetSize(_UnderlyingPtr);
        }

        /// Get current usage in bytes of the buffer
        /// Generated from method `JPH::TempAllocatorImpl::GetUsage`.
        public unsafe UIntPtr GetUsage()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_GetUsage", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_GetUsage", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_TempAllocatorImpl_GetUsage(_Underlying *_this);
            return __JPH_TempAllocatorImpl_GetUsage(_UnderlyingPtr);
        }

        /// Check if an allocation of inSize can be made in this fixed buffer allocator
        /// Generated from method `JPH::TempAllocatorImpl::CanAllocate`.
        public unsafe bool CanAllocate(uint inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_CanAllocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_CanAllocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_TempAllocatorImpl_CanAllocate(_Underlying *_this, uint inSize);
            return __JPH_TempAllocatorImpl_CanAllocate(_UnderlyingPtr, inSize) != 0;
        }

        /// Check if memory block at inAddress is owned by this allocator
        /// Generated from method `JPH::TempAllocatorImpl::OwnsMemory`.
        /// Parameter `inAddress` is a read-only pointer.
        public unsafe bool OwnsMemory(void *inAddress)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_OwnsMemory", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_OwnsMemory", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_TempAllocatorImpl_OwnsMemory(_Underlying *_this, void *inAddress);
            return __JPH_TempAllocatorImpl_OwnsMemory(_UnderlyingPtr, inAddress) != 0;
        }
    }

    /// Default implementation of the temp allocator that allocates a large block through malloc upfront
    /// Generated from class `JPH::TempAllocatorImpl`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TempAllocator`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class TempAllocatorImpl : Const_TempAllocatorImpl
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(TempAllocatorImpl self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_TempAllocatorImpl_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_TempAllocatorImpl_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(TempAllocatorImpl self)
            => (JPH.Const_NonCopyable)(JPH.Const_TempAllocatorImpl)self;
        public static unsafe implicit operator JPH.TempAllocator(TempAllocatorImpl self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_UpcastTo_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_UpcastTo_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TempAllocator._Underlying *__JPH_TempAllocatorImpl_UpcastTo_JPH_TempAllocator(_Underlying *_this);
            JPH.TempAllocator ret = new(__JPH_TempAllocatorImpl_UpcastTo_JPH_TempAllocator(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_TempAllocator(TempAllocatorImpl self)
            => (JPH.Const_TempAllocator)(JPH.Const_TempAllocatorImpl)self;

        // Downcasts:
        public static unsafe explicit operator TempAllocatorImpl(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            TempAllocatorImpl ret = new(__JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TempAllocatorImpl(JPH.TempAllocator parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_TempAllocator(JPH.TempAllocator._Underlying *_this);
            TempAllocatorImpl ret = new(__JPH_TempAllocatorImpl_StaticDowncastFrom_JPH_TempAllocator(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe TempAllocatorImpl(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs the allocator with a maximum allocatable size of inSize
        /// Generated from constructor `JPH::TempAllocatorImpl::TempAllocatorImpl`.
        public unsafe TempAllocatorImpl(UIntPtr inSize) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TempAllocatorImpl._Underlying *__JPH_TempAllocatorImpl_Construct(UIntPtr inSize);
            _UnderlyingPtr = __JPH_TempAllocatorImpl_Construct(inSize);
        }

        // See: TempAllocator
        /// Generated from method `JPH::TempAllocatorImpl::Allocate`.
        /// Returns a mutable pointer.
        public unsafe void *Allocate(uint inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_Allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_Allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TempAllocatorImpl_Allocate(_Underlying *_this, uint inSize);
            return __JPH_TempAllocatorImpl_Allocate(_UnderlyingPtr, inSize);
        }

        // See: TempAllocator
        /// Generated from method `JPH::TempAllocatorImpl::Free`.
        /// Parameter `inAddress` is a mutable pointer.
        public unsafe void Free(void *inAddress, uint inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImpl_Free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImpl_Free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TempAllocatorImpl_Free(_Underlying *_this, void *inAddress, uint inSize);
            __JPH_TempAllocatorImpl_Free(_UnderlyingPtr, inAddress, inSize);
        }
    }

    /// This is used for optional parameters of class `TempAllocatorImpl` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_TempAllocatorImpl`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TempAllocatorImpl`/`Const_TempAllocatorImpl` directly.
    public class _InOptMut_TempAllocatorImpl
    {
        public TempAllocatorImpl? Opt;

        public _InOptMut_TempAllocatorImpl() {}
        public _InOptMut_TempAllocatorImpl(TempAllocatorImpl value) {Opt = value;}
        public static implicit operator _InOptMut_TempAllocatorImpl(TempAllocatorImpl value) {return new(value);}
    }

    /// This is used for optional parameters of class `TempAllocatorImpl` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_TempAllocatorImpl`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TempAllocatorImpl`/`Const_TempAllocatorImpl` to pass it to the function.
    public class _InOptConst_TempAllocatorImpl
    {
        public Const_TempAllocatorImpl? Opt;

        public _InOptConst_TempAllocatorImpl() {}
        public _InOptConst_TempAllocatorImpl(Const_TempAllocatorImpl value) {Opt = value;}
        public static implicit operator _InOptConst_TempAllocatorImpl(Const_TempAllocatorImpl value) {return new(value);}
    }

    /// Implementation of the TempAllocator that just falls back to malloc/free
    /// Note: This can be quite slow when running in the debugger as large memory blocks need to be initialized with 0xcd
    /// Generated from class `JPH::TempAllocatorMalloc`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TempAllocator`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_TempAllocatorMalloc : JPH.Object<Const_TempAllocatorMalloc>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorMalloc_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorMalloc_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TempAllocatorMalloc_Destroy(_Underlying *_this);
            __JPH_TempAllocatorMalloc_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_TempAllocatorMalloc() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_TempAllocatorMalloc self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorMalloc_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorMalloc_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_TempAllocatorMalloc_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_TempAllocatorMalloc_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_TempAllocator(Const_TempAllocatorMalloc self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorMalloc_UpcastTo_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorMalloc_UpcastTo_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_TempAllocator._Underlying *__JPH_TempAllocatorMalloc_UpcastTo_JPH_TempAllocator(_Underlying *_this);
            JPH.Const_TempAllocator ret = new(__JPH_TempAllocatorMalloc_UpcastTo_JPH_TempAllocator(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_TempAllocatorMalloc(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_TempAllocatorMalloc ret = new(__JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TempAllocatorMalloc(JPH.Const_TempAllocator parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_TempAllocator(JPH.Const_TempAllocator._Underlying *_this);
            Const_TempAllocatorMalloc ret = new(__JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_TempAllocator(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// If this allocator needs to fall back to aligned allocations because JPH_RVECTOR_ALIGNMENT is bigger than the platform default
        public static unsafe bool NeedsAlignedAllocate
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorMalloc_Get_needs_aligned_allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorMalloc_Get_needs_aligned_allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_TempAllocatorMalloc_Get_needs_aligned_allocate();
                return *__JPH_TempAllocatorMalloc_Get_needs_aligned_allocate();
            }
        }

        internal unsafe Const_TempAllocatorMalloc(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_TempAllocatorMalloc() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorMalloc_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorMalloc_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TempAllocatorMalloc._Underlying *__JPH_TempAllocatorMalloc_DefaultConstruct();
            _UnderlyingPtr = __JPH_TempAllocatorMalloc_DefaultConstruct();
        }

        /// Generated from method `JPH::TempAllocatorMalloc::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TempAllocatorMalloc_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TempAllocatorMalloc_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TempAllocatorMalloc_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_TempAllocatorMalloc_size_t(inCount);
        }

        /// Generated from method `JPH::TempAllocatorMalloc::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorMalloc_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorMalloc_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TempAllocatorMalloc_void_ptr(void *inPointer);
            __Jolt_delete_JPH_TempAllocatorMalloc_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TempAllocatorMalloc::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorMalloc_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorMalloc_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TempAllocatorMalloc_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_TempAllocatorMalloc_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TempAllocatorMalloc::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocatorMalloc_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocatorMalloc_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TempAllocatorMalloc_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_TempAllocatorMalloc_size_t(inCount);
        }

        /// Generated from method `JPH::TempAllocatorMalloc::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TempAllocatorMalloc::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TempAllocatorMalloc::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TempAllocatorMalloc_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TempAllocatorMalloc_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TempAllocatorMalloc_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_TempAllocatorMalloc_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TempAllocatorMalloc::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorMalloc_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorMalloc_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TempAllocatorMalloc_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_TempAllocatorMalloc_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::TempAllocatorMalloc::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocatorMalloc_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocatorMalloc_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TempAllocatorMalloc_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_TempAllocatorMalloc_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TempAllocatorMalloc::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_TempAllocatorMalloc_void_ptr_void_ptr(inPointer, inPlace);
        }
    }

    /// Implementation of the TempAllocator that just falls back to malloc/free
    /// Note: This can be quite slow when running in the debugger as large memory blocks need to be initialized with 0xcd
    /// Generated from class `JPH::TempAllocatorMalloc`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TempAllocator`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class TempAllocatorMalloc : Const_TempAllocatorMalloc
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(TempAllocatorMalloc self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorMalloc_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorMalloc_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_TempAllocatorMalloc_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_TempAllocatorMalloc_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(TempAllocatorMalloc self)
            => (JPH.Const_NonCopyable)(JPH.Const_TempAllocatorMalloc)self;
        public static unsafe implicit operator JPH.TempAllocator(TempAllocatorMalloc self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorMalloc_UpcastTo_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorMalloc_UpcastTo_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TempAllocator._Underlying *__JPH_TempAllocatorMalloc_UpcastTo_JPH_TempAllocator(_Underlying *_this);
            JPH.TempAllocator ret = new(__JPH_TempAllocatorMalloc_UpcastTo_JPH_TempAllocator(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_TempAllocator(TempAllocatorMalloc self)
            => (JPH.Const_TempAllocator)(JPH.Const_TempAllocatorMalloc)self;

        // Downcasts:
        public static unsafe explicit operator TempAllocatorMalloc(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            TempAllocatorMalloc ret = new(__JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TempAllocatorMalloc(JPH.TempAllocator parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_TempAllocator(JPH.TempAllocator._Underlying *_this);
            TempAllocatorMalloc ret = new(__JPH_TempAllocatorMalloc_StaticDowncastFrom_JPH_TempAllocator(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe TempAllocatorMalloc(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe TempAllocatorMalloc() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorMalloc_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorMalloc_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TempAllocatorMalloc._Underlying *__JPH_TempAllocatorMalloc_DefaultConstruct();
            _UnderlyingPtr = __JPH_TempAllocatorMalloc_DefaultConstruct();
        }

        // See: TempAllocator
        /// Generated from method `JPH::TempAllocatorMalloc::Allocate`.
        /// Returns a mutable pointer.
        public unsafe void *Allocate(uint inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorMalloc_Allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorMalloc_Allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TempAllocatorMalloc_Allocate(_Underlying *_this, uint inSize);
            return __JPH_TempAllocatorMalloc_Allocate(_UnderlyingPtr, inSize);
        }

        // See: TempAllocator
        /// Generated from method `JPH::TempAllocatorMalloc::Free`.
        /// Parameter `inAddress` is a mutable pointer.
        public unsafe void Free(void *inAddress, uint inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorMalloc_Free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorMalloc_Free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TempAllocatorMalloc_Free(_Underlying *_this, void *inAddress, uint inSize);
            __JPH_TempAllocatorMalloc_Free(_UnderlyingPtr, inAddress, inSize);
        }
    }

    /// This is used as a function parameter when the underlying function receives `TempAllocatorMalloc` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_TempAllocatorMalloc
    {
        #pragma warning disable CS0649
        internal readonly Const_TempAllocatorMalloc? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_TempAllocatorMalloc() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `TempAllocatorMalloc` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_TempAllocatorMalloc`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TempAllocatorMalloc`/`Const_TempAllocatorMalloc` directly.
    public class _InOptMut_TempAllocatorMalloc
    {
        public TempAllocatorMalloc? Opt;

        public _InOptMut_TempAllocatorMalloc() {}
        public _InOptMut_TempAllocatorMalloc(TempAllocatorMalloc value) {Opt = value;}
        public static implicit operator _InOptMut_TempAllocatorMalloc(TempAllocatorMalloc value) {return new(value);}
    }

    /// This is used for optional parameters of class `TempAllocatorMalloc` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_TempAllocatorMalloc`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TempAllocatorMalloc`/`Const_TempAllocatorMalloc` to pass it to the function.
    public class _InOptConst_TempAllocatorMalloc
    {
        public Const_TempAllocatorMalloc? Opt;

        public _InOptConst_TempAllocatorMalloc() {}
        public _InOptConst_TempAllocatorMalloc(Const_TempAllocatorMalloc value) {Opt = value;}
        public static implicit operator _InOptConst_TempAllocatorMalloc(Const_TempAllocatorMalloc value) {return new(value);}
    }

    /// Implementation of the TempAllocator that tries to allocate from a large preallocated block, but falls back to malloc when it is exhausted
    /// Generated from class `JPH::TempAllocatorImplWithMallocFallback`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TempAllocator`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_TempAllocatorImplWithMallocFallback : JPH.Object<Const_TempAllocatorImplWithMallocFallback>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TempAllocatorImplWithMallocFallback_Destroy(_Underlying *_this);
            __JPH_TempAllocatorImplWithMallocFallback_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_TempAllocatorImplWithMallocFallback() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_TempAllocatorImplWithMallocFallback self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_TempAllocator(Const_TempAllocatorImplWithMallocFallback self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_TempAllocator._Underlying *__JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_TempAllocator(_Underlying *_this);
            JPH.Const_TempAllocator ret = new(__JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_TempAllocator(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_TempAllocatorImplWithMallocFallback(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_TempAllocatorImplWithMallocFallback ret = new(__JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_TempAllocatorImplWithMallocFallback(JPH.Const_TempAllocator parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_TempAllocator(JPH.Const_TempAllocator._Underlying *_this);
            Const_TempAllocatorImplWithMallocFallback ret = new(__JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_TempAllocator(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// If this allocator needs to fall back to aligned allocations because JPH_RVECTOR_ALIGNMENT is bigger than the platform default
        public static unsafe bool NeedsAlignedAllocate
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_Get_needs_aligned_allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_Get_needs_aligned_allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_TempAllocatorImplWithMallocFallback_Get_needs_aligned_allocate();
                return *__JPH_TempAllocatorImplWithMallocFallback_Get_needs_aligned_allocate();
            }
        }

        internal unsafe Const_TempAllocatorImplWithMallocFallback(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs the allocator with an initial fixed block if inSize
        /// Generated from constructor `JPH::TempAllocatorImplWithMallocFallback::TempAllocatorImplWithMallocFallback`.
        public unsafe Const_TempAllocatorImplWithMallocFallback(uint inSize) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TempAllocatorImplWithMallocFallback._Underlying *__JPH_TempAllocatorImplWithMallocFallback_Construct(uint inSize);
            _UnderlyingPtr = __JPH_TempAllocatorImplWithMallocFallback_Construct(inSize);
        }

        /// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TempAllocatorImplWithMallocFallback_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TempAllocatorImplWithMallocFallback_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TempAllocatorImplWithMallocFallback_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_TempAllocatorImplWithMallocFallback_size_t(inCount);
        }

        /// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr(void *inPointer);
            __Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocatorImplWithMallocFallback_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocatorImplWithMallocFallback_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TempAllocatorImplWithMallocFallback_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_TempAllocatorImplWithMallocFallback_size_t(inCount);
        }

        /// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TempAllocatorImplWithMallocFallback_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TempAllocatorImplWithMallocFallback_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TempAllocatorImplWithMallocFallback_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_TempAllocatorImplWithMallocFallback_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_TempAllocatorImplWithMallocFallback_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocatorImplWithMallocFallback_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TempAllocatorImplWithMallocFallback_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TempAllocatorImplWithMallocFallback_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_TempAllocatorImplWithMallocFallback_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TempAllocatorImplWithMallocFallback::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_TempAllocatorImplWithMallocFallback_void_ptr_void_ptr(inPointer, inPlace);
        }
    }

    /// Implementation of the TempAllocator that tries to allocate from a large preallocated block, but falls back to malloc when it is exhausted
    /// Generated from class `JPH::TempAllocatorImplWithMallocFallback`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TempAllocator`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class TempAllocatorImplWithMallocFallback : Const_TempAllocatorImplWithMallocFallback
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(TempAllocatorImplWithMallocFallback self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(TempAllocatorImplWithMallocFallback self)
            => (JPH.Const_NonCopyable)(JPH.Const_TempAllocatorImplWithMallocFallback)self;
        public static unsafe implicit operator JPH.TempAllocator(TempAllocatorImplWithMallocFallback self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TempAllocator._Underlying *__JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_TempAllocator(_Underlying *_this);
            JPH.TempAllocator ret = new(__JPH_TempAllocatorImplWithMallocFallback_UpcastTo_JPH_TempAllocator(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_TempAllocator(TempAllocatorImplWithMallocFallback self)
            => (JPH.Const_TempAllocator)(JPH.Const_TempAllocatorImplWithMallocFallback)self;

        // Downcasts:
        public static unsafe explicit operator TempAllocatorImplWithMallocFallback(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            TempAllocatorImplWithMallocFallback ret = new(__JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator TempAllocatorImplWithMallocFallback(JPH.TempAllocator parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_TempAllocator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_TempAllocator(JPH.TempAllocator._Underlying *_this);
            TempAllocatorImplWithMallocFallback ret = new(__JPH_TempAllocatorImplWithMallocFallback_StaticDowncastFrom_JPH_TempAllocator(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe TempAllocatorImplWithMallocFallback(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs the allocator with an initial fixed block if inSize
        /// Generated from constructor `JPH::TempAllocatorImplWithMallocFallback::TempAllocatorImplWithMallocFallback`.
        public unsafe TempAllocatorImplWithMallocFallback(uint inSize) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TempAllocatorImplWithMallocFallback._Underlying *__JPH_TempAllocatorImplWithMallocFallback_Construct(uint inSize);
            _UnderlyingPtr = __JPH_TempAllocatorImplWithMallocFallback_Construct(inSize);
        }

        // See: TempAllocator
        /// Generated from method `JPH::TempAllocatorImplWithMallocFallback::Allocate`.
        /// Returns a mutable pointer.
        public unsafe void *Allocate(uint inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_Allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_Allocate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_TempAllocatorImplWithMallocFallback_Allocate(_Underlying *_this, uint inSize);
            return __JPH_TempAllocatorImplWithMallocFallback_Allocate(_UnderlyingPtr, inSize);
        }

        // See: TempAllocator
        /// Generated from method `JPH::TempAllocatorImplWithMallocFallback::Free`.
        /// Parameter `inAddress` is a mutable pointer.
        public unsafe void Free(void *inAddress, uint inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_Free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TempAllocatorImplWithMallocFallback_Free", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TempAllocatorImplWithMallocFallback_Free(_Underlying *_this, void *inAddress, uint inSize);
            __JPH_TempAllocatorImplWithMallocFallback_Free(_UnderlyingPtr, inAddress, inSize);
        }
    }

    /// This is used for optional parameters of class `TempAllocatorImplWithMallocFallback` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_TempAllocatorImplWithMallocFallback`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TempAllocatorImplWithMallocFallback`/`Const_TempAllocatorImplWithMallocFallback` directly.
    public class _InOptMut_TempAllocatorImplWithMallocFallback
    {
        public TempAllocatorImplWithMallocFallback? Opt;

        public _InOptMut_TempAllocatorImplWithMallocFallback() {}
        public _InOptMut_TempAllocatorImplWithMallocFallback(TempAllocatorImplWithMallocFallback value) {Opt = value;}
        public static implicit operator _InOptMut_TempAllocatorImplWithMallocFallback(TempAllocatorImplWithMallocFallback value) {return new(value);}
    }

    /// This is used for optional parameters of class `TempAllocatorImplWithMallocFallback` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_TempAllocatorImplWithMallocFallback`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TempAllocatorImplWithMallocFallback`/`Const_TempAllocatorImplWithMallocFallback` to pass it to the function.
    public class _InOptConst_TempAllocatorImplWithMallocFallback
    {
        public Const_TempAllocatorImplWithMallocFallback? Opt;

        public _InOptConst_TempAllocatorImplWithMallocFallback() {}
        public _InOptConst_TempAllocatorImplWithMallocFallback(Const_TempAllocatorImplWithMallocFallback value) {Opt = value;}
        public static implicit operator _InOptConst_TempAllocatorImplWithMallocFallback(Const_TempAllocatorImplWithMallocFallback value) {return new(value);}
    }
}
