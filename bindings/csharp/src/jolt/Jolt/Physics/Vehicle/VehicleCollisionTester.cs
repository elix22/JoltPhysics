// machine generated, do not edit
public static partial class JPH
{
    /// Class that does collision detection between wheels and ground
    /// Generated from class `JPH::VehicleCollisionTester`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::VehicleCollisionTester>`
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleCollisionTesterCastCylinder`
    ///     `JPH::VehicleCollisionTesterCastSphere`
    ///     `JPH::VehicleCollisionTesterRay`
    /// This is the const half of the class.
    public class Const_VehicleCollisionTester : JPH.Object<Const_VehicleCollisionTester>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleCollisionTester_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleCollisionTester_Release(void *_this);
            __JPH_RefTarget_JPH_VehicleCollisionTester_Release(__JPH_VehicleCollisionTester_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_VehicleCollisionTester() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHVehicleCollisionTester(Const_VehicleCollisionTester self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHVehicleCollisionTester._Underlying *__JPH_VehicleCollisionTester_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            JPH.Const_RefTarget_JPHVehicleCollisionTester ret = new(__JPH_VehicleCollisionTester_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_VehicleCollisionTester self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_VehicleCollisionTester_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_VehicleCollisionTester_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_VehicleCollisionTester(JPH.Const_RefTarget_JPHVehicleCollisionTester parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH.Const_RefTarget_JPHVehicleCollisionTester._Underlying *_this);
            Const_VehicleCollisionTester ret = new(__JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_VehicleCollisionTester(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_VehicleCollisionTester ret = new(__JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_VehicleCollisionTester(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `JPH::VehicleCollisionTester::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTester_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTester_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleCollisionTester_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_VehicleCollisionTester_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleCollisionTester::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTester_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTester_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleCollisionTester_void_ptr(void *inPointer);
            __Jolt_delete_JPH_VehicleCollisionTester_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTester::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTester_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTester_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleCollisionTester_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_VehicleCollisionTester_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleCollisionTester::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTester_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTester_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleCollisionTester_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_VehicleCollisionTester_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleCollisionTester::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTester::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleCollisionTester::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTester_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTester_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleCollisionTester_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_VehicleCollisionTester_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTester::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTester_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTester_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleCollisionTester_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_VehicleCollisionTester_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::VehicleCollisionTester::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTester_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTester_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleCollisionTester_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_VehicleCollisionTester_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTester::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_VehicleCollisionTester_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Object layer to use for collision detection, this is used when the filters are not overridden
        /// Generated from method `JPH::VehicleCollisionTester::GetObjectLayer`.
        public unsafe ushort GetObjectLayer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_GetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_GetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ushort __JPH_VehicleCollisionTester_GetObjectLayer(_Underlying *_this);
            return __JPH_VehicleCollisionTester_GetObjectLayer(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleCollisionTester::GetBroadPhaseLayerFilter`.
        public unsafe JPH.Const_BroadPhaseLayerFilter? GetBroadPhaseLayerFilter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_GetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_GetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BroadPhaseLayerFilter._Underlying *__JPH_VehicleCollisionTester_GetBroadPhaseLayerFilter(_Underlying *_this);
            var __c_ret = __JPH_VehicleCollisionTester_GetBroadPhaseLayerFilter(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_BroadPhaseLayerFilter(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::VehicleCollisionTester::GetObjectLayerFilter`.
        public unsafe JPH.Const_ObjectLayerFilter? GetObjectLayerFilter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_GetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_GetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ObjectLayerFilter._Underlying *__JPH_VehicleCollisionTester_GetObjectLayerFilter(_Underlying *_this);
            var __c_ret = __JPH_VehicleCollisionTester_GetObjectLayerFilter(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_ObjectLayerFilter(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::VehicleCollisionTester::GetBodyFilter`.
        public unsafe JPH.Const_BodyFilter? GetBodyFilter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_GetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_GetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BodyFilter._Underlying *__JPH_VehicleCollisionTester_GetBodyFilter(_Underlying *_this);
            var __c_ret = __JPH_VehicleCollisionTester_GetBodyFilter(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_BodyFilter(__c_ret, is_owning: false) : null;
        }

        /// Do a collision test with the world
        /// @param inPhysicsSystem The physics system that should be tested against
        /// @param inVehicleConstraint The vehicle constraint
        /// @param inWheelIndex Index of the wheel that we're testing collision for
        /// @param inOrigin Origin for the test, corresponds to the world space position for the suspension attachment point
        /// @param inDirection Direction for the test (unit vector, world space)
        /// @param inVehicleBodyID This body should be filtered out during collision detection to avoid self collisions
        /// @param outBody Body that the wheel collided with
        /// @param outSubShapeID Sub shape ID that the wheel collided with
        /// @param outContactPosition Contact point between wheel and floor, in world space
        /// @param outContactNormal Contact normal between wheel and floor, pointing away from the floor
        /// @param outSuspensionLength New length of the suspension [0, inSuspensionMaxLength]
        /// @return True when collision found, false if not
        /// Generated from method `JPH::VehicleCollisionTester::Collide`.
        public unsafe bool Collide(JPH.PhysicsSystem inPhysicsSystem, JPH.Const_VehicleConstraint inVehicleConstraint, uint inWheelIndex, JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection, in JPH.BodyID inVehicleBodyID, ref void *outBody, JPH.SubShapeID outSubShapeID, JPH.Vec3 outContactPosition, JPH.Vec3 outContactNormal, ref float outSuspensionLength)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_Collide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_Collide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_VehicleCollisionTester_Collide(_Underlying *_this, JPH.PhysicsSystem._Underlying *inPhysicsSystem, JPH.Const_VehicleConstraint._Underlying *inVehicleConstraint, uint inWheelIndex, JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection, JPH.BodyID *inVehicleBodyID, void **outBody, JPH.SubShapeID._Underlying *outSubShapeID, JPH.Vec3._Underlying *outContactPosition, JPH.Vec3._Underlying *outContactNormal, float *outSuspensionLength);
            fixed (JPH.BodyID *__ptr_inVehicleBodyID = &inVehicleBodyID)
            {
                fixed (void **__ptr_outBody = &outBody)
                {
                    fixed (float *__ptr_outSuspensionLength = &outSuspensionLength)
                    {
                        return __JPH_VehicleCollisionTester_Collide(_UnderlyingPtr, inPhysicsSystem._UnderlyingPtr, inVehicleConstraint._UnderlyingPtr, inWheelIndex, inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr, __ptr_inVehicleBodyID, __ptr_outBody, outSubShapeID._UnderlyingPtr, outContactPosition._UnderlyingPtr, outContactNormal._UnderlyingPtr, __ptr_outSuspensionLength) != 0;
                    }
                }
            }
        }

        /// Do a cheap contact properties prediction based on the contact properties from the last collision test (provided as input parameters)
        /// @param inPhysicsSystem The physics system that should be tested against
        /// @param inVehicleConstraint The vehicle constraint
        /// @param inWheelIndex Index of the wheel that we're testing collision for
        /// @param inOrigin Origin for the test, corresponds to the world space position for the suspension attachment point
        /// @param inDirection Direction for the test (unit vector, world space)
        /// @param inVehicleBodyID The body ID for the vehicle itself
        /// @param ioBody Body that the wheel previously collided with
        /// @param ioSubShapeID Sub shape ID that the wheel collided with during the last check
        /// @param ioContactPosition Contact point between wheel and floor during the last check, in world space
        /// @param ioContactNormal Contact normal between wheel and floor during the last check, pointing away from the floor
        /// @param ioSuspensionLength New length of the suspension [0, inSuspensionMaxLength]
        /// Generated from method `JPH::VehicleCollisionTester::PredictContactProperties`.
        public unsafe void PredictContactProperties(JPH.PhysicsSystem inPhysicsSystem, JPH.Const_VehicleConstraint inVehicleConstraint, uint inWheelIndex, JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection, in JPH.BodyID inVehicleBodyID, ref void *ioBody, JPH.SubShapeID ioSubShapeID, JPH.Vec3 ioContactPosition, JPH.Vec3 ioContactNormal, ref float ioSuspensionLength)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_PredictContactProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_PredictContactProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTester_PredictContactProperties(_Underlying *_this, JPH.PhysicsSystem._Underlying *inPhysicsSystem, JPH.Const_VehicleConstraint._Underlying *inVehicleConstraint, uint inWheelIndex, JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection, JPH.BodyID *inVehicleBodyID, void **ioBody, JPH.SubShapeID._Underlying *ioSubShapeID, JPH.Vec3._Underlying *ioContactPosition, JPH.Vec3._Underlying *ioContactNormal, float *ioSuspensionLength);
            fixed (JPH.BodyID *__ptr_inVehicleBodyID = &inVehicleBodyID)
            {
                fixed (void **__ptr_ioBody = &ioBody)
                {
                    fixed (float *__ptr_ioSuspensionLength = &ioSuspensionLength)
                    {
                        __JPH_VehicleCollisionTester_PredictContactProperties(_UnderlyingPtr, inPhysicsSystem._UnderlyingPtr, inVehicleConstraint._UnderlyingPtr, inWheelIndex, inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr, __ptr_inVehicleBodyID, __ptr_ioBody, ioSubShapeID._UnderlyingPtr, ioContactPosition._UnderlyingPtr, ioContactNormal._UnderlyingPtr, __ptr_ioSuspensionLength);
                    }
                }
            }
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::VehicleCollisionTester::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTester_SetEmbedded(_Underlying *_this);
            __JPH_VehicleCollisionTester_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::VehicleCollisionTester::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_VehicleCollisionTester_GetRefCount(_Underlying *_this);
            return __JPH_VehicleCollisionTester_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::VehicleCollisionTester::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTester_AddRef(_Underlying *_this);
            __JPH_VehicleCollisionTester_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleCollisionTester::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTester_Release(_Underlying *_this);
            __JPH_VehicleCollisionTester_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::VehicleCollisionTester::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_VehicleCollisionTester_sInternalGetRefCountOffset();
            return __JPH_VehicleCollisionTester_sInternalGetRefCountOffset();
        }
    }

    /// Class that does collision detection between wheels and ground
    /// Generated from class `JPH::VehicleCollisionTester`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RefTarget<JPH::VehicleCollisionTester>`
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleCollisionTesterCastCylinder`
    ///     `JPH::VehicleCollisionTesterCastSphere`
    ///     `JPH::VehicleCollisionTesterRay`
    /// This is the non-const half of the class.
    public class VehicleCollisionTester : Const_VehicleCollisionTester
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHVehicleCollisionTester(VehicleCollisionTester self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleCollisionTester._Underlying *__JPH_VehicleCollisionTester_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            JPH.RefTarget_JPHVehicleCollisionTester ret = new(__JPH_VehicleCollisionTester_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHVehicleCollisionTester(VehicleCollisionTester self)
            => (JPH.Const_RefTarget_JPHVehicleCollisionTester)(JPH.Const_VehicleCollisionTester)self;
        public static unsafe implicit operator JPH.NonCopyable(VehicleCollisionTester self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_VehicleCollisionTester_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_VehicleCollisionTester_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(VehicleCollisionTester self)
            => (JPH.Const_NonCopyable)(JPH.Const_VehicleCollisionTester)self;

        // Downcasts:
        public static unsafe explicit operator VehicleCollisionTester(JPH.RefTarget_JPHVehicleCollisionTester parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH.RefTarget_JPHVehicleCollisionTester._Underlying *_this);
            VehicleCollisionTester ret = new(__JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator VehicleCollisionTester(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            VehicleCollisionTester ret = new(__JPH_VehicleCollisionTester_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe VehicleCollisionTester(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from method `JPH::VehicleCollisionTester::SetObjectLayer`.
        public unsafe void SetObjectLayer(ushort inObjectLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTester_SetObjectLayer(_Underlying *_this, ushort inObjectLayer);
            __JPH_VehicleCollisionTester_SetObjectLayer(_UnderlyingPtr, inObjectLayer);
        }

        /// Access to the broad phase layer filter, when set this overrides the object layer supplied in the constructor
        /// Generated from method `JPH::VehicleCollisionTester::SetBroadPhaseLayerFilter`.
        public unsafe void SetBroadPhaseLayerFilter(JPH.Const_BroadPhaseLayerFilter? inFilter)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_SetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_SetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTester_SetBroadPhaseLayerFilter(_Underlying *_this, JPH.Const_BroadPhaseLayerFilter._Underlying *inFilter);
            __JPH_VehicleCollisionTester_SetBroadPhaseLayerFilter(_UnderlyingPtr, inFilter is not null ? inFilter._UnderlyingPtr : null);
        }

        /// Access to the object layer filter, when set this overrides the object layer supplied in the constructor
        /// Generated from method `JPH::VehicleCollisionTester::SetObjectLayerFilter`.
        public unsafe void SetObjectLayerFilter(JPH.Const_ObjectLayerFilter? inFilter)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_SetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_SetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTester_SetObjectLayerFilter(_Underlying *_this, JPH.Const_ObjectLayerFilter._Underlying *inFilter);
            __JPH_VehicleCollisionTester_SetObjectLayerFilter(_UnderlyingPtr, inFilter is not null ? inFilter._UnderlyingPtr : null);
        }

        /// Access to the body filter, when set this overrides the default filter that filters out the vehicle body
        /// Generated from method `JPH::VehicleCollisionTester::SetBodyFilter`.
        public unsafe void SetBodyFilter(JPH.Const_BodyFilter? inFilter)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTester_SetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTester_SetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTester_SetBodyFilter(_Underlying *_this, JPH.Const_BodyFilter._Underlying *inFilter);
            __JPH_VehicleCollisionTester_SetBodyFilter(_UnderlyingPtr, inFilter is not null ? inFilter._UnderlyingPtr : null);
        }
    }

    /// This is used for optional parameters of class `VehicleCollisionTester` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_VehicleCollisionTester`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleCollisionTester`/`Const_VehicleCollisionTester` directly.
    public class _InOptMut_VehicleCollisionTester
    {
        public VehicleCollisionTester? Opt;

        public _InOptMut_VehicleCollisionTester() {}
        public _InOptMut_VehicleCollisionTester(VehicleCollisionTester value) {Opt = value;}
        public static implicit operator _InOptMut_VehicleCollisionTester(VehicleCollisionTester value) {return new(value);}
    }

    /// This is used for optional parameters of class `VehicleCollisionTester` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_VehicleCollisionTester`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleCollisionTester`/`Const_VehicleCollisionTester` to pass it to the function.
    public class _InOptConst_VehicleCollisionTester
    {
        public Const_VehicleCollisionTester? Opt;

        public _InOptConst_VehicleCollisionTester() {}
        public _InOptConst_VehicleCollisionTester(Const_VehicleCollisionTester value) {Opt = value;}
        public static implicit operator _InOptConst_VehicleCollisionTester(Const_VehicleCollisionTester value) {return new(value);}
    }

    /// Collision tester that tests collision using a raycast
    /// Generated from class `JPH::VehicleCollisionTesterRay`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleCollisionTester`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::VehicleCollisionTester>`
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_VehicleCollisionTesterRay : JPH.Object<Const_VehicleCollisionTesterRay>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleCollisionTester_Release(void *_this);
            __JPH_RefTarget_JPH_VehicleCollisionTester_Release(__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_VehicleCollisionTesterRay() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHVehicleCollisionTester(Const_VehicleCollisionTesterRay self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHVehicleCollisionTester._Underlying *__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            JPH.Const_RefTarget_JPHVehicleCollisionTester ret = new(__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_VehicleCollisionTesterRay self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_VehicleCollisionTester(Const_VehicleCollisionTesterRay self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleCollisionTester._Underlying *__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_VehicleCollisionTester(_Underlying *_this);
            JPH.Const_VehicleCollisionTester ret = new(__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_VehicleCollisionTester(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_VehicleCollisionTesterRay(JPH.Const_RefTarget_JPHVehicleCollisionTester parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH.Const_RefTarget_JPHVehicleCollisionTester._Underlying *_this);
            Const_VehicleCollisionTesterRay ret = new(__JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_VehicleCollisionTesterRay(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_VehicleCollisionTesterRay ret = new(__JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_VehicleCollisionTesterRay(JPH.Const_VehicleCollisionTester parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_VehicleCollisionTester(JPH.Const_VehicleCollisionTester._Underlying *_this);
            Const_VehicleCollisionTesterRay ret = new(__JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_VehicleCollisionTester(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_VehicleCollisionTesterRay(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// @param inObjectLayer Object layer to test collision with
        /// @param inUp World space up vector, used to avoid colliding with vertical walls.
        /// @param inMaxSlopeAngle Max angle (rad) that is considered for colliding wheels. This is to avoid colliding with vertical walls.
        /// Generated from constructor `JPH::VehicleCollisionTesterRay::VehicleCollisionTesterRay`.
        /// Parameter `inUp` defaults to `Vec3::sAxisY()`.
        /// Parameter `inMaxSlopeAngle` defaults to `DegreesToRadians(80.0f)`.
        public unsafe Const_VehicleCollisionTesterRay(ushort inObjectLayer, JPH.Const_Vec3? inUp = null, float? inMaxSlopeAngle = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleCollisionTesterRay._Underlying *__JPH_VehicleCollisionTesterRay_Construct(ushort inObjectLayer, JPH.Vec3._Underlying *inUp, float *inMaxSlopeAngle);
            float __deref_inMaxSlopeAngle = inMaxSlopeAngle.GetValueOrDefault();
            _UnderlyingPtr = __JPH_VehicleCollisionTesterRay_Construct(inObjectLayer, inUp is not null ? inUp._UnderlyingPtr : null, inMaxSlopeAngle.HasValue ? &__deref_inMaxSlopeAngle : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_UnderlyingPtr));
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTesterRay_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTesterRay_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleCollisionTesterRay_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_VehicleCollisionTesterRay_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr(void *inPointer);
            __Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTesterRay_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTesterRay_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleCollisionTesterRay_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_VehicleCollisionTesterRay_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTesterRay_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTesterRay_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleCollisionTesterRay_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_VehicleCollisionTesterRay_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_VehicleCollisionTesterRay_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTesterRay_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTesterRay_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleCollisionTesterRay_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_VehicleCollisionTesterRay_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_VehicleCollisionTesterRay_void_ptr_void_ptr(inPointer, inPlace);
        }

        // See: VehicleCollisionTester
        /// Generated from method `JPH::VehicleCollisionTesterRay::Collide`.
        public unsafe bool Collide(JPH.PhysicsSystem inPhysicsSystem, JPH.Const_VehicleConstraint inVehicleConstraint, uint inWheelIndex, JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection, in JPH.BodyID inVehicleBodyID, ref void *outBody, JPH.SubShapeID outSubShapeID, JPH.Vec3 outContactPosition, JPH.Vec3 outContactNormal, ref float outSuspensionLength)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_Collide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_Collide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_VehicleCollisionTesterRay_Collide(_Underlying *_this, JPH.PhysicsSystem._Underlying *inPhysicsSystem, JPH.Const_VehicleConstraint._Underlying *inVehicleConstraint, uint inWheelIndex, JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection, JPH.BodyID *inVehicleBodyID, void **outBody, JPH.SubShapeID._Underlying *outSubShapeID, JPH.Vec3._Underlying *outContactPosition, JPH.Vec3._Underlying *outContactNormal, float *outSuspensionLength);
            fixed (JPH.BodyID *__ptr_inVehicleBodyID = &inVehicleBodyID)
            {
                fixed (void **__ptr_outBody = &outBody)
                {
                    fixed (float *__ptr_outSuspensionLength = &outSuspensionLength)
                    {
                        return __JPH_VehicleCollisionTesterRay_Collide(_UnderlyingPtr, inPhysicsSystem._UnderlyingPtr, inVehicleConstraint._UnderlyingPtr, inWheelIndex, inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr, __ptr_inVehicleBodyID, __ptr_outBody, outSubShapeID._UnderlyingPtr, outContactPosition._UnderlyingPtr, outContactNormal._UnderlyingPtr, __ptr_outSuspensionLength) != 0;
                    }
                }
            }
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::PredictContactProperties`.
        public unsafe void PredictContactProperties(JPH.PhysicsSystem inPhysicsSystem, JPH.Const_VehicleConstraint inVehicleConstraint, uint inWheelIndex, JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection, in JPH.BodyID inVehicleBodyID, ref void *ioBody, JPH.SubShapeID ioSubShapeID, JPH.Vec3 ioContactPosition, JPH.Vec3 ioContactNormal, ref float ioSuspensionLength)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_PredictContactProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_PredictContactProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterRay_PredictContactProperties(_Underlying *_this, JPH.PhysicsSystem._Underlying *inPhysicsSystem, JPH.Const_VehicleConstraint._Underlying *inVehicleConstraint, uint inWheelIndex, JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection, JPH.BodyID *inVehicleBodyID, void **ioBody, JPH.SubShapeID._Underlying *ioSubShapeID, JPH.Vec3._Underlying *ioContactPosition, JPH.Vec3._Underlying *ioContactNormal, float *ioSuspensionLength);
            fixed (JPH.BodyID *__ptr_inVehicleBodyID = &inVehicleBodyID)
            {
                fixed (void **__ptr_ioBody = &ioBody)
                {
                    fixed (float *__ptr_ioSuspensionLength = &ioSuspensionLength)
                    {
                        __JPH_VehicleCollisionTesterRay_PredictContactProperties(_UnderlyingPtr, inPhysicsSystem._UnderlyingPtr, inVehicleConstraint._UnderlyingPtr, inWheelIndex, inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr, __ptr_inVehicleBodyID, __ptr_ioBody, ioSubShapeID._UnderlyingPtr, ioContactPosition._UnderlyingPtr, ioContactNormal._UnderlyingPtr, __ptr_ioSuspensionLength);
                    }
                }
            }
        }

        /// Object layer to use for collision detection, this is used when the filters are not overridden
        /// Generated from method `JPH::VehicleCollisionTesterRay::GetObjectLayer`.
        public unsafe ushort GetObjectLayer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_GetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_GetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ushort __JPH_VehicleCollisionTesterRay_GetObjectLayer(_Underlying *_this);
            return __JPH_VehicleCollisionTesterRay_GetObjectLayer(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::GetBroadPhaseLayerFilter`.
        public unsafe JPH.Const_BroadPhaseLayerFilter? GetBroadPhaseLayerFilter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_GetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_GetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BroadPhaseLayerFilter._Underlying *__JPH_VehicleCollisionTesterRay_GetBroadPhaseLayerFilter(_Underlying *_this);
            var __c_ret = __JPH_VehicleCollisionTesterRay_GetBroadPhaseLayerFilter(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_BroadPhaseLayerFilter(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::GetObjectLayerFilter`.
        public unsafe JPH.Const_ObjectLayerFilter? GetObjectLayerFilter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_GetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_GetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ObjectLayerFilter._Underlying *__JPH_VehicleCollisionTesterRay_GetObjectLayerFilter(_Underlying *_this);
            var __c_ret = __JPH_VehicleCollisionTesterRay_GetObjectLayerFilter(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_ObjectLayerFilter(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::GetBodyFilter`.
        public unsafe JPH.Const_BodyFilter? GetBodyFilter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_GetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_GetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BodyFilter._Underlying *__JPH_VehicleCollisionTesterRay_GetBodyFilter(_Underlying *_this);
            var __c_ret = __JPH_VehicleCollisionTesterRay_GetBodyFilter(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_BodyFilter(__c_ret, is_owning: false) : null;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::VehicleCollisionTesterRay::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterRay_SetEmbedded(_Underlying *_this);
            __JPH_VehicleCollisionTesterRay_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::VehicleCollisionTesterRay::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_VehicleCollisionTesterRay_GetRefCount(_Underlying *_this);
            return __JPH_VehicleCollisionTesterRay_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::VehicleCollisionTesterRay::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterRay_AddRef(_Underlying *_this);
            __JPH_VehicleCollisionTesterRay_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterRay_Release(_Underlying *_this);
            __JPH_VehicleCollisionTesterRay_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::VehicleCollisionTesterRay::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_VehicleCollisionTesterRay_sInternalGetRefCountOffset();
            return __JPH_VehicleCollisionTesterRay_sInternalGetRefCountOffset();
        }
    }

    /// Collision tester that tests collision using a raycast
    /// Generated from class `JPH::VehicleCollisionTesterRay`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleCollisionTester`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::VehicleCollisionTester>`
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class VehicleCollisionTesterRay : Const_VehicleCollisionTesterRay
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHVehicleCollisionTester(VehicleCollisionTesterRay self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleCollisionTester._Underlying *__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            JPH.RefTarget_JPHVehicleCollisionTester ret = new(__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHVehicleCollisionTester(VehicleCollisionTesterRay self)
            => (JPH.Const_RefTarget_JPHVehicleCollisionTester)(JPH.Const_VehicleCollisionTesterRay)self;
        public static unsafe implicit operator JPH.NonCopyable(VehicleCollisionTesterRay self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(VehicleCollisionTesterRay self)
            => (JPH.Const_NonCopyable)(JPH.Const_VehicleCollisionTesterRay)self;
        public static unsafe implicit operator JPH.VehicleCollisionTester(VehicleCollisionTesterRay self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleCollisionTester._Underlying *__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_VehicleCollisionTester(_Underlying *_this);
            JPH.VehicleCollisionTester ret = new(__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_VehicleCollisionTester(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_VehicleCollisionTester(VehicleCollisionTesterRay self)
            => (JPH.Const_VehicleCollisionTester)(JPH.Const_VehicleCollisionTesterRay)self;

        // Downcasts:
        public static unsafe explicit operator VehicleCollisionTesterRay(JPH.RefTarget_JPHVehicleCollisionTester parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH.RefTarget_JPHVehicleCollisionTester._Underlying *_this);
            VehicleCollisionTesterRay ret = new(__JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator VehicleCollisionTesterRay(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            VehicleCollisionTesterRay ret = new(__JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator VehicleCollisionTesterRay(JPH.VehicleCollisionTester parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_VehicleCollisionTester(JPH.VehicleCollisionTester._Underlying *_this);
            VehicleCollisionTesterRay ret = new(__JPH_VehicleCollisionTesterRay_StaticDowncastFrom_JPH_VehicleCollisionTester(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe VehicleCollisionTesterRay(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// @param inObjectLayer Object layer to test collision with
        /// @param inUp World space up vector, used to avoid colliding with vertical walls.
        /// @param inMaxSlopeAngle Max angle (rad) that is considered for colliding wheels. This is to avoid colliding with vertical walls.
        /// Generated from constructor `JPH::VehicleCollisionTesterRay::VehicleCollisionTesterRay`.
        /// Parameter `inUp` defaults to `Vec3::sAxisY()`.
        /// Parameter `inMaxSlopeAngle` defaults to `DegreesToRadians(80.0f)`.
        public unsafe VehicleCollisionTesterRay(ushort inObjectLayer, JPH.Const_Vec3? inUp = null, float? inMaxSlopeAngle = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleCollisionTesterRay._Underlying *__JPH_VehicleCollisionTesterRay_Construct(ushort inObjectLayer, JPH.Vec3._Underlying *inUp, float *inMaxSlopeAngle);
            float __deref_inMaxSlopeAngle = inMaxSlopeAngle.GetValueOrDefault();
            _UnderlyingPtr = __JPH_VehicleCollisionTesterRay_Construct(inObjectLayer, inUp is not null ? inUp._UnderlyingPtr : null, inMaxSlopeAngle.HasValue ? &__deref_inMaxSlopeAngle : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(__JPH_VehicleCollisionTesterRay_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_UnderlyingPtr));
        }

        /// Generated from method `JPH::VehicleCollisionTesterRay::SetObjectLayer`.
        public unsafe void SetObjectLayer(ushort inObjectLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterRay_SetObjectLayer(_Underlying *_this, ushort inObjectLayer);
            __JPH_VehicleCollisionTesterRay_SetObjectLayer(_UnderlyingPtr, inObjectLayer);
        }

        /// Access to the broad phase layer filter, when set this overrides the object layer supplied in the constructor
        /// Generated from method `JPH::VehicleCollisionTesterRay::SetBroadPhaseLayerFilter`.
        public unsafe void SetBroadPhaseLayerFilter(JPH.Const_BroadPhaseLayerFilter? inFilter)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_SetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_SetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterRay_SetBroadPhaseLayerFilter(_Underlying *_this, JPH.Const_BroadPhaseLayerFilter._Underlying *inFilter);
            __JPH_VehicleCollisionTesterRay_SetBroadPhaseLayerFilter(_UnderlyingPtr, inFilter is not null ? inFilter._UnderlyingPtr : null);
        }

        /// Access to the object layer filter, when set this overrides the object layer supplied in the constructor
        /// Generated from method `JPH::VehicleCollisionTesterRay::SetObjectLayerFilter`.
        public unsafe void SetObjectLayerFilter(JPH.Const_ObjectLayerFilter? inFilter)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_SetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_SetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterRay_SetObjectLayerFilter(_Underlying *_this, JPH.Const_ObjectLayerFilter._Underlying *inFilter);
            __JPH_VehicleCollisionTesterRay_SetObjectLayerFilter(_UnderlyingPtr, inFilter is not null ? inFilter._UnderlyingPtr : null);
        }

        /// Access to the body filter, when set this overrides the default filter that filters out the vehicle body
        /// Generated from method `JPH::VehicleCollisionTesterRay::SetBodyFilter`.
        public unsafe void SetBodyFilter(JPH.Const_BodyFilter? inFilter)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_SetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterRay_SetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterRay_SetBodyFilter(_Underlying *_this, JPH.Const_BodyFilter._Underlying *inFilter);
            __JPH_VehicleCollisionTesterRay_SetBodyFilter(_UnderlyingPtr, inFilter is not null ? inFilter._UnderlyingPtr : null);
        }
    }

    /// This is used for optional parameters of class `VehicleCollisionTesterRay` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_VehicleCollisionTesterRay`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleCollisionTesterRay`/`Const_VehicleCollisionTesterRay` directly.
    public class _InOptMut_VehicleCollisionTesterRay
    {
        public VehicleCollisionTesterRay? Opt;

        public _InOptMut_VehicleCollisionTesterRay() {}
        public _InOptMut_VehicleCollisionTesterRay(VehicleCollisionTesterRay value) {Opt = value;}
        public static implicit operator _InOptMut_VehicleCollisionTesterRay(VehicleCollisionTesterRay value) {return new(value);}
    }

    /// This is used for optional parameters of class `VehicleCollisionTesterRay` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_VehicleCollisionTesterRay`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleCollisionTesterRay`/`Const_VehicleCollisionTesterRay` to pass it to the function.
    public class _InOptConst_VehicleCollisionTesterRay
    {
        public Const_VehicleCollisionTesterRay? Opt;

        public _InOptConst_VehicleCollisionTesterRay() {}
        public _InOptConst_VehicleCollisionTesterRay(Const_VehicleCollisionTesterRay value) {Opt = value;}
        public static implicit operator _InOptConst_VehicleCollisionTesterRay(Const_VehicleCollisionTesterRay value) {return new(value);}
    }

    /// Collision tester that tests collision using a sphere cast
    /// Generated from class `JPH::VehicleCollisionTesterCastSphere`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleCollisionTester`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::VehicleCollisionTester>`
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_VehicleCollisionTesterCastSphere : JPH.Object<Const_VehicleCollisionTesterCastSphere>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleCollisionTester_Release(void *_this);
            __JPH_RefTarget_JPH_VehicleCollisionTester_Release(__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_VehicleCollisionTesterCastSphere() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHVehicleCollisionTester(Const_VehicleCollisionTesterCastSphere self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHVehicleCollisionTester._Underlying *__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            JPH.Const_RefTarget_JPHVehicleCollisionTester ret = new(__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_VehicleCollisionTesterCastSphere self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_VehicleCollisionTester(Const_VehicleCollisionTesterCastSphere self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleCollisionTester._Underlying *__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_VehicleCollisionTester(_Underlying *_this);
            JPH.Const_VehicleCollisionTester ret = new(__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_VehicleCollisionTester(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_VehicleCollisionTesterCastSphere(JPH.Const_RefTarget_JPHVehicleCollisionTester parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH.Const_RefTarget_JPHVehicleCollisionTester._Underlying *_this);
            Const_VehicleCollisionTesterCastSphere ret = new(__JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_VehicleCollisionTesterCastSphere(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_VehicleCollisionTesterCastSphere ret = new(__JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_VehicleCollisionTesterCastSphere(JPH.Const_VehicleCollisionTester parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_VehicleCollisionTester(JPH.Const_VehicleCollisionTester._Underlying *_this);
            Const_VehicleCollisionTesterCastSphere ret = new(__JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_VehicleCollisionTester(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_VehicleCollisionTesterCastSphere(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// @param inObjectLayer Object layer to test collision with
        /// @param inUp World space up vector, used to avoid colliding with vertical walls.
        /// @param inRadius Radius of sphere
        /// @param inMaxSlopeAngle Max angle (rad) that is considered for colliding wheels. This is to avoid colliding with vertical walls.
        /// Generated from constructor `JPH::VehicleCollisionTesterCastSphere::VehicleCollisionTesterCastSphere`.
        /// Parameter `inUp` defaults to `Vec3::sAxisY()`.
        /// Parameter `inMaxSlopeAngle` defaults to `DegreesToRadians(80.0f)`.
        public unsafe Const_VehicleCollisionTesterCastSphere(ushort inObjectLayer, float inRadius, JPH.Const_Vec3? inUp = null, float? inMaxSlopeAngle = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleCollisionTesterCastSphere._Underlying *__JPH_VehicleCollisionTesterCastSphere_Construct(ushort inObjectLayer, float inRadius, JPH.Vec3._Underlying *inUp, float *inMaxSlopeAngle);
            float __deref_inMaxSlopeAngle = inMaxSlopeAngle.GetValueOrDefault();
            _UnderlyingPtr = __JPH_VehicleCollisionTesterCastSphere_Construct(inObjectLayer, inRadius, inUp is not null ? inUp._UnderlyingPtr : null, inMaxSlopeAngle.HasValue ? &__deref_inMaxSlopeAngle : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_UnderlyingPtr));
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTesterCastSphere_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTesterCastSphere_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleCollisionTesterCastSphere_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_VehicleCollisionTesterCastSphere_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr(void *inPointer);
            __Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTesterCastSphere_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTesterCastSphere_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleCollisionTesterCastSphere_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_VehicleCollisionTesterCastSphere_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTesterCastSphere_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTesterCastSphere_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleCollisionTesterCastSphere_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_VehicleCollisionTesterCastSphere_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_VehicleCollisionTesterCastSphere_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTesterCastSphere_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTesterCastSphere_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleCollisionTesterCastSphere_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_VehicleCollisionTesterCastSphere_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_VehicleCollisionTesterCastSphere_void_ptr_void_ptr(inPointer, inPlace);
        }

        // See: VehicleCollisionTester
        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::Collide`.
        public unsafe bool Collide(JPH.PhysicsSystem inPhysicsSystem, JPH.Const_VehicleConstraint inVehicleConstraint, uint inWheelIndex, JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection, in JPH.BodyID inVehicleBodyID, ref void *outBody, JPH.SubShapeID outSubShapeID, JPH.Vec3 outContactPosition, JPH.Vec3 outContactNormal, ref float outSuspensionLength)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_Collide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_Collide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_VehicleCollisionTesterCastSphere_Collide(_Underlying *_this, JPH.PhysicsSystem._Underlying *inPhysicsSystem, JPH.Const_VehicleConstraint._Underlying *inVehicleConstraint, uint inWheelIndex, JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection, JPH.BodyID *inVehicleBodyID, void **outBody, JPH.SubShapeID._Underlying *outSubShapeID, JPH.Vec3._Underlying *outContactPosition, JPH.Vec3._Underlying *outContactNormal, float *outSuspensionLength);
            fixed (JPH.BodyID *__ptr_inVehicleBodyID = &inVehicleBodyID)
            {
                fixed (void **__ptr_outBody = &outBody)
                {
                    fixed (float *__ptr_outSuspensionLength = &outSuspensionLength)
                    {
                        return __JPH_VehicleCollisionTesterCastSphere_Collide(_UnderlyingPtr, inPhysicsSystem._UnderlyingPtr, inVehicleConstraint._UnderlyingPtr, inWheelIndex, inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr, __ptr_inVehicleBodyID, __ptr_outBody, outSubShapeID._UnderlyingPtr, outContactPosition._UnderlyingPtr, outContactNormal._UnderlyingPtr, __ptr_outSuspensionLength) != 0;
                    }
                }
            }
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::PredictContactProperties`.
        public unsafe void PredictContactProperties(JPH.PhysicsSystem inPhysicsSystem, JPH.Const_VehicleConstraint inVehicleConstraint, uint inWheelIndex, JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection, in JPH.BodyID inVehicleBodyID, ref void *ioBody, JPH.SubShapeID ioSubShapeID, JPH.Vec3 ioContactPosition, JPH.Vec3 ioContactNormal, ref float ioSuspensionLength)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_PredictContactProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_PredictContactProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastSphere_PredictContactProperties(_Underlying *_this, JPH.PhysicsSystem._Underlying *inPhysicsSystem, JPH.Const_VehicleConstraint._Underlying *inVehicleConstraint, uint inWheelIndex, JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection, JPH.BodyID *inVehicleBodyID, void **ioBody, JPH.SubShapeID._Underlying *ioSubShapeID, JPH.Vec3._Underlying *ioContactPosition, JPH.Vec3._Underlying *ioContactNormal, float *ioSuspensionLength);
            fixed (JPH.BodyID *__ptr_inVehicleBodyID = &inVehicleBodyID)
            {
                fixed (void **__ptr_ioBody = &ioBody)
                {
                    fixed (float *__ptr_ioSuspensionLength = &ioSuspensionLength)
                    {
                        __JPH_VehicleCollisionTesterCastSphere_PredictContactProperties(_UnderlyingPtr, inPhysicsSystem._UnderlyingPtr, inVehicleConstraint._UnderlyingPtr, inWheelIndex, inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr, __ptr_inVehicleBodyID, __ptr_ioBody, ioSubShapeID._UnderlyingPtr, ioContactPosition._UnderlyingPtr, ioContactNormal._UnderlyingPtr, __ptr_ioSuspensionLength);
                    }
                }
            }
        }

        /// Object layer to use for collision detection, this is used when the filters are not overridden
        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::GetObjectLayer`.
        public unsafe ushort GetObjectLayer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_GetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_GetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ushort __JPH_VehicleCollisionTesterCastSphere_GetObjectLayer(_Underlying *_this);
            return __JPH_VehicleCollisionTesterCastSphere_GetObjectLayer(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::GetBroadPhaseLayerFilter`.
        public unsafe JPH.Const_BroadPhaseLayerFilter? GetBroadPhaseLayerFilter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_GetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_GetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BroadPhaseLayerFilter._Underlying *__JPH_VehicleCollisionTesterCastSphere_GetBroadPhaseLayerFilter(_Underlying *_this);
            var __c_ret = __JPH_VehicleCollisionTesterCastSphere_GetBroadPhaseLayerFilter(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_BroadPhaseLayerFilter(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::GetObjectLayerFilter`.
        public unsafe JPH.Const_ObjectLayerFilter? GetObjectLayerFilter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_GetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_GetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ObjectLayerFilter._Underlying *__JPH_VehicleCollisionTesterCastSphere_GetObjectLayerFilter(_Underlying *_this);
            var __c_ret = __JPH_VehicleCollisionTesterCastSphere_GetObjectLayerFilter(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_ObjectLayerFilter(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::GetBodyFilter`.
        public unsafe JPH.Const_BodyFilter? GetBodyFilter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_GetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_GetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BodyFilter._Underlying *__JPH_VehicleCollisionTesterCastSphere_GetBodyFilter(_Underlying *_this);
            var __c_ret = __JPH_VehicleCollisionTesterCastSphere_GetBodyFilter(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_BodyFilter(__c_ret, is_owning: false) : null;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastSphere_SetEmbedded(_Underlying *_this);
            __JPH_VehicleCollisionTesterCastSphere_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_VehicleCollisionTesterCastSphere_GetRefCount(_Underlying *_this);
            return __JPH_VehicleCollisionTesterCastSphere_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastSphere_AddRef(_Underlying *_this);
            __JPH_VehicleCollisionTesterCastSphere_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastSphere_Release(_Underlying *_this);
            __JPH_VehicleCollisionTesterCastSphere_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_VehicleCollisionTesterCastSphere_sInternalGetRefCountOffset();
            return __JPH_VehicleCollisionTesterCastSphere_sInternalGetRefCountOffset();
        }
    }

    /// Collision tester that tests collision using a sphere cast
    /// Generated from class `JPH::VehicleCollisionTesterCastSphere`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleCollisionTester`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::VehicleCollisionTester>`
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class VehicleCollisionTesterCastSphere : Const_VehicleCollisionTesterCastSphere
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHVehicleCollisionTester(VehicleCollisionTesterCastSphere self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleCollisionTester._Underlying *__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            JPH.RefTarget_JPHVehicleCollisionTester ret = new(__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHVehicleCollisionTester(VehicleCollisionTesterCastSphere self)
            => (JPH.Const_RefTarget_JPHVehicleCollisionTester)(JPH.Const_VehicleCollisionTesterCastSphere)self;
        public static unsafe implicit operator JPH.NonCopyable(VehicleCollisionTesterCastSphere self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(VehicleCollisionTesterCastSphere self)
            => (JPH.Const_NonCopyable)(JPH.Const_VehicleCollisionTesterCastSphere)self;
        public static unsafe implicit operator JPH.VehicleCollisionTester(VehicleCollisionTesterCastSphere self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleCollisionTester._Underlying *__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_VehicleCollisionTester(_Underlying *_this);
            JPH.VehicleCollisionTester ret = new(__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_VehicleCollisionTester(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_VehicleCollisionTester(VehicleCollisionTesterCastSphere self)
            => (JPH.Const_VehicleCollisionTester)(JPH.Const_VehicleCollisionTesterCastSphere)self;

        // Downcasts:
        public static unsafe explicit operator VehicleCollisionTesterCastSphere(JPH.RefTarget_JPHVehicleCollisionTester parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH.RefTarget_JPHVehicleCollisionTester._Underlying *_this);
            VehicleCollisionTesterCastSphere ret = new(__JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator VehicleCollisionTesterCastSphere(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            VehicleCollisionTesterCastSphere ret = new(__JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator VehicleCollisionTesterCastSphere(JPH.VehicleCollisionTester parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_VehicleCollisionTester(JPH.VehicleCollisionTester._Underlying *_this);
            VehicleCollisionTesterCastSphere ret = new(__JPH_VehicleCollisionTesterCastSphere_StaticDowncastFrom_JPH_VehicleCollisionTester(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe VehicleCollisionTesterCastSphere(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// @param inObjectLayer Object layer to test collision with
        /// @param inUp World space up vector, used to avoid colliding with vertical walls.
        /// @param inRadius Radius of sphere
        /// @param inMaxSlopeAngle Max angle (rad) that is considered for colliding wheels. This is to avoid colliding with vertical walls.
        /// Generated from constructor `JPH::VehicleCollisionTesterCastSphere::VehicleCollisionTesterCastSphere`.
        /// Parameter `inUp` defaults to `Vec3::sAxisY()`.
        /// Parameter `inMaxSlopeAngle` defaults to `DegreesToRadians(80.0f)`.
        public unsafe VehicleCollisionTesterCastSphere(ushort inObjectLayer, float inRadius, JPH.Const_Vec3? inUp = null, float? inMaxSlopeAngle = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleCollisionTesterCastSphere._Underlying *__JPH_VehicleCollisionTesterCastSphere_Construct(ushort inObjectLayer, float inRadius, JPH.Vec3._Underlying *inUp, float *inMaxSlopeAngle);
            float __deref_inMaxSlopeAngle = inMaxSlopeAngle.GetValueOrDefault();
            _UnderlyingPtr = __JPH_VehicleCollisionTesterCastSphere_Construct(inObjectLayer, inRadius, inUp is not null ? inUp._UnderlyingPtr : null, inMaxSlopeAngle.HasValue ? &__deref_inMaxSlopeAngle : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(__JPH_VehicleCollisionTesterCastSphere_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_UnderlyingPtr));
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::SetObjectLayer`.
        public unsafe void SetObjectLayer(ushort inObjectLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastSphere_SetObjectLayer(_Underlying *_this, ushort inObjectLayer);
            __JPH_VehicleCollisionTesterCastSphere_SetObjectLayer(_UnderlyingPtr, inObjectLayer);
        }

        /// Access to the broad phase layer filter, when set this overrides the object layer supplied in the constructor
        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::SetBroadPhaseLayerFilter`.
        public unsafe void SetBroadPhaseLayerFilter(JPH.Const_BroadPhaseLayerFilter? inFilter)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_SetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_SetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastSphere_SetBroadPhaseLayerFilter(_Underlying *_this, JPH.Const_BroadPhaseLayerFilter._Underlying *inFilter);
            __JPH_VehicleCollisionTesterCastSphere_SetBroadPhaseLayerFilter(_UnderlyingPtr, inFilter is not null ? inFilter._UnderlyingPtr : null);
        }

        /// Access to the object layer filter, when set this overrides the object layer supplied in the constructor
        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::SetObjectLayerFilter`.
        public unsafe void SetObjectLayerFilter(JPH.Const_ObjectLayerFilter? inFilter)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_SetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_SetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastSphere_SetObjectLayerFilter(_Underlying *_this, JPH.Const_ObjectLayerFilter._Underlying *inFilter);
            __JPH_VehicleCollisionTesterCastSphere_SetObjectLayerFilter(_UnderlyingPtr, inFilter is not null ? inFilter._UnderlyingPtr : null);
        }

        /// Access to the body filter, when set this overrides the default filter that filters out the vehicle body
        /// Generated from method `JPH::VehicleCollisionTesterCastSphere::SetBodyFilter`.
        public unsafe void SetBodyFilter(JPH.Const_BodyFilter? inFilter)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_SetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastSphere_SetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastSphere_SetBodyFilter(_Underlying *_this, JPH.Const_BodyFilter._Underlying *inFilter);
            __JPH_VehicleCollisionTesterCastSphere_SetBodyFilter(_UnderlyingPtr, inFilter is not null ? inFilter._UnderlyingPtr : null);
        }
    }

    /// This is used for optional parameters of class `VehicleCollisionTesterCastSphere` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_VehicleCollisionTesterCastSphere`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleCollisionTesterCastSphere`/`Const_VehicleCollisionTesterCastSphere` directly.
    public class _InOptMut_VehicleCollisionTesterCastSphere
    {
        public VehicleCollisionTesterCastSphere? Opt;

        public _InOptMut_VehicleCollisionTesterCastSphere() {}
        public _InOptMut_VehicleCollisionTesterCastSphere(VehicleCollisionTesterCastSphere value) {Opt = value;}
        public static implicit operator _InOptMut_VehicleCollisionTesterCastSphere(VehicleCollisionTesterCastSphere value) {return new(value);}
    }

    /// This is used for optional parameters of class `VehicleCollisionTesterCastSphere` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_VehicleCollisionTesterCastSphere`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleCollisionTesterCastSphere`/`Const_VehicleCollisionTesterCastSphere` to pass it to the function.
    public class _InOptConst_VehicleCollisionTesterCastSphere
    {
        public Const_VehicleCollisionTesterCastSphere? Opt;

        public _InOptConst_VehicleCollisionTesterCastSphere() {}
        public _InOptConst_VehicleCollisionTesterCastSphere(Const_VehicleCollisionTesterCastSphere value) {Opt = value;}
        public static implicit operator _InOptConst_VehicleCollisionTesterCastSphere(Const_VehicleCollisionTesterCastSphere value) {return new(value);}
    }

    /// Collision tester that tests collision using a cylinder shape
    /// Generated from class `JPH::VehicleCollisionTesterCastCylinder`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleCollisionTester`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::VehicleCollisionTester>`
    ///     `JPH::NonCopyable`
    /// This is the const half of the class.
    public class Const_VehicleCollisionTesterCastCylinder : JPH.Object<Const_VehicleCollisionTesterCastCylinder>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleCollisionTester_Release(void *_this);
            __JPH_RefTarget_JPH_VehicleCollisionTester_Release(__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_VehicleCollisionTesterCastCylinder() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RefTarget_JPHVehicleCollisionTester(Const_VehicleCollisionTesterCastCylinder self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHVehicleCollisionTester._Underlying *__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            JPH.Const_RefTarget_JPHVehicleCollisionTester ret = new(__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_VehicleCollisionTesterCastCylinder self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_VehicleCollisionTester(Const_VehicleCollisionTesterCastCylinder self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleCollisionTester._Underlying *__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_VehicleCollisionTester(_Underlying *_this);
            JPH.Const_VehicleCollisionTester ret = new(__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_VehicleCollisionTester(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_VehicleCollisionTesterCastCylinder(JPH.Const_RefTarget_JPHVehicleCollisionTester parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH.Const_RefTarget_JPHVehicleCollisionTester._Underlying *_this);
            Const_VehicleCollisionTesterCastCylinder ret = new(__JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_VehicleCollisionTesterCastCylinder(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_VehicleCollisionTesterCastCylinder ret = new(__JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_VehicleCollisionTesterCastCylinder(JPH.Const_VehicleCollisionTester parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_VehicleCollisionTester(JPH.Const_VehicleCollisionTester._Underlying *_this);
            Const_VehicleCollisionTesterCastCylinder ret = new(__JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_VehicleCollisionTester(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_VehicleCollisionTesterCastCylinder(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructor
        /// @param inObjectLayer Object layer to test collision with
        /// @param inConvexRadiusFraction Fraction of half the wheel width (or wheel radius if it is smaller) that is used as the convex radius
        /// Generated from constructor `JPH::VehicleCollisionTesterCastCylinder::VehicleCollisionTesterCastCylinder`.
        /// Parameter `inConvexRadiusFraction` defaults to `0.100000001f`.
        public unsafe Const_VehicleCollisionTesterCastCylinder(ushort inObjectLayer, float? inConvexRadiusFraction = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleCollisionTesterCastCylinder._Underlying *__JPH_VehicleCollisionTesterCastCylinder_Construct(ushort inObjectLayer, float *inConvexRadiusFraction);
            float __deref_inConvexRadiusFraction = inConvexRadiusFraction.GetValueOrDefault();
            _UnderlyingPtr = __JPH_VehicleCollisionTesterCastCylinder_Construct(inObjectLayer, inConvexRadiusFraction.HasValue ? &__deref_inConvexRadiusFraction : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_UnderlyingPtr));
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTesterCastCylinder_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTesterCastCylinder_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleCollisionTesterCastCylinder_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_VehicleCollisionTesterCastCylinder_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr(void *inPointer);
            __Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTesterCastCylinder_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTesterCastCylinder_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleCollisionTesterCastCylinder_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_VehicleCollisionTesterCastCylinder_size_t(inCount);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr(inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTesterCastCylinder_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_VehicleCollisionTesterCastCylinder_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_VehicleCollisionTesterCastCylinder_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_VehicleCollisionTesterCastCylinder_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_VehicleCollisionTesterCastCylinder_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTesterCastCylinder_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_VehicleCollisionTesterCastCylinder_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_VehicleCollisionTesterCastCylinder_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_VehicleCollisionTesterCastCylinder_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_VehicleCollisionTesterCastCylinder_void_ptr_void_ptr(inPointer, inPlace);
        }

        // See: VehicleCollisionTester
        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::Collide`.
        public unsafe bool Collide(JPH.PhysicsSystem inPhysicsSystem, JPH.Const_VehicleConstraint inVehicleConstraint, uint inWheelIndex, JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection, in JPH.BodyID inVehicleBodyID, ref void *outBody, JPH.SubShapeID outSubShapeID, JPH.Vec3 outContactPosition, JPH.Vec3 outContactNormal, ref float outSuspensionLength)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_Collide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_Collide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_VehicleCollisionTesterCastCylinder_Collide(_Underlying *_this, JPH.PhysicsSystem._Underlying *inPhysicsSystem, JPH.Const_VehicleConstraint._Underlying *inVehicleConstraint, uint inWheelIndex, JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection, JPH.BodyID *inVehicleBodyID, void **outBody, JPH.SubShapeID._Underlying *outSubShapeID, JPH.Vec3._Underlying *outContactPosition, JPH.Vec3._Underlying *outContactNormal, float *outSuspensionLength);
            fixed (JPH.BodyID *__ptr_inVehicleBodyID = &inVehicleBodyID)
            {
                fixed (void **__ptr_outBody = &outBody)
                {
                    fixed (float *__ptr_outSuspensionLength = &outSuspensionLength)
                    {
                        return __JPH_VehicleCollisionTesterCastCylinder_Collide(_UnderlyingPtr, inPhysicsSystem._UnderlyingPtr, inVehicleConstraint._UnderlyingPtr, inWheelIndex, inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr, __ptr_inVehicleBodyID, __ptr_outBody, outSubShapeID._UnderlyingPtr, outContactPosition._UnderlyingPtr, outContactNormal._UnderlyingPtr, __ptr_outSuspensionLength) != 0;
                    }
                }
            }
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::PredictContactProperties`.
        public unsafe void PredictContactProperties(JPH.PhysicsSystem inPhysicsSystem, JPH.Const_VehicleConstraint inVehicleConstraint, uint inWheelIndex, JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection, in JPH.BodyID inVehicleBodyID, ref void *ioBody, JPH.SubShapeID ioSubShapeID, JPH.Vec3 ioContactPosition, JPH.Vec3 ioContactNormal, ref float ioSuspensionLength)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_PredictContactProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_PredictContactProperties", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastCylinder_PredictContactProperties(_Underlying *_this, JPH.PhysicsSystem._Underlying *inPhysicsSystem, JPH.Const_VehicleConstraint._Underlying *inVehicleConstraint, uint inWheelIndex, JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection, JPH.BodyID *inVehicleBodyID, void **ioBody, JPH.SubShapeID._Underlying *ioSubShapeID, JPH.Vec3._Underlying *ioContactPosition, JPH.Vec3._Underlying *ioContactNormal, float *ioSuspensionLength);
            fixed (JPH.BodyID *__ptr_inVehicleBodyID = &inVehicleBodyID)
            {
                fixed (void **__ptr_ioBody = &ioBody)
                {
                    fixed (float *__ptr_ioSuspensionLength = &ioSuspensionLength)
                    {
                        __JPH_VehicleCollisionTesterCastCylinder_PredictContactProperties(_UnderlyingPtr, inPhysicsSystem._UnderlyingPtr, inVehicleConstraint._UnderlyingPtr, inWheelIndex, inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr, __ptr_inVehicleBodyID, __ptr_ioBody, ioSubShapeID._UnderlyingPtr, ioContactPosition._UnderlyingPtr, ioContactNormal._UnderlyingPtr, __ptr_ioSuspensionLength);
                    }
                }
            }
        }

        /// Object layer to use for collision detection, this is used when the filters are not overridden
        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::GetObjectLayer`.
        public unsafe ushort GetObjectLayer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_GetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_GetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ushort __JPH_VehicleCollisionTesterCastCylinder_GetObjectLayer(_Underlying *_this);
            return __JPH_VehicleCollisionTesterCastCylinder_GetObjectLayer(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::GetBroadPhaseLayerFilter`.
        public unsafe JPH.Const_BroadPhaseLayerFilter? GetBroadPhaseLayerFilter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_GetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_GetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BroadPhaseLayerFilter._Underlying *__JPH_VehicleCollisionTesterCastCylinder_GetBroadPhaseLayerFilter(_Underlying *_this);
            var __c_ret = __JPH_VehicleCollisionTesterCastCylinder_GetBroadPhaseLayerFilter(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_BroadPhaseLayerFilter(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::GetObjectLayerFilter`.
        public unsafe JPH.Const_ObjectLayerFilter? GetObjectLayerFilter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_GetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_GetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ObjectLayerFilter._Underlying *__JPH_VehicleCollisionTesterCastCylinder_GetObjectLayerFilter(_Underlying *_this);
            var __c_ret = __JPH_VehicleCollisionTesterCastCylinder_GetObjectLayerFilter(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_ObjectLayerFilter(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::GetBodyFilter`.
        public unsafe JPH.Const_BodyFilter? GetBodyFilter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_GetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_GetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_BodyFilter._Underlying *__JPH_VehicleCollisionTesterCastCylinder_GetBodyFilter(_Underlying *_this);
            var __c_ret = __JPH_VehicleCollisionTesterCastCylinder_GetBodyFilter(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_BodyFilter(__c_ret, is_owning: false) : null;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastCylinder_SetEmbedded(_Underlying *_this);
            __JPH_VehicleCollisionTesterCastCylinder_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_VehicleCollisionTesterCastCylinder_GetRefCount(_Underlying *_this);
            return __JPH_VehicleCollisionTesterCastCylinder_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastCylinder_AddRef(_Underlying *_this);
            __JPH_VehicleCollisionTesterCastCylinder_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastCylinder_Release(_Underlying *_this);
            __JPH_VehicleCollisionTesterCastCylinder_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_VehicleCollisionTesterCastCylinder_sInternalGetRefCountOffset();
            return __JPH_VehicleCollisionTesterCastCylinder_sInternalGetRefCountOffset();
        }
    }

    /// Collision tester that tests collision using a cylinder shape
    /// Generated from class `JPH::VehicleCollisionTesterCastCylinder`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::VehicleCollisionTester`
    ///   Indirect: (non-virtual)
    ///     `JPH::RefTarget<JPH::VehicleCollisionTester>`
    ///     `JPH::NonCopyable`
    /// This is the non-const half of the class.
    public class VehicleCollisionTesterCastCylinder : Const_VehicleCollisionTesterCastCylinder
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RefTarget_JPHVehicleCollisionTester(VehicleCollisionTesterCastCylinder self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHVehicleCollisionTester._Underlying *__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            JPH.RefTarget_JPHVehicleCollisionTester ret = new(__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHVehicleCollisionTester(VehicleCollisionTesterCastCylinder self)
            => (JPH.Const_RefTarget_JPHVehicleCollisionTester)(JPH.Const_VehicleCollisionTesterCastCylinder)self;
        public static unsafe implicit operator JPH.NonCopyable(VehicleCollisionTesterCastCylinder self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_NonCopyable(VehicleCollisionTesterCastCylinder self)
            => (JPH.Const_NonCopyable)(JPH.Const_VehicleCollisionTesterCastCylinder)self;
        public static unsafe implicit operator JPH.VehicleCollisionTester(VehicleCollisionTesterCastCylinder self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleCollisionTester._Underlying *__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_VehicleCollisionTester(_Underlying *_this);
            JPH.VehicleCollisionTester ret = new(__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_VehicleCollisionTester(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_VehicleCollisionTester(VehicleCollisionTesterCastCylinder self)
            => (JPH.Const_VehicleCollisionTester)(JPH.Const_VehicleCollisionTesterCastCylinder)self;

        // Downcasts:
        public static unsafe explicit operator VehicleCollisionTesterCastCylinder(JPH.RefTarget_JPHVehicleCollisionTester parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(JPH.RefTarget_JPHVehicleCollisionTester._Underlying *_this);
            VehicleCollisionTesterCastCylinder ret = new(__JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_RefTarget_JPH_VehicleCollisionTester(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator VehicleCollisionTesterCastCylinder(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            VehicleCollisionTesterCastCylinder ret = new(__JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator VehicleCollisionTesterCastCylinder(JPH.VehicleCollisionTester parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_VehicleCollisionTester(JPH.VehicleCollisionTester._Underlying *_this);
            VehicleCollisionTesterCastCylinder ret = new(__JPH_VehicleCollisionTesterCastCylinder_StaticDowncastFrom_JPH_VehicleCollisionTester(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe VehicleCollisionTesterCastCylinder(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructor
        /// @param inObjectLayer Object layer to test collision with
        /// @param inConvexRadiusFraction Fraction of half the wheel width (or wheel radius if it is smaller) that is used as the convex radius
        /// Generated from constructor `JPH::VehicleCollisionTesterCastCylinder::VehicleCollisionTesterCastCylinder`.
        /// Parameter `inConvexRadiusFraction` defaults to `0.100000001f`.
        public unsafe VehicleCollisionTesterCastCylinder(ushort inObjectLayer, float? inConvexRadiusFraction = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleCollisionTesterCastCylinder._Underlying *__JPH_VehicleCollisionTesterCastCylinder_Construct(ushort inObjectLayer, float *inConvexRadiusFraction);
            float __deref_inConvexRadiusFraction = inConvexRadiusFraction.GetValueOrDefault();
            _UnderlyingPtr = __JPH_VehicleCollisionTesterCastCylinder_Construct(inObjectLayer, inConvexRadiusFraction.HasValue ? &__deref_inConvexRadiusFraction : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_VehicleCollisionTester_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(void *_this);
            __JPH_RefTarget_JPH_VehicleCollisionTester_AddRef(__JPH_VehicleCollisionTesterCastCylinder_UpcastTo_JPH_RefTarget_JPH_VehicleCollisionTester(_UnderlyingPtr));
        }

        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::SetObjectLayer`.
        public unsafe void SetObjectLayer(ushort inObjectLayer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_SetObjectLayer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastCylinder_SetObjectLayer(_Underlying *_this, ushort inObjectLayer);
            __JPH_VehicleCollisionTesterCastCylinder_SetObjectLayer(_UnderlyingPtr, inObjectLayer);
        }

        /// Access to the broad phase layer filter, when set this overrides the object layer supplied in the constructor
        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::SetBroadPhaseLayerFilter`.
        public unsafe void SetBroadPhaseLayerFilter(JPH.Const_BroadPhaseLayerFilter? inFilter)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_SetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_SetBroadPhaseLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastCylinder_SetBroadPhaseLayerFilter(_Underlying *_this, JPH.Const_BroadPhaseLayerFilter._Underlying *inFilter);
            __JPH_VehicleCollisionTesterCastCylinder_SetBroadPhaseLayerFilter(_UnderlyingPtr, inFilter is not null ? inFilter._UnderlyingPtr : null);
        }

        /// Access to the object layer filter, when set this overrides the object layer supplied in the constructor
        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::SetObjectLayerFilter`.
        public unsafe void SetObjectLayerFilter(JPH.Const_ObjectLayerFilter? inFilter)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_SetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_SetObjectLayerFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastCylinder_SetObjectLayerFilter(_Underlying *_this, JPH.Const_ObjectLayerFilter._Underlying *inFilter);
            __JPH_VehicleCollisionTesterCastCylinder_SetObjectLayerFilter(_UnderlyingPtr, inFilter is not null ? inFilter._UnderlyingPtr : null);
        }

        /// Access to the body filter, when set this overrides the default filter that filters out the vehicle body
        /// Generated from method `JPH::VehicleCollisionTesterCastCylinder::SetBodyFilter`.
        public unsafe void SetBodyFilter(JPH.Const_BodyFilter? inFilter)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_SetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_VehicleCollisionTesterCastCylinder_SetBodyFilter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_VehicleCollisionTesterCastCylinder_SetBodyFilter(_Underlying *_this, JPH.Const_BodyFilter._Underlying *inFilter);
            __JPH_VehicleCollisionTesterCastCylinder_SetBodyFilter(_UnderlyingPtr, inFilter is not null ? inFilter._UnderlyingPtr : null);
        }
    }

    /// This is used for optional parameters of class `VehicleCollisionTesterCastCylinder` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_VehicleCollisionTesterCastCylinder`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleCollisionTesterCastCylinder`/`Const_VehicleCollisionTesterCastCylinder` directly.
    public class _InOptMut_VehicleCollisionTesterCastCylinder
    {
        public VehicleCollisionTesterCastCylinder? Opt;

        public _InOptMut_VehicleCollisionTesterCastCylinder() {}
        public _InOptMut_VehicleCollisionTesterCastCylinder(VehicleCollisionTesterCastCylinder value) {Opt = value;}
        public static implicit operator _InOptMut_VehicleCollisionTesterCastCylinder(VehicleCollisionTesterCastCylinder value) {return new(value);}
    }

    /// This is used for optional parameters of class `VehicleCollisionTesterCastCylinder` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_VehicleCollisionTesterCastCylinder`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `VehicleCollisionTesterCastCylinder`/`Const_VehicleCollisionTesterCastCylinder` to pass it to the function.
    public class _InOptConst_VehicleCollisionTesterCastCylinder
    {
        public Const_VehicleCollisionTesterCastCylinder? Opt;

        public _InOptConst_VehicleCollisionTesterCastCylinder() {}
        public _InOptConst_VehicleCollisionTesterCastCylinder(Const_VehicleCollisionTesterCastCylinder value) {Opt = value;}
        public static implicit operator _InOptConst_VehicleCollisionTesterCastCylinder(Const_VehicleCollisionTesterCastCylinder value) {return new(value);}
    }
}
