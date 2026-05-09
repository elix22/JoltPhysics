// machine generated, do not edit
public static partial class JPH
{
    /// Contains the structure of a ragdoll
    /// Generated from class `JPH::RagdollSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::RagdollSettings>`
    /// This is the const half of the class.
    public class Const_RagdollSettings : JPH.Object<Const_RagdollSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_RagdollSettings_Release(void *_this);
            __JPH_RefTarget_JPH_RagdollSettings_Release(__JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RagdollSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHRagdollSettings(Const_RagdollSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHRagdollSettings._Underlying *__JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHRagdollSettings ret = new(__JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_RagdollSettings(JPH.Const_RefTarget_JPHRagdollSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_StaticDowncastFrom_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_StaticDowncastFrom_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_RagdollSettings_StaticDowncastFrom_JPH_RefTarget_JPH_RagdollSettings(JPH.Const_RefTarget_JPHRagdollSettings._Underlying *_this);
            Const_RagdollSettings ret = new(__JPH_RagdollSettings_StaticDowncastFrom_JPH_RefTarget_JPH_RagdollSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// For each of the joints, the body and constraint attaching it to its parent body (1-on-1 with mSkeleton.GetJoints())
        public unsafe JPH.Const_Array_JPHRagdollSettingsPart mParts
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Get_mParts", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Get_mParts", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Array_JPHRagdollSettingsPart._Underlying *__JPH_RagdollSettings_Get_mParts(_Underlying *_this);
                JPH.Const_Array_JPHRagdollSettingsPart __ret;
                __ret = new(__JPH_RagdollSettings_Get_mParts(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// A list of constraints that connects two bodies in a ragdoll (for non parent child related constraints)
        public unsafe JPH.Const_Array_JPHRagdollSettingsAdditionalConstraint mAdditionalConstraints
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Get_mAdditionalConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Get_mAdditionalConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Array_JPHRagdollSettingsAdditionalConstraint._Underlying *__JPH_RagdollSettings_Get_mAdditionalConstraints(_Underlying *_this);
                JPH.Const_Array_JPHRagdollSettingsAdditionalConstraint __ret;
                __ret = new(__JPH_RagdollSettings_Get_mAdditionalConstraints(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_RagdollSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RagdollSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RagdollSettings._Underlying *__JPH_RagdollSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RagdollSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_RagdollSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_RagdollSettings_AddRef(__JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::RagdollSettings::RagdollSettings`.
        public unsafe Const_RagdollSettings(JPH._ByValue_RagdollSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RagdollSettings._Underlying *__JPH_RagdollSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RagdollSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RagdollSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_RagdollSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_RagdollSettings_AddRef(__JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RagdollSettings::RagdollSettings`.
        public Const_RagdollSettings(Const_RagdollSettings _other) : this(new _ByValue_RagdollSettings(_other)) {}

        /// Generated from constructor `JPH::RagdollSettings::RagdollSettings`.
        public Const_RagdollSettings(RagdollSettings _other) : this((Const_RagdollSettings)_other) {}

        /// Generated from method `JPH::RagdollSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RagdollSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RagdollSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_RagdollSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_RagdollSettings_size_t(inCount);
        }

        /// Generated from method `JPH::RagdollSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RagdollSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_RagdollSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::RagdollSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RagdollSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_RagdollSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::RagdollSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RagdollSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RagdollSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_RagdollSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_RagdollSettings_size_t(inCount);
        }

        /// Generated from method `JPH::RagdollSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RagdollSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_RagdollSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::RagdollSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RagdollSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_RagdollSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::RagdollSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RagdollSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RagdollSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_RagdollSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_RagdollSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::RagdollSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RagdollSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_RagdollSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::RagdollSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RagdollSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RagdollSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_RagdollSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_RagdollSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::RagdollSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RagdollSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_RagdollSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Create ragdoll instance from these settings
        /// @return Newly created ragdoll or null when out of bodies
        /// Generated from method `JPH::RagdollSettings::CreateRagdoll`.
        public unsafe JPH.Ragdoll? CreateRagdoll(uint inCollisionGroup, ulong inUserData, JPH.PhysicsSystem? inSystem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_CreateRagdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_CreateRagdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Ragdoll._Underlying *__JPH_RagdollSettings_CreateRagdoll(_Underlying *_this, uint inCollisionGroup, ulong inUserData, JPH.PhysicsSystem._Underlying *inSystem);
            var __c_ret = __JPH_RagdollSettings_CreateRagdoll(_UnderlyingPtr, inCollisionGroup, inUserData, inSystem is not null ? inSystem._UnderlyingPtr : null);
            return __c_ret is not null ? new JPH.Ragdoll(__c_ret, is_owning: false) : null;
        }

        /// Access to the skeleton of this ragdoll
        /// Generated from method `JPH::RagdollSettings::GetSkeleton`.
        public unsafe JPH.Const_Skeleton? GetSkeleton()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_GetSkeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_GetSkeleton", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Skeleton._Underlying *__JPH_RagdollSettings_GetSkeleton(_Underlying *_this);
            var __c_ret = __JPH_RagdollSettings_GetSkeleton(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_Skeleton(__c_ret, is_owning: false) : null;
        }

        /// Get table that maps a body index to the constraint index with which it is connected to its parent. -1 if there is no constraint associated with the body.
        /// Note that this will only tell you which constraint connects the body to its parent, it will not look in the additional constraint list.
        /// Generated from method `JPH::RagdollSettings::GetBodyIndexToConstraintIndex`.
        public unsafe JPH.Const_Array_Int GetBodyIndexToConstraintIndex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_GetBodyIndexToConstraintIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_GetBodyIndexToConstraintIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Array_Int._Underlying *__JPH_RagdollSettings_GetBodyIndexToConstraintIndex(_Underlying *_this);
            return new(__JPH_RagdollSettings_GetBodyIndexToConstraintIndex(_UnderlyingPtr), is_owning: false);
        }

        /// Map a single body index to a constraint index
        /// Generated from method `JPH::RagdollSettings::GetConstraintIndexForBodyIndex`.
        public unsafe int GetConstraintIndexForBodyIndex(int inBodyIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_GetConstraintIndexForBodyIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_GetConstraintIndexForBodyIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RagdollSettings_GetConstraintIndexForBodyIndex(_Underlying *_this, int inBodyIndex);
            return __JPH_RagdollSettings_GetConstraintIndexForBodyIndex(_UnderlyingPtr, inBodyIndex);
        }

        /// Table that maps a constraint index (index in mConstraints) to the indices of the bodies that the constraint is connected to (index in mBodyIDs)
        /// Generated from method `JPH::RagdollSettings::GetConstraintIndexToBodyIdxPair`.
        public unsafe JPH.Const_Array_StdPairIntInt GetConstraintIndexToBodyIdxPair()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_GetConstraintIndexToBodyIdxPair", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_GetConstraintIndexToBodyIdxPair", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Array_StdPairIntInt._Underlying *__JPH_RagdollSettings_GetConstraintIndexToBodyIdxPair(_Underlying *_this);
            return new(__JPH_RagdollSettings_GetConstraintIndexToBodyIdxPair(_UnderlyingPtr), is_owning: false);
        }

        /// Map a single constraint index (index in mConstraints) to the indices of the bodies that the constraint is connected to (index in mBodyIDs)
        /// Generated from method `JPH::RagdollSettings::GetBodyIndicesForConstraintIndex`.
        public unsafe JPH.Std.Pair_Int_Int GetBodyIndicesForConstraintIndex(int inConstraintIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_GetBodyIndicesForConstraintIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_GetBodyIndicesForConstraintIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Std.Pair_Int_Int._Underlying *__JPH_RagdollSettings_GetBodyIndicesForConstraintIndex(_Underlying *_this, int inConstraintIndex);
            return new(__JPH_RagdollSettings_GetBodyIndicesForConstraintIndex(_UnderlyingPtr, inConstraintIndex), is_owning: true);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::RagdollSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RagdollSettings_SetEmbedded(_Underlying *_this);
            __JPH_RagdollSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::RagdollSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_RagdollSettings_GetRefCount(_Underlying *_this);
            return __JPH_RagdollSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::RagdollSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RagdollSettings_AddRef(_Underlying *_this);
            __JPH_RagdollSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::RagdollSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RagdollSettings_Release(_Underlying *_this);
            __JPH_RagdollSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::RagdollSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_RagdollSettings_sInternalGetRefCountOffset();
            return __JPH_RagdollSettings_sInternalGetRefCountOffset();
        }

        /// A constraint that connects two bodies in a ragdoll (for non parent child related constraints)
        /// Generated from class `JPH::RagdollSettings::AdditionalConstraint`.
        /// This is the const half of the class.
        public class Const_AdditionalConstraint : JPH.Object<Const_AdditionalConstraint>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RagdollSettings_AdditionalConstraint_Destroy(_Underlying *_this);
                __JPH_RagdollSettings_AdditionalConstraint_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_AdditionalConstraint() {Dispose(false);}

            ///< Indices of the bodies that this constraint connects
            public unsafe ref JPH.ArrayInt2 mBodyIdx
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_Get_mBodyIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_Get_mBodyIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayInt2 *__JPH_RagdollSettings_AdditionalConstraint_Get_mBodyIdx(_Underlying *_this);
                    return ref *(__JPH_RagdollSettings_AdditionalConstraint_Get_mBodyIdx(_UnderlyingPtr));
                }
            }

            internal unsafe Const_AdditionalConstraint(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_AdditionalConstraint() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.RagdollSettings.AdditionalConstraint._Underlying *__JPH_RagdollSettings_AdditionalConstraint_DefaultConstruct();
                _UnderlyingPtr = __JPH_RagdollSettings_AdditionalConstraint_DefaultConstruct();
            }

            /// Generated from constructor `JPH::RagdollSettings::AdditionalConstraint::AdditionalConstraint`.
            public unsafe Const_AdditionalConstraint(JPH.RagdollSettings._ByValue_AdditionalConstraint _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.RagdollSettings.AdditionalConstraint._Underlying *__JPH_RagdollSettings_AdditionalConstraint_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RagdollSettings.AdditionalConstraint._Underlying *_other);
                _UnderlyingPtr = __JPH_RagdollSettings_AdditionalConstraint_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::RagdollSettings::AdditionalConstraint::AdditionalConstraint`.
            public Const_AdditionalConstraint(Const_AdditionalConstraint _other) : this(new _ByValue_AdditionalConstraint(_other)) {}

            /// Generated from constructor `JPH::RagdollSettings::AdditionalConstraint::AdditionalConstraint`.
            public Const_AdditionalConstraint(AdditionalConstraint _other) : this((Const_AdditionalConstraint)_other) {}

            /// Generated from constructor `JPH::RagdollSettings::AdditionalConstraint::AdditionalConstraint`.
            public unsafe Const_AdditionalConstraint(int inBodyIdx1, int inBodyIdx2, JPH.TwoBodyConstraintSettings? inConstraint) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.RagdollSettings.AdditionalConstraint._Underlying *__JPH_RagdollSettings_AdditionalConstraint_Construct(int inBodyIdx1, int inBodyIdx2, JPH.TwoBodyConstraintSettings._Underlying *inConstraint);
                _UnderlyingPtr = __JPH_RagdollSettings_AdditionalConstraint_Construct(inBodyIdx1, inBodyIdx2, inConstraint is not null ? inConstraint._UnderlyingPtr : null);
            }

            /// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RagdollSettings_AdditionalConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RagdollSettings_AdditionalConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_RagdollSettings_AdditionalConstraint_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_RagdollSettings_AdditionalConstraint_size_t(inCount);
            }

            /// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr(void *inPointer);
                __Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr(inPointer);
            }

            /// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RagdollSettings_AdditionalConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RagdollSettings_AdditionalConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_RagdollSettings_AdditionalConstraint_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_RagdollSettings_AdditionalConstraint_size_t(inCount);
            }

            /// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr(inPointer);
            }

            /// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RagdollSettings_AdditionalConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RagdollSettings_AdditionalConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_RagdollSettings_AdditionalConstraint_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_RagdollSettings_AdditionalConstraint_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_RagdollSettings_AdditionalConstraint_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RagdollSettings_AdditionalConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RagdollSettings_AdditionalConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_RagdollSettings_AdditionalConstraint_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_RagdollSettings_AdditionalConstraint_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_RagdollSettings_AdditionalConstraint_void_ptr_void_ptr(inPointer, inPlace);
            }
        }

        /// A constraint that connects two bodies in a ragdoll (for non parent child related constraints)
        /// Generated from class `JPH::RagdollSettings::AdditionalConstraint`.
        /// This is the non-const half of the class.
        public class AdditionalConstraint : Const_AdditionalConstraint
        {
            ///< Indices of the bodies that this constraint connects
            new public unsafe ref JPH.ArrayInt2 mBodyIdx
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_GetMutable_mBodyIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_GetMutable_mBodyIdx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.ArrayInt2 *__JPH_RagdollSettings_AdditionalConstraint_GetMutable_mBodyIdx(_Underlying *_this);
                    return ref *(__JPH_RagdollSettings_AdditionalConstraint_GetMutable_mBodyIdx(_UnderlyingPtr));
                }
            }

            internal unsafe AdditionalConstraint(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe AdditionalConstraint() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.RagdollSettings.AdditionalConstraint._Underlying *__JPH_RagdollSettings_AdditionalConstraint_DefaultConstruct();
                _UnderlyingPtr = __JPH_RagdollSettings_AdditionalConstraint_DefaultConstruct();
            }

            /// Generated from constructor `JPH::RagdollSettings::AdditionalConstraint::AdditionalConstraint`.
            public unsafe AdditionalConstraint(JPH.RagdollSettings._ByValue_AdditionalConstraint _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.RagdollSettings.AdditionalConstraint._Underlying *__JPH_RagdollSettings_AdditionalConstraint_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RagdollSettings.AdditionalConstraint._Underlying *_other);
                _UnderlyingPtr = __JPH_RagdollSettings_AdditionalConstraint_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::RagdollSettings::AdditionalConstraint::AdditionalConstraint`.
            public AdditionalConstraint(Const_AdditionalConstraint _other) : this(new _ByValue_AdditionalConstraint(_other)) {}

            /// Generated from constructor `JPH::RagdollSettings::AdditionalConstraint::AdditionalConstraint`.
            public AdditionalConstraint(AdditionalConstraint _other) : this((Const_AdditionalConstraint)_other) {}

            /// Generated from constructor `JPH::RagdollSettings::AdditionalConstraint::AdditionalConstraint`.
            public unsafe AdditionalConstraint(int inBodyIdx1, int inBodyIdx2, JPH.TwoBodyConstraintSettings? inConstraint) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.RagdollSettings.AdditionalConstraint._Underlying *__JPH_RagdollSettings_AdditionalConstraint_Construct(int inBodyIdx1, int inBodyIdx2, JPH.TwoBodyConstraintSettings._Underlying *inConstraint);
                _UnderlyingPtr = __JPH_RagdollSettings_AdditionalConstraint_Construct(inBodyIdx1, inBodyIdx2, inConstraint is not null ? inConstraint._UnderlyingPtr : null);
            }

            /// Generated from method `JPH::RagdollSettings::AdditionalConstraint::operator=`.
            public unsafe JPH.RagdollSettings.AdditionalConstraint Assign(JPH.RagdollSettings._ByValue_AdditionalConstraint _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_AdditionalConstraint_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.RagdollSettings.AdditionalConstraint._Underlying *__JPH_RagdollSettings_AdditionalConstraint_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RagdollSettings.AdditionalConstraint._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_RagdollSettings_AdditionalConstraint_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }
        }

        /// This is used as a function parameter when the underlying function receives `AdditionalConstraint` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `AdditionalConstraint`/`Const_AdditionalConstraint` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_AdditionalConstraint
        {
            #pragma warning disable CS0649
            internal readonly Const_AdditionalConstraint? Value;
            #pragma warning restore CS0649
            internal readonly JPH._PassBy PassByMode;
            public _ByValue_AdditionalConstraint() {PassByMode = JPH._PassBy.default_construct;}
            public _ByValue_AdditionalConstraint(Const_AdditionalConstraint new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
            public static implicit operator _ByValue_AdditionalConstraint(Const_AdditionalConstraint arg) {return new(arg);}
            public _ByValue_AdditionalConstraint(JPH._Moved<AdditionalConstraint> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
            public static implicit operator _ByValue_AdditionalConstraint(JPH._Moved<AdditionalConstraint> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `AdditionalConstraint` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_AdditionalConstraint`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `AdditionalConstraint`/`Const_AdditionalConstraint` directly.
        public class _InOptMut_AdditionalConstraint
        {
            public AdditionalConstraint? Opt;

            public _InOptMut_AdditionalConstraint() {}
            public _InOptMut_AdditionalConstraint(AdditionalConstraint value) {Opt = value;}
            public static implicit operator _InOptMut_AdditionalConstraint(AdditionalConstraint value) {return new(value);}
        }

        /// This is used for optional parameters of class `AdditionalConstraint` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_AdditionalConstraint`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `AdditionalConstraint`/`Const_AdditionalConstraint` to pass it to the function.
        public class _InOptConst_AdditionalConstraint
        {
            public Const_AdditionalConstraint? Opt;

            public _InOptConst_AdditionalConstraint() {}
            public _InOptConst_AdditionalConstraint(Const_AdditionalConstraint value) {Opt = value;}
            public static implicit operator _InOptConst_AdditionalConstraint(Const_AdditionalConstraint value) {return new(value);}
        }

        /// A single rigid body sub part of the ragdoll
        /// Generated from class `JPH::RagdollSettings::Part`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::BodyCreationSettings`
        /// This is the const half of the class.
        public class Const_Part : JPH.Object<Const_Part>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RagdollSettings_Part_Destroy(_Underlying *_this);
                __JPH_RagdollSettings_Part_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Part() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator JPH.Const_BodyCreationSettings(Const_Part self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_UpcastTo_JPH_BodyCreationSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_UpcastTo_JPH_BodyCreationSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_BodyCreationSettings._Underlying *__JPH_RagdollSettings_Part_UpcastTo_JPH_BodyCreationSettings(_Underlying *_this);
                JPH.Const_BodyCreationSettings ret = new(__JPH_RagdollSettings_Part_UpcastTo_JPH_BodyCreationSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_Part(JPH.Const_BodyCreationSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_StaticDowncastFrom_JPH_BodyCreationSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_StaticDowncastFrom_JPH_BodyCreationSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_RagdollSettings_Part_StaticDowncastFrom_JPH_BodyCreationSettings(JPH.Const_BodyCreationSettings._Underlying *_this);
                Const_Part ret = new(__JPH_RagdollSettings_Part_StaticDowncastFrom_JPH_BodyCreationSettings(parent._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            ///< Position of the body (not of the center of mass)
            public unsafe JPH.Const_Vec3 mPosition
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Vec3._Underlying *__JPH_RagdollSettings_Part_Get_mPosition(_Underlying *_this);
                    JPH.Const_Vec3 __ret;
                    __ret = new(__JPH_RagdollSettings_Part_Get_mPosition(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Rotation of the body
            public unsafe JPH.Const_Quat mRotation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Quat._Underlying *__JPH_RagdollSettings_Part_Get_mRotation(_Underlying *_this);
                    JPH.Const_Quat __ret;
                    __ret = new(__JPH_RagdollSettings_Part_Get_mRotation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< World space linear velocity of the center of mass (m/s)
            public unsafe JPH.Const_Vec3 mLinearVelocity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Vec3._Underlying *__JPH_RagdollSettings_Part_Get_mLinearVelocity(_Underlying *_this);
                    JPH.Const_Vec3 __ret;
                    __ret = new(__JPH_RagdollSettings_Part_Get_mLinearVelocity(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< World space angular velocity (rad/s)
            public unsafe JPH.Const_Vec3 mAngularVelocity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Vec3._Underlying *__JPH_RagdollSettings_Part_Get_mAngularVelocity(_Underlying *_this);
                    JPH.Const_Vec3 __ret;
                    __ret = new(__JPH_RagdollSettings_Part_Get_mAngularVelocity(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            /// User data value (can be used by application)
            public unsafe ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_RagdollSettings_Part_Get_mUserData(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mUserData(_UnderlyingPtr);
                }
            }

            ///< The collision layer this body belongs to (determines if two objects can collide)
            public unsafe ushort mObjectLayer
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ushort *__JPH_RagdollSettings_Part_Get_mObjectLayer(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mObjectLayer(_UnderlyingPtr);
                }
            }

            ///< The collision group this body belongs to (determines if two objects can collide)
            public unsafe JPH.Const_CollisionGroup mCollisionGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_CollisionGroup._Underlying *__JPH_RagdollSettings_Part_Get_mCollisionGroup(_Underlying *_this);
                    JPH.Const_CollisionGroup __ret;
                    __ret = new(__JPH_RagdollSettings_Part_Get_mCollisionGroup(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Motion type, determines if the object is static, dynamic or kinematic
            public unsafe JPH.EMotionType mMotionType
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mMotionType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mMotionType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.EMotionType *__JPH_RagdollSettings_Part_Get_mMotionType(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mMotionType(_UnderlyingPtr);
                }
            }

            ///< When this body is created as static, this setting tells the system to create a MotionProperties object so that the object can be switched to kinematic or dynamic
            public unsafe bool mAllowDynamicOrKinematic
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mAllowDynamicOrKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mAllowDynamicOrKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_RagdollSettings_Part_Get_mAllowDynamicOrKinematic(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mAllowDynamicOrKinematic(_UnderlyingPtr);
                }
            }

            ///< If this body is a sensor. A sensor will receive collision callbacks, but will not cause any collision responses and can be used as a trigger volume. See description at Body::SetIsSensor.
            public unsafe bool mIsSensor
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_RagdollSettings_Part_Get_mIsSensor(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mIsSensor(_UnderlyingPtr);
                }
            }

            ///< If kinematic objects can generate contact points against other kinematic or static objects. See description at Body::SetCollideKinematicVsNonDynamic.
            public unsafe bool mCollideKinematicVsNonDynamic
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mCollideKinematicVsNonDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mCollideKinematicVsNonDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_RagdollSettings_Part_Get_mCollideKinematicVsNonDynamic(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mCollideKinematicVsNonDynamic(_UnderlyingPtr);
                }
            }

            ///< If this body should use manifold reduction (see description at Body::SetUseManifoldReduction)
            public unsafe bool mUseManifoldReduction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_RagdollSettings_Part_Get_mUseManifoldReduction(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mUseManifoldReduction(_UnderlyingPtr);
                }
            }

            ///< Set to indicate that the gyroscopic force should be applied to this body (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
            public unsafe bool mApplyGyroscopicForce
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mApplyGyroscopicForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mApplyGyroscopicForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_RagdollSettings_Part_Get_mApplyGyroscopicForce(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mApplyGyroscopicForce(_UnderlyingPtr);
                }
            }

            ///< Motion quality, or how well it detects collisions when it has a high velocity
            public unsafe JPH.EMotionQuality mMotionQuality
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.EMotionQuality *__JPH_RagdollSettings_Part_Get_mMotionQuality(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mMotionQuality(_UnderlyingPtr);
                }
            }

            ///< Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
            public unsafe bool mEnhancedInternalEdgeRemoval
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_RagdollSettings_Part_Get_mEnhancedInternalEdgeRemoval(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mEnhancedInternalEdgeRemoval(_UnderlyingPtr);
                }
            }

            ///< If this body can go to sleep or not
            public unsafe bool mAllowSleeping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_RagdollSettings_Part_Get_mAllowSleeping(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mAllowSleeping(_UnderlyingPtr);
                }
            }

            ///< Friction of the body (dimensionless number, usually between 0 and 1, 0 = no friction, 1 = friction force equals force that presses the two bodies together). Note that bodies can have negative friction but the combined friction (see PhysicsSystem::SetCombineFriction) should never go below zero.
            public unsafe float mFriction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_Get_mFriction(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mFriction(_UnderlyingPtr);
                }
            }

            ///< Restitution of body (dimensionless number, usually between 0 and 1, 0 = completely inelastic collision response, 1 = completely elastic collision response). Note that bodies can have negative restitution but the combined restitution (see PhysicsSystem::SetCombineRestitution) should never go below zero.
            public unsafe float mRestitution
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_Get_mRestitution(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mRestitution(_UnderlyingPtr);
                }
            }

            ///< Linear damping: dv/dt = -c * v. c. Value should be zero or positive and is usually close to 0.
            public unsafe float mLinearDamping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_Get_mLinearDamping(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mLinearDamping(_UnderlyingPtr);
                }
            }

            ///< Angular damping: dw/dt = -c * w. c. Value should be zero or positive and is usually close to 0.
            public unsafe float mAngularDamping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_Get_mAngularDamping(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mAngularDamping(_UnderlyingPtr);
                }
            }

            ///< Maximum linear velocity that this body can reach (m/s)
            public unsafe float mMaxLinearVelocity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_Get_mMaxLinearVelocity(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mMaxLinearVelocity(_UnderlyingPtr);
                }
            }

            ///< Maximum angular velocity that this body can reach (rad/s)
            public unsafe float mMaxAngularVelocity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_Get_mMaxAngularVelocity(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mMaxAngularVelocity(_UnderlyingPtr);
                }
            }

            ///< Value to multiply gravity with for this body
            public unsafe float mGravityFactor
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_Get_mGravityFactor(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mGravityFactor(_UnderlyingPtr);
                }
            }

            ///< Used only when this body is dynamic and colliding. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public unsafe uint mNumVelocityStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_RagdollSettings_Part_Get_mNumVelocityStepsOverride(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mNumVelocityStepsOverride(_UnderlyingPtr);
                }
            }

            ///< Used only when this body is dynamic and colliding. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public unsafe uint mNumPositionStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_RagdollSettings_Part_Get_mNumPositionStepsOverride(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mNumPositionStepsOverride(_UnderlyingPtr);
                }
            }

            ///< When calculating the inertia (not when it is provided) the calculated inertia will be multiplied by this value
            public unsafe float mInertiaMultiplier
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mInertiaMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_Get_mInertiaMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_Get_mInertiaMultiplier(_Underlying *_this);
                    return *__JPH_RagdollSettings_Part_Get_mInertiaMultiplier(_UnderlyingPtr);
                }
            }

            internal unsafe Const_Part(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Part() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.RagdollSettings.Part._Underlying *__JPH_RagdollSettings_Part_DefaultConstruct();
                _UnderlyingPtr = __JPH_RagdollSettings_Part_DefaultConstruct();
            }

            /// Generated from constructor `JPH::RagdollSettings::Part::Part`.
            public unsafe Const_Part(JPH.RagdollSettings._ByValue_Part _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.RagdollSettings.Part._Underlying *__JPH_RagdollSettings_Part_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RagdollSettings.Part._Underlying *_other);
                _UnderlyingPtr = __JPH_RagdollSettings_Part_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::RagdollSettings::Part::Part`.
            public Const_Part(Const_Part _other) : this(new _ByValue_Part(_other)) {}

            /// Generated from constructor `JPH::RagdollSettings::Part::Part`.
            public Const_Part(Part _other) : this((Const_Part)_other) {}

            /// Generated from method `JPH::RagdollSettings::Part::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RagdollSettings_Part_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RagdollSettings_Part_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_RagdollSettings_Part_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_RagdollSettings_Part_size_t(inCount);
            }

            /// Generated from method `JPH::RagdollSettings::Part::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_Part_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_Part_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_RagdollSettings_Part_void_ptr(void *inPointer);
                __Jolt_delete_JPH_RagdollSettings_Part_void_ptr(inPointer);
            }

            /// Generated from method `JPH::RagdollSettings::Part::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_Part_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_Part_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_RagdollSettings_Part_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_RagdollSettings_Part_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::RagdollSettings::Part::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RagdollSettings_Part_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RagdollSettings_Part_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_RagdollSettings_Part_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_RagdollSettings_Part_size_t(inCount);
            }

            /// Generated from method `JPH::RagdollSettings::Part::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr(inPointer);
            }

            /// Generated from method `JPH::RagdollSettings::Part::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::RagdollSettings::Part::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RagdollSettings_Part_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RagdollSettings_Part_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_RagdollSettings_Part_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_RagdollSettings_Part_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::RagdollSettings::Part::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_Part_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RagdollSettings_Part_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_RagdollSettings_Part_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_RagdollSettings_Part_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::RagdollSettings::Part::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RagdollSettings_Part_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RagdollSettings_Part_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_RagdollSettings_Part_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_RagdollSettings_Part_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::RagdollSettings::Part::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_RagdollSettings_Part_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Access to the shape settings object. This contains serializable (non-runtime optimized) information about the Shape.
            /// Generated from method `JPH::RagdollSettings::Part::GetShapeSettings`.
            public unsafe JPH.Const_ShapeSettings? GetShapeSettings()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_ShapeSettings._Underlying *__JPH_RagdollSettings_Part_GetShapeSettings(_Underlying *_this);
                var __c_ret = __JPH_RagdollSettings_Part_GetShapeSettings(_UnderlyingPtr);
                return __c_ret is not null ? new JPH.Const_ShapeSettings(__c_ret, is_owning: false) : null;
            }

            /// Access to the run-time shape object. Will convert from ShapeSettings object if needed.
            /// Generated from method `JPH::RagdollSettings::Part::GetShape`.
            public unsafe JPH.Const_Shape? GetShape()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Shape._Underlying *__JPH_RagdollSettings_Part_GetShape(_Underlying *_this);
                var __c_ret = __JPH_RagdollSettings_Part_GetShape(_UnderlyingPtr);
                return __c_ret is not null ? new JPH.Const_Shape(__c_ret, is_owning: false) : null;
            }

            /// Check if the mass properties of this body will be calculated (only relevant for kinematic or dynamic objects that need a MotionProperties object)
            /// Generated from method `JPH::RagdollSettings::Part::HasMassProperties`.
            public unsafe bool HasMassProperties()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_HasMassProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_HasMassProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_RagdollSettings_Part_HasMassProperties(_Underlying *_this);
                return __JPH_RagdollSettings_Part_HasMassProperties(_UnderlyingPtr) != 0;
            }
        }

        /// A single rigid body sub part of the ragdoll
        /// Generated from class `JPH::RagdollSettings::Part`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::BodyCreationSettings`
        /// This is the non-const half of the class.
        public class Part : Const_Part
        {
            // Upcasts:
            public static unsafe implicit operator JPH.BodyCreationSettings(Part self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_UpcastTo_JPH_BodyCreationSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_UpcastTo_JPH_BodyCreationSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyCreationSettings._Underlying *__JPH_RagdollSettings_Part_UpcastTo_JPH_BodyCreationSettings(_Underlying *_this);
                JPH.BodyCreationSettings ret = new(__JPH_RagdollSettings_Part_UpcastTo_JPH_BodyCreationSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator JPH.Const_BodyCreationSettings(Part self)
                => (JPH.Const_BodyCreationSettings)(JPH.RagdollSettings.Const_Part)self;

            // Downcasts:
            public static unsafe explicit operator Part(JPH.BodyCreationSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_StaticDowncastFrom_JPH_BodyCreationSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_StaticDowncastFrom_JPH_BodyCreationSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_RagdollSettings_Part_StaticDowncastFrom_JPH_BodyCreationSettings(JPH.BodyCreationSettings._Underlying *_this);
                Part ret = new(__JPH_RagdollSettings_Part_StaticDowncastFrom_JPH_BodyCreationSettings(parent._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            ///< Position of the body (not of the center of mass)
            public new unsafe JPH.Vec3 mPosition
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Vec3._Underlying *__JPH_RagdollSettings_Part_GetMutable_mPosition(_Underlying *_this);
                    JPH.Vec3 __ret;
                    __ret = new(__JPH_RagdollSettings_Part_GetMutable_mPosition(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Rotation of the body
            public new unsafe JPH.Quat mRotation
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Quat._Underlying *__JPH_RagdollSettings_Part_GetMutable_mRotation(_Underlying *_this);
                    JPH.Quat __ret;
                    __ret = new(__JPH_RagdollSettings_Part_GetMutable_mRotation(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< World space linear velocity of the center of mass (m/s)
            public new unsafe JPH.Vec3 mLinearVelocity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Vec3._Underlying *__JPH_RagdollSettings_Part_GetMutable_mLinearVelocity(_Underlying *_this);
                    JPH.Vec3 __ret;
                    __ret = new(__JPH_RagdollSettings_Part_GetMutable_mLinearVelocity(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< World space angular velocity (rad/s)
            public new unsafe JPH.Vec3 mAngularVelocity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Vec3._Underlying *__JPH_RagdollSettings_Part_GetMutable_mAngularVelocity(_Underlying *_this);
                    JPH.Vec3 __ret;
                    __ret = new(__JPH_RagdollSettings_Part_GetMutable_mAngularVelocity(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            /// User data value (can be used by application)
            public new unsafe ref ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_RagdollSettings_Part_GetMutable_mUserData(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mUserData(_UnderlyingPtr);
                }
            }

            ///< The collision layer this body belongs to (determines if two objects can collide)
            public new unsafe ref ushort mObjectLayer
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ushort *__JPH_RagdollSettings_Part_GetMutable_mObjectLayer(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mObjectLayer(_UnderlyingPtr);
                }
            }

            ///< The collision group this body belongs to (determines if two objects can collide)
            public new unsafe JPH.CollisionGroup mCollisionGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.CollisionGroup._Underlying *__JPH_RagdollSettings_Part_GetMutable_mCollisionGroup(_Underlying *_this);
                    JPH.CollisionGroup __ret;
                    __ret = new(__JPH_RagdollSettings_Part_GetMutable_mCollisionGroup(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Motion type, determines if the object is static, dynamic or kinematic
            public new unsafe ref JPH.EMotionType mMotionType
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mMotionType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mMotionType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.EMotionType *__JPH_RagdollSettings_Part_GetMutable_mMotionType(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mMotionType(_UnderlyingPtr);
                }
            }

            ///< When this body is created as static, this setting tells the system to create a MotionProperties object so that the object can be switched to kinematic or dynamic
            public new unsafe ref bool mAllowDynamicOrKinematic
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mAllowDynamicOrKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mAllowDynamicOrKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_RagdollSettings_Part_GetMutable_mAllowDynamicOrKinematic(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mAllowDynamicOrKinematic(_UnderlyingPtr);
                }
            }

            ///< If this body is a sensor. A sensor will receive collision callbacks, but will not cause any collision responses and can be used as a trigger volume. See description at Body::SetIsSensor.
            public new unsafe ref bool mIsSensor
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_RagdollSettings_Part_GetMutable_mIsSensor(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mIsSensor(_UnderlyingPtr);
                }
            }

            ///< If kinematic objects can generate contact points against other kinematic or static objects. See description at Body::SetCollideKinematicVsNonDynamic.
            public new unsafe ref bool mCollideKinematicVsNonDynamic
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mCollideKinematicVsNonDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mCollideKinematicVsNonDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_RagdollSettings_Part_GetMutable_mCollideKinematicVsNonDynamic(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mCollideKinematicVsNonDynamic(_UnderlyingPtr);
                }
            }

            ///< If this body should use manifold reduction (see description at Body::SetUseManifoldReduction)
            public new unsafe ref bool mUseManifoldReduction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_RagdollSettings_Part_GetMutable_mUseManifoldReduction(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mUseManifoldReduction(_UnderlyingPtr);
                }
            }

            ///< Set to indicate that the gyroscopic force should be applied to this body (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
            public new unsafe ref bool mApplyGyroscopicForce
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mApplyGyroscopicForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mApplyGyroscopicForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_RagdollSettings_Part_GetMutable_mApplyGyroscopicForce(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mApplyGyroscopicForce(_UnderlyingPtr);
                }
            }

            ///< Motion quality, or how well it detects collisions when it has a high velocity
            public new unsafe ref JPH.EMotionQuality mMotionQuality
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.EMotionQuality *__JPH_RagdollSettings_Part_GetMutable_mMotionQuality(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mMotionQuality(_UnderlyingPtr);
                }
            }

            ///< Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
            public new unsafe ref bool mEnhancedInternalEdgeRemoval
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_RagdollSettings_Part_GetMutable_mEnhancedInternalEdgeRemoval(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mEnhancedInternalEdgeRemoval(_UnderlyingPtr);
                }
            }

            ///< If this body can go to sleep or not
            public new unsafe ref bool mAllowSleeping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_RagdollSettings_Part_GetMutable_mAllowSleeping(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mAllowSleeping(_UnderlyingPtr);
                }
            }

            ///< Friction of the body (dimensionless number, usually between 0 and 1, 0 = no friction, 1 = friction force equals force that presses the two bodies together). Note that bodies can have negative friction but the combined friction (see PhysicsSystem::SetCombineFriction) should never go below zero.
            public new unsafe ref float mFriction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_GetMutable_mFriction(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mFriction(_UnderlyingPtr);
                }
            }

            ///< Restitution of body (dimensionless number, usually between 0 and 1, 0 = completely inelastic collision response, 1 = completely elastic collision response). Note that bodies can have negative restitution but the combined restitution (see PhysicsSystem::SetCombineRestitution) should never go below zero.
            public new unsafe ref float mRestitution
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_GetMutable_mRestitution(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mRestitution(_UnderlyingPtr);
                }
            }

            ///< Linear damping: dv/dt = -c * v. c. Value should be zero or positive and is usually close to 0.
            public new unsafe ref float mLinearDamping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_GetMutable_mLinearDamping(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mLinearDamping(_UnderlyingPtr);
                }
            }

            ///< Angular damping: dw/dt = -c * w. c. Value should be zero or positive and is usually close to 0.
            public new unsafe ref float mAngularDamping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_GetMutable_mAngularDamping(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mAngularDamping(_UnderlyingPtr);
                }
            }

            ///< Maximum linear velocity that this body can reach (m/s)
            public new unsafe ref float mMaxLinearVelocity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_GetMutable_mMaxLinearVelocity(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mMaxLinearVelocity(_UnderlyingPtr);
                }
            }

            ///< Maximum angular velocity that this body can reach (rad/s)
            public new unsafe ref float mMaxAngularVelocity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_GetMutable_mMaxAngularVelocity(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mMaxAngularVelocity(_UnderlyingPtr);
                }
            }

            ///< Value to multiply gravity with for this body
            public new unsafe ref float mGravityFactor
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_GetMutable_mGravityFactor(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mGravityFactor(_UnderlyingPtr);
                }
            }

            ///< Used only when this body is dynamic and colliding. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public new unsafe ref uint mNumVelocityStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_RagdollSettings_Part_GetMutable_mNumVelocityStepsOverride(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mNumVelocityStepsOverride(_UnderlyingPtr);
                }
            }

            ///< Used only when this body is dynamic and colliding. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public new unsafe ref uint mNumPositionStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_RagdollSettings_Part_GetMutable_mNumPositionStepsOverride(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mNumPositionStepsOverride(_UnderlyingPtr);
                }
            }

            ///< When calculating the inertia (not when it is provided) the calculated inertia will be multiplied by this value
            public new unsafe ref float mInertiaMultiplier
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mInertiaMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_GetMutable_mInertiaMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_RagdollSettings_Part_GetMutable_mInertiaMultiplier(_Underlying *_this);
                    return ref *__JPH_RagdollSettings_Part_GetMutable_mInertiaMultiplier(_UnderlyingPtr);
                }
            }

            internal unsafe Part(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Part() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.RagdollSettings.Part._Underlying *__JPH_RagdollSettings_Part_DefaultConstruct();
                _UnderlyingPtr = __JPH_RagdollSettings_Part_DefaultConstruct();
            }

            /// Generated from constructor `JPH::RagdollSettings::Part::Part`.
            public unsafe Part(JPH.RagdollSettings._ByValue_Part _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.RagdollSettings.Part._Underlying *__JPH_RagdollSettings_Part_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RagdollSettings.Part._Underlying *_other);
                _UnderlyingPtr = __JPH_RagdollSettings_Part_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::RagdollSettings::Part::Part`.
            public Part(Const_Part _other) : this(new _ByValue_Part(_other)) {}

            /// Generated from constructor `JPH::RagdollSettings::Part::Part`.
            public Part(Part _other) : this((Const_Part)_other) {}

            /// Generated from method `JPH::RagdollSettings::Part::operator=`.
            public unsafe JPH.RagdollSettings.Part Assign(JPH.RagdollSettings._ByValue_Part _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.RagdollSettings.Part._Underlying *__JPH_RagdollSettings_Part_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RagdollSettings.Part._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_RagdollSettings_Part_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }

            /// Generated from method `JPH::RagdollSettings::Part::SetShapeSettings`.
            public unsafe void SetShapeSettings(JPH.Const_ShapeSettings? inShape)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_SetShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_SetShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RagdollSettings_Part_SetShapeSettings(_Underlying *_this, JPH.Const_ShapeSettings._Underlying *inShape);
                __JPH_RagdollSettings_Part_SetShapeSettings(_UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null);
            }

            /// Generated from method `JPH::RagdollSettings::Part::SetShape`.
            public unsafe void SetShape(JPH.Const_Shape? inShape)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Part_SetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Part_SetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RagdollSettings_Part_SetShape(_Underlying *_this, JPH.Const_Shape._Underlying *inShape);
                __JPH_RagdollSettings_Part_SetShape(_UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null);
            }
        }

        /// This is used as a function parameter when the underlying function receives `Part` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `Part`/`Const_Part` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_Part
        {
            #pragma warning disable CS0649
            internal readonly Const_Part? Value;
            #pragma warning restore CS0649
            internal readonly JPH._PassBy PassByMode;
            public _ByValue_Part() {PassByMode = JPH._PassBy.default_construct;}
            public _ByValue_Part(Const_Part new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
            public static implicit operator _ByValue_Part(Const_Part arg) {return new(arg);}
            public _ByValue_Part(JPH._Moved<Part> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
            public static implicit operator _ByValue_Part(JPH._Moved<Part> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `Part` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Part`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Part`/`Const_Part` directly.
        public class _InOptMut_Part
        {
            public Part? Opt;

            public _InOptMut_Part() {}
            public _InOptMut_Part(Part value) {Opt = value;}
            public static implicit operator _InOptMut_Part(Part value) {return new(value);}
        }

        /// This is used for optional parameters of class `Part` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Part`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Part`/`Const_Part` to pass it to the function.
        public class _InOptConst_Part
        {
            public Const_Part? Opt;

            public _InOptConst_Part() {}
            public _InOptConst_Part(Const_Part value) {Opt = value;}
            public static implicit operator _InOptConst_Part(Const_Part value) {return new(value);}
        }
    }

    /// Contains the structure of a ragdoll
    /// Generated from class `JPH::RagdollSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::RagdollSettings>`
    /// This is the non-const half of the class.
    public class RagdollSettings : Const_RagdollSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHRagdollSettings(RagdollSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHRagdollSettings._Underlying *__JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(_Underlying *_this);
            JPH.RefTarget_JPHRagdollSettings ret = new(__JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHRagdollSettings(RagdollSettings self)
            => (JPH.Const_RefTarget_JPHRagdollSettings)(JPH.Const_RagdollSettings)self;

        // Downcasts:
        public static unsafe explicit operator RagdollSettings(JPH.RefTarget_JPHRagdollSettings parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_StaticDowncastFrom_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_StaticDowncastFrom_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_RagdollSettings_StaticDowncastFrom_JPH_RefTarget_JPH_RagdollSettings(JPH.RefTarget_JPHRagdollSettings._Underlying *_this);
            RagdollSettings ret = new(__JPH_RagdollSettings_StaticDowncastFrom_JPH_RefTarget_JPH_RagdollSettings(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// For each of the joints, the body and constraint attaching it to its parent body (1-on-1 with mSkeleton.GetJoints())
        public new unsafe JPH.Array_JPHRagdollSettingsPart mParts
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_GetMutable_mParts", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_GetMutable_mParts", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Array_JPHRagdollSettingsPart._Underlying *__JPH_RagdollSettings_GetMutable_mParts(_Underlying *_this);
                JPH.Array_JPHRagdollSettingsPart __ret;
                __ret = new(__JPH_RagdollSettings_GetMutable_mParts(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// A list of constraints that connects two bodies in a ragdoll (for non parent child related constraints)
        public new unsafe JPH.Array_JPHRagdollSettingsAdditionalConstraint mAdditionalConstraints
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_GetMutable_mAdditionalConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_GetMutable_mAdditionalConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Array_JPHRagdollSettingsAdditionalConstraint._Underlying *__JPH_RagdollSettings_GetMutable_mAdditionalConstraints(_Underlying *_this);
                JPH.Array_JPHRagdollSettingsAdditionalConstraint __ret;
                __ret = new(__JPH_RagdollSettings_GetMutable_mAdditionalConstraints(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe RagdollSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RagdollSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RagdollSettings._Underlying *__JPH_RagdollSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RagdollSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_RagdollSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_RagdollSettings_AddRef(__JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::RagdollSettings::RagdollSettings`.
        public unsafe RagdollSettings(JPH._ByValue_RagdollSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RagdollSettings._Underlying *__JPH_RagdollSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.RagdollSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RagdollSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_RagdollSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_RagdollSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_RagdollSettings_AddRef(__JPH_RagdollSettings_UpcastTo_JPH_RefTarget_JPH_RagdollSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::RagdollSettings::RagdollSettings`.
        public RagdollSettings(Const_RagdollSettings _other) : this(new _ByValue_RagdollSettings(_other)) {}

        /// Generated from constructor `JPH::RagdollSettings::RagdollSettings`.
        public RagdollSettings(RagdollSettings _other) : this((Const_RagdollSettings)_other) {}

        /// Generated from method `JPH::RagdollSettings::operator=`.
        public unsafe JPH.RagdollSettings Assign(JPH._ByValue_RagdollSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RagdollSettings._Underlying *__JPH_RagdollSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.RagdollSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_RagdollSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Stabilize the constraints of the ragdoll
        /// @return True on success, false on failure.
        /// Generated from method `JPH::RagdollSettings::Stabilize`.
        public unsafe bool Stabilize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_Stabilize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_Stabilize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_RagdollSettings_Stabilize(_Underlying *_this);
            return __JPH_RagdollSettings_Stabilize(_UnderlyingPtr) != 0;
        }

        /// Initializes the constraint priorities so that constraints near the leaves of the ragdoll have a lower priority
        /// than constraints near the root of the ragdoll.
        /// @param inBasePriority The lowest priority that will be used in the ragdoll.
        /// Generated from method `JPH::RagdollSettings::CalculateConstraintPriorities`.
        /// Parameter `inBasePriority` defaults to `0`.
        public unsafe void CalculateConstraintPriorities(uint? inBasePriority = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_CalculateConstraintPriorities", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_CalculateConstraintPriorities", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RagdollSettings_CalculateConstraintPriorities(_Underlying *_this, uint *inBasePriority);
            uint __deref_inBasePriority = inBasePriority.GetValueOrDefault();
            __JPH_RagdollSettings_CalculateConstraintPriorities(_UnderlyingPtr, inBasePriority.HasValue ? &__deref_inBasePriority : null);
        }

        /// After the ragdoll has been fully configured, call this function to automatically create and add a GroupFilterTable collision filter to all bodies
        /// and configure them so that parent and children don't collide.
        ///
        /// This will:
        /// - Create a GroupFilterTable and assign it to all of the bodies in a ragdoll.
        /// - Each body in your ragdoll will get a SubGroupID that is equal to the joint index in the Skeleton that it is attached to.
        /// - Loop over all joints in the Skeleton and call GroupFilterTable::DisableCollision(joint index, parent joint index).
        /// - When a pose is provided through inJointMatrices the function will detect collisions between joints
        /// (they must be separated by more than inMinSeparationDistance to be treated as not colliding) and automatically disable collisions.
        ///
        /// When you create an instance using Ragdoll::CreateRagdoll pass in a unique GroupID for each ragdoll (e.g. a simple counter), note that this number
        /// should be unique throughout the PhysicsSystem, so if you have different types of ragdolls they should not share the same GroupID.
        /// Generated from method `JPH::RagdollSettings::DisableParentChildCollisions`.
        /// Parameter `inMinSeparationDistance` defaults to `0.0f`.
        public unsafe void DisableParentChildCollisions(JPH.Const_Mat44? inJointMatrices = null, float? inMinSeparationDistance = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_DisableParentChildCollisions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_DisableParentChildCollisions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RagdollSettings_DisableParentChildCollisions(_Underlying *_this, JPH.Const_Mat44._Underlying *inJointMatrices, float *inMinSeparationDistance);
            float __deref_inMinSeparationDistance = inMinSeparationDistance.GetValueOrDefault();
            __JPH_RagdollSettings_DisableParentChildCollisions(_UnderlyingPtr, inJointMatrices is not null ? inJointMatrices._UnderlyingPtr : null, inMinSeparationDistance.HasValue ? &__deref_inMinSeparationDistance : null);
        }

        /// Generated from method `JPH::RagdollSettings::GetSkeleton`.
        public unsafe new JPH.Skeleton? GetSkeleton()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_GetSkeleton_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_GetSkeleton_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Skeleton._Underlying *__JPH_RagdollSettings_GetSkeleton_mut(_Underlying *_this);
            var __c_ret = __JPH_RagdollSettings_GetSkeleton_mut(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Skeleton(__c_ret, is_owning: false) : null;
        }

        /// Calculate the map needed for GetBodyIndexToConstraintIndex()
        /// Generated from method `JPH::RagdollSettings::CalculateBodyIndexToConstraintIndex`.
        public unsafe void CalculateBodyIndexToConstraintIndex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_CalculateBodyIndexToConstraintIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_CalculateBodyIndexToConstraintIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RagdollSettings_CalculateBodyIndexToConstraintIndex(_Underlying *_this);
            __JPH_RagdollSettings_CalculateBodyIndexToConstraintIndex(_UnderlyingPtr);
        }

        /// Calculate the map needed for GetConstraintIndexToBodyIdxPair()
        /// Generated from method `JPH::RagdollSettings::CalculateConstraintIndexToBodyIdxPair`.
        public unsafe void CalculateConstraintIndexToBodyIdxPair()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RagdollSettings_CalculateConstraintIndexToBodyIdxPair", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RagdollSettings_CalculateConstraintIndexToBodyIdxPair", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RagdollSettings_CalculateConstraintIndexToBodyIdxPair(_Underlying *_this);
            __JPH_RagdollSettings_CalculateConstraintIndexToBodyIdxPair(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `RagdollSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `RagdollSettings`/`Const_RagdollSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_RagdollSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_RagdollSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_RagdollSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_RagdollSettings(Const_RagdollSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_RagdollSettings(Const_RagdollSettings arg) {return new(arg);}
        public _ByValue_RagdollSettings(JPH._Moved<RagdollSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_RagdollSettings(JPH._Moved<RagdollSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `RagdollSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RagdollSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RagdollSettings`/`Const_RagdollSettings` directly.
    public class _InOptMut_RagdollSettings
    {
        public RagdollSettings? Opt;

        public _InOptMut_RagdollSettings() {}
        public _InOptMut_RagdollSettings(RagdollSettings value) {Opt = value;}
        public static implicit operator _InOptMut_RagdollSettings(RagdollSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `RagdollSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RagdollSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RagdollSettings`/`Const_RagdollSettings` to pass it to the function.
    public class _InOptConst_RagdollSettings
    {
        public Const_RagdollSettings? Opt;

        public _InOptConst_RagdollSettings() {}
        public _InOptConst_RagdollSettings(Const_RagdollSettings value) {Opt = value;}
        public static implicit operator _InOptConst_RagdollSettings(Const_RagdollSettings value) {return new(value);}
    }

    /// Runtime ragdoll information
    /// Generated from class `JPH::Ragdoll`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::Ragdoll>`
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_Ragdoll : JPH.Object<Const_Ragdoll>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Ragdoll_Release(void *_this);
            __JPH_RefTarget_JPH_Ragdoll_Release(__JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Ragdoll() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHRagdoll(Const_Ragdoll self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHRagdoll._Underlying *__JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll(_Underlying *_this);
            JPH.Const_RefTarget_JPHRagdoll ret = new(__JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_Ragdoll self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_Ragdoll_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_Ragdoll_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_Ragdoll(JPH.Const_RefTarget_JPHRagdoll parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_StaticDowncastFrom_JPH_RefTarget_JPH_Ragdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_StaticDowncastFrom_JPH_RefTarget_JPH_Ragdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Ragdoll_StaticDowncastFrom_JPH_RefTarget_JPH_Ragdoll(JPH.Const_RefTarget_JPHRagdoll._Underlying *_this);
            Const_Ragdoll ret = new(__JPH_Ragdoll_StaticDowncastFrom_JPH_RefTarget_JPH_Ragdoll(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_Ragdoll(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Ragdoll_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_Ragdoll ret = new(__JPH_Ragdoll_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_Ragdoll(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// Generated from constructor `JPH::Ragdoll::Ragdoll`.
        public unsafe Const_Ragdoll(JPH.PhysicsSystem? inSystem) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Ragdoll._Underlying *__JPH_Ragdoll_Construct(JPH.PhysicsSystem._Underlying *inSystem);
            _UnderlyingPtr = __JPH_Ragdoll_Construct(inSystem is not null ? inSystem._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Ragdoll_AddRef(void *_this);
            __JPH_RefTarget_JPH_Ragdoll_AddRef(__JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll(_UnderlyingPtr));
        }

        /// Generated from method `JPH::Ragdoll::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Ragdoll_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Ragdoll_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Ragdoll_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_Ragdoll_size_t(inCount);
        }

        /// Generated from method `JPH::Ragdoll::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Ragdoll_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Ragdoll_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Ragdoll_void_ptr(void *inPointer);
            __Jolt_delete_JPH_Ragdoll_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Ragdoll::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Ragdoll_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Ragdoll_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Ragdoll_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_Ragdoll_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Ragdoll::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Ragdoll_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Ragdoll_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Ragdoll_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_Ragdoll_size_t(inCount);
        }

        /// Generated from method `JPH::Ragdoll::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Ragdoll_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Ragdoll_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Ragdoll_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_Ragdoll_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Ragdoll::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Ragdoll_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Ragdoll_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Ragdoll_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_Ragdoll_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Ragdoll::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Ragdoll_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Ragdoll_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Ragdoll_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_Ragdoll_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Ragdoll::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Ragdoll_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Ragdoll_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Ragdoll_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_Ragdoll_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::Ragdoll::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Ragdoll_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Ragdoll_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Ragdoll_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_Ragdoll_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Ragdoll::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Ragdoll_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Ragdoll_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Ragdoll_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_Ragdoll_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Check if one or more of the bodies in the ragdoll are active.
        /// Note that this involves locking the bodies (if inLockBodies is true) and looping over them. An alternative and possibly faster
        /// way could be to install a BodyActivationListener and count the number of active bodies of a ragdoll as they're activated / deactivated
        /// (basically check if the body that activates / deactivates is in GetBodyIDs() and increment / decrement a counter).
        /// Generated from method `JPH::Ragdoll::IsActive`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe bool IsActive(bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Ragdoll_IsActive(_Underlying *_this, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            return __JPH_Ragdoll_IsActive(_UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null) != 0;
        }

        /// Get the position and orientation of the root of the ragdoll
        /// Generated from method `JPH::Ragdoll::GetRootTransform`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void GetRootTransform(JPH.Vec3 outPosition, JPH.Quat outRotation, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_GetRootTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_GetRootTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_GetRootTransform(_Underlying *_this, JPH.Vec3._Underlying *outPosition, JPH.Quat._Underlying *outRotation, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_GetRootTransform(_UnderlyingPtr, outPosition._UnderlyingPtr, outRotation._UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Get number of bodies in the ragdoll
        /// Generated from method `JPH::Ragdoll::GetBodyCount`.
        public unsafe UIntPtr GetBodyCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_GetBodyCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_GetBodyCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_Ragdoll_GetBodyCount(_Underlying *_this);
            return __JPH_Ragdoll_GetBodyCount(_UnderlyingPtr);
        }

        /// Access a body ID
        /// Generated from method `JPH::Ragdoll::GetBodyID`.
        public unsafe JPH.BodyID GetBodyID(int inBodyIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_GetBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_GetBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID __JPH_Ragdoll_GetBodyID(_Underlying *_this, int inBodyIndex);
            return __JPH_Ragdoll_GetBodyID(_UnderlyingPtr, inBodyIndex);
        }

        /// Access to the array of body IDs
        /// Generated from method `JPH::Ragdoll::GetBodyIDs`.
        public unsafe JPH.Const_Array_JPHBodyID GetBodyIDs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_GetBodyIDs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_GetBodyIDs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Array_JPHBodyID._Underlying *__JPH_Ragdoll_GetBodyIDs(_Underlying *_this);
            return new(__JPH_Ragdoll_GetBodyIDs(_UnderlyingPtr), is_owning: false);
        }

        /// Get number of constraints in the ragdoll
        /// Generated from method `JPH::Ragdoll::GetConstraintCount`.
        public unsafe UIntPtr GetConstraintCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_GetConstraintCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_GetConstraintCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_Ragdoll_GetConstraintCount(_Underlying *_this);
            return __JPH_Ragdoll_GetConstraintCount(_UnderlyingPtr);
        }

        /// Access a constraint by index
        /// Generated from method `JPH::Ragdoll::GetConstraint`.
        public unsafe JPH.Const_TwoBodyConstraint? GetConstraint(int inConstraintIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_GetConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_GetConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_TwoBodyConstraint._Underlying *__JPH_Ragdoll_GetConstraint(_Underlying *_this, int inConstraintIndex);
            var __c_ret = __JPH_Ragdoll_GetConstraint(_UnderlyingPtr, inConstraintIndex);
            return __c_ret is not null ? new JPH.Const_TwoBodyConstraint(__c_ret, is_owning: false) : null;
        }

        /// Get world space bounding box for all bodies of the ragdoll
        /// Generated from method `JPH::Ragdoll::GetWorldSpaceBounds`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe JPH.AABox GetWorldSpaceBounds(bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_GetWorldSpaceBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_GetWorldSpaceBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_Ragdoll_GetWorldSpaceBounds(_Underlying *_this, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            return new(__JPH_Ragdoll_GetWorldSpaceBounds(_UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null), is_owning: true);
        }

        /// Get the settings object that created this ragdoll
        /// Generated from method `JPH::Ragdoll::GetRagdollSettings`.
        public unsafe JPH.Const_RagdollSettings? GetRagdollSettings()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_GetRagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_GetRagdollSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RagdollSettings._Underlying *__JPH_Ragdoll_GetRagdollSettings(_Underlying *_this);
            var __c_ret = __JPH_Ragdoll_GetRagdollSettings(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_RagdollSettings(__c_ret, is_owning: false) : null;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::Ragdoll::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_SetEmbedded(_Underlying *_this);
            __JPH_Ragdoll_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::Ragdoll::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_Ragdoll_GetRefCount(_Underlying *_this);
            return __JPH_Ragdoll_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::Ragdoll::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_AddRef(_Underlying *_this);
            __JPH_Ragdoll_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::Ragdoll::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_Release(_Underlying *_this);
            __JPH_Ragdoll_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::Ragdoll::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_Ragdoll_sInternalGetRefCountOffset();
            return __JPH_Ragdoll_sInternalGetRefCountOffset();
        }
    }

    /// Runtime ragdoll information
    /// Generated from class `JPH::Ragdoll`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::Ragdoll>`
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class Ragdoll : Const_Ragdoll
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHRagdoll(Ragdoll self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHRagdoll._Underlying *__JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll(_Underlying *_this);
            JPH.RefTarget_JPHRagdoll ret = new(__JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHRagdoll(Ragdoll self)
            => (JPH.Const_RefTarget_JPHRagdoll)(JPH.Const_Ragdoll)self;
        public static unsafe implicit operator JPH.NonCopyable(Ragdoll self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_Ragdoll_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_Ragdoll_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Ragdoll self)
            => (JPH.Const_NonCopyable)(JPH.Const_Ragdoll)self;

        // Downcasts:
        public static unsafe explicit operator Ragdoll(JPH.RefTarget_JPHRagdoll parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_StaticDowncastFrom_JPH_RefTarget_JPH_Ragdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_StaticDowncastFrom_JPH_RefTarget_JPH_Ragdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Ragdoll_StaticDowncastFrom_JPH_RefTarget_JPH_Ragdoll(JPH.RefTarget_JPHRagdoll._Underlying *_this);
            Ragdoll ret = new(__JPH_Ragdoll_StaticDowncastFrom_JPH_RefTarget_JPH_Ragdoll(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Ragdoll(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_Ragdoll_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            Ragdoll ret = new(__JPH_Ragdoll_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Ragdoll(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// Generated from constructor `JPH::Ragdoll::Ragdoll`.
        public unsafe Ragdoll(JPH.PhysicsSystem? inSystem) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Ragdoll._Underlying *__JPH_Ragdoll_Construct(JPH.PhysicsSystem._Underlying *inSystem);
            _UnderlyingPtr = __JPH_Ragdoll_Construct(inSystem is not null ? inSystem._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Ragdoll_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Ragdoll_AddRef(void *_this);
            __JPH_RefTarget_JPH_Ragdoll_AddRef(__JPH_Ragdoll_UpcastTo_JPH_RefTarget_JPH_Ragdoll(_UnderlyingPtr));
        }

        /// Add bodies and constraints to the system and optionally activate the bodies
        /// Generated from method `JPH::Ragdoll::AddToPhysicsSystem`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void AddToPhysicsSystem(JPH.EActivation inActivationMode, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_AddToPhysicsSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_AddToPhysicsSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_AddToPhysicsSystem(_Underlying *_this, JPH.EActivation inActivationMode, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_AddToPhysicsSystem(_UnderlyingPtr, inActivationMode, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Remove bodies and constraints from the system
        /// Generated from method `JPH::Ragdoll::RemoveFromPhysicsSystem`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void RemoveFromPhysicsSystem(bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_RemoveFromPhysicsSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_RemoveFromPhysicsSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_RemoveFromPhysicsSystem(_Underlying *_this, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_RemoveFromPhysicsSystem(_UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Wake up all bodies in the ragdoll
        /// Generated from method `JPH::Ragdoll::Activate`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void Activate(bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_Activate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_Activate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_Activate(_Underlying *_this, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_Activate(_UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Set the group ID on all bodies in the ragdoll
        /// Generated from method `JPH::Ragdoll::SetGroupID`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void SetGroupID(uint inGroupID, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_SetGroupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_SetGroupID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_SetGroupID(_Underlying *_this, uint inGroupID, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_SetGroupID(_UnderlyingPtr, inGroupID, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Set the ragdoll to a pose (calls BodyInterface::SetPositionAndRotation to instantly move the ragdoll)
        /// Generated from method `JPH::Ragdoll::SetPose`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void SetPose(JPH.Const_SkeletonPose inPose, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_SetPose_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_SetPose_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_SetPose_2(_Underlying *_this, JPH.Const_SkeletonPose._Underlying *inPose, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_SetPose_2(_UnderlyingPtr, inPose._UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Lower level version of SetPose that directly takes the world space joint matrices
        /// Generated from method `JPH::Ragdoll::SetPose`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void SetPose(JPH.Const_Vec3 inRootOffset, JPH.Const_Mat44? inJointMatrices, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_SetPose_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_SetPose_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_SetPose_3(_Underlying *_this, JPH.Vec3._Underlying *inRootOffset, JPH.Const_Mat44._Underlying *inJointMatrices, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_SetPose_3(_UnderlyingPtr, inRootOffset._UnderlyingPtr, inJointMatrices is not null ? inJointMatrices._UnderlyingPtr : null, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Get the ragdoll pose (uses the world transform of the bodies to calculate the pose)
        /// Generated from method `JPH::Ragdoll::GetPose`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void GetPose(JPH.SkeletonPose outPose, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_GetPose_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_GetPose_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_GetPose_2(_Underlying *_this, JPH.SkeletonPose._Underlying *outPose, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_GetPose_2(_UnderlyingPtr, outPose._UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Lower level version of GetPose that directly returns the world space joint matrices
        /// Generated from method `JPH::Ragdoll::GetPose`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void GetPose(JPH.Vec3 outRootOffset, JPH.Mat44? outJointMatrices, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_GetPose_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_GetPose_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_GetPose_3(_Underlying *_this, JPH.Vec3._Underlying *outRootOffset, JPH.Mat44._Underlying *outJointMatrices, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_GetPose_3(_UnderlyingPtr, outRootOffset._UnderlyingPtr, outJointMatrices is not null ? outJointMatrices._UnderlyingPtr : null, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// This function calls ResetWarmStart on all constraints. It can be used after calling SetPose to reset previous frames impulses. See: Constraint::ResetWarmStart.
        /// Generated from method `JPH::Ragdoll::ResetWarmStart`.
        public unsafe void ResetWarmStart()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_ResetWarmStart(_Underlying *_this);
            __JPH_Ragdoll_ResetWarmStart(_UnderlyingPtr);
        }

        /// Drive the ragdoll to a specific pose by setting velocities on each of the bodies so that it will reach inPose in inDeltaTime
        /// Generated from method `JPH::Ragdoll::DriveToPoseUsingKinematics`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void DriveToPoseUsingKinematics(JPH.Const_SkeletonPose inPose, float inDeltaTime, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_DriveToPoseUsingKinematics_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_DriveToPoseUsingKinematics_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_DriveToPoseUsingKinematics_3(_Underlying *_this, JPH.Const_SkeletonPose._Underlying *inPose, float inDeltaTime, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_DriveToPoseUsingKinematics_3(_UnderlyingPtr, inPose._UnderlyingPtr, inDeltaTime, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Lower level version of DriveToPoseUsingKinematics that directly takes the world space joint matrices
        /// Generated from method `JPH::Ragdoll::DriveToPoseUsingKinematics`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void DriveToPoseUsingKinematics(JPH.Const_Vec3 inRootOffset, JPH.Const_Mat44? inJointMatrices, float inDeltaTime, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_DriveToPoseUsingKinematics_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_DriveToPoseUsingKinematics_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_DriveToPoseUsingKinematics_4(_Underlying *_this, JPH.Vec3._Underlying *inRootOffset, JPH.Const_Mat44._Underlying *inJointMatrices, float inDeltaTime, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_DriveToPoseUsingKinematics_4(_UnderlyingPtr, inRootOffset._UnderlyingPtr, inJointMatrices is not null ? inJointMatrices._UnderlyingPtr : null, inDeltaTime, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Drive the ragdoll to a specific pose by activating the motors on each constraint
        /// Generated from method `JPH::Ragdoll::DriveToPoseUsingMotors`.
        public unsafe void DriveToPoseUsingMotors(JPH.Const_SkeletonPose inPose)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_DriveToPoseUsingMotors", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_DriveToPoseUsingMotors", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_DriveToPoseUsingMotors(_Underlying *_this, JPH.Const_SkeletonPose._Underlying *inPose);
            __JPH_Ragdoll_DriveToPoseUsingMotors(_UnderlyingPtr, inPose._UnderlyingPtr);
        }

        /// Control the linear and velocity of all bodies in the ragdoll
        /// Generated from method `JPH::Ragdoll::SetLinearAndAngularVelocity`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void SetLinearAndAngularVelocity(JPH.Const_Vec3 inLinearVelocity, JPH.Const_Vec3 inAngularVelocity, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_SetLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_SetLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_SetLinearAndAngularVelocity(_Underlying *_this, JPH.Vec3._Underlying *inLinearVelocity, JPH.Vec3._Underlying *inAngularVelocity, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_SetLinearAndAngularVelocity(_UnderlyingPtr, inLinearVelocity._UnderlyingPtr, inAngularVelocity._UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Set the world space linear velocity of all bodies in the ragdoll.
        /// Generated from method `JPH::Ragdoll::SetLinearVelocity`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void SetLinearVelocity(JPH.Const_Vec3 inLinearVelocity, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_SetLinearVelocity(_Underlying *_this, JPH.Vec3._Underlying *inLinearVelocity, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_SetLinearVelocity(_UnderlyingPtr, inLinearVelocity._UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Add a world space velocity (in m/s) to all bodies in the ragdoll.
        /// Generated from method `JPH::Ragdoll::AddLinearVelocity`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void AddLinearVelocity(JPH.Const_Vec3 inLinearVelocity, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_AddLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_AddLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_AddLinearVelocity(_Underlying *_this, JPH.Vec3._Underlying *inLinearVelocity, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_AddLinearVelocity(_UnderlyingPtr, inLinearVelocity._UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Add impulse to all bodies of the ragdoll (center of mass of each of them)
        /// Generated from method `JPH::Ragdoll::AddImpulse`.
        /// Parameter `inLockBodies` defaults to `true`.
        public unsafe void AddImpulse(JPH.Const_Vec3 inImpulse, bool? inLockBodies = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_AddImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_AddImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ragdoll_AddImpulse(_Underlying *_this, JPH.Vec3._Underlying *inImpulse, byte *inLockBodies);
            byte __deref_inLockBodies = inLockBodies.GetValueOrDefault() ? (byte)1 : (byte)0;
            __JPH_Ragdoll_AddImpulse(_UnderlyingPtr, inImpulse._UnderlyingPtr, inLockBodies.HasValue ? &__deref_inLockBodies : null);
        }

        /// Access a constraint by index
        /// Generated from method `JPH::Ragdoll::GetConstraint`.
        public unsafe new JPH.TwoBodyConstraint? GetConstraint(int inConstraintIndex)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ragdoll_GetConstraint_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ragdoll_GetConstraint_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TwoBodyConstraint._Underlying *__JPH_Ragdoll_GetConstraint_mut(_Underlying *_this, int inConstraintIndex);
            var __c_ret = __JPH_Ragdoll_GetConstraint_mut(_UnderlyingPtr, inConstraintIndex);
            return __c_ret is not null ? new JPH.TwoBodyConstraint(__c_ret, is_owning: false) : null;
        }
    }

    /// This is used for optional parameters of class `Ragdoll` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Ragdoll`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Ragdoll`/`Const_Ragdoll` directly.
    public class _InOptMut_Ragdoll
    {
        public Ragdoll? Opt;

        public _InOptMut_Ragdoll() {}
        public _InOptMut_Ragdoll(Ragdoll value) {Opt = value;}
        public static implicit operator _InOptMut_Ragdoll(Ragdoll value) {return new(value);}
    }

    /// This is used for optional parameters of class `Ragdoll` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Ragdoll`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Ragdoll`/`Const_Ragdoll` to pass it to the function.
    public class _InOptConst_Ragdoll
    {
        public Const_Ragdoll? Opt;

        public _InOptConst_Ragdoll() {}
        public _InOptConst_Ragdoll(Const_Ragdoll value) {Opt = value;}
        public static implicit operator _InOptConst_Ragdoll(Const_Ragdoll value) {return new(value);}
    }
}
