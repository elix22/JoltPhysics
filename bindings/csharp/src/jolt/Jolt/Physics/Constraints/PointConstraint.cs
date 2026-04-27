// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Point constraint settings, used to create a point constraint
        /// Generated from class `JPH::PointConstraintSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraintSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::SerializableObject`
        ///     `JPH::RefTarget<JPH::ConstraintSettings>`
        ///     `JPH::ConstraintSettings`
        /// This is the const half of the class.
        public class Const_PointConstraintSettings : Jolt.Object<Const_PointConstraintSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraintSettings_Destroy(_Underlying *_this);
                __JPH_PointConstraintSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_PointConstraintSettings() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_SerializableObject(Const_PointConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_SerializableObject._Underlying *__JPH_PointConstraintSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.Const_SerializableObject ret = new(__JPH_PointConstraintSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHConstraintSettings(Const_PointConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHConstraintSettings._Underlying *__JPH_PointConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHConstraintSettings ret = new(__JPH_PointConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_ConstraintSettings(Const_PointConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_ConstraintSettings._Underlying *__JPH_PointConstraintSettings_UpcastTo_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.Const_ConstraintSettings ret = new(__JPH_PointConstraintSettings_UpcastTo_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_TwoBodyConstraintSettings(Const_PointConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_TwoBodyConstraintSettings._Underlying *__JPH_PointConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(_Underlying *_this);
                Jolt.JPH.Const_TwoBodyConstraintSettings ret = new(__JPH_PointConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_PointConstraintSettings?(Jolt.JPH.Const_SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.Const_SerializableObject._Underlying *_this);
                var ptr = __JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_PointConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_PointConstraintSettings?(Jolt.JPH.Const_ConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(Jolt.JPH.Const_ConstraintSettings._Underlying *_this);
                var ptr = __JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_PointConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_PointConstraintSettings?(Jolt.JPH.Const_TwoBodyConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(Jolt.JPH.Const_TwoBodyConstraintSettings._Underlying *_this);
                var ptr = __JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_PointConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
            public unsafe bool mEnabled
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_Get_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_Get_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_PointConstraintSettings_Get_mEnabled(_Underlying *_this);
                    return *__JPH_PointConstraintSettings_Get_mEnabled(_UnderlyingPtr);
                }
            }

            /// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
            /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
            public unsafe uint mConstraintPriority
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_Get_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_Get_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_PointConstraintSettings_Get_mConstraintPriority(_Underlying *_this);
                    return *__JPH_PointConstraintSettings_Get_mConstraintPriority(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public unsafe uint mNumVelocityStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_PointConstraintSettings_Get_mNumVelocityStepsOverride(_Underlying *_this);
                    return *__JPH_PointConstraintSettings_Get_mNumVelocityStepsOverride(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public unsafe uint mNumPositionStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_PointConstraintSettings_Get_mNumPositionStepsOverride(_Underlying *_this);
                    return *__JPH_PointConstraintSettings_Get_mNumPositionStepsOverride(_UnderlyingPtr);
                }
            }

            /// Size of constraint when drawing it through the debug renderer
            public unsafe float mDrawConstraintSize
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_Get_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_Get_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_PointConstraintSettings_Get_mDrawConstraintSize(_Underlying *_this);
                    return *__JPH_PointConstraintSettings_Get_mDrawConstraintSize(_UnderlyingPtr);
                }
            }

            /// User data value (can be used by application)
            public unsafe ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_PointConstraintSettings_Get_mUserData(_Underlying *_this);
                    return *__JPH_PointConstraintSettings_Get_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe Const_PointConstraintSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_PointConstraintSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.PointConstraintSettings._Underlying *__JPH_PointConstraintSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_PointConstraintSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::PointConstraintSettings::PointConstraintSettings`.
            public unsafe Const_PointConstraintSettings(Jolt.JPH._ByValue_PointConstraintSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.PointConstraintSettings._Underlying *__JPH_PointConstraintSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.PointConstraintSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_PointConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::PointConstraintSettings::PointConstraintSettings`.
            public Const_PointConstraintSettings(Const_PointConstraintSettings _other) : this(new _ByValue_PointConstraintSettings(_other)) {}

            /// Generated from constructor `JPH::PointConstraintSettings::PointConstraintSettings`.
            public Const_PointConstraintSettings(PointConstraintSettings _other) : this((Const_PointConstraintSettings)_other) {}

            /// Generated from method `JPH::PointConstraintSettings::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PointConstraintSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PointConstraintSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_PointConstraintSettings_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_PointConstraintSettings_unsigned_long(inCount);
            }

            /// Generated from method `JPH::PointConstraintSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PointConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PointConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PointConstraintSettings_void_ptr(void *inPointer);
                __Jolt_delete_JPH_PointConstraintSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::PointConstraintSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PointConstraintSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PointConstraintSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PointConstraintSettings_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_PointConstraintSettings_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::PointConstraintSettings::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PointConstraintSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PointConstraintSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_PointConstraintSettings_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_PointConstraintSettings_unsigned_long(inCount);
            }

            /// Generated from method `JPH::PointConstraintSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PointConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PointConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PointConstraintSettings_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_PointConstraintSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::PointConstraintSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PointConstraintSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PointConstraintSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PointConstraintSettings_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_PointConstraintSettings_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::PointConstraintSettings::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PointConstraintSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PointConstraintSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_PointConstraintSettings_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_PointConstraintSettings_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::PointConstraintSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PointConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PointConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PointConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_PointConstraintSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::PointConstraintSettings::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PointConstraintSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PointConstraintSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_PointConstraintSettings_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_PointConstraintSettings_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::PointConstraintSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PointConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PointConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PointConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_PointConstraintSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Create an instance of this constraint
            /// Generated from method `JPH::PointConstraintSettings::Create`.
            public unsafe Jolt.JPH.TwoBodyConstraint? Create(Jolt.JPH.Body inBody1, Jolt.JPH.Body inBody2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_Create", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_Create", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TwoBodyConstraint._Underlying *__JPH_PointConstraintSettings_Create(_Underlying *_this, Jolt.JPH.Body._Underlying *inBody1, Jolt.JPH.Body._Underlying *inBody2);
                var __c_ret = __JPH_PointConstraintSettings_Create(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.TwoBodyConstraint(__c_ret, is_owning: false) : null;
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::PointConstraintSettings::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraintSettings_SetEmbedded(_Underlying *_this);
                __JPH_PointConstraintSettings_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::PointConstraintSettings::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_PointConstraintSettings_GetRefCount(_Underlying *_this);
                return __JPH_PointConstraintSettings_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::PointConstraintSettings::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraintSettings_AddRef(_Underlying *_this);
                __JPH_PointConstraintSettings_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::PointConstraintSettings::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraintSettings_Release(_Underlying *_this);
                __JPH_PointConstraintSettings_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::PointConstraintSettings::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_PointConstraintSettings_sInternalGetRefCountOffset();
                return __JPH_PointConstraintSettings_sInternalGetRefCountOffset();
            }
        }

        /// Point constraint settings, used to create a point constraint
        /// Generated from class `JPH::PointConstraintSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraintSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::SerializableObject`
        ///     `JPH::RefTarget<JPH::ConstraintSettings>`
        ///     `JPH::ConstraintSettings`
        /// This is the non-const half of the class.
        public class PointConstraintSettings : Const_PointConstraintSettings
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.SerializableObject(PointConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SerializableObject._Underlying *__JPH_PointConstraintSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
                Jolt.JPH.SerializableObject ret = new(__JPH_PointConstraintSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHConstraintSettings(PointConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHConstraintSettings._Underlying *__JPH_PointConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHConstraintSettings ret = new(__JPH_PointConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.ConstraintSettings(PointConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.ConstraintSettings._Underlying *__JPH_PointConstraintSettings_UpcastTo_JPH_ConstraintSettings(_Underlying *_this);
                Jolt.JPH.ConstraintSettings ret = new(__JPH_PointConstraintSettings_UpcastTo_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.TwoBodyConstraintSettings(PointConstraintSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TwoBodyConstraintSettings._Underlying *__JPH_PointConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(_Underlying *_this);
                Jolt.JPH.TwoBodyConstraintSettings ret = new(__JPH_PointConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator PointConstraintSettings?(Jolt.JPH.SerializableObject parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(Jolt.JPH.SerializableObject._Underlying *_this);
                var ptr = __JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr);
                if (ptr is null) return null;
                PointConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator PointConstraintSettings?(Jolt.JPH.ConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(Jolt.JPH.ConstraintSettings._Underlying *_this);
                var ptr = __JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_ConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                PointConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator PointConstraintSettings?(Jolt.JPH.TwoBodyConstraintSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(Jolt.JPH.TwoBodyConstraintSettings._Underlying *_this);
                var ptr = __JPH_PointConstraintSettings_DynamicDowncastFrom_JPH_TwoBodyConstraintSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                PointConstraintSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
            public new unsafe ref bool mEnabled
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_GetMutable_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_GetMutable_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_PointConstraintSettings_GetMutable_mEnabled(_Underlying *_this);
                    return ref *__JPH_PointConstraintSettings_GetMutable_mEnabled(_UnderlyingPtr);
                }
            }

            /// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
            /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
            public new unsafe ref uint mConstraintPriority
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_GetMutable_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_GetMutable_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_PointConstraintSettings_GetMutable_mConstraintPriority(_Underlying *_this);
                    return ref *__JPH_PointConstraintSettings_GetMutable_mConstraintPriority(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public new unsafe ref uint mNumVelocityStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_PointConstraintSettings_GetMutable_mNumVelocityStepsOverride(_Underlying *_this);
                    return ref *__JPH_PointConstraintSettings_GetMutable_mNumVelocityStepsOverride(_UnderlyingPtr);
                }
            }

            /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
            public new unsafe ref uint mNumPositionStepsOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_PointConstraintSettings_GetMutable_mNumPositionStepsOverride(_Underlying *_this);
                    return ref *__JPH_PointConstraintSettings_GetMutable_mNumPositionStepsOverride(_UnderlyingPtr);
                }
            }

            /// Size of constraint when drawing it through the debug renderer
            public new unsafe ref float mDrawConstraintSize
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_GetMutable_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_GetMutable_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_PointConstraintSettings_GetMutable_mDrawConstraintSize(_Underlying *_this);
                    return ref *__JPH_PointConstraintSettings_GetMutable_mDrawConstraintSize(_UnderlyingPtr);
                }
            }

            /// User data value (can be used by application)
            public new unsafe ref ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_PointConstraintSettings_GetMutable_mUserData(_Underlying *_this);
                    return ref *__JPH_PointConstraintSettings_GetMutable_mUserData(_UnderlyingPtr);
                }
            }

            internal unsafe PointConstraintSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe PointConstraintSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.PointConstraintSettings._Underlying *__JPH_PointConstraintSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_PointConstraintSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::PointConstraintSettings::PointConstraintSettings`.
            public unsafe PointConstraintSettings(Jolt.JPH._ByValue_PointConstraintSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.PointConstraintSettings._Underlying *__JPH_PointConstraintSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.PointConstraintSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_PointConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::PointConstraintSettings::PointConstraintSettings`.
            public PointConstraintSettings(Const_PointConstraintSettings _other) : this(new _ByValue_PointConstraintSettings(_other)) {}

            /// Generated from constructor `JPH::PointConstraintSettings::PointConstraintSettings`.
            public PointConstraintSettings(PointConstraintSettings _other) : this((Const_PointConstraintSettings)_other) {}

            /// Generated from method `JPH::PointConstraintSettings::operator=`.
            public unsafe Jolt.JPH.PointConstraintSettings Assign(Jolt.JPH._ByValue_PointConstraintSettings _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.PointConstraintSettings._Underlying *__JPH_PointConstraintSettings_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JPH.PointConstraintSettings._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_PointConstraintSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }
        }

        /// This is used as a function parameter when the underlying function receives `PointConstraintSettings` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `PointConstraintSettings`/`Const_PointConstraintSettings` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_PointConstraintSettings
        {
            #pragma warning disable CS0649
            internal readonly Const_PointConstraintSettings? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_PointConstraintSettings() {PassByMode = Jolt._PassBy.default_construct;}
            public _ByValue_PointConstraintSettings(Const_PointConstraintSettings new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
            public static implicit operator _ByValue_PointConstraintSettings(Const_PointConstraintSettings arg) {return new(arg);}
            public _ByValue_PointConstraintSettings(Jolt._Moved<PointConstraintSettings> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
            public static implicit operator _ByValue_PointConstraintSettings(Jolt._Moved<PointConstraintSettings> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `PointConstraintSettings` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_PointConstraintSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `PointConstraintSettings`/`Const_PointConstraintSettings` directly.
        public class _InOptMut_PointConstraintSettings
        {
            public PointConstraintSettings? Opt;

            public _InOptMut_PointConstraintSettings() {}
            public _InOptMut_PointConstraintSettings(PointConstraintSettings value) {Opt = value;}
            public static implicit operator _InOptMut_PointConstraintSettings(PointConstraintSettings value) {return new(value);}
        }

        /// This is used for optional parameters of class `PointConstraintSettings` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_PointConstraintSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `PointConstraintSettings`/`Const_PointConstraintSettings` to pass it to the function.
        public class _InOptConst_PointConstraintSettings
        {
            public Const_PointConstraintSettings? Opt;

            public _InOptConst_PointConstraintSettings() {}
            public _InOptConst_PointConstraintSettings(Const_PointConstraintSettings value) {Opt = value;}
            public static implicit operator _InOptConst_PointConstraintSettings(Const_PointConstraintSettings value) {return new(value);}
        }

        /// A point constraint constrains 2 bodies on a single point (removing 3 degrees of freedom)
        /// Generated from class `JPH::PointConstraint`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraint`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::Constraint>`
        ///     `JPH::NonCopyable`
        ///     `JPH::Constraint`
        /// This is the const half of the class.
        public class Const_PointConstraint : Jolt.Object<Const_PointConstraint>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraint_Destroy(_Underlying *_this);
                __JPH_PointConstraint_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_PointConstraint() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHConstraint(Const_PointConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHConstraint._Underlying *__JPH_PointConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHConstraint ret = new(__JPH_PointConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_PointConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_PointConstraint_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_PointConstraint_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_Constraint(Const_PointConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Constraint._Underlying *__JPH_PointConstraint_UpcastTo_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.Const_Constraint ret = new(__JPH_PointConstraint_UpcastTo_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_TwoBodyConstraint(Const_PointConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_TwoBodyConstraint._Underlying *__JPH_PointConstraint_UpcastTo_JPH_TwoBodyConstraint(_Underlying *_this);
                Jolt.JPH.Const_TwoBodyConstraint ret = new(__JPH_PointConstraint_UpcastTo_JPH_TwoBodyConstraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_PointConstraint?(Jolt.JPH.Const_Constraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PointConstraint_DynamicDowncastFrom_JPH_Constraint(Jolt.JPH.Const_Constraint._Underlying *_this);
                var ptr = __JPH_PointConstraint_DynamicDowncastFrom_JPH_Constraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_PointConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator Const_PointConstraint?(Jolt.JPH.Const_TwoBodyConstraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PointConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(Jolt.JPH.Const_TwoBodyConstraint._Underlying *_this);
                var ptr = __JPH_PointConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_PointConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe Const_PointConstraint(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Construct point constraint
            /// Generated from constructor `JPH::PointConstraint::PointConstraint`.
            public unsafe Const_PointConstraint(Jolt.JPH.Body inBody1, Jolt.JPH.Body inBody2, Jolt.JPH.Const_PointConstraintSettings inSettings) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.PointConstraint._Underlying *__JPH_PointConstraint_Construct(Jolt.JPH.Body._Underlying *inBody1, Jolt.JPH.Body._Underlying *inBody2, Jolt.JPH.Const_PointConstraintSettings._Underlying *inSettings);
                _UnderlyingPtr = __JPH_PointConstraint_Construct(inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inSettings._UnderlyingPtr);
            }

            /// Generated from method `JPH::PointConstraint::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PointConstraint_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PointConstraint_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_PointConstraint_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_PointConstraint_unsigned_long(inCount);
            }

            /// Generated from method `JPH::PointConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PointConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PointConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PointConstraint_void_ptr(void *inPointer);
                __Jolt_delete_JPH_PointConstraint_void_ptr(inPointer);
            }

            /// Generated from method `JPH::PointConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PointConstraint_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PointConstraint_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PointConstraint_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_PointConstraint_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::PointConstraint::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PointConstraint_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PointConstraint_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_PointConstraint_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_PointConstraint_unsigned_long(inCount);
            }

            /// Generated from method `JPH::PointConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PointConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PointConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PointConstraint_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_PointConstraint_void_ptr(inPointer);
            }

            /// Generated from method `JPH::PointConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PointConstraint_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PointConstraint_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PointConstraint_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_PointConstraint_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::PointConstraint::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PointConstraint_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PointConstraint_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_PointConstraint_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_PointConstraint_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::PointConstraint::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PointConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PointConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PointConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_PointConstraint_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::PointConstraint::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PointConstraint_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PointConstraint_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_PointConstraint_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_PointConstraint_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::PointConstraint::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PointConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PointConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PointConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_PointConstraint_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Solver interface
            /// Generated from method `JPH::PointConstraint::IsActive`.
            public unsafe bool IsActive()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_PointConstraint_IsActive(_Underlying *_this);
                return __JPH_PointConstraint_IsActive(_UnderlyingPtr) != 0;
            }

            /// Access to the connected bodies
            /// Generated from method `JPH::PointConstraint::GetBody1`.
            public unsafe Jolt.JPH.Body? GetBody1()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_GetBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_GetBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Body._Underlying *__JPH_PointConstraint_GetBody1(_Underlying *_this);
                var __c_ret = __JPH_PointConstraint_GetBody1(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Body(__c_ret, is_owning: false) : null;
            }

            /// Generated from method `JPH::PointConstraint::GetBody2`.
            public unsafe Jolt.JPH.Body? GetBody2()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_GetBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_GetBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Body._Underlying *__JPH_PointConstraint_GetBody2(_Underlying *_this);
                var __c_ret = __JPH_PointConstraint_GetBody2(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Body(__c_ret, is_owning: false) : null;
            }

            /// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
            /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
            /// Generated from method `JPH::PointConstraint::GetConstraintPriority`.
            public unsafe uint GetConstraintPriority()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_GetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_GetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_PointConstraint_GetConstraintPriority(_Underlying *_this);
                return __JPH_PointConstraint_GetConstraintPriority(_UnderlyingPtr);
            }

            /// Generated from method `JPH::PointConstraint::GetNumVelocityStepsOverride`.
            public unsafe uint GetNumVelocityStepsOverride()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_PointConstraint_GetNumVelocityStepsOverride(_Underlying *_this);
                return __JPH_PointConstraint_GetNumVelocityStepsOverride(_UnderlyingPtr);
            }

            /// Generated from method `JPH::PointConstraint::GetNumPositionStepsOverride`.
            public unsafe uint GetNumPositionStepsOverride()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_PointConstraint_GetNumPositionStepsOverride(_Underlying *_this);
                return __JPH_PointConstraint_GetNumPositionStepsOverride(_UnderlyingPtr);
            }

            /// Test if a constraint is enabled.
            /// Generated from method `JPH::PointConstraint::GetEnabled`.
            public unsafe bool GetEnabled()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_PointConstraint_GetEnabled(_Underlying *_this);
                return __JPH_PointConstraint_GetEnabled(_UnderlyingPtr) != 0;
            }

            /// Access to the user data, can be used for anything by the application
            /// Generated from method `JPH::PointConstraint::GetUserData`.
            public unsafe ulong GetUserData()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_PointConstraint_GetUserData(_Underlying *_this);
                return __JPH_PointConstraint_GetUserData(_UnderlyingPtr);
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::PointConstraint::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraint_SetEmbedded(_Underlying *_this);
                __JPH_PointConstraint_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::PointConstraint::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_PointConstraint_GetRefCount(_Underlying *_this);
                return __JPH_PointConstraint_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::PointConstraint::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraint_AddRef(_Underlying *_this);
                __JPH_PointConstraint_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::PointConstraint::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraint_Release(_Underlying *_this);
                __JPH_PointConstraint_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::PointConstraint::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_PointConstraint_sInternalGetRefCountOffset();
                return __JPH_PointConstraint_sInternalGetRefCountOffset();
            }
        }

        /// A point constraint constrains 2 bodies on a single point (removing 3 degrees of freedom)
        /// Generated from class `JPH::PointConstraint`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::TwoBodyConstraint`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::Constraint>`
        ///     `JPH::NonCopyable`
        ///     `JPH::Constraint`
        /// This is the non-const half of the class.
        public class PointConstraint : Const_PointConstraint
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHConstraint(PointConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHConstraint._Underlying *__JPH_PointConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHConstraint ret = new(__JPH_PointConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.NonCopyable(PointConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_PointConstraint_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_PointConstraint_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Constraint(PointConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Constraint._Underlying *__JPH_PointConstraint_UpcastTo_JPH_Constraint(_Underlying *_this);
                Jolt.JPH.Constraint ret = new(__JPH_PointConstraint_UpcastTo_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.TwoBodyConstraint(PointConstraint self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.TwoBodyConstraint._Underlying *__JPH_PointConstraint_UpcastTo_JPH_TwoBodyConstraint(_Underlying *_this);
                Jolt.JPH.TwoBodyConstraint ret = new(__JPH_PointConstraint_UpcastTo_JPH_TwoBodyConstraint(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator PointConstraint?(Jolt.JPH.Constraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_DynamicDowncastFrom_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PointConstraint_DynamicDowncastFrom_JPH_Constraint(Jolt.JPH.Constraint._Underlying *_this);
                var ptr = __JPH_PointConstraint_DynamicDowncastFrom_JPH_Constraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                PointConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }
            public static unsafe explicit operator PointConstraint?(Jolt.JPH.TwoBodyConstraint parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_PointConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(Jolt.JPH.TwoBodyConstraint._Underlying *_this);
                var ptr = __JPH_PointConstraint_DynamicDowncastFrom_JPH_TwoBodyConstraint(parent._UnderlyingPtr);
                if (ptr is null) return null;
                PointConstraint ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe PointConstraint(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Construct point constraint
            /// Generated from constructor `JPH::PointConstraint::PointConstraint`.
            public unsafe PointConstraint(Jolt.JPH.Body inBody1, Jolt.JPH.Body inBody2, Jolt.JPH.Const_PointConstraintSettings inSettings) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.PointConstraint._Underlying *__JPH_PointConstraint_Construct(Jolt.JPH.Body._Underlying *inBody1, Jolt.JPH.Body._Underlying *inBody2, Jolt.JPH.Const_PointConstraintSettings._Underlying *inSettings);
                _UnderlyingPtr = __JPH_PointConstraint_Construct(inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inSettings._UnderlyingPtr);
            }

            /// Generated from method `JPH::PointConstraint::SetupVelocityConstraint`.
            public unsafe void SetupVelocityConstraint(float inDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_SetupVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_SetupVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraint_SetupVelocityConstraint(_Underlying *_this, float inDeltaTime);
                __JPH_PointConstraint_SetupVelocityConstraint(_UnderlyingPtr, inDeltaTime);
            }

            /// Generated from method `JPH::PointConstraint::ResetWarmStart`.
            public unsafe void ResetWarmStart()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraint_ResetWarmStart(_Underlying *_this);
                __JPH_PointConstraint_ResetWarmStart(_UnderlyingPtr);
            }

            /// Generated from method `JPH::PointConstraint::WarmStartVelocityConstraint`.
            public unsafe void WarmStartVelocityConstraint(float inWarmStartImpulseRatio)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_WarmStartVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_WarmStartVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraint_WarmStartVelocityConstraint(_Underlying *_this, float inWarmStartImpulseRatio);
                __JPH_PointConstraint_WarmStartVelocityConstraint(_UnderlyingPtr, inWarmStartImpulseRatio);
            }

            /// Generated from method `JPH::PointConstraint::SolveVelocityConstraint`.
            public unsafe bool SolveVelocityConstraint(float inDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_SolveVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_SolveVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_PointConstraint_SolveVelocityConstraint(_Underlying *_this, float inDeltaTime);
                return __JPH_PointConstraint_SolveVelocityConstraint(_UnderlyingPtr, inDeltaTime) != 0;
            }

            /// Generated from method `JPH::PointConstraint::SolvePositionConstraint`.
            public unsafe bool SolvePositionConstraint(float inDeltaTime, float inBaumgarte)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_SolvePositionConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_SolvePositionConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_PointConstraint_SolvePositionConstraint(_Underlying *_this, float inDeltaTime, float inBaumgarte);
                return __JPH_PointConstraint_SolvePositionConstraint(_UnderlyingPtr, inDeltaTime, inBaumgarte) != 0;
            }

            /// Generated from method `JPH::PointConstraint::SetConstraintPriority`.
            public unsafe void SetConstraintPriority(uint inPriority)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_SetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_SetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraint_SetConstraintPriority(_Underlying *_this, uint inPriority);
                __JPH_PointConstraint_SetConstraintPriority(_UnderlyingPtr, inPriority);
            }

            /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
            /// Generated from method `JPH::PointConstraint::SetNumVelocityStepsOverride`.
            public unsafe void SetNumVelocityStepsOverride(uint inN)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraint_SetNumVelocityStepsOverride(_Underlying *_this, uint inN);
                __JPH_PointConstraint_SetNumVelocityStepsOverride(_UnderlyingPtr, inN);
            }

            /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
            /// Generated from method `JPH::PointConstraint::SetNumPositionStepsOverride`.
            public unsafe void SetNumPositionStepsOverride(uint inN)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraint_SetNumPositionStepsOverride(_Underlying *_this, uint inN);
                __JPH_PointConstraint_SetNumPositionStepsOverride(_UnderlyingPtr, inN);
            }

            /// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
            /// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
            /// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
            /// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
            /// Generated from method `JPH::PointConstraint::SetEnabled`.
            public unsafe void SetEnabled(bool inEnabled)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraint_SetEnabled(_Underlying *_this, byte inEnabled);
                __JPH_PointConstraint_SetEnabled(_UnderlyingPtr, inEnabled ? (byte)1 : (byte)0);
            }

            /// Generated from method `JPH::PointConstraint::SetUserData`.
            public unsafe void SetUserData(ulong inUserData)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PointConstraint_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PointConstraint_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PointConstraint_SetUserData(_Underlying *_this, ulong inUserData);
                __JPH_PointConstraint_SetUserData(_UnderlyingPtr, inUserData);
            }
        }

        /// This is used for optional parameters of class `PointConstraint` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_PointConstraint`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `PointConstraint`/`Const_PointConstraint` directly.
        public class _InOptMut_PointConstraint
        {
            public PointConstraint? Opt;

            public _InOptMut_PointConstraint() {}
            public _InOptMut_PointConstraint(PointConstraint value) {Opt = value;}
            public static implicit operator _InOptMut_PointConstraint(PointConstraint value) {return new(value);}
        }

        /// This is used for optional parameters of class `PointConstraint` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_PointConstraint`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `PointConstraint`/`Const_PointConstraint` to pass it to the function.
        public class _InOptConst_PointConstraint
        {
            public Const_PointConstraint? Opt;

            public _InOptConst_PointConstraint() {}
            public _InOptConst_PointConstraint(Const_PointConstraint value) {Opt = value;}
            public static implicit operator _InOptConst_PointConstraint(Const_PointConstraint value) {return new(value);}
        }
    }
}
