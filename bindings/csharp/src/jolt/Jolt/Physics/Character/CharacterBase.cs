// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Base class for configuration of a character
        /// Generated from class `JPH::CharacterBaseSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::RefTarget<JPH::CharacterBaseSettings>`
        /// Derived classes:
        ///   Direct: (non-virtual)
        ///     `JPH::CharacterVirtualSettings`
        /// This is the const half of the class.
        public class Const_CharacterBaseSettings : Jolt.Object<Const_CharacterBaseSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterBaseSettings_Destroy(_Underlying *_this);
                __JPH_CharacterBaseSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_CharacterBaseSettings() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHCharacterBaseSettings(Const_CharacterBaseSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHCharacterBaseSettings._Underlying *__JPH_CharacterBaseSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHCharacterBaseSettings ret = new(__JPH_CharacterBaseSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            /// Vector indicating the up direction of the character
            public unsafe Jolt.JPH.Const_Vec3 mUp
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_Get_mUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_Get_mUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.Const_Vec3._Underlying *__JPH_CharacterBaseSettings_Get_mUp(_Underlying *_this);
                    Jolt.JPH.Const_Vec3 __ret;
                    __ret = new(__JPH_CharacterBaseSettings_Get_mUp(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            /// Maximum angle of slope that character can still walk on (radians).
            public unsafe float mMaxSlopeAngle
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_Get_mMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_Get_mMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterBaseSettings_Get_mMaxSlopeAngle(_Underlying *_this);
                    return *__JPH_CharacterBaseSettings_Get_mMaxSlopeAngle(_UnderlyingPtr);
                }
            }

            /// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
            public unsafe bool mEnhancedInternalEdgeRemoval
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_Get_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_Get_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_CharacterBaseSettings_Get_mEnhancedInternalEdgeRemoval(_Underlying *_this);
                    return *__JPH_CharacterBaseSettings_Get_mEnhancedInternalEdgeRemoval(_UnderlyingPtr);
                }
            }

            internal unsafe Const_CharacterBaseSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_CharacterBaseSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterBaseSettings._Underlying *__JPH_CharacterBaseSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_CharacterBaseSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::CharacterBaseSettings::CharacterBaseSettings`.
            public unsafe Const_CharacterBaseSettings(Jolt.JPH._ByValue_CharacterBaseSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterBaseSettings._Underlying *__JPH_CharacterBaseSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.CharacterBaseSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_CharacterBaseSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::CharacterBaseSettings::CharacterBaseSettings`.
            public Const_CharacterBaseSettings(Const_CharacterBaseSettings _other) : this(new _ByValue_CharacterBaseSettings(_other)) {}

            /// Generated from constructor `JPH::CharacterBaseSettings::CharacterBaseSettings`.
            public Const_CharacterBaseSettings(CharacterBaseSettings _other) : this((Const_CharacterBaseSettings)_other) {}

            /// Generated from method `JPH::CharacterBaseSettings::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CharacterBaseSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CharacterBaseSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_CharacterBaseSettings_size_t(ulong inCount);
                return __Jolt_new_JPH_CharacterBaseSettings_size_t(inCount);
            }

            /// Generated from method `JPH::CharacterBaseSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterBaseSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterBaseSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CharacterBaseSettings_void_ptr(void *inPointer);
                __Jolt_delete_JPH_CharacterBaseSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::CharacterBaseSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterBaseSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterBaseSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CharacterBaseSettings_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_CharacterBaseSettings_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::CharacterBaseSettings::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterBaseSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterBaseSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_CharacterBaseSettings_size_t(ulong inCount);
                return __Jolt_new_array_JPH_CharacterBaseSettings_size_t(inCount);
            }

            /// Generated from method `JPH::CharacterBaseSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::CharacterBaseSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::CharacterBaseSettings::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CharacterBaseSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CharacterBaseSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_CharacterBaseSettings_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_CharacterBaseSettings_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::CharacterBaseSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterBaseSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterBaseSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CharacterBaseSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_CharacterBaseSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::CharacterBaseSettings::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterBaseSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterBaseSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_CharacterBaseSettings_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_CharacterBaseSettings_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::CharacterBaseSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_CharacterBaseSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::CharacterBaseSettings::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterBaseSettings_SetEmbedded(_Underlying *_this);
                __JPH_CharacterBaseSettings_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::CharacterBaseSettings::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_CharacterBaseSettings_GetRefCount(_Underlying *_this);
                return __JPH_CharacterBaseSettings_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::CharacterBaseSettings::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterBaseSettings_AddRef(_Underlying *_this);
                __JPH_CharacterBaseSettings_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::CharacterBaseSettings::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterBaseSettings_Release(_Underlying *_this);
                __JPH_CharacterBaseSettings_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::CharacterBaseSettings::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_CharacterBaseSettings_sInternalGetRefCountOffset();
                return __JPH_CharacterBaseSettings_sInternalGetRefCountOffset();
            }
        }

        /// Base class for configuration of a character
        /// Generated from class `JPH::CharacterBaseSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::RefTarget<JPH::CharacterBaseSettings>`
        /// Derived classes:
        ///   Direct: (non-virtual)
        ///     `JPH::CharacterVirtualSettings`
        /// This is the non-const half of the class.
        public class CharacterBaseSettings : Const_CharacterBaseSettings
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHCharacterBaseSettings(CharacterBaseSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHCharacterBaseSettings._Underlying *__JPH_CharacterBaseSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHCharacterBaseSettings ret = new(__JPH_CharacterBaseSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            /// Vector indicating the up direction of the character
            public new unsafe Jolt.JPH.Vec3 mUp
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_GetMutable_mUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_GetMutable_mUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.Vec3._Underlying *__JPH_CharacterBaseSettings_GetMutable_mUp(_Underlying *_this);
                    Jolt.JPH.Vec3 __ret;
                    __ret = new(__JPH_CharacterBaseSettings_GetMutable_mUp(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            /// Maximum angle of slope that character can still walk on (radians).
            public new unsafe ref float mMaxSlopeAngle
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_GetMutable_mMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_GetMutable_mMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterBaseSettings_GetMutable_mMaxSlopeAngle(_Underlying *_this);
                    return ref *__JPH_CharacterBaseSettings_GetMutable_mMaxSlopeAngle(_UnderlyingPtr);
                }
            }

            /// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
            public new unsafe ref bool mEnhancedInternalEdgeRemoval
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_GetMutable_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_GetMutable_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_CharacterBaseSettings_GetMutable_mEnhancedInternalEdgeRemoval(_Underlying *_this);
                    return ref *__JPH_CharacterBaseSettings_GetMutable_mEnhancedInternalEdgeRemoval(_UnderlyingPtr);
                }
            }

            internal unsafe CharacterBaseSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe CharacterBaseSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterBaseSettings._Underlying *__JPH_CharacterBaseSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_CharacterBaseSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::CharacterBaseSettings::CharacterBaseSettings`.
            public unsafe CharacterBaseSettings(Jolt.JPH._ByValue_CharacterBaseSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterBaseSettings._Underlying *__JPH_CharacterBaseSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.CharacterBaseSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_CharacterBaseSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::CharacterBaseSettings::CharacterBaseSettings`.
            public CharacterBaseSettings(Const_CharacterBaseSettings _other) : this(new _ByValue_CharacterBaseSettings(_other)) {}

            /// Generated from constructor `JPH::CharacterBaseSettings::CharacterBaseSettings`.
            public CharacterBaseSettings(CharacterBaseSettings _other) : this((Const_CharacterBaseSettings)_other) {}

            /// Generated from method `JPH::CharacterBaseSettings::operator=`.
            public unsafe Jolt.JPH.CharacterBaseSettings Assign(Jolt.JPH._ByValue_CharacterBaseSettings _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBaseSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBaseSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterBaseSettings._Underlying *__JPH_CharacterBaseSettings_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JPH.CharacterBaseSettings._Underlying *_other);
                Jolt.JPH.CharacterBaseSettings __ret;
                __ret = new(__JPH_CharacterBaseSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                __ret._KeepAlive(this);
                return __ret;
            }
        }

        /// This is used as a function parameter when the underlying function receives `CharacterBaseSettings` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `CharacterBaseSettings`/`Const_CharacterBaseSettings` to copy it into the function.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_CharacterBaseSettings
        {
            #pragma warning disable CS0649
            internal readonly Const_CharacterBaseSettings? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_CharacterBaseSettings() {PassByMode = Jolt._PassBy.default_construct;}
            public _ByValue_CharacterBaseSettings(Const_CharacterBaseSettings new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
            public static implicit operator _ByValue_CharacterBaseSettings(Const_CharacterBaseSettings arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `CharacterBaseSettings` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_CharacterBaseSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterBaseSettings`/`Const_CharacterBaseSettings` directly.
        public class _InOptMut_CharacterBaseSettings
        {
            public CharacterBaseSettings? Opt;

            public _InOptMut_CharacterBaseSettings() {}
            public _InOptMut_CharacterBaseSettings(CharacterBaseSettings value) {Opt = value;}
            public static implicit operator _InOptMut_CharacterBaseSettings(CharacterBaseSettings value) {return new(value);}
        }

        /// This is used for optional parameters of class `CharacterBaseSettings` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_CharacterBaseSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterBaseSettings`/`Const_CharacterBaseSettings` to pass it to the function.
        public class _InOptConst_CharacterBaseSettings
        {
            public Const_CharacterBaseSettings? Opt;

            public _InOptConst_CharacterBaseSettings() {}
            public _InOptConst_CharacterBaseSettings(Const_CharacterBaseSettings value) {Opt = value;}
            public static implicit operator _InOptConst_CharacterBaseSettings(Const_CharacterBaseSettings value) {return new(value);}
        }

        /// Base class for character class
        /// Generated from class `JPH::CharacterBase`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::RefTarget<JPH::CharacterBase>`
        ///     `JPH::NonCopyable`
        /// Derived classes:
        ///   Direct: (non-virtual)
        ///     `JPH::CharacterVirtual`
        /// This is the const half of the class.
        public class Const_CharacterBase : Jolt.Object<Const_CharacterBase>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterBase_Destroy(_Underlying *_this);
                __JPH_CharacterBase_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_CharacterBase() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHCharacterBase(Const_CharacterBase self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHCharacterBase._Underlying *__JPH_CharacterBase_UpcastTo_JPH_RefTarget_JPH_CharacterBase(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHCharacterBase ret = new(__JPH_CharacterBase_UpcastTo_JPH_RefTarget_JPH_CharacterBase(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_CharacterBase self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_CharacterBase_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_CharacterBase_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            internal unsafe Const_CharacterBase(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructor
            /// Generated from constructor `JPH::CharacterBase::CharacterBase`.
            public unsafe Const_CharacterBase(Jolt.JPH.Const_CharacterBaseSettings? inSettings, Jolt.JPH.PhysicsSystem? inSystem) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterBase._Underlying *__JPH_CharacterBase_Construct(Jolt.JPH.Const_CharacterBaseSettings._Underlying *inSettings, Jolt.JPH.PhysicsSystem._Underlying *inSystem);
                _UnderlyingPtr = __JPH_CharacterBase_Construct(inSettings is not null ? inSettings._UnderlyingPtr : null, inSystem is not null ? inSystem._UnderlyingPtr : null);
            }

            /// Generated from method `JPH::CharacterBase::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CharacterBase_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CharacterBase_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_CharacterBase_size_t(ulong inCount);
                return __Jolt_new_JPH_CharacterBase_size_t(inCount);
            }

            /// Generated from method `JPH::CharacterBase::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterBase_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterBase_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CharacterBase_void_ptr(void *inPointer);
                __Jolt_delete_JPH_CharacterBase_void_ptr(inPointer);
            }

            /// Generated from method `JPH::CharacterBase::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterBase_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterBase_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CharacterBase_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_CharacterBase_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::CharacterBase::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterBase_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterBase_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_CharacterBase_size_t(ulong inCount);
                return __Jolt_new_array_JPH_CharacterBase_size_t(inCount);
            }

            /// Generated from method `JPH::CharacterBase::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterBase_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterBase_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CharacterBase_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_CharacterBase_void_ptr(inPointer);
            }

            /// Generated from method `JPH::CharacterBase::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterBase_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterBase_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CharacterBase_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_CharacterBase_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::CharacterBase::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CharacterBase_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CharacterBase_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_CharacterBase_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_CharacterBase_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::CharacterBase::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterBase_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterBase_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CharacterBase_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_CharacterBase_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::CharacterBase::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterBase_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterBase_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_CharacterBase_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_CharacterBase_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::CharacterBase::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterBase_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterBase_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CharacterBase_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_CharacterBase_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::CharacterBase::GetCosMaxSlopeAngle`.
            public unsafe float GetCosMaxSlopeAngle()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_GetCosMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_GetCosMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_CharacterBase_GetCosMaxSlopeAngle(_Underlying *_this);
                return __JPH_CharacterBase_GetCosMaxSlopeAngle(_UnderlyingPtr);
            }

            /// Generated from method `JPH::CharacterBase::GetUp`.
            public unsafe Jolt.JPH.Vec3 GetUp()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_GetUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_GetUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_CharacterBase_GetUp(_Underlying *_this);
                return new(__JPH_CharacterBase_GetUp(_UnderlyingPtr), is_owning: true);
            }

            /// Check if the normal of the ground surface is too steep to walk on
            /// Generated from method `JPH::CharacterBase::IsSlopeTooSteep`.
            public unsafe bool IsSlopeTooSteep(Jolt.JPH.Const_Vec3 inNormal)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_IsSlopeTooSteep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_IsSlopeTooSteep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_CharacterBase_IsSlopeTooSteep(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inNormal);
                return __JPH_CharacterBase_IsSlopeTooSteep(_UnderlyingPtr, inNormal._UnderlyingPtr) != 0;
            }

            /// Get the current shape that the character is using.
            /// Generated from method `JPH::CharacterBase::GetShape`.
            public unsafe Jolt.JPH.Const_Shape? GetShape()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_GetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_GetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Shape._Underlying *__JPH_CharacterBase_GetShape(_Underlying *_this);
                var __c_ret = __JPH_CharacterBase_GetShape(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_Shape(__c_ret, is_owning: false) : null;
            }

            /// Debug function to convert enum values to string
            /// Generated from method `JPH::CharacterBase::sToString`.
            public static unsafe byte? SToString(Jolt.JPH.CharacterBase.EGroundState inState)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_sToString", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_sToString", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte *__JPH_CharacterBase_sToString(Jolt.JPH.CharacterBase.EGroundState inState);
                var __c_ret = __JPH_CharacterBase_sToString(inState);
                return __c_ret is not null ? *__c_ret : null;
            }

            /// Current ground state
            /// Generated from method `JPH::CharacterBase::GetGroundState`.
            public unsafe Jolt.JPH.CharacterBase.EGroundState GetGroundState()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_GetGroundState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_GetGroundState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterBase.EGroundState __JPH_CharacterBase_GetGroundState(_Underlying *_this);
                return __JPH_CharacterBase_GetGroundState(_UnderlyingPtr);
            }

            /// Returns true if the player is supported by normal or steep ground
            /// Generated from method `JPH::CharacterBase::IsSupported`.
            public unsafe bool IsSupported()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_IsSupported", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_IsSupported", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_CharacterBase_IsSupported(_Underlying *_this);
                return __JPH_CharacterBase_IsSupported(_UnderlyingPtr) != 0;
            }

            /// Get the contact point with the ground
            /// Generated from method `JPH::CharacterBase::GetGroundPosition`.
            public unsafe Jolt.JPH.Vec3 GetGroundPosition()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_GetGroundPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_GetGroundPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_CharacterBase_GetGroundPosition(_Underlying *_this);
                return new(__JPH_CharacterBase_GetGroundPosition(_UnderlyingPtr), is_owning: true);
            }

            /// Get the contact normal with the ground
            /// Generated from method `JPH::CharacterBase::GetGroundNormal`.
            public unsafe Jolt.JPH.Vec3 GetGroundNormal()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_GetGroundNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_GetGroundNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_CharacterBase_GetGroundNormal(_Underlying *_this);
                return new(__JPH_CharacterBase_GetGroundNormal(_UnderlyingPtr), is_owning: true);
            }

            /// Velocity in world space of ground
            /// Generated from method `JPH::CharacterBase::GetGroundVelocity`.
            public unsafe Jolt.JPH.Vec3 GetGroundVelocity()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_GetGroundVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_GetGroundVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_CharacterBase_GetGroundVelocity(_Underlying *_this);
                return new(__JPH_CharacterBase_GetGroundVelocity(_UnderlyingPtr), is_owning: true);
            }

            /// Material that the character is standing on
            /// Generated from method `JPH::CharacterBase::GetGroundMaterial`.
            public unsafe Jolt.JPH.Const_PhysicsMaterial? GetGroundMaterial()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_GetGroundMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_GetGroundMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_PhysicsMaterial._Underlying *__JPH_CharacterBase_GetGroundMaterial(_Underlying *_this);
                var __c_ret = __JPH_CharacterBase_GetGroundMaterial(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
            }

            /// BodyID of the object the character is standing on. Note may have been removed!
            /// Generated from method `JPH::CharacterBase::GetGroundBodyID`.
            public unsafe Jolt.JPH.BodyID GetGroundBodyID()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_GetGroundBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_GetGroundBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BodyID __JPH_CharacterBase_GetGroundBodyID(_Underlying *_this);
                return __JPH_CharacterBase_GetGroundBodyID(_UnderlyingPtr);
            }

            /// Sub part of the body that we're standing on.
            /// Generated from method `JPH::CharacterBase::GetGroundSubShapeID`.
            public unsafe Jolt.JPH.SubShapeID GetGroundSubShapeID()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_GetGroundSubShapeID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_GetGroundSubShapeID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SubShapeID._Underlying *__JPH_CharacterBase_GetGroundSubShapeID(_Underlying *_this);
                return new(__JPH_CharacterBase_GetGroundSubShapeID(_UnderlyingPtr), is_owning: true);
            }

            /// User data value of the body that we're standing on
            /// Generated from method `JPH::CharacterBase::GetGroundUserData`.
            public unsafe ulong GetGroundUserData()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_GetGroundUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_GetGroundUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_CharacterBase_GetGroundUserData(_Underlying *_this);
                return __JPH_CharacterBase_GetGroundUserData(_UnderlyingPtr);
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::CharacterBase::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterBase_SetEmbedded(_Underlying *_this);
                __JPH_CharacterBase_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::CharacterBase::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_CharacterBase_GetRefCount(_Underlying *_this);
                return __JPH_CharacterBase_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::CharacterBase::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterBase_AddRef(_Underlying *_this);
                __JPH_CharacterBase_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::CharacterBase::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterBase_Release(_Underlying *_this);
                __JPH_CharacterBase_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::CharacterBase::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_CharacterBase_sInternalGetRefCountOffset();
                return __JPH_CharacterBase_sInternalGetRefCountOffset();
            }

            public enum EGroundState : int
            {
                ///< Character is on the ground and can move freely.
                OnGround = 0,
                ///< Character is on a slope that is too steep and can't climb up any further. The caller should start applying downward velocity if sliding from the slope is desired.
                OnSteepGround = 1,
                ///< Character is touching an object, but is not supported by it and should fall. The GetGroundXXX functions will return information about the touched object.
                NotSupported = 2,
                ///< Character is in the air and is not touching anything.
                InAir = 3,
            }
        }

        /// Base class for character class
        /// Generated from class `JPH::CharacterBase`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::RefTarget<JPH::CharacterBase>`
        ///     `JPH::NonCopyable`
        /// Derived classes:
        ///   Direct: (non-virtual)
        ///     `JPH::CharacterVirtual`
        /// This is the non-const half of the class.
        public class CharacterBase : Const_CharacterBase
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHCharacterBase(CharacterBase self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHCharacterBase._Underlying *__JPH_CharacterBase_UpcastTo_JPH_RefTarget_JPH_CharacterBase(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHCharacterBase ret = new(__JPH_CharacterBase_UpcastTo_JPH_RefTarget_JPH_CharacterBase(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.NonCopyable(CharacterBase self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_CharacterBase_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_CharacterBase_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            internal unsafe CharacterBase(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructor
            /// Generated from constructor `JPH::CharacterBase::CharacterBase`.
            public unsafe CharacterBase(Jolt.JPH.Const_CharacterBaseSettings? inSettings, Jolt.JPH.PhysicsSystem? inSystem) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterBase._Underlying *__JPH_CharacterBase_Construct(Jolt.JPH.Const_CharacterBaseSettings._Underlying *inSettings, Jolt.JPH.PhysicsSystem._Underlying *inSystem);
                _UnderlyingPtr = __JPH_CharacterBase_Construct(inSettings is not null ? inSettings._UnderlyingPtr : null, inSystem is not null ? inSystem._UnderlyingPtr : null);
            }

            /// Set the maximum angle of slope that character can still walk on (radians)
            /// Generated from method `JPH::CharacterBase::SetMaxSlopeAngle`.
            public unsafe void SetMaxSlopeAngle(float inMaxSlopeAngle)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_SetMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_SetMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterBase_SetMaxSlopeAngle(_Underlying *_this, float inMaxSlopeAngle);
                __JPH_CharacterBase_SetMaxSlopeAngle(_UnderlyingPtr, inMaxSlopeAngle);
            }

            /// Set the up vector for the character
            /// Generated from method `JPH::CharacterBase::SetUp`.
            public unsafe void SetUp(Jolt.JPH.Const_Vec3 inUp)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterBase_SetUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterBase_SetUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterBase_SetUp(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inUp);
                __JPH_CharacterBase_SetUp(_UnderlyingPtr, inUp._UnderlyingPtr);
            }
        }

        /// This is used for optional parameters of class `CharacterBase` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_CharacterBase`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterBase`/`Const_CharacterBase` directly.
        public class _InOptMut_CharacterBase
        {
            public CharacterBase? Opt;

            public _InOptMut_CharacterBase() {}
            public _InOptMut_CharacterBase(CharacterBase value) {Opt = value;}
            public static implicit operator _InOptMut_CharacterBase(CharacterBase value) {return new(value);}
        }

        /// This is used for optional parameters of class `CharacterBase` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_CharacterBase`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterBase`/`Const_CharacterBase` to pass it to the function.
        public class _InOptConst_CharacterBase
        {
            public Const_CharacterBase? Opt;

            public _InOptConst_CharacterBase() {}
            public _InOptConst_CharacterBase(Const_CharacterBase value) {Opt = value;}
            public static implicit operator _InOptConst_CharacterBase(Const_CharacterBase value) {return new(value);}
        }
    }
}
