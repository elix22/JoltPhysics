// machine generated, do not edit
public static partial class JPH
{
    /// Structure that holds a single ray cast
    /// Generated from class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RayCast`
    /// This is the const half of the class.
    public class Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast : JPH.Object<Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Destroy(_Underlying *_this);
            __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast() {Dispose(false);}

        ///< Origin of the ray
        public unsafe JPH.Const_Vec3 mOrigin
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Get_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Get_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Get_mOrigin(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Get_mOrigin(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
        public unsafe JPH.Const_Vec3 mDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Get_mDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Get_mDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DefaultConstruct();
            _UnderlyingPtr = __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::RayCastT`.
        public unsafe Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast(JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_ConstructFromAnother(JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast._Underlying *_other);
            _UnderlyingPtr = __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::RayCastT`.
        public Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast(RayCastT_JPHVec3_JPHMat44_JPHRayCast _other) : this((Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast)_other) {}

        /// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::RayCastT`.
        public unsafe Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast(JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Construct(JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Construct(inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t(inCount);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr(void *inPointer);
            __Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr(inPointer);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t(inCount);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr(inPointer);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Transform this ray using inTransform
        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::Transformed`.
        public unsafe JPH.RayCast Transformed(JPH.Const_Mat44 inTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Transformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Transformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Transformed(_Underlying *_this, JPH.Const_Mat44._Underlying *inTransform);
            return new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Transformed(_UnderlyingPtr, inTransform._UnderlyingPtr), is_owning: true);
        }

        /// Translate ray using inTranslation
        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::Translated`.
        public unsafe JPH.RayCast Translated(JPH.Const_Vec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Translated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Translated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Translated(_Underlying *_this, JPH.Vec3._Underlying *inTranslation);
            return new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Translated(_UnderlyingPtr, inTranslation._UnderlyingPtr), is_owning: true);
        }

        /// Get point with fraction inFraction on ray (0 = start of ray, 1 = end of ray)
        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::GetPointOnRay`.
        public unsafe JPH.Vec3 GetPointOnRay(float inFraction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetPointOnRay(_Underlying *_this, float inFraction);
            return new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetPointOnRay(_UnderlyingPtr, inFraction), is_owning: true);
        }
    }

    /// Structure that holds a single ray cast
    /// Generated from class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RayCast`
    /// This is the non-const half of the class.
    public class RayCastT_JPHVec3_JPHMat44_JPHRayCast : Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast
    {
        ///< Origin of the ray
        public new unsafe JPH.Vec3 mOrigin
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetMutable_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetMutable_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetMutable_mOrigin(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetMutable_mOrigin(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
        public new unsafe JPH.Vec3 mDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetMutable_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetMutable_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetMutable_mDirection(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_GetMutable_mDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe RayCastT_JPHVec3_JPHMat44_JPHRayCast(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RayCastT_JPHVec3_JPHMat44_JPHRayCast() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DefaultConstruct();
            _UnderlyingPtr = __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::RayCastT`.
        public unsafe RayCastT_JPHVec3_JPHMat44_JPHRayCast(JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_ConstructFromAnother(JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast._Underlying *_other);
            _UnderlyingPtr = __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::RayCastT`.
        public RayCastT_JPHVec3_JPHMat44_JPHRayCast(RayCastT_JPHVec3_JPHMat44_JPHRayCast _other) : this((Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast)_other) {}

        /// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::RayCastT`.
        public unsafe RayCastT_JPHVec3_JPHMat44_JPHRayCast(JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Construct(JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_Construct(inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>::operator=`.
        public unsafe JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast Assign(JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_AssignFromAnother(_Underlying *_this, JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `RayCastT_JPHVec3_JPHMat44_JPHRayCast` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RayCastT_JPHVec3_JPHMat44_JPHRayCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RayCastT_JPHVec3_JPHMat44_JPHRayCast`/`Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast` directly.
    public class _InOptMut_RayCastT_JPHVec3_JPHMat44_JPHRayCast
    {
        public RayCastT_JPHVec3_JPHMat44_JPHRayCast? Opt;

        public _InOptMut_RayCastT_JPHVec3_JPHMat44_JPHRayCast() {}
        public _InOptMut_RayCastT_JPHVec3_JPHMat44_JPHRayCast(RayCastT_JPHVec3_JPHMat44_JPHRayCast value) {Opt = value;}
        public static implicit operator _InOptMut_RayCastT_JPHVec3_JPHMat44_JPHRayCast(RayCastT_JPHVec3_JPHMat44_JPHRayCast value) {return new(value);}
    }

    /// This is used for optional parameters of class `RayCastT_JPHVec3_JPHMat44_JPHRayCast` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RayCastT_JPHVec3_JPHMat44_JPHRayCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RayCastT_JPHVec3_JPHMat44_JPHRayCast`/`Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast` to pass it to the function.
    public class _InOptConst_RayCastT_JPHVec3_JPHMat44_JPHRayCast
    {
        public Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast? Opt;

        public _InOptConst_RayCastT_JPHVec3_JPHMat44_JPHRayCast() {}
        public _InOptConst_RayCastT_JPHVec3_JPHMat44_JPHRayCast(Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast value) {Opt = value;}
        public static implicit operator _InOptConst_RayCastT_JPHVec3_JPHMat44_JPHRayCast(Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast value) {return new(value);}
    }

    /// Structure that holds a single ray cast
    /// Generated from class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RRayCast`
    /// This is the const half of the class.
    public class Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast : JPH.Object<Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Destroy(_Underlying *_this);
            __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast() {Dispose(false);}

        ///< Origin of the ray
        public unsafe JPH.Const_Vec3 mOrigin
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Get_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Get_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Get_mOrigin(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Get_mOrigin(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
        public unsafe JPH.Const_Vec3 mDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Get_mDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Get_mDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DefaultConstruct();
            _UnderlyingPtr = __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::RayCastT`.
        public unsafe Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast(JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_ConstructFromAnother(JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast._Underlying *_other);
            _UnderlyingPtr = __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::RayCastT`.
        public Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast(RayCastT_JPHVec3_JPHMat44_JPHRRayCast _other) : this((Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast)_other) {}

        /// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::RayCastT`.
        public unsafe Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast(JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Construct(JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Construct(inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t(inCount);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr(void *inPointer);
            __Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr(inPointer);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t(inCount);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr(inPointer);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Transform this ray using inTransform
        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::Transformed`.
        public unsafe JPH.RRayCast Transformed(JPH.Const_Mat44 inTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Transformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Transformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Transformed(_Underlying *_this, JPH.Const_Mat44._Underlying *inTransform);
            return new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Transformed(_UnderlyingPtr, inTransform._UnderlyingPtr), is_owning: true);
        }

        /// Translate ray using inTranslation
        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::Translated`.
        public unsafe JPH.RRayCast Translated(JPH.Const_Vec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Translated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Translated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Translated(_Underlying *_this, JPH.Vec3._Underlying *inTranslation);
            return new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Translated(_UnderlyingPtr, inTranslation._UnderlyingPtr), is_owning: true);
        }

        /// Get point with fraction inFraction on ray (0 = start of ray, 1 = end of ray)
        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::GetPointOnRay`.
        public unsafe JPH.Vec3 GetPointOnRay(float inFraction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetPointOnRay(_Underlying *_this, float inFraction);
            return new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetPointOnRay(_UnderlyingPtr, inFraction), is_owning: true);
        }
    }

    /// Structure that holds a single ray cast
    /// Generated from class `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RRayCast`
    /// This is the non-const half of the class.
    public class RayCastT_JPHVec3_JPHMat44_JPHRRayCast : Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast
    {
        ///< Origin of the ray
        public new unsafe JPH.Vec3 mOrigin
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetMutable_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetMutable_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetMutable_mOrigin(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetMutable_mOrigin(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
        public new unsafe JPH.Vec3 mDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetMutable_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetMutable_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetMutable_mDirection(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_GetMutable_mDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe RayCastT_JPHVec3_JPHMat44_JPHRRayCast(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RayCastT_JPHVec3_JPHMat44_JPHRRayCast() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DefaultConstruct();
            _UnderlyingPtr = __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::RayCastT`.
        public unsafe RayCastT_JPHVec3_JPHMat44_JPHRRayCast(JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_ConstructFromAnother(JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast._Underlying *_other);
            _UnderlyingPtr = __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::RayCastT`.
        public RayCastT_JPHVec3_JPHMat44_JPHRRayCast(RayCastT_JPHVec3_JPHMat44_JPHRRayCast _other) : this((Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast)_other) {}

        /// Generated from constructor `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::RayCastT`.
        public unsafe RayCastT_JPHVec3_JPHMat44_JPHRRayCast(JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Construct(JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_Construct(inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr);
        }

        /// Generated from method `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>::operator=`.
        public unsafe JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast Assign(JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast._Underlying *__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_AssignFromAnother(_Underlying *_this, JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `RayCastT_JPHVec3_JPHMat44_JPHRRayCast` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RayCastT_JPHVec3_JPHMat44_JPHRRayCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RayCastT_JPHVec3_JPHMat44_JPHRRayCast`/`Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast` directly.
    public class _InOptMut_RayCastT_JPHVec3_JPHMat44_JPHRRayCast
    {
        public RayCastT_JPHVec3_JPHMat44_JPHRRayCast? Opt;

        public _InOptMut_RayCastT_JPHVec3_JPHMat44_JPHRRayCast() {}
        public _InOptMut_RayCastT_JPHVec3_JPHMat44_JPHRRayCast(RayCastT_JPHVec3_JPHMat44_JPHRRayCast value) {Opt = value;}
        public static implicit operator _InOptMut_RayCastT_JPHVec3_JPHMat44_JPHRRayCast(RayCastT_JPHVec3_JPHMat44_JPHRRayCast value) {return new(value);}
    }

    /// This is used for optional parameters of class `RayCastT_JPHVec3_JPHMat44_JPHRRayCast` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RayCastT_JPHVec3_JPHMat44_JPHRRayCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RayCastT_JPHVec3_JPHMat44_JPHRRayCast`/`Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast` to pass it to the function.
    public class _InOptConst_RayCastT_JPHVec3_JPHMat44_JPHRRayCast
    {
        public Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast? Opt;

        public _InOptConst_RayCastT_JPHVec3_JPHMat44_JPHRRayCast() {}
        public _InOptConst_RayCastT_JPHVec3_JPHMat44_JPHRRayCast(Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast value) {Opt = value;}
        public static implicit operator _InOptConst_RayCastT_JPHVec3_JPHMat44_JPHRRayCast(Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast value) {return new(value);}
    }

    /// Generated from class `JPH::RayCast`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>`
    /// This is the const half of the class.
    public class Const_RayCast : JPH.Object<Const_RayCast>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RayCast_Destroy(_Underlying *_this);
            __JPH_RayCast_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RayCast() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast(Const_RayCast self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast._Underlying *__JPH_RayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(_Underlying *_this);
            JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast ret = new(__JPH_RayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_RayCast(JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_RayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast._Underlying *_this);
            Const_RayCast ret = new(__JPH_RayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Origin of the ray
        public unsafe JPH.Const_Vec3 mOrigin
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_Get_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_Get_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_RayCast_Get_mOrigin(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_RayCast_Get_mOrigin(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
        public unsafe JPH.Const_Vec3 mDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_RayCast_Get_mDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_RayCast_Get_mDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_RayCast(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RayCast() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCast._Underlying *__JPH_RayCast_DefaultConstruct();
            _UnderlyingPtr = __JPH_RayCast_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RayCast::RayCast`.
        public unsafe Const_RayCast(JPH.Const_RayCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCast._Underlying *__JPH_RayCast_ConstructFromAnother(JPH.RayCast._Underlying *_other);
            _UnderlyingPtr = __JPH_RayCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RayCast::RayCast`.
        public Const_RayCast(RayCast _other) : this((Const_RayCast)_other) {}

        /// Generated from constructor `JPH::RayCast::RayCast`.
        public unsafe Const_RayCast(JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCast._Underlying *__JPH_RayCast_Construct(JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_RayCast_Construct(inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr);
        }

        /// Transform this ray using inTransform
        /// Generated from method `JPH::RayCast::Transformed`.
        public unsafe JPH.RayCast Transformed(JPH.Const_Mat44 inTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_Transformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_Transformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCast._Underlying *__JPH_RayCast_Transformed(_Underlying *_this, JPH.Const_Mat44._Underlying *inTransform);
            return new(__JPH_RayCast_Transformed(_UnderlyingPtr, inTransform._UnderlyingPtr), is_owning: true);
        }

        /// Translate ray using inTranslation
        /// Generated from method `JPH::RayCast::Translated`.
        public unsafe JPH.RayCast Translated(JPH.Const_Vec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_Translated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_Translated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCast._Underlying *__JPH_RayCast_Translated(_Underlying *_this, JPH.Vec3._Underlying *inTranslation);
            return new(__JPH_RayCast_Translated(_UnderlyingPtr, inTranslation._UnderlyingPtr), is_owning: true);
        }

        /// Get point with fraction inFraction on ray (0 = start of ray, 1 = end of ray)
        /// Generated from method `JPH::RayCast::GetPointOnRay`.
        public unsafe JPH.Vec3 GetPointOnRay(float inFraction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_RayCast_GetPointOnRay(_Underlying *_this, float inFraction);
            return new(__JPH_RayCast_GetPointOnRay(_UnderlyingPtr, inFraction), is_owning: true);
        }
    }

    /// Generated from class `JPH::RayCast`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RayCast>`
    /// This is the non-const half of the class.
    public class RayCast : Const_RayCast
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast(RayCast self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast._Underlying *__JPH_RayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(_Underlying *_this);
            JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast ret = new(__JPH_RayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast(RayCast self)
            => (JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRayCast)(JPH.Const_RayCast)self;

        // Downcasts:
        public static unsafe explicit operator RayCast(JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_RayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(JPH.RayCastT_JPHVec3_JPHMat44_JPHRayCast._Underlying *_this);
            RayCast ret = new(__JPH_RayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RayCast(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Origin of the ray
        public new unsafe JPH.Vec3 mOrigin
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_GetMutable_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_GetMutable_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_RayCast_GetMutable_mOrigin(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_RayCast_GetMutable_mOrigin(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
        public new unsafe JPH.Vec3 mDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_GetMutable_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_GetMutable_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_RayCast_GetMutable_mDirection(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_RayCast_GetMutable_mDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe RayCast(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RayCast() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCast._Underlying *__JPH_RayCast_DefaultConstruct();
            _UnderlyingPtr = __JPH_RayCast_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RayCast::RayCast`.
        public unsafe RayCast(JPH.Const_RayCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCast._Underlying *__JPH_RayCast_ConstructFromAnother(JPH.RayCast._Underlying *_other);
            _UnderlyingPtr = __JPH_RayCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RayCast::RayCast`.
        public RayCast(RayCast _other) : this((Const_RayCast)_other) {}

        /// Generated from constructor `JPH::RayCast::RayCast`.
        public unsafe RayCast(JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCast._Underlying *__JPH_RayCast_Construct(JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_RayCast_Construct(inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr);
        }

        /// Generated from method `JPH::RayCast::operator=`.
        public unsafe JPH.RayCast Assign(JPH.Const_RayCast _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCast_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCast_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCast._Underlying *__JPH_RayCast_AssignFromAnother(_Underlying *_this, JPH.RayCast._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_RayCast_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `RayCast` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RayCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RayCast`/`Const_RayCast` directly.
    public class _InOptMut_RayCast
    {
        public RayCast? Opt;

        public _InOptMut_RayCast() {}
        public _InOptMut_RayCast(RayCast value) {Opt = value;}
        public static implicit operator _InOptMut_RayCast(RayCast value) {return new(value);}
    }

    /// This is used for optional parameters of class `RayCast` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RayCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RayCast`/`Const_RayCast` to pass it to the function.
    public class _InOptConst_RayCast
    {
        public Const_RayCast? Opt;

        public _InOptConst_RayCast() {}
        public _InOptConst_RayCast(Const_RayCast value) {Opt = value;}
        public static implicit operator _InOptConst_RayCast(Const_RayCast value) {return new(value);}
    }

    /// Generated from class `JPH::RRayCast`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>`
    /// This is the const half of the class.
    public class Const_RRayCast : JPH.Object<Const_RRayCast>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RRayCast_Destroy(_Underlying *_this);
            __JPH_RRayCast_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RRayCast() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast(Const_RRayCast self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast._Underlying *__JPH_RRayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(_Underlying *_this);
            JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast ret = new(__JPH_RRayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_RRayCast(JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_RRayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast._Underlying *_this);
            Const_RRayCast ret = new(__JPH_RRayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Origin of the ray
        public unsafe JPH.Const_Vec3 mOrigin
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_Get_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_Get_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_RRayCast_Get_mOrigin(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_RRayCast_Get_mOrigin(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
        public unsafe JPH.Const_Vec3 mDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_Get_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_RRayCast_Get_mDirection(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_RRayCast_Get_mDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_RRayCast(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RRayCast() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RRayCast._Underlying *__JPH_RRayCast_DefaultConstruct();
            _UnderlyingPtr = __JPH_RRayCast_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RRayCast::RRayCast`.
        public unsafe Const_RRayCast(JPH.Const_RRayCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RRayCast._Underlying *__JPH_RRayCast_ConstructFromAnother(JPH.RRayCast._Underlying *_other);
            _UnderlyingPtr = __JPH_RRayCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RRayCast::RRayCast`.
        public Const_RRayCast(RRayCast _other) : this((Const_RRayCast)_other) {}

        /// Generated from constructor `JPH::RRayCast::RRayCast`.
        public unsafe Const_RRayCast(JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RRayCast._Underlying *__JPH_RRayCast_Construct_2(JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_RRayCast_Construct_2(inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr);
        }

        /// Convert from RayCast, converts single to double precision
        /// Generated from constructor `JPH::RRayCast::RRayCast`.
        public unsafe Const_RRayCast(JPH.Const_RayCast inRay) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RRayCast._Underlying *__JPH_RRayCast_Construct_1(JPH.Const_RayCast._Underlying *inRay);
            _UnderlyingPtr = __JPH_RRayCast_Construct_1(inRay._UnderlyingPtr);
        }

        /// Convert to RayCast, which implies casting from double precision to single precision
        /// Generated from conversion operator `JPH::RRayCast::operator JPH::RayCast`.
        public static unsafe explicit operator JPH.RayCast(JPH.Const_RRayCast _this)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_ConvertTo_JPH_RayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_ConvertTo_JPH_RayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCast._Underlying *__JPH_RRayCast_ConvertTo_JPH_RayCast(JPH.Const_RRayCast._Underlying *_this);
            return new(__JPH_RRayCast_ConvertTo_JPH_RayCast(_this._UnderlyingPtr), is_owning: true);
        }

        /// Transform this ray using inTransform
        /// Generated from method `JPH::RRayCast::Transformed`.
        public unsafe JPH.RRayCast Transformed(JPH.Const_Mat44 inTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_Transformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_Transformed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RRayCast._Underlying *__JPH_RRayCast_Transformed(_Underlying *_this, JPH.Const_Mat44._Underlying *inTransform);
            return new(__JPH_RRayCast_Transformed(_UnderlyingPtr, inTransform._UnderlyingPtr), is_owning: true);
        }

        /// Translate ray using inTranslation
        /// Generated from method `JPH::RRayCast::Translated`.
        public unsafe JPH.RRayCast Translated(JPH.Const_Vec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_Translated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_Translated", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RRayCast._Underlying *__JPH_RRayCast_Translated(_Underlying *_this, JPH.Vec3._Underlying *inTranslation);
            return new(__JPH_RRayCast_Translated(_UnderlyingPtr, inTranslation._UnderlyingPtr), is_owning: true);
        }

        /// Get point with fraction inFraction on ray (0 = start of ray, 1 = end of ray)
        /// Generated from method `JPH::RRayCast::GetPointOnRay`.
        public unsafe JPH.Vec3 GetPointOnRay(float inFraction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_GetPointOnRay", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_RRayCast_GetPointOnRay(_Underlying *_this, float inFraction);
            return new(__JPH_RRayCast_GetPointOnRay(_UnderlyingPtr, inFraction), is_owning: true);
        }
    }

    /// Generated from class `JPH::RRayCast`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::RayCastT<JPH::Vec3, JPH::Mat44, JPH::RRayCast>`
    /// This is the non-const half of the class.
    public class RRayCast : Const_RRayCast
    {
        // Upcasts:
        public static unsafe implicit operator JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast(RRayCast self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast._Underlying *__JPH_RRayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(_Underlying *_this);
            JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast ret = new(__JPH_RRayCast_UpcastTo_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast(RRayCast self)
            => (JPH.Const_RayCastT_JPHVec3_JPHMat44_JPHRRayCast)(JPH.Const_RRayCast)self;

        // Downcasts:
        public static unsafe explicit operator RRayCast(JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_RRayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(JPH.RayCastT_JPHVec3_JPHMat44_JPHRRayCast._Underlying *_this);
            RRayCast ret = new(__JPH_RRayCast_StaticDowncastFrom_JPH_RayCastT_JPH_Vec3_JPH_Mat44_JPH_RRayCast(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        ///< Origin of the ray
        public new unsafe JPH.Vec3 mOrigin
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_GetMutable_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_GetMutable_mOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_RRayCast_GetMutable_mOrigin(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_RRayCast_GetMutable_mOrigin(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        ///< Direction and length of the ray (anything beyond this length will not be reported as a hit)
        public new unsafe JPH.Vec3 mDirection
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_GetMutable_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_GetMutable_mDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_RRayCast_GetMutable_mDirection(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_RRayCast_GetMutable_mDirection(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe RRayCast(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RRayCast() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RRayCast._Underlying *__JPH_RRayCast_DefaultConstruct();
            _UnderlyingPtr = __JPH_RRayCast_DefaultConstruct();
        }

        /// Generated from constructor `JPH::RRayCast::RRayCast`.
        public unsafe RRayCast(JPH.Const_RRayCast _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RRayCast._Underlying *__JPH_RRayCast_ConstructFromAnother(JPH.RRayCast._Underlying *_other);
            _UnderlyingPtr = __JPH_RRayCast_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RRayCast::RRayCast`.
        public RRayCast(RRayCast _other) : this((Const_RRayCast)_other) {}

        /// Generated from constructor `JPH::RRayCast::RRayCast`.
        public unsafe RRayCast(JPH.Const_Vec3 inOrigin, JPH.Const_Vec3 inDirection) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RRayCast._Underlying *__JPH_RRayCast_Construct_2(JPH.Vec3._Underlying *inOrigin, JPH.Vec3._Underlying *inDirection);
            _UnderlyingPtr = __JPH_RRayCast_Construct_2(inOrigin._UnderlyingPtr, inDirection._UnderlyingPtr);
        }

        /// Convert from RayCast, converts single to double precision
        /// Generated from constructor `JPH::RRayCast::RRayCast`.
        public unsafe RRayCast(JPH.Const_RayCast inRay) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RRayCast._Underlying *__JPH_RRayCast_Construct_1(JPH.Const_RayCast._Underlying *inRay);
            _UnderlyingPtr = __JPH_RRayCast_Construct_1(inRay._UnderlyingPtr);
        }

        /// Generated from method `JPH::RRayCast::operator=`.
        public unsafe JPH.RRayCast Assign(JPH.Const_RRayCast _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RRayCast_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RRayCast_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RRayCast._Underlying *__JPH_RRayCast_AssignFromAnother(_Underlying *_this, JPH.RRayCast._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_RRayCast_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `RRayCast` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RRayCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RRayCast`/`Const_RRayCast` directly.
    public class _InOptMut_RRayCast
    {
        public RRayCast? Opt;

        public _InOptMut_RRayCast() {}
        public _InOptMut_RRayCast(RRayCast value) {Opt = value;}
        public static implicit operator _InOptMut_RRayCast(RRayCast value) {return new(value);}
    }

    /// This is used for optional parameters of class `RRayCast` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RRayCast`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RRayCast`/`Const_RRayCast` to pass it to the function.
    public class _InOptConst_RRayCast
    {
        public Const_RRayCast? Opt;

        public _InOptConst_RRayCast() {}
        public _InOptConst_RRayCast(Const_RRayCast value) {Opt = value;}
        public static implicit operator _InOptConst_RRayCast(Const_RRayCast value) {return new(value);}
    }

    /// Settings to be passed with a ray cast
    /// Generated from class `JPH::RayCastSettings`.
    /// This is the const half of the class.
    public class Const_RayCastSettings : JPH.Object<Const_RayCastSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RayCastSettings_Destroy(_Underlying *_this);
            __JPH_RayCastSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_RayCastSettings() {Dispose(false);}

        /// How backfacing triangles should be treated (should we report back facing hits for triangle based shapes, e.g. MeshShape/HeightFieldShape?)
        public unsafe JPH.EBackFaceMode mBackFaceModeTriangles
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_Get_mBackFaceModeTriangles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_Get_mBackFaceModeTriangles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EBackFaceMode *__JPH_RayCastSettings_Get_mBackFaceModeTriangles(_Underlying *_this);
                return *__JPH_RayCastSettings_Get_mBackFaceModeTriangles(_UnderlyingPtr);
            }
        }

        /// How backfacing convex objects should be treated (should we report back facing hits for convex shapes?)
        public unsafe JPH.EBackFaceMode mBackFaceModeConvex
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_Get_mBackFaceModeConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_Get_mBackFaceModeConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EBackFaceMode *__JPH_RayCastSettings_Get_mBackFaceModeConvex(_Underlying *_this);
                return *__JPH_RayCastSettings_Get_mBackFaceModeConvex(_UnderlyingPtr);
            }
        }

        /// If convex shapes should be treated as solid. When true, a ray starting inside a convex shape will generate a hit at fraction 0.
        public unsafe bool mTreatConvexAsSolid
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_Get_mTreatConvexAsSolid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_Get_mTreatConvexAsSolid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_RayCastSettings_Get_mTreatConvexAsSolid(_Underlying *_this);
                return *__JPH_RayCastSettings_Get_mTreatConvexAsSolid(_UnderlyingPtr);
            }
        }

        internal unsafe Const_RayCastSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_RayCastSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastSettings._Underlying *__JPH_RayCastSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RayCastSettings_DefaultConstruct();
        }

        /// Constructs `JPH::RayCastSettings` elementwise.
        public unsafe Const_RayCastSettings(JPH.EBackFaceMode mBackFaceModeTriangles, JPH.EBackFaceMode mBackFaceModeConvex, bool mTreatConvexAsSolid) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastSettings._Underlying *__JPH_RayCastSettings_ConstructFrom(JPH.EBackFaceMode mBackFaceModeTriangles, JPH.EBackFaceMode mBackFaceModeConvex, byte mTreatConvexAsSolid);
            _UnderlyingPtr = __JPH_RayCastSettings_ConstructFrom(mBackFaceModeTriangles, mBackFaceModeConvex, mTreatConvexAsSolid ? (byte)1 : (byte)0);
        }

        /// Generated from constructor `JPH::RayCastSettings::RayCastSettings`.
        public unsafe Const_RayCastSettings(JPH.Const_RayCastSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastSettings._Underlying *__JPH_RayCastSettings_ConstructFromAnother(JPH.RayCastSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RayCastSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RayCastSettings::RayCastSettings`.
        public Const_RayCastSettings(RayCastSettings _other) : this((Const_RayCastSettings)_other) {}

        /// Generated from method `JPH::RayCastSettings::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RayCastSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RayCastSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_RayCastSettings_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_RayCastSettings_size_t(inCount);
        }

        /// Generated from method `JPH::RayCastSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RayCastSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RayCastSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RayCastSettings_void_ptr(void *inPointer);
            __Jolt_delete_JPH_RayCastSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::RayCastSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RayCastSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RayCastSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RayCastSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_RayCastSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::RayCastSettings::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastSettings_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_RayCastSettings_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_RayCastSettings_size_t(inCount);
        }

        /// Generated from method `JPH::RayCastSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastSettings_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RayCastSettings_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_RayCastSettings_void_ptr(inPointer);
        }

        /// Generated from method `JPH::RayCastSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastSettings_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RayCastSettings_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_RayCastSettings_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::RayCastSettings::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_RayCastSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_RayCastSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_RayCastSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_RayCastSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::RayCastSettings::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_RayCastSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_RayCastSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_RayCastSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_RayCastSettings_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::RayCastSettings::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_RayCastSettings_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_RayCastSettings_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_RayCastSettings_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::RayCastSettings::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_RayCastSettings_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_RayCastSettings_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_RayCastSettings_void_ptr_void_ptr(inPointer, inPlace);
        }
    }

    /// Settings to be passed with a ray cast
    /// Generated from class `JPH::RayCastSettings`.
    /// This is the non-const half of the class.
    public class RayCastSettings : Const_RayCastSettings
    {
        /// How backfacing triangles should be treated (should we report back facing hits for triangle based shapes, e.g. MeshShape/HeightFieldShape?)
        public new unsafe ref JPH.EBackFaceMode mBackFaceModeTriangles
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_GetMutable_mBackFaceModeTriangles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_GetMutable_mBackFaceModeTriangles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EBackFaceMode *__JPH_RayCastSettings_GetMutable_mBackFaceModeTriangles(_Underlying *_this);
                return ref *__JPH_RayCastSettings_GetMutable_mBackFaceModeTriangles(_UnderlyingPtr);
            }
        }

        /// How backfacing convex objects should be treated (should we report back facing hits for convex shapes?)
        public new unsafe ref JPH.EBackFaceMode mBackFaceModeConvex
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_GetMutable_mBackFaceModeConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_GetMutable_mBackFaceModeConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.EBackFaceMode *__JPH_RayCastSettings_GetMutable_mBackFaceModeConvex(_Underlying *_this);
                return ref *__JPH_RayCastSettings_GetMutable_mBackFaceModeConvex(_UnderlyingPtr);
            }
        }

        /// If convex shapes should be treated as solid. When true, a ray starting inside a convex shape will generate a hit at fraction 0.
        public new unsafe ref bool mTreatConvexAsSolid
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_GetMutable_mTreatConvexAsSolid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_GetMutable_mTreatConvexAsSolid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__JPH_RayCastSettings_GetMutable_mTreatConvexAsSolid(_Underlying *_this);
                return ref *__JPH_RayCastSettings_GetMutable_mTreatConvexAsSolid(_UnderlyingPtr);
            }
        }

        internal unsafe RayCastSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe RayCastSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastSettings._Underlying *__JPH_RayCastSettings_DefaultConstruct();
            _UnderlyingPtr = __JPH_RayCastSettings_DefaultConstruct();
        }

        /// Constructs `JPH::RayCastSettings` elementwise.
        public unsafe RayCastSettings(JPH.EBackFaceMode mBackFaceModeTriangles, JPH.EBackFaceMode mBackFaceModeConvex, bool mTreatConvexAsSolid) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastSettings._Underlying *__JPH_RayCastSettings_ConstructFrom(JPH.EBackFaceMode mBackFaceModeTriangles, JPH.EBackFaceMode mBackFaceModeConvex, byte mTreatConvexAsSolid);
            _UnderlyingPtr = __JPH_RayCastSettings_ConstructFrom(mBackFaceModeTriangles, mBackFaceModeConvex, mTreatConvexAsSolid ? (byte)1 : (byte)0);
        }

        /// Generated from constructor `JPH::RayCastSettings::RayCastSettings`.
        public unsafe RayCastSettings(JPH.Const_RayCastSettings _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastSettings._Underlying *__JPH_RayCastSettings_ConstructFromAnother(JPH.RayCastSettings._Underlying *_other);
            _UnderlyingPtr = __JPH_RayCastSettings_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::RayCastSettings::RayCastSettings`.
        public RayCastSettings(RayCastSettings _other) : this((Const_RayCastSettings)_other) {}

        /// Generated from method `JPH::RayCastSettings::operator=`.
        public unsafe JPH.RayCastSettings Assign(JPH.Const_RayCastSettings _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RayCastSettings._Underlying *__JPH_RayCastSettings_AssignFromAnother(_Underlying *_this, JPH.RayCastSettings._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_RayCastSettings_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Set the backfacing mode for all shapes
        /// Generated from method `JPH::RayCastSettings::SetBackFaceMode`.
        public unsafe void SetBackFaceMode(JPH.EBackFaceMode inMode)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RayCastSettings_SetBackFaceMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RayCastSettings_SetBackFaceMode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RayCastSettings_SetBackFaceMode(_Underlying *_this, JPH.EBackFaceMode inMode);
            __JPH_RayCastSettings_SetBackFaceMode(_UnderlyingPtr, inMode);
        }
    }

    /// This is used for optional parameters of class `RayCastSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_RayCastSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RayCastSettings`/`Const_RayCastSettings` directly.
    public class _InOptMut_RayCastSettings
    {
        public RayCastSettings? Opt;

        public _InOptMut_RayCastSettings() {}
        public _InOptMut_RayCastSettings(RayCastSettings value) {Opt = value;}
        public static implicit operator _InOptMut_RayCastSettings(RayCastSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `RayCastSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_RayCastSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `RayCastSettings`/`Const_RayCastSettings` to pass it to the function.
    public class _InOptConst_RayCastSettings
    {
        public Const_RayCastSettings? Opt;

        public _InOptConst_RayCastSettings() {}
        public _InOptConst_RayCastSettings(Const_RayCastSettings value) {Opt = value;}
        public static implicit operator _InOptConst_RayCastSettings(Const_RayCastSettings value) {return new(value);}
    }
}
