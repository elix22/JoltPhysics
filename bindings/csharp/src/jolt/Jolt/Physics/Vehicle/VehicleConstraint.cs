// machine generated, do not edit
public static partial class JPH
{
    /// Configuration for constraint that simulates a wheeled vehicle.
    ///
    /// The properties in this constraint are largely based on "Car Physics for Games" by Marco Monster.
    /// See: https://www.asawicki.info/Mirror/Car%20Physics%20for%20Games/Car%20Physics%20for%20Games.html
    /// Generated from class `JPH::VehicleConstraintSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConstraintSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ConstraintSettings>`
    /// This is the const half of the class.
    public class Const_VehicleConstraintSettings : JPH.Object<Const_VehicleConstraintSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_Release(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_Release(__JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_VehicleConstraintSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_VehicleConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_VehicleConstraintSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_VehicleConstraintSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHConstraintSettings(Const_VehicleConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHConstraintSettings._Underlying *__JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHConstraintSettings ret = new(__JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ConstraintSettings(Const_VehicleConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ConstraintSettings._Underlying *__JPH_VehicleConstraintSettings_UpcastTo_JPH_ConstraintSettings(_Underlying *_this);
            JPH.Const_ConstraintSettings ret = new(__JPH_VehicleConstraintSettings_UpcastTo_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        ///< Vector indicating the up direction of the vehicle (in local space to the body)
        public unsafe JPH.Const_Vec3 mUp
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_VehicleConstraintSettings_Get_mUp(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_VehicleConstraintSettings_Get_mUp(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Vector indicating forward direction of the vehicle (in local space to the body)
        public unsafe JPH.Const_Vec3 mForward
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_VehicleConstraintSettings_Get_mForward(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_VehicleConstraintSettings_Get_mForward(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Defines the maximum pitch/roll angle (rad), can be used to avoid the car from getting upside down. The vehicle up direction will stay within a cone centered around the up axis with half top angle mMaxPitchRollAngle, set to pi to turn off.
        public unsafe float mMaxPitchRollAngle
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mMaxPitchRollAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mMaxPitchRollAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleConstraintSettings_Get_mMaxPitchRollAngle(_Underlying *_this);
                return *__JPH_VehicleConstraintSettings_Get_mMaxPitchRollAngle(_UnderlyingPtr);
            }
        }

        /// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
        public unsafe bool mEnabled
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_VehicleConstraintSettings_Get_mEnabled(_Underlying *_this);
                return *__JPH_VehicleConstraintSettings_Get_mEnabled(_UnderlyingPtr);
            }
        }

        /// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
        /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
        public unsafe uint mConstraintPriority
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_VehicleConstraintSettings_Get_mConstraintPriority(_Underlying *_this);
                return *__JPH_VehicleConstraintSettings_Get_mConstraintPriority(_UnderlyingPtr);
            }
        }

        /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public unsafe uint mNumVelocityStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_VehicleConstraintSettings_Get_mNumVelocityStepsOverride(_Underlying *_this);
                return *__JPH_VehicleConstraintSettings_Get_mNumVelocityStepsOverride(_UnderlyingPtr);
            }
        }

        /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public unsafe uint mNumPositionStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_VehicleConstraintSettings_Get_mNumPositionStepsOverride(_Underlying *_this);
                return *__JPH_VehicleConstraintSettings_Get_mNumPositionStepsOverride(_UnderlyingPtr);
            }
        }

        /// Size of constraint when drawing it through the debug renderer
        public unsafe float mDrawConstraintSize
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleConstraintSettings_Get_mDrawConstraintSize(_Underlying *_this);
                return *__JPH_VehicleConstraintSettings_Get_mDrawConstraintSize(_UnderlyingPtr);
            }
        }

        /// User data value (can be used by application)
        public unsafe UIntPtr mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static UIntPtr *__JPH_VehicleConstraintSettings_Get_mUserData(_Underlying *_this);
                return *__JPH_VehicleConstraintSettings_Get_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe Const_VehicleConstraintSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_VehicleConstraintSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleConstraintSettings._Underlying *__JPH_VehicleConstraintSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleConstraintSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_AddRef(__JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::VehicleConstraintSettings::VehicleConstraintSettings`.
        public unsafe Const_VehicleConstraintSettings(JPH._ByValue_VehicleConstraintSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleConstraintSettings._Underlying *__JPH_VehicleConstraintSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.VehicleConstraintSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_AddRef(__JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::VehicleConstraintSettings::VehicleConstraintSettings`.
        public Const_VehicleConstraintSettings(Const_VehicleConstraintSettings _other) : this(new _ByValue_VehicleConstraintSettings(_other)) {}

        /// Generated from constructor `JPH::VehicleConstraintSettings::VehicleConstraintSettings`.
        public Const_VehicleConstraintSettings(VehicleConstraintSettings _other) : this((Const_VehicleConstraintSettings)_other) {}

        /// Generated from method `JPH::VehicleConstraintSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleConstraintSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_VehicleConstraintSettings_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleConstraintSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleConstraintSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_VehicleConstraintSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleConstraintSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleConstraintSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_VehicleConstraintSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleConstraintSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleConstraintSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_VehicleConstraintSettings_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleConstraintSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleConstraintSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleConstraintSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleConstraintSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_VehicleConstraintSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleConstraintSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_VehicleConstraintSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::VehicleConstraintSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleConstraintSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_VehicleConstraintSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleConstraintSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_VehicleConstraintSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::VehicleConstraintSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraintSettings_SetEmbedded(_Underlying *_this);
            __JPH_VehicleConstraintSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::VehicleConstraintSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_VehicleConstraintSettings_GetRefCount(_Underlying *_this);
            return __JPH_VehicleConstraintSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::VehicleConstraintSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraintSettings_AddRef(_Underlying *_this);
            __JPH_VehicleConstraintSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleConstraintSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraintSettings_Release(_Underlying *_this);
            __JPH_VehicleConstraintSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::VehicleConstraintSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_VehicleConstraintSettings_sInternalGetRefCountOffset();
            return __JPH_VehicleConstraintSettings_sInternalGetRefCountOffset();
        }
    }

    /// Configuration for constraint that simulates a wheeled vehicle.
    ///
    /// The properties in this constraint are largely based on "Car Physics for Games" by Marco Monster.
    /// See: https://www.asawicki.info/Mirror/Car%20Physics%20for%20Games/Car%20Physics%20for%20Games.html
    /// Generated from class `JPH::VehicleConstraintSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ConstraintSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ConstraintSettings>`
    /// This is the non-const half of the class.
    public class VehicleConstraintSettings : Const_VehicleConstraintSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(VehicleConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_VehicleConstraintSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_VehicleConstraintSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.RefTarget_JPHConstraintSettings(VehicleConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraintSettings._Underlying *__JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            JPH.RefTarget_JPHConstraintSettings ret = new(__JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ConstraintSettings(VehicleConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ConstraintSettings._Underlying *__JPH_VehicleConstraintSettings_UpcastTo_JPH_ConstraintSettings(_Underlying *_this);
            JPH.ConstraintSettings ret = new(__JPH_VehicleConstraintSettings_UpcastTo_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        ///< Vector indicating the up direction of the vehicle (in local space to the body)
        public new unsafe JPH.Vec3 mUp
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_VehicleConstraintSettings_GetMutable_mUp(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_VehicleConstraintSettings_GetMutable_mUp(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Vector indicating forward direction of the vehicle (in local space to the body)
        public new unsafe JPH.Vec3 mForward
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_VehicleConstraintSettings_GetMutable_mForward(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_VehicleConstraintSettings_GetMutable_mForward(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Defines the maximum pitch/roll angle (rad), can be used to avoid the car from getting upside down. The vehicle up direction will stay within a cone centered around the up axis with half top angle mMaxPitchRollAngle, set to pi to turn off.
        public new unsafe ref float mMaxPitchRollAngle
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mMaxPitchRollAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mMaxPitchRollAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleConstraintSettings_GetMutable_mMaxPitchRollAngle(_Underlying *_this);
                return ref *__JPH_VehicleConstraintSettings_GetMutable_mMaxPitchRollAngle(_UnderlyingPtr);
            }
        }

        /// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
        public new unsafe ref bool mEnabled
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_VehicleConstraintSettings_GetMutable_mEnabled(_Underlying *_this);
                return ref *__JPH_VehicleConstraintSettings_GetMutable_mEnabled(_UnderlyingPtr);
            }
        }

        /// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
        /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
        public new unsafe ref uint mConstraintPriority
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_VehicleConstraintSettings_GetMutable_mConstraintPriority(_Underlying *_this);
                return ref *__JPH_VehicleConstraintSettings_GetMutable_mConstraintPriority(_UnderlyingPtr);
            }
        }

        /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public new unsafe ref uint mNumVelocityStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_VehicleConstraintSettings_GetMutable_mNumVelocityStepsOverride(_Underlying *_this);
                return ref *__JPH_VehicleConstraintSettings_GetMutable_mNumVelocityStepsOverride(_UnderlyingPtr);
            }
        }

        /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public new unsafe ref uint mNumPositionStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_VehicleConstraintSettings_GetMutable_mNumPositionStepsOverride(_Underlying *_this);
                return ref *__JPH_VehicleConstraintSettings_GetMutable_mNumPositionStepsOverride(_UnderlyingPtr);
            }
        }

        /// Size of constraint when drawing it through the debug renderer
        public new unsafe ref float mDrawConstraintSize
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_VehicleConstraintSettings_GetMutable_mDrawConstraintSize(_Underlying *_this);
                return ref *__JPH_VehicleConstraintSettings_GetMutable_mDrawConstraintSize(_UnderlyingPtr);
            }
        }

        /// User data value (can be used by application)
        public new unsafe ref UIntPtr mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static UIntPtr *__JPH_VehicleConstraintSettings_GetMutable_mUserData(_Underlying *_this);
                return ref *__JPH_VehicleConstraintSettings_GetMutable_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe VehicleConstraintSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe VehicleConstraintSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleConstraintSettings._Underlying *__JPH_VehicleConstraintSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_VehicleConstraintSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_AddRef(__JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::VehicleConstraintSettings::VehicleConstraintSettings`.
        public unsafe VehicleConstraintSettings(JPH._ByValue_VehicleConstraintSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleConstraintSettings._Underlying *__JPH_VehicleConstraintSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.VehicleConstraintSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_VehicleConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_AddRef(__JPH_VehicleConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::VehicleConstraintSettings::VehicleConstraintSettings`.
        public VehicleConstraintSettings(Const_VehicleConstraintSettings _other) : this(new _ByValue_VehicleConstraintSettings(_other)) {}

        /// Generated from constructor `JPH::VehicleConstraintSettings::VehicleConstraintSettings`.
        public VehicleConstraintSettings(VehicleConstraintSettings _other) : this((Const_VehicleConstraintSettings)_other) {}

        /// Generated from method `JPH::VehicleConstraintSettings::operator=`.
        public unsafe JPH.VehicleConstraintSettings Assign(JPH._ByValue_VehicleConstraintSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleConstraintSettings._Underlying *__JPH_VehicleConstraintSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.VehicleConstraintSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_VehicleConstraintSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `VehicleConstraintSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `VehicleConstraintSettings`/`Const_VehicleConstraintSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_VehicleConstraintSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_VehicleConstraintSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_VehicleConstraintSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_VehicleConstraintSettings(Const_VehicleConstraintSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_VehicleConstraintSettings(Const_VehicleConstraintSettings arg) {return new(arg);}
        public _ByValue_VehicleConstraintSettings(JPH._Moved<VehicleConstraintSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_VehicleConstraintSettings(JPH._Moved<VehicleConstraintSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `VehicleConstraintSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_VehicleConstraintSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleConstraintSettings`/`Const_VehicleConstraintSettings` directly.
    public class _InOptMut_VehicleConstraintSettings
    {
        public VehicleConstraintSettings? Opt;

        public _InOptMut_VehicleConstraintSettings() {}
        public _InOptMut_VehicleConstraintSettings(VehicleConstraintSettings value) {Opt = value;}
        public static implicit operator _InOptMut_VehicleConstraintSettings(VehicleConstraintSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `VehicleConstraintSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_VehicleConstraintSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleConstraintSettings`/`Const_VehicleConstraintSettings` to pass it to the function.
    public class _InOptConst_VehicleConstraintSettings
    {
        public Const_VehicleConstraintSettings? Opt;

        public _InOptConst_VehicleConstraintSettings() {}
        public _InOptConst_VehicleConstraintSettings(Const_VehicleConstraintSettings value) {Opt = value;}
        public static implicit operator _InOptConst_VehicleConstraintSettings(Const_VehicleConstraintSettings value) {return new(value);}
    }

    /// Constraint that simulates a vehicle
    /// Note: Don't forget to register the constraint as a StepListener with the PhysicsSystem!
    ///
    /// When the vehicle drives over very light objects (rubble) you may see the car body dip down. This is a known issue and is an artifact of the iterative solver that Jolt is using.
    /// Basically if a light object is sandwiched between two heavy objects (the static floor and the car body), the light object is not able to transfer enough force from the ground to
    /// the car body to keep the car body up. You can see this effect in the HeavyOnLightTest sample, the boxes on the right have a lot of penetration because they're on top of light objects.
    ///
    /// There are a couple of ways to improve this:
    ///
    /// 1. You can increase the number of velocity steps (global settings PhysicsSettings::mNumVelocitySteps or if you only want to increase it on
    /// the vehicle you can use VehicleConstraintSettings::mNumVelocityStepsOverride). E.g. going from 10 to 30 steps in the HeavyOnLightTest sample makes the penetration a lot less.
    /// The number of position steps can also be increased (the first prevents the body from going down, the second corrects it if the problem did
    /// occur which inevitably happens due to numerical drift). This solution costs CPU cycles.
    ///
    /// 2. You can reduce the mass difference between the vehicle body and the rubble on the floor (by making the rubble heavier or the car lighter).
    ///
    /// 3. You could filter out collisions between the vehicle collision test and the rubble completely. This would make the wheels ignore the rubble but would cause the vehicle to drive
    /// through it as if nothing happened. You could create fake wheels (keyframed bodies) that move along with the vehicle and that only collide with rubble (and not the vehicle or the ground).
    /// This would cause the vehicle to push away the rubble without the rubble being able to affect the vehicle (unless it hits the main body of course).
    ///
    /// Note that when driving over rubble, you may see the wheel jump up and down quite quickly because one frame a collision is found and the next frame not.
    /// To alleviate this, it may be needed to smooth the motion of the visual mesh for the wheel.
    /// Generated from class `JPH::VehicleConstraint`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Constraint`
    ///     `JPH::PhysicsStepListener`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Constraint>`
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_VehicleConstraint : JPH.Object<Const_VehicleConstraint>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Constraint_Release(void *_this);
            __JPH_RefTarget_JPH_Constraint_Release(__JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_VehicleConstraint() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHConstraint(Const_VehicleConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHConstraint._Underlying *__JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            JPH.Const_RefTarget_JPHConstraint ret = new(__JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_VehicleConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_VehicleConstraint_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_VehicleConstraint_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Constraint(Const_VehicleConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Constraint._Underlying *__JPH_VehicleConstraint_UpcastTo_JPH_Constraint(_Underlying *_this);
            JPH.Const_Constraint ret = new(__JPH_VehicleConstraint_UpcastTo_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_PhysicsStepListener(Const_VehicleConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_PhysicsStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_PhysicsStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_PhysicsStepListener._Underlying *__JPH_VehicleConstraint_UpcastTo_JPH_PhysicsStepListener(_Underlying *_this);
            JPH.Const_PhysicsStepListener ret = new(__JPH_VehicleConstraint_UpcastTo_JPH_PhysicsStepListener(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe Const_VehicleConstraint(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor / destructor
        /// Generated from constructor `JPH::VehicleConstraint::VehicleConstraint`.
        public unsafe Const_VehicleConstraint(JPH.Body inVehicleBody, JPH.Const_VehicleConstraintSettings inSettings) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleConstraint._Underlying *__JPH_VehicleConstraint_Construct(JPH.Body._Underlying *inVehicleBody, JPH.Const_VehicleConstraintSettings._Underlying *inSettings);
            _UnderlyingPtr = __JPH_VehicleConstraint_Construct(inVehicleBody._UnderlyingPtr, inSettings._UnderlyingPtr);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Constraint_AddRef(void *_this);
            __JPH_RefTarget_JPH_Constraint_AddRef(__JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_UnderlyingPtr));
        }

        /// Generated from method `JPH::VehicleConstraint::GetMaxPitchRollAngle`.
        public unsafe float GetMaxPitchRollAngle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetMaxPitchRollAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetMaxPitchRollAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_VehicleConstraint_GetMaxPitchRollAngle(_Underlying *_this);
            return __JPH_VehicleConstraint_GetMaxPitchRollAngle(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleConstraint::GetVehicleCollisionTester`.
        public unsafe JPH.Const_VehicleCollisionTester? GetVehicleCollisionTester()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetVehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetVehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleCollisionTester._Underlying *__JPH_VehicleConstraint_GetVehicleCollisionTester(_Underlying *_this);
            var __c_ret = __JPH_VehicleConstraint_GetVehicleCollisionTester(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_VehicleCollisionTester(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::VehicleConstraint::GetCombineFriction`.
        public unsafe JPH.Std.Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_ConstJPHBodyRef_ConstJPHSubShapeIDRef GetCombineFriction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetCombineFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetCombineFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Std.Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_ConstJPHBodyRef_ConstJPHSubShapeIDRef._Underlying *__JPH_VehicleConstraint_GetCombineFriction(_Underlying *_this);
            return new(__JPH_VehicleConstraint_GetCombineFriction(_UnderlyingPtr), is_owning: false);
        }

        /// Callback function to notify that PhysicsStepListener::OnStep has started for this vehicle. Default is to do nothing.
        /// Can be used to allow higher-level code to e.g. control steering. This is the last moment that the position/orientation of the vehicle can be changed.
        /// Wheel collision checks have not been performed yet.
        /// Generated from method `JPH::VehicleConstraint::GetPreStepCallback`.
        public unsafe JPH.Std.Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef GetPreStepCallback()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetPreStepCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetPreStepCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Std.Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *__JPH_VehicleConstraint_GetPreStepCallback(_Underlying *_this);
            return new(__JPH_VehicleConstraint_GetPreStepCallback(_UnderlyingPtr), is_owning: false);
        }

        /// Callback function to notify that PhysicsStepListener::OnStep has just completed wheel collision checks. Default is to do nothing.
        /// Can be used to allow higher-level code to e.g. detect tire contact or to modify the velocity of the vehicle based on the wheel contacts.
        /// You should not change the position of the vehicle in this callback as the wheel collision checks have already been performed.
        /// Generated from method `JPH::VehicleConstraint::GetPostCollideCallback`.
        public unsafe JPH.Std.Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef GetPostCollideCallback()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetPostCollideCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetPostCollideCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Std.Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *__JPH_VehicleConstraint_GetPostCollideCallback(_Underlying *_this);
            return new(__JPH_VehicleConstraint_GetPostCollideCallback(_UnderlyingPtr), is_owning: false);
        }

        /// Callback function to notify that PhysicsStepListener::OnStep has completed for this vehicle. Default is to do nothing.
        /// Can be used to allow higher-level code to e.g. control the vehicle in the air.
        /// You should not change the position of the vehicle in this callback as the wheel collision checks have already been performed.
        /// Generated from method `JPH::VehicleConstraint::GetPostStepCallback`.
        public unsafe JPH.Std.Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef GetPostStepCallback()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetPostStepCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetPostStepCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Std.Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *__JPH_VehicleConstraint_GetPostStepCallback(_Underlying *_this);
            return new(__JPH_VehicleConstraint_GetPostStepCallback(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::VehicleConstraint::IsGravityOverridden`.
        public unsafe bool IsGravityOverridden()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_IsGravityOverridden", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_IsGravityOverridden", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_VehicleConstraint_IsGravityOverridden(_Underlying *_this);
            return __JPH_VehicleConstraint_IsGravityOverridden(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JPH::VehicleConstraint::GetGravityOverride`.
        public unsafe JPH.Vec3 GetGravityOverride()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetGravityOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetGravityOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_VehicleConstraint_GetGravityOverride(_Underlying *_this);
            return new(__JPH_VehicleConstraint_GetGravityOverride(_UnderlyingPtr), is_owning: true);
        }

        /// Get the local space forward vector of the vehicle
        /// Generated from method `JPH::VehicleConstraint::GetLocalForward`.
        public unsafe JPH.Vec3 GetLocalForward()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetLocalForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetLocalForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_VehicleConstraint_GetLocalForward(_Underlying *_this);
            return new(__JPH_VehicleConstraint_GetLocalForward(_UnderlyingPtr), is_owning: true);
        }

        /// Get the local space up vector of the vehicle
        /// Generated from method `JPH::VehicleConstraint::GetLocalUp`.
        public unsafe JPH.Vec3 GetLocalUp()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetLocalUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetLocalUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_VehicleConstraint_GetLocalUp(_Underlying *_this);
            return new(__JPH_VehicleConstraint_GetLocalUp(_UnderlyingPtr), is_owning: true);
        }

        /// Vector indicating the world space up direction (used to limit vehicle pitch/roll), calculated every frame by inverting gravity
        /// Generated from method `JPH::VehicleConstraint::GetWorldUp`.
        public unsafe JPH.Vec3 GetWorldUp()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetWorldUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetWorldUp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_VehicleConstraint_GetWorldUp(_Underlying *_this);
            return new(__JPH_VehicleConstraint_GetWorldUp(_UnderlyingPtr), is_owning: true);
        }

        /// Access to the vehicle body
        /// Generated from method `JPH::VehicleConstraint::GetVehicleBody`.
        public unsafe JPH.Body? GetVehicleBody()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetVehicleBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetVehicleBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Body._Underlying *__JPH_VehicleConstraint_GetVehicleBody(_Underlying *_this);
            var __c_ret = __JPH_VehicleConstraint_GetVehicleBody(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Body(__c_ret, is_owning: false) : null;
        }

        /// Access to the vehicle controller interface (determines acceleration / deceleration)
        /// Generated from method `JPH::VehicleConstraint::GetController`.
        public unsafe JPH.Const_VehicleController? GetController()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetController", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleController._Underlying *__JPH_VehicleConstraint_GetController(_Underlying *_this);
            var __c_ret = __JPH_VehicleConstraint_GetController(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_VehicleController(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::VehicleConstraint::GetWheel`.
        public unsafe JPH.Const_Wheel? GetWheel(uint inIdx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetWheel", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Wheel._Underlying *__JPH_VehicleConstraint_GetWheel(_Underlying *_this, uint inIdx);
            var __c_ret = __JPH_VehicleConstraint_GetWheel(_UnderlyingPtr, inIdx);
            return __c_ret is not null ? new JPH.Const_Wheel(__c_ret, is_owning: false) : null;
        }

        /// Get the basis vectors for the wheel in local space to the vehicle body (note: basis does not rotate when the wheel rotates around its axis)
        /// @param inWheel Wheel to fetch basis for
        /// @param outForward Forward vector for the wheel
        /// @param outUp Up vector for the wheel
        /// @param outRight Right vector for the wheel
        /// Generated from method `JPH::VehicleConstraint::GetWheelLocalBasis`.
        public unsafe void GetWheelLocalBasis(JPH.Const_Wheel? inWheel, JPH.Vec3 outForward, JPH.Vec3 outUp, JPH.Vec3 outRight)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetWheelLocalBasis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetWheelLocalBasis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_GetWheelLocalBasis(_Underlying *_this, JPH.Const_Wheel._Underlying *inWheel, JPH.Vec3._Underlying *outForward, JPH.Vec3._Underlying *outUp, JPH.Vec3._Underlying *outRight);
            __JPH_VehicleConstraint_GetWheelLocalBasis(_UnderlyingPtr, inWheel is not null ? inWheel._UnderlyingPtr : null, outForward._UnderlyingPtr, outUp._UnderlyingPtr, outRight._UnderlyingPtr);
        }

        /// Get the transform of a wheel in local space to the vehicle body, returns a matrix that transforms a cylinder aligned with the Y axis in body space (not COM space)
        /// @param inWheelIndex Index of the wheel to fetch
        /// @param inWheelRight Unit vector that indicates right in model space of the wheel (so if you only have 1 wheel model, you probably want to specify the opposite direction for the left and right wheels)
        /// @param inWheelUp Unit vector that indicates up in model space of the wheel
        /// Generated from method `JPH::VehicleConstraint::GetWheelLocalTransform`.
        public unsafe JPH.Mat44 GetWheelLocalTransform(uint inWheelIndex, JPH.Const_Vec3 inWheelRight, JPH.Const_Vec3 inWheelUp)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetWheelLocalTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetWheelLocalTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_VehicleConstraint_GetWheelLocalTransform(_Underlying *_this, uint inWheelIndex, JPH.Vec3._Underlying *inWheelRight, JPH.Vec3._Underlying *inWheelUp);
            return new(__JPH_VehicleConstraint_GetWheelLocalTransform(_UnderlyingPtr, inWheelIndex, inWheelRight._UnderlyingPtr, inWheelUp._UnderlyingPtr), is_owning: true);
        }

        /// Get the transform of a wheel in world space, returns a matrix that transforms a cylinder aligned with the Y axis in world space
        /// @param inWheelIndex Index of the wheel to fetch
        /// @param inWheelRight Unit vector that indicates right in model space of the wheel (so if you only have 1 wheel model, you probably want to specify the opposite direction for the left and right wheels)
        /// @param inWheelUp Unit vector that indicates up in model space of the wheel
        /// Generated from method `JPH::VehicleConstraint::GetWheelWorldTransform`.
        public unsafe JPH.Mat44 GetWheelWorldTransform(uint inWheelIndex, JPH.Const_Vec3 inWheelRight, JPH.Const_Vec3 inWheelUp)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetWheelWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetWheelWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_VehicleConstraint_GetWheelWorldTransform(_Underlying *_this, uint inWheelIndex, JPH.Vec3._Underlying *inWheelRight, JPH.Vec3._Underlying *inWheelUp);
            return new(__JPH_VehicleConstraint_GetWheelWorldTransform(_UnderlyingPtr, inWheelIndex, inWheelRight._UnderlyingPtr, inWheelUp._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::VehicleConstraint::GetNumStepsBetweenCollisionTestActive`.
        public unsafe uint GetNumStepsBetweenCollisionTestActive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetNumStepsBetweenCollisionTestActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetNumStepsBetweenCollisionTestActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_VehicleConstraint_GetNumStepsBetweenCollisionTestActive(_Underlying *_this);
            return __JPH_VehicleConstraint_GetNumStepsBetweenCollisionTestActive(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleConstraint::GetNumStepsBetweenCollisionTestInactive`.
        public unsafe uint GetNumStepsBetweenCollisionTestInactive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetNumStepsBetweenCollisionTestInactive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetNumStepsBetweenCollisionTestInactive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_VehicleConstraint_GetNumStepsBetweenCollisionTestInactive(_Underlying *_this);
            return __JPH_VehicleConstraint_GetNumStepsBetweenCollisionTestInactive(_UnderlyingPtr);
        }

        // Generic interface of a constraint
        /// Generated from method `JPH::VehicleConstraint::IsActive`.
        public unsafe bool IsActive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_VehicleConstraint_IsActive(_Underlying *_this);
            return __JPH_VehicleConstraint_IsActive(_UnderlyingPtr) != 0;
        }

        /// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
        /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
        /// Generated from method `JPH::VehicleConstraint::GetConstraintPriority`.
        public unsafe uint GetConstraintPriority()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_VehicleConstraint_GetConstraintPriority(_Underlying *_this);
            return __JPH_VehicleConstraint_GetConstraintPriority(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleConstraint::GetNumVelocityStepsOverride`.
        public unsafe uint GetNumVelocityStepsOverride()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_VehicleConstraint_GetNumVelocityStepsOverride(_Underlying *_this);
            return __JPH_VehicleConstraint_GetNumVelocityStepsOverride(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleConstraint::GetNumPositionStepsOverride`.
        public unsafe uint GetNumPositionStepsOverride()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_VehicleConstraint_GetNumPositionStepsOverride(_Underlying *_this);
            return __JPH_VehicleConstraint_GetNumPositionStepsOverride(_UnderlyingPtr);
        }

        /// Test if a constraint is enabled.
        /// Generated from method `JPH::VehicleConstraint::GetEnabled`.
        public unsafe bool GetEnabled()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_VehicleConstraint_GetEnabled(_Underlying *_this);
            return __JPH_VehicleConstraint_GetEnabled(_UnderlyingPtr) != 0;
        }

        /// Access to the user data, can be used for anything by the application
        /// Generated from method `JPH::VehicleConstraint::GetUserData`.
        public unsafe UIntPtr GetUserData()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_VehicleConstraint_GetUserData(_Underlying *_this);
            return __JPH_VehicleConstraint_GetUserData(_UnderlyingPtr);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::VehicleConstraint::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetEmbedded(_Underlying *_this);
            __JPH_VehicleConstraint_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::VehicleConstraint::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_VehicleConstraint_GetRefCount(_Underlying *_this);
            return __JPH_VehicleConstraint_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::VehicleConstraint::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_AddRef(_Underlying *_this);
            __JPH_VehicleConstraint_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleConstraint::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_Release(_Underlying *_this);
            __JPH_VehicleConstraint_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::VehicleConstraint::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_VehicleConstraint_sInternalGetRefCountOffset();
            return __JPH_VehicleConstraint_sInternalGetRefCountOffset();
        }
    }

    /// Constraint that simulates a vehicle
    /// Note: Don't forget to register the constraint as a StepListener with the PhysicsSystem!
    ///
    /// When the vehicle drives over very light objects (rubble) you may see the car body dip down. This is a known issue and is an artifact of the iterative solver that Jolt is using.
    /// Basically if a light object is sandwiched between two heavy objects (the static floor and the car body), the light object is not able to transfer enough force from the ground to
    /// the car body to keep the car body up. You can see this effect in the HeavyOnLightTest sample, the boxes on the right have a lot of penetration because they're on top of light objects.
    ///
    /// There are a couple of ways to improve this:
    ///
    /// 1. You can increase the number of velocity steps (global settings PhysicsSettings::mNumVelocitySteps or if you only want to increase it on
    /// the vehicle you can use VehicleConstraintSettings::mNumVelocityStepsOverride). E.g. going from 10 to 30 steps in the HeavyOnLightTest sample makes the penetration a lot less.
    /// The number of position steps can also be increased (the first prevents the body from going down, the second corrects it if the problem did
    /// occur which inevitably happens due to numerical drift). This solution costs CPU cycles.
    ///
    /// 2. You can reduce the mass difference between the vehicle body and the rubble on the floor (by making the rubble heavier or the car lighter).
    ///
    /// 3. You could filter out collisions between the vehicle collision test and the rubble completely. This would make the wheels ignore the rubble but would cause the vehicle to drive
    /// through it as if nothing happened. You could create fake wheels (keyframed bodies) that move along with the vehicle and that only collide with rubble (and not the vehicle or the ground).
    /// This would cause the vehicle to push away the rubble without the rubble being able to affect the vehicle (unless it hits the main body of course).
    ///
    /// Note that when driving over rubble, you may see the wheel jump up and down quite quickly because one frame a collision is found and the next frame not.
    /// To alleviate this, it may be needed to smooth the motion of the visual mesh for the wheel.
    /// Generated from class `JPH::VehicleConstraint`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::Constraint`
    ///     `JPH::PhysicsStepListener`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Constraint>`
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class VehicleConstraint : Const_VehicleConstraint
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHConstraint(VehicleConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraint._Underlying *__JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            JPH.RefTarget_JPHConstraint ret = new(__JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.NonCopyable(VehicleConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_VehicleConstraint_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_VehicleConstraint_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Constraint(VehicleConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Constraint._Underlying *__JPH_VehicleConstraint_UpcastTo_JPH_Constraint(_Underlying *_this);
            JPH.Constraint ret = new(__JPH_VehicleConstraint_UpcastTo_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.PhysicsStepListener(VehicleConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_PhysicsStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_PhysicsStepListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsStepListener._Underlying *__JPH_VehicleConstraint_UpcastTo_JPH_PhysicsStepListener(_Underlying *_this);
            JPH.PhysicsStepListener ret = new(__JPH_VehicleConstraint_UpcastTo_JPH_PhysicsStepListener(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe VehicleConstraint(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor / destructor
        /// Generated from constructor `JPH::VehicleConstraint::VehicleConstraint`.
        public unsafe VehicleConstraint(JPH.Body inVehicleBody, JPH.Const_VehicleConstraintSettings inSettings) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleConstraint._Underlying *__JPH_VehicleConstraint_Construct(JPH.Body._Underlying *inVehicleBody, JPH.Const_VehicleConstraintSettings._Underlying *inSettings);
            _UnderlyingPtr = __JPH_VehicleConstraint_Construct(inVehicleBody._UnderlyingPtr, inSettings._UnderlyingPtr);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Constraint_AddRef(void *_this);
            __JPH_RefTarget_JPH_Constraint_AddRef(__JPH_VehicleConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_UnderlyingPtr));
        }

        /// Defines the maximum pitch/roll angle (rad), can be used to avoid the car from getting upside down. The vehicle up direction will stay within a cone centered around the up axis with half top angle mMaxPitchRollAngle, set to pi to turn off.
        /// Generated from method `JPH::VehicleConstraint::SetMaxPitchRollAngle`.
        public unsafe void SetMaxPitchRollAngle(float inMaxPitchRollAngle)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetMaxPitchRollAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetMaxPitchRollAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetMaxPitchRollAngle(_Underlying *_this, float inMaxPitchRollAngle);
            __JPH_VehicleConstraint_SetMaxPitchRollAngle(_UnderlyingPtr, inMaxPitchRollAngle);
        }

        /// Set the interface that tests collision between wheel and ground
        /// Generated from method `JPH::VehicleConstraint::SetVehicleCollisionTester`.
        public unsafe void SetVehicleCollisionTester(JPH.Const_VehicleCollisionTester? inTester)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetVehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetVehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetVehicleCollisionTester(_Underlying *_this, JPH.Const_VehicleCollisionTester._Underlying *inTester);
            __JPH_VehicleConstraint_SetVehicleCollisionTester(_UnderlyingPtr, inTester is not null ? inTester._UnderlyingPtr : null);
        }

        /// Set the function that combines the friction of two bodies and returns it
        /// Default method is the geometric mean: sqrt(friction1 * friction2).
        /// Generated from method `JPH::VehicleConstraint::SetCombineFriction`.
        public unsafe void SetCombineFriction(JPH.Std.Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_ConstJPHBodyRef_ConstJPHSubShapeIDRef inCombineFriction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetCombineFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetCombineFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetCombineFriction(_Underlying *_this, JPH.Std.Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_ConstJPHBodyRef_ConstJPHSubShapeIDRef._Underlying *inCombineFriction);
            __JPH_VehicleConstraint_SetCombineFriction(_UnderlyingPtr, inCombineFriction._UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleConstraint::SetPreStepCallback`.
        public unsafe void SetPreStepCallback(JPH.Std.Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef inPreStepCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetPreStepCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetPreStepCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetPreStepCallback(_Underlying *_this, JPH.Std.Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *inPreStepCallback);
            __JPH_VehicleConstraint_SetPreStepCallback(_UnderlyingPtr, inPreStepCallback._UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleConstraint::SetPostCollideCallback`.
        public unsafe void SetPostCollideCallback(JPH.Std.Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef inPostCollideCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetPostCollideCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetPostCollideCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetPostCollideCallback(_Underlying *_this, JPH.Std.Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *inPostCollideCallback);
            __JPH_VehicleConstraint_SetPostCollideCallback(_UnderlyingPtr, inPostCollideCallback._UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleConstraint::SetPostStepCallback`.
        public unsafe void SetPostStepCallback(JPH.Std.Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef inPostStepCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetPostStepCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetPostStepCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetPostStepCallback(_Underlying *_this, JPH.Std.Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *inPostStepCallback);
            __JPH_VehicleConstraint_SetPostStepCallback(_UnderlyingPtr, inPostStepCallback._UnderlyingPtr);
        }

        /// Override gravity for this vehicle. Note that overriding gravity will set the gravity factor of the vehicle body to 0 and apply gravity in the PhysicsStepListener instead.
        /// Generated from method `JPH::VehicleConstraint::OverrideGravity`.
        public unsafe void OverrideGravity(JPH.Const_Vec3 inGravity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_OverrideGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_OverrideGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_OverrideGravity(_Underlying *_this, JPH.Vec3._Underlying *inGravity);
            __JPH_VehicleConstraint_OverrideGravity(_UnderlyingPtr, inGravity._UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleConstraint::ResetGravityOverride`.
        public unsafe void ResetGravityOverride()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_ResetGravityOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_ResetGravityOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_ResetGravityOverride(_Underlying *_this);
            __JPH_VehicleConstraint_ResetGravityOverride(_UnderlyingPtr);
        }

        /// Access to the vehicle controller interface (determines acceleration / deceleration)
        /// Generated from method `JPH::VehicleConstraint::GetController`.
        public unsafe new JPH.VehicleController? GetController()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetController_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetController_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleController._Underlying *__JPH_VehicleConstraint_GetController_mut(_Underlying *_this);
            var __c_ret = __JPH_VehicleConstraint_GetController_mut(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.VehicleController(__c_ret, is_owning: false) : null;
        }

        /// Get the state of a wheel
        /// Generated from method `JPH::VehicleConstraint::GetWheel`.
        public unsafe new JPH.Wheel? GetWheel(uint inIdx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_GetWheel_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_GetWheel_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Wheel._Underlying *__JPH_VehicleConstraint_GetWheel_mut(_Underlying *_this, uint inIdx);
            var __c_ret = __JPH_VehicleConstraint_GetWheel_mut(_UnderlyingPtr, inIdx);
            return __c_ret is not null ? new JPH.Wheel(__c_ret, is_owning: false) : null;
        }

        /// Number of simulation steps between wheel collision tests when the vehicle is active. Default is 1. 0 = never, 1 = every step, 2 = every other step, etc.
        /// Note that if a vehicle has multiple wheels and the number of steps > 1, the wheels will be tested in a round robin fashion.
        /// If there are multiple vehicles, the tests will be spread out based on the BodyID of the vehicle.
        /// If you set this to test less than every step, you may see simulation artifacts. This setting can be used to reduce the cost of simulating vehicles in the distance.
        /// Generated from method `JPH::VehicleConstraint::SetNumStepsBetweenCollisionTestActive`.
        public unsafe void SetNumStepsBetweenCollisionTestActive(uint inSteps)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetNumStepsBetweenCollisionTestActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetNumStepsBetweenCollisionTestActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetNumStepsBetweenCollisionTestActive(_Underlying *_this, uint inSteps);
            __JPH_VehicleConstraint_SetNumStepsBetweenCollisionTestActive(_UnderlyingPtr, inSteps);
        }

        /// Number of simulation steps between wheel collision tests when the vehicle is inactive. Default is 1. 0 = never, 1 = every step, 2 = every other step, etc.
        /// Note that if a vehicle has multiple wheels and the number of steps > 1, the wheels will be tested in a round robin fashion.
        /// If there are multiple vehicles, the tests will be spread out based on the BodyID of the vehicle.
        /// This number can be lower than the number of steps when the vehicle is active as the only purpose of this test is
        /// to allow the vehicle to wake up in response to bodies moving into the wheels but not touching the body of the vehicle.
        /// Generated from method `JPH::VehicleConstraint::SetNumStepsBetweenCollisionTestInactive`.
        public unsafe void SetNumStepsBetweenCollisionTestInactive(uint inSteps)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetNumStepsBetweenCollisionTestInactive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetNumStepsBetweenCollisionTestInactive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetNumStepsBetweenCollisionTestInactive(_Underlying *_this, uint inSteps);
            __JPH_VehicleConstraint_SetNumStepsBetweenCollisionTestInactive(_UnderlyingPtr, inSteps);
        }

        /// Generated from method `JPH::VehicleConstraint::NotifyShapeChanged`.
        public unsafe void NotifyShapeChanged(in JPH.BodyID inBodyID, JPH.Const_Vec3 inDeltaCOM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_NotifyShapeChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_NotifyShapeChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_NotifyShapeChanged(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inDeltaCOM);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_VehicleConstraint_NotifyShapeChanged(_UnderlyingPtr, __ptr_inBodyID, inDeltaCOM._UnderlyingPtr);
            }
        }

        /// Generated from method `JPH::VehicleConstraint::SetupVelocityConstraint`.
        public unsafe void SetupVelocityConstraint(float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetupVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetupVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetupVelocityConstraint(_Underlying *_this, float inDeltaTime);
            __JPH_VehicleConstraint_SetupVelocityConstraint(_UnderlyingPtr, inDeltaTime);
        }

        /// Generated from method `JPH::VehicleConstraint::ResetWarmStart`.
        public unsafe void ResetWarmStart()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_ResetWarmStart(_Underlying *_this);
            __JPH_VehicleConstraint_ResetWarmStart(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleConstraint::WarmStartVelocityConstraint`.
        public unsafe void WarmStartVelocityConstraint(float inWarmStartImpulseRatio)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_WarmStartVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_WarmStartVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_WarmStartVelocityConstraint(_Underlying *_this, float inWarmStartImpulseRatio);
            __JPH_VehicleConstraint_WarmStartVelocityConstraint(_UnderlyingPtr, inWarmStartImpulseRatio);
        }

        /// Generated from method `JPH::VehicleConstraint::SolveVelocityConstraint`.
        public unsafe bool SolveVelocityConstraint(float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SolveVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SolveVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_VehicleConstraint_SolveVelocityConstraint(_Underlying *_this, float inDeltaTime);
            return __JPH_VehicleConstraint_SolveVelocityConstraint(_UnderlyingPtr, inDeltaTime) != 0;
        }

        /// Generated from method `JPH::VehicleConstraint::SolvePositionConstraint`.
        public unsafe bool SolvePositionConstraint(float inDeltaTime, float inBaumgarte)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SolvePositionConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SolvePositionConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_VehicleConstraint_SolvePositionConstraint(_Underlying *_this, float inDeltaTime, float inBaumgarte);
            return __JPH_VehicleConstraint_SolvePositionConstraint(_UnderlyingPtr, inDeltaTime, inBaumgarte) != 0;
        }

        /// Generated from method `JPH::VehicleConstraint::SetConstraintPriority`.
        public unsafe void SetConstraintPriority(uint inPriority)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetConstraintPriority(_Underlying *_this, uint inPriority);
            __JPH_VehicleConstraint_SetConstraintPriority(_UnderlyingPtr, inPriority);
        }

        /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
        /// Generated from method `JPH::VehicleConstraint::SetNumVelocityStepsOverride`.
        public unsafe void SetNumVelocityStepsOverride(uint inN)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetNumVelocityStepsOverride(_Underlying *_this, uint inN);
            __JPH_VehicleConstraint_SetNumVelocityStepsOverride(_UnderlyingPtr, inN);
        }

        /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
        /// Generated from method `JPH::VehicleConstraint::SetNumPositionStepsOverride`.
        public unsafe void SetNumPositionStepsOverride(uint inN)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetNumPositionStepsOverride(_Underlying *_this, uint inN);
            __JPH_VehicleConstraint_SetNumPositionStepsOverride(_UnderlyingPtr, inN);
        }

        /// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
        /// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
        /// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
        /// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
        /// Generated from method `JPH::VehicleConstraint::SetEnabled`.
        public unsafe void SetEnabled(bool inEnabled)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetEnabled(_Underlying *_this, byte inEnabled);
            __JPH_VehicleConstraint_SetEnabled(_UnderlyingPtr, inEnabled ? (byte)1 : (byte)0);
        }

        /// Generated from method `JPH::VehicleConstraint::SetUserData`.
        public unsafe void SetUserData(UIntPtr inUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleConstraint_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleConstraint_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleConstraint_SetUserData(_Underlying *_this, UIntPtr inUserData);
            __JPH_VehicleConstraint_SetUserData(_UnderlyingPtr, inUserData);
        }
    }

    /// This is used for optional parameters of class `VehicleConstraint` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_VehicleConstraint`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleConstraint`/`Const_VehicleConstraint` directly.
    public class _InOptMut_VehicleConstraint
    {
        public VehicleConstraint? Opt;

        public _InOptMut_VehicleConstraint() {}
        public _InOptMut_VehicleConstraint(VehicleConstraint value) {Opt = value;}
        public static implicit operator _InOptMut_VehicleConstraint(VehicleConstraint value) {return new(value);}
    }

    /// This is used for optional parameters of class `VehicleConstraint` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_VehicleConstraint`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleConstraint`/`Const_VehicleConstraint` to pass it to the function.
    public class _InOptConst_VehicleConstraint
    {
        public Const_VehicleConstraint? Opt;

        public _InOptConst_VehicleConstraint() {}
        public _InOptConst_VehicleConstraint(Const_VehicleConstraint value) {Opt = value;}
        public static implicit operator _InOptConst_VehicleConstraint(Const_VehicleConstraint value) {return new(value);}
    }
}
