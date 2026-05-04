// machine generated, do not edit
public static partial class JPH
{
    /// Contains the configuration of a character
    /// Generated from class `JPH::CharacterSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CharacterBaseSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::CharacterBaseSettings>`
    /// This is the const half of the class.
    public class Const_CharacterSettings : JPH.Object<Const_CharacterSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBaseSettings_Release(void *_this);
            __JPH_RefTarget_JPH_CharacterBaseSettings_Release(__JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_CharacterSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHCharacterBaseSettings(Const_CharacterSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHCharacterBaseSettings._Underlying *__JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHCharacterBaseSettings ret = new(__JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_CharacterBaseSettings(Const_CharacterSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_CharacterBaseSettings._Underlying *__JPH_CharacterSettings_UpcastTo_JPH_CharacterBaseSettings(_Underlying *_this);
            JPH.Const_CharacterBaseSettings ret = new(__JPH_CharacterSettings_UpcastTo_JPH_CharacterBaseSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_CharacterSettings(JPH.Const_RefTarget_JPHCharacterBaseSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CharacterSettings_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(JPH.Const_RefTarget_JPHCharacterBaseSettings._Underlying *_this);
            Const_CharacterSettings ret = new(__JPH_CharacterSettings_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_CharacterSettings(JPH.Const_CharacterBaseSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_StaticDowncastFrom_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_StaticDowncastFrom_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CharacterSettings_StaticDowncastFrom_JPH_CharacterBaseSettings(JPH.Const_CharacterBaseSettings._Underlying *_this);
            Const_CharacterSettings ret = new(__JPH_CharacterSettings_StaticDowncastFrom_JPH_CharacterBaseSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// Layer that this character will be added to
        public unsafe ushort mLayer
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_Get_mLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_Get_mLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ushort *__JPH_CharacterSettings_Get_mLayer(_Underlying *_this);
                return *__JPH_CharacterSettings_Get_mLayer(_UnderlyingPtr);
            }
        }

        /// Mass of the character
        public unsafe float mMass
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_Get_mMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_Get_mMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CharacterSettings_Get_mMass(_Underlying *_this);
                return *__JPH_CharacterSettings_Get_mMass(_UnderlyingPtr);
            }
        }

        /// Friction for the character
        public unsafe float mFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_Get_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_Get_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CharacterSettings_Get_mFriction(_Underlying *_this);
                return *__JPH_CharacterSettings_Get_mFriction(_UnderlyingPtr);
            }
        }

        /// Value to multiply gravity with for this character
        public unsafe float mGravityFactor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_Get_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_Get_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CharacterSettings_Get_mGravityFactor(_Underlying *_this);
                return *__JPH_CharacterSettings_Get_mGravityFactor(_UnderlyingPtr);
            }
        }

        /// Vector indicating the up direction of the character
        public unsafe JPH.Const_Vec3 mUp
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_Get_mUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_Get_mUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_CharacterSettings_Get_mUp(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_CharacterSettings_Get_mUp(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// Plane, defined in local space relative to the character. Every contact behind this plane can support the
        /// character, every contact in front of this plane is treated as only colliding with the player.
        /// Default: Accept any contact.
        public unsafe JPH.Const_Plane mSupportingVolume
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_Get_mSupportingVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_Get_mSupportingVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Plane._Underlying *__JPH_CharacterSettings_Get_mSupportingVolume(_Underlying *_this);
                JPH.Const_Plane __ret;
                __ret = new(__JPH_CharacterSettings_Get_mSupportingVolume(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_Get_mMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_Get_mMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CharacterSettings_Get_mMaxSlopeAngle(_Underlying *_this);
                return *__JPH_CharacterSettings_Get_mMaxSlopeAngle(_UnderlyingPtr);
            }
        }

        /// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
        public unsafe bool mEnhancedInternalEdgeRemoval
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_Get_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_Get_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_CharacterSettings_Get_mEnhancedInternalEdgeRemoval(_Underlying *_this);
                return *__JPH_CharacterSettings_Get_mEnhancedInternalEdgeRemoval(_UnderlyingPtr);
            }
        }

        internal unsafe Const_CharacterSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_CharacterSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterSettings._Underlying *__JPH_CharacterSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_CharacterSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBaseSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_CharacterBaseSettings_AddRef(__JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::CharacterSettings::CharacterSettings`.
        public unsafe Const_CharacterSettings(JPH._ByValue_CharacterSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterSettings._Underlying *__JPH_CharacterSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.CharacterSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_CharacterSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBaseSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_CharacterBaseSettings_AddRef(__JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::CharacterSettings::CharacterSettings`.
        public Const_CharacterSettings(Const_CharacterSettings _other) : this(new _ByValue_CharacterSettings(_other)) {}

        /// Generated from constructor `JPH::CharacterSettings::CharacterSettings`.
        public Const_CharacterSettings(CharacterSettings _other) : this((Const_CharacterSettings)_other) {}

        /// Generated from method `JPH::CharacterSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CharacterSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CharacterSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CharacterSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_CharacterSettings_size_t(inCount);
        }

        /// Generated from method `JPH::CharacterSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CharacterSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_CharacterSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CharacterSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CharacterSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_CharacterSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CharacterSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CharacterSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_CharacterSettings_size_t(inCount);
        }

        /// Generated from method `JPH::CharacterSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CharacterSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_CharacterSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CharacterSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CharacterSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_CharacterSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CharacterSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CharacterSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CharacterSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CharacterSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_CharacterSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CharacterSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CharacterSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_CharacterSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::CharacterSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CharacterSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_CharacterSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CharacterSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CharacterSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_CharacterSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::CharacterSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CharacterSettings_SetEmbedded(_Underlying *_this);
            __JPH_CharacterSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::CharacterSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_CharacterSettings_GetRefCount(_Underlying *_this);
            return __JPH_CharacterSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::CharacterSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CharacterSettings_AddRef(_Underlying *_this);
            __JPH_CharacterSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::CharacterSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CharacterSettings_Release(_Underlying *_this);
            __JPH_CharacterSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::CharacterSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_CharacterSettings_sInternalGetRefCountOffset();
            return __JPH_CharacterSettings_sInternalGetRefCountOffset();
        }
    }

    /// Contains the configuration of a character
    /// Generated from class `JPH::CharacterSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CharacterBaseSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::CharacterBaseSettings>`
    /// This is the non-const half of the class.
    public class CharacterSettings : Const_CharacterSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHCharacterBaseSettings(CharacterSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHCharacterBaseSettings._Underlying *__JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_Underlying *_this);
            JPH.RefTarget_JPHCharacterBaseSettings ret = new(__JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.CharacterBaseSettings(CharacterSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterBaseSettings._Underlying *__JPH_CharacterSettings_UpcastTo_JPH_CharacterBaseSettings(_Underlying *_this);
            JPH.CharacterBaseSettings ret = new(__JPH_CharacterSettings_UpcastTo_JPH_CharacterBaseSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator CharacterSettings(JPH.RefTarget_JPHCharacterBaseSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CharacterSettings_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(JPH.RefTarget_JPHCharacterBaseSettings._Underlying *_this);
            CharacterSettings ret = new(__JPH_CharacterSettings_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBaseSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator CharacterSettings(JPH.CharacterBaseSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_StaticDowncastFrom_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_StaticDowncastFrom_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CharacterSettings_StaticDowncastFrom_JPH_CharacterBaseSettings(JPH.CharacterBaseSettings._Underlying *_this);
            CharacterSettings ret = new(__JPH_CharacterSettings_StaticDowncastFrom_JPH_CharacterBaseSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// Layer that this character will be added to
        public new unsafe ref ushort mLayer
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ushort *__JPH_CharacterSettings_GetMutable_mLayer(_Underlying *_this);
                return ref *__JPH_CharacterSettings_GetMutable_mLayer(_UnderlyingPtr);
            }
        }

        /// Mass of the character
        public new unsafe ref float mMass
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CharacterSettings_GetMutable_mMass(_Underlying *_this);
                return ref *__JPH_CharacterSettings_GetMutable_mMass(_UnderlyingPtr);
            }
        }

        /// Friction for the character
        public new unsafe ref float mFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CharacterSettings_GetMutable_mFriction(_Underlying *_this);
                return ref *__JPH_CharacterSettings_GetMutable_mFriction(_UnderlyingPtr);
            }
        }

        /// Value to multiply gravity with for this character
        public new unsafe ref float mGravityFactor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CharacterSettings_GetMutable_mGravityFactor(_Underlying *_this);
                return ref *__JPH_CharacterSettings_GetMutable_mGravityFactor(_UnderlyingPtr);
            }
        }

        /// Vector indicating the up direction of the character
        public new unsafe JPH.Vec3 mUp
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_CharacterSettings_GetMutable_mUp(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_CharacterSettings_GetMutable_mUp(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// Plane, defined in local space relative to the character. Every contact behind this plane can support the
        /// character, every contact in front of this plane is treated as only colliding with the player.
        /// Default: Accept any contact.
        public new unsafe JPH.Plane mSupportingVolume
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mSupportingVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mSupportingVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Plane._Underlying *__JPH_CharacterSettings_GetMutable_mSupportingVolume(_Underlying *_this);
                JPH.Plane __ret;
                __ret = new(__JPH_CharacterSettings_GetMutable_mSupportingVolume(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CharacterSettings_GetMutable_mMaxSlopeAngle(_Underlying *_this);
                return ref *__JPH_CharacterSettings_GetMutable_mMaxSlopeAngle(_UnderlyingPtr);
            }
        }

        /// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
        public new unsafe ref bool mEnhancedInternalEdgeRemoval
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_GetMutable_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_CharacterSettings_GetMutable_mEnhancedInternalEdgeRemoval(_Underlying *_this);
                return ref *__JPH_CharacterSettings_GetMutable_mEnhancedInternalEdgeRemoval(_UnderlyingPtr);
            }
        }

        internal unsafe CharacterSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe CharacterSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterSettings._Underlying *__JPH_CharacterSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_CharacterSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBaseSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_CharacterBaseSettings_AddRef(__JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::CharacterSettings::CharacterSettings`.
        public unsafe CharacterSettings(JPH._ByValue_CharacterSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterSettings._Underlying *__JPH_CharacterSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.CharacterSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_CharacterSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBaseSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBaseSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_CharacterBaseSettings_AddRef(__JPH_CharacterSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::CharacterSettings::CharacterSettings`.
        public CharacterSettings(Const_CharacterSettings _other) : this(new _ByValue_CharacterSettings(_other)) {}

        /// Generated from constructor `JPH::CharacterSettings::CharacterSettings`.
        public CharacterSettings(CharacterSettings _other) : this((Const_CharacterSettings)_other) {}

        /// Generated from method `JPH::CharacterSettings::operator=`.
        public unsafe JPH.CharacterSettings Assign(JPH._ByValue_CharacterSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterSettings._Underlying *__JPH_CharacterSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.CharacterSettings._Underlying *_other);
            JPH.CharacterSettings __ret;
            __ret = new(__JPH_CharacterSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `CharacterSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `CharacterSettings`/`Const_CharacterSettings` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_CharacterSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_CharacterSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_CharacterSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_CharacterSettings(Const_CharacterSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_CharacterSettings(Const_CharacterSettings arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `CharacterSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_CharacterSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CharacterSettings`/`Const_CharacterSettings` directly.
    public class _InOptMut_CharacterSettings
    {
        public CharacterSettings? Opt;

        public _InOptMut_CharacterSettings() {}
        public _InOptMut_CharacterSettings(CharacterSettings value) {Opt = value;}
        public static implicit operator _InOptMut_CharacterSettings(CharacterSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `CharacterSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_CharacterSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CharacterSettings`/`Const_CharacterSettings` to pass it to the function.
    public class _InOptConst_CharacterSettings
    {
        public Const_CharacterSettings? Opt;

        public _InOptConst_CharacterSettings() {}
        public _InOptConst_CharacterSettings(Const_CharacterSettings value) {Opt = value;}
        public static implicit operator _InOptConst_CharacterSettings(Const_CharacterSettings value) {return new(value);}
    }

    /// Runtime character object.
    /// This object usually represents the player or a humanoid AI. It uses a single rigid body,
    /// usually with a capsule shape to simulate movement and collision for the character.
    /// The character is a keyframed object, the application controls it by setting the velocity.
    /// Generated from class `JPH::Character`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CharacterBase`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::CharacterBase>`
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_Character : JPH.Object<Const_Character>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBase_Release(void *_this);
            __JPH_RefTarget_JPH_CharacterBase_Release(__JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Character() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHCharacterBase(Const_Character self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHCharacterBase._Underlying *__JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase(_Underlying *_this);
            JPH.Const_RefTarget_JPHCharacterBase ret = new(__JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_Character self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_Character_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_Character_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_CharacterBase(Const_Character self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_CharacterBase._Underlying *__JPH_Character_UpcastTo_JPH_CharacterBase(_Underlying *_this);
            JPH.Const_CharacterBase ret = new(__JPH_Character_UpcastTo_JPH_CharacterBase(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_Character(JPH.Const_RefTarget_JPHCharacterBase parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Character_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(JPH.Const_RefTarget_JPHCharacterBase._Underlying *_this);
            Const_Character ret = new(__JPH_Character_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_Character(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Character_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_Character ret = new(__JPH_Character_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_Character(JPH.Const_CharacterBase parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_StaticDowncastFrom_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_StaticDowncastFrom_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Character_StaticDowncastFrom_JPH_CharacterBase(JPH.Const_CharacterBase._Underlying *_this);
            Const_Character ret = new(__JPH_Character_StaticDowncastFrom_JPH_CharacterBase(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_Character(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// @param inSettings The settings for the character
        /// @param inPosition Initial position for the character
        /// @param inRotation Initial rotation for the character (usually only around Y)
        /// @param inUserData Application specific value
        /// @param inSystem Physics system that this character will be added to later
        /// Generated from constructor `JPH::Character::Character`.
        public unsafe Const_Character(JPH.Const_CharacterSettings? inSettings, JPH.Const_Vec3 inPosition, JPH.Const_Quat inRotation, UIntPtr inUserData, JPH.PhysicsSystem? inSystem) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Character._Underlying *__JPH_Character_Construct(JPH.Const_CharacterSettings._Underlying *inSettings, JPH.Vec3._Underlying *inPosition, JPH.Quat._Underlying *inRotation, UIntPtr inUserData, JPH.PhysicsSystem._Underlying *inSystem);
            _UnderlyingPtr = __JPH_Character_Construct(inSettings is not null ? inSettings._UnderlyingPtr : null, inPosition._UnderlyingPtr, inRotation._UnderlyingPtr, inUserData, inSystem is not null ? inSystem._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBase_AddRef(void *_this);
            __JPH_RefTarget_JPH_CharacterBase_AddRef(__JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase(_UnderlyingPtr));
        }

        /// Generated from method `JPH::Character::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Character_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Character_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Character_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_Character_size_t(inCount);
        }

        /// Generated from method `JPH::Character::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Character_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Character_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Character_void_ptr(void *inPointer);
            __Jolt_delete_JPH_Character_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Character::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Character_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Character_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Character_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_Character_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Character::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Character_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Character_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Character_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_Character_size_t(inCount);
        }

        /// Generated from method `JPH::Character::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Character_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Character_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Character_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_Character_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Character::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Character_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Character_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Character_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_Character_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Character::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Character_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Character_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Character_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_Character_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Character::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Character_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Character_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Character_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_Character_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::Character::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Character_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Character_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Character_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_Character_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Character::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Character_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Character_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Character_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_Character_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Get the linear velocity of the character (m / s)
        /// Generated from method `JPH::Character::GetLinearVelocity`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe JPH.Vec3 GetLinearVelocity(bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Character_GetLinearVelocity(_Underlying *_this, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            return new(__JPH_Character_GetLinearVelocity(_UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null), is_owning: true);
        }

        /// Get the body associated with this character
        /// Generated from method `JPH::Character::GetBodyID`.
        public unsafe JPH.BodyID GetBodyID()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID __JPH_Character_GetBodyID(_Underlying *_this);
            return __JPH_Character_GetBodyID(_UnderlyingPtr);
        }

        /// Get position / rotation of the body
        /// Generated from method `JPH::Character::GetPositionAndRotation`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void GetPositionAndRotation(JPH.Vec3 outPosition, JPH.Quat outRotation, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetPositionAndRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetPositionAndRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_GetPositionAndRotation(_Underlying *_this, JPH.Vec3._Underlying *outPosition, JPH.Quat._Underlying *outRotation, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Character_GetPositionAndRotation(_UnderlyingPtr, outPosition._UnderlyingPtr, outRotation._UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Set the position / rotation of the body, optionally activating it.
        /// Generated from method `JPH::Character::SetPositionAndRotation`.
        /// Parameter `inActivationMode` defaults to `EActivation::Activate`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void SetPositionAndRotation(JPH.Const_Vec3 inPosition, JPH.Const_Quat inRotation, JPH.EActivation? inActivationMode = null, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_SetPositionAndRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_SetPositionAndRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_SetPositionAndRotation(_Underlying *_this, JPH.Vec3._Underlying *inPosition, JPH.Quat._Underlying *inRotation, JPH.EActivation *inActivationMode, byte *inLockBodies);
            JPH.EActivation __deref_inActivationMode = inActivationMode.GetValueOrDefault();
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Character_SetPositionAndRotation(_UnderlyingPtr, inPosition._UnderlyingPtr, inRotation._UnderlyingPtr, inActivationMode.HasValue ? &__deref_inActivationMode : null, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Get the position of the character
        /// Generated from method `JPH::Character::GetPosition`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe JPH.Vec3 GetPosition(bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Character_GetPosition(_Underlying *_this, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            return new(__JPH_Character_GetPosition(_UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null), is_owning: true);
        }

        /// Get the rotation of the character
        /// Generated from method `JPH::Character::GetRotation`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe JPH.Quat GetRotation(bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_Character_GetRotation(_Underlying *_this, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            return new(__JPH_Character_GetRotation(_UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null), is_owning: true);
        }

        /// Position of the center of mass of the underlying rigid body
        /// Generated from method `JPH::Character::GetCenterOfMassPosition`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe JPH.Vec3 GetCenterOfMassPosition(bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetCenterOfMassPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetCenterOfMassPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Character_GetCenterOfMassPosition(_Underlying *_this, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            return new(__JPH_Character_GetCenterOfMassPosition(_UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null), is_owning: true);
        }

        /// Calculate the world transform of the character
        /// Generated from method `JPH::Character::GetWorldTransform`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe JPH.Mat44 GetWorldTransform(bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_Character_GetWorldTransform(_Underlying *_this, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            return new(__JPH_Character_GetWorldTransform(_UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null), is_owning: true);
        }

        /// Get the layer of the character
        /// Generated from method `JPH::Character::GetLayer`.
        public unsafe ushort GetLayer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ushort __JPH_Character_GetLayer(_Underlying *_this);
            return __JPH_Character_GetLayer(_UnderlyingPtr);
        }

        /// Get the transformed shape that represents the volume of the character, can be used for collision checks.
        /// Generated from method `JPH::Character::GetTransformedShape`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe JPH.TransformedShape GetTransformedShape(bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetTransformedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetTransformedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TransformedShape._Underlying *__JPH_Character_GetTransformedShape(_Underlying *_this, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            return new(__JPH_Character_GetTransformedShape(_UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null), is_owning: true);
        }

        /// Get the character settings that can recreate this character
        /// Generated from method `JPH::Character::GetCharacterSettings`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe JPH.CharacterSettings GetCharacterSettings(bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetCharacterSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetCharacterSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterSettings._Underlying *__JPH_Character_GetCharacterSettings(_Underlying *_this, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            return new(__JPH_Character_GetCharacterSettings(_UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null), is_owning: true);
        }

        /// Generated from method `JPH::Character::GetCosMaxSlopeAngle`.
        public unsafe float GetCosMaxSlopeAngle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetCosMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetCosMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Character_GetCosMaxSlopeAngle(_Underlying *_this);
            return __JPH_Character_GetCosMaxSlopeAngle(_UnderlyingPtr);
        }

        /// Generated from method `JPH::Character::GetUp`.
        public unsafe JPH.Vec3 GetUp()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Character_GetUp(_Underlying *_this);
            return new(__JPH_Character_GetUp(_UnderlyingPtr), is_owning: true);
        }

        /// Check if the normal of the ground surface is too steep to walk on
        /// Generated from method `JPH::Character::IsSlopeTooSteep`.
        public unsafe bool IsSlopeTooSteep(JPH.Const_Vec3 inNormal)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_IsSlopeTooSteep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_IsSlopeTooSteep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Character_IsSlopeTooSteep(_Underlying *_this, JPH.Vec3._Underlying *inNormal);
            return __JPH_Character_IsSlopeTooSteep(_UnderlyingPtr, inNormal._UnderlyingPtr) != 0;
        }

        /// Get the current shape that the character is using.
        /// Generated from method `JPH::Character::GetShape`.
        public unsafe JPH.Const_Shape? GetShape()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_Character_GetShape(_Underlying *_this);
            var __c_ret = __JPH_Character_GetShape(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_Shape(__c_ret, is_owning: false) : null;
        }

        /// Debug function to convert enum values to string
        /// Generated from method `JPH::Character::sToString`.
        public static unsafe byte? SToString(JPH.CharacterBase.EGroundState inState)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_sToString", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_sToString", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte *__JPH_Character_sToString(JPH.CharacterBase.EGroundState inState);
            var __c_ret = __JPH_Character_sToString(inState);
            return __c_ret is not null ? *__c_ret : null;
        }

        /// Current ground state
        /// Generated from method `JPH::Character::GetGroundState`.
        public unsafe JPH.CharacterBase.EGroundState GetGroundState()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetGroundState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetGroundState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterBase.EGroundState __JPH_Character_GetGroundState(_Underlying *_this);
            return __JPH_Character_GetGroundState(_UnderlyingPtr);
        }

        /// Returns true if the player is supported by normal or steep ground
        /// Generated from method `JPH::Character::IsSupported`.
        public unsafe bool IsSupported()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_IsSupported", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_IsSupported", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Character_IsSupported(_Underlying *_this);
            return __JPH_Character_IsSupported(_UnderlyingPtr) != 0;
        }

        /// Get the contact point with the ground
        /// Generated from method `JPH::Character::GetGroundPosition`.
        public unsafe JPH.Vec3 GetGroundPosition()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetGroundPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetGroundPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Character_GetGroundPosition(_Underlying *_this);
            return new(__JPH_Character_GetGroundPosition(_UnderlyingPtr), is_owning: true);
        }

        /// Get the contact normal with the ground
        /// Generated from method `JPH::Character::GetGroundNormal`.
        public unsafe JPH.Vec3 GetGroundNormal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetGroundNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetGroundNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Character_GetGroundNormal(_Underlying *_this);
            return new(__JPH_Character_GetGroundNormal(_UnderlyingPtr), is_owning: true);
        }

        /// Velocity in world space of ground
        /// Generated from method `JPH::Character::GetGroundVelocity`.
        public unsafe JPH.Vec3 GetGroundVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetGroundVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetGroundVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Character_GetGroundVelocity(_Underlying *_this);
            return new(__JPH_Character_GetGroundVelocity(_UnderlyingPtr), is_owning: true);
        }

        /// Material that the character is standing on
        /// Generated from method `JPH::Character::GetGroundMaterial`.
        public unsafe JPH.Const_PhysicsMaterial? GetGroundMaterial()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetGroundMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetGroundMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_PhysicsMaterial._Underlying *__JPH_Character_GetGroundMaterial(_Underlying *_this);
            var __c_ret = __JPH_Character_GetGroundMaterial(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
        }

        /// BodyID of the object the character is standing on. Note may have been removed!
        /// Generated from method `JPH::Character::GetGroundBodyID`.
        public unsafe JPH.BodyID GetGroundBodyID()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetGroundBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetGroundBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID __JPH_Character_GetGroundBodyID(_Underlying *_this);
            return __JPH_Character_GetGroundBodyID(_UnderlyingPtr);
        }

        /// Sub part of the body that we're standing on.
        /// Generated from method `JPH::Character::GetGroundSubShapeID`.
        public unsafe JPH.SubShapeID GetGroundSubShapeID()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetGroundSubShapeID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetGroundSubShapeID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SubShapeID._Underlying *__JPH_Character_GetGroundSubShapeID(_Underlying *_this);
            return new(__JPH_Character_GetGroundSubShapeID(_UnderlyingPtr), is_owning: true);
        }

        /// User data value of the body that we're standing on
        /// Generated from method `JPH::Character::GetGroundUserData`.
        public unsafe UIntPtr GetGroundUserData()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetGroundUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetGroundUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_Character_GetGroundUserData(_Underlying *_this);
            return __JPH_Character_GetGroundUserData(_UnderlyingPtr);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::Character::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_SetEmbedded(_Underlying *_this);
            __JPH_Character_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::Character::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_Character_GetRefCount(_Underlying *_this);
            return __JPH_Character_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::Character::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_AddRef(_Underlying *_this);
            __JPH_Character_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::Character::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_Release(_Underlying *_this);
            __JPH_Character_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::Character::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_Character_sInternalGetRefCountOffset();
            return __JPH_Character_sInternalGetRefCountOffset();
        }
    }

    /// Runtime character object.
    /// This object usually represents the player or a humanoid AI. It uses a single rigid body,
    /// usually with a capsule shape to simulate movement and collision for the character.
    /// The character is a keyframed object, the application controls it by setting the velocity.
    /// Generated from class `JPH::Character`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CharacterBase`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::CharacterBase>`
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class Character : Const_Character
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHCharacterBase(Character self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHCharacterBase._Underlying *__JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase(_Underlying *_this);
            JPH.RefTarget_JPHCharacterBase ret = new(__JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.NonCopyable(Character self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_Character_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_Character_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.CharacterBase(Character self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CharacterBase._Underlying *__JPH_Character_UpcastTo_JPH_CharacterBase(_Underlying *_this);
            JPH.CharacterBase ret = new(__JPH_Character_UpcastTo_JPH_CharacterBase(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Character(JPH.RefTarget_JPHCharacterBase parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Character_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(JPH.RefTarget_JPHCharacterBase._Underlying *_this);
            Character ret = new(__JPH_Character_StaticDowncastFrom_JPH_RefTarget_JPH_CharacterBase(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Character(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Character_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            Character ret = new(__JPH_Character_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Character(JPH.CharacterBase parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_StaticDowncastFrom_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_StaticDowncastFrom_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Character_StaticDowncastFrom_JPH_CharacterBase(JPH.CharacterBase._Underlying *_this);
            Character ret = new(__JPH_Character_StaticDowncastFrom_JPH_CharacterBase(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Character(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// @param inSettings The settings for the character
        /// @param inPosition Initial position for the character
        /// @param inRotation Initial rotation for the character (usually only around Y)
        /// @param inUserData Application specific value
        /// @param inSystem Physics system that this character will be added to later
        /// Generated from constructor `JPH::Character::Character`.
        public unsafe Character(JPH.Const_CharacterSettings? inSettings, JPH.Const_Vec3 inPosition, JPH.Const_Quat inRotation, UIntPtr inUserData, JPH.PhysicsSystem? inSystem) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Character._Underlying *__JPH_Character_Construct(JPH.Const_CharacterSettings._Underlying *inSettings, JPH.Vec3._Underlying *inPosition, JPH.Quat._Underlying *inRotation, UIntPtr inUserData, JPH.PhysicsSystem._Underlying *inSystem);
            _UnderlyingPtr = __JPH_Character_Construct(inSettings is not null ? inSettings._UnderlyingPtr : null, inPosition._UnderlyingPtr, inRotation._UnderlyingPtr, inUserData, inSystem is not null ? inSystem._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_CharacterBase_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_CharacterBase_AddRef(void *_this);
            __JPH_RefTarget_JPH_CharacterBase_AddRef(__JPH_Character_UpcastTo_JPH_RefTarget_JPH_CharacterBase(_UnderlyingPtr));
        }

        /// Add bodies and constraints to the system and optionally activate the bodies
        /// Generated from method `JPH::Character::AddToPhysicsSystem`.
        /// Parameter `inActivationMode` defaults to `EActivation::Activate`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void AddToPhysicsSystem(JPH.EActivation? inActivationMode = null, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_AddToPhysicsSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_AddToPhysicsSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_AddToPhysicsSystem(_Underlying *_this, JPH.EActivation *inActivationMode, byte *inLockBodies);
            JPH.EActivation __deref_inActivationMode = inActivationMode.GetValueOrDefault();
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Character_AddToPhysicsSystem(_UnderlyingPtr, inActivationMode.HasValue ? &__deref_inActivationMode : null, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Remove bodies and constraints from the system
        /// Generated from method `JPH::Character::RemoveFromPhysicsSystem`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void RemoveFromPhysicsSystem(bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_RemoveFromPhysicsSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_RemoveFromPhysicsSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_RemoveFromPhysicsSystem(_Underlying *_this, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Character_RemoveFromPhysicsSystem(_UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Wake up the character
        /// Generated from method `JPH::Character::Activate`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void Activate(bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_Activate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_Activate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_Activate(_Underlying *_this, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Character_Activate(_UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Needs to be called after every PhysicsSystem::Update
        /// @param inMaxSeparationDistance Max distance between the floor and the character to still consider the character standing on the floor
        /// @param inLockBodies If the collision query should use the locking body interface (true) or the non locking body interface (false)
        /// Generated from method `JPH::Character::PostSimulation`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void PostSimulation(float inMaxSeparationDistance, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_PostSimulation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_PostSimulation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_PostSimulation(_Underlying *_this, float inMaxSeparationDistance, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Character_PostSimulation(_UnderlyingPtr, inMaxSeparationDistance, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Control the velocity of the character
        /// Generated from method `JPH::Character::SetLinearAndAngularVelocity`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void SetLinearAndAngularVelocity(JPH.Const_Vec3 inLinearVelocity, JPH.Const_Vec3 inAngularVelocity, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_SetLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_SetLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_SetLinearAndAngularVelocity(_Underlying *_this, JPH.Vec3._Underlying *inLinearVelocity, JPH.Vec3._Underlying *inAngularVelocity, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Character_SetLinearAndAngularVelocity(_UnderlyingPtr, inLinearVelocity._UnderlyingPtr, inAngularVelocity._UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Set the linear velocity of the character (m / s)
        /// Generated from method `JPH::Character::SetLinearVelocity`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void SetLinearVelocity(JPH.Const_Vec3 inLinearVelocity, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_SetLinearVelocity(_Underlying *_this, JPH.Vec3._Underlying *inLinearVelocity, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Character_SetLinearVelocity(_UnderlyingPtr, inLinearVelocity._UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Add world space linear velocity to current velocity (m / s)
        /// Generated from method `JPH::Character::AddLinearVelocity`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void AddLinearVelocity(JPH.Const_Vec3 inLinearVelocity, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_AddLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_AddLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_AddLinearVelocity(_Underlying *_this, JPH.Vec3._Underlying *inLinearVelocity, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Character_AddLinearVelocity(_UnderlyingPtr, inLinearVelocity._UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Add impulse to the center of mass of the character
        /// Generated from method `JPH::Character::AddImpulse`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void AddImpulse(JPH.Const_Vec3 inImpulse, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_AddImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_AddImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_AddImpulse(_Underlying *_this, JPH.Vec3._Underlying *inImpulse, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Character_AddImpulse(_UnderlyingPtr, inImpulse._UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Set the position of the character, optionally activating it.
        /// Generated from method `JPH::Character::SetPosition`.
        /// Parameter `inActivationMode` defaults to `EActivation::Activate`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void SetPosition(JPH.Const_Vec3 inPosition, JPH.EActivation? inActivationMode = null, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_SetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_SetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_SetPosition(_Underlying *_this, JPH.Vec3._Underlying *inPosition, JPH.EActivation *inActivationMode, byte *inLockBodies);
            JPH.EActivation __deref_inActivationMode = inActivationMode.GetValueOrDefault();
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Character_SetPosition(_UnderlyingPtr, inPosition._UnderlyingPtr, inActivationMode.HasValue ? &__deref_inActivationMode : null, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Set the rotation of the character, optionally activating it.
        /// Generated from method `JPH::Character::SetRotation`.
        /// Parameter `inActivationMode` defaults to `EActivation::Activate`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void SetRotation(JPH.Const_Quat inRotation, JPH.EActivation? inActivationMode = null, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_SetRotation(_Underlying *_this, JPH.Quat._Underlying *inRotation, JPH.EActivation *inActivationMode, byte *inLockBodies);
            JPH.EActivation __deref_inActivationMode = inActivationMode.GetValueOrDefault();
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Character_SetRotation(_UnderlyingPtr, inRotation._UnderlyingPtr, inActivationMode.HasValue ? &__deref_inActivationMode : null, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Update the layer of the character
        /// Generated from method `JPH::Character::SetLayer`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void SetLayer(ushort inLayer, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_SetLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_SetLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_SetLayer(_Underlying *_this, ushort inLayer, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Character_SetLayer(_UnderlyingPtr, inLayer, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Switch the shape of the character (e.g. for stance). When inMaxPenetrationDepth is not FLT_MAX, it checks
        /// if the new shape collides before switching shape. Returns true if the switch succeeded.
        /// Generated from method `JPH::Character::SetShape`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe bool SetShape(JPH.Const_Shape? inShape, float inMaxPenetrationDepth, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_SetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_SetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Character_SetShape(_Underlying *_this, JPH.Const_Shape._Underlying *inShape, float inMaxPenetrationDepth, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            return __JPH_Character_SetShape(_UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null, inMaxPenetrationDepth, inLockBodies.HasValue ? &__deref_inLockBodies : null) != 0;
        }

        /// Set the maximum angle of slope that character can still walk on (radians)
        /// Generated from method `JPH::Character::SetMaxSlopeAngle`.
        public unsafe void SetMaxSlopeAngle(float inMaxSlopeAngle)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_SetMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_SetMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_SetMaxSlopeAngle(_Underlying *_this, float inMaxSlopeAngle);
            __JPH_Character_SetMaxSlopeAngle(_UnderlyingPtr, inMaxSlopeAngle);
        }

        /// Set the up vector for the character
        /// Generated from method `JPH::Character::SetUp`.
        public unsafe void SetUp(JPH.Const_Vec3 inUp)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Character_SetUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Character_SetUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Character_SetUp(_Underlying *_this, JPH.Vec3._Underlying *inUp);
            __JPH_Character_SetUp(_UnderlyingPtr, inUp._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `Character` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Character`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Character`/`Const_Character` directly.
    public class _InOptMut_Character
    {
        public Character? Opt;

        public _InOptMut_Character() {}
        public _InOptMut_Character(Character value) {Opt = value;}
        public static implicit operator _InOptMut_Character(Character value) {return new(value);}
    }

    /// This is used for optional parameters of class `Character` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Character`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Character`/`Const_Character` to pass it to the function.
    public class _InOptConst_Character
    {
        public Const_Character? Opt;

        public _InOptConst_Character() {}
        public _InOptConst_Character(Const_Character value) {Opt = value;}
        public static implicit operator _InOptConst_Character(Const_Character value) {return new(value);}
    }
}
