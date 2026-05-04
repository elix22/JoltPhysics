// machine generated, do not edit
public static partial class JPH
{
    /// Class that contains all information of two colliding shapes
    /// Generated from class `JPH::CollideShapeResult`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeCastResult`
    /// This is the const half of the class.
    public class Const_CollideShapeResult : JPH.Object<Const_CollideShapeResult>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CollideShapeResult_Destroy(_Underlying *_this);
            __JPH_CollideShapeResult_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_CollideShapeResult() {Dispose(false);}

        ///< Contact point on the surface of shape 1 (in world space or relative to base offset)
        public unsafe JPH.Const_Vec3 mContactPointOn1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_Get_mContactPointOn1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_Get_mContactPointOn1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_CollideShapeResult_Get_mContactPointOn1(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_CollideShapeResult_Get_mContactPointOn1(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_Get_mContactPointOn2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_Get_mContactPointOn2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_CollideShapeResult_Get_mContactPointOn2(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_CollideShapeResult_Get_mContactPointOn2(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_Get_mPenetrationAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_Get_mPenetrationAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_CollideShapeResult_Get_mPenetrationAxis(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_CollideShapeResult_Get_mPenetrationAxis(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_Get_mPenetrationDepth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_Get_mPenetrationDepth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CollideShapeResult_Get_mPenetrationDepth(_Underlying *_this);
                return *__JPH_CollideShapeResult_Get_mPenetrationDepth(_UnderlyingPtr);
            }
        }

        ///< Sub shape ID that identifies the face on shape 1
        public unsafe JPH.Const_SubShapeID mSubShapeID1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_Get_mSubShapeID1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_Get_mSubShapeID1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_SubShapeID._Underlying *__JPH_CollideShapeResult_Get_mSubShapeID1(_Underlying *_this);
                JPH.Const_SubShapeID __ret;
                __ret = new(__JPH_CollideShapeResult_Get_mSubShapeID1(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_Get_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_Get_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_SubShapeID._Underlying *__JPH_CollideShapeResult_Get_mSubShapeID2(_Underlying *_this);
                JPH.Const_SubShapeID __ret;
                __ret = new(__JPH_CollideShapeResult_Get_mSubShapeID2(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_Get_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_Get_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_CollideShapeResult_Get_mBodyID2(_Underlying *_this);
                return ref *__JPH_CollideShapeResult_Get_mBodyID2(_UnderlyingPtr);
            }
        }

        internal unsafe Const_CollideShapeResult(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_CollideShapeResult() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideShapeResult._Underlying *__JPH_CollideShapeResult_DefaultConstruct();
            _UnderlyingPtr = __JPH_CollideShapeResult_DefaultConstruct();
        }

        /// Generated from constructor `JPH::CollideShapeResult::CollideShapeResult`.
        public unsafe Const_CollideShapeResult(JPH._ByValue_CollideShapeResult _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideShapeResult._Underlying *__JPH_CollideShapeResult_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.CollideShapeResult._Underlying *_other);
            _UnderlyingPtr = __JPH_CollideShapeResult_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::CollideShapeResult::CollideShapeResult`.
        public Const_CollideShapeResult(Const_CollideShapeResult _other) : this(new _ByValue_CollideShapeResult(_other)) {}

        /// Generated from constructor `JPH::CollideShapeResult::CollideShapeResult`.
        public Const_CollideShapeResult(CollideShapeResult _other) : this((Const_CollideShapeResult)_other) {}

        /// Constructor
        /// Generated from constructor `JPH::CollideShapeResult::CollideShapeResult`.
        public unsafe Const_CollideShapeResult(JPH.Const_Vec3 inContactPointOn1, JPH.Const_Vec3 inContactPointOn2, JPH.Const_Vec3 inPenetrationAxis, float inPenetrationDepth, JPH.Const_SubShapeID inSubShapeID1, JPH.Const_SubShapeID inSubShapeID2, in JPH.BodyID inBodyID2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideShapeResult._Underlying *__JPH_CollideShapeResult_Construct(JPH.Vec3._Underlying *inContactPointOn1, JPH.Vec3._Underlying *inContactPointOn2, JPH.Vec3._Underlying *inPenetrationAxis, float inPenetrationDepth, JPH.Const_SubShapeID._Underlying *inSubShapeID1, JPH.Const_SubShapeID._Underlying *inSubShapeID2, JPH.BodyID *inBodyID2);
            fixed (JPH.BodyID *__ptr_inBodyID2 = &inBodyID2)
            {
                _UnderlyingPtr = __JPH_CollideShapeResult_Construct(inContactPointOn1._UnderlyingPtr, inContactPointOn2._UnderlyingPtr, inPenetrationAxis._UnderlyingPtr, inPenetrationDepth, inSubShapeID1._UnderlyingPtr, inSubShapeID2._UnderlyingPtr, __ptr_inBodyID2);
            }
        }

        /// Generated from method `JPH::CollideShapeResult::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CollideShapeResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CollideShapeResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CollideShapeResult_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_CollideShapeResult_size_t(inCount);
        }

        /// Generated from method `JPH::CollideShapeResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollideShapeResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollideShapeResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollideShapeResult_void_ptr(void *inPointer);
            __Jolt_delete_JPH_CollideShapeResult_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CollideShapeResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollideShapeResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollideShapeResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollideShapeResult_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_CollideShapeResult_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CollideShapeResult::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CollideShapeResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CollideShapeResult_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CollideShapeResult_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_CollideShapeResult_size_t(inCount);
        }

        /// Generated from method `JPH::CollideShapeResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideShapeResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideShapeResult_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollideShapeResult_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_CollideShapeResult_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CollideShapeResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideShapeResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideShapeResult_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollideShapeResult_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_CollideShapeResult_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CollideShapeResult::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CollideShapeResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CollideShapeResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CollideShapeResult_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_CollideShapeResult_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CollideShapeResult::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollideShapeResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollideShapeResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollideShapeResult_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_CollideShapeResult_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::CollideShapeResult::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CollideShapeResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CollideShapeResult_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CollideShapeResult_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_CollideShapeResult_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CollideShapeResult::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideShapeResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideShapeResult_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollideShapeResult_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_CollideShapeResult_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Function required by the CollisionCollector. A smaller fraction is considered to be a 'better hit'. We use -penetration depth to get the hit with the biggest penetration depth
        /// Generated from method `JPH::CollideShapeResult::GetEarlyOutFraction`.
        public unsafe float GetEarlyOutFraction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_GetEarlyOutFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_GetEarlyOutFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_CollideShapeResult_GetEarlyOutFraction(_Underlying *_this);
            return __JPH_CollideShapeResult_GetEarlyOutFraction(_UnderlyingPtr);
        }

        /// Reverses the hit result, swapping contact point 1 with contact point 2 etc.
        /// Generated from method `JPH::CollideShapeResult::Reversed`.
        public unsafe JPH.CollideShapeResult Reversed()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_Reversed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_Reversed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideShapeResult._Underlying *__JPH_CollideShapeResult_Reversed(_Underlying *_this);
            return new(__JPH_CollideShapeResult_Reversed(_UnderlyingPtr), is_owning: true);
        }
    }

    /// Class that contains all information of two colliding shapes
    /// Generated from class `JPH::CollideShapeResult`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::ShapeCastResult`
    /// This is the non-const half of the class.
    public class CollideShapeResult : Const_CollideShapeResult
    {
        ///< Contact point on the surface of shape 1 (in world space or relative to base offset)
        public new unsafe JPH.Vec3 mContactPointOn1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_GetMutable_mContactPointOn1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_GetMutable_mContactPointOn1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_CollideShapeResult_GetMutable_mContactPointOn1(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_CollideShapeResult_GetMutable_mContactPointOn1(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_GetMutable_mContactPointOn2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_GetMutable_mContactPointOn2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_CollideShapeResult_GetMutable_mContactPointOn2(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_CollideShapeResult_GetMutable_mContactPointOn2(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_GetMutable_mPenetrationAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_GetMutable_mPenetrationAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_CollideShapeResult_GetMutable_mPenetrationAxis(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_CollideShapeResult_GetMutable_mPenetrationAxis(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_GetMutable_mPenetrationDepth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_GetMutable_mPenetrationDepth", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CollideShapeResult_GetMutable_mPenetrationDepth(_Underlying *_this);
                return ref *__JPH_CollideShapeResult_GetMutable_mPenetrationDepth(_UnderlyingPtr);
            }
        }

        ///< Sub shape ID that identifies the face on shape 1
        public new unsafe JPH.SubShapeID mSubShapeID1
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_GetMutable_mSubShapeID1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_GetMutable_mSubShapeID1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SubShapeID._Underlying *__JPH_CollideShapeResult_GetMutable_mSubShapeID1(_Underlying *_this);
                JPH.SubShapeID __ret;
                __ret = new(__JPH_CollideShapeResult_GetMutable_mSubShapeID1(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_GetMutable_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_GetMutable_mSubShapeID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SubShapeID._Underlying *__JPH_CollideShapeResult_GetMutable_mSubShapeID2(_Underlying *_this);
                JPH.SubShapeID __ret;
                __ret = new(__JPH_CollideShapeResult_GetMutable_mSubShapeID2(_UnderlyingPtr), is_owning: false);
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
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_GetMutable_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_GetMutable_mBodyID2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__JPH_CollideShapeResult_GetMutable_mBodyID2(_Underlying *_this);
                return ref *__JPH_CollideShapeResult_GetMutable_mBodyID2(_UnderlyingPtr);
            }
        }

        internal unsafe CollideShapeResult(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe CollideShapeResult() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideShapeResult._Underlying *__JPH_CollideShapeResult_DefaultConstruct();
            _UnderlyingPtr = __JPH_CollideShapeResult_DefaultConstruct();
        }

        /// Generated from constructor `JPH::CollideShapeResult::CollideShapeResult`.
        public unsafe CollideShapeResult(JPH._ByValue_CollideShapeResult _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideShapeResult._Underlying *__JPH_CollideShapeResult_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.CollideShapeResult._Underlying *_other);
            _UnderlyingPtr = __JPH_CollideShapeResult_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::CollideShapeResult::CollideShapeResult`.
        public CollideShapeResult(Const_CollideShapeResult _other) : this(new _ByValue_CollideShapeResult(_other)) {}

        /// Generated from constructor `JPH::CollideShapeResult::CollideShapeResult`.
        public CollideShapeResult(CollideShapeResult _other) : this((Const_CollideShapeResult)_other) {}

        /// Constructor
        /// Generated from constructor `JPH::CollideShapeResult::CollideShapeResult`.
        public unsafe CollideShapeResult(JPH.Const_Vec3 inContactPointOn1, JPH.Const_Vec3 inContactPointOn2, JPH.Const_Vec3 inPenetrationAxis, float inPenetrationDepth, JPH.Const_SubShapeID inSubShapeID1, JPH.Const_SubShapeID inSubShapeID2, in JPH.BodyID inBodyID2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideShapeResult._Underlying *__JPH_CollideShapeResult_Construct(JPH.Vec3._Underlying *inContactPointOn1, JPH.Vec3._Underlying *inContactPointOn2, JPH.Vec3._Underlying *inPenetrationAxis, float inPenetrationDepth, JPH.Const_SubShapeID._Underlying *inSubShapeID1, JPH.Const_SubShapeID._Underlying *inSubShapeID2, JPH.BodyID *inBodyID2);
            fixed (JPH.BodyID *__ptr_inBodyID2 = &inBodyID2)
            {
                _UnderlyingPtr = __JPH_CollideShapeResult_Construct(inContactPointOn1._UnderlyingPtr, inContactPointOn2._UnderlyingPtr, inPenetrationAxis._UnderlyingPtr, inPenetrationDepth, inSubShapeID1._UnderlyingPtr, inSubShapeID2._UnderlyingPtr, __ptr_inBodyID2);
            }
        }

        /// Generated from method `JPH::CollideShapeResult::operator=`.
        public unsafe JPH.CollideShapeResult Assign(JPH._ByValue_CollideShapeResult _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeResult_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeResult_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideShapeResult._Underlying *__JPH_CollideShapeResult_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.CollideShapeResult._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_CollideShapeResult_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }
    }

    /// This is used as a function parameter when the underlying function receives `CollideShapeResult` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `CollideShapeResult`/`Const_CollideShapeResult` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_CollideShapeResult
    {
        #pragma warning disable CS0649
        internal readonly Const_CollideShapeResult? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_CollideShapeResult() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_CollideShapeResult(Const_CollideShapeResult new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_CollideShapeResult(Const_CollideShapeResult arg) {return new(arg);}
        public _ByValue_CollideShapeResult(JPH._Moved<CollideShapeResult> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_CollideShapeResult(JPH._Moved<CollideShapeResult> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `CollideShapeResult` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_CollideShapeResult`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CollideShapeResult`/`Const_CollideShapeResult` directly.
    public class _InOptMut_CollideShapeResult
    {
        public CollideShapeResult? Opt;

        public _InOptMut_CollideShapeResult() {}
        public _InOptMut_CollideShapeResult(CollideShapeResult value) {Opt = value;}
        public static implicit operator _InOptMut_CollideShapeResult(CollideShapeResult value) {return new(value);}
    }

    /// This is used for optional parameters of class `CollideShapeResult` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_CollideShapeResult`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CollideShapeResult`/`Const_CollideShapeResult` to pass it to the function.
    public class _InOptConst_CollideShapeResult
    {
        public Const_CollideShapeResult? Opt;

        public _InOptConst_CollideShapeResult() {}
        public _InOptConst_CollideShapeResult(Const_CollideShapeResult value) {Opt = value;}
        public static implicit operator _InOptConst_CollideShapeResult(Const_CollideShapeResult value) {return new(value);}
    }

    /// Settings to be passed with a collision query
    /// Generated from class `JPH::CollideSettingsBase`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CollideShapeSettings`
    ///     `JPH::ShapeCastSettings`
    /// This is the const half of the class.
    public class Const_CollideSettingsBase : JPH.Object<Const_CollideSettingsBase>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CollideSettingsBase_Destroy(_Underlying *_this);
            __JPH_CollideSettingsBase_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_CollideSettingsBase() {Dispose(false);}

        /// How active edges (edges that a moving object should bump into) are handled
        public unsafe JPH.EActiveEdgeMode mActiveEdgeMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_Get_mActiveEdgeMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_Get_mActiveEdgeMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EActiveEdgeMode *__JPH_CollideSettingsBase_Get_mActiveEdgeMode(_Underlying *_this);
                return *__JPH_CollideSettingsBase_Get_mActiveEdgeMode(_UnderlyingPtr);
            }
        }

        /// If colliding faces should be collected or only the collision point
        public unsafe JPH.ECollectFacesMode mCollectFacesMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_Get_mCollectFacesMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_Get_mCollectFacesMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ECollectFacesMode *__JPH_CollideSettingsBase_Get_mCollectFacesMode(_Underlying *_this);
                return *__JPH_CollideSettingsBase_Get_mCollectFacesMode(_UnderlyingPtr);
            }
        }

        /// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
        public unsafe float mCollisionTolerance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_Get_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_Get_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CollideSettingsBase_Get_mCollisionTolerance(_Underlying *_this);
                return *__JPH_CollideSettingsBase_Get_mCollisionTolerance(_UnderlyingPtr);
            }
        }

        /// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
        public unsafe float mPenetrationTolerance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_Get_mPenetrationTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_Get_mPenetrationTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CollideSettingsBase_Get_mPenetrationTolerance(_Underlying *_this);
                return *__JPH_CollideSettingsBase_Get_mPenetrationTolerance(_UnderlyingPtr);
            }
        }

        /// When mActiveEdgeMode is CollideOnlyWithActive a movement direction can be provided. When hitting an inactive edge, the system will select the triangle normal as penetration depth only if it impedes the movement less than with the calculated penetration depth.
        public unsafe JPH.Const_Vec3 mActiveEdgeMovementDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_Get_mActiveEdgeMovementDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_Get_mActiveEdgeMovementDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_CollideSettingsBase_Get_mActiveEdgeMovementDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_CollideSettingsBase_Get_mActiveEdgeMovementDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_CollideSettingsBase(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_CollideSettingsBase() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideSettingsBase._Underlying *__JPH_CollideSettingsBase_DefaultConstruct();
            _UnderlyingPtr = __JPH_CollideSettingsBase_DefaultConstruct();
        }

        /// Constructs `JPH::CollideSettingsBase` elementwise.
        public unsafe Const_CollideSettingsBase(JPH.EActiveEdgeMode mActiveEdgeMode, JPH.ECollectFacesMode mCollectFacesMode, float mCollisionTolerance, float mPenetrationTolerance, JPH.Const_Vec3 mActiveEdgeMovementDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideSettingsBase._Underlying *__JPH_CollideSettingsBase_ConstructFrom(JPH.EActiveEdgeMode mActiveEdgeMode, JPH.ECollectFacesMode mCollectFacesMode, float mCollisionTolerance, float mPenetrationTolerance, JPH.Vec3._Underlying *mActiveEdgeMovementDirection);
            _UnderlyingPtr = __JPH_CollideSettingsBase_ConstructFrom(mActiveEdgeMode, mCollectFacesMode, mCollisionTolerance, mPenetrationTolerance, mActiveEdgeMovementDirection._UnderlyingPtr);
            _KeepAlive(mActiveEdgeMovementDirection);
        }

        /// Generated from constructor `JPH::CollideSettingsBase::CollideSettingsBase`.
        public unsafe Const_CollideSettingsBase(JPH.Const_CollideSettingsBase _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideSettingsBase._Underlying *__JPH_CollideSettingsBase_ConstructFromAnother(JPH.CollideSettingsBase._Underlying *_other);
            _UnderlyingPtr = __JPH_CollideSettingsBase_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::CollideSettingsBase::CollideSettingsBase`.
        public Const_CollideSettingsBase(CollideSettingsBase _other) : this((Const_CollideSettingsBase)_other) {}

        /// Generated from method `JPH::CollideSettingsBase::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CollideSettingsBase_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CollideSettingsBase_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CollideSettingsBase_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_CollideSettingsBase_size_t(inCount);
        }

        /// Generated from method `JPH::CollideSettingsBase::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollideSettingsBase_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollideSettingsBase_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollideSettingsBase_void_ptr(void *inPointer);
            __Jolt_delete_JPH_CollideSettingsBase_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CollideSettingsBase::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollideSettingsBase_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollideSettingsBase_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollideSettingsBase_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_CollideSettingsBase_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CollideSettingsBase::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CollideSettingsBase_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CollideSettingsBase_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CollideSettingsBase_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_CollideSettingsBase_size_t(inCount);
        }

        /// Generated from method `JPH::CollideSettingsBase::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideSettingsBase_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideSettingsBase_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollideSettingsBase_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_CollideSettingsBase_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CollideSettingsBase::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideSettingsBase_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideSettingsBase_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollideSettingsBase_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_CollideSettingsBase_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CollideSettingsBase::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CollideSettingsBase_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CollideSettingsBase_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CollideSettingsBase_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_CollideSettingsBase_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CollideSettingsBase::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollideSettingsBase_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollideSettingsBase_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollideSettingsBase_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_CollideSettingsBase_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::CollideSettingsBase::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CollideSettingsBase_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CollideSettingsBase_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CollideSettingsBase_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_CollideSettingsBase_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CollideSettingsBase::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideSettingsBase_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideSettingsBase_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollideSettingsBase_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_CollideSettingsBase_void_ptr_void_ptr(inPointer, inPlace);
        }
    }

    /// Settings to be passed with a collision query
    /// Generated from class `JPH::CollideSettingsBase`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CollideShapeSettings`
    ///     `JPH::ShapeCastSettings`
    /// This is the non-const half of the class.
    public class CollideSettingsBase : Const_CollideSettingsBase
    {
        /// How active edges (edges that a moving object should bump into) are handled
        public new unsafe ref JPH.EActiveEdgeMode mActiveEdgeMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_GetMutable_mActiveEdgeMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_GetMutable_mActiveEdgeMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EActiveEdgeMode *__JPH_CollideSettingsBase_GetMutable_mActiveEdgeMode(_Underlying *_this);
                return ref *__JPH_CollideSettingsBase_GetMutable_mActiveEdgeMode(_UnderlyingPtr);
            }
        }

        /// If colliding faces should be collected or only the collision point
        public new unsafe ref JPH.ECollectFacesMode mCollectFacesMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_GetMutable_mCollectFacesMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_GetMutable_mCollectFacesMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ECollectFacesMode *__JPH_CollideSettingsBase_GetMutable_mCollectFacesMode(_Underlying *_this);
                return ref *__JPH_CollideSettingsBase_GetMutable_mCollectFacesMode(_UnderlyingPtr);
            }
        }

        /// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
        public new unsafe ref float mCollisionTolerance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_GetMutable_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_GetMutable_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CollideSettingsBase_GetMutable_mCollisionTolerance(_Underlying *_this);
                return ref *__JPH_CollideSettingsBase_GetMutable_mCollisionTolerance(_UnderlyingPtr);
            }
        }

        /// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
        public new unsafe ref float mPenetrationTolerance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_GetMutable_mPenetrationTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_GetMutable_mPenetrationTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CollideSettingsBase_GetMutable_mPenetrationTolerance(_Underlying *_this);
                return ref *__JPH_CollideSettingsBase_GetMutable_mPenetrationTolerance(_UnderlyingPtr);
            }
        }

        /// When mActiveEdgeMode is CollideOnlyWithActive a movement direction can be provided. When hitting an inactive edge, the system will select the triangle normal as penetration depth only if it impedes the movement less than with the calculated penetration depth.
        public new unsafe JPH.Vec3 mActiveEdgeMovementDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_GetMutable_mActiveEdgeMovementDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_GetMutable_mActiveEdgeMovementDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_CollideSettingsBase_GetMutable_mActiveEdgeMovementDirection(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_CollideSettingsBase_GetMutable_mActiveEdgeMovementDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe CollideSettingsBase(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe CollideSettingsBase() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideSettingsBase._Underlying *__JPH_CollideSettingsBase_DefaultConstruct();
            _UnderlyingPtr = __JPH_CollideSettingsBase_DefaultConstruct();
        }

        /// Constructs `JPH::CollideSettingsBase` elementwise.
        public unsafe CollideSettingsBase(JPH.EActiveEdgeMode mActiveEdgeMode, JPH.ECollectFacesMode mCollectFacesMode, float mCollisionTolerance, float mPenetrationTolerance, JPH.Const_Vec3 mActiveEdgeMovementDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideSettingsBase._Underlying *__JPH_CollideSettingsBase_ConstructFrom(JPH.EActiveEdgeMode mActiveEdgeMode, JPH.ECollectFacesMode mCollectFacesMode, float mCollisionTolerance, float mPenetrationTolerance, JPH.Vec3._Underlying *mActiveEdgeMovementDirection);
            _UnderlyingPtr = __JPH_CollideSettingsBase_ConstructFrom(mActiveEdgeMode, mCollectFacesMode, mCollisionTolerance, mPenetrationTolerance, mActiveEdgeMovementDirection._UnderlyingPtr);
            _KeepAlive(mActiveEdgeMovementDirection);
        }

        /// Generated from constructor `JPH::CollideSettingsBase::CollideSettingsBase`.
        public unsafe CollideSettingsBase(JPH.Const_CollideSettingsBase _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideSettingsBase._Underlying *__JPH_CollideSettingsBase_ConstructFromAnother(JPH.CollideSettingsBase._Underlying *_other);
            _UnderlyingPtr = __JPH_CollideSettingsBase_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::CollideSettingsBase::CollideSettingsBase`.
        public CollideSettingsBase(CollideSettingsBase _other) : this((Const_CollideSettingsBase)_other) {}

        /// Generated from method `JPH::CollideSettingsBase::operator=`.
        public unsafe JPH.CollideSettingsBase Assign(JPH.Const_CollideSettingsBase _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideSettingsBase_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideSettingsBase_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideSettingsBase._Underlying *__JPH_CollideSettingsBase_AssignFromAnother(_Underlying *_this, JPH.CollideSettingsBase._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_CollideSettingsBase_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `CollideSettingsBase` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_CollideSettingsBase`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CollideSettingsBase`/`Const_CollideSettingsBase` directly.
    public class _InOptMut_CollideSettingsBase
    {
        public CollideSettingsBase? Opt;

        public _InOptMut_CollideSettingsBase() {}
        public _InOptMut_CollideSettingsBase(CollideSettingsBase value) {Opt = value;}
        public static implicit operator _InOptMut_CollideSettingsBase(CollideSettingsBase value) {return new(value);}
    }

    /// This is used for optional parameters of class `CollideSettingsBase` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_CollideSettingsBase`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CollideSettingsBase`/`Const_CollideSettingsBase` to pass it to the function.
    public class _InOptConst_CollideSettingsBase
    {
        public Const_CollideSettingsBase? Opt;

        public _InOptConst_CollideSettingsBase() {}
        public _InOptConst_CollideSettingsBase(Const_CollideSettingsBase value) {Opt = value;}
        public static implicit operator _InOptConst_CollideSettingsBase(Const_CollideSettingsBase value) {return new(value);}
    }

    /// Settings to be passed with a collision query
    /// Generated from class `JPH::CollideShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CollideSettingsBase`
    /// This is the const half of the class.
    public class Const_CollideShapeSettings : JPH.Object<Const_CollideShapeSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_CollideShapeSettings_Destroy(_Underlying *_this);
            __JPH_CollideShapeSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_CollideShapeSettings() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_CollideSettingsBase(Const_CollideShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_UpcastTo_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_UpcastTo_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_CollideSettingsBase._Underlying *__JPH_CollideShapeSettings_UpcastTo_JPH_CollideSettingsBase(_Underlying *_this);
            JPH.Const_CollideSettingsBase ret = new(__JPH_CollideShapeSettings_UpcastTo_JPH_CollideSettingsBase(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_CollideShapeSettings(JPH.Const_CollideSettingsBase parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_StaticDowncastFrom_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_StaticDowncastFrom_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CollideShapeSettings_StaticDowncastFrom_JPH_CollideSettingsBase(JPH.Const_CollideSettingsBase._Underlying *_this);
            Const_CollideShapeSettings ret = new(__JPH_CollideShapeSettings_StaticDowncastFrom_JPH_CollideSettingsBase(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// When > 0 contacts in the vicinity of the query shape can be found. All nearest contacts that are not further away than this distance will be found.
        /// Note that in this case CollideShapeResult::mPenetrationDepth can become negative to indicate that objects are not overlapping. (unit: meter)
        public unsafe float mMaxSeparationDistance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_Get_mMaxSeparationDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_Get_mMaxSeparationDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CollideShapeSettings_Get_mMaxSeparationDistance(_Underlying *_this);
                return *__JPH_CollideShapeSettings_Get_mMaxSeparationDistance(_UnderlyingPtr);
            }
        }

        /// How backfacing triangles should be treated
        public unsafe JPH.EBackFaceMode mBackFaceMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_Get_mBackFaceMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_Get_mBackFaceMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EBackFaceMode *__JPH_CollideShapeSettings_Get_mBackFaceMode(_Underlying *_this);
                return *__JPH_CollideShapeSettings_Get_mBackFaceMode(_UnderlyingPtr);
            }
        }

        /// How active edges (edges that a moving object should bump into) are handled
        public unsafe JPH.EActiveEdgeMode mActiveEdgeMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_Get_mActiveEdgeMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_Get_mActiveEdgeMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EActiveEdgeMode *__JPH_CollideShapeSettings_Get_mActiveEdgeMode(_Underlying *_this);
                return *__JPH_CollideShapeSettings_Get_mActiveEdgeMode(_UnderlyingPtr);
            }
        }

        /// If colliding faces should be collected or only the collision point
        public unsafe JPH.ECollectFacesMode mCollectFacesMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_Get_mCollectFacesMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_Get_mCollectFacesMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ECollectFacesMode *__JPH_CollideShapeSettings_Get_mCollectFacesMode(_Underlying *_this);
                return *__JPH_CollideShapeSettings_Get_mCollectFacesMode(_UnderlyingPtr);
            }
        }

        /// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
        public unsafe float mCollisionTolerance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_Get_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_Get_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CollideShapeSettings_Get_mCollisionTolerance(_Underlying *_this);
                return *__JPH_CollideShapeSettings_Get_mCollisionTolerance(_UnderlyingPtr);
            }
        }

        /// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
        public unsafe float mPenetrationTolerance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_Get_mPenetrationTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_Get_mPenetrationTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CollideShapeSettings_Get_mPenetrationTolerance(_Underlying *_this);
                return *__JPH_CollideShapeSettings_Get_mPenetrationTolerance(_UnderlyingPtr);
            }
        }

        /// When mActiveEdgeMode is CollideOnlyWithActive a movement direction can be provided. When hitting an inactive edge, the system will select the triangle normal as penetration depth only if it impedes the movement less than with the calculated penetration depth.
        public unsafe JPH.Const_Vec3 mActiveEdgeMovementDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_Get_mActiveEdgeMovementDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_Get_mActiveEdgeMovementDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_CollideShapeSettings_Get_mActiveEdgeMovementDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_CollideShapeSettings_Get_mActiveEdgeMovementDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_CollideShapeSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_CollideShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideShapeSettings._Underlying *__JPH_CollideShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_CollideShapeSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::CollideShapeSettings::CollideShapeSettings`.
        public unsafe Const_CollideShapeSettings(JPH.Const_CollideShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideShapeSettings._Underlying *__JPH_CollideShapeSettings_ConstructFromAnother(JPH.CollideShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_CollideShapeSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::CollideShapeSettings::CollideShapeSettings`.
        public Const_CollideShapeSettings(CollideShapeSettings _other) : this((Const_CollideShapeSettings)_other) {}

        /// Generated from method `JPH::CollideShapeSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CollideShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CollideShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CollideShapeSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_CollideShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::CollideShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollideShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollideShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollideShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_CollideShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CollideShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollideShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollideShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollideShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_CollideShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CollideShapeSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CollideShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CollideShapeSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CollideShapeSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_CollideShapeSettings_size_t(inCount);
        }

        /// Generated from method `JPH::CollideShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideShapeSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollideShapeSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_CollideShapeSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::CollideShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideShapeSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollideShapeSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_CollideShapeSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::CollideShapeSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_CollideShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_CollideShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_CollideShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_CollideShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CollideShapeSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_CollideShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_CollideShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_CollideShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_CollideShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::CollideShapeSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_CollideShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_CollideShapeSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_CollideShapeSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_CollideShapeSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::CollideShapeSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_CollideShapeSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_CollideShapeSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_CollideShapeSettings_void_ptr_void_ptr(inPointer, inPlace);
        }
    }

    /// Settings to be passed with a collision query
    /// Generated from class `JPH::CollideShapeSettings`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::CollideSettingsBase`
    /// This is the non-const half of the class.
    public class CollideShapeSettings : Const_CollideShapeSettings
    {
        // Upcasts:
        public static unsafe implicit operator JPH.CollideSettingsBase(CollideShapeSettings self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_UpcastTo_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_UpcastTo_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideSettingsBase._Underlying *__JPH_CollideShapeSettings_UpcastTo_JPH_CollideSettingsBase(_Underlying *_this);
            JPH.CollideSettingsBase ret = new(__JPH_CollideShapeSettings_UpcastTo_JPH_CollideSettingsBase(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator CollideShapeSettings(JPH.CollideSettingsBase parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_StaticDowncastFrom_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_StaticDowncastFrom_JPH_CollideSettingsBase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_CollideShapeSettings_StaticDowncastFrom_JPH_CollideSettingsBase(JPH.CollideSettingsBase._Underlying *_this);
            CollideShapeSettings ret = new(__JPH_CollideShapeSettings_StaticDowncastFrom_JPH_CollideSettingsBase(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// When > 0 contacts in the vicinity of the query shape can be found. All nearest contacts that are not further away than this distance will be found.
        /// Note that in this case CollideShapeResult::mPenetrationDepth can become negative to indicate that objects are not overlapping. (unit: meter)
        public new unsafe ref float mMaxSeparationDistance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_GetMutable_mMaxSeparationDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_GetMutable_mMaxSeparationDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CollideShapeSettings_GetMutable_mMaxSeparationDistance(_Underlying *_this);
                return ref *__JPH_CollideShapeSettings_GetMutable_mMaxSeparationDistance(_UnderlyingPtr);
            }
        }

        /// How backfacing triangles should be treated
        public new unsafe ref JPH.EBackFaceMode mBackFaceMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_GetMutable_mBackFaceMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_GetMutable_mBackFaceMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EBackFaceMode *__JPH_CollideShapeSettings_GetMutable_mBackFaceMode(_Underlying *_this);
                return ref *__JPH_CollideShapeSettings_GetMutable_mBackFaceMode(_UnderlyingPtr);
            }
        }

        /// How active edges (edges that a moving object should bump into) are handled
        public new unsafe ref JPH.EActiveEdgeMode mActiveEdgeMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_GetMutable_mActiveEdgeMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_GetMutable_mActiveEdgeMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EActiveEdgeMode *__JPH_CollideShapeSettings_GetMutable_mActiveEdgeMode(_Underlying *_this);
                return ref *__JPH_CollideShapeSettings_GetMutable_mActiveEdgeMode(_UnderlyingPtr);
            }
        }

        /// If colliding faces should be collected or only the collision point
        public new unsafe ref JPH.ECollectFacesMode mCollectFacesMode
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_GetMutable_mCollectFacesMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_GetMutable_mCollectFacesMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.ECollectFacesMode *__JPH_CollideShapeSettings_GetMutable_mCollectFacesMode(_Underlying *_this);
                return ref *__JPH_CollideShapeSettings_GetMutable_mCollectFacesMode(_UnderlyingPtr);
            }
        }

        /// If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter)
        public new unsafe ref float mCollisionTolerance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_GetMutable_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_GetMutable_mCollisionTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CollideShapeSettings_GetMutable_mCollisionTolerance(_Underlying *_this);
                return ref *__JPH_CollideShapeSettings_GetMutable_mCollisionTolerance(_UnderlyingPtr);
            }
        }

        /// A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless)
        public new unsafe ref float mPenetrationTolerance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_GetMutable_mPenetrationTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_GetMutable_mPenetrationTolerance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static float *__JPH_CollideShapeSettings_GetMutable_mPenetrationTolerance(_Underlying *_this);
                return ref *__JPH_CollideShapeSettings_GetMutable_mPenetrationTolerance(_UnderlyingPtr);
            }
        }

        /// When mActiveEdgeMode is CollideOnlyWithActive a movement direction can be provided. When hitting an inactive edge, the system will select the triangle normal as penetration depth only if it impedes the movement less than with the calculated penetration depth.
        public new unsafe JPH.Vec3 mActiveEdgeMovementDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_GetMutable_mActiveEdgeMovementDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_GetMutable_mActiveEdgeMovementDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_CollideShapeSettings_GetMutable_mActiveEdgeMovementDirection(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_CollideShapeSettings_GetMutable_mActiveEdgeMovementDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe CollideShapeSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe CollideShapeSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideShapeSettings._Underlying *__JPH_CollideShapeSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_CollideShapeSettings_DefaultConstruct();
        }

        /// Generated from constructor `JPH::CollideShapeSettings::CollideShapeSettings`.
        public unsafe CollideShapeSettings(JPH.Const_CollideShapeSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideShapeSettings._Underlying *__JPH_CollideShapeSettings_ConstructFromAnother(JPH.CollideShapeSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_CollideShapeSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::CollideShapeSettings::CollideShapeSettings`.
        public CollideShapeSettings(CollideShapeSettings _other) : this((Const_CollideShapeSettings)_other) {}

        /// Generated from method `JPH::CollideShapeSettings::operator=`.
        public unsafe JPH.CollideShapeSettings Assign(JPH.Const_CollideShapeSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_CollideShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_CollideShapeSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.CollideShapeSettings._Underlying *__JPH_CollideShapeSettings_AssignFromAnother(_Underlying *_this, JPH.CollideShapeSettings._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_CollideShapeSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `CollideShapeSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_CollideShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CollideShapeSettings`/`Const_CollideShapeSettings` directly.
    public class _InOptMut_CollideShapeSettings
    {
        public CollideShapeSettings? Opt;

        public _InOptMut_CollideShapeSettings() {}
        public _InOptMut_CollideShapeSettings(CollideShapeSettings value) {Opt = value;}
        public static implicit operator _InOptMut_CollideShapeSettings(CollideShapeSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `CollideShapeSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_CollideShapeSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `CollideShapeSettings`/`Const_CollideShapeSettings` to pass it to the function.
    public class _InOptConst_CollideShapeSettings
    {
        public Const_CollideShapeSettings? Opt;

        public _InOptConst_CollideShapeSettings() {}
        public _InOptConst_CollideShapeSettings(Const_CollideShapeSettings value) {Opt = value;}
        public static implicit operator _InOptConst_CollideShapeSettings(Const_CollideShapeSettings value) {return new(value);}
    }
}
