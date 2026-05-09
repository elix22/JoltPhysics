// machine generated, do not edit
public static partial class JPH
{
    /// Structure that holds a single shape cast (a shape moving along a linear path in 3d space with no rotation)
    /// Generated from class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeCast`
    /// This is the const half of the class.
    public class Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast : JPH.Object<Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Destroy(_Underlying *_this);
            __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast() {Dispose(false);}

        ///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
        public unsafe JPH.Const_Shape? mShape
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Shape._Underlying **__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mShape(Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast._Underlying *_this);
                var ptr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mShape(_UnderlyingPtr);
                JPH.Const_Shape? value = null;
                if (*ptr is not null)
                {
                    value = new(*ptr, is_owning: false);
                    value._KeepAliveEnclosingObject = this;
                }
                return value;
            }
        }

        ///< Scale in local space of the shape being cast (scales relative to its center of mass)
        public unsafe JPH.Const_Vec3 mScale
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mScale(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mScale(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Start position and orientation of the center of mass of the shape (construct using sFromWorldTransform if you have a world transform for your shape)
        public unsafe JPH.Const_Mat44 mCenterOfMassStart
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mCenterOfMassStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mCenterOfMassStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Mat44._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mCenterOfMassStart(_Underlying *_this);
                JPH.Const_Mat44 __ret;
                __ret = new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mCenterOfMassStart(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction and length of the cast (anything beyond this length will not be reported as a hit)
        public unsafe JPH.Const_Vec3 mDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Cached shape's world bounds, calculated in constructor
        public unsafe JPH.Const_AABox mShapeWorldBounds
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mShapeWorldBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mShapeWorldBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_AABox._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mShapeWorldBounds(_Underlying *_this);
                JPH.Const_AABox __ret;
                __ret = new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Get_mShapeWorldBounds(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::ShapeCastT`.
        public unsafe Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_ConstructFromAnother(JPH.ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast._Underlying *_other);
            _UnderlyingPtr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::ShapeCastT`.
        public Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast _other) : this((Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast)_other) {}

        /// Constructor
        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::ShapeCastT`.
        public unsafe Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection, JPH.Const_AABox inWorldSpaceBounds) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_5(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection, JPH.Const_AABox._Underlying *inWorldSpaceBounds);
            _UnderlyingPtr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_5(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr, inWorldSpaceBounds._UnderlyingPtr);
        }

        /// Constructor
        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::ShapeCastT`.
        public unsafe Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_4(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_4(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t(inCount);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr(void *inPointer);
            __Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t(inCount);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Construct a shape cast using a world transform for a shape instead of a center of mass transform
        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::sFromWorldTransform`.
        public static unsafe JPH.ShapeCast SFromWorldTransform(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inWorldTransform, JPH.Const_Vec3 inDirection)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_sFromWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_sFromWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_sFromWorldTransform(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inWorldTransform, JPH.Vec3._Underlying *inDirection);
            return new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_sFromWorldTransform(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inWorldTransform._UnderlyingPtr, inDirection._UnderlyingPtr), is_owning: true);
        }

        /// Transform this shape cast using inTransform. Multiply transform on the left left hand side.
        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::PostTransformed`.
        public unsafe JPH.ShapeCast PostTransformed(JPH.Const_Mat44 inTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_PostTransformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_PostTransformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_PostTransformed(_Underlying *_this, JPH.Const_Mat44._Underlying *inTransform);
            return new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_PostTransformed(_UnderlyingPtr, inTransform._UnderlyingPtr), is_owning: true);
        }

        /// Translate this shape cast by inTranslation.
        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::PostTranslated`.
        public unsafe JPH.ShapeCast PostTranslated(JPH.Const_Vec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_PostTranslated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_PostTranslated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_PostTranslated(_Underlying *_this, JPH.Vec3._Underlying *inTranslation);
            return new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_PostTranslated(_UnderlyingPtr, inTranslation._UnderlyingPtr), is_owning: true);
        }

        /// Get point with fraction inFraction on ray from mCenterOfMassStart to mCenterOfMassStart + mDirection (0 = start of ray, 1 = end of ray)
        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::GetPointOnRay`.
        public unsafe JPH.Vec3 GetPointOnRay(float inFraction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_GetPointOnRay(_Underlying *_this, float inFraction);
            return new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_GetPointOnRay(_UnderlyingPtr, inFraction), is_owning: true);
        }
    }

    /// Structure that holds a single shape cast (a shape moving along a linear path in 3d space with no rotation)
    /// Generated from class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeCast`
    /// This is the non-const half of the class.
    public class ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast : Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast
    {
        ///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
        public new unsafe JPH.Const_Shape? mShape
        {
            get => base.mShape;
            set
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_GetMutable_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_GetMutable_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Shape._Underlying **__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_GetMutable_mShape(ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast._Underlying *_this);
                var ptr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_GetMutable_mShape(_UnderlyingPtr);
                _DiscardKeepAlive("mShape");
                if (value is not null)
                    _KeepAlive(value, "mShape");
                *ptr = (value is not null ? value._UnderlyingPtr : null);
            }
        }

        internal unsafe ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::ShapeCastT`.
        public unsafe ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_ConstructFromAnother(JPH.ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast._Underlying *_other);
            _UnderlyingPtr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::ShapeCastT`.
        public ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast _other) : this((Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast)_other) {}

        /// Constructor
        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::ShapeCastT`.
        public unsafe ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection, JPH.Const_AABox inWorldSpaceBounds) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_5(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection, JPH.Const_AABox._Underlying *inWorldSpaceBounds);
            _UnderlyingPtr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_5(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr, inWorldSpaceBounds._UnderlyingPtr);
        }

        /// Constructor
        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>::ShapeCastT`.
        public unsafe ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_4(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast_Construct_4(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast`/`Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast` directly.
    public class _InOptMut_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast
    {
        public ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast? Opt;

        public _InOptMut_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast() {}
        public _InOptMut_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast value) {Opt = value;}
        public static implicit operator _InOptMut_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast value) {return new(value);}
    }

    /// This is used for optional parameters of class `ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast`/`Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast` to pass it to the function.
    public class _InOptConst_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast
    {
        public Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast? Opt;

        public _InOptConst_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast() {}
        public _InOptConst_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast value) {Opt = value;}
        public static implicit operator _InOptConst_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast value) {return new(value);}
    }

    /// Structure that holds a single shape cast (a shape moving along a linear path in 3d space with no rotation)
    /// Generated from class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RShapeCast`
    /// This is the const half of the class.
    public class Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast : JPH.Object<Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Destroy(_Underlying *_this);
            __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast() {Dispose(false);}

        ///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
        public unsafe JPH.Const_Shape? mShape
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Shape._Underlying **__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mShape(Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast._Underlying *_this);
                var ptr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mShape(_UnderlyingPtr);
                JPH.Const_Shape? value = null;
                if (*ptr is not null)
                {
                    value = new(*ptr, is_owning: false);
                    value._KeepAliveEnclosingObject = this;
                }
                return value;
            }
        }

        ///< Scale in local space of the shape being cast (scales relative to its center of mass)
        public unsafe JPH.Const_Vec3 mScale
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mScale(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mScale(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Start position and orientation of the center of mass of the shape (construct using sFromWorldTransform if you have a world transform for your shape)
        public unsafe JPH.Const_Mat44 mCenterOfMassStart
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mCenterOfMassStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mCenterOfMassStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Mat44._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mCenterOfMassStart(_Underlying *_this);
                JPH.Const_Mat44 __ret;
                __ret = new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mCenterOfMassStart(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction and length of the cast (anything beyond this length will not be reported as a hit)
        public unsafe JPH.Const_Vec3 mDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Cached shape's world bounds, calculated in constructor
        public unsafe JPH.Const_AABox mShapeWorldBounds
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mShapeWorldBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mShapeWorldBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_AABox._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mShapeWorldBounds(_Underlying *_this);
                JPH.Const_AABox __ret;
                __ret = new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Get_mShapeWorldBounds(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::ShapeCastT`.
        public unsafe Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_ConstructFromAnother(JPH.ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast._Underlying *_other);
            _UnderlyingPtr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::ShapeCastT`.
        public Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast _other) : this((Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast)_other) {}

        /// Constructor
        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::ShapeCastT`.
        public unsafe Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection, JPH.Const_AABox inWorldSpaceBounds) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_5(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection, JPH.Const_AABox._Underlying *inWorldSpaceBounds);
            _UnderlyingPtr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_5(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr, inWorldSpaceBounds._UnderlyingPtr);
        }

        /// Constructor
        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::ShapeCastT`.
        public unsafe Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_4(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_4(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t(inCount);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr(void *inPointer);
            __Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t(inCount);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Construct a shape cast using a world transform for a shape instead of a center of mass transform
        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::sFromWorldTransform`.
        public static unsafe JPH.RShapeCast SFromWorldTransform(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inWorldTransform, JPH.Const_Vec3 inDirection)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_sFromWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_sFromWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_sFromWorldTransform(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inWorldTransform, JPH.Vec3._Underlying *inDirection);
            return new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_sFromWorldTransform(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inWorldTransform._UnderlyingPtr, inDirection._UnderlyingPtr), is_owning: true);
        }

        /// Transform this shape cast using inTransform. Multiply transform on the left left hand side.
        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::PostTransformed`.
        public unsafe JPH.RShapeCast PostTransformed(JPH.Const_Mat44 inTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_PostTransformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_PostTransformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_PostTransformed(_Underlying *_this, JPH.Const_Mat44._Underlying *inTransform);
            return new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_PostTransformed(_UnderlyingPtr, inTransform._UnderlyingPtr), is_owning: true);
        }

        /// Translate this shape cast by inTranslation.
        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::PostTranslated`.
        public unsafe JPH.RShapeCast PostTranslated(JPH.Const_Vec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_PostTranslated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_PostTranslated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_PostTranslated(_Underlying *_this, JPH.Vec3._Underlying *inTranslation);
            return new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_PostTranslated(_UnderlyingPtr, inTranslation._UnderlyingPtr), is_owning: true);
        }

        /// Get point with fraction inFraction on ray from mCenterOfMassStart to mCenterOfMassStart + mDirection (0 = start of ray, 1 = end of ray)
        /// Generated from method `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::GetPointOnRay`.
        public unsafe JPH.Vec3 GetPointOnRay(float inFraction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_GetPointOnRay(_Underlying *_this, float inFraction);
            return new(__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_GetPointOnRay(_UnderlyingPtr, inFraction), is_owning: true);
        }
    }

    /// Structure that holds a single shape cast (a shape moving along a linear path in 3d space with no rotation)
    /// Generated from class `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RShapeCast`
    /// This is the non-const half of the class.
    public class ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast : Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast
    {
        ///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
        public new unsafe JPH.Const_Shape? mShape
        {
            get => base.mShape;
            set
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_GetMutable_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_GetMutable_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Shape._Underlying **__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_GetMutable_mShape(ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast._Underlying *_this);
                var ptr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_GetMutable_mShape(_UnderlyingPtr);
                _DiscardKeepAlive("mShape");
                if (value is not null)
                    _KeepAlive(value, "mShape");
                *ptr = (value is not null ? value._UnderlyingPtr : null);
            }
        }

        internal unsafe ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::ShapeCastT`.
        public unsafe ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_ConstructFromAnother(JPH.ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast._Underlying *_other);
            _UnderlyingPtr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::ShapeCastT`.
        public ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast _other) : this((Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast)_other) {}

        /// Constructor
        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::ShapeCastT`.
        public unsafe ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection, JPH.Const_AABox inWorldSpaceBounds) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_5(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection, JPH.Const_AABox._Underlying *inWorldSpaceBounds);
            _UnderlyingPtr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_5(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr, inWorldSpaceBounds._UnderlyingPtr);
        }

        /// Constructor
        /// Generated from constructor `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>::ShapeCastT`.
        public unsafe ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast._Underlying *__JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_4(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast_Construct_4(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast`/`Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast` directly.
    public class _InOptMut_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast
    {
        public ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast? Opt;

        public _InOptMut_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast() {}
        public _InOptMut_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast value) {Opt = value;}
        public static implicit operator _InOptMut_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast value) {return new(value);}
    }

    /// This is used for optional parameters of class `ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast`/`Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast` to pass it to the function.
    public class _InOptConst_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast
    {
        public Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast? Opt;

        public _InOptConst_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast() {}
        public _InOptConst_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast value) {Opt = value;}
        public static implicit operator _InOptConst_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast value) {return new(value);}
    }

    /// Generated from class `JPH::ShapeCast`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>`
    /// This is the const half of the class.
    public class Const_ShapeCast : JPH.Object<Const_ShapeCast>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ShapeCast_Destroy(_Underlying *_this);
            __JPH_ShapeCast_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ShapeCast() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(Const_ShapeCast self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast._Underlying *__JPH_ShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(_Underlying *_this);
            JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast ret = new(__JPH_ShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_ShapeCast(JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast._Underlying *_this);
            Const_ShapeCast ret = new(__JPH_ShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
        public unsafe JPH.Const_Shape? mShape
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_Get_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_Get_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Shape._Underlying **__JPH_ShapeCast_Get_mShape(Const_ShapeCast._Underlying *_this);
                var ptr = __JPH_ShapeCast_Get_mShape(_UnderlyingPtr);
                JPH.Const_Shape? value = null;
                if (*ptr is not null)
                {
                    value = new(*ptr, is_owning: false);
                    value._KeepAliveEnclosingObject = this;
                }
                return value;
            }
        }

        ///< Scale in local space of the shape being cast (scales relative to its center of mass)
        public unsafe JPH.Const_Vec3 mScale
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_Get_mScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_Get_mScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_ShapeCast_Get_mScale(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_ShapeCast_Get_mScale(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Start position and orientation of the center of mass of the shape (construct using sFromWorldTransform if you have a world transform for your shape)
        public unsafe JPH.Const_Mat44 mCenterOfMassStart
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_Get_mCenterOfMassStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_Get_mCenterOfMassStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Mat44._Underlying *__JPH_ShapeCast_Get_mCenterOfMassStart(_Underlying *_this);
                JPH.Const_Mat44 __ret;
                __ret = new(__JPH_ShapeCast_Get_mCenterOfMassStart(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction and length of the cast (anything beyond this length will not be reported as a hit)
        public unsafe JPH.Const_Vec3 mDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_ShapeCast_Get_mDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_ShapeCast_Get_mDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Cached shape's world bounds, calculated in constructor
        public unsafe JPH.Const_AABox mShapeWorldBounds
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_Get_mShapeWorldBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_Get_mShapeWorldBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_AABox._Underlying *__JPH_ShapeCast_Get_mShapeWorldBounds(_Underlying *_this);
                JPH.Const_AABox __ret;
                __ret = new(__JPH_ShapeCast_Get_mShapeWorldBounds(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_ShapeCast(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JPH::ShapeCast::ShapeCast`.
        public unsafe Const_ShapeCast(JPH.Const_ShapeCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCast._Underlying *__JPH_ShapeCast_ConstructFromAnother(JPH.ShapeCast._Underlying *_other);
            _UnderlyingPtr = __JPH_ShapeCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::ShapeCast::ShapeCast`.
        public Const_ShapeCast(ShapeCast _other) : this((Const_ShapeCast)_other) {}

        /// Constructor
        /// Generated from constructor `JPH::ShapeCast::ShapeCast`.
        public unsafe Const_ShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection, JPH.Const_AABox inWorldSpaceBounds) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCast._Underlying *__JPH_ShapeCast_Construct_5(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection, JPH.Const_AABox._Underlying *inWorldSpaceBounds);
            _UnderlyingPtr = __JPH_ShapeCast_Construct_5(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr, inWorldSpaceBounds._UnderlyingPtr);
        }

        /// Constructor
        /// Generated from constructor `JPH::ShapeCast::ShapeCast`.
        public unsafe Const_ShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCast._Underlying *__JPH_ShapeCast_Construct_4(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_ShapeCast_Construct_4(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr);
        }

        /// Construct a shape cast using a world transform for a shape instead of a center of mass transform
        /// Generated from method `JPH::ShapeCast::sFromWorldTransform`.
        public static unsafe JPH.ShapeCast SFromWorldTransform(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inWorldTransform, JPH.Const_Vec3 inDirection)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_sFromWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_sFromWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCast._Underlying *__JPH_ShapeCast_sFromWorldTransform(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inWorldTransform, JPH.Vec3._Underlying *inDirection);
            return new(__JPH_ShapeCast_sFromWorldTransform(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inWorldTransform._UnderlyingPtr, inDirection._UnderlyingPtr), is_owning: true);
        }

        /// Transform this shape cast using inTransform. Multiply transform on the left left hand side.
        /// Generated from method `JPH::ShapeCast::PostTransformed`.
        public unsafe JPH.ShapeCast PostTransformed(JPH.Const_Mat44 inTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_PostTransformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_PostTransformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCast._Underlying *__JPH_ShapeCast_PostTransformed(_Underlying *_this, JPH.Const_Mat44._Underlying *inTransform);
            return new(__JPH_ShapeCast_PostTransformed(_UnderlyingPtr, inTransform._UnderlyingPtr), is_owning: true);
        }

        /// Translate this shape cast by inTranslation.
        /// Generated from method `JPH::ShapeCast::PostTranslated`.
        public unsafe JPH.ShapeCast PostTranslated(JPH.Const_Vec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_PostTranslated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_PostTranslated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCast._Underlying *__JPH_ShapeCast_PostTranslated(_Underlying *_this, JPH.Vec3._Underlying *inTranslation);
            return new(__JPH_ShapeCast_PostTranslated(_UnderlyingPtr, inTranslation._UnderlyingPtr), is_owning: true);
        }

        /// Get point with fraction inFraction on ray from mCenterOfMassStart to mCenterOfMassStart + mDirection (0 = start of ray, 1 = end of ray)
        /// Generated from method `JPH::ShapeCast::GetPointOnRay`.
        public unsafe JPH.Vec3 GetPointOnRay(float inFraction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_ShapeCast_GetPointOnRay(_Underlying *_this, float inFraction);
            return new(__JPH_ShapeCast_GetPointOnRay(_UnderlyingPtr, inFraction), is_owning: true);
        }
    }

    /// Generated from class `JPH::ShapeCast`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::ShapeCast>`
    /// This is the non-const half of the class.
    public class ShapeCast : Const_ShapeCast
    {
        // Upcasts:
        public static unsafe implicit operator JPH.ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(ShapeCast self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast._Underlying *__JPH_ShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(_Underlying *_this);
            JPH.ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast ret = new(__JPH_ShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast(ShapeCast self)
            => (JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast)(JPH.Const_ShapeCast)self;

        // Downcasts:
        public static unsafe explicit operator ShapeCast(JPH.ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(JPH.ShapeCastT_JPHVec3_JPHMat44_JPHShapeCast._Underlying *_this);
            ShapeCast ret = new(__JPH_ShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_ShapeCast(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
        public new unsafe JPH.Const_Shape? mShape
        {
            get => base.mShape;
            set
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_GetMutable_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_GetMutable_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Shape._Underlying **__JPH_ShapeCast_GetMutable_mShape(ShapeCast._Underlying *_this);
                var ptr = __JPH_ShapeCast_GetMutable_mShape(_UnderlyingPtr);
                _DiscardKeepAlive("mShape");
                if (value is not null)
                    _KeepAlive(value, "mShape");
                *ptr = (value is not null ? value._UnderlyingPtr : null);
            }
        }

        internal unsafe ShapeCast(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JPH::ShapeCast::ShapeCast`.
        public unsafe ShapeCast(JPH.Const_ShapeCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCast._Underlying *__JPH_ShapeCast_ConstructFromAnother(JPH.ShapeCast._Underlying *_other);
            _UnderlyingPtr = __JPH_ShapeCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::ShapeCast::ShapeCast`.
        public ShapeCast(ShapeCast _other) : this((Const_ShapeCast)_other) {}

        /// Constructor
        /// Generated from constructor `JPH::ShapeCast::ShapeCast`.
        public unsafe ShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection, JPH.Const_AABox inWorldSpaceBounds) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCast._Underlying *__JPH_ShapeCast_Construct_5(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection, JPH.Const_AABox._Underlying *inWorldSpaceBounds);
            _UnderlyingPtr = __JPH_ShapeCast_Construct_5(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr, inWorldSpaceBounds._UnderlyingPtr);
        }

        /// Constructor
        /// Generated from constructor `JPH::ShapeCast::ShapeCast`.
        public unsafe ShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCast._Underlying *__JPH_ShapeCast_Construct_4(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_ShapeCast_Construct_4(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `ShapeCast` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ShapeCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ShapeCast`/`Const_ShapeCast` directly.
    public class _InOptMut_ShapeCast
    {
        public ShapeCast? Opt;

        public _InOptMut_ShapeCast() {}
        public _InOptMut_ShapeCast(ShapeCast value) {Opt = value;}
        public static implicit operator _InOptMut_ShapeCast(ShapeCast value) {return new(value);}
    }

    /// This is used for optional parameters of class `ShapeCast` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ShapeCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ShapeCast`/`Const_ShapeCast` to pass it to the function.
    public class _InOptConst_ShapeCast
    {
        public Const_ShapeCast? Opt;

        public _InOptConst_ShapeCast() {}
        public _InOptConst_ShapeCast(Const_ShapeCast value) {Opt = value;}
        public static implicit operator _InOptConst_ShapeCast(Const_ShapeCast value) {return new(value);}
    }

    /// Generated from class `JPH::RShapeCast`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>`
    /// This is the const half of the class.
    public class Const_RShapeCast : JPH.Object<Const_RShapeCast>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RShapeCast_Destroy(_Underlying *_this);
            __JPH_RShapeCast_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RShapeCast() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(Const_RShapeCast self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast._Underlying *__JPH_RShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(_Underlying *_this);
            JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast ret = new(__JPH_RShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_RShapeCast(JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_RShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast._Underlying *_this);
            Const_RShapeCast ret = new(__JPH_RShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
        public unsafe JPH.Const_Shape? mShape
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_Get_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_Get_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Shape._Underlying **__JPH_RShapeCast_Get_mShape(Const_RShapeCast._Underlying *_this);
                var ptr = __JPH_RShapeCast_Get_mShape(_UnderlyingPtr);
                JPH.Const_Shape? value = null;
                if (*ptr is not null)
                {
                    value = new(*ptr, is_owning: false);
                    value._KeepAliveEnclosingObject = this;
                }
                return value;
            }
        }

        ///< Scale in local space of the shape being cast (scales relative to its center of mass)
        public unsafe JPH.Const_Vec3 mScale
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_Get_mScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_Get_mScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_RShapeCast_Get_mScale(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_RShapeCast_Get_mScale(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Start position and orientation of the center of mass of the shape (construct using sFromWorldTransform if you have a world transform for your shape)
        public unsafe JPH.Const_Mat44 mCenterOfMassStart
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_Get_mCenterOfMassStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_Get_mCenterOfMassStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Mat44._Underlying *__JPH_RShapeCast_Get_mCenterOfMassStart(_Underlying *_this);
                JPH.Const_Mat44 __ret;
                __ret = new(__JPH_RShapeCast_Get_mCenterOfMassStart(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction and length of the cast (anything beyond this length will not be reported as a hit)
        public unsafe JPH.Const_Vec3 mDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_RShapeCast_Get_mDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_RShapeCast_Get_mDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Cached shape's world bounds, calculated in constructor
        public unsafe JPH.Const_AABox mShapeWorldBounds
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_Get_mShapeWorldBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_Get_mShapeWorldBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_AABox._Underlying *__JPH_RShapeCast_Get_mShapeWorldBounds(_Underlying *_this);
                JPH.Const_AABox __ret;
                __ret = new(__JPH_RShapeCast_Get_mShapeWorldBounds(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_RShapeCast(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JPH::RShapeCast::RShapeCast`.
        public unsafe Const_RShapeCast(JPH.Const_RShapeCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RShapeCast._Underlying *__JPH_RShapeCast_ConstructFromAnother(JPH.RShapeCast._Underlying *_other);
            _UnderlyingPtr = __JPH_RShapeCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RShapeCast::RShapeCast`.
        public Const_RShapeCast(RShapeCast _other) : this((Const_RShapeCast)_other) {}

        /// Constructor
        /// Generated from constructor `JPH::RShapeCast::RShapeCast`.
        public unsafe Const_RShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection, JPH.Const_AABox inWorldSpaceBounds) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RShapeCast._Underlying *__JPH_RShapeCast_Construct_5(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection, JPH.Const_AABox._Underlying *inWorldSpaceBounds);
            _UnderlyingPtr = __JPH_RShapeCast_Construct_5(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr, inWorldSpaceBounds._UnderlyingPtr);
        }

        /// Constructor
        /// Generated from constructor `JPH::RShapeCast::RShapeCast`.
        public unsafe Const_RShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RShapeCast._Underlying *__JPH_RShapeCast_Construct_4(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_RShapeCast_Construct_4(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr);
        }

        /// Convert from ShapeCast, converts single to double precision
        /// Generated from constructor `JPH::RShapeCast::RShapeCast`.
        public unsafe Const_RShapeCast(JPH.Const_ShapeCast inCast) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RShapeCast._Underlying *__JPH_RShapeCast_Construct_1(JPH.Const_ShapeCast._Underlying *inCast);
            _UnderlyingPtr = __JPH_RShapeCast_Construct_1(inCast._UnderlyingPtr);
        }

        /// Convert to ShapeCast, which implies casting from double precision to single precision
        /// Generated from conversion operator `JPH::RShapeCast::operator JPH::ShapeCast`.
        public static unsafe explicit operator JPH.ShapeCast(JPH.Const_RShapeCast _this)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_ConvertTo_JPH_ShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_ConvertTo_JPH_ShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCast._Underlying *__JPH_RShapeCast_ConvertTo_JPH_ShapeCast(JPH.Const_RShapeCast._Underlying *_this);
            return new(__JPH_RShapeCast_ConvertTo_JPH_ShapeCast(_this._UnderlyingPtr), is_owning: true);
        }

        /// Construct a shape cast using a world transform for a shape instead of a center of mass transform
        /// Generated from method `JPH::RShapeCast::sFromWorldTransform`.
        public static unsafe JPH.RShapeCast SFromWorldTransform(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inWorldTransform, JPH.Const_Vec3 inDirection)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_sFromWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_sFromWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RShapeCast._Underlying *__JPH_RShapeCast_sFromWorldTransform(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inWorldTransform, JPH.Vec3._Underlying *inDirection);
            return new(__JPH_RShapeCast_sFromWorldTransform(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inWorldTransform._UnderlyingPtr, inDirection._UnderlyingPtr), is_owning: true);
        }

        /// Transform this shape cast using inTransform. Multiply transform on the left left hand side.
        /// Generated from method `JPH::RShapeCast::PostTransformed`.
        public unsafe JPH.RShapeCast PostTransformed(JPH.Const_Mat44 inTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_PostTransformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_PostTransformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RShapeCast._Underlying *__JPH_RShapeCast_PostTransformed(_Underlying *_this, JPH.Const_Mat44._Underlying *inTransform);
            return new(__JPH_RShapeCast_PostTransformed(_UnderlyingPtr, inTransform._UnderlyingPtr), is_owning: true);
        }

        /// Translate this shape cast by inTranslation.
        /// Generated from method `JPH::RShapeCast::PostTranslated`.
        public unsafe JPH.RShapeCast PostTranslated(JPH.Const_Vec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_PostTranslated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_PostTranslated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RShapeCast._Underlying *__JPH_RShapeCast_PostTranslated(_Underlying *_this, JPH.Vec3._Underlying *inTranslation);
            return new(__JPH_RShapeCast_PostTranslated(_UnderlyingPtr, inTranslation._UnderlyingPtr), is_owning: true);
        }

        /// Get point with fraction inFraction on ray from mCenterOfMassStart to mCenterOfMassStart + mDirection (0 = start of ray, 1 = end of ray)
        /// Generated from method `JPH::RShapeCast::GetPointOnRay`.
        public unsafe JPH.Vec3 GetPointOnRay(float inFraction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_RShapeCast_GetPointOnRay(_Underlying *_this, float inFraction);
            return new(__JPH_RShapeCast_GetPointOnRay(_UnderlyingPtr, inFraction), is_owning: true);
        }
    }

    /// Generated from class `JPH::RShapeCast`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeCastT<JPH::Vec3, JPH::Mat44, JPH::RShapeCast>`
    /// This is the non-const half of the class.
    public class RShapeCast : Const_RShapeCast
    {
        // Upcasts:
        public static unsafe implicit operator JPH.ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(RShapeCast self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast._Underlying *__JPH_RShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(_Underlying *_this);
            JPH.ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast ret = new(__JPH_RShapeCast_UpcastTo_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast(RShapeCast self)
            => (JPH.Const_ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast)(JPH.Const_RShapeCast)self;

        // Downcasts:
        public static unsafe explicit operator RShapeCast(JPH.ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_RShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(JPH.ShapeCastT_JPHVec3_JPHMat44_JPHRShapeCast._Underlying *_this);
            RShapeCast ret = new(__JPH_RShapeCast_StaticDowncastFrom_JPH_ShapeCastT_JPH_Vec3_JPH_Mat44_JPH_RShapeCast(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Shape that's being cast (cannot be mesh shape). Note that this structure does not assume ownership over the shape for performance reasons.
        public new unsafe JPH.Const_Shape? mShape
        {
            get => base.mShape;
            set
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_GetMutable_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_GetMutable_mShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Shape._Underlying **__JPH_RShapeCast_GetMutable_mShape(RShapeCast._Underlying *_this);
                var ptr = __JPH_RShapeCast_GetMutable_mShape(_UnderlyingPtr);
                _DiscardKeepAlive("mShape");
                if (value is not null)
                    _KeepAlive(value, "mShape");
                *ptr = (value is not null ? value._UnderlyingPtr : null);
            }
        }

        internal unsafe RShapeCast(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JPH::RShapeCast::RShapeCast`.
        public unsafe RShapeCast(JPH.Const_RShapeCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RShapeCast._Underlying *__JPH_RShapeCast_ConstructFromAnother(JPH.RShapeCast._Underlying *_other);
            _UnderlyingPtr = __JPH_RShapeCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RShapeCast::RShapeCast`.
        public RShapeCast(RShapeCast _other) : this((Const_RShapeCast)_other) {}

        /// Constructor
        /// Generated from constructor `JPH::RShapeCast::RShapeCast`.
        public unsafe RShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection, JPH.Const_AABox inWorldSpaceBounds) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_Construct_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RShapeCast._Underlying *__JPH_RShapeCast_Construct_5(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection, JPH.Const_AABox._Underlying *inWorldSpaceBounds);
            _UnderlyingPtr = __JPH_RShapeCast_Construct_5(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr, inWorldSpaceBounds._UnderlyingPtr);
        }

        /// Constructor
        /// Generated from constructor `JPH::RShapeCast::RShapeCast`.
        public unsafe RShapeCast(JPH.Const_Shape? inShape, JPH.Const_Vec3 inScale, JPH.Const_Mat44 inCenterOfMassStart, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RShapeCast._Underlying *__JPH_RShapeCast_Construct_4(JPH.Const_Shape._Underlying *inShape, JPH.Vec3._Underlying *inScale, JPH.Const_Mat44._Underlying *inCenterOfMassStart, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_RShapeCast_Construct_4(inShape is not null ? inShape._UnderlyingPtr : null, inScale._UnderlyingPtr, inCenterOfMassStart._UnderlyingPtr, inDirection._UnderlyingPtr);
        }

        /// Convert from ShapeCast, converts single to double precision
        /// Generated from constructor `JPH::RShapeCast::RShapeCast`.
        public unsafe RShapeCast(JPH.Const_ShapeCast inCast) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RShapeCast_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RShapeCast_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RShapeCast._Underlying *__JPH_RShapeCast_Construct_1(JPH.Const_ShapeCast._Underlying *inCast);
            _UnderlyingPtr = __JPH_RShapeCast_Construct_1(inCast._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `RShapeCast` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RShapeCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RShapeCast`/`Const_RShapeCast` directly.
    public class _InOptMut_RShapeCast
    {
        public RShapeCast? Opt;

        public _InOptMut_RShapeCast() {}
        public _InOptMut_RShapeCast(RShapeCast value) {Opt = value;}
        public static implicit operator _InOptMut_RShapeCast(RShapeCast value) {return new(value);}
    }

    /// This is used for optional parameters of class `RShapeCast` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RShapeCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RShapeCast`/`Const_RShapeCast` to pass it to the function.
    public class _InOptConst_RShapeCast
    {
        public Const_RShapeCast? Opt;

        public _InOptConst_RShapeCast() {}
        public _InOptConst_RShapeCast(Const_RShapeCast value) {Opt = value;}
        public static implicit operator _InOptConst_RShapeCast(Const_RShapeCast value) {return new(value);}
    }

    /// Settings to be passed with a shape cast
    /// Generated from class `JPH::ShapeCastSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CollideSettingsBase`
    /// This is the const half of the class.
    public class Const_ShapeCastSettings : JPH.Object<Const_ShapeCastSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ShapeCastSettings_Destroy(_Underlying *_this);
            __JPH_ShapeCastSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ShapeCastSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_CollideSettingsBase(Const_ShapeCastSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_UpcastTo_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_UpcastTo_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_CollideSettingsBase._Underlying *__JPH_ShapeCastSettings_UpcastTo_JPH_CollideSettingsBase(_Underlying *_this);
            JPH.Const_CollideSettingsBase ret = new(__JPH_ShapeCastSettings_UpcastTo_JPH_CollideSettingsBase(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_ShapeCastSettings(JPH.Const_CollideSettingsBase parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_StaticDowncastFrom_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_StaticDowncastFrom_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ShapeCastSettings_StaticDowncastFrom_JPH_CollideSettingsBase(JPH.Const_CollideSettingsBase._Underlying *_this);
            Const_ShapeCastSettings ret = new(__JPH_ShapeCastSettings_StaticDowncastFrom_JPH_CollideSettingsBase(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// How backfacing triangles should be treated (should we report moving from back to front for triangle based shapes, e.g. for MeshShape/HeightFieldShape?)
        public unsafe JPH.EBackFaceMode mBackFaceModeTriangles
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mBackFaceModeTriangles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mBackFaceModeTriangles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EBackFaceMode *__JPH_ShapeCastSettings_Get_mBackFaceModeTriangles(_Underlying *_this);
                return *__JPH_ShapeCastSettings_Get_mBackFaceModeTriangles(_UnderlyingPtr);
            }
        }

        /// How backfacing convex objects should be treated (should we report starting inside an object and moving out?)
        public unsafe JPH.EBackFaceMode mBackFaceModeConvex
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mBackFaceModeConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mBackFaceModeConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EBackFaceMode *__JPH_ShapeCastSettings_Get_mBackFaceModeConvex(_Underlying *_this);
                return *__JPH_ShapeCastSettings_Get_mBackFaceModeConvex(_UnderlyingPtr);
            }
        }

        /// Indicates if we want to shrink the shape by the convex radius and then expand it again. This speeds up collision detection and gives a more accurate normal at the cost of a more 'rounded' shape.
        public unsafe bool mUseShrunkenShapeAndConvexRadius
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mUseShrunkenShapeAndConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mUseShrunkenShapeAndConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_ShapeCastSettings_Get_mUseShrunkenShapeAndConvexRadius(_Underlying *_this);
                return *__JPH_ShapeCastSettings_Get_mUseShrunkenShapeAndConvexRadius(_UnderlyingPtr);
            }
        }

        /// When true, and the shape is intersecting at the beginning of the cast (fraction = 0) then this will calculate the deepest penetration point (costing additional CPU time)
        public unsafe bool mReturnDeepestPoint
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mReturnDeepestPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mReturnDeepestPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_ShapeCastSettings_Get_mReturnDeepestPoint(_Underlying *_this);
                return *__JPH_ShapeCastSettings_Get_mReturnDeepestPoint(_UnderlyingPtr);
            }
        }

        /// How active edges (edges that a moving object should bump into) are handled
        public unsafe JPH.EActiveEdgeMode mActiveEdgeMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mActiveEdgeMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mActiveEdgeMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EActiveEdgeMode *__JPH_ShapeCastSettings_Get_mActiveEdgeMode(_Underlying *_this);
                return *__JPH_ShapeCastSettings_Get_mActiveEdgeMode(_UnderlyingPtr);
            }
        }

        /// If colliding faces should be collected or only the collision point
        public unsafe JPH.ECollectFacesMode mCollectFacesMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mCollectFacesMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mCollectFacesMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ECollectFacesMode *__JPH_ShapeCastSettings_Get_mCollectFacesMode(_Underlying *_this);
                return *__JPH_ShapeCastSettings_Get_mCollectFacesMode(_UnderlyingPtr);
            }
        }

        /// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
        public unsafe float mCollisionTolerance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ShapeCastSettings_Get_mCollisionTolerance(_Underlying *_this);
                return *__JPH_ShapeCastSettings_Get_mCollisionTolerance(_UnderlyingPtr);
            }
        }

        /// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
        public unsafe float mPenetrationTolerance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mPenetrationTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mPenetrationTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ShapeCastSettings_Get_mPenetrationTolerance(_Underlying *_this);
                return *__JPH_ShapeCastSettings_Get_mPenetrationTolerance(_UnderlyingPtr);
            }
        }

        /// When mActiveEdgeMode is CollideOnlyWithActive a movement direction can be provided. When hitting an inactive edge, the system will select the triangle normal as penetration depth only if it impedes the movement less than with the calculated penetration depth.
        public unsafe JPH.Const_Vec3 mActiveEdgeMovementDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mActiveEdgeMovementDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_Get_mActiveEdgeMovementDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_ShapeCastSettings_Get_mActiveEdgeMovementDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_ShapeCastSettings_Get_mActiveEdgeMovementDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_ShapeCastSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_ShapeCastSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastSettings._Underlying *__JPH_ShapeCastSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_ShapeCastSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::ShapeCastSettings::ShapeCastSettings`.
        public unsafe Const_ShapeCastSettings(JPH.Const_ShapeCastSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastSettings._Underlying *__JPH_ShapeCastSettings_ConstructFromAnother(JPH.ShapeCastSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_ShapeCastSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::ShapeCastSettings::ShapeCastSettings`.
        public Const_ShapeCastSettings(ShapeCastSettings _other) : this((Const_ShapeCastSettings)_other) {}

        /// Generated from method `JPH::ShapeCastSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ShapeCastSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_ShapeCastSettings_size_t(inCount);
        }

        /// Generated from method `JPH::ShapeCastSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeCastSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_ShapeCastSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ShapeCastSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeCastSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_ShapeCastSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ShapeCastSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ShapeCastSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_ShapeCastSettings_size_t(inCount);
        }

        /// Generated from method `JPH::ShapeCastSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeCastSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_ShapeCastSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ShapeCastSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeCastSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_ShapeCastSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ShapeCastSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ShapeCastSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_ShapeCastSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ShapeCastSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeCastSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_ShapeCastSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::ShapeCastSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ShapeCastSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_ShapeCastSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ShapeCastSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeCastSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_ShapeCastSettings_void_ptr_void_ptr(inPointer, inPlace);
        }
    }

    /// Settings to be passed with a shape cast
    /// Generated from class `JPH::ShapeCastSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CollideSettingsBase`
    /// This is the non-const half of the class.
    public class ShapeCastSettings : Const_ShapeCastSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.CollideSettingsBase(ShapeCastSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_UpcastTo_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_UpcastTo_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideSettingsBase._Underlying *__JPH_ShapeCastSettings_UpcastTo_JPH_CollideSettingsBase(_Underlying *_this);
            JPH.CollideSettingsBase ret = new(__JPH_ShapeCastSettings_UpcastTo_JPH_CollideSettingsBase(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_CollideSettingsBase(ShapeCastSettings self)
            => (JPH.Const_CollideSettingsBase)(JPH.Const_ShapeCastSettings)self;

        // Downcasts:
        public static unsafe explicit operator ShapeCastSettings(JPH.CollideSettingsBase parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_StaticDowncastFrom_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_StaticDowncastFrom_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ShapeCastSettings_StaticDowncastFrom_JPH_CollideSettingsBase(JPH.CollideSettingsBase._Underlying *_this);
            ShapeCastSettings ret = new(__JPH_ShapeCastSettings_StaticDowncastFrom_JPH_CollideSettingsBase(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// How backfacing triangles should be treated (should we report moving from back to front for triangle based shapes, e.g. for MeshShape/HeightFieldShape?)
        public new unsafe ref JPH.EBackFaceMode mBackFaceModeTriangles
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mBackFaceModeTriangles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mBackFaceModeTriangles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EBackFaceMode *__JPH_ShapeCastSettings_GetMutable_mBackFaceModeTriangles(_Underlying *_this);
                return ref *__JPH_ShapeCastSettings_GetMutable_mBackFaceModeTriangles(_UnderlyingPtr);
            }
        }

        /// How backfacing convex objects should be treated (should we report starting inside an object and moving out?)
        public new unsafe ref JPH.EBackFaceMode mBackFaceModeConvex
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mBackFaceModeConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mBackFaceModeConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EBackFaceMode *__JPH_ShapeCastSettings_GetMutable_mBackFaceModeConvex(_Underlying *_this);
                return ref *__JPH_ShapeCastSettings_GetMutable_mBackFaceModeConvex(_UnderlyingPtr);
            }
        }

        /// Indicates if we want to shrink the shape by the convex radius and then expand it again. This speeds up collision detection and gives a more accurate normal at the cost of a more 'rounded' shape.
        public new unsafe ref bool mUseShrunkenShapeAndConvexRadius
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mUseShrunkenShapeAndConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mUseShrunkenShapeAndConvexRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_ShapeCastSettings_GetMutable_mUseShrunkenShapeAndConvexRadius(_Underlying *_this);
                return ref *__JPH_ShapeCastSettings_GetMutable_mUseShrunkenShapeAndConvexRadius(_UnderlyingPtr);
            }
        }

        /// When true, and the shape is intersecting at the beginning of the cast (fraction = 0) then this will calculate the deepest penetration point (costing additional CPU time)
        public new unsafe ref bool mReturnDeepestPoint
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mReturnDeepestPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mReturnDeepestPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_ShapeCastSettings_GetMutable_mReturnDeepestPoint(_Underlying *_this);
                return ref *__JPH_ShapeCastSettings_GetMutable_mReturnDeepestPoint(_UnderlyingPtr);
            }
        }

        /// How active edges (edges that a moving object should bump into) are handled
        public new unsafe ref JPH.EActiveEdgeMode mActiveEdgeMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mActiveEdgeMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mActiveEdgeMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EActiveEdgeMode *__JPH_ShapeCastSettings_GetMutable_mActiveEdgeMode(_Underlying *_this);
                return ref *__JPH_ShapeCastSettings_GetMutable_mActiveEdgeMode(_UnderlyingPtr);
            }
        }

        /// If colliding faces should be collected or only the collision point
        public new unsafe ref JPH.ECollectFacesMode mCollectFacesMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mCollectFacesMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mCollectFacesMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ECollectFacesMode *__JPH_ShapeCastSettings_GetMutable_mCollectFacesMode(_Underlying *_this);
                return ref *__JPH_ShapeCastSettings_GetMutable_mCollectFacesMode(_UnderlyingPtr);
            }
        }

        /// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
        public new unsafe ref float mCollisionTolerance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ShapeCastSettings_GetMutable_mCollisionTolerance(_Underlying *_this);
                return ref *__JPH_ShapeCastSettings_GetMutable_mCollisionTolerance(_UnderlyingPtr);
            }
        }

        /// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
        public new unsafe ref float mPenetrationTolerance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mPenetrationTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mPenetrationTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ShapeCastSettings_GetMutable_mPenetrationTolerance(_Underlying *_this);
                return ref *__JPH_ShapeCastSettings_GetMutable_mPenetrationTolerance(_UnderlyingPtr);
            }
        }

        /// When mActiveEdgeMode is CollideOnlyWithActive a movement direction can be provided. When hitting an inactive edge, the system will select the triangle normal as penetration depth only if it impedes the movement less than with the calculated penetration depth.
        public new unsafe JPH.Vec3 mActiveEdgeMovementDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mActiveEdgeMovementDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_GetMutable_mActiveEdgeMovementDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_ShapeCastSettings_GetMutable_mActiveEdgeMovementDirection(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_ShapeCastSettings_GetMutable_mActiveEdgeMovementDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe ShapeCastSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe ShapeCastSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastSettings._Underlying *__JPH_ShapeCastSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_ShapeCastSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::ShapeCastSettings::ShapeCastSettings`.
        public unsafe ShapeCastSettings(JPH.Const_ShapeCastSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastSettings._Underlying *__JPH_ShapeCastSettings_ConstructFromAnother(JPH.ShapeCastSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_ShapeCastSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::ShapeCastSettings::ShapeCastSettings`.
        public ShapeCastSettings(ShapeCastSettings _other) : this((Const_ShapeCastSettings)_other) {}

        /// Generated from method `JPH::ShapeCastSettings::operator=`.
        public unsafe JPH.ShapeCastSettings Assign(JPH.Const_ShapeCastSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastSettings._Underlying *__JPH_ShapeCastSettings_AssignFromAnother(_Underlying *_this, JPH.ShapeCastSettings._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_ShapeCastSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Set the backfacing mode for all shapes
        /// Generated from method `JPH::ShapeCastSettings::SetBackFaceMode`.
        public unsafe void SetBackFaceMode(JPH.EBackFaceMode inMode)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastSettings_SetBackFaceMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastSettings_SetBackFaceMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ShapeCastSettings_SetBackFaceMode(_Underlying *_this, JPH.EBackFaceMode inMode);
            __JPH_ShapeCastSettings_SetBackFaceMode(_UnderlyingPtr, inMode);
        }
    }

    /// This is used for optional parameters of class `ShapeCastSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ShapeCastSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ShapeCastSettings`/`Const_ShapeCastSettings` directly.
    public class _InOptMut_ShapeCastSettings
    {
        public ShapeCastSettings? Opt;

        public _InOptMut_ShapeCastSettings() {}
        public _InOptMut_ShapeCastSettings(ShapeCastSettings value) {Opt = value;}
        public static implicit operator _InOptMut_ShapeCastSettings(ShapeCastSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `ShapeCastSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ShapeCastSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ShapeCastSettings`/`Const_ShapeCastSettings` to pass it to the function.
    public class _InOptConst_ShapeCastSettings
    {
        public Const_ShapeCastSettings? Opt;

        public _InOptConst_ShapeCastSettings() {}
        public _InOptConst_ShapeCastSettings(Const_ShapeCastSettings value) {Opt = value;}
        public static implicit operator _InOptConst_ShapeCastSettings(Const_ShapeCastSettings value) {return new(value);}
    }

    /// Result of a shape cast test
    /// Generated from class `JPH::ShapeCastResult`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CollideShapeResult`
    /// This is the const half of the class.
    public class Const_ShapeCastResult : JPH.Object<Const_ShapeCastResult>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_ShapeCastResult_Destroy(_Underlying *_this);
            __JPH_ShapeCastResult_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_ShapeCastResult() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_CollideShapeResult(Const_ShapeCastResult self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_UpcastTo_JPH_CollideShapeResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_UpcastTo_JPH_CollideShapeResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_CollideShapeResult._Underlying *__JPH_ShapeCastResult_UpcastTo_JPH_CollideShapeResult(_Underlying *_this);
            JPH.Const_CollideShapeResult ret = new(__JPH_ShapeCastResult_UpcastTo_JPH_CollideShapeResult(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_ShapeCastResult(JPH.Const_CollideShapeResult parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_StaticDowncastFrom_JPH_CollideShapeResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_StaticDowncastFrom_JPH_CollideShapeResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ShapeCastResult_StaticDowncastFrom_JPH_CollideShapeResult(JPH.Const_CollideShapeResult._Underlying *_this);
            Const_ShapeCastResult ret = new(__JPH_ShapeCastResult_StaticDowncastFrom_JPH_CollideShapeResult(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< This is the fraction where the shape hit the other shape: CenterOfMassOnHit = Start + value * (End - Start)
        public unsafe float mFraction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ShapeCastResult_Get_mFraction(_Underlying *_this);
                return *__JPH_ShapeCastResult_Get_mFraction(_UnderlyingPtr);
            }
        }

        ///< True if the shape was hit from the back side
        public unsafe bool mIsBackFaceHit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mIsBackFaceHit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mIsBackFaceHit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_ShapeCastResult_Get_mIsBackFaceHit(_Underlying *_this);
                return *__JPH_ShapeCastResult_Get_mIsBackFaceHit(_UnderlyingPtr);
            }
        }

        ///< Contact point on the surface of shape 1 (in world space or relative to base offset)
        public unsafe JPH.Const_Vec3 mContactPointOn1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mContactPointOn1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mContactPointOn1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_ShapeCastResult_Get_mContactPointOn1(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_ShapeCastResult_Get_mContactPointOn1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Contact point on the surface of shape 2 (in world space or relative to base offset). If the penetration depth is 0, this will be the same as mContactPointOn1.
        public unsafe JPH.Const_Vec3 mContactPointOn2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mContactPointOn2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mContactPointOn2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_ShapeCastResult_Get_mContactPointOn2(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_ShapeCastResult_Get_mContactPointOn2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction to move shape 2 out of collision along the shortest path (magnitude is meaningless, in world space). You can use -mPenetrationAxis.Normalized() as contact normal.
        public unsafe JPH.Const_Vec3 mPenetrationAxis
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mPenetrationAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mPenetrationAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_ShapeCastResult_Get_mPenetrationAxis(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_ShapeCastResult_Get_mPenetrationAxis(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Penetration depth (move shape 2 by this distance to resolve the collision). If CollideShapeSettings::mMaxSeparationDistance > 0 this number can be negative to indicate that the objects are separated by -mPenetrationDepth. The contact points are the closest points in that case.
        public unsafe float mPenetrationDepth
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mPenetrationDepth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mPenetrationDepth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ShapeCastResult_Get_mPenetrationDepth(_Underlying *_this);
                return *__JPH_ShapeCastResult_Get_mPenetrationDepth(_UnderlyingPtr);
            }
        }

        ///< Sub shape ID that identifies the face on shape 1
        public unsafe JPH.Const_SubShapeID mSubShapeID1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mSubShapeID1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mSubShapeID1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_SubShapeID._Underlying *__JPH_ShapeCastResult_Get_mSubShapeID1(_Underlying *_this);
                JPH.Const_SubShapeID __ret;
                __ret = new(__JPH_ShapeCastResult_Get_mSubShapeID1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Sub shape ID that identifies the face on shape 2
        public unsafe JPH.Const_SubShapeID mSubShapeID2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_SubShapeID._Underlying *__JPH_ShapeCastResult_Get_mSubShapeID2(_Underlying *_this);
                JPH.Const_SubShapeID __ret;
                __ret = new(__JPH_ShapeCastResult_Get_mSubShapeID2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< BodyID to which shape 2 belongs to
        public unsafe ref readonly JPH.BodyID mBodyID2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_Get_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_ShapeCastResult_Get_mBodyID2(_Underlying *_this);
                return ref *__JPH_ShapeCastResult_Get_mBodyID2(_UnderlyingPtr);
            }
        }

        internal unsafe Const_ShapeCastResult(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_ShapeCastResult() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastResult._Underlying *__JPH_ShapeCastResult_DefaultConstruct();
            _UnderlyingPtr = __JPH_ShapeCastResult_DefaultConstruct();
        }

        /// Generated from constructor `JPH::ShapeCastResult::ShapeCastResult`.
        public unsafe Const_ShapeCastResult(JPH._ByValue_ShapeCastResult _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastResult._Underlying *__JPH_ShapeCastResult_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.ShapeCastResult._Underlying *_other);
            _UnderlyingPtr = __JPH_ShapeCastResult_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::ShapeCastResult::ShapeCastResult`.
        public Const_ShapeCastResult(Const_ShapeCastResult _other) : this(new _ByValue_ShapeCastResult(_other)) {}

        /// Generated from constructor `JPH::ShapeCastResult::ShapeCastResult`.
        public Const_ShapeCastResult(ShapeCastResult _other) : this((Const_ShapeCastResult)_other) {}

        /// Constructor
        /// @param inFraction Fraction at which the cast hit
        /// @param inContactPoint1 Contact point on shape 1
        /// @param inContactPoint2 Contact point on shape 2
        /// @param inContactNormalOrPenetrationDepth Contact normal pointing from shape 1 to 2 or penetration depth vector when the objects are penetrating (also from 1 to 2)
        /// @param inBackFaceHit If this hit was a back face hit
        /// @param inSubShapeID1 Sub shape id for shape 1
        /// @param inSubShapeID2 Sub shape id for shape 2
        /// @param inBodyID2 BodyID that was hit
        /// Generated from constructor `JPH::ShapeCastResult::ShapeCastResult`.
        public unsafe Const_ShapeCastResult(float inFraction, JPH.Const_Vec3 inContactPoint1, JPH.Const_Vec3 inContactPoint2, JPH.Const_Vec3 inContactNormalOrPenetrationDepth, bool inBackFaceHit, JPH.Const_SubShapeID inSubShapeID1, JPH.Const_SubShapeID inSubShapeID2, in JPH.BodyID inBodyID2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastResult._Underlying *__JPH_ShapeCastResult_Construct(float inFraction, JPH.Vec3._Underlying *inContactPoint1, JPH.Vec3._Underlying *inContactPoint2, JPH.Vec3._Underlying *inContactNormalOrPenetrationDepth, byte inBackFaceHit, JPH.Const_SubShapeID._Underlying *inSubShapeID1, JPH.Const_SubShapeID._Underlying *inSubShapeID2, JPH.BodyID *inBodyID2);
            fixed (JPH.BodyID *__ptr_inBodyID2 = &inBodyID2)
            {
                _UnderlyingPtr = __JPH_ShapeCastResult_Construct(inFraction, inContactPoint1._UnderlyingPtr, inContactPoint2._UnderlyingPtr, inContactNormalOrPenetrationDepth._UnderlyingPtr, inBackFaceHit ? (byte)1 : (byte)0, inSubShapeID1._UnderlyingPtr, inSubShapeID2._UnderlyingPtr, __ptr_inBodyID2);
            }
        }

        /// Generated from method `JPH::ShapeCastResult::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ShapeCastResult_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_ShapeCastResult_size_t(inCount);
        }

        /// Generated from method `JPH::ShapeCastResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeCastResult_void_ptr(void *inPointer);
            __Jolt_delete_JPH_ShapeCastResult_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ShapeCastResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeCastResult_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_ShapeCastResult_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ShapeCastResult::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ShapeCastResult_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_ShapeCastResult_size_t(inCount);
        }

        /// Generated from method `JPH::ShapeCastResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeCastResult_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_ShapeCastResult_void_ptr(inPointer);
        }

        /// Generated from method `JPH::ShapeCastResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeCastResult_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_ShapeCastResult_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::ShapeCastResult::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_ShapeCastResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_ShapeCastResult_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_ShapeCastResult_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ShapeCastResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_ShapeCastResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_ShapeCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_ShapeCastResult_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::ShapeCastResult::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_ShapeCastResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_ShapeCastResult_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_ShapeCastResult_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::ShapeCastResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_ShapeCastResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_ShapeCastResult_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_ShapeCastResult_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Function required by the CollisionCollector. A smaller fraction is considered to be a 'better hit'. For rays/cast shapes we can just use the collision fraction. The fraction and penetration depth are combined in such a way that deeper hits at fraction 0 go first.
        /// Generated from method `JPH::ShapeCastResult::GetEarlyOutFraction`.
        public unsafe float GetEarlyOutFraction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_GetEarlyOutFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_GetEarlyOutFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_ShapeCastResult_GetEarlyOutFraction(_Underlying *_this);
            return __JPH_ShapeCastResult_GetEarlyOutFraction(_UnderlyingPtr);
        }

        /// Reverses the hit result, swapping contact point 1 with contact point 2 etc.
        /// @param inWorldSpaceCastDirection Direction of the shape cast in world space
        /// Generated from method `JPH::ShapeCastResult::Reversed`.
        public unsafe JPH.ShapeCastResult Reversed(JPH.Const_Vec3 inWorldSpaceCastDirection)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_Reversed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_Reversed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastResult._Underlying *__JPH_ShapeCastResult_Reversed(_Underlying *_this, JPH.Vec3._Underlying *inWorldSpaceCastDirection);
            return new(__JPH_ShapeCastResult_Reversed(_UnderlyingPtr, inWorldSpaceCastDirection._UnderlyingPtr), is_owning: true);
        }
    }

    /// Result of a shape cast test
    /// Generated from class `JPH::ShapeCastResult`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CollideShapeResult`
    /// This is the non-const half of the class.
    public class ShapeCastResult : Const_ShapeCastResult
    {
        // Upcasts:
        public static unsafe implicit operator JPH.CollideShapeResult(ShapeCastResult self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_UpcastTo_JPH_CollideShapeResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_UpcastTo_JPH_CollideShapeResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideShapeResult._Underlying *__JPH_ShapeCastResult_UpcastTo_JPH_CollideShapeResult(_Underlying *_this);
            JPH.CollideShapeResult ret = new(__JPH_ShapeCastResult_UpcastTo_JPH_CollideShapeResult(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_CollideShapeResult(ShapeCastResult self)
            => (JPH.Const_CollideShapeResult)(JPH.Const_ShapeCastResult)self;

        // Downcasts:
        public static unsafe explicit operator ShapeCastResult(JPH.CollideShapeResult parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_StaticDowncastFrom_JPH_CollideShapeResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_StaticDowncastFrom_JPH_CollideShapeResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_ShapeCastResult_StaticDowncastFrom_JPH_CollideShapeResult(JPH.CollideShapeResult._Underlying *_this);
            ShapeCastResult ret = new(__JPH_ShapeCastResult_StaticDowncastFrom_JPH_CollideShapeResult(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< This is the fraction where the shape hit the other shape: CenterOfMassOnHit = Start + value * (End - Start)
        public new unsafe ref float mFraction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ShapeCastResult_GetMutable_mFraction(_Underlying *_this);
                return ref *__JPH_ShapeCastResult_GetMutable_mFraction(_UnderlyingPtr);
            }
        }

        ///< True if the shape was hit from the back side
        public new unsafe ref bool mIsBackFaceHit
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mIsBackFaceHit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mIsBackFaceHit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_ShapeCastResult_GetMutable_mIsBackFaceHit(_Underlying *_this);
                return ref *__JPH_ShapeCastResult_GetMutable_mIsBackFaceHit(_UnderlyingPtr);
            }
        }

        ///< Contact point on the surface of shape 1 (in world space or relative to base offset)
        public new unsafe JPH.Vec3 mContactPointOn1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mContactPointOn1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mContactPointOn1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_ShapeCastResult_GetMutable_mContactPointOn1(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_ShapeCastResult_GetMutable_mContactPointOn1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Contact point on the surface of shape 2 (in world space or relative to base offset). If the penetration depth is 0, this will be the same as mContactPointOn1.
        public new unsafe JPH.Vec3 mContactPointOn2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mContactPointOn2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mContactPointOn2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_ShapeCastResult_GetMutable_mContactPointOn2(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_ShapeCastResult_GetMutable_mContactPointOn2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction to move shape 2 out of collision along the shortest path (magnitude is meaningless, in world space). You can use -mPenetrationAxis.Normalized() as contact normal.
        public new unsafe JPH.Vec3 mPenetrationAxis
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mPenetrationAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mPenetrationAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_ShapeCastResult_GetMutable_mPenetrationAxis(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_ShapeCastResult_GetMutable_mPenetrationAxis(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Penetration depth (move shape 2 by this distance to resolve the collision). If CollideShapeSettings::mMaxSeparationDistance > 0 this number can be negative to indicate that the objects are separated by -mPenetrationDepth. The contact points are the closest points in that case.
        public new unsafe ref float mPenetrationDepth
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mPenetrationDepth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mPenetrationDepth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_ShapeCastResult_GetMutable_mPenetrationDepth(_Underlying *_this);
                return ref *__JPH_ShapeCastResult_GetMutable_mPenetrationDepth(_UnderlyingPtr);
            }
        }

        ///< Sub shape ID that identifies the face on shape 1
        public new unsafe JPH.SubShapeID mSubShapeID1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mSubShapeID1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mSubShapeID1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SubShapeID._Underlying *__JPH_ShapeCastResult_GetMutable_mSubShapeID1(_Underlying *_this);
                JPH.SubShapeID __ret;
                __ret = new(__JPH_ShapeCastResult_GetMutable_mSubShapeID1(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Sub shape ID that identifies the face on shape 2
        public new unsafe JPH.SubShapeID mSubShapeID2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SubShapeID._Underlying *__JPH_ShapeCastResult_GetMutable_mSubShapeID2(_Underlying *_this);
                JPH.SubShapeID __ret;
                __ret = new(__JPH_ShapeCastResult_GetMutable_mSubShapeID2(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< BodyID to which shape 2 belongs to
        public new unsafe ref JPH.BodyID mBodyID2
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_GetMutable_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_ShapeCastResult_GetMutable_mBodyID2(_Underlying *_this);
                return ref *__JPH_ShapeCastResult_GetMutable_mBodyID2(_UnderlyingPtr);
            }
        }

        internal unsafe ShapeCastResult(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe ShapeCastResult() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastResult._Underlying *__JPH_ShapeCastResult_DefaultConstruct();
            _UnderlyingPtr = __JPH_ShapeCastResult_DefaultConstruct();
        }

        /// Generated from constructor `JPH::ShapeCastResult::ShapeCastResult`.
        public unsafe ShapeCastResult(JPH._ByValue_ShapeCastResult _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastResult._Underlying *__JPH_ShapeCastResult_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.ShapeCastResult._Underlying *_other);
            _UnderlyingPtr = __JPH_ShapeCastResult_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::ShapeCastResult::ShapeCastResult`.
        public ShapeCastResult(Const_ShapeCastResult _other) : this(new _ByValue_ShapeCastResult(_other)) {}

        /// Generated from constructor `JPH::ShapeCastResult::ShapeCastResult`.
        public ShapeCastResult(ShapeCastResult _other) : this((Const_ShapeCastResult)_other) {}

        /// Constructor
        /// @param inFraction Fraction at which the cast hit
        /// @param inContactPoint1 Contact point on shape 1
        /// @param inContactPoint2 Contact point on shape 2
        /// @param inContactNormalOrPenetrationDepth Contact normal pointing from shape 1 to 2 or penetration depth vector when the objects are penetrating (also from 1 to 2)
        /// @param inBackFaceHit If this hit was a back face hit
        /// @param inSubShapeID1 Sub shape id for shape 1
        /// @param inSubShapeID2 Sub shape id for shape 2
        /// @param inBodyID2 BodyID that was hit
        /// Generated from constructor `JPH::ShapeCastResult::ShapeCastResult`.
        public unsafe ShapeCastResult(float inFraction, JPH.Const_Vec3 inContactPoint1, JPH.Const_Vec3 inContactPoint2, JPH.Const_Vec3 inContactNormalOrPenetrationDepth, bool inBackFaceHit, JPH.Const_SubShapeID inSubShapeID1, JPH.Const_SubShapeID inSubShapeID2, in JPH.BodyID inBodyID2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastResult._Underlying *__JPH_ShapeCastResult_Construct(float inFraction, JPH.Vec3._Underlying *inContactPoint1, JPH.Vec3._Underlying *inContactPoint2, JPH.Vec3._Underlying *inContactNormalOrPenetrationDepth, byte inBackFaceHit, JPH.Const_SubShapeID._Underlying *inSubShapeID1, JPH.Const_SubShapeID._Underlying *inSubShapeID2, JPH.BodyID *inBodyID2);
            fixed (JPH.BodyID *__ptr_inBodyID2 = &inBodyID2)
            {
                _UnderlyingPtr = __JPH_ShapeCastResult_Construct(inFraction, inContactPoint1._UnderlyingPtr, inContactPoint2._UnderlyingPtr, inContactNormalOrPenetrationDepth._UnderlyingPtr, inBackFaceHit ? (byte)1 : (byte)0, inSubShapeID1._UnderlyingPtr, inSubShapeID2._UnderlyingPtr, __ptr_inBodyID2);
            }
        }

        /// Generated from method `JPH::ShapeCastResult::operator=`.
        public unsafe JPH.ShapeCastResult Assign(JPH._ByValue_ShapeCastResult _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_ShapeCastResult_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_ShapeCastResult_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.ShapeCastResult._Underlying *__JPH_ShapeCastResult_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.ShapeCastResult._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_ShapeCastResult_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `ShapeCastResult` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `ShapeCastResult`/`Const_ShapeCastResult` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_ShapeCastResult
    {
        #pragma warning disable CS0649
        internal readonly Const_ShapeCastResult? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_ShapeCastResult() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_ShapeCastResult(Const_ShapeCastResult new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_ShapeCastResult(Const_ShapeCastResult arg) {return new(arg);}
        public _ByValue_ShapeCastResult(JPH._Moved<ShapeCastResult> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_ShapeCastResult(JPH._Moved<ShapeCastResult> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `ShapeCastResult` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_ShapeCastResult`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ShapeCastResult`/`Const_ShapeCastResult` directly.
    public class _InOptMut_ShapeCastResult
    {
        public ShapeCastResult? Opt;

        public _InOptMut_ShapeCastResult() {}
        public _InOptMut_ShapeCastResult(ShapeCastResult value) {Opt = value;}
        public static implicit operator _InOptMut_ShapeCastResult(ShapeCastResult value) {return new(value);}
    }

    /// This is used for optional parameters of class `ShapeCastResult` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_ShapeCastResult`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `ShapeCastResult`/`Const_ShapeCastResult` to pass it to the function.
    public class _InOptConst_ShapeCastResult
    {
        public Const_ShapeCastResult? Opt;

        public _InOptConst_ShapeCastResult() {}
        public _InOptConst_ShapeCastResult(Const_ShapeCastResult value) {Opt = value;}
        public static implicit operator _InOptConst_ShapeCastResult(Const_ShapeCastResult value) {return new(value);}
    }
}
