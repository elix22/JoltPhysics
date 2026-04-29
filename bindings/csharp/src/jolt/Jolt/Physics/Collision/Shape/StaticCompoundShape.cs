// machine generated, do not edit
public static partial class JPH
{
    /// Class that constructs a StaticCompoundShape. Note that if you only want a compound of 1 shape, use a RotatedTranslatedShape instead.
    /// Generated from class `JPH::StaticCompoundShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CompoundShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    ///     `JPH::ShapeSettings`
    /// This is the const half of the class.
    public class Const_StaticCompoundShapeSettings : JPH.Object<Const_StaticCompoundShapeSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_Release(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_Release(__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_StaticCompoundShapeSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_StaticCompoundShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShapeSettings(Const_StaticCompoundShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShapeSettings._Underlying *__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHShapeSettings ret = new(__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ShapeSettings(Const_StaticCompoundShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ShapeSettings._Underlying *__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_ShapeSettings ret = new(__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_CompoundShapeSettings(Const_StaticCompoundShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_CompoundShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_CompoundShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_CompoundShapeSettings._Underlying *__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_CompoundShapeSettings(_Underlying *_this);
            JPH.Const_CompoundShapeSettings ret = new(__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_CompoundShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        /// User data (to be used freely by the application)
        public unsafe UIntPtr mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static UIntPtr *__JPH_StaticCompoundShapeSettings_Get_mUserData(_Underlying *_this);
                return *__JPH_StaticCompoundShapeSettings_Get_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe Const_StaticCompoundShapeSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_StaticCompoundShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.StaticCompoundShapeSettings._Underlying *__JPH_StaticCompoundShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_StaticCompoundShapeSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::StaticCompoundShapeSettings::StaticCompoundShapeSettings`.
        public unsafe Const_StaticCompoundShapeSettings(JPH._ByValue_StaticCompoundShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.StaticCompoundShapeSettings._Underlying *__JPH_StaticCompoundShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.StaticCompoundShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_StaticCompoundShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::StaticCompoundShapeSettings::StaticCompoundShapeSettings`.
        public Const_StaticCompoundShapeSettings(Const_StaticCompoundShapeSettings _other) : this(new _ByValue_StaticCompoundShapeSettings(_other)) {}

        /// Generated from constructor `JPH::StaticCompoundShapeSettings::StaticCompoundShapeSettings`.
        public Const_StaticCompoundShapeSettings(StaticCompoundShapeSettings _other) : this((Const_StaticCompoundShapeSettings)_other) {}

        /// Generated from method `JPH::StaticCompoundShapeSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_StaticCompoundShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_StaticCompoundShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_StaticCompoundShapeSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_StaticCompoundShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::StaticCompoundShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::StaticCompoundShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::StaticCompoundShapeSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_StaticCompoundShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_StaticCompoundShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_StaticCompoundShapeSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_StaticCompoundShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::StaticCompoundShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::StaticCompoundShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::StaticCompoundShapeSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_StaticCompoundShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_StaticCompoundShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_StaticCompoundShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_StaticCompoundShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::StaticCompoundShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_StaticCompoundShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::StaticCompoundShapeSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_StaticCompoundShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_StaticCompoundShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_StaticCompoundShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_StaticCompoundShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::StaticCompoundShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_StaticCompoundShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::StaticCompoundShapeSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_StaticCompoundShapeSettings_SetEmbedded(_Underlying *_this);
            __JPH_StaticCompoundShapeSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::StaticCompoundShapeSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_StaticCompoundShapeSettings_GetRefCount(_Underlying *_this);
            return __JPH_StaticCompoundShapeSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::StaticCompoundShapeSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_StaticCompoundShapeSettings_AddRef(_Underlying *_this);
            __JPH_StaticCompoundShapeSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::StaticCompoundShapeSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_StaticCompoundShapeSettings_Release(_Underlying *_this);
            __JPH_StaticCompoundShapeSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::StaticCompoundShapeSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_StaticCompoundShapeSettings_sInternalGetRefCountOffset();
            return __JPH_StaticCompoundShapeSettings_sInternalGetRefCountOffset();
        }
    }

    /// Class that constructs a StaticCompoundShape. Note that if you only want a compound of 1 shape, use a RotatedTranslatedShape instead.
    /// Generated from class `JPH::StaticCompoundShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CompoundShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    ///     `JPH::ShapeSettings`
    /// This is the non-const half of the class.
    public class StaticCompoundShapeSettings : Const_StaticCompoundShapeSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(StaticCompoundShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.RefTarget_JPHShapeSettings(StaticCompoundShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.RefTarget_JPHShapeSettings ret = new(__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ShapeSettings(StaticCompoundShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeSettings._Underlying *__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
            JPH.ShapeSettings ret = new(__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.CompoundShapeSettings(StaticCompoundShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_CompoundShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_CompoundShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CompoundShapeSettings._Underlying *__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_CompoundShapeSettings(_Underlying *_this);
            JPH.CompoundShapeSettings ret = new(__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_CompoundShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        /// User data (to be used freely by the application)
        public new unsafe ref UIntPtr mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static UIntPtr *__JPH_StaticCompoundShapeSettings_GetMutable_mUserData(_Underlying *_this);
                return ref *__JPH_StaticCompoundShapeSettings_GetMutable_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe StaticCompoundShapeSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe StaticCompoundShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.StaticCompoundShapeSettings._Underlying *__JPH_StaticCompoundShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_StaticCompoundShapeSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::StaticCompoundShapeSettings::StaticCompoundShapeSettings`.
        public unsafe StaticCompoundShapeSettings(JPH._ByValue_StaticCompoundShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.StaticCompoundShapeSettings._Underlying *__JPH_StaticCompoundShapeSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.StaticCompoundShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_StaticCompoundShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_AddRef(__JPH_StaticCompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::StaticCompoundShapeSettings::StaticCompoundShapeSettings`.
        public StaticCompoundShapeSettings(Const_StaticCompoundShapeSettings _other) : this(new _ByValue_StaticCompoundShapeSettings(_other)) {}

        /// Generated from constructor `JPH::StaticCompoundShapeSettings::StaticCompoundShapeSettings`.
        public StaticCompoundShapeSettings(StaticCompoundShapeSettings _other) : this((Const_StaticCompoundShapeSettings)_other) {}

        /// Generated from method `JPH::StaticCompoundShapeSettings::operator=`.
        public unsafe JPH.StaticCompoundShapeSettings Assign(JPH._ByValue_StaticCompoundShapeSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.StaticCompoundShapeSettings._Underlying *__JPH_StaticCompoundShapeSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.StaticCompoundShapeSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_StaticCompoundShapeSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// When creating a shape, the result is cached so that calling Create() again will return the same shape.
        /// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
        /// Generated from method `JPH::StaticCompoundShapeSettings::ClearCachedResult`.
        public unsafe void ClearCachedResult()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_StaticCompoundShapeSettings_ClearCachedResult(_Underlying *_this);
            __JPH_StaticCompoundShapeSettings_ClearCachedResult(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `StaticCompoundShapeSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `StaticCompoundShapeSettings`/`Const_StaticCompoundShapeSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_StaticCompoundShapeSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_StaticCompoundShapeSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_StaticCompoundShapeSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_StaticCompoundShapeSettings(Const_StaticCompoundShapeSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_StaticCompoundShapeSettings(Const_StaticCompoundShapeSettings arg) {return new(arg);}
        public _ByValue_StaticCompoundShapeSettings(JPH._Moved<StaticCompoundShapeSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_StaticCompoundShapeSettings(JPH._Moved<StaticCompoundShapeSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `StaticCompoundShapeSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_StaticCompoundShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `StaticCompoundShapeSettings`/`Const_StaticCompoundShapeSettings` directly.
    public class _InOptMut_StaticCompoundShapeSettings
    {
        public StaticCompoundShapeSettings? Opt;

        public _InOptMut_StaticCompoundShapeSettings() {}
        public _InOptMut_StaticCompoundShapeSettings(StaticCompoundShapeSettings value) {Opt = value;}
        public static implicit operator _InOptMut_StaticCompoundShapeSettings(StaticCompoundShapeSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `StaticCompoundShapeSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_StaticCompoundShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `StaticCompoundShapeSettings`/`Const_StaticCompoundShapeSettings` to pass it to the function.
    public class _InOptConst_StaticCompoundShapeSettings
    {
        public Const_StaticCompoundShapeSettings? Opt;

        public _InOptConst_StaticCompoundShapeSettings() {}
        public _InOptConst_StaticCompoundShapeSettings(Const_StaticCompoundShapeSettings value) {Opt = value;}
        public static implicit operator _InOptConst_StaticCompoundShapeSettings(Const_StaticCompoundShapeSettings value) {return new(value);}
    }

    /// A compound shape, sub shapes can be rotated and translated.
    /// Sub shapes cannot be modified once the shape is constructed.
    /// Shifts all child objects so that they're centered around the center of mass.
    /// Generated from class `JPH::StaticCompoundShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CompoundShape`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    ///     `JPH::Shape`
    /// This is the const half of the class.
    public class Const_StaticCompoundShape : JPH.Object<Const_StaticCompoundShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_Release(void *_this);
            __JPH_RefTarget_JPH_Shape_Release(__JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_StaticCompoundShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShape(Const_StaticCompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShape._Underlying *__JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.Const_RefTarget_JPHShape ret = new(__JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_StaticCompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_StaticCompoundShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_StaticCompoundShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Shape(Const_StaticCompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_StaticCompoundShape_UpcastTo_JPH_Shape(_Underlying *_this);
            JPH.Const_Shape ret = new(__JPH_StaticCompoundShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_CompoundShape(Const_StaticCompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_CompoundShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_CompoundShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_CompoundShape._Underlying *__JPH_StaticCompoundShape_UpcastTo_JPH_CompoundShape(_Underlying *_this);
            JPH.Const_CompoundShape ret = new(__JPH_StaticCompoundShape_UpcastTo_JPH_CompoundShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        /// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
        public static unsafe int CGetTrianglesMinTrianglesRequested
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_StaticCompoundShape_Get_cGetTrianglesMinTrianglesRequested();
                return *__JPH_StaticCompoundShape_Get_cGetTrianglesMinTrianglesRequested();
            }
        }

        internal unsafe Const_StaticCompoundShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_StaticCompoundShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.StaticCompoundShape._Underlying *__JPH_StaticCompoundShape_DefaultConstruct();
            _UnderlyingPtr = __JPH_StaticCompoundShape_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_AddRef(void *_this);
            __JPH_RefTarget_JPH_Shape_AddRef(__JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
        }

        /// Generated from method `JPH::StaticCompoundShape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_StaticCompoundShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_StaticCompoundShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_StaticCompoundShape_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_StaticCompoundShape_size_t(inCount);
        }

        /// Generated from method `JPH::StaticCompoundShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_StaticCompoundShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_StaticCompoundShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_StaticCompoundShape_void_ptr(void *inPointer);
            __Jolt_delete_JPH_StaticCompoundShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::StaticCompoundShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_StaticCompoundShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_StaticCompoundShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_StaticCompoundShape_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_StaticCompoundShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::StaticCompoundShape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_StaticCompoundShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_StaticCompoundShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_StaticCompoundShape_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_StaticCompoundShape_size_t(inCount);
        }

        /// Generated from method `JPH::StaticCompoundShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_StaticCompoundShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_StaticCompoundShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_StaticCompoundShape_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_StaticCompoundShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::StaticCompoundShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_StaticCompoundShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_StaticCompoundShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_StaticCompoundShape_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_StaticCompoundShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::StaticCompoundShape::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_StaticCompoundShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_StaticCompoundShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_StaticCompoundShape_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_StaticCompoundShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::StaticCompoundShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_StaticCompoundShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_StaticCompoundShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_StaticCompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_StaticCompoundShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::StaticCompoundShape::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_StaticCompoundShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_StaticCompoundShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_StaticCompoundShape_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_StaticCompoundShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::StaticCompoundShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_StaticCompoundShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_StaticCompoundShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_StaticCompoundShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_StaticCompoundShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        // See: CompoundShape::GetIntersectingSubShapes
        /// Generated from method `JPH::StaticCompoundShape::GetIntersectingSubShapes`.
        public unsafe int GetIntersectingSubShapes(JPH.Const_AABox inBox, JPH.InOut<uint>? outSubShapeIndices, int inMaxSubShapeIndices)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetIntersectingSubShapes_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetIntersectingSubShapes_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_StaticCompoundShape_GetIntersectingSubShapes_JPH_AABox(_Underlying *_this, JPH.Const_AABox._Underlying *inBox, uint *outSubShapeIndices, int inMaxSubShapeIndices);
            uint __value_outSubShapeIndices = outSubShapeIndices is not null ? outSubShapeIndices.Value : default(uint);
            var __c_ret = __JPH_StaticCompoundShape_GetIntersectingSubShapes_JPH_AABox(_UnderlyingPtr, inBox._UnderlyingPtr, outSubShapeIndices is not null ? &__value_outSubShapeIndices : null, inMaxSubShapeIndices);
            if (outSubShapeIndices is not null) outSubShapeIndices.Value = __value_outSubShapeIndices;
            return __c_ret;
        }

        // See Shape::GetStats
        /// Generated from method `JPH::StaticCompoundShape::GetStats`.
        public unsafe JPH.Shape.Stats GetStats()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape.Stats._Underlying *__JPH_StaticCompoundShape_GetStats(_Underlying *_this);
            return new(__JPH_StaticCompoundShape_GetStats(_UnderlyingPtr), is_owning: true);
        }

        // Register shape functions with the registry
        /// Generated from method `JPH::StaticCompoundShape::sRegister`.
        public static void SRegister()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_StaticCompoundShape_sRegister();
            __JPH_StaticCompoundShape_sRegister();
        }

        // See Shape::GetCenterOfMass
        /// Generated from method `JPH::StaticCompoundShape::GetCenterOfMass`.
        public unsafe JPH.Vec3 GetCenterOfMass()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_StaticCompoundShape_GetCenterOfMass(_Underlying *_this);
            return new(__JPH_StaticCompoundShape_GetCenterOfMass(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::MustBeStatic
        /// Generated from method `JPH::StaticCompoundShape::MustBeStatic`.
        public unsafe bool MustBeStatic()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_StaticCompoundShape_MustBeStatic(_Underlying *_this);
            return __JPH_StaticCompoundShape_MustBeStatic(_UnderlyingPtr) != 0;
        }

        // See Shape::GetLocalBounds
        /// Generated from method `JPH::StaticCompoundShape::GetLocalBounds`.
        public unsafe JPH.AABox GetLocalBounds()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_StaticCompoundShape_GetLocalBounds(_Underlying *_this);
            return new(__JPH_StaticCompoundShape_GetLocalBounds(_UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetSubShapeIDBitsRecursive
        /// Generated from method `JPH::StaticCompoundShape::GetSubShapeIDBitsRecursive`.
        public unsafe uint GetSubShapeIDBitsRecursive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_StaticCompoundShape_GetSubShapeIDBitsRecursive(_Underlying *_this);
            return __JPH_StaticCompoundShape_GetSubShapeIDBitsRecursive(_UnderlyingPtr);
        }

        // See Shape::GetInnerRadius
        /// Generated from method `JPH::StaticCompoundShape::GetInnerRadius`.
        public unsafe float GetInnerRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_StaticCompoundShape_GetInnerRadius(_Underlying *_this);
            return __JPH_StaticCompoundShape_GetInnerRadius(_UnderlyingPtr);
        }

        // See Shape::GetMaterial
        /// Generated from method `JPH::StaticCompoundShape::GetMaterial`.
        public unsafe JPH.Const_PhysicsMaterial? GetMaterial(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_PhysicsMaterial._Underlying *__JPH_StaticCompoundShape_GetMaterial(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            var __c_ret = __JPH_StaticCompoundShape_GetMaterial(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
        }

        // See Shape::GetLeafShape
        /// Generated from method `JPH::StaticCompoundShape::GetLeafShape`.
        public unsafe JPH.Const_Shape? GetLeafShape(JPH.Const_SubShapeID inSubShapeID, JPH.SubShapeID outRemainder)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_StaticCompoundShape_GetLeafShape(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.SubShapeID._Underlying *outRemainder);
            var __c_ret = __JPH_StaticCompoundShape_GetLeafShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_Shape(__c_ret, is_owning: false) : null;
        }

        // See Shape::GetSubShapeUserData
        /// Generated from method `JPH::StaticCompoundShape::GetSubShapeUserData`.
        public unsafe UIntPtr GetSubShapeUserData(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_StaticCompoundShape_GetSubShapeUserData(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            return __JPH_StaticCompoundShape_GetSubShapeUserData(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
        }

        // See Shape::GetSurfaceNormal
        /// Generated from method `JPH::StaticCompoundShape::GetSurfaceNormal`.
        public unsafe JPH.Vec3 GetSurfaceNormal(JPH.Const_SubShapeID inSubShapeID, JPH.Const_Vec3 inLocalSurfacePosition)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_StaticCompoundShape_GetSurfaceNormal(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.Vec3._Underlying *inLocalSurfacePosition);
            return new(__JPH_StaticCompoundShape_GetSurfaceNormal(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, inLocalSurfacePosition._UnderlyingPtr), is_owning: true);
        }

        // See Shape::GetSubmergedVolume
        /// Generated from method `JPH::StaticCompoundShape::GetSubmergedVolume`.
        public unsafe void GetSubmergedVolume(JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale, JPH.Const_Plane inSurface, ref float outTotalVolume, ref float outSubmergedVolume, JPH.Vec3 outCenterOfBuoyancy)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetSubmergedVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetSubmergedVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_StaticCompoundShape_GetSubmergedVolume(_Underlying *_this, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale, JPH.Const_Plane._Underlying *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH.Vec3._Underlying *outCenterOfBuoyancy);
            fixed (float *__ptr_outTotalVolume = &outTotalVolume)
            {
                fixed (float *__ptr_outSubmergedVolume = &outSubmergedVolume)
                {
                    __JPH_StaticCompoundShape_GetSubmergedVolume(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr, inSurface._UnderlyingPtr, __ptr_outTotalVolume, __ptr_outSubmergedVolume, outCenterOfBuoyancy._UnderlyingPtr);
                }
            }
        }

        // See Shape::GetTrianglesStart
        /// Generated from method `JPH::StaticCompoundShape::GetTrianglesStart`.
        public unsafe void GetTrianglesStart(JPH.Shape.GetTrianglesContext ioContext, JPH.Const_AABox inBox, JPH.Const_Vec3 inPositionCOM, JPH.Const_Quat inRotation, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_StaticCompoundShape_GetTrianglesStart(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, JPH.Const_AABox._Underlying *inBox, JPH.Vec3._Underlying *inPositionCOM, JPH.Quat._Underlying *inRotation, JPH.Vec3._Underlying *inScale);
            __JPH_StaticCompoundShape_GetTrianglesStart(_UnderlyingPtr, ioContext._UnderlyingPtr, inBox._UnderlyingPtr, inPositionCOM._UnderlyingPtr, inRotation._UnderlyingPtr, inScale._UnderlyingPtr);
        }

        // See Shape::GetTrianglesNext
        /// Generated from method `JPH::StaticCompoundShape::GetTrianglesNext`.
        public unsafe int GetTrianglesNext(JPH.Shape.GetTrianglesContext ioContext, int inMaxTrianglesRequested, JPH.Float3? outTriangleVertices, void **outMaterials = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_StaticCompoundShape_GetTrianglesNext(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, int inMaxTrianglesRequested, JPH.Float3._Underlying *outTriangleVertices, void **outMaterials);
            return __JPH_StaticCompoundShape_GetTrianglesNext(_UnderlyingPtr, ioContext._UnderlyingPtr, inMaxTrianglesRequested, outTriangleVertices is not null ? outTriangleVertices._UnderlyingPtr : null, outMaterials);
        }

        /// Get the total number of sub shapes
        /// Generated from method `JPH::StaticCompoundShape::GetNumSubShapes`.
        public unsafe uint GetNumSubShapes()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetNumSubShapes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetNumSubShapes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_StaticCompoundShape_GetNumSubShapes(_Underlying *_this);
            return __JPH_StaticCompoundShape_GetNumSubShapes(_UnderlyingPtr);
        }

        /// Access to a particular sub shape
        /// Generated from method `JPH::StaticCompoundShape::GetSubShape`.
        public unsafe JPH.CompoundShape.Const_SubShape GetSubShape(uint inIdx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetSubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetSubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CompoundShape.Const_SubShape._Underlying *__JPH_StaticCompoundShape_GetSubShape(_Underlying *_this, uint inIdx);
            return new(__JPH_StaticCompoundShape_GetSubShape(_UnderlyingPtr, inIdx), is_owning: false);
        }

        /// Get the user data associated with a shape in this compound
        /// Generated from method `JPH::StaticCompoundShape::GetCompoundUserData`.
        public unsafe uint GetCompoundUserData(uint inIdx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetCompoundUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetCompoundUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_StaticCompoundShape_GetCompoundUserData(_Underlying *_this, uint inIdx);
            return __JPH_StaticCompoundShape_GetCompoundUserData(_UnderlyingPtr, inIdx);
        }

        /// Check if a sub shape ID is still valid for this shape
        /// @param inSubShapeID Sub shape id that indicates the leaf shape relative to this shape
        /// @return True if the ID is valid, false if not
        /// Generated from method `JPH::StaticCompoundShape::IsSubShapeIDValid`.
        public unsafe bool IsSubShapeIDValid(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_IsSubShapeIDValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_IsSubShapeIDValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_StaticCompoundShape_IsSubShapeIDValid(_Underlying *_this, JPH.SubShapeID._Underlying *inSubShapeID);
            return __JPH_StaticCompoundShape_IsSubShapeIDValid(_UnderlyingPtr, inSubShapeID._UnderlyingPtr) != 0;
        }

        /// Convert SubShapeID to sub shape index
        /// @param inSubShapeID Sub shape id that indicates the leaf shape relative to this shape
        /// @param outRemainder This is the sub shape ID for the sub shape of the compound after popping off the index
        /// @return The index of the sub shape of this compound
        /// Generated from method `JPH::StaticCompoundShape::GetSubShapeIndexFromID`.
        public unsafe uint GetSubShapeIndexFromID(JPH.Const_SubShapeID inSubShapeID, JPH.SubShapeID outRemainder)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetSubShapeIndexFromID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetSubShapeIndexFromID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_StaticCompoundShape_GetSubShapeIndexFromID(_Underlying *_this, JPH.SubShapeID._Underlying *inSubShapeID, JPH.SubShapeID._Underlying *outRemainder);
            return __JPH_StaticCompoundShape_GetSubShapeIndexFromID(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
        }

        // See Shape::GetVolume
        /// Generated from method `JPH::StaticCompoundShape::GetVolume`.
        public unsafe float GetVolume()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_StaticCompoundShape_GetVolume(_Underlying *_this);
            return __JPH_StaticCompoundShape_GetVolume(_UnderlyingPtr);
        }

        // See Shape::IsValidScale
        /// Generated from method `JPH::StaticCompoundShape::IsValidScale`.
        public unsafe bool IsValidScale(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_StaticCompoundShape_IsValidScale(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return __JPH_StaticCompoundShape_IsValidScale(_UnderlyingPtr, inScale._UnderlyingPtr) != 0;
        }

        // See Shape::MakeScaleValid
        /// Generated from method `JPH::StaticCompoundShape::MakeScaleValid`.
        public unsafe JPH.Vec3 MakeScaleValid(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_StaticCompoundShape_MakeScaleValid(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return new(__JPH_StaticCompoundShape_MakeScaleValid(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// User data (to be used freely by the application)
        /// Generated from method `JPH::StaticCompoundShape::GetUserData`.
        public unsafe UIntPtr GetUserData()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_StaticCompoundShape_GetUserData(_Underlying *_this);
            return __JPH_StaticCompoundShape_GetUserData(_UnderlyingPtr);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::StaticCompoundShape::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_StaticCompoundShape_SetEmbedded(_Underlying *_this);
            __JPH_StaticCompoundShape_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::StaticCompoundShape::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_StaticCompoundShape_GetRefCount(_Underlying *_this);
            return __JPH_StaticCompoundShape_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::StaticCompoundShape::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_StaticCompoundShape_AddRef(_Underlying *_this);
            __JPH_StaticCompoundShape_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::StaticCompoundShape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_StaticCompoundShape_Release(_Underlying *_this);
            __JPH_StaticCompoundShape_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::StaticCompoundShape::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_StaticCompoundShape_sInternalGetRefCountOffset();
            return __JPH_StaticCompoundShape_sInternalGetRefCountOffset();
        }
    }

    /// A compound shape, sub shapes can be rotated and translated.
    /// Sub shapes cannot be modified once the shape is constructed.
    /// Shifts all child objects so that they're centered around the center of mass.
    /// Generated from class `JPH::StaticCompoundShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CompoundShape`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    ///     `JPH::Shape`
    /// This is the non-const half of the class.
    public class StaticCompoundShape : Const_StaticCompoundShape
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHShape(StaticCompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShape._Underlying *__JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.RefTarget_JPHShape ret = new(__JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.NonCopyable(StaticCompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_StaticCompoundShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_StaticCompoundShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Shape(StaticCompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape._Underlying *__JPH_StaticCompoundShape_UpcastTo_JPH_Shape(_Underlying *_this);
            JPH.Shape ret = new(__JPH_StaticCompoundShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.CompoundShape(StaticCompoundShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_CompoundShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_CompoundShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CompoundShape._Underlying *__JPH_StaticCompoundShape_UpcastTo_JPH_CompoundShape(_Underlying *_this);
            JPH.CompoundShape ret = new(__JPH_StaticCompoundShape_UpcastTo_JPH_CompoundShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe StaticCompoundShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe StaticCompoundShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.StaticCompoundShape._Underlying *__JPH_StaticCompoundShape_DefaultConstruct();
            _UnderlyingPtr = __JPH_StaticCompoundShape_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_AddRef(void *_this);
            __JPH_RefTarget_JPH_Shape_AddRef(__JPH_StaticCompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
        }

        /// Set the user data associated with a shape in this compound
        /// Generated from method `JPH::StaticCompoundShape::SetCompoundUserData`.
        public unsafe void SetCompoundUserData(uint inIdx, uint inUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_SetCompoundUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_SetCompoundUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_StaticCompoundShape_SetCompoundUserData(_Underlying *_this, uint inIdx, uint inUserData);
            __JPH_StaticCompoundShape_SetCompoundUserData(_UnderlyingPtr, inIdx, inUserData);
        }

        /// Generated from method `JPH::StaticCompoundShape::SetUserData`.
        public unsafe void SetUserData(UIntPtr inUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_StaticCompoundShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_StaticCompoundShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_StaticCompoundShape_SetUserData(_Underlying *_this, UIntPtr inUserData);
            __JPH_StaticCompoundShape_SetUserData(_UnderlyingPtr, inUserData);
        }
    }

    /// This is used as a function parameter when the underlying function receives `StaticCompoundShape` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_StaticCompoundShape
    {
        #pragma warning disable CS0649
        internal readonly Const_StaticCompoundShape? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_StaticCompoundShape() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `StaticCompoundShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_StaticCompoundShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `StaticCompoundShape`/`Const_StaticCompoundShape` directly.
    public class _InOptMut_StaticCompoundShape
    {
        public StaticCompoundShape? Opt;

        public _InOptMut_StaticCompoundShape() {}
        public _InOptMut_StaticCompoundShape(StaticCompoundShape value) {Opt = value;}
        public static implicit operator _InOptMut_StaticCompoundShape(StaticCompoundShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `StaticCompoundShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_StaticCompoundShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `StaticCompoundShape`/`Const_StaticCompoundShape` to pass it to the function.
    public class _InOptConst_StaticCompoundShape
    {
        public Const_StaticCompoundShape? Opt;

        public _InOptConst_StaticCompoundShape() {}
        public _InOptConst_StaticCompoundShape(Const_StaticCompoundShape value) {Opt = value;}
        public static implicit operator _InOptConst_StaticCompoundShape(Const_StaticCompoundShape value) {return new(value);}
    }
}
