// machine generated, do not edit
public static partial class JPH
{
    /// BroadPhaseLayerInterface implementation.
    /// This defines a mapping between object and broadphase layers.
    /// This implementation uses a simple table
    /// Generated from class `JPH::BroadPhaseLayerInterfaceTable`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BroadPhaseLayerInterface`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_BroadPhaseLayerInterfaceTable : JPH.Object<Const_BroadPhaseLayerInterfaceTable>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BroadPhaseLayerInterfaceTable_Destroy(_Underlying *_this);
            __JPH_BroadPhaseLayerInterfaceTable_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BroadPhaseLayerInterfaceTable() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_BroadPhaseLayerInterfaceTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_BroadPhaseLayerInterface(Const_BroadPhaseLayerInterfaceTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_BroadPhaseLayerInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_BroadPhaseLayerInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BroadPhaseLayerInterface._Underlying *__JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_BroadPhaseLayerInterface(_Underlying *_this);
            JPH.Const_BroadPhaseLayerInterface ret = new(__JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_BroadPhaseLayerInterface(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe Const_BroadPhaseLayerInterfaceTable(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JPH::BroadPhaseLayerInterfaceTable::BroadPhaseLayerInterfaceTable`.
        public unsafe Const_BroadPhaseLayerInterfaceTable(uint inNumObjectLayers, uint inNumBroadPhaseLayers) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayerInterfaceTable._Underlying *__JPH_BroadPhaseLayerInterfaceTable_Construct(uint inNumObjectLayers, uint inNumBroadPhaseLayers);
            _UnderlyingPtr = __JPH_BroadPhaseLayerInterfaceTable_Construct(inNumObjectLayers, inNumBroadPhaseLayers);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_BroadPhaseLayerInterfaceTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_BroadPhaseLayerInterfaceTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_BroadPhaseLayerInterfaceTable_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_BroadPhaseLayerInterfaceTable_size_t(inCount);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr(void *inPointer);
            __Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr(inPointer);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_BroadPhaseLayerInterfaceTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_BroadPhaseLayerInterfaceTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_BroadPhaseLayerInterfaceTable_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_BroadPhaseLayerInterfaceTable_size_t(inCount);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr(inPointer);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_BroadPhaseLayerInterfaceTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_BroadPhaseLayerInterfaceTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_BroadPhaseLayerInterfaceTable_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_BroadPhaseLayerInterfaceTable_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_BroadPhaseLayerInterfaceTable_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_BroadPhaseLayerInterfaceTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_BroadPhaseLayerInterfaceTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_BroadPhaseLayerInterfaceTable_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_BroadPhaseLayerInterfaceTable_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceTable::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_BroadPhaseLayerInterfaceTable_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceTable::GetNumBroadPhaseLayers`.
        public unsafe uint GetNumBroadPhaseLayers()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_GetNumBroadPhaseLayers", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_GetNumBroadPhaseLayers", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_BroadPhaseLayerInterfaceTable_GetNumBroadPhaseLayers(_Underlying *_this);
            return __JPH_BroadPhaseLayerInterfaceTable_GetNumBroadPhaseLayers(_UnderlyingPtr);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceTable::GetBroadPhaseLayer`.
        public unsafe JPH.BroadPhaseLayer GetBroadPhaseLayer(ushort inLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_GetBroadPhaseLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_GetBroadPhaseLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayer._Underlying *__JPH_BroadPhaseLayerInterfaceTable_GetBroadPhaseLayer(_Underlying *_this, ushort inLayer);
            return new(__JPH_BroadPhaseLayerInterfaceTable_GetBroadPhaseLayer(_UnderlyingPtr, inLayer), is_owning: true);
        }
    }

    /// BroadPhaseLayerInterface implementation.
    /// This defines a mapping between object and broadphase layers.
    /// This implementation uses a simple table
    /// Generated from class `JPH::BroadPhaseLayerInterfaceTable`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::BroadPhaseLayerInterface`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class BroadPhaseLayerInterfaceTable : Const_BroadPhaseLayerInterfaceTable
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(BroadPhaseLayerInterfaceTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.BroadPhaseLayerInterface(BroadPhaseLayerInterfaceTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_BroadPhaseLayerInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_BroadPhaseLayerInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayerInterface._Underlying *__JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_BroadPhaseLayerInterface(_Underlying *_this);
            JPH.BroadPhaseLayerInterface ret = new(__JPH_BroadPhaseLayerInterfaceTable_UpcastTo_JPH_BroadPhaseLayerInterface(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe BroadPhaseLayerInterfaceTable(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JPH::BroadPhaseLayerInterfaceTable::BroadPhaseLayerInterfaceTable`.
        public unsafe BroadPhaseLayerInterfaceTable(uint inNumObjectLayers, uint inNumBroadPhaseLayers) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BroadPhaseLayerInterfaceTable._Underlying *__JPH_BroadPhaseLayerInterfaceTable_Construct(uint inNumObjectLayers, uint inNumBroadPhaseLayers);
            _UnderlyingPtr = __JPH_BroadPhaseLayerInterfaceTable_Construct(inNumObjectLayers, inNumBroadPhaseLayers);
        }

        /// Generated from method `JPH::BroadPhaseLayerInterfaceTable::MapObjectToBroadPhaseLayer`.
        public unsafe void MapObjectToBroadPhaseLayer(ushort inObjectLayer, JPH.Const_BroadPhaseLayer inBroadPhaseLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_MapObjectToBroadPhaseLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BroadPhaseLayerInterfaceTable_MapObjectToBroadPhaseLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BroadPhaseLayerInterfaceTable_MapObjectToBroadPhaseLayer(_Underlying *_this, ushort inObjectLayer, JPH.BroadPhaseLayer._Underlying *inBroadPhaseLayer);
            __JPH_BroadPhaseLayerInterfaceTable_MapObjectToBroadPhaseLayer(_UnderlyingPtr, inObjectLayer, inBroadPhaseLayer._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `BroadPhaseLayerInterfaceTable` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BroadPhaseLayerInterfaceTable`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BroadPhaseLayerInterfaceTable`/`Const_BroadPhaseLayerInterfaceTable` directly.
    public class _InOptMut_BroadPhaseLayerInterfaceTable
    {
        public BroadPhaseLayerInterfaceTable? Opt;

        public _InOptMut_BroadPhaseLayerInterfaceTable() {}
        public _InOptMut_BroadPhaseLayerInterfaceTable(BroadPhaseLayerInterfaceTable value) {Opt = value;}
        public static implicit operator _InOptMut_BroadPhaseLayerInterfaceTable(BroadPhaseLayerInterfaceTable value) {return new(value);}
    }

    /// This is used for optional parameters of class `BroadPhaseLayerInterfaceTable` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BroadPhaseLayerInterfaceTable`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BroadPhaseLayerInterfaceTable`/`Const_BroadPhaseLayerInterfaceTable` to pass it to the function.
    public class _InOptConst_BroadPhaseLayerInterfaceTable
    {
        public Const_BroadPhaseLayerInterfaceTable? Opt;

        public _InOptConst_BroadPhaseLayerInterfaceTable() {}
        public _InOptConst_BroadPhaseLayerInterfaceTable(Const_BroadPhaseLayerInterfaceTable value) {Opt = value;}
        public static implicit operator _InOptConst_BroadPhaseLayerInterfaceTable(Const_BroadPhaseLayerInterfaceTable value) {return new(value);}
    }
}
