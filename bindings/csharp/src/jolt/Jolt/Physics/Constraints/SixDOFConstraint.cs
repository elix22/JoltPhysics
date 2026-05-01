// machine generated, do not edit
public static partial class JPH
{
    /// 6 Degree Of Freedom Constraint setup structure. Allows control over each of the 6 degrees of freedom.
    /// Generated from class `JPH::SixDOFConstraintSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TwoBodyConstraintSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ConstraintSettings>`
    ///     `JPH::ConstraintSettings`
    /// This is the const half of the class.
    public class Const_SixDOFConstraintSettings : JPH.Object<Const_SixDOFConstraintSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_Release(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_Release(__JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SixDOFConstraintSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_SixDOFConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_SixDOFConstraintSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_SixDOFConstraintSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHConstraintSettings(Const_SixDOFConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHConstraintSettings._Underlying *__JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            JPH.Const_RefTarget_JPHConstraintSettings ret = new(__JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ConstraintSettings(Const_SixDOFConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ConstraintSettings._Underlying *__JPH_SixDOFConstraintSettings_UpcastTo_JPH_ConstraintSettings(_Underlying *_this);
            JPH.Const_ConstraintSettings ret = new(__JPH_SixDOFConstraintSettings_UpcastTo_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_TwoBodyConstraintSettings(Const_SixDOFConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_TwoBodyConstraintSettings._Underlying *__JPH_SixDOFConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(_Underlying *_this);
            JPH.Const_TwoBodyConstraintSettings ret = new(__JPH_SixDOFConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        /// Body 1 constraint reference frame (space determined by mSpace)
        public unsafe JPH.Const_Vec3 mPosition1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mPosition1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mPosition1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_SixDOFConstraintSettings_Get_mPosition1(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_SixDOFConstraintSettings_Get_mPosition1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Vec3 mAxisX1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mAxisX1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mAxisX1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_SixDOFConstraintSettings_Get_mAxisX1(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_SixDOFConstraintSettings_Get_mAxisX1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Vec3 mAxisY1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mAxisY1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mAxisY1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_SixDOFConstraintSettings_Get_mAxisY1(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_SixDOFConstraintSettings_Get_mAxisY1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// Body 2 constraint reference frame (space determined by mSpace)
        public unsafe JPH.Const_Vec3 mPosition2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mPosition2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mPosition2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_SixDOFConstraintSettings_Get_mPosition2(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_SixDOFConstraintSettings_Get_mPosition2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Vec3 mAxisX2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mAxisX2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mAxisX2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_SixDOFConstraintSettings_Get_mAxisX2(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_SixDOFConstraintSettings_Get_mAxisX2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Vec3 mAxisY2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mAxisY2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mAxisY2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_SixDOFConstraintSettings_Get_mAxisY2(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_SixDOFConstraintSettings_Get_mAxisY2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// Friction settings.
        /// For translation: Max friction force in N. 0 = no friction.
        /// For rotation: Max friction torque in Nm. 0 = no friction.
        public unsafe ref JPH.ArrayFloat6 mMaxFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mMaxFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mMaxFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ArrayFloat6 *__JPH_SixDOFConstraintSettings_Get_mMaxFriction(_Underlying *_this);
                return ref *(__JPH_SixDOFConstraintSettings_Get_mMaxFriction(_UnderlyingPtr));
            }
        }

        /// Limits.
        /// For translation: Min and max linear limits in m (0 is frame of body 1 and 2 coincide).
        /// For rotation: Min and max angular limits in rad (0 is frame of body 1 and 2 coincide). See comments at Axis enum for limit ranges.
        ///
        /// Remove degree of freedom by setting min = FLT_MAX and max = -FLT_MAX. The constraint will be driven to 0 for this axis.
        ///
        /// Free movement over an axis is allowed when min = -FLT_MAX and max = FLT_MAX.
        ///
        /// Rotation limit around X-Axis: When limited, should be \f$\in [-\pi, \pi]\f$. Can be asymmetric around zero.
        ///
        /// Rotation limit around Y-Z Axis: Forms a pyramid or cone shaped limit:
        /// * For pyramid, should be \f$\in [-\pi, \pi]\f$ and does not need to be symmetrical around zero.
        /// * For cone should be \f$\in [0, \pi]\f$ and needs to be symmetrical around zero (min limit is assumed to be -max limit).
        public unsafe ref JPH.ArrayFloat6 mLimitMin
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mLimitMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mLimitMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ArrayFloat6 *__JPH_SixDOFConstraintSettings_Get_mLimitMin(_Underlying *_this);
                return ref *(__JPH_SixDOFConstraintSettings_Get_mLimitMin(_UnderlyingPtr));
            }
        }

        public unsafe ref JPH.ArrayFloat6 mLimitMax
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mLimitMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mLimitMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ArrayFloat6 *__JPH_SixDOFConstraintSettings_Get_mLimitMax(_Underlying *_this);
                return ref *(__JPH_SixDOFConstraintSettings_Get_mLimitMax(_UnderlyingPtr));
            }
        }

        /// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
        public unsafe bool mEnabled
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_SixDOFConstraintSettings_Get_mEnabled(_Underlying *_this);
                return *__JPH_SixDOFConstraintSettings_Get_mEnabled(_UnderlyingPtr);
            }
        }

        /// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
        /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
        public unsafe uint mConstraintPriority
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_SixDOFConstraintSettings_Get_mConstraintPriority(_Underlying *_this);
                return *__JPH_SixDOFConstraintSettings_Get_mConstraintPriority(_UnderlyingPtr);
            }
        }

        /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public unsafe uint mNumVelocityStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_SixDOFConstraintSettings_Get_mNumVelocityStepsOverride(_Underlying *_this);
                return *__JPH_SixDOFConstraintSettings_Get_mNumVelocityStepsOverride(_UnderlyingPtr);
            }
        }

        /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public unsafe uint mNumPositionStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_SixDOFConstraintSettings_Get_mNumPositionStepsOverride(_Underlying *_this);
                return *__JPH_SixDOFConstraintSettings_Get_mNumPositionStepsOverride(_UnderlyingPtr);
            }
        }

        /// Size of constraint when drawing it through the debug renderer
        public unsafe float mDrawConstraintSize
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SixDOFConstraintSettings_Get_mDrawConstraintSize(_Underlying *_this);
                return *__JPH_SixDOFConstraintSettings_Get_mDrawConstraintSize(_UnderlyingPtr);
            }
        }

        /// User data value (can be used by application)
        public unsafe UIntPtr mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static UIntPtr *__JPH_SixDOFConstraintSettings_Get_mUserData(_Underlying *_this);
                return *__JPH_SixDOFConstraintSettings_Get_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe Const_SixDOFConstraintSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_SixDOFConstraintSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SixDOFConstraintSettings._Underlying *__JPH_SixDOFConstraintSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_SixDOFConstraintSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_AddRef(__JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::SixDOFConstraintSettings::SixDOFConstraintSettings`.
        public unsafe Const_SixDOFConstraintSettings(JPH._ByValue_SixDOFConstraintSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SixDOFConstraintSettings._Underlying *__JPH_SixDOFConstraintSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SixDOFConstraintSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_SixDOFConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_AddRef(__JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::SixDOFConstraintSettings::SixDOFConstraintSettings`.
        public Const_SixDOFConstraintSettings(Const_SixDOFConstraintSettings _other) : this(new _ByValue_SixDOFConstraintSettings(_other)) {}

        /// Generated from constructor `JPH::SixDOFConstraintSettings::SixDOFConstraintSettings`.
        public Const_SixDOFConstraintSettings(SixDOFConstraintSettings _other) : this((Const_SixDOFConstraintSettings)_other) {}

        /// Generated from method `JPH::SixDOFConstraintSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SixDOFConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SixDOFConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SixDOFConstraintSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_SixDOFConstraintSettings_size_t(inCount);
        }

        /// Generated from method `JPH::SixDOFConstraintSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SixDOFConstraintSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SixDOFConstraintSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SixDOFConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SixDOFConstraintSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SixDOFConstraintSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_SixDOFConstraintSettings_size_t(inCount);
        }

        /// Generated from method `JPH::SixDOFConstraintSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SixDOFConstraintSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SixDOFConstraintSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SixDOFConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SixDOFConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SixDOFConstraintSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_SixDOFConstraintSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SixDOFConstraintSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_SixDOFConstraintSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::SixDOFConstraintSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SixDOFConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SixDOFConstraintSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SixDOFConstraintSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_SixDOFConstraintSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SixDOFConstraintSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_SixDOFConstraintSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Create an instance of this constraint
        /// Generated from method `JPH::SixDOFConstraintSettings::Create`.
        public unsafe JPH.TwoBodyConstraint? Create(JPH.Body inBody1, JPH.Body inBody2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Create", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Create", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TwoBodyConstraint._Underlying *__JPH_SixDOFConstraintSettings_Create(_Underlying *_this, JPH.Body._Underlying *inBody1, JPH.Body._Underlying *inBody2);
            var __c_ret = __JPH_SixDOFConstraintSettings_Create(_UnderlyingPtr, inBody1._UnderlyingPtr, inBody2._UnderlyingPtr);
            return __c_ret is not null ? new JPH.TwoBodyConstraint(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::SixDOFConstraintSettings::IsFreeAxis`.
        public unsafe bool IsFreeAxis(JPH.SixDOFConstraintSettings.EAxis inAxis)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_IsFreeAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_IsFreeAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SixDOFConstraintSettings_IsFreeAxis(_Underlying *_this, JPH.SixDOFConstraintSettings.EAxis inAxis);
            return __JPH_SixDOFConstraintSettings_IsFreeAxis(_UnderlyingPtr, inAxis) != 0;
        }

        /// Generated from method `JPH::SixDOFConstraintSettings::IsFixedAxis`.
        public unsafe bool IsFixedAxis(JPH.SixDOFConstraintSettings.EAxis inAxis)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_IsFixedAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_IsFixedAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SixDOFConstraintSettings_IsFixedAxis(_Underlying *_this, JPH.SixDOFConstraintSettings.EAxis inAxis);
            return __JPH_SixDOFConstraintSettings_IsFixedAxis(_UnderlyingPtr, inAxis) != 0;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::SixDOFConstraintSettings::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraintSettings_SetEmbedded(_Underlying *_this);
            __JPH_SixDOFConstraintSettings_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::SixDOFConstraintSettings::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SixDOFConstraintSettings_GetRefCount(_Underlying *_this);
            return __JPH_SixDOFConstraintSettings_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::SixDOFConstraintSettings::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraintSettings_AddRef(_Underlying *_this);
            __JPH_SixDOFConstraintSettings_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SixDOFConstraintSettings::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraintSettings_Release(_Underlying *_this);
            __JPH_SixDOFConstraintSettings_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::SixDOFConstraintSettings::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_SixDOFConstraintSettings_sInternalGetRefCountOffset();
            return __JPH_SixDOFConstraintSettings_sInternalGetRefCountOffset();
        }

        /// Constraint is split up into translation/rotation around X, Y and Z axis.
        public enum EAxis : uint
        {
            TranslationX = 0,
            TranslationY = 1,
            TranslationZ = 2,
            RotationX = 3,
            RotationY = 4,
            RotationZ = 5,
            Num = 6,
            NumTranslation = 3,
        }
    }

    /// 6 Degree Of Freedom Constraint setup structure. Allows control over each of the 6 degrees of freedom.
    /// Generated from class `JPH::SixDOFConstraintSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TwoBodyConstraintSettings`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::ConstraintSettings>`
    ///     `JPH::ConstraintSettings`
    /// This is the non-const half of the class.
    public class SixDOFConstraintSettings : Const_SixDOFConstraintSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(SixDOFConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_SixDOFConstraintSettings_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_SixDOFConstraintSettings_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.RefTarget_JPHConstraintSettings(SixDOFConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraintSettings._Underlying *__JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            JPH.RefTarget_JPHConstraintSettings ret = new(__JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.ConstraintSettings(SixDOFConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ConstraintSettings._Underlying *__JPH_SixDOFConstraintSettings_UpcastTo_JPH_ConstraintSettings(_Underlying *_this);
            JPH.ConstraintSettings ret = new(__JPH_SixDOFConstraintSettings_UpcastTo_JPH_ConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.TwoBodyConstraintSettings(SixDOFConstraintSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TwoBodyConstraintSettings._Underlying *__JPH_SixDOFConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(_Underlying *_this);
            JPH.TwoBodyConstraintSettings ret = new(__JPH_SixDOFConstraintSettings_UpcastTo_JPH_TwoBodyConstraintSettings(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        /// Body 1 constraint reference frame (space determined by mSpace)
        public new unsafe JPH.Vec3 mPosition1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mPosition1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mPosition1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraintSettings_GetMutable_mPosition1(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_SixDOFConstraintSettings_GetMutable_mPosition1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Vec3 mAxisX1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mAxisX1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mAxisX1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraintSettings_GetMutable_mAxisX1(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_SixDOFConstraintSettings_GetMutable_mAxisX1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Vec3 mAxisY1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mAxisY1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mAxisY1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraintSettings_GetMutable_mAxisY1(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_SixDOFConstraintSettings_GetMutable_mAxisY1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// Body 2 constraint reference frame (space determined by mSpace)
        public new unsafe JPH.Vec3 mPosition2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mPosition2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mPosition2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraintSettings_GetMutable_mPosition2(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_SixDOFConstraintSettings_GetMutable_mPosition2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Vec3 mAxisX2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mAxisX2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mAxisX2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraintSettings_GetMutable_mAxisX2(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_SixDOFConstraintSettings_GetMutable_mAxisX2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Vec3 mAxisY2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mAxisY2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mAxisY2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraintSettings_GetMutable_mAxisY2(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_SixDOFConstraintSettings_GetMutable_mAxisY2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// Friction settings.
        /// For translation: Max friction force in N. 0 = no friction.
        /// For rotation: Max friction torque in Nm. 0 = no friction.
        new public unsafe ref JPH.ArrayFloat6 mMaxFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mMaxFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mMaxFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ArrayFloat6 *__JPH_SixDOFConstraintSettings_GetMutable_mMaxFriction(_Underlying *_this);
                return ref *(__JPH_SixDOFConstraintSettings_GetMutable_mMaxFriction(_UnderlyingPtr));
            }
        }

        /// Limits.
        /// For translation: Min and max linear limits in m (0 is frame of body 1 and 2 coincide).
        /// For rotation: Min and max angular limits in rad (0 is frame of body 1 and 2 coincide). See comments at Axis enum for limit ranges.
        ///
        /// Remove degree of freedom by setting min = FLT_MAX and max = -FLT_MAX. The constraint will be driven to 0 for this axis.
        ///
        /// Free movement over an axis is allowed when min = -FLT_MAX and max = FLT_MAX.
        ///
        /// Rotation limit around X-Axis: When limited, should be \f$\in [-\pi, \pi]\f$. Can be asymmetric around zero.
        ///
        /// Rotation limit around Y-Z Axis: Forms a pyramid or cone shaped limit:
        /// * For pyramid, should be \f$\in [-\pi, \pi]\f$ and does not need to be symmetrical around zero.
        /// * For cone should be \f$\in [0, \pi]\f$ and needs to be symmetrical around zero (min limit is assumed to be -max limit).
        new public unsafe ref JPH.ArrayFloat6 mLimitMin
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mLimitMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mLimitMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ArrayFloat6 *__JPH_SixDOFConstraintSettings_GetMutable_mLimitMin(_Underlying *_this);
                return ref *(__JPH_SixDOFConstraintSettings_GetMutable_mLimitMin(_UnderlyingPtr));
            }
        }

        new public unsafe ref JPH.ArrayFloat6 mLimitMax
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mLimitMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mLimitMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ArrayFloat6 *__JPH_SixDOFConstraintSettings_GetMutable_mLimitMax(_Underlying *_this);
                return ref *(__JPH_SixDOFConstraintSettings_GetMutable_mLimitMax(_UnderlyingPtr));
            }
        }

        /// If this constraint is enabled initially. Use Constraint::SetEnabled to toggle after creation.
        public new unsafe ref bool mEnabled
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_SixDOFConstraintSettings_GetMutable_mEnabled(_Underlying *_this);
                return ref *__JPH_SixDOFConstraintSettings_GetMutable_mEnabled(_UnderlyingPtr);
            }
        }

        /// Priority of the constraint when solving. Higher numbers are more likely to be solved correctly.
        /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
        public new unsafe ref uint mConstraintPriority
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_SixDOFConstraintSettings_GetMutable_mConstraintPriority(_Underlying *_this);
                return ref *__JPH_SixDOFConstraintSettings_GetMutable_mConstraintPriority(_UnderlyingPtr);
            }
        }

        /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public new unsafe ref uint mNumVelocityStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_SixDOFConstraintSettings_GetMutable_mNumVelocityStepsOverride(_Underlying *_this);
                return ref *__JPH_SixDOFConstraintSettings_GetMutable_mNumVelocityStepsOverride(_UnderlyingPtr);
            }
        }

        /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public new unsafe ref uint mNumPositionStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_SixDOFConstraintSettings_GetMutable_mNumPositionStepsOverride(_Underlying *_this);
                return ref *__JPH_SixDOFConstraintSettings_GetMutable_mNumPositionStepsOverride(_UnderlyingPtr);
            }
        }

        /// Size of constraint when drawing it through the debug renderer
        public new unsafe ref float mDrawConstraintSize
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SixDOFConstraintSettings_GetMutable_mDrawConstraintSize(_Underlying *_this);
                return ref *__JPH_SixDOFConstraintSettings_GetMutable_mDrawConstraintSize(_UnderlyingPtr);
            }
        }

        /// User data value (can be used by application)
        public new unsafe ref UIntPtr mUserData
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static UIntPtr *__JPH_SixDOFConstraintSettings_GetMutable_mUserData(_Underlying *_this);
                return ref *__JPH_SixDOFConstraintSettings_GetMutable_mUserData(_UnderlyingPtr);
            }
        }

        internal unsafe SixDOFConstraintSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe SixDOFConstraintSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SixDOFConstraintSettings._Underlying *__JPH_SixDOFConstraintSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_SixDOFConstraintSettings_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_AddRef(__JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::SixDOFConstraintSettings::SixDOFConstraintSettings`.
        public unsafe SixDOFConstraintSettings(JPH._ByValue_SixDOFConstraintSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SixDOFConstraintSettings._Underlying *__JPH_SixDOFConstraintSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.SixDOFConstraintSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_SixDOFConstraintSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_ConstraintSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_ConstraintSettings_AddRef(void *_this);
            __JPH_RefTarget_JPH_ConstraintSettings_AddRef(__JPH_SixDOFConstraintSettings_UpcastTo_JPH_RefTarget_JPH_ConstraintSettings(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::SixDOFConstraintSettings::SixDOFConstraintSettings`.
        public SixDOFConstraintSettings(Const_SixDOFConstraintSettings _other) : this(new _ByValue_SixDOFConstraintSettings(_other)) {}

        /// Generated from constructor `JPH::SixDOFConstraintSettings::SixDOFConstraintSettings`.
        public SixDOFConstraintSettings(SixDOFConstraintSettings _other) : this((Const_SixDOFConstraintSettings)_other) {}

        /// Generated from method `JPH::SixDOFConstraintSettings::operator=`.
        public unsafe JPH.SixDOFConstraintSettings Assign(JPH._ByValue_SixDOFConstraintSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SixDOFConstraintSettings._Underlying *__JPH_SixDOFConstraintSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.SixDOFConstraintSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_SixDOFConstraintSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Make axis free (unconstrained)
        /// Generated from method `JPH::SixDOFConstraintSettings::MakeFreeAxis`.
        public unsafe void MakeFreeAxis(JPH.SixDOFConstraintSettings.EAxis inAxis)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_MakeFreeAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_MakeFreeAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraintSettings_MakeFreeAxis(_Underlying *_this, JPH.SixDOFConstraintSettings.EAxis inAxis);
            __JPH_SixDOFConstraintSettings_MakeFreeAxis(_UnderlyingPtr, inAxis);
        }

        /// Make axis fixed (fixed at value 0)
        /// Generated from method `JPH::SixDOFConstraintSettings::MakeFixedAxis`.
        public unsafe void MakeFixedAxis(JPH.SixDOFConstraintSettings.EAxis inAxis)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_MakeFixedAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_MakeFixedAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraintSettings_MakeFixedAxis(_Underlying *_this, JPH.SixDOFConstraintSettings.EAxis inAxis);
            __JPH_SixDOFConstraintSettings_MakeFixedAxis(_UnderlyingPtr, inAxis);
        }

        /// Set a valid range for the constraint (if inMax < inMin, the axis will become fixed)
        /// Generated from method `JPH::SixDOFConstraintSettings::SetLimitedAxis`.
        public unsafe void SetLimitedAxis(JPH.SixDOFConstraintSettings.EAxis inAxis, float inMin, float inMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_SetLimitedAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraintSettings_SetLimitedAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraintSettings_SetLimitedAxis(_Underlying *_this, JPH.SixDOFConstraintSettings.EAxis inAxis, float inMin, float inMax);
            __JPH_SixDOFConstraintSettings_SetLimitedAxis(_UnderlyingPtr, inAxis, inMin, inMax);
        }
    }

    /// This is used as a function parameter when the underlying function receives `SixDOFConstraintSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `SixDOFConstraintSettings`/`Const_SixDOFConstraintSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_SixDOFConstraintSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_SixDOFConstraintSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_SixDOFConstraintSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_SixDOFConstraintSettings(Const_SixDOFConstraintSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_SixDOFConstraintSettings(Const_SixDOFConstraintSettings arg) {return new(arg);}
        public _ByValue_SixDOFConstraintSettings(JPH._Moved<SixDOFConstraintSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_SixDOFConstraintSettings(JPH._Moved<SixDOFConstraintSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `SixDOFConstraintSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SixDOFConstraintSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SixDOFConstraintSettings`/`Const_SixDOFConstraintSettings` directly.
    public class _InOptMut_SixDOFConstraintSettings
    {
        public SixDOFConstraintSettings? Opt;

        public _InOptMut_SixDOFConstraintSettings() {}
        public _InOptMut_SixDOFConstraintSettings(SixDOFConstraintSettings value) {Opt = value;}
        public static implicit operator _InOptMut_SixDOFConstraintSettings(SixDOFConstraintSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `SixDOFConstraintSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SixDOFConstraintSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SixDOFConstraintSettings`/`Const_SixDOFConstraintSettings` to pass it to the function.
    public class _InOptConst_SixDOFConstraintSettings
    {
        public Const_SixDOFConstraintSettings? Opt;

        public _InOptConst_SixDOFConstraintSettings() {}
        public _InOptConst_SixDOFConstraintSettings(Const_SixDOFConstraintSettings value) {Opt = value;}
        public static implicit operator _InOptConst_SixDOFConstraintSettings(Const_SixDOFConstraintSettings value) {return new(value);}
    }

    /// 6 Degree Of Freedom Constraint. Allows control over each of the 6 degrees of freedom.
    /// Generated from class `JPH::SixDOFConstraint`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TwoBodyConstraint`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Constraint>`
    ///     `JPH::NonCopyable`
    ///     `JPH::Constraint`
    /// This is the const half of the class.
    public class Const_SixDOFConstraint : JPH.Object<Const_SixDOFConstraint>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Constraint_Release(void *_this);
            __JPH_RefTarget_JPH_Constraint_Release(__JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SixDOFConstraint() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHConstraint(Const_SixDOFConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHConstraint._Underlying *__JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            JPH.Const_RefTarget_JPHConstraint ret = new(__JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_SixDOFConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_SixDOFConstraint_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_SixDOFConstraint_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_Constraint(Const_SixDOFConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Constraint._Underlying *__JPH_SixDOFConstraint_UpcastTo_JPH_Constraint(_Underlying *_this);
            JPH.Const_Constraint ret = new(__JPH_SixDOFConstraint_UpcastTo_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_TwoBodyConstraint(Const_SixDOFConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_TwoBodyConstraint._Underlying *__JPH_SixDOFConstraint_UpcastTo_JPH_TwoBodyConstraint(_Underlying *_this);
            JPH.Const_TwoBodyConstraint ret = new(__JPH_SixDOFConstraint_UpcastTo_JPH_TwoBodyConstraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe Const_SixDOFConstraint(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Construct six DOF constraint
        /// Generated from constructor `JPH::SixDOFConstraint::SixDOFConstraint`.
        public unsafe Const_SixDOFConstraint(JPH.Body inBody1, JPH.Body inBody2, JPH.Const_SixDOFConstraintSettings inSettings) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SixDOFConstraint._Underlying *__JPH_SixDOFConstraint_Construct(JPH.Body._Underlying *inBody1, JPH.Body._Underlying *inBody2, JPH.Const_SixDOFConstraintSettings._Underlying *inSettings);
            _UnderlyingPtr = __JPH_SixDOFConstraint_Construct(inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inSettings._UnderlyingPtr);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Constraint_AddRef(void *_this);
            __JPH_RefTarget_JPH_Constraint_AddRef(__JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_UnderlyingPtr));
        }

        /// Generated from method `JPH::SixDOFConstraint::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SixDOFConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SixDOFConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SixDOFConstraint_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_SixDOFConstraint_size_t(inCount);
        }

        /// Generated from method `JPH::SixDOFConstraint::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SixDOFConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SixDOFConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SixDOFConstraint_void_ptr(void *inPointer);
            __Jolt_delete_JPH_SixDOFConstraint_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SixDOFConstraint::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SixDOFConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SixDOFConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SixDOFConstraint_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_SixDOFConstraint_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SixDOFConstraint::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SixDOFConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SixDOFConstraint_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SixDOFConstraint_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_SixDOFConstraint_size_t(inCount);
        }

        /// Generated from method `JPH::SixDOFConstraint::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SixDOFConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SixDOFConstraint_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SixDOFConstraint_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_SixDOFConstraint_void_ptr(inPointer);
        }

        /// Generated from method `JPH::SixDOFConstraint::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SixDOFConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SixDOFConstraint_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SixDOFConstraint_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_SixDOFConstraint_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::SixDOFConstraint::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SixDOFConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SixDOFConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_SixDOFConstraint_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_SixDOFConstraint_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SixDOFConstraint::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SixDOFConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SixDOFConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_SixDOFConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_SixDOFConstraint_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::SixDOFConstraint::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SixDOFConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SixDOFConstraint_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_SixDOFConstraint_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_SixDOFConstraint_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::SixDOFConstraint::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SixDOFConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SixDOFConstraint_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_SixDOFConstraint_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_SixDOFConstraint_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::SixDOFConstraint::DrawConstraint`.
        public unsafe void DrawConstraint(JPH.DebugRenderer? inRenderer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_DrawConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_DrawConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_DrawConstraint(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer);
            __JPH_SixDOFConstraint_DrawConstraint(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null);
        }

        /// Generated from method `JPH::SixDOFConstraint::DrawConstraintLimits`.
        public unsafe void DrawConstraintLimits(JPH.DebugRenderer? inRenderer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_DrawConstraintLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_DrawConstraintLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_DrawConstraintLimits(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer);
            __JPH_SixDOFConstraint_DrawConstraintLimits(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null);
        }

        // See: TwoBodyConstraint
        /// Generated from method `JPH::SixDOFConstraint::GetConstraintToBody1Matrix`.
        public unsafe JPH.Mat44 GetConstraintToBody1Matrix()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetConstraintToBody1Matrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetConstraintToBody1Matrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_SixDOFConstraint_GetConstraintToBody1Matrix(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetConstraintToBody1Matrix(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::SixDOFConstraint::GetConstraintToBody2Matrix`.
        public unsafe JPH.Mat44 GetConstraintToBody2Matrix()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetConstraintToBody2Matrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetConstraintToBody2Matrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_SixDOFConstraint_GetConstraintToBody2Matrix(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetConstraintToBody2Matrix(_UnderlyingPtr), is_owning: true);
        }

        /// Get constraint Limits
        /// Generated from method `JPH::SixDOFConstraint::GetLimitsMin`.
        public unsafe float GetLimitsMin(JPH.SixDOFConstraintSettings.EAxis inAxis)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetLimitsMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetLimitsMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SixDOFConstraint_GetLimitsMin(_Underlying *_this, JPH.SixDOFConstraintSettings.EAxis inAxis);
            return __JPH_SixDOFConstraint_GetLimitsMin(_UnderlyingPtr, inAxis);
        }

        /// Generated from method `JPH::SixDOFConstraint::GetLimitsMax`.
        public unsafe float GetLimitsMax(JPH.SixDOFConstraintSettings.EAxis inAxis)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetLimitsMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetLimitsMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SixDOFConstraint_GetLimitsMax(_Underlying *_this, JPH.SixDOFConstraintSettings.EAxis inAxis);
            return __JPH_SixDOFConstraint_GetLimitsMax(_UnderlyingPtr, inAxis);
        }

        /// Generated from method `JPH::SixDOFConstraint::GetTranslationLimitsMin`.
        public unsafe JPH.Vec3 GetTranslationLimitsMin()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTranslationLimitsMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTranslationLimitsMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraint_GetTranslationLimitsMin(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetTranslationLimitsMin(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::SixDOFConstraint::GetTranslationLimitsMax`.
        public unsafe JPH.Vec3 GetTranslationLimitsMax()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTranslationLimitsMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTranslationLimitsMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraint_GetTranslationLimitsMax(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetTranslationLimitsMax(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::SixDOFConstraint::GetRotationLimitsMin`.
        public unsafe JPH.Vec3 GetRotationLimitsMin()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetRotationLimitsMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetRotationLimitsMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraint_GetRotationLimitsMin(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetRotationLimitsMin(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::SixDOFConstraint::GetRotationLimitsMax`.
        public unsafe JPH.Vec3 GetRotationLimitsMax()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetRotationLimitsMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetRotationLimitsMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraint_GetRotationLimitsMax(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetRotationLimitsMax(_UnderlyingPtr), is_owning: true);
        }

        /// Check which axis are fixed/free
        /// Generated from method `JPH::SixDOFConstraint::IsFixedAxis`.
        public unsafe bool IsFixedAxis(JPH.SixDOFConstraintSettings.EAxis inAxis)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_IsFixedAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_IsFixedAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SixDOFConstraint_IsFixedAxis(_Underlying *_this, JPH.SixDOFConstraintSettings.EAxis inAxis);
            return __JPH_SixDOFConstraint_IsFixedAxis(_UnderlyingPtr, inAxis) != 0;
        }

        /// Generated from method `JPH::SixDOFConstraint::IsFreeAxis`.
        public unsafe bool IsFreeAxis(JPH.SixDOFConstraintSettings.EAxis inAxis)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_IsFreeAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_IsFreeAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SixDOFConstraint_IsFreeAxis(_Underlying *_this, JPH.SixDOFConstraintSettings.EAxis inAxis);
            return __JPH_SixDOFConstraint_IsFreeAxis(_UnderlyingPtr, inAxis) != 0;
        }

        /// Generated from method `JPH::SixDOFConstraint::GetMaxFriction`.
        public unsafe float GetMaxFriction(JPH.SixDOFConstraintSettings.EAxis inAxis)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetMaxFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetMaxFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SixDOFConstraint_GetMaxFriction(_Underlying *_this, JPH.SixDOFConstraintSettings.EAxis inAxis);
            return __JPH_SixDOFConstraint_GetMaxFriction(_UnderlyingPtr, inAxis);
        }

        /// Get rotation of constraint in constraint space
        /// Generated from method `JPH::SixDOFConstraint::GetRotationInConstraintSpace`.
        public unsafe JPH.Quat GetRotationInConstraintSpace()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetRotationInConstraintSpace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetRotationInConstraintSpace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_SixDOFConstraint_GetRotationInConstraintSpace(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetRotationInConstraintSpace(_UnderlyingPtr), is_owning: true);
        }

        /// Set the target velocity in body 1 constraint space
        /// Generated from method `JPH::SixDOFConstraint::GetTargetVelocityCS`.
        public unsafe JPH.Vec3 GetTargetVelocityCS()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTargetVelocityCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTargetVelocityCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraint_GetTargetVelocityCS(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetTargetVelocityCS(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::SixDOFConstraint::GetTargetAngularVelocityCS`.
        public unsafe JPH.Vec3 GetTargetAngularVelocityCS()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTargetAngularVelocityCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTargetAngularVelocityCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraint_GetTargetAngularVelocityCS(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetTargetAngularVelocityCS(_UnderlyingPtr), is_owning: true);
        }

        /// Set the target position in body 1 constraint space
        /// Generated from method `JPH::SixDOFConstraint::GetTargetPositionCS`.
        public unsafe JPH.Vec3 GetTargetPositionCS()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTargetPositionCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTargetPositionCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraint_GetTargetPositionCS(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetTargetPositionCS(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::SixDOFConstraint::GetTargetOrientationCS`.
        public unsafe JPH.Quat GetTargetOrientationCS()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTargetOrientationCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTargetOrientationCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_SixDOFConstraint_GetTargetOrientationCS(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetTargetOrientationCS(_UnderlyingPtr), is_owning: true);
        }

        ///@name Get Lagrange multiplier from last physics update (the linear/angular impulse applied to satisfy the constraint)
        /// Generated from method `JPH::SixDOFConstraint::GetTotalLambdaPosition`.
        public unsafe JPH.Vec3 GetTotalLambdaPosition()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTotalLambdaPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTotalLambdaPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraint_GetTotalLambdaPosition(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetTotalLambdaPosition(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::SixDOFConstraint::GetTotalLambdaRotation`.
        public unsafe JPH.Vec3 GetTotalLambdaRotation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTotalLambdaRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTotalLambdaRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraint_GetTotalLambdaRotation(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetTotalLambdaRotation(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::SixDOFConstraint::GetTotalLambdaMotorTranslation`.
        public unsafe JPH.Vec3 GetTotalLambdaMotorTranslation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTotalLambdaMotorTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTotalLambdaMotorTranslation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraint_GetTotalLambdaMotorTranslation(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetTotalLambdaMotorTranslation(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::SixDOFConstraint::GetTotalLambdaMotorRotation`.
        public unsafe JPH.Vec3 GetTotalLambdaMotorRotation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTotalLambdaMotorRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetTotalLambdaMotorRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_SixDOFConstraint_GetTotalLambdaMotorRotation(_Underlying *_this);
            return new(__JPH_SixDOFConstraint_GetTotalLambdaMotorRotation(_UnderlyingPtr), is_owning: true);
        }

        /// Solver interface
        /// Generated from method `JPH::SixDOFConstraint::IsActive`.
        public unsafe bool IsActive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SixDOFConstraint_IsActive(_Underlying *_this);
            return __JPH_SixDOFConstraint_IsActive(_UnderlyingPtr) != 0;
        }

        /// Generated from method `JPH::SixDOFConstraint::DrawConstraintReferenceFrame`.
        public unsafe void DrawConstraintReferenceFrame(JPH.DebugRenderer? inRenderer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_DrawConstraintReferenceFrame", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_DrawConstraintReferenceFrame", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_DrawConstraintReferenceFrame(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer);
            __JPH_SixDOFConstraint_DrawConstraintReferenceFrame(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null);
        }

        /// Access to the connected bodies
        /// Generated from method `JPH::SixDOFConstraint::GetBody1`.
        public unsafe JPH.Body? GetBody1()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetBody1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Body._Underlying *__JPH_SixDOFConstraint_GetBody1(_Underlying *_this);
            var __c_ret = __JPH_SixDOFConstraint_GetBody1(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Body(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::SixDOFConstraint::GetBody2`.
        public unsafe JPH.Body? GetBody2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetBody2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Body._Underlying *__JPH_SixDOFConstraint_GetBody2(_Underlying *_this);
            var __c_ret = __JPH_SixDOFConstraint_GetBody2(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Body(__c_ret, is_owning: false) : null;
        }

        /// Priority of the constraint when solving. Higher numbers have are more likely to be solved correctly.
        /// Note that if you want a deterministic simulation and you cannot guarantee the order in which constraints are added/removed, you can make the priority for all constraints unique to get a deterministic ordering.
        /// Generated from method `JPH::SixDOFConstraint::GetConstraintPriority`.
        public unsafe uint GetConstraintPriority()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SixDOFConstraint_GetConstraintPriority(_Underlying *_this);
            return __JPH_SixDOFConstraint_GetConstraintPriority(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SixDOFConstraint::GetNumVelocityStepsOverride`.
        public unsafe uint GetNumVelocityStepsOverride()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SixDOFConstraint_GetNumVelocityStepsOverride(_Underlying *_this);
            return __JPH_SixDOFConstraint_GetNumVelocityStepsOverride(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SixDOFConstraint::GetNumPositionStepsOverride`.
        public unsafe uint GetNumPositionStepsOverride()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SixDOFConstraint_GetNumPositionStepsOverride(_Underlying *_this);
            return __JPH_SixDOFConstraint_GetNumPositionStepsOverride(_UnderlyingPtr);
        }

        /// Test if a constraint is enabled.
        /// Generated from method `JPH::SixDOFConstraint::GetEnabled`.
        public unsafe bool GetEnabled()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SixDOFConstraint_GetEnabled(_Underlying *_this);
            return __JPH_SixDOFConstraint_GetEnabled(_UnderlyingPtr) != 0;
        }

        /// Access to the user data, can be used for anything by the application
        /// Generated from method `JPH::SixDOFConstraint::GetUserData`.
        public unsafe UIntPtr GetUserData()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_SixDOFConstraint_GetUserData(_Underlying *_this);
            return __JPH_SixDOFConstraint_GetUserData(_UnderlyingPtr);
        }

        /// Size of constraint when drawing it through the debug renderer
        /// Generated from method `JPH::SixDOFConstraint::GetDrawConstraintSize`.
        public unsafe float GetDrawConstraintSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_SixDOFConstraint_GetDrawConstraintSize(_Underlying *_this);
            return __JPH_SixDOFConstraint_GetDrawConstraintSize(_UnderlyingPtr);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::SixDOFConstraint::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetEmbedded(_Underlying *_this);
            __JPH_SixDOFConstraint_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::SixDOFConstraint::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_SixDOFConstraint_GetRefCount(_Underlying *_this);
            return __JPH_SixDOFConstraint_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::SixDOFConstraint::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_AddRef(_Underlying *_this);
            __JPH_SixDOFConstraint_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SixDOFConstraint::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_Release(_Underlying *_this);
            __JPH_SixDOFConstraint_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::SixDOFConstraint::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_SixDOFConstraint_sInternalGetRefCountOffset();
            return __JPH_SixDOFConstraint_sInternalGetRefCountOffset();
        }
    }

    /// 6 Degree Of Freedom Constraint. Allows control over each of the 6 degrees of freedom.
    /// Generated from class `JPH::SixDOFConstraint`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::TwoBodyConstraint`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::Constraint>`
    ///     `JPH::NonCopyable`
    ///     `JPH::Constraint`
    /// This is the non-const half of the class.
    public class SixDOFConstraint : Const_SixDOFConstraint
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHConstraint(SixDOFConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHConstraint._Underlying *__JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            JPH.RefTarget_JPHConstraint ret = new(__JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.NonCopyable(SixDOFConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_SixDOFConstraint_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_SixDOFConstraint_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Constraint(SixDOFConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Constraint._Underlying *__JPH_SixDOFConstraint_UpcastTo_JPH_Constraint(_Underlying *_this);
            JPH.Constraint ret = new(__JPH_SixDOFConstraint_UpcastTo_JPH_Constraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.TwoBodyConstraint(SixDOFConstraint self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_TwoBodyConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TwoBodyConstraint._Underlying *__JPH_SixDOFConstraint_UpcastTo_JPH_TwoBodyConstraint(_Underlying *_this);
            JPH.TwoBodyConstraint ret = new(__JPH_SixDOFConstraint_UpcastTo_JPH_TwoBodyConstraint(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe SixDOFConstraint(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Construct six DOF constraint
        /// Generated from constructor `JPH::SixDOFConstraint::SixDOFConstraint`.
        public unsafe SixDOFConstraint(JPH.Body inBody1, JPH.Body inBody2, JPH.Const_SixDOFConstraintSettings inSettings) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SixDOFConstraint._Underlying *__JPH_SixDOFConstraint_Construct(JPH.Body._Underlying *inBody1, JPH.Body._Underlying *inBody2, JPH.Const_SixDOFConstraintSettings._Underlying *inSettings);
            _UnderlyingPtr = __JPH_SixDOFConstraint_Construct(inBody1._UnderlyingPtr, inBody2._UnderlyingPtr, inSettings._UnderlyingPtr);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_Constraint_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_Constraint_AddRef(void *_this);
            __JPH_RefTarget_JPH_Constraint_AddRef(__JPH_SixDOFConstraint_UpcastTo_JPH_RefTarget_JPH_Constraint(_UnderlyingPtr));
        }

        /// Generated from method `JPH::SixDOFConstraint::NotifyShapeChanged`.
        public unsafe void NotifyShapeChanged(in JPH.BodyID inBodyID, JPH.Const_Vec3 inDeltaCOM)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_NotifyShapeChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_NotifyShapeChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_NotifyShapeChanged(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inDeltaCOM);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_SixDOFConstraint_NotifyShapeChanged(_UnderlyingPtr, __ptr_inBodyID, inDeltaCOM._UnderlyingPtr);
            }
        }

        /// Generated from method `JPH::SixDOFConstraint::SetupVelocityConstraint`.
        public unsafe void SetupVelocityConstraint(float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetupVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetupVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetupVelocityConstraint(_Underlying *_this, float inDeltaTime);
            __JPH_SixDOFConstraint_SetupVelocityConstraint(_UnderlyingPtr, inDeltaTime);
        }

        /// Generated from method `JPH::SixDOFConstraint::ResetWarmStart`.
        public unsafe void ResetWarmStart()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_ResetWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_ResetWarmStart(_Underlying *_this);
            __JPH_SixDOFConstraint_ResetWarmStart(_UnderlyingPtr);
        }

        /// Generated from method `JPH::SixDOFConstraint::WarmStartVelocityConstraint`.
        public unsafe void WarmStartVelocityConstraint(float inWarmStartImpulseRatio)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_WarmStartVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_WarmStartVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_WarmStartVelocityConstraint(_Underlying *_this, float inWarmStartImpulseRatio);
            __JPH_SixDOFConstraint_WarmStartVelocityConstraint(_UnderlyingPtr, inWarmStartImpulseRatio);
        }

        /// Generated from method `JPH::SixDOFConstraint::SolveVelocityConstraint`.
        public unsafe bool SolveVelocityConstraint(float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SolveVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SolveVelocityConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SixDOFConstraint_SolveVelocityConstraint(_Underlying *_this, float inDeltaTime);
            return __JPH_SixDOFConstraint_SolveVelocityConstraint(_UnderlyingPtr, inDeltaTime) != 0;
        }

        /// Generated from method `JPH::SixDOFConstraint::SolvePositionConstraint`.
        public unsafe bool SolvePositionConstraint(float inDeltaTime, float inBaumgarte)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SolvePositionConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SolvePositionConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_SixDOFConstraint_SolvePositionConstraint(_Underlying *_this, float inDeltaTime, float inBaumgarte);
            return __JPH_SixDOFConstraint_SolvePositionConstraint(_UnderlyingPtr, inDeltaTime, inBaumgarte) != 0;
        }

        /// Update the translation limits for this constraint
        /// Generated from method `JPH::SixDOFConstraint::SetTranslationLimits`.
        public unsafe void SetTranslationLimits(JPH.Const_Vec3 inLimitMin, JPH.Const_Vec3 inLimitMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetTranslationLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetTranslationLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetTranslationLimits(_Underlying *_this, JPH.Vec3._Underlying *inLimitMin, JPH.Vec3._Underlying *inLimitMax);
            __JPH_SixDOFConstraint_SetTranslationLimits(_UnderlyingPtr, inLimitMin._UnderlyingPtr, inLimitMax._UnderlyingPtr);
        }

        /// Update the rotational limits for this constraint
        /// Generated from method `JPH::SixDOFConstraint::SetRotationLimits`.
        public unsafe void SetRotationLimits(JPH.Const_Vec3 inLimitMin, JPH.Const_Vec3 inLimitMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetRotationLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetRotationLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetRotationLimits(_Underlying *_this, JPH.Vec3._Underlying *inLimitMin, JPH.Vec3._Underlying *inLimitMax);
            __JPH_SixDOFConstraint_SetRotationLimits(_UnderlyingPtr, inLimitMin._UnderlyingPtr, inLimitMax._UnderlyingPtr);
        }

        /// Set the max friction for each axis
        /// Generated from method `JPH::SixDOFConstraint::SetMaxFriction`.
        public unsafe void SetMaxFriction(JPH.SixDOFConstraintSettings.EAxis inAxis, float inFriction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetMaxFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetMaxFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetMaxFriction(_Underlying *_this, JPH.SixDOFConstraintSettings.EAxis inAxis, float inFriction);
            __JPH_SixDOFConstraint_SetMaxFriction(_UnderlyingPtr, inAxis, inFriction);
        }

        /// Generated from method `JPH::SixDOFConstraint::SetTargetVelocityCS`.
        public unsafe void SetTargetVelocityCS(JPH.Const_Vec3 inVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetTargetVelocityCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetTargetVelocityCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetTargetVelocityCS(_Underlying *_this, JPH.Vec3._Underlying *inVelocity);
            __JPH_SixDOFConstraint_SetTargetVelocityCS(_UnderlyingPtr, inVelocity._UnderlyingPtr);
        }

        /// Set the target angular velocity in body 2 constraint space (!)
        /// Generated from method `JPH::SixDOFConstraint::SetTargetAngularVelocityCS`.
        public unsafe void SetTargetAngularVelocityCS(JPH.Const_Vec3 inAngularVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetTargetAngularVelocityCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetTargetAngularVelocityCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetTargetAngularVelocityCS(_Underlying *_this, JPH.Vec3._Underlying *inAngularVelocity);
            __JPH_SixDOFConstraint_SetTargetAngularVelocityCS(_UnderlyingPtr, inAngularVelocity._UnderlyingPtr);
        }

        /// Generated from method `JPH::SixDOFConstraint::SetTargetPositionCS`.
        public unsafe void SetTargetPositionCS(JPH.Const_Vec3 inPosition)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetTargetPositionCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetTargetPositionCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetTargetPositionCS(_Underlying *_this, JPH.Vec3._Underlying *inPosition);
            __JPH_SixDOFConstraint_SetTargetPositionCS(_UnderlyingPtr, inPosition._UnderlyingPtr);
        }

        /// Set the target orientation in body 1 constraint space
        /// Generated from method `JPH::SixDOFConstraint::SetTargetOrientationCS`.
        public unsafe void SetTargetOrientationCS(JPH.Const_Quat inOrientation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetTargetOrientationCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetTargetOrientationCS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetTargetOrientationCS(_Underlying *_this, JPH.Quat._Underlying *inOrientation);
            __JPH_SixDOFConstraint_SetTargetOrientationCS(_UnderlyingPtr, inOrientation._UnderlyingPtr);
        }

        /// Set the target orientation in body space (R2 = R1 * inOrientation, where R1 and R2 are the world space rotations for body 1 and 2).
        /// Solve: R2 * ConstraintToBody2 = R1 * ConstraintToBody1 * q (see SwingTwistConstraint::GetSwingTwist) and R2 = R1 * inOrientation for q.
        /// Generated from method `JPH::SixDOFConstraint::SetTargetOrientationBS`.
        public unsafe void SetTargetOrientationBS(JPH.Const_Quat inOrientation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetTargetOrientationBS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetTargetOrientationBS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetTargetOrientationBS(_Underlying *_this, JPH.Quat._Underlying *inOrientation);
            __JPH_SixDOFConstraint_SetTargetOrientationBS(_UnderlyingPtr, inOrientation._UnderlyingPtr);
        }

        /// Generated from method `JPH::SixDOFConstraint::SetConstraintPriority`.
        public unsafe void SetConstraintPriority(uint inPriority)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetConstraintPriority", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetConstraintPriority(_Underlying *_this, uint inPriority);
            __JPH_SixDOFConstraint_SetConstraintPriority(_UnderlyingPtr, inPriority);
        }

        /// Used only when the constraint is active. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
        /// Generated from method `JPH::SixDOFConstraint::SetNumVelocityStepsOverride`.
        public unsafe void SetNumVelocityStepsOverride(uint inN)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetNumVelocityStepsOverride(_Underlying *_this, uint inN);
            __JPH_SixDOFConstraint_SetNumVelocityStepsOverride(_UnderlyingPtr, inN);
        }

        /// Used only when the constraint is active. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
        /// Generated from method `JPH::SixDOFConstraint::SetNumPositionStepsOverride`.
        public unsafe void SetNumPositionStepsOverride(uint inN)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetNumPositionStepsOverride(_Underlying *_this, uint inN);
            __JPH_SixDOFConstraint_SetNumPositionStepsOverride(_UnderlyingPtr, inN);
        }

        /// Enable / disable this constraint. This can e.g. be used to implement a breakable constraint by detecting that the constraint impulse
        /// (see e.g. PointConstraint::GetTotalLambdaPosition) went over a certain limit and then disabling the constraint.
        /// Note that although a disabled constraint will not affect the simulation in any way anymore, it does incur some processing overhead.
        /// Alternatively you can remove a constraint from the constraint manager (which may be more costly if you want to disable the constraint for a short while).
        /// Generated from method `JPH::SixDOFConstraint::SetEnabled`.
        public unsafe void SetEnabled(bool inEnabled)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetEnabled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetEnabled(_Underlying *_this, byte inEnabled);
            __JPH_SixDOFConstraint_SetEnabled(_UnderlyingPtr, inEnabled ? (byte)1 : (byte)0);
        }

        /// Generated from method `JPH::SixDOFConstraint::SetUserData`.
        public unsafe void SetUserData(UIntPtr inUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetUserData(_Underlying *_this, UIntPtr inUserData);
            __JPH_SixDOFConstraint_SetUserData(_UnderlyingPtr, inUserData);
        }

        /// Generated from method `JPH::SixDOFConstraint::SetDrawConstraintSize`.
        public unsafe void SetDrawConstraintSize(float inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SixDOFConstraint_SetDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SixDOFConstraint_SetDrawConstraintSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SixDOFConstraint_SetDrawConstraintSize(_Underlying *_this, float inSize);
            __JPH_SixDOFConstraint_SetDrawConstraintSize(_UnderlyingPtr, inSize);
        }
    }

    /// This is used for optional parameters of class `SixDOFConstraint` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SixDOFConstraint`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SixDOFConstraint`/`Const_SixDOFConstraint` directly.
    public class _InOptMut_SixDOFConstraint
    {
        public SixDOFConstraint? Opt;

        public _InOptMut_SixDOFConstraint() {}
        public _InOptMut_SixDOFConstraint(SixDOFConstraint value) {Opt = value;}
        public static implicit operator _InOptMut_SixDOFConstraint(SixDOFConstraint value) {return new(value);}
    }

    /// This is used for optional parameters of class `SixDOFConstraint` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SixDOFConstraint`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SixDOFConstraint`/`Const_SixDOFConstraint` to pass it to the function.
    public class _InOptConst_SixDOFConstraint
    {
        public Const_SixDOFConstraint? Opt;

        public _InOptConst_SixDOFConstraint() {}
        public _InOptConst_SixDOFConstraint(Const_SixDOFConstraint value) {Opt = value;}
        public static implicit operator _InOptConst_SixDOFConstraint(Const_SixDOFConstraint value) {return new(value);}
    }
}
