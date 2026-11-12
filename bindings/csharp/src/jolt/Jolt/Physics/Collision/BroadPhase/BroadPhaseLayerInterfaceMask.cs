// machine generated, do not edit
public static partial class JPH
{
    /// BroadPhaseLayerInterface implementation.
    /// This defines a mapping between object and broadphase layers.
    /// This implementation works together with ObjectLayerPairFilterMask and ObjectVsBroadPhaseLayerFilterMask.
    /// A broadphase layer is suitable for an object if its group & inGroupsToInclude is not zero and its group & inGroupsToExclude is zero.
    /// The broadphase layers are iterated from lowest to highest value and the first one that matches is taken. If none match then it takes the last layer.
    /// Generated from class `JPH::BroadPhaseLayerInterfaceMask`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BroadPhaseLayerInterface`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_BroadPhaseLayerInterfaceMask : JPH.Object<Const_BroadPhaseLayerInterfaceMask>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BroadPhaseLayerInterfaceMask_Destroy(_Underlying *_this);
            __JPH_BroadPhaseLayerInterfaceMask_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BroadPhaseLayerInterfaceMask() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_BroadPhaseLayerInterfaceMask self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_BroadPhaseLayerInterface(Const_BroadPhaseLayerInterfaceMask self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_BroadPhaseLayerInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_BroadPhaseLayerInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BroadPhaseLayerInterface._Underlying *__JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_BroadPhaseLayerInterface(_Underlying *_this);
            JPH.Const_BroadPhaseLayerInterface ret = new(__JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_BroadPhaseLayerInterface(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BroadPhaseLayerInterfaceMask(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_BroadPhaseLayerInterfaceMask ret = new(__JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BroadPhaseLayerInterfaceMask(JPH.Const_BroadPhaseLayerInterface parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_BroadPhaseLayerInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_BroadPhaseLayerInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_BroadPhaseLayerInterface(JPH.Const_BroadPhaseLayerInterface._Underlying *_this);
            Const_BroadPhaseLayerInterfaceMask ret = new(__JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_BroadPhaseLayerInterface(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BroadPhaseLayerInterfaceMask(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JPH::BroadPhaseLayerInterfaceMask::BroadPhaseLayerInterfaceMask`.
        public unsafe Const_BroadPhaseLayerInterfaceMask(uint inNumBroadPhaseLayers) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayerInterfaceMask._Underlying *__JPH_BroadPhaseLayerInterfaceMask_Construct(uint inNumBroadPhaseLayers);
            _UnderlyingPtr = __JPH_BroadPhaseLayerInterfaceMask_Construct(inNumBroadPhaseLayers);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_BroadPhaseLayerInterfaceMask_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_BroadPhaseLayerInterfaceMask_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_BroadPhaseLayerInterfaceMask_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_BroadPhaseLayerInterfaceMask_size_t(inCount);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr(void *inPointer);
            __Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr(inPointer);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_BroadPhaseLayerInterfaceMask_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_BroadPhaseLayerInterfaceMask_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_BroadPhaseLayerInterfaceMask_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_BroadPhaseLayerInterfaceMask_size_t(inCount);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr(inPointer);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_BroadPhaseLayerInterfaceMask_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_BroadPhaseLayerInterfaceMask_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_BroadPhaseLayerInterfaceMask_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_BroadPhaseLayerInterfaceMask_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_BroadPhaseLayerInterfaceMask_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_BroadPhaseLayerInterfaceMask_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_BroadPhaseLayerInterfaceMask_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_BroadPhaseLayerInterfaceMask_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_BroadPhaseLayerInterfaceMask_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceMask::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_BroadPhaseLayerInterfaceMask_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceMask::GetNumBroadPhaseLayers`.
        public unsafe uint GetNumBroadPhaseLayers()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_GetNumBroadPhaseLayers", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_GetNumBroadPhaseLayers", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_BroadPhaseLayerInterfaceMask_GetNumBroadPhaseLayers(_Underlying *_this);
            return __JPH_BroadPhaseLayerInterfaceMask_GetNumBroadPhaseLayers(_UnderlyingPtr);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceMask::GetBroadPhaseLayer`.
        public unsafe JPH.BroadPhaseLayer GetBroadPhaseLayer(ushort inLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_GetBroadPhaseLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_GetBroadPhaseLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayer._Underlying *__JPH_BroadPhaseLayerInterfaceMask_GetBroadPhaseLayer(_Underlying *_this, ushort inLayer);
            return new(__JPH_BroadPhaseLayerInterfaceMask_GetBroadPhaseLayer(_UnderlyingPtr, inLayer), is_owning: true);
        }

        /// Returns true if an object layer should collide with a broadphase layer, this function is being called from ObjectVsBroadPhaseLayerFilterMask
        /// Generated from method `JPH::BroadPhaseLayerInterfaceMask::ShouldCollide`.
        public unsafe bool ShouldCollide(ushort inLayer1, JPH.Const_BroadPhaseLayer inLayer2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_BroadPhaseLayerInterfaceMask_ShouldCollide(_Underlying *_this, ushort inLayer1, JPH.BroadPhaseLayer._Underlying *inLayer2);
            return __JPH_BroadPhaseLayerInterfaceMask_ShouldCollide(_UnderlyingPtr, inLayer1, inLayer2._UnderlyingPtr) != 0;
        }
    }

    /// BroadPhaseLayerInterface implementation.
    /// This defines a mapping between object and broadphase layers.
    /// This implementation works together with ObjectLayerPairFilterMask and ObjectVsBroadPhaseLayerFilterMask.
    /// A broadphase layer is suitable for an object if its group & inGroupsToInclude is not zero and its group & inGroupsToExclude is zero.
    /// The broadphase layers are iterated from lowest to highest value and the first one that matches is taken. If none match then it takes the last layer.
    /// Generated from class `JPH::BroadPhaseLayerInterfaceMask`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BroadPhaseLayerInterface`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class BroadPhaseLayerInterfaceMask : Const_BroadPhaseLayerInterfaceMask
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(BroadPhaseLayerInterfaceMask self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(BroadPhaseLayerInterfaceMask self)
            => (JPH.Const_NonCopyable)(JPH.Const_BroadPhaseLayerInterfaceMask)self;
        public static unsafe implicit operator JPH.BroadPhaseLayerInterface(BroadPhaseLayerInterfaceMask self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_BroadPhaseLayerInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_BroadPhaseLayerInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayerInterface._Underlying *__JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_BroadPhaseLayerInterface(_Underlying *_this);
            JPH.BroadPhaseLayerInterface ret = new(__JPH_BroadPhaseLayerInterfaceMask_UpcastTo_JPH_BroadPhaseLayerInterface(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_BroadPhaseLayerInterface(BroadPhaseLayerInterfaceMask self)
            => (JPH.Const_BroadPhaseLayerInterface)(JPH.Const_BroadPhaseLayerInterfaceMask)self;

        // Downcasts:
        public static unsafe explicit operator BroadPhaseLayerInterfaceMask(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            BroadPhaseLayerInterfaceMask ret = new(__JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BroadPhaseLayerInterfaceMask(JPH.BroadPhaseLayerInterface parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_BroadPhaseLayerInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_BroadPhaseLayerInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_BroadPhaseLayerInterface(JPH.BroadPhaseLayerInterface._Underlying *_this);
            BroadPhaseLayerInterfaceMask ret = new(__JPH_BroadPhaseLayerInterfaceMask_StaticDowncastFrom_JPH_BroadPhaseLayerInterface(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BroadPhaseLayerInterfaceMask(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JPH::BroadPhaseLayerInterfaceMask::BroadPhaseLayerInterfaceMask`.
        public unsafe BroadPhaseLayerInterfaceMask(uint inNumBroadPhaseLayers) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayerInterfaceMask._Underlying *__JPH_BroadPhaseLayerInterfaceMask_Construct(uint inNumBroadPhaseLayers);
            _UnderlyingPtr = __JPH_BroadPhaseLayerInterfaceMask_Construct(inNumBroadPhaseLayers);
        }

        // Configures a broadphase layer.
        /// Generated from method `JPH::BroadPhaseLayerInterfaceMask::ConfigureLayer`.
        public unsafe void ConfigureLayer(JPH.Const_BroadPhaseLayer inBroadPhaseLayer, uint inGroupsToInclude, uint inGroupsToExclude)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_ConfigureLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceMask_ConfigureLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BroadPhaseLayerInterfaceMask_ConfigureLayer(_Underlying *_this, JPH.BroadPhaseLayer._Underlying *inBroadPhaseLayer, uint inGroupsToInclude, uint inGroupsToExclude);
            __JPH_BroadPhaseLayerInterfaceMask_ConfigureLayer(_UnderlyingPtr, inBroadPhaseLayer._UnderlyingPtr, inGroupsToInclude, inGroupsToExclude);
        }
    }

    /// This is used for optional parameters of class `BroadPhaseLayerInterfaceMask` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BroadPhaseLayerInterfaceMask`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BroadPhaseLayerInterfaceMask`/`Const_BroadPhaseLayerInterfaceMask` directly.
    public class _InOptMut_BroadPhaseLayerInterfaceMask
    {
        public BroadPhaseLayerInterfaceMask? Opt;

        public _InOptMut_BroadPhaseLayerInterfaceMask() {}
        public _InOptMut_BroadPhaseLayerInterfaceMask(BroadPhaseLayerInterfaceMask value) {Opt = value;}
        public static implicit operator _InOptMut_BroadPhaseLayerInterfaceMask(BroadPhaseLayerInterfaceMask value) {return new(value);}
    }

    /// This is used for optional parameters of class `BroadPhaseLayerInterfaceMask` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BroadPhaseLayerInterfaceMask`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BroadPhaseLayerInterfaceMask`/`Const_BroadPhaseLayerInterfaceMask` to pass it to the function.
    public class _InOptConst_BroadPhaseLayerInterfaceMask
    {
        public Const_BroadPhaseLayerInterfaceMask? Opt;

        public _InOptConst_BroadPhaseLayerInterfaceMask() {}
        public _InOptConst_BroadPhaseLayerInterfaceMask(Const_BroadPhaseLayerInterfaceMask value) {Opt = value;}
        public static implicit operator _InOptConst_BroadPhaseLayerInterfaceMask(Const_BroadPhaseLayerInterfaceMask value) {return new(value);}
    }
}
