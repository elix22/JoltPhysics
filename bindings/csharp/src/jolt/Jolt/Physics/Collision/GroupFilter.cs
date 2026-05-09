// machine generated, do not edit
public static partial class JPH
{
    /// Abstract class that checks if two CollisionGroups collide
    /// Generated from class `JPH::GroupFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::GroupFilter>`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::GroupFilterTable`
    /// This is the const half of the class.
    public class Const_GroupFilter : JPH.Object<Const_GroupFilter>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_GroupFilter_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_GroupFilter_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_GroupFilter_Release(void *_this);
            __JPH_RefTarget_JPH_GroupFilter_Release(__JPH_GroupFilter_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_GroupFilter() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_GroupFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_GroupFilter_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_GroupFilter_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHGroupFilter(Const_GroupFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHGroupFilter._Underlying *__JPH_GroupFilter_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_Underlying *_this);
            JPH.Const_RefTarget_JPHGroupFilter ret = new(__JPH_GroupFilter_UpcastTo_JPH_RefTarget_JPH_GroupFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_GroupFilter(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_GroupFilter_StaticDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            Const_GroupFilter ret = new(__JPH_GroupFilter_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_GroupFilter(JPH.Const_RefTarget_JPHGroupFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_GroupFilter_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(JPH.Const_RefTarget_JPHGroupFilter._Underlying *_this);
            Const_GroupFilter ret = new(__JPH_GroupFilter_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_GroupFilter(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `JPH::GroupFilter::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_GroupFilter_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_GroupFilter_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_GroupFilter_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_GroupFilter_size_t(inCount);
        }

        /// Generated from method `JPH::GroupFilter::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_GroupFilter_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_GroupFilter_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_GroupFilter_void_ptr(void *inPointer);
            __Jolt_delete_JPH_GroupFilter_void_ptr(inPointer);
        }

        /// Generated from method `JPH::GroupFilter::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_GroupFilter_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_GroupFilter_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_GroupFilter_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_GroupFilter_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::GroupFilter::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_GroupFilter_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_GroupFilter_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_GroupFilter_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_GroupFilter_size_t(inCount);
        }

        /// Generated from method `JPH::GroupFilter::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_GroupFilter_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_GroupFilter_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_GroupFilter_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_GroupFilter_void_ptr(inPointer);
        }

        /// Generated from method `JPH::GroupFilter::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_GroupFilter_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_GroupFilter_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_GroupFilter_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_GroupFilter_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::GroupFilter::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_GroupFilter_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_GroupFilter_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_GroupFilter_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_GroupFilter_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::GroupFilter::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_GroupFilter_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_GroupFilter_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_GroupFilter_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_GroupFilter_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::GroupFilter::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_GroupFilter_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_GroupFilter_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_GroupFilter_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_GroupFilter_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::GroupFilter::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_GroupFilter_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_GroupFilter_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_GroupFilter_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_GroupFilter_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Check if two groups collide
        /// Generated from method `JPH::GroupFilter::CanCollide`.
        public unsafe bool CanCollide(JPH.Const_CollisionGroup inGroup1, JPH.Const_CollisionGroup inGroup2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_CanCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_CanCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_GroupFilter_CanCollide(_Underlying *_this, JPH.Const_CollisionGroup._Underlying *inGroup1, JPH.Const_CollisionGroup._Underlying *inGroup2);
            return __JPH_GroupFilter_CanCollide(_UnderlyingPtr, inGroup1._UnderlyingPtr, inGroup2._UnderlyingPtr) != 0;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::GroupFilter::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_GroupFilter_SetEmbedded(_Underlying *_this);
            __JPH_GroupFilter_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::GroupFilter::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_GroupFilter_GetRefCount(_Underlying *_this);
            return __JPH_GroupFilter_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::GroupFilter::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_GroupFilter_AddRef(_Underlying *_this);
            __JPH_GroupFilter_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::GroupFilter::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_GroupFilter_Release(_Underlying *_this);
            __JPH_GroupFilter_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::GroupFilter::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_GroupFilter_sInternalGetRefCountOffset();
            return __JPH_GroupFilter_sInternalGetRefCountOffset();
        }
    }

    /// Abstract class that checks if two CollisionGroups collide
    /// Generated from class `JPH::GroupFilter`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::GroupFilter>`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::GroupFilterTable`
    /// This is the non-const half of the class.
    public class GroupFilter : Const_GroupFilter
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(GroupFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_GroupFilter_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_GroupFilter_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_SerializableObject(GroupFilter self)
            => (JPH.Const_SerializableObject)(JPH.Const_GroupFilter)self;
        public static unsafe implicit operator JPH.RefTarget_JPHGroupFilter(GroupFilter self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_UpcastTo_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHGroupFilter._Underlying *__JPH_GroupFilter_UpcastTo_JPH_RefTarget_JPH_GroupFilter(_Underlying *_this);
            JPH.RefTarget_JPHGroupFilter ret = new(__JPH_GroupFilter_UpcastTo_JPH_RefTarget_JPH_GroupFilter(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHGroupFilter(GroupFilter self)
            => (JPH.Const_RefTarget_JPHGroupFilter)(JPH.Const_GroupFilter)self;

        // Downcasts:
        public static unsafe explicit operator GroupFilter(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_GroupFilter_StaticDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            GroupFilter ret = new(__JPH_GroupFilter_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator GroupFilter(JPH.RefTarget_JPHGroupFilter parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_GroupFilter_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_GroupFilter_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_GroupFilter_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(JPH.RefTarget_JPHGroupFilter._Underlying *_this);
            GroupFilter ret = new(__JPH_GroupFilter_StaticDowncastFrom_JPH_RefTarget_JPH_GroupFilter(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe GroupFilter(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}
    }

    /// This is used for optional parameters of class `GroupFilter` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_GroupFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `GroupFilter`/`Const_GroupFilter` directly.
    public class _InOptMut_GroupFilter
    {
        public GroupFilter? Opt;

        public _InOptMut_GroupFilter() {}
        public _InOptMut_GroupFilter(GroupFilter value) {Opt = value;}
        public static implicit operator _InOptMut_GroupFilter(GroupFilter value) {return new(value);}
    }

    /// This is used for optional parameters of class `GroupFilter` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_GroupFilter`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `GroupFilter`/`Const_GroupFilter` to pass it to the function.
    public class _InOptConst_GroupFilter
    {
        public Const_GroupFilter? Opt;

        public _InOptConst_GroupFilter() {}
        public _InOptConst_GroupFilter(Const_GroupFilter value) {Opt = value;}
        public static implicit operator _InOptConst_GroupFilter(Const_GroupFilter value) {return new(value);}
    }
}
