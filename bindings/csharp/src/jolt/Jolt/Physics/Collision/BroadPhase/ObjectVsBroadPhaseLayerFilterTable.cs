// machine generated, do not edit
public static partial class JPH
{
    /// Class that determines if an object layer can collide with a broadphase layer.
    /// This implementation uses a table and constructs itself from an ObjectLayerPairFilter and a BroadPhaseLayerInterface.
    /// Generated from class `JPH::ObjectVsBroadPhaseLayerFilterTable`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectVsBroadPhaseLayerFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_ObjectVsBroadPhaseLayerFilterTable : JPH.Object<Const_ObjectVsBroadPhaseLayerFilterTable>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ObjectVsBroadPhaseLayerFilterTable_Destroy(_Underlying *_this);
            __JPH_ObjectVsBroadPhaseLayerFilterTable_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ObjectVsBroadPhaseLayerFilterTable() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_ObjectVsBroadPhaseLayerFilterTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ObjectVsBroadPhaseLayerFilter(Const_ObjectVsBroadPhaseLayerFilterTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ObjectVsBroadPhaseLayerFilter._Underlying *__JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(_Underlying *_this);
            JPH.Const_ObjectVsBroadPhaseLayerFilter ret = new(__JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_ObjectVsBroadPhaseLayerFilterTable(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_ObjectVsBroadPhaseLayerFilterTable ret = new(__JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_ObjectVsBroadPhaseLayerFilterTable(JPH.Const_ObjectVsBroadPhaseLayerFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(JPH.Const_ObjectVsBroadPhaseLayerFilter._Underlying *_this);
            Const_ObjectVsBroadPhaseLayerFilterTable ret = new(__JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_ObjectVsBroadPhaseLayerFilterTable(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Construct the table
        /// @param inBroadPhaseLayerInterface The broad phase layer interface that maps object layers to broad phase layers
        /// @param inNumBroadPhaseLayers Number of broad phase layers
        /// @param inObjectLayerPairFilter The object layer pair filter that determines which object layers can collide
        /// @param inNumObjectLayers Number of object layers
        /// Generated from constructor `JPH::ObjectVsBroadPhaseLayerFilterTable::ObjectVsBroadPhaseLayerFilterTable`.
        public unsafe Const_ObjectVsBroadPhaseLayerFilterTable(JPH.Const_BroadPhaseLayerInterface inBroadPhaseLayerInterface, uint inNumBroadPhaseLayers, JPH.Const_ObjectLayerPairFilter inObjectLayerPairFilter, uint inNumObjectLayers) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectVsBroadPhaseLayerFilterTable._Underlying *__JPH_ObjectVsBroadPhaseLayerFilterTable_Construct(JPH.Const_BroadPhaseLayerInterface._Underlying *inBroadPhaseLayerInterface, uint inNumBroadPhaseLayers, JPH.Const_ObjectLayerPairFilter._Underlying *inObjectLayerPairFilter, uint inNumObjectLayers);
            _UnderlyingPtr = __JPH_ObjectVsBroadPhaseLayerFilterTable_Construct(inBroadPhaseLayerInterface._UnderlyingPtr, inNumBroadPhaseLayers, inObjectLayerPairFilter._UnderlyingPtr, inNumObjectLayers);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t(inCount);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr(void *inPointer);
            __Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t(inCount);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_ObjectVsBroadPhaseLayerFilterTable_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_ObjectVsBroadPhaseLayerFilterTable_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Returns true if an object layer should collide with a broadphase layer
        /// Generated from method `JPH::ObjectVsBroadPhaseLayerFilterTable::ShouldCollide`.
        public unsafe bool ShouldCollide(ushort inLayer1, JPH.Const_BroadPhaseLayer inLayer2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_ObjectVsBroadPhaseLayerFilterTable_ShouldCollide(_Underlying *_this, ushort inLayer1, JPH.BroadPhaseLayer._Underlying *inLayer2);
            return __JPH_ObjectVsBroadPhaseLayerFilterTable_ShouldCollide(_UnderlyingPtr, inLayer1, inLayer2._UnderlyingPtr) != 0;
        }
    }

    /// Class that determines if an object layer can collide with a broadphase layer.
    /// This implementation uses a table and constructs itself from an ObjectLayerPairFilter and a BroadPhaseLayerInterface.
    /// Generated from class `JPH::ObjectVsBroadPhaseLayerFilterTable`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectVsBroadPhaseLayerFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class ObjectVsBroadPhaseLayerFilterTable : Const_ObjectVsBroadPhaseLayerFilterTable
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(ObjectVsBroadPhaseLayerFilterTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ObjectVsBroadPhaseLayerFilter(ObjectVsBroadPhaseLayerFilterTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectVsBroadPhaseLayerFilter._Underlying *__JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(_Underlying *_this);
            JPH.ObjectVsBroadPhaseLayerFilter ret = new(__JPH_ObjectVsBroadPhaseLayerFilterTable_UpcastTo_JPH_ObjectVsBroadPhaseLayerFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator ObjectVsBroadPhaseLayerFilterTable(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            ObjectVsBroadPhaseLayerFilterTable ret = new(__JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator ObjectVsBroadPhaseLayerFilterTable(JPH.ObjectVsBroadPhaseLayerFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(JPH.ObjectVsBroadPhaseLayerFilter._Underlying *_this);
            ObjectVsBroadPhaseLayerFilterTable ret = new(__JPH_ObjectVsBroadPhaseLayerFilterTable_StaticDowncastFrom_JPH_ObjectVsBroadPhaseLayerFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe ObjectVsBroadPhaseLayerFilterTable(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Construct the table
        /// @param inBroadPhaseLayerInterface The broad phase layer interface that maps object layers to broad phase layers
        /// @param inNumBroadPhaseLayers Number of broad phase layers
        /// @param inObjectLayerPairFilter The object layer pair filter that determines which object layers can collide
        /// @param inNumObjectLayers Number of object layers
        /// Generated from constructor `JPH::ObjectVsBroadPhaseLayerFilterTable::ObjectVsBroadPhaseLayerFilterTable`.
        public unsafe ObjectVsBroadPhaseLayerFilterTable(JPH.Const_BroadPhaseLayerInterface inBroadPhaseLayerInterface, uint inNumBroadPhaseLayers, JPH.Const_ObjectLayerPairFilter inObjectLayerPairFilter, uint inNumObjectLayers) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectVsBroadPhaseLayerFilterTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectVsBroadPhaseLayerFilterTable._Underlying *__JPH_ObjectVsBroadPhaseLayerFilterTable_Construct(JPH.Const_BroadPhaseLayerInterface._Underlying *inBroadPhaseLayerInterface, uint inNumBroadPhaseLayers, JPH.Const_ObjectLayerPairFilter._Underlying *inObjectLayerPairFilter, uint inNumObjectLayers);
            _UnderlyingPtr = __JPH_ObjectVsBroadPhaseLayerFilterTable_Construct(inBroadPhaseLayerInterface._UnderlyingPtr, inNumBroadPhaseLayers, inObjectLayerPairFilter._UnderlyingPtr, inNumObjectLayers);
        }
    }

    /// This is used for optional parameters of class `ObjectVsBroadPhaseLayerFilterTable` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ObjectVsBroadPhaseLayerFilterTable`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ObjectVsBroadPhaseLayerFilterTable`/`Const_ObjectVsBroadPhaseLayerFilterTable` directly.
    public class _InOptMut_ObjectVsBroadPhaseLayerFilterTable
    {
        public ObjectVsBroadPhaseLayerFilterTable? Opt;

        public _InOptMut_ObjectVsBroadPhaseLayerFilterTable() {}
        public _InOptMut_ObjectVsBroadPhaseLayerFilterTable(ObjectVsBroadPhaseLayerFilterTable value) {Opt = value;}
        public static implicit operator _InOptMut_ObjectVsBroadPhaseLayerFilterTable(ObjectVsBroadPhaseLayerFilterTable value) {return new(value);}
    }

    /// This is used for optional parameters of class `ObjectVsBroadPhaseLayerFilterTable` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ObjectVsBroadPhaseLayerFilterTable`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ObjectVsBroadPhaseLayerFilterTable`/`Const_ObjectVsBroadPhaseLayerFilterTable` to pass it to the function.
    public class _InOptConst_ObjectVsBroadPhaseLayerFilterTable
    {
        public Const_ObjectVsBroadPhaseLayerFilterTable? Opt;

        public _InOptConst_ObjectVsBroadPhaseLayerFilterTable() {}
        public _InOptConst_ObjectVsBroadPhaseLayerFilterTable(Const_ObjectVsBroadPhaseLayerFilterTable value) {Opt = value;}
        public static implicit operator _InOptConst_ObjectVsBroadPhaseLayerFilterTable(Const_ObjectVsBroadPhaseLayerFilterTable value) {return new(value);}
    }
}
