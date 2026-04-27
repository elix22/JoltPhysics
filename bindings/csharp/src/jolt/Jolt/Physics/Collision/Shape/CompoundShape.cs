// machine generated, do not edit
public static partial class Jolt
{
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
        public class Const_CompoundShapeSettings : Jolt.Object<Const_CompoundShapeSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CompoundShapeSettings_Destroy(_Underlying *_this);
                __JPH_CompoundShapeSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_CompoundShapeSettings() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_SerializableObject(Const_CompoundShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_SerializableObject._Underlying *__JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.Const_SerializableObject ret = new(__JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHShapeSettings(Const_CompoundShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHShapeSettings._Underlying *__JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHShapeSettings ret = new(__JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_ShapeSettings(Const_CompoundShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_ShapeSettings._Underlying *__JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.Const_ShapeSettings ret = new(__JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_CompoundShapeSettings?(Jolt.JPH.Const_SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.Const_SerializableObject._Underlying *_this);
                var ptr = __JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_CompoundShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_CompoundShapeSettings?(Jolt.JPH.Const_ShapeSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(Jolt.JPH.Const_ShapeSettings._Underlying *_this);
                var ptr = __JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_CompoundShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
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
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_CompoundShapeSettings_size_t(ulong inCount);
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
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CompoundShapeSettings_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_CompoundShapeSettings_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::CompoundShapeSettings::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_CompoundShapeSettings_size_t(ulong inCount);
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
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_CompoundShapeSettings_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::CompoundShapeSettings::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_CompoundShapeSettings_size_t_void_ptr(ulong inCount, void *inPointer);
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
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_CompoundShapeSettings_size_t_void_ptr(ulong inCount, void *inPointer);
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
            public class Const_SubShapeSettings : Jolt.Object<Const_SubShapeSettings>, System.IDisposable
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
                    extern static Jolt.JPH.CompoundShapeSettings.SubShapeSettings._Underlying *__JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct();
                    _UnderlyingPtr = __JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct();
                }

                /// Generated from constructor `JPH::CompoundShapeSettings::SubShapeSettings::SubShapeSettings`.
                public unsafe Const_SubShapeSettings(Jolt.JPH.CompoundShapeSettings._ByValue_SubShapeSettings _other) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CompoundShapeSettings.SubShapeSettings._Underlying *__JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.CompoundShapeSettings.SubShapeSettings._Underlying *_other);
                    _UnderlyingPtr = __JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                    if (_other.Value is not null) _KeepAlive(_other.Value);
                }

                /// Generated from constructor `JPH::CompoundShapeSettings::SubShapeSettings::SubShapeSettings`.
                public Const_SubShapeSettings(Const_SubShapeSettings _other) : this(new _ByValue_SubShapeSettings(_other)) {}

                /// Generated from constructor `JPH::CompoundShapeSettings::SubShapeSettings::SubShapeSettings`.
                public Const_SubShapeSettings(SubShapeSettings _other) : this((Const_SubShapeSettings)_other) {}

                /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator new`.
                /// Returns a mutable pointer.
                public static unsafe void *New(ulong inCount)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void *__Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t(ulong inCount);
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
                public static unsafe void Delete(void *inPointer, ulong inSize)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t(void *inPointer, ulong inSize);
                    __Jolt_delete_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t(inPointer, inSize);
                }

                /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator new[]`.
                /// Returns a mutable pointer.
                public static unsafe void *NewArray(ulong inCount)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void *__Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t(ulong inCount);
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
                public static unsafe void DeleteArray(void *inPointer, ulong inSize)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t(void *inPointer, ulong inSize);
                    __Jolt_delete_array_JPH_CompoundShapeSettings_SubShapeSettings_void_ptr_size_t(inPointer, inSize);
                }

                /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator new`.
                /// Parameter `inPointer` is a mutable pointer.
                /// Returns a mutable pointer.
                public static unsafe void *New(ulong inCount, void *inPointer)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void *__Jolt_new_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr(ulong inCount, void *inPointer);
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
                public static unsafe void *NewArray(ulong inCount, void *inPointer)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void *__Jolt_new_array_JPH_CompoundShapeSettings_SubShapeSettings_size_t_void_ptr(ulong inCount, void *inPointer);
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
                    extern static Jolt.JPH.CompoundShapeSettings.SubShapeSettings._Underlying *__JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct();
                    _UnderlyingPtr = __JPH_CompoundShapeSettings_SubShapeSettings_DefaultConstruct();
                }

                /// Generated from constructor `JPH::CompoundShapeSettings::SubShapeSettings::SubShapeSettings`.
                public unsafe SubShapeSettings(Jolt.JPH.CompoundShapeSettings._ByValue_SubShapeSettings _other) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CompoundShapeSettings.SubShapeSettings._Underlying *__JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.CompoundShapeSettings.SubShapeSettings._Underlying *_other);
                    _UnderlyingPtr = __JPH_CompoundShapeSettings_SubShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                    if (_other.Value is not null) _KeepAlive(_other.Value);
                }

                /// Generated from constructor `JPH::CompoundShapeSettings::SubShapeSettings::SubShapeSettings`.
                public SubShapeSettings(Const_SubShapeSettings _other) : this(new _ByValue_SubShapeSettings(_other)) {}

                /// Generated from constructor `JPH::CompoundShapeSettings::SubShapeSettings::SubShapeSettings`.
                public SubShapeSettings(SubShapeSettings _other) : this((Const_SubShapeSettings)_other) {}

                /// Generated from method `JPH::CompoundShapeSettings::SubShapeSettings::operator=`.
                public unsafe Jolt.JPH.CompoundShapeSettings.SubShapeSettings Assign(Jolt.JPH.CompoundShapeSettings._ByValue_SubShapeSettings _other)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_SubShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CompoundShapeSettings.SubShapeSettings._Underlying *__JPH_CompoundShapeSettings_SubShapeSettings_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JPH.CompoundShapeSettings.SubShapeSettings._Underlying *_other);
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
                internal readonly Jolt._PassBy PassByMode;
                public _ByValue_SubShapeSettings() {PassByMode = Jolt._PassBy.default_construct;}
                public _ByValue_SubShapeSettings(Const_SubShapeSettings new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
                public static implicit operator _ByValue_SubShapeSettings(Const_SubShapeSettings arg) {return new(arg);}
                public _ByValue_SubShapeSettings(Jolt._Moved<SubShapeSettings> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
                public static implicit operator _ByValue_SubShapeSettings(Jolt._Moved<SubShapeSettings> arg) {return new(arg);}
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
            public static unsafe implicit operator Jolt.JPH.SerializableObject(CompoundShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SerializableObject._Underlying *__JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.SerializableObject ret = new(__JPH_CompoundShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHShapeSettings(CompoundShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHShapeSettings ret = new(__JPH_CompoundShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.ShapeSettings(CompoundShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.ShapeSettings._Underlying *__JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.ShapeSettings ret = new(__JPH_CompoundShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator CompoundShapeSettings?(Jolt.JPH.SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.SerializableObject._Underlying *_this);
                var ptr = __JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                CompoundShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator CompoundShapeSettings?(Jolt.JPH.ShapeSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(Jolt.JPH.ShapeSettings._Underlying *_this);
                var ptr = __JPH_CompoundShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                CompoundShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
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
        public class Const_CompoundShape : Jolt.Object<Const_CompoundShape>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CompoundShape_Destroy(_Underlying *_this);
                __JPH_CompoundShape_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_CompoundShape() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHShape(Const_CompoundShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHShape._Underlying *__JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHShape ret = new(__JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_CompoundShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_CompoundShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_CompoundShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_Shape(Const_CompoundShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Shape._Underlying *__JPH_CompoundShape_UpcastTo_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Const_Shape ret = new(__JPH_CompoundShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_CompoundShape?(Jolt.JPH.Const_Shape parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_CompoundShape_DynamicDowncastFrom_JPH_Shape(Jolt.JPH.Const_Shape._Underlying *_this);
                var ptr = __JPH_CompoundShape_DynamicDowncastFrom_JPH_Shape(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_CompoundShape ret = new(ptr, is_owning: false);
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

            internal unsafe Const_CompoundShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from method `JPH::CompoundShape::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CompoundShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CompoundShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_CompoundShape_size_t(ulong inCount);
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
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CompoundShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CompoundShape_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_CompoundShape_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::CompoundShape::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_CompoundShape_size_t(ulong inCount);
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
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CompoundShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CompoundShape_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_CompoundShape_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::CompoundShape::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CompoundShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CompoundShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_CompoundShape_size_t_void_ptr(ulong inCount, void *inPointer);
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
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CompoundShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_CompoundShape_size_t_void_ptr(ulong inCount, void *inPointer);
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
            public unsafe Jolt.JPH.AABox GetLocalBounds()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.AABox._Underlying *__JPH_CompoundShape_GetLocalBounds(_Underlying *_this);
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
            public unsafe Jolt.JPH.Const_PhysicsMaterial? GetMaterial(Jolt.JPH.Const_SubShapeID inSubShapeID)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_PhysicsMaterial._Underlying *__JPH_CompoundShape_GetMaterial(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID);
                var __c_ret = __JPH_CompoundShape_GetMaterial(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
            }

            // See Shape::GetLeafShape
            /// Generated from method `JPH::CompoundShape::GetLeafShape`.
            public unsafe Jolt.JPH.Const_Shape? GetLeafShape(Jolt.JPH.Const_SubShapeID inSubShapeID, Jolt.JPH.SubShapeID outRemainder)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Shape._Underlying *__JPH_CompoundShape_GetLeafShape(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID, Jolt.JPH.SubShapeID._Underlying *outRemainder);
                var __c_ret = __JPH_CompoundShape_GetLeafShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_Shape(__c_ret, is_owning: false) : null;
            }

            // See Shape::GetSubShapeUserData
            /// Generated from method `JPH::CompoundShape::GetSubShapeUserData`.
            public unsafe ulong GetSubShapeUserData(Jolt.JPH.Const_SubShapeID inSubShapeID)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_CompoundShape_GetSubShapeUserData(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID);
                return __JPH_CompoundShape_GetSubShapeUserData(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
            }

            /// Get which sub shape's bounding boxes overlap with an axis aligned box
            /// @param inBox The axis aligned box to test against (relative to the center of mass of this shape)
            /// @param outSubShapeIndices Buffer where to place the indices of the sub shapes that intersect
            /// @param inMaxSubShapeIndices How many indices will fit in the buffer (normally you'd provide a buffer of GetNumSubShapes() indices)
            /// @return How many indices were placed in outSubShapeIndices
            /// Generated from method `JPH::CompoundShape::GetIntersectingSubShapes`.
            public unsafe int GetIntersectingSubShapes(Jolt.JPH.Const_AABox inBox, Jolt.InOut<uint>? outSubShapeIndices, int inMaxSubShapeIndices)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetIntersectingSubShapes_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetIntersectingSubShapes_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_CompoundShape_GetIntersectingSubShapes_JPH_AABox(_Underlying *_this, Jolt.JPH.Const_AABox._Underlying *inBox, uint *outSubShapeIndices, int inMaxSubShapeIndices);
                uint __value_outSubShapeIndices = outSubShapeIndices is not null ? outSubShapeIndices.Value : default(uint);
                var __c_ret = __JPH_CompoundShape_GetIntersectingSubShapes_JPH_AABox(_UnderlyingPtr, inBox._UnderlyingPtr, outSubShapeIndices is not null ? &__value_outSubShapeIndices : null, inMaxSubShapeIndices);
                if (outSubShapeIndices is not null) outSubShapeIndices.Value = __value_outSubShapeIndices;
                return __c_ret;
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
            public unsafe Jolt.JPH.CompoundShape.Const_SubShape GetSubShape(uint inIdx)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetSubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetSubShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CompoundShape.Const_SubShape._Underlying *__JPH_CompoundShape_GetSubShape(_Underlying *_this, uint inIdx);
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
            public unsafe bool IsSubShapeIDValid(Jolt.JPH.Const_SubShapeID inSubShapeID)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_IsSubShapeIDValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_IsSubShapeIDValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_CompoundShape_IsSubShapeIDValid(_Underlying *_this, Jolt.JPH.SubShapeID._Underlying *inSubShapeID);
                return __JPH_CompoundShape_IsSubShapeIDValid(_UnderlyingPtr, inSubShapeID._UnderlyingPtr) != 0;
            }

            /// Convert SubShapeID to sub shape index
            /// @param inSubShapeID Sub shape id that indicates the leaf shape relative to this shape
            /// @param outRemainder This is the sub shape ID for the sub shape of the compound after popping off the index
            /// @return The index of the sub shape of this compound
            /// Generated from method `JPH::CompoundShape::GetSubShapeIndexFromID`.
            public unsafe uint GetSubShapeIndexFromID(Jolt.JPH.Const_SubShapeID inSubShapeID, Jolt.JPH.SubShapeID outRemainder)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapeIndexFromID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetSubShapeIndexFromID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_CompoundShape_GetSubShapeIndexFromID(_Underlying *_this, Jolt.JPH.SubShapeID._Underlying *inSubShapeID, Jolt.JPH.SubShapeID._Underlying *outRemainder);
                return __JPH_CompoundShape_GetSubShapeIndexFromID(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
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
            public unsafe Jolt.JPH.Shape.Stats GetStats()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Shape.Stats._Underlying *__JPH_CompoundShape_GetStats(_Underlying *_this);
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
            public class Const_SubShape : Jolt.Object<Const_SubShape>, System.IDisposable
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
                    extern static Jolt.JPH.CompoundShape.SubShape._Underlying *__JPH_CompoundShape_SubShape_DefaultConstruct();
                    _UnderlyingPtr = __JPH_CompoundShape_SubShape_DefaultConstruct();
                }

                /// Generated from constructor `JPH::CompoundShape::SubShape::SubShape`.
                public unsafe Const_SubShape(Jolt.JPH.CompoundShape._ByValue_SubShape _other) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CompoundShape.SubShape._Underlying *__JPH_CompoundShape_SubShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.CompoundShape.SubShape._Underlying *_other);
                    _UnderlyingPtr = __JPH_CompoundShape_SubShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                    if (_other.Value is not null) _KeepAlive(_other.Value);
                }

                /// Generated from constructor `JPH::CompoundShape::SubShape::SubShape`.
                public Const_SubShape(Const_SubShape _other) : this(new _ByValue_SubShape(_other)) {}

                /// Generated from constructor `JPH::CompoundShape::SubShape::SubShape`.
                public Const_SubShape(SubShape _other) : this((Const_SubShape)_other) {}
            }

            /// Generated from class `JPH::CompoundShape::SubShape`.
            /// This is the non-const half of the class.
            public class SubShape : Const_SubShape
            {
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
                    extern static Jolt.JPH.CompoundShape.SubShape._Underlying *__JPH_CompoundShape_SubShape_DefaultConstruct();
                    _UnderlyingPtr = __JPH_CompoundShape_SubShape_DefaultConstruct();
                }

                /// Generated from constructor `JPH::CompoundShape::SubShape::SubShape`.
                public unsafe SubShape(Jolt.JPH.CompoundShape._ByValue_SubShape _other) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CompoundShape.SubShape._Underlying *__JPH_CompoundShape_SubShape_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.CompoundShape.SubShape._Underlying *_other);
                    _UnderlyingPtr = __JPH_CompoundShape_SubShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                    if (_other.Value is not null) _KeepAlive(_other.Value);
                }

                /// Generated from constructor `JPH::CompoundShape::SubShape::SubShape`.
                public SubShape(Const_SubShape _other) : this(new _ByValue_SubShape(_other)) {}

                /// Generated from constructor `JPH::CompoundShape::SubShape::SubShape`.
                public SubShape(SubShape _other) : this((Const_SubShape)_other) {}

                /// Generated from method `JPH::CompoundShape::SubShape::operator=`.
                public unsafe Jolt.JPH.CompoundShape.SubShape Assign(Jolt.JPH.CompoundShape._ByValue_SubShape _other)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_SubShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_SubShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CompoundShape.SubShape._Underlying *__JPH_CompoundShape_SubShape_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JPH.CompoundShape.SubShape._Underlying *_other);
                    _DiscardKeepAlive();
                    if (_other.Value is not null) _KeepAlive(_other.Value);
                    return new(__JPH_CompoundShape_SubShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
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
                internal readonly Jolt._PassBy PassByMode;
                public _ByValue_SubShape() {PassByMode = Jolt._PassBy.default_construct;}
                public _ByValue_SubShape(Const_SubShape new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
                public static implicit operator _ByValue_SubShape(Const_SubShape arg) {return new(arg);}
                public _ByValue_SubShape(Jolt._Moved<SubShape> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
                public static implicit operator _ByValue_SubShape(Jolt._Moved<SubShape> arg) {return new(arg);}
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
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHShape(CompoundShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHShape._Underlying *__JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHShape ret = new(__JPH_CompoundShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.NonCopyable(CompoundShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_CompoundShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_CompoundShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Shape(CompoundShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Shape._Underlying *__JPH_CompoundShape_UpcastTo_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Shape ret = new(__JPH_CompoundShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator CompoundShape?(Jolt.JPH.Shape parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CompoundShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CompoundShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_CompoundShape_DynamicDowncastFrom_JPH_Shape(Jolt.JPH.Shape._Underlying *_this);
                var ptr = __JPH_CompoundShape_DynamicDowncastFrom_JPH_Shape(parent._UnderlyingPtr);
                if (ptr is null) return null;
                CompoundShape ret = new(ptr, is_owning: false);
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
}
