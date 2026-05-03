// machine generated, do not edit
public static partial class JPH
{
    /// Pulley constraint settings, used to create a pulley constraint.
    /// A pulley connects two bodies via two fixed world points to each other similar to a distance constraint.
    /// We define Length1 = |BodyPoint1 - FixedPoint1| where Body1 is a point on body 1 in world space and FixedPoint1 a fixed point in world space
    /// Length2 = |BodyPoint2 - FixedPoint2|
    /// The constraint keeps the two line segments constrained so that
    /// MinDistance <= Length1 + Ratio * Length2 <= MaxDistance
    /// Generated from class `JPH::PulleyConstraintSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TwoBodyConstraintSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ConstraintSettings>`
    ///     `JPH::ConstraintSettings`
    /// This is the const half of the class.
    public class Const_PulleyConstraintSettings : JPH.Object<Const_PulleyConstraintSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_Release(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_Release(__JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_PulleyConstraintSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_PulleyConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_PulleyConstraintSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_PulleyConstraintSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHConstraintSettings(Const_PulleyConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHConstraintSettings._Underlying *__JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHConstraintSettings ret = new(__JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ConstraintSettings(Const_PulleyConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ConstraintSettings._Underlying *__JPH_PulleyConstraintSettings_UpcastTo_JPH_ConstraintSettings(_Underlying *_this);
            JPH.Const_ConstraintSettings ret = new(__JPH_PulleyConstraintSettings_UpcastTo_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_TwoBodyConstraintSettings(Const_PulleyConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_TwoBodyConstraintSettings._Underlying *__JPH_PulleyConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(_Underlying *_this);
            JPH.Const_TwoBodyConstraintSettings ret = new(__JPH_PulleyConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        /// Body 1 constraint attachment point (space determined by mSpace).
        public unsafe JPH.Const_Vec3 mBodyPoint1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mBodyPoint1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mBodyPoint1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_PulleyConstraintSettings_Get_mBodyPoint1(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_PulleyConstraintSettings_Get_mBodyPoint1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// Fixed world point to which body 1 is connected (always world space)
        public unsafe JPH.Const_Vec3 mFixedPoint1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mFixedPoint1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mFixedPoint1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_PulleyConstraintSettings_Get_mFixedPoint1(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_PulleyConstraintSettings_Get_mFixedPoint1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// Body 2 constraint attachment point (space determined by mSpace)
        public unsafe JPH.Const_Vec3 mBodyPoint2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mBodyPoint2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mBodyPoint2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_PulleyConstraintSettings_Get_mBodyPoint2(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_PulleyConstraintSettings_Get_mBodyPoint2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// Fixed world point to which body 2 is connected (always world space)
        public unsafe JPH.Const_Vec3 mFixedPoint2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mFixedPoint2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mFixedPoint2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_PulleyConstraintSettings_Get_mFixedPoint2(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_PulleyConstraintSettings_Get_mFixedPoint2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// Ratio between the two line segments (see formula above), can be used to create a block and tackle
        public unsafe float mRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PulleyConstraintSettings_Get_mRatio(_Underlying *_this);
                return *__JPH_PulleyConstraintSettings_Get_mRatio(_UnderlyingPtr);
            }
        }

        /// The minimum length of the line segments (see formula above), use -1 to calculate the length based on the positions of the objects when the constraint is created.
        public unsafe float mMinLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PulleyConstraintSettings_Get_mMinLength(_Underlying *_this);
                return *__JPH_PulleyConstraintSettings_Get_mMinLength(_UnderlyingPtr);
            }
        }

        /// The maximum length of the line segments (see formula above), use -1 to calculate the length based on the positions of the objects when the constraint is created.
        public unsafe float mMaxLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PulleyConstraintSettings_Get_mMaxLength(_Underlying *_this);
                return *__JPH_PulleyConstraintSettings_Get_mMaxLength(_UnderlyingPtr);
            }
        }

        /// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
        public unsafe bool mEnabled
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PulleyConstraintSettings_Get_mEnabled(_Underlying *_this);
                return *__JPH_PulleyConstraintSettings_Get_mEnabled(_UnderlyingPtr);
            }
        }

        /// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
        /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
        public unsafe uint mConstraintPriority
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_PulleyConstraintSettings_Get_mConstraintPriority(_Underlying *_this);
                return *__JPH_PulleyConstraintSettings_Get_mConstraintPriority(_UnderlyingPtr);
            }
        }

        /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public unsafe uint mNumVelocityStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_PulleyConstraintSettings_Get_mNumVelocityStepsOverride(_Underlying *_this);
                return *__JPH_PulleyConstraintSettings_Get_mNumVelocityStepsOverride(_UnderlyingPtr);
            }
        }

        /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public unsafe uint mNumPositionStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_PulleyConstraintSettings_Get_mNumPositionStepsOverride(_Underlying *_this);
                return *__JPH_PulleyConstraintSettings_Get_mNumPositionStepsOverride(_UnderlyingPtr);
            }
        }

        /// Size of constraint when drawing it through the debug renderer
        public unsafe float mDrawConstraintSize
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PulleyConstraintSettings_Get_mDrawConstraintSize(_Underlying *_this);
                return *__JPH_PulleyConstraintSettings_Get_mDrawConstraintSize(_UnderlyingPtr);
            }
        }

        /// User data value (can be used by application)
        public unsafe UIntPtr mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static UIntPtr *__JPH_PulleyConstraintSettings_Get_mUserData(_Underlying *_this);
                return *__JPH_PulleyConstraintSettings_Get_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe Const_PulleyConstraintSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_PulleyConstraintSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PulleyConstraintSettings._Underlying *__JPH_PulleyConstraintSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_PulleyConstraintSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_AddRef(__JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::PulleyConstraintSettings::PulleyConstraintSettings`.
        public unsafe Const_PulleyConstraintSettings(JPH._ByValue_PulleyConstraintSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PulleyConstraintSettings._Underlying *__JPH_PulleyConstraintSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.PulleyConstraintSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_PulleyConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_AddRef(__JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::PulleyConstraintSettings::PulleyConstraintSettings`.
        public Const_PulleyConstraintSettings(Const_PulleyConstraintSettings _other) : this(new _ByValue_PulleyConstraintSettings(_other)) {}

        /// Generated from constructor `JPH::PulleyConstraintSettings::PulleyConstraintSettings`.
        public Const_PulleyConstraintSettings(PulleyConstraintSettings _other) : this((Const_PulleyConstraintSettings)_other) {}

        /// Generated from method `JPH::PulleyConstraintSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PulleyConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PulleyConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PulleyConstraintSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_PulleyConstraintSettings_size_t(inCount);
        }

        /// Generated from method `JPH::PulleyConstraintSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PulleyConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PulleyConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PulleyConstraintSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_PulleyConstraintSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PulleyConstraintSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PulleyConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PulleyConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PulleyConstraintSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_PulleyConstraintSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PulleyConstraintSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PulleyConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PulleyConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PulleyConstraintSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_PulleyConstraintSettings_size_t(inCount);
        }

        /// Generated from method `JPH::PulleyConstraintSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PulleyConstraintSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PulleyConstraintSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PulleyConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PulleyConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PulleyConstraintSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_PulleyConstraintSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PulleyConstraintSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PulleyConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PulleyConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PulleyConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_PulleyConstraintSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::PulleyConstraintSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PulleyConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PulleyConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PulleyConstraintSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_PulleyConstraintSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PulleyConstraintSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_PulleyConstraintSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Create an instance of this constraint
        /// Generated from method `JPH::PulleyConstraintSettings::Create`.
        public unsafe JPH.TwoBodyConstraint? Create(JPH.Body inBody1, JPH.Body inBody2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Create", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Create", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TwoBodyConstraint._Underlying *__JPH_PulleyConstraintSettings_Create(_Underlying *_this, JPH.Body._Underlying *inBody1, JPH.Body._Underlying *inBody2);
            var __c_ret = __JPH_PulleyConstraintSettings_Create(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr);
            return __c_ret is not null ? new JPH.TwoBodyConstraint(__c_ret, is_owning: false) : null;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::PulleyConstraintSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraintSettings_SetEmbedded(_Underlying *_this);
            __JPH_PulleyConstraintSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::PulleyConstraintSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_PulleyConstraintSettings_GetRefCount(_Underlying *_this);
            return __JPH_PulleyConstraintSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::PulleyConstraintSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraintSettings_AddRef(_Underlying *_this);
            __JPH_PulleyConstraintSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::PulleyConstraintSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraintSettings_Release(_Underlying *_this);
            __JPH_PulleyConstraintSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::PulleyConstraintSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_PulleyConstraintSettings_sInternalGetRefCountOffset();
            return __JPH_PulleyConstraintSettings_sInternalGetRefCountOffset();
        }
    }

    /// Pulley constraint settings, used to create a pulley constraint.
    /// A pulley connects two bodies via two fixed world points to each other similar to a distance constraint.
    /// We define Length1 = |BodyPoint1 - FixedPoint1| where Body1 is a point on body 1 in world space and FixedPoint1 a fixed point in world space
    /// Length2 = |BodyPoint2 - FixedPoint2|
    /// The constraint keeps the two line segments constrained so that
    /// MinDistance <= Length1 + Ratio * Length2 <= MaxDistance
    /// Generated from class `JPH::PulleyConstraintSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TwoBodyConstraintSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ConstraintSettings>`
    ///     `JPH::ConstraintSettings`
    /// This is the non-const half of the class.
    public class PulleyConstraintSettings : Const_PulleyConstraintSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(PulleyConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_PulleyConstraintSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_PulleyConstraintSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.RefTarget_JPHConstraintSettings(PulleyConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraintSettings._Underlying *__JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            JPH.RefTarget_JPHConstraintSettings ret = new(__JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ConstraintSettings(PulleyConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ConstraintSettings._Underlying *__JPH_PulleyConstraintSettings_UpcastTo_JPH_ConstraintSettings(_Underlying *_this);
            JPH.ConstraintSettings ret = new(__JPH_PulleyConstraintSettings_UpcastTo_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.TwoBodyConstraintSettings(PulleyConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TwoBodyConstraintSettings._Underlying *__JPH_PulleyConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(_Underlying *_this);
            JPH.TwoBodyConstraintSettings ret = new(__JPH_PulleyConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        /// Body 1 constraint attachment point (space determined by mSpace).
        public new unsafe JPH.Vec3 mBodyPoint1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mBodyPoint1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mBodyPoint1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_PulleyConstraintSettings_GetMutable_mBodyPoint1(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_PulleyConstraintSettings_GetMutable_mBodyPoint1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// Fixed world point to which body 1 is connected (always world space)
        public new unsafe JPH.Vec3 mFixedPoint1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mFixedPoint1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mFixedPoint1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_PulleyConstraintSettings_GetMutable_mFixedPoint1(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_PulleyConstraintSettings_GetMutable_mFixedPoint1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// Body 2 constraint attachment point (space determined by mSpace)
        public new unsafe JPH.Vec3 mBodyPoint2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mBodyPoint2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mBodyPoint2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_PulleyConstraintSettings_GetMutable_mBodyPoint2(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_PulleyConstraintSettings_GetMutable_mBodyPoint2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// Fixed world point to which body 2 is connected (always world space)
        public new unsafe JPH.Vec3 mFixedPoint2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mFixedPoint2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mFixedPoint2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_PulleyConstraintSettings_GetMutable_mFixedPoint2(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_PulleyConstraintSettings_GetMutable_mFixedPoint2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// Ratio between the two line segments (see formula above), can be used to create a block and tackle
        public new unsafe ref float mRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mRatio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PulleyConstraintSettings_GetMutable_mRatio(_Underlying *_this);
                return ref *__JPH_PulleyConstraintSettings_GetMutable_mRatio(_UnderlyingPtr);
            }
        }

        /// The minimum length of the line segments (see formula above), use -1 to calculate the length based on the positions of the objects when the constraint is created.
        public new unsafe ref float mMinLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PulleyConstraintSettings_GetMutable_mMinLength(_Underlying *_this);
                return ref *__JPH_PulleyConstraintSettings_GetMutable_mMinLength(_UnderlyingPtr);
            }
        }

        /// The maximum length of the line segments (see formula above), use -1 to calculate the length based on the positions of the objects when the constraint is created.
        public new unsafe ref float mMaxLength
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PulleyConstraintSettings_GetMutable_mMaxLength(_Underlying *_this);
                return ref *__JPH_PulleyConstraintSettings_GetMutable_mMaxLength(_UnderlyingPtr);
            }
        }

        /// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
        public new unsafe ref bool mEnabled
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PulleyConstraintSettings_GetMutable_mEnabled(_Underlying *_this);
                return ref *__JPH_PulleyConstraintSettings_GetMutable_mEnabled(_UnderlyingPtr);
            }
        }

        /// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
        /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
        public new unsafe ref uint mConstraintPriority
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_PulleyConstraintSettings_GetMutable_mConstraintPriority(_Underlying *_this);
                return ref *__JPH_PulleyConstraintSettings_GetMutable_mConstraintPriority(_UnderlyingPtr);
            }
        }

        /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public new unsafe ref uint mNumVelocityStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_PulleyConstraintSettings_GetMutable_mNumVelocityStepsOverride(_Underlying *_this);
                return ref *__JPH_PulleyConstraintSettings_GetMutable_mNumVelocityStepsOverride(_UnderlyingPtr);
            }
        }

        /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public new unsafe ref uint mNumPositionStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_PulleyConstraintSettings_GetMutable_mNumPositionStepsOverride(_Underlying *_this);
                return ref *__JPH_PulleyConstraintSettings_GetMutable_mNumPositionStepsOverride(_UnderlyingPtr);
            }
        }

        /// Size of constraint when drawing it through the debug renderer
        public new unsafe ref float mDrawConstraintSize
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PulleyConstraintSettings_GetMutable_mDrawConstraintSize(_Underlying *_this);
                return ref *__JPH_PulleyConstraintSettings_GetMutable_mDrawConstraintSize(_UnderlyingPtr);
            }
        }

        /// User data value (can be used by application)
        public new unsafe ref UIntPtr mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static UIntPtr *__JPH_PulleyConstraintSettings_GetMutable_mUserData(_Underlying *_this);
                return ref *__JPH_PulleyConstraintSettings_GetMutable_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe PulleyConstraintSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe PulleyConstraintSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PulleyConstraintSettings._Underlying *__JPH_PulleyConstraintSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_PulleyConstraintSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_AddRef(__JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::PulleyConstraintSettings::PulleyConstraintSettings`.
        public unsafe PulleyConstraintSettings(JPH._ByValue_PulleyConstraintSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PulleyConstraintSettings._Underlying *__JPH_PulleyConstraintSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.PulleyConstraintSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_PulleyConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_AddRef(__JPH_PulleyConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::PulleyConstraintSettings::PulleyConstraintSettings`.
        public PulleyConstraintSettings(Const_PulleyConstraintSettings _other) : this(new _ByValue_PulleyConstraintSettings(_other)) {}

        /// Generated from constructor `JPH::PulleyConstraintSettings::PulleyConstraintSettings`.
        public PulleyConstraintSettings(PulleyConstraintSettings _other) : this((Const_PulleyConstraintSettings)_other) {}

        /// Generated from method `JPH::PulleyConstraintSettings::operator=`.
        public unsafe JPH.PulleyConstraintSettings Assign(JPH._ByValue_PulleyConstraintSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PulleyConstraintSettings._Underlying *__JPH_PulleyConstraintSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.PulleyConstraintSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_PulleyConstraintSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `PulleyConstraintSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `PulleyConstraintSettings`/`Const_PulleyConstraintSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_PulleyConstraintSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_PulleyConstraintSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_PulleyConstraintSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_PulleyConstraintSettings(Const_PulleyConstraintSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_PulleyConstraintSettings(Const_PulleyConstraintSettings arg) {return new(arg);}
        public _ByValue_PulleyConstraintSettings(JPH._Moved<PulleyConstraintSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_PulleyConstraintSettings(JPH._Moved<PulleyConstraintSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `PulleyConstraintSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_PulleyConstraintSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PulleyConstraintSettings`/`Const_PulleyConstraintSettings` directly.
    public class _InOptMut_PulleyConstraintSettings
    {
        public PulleyConstraintSettings? Opt;

        public _InOptMut_PulleyConstraintSettings() {}
        public _InOptMut_PulleyConstraintSettings(PulleyConstraintSettings value) {Opt = value;}
        public static implicit operator _InOptMut_PulleyConstraintSettings(PulleyConstraintSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `PulleyConstraintSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_PulleyConstraintSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PulleyConstraintSettings`/`Const_PulleyConstraintSettings` to pass it to the function.
    public class _InOptConst_PulleyConstraintSettings
    {
        public Const_PulleyConstraintSettings? Opt;

        public _InOptConst_PulleyConstraintSettings() {}
        public _InOptConst_PulleyConstraintSettings(Const_PulleyConstraintSettings value) {Opt = value;}
        public static implicit operator _InOptConst_PulleyConstraintSettings(Const_PulleyConstraintSettings value) {return new(value);}
    }

    /// A pulley constraint.
    /// Generated from class `JPH::PulleyConstraint`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TwoBodyConstraint`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Constraint>`
    ///     `JPH::NonCopyable`
    ///     `JPH::Constraint`
    /// This is the const half of the class.
    public class Const_PulleyConstraint : JPH.Object<Const_PulleyConstraint>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Constraint_Release(void *_this);
            __JPH_RefTarget_JPH_Constraint_Release(__JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_PulleyConstraint() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHConstraint(Const_PulleyConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHConstraint._Underlying *__JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            JPH.Const_RefTarget_JPHConstraint ret = new(__JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_PulleyConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_PulleyConstraint_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_PulleyConstraint_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Constraint(Const_PulleyConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Constraint._Underlying *__JPH_PulleyConstraint_UpcastTo_JPH_Constraint(_Underlying *_this);
            JPH.Const_Constraint ret = new(__JPH_PulleyConstraint_UpcastTo_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_TwoBodyConstraint(Const_PulleyConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_TwoBodyConstraint._Underlying *__JPH_PulleyConstraint_UpcastTo_JPH_TwoBodyConstraint(_Underlying *_this);
            JPH.Const_TwoBodyConstraint ret = new(__JPH_PulleyConstraint_UpcastTo_JPH_TwoBodyConstraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe Const_PulleyConstraint(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Construct pulley constraint
        /// Generated from constructor `JPH::PulleyConstraint::PulleyConstraint`.
        public unsafe Const_PulleyConstraint(JPH.Body inBody1, JPH.Body inBody2, JPH.Const_PulleyConstraintSettings inSettings) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PulleyConstraint._Underlying *__JPH_PulleyConstraint_Construct(JPH.Body._Underlying *inBody1, JPH.Body._Underlying *inBody2, JPH.Const_PulleyConstraintSettings._Underlying *inSettings);
            _UnderlyingPtr = __JPH_PulleyConstraint_Construct(inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inSettings._UnderlyingPtr);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Constraint_AddRef(void *_this);
            __JPH_RefTarget_JPH_Constraint_AddRef(__JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_UnderlyingPtr));
        }

        /// Generated from method `JPH::PulleyConstraint::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PulleyConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PulleyConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PulleyConstraint_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_PulleyConstraint_size_t(inCount);
        }

        /// Generated from method `JPH::PulleyConstraint::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PulleyConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PulleyConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PulleyConstraint_void_ptr(void *inPointer);
            __Jolt_delete_JPH_PulleyConstraint_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PulleyConstraint::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PulleyConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PulleyConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PulleyConstraint_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_PulleyConstraint_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PulleyConstraint::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PulleyConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PulleyConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PulleyConstraint_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_PulleyConstraint_size_t(inCount);
        }

        /// Generated from method `JPH::PulleyConstraint::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PulleyConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PulleyConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PulleyConstraint_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_PulleyConstraint_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PulleyConstraint::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PulleyConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PulleyConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PulleyConstraint_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_PulleyConstraint_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PulleyConstraint::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PulleyConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PulleyConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PulleyConstraint_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_PulleyConstraint_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PulleyConstraint::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PulleyConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PulleyConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PulleyConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_PulleyConstraint_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::PulleyConstraint::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PulleyConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PulleyConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PulleyConstraint_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_PulleyConstraint_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PulleyConstraint::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PulleyConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PulleyConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PulleyConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_PulleyConstraint_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::PulleyConstraint::DrawConstraint`.
        public unsafe void DrawConstraint(JPH.DebugRenderer? inRenderer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_DrawConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_DrawConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_DrawConstraint(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer);
            __JPH_PulleyConstraint_DrawConstraint(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null);
        }

        // See: TwoBodyConstraint
        /// Generated from method `JPH::PulleyConstraint::GetConstraintToBody1Matrix`.
        public unsafe JPH.Mat44 GetConstraintToBody1Matrix()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetConstraintToBody1Matrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetConstraintToBody1Matrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_PulleyConstraint_GetConstraintToBody1Matrix(_Underlying *_this);
            return new(__JPH_PulleyConstraint_GetConstraintToBody1Matrix(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::PulleyConstraint::GetConstraintToBody2Matrix`.
        public unsafe JPH.Mat44 GetConstraintToBody2Matrix()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetConstraintToBody2Matrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetConstraintToBody2Matrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_PulleyConstraint_GetConstraintToBody2Matrix(_Underlying *_this);
            return new(__JPH_PulleyConstraint_GetConstraintToBody2Matrix(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::PulleyConstraint::GetMinLength`.
        public unsafe float GetMinLength()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetMinLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_PulleyConstraint_GetMinLength(_Underlying *_this);
            return __JPH_PulleyConstraint_GetMinLength(_UnderlyingPtr);
        }

        /// Generated from method `JPH::PulleyConstraint::GetMaxLength`.
        public unsafe float GetMaxLength()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetMaxLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_PulleyConstraint_GetMaxLength(_Underlying *_this);
            return __JPH_PulleyConstraint_GetMaxLength(_UnderlyingPtr);
        }

        /// Get the current length of both segments (multiplied by the ratio for segment 2)
        /// Generated from method `JPH::PulleyConstraint::GetCurrentLength`.
        public unsafe float GetCurrentLength()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetCurrentLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetCurrentLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_PulleyConstraint_GetCurrentLength(_Underlying *_this);
            return __JPH_PulleyConstraint_GetCurrentLength(_UnderlyingPtr);
        }

        ///@name Get Lagrange multiplier from last physics update (the linear impulse applied to satisfy the constraint)
        /// Generated from method `JPH::PulleyConstraint::GetTotalLambdaPosition`.
        public unsafe float GetTotalLambdaPosition()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetTotalLambdaPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetTotalLambdaPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_PulleyConstraint_GetTotalLambdaPosition(_Underlying *_this);
            return __JPH_PulleyConstraint_GetTotalLambdaPosition(_UnderlyingPtr);
        }

        /// Solver interface
        /// Generated from method `JPH::PulleyConstraint::IsActive`.
        public unsafe bool IsActive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_PulleyConstraint_IsActive(_Underlying *_this);
            return __JPH_PulleyConstraint_IsActive(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JPH::PulleyConstraint::DrawConstraintReferenceFrame`.
        public unsafe void DrawConstraintReferenceFrame(JPH.DebugRenderer? inRenderer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_DrawConstraintReferenceFrame", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_DrawConstraintReferenceFrame", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_DrawConstraintReferenceFrame(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer);
            __JPH_PulleyConstraint_DrawConstraintReferenceFrame(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null);
        }

        /// Access to the connected bodies
        /// Generated from method `JPH::PulleyConstraint::GetBody1`.
        public unsafe JPH.Body? GetBody1()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Body._Underlying *__JPH_PulleyConstraint_GetBody1(_Underlying *_this);
            var __c_ret = __JPH_PulleyConstraint_GetBody1(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Body(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::PulleyConstraint::GetBody2`.
        public unsafe JPH.Body? GetBody2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Body._Underlying *__JPH_PulleyConstraint_GetBody2(_Underlying *_this);
            var __c_ret = __JPH_PulleyConstraint_GetBody2(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Body(__c_ret, is_owning: false) : null;
        }

        /// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
        /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
        /// Generated from method `JPH::PulleyConstraint::GetConstraintPriority`.
        public unsafe uint GetConstraintPriority()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_PulleyConstraint_GetConstraintPriority(_Underlying *_this);
            return __JPH_PulleyConstraint_GetConstraintPriority(_UnderlyingPtr);
        }

        /// Generated from method `JPH::PulleyConstraint::GetNumVelocityStepsOverride`.
        public unsafe uint GetNumVelocityStepsOverride()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_PulleyConstraint_GetNumVelocityStepsOverride(_Underlying *_this);
            return __JPH_PulleyConstraint_GetNumVelocityStepsOverride(_UnderlyingPtr);
        }

        /// Generated from method `JPH::PulleyConstraint::GetNumPositionStepsOverride`.
        public unsafe uint GetNumPositionStepsOverride()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_PulleyConstraint_GetNumPositionStepsOverride(_Underlying *_this);
            return __JPH_PulleyConstraint_GetNumPositionStepsOverride(_UnderlyingPtr);
        }

        /// Test if a constraint is enabled.
        /// Generated from method `JPH::PulleyConstraint::GetEnabled`.
        public unsafe bool GetEnabled()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_PulleyConstraint_GetEnabled(_Underlying *_this);
            return __JPH_PulleyConstraint_GetEnabled(_UnderlyingPtr) != 0;
        }

        /// Access to the user data, can be used for anything by the application
        /// Generated from method `JPH::PulleyConstraint::GetUserData`.
        public unsafe UIntPtr GetUserData()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_PulleyConstraint_GetUserData(_Underlying *_this);
            return __JPH_PulleyConstraint_GetUserData(_UnderlyingPtr);
        }

        /// Generated from method `JPH::PulleyConstraint::DrawConstraintLimits`.
        public unsafe void DrawConstraintLimits(JPH.DebugRenderer? inRenderer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_DrawConstraintLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_DrawConstraintLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_DrawConstraintLimits(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer);
            __JPH_PulleyConstraint_DrawConstraintLimits(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null);
        }

        /// Size of constraint when drawing it through the debug renderer
        /// Generated from method `JPH::PulleyConstraint::GetDrawConstraintSize`.
        public unsafe float GetDrawConstraintSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_PulleyConstraint_GetDrawConstraintSize(_Underlying *_this);
            return __JPH_PulleyConstraint_GetDrawConstraintSize(_UnderlyingPtr);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::PulleyConstraint::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_SetEmbedded(_Underlying *_this);
            __JPH_PulleyConstraint_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::PulleyConstraint::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_PulleyConstraint_GetRefCount(_Underlying *_this);
            return __JPH_PulleyConstraint_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::PulleyConstraint::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_AddRef(_Underlying *_this);
            __JPH_PulleyConstraint_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::PulleyConstraint::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_Release(_Underlying *_this);
            __JPH_PulleyConstraint_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::PulleyConstraint::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_PulleyConstraint_sInternalGetRefCountOffset();
            return __JPH_PulleyConstraint_sInternalGetRefCountOffset();
        }
    }

    /// A pulley constraint.
    /// Generated from class `JPH::PulleyConstraint`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TwoBodyConstraint`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Constraint>`
    ///     `JPH::NonCopyable`
    ///     `JPH::Constraint`
    /// This is the non-const half of the class.
    public class PulleyConstraint : Const_PulleyConstraint
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHConstraint(PulleyConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraint._Underlying *__JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            JPH.RefTarget_JPHConstraint ret = new(__JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.NonCopyable(PulleyConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_PulleyConstraint_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_PulleyConstraint_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Constraint(PulleyConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Constraint._Underlying *__JPH_PulleyConstraint_UpcastTo_JPH_Constraint(_Underlying *_this);
            JPH.Constraint ret = new(__JPH_PulleyConstraint_UpcastTo_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.TwoBodyConstraint(PulleyConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TwoBodyConstraint._Underlying *__JPH_PulleyConstraint_UpcastTo_JPH_TwoBodyConstraint(_Underlying *_this);
            JPH.TwoBodyConstraint ret = new(__JPH_PulleyConstraint_UpcastTo_JPH_TwoBodyConstraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe PulleyConstraint(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Construct pulley constraint
        /// Generated from constructor `JPH::PulleyConstraint::PulleyConstraint`.
        public unsafe PulleyConstraint(JPH.Body inBody1, JPH.Body inBody2, JPH.Const_PulleyConstraintSettings inSettings) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PulleyConstraint._Underlying *__JPH_PulleyConstraint_Construct(JPH.Body._Underlying *inBody1, JPH.Body._Underlying *inBody2, JPH.Const_PulleyConstraintSettings._Underlying *inSettings);
            _UnderlyingPtr = __JPH_PulleyConstraint_Construct(inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inSettings._UnderlyingPtr);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Constraint_AddRef(void *_this);
            __JPH_RefTarget_JPH_Constraint_AddRef(__JPH_PulleyConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_UnderlyingPtr));
        }

        /// Generated from method `JPH::PulleyConstraint::NotifyShapeChanged`.
        public unsafe void NotifyShapeChanged(in JPH.BodyID inBodyID, JPH.Const_Vec3 inDeltaCOM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_NotifyShapeChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_NotifyShapeChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_NotifyShapeChanged(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inDeltaCOM);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_PulleyConstraint_NotifyShapeChanged(_UnderlyingPtr, __ptr_inBodyID, inDeltaCOM._UnderlyingPtr);
            }
        }

        /// Generated from method `JPH::PulleyConstraint::SetupVelocityConstraint`.
        public unsafe void SetupVelocityConstraint(float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_SetupVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_SetupVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_SetupVelocityConstraint(_Underlying *_this, float inDeltaTime);
            __JPH_PulleyConstraint_SetupVelocityConstraint(_UnderlyingPtr, inDeltaTime);
        }

        /// Generated from method `JPH::PulleyConstraint::ResetWarmStart`.
        public unsafe void ResetWarmStart()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_ResetWarmStart(_Underlying *_this);
            __JPH_PulleyConstraint_ResetWarmStart(_UnderlyingPtr);
        }

        /// Generated from method `JPH::PulleyConstraint::WarmStartVelocityConstraint`.
        public unsafe void WarmStartVelocityConstraint(float inWarmStartImpulseRatio)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_WarmStartVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_WarmStartVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_WarmStartVelocityConstraint(_Underlying *_this, float inWarmStartImpulseRatio);
            __JPH_PulleyConstraint_WarmStartVelocityConstraint(_UnderlyingPtr, inWarmStartImpulseRatio);
        }

        /// Generated from method `JPH::PulleyConstraint::SolveVelocityConstraint`.
        public unsafe bool SolveVelocityConstraint(float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_SolveVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_SolveVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_PulleyConstraint_SolveVelocityConstraint(_Underlying *_this, float inDeltaTime);
            return __JPH_PulleyConstraint_SolveVelocityConstraint(_UnderlyingPtr, inDeltaTime) != 0;
        }

        /// Generated from method `JPH::PulleyConstraint::SolvePositionConstraint`.
        public unsafe bool SolvePositionConstraint(float inDeltaTime, float inBaumgarte)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_SolvePositionConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_SolvePositionConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_PulleyConstraint_SolvePositionConstraint(_Underlying *_this, float inDeltaTime, float inBaumgarte);
            return __JPH_PulleyConstraint_SolvePositionConstraint(_UnderlyingPtr, inDeltaTime, inBaumgarte) != 0;
        }

        /// Update the minimum and maximum length for the constraint
        /// Generated from method `JPH::PulleyConstraint::SetLength`.
        public unsafe void SetLength(float inMinLength, float inMaxLength)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_SetLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_SetLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_SetLength(_Underlying *_this, float inMinLength, float inMaxLength);
            __JPH_PulleyConstraint_SetLength(_UnderlyingPtr, inMinLength, inMaxLength);
        }

        /// Generated from method `JPH::PulleyConstraint::SetConstraintPriority`.
        public unsafe void SetConstraintPriority(uint inPriority)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_SetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_SetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_SetConstraintPriority(_Underlying *_this, uint inPriority);
            __JPH_PulleyConstraint_SetConstraintPriority(_UnderlyingPtr, inPriority);
        }

        /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
        /// Generated from method `JPH::PulleyConstraint::SetNumVelocityStepsOverride`.
        public unsafe void SetNumVelocityStepsOverride(uint inN)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_SetNumVelocityStepsOverride(_Underlying *_this, uint inN);
            __JPH_PulleyConstraint_SetNumVelocityStepsOverride(_UnderlyingPtr, inN);
        }

        /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
        /// Generated from method `JPH::PulleyConstraint::SetNumPositionStepsOverride`.
        public unsafe void SetNumPositionStepsOverride(uint inN)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_SetNumPositionStepsOverride(_Underlying *_this, uint inN);
            __JPH_PulleyConstraint_SetNumPositionStepsOverride(_UnderlyingPtr, inN);
        }

        /// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
        /// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
        /// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
        /// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
        /// Generated from method `JPH::PulleyConstraint::SetEnabled`.
        public unsafe void SetEnabled(bool inEnabled)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_SetEnabled(_Underlying *_this, byte inEnabled);
            __JPH_PulleyConstraint_SetEnabled(_UnderlyingPtr, inEnabled ? (byte)1 : (byte)0);
        }

        /// Generated from method `JPH::PulleyConstraint::SetUserData`.
        public unsafe void SetUserData(UIntPtr inUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_SetUserData(_Underlying *_this, UIntPtr inUserData);
            __JPH_PulleyConstraint_SetUserData(_UnderlyingPtr, inUserData);
        }

        /// Generated from method `JPH::PulleyConstraint::SetDrawConstraintSize`.
        public unsafe void SetDrawConstraintSize(float inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PulleyConstraint_SetDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PulleyConstraint_SetDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PulleyConstraint_SetDrawConstraintSize(_Underlying *_this, float inSize);
            __JPH_PulleyConstraint_SetDrawConstraintSize(_UnderlyingPtr, inSize);
        }
    }

    /// This is used for optional parameters of class `PulleyConstraint` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_PulleyConstraint`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PulleyConstraint`/`Const_PulleyConstraint` directly.
    public class _InOptMut_PulleyConstraint
    {
        public PulleyConstraint? Opt;

        public _InOptMut_PulleyConstraint() {}
        public _InOptMut_PulleyConstraint(PulleyConstraint value) {Opt = value;}
        public static implicit operator _InOptMut_PulleyConstraint(PulleyConstraint value) {return new(value);}
    }

    /// This is used for optional parameters of class `PulleyConstraint` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_PulleyConstraint`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PulleyConstraint`/`Const_PulleyConstraint` to pass it to the function.
    public class _InOptConst_PulleyConstraint
    {
        public Const_PulleyConstraint? Opt;

        public _InOptConst_PulleyConstraint() {}
        public _InOptConst_PulleyConstraint(Const_PulleyConstraint value) {Opt = value;}
        public static implicit operator _InOptConst_PulleyConstraint(Const_PulleyConstraint value) {return new(value);}
    }
}
