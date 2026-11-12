// machine generated, do not edit
public static partial class JPH
{
    /// An infinite plane described by the formula X . Normal + Constant = 0.
    /// Generated from class `JPH::Plane`.
    /// This is the const half of the class.
    public class Const_Plane : JPH.Object<Const_Plane>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Plane_Destroy(_Underlying *_this);
            __JPH_Plane_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Plane() {Dispose(false);}

        internal unsafe Const_Plane(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Plane() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_DefaultConstruct();
            _UnderlyingPtr = __JPH_Plane_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Plane::Plane`.
        public unsafe Const_Plane(JPH.Const_Plane _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_ConstructFromAnother(JPH.Plane._Underlying *_other);
            _UnderlyingPtr = __JPH_Plane_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::Plane::Plane`.
        public Const_Plane(Plane _other) : this((Const_Plane)_other) {}

        /// Generated from constructor `JPH::Plane::Plane`.
        public unsafe Const_Plane(JPH.Const_Vec4 inNormalAndConstant) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_Construct_1(JPH.Vec4._Underlying *inNormalAndConstant);
            _UnderlyingPtr = __JPH_Plane_Construct_1(inNormalAndConstant._UnderlyingPtr);
        }

        /// Generated from constructor `JPH::Plane::Plane`.
        public unsafe Const_Plane(JPH.Const_Vec3 inNormal, float inConstant) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_Construct_2(JPH.Vec3._Underlying *inNormal, float inConstant);
            _UnderlyingPtr = __JPH_Plane_Construct_2(inNormal._UnderlyingPtr, inConstant);
        }

        /// Generated from method `JPH::Plane::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Plane_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Plane_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Plane_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_Plane_size_t(inCount);
        }

        /// Generated from method `JPH::Plane::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Plane_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Plane_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Plane_void_ptr(void *inPointer);
            __Jolt_delete_JPH_Plane_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Plane::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Plane_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Plane_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Plane_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_Plane_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Plane::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Plane_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Plane_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Plane_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_Plane_size_t(inCount);
        }

        /// Generated from method `JPH::Plane::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Plane_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Plane_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Plane_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_Plane_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Plane::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Plane_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Plane_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Plane_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_Plane_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Plane::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Plane_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Plane_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Plane_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_Plane_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Plane::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Plane_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Plane_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Plane_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_Plane_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::Plane::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Plane_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Plane_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Plane_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_Plane_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Plane::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Plane_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Plane_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Plane_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_Plane_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Create from point and normal
        /// Generated from method `JPH::Plane::sFromPointAndNormal`.
        public static unsafe JPH.Plane SFromPointAndNormal(JPH.Const_Vec3 inPoint, JPH.Const_Vec3 inNormal)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_sFromPointAndNormal_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_sFromPointAndNormal_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_sFromPointAndNormal_JPH_Vec3(JPH.Vec3._Underlying *inPoint, JPH.Vec3._Underlying *inNormal);
            return new(__JPH_Plane_sFromPointAndNormal_JPH_Vec3(inPoint._UnderlyingPtr, inNormal._UnderlyingPtr), is_owning: true);
        }

        /// Create from point and normal, double precision version that more accurately calculates the plane constant
        /// Generated from method `JPH::Plane::sFromPointAndNormal`.
        public static unsafe JPH.Plane SFromPointAndNormal(JPH.Const_DVec3 inPoint, JPH.Const_Vec3 inNormal)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_sFromPointAndNormal_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_sFromPointAndNormal_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_sFromPointAndNormal_JPH_DVec3(JPH.Const_DVec3._Underlying *inPoint, JPH.Vec3._Underlying *inNormal);
            return new(__JPH_Plane_sFromPointAndNormal_JPH_DVec3(inPoint._UnderlyingPtr, inNormal._UnderlyingPtr), is_owning: true);
        }

        /// Create from 3 counter clockwise points
        /// Generated from method `JPH::Plane::sFromPointsCCW`.
        public static unsafe JPH.Plane SFromPointsCCW(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_sFromPointsCCW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_sFromPointsCCW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_sFromPointsCCW(JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3);
            return new(__JPH_Plane_sFromPointsCCW(inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr), is_owning: true);
        }

        // Properties
        /// Generated from method `JPH::Plane::GetNormal`.
        public unsafe JPH.Vec3 GetNormal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_GetNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_GetNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Plane_GetNormal(_Underlying *_this);
            return new(__JPH_Plane_GetNormal(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `JPH::Plane::GetConstant`.
        public unsafe float GetConstant()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_GetConstant", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_GetConstant", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Plane_GetConstant(_Underlying *_this);
            return __JPH_Plane_GetConstant(_UnderlyingPtr);
        }

        /// Store as 4 floats
        /// Generated from method `JPH::Plane::StoreFloat4`.
        public unsafe void StoreFloat4(JPH.Float4? outV)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_StoreFloat4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_StoreFloat4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Plane_StoreFloat4(_Underlying *_this, JPH.Float4._Underlying *outV);
            __JPH_Plane_StoreFloat4(_UnderlyingPtr, outV is not null ? outV._UnderlyingPtr : null);
        }

        /// Offset the plane (positive value means move it in the direction of the plane normal)
        /// Generated from method `JPH::Plane::Offset`.
        public unsafe JPH.Plane Offset(float inDistance)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_Offset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_Offset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_Offset(_Underlying *_this, float inDistance);
            return new(__JPH_Plane_Offset(_UnderlyingPtr, inDistance), is_owning: true);
        }

        /// Transform the plane by a matrix
        /// Generated from method `JPH::Plane::GetTransformed`.
        public unsafe JPH.Plane GetTransformed(JPH.Const_Mat44 inTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_GetTransformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_GetTransformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_GetTransformed(_Underlying *_this, JPH.Const_Mat44._Underlying *inTransform);
            return new(__JPH_Plane_GetTransformed(_UnderlyingPtr, inTransform._UnderlyingPtr), is_owning: true);
        }

        /// Scale the plane, can handle non-uniform and negative scaling
        /// Generated from method `JPH::Plane::Scaled`.
        public unsafe JPH.Plane Scaled(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_Scaled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_Scaled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_Scaled(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return new(__JPH_Plane_Scaled(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// Distance point to plane
        /// Generated from method `JPH::Plane::SignedDistance`.
        public unsafe float SignedDistance(JPH.Const_Vec3 inPoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_SignedDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_SignedDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_Plane_SignedDistance(_Underlying *_this, JPH.Vec3._Underlying *inPoint);
            return __JPH_Plane_SignedDistance(_UnderlyingPtr, inPoint._UnderlyingPtr);
        }

        /// Project inPoint onto the plane
        /// Generated from method `JPH::Plane::ProjectPointOnPlane`.
        public unsafe JPH.Vec3 ProjectPointOnPlane(JPH.Const_Vec3 inPoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_ProjectPointOnPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_ProjectPointOnPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_Plane_ProjectPointOnPlane(_Underlying *_this, JPH.Vec3._Underlying *inPoint);
            return new(__JPH_Plane_ProjectPointOnPlane(_UnderlyingPtr, inPoint._UnderlyingPtr), is_owning: true);
        }

        /// Returns intersection point between 3 planes
        /// Generated from method `JPH::Plane::sIntersectPlanes`.
        public static unsafe bool SIntersectPlanes(JPH.Const_Plane inP1, JPH.Const_Plane inP2, JPH.Const_Plane inP3, JPH.Vec3 outPoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_sIntersectPlanes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_sIntersectPlanes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Plane_sIntersectPlanes(JPH.Const_Plane._Underlying *inP1, JPH.Const_Plane._Underlying *inP2, JPH.Const_Plane._Underlying *inP3, JPH.Vec3._Underlying *outPoint);
            return __JPH_Plane_sIntersectPlanes(inP1._UnderlyingPtr, inP2._UnderlyingPtr, inP3._UnderlyingPtr, outPoint._UnderlyingPtr) != 0;
        }
    }

    /// An infinite plane described by the formula X . Normal + Constant = 0.
    /// Generated from class `JPH::Plane`.
    /// This is the non-const half of the class.
    public class Plane : Const_Plane
    {
        internal unsafe Plane(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Plane() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_DefaultConstruct();
            _UnderlyingPtr = __JPH_Plane_DefaultConstruct();
        }

        /// Generated from constructor `JPH::Plane::Plane`.
        public unsafe Plane(JPH.Const_Plane _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_ConstructFromAnother(JPH.Plane._Underlying *_other);
            _UnderlyingPtr = __JPH_Plane_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::Plane::Plane`.
        public Plane(Plane _other) : this((Const_Plane)_other) {}

        /// Generated from constructor `JPH::Plane::Plane`.
        public unsafe Plane(JPH.Const_Vec4 inNormalAndConstant) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_Construct_1(JPH.Vec4._Underlying *inNormalAndConstant);
            _UnderlyingPtr = __JPH_Plane_Construct_1(inNormalAndConstant._UnderlyingPtr);
        }

        /// Generated from constructor `JPH::Plane::Plane`.
        public unsafe Plane(JPH.Const_Vec3 inNormal, float inConstant) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_Construct_2(JPH.Vec3._Underlying *inNormal, float inConstant);
            _UnderlyingPtr = __JPH_Plane_Construct_2(inNormal._UnderlyingPtr, inConstant);
        }

        /// Generated from method `JPH::Plane::operator=`.
        public unsafe JPH.Plane Assign(JPH.Const_Plane _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Plane._Underlying *__JPH_Plane_AssignFromAnother(_Underlying *_this, JPH.Plane._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_Plane_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `JPH::Plane::SetNormal`.
        public unsafe void SetNormal(JPH.Const_Vec3 inNormal)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_SetNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_SetNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Plane_SetNormal(_Underlying *_this, JPH.Vec3._Underlying *inNormal);
            __JPH_Plane_SetNormal(_UnderlyingPtr, inNormal._UnderlyingPtr);
        }

        /// Generated from method `JPH::Plane::SetConstant`.
        public unsafe void SetConstant(float inConstant)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Plane_SetConstant", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Plane_SetConstant", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Plane_SetConstant(_Underlying *_this, float inConstant);
            __JPH_Plane_SetConstant(_UnderlyingPtr, inConstant);
        }
    }

    /// This is used for optional parameters of class `Plane` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Plane`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Plane`/`Const_Plane` directly.
    public class _InOptMut_Plane
    {
        public Plane? Opt;

        public _InOptMut_Plane() {}
        public _InOptMut_Plane(Plane value) {Opt = value;}
        public static implicit operator _InOptMut_Plane(Plane value) {return new(value);}
    }

    /// This is used for optional parameters of class `Plane` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Plane`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Plane`/`Const_Plane` to pass it to the function.
    public class _InOptConst_Plane
    {
        public Const_Plane? Opt;

        public _InOptConst_Plane() {}
        public _InOptConst_Plane(Const_Plane value) {Opt = value;}
        public static implicit operator _InOptConst_Plane(Const_Plane value) {return new(value);}
    }
}
