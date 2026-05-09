// machine generated, do not edit
public static partial class JPH
{
    /// Class that determines if an object layer can collide with a broadphase layer.
    /// This implementation works together with BroadPhaseLayerInterfaceMask and ObjectLayerPairFilterMask
    /// Generated from class `JPH::ObjectVsBroadPhaseLayerFilterMask`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectVsBroadPhaseLayerFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_ObjectVsBroadPhaseLayerFilterMask : JPH.Object<Const_ObjectVsBroadPhaseLayerFilterMask>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ObjectVsBroadPhaseLayerFilterMask_Destroy(_Underlying *_this);
            __JPH_ObjectVsBroadPhaseLayerFilterMask_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ObjectVsBroadPhaseLayerFilterMask() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_ObjectVsBroadPhaseLayerFilterMask self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ObjectVsBroadPhaseLayerFilter(Const_ObjectVsBroadPhaseLayerFilterMask self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ObjectVsBroadPhaseLayerFilter._Underlying *__JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(_Underlying *_this);
            JPH.Const_ObjectVsBroadPhaseLayerFilter ret = new(__JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_ObjectVsBroadPhaseLayerFilterMask(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_ObjectVsBroadPhaseLayerFilterMask ret = new(__JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_ObjectVsBroadPhaseLayerFilterMask(JPH.Const_ObjectVsBroadPhaseLayerFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(JPH.Const_ObjectVsBroadPhaseLayerFilter._Underlying *_this);
            Const_ObjectVsBroadPhaseLayerFilterMask ret = new(__JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_ObjectVsBroadPhaseLayerFilterMask(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// Generated from constructor `JPH::ObjectVsBroadPhaseLayerFilterMask::ObjectVsBroadPhaseLayerFilterMask`.
        public unsafe Const_ObjectVsBroadPhaseLayerFilterMask(JPH.Const_BroadPhaseLayerInterfaceMask inBroadPhaseLayerInterface) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectVsBroadPhaseLayerFilterMask._Underlying *__JPH_ObjectVsBroadPhaseLayerFilterMask_Construct(JPH.Const_BroadPhaseLayerInterfaceMask._Underlying *inBroadPhaseLayerInterface);
            _UnderlyingPtr = __JPH_ObjectVsBroadPhaseLayerFilterMask_Construct(inBroadPhaseLayerInterface._UnderlyingPtr);
        }

        /// Constructor
        /// Generated from constructor `JPH::ObjectVsBroadPhaseLayerFilterMask::ObjectVsBroadPhaseLayerFilterMask`.
        public static unsafe implicit operator Const_ObjectVsBroadPhaseLayerFilterMask(JPH.Const_BroadPhaseLayerInterfaceMask inBroadPhaseLayerInterface) {return new(inBroadPhaseLayerInterface);}

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t(inCount);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr(void *inPointer);
            __Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t(inCount);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterMask_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterMask_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Returns true if an object layer should collide with a broadphase layer
        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterMask::ShouldCollide`.
        public unsafe bool ShouldCollide(ushort inLayer1, JPH.Const_BroadPhaseLayer inLayer2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_ObjectVsBroadPhaseLayerFilterMask_ShouldCollide(_Underlying *_this, ushort inLayer1, JPH.BroadPhaseLayer._Underlying *inLayer2);
            return __JPH_ObjectVsBroadPhaseLayerFilterMask_ShouldCollide(_UnderlyingPtr, inLayer1, inLayer2._UnderlyingPtr) != 0;
        }
    }

    /// Class that determines if an object layer can collide with a broadphase layer.
    /// This implementation works together with BroadPhaseLayerInterfaceMask and ObjectLayerPairFilterMask
    /// Generated from class `JPH::ObjectVsBroadPhaseLayerFilterMask`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectVsBroadPhaseLayerFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class ObjectVsBroadPhaseLayerFilterMask : Const_ObjectVsBroadPhaseLayerFilterMask
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(ObjectVsBroadPhaseLayerFilterMask self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(ObjectVsBroadPhaseLayerFilterMask self)
            => (JPH.Const_NonCopyable)(JPH.Const_ObjectVsBroadPhaseLayerFilterMask)self;
        public static unsafe implicit operator JPH.ObjectVsBroadPhaseLayerFilter(ObjectVsBroadPhaseLayerFilterMask self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectVsBroadPhaseLayerFilter._Underlying *__JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(_Underlying *_this);
            JPH.ObjectVsBroadPhaseLayerFilter ret = new(__JPH_ObjectVsBroadPhaseLayerFilterMask_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ObjectVsBroadPhaseLayerFilter(ObjectVsBroadPhaseLayerFilterMask self)
            => (JPH.Const_ObjectVsBroadPhaseLayerFilter)(JPH.Const_ObjectVsBroadPhaseLayerFilterMask)self;

        // Downcasts:
        public static unsafe explicit operator ObjectVsBroadPhaseLayerFilterMask(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            ObjectVsBroadPhaseLayerFilterMask ret = new(__JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator ObjectVsBroadPhaseLayerFilterMask(JPH.ObjectVsBroadPhaseLayerFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(JPH.ObjectVsBroadPhaseLayerFilter._Underlying *_this);
            ObjectVsBroadPhaseLayerFilterMask ret = new(__JPH_ObjectVsBroadPhaseLayerFilterMask_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe ObjectVsBroadPhaseLayerFilterMask(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// Generated from constructor `JPH::ObjectVsBroadPhaseLayerFilterMask::ObjectVsBroadPhaseLayerFilterMask`.
        public unsafe ObjectVsBroadPhaseLayerFilterMask(JPH.Const_BroadPhaseLayerInterfaceMask inBroadPhaseLayerInterface) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterMask_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectVsBroadPhaseLayerFilterMask._Underlying *__JPH_ObjectVsBroadPhaseLayerFilterMask_Construct(JPH.Const_BroadPhaseLayerInterfaceMask._Underlying *inBroadPhaseLayerInterface);
            _UnderlyingPtr = __JPH_ObjectVsBroadPhaseLayerFilterMask_Construct(inBroadPhaseLayerInterface._UnderlyingPtr);
        }

        /// Constructor
        /// Generated from constructor `JPH::ObjectVsBroadPhaseLayerFilterMask::ObjectVsBroadPhaseLayerFilterMask`.
        public static unsafe implicit operator ObjectVsBroadPhaseLayerFilterMask(JPH.Const_BroadPhaseLayerInterfaceMask inBroadPhaseLayerInterface) {return new(inBroadPhaseLayerInterface);}
    }

    /// This is used for optional parameters of class `ObjectVsBroadPhaseLayerFilterMask` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ObjectVsBroadPhaseLayerFilterMask`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ObjectVsBroadPhaseLayerFilterMask`/`Const_ObjectVsBroadPhaseLayerFilterMask` directly.
    public class _InOptMut_ObjectVsBroadPhaseLayerFilterMask
    {
        public ObjectVsBroadPhaseLayerFilterMask? Opt;

        public _InOptMut_ObjectVsBroadPhaseLayerFilterMask() {}
        public _InOptMut_ObjectVsBroadPhaseLayerFilterMask(ObjectVsBroadPhaseLayerFilterMask value) {Opt = value;}
        public static implicit operator _InOptMut_ObjectVsBroadPhaseLayerFilterMask(ObjectVsBroadPhaseLayerFilterMask value) {return new(value);}
    }

    /// This is used for optional parameters of class `ObjectVsBroadPhaseLayerFilterMask` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ObjectVsBroadPhaseLayerFilterMask`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ObjectVsBroadPhaseLayerFilterMask`/`Const_ObjectVsBroadPhaseLayerFilterMask` to pass it to the function.
    public class _InOptConst_ObjectVsBroadPhaseLayerFilterMask
    {
        public Const_ObjectVsBroadPhaseLayerFilterMask? Opt;

        public _InOptConst_ObjectVsBroadPhaseLayerFilterMask() {}
        public _InOptConst_ObjectVsBroadPhaseLayerFilterMask(Const_ObjectVsBroadPhaseLayerFilterMask value) {Opt = value;}
        public static implicit operator _InOptConst_ObjectVsBroadPhaseLayerFilterMask(Const_ObjectVsBroadPhaseLayerFilterMask value) {return new(value);}

        /// Constructor
        /// Generated from constructor `JPH::ObjectVsBroadPhaseLayerFilterMask::ObjectVsBroadPhaseLayerFilterMask`.
        public static unsafe implicit operator _InOptConst_ObjectVsBroadPhaseLayerFilterMask(JPH.Const_BroadPhaseLayerInterfaceMask inBroadPhaseLayerInterface) {return new Const_ObjectVsBroadPhaseLayerFilterMask(inBroadPhaseLayerInterface);}
    }
}
