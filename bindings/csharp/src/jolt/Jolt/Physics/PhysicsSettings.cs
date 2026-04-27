// machine generated, do not edit
public static partial class JPH
{
    /// Generated from class `JPH::PhysicsSettings`.
    /// This is the const half of the class.
    public class Const_PhysicsSettings : JPH.Object<Const_PhysicsSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PhysicsSettings_Destroy(_Underlying *_this);
            __JPH_PhysicsSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_PhysicsSettings() {Dispose(false);}

        /// Size of body pairs array, corresponds to the maximum amount of potential body pairs that can be in flight at any time.
        /// Setting this to a low value will use less memory but slow down simulation as threads may run out of narrow phase work.
        public unsafe int mMaxInFlightBodyPairs
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mMaxInFlightBodyPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mMaxInFlightBodyPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_PhysicsSettings_Get_mMaxInFlightBodyPairs(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mMaxInFlightBodyPairs(_UnderlyingPtr);
            }
        }

        /// How many PhysicsStepListeners to notify in 1 batch
        public unsafe int mStepListenersBatchSize
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mStepListenersBatchSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mStepListenersBatchSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_PhysicsSettings_Get_mStepListenersBatchSize(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mStepListenersBatchSize(_UnderlyingPtr);
            }
        }

        /// How many step listener batches are needed before spawning another job (set to INT_MAX if no parallelism is desired)
        public unsafe int mStepListenerBatchesPerJob
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mStepListenerBatchesPerJob", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mStepListenerBatchesPerJob", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_PhysicsSettings_Get_mStepListenerBatchesPerJob(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mStepListenerBatchesPerJob(_UnderlyingPtr);
            }
        }

        /// Baumgarte stabilization factor (how much of the position error to 'fix' in 1 update) (unit: dimensionless, 0 = nothing, 1 = 100%)
        public unsafe float mBaumgarte
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mBaumgarte", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mBaumgarte", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_Get_mBaumgarte(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mBaumgarte(_UnderlyingPtr);
            }
        }

        /// Radius around objects inside which speculative contact points will be detected. Note that if this is too big
        /// you will get ghost collisions as speculative contacts are based on the closest points during the collision detection
        /// step which may not be the actual closest points by the time the two objects hit (unit: meters)
        public unsafe float mSpeculativeContactDistance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mSpeculativeContactDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mSpeculativeContactDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_Get_mSpeculativeContactDistance(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mSpeculativeContactDistance(_UnderlyingPtr);
            }
        }

        /// How much bodies are allowed to sink into each other (unit: meters)
        public unsafe float mPenetrationSlop
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mPenetrationSlop", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mPenetrationSlop", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_Get_mPenetrationSlop(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mPenetrationSlop(_UnderlyingPtr);
            }
        }

        /// Fraction of its inner radius a body must move per step to enable casting for the LinearCast motion quality
        public unsafe float mLinearCastThreshold
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mLinearCastThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mLinearCastThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_Get_mLinearCastThreshold(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mLinearCastThreshold(_UnderlyingPtr);
            }
        }

        /// Fraction of its inner radius a body may penetrate another body for the LinearCast motion quality
        public unsafe float mLinearCastMaxPenetration
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mLinearCastMaxPenetration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mLinearCastMaxPenetration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_Get_mLinearCastMaxPenetration(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mLinearCastMaxPenetration(_UnderlyingPtr);
            }
        }

        /// Max distance to use to determine if two points are on the same plane for determining the contact manifold between two shape faces (unit: meter)
        public unsafe float mManifoldTolerance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mManifoldTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mManifoldTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_Get_mManifoldTolerance(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mManifoldTolerance(_UnderlyingPtr);
            }
        }

        /// Maximum distance to correct in a single iteration when solving position constraints (unit: meters)
        public unsafe float mMaxPenetrationDistance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mMaxPenetrationDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mMaxPenetrationDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_Get_mMaxPenetrationDistance(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mMaxPenetrationDistance(_UnderlyingPtr);
            }
        }

        ///< 1 mm
        public unsafe float mBodyPairCacheMaxDeltaPositionSq
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mBodyPairCacheMaxDeltaPositionSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mBodyPairCacheMaxDeltaPositionSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_Get_mBodyPairCacheMaxDeltaPositionSq(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mBodyPairCacheMaxDeltaPositionSq(_UnderlyingPtr);
            }
        }

        ///< cos(2 degrees / 2)
        public unsafe float mBodyPairCacheCosMaxDeltaRotationDiv2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mBodyPairCacheCosMaxDeltaRotationDiv2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mBodyPairCacheCosMaxDeltaRotationDiv2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_Get_mBodyPairCacheCosMaxDeltaRotationDiv2(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mBodyPairCacheCosMaxDeltaRotationDiv2(_UnderlyingPtr);
            }
        }

        ///< cos(5 degree)
        public unsafe float mContactNormalCosMaxDeltaRotation
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mContactNormalCosMaxDeltaRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mContactNormalCosMaxDeltaRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_Get_mContactNormalCosMaxDeltaRotation(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mContactNormalCosMaxDeltaRotation(_UnderlyingPtr);
            }
        }

        ///< 1 cm
        public unsafe float mContactPointPreserveLambdaMaxDistSq
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mContactPointPreserveLambdaMaxDistSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mContactPointPreserveLambdaMaxDistSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_Get_mContactPointPreserveLambdaMaxDistSq(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mContactPointPreserveLambdaMaxDistSq(_UnderlyingPtr);
            }
        }

        /// Number of solver velocity iterations to run
        /// Note that this needs to be >= 2 in order for friction to work (friction is applied using the non-penetration impulse from the previous iteration)
        public unsafe uint mNumVelocitySteps
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mNumVelocitySteps", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mNumVelocitySteps", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_PhysicsSettings_Get_mNumVelocitySteps(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mNumVelocitySteps(_UnderlyingPtr);
            }
        }

        /// Number of solver position iterations to run
        public unsafe uint mNumPositionSteps
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mNumPositionSteps", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mNumPositionSteps", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_PhysicsSettings_Get_mNumPositionSteps(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mNumPositionSteps(_UnderlyingPtr);
            }
        }

        /// Minimal velocity needed before a collision can be elastic. If the relative velocity between colliding objects
        /// in the direction of the contact normal is lower than this, the restitution will be zero regardless of the configured
        /// value. This lets an object settle sooner. Must be a positive number. (unit: m)
        public unsafe float mMinVelocityForRestitution
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mMinVelocityForRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mMinVelocityForRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_Get_mMinVelocityForRestitution(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mMinVelocityForRestitution(_UnderlyingPtr);
            }
        }

        /// Time before object is allowed to go to sleep (unit: seconds)
        public unsafe float mTimeBeforeSleep
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mTimeBeforeSleep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mTimeBeforeSleep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_Get_mTimeBeforeSleep(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mTimeBeforeSleep(_UnderlyingPtr);
            }
        }

        /// To detect if an object is sleeping, we use 3 points:
        /// - The center of mass.
        /// - The centers of the faces of the bounding box that are furthest away from the center.
        /// The movement of these points is tracked and if the velocity of all 3 points is lower than this value,
        /// the object is allowed to go to sleep. Must be a positive number. (unit: m/s)
        public unsafe float mPointVelocitySleepThreshold
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mPointVelocitySleepThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mPointVelocitySleepThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_Get_mPointVelocitySleepThreshold(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mPointVelocitySleepThreshold(_UnderlyingPtr);
            }
        }

        /// By default the simulation is deterministic, it is possible to turn this off by setting this setting to false. This will make the simulation run faster but it will no longer be deterministic.
        public unsafe bool mDeterministicSimulation
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mDeterministicSimulation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mDeterministicSimulation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSettings_Get_mDeterministicSimulation(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mDeterministicSimulation(_UnderlyingPtr);
            }
        }

        /// Whether or not to use warm starting for constraints (initially applying previous frames impulses)
        public unsafe bool mConstraintWarmStart
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mConstraintWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mConstraintWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSettings_Get_mConstraintWarmStart(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mConstraintWarmStart(_UnderlyingPtr);
            }
        }

        /// Whether or not to use the body pair cache, which removes the need for narrow phase collision detection when orientation between two bodies didn't change
        public unsafe bool mUseBodyPairContactCache
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mUseBodyPairContactCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mUseBodyPairContactCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSettings_Get_mUseBodyPairContactCache(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mUseBodyPairContactCache(_UnderlyingPtr);
            }
        }

        /// Whether or not to reduce manifolds with similar contact normals into one contact manifold (see description at Body::SetUseManifoldReduction)
        public unsafe bool mUseManifoldReduction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSettings_Get_mUseManifoldReduction(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mUseManifoldReduction(_UnderlyingPtr);
            }
        }

        /// If we split up large islands into smaller parallel batches of work (to improve performance)
        public unsafe bool mUseLargeIslandSplitter
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mUseLargeIslandSplitter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mUseLargeIslandSplitter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSettings_Get_mUseLargeIslandSplitter(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mUseLargeIslandSplitter(_UnderlyingPtr);
            }
        }

        /// If objects can go to sleep or not
        public unsafe bool mAllowSleeping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSettings_Get_mAllowSleeping(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mAllowSleeping(_UnderlyingPtr);
            }
        }

        /// When false, we prevent collision against non-active (shared) edges. Mainly for debugging the algorithm.
        public unsafe bool mCheckActiveEdges
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mCheckActiveEdges", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_Get_mCheckActiveEdges", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSettings_Get_mCheckActiveEdges(_Underlying *_this);
                return *__JPH_PhysicsSettings_Get_mCheckActiveEdges(_UnderlyingPtr);
            }
        }

        internal unsafe Const_PhysicsSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_PhysicsSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsSettings._Underlying *__JPH_PhysicsSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_PhysicsSettings_DefaultConstruct();
        }

        /// Constructs `JPH::PhysicsSettings` elementwise.
        public unsafe Const_PhysicsSettings(int mMaxInFlightBodyPairs, int mStepListenersBatchSize, int mStepListenerBatchesPerJob, float mBaumgarte, float mSpeculativeContactDistance, float mPenetrationSlop, float mLinearCastThreshold, float mLinearCastMaxPenetration, float mManifoldTolerance, float mMaxPenetrationDistance, float mBodyPairCacheMaxDeltaPositionSq, float mBodyPairCacheCosMaxDeltaRotationDiv2, float mContactNormalCosMaxDeltaRotation, float mContactPointPreserveLambdaMaxDistSq, uint mNumVelocitySteps, uint mNumPositionSteps, float mMinVelocityForRestitution, float mTimeBeforeSleep, float mPointVelocitySleepThreshold, bool mDeterministicSimulation, bool mConstraintWarmStart, bool mUseBodyPairContactCache, bool mUseManifoldReduction, bool mUseLargeIslandSplitter, bool mAllowSleeping, bool mCheckActiveEdges) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsSettings._Underlying *__JPH_PhysicsSettings_ConstructFrom(int mMaxInFlightBodyPairs, int mStepListenersBatchSize, int mStepListenerBatchesPerJob, float mBaumgarte, float mSpeculativeContactDistance, float mPenetrationSlop, float mLinearCastThreshold, float mLinearCastMaxPenetration, float mManifoldTolerance, float mMaxPenetrationDistance, float mBodyPairCacheMaxDeltaPositionSq, float mBodyPairCacheCosMaxDeltaRotationDiv2, float mContactNormalCosMaxDeltaRotation, float mContactPointPreserveLambdaMaxDistSq, uint mNumVelocitySteps, uint mNumPositionSteps, float mMinVelocityForRestitution, float mTimeBeforeSleep, float mPointVelocitySleepThreshold, byte mDeterministicSimulation, byte mConstraintWarmStart, byte mUseBodyPairContactCache, byte mUseManifoldReduction, byte mUseLargeIslandSplitter, byte mAllowSleeping, byte mCheckActiveEdges);
            _UnderlyingPtr = __JPH_PhysicsSettings_ConstructFrom(mMaxInFlightBodyPairs, mStepListenersBatchSize, mStepListenerBatchesPerJob, mBaumgarte, mSpeculativeContactDistance, mPenetrationSlop, mLinearCastThreshold, mLinearCastMaxPenetration, mManifoldTolerance, mMaxPenetrationDistance, mBodyPairCacheMaxDeltaPositionSq, mBodyPairCacheCosMaxDeltaRotationDiv2, mContactNormalCosMaxDeltaRotation, mContactPointPreserveLambdaMaxDistSq, mNumVelocitySteps, mNumPositionSteps, mMinVelocityForRestitution, mTimeBeforeSleep, mPointVelocitySleepThreshold, mDeterministicSimulation ? (byte)1 : (byte)0, mConstraintWarmStart ? (byte)1 : (byte)0, mUseBodyPairContactCache ? (byte)1 : (byte)0, mUseManifoldReduction ? (byte)1 : (byte)0, mUseLargeIslandSplitter ? (byte)1 : (byte)0, mAllowSleeping ? (byte)1 : (byte)0, mCheckActiveEdges ? (byte)1 : (byte)0);
        }

        /// Generated from constructor `JPH::PhysicsSettings::PhysicsSettings`.
        public unsafe Const_PhysicsSettings(JPH.Const_PhysicsSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsSettings._Underlying *__JPH_PhysicsSettings_ConstructFromAnother(JPH.PhysicsSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_PhysicsSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::PhysicsSettings::PhysicsSettings`.
        public Const_PhysicsSettings(PhysicsSettings _other) : this((Const_PhysicsSettings)_other) {}

        /// Generated from method `JPH::PhysicsSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PhysicsSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PhysicsSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PhysicsSettings_size_t(ulong inCount);
            return __Jolt_new_JPH_PhysicsSettings_size_t(inCount);
        }

        /// Generated from method `JPH::PhysicsSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PhysicsSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_PhysicsSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PhysicsSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PhysicsSettings_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_JPH_PhysicsSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PhysicsSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PhysicsSettings_size_t(ulong inCount);
            return __Jolt_new_array_JPH_PhysicsSettings_size_t(inCount);
        }

        /// Generated from method `JPH::PhysicsSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PhysicsSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_PhysicsSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PhysicsSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, ulong inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PhysicsSettings_void_ptr_size_t(void *inPointer, ulong inSize);
            __Jolt_delete_array_JPH_PhysicsSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PhysicsSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PhysicsSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PhysicsSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PhysicsSettings_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_JPH_PhysicsSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PhysicsSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PhysicsSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PhysicsSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_PhysicsSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::PhysicsSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PhysicsSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PhysicsSettings_size_t_void_ptr(ulong inCount, void *inPointer);
            return __Jolt_new_array_JPH_PhysicsSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PhysicsSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PhysicsSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PhysicsSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_PhysicsSettings_void_ptr_void_ptr(inPointer, inPlace);
        }
    }

    /// Generated from class `JPH::PhysicsSettings`.
    /// This is the non-const half of the class.
    public class PhysicsSettings : Const_PhysicsSettings
    {
        /// Size of body pairs array, corresponds to the maximum amount of potential body pairs that can be in flight at any time.
        /// Setting this to a low value will use less memory but slow down simulation as threads may run out of narrow phase work.
        public new unsafe ref int mMaxInFlightBodyPairs
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mMaxInFlightBodyPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mMaxInFlightBodyPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_PhysicsSettings_GetMutable_mMaxInFlightBodyPairs(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mMaxInFlightBodyPairs(_UnderlyingPtr);
            }
        }

        /// How many PhysicsStepListeners to notify in 1 batch
        public new unsafe ref int mStepListenersBatchSize
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mStepListenersBatchSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mStepListenersBatchSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_PhysicsSettings_GetMutable_mStepListenersBatchSize(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mStepListenersBatchSize(_UnderlyingPtr);
            }
        }

        /// How many step listener batches are needed before spawning another job (set to INT_MAX if no parallelism is desired)
        public new unsafe ref int mStepListenerBatchesPerJob
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mStepListenerBatchesPerJob", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mStepListenerBatchesPerJob", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_PhysicsSettings_GetMutable_mStepListenerBatchesPerJob(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mStepListenerBatchesPerJob(_UnderlyingPtr);
            }
        }

        /// Baumgarte stabilization factor (how much of the position error to 'fix' in 1 update) (unit: dimensionless, 0 = nothing, 1 = 100%)
        public new unsafe ref float mBaumgarte
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mBaumgarte", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mBaumgarte", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_GetMutable_mBaumgarte(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mBaumgarte(_UnderlyingPtr);
            }
        }

        /// Radius around objects inside which speculative contact points will be detected. Note that if this is too big
        /// you will get ghost collisions as speculative contacts are based on the closest points during the collision detection
        /// step which may not be the actual closest points by the time the two objects hit (unit: meters)
        public new unsafe ref float mSpeculativeContactDistance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mSpeculativeContactDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mSpeculativeContactDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_GetMutable_mSpeculativeContactDistance(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mSpeculativeContactDistance(_UnderlyingPtr);
            }
        }

        /// How much bodies are allowed to sink into each other (unit: meters)
        public new unsafe ref float mPenetrationSlop
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mPenetrationSlop", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mPenetrationSlop", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_GetMutable_mPenetrationSlop(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mPenetrationSlop(_UnderlyingPtr);
            }
        }

        /// Fraction of its inner radius a body must move per step to enable casting for the LinearCast motion quality
        public new unsafe ref float mLinearCastThreshold
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mLinearCastThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mLinearCastThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_GetMutable_mLinearCastThreshold(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mLinearCastThreshold(_UnderlyingPtr);
            }
        }

        /// Fraction of its inner radius a body may penetrate another body for the LinearCast motion quality
        public new unsafe ref float mLinearCastMaxPenetration
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mLinearCastMaxPenetration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mLinearCastMaxPenetration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_GetMutable_mLinearCastMaxPenetration(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mLinearCastMaxPenetration(_UnderlyingPtr);
            }
        }

        /// Max distance to use to determine if two points are on the same plane for determining the contact manifold between two shape faces (unit: meter)
        public new unsafe ref float mManifoldTolerance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mManifoldTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mManifoldTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_GetMutable_mManifoldTolerance(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mManifoldTolerance(_UnderlyingPtr);
            }
        }

        /// Maximum distance to correct in a single iteration when solving position constraints (unit: meters)
        public new unsafe ref float mMaxPenetrationDistance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mMaxPenetrationDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mMaxPenetrationDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_GetMutable_mMaxPenetrationDistance(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mMaxPenetrationDistance(_UnderlyingPtr);
            }
        }

        ///< 1 mm
        public new unsafe ref float mBodyPairCacheMaxDeltaPositionSq
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mBodyPairCacheMaxDeltaPositionSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mBodyPairCacheMaxDeltaPositionSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_GetMutable_mBodyPairCacheMaxDeltaPositionSq(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mBodyPairCacheMaxDeltaPositionSq(_UnderlyingPtr);
            }
        }

        ///< cos(2 degrees / 2)
        public new unsafe ref float mBodyPairCacheCosMaxDeltaRotationDiv2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mBodyPairCacheCosMaxDeltaRotationDiv2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mBodyPairCacheCosMaxDeltaRotationDiv2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_GetMutable_mBodyPairCacheCosMaxDeltaRotationDiv2(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mBodyPairCacheCosMaxDeltaRotationDiv2(_UnderlyingPtr);
            }
        }

        ///< cos(5 degree)
        public new unsafe ref float mContactNormalCosMaxDeltaRotation
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mContactNormalCosMaxDeltaRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mContactNormalCosMaxDeltaRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_GetMutable_mContactNormalCosMaxDeltaRotation(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mContactNormalCosMaxDeltaRotation(_UnderlyingPtr);
            }
        }

        ///< 1 cm
        public new unsafe ref float mContactPointPreserveLambdaMaxDistSq
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mContactPointPreserveLambdaMaxDistSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mContactPointPreserveLambdaMaxDistSq", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_GetMutable_mContactPointPreserveLambdaMaxDistSq(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mContactPointPreserveLambdaMaxDistSq(_UnderlyingPtr);
            }
        }

        /// Number of solver velocity iterations to run
        /// Note that this needs to be >= 2 in order for friction to work (friction is applied using the non-penetration impulse from the previous iteration)
        public new unsafe ref uint mNumVelocitySteps
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mNumVelocitySteps", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mNumVelocitySteps", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_PhysicsSettings_GetMutable_mNumVelocitySteps(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mNumVelocitySteps(_UnderlyingPtr);
            }
        }

        /// Number of solver position iterations to run
        public new unsafe ref uint mNumPositionSteps
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mNumPositionSteps", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mNumPositionSteps", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__JPH_PhysicsSettings_GetMutable_mNumPositionSteps(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mNumPositionSteps(_UnderlyingPtr);
            }
        }

        /// Minimal velocity needed before a collision can be elastic. If the relative velocity between colliding objects
        /// in the direction of the contact normal is lower than this, the restitution will be zero regardless of the configured
        /// value. This lets an object settle sooner. Must be a positive number. (unit: m)
        public new unsafe ref float mMinVelocityForRestitution
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mMinVelocityForRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mMinVelocityForRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_GetMutable_mMinVelocityForRestitution(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mMinVelocityForRestitution(_UnderlyingPtr);
            }
        }

        /// Time before object is allowed to go to sleep (unit: seconds)
        public new unsafe ref float mTimeBeforeSleep
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mTimeBeforeSleep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mTimeBeforeSleep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_GetMutable_mTimeBeforeSleep(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mTimeBeforeSleep(_UnderlyingPtr);
            }
        }

        /// To detect if an object is sleeping, we use 3 points:
        /// - The center of mass.
        /// - The centers of the faces of the bounding box that are furthest away from the center.
        /// The movement of these points is tracked and if the velocity of all 3 points is lower than this value,
        /// the object is allowed to go to sleep. Must be a positive number. (unit: m/s)
        public new unsafe ref float mPointVelocitySleepThreshold
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mPointVelocitySleepThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mPointVelocitySleepThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_PhysicsSettings_GetMutable_mPointVelocitySleepThreshold(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mPointVelocitySleepThreshold(_UnderlyingPtr);
            }
        }

        /// By default the simulation is deterministic, it is possible to turn this off by setting this setting to false. This will make the simulation run faster but it will no longer be deterministic.
        public new unsafe ref bool mDeterministicSimulation
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mDeterministicSimulation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mDeterministicSimulation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSettings_GetMutable_mDeterministicSimulation(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mDeterministicSimulation(_UnderlyingPtr);
            }
        }

        /// Whether or not to use warm starting for constraints (initially applying previous frames impulses)
        public new unsafe ref bool mConstraintWarmStart
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mConstraintWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mConstraintWarmStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSettings_GetMutable_mConstraintWarmStart(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mConstraintWarmStart(_UnderlyingPtr);
            }
        }

        /// Whether or not to use the body pair cache, which removes the need for narrow phase collision detection when orientation between two bodies didn't change
        public new unsafe ref bool mUseBodyPairContactCache
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mUseBodyPairContactCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mUseBodyPairContactCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSettings_GetMutable_mUseBodyPairContactCache(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mUseBodyPairContactCache(_UnderlyingPtr);
            }
        }

        /// Whether or not to reduce manifolds with similar contact normals into one contact manifold (see description at Body::SetUseManifoldReduction)
        public new unsafe ref bool mUseManifoldReduction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSettings_GetMutable_mUseManifoldReduction(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mUseManifoldReduction(_UnderlyingPtr);
            }
        }

        /// If we split up large islands into smaller parallel batches of work (to improve performance)
        public new unsafe ref bool mUseLargeIslandSplitter
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mUseLargeIslandSplitter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mUseLargeIslandSplitter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSettings_GetMutable_mUseLargeIslandSplitter(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mUseLargeIslandSplitter(_UnderlyingPtr);
            }
        }

        /// If objects can go to sleep or not
        public new unsafe ref bool mAllowSleeping
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSettings_GetMutable_mAllowSleeping(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mAllowSleeping(_UnderlyingPtr);
            }
        }

        /// When false, we prevent collision against non-active (shared) edges. Mainly for debugging the algorithm.
        public new unsafe ref bool mCheckActiveEdges
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mCheckActiveEdges", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_GetMutable_mCheckActiveEdges", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_PhysicsSettings_GetMutable_mCheckActiveEdges(_Underlying *_this);
                return ref *__JPH_PhysicsSettings_GetMutable_mCheckActiveEdges(_UnderlyingPtr);
            }
        }

        internal unsafe PhysicsSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe PhysicsSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsSettings._Underlying *__JPH_PhysicsSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_PhysicsSettings_DefaultConstruct();
        }

        /// Constructs `JPH::PhysicsSettings` elementwise.
        public unsafe PhysicsSettings(int mMaxInFlightBodyPairs, int mStepListenersBatchSize, int mStepListenerBatchesPerJob, float mBaumgarte, float mSpeculativeContactDistance, float mPenetrationSlop, float mLinearCastThreshold, float mLinearCastMaxPenetration, float mManifoldTolerance, float mMaxPenetrationDistance, float mBodyPairCacheMaxDeltaPositionSq, float mBodyPairCacheCosMaxDeltaRotationDiv2, float mContactNormalCosMaxDeltaRotation, float mContactPointPreserveLambdaMaxDistSq, uint mNumVelocitySteps, uint mNumPositionSteps, float mMinVelocityForRestitution, float mTimeBeforeSleep, float mPointVelocitySleepThreshold, bool mDeterministicSimulation, bool mConstraintWarmStart, bool mUseBodyPairContactCache, bool mUseManifoldReduction, bool mUseLargeIslandSplitter, bool mAllowSleeping, bool mCheckActiveEdges) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsSettings._Underlying *__JPH_PhysicsSettings_ConstructFrom(int mMaxInFlightBodyPairs, int mStepListenersBatchSize, int mStepListenerBatchesPerJob, float mBaumgarte, float mSpeculativeContactDistance, float mPenetrationSlop, float mLinearCastThreshold, float mLinearCastMaxPenetration, float mManifoldTolerance, float mMaxPenetrationDistance, float mBodyPairCacheMaxDeltaPositionSq, float mBodyPairCacheCosMaxDeltaRotationDiv2, float mContactNormalCosMaxDeltaRotation, float mContactPointPreserveLambdaMaxDistSq, uint mNumVelocitySteps, uint mNumPositionSteps, float mMinVelocityForRestitution, float mTimeBeforeSleep, float mPointVelocitySleepThreshold, byte mDeterministicSimulation, byte mConstraintWarmStart, byte mUseBodyPairContactCache, byte mUseManifoldReduction, byte mUseLargeIslandSplitter, byte mAllowSleeping, byte mCheckActiveEdges);
            _UnderlyingPtr = __JPH_PhysicsSettings_ConstructFrom(mMaxInFlightBodyPairs, mStepListenersBatchSize, mStepListenerBatchesPerJob, mBaumgarte, mSpeculativeContactDistance, mPenetrationSlop, mLinearCastThreshold, mLinearCastMaxPenetration, mManifoldTolerance, mMaxPenetrationDistance, mBodyPairCacheMaxDeltaPositionSq, mBodyPairCacheCosMaxDeltaRotationDiv2, mContactNormalCosMaxDeltaRotation, mContactPointPreserveLambdaMaxDistSq, mNumVelocitySteps, mNumPositionSteps, mMinVelocityForRestitution, mTimeBeforeSleep, mPointVelocitySleepThreshold, mDeterministicSimulation ? (byte)1 : (byte)0, mConstraintWarmStart ? (byte)1 : (byte)0, mUseBodyPairContactCache ? (byte)1 : (byte)0, mUseManifoldReduction ? (byte)1 : (byte)0, mUseLargeIslandSplitter ? (byte)1 : (byte)0, mAllowSleeping ? (byte)1 : (byte)0, mCheckActiveEdges ? (byte)1 : (byte)0);
        }

        /// Generated from constructor `JPH::PhysicsSettings::PhysicsSettings`.
        public unsafe PhysicsSettings(JPH.Const_PhysicsSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsSettings._Underlying *__JPH_PhysicsSettings_ConstructFromAnother(JPH.PhysicsSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_PhysicsSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::PhysicsSettings::PhysicsSettings`.
        public PhysicsSettings(PhysicsSettings _other) : this((Const_PhysicsSettings)_other) {}

        /// Generated from method `JPH::PhysicsSettings::operator=`.
        public unsafe JPH.PhysicsSettings Assign(JPH.Const_PhysicsSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PhysicsSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PhysicsSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PhysicsSettings._Underlying *__JPH_PhysicsSettings_AssignFromAnother(_Underlying *_this, JPH.PhysicsSettings._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_PhysicsSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `PhysicsSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_PhysicsSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PhysicsSettings`/`Const_PhysicsSettings` directly.
    public class _InOptMut_PhysicsSettings
    {
        public PhysicsSettings? Opt;

        public _InOptMut_PhysicsSettings() {}
        public _InOptMut_PhysicsSettings(PhysicsSettings value) {Opt = value;}
        public static implicit operator _InOptMut_PhysicsSettings(PhysicsSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `PhysicsSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_PhysicsSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PhysicsSettings`/`Const_PhysicsSettings` to pass it to the function.
    public class _InOptConst_PhysicsSettings
    {
        public Const_PhysicsSettings? Opt;

        public _InOptConst_PhysicsSettings() {}
        public _InOptConst_PhysicsSettings(Const_PhysicsSettings value) {Opt = value;}
        public static implicit operator _InOptConst_PhysicsSettings(Const_PhysicsSettings value) {return new(value);}
    }
}
