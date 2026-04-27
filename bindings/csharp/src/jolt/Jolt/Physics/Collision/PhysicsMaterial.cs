// machine generated, do not edit
public static partial class JPH
{
    /// This structure describes the surface of (part of) a shape. You should inherit from it to define additional
    /// information that is interesting for the simulation. The 2 materials involved in a contact could be used
    /// to decide which sound or particle effects to play.
    ///
    /// If you inherit from this material, don't forget to create a suitable default material in sDefault
    /// Generated from class `JPH::PhysicsMaterial`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::PhysicsMaterial>`
    /// This is the const half of the class.
    public class Const_PhysicsMaterial : JPH.Object<Const_PhysicsMaterial>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsMaterial_Destroy(_Underlying *_this);
            __JPH_PhysicsMaterial_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_PhysicsMaterial() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_PhysicsMaterial self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_PhysicsMaterial_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_PhysicsMaterial_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHPhysicsMaterial(Const_PhysicsMaterial self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHPhysicsMaterial._Underlying *__JPH_PhysicsMaterial_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(_Underlying *_this);
            JPH.Const_RefTarget_JPHPhysicsMaterial ret = new(__JPH_PhysicsMaterial_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_PhysicsMaterial?(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_PhysicsMaterial_DynamicDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            var ptr = __JPH_PhysicsMaterial_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_PhysicsMaterial ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_PhysicsMaterial(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_PhysicsMaterial() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsMaterial._Underlying *__JPH_PhysicsMaterial_DefaultConstruct();
            _UnderlyingPtr = __JPH_PhysicsMaterial_DefaultConstruct();
        }

        /// Generated from method `JPH::PhysicsMaterial::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PhysicsMaterial_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PhysicsMaterial_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PhysicsMaterial_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_PhysicsMaterial_size_t(inCount);
        }

        /// Generated from method `JPH::PhysicsMaterial::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsMaterial_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsMaterial_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PhysicsMaterial_void_ptr(void *inPointer);
            __Jolt_delete_JPH_PhysicsMaterial_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PhysicsMaterial::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsMaterial_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsMaterial_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PhysicsMaterial_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_PhysicsMaterial_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PhysicsMaterial::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsMaterial_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsMaterial_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PhysicsMaterial_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_PhysicsMaterial_size_t(inCount);
        }

        /// Generated from method `JPH::PhysicsMaterial::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsMaterial_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsMaterial_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PhysicsMaterial_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_PhysicsMaterial_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PhysicsMaterial::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsMaterial_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsMaterial_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PhysicsMaterial_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_PhysicsMaterial_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PhysicsMaterial::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PhysicsMaterial_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PhysicsMaterial_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PhysicsMaterial_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_PhysicsMaterial_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PhysicsMaterial::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsMaterial_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsMaterial_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PhysicsMaterial_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_PhysicsMaterial_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::PhysicsMaterial::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsMaterial_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsMaterial_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PhysicsMaterial_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_PhysicsMaterial_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PhysicsMaterial::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsMaterial_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsMaterial_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PhysicsMaterial_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_PhysicsMaterial_void_ptr_void_ptr(inPointer, inPlace);
        }

        // Properties
        /// Generated from method `JPH::PhysicsMaterial::GetDebugName`.
        public unsafe byte? GetDebugName()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_GetDebugName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_GetDebugName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte *__JPH_PhysicsMaterial_GetDebugName(_Underlying *_this);
            var __c_ret = __JPH_PhysicsMaterial_GetDebugName(_UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::PhysicsMaterial::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsMaterial_SetEmbedded(_Underlying *_this);
            __JPH_PhysicsMaterial_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::PhysicsMaterial::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_PhysicsMaterial_GetRefCount(_Underlying *_this);
            return __JPH_PhysicsMaterial_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::PhysicsMaterial::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsMaterial_AddRef(_Underlying *_this);
            __JPH_PhysicsMaterial_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::PhysicsMaterial::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsMaterial_Release(_Underlying *_this);
            __JPH_PhysicsMaterial_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::PhysicsMaterial::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_PhysicsMaterial_sInternalGetRefCountOffset();
            return __JPH_PhysicsMaterial_sInternalGetRefCountOffset();
        }
    }

    /// This structure describes the surface of (part of) a shape. You should inherit from it to define additional
    /// information that is interesting for the simulation. The 2 materials involved in a contact could be used
    /// to decide which sound or particle effects to play.
    ///
    /// If you inherit from this material, don't forget to create a suitable default material in sDefault
    /// Generated from class `JPH::PhysicsMaterial`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::PhysicsMaterial>`
    /// This is the non-const half of the class.
    public class PhysicsMaterial : Const_PhysicsMaterial
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(PhysicsMaterial self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_PhysicsMaterial_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_PhysicsMaterial_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.RefTarget_JPHPhysicsMaterial(PhysicsMaterial self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHPhysicsMaterial._Underlying *__JPH_PhysicsMaterial_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(_Underlying *_this);
            JPH.RefTarget_JPHPhysicsMaterial ret = new(__JPH_PhysicsMaterial_UpcastTo_JPH_RefTarget_JPH_PhysicsMaterial(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator PhysicsMaterial?(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_PhysicsMaterial_DynamicDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            var ptr = __JPH_PhysicsMaterial_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
            if (ptr is null) return null;
            PhysicsMaterial ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe PhysicsMaterial(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe PhysicsMaterial() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsMaterial_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsMaterial_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsMaterial._Underlying *__JPH_PhysicsMaterial_DefaultConstruct();
            _UnderlyingPtr = __JPH_PhysicsMaterial_DefaultConstruct();
        }
    }

    /// This is used as a function parameter when the underlying function receives `PhysicsMaterial` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_PhysicsMaterial
    {
        #pragma warning disable CS0649
        internal readonly Const_PhysicsMaterial? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_PhysicsMaterial() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `PhysicsMaterial` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_PhysicsMaterial`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PhysicsMaterial`/`Const_PhysicsMaterial` directly.
    public class _InOptMut_PhysicsMaterial
    {
        public PhysicsMaterial? Opt;

        public _InOptMut_PhysicsMaterial() {}
        public _InOptMut_PhysicsMaterial(PhysicsMaterial value) {Opt = value;}
        public static implicit operator _InOptMut_PhysicsMaterial(PhysicsMaterial value) {return new(value);}
    }

    /// This is used for optional parameters of class `PhysicsMaterial` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_PhysicsMaterial`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PhysicsMaterial`/`Const_PhysicsMaterial` to pass it to the function.
    public class _InOptConst_PhysicsMaterial
    {
        public Const_PhysicsMaterial? Opt;

        public _InOptConst_PhysicsMaterial() {}
        public _InOptConst_PhysicsMaterial(Const_PhysicsMaterial value) {Opt = value;}
        public static implicit operator _InOptConst_PhysicsMaterial(Const_PhysicsMaterial value) {return new(value);}
    }
}
