// machine generated, do not edit
public static partial class JPH
{
    /// Filter class to test if two objects can collide based on their object layer. Used while finding collision pairs.
    /// This implementation uses a table to determine if two layers can collide.
    /// Generated from class `JPH::ObjectLayerPairFilterTable`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectLayerPairFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_ObjectLayerPairFilterTable : JPH.Object<Const_ObjectLayerPairFilterTable>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ObjectLayerPairFilterTable_Destroy(_Underlying *_this);
            __JPH_ObjectLayerPairFilterTable_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ObjectLayerPairFilterTable() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_ObjectLayerPairFilterTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ObjectLayerPairFilter(Const_ObjectLayerPairFilterTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ObjectLayerPairFilter._Underlying *__JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_ObjectLayerPairFilter(_Underlying *_this);
            JPH.Const_ObjectLayerPairFilter ret = new(__JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_ObjectLayerPairFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_ObjectLayerPairFilterTable(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_ObjectLayerPairFilterTable ret = new(__JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_ObjectLayerPairFilterTable(JPH.Const_ObjectLayerPairFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_ObjectLayerPairFilter(JPH.Const_ObjectLayerPairFilter._Underlying *_this);
            Const_ObjectLayerPairFilterTable ret = new(__JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_ObjectLayerPairFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_ObjectLayerPairFilterTable(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs the table with inNumObjectLayers Layers, initially all layer pairs are disabled
        /// Generated from constructor `JPH::ObjectLayerPairFilterTable::ObjectLayerPairFilterTable`.
        public unsafe Const_ObjectLayerPairFilterTable(uint inNumObjectLayers) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectLayerPairFilterTable._Underlying *__JPH_ObjectLayerPairFilterTable_Construct(uint inNumObjectLayers);
            _UnderlyingPtr = __JPH_ObjectLayerPairFilterTable_Construct(inNumObjectLayers);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterTable::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ObjectLayerPairFilterTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ObjectLayerPairFilterTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ObjectLayerPairFilterTable_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_ObjectLayerPairFilterTable_size_t(inCount);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterTable::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr(void *inPointer);
            __Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterTable::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterTable::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectLayerPairFilterTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectLayerPairFilterTable_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ObjectLayerPairFilterTable_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_ObjectLayerPairFilterTable_size_t(inCount);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterTable::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterTable::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterTable::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ObjectLayerPairFilterTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ObjectLayerPairFilterTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ObjectLayerPairFilterTable_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_ObjectLayerPairFilterTable_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterTable::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_ObjectLayerPairFilterTable_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterTable::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectLayerPairFilterTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ObjectLayerPairFilterTable_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ObjectLayerPairFilterTable_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_ObjectLayerPairFilterTable_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ObjectLayerPairFilterTable::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_ObjectLayerPairFilterTable_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Get the number of object layers
        /// Generated from method `JPH::ObjectLayerPairFilterTable::GetNumObjectLayers`.
        public unsafe uint GetNumObjectLayers()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_GetNumObjectLayers", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_GetNumObjectLayers", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_ObjectLayerPairFilterTable_GetNumObjectLayers(_Underlying *_this);
            return __JPH_ObjectLayerPairFilterTable_GetNumObjectLayers(_UnderlyingPtr);
        }

        /// Returns true if two layers can collide
        /// Generated from method `JPH::ObjectLayerPairFilterTable::ShouldCollide`.
        public unsafe bool ShouldCollide(ushort inObject1, ushort inObject2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_ShouldCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_ObjectLayerPairFilterTable_ShouldCollide(_Underlying *_this, ushort inObject1, ushort inObject2);
            return __JPH_ObjectLayerPairFilterTable_ShouldCollide(_UnderlyingPtr, inObject1, inObject2) != 0;
        }
    }

    /// Filter class to test if two objects can collide based on their object layer. Used while finding collision pairs.
    /// This implementation uses a table to determine if two layers can collide.
    /// Generated from class `JPH::ObjectLayerPairFilterTable`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ObjectLayerPairFilter`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class ObjectLayerPairFilterTable : Const_ObjectLayerPairFilterTable
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(ObjectLayerPairFilterTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ObjectLayerPairFilter(ObjectLayerPairFilterTable self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectLayerPairFilter._Underlying *__JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_ObjectLayerPairFilter(_Underlying *_this);
            JPH.ObjectLayerPairFilter ret = new(__JPH_ObjectLayerPairFilterTable_UpcastTo_JPH_ObjectLayerPairFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator ObjectLayerPairFilterTable(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            ObjectLayerPairFilterTable ret = new(__JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator ObjectLayerPairFilterTable(JPH.ObjectLayerPairFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_ObjectLayerPairFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_ObjectLayerPairFilter(JPH.ObjectLayerPairFilter._Underlying *_this);
            ObjectLayerPairFilterTable ret = new(__JPH_ObjectLayerPairFilterTable_StaticDowncastFrom_JPH_ObjectLayerPairFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe ObjectLayerPairFilterTable(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs the table with inNumObjectLayers Layers, initially all layer pairs are disabled
        /// Generated from constructor `JPH::ObjectLayerPairFilterTable::ObjectLayerPairFilterTable`.
        public unsafe ObjectLayerPairFilterTable(uint inNumObjectLayers) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ObjectLayerPairFilterTable._Underlying *__JPH_ObjectLayerPairFilterTable_Construct(uint inNumObjectLayers);
            _UnderlyingPtr = __JPH_ObjectLayerPairFilterTable_Construct(inNumObjectLayers);
        }

        /// Disable collision between two object layers
        /// Generated from method `JPH::ObjectLayerPairFilterTable::DisableCollision`.
        public unsafe void DisableCollision(ushort inLayer1, ushort inLayer2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_DisableCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_DisableCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ObjectLayerPairFilterTable_DisableCollision(_Underlying *_this, ushort inLayer1, ushort inLayer2);
            __JPH_ObjectLayerPairFilterTable_DisableCollision(_UnderlyingPtr, inLayer1, inLayer2);
        }

        /// Enable collision between two object layers
        /// Generated from method `JPH::ObjectLayerPairFilterTable::EnableCollision`.
        public unsafe void EnableCollision(ushort inLayer1, ushort inLayer2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_EnableCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ObjectLayerPairFilterTable_EnableCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ObjectLayerPairFilterTable_EnableCollision(_Underlying *_this, ushort inLayer1, ushort inLayer2);
            __JPH_ObjectLayerPairFilterTable_EnableCollision(_UnderlyingPtr, inLayer1, inLayer2);
        }
    }

    /// This is used for optional parameters of class `ObjectLayerPairFilterTable` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ObjectLayerPairFilterTable`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ObjectLayerPairFilterTable`/`Const_ObjectLayerPairFilterTable` directly.
    public class _InOptMut_ObjectLayerPairFilterTable
    {
        public ObjectLayerPairFilterTable? Opt;

        public _InOptMut_ObjectLayerPairFilterTable() {}
        public _InOptMut_ObjectLayerPairFilterTable(ObjectLayerPairFilterTable value) {Opt = value;}
        public static implicit operator _InOptMut_ObjectLayerPairFilterTable(ObjectLayerPairFilterTable value) {return new(value);}
    }

    /// This is used for optional parameters of class `ObjectLayerPairFilterTable` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ObjectLayerPairFilterTable`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ObjectLayerPairFilterTable`/`Const_ObjectLayerPairFilterTable` to pass it to the function.
    public class _InOptConst_ObjectLayerPairFilterTable
    {
        public Const_ObjectLayerPairFilterTable? Opt;

        public _InOptConst_ObjectLayerPairFilterTable() {}
        public _InOptConst_ObjectLayerPairFilterTable(Const_ObjectLayerPairFilterTable value) {Opt = value;}
        public static implicit operator _InOptConst_ObjectLayerPairFilterTable(Const_ObjectLayerPairFilterTable value) {return new(value);}
    }
}
