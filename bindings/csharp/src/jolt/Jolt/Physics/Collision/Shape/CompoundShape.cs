// machine generated, do not edit
public static partial class JPH
{
    /// Base class settings to construct a compound shape
    /// Generated from class `JPH::CompoundShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::MutableCompoundShapeSettings`
    ///     `JPH::StaticCompoundShapeSettings`
    /// This is the const half of the class.
    public class Const_CompoundShapeSettings : JPH.Object<Const_CompoundShapeSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_Release(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_Release(__JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_CompoundShapeSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_CompoundShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShapeSettings(Const_CompoundShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShapeSettings._Underlying *__JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHShapeSettings ret = new(__JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ShapeSettings(Const_CompoundShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ShapeSettings._Underlying *__JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_ShapeSettings ret = new(__JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_CompoundShapeSettings(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            Const_CompoundShapeSettings ret = new(__JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_CompoundShapeSettings(JPH.Const_RefTarget_JPHShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH.Const_RefTarget_JPHShapeSettings._Underlying *_this);
            Const_CompoundShapeSettings ret = new(__JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_CompoundShapeSettings(JPH.Const_ShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(JPH.Const_ShapeSettings._Underlying *_this);
            Const_CompoundShapeSettings ret = new(__JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        public unsafe JPH.Const_Array_JPHCompoundShapeSettingsSubShapeSettings mSubShapes
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_Get_mSubShapes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_Get_mSubShapes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Array_JPHCompoundShapeSettingsSubShapeSettings._Underlying *__JPH_CompoundShapeSettings_Get_mSubShapes(_Underlying *_this);
                JPH.Const_Array_JPHCompoundShapeSettingsSubShapeSettings __ret;
                __ret = new(__JPH_CompoundShapeSettings_Get_mSubShapes(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// User data (to be used freely by the application)
        public unsafe ulong mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong *__JPH_CompoundShapeSettings_Get_mUserData(_Underlying *_this);
                return *__JPH_CompoundShapeSettings_Get_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe Const_CompoundShapeSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `JPH::CompoundShapeSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CompoundShapeSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_CompoundShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::CompoundShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CompoundShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_CompoundShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CompoundShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CompoundShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_CompoundShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CompoundShapeSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CompoundShapeSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_CompoundShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::CompoundShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CompoundShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CompoundShapeSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CompoundShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_CompoundShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CompoundShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_CompoundShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::CompoundShapeSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CompoundShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_CompoundShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CompoundShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::CompoundShapeSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShapeSettings_SetEmbedded(_Underlying *_this);
            __JPH_CompoundShapeSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::CompoundShapeSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_CompoundShapeSettings_GetRefCount(_Underlying *_this);
            return __JPH_CompoundShapeSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::CompoundShapeSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShapeSettings_AddRef(_Underlying *_this);
            __JPH_CompoundShapeSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::CompoundShapeSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShapeSettings_Release(_Underlying *_this);
            __JPH_CompoundShapeSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::CompoundShapeSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_CompoundShapeSettings_sInternalGetRefCountOffset();
            return __JPH_CompoundShapeSettings_sInternalGetRefCountOffset();
        }

        /// Generated from class `JPH::CompoundShapeSettings::SubShapeSettings`.
        /// This is the const half of the class.
        public class Const_SubShapeSettings : JPH.Object<Const_SubShapeSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CompoundShapeSettings_SubShapeSettings_Destroy(_Underlying *_this);
                __JPH_CompoundShapeSettings_SubShapeSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_SubShapeSettings() {Dispose(false);}

            ///< Position of the sub shape
            public unsafe JPH.Const_Vec3 mPosition
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Vec3._Underlying *__JPH_CompoundShapeSettings_SubShapeSettings_Get_mPosition(_Underlying *_this);
                    JPH.Const_Vec3 __ret;
                    __ret = new(__JPH_CompoundShapeSettings_SubShapeSettings_Get_mPosition(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Rotation of the sub shape
            public unsafe JPH.Const_Quat mRotation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_Get_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_Get_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Quat._Underlying *__JPH_CompoundShapeSettings_SubShapeSettings_Get_mRotation(_Underlying *_this);
                    JPH.Const_Quat __ret;
                    __ret = new(__JPH_CompoundShapeSettings_SubShapeSettings_Get_mRotation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            /// User data value (can be used by the application for any purpose).
            /// Note this value can be retrieved through GetSubShape(...).mUserData, not through GetSubShapeUserData(...) as that returns Shape::GetUserData() of the leaf shape.
            /// Use GetSubShapeIndexFromID get a shape index from a SubShapeID to pass to GetSubShape.
            public unsafe uint mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_CompoundShapeSettings_SubShapeSettings_Get_mUserData(_Underlying *_this);
                    return *__JPH_CompoundShapeSettings_SubShapeSettings_Get_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe Const_SubShapeSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_SubShapeSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.CompoundShapeSettings.SubShapeSettings._Underlying *__JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::CompoundShapeSettings::SubShapeSettings::SubShapeSettings`.
            public unsafe Const_SubShapeSettings(JPH.CompoundShapeSettings._ByValue_SubShapeSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.CompoundShapeSettings.SubShapeSettings._Underlying *__JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.CompoundShapeSettings.SubShapeSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::CompoundShapeSettings::SubShapeSettings::SubShapeSettings`.
            public Const_SubShapeSettings(Const_SubShapeSettings _other) : this(new _ByValue_SubShapeSettings(_other)) {}

            /// Generated from constructor `JPH::CompoundShapeSettings::SubShapeSettings::SubShapeSettings`.
            public Const_SubShapeSettings(SubShapeSettings _other) : this((Const_SubShapeSettings)_other) {}

            /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t(inCount);
            }

            /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr(void *inPointer);
                __Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t(inCount);
            }

            /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
            }
        }

        /// Generated from class `JPH::CompoundShapeSettings::SubShapeSettings`.
        /// This is the non-const half of the class.
        public class SubShapeSettings : Const_SubShapeSettings
        {
            ///< Position of the sub shape
            public new unsafe JPH.Vec3 mPosition
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Vec3._Underlying *__JPH_CompoundShapeSettings_SubShapeSettings_GetMutable_mPosition(_Underlying *_this);
                    JPH.Vec3 __ret;
                    __ret = new(__JPH_CompoundShapeSettings_SubShapeSettings_GetMutable_mPosition(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Rotation of the sub shape
            public new unsafe JPH.Quat mRotation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_GetMutable_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_GetMutable_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Quat._Underlying *__JPH_CompoundShapeSettings_SubShapeSettings_GetMutable_mRotation(_Underlying *_this);
                    JPH.Quat __ret;
                    __ret = new(__JPH_CompoundShapeSettings_SubShapeSettings_GetMutable_mRotation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            /// User data value (can be used by the application for any purpose).
            /// Note this value can be retrieved through GetSubShape(...).mUserData, not through GetSubShapeUserData(...) as that returns Shape::GetUserData() of the leaf shape.
            /// Use GetSubShapeIndexFromID get a shape index from a SubShapeID to pass to GetSubShape.
            public new unsafe ref uint mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_CompoundShapeSettings_SubShapeSettings_GetMutable_mUserData(_Underlying *_this);
                    return ref *__JPH_CompoundShapeSettings_SubShapeSettings_GetMutable_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe SubShapeSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe SubShapeSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.CompoundShapeSettings.SubShapeSettings._Underlying *__JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::CompoundShapeSettings::SubShapeSettings::SubShapeSettings`.
            public unsafe SubShapeSettings(JPH.CompoundShapeSettings._ByValue_SubShapeSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.CompoundShapeSettings.SubShapeSettings._Underlying *__JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.CompoundShapeSettings.SubShapeSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::CompoundShapeSettings::SubShapeSettings::SubShapeSettings`.
            public SubShapeSettings(Const_SubShapeSettings _other) : this(new _ByValue_SubShapeSettings(_other)) {}

            /// Generated from constructor `JPH::CompoundShapeSettings::SubShapeSettings::SubShapeSettings`.
            public SubShapeSettings(SubShapeSettings _other) : this((Const_SubShapeSettings)_other) {}

            /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator=`.
            public unsafe JPH.CompoundShapeSettings.SubShapeSettings Assign(JPH.CompoundShapeSettings._ByValue_SubShapeSettings _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.CompoundShapeSettings.SubShapeSettings._Underlying *__JPH_CompoundShapeSettings_SubShapeSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.CompoundShapeSettings.SubShapeSettings._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_CompoundShapeSettings_SubShapeSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }
        }

        /// This is used as a function parameter when the underlying function receives `SubShapeSettings` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `SubShapeSettings`/`Const_SubShapeSettings` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_SubShapeSettings
        {
            #pragma warning disable CS0649
            internal readonly Const_SubShapeSettings? Value;
            #pragma warning restore CS0649
            internal readonly JPH._PassBy PassByMode;
            public _ByValue_SubShapeSettings() {PassByMode = JPH._PassBy.default_construct;}
            public _ByValue_SubShapeSettings(Const_SubShapeSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
            public static implicit operator _ByValue_SubShapeSettings(Const_SubShapeSettings arg) {return new(arg);}
            public _ByValue_SubShapeSettings(JPH._Moved<SubShapeSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
            public static implicit operator _ByValue_SubShapeSettings(JPH._Moved<SubShapeSettings> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `SubShapeSettings` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_SubShapeSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `SubShapeSettings`/`Const_SubShapeSettings` directly.
        public class _InOptMut_SubShapeSettings
        {
            public SubShapeSettings? Opt;

            public _InOptMut_SubShapeSettings() {}
            public _InOptMut_SubShapeSettings(SubShapeSettings value) {Opt = value;}
            public static implicit operator _InOptMut_SubShapeSettings(SubShapeSettings value) {return new(value);}
        }

        /// This is used for optional parameters of class `SubShapeSettings` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_SubShapeSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `SubShapeSettings`/`Const_SubShapeSettings` to pass it to the function.
        public class _InOptConst_SubShapeSettings
        {
            public Const_SubShapeSettings? Opt;

            public _InOptConst_SubShapeSettings() {}
            public _InOptConst_SubShapeSettings(Const_SubShapeSettings value) {Opt = value;}
            public static implicit operator _InOptConst_SubShapeSettings(Const_SubShapeSettings value) {return new(value);}
        }
    }

    /// Base class settings to construct a compound shape
    /// Generated from class `JPH::CompoundShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::MutableCompoundShapeSettings`
    ///     `JPH::StaticCompoundShapeSettings`
    /// This is the non-const half of the class.
    public class CompoundShapeSettings : Const_CompoundShapeSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(CompoundShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_SerializableObject(CompoundShapeSettings self)
            => (JPH.Const_SerializableObject)(JPH.Const_CompoundShapeSettings)self;
        public static unsafe implicit operator JPH.RefTarget_JPHShapeSettings(CompoundShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.RefTarget_JPHShapeSettings ret = new(__JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShapeSettings(CompoundShapeSettings self)
            => (JPH.Const_RefTarget_JPHShapeSettings)(JPH.Const_CompoundShapeSettings)self;
        public static unsafe implicit operator JPH.ShapeSettings(CompoundShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeSettings._Underlying *__JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
            JPH.ShapeSettings ret = new(__JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ShapeSettings(CompoundShapeSettings self)
            => (JPH.Const_ShapeSettings)(JPH.Const_CompoundShapeSettings)self;

        // Downcasts:
        public static unsafe explicit operator CompoundShapeSettings(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            CompoundShapeSettings ret = new(__JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator CompoundShapeSettings(JPH.RefTarget_JPHShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH.RefTarget_JPHShapeSettings._Underlying *_this);
            CompoundShapeSettings ret = new(__JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator CompoundShapeSettings(JPH.ShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(JPH.ShapeSettings._Underlying *_this);
            CompoundShapeSettings ret = new(__JPH_CompoundShapeSettings_StaticDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        public new unsafe JPH.Array_JPHCompoundShapeSettingsSubShapeSettings mSubShapes
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_GetMutable_mSubShapes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_GetMutable_mSubShapes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Array_JPHCompoundShapeSettingsSubShapeSettings._Underlying *__JPH_CompoundShapeSettings_GetMutable_mSubShapes(_Underlying *_this);
                JPH.Array_JPHCompoundShapeSettingsSubShapeSettings __ret;
                __ret = new(__JPH_CompoundShapeSettings_GetMutable_mSubShapes(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// User data (to be used freely by the application)
        public new unsafe ref ulong mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong *__JPH_CompoundShapeSettings_GetMutable_mUserData(_Underlying *_this);
                return ref *__JPH_CompoundShapeSettings_GetMutable_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe CompoundShapeSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Add a shape to the compound.
        /// Generated from method `JPH::CompoundShapeSettings::AddShape`.
        /// Parameter `inUserData` defaults to `0`.
        public unsafe void AddShape(JPH.Const_Vec3 inPosition, JPH.Const_Quat inRotation, JPH.Const_ShapeSettings? inShape, uint? inUserData = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_AddShape_const_JPH_ShapeSettings_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_AddShape_const_JPH_ShapeSettings_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShapeSettings_AddShape_const_JPH_ShapeSettings_ptr(_Underlying *_this, JPH.Vec3._Underlying *inPosition, JPH.Quat._Underlying *inRotation, JPH.Const_ShapeSettings._Underlying *inShape, uint *inUserData);
            uint __deref_inUserData = inUserData.GetValueOrDefault();
            __JPH_CompoundShapeSettings_AddShape_const_JPH_ShapeSettings_ptr(_UnderlyingPtr, inPosition._UnderlyingPtr, inRotation._UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null, inUserData.HasValue ? &__deref_inUserData : null);
        }

        /// Add a shape to the compound. Variant that uses a concrete shape, which means this object cannot be serialized.
        /// Generated from method `JPH::CompoundShapeSettings::AddShape`.
        /// Parameter `inUserData` defaults to `0`.
        public unsafe void AddShape(JPH.Const_Vec3 inPosition, JPH.Const_Quat inRotation, JPH.Const_Shape? inShape, uint? inUserData = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_AddShape_const_JPH_Shape_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_AddShape_const_JPH_Shape_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShapeSettings_AddShape_const_JPH_Shape_ptr(_Underlying *_this, JPH.Vec3._Underlying *inPosition, JPH.Quat._Underlying *inRotation, JPH.Const_Shape._Underlying *inShape, uint *inUserData);
            uint __deref_inUserData = inUserData.GetValueOrDefault();
            __JPH_CompoundShapeSettings_AddShape_const_JPH_Shape_ptr(_UnderlyingPtr, inPosition._UnderlyingPtr, inRotation._UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null, inUserData.HasValue ? &__deref_inUserData : null);
        }

        /// When creating a shape, the result is cached so that calling Create() again will return the same shape.
        /// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
        /// Generated from method `JPH::CompoundShapeSettings::ClearCachedResult`.
        public unsafe void ClearCachedResult()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShapeSettings_ClearCachedResult(_Underlying *_this);
            __JPH_CompoundShapeSettings_ClearCachedResult(_UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `CompoundShapeSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_CompoundShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CompoundShapeSettings`/`Const_CompoundShapeSettings` directly.
    public class _InOptMut_CompoundShapeSettings
    {
        public CompoundShapeSettings? Opt;

        public _InOptMut_CompoundShapeSettings() {}
        public _InOptMut_CompoundShapeSettings(CompoundShapeSettings value) {Opt = value;}
        public static implicit operator _InOptMut_CompoundShapeSettings(CompoundShapeSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `CompoundShapeSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_CompoundShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CompoundShapeSettings`/`Const_CompoundShapeSettings` to pass it to the function.
    public class _InOptConst_CompoundShapeSettings
    {
        public Const_CompoundShapeSettings? Opt;

        public _InOptConst_CompoundShapeSettings() {}
        public _InOptConst_CompoundShapeSettings(Const_CompoundShapeSettings value) {Opt = value;}
        public static implicit operator _InOptConst_CompoundShapeSettings(Const_CompoundShapeSettings value) {return new(value);}
    }

    /// Base class for a compound shape
    /// Generated from class `JPH::CompoundShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Shape`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::MutableCompoundShape`
    ///     `JPH::StaticCompoundShape`
    /// This is the const half of the class.
    public class Const_CompoundShape : JPH.Object<Const_CompoundShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_Release(void *_this);
            __JPH_RefTarget_JPH_Shape_Release(__JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_CompoundShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShape(Const_CompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShape._Underlying *__JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.Const_RefTarget_JPHShape ret = new(__JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_CompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_CompoundShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_CompoundShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Shape(Const_CompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_CompoundShape_UpcastTo_JPH_Shape(_Underlying *_this);
            JPH.Const_Shape ret = new(__JPH_CompoundShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_CompoundShape(JPH.Const_RefTarget_JPHShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CompoundShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH.Const_RefTarget_JPHShape._Underlying *_this);
            Const_CompoundShape ret = new(__JPH_CompoundShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_CompoundShape(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CompoundShape_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_CompoundShape ret = new(__JPH_CompoundShape_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_CompoundShape(JPH.Const_Shape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_StaticDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_StaticDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CompoundShape_StaticDowncastFrom_JPH_Shape(JPH.Const_Shape._Underlying *_this);
            Const_CompoundShape ret = new(__JPH_CompoundShape_StaticDowncastFrom_JPH_Shape(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
        public static unsafe int CGetTrianglesMinTrianglesRequested
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_CompoundShape_Get_cGetTrianglesMinTrianglesRequested();
                return *__JPH_CompoundShape_Get_cGetTrianglesMinTrianglesRequested();
            }
        }

        /// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
        public static unsafe ref bool SDrawSubmergedVolumes
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetMutable_sDrawSubmergedVolumes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetMutable_sDrawSubmergedVolumes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_CompoundShape_GetMutable_sDrawSubmergedVolumes();
                return ref *__JPH_CompoundShape_GetMutable_sDrawSubmergedVolumes();
            }
        }

        internal unsafe Const_CompoundShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Get world space bounds including convex radius.
        /// Generated from method `JPH::CompoundShape::GetWorldSpaceBounds`.
        public unsafe JPH.AABox GetWorldSpaceBounds(JPH.Const_DMat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetWorldSpaceBounds_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetWorldSpaceBounds_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_CompoundShape_GetWorldSpaceBounds_JPH_DMat44(_Underlying *_this, JPH.Const_DMat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale);
            return new(__JPH_CompoundShape_GetWorldSpaceBounds_JPH_DMat44(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::CompoundShape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CompoundShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CompoundShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CompoundShape_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_CompoundShape_size_t(inCount);
        }

        /// Generated from method `JPH::CompoundShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CompoundShape_void_ptr(void *inPointer);
            __Jolt_delete_JPH_CompoundShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CompoundShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CompoundShape_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_CompoundShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CompoundShape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CompoundShape_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_CompoundShape_size_t(inCount);
        }

        /// Generated from method `JPH::CompoundShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CompoundShape_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_CompoundShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CompoundShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CompoundShape_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_CompoundShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CompoundShape::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CompoundShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CompoundShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CompoundShape_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_CompoundShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CompoundShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_CompoundShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::CompoundShape::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CompoundShape_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_CompoundShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CompoundShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_CompoundShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        // See Shape::GetCenterOfMass
        /// Generated from method `JPH::CompoundShape::GetCenterOfMass`.
        public unsafe JPH.Vec3 GetCenterOfMass()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_CompoundShape_GetCenterOfMass(_Underlying *_this);
            return new(__JPH_CompoundShape_GetCenterOfMass(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::MustBeStatic
        /// Generated from method `JPH::CompoundShape::MustBeStatic`.
        public unsafe bool MustBeStatic()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_CompoundShape_MustBeStatic(_Underlying *_this);
            return __JPH_CompoundShape_MustBeStatic(_UnderlyingPtr) != 0;
        }

        // See Shape::GetLocalBounds
        /// Generated from method `JPH::CompoundShape::GetLocalBounds`.
        public unsafe JPH.AABox GetLocalBounds()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_CompoundShape_GetLocalBounds(_Underlying *_this);
            return new(__JPH_CompoundShape_GetLocalBounds(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetSubShapeIDBitsRecursive
        /// Generated from method `JPH::CompoundShape::GetSubShapeIDBitsRecursive`.
        public unsafe uint GetSubShapeIDBitsRecursive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_CompoundShape_GetSubShapeIDBitsRecursive(_Underlying *_this);
            return __JPH_CompoundShape_GetSubShapeIDBitsRecursive(_UnderlyingPtr);
        }

        // See Shape::GetWorldSpaceBounds
        /// Generated from method `JPH::CompoundShape::GetWorldSpaceBounds`.
        public unsafe JPH.AABox GetWorldSpaceBounds(JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetWorldSpaceBounds_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetWorldSpaceBounds_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_CompoundShape_GetWorldSpaceBounds_JPH_Mat44(_Underlying *_this, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale);
            return new(__JPH_CompoundShape_GetWorldSpaceBounds_JPH_Mat44(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetInnerRadius
        /// Generated from method `JPH::CompoundShape::GetInnerRadius`.
        public unsafe float GetInnerRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_CompoundShape_GetInnerRadius(_Underlying *_this);
            return __JPH_CompoundShape_GetInnerRadius(_UnderlyingPtr);
        }

        // See Shape::GetMaterial
        /// Generated from method `JPH::CompoundShape::GetMaterial`.
        public unsafe JPH.Const_PhysicsMaterial? GetMaterial(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_PhysicsMaterial._Underlying *__JPH_CompoundShape_GetMaterial(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            var __c_ret = __JPH_CompoundShape_GetMaterial(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
        }

        // See Shape::GetLeafShape
        /// Generated from method `JPH::CompoundShape::GetLeafShape`.
        public unsafe JPH.Const_Shape? GetLeafShape(JPH.Const_SubShapeID inSubShapeID, JPH.SubShapeID outRemainder)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_CompoundShape_GetLeafShape(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.SubShapeID._Underlying *outRemainder);
            var __c_ret = __JPH_CompoundShape_GetLeafShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_Shape(__c_ret, is_owning: false) : null;
        }

        // See Shape::GetSubShapeUserData
        /// Generated from method `JPH::CompoundShape::GetSubShapeUserData`.
        public unsafe ulong GetSubShapeUserData(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __JPH_CompoundShape_GetSubShapeUserData(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            return __JPH_CompoundShape_GetSubShapeUserData(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
        }

        // See Shape::GetSubShapeTransformedShape
        /// Generated from method `JPH::CompoundShape::GetSubShapeTransformedShape`.
        public unsafe JPH.TransformedShape GetSubShapeTransformedShape(JPH.Const_SubShapeID inSubShapeID, JPH.Const_Vec3 inPositionCOM, JPH.Const_Quat inRotation, JPH.Const_Vec3 inScale, JPH.SubShapeID outRemainder)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapeTransformedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapeTransformedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TransformedShape._Underlying *__JPH_CompoundShape_GetSubShapeTransformedShape(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.Vec3._Underlying *inPositionCOM, JPH.Quat._Underlying *inRotation, JPH.Vec3._Underlying *inScale, JPH.SubShapeID._Underlying *outRemainder);
            return new(__JPH_CompoundShape_GetSubShapeTransformedShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, inPositionCOM._UnderlyingPtr, inRotation._UnderlyingPtr, inScale._UnderlyingPtr, outRemainder._UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetSurfaceNormal
        /// Generated from method `JPH::CompoundShape::GetSurfaceNormal`.
        public unsafe JPH.Vec3 GetSurfaceNormal(JPH.Const_SubShapeID inSubShapeID, JPH.Const_Vec3 inLocalSurfacePosition)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_CompoundShape_GetSurfaceNormal(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.Vec3._Underlying *inLocalSurfacePosition);
            return new(__JPH_CompoundShape_GetSurfaceNormal(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, inLocalSurfacePosition._UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetSubmergedVolume
        /// Generated from method `JPH::CompoundShape::GetSubmergedVolume`.
        public unsafe void GetSubmergedVolume(JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale, JPH.Const_Plane inSurface, ref float outTotalVolume, ref float outSubmergedVolume, JPH.Vec3 outCenterOfBuoyancy, JPH.Const_Vec3 inBaseOffset)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetSubmergedVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetSubmergedVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShape_GetSubmergedVolume(_Underlying *_this, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale, JPH.Const_Plane._Underlying *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH.Vec3._Underlying *outCenterOfBuoyancy, JPH.Vec3._Underlying *inBaseOffset);
            fixed (float *__ptr_outTotalVolume = &outTotalVolume)
            {
                fixed (float *__ptr_outSubmergedVolume = &outSubmergedVolume)
                {
                    __JPH_CompoundShape_GetSubmergedVolume(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr, inSurface._UnderlyingPtr, __ptr_outTotalVolume, __ptr_outSubmergedVolume, outCenterOfBuoyancy._UnderlyingPtr, inBaseOffset._UnderlyingPtr);
                }
            }
        }

        // See Shape::Draw
        /// Generated from method `JPH::CompoundShape::Draw`.
        public unsafe void Draw(JPH.DebugRenderer? inRenderer, JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale, JPH.Const_Color inColor, bool inUseMaterialColors, bool inDrawWireframe)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_Draw", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_Draw", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShape_Draw(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale, JPH.Color._Underlying *inColor, byte inUseMaterialColors, byte inDrawWireframe);
            __JPH_CompoundShape_Draw(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr, inColor._UnderlyingPtr, inUseMaterialColors ? (byte)1 : (byte)0, inDrawWireframe ? (byte)1 : (byte)0);
        }

        // See Shape::DrawGetSupportFunction
        /// Generated from method `JPH::CompoundShape::DrawGetSupportFunction`.
        public unsafe void DrawGetSupportFunction(JPH.DebugRenderer? inRenderer, JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale, JPH.Const_Color inColor, bool inDrawSupportDirection)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_DrawGetSupportFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_DrawGetSupportFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShape_DrawGetSupportFunction(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale, JPH.Color._Underlying *inColor, byte inDrawSupportDirection);
            __JPH_CompoundShape_DrawGetSupportFunction(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr, inColor._UnderlyingPtr, inDrawSupportDirection ? (byte)1 : (byte)0);
        }

        // See Shape::DrawGetSupportingFace
        /// Generated from method `JPH::CompoundShape::DrawGetSupportingFace`.
        public unsafe void DrawGetSupportingFace(JPH.DebugRenderer? inRenderer, JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_DrawGetSupportingFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_DrawGetSupportingFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShape_DrawGetSupportingFace(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale);
            __JPH_CompoundShape_DrawGetSupportingFace(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr);
        }

        // See Shape::GetTrianglesStart
        /// Generated from method `JPH::CompoundShape::GetTrianglesStart`.
        public unsafe void GetTrianglesStart(JPH.Shape.GetTrianglesContext ioContext, JPH.Const_AABox inBox, JPH.Const_Vec3 inPositionCOM, JPH.Const_Quat inRotation, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShape_GetTrianglesStart(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, JPH.Const_AABox._Underlying *inBox, JPH.Vec3._Underlying *inPositionCOM, JPH.Quat._Underlying *inRotation, JPH.Vec3._Underlying *inScale);
            __JPH_CompoundShape_GetTrianglesStart(_UnderlyingPtr, ioContext._UnderlyingPtr, inBox._UnderlyingPtr, inPositionCOM._UnderlyingPtr, inRotation._UnderlyingPtr, inScale._UnderlyingPtr);
        }

        // See Shape::GetTrianglesNext
        /// Generated from method `JPH::CompoundShape::GetTrianglesNext`.
        public unsafe int GetTrianglesNext(JPH.Shape.GetTrianglesContext ioContext, int inMaxTrianglesRequested, JPH.Float3? outTriangleVertices, void **outMaterials = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_CompoundShape_GetTrianglesNext(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, int inMaxTrianglesRequested, JPH.Float3._Underlying *outTriangleVertices, void **outMaterials);
            return __JPH_CompoundShape_GetTrianglesNext(_UnderlyingPtr, ioContext._UnderlyingPtr, inMaxTrianglesRequested, outTriangleVertices is not null ? outTriangleVertices._UnderlyingPtr : null, outMaterials);
        }

        /// Get which sub shape's bounding boxes overlap with an axis aligned box
        /// @param inBox The axis aligned box to test against (relative to the center of mass of this shape)
        /// @param outSubShapeIndices Buffer where to place the indices of the sub shapes that intersect
        /// @param inMaxSubShapeIndices How many indices will fit in the buffer (normally you'd provide a buffer of GetNumSubShapes() indices)
        /// @return How many indices were placed in outSubShapeIndices
        /// Generated from method `JPH::CompoundShape::GetIntersectingSubShapes`.
        public unsafe int GetIntersectingSubShapes(JPH.Const_AABox inBox, JPH.InOut<uint>? outSubShapeIndices, int inMaxSubShapeIndices)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetIntersectingSubShapes_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetIntersectingSubShapes_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_CompoundShape_GetIntersectingSubShapes_JPH_AABox(_Underlying *_this, JPH.Const_AABox._Underlying *inBox, uint *outSubShapeIndices, int inMaxSubShapeIndices);
            uint __value_outSubShapeIndices = outSubShapeIndices is not null ? outSubShapeIndices.Value : default(uint);
            var __c_ret = __JPH_CompoundShape_GetIntersectingSubShapes_JPH_AABox(_UnderlyingPtr, inBox._UnderlyingPtr, outSubShapeIndices is not null ? &__value_outSubShapeIndices : null, inMaxSubShapeIndices);
            if (outSubShapeIndices is not null) outSubShapeIndices.Value = __value_outSubShapeIndices;
            return __c_ret;
        }

        /// Access to the sub shapes of this compound
        /// Generated from method `JPH::CompoundShape::GetSubShapes`.
        public unsafe JPH.Const_Array_JPHCompoundShapeSubShape GetSubShapes()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Array_JPHCompoundShapeSubShape._Underlying *__JPH_CompoundShape_GetSubShapes(_Underlying *_this);
            return new(__JPH_CompoundShape_GetSubShapes(_UnderlyingPtr), is_owning: false);
        }

        /// Get the total number of sub shapes
        /// Generated from method `JPH::CompoundShape::GetNumSubShapes`.
        public unsafe uint GetNumSubShapes()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetNumSubShapes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetNumSubShapes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_CompoundShape_GetNumSubShapes(_Underlying *_this);
            return __JPH_CompoundShape_GetNumSubShapes(_UnderlyingPtr);
        }

        /// Access to a particular sub shape
        /// Generated from method `JPH::CompoundShape::GetSubShape`.
        public unsafe JPH.CompoundShape.Const_SubShape GetSubShape(uint inIdx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetSubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetSubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CompoundShape.Const_SubShape._Underlying *__JPH_CompoundShape_GetSubShape(_Underlying *_this, uint inIdx);
            return new(__JPH_CompoundShape_GetSubShape(_UnderlyingPtr, inIdx), is_owning: false);
        }

        /// Get the user data associated with a shape in this compound
        /// Generated from method `JPH::CompoundShape::GetCompoundUserData`.
        public unsafe uint GetCompoundUserData(uint inIdx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetCompoundUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetCompoundUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_CompoundShape_GetCompoundUserData(_Underlying *_this, uint inIdx);
            return __JPH_CompoundShape_GetCompoundUserData(_UnderlyingPtr, inIdx);
        }

        /// Check if a sub shape ID is still valid for this shape
        /// @param inSubShapeID Sub shape id that indicates the leaf shape relative to this shape
        /// @return True if the ID is valid, false if not
        /// Generated from method `JPH::CompoundShape::IsSubShapeIDValid`.
        public unsafe bool IsSubShapeIDValid(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_IsSubShapeIDValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_IsSubShapeIDValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_CompoundShape_IsSubShapeIDValid(_Underlying *_this, JPH.SubShapeID._Underlying *inSubShapeID);
            return __JPH_CompoundShape_IsSubShapeIDValid(_UnderlyingPtr, inSubShapeID._UnderlyingPtr) != 0;
        }

        /// Convert SubShapeID to sub shape index
        /// @param inSubShapeID Sub shape id that indicates the leaf shape relative to this shape
        /// @param outRemainder This is the sub shape ID for the sub shape of the compound after popping off the index
        /// @return The index of the sub shape of this compound
        /// Generated from method `JPH::CompoundShape::GetSubShapeIndexFromID`.
        public unsafe uint GetSubShapeIndexFromID(JPH.Const_SubShapeID inSubShapeID, JPH.SubShapeID outRemainder)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapeIndexFromID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapeIndexFromID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_CompoundShape_GetSubShapeIndexFromID(_Underlying *_this, JPH.SubShapeID._Underlying *inSubShapeID, JPH.SubShapeID._Underlying *outRemainder);
            return __JPH_CompoundShape_GetSubShapeIndexFromID(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
        }

        /// @brief Convert a sub shape index to a sub shape ID
        /// @param inIdx Index of the sub shape of this compound
        /// @param inParentSubShapeID Parent SubShapeID (describing the path to the compound shape)
        /// @return A sub shape ID creator that contains the full path to the sub shape with index inIdx
        /// Generated from method `JPH::CompoundShape::GetSubShapeIDFromIndex`.
        public unsafe JPH.SubShapeIDCreator GetSubShapeIDFromIndex(int inIdx, JPH.Const_SubShapeIDCreator inParentSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapeIDFromIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapeIDFromIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SubShapeIDCreator._Underlying *__JPH_CompoundShape_GetSubShapeIDFromIndex(_Underlying *_this, int inIdx, JPH.Const_SubShapeIDCreator._Underlying *inParentSubShapeID);
            return new(__JPH_CompoundShape_GetSubShapeIDFromIndex(_UnderlyingPtr, inIdx, inParentSubShapeID._UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetVolume
        /// Generated from method `JPH::CompoundShape::GetVolume`.
        public unsafe float GetVolume()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_CompoundShape_GetVolume(_Underlying *_this);
            return __JPH_CompoundShape_GetVolume(_UnderlyingPtr);
        }

        // See Shape::IsValidScale
        /// Generated from method `JPH::CompoundShape::IsValidScale`.
        public unsafe bool IsValidScale(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_CompoundShape_IsValidScale(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return __JPH_CompoundShape_IsValidScale(_UnderlyingPtr, inScale._UnderlyingPtr) != 0;
        }

        // See Shape::MakeScaleValid
        /// Generated from method `JPH::CompoundShape::MakeScaleValid`.
        public unsafe JPH.Vec3 MakeScaleValid(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_CompoundShape_MakeScaleValid(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return new(__JPH_CompoundShape_MakeScaleValid(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        // Register shape functions with the registry
        /// Generated from method `JPH::CompoundShape::sRegister`.
        public static void SRegister()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShape_sRegister();
            __JPH_CompoundShape_sRegister();
        }

        /// User data (to be used freely by the application)
        /// Generated from method `JPH::CompoundShape::GetUserData`.
        public unsafe ulong GetUserData()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __JPH_CompoundShape_GetUserData(_Underlying *_this);
            return __JPH_CompoundShape_GetUserData(_UnderlyingPtr);
        }

        /// Get stats of this shape. Use for logging / data collection purposes only. Does not add values from child shapes, use GetStatsRecursive for this.
        /// Generated from method `JPH::CompoundShape::GetStats`.
        public unsafe JPH.Shape.Stats GetStats()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape.Stats._Underlying *__JPH_CompoundShape_GetStats(_Underlying *_this);
            return new(__JPH_CompoundShape_GetStats(_UnderlyingPtr), is_owning: true);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::CompoundShape::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShape_SetEmbedded(_Underlying *_this);
            __JPH_CompoundShape_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::CompoundShape::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_CompoundShape_GetRefCount(_Underlying *_this);
            return __JPH_CompoundShape_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::CompoundShape::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShape_AddRef(_Underlying *_this);
            __JPH_CompoundShape_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::CompoundShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShape_Release(_Underlying *_this);
            __JPH_CompoundShape_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::CompoundShape::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_CompoundShape_sInternalGetRefCountOffset();
            return __JPH_CompoundShape_sInternalGetRefCountOffset();
        }

        /// Generated from class `JPH::CompoundShape::SubShape`.
        /// This is the const half of the class.
        public class Const_SubShape : JPH.Object<Const_SubShape>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CompoundShape_SubShape_Destroy(_Underlying *_this);
                __JPH_CompoundShape_SubShape_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_SubShape() {Dispose(false);}

            ///< Note: Position of center of mass of sub shape!
            public unsafe JPH.Const_Float3 mPositionCOM
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_Get_mPositionCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_Get_mPositionCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Float3._Underlying *__JPH_CompoundShape_SubShape_Get_mPositionCOM(_Underlying *_this);
                    JPH.Const_Float3 __ret;
                    __ret = new(__JPH_CompoundShape_SubShape_Get_mPositionCOM(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Note: X, Y, Z of rotation quaternion - note we read 4 bytes beyond this so make sure there's something there
            public unsafe JPH.Const_Float3 mRotation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_Get_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_Get_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Float3._Underlying *__JPH_CompoundShape_SubShape_Get_mRotation(_Underlying *_this);
                    JPH.Const_Float3 __ret;
                    __ret = new(__JPH_CompoundShape_SubShape_Get_mRotation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< User data value (put here because it falls in padding bytes)
            public unsafe uint mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_CompoundShape_SubShape_Get_mUserData(_Underlying *_this);
                    return *__JPH_CompoundShape_SubShape_Get_mUserData(_UnderlyingPtr);
                }
            }

            ///< If mRotation is close to identity (put here because it falls in padding bytes)
            public unsafe bool mIsRotationIdentity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_Get_mIsRotationIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_Get_mIsRotationIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_CompoundShape_SubShape_Get_mIsRotationIdentity(_Underlying *_this);
                    return *__JPH_CompoundShape_SubShape_Get_mIsRotationIdentity(_UnderlyingPtr);
                }
            }

            internal unsafe Const_SubShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_SubShape() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.CompoundShape.SubShape._Underlying *__JPH_CompoundShape_SubShape_DefaultConstruct();
                _UnderlyingPtr = __JPH_CompoundShape_SubShape_DefaultConstruct();
            }

            /// Generated from constructor `JPH::CompoundShape::SubShape::SubShape`.
            public unsafe Const_SubShape(JPH.CompoundShape._ByValue_SubShape _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.CompoundShape.SubShape._Underlying *__JPH_CompoundShape_SubShape_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.CompoundShape.SubShape._Underlying *_other);
                _UnderlyingPtr = __JPH_CompoundShape_SubShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::CompoundShape::SubShape::SubShape`.
            public Const_SubShape(Const_SubShape _other) : this(new _ByValue_SubShape(_other)) {}

            /// Generated from constructor `JPH::CompoundShape::SubShape::SubShape`.
            public Const_SubShape(SubShape _other) : this((Const_SubShape)_other) {}

            /// Get the local transform for this shape given the scale of the child shape
            /// The total transform of the child shape will be GetLocalTransformNoScale(inScale) * Mat44::sScaling(TransformScale(inScale))
            /// @param inScale The scale of the child shape (in local space of this shape)
            /// Generated from method `JPH::CompoundShape::SubShape::GetLocalTransformNoScale`.
            public unsafe JPH.Mat44 GetLocalTransformNoScale(JPH.Const_Vec3 inScale)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_GetLocalTransformNoScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_GetLocalTransformNoScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Mat44._Underlying *__JPH_CompoundShape_SubShape_GetLocalTransformNoScale(_Underlying *_this, JPH.Vec3._Underlying *inScale);
                return new(__JPH_CompoundShape_SubShape_GetLocalTransformNoScale(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
            }

            /// Test if inScale is valid for this sub shape
            /// Generated from method `JPH::CompoundShape::SubShape::IsValidScale`.
            public unsafe bool IsValidScale(JPH.Const_Vec3 inScale)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_CompoundShape_SubShape_IsValidScale(_Underlying *_this, JPH.Vec3._Underlying *inScale);
                return __JPH_CompoundShape_SubShape_IsValidScale(_UnderlyingPtr, inScale._UnderlyingPtr) != 0;
            }

            /// Transform the scale to the local space of the child shape
            /// Generated from method `JPH::CompoundShape::SubShape::TransformScale`.
            public unsafe JPH.Vec3 TransformScale(JPH.Const_Vec3 inScale)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_TransformScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_TransformScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_CompoundShape_SubShape_TransformScale(_Underlying *_this, JPH.Vec3._Underlying *inScale);
                return new(__JPH_CompoundShape_SubShape_TransformScale(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
            }

            /// Uncompress the center of mass position
            /// Generated from method `JPH::CompoundShape::SubShape::GetPositionCOM`.
            public unsafe JPH.Vec3 GetPositionCOM()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_GetPositionCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_GetPositionCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_CompoundShape_SubShape_GetPositionCOM(_Underlying *_this);
                return new(__JPH_CompoundShape_SubShape_GetPositionCOM(_UnderlyingPtr), is_owning: true);
            }

            /// Uncompress the rotation
            /// Generated from method `JPH::CompoundShape::SubShape::GetRotation`.
            public unsafe JPH.Quat GetRotation()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Quat._Underlying *__JPH_CompoundShape_SubShape_GetRotation(_Underlying *_this);
                return new(__JPH_CompoundShape_SubShape_GetRotation(_UnderlyingPtr), is_owning: true);
            }
        }

        /// Generated from class `JPH::CompoundShape::SubShape`.
        /// This is the non-const half of the class.
        public class SubShape : Const_SubShape
        {
            ///< Note: Position of center of mass of sub shape!
            public new unsafe JPH.Float3 mPositionCOM
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_GetMutable_mPositionCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_GetMutable_mPositionCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Float3._Underlying *__JPH_CompoundShape_SubShape_GetMutable_mPositionCOM(_Underlying *_this);
                    JPH.Float3 __ret;
                    __ret = new(__JPH_CompoundShape_SubShape_GetMutable_mPositionCOM(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Note: X, Y, Z of rotation quaternion - note we read 4 bytes beyond this so make sure there's something there
            public new unsafe JPH.Float3 mRotation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_GetMutable_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_GetMutable_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Float3._Underlying *__JPH_CompoundShape_SubShape_GetMutable_mRotation(_Underlying *_this);
                    JPH.Float3 __ret;
                    __ret = new(__JPH_CompoundShape_SubShape_GetMutable_mRotation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< User data value (put here because it falls in padding bytes)
            public new unsafe ref uint mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_CompoundShape_SubShape_GetMutable_mUserData(_Underlying *_this);
                    return ref *__JPH_CompoundShape_SubShape_GetMutable_mUserData(_UnderlyingPtr);
                }
            }

            ///< If mRotation is close to identity (put here because it falls in padding bytes)
            public new unsafe ref bool mIsRotationIdentity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_GetMutable_mIsRotationIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_GetMutable_mIsRotationIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_CompoundShape_SubShape_GetMutable_mIsRotationIdentity(_Underlying *_this);
                    return ref *__JPH_CompoundShape_SubShape_GetMutable_mIsRotationIdentity(_UnderlyingPtr);
                }
            }

            internal unsafe SubShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe SubShape() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.CompoundShape.SubShape._Underlying *__JPH_CompoundShape_SubShape_DefaultConstruct();
                _UnderlyingPtr = __JPH_CompoundShape_SubShape_DefaultConstruct();
            }

            /// Generated from constructor `JPH::CompoundShape::SubShape::SubShape`.
            public unsafe SubShape(JPH.CompoundShape._ByValue_SubShape _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.CompoundShape.SubShape._Underlying *__JPH_CompoundShape_SubShape_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.CompoundShape.SubShape._Underlying *_other);
                _UnderlyingPtr = __JPH_CompoundShape_SubShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::CompoundShape::SubShape::SubShape`.
            public SubShape(Const_SubShape _other) : this(new _ByValue_SubShape(_other)) {}

            /// Generated from constructor `JPH::CompoundShape::SubShape::SubShape`.
            public SubShape(SubShape _other) : this((Const_SubShape)_other) {}

            /// Generated from method `JPH::CompoundShape::SubShape::operator=`.
            public unsafe JPH.CompoundShape.SubShape Assign(JPH.CompoundShape._ByValue_SubShape _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.CompoundShape.SubShape._Underlying *__JPH_CompoundShape_SubShape_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.CompoundShape.SubShape._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_CompoundShape_SubShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }

            /// Update the transform of this sub shape
            /// @param inPosition New position
            /// @param inRotation New orientation
            /// @param inCenterOfMass The center of mass of the compound shape
            /// Generated from method `JPH::CompoundShape::SubShape::SetTransform`.
            public unsafe void SetTransform(JPH.Const_Vec3 inPosition, JPH.Const_Quat inRotation, JPH.Const_Vec3 inCenterOfMass)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_SetTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_SetTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CompoundShape_SubShape_SetTransform(_Underlying *_this, JPH.Vec3._Underlying *inPosition, JPH.Quat._Underlying *inRotation, JPH.Vec3._Underlying *inCenterOfMass);
                __JPH_CompoundShape_SubShape_SetTransform(_UnderlyingPtr, inPosition._UnderlyingPtr, inRotation._UnderlyingPtr, inCenterOfMass._UnderlyingPtr);
            }

            /// Compress the center of mass position
            /// Generated from method `JPH::CompoundShape::SubShape::SetPositionCOM`.
            public unsafe void SetPositionCOM(JPH.Const_Vec3 inPositionCOM)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_SetPositionCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_SetPositionCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CompoundShape_SubShape_SetPositionCOM(_Underlying *_this, JPH.Vec3._Underlying *inPositionCOM);
                __JPH_CompoundShape_SubShape_SetPositionCOM(_UnderlyingPtr, inPositionCOM._UnderlyingPtr);
            }

            /// Compress the rotation
            /// Generated from method `JPH::CompoundShape::SubShape::SetRotation`.
            public unsafe void SetRotation(JPH.Const_Quat inRotation)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CompoundShape_SubShape_SetRotation(_Underlying *_this, JPH.Quat._Underlying *inRotation);
                __JPH_CompoundShape_SubShape_SetRotation(_UnderlyingPtr, inRotation._UnderlyingPtr);
            }
        }

        /// This is used as a function parameter when the underlying function receives `SubShape` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `SubShape`/`Const_SubShape` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_SubShape
        {
            #pragma warning disable CS0649
            internal readonly Const_SubShape? Value;
            #pragma warning restore CS0649
            internal readonly JPH._PassBy PassByMode;
            public _ByValue_SubShape() {PassByMode = JPH._PassBy.default_construct;}
            public _ByValue_SubShape(Const_SubShape new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
            public static implicit operator _ByValue_SubShape(Const_SubShape arg) {return new(arg);}
            public _ByValue_SubShape(JPH._Moved<SubShape> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
            public static implicit operator _ByValue_SubShape(JPH._Moved<SubShape> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `SubShape` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_SubShape`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `SubShape`/`Const_SubShape` directly.
        public class _InOptMut_SubShape
        {
            public SubShape? Opt;

            public _InOptMut_SubShape() {}
            public _InOptMut_SubShape(SubShape value) {Opt = value;}
            public static implicit operator _InOptMut_SubShape(SubShape value) {return new(value);}
        }

        /// This is used for optional parameters of class `SubShape` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_SubShape`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `SubShape`/`Const_SubShape` to pass it to the function.
        public class _InOptConst_SubShape
        {
            public Const_SubShape? Opt;

            public _InOptConst_SubShape() {}
            public _InOptConst_SubShape(Const_SubShape value) {Opt = value;}
            public static implicit operator _InOptConst_SubShape(Const_SubShape value) {return new(value);}
        }
    }

    /// Base class for a compound shape
    /// Generated from class `JPH::CompoundShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Shape`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::MutableCompoundShape`
    ///     `JPH::StaticCompoundShape`
    /// This is the non-const half of the class.
    public class CompoundShape : Const_CompoundShape
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHShape(CompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShape._Underlying *__JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.RefTarget_JPHShape ret = new(__JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShape(CompoundShape self)
            => (JPH.Const_RefTarget_JPHShape)(JPH.Const_CompoundShape)self;
        public static unsafe implicit operator JPH.NonCopyable(CompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_CompoundShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_CompoundShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(CompoundShape self)
            => (JPH.Const_NonCopyable)(JPH.Const_CompoundShape)self;
        public static unsafe implicit operator JPH.Shape(CompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape._Underlying *__JPH_CompoundShape_UpcastTo_JPH_Shape(_Underlying *_this);
            JPH.Shape ret = new(__JPH_CompoundShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Shape(CompoundShape self)
            => (JPH.Const_Shape)(JPH.Const_CompoundShape)self;

        // Downcasts:
        public static unsafe explicit operator CompoundShape(JPH.RefTarget_JPHShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CompoundShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH.RefTarget_JPHShape._Underlying *_this);
            CompoundShape ret = new(__JPH_CompoundShape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator CompoundShape(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CompoundShape_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            CompoundShape ret = new(__JPH_CompoundShape_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator CompoundShape(JPH.Shape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_StaticDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_StaticDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CompoundShape_StaticDowncastFrom_JPH_Shape(JPH.Shape._Underlying *_this);
            CompoundShape ret = new(__JPH_CompoundShape_StaticDowncastFrom_JPH_Shape(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe CompoundShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Set the user data associated with a shape in this compound
        /// Generated from method `JPH::CompoundShape::SetCompoundUserData`.
        public unsafe void SetCompoundUserData(uint inIdx, uint inUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SetCompoundUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SetCompoundUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShape_SetCompoundUserData(_Underlying *_this, uint inIdx, uint inUserData);
            __JPH_CompoundShape_SetCompoundUserData(_UnderlyingPtr, inIdx, inUserData);
        }

        /// Generated from method `JPH::CompoundShape::SetUserData`.
        public unsafe void SetUserData(ulong inUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CompoundShape_SetUserData(_Underlying *_this, ulong inUserData);
            __JPH_CompoundShape_SetUserData(_UnderlyingPtr, inUserData);
        }
    }

    /// This is used for optional parameters of class `CompoundShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_CompoundShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CompoundShape`/`Const_CompoundShape` directly.
    public class _InOptMut_CompoundShape
    {
        public CompoundShape? Opt;

        public _InOptMut_CompoundShape() {}
        public _InOptMut_CompoundShape(CompoundShape value) {Opt = value;}
        public static implicit operator _InOptMut_CompoundShape(CompoundShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `CompoundShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_CompoundShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CompoundShape`/`Const_CompoundShape` to pass it to the function.
    public class _InOptConst_CompoundShape
    {
        public Const_CompoundShape? Opt;

        public _InOptConst_CompoundShape() {}
        public _InOptConst_CompoundShape(Const_CompoundShape value) {Opt = value;}
        public static implicit operator _InOptConst_CompoundShape(Const_CompoundShape value) {return new(value);}
    }
}
