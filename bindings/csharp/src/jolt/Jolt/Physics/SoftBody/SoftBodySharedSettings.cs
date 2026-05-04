// machine generated, do not edit
public static partial class JPH
{
    /// This class defines the setup of all particles and their constraints.
    /// It is used during the simulation and can be shared between multiple soft bodies.
    /// Generated from class `JPH::SoftBodySharedSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::SoftBodySharedSettings>`
    /// This is the const half of the class.
    public class Const_SoftBodySharedSettings : JPH.Object<Const_SoftBodySharedSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SoftBodySharedSettings_Release(void *_this);
            __JPH_RefTarget_JPH_SoftBodySharedSettings_Release(__JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SoftBodySharedSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHSoftBodySharedSettings(Const_SoftBodySharedSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHSoftBodySharedSettings._Underlying *__JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHSoftBodySharedSettings ret = new(__JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_SoftBodySharedSettings(JPH.Const_RefTarget_JPHSoftBodySharedSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_StaticDowncastFrom_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_StaticDowncastFrom_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SoftBodySharedSettings_StaticDowncastFrom_JPH_RefTarget_JPH_SoftBodySharedSettings(JPH.Const_RefTarget_JPHSoftBodySharedSettings._Underlying *_this);
            Const_SoftBodySharedSettings ret = new(__JPH_SoftBodySharedSettings_StaticDowncastFrom_JPH_RefTarget_JPH_SoftBodySharedSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_SoftBodySharedSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_SoftBodySharedSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings._Underlying *__JPH_SoftBodySharedSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_SoftBodySharedSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef(__JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::SoftBodySharedSettings::SoftBodySharedSettings`.
        public unsafe Const_SoftBodySharedSettings(JPH._ByValue_SoftBodySharedSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings._Underlying *__JPH_SoftBodySharedSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SoftBodySharedSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_SoftBodySharedSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef(__JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::SoftBodySharedSettings::SoftBodySharedSettings`.
        public Const_SoftBodySharedSettings(Const_SoftBodySharedSettings _other) : this(new _ByValue_SoftBodySharedSettings(_other)) {}

        /// Generated from constructor `JPH::SoftBodySharedSettings::SoftBodySharedSettings`.
        public Const_SoftBodySharedSettings(SoftBodySharedSettings _other) : this((Const_SoftBodySharedSettings)_other) {}

        /// Generated from method `JPH::SoftBodySharedSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SoftBodySharedSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_SoftBodySharedSettings_size_t(inCount);
        }

        /// Generated from method `JPH::SoftBodySharedSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SoftBodySharedSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_SoftBodySharedSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SoftBodySharedSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SoftBodySharedSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_SoftBodySharedSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SoftBodySharedSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_SoftBodySharedSettings_size_t(inCount);
        }

        /// Generated from method `JPH::SoftBodySharedSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SoftBodySharedSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SoftBodySharedSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SoftBodySharedSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_SoftBodySharedSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SoftBodySharedSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SoftBodySharedSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_SoftBodySharedSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::SoftBodySharedSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_SoftBodySharedSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SoftBodySharedSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::SoftBodySharedSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodySharedSettings_SetEmbedded(_Underlying *_this);
            __JPH_SoftBodySharedSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::SoftBodySharedSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SoftBodySharedSettings_GetRefCount(_Underlying *_this);
            return __JPH_SoftBodySharedSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::SoftBodySharedSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodySharedSettings_AddRef(_Underlying *_this);
            __JPH_SoftBodySharedSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SoftBodySharedSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodySharedSettings_Release(_Underlying *_this);
            __JPH_SoftBodySharedSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::SoftBodySharedSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_SoftBodySharedSettings_sInternalGetRefCountOffset();
            return __JPH_SoftBodySharedSettings_sInternalGetRefCountOffset();
        }

        /**
        * A dihedral bend constraint keeps the angle between two triangles constant along their shared edge.
        *
        *        x2
        *       /  \
        *      / t0 \
        *     x0----x1
        *      \ t1 /
        *       \  /
        *        x3
        *
        * x0..x3 are the vertices, t0 and t1 are the triangles that share the edge x0..x1
        *
        * Based on:
        * - "Position Based Dynamics" - Matthias Muller et al.
        * - "Strain Based Dynamics" - Matthias Muller et al.
        * - "Simulation of Clothing with Folds and Wrinkles" - R. Bridson et al.
        */
        /// Generated from class `JPH::SoftBodySharedSettings::DihedralBend`.
        /// This is the const half of the class.
        public class Const_DihedralBend : JPH.Object<Const_DihedralBend>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodySharedSettings_DihedralBend_Destroy(_Underlying *_this);
                __JPH_SoftBodySharedSettings_DihedralBend_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_DihedralBend() {Dispose(false);}

            ///< Indices of the vertices of the 2 triangles that share an edge (the first 2 vertices are the shared edge)
            public unsafe ref JPH.ArrayUnsignedInt4 mVertex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_Get_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_Get_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedInt4 *__JPH_SoftBodySharedSettings_DihedralBend_Get_mVertex(_Underlying *_this);
                    return ref *(__JPH_SoftBodySharedSettings_DihedralBend_Get_mVertex(_UnderlyingPtr));
                }
            }

            ///< Inverse of the stiffness of the constraint
            public unsafe float mCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_Get_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_Get_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_DihedralBend_Get_mCompliance(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_DihedralBend_Get_mCompliance(_UnderlyingPtr);
                }
            }

            ///< Initial angle between the normals of the triangles (pi - dihedral angle), calculated by CalculateBendConstraintConstants
            public unsafe float mInitialAngle
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_Get_mInitialAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_Get_mInitialAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_DihedralBend_Get_mInitialAngle(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_DihedralBend_Get_mInitialAngle(_UnderlyingPtr);
                }
            }

            internal unsafe Const_DihedralBend(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_DihedralBend() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.DihedralBend._Underlying *__JPH_SoftBodySharedSettings_DihedralBend_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_DihedralBend_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::DihedralBend::DihedralBend`.
            public unsafe Const_DihedralBend(JPH.SoftBodySharedSettings.Const_DihedralBend _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.DihedralBend._Underlying *__JPH_SoftBodySharedSettings_DihedralBend_ConstructFromAnother(JPH.SoftBodySharedSettings.DihedralBend._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_DihedralBend_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::DihedralBend::DihedralBend`.
            public Const_DihedralBend(DihedralBend _other) : this((Const_DihedralBend)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::DihedralBend::DihedralBend`.
            /// Parameter `inCompliance` defaults to `0.0f`.
            public unsafe Const_DihedralBend(uint inVertex1, uint inVertex2, uint inVertex3, uint inVertex4, float? inCompliance = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.DihedralBend._Underlying *__JPH_SoftBodySharedSettings_DihedralBend_Construct(uint inVertex1, uint inVertex2, uint inVertex3, uint inVertex4, float *inCompliance);
                float __deref_inCompliance = inCompliance.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_DihedralBend_Construct(inVertex1, inVertex2, inVertex3, inVertex4, inCompliance.HasValue ? &__deref_inCompliance : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_DihedralBend_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_DihedralBend_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_DihedralBend_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_SoftBodySharedSettings_DihedralBend_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_DihedralBend_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_DihedralBend_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_DihedralBend_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_DihedralBend_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_DihedralBend_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_DihedralBend_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_DihedralBend_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_SoftBodySharedSettings_DihedralBend_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_DihedralBend_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_DihedralBend_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_DihedralBend_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_DihedralBend_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Return the lowest vertex index of this constraint
            /// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::GetMinVertexIndex`.
            public unsafe uint GetMinVertexIndex()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_GetMinVertexIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_GetMinVertexIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_SoftBodySharedSettings_DihedralBend_GetMinVertexIndex(_Underlying *_this);
                return __JPH_SoftBodySharedSettings_DihedralBend_GetMinVertexIndex(_UnderlyingPtr);
            }
        }

        /**
        * A dihedral bend constraint keeps the angle between two triangles constant along their shared edge.
        *
        *        x2
        *       /  \
        *      / t0 \
        *     x0----x1
        *      \ t1 /
        *       \  /
        *        x3
        *
        * x0..x3 are the vertices, t0 and t1 are the triangles that share the edge x0..x1
        *
        * Based on:
        * - "Position Based Dynamics" - Matthias Muller et al.
        * - "Strain Based Dynamics" - Matthias Muller et al.
        * - "Simulation of Clothing with Folds and Wrinkles" - R. Bridson et al.
        */
        /// Generated from class `JPH::SoftBodySharedSettings::DihedralBend`.
        /// This is the non-const half of the class.
        public class DihedralBend : Const_DihedralBend
        {
            ///< Indices of the vertices of the 2 triangles that share an edge (the first 2 vertices are the shared edge)
            new public unsafe ref JPH.ArrayUnsignedInt4 mVertex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedInt4 *__JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mVertex(_Underlying *_this);
                    return ref *(__JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mVertex(_UnderlyingPtr));
                }
            }

            ///< Inverse of the stiffness of the constraint
            public new unsafe ref float mCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mCompliance(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mCompliance(_UnderlyingPtr);
                }
            }

            ///< Initial angle between the normals of the triangles (pi - dihedral angle), calculated by CalculateBendConstraintConstants
            public new unsafe ref float mInitialAngle
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mInitialAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mInitialAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mInitialAngle(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mInitialAngle(_UnderlyingPtr);
                }
            }

            internal unsafe DihedralBend(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe DihedralBend() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.DihedralBend._Underlying *__JPH_SoftBodySharedSettings_DihedralBend_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_DihedralBend_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::DihedralBend::DihedralBend`.
            public unsafe DihedralBend(JPH.SoftBodySharedSettings.Const_DihedralBend _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.DihedralBend._Underlying *__JPH_SoftBodySharedSettings_DihedralBend_ConstructFromAnother(JPH.SoftBodySharedSettings.DihedralBend._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_DihedralBend_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::DihedralBend::DihedralBend`.
            public DihedralBend(DihedralBend _other) : this((Const_DihedralBend)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::DihedralBend::DihedralBend`.
            /// Parameter `inCompliance` defaults to `0.0f`.
            public unsafe DihedralBend(uint inVertex1, uint inVertex2, uint inVertex3, uint inVertex4, float? inCompliance = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.DihedralBend._Underlying *__JPH_SoftBodySharedSettings_DihedralBend_Construct(uint inVertex1, uint inVertex2, uint inVertex3, uint inVertex4, float *inCompliance);
                float __deref_inCompliance = inCompliance.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_DihedralBend_Construct(inVertex1, inVertex2, inVertex3, inVertex4, inCompliance.HasValue ? &__deref_inCompliance : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::DihedralBend::operator=`.
            public unsafe JPH.SoftBodySharedSettings.DihedralBend Assign(JPH.SoftBodySharedSettings.Const_DihedralBend _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DihedralBend_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.DihedralBend._Underlying *__JPH_SoftBodySharedSettings_DihedralBend_AssignFromAnother(_Underlying *_this, JPH.SoftBodySharedSettings.DihedralBend._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SoftBodySharedSettings_DihedralBend_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `DihedralBend` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_DihedralBend`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `DihedralBend`/`Const_DihedralBend` directly.
        public class _InOptMut_DihedralBend
        {
            public DihedralBend? Opt;

            public _InOptMut_DihedralBend() {}
            public _InOptMut_DihedralBend(DihedralBend value) {Opt = value;}
            public static implicit operator _InOptMut_DihedralBend(DihedralBend value) {return new(value);}
        }

        /// This is used for optional parameters of class `DihedralBend` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_DihedralBend`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `DihedralBend`/`Const_DihedralBend` to pass it to the function.
        public class _InOptConst_DihedralBend
        {
            public Const_DihedralBend? Opt;

            public _InOptConst_DihedralBend() {}
            public _InOptConst_DihedralBend(Const_DihedralBend value) {Opt = value;}
            public static implicit operator _InOptConst_DihedralBend(Const_DihedralBend value) {return new(value);}
        }

        /// Which type of bend constraint should be created
        public enum EBendType : int
        {
            ///< No bend constraints will be created
            None = 0,
            ///< A simple distance constraint
            Distance = 1,
            ///< A dihedral bend constraint (most expensive, but also supports triangles that are initially not in the same plane)
            Dihedral = 2,
        }

        /// The type of long range attachment constraint to create
        public enum ELRAType : int
        {
            ///< Don't create a LRA constraint
            None = 0,
            ///< Create a LRA constraint based on Euclidean distance between the closest kinematic vertex and this vertex
            EuclideanDistance = 1,
            ///< Create a LRA constraint based on the geodesic distance between the closest kinematic vertex and this vertex (follows the edge constraints)
            GeodesicDistance = 2,
        }

        /// An edge keeps two vertices at a constant distance using a spring: |x1 - x2| = rest length
        /// Generated from class `JPH::SoftBodySharedSettings::Edge`.
        /// This is the const half of the class.
        public class Const_Edge : JPH.Object<Const_Edge>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodySharedSettings_Edge_Destroy(_Underlying *_this);
                __JPH_SoftBodySharedSettings_Edge_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Edge() {Dispose(false);}

            ///< Indices of the vertices that form the edge
            public unsafe ref JPH.ArrayUnsignedInt2 mVertex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_Get_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_Get_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedInt2 *__JPH_SoftBodySharedSettings_Edge_Get_mVertex(_Underlying *_this);
                    return ref *(__JPH_SoftBodySharedSettings_Edge_Get_mVertex(_UnderlyingPtr));
                }
            }

            ///< Rest length of the spring, calculated by CalculateEdgeLengths
            public unsafe float mRestLength
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_Get_mRestLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_Get_mRestLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Edge_Get_mRestLength(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_Edge_Get_mRestLength(_UnderlyingPtr);
                }
            }

            ///< Inverse of the stiffness of the spring
            public unsafe float mCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_Get_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_Get_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Edge_Get_mCompliance(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_Edge_Get_mCompliance(_UnderlyingPtr);
                }
            }

            internal unsafe Const_Edge(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Edge() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Edge._Underlying *__JPH_SoftBodySharedSettings_Edge_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Edge_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Edge::Edge`.
            public unsafe Const_Edge(JPH.SoftBodySharedSettings.Const_Edge _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Edge._Underlying *__JPH_SoftBodySharedSettings_Edge_ConstructFromAnother(JPH.SoftBodySharedSettings.Edge._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Edge_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Edge::Edge`.
            public Const_Edge(Edge _other) : this((Const_Edge)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::Edge::Edge`.
            /// Parameter `inCompliance` defaults to `0.0f`.
            public unsafe Const_Edge(uint inVertex1, uint inVertex2, float? inCompliance = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Edge._Underlying *__JPH_SoftBodySharedSettings_Edge_Construct(uint inVertex1, uint inVertex2, float *inCompliance);
                float __deref_inCompliance = inCompliance.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Edge_Construct(inVertex1, inVertex2, inCompliance.HasValue ? &__deref_inCompliance : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Edge::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Edge_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Edge_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_Edge_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_SoftBodySharedSettings_Edge_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Edge::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Edge::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Edge::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Edge_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Edge_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_Edge_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_Edge_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Edge::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Edge::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Edge::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Edge_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Edge_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_Edge_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_SoftBodySharedSettings_Edge_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Edge::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Edge::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Edge_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Edge_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_Edge_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_Edge_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Edge::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Return the lowest vertex index of this constraint
            /// Generated from method `JPH::SoftBodySharedSettings::Edge::GetMinVertexIndex`.
            public unsafe uint GetMinVertexIndex()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_GetMinVertexIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_GetMinVertexIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_SoftBodySharedSettings_Edge_GetMinVertexIndex(_Underlying *_this);
                return __JPH_SoftBodySharedSettings_Edge_GetMinVertexIndex(_UnderlyingPtr);
            }
        }

        /// An edge keeps two vertices at a constant distance using a spring: |x1 - x2| = rest length
        /// Generated from class `JPH::SoftBodySharedSettings::Edge`.
        /// This is the non-const half of the class.
        public class Edge : Const_Edge
        {
            ///< Indices of the vertices that form the edge
            new public unsafe ref JPH.ArrayUnsignedInt2 mVertex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_GetMutable_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_GetMutable_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedInt2 *__JPH_SoftBodySharedSettings_Edge_GetMutable_mVertex(_Underlying *_this);
                    return ref *(__JPH_SoftBodySharedSettings_Edge_GetMutable_mVertex(_UnderlyingPtr));
                }
            }

            ///< Rest length of the spring, calculated by CalculateEdgeLengths
            public new unsafe ref float mRestLength
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_GetMutable_mRestLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_GetMutable_mRestLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Edge_GetMutable_mRestLength(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_Edge_GetMutable_mRestLength(_UnderlyingPtr);
                }
            }

            ///< Inverse of the stiffness of the spring
            public new unsafe ref float mCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_GetMutable_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_GetMutable_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Edge_GetMutable_mCompliance(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_Edge_GetMutable_mCompliance(_UnderlyingPtr);
                }
            }

            internal unsafe Edge(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Edge() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Edge._Underlying *__JPH_SoftBodySharedSettings_Edge_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Edge_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Edge::Edge`.
            public unsafe Edge(JPH.SoftBodySharedSettings.Const_Edge _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Edge._Underlying *__JPH_SoftBodySharedSettings_Edge_ConstructFromAnother(JPH.SoftBodySharedSettings.Edge._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Edge_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Edge::Edge`.
            public Edge(Edge _other) : this((Const_Edge)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::Edge::Edge`.
            /// Parameter `inCompliance` defaults to `0.0f`.
            public unsafe Edge(uint inVertex1, uint inVertex2, float? inCompliance = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Edge._Underlying *__JPH_SoftBodySharedSettings_Edge_Construct(uint inVertex1, uint inVertex2, float *inCompliance);
                float __deref_inCompliance = inCompliance.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Edge_Construct(inVertex1, inVertex2, inCompliance.HasValue ? &__deref_inCompliance : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Edge::operator=`.
            public unsafe JPH.SoftBodySharedSettings.Edge Assign(JPH.SoftBodySharedSettings.Const_Edge _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Edge_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Edge._Underlying *__JPH_SoftBodySharedSettings_Edge_AssignFromAnother(_Underlying *_this, JPH.SoftBodySharedSettings.Edge._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SoftBodySharedSettings_Edge_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `Edge` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Edge`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Edge`/`Const_Edge` directly.
        public class _InOptMut_Edge
        {
            public Edge? Opt;

            public _InOptMut_Edge() {}
            public _InOptMut_Edge(Edge value) {Opt = value;}
            public static implicit operator _InOptMut_Edge(Edge value) {return new(value);}
        }

        /// This is used for optional parameters of class `Edge` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Edge`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Edge`/`Const_Edge` to pass it to the function.
        public class _InOptConst_Edge
        {
            public Const_Edge? Opt;

            public _InOptConst_Edge() {}
            public _InOptConst_Edge(Const_Edge value) {Opt = value;}
            public static implicit operator _InOptConst_Edge(Const_Edge value) {return new(value);}
        }

        /// A face defines the surface of the body
        /// Generated from class `JPH::SoftBodySharedSettings::Face`.
        /// This is the const half of the class.
        public class Const_Face : JPH.Object<Const_Face>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodySharedSettings_Face_Destroy(_Underlying *_this);
                __JPH_SoftBodySharedSettings_Face_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Face() {Dispose(false);}

            ///< Indices of the vertices that form the face
            public unsafe ref JPH.ArrayUnsignedInt3 mVertex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_Get_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_Get_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedInt3 *__JPH_SoftBodySharedSettings_Face_Get_mVertex(_Underlying *_this);
                    return ref *(__JPH_SoftBodySharedSettings_Face_Get_mVertex(_UnderlyingPtr));
                }
            }

            ///< Index of the material of the face in SoftBodySharedSettings::mMaterials
            public unsafe uint mMaterialIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_Get_mMaterialIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_Get_mMaterialIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_SoftBodySharedSettings_Face_Get_mMaterialIndex(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_Face_Get_mMaterialIndex(_UnderlyingPtr);
                }
            }

            internal unsafe Const_Face(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Face() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Face._Underlying *__JPH_SoftBodySharedSettings_Face_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Face_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Face::Face`.
            public unsafe Const_Face(JPH.SoftBodySharedSettings.Const_Face _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Face._Underlying *__JPH_SoftBodySharedSettings_Face_ConstructFromAnother(JPH.SoftBodySharedSettings.Face._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Face_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Face::Face`.
            public Const_Face(Face _other) : this((Const_Face)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::Face::Face`.
            /// Parameter `inMaterialIndex` defaults to `0`.
            public unsafe Const_Face(uint inVertex1, uint inVertex2, uint inVertex3, uint? inMaterialIndex = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Face._Underlying *__JPH_SoftBodySharedSettings_Face_Construct(uint inVertex1, uint inVertex2, uint inVertex3, uint *inMaterialIndex);
                uint __deref_inMaterialIndex = inMaterialIndex.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Face_Construct(inVertex1, inVertex2, inVertex3, inMaterialIndex.HasValue ? &__deref_inMaterialIndex : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Face::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Face_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Face_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_Face_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_SoftBodySharedSettings_Face_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Face::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Face::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Face::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Face_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Face_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_Face_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_Face_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Face::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Face::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Face::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Face_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Face_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_Face_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_SoftBodySharedSettings_Face_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Face::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Face::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Face_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Face_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_Face_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_Face_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Face::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Check if this is a degenerate face (a face which points to the same vertex twice)
            /// Generated from method `JPH::SoftBodySharedSettings::Face::IsDegenerate`.
            public unsafe bool IsDegenerate()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_IsDegenerate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_IsDegenerate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_SoftBodySharedSettings_Face_IsDegenerate(_Underlying *_this);
                return __JPH_SoftBodySharedSettings_Face_IsDegenerate(_UnderlyingPtr) != 0;
            }
        }

        /// A face defines the surface of the body
        /// Generated from class `JPH::SoftBodySharedSettings::Face`.
        /// This is the non-const half of the class.
        public class Face : Const_Face
        {
            ///< Indices of the vertices that form the face
            new public unsafe ref JPH.ArrayUnsignedInt3 mVertex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_GetMutable_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_GetMutable_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedInt3 *__JPH_SoftBodySharedSettings_Face_GetMutable_mVertex(_Underlying *_this);
                    return ref *(__JPH_SoftBodySharedSettings_Face_GetMutable_mVertex(_UnderlyingPtr));
                }
            }

            ///< Index of the material of the face in SoftBodySharedSettings::mMaterials
            public new unsafe ref uint mMaterialIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_GetMutable_mMaterialIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_GetMutable_mMaterialIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_SoftBodySharedSettings_Face_GetMutable_mMaterialIndex(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_Face_GetMutable_mMaterialIndex(_UnderlyingPtr);
                }
            }

            internal unsafe Face(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Face() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Face._Underlying *__JPH_SoftBodySharedSettings_Face_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Face_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Face::Face`.
            public unsafe Face(JPH.SoftBodySharedSettings.Const_Face _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Face._Underlying *__JPH_SoftBodySharedSettings_Face_ConstructFromAnother(JPH.SoftBodySharedSettings.Face._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Face_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Face::Face`.
            public Face(Face _other) : this((Const_Face)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::Face::Face`.
            /// Parameter `inMaterialIndex` defaults to `0`.
            public unsafe Face(uint inVertex1, uint inVertex2, uint inVertex3, uint? inMaterialIndex = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Face._Underlying *__JPH_SoftBodySharedSettings_Face_Construct(uint inVertex1, uint inVertex2, uint inVertex3, uint *inMaterialIndex);
                uint __deref_inMaterialIndex = inMaterialIndex.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Face_Construct(inVertex1, inVertex2, inVertex3, inMaterialIndex.HasValue ? &__deref_inMaterialIndex : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Face::operator=`.
            public unsafe JPH.SoftBodySharedSettings.Face Assign(JPH.SoftBodySharedSettings.Const_Face _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Face_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Face._Underlying *__JPH_SoftBodySharedSettings_Face_AssignFromAnother(_Underlying *_this, JPH.SoftBodySharedSettings.Face._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SoftBodySharedSettings_Face_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `Face` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Face`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Face`/`Const_Face` directly.
        public class _InOptMut_Face
        {
            public Face? Opt;

            public _InOptMut_Face() {}
            public _InOptMut_Face(Face value) {Opt = value;}
            public static implicit operator _InOptMut_Face(Face value) {return new(value);}
        }

        /// This is used for optional parameters of class `Face` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Face`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Face`/`Const_Face` to pass it to the function.
        public class _InOptConst_Face
        {
            public Const_Face? Opt;

            public _InOptConst_Face() {}
            public _InOptConst_Face(Const_Face value) {Opt = value;}
            public static implicit operator _InOptConst_Face(Const_Face value) {return new(value);}
        }

        /// An inverse bind matrix take a skinned vertex from its bind pose into joint local space
        /// Generated from class `JPH::SoftBodySharedSettings::InvBind`.
        /// This is the const half of the class.
        public class Const_InvBind : JPH.Object<Const_InvBind>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodySharedSettings_InvBind_Destroy(_Underlying *_this);
                __JPH_SoftBodySharedSettings_InvBind_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_InvBind() {Dispose(false);}

            ///< Joint index to which this is attached
            public unsafe uint mJointIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_Get_mJointIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_Get_mJointIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_SoftBodySharedSettings_InvBind_Get_mJointIndex(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_InvBind_Get_mJointIndex(_UnderlyingPtr);
                }
            }

            ///< The inverse bind matrix, this takes a vertex in its bind pose (Vertex::mPosition) to joint local space
            public unsafe JPH.Const_Mat44 mInvBind
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_Get_mInvBind", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_Get_mInvBind", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Mat44._Underlying *__JPH_SoftBodySharedSettings_InvBind_Get_mInvBind(_Underlying *_this);
                    JPH.Const_Mat44 __ret;
                    __ret = new(__JPH_SoftBodySharedSettings_InvBind_Get_mInvBind(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Const_InvBind(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_InvBind() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.InvBind._Underlying *__JPH_SoftBodySharedSettings_InvBind_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_InvBind_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::InvBind::InvBind`.
            public unsafe Const_InvBind(JPH.SoftBodySharedSettings.Const_InvBind _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.InvBind._Underlying *__JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother(JPH.SoftBodySharedSettings.InvBind._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::InvBind::InvBind`.
            public Const_InvBind(InvBind _other) : this((Const_InvBind)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::InvBind::InvBind`.
            public unsafe Const_InvBind(uint inJointIndex, JPH.Const_Mat44 inInvBind) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.InvBind._Underlying *__JPH_SoftBodySharedSettings_InvBind_Construct(uint inJointIndex, JPH.Const_Mat44._Underlying *inInvBind);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_InvBind_Construct(inJointIndex, inInvBind._UnderlyingPtr);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_InvBind_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_InvBind_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_InvBind_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_SoftBodySharedSettings_InvBind_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_InvBind_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_InvBind_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_InvBind_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_InvBind_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_InvBind_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_InvBind_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_InvBind_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_SoftBodySharedSettings_InvBind_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_InvBind_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_InvBind_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_InvBind_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_InvBind_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr_void_ptr(inPointer, inPlace);
            }
        }

        /// An inverse bind matrix take a skinned vertex from its bind pose into joint local space
        /// Generated from class `JPH::SoftBodySharedSettings::InvBind`.
        /// This is the non-const half of the class.
        public class InvBind : Const_InvBind
        {
            ///< Joint index to which this is attached
            public new unsafe ref uint mJointIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_GetMutable_mJointIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_GetMutable_mJointIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_SoftBodySharedSettings_InvBind_GetMutable_mJointIndex(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_InvBind_GetMutable_mJointIndex(_UnderlyingPtr);
                }
            }

            ///< The inverse bind matrix, this takes a vertex in its bind pose (Vertex::mPosition) to joint local space
            public new unsafe JPH.Mat44 mInvBind
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_GetMutable_mInvBind", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_GetMutable_mInvBind", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Mat44._Underlying *__JPH_SoftBodySharedSettings_InvBind_GetMutable_mInvBind(_Underlying *_this);
                    JPH.Mat44 __ret;
                    __ret = new(__JPH_SoftBodySharedSettings_InvBind_GetMutable_mInvBind(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe InvBind(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe InvBind() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.InvBind._Underlying *__JPH_SoftBodySharedSettings_InvBind_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_InvBind_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::InvBind::InvBind`.
            public unsafe InvBind(JPH.SoftBodySharedSettings.Const_InvBind _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.InvBind._Underlying *__JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother(JPH.SoftBodySharedSettings.InvBind._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::InvBind::InvBind`.
            public InvBind(InvBind _other) : this((Const_InvBind)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::InvBind::InvBind`.
            public unsafe InvBind(uint inJointIndex, JPH.Const_Mat44 inInvBind) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.InvBind._Underlying *__JPH_SoftBodySharedSettings_InvBind_Construct(uint inJointIndex, JPH.Const_Mat44._Underlying *inInvBind);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_InvBind_Construct(inJointIndex, inInvBind._UnderlyingPtr);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::InvBind::operator=`.
            public unsafe JPH.SoftBodySharedSettings.InvBind Assign(JPH.SoftBodySharedSettings.Const_InvBind _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_InvBind_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.InvBind._Underlying *__JPH_SoftBodySharedSettings_InvBind_AssignFromAnother(_Underlying *_this, JPH.SoftBodySharedSettings.InvBind._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SoftBodySharedSettings_InvBind_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `InvBind` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_InvBind`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `InvBind`/`Const_InvBind` directly.
        public class _InOptMut_InvBind
        {
            public InvBind? Opt;

            public _InOptMut_InvBind() {}
            public _InOptMut_InvBind(InvBind value) {Opt = value;}
            public static implicit operator _InOptMut_InvBind(InvBind value) {return new(value);}
        }

        /// This is used for optional parameters of class `InvBind` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_InvBind`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `InvBind`/`Const_InvBind` to pass it to the function.
        public class _InOptConst_InvBind
        {
            public Const_InvBind? Opt;

            public _InOptConst_InvBind() {}
            public _InOptConst_InvBind(Const_InvBind value) {Opt = value;}
            public static implicit operator _InOptConst_InvBind(Const_InvBind value) {return new(value);}
        }

        /// A long range attachment constraint, this is a constraint that sets a max distance between a kinematic vertex and a dynamic vertex
        /// See: "Long Range Attachments - A Method to Simulate Inextensible Clothing in Computer Games", Tae-Yong Kim, Nuttapong Chentanez and Matthias Mueller-Fischer
        /// Generated from class `JPH::SoftBodySharedSettings::LRA`.
        /// This is the const half of the class.
        public class Const_LRA : JPH.Object<Const_LRA>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodySharedSettings_LRA_Destroy(_Underlying *_this);
                __JPH_SoftBodySharedSettings_LRA_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_LRA() {Dispose(false);}

            ///< The vertices that are connected. The first vertex should be kinematic, the 2nd dynamic.
            public unsafe ref JPH.ArrayUnsignedInt2 mVertex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_Get_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_Get_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedInt2 *__JPH_SoftBodySharedSettings_LRA_Get_mVertex(_Underlying *_this);
                    return ref *(__JPH_SoftBodySharedSettings_LRA_Get_mVertex(_UnderlyingPtr));
                }
            }

            ///< The maximum distance between the vertices, calculated by CalculateLRALengths
            public unsafe float mMaxDistance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_Get_mMaxDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_Get_mMaxDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_LRA_Get_mMaxDistance(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_LRA_Get_mMaxDistance(_UnderlyingPtr);
                }
            }

            internal unsafe Const_LRA(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_LRA() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.LRA._Underlying *__JPH_SoftBodySharedSettings_LRA_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_LRA_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::LRA::LRA`.
            public unsafe Const_LRA(JPH.SoftBodySharedSettings.Const_LRA _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.LRA._Underlying *__JPH_SoftBodySharedSettings_LRA_ConstructFromAnother(JPH.SoftBodySharedSettings.LRA._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_LRA_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::LRA::LRA`.
            public Const_LRA(LRA _other) : this((Const_LRA)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::LRA::LRA`.
            public unsafe Const_LRA(uint inVertex1, uint inVertex2, float inMaxDistance) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.LRA._Underlying *__JPH_SoftBodySharedSettings_LRA_Construct(uint inVertex1, uint inVertex2, float inMaxDistance);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_LRA_Construct(inVertex1, inVertex2, inMaxDistance);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::LRA::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_LRA_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_LRA_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_LRA_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_SoftBodySharedSettings_LRA_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::LRA::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::LRA::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::LRA::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_LRA_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_LRA_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_LRA_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_LRA_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::LRA::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::LRA::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::LRA::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_LRA_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_LRA_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_LRA_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_SoftBodySharedSettings_LRA_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::LRA::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::LRA::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_LRA_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_LRA_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_LRA_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_LRA_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::LRA::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Return the lowest vertex index of this constraint
            /// Generated from method `JPH::SoftBodySharedSettings::LRA::GetMinVertexIndex`.
            public unsafe uint GetMinVertexIndex()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_GetMinVertexIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_GetMinVertexIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_SoftBodySharedSettings_LRA_GetMinVertexIndex(_Underlying *_this);
                return __JPH_SoftBodySharedSettings_LRA_GetMinVertexIndex(_UnderlyingPtr);
            }
        }

        /// A long range attachment constraint, this is a constraint that sets a max distance between a kinematic vertex and a dynamic vertex
        /// See: "Long Range Attachments - A Method to Simulate Inextensible Clothing in Computer Games", Tae-Yong Kim, Nuttapong Chentanez and Matthias Mueller-Fischer
        /// Generated from class `JPH::SoftBodySharedSettings::LRA`.
        /// This is the non-const half of the class.
        public class LRA : Const_LRA
        {
            ///< The vertices that are connected. The first vertex should be kinematic, the 2nd dynamic.
            new public unsafe ref JPH.ArrayUnsignedInt2 mVertex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_GetMutable_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_GetMutable_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedInt2 *__JPH_SoftBodySharedSettings_LRA_GetMutable_mVertex(_Underlying *_this);
                    return ref *(__JPH_SoftBodySharedSettings_LRA_GetMutable_mVertex(_UnderlyingPtr));
                }
            }

            ///< The maximum distance between the vertices, calculated by CalculateLRALengths
            public new unsafe ref float mMaxDistance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_GetMutable_mMaxDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_GetMutable_mMaxDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_LRA_GetMutable_mMaxDistance(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_LRA_GetMutable_mMaxDistance(_UnderlyingPtr);
                }
            }

            internal unsafe LRA(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe LRA() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.LRA._Underlying *__JPH_SoftBodySharedSettings_LRA_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_LRA_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::LRA::LRA`.
            public unsafe LRA(JPH.SoftBodySharedSettings.Const_LRA _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.LRA._Underlying *__JPH_SoftBodySharedSettings_LRA_ConstructFromAnother(JPH.SoftBodySharedSettings.LRA._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_LRA_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::LRA::LRA`.
            public LRA(LRA _other) : this((Const_LRA)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::LRA::LRA`.
            public unsafe LRA(uint inVertex1, uint inVertex2, float inMaxDistance) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.LRA._Underlying *__JPH_SoftBodySharedSettings_LRA_Construct(uint inVertex1, uint inVertex2, float inMaxDistance);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_LRA_Construct(inVertex1, inVertex2, inMaxDistance);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::LRA::operator=`.
            public unsafe JPH.SoftBodySharedSettings.LRA Assign(JPH.SoftBodySharedSettings.Const_LRA _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_LRA_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.LRA._Underlying *__JPH_SoftBodySharedSettings_LRA_AssignFromAnother(_Underlying *_this, JPH.SoftBodySharedSettings.LRA._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SoftBodySharedSettings_LRA_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `LRA` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_LRA`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `LRA`/`Const_LRA` directly.
        public class _InOptMut_LRA
        {
            public LRA? Opt;

            public _InOptMut_LRA() {}
            public _InOptMut_LRA(LRA value) {Opt = value;}
            public static implicit operator _InOptMut_LRA(LRA value) {return new(value);}
        }

        /// This is used for optional parameters of class `LRA` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_LRA`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `LRA`/`Const_LRA` to pass it to the function.
        public class _InOptConst_LRA
        {
            public Const_LRA? Opt;

            public _InOptConst_LRA() {}
            public _InOptConst_LRA(Const_LRA value) {Opt = value;}
            public static implicit operator _InOptConst_LRA(Const_LRA value) {return new(value);}
        }

        /// Information about the optimization of the soft body, the indices of certain elements may have changed.
        /// Generated from class `JPH::SoftBodySharedSettings::OptimizationResults`.
        /// This is the const half of the class.
        public class Const_OptimizationResults : JPH.Object<Const_OptimizationResults>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_OptimizationResults_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_OptimizationResults_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodySharedSettings_OptimizationResults_Destroy(_Underlying *_this);
                __JPH_SoftBodySharedSettings_OptimizationResults_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_OptimizationResults() {Dispose(false);}

            internal unsafe Const_OptimizationResults(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_OptimizationResults() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_OptimizationResults_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_OptimizationResults_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.OptimizationResults._Underlying *__JPH_SoftBodySharedSettings_OptimizationResults_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_OptimizationResults_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::OptimizationResults::OptimizationResults`.
            public unsafe Const_OptimizationResults(JPH.SoftBodySharedSettings._ByValue_OptimizationResults _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_OptimizationResults_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_OptimizationResults_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.OptimizationResults._Underlying *__JPH_SoftBodySharedSettings_OptimizationResults_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SoftBodySharedSettings.OptimizationResults._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_OptimizationResults_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::OptimizationResults::OptimizationResults`.
            public Const_OptimizationResults(Const_OptimizationResults _other) : this(new _ByValue_OptimizationResults(_other)) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::OptimizationResults::OptimizationResults`.
            public Const_OptimizationResults(OptimizationResults _other) : this((Const_OptimizationResults)_other) {}
        }

        /// Information about the optimization of the soft body, the indices of certain elements may have changed.
        /// Generated from class `JPH::SoftBodySharedSettings::OptimizationResults`.
        /// This is the non-const half of the class.
        public class OptimizationResults : Const_OptimizationResults
        {
            internal unsafe OptimizationResults(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe OptimizationResults() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_OptimizationResults_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_OptimizationResults_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.OptimizationResults._Underlying *__JPH_SoftBodySharedSettings_OptimizationResults_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_OptimizationResults_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::OptimizationResults::OptimizationResults`.
            public unsafe OptimizationResults(JPH.SoftBodySharedSettings._ByValue_OptimizationResults _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_OptimizationResults_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_OptimizationResults_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.OptimizationResults._Underlying *__JPH_SoftBodySharedSettings_OptimizationResults_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SoftBodySharedSettings.OptimizationResults._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_OptimizationResults_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::OptimizationResults::OptimizationResults`.
            public OptimizationResults(Const_OptimizationResults _other) : this(new _ByValue_OptimizationResults(_other)) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::OptimizationResults::OptimizationResults`.
            public OptimizationResults(OptimizationResults _other) : this((Const_OptimizationResults)_other) {}

            /// Generated from method `JPH::SoftBodySharedSettings::OptimizationResults::operator=`.
            public unsafe JPH.SoftBodySharedSettings.OptimizationResults Assign(JPH.SoftBodySharedSettings._ByValue_OptimizationResults _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_OptimizationResults_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_OptimizationResults_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.OptimizationResults._Underlying *__JPH_SoftBodySharedSettings_OptimizationResults_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.SoftBodySharedSettings.OptimizationResults._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_SoftBodySharedSettings_OptimizationResults_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }
        }

        /// This is used as a function parameter when the underlying function receives `OptimizationResults` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `OptimizationResults`/`Const_OptimizationResults` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_OptimizationResults
        {
            #pragma warning disable CS0649
            internal readonly Const_OptimizationResults? Value;
            #pragma warning restore CS0649
            internal readonly JPH._PassBy PassByMode;
            public _ByValue_OptimizationResults() {PassByMode = JPH._PassBy.default_construct;}
            public _ByValue_OptimizationResults(Const_OptimizationResults new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
            public static implicit operator _ByValue_OptimizationResults(Const_OptimizationResults arg) {return new(arg);}
            public _ByValue_OptimizationResults(JPH._Moved<OptimizationResults> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
            public static implicit operator _ByValue_OptimizationResults(JPH._Moved<OptimizationResults> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `OptimizationResults` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_OptimizationResults`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `OptimizationResults`/`Const_OptimizationResults` directly.
        public class _InOptMut_OptimizationResults
        {
            public OptimizationResults? Opt;

            public _InOptMut_OptimizationResults() {}
            public _InOptMut_OptimizationResults(OptimizationResults value) {Opt = value;}
            public static implicit operator _InOptMut_OptimizationResults(OptimizationResults value) {return new(value);}
        }

        /// This is used for optional parameters of class `OptimizationResults` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_OptimizationResults`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `OptimizationResults`/`Const_OptimizationResults` to pass it to the function.
        public class _InOptConst_OptimizationResults
        {
            public Const_OptimizationResults? Opt;

            public _InOptConst_OptimizationResults() {}
            public _InOptConst_OptimizationResults(Const_OptimizationResults value) {Opt = value;}
            public static implicit operator _InOptConst_OptimizationResults(Const_OptimizationResults value) {return new(value);}
        }

        /// A constraint that connects two Cosserat rods and limits bend and twist between the rods.
        /// Generated from class `JPH::SoftBodySharedSettings::RodBendTwist`.
        /// This is the const half of the class.
        public class Const_RodBendTwist : JPH.Object<Const_RodBendTwist>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodySharedSettings_RodBendTwist_Destroy(_Underlying *_this);
                __JPH_SoftBodySharedSettings_RodBendTwist_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_RodBendTwist() {Dispose(false);}

            ///< Indices of rods that are constrained (index in mRodStretchShearConstraints)
            public unsafe ref JPH.ArrayUnsignedInt2 mRod
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_Get_mRod", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_Get_mRod", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedInt2 *__JPH_SoftBodySharedSettings_RodBendTwist_Get_mRod(_Underlying *_this);
                    return ref *(__JPH_SoftBodySharedSettings_RodBendTwist_Get_mRod(_UnderlyingPtr));
                }
            }

            ///< Inverse of the stiffness of the rod
            public unsafe float mCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_Get_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_Get_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_RodBendTwist_Get_mCompliance(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_RodBendTwist_Get_mCompliance(_UnderlyingPtr);
                }
            }

            ///< The initial rotation between the rods: rod1.mBishop.Conjugated() * rod2.mBishop, calculated by CalculateRodProperties
            public unsafe JPH.Const_Quat mOmega0
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_Get_mOmega0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_Get_mOmega0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Quat._Underlying *__JPH_SoftBodySharedSettings_RodBendTwist_Get_mOmega0(_Underlying *_this);
                    JPH.Const_Quat __ret;
                    __ret = new(__JPH_SoftBodySharedSettings_RodBendTwist_Get_mOmega0(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Const_RodBendTwist(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_RodBendTwist() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.RodBendTwist._Underlying *__JPH_SoftBodySharedSettings_RodBendTwist_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_RodBendTwist_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::RodBendTwist::RodBendTwist`.
            public unsafe Const_RodBendTwist(JPH.SoftBodySharedSettings.Const_RodBendTwist _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.RodBendTwist._Underlying *__JPH_SoftBodySharedSettings_RodBendTwist_ConstructFromAnother(JPH.SoftBodySharedSettings.RodBendTwist._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_RodBendTwist_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::RodBendTwist::RodBendTwist`.
            public Const_RodBendTwist(RodBendTwist _other) : this((Const_RodBendTwist)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::RodBendTwist::RodBendTwist`.
            /// Parameter `inCompliance` defaults to `0.0f`.
            public unsafe Const_RodBendTwist(uint inRod1, uint inRod2, float? inCompliance = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.RodBendTwist._Underlying *__JPH_SoftBodySharedSettings_RodBendTwist_Construct(uint inRod1, uint inRod2, float *inCompliance);
                float __deref_inCompliance = inCompliance.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_RodBendTwist_Construct(inRod1, inRod2, inCompliance.HasValue ? &__deref_inCompliance : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_RodBendTwist_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_RodBendTwist_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_RodBendTwist_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_SoftBodySharedSettings_RodBendTwist_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_RodBendTwist_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_RodBendTwist_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_RodBendTwist_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_RodBendTwist_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_RodBendTwist_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_RodBendTwist_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_RodBendTwist_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_SoftBodySharedSettings_RodBendTwist_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_RodBendTwist_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_RodBendTwist_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_RodBendTwist_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_RodBendTwist_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_void_ptr(inPointer, inPlace);
            }
        }

        /// A constraint that connects two Cosserat rods and limits bend and twist between the rods.
        /// Generated from class `JPH::SoftBodySharedSettings::RodBendTwist`.
        /// This is the non-const half of the class.
        public class RodBendTwist : Const_RodBendTwist
        {
            ///< Indices of rods that are constrained (index in mRodStretchShearConstraints)
            new public unsafe ref JPH.ArrayUnsignedInt2 mRod
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mRod", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mRod", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedInt2 *__JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mRod(_Underlying *_this);
                    return ref *(__JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mRod(_UnderlyingPtr));
                }
            }

            ///< Inverse of the stiffness of the rod
            public new unsafe ref float mCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mCompliance(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mCompliance(_UnderlyingPtr);
                }
            }

            ///< The initial rotation between the rods: rod1.mBishop.Conjugated() * rod2.mBishop, calculated by CalculateRodProperties
            public new unsafe JPH.Quat mOmega0
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mOmega0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mOmega0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Quat._Underlying *__JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mOmega0(_Underlying *_this);
                    JPH.Quat __ret;
                    __ret = new(__JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mOmega0(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe RodBendTwist(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe RodBendTwist() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.RodBendTwist._Underlying *__JPH_SoftBodySharedSettings_RodBendTwist_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_RodBendTwist_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::RodBendTwist::RodBendTwist`.
            public unsafe RodBendTwist(JPH.SoftBodySharedSettings.Const_RodBendTwist _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.RodBendTwist._Underlying *__JPH_SoftBodySharedSettings_RodBendTwist_ConstructFromAnother(JPH.SoftBodySharedSettings.RodBendTwist._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_RodBendTwist_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::RodBendTwist::RodBendTwist`.
            public RodBendTwist(RodBendTwist _other) : this((Const_RodBendTwist)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::RodBendTwist::RodBendTwist`.
            /// Parameter `inCompliance` defaults to `0.0f`.
            public unsafe RodBendTwist(uint inRod1, uint inRod2, float? inCompliance = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.RodBendTwist._Underlying *__JPH_SoftBodySharedSettings_RodBendTwist_Construct(uint inRod1, uint inRod2, float *inCompliance);
                float __deref_inCompliance = inCompliance.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_RodBendTwist_Construct(inRod1, inRod2, inCompliance.HasValue ? &__deref_inCompliance : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodBendTwist::operator=`.
            public unsafe JPH.SoftBodySharedSettings.RodBendTwist Assign(JPH.SoftBodySharedSettings.Const_RodBendTwist _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodBendTwist_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.RodBendTwist._Underlying *__JPH_SoftBodySharedSettings_RodBendTwist_AssignFromAnother(_Underlying *_this, JPH.SoftBodySharedSettings.RodBendTwist._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SoftBodySharedSettings_RodBendTwist_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `RodBendTwist` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_RodBendTwist`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `RodBendTwist`/`Const_RodBendTwist` directly.
        public class _InOptMut_RodBendTwist
        {
            public RodBendTwist? Opt;

            public _InOptMut_RodBendTwist() {}
            public _InOptMut_RodBendTwist(RodBendTwist value) {Opt = value;}
            public static implicit operator _InOptMut_RodBendTwist(RodBendTwist value) {return new(value);}
        }

        /// This is used for optional parameters of class `RodBendTwist` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_RodBendTwist`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `RodBendTwist`/`Const_RodBendTwist` to pass it to the function.
        public class _InOptConst_RodBendTwist
        {
            public Const_RodBendTwist? Opt;

            public _InOptConst_RodBendTwist() {}
            public _InOptConst_RodBendTwist(Const_RodBendTwist value) {Opt = value;}
            public static implicit operator _InOptConst_RodBendTwist(Const_RodBendTwist value) {return new(value);}
        }

        /// A discrete Cosserat rod connects two particles with a rigid rod that has fixed length and inertia.
        /// A rod can be used instead of an Edge to constraint two vertices. The orientation of the rod can be
        /// used to orient geometry attached to the rod (e.g. a plant leaf). Note that each rod needs to be constrained
        /// by at least one RodBendTwist constraint in order to constrain the rotation of the rod. If you don't do
        /// this then the orientation is likely to rotate around the rod axis with constant velocity.
        /// Based on "Position and Orientation Based Cosserat Rods" - Kugelstadt and Schoemer - SIGGRAPH 2016
        /// See: https://www.researchgate.net/publication/325597548_Position_and_Orientation_Based_Cosserat_Rods
        /// Generated from class `JPH::SoftBodySharedSettings::RodStretchShear`.
        /// This is the const half of the class.
        public class Const_RodStretchShear : JPH.Object<Const_RodStretchShear>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodySharedSettings_RodStretchShear_Destroy(_Underlying *_this);
                __JPH_SoftBodySharedSettings_RodStretchShear_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_RodStretchShear() {Dispose(false);}

            ///< Indices of the vertices that form the rod
            public unsafe ref JPH.ArrayUnsignedInt2 mVertex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Get_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Get_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedInt2 *__JPH_SoftBodySharedSettings_RodStretchShear_Get_mVertex(_Underlying *_this);
                    return ref *(__JPH_SoftBodySharedSettings_RodStretchShear_Get_mVertex(_UnderlyingPtr));
                }
            }

            ///< Fixed length of the rod, calculated by CalculateRodProperties
            public unsafe float mLength
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Get_mLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Get_mLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_RodStretchShear_Get_mLength(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_RodStretchShear_Get_mLength(_UnderlyingPtr);
                }
            }

            ///< Inverse of the mass of the rod (0 for static rods), calculated by CalculateRodProperties but can be overridden afterwards
            public unsafe float mInvMass
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Get_mInvMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Get_mInvMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_RodStretchShear_Get_mInvMass(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_RodStretchShear_Get_mInvMass(_UnderlyingPtr);
                }
            }

            ///< Inverse of the stiffness of the rod
            public unsafe float mCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Get_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Get_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_RodStretchShear_Get_mCompliance(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_RodStretchShear_Get_mCompliance(_UnderlyingPtr);
                }
            }

            ///< The Bishop frame of the rod (the rotation of the rod in its rest pose so that it has zero twist towards adjacent rods), calculated by CalculateRodProperties
            public unsafe JPH.Const_Quat mBishop
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Get_mBishop", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Get_mBishop", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Quat._Underlying *__JPH_SoftBodySharedSettings_RodStretchShear_Get_mBishop(_Underlying *_this);
                    JPH.Const_Quat __ret;
                    __ret = new(__JPH_SoftBodySharedSettings_RodStretchShear_Get_mBishop(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Const_RodStretchShear(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_RodStretchShear() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.RodStretchShear._Underlying *__JPH_SoftBodySharedSettings_RodStretchShear_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_RodStretchShear_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::RodStretchShear::RodStretchShear`.
            public unsafe Const_RodStretchShear(JPH.SoftBodySharedSettings.Const_RodStretchShear _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.RodStretchShear._Underlying *__JPH_SoftBodySharedSettings_RodStretchShear_ConstructFromAnother(JPH.SoftBodySharedSettings.RodStretchShear._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_RodStretchShear_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::RodStretchShear::RodStretchShear`.
            public Const_RodStretchShear(RodStretchShear _other) : this((Const_RodStretchShear)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::RodStretchShear::RodStretchShear`.
            /// Parameter `inCompliance` defaults to `0.0f`.
            public unsafe Const_RodStretchShear(uint inVertex1, uint inVertex2, float? inCompliance = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.RodStretchShear._Underlying *__JPH_SoftBodySharedSettings_RodStretchShear_Construct(uint inVertex1, uint inVertex2, float *inCompliance);
                float __deref_inCompliance = inCompliance.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_RodStretchShear_Construct(inVertex1, inVertex2, inCompliance.HasValue ? &__deref_inCompliance : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_RodStretchShear_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_RodStretchShear_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_RodStretchShear_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_SoftBodySharedSettings_RodStretchShear_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_RodStretchShear_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_RodStretchShear_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_RodStretchShear_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_RodStretchShear_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_RodStretchShear_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_RodStretchShear_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_RodStretchShear_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_SoftBodySharedSettings_RodStretchShear_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_RodStretchShear_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_RodStretchShear_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_RodStretchShear_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_RodStretchShear_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Return the lowest vertex index of this constraint
            /// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::GetMinVertexIndex`.
            public unsafe uint GetMinVertexIndex()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_GetMinVertexIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_GetMinVertexIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_SoftBodySharedSettings_RodStretchShear_GetMinVertexIndex(_Underlying *_this);
                return __JPH_SoftBodySharedSettings_RodStretchShear_GetMinVertexIndex(_UnderlyingPtr);
            }
        }

        /// A discrete Cosserat rod connects two particles with a rigid rod that has fixed length and inertia.
        /// A rod can be used instead of an Edge to constraint two vertices. The orientation of the rod can be
        /// used to orient geometry attached to the rod (e.g. a plant leaf). Note that each rod needs to be constrained
        /// by at least one RodBendTwist constraint in order to constrain the rotation of the rod. If you don't do
        /// this then the orientation is likely to rotate around the rod axis with constant velocity.
        /// Based on "Position and Orientation Based Cosserat Rods" - Kugelstadt and Schoemer - SIGGRAPH 2016
        /// See: https://www.researchgate.net/publication/325597548_Position_and_Orientation_Based_Cosserat_Rods
        /// Generated from class `JPH::SoftBodySharedSettings::RodStretchShear`.
        /// This is the non-const half of the class.
        public class RodStretchShear : Const_RodStretchShear
        {
            ///< Indices of the vertices that form the rod
            new public unsafe ref JPH.ArrayUnsignedInt2 mVertex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedInt2 *__JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mVertex(_Underlying *_this);
                    return ref *(__JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mVertex(_UnderlyingPtr));
                }
            }

            ///< Fixed length of the rod, calculated by CalculateRodProperties
            public new unsafe ref float mLength
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mLength(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mLength(_UnderlyingPtr);
                }
            }

            ///< Inverse of the mass of the rod (0 for static rods), calculated by CalculateRodProperties but can be overridden afterwards
            public new unsafe ref float mInvMass
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mInvMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mInvMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mInvMass(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mInvMass(_UnderlyingPtr);
                }
            }

            ///< Inverse of the stiffness of the rod
            public new unsafe ref float mCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mCompliance(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mCompliance(_UnderlyingPtr);
                }
            }

            ///< The Bishop frame of the rod (the rotation of the rod in its rest pose so that it has zero twist towards adjacent rods), calculated by CalculateRodProperties
            public new unsafe JPH.Quat mBishop
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mBishop", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mBishop", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Quat._Underlying *__JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mBishop(_Underlying *_this);
                    JPH.Quat __ret;
                    __ret = new(__JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mBishop(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe RodStretchShear(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe RodStretchShear() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.RodStretchShear._Underlying *__JPH_SoftBodySharedSettings_RodStretchShear_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_RodStretchShear_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::RodStretchShear::RodStretchShear`.
            public unsafe RodStretchShear(JPH.SoftBodySharedSettings.Const_RodStretchShear _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.RodStretchShear._Underlying *__JPH_SoftBodySharedSettings_RodStretchShear_ConstructFromAnother(JPH.SoftBodySharedSettings.RodStretchShear._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_RodStretchShear_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::RodStretchShear::RodStretchShear`.
            public RodStretchShear(RodStretchShear _other) : this((Const_RodStretchShear)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::RodStretchShear::RodStretchShear`.
            /// Parameter `inCompliance` defaults to `0.0f`.
            public unsafe RodStretchShear(uint inVertex1, uint inVertex2, float? inCompliance = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.RodStretchShear._Underlying *__JPH_SoftBodySharedSettings_RodStretchShear_Construct(uint inVertex1, uint inVertex2, float *inCompliance);
                float __deref_inCompliance = inCompliance.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_RodStretchShear_Construct(inVertex1, inVertex2, inCompliance.HasValue ? &__deref_inCompliance : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::RodStretchShear::operator=`.
            public unsafe JPH.SoftBodySharedSettings.RodStretchShear Assign(JPH.SoftBodySharedSettings.Const_RodStretchShear _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_RodStretchShear_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.RodStretchShear._Underlying *__JPH_SoftBodySharedSettings_RodStretchShear_AssignFromAnother(_Underlying *_this, JPH.SoftBodySharedSettings.RodStretchShear._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SoftBodySharedSettings_RodStretchShear_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `RodStretchShear` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_RodStretchShear`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `RodStretchShear`/`Const_RodStretchShear` directly.
        public class _InOptMut_RodStretchShear
        {
            public RodStretchShear? Opt;

            public _InOptMut_RodStretchShear() {}
            public _InOptMut_RodStretchShear(RodStretchShear value) {Opt = value;}
            public static implicit operator _InOptMut_RodStretchShear(RodStretchShear value) {return new(value);}
        }

        /// This is used for optional parameters of class `RodStretchShear` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_RodStretchShear`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `RodStretchShear`/`Const_RodStretchShear` to pass it to the function.
        public class _InOptConst_RodStretchShear
        {
            public Const_RodStretchShear? Opt;

            public _InOptConst_RodStretchShear() {}
            public _InOptConst_RodStretchShear(Const_RodStretchShear value) {Opt = value;}
            public static implicit operator _InOptConst_RodStretchShear(Const_RodStretchShear value) {return new(value);}
        }

        /// A joint and its skin weight
        /// Generated from class `JPH::SoftBodySharedSettings::SkinWeight`.
        /// This is the const half of the class.
        public class Const_SkinWeight : JPH.Object<Const_SkinWeight>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodySharedSettings_SkinWeight_Destroy(_Underlying *_this);
                __JPH_SoftBodySharedSettings_SkinWeight_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_SkinWeight() {Dispose(false);}

            ///< Index in mInvBindMatrices
            public unsafe uint mInvBindIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_Get_mInvBindIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_Get_mInvBindIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_SoftBodySharedSettings_SkinWeight_Get_mInvBindIndex(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_SkinWeight_Get_mInvBindIndex(_UnderlyingPtr);
                }
            }

            ///< Weight with which it is skinned
            public unsafe float mWeight
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_Get_mWeight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_Get_mWeight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_SkinWeight_Get_mWeight(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_SkinWeight_Get_mWeight(_UnderlyingPtr);
                }
            }

            internal unsafe Const_SkinWeight(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_SkinWeight() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.SkinWeight._Underlying *__JPH_SoftBodySharedSettings_SkinWeight_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_SkinWeight_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::SkinWeight::SkinWeight`.
            public unsafe Const_SkinWeight(JPH.SoftBodySharedSettings.Const_SkinWeight _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.SkinWeight._Underlying *__JPH_SoftBodySharedSettings_SkinWeight_ConstructFromAnother(JPH.SoftBodySharedSettings.SkinWeight._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_SkinWeight_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::SkinWeight::SkinWeight`.
            public Const_SkinWeight(SkinWeight _other) : this((Const_SkinWeight)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::SkinWeight::SkinWeight`.
            public unsafe Const_SkinWeight(uint inInvBindIndex, float inWeight) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.SkinWeight._Underlying *__JPH_SoftBodySharedSettings_SkinWeight_Construct(uint inInvBindIndex, float inWeight);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_SkinWeight_Construct(inInvBindIndex, inWeight);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_SkinWeight_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_SkinWeight_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_SkinWeight_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_SoftBodySharedSettings_SkinWeight_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_SkinWeight_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_SkinWeight_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_SkinWeight_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_SkinWeight_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_SkinWeight_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_SkinWeight_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_SkinWeight_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_SoftBodySharedSettings_SkinWeight_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_SkinWeight_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_SkinWeight_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_SkinWeight_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_SkinWeight_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_void_ptr(inPointer, inPlace);
            }
        }

        /// A joint and its skin weight
        /// Generated from class `JPH::SoftBodySharedSettings::SkinWeight`.
        /// This is the non-const half of the class.
        public class SkinWeight : Const_SkinWeight
        {
            ///< Index in mInvBindMatrices
            public new unsafe ref uint mInvBindIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_GetMutable_mInvBindIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_GetMutable_mInvBindIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_SoftBodySharedSettings_SkinWeight_GetMutable_mInvBindIndex(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_SkinWeight_GetMutable_mInvBindIndex(_UnderlyingPtr);
                }
            }

            ///< Weight with which it is skinned
            public new unsafe ref float mWeight
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_GetMutable_mWeight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_GetMutable_mWeight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_SkinWeight_GetMutable_mWeight(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_SkinWeight_GetMutable_mWeight(_UnderlyingPtr);
                }
            }

            internal unsafe SkinWeight(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe SkinWeight() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.SkinWeight._Underlying *__JPH_SoftBodySharedSettings_SkinWeight_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_SkinWeight_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::SkinWeight::SkinWeight`.
            public unsafe SkinWeight(JPH.SoftBodySharedSettings.Const_SkinWeight _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.SkinWeight._Underlying *__JPH_SoftBodySharedSettings_SkinWeight_ConstructFromAnother(JPH.SoftBodySharedSettings.SkinWeight._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_SkinWeight_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::SkinWeight::SkinWeight`.
            public SkinWeight(SkinWeight _other) : this((Const_SkinWeight)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::SkinWeight::SkinWeight`.
            public unsafe SkinWeight(uint inInvBindIndex, float inWeight) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.SkinWeight._Underlying *__JPH_SoftBodySharedSettings_SkinWeight_Construct(uint inInvBindIndex, float inWeight);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_SkinWeight_Construct(inInvBindIndex, inWeight);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::SkinWeight::operator=`.
            public unsafe JPH.SoftBodySharedSettings.SkinWeight Assign(JPH.SoftBodySharedSettings.Const_SkinWeight _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_SkinWeight_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.SkinWeight._Underlying *__JPH_SoftBodySharedSettings_SkinWeight_AssignFromAnother(_Underlying *_this, JPH.SoftBodySharedSettings.SkinWeight._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SoftBodySharedSettings_SkinWeight_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `SkinWeight` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_SkinWeight`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `SkinWeight`/`Const_SkinWeight` directly.
        public class _InOptMut_SkinWeight
        {
            public SkinWeight? Opt;

            public _InOptMut_SkinWeight() {}
            public _InOptMut_SkinWeight(SkinWeight value) {Opt = value;}
            public static implicit operator _InOptMut_SkinWeight(SkinWeight value) {return new(value);}
        }

        /// This is used for optional parameters of class `SkinWeight` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_SkinWeight`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `SkinWeight`/`Const_SkinWeight` to pass it to the function.
        public class _InOptConst_SkinWeight
        {
            public Const_SkinWeight? Opt;

            public _InOptConst_SkinWeight() {}
            public _InOptConst_SkinWeight(Const_SkinWeight value) {Opt = value;}
            public static implicit operator _InOptConst_SkinWeight(Const_SkinWeight value) {return new(value);}
        }

        /// A constraint that skins a vertex to joints and limits the distance that the simulated vertex can travel from this vertex
        /// Generated from class `JPH::SoftBodySharedSettings::Skinned`.
        /// This is the const half of the class.
        public class Const_Skinned : JPH.Object<Const_Skinned>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodySharedSettings_Skinned_Destroy(_Underlying *_this);
                __JPH_SoftBodySharedSettings_Skinned_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Skinned() {Dispose(false);}

            /// Maximum number of skin weights
            public static unsafe uint CMaxSkinWeights
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Get_cMaxSkinWeights", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Get_cMaxSkinWeights", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_SoftBodySharedSettings_Skinned_Get_cMaxSkinWeights();
                    return *__JPH_SoftBodySharedSettings_Skinned_Get_cMaxSkinWeights();
                }
            }

            ///< Index in mVertices which indicates which vertex is being skinned
            public unsafe uint mVertex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Get_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Get_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_SoftBodySharedSettings_Skinned_Get_mVertex(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_Skinned_Get_mVertex(_UnderlyingPtr);
                }
            }

            ///< Skin weights, the bind pose of the vertex is assumed to be stored in Vertex::mPosition. The first weight that is zero indicates the end of the list. Weights should add up to 1.
            public unsafe JPH.ArraySoftBodySharedSettingsSkinWeight4 mWeights
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Get_mWeights", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Get_mWeights", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.SoftBodySharedSettings.SkinWeight._Underlying *__JPH_SoftBodySharedSettings_Skinned_Get_mWeights(_Underlying *_this);
                    return new(__JPH_SoftBodySharedSettings_Skinned_Get_mWeights(_UnderlyingPtr));
                }
            }

            ///< Maximum distance that this vertex can reach from the skinned vertex, disabled when FLT_MAX. 0 when you want to hard skin the vertex to the skinned vertex.
            public unsafe float mMaxDistance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Get_mMaxDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Get_mMaxDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Skinned_Get_mMaxDistance(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_Skinned_Get_mMaxDistance(_UnderlyingPtr);
                }
            }

            ///< Disabled if mBackStopDistance >= mMaxDistance. The faces surrounding mVertex determine an average normal. mBackStopDistance behind the vertex in the opposite direction of this normal, the back stop sphere starts. The simulated vertex will be pushed out of this sphere and it can be used to approximate the volume of the skinned mesh behind the skinned vertex.
            public unsafe float mBackStopDistance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Get_mBackStopDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Get_mBackStopDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Skinned_Get_mBackStopDistance(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_Skinned_Get_mBackStopDistance(_UnderlyingPtr);
                }
            }

            ///< Radius of the backstop sphere. By default this is a fairly large radius so the sphere approximates a plane.
            public unsafe float mBackStopRadius
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Get_mBackStopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Get_mBackStopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Skinned_Get_mBackStopRadius(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_Skinned_Get_mBackStopRadius(_UnderlyingPtr);
                }
            }

            ///< Information needed to calculate the normal of this vertex, lowest 24 bit is start index in mSkinnedConstraintNormals, highest 8 bit is number of faces (generated by CalculateSkinnedConstraintNormals)
            public unsafe uint mNormalInfo
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Get_mNormalInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Get_mNormalInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_SoftBodySharedSettings_Skinned_Get_mNormalInfo(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_Skinned_Get_mNormalInfo(_UnderlyingPtr);
                }
            }

            internal unsafe Const_Skinned(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Skinned() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Skinned._Underlying *__JPH_SoftBodySharedSettings_Skinned_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Skinned_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Skinned::Skinned`.
            public unsafe Const_Skinned(JPH.SoftBodySharedSettings.Const_Skinned _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Skinned._Underlying *__JPH_SoftBodySharedSettings_Skinned_ConstructFromAnother(JPH.SoftBodySharedSettings.Skinned._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Skinned_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Skinned::Skinned`.
            public Const_Skinned(Skinned _other) : this((Const_Skinned)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::Skinned::Skinned`.
            public unsafe Const_Skinned(uint inVertex, float inMaxDistance, float inBackStopDistance, float inBackStopRadius) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Skinned._Underlying *__JPH_SoftBodySharedSettings_Skinned_Construct(uint inVertex, float inMaxDistance, float inBackStopDistance, float inBackStopRadius);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Skinned_Construct(inVertex, inMaxDistance, inBackStopDistance, inBackStopRadius);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Skinned_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Skinned_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_Skinned_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_SoftBodySharedSettings_Skinned_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Skinned_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Skinned_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_Skinned_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_Skinned_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Skinned_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Skinned_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_Skinned_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_SoftBodySharedSettings_Skinned_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Skinned_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Skinned_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_Skinned_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_Skinned_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr_void_ptr(inPointer, inPlace);
            }
        }

        /// A constraint that skins a vertex to joints and limits the distance that the simulated vertex can travel from this vertex
        /// Generated from class `JPH::SoftBodySharedSettings::Skinned`.
        /// This is the non-const half of the class.
        public class Skinned : Const_Skinned
        {
            ///< Index in mVertices which indicates which vertex is being skinned
            public new unsafe ref uint mVertex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_GetMutable_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_GetMutable_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_SoftBodySharedSettings_Skinned_GetMutable_mVertex(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_Skinned_GetMutable_mVertex(_UnderlyingPtr);
                }
            }

            ///< Skin weights, the bind pose of the vertex is assumed to be stored in Vertex::mPosition. The first weight that is zero indicates the end of the list. Weights should add up to 1.
            new public unsafe JPH.ArraySoftBodySharedSettingsSkinWeight4 mWeights
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_GetMutable_mWeights", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_GetMutable_mWeights", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.SoftBodySharedSettings.SkinWeight._Underlying *__JPH_SoftBodySharedSettings_Skinned_GetMutable_mWeights(_Underlying *_this);
                    return new(__JPH_SoftBodySharedSettings_Skinned_GetMutable_mWeights(_UnderlyingPtr));
                }
            }

            ///< Maximum distance that this vertex can reach from the skinned vertex, disabled when FLT_MAX. 0 when you want to hard skin the vertex to the skinned vertex.
            public new unsafe ref float mMaxDistance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_GetMutable_mMaxDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_GetMutable_mMaxDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Skinned_GetMutable_mMaxDistance(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_Skinned_GetMutable_mMaxDistance(_UnderlyingPtr);
                }
            }

            ///< Disabled if mBackStopDistance >= mMaxDistance. The faces surrounding mVertex determine an average normal. mBackStopDistance behind the vertex in the opposite direction of this normal, the back stop sphere starts. The simulated vertex will be pushed out of this sphere and it can be used to approximate the volume of the skinned mesh behind the skinned vertex.
            public new unsafe ref float mBackStopDistance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_GetMutable_mBackStopDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_GetMutable_mBackStopDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Skinned_GetMutable_mBackStopDistance(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_Skinned_GetMutable_mBackStopDistance(_UnderlyingPtr);
                }
            }

            ///< Radius of the backstop sphere. By default this is a fairly large radius so the sphere approximates a plane.
            public new unsafe ref float mBackStopRadius
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_GetMutable_mBackStopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_GetMutable_mBackStopRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Skinned_GetMutable_mBackStopRadius(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_Skinned_GetMutable_mBackStopRadius(_UnderlyingPtr);
                }
            }

            ///< Information needed to calculate the normal of this vertex, lowest 24 bit is start index in mSkinnedConstraintNormals, highest 8 bit is number of faces (generated by CalculateSkinnedConstraintNormals)
            public new unsafe ref uint mNormalInfo
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_GetMutable_mNormalInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_GetMutable_mNormalInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_SoftBodySharedSettings_Skinned_GetMutable_mNormalInfo(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_Skinned_GetMutable_mNormalInfo(_UnderlyingPtr);
                }
            }

            internal unsafe Skinned(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Skinned() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Skinned._Underlying *__JPH_SoftBodySharedSettings_Skinned_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Skinned_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Skinned::Skinned`.
            public unsafe Skinned(JPH.SoftBodySharedSettings.Const_Skinned _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Skinned._Underlying *__JPH_SoftBodySharedSettings_Skinned_ConstructFromAnother(JPH.SoftBodySharedSettings.Skinned._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Skinned_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Skinned::Skinned`.
            public Skinned(Skinned _other) : this((Const_Skinned)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::Skinned::Skinned`.
            public unsafe Skinned(uint inVertex, float inMaxDistance, float inBackStopDistance, float inBackStopRadius) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Skinned._Underlying *__JPH_SoftBodySharedSettings_Skinned_Construct(uint inVertex, float inMaxDistance, float inBackStopDistance, float inBackStopRadius);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Skinned_Construct(inVertex, inMaxDistance, inBackStopDistance, inBackStopRadius);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Skinned::operator=`.
            public unsafe JPH.SoftBodySharedSettings.Skinned Assign(JPH.SoftBodySharedSettings.Const_Skinned _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Skinned._Underlying *__JPH_SoftBodySharedSettings_Skinned_AssignFromAnother(_Underlying *_this, JPH.SoftBodySharedSettings.Skinned._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SoftBodySharedSettings_Skinned_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }

            /// Normalize the weights so that they add up to 1
            /// Generated from method `JPH::SoftBodySharedSettings::Skinned::NormalizeWeights`.
            public unsafe void NormalizeWeights()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_NormalizeWeights", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Skinned_NormalizeWeights", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodySharedSettings_Skinned_NormalizeWeights(_Underlying *_this);
                __JPH_SoftBodySharedSettings_Skinned_NormalizeWeights(_UnderlyingPtr);
            }
        }

        /// This is used for optional parameters of class `Skinned` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Skinned`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Skinned`/`Const_Skinned` directly.
        public class _InOptMut_Skinned
        {
            public Skinned? Opt;

            public _InOptMut_Skinned() {}
            public _InOptMut_Skinned(Skinned value) {Opt = value;}
            public static implicit operator _InOptMut_Skinned(Skinned value) {return new(value);}
        }

        /// This is used for optional parameters of class `Skinned` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Skinned`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Skinned`/`Const_Skinned` to pass it to the function.
        public class _InOptConst_Skinned
        {
            public Const_Skinned? Opt;

            public _InOptConst_Skinned() {}
            public _InOptConst_Skinned(Const_Skinned value) {Opt = value;}
            public static implicit operator _InOptConst_Skinned(Const_Skinned value) {return new(value);}
        }

        /// A vertex is a particle, the data in this structure is only used during creation of the soft body and not during simulation
        /// Generated from class `JPH::SoftBodySharedSettings::Vertex`.
        /// This is the const half of the class.
        public class Const_Vertex : JPH.Object<Const_Vertex>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodySharedSettings_Vertex_Destroy(_Underlying *_this);
                __JPH_SoftBodySharedSettings_Vertex_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Vertex() {Dispose(false);}

            ///< Initial position of the vertex
            public unsafe JPH.Const_Float3 mPosition
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Float3._Underlying *__JPH_SoftBodySharedSettings_Vertex_Get_mPosition(_Underlying *_this);
                    JPH.Const_Float3 __ret;
                    __ret = new(__JPH_SoftBodySharedSettings_Vertex_Get_mPosition(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Initial velocity of the vertex
            public unsafe JPH.Const_Float3 mVelocity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_Get_mVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_Get_mVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Float3._Underlying *__JPH_SoftBodySharedSettings_Vertex_Get_mVelocity(_Underlying *_this);
                    JPH.Const_Float3 __ret;
                    __ret = new(__JPH_SoftBodySharedSettings_Vertex_Get_mVelocity(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Initial inverse of the mass of the vertex
            public unsafe float mInvMass
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_Get_mInvMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_Get_mInvMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Vertex_Get_mInvMass(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_Vertex_Get_mInvMass(_UnderlyingPtr);
                }
            }

            internal unsafe Const_Vertex(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Vertex() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Vertex._Underlying *__JPH_SoftBodySharedSettings_Vertex_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Vertex_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Vertex::Vertex`.
            public unsafe Const_Vertex(JPH.SoftBodySharedSettings.Const_Vertex _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Vertex._Underlying *__JPH_SoftBodySharedSettings_Vertex_ConstructFromAnother(JPH.SoftBodySharedSettings.Vertex._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Vertex_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Vertex::Vertex`.
            public Const_Vertex(Vertex _other) : this((Const_Vertex)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::Vertex::Vertex`.
            /// Parameter `inVelocity` defaults to `JPH::Float3(0, 0, 0)`.
            /// Parameter `inInvMass` defaults to `1.0f`.
            public unsafe Const_Vertex(JPH.Const_Float3 inPosition, JPH.Const_Float3? inVelocity = null, float? inInvMass = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Vertex._Underlying *__JPH_SoftBodySharedSettings_Vertex_Construct(JPH.Const_Float3._Underlying *inPosition, JPH.Const_Float3._Underlying *inVelocity, float *inInvMass);
                float __deref_inInvMass = inInvMass.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Vertex_Construct(inPosition._UnderlyingPtr, inVelocity is not null ? inVelocity._UnderlyingPtr : null, inInvMass.HasValue ? &__deref_inInvMass : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Vertex_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Vertex_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_Vertex_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_SoftBodySharedSettings_Vertex_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Vertex_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Vertex_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_Vertex_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_Vertex_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Vertex_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Vertex_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_Vertex_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_SoftBodySharedSettings_Vertex_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Vertex_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Vertex_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_Vertex_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_Vertex_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr_void_ptr(inPointer, inPlace);
            }
        }

        /// A vertex is a particle, the data in this structure is only used during creation of the soft body and not during simulation
        /// Generated from class `JPH::SoftBodySharedSettings::Vertex`.
        /// This is the non-const half of the class.
        public class Vertex : Const_Vertex
        {
            ///< Initial position of the vertex
            public new unsafe JPH.Float3 mPosition
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Float3._Underlying *__JPH_SoftBodySharedSettings_Vertex_GetMutable_mPosition(_Underlying *_this);
                    JPH.Float3 __ret;
                    __ret = new(__JPH_SoftBodySharedSettings_Vertex_GetMutable_mPosition(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Initial velocity of the vertex
            public new unsafe JPH.Float3 mVelocity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_GetMutable_mVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_GetMutable_mVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Float3._Underlying *__JPH_SoftBodySharedSettings_Vertex_GetMutable_mVelocity(_Underlying *_this);
                    JPH.Float3 __ret;
                    __ret = new(__JPH_SoftBodySharedSettings_Vertex_GetMutable_mVelocity(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Initial inverse of the mass of the vertex
            public new unsafe ref float mInvMass
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_GetMutable_mInvMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_GetMutable_mInvMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Vertex_GetMutable_mInvMass(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_Vertex_GetMutable_mInvMass(_UnderlyingPtr);
                }
            }

            internal unsafe Vertex(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Vertex() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Vertex._Underlying *__JPH_SoftBodySharedSettings_Vertex_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Vertex_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Vertex::Vertex`.
            public unsafe Vertex(JPH.SoftBodySharedSettings.Const_Vertex _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Vertex._Underlying *__JPH_SoftBodySharedSettings_Vertex_ConstructFromAnother(JPH.SoftBodySharedSettings.Vertex._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Vertex_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Vertex::Vertex`.
            public Vertex(Vertex _other) : this((Const_Vertex)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::Vertex::Vertex`.
            /// Parameter `inVelocity` defaults to `JPH::Float3(0, 0, 0)`.
            /// Parameter `inInvMass` defaults to `1.0f`.
            public unsafe Vertex(JPH.Const_Float3 inPosition, JPH.Const_Float3? inVelocity = null, float? inInvMass = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Vertex._Underlying *__JPH_SoftBodySharedSettings_Vertex_Construct(JPH.Const_Float3._Underlying *inPosition, JPH.Const_Float3._Underlying *inVelocity, float *inInvMass);
                float __deref_inInvMass = inInvMass.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Vertex_Construct(inPosition._UnderlyingPtr, inVelocity is not null ? inVelocity._UnderlyingPtr : null, inInvMass.HasValue ? &__deref_inInvMass : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Vertex::operator=`.
            public unsafe JPH.SoftBodySharedSettings.Vertex Assign(JPH.SoftBodySharedSettings.Const_Vertex _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Vertex_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Vertex._Underlying *__JPH_SoftBodySharedSettings_Vertex_AssignFromAnother(_Underlying *_this, JPH.SoftBodySharedSettings.Vertex._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SoftBodySharedSettings_Vertex_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `Vertex` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Vertex`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Vertex`/`Const_Vertex` directly.
        public class _InOptMut_Vertex
        {
            public Vertex? Opt;

            public _InOptMut_Vertex() {}
            public _InOptMut_Vertex(Vertex value) {Opt = value;}
            public static implicit operator _InOptMut_Vertex(Vertex value) {return new(value);}
        }

        /// This is used for optional parameters of class `Vertex` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Vertex`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Vertex`/`Const_Vertex` to pass it to the function.
        public class _InOptConst_Vertex
        {
            public Const_Vertex? Opt;

            public _InOptConst_Vertex() {}
            public _InOptConst_Vertex(Const_Vertex value) {Opt = value;}
            public static implicit operator _InOptConst_Vertex(Const_Vertex value) {return new(value);}
        }

        /// Per vertex attributes used during the CreateConstraints function.
        /// For an edge or shear constraint, the compliance is averaged between the two attached vertices.
        /// For a bend constraint, the compliance is averaged between the two vertices on the shared edge.
        /// Generated from class `JPH::SoftBodySharedSettings::VertexAttributes`.
        /// This is the const half of the class.
        public class Const_VertexAttributes : JPH.Object<Const_VertexAttributes>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodySharedSettings_VertexAttributes_Destroy(_Underlying *_this);
                __JPH_SoftBodySharedSettings_VertexAttributes_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_VertexAttributes() {Dispose(false);}

            ///< The compliance of the normal edges. Set to FLT_MAX to disable regular edges for any edge involving this vertex.
            public unsafe float mCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Get_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Get_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_VertexAttributes_Get_mCompliance(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_VertexAttributes_Get_mCompliance(_UnderlyingPtr);
                }
            }

            ///< The compliance of the shear edges. Set to FLT_MAX to disable shear edges for any edge involving this vertex.
            public unsafe float mShearCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Get_mShearCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Get_mShearCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_VertexAttributes_Get_mShearCompliance(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_VertexAttributes_Get_mShearCompliance(_UnderlyingPtr);
                }
            }

            ///< The compliance of the bend edges. Set to FLT_MAX to disable bend edges for any bend constraint involving this vertex.
            public unsafe float mBendCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Get_mBendCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Get_mBendCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_VertexAttributes_Get_mBendCompliance(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_VertexAttributes_Get_mBendCompliance(_UnderlyingPtr);
                }
            }

            ///< The type of long range attachment constraint to create.
            public unsafe JPH.SoftBodySharedSettings.ELRAType mLRAType
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Get_mLRAType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Get_mLRAType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.SoftBodySharedSettings.ELRAType *__JPH_SoftBodySharedSettings_VertexAttributes_Get_mLRAType(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_VertexAttributes_Get_mLRAType(_UnderlyingPtr);
                }
            }

            ///< Multiplier for the max distance of the LRA constraint, e.g. 1.01 means the max distance is 1% longer than the calculated distance in the rest pose.
            public unsafe float mLRAMaxDistanceMultiplier
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Get_mLRAMaxDistanceMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Get_mLRAMaxDistanceMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_VertexAttributes_Get_mLRAMaxDistanceMultiplier(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_VertexAttributes_Get_mLRAMaxDistanceMultiplier(_UnderlyingPtr);
                }
            }

            internal unsafe Const_VertexAttributes(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_VertexAttributes() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.VertexAttributes._Underlying *__JPH_SoftBodySharedSettings_VertexAttributes_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_VertexAttributes_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::VertexAttributes::VertexAttributes`.
            public unsafe Const_VertexAttributes(JPH.SoftBodySharedSettings.Const_VertexAttributes _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.VertexAttributes._Underlying *__JPH_SoftBodySharedSettings_VertexAttributes_ConstructFromAnother(JPH.SoftBodySharedSettings.VertexAttributes._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_VertexAttributes_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::VertexAttributes::VertexAttributes`.
            public Const_VertexAttributes(VertexAttributes _other) : this((Const_VertexAttributes)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::VertexAttributes::VertexAttributes`.
            /// Parameter `inLRAType` defaults to `ELRAType::None`.
            /// Parameter `inLRAMaxDistanceMultiplier` defaults to `1.0f`.
            public unsafe Const_VertexAttributes(float inCompliance, float inShearCompliance, float inBendCompliance, JPH.SoftBodySharedSettings.ELRAType? inLRAType = null, float? inLRAMaxDistanceMultiplier = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.VertexAttributes._Underlying *__JPH_SoftBodySharedSettings_VertexAttributes_Construct(float inCompliance, float inShearCompliance, float inBendCompliance, JPH.SoftBodySharedSettings.ELRAType *inLRAType, float *inLRAMaxDistanceMultiplier);
                JPH.SoftBodySharedSettings.ELRAType __deref_inLRAType = inLRAType.GetValueOrDefault();
                float __deref_inLRAMaxDistanceMultiplier = inLRAMaxDistanceMultiplier.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_VertexAttributes_Construct(inCompliance, inShearCompliance, inBendCompliance, inLRAType.HasValue ? &__deref_inLRAType : null, inLRAMaxDistanceMultiplier.HasValue ? &__deref_inLRAMaxDistanceMultiplier : null);
            }
        }

        /// Per vertex attributes used during the CreateConstraints function.
        /// For an edge or shear constraint, the compliance is averaged between the two attached vertices.
        /// For a bend constraint, the compliance is averaged between the two vertices on the shared edge.
        /// Generated from class `JPH::SoftBodySharedSettings::VertexAttributes`.
        /// This is the non-const half of the class.
        public class VertexAttributes : Const_VertexAttributes
        {
            ///< The compliance of the normal edges. Set to FLT_MAX to disable regular edges for any edge involving this vertex.
            public new unsafe ref float mCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mCompliance(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mCompliance(_UnderlyingPtr);
                }
            }

            ///< The compliance of the shear edges. Set to FLT_MAX to disable shear edges for any edge involving this vertex.
            public new unsafe ref float mShearCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mShearCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mShearCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mShearCompliance(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mShearCompliance(_UnderlyingPtr);
                }
            }

            ///< The compliance of the bend edges. Set to FLT_MAX to disable bend edges for any bend constraint involving this vertex.
            public new unsafe ref float mBendCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mBendCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mBendCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mBendCompliance(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mBendCompliance(_UnderlyingPtr);
                }
            }

            ///< The type of long range attachment constraint to create.
            public new unsafe ref JPH.SoftBodySharedSettings.ELRAType mLRAType
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mLRAType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mLRAType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.SoftBodySharedSettings.ELRAType *__JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mLRAType(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mLRAType(_UnderlyingPtr);
                }
            }

            ///< Multiplier for the max distance of the LRA constraint, e.g. 1.01 means the max distance is 1% longer than the calculated distance in the rest pose.
            public new unsafe ref float mLRAMaxDistanceMultiplier
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mLRAMaxDistanceMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mLRAMaxDistanceMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mLRAMaxDistanceMultiplier(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mLRAMaxDistanceMultiplier(_UnderlyingPtr);
                }
            }

            internal unsafe VertexAttributes(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe VertexAttributes() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.VertexAttributes._Underlying *__JPH_SoftBodySharedSettings_VertexAttributes_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_VertexAttributes_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::VertexAttributes::VertexAttributes`.
            public unsafe VertexAttributes(JPH.SoftBodySharedSettings.Const_VertexAttributes _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.VertexAttributes._Underlying *__JPH_SoftBodySharedSettings_VertexAttributes_ConstructFromAnother(JPH.SoftBodySharedSettings.VertexAttributes._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_VertexAttributes_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::VertexAttributes::VertexAttributes`.
            public VertexAttributes(VertexAttributes _other) : this((Const_VertexAttributes)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::VertexAttributes::VertexAttributes`.
            /// Parameter `inLRAType` defaults to `ELRAType::None`.
            /// Parameter `inLRAMaxDistanceMultiplier` defaults to `1.0f`.
            public unsafe VertexAttributes(float inCompliance, float inShearCompliance, float inBendCompliance, JPH.SoftBodySharedSettings.ELRAType? inLRAType = null, float? inLRAMaxDistanceMultiplier = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.VertexAttributes._Underlying *__JPH_SoftBodySharedSettings_VertexAttributes_Construct(float inCompliance, float inShearCompliance, float inBendCompliance, JPH.SoftBodySharedSettings.ELRAType *inLRAType, float *inLRAMaxDistanceMultiplier);
                JPH.SoftBodySharedSettings.ELRAType __deref_inLRAType = inLRAType.GetValueOrDefault();
                float __deref_inLRAMaxDistanceMultiplier = inLRAMaxDistanceMultiplier.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_VertexAttributes_Construct(inCompliance, inShearCompliance, inBendCompliance, inLRAType.HasValue ? &__deref_inLRAType : null, inLRAMaxDistanceMultiplier.HasValue ? &__deref_inLRAMaxDistanceMultiplier : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::VertexAttributes::operator=`.
            public unsafe JPH.SoftBodySharedSettings.VertexAttributes Assign(JPH.SoftBodySharedSettings.Const_VertexAttributes _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_VertexAttributes_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.VertexAttributes._Underlying *__JPH_SoftBodySharedSettings_VertexAttributes_AssignFromAnother(_Underlying *_this, JPH.SoftBodySharedSettings.VertexAttributes._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SoftBodySharedSettings_VertexAttributes_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `VertexAttributes` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_VertexAttributes`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `VertexAttributes`/`Const_VertexAttributes` directly.
        public class _InOptMut_VertexAttributes
        {
            public VertexAttributes? Opt;

            public _InOptMut_VertexAttributes() {}
            public _InOptMut_VertexAttributes(VertexAttributes value) {Opt = value;}
            public static implicit operator _InOptMut_VertexAttributes(VertexAttributes value) {return new(value);}
        }

        /// This is used for optional parameters of class `VertexAttributes` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_VertexAttributes`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `VertexAttributes`/`Const_VertexAttributes` to pass it to the function.
        public class _InOptConst_VertexAttributes
        {
            public Const_VertexAttributes? Opt;

            public _InOptConst_VertexAttributes() {}
            public _InOptConst_VertexAttributes(Const_VertexAttributes value) {Opt = value;}
            public static implicit operator _InOptConst_VertexAttributes(Const_VertexAttributes value) {return new(value);}
        }

        /// Volume constraint, keeps the volume of a tetrahedron constant
        /// Generated from class `JPH::SoftBodySharedSettings::Volume`.
        /// This is the const half of the class.
        public class Const_Volume : JPH.Object<Const_Volume>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodySharedSettings_Volume_Destroy(_Underlying *_this);
                __JPH_SoftBodySharedSettings_Volume_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Volume() {Dispose(false);}

            ///< Indices of the vertices that form the tetrahedron
            public unsafe ref JPH.ArrayUnsignedInt4 mVertex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_Get_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_Get_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedInt4 *__JPH_SoftBodySharedSettings_Volume_Get_mVertex(_Underlying *_this);
                    return ref *(__JPH_SoftBodySharedSettings_Volume_Get_mVertex(_UnderlyingPtr));
                }
            }

            ///< 6 times the rest volume of the tetrahedron, calculated by CalculateVolumeConstraintVolumes
            public unsafe float mSixRestVolume
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_Get_mSixRestVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_Get_mSixRestVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Volume_Get_mSixRestVolume(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_Volume_Get_mSixRestVolume(_UnderlyingPtr);
                }
            }

            ///< Inverse of the stiffness of the constraint
            public unsafe float mCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_Get_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_Get_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Volume_Get_mCompliance(_Underlying *_this);
                    return *__JPH_SoftBodySharedSettings_Volume_Get_mCompliance(_UnderlyingPtr);
                }
            }

            internal unsafe Const_Volume(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Volume() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Volume._Underlying *__JPH_SoftBodySharedSettings_Volume_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Volume_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Volume::Volume`.
            public unsafe Const_Volume(JPH.SoftBodySharedSettings.Const_Volume _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Volume._Underlying *__JPH_SoftBodySharedSettings_Volume_ConstructFromAnother(JPH.SoftBodySharedSettings.Volume._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Volume_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Volume::Volume`.
            public Const_Volume(Volume _other) : this((Const_Volume)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::Volume::Volume`.
            /// Parameter `inCompliance` defaults to `0.0f`.
            public unsafe Const_Volume(uint inVertex1, uint inVertex2, uint inVertex3, uint inVertex4, float? inCompliance = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Volume._Underlying *__JPH_SoftBodySharedSettings_Volume_Construct(uint inVertex1, uint inVertex2, uint inVertex3, uint inVertex4, float *inCompliance);
                float __deref_inCompliance = inCompliance.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Volume_Construct(inVertex1, inVertex2, inVertex3, inVertex4, inCompliance.HasValue ? &__deref_inCompliance : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Volume::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Volume_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Volume_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_Volume_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_SoftBodySharedSettings_Volume_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Volume::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Volume::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Volume::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Volume_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Volume_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_Volume_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_Volume_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Volume::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Volume::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Volume::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Volume_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodySharedSettings_Volume_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodySharedSettings_Volume_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_SoftBodySharedSettings_Volume_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Volume::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Volume::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Volume_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodySharedSettings_Volume_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodySharedSettings_Volume_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_SoftBodySharedSettings_Volume_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Volume::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Return the lowest vertex index of this constraint
            /// Generated from method `JPH::SoftBodySharedSettings::Volume::GetMinVertexIndex`.
            public unsafe uint GetMinVertexIndex()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_GetMinVertexIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_GetMinVertexIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_SoftBodySharedSettings_Volume_GetMinVertexIndex(_Underlying *_this);
                return __JPH_SoftBodySharedSettings_Volume_GetMinVertexIndex(_UnderlyingPtr);
            }
        }

        /// Volume constraint, keeps the volume of a tetrahedron constant
        /// Generated from class `JPH::SoftBodySharedSettings::Volume`.
        /// This is the non-const half of the class.
        public class Volume : Const_Volume
        {
            ///< Indices of the vertices that form the tetrahedron
            new public unsafe ref JPH.ArrayUnsignedInt4 mVertex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_GetMutable_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_GetMutable_mVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedInt4 *__JPH_SoftBodySharedSettings_Volume_GetMutable_mVertex(_Underlying *_this);
                    return ref *(__JPH_SoftBodySharedSettings_Volume_GetMutable_mVertex(_UnderlyingPtr));
                }
            }

            ///< 6 times the rest volume of the tetrahedron, calculated by CalculateVolumeConstraintVolumes
            public new unsafe ref float mSixRestVolume
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_GetMutable_mSixRestVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_GetMutable_mSixRestVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Volume_GetMutable_mSixRestVolume(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_Volume_GetMutable_mSixRestVolume(_UnderlyingPtr);
                }
            }

            ///< Inverse of the stiffness of the constraint
            public new unsafe ref float mCompliance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_GetMutable_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_GetMutable_mCompliance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodySharedSettings_Volume_GetMutable_mCompliance(_Underlying *_this);
                    return ref *__JPH_SoftBodySharedSettings_Volume_GetMutable_mCompliance(_UnderlyingPtr);
                }
            }

            internal unsafe Volume(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Volume() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Volume._Underlying *__JPH_SoftBodySharedSettings_Volume_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Volume_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Volume::Volume`.
            public unsafe Volume(JPH.SoftBodySharedSettings.Const_Volume _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Volume._Underlying *__JPH_SoftBodySharedSettings_Volume_ConstructFromAnother(JPH.SoftBodySharedSettings.Volume._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Volume_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::SoftBodySharedSettings::Volume::Volume`.
            public Volume(Volume _other) : this((Const_Volume)_other) {}

            /// Generated from constructor `JPH::SoftBodySharedSettings::Volume::Volume`.
            /// Parameter `inCompliance` defaults to `0.0f`.
            public unsafe Volume(uint inVertex1, uint inVertex2, uint inVertex3, uint inVertex4, float? inCompliance = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Volume._Underlying *__JPH_SoftBodySharedSettings_Volume_Construct(uint inVertex1, uint inVertex2, uint inVertex3, uint inVertex4, float *inCompliance);
                float __deref_inCompliance = inCompliance.GetValueOrDefault();
                _UnderlyingPtr = __JPH_SoftBodySharedSettings_Volume_Construct(inVertex1, inVertex2, inVertex3, inVertex4, inCompliance.HasValue ? &__deref_inCompliance : null);
            }

            /// Generated from method `JPH::SoftBodySharedSettings::Volume::operator=`.
            public unsafe JPH.SoftBodySharedSettings.Volume Assign(JPH.SoftBodySharedSettings.Const_Volume _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Volume_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Volume._Underlying *__JPH_SoftBodySharedSettings_Volume_AssignFromAnother(_Underlying *_this, JPH.SoftBodySharedSettings.Volume._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_SoftBodySharedSettings_Volume_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `Volume` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Volume`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Volume`/`Const_Volume` directly.
        public class _InOptMut_Volume
        {
            public Volume? Opt;

            public _InOptMut_Volume() {}
            public _InOptMut_Volume(Volume value) {Opt = value;}
            public static implicit operator _InOptMut_Volume(Volume value) {return new(value);}
        }

        /// This is used for optional parameters of class `Volume` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Volume`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Volume`/`Const_Volume` to pass it to the function.
        public class _InOptConst_Volume
        {
            public Const_Volume? Opt;

            public _InOptConst_Volume() {}
            public _InOptConst_Volume(Const_Volume value) {Opt = value;}
            public static implicit operator _InOptConst_Volume(Const_Volume value) {return new(value);}
        }
    }

    /// This class defines the setup of all particles and their constraints.
    /// It is used during the simulation and can be shared between multiple soft bodies.
    /// Generated from class `JPH::SoftBodySharedSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::SoftBodySharedSettings>`
    /// This is the non-const half of the class.
    public class SoftBodySharedSettings : Const_SoftBodySharedSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHSoftBodySharedSettings(SoftBodySharedSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHSoftBodySharedSettings._Underlying *__JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(_Underlying *_this);
            JPH.RefTarget_JPHSoftBodySharedSettings ret = new(__JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator SoftBodySharedSettings(JPH.RefTarget_JPHSoftBodySharedSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_StaticDowncastFrom_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_StaticDowncastFrom_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_SoftBodySharedSettings_StaticDowncastFrom_JPH_RefTarget_JPH_SoftBodySharedSettings(JPH.RefTarget_JPHSoftBodySharedSettings._Underlying *_this);
            SoftBodySharedSettings ret = new(__JPH_SoftBodySharedSettings_StaticDowncastFrom_JPH_RefTarget_JPH_SoftBodySharedSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe SoftBodySharedSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe SoftBodySharedSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings._Underlying *__JPH_SoftBodySharedSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_SoftBodySharedSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef(__JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::SoftBodySharedSettings::SoftBodySharedSettings`.
        public unsafe SoftBodySharedSettings(JPH._ByValue_SoftBodySharedSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings._Underlying *__JPH_SoftBodySharedSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SoftBodySharedSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_SoftBodySharedSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_SoftBodySharedSettings_AddRef(__JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::SoftBodySharedSettings::SoftBodySharedSettings`.
        public SoftBodySharedSettings(Const_SoftBodySharedSettings _other) : this(new _ByValue_SoftBodySharedSettings(_other)) {}

        /// Generated from constructor `JPH::SoftBodySharedSettings::SoftBodySharedSettings`.
        public SoftBodySharedSettings(SoftBodySharedSettings _other) : this((Const_SoftBodySharedSettings)_other) {}

        /// Generated from method `JPH::SoftBodySharedSettings::operator=`.
        public unsafe JPH.SoftBodySharedSettings Assign(JPH._ByValue_SoftBodySharedSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings._Underlying *__JPH_SoftBodySharedSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.SoftBodySharedSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_SoftBodySharedSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Automatically create constraints based on the faces of the soft body
        /// @param inVertexAttributes A list of attributes for each vertex (1-on-1 with mVertices, note that if the list is smaller than mVertices the last element will be repeated). This defines the properties of the constraints that are created.
        /// @param inVertexAttributesLength The length of inVertexAttributes
        /// @param inBendType The type of bend constraint to create
        /// @param inAngleTolerance Shear edges are created when two connected triangles form a quad (are roughly in the same plane and form a square with roughly 90 degree angles). This defines the tolerance (in radians).
        /// Generated from method `JPH::SoftBodySharedSettings::CreateConstraints`.
        /// Parameter `inBendType` defaults to `EBendType::Distance`.
        /// Parameter `inAngleTolerance` defaults to `DegreesToRadians(8.0f)`.
        public unsafe void CreateConstraints(JPH.SoftBodySharedSettings.Const_VertexAttributes? inVertexAttributes, uint inVertexAttributesLength, JPH.SoftBodySharedSettings.EBendType? inBendType = null, float? inAngleTolerance = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_CreateConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_CreateConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodySharedSettings_CreateConstraints(_Underlying *_this, JPH.SoftBodySharedSettings.Const_VertexAttributes._Underlying *inVertexAttributes, uint inVertexAttributesLength, JPH.SoftBodySharedSettings.EBendType *inBendType, float *inAngleTolerance);
            JPH.SoftBodySharedSettings.EBendType __deref_inBendType = inBendType.GetValueOrDefault();
            float __deref_inAngleTolerance = inAngleTolerance.GetValueOrDefault();
            __JPH_SoftBodySharedSettings_CreateConstraints(_UnderlyingPtr, inVertexAttributes is not null ? inVertexAttributes._UnderlyingPtr : null, inVertexAttributesLength, inBendType.HasValue ? &__deref_inBendType : null, inAngleTolerance.HasValue ? &__deref_inAngleTolerance : null);
        }

        /// Calculate the initial lengths of all springs of the edges of this soft body (if you use CreateConstraint, this is already done)
        /// Generated from method `JPH::SoftBodySharedSettings::CalculateEdgeLengths`.
        public unsafe void CalculateEdgeLengths()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_CalculateEdgeLengths", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_CalculateEdgeLengths", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodySharedSettings_CalculateEdgeLengths(_Underlying *_this);
            __JPH_SoftBodySharedSettings_CalculateEdgeLengths(_UnderlyingPtr);
        }

        /// Calculate the properties of the rods
        /// Note that this can swap mVertex of the RodStretchShear constraints if two rods are connected through a RodBendTwist constraint but point in opposite directions.
        /// Generated from method `JPH::SoftBodySharedSettings::CalculateRodProperties`.
        public unsafe void CalculateRodProperties()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_CalculateRodProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_CalculateRodProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodySharedSettings_CalculateRodProperties(_Underlying *_this);
            __JPH_SoftBodySharedSettings_CalculateRodProperties(_UnderlyingPtr);
        }

        /// Calculate the max lengths for the long range attachment constraints based on Euclidean distance (if you use CreateConstraints, this is already done)
        /// @param inMaxDistanceMultiplier Multiplier for the max distance of the LRA constraint, e.g. 1.01 means the max distance is 1% longer than the calculated distance in the rest pose.
        /// Generated from method `JPH::SoftBodySharedSettings::CalculateLRALengths`.
        /// Parameter `inMaxDistanceMultiplier` defaults to `1.0f`.
        public unsafe void CalculateLRALengths(float? inMaxDistanceMultiplier = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_CalculateLRALengths", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_CalculateLRALengths", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodySharedSettings_CalculateLRALengths(_Underlying *_this, float *inMaxDistanceMultiplier);
            float __deref_inMaxDistanceMultiplier = inMaxDistanceMultiplier.GetValueOrDefault();
            __JPH_SoftBodySharedSettings_CalculateLRALengths(_UnderlyingPtr, inMaxDistanceMultiplier.HasValue ? &__deref_inMaxDistanceMultiplier : null);
        }

        /// Calculate the constants for the bend constraints (if you use CreateConstraints, this is already done)
        /// Generated from method `JPH::SoftBodySharedSettings::CalculateBendConstraintConstants`.
        public unsafe void CalculateBendConstraintConstants()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_CalculateBendConstraintConstants", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_CalculateBendConstraintConstants", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodySharedSettings_CalculateBendConstraintConstants(_Underlying *_this);
            __JPH_SoftBodySharedSettings_CalculateBendConstraintConstants(_UnderlyingPtr);
        }

        /// Calculates the initial volume of all tetrahedra of this soft body
        /// Generated from method `JPH::SoftBodySharedSettings::CalculateVolumeConstraintVolumes`.
        public unsafe void CalculateVolumeConstraintVolumes()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_CalculateVolumeConstraintVolumes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_CalculateVolumeConstraintVolumes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodySharedSettings_CalculateVolumeConstraintVolumes(_Underlying *_this);
            __JPH_SoftBodySharedSettings_CalculateVolumeConstraintVolumes(_UnderlyingPtr);
        }

        /// Calculate information needed to be able to calculate the skinned constraint normals at run-time
        /// Generated from method `JPH::SoftBodySharedSettings::CalculateSkinnedConstraintNormals`.
        public unsafe void CalculateSkinnedConstraintNormals()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_CalculateSkinnedConstraintNormals", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_CalculateSkinnedConstraintNormals", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodySharedSettings_CalculateSkinnedConstraintNormals(_Underlying *_this);
            __JPH_SoftBodySharedSettings_CalculateSkinnedConstraintNormals(_UnderlyingPtr);
        }

        /// Optimize the soft body settings for simulation. This will reorder constraints so they can be executed in parallel.
        /// Generated from method `JPH::SoftBodySharedSettings::Optimize`.
        public unsafe void Optimize(JPH.SoftBodySharedSettings.OptimizationResults outResults)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Optimize_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Optimize_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodySharedSettings_Optimize_1(_Underlying *_this, JPH.SoftBodySharedSettings.OptimizationResults._Underlying *outResults);
            __JPH_SoftBodySharedSettings_Optimize_1(_UnderlyingPtr, outResults._UnderlyingPtr);
        }

        /// Optimize the soft body settings without results
        /// Generated from method `JPH::SoftBodySharedSettings::Optimize`.
        public unsafe void Optimize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Optimize_0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_Optimize_0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodySharedSettings_Optimize_0(_Underlying *_this);
            __JPH_SoftBodySharedSettings_Optimize_0(_UnderlyingPtr);
        }

        /// Add a face to this soft body
        /// Generated from method `JPH::SoftBodySharedSettings::AddFace`.
        public unsafe void AddFace(JPH.SoftBodySharedSettings.Const_Face inFace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodySharedSettings_AddFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodySharedSettings_AddFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodySharedSettings_AddFace(_Underlying *_this, JPH.SoftBodySharedSettings.Const_Face._Underlying *inFace);
            __JPH_SoftBodySharedSettings_AddFace(_UnderlyingPtr, inFace._UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `SoftBodySharedSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `SoftBodySharedSettings`/`Const_SoftBodySharedSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_SoftBodySharedSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_SoftBodySharedSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_SoftBodySharedSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_SoftBodySharedSettings(Const_SoftBodySharedSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_SoftBodySharedSettings(Const_SoftBodySharedSettings arg) {return new(arg);}
        public _ByValue_SoftBodySharedSettings(JPH._Moved<SoftBodySharedSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_SoftBodySharedSettings(JPH._Moved<SoftBodySharedSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `SoftBodySharedSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SoftBodySharedSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SoftBodySharedSettings`/`Const_SoftBodySharedSettings` directly.
    public class _InOptMut_SoftBodySharedSettings
    {
        public SoftBodySharedSettings? Opt;

        public _InOptMut_SoftBodySharedSettings() {}
        public _InOptMut_SoftBodySharedSettings(SoftBodySharedSettings value) {Opt = value;}
        public static implicit operator _InOptMut_SoftBodySharedSettings(SoftBodySharedSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `SoftBodySharedSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SoftBodySharedSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SoftBodySharedSettings`/`Const_SoftBodySharedSettings` to pass it to the function.
    public class _InOptConst_SoftBodySharedSettings
    {
        public Const_SoftBodySharedSettings? Opt;

        public _InOptConst_SoftBodySharedSettings() {}
        public _InOptConst_SoftBodySharedSettings(Const_SoftBodySharedSettings value) {Opt = value;}
        public static implicit operator _InOptConst_SoftBodySharedSettings(Const_SoftBodySharedSettings value) {return new(value);}
    }
}
