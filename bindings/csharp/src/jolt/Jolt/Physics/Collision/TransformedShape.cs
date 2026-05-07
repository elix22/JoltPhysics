// machine generated, do not edit
public static partial class JPH
{
    /// Temporary data structure that contains a shape and a transform.
    /// This structure can be obtained from a body (e.g. after a broad phase query) under lock protection.
    /// The lock can then be released and collision detection operations can be safely performed since
    /// the class takes a reference on the shape and does not use anything from the body anymore.
    /// Generated from class `JPH::TransformedShape`.
    /// This is the const half of the class.
    public class Const_TransformedShape : JPH.Object<Const_TransformedShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TransformedShape_Destroy(_Underlying *_this);
            __JPH_TransformedShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_TransformedShape() {Dispose(false);}

        ///< Center of mass world position of the shape
        public unsafe JPH.Const_Vec3 mShapePositionCOM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_Get_mShapePositionCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_Get_mShapePositionCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_TransformedShape_Get_mShapePositionCOM(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_TransformedShape_Get_mShapePositionCOM(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Rotation of the shape
        public unsafe JPH.Const_Quat mShapeRotation
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_Get_mShapeRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_Get_mShapeRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Quat._Underlying *__JPH_TransformedShape_Get_mShapeRotation(_Underlying *_this);
                JPH.Const_Quat __ret;
                __ret = new(__JPH_TransformedShape_Get_mShapeRotation(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Not stored as Vec3 to get a nicely packed structure
        public unsafe JPH.Const_Float3 mShapeScale
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_Get_mShapeScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_Get_mShapeScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Float3._Underlying *__JPH_TransformedShape_Get_mShapeScale(_Underlying *_this);
                JPH.Const_Float3 __ret;
                __ret = new(__JPH_TransformedShape_Get_mShapeScale(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Optional body ID from which this shape comes
        public unsafe ref readonly JPH.BodyID mBodyID
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_Get_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_Get_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_TransformedShape_Get_mBodyID(_Underlying *_this);
                return ref *__JPH_TransformedShape_Get_mBodyID(_UnderlyingPtr);
            }
        }

        ///< Optional sub shape ID creator for the shape (can be used when expanding compound shapes into multiple transformed shapes)
        public unsafe JPH.Const_SubShapeIDCreator mSubShapeIDCreator
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_Get_mSubShapeIDCreator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_Get_mSubShapeIDCreator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_SubShapeIDCreator._Underlying *__JPH_TransformedShape_Get_mSubShapeIDCreator(_Underlying *_this);
                JPH.Const_SubShapeIDCreator __ret;
                __ret = new(__JPH_TransformedShape_Get_mSubShapeIDCreator(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_TransformedShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_TransformedShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TransformedShape._Underlying *__JPH_TransformedShape_DefaultConstruct();
            _UnderlyingPtr = __JPH_TransformedShape_DefaultConstruct();
        }

        /// Generated from constructor `JPH::TransformedShape::TransformedShape`.
        public unsafe Const_TransformedShape(JPH._ByValue_TransformedShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TransformedShape._Underlying *__JPH_TransformedShape_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.TransformedShape._Underlying *_other);
            _UnderlyingPtr = __JPH_TransformedShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::TransformedShape::TransformedShape`.
        public Const_TransformedShape(Const_TransformedShape _other) : this(new _ByValue_TransformedShape(_other)) {}

        /// Generated from constructor `JPH::TransformedShape::TransformedShape`.
        public Const_TransformedShape(TransformedShape _other) : this((Const_TransformedShape)_other) {}

        /// Generated from constructor `JPH::TransformedShape::TransformedShape`.
        /// Parameter `inSubShapeIDCreator` defaults to `JPH::SubShapeIDCreator()`.
        public unsafe Const_TransformedShape(JPH.Const_Vec3 inPositionCOM, JPH.Const_Quat inRotation, JPH.Const_Shape? inShape, in JPH.BodyID inBodyID, JPH.Const_SubShapeIDCreator? inSubShapeIDCreator = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TransformedShape._Underlying *__JPH_TransformedShape_Construct(JPH.Vec3._Underlying *inPositionCOM, JPH.Quat._Underlying *inRotation, JPH.Const_Shape._Underlying *inShape, JPH.BodyID *inBodyID, JPH.Const_SubShapeIDCreator._Underlying *inSubShapeIDCreator);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                _UnderlyingPtr = __JPH_TransformedShape_Construct(inPositionCOM._UnderlyingPtr, inRotation._UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null, __ptr_inBodyID, inSubShapeIDCreator is not null ? inSubShapeIDCreator._UnderlyingPtr : null);
            }
        }

        /// Generated from method `JPH::TransformedShape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TransformedShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TransformedShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TransformedShape_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_TransformedShape_size_t(inCount);
        }

        /// Generated from method `JPH::TransformedShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TransformedShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TransformedShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TransformedShape_void_ptr(void *inPointer);
            __Jolt_delete_JPH_TransformedShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TransformedShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TransformedShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TransformedShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TransformedShape_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_TransformedShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TransformedShape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TransformedShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TransformedShape_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TransformedShape_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_TransformedShape_size_t(inCount);
        }

        /// Generated from method `JPH::TransformedShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TransformedShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TransformedShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TransformedShape_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_TransformedShape_void_ptr(inPointer);
        }

        /// Generated from method `JPH::TransformedShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TransformedShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TransformedShape_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TransformedShape_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_TransformedShape_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::TransformedShape::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_TransformedShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_TransformedShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_TransformedShape_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_TransformedShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TransformedShape::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_TransformedShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_TransformedShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_TransformedShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_TransformedShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::TransformedShape::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_TransformedShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_TransformedShape_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_TransformedShape_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_TransformedShape_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::TransformedShape::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_TransformedShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_TransformedShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_TransformedShape_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_TransformedShape_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Cast a ray and find the closest hit. Returns true if it finds a hit. Hits further than ioHit.mFraction will not be considered and in this case ioHit will remain unmodified (and the function will return false).
        /// Convex objects will be treated as solid (meaning if the ray starts inside, you'll get a hit fraction of 0) and back face hits are returned.
        /// If you want the surface normal of the hit use GetWorldSpaceSurfaceNormal(ioHit.mSubShapeID2, inRay.GetPointOnRay(ioHit.mFraction)) on this object.
        /// Generated from method `JPH::TransformedShape::CastRay`.
        public unsafe bool CastRay(JPH.Const_RRayCast inRay, JPH.RayCastResult ioHit)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_CastRay_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_CastRay_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_TransformedShape_CastRay_2(_Underlying *_this, JPH.Const_RRayCast._Underlying *inRay, JPH.RayCastResult._Underlying *ioHit);
            return __JPH_TransformedShape_CastRay_2(_UnderlyingPtr, inRay._UnderlyingPtr, ioHit._UnderlyingPtr) != 0;
        }

        /// To start iterating over triangles, call this function first.
        /// To get the actual triangles call GetTrianglesNext.
        /// @param ioContext A temporary buffer and should remain untouched until the last call to GetTrianglesNext.
        /// @param inBox The world space bounding in which you want to get the triangles.
        /// @param inBaseOffset All hit results will be returned relative to this offset, can be zero to get results in world position, but when you're testing far from the origin you get better precision by picking a position that's closer e.g. inBox.GetCenter() since floats are most accurate near the origin
        /// Generated from method `JPH::TransformedShape::GetTrianglesStart`.
        public unsafe void GetTrianglesStart(JPH.Shape.GetTrianglesContext ioContext, JPH.Const_AABox inBox, JPH.Const_Vec3 inBaseOffset)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetTrianglesStart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TransformedShape_GetTrianglesStart(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, JPH.Const_AABox._Underlying *inBox, JPH.Vec3._Underlying *inBaseOffset);
            __JPH_TransformedShape_GetTrianglesStart(_UnderlyingPtr, ioContext._UnderlyingPtr, inBox._UnderlyingPtr, inBaseOffset._UnderlyingPtr);
        }

        /// Call this repeatedly to get all triangles in the box.
        /// outTriangleVertices should be large enough to hold 3 * inMaxTriangleRequested entries
        /// outMaterials (if it is not null) should contain inMaxTrianglesRequested entries
        /// The function returns the amount of triangles that it found (which will be <= inMaxTrianglesRequested), or 0 if there are no more triangles.
        /// Note that the function can return a value < inMaxTrianglesRequested and still have more triangles to process (triangles can be returned in blocks)
        /// Note that the function may return triangles outside of the requested box, only coarse culling is performed on the returned triangles
        /// Generated from method `JPH::TransformedShape::GetTrianglesNext`.
        public unsafe int GetTrianglesNext(JPH.Shape.GetTrianglesContext ioContext, int inMaxTrianglesRequested, JPH.Float3? outTriangleVertices, void **outMaterials = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetTrianglesNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_TransformedShape_GetTrianglesNext(_Underlying *_this, JPH.Shape.GetTrianglesContext._Underlying *ioContext, int inMaxTrianglesRequested, JPH.Float3._Underlying *outTriangleVertices, void **outMaterials);
            return __JPH_TransformedShape_GetTrianglesNext(_UnderlyingPtr, ioContext._UnderlyingPtr, inMaxTrianglesRequested, outTriangleVertices is not null ? outTriangleVertices._UnderlyingPtr : null, outMaterials);
        }

        /// Get/set the scale of the shape as a Vec3
        /// Generated from method `JPH::TransformedShape::GetShapeScale`.
        public unsafe JPH.Vec3 GetShapeScale()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetShapeScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetShapeScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_TransformedShape_GetShapeScale(_Underlying *_this);
            return new(__JPH_TransformedShape_GetShapeScale(_UnderlyingPtr), is_owning: true);
        }

        /// Calculates the transform for this shape's center of mass (excluding scale)
        /// Generated from method `JPH::TransformedShape::GetCenterOfMassTransform`.
        public unsafe JPH.Mat44 GetCenterOfMassTransform()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_TransformedShape_GetCenterOfMassTransform(_Underlying *_this);
            return new(__JPH_TransformedShape_GetCenterOfMassTransform(_UnderlyingPtr), is_owning: true);
        }

        /// Calculates the inverse of the transform for this shape's center of mass (excluding scale)
        /// Generated from method `JPH::TransformedShape::GetInverseCenterOfMassTransform`.
        public unsafe JPH.Mat44 GetInverseCenterOfMassTransform()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetInverseCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetInverseCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_TransformedShape_GetInverseCenterOfMassTransform(_Underlying *_this);
            return new(__JPH_TransformedShape_GetInverseCenterOfMassTransform(_UnderlyingPtr), is_owning: true);
        }

        /// Calculates the world transform including scale of this shape (not from the center of mass but in the space the shape was created)
        /// Generated from method `JPH::TransformedShape::GetWorldTransform`.
        public unsafe JPH.Mat44 GetWorldTransform()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Mat44._Underlying *__JPH_TransformedShape_GetWorldTransform(_Underlying *_this);
            return new(__JPH_TransformedShape_GetWorldTransform(_UnderlyingPtr), is_owning: true);
        }

        /// Get the world space bounding box for this transformed shape
        /// Generated from method `JPH::TransformedShape::GetWorldSpaceBounds`.
        public unsafe JPH.AABox GetWorldSpaceBounds()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetWorldSpaceBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetWorldSpaceBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_TransformedShape_GetWorldSpaceBounds(_Underlying *_this);
            return new(__JPH_TransformedShape_GetWorldSpaceBounds(_UnderlyingPtr), is_owning: true);
        }

        /// Make inSubShapeID relative to mShape. When mSubShapeIDCreator is not empty, this is needed in order to get the correct path to the sub shape.
        /// Generated from method `JPH::TransformedShape::MakeSubShapeIDRelativeToShape`.
        public unsafe JPH.SubShapeID MakeSubShapeIDRelativeToShape(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_MakeSubShapeIDRelativeToShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_MakeSubShapeIDRelativeToShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SubShapeID._Underlying *__JPH_TransformedShape_MakeSubShapeIDRelativeToShape(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            return new(__JPH_TransformedShape_MakeSubShapeIDRelativeToShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr), is_owning: true);
        }

        /// Get surface normal of a particular sub shape and its world space surface position on this body.
        /// Note: When you have a CollideShapeResult or ShapeCastResult you should use -mPenetrationAxis.Normalized() as contact normal as GetWorldSpaceSurfaceNormal will only return face normals (and not vertex or edge normals).
        /// Generated from method `JPH::TransformedShape::GetWorldSpaceSurfaceNormal`.
        public unsafe JPH.Vec3 GetWorldSpaceSurfaceNormal(JPH.Const_SubShapeID inSubShapeID, JPH.Const_Vec3 inPosition)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetWorldSpaceSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetWorldSpaceSurfaceNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_TransformedShape_GetWorldSpaceSurfaceNormal(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.Vec3._Underlying *inPosition);
            return new(__JPH_TransformedShape_GetWorldSpaceSurfaceNormal(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, inPosition._UnderlyingPtr), is_owning: true);
        }

        /// Get material of a particular sub shape
        /// Generated from method `JPH::TransformedShape::GetMaterial`.
        public unsafe JPH.Const_PhysicsMaterial? GetMaterial(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetMaterial", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_PhysicsMaterial._Underlying *__JPH_TransformedShape_GetMaterial(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            var __c_ret = __JPH_TransformedShape_GetMaterial(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
            return __c_ret is not null ? new JPH.Const_PhysicsMaterial(__c_ret, is_owning: false) : null;
        }

        /// Get the user data of a particular sub shape
        /// Generated from method `JPH::TransformedShape::GetSubShapeUserData`.
        public unsafe ulong GetSubShapeUserData(JPH.Const_SubShapeID inSubShapeID)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetSubShapeUserData", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __JPH_TransformedShape_GetSubShapeUserData(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID);
            return __JPH_TransformedShape_GetSubShapeUserData(_UnderlyingPtr, inSubShapeID._UnderlyingPtr);
        }

        /// Get the direct child sub shape and its transform for a sub shape ID.
        /// @param inSubShapeID Sub shape ID that indicates the path to the leaf shape
        /// @param outRemainder The remainder of the sub shape ID after removing the sub shape
        /// @return Direct child sub shape and its transform, note that the body ID and sub shape ID will be invalid
        /// Generated from method `JPH::TransformedShape::GetSubShapeTransformedShape`.
        public unsafe JPH.TransformedShape GetSubShapeTransformedShape(JPH.Const_SubShapeID inSubShapeID, JPH.SubShapeID outRemainder)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetSubShapeTransformedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetSubShapeTransformedShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TransformedShape._Underlying *__JPH_TransformedShape_GetSubShapeTransformedShape(_Underlying *_this, JPH.Const_SubShapeID._Underlying *inSubShapeID, JPH.SubShapeID._Underlying *outRemainder);
            return new(__JPH_TransformedShape_GetSubShapeTransformedShape(_UnderlyingPtr, inSubShapeID._UnderlyingPtr, outRemainder._UnderlyingPtr), is_owning: true);
        }

        /// Helper function to return the body id from a transformed shape. If the transformed shape is null an invalid body ID will be returned.
        /// Generated from method `JPH::TransformedShape::sGetBodyID`.
        public static unsafe JPH.BodyID SGetBodyID(JPH.Const_TransformedShape? inTS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_sGetBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_sGetBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID __JPH_TransformedShape_sGetBodyID(JPH.Const_TransformedShape._Underlying *inTS);
            return __JPH_TransformedShape_sGetBodyID(inTS is not null ? inTS._UnderlyingPtr : null);
        }
    }

    /// Temporary data structure that contains a shape and a transform.
    /// This structure can be obtained from a body (e.g. after a broad phase query) under lock protection.
    /// The lock can then be released and collision detection operations can be safely performed since
    /// the class takes a reference on the shape and does not use anything from the body anymore.
    /// Generated from class `JPH::TransformedShape`.
    /// This is the non-const half of the class.
    public class TransformedShape : Const_TransformedShape
    {
        ///< Center of mass world position of the shape
        public new unsafe JPH.Vec3 mShapePositionCOM
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetMutable_mShapePositionCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetMutable_mShapePositionCOM", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_TransformedShape_GetMutable_mShapePositionCOM(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_TransformedShape_GetMutable_mShapePositionCOM(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Rotation of the shape
        public new unsafe JPH.Quat mShapeRotation
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetMutable_mShapeRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetMutable_mShapeRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Quat._Underlying *__JPH_TransformedShape_GetMutable_mShapeRotation(_Underlying *_this);
                JPH.Quat __ret;
                __ret = new(__JPH_TransformedShape_GetMutable_mShapeRotation(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Not stored as Vec3 to get a nicely packed structure
        public new unsafe JPH.Float3 mShapeScale
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetMutable_mShapeScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetMutable_mShapeScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Float3._Underlying *__JPH_TransformedShape_GetMutable_mShapeScale(_Underlying *_this);
                JPH.Float3 __ret;
                __ret = new(__JPH_TransformedShape_GetMutable_mShapeScale(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Optional body ID from which this shape comes
        public new unsafe ref JPH.BodyID mBodyID
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetMutable_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetMutable_mBodyID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_TransformedShape_GetMutable_mBodyID(_Underlying *_this);
                return ref *__JPH_TransformedShape_GetMutable_mBodyID(_UnderlyingPtr);
            }
        }

        ///< Optional sub shape ID creator for the shape (can be used when expanding compound shapes into multiple transformed shapes)
        public new unsafe JPH.SubShapeIDCreator mSubShapeIDCreator
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_GetMutable_mSubShapeIDCreator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_GetMutable_mSubShapeIDCreator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SubShapeIDCreator._Underlying *__JPH_TransformedShape_GetMutable_mSubShapeIDCreator(_Underlying *_this);
                JPH.SubShapeIDCreator __ret;
                __ret = new(__JPH_TransformedShape_GetMutable_mSubShapeIDCreator(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe TransformedShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe TransformedShape() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TransformedShape._Underlying *__JPH_TransformedShape_DefaultConstruct();
            _UnderlyingPtr = __JPH_TransformedShape_DefaultConstruct();
        }

        /// Generated from constructor `JPH::TransformedShape::TransformedShape`.
        public unsafe TransformedShape(JPH._ByValue_TransformedShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TransformedShape._Underlying *__JPH_TransformedShape_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.TransformedShape._Underlying *_other);
            _UnderlyingPtr = __JPH_TransformedShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::TransformedShape::TransformedShape`.
        public TransformedShape(Const_TransformedShape _other) : this(new _ByValue_TransformedShape(_other)) {}

        /// Generated from constructor `JPH::TransformedShape::TransformedShape`.
        public TransformedShape(TransformedShape _other) : this((Const_TransformedShape)_other) {}

        /// Generated from constructor `JPH::TransformedShape::TransformedShape`.
        /// Parameter `inSubShapeIDCreator` defaults to `JPH::SubShapeIDCreator()`.
        public unsafe TransformedShape(JPH.Const_Vec3 inPositionCOM, JPH.Const_Quat inRotation, JPH.Const_Shape? inShape, in JPH.BodyID inBodyID, JPH.Const_SubShapeIDCreator? inSubShapeIDCreator = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TransformedShape._Underlying *__JPH_TransformedShape_Construct(JPH.Vec3._Underlying *inPositionCOM, JPH.Quat._Underlying *inRotation, JPH.Const_Shape._Underlying *inShape, JPH.BodyID *inBodyID, JPH.Const_SubShapeIDCreator._Underlying *inSubShapeIDCreator);
            fixed (JPH.BodyID *__ptr_inBodyID = &inBodyID)
            {
                _UnderlyingPtr = __JPH_TransformedShape_Construct(inPositionCOM._UnderlyingPtr, inRotation._UnderlyingPtr, inShape is not null ? inShape._UnderlyingPtr : null, __ptr_inBodyID, inSubShapeIDCreator is not null ? inSubShapeIDCreator._UnderlyingPtr : null);
            }
        }

        /// Generated from method `JPH::TransformedShape::operator=`.
        public unsafe JPH.TransformedShape Assign(JPH._ByValue_TransformedShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.TransformedShape._Underlying *__JPH_TransformedShape_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.TransformedShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_TransformedShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `JPH::TransformedShape::SetShapeScale`.
        public unsafe void SetShapeScale(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_SetShapeScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_SetShapeScale", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TransformedShape_SetShapeScale(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            __JPH_TransformedShape_SetShapeScale(_UnderlyingPtr, inScale._UnderlyingPtr);
        }

        /// Sets the world transform (including scale) of this transformed shape (not from the center of mass but in the space the shape was created)
        /// Generated from method `JPH::TransformedShape::SetWorldTransform`.
        public unsafe void SetWorldTransform(JPH.Const_Vec3 inPosition, JPH.Const_Quat inRotation, JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_SetWorldTransform_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_SetWorldTransform_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TransformedShape_SetWorldTransform_3(_Underlying *_this, JPH.Vec3._Underlying *inPosition, JPH.Quat._Underlying *inRotation, JPH.Vec3._Underlying *inScale);
            __JPH_TransformedShape_SetWorldTransform_3(_UnderlyingPtr, inPosition._UnderlyingPtr, inRotation._UnderlyingPtr, inScale._UnderlyingPtr);
        }

        /// Sets the world transform (including scale) of this transformed shape (not from the center of mass but in the space the shape was created)
        /// Generated from method `JPH::TransformedShape::SetWorldTransform`.
        public unsafe void SetWorldTransform(JPH.Const_Mat44 inTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_TransformedShape_SetWorldTransform_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_TransformedShape_SetWorldTransform_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_TransformedShape_SetWorldTransform_1(_Underlying *_this, JPH.Const_Mat44._Underlying *inTransform);
            __JPH_TransformedShape_SetWorldTransform_1(_UnderlyingPtr, inTransform._UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `TransformedShape` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `TransformedShape`/`Const_TransformedShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_TransformedShape
    {
        #pragma warning disable CS0649
        internal readonly Const_TransformedShape? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_TransformedShape() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_TransformedShape(Const_TransformedShape new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_TransformedShape(Const_TransformedShape arg) {return new(arg);}
        public _ByValue_TransformedShape(JPH._Moved<TransformedShape> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_TransformedShape(JPH._Moved<TransformedShape> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `TransformedShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_TransformedShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TransformedShape`/`Const_TransformedShape` directly.
    public class _InOptMut_TransformedShape
    {
        public TransformedShape? Opt;

        public _InOptMut_TransformedShape() {}
        public _InOptMut_TransformedShape(TransformedShape value) {Opt = value;}
        public static implicit operator _InOptMut_TransformedShape(TransformedShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `TransformedShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_TransformedShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `TransformedShape`/`Const_TransformedShape` to pass it to the function.
    public class _InOptConst_TransformedShape
    {
        public Const_TransformedShape? Opt;

        public _InOptConst_TransformedShape() {}
        public _InOptConst_TransformedShape(Const_TransformedShape value) {Opt = value;}
        public static implicit operator _InOptConst_TransformedShape(Const_TransformedShape value) {return new(value);}
    }
}
