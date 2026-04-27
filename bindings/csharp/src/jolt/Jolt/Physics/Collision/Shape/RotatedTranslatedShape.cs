// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Class that constructs a RotatedTranslatedShape
        /// Generated from class `JPH::RotatedTranslatedShapeSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::DecoratedShapeSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::SerializableObject`
        ///     `JPH::RefTarget<JPH::ShapeSettings>`
        ///     `JPH::ShapeSettings`
        /// This is the const half of the class.
        public class Const_RotatedTranslatedShapeSettings : Jolt.Object<Const_RotatedTranslatedShapeSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RotatedTranslatedShapeSettings_Destroy(_Underlying *_this);
                __JPH_RotatedTranslatedShapeSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_RotatedTranslatedShapeSettings() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_SerializableObject(Const_RotatedTranslatedShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_SerializableObject._Underlying *__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.Const_SerializableObject ret = new(__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHShapeSettings(Const_RotatedTranslatedShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHShapeSettings._Underlying *__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHShapeSettings ret = new(__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_ShapeSettings(Const_RotatedTranslatedShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_ShapeSettings._Underlying *__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.Const_ShapeSettings ret = new(__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_DecoratedShapeSettings(Const_RotatedTranslatedShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_DecoratedShapeSettings._Underlying *__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(_Underlying *_this);
                Jolt.JPH.Const_DecoratedShapeSettings ret = new(__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_RotatedTranslatedShapeSettings?(Jolt.JPH.Const_SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.Const_SerializableObject._Underlying *_this);
                var ptr = __JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_RotatedTranslatedShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_RotatedTranslatedShapeSettings?(Jolt.JPH.Const_ShapeSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(Jolt.JPH.Const_ShapeSettings._Underlying *_this);
                var ptr = __JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_RotatedTranslatedShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_RotatedTranslatedShapeSettings?(Jolt.JPH.Const_DecoratedShapeSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings(Jolt.JPH.Const_DecoratedShapeSettings._Underlying *_this);
                var ptr = __JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_RotatedTranslatedShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// User data (to be used freely by the application)
            public unsafe ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_RotatedTranslatedShapeSettings_Get_mUserData(_Underlying *_this);
                    return *__JPH_RotatedTranslatedShapeSettings_Get_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe Const_RotatedTranslatedShapeSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_RotatedTranslatedShapeSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RotatedTranslatedShapeSettings._Underlying *__JPH_RotatedTranslatedShapeSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_RotatedTranslatedShapeSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::RotatedTranslatedShapeSettings::RotatedTranslatedShapeSettings`.
            public unsafe Const_RotatedTranslatedShapeSettings(Jolt.JPH._ByValue_RotatedTranslatedShapeSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RotatedTranslatedShapeSettings._Underlying *__JPH_RotatedTranslatedShapeSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.RotatedTranslatedShapeSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_RotatedTranslatedShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::RotatedTranslatedShapeSettings::RotatedTranslatedShapeSettings`.
            public Const_RotatedTranslatedShapeSettings(Const_RotatedTranslatedShapeSettings _other) : this(new _ByValue_RotatedTranslatedShapeSettings(_other)) {}

            /// Generated from constructor `JPH::RotatedTranslatedShapeSettings::RotatedTranslatedShapeSettings`.
            public Const_RotatedTranslatedShapeSettings(RotatedTranslatedShapeSettings _other) : this((Const_RotatedTranslatedShapeSettings)_other) {}

            /// Generated from method `JPH::RotatedTranslatedShapeSettings::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RotatedTranslatedShapeSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RotatedTranslatedShapeSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_RotatedTranslatedShapeSettings_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_RotatedTranslatedShapeSettings_unsigned_long(inCount);
            }

            /// Generated from method `JPH::RotatedTranslatedShapeSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr(void *inPointer);
                __Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::RotatedTranslatedShapeSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::RotatedTranslatedShapeSettings::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RotatedTranslatedShapeSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RotatedTranslatedShapeSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_RotatedTranslatedShapeSettings_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_RotatedTranslatedShapeSettings_unsigned_long(inCount);
            }

            /// Generated from method `JPH::RotatedTranslatedShapeSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::RotatedTranslatedShapeSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::RotatedTranslatedShapeSettings::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RotatedTranslatedShapeSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RotatedTranslatedShapeSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_RotatedTranslatedShapeSettings_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_RotatedTranslatedShapeSettings_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::RotatedTranslatedShapeSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_RotatedTranslatedShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::RotatedTranslatedShapeSettings::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RotatedTranslatedShapeSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RotatedTranslatedShapeSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_RotatedTranslatedShapeSettings_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_RotatedTranslatedShapeSettings_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::RotatedTranslatedShapeSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_RotatedTranslatedShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::RotatedTranslatedShapeSettings::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RotatedTranslatedShapeSettings_SetEmbedded(_Underlying *_this);
                __JPH_RotatedTranslatedShapeSettings_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::RotatedTranslatedShapeSettings::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_RotatedTranslatedShapeSettings_GetRefCount(_Underlying *_this);
                return __JPH_RotatedTranslatedShapeSettings_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::RotatedTranslatedShapeSettings::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RotatedTranslatedShapeSettings_AddRef(_Underlying *_this);
                __JPH_RotatedTranslatedShapeSettings_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::RotatedTranslatedShapeSettings::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RotatedTranslatedShapeSettings_Release(_Underlying *_this);
                __JPH_RotatedTranslatedShapeSettings_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::RotatedTranslatedShapeSettings::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_RotatedTranslatedShapeSettings_sInternalGetRefCountOffset();
                return __JPH_RotatedTranslatedShapeSettings_sInternalGetRefCountOffset();
            }
        }

        /// Class that constructs a RotatedTranslatedShape
        /// Generated from class `JPH::RotatedTranslatedShapeSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::DecoratedShapeSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::SerializableObject`
        ///     `JPH::RefTarget<JPH::ShapeSettings>`
        ///     `JPH::ShapeSettings`
        /// This is the non-const half of the class.
        public class RotatedTranslatedShapeSettings : Const_RotatedTranslatedShapeSettings
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.SerializableObject(RotatedTranslatedShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SerializableObject._Underlying *__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.SerializableObject ret = new(__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHShapeSettings(RotatedTranslatedShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHShapeSettings._Underlying *__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHShapeSettings ret = new(__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_RefTarget_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.ShapeSettings(RotatedTranslatedShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.ShapeSettings._Underlying *__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_ShapeSettings(_Underlying *_this);
                Jolt.JPH.ShapeSettings ret = new(__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_ShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.DecoratedShapeSettings(RotatedTranslatedShapeSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DecoratedShapeSettings._Underlying *__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(_Underlying *_this);
                Jolt.JPH.DecoratedShapeSettings ret = new(__JPH_RotatedTranslatedShapeSettings_UpcastTo_JPH_DecoratedShapeSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator RotatedTranslatedShapeSettings?(Jolt.JPH.SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.SerializableObject._Underlying *_this);
                var ptr = __JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                RotatedTranslatedShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator RotatedTranslatedShapeSettings?(Jolt.JPH.ShapeSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(Jolt.JPH.ShapeSettings._Underlying *_this);
                var ptr = __JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_ShapeSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                RotatedTranslatedShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator RotatedTranslatedShapeSettings?(Jolt.JPH.DecoratedShapeSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings(Jolt.JPH.DecoratedShapeSettings._Underlying *_this);
                var ptr = __JPH_RotatedTranslatedShapeSettings_DynamicDowncastFrom_JPH_DecoratedShapeSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                RotatedTranslatedShapeSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// User data (to be used freely by the application)
            public new unsafe ref ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_RotatedTranslatedShapeSettings_GetMutable_mUserData(_Underlying *_this);
                    return ref *__JPH_RotatedTranslatedShapeSettings_GetMutable_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe RotatedTranslatedShapeSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe RotatedTranslatedShapeSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RotatedTranslatedShapeSettings._Underlying *__JPH_RotatedTranslatedShapeSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_RotatedTranslatedShapeSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::RotatedTranslatedShapeSettings::RotatedTranslatedShapeSettings`.
            public unsafe RotatedTranslatedShapeSettings(Jolt.JPH._ByValue_RotatedTranslatedShapeSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RotatedTranslatedShapeSettings._Underlying *__JPH_RotatedTranslatedShapeSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.RotatedTranslatedShapeSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_RotatedTranslatedShapeSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::RotatedTranslatedShapeSettings::RotatedTranslatedShapeSettings`.
            public RotatedTranslatedShapeSettings(Const_RotatedTranslatedShapeSettings _other) : this(new _ByValue_RotatedTranslatedShapeSettings(_other)) {}

            /// Generated from constructor `JPH::RotatedTranslatedShapeSettings::RotatedTranslatedShapeSettings`.
            public RotatedTranslatedShapeSettings(RotatedTranslatedShapeSettings _other) : this((Const_RotatedTranslatedShapeSettings)_other) {}

            /// Generated from method `JPH::RotatedTranslatedShapeSettings::operator=`.
            public unsafe Jolt.JPH.RotatedTranslatedShapeSettings Assign(Jolt.JPH._ByValue_RotatedTranslatedShapeSettings _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RotatedTranslatedShapeSettings._Underlying *__JPH_RotatedTranslatedShapeSettings_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JPH.RotatedTranslatedShapeSettings._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_RotatedTranslatedShapeSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }

            /// When creating a shape, the result is cached so that calling Create() again will return the same shape.
            /// If you make changes to the ShapeSettings you need to call this function to clear the cached result to allow Create() to build a new shape.
            /// Generated from method `JPH::RotatedTranslatedShapeSettings::ClearCachedResult`.
            public unsafe void ClearCachedResult()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShapeSettings_ClearCachedResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RotatedTranslatedShapeSettings_ClearCachedResult(_Underlying *_this);
                __JPH_RotatedTranslatedShapeSettings_ClearCachedResult(_UnderlyingPtr);
            }
        }

        /// This is used as a function parameter when the underlying function receives `RotatedTranslatedShapeSettings` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `RotatedTranslatedShapeSettings`/`Const_RotatedTranslatedShapeSettings` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_RotatedTranslatedShapeSettings
        {
            #pragma warning disable CS0649
            internal readonly Const_RotatedTranslatedShapeSettings? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_RotatedTranslatedShapeSettings() {PassByMode = Jolt._PassBy.default_construct;}
            public _ByValue_RotatedTranslatedShapeSettings(Const_RotatedTranslatedShapeSettings new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
            public static implicit operator _ByValue_RotatedTranslatedShapeSettings(Const_RotatedTranslatedShapeSettings arg) {return new(arg);}
            public _ByValue_RotatedTranslatedShapeSettings(Jolt._Moved<RotatedTranslatedShapeSettings> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
            public static implicit operator _ByValue_RotatedTranslatedShapeSettings(Jolt._Moved<RotatedTranslatedShapeSettings> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `RotatedTranslatedShapeSettings` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_RotatedTranslatedShapeSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `RotatedTranslatedShapeSettings`/`Const_RotatedTranslatedShapeSettings` directly.
        public class _InOptMut_RotatedTranslatedShapeSettings
        {
            public RotatedTranslatedShapeSettings? Opt;

            public _InOptMut_RotatedTranslatedShapeSettings() {}
            public _InOptMut_RotatedTranslatedShapeSettings(RotatedTranslatedShapeSettings value) {Opt = value;}
            public static implicit operator _InOptMut_RotatedTranslatedShapeSettings(RotatedTranslatedShapeSettings value) {return new(value);}
        }

        /// This is used for optional parameters of class `RotatedTranslatedShapeSettings` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_RotatedTranslatedShapeSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `RotatedTranslatedShapeSettings`/`Const_RotatedTranslatedShapeSettings` to pass it to the function.
        public class _InOptConst_RotatedTranslatedShapeSettings
        {
            public Const_RotatedTranslatedShapeSettings? Opt;

            public _InOptConst_RotatedTranslatedShapeSettings() {}
            public _InOptConst_RotatedTranslatedShapeSettings(Const_RotatedTranslatedShapeSettings value) {Opt = value;}
            public static implicit operator _InOptConst_RotatedTranslatedShapeSettings(Const_RotatedTranslatedShapeSettings value) {return new(value);}
        }

        /// A rotated translated shape will rotate and translate a child shape.
        /// Shifts the child object so that it is centered around the center of mass.
        /// Generated from class `JPH::RotatedTranslatedShape`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::DecoratedShape`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::Shape>`
        ///     `JPH::NonCopyable`
        ///     `JPH::Shape`
        /// This is the const half of the class.
        public class Const_RotatedTranslatedShape : Jolt.Object<Const_RotatedTranslatedShape>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RotatedTranslatedShape_Destroy(_Underlying *_this);
                __JPH_RotatedTranslatedShape_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_RotatedTranslatedShape() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHShape(Const_RotatedTranslatedShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHShape._Underlying *__JPH_RotatedTranslatedShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHShape ret = new(__JPH_RotatedTranslatedShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_RotatedTranslatedShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_RotatedTranslatedShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_RotatedTranslatedShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_Shape(Const_RotatedTranslatedShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Shape._Underlying *__JPH_RotatedTranslatedShape_UpcastTo_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Const_Shape ret = new(__JPH_RotatedTranslatedShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_DecoratedShape(Const_RotatedTranslatedShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_DecoratedShape._Underlying *__JPH_RotatedTranslatedShape_UpcastTo_JPH_DecoratedShape(_Underlying *_this);
                Jolt.JPH.Const_DecoratedShape ret = new(__JPH_RotatedTranslatedShape_UpcastTo_JPH_DecoratedShape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_RotatedTranslatedShape?(Jolt.JPH.Const_Shape parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_Shape(Jolt.JPH.Const_Shape._Underlying *_this);
                var ptr = __JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_Shape(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_RotatedTranslatedShape ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_RotatedTranslatedShape?(Jolt.JPH.Const_DecoratedShape parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_DecoratedShape(Jolt.JPH.Const_DecoratedShape._Underlying *_this);
                var ptr = __JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_DecoratedShape(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_RotatedTranslatedShape ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// This is the minimum amount of triangles that should be requested through GetTrianglesNext.
            public static unsafe int CGetTrianglesMinTrianglesRequested
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_Get_cGetTrianglesMinTrianglesRequested", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__JPH_RotatedTranslatedShape_Get_cGetTrianglesMinTrianglesRequested();
                    return *__JPH_RotatedTranslatedShape_Get_cGetTrianglesMinTrianglesRequested();
                }
            }

            internal unsafe Const_RotatedTranslatedShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_RotatedTranslatedShape() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RotatedTranslatedShape._Underlying *__JPH_RotatedTranslatedShape_DefaultConstruct();
                _UnderlyingPtr = __JPH_RotatedTranslatedShape_DefaultConstruct();
            }

            /// Generated from method `JPH::RotatedTranslatedShape::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RotatedTranslatedShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RotatedTranslatedShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_RotatedTranslatedShape_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_RotatedTranslatedShape_unsigned_long(inCount);
            }

            /// Generated from method `JPH::RotatedTranslatedShape::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RotatedTranslatedShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RotatedTranslatedShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_RotatedTranslatedShape_void_ptr(void *inPointer);
                __Jolt_delete_JPH_RotatedTranslatedShape_void_ptr(inPointer);
            }

            /// Generated from method `JPH::RotatedTranslatedShape::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RotatedTranslatedShape_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RotatedTranslatedShape_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_RotatedTranslatedShape_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_RotatedTranslatedShape_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::RotatedTranslatedShape::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RotatedTranslatedShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RotatedTranslatedShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_RotatedTranslatedShape_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_RotatedTranslatedShape_unsigned_long(inCount);
            }

            /// Generated from method `JPH::RotatedTranslatedShape::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr(inPointer);
            }

            /// Generated from method `JPH::RotatedTranslatedShape::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::RotatedTranslatedShape::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RotatedTranslatedShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RotatedTranslatedShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_RotatedTranslatedShape_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_RotatedTranslatedShape_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::RotatedTranslatedShape::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RotatedTranslatedShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RotatedTranslatedShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_RotatedTranslatedShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_RotatedTranslatedShape_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::RotatedTranslatedShape::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RotatedTranslatedShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RotatedTranslatedShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_RotatedTranslatedShape_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_RotatedTranslatedShape_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::RotatedTranslatedShape::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_RotatedTranslatedShape_void_ptr_void_ptr(inPointer, inPlace);
            }

            // See Shape::GetLocalBounds
            /// Generated from method `JPH::RotatedTranslatedShape::GetLocalBounds`.
            public unsafe Jolt.JPH.AABox GetLocalBounds()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetLocalBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.AABox._Underlying *__JPH_RotatedTranslatedShape_GetLocalBounds(_Underlying *_this);
                return new(__JPH_RotatedTranslatedShape_GetLocalBounds(_UnderlyingPtr), is_owning: true);
            }

            // See Shape::GetInnerRadius
            /// Generated from method `JPH::RotatedTranslatedShape::GetInnerRadius`.
            public unsafe float GetInnerRadius()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetInnerRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_RotatedTranslatedShape_GetInnerRadius(_Underlying *_this);
                return __JPH_RotatedTranslatedShape_GetInnerRadius(_UnderlyingPtr);
            }

            // See Shape::GetStats
            /// Generated from method `JPH::RotatedTranslatedShape::GetStats`.
            public unsafe Jolt.JPH.Shape.Stats GetStats()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Shape.Stats._Underlying *__JPH_RotatedTranslatedShape_GetStats(_Underlying *_this);
                return new(__JPH_RotatedTranslatedShape_GetStats(_UnderlyingPtr), is_owning: true);
            }

            // See Shape::GetVolume
            /// Generated from method `JPH::RotatedTranslatedShape::GetVolume`.
            public unsafe float GetVolume()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_RotatedTranslatedShape_GetVolume(_Underlying *_this);
                return __JPH_RotatedTranslatedShape_GetVolume(_UnderlyingPtr);
            }

            // Register shape functions with the registry
            /// Generated from method `JPH::RotatedTranslatedShape::sRegister`.
            public static void SRegister()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_sRegister", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RotatedTranslatedShape_sRegister();
                __JPH_RotatedTranslatedShape_sRegister();
            }

            /// Access to the decorated inner shape
            /// Generated from method `JPH::RotatedTranslatedShape::GetInnerShape`.
            public unsafe Jolt.JPH.Const_Shape? GetInnerShape()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetInnerShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetInnerShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Shape._Underlying *__JPH_RotatedTranslatedShape_GetInnerShape(_Underlying *_this);
                var __c_ret = __JPH_RotatedTranslatedShape_GetInnerShape(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_Shape(__c_ret, is_owning: false) : null;
            }

            // See Shape::MustBeStatic
            /// Generated from method `JPH::RotatedTranslatedShape::MustBeStatic`.
            public unsafe bool MustBeStatic()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_MustBeStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_RotatedTranslatedShape_MustBeStatic(_Underlying *_this);
                return __JPH_RotatedTranslatedShape_MustBeStatic(_UnderlyingPtr) != 0;
            }

            // See Shape::GetSubShapeIDBitsRecursive
            /// Generated from method `JPH::RotatedTranslatedShape::GetSubShapeIDBitsRecursive`.
            public unsafe uint GetSubShapeIDBitsRecursive()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetSubShapeIDBitsRecursive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_RotatedTranslatedShape_GetSubShapeIDBitsRecursive(_Underlying *_this);
                return __JPH_RotatedTranslatedShape_GetSubShapeIDBitsRecursive(_UnderlyingPtr);
            }

            // See Shape::GetLeafShape
            /// Generated from method `JPH::RotatedTranslatedShape::GetLeafShape`.
            public unsafe Jolt.JPH.Const_Shape? GetLeafShape(Jolt.JPH.Const_SubShapeID inSubShapeID, Jolt.JPH.SubShapeID outRemainder)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetLeafShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Shape._Underlying *__JPH_RotatedTranslatedShape_GetLeafShape(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID, Jolt.JPH.SubShapeID._Underlying *outRemainder);
                var __c_ret = __JPH_RotatedTranslatedShape_GetLeafShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_Shape(__c_ret, is_owning: false) : null;
            }

            // See Shape::GetMaterial
            /// Generated from method `JPH::RotatedTranslatedShape::GetMaterial`.
            public unsafe Jolt.JPH.Const_PhysicsMaterial? GetMaterial(Jolt.JPH.Const_SubShapeID inSubShapeID)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_PhysicsMaterial._Underlying *__JPH_RotatedTranslatedShape_GetMaterial(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID);
                var __c_ret = __JPH_RotatedTranslatedShape_GetMaterial(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
            }

            // See Shape::GetSubShapeUserData
            /// Generated from method `JPH::RotatedTranslatedShape::GetSubShapeUserData`.
            public unsafe ulong GetSubShapeUserData(Jolt.JPH.Const_SubShapeID inSubShapeID)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_RotatedTranslatedShape_GetSubShapeUserData(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID);
                return __JPH_RotatedTranslatedShape_GetSubShapeUserData(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
            }

            /// User data (to be used freely by the application)
            /// Generated from method `JPH::RotatedTranslatedShape::GetUserData`.
            public unsafe ulong GetUserData()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_RotatedTranslatedShape_GetUserData(_Underlying *_this);
                return __JPH_RotatedTranslatedShape_GetUserData(_UnderlyingPtr);
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::RotatedTranslatedShape::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RotatedTranslatedShape_SetEmbedded(_Underlying *_this);
                __JPH_RotatedTranslatedShape_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::RotatedTranslatedShape::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_RotatedTranslatedShape_GetRefCount(_Underlying *_this);
                return __JPH_RotatedTranslatedShape_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::RotatedTranslatedShape::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RotatedTranslatedShape_AddRef(_Underlying *_this);
                __JPH_RotatedTranslatedShape_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::RotatedTranslatedShape::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RotatedTranslatedShape_Release(_Underlying *_this);
                __JPH_RotatedTranslatedShape_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::RotatedTranslatedShape::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_RotatedTranslatedShape_sInternalGetRefCountOffset();
                return __JPH_RotatedTranslatedShape_sInternalGetRefCountOffset();
            }
        }

        /// A rotated translated shape will rotate and translate a child shape.
        /// Shifts the child object so that it is centered around the center of mass.
        /// Generated from class `JPH::RotatedTranslatedShape`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::DecoratedShape`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::Shape>`
        ///     `JPH::NonCopyable`
        ///     `JPH::Shape`
        /// This is the non-const half of the class.
        public class RotatedTranslatedShape : Const_RotatedTranslatedShape
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHShape(RotatedTranslatedShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_RefTarget_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHShape._Underlying *__JPH_RotatedTranslatedShape_UpcastTo_JPH_RefTarget_JPH_Shape(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHShape ret = new(__JPH_RotatedTranslatedShape_UpcastTo_JPH_RefTarget_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.NonCopyable(RotatedTranslatedShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_RotatedTranslatedShape_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_RotatedTranslatedShape_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Shape(RotatedTranslatedShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Shape._Underlying *__JPH_RotatedTranslatedShape_UpcastTo_JPH_Shape(_Underlying *_this);
                Jolt.JPH.Shape ret = new(__JPH_RotatedTranslatedShape_UpcastTo_JPH_Shape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.DecoratedShape(RotatedTranslatedShape self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_UpcastTo_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DecoratedShape._Underlying *__JPH_RotatedTranslatedShape_UpcastTo_JPH_DecoratedShape(_Underlying *_this);
                Jolt.JPH.DecoratedShape ret = new(__JPH_RotatedTranslatedShape_UpcastTo_JPH_DecoratedShape(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator RotatedTranslatedShape?(Jolt.JPH.Shape parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_Shape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_Shape(Jolt.JPH.Shape._Underlying *_this);
                var ptr = __JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_Shape(parent._UnderlyingPtr);
                if (ptr is null) return null;
                RotatedTranslatedShape ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator RotatedTranslatedShape?(Jolt.JPH.DecoratedShape parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_DecoratedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_DecoratedShape(Jolt.JPH.DecoratedShape._Underlying *_this);
                var ptr = __JPH_RotatedTranslatedShape_DynamicDowncastFrom_JPH_DecoratedShape(parent._UnderlyingPtr);
                if (ptr is null) return null;
                RotatedTranslatedShape ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe RotatedTranslatedShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe RotatedTranslatedShape() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RotatedTranslatedShape._Underlying *__JPH_RotatedTranslatedShape_DefaultConstruct();
                _UnderlyingPtr = __JPH_RotatedTranslatedShape_DefaultConstruct();
            }

            /// Generated from method `JPH::RotatedTranslatedShape::SetUserData`.
            public unsafe void SetUserData(ulong inUserData)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RotatedTranslatedShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RotatedTranslatedShape_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RotatedTranslatedShape_SetUserData(_Underlying *_this, ulong inUserData);
                __JPH_RotatedTranslatedShape_SetUserData(_UnderlyingPtr, inUserData);
            }
        }

        /// This is used as a function parameter when the underlying function receives `RotatedTranslatedShape` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_RotatedTranslatedShape
        {
            #pragma warning disable CS0649
            internal readonly Const_RotatedTranslatedShape? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_RotatedTranslatedShape() {PassByMode = Jolt._PassBy.default_construct;}
        }

        /// This is used for optional parameters of class `RotatedTranslatedShape` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_RotatedTranslatedShape`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `RotatedTranslatedShape`/`Const_RotatedTranslatedShape` directly.
        public class _InOptMut_RotatedTranslatedShape
        {
            public RotatedTranslatedShape? Opt;

            public _InOptMut_RotatedTranslatedShape() {}
            public _InOptMut_RotatedTranslatedShape(RotatedTranslatedShape value) {Opt = value;}
            public static implicit operator _InOptMut_RotatedTranslatedShape(RotatedTranslatedShape value) {return new(value);}
        }

        /// This is used for optional parameters of class `RotatedTranslatedShape` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_RotatedTranslatedShape`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `RotatedTranslatedShape`/`Const_RotatedTranslatedShape` to pass it to the function.
        public class _InOptConst_RotatedTranslatedShape
        {
            public Const_RotatedTranslatedShape? Opt;

            public _InOptConst_RotatedTranslatedShape() {}
            public _InOptConst_RotatedTranslatedShape(Const_RotatedTranslatedShape value) {Opt = value;}
            public static implicit operator _InOptConst_RotatedTranslatedShape(Const_RotatedTranslatedShape value) {return new(value);}
        }
    }
}
