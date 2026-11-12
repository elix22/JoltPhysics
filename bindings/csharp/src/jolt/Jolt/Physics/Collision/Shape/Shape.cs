// machine generated, do not edit
public static partial class JPH
{
    /// Class that can construct shapes and that is serializable using the ObjectStream system.
    /// Can be used to store shape data in 'uncooked' form (i.e. in a form that is still human readable and authorable).
    /// Once the shape has been created using the Create() function, the data will be moved into the Shape class
    /// in a form that is optimized for collision detection. After this, the ShapeSettings object is no longer needed
    /// and can be destroyed. Each shape class has a derived class of the ShapeSettings object to store shape specific
    /// data.
    /// Generated from class `JPH::ShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CompoundShapeSettings`
    ///     `JPH::ConvexShapeSettings`
    ///     `JPH::DecoratedShapeSettings`
    ///     `JPH::EmptyShapeSettings`
    ///     `JPH::HeightFieldShapeSettings`
    ///     `JPH::MeshShapeSettings`
    ///     `JPH::PlaneShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::BoxShapeSettings`
    ///     `JPH::CapsuleShapeSettings`
    ///     `JPH::ConvexHullShapeSettings`
    ///     `JPH::CylinderShapeSettings`
    ///     `JPH::MutableCompoundShapeSettings`
    ///     `JPH::OffsetCenterOfMassShapeSettings`
    ///     `JPH::RotatedTranslatedShapeSettings`
    ///     `JPH::ScaledShapeSettings`
    ///     `JPH::SphereShapeSettings`
    ///     `JPH::StaticCompoundShapeSettings`
    ///     `JPH::TaperedCapsuleShapeSettings`
    ///     `JPH::TaperedCylinderShapeSettings`
    ///     `JPH::TriangleShapeSettings`
    /// This is the const half of the class.
    public class Const_ShapeSettings : JPH.Object<Const_ShapeSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ShapeSettings_Release(void *_this);
            __JPH_RefTarget_JPH_ShapeSettings_Release(__JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ShapeSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_ShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_ShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_ShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShapeSettings(Const_ShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShapeSettings._Underlying *__JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHShapeSettings ret = new(__JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_ShapeSettings(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ShapeSettings_StaticDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            Const_ShapeSettings ret = new(__JPH_ShapeSettings_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_ShapeSettings(JPH.Const_RefTarget_JPHShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH.Const_RefTarget_JPHShapeSettings._Underlying *_this);
            Const_ShapeSettings ret = new(__JPH_ShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// User data (to be used freely by the application)
        public unsafe ulong mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong *__JPH_ShapeSettings_Get_mUserData(_Underlying *_this);
                return *__JPH_ShapeSettings_Get_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe Const_ShapeSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `JPH::ShapeSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ShapeSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_ShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::ShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_ShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_ShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ShapeSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ShapeSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_ShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::ShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_ShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_ShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ShapeSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_ShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_ShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::ShapeSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_ShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_ShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::ShapeSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ShapeSettings_SetEmbedded(_Underlying *_this);
            __JPH_ShapeSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::ShapeSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_ShapeSettings_GetRefCount(_Underlying *_this);
            return __JPH_ShapeSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::ShapeSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ShapeSettings_AddRef(_Underlying *_this);
            __JPH_ShapeSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::ShapeSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ShapeSettings_Release(_Underlying *_this);
            __JPH_ShapeSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::ShapeSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_ShapeSettings_sInternalGetRefCountOffset();
            return __JPH_ShapeSettings_sInternalGetRefCountOffset();
        }
    }

    /// Class that can construct shapes and that is serializable using the ObjectStream system.
    /// Can be used to store shape data in 'uncooked' form (i.e. in a form that is still human readable and authorable).
    /// Once the shape has been created using the Create() function, the data will be moved into the Shape class
    /// in a form that is optimized for collision detection. After this, the ShapeSettings object is no longer needed
    /// and can be destroyed. Each shape class has a derived class of the ShapeSettings object to store shape specific
    /// data.
    /// Generated from class `JPH::ShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ShapeSettings>`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CompoundShapeSettings`
    ///     `JPH::ConvexShapeSettings`
    ///     `JPH::DecoratedShapeSettings`
    ///     `JPH::EmptyShapeSettings`
    ///     `JPH::HeightFieldShapeSettings`
    ///     `JPH::MeshShapeSettings`
    ///     `JPH::PlaneShapeSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::BoxShapeSettings`
    ///     `JPH::CapsuleShapeSettings`
    ///     `JPH::ConvexHullShapeSettings`
    ///     `JPH::CylinderShapeSettings`
    ///     `JPH::MutableCompoundShapeSettings`
    ///     `JPH::OffsetCenterOfMassShapeSettings`
    ///     `JPH::RotatedTranslatedShapeSettings`
    ///     `JPH::ScaledShapeSettings`
    ///     `JPH::SphereShapeSettings`
    ///     `JPH::StaticCompoundShapeSettings`
    ///     `JPH::TaperedCapsuleShapeSettings`
    ///     `JPH::TaperedCylinderShapeSettings`
    ///     `JPH::TriangleShapeSettings`
    /// This is the non-const half of the class.
    public class ShapeSettings : Const_ShapeSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(ShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_ShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_ShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_SerializableObject(ShapeSettings self)
            => (JPH.Const_SerializableObject)(JPH.Const_ShapeSettings)self;
        public static unsafe implicit operator JPH.RefTarget_JPHShapeSettings(ShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
            JPH.RefTarget_JPHShapeSettings ret = new(__JPH_ShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShapeSettings(ShapeSettings self)
            => (JPH.Const_RefTarget_JPHShapeSettings)(JPH.Const_ShapeSettings)self;

        // Downcasts:
        public static unsafe explicit operator ShapeSettings(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ShapeSettings_StaticDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            ShapeSettings ret = new(__JPH_ShapeSettings_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator ShapeSettings(JPH.RefTarget_JPHShapeSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(JPH.RefTarget_JPHShapeSettings._Underlying *_this);
            ShapeSettings ret = new(__JPH_ShapeSettings_StaticDowncastFrom_JPH_RefTarget_JPH_ShapeSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// User data (to be used freely by the application)
        public new unsafe ref ulong mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong *__JPH_ShapeSettings_GetMutable_mUserData(_Underlying *_this);
                return ref *__JPH_ShapeSettings_GetMutable_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe ShapeSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// When creating a shape, the result is cached so that calling Create() again will return the same shape.
        /// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
        /// Generated from method `JPH::ShapeSettings::ClearCachedResult`.
        public unsafe void ClearCachedResult()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ShapeSettings_ClearCachedResult(_Underlying *_this);
            __JPH_ShapeSettings_ClearCachedResult(_UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `ShapeSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ShapeSettings`/`Const_ShapeSettings` directly.
    public class _InOptMut_ShapeSettings
    {
        public ShapeSettings? Opt;

        public _InOptMut_ShapeSettings() {}
        public _InOptMut_ShapeSettings(ShapeSettings value) {Opt = value;}
        public static implicit operator _InOptMut_ShapeSettings(ShapeSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `ShapeSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ShapeSettings`/`Const_ShapeSettings` to pass it to the function.
    public class _InOptConst_ShapeSettings
    {
        public Const_ShapeSettings? Opt;

        public _InOptConst_ShapeSettings() {}
        public _InOptConst_ShapeSettings(Const_ShapeSettings value) {Opt = value;}
        public static implicit operator _InOptConst_ShapeSettings(Const_ShapeSettings value) {return new(value);}
    }

    /// Base class for all shapes (collision volume of a body). Defines a virtual interface for collision detection.
    /// Generated from class `JPH::Shape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CompoundShape`
    ///     `JPH::ConvexShape`
    ///     `JPH::DecoratedShape`
    ///     `JPH::EmptyShape`
    ///     `JPH::HeightFieldShape`
    ///     `JPH::MeshShape`
    ///     `JPH::PlaneShape`
    ///     `JPH::SoftBodyShape`
    ///   Indirect: (non-virtual)
    ///     `JPH::BoxShape`
    ///     `JPH::CapsuleShape`
    ///     `JPH::ConvexHullShape`
    ///     `JPH::CylinderShape`
    ///     `JPH::MutableCompoundShape`
    ///     `JPH::OffsetCenterOfMassShape`
    ///     `JPH::RotatedTranslatedShape`
    ///     `JPH::ScaledShape`
    ///     `JPH::SphereShape`
    ///     `JPH::StaticCompoundShape`
    ///     `JPH::TaperedCapsuleShape`
    ///     `JPH::TaperedCylinderShape`
    ///     `JPH::TriangleShape`
    /// This is the const half of the class.
    public class Const_Shape : JPH.Object<Const_Shape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Shape_Release(void *_this);
            __JPH_RefTarget_JPH_Shape_Release(__JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Shape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShape(Const_Shape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHShape._Underlying *__JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.Const_RefTarget_JPHShape ret = new(__JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_Shape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_Shape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_Shape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_Shape(JPH.Const_RefTarget_JPHShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Shape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH.Const_RefTarget_JPHShape._Underlying *_this);
            Const_Shape ret = new(__JPH_Shape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_Shape(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Shape_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_Shape ret = new(__JPH_Shape_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
        public static unsafe int CGetTrianglesMinTrianglesRequested
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_Shape_Get_cGetTrianglesMinTrianglesRequested();
                return *__JPH_Shape_Get_cGetTrianglesMinTrianglesRequested();
            }
        }

        /// Debug helper which draws the intersection between water and the shapes, the center of buoyancy and the submerged volume
        public static unsafe ref bool SDrawSubmergedVolumes
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetMutable_sDrawSubmergedVolumes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetMutable_sDrawSubmergedVolumes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_Shape_GetMutable_sDrawSubmergedVolumes();
                return ref *__JPH_Shape_GetMutable_sDrawSubmergedVolumes();
            }
        }

        internal unsafe Const_Shape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `JPH::Shape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Shape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Shape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Shape_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_Shape_size_t(inCount);
        }

        /// Generated from method `JPH::Shape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Shape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Shape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Shape_void_ptr(void *inPointer);
            __Jolt_delete_JPH_Shape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Shape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Shape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Shape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Shape_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_Shape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Shape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Shape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Shape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Shape_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_Shape_size_t(inCount);
        }

        /// Generated from method `JPH::Shape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Shape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Shape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Shape_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_Shape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Shape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Shape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Shape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Shape_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_Shape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Shape::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Shape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Shape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Shape_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_Shape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Shape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Shape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Shape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Shape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_Shape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::Shape::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Shape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Shape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Shape_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_Shape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Shape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Shape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Shape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Shape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_Shape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// User data (to be used freely by the application)
        /// Generated from method `JPH::Shape::GetUserData`.
        public unsafe ulong GetUserData()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __JPH_Shape_GetUserData(_Underlying *_this);
            return __JPH_Shape_GetUserData(_UnderlyingPtr);
        }

        /// Check if this shape can only be used to create a static body or if it can also be dynamic/kinematic
        /// Generated from method `JPH::Shape::MustBeStatic`.
        public unsafe bool MustBeStatic()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Shape_MustBeStatic(_Underlying *_this);
            return __JPH_Shape_MustBeStatic(_UnderlyingPtr) != 0;
        }

        /// All shapes are centered around their center of mass. This function returns the center of mass position that needs to be applied to transform the shape to where it was created.
        /// Generated from method `JPH::Shape::GetCenterOfMass`.
        public unsafe JPH.Vec3 GetCenterOfMass()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetCenterOfMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Shape_GetCenterOfMass(_Underlying *_this);
            return new(__JPH_Shape_GetCenterOfMass(_UnderlyingPtr), is_owning: true);
        }

        /// Get local bounding box including convex radius, this box is centered around the center of mass rather than the world transform
        /// Generated from method `JPH::Shape::GetLocalBounds`.
        public unsafe JPH.AABox GetLocalBounds()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_Shape_GetLocalBounds(_Underlying *_this);
            return new(__JPH_Shape_GetLocalBounds(_UnderlyingPtr), is_owning: true);
        }

        /// Get the max number of sub shape ID bits that are needed to be able to address any leaf shape in this shape. Used mainly for checking that it is smaller or equal than SubShapeID::MaxBits.
        /// Generated from method `JPH::Shape::GetSubShapeIDBitsRecursive`.
        public unsafe uint GetSubShapeIDBitsRecursive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_Shape_GetSubShapeIDBitsRecursive(_Underlying *_this);
            return __JPH_Shape_GetSubShapeIDBitsRecursive(_UnderlyingPtr);
        }

        /// Get world space bounds including convex radius.
        /// This shape is scaled by inScale in local space first.
        /// This function can be overridden to return a closer fitting world space bounding box, by default it will just transform what GetLocalBounds() returns.
        /// Generated from method `JPH::Shape::GetWorldSpaceBounds`.
        public unsafe JPH.AABox GetWorldSpaceBounds(JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetWorldSpaceBounds_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetWorldSpaceBounds_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_Shape_GetWorldSpaceBounds_JPH_Mat44(_Underlying *_this, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale);
            return new(__JPH_Shape_GetWorldSpaceBounds_JPH_Mat44(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// Get world space bounds including convex radius.
        /// Generated from method `JPH::Shape::GetWorldSpaceBounds`.
        public unsafe JPH.AABox GetWorldSpaceBounds(JPH.Const_DMat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetWorldSpaceBounds_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetWorldSpaceBounds_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_Shape_GetWorldSpaceBounds_JPH_DMat44(_Underlying *_this, JPH.Const_DMat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale);
            return new(__JPH_Shape_GetWorldSpaceBounds_JPH_DMat44(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// Returns the radius of the biggest sphere that fits entirely in the shape. In case this shape consists of multiple sub shapes, it returns the smallest sphere of the parts.
        /// This can be used as a measure of how far the shape can be moved without risking going through geometry.
        /// Generated from method `JPH::Shape::GetInnerRadius`.
        public unsafe float GetInnerRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Shape_GetInnerRadius(_Underlying *_this);
            return __JPH_Shape_GetInnerRadius(_UnderlyingPtr);
        }

        /// Get the leaf shape for a particular sub shape ID.
        /// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
        /// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
        /// @return The shape or null if the sub shape ID is invalid
        /// Generated from method `JPH::Shape::GetLeafShape`.
        public unsafe JPH.Const_Shape? GetLeafShape(JPH.Const_SubShapeID inSubShapeID, JPH.SubShapeID outRemainder)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_Shape_GetLeafShape(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.SubShapeID._Underlying *outRemainder);
            var __c_ret = __JPH_Shape_GetLeafShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_Shape(__c_ret, is_owning: false) : null;
        }

        /// Get the material assigned to a particular sub shape ID
        /// Generated from method `JPH::Shape::GetMaterial`.
        public unsafe JPH.Const_PhysicsMaterial? GetMaterial(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_PhysicsMaterial._Underlying *__JPH_Shape_GetMaterial(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            var __c_ret = __JPH_Shape_GetMaterial(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
        }

        /// Get the surface normal of a particular sub shape ID and point on surface (all vectors are relative to center of mass for this shape).
        /// Note: When you have a CollideShapeResult or ShapeCastResult you should use -mPenetrationAxis.Normalized() as contact normal as GetSurfaceNormal will only return face normals (and not vertex or edge normals).
        /// Generated from method `JPH::Shape::GetSurfaceNormal`.
        public unsafe JPH.Vec3 GetSurfaceNormal(JPH.Const_SubShapeID inSubShapeID, JPH.Const_Vec3 inLocalSurfacePosition)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Shape_GetSurfaceNormal(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.Vec3._Underlying *inLocalSurfacePosition);
            return new(__JPH_Shape_GetSurfaceNormal(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, inLocalSurfacePosition._UnderlyingPtr), is_owning: true);
        }

        /// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
        /// Generated from method `JPH::Shape::GetSubShapeUserData`.
        public unsafe ulong GetSubShapeUserData(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __JPH_Shape_GetSubShapeUserData(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            return __JPH_Shape_GetSubShapeUserData(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
        }

        /// Get the direct child sub shape and its transform for a sub shape ID.
        /// @param inSubShapeID Sub shape ID that indicates the path to the leaf shape
        /// @param inPositionCOM The position of the center of mass of this shape
        /// @param inRotation The orientation of this shape
        /// @param inScale Scale in local space of the shape (scales relative to its center of mass)
        /// @param outRemainder The remainder of the sub shape ID after removing the sub shape
        /// @return Direct child sub shape and its transform, note that the body ID and sub shape ID will be invalid
        /// Generated from method `JPH::Shape::GetSubShapeTransformedShape`.
        public unsafe JPH.TransformedShape GetSubShapeTransformedShape(JPH.Const_SubShapeID inSubShapeID, JPH.Const_Vec3 inPositionCOM, JPH.Const_Quat inRotation, JPH.Const_Vec3 inScale, JPH.SubShapeID outRemainder)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetSubShapeTransformedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetSubShapeTransformedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TransformedShape._Underlying *__JPH_Shape_GetSubShapeTransformedShape(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.Vec3._Underlying *inPositionCOM, JPH.Quat._Underlying *inRotation, JPH.Vec3._Underlying *inScale, JPH.SubShapeID._Underlying *outRemainder);
            return new(__JPH_Shape_GetSubShapeTransformedShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, inPositionCOM._UnderlyingPtr, inRotation._UnderlyingPtr, inScale._UnderlyingPtr, outRemainder._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Shape::GetSubmergedVolume`.
        public unsafe void GetSubmergedVolume(JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale, JPH.Const_Plane inSurface, ref float outTotalVolume, ref float outSubmergedVolume, JPH.Vec3 outCenterOfBuoyancy, JPH.Const_Vec3 inBaseOffset)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetSubmergedVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetSubmergedVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Shape_GetSubmergedVolume(_Underlying *_this, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale, JPH.Const_Plane._Underlying *inSurface, float *outTotalVolume, float *outSubmergedVolume, JPH.Vec3._Underlying *outCenterOfBuoyancy, JPH.Vec3._Underlying *inBaseOffset);
            fixed (float *__ptr_outTotalVolume = &outTotalVolume)
            {
                fixed (float *__ptr_outSubmergedVolume = &outSubmergedVolume)
                {
                    __JPH_Shape_GetSubmergedVolume(_UnderlyingPtr, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr, inSurface._UnderlyingPtr, __ptr_outTotalVolume, __ptr_outSubmergedVolume, outCenterOfBuoyancy._UnderlyingPtr, inBaseOffset._UnderlyingPtr);
                }
            }
        }

        /// Draw the shape at a particular location with a particular color (debugging purposes)
        /// Generated from method `JPH::Shape::Draw`.
        public unsafe void Draw(JPH.DebugRenderer? inRenderer, JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale, JPH.Const_Color inColor, bool inUseMaterialColors, bool inDrawWireframe)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_Draw", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_Draw", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Shape_Draw(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale, JPH.Color._Underlying *inColor, byte inUseMaterialColors, byte inDrawWireframe);
            __JPH_Shape_Draw(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr, inColor._UnderlyingPtr, inUseMaterialColors ? (byte)1 : (byte)0, inDrawWireframe ? (byte)1 : (byte)0);
        }

        /// Draw the results of the GetSupportFunction with the convex radius added back on to show any errors introduced by this process (only relevant for convex shapes)
        /// Generated from method `JPH::Shape::DrawGetSupportFunction`.
        public unsafe void DrawGetSupportFunction(JPH.DebugRenderer? inRenderer, JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale, JPH.Const_Color inColor, bool inDrawSupportDirection)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_DrawGetSupportFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_DrawGetSupportFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Shape_DrawGetSupportFunction(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale, JPH.Color._Underlying *inColor, byte inDrawSupportDirection);
            __JPH_Shape_DrawGetSupportFunction(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr, inColor._UnderlyingPtr, inDrawSupportDirection ? (byte)1 : (byte)0);
        }

        /// Draw the results of the GetSupportingFace function to show any errors introduced by this process (only relevant for convex shapes)
        /// Generated from method `JPH::Shape::DrawGetSupportingFace`.
        public unsafe void DrawGetSupportingFace(JPH.DebugRenderer? inRenderer, JPH.Const_Mat44 inCenterOfMassTransform, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_DrawGetSupportingFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_DrawGetSupportingFace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Shape_DrawGetSupportingFace(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer, JPH.Const_Mat44._Underlying *inCenterOfMassTransform, JPH.Vec3._Underlying *inScale);
            __JPH_Shape_DrawGetSupportingFace(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inCenterOfMassTransform._UnderlyingPtr, inScale._UnderlyingPtr);
        }

        /// Cast a ray against this shape, returns true if it finds a hit closer than ioHit.mFraction and updates that fraction. Otherwise ioHit is left untouched and the function returns false.
        /// Note that the ray should be relative to the center of mass of this shape (i.e. subtract Shape::GetCenterOfMass() from RayCast::mOrigin if you want to cast against the shape in the space it was created).
        /// Convex objects will be treated as solid (meaning if the ray starts inside, you'll get a hit fraction of 0) and back face hits against triangles are returned.
        /// If you want the surface normal of the hit use GetSurfaceNormal(ioHit.mSubShapeID2, inRay.GetPointOnRay(ioHit.mFraction)).
        /// Generated from method `JPH::Shape::CastRay`.
        public unsafe bool CastRay(JPH.Const_RayCast inRay, JPH.Const_SubShapeIDCreator inSubShapeIDCreator, JPH.RayCastResult ioHit)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_CastRay_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_CastRay_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Shape_CastRay_3(_Underlying *_this, JPH.Const_RayCast._Underlying *inRay, JPH.Const_SubShapeIDCreator._Underlying *inSubShapeIDCreator, JPH.RayCastResult._Underlying *ioHit);
            return __JPH_Shape_CastRay_3(_UnderlyingPtr, inRay._UnderlyingPtr, inSubShapeIDCreator._UnderlyingPtr, ioHit._UnderlyingPtr) != 0;
        }

        /// To start iterating over triangles, call this function first.
        /// ioContext is a temporary buffer and should remain untouched until the last call to GetTrianglesNext.
        /// inBox is the world space bounding in which you want to get the triangles.
        /// inPositionCOM/inRotation/inScale describes the transform of this shape.
        /// To get the actual triangles call GetTrianglesNext.
        /// Generated from method `JPH::Shape::GetTrianglesStart`.
        public unsafe void GetTrianglesStart(JPH.Shape.GetTrianglesContext ioContext, JPH.Const_AABox inBox, JPH.Const_Vec3 inPositionCOM, JPH.Const_Quat inRotation, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Shape_GetTrianglesStart(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, JPH.Const_AABox._Underlying *inBox, JPH.Vec3._Underlying *inPositionCOM, JPH.Quat._Underlying *inRotation, JPH.Vec3._Underlying *inScale);
            __JPH_Shape_GetTrianglesStart(_UnderlyingPtr, ioContext._UnderlyingPtr, inBox._UnderlyingPtr, inPositionCOM._UnderlyingPtr, inRotation._UnderlyingPtr, inScale._UnderlyingPtr);
        }

        /// Call this repeatedly to get all triangles in the box.
        /// outTriangleVertices should be large enough to hold 3 * inMaxTriangleRequested entries.
        /// outMaterials (if it is not null) should contain inMaxTrianglesRequested entries.
        /// The function returns the amount of triangles that it found (which will be <= inMaxTrianglesRequested), or 0 if there are no more triangles.
        /// Note that the function can return a value < inMaxTrianglesRequested and still have more triangles to process (triangles can be returned in blocks).
        /// Note that the function may return triangles outside of the requested box, only coarse culling is performed on the returned triangles.
        /// Generated from method `JPH::Shape::GetTrianglesNext`.
        public unsafe int GetTrianglesNext(JPH.Shape.GetTrianglesContext ioContext, int inMaxTrianglesRequested, JPH.Float3? outTriangleVertices, void **outMaterials = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_Shape_GetTrianglesNext(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, int inMaxTrianglesRequested, JPH.Float3._Underlying *outTriangleVertices, void **outMaterials);
            return __JPH_Shape_GetTrianglesNext(_UnderlyingPtr, ioContext._UnderlyingPtr, inMaxTrianglesRequested, outTriangleVertices is not null ? outTriangleVertices._UnderlyingPtr : null, outMaterials);
        }

        /// Get stats of this shape. Use for logging / data collection purposes only. Does not add values from child shapes, use GetStatsRecursive for this.
        /// Generated from method `JPH::Shape::GetStats`.
        public unsafe JPH.Shape.Stats GetStats()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Shape.Stats._Underlying *__JPH_Shape_GetStats(_Underlying *_this);
            return new(__JPH_Shape_GetStats(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Shape::GetVolume`.
        public unsafe float GetVolume()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Shape_GetVolume(_Underlying *_this);
            return __JPH_Shape_GetVolume(_UnderlyingPtr);
        }

        /// Test if inScale is a valid scale for this shape. Some shapes can only be scaled uniformly, compound shapes cannot handle shapes
        /// being rotated and scaled (this would cause shearing), scale can never be zero. When the scale is invalid, the function will return false.
        ///
        /// Here's a list of supported scales:
        /// * SphereShape: Scale must be uniform (signs of scale are ignored).
        /// * BoxShape: Any scale supported (signs of scale are ignored).
        /// * TriangleShape: Any scale supported when convex radius is zero, otherwise only uniform scale supported.
        /// * CapsuleShape: Scale must be uniform (signs of scale are ignored).
        /// * TaperedCapsuleShape: Scale must be uniform (sign of Y scale can be used to flip the capsule).
        /// * CylinderShape: Scale must be uniform in XZ plane, Y can scale independently (signs of scale are ignored).
        /// * RotatedTranslatedShape: Scale must not cause shear in the child shape.
        /// * CompoundShape: Scale must not cause shear in any of the child shapes.
        /// Generated from method `JPH::Shape::IsValidScale`.
        public unsafe bool IsValidScale(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_IsValidScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Shape_IsValidScale(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return __JPH_Shape_IsValidScale(_UnderlyingPtr, inScale._UnderlyingPtr) != 0;
        }

        /// This function will make sure that if you wrap this shape in a ScaledShape that the scale is valid.
        /// Note that this involves discarding components of the scale that are invalid, so the resulting scaled shape may be different than the requested scale.
        /// Compare the return value of this function with the scale you passed in to detect major inconsistencies and possibly warn the user.
        /// @param inScale Local space scale for this shape.
        /// @return Scale that can be used to wrap this shape in a ScaledShape. IsValidScale will return true for this scale.
        /// Generated from method `JPH::Shape::MakeScaleValid`.
        public unsafe JPH.Vec3 MakeScaleValid(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_MakeScaleValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Shape_MakeScaleValid(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return new(__JPH_Shape_MakeScaleValid(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::Shape::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Shape_SetEmbedded(_Underlying *_this);
            __JPH_Shape_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::Shape::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_Shape_GetRefCount(_Underlying *_this);
            return __JPH_Shape_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::Shape::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Shape_AddRef(_Underlying *_this);
            __JPH_Shape_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::Shape::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Shape_Release(_Underlying *_this);
            __JPH_Shape_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::Shape::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_Shape_sInternalGetRefCountOffset();
            return __JPH_Shape_sInternalGetRefCountOffset();
        }

        /// An opaque buffer that holds shape specific information during GetTrianglesStart/Next.
        /// Generated from class `JPH::Shape::GetTrianglesContext`.
        /// This is the const half of the class.
        public class Const_GetTrianglesContext : JPH.Object<Const_GetTrianglesContext>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Shape_GetTrianglesContext_Destroy(_Underlying *_this);
                __JPH_Shape_GetTrianglesContext_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_GetTrianglesContext() {Dispose(false);}

            public unsafe ref JPH.ArrayUnsignedChar4288 mData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_Get_mData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_Get_mData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedChar4288 *__JPH_Shape_GetTrianglesContext_Get_mData(_Underlying *_this);
                    return ref *(__JPH_Shape_GetTrianglesContext_Get_mData(_UnderlyingPtr));
                }
            }

            internal unsafe Const_GetTrianglesContext(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_GetTrianglesContext() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Shape.GetTrianglesContext._Underlying *__JPH_Shape_GetTrianglesContext_DefaultConstruct();
                _UnderlyingPtr = __JPH_Shape_GetTrianglesContext_DefaultConstruct();
            }

            /// Generated from constructor `JPH::Shape::GetTrianglesContext::GetTrianglesContext`.
            public unsafe Const_GetTrianglesContext(JPH.Shape.Const_GetTrianglesContext _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Shape.GetTrianglesContext._Underlying *__JPH_Shape_GetTrianglesContext_ConstructFromAnother(JPH.Shape.GetTrianglesContext._Underlying *_other);
                _UnderlyingPtr = __JPH_Shape_GetTrianglesContext_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::Shape::GetTrianglesContext::GetTrianglesContext`.
            public Const_GetTrianglesContext(GetTrianglesContext _other) : this((Const_GetTrianglesContext)_other) {}
        }

        /// An opaque buffer that holds shape specific information during GetTrianglesStart/Next.
        /// Generated from class `JPH::Shape::GetTrianglesContext`.
        /// This is the non-const half of the class.
        public class GetTrianglesContext : Const_GetTrianglesContext
        {
            new public unsafe ref JPH.ArrayUnsignedChar4288 mData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_GetMutable_mData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_GetMutable_mData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayUnsignedChar4288 *__JPH_Shape_GetTrianglesContext_GetMutable_mData(_Underlying *_this);
                    return ref *(__JPH_Shape_GetTrianglesContext_GetMutable_mData(_UnderlyingPtr));
                }
            }

            internal unsafe GetTrianglesContext(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe GetTrianglesContext() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Shape.GetTrianglesContext._Underlying *__JPH_Shape_GetTrianglesContext_DefaultConstruct();
                _UnderlyingPtr = __JPH_Shape_GetTrianglesContext_DefaultConstruct();
            }

            /// Generated from constructor `JPH::Shape::GetTrianglesContext::GetTrianglesContext`.
            public unsafe GetTrianglesContext(JPH.Shape.Const_GetTrianglesContext _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Shape.GetTrianglesContext._Underlying *__JPH_Shape_GetTrianglesContext_ConstructFromAnother(JPH.Shape.GetTrianglesContext._Underlying *_other);
                _UnderlyingPtr = __JPH_Shape_GetTrianglesContext_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::Shape::GetTrianglesContext::GetTrianglesContext`.
            public GetTrianglesContext(GetTrianglesContext _other) : this((Const_GetTrianglesContext)_other) {}

            /// Generated from method `JPH::Shape::GetTrianglesContext::operator=`.
            public unsafe JPH.Shape.GetTrianglesContext Assign(JPH.Shape.Const_GetTrianglesContext _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_GetTrianglesContext_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Shape.GetTrianglesContext._Underlying *__JPH_Shape_GetTrianglesContext_AssignFromAnother(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_Shape_GetTrianglesContext_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `GetTrianglesContext` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_GetTrianglesContext`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `GetTrianglesContext`/`Const_GetTrianglesContext` directly.
        public class _InOptMut_GetTrianglesContext
        {
            public GetTrianglesContext? Opt;

            public _InOptMut_GetTrianglesContext() {}
            public _InOptMut_GetTrianglesContext(GetTrianglesContext value) {Opt = value;}
            public static implicit operator _InOptMut_GetTrianglesContext(GetTrianglesContext value) {return new(value);}
        }

        /// This is used for optional parameters of class `GetTrianglesContext` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_GetTrianglesContext`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `GetTrianglesContext`/`Const_GetTrianglesContext` to pass it to the function.
        public class _InOptConst_GetTrianglesContext
        {
            public Const_GetTrianglesContext? Opt;

            public _InOptConst_GetTrianglesContext() {}
            public _InOptConst_GetTrianglesContext(Const_GetTrianglesContext value) {Opt = value;}
            public static implicit operator _InOptConst_GetTrianglesContext(Const_GetTrianglesContext value) {return new(value);}
        }

        /// Class that holds information about the shape that can be used for logging / data collection purposes
        /// Generated from class `JPH::Shape::Stats`.
        /// This is the const half of the class.
        public class Const_Stats : JPH.Object<Const_Stats>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_Stats_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_Stats_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Shape_Stats_Destroy(_Underlying *_this);
                __JPH_Shape_Stats_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Stats() {Dispose(false);}

            ///< Amount of memory used by this shape (size in bytes)
            public unsafe UIntPtr mSizeBytes
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_Stats_Get_mSizeBytes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_Stats_Get_mSizeBytes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static UIntPtr *__JPH_Shape_Stats_Get_mSizeBytes(_Underlying *_this);
                    return *__JPH_Shape_Stats_Get_mSizeBytes(_UnderlyingPtr);
                }
            }

            ///< Number of triangles in this shape (when applicable)
            public unsafe uint mNumTriangles
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_Stats_Get_mNumTriangles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_Stats_Get_mNumTriangles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_Shape_Stats_Get_mNumTriangles(_Underlying *_this);
                    return *__JPH_Shape_Stats_Get_mNumTriangles(_UnderlyingPtr);
                }
            }

            internal unsafe Const_Stats(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from constructor `JPH::Shape::Stats::Stats`.
            public unsafe Const_Stats(JPH.Shape.Const_Stats _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_Stats_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_Stats_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Shape.Stats._Underlying *__JPH_Shape_Stats_ConstructFromAnother(JPH.Shape.Stats._Underlying *_other);
                _UnderlyingPtr = __JPH_Shape_Stats_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::Shape::Stats::Stats`.
            public Const_Stats(Stats _other) : this((Const_Stats)_other) {}

            /// Generated from constructor `JPH::Shape::Stats::Stats`.
            public unsafe Const_Stats(UIntPtr inSizeBytes, uint inNumTriangles) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_Stats_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_Stats_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Shape.Stats._Underlying *__JPH_Shape_Stats_Construct(UIntPtr inSizeBytes, uint inNumTriangles);
                _UnderlyingPtr = __JPH_Shape_Stats_Construct(inSizeBytes, inNumTriangles);
            }
        }

        /// Class that holds information about the shape that can be used for logging / data collection purposes
        /// Generated from class `JPH::Shape::Stats`.
        /// This is the non-const half of the class.
        public class Stats : Const_Stats
        {
            ///< Amount of memory used by this shape (size in bytes)
            public new unsafe ref UIntPtr mSizeBytes
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_Stats_GetMutable_mSizeBytes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_Stats_GetMutable_mSizeBytes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static UIntPtr *__JPH_Shape_Stats_GetMutable_mSizeBytes(_Underlying *_this);
                    return ref *__JPH_Shape_Stats_GetMutable_mSizeBytes(_UnderlyingPtr);
                }
            }

            ///< Number of triangles in this shape (when applicable)
            public new unsafe ref uint mNumTriangles
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_Stats_GetMutable_mNumTriangles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_Stats_GetMutable_mNumTriangles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_Shape_Stats_GetMutable_mNumTriangles(_Underlying *_this);
                    return ref *__JPH_Shape_Stats_GetMutable_mNumTriangles(_UnderlyingPtr);
                }
            }

            internal unsafe Stats(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Generated from constructor `JPH::Shape::Stats::Stats`.
            public unsafe Stats(JPH.Shape.Const_Stats _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_Stats_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_Stats_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Shape.Stats._Underlying *__JPH_Shape_Stats_ConstructFromAnother(JPH.Shape.Stats._Underlying *_other);
                _UnderlyingPtr = __JPH_Shape_Stats_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::Shape::Stats::Stats`.
            public Stats(Stats _other) : this((Const_Stats)_other) {}

            /// Generated from constructor `JPH::Shape::Stats::Stats`.
            public unsafe Stats(UIntPtr inSizeBytes, uint inNumTriangles) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_Stats_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_Stats_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Shape.Stats._Underlying *__JPH_Shape_Stats_Construct(UIntPtr inSizeBytes, uint inNumTriangles);
                _UnderlyingPtr = __JPH_Shape_Stats_Construct(inSizeBytes, inNumTriangles);
            }

            /// Generated from method `JPH::Shape::Stats::operator=`.
            public unsafe JPH.Shape.Stats Assign(JPH.Shape.Const_Stats _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_Stats_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_Stats_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Shape.Stats._Underlying *__JPH_Shape_Stats_AssignFromAnother(_Underlying *_this, JPH.Shape.Stats._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_Shape_Stats_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `Stats` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Stats`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Stats`/`Const_Stats` directly.
        public class _InOptMut_Stats
        {
            public Stats? Opt;

            public _InOptMut_Stats() {}
            public _InOptMut_Stats(Stats value) {Opt = value;}
            public static implicit operator _InOptMut_Stats(Stats value) {return new(value);}
        }

        /// This is used for optional parameters of class `Stats` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Stats`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Stats`/`Const_Stats` to pass it to the function.
        public class _InOptConst_Stats
        {
            public Const_Stats? Opt;

            public _InOptConst_Stats() {}
            public _InOptConst_Stats(Const_Stats value) {Opt = value;}
            public static implicit operator _InOptConst_Stats(Const_Stats value) {return new(value);}
        }
    }

    /// Base class for all shapes (collision volume of a body). Defines a virtual interface for collision detection.
    /// Generated from class `JPH::Shape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::Shape>`
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CompoundShape`
    ///     `JPH::ConvexShape`
    ///     `JPH::DecoratedShape`
    ///     `JPH::EmptyShape`
    ///     `JPH::HeightFieldShape`
    ///     `JPH::MeshShape`
    ///     `JPH::PlaneShape`
    ///     `JPH::SoftBodyShape`
    ///   Indirect: (non-virtual)
    ///     `JPH::BoxShape`
    ///     `JPH::CapsuleShape`
    ///     `JPH::ConvexHullShape`
    ///     `JPH::CylinderShape`
    ///     `JPH::MutableCompoundShape`
    ///     `JPH::OffsetCenterOfMassShape`
    ///     `JPH::RotatedTranslatedShape`
    ///     `JPH::ScaledShape`
    ///     `JPH::SphereShape`
    ///     `JPH::StaticCompoundShape`
    ///     `JPH::TaperedCapsuleShape`
    ///     `JPH::TaperedCylinderShape`
    ///     `JPH::TriangleShape`
    /// This is the non-const half of the class.
    public class Shape : Const_Shape
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHShape(Shape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHShape._Underlying *__JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
            JPH.RefTarget_JPHShape ret = new(__JPH_Shape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHShape(Shape self)
            => (JPH.Const_RefTarget_JPHShape)(JPH.Const_Shape)self;
        public static unsafe implicit operator JPH.NonCopyable(Shape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_Shape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_Shape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Shape self)
            => (JPH.Const_NonCopyable)(JPH.Const_Shape)self;

        // Downcasts:
        public static unsafe explicit operator Shape(JPH.RefTarget_JPHShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Shape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(JPH.RefTarget_JPHShape._Underlying *_this);
            Shape ret = new(__JPH_Shape_StaticDowncastFrom_JPH_RefTarget_JPH_Shape(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Shape(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Shape_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            Shape ret = new(__JPH_Shape_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Shape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from method `JPH::Shape::SetUserData`.
        public unsafe void SetUserData(ulong inUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Shape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Shape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Shape_SetUserData(_Underlying *_this, ulong inUserData);
            __JPH_Shape_SetUserData(_UnderlyingPtr, inUserData);
        }
    }

    /// This is used for optional parameters of class `Shape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Shape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Shape`/`Const_Shape` directly.
    public class _InOptMut_Shape
    {
        public Shape? Opt;

        public _InOptMut_Shape() {}
        public _InOptMut_Shape(Shape value) {Opt = value;}
        public static implicit operator _InOptMut_Shape(Shape value) {return new(value);}
    }

    /// This is used for optional parameters of class `Shape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Shape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Shape`/`Const_Shape` to pass it to the function.
    public class _InOptConst_Shape
    {
        public Const_Shape? Opt;

        public _InOptConst_Shape() {}
        public _InOptConst_Shape(Const_Shape value) {Opt = value;}
        public static implicit operator _InOptConst_Shape(Const_Shape value) {return new(value);}
    }
}
