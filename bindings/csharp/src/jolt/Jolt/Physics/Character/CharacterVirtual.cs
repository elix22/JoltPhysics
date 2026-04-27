// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Contains the configuration of a character
        /// Generated from class `JPH::CharacterVirtualSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::CharacterBaseSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::CharacterBaseSettings>`
        /// This is the const half of the class.
        public class Const_CharacterVirtualSettings : Jolt.Object<Const_CharacterVirtualSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtualSettings_Destroy(_Underlying *_this);
                __JPH_CharacterVirtualSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_CharacterVirtualSettings() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHCharacterBaseSettings(Const_CharacterVirtualSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHCharacterBaseSettings._Underlying *__JPH_CharacterVirtualSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHCharacterBaseSettings ret = new(__JPH_CharacterVirtualSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_CharacterBaseSettings(Const_CharacterVirtualSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_UpcastTo_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_UpcastTo_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_CharacterBaseSettings._Underlying *__JPH_CharacterVirtualSettings_UpcastTo_JPH_CharacterBaseSettings(_Underlying *_this);
                Jolt.JPH.Const_CharacterBaseSettings ret = new(__JPH_CharacterVirtualSettings_UpcastTo_JPH_CharacterBaseSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_CharacterVirtualSettings?(Jolt.JPH.Const_CharacterBaseSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_DynamicDowncastFrom_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_DynamicDowncastFrom_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_CharacterVirtualSettings_DynamicDowncastFrom_JPH_CharacterBaseSettings(Jolt.JPH.Const_CharacterBaseSettings._Underlying *_this);
                var ptr = __JPH_CharacterVirtualSettings_DynamicDowncastFrom_JPH_CharacterBaseSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_CharacterVirtualSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// ID to give to this character. This is used for deterministically sorting and as an identifier to represent the character in the contact removal callback.
            public unsafe Jolt.JPH.Const_CharacterID mid
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.Const_CharacterID._Underlying *__JPH_CharacterVirtualSettings_Get_mID(_Underlying *_this);
                    Jolt.JPH.Const_CharacterID __ret;
                    __ret = new(__JPH_CharacterVirtualSettings_Get_mID(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            /// Character mass (kg). Used to push down objects with gravity when the character is standing on top.
            public unsafe float mMass
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_Get_mMass(_Underlying *_this);
                    return *__JPH_CharacterVirtualSettings_Get_mMass(_UnderlyingPtr);
                }
            }

            /// Maximum force with which the character can push other bodies (N).
            public unsafe float mMaxStrength
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mMaxStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mMaxStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_Get_mMaxStrength(_Underlying *_this);
                    return *__JPH_CharacterVirtualSettings_Get_mMaxStrength(_UnderlyingPtr);
                }
            }

            ///< How far to scan outside of the shape for predictive contacts. A value of 0 will most likely cause the character to get stuck as it cannot properly calculate a sliding direction anymore. A value that's too high will cause ghost collisions.
            public unsafe float mPredictiveContactDistance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mPredictiveContactDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mPredictiveContactDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_Get_mPredictiveContactDistance(_Underlying *_this);
                    return *__JPH_CharacterVirtualSettings_Get_mPredictiveContactDistance(_UnderlyingPtr);
                }
            }

            ///< Max amount of collision loops
            public unsafe uint mMaxCollisionIterations
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mMaxCollisionIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mMaxCollisionIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_CharacterVirtualSettings_Get_mMaxCollisionIterations(_Underlying *_this);
                    return *__JPH_CharacterVirtualSettings_Get_mMaxCollisionIterations(_UnderlyingPtr);
                }
            }

            ///< How often to try stepping in the constraint solving
            public unsafe uint mMaxConstraintIterations
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mMaxConstraintIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mMaxConstraintIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_CharacterVirtualSettings_Get_mMaxConstraintIterations(_Underlying *_this);
                    return *__JPH_CharacterVirtualSettings_Get_mMaxConstraintIterations(_UnderlyingPtr);
                }
            }

            ///< Early out condition: If this much time is left to simulate we are done
            public unsafe float mMinTimeRemaining
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mMinTimeRemaining", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mMinTimeRemaining", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_Get_mMinTimeRemaining(_Underlying *_this);
                    return *__JPH_CharacterVirtualSettings_Get_mMinTimeRemaining(_UnderlyingPtr);
                }
            }

            ///< How far we're willing to penetrate geometry
            public unsafe float mCollisionTolerance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_Get_mCollisionTolerance(_Underlying *_this);
                    return *__JPH_CharacterVirtualSettings_Get_mCollisionTolerance(_UnderlyingPtr);
                }
            }

            ///< How far we try to stay away from the geometry, this ensures that the sweep will hit as little as possible lowering the collision cost and reducing the risk of getting stuck
            public unsafe float mCharacterPadding
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mCharacterPadding", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mCharacterPadding", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_Get_mCharacterPadding(_Underlying *_this);
                    return *__JPH_CharacterVirtualSettings_Get_mCharacterPadding(_UnderlyingPtr);
                }
            }

            ///< Max num hits to collect in order to avoid excess of contact points collection
            public unsafe uint mMaxNumHits
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mMaxNumHits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mMaxNumHits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_CharacterVirtualSettings_Get_mMaxNumHits(_Underlying *_this);
                    return *__JPH_CharacterVirtualSettings_Get_mMaxNumHits(_UnderlyingPtr);
                }
            }

            ///< Cos(angle) where angle is the maximum angle between two hits contact normals that are allowed to be merged during hit reduction. Default is around 2.5 degrees. Set to -1 to turn off.
            public unsafe float mHitReductionCosMaxAngle
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mHitReductionCosMaxAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mHitReductionCosMaxAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_Get_mHitReductionCosMaxAngle(_Underlying *_this);
                    return *__JPH_CharacterVirtualSettings_Get_mHitReductionCosMaxAngle(_UnderlyingPtr);
                }
            }

            ///< This value governs how fast a penetration will be resolved, 0 = nothing is resolved, 1 = everything in one update
            public unsafe float mPenetrationRecoverySpeed
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mPenetrationRecoverySpeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mPenetrationRecoverySpeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_Get_mPenetrationRecoverySpeed(_Underlying *_this);
                    return *__JPH_CharacterVirtualSettings_Get_mPenetrationRecoverySpeed(_UnderlyingPtr);
                }
            }

            /// For a deterministic simulation, it is important to have a deterministic body ID. When set and when mInnerBodyShape is specified,
            /// the inner body will be created with this specified ID instead of a generated ID.
            public unsafe ref readonly Jolt.JPH.BodyID mInnerBodyIDOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mInnerBodyIDOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mInnerBodyIDOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.BodyID *__JPH_CharacterVirtualSettings_Get_mInnerBodyIDOverride(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_Get_mInnerBodyIDOverride(_UnderlyingPtr);
                }
            }

            /// Layer that the inner rigid body will be added to
            public unsafe ushort mInnerBodyLayer
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mInnerBodyLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mInnerBodyLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ushort *__JPH_CharacterVirtualSettings_Get_mInnerBodyLayer(_Underlying *_this);
                    return *__JPH_CharacterVirtualSettings_Get_mInnerBodyLayer(_UnderlyingPtr);
                }
            }

            /// Maximum angle of slope that character can still walk on (radians).
            public unsafe float mMaxSlopeAngle
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_Get_mMaxSlopeAngle(_Underlying *_this);
                    return *__JPH_CharacterVirtualSettings_Get_mMaxSlopeAngle(_UnderlyingPtr);
                }
            }

            /// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
            public unsafe bool mEnhancedInternalEdgeRemoval
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Get_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_CharacterVirtualSettings_Get_mEnhancedInternalEdgeRemoval(_Underlying *_this);
                    return *__JPH_CharacterVirtualSettings_Get_mEnhancedInternalEdgeRemoval(_UnderlyingPtr);
                }
            }

            internal unsafe Const_CharacterVirtualSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_CharacterVirtualSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterVirtualSettings._Underlying *__JPH_CharacterVirtualSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_CharacterVirtualSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::CharacterVirtualSettings::CharacterVirtualSettings`.
            public unsafe Const_CharacterVirtualSettings(Jolt.JPH._ByValue_CharacterVirtualSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterVirtualSettings._Underlying *__JPH_CharacterVirtualSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.CharacterVirtualSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_CharacterVirtualSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::CharacterVirtualSettings::CharacterVirtualSettings`.
            public Const_CharacterVirtualSettings(Const_CharacterVirtualSettings _other) : this(new _ByValue_CharacterVirtualSettings(_other)) {}

            /// Generated from constructor `JPH::CharacterVirtualSettings::CharacterVirtualSettings`.
            public Const_CharacterVirtualSettings(CharacterVirtualSettings _other) : this((Const_CharacterVirtualSettings)_other) {}

            /// Generated from method `JPH::CharacterVirtualSettings::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CharacterVirtualSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CharacterVirtualSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_CharacterVirtualSettings_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_CharacterVirtualSettings_unsigned_long(inCount);
            }

            /// Generated from method `JPH::CharacterVirtualSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterVirtualSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterVirtualSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CharacterVirtualSettings_void_ptr(void *inPointer);
                __Jolt_delete_JPH_CharacterVirtualSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::CharacterVirtualSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterVirtualSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterVirtualSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CharacterVirtualSettings_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_CharacterVirtualSettings_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::CharacterVirtualSettings::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterVirtualSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterVirtualSettings_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_CharacterVirtualSettings_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_CharacterVirtualSettings_unsigned_long(inCount);
            }

            /// Generated from method `JPH::CharacterVirtualSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr(inPointer);
            }

            /// Generated from method `JPH::CharacterVirtualSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::CharacterVirtualSettings::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CharacterVirtualSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CharacterVirtualSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_CharacterVirtualSettings_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_CharacterVirtualSettings_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::CharacterVirtualSettings::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterVirtualSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterVirtualSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CharacterVirtualSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_CharacterVirtualSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::CharacterVirtualSettings::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterVirtualSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterVirtualSettings_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_CharacterVirtualSettings_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_CharacterVirtualSettings_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::CharacterVirtualSettings::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_CharacterVirtualSettings_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::CharacterVirtualSettings::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtualSettings_SetEmbedded(_Underlying *_this);
                __JPH_CharacterVirtualSettings_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::CharacterVirtualSettings::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_CharacterVirtualSettings_GetRefCount(_Underlying *_this);
                return __JPH_CharacterVirtualSettings_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::CharacterVirtualSettings::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtualSettings_AddRef(_Underlying *_this);
                __JPH_CharacterVirtualSettings_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::CharacterVirtualSettings::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtualSettings_Release(_Underlying *_this);
                __JPH_CharacterVirtualSettings_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::CharacterVirtualSettings::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_CharacterVirtualSettings_sInternalGetRefCountOffset();
                return __JPH_CharacterVirtualSettings_sInternalGetRefCountOffset();
            }
        }

        /// Contains the configuration of a character
        /// Generated from class `JPH::CharacterVirtualSettings`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::CharacterBaseSettings`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::CharacterBaseSettings>`
        /// This is the non-const half of the class.
        public class CharacterVirtualSettings : Const_CharacterVirtualSettings
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHCharacterBaseSettings(CharacterVirtualSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHCharacterBaseSettings._Underlying *__JPH_CharacterVirtualSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHCharacterBaseSettings ret = new(__JPH_CharacterVirtualSettings_UpcastTo_JPH_RefTarget_JPH_CharacterBaseSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.CharacterBaseSettings(CharacterVirtualSettings self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_UpcastTo_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_UpcastTo_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterBaseSettings._Underlying *__JPH_CharacterVirtualSettings_UpcastTo_JPH_CharacterBaseSettings(_Underlying *_this);
                Jolt.JPH.CharacterBaseSettings ret = new(__JPH_CharacterVirtualSettings_UpcastTo_JPH_CharacterBaseSettings(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator CharacterVirtualSettings?(Jolt.JPH.CharacterBaseSettings parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_DynamicDowncastFrom_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_DynamicDowncastFrom_JPH_CharacterBaseSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_CharacterVirtualSettings_DynamicDowncastFrom_JPH_CharacterBaseSettings(Jolt.JPH.CharacterBaseSettings._Underlying *_this);
                var ptr = __JPH_CharacterVirtualSettings_DynamicDowncastFrom_JPH_CharacterBaseSettings(parent._UnderlyingPtr);
                if (ptr is null) return null;
                CharacterVirtualSettings ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            /// ID to give to this character. This is used for deterministically sorting and as an identifier to represent the character in the contact removal callback.
            public new unsafe Jolt.JPH.CharacterID mid
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterID._Underlying *__JPH_CharacterVirtualSettings_GetMutable_mID(_Underlying *_this);
                    Jolt.JPH.CharacterID __ret;
                    __ret = new(__JPH_CharacterVirtualSettings_GetMutable_mID(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            /// Character mass (kg). Used to push down objects with gravity when the character is standing on top.
            public new unsafe ref float mMass
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_GetMutable_mMass(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mMass(_UnderlyingPtr);
                }
            }

            /// Maximum force with which the character can push other bodies (N).
            public new unsafe ref float mMaxStrength
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mMaxStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mMaxStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_GetMutable_mMaxStrength(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mMaxStrength(_UnderlyingPtr);
                }
            }

            ///< How far to scan outside of the shape for predictive contacts. A value of 0 will most likely cause the character to get stuck as it cannot properly calculate a sliding direction anymore. A value that's too high will cause ghost collisions.
            public new unsafe ref float mPredictiveContactDistance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mPredictiveContactDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mPredictiveContactDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_GetMutable_mPredictiveContactDistance(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mPredictiveContactDistance(_UnderlyingPtr);
                }
            }

            ///< Max amount of collision loops
            public new unsafe ref uint mMaxCollisionIterations
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mMaxCollisionIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mMaxCollisionIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_CharacterVirtualSettings_GetMutable_mMaxCollisionIterations(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mMaxCollisionIterations(_UnderlyingPtr);
                }
            }

            ///< How often to try stepping in the constraint solving
            public new unsafe ref uint mMaxConstraintIterations
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mMaxConstraintIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mMaxConstraintIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_CharacterVirtualSettings_GetMutable_mMaxConstraintIterations(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mMaxConstraintIterations(_UnderlyingPtr);
                }
            }

            ///< Early out condition: If this much time is left to simulate we are done
            public new unsafe ref float mMinTimeRemaining
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mMinTimeRemaining", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mMinTimeRemaining", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_GetMutable_mMinTimeRemaining(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mMinTimeRemaining(_UnderlyingPtr);
                }
            }

            ///< How far we're willing to penetrate geometry
            public new unsafe ref float mCollisionTolerance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_GetMutable_mCollisionTolerance(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mCollisionTolerance(_UnderlyingPtr);
                }
            }

            ///< How far we try to stay away from the geometry, this ensures that the sweep will hit as little as possible lowering the collision cost and reducing the risk of getting stuck
            public new unsafe ref float mCharacterPadding
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mCharacterPadding", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mCharacterPadding", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_GetMutable_mCharacterPadding(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mCharacterPadding(_UnderlyingPtr);
                }
            }

            ///< Max num hits to collect in order to avoid excess of contact points collection
            public new unsafe ref uint mMaxNumHits
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mMaxNumHits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mMaxNumHits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_CharacterVirtualSettings_GetMutable_mMaxNumHits(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mMaxNumHits(_UnderlyingPtr);
                }
            }

            ///< Cos(angle) where angle is the maximum angle between two hits contact normals that are allowed to be merged during hit reduction. Default is around 2.5 degrees. Set to -1 to turn off.
            public new unsafe ref float mHitReductionCosMaxAngle
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mHitReductionCosMaxAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mHitReductionCosMaxAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_GetMutable_mHitReductionCosMaxAngle(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mHitReductionCosMaxAngle(_UnderlyingPtr);
                }
            }

            ///< This value governs how fast a penetration will be resolved, 0 = nothing is resolved, 1 = everything in one update
            public new unsafe ref float mPenetrationRecoverySpeed
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mPenetrationRecoverySpeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mPenetrationRecoverySpeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_GetMutable_mPenetrationRecoverySpeed(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mPenetrationRecoverySpeed(_UnderlyingPtr);
                }
            }

            /// For a deterministic simulation, it is important to have a deterministic body ID. When set and when mInnerBodyShape is specified,
            /// the inner body will be created with this specified ID instead of a generated ID.
            public new unsafe ref Jolt.JPH.BodyID mInnerBodyIDOverride
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mInnerBodyIDOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mInnerBodyIDOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.BodyID *__JPH_CharacterVirtualSettings_GetMutable_mInnerBodyIDOverride(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mInnerBodyIDOverride(_UnderlyingPtr);
                }
            }

            /// Layer that the inner rigid body will be added to
            public new unsafe ref ushort mInnerBodyLayer
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mInnerBodyLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mInnerBodyLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ushort *__JPH_CharacterVirtualSettings_GetMutable_mInnerBodyLayer(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mInnerBodyLayer(_UnderlyingPtr);
                }
            }

            /// Maximum angle of slope that character can still walk on (radians).
            public new unsafe ref float mMaxSlopeAngle
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_CharacterVirtualSettings_GetMutable_mMaxSlopeAngle(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mMaxSlopeAngle(_UnderlyingPtr);
                }
            }

            /// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
            public new unsafe ref bool mEnhancedInternalEdgeRemoval
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_GetMutable_mEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_CharacterVirtualSettings_GetMutable_mEnhancedInternalEdgeRemoval(_Underlying *_this);
                    return ref *__JPH_CharacterVirtualSettings_GetMutable_mEnhancedInternalEdgeRemoval(_UnderlyingPtr);
                }
            }

            internal unsafe CharacterVirtualSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe CharacterVirtualSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterVirtualSettings._Underlying *__JPH_CharacterVirtualSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_CharacterVirtualSettings_DefaultConstruct();
            }

            /// Generated from constructor `JPH::CharacterVirtualSettings::CharacterVirtualSettings`.
            public unsafe CharacterVirtualSettings(Jolt.JPH._ByValue_CharacterVirtualSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterVirtualSettings._Underlying *__JPH_CharacterVirtualSettings_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.CharacterVirtualSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_CharacterVirtualSettings_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::CharacterVirtualSettings::CharacterVirtualSettings`.
            public CharacterVirtualSettings(Const_CharacterVirtualSettings _other) : this(new _ByValue_CharacterVirtualSettings(_other)) {}

            /// Generated from constructor `JPH::CharacterVirtualSettings::CharacterVirtualSettings`.
            public CharacterVirtualSettings(CharacterVirtualSettings _other) : this((Const_CharacterVirtualSettings)_other) {}

            /// Generated from method `JPH::CharacterVirtualSettings::operator=`.
            public unsafe Jolt.JPH.CharacterVirtualSettings Assign(Jolt.JPH._ByValue_CharacterVirtualSettings _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtualSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtualSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterVirtualSettings._Underlying *__JPH_CharacterVirtualSettings_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JPH.CharacterVirtualSettings._Underlying *_other);
                Jolt.JPH.CharacterVirtualSettings __ret;
                __ret = new(__JPH_CharacterVirtualSettings_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                __ret._KeepAlive(this);
                return __ret;
            }
        }

        /// This is used as a function parameter when the underlying function receives `CharacterVirtualSettings` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `CharacterVirtualSettings`/`Const_CharacterVirtualSettings` to copy it into the function.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_CharacterVirtualSettings
        {
            #pragma warning disable CS0649
            internal readonly Const_CharacterVirtualSettings? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_CharacterVirtualSettings() {PassByMode = Jolt._PassBy.default_construct;}
            public _ByValue_CharacterVirtualSettings(Const_CharacterVirtualSettings new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
            public static implicit operator _ByValue_CharacterVirtualSettings(Const_CharacterVirtualSettings arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `CharacterVirtualSettings` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_CharacterVirtualSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterVirtualSettings`/`Const_CharacterVirtualSettings` directly.
        public class _InOptMut_CharacterVirtualSettings
        {
            public CharacterVirtualSettings? Opt;

            public _InOptMut_CharacterVirtualSettings() {}
            public _InOptMut_CharacterVirtualSettings(CharacterVirtualSettings value) {Opt = value;}
            public static implicit operator _InOptMut_CharacterVirtualSettings(CharacterVirtualSettings value) {return new(value);}
        }

        /// This is used for optional parameters of class `CharacterVirtualSettings` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_CharacterVirtualSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterVirtualSettings`/`Const_CharacterVirtualSettings` to pass it to the function.
        public class _InOptConst_CharacterVirtualSettings
        {
            public Const_CharacterVirtualSettings? Opt;

            public _InOptConst_CharacterVirtualSettings() {}
            public _InOptConst_CharacterVirtualSettings(Const_CharacterVirtualSettings value) {Opt = value;}
            public static implicit operator _InOptConst_CharacterVirtualSettings(Const_CharacterVirtualSettings value) {return new(value);}
        }

        /// This class contains settings that allow you to override the behavior of a character's collision response
        /// Generated from class `JPH::CharacterContactSettings`.
        /// This is the const half of the class.
        public class Const_CharacterContactSettings : Jolt.Object<Const_CharacterContactSettings>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterContactSettings_Destroy(_Underlying *_this);
                __JPH_CharacterContactSettings_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_CharacterContactSettings() {Dispose(false);}

            /// True when the object can push the virtual character.
            public unsafe bool mCanPushCharacter
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactSettings_Get_mCanPushCharacter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactSettings_Get_mCanPushCharacter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_CharacterContactSettings_Get_mCanPushCharacter(_Underlying *_this);
                    return *__JPH_CharacterContactSettings_Get_mCanPushCharacter(_UnderlyingPtr);
                }
            }

            /// True when the virtual character can apply impulses (push) the body.
            /// Note that this only works against rigid bodies. Other CharacterVirtual objects can only be moved in their own update,
            /// so you must ensure that in their OnCharacterContactAdded mCanPushCharacter is true.
            public unsafe bool mCanReceiveImpulses
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactSettings_Get_mCanReceiveImpulses", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactSettings_Get_mCanReceiveImpulses", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_CharacterContactSettings_Get_mCanReceiveImpulses(_Underlying *_this);
                    return *__JPH_CharacterContactSettings_Get_mCanReceiveImpulses(_UnderlyingPtr);
                }
            }

            internal unsafe Const_CharacterContactSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_CharacterContactSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterContactSettings._Underlying *__JPH_CharacterContactSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_CharacterContactSettings_DefaultConstruct();
            }

            /// Constructs `JPH::CharacterContactSettings` elementwise.
            public unsafe Const_CharacterContactSettings(bool mCanPushCharacter, bool mCanReceiveImpulses) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterContactSettings._Underlying *__JPH_CharacterContactSettings_ConstructFrom(byte mCanPushCharacter, byte mCanReceiveImpulses);
                _UnderlyingPtr = __JPH_CharacterContactSettings_ConstructFrom(mCanPushCharacter ? (byte)1 : (byte)0, mCanReceiveImpulses ? (byte)1 : (byte)0);
            }

            /// Generated from constructor `JPH::CharacterContactSettings::CharacterContactSettings`.
            public unsafe Const_CharacterContactSettings(Jolt.JPH.Const_CharacterContactSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterContactSettings._Underlying *__JPH_CharacterContactSettings_ConstructFromAnother(Jolt.JPH.CharacterContactSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_CharacterContactSettings_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::CharacterContactSettings::CharacterContactSettings`.
            public Const_CharacterContactSettings(CharacterContactSettings _other) : this((Const_CharacterContactSettings)_other) {}
        }

        /// This class contains settings that allow you to override the behavior of a character's collision response
        /// Generated from class `JPH::CharacterContactSettings`.
        /// This is the non-const half of the class.
        public class CharacterContactSettings : Const_CharacterContactSettings
        {
            /// True when the object can push the virtual character.
            public new unsafe ref bool mCanPushCharacter
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactSettings_GetMutable_mCanPushCharacter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactSettings_GetMutable_mCanPushCharacter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_CharacterContactSettings_GetMutable_mCanPushCharacter(_Underlying *_this);
                    return ref *__JPH_CharacterContactSettings_GetMutable_mCanPushCharacter(_UnderlyingPtr);
                }
            }

            /// True when the virtual character can apply impulses (push) the body.
            /// Note that this only works against rigid bodies. Other CharacterVirtual objects can only be moved in their own update,
            /// so you must ensure that in their OnCharacterContactAdded mCanPushCharacter is true.
            public new unsafe ref bool mCanReceiveImpulses
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactSettings_GetMutable_mCanReceiveImpulses", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactSettings_GetMutable_mCanReceiveImpulses", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__JPH_CharacterContactSettings_GetMutable_mCanReceiveImpulses(_Underlying *_this);
                    return ref *__JPH_CharacterContactSettings_GetMutable_mCanReceiveImpulses(_UnderlyingPtr);
                }
            }

            internal unsafe CharacterContactSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe CharacterContactSettings() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterContactSettings._Underlying *__JPH_CharacterContactSettings_DefaultConstruct();
                _UnderlyingPtr = __JPH_CharacterContactSettings_DefaultConstruct();
            }

            /// Constructs `JPH::CharacterContactSettings` elementwise.
            public unsafe CharacterContactSettings(bool mCanPushCharacter, bool mCanReceiveImpulses) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterContactSettings._Underlying *__JPH_CharacterContactSettings_ConstructFrom(byte mCanPushCharacter, byte mCanReceiveImpulses);
                _UnderlyingPtr = __JPH_CharacterContactSettings_ConstructFrom(mCanPushCharacter ? (byte)1 : (byte)0, mCanReceiveImpulses ? (byte)1 : (byte)0);
            }

            /// Generated from constructor `JPH::CharacterContactSettings::CharacterContactSettings`.
            public unsafe CharacterContactSettings(Jolt.JPH.Const_CharacterContactSettings _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterContactSettings._Underlying *__JPH_CharacterContactSettings_ConstructFromAnother(Jolt.JPH.CharacterContactSettings._Underlying *_other);
                _UnderlyingPtr = __JPH_CharacterContactSettings_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::CharacterContactSettings::CharacterContactSettings`.
            public CharacterContactSettings(CharacterContactSettings _other) : this((Const_CharacterContactSettings)_other) {}

            /// Generated from method `JPH::CharacterContactSettings::operator=`.
            public unsafe Jolt.JPH.CharacterContactSettings Assign(Jolt.JPH.Const_CharacterContactSettings _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterContactSettings._Underlying *__JPH_CharacterContactSettings_AssignFromAnother(_Underlying *_this, Jolt.JPH.CharacterContactSettings._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_CharacterContactSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `CharacterContactSettings` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_CharacterContactSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterContactSettings`/`Const_CharacterContactSettings` directly.
        public class _InOptMut_CharacterContactSettings
        {
            public CharacterContactSettings? Opt;

            public _InOptMut_CharacterContactSettings() {}
            public _InOptMut_CharacterContactSettings(CharacterContactSettings value) {Opt = value;}
            public static implicit operator _InOptMut_CharacterContactSettings(CharacterContactSettings value) {return new(value);}
        }

        /// This is used for optional parameters of class `CharacterContactSettings` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_CharacterContactSettings`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterContactSettings`/`Const_CharacterContactSettings` to pass it to the function.
        public class _InOptConst_CharacterContactSettings
        {
            public Const_CharacterContactSettings? Opt;

            public _InOptConst_CharacterContactSettings() {}
            public _InOptConst_CharacterContactSettings(Const_CharacterContactSettings value) {Opt = value;}
            public static implicit operator _InOptConst_CharacterContactSettings(Const_CharacterContactSettings value) {return new(value);}
        }

        /// This class receives callbacks when a virtual character hits something.
        /// Once created, register it on a CharacterVirtual by using the character's SetListener method.
        /// Generated from class `JPH::CharacterContactListener`.
        /// This is the const half of the class.
        public class Const_CharacterContactListener : Jolt.Object<Const_CharacterContactListener>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactListener_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterContactListener_Destroy(_Underlying *_this);
                __JPH_CharacterContactListener_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_CharacterContactListener() {Dispose(false);}

            internal unsafe Const_CharacterContactListener(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_CharacterContactListener() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterContactListener._Underlying *__JPH_CharacterContactListener_DefaultConstruct();
                _UnderlyingPtr = __JPH_CharacterContactListener_DefaultConstruct();
            }

            /// Generated from constructor `JPH::CharacterContactListener::CharacterContactListener`.
            public unsafe Const_CharacterContactListener(Jolt.JPH._ByValue_CharacterContactListener _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterContactListener._Underlying *__JPH_CharacterContactListener_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.CharacterContactListener._Underlying *_other);
                _UnderlyingPtr = __JPH_CharacterContactListener_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::CharacterContactListener::CharacterContactListener`.
            public Const_CharacterContactListener(Const_CharacterContactListener _other) : this(new _ByValue_CharacterContactListener(_other)) {}

            /// Generated from constructor `JPH::CharacterContactListener::CharacterContactListener`.
            public Const_CharacterContactListener(CharacterContactListener _other) : this((Const_CharacterContactListener)_other) {}
        }

        /// This class receives callbacks when a virtual character hits something.
        /// Once created, register it on a CharacterVirtual by using the character's SetListener method.
        /// Generated from class `JPH::CharacterContactListener`.
        /// This is the non-const half of the class.
        public class CharacterContactListener : Const_CharacterContactListener
        {
            internal unsafe CharacterContactListener(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe CharacterContactListener() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactListener_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterContactListener._Underlying *__JPH_CharacterContactListener_DefaultConstruct();
                _UnderlyingPtr = __JPH_CharacterContactListener_DefaultConstruct();
            }

            /// Generated from constructor `JPH::CharacterContactListener::CharacterContactListener`.
            public unsafe CharacterContactListener(Jolt.JPH._ByValue_CharacterContactListener _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactListener_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterContactListener._Underlying *__JPH_CharacterContactListener_ConstructFromAnother(Jolt._PassBy _other_pass_by, Jolt.JPH.CharacterContactListener._Underlying *_other);
                _UnderlyingPtr = __JPH_CharacterContactListener_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::CharacterContactListener::CharacterContactListener`.
            public CharacterContactListener(Const_CharacterContactListener _other) : this(new _ByValue_CharacterContactListener(_other)) {}

            /// Generated from constructor `JPH::CharacterContactListener::CharacterContactListener`.
            public CharacterContactListener(CharacterContactListener _other) : this((Const_CharacterContactListener)_other) {}

            /// Generated from method `JPH::CharacterContactListener::operator=`.
            public unsafe Jolt.JPH.CharacterContactListener Assign(Jolt.JPH._ByValue_CharacterContactListener _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactListener_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactListener_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterContactListener._Underlying *__JPH_CharacterContactListener_AssignFromAnother(_Underlying *_this, Jolt._PassBy _other_pass_by, Jolt.JPH.CharacterContactListener._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_CharacterContactListener_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }

            /// Checks if a character can collide with specified body. Return true if the contact is valid.
            /// Generated from method `JPH::CharacterContactListener::OnContactValidate`.
            public unsafe bool OnContactValidate(Jolt.JPH.Const_CharacterVirtual? inCharacter, in Jolt.JPH.BodyID inBodyID2, Jolt.JPH.Const_SubShapeID inSubShapeID2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactListener_OnContactValidate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactListener_OnContactValidate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_CharacterContactListener_OnContactValidate(_Underlying *_this, Jolt.JPH.Const_CharacterVirtual._Underlying *inCharacter, Jolt.JPH.BodyID *inBodyID2, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID2);
                fixed (Jolt.JPH.BodyID *__ptr_inBodyID2 = &inBodyID2)
                {
                    return __JPH_CharacterContactListener_OnContactValidate(_UnderlyingPtr, inCharacter is not null ? inCharacter._UnderlyingPtr : null, __ptr_inBodyID2, inSubShapeID2._UnderlyingPtr) != 0;
                }
            }

            /// Same as OnContactValidate but when colliding with a CharacterVirtual
            /// Generated from method `JPH::CharacterContactListener::OnCharacterContactValidate`.
            public unsafe bool OnCharacterContactValidate(Jolt.JPH.Const_CharacterVirtual? inCharacter, Jolt.JPH.Const_CharacterVirtual? inOtherCharacter, Jolt.JPH.Const_SubShapeID inSubShapeID2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactListener_OnCharacterContactValidate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactListener_OnCharacterContactValidate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_CharacterContactListener_OnCharacterContactValidate(_Underlying *_this, Jolt.JPH.Const_CharacterVirtual._Underlying *inCharacter, Jolt.JPH.Const_CharacterVirtual._Underlying *inOtherCharacter, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID2);
                return __JPH_CharacterContactListener_OnCharacterContactValidate(_UnderlyingPtr, inCharacter is not null ? inCharacter._UnderlyingPtr : null, inOtherCharacter is not null ? inOtherCharacter._UnderlyingPtr : null, inSubShapeID2._UnderlyingPtr) != 0;
            }

            /// Called whenever the character loses contact with a body.
            /// Note that there is no guarantee that the body or its sub shape still exists at this point. The body may have been deleted since the last update.
            /// @param inCharacter Character that is being solved
            /// @param inBodyID2 Body ID of body that is being hit
            /// @param inSubShapeID2 Sub shape ID of shape that is being hit
            /// Generated from method `JPH::CharacterContactListener::OnContactRemoved`.
            public unsafe void OnContactRemoved(Jolt.JPH.Const_CharacterVirtual? inCharacter, in Jolt.JPH.BodyID inBodyID2, Jolt.JPH.Const_SubShapeID inSubShapeID2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactListener_OnContactRemoved", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactListener_OnContactRemoved", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterContactListener_OnContactRemoved(_Underlying *_this, Jolt.JPH.Const_CharacterVirtual._Underlying *inCharacter, Jolt.JPH.BodyID *inBodyID2, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID2);
                fixed (Jolt.JPH.BodyID *__ptr_inBodyID2 = &inBodyID2)
                {
                    __JPH_CharacterContactListener_OnContactRemoved(_UnderlyingPtr, inCharacter is not null ? inCharacter._UnderlyingPtr : null, __ptr_inBodyID2, inSubShapeID2._UnderlyingPtr);
                }
            }

            /// Same as OnContactRemoved but when colliding with a CharacterVirtual
            /// Note that inOtherCharacterID can be the ID of a character that has been deleted. This happens if the character was in contact with this character during the last update, but has been deleted since.
            /// Generated from method `JPH::CharacterContactListener::OnCharacterContactRemoved`.
            public unsafe void OnCharacterContactRemoved(Jolt.JPH.Const_CharacterVirtual? inCharacter, Jolt.JPH.Const_CharacterID inOtherCharacterID, Jolt.JPH.Const_SubShapeID inSubShapeID2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterContactListener_OnCharacterContactRemoved", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterContactListener_OnCharacterContactRemoved", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterContactListener_OnCharacterContactRemoved(_Underlying *_this, Jolt.JPH.Const_CharacterVirtual._Underlying *inCharacter, Jolt.JPH.Const_CharacterID._Underlying *inOtherCharacterID, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID2);
                __JPH_CharacterContactListener_OnCharacterContactRemoved(_UnderlyingPtr, inCharacter is not null ? inCharacter._UnderlyingPtr : null, inOtherCharacterID._UnderlyingPtr, inSubShapeID2._UnderlyingPtr);
            }
        }

        /// This is used as a function parameter when the underlying function receives `CharacterContactListener` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `CharacterContactListener`/`Const_CharacterContactListener` to copy it into the function.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_CharacterContactListener
        {
            #pragma warning disable CS0649
            internal readonly Const_CharacterContactListener? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_CharacterContactListener() {PassByMode = Jolt._PassBy.default_construct;}
            public _ByValue_CharacterContactListener(Const_CharacterContactListener new_value) {Value = new_value; PassByMode = Jolt._PassBy.copy;}
            public static implicit operator _ByValue_CharacterContactListener(Const_CharacterContactListener arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `CharacterContactListener` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_CharacterContactListener`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterContactListener`/`Const_CharacterContactListener` directly.
        public class _InOptMut_CharacterContactListener
        {
            public CharacterContactListener? Opt;

            public _InOptMut_CharacterContactListener() {}
            public _InOptMut_CharacterContactListener(CharacterContactListener value) {Opt = value;}
            public static implicit operator _InOptMut_CharacterContactListener(CharacterContactListener value) {return new(value);}
        }

        /// This is used for optional parameters of class `CharacterContactListener` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_CharacterContactListener`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterContactListener`/`Const_CharacterContactListener` to pass it to the function.
        public class _InOptConst_CharacterContactListener
        {
            public Const_CharacterContactListener? Opt;

            public _InOptConst_CharacterContactListener() {}
            public _InOptConst_CharacterContactListener(Const_CharacterContactListener value) {Opt = value;}
            public static implicit operator _InOptConst_CharacterContactListener(Const_CharacterContactListener value) {return new(value);}
        }

        /// Interface class that allows a CharacterVirtual to check collision with other CharacterVirtual instances.
        /// Since CharacterVirtual instances are not registered anywhere, it is up to the application to test collision against relevant characters.
        /// The characters could be stored in a tree structure to make this more efficient.
        /// Generated from class `JPH::CharacterVsCharacterCollision`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::NonCopyable`
        /// Derived classes:
        ///   Direct: (non-virtual)
        ///     `JPH::CharacterVsCharacterCollisionSimple`
        /// This is the const half of the class.
        public class Const_CharacterVsCharacterCollision : Jolt.Object<Const_CharacterVsCharacterCollision>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVsCharacterCollision_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVsCharacterCollision_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVsCharacterCollision_Destroy(_Underlying *_this);
                __JPH_CharacterVsCharacterCollision_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_CharacterVsCharacterCollision() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_CharacterVsCharacterCollision self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVsCharacterCollision_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVsCharacterCollision_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_CharacterVsCharacterCollision_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_CharacterVsCharacterCollision_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            internal unsafe Const_CharacterVsCharacterCollision(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}
        }

        /// Interface class that allows a CharacterVirtual to check collision with other CharacterVirtual instances.
        /// Since CharacterVirtual instances are not registered anywhere, it is up to the application to test collision against relevant characters.
        /// The characters could be stored in a tree structure to make this more efficient.
        /// Generated from class `JPH::CharacterVsCharacterCollision`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::NonCopyable`
        /// Derived classes:
        ///   Direct: (non-virtual)
        ///     `JPH::CharacterVsCharacterCollisionSimple`
        /// This is the non-const half of the class.
        public class CharacterVsCharacterCollision : Const_CharacterVsCharacterCollision
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.NonCopyable(CharacterVsCharacterCollision self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVsCharacterCollision_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVsCharacterCollision_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_CharacterVsCharacterCollision_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_CharacterVsCharacterCollision_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            internal unsafe CharacterVsCharacterCollision(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}
        }

        /// This is used for optional parameters of class `CharacterVsCharacterCollision` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_CharacterVsCharacterCollision`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterVsCharacterCollision`/`Const_CharacterVsCharacterCollision` directly.
        public class _InOptMut_CharacterVsCharacterCollision
        {
            public CharacterVsCharacterCollision? Opt;

            public _InOptMut_CharacterVsCharacterCollision() {}
            public _InOptMut_CharacterVsCharacterCollision(CharacterVsCharacterCollision value) {Opt = value;}
            public static implicit operator _InOptMut_CharacterVsCharacterCollision(CharacterVsCharacterCollision value) {return new(value);}
        }

        /// This is used for optional parameters of class `CharacterVsCharacterCollision` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_CharacterVsCharacterCollision`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterVsCharacterCollision`/`Const_CharacterVsCharacterCollision` to pass it to the function.
        public class _InOptConst_CharacterVsCharacterCollision
        {
            public Const_CharacterVsCharacterCollision? Opt;

            public _InOptConst_CharacterVsCharacterCollision() {}
            public _InOptConst_CharacterVsCharacterCollision(Const_CharacterVsCharacterCollision value) {Opt = value;}
            public static implicit operator _InOptConst_CharacterVsCharacterCollision(Const_CharacterVsCharacterCollision value) {return new(value);}
        }

        /// Simple collision checker that loops over all registered characters.
        /// This is a brute force checking algorithm. If you have a lot of characters you may want to store your characters
        /// in a hierarchical structure to make this more efficient.
        /// Note that this is not thread safe, so make sure that only one CharacterVirtual is checking collision at a time.
        /// Generated from class `JPH::CharacterVsCharacterCollisionSimple`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::CharacterVsCharacterCollision`
        ///   Indirect: (non-virtual)
        ///     `JPH::NonCopyable`
        /// This is the const half of the class.
        public class Const_CharacterVsCharacterCollisionSimple : Jolt.Object<Const_CharacterVsCharacterCollisionSimple>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVsCharacterCollisionSimple_Destroy(_Underlying *_this);
                __JPH_CharacterVsCharacterCollisionSimple_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_CharacterVsCharacterCollisionSimple() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_CharacterVsCharacterCollisionSimple self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_CharacterVsCharacterCollision(Const_CharacterVsCharacterCollisionSimple self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_CharacterVsCharacterCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_CharacterVsCharacterCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_CharacterVsCharacterCollision._Underlying *__JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_CharacterVsCharacterCollision(_Underlying *_this);
                Jolt.JPH.Const_CharacterVsCharacterCollision ret = new(__JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_CharacterVsCharacterCollision(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_CharacterVsCharacterCollisionSimple?(Jolt.JPH.Const_CharacterVsCharacterCollision parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_DynamicDowncastFrom_JPH_CharacterVsCharacterCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_DynamicDowncastFrom_JPH_CharacterVsCharacterCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_CharacterVsCharacterCollisionSimple_DynamicDowncastFrom_JPH_CharacterVsCharacterCollision(Jolt.JPH.Const_CharacterVsCharacterCollision._Underlying *_this);
                var ptr = __JPH_CharacterVsCharacterCollisionSimple_DynamicDowncastFrom_JPH_CharacterVsCharacterCollision(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_CharacterVsCharacterCollisionSimple ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe Const_CharacterVsCharacterCollisionSimple(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_CharacterVsCharacterCollisionSimple() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterVsCharacterCollisionSimple._Underlying *__JPH_CharacterVsCharacterCollisionSimple_DefaultConstruct();
                _UnderlyingPtr = __JPH_CharacterVsCharacterCollisionSimple_DefaultConstruct();
            }
        }

        /// Simple collision checker that loops over all registered characters.
        /// This is a brute force checking algorithm. If you have a lot of characters you may want to store your characters
        /// in a hierarchical structure to make this more efficient.
        /// Note that this is not thread safe, so make sure that only one CharacterVirtual is checking collision at a time.
        /// Generated from class `JPH::CharacterVsCharacterCollisionSimple`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::CharacterVsCharacterCollision`
        ///   Indirect: (non-virtual)
        ///     `JPH::NonCopyable`
        /// This is the non-const half of the class.
        public class CharacterVsCharacterCollisionSimple : Const_CharacterVsCharacterCollisionSimple
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.NonCopyable(CharacterVsCharacterCollisionSimple self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.CharacterVsCharacterCollision(CharacterVsCharacterCollisionSimple self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_CharacterVsCharacterCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_CharacterVsCharacterCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterVsCharacterCollision._Underlying *__JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_CharacterVsCharacterCollision(_Underlying *_this);
                Jolt.JPH.CharacterVsCharacterCollision ret = new(__JPH_CharacterVsCharacterCollisionSimple_UpcastTo_JPH_CharacterVsCharacterCollision(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator CharacterVsCharacterCollisionSimple?(Jolt.JPH.CharacterVsCharacterCollision parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_DynamicDowncastFrom_JPH_CharacterVsCharacterCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_DynamicDowncastFrom_JPH_CharacterVsCharacterCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_CharacterVsCharacterCollisionSimple_DynamicDowncastFrom_JPH_CharacterVsCharacterCollision(Jolt.JPH.CharacterVsCharacterCollision._Underlying *_this);
                var ptr = __JPH_CharacterVsCharacterCollisionSimple_DynamicDowncastFrom_JPH_CharacterVsCharacterCollision(parent._UnderlyingPtr);
                if (ptr is null) return null;
                CharacterVsCharacterCollisionSimple ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe CharacterVsCharacterCollisionSimple(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe CharacterVsCharacterCollisionSimple() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterVsCharacterCollisionSimple._Underlying *__JPH_CharacterVsCharacterCollisionSimple_DefaultConstruct();
                _UnderlyingPtr = __JPH_CharacterVsCharacterCollisionSimple_DefaultConstruct();
            }

            /// Add a character to the list of characters to check collision against.
            /// Generated from method `JPH::CharacterVsCharacterCollisionSimple::Add`.
            public unsafe void Add(Jolt.JPH.CharacterVirtual? inCharacter)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_Add", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_Add", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVsCharacterCollisionSimple_Add(_Underlying *_this, Jolt.JPH.CharacterVirtual._Underlying *inCharacter);
                __JPH_CharacterVsCharacterCollisionSimple_Add(_UnderlyingPtr, inCharacter is not null ? inCharacter._UnderlyingPtr : null);
            }

            /// Remove a character from the list of characters to check collision against.
            /// Generated from method `JPH::CharacterVsCharacterCollisionSimple::Remove`.
            public unsafe void Remove(Jolt.JPH.Const_CharacterVirtual? inCharacter)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_Remove", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVsCharacterCollisionSimple_Remove", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVsCharacterCollisionSimple_Remove(_Underlying *_this, Jolt.JPH.Const_CharacterVirtual._Underlying *inCharacter);
                __JPH_CharacterVsCharacterCollisionSimple_Remove(_UnderlyingPtr, inCharacter is not null ? inCharacter._UnderlyingPtr : null);
            }
        }

        /// This is used as a function parameter when the underlying function receives `CharacterVsCharacterCollisionSimple` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_CharacterVsCharacterCollisionSimple
        {
            #pragma warning disable CS0649
            internal readonly Const_CharacterVsCharacterCollisionSimple? Value;
            #pragma warning restore CS0649
            internal readonly Jolt._PassBy PassByMode;
            public _ByValue_CharacterVsCharacterCollisionSimple() {PassByMode = Jolt._PassBy.default_construct;}
        }

        /// This is used for optional parameters of class `CharacterVsCharacterCollisionSimple` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_CharacterVsCharacterCollisionSimple`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterVsCharacterCollisionSimple`/`Const_CharacterVsCharacterCollisionSimple` directly.
        public class _InOptMut_CharacterVsCharacterCollisionSimple
        {
            public CharacterVsCharacterCollisionSimple? Opt;

            public _InOptMut_CharacterVsCharacterCollisionSimple() {}
            public _InOptMut_CharacterVsCharacterCollisionSimple(CharacterVsCharacterCollisionSimple value) {Opt = value;}
            public static implicit operator _InOptMut_CharacterVsCharacterCollisionSimple(CharacterVsCharacterCollisionSimple value) {return new(value);}
        }

        /// This is used for optional parameters of class `CharacterVsCharacterCollisionSimple` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_CharacterVsCharacterCollisionSimple`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterVsCharacterCollisionSimple`/`Const_CharacterVsCharacterCollisionSimple` to pass it to the function.
        public class _InOptConst_CharacterVsCharacterCollisionSimple
        {
            public Const_CharacterVsCharacterCollisionSimple? Opt;

            public _InOptConst_CharacterVsCharacterCollisionSimple() {}
            public _InOptConst_CharacterVsCharacterCollisionSimple(Const_CharacterVsCharacterCollisionSimple value) {Opt = value;}
            public static implicit operator _InOptConst_CharacterVsCharacterCollisionSimple(Const_CharacterVsCharacterCollisionSimple value) {return new(value);}
        }

        /// Runtime character object.
        /// This object usually represents the player. Contrary to the Character class it doesn't use a rigid body but moves doing collision checks only (hence the name virtual).
        /// The advantage of this is that you can determine when the character moves in the frame (usually this has to happen at a very particular point in the frame)
        /// but the downside is that other objects don't see this virtual character. To make a CharacterVirtual visible to the simulation, you can optionally create an inner
        /// rigid body through CharacterVirtualSettings::mInnerBodyShape. A CharacterVirtual is not tracked by the PhysicsSystem so you need to update it yourself. This also means
        /// that a call to PhysicsSystem::SaveState will not save its state, you need to call CharacterVirtual::SaveState yourself.
        /// Generated from class `JPH::CharacterVirtual`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::CharacterBase`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::CharacterBase>`
        ///     `JPH::NonCopyable`
        /// This is the const half of the class.
        public class Const_CharacterVirtual : Jolt.Object<Const_CharacterVirtual>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_Destroy(_Underlying *_this);
                __JPH_CharacterVirtual_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_CharacterVirtual() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_RefTarget_JPHCharacterBase(Const_CharacterVirtual self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_RefTarget_JPHCharacterBase._Underlying *__JPH_CharacterVirtual_UpcastTo_JPH_RefTarget_JPH_CharacterBase(_Underlying *_this);
                Jolt.JPH.Const_RefTarget_JPHCharacterBase ret = new(__JPH_CharacterVirtual_UpcastTo_JPH_RefTarget_JPH_CharacterBase(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_CharacterVirtual self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_CharacterVirtual_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_CharacterVirtual_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.Const_CharacterBase(Const_CharacterVirtual self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_UpcastTo_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_UpcastTo_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_CharacterBase._Underlying *__JPH_CharacterVirtual_UpcastTo_JPH_CharacterBase(_Underlying *_this);
                Jolt.JPH.Const_CharacterBase ret = new(__JPH_CharacterVirtual_UpcastTo_JPH_CharacterBase(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_CharacterVirtual?(Jolt.JPH.Const_CharacterBase parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_DynamicDowncastFrom_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_DynamicDowncastFrom_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_CharacterVirtual_DynamicDowncastFrom_JPH_CharacterBase(Jolt.JPH.Const_CharacterBase._Underlying *_this);
                var ptr = __JPH_CharacterVirtual_DynamicDowncastFrom_JPH_CharacterBase(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_CharacterVirtual ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe Const_CharacterVirtual(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from method `JPH::CharacterVirtual::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CharacterVirtual_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CharacterVirtual_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_CharacterVirtual_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_CharacterVirtual_unsigned_long(inCount);
            }

            /// Generated from method `JPH::CharacterVirtual::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterVirtual_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterVirtual_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CharacterVirtual_void_ptr(void *inPointer);
                __Jolt_delete_JPH_CharacterVirtual_void_ptr(inPointer);
            }

            /// Generated from method `JPH::CharacterVirtual::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterVirtual_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterVirtual_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CharacterVirtual_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_CharacterVirtual_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::CharacterVirtual::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterVirtual_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterVirtual_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_CharacterVirtual_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_CharacterVirtual_unsigned_long(inCount);
            }

            /// Generated from method `JPH::CharacterVirtual::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterVirtual_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterVirtual_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CharacterVirtual_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_CharacterVirtual_void_ptr(inPointer);
            }

            /// Generated from method `JPH::CharacterVirtual::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterVirtual_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterVirtual_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CharacterVirtual_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_CharacterVirtual_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::CharacterVirtual::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CharacterVirtual_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CharacterVirtual_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_CharacterVirtual_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_CharacterVirtual_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::CharacterVirtual::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CharacterVirtual_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CharacterVirtual_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_CharacterVirtual_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_CharacterVirtual_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::CharacterVirtual::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterVirtual_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CharacterVirtual_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_CharacterVirtual_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_CharacterVirtual_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::CharacterVirtual::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterVirtual_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CharacterVirtual_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_CharacterVirtual_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_CharacterVirtual_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// The ID of this character
            /// Generated from method `JPH::CharacterVirtual::GetID`.
            public unsafe Jolt.JPH.Const_CharacterID GetID()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_CharacterID._Underlying *__JPH_CharacterVirtual_GetID(_Underlying *_this);
                return new(__JPH_CharacterVirtual_GetID(_UnderlyingPtr), is_owning: false);
            }

            /// Get the current contact listener
            /// Generated from method `JPH::CharacterVirtual::GetListener`.
            public unsafe Jolt.JPH.CharacterContactListener? GetListener()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterContactListener._Underlying *__JPH_CharacterVirtual_GetListener(_Underlying *_this);
                var __c_ret = __JPH_CharacterVirtual_GetListener(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.CharacterContactListener(__c_ret, is_owning: false) : null;
            }

            /// Character mass (kg)
            /// Generated from method `JPH::CharacterVirtual::GetMass`.
            public unsafe float GetMass()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_CharacterVirtual_GetMass(_Underlying *_this);
                return __JPH_CharacterVirtual_GetMass(_UnderlyingPtr);
            }

            /// Maximum force with which the character can push other bodies (N)
            /// Generated from method `JPH::CharacterVirtual::GetMaxStrength`.
            public unsafe float GetMaxStrength()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetMaxStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetMaxStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_CharacterVirtual_GetMaxStrength(_Underlying *_this);
                return __JPH_CharacterVirtual_GetMaxStrength(_UnderlyingPtr);
            }

            /// This value governs how fast a penetration will be resolved, 0 = nothing is resolved, 1 = everything in one update
            /// Generated from method `JPH::CharacterVirtual::GetPenetrationRecoverySpeed`.
            public unsafe float GetPenetrationRecoverySpeed()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetPenetrationRecoverySpeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetPenetrationRecoverySpeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_CharacterVirtual_GetPenetrationRecoverySpeed(_Underlying *_this);
                return __JPH_CharacterVirtual_GetPenetrationRecoverySpeed(_UnderlyingPtr);
            }

            /// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
            /// Generated from method `JPH::CharacterVirtual::GetEnhancedInternalEdgeRemoval`.
            public unsafe bool GetEnhancedInternalEdgeRemoval()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_CharacterVirtual_GetEnhancedInternalEdgeRemoval(_Underlying *_this);
                return __JPH_CharacterVirtual_GetEnhancedInternalEdgeRemoval(_UnderlyingPtr) != 0;
            }

            /// Character padding
            /// Generated from method `JPH::CharacterVirtual::GetCharacterPadding`.
            public unsafe float GetCharacterPadding()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetCharacterPadding", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetCharacterPadding", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_CharacterVirtual_GetCharacterPadding(_Underlying *_this);
                return __JPH_CharacterVirtual_GetCharacterPadding(_UnderlyingPtr);
            }

            /// Max num hits to collect in order to avoid excess of contact points collection
            /// Generated from method `JPH::CharacterVirtual::GetMaxNumHits`.
            public unsafe uint GetMaxNumHits()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetMaxNumHits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetMaxNumHits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_CharacterVirtual_GetMaxNumHits(_Underlying *_this);
                return __JPH_CharacterVirtual_GetMaxNumHits(_UnderlyingPtr);
            }

            /// Cos(angle) where angle is the maximum angle between two hits contact normals that are allowed to be merged during hit reduction. Default is around 2.5 degrees. Set to -1 to turn off.
            /// Generated from method `JPH::CharacterVirtual::GetHitReductionCosMaxAngle`.
            public unsafe float GetHitReductionCosMaxAngle()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetHitReductionCosMaxAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetHitReductionCosMaxAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_CharacterVirtual_GetHitReductionCosMaxAngle(_Underlying *_this);
                return __JPH_CharacterVirtual_GetHitReductionCosMaxAngle(_UnderlyingPtr);
            }

            /// Returns if we exceeded the maximum number of hits during the last collision check and had to discard hits based on distance.
            /// This can be used to find areas that have too complex geometry for the character to navigate properly.
            /// To solve you can either increase the max number of hits or simplify the geometry. Note that the character simulation will
            /// try to do its best to select the most relevant contacts to avoid the character from getting stuck.
            /// Generated from method `JPH::CharacterVirtual::GetMaxHitsExceeded`.
            public unsafe bool GetMaxHitsExceeded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetMaxHitsExceeded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetMaxHitsExceeded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_CharacterVirtual_GetMaxHitsExceeded(_Underlying *_this);
                return __JPH_CharacterVirtual_GetMaxHitsExceeded(_UnderlyingPtr) != 0;
            }

            /// Access to the user data, can be used for anything by the application
            /// Generated from method `JPH::CharacterVirtual::GetUserData`.
            public unsafe ulong GetUserData()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_CharacterVirtual_GetUserData(_Underlying *_this);
                return __JPH_CharacterVirtual_GetUserData(_UnderlyingPtr);
            }

            /// Optional inner rigid body that proxies the character in the world. Can be used to update body properties.
            /// Generated from method `JPH::CharacterVirtual::GetInnerBodyID`.
            public unsafe Jolt.JPH.BodyID GetInnerBodyID()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetInnerBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetInnerBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BodyID __JPH_CharacterVirtual_GetInnerBodyID(_Underlying *_this);
                return __JPH_CharacterVirtual_GetInnerBodyID(_UnderlyingPtr);
            }

            /// Get the character settings that can recreate this character
            /// Generated from method `JPH::CharacterVirtual::GetCharacterVirtualSettings`.
            public unsafe Jolt.JPH.CharacterVirtualSettings GetCharacterVirtualSettings()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetCharacterVirtualSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetCharacterVirtualSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterVirtualSettings._Underlying *__JPH_CharacterVirtual_GetCharacterVirtualSettings(_Underlying *_this);
                return new(__JPH_CharacterVirtual_GetCharacterVirtualSettings(_UnderlyingPtr), is_owning: true);
            }

            /// Check if the character is currently in contact with or has collided with another body in the last operation (e.g. Update or WalkStairs)
            /// Generated from method `JPH::CharacterVirtual::HasCollidedWith`.
            public unsafe bool HasCollidedWith(in Jolt.JPH.BodyID inBody)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_HasCollidedWith_JPH_BodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_HasCollidedWith_JPH_BodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_CharacterVirtual_HasCollidedWith_JPH_BodyID(_Underlying *_this, Jolt.JPH.BodyID *inBody);
                fixed (Jolt.JPH.BodyID *__ptr_inBody = &inBody)
                {
                    return __JPH_CharacterVirtual_HasCollidedWith_JPH_BodyID(_UnderlyingPtr, __ptr_inBody) != 0;
                }
            }

            /// Check if the character is currently in contact with or has collided with another character in the last time step (e.g. Update or WalkStairs)
            /// Generated from method `JPH::CharacterVirtual::HasCollidedWith`.
            public unsafe bool HasCollidedWith(Jolt.JPH.Const_CharacterID inCharacterID)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_HasCollidedWith_JPH_CharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_HasCollidedWith_JPH_CharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_CharacterVirtual_HasCollidedWith_JPH_CharacterID(_Underlying *_this, Jolt.JPH.Const_CharacterID._Underlying *inCharacterID);
                return __JPH_CharacterVirtual_HasCollidedWith_JPH_CharacterID(_UnderlyingPtr, inCharacterID._UnderlyingPtr) != 0;
            }

            /// Check if the character is currently in contact with or has collided with another character in the last time step (e.g. Update or WalkStairs)
            /// Generated from method `JPH::CharacterVirtual::HasCollidedWith`.
            public unsafe bool HasCollidedWith(Jolt.JPH.Const_CharacterVirtual? inCharacter)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_HasCollidedWith_const_JPH_CharacterVirtual_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_HasCollidedWith_const_JPH_CharacterVirtual_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_CharacterVirtual_HasCollidedWith_const_JPH_CharacterVirtual_ptr(_Underlying *_this, Jolt.JPH.Const_CharacterVirtual._Underlying *inCharacter);
                return __JPH_CharacterVirtual_HasCollidedWith_const_JPH_CharacterVirtual_ptr(_UnderlyingPtr, inCharacter is not null ? inCharacter._UnderlyingPtr : null) != 0;
            }

            /// Generated from method `JPH::CharacterVirtual::GetCosMaxSlopeAngle`.
            public unsafe float GetCosMaxSlopeAngle()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetCosMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetCosMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_CharacterVirtual_GetCosMaxSlopeAngle(_Underlying *_this);
                return __JPH_CharacterVirtual_GetCosMaxSlopeAngle(_UnderlyingPtr);
            }

            /// Get the current shape that the character is using.
            /// Generated from method `JPH::CharacterVirtual::GetShape`.
            public unsafe Jolt.JPH.Const_Shape? GetShape()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Shape._Underlying *__JPH_CharacterVirtual_GetShape(_Underlying *_this);
                var __c_ret = __JPH_CharacterVirtual_GetShape(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_Shape(__c_ret, is_owning: false) : null;
            }

            /// Debug function to convert enum values to string
            /// Generated from method `JPH::CharacterVirtual::sToString`.
            public static unsafe byte? SToString(Jolt.JPH.CharacterBase.EGroundState inState)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_sToString", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_sToString", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte *__JPH_CharacterVirtual_sToString(Jolt.JPH.CharacterBase.EGroundState inState);
                var __c_ret = __JPH_CharacterVirtual_sToString(inState);
                return __c_ret is not null ? *__c_ret : null;
            }

            /// Current ground state
            /// Generated from method `JPH::CharacterVirtual::GetGroundState`.
            public unsafe Jolt.JPH.CharacterBase.EGroundState GetGroundState()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetGroundState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetGroundState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterBase.EGroundState __JPH_CharacterVirtual_GetGroundState(_Underlying *_this);
                return __JPH_CharacterVirtual_GetGroundState(_UnderlyingPtr);
            }

            /// Returns true if the player is supported by normal or steep ground
            /// Generated from method `JPH::CharacterVirtual::IsSupported`.
            public unsafe bool IsSupported()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_IsSupported", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_IsSupported", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_CharacterVirtual_IsSupported(_Underlying *_this);
                return __JPH_CharacterVirtual_IsSupported(_UnderlyingPtr) != 0;
            }

            /// Material that the character is standing on
            /// Generated from method `JPH::CharacterVirtual::GetGroundMaterial`.
            public unsafe Jolt.JPH.Const_PhysicsMaterial? GetGroundMaterial()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetGroundMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetGroundMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_PhysicsMaterial._Underlying *__JPH_CharacterVirtual_GetGroundMaterial(_Underlying *_this);
                var __c_ret = __JPH_CharacterVirtual_GetGroundMaterial(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
            }

            /// BodyID of the object the character is standing on. Note may have been removed!
            /// Generated from method `JPH::CharacterVirtual::GetGroundBodyID`.
            public unsafe Jolt.JPH.BodyID GetGroundBodyID()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetGroundBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetGroundBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BodyID __JPH_CharacterVirtual_GetGroundBodyID(_Underlying *_this);
                return __JPH_CharacterVirtual_GetGroundBodyID(_UnderlyingPtr);
            }

            /// Sub part of the body that we're standing on.
            /// Generated from method `JPH::CharacterVirtual::GetGroundSubShapeID`.
            public unsafe Jolt.JPH.SubShapeID GetGroundSubShapeID()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetGroundSubShapeID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetGroundSubShapeID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SubShapeID._Underlying *__JPH_CharacterVirtual_GetGroundSubShapeID(_Underlying *_this);
                return new(__JPH_CharacterVirtual_GetGroundSubShapeID(_UnderlyingPtr), is_owning: true);
            }

            /// User data value of the body that we're standing on
            /// Generated from method `JPH::CharacterVirtual::GetGroundUserData`.
            public unsafe ulong GetGroundUserData()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetGroundUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetGroundUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_CharacterVirtual_GetGroundUserData(_Underlying *_this);
                return __JPH_CharacterVirtual_GetGroundUserData(_UnderlyingPtr);
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::CharacterVirtual::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_SetEmbedded(_Underlying *_this);
                __JPH_CharacterVirtual_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::CharacterVirtual::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_CharacterVirtual_GetRefCount(_Underlying *_this);
                return __JPH_CharacterVirtual_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::CharacterVirtual::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_AddRef(_Underlying *_this);
                __JPH_CharacterVirtual_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::CharacterVirtual::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_Release(_Underlying *_this);
                __JPH_CharacterVirtual_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::CharacterVirtual::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_CharacterVirtual_sInternalGetRefCountOffset();
                return __JPH_CharacterVirtual_sInternalGetRefCountOffset();
            }

            /// Encapsulates a collision contact
            /// Generated from class `JPH::CharacterVirtual::Contact`.
            /// Base classes:
            ///   Direct: (non-virtual)
            ///     `JPH::CharacterVirtual::ContactKey`
            /// This is the const half of the class.
            public class Const_Contact : Jolt.Object<Const_Contact>, System.IDisposable, System.IEquatable<Jolt.JPH.CharacterVirtual.Const_ContactKey>
            {
                internal struct _Underlying {} // Represents the underlying C++ type.

                internal unsafe _Underlying *_UnderlyingPtr;

                protected virtual unsafe void Dispose(bool disposing)
                {
                    if (_UnderlyingPtr is null || !_IsOwningVal)
                        return;
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __JPH_CharacterVirtual_Contact_Destroy(_Underlying *_this);
                    __JPH_CharacterVirtual_Contact_Destroy(_UnderlyingPtr);
                    _UnderlyingPtr = null;
                }
                public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
                ~Const_Contact() {Dispose(false);}

                // Upcasts:
                public static unsafe implicit operator Jolt.JPH.CharacterVirtual.Const_ContactKey(Const_Contact self)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_UpcastTo_JPH_CharacterVirtual_ContactKey", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_UpcastTo_JPH_CharacterVirtual_ContactKey", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.Const_ContactKey._Underlying *__JPH_CharacterVirtual_Contact_UpcastTo_JPH_CharacterVirtual_ContactKey(_Underlying *_this);
                    Jolt.JPH.CharacterVirtual.Const_ContactKey ret = new(__JPH_CharacterVirtual_Contact_UpcastTo_JPH_CharacterVirtual_ContactKey(self._UnderlyingPtr), is_owning: false);
                    ret._KeepAliveEnclosingObject = self;
                    return ret;
                }

                ///< Distance to the contact <= 0 means that it is an actual contact, > 0 means predictive
                public unsafe float mDistance
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static float *__JPH_CharacterVirtual_Contact_Get_mDistance(_Underlying *_this);
                        return *__JPH_CharacterVirtual_Contact_Get_mDistance(_UnderlyingPtr);
                    }
                }

                ///< Fraction along the path where this contact takes place
                public unsafe float mFraction
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static float *__JPH_CharacterVirtual_Contact_Get_mFraction(_Underlying *_this);
                        return *__JPH_CharacterVirtual_Contact_Get_mFraction(_UnderlyingPtr);
                    }
                }

                ///< If B is a sensor
                public unsafe bool mIsSensorB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mIsSensorB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mIsSensorB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static bool *__JPH_CharacterVirtual_Contact_Get_mIsSensorB(_Underlying *_this);
                        return *__JPH_CharacterVirtual_Contact_Get_mIsSensorB(_UnderlyingPtr);
                    }
                }

                ///< Character we're colliding with (if not nullptr). Note that this may be a dangling pointer when accessed through GetActiveContacts(), use mCharacterIDB instead.
                public unsafe Jolt.JPH.Const_CharacterVirtual? mCharacterB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mCharacterB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mCharacterB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.Const_CharacterVirtual._Underlying **__JPH_CharacterVirtual_Contact_Get_mCharacterB(Const_Contact._Underlying *_this);
                        var ptr = __JPH_CharacterVirtual_Contact_Get_mCharacterB(_UnderlyingPtr);
                        Jolt.JPH.Const_CharacterVirtual? value = null;
                        if (*ptr is not null)
                        {
                            value = new(*ptr, is_owning: false);
                            value._KeepAliveEnclosingObject = this;
                        }
                        return value;
                    }
                }

                ///< User data of B
                public unsafe ulong mUserData
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static ulong *__JPH_CharacterVirtual_Contact_Get_mUserData(_Underlying *_this);
                        return *__JPH_CharacterVirtual_Contact_Get_mUserData(_UnderlyingPtr);
                    }
                }

                ///< Material of B
                public unsafe Jolt.JPH.Const_PhysicsMaterial? mMaterial
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.Const_PhysicsMaterial._Underlying **__JPH_CharacterVirtual_Contact_Get_mMaterial(Const_Contact._Underlying *_this);
                        var ptr = __JPH_CharacterVirtual_Contact_Get_mMaterial(_UnderlyingPtr);
                        Jolt.JPH.Const_PhysicsMaterial? value = null;
                        if (*ptr is not null)
                        {
                            value = new(*ptr, is_owning: false);
                            value._KeepAliveEnclosingObject = this;
                        }
                        return value;
                    }
                }

                ///< If the character actually collided with the contact (can be false if a predictive contact never becomes a real one)
                public unsafe bool mHadCollision
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mHadCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mHadCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static bool *__JPH_CharacterVirtual_Contact_Get_mHadCollision(_Underlying *_this);
                        return *__JPH_CharacterVirtual_Contact_Get_mHadCollision(_UnderlyingPtr);
                    }
                }

                ///< If the contact validate callback chose to discard this contact or when the body is a sensor
                public unsafe bool mWasDiscarded
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mWasDiscarded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mWasDiscarded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static bool *__JPH_CharacterVirtual_Contact_Get_mWasDiscarded(_Underlying *_this);
                        return *__JPH_CharacterVirtual_Contact_Get_mWasDiscarded(_UnderlyingPtr);
                    }
                }

                ///< When true, the velocity of the contact point can push the character
                public unsafe bool mCanPushCharacter
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mCanPushCharacter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mCanPushCharacter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static bool *__JPH_CharacterVirtual_Contact_Get_mCanPushCharacter(_Underlying *_this);
                        return *__JPH_CharacterVirtual_Contact_Get_mCanPushCharacter(_UnderlyingPtr);
                    }
                }

                ///< ID of body we're colliding with (if not invalid)
                public unsafe ref readonly Jolt.JPH.BodyID mBodyB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mBodyB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mBodyB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.BodyID *__JPH_CharacterVirtual_Contact_Get_mBodyB(_Underlying *_this);
                        return ref *__JPH_CharacterVirtual_Contact_Get_mBodyB(_UnderlyingPtr);
                    }
                }

                ///< Character we're colliding with (if not invalid)
                public unsafe Jolt.JPH.Const_CharacterID mCharacterIDB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mCharacterIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mCharacterIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.Const_CharacterID._Underlying *__JPH_CharacterVirtual_Contact_Get_mCharacterIDB(_Underlying *_this);
                        Jolt.JPH.Const_CharacterID __ret;
                        __ret = new(__JPH_CharacterVirtual_Contact_Get_mCharacterIDB(_UnderlyingPtr), is_owning: false);
                        __ret._KeepAliveEnclosingObject = this;
                        return __ret;
                    }
                }

                ///< Sub shape ID of body or character we're colliding with
                public unsafe Jolt.JPH.Const_SubShapeID mSubShapeIDB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mSubShapeIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_Get_mSubShapeIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.Const_SubShapeID._Underlying *__JPH_CharacterVirtual_Contact_Get_mSubShapeIDB(_Underlying *_this);
                        Jolt.JPH.Const_SubShapeID __ret;
                        __ret = new(__JPH_CharacterVirtual_Contact_Get_mSubShapeIDB(_UnderlyingPtr), is_owning: false);
                        __ret._KeepAliveEnclosingObject = this;
                        return __ret;
                    }
                }

                internal unsafe Const_Contact(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

                /// Constructs an empty (default-constructed) instance.
                public unsafe Const_Contact() : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.Contact._Underlying *__JPH_CharacterVirtual_Contact_DefaultConstruct();
                    _UnderlyingPtr = __JPH_CharacterVirtual_Contact_DefaultConstruct();
                }

                /// Generated from constructor `JPH::CharacterVirtual::Contact::Contact`.
                public unsafe Const_Contact(Jolt.JPH.CharacterVirtual.Const_Contact _other) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.Contact._Underlying *__JPH_CharacterVirtual_Contact_ConstructFromAnother(Jolt.JPH.CharacterVirtual.Contact._Underlying *_other);
                    _UnderlyingPtr = __JPH_CharacterVirtual_Contact_ConstructFromAnother(_other._UnderlyingPtr);
                    _KeepAlive(_other);
                }

                /// Generated from constructor `JPH::CharacterVirtual::Contact::Contact`.
                public Const_Contact(Contact _other) : this((Const_Contact)_other) {}

                /// Checks if two contacts refer to the same body (or virtual character)
                /// Generated from method `JPH::CharacterVirtual::Contact::IsSameBody`.
                public unsafe bool IsSameBody(Jolt.JPH.CharacterVirtual.Const_ContactKey inOther)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_IsSameBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_IsSameBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static byte __JPH_CharacterVirtual_Contact_IsSameBody(_Underlying *_this, Jolt.JPH.CharacterVirtual.Const_ContactKey._Underlying *inOther);
                    return __JPH_CharacterVirtual_Contact_IsSameBody(_UnderlyingPtr, inOther._UnderlyingPtr) != 0;
                }

                /// Equality operator
                /// Generated from method `JPH::CharacterVirtual::Contact::operator==`.
                public static unsafe bool operator==(Jolt.JPH.CharacterVirtual.Const_Contact _this, Jolt.JPH.CharacterVirtual.Const_ContactKey inRHS)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_CharacterVirtual_Contact_JPH_CharacterVirtual_ContactKey", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_CharacterVirtual_Contact_JPH_CharacterVirtual_ContactKey", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static byte __Jolt_equal_JPH_CharacterVirtual_Contact_JPH_CharacterVirtual_ContactKey(Jolt.JPH.CharacterVirtual.Const_Contact._Underlying *_this, Jolt.JPH.CharacterVirtual.Const_ContactKey._Underlying *inRHS);
                    return __Jolt_equal_JPH_CharacterVirtual_Contact_JPH_CharacterVirtual_ContactKey(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
                }

                public static unsafe bool operator!=(Jolt.JPH.CharacterVirtual.Const_Contact _this, Jolt.JPH.CharacterVirtual.Const_ContactKey inRHS)
                {
                    return !(_this == inRHS);
                }

                /// Hash of this structure
                /// Generated from method `JPH::CharacterVirtual::Contact::GetHash`.
                public unsafe ulong GetHash()
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetHash", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetHash", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong __JPH_CharacterVirtual_Contact_GetHash(_Underlying *_this);
                    return __JPH_CharacterVirtual_Contact_GetHash(_UnderlyingPtr);
                }

                // IEquatable:

                public bool Equals(Jolt.JPH.CharacterVirtual.Const_ContactKey? inRHS)
                {
                    if (inRHS is null)
                        return false;
                    return this == inRHS;
                }

                public override bool Equals(object? other)
                {
                    if (other is null)
                        return false;
                    if (other is Jolt.JPH.CharacterVirtual.Const_ContactKey)
                        return this == (Jolt.JPH.CharacterVirtual.Const_ContactKey)other;
                    return false;
                }
            }

            /// Encapsulates a collision contact
            /// Generated from class `JPH::CharacterVirtual::Contact`.
            /// Base classes:
            ///   Direct: (non-virtual)
            ///     `JPH::CharacterVirtual::ContactKey`
            /// This is the non-const half of the class.
            public class Contact : Const_Contact
            {
                // Upcasts:
                public static unsafe implicit operator Jolt.JPH.CharacterVirtual.ContactKey(Contact self)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_UpcastTo_JPH_CharacterVirtual_ContactKey", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_UpcastTo_JPH_CharacterVirtual_ContactKey", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ContactKey._Underlying *__JPH_CharacterVirtual_Contact_UpcastTo_JPH_CharacterVirtual_ContactKey(_Underlying *_this);
                    Jolt.JPH.CharacterVirtual.ContactKey ret = new(__JPH_CharacterVirtual_Contact_UpcastTo_JPH_CharacterVirtual_ContactKey(self._UnderlyingPtr), is_owning: false);
                    ret._KeepAliveEnclosingObject = self;
                    return ret;
                }

                ///< Distance to the contact <= 0 means that it is an actual contact, > 0 means predictive
                public new unsafe ref float mDistance
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static float *__JPH_CharacterVirtual_Contact_GetMutable_mDistance(_Underlying *_this);
                        return ref *__JPH_CharacterVirtual_Contact_GetMutable_mDistance(_UnderlyingPtr);
                    }
                }

                ///< Fraction along the path where this contact takes place
                public new unsafe ref float mFraction
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static float *__JPH_CharacterVirtual_Contact_GetMutable_mFraction(_Underlying *_this);
                        return ref *__JPH_CharacterVirtual_Contact_GetMutable_mFraction(_UnderlyingPtr);
                    }
                }

                ///< If B is a sensor
                public new unsafe ref bool mIsSensorB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mIsSensorB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mIsSensorB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static bool *__JPH_CharacterVirtual_Contact_GetMutable_mIsSensorB(_Underlying *_this);
                        return ref *__JPH_CharacterVirtual_Contact_GetMutable_mIsSensorB(_UnderlyingPtr);
                    }
                }

                ///< Character we're colliding with (if not nullptr). Note that this may be a dangling pointer when accessed through GetActiveContacts(), use mCharacterIDB instead.
                public new unsafe Jolt.JPH.Const_CharacterVirtual? mCharacterB
                {
                    get => base.mCharacterB;
                    set
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mCharacterB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mCharacterB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.Const_CharacterVirtual._Underlying **__JPH_CharacterVirtual_Contact_GetMutable_mCharacterB(Contact._Underlying *_this);
                        var ptr = __JPH_CharacterVirtual_Contact_GetMutable_mCharacterB(_UnderlyingPtr);
                        _DiscardKeepAlive("mCharacterB");
                        if (value is not null)
                            _KeepAlive(value, "mCharacterB");
                        *ptr = (value is not null ? value._UnderlyingPtr : null);
                    }
                }

                ///< User data of B
                public new unsafe ref ulong mUserData
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static ulong *__JPH_CharacterVirtual_Contact_GetMutable_mUserData(_Underlying *_this);
                        return ref *__JPH_CharacterVirtual_Contact_GetMutable_mUserData(_UnderlyingPtr);
                    }
                }

                ///< Material of B
                public new unsafe Jolt.JPH.Const_PhysicsMaterial? mMaterial
                {
                    get => base.mMaterial;
                    set
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.Const_PhysicsMaterial._Underlying **__JPH_CharacterVirtual_Contact_GetMutable_mMaterial(Contact._Underlying *_this);
                        var ptr = __JPH_CharacterVirtual_Contact_GetMutable_mMaterial(_UnderlyingPtr);
                        _DiscardKeepAlive("mMaterial");
                        if (value is not null)
                            _KeepAlive(value, "mMaterial");
                        *ptr = (value is not null ? value._UnderlyingPtr : null);
                    }
                }

                ///< If the character actually collided with the contact (can be false if a predictive contact never becomes a real one)
                public new unsafe ref bool mHadCollision
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mHadCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mHadCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static bool *__JPH_CharacterVirtual_Contact_GetMutable_mHadCollision(_Underlying *_this);
                        return ref *__JPH_CharacterVirtual_Contact_GetMutable_mHadCollision(_UnderlyingPtr);
                    }
                }

                ///< If the contact validate callback chose to discard this contact or when the body is a sensor
                public new unsafe ref bool mWasDiscarded
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mWasDiscarded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mWasDiscarded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static bool *__JPH_CharacterVirtual_Contact_GetMutable_mWasDiscarded(_Underlying *_this);
                        return ref *__JPH_CharacterVirtual_Contact_GetMutable_mWasDiscarded(_UnderlyingPtr);
                    }
                }

                ///< When true, the velocity of the contact point can push the character
                public new unsafe ref bool mCanPushCharacter
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mCanPushCharacter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mCanPushCharacter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static bool *__JPH_CharacterVirtual_Contact_GetMutable_mCanPushCharacter(_Underlying *_this);
                        return ref *__JPH_CharacterVirtual_Contact_GetMutable_mCanPushCharacter(_UnderlyingPtr);
                    }
                }

                ///< ID of body we're colliding with (if not invalid)
                public new unsafe ref Jolt.JPH.BodyID mBodyB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mBodyB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mBodyB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.BodyID *__JPH_CharacterVirtual_Contact_GetMutable_mBodyB(_Underlying *_this);
                        return ref *__JPH_CharacterVirtual_Contact_GetMutable_mBodyB(_UnderlyingPtr);
                    }
                }

                ///< Character we're colliding with (if not invalid)
                public new unsafe Jolt.JPH.CharacterID mCharacterIDB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mCharacterIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mCharacterIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.CharacterID._Underlying *__JPH_CharacterVirtual_Contact_GetMutable_mCharacterIDB(_Underlying *_this);
                        Jolt.JPH.CharacterID __ret;
                        __ret = new(__JPH_CharacterVirtual_Contact_GetMutable_mCharacterIDB(_UnderlyingPtr), is_owning: false);
                        __ret._KeepAliveEnclosingObject = this;
                        return __ret;
                    }
                }

                ///< Sub shape ID of body or character we're colliding with
                public new unsafe Jolt.JPH.SubShapeID mSubShapeIDB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mSubShapeIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_GetMutable_mSubShapeIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.SubShapeID._Underlying *__JPH_CharacterVirtual_Contact_GetMutable_mSubShapeIDB(_Underlying *_this);
                        Jolt.JPH.SubShapeID __ret;
                        __ret = new(__JPH_CharacterVirtual_Contact_GetMutable_mSubShapeIDB(_UnderlyingPtr), is_owning: false);
                        __ret._KeepAliveEnclosingObject = this;
                        return __ret;
                    }
                }

                internal unsafe Contact(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

                /// Constructs an empty (default-constructed) instance.
                public unsafe Contact() : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.Contact._Underlying *__JPH_CharacterVirtual_Contact_DefaultConstruct();
                    _UnderlyingPtr = __JPH_CharacterVirtual_Contact_DefaultConstruct();
                }

                /// Generated from constructor `JPH::CharacterVirtual::Contact::Contact`.
                public unsafe Contact(Jolt.JPH.CharacterVirtual.Const_Contact _other) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.Contact._Underlying *__JPH_CharacterVirtual_Contact_ConstructFromAnother(Jolt.JPH.CharacterVirtual.Contact._Underlying *_other);
                    _UnderlyingPtr = __JPH_CharacterVirtual_Contact_ConstructFromAnother(_other._UnderlyingPtr);
                    _KeepAlive(_other);
                }

                /// Generated from constructor `JPH::CharacterVirtual::Contact::Contact`.
                public Contact(Contact _other) : this((Const_Contact)_other) {}

                /// Generated from method `JPH::CharacterVirtual::Contact::operator=`.
                public unsafe Jolt.JPH.CharacterVirtual.Contact Assign(Jolt.JPH.CharacterVirtual.Const_Contact _other)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_Contact_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.Contact._Underlying *__JPH_CharacterVirtual_Contact_AssignFromAnother(_Underlying *_this, Jolt.JPH.CharacterVirtual.Contact._Underlying *_other);
                    _DiscardKeepAlive();
                    _KeepAlive(_other);
                    return new(__JPH_CharacterVirtual_Contact_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
                }
            }

            /// This is used for optional parameters of class `Contact` with default arguments.
            /// This is only used mutable parameters. For const ones we have `_InOptConst_Contact`.
            /// Usage:
            /// * Pass `null` to use the default argument.
            /// * Pass `new()` to pass no object.
            /// * Pass an instance of `Contact`/`Const_Contact` directly.
            public class _InOptMut_Contact
            {
                public Contact? Opt;

                public _InOptMut_Contact() {}
                public _InOptMut_Contact(Contact value) {Opt = value;}
                public static implicit operator _InOptMut_Contact(Contact value) {return new(value);}
            }

            /// This is used for optional parameters of class `Contact` with default arguments.
            /// This is only used const parameters. For non-const ones we have `_InOptMut_Contact`.
            /// Usage:
            /// * Pass `null` to use the default argument.
            /// * Pass `new()` to pass no object.
            /// * Pass an instance of `Contact`/`Const_Contact` to pass it to the function.
            public class _InOptConst_Contact
            {
                public Const_Contact? Opt;

                public _InOptConst_Contact() {}
                public _InOptConst_Contact(Const_Contact value) {Opt = value;}
                public static implicit operator _InOptConst_Contact(Const_Contact value) {return new(value);}
            }

            /// Uniquely identifies a contact between a character and another body or character
            /// Generated from class `JPH::CharacterVirtual::ContactKey`.
            /// Derived classes:
            ///   Direct: (non-virtual)
            ///     `JPH::CharacterVirtual::Contact`
            /// This is the const half of the class.
            public class Const_ContactKey : Jolt.Object<Const_ContactKey>, System.IDisposable, System.IEquatable<Jolt.JPH.CharacterVirtual.Const_ContactKey>
            {
                internal struct _Underlying {} // Represents the underlying C++ type.

                internal unsafe _Underlying *_UnderlyingPtr;

                protected virtual unsafe void Dispose(bool disposing)
                {
                    if (_UnderlyingPtr is null || !_IsOwningVal)
                        return;
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __JPH_CharacterVirtual_ContactKey_Destroy(_Underlying *_this);
                    __JPH_CharacterVirtual_ContactKey_Destroy(_UnderlyingPtr);
                    _UnderlyingPtr = null;
                }
                public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
                ~Const_ContactKey() {Dispose(false);}

                ///< ID of body we're colliding with (if not invalid)
                public unsafe ref readonly Jolt.JPH.BodyID mBodyB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Get_mBodyB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Get_mBodyB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.BodyID *__JPH_CharacterVirtual_ContactKey_Get_mBodyB(_Underlying *_this);
                        return ref *__JPH_CharacterVirtual_ContactKey_Get_mBodyB(_UnderlyingPtr);
                    }
                }

                ///< Character we're colliding with (if not invalid)
                public unsafe Jolt.JPH.Const_CharacterID mCharacterIDB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Get_mCharacterIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Get_mCharacterIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.Const_CharacterID._Underlying *__JPH_CharacterVirtual_ContactKey_Get_mCharacterIDB(_Underlying *_this);
                        Jolt.JPH.Const_CharacterID __ret;
                        __ret = new(__JPH_CharacterVirtual_ContactKey_Get_mCharacterIDB(_UnderlyingPtr), is_owning: false);
                        __ret._KeepAliveEnclosingObject = this;
                        return __ret;
                    }
                }

                ///< Sub shape ID of body or character we're colliding with
                public unsafe Jolt.JPH.Const_SubShapeID mSubShapeIDB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Get_mSubShapeIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Get_mSubShapeIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.Const_SubShapeID._Underlying *__JPH_CharacterVirtual_ContactKey_Get_mSubShapeIDB(_Underlying *_this);
                        Jolt.JPH.Const_SubShapeID __ret;
                        __ret = new(__JPH_CharacterVirtual_ContactKey_Get_mSubShapeIDB(_UnderlyingPtr), is_owning: false);
                        __ret._KeepAliveEnclosingObject = this;
                        return __ret;
                    }
                }

                internal unsafe Const_ContactKey(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

                /// Constructs an empty (default-constructed) instance.
                public unsafe Const_ContactKey() : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ContactKey._Underlying *__JPH_CharacterVirtual_ContactKey_DefaultConstruct();
                    _UnderlyingPtr = __JPH_CharacterVirtual_ContactKey_DefaultConstruct();
                }

                /// Generated from constructor `JPH::CharacterVirtual::ContactKey::ContactKey`.
                public unsafe Const_ContactKey(Jolt.JPH.CharacterVirtual.Const_ContactKey inContact) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ContactKey._Underlying *__JPH_CharacterVirtual_ContactKey_ConstructFromAnother(Jolt.JPH.CharacterVirtual.ContactKey._Underlying *inContact);
                    _UnderlyingPtr = __JPH_CharacterVirtual_ContactKey_ConstructFromAnother(inContact._UnderlyingPtr);
                    _KeepAlive(inContact);
                }

                /// Generated from constructor `JPH::CharacterVirtual::ContactKey::ContactKey`.
                public Const_ContactKey(ContactKey inContact) : this((Const_ContactKey)inContact) {}

                /// Generated from constructor `JPH::CharacterVirtual::ContactKey::ContactKey`.
                public unsafe Const_ContactKey(in Jolt.JPH.BodyID inBodyB, Jolt.JPH.Const_SubShapeID inSubShapeID) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Construct_JPH_BodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Construct_JPH_BodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ContactKey._Underlying *__JPH_CharacterVirtual_ContactKey_Construct_JPH_BodyID(Jolt.JPH.BodyID *inBodyB, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID);
                    fixed (Jolt.JPH.BodyID *__ptr_inBodyB = &inBodyB)
                    {
                        _UnderlyingPtr = __JPH_CharacterVirtual_ContactKey_Construct_JPH_BodyID(__ptr_inBodyB, inSubShapeID._UnderlyingPtr);
                    }
                }

                /// Generated from constructor `JPH::CharacterVirtual::ContactKey::ContactKey`.
                public unsafe Const_ContactKey(Jolt.JPH.Const_CharacterID inCharacterIDB, Jolt.JPH.Const_SubShapeID inSubShapeID) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Construct_JPH_CharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Construct_JPH_CharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ContactKey._Underlying *__JPH_CharacterVirtual_ContactKey_Construct_JPH_CharacterID(Jolt.JPH.Const_CharacterID._Underlying *inCharacterIDB, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID);
                    _UnderlyingPtr = __JPH_CharacterVirtual_ContactKey_Construct_JPH_CharacterID(inCharacterIDB._UnderlyingPtr, inSubShapeID._UnderlyingPtr);
                }

                /// Checks if two contacts refer to the same body (or virtual character)
                /// Generated from method `JPH::CharacterVirtual::ContactKey::IsSameBody`.
                public unsafe bool IsSameBody(Jolt.JPH.CharacterVirtual.Const_ContactKey inOther)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_IsSameBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_IsSameBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static byte __JPH_CharacterVirtual_ContactKey_IsSameBody(_Underlying *_this, Jolt.JPH.CharacterVirtual.Const_ContactKey._Underlying *inOther);
                    return __JPH_CharacterVirtual_ContactKey_IsSameBody(_UnderlyingPtr, inOther._UnderlyingPtr) != 0;
                }

                /// Equality operator
                /// Generated from method `JPH::CharacterVirtual::ContactKey::operator==`.
                public static unsafe bool operator==(Jolt.JPH.CharacterVirtual.Const_ContactKey _this, Jolt.JPH.CharacterVirtual.Const_ContactKey inRHS)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_CharacterVirtual_ContactKey", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_CharacterVirtual_ContactKey", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static byte __Jolt_equal_JPH_CharacterVirtual_ContactKey(Jolt.JPH.CharacterVirtual.Const_ContactKey._Underlying *_this, Jolt.JPH.CharacterVirtual.Const_ContactKey._Underlying *inRHS);
                    return __Jolt_equal_JPH_CharacterVirtual_ContactKey(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
                }

                public static unsafe bool operator!=(Jolt.JPH.CharacterVirtual.Const_ContactKey _this, Jolt.JPH.CharacterVirtual.Const_ContactKey inRHS)
                {
                    return !(_this == inRHS);
                }

                /// Hash of this structure
                /// Generated from method `JPH::CharacterVirtual::ContactKey::GetHash`.
                public unsafe ulong GetHash()
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_GetHash", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_GetHash", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static ulong __JPH_CharacterVirtual_ContactKey_GetHash(_Underlying *_this);
                    return __JPH_CharacterVirtual_ContactKey_GetHash(_UnderlyingPtr);
                }

                // IEquatable:

                public bool Equals(Jolt.JPH.CharacterVirtual.Const_ContactKey? inRHS)
                {
                    if (inRHS is null)
                        return false;
                    return this == inRHS;
                }

                public override bool Equals(object? other)
                {
                    if (other is null)
                        return false;
                    if (other is Jolt.JPH.CharacterVirtual.Const_ContactKey)
                        return this == (Jolt.JPH.CharacterVirtual.Const_ContactKey)other;
                    return false;
                }
            }

            /// Uniquely identifies a contact between a character and another body or character
            /// Generated from class `JPH::CharacterVirtual::ContactKey`.
            /// Derived classes:
            ///   Direct: (non-virtual)
            ///     `JPH::CharacterVirtual::Contact`
            /// This is the non-const half of the class.
            public class ContactKey : Const_ContactKey
            {
                ///< ID of body we're colliding with (if not invalid)
                public new unsafe ref Jolt.JPH.BodyID mBodyB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_GetMutable_mBodyB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_GetMutable_mBodyB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.BodyID *__JPH_CharacterVirtual_ContactKey_GetMutable_mBodyB(_Underlying *_this);
                        return ref *__JPH_CharacterVirtual_ContactKey_GetMutable_mBodyB(_UnderlyingPtr);
                    }
                }

                ///< Character we're colliding with (if not invalid)
                public new unsafe Jolt.JPH.CharacterID mCharacterIDB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_GetMutable_mCharacterIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_GetMutable_mCharacterIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.CharacterID._Underlying *__JPH_CharacterVirtual_ContactKey_GetMutable_mCharacterIDB(_Underlying *_this);
                        Jolt.JPH.CharacterID __ret;
                        __ret = new(__JPH_CharacterVirtual_ContactKey_GetMutable_mCharacterIDB(_UnderlyingPtr), is_owning: false);
                        __ret._KeepAliveEnclosingObject = this;
                        return __ret;
                    }
                }

                ///< Sub shape ID of body or character we're colliding with
                public new unsafe Jolt.JPH.SubShapeID mSubShapeIDB
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_GetMutable_mSubShapeIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_GetMutable_mSubShapeIDB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static Jolt.JPH.SubShapeID._Underlying *__JPH_CharacterVirtual_ContactKey_GetMutable_mSubShapeIDB(_Underlying *_this);
                        Jolt.JPH.SubShapeID __ret;
                        __ret = new(__JPH_CharacterVirtual_ContactKey_GetMutable_mSubShapeIDB(_UnderlyingPtr), is_owning: false);
                        __ret._KeepAliveEnclosingObject = this;
                        return __ret;
                    }
                }

                internal unsafe ContactKey(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

                /// Constructs an empty (default-constructed) instance.
                public unsafe ContactKey() : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ContactKey._Underlying *__JPH_CharacterVirtual_ContactKey_DefaultConstruct();
                    _UnderlyingPtr = __JPH_CharacterVirtual_ContactKey_DefaultConstruct();
                }

                /// Generated from constructor `JPH::CharacterVirtual::ContactKey::ContactKey`.
                public unsafe ContactKey(Jolt.JPH.CharacterVirtual.Const_ContactKey inContact) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ContactKey._Underlying *__JPH_CharacterVirtual_ContactKey_ConstructFromAnother(Jolt.JPH.CharacterVirtual.ContactKey._Underlying *inContact);
                    _UnderlyingPtr = __JPH_CharacterVirtual_ContactKey_ConstructFromAnother(inContact._UnderlyingPtr);
                    _KeepAlive(inContact);
                }

                /// Generated from constructor `JPH::CharacterVirtual::ContactKey::ContactKey`.
                public ContactKey(ContactKey inContact) : this((Const_ContactKey)inContact) {}

                /// Generated from constructor `JPH::CharacterVirtual::ContactKey::ContactKey`.
                public unsafe ContactKey(in Jolt.JPH.BodyID inBodyB, Jolt.JPH.Const_SubShapeID inSubShapeID) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Construct_JPH_BodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Construct_JPH_BodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ContactKey._Underlying *__JPH_CharacterVirtual_ContactKey_Construct_JPH_BodyID(Jolt.JPH.BodyID *inBodyB, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID);
                    fixed (Jolt.JPH.BodyID *__ptr_inBodyB = &inBodyB)
                    {
                        _UnderlyingPtr = __JPH_CharacterVirtual_ContactKey_Construct_JPH_BodyID(__ptr_inBodyB, inSubShapeID._UnderlyingPtr);
                    }
                }

                /// Generated from constructor `JPH::CharacterVirtual::ContactKey::ContactKey`.
                public unsafe ContactKey(Jolt.JPH.Const_CharacterID inCharacterIDB, Jolt.JPH.Const_SubShapeID inSubShapeID) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Construct_JPH_CharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_Construct_JPH_CharacterID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ContactKey._Underlying *__JPH_CharacterVirtual_ContactKey_Construct_JPH_CharacterID(Jolt.JPH.Const_CharacterID._Underlying *inCharacterIDB, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID);
                    _UnderlyingPtr = __JPH_CharacterVirtual_ContactKey_Construct_JPH_CharacterID(inCharacterIDB._UnderlyingPtr, inSubShapeID._UnderlyingPtr);
                }

                /// Generated from method `JPH::CharacterVirtual::ContactKey::operator=`.
                public unsafe Jolt.JPH.CharacterVirtual.ContactKey Assign(Jolt.JPH.CharacterVirtual.Const_ContactKey inContact)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ContactKey_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ContactKey._Underlying *__JPH_CharacterVirtual_ContactKey_AssignFromAnother(_Underlying *_this, Jolt.JPH.CharacterVirtual.ContactKey._Underlying *inContact);
                    Jolt.JPH.CharacterVirtual.ContactKey __ret;
                    __ret = new(__JPH_CharacterVirtual_ContactKey_AssignFromAnother(_UnderlyingPtr, inContact._UnderlyingPtr), is_owning: false);
                    _DiscardKeepAlive();
                    _KeepAlive(inContact);
                    __ret._KeepAlive(this);
                    return __ret;
                }
            }

            /// This is used for optional parameters of class `ContactKey` with default arguments.
            /// This is only used mutable parameters. For const ones we have `_InOptConst_ContactKey`.
            /// Usage:
            /// * Pass `null` to use the default argument.
            /// * Pass `new()` to pass no object.
            /// * Pass an instance of `ContactKey`/`Const_ContactKey` directly.
            public class _InOptMut_ContactKey
            {
                public ContactKey? Opt;

                public _InOptMut_ContactKey() {}
                public _InOptMut_ContactKey(ContactKey value) {Opt = value;}
                public static implicit operator _InOptMut_ContactKey(ContactKey value) {return new(value);}
            }

            /// This is used for optional parameters of class `ContactKey` with default arguments.
            /// This is only used const parameters. For non-const ones we have `_InOptMut_ContactKey`.
            /// Usage:
            /// * Pass `null` to use the default argument.
            /// * Pass `new()` to pass no object.
            /// * Pass an instance of `ContactKey`/`Const_ContactKey` to pass it to the function.
            public class _InOptConst_ContactKey
            {
                public Const_ContactKey? Opt;

                public _InOptConst_ContactKey() {}
                public _InOptConst_ContactKey(Const_ContactKey value) {Opt = value;}
                public static implicit operator _InOptConst_ContactKey(Const_ContactKey value) {return new(value);}
            }

            /// Settings struct with settings for ExtendedUpdate
            /// Generated from class `JPH::CharacterVirtual::ExtendedUpdateSettings`.
            /// This is the const half of the class.
            public class Const_ExtendedUpdateSettings : Jolt.Object<Const_ExtendedUpdateSettings>, System.IDisposable
            {
                internal struct _Underlying {} // Represents the underlying C++ type.

                internal unsafe _Underlying *_UnderlyingPtr;

                protected virtual unsafe void Dispose(bool disposing)
                {
                    if (_UnderlyingPtr is null || !_IsOwningVal)
                        return;
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static void __JPH_CharacterVirtual_ExtendedUpdateSettings_Destroy(_Underlying *_this);
                    __JPH_CharacterVirtual_ExtendedUpdateSettings_Destroy(_UnderlyingPtr);
                    _UnderlyingPtr = null;
                }
                public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
                ~Const_ExtendedUpdateSettings() {Dispose(false);}

                ///< See WalkStairs inStepForward parameter. Note that the parameter only indicates a magnitude, direction is taken from current velocity.
                public unsafe float mWalkStairsMinStepForward
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsMinStepForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsMinStepForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static float *__JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsMinStepForward(_Underlying *_this);
                        return *__JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsMinStepForward(_UnderlyingPtr);
                    }
                }

                ///< See WalkStairs inStepForwardTest parameter. Note that the parameter only indicates a magnitude, direction is taken from current velocity.
                public unsafe float mWalkStairsStepForwardTest
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsStepForwardTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsStepForwardTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static float *__JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsStepForwardTest(_Underlying *_this);
                        return *__JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsStepForwardTest(_UnderlyingPtr);
                    }
                }

                ///< Cos(angle) where angle is the maximum angle between the ground normal in the horizontal plane and the character forward vector where we're willing to adjust the step forward test towards the contact normal.
                public unsafe float mWalkStairsCosAngleForwardContact
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsCosAngleForwardContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsCosAngleForwardContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static float *__JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsCosAngleForwardContact(_Underlying *_this);
                        return *__JPH_CharacterVirtual_ExtendedUpdateSettings_Get_mWalkStairsCosAngleForwardContact(_UnderlyingPtr);
                    }
                }

                internal unsafe Const_ExtendedUpdateSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

                /// Constructs an empty (default-constructed) instance.
                public unsafe Const_ExtendedUpdateSettings() : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ExtendedUpdateSettings._Underlying *__JPH_CharacterVirtual_ExtendedUpdateSettings_DefaultConstruct();
                    _UnderlyingPtr = __JPH_CharacterVirtual_ExtendedUpdateSettings_DefaultConstruct();
                }

                /// Generated from constructor `JPH::CharacterVirtual::ExtendedUpdateSettings::ExtendedUpdateSettings`.
                public unsafe Const_ExtendedUpdateSettings(Jolt.JPH.CharacterVirtual.Const_ExtendedUpdateSettings _other) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ExtendedUpdateSettings._Underlying *__JPH_CharacterVirtual_ExtendedUpdateSettings_ConstructFromAnother(Jolt.JPH.CharacterVirtual.ExtendedUpdateSettings._Underlying *_other);
                    _UnderlyingPtr = __JPH_CharacterVirtual_ExtendedUpdateSettings_ConstructFromAnother(_other._UnderlyingPtr);
                    _KeepAlive(_other);
                }

                /// Generated from constructor `JPH::CharacterVirtual::ExtendedUpdateSettings::ExtendedUpdateSettings`.
                public Const_ExtendedUpdateSettings(ExtendedUpdateSettings _other) : this((Const_ExtendedUpdateSettings)_other) {}
            }

            /// Settings struct with settings for ExtendedUpdate
            /// Generated from class `JPH::CharacterVirtual::ExtendedUpdateSettings`.
            /// This is the non-const half of the class.
            public class ExtendedUpdateSettings : Const_ExtendedUpdateSettings
            {
                ///< See WalkStairs inStepForward parameter. Note that the parameter only indicates a magnitude, direction is taken from current velocity.
                public new unsafe ref float mWalkStairsMinStepForward
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsMinStepForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsMinStepForward", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static float *__JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsMinStepForward(_Underlying *_this);
                        return ref *__JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsMinStepForward(_UnderlyingPtr);
                    }
                }

                ///< See WalkStairs inStepForwardTest parameter. Note that the parameter only indicates a magnitude, direction is taken from current velocity.
                public new unsafe ref float mWalkStairsStepForwardTest
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsStepForwardTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsStepForwardTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static float *__JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsStepForwardTest(_Underlying *_this);
                        return ref *__JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsStepForwardTest(_UnderlyingPtr);
                    }
                }

                ///< Cos(angle) where angle is the maximum angle between the ground normal in the horizontal plane and the character forward vector where we're willing to adjust the step forward test towards the contact normal.
                public new unsafe ref float mWalkStairsCosAngleForwardContact
                {
                    get
                    {
                        #if __IOS__
                        [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsCosAngleForwardContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #else
                        [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsCosAngleForwardContact", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                        #endif
                        extern static float *__JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsCosAngleForwardContact(_Underlying *_this);
                        return ref *__JPH_CharacterVirtual_ExtendedUpdateSettings_GetMutable_mWalkStairsCosAngleForwardContact(_UnderlyingPtr);
                    }
                }

                internal unsafe ExtendedUpdateSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

                /// Constructs an empty (default-constructed) instance.
                public unsafe ExtendedUpdateSettings() : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ExtendedUpdateSettings._Underlying *__JPH_CharacterVirtual_ExtendedUpdateSettings_DefaultConstruct();
                    _UnderlyingPtr = __JPH_CharacterVirtual_ExtendedUpdateSettings_DefaultConstruct();
                }

                /// Generated from constructor `JPH::CharacterVirtual::ExtendedUpdateSettings::ExtendedUpdateSettings`.
                public unsafe ExtendedUpdateSettings(Jolt.JPH.CharacterVirtual.Const_ExtendedUpdateSettings _other) : this(null, is_owning: true)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ExtendedUpdateSettings._Underlying *__JPH_CharacterVirtual_ExtendedUpdateSettings_ConstructFromAnother(Jolt.JPH.CharacterVirtual.ExtendedUpdateSettings._Underlying *_other);
                    _UnderlyingPtr = __JPH_CharacterVirtual_ExtendedUpdateSettings_ConstructFromAnother(_other._UnderlyingPtr);
                    _KeepAlive(_other);
                }

                /// Generated from constructor `JPH::CharacterVirtual::ExtendedUpdateSettings::ExtendedUpdateSettings`.
                public ExtendedUpdateSettings(ExtendedUpdateSettings _other) : this((Const_ExtendedUpdateSettings)_other) {}

                /// Generated from method `JPH::CharacterVirtual::ExtendedUpdateSettings::operator=`.
                public unsafe Jolt.JPH.CharacterVirtual.ExtendedUpdateSettings Assign(Jolt.JPH.CharacterVirtual.Const_ExtendedUpdateSettings _other)
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_ExtendedUpdateSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.CharacterVirtual.ExtendedUpdateSettings._Underlying *__JPH_CharacterVirtual_ExtendedUpdateSettings_AssignFromAnother(_Underlying *_this, Jolt.JPH.CharacterVirtual.ExtendedUpdateSettings._Underlying *_other);
                    _DiscardKeepAlive();
                    _KeepAlive(_other);
                    return new(__JPH_CharacterVirtual_ExtendedUpdateSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
                }
            }

            /// This is used for optional parameters of class `ExtendedUpdateSettings` with default arguments.
            /// This is only used mutable parameters. For const ones we have `_InOptConst_ExtendedUpdateSettings`.
            /// Usage:
            /// * Pass `null` to use the default argument.
            /// * Pass `new()` to pass no object.
            /// * Pass an instance of `ExtendedUpdateSettings`/`Const_ExtendedUpdateSettings` directly.
            public class _InOptMut_ExtendedUpdateSettings
            {
                public ExtendedUpdateSettings? Opt;

                public _InOptMut_ExtendedUpdateSettings() {}
                public _InOptMut_ExtendedUpdateSettings(ExtendedUpdateSettings value) {Opt = value;}
                public static implicit operator _InOptMut_ExtendedUpdateSettings(ExtendedUpdateSettings value) {return new(value);}
            }

            /// This is used for optional parameters of class `ExtendedUpdateSettings` with default arguments.
            /// This is only used const parameters. For non-const ones we have `_InOptMut_ExtendedUpdateSettings`.
            /// Usage:
            /// * Pass `null` to use the default argument.
            /// * Pass `new()` to pass no object.
            /// * Pass an instance of `ExtendedUpdateSettings`/`Const_ExtendedUpdateSettings` to pass it to the function.
            public class _InOptConst_ExtendedUpdateSettings
            {
                public Const_ExtendedUpdateSettings? Opt;

                public _InOptConst_ExtendedUpdateSettings() {}
                public _InOptConst_ExtendedUpdateSettings(Const_ExtendedUpdateSettings value) {Opt = value;}
                public static implicit operator _InOptConst_ExtendedUpdateSettings(Const_ExtendedUpdateSettings value) {return new(value);}
            }
        }

        /// Runtime character object.
        /// This object usually represents the player. Contrary to the Character class it doesn't use a rigid body but moves doing collision checks only (hence the name virtual).
        /// The advantage of this is that you can determine when the character moves in the frame (usually this has to happen at a very particular point in the frame)
        /// but the downside is that other objects don't see this virtual character. To make a CharacterVirtual visible to the simulation, you can optionally create an inner
        /// rigid body through CharacterVirtualSettings::mInnerBodyShape. A CharacterVirtual is not tracked by the PhysicsSystem so you need to update it yourself. This also means
        /// that a call to PhysicsSystem::SaveState will not save its state, you need to call CharacterVirtual::SaveState yourself.
        /// Generated from class `JPH::CharacterVirtual`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::CharacterBase`
        ///   Indirect: (non-virtual)
        ///     `JPH::RefTarget<JPH::CharacterBase>`
        ///     `JPH::NonCopyable`
        /// This is the non-const half of the class.
        public class CharacterVirtual : Const_CharacterVirtual
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.RefTarget_JPHCharacterBase(CharacterVirtual self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_UpcastTo_JPH_RefTarget_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.RefTarget_JPHCharacterBase._Underlying *__JPH_CharacterVirtual_UpcastTo_JPH_RefTarget_JPH_CharacterBase(_Underlying *_this);
                Jolt.JPH.RefTarget_JPHCharacterBase ret = new(__JPH_CharacterVirtual_UpcastTo_JPH_RefTarget_JPH_CharacterBase(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.NonCopyable(CharacterVirtual self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_CharacterVirtual_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_CharacterVirtual_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }
            public static unsafe implicit operator Jolt.JPH.CharacterBase(CharacterVirtual self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_UpcastTo_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_UpcastTo_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CharacterBase._Underlying *__JPH_CharacterVirtual_UpcastTo_JPH_CharacterBase(_Underlying *_this);
                Jolt.JPH.CharacterBase ret = new(__JPH_CharacterVirtual_UpcastTo_JPH_CharacterBase(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator CharacterVirtual?(Jolt.JPH.CharacterBase parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_DynamicDowncastFrom_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_DynamicDowncastFrom_JPH_CharacterBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__JPH_CharacterVirtual_DynamicDowncastFrom_JPH_CharacterBase(Jolt.JPH.CharacterBase._Underlying *_this);
                var ptr = __JPH_CharacterVirtual_DynamicDowncastFrom_JPH_CharacterBase(parent._UnderlyingPtr);
                if (ptr is null) return null;
                CharacterVirtual ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            internal unsafe CharacterVirtual(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Set the contact listener
            /// Generated from method `JPH::CharacterVirtual::SetListener`.
            public unsafe void SetListener(Jolt.JPH.CharacterContactListener? inListener)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_SetListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_SetListener", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_SetListener(_Underlying *_this, Jolt.JPH.CharacterContactListener._Underlying *inListener);
                __JPH_CharacterVirtual_SetListener(_UnderlyingPtr, inListener is not null ? inListener._UnderlyingPtr : null);
            }

            /// Set the character vs character collision interface
            /// Generated from method `JPH::CharacterVirtual::SetCharacterVsCharacterCollision`.
            public unsafe void SetCharacterVsCharacterCollision(Jolt.JPH.CharacterVsCharacterCollision? inCharacterVsCharacterCollision)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_SetCharacterVsCharacterCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_SetCharacterVsCharacterCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_SetCharacterVsCharacterCollision(_Underlying *_this, Jolt.JPH.CharacterVsCharacterCollision._Underlying *inCharacterVsCharacterCollision);
                __JPH_CharacterVirtual_SetCharacterVsCharacterCollision(_UnderlyingPtr, inCharacterVsCharacterCollision is not null ? inCharacterVsCharacterCollision._UnderlyingPtr : null);
            }

            /// Generated from method `JPH::CharacterVirtual::SetMass`.
            public unsafe void SetMass(float inMass)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_SetMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_SetMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_SetMass(_Underlying *_this, float inMass);
                __JPH_CharacterVirtual_SetMass(_UnderlyingPtr, inMass);
            }

            /// Generated from method `JPH::CharacterVirtual::SetMaxStrength`.
            public unsafe void SetMaxStrength(float inMaxStrength)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_SetMaxStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_SetMaxStrength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_SetMaxStrength(_Underlying *_this, float inMaxStrength);
                __JPH_CharacterVirtual_SetMaxStrength(_UnderlyingPtr, inMaxStrength);
            }

            /// Generated from method `JPH::CharacterVirtual::SetPenetrationRecoverySpeed`.
            public unsafe void SetPenetrationRecoverySpeed(float inSpeed)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_SetPenetrationRecoverySpeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_SetPenetrationRecoverySpeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_SetPenetrationRecoverySpeed(_Underlying *_this, float inSpeed);
                __JPH_CharacterVirtual_SetPenetrationRecoverySpeed(_UnderlyingPtr, inSpeed);
            }

            /// Generated from method `JPH::CharacterVirtual::SetEnhancedInternalEdgeRemoval`.
            public unsafe void SetEnhancedInternalEdgeRemoval(bool inApply)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_SetEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_SetEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_SetEnhancedInternalEdgeRemoval(_Underlying *_this, byte inApply);
                __JPH_CharacterVirtual_SetEnhancedInternalEdgeRemoval(_UnderlyingPtr, inApply ? (byte)1 : (byte)0);
            }

            /// Generated from method `JPH::CharacterVirtual::SetMaxNumHits`.
            public unsafe void SetMaxNumHits(uint inMaxHits)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_SetMaxNumHits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_SetMaxNumHits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_SetMaxNumHits(_Underlying *_this, uint inMaxHits);
                __JPH_CharacterVirtual_SetMaxNumHits(_UnderlyingPtr, inMaxHits);
            }

            /// Generated from method `JPH::CharacterVirtual::SetHitReductionCosMaxAngle`.
            public unsafe void SetHitReductionCosMaxAngle(float inCosMaxAngle)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_SetHitReductionCosMaxAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_SetHitReductionCosMaxAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_SetHitReductionCosMaxAngle(_Underlying *_this, float inCosMaxAngle);
                __JPH_CharacterVirtual_SetHitReductionCosMaxAngle(_UnderlyingPtr, inCosMaxAngle);
            }

            /// Generated from method `JPH::CharacterVirtual::SetUserData`.
            public unsafe void SetUserData(ulong inUserData)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_SetUserData(_Underlying *_this, ulong inUserData);
                __JPH_CharacterVirtual_SetUserData(_UnderlyingPtr, inUserData);
            }

            /// This function is internally called by Update, WalkStairs, StickToFloor and ExtendedUpdate and is responsible for tracking if contacts are added, persisted or removed.
            /// If you want to do multiple operations on a character (e.g. first Update then WalkStairs), you can surround the code with a StartTrackingContactChanges and FinishTrackingContactChanges pair
            /// to only receive a single callback per contact on the CharacterContactListener. If you don't do this then you could for example receive a contact added callback during the Update and a
            /// contact persisted callback during WalkStairs.
            /// Generated from method `JPH::CharacterVirtual::StartTrackingContactChanges`.
            public unsafe void StartTrackingContactChanges()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_StartTrackingContactChanges", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_StartTrackingContactChanges", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_StartTrackingContactChanges(_Underlying *_this);
                __JPH_CharacterVirtual_StartTrackingContactChanges(_UnderlyingPtr);
            }

            /// This call triggers contact removal callbacks and is used in conjunction with StartTrackingContactChanges.
            /// Generated from method `JPH::CharacterVirtual::FinishTrackingContactChanges`.
            public unsafe void FinishTrackingContactChanges()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_FinishTrackingContactChanges", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_FinishTrackingContactChanges", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_FinishTrackingContactChanges(_Underlying *_this);
                __JPH_CharacterVirtual_FinishTrackingContactChanges(_UnderlyingPtr);
            }

            /// This function can be used after a character has teleported to determine the new contacts with the world.
            /// Generated from method `JPH::CharacterVirtual::RefreshContacts`.
            public unsafe void RefreshContacts(Jolt.JPH.Const_BroadPhaseLayerFilter inBroadPhaseLayerFilter, Jolt.JPH.Const_ObjectLayerFilter inObjectLayerFilter, Jolt.JPH.Const_BodyFilter inBodyFilter, Jolt.JPH.Const_ShapeFilter inShapeFilter, Jolt.JPH.TempAllocator inAllocator)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_RefreshContacts", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_RefreshContacts", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_RefreshContacts(_Underlying *_this, Jolt.JPH.Const_BroadPhaseLayerFilter._Underlying *inBroadPhaseLayerFilter, Jolt.JPH.Const_ObjectLayerFilter._Underlying *inObjectLayerFilter, Jolt.JPH.Const_BodyFilter._Underlying *inBodyFilter, Jolt.JPH.Const_ShapeFilter._Underlying *inShapeFilter, Jolt.JPH.TempAllocator._Underlying *inAllocator);
                __JPH_CharacterVirtual_RefreshContacts(_UnderlyingPtr, inBroadPhaseLayerFilter._UnderlyingPtr, inObjectLayerFilter._UnderlyingPtr, inBodyFilter._UnderlyingPtr, inShapeFilter._UnderlyingPtr, inAllocator._UnderlyingPtr);
            }

            /// Use the ground body ID to get an updated estimate of the ground velocity. This function can be used if the ground body has moved / changed velocity and you want a new estimate of the ground velocity.
            /// It will not perform collision detection, so is less accurate than RefreshContacts but a lot faster.
            /// Generated from method `JPH::CharacterVirtual::UpdateGroundVelocity`.
            public unsafe void UpdateGroundVelocity()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_UpdateGroundVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_UpdateGroundVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_UpdateGroundVelocity(_Underlying *_this);
                __JPH_CharacterVirtual_UpdateGroundVelocity(_UnderlyingPtr);
            }

            /// Switch the shape of the character (e.g. for stance).
            /// @param inShape The shape to switch to.
            /// @param inMaxPenetrationDepth When inMaxPenetrationDepth is not FLT_MAX, it checks if the new shape collides before switching shape. This is the max penetration we're willing to accept after the switch.
            /// @param inBroadPhaseLayerFilter Filter that is used to check if the character collides with something in the broadphase.
            /// @param inObjectLayerFilter Filter that is used to check if a character collides with a layer.
            /// @param inBodyFilter Filter that is used to check if a character collides with a body.
            /// @param inShapeFilter Filter that is used to check if a character collides with a subshape.
            /// @param inAllocator An allocator for temporary allocations. All memory will be freed by the time this function returns.
            /// @return Returns true if the switch succeeded.
            /// Generated from method `JPH::CharacterVirtual::SetShape`.
            public unsafe bool SetShape(Jolt.JPH.Const_Shape? inShape, float inMaxPenetrationDepth, Jolt.JPH.Const_BroadPhaseLayerFilter inBroadPhaseLayerFilter, Jolt.JPH.Const_ObjectLayerFilter inObjectLayerFilter, Jolt.JPH.Const_BodyFilter inBodyFilter, Jolt.JPH.Const_ShapeFilter inShapeFilter, Jolt.JPH.TempAllocator inAllocator)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_SetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_SetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_CharacterVirtual_SetShape(_Underlying *_this, Jolt.JPH.Const_Shape._Underlying *inShape, float inMaxPenetrationDepth, Jolt.JPH.Const_BroadPhaseLayerFilter._Underlying *inBroadPhaseLayerFilter, Jolt.JPH.Const_ObjectLayerFilter._Underlying *inObjectLayerFilter, Jolt.JPH.Const_BodyFilter._Underlying *inBodyFilter, Jolt.JPH.Const_ShapeFilter._Underlying *inShapeFilter, Jolt.JPH.TempAllocator._Underlying *inAllocator);
                return __JPH_CharacterVirtual_SetShape(_UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null, inMaxPenetrationDepth, inBroadPhaseLayerFilter._UnderlyingPtr, inObjectLayerFilter._UnderlyingPtr, inBodyFilter._UnderlyingPtr, inShapeFilter._UnderlyingPtr, inAllocator._UnderlyingPtr) != 0;
            }

            /// Updates the shape of the inner rigid body. Should be called after a successful call to SetShape.
            /// Generated from method `JPH::CharacterVirtual::SetInnerBodyShape`.
            public unsafe void SetInnerBodyShape(Jolt.JPH.Const_Shape? inShape)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_SetInnerBodyShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_SetInnerBodyShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_SetInnerBodyShape(_Underlying *_this, Jolt.JPH.Const_Shape._Underlying *inShape);
                __JPH_CharacterVirtual_SetInnerBodyShape(_UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null);
            }

            /// Set the maximum angle of slope that character can still walk on (radians)
            /// Generated from method `JPH::CharacterVirtual::SetMaxSlopeAngle`.
            public unsafe void SetMaxSlopeAngle(float inMaxSlopeAngle)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CharacterVirtual_SetMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CharacterVirtual_SetMaxSlopeAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_CharacterVirtual_SetMaxSlopeAngle(_Underlying *_this, float inMaxSlopeAngle);
                __JPH_CharacterVirtual_SetMaxSlopeAngle(_UnderlyingPtr, inMaxSlopeAngle);
            }
        }

        /// This is used for optional parameters of class `CharacterVirtual` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_CharacterVirtual`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterVirtual`/`Const_CharacterVirtual` directly.
        public class _InOptMut_CharacterVirtual
        {
            public CharacterVirtual? Opt;

            public _InOptMut_CharacterVirtual() {}
            public _InOptMut_CharacterVirtual(CharacterVirtual value) {Opt = value;}
            public static implicit operator _InOptMut_CharacterVirtual(CharacterVirtual value) {return new(value);}
        }

        /// This is used for optional parameters of class `CharacterVirtual` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_CharacterVirtual`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `CharacterVirtual`/`Const_CharacterVirtual` to pass it to the function.
        public class _InOptConst_CharacterVirtual
        {
            public Const_CharacterVirtual? Opt;

            public _InOptConst_CharacterVirtual() {}
            public _InOptConst_CharacterVirtual(Const_CharacterVirtual value) {Opt = value;}
            public static implicit operator _InOptConst_CharacterVirtual(Const_CharacterVirtual value) {return new(value);}
        }
    }
}
