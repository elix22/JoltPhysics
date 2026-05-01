// machine generated, do not edit
public static partial class JPH
{
    /// Class that provides operations on bodies using a body ID. Note that if you need to do multiple operations on a single body, it is more efficient to lock the body once and combine the operations.
    /// All quantities are in world space unless otherwise specified.
    /// Generated from class `JPH::BodyInterface`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_BodyInterface : JPH.Object<Const_BodyInterface>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_Destroy(_Underlying *_this);
            __JPH_BodyInterface_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BodyInterface() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_BodyInterface self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_BodyInterface_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_BodyInterface_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe Const_BodyInterface(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_BodyInterface() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyInterface._Underlying *__JPH_BodyInterface_DefaultConstruct();
            _UnderlyingPtr = __JPH_BodyInterface_DefaultConstruct();
        }

        /// Advanced use only. Creates a rigid body without specifying an ID. This body cannot be added to the physics system until it has been assigned a body ID.
        /// This can be used to decouple allocation from registering the body. A call to CreateBodyWithoutID followed by AssignBodyID is equivalent to calling CreateBodyWithID.
        /// @return Created body
        /// Generated from method `JPH::BodyInterface::CreateBodyWithoutID`.
        public unsafe JPH.Body? CreateBodyWithoutID(JPH.Const_BodyCreationSettings inSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_CreateBodyWithoutID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_CreateBodyWithoutID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Body._Underlying *__JPH_BodyInterface_CreateBodyWithoutID(_Underlying *_this, JPH.Const_BodyCreationSettings._Underlying *inSettings);
            var __c_ret = __JPH_BodyInterface_CreateBodyWithoutID(_UnderlyingPtr, inSettings._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Body(__c_ret, is_owning: false) : null;
        }

        /// Advanced use only. Creates a body without specifying an ID. See comments at CreateBodyWithoutID.
        /// Generated from method `JPH::BodyInterface::CreateSoftBodyWithoutID`.
        public unsafe JPH.Body? CreateSoftBodyWithoutID(JPH.Const_SoftBodyCreationSettings inSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_CreateSoftBodyWithoutID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_CreateSoftBodyWithoutID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Body._Underlying *__JPH_BodyInterface_CreateSoftBodyWithoutID(_Underlying *_this, JPH.Const_SoftBodyCreationSettings._Underlying *inSettings);
            var __c_ret = __JPH_BodyInterface_CreateSoftBodyWithoutID(_UnderlyingPtr, inSettings._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Body(__c_ret, is_owning: false) : null;
        }

        /// Advanced use only. Destroy a body previously created with CreateBodyWithoutID that hasn't gotten an ID yet through the AssignBodyID function,
        /// or a body that has had its body ID unassigned through UnassignBodyIDs. Bodies that have an ID should be destroyed through DestroyBody.
        /// Generated from method `JPH::BodyInterface::DestroyBodyWithoutID`.
        public unsafe void DestroyBodyWithoutID(JPH.Body? inBody)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_DestroyBodyWithoutID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_DestroyBodyWithoutID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_DestroyBodyWithoutID(_Underlying *_this, JPH.Body._Underlying *inBody);
            __JPH_BodyInterface_DestroyBodyWithoutID(_UnderlyingPtr, inBody is not null ? inBody._UnderlyingPtr : null);
        }

        /// Check if a body has been added to the physics system.
        /// Generated from method `JPH::BodyInterface::IsAdded`.
        public unsafe bool IsAdded(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_IsAdded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_IsAdded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_BodyInterface_IsAdded(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_IsAdded(_UnderlyingPtr, __ptr_inBodyID) != 0;
            }
        }

        /// Generated from method `JPH::BodyInterface::IsActive`.
        public unsafe bool IsActive(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_IsActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_BodyInterface_IsActive(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_IsActive(_UnderlyingPtr, __ptr_inBodyID) != 0;
            }
        }

        /// Set a new shape on the body
        /// @param inBodyID Body ID of body that had its shape changed
        /// @param inShape The new shape
        /// @param inUpdateMassProperties When true, the mass and inertia tensor is recalculated
        /// @param inActivationMode Whether or not to activate the body
        /// Generated from method `JPH::BodyInterface::SetShape`.
        public unsafe void SetShape(in JPH.BodyID inBodyID, JPH.Const_Shape? inShape, bool inUpdateMassProperties, JPH.EActivation inActivationMode)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetShape(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Const_Shape._Underlying *inShape, byte inUpdateMassProperties, JPH.EActivation inActivationMode);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetShape(_UnderlyingPtr, __ptr_inBodyID, inShape is not null ? inShape._UnderlyingPtr : null, inUpdateMassProperties ? (byte)1 : (byte)0, inActivationMode);
            }
        }

        /// Notify all systems to indicate that a shape has changed (usable for MutableCompoundShapes)
        /// @param inBodyID Body ID of body that had its shape changed
        /// @param inPreviousCenterOfMass Center of mass of the shape before the alterations
        /// @param inUpdateMassProperties When true, the mass and inertia tensor is recalculated
        /// @param inActivationMode Whether or not to activate the body
        /// Generated from method `JPH::BodyInterface::NotifyShapeChanged`.
        public unsafe void NotifyShapeChanged(in JPH.BodyID inBodyID, JPH.Const_Vec3 inPreviousCenterOfMass, bool inUpdateMassProperties, JPH.EActivation inActivationMode)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_NotifyShapeChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_NotifyShapeChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_NotifyShapeChanged(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inPreviousCenterOfMass, byte inUpdateMassProperties, JPH.EActivation inActivationMode);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_NotifyShapeChanged(_UnderlyingPtr, __ptr_inBodyID, inPreviousCenterOfMass._UnderlyingPtr, inUpdateMassProperties ? (byte)1 : (byte)0, inActivationMode);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetObjectLayer`.
        public unsafe ushort GetObjectLayer(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ushort __JPH_BodyInterface_GetObjectLayer(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_GetObjectLayer(_UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetPositionAndRotation`.
        public unsafe void GetPositionAndRotation(in JPH.BodyID inBodyID, JPH.Vec3 outPosition, JPH.Quat outRotation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetPositionAndRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetPositionAndRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_GetPositionAndRotation(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *outPosition, JPH.Quat._Underlying *outRotation);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_GetPositionAndRotation(_UnderlyingPtr, __ptr_inBodyID, outPosition._UnderlyingPtr, outRotation._UnderlyingPtr);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetPosition`.
        public unsafe JPH.Vec3 GetPosition(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_BodyInterface_GetPosition(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return new(__JPH_BodyInterface_GetPosition(_UnderlyingPtr, __ptr_inBodyID), is_owning: true);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetCenterOfMassPosition`.
        public unsafe JPH.Vec3 GetCenterOfMassPosition(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetCenterOfMassPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetCenterOfMassPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_BodyInterface_GetCenterOfMassPosition(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return new(__JPH_BodyInterface_GetCenterOfMassPosition(_UnderlyingPtr, __ptr_inBodyID), is_owning: true);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetRotation`.
        public unsafe JPH.Quat GetRotation(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Quat._Underlying *__JPH_BodyInterface_GetRotation(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return new(__JPH_BodyInterface_GetRotation(_UnderlyingPtr, __ptr_inBodyID), is_owning: true);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetWorldTransform`.
        public unsafe JPH.Mat44 GetWorldTransform(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_BodyInterface_GetWorldTransform(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return new(__JPH_BodyInterface_GetWorldTransform(_UnderlyingPtr, __ptr_inBodyID), is_owning: true);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetCenterOfMassTransform`.
        public unsafe JPH.Mat44 GetCenterOfMassTransform(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_BodyInterface_GetCenterOfMassTransform(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return new(__JPH_BodyInterface_GetCenterOfMassTransform(_UnderlyingPtr, __ptr_inBodyID), is_owning: true);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetLinearAndAngularVelocity`.
        public unsafe void GetLinearAndAngularVelocity(in JPH.BodyID inBodyID, JPH.Vec3 outLinearVelocity, JPH.Vec3 outAngularVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_GetLinearAndAngularVelocity(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *outLinearVelocity, JPH.Vec3._Underlying *outAngularVelocity);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_GetLinearAndAngularVelocity(_UnderlyingPtr, __ptr_inBodyID, outLinearVelocity._UnderlyingPtr, outAngularVelocity._UnderlyingPtr);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetLinearVelocity`.
        public unsafe JPH.Vec3 GetLinearVelocity(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_BodyInterface_GetLinearVelocity(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return new(__JPH_BodyInterface_GetLinearVelocity(_UnderlyingPtr, __ptr_inBodyID), is_owning: true);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetAngularVelocity`.
        public unsafe JPH.Vec3 GetAngularVelocity(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_BodyInterface_GetAngularVelocity(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return new(__JPH_BodyInterface_GetAngularVelocity(_UnderlyingPtr, __ptr_inBodyID), is_owning: true);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetPointVelocity`.
        public unsafe JPH.Vec3 GetPointVelocity(in JPH.BodyID inBodyID, JPH.Const_Vec3 inPoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetPointVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetPointVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_BodyInterface_GetPointVelocity(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inPoint);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return new(__JPH_BodyInterface_GetPointVelocity(_UnderlyingPtr, __ptr_inBodyID, inPoint._UnderlyingPtr), is_owning: true);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetMotionType`.
        public unsafe JPH.EMotionType GetMotionType(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetMotionType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetMotionType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.EMotionType __JPH_BodyInterface_GetMotionType(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_GetMotionType(_UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetMotionQuality`.
        public unsafe JPH.EMotionQuality GetMotionQuality(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.EMotionQuality __JPH_BodyInterface_GetMotionQuality(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_GetMotionQuality(_UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Get inverse inertia tensor in world space
        /// Generated from method `JPH::BodyInterface::GetInverseInertia`.
        public unsafe JPH.Mat44 GetInverseInertia(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetInverseInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetInverseInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_BodyInterface_GetInverseInertia(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return new(__JPH_BodyInterface_GetInverseInertia(_UnderlyingPtr, __ptr_inBodyID), is_owning: true);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetRestitution`.
        public unsafe float GetRestitution(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_BodyInterface_GetRestitution(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_GetRestitution(_UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetFriction`.
        public unsafe float GetFriction(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_BodyInterface_GetFriction(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_GetFriction(_UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetGravityFactor`.
        public unsafe float GetGravityFactor(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_BodyInterface_GetGravityFactor(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_GetGravityFactor(_UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetMaxLinearVelocity`.
        public unsafe float GetMaxLinearVelocity(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_BodyInterface_GetMaxLinearVelocity(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_GetMaxLinearVelocity(_UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetMaxAngularVelocity`.
        public unsafe float GetMaxAngularVelocity(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_BodyInterface_GetMaxAngularVelocity(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_GetMaxAngularVelocity(_UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Generated from method `JPH::BodyInterface::GetUseManifoldReduction`.
        public unsafe bool GetUseManifoldReduction(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_BodyInterface_GetUseManifoldReduction(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_GetUseManifoldReduction(_UnderlyingPtr, __ptr_inBodyID) != 0;
            }
        }

        /// Generated from method `JPH::BodyInterface::IsSensor`.
        public unsafe bool IsSensor(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_IsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_IsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_BodyInterface_IsSensor(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_IsSensor(_UnderlyingPtr, __ptr_inBodyID) != 0;
            }
        }

        /// Generated from method `JPH::BodyInterface::GetCollisionGroup`.
        public unsafe JPH.Const_CollisionGroup GetCollisionGroup(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_CollisionGroup._Underlying *__JPH_BodyInterface_GetCollisionGroup(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return new(__JPH_BodyInterface_GetCollisionGroup(_UnderlyingPtr, __ptr_inBodyID), is_owning: false);
            }
        }

        /// Get transform and shape for this body, used to perform collision detection
        /// Generated from method `JPH::BodyInterface::GetTransformedShape`.
        public unsafe JPH.TransformedShape GetTransformedShape(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetTransformedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetTransformedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TransformedShape._Underlying *__JPH_BodyInterface_GetTransformedShape(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return new(__JPH_BodyInterface_GetTransformedShape(_UnderlyingPtr, __ptr_inBodyID), is_owning: true);
            }
        }

        /// Get the user data for a body
        /// Generated from method `JPH::BodyInterface::GetUserData`.
        public unsafe UIntPtr GetUserData(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __JPH_BodyInterface_GetUserData(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_GetUserData(_UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Generated from method `JPH::BodyInterface::SetUserData`.
        public unsafe void SetUserData(in JPH.BodyID inBodyID, UIntPtr inUserData)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetUserData(_Underlying *_this, JPH.BodyID *inBodyID, UIntPtr inUserData);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetUserData(_UnderlyingPtr, __ptr_inBodyID, inUserData);
            }
        }

        /// Get the material for a particular sub shape
        /// Generated from method `JPH::BodyInterface::GetMaterial`.
        public unsafe JPH.Const_PhysicsMaterial? GetMaterial(in JPH.BodyID inBodyID, JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_PhysicsMaterial._Underlying *__JPH_BodyInterface_GetMaterial(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                var __c_ret = __JPH_BodyInterface_GetMaterial(_UnderlyingPtr, __ptr_inBodyID, inSubShapeID._UnderlyingPtr);
                return __c_ret is not null ? new JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
            }
        }
    }

    /// Class that provides operations on bodies using a body ID. Note that if you need to do multiple operations on a single body, it is more efficient to lock the body once and combine the operations.
    /// All quantities are in world space unless otherwise specified.
    /// Generated from class `JPH::BodyInterface`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class BodyInterface : Const_BodyInterface
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(BodyInterface self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_BodyInterface_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_BodyInterface_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe BodyInterface(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe BodyInterface() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyInterface._Underlying *__JPH_BodyInterface_DefaultConstruct();
            _UnderlyingPtr = __JPH_BodyInterface_DefaultConstruct();
        }

        /// Create a rigid body
        /// @return Created body or null when out of bodies
        /// Generated from method `JPH::BodyInterface::CreateBody`.
        public unsafe JPH.Body? CreateBody(JPH.Const_BodyCreationSettings inSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_CreateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_CreateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Body._Underlying *__JPH_BodyInterface_CreateBody(_Underlying *_this, JPH.Const_BodyCreationSettings._Underlying *inSettings);
            var __c_ret = __JPH_BodyInterface_CreateBody(_UnderlyingPtr, inSettings._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Body(__c_ret, is_owning: false) : null;
        }

        /// Create a soft body
        /// @return Created body or null when out of bodies
        /// Generated from method `JPH::BodyInterface::CreateSoftBody`.
        public unsafe JPH.Body? CreateSoftBody(JPH.Const_SoftBodyCreationSettings inSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_CreateSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_CreateSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Body._Underlying *__JPH_BodyInterface_CreateSoftBody(_Underlying *_this, JPH.Const_SoftBodyCreationSettings._Underlying *inSettings);
            var __c_ret = __JPH_BodyInterface_CreateSoftBody(_UnderlyingPtr, inSettings._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Body(__c_ret, is_owning: false) : null;
        }

        /// Create a rigid body with specified ID. This function can be used if a simulation is to run in sync between clients or if a simulation needs to be restored exactly.
        /// The ID created on the server can be replicated to the client and used to create a deterministic simulation.
        /// @return Created body or null when the body ID is invalid or a body of the same ID already exists.
        /// Generated from method `JPH::BodyInterface::CreateBodyWithID`.
        public unsafe JPH.Body? CreateBodyWithID(in JPH.BodyID inBodyID, JPH.Const_BodyCreationSettings inSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_CreateBodyWithID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_CreateBodyWithID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Body._Underlying *__JPH_BodyInterface_CreateBodyWithID(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Const_BodyCreationSettings._Underlying *inSettings);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                var __c_ret = __JPH_BodyInterface_CreateBodyWithID(_UnderlyingPtr, __ptr_inBodyID, inSettings._UnderlyingPtr);
                return __c_ret is not null ? new JPH.Body(__c_ret, is_owning: false) : null;
            }
        }

        /// Create a soft body with specified ID. See comments at CreateBodyWithID.
        /// Generated from method `JPH::BodyInterface::CreateSoftBodyWithID`.
        public unsafe JPH.Body? CreateSoftBodyWithID(in JPH.BodyID inBodyID, JPH.Const_SoftBodyCreationSettings inSettings)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_CreateSoftBodyWithID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_CreateSoftBodyWithID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Body._Underlying *__JPH_BodyInterface_CreateSoftBodyWithID(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Const_SoftBodyCreationSettings._Underlying *inSettings);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                var __c_ret = __JPH_BodyInterface_CreateSoftBodyWithID(_UnderlyingPtr, __ptr_inBodyID, inSettings._UnderlyingPtr);
                return __c_ret is not null ? new JPH.Body(__c_ret, is_owning: false) : null;
            }
        }

        /// Advanced use only. Assigns the next available body ID to a body that was created using CreateBodyWithoutID. After this call, the body can be added to the physics system.
        /// @return false if the body already has an ID or out of body ids.
        /// Generated from method `JPH::BodyInterface::AssignBodyID`.
        public unsafe bool AssignBodyID(JPH.Body? ioBody)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AssignBodyID_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AssignBodyID_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_BodyInterface_AssignBodyID_1(_Underlying *_this, JPH.Body._Underlying *ioBody);
            return __JPH_BodyInterface_AssignBodyID_1(_UnderlyingPtr, ioBody is not null ? ioBody._UnderlyingPtr : null) != 0;
        }

        /// Advanced use only. Assigns a body ID to a body that was created using CreateBodyWithoutID. After this call, the body can be added to the physics system.
        /// @return false if the body already has an ID or if the ID is not valid.
        /// Generated from method `JPH::BodyInterface::AssignBodyID`.
        public unsafe bool AssignBodyID(JPH.Body? ioBody, in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AssignBodyID_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AssignBodyID_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_BodyInterface_AssignBodyID_2(_Underlying *_this, JPH.Body._Underlying *ioBody, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_AssignBodyID_2(_UnderlyingPtr, ioBody is not null ? ioBody._UnderlyingPtr : null, __ptr_inBodyID) != 0;
            }
        }

        /// Advanced use only. See UnassignBodyIDs. Unassigns the ID of a single body.
        /// Generated from method `JPH::BodyInterface::UnassignBodyID`.
        public unsafe JPH.Body? UnassignBodyID(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_UnassignBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_UnassignBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Body._Underlying *__JPH_BodyInterface_UnassignBodyID(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                var __c_ret = __JPH_BodyInterface_UnassignBodyID(_UnderlyingPtr, __ptr_inBodyID);
                return __c_ret is not null ? new JPH.Body(__c_ret, is_owning: false) : null;
            }
        }

        /// Advanced use only. Removes a number of body IDs from their bodies and returns the body pointers. Before calling this, the body should have been removed from the physics system.
        /// The body can be destroyed through DestroyBodyWithoutID. This can be used to decouple deallocation. A call to UnassignBodyIDs followed by calls to DestroyBodyWithoutID is equivalent to calling DestroyBodies.
        /// @param inBodyIDs A list of body IDs
        /// @param inNumber Number of bodies in the list
        /// @param outBodies If not null on input, this will contain a list of body pointers corresponding to inBodyIDs that can be destroyed afterwards (caller assumes ownership over these).
        /// Generated from method `JPH::BodyInterface::UnassignBodyIDs`.
        public unsafe void UnassignBodyIDs(JPH.BodyID? inBodyIDs, int inNumber, void **outBodies)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_UnassignBodyIDs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_UnassignBodyIDs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_UnassignBodyIDs(_Underlying *_this, JPH.BodyID *inBodyIDs, int inNumber, void **outBodies);
            JPH.BodyID __deref_inBodyIDs = inBodyIDs.GetValueOrDefault();
            __JPH_BodyInterface_UnassignBodyIDs(_UnderlyingPtr, inBodyIDs.HasValue ? &__deref_inBodyIDs : null, inNumber, outBodies);
        }

        /// Destroy a body.
        /// Make sure that you remove the body from the physics system using BodyInterface::RemoveBody before calling this function.
        /// Generated from method `JPH::BodyInterface::DestroyBody`.
        public unsafe void DestroyBody(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_DestroyBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_DestroyBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_DestroyBody(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_DestroyBody(_UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Destroy multiple bodies
        /// Make sure that you remove the bodies from the physics system using BodyInterface::RemoveBody before calling this function.
        /// Generated from method `JPH::BodyInterface::DestroyBodies`.
        public unsafe void DestroyBodies(JPH.BodyID? inBodyIDs, int inNumber)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_DestroyBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_DestroyBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_DestroyBodies(_Underlying *_this, JPH.BodyID *inBodyIDs, int inNumber);
            JPH.BodyID __deref_inBodyIDs = inBodyIDs.GetValueOrDefault();
            __JPH_BodyInterface_DestroyBodies(_UnderlyingPtr, inBodyIDs.HasValue ? &__deref_inBodyIDs : null, inNumber);
        }

        /// Add body to the physics system.
        /// Note that if you need to add multiple bodies, use the AddBodiesPrepare/AddBodiesFinalize function.
        /// Adding many bodies, one at a time, results in a really inefficient broadphase until PhysicsSystem::OptimizeBroadPhase is called or when PhysicsSystem::Update rebuilds the tree!
        /// After adding, to get a body by ID use the BodyLockRead or BodyLockWrite interface!
        /// Generated from method `JPH::BodyInterface::AddBody`.
        public unsafe void AddBody(in JPH.BodyID inBodyID, JPH.EActivation inActivationMode)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AddBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AddBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_AddBody(_Underlying *_this, JPH.BodyID *inBodyID, JPH.EActivation inActivationMode);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_AddBody(_UnderlyingPtr, __ptr_inBodyID, inActivationMode);
            }
        }

        /// Remove body from the physics system. Note that you need to add a body to the physics system before you can remove it.
        /// Generated from method `JPH::BodyInterface::RemoveBody`.
        public unsafe void RemoveBody(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_RemoveBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_RemoveBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_RemoveBody(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_RemoveBody(_UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Combines CreateBody and AddBody
        /// @return Created body ID or an invalid ID when out of bodies
        /// Generated from method `JPH::BodyInterface::CreateAndAddBody`.
        public unsafe JPH.BodyID CreateAndAddBody(JPH.Const_BodyCreationSettings inSettings, JPH.EActivation inActivationMode)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_CreateAndAddBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_CreateAndAddBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID __JPH_BodyInterface_CreateAndAddBody(_Underlying *_this, JPH.Const_BodyCreationSettings._Underlying *inSettings, JPH.EActivation inActivationMode);
            return __JPH_BodyInterface_CreateAndAddBody(_UnderlyingPtr, inSettings._UnderlyingPtr, inActivationMode);
        }

        /// Combines CreateSoftBody and AddBody
        /// @return Created body ID or an invalid ID when out of bodies
        /// Generated from method `JPH::BodyInterface::CreateAndAddSoftBody`.
        public unsafe JPH.BodyID CreateAndAddSoftBody(JPH.Const_SoftBodyCreationSettings inSettings, JPH.EActivation inActivationMode)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_CreateAndAddSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_CreateAndAddSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID __JPH_BodyInterface_CreateAndAddSoftBody(_Underlying *_this, JPH.Const_SoftBodyCreationSettings._Underlying *inSettings, JPH.EActivation inActivationMode);
            return __JPH_BodyInterface_CreateAndAddSoftBody(_UnderlyingPtr, inSettings._UnderlyingPtr, inActivationMode);
        }

        /// Prepare adding inNumber bodies at ioBodies to the PhysicsSystem, returns a handle that should be used in AddBodiesFinalize/Abort.
        /// This can be done on a background thread without influencing the PhysicsSystem.
        /// ioBodies may be shuffled around by this function and should be kept that way until AddBodiesFinalize/Abort is called.
        /// Generated from method `JPH::BodyInterface::AddBodiesPrepare`.
        /// Returns a mutable pointer.
        public unsafe void *AddBodiesPrepare(JPH.InOut<JPH.BodyID>? ioBodies, int inNumber)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AddBodiesPrepare", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AddBodiesPrepare", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_BodyInterface_AddBodiesPrepare(_Underlying *_this, JPH.BodyID *ioBodies, int inNumber);
            JPH.BodyID __value_ioBodies = ioBodies is not null ? ioBodies.Value : default(JPH.BodyID);
            var __c_ret = __JPH_BodyInterface_AddBodiesPrepare(_UnderlyingPtr, ioBodies is not null ? &__value_ioBodies : null, inNumber);
            if (ioBodies is not null) ioBodies.Value = __value_ioBodies;
            return __c_ret;
        }

        /// Finalize adding bodies to the PhysicsSystem, supply the return value of AddBodiesPrepare in inAddState.
        /// Please ensure that the ioBodies array passed to AddBodiesPrepare is unmodified and passed again to this function.
        /// Generated from method `JPH::BodyInterface::AddBodiesFinalize`.
        /// Parameter `inAddState` is a mutable pointer.
        public unsafe void AddBodiesFinalize(JPH.InOut<JPH.BodyID>? ioBodies, int inNumber, void *inAddState, JPH.EActivation inActivationMode)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AddBodiesFinalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AddBodiesFinalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_AddBodiesFinalize(_Underlying *_this, JPH.BodyID *ioBodies, int inNumber, void *inAddState, JPH.EActivation inActivationMode);
            JPH.BodyID __value_ioBodies = ioBodies is not null ? ioBodies.Value : default(JPH.BodyID);
            if (ioBodies is not null) ioBodies.Value = __value_ioBodies;
            __JPH_BodyInterface_AddBodiesFinalize(_UnderlyingPtr, ioBodies is not null ? &__value_ioBodies : null, inNumber, inAddState, inActivationMode);
        }

        /// Abort adding bodies to the PhysicsSystem, supply the return value of AddBodiesPrepare in inAddState.
        /// This can be done on a background thread without influencing the PhysicsSystem.
        /// Please ensure that the ioBodies array passed to AddBodiesPrepare is unmodified and passed again to this function.
        /// Generated from method `JPH::BodyInterface::AddBodiesAbort`.
        /// Parameter `inAddState` is a mutable pointer.
        public unsafe void AddBodiesAbort(JPH.InOut<JPH.BodyID>? ioBodies, int inNumber, void *inAddState)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AddBodiesAbort", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AddBodiesAbort", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_AddBodiesAbort(_Underlying *_this, JPH.BodyID *ioBodies, int inNumber, void *inAddState);
            JPH.BodyID __value_ioBodies = ioBodies is not null ? ioBodies.Value : default(JPH.BodyID);
            if (ioBodies is not null) ioBodies.Value = __value_ioBodies;
            __JPH_BodyInterface_AddBodiesAbort(_UnderlyingPtr, ioBodies is not null ? &__value_ioBodies : null, inNumber, inAddState);
        }

        /// Remove inNumber bodies in ioBodies from the PhysicsSystem. Note that bodies need to be added to the physics system before they can be removed.
        /// ioBodies may be shuffled around by this function.
        /// Generated from method `JPH::BodyInterface::RemoveBodies`.
        public unsafe void RemoveBodies(JPH.InOut<JPH.BodyID>? ioBodies, int inNumber)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_RemoveBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_RemoveBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_RemoveBodies(_Underlying *_this, JPH.BodyID *ioBodies, int inNumber);
            JPH.BodyID __value_ioBodies = ioBodies is not null ? ioBodies.Value : default(JPH.BodyID);
            if (ioBodies is not null) ioBodies.Value = __value_ioBodies;
            __JPH_BodyInterface_RemoveBodies(_UnderlyingPtr, ioBodies is not null ? &__value_ioBodies : null, inNumber);
        }

        ///@name Activate / deactivate a body. Note that you need to add a body to the physics system before you can activate it.
        ///@{
        /// Generated from method `JPH::BodyInterface::ActivateBody`.
        public unsafe void ActivateBody(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_ActivateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_ActivateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_ActivateBody(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_ActivateBody(_UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Generated from method `JPH::BodyInterface::ActivateBodies`.
        public unsafe void ActivateBodies(JPH.BodyID? inBodyIDs, int inNumber)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_ActivateBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_ActivateBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_ActivateBodies(_Underlying *_this, JPH.BodyID *inBodyIDs, int inNumber);
            JPH.BodyID __deref_inBodyIDs = inBodyIDs.GetValueOrDefault();
            __JPH_BodyInterface_ActivateBodies(_UnderlyingPtr, inBodyIDs.HasValue ? &__deref_inBodyIDs : null, inNumber);
        }

        /// Generated from method `JPH::BodyInterface::ActivateBodiesInAABox`.
        public unsafe void ActivateBodiesInAABox(JPH.Const_AABox inBox, JPH.Const_BroadPhaseLayerFilter inBroadPhaseLayerFilter, JPH.Const_ObjectLayerFilter inObjectLayerFilter)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_ActivateBodiesInAABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_ActivateBodiesInAABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_ActivateBodiesInAABox(_Underlying *_this, JPH.Const_AABox._Underlying *inBox, JPH.Const_BroadPhaseLayerFilter._Underlying *inBroadPhaseLayerFilter, JPH.Const_ObjectLayerFilter._Underlying *inObjectLayerFilter);
            __JPH_BodyInterface_ActivateBodiesInAABox(_UnderlyingPtr, inBox._UnderlyingPtr, inBroadPhaseLayerFilter._UnderlyingPtr, inObjectLayerFilter._UnderlyingPtr);
        }

        /// Generated from method `JPH::BodyInterface::DeactivateBody`.
        public unsafe void DeactivateBody(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_DeactivateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_DeactivateBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_DeactivateBody(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_DeactivateBody(_UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Generated from method `JPH::BodyInterface::DeactivateBodies`.
        public unsafe void DeactivateBodies(JPH.BodyID? inBodyIDs, int inNumber)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_DeactivateBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_DeactivateBodies", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_DeactivateBodies(_Underlying *_this, JPH.BodyID *inBodyIDs, int inNumber);
            JPH.BodyID __deref_inBodyIDs = inBodyIDs.GetValueOrDefault();
            __JPH_BodyInterface_DeactivateBodies(_UnderlyingPtr, inBodyIDs.HasValue ? &__deref_inBodyIDs : null, inNumber);
        }

        /// Generated from method `JPH::BodyInterface::ResetSleepTimer`.
        public unsafe void ResetSleepTimer(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_ResetSleepTimer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_ResetSleepTimer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_ResetSleepTimer(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_ResetSleepTimer(_UnderlyingPtr, __ptr_inBodyID);
            }
        }

        /// Create a two body constraint
        /// Generated from method `JPH::BodyInterface::CreateConstraint`.
        public unsafe JPH.TwoBodyConstraint? CreateConstraint(JPH.Const_TwoBodyConstraintSettings? inSettings, in JPH.BodyID inBodyID1, in JPH.BodyID inBodyID2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_CreateConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_CreateConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TwoBodyConstraint._Underlying *__JPH_BodyInterface_CreateConstraint(_Underlying *_this, JPH.Const_TwoBodyConstraintSettings._Underlying *inSettings, JPH.BodyID *inBodyID1, JPH.BodyID *inBodyID2);
            fixed (JPH.BodyID *__ptr_inBodyID1 = &inBodyID1)
            {
                fixed (JPH.BodyID *__ptr_inBodyID2 = &inBodyID2)
                {
                    var __c_ret = __JPH_BodyInterface_CreateConstraint(_UnderlyingPtr, inSettings is not null ? inSettings._UnderlyingPtr : null, __ptr_inBodyID1, __ptr_inBodyID2);
                    return __c_ret is not null ? new JPH.TwoBodyConstraint(__c_ret, is_owning: false) : null;
                }
            }
        }

        /// Activate non-static bodies attached to a constraint.
        /// Note that the bodies involved in the constraint should be added to the physics system before activating a constraint.
        /// Generated from method `JPH::BodyInterface::ActivateConstraint`.
        public unsafe void ActivateConstraint(JPH.Const_TwoBodyConstraint? inConstraint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_ActivateConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_ActivateConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_ActivateConstraint(_Underlying *_this, JPH.Const_TwoBodyConstraint._Underlying *inConstraint);
            __JPH_BodyInterface_ActivateConstraint(_UnderlyingPtr, inConstraint is not null ? inConstraint._UnderlyingPtr : null);
        }

        ///@name Object layer of a body
        ///@{
        /// Generated from method `JPH::BodyInterface::SetObjectLayer`.
        public unsafe void SetObjectLayer(in JPH.BodyID inBodyID, ushort inLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetObjectLayer(_Underlying *_this, JPH.BodyID *inBodyID, ushort inLayer);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetObjectLayer(_UnderlyingPtr, __ptr_inBodyID, inLayer);
            }
        }

        ///@name Position and rotation of a body
        ///@{
        /// Generated from method `JPH::BodyInterface::SetPositionAndRotation`.
        public unsafe void SetPositionAndRotation(in JPH.BodyID inBodyID, JPH.Const_Vec3 inPosition, JPH.Const_Quat inRotation, JPH.EActivation inActivationMode)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetPositionAndRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetPositionAndRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetPositionAndRotation(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inPosition, JPH.Quat._Underlying *inRotation, JPH.EActivation inActivationMode);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetPositionAndRotation(_UnderlyingPtr, __ptr_inBodyID, inPosition._UnderlyingPtr, inRotation._UnderlyingPtr, inActivationMode);
            }
        }

        /// Generated from method `JPH::BodyInterface::SetPositionAndRotationWhenChanged`.
        public unsafe void SetPositionAndRotationWhenChanged(in JPH.BodyID inBodyID, JPH.Const_Vec3 inPosition, JPH.Const_Quat inRotation, JPH.EActivation inActivationMode)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetPositionAndRotationWhenChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetPositionAndRotationWhenChanged", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetPositionAndRotationWhenChanged(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inPosition, JPH.Quat._Underlying *inRotation, JPH.EActivation inActivationMode);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetPositionAndRotationWhenChanged(_UnderlyingPtr, __ptr_inBodyID, inPosition._UnderlyingPtr, inRotation._UnderlyingPtr, inActivationMode);
            }
        }

        /// Generated from method `JPH::BodyInterface::SetPosition`.
        public unsafe void SetPosition(in JPH.BodyID inBodyID, JPH.Const_Vec3 inPosition, JPH.EActivation inActivationMode)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetPosition(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inPosition, JPH.EActivation inActivationMode);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetPosition(_UnderlyingPtr, __ptr_inBodyID, inPosition._UnderlyingPtr, inActivationMode);
            }
        }

        /// Generated from method `JPH::BodyInterface::SetRotation`.
        public unsafe void SetRotation(in JPH.BodyID inBodyID, JPH.Const_Quat inRotation, JPH.EActivation inActivationMode)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetRotation(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Quat._Underlying *inRotation, JPH.EActivation inActivationMode);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetRotation(_UnderlyingPtr, __ptr_inBodyID, inRotation._UnderlyingPtr, inActivationMode);
            }
        }

        /// Set velocity of body such that it will be positioned at inTargetPosition/Rotation in inDeltaTime seconds (will activate body if needed)
        /// Generated from method `JPH::BodyInterface::MoveKinematic`.
        public unsafe void MoveKinematic(in JPH.BodyID inBodyID, JPH.Const_Vec3 inTargetPosition, JPH.Const_Quat inTargetRotation, float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_MoveKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_MoveKinematic", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_MoveKinematic(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inTargetPosition, JPH.Quat._Underlying *inTargetRotation, float inDeltaTime);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_MoveKinematic(_UnderlyingPtr, __ptr_inBodyID, inTargetPosition._UnderlyingPtr, inTargetRotation._UnderlyingPtr, inDeltaTime);
            }
        }

        /// Linear or angular velocity (functions will activate body if needed).
        /// Note that the linear velocity is the velocity of the center of mass, which may not coincide with the position of your object, to correct for this: \f$VelocityCOM = Velocity - AngularVelocity \times ShapeCOM\f$
        /// Generated from method `JPH::BodyInterface::SetLinearAndAngularVelocity`.
        public unsafe void SetLinearAndAngularVelocity(in JPH.BodyID inBodyID, JPH.Const_Vec3 inLinearVelocity, JPH.Const_Vec3 inAngularVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetLinearAndAngularVelocity(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inLinearVelocity, JPH.Vec3._Underlying *inAngularVelocity);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetLinearAndAngularVelocity(_UnderlyingPtr, __ptr_inBodyID, inLinearVelocity._UnderlyingPtr, inAngularVelocity._UnderlyingPtr);
            }
        }

        /// Generated from method `JPH::BodyInterface::SetLinearVelocity`.
        public unsafe void SetLinearVelocity(in JPH.BodyID inBodyID, JPH.Const_Vec3 inLinearVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetLinearVelocity(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inLinearVelocity);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetLinearVelocity(_UnderlyingPtr, __ptr_inBodyID, inLinearVelocity._UnderlyingPtr);
            }
        }

        /// Generated from method `JPH::BodyInterface::AddLinearVelocity`.
        public unsafe void AddLinearVelocity(in JPH.BodyID inBodyID, JPH.Const_Vec3 inLinearVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AddLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AddLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_AddLinearVelocity(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inLinearVelocity);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_AddLinearVelocity(_UnderlyingPtr, __ptr_inBodyID, inLinearVelocity._UnderlyingPtr);
            }
        }

        /// Generated from method `JPH::BodyInterface::AddLinearAndAngularVelocity`.
        public unsafe void AddLinearAndAngularVelocity(in JPH.BodyID inBodyID, JPH.Const_Vec3 inLinearVelocity, JPH.Const_Vec3 inAngularVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AddLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AddLinearAndAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_AddLinearAndAngularVelocity(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inLinearVelocity, JPH.Vec3._Underlying *inAngularVelocity);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_AddLinearAndAngularVelocity(_UnderlyingPtr, __ptr_inBodyID, inLinearVelocity._UnderlyingPtr, inAngularVelocity._UnderlyingPtr);
            }
        }

        /// Generated from method `JPH::BodyInterface::SetAngularVelocity`.
        public unsafe void SetAngularVelocity(in JPH.BodyID inBodyID, JPH.Const_Vec3 inAngularVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetAngularVelocity(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inAngularVelocity);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetAngularVelocity(_UnderlyingPtr, __ptr_inBodyID, inAngularVelocity._UnderlyingPtr);
            }
        }

        /// Set the complete motion state of a body.
        /// Note that the linear velocity is the velocity of the center of mass, which may not coincide with the position of your object, to correct for this: \f$VelocityCOM = Velocity - AngularVelocity \times ShapeCOM\f$
        /// Generated from method `JPH::BodyInterface::SetPositionRotationAndVelocity`.
        public unsafe void SetPositionRotationAndVelocity(in JPH.BodyID inBodyID, JPH.Const_Vec3 inPosition, JPH.Const_Quat inRotation, JPH.Const_Vec3 inLinearVelocity, JPH.Const_Vec3 inAngularVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetPositionRotationAndVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetPositionRotationAndVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetPositionRotationAndVelocity(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inPosition, JPH.Quat._Underlying *inRotation, JPH.Vec3._Underlying *inLinearVelocity, JPH.Vec3._Underlying *inAngularVelocity);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetPositionRotationAndVelocity(_UnderlyingPtr, __ptr_inBodyID, inPosition._UnderlyingPtr, inRotation._UnderlyingPtr, inLinearVelocity._UnderlyingPtr, inAngularVelocity._UnderlyingPtr);
            }
        }

        ///@name Add forces to the body. Note that you should add a body to the physics system before applying forces or torques.
        ///@{
        /// Generated from method `JPH::BodyInterface::AddForce`.
        /// Parameter `inActivationMode` defaults to `EActivation::Activate`.
        public unsafe void AddForce(in JPH.BodyID inBodyID, JPH.Const_Vec3 inForce, JPH.EActivation? inActivationMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AddForce_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AddForce_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_AddForce_3(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inForce, JPH.EActivation *inActivationMode);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                JPH.EActivation __deref_inActivationMode = inActivationMode.GetValueOrDefault();
                __JPH_BodyInterface_AddForce_3(_UnderlyingPtr, __ptr_inBodyID, inForce._UnderlyingPtr, inActivationMode.HasValue ? &__deref_inActivationMode : null);
            }
        }

        /// Generated from method `JPH::BodyInterface::AddForce`.
        /// Parameter `inActivationMode` defaults to `EActivation::Activate`.
        public unsafe void AddForce(in JPH.BodyID inBodyID, JPH.Const_Vec3 inForce, JPH.Const_Vec3 inPoint, JPH.EActivation? inActivationMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AddForce_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AddForce_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_AddForce_4(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inForce, JPH.Vec3._Underlying *inPoint, JPH.EActivation *inActivationMode);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                JPH.EActivation __deref_inActivationMode = inActivationMode.GetValueOrDefault();
                __JPH_BodyInterface_AddForce_4(_UnderlyingPtr, __ptr_inBodyID, inForce._UnderlyingPtr, inPoint._UnderlyingPtr, inActivationMode.HasValue ? &__deref_inActivationMode : null);
            }
        }

        /// Generated from method `JPH::BodyInterface::AddTorque`.
        /// Parameter `inActivationMode` defaults to `EActivation::Activate`.
        public unsafe void AddTorque(in JPH.BodyID inBodyID, JPH.Const_Vec3 inTorque, JPH.EActivation? inActivationMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AddTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AddTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_AddTorque(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inTorque, JPH.EActivation *inActivationMode);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                JPH.EActivation __deref_inActivationMode = inActivationMode.GetValueOrDefault();
                __JPH_BodyInterface_AddTorque(_UnderlyingPtr, __ptr_inBodyID, inTorque._UnderlyingPtr, inActivationMode.HasValue ? &__deref_inActivationMode : null);
            }
        }

        /// Generated from method `JPH::BodyInterface::AddForceAndTorque`.
        /// Parameter `inActivationMode` defaults to `EActivation::Activate`.
        public unsafe void AddForceAndTorque(in JPH.BodyID inBodyID, JPH.Const_Vec3 inForce, JPH.Const_Vec3 inTorque, JPH.EActivation? inActivationMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AddForceAndTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AddForceAndTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_AddForceAndTorque(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inForce, JPH.Vec3._Underlying *inTorque, JPH.EActivation *inActivationMode);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                JPH.EActivation __deref_inActivationMode = inActivationMode.GetValueOrDefault();
                __JPH_BodyInterface_AddForceAndTorque(_UnderlyingPtr, __ptr_inBodyID, inForce._UnderlyingPtr, inTorque._UnderlyingPtr, inActivationMode.HasValue ? &__deref_inActivationMode : null);
            }
        }

        ///@name Add an impulse to the body. Note that you should add a body to the physics system before applying impulses.
        ///@{
        /// Generated from method `JPH::BodyInterface::AddImpulse`.
        public unsafe void AddImpulse(in JPH.BodyID inBodyID, JPH.Const_Vec3 inImpulse)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AddImpulse_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AddImpulse_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_AddImpulse_2(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inImpulse);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_AddImpulse_2(_UnderlyingPtr, __ptr_inBodyID, inImpulse._UnderlyingPtr);
            }
        }

        /// Generated from method `JPH::BodyInterface::AddImpulse`.
        public unsafe void AddImpulse(in JPH.BodyID inBodyID, JPH.Const_Vec3 inImpulse, JPH.Const_Vec3 inPoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AddImpulse_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AddImpulse_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_AddImpulse_3(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inImpulse, JPH.Vec3._Underlying *inPoint);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_AddImpulse_3(_UnderlyingPtr, __ptr_inBodyID, inImpulse._UnderlyingPtr, inPoint._UnderlyingPtr);
            }
        }

        /// Generated from method `JPH::BodyInterface::AddAngularImpulse`.
        public unsafe void AddAngularImpulse(in JPH.BodyID inBodyID, JPH.Const_Vec3 inAngularImpulse)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_AddAngularImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_AddAngularImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_AddAngularImpulse(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inAngularImpulse);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_AddAngularImpulse(_UnderlyingPtr, __ptr_inBodyID, inAngularImpulse._UnderlyingPtr);
            }
        }

        /// Generated from method `JPH::BodyInterface::ApplyBuoyancyImpulse`.
        public unsafe bool ApplyBuoyancyImpulse(in JPH.BodyID inBodyID, JPH.Const_Vec3 inSurfacePosition, JPH.Const_Vec3 inSurfaceNormal, float inBuoyancy, float inLinearDrag, float inAngularDrag, JPH.Const_Vec3 inFluidVelocity, JPH.Const_Vec3 inGravity, float inDeltaTime)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_ApplyBuoyancyImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_ApplyBuoyancyImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_BodyInterface_ApplyBuoyancyImpulse(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Vec3._Underlying *inSurfacePosition, JPH.Vec3._Underlying *inSurfaceNormal, float inBuoyancy, float inLinearDrag, float inAngularDrag, JPH.Vec3._Underlying *inFluidVelocity, JPH.Vec3._Underlying *inGravity, float inDeltaTime);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                return __JPH_BodyInterface_ApplyBuoyancyImpulse(_UnderlyingPtr, __ptr_inBodyID, inSurfacePosition._UnderlyingPtr, inSurfaceNormal._UnderlyingPtr, inBuoyancy, inLinearDrag, inAngularDrag, inFluidVelocity._UnderlyingPtr, inGravity._UnderlyingPtr, inDeltaTime) != 0;
            }
        }

        ///@name Body motion type
        ///@{
        /// Generated from method `JPH::BodyInterface::SetMotionType`.
        public unsafe void SetMotionType(in JPH.BodyID inBodyID, JPH.EMotionType inMotionType, JPH.EActivation inActivationMode)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetMotionType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetMotionType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetMotionType(_Underlying *_this, JPH.BodyID *inBodyID, JPH.EMotionType inMotionType, JPH.EActivation inActivationMode);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetMotionType(_UnderlyingPtr, __ptr_inBodyID, inMotionType, inActivationMode);
            }
        }

        ///@name Body motion quality
        ///@{
        /// Generated from method `JPH::BodyInterface::SetMotionQuality`.
        public unsafe void SetMotionQuality(in JPH.BodyID inBodyID, JPH.EMotionQuality inMotionQuality)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetMotionQuality", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetMotionQuality(_Underlying *_this, JPH.BodyID *inBodyID, JPH.EMotionQuality inMotionQuality);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetMotionQuality(_UnderlyingPtr, __ptr_inBodyID, inMotionQuality);
            }
        }

        ///@name Restitution
        ///@{
        /// Generated from method `JPH::BodyInterface::SetRestitution`.
        public unsafe void SetRestitution(in JPH.BodyID inBodyID, float inRestitution)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetRestitution(_Underlying *_this, JPH.BodyID *inBodyID, float inRestitution);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetRestitution(_UnderlyingPtr, __ptr_inBodyID, inRestitution);
            }
        }

        ///@name Friction
        ///@{
        /// Generated from method `JPH::BodyInterface::SetFriction`.
        public unsafe void SetFriction(in JPH.BodyID inBodyID, float inFriction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetFriction(_Underlying *_this, JPH.BodyID *inBodyID, float inFriction);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetFriction(_UnderlyingPtr, __ptr_inBodyID, inFriction);
            }
        }

        ///@name Gravity factor
        ///@{
        /// Generated from method `JPH::BodyInterface::SetGravityFactor`.
        public unsafe void SetGravityFactor(in JPH.BodyID inBodyID, float inGravityFactor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetGravityFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetGravityFactor(_Underlying *_this, JPH.BodyID *inBodyID, float inGravityFactor);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetGravityFactor(_UnderlyingPtr, __ptr_inBodyID, inGravityFactor);
            }
        }

        ///@name Max linear velocity
        ///@{
        /// Generated from method `JPH::BodyInterface::SetMaxLinearVelocity`.
        public unsafe void SetMaxLinearVelocity(in JPH.BodyID inBodyID, float inLinearVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetMaxLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetMaxLinearVelocity(_Underlying *_this, JPH.BodyID *inBodyID, float inLinearVelocity);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetMaxLinearVelocity(_UnderlyingPtr, __ptr_inBodyID, inLinearVelocity);
            }
        }

        ///@name Max angular velocity
        ///@{
        /// Generated from method `JPH::BodyInterface::SetMaxAngularVelocity`.
        public unsafe void SetMaxAngularVelocity(in JPH.BodyID inBodyID, float inAngularVelocity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetMaxAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetMaxAngularVelocity(_Underlying *_this, JPH.BodyID *inBodyID, float inAngularVelocity);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetMaxAngularVelocity(_UnderlyingPtr, __ptr_inBodyID, inAngularVelocity);
            }
        }

        ///@name Manifold reduction
        ///@{
        /// Generated from method `JPH::BodyInterface::SetUseManifoldReduction`.
        public unsafe void SetUseManifoldReduction(in JPH.BodyID inBodyID, bool inUseReduction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetUseManifoldReduction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetUseManifoldReduction(_Underlying *_this, JPH.BodyID *inBodyID, byte inUseReduction);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetUseManifoldReduction(_UnderlyingPtr, __ptr_inBodyID, inUseReduction ? (byte)1 : (byte)0);
            }
        }

        ///@name Sensor
        ///@{
        /// Generated from method `JPH::BodyInterface::SetIsSensor`.
        public unsafe void SetIsSensor(in JPH.BodyID inBodyID, bool inIsSensor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetIsSensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetIsSensor(_Underlying *_this, JPH.BodyID *inBodyID, byte inIsSensor);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetIsSensor(_UnderlyingPtr, __ptr_inBodyID, inIsSensor ? (byte)1 : (byte)0);
            }
        }

        ///@name Collision group
        ///@{
        /// Generated from method `JPH::BodyInterface::SetCollisionGroup`.
        public unsafe void SetCollisionGroup(in JPH.BodyID inBodyID, JPH.Const_CollisionGroup inCollisionGroup)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_SetCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_SetCollisionGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_SetCollisionGroup(_Underlying *_this, JPH.BodyID *inBodyID, JPH.Const_CollisionGroup._Underlying *inCollisionGroup);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_SetCollisionGroup(_UnderlyingPtr, __ptr_inBodyID, inCollisionGroup._UnderlyingPtr);
            }
        }

        /// Set the Body::EFlags::InvalidateContactCache flag for the specified body. This means that the collision cache is invalid for any body pair involving that body until the next physics step.
        /// Generated from method `JPH::BodyInterface::InvalidateContactCache`.
        public unsafe void InvalidateContactCache(in JPH.BodyID inBodyID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_BodyInterface_InvalidateContactCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_BodyInterface_InvalidateContactCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_BodyInterface_InvalidateContactCache(_Underlying *_this, JPH.BodyID *inBodyID);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                __JPH_BodyInterface_InvalidateContactCache(_UnderlyingPtr, __ptr_inBodyID);
            }
        }
    }

    /// This is used as a function parameter when the underlying function receives `BodyInterface` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BodyInterface
    {
        #pragma warning disable CS0649
        internal readonly Const_BodyInterface? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_BodyInterface() {PassByMode = JPH._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `BodyInterface` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BodyInterface`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BodyInterface`/`Const_BodyInterface` directly.
    public class _InOptMut_BodyInterface
    {
        public BodyInterface? Opt;

        public _InOptMut_BodyInterface() {}
        public _InOptMut_BodyInterface(BodyInterface value) {Opt = value;}
        public static implicit operator _InOptMut_BodyInterface(BodyInterface value) {return new(value);}
    }

    /// This is used for optional parameters of class `BodyInterface` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BodyInterface`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BodyInterface`/`Const_BodyInterface` to pass it to the function.
    public class _InOptConst_BodyInterface
    {
        public Const_BodyInterface? Opt;

        public _InOptConst_BodyInterface() {}
        public _InOptConst_BodyInterface(Const_BodyInterface value) {Opt = value;}
        public static implicit operator _InOptConst_BodyInterface(Const_BodyInterface value) {return new(value);}
    }
}
