// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Distance constraint settings, used to create a distance constraint
        /// Generated from class `JPH::DistanceConstraintSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraintSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::SerializableObject`
        ///     `JPH::RefTarget<JPH::ConstraintSettings>`
        ///     `JPH::ConstraintSettings`
        /// This is the const half of the class.
        public class Const_DistanceConstraintSettings : Jolt.Object<Const_DistanceConstraintSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraintSettings_Destroy(_Underlying *_this);
                __JPH_DistanceConstraintSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_DistanceConstraintSettings() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_SerializableObject(Const_DistanceConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_SerializableObject._Underlying *__JPH_DistanceConstraintSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.Const_SerializableObject ret = new(__JPH_DistanceConstraintSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHConstraintSettings(Const_DistanceConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHConstraintSettings._Underlying *__JPH_DistanceConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHConstraintSettings ret = new(__JPH_DistanceConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_ConstraintSettings(Const_DistanceConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_ConstraintSettings._Underlying *__JPH_DistanceConstraintSettings_UpcastTo_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.Const_ConstraintSettings ret = new(__JPH_DistanceConstraintSettings_UpcastTo_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_TwoBodyConstraintSettings(Const_DistanceConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_TwoBodyConstraintSettings._Underlying *__JPH_DistanceConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(_Underlying *_this);
                Jolt.JPH.Const_TwoBodyConstraintSettings ret = new(__JPH_DistanceConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_DistanceConstraintSettings?(Jolt.JPH.Const_SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.Const_SerializableObject._Underlying *_this);
                var ptr = __JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_DistanceConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_DistanceConstraintSettings?(Jolt.JPH.Const_ConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(Jolt.JPH.Const_ConstraintSettings._Underlying *_this);
                var ptr = __JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_DistanceConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_DistanceConstraintSettings?(Jolt.JPH.Const_TwoBodyConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(Jolt.JPH.Const_TwoBodyConstraintSettings._Underlying *_this);
                var ptr = __JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_DistanceConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// Ability to override the distance range at which the two points are kept apart. If the value is negative, it will be replaced by the distance between mPoint1 and mPoint2 (works only if mSpace is world space).
            public unsafe float mMinDistance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mMinDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mMinDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_DistanceConstraintSettings_Get_mMinDistance(_Underlying *_this);
                    return *__JPH_DistanceConstraintSettings_Get_mMinDistance(_UnderlyingPtr);
                }
            }

            public unsafe float mMaxDistance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mMaxDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mMaxDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_DistanceConstraintSettings_Get_mMaxDistance(_Underlying *_this);
                    return *__JPH_DistanceConstraintSettings_Get_mMaxDistance(_UnderlyingPtr);
                }
            }

            /// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
            public unsafe bool mEnabled
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_DistanceConstraintSettings_Get_mEnabled(_Underlying *_this);
                    return *__JPH_DistanceConstraintSettings_Get_mEnabled(_UnderlyingPtr);
                }
            }

            /// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
            /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
            public unsafe uint mConstraintPriority
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_DistanceConstraintSettings_Get_mConstraintPriority(_Underlying *_this);
                    return *__JPH_DistanceConstraintSettings_Get_mConstraintPriority(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public unsafe uint mNumVelocityStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_DistanceConstraintSettings_Get_mNumVelocityStepsOverride(_Underlying *_this);
                    return *__JPH_DistanceConstraintSettings_Get_mNumVelocityStepsOverride(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public unsafe uint mNumPositionStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_DistanceConstraintSettings_Get_mNumPositionStepsOverride(_Underlying *_this);
                    return *__JPH_DistanceConstraintSettings_Get_mNumPositionStepsOverride(_UnderlyingPtr);
                }
            }

            /// Size of constraint when drawing it through the debug renderer
            public unsafe float mDrawConstraintSize
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_DistanceConstraintSettings_Get_mDrawConstraintSize(_Underlying *_this);
                    return *__JPH_DistanceConstraintSettings_Get_mDrawConstraintSize(_UnderlyingPtr);
                }
            }

            /// User data value (can be used by application)
            public unsafe ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_DistanceConstraintSettings_Get_mUserData(_Underlying *_this);
                    return *__JPH_DistanceConstraintSettings_Get_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe Const_DistanceConstraintSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_DistanceConstraintSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DistanceConstraintSettings._Underlying *__JPH_DistanceConstraintSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_DistanceConstraintSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::DistanceConstraintSettings::DistanceConstraintSettings`.
            public unsafe Const_DistanceConstraintSettings(Jolt.JPH._ByValue_DistanceConstraintSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DistanceConstraintSettings._Underlying *__JPH_DistanceConstraintSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.DistanceConstraintSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_DistanceConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::DistanceConstraintSettings::DistanceConstraintSettings`.
            public Const_DistanceConstraintSettings(Const_DistanceConstraintSettings _other) : this(new _ByValue_DistanceConstraintSettings(_other)) {}

            /// Generated from constructor `JPH::DistanceConstraintSettings::DistanceConstraintSettings`.
            public Const_DistanceConstraintSettings(DistanceConstraintSettings _other) : this((Const_DistanceConstraintSettings)_other) {}

            /// Generated from method `JPH::DistanceConstraintSettings::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_DistanceConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_DistanceConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_DistanceConstraintSettings_size_t(ulong inCount);
                return __Jolt_new_JPH_DistanceConstraintSettings_size_t(inCount);
            }

            /// Generated from method `JPH::DistanceConstraintSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DistanceConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DistanceConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_DistanceConstraintSettings_void_ptr(void *inPointer);
                __Jolt_delete_JPH_DistanceConstraintSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::DistanceConstraintSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DistanceConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DistanceConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_DistanceConstraintSettings_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_DistanceConstraintSettings_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::DistanceConstraintSettings::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_DistanceConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_DistanceConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_DistanceConstraintSettings_size_t(ulong inCount);
                return __Jolt_new_array_JPH_DistanceConstraintSettings_size_t(inCount);
            }

            /// Generated from method `JPH::DistanceConstraintSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::DistanceConstraintSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::DistanceConstraintSettings::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_DistanceConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_DistanceConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_DistanceConstraintSettings_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_DistanceConstraintSettings_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::DistanceConstraintSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DistanceConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DistanceConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_DistanceConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_DistanceConstraintSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::DistanceConstraintSettings::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_DistanceConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_DistanceConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_DistanceConstraintSettings_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_DistanceConstraintSettings_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::DistanceConstraintSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_DistanceConstraintSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Create an instance of this constraint
            /// Generated from method `JPH::DistanceConstraintSettings::Create`.
            public unsafe Jolt.JPH.TwoBodyConstraint? Create(Jolt.JPH.Body inBody1, Jolt.JPH.Body inBody2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Create", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Create", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TwoBodyConstraint._Underlying *__JPH_DistanceConstraintSettings_Create(_Underlying *_this, Jolt.JPH.Body._Underlying *inBody1, Jolt.JPH.Body._Underlying *inBody2);
                var __c_ret = __JPH_DistanceConstraintSettings_Create(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.TwoBodyConstraint(__c_ret, is_owning: false) : null;
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::DistanceConstraintSettings::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraintSettings_SetEmbedded(_Underlying *_this);
                __JPH_DistanceConstraintSettings_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::DistanceConstraintSettings::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_DistanceConstraintSettings_GetRefCount(_Underlying *_this);
                return __JPH_DistanceConstraintSettings_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::DistanceConstraintSettings::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraintSettings_AddRef(_Underlying *_this);
                __JPH_DistanceConstraintSettings_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::DistanceConstraintSettings::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraintSettings_Release(_Underlying *_this);
                __JPH_DistanceConstraintSettings_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::DistanceConstraintSettings::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_DistanceConstraintSettings_sInternalGetRefCountOffset();
                return __JPH_DistanceConstraintSettings_sInternalGetRefCountOffset();
            }
        }

        /// Distance constraint settings, used to create a distance constraint
        /// Generated from class `JPH::DistanceConstraintSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraintSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::SerializableObject`
        ///     `JPH::RefTarget<JPH::ConstraintSettings>`
        ///     `JPH::ConstraintSettings`
        /// This is the non-const half of the class.
        public class DistanceConstraintSettings : Const_DistanceConstraintSettings
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.SerializableObject(DistanceConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SerializableObject._Underlying *__JPH_DistanceConstraintSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.SerializableObject ret = new(__JPH_DistanceConstraintSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHConstraintSettings(DistanceConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHConstraintSettings._Underlying *__JPH_DistanceConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHConstraintSettings ret = new(__JPH_DistanceConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.ConstraintSettings(DistanceConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.ConstraintSettings._Underlying *__JPH_DistanceConstraintSettings_UpcastTo_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.ConstraintSettings ret = new(__JPH_DistanceConstraintSettings_UpcastTo_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.TwoBodyConstraintSettings(DistanceConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TwoBodyConstraintSettings._Underlying *__JPH_DistanceConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(_Underlying *_this);
                Jolt.JPH.TwoBodyConstraintSettings ret = new(__JPH_DistanceConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator DistanceConstraintSettings?(Jolt.JPH.SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.SerializableObject._Underlying *_this);
                var ptr = __JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                DistanceConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator DistanceConstraintSettings?(Jolt.JPH.ConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(Jolt.JPH.ConstraintSettings._Underlying *_this);
                var ptr = __JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                DistanceConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator DistanceConstraintSettings?(Jolt.JPH.TwoBodyConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(Jolt.JPH.TwoBodyConstraintSettings._Underlying *_this);
                var ptr = __JPH_DistanceConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                DistanceConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// Ability to override the distance range at which the two points are kept apart. If the value is negative, it will be replaced by the distance between mPoint1 and mPoint2 (works only if mSpace is world space).
            public new unsafe ref float mMinDistance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mMinDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mMinDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_DistanceConstraintSettings_GetMutable_mMinDistance(_Underlying *_this);
                    return ref *__JPH_DistanceConstraintSettings_GetMutable_mMinDistance(_UnderlyingPtr);
                }
            }

            public new unsafe ref float mMaxDistance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mMaxDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mMaxDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_DistanceConstraintSettings_GetMutable_mMaxDistance(_Underlying *_this);
                    return ref *__JPH_DistanceConstraintSettings_GetMutable_mMaxDistance(_UnderlyingPtr);
                }
            }

            /// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
            public new unsafe ref bool mEnabled
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_DistanceConstraintSettings_GetMutable_mEnabled(_Underlying *_this);
                    return ref *__JPH_DistanceConstraintSettings_GetMutable_mEnabled(_UnderlyingPtr);
                }
            }

            /// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
            /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
            public new unsafe ref uint mConstraintPriority
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_DistanceConstraintSettings_GetMutable_mConstraintPriority(_Underlying *_this);
                    return ref *__JPH_DistanceConstraintSettings_GetMutable_mConstraintPriority(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public new unsafe ref uint mNumVelocityStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_DistanceConstraintSettings_GetMutable_mNumVelocityStepsOverride(_Underlying *_this);
                    return ref *__JPH_DistanceConstraintSettings_GetMutable_mNumVelocityStepsOverride(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public new unsafe ref uint mNumPositionStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_DistanceConstraintSettings_GetMutable_mNumPositionStepsOverride(_Underlying *_this);
                    return ref *__JPH_DistanceConstraintSettings_GetMutable_mNumPositionStepsOverride(_UnderlyingPtr);
                }
            }

            /// Size of constraint when drawing it through the debug renderer
            public new unsafe ref float mDrawConstraintSize
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_DistanceConstraintSettings_GetMutable_mDrawConstraintSize(_Underlying *_this);
                    return ref *__JPH_DistanceConstraintSettings_GetMutable_mDrawConstraintSize(_UnderlyingPtr);
                }
            }

            /// User data value (can be used by application)
            public new unsafe ref ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_DistanceConstraintSettings_GetMutable_mUserData(_Underlying *_this);
                    return ref *__JPH_DistanceConstraintSettings_GetMutable_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe DistanceConstraintSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe DistanceConstraintSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DistanceConstraintSettings._Underlying *__JPH_DistanceConstraintSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_DistanceConstraintSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::DistanceConstraintSettings::DistanceConstraintSettings`.
            public unsafe DistanceConstraintSettings(Jolt.JPH._ByValue_DistanceConstraintSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DistanceConstraintSettings._Underlying *__JPH_DistanceConstraintSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.DistanceConstraintSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_DistanceConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::DistanceConstraintSettings::DistanceConstraintSettings`.
            public DistanceConstraintSettings(Const_DistanceConstraintSettings _other) : this(new _ByValue_DistanceConstraintSettings(_other)) {}

            /// Generated from constructor `JPH::DistanceConstraintSettings::DistanceConstraintSettings`.
            public DistanceConstraintSettings(DistanceConstraintSettings _other) : this((Const_DistanceConstraintSettings)_other) {}

            /// Generated from method `JPH::DistanceConstraintSettings::operator=`.
            public unsafe Jolt.JPH.DistanceConstraintSettings Assign(Jolt.JPH._ByValue_DistanceConstraintSettings _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DistanceConstraintSettings._Underlying *__JPH_DistanceConstraintSettings_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JPH.DistanceConstraintSettings._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_DistanceConstraintSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }
        }

        /// This is used as a function parameter when the underlying function receives `DistanceConstraintSettings` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `DistanceConstraintSettings`/`Const_DistanceConstraintSettings` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_DistanceConstraintSettings
        {
            #pragma warning disable CS0649
            internal readonly Const_DistanceConstraintSettings? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_DistanceConstraintSettings() {PassByMode = Jolt._PassBy.default_construct;}
            public _ByValue_DistanceConstraintSettings(Const_DistanceConstraintSettings new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
            public static implicit operator _ByValue_DistanceConstraintSettings(Const_DistanceConstraintSettings arg) {return new(arg);}
            public _ByValue_DistanceConstraintSettings(Jolt._Moved<DistanceConstraintSettings> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
            public static implicit operator _ByValue_DistanceConstraintSettings(Jolt._Moved<DistanceConstraintSettings> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `DistanceConstraintSettings` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_DistanceConstraintSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `DistanceConstraintSettings`/`Const_DistanceConstraintSettings` directly.
        public class _InOptMut_DistanceConstraintSettings
        {
            public DistanceConstraintSettings? Opt;

            public _InOptMut_DistanceConstraintSettings() {}
            public _InOptMut_DistanceConstraintSettings(DistanceConstraintSettings value) {Opt = value;}
            public static implicit operator _InOptMut_DistanceConstraintSettings(DistanceConstraintSettings value) {return new(value);}
        }

        /// This is used for optional parameters of class `DistanceConstraintSettings` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_DistanceConstraintSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `DistanceConstraintSettings`/`Const_DistanceConstraintSettings` to pass it to the function.
        public class _InOptConst_DistanceConstraintSettings
        {
            public Const_DistanceConstraintSettings? Opt;

            public _InOptConst_DistanceConstraintSettings() {}
            public _InOptConst_DistanceConstraintSettings(Const_DistanceConstraintSettings value) {Opt = value;}
            public static implicit operator _InOptConst_DistanceConstraintSettings(Const_DistanceConstraintSettings value) {return new(value);}
        }

        /// This constraint is a stiff spring that holds 2 points at a fixed distance from each other
        /// Generated from class `JPH::DistanceConstraint`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraint`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::Constraint>`
        ///     `JPH::NonCopyable`
        ///     `JPH::Constraint`
        /// This is the const half of the class.
        public class Const_DistanceConstraint : Jolt.Object<Const_DistanceConstraint>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraint_Destroy(_Underlying *_this);
                __JPH_DistanceConstraint_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_DistanceConstraint() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHConstraint(Const_DistanceConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHConstraint._Underlying *__JPH_DistanceConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHConstraint ret = new(__JPH_DistanceConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_DistanceConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_DistanceConstraint_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_DistanceConstraint_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_Constraint(Const_DistanceConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Constraint._Underlying *__JPH_DistanceConstraint_UpcastTo_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.Const_Constraint ret = new(__JPH_DistanceConstraint_UpcastTo_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_TwoBodyConstraint(Const_DistanceConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_TwoBodyConstraint._Underlying *__JPH_DistanceConstraint_UpcastTo_JPH_TwoBodyConstraint(_Underlying *_this);
                Jolt.JPH.Const_TwoBodyConstraint ret = new(__JPH_DistanceConstraint_UpcastTo_JPH_TwoBodyConstraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_DistanceConstraint?(Jolt.JPH.Const_Constraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_DistanceConstraint_DynamicDowncastFrom_JPH_Constraint(Jolt.JPH.Const_Constraint._Underlying *_this);
                var ptr = __JPH_DistanceConstraint_DynamicDowncastFrom_JPH_Constraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_DistanceConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_DistanceConstraint?(Jolt.JPH.Const_TwoBodyConstraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_DistanceConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(Jolt.JPH.Const_TwoBodyConstraint._Underlying *_this);
                var ptr = __JPH_DistanceConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_DistanceConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe Const_DistanceConstraint(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Construct distance constraint
            /// Generated from constructor `JPH::DistanceConstraint::DistanceConstraint`.
            public unsafe Const_DistanceConstraint(Jolt.JPH.Body inBody1, Jolt.JPH.Body inBody2, Jolt.JPH.Const_DistanceConstraintSettings inSettings) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DistanceConstraint._Underlying *__JPH_DistanceConstraint_Construct(Jolt.JPH.Body._Underlying *inBody1, Jolt.JPH.Body._Underlying *inBody2, Jolt.JPH.Const_DistanceConstraintSettings._Underlying *inSettings);
                _UnderlyingPtr = __JPH_DistanceConstraint_Construct(inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inSettings._UnderlyingPtr);
            }

            /// Generated from method `JPH::DistanceConstraint::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_DistanceConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_DistanceConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_DistanceConstraint_size_t(ulong inCount);
                return __Jolt_new_JPH_DistanceConstraint_size_t(inCount);
            }

            /// Generated from method `JPH::DistanceConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DistanceConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DistanceConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_DistanceConstraint_void_ptr(void *inPointer);
                __Jolt_delete_JPH_DistanceConstraint_void_ptr(inPointer);
            }

            /// Generated from method `JPH::DistanceConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DistanceConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DistanceConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_DistanceConstraint_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_DistanceConstraint_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::DistanceConstraint::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_DistanceConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_DistanceConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_DistanceConstraint_size_t(ulong inCount);
                return __Jolt_new_array_JPH_DistanceConstraint_size_t(inCount);
            }

            /// Generated from method `JPH::DistanceConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DistanceConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DistanceConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_DistanceConstraint_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_DistanceConstraint_void_ptr(inPointer);
            }

            /// Generated from method `JPH::DistanceConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DistanceConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DistanceConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_DistanceConstraint_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_DistanceConstraint_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::DistanceConstraint::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_DistanceConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_DistanceConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_DistanceConstraint_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_DistanceConstraint_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::DistanceConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DistanceConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DistanceConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_DistanceConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_DistanceConstraint_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::DistanceConstraint::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_DistanceConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_DistanceConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_DistanceConstraint_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_DistanceConstraint_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::DistanceConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DistanceConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DistanceConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_DistanceConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_DistanceConstraint_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::DistanceConstraint::GetMinDistance`.
            public unsafe float GetMinDistance()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_GetMinDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_GetMinDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_DistanceConstraint_GetMinDistance(_Underlying *_this);
                return __JPH_DistanceConstraint_GetMinDistance(_UnderlyingPtr);
            }

            /// Generated from method `JPH::DistanceConstraint::GetMaxDistance`.
            public unsafe float GetMaxDistance()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_GetMaxDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_GetMaxDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_DistanceConstraint_GetMaxDistance(_Underlying *_this);
                return __JPH_DistanceConstraint_GetMaxDistance(_UnderlyingPtr);
            }

            ///@name Get Lagrange multiplier from last physics update (the linear impulse applied to satisfy the constraint)
            /// Generated from method `JPH::DistanceConstraint::GetTotalLambdaPosition`.
            public unsafe float GetTotalLambdaPosition()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_GetTotalLambdaPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_GetTotalLambdaPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_DistanceConstraint_GetTotalLambdaPosition(_Underlying *_this);
                return __JPH_DistanceConstraint_GetTotalLambdaPosition(_UnderlyingPtr);
            }

            /// Solver interface
            /// Generated from method `JPH::DistanceConstraint::IsActive`.
            public unsafe bool IsActive()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_DistanceConstraint_IsActive(_Underlying *_this);
                return __JPH_DistanceConstraint_IsActive(_UnderlyingPtr) != 0;
            }

            /// Access to the connected bodies
            /// Generated from method `JPH::DistanceConstraint::GetBody1`.
            public unsafe Jolt.JPH.Body? GetBody1()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_GetBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_GetBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Body._Underlying *__JPH_DistanceConstraint_GetBody1(_Underlying *_this);
                var __c_ret = __JPH_DistanceConstraint_GetBody1(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Body(__c_ret, is_owning: false) : null;
            }

            /// Generated from method `JPH::DistanceConstraint::GetBody2`.
            public unsafe Jolt.JPH.Body? GetBody2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_GetBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_GetBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Body._Underlying *__JPH_DistanceConstraint_GetBody2(_Underlying *_this);
                var __c_ret = __JPH_DistanceConstraint_GetBody2(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Body(__c_ret, is_owning: false) : null;
            }

            /// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
            /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
            /// Generated from method `JPH::DistanceConstraint::GetConstraintPriority`.
            public unsafe uint GetConstraintPriority()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_GetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_GetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_DistanceConstraint_GetConstraintPriority(_Underlying *_this);
                return __JPH_DistanceConstraint_GetConstraintPriority(_UnderlyingPtr);
            }

            /// Generated from method `JPH::DistanceConstraint::GetNumVelocityStepsOverride`.
            public unsafe uint GetNumVelocityStepsOverride()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_DistanceConstraint_GetNumVelocityStepsOverride(_Underlying *_this);
                return __JPH_DistanceConstraint_GetNumVelocityStepsOverride(_UnderlyingPtr);
            }

            /// Generated from method `JPH::DistanceConstraint::GetNumPositionStepsOverride`.
            public unsafe uint GetNumPositionStepsOverride()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_DistanceConstraint_GetNumPositionStepsOverride(_Underlying *_this);
                return __JPH_DistanceConstraint_GetNumPositionStepsOverride(_UnderlyingPtr);
            }

            /// Test if a constraint is enabled.
            /// Generated from method `JPH::DistanceConstraint::GetEnabled`.
            public unsafe bool GetEnabled()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_DistanceConstraint_GetEnabled(_Underlying *_this);
                return __JPH_DistanceConstraint_GetEnabled(_UnderlyingPtr) != 0;
            }

            /// Access to the user data, can be used for anything by the application
            /// Generated from method `JPH::DistanceConstraint::GetUserData`.
            public unsafe ulong GetUserData()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_DistanceConstraint_GetUserData(_Underlying *_this);
                return __JPH_DistanceConstraint_GetUserData(_UnderlyingPtr);
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::DistanceConstraint::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraint_SetEmbedded(_Underlying *_this);
                __JPH_DistanceConstraint_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::DistanceConstraint::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_DistanceConstraint_GetRefCount(_Underlying *_this);
                return __JPH_DistanceConstraint_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::DistanceConstraint::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraint_AddRef(_Underlying *_this);
                __JPH_DistanceConstraint_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::DistanceConstraint::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraint_Release(_Underlying *_this);
                __JPH_DistanceConstraint_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::DistanceConstraint::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_DistanceConstraint_sInternalGetRefCountOffset();
                return __JPH_DistanceConstraint_sInternalGetRefCountOffset();
            }
        }

        /// This constraint is a stiff spring that holds 2 points at a fixed distance from each other
        /// Generated from class `JPH::DistanceConstraint`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraint`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::Constraint>`
        ///     `JPH::NonCopyable`
        ///     `JPH::Constraint`
        /// This is the non-const half of the class.
        public class DistanceConstraint : Const_DistanceConstraint
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHConstraint(DistanceConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHConstraint._Underlying *__JPH_DistanceConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHConstraint ret = new(__JPH_DistanceConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.NonCopyable(DistanceConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_DistanceConstraint_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_DistanceConstraint_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Constraint(DistanceConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Constraint._Underlying *__JPH_DistanceConstraint_UpcastTo_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.Constraint ret = new(__JPH_DistanceConstraint_UpcastTo_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.TwoBodyConstraint(DistanceConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TwoBodyConstraint._Underlying *__JPH_DistanceConstraint_UpcastTo_JPH_TwoBodyConstraint(_Underlying *_this);
                Jolt.JPH.TwoBodyConstraint ret = new(__JPH_DistanceConstraint_UpcastTo_JPH_TwoBodyConstraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator DistanceConstraint?(Jolt.JPH.Constraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_DistanceConstraint_DynamicDowncastFrom_JPH_Constraint(Jolt.JPH.Constraint._Underlying *_this);
                var ptr = __JPH_DistanceConstraint_DynamicDowncastFrom_JPH_Constraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                DistanceConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator DistanceConstraint?(Jolt.JPH.TwoBodyConstraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_DistanceConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(Jolt.JPH.TwoBodyConstraint._Underlying *_this);
                var ptr = __JPH_DistanceConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                DistanceConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe DistanceConstraint(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Construct distance constraint
            /// Generated from constructor `JPH::DistanceConstraint::DistanceConstraint`.
            public unsafe DistanceConstraint(Jolt.JPH.Body inBody1, Jolt.JPH.Body inBody2, Jolt.JPH.Const_DistanceConstraintSettings inSettings) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.DistanceConstraint._Underlying *__JPH_DistanceConstraint_Construct(Jolt.JPH.Body._Underlying *inBody1, Jolt.JPH.Body._Underlying *inBody2, Jolt.JPH.Const_DistanceConstraintSettings._Underlying *inSettings);
                _UnderlyingPtr = __JPH_DistanceConstraint_Construct(inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inSettings._UnderlyingPtr);
            }

            /// Generated from method `JPH::DistanceConstraint::SetupVelocityConstraint`.
            public unsafe void SetupVelocityConstraint(float inDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_SetupVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_SetupVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraint_SetupVelocityConstraint(_Underlying *_this, float inDeltaTime);
                __JPH_DistanceConstraint_SetupVelocityConstraint(_UnderlyingPtr, inDeltaTime);
            }

            /// Generated from method `JPH::DistanceConstraint::ResetWarmStart`.
            public unsafe void ResetWarmStart()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraint_ResetWarmStart(_Underlying *_this);
                __JPH_DistanceConstraint_ResetWarmStart(_UnderlyingPtr);
            }

            /// Generated from method `JPH::DistanceConstraint::WarmStartVelocityConstraint`.
            public unsafe void WarmStartVelocityConstraint(float inWarmStartImpulseRatio)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_WarmStartVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_WarmStartVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraint_WarmStartVelocityConstraint(_Underlying *_this, float inWarmStartImpulseRatio);
                __JPH_DistanceConstraint_WarmStartVelocityConstraint(_UnderlyingPtr, inWarmStartImpulseRatio);
            }

            /// Generated from method `JPH::DistanceConstraint::SolveVelocityConstraint`.
            public unsafe bool SolveVelocityConstraint(float inDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_SolveVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_SolveVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_DistanceConstraint_SolveVelocityConstraint(_Underlying *_this, float inDeltaTime);
                return __JPH_DistanceConstraint_SolveVelocityConstraint(_UnderlyingPtr, inDeltaTime) != 0;
            }

            /// Generated from method `JPH::DistanceConstraint::SolvePositionConstraint`.
            public unsafe bool SolvePositionConstraint(float inDeltaTime, float inBaumgarte)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_SolvePositionConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_SolvePositionConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_DistanceConstraint_SolvePositionConstraint(_Underlying *_this, float inDeltaTime, float inBaumgarte);
                return __JPH_DistanceConstraint_SolvePositionConstraint(_UnderlyingPtr, inDeltaTime, inBaumgarte) != 0;
            }

            /// Update the minimum and maximum distance for the constraint
            /// Generated from method `JPH::DistanceConstraint::SetDistance`.
            public unsafe void SetDistance(float inMinDistance, float inMaxDistance)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_SetDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_SetDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraint_SetDistance(_Underlying *_this, float inMinDistance, float inMaxDistance);
                __JPH_DistanceConstraint_SetDistance(_UnderlyingPtr, inMinDistance, inMaxDistance);
            }

            /// Generated from method `JPH::DistanceConstraint::SetConstraintPriority`.
            public unsafe void SetConstraintPriority(uint inPriority)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_SetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_SetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraint_SetConstraintPriority(_Underlying *_this, uint inPriority);
                __JPH_DistanceConstraint_SetConstraintPriority(_UnderlyingPtr, inPriority);
            }

            /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
            /// Generated from method `JPH::DistanceConstraint::SetNumVelocityStepsOverride`.
            public unsafe void SetNumVelocityStepsOverride(uint inN)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraint_SetNumVelocityStepsOverride(_Underlying *_this, uint inN);
                __JPH_DistanceConstraint_SetNumVelocityStepsOverride(_UnderlyingPtr, inN);
            }

            /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
            /// Generated from method `JPH::DistanceConstraint::SetNumPositionStepsOverride`.
            public unsafe void SetNumPositionStepsOverride(uint inN)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraint_SetNumPositionStepsOverride(_Underlying *_this, uint inN);
                __JPH_DistanceConstraint_SetNumPositionStepsOverride(_UnderlyingPtr, inN);
            }

            /// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
            /// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
            /// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
            /// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
            /// Generated from method `JPH::DistanceConstraint::SetEnabled`.
            public unsafe void SetEnabled(bool inEnabled)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraint_SetEnabled(_Underlying *_this, byte inEnabled);
                __JPH_DistanceConstraint_SetEnabled(_UnderlyingPtr, inEnabled ? (byte)1 : (byte)0);
            }

            /// Generated from method `JPH::DistanceConstraint::SetUserData`.
            public unsafe void SetUserData(ulong inUserData)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DistanceConstraint_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DistanceConstraint_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DistanceConstraint_SetUserData(_Underlying *_this, ulong inUserData);
                __JPH_DistanceConstraint_SetUserData(_UnderlyingPtr, inUserData);
            }
        }

        /// This is used for optional parameters of class `DistanceConstraint` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_DistanceConstraint`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `DistanceConstraint`/`Const_DistanceConstraint` directly.
        public class _InOptMut_DistanceConstraint
        {
            public DistanceConstraint? Opt;

            public _InOptMut_DistanceConstraint() {}
            public _InOptMut_DistanceConstraint(DistanceConstraint value) {Opt = value;}
            public static implicit operator _InOptMut_DistanceConstraint(DistanceConstraint value) {return new(value);}
        }

        /// This is used for optional parameters of class `DistanceConstraint` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_DistanceConstraint`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `DistanceConstraint`/`Const_DistanceConstraint` to pass it to the function.
        public class _InOptConst_DistanceConstraint
        {
            public Const_DistanceConstraint? Opt;

            public _InOptConst_DistanceConstraint() {}
            public _InOptConst_DistanceConstraint(Const_DistanceConstraint value) {Opt = value;}
            public static implicit operator _InOptConst_DistanceConstraint(Const_DistanceConstraint value) {return new(value);}
        }
    }
}
