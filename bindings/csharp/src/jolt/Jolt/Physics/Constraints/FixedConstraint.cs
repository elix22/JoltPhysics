// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Fixed constraint settings, used to create a fixed constraint
        /// Generated from class `JPH::FixedConstraintSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraintSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::SerializableObject`
        ///     `JPH::RefTarget<JPH::ConstraintSettings>`
        ///     `JPH::ConstraintSettings`
        /// This is the const half of the class.
        public class Const_FixedConstraintSettings : Jolt.Object<Const_FixedConstraintSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraintSettings_Destroy(_Underlying *_this);
                __JPH_FixedConstraintSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_FixedConstraintSettings() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_SerializableObject(Const_FixedConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_SerializableObject._Underlying *__JPH_FixedConstraintSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.Const_SerializableObject ret = new(__JPH_FixedConstraintSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHConstraintSettings(Const_FixedConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHConstraintSettings._Underlying *__JPH_FixedConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHConstraintSettings ret = new(__JPH_FixedConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_ConstraintSettings(Const_FixedConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_ConstraintSettings._Underlying *__JPH_FixedConstraintSettings_UpcastTo_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.Const_ConstraintSettings ret = new(__JPH_FixedConstraintSettings_UpcastTo_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_TwoBodyConstraintSettings(Const_FixedConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_TwoBodyConstraintSettings._Underlying *__JPH_FixedConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(_Underlying *_this);
                Jolt.JPH.Const_TwoBodyConstraintSettings ret = new(__JPH_FixedConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_FixedConstraintSettings?(Jolt.JPH.Const_SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.Const_SerializableObject._Underlying *_this);
                var ptr = __JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_FixedConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_FixedConstraintSettings?(Jolt.JPH.Const_ConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(Jolt.JPH.Const_ConstraintSettings._Underlying *_this);
                var ptr = __JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_FixedConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_FixedConstraintSettings?(Jolt.JPH.Const_TwoBodyConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(Jolt.JPH.Const_TwoBodyConstraintSettings._Underlying *_this);
                var ptr = __JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_FixedConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// When mSpace is WorldSpace mPoint1 and mPoint2 can be automatically calculated based on the positions of the bodies when the constraint is created (they will be fixated in their current relative position/orientation). Set this to false if you want to supply the attachment points yourself.
            public unsafe bool mAutoDetectPoint
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_Get_mAutoDetectPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_Get_mAutoDetectPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_FixedConstraintSettings_Get_mAutoDetectPoint(_Underlying *_this);
                    return *__JPH_FixedConstraintSettings_Get_mAutoDetectPoint(_UnderlyingPtr);
                }
            }

            /// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
            public unsafe bool mEnabled
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_Get_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_Get_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_FixedConstraintSettings_Get_mEnabled(_Underlying *_this);
                    return *__JPH_FixedConstraintSettings_Get_mEnabled(_UnderlyingPtr);
                }
            }

            /// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
            /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
            public unsafe uint mConstraintPriority
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_Get_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_Get_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_FixedConstraintSettings_Get_mConstraintPriority(_Underlying *_this);
                    return *__JPH_FixedConstraintSettings_Get_mConstraintPriority(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public unsafe uint mNumVelocityStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_FixedConstraintSettings_Get_mNumVelocityStepsOverride(_Underlying *_this);
                    return *__JPH_FixedConstraintSettings_Get_mNumVelocityStepsOverride(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public unsafe uint mNumPositionStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_FixedConstraintSettings_Get_mNumPositionStepsOverride(_Underlying *_this);
                    return *__JPH_FixedConstraintSettings_Get_mNumPositionStepsOverride(_UnderlyingPtr);
                }
            }

            /// Size of constraint when drawing it through the debug renderer
            public unsafe float mDrawConstraintSize
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_Get_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_Get_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_FixedConstraintSettings_Get_mDrawConstraintSize(_Underlying *_this);
                    return *__JPH_FixedConstraintSettings_Get_mDrawConstraintSize(_UnderlyingPtr);
                }
            }

            /// User data value (can be used by application)
            public unsafe ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_FixedConstraintSettings_Get_mUserData(_Underlying *_this);
                    return *__JPH_FixedConstraintSettings_Get_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe Const_FixedConstraintSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_FixedConstraintSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.FixedConstraintSettings._Underlying *__JPH_FixedConstraintSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_FixedConstraintSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::FixedConstraintSettings::FixedConstraintSettings`.
            public unsafe Const_FixedConstraintSettings(Jolt.JPH._ByValue_FixedConstraintSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.FixedConstraintSettings._Underlying *__JPH_FixedConstraintSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.FixedConstraintSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_FixedConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::FixedConstraintSettings::FixedConstraintSettings`.
            public Const_FixedConstraintSettings(Const_FixedConstraintSettings _other) : this(new _ByValue_FixedConstraintSettings(_other)) {}

            /// Generated from constructor `JPH::FixedConstraintSettings::FixedConstraintSettings`.
            public Const_FixedConstraintSettings(FixedConstraintSettings _other) : this((Const_FixedConstraintSettings)_other) {}

            /// Generated from method `JPH::FixedConstraintSettings::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_FixedConstraintSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_FixedConstraintSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_FixedConstraintSettings_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_FixedConstraintSettings_unsigned_long(inCount);
            }

            /// Generated from method `JPH::FixedConstraintSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_FixedConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_FixedConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_FixedConstraintSettings_void_ptr(void *inPointer);
                __Jolt_delete_JPH_FixedConstraintSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::FixedConstraintSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_FixedConstraintSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_FixedConstraintSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_FixedConstraintSettings_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_FixedConstraintSettings_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::FixedConstraintSettings::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_FixedConstraintSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_FixedConstraintSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_FixedConstraintSettings_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_FixedConstraintSettings_unsigned_long(inCount);
            }

            /// Generated from method `JPH::FixedConstraintSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::FixedConstraintSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::FixedConstraintSettings::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_FixedConstraintSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_FixedConstraintSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_FixedConstraintSettings_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_FixedConstraintSettings_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::FixedConstraintSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_FixedConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_FixedConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_FixedConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_FixedConstraintSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::FixedConstraintSettings::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_FixedConstraintSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_FixedConstraintSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_FixedConstraintSettings_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_FixedConstraintSettings_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::FixedConstraintSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_FixedConstraintSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Create an instance of this constraint
            /// Generated from method `JPH::FixedConstraintSettings::Create`.
            public unsafe Jolt.JPH.TwoBodyConstraint? Create(Jolt.JPH.Body inBody1, Jolt.JPH.Body inBody2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_Create", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_Create", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TwoBodyConstraint._Underlying *__JPH_FixedConstraintSettings_Create(_Underlying *_this, Jolt.JPH.Body._Underlying *inBody1, Jolt.JPH.Body._Underlying *inBody2);
                var __c_ret = __JPH_FixedConstraintSettings_Create(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.TwoBodyConstraint(__c_ret, is_owning: false) : null;
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::FixedConstraintSettings::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraintSettings_SetEmbedded(_Underlying *_this);
                __JPH_FixedConstraintSettings_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::FixedConstraintSettings::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_FixedConstraintSettings_GetRefCount(_Underlying *_this);
                return __JPH_FixedConstraintSettings_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::FixedConstraintSettings::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraintSettings_AddRef(_Underlying *_this);
                __JPH_FixedConstraintSettings_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::FixedConstraintSettings::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraintSettings_Release(_Underlying *_this);
                __JPH_FixedConstraintSettings_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::FixedConstraintSettings::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_FixedConstraintSettings_sInternalGetRefCountOffset();
                return __JPH_FixedConstraintSettings_sInternalGetRefCountOffset();
            }
        }

        /// Fixed constraint settings, used to create a fixed constraint
        /// Generated from class `JPH::FixedConstraintSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraintSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::SerializableObject`
        ///     `JPH::RefTarget<JPH::ConstraintSettings>`
        ///     `JPH::ConstraintSettings`
        /// This is the non-const half of the class.
        public class FixedConstraintSettings : Const_FixedConstraintSettings
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.SerializableObject(FixedConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SerializableObject._Underlying *__JPH_FixedConstraintSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.SerializableObject ret = new(__JPH_FixedConstraintSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHConstraintSettings(FixedConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHConstraintSettings._Underlying *__JPH_FixedConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHConstraintSettings ret = new(__JPH_FixedConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.ConstraintSettings(FixedConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.ConstraintSettings._Underlying *__JPH_FixedConstraintSettings_UpcastTo_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.ConstraintSettings ret = new(__JPH_FixedConstraintSettings_UpcastTo_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.TwoBodyConstraintSettings(FixedConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TwoBodyConstraintSettings._Underlying *__JPH_FixedConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(_Underlying *_this);
                Jolt.JPH.TwoBodyConstraintSettings ret = new(__JPH_FixedConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator FixedConstraintSettings?(Jolt.JPH.SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.SerializableObject._Underlying *_this);
                var ptr = __JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                FixedConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator FixedConstraintSettings?(Jolt.JPH.ConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(Jolt.JPH.ConstraintSettings._Underlying *_this);
                var ptr = __JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                FixedConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator FixedConstraintSettings?(Jolt.JPH.TwoBodyConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(Jolt.JPH.TwoBodyConstraintSettings._Underlying *_this);
                var ptr = __JPH_FixedConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                FixedConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// When mSpace is WorldSpace mPoint1 and mPoint2 can be automatically calculated based on the positions of the bodies when the constraint is created (they will be fixated in their current relative position/orientation). Set this to false if you want to supply the attachment points yourself.
            public new unsafe ref bool mAutoDetectPoint
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetMutable_mAutoDetectPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetMutable_mAutoDetectPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_FixedConstraintSettings_GetMutable_mAutoDetectPoint(_Underlying *_this);
                    return ref *__JPH_FixedConstraintSettings_GetMutable_mAutoDetectPoint(_UnderlyingPtr);
                }
            }

            /// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
            public new unsafe ref bool mEnabled
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetMutable_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetMutable_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_FixedConstraintSettings_GetMutable_mEnabled(_Underlying *_this);
                    return ref *__JPH_FixedConstraintSettings_GetMutable_mEnabled(_UnderlyingPtr);
                }
            }

            /// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
            /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
            public new unsafe ref uint mConstraintPriority
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetMutable_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetMutable_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_FixedConstraintSettings_GetMutable_mConstraintPriority(_Underlying *_this);
                    return ref *__JPH_FixedConstraintSettings_GetMutable_mConstraintPriority(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public new unsafe ref uint mNumVelocityStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_FixedConstraintSettings_GetMutable_mNumVelocityStepsOverride(_Underlying *_this);
                    return ref *__JPH_FixedConstraintSettings_GetMutable_mNumVelocityStepsOverride(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public new unsafe ref uint mNumPositionStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_FixedConstraintSettings_GetMutable_mNumPositionStepsOverride(_Underlying *_this);
                    return ref *__JPH_FixedConstraintSettings_GetMutable_mNumPositionStepsOverride(_UnderlyingPtr);
                }
            }

            /// Size of constraint when drawing it through the debug renderer
            public new unsafe ref float mDrawConstraintSize
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetMutable_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetMutable_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_FixedConstraintSettings_GetMutable_mDrawConstraintSize(_Underlying *_this);
                    return ref *__JPH_FixedConstraintSettings_GetMutable_mDrawConstraintSize(_UnderlyingPtr);
                }
            }

            /// User data value (can be used by application)
            public new unsafe ref ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_FixedConstraintSettings_GetMutable_mUserData(_Underlying *_this);
                    return ref *__JPH_FixedConstraintSettings_GetMutable_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe FixedConstraintSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe FixedConstraintSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.FixedConstraintSettings._Underlying *__JPH_FixedConstraintSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_FixedConstraintSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::FixedConstraintSettings::FixedConstraintSettings`.
            public unsafe FixedConstraintSettings(Jolt.JPH._ByValue_FixedConstraintSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.FixedConstraintSettings._Underlying *__JPH_FixedConstraintSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.FixedConstraintSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_FixedConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::FixedConstraintSettings::FixedConstraintSettings`.
            public FixedConstraintSettings(Const_FixedConstraintSettings _other) : this(new _ByValue_FixedConstraintSettings(_other)) {}

            /// Generated from constructor `JPH::FixedConstraintSettings::FixedConstraintSettings`.
            public FixedConstraintSettings(FixedConstraintSettings _other) : this((Const_FixedConstraintSettings)_other) {}

            /// Generated from method `JPH::FixedConstraintSettings::operator=`.
            public unsafe Jolt.JPH.FixedConstraintSettings Assign(Jolt.JPH._ByValue_FixedConstraintSettings _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.FixedConstraintSettings._Underlying *__JPH_FixedConstraintSettings_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JPH.FixedConstraintSettings._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_FixedConstraintSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }
        }

        /// This is used as a function parameter when the underlying function receives `FixedConstraintSettings` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `FixedConstraintSettings`/`Const_FixedConstraintSettings` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_FixedConstraintSettings
        {
            #pragma warning disable CS0649
            internal readonly Const_FixedConstraintSettings? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_FixedConstraintSettings() {PassByMode = Jolt._PassBy.default_construct;}
            public _ByValue_FixedConstraintSettings(Const_FixedConstraintSettings new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
            public static implicit operator _ByValue_FixedConstraintSettings(Const_FixedConstraintSettings arg) {return new(arg);}
            public _ByValue_FixedConstraintSettings(Jolt._Moved<FixedConstraintSettings> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
            public static implicit operator _ByValue_FixedConstraintSettings(Jolt._Moved<FixedConstraintSettings> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `FixedConstraintSettings` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_FixedConstraintSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `FixedConstraintSettings`/`Const_FixedConstraintSettings` directly.
        public class _InOptMut_FixedConstraintSettings
        {
            public FixedConstraintSettings? Opt;

            public _InOptMut_FixedConstraintSettings() {}
            public _InOptMut_FixedConstraintSettings(FixedConstraintSettings value) {Opt = value;}
            public static implicit operator _InOptMut_FixedConstraintSettings(FixedConstraintSettings value) {return new(value);}
        }

        /// This is used for optional parameters of class `FixedConstraintSettings` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_FixedConstraintSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `FixedConstraintSettings`/`Const_FixedConstraintSettings` to pass it to the function.
        public class _InOptConst_FixedConstraintSettings
        {
            public Const_FixedConstraintSettings? Opt;

            public _InOptConst_FixedConstraintSettings() {}
            public _InOptConst_FixedConstraintSettings(Const_FixedConstraintSettings value) {Opt = value;}
            public static implicit operator _InOptConst_FixedConstraintSettings(Const_FixedConstraintSettings value) {return new(value);}
        }

        /// A fixed constraint welds two bodies together removing all degrees of freedom between them.
        /// This variant uses Euler angles for the rotation constraint.
        /// Generated from class `JPH::FixedConstraint`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraint`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::Constraint>`
        ///     `JPH::NonCopyable`
        ///     `JPH::Constraint`
        /// This is the const half of the class.
        public class Const_FixedConstraint : Jolt.Object<Const_FixedConstraint>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraint_Destroy(_Underlying *_this);
                __JPH_FixedConstraint_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_FixedConstraint() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHConstraint(Const_FixedConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHConstraint._Underlying *__JPH_FixedConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHConstraint ret = new(__JPH_FixedConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_FixedConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_FixedConstraint_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_FixedConstraint_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_Constraint(Const_FixedConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Constraint._Underlying *__JPH_FixedConstraint_UpcastTo_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.Const_Constraint ret = new(__JPH_FixedConstraint_UpcastTo_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_TwoBodyConstraint(Const_FixedConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_TwoBodyConstraint._Underlying *__JPH_FixedConstraint_UpcastTo_JPH_TwoBodyConstraint(_Underlying *_this);
                Jolt.JPH.Const_TwoBodyConstraint ret = new(__JPH_FixedConstraint_UpcastTo_JPH_TwoBodyConstraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_FixedConstraint?(Jolt.JPH.Const_Constraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_FixedConstraint_DynamicDowncastFrom_JPH_Constraint(Jolt.JPH.Const_Constraint._Underlying *_this);
                var ptr = __JPH_FixedConstraint_DynamicDowncastFrom_JPH_Constraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_FixedConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_FixedConstraint?(Jolt.JPH.Const_TwoBodyConstraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_FixedConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(Jolt.JPH.Const_TwoBodyConstraint._Underlying *_this);
                var ptr = __JPH_FixedConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_FixedConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe Const_FixedConstraint(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructor
            /// Generated from constructor `JPH::FixedConstraint::FixedConstraint`.
            public unsafe Const_FixedConstraint(Jolt.JPH.Body inBody1, Jolt.JPH.Body inBody2, Jolt.JPH.Const_FixedConstraintSettings inSettings) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.FixedConstraint._Underlying *__JPH_FixedConstraint_Construct(Jolt.JPH.Body._Underlying *inBody1, Jolt.JPH.Body._Underlying *inBody2, Jolt.JPH.Const_FixedConstraintSettings._Underlying *inSettings);
                _UnderlyingPtr = __JPH_FixedConstraint_Construct(inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inSettings._UnderlyingPtr);
            }

            /// Generated from method `JPH::FixedConstraint::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_FixedConstraint_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_FixedConstraint_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_FixedConstraint_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_FixedConstraint_unsigned_long(inCount);
            }

            /// Generated from method `JPH::FixedConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_FixedConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_FixedConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_FixedConstraint_void_ptr(void *inPointer);
                __Jolt_delete_JPH_FixedConstraint_void_ptr(inPointer);
            }

            /// Generated from method `JPH::FixedConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_FixedConstraint_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_FixedConstraint_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_FixedConstraint_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_FixedConstraint_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::FixedConstraint::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_FixedConstraint_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_FixedConstraint_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_FixedConstraint_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_FixedConstraint_unsigned_long(inCount);
            }

            /// Generated from method `JPH::FixedConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_FixedConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_FixedConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_FixedConstraint_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_FixedConstraint_void_ptr(inPointer);
            }

            /// Generated from method `JPH::FixedConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_FixedConstraint_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_FixedConstraint_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_FixedConstraint_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_FixedConstraint_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::FixedConstraint::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_FixedConstraint_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_FixedConstraint_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_FixedConstraint_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_FixedConstraint_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::FixedConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_FixedConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_FixedConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_FixedConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_FixedConstraint_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::FixedConstraint::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_FixedConstraint_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_FixedConstraint_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_FixedConstraint_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_FixedConstraint_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::FixedConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_FixedConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_FixedConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_FixedConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_FixedConstraint_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Solver interface
            /// Generated from method `JPH::FixedConstraint::IsActive`.
            public unsafe bool IsActive()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_FixedConstraint_IsActive(_Underlying *_this);
                return __JPH_FixedConstraint_IsActive(_UnderlyingPtr) != 0;
            }

            /// Access to the connected bodies
            /// Generated from method `JPH::FixedConstraint::GetBody1`.
            public unsafe Jolt.JPH.Body? GetBody1()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_GetBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_GetBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Body._Underlying *__JPH_FixedConstraint_GetBody1(_Underlying *_this);
                var __c_ret = __JPH_FixedConstraint_GetBody1(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Body(__c_ret, is_owning: false) : null;
            }

            /// Generated from method `JPH::FixedConstraint::GetBody2`.
            public unsafe Jolt.JPH.Body? GetBody2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_GetBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_GetBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Body._Underlying *__JPH_FixedConstraint_GetBody2(_Underlying *_this);
                var __c_ret = __JPH_FixedConstraint_GetBody2(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Body(__c_ret, is_owning: false) : null;
            }

            /// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
            /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
            /// Generated from method `JPH::FixedConstraint::GetConstraintPriority`.
            public unsafe uint GetConstraintPriority()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_GetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_GetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_FixedConstraint_GetConstraintPriority(_Underlying *_this);
                return __JPH_FixedConstraint_GetConstraintPriority(_UnderlyingPtr);
            }

            /// Generated from method `JPH::FixedConstraint::GetNumVelocityStepsOverride`.
            public unsafe uint GetNumVelocityStepsOverride()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_FixedConstraint_GetNumVelocityStepsOverride(_Underlying *_this);
                return __JPH_FixedConstraint_GetNumVelocityStepsOverride(_UnderlyingPtr);
            }

            /// Generated from method `JPH::FixedConstraint::GetNumPositionStepsOverride`.
            public unsafe uint GetNumPositionStepsOverride()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_FixedConstraint_GetNumPositionStepsOverride(_Underlying *_this);
                return __JPH_FixedConstraint_GetNumPositionStepsOverride(_UnderlyingPtr);
            }

            /// Test if a constraint is enabled.
            /// Generated from method `JPH::FixedConstraint::GetEnabled`.
            public unsafe bool GetEnabled()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_FixedConstraint_GetEnabled(_Underlying *_this);
                return __JPH_FixedConstraint_GetEnabled(_UnderlyingPtr) != 0;
            }

            /// Access to the user data, can be used for anything by the application
            /// Generated from method `JPH::FixedConstraint::GetUserData`.
            public unsafe ulong GetUserData()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_FixedConstraint_GetUserData(_Underlying *_this);
                return __JPH_FixedConstraint_GetUserData(_UnderlyingPtr);
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::FixedConstraint::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraint_SetEmbedded(_Underlying *_this);
                __JPH_FixedConstraint_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::FixedConstraint::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_FixedConstraint_GetRefCount(_Underlying *_this);
                return __JPH_FixedConstraint_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::FixedConstraint::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraint_AddRef(_Underlying *_this);
                __JPH_FixedConstraint_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::FixedConstraint::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraint_Release(_Underlying *_this);
                __JPH_FixedConstraint_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::FixedConstraint::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_FixedConstraint_sInternalGetRefCountOffset();
                return __JPH_FixedConstraint_sInternalGetRefCountOffset();
            }
        }

        /// A fixed constraint welds two bodies together removing all degrees of freedom between them.
        /// This variant uses Euler angles for the rotation constraint.
        /// Generated from class `JPH::FixedConstraint`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraint`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::Constraint>`
        ///     `JPH::NonCopyable`
        ///     `JPH::Constraint`
        /// This is the non-const half of the class.
        public class FixedConstraint : Const_FixedConstraint
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHConstraint(FixedConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHConstraint._Underlying *__JPH_FixedConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHConstraint ret = new(__JPH_FixedConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.NonCopyable(FixedConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_FixedConstraint_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_FixedConstraint_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Constraint(FixedConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Constraint._Underlying *__JPH_FixedConstraint_UpcastTo_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.Constraint ret = new(__JPH_FixedConstraint_UpcastTo_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.TwoBodyConstraint(FixedConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TwoBodyConstraint._Underlying *__JPH_FixedConstraint_UpcastTo_JPH_TwoBodyConstraint(_Underlying *_this);
                Jolt.JPH.TwoBodyConstraint ret = new(__JPH_FixedConstraint_UpcastTo_JPH_TwoBodyConstraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator FixedConstraint?(Jolt.JPH.Constraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_FixedConstraint_DynamicDowncastFrom_JPH_Constraint(Jolt.JPH.Constraint._Underlying *_this);
                var ptr = __JPH_FixedConstraint_DynamicDowncastFrom_JPH_Constraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                FixedConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator FixedConstraint?(Jolt.JPH.TwoBodyConstraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_FixedConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(Jolt.JPH.TwoBodyConstraint._Underlying *_this);
                var ptr = __JPH_FixedConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                FixedConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe FixedConstraint(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructor
            /// Generated from constructor `JPH::FixedConstraint::FixedConstraint`.
            public unsafe FixedConstraint(Jolt.JPH.Body inBody1, Jolt.JPH.Body inBody2, Jolt.JPH.Const_FixedConstraintSettings inSettings) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.FixedConstraint._Underlying *__JPH_FixedConstraint_Construct(Jolt.JPH.Body._Underlying *inBody1, Jolt.JPH.Body._Underlying *inBody2, Jolt.JPH.Const_FixedConstraintSettings._Underlying *inSettings);
                _UnderlyingPtr = __JPH_FixedConstraint_Construct(inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inSettings._UnderlyingPtr);
            }

            /// Generated from method `JPH::FixedConstraint::SetupVelocityConstraint`.
            public unsafe void SetupVelocityConstraint(float inDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_SetupVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_SetupVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraint_SetupVelocityConstraint(_Underlying *_this, float inDeltaTime);
                __JPH_FixedConstraint_SetupVelocityConstraint(_UnderlyingPtr, inDeltaTime);
            }

            /// Generated from method `JPH::FixedConstraint::ResetWarmStart`.
            public unsafe void ResetWarmStart()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraint_ResetWarmStart(_Underlying *_this);
                __JPH_FixedConstraint_ResetWarmStart(_UnderlyingPtr);
            }

            /// Generated from method `JPH::FixedConstraint::WarmStartVelocityConstraint`.
            public unsafe void WarmStartVelocityConstraint(float inWarmStartImpulseRatio)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_WarmStartVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_WarmStartVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraint_WarmStartVelocityConstraint(_Underlying *_this, float inWarmStartImpulseRatio);
                __JPH_FixedConstraint_WarmStartVelocityConstraint(_UnderlyingPtr, inWarmStartImpulseRatio);
            }

            /// Generated from method `JPH::FixedConstraint::SolveVelocityConstraint`.
            public unsafe bool SolveVelocityConstraint(float inDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_SolveVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_SolveVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_FixedConstraint_SolveVelocityConstraint(_Underlying *_this, float inDeltaTime);
                return __JPH_FixedConstraint_SolveVelocityConstraint(_UnderlyingPtr, inDeltaTime) != 0;
            }

            /// Generated from method `JPH::FixedConstraint::SolvePositionConstraint`.
            public unsafe bool SolvePositionConstraint(float inDeltaTime, float inBaumgarte)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_SolvePositionConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_SolvePositionConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_FixedConstraint_SolvePositionConstraint(_Underlying *_this, float inDeltaTime, float inBaumgarte);
                return __JPH_FixedConstraint_SolvePositionConstraint(_UnderlyingPtr, inDeltaTime, inBaumgarte) != 0;
            }

            /// Generated from method `JPH::FixedConstraint::SetConstraintPriority`.
            public unsafe void SetConstraintPriority(uint inPriority)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_SetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_SetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraint_SetConstraintPriority(_Underlying *_this, uint inPriority);
                __JPH_FixedConstraint_SetConstraintPriority(_UnderlyingPtr, inPriority);
            }

            /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
            /// Generated from method `JPH::FixedConstraint::SetNumVelocityStepsOverride`.
            public unsafe void SetNumVelocityStepsOverride(uint inN)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraint_SetNumVelocityStepsOverride(_Underlying *_this, uint inN);
                __JPH_FixedConstraint_SetNumVelocityStepsOverride(_UnderlyingPtr, inN);
            }

            /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
            /// Generated from method `JPH::FixedConstraint::SetNumPositionStepsOverride`.
            public unsafe void SetNumPositionStepsOverride(uint inN)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraint_SetNumPositionStepsOverride(_Underlying *_this, uint inN);
                __JPH_FixedConstraint_SetNumPositionStepsOverride(_UnderlyingPtr, inN);
            }

            /// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
            /// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
            /// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
            /// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
            /// Generated from method `JPH::FixedConstraint::SetEnabled`.
            public unsafe void SetEnabled(bool inEnabled)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraint_SetEnabled(_Underlying *_this, byte inEnabled);
                __JPH_FixedConstraint_SetEnabled(_UnderlyingPtr, inEnabled ? (byte)1 : (byte)0);
            }

            /// Generated from method `JPH::FixedConstraint::SetUserData`.
            public unsafe void SetUserData(ulong inUserData)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_FixedConstraint_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_FixedConstraint_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_FixedConstraint_SetUserData(_Underlying *_this, ulong inUserData);
                __JPH_FixedConstraint_SetUserData(_UnderlyingPtr, inUserData);
            }
        }

        /// This is used for optional parameters of class `FixedConstraint` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_FixedConstraint`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `FixedConstraint`/`Const_FixedConstraint` directly.
        public class _InOptMut_FixedConstraint
        {
            public FixedConstraint? Opt;

            public _InOptMut_FixedConstraint() {}
            public _InOptMut_FixedConstraint(FixedConstraint value) {Opt = value;}
            public static implicit operator _InOptMut_FixedConstraint(FixedConstraint value) {return new(value);}
        }

        /// This is used for optional parameters of class `FixedConstraint` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_FixedConstraint`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `FixedConstraint`/`Const_FixedConstraint` to pass it to the function.
        public class _InOptConst_FixedConstraint
        {
            public Const_FixedConstraint? Opt;

            public _InOptConst_FixedConstraint() {}
            public _InOptConst_FixedConstraint(Const_FixedConstraint value) {Opt = value;}
            public static implicit operator _InOptConst_FixedConstraint(Const_FixedConstraint value) {return new(value);}
        }
    }
}
