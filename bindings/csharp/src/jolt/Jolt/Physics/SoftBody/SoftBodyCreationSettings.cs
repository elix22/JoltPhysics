// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// This class contains the information needed to create a soft body object
        /// Note: Soft bodies are still in development and come with several caveats. Read the Architecture and API documentation for more information!
        /// Generated from class `JPH::SoftBodyCreationSettings`.
        /// This is the const half of the class.
        public class Const_SoftBodyCreationSettings : Jolt.Object<Const_SoftBodyCreationSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_SoftBodyCreationSettings_Destroy(_Underlying *_this);
                __JPH_SoftBodyCreationSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_SoftBodyCreationSettings() {Dispose(false);}

            /// User data value (can be used by application)
            public unsafe ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_SoftBodyCreationSettings_Get_mUserData(_Underlying *_this);
                    return *__JPH_SoftBodyCreationSettings_Get_mUserData(_UnderlyingPtr);
                }
            }

            ///< The collision layer this body belongs to (determines if two objects can collide)
            public unsafe ushort mObjectLayer
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ushort *__JPH_SoftBodyCreationSettings_Get_mObjectLayer(_Underlying *_this);
                    return *__JPH_SoftBodyCreationSettings_Get_mObjectLayer(_UnderlyingPtr);
                }
            }

            ///< The collision group this body belongs to (determines if two objects can collide)
            public unsafe Jolt.JPH.Const_CollisionGroup mCollisionGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.Const_CollisionGroup._Underlying *__JPH_SoftBodyCreationSettings_Get_mCollisionGroup(_Underlying *_this);
                    Jolt.JPH.Const_CollisionGroup __ret;
                    __ret = new(__JPH_SoftBodyCreationSettings_Get_mCollisionGroup(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Number of solver iterations
            public unsafe uint mNumIterations
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mNumIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mNumIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_SoftBodyCreationSettings_Get_mNumIterations(_Underlying *_this);
                    return *__JPH_SoftBodyCreationSettings_Get_mNumIterations(_UnderlyingPtr);
                }
            }

            ///< Linear damping: dv/dt = -mLinearDamping * v. Value should be zero or positive and is usually close to 0.
            public unsafe float mLinearDamping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodyCreationSettings_Get_mLinearDamping(_Underlying *_this);
                    return *__JPH_SoftBodyCreationSettings_Get_mLinearDamping(_UnderlyingPtr);
                }
            }

            ///< Maximum linear velocity that a vertex can reach (m/s)
            public unsafe float mMaxLinearVelocity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodyCreationSettings_Get_mMaxLinearVelocity(_Underlying *_this);
                    return *__JPH_SoftBodyCreationSettings_Get_mMaxLinearVelocity(_UnderlyingPtr);
                }
            }

            ///< Restitution when colliding
            public unsafe float mRestitution
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodyCreationSettings_Get_mRestitution(_Underlying *_this);
                    return *__JPH_SoftBodyCreationSettings_Get_mRestitution(_UnderlyingPtr);
                }
            }

            ///< Friction coefficient when colliding
            public unsafe float mFriction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodyCreationSettings_Get_mFriction(_Underlying *_this);
                    return *__JPH_SoftBodyCreationSettings_Get_mFriction(_UnderlyingPtr);
                }
            }

            ///< n * R * T, amount of substance * ideal gas constant * absolute temperature, see https://en.wikipedia.org/wiki/Pressure
            public unsafe float mPressure
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mPressure", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mPressure", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodyCreationSettings_Get_mPressure(_Underlying *_this);
                    return *__JPH_SoftBodyCreationSettings_Get_mPressure(_UnderlyingPtr);
                }
            }

            ///< Value to multiply gravity with for this body
            public unsafe float mGravityFactor
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodyCreationSettings_Get_mGravityFactor(_Underlying *_this);
                    return *__JPH_SoftBodyCreationSettings_Get_mGravityFactor(_UnderlyingPtr);
                }
            }

            ///< How big the particles are, can be used to push the vertices a little bit away from the surface of other bodies to prevent z-fighting
            public unsafe float mVertexRadius
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mVertexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mVertexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodyCreationSettings_Get_mVertexRadius(_Underlying *_this);
                    return *__JPH_SoftBodyCreationSettings_Get_mVertexRadius(_UnderlyingPtr);
                }
            }

            ///< Update the position of the body while simulating (set to false for something that is attached to the static world)
            public unsafe bool mUpdatePosition
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mUpdatePosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mUpdatePosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_SoftBodyCreationSettings_Get_mUpdatePosition(_Underlying *_this);
                    return *__JPH_SoftBodyCreationSettings_Get_mUpdatePosition(_UnderlyingPtr);
                }
            }

            ///< Bake specified mRotation in the vertices and set the body rotation to identity (simulation is slightly more accurate if the rotation of a soft body is kept to identity)
            public unsafe bool mMakeRotationIdentity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mMakeRotationIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mMakeRotationIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_SoftBodyCreationSettings_Get_mMakeRotationIdentity(_Underlying *_this);
                    return *__JPH_SoftBodyCreationSettings_Get_mMakeRotationIdentity(_UnderlyingPtr);
                }
            }

            ///< If this body can go to sleep or not
            public unsafe bool mAllowSleeping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_SoftBodyCreationSettings_Get_mAllowSleeping(_Underlying *_this);
                    return *__JPH_SoftBodyCreationSettings_Get_mAllowSleeping(_UnderlyingPtr);
                }
            }

            ///< If the faces in this soft body should be treated as double sided for the purpose of collision detection (ray cast / collide shape / cast shape)
            public unsafe bool mFacesDoubleSided
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mFacesDoubleSided", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_Get_mFacesDoubleSided", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_SoftBodyCreationSettings_Get_mFacesDoubleSided(_Underlying *_this);
                    return *__JPH_SoftBodyCreationSettings_Get_mFacesDoubleSided(_UnderlyingPtr);
                }
            }

            internal unsafe Const_SoftBodyCreationSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_SoftBodyCreationSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SoftBodyCreationSettings._Underlying *__JPH_SoftBodyCreationSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodyCreationSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodyCreationSettings::SoftBodyCreationSettings`.
            public unsafe Const_SoftBodyCreationSettings(Jolt.JPH._ByValue_SoftBodyCreationSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SoftBodyCreationSettings._Underlying *__JPH_SoftBodyCreationSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.SoftBodyCreationSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodyCreationSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::SoftBodyCreationSettings::SoftBodyCreationSettings`.
            public Const_SoftBodyCreationSettings(Const_SoftBodyCreationSettings _other) : this(new _ByValue_SoftBodyCreationSettings(_other)) {}

            /// Generated from constructor `JPH::SoftBodyCreationSettings::SoftBodyCreationSettings`.
            public Const_SoftBodyCreationSettings(SoftBodyCreationSettings _other) : this((Const_SoftBodyCreationSettings)_other) {}

            /// Generated from method `JPH::SoftBodyCreationSettings::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodyCreationSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodyCreationSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodyCreationSettings_size_t(ulong inCount);
                return __Jolt_new_JPH_SoftBodyCreationSettings_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodyCreationSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr(void *inPointer);
                __Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodyCreationSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodyCreationSettings::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodyCreationSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodyCreationSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodyCreationSettings_size_t(ulong inCount);
                return __Jolt_new_array_JPH_SoftBodyCreationSettings_size_t(inCount);
            }

            /// Generated from method `JPH::SoftBodyCreationSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::SoftBodyCreationSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::SoftBodyCreationSettings::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_SoftBodyCreationSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_SoftBodyCreationSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_SoftBodyCreationSettings_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_SoftBodyCreationSettings_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodyCreationSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_SoftBodyCreationSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::SoftBodyCreationSettings::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodyCreationSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_SoftBodyCreationSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_SoftBodyCreationSettings_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_SoftBodyCreationSettings_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::SoftBodyCreationSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_SoftBodyCreationSettings_void_ptr_void_ptr(inPointer, inPlace);
            }
        }

        /// This class contains the information needed to create a soft body object
        /// Note: Soft bodies are still in development and come with several caveats. Read the Architecture and API documentation for more information!
        /// Generated from class `JPH::SoftBodyCreationSettings`.
        /// This is the non-const half of the class.
        public class SoftBodyCreationSettings : Const_SoftBodyCreationSettings
        {
            /// User data value (can be used by application)
            public new unsafe ref ulong mUserData
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong *__JPH_SoftBodyCreationSettings_GetMutable_mUserData(_Underlying *_this);
                    return ref *__JPH_SoftBodyCreationSettings_GetMutable_mUserData(_UnderlyingPtr);
                }
            }

            ///< The collision layer this body belongs to (determines if two objects can collide)
            public new unsafe ref ushort mObjectLayer
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ushort *__JPH_SoftBodyCreationSettings_GetMutable_mObjectLayer(_Underlying *_this);
                    return ref *__JPH_SoftBodyCreationSettings_GetMutable_mObjectLayer(_UnderlyingPtr);
                }
            }

            ///< The collision group this body belongs to (determines if two objects can collide)
            public new unsafe Jolt.JPH.CollisionGroup mCollisionGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CollisionGroup._Underlying *__JPH_SoftBodyCreationSettings_GetMutable_mCollisionGroup(_Underlying *_this);
                    Jolt.JPH.CollisionGroup __ret;
                    __ret = new(__JPH_SoftBodyCreationSettings_GetMutable_mCollisionGroup(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Number of solver iterations
            public new unsafe ref uint mNumIterations
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mNumIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mNumIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_SoftBodyCreationSettings_GetMutable_mNumIterations(_Underlying *_this);
                    return ref *__JPH_SoftBodyCreationSettings_GetMutable_mNumIterations(_UnderlyingPtr);
                }
            }

            ///< Linear damping: dv/dt = -mLinearDamping * v. Value should be zero or positive and is usually close to 0.
            public new unsafe ref float mLinearDamping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodyCreationSettings_GetMutable_mLinearDamping(_Underlying *_this);
                    return ref *__JPH_SoftBodyCreationSettings_GetMutable_mLinearDamping(_UnderlyingPtr);
                }
            }

            ///< Maximum linear velocity that a vertex can reach (m/s)
            public new unsafe ref float mMaxLinearVelocity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodyCreationSettings_GetMutable_mMaxLinearVelocity(_Underlying *_this);
                    return ref *__JPH_SoftBodyCreationSettings_GetMutable_mMaxLinearVelocity(_UnderlyingPtr);
                }
            }

            ///< Restitution when colliding
            public new unsafe ref float mRestitution
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodyCreationSettings_GetMutable_mRestitution(_Underlying *_this);
                    return ref *__JPH_SoftBodyCreationSettings_GetMutable_mRestitution(_UnderlyingPtr);
                }
            }

            ///< Friction coefficient when colliding
            public new unsafe ref float mFriction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodyCreationSettings_GetMutable_mFriction(_Underlying *_this);
                    return ref *__JPH_SoftBodyCreationSettings_GetMutable_mFriction(_UnderlyingPtr);
                }
            }

            ///< n * R * T, amount of substance * ideal gas constant * absolute temperature, see https://en.wikipedia.org/wiki/Pressure
            public new unsafe ref float mPressure
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mPressure", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mPressure", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodyCreationSettings_GetMutable_mPressure(_Underlying *_this);
                    return ref *__JPH_SoftBodyCreationSettings_GetMutable_mPressure(_UnderlyingPtr);
                }
            }

            ///< Value to multiply gravity with for this body
            public new unsafe ref float mGravityFactor
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodyCreationSettings_GetMutable_mGravityFactor(_Underlying *_this);
                    return ref *__JPH_SoftBodyCreationSettings_GetMutable_mGravityFactor(_UnderlyingPtr);
                }
            }

            ///< How big the particles are, can be used to push the vertices a little bit away from the surface of other bodies to prevent z-fighting
            public new unsafe ref float mVertexRadius
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mVertexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mVertexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_SoftBodyCreationSettings_GetMutable_mVertexRadius(_Underlying *_this);
                    return ref *__JPH_SoftBodyCreationSettings_GetMutable_mVertexRadius(_UnderlyingPtr);
                }
            }

            ///< Update the position of the body while simulating (set to false for something that is attached to the static world)
            public new unsafe ref bool mUpdatePosition
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mUpdatePosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mUpdatePosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_SoftBodyCreationSettings_GetMutable_mUpdatePosition(_Underlying *_this);
                    return ref *__JPH_SoftBodyCreationSettings_GetMutable_mUpdatePosition(_UnderlyingPtr);
                }
            }

            ///< Bake specified mRotation in the vertices and set the body rotation to identity (simulation is slightly more accurate if the rotation of a soft body is kept to identity)
            public new unsafe ref bool mMakeRotationIdentity
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mMakeRotationIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mMakeRotationIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_SoftBodyCreationSettings_GetMutable_mMakeRotationIdentity(_Underlying *_this);
                    return ref *__JPH_SoftBodyCreationSettings_GetMutable_mMakeRotationIdentity(_UnderlyingPtr);
                }
            }

            ///< If this body can go to sleep or not
            public new unsafe ref bool mAllowSleeping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_SoftBodyCreationSettings_GetMutable_mAllowSleeping(_Underlying *_this);
                    return ref *__JPH_SoftBodyCreationSettings_GetMutable_mAllowSleeping(_UnderlyingPtr);
                }
            }

            ///< If the faces in this soft body should be treated as double sided for the purpose of collision detection (ray cast / collide shape / cast shape)
            public new unsafe ref bool mFacesDoubleSided
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mFacesDoubleSided", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_GetMutable_mFacesDoubleSided", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_SoftBodyCreationSettings_GetMutable_mFacesDoubleSided(_Underlying *_this);
                    return ref *__JPH_SoftBodyCreationSettings_GetMutable_mFacesDoubleSided(_UnderlyingPtr);
                }
            }

            internal unsafe SoftBodyCreationSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe SoftBodyCreationSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SoftBodyCreationSettings._Underlying *__JPH_SoftBodyCreationSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_SoftBodyCreationSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::SoftBodyCreationSettings::SoftBodyCreationSettings`.
            public unsafe SoftBodyCreationSettings(Jolt.JPH._ByValue_SoftBodyCreationSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SoftBodyCreationSettings._Underlying *__JPH_SoftBodyCreationSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.SoftBodyCreationSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_SoftBodyCreationSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::SoftBodyCreationSettings::SoftBodyCreationSettings`.
            public SoftBodyCreationSettings(Const_SoftBodyCreationSettings _other) : this(new _ByValue_SoftBodyCreationSettings(_other)) {}

            /// Generated from constructor `JPH::SoftBodyCreationSettings::SoftBodyCreationSettings`.
            public SoftBodyCreationSettings(SoftBodyCreationSettings _other) : this((Const_SoftBodyCreationSettings)_other) {}

            /// Generated from method `JPH::SoftBodyCreationSettings::operator=`.
            public unsafe Jolt.JPH.SoftBodyCreationSettings Assign(Jolt.JPH._ByValue_SoftBodyCreationSettings _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_SoftBodyCreationSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SoftBodyCreationSettings._Underlying *__JPH_SoftBodyCreationSettings_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JPH.SoftBodyCreationSettings._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_SoftBodyCreationSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }
        }

        /// This is used as a function parameter when the underlying function receives `SoftBodyCreationSettings` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `SoftBodyCreationSettings`/`Const_SoftBodyCreationSettings` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_SoftBodyCreationSettings
        {
            #pragma warning disable CS0649
            internal readonly Const_SoftBodyCreationSettings? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_SoftBodyCreationSettings() {PassByMode = Jolt._PassBy.default_construct;}
            public _ByValue_SoftBodyCreationSettings(Const_SoftBodyCreationSettings new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
            public static implicit operator _ByValue_SoftBodyCreationSettings(Const_SoftBodyCreationSettings arg) {return new(arg);}
            public _ByValue_SoftBodyCreationSettings(Jolt._Moved<SoftBodyCreationSettings> moved) {Value = moved.Value; PassByMode = Jolt._PassBy.move;}
            public static implicit operator _ByValue_SoftBodyCreationSettings(Jolt._Moved<SoftBodyCreationSettings> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `SoftBodyCreationSettings` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_SoftBodyCreationSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `SoftBodyCreationSettings`/`Const_SoftBodyCreationSettings` directly.
        public class _InOptMut_SoftBodyCreationSettings
        {
            public SoftBodyCreationSettings? Opt;

            public _InOptMut_SoftBodyCreationSettings() {}
            public _InOptMut_SoftBodyCreationSettings(SoftBodyCreationSettings value) {Opt = value;}
            public static implicit operator _InOptMut_SoftBodyCreationSettings(SoftBodyCreationSettings value) {return new(value);}
        }

        /// This is used for optional parameters of class `SoftBodyCreationSettings` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_SoftBodyCreationSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `SoftBodyCreationSettings`/`Const_SoftBodyCreationSettings` to pass it to the function.
        public class _InOptConst_SoftBodyCreationSettings
        {
            public Const_SoftBodyCreationSettings? Opt;

            public _InOptConst_SoftBodyCreationSettings() {}
            public _InOptConst_SoftBodyCreationSettings(Const_SoftBodyCreationSettings value) {Opt = value;}
            public static implicit operator _InOptConst_SoftBodyCreationSettings(Const_SoftBodyCreationSettings value) {return new(value);}
        }
    }
}
