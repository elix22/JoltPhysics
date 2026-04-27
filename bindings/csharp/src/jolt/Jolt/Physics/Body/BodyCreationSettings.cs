// machine generated, do not edit
public static partial class JPH
{
    /// Settings for constructing a rigid body
    /// Generated from class `JPH::BodyCreationSettings`.
    /// This is the const half of the class.
    public class Const_BodyCreationSettings : JPH.Object<Const_BodyCreationSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyCreationSettings_Destroy(_Underlying *_this);
            __JPH_BodyCreationSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BodyCreationSettings() {Dispose(false);}

        ///< Position of the body (not of the center of mass)
        public unsafe JPH.Const_Vec3 mPosition
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_BodyCreationSettings_Get_mPosition(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_BodyCreationSettings_Get_mPosition(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Quat._Underlying *__JPH_BodyCreationSettings_Get_mRotation(_Underlying *_this);
                JPH.Const_Quat __ret;
                __ret = new(__JPH_BodyCreationSettings_Get_mRotation(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_BodyCreationSettings_Get_mLinearVelocity(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_BodyCreationSettings_Get_mLinearVelocity(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_BodyCreationSettings_Get_mAngularVelocity(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_BodyCreationSettings_Get_mAngularVelocity(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong *__JPH_BodyCreationSettings_Get_mUserData(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mUserData(_UnderlyingPtr);
            }
        }

        ///< The collision layer this body belongs to (determines if two objects can collide)
        public unsafe ushort mObjectLayer
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ushort *__JPH_BodyCreationSettings_Get_mObjectLayer(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mObjectLayer(_UnderlyingPtr);
            }
        }

        ///< The collision group this body belongs to (determines if two objects can collide)
        public unsafe JPH.Const_CollisionGroup mCollisionGroup
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_CollisionGroup._Underlying *__JPH_BodyCreationSettings_Get_mCollisionGroup(_Underlying *_this);
                JPH.Const_CollisionGroup __ret;
                __ret = new(__JPH_BodyCreationSettings_Get_mCollisionGroup(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< When this body is created as static, this setting tells the system to create a MotionProperties object so that the object can be switched to kinematic or dynamic
        public unsafe bool mAllowDynamicOrKinematic
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mAllowDynamicOrKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mAllowDynamicOrKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_BodyCreationSettings_Get_mAllowDynamicOrKinematic(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mAllowDynamicOrKinematic(_UnderlyingPtr);
            }
        }

        ///< If this body is a sensor. A sensor will receive collision callbacks, but will not cause any collision responses and can be used as a trigger volume. See description at Body::SetIsSensor.
        public unsafe bool mIsSensor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_BodyCreationSettings_Get_mIsSensor(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mIsSensor(_UnderlyingPtr);
            }
        }

        ///< If kinematic objects can generate contact points against other kinematic or static objects. See description at Body::SetCollideKinematicVsNonDynamic.
        public unsafe bool mCollideKinematicVsNonDynamic
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mCollideKinematicVsNonDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mCollideKinematicVsNonDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_BodyCreationSettings_Get_mCollideKinematicVsNonDynamic(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mCollideKinematicVsNonDynamic(_UnderlyingPtr);
            }
        }

        ///< If this body should use manifold reduction (see description at Body::SetUseManifoldReduction)
        public unsafe bool mUseManifoldReduction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_BodyCreationSettings_Get_mUseManifoldReduction(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mUseManifoldReduction(_UnderlyingPtr);
            }
        }

        ///< Set to indicate that the gyroscopic force should be applied to this body (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
        public unsafe bool mApplyGyroscopicForce
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mApplyGyroscopicForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mApplyGyroscopicForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_BodyCreationSettings_Get_mApplyGyroscopicForce(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mApplyGyroscopicForce(_UnderlyingPtr);
            }
        }

        ///< Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
        public unsafe bool mEnhancedInternalEdgeRemoval
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_BodyCreationSettings_Get_mEnhancedInternalEdgeRemoval(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mEnhancedInternalEdgeRemoval(_UnderlyingPtr);
            }
        }

        ///< If this body can go to sleep or not
        public unsafe bool mAllowSleeping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_BodyCreationSettings_Get_mAllowSleeping(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mAllowSleeping(_UnderlyingPtr);
            }
        }

        ///< Friction of the body (dimensionless number, usually between 0 and 1, 0 = no friction, 1 = friction force equals force that presses the two bodies together). Note that bodies can have negative friction but the combined friction (see PhysicsSystem::SetCombineFriction) should never go below zero.
        public unsafe float mFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_Get_mFriction(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mFriction(_UnderlyingPtr);
            }
        }

        ///< Restitution of body (dimensionless number, usually between 0 and 1, 0 = completely inelastic collision response, 1 = completely elastic collision response). Note that bodies can have negative restitution but the combined restitution (see PhysicsSystem::SetCombineRestitution) should never go below zero.
        public unsafe float mRestitution
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_Get_mRestitution(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mRestitution(_UnderlyingPtr);
            }
        }

        ///< Linear damping: dv/dt = -c * v. c. Value should be zero or positive and is usually close to 0.
        public unsafe float mLinearDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_Get_mLinearDamping(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mLinearDamping(_UnderlyingPtr);
            }
        }

        ///< Angular damping: dw/dt = -c * w. c. Value should be zero or positive and is usually close to 0.
        public unsafe float mAngularDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_Get_mAngularDamping(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mAngularDamping(_UnderlyingPtr);
            }
        }

        ///< Maximum linear velocity that this body can reach (m/s)
        public unsafe float mMaxLinearVelocity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_Get_mMaxLinearVelocity(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mMaxLinearVelocity(_UnderlyingPtr);
            }
        }

        ///< Maximum angular velocity that this body can reach (rad/s)
        public unsafe float mMaxAngularVelocity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_Get_mMaxAngularVelocity(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mMaxAngularVelocity(_UnderlyingPtr);
            }
        }

        ///< Value to multiply gravity with for this body
        public unsafe float mGravityFactor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_Get_mGravityFactor(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mGravityFactor(_UnderlyingPtr);
            }
        }

        ///< Used only when this body is dynamic and colliding. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public unsafe uint mNumVelocityStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_BodyCreationSettings_Get_mNumVelocityStepsOverride(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mNumVelocityStepsOverride(_UnderlyingPtr);
            }
        }

        ///< Used only when this body is dynamic and colliding. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public unsafe uint mNumPositionStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_BodyCreationSettings_Get_mNumPositionStepsOverride(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mNumPositionStepsOverride(_UnderlyingPtr);
            }
        }

        ///< When calculating the inertia (not when it is provided) the calculated inertia will be multiplied by this value
        public unsafe float mInertiaMultiplier
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mInertiaMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_Get_mInertiaMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_Get_mInertiaMultiplier(_Underlying *_this);
                return *__JPH_BodyCreationSettings_Get_mInertiaMultiplier(_UnderlyingPtr);
            }
        }

        internal unsafe Const_BodyCreationSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_BodyCreationSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyCreationSettings._Underlying *__JPH_BodyCreationSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_BodyCreationSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::BodyCreationSettings::BodyCreationSettings`.
        public unsafe Const_BodyCreationSettings(JPH._ByValue_BodyCreationSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyCreationSettings._Underlying *__JPH_BodyCreationSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.BodyCreationSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_BodyCreationSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::BodyCreationSettings::BodyCreationSettings`.
        public Const_BodyCreationSettings(Const_BodyCreationSettings _other) : this(new _ByValue_BodyCreationSettings(_other)) {}

        /// Generated from constructor `JPH::BodyCreationSettings::BodyCreationSettings`.
        public Const_BodyCreationSettings(BodyCreationSettings _other) : this((Const_BodyCreationSettings)_other) {}

        /// Generated from method `JPH::BodyCreationSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_BodyCreationSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_BodyCreationSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_BodyCreationSettings_size_t(ulong inCount);
            return __Jolt_new_JPH_BodyCreationSettings_size_t(inCount);
        }

        /// Generated from method `JPH::BodyCreationSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BodyCreationSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BodyCreationSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_BodyCreationSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_BodyCreationSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::BodyCreationSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BodyCreationSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BodyCreationSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_BodyCreationSettings_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_JPH_BodyCreationSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::BodyCreationSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_BodyCreationSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_BodyCreationSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_BodyCreationSettings_size_t(ulong inCount);
            return __Jolt_new_array_JPH_BodyCreationSettings_size_t(inCount);
        }

        /// Generated from method `JPH::BodyCreationSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyCreationSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyCreationSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_BodyCreationSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_BodyCreationSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::BodyCreationSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyCreationSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyCreationSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_BodyCreationSettings_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_array_JPH_BodyCreationSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::BodyCreationSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_BodyCreationSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_BodyCreationSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_BodyCreationSettings_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_JPH_BodyCreationSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::BodyCreationSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_BodyCreationSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_BodyCreationSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_BodyCreationSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_BodyCreationSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::BodyCreationSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_BodyCreationSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_BodyCreationSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_BodyCreationSettings_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_array_JPH_BodyCreationSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::BodyCreationSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyCreationSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_BodyCreationSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_BodyCreationSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_BodyCreationSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Access to the shape settings object. This contains serializable (non-runtime optimized) information about the Shape.
        /// Generated from method `JPH::BodyCreationSettings::GetShapeSettings`.
        public unsafe JPH.Const_ShapeSettings? GetShapeSettings()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ShapeSettings._Underlying *__JPH_BodyCreationSettings_GetShapeSettings(_Underlying *_this);
            var __c_ret = __JPH_BodyCreationSettings_GetShapeSettings(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_ShapeSettings(__c_ret, is_owning: false) : null;
        }

        /// Access to the run-time shape object. Will convert from ShapeSettings object if needed.
        /// Generated from method `JPH::BodyCreationSettings::GetShape`.
        public unsafe JPH.Const_Shape? GetShape()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_Shape._Underlying *__JPH_BodyCreationSettings_GetShape(_Underlying *_this);
            var __c_ret = __JPH_BodyCreationSettings_GetShape(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_Shape(__c_ret, is_owning: false) : null;
        }

        /// Check if the mass properties of this body will be calculated (only relevant for kinematic or dynamic objects that need a MotionProperties object)
        /// Generated from method `JPH::BodyCreationSettings::HasMassProperties`.
        public unsafe bool HasMassProperties()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_HasMassProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_HasMassProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_BodyCreationSettings_HasMassProperties(_Underlying *_this);
            return __JPH_BodyCreationSettings_HasMassProperties(_UnderlyingPtr) != 0;
        }
    }

    /// Settings for constructing a rigid body
    /// Generated from class `JPH::BodyCreationSettings`.
    /// This is the non-const half of the class.
    public class BodyCreationSettings : Const_BodyCreationSettings
    {
        ///< Position of the body (not of the center of mass)
        public new unsafe JPH.Vec3 mPosition
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_BodyCreationSettings_GetMutable_mPosition(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_BodyCreationSettings_GetMutable_mPosition(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Quat._Underlying *__JPH_BodyCreationSettings_GetMutable_mRotation(_Underlying *_this);
                JPH.Quat __ret;
                __ret = new(__JPH_BodyCreationSettings_GetMutable_mRotation(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_BodyCreationSettings_GetMutable_mLinearVelocity(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_BodyCreationSettings_GetMutable_mLinearVelocity(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_BodyCreationSettings_GetMutable_mAngularVelocity(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_BodyCreationSettings_GetMutable_mAngularVelocity(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong *__JPH_BodyCreationSettings_GetMutable_mUserData(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mUserData(_UnderlyingPtr);
            }
        }

        ///< The collision layer this body belongs to (determines if two objects can collide)
        public new unsafe ref ushort mObjectLayer
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ushort *__JPH_BodyCreationSettings_GetMutable_mObjectLayer(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mObjectLayer(_UnderlyingPtr);
            }
        }

        ///< The collision group this body belongs to (determines if two objects can collide)
        public new unsafe JPH.CollisionGroup mCollisionGroup
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.CollisionGroup._Underlying *__JPH_BodyCreationSettings_GetMutable_mCollisionGroup(_Underlying *_this);
                JPH.CollisionGroup __ret;
                __ret = new(__JPH_BodyCreationSettings_GetMutable_mCollisionGroup(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< When this body is created as static, this setting tells the system to create a MotionProperties object so that the object can be switched to kinematic or dynamic
        public new unsafe ref bool mAllowDynamicOrKinematic
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mAllowDynamicOrKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mAllowDynamicOrKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_BodyCreationSettings_GetMutable_mAllowDynamicOrKinematic(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mAllowDynamicOrKinematic(_UnderlyingPtr);
            }
        }

        ///< If this body is a sensor. A sensor will receive collision callbacks, but will not cause any collision responses and can be used as a trigger volume. See description at Body::SetIsSensor.
        public new unsafe ref bool mIsSensor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_BodyCreationSettings_GetMutable_mIsSensor(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mIsSensor(_UnderlyingPtr);
            }
        }

        ///< If kinematic objects can generate contact points against other kinematic or static objects. See description at Body::SetCollideKinematicVsNonDynamic.
        public new unsafe ref bool mCollideKinematicVsNonDynamic
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mCollideKinematicVsNonDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mCollideKinematicVsNonDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_BodyCreationSettings_GetMutable_mCollideKinematicVsNonDynamic(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mCollideKinematicVsNonDynamic(_UnderlyingPtr);
            }
        }

        ///< If this body should use manifold reduction (see description at Body::SetUseManifoldReduction)
        public new unsafe ref bool mUseManifoldReduction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_BodyCreationSettings_GetMutable_mUseManifoldReduction(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mUseManifoldReduction(_UnderlyingPtr);
            }
        }

        ///< Set to indicate that the gyroscopic force should be applied to this body (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
        public new unsafe ref bool mApplyGyroscopicForce
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mApplyGyroscopicForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mApplyGyroscopicForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_BodyCreationSettings_GetMutable_mApplyGyroscopicForce(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mApplyGyroscopicForce(_UnderlyingPtr);
            }
        }

        ///< Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
        public new unsafe ref bool mEnhancedInternalEdgeRemoval
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_BodyCreationSettings_GetMutable_mEnhancedInternalEdgeRemoval(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mEnhancedInternalEdgeRemoval(_UnderlyingPtr);
            }
        }

        ///< If this body can go to sleep or not
        public new unsafe ref bool mAllowSleeping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_BodyCreationSettings_GetMutable_mAllowSleeping(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mAllowSleeping(_UnderlyingPtr);
            }
        }

        ///< Friction of the body (dimensionless number, usually between 0 and 1, 0 = no friction, 1 = friction force equals force that presses the two bodies together). Note that bodies can have negative friction but the combined friction (see PhysicsSystem::SetCombineFriction) should never go below zero.
        public new unsafe ref float mFriction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_GetMutable_mFriction(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mFriction(_UnderlyingPtr);
            }
        }

        ///< Restitution of body (dimensionless number, usually between 0 and 1, 0 = completely inelastic collision response, 1 = completely elastic collision response). Note that bodies can have negative restitution but the combined restitution (see PhysicsSystem::SetCombineRestitution) should never go below zero.
        public new unsafe ref float mRestitution
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_GetMutable_mRestitution(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mRestitution(_UnderlyingPtr);
            }
        }

        ///< Linear damping: dv/dt = -c * v. c. Value should be zero or positive and is usually close to 0.
        public new unsafe ref float mLinearDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_GetMutable_mLinearDamping(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mLinearDamping(_UnderlyingPtr);
            }
        }

        ///< Angular damping: dw/dt = -c * w. c. Value should be zero or positive and is usually close to 0.
        public new unsafe ref float mAngularDamping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_GetMutable_mAngularDamping(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mAngularDamping(_UnderlyingPtr);
            }
        }

        ///< Maximum linear velocity that this body can reach (m/s)
        public new unsafe ref float mMaxLinearVelocity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_GetMutable_mMaxLinearVelocity(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mMaxLinearVelocity(_UnderlyingPtr);
            }
        }

        ///< Maximum angular velocity that this body can reach (rad/s)
        public new unsafe ref float mMaxAngularVelocity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_GetMutable_mMaxAngularVelocity(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mMaxAngularVelocity(_UnderlyingPtr);
            }
        }

        ///< Value to multiply gravity with for this body
        public new unsafe ref float mGravityFactor
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_GetMutable_mGravityFactor(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mGravityFactor(_UnderlyingPtr);
            }
        }

        ///< Used only when this body is dynamic and colliding. Override for the number of solver velocity iterations to run, 0 means use the default in PhysicsSettings::mNumVelocitySteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public new unsafe ref uint mNumVelocityStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mNumVelocityStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_BodyCreationSettings_GetMutable_mNumVelocityStepsOverride(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mNumVelocityStepsOverride(_UnderlyingPtr);
            }
        }

        ///< Used only when this body is dynamic and colliding. Override for the number of solver position iterations to run, 0 means use the default in PhysicsSettings::mNumPositionSteps. The number of iterations to use is the max of all contacts and constraints in the island.
        public new unsafe ref uint mNumPositionStepsOverride
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mNumPositionStepsOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_BodyCreationSettings_GetMutable_mNumPositionStepsOverride(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mNumPositionStepsOverride(_UnderlyingPtr);
            }
        }

        ///< When calculating the inertia (not when it is provided) the calculated inertia will be multiplied by this value
        public new unsafe ref float mInertiaMultiplier
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mInertiaMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_GetMutable_mInertiaMultiplier", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_BodyCreationSettings_GetMutable_mInertiaMultiplier(_Underlying *_this);
                return ref *__JPH_BodyCreationSettings_GetMutable_mInertiaMultiplier(_UnderlyingPtr);
            }
        }

        internal unsafe BodyCreationSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe BodyCreationSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyCreationSettings._Underlying *__JPH_BodyCreationSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_BodyCreationSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::BodyCreationSettings::BodyCreationSettings`.
        public unsafe BodyCreationSettings(JPH._ByValue_BodyCreationSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyCreationSettings._Underlying *__JPH_BodyCreationSettings_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.BodyCreationSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_BodyCreationSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::BodyCreationSettings::BodyCreationSettings`.
        public BodyCreationSettings(Const_BodyCreationSettings _other) : this(new _ByValue_BodyCreationSettings(_other)) {}

        /// Generated from constructor `JPH::BodyCreationSettings::BodyCreationSettings`.
        public BodyCreationSettings(BodyCreationSettings _other) : this((Const_BodyCreationSettings)_other) {}

        /// Generated from method `JPH::BodyCreationSettings::operator=`.
        public unsafe JPH.BodyCreationSettings Assign(JPH._ByValue_BodyCreationSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyCreationSettings._Underlying *__JPH_BodyCreationSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.BodyCreationSettings._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_BodyCreationSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JPH::BodyCreationSettings::SetShapeSettings`.
        public unsafe void SetShapeSettings(JPH.Const_ShapeSettings? inShape)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_SetShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_SetShapeSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyCreationSettings_SetShapeSettings(_Underlying *_this, JPH.Const_ShapeSettings._Underlying *inShape);
            __JPH_BodyCreationSettings_SetShapeSettings(_UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null);
        }

        /// Generated from method `JPH::BodyCreationSettings::SetShape`.
        public unsafe void SetShape(JPH.Const_Shape? inShape)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyCreationSettings_SetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyCreationSettings_SetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyCreationSettings_SetShape(_Underlying *_this, JPH.Const_Shape._Underlying *inShape);
            __JPH_BodyCreationSettings_SetShape(_UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BodyCreationSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `BodyCreationSettings`/`Const_BodyCreationSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BodyCreationSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_BodyCreationSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_BodyCreationSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_BodyCreationSettings(Const_BodyCreationSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_BodyCreationSettings(Const_BodyCreationSettings arg) {return new(arg);}
        public _ByValue_BodyCreationSettings(JPH._Moved<BodyCreationSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_BodyCreationSettings(JPH._Moved<BodyCreationSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `BodyCreationSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BodyCreationSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BodyCreationSettings`/`Const_BodyCreationSettings` directly.
    public class _InOptMut_BodyCreationSettings
    {
        public BodyCreationSettings? Opt;

        public _InOptMut_BodyCreationSettings() {}
        public _InOptMut_BodyCreationSettings(BodyCreationSettings value) {Opt = value;}
        public static implicit operator _InOptMut_BodyCreationSettings(BodyCreationSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `BodyCreationSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BodyCreationSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BodyCreationSettings`/`Const_BodyCreationSettings` to pass it to the function.
    public class _InOptConst_BodyCreationSettings
    {
        public Const_BodyCreationSettings? Opt;

        public _InOptConst_BodyCreationSettings() {}
        public _InOptConst_BodyCreationSettings(Const_BodyCreationSettings value) {Opt = value;}
        public static implicit operator _InOptConst_BodyCreationSettings(Const_BodyCreationSettings value) {return new(value);}
    }
}
