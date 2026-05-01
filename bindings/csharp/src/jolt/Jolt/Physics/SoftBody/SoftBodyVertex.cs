// machine generated, do not edit
public static partial class JPH
{
    /// Run time information for a single particle of a soft body
    /// Note that at run-time you should only modify the inverse mass and/or velocity of a vertex to control the soft body.
    /// Modifying the position can lead to missed collisions.
    /// The other members are used internally by the soft body solver.
    /// Generated from class `JPH::SoftBodyVertex`.
    /// This is the const half of the class.
    public class Const_SoftBodyVertex : JPH.Object<Const_SoftBodyVertex>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyVertex_Destroy(_Underlying *_this);
            __JPH_SoftBodyVertex_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_SoftBodyVertex() {Dispose(false);}

        ///< Internal use only. Position at the previous time step
        public unsafe JPH.Const_Vec3 mPreviousPosition
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mPreviousPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mPreviousPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_SoftBodyVertex_Get_mPreviousPosition(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_SoftBodyVertex_Get_mPreviousPosition(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Position, relative to the center of mass of the soft body
        public unsafe JPH.Const_Vec3 mPosition
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_SoftBodyVertex_Get_mPosition(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_SoftBodyVertex_Get_mPosition(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Velocity, relative to the center of mass of the soft body
        public unsafe JPH.Const_Vec3 mVelocity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_SoftBodyVertex_Get_mVelocity(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_SoftBodyVertex_Get_mVelocity(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Internal use only. Nearest collision plane, relative to the center of mass of the soft body
        public unsafe JPH.Const_Plane mCollisionPlane
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mCollisionPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mCollisionPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Plane._Underlying *__JPH_SoftBodyVertex_Get_mCollisionPlane(_Underlying *_this);
                JPH.Const_Plane __ret;
                __ret = new(__JPH_SoftBodyVertex_Get_mCollisionPlane(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Internal use only. Index in the colliding shapes list of the body we may collide with
        public unsafe int mCollidingShapeIndex
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mCollidingShapeIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mCollidingShapeIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_SoftBodyVertex_Get_mCollidingShapeIndex(_Underlying *_this);
                return *__JPH_SoftBodyVertex_Get_mCollidingShapeIndex(_UnderlyingPtr);
            }
        }

        ///< True if the vertex has collided with anything in the last update
        public unsafe bool mHasContact
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mHasContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mHasContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_SoftBodyVertex_Get_mHasContact(_Underlying *_this);
                return *__JPH_SoftBodyVertex_Get_mHasContact(_UnderlyingPtr);
            }
        }

        ///< Internal use only. Used while finding the collision plane, stores the largest penetration found so far
        public unsafe float mLargestPenetration
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mLargestPenetration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mLargestPenetration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SoftBodyVertex_Get_mLargestPenetration(_Underlying *_this);
                return *__JPH_SoftBodyVertex_Get_mLargestPenetration(_UnderlyingPtr);
            }
        }

        ///< Inverse mass (1 / mass)
        public unsafe float mInvMass
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mInvMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_Get_mInvMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SoftBodyVertex_Get_mInvMass(_Underlying *_this);
                return *__JPH_SoftBodyVertex_Get_mInvMass(_UnderlyingPtr);
            }
        }

        internal unsafe Const_SoftBodyVertex(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_SoftBodyVertex() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyVertex._Underlying *__JPH_SoftBodyVertex_DefaultConstruct();
            _UnderlyingPtr = __JPH_SoftBodyVertex_DefaultConstruct();
        }

        /// Constructs `JPH::SoftBodyVertex` elementwise.
        public unsafe Const_SoftBodyVertex(JPH.Const_Vec3 mPreviousPosition, JPH.Const_Vec3 mPosition, JPH.Const_Vec3 mVelocity, JPH.Const_Plane mCollisionPlane, int mCollidingShapeIndex, bool mHasContact, float mLargestPenetration, float mInvMass) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyVertex._Underlying *__JPH_SoftBodyVertex_ConstructFrom(JPH.Vec3._Underlying *mPreviousPosition, JPH.Vec3._Underlying *mPosition, JPH.Vec3._Underlying *mVelocity, JPH.Plane._Underlying *mCollisionPlane, int mCollidingShapeIndex, byte mHasContact, float mLargestPenetration, float mInvMass);
            _UnderlyingPtr = __JPH_SoftBodyVertex_ConstructFrom(mPreviousPosition._UnderlyingPtr, mPosition._UnderlyingPtr, mVelocity._UnderlyingPtr, mCollisionPlane._UnderlyingPtr, mCollidingShapeIndex, mHasContact ? (byte)1 : (byte)0, mLargestPenetration, mInvMass);
            _KeepAlive(mPreviousPosition);
            _KeepAlive(mPosition);
            _KeepAlive(mVelocity);
            _KeepAlive(mCollisionPlane);
        }

        /// Generated from constructor `JPH::SoftBodyVertex::SoftBodyVertex`.
        public unsafe Const_SoftBodyVertex(JPH.Const_SoftBodyVertex _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyVertex._Underlying *__JPH_SoftBodyVertex_ConstructFromAnother(JPH.SoftBodyVertex._Underlying *_other);
            _UnderlyingPtr = __JPH_SoftBodyVertex_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::SoftBodyVertex::SoftBodyVertex`.
        public Const_SoftBodyVertex(SoftBodyVertex _other) : this((Const_SoftBodyVertex)_other) {}
    }

    /// Run time information for a single particle of a soft body
    /// Note that at run-time you should only modify the inverse mass and/or velocity of a vertex to control the soft body.
    /// Modifying the position can lead to missed collisions.
    /// The other members are used internally by the soft body solver.
    /// Generated from class `JPH::SoftBodyVertex`.
    /// This is the non-const half of the class.
    public class SoftBodyVertex : Const_SoftBodyVertex
    {
        ///< Internal use only. Position at the previous time step
        public new unsafe JPH.Vec3 mPreviousPosition
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mPreviousPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mPreviousPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_SoftBodyVertex_GetMutable_mPreviousPosition(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_SoftBodyVertex_GetMutable_mPreviousPosition(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Position, relative to the center of mass of the soft body
        public new unsafe JPH.Vec3 mPosition
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_SoftBodyVertex_GetMutable_mPosition(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_SoftBodyVertex_GetMutable_mPosition(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Velocity, relative to the center of mass of the soft body
        public new unsafe JPH.Vec3 mVelocity
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_SoftBodyVertex_GetMutable_mVelocity(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_SoftBodyVertex_GetMutable_mVelocity(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Internal use only. Nearest collision plane, relative to the center of mass of the soft body
        public new unsafe JPH.Plane mCollisionPlane
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mCollisionPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mCollisionPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Plane._Underlying *__JPH_SoftBodyVertex_GetMutable_mCollisionPlane(_Underlying *_this);
                JPH.Plane __ret;
                __ret = new(__JPH_SoftBodyVertex_GetMutable_mCollisionPlane(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Internal use only. Index in the colliding shapes list of the body we may collide with
        public new unsafe ref int mCollidingShapeIndex
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mCollidingShapeIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mCollidingShapeIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__JPH_SoftBodyVertex_GetMutable_mCollidingShapeIndex(_Underlying *_this);
                return ref *__JPH_SoftBodyVertex_GetMutable_mCollidingShapeIndex(_UnderlyingPtr);
            }
        }

        ///< True if the vertex has collided with anything in the last update
        public new unsafe ref bool mHasContact
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mHasContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mHasContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_SoftBodyVertex_GetMutable_mHasContact(_Underlying *_this);
                return ref *__JPH_SoftBodyVertex_GetMutable_mHasContact(_UnderlyingPtr);
            }
        }

        ///< Internal use only. Used while finding the collision plane, stores the largest penetration found so far
        public new unsafe ref float mLargestPenetration
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mLargestPenetration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mLargestPenetration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SoftBodyVertex_GetMutable_mLargestPenetration(_Underlying *_this);
                return ref *__JPH_SoftBodyVertex_GetMutable_mLargestPenetration(_UnderlyingPtr);
            }
        }

        ///< Inverse mass (1 / mass)
        public new unsafe ref float mInvMass
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mInvMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_GetMutable_mInvMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_SoftBodyVertex_GetMutable_mInvMass(_Underlying *_this);
                return ref *__JPH_SoftBodyVertex_GetMutable_mInvMass(_UnderlyingPtr);
            }
        }

        internal unsafe SoftBodyVertex(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe SoftBodyVertex() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyVertex._Underlying *__JPH_SoftBodyVertex_DefaultConstruct();
            _UnderlyingPtr = __JPH_SoftBodyVertex_DefaultConstruct();
        }

        /// Constructs `JPH::SoftBodyVertex` elementwise.
        public unsafe SoftBodyVertex(JPH.Const_Vec3 mPreviousPosition, JPH.Const_Vec3 mPosition, JPH.Const_Vec3 mVelocity, JPH.Const_Plane mCollisionPlane, int mCollidingShapeIndex, bool mHasContact, float mLargestPenetration, float mInvMass) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyVertex._Underlying *__JPH_SoftBodyVertex_ConstructFrom(JPH.Vec3._Underlying *mPreviousPosition, JPH.Vec3._Underlying *mPosition, JPH.Vec3._Underlying *mVelocity, JPH.Plane._Underlying *mCollisionPlane, int mCollidingShapeIndex, byte mHasContact, float mLargestPenetration, float mInvMass);
            _UnderlyingPtr = __JPH_SoftBodyVertex_ConstructFrom(mPreviousPosition._UnderlyingPtr, mPosition._UnderlyingPtr, mVelocity._UnderlyingPtr, mCollisionPlane._UnderlyingPtr, mCollidingShapeIndex, mHasContact ? (byte)1 : (byte)0, mLargestPenetration, mInvMass);
            _KeepAlive(mPreviousPosition);
            _KeepAlive(mPosition);
            _KeepAlive(mVelocity);
            _KeepAlive(mCollisionPlane);
        }

        /// Generated from constructor `JPH::SoftBodyVertex::SoftBodyVertex`.
        public unsafe SoftBodyVertex(JPH.Const_SoftBodyVertex _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyVertex._Underlying *__JPH_SoftBodyVertex_ConstructFromAnother(JPH.SoftBodyVertex._Underlying *_other);
            _UnderlyingPtr = __JPH_SoftBodyVertex_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::SoftBodyVertex::SoftBodyVertex`.
        public SoftBodyVertex(SoftBodyVertex _other) : this((Const_SoftBodyVertex)_other) {}

        /// Generated from method `JPH::SoftBodyVertex::operator=`.
        public unsafe JPH.SoftBodyVertex Assign(JPH.Const_SoftBodyVertex _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodyVertex._Underlying *__JPH_SoftBodyVertex_AssignFromAnother(_Underlying *_this, JPH.SoftBodyVertex._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_SoftBodyVertex_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Reset collision information to prepare for a new collision check
        /// Generated from method `JPH::SoftBodyVertex::ResetCollision`.
        public unsafe void ResetCollision()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyVertex_ResetCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyVertex_ResetCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_SoftBodyVertex_ResetCollision(_Underlying *_this);
            __JPH_SoftBodyVertex_ResetCollision(_UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `SoftBodyVertex` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_SoftBodyVertex`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SoftBodyVertex`/`Const_SoftBodyVertex` directly.
    public class _InOptMut_SoftBodyVertex
    {
        public SoftBodyVertex? Opt;

        public _InOptMut_SoftBodyVertex() {}
        public _InOptMut_SoftBodyVertex(SoftBodyVertex value) {Opt = value;}
        public static implicit operator _InOptMut_SoftBodyVertex(SoftBodyVertex value) {return new(value);}
    }

    /// This is used for optional parameters of class `SoftBodyVertex` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_SoftBodyVertex`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `SoftBodyVertex`/`Const_SoftBodyVertex` to pass it to the function.
    public class _InOptConst_SoftBodyVertex
    {
        public Const_SoftBodyVertex? Opt;

        public _InOptConst_SoftBodyVertex() {}
        public _InOptConst_SoftBodyVertex(Const_SoftBodyVertex value) {Opt = value;}
        public static implicit operator _InOptConst_SoftBodyVertex(Const_SoftBodyVertex value) {return new(value);}
    }
}
