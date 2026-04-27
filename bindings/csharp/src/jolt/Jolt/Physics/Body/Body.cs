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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Body_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Body_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_Body_size_t(ulong inCount);
                return __Jolt_new_JPH_Body_size_t(inCount);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Body_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Body_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_Body_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_JPH_Body_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::Body::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(ulong inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Body_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Body_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_Body_size_t(ulong inCount);
                return __Jolt_new_array_JPH_Body_size_t(inCount);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Body_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Body_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_Body_void_ptr_size_t(void *inPointer, ulong inSize);
                __Jolt_delete_array_JPH_Body_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::Body::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(ulong inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Body_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Body_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_Body_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_JPH_Body_size_t_void_ptr(inCount, inPointer);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Body_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Body_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_Body_size_t_void_ptr(ulong inCount, void *inPointer);
                return __Jolt_new_array_JPH_Body_size_t_void_ptr(inCount, inPointer);
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

            /// Get world space linear velocity of the center of mass (unit: m/s)
            /// Generated from method `JPH::Body::GetLinearVelocity`.
            public unsafe Jolt.JPH.Vec3 GetLinearVelocity()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Body_GetLinearVelocity(_Underlying *_this);
                return new(__JPH_Body_GetLinearVelocity(_UnderlyingPtr), is_owning: true);
            }

            /// Get world space angular velocity of the center of mass (unit: rad/s)
            /// Generated from method `JPH::Body::GetAngularVelocity`.
            public unsafe Jolt.JPH.Vec3 GetAngularVelocity()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Body_GetAngularVelocity(_Underlying *_this);
                return new(__JPH_Body_GetAngularVelocity(_UnderlyingPtr), is_owning: true);
            }

            /// Velocity of point inPoint (in center of mass space, e.g. on the surface of the body) of the body (unit: m/s)
            /// Generated from method `JPH::Body::GetPointVelocityCOM`.
            public unsafe Jolt.JPH.Vec3 GetPointVelocityCOM(Jolt.JPH.Const_Vec3 inPointRelativeToCOM)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetPointVelocityCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetPointVelocityCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Body_GetPointVelocityCOM(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inPointRelativeToCOM);
                return new(__JPH_Body_GetPointVelocityCOM(_UnderlyingPtr, inPointRelativeToCOM._UnderlyingPtr), is_owning: true);
            }

            /// Velocity of point inPoint (in world space, e.g. on the surface of the body) of the body (unit: m/s)
            /// Generated from method `JPH::Body::GetPointVelocity`.
            public unsafe Jolt.JPH.Vec3 GetPointVelocity(Jolt.JPH.Const_Vec3 inPoint)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetPointVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetPointVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Body_GetPointVelocity(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inPoint);
                return new(__JPH_Body_GetPointVelocity(_UnderlyingPtr, inPoint._UnderlyingPtr), is_owning: true);
            }

            // Get the total amount of force applied to the center of mass this time step (through AddForce calls). Note that it will reset to zero after PhysicsSystem::Update.
            /// Generated from method `JPH::Body::GetAccumulatedForce`.
            public unsafe Jolt.JPH.Vec3 GetAccumulatedForce()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetAccumulatedForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetAccumulatedForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Body_GetAccumulatedForce(_Underlying *_this);
                return new(__JPH_Body_GetAccumulatedForce(_UnderlyingPtr), is_owning: true);
            }

            // Get the total amount of torque applied to the center of mass this time step (through AddForce/AddTorque calls). Note that it will reset to zero after PhysicsSystem::Update.
            /// Generated from method `JPH::Body::GetAccumulatedTorque`.
            public unsafe Jolt.JPH.Vec3 GetAccumulatedTorque()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetAccumulatedTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetAccumulatedTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Body_GetAccumulatedTorque(_Underlying *_this);
                return new(__JPH_Body_GetAccumulatedTorque(_UnderlyingPtr), is_owning: true);
            }

            /// Get inverse inertia tensor in world space
            /// Generated from method `JPH::Body::GetInverseInertia`.
            public unsafe Jolt.JPH.Mat44 GetInverseInertia()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetInverseInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetInverseInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Mat44._Underlying *__JPH_Body_GetInverseInertia(_Underlying *_this);
                return new(__JPH_Body_GetInverseInertia(_UnderlyingPtr), is_owning: true);
            }

            /// Gets the properties needed to do buoyancy calculations
            /// @param inSurfacePosition Position of the fluid surface in world space
            /// @param inSurfaceNormal Normal of the fluid surface (should point up)
            /// @param outTotalVolume On return this contains the total volume of the shape
            /// @param outSubmergedVolume On return this contains the submerged volume of the shape
            /// @param outRelativeCenterOfBuoyancy On return this contains the center of mass of the submerged volume relative to the center of mass of the body
            /// Generated from method `JPH::Body::GetSubmergedVolume`.
            public unsafe void GetSubmergedVolume(Jolt.JPH.Const_Vec3 inSurfacePosition, Jolt.JPH.Const_Vec3 inSurfaceNormal, ref float outTotalVolume, ref float outSubmergedVolume, Jolt.JPH.Vec3 outRelativeCenterOfBuoyancy)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetSubmergedVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetSubmergedVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_GetSubmergedVolume(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inSurfacePosition, Jolt.JPH.Vec3._Underlying *inSurfaceNormal, float *outTotalVolume, float *outSubmergedVolume, Jolt.JPH.Vec3._Underlying *outRelativeCenterOfBuoyancy);
                fixed (float *__ptr_outTotalVolume = &outTotalVolume)
                {
                    fixed (float *__ptr_outSubmergedVolume = &outSubmergedVolume)
                    {
                        __JPH_Body_GetSubmergedVolume(_UnderlyingPtr, inSurfacePosition._UnderlyingPtr, inSurfaceNormal._UnderlyingPtr, __ptr_outTotalVolume, __ptr_outSubmergedVolume, outRelativeCenterOfBuoyancy._UnderlyingPtr);
                    }
                }
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

            /// World space position of the body
            /// Generated from method `JPH::Body::GetPosition`.
            public unsafe Jolt.JPH.Vec3 GetPosition()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Body_GetPosition(_Underlying *_this);
                return new(__JPH_Body_GetPosition(_UnderlyingPtr), is_owning: true);
            }

            /// World space rotation of the body
            /// Generated from method `JPH::Body::GetRotation`.
            public unsafe Jolt.JPH.Quat GetRotation()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Quat._Underlying *__JPH_Body_GetRotation(_Underlying *_this);
                return new(__JPH_Body_GetRotation(_UnderlyingPtr), is_owning: true);
            }

            /// Calculates the transform of this body
            /// Generated from method `JPH::Body::GetWorldTransform`.
            public unsafe Jolt.JPH.Mat44 GetWorldTransform()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Mat44._Underlying *__JPH_Body_GetWorldTransform(_Underlying *_this);
                return new(__JPH_Body_GetWorldTransform(_UnderlyingPtr), is_owning: true);
            }

            /// Gets the world space position of this body's center of mass
            /// Generated from method `JPH::Body::GetCenterOfMassPosition`.
            public unsafe Jolt.JPH.Vec3 GetCenterOfMassPosition()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetCenterOfMassPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetCenterOfMassPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Body_GetCenterOfMassPosition(_Underlying *_this);
                return new(__JPH_Body_GetCenterOfMassPosition(_UnderlyingPtr), is_owning: true);
            }

            /// Calculates the transform for this body's center of mass
            /// Generated from method `JPH::Body::GetCenterOfMassTransform`.
            public unsafe Jolt.JPH.Mat44 GetCenterOfMassTransform()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Mat44._Underlying *__JPH_Body_GetCenterOfMassTransform(_Underlying *_this);
                return new(__JPH_Body_GetCenterOfMassTransform(_UnderlyingPtr), is_owning: true);
            }

            /// Calculates the inverse of the transform for this body's center of mass
            /// Generated from method `JPH::Body::GetInverseCenterOfMassTransform`.
            public unsafe Jolt.JPH.Mat44 GetInverseCenterOfMassTransform()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetInverseCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetInverseCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Mat44._Underlying *__JPH_Body_GetInverseCenterOfMassTransform(_Underlying *_this);
                return new(__JPH_Body_GetInverseCenterOfMassTransform(_UnderlyingPtr), is_owning: true);
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

            /// Get surface normal of a particular sub shape and its world space surface position on this body
            /// Generated from method `JPH::Body::GetWorldSpaceSurfaceNormal`.
            public unsafe Jolt.JPH.Vec3 GetWorldSpaceSurfaceNormal(Jolt.JPH.Const_SubShapeID inSubShapeID, Jolt.JPH.Const_Vec3 inPosition)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_GetWorldSpaceSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_GetWorldSpaceSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Jolt.JPH.Vec3._Underlying *__JPH_Body_GetWorldSpaceSurfaceNormal(_Underlying *_this, Jolt.JPH.Const_SubShapeID._Underlying *inSubShapeID, Jolt.JPH.Vec3._Underlying *inPosition);
                return new(__JPH_Body_GetWorldSpaceSurfaceNormal(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, inPosition._UnderlyingPtr), is_owning: true);
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

            /// Set world space linear velocity of the center of mass (unit: m/s).
            /// If you want the body to wake up when it is sleeping, use BodyInterface::SetLinearVelocity instead.
            /// Generated from method `JPH::Body::SetLinearVelocity`.
            public unsafe void SetLinearVelocity(Jolt.JPH.Const_Vec3 inLinearVelocity)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetLinearVelocity(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inLinearVelocity);
                __JPH_Body_SetLinearVelocity(_UnderlyingPtr, inLinearVelocity._UnderlyingPtr);
            }

            /// Set world space linear velocity of the center of mass, will make sure the value is clamped against the maximum linear velocity.
            /// If you want the body to wake up when it is sleeping, use BodyInterface::SetLinearVelocity instead.
            /// Generated from method `JPH::Body::SetLinearVelocityClamped`.
            public unsafe void SetLinearVelocityClamped(Jolt.JPH.Const_Vec3 inLinearVelocity)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetLinearVelocityClamped", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetLinearVelocityClamped", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetLinearVelocityClamped(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inLinearVelocity);
                __JPH_Body_SetLinearVelocityClamped(_UnderlyingPtr, inLinearVelocity._UnderlyingPtr);
            }

            /// Set world space angular velocity of the center of mass (unit: rad/s).
            /// If you want the body to wake up when it is sleeping, use BodyInterface::SetAngularVelocity instead.
            /// Generated from method `JPH::Body::SetAngularVelocity`.
            public unsafe void SetAngularVelocity(Jolt.JPH.Const_Vec3 inAngularVelocity)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetAngularVelocity(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inAngularVelocity);
                __JPH_Body_SetAngularVelocity(_UnderlyingPtr, inAngularVelocity._UnderlyingPtr);
            }

            /// Set world space angular velocity of the center of mass, will make sure the value is clamped against the maximum angular velocity.
            /// If you want the body to wake up when it is sleeping, use BodyInterface::SetAngularVelocity instead.
            /// Generated from method `JPH::Body::SetAngularVelocityClamped`.
            public unsafe void SetAngularVelocityClamped(Jolt.JPH.Const_Vec3 inAngularVelocity)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetAngularVelocityClamped", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetAngularVelocityClamped", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetAngularVelocityClamped(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inAngularVelocity);
                __JPH_Body_SetAngularVelocityClamped(_UnderlyingPtr, inAngularVelocity._UnderlyingPtr);
            }

            /// Add force (unit: N) at center of mass for the next time step, will be reset after the next call to PhysicsSystem::Update.
            /// If you want the body to wake up when it is sleeping, use BodyInterface::AddForce instead.
            /// Generated from method `JPH::Body::AddForce`.
            public unsafe void AddForce(Jolt.JPH.Const_Vec3 inForce)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_AddForce_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_AddForce_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_AddForce_1(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inForce);
                __JPH_Body_AddForce_1(_UnderlyingPtr, inForce._UnderlyingPtr);
            }

            /// Add force (unit: N) at world space position inPosition for the next time step, will be reset after the next call to PhysicsSystem::Update.
            /// If you want the body to wake up when it is sleeping, use BodyInterface::AddForce instead.
            /// Generated from method `JPH::Body::AddForce`.
            public unsafe void AddForce(Jolt.JPH.Const_Vec3 inForce, Jolt.JPH.Const_Vec3 inPosition)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_AddForce_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_AddForce_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_AddForce_2(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inForce, Jolt.JPH.Vec3._Underlying *inPosition);
                __JPH_Body_AddForce_2(_UnderlyingPtr, inForce._UnderlyingPtr, inPosition._UnderlyingPtr);
            }

            /// Add torque (unit: N m) for the next time step, will be reset after the next call to PhysicsSystem::Update.
            /// If you want the body to wake up when it is sleeping, use BodyInterface::AddTorque instead.
            /// Generated from method `JPH::Body::AddTorque`.
            public unsafe void AddTorque(Jolt.JPH.Const_Vec3 inTorque)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_AddTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_AddTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_AddTorque(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inTorque);
                __JPH_Body_AddTorque(_UnderlyingPtr, inTorque._UnderlyingPtr);
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

            /// Add impulse to center of mass (unit: kg m/s).
            /// If you want the body to wake up when it is sleeping, use BodyInterface::AddImpulse instead.
            /// Generated from method `JPH::Body::AddImpulse`.
            public unsafe void AddImpulse(Jolt.JPH.Const_Vec3 inImpulse)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_AddImpulse_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_AddImpulse_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_AddImpulse_1(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inImpulse);
                __JPH_Body_AddImpulse_1(_UnderlyingPtr, inImpulse._UnderlyingPtr);
            }

            /// Add impulse to point in world space (unit: kg m/s).
            /// If you want the body to wake up when it is sleeping, use BodyInterface::AddImpulse instead.
            /// Generated from method `JPH::Body::AddImpulse`.
            public unsafe void AddImpulse(Jolt.JPH.Const_Vec3 inImpulse, Jolt.JPH.Const_Vec3 inPosition)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_AddImpulse_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_AddImpulse_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_AddImpulse_2(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inImpulse, Jolt.JPH.Vec3._Underlying *inPosition);
                __JPH_Body_AddImpulse_2(_UnderlyingPtr, inImpulse._UnderlyingPtr, inPosition._UnderlyingPtr);
            }

            /// Add angular impulse in world space (unit: N m s).
            /// If you want the body to wake up when it is sleeping, use BodyInterface::AddAngularImpulse instead.
            /// Generated from method `JPH::Body::AddAngularImpulse`.
            public unsafe void AddAngularImpulse(Jolt.JPH.Const_Vec3 inAngularImpulse)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_AddAngularImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_AddAngularImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_AddAngularImpulse(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inAngularImpulse);
                __JPH_Body_AddAngularImpulse(_UnderlyingPtr, inAngularImpulse._UnderlyingPtr);
            }

            /// Set velocity of body such that it will be positioned at inTargetPosition/Rotation in inDeltaTime seconds.
            /// If you want the body to wake up when it is sleeping, use BodyInterface::MoveKinematic instead.
            /// Generated from method `JPH::Body::MoveKinematic`.
            public unsafe void MoveKinematic(Jolt.JPH.Const_Vec3 inTargetPosition, Jolt.JPH.Const_Quat inTargetRotation, float inDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_MoveKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_MoveKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_MoveKinematic(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inTargetPosition, Jolt.JPH.Quat._Underlying *inTargetRotation, float inDeltaTime);
                __JPH_Body_MoveKinematic(_UnderlyingPtr, inTargetPosition._UnderlyingPtr, inTargetRotation._UnderlyingPtr, inDeltaTime);
            }

            /// Applies an impulse to the body that simulates fluid buoyancy and drag.
            /// If you want the body to wake up when it is sleeping, use BodyInterface::ApplyBuoyancyImpulse instead.
            /// @param inSurfacePosition Position of the fluid surface in world space
            /// @param inSurfaceNormal Normal of the fluid surface (should point up)
            /// @param inBuoyancy The buoyancy factor for the body. 1 = neutral body, < 1 sinks, > 1 floats. Note that we don't use the fluid density since it is harder to configure than a simple number between [0, 2]
            /// @param inLinearDrag Linear drag factor that slows down the body when in the fluid (approx. 0.5)
            /// @param inAngularDrag Angular drag factor that slows down rotation when the body is in the fluid (approx. 0.01)
            /// @param inFluidVelocity The average velocity of the fluid (in m/s) in which the body resides
            /// @param inGravity The gravity vector (pointing down)
            /// @param inDeltaTime Delta time of the next simulation step (in s)
            /// @return true if an impulse was applied, false if the body was not in the fluid
            /// Generated from method `JPH::Body::ApplyBuoyancyImpulse`.
            public unsafe bool ApplyBuoyancyImpulse(Jolt.JPH.Const_Vec3 inSurfacePosition, Jolt.JPH.Const_Vec3 inSurfaceNormal, float inBuoyancy, float inLinearDrag, float inAngularDrag, Jolt.JPH.Const_Vec3 inFluidVelocity, Jolt.JPH.Const_Vec3 inGravity, float inDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_ApplyBuoyancyImpulse_8", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_ApplyBuoyancyImpulse_8", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_ApplyBuoyancyImpulse_8(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inSurfacePosition, Jolt.JPH.Vec3._Underlying *inSurfaceNormal, float inBuoyancy, float inLinearDrag, float inAngularDrag, Jolt.JPH.Vec3._Underlying *inFluidVelocity, Jolt.JPH.Vec3._Underlying *inGravity, float inDeltaTime);
                return __JPH_Body_ApplyBuoyancyImpulse_8(_UnderlyingPtr, inSurfacePosition._UnderlyingPtr, inSurfaceNormal._UnderlyingPtr, inBuoyancy, inLinearDrag, inAngularDrag, inFluidVelocity._UnderlyingPtr, inGravity._UnderlyingPtr, inDeltaTime) != 0;
            }

            /// Applies an impulse to the body that simulates fluid buoyancy and drag.
            /// If you want the body to wake up when it is sleeping, use BodyInterface::ApplyBuoyancyImpulse instead.
            /// @param inTotalVolume Total volume of the shape of this body (m^3)
            /// @param inSubmergedVolume Submerged volume of the shape of this body (m^3)
            /// @param inRelativeCenterOfBuoyancy The center of mass of the submerged volume relative to the center of mass of the body
            /// @param inBuoyancy The buoyancy factor for the body. 1 = neutral body, < 1 sinks, > 1 floats. Note that we don't use the fluid density since it is harder to configure than a simple number between [0, 2]
            /// @param inLinearDrag Linear drag factor that slows down the body when in the fluid (approx. 0.5)
            /// @param inAngularDrag Angular drag factor that slows down rotation when the body is in the fluid (approx. 0.01)
            /// @param inFluidVelocity The average velocity of the fluid (in m/s) in which the body resides
            /// @param inGravity The gravity vector (pointing down)
            /// @param inDeltaTime Delta time of the next simulation step (in s)
            /// @return true if an impulse was applied, false if the body was not in the fluid
            /// Generated from method `JPH::Body::ApplyBuoyancyImpulse`.
            public unsafe bool ApplyBuoyancyImpulse(float inTotalVolume, float inSubmergedVolume, Jolt.JPH.Const_Vec3 inRelativeCenterOfBuoyancy, float inBuoyancy, float inLinearDrag, float inAngularDrag, Jolt.JPH.Const_Vec3 inFluidVelocity, Jolt.JPH.Const_Vec3 inGravity, float inDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_ApplyBuoyancyImpulse_9", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_ApplyBuoyancyImpulse_9", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __JPH_Body_ApplyBuoyancyImpulse_9(_Underlying *_this, float inTotalVolume, float inSubmergedVolume, Jolt.JPH.Vec3._Underlying *inRelativeCenterOfBuoyancy, float inBuoyancy, float inLinearDrag, float inAngularDrag, Jolt.JPH.Vec3._Underlying *inFluidVelocity, Jolt.JPH.Vec3._Underlying *inGravity, float inDeltaTime);
                return __JPH_Body_ApplyBuoyancyImpulse_9(_UnderlyingPtr, inTotalVolume, inSubmergedVolume, inRelativeCenterOfBuoyancy._UnderlyingPtr, inBuoyancy, inLinearDrag, inAngularDrag, inFluidVelocity._UnderlyingPtr, inGravity._UnderlyingPtr, inDeltaTime) != 0;
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

            /// Update position using an Euler step (used during position integrate & constraint solving)
            /// Generated from method `JPH::Body::AddPositionStep`.
            public unsafe void AddPositionStep(Jolt.JPH.Const_Vec3 inLinearVelocityTimesDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_AddPositionStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_AddPositionStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_AddPositionStep(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inLinearVelocityTimesDeltaTime);
                __JPH_Body_AddPositionStep(_UnderlyingPtr, inLinearVelocityTimesDeltaTime._UnderlyingPtr);
            }

            /// Generated from method `JPH::Body::SubPositionStep`.
            public unsafe void SubPositionStep(Jolt.JPH.Const_Vec3 inLinearVelocityTimesDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SubPositionStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SubPositionStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SubPositionStep(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inLinearVelocityTimesDeltaTime);
                __JPH_Body_SubPositionStep(_UnderlyingPtr, inLinearVelocityTimesDeltaTime._UnderlyingPtr);
            }

            /// Update rotation using an Euler step (used during position integrate & constraint solving)
            /// Generated from method `JPH::Body::AddRotationStep`.
            public unsafe void AddRotationStep(Jolt.JPH.Const_Vec3 inAngularVelocityTimesDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_AddRotationStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_AddRotationStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_AddRotationStep(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inAngularVelocityTimesDeltaTime);
                __JPH_Body_AddRotationStep(_UnderlyingPtr, inAngularVelocityTimesDeltaTime._UnderlyingPtr);
            }

            /// Generated from method `JPH::Body::SubRotationStep`.
            public unsafe void SubRotationStep(Jolt.JPH.Const_Vec3 inAngularVelocityTimesDeltaTime)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SubRotationStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SubRotationStep", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SubRotationStep(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inAngularVelocityTimesDeltaTime);
                __JPH_Body_SubRotationStep(_UnderlyingPtr, inAngularVelocityTimesDeltaTime._UnderlyingPtr);
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

            /// Function to update body's position (should only be called by the BodyInterface since it also requires updating the broadphase)
            /// Generated from method `JPH::Body::SetPositionAndRotationInternal`.
            /// Parameter `inResetSleepTimer` defaults to `true`.
            public unsafe void SetPositionAndRotationInternal(Jolt.JPH.Const_Vec3 inPosition, Jolt.JPH.Const_Quat inRotation, bool? inResetSleepTimer = null)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_SetPositionAndRotationInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_SetPositionAndRotationInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_SetPositionAndRotationInternal(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inPosition, Jolt.JPH.Quat._Underlying *inRotation, byte *inResetSleepTimer);
                byte __deref_inResetSleepTimer = inResetSleepTimer.GetValueOrDefault() ? (byte)1 : (byte)0;
                __JPH_Body_SetPositionAndRotationInternal(_UnderlyingPtr, inPosition._UnderlyingPtr, inRotation._UnderlyingPtr, inResetSleepTimer.HasValue ? &__deref_inResetSleepTimer : null);
            }

            /// Updates the center of mass and optionally mass properties after shifting the center of mass or changes to the shape (should only be called by the BodyInterface since it also requires updating the broadphase)
            /// @param inPreviousCenterOfMass Center of mass of the shape before the alterations
            /// @param inUpdateMassProperties When true, the mass and inertia tensor is recalculated
            /// Generated from method `JPH::Body::UpdateCenterOfMassInternal`.
            public unsafe void UpdateCenterOfMassInternal(Jolt.JPH.Const_Vec3 inPreviousCenterOfMass, bool inUpdateMassProperties)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Body_UpdateCenterOfMassInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Body_UpdateCenterOfMassInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_Body_UpdateCenterOfMassInternal(_Underlying *_this, Jolt.JPH.Vec3._Underlying *inPreviousCenterOfMass, byte inUpdateMassProperties);
                __JPH_Body_UpdateCenterOfMassInternal(_UnderlyingPtr, inPreviousCenterOfMass._UnderlyingPtr, inUpdateMassProperties ? (byte)1 : (byte)0);
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
