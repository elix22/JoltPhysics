// machine generated, do not edit
public static partial class Jolt
{
    public static partial class JPH
    {
        /// Generated from class `JPH::Body`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::NonCopyable`
        /// This is the const half of the class.
        public class Const_Body : Jolt.Object<Const_Body>
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.Const_NonCopyable(Const_Body self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_NonCopyable._Underlying *__JPH_Body_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.Const_NonCopyable ret = new(__JPH_Body_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            /// A dummy body that can be used by constraints to attach a constraint to the world instead of another body
            public static unsafe Jolt.JPH.Body SFixedToWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetMutable_sFixedToWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetMutable_sFixedToWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Jolt.JPH.Body._Underlying *__JPH_Body_GetMutable_sFixedToWorld();
                    return new(__JPH_Body_GetMutable_sFixedToWorld(), is_owning: false);
                }
            }

            ///< Constant indicating that body is not active
            public static unsafe uint CInactiveIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_Get_cInactiveIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_Get_cInactiveIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__JPH_Body_Get_cInactiveIndex();
                    return *__JPH_Body_Get_cInactiveIndex();
                }
            }

            internal unsafe Const_Body(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from method `JPH::Body::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Body_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Body_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_Body_unsigned_long(ulong inCount);
                return __Jolt_new_JPH_Body_unsigned_long(inCount);
            }

            /// Generated from method `JPH::Body::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Body_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Body_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Body_void_ptr(void *inPointer);
                __Jolt_delete_JPH_Body_void_ptr(inPointer);
            }

            /// Generated from method `JPH::Body::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Body_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Body_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Body_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_Body_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::Body::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Body_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Body_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_Body_unsigned_long(ulong inCount);
                return __Jolt_new_array_JPH_Body_unsigned_long(inCount);
            }

            /// Generated from method `JPH::Body::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Body_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Body_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Body_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_Body_void_ptr(inPointer);
            }

            /// Generated from method `JPH::Body::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, ulong inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Body_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Body_void_ptr_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Body_void_ptr_unsigned_long(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_Body_void_ptr_unsigned_long(inPointer, inSize);
            }

            /// Generated from method `JPH::Body::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Body_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Body_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_Body_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_Body_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::Body::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Body_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Body_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Body_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_Body_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::Body::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Body_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Body_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_Body_unsigned_long_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_Body_unsigned_long_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::Body::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Body_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Body_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Body_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_Body_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Get the id of this body
            /// Generated from method `JPH::Body::GetID`.
            public unsafe ref readonly Jolt.JPH.BodyID GetID()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BodyID *__JPH_Body_GetID(_Underlying *_this);
                return ref *__JPH_Body_GetID(_UnderlyingPtr);
            }

            /// Check if this body is a rigid body
            /// Generated from method `JPH::Body::IsRigidBody`.
            public unsafe bool IsRigidBody()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_IsRigidBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_IsRigidBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_IsRigidBody(_Underlying *_this);
                return __JPH_Body_IsRigidBody(_UnderlyingPtr) != 0;
            }

            /// Check if this body is a soft body
            /// Generated from method `JPH::Body::IsSoftBody`.
            public unsafe bool IsSoftBody()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_IsSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_IsSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_IsSoftBody(_Underlying *_this);
                return __JPH_Body_IsSoftBody(_UnderlyingPtr) != 0;
            }

            /// If this body is currently actively simulating (true) or sleeping (false)
            /// Generated from method `JPH::Body::IsActive`.
            public unsafe bool IsActive()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_IsActive(_Underlying *_this);
                return __JPH_Body_IsActive(_UnderlyingPtr) != 0;
            }

            /// Check if this body is static (not movable)
            /// Generated from method `JPH::Body::IsStatic`.
            public unsafe bool IsStatic()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_IsStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_IsStatic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_IsStatic(_Underlying *_this);
                return __JPH_Body_IsStatic(_UnderlyingPtr) != 0;
            }

            /// Check if this body is kinematic (keyframed), which means that it will move according to its current velocity, but forces don't affect it
            /// Generated from method `JPH::Body::IsKinematic`.
            public unsafe bool IsKinematic()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_IsKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_IsKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_IsKinematic(_Underlying *_this);
                return __JPH_Body_IsKinematic(_UnderlyingPtr) != 0;
            }

            /// Check if this body is dynamic, which means that it moves and forces can act on it
            /// Generated from method `JPH::Body::IsDynamic`.
            public unsafe bool IsDynamic()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_IsDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_IsDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_IsDynamic(_Underlying *_this);
                return __JPH_Body_IsDynamic(_UnderlyingPtr) != 0;
            }

            /// Check if a body could be made kinematic or dynamic (if it was created dynamic or with mAllowDynamicOrKinematic set to true)
            /// Generated from method `JPH::Body::CanBeKinematicOrDynamic`.
            public unsafe bool CanBeKinematicOrDynamic()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_CanBeKinematicOrDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_CanBeKinematicOrDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_CanBeKinematicOrDynamic(_Underlying *_this);
                return __JPH_Body_CanBeKinematicOrDynamic(_UnderlyingPtr) != 0;
            }

            /// Check if this body is a sensor.
            /// Generated from method `JPH::Body::IsSensor`.
            public unsafe bool IsSensor()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_IsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_IsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_IsSensor(_Underlying *_this);
                return __JPH_Body_IsSensor(_UnderlyingPtr) != 0;
            }

            /// Check if kinematic objects can generate contact points against other kinematic or static objects.
            /// Generated from method `JPH::Body::GetCollideKinematicVsNonDynamic`.
            public unsafe bool GetCollideKinematicVsNonDynamic()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetCollideKinematicVsNonDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetCollideKinematicVsNonDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_GetCollideKinematicVsNonDynamic(_Underlying *_this);
                return __JPH_Body_GetCollideKinematicVsNonDynamic(_UnderlyingPtr) != 0;
            }

            /// Check if this body can use manifold reduction.
            /// Generated from method `JPH::Body::GetUseManifoldReduction`.
            public unsafe bool GetUseManifoldReduction()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_GetUseManifoldReduction(_Underlying *_this);
                return __JPH_Body_GetUseManifoldReduction(_UnderlyingPtr) != 0;
            }

            /// Checks if the combination of this body and inBody2 should use manifold reduction
            /// Generated from method `JPH::Body::GetUseManifoldReductionWithBody`.
            public unsafe bool GetUseManifoldReductionWithBody(Jolt.JPH.Const_Body inBody2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetUseManifoldReductionWithBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetUseManifoldReductionWithBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_GetUseManifoldReductionWithBody(_Underlying *_this, Jolt.JPH.Const_Body._Underlying *inBody2);
                return __JPH_Body_GetUseManifoldReductionWithBody(_UnderlyingPtr, inBody2._UnderlyingPtr) != 0;
            }

            /// Check if the gyroscopic force is being applied for this body
            /// Generated from method `JPH::Body::GetApplyGyroscopicForce`.
            public unsafe bool GetApplyGyroscopicForce()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetApplyGyroscopicForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetApplyGyroscopicForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_GetApplyGyroscopicForce(_Underlying *_this);
                return __JPH_Body_GetApplyGyroscopicForce(_UnderlyingPtr) != 0;
            }

            /// Check if enhanced internal edge removal is turned on
            /// Generated from method `JPH::Body::GetEnhancedInternalEdgeRemoval`.
            public unsafe bool GetEnhancedInternalEdgeRemoval()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_GetEnhancedInternalEdgeRemoval(_Underlying *_this);
                return __JPH_Body_GetEnhancedInternalEdgeRemoval(_UnderlyingPtr) != 0;
            }

            /// Checks if the combination of this body and inBody2 should use enhanced internal edge removal
            /// Generated from method `JPH::Body::GetEnhancedInternalEdgeRemovalWithBody`.
            public unsafe bool GetEnhancedInternalEdgeRemovalWithBody(Jolt.JPH.Const_Body inBody2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetEnhancedInternalEdgeRemovalWithBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetEnhancedInternalEdgeRemovalWithBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_GetEnhancedInternalEdgeRemovalWithBody(_Underlying *_this, Jolt.JPH.Const_Body._Underlying *inBody2);
                return __JPH_Body_GetEnhancedInternalEdgeRemovalWithBody(_UnderlyingPtr, inBody2._UnderlyingPtr) != 0;
            }

            /// Get broadphase layer, this determines in which broad phase sub-tree the object is placed
            /// Generated from method `JPH::Body::GetBroadPhaseLayer`.
            public unsafe Jolt.JPH.BroadPhaseLayer GetBroadPhaseLayer()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetBroadPhaseLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetBroadPhaseLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BroadPhaseLayer._Underlying *__JPH_Body_GetBroadPhaseLayer(_Underlying *_this);
                return new(__JPH_Body_GetBroadPhaseLayer(_UnderlyingPtr), is_owning: true);
            }

            /// Get object layer, this determines which other objects it collides with
            /// Generated from method `JPH::Body::GetObjectLayer`.
            public unsafe ushort GetObjectLayer()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ushort __JPH_Body_GetObjectLayer(_Underlying *_this);
                return __JPH_Body_GetObjectLayer(_UnderlyingPtr);
            }

            /// Collision group and sub-group ID, determines which other objects it collides with
            /// Generated from method `JPH::Body::GetCollisionGroup`.
            public unsafe Jolt.JPH.Const_CollisionGroup GetCollisionGroup()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_CollisionGroup._Underlying *__JPH_Body_GetCollisionGroup(_Underlying *_this);
                return new(__JPH_Body_GetCollisionGroup(_UnderlyingPtr), is_owning: false);
            }

            /// If this body can go to sleep. Note that disabling sleeping on a sleeping object will not wake it up.
            /// Generated from method `JPH::Body::GetAllowSleeping`.
            public unsafe bool GetAllowSleeping()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_GetAllowSleeping(_Underlying *_this);
                return __JPH_Body_GetAllowSleeping(_UnderlyingPtr) != 0;
            }

            /// Friction (dimensionless number, usually between 0 and 1, 0 = no friction, 1 = friction force equals force that presses the two bodies together). Note that bodies can have negative friction but the combined friction (see PhysicsSystem::SetCombineFriction) should never go below zero.
            /// Generated from method `JPH::Body::GetFriction`.
            public unsafe float GetFriction()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Body_GetFriction(_Underlying *_this);
                return __JPH_Body_GetFriction(_UnderlyingPtr);
            }

            /// Restitution (dimensionless number, usually between 0 and 1, 0 = completely inelastic collision response, 1 = completely elastic collision response). Note that bodies can have negative restitution but the combined restitution (see PhysicsSystem::SetCombineRestitution) should never go below zero.
            /// Generated from method `JPH::Body::GetRestitution`.
            public unsafe float GetRestitution()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float __JPH_Body_GetRestitution(_Underlying *_this);
                return __JPH_Body_GetRestitution(_UnderlyingPtr);
            }

            /// Check if this body has been added to the physics system
            /// Generated from method `JPH::Body::IsInBroadPhase`.
            public unsafe bool IsInBroadPhase()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_IsInBroadPhase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_IsInBroadPhase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_IsInBroadPhase(_Underlying *_this);
                return __JPH_Body_IsInBroadPhase(_UnderlyingPtr) != 0;
            }

            /// Check if this body has been changed in such a way that the collision cache should be considered invalid for any body interacting with this body
            /// Generated from method `JPH::Body::IsCollisionCacheInvalid`.
            public unsafe bool IsCollisionCacheInvalid()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_IsCollisionCacheInvalid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_IsCollisionCacheInvalid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_IsCollisionCacheInvalid(_Underlying *_this);
                return __JPH_Body_IsCollisionCacheInvalid(_UnderlyingPtr) != 0;
            }

            /// Get the shape of this body
            /// Generated from method `JPH::Body::GetShape`.
            public unsafe Jolt.JPH.Const_Shape? GetShape()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_Shape._Underlying *__JPH_Body_GetShape(_Underlying *_this);
                var __c_ret = __JPH_Body_GetShape(_UnderlyingPtr);
                return __c_ret is not null ? new Jolt.JPH.Const_Shape(__c_ret, is_owning: false) : null;
            }

            /// Get world space bounding box
            /// Generated from method `JPH::Body::GetWorldSpaceBounds`.
            public unsafe Jolt.JPH.Const_AABox GetWorldSpaceBounds()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetWorldSpaceBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetWorldSpaceBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Const_AABox._Underlying *__JPH_Body_GetWorldSpaceBounds(_Underlying *_this);
                return new(__JPH_Body_GetWorldSpaceBounds(_UnderlyingPtr), is_owning: false);
            }

            /// Access to the user data, can be used for anything by the application
            /// Generated from method `JPH::Body::GetUserData`.
            public unsafe ulong GetUserData()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static ulong __JPH_Body_GetUserData(_Underlying *_this);
                return __JPH_Body_GetUserData(_UnderlyingPtr);
            }

            /// Debug function to convert a body back to a body creation settings object to be able to save/recreate the body later
            /// Generated from method `JPH::Body::GetBodyCreationSettings`.
            public unsafe Jolt.JPH.BodyCreationSettings GetBodyCreationSettings()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetBodyCreationSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetBodyCreationSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.BodyCreationSettings._Underlying *__JPH_Body_GetBodyCreationSettings(_Underlying *_this);
                return new(__JPH_Body_GetBodyCreationSettings(_UnderlyingPtr), is_owning: true);
            }

            /// Debug function to convert a soft body back to a soft body creation settings object to be able to save/recreate the body later
            /// Generated from method `JPH::Body::GetSoftBodyCreationSettings`.
            public unsafe Jolt.JPH.SoftBodyCreationSettings GetSoftBodyCreationSettings()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetSoftBodyCreationSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetSoftBodyCreationSettings", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.SoftBodyCreationSettings._Underlying *__JPH_Body_GetSoftBodyCreationSettings(_Underlying *_this);
                return new(__JPH_Body_GetSoftBodyCreationSettings(_UnderlyingPtr), is_owning: true);
            }

            /// Helper function for BroadPhase::FindCollidingPairs that returns true when two bodies can collide
            /// It assumes that body 1 is dynamic and active and guarantees that it body 1 collides with body 2 that body 2 will not collide with body 1 in order to avoid finding duplicate collision pairs
            /// Generated from method `JPH::Body::sFindCollidingPairsCanCollide`.
            public static unsafe bool SFindCollidingPairsCanCollide(Jolt.JPH.Const_Body inBody1, Jolt.JPH.Const_Body inBody2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_sFindCollidingPairsCanCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_sFindCollidingPairsCanCollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_sFindCollidingPairsCanCollide(Jolt.JPH.Const_Body._Underlying *inBody1, Jolt.JPH.Const_Body._Underlying *inBody2);
                return __JPH_Body_sFindCollidingPairsCanCollide(inBody1._UnderlyingPtr, inBody2._UnderlyingPtr) != 0;
            }

            /// Access to the index in the BodyManager::mActiveBodies list
            /// Generated from method `JPH::Body::GetIndexInActiveBodiesInternal`.
            public unsafe uint GetIndexInActiveBodiesInternal()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetIndexInActiveBodiesInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetIndexInActiveBodiesInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_Body_GetIndexInActiveBodiesInternal(_Underlying *_this);
                return __JPH_Body_GetIndexInActiveBodiesInternal(_UnderlyingPtr);
            }
        }

        /// Generated from class `JPH::Body`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::NonCopyable`
        /// This is the non-const half of the class.
        public class Body : Const_Body
        {
            // Upcasts:
            public static unsafe implicit operator Jolt.JPH.NonCopyable(Body self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.NonCopyable._Underlying *__JPH_Body_UpcastTo_JPH_NonCopyable(_Underlying *_this);
                Jolt.JPH.NonCopyable ret = new(__JPH_Body_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            internal unsafe Body(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Change the body to a sensor. A sensor will receive collision callbacks, but will not cause any collision responses and can be used as a trigger volume.
            /// The cheapest sensor (in terms of CPU usage) is a sensor with motion type Static (they can be moved around using BodyInterface::SetPosition/SetPositionAndRotation).
            /// These sensors will only detect collisions with active Dynamic or Kinematic bodies. As soon as a body go to sleep, the contact point with the sensor will be lost.
            /// If you make a sensor Dynamic or Kinematic and activate them, the sensor will be able to detect collisions with sleeping bodies too. An active sensor will never go to sleep automatically.
            /// When you make a Dynamic or Kinematic sensor, make sure it is in an ObjectLayer that does not collide with Static bodies or other sensors to avoid extra overhead in the broad phase.
            /// Generated from method `JPH::Body::SetIsSensor`.
            public unsafe void SetIsSensor(bool inIsSensor)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetIsSensor(_Underlying *_this, byte inIsSensor);
                __JPH_Body_SetIsSensor(_UnderlyingPtr, inIsSensor ? (byte)1 : (byte)0);
            }

            /// If kinematic objects can generate contact points against other kinematic or static objects.
            /// Note that turning this on can be CPU intensive as much more collision detection work will be done without any effect on the simulation (kinematic objects are not affected by other kinematic/static objects).
            /// This can be used to make sensors detect static objects. Note that the sensor must be kinematic and active for it to detect static objects.
            /// Generated from method `JPH::Body::SetCollideKinematicVsNonDynamic`.
            public unsafe void SetCollideKinematicVsNonDynamic(bool inCollide)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetCollideKinematicVsNonDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetCollideKinematicVsNonDynamic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetCollideKinematicVsNonDynamic(_Underlying *_this, byte inCollide);
                __JPH_Body_SetCollideKinematicVsNonDynamic(_UnderlyingPtr, inCollide ? (byte)1 : (byte)0);
            }

            /// If PhysicsSettings::mUseManifoldReduction is true, this allows turning off manifold reduction for this specific body.
            /// Manifold reduction by default will combine contacts with similar normals that come from different SubShapeIDs (e.g. different triangles in a mesh shape or different compound shapes).
            /// If the application requires tracking exactly which SubShapeIDs are in contact, you can turn off manifold reduction. Note that this comes at a performance cost.
            /// Consider using BodyInterface::SetUseManifoldReduction if the body could already be in contact with other bodies to ensure that the contact cache is invalidated and you get the correct contact callbacks.
            /// Generated from method `JPH::Body::SetUseManifoldReduction`.
            public unsafe void SetUseManifoldReduction(bool inUseReduction)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetUseManifoldReduction(_Underlying *_this, byte inUseReduction);
                __JPH_Body_SetUseManifoldReduction(_UnderlyingPtr, inUseReduction ? (byte)1 : (byte)0);
            }

            /// Set to indicate that the gyroscopic force should be applied to this body (aka Dzhanibekov effect, see https://en.wikipedia.org/wiki/Tennis_racket_theorem)
            /// Generated from method `JPH::Body::SetApplyGyroscopicForce`.
            public unsafe void SetApplyGyroscopicForce(bool inApply)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetApplyGyroscopicForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetApplyGyroscopicForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetApplyGyroscopicForce(_Underlying *_this, byte inApply);
                __JPH_Body_SetApplyGyroscopicForce(_UnderlyingPtr, inApply ? (byte)1 : (byte)0);
            }

            /// Set to indicate that extra effort should be made to try to remove ghost contacts (collisions with internal edges of a mesh). This is more expensive but makes bodies move smoother over a mesh with convex edges.
            /// Generated from method `JPH::Body::SetEnhancedInternalEdgeRemoval`.
            public unsafe void SetEnhancedInternalEdgeRemoval(bool inApply)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetEnhancedInternalEdgeRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetEnhancedInternalEdgeRemoval(_Underlying *_this, byte inApply);
                __JPH_Body_SetEnhancedInternalEdgeRemoval(_UnderlyingPtr, inApply ? (byte)1 : (byte)0);
            }

            /// Generated from method `JPH::Body::GetCollisionGroup`.
            public unsafe new Jolt.JPH.CollisionGroup GetCollisionGroup()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetCollisionGroup_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetCollisionGroup_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.CollisionGroup._Underlying *__JPH_Body_GetCollisionGroup_mut(_Underlying *_this);
                return new(__JPH_Body_GetCollisionGroup_mut(_UnderlyingPtr), is_owning: false);
            }

            /// Generated from method `JPH::Body::SetCollisionGroup`.
            public unsafe void SetCollisionGroup(Jolt.JPH.Const_CollisionGroup inGroup)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetCollisionGroup(_Underlying *_this, Jolt.JPH.Const_CollisionGroup._Underlying *inGroup);
                __JPH_Body_SetCollisionGroup(_UnderlyingPtr, inGroup._UnderlyingPtr);
            }

            /// Generated from method `JPH::Body::SetAllowSleeping`.
            public unsafe void SetAllowSleeping(bool inAllow)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetAllowSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetAllowSleeping(_Underlying *_this, byte inAllow);
                __JPH_Body_SetAllowSleeping(_UnderlyingPtr, inAllow ? (byte)1 : (byte)0);
            }

            /// Resets the sleep timer. This does not wake up the body if it is sleeping, but allows resetting the system that detects when a body is sleeping.
            /// Generated from method `JPH::Body::ResetSleepTimer`.
            public unsafe void ResetSleepTimer()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_ResetSleepTimer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_ResetSleepTimer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_ResetSleepTimer(_Underlying *_this);
                __JPH_Body_ResetSleepTimer(_UnderlyingPtr);
            }

            /// Generated from method `JPH::Body::SetFriction`.
            public unsafe void SetFriction(float inFriction)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetFriction(_Underlying *_this, float inFriction);
                __JPH_Body_SetFriction(_UnderlyingPtr, inFriction);
            }

            /// Generated from method `JPH::Body::SetRestitution`.
            public unsafe void SetRestitution(float inRestitution)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetRestitution(_Underlying *_this, float inRestitution);
                __JPH_Body_SetRestitution(_UnderlyingPtr, inRestitution);
            }

            // Reset the total accumulated force, not that this will be done automatically after every time step.
            /// Generated from method `JPH::Body::ResetForce`.
            public unsafe void ResetForce()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_ResetForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_ResetForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_ResetForce(_Underlying *_this);
                __JPH_Body_ResetForce(_UnderlyingPtr);
            }

            // Reset the total accumulated torque, not that this will be done automatically after every time step.
            /// Generated from method `JPH::Body::ResetTorque`.
            public unsafe void ResetTorque()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_ResetTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_ResetTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_ResetTorque(_Underlying *_this);
                __JPH_Body_ResetTorque(_UnderlyingPtr);
            }

            // Reset the current velocity and accumulated force and torque.
            /// Generated from method `JPH::Body::ResetMotion`.
            public unsafe void ResetMotion()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_ResetMotion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_ResetMotion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_ResetMotion(_Underlying *_this);
                __JPH_Body_ResetMotion(_UnderlyingPtr);
            }

            /// Generated from method `JPH::Body::SetUserData`.
            public unsafe void SetUserData(ulong inUserData)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetUserData(_Underlying *_this, ulong inUserData);
                __JPH_Body_SetUserData(_UnderlyingPtr, inUserData);
            }

            /// Flag if body is in the broadphase (should only be called by the BroadPhase)
            /// Generated from method `JPH::Body::SetInBroadPhaseInternal`.
            public unsafe void SetInBroadPhaseInternal(bool inInBroadPhase)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetInBroadPhaseInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetInBroadPhaseInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetInBroadPhaseInternal(_Underlying *_this, byte inInBroadPhase);
                __JPH_Body_SetInBroadPhaseInternal(_UnderlyingPtr, inInBroadPhase ? (byte)1 : (byte)0);
            }

            /// Invalidate the contact cache (should only be called by the BodyManager), will be reset the next simulation step. Returns true if the contact cache was still valid.
            /// Generated from method `JPH::Body::InvalidateContactCacheInternal`.
            public unsafe bool InvalidateContactCacheInternal()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_InvalidateContactCacheInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_InvalidateContactCacheInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_InvalidateContactCacheInternal(_Underlying *_this);
                return __JPH_Body_InvalidateContactCacheInternal(_UnderlyingPtr) != 0;
            }

            /// Reset the collision cache invalid flag (should only be called by the BodyManager).
            /// Generated from method `JPH::Body::ValidateContactCacheInternal`.
            public unsafe void ValidateContactCacheInternal()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_ValidateContactCacheInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_ValidateContactCacheInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_ValidateContactCacheInternal(_Underlying *_this);
                __JPH_Body_ValidateContactCacheInternal(_UnderlyingPtr);
            }

            /// Updates world space bounding box (should only be called by the PhysicsSystem)
            /// Generated from method `JPH::Body::CalculateWorldSpaceBoundsInternal`.
            public unsafe void CalculateWorldSpaceBoundsInternal()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_CalculateWorldSpaceBoundsInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_CalculateWorldSpaceBoundsInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_CalculateWorldSpaceBoundsInternal(_Underlying *_this);
                __JPH_Body_CalculateWorldSpaceBoundsInternal(_UnderlyingPtr);
            }

            /// Function to update a body's shape (should only be called by the BodyInterface since it also requires updating the broadphase)
            /// @param inShape The new shape for this body
            /// @param inUpdateMassProperties When true, the mass and inertia tensor is recalculated
            /// Generated from method `JPH::Body::SetShapeInternal`.
            public unsafe void SetShapeInternal(Jolt.JPH.Const_Shape? inShape, bool inUpdateMassProperties)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetShapeInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetShapeInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetShapeInternal(_Underlying *_this, Jolt.JPH.Const_Shape._Underlying *inShape, byte inUpdateMassProperties);
                __JPH_Body_SetShapeInternal(_UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null, inUpdateMassProperties ? (byte)1 : (byte)0);
            }
        }

        /// This is used for optional parameters of class `Body` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Body`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Body`/`Const_Body` directly.
        public class _InOptMut_Body
        {
            public Body? Opt;

            public _InOptMut_Body() {}
            public _InOptMut_Body(Body value) {Opt = value;}
            public static implicit operator _InOptMut_Body(Body value) {return new(value);}
        }

        /// This is used for optional parameters of class `Body` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Body`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Body`/`Const_Body` to pass it to the function.
        public class _InOptConst_Body
        {
            public Const_Body? Opt;

            public _InOptConst_Body() {}
            public _InOptConst_Body(Const_Body value) {Opt = value;}
            public static implicit operator _InOptConst_Body(Const_Body value) {return new(value);}
        }
    }
}
