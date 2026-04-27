// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Class that constructs a PlaneShape
        /// Generated from class `JPH::PlaneShapeSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::ShapeSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::SerializableObject`
        ///     `JPH::RefTarget<JPH::ShapeSettings>`
        /// This is the const half of the class.
        public class Const_PlaneShapeSettings : Jolt.Object<Const_PlaneShapeSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PlaneShapeSettings_Destroy(_Underlying *_this);
                __JPH_PlaneShapeSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_PlaneShapeSettings() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_SerializableObject(Const_PlaneShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_SerializableObject._Underlying *__JPH_PlaneShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.Const_SerializableObject ret = new(__JPH_PlaneShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHShapeSettings(Const_PlaneShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHShapeSettings._Underlying *__JPH_PlaneShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHShapeSettings ret = new(__JPH_PlaneShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_ShapeSettings(Const_PlaneShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_ShapeSettings._Underlying *__JPH_PlaneShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.Const_ShapeSettings ret = new(__JPH_PlaneShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_PlaneShapeSettings?(Jolt.JPH.Const_SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.Const_SerializableObject._Underlying *_this);
                var ptr = __JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_PlaneShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_PlaneShapeSettings?(Jolt.JPH.Const_ShapeSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(Jolt.JPH.Const_ShapeSettings._Underlying *_this);
                var ptr = __JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_PlaneShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            ///< Default half-extent of the plane (total size along 1 axis will be 2 * half-extent)
            public static unsafe float CDefaultHalfExtent
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_Get_cDefaultHalfExtent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_Get_cDefaultHalfExtent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_PlaneShapeSettings_Get_cDefaultHalfExtent();
                    return *__JPH_PlaneShapeSettings_Get_cDefaultHalfExtent();
                }
            }

            ///< The bounding box of this plane will run from [-half_extent, half_extent]. Keep this as low as possible for better broad phase performance.
            public unsafe float mHalfExtent
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_Get_mHalfExtent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_Get_mHalfExtent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_PlaneShapeSettings_Get_mHalfExtent(_Underlying *_this);
                    return *__JPH_PlaneShapeSettings_Get_mHalfExtent(_UnderlyingPtr);
                }
            }

            /// User data (to be used freely by the application)
            public unsafe ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_PlaneShapeSettings_Get_mUserData(_Underlying *_this);
                    return *__JPH_PlaneShapeSettings_Get_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe Const_PlaneShapeSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_PlaneShapeSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.PlaneShapeSettings._Underlying *__JPH_PlaneShapeSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_PlaneShapeSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::PlaneShapeSettings::PlaneShapeSettings`.
            public unsafe Const_PlaneShapeSettings(Jolt.JPH._ByValue_PlaneShapeSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.PlaneShapeSettings._Underlying *__JPH_PlaneShapeSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.PlaneShapeSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_PlaneShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::PlaneShapeSettings::PlaneShapeSettings`.
            public Const_PlaneShapeSettings(Const_PlaneShapeSettings _other) : this(new _ByValue_PlaneShapeSettings(_other)) {}

            /// Generated from constructor `JPH::PlaneShapeSettings::PlaneShapeSettings`.
            public Const_PlaneShapeSettings(PlaneShapeSettings _other) : this((Const_PlaneShapeSettings)_other) {}

            /// Generated from method `JPH::PlaneShapeSettings::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PlaneShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PlaneShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_PlaneShapeSettings_size_t(ulong inCount);
                return __Jolt_new_JPH_PlaneShapeSettings_size_t(inCount);
            }

            /// Generated from method `JPH::PlaneShapeSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PlaneShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PlaneShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PlaneShapeSettings_void_ptr(void *inPointer);
                __Jolt_delete_JPH_PlaneShapeSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::PlaneShapeSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PlaneShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PlaneShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PlaneShapeSettings_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_PlaneShapeSettings_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::PlaneShapeSettings::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PlaneShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PlaneShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_PlaneShapeSettings_size_t(ulong inCount);
                return __Jolt_new_array_JPH_PlaneShapeSettings_size_t(inCount);
            }

            /// Generated from method `JPH::PlaneShapeSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::PlaneShapeSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::PlaneShapeSettings::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PlaneShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PlaneShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_PlaneShapeSettings_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_PlaneShapeSettings_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::PlaneShapeSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PlaneShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PlaneShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PlaneShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_PlaneShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::PlaneShapeSettings::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PlaneShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PlaneShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_PlaneShapeSettings_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_PlaneShapeSettings_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::PlaneShapeSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_PlaneShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::PlaneShapeSettings::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PlaneShapeSettings_SetEmbedded(_Underlying *_this);
                __JPH_PlaneShapeSettings_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::PlaneShapeSettings::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_PlaneShapeSettings_GetRefCount(_Underlying *_this);
                return __JPH_PlaneShapeSettings_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::PlaneShapeSettings::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PlaneShapeSettings_AddRef(_Underlying *_this);
                __JPH_PlaneShapeSettings_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::PlaneShapeSettings::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PlaneShapeSettings_Release(_Underlying *_this);
                __JPH_PlaneShapeSettings_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::PlaneShapeSettings::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_PlaneShapeSettings_sInternalGetRefCountOffset();
                return __JPH_PlaneShapeSettings_sInternalGetRefCountOffset();
            }
        }

        /// Class that constructs a PlaneShape
        /// Generated from class `JPH::PlaneShapeSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::ShapeSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::SerializableObject`
        ///     `JPH::RefTarget<JPH::ShapeSettings>`
        /// This is the non-const half of the class.
        public class PlaneShapeSettings : Const_PlaneShapeSettings
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.SerializableObject(PlaneShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SerializableObject._Underlying *__JPH_PlaneShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.SerializableObject ret = new(__JPH_PlaneShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHShapeSettings(PlaneShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_PlaneShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHShapeSettings ret = new(__JPH_PlaneShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.ShapeSettings(PlaneShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.ShapeSettings._Underlying *__JPH_PlaneShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.ShapeSettings ret = new(__JPH_PlaneShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator PlaneShapeSettings?(Jolt.JPH.SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.SerializableObject._Underlying *_this);
                var ptr = __JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                PlaneShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator PlaneShapeSettings?(Jolt.JPH.ShapeSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(Jolt.JPH.ShapeSettings._Underlying *_this);
                var ptr = __JPH_PlaneShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                PlaneShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            ///< The bounding box of this plane will run from [-half_extent, half_extent]. Keep this as low as possible for better broad phase performance.
            public new unsafe ref float mHalfExtent
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_GetMutable_mHalfExtent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_GetMutable_mHalfExtent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_PlaneShapeSettings_GetMutable_mHalfExtent(_Underlying *_this);
                    return ref *__JPH_PlaneShapeSettings_GetMutable_mHalfExtent(_UnderlyingPtr);
                }
            }

            /// User data (to be used freely by the application)
            public new unsafe ref ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_PlaneShapeSettings_GetMutable_mUserData(_Underlying *_this);
                    return ref *__JPH_PlaneShapeSettings_GetMutable_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe PlaneShapeSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe PlaneShapeSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.PlaneShapeSettings._Underlying *__JPH_PlaneShapeSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_PlaneShapeSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::PlaneShapeSettings::PlaneShapeSettings`.
            public unsafe PlaneShapeSettings(Jolt.JPH._ByValue_PlaneShapeSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.PlaneShapeSettings._Underlying *__JPH_PlaneShapeSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.PlaneShapeSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_PlaneShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::PlaneShapeSettings::PlaneShapeSettings`.
            public PlaneShapeSettings(Const_PlaneShapeSettings _other) : this(new _ByValue_PlaneShapeSettings(_other)) {}

            /// Generated from constructor `JPH::PlaneShapeSettings::PlaneShapeSettings`.
            public PlaneShapeSettings(PlaneShapeSettings _other) : this((Const_PlaneShapeSettings)_other) {}

            /// Generated from method `JPH::PlaneShapeSettings::operator=`.
            public unsafe Jolt.JPH.PlaneShapeSettings Assign(Jolt.JPH._ByValue_PlaneShapeSettings _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.PlaneShapeSettings._Underlying *__JPH_PlaneShapeSettings_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JPH.PlaneShapeSettings._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_PlaneShapeSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }

            /// When creating a shape, the result is cached so that calling Create() again will return the same shape.
            /// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
            /// Generated from method `JPH::PlaneShapeSettings::ClearCachedResult`.
            public unsafe void ClearCachedResult()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PlaneShapeSettings_ClearCachedResult(_Underlying *_this);
                __JPH_PlaneShapeSettings_ClearCachedResult(_UnderlyingPtr);
            }
        }

        /// This is used as a function parameter when the underlying function receives `PlaneShapeSettings` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `PlaneShapeSettings`/`Const_PlaneShapeSettings` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_PlaneShapeSettings
        {
            #pragma warning disable CS0649
            internal readonly Const_PlaneShapeSettings? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_PlaneShapeSettings() {PassByMode = Jolt._PassBy.default_construct;}
            public _ByValue_PlaneShapeSettings(Const_PlaneShapeSettings new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
            public static implicit operator _ByValue_PlaneShapeSettings(Const_PlaneShapeSettings arg) {return new(arg);}
            public _ByValue_PlaneShapeSettings(Jolt._Moved<PlaneShapeSettings> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
            public static implicit operator _ByValue_PlaneShapeSettings(Jolt._Moved<PlaneShapeSettings> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `PlaneShapeSettings` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_PlaneShapeSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `PlaneShapeSettings`/`Const_PlaneShapeSettings` directly.
        public class _InOptMut_PlaneShapeSettings
        {
            public PlaneShapeSettings? Opt;

            public _InOptMut_PlaneShapeSettings() {}
            public _InOptMut_PlaneShapeSettings(PlaneShapeSettings value) {Opt = value;}
            public static implicit operator _InOptMut_PlaneShapeSettings(PlaneShapeSettings value) {return new(value);}
        }

        /// This is used for optional parameters of class `PlaneShapeSettings` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_PlaneShapeSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `PlaneShapeSettings`/`Const_PlaneShapeSettings` to pass it to the function.
        public class _InOptConst_PlaneShapeSettings
        {
            public Const_PlaneShapeSettings? Opt;

            public _InOptConst_PlaneShapeSettings() {}
            public _InOptConst_PlaneShapeSettings(Const_PlaneShapeSettings value) {Opt = value;}
            public static implicit operator _InOptConst_PlaneShapeSettings(Const_PlaneShapeSettings value) {return new(value);}
        }

        /// A plane shape. The negative half space is considered solid. Planes cannot be dynamic objects, only static or kinematic.
        /// The plane is considered an infinite shape, but testing collision outside of its bounding box (defined by the half-extent parameter) will not return a collision result.
        /// At the edge of the bounding box collision with the plane will be inconsistent. If you need something of a well defined size, a box shape may be better.
        /// Generated from class `JPH::PlaneShape`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::Shape`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::Shape>`
        ///     `JPH::NonCopyable`
        /// This is the const half of the class.
        public class Const_PlaneShape : Jolt.Object<Const_PlaneShape>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PlaneShape_Destroy(_Underlying *_this);
                __JPH_PlaneShape_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_PlaneShape() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHShape(Const_PlaneShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHShape._Underlying *__JPH_PlaneShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHShape ret = new(__JPH_PlaneShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_PlaneShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_PlaneShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_PlaneShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_Shape(Const_PlaneShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Shape._Underlying *__JPH_PlaneShape_UpcastTo_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Const_Shape ret = new(__JPH_PlaneShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_PlaneShape?(Jolt.JPH.Const_Shape parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PlaneShape_DynamicDowncastFrom_JPH_Shape(Jolt.JPH.Const_Shape._Underlying *_this);
                var ptr = __JPH_PlaneShape_DynamicDowncastFrom_JPH_Shape(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_PlaneShape ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
            public static unsafe int CGetTrianglesMinTrianglesRequested
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_PlaneShape_Get_cGetTrianglesMinTrianglesRequested();
                    return *__JPH_PlaneShape_Get_cGetTrianglesMinTrianglesRequested();
                }
            }

            internal unsafe Const_PlaneShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_PlaneShape() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.PlaneShape._Underlying *__JPH_PlaneShape_DefaultConstruct();
                _UnderlyingPtr = __JPH_PlaneShape_DefaultConstruct();
            }

            /// Generated from method `JPH::PlaneShape::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PlaneShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PlaneShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_PlaneShape_size_t(ulong inCount);
                return __Jolt_new_JPH_PlaneShape_size_t(inCount);
            }

            /// Generated from method `JPH::PlaneShape::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PlaneShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PlaneShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PlaneShape_void_ptr(void *inPointer);
                __Jolt_delete_JPH_PlaneShape_void_ptr(inPointer);
            }

            /// Generated from method `JPH::PlaneShape::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PlaneShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PlaneShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PlaneShape_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_PlaneShape_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::PlaneShape::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PlaneShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PlaneShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_PlaneShape_size_t(ulong inCount);
                return __Jolt_new_array_JPH_PlaneShape_size_t(inCount);
            }

            /// Generated from method `JPH::PlaneShape::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PlaneShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PlaneShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PlaneShape_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_PlaneShape_void_ptr(inPointer);
            }

            /// Generated from method `JPH::PlaneShape::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PlaneShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PlaneShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PlaneShape_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_PlaneShape_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::PlaneShape::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PlaneShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PlaneShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_PlaneShape_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_PlaneShape_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::PlaneShape::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PlaneShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PlaneShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PlaneShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_PlaneShape_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::PlaneShape::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PlaneShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PlaneShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_PlaneShape_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_PlaneShape_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::PlaneShape::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PlaneShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PlaneShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PlaneShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_PlaneShape_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Get the half-extent of the bounding box of the plane
            /// Generated from method `JPH::PlaneShape::GetHalfExtent`.
            public unsafe float GetHalfExtent()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_GetHalfExtent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_GetHalfExtent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_PlaneShape_GetHalfExtent(_Underlying *_this);
                return __JPH_PlaneShape_GetHalfExtent(_UnderlyingPtr);
            }

            // See Shape::MustBeStatic
            /// Generated from method `JPH::PlaneShape::MustBeStatic`.
            public unsafe bool MustBeStatic()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_PlaneShape_MustBeStatic(_Underlying *_this);
                return __JPH_PlaneShape_MustBeStatic(_UnderlyingPtr) != 0;
            }

            // See Shape::GetLocalBounds
            /// Generated from method `JPH::PlaneShape::GetLocalBounds`.
            public unsafe Jolt.JPH.AABox GetLocalBounds()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.AABox._Underlying *__JPH_PlaneShape_GetLocalBounds(_Underlying *_this);
                return new(__JPH_PlaneShape_GetLocalBounds(_UnderlyingPtr), is_owning: true);
            }

            // See Shape::GetSubShapeIDBitsRecursive
            /// Generated from method `JPH::PlaneShape::GetSubShapeIDBitsRecursive`.
            public unsafe uint GetSubShapeIDBitsRecursive()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_PlaneShape_GetSubShapeIDBitsRecursive(_Underlying *_this);
                return __JPH_PlaneShape_GetSubShapeIDBitsRecursive(_UnderlyingPtr);
            }

            // See Shape::GetInnerRadius
            /// Generated from method `JPH::PlaneShape::GetInnerRadius`.
            public unsafe float GetInnerRadius()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_PlaneShape_GetInnerRadius(_Underlying *_this);
                return __JPH_PlaneShape_GetInnerRadius(_UnderlyingPtr);
            }

            // See Shape::GetMaterial
            /// Generated from method `JPH::PlaneShape::GetMaterial`.
            public unsafe Jolt.JPH.Const_PhysicsMaterial? GetMaterial(Jolt.JPH.Const_SubShapeID inSubShapeID)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_GetMaterial_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_GetMaterial_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_PhysicsMaterial._Underlying *__JPH_PlaneShape_GetMaterial_1(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID);
                var __c_ret = __JPH_PlaneShape_GetMaterial_1(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
            }

            // See Shape::GetStats
            /// Generated from method `JPH::PlaneShape::GetStats`.
            public unsafe Jolt.JPH.Shape.Stats GetStats()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Shape.Stats._Underlying *__JPH_PlaneShape_GetStats(_Underlying *_this);
                return new(__JPH_PlaneShape_GetStats(_UnderlyingPtr), is_owning: true);
            }

            // See Shape::GetVolume
            /// Generated from method `JPH::PlaneShape::GetVolume`.
            public unsafe float GetVolume()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_PlaneShape_GetVolume(_Underlying *_this);
                return __JPH_PlaneShape_GetVolume(_UnderlyingPtr);
            }

            /// Generated from method `JPH::PlaneShape::GetMaterial`.
            public unsafe Jolt.JPH.Const_PhysicsMaterial? GetMaterial()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_GetMaterial_0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_GetMaterial_0", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_PhysicsMaterial._Underlying *__JPH_PlaneShape_GetMaterial_0(_Underlying *_this);
                var __c_ret = __JPH_PlaneShape_GetMaterial_0(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
            }

            // Register shape functions with the registry
            /// Generated from method `JPH::PlaneShape::sRegister`.
            public static void SRegister()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PlaneShape_sRegister();
                __JPH_PlaneShape_sRegister();
            }

            /// User data (to be used freely by the application)
            /// Generated from method `JPH::PlaneShape::GetUserData`.
            public unsafe ulong GetUserData()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_PlaneShape_GetUserData(_Underlying *_this);
                return __JPH_PlaneShape_GetUserData(_UnderlyingPtr);
            }

            /// Get the leaf shape for a particular sub shape ID.
            /// @param inSubShapeID The full sub shape ID that indicates the path to the leaf shape
            /// @param outRemainder What remains of the sub shape ID after removing the path to the leaf shape (could e.g. refer to a triangle within a MeshShape)
            /// @return The shape or null if the sub shape ID is invalid
            /// Generated from method `JPH::PlaneShape::GetLeafShape`.
            public unsafe Jolt.JPH.Const_Shape? GetLeafShape(Jolt.JPH.Const_SubShapeID inSubShapeID, Jolt.JPH.SubShapeID outRemainder)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Shape._Underlying *__JPH_PlaneShape_GetLeafShape(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID, Jolt.JPH.SubShapeID._Underlying *outRemainder);
                var __c_ret = __JPH_PlaneShape_GetLeafShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_Shape(__c_ret, is_owning: false) : null;
            }

            /// Get the user data of a particular sub shape ID. Corresponds with the value stored in Shape::GetUserData of the leaf shape pointed to by inSubShapeID.
            /// Generated from method `JPH::PlaneShape::GetSubShapeUserData`.
            public unsafe ulong GetSubShapeUserData(Jolt.JPH.Const_SubShapeID inSubShapeID)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_PlaneShape_GetSubShapeUserData(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID);
                return __JPH_PlaneShape_GetSubShapeUserData(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::PlaneShape::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PlaneShape_SetEmbedded(_Underlying *_this);
                __JPH_PlaneShape_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::PlaneShape::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_PlaneShape_GetRefCount(_Underlying *_this);
                return __JPH_PlaneShape_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::PlaneShape::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PlaneShape_AddRef(_Underlying *_this);
                __JPH_PlaneShape_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::PlaneShape::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PlaneShape_Release(_Underlying *_this);
                __JPH_PlaneShape_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::PlaneShape::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_PlaneShape_sInternalGetRefCountOffset();
                return __JPH_PlaneShape_sInternalGetRefCountOffset();
            }
        }

        /// A plane shape. The negative half space is considered solid. Planes cannot be dynamic objects, only static or kinematic.
        /// The plane is considered an infinite shape, but testing collision outside of its bounding box (defined by the half-extent parameter) will not return a collision result.
        /// At the edge of the bounding box collision with the plane will be inconsistent. If you need something of a well defined size, a box shape may be better.
        /// Generated from class `JPH::PlaneShape`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::Shape`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::Shape>`
        ///     `JPH::NonCopyable`
        /// This is the non-const half of the class.
        public class PlaneShape : Const_PlaneShape
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHShape(PlaneShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHShape._Underlying *__JPH_PlaneShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHShape ret = new(__JPH_PlaneShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.NonCopyable(PlaneShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_PlaneShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_PlaneShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Shape(PlaneShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Shape._Underlying *__JPH_PlaneShape_UpcastTo_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Shape ret = new(__JPH_PlaneShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator PlaneShape?(Jolt.JPH.Shape parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PlaneShape_DynamicDowncastFrom_JPH_Shape(Jolt.JPH.Shape._Underlying *_this);
                var ptr = __JPH_PlaneShape_DynamicDowncastFrom_JPH_Shape(parent._UnderlyingPtr);
                if (ptr is null) return null;
                PlaneShape ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe PlaneShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe PlaneShape() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.PlaneShape._Underlying *__JPH_PlaneShape_DefaultConstruct();
                _UnderlyingPtr = __JPH_PlaneShape_DefaultConstruct();
            }

            /// Material of the shape
            /// Generated from method `JPH::PlaneShape::SetMaterial`.
            public unsafe void SetMaterial(Jolt.JPH.Const_PhysicsMaterial? inMaterial)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_SetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_SetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PlaneShape_SetMaterial(_Underlying *_this, Jolt.JPH.Const_PhysicsMaterial._Underlying *inMaterial);
                __JPH_PlaneShape_SetMaterial(_UnderlyingPtr, inMaterial is not null ? inMaterial._UnderlyingPtr : null);
            }

            /// Generated from method `JPH::PlaneShape::SetUserData`.
            public unsafe void SetUserData(ulong inUserData)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PlaneShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PlaneShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PlaneShape_SetUserData(_Underlying *_this, ulong inUserData);
                __JPH_PlaneShape_SetUserData(_UnderlyingPtr, inUserData);
            }
        }

        /// This is used as a function parameter when the underlying function receives `PlaneShape` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_PlaneShape
        {
            #pragma warning disable CS0649
            internal readonly Const_PlaneShape? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_PlaneShape() {PassByMode = Jolt._PassBy.default_construct;}
        }

        /// This is used for optional parameters of class `PlaneShape` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_PlaneShape`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `PlaneShape`/`Const_PlaneShape` directly.
        public class _InOptMut_PlaneShape
        {
            public PlaneShape? Opt;

            public _InOptMut_PlaneShape() {}
            public _InOptMut_PlaneShape(PlaneShape value) {Opt = value;}
            public static implicit operator _InOptMut_PlaneShape(PlaneShape value) {return new(value);}
        }

        /// This is used for optional parameters of class `PlaneShape` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_PlaneShape`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `PlaneShape`/`Const_PlaneShape` to pass it to the function.
        public class _InOptConst_PlaneShape
        {
            public Const_PlaneShape? Opt;

            public _InOptConst_PlaneShape() {}
            public _InOptConst_PlaneShape(Const_PlaneShape value) {Opt = value;}
            public static implicit operator _InOptConst_PlaneShape(Const_PlaneShape value) {return new(value);}
        }
    }
}
