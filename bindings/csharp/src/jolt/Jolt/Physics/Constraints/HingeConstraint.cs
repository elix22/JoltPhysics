// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Hinge constraint settings, used to create a hinge constraint
        /// Generated from class `JPH::HingeConstraintSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraintSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::SerializableObject`
        ///     `JPH::RefTarget<JPH::ConstraintSettings>`
        ///     `JPH::ConstraintSettings`
        /// This is the const half of the class.
        public class Const_HingeConstraintSettings : Jolt.Object<Const_HingeConstraintSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraintSettings_Destroy(_Underlying *_this);
                __JPH_HingeConstraintSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_HingeConstraintSettings() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_SerializableObject(Const_HingeConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_SerializableObject._Underlying *__JPH_HingeConstraintSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.Const_SerializableObject ret = new(__JPH_HingeConstraintSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHConstraintSettings(Const_HingeConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHConstraintSettings._Underlying *__JPH_HingeConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHConstraintSettings ret = new(__JPH_HingeConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_ConstraintSettings(Const_HingeConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_ConstraintSettings._Underlying *__JPH_HingeConstraintSettings_UpcastTo_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.Const_ConstraintSettings ret = new(__JPH_HingeConstraintSettings_UpcastTo_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_TwoBodyConstraintSettings(Const_HingeConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_TwoBodyConstraintSettings._Underlying *__JPH_HingeConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(_Underlying *_this);
                Jolt.JPH.Const_TwoBodyConstraintSettings ret = new(__JPH_HingeConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_HingeConstraintSettings?(Jolt.JPH.Const_SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.Const_SerializableObject._Underlying *_this);
                var ptr = __JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_HingeConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_HingeConstraintSettings?(Jolt.JPH.Const_ConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(Jolt.JPH.Const_ConstraintSettings._Underlying *_this);
                var ptr = __JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_HingeConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_HingeConstraintSettings?(Jolt.JPH.Const_TwoBodyConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(Jolt.JPH.Const_TwoBodyConstraintSettings._Underlying *_this);
                var ptr = __JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_HingeConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// Rotation around the hinge axis will be limited between [mLimitsMin, mLimitsMax] where mLimitsMin e [-pi, 0] and mLimitsMax e [0, pi].
            /// Both angles are in radians.
            public unsafe float mLimitsMin
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mLimitsMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mLimitsMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_HingeConstraintSettings_Get_mLimitsMin(_Underlying *_this);
                    return *__JPH_HingeConstraintSettings_Get_mLimitsMin(_UnderlyingPtr);
                }
            }

            public unsafe float mLimitsMax
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mLimitsMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mLimitsMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_HingeConstraintSettings_Get_mLimitsMax(_Underlying *_this);
                    return *__JPH_HingeConstraintSettings_Get_mLimitsMax(_UnderlyingPtr);
                }
            }

            /// Maximum amount of torque (N m) to apply as friction when the constraint is not powered by a motor
            public unsafe float mMaxFrictionTorque
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mMaxFrictionTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mMaxFrictionTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_HingeConstraintSettings_Get_mMaxFrictionTorque(_Underlying *_this);
                    return *__JPH_HingeConstraintSettings_Get_mMaxFrictionTorque(_UnderlyingPtr);
                }
            }

            /// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
            public unsafe bool mEnabled
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_HingeConstraintSettings_Get_mEnabled(_Underlying *_this);
                    return *__JPH_HingeConstraintSettings_Get_mEnabled(_UnderlyingPtr);
                }
            }

            /// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
            /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
            public unsafe uint mConstraintPriority
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_HingeConstraintSettings_Get_mConstraintPriority(_Underlying *_this);
                    return *__JPH_HingeConstraintSettings_Get_mConstraintPriority(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public unsafe uint mNumVelocityStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_HingeConstraintSettings_Get_mNumVelocityStepsOverride(_Underlying *_this);
                    return *__JPH_HingeConstraintSettings_Get_mNumVelocityStepsOverride(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public unsafe uint mNumPositionStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_HingeConstraintSettings_Get_mNumPositionStepsOverride(_Underlying *_this);
                    return *__JPH_HingeConstraintSettings_Get_mNumPositionStepsOverride(_UnderlyingPtr);
                }
            }

            /// Size of constraint when drawing it through the debug renderer
            public unsafe float mDrawConstraintSize
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_HingeConstraintSettings_Get_mDrawConstraintSize(_Underlying *_this);
                    return *__JPH_HingeConstraintSettings_Get_mDrawConstraintSize(_UnderlyingPtr);
                }
            }

            /// User data value (can be used by application)
            public unsafe ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_HingeConstraintSettings_Get_mUserData(_Underlying *_this);
                    return *__JPH_HingeConstraintSettings_Get_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe Const_HingeConstraintSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_HingeConstraintSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.HingeConstraintSettings._Underlying *__JPH_HingeConstraintSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_HingeConstraintSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::HingeConstraintSettings::HingeConstraintSettings`.
            public unsafe Const_HingeConstraintSettings(Jolt.JPH._ByValue_HingeConstraintSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.HingeConstraintSettings._Underlying *__JPH_HingeConstraintSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.HingeConstraintSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_HingeConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::HingeConstraintSettings::HingeConstraintSettings`.
            public Const_HingeConstraintSettings(Const_HingeConstraintSettings _other) : this(new _ByValue_HingeConstraintSettings(_other)) {}

            /// Generated from constructor `JPH::HingeConstraintSettings::HingeConstraintSettings`.
            public Const_HingeConstraintSettings(HingeConstraintSettings _other) : this((Const_HingeConstraintSettings)_other) {}

            /// Generated from method `JPH::HingeConstraintSettings::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_HingeConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_HingeConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_HingeConstraintSettings_size_t(ulong inCount);
                return __Jolt_new_JPH_HingeConstraintSettings_size_t(inCount);
            }

            /// Generated from method `JPH::HingeConstraintSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_HingeConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_HingeConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_HingeConstraintSettings_void_ptr(void *inPointer);
                __Jolt_delete_JPH_HingeConstraintSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::HingeConstraintSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_HingeConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_HingeConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_HingeConstraintSettings_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_HingeConstraintSettings_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::HingeConstraintSettings::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_HingeConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_HingeConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_HingeConstraintSettings_size_t(ulong inCount);
                return __Jolt_new_array_JPH_HingeConstraintSettings_size_t(inCount);
            }

            /// Generated from method `JPH::HingeConstraintSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::HingeConstraintSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::HingeConstraintSettings::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_HingeConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_HingeConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_HingeConstraintSettings_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_HingeConstraintSettings_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::HingeConstraintSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_HingeConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_HingeConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_HingeConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_HingeConstraintSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::HingeConstraintSettings::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_HingeConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_HingeConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_HingeConstraintSettings_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_HingeConstraintSettings_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::HingeConstraintSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_HingeConstraintSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Create an instance of this constraint
            /// Generated from method `JPH::HingeConstraintSettings::Create`.
            public unsafe Jolt.JPH.TwoBodyConstraint? Create(Jolt.JPH.Body inBody1, Jolt.JPH.Body inBody2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_Create", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_Create", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TwoBodyConstraint._Underlying *__JPH_HingeConstraintSettings_Create(_Underlying *_this, Jolt.JPH.Body._Underlying *inBody1, Jolt.JPH.Body._Underlying *inBody2);
                var __c_ret = __JPH_HingeConstraintSettings_Create(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.TwoBodyConstraint(__c_ret, is_owning: false) : null;
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::HingeConstraintSettings::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraintSettings_SetEmbedded(_Underlying *_this);
                __JPH_HingeConstraintSettings_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::HingeConstraintSettings::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_HingeConstraintSettings_GetRefCount(_Underlying *_this);
                return __JPH_HingeConstraintSettings_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::HingeConstraintSettings::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraintSettings_AddRef(_Underlying *_this);
                __JPH_HingeConstraintSettings_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::HingeConstraintSettings::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraintSettings_Release(_Underlying *_this);
                __JPH_HingeConstraintSettings_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::HingeConstraintSettings::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_HingeConstraintSettings_sInternalGetRefCountOffset();
                return __JPH_HingeConstraintSettings_sInternalGetRefCountOffset();
            }
        }

        /// Hinge constraint settings, used to create a hinge constraint
        /// Generated from class `JPH::HingeConstraintSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraintSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::SerializableObject`
        ///     `JPH::RefTarget<JPH::ConstraintSettings>`
        ///     `JPH::ConstraintSettings`
        /// This is the non-const half of the class.
        public class HingeConstraintSettings : Const_HingeConstraintSettings
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.SerializableObject(HingeConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SerializableObject._Underlying *__JPH_HingeConstraintSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.SerializableObject ret = new(__JPH_HingeConstraintSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHConstraintSettings(HingeConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHConstraintSettings._Underlying *__JPH_HingeConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHConstraintSettings ret = new(__JPH_HingeConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.ConstraintSettings(HingeConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.ConstraintSettings._Underlying *__JPH_HingeConstraintSettings_UpcastTo_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.ConstraintSettings ret = new(__JPH_HingeConstraintSettings_UpcastTo_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.TwoBodyConstraintSettings(HingeConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TwoBodyConstraintSettings._Underlying *__JPH_HingeConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(_Underlying *_this);
                Jolt.JPH.TwoBodyConstraintSettings ret = new(__JPH_HingeConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator HingeConstraintSettings?(Jolt.JPH.SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.SerializableObject._Underlying *_this);
                var ptr = __JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                HingeConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator HingeConstraintSettings?(Jolt.JPH.ConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(Jolt.JPH.ConstraintSettings._Underlying *_this);
                var ptr = __JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                HingeConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator HingeConstraintSettings?(Jolt.JPH.TwoBodyConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(Jolt.JPH.TwoBodyConstraintSettings._Underlying *_this);
                var ptr = __JPH_HingeConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                HingeConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// Rotation around the hinge axis will be limited between [mLimitsMin, mLimitsMax] where mLimitsMin e [-pi, 0] and mLimitsMax e [0, pi].
            /// Both angles are in radians.
            public new unsafe ref float mLimitsMin
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mLimitsMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mLimitsMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_HingeConstraintSettings_GetMutable_mLimitsMin(_Underlying *_this);
                    return ref *__JPH_HingeConstraintSettings_GetMutable_mLimitsMin(_UnderlyingPtr);
                }
            }

            public new unsafe ref float mLimitsMax
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mLimitsMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mLimitsMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_HingeConstraintSettings_GetMutable_mLimitsMax(_Underlying *_this);
                    return ref *__JPH_HingeConstraintSettings_GetMutable_mLimitsMax(_UnderlyingPtr);
                }
            }

            /// Maximum amount of torque (N m) to apply as friction when the constraint is not powered by a motor
            public new unsafe ref float mMaxFrictionTorque
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mMaxFrictionTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mMaxFrictionTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_HingeConstraintSettings_GetMutable_mMaxFrictionTorque(_Underlying *_this);
                    return ref *__JPH_HingeConstraintSettings_GetMutable_mMaxFrictionTorque(_UnderlyingPtr);
                }
            }

            /// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
            public new unsafe ref bool mEnabled
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_HingeConstraintSettings_GetMutable_mEnabled(_Underlying *_this);
                    return ref *__JPH_HingeConstraintSettings_GetMutable_mEnabled(_UnderlyingPtr);
                }
            }

            /// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
            /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
            public new unsafe ref uint mConstraintPriority
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_HingeConstraintSettings_GetMutable_mConstraintPriority(_Underlying *_this);
                    return ref *__JPH_HingeConstraintSettings_GetMutable_mConstraintPriority(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public new unsafe ref uint mNumVelocityStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_HingeConstraintSettings_GetMutable_mNumVelocityStepsOverride(_Underlying *_this);
                    return ref *__JPH_HingeConstraintSettings_GetMutable_mNumVelocityStepsOverride(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public new unsafe ref uint mNumPositionStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_HingeConstraintSettings_GetMutable_mNumPositionStepsOverride(_Underlying *_this);
                    return ref *__JPH_HingeConstraintSettings_GetMutable_mNumPositionStepsOverride(_UnderlyingPtr);
                }
            }

            /// Size of constraint when drawing it through the debug renderer
            public new unsafe ref float mDrawConstraintSize
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_HingeConstraintSettings_GetMutable_mDrawConstraintSize(_Underlying *_this);
                    return ref *__JPH_HingeConstraintSettings_GetMutable_mDrawConstraintSize(_UnderlyingPtr);
                }
            }

            /// User data value (can be used by application)
            public new unsafe ref ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_HingeConstraintSettings_GetMutable_mUserData(_Underlying *_this);
                    return ref *__JPH_HingeConstraintSettings_GetMutable_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe HingeConstraintSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe HingeConstraintSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.HingeConstraintSettings._Underlying *__JPH_HingeConstraintSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_HingeConstraintSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::HingeConstraintSettings::HingeConstraintSettings`.
            public unsafe HingeConstraintSettings(Jolt.JPH._ByValue_HingeConstraintSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.HingeConstraintSettings._Underlying *__JPH_HingeConstraintSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.HingeConstraintSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_HingeConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::HingeConstraintSettings::HingeConstraintSettings`.
            public HingeConstraintSettings(Const_HingeConstraintSettings _other) : this(new _ByValue_HingeConstraintSettings(_other)) {}

            /// Generated from constructor `JPH::HingeConstraintSettings::HingeConstraintSettings`.
            public HingeConstraintSettings(HingeConstraintSettings _other) : this((Const_HingeConstraintSettings)_other) {}

            /// Generated from method `JPH::HingeConstraintSettings::operator=`.
            public unsafe Jolt.JPH.HingeConstraintSettings Assign(Jolt.JPH._ByValue_HingeConstraintSettings _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.HingeConstraintSettings._Underlying *__JPH_HingeConstraintSettings_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JPH.HingeConstraintSettings._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_HingeConstraintSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }
        }

        /// This is used as a function parameter when the underlying function receives `HingeConstraintSettings` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `HingeConstraintSettings`/`Const_HingeConstraintSettings` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_HingeConstraintSettings
        {
            #pragma warning disable CS0649
            internal readonly Const_HingeConstraintSettings? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_HingeConstraintSettings() {PassByMode = Jolt._PassBy.default_construct;}
            public _ByValue_HingeConstraintSettings(Const_HingeConstraintSettings new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
            public static implicit operator _ByValue_HingeConstraintSettings(Const_HingeConstraintSettings arg) {return new(arg);}
            public _ByValue_HingeConstraintSettings(Jolt._Moved<HingeConstraintSettings> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
            public static implicit operator _ByValue_HingeConstraintSettings(Jolt._Moved<HingeConstraintSettings> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `HingeConstraintSettings` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_HingeConstraintSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `HingeConstraintSettings`/`Const_HingeConstraintSettings` directly.
        public class _InOptMut_HingeConstraintSettings
        {
            public HingeConstraintSettings? Opt;

            public _InOptMut_HingeConstraintSettings() {}
            public _InOptMut_HingeConstraintSettings(HingeConstraintSettings value) {Opt = value;}
            public static implicit operator _InOptMut_HingeConstraintSettings(HingeConstraintSettings value) {return new(value);}
        }

        /// This is used for optional parameters of class `HingeConstraintSettings` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_HingeConstraintSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `HingeConstraintSettings`/`Const_HingeConstraintSettings` to pass it to the function.
        public class _InOptConst_HingeConstraintSettings
        {
            public Const_HingeConstraintSettings? Opt;

            public _InOptConst_HingeConstraintSettings() {}
            public _InOptConst_HingeConstraintSettings(Const_HingeConstraintSettings value) {Opt = value;}
            public static implicit operator _InOptConst_HingeConstraintSettings(Const_HingeConstraintSettings value) {return new(value);}
        }

        /// A hinge constraint constrains 2 bodies on a single point and allows only a single axis of rotation
        /// Generated from class `JPH::HingeConstraint`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraint`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::Constraint>`
        ///     `JPH::NonCopyable`
        ///     `JPH::Constraint`
        /// This is the const half of the class.
        public class Const_HingeConstraint : Jolt.Object<Const_HingeConstraint>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_Destroy(_Underlying *_this);
                __JPH_HingeConstraint_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_HingeConstraint() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHConstraint(Const_HingeConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHConstraint._Underlying *__JPH_HingeConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHConstraint ret = new(__JPH_HingeConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_HingeConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_HingeConstraint_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_HingeConstraint_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_Constraint(Const_HingeConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Constraint._Underlying *__JPH_HingeConstraint_UpcastTo_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.Const_Constraint ret = new(__JPH_HingeConstraint_UpcastTo_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_TwoBodyConstraint(Const_HingeConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_TwoBodyConstraint._Underlying *__JPH_HingeConstraint_UpcastTo_JPH_TwoBodyConstraint(_Underlying *_this);
                Jolt.JPH.Const_TwoBodyConstraint ret = new(__JPH_HingeConstraint_UpcastTo_JPH_TwoBodyConstraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_HingeConstraint?(Jolt.JPH.Const_Constraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HingeConstraint_DynamicDowncastFrom_JPH_Constraint(Jolt.JPH.Const_Constraint._Underlying *_this);
                var ptr = __JPH_HingeConstraint_DynamicDowncastFrom_JPH_Constraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_HingeConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_HingeConstraint?(Jolt.JPH.Const_TwoBodyConstraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HingeConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(Jolt.JPH.Const_TwoBodyConstraint._Underlying *_this);
                var ptr = __JPH_HingeConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_HingeConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe Const_HingeConstraint(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Construct hinge constraint
            /// Generated from constructor `JPH::HingeConstraint::HingeConstraint`.
            public unsafe Const_HingeConstraint(Jolt.JPH.Body inBody1, Jolt.JPH.Body inBody2, Jolt.JPH.Const_HingeConstraintSettings inSettings) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.HingeConstraint._Underlying *__JPH_HingeConstraint_Construct(Jolt.JPH.Body._Underlying *inBody1, Jolt.JPH.Body._Underlying *inBody2, Jolt.JPH.Const_HingeConstraintSettings._Underlying *inSettings);
                _UnderlyingPtr = __JPH_HingeConstraint_Construct(inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inSettings._UnderlyingPtr);
            }

            /// Generated from method `JPH::HingeConstraint::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_HingeConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_HingeConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_HingeConstraint_size_t(ulong inCount);
                return __Jolt_new_JPH_HingeConstraint_size_t(inCount);
            }

            /// Generated from method `JPH::HingeConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_HingeConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_HingeConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_HingeConstraint_void_ptr(void *inPointer);
                __Jolt_delete_JPH_HingeConstraint_void_ptr(inPointer);
            }

            /// Generated from method `JPH::HingeConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_HingeConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_HingeConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_HingeConstraint_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_HingeConstraint_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::HingeConstraint::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_HingeConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_HingeConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_HingeConstraint_size_t(ulong inCount);
                return __Jolt_new_array_JPH_HingeConstraint_size_t(inCount);
            }

            /// Generated from method `JPH::HingeConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_HingeConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_HingeConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_HingeConstraint_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_HingeConstraint_void_ptr(inPointer);
            }

            /// Generated from method `JPH::HingeConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_HingeConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_HingeConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_HingeConstraint_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_HingeConstraint_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::HingeConstraint::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_HingeConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_HingeConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_HingeConstraint_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_HingeConstraint_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::HingeConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_HingeConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_HingeConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_HingeConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_HingeConstraint_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::HingeConstraint::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_HingeConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_HingeConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_HingeConstraint_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_HingeConstraint_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::HingeConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_HingeConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_HingeConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_HingeConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_HingeConstraint_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Get the current rotation angle from the rest position
            /// Generated from method `JPH::HingeConstraint::GetCurrentAngle`.
            public unsafe float GetCurrentAngle()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetCurrentAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetCurrentAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_HingeConstraint_GetCurrentAngle(_Underlying *_this);
                return __JPH_HingeConstraint_GetCurrentAngle(_UnderlyingPtr);
            }

            /// Generated from method `JPH::HingeConstraint::GetMaxFrictionTorque`.
            public unsafe float GetMaxFrictionTorque()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetMaxFrictionTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetMaxFrictionTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_HingeConstraint_GetMaxFrictionTorque(_Underlying *_this);
                return __JPH_HingeConstraint_GetMaxFrictionTorque(_UnderlyingPtr);
            }

            /// Generated from method `JPH::HingeConstraint::GetTargetAngularVelocity`.
            public unsafe float GetTargetAngularVelocity()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetTargetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetTargetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_HingeConstraint_GetTargetAngularVelocity(_Underlying *_this);
                return __JPH_HingeConstraint_GetTargetAngularVelocity(_UnderlyingPtr);
            }

            /// Generated from method `JPH::HingeConstraint::GetTargetAngle`.
            public unsafe float GetTargetAngle()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetTargetAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetTargetAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_HingeConstraint_GetTargetAngle(_Underlying *_this);
                return __JPH_HingeConstraint_GetTargetAngle(_UnderlyingPtr);
            }

            /// Generated from method `JPH::HingeConstraint::GetLimitsMin`.
            public unsafe float GetLimitsMin()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetLimitsMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetLimitsMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_HingeConstraint_GetLimitsMin(_Underlying *_this);
                return __JPH_HingeConstraint_GetLimitsMin(_UnderlyingPtr);
            }

            /// Generated from method `JPH::HingeConstraint::GetLimitsMax`.
            public unsafe float GetLimitsMax()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetLimitsMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetLimitsMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_HingeConstraint_GetLimitsMax(_Underlying *_this);
                return __JPH_HingeConstraint_GetLimitsMax(_UnderlyingPtr);
            }

            /// Generated from method `JPH::HingeConstraint::HasLimits`.
            public unsafe bool HasLimits()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_HasLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_HasLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_HingeConstraint_HasLimits(_Underlying *_this);
                return __JPH_HingeConstraint_HasLimits(_UnderlyingPtr) != 0;
            }

            /// Generated from method `JPH::HingeConstraint::GetTotalLambdaRotationLimits`.
            public unsafe float GetTotalLambdaRotationLimits()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetTotalLambdaRotationLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetTotalLambdaRotationLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_HingeConstraint_GetTotalLambdaRotationLimits(_Underlying *_this);
                return __JPH_HingeConstraint_GetTotalLambdaRotationLimits(_UnderlyingPtr);
            }

            /// Generated from method `JPH::HingeConstraint::GetTotalLambdaMotor`.
            public unsafe float GetTotalLambdaMotor()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetTotalLambdaMotor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetTotalLambdaMotor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_HingeConstraint_GetTotalLambdaMotor(_Underlying *_this);
                return __JPH_HingeConstraint_GetTotalLambdaMotor(_UnderlyingPtr);
            }

            /// Solver interface
            /// Generated from method `JPH::HingeConstraint::IsActive`.
            public unsafe bool IsActive()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_HingeConstraint_IsActive(_Underlying *_this);
                return __JPH_HingeConstraint_IsActive(_UnderlyingPtr) != 0;
            }

            /// Access to the connected bodies
            /// Generated from method `JPH::HingeConstraint::GetBody1`.
            public unsafe Jolt.JPH.Body? GetBody1()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Body._Underlying *__JPH_HingeConstraint_GetBody1(_Underlying *_this);
                var __c_ret = __JPH_HingeConstraint_GetBody1(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Body(__c_ret, is_owning: false) : null;
            }

            /// Generated from method `JPH::HingeConstraint::GetBody2`.
            public unsafe Jolt.JPH.Body? GetBody2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Body._Underlying *__JPH_HingeConstraint_GetBody2(_Underlying *_this);
                var __c_ret = __JPH_HingeConstraint_GetBody2(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Body(__c_ret, is_owning: false) : null;
            }

            /// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
            /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
            /// Generated from method `JPH::HingeConstraint::GetConstraintPriority`.
            public unsafe uint GetConstraintPriority()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_HingeConstraint_GetConstraintPriority(_Underlying *_this);
                return __JPH_HingeConstraint_GetConstraintPriority(_UnderlyingPtr);
            }

            /// Generated from method `JPH::HingeConstraint::GetNumVelocityStepsOverride`.
            public unsafe uint GetNumVelocityStepsOverride()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_HingeConstraint_GetNumVelocityStepsOverride(_Underlying *_this);
                return __JPH_HingeConstraint_GetNumVelocityStepsOverride(_UnderlyingPtr);
            }

            /// Generated from method `JPH::HingeConstraint::GetNumPositionStepsOverride`.
            public unsafe uint GetNumPositionStepsOverride()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_HingeConstraint_GetNumPositionStepsOverride(_Underlying *_this);
                return __JPH_HingeConstraint_GetNumPositionStepsOverride(_UnderlyingPtr);
            }

            /// Test if a constraint is enabled.
            /// Generated from method `JPH::HingeConstraint::GetEnabled`.
            public unsafe bool GetEnabled()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_HingeConstraint_GetEnabled(_Underlying *_this);
                return __JPH_HingeConstraint_GetEnabled(_UnderlyingPtr) != 0;
            }

            /// Access to the user data, can be used for anything by the application
            /// Generated from method `JPH::HingeConstraint::GetUserData`.
            public unsafe ulong GetUserData()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_HingeConstraint_GetUserData(_Underlying *_this);
                return __JPH_HingeConstraint_GetUserData(_UnderlyingPtr);
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::HingeConstraint::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_SetEmbedded(_Underlying *_this);
                __JPH_HingeConstraint_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::HingeConstraint::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_HingeConstraint_GetRefCount(_Underlying *_this);
                return __JPH_HingeConstraint_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::HingeConstraint::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_AddRef(_Underlying *_this);
                __JPH_HingeConstraint_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::HingeConstraint::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_Release(_Underlying *_this);
                __JPH_HingeConstraint_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::HingeConstraint::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_HingeConstraint_sInternalGetRefCountOffset();
                return __JPH_HingeConstraint_sInternalGetRefCountOffset();
            }
        }

        /// A hinge constraint constrains 2 bodies on a single point and allows only a single axis of rotation
        /// Generated from class `JPH::HingeConstraint`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraint`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::Constraint>`
        ///     `JPH::NonCopyable`
        ///     `JPH::Constraint`
        /// This is the non-const half of the class.
        public class HingeConstraint : Const_HingeConstraint
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHConstraint(HingeConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHConstraint._Underlying *__JPH_HingeConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHConstraint ret = new(__JPH_HingeConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.NonCopyable(HingeConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_HingeConstraint_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_HingeConstraint_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Constraint(HingeConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Constraint._Underlying *__JPH_HingeConstraint_UpcastTo_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.Constraint ret = new(__JPH_HingeConstraint_UpcastTo_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.TwoBodyConstraint(HingeConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TwoBodyConstraint._Underlying *__JPH_HingeConstraint_UpcastTo_JPH_TwoBodyConstraint(_Underlying *_this);
                Jolt.JPH.TwoBodyConstraint ret = new(__JPH_HingeConstraint_UpcastTo_JPH_TwoBodyConstraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator HingeConstraint?(Jolt.JPH.Constraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HingeConstraint_DynamicDowncastFrom_JPH_Constraint(Jolt.JPH.Constraint._Underlying *_this);
                var ptr = __JPH_HingeConstraint_DynamicDowncastFrom_JPH_Constraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                HingeConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator HingeConstraint?(Jolt.JPH.TwoBodyConstraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_HingeConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(Jolt.JPH.TwoBodyConstraint._Underlying *_this);
                var ptr = __JPH_HingeConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                HingeConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe HingeConstraint(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Construct hinge constraint
            /// Generated from constructor `JPH::HingeConstraint::HingeConstraint`.
            public unsafe HingeConstraint(Jolt.JPH.Body inBody1, Jolt.JPH.Body inBody2, Jolt.JPH.Const_HingeConstraintSettings inSettings) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.HingeConstraint._Underlying *__JPH_HingeConstraint_Construct(Jolt.JPH.Body._Underlying *inBody1, Jolt.JPH.Body._Underlying *inBody2, Jolt.JPH.Const_HingeConstraintSettings._Underlying *inSettings);
                _UnderlyingPtr = __JPH_HingeConstraint_Construct(inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inSettings._UnderlyingPtr);
            }

            /// Generated from method `JPH::HingeConstraint::SetupVelocityConstraint`.
            public unsafe void SetupVelocityConstraint(float inDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_SetupVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_SetupVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_SetupVelocityConstraint(_Underlying *_this, float inDeltaTime);
                __JPH_HingeConstraint_SetupVelocityConstraint(_UnderlyingPtr, inDeltaTime);
            }

            /// Generated from method `JPH::HingeConstraint::ResetWarmStart`.
            public unsafe void ResetWarmStart()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_ResetWarmStart(_Underlying *_this);
                __JPH_HingeConstraint_ResetWarmStart(_UnderlyingPtr);
            }

            /// Generated from method `JPH::HingeConstraint::WarmStartVelocityConstraint`.
            public unsafe void WarmStartVelocityConstraint(float inWarmStartImpulseRatio)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_WarmStartVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_WarmStartVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_WarmStartVelocityConstraint(_Underlying *_this, float inWarmStartImpulseRatio);
                __JPH_HingeConstraint_WarmStartVelocityConstraint(_UnderlyingPtr, inWarmStartImpulseRatio);
            }

            /// Generated from method `JPH::HingeConstraint::SolveVelocityConstraint`.
            public unsafe bool SolveVelocityConstraint(float inDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_SolveVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_SolveVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_HingeConstraint_SolveVelocityConstraint(_Underlying *_this, float inDeltaTime);
                return __JPH_HingeConstraint_SolveVelocityConstraint(_UnderlyingPtr, inDeltaTime) != 0;
            }

            /// Generated from method `JPH::HingeConstraint::SolvePositionConstraint`.
            public unsafe bool SolvePositionConstraint(float inDeltaTime, float inBaumgarte)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_SolvePositionConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_SolvePositionConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_HingeConstraint_SolvePositionConstraint(_Underlying *_this, float inDeltaTime, float inBaumgarte);
                return __JPH_HingeConstraint_SolvePositionConstraint(_UnderlyingPtr, inDeltaTime, inBaumgarte) != 0;
            }

            // Friction control
            /// Generated from method `JPH::HingeConstraint::SetMaxFrictionTorque`.
            public unsafe void SetMaxFrictionTorque(float inFrictionTorque)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_SetMaxFrictionTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_SetMaxFrictionTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_SetMaxFrictionTorque(_Underlying *_this, float inFrictionTorque);
                __JPH_HingeConstraint_SetMaxFrictionTorque(_UnderlyingPtr, inFrictionTorque);
            }

            /// Generated from method `JPH::HingeConstraint::SetTargetAngularVelocity`.
            public unsafe void SetTargetAngularVelocity(float inAngularVelocity)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_SetTargetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_SetTargetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_SetTargetAngularVelocity(_Underlying *_this, float inAngularVelocity);
                __JPH_HingeConstraint_SetTargetAngularVelocity(_UnderlyingPtr, inAngularVelocity);
            }

            /// Generated from method `JPH::HingeConstraint::SetTargetAngle`.
            public unsafe void SetTargetAngle(float inAngle)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_SetTargetAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_SetTargetAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_SetTargetAngle(_Underlying *_this, float inAngle);
                __JPH_HingeConstraint_SetTargetAngle(_UnderlyingPtr, inAngle);
            }

            /// Update the rotation limits of the hinge, value in radians (see HingeConstraintSettings)
            /// Generated from method `JPH::HingeConstraint::SetLimits`.
            public unsafe void SetLimits(float inLimitsMin, float inLimitsMax)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_SetLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_SetLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_SetLimits(_Underlying *_this, float inLimitsMin, float inLimitsMax);
                __JPH_HingeConstraint_SetLimits(_UnderlyingPtr, inLimitsMin, inLimitsMax);
            }

            /// Generated from method `JPH::HingeConstraint::SetConstraintPriority`.
            public unsafe void SetConstraintPriority(uint inPriority)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_SetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_SetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_SetConstraintPriority(_Underlying *_this, uint inPriority);
                __JPH_HingeConstraint_SetConstraintPriority(_UnderlyingPtr, inPriority);
            }

            /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
            /// Generated from method `JPH::HingeConstraint::SetNumVelocityStepsOverride`.
            public unsafe void SetNumVelocityStepsOverride(uint inN)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_SetNumVelocityStepsOverride(_Underlying *_this, uint inN);
                __JPH_HingeConstraint_SetNumVelocityStepsOverride(_UnderlyingPtr, inN);
            }

            /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
            /// Generated from method `JPH::HingeConstraint::SetNumPositionStepsOverride`.
            public unsafe void SetNumPositionStepsOverride(uint inN)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_SetNumPositionStepsOverride(_Underlying *_this, uint inN);
                __JPH_HingeConstraint_SetNumPositionStepsOverride(_UnderlyingPtr, inN);
            }

            /// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
            /// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
            /// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
            /// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
            /// Generated from method `JPH::HingeConstraint::SetEnabled`.
            public unsafe void SetEnabled(bool inEnabled)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_SetEnabled(_Underlying *_this, byte inEnabled);
                __JPH_HingeConstraint_SetEnabled(_UnderlyingPtr, inEnabled ? (byte)1 : (byte)0);
            }

            /// Generated from method `JPH::HingeConstraint::SetUserData`.
            public unsafe void SetUserData(ulong inUserData)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_HingeConstraint_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_HingeConstraint_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_HingeConstraint_SetUserData(_Underlying *_this, ulong inUserData);
                __JPH_HingeConstraint_SetUserData(_UnderlyingPtr, inUserData);
            }
        }

        /// This is used for optional parameters of class `HingeConstraint` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_HingeConstraint`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `HingeConstraint`/`Const_HingeConstraint` directly.
        public class _InOptMut_HingeConstraint
        {
            public HingeConstraint? Opt;

            public _InOptMut_HingeConstraint() {}
            public _InOptMut_HingeConstraint(HingeConstraint value) {Opt = value;}
            public static implicit operator _InOptMut_HingeConstraint(HingeConstraint value) {return new(value);}
        }

        /// This is used for optional parameters of class `HingeConstraint` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_HingeConstraint`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `HingeConstraint`/`Const_HingeConstraint` to pass it to the function.
        public class _InOptConst_HingeConstraint
        {
            public Const_HingeConstraint? Opt;

            public _InOptConst_HingeConstraint() {}
            public _InOptConst_HingeConstraint(Const_HingeConstraint value) {Opt = value;}
            public static implicit operator _InOptConst_HingeConstraint(Const_HingeConstraint value) {return new(value);}
        }
    }
}
