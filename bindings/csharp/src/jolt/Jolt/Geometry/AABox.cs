// machine generated, do not edit
public static partial class JPH
{
    /// Axis aligned box
    /// Generated from class `JPH::AABox`.
    /// This is the const half of the class.
    public class Const_AABox : JPH.Object<Const_AABox>, System.IDisposable, System.IEquatable<JPH.Const_AABox>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_AABox_Destroy(_Underlying *_this);
            __JPH_AABox_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_AABox() {Dispose(false);}

        /// Bounding box min and max
        public unsafe JPH.Const_Vec3 mMin
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Get_mMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Get_mMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_AABox_Get_mMin(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_AABox_Get_mMin(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe JPH.Const_Vec3 mMax
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Get_mMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Get_mMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_Vec3._Underlying *__JPH_AABox_Get_mMax(_Underlying *_this);
                JPH.Const_Vec3 __ret;
                __ret = new(__JPH_AABox_Get_mMax(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_AABox(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_AABox() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_DefaultConstruct();
            _UnderlyingPtr = __JPH_AABox_DefaultConstruct();
        }

        /// Generated from constructor `JPH::AABox::AABox`.
        public unsafe Const_AABox(JPH.Const_AABox _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_ConstructFromAnother(JPH.AABox._Underlying *_other);
            _UnderlyingPtr = __JPH_AABox_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::AABox::AABox`.
        public Const_AABox(AABox _other) : this((Const_AABox)_other) {}

        /// Generated from constructor `JPH::AABox::AABox`.
        public unsafe Const_AABox(JPH.Const_Vec3 inMin, JPH.Const_Vec3 inMax) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Construct_const_JPH_Vec3_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Construct_const_JPH_Vec3_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_Construct_const_JPH_Vec3_JPH_Vec3(JPH.Vec3._Underlying *inMin, JPH.Vec3._Underlying *inMax);
            _UnderlyingPtr = __JPH_AABox_Construct_const_JPH_Vec3_JPH_Vec3(inMin._UnderlyingPtr, inMax._UnderlyingPtr);
        }

        /// Generated from constructor `JPH::AABox::AABox`.
        public unsafe Const_AABox(JPH.Const_DVec3 inMin, JPH.Const_DVec3 inMax) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Construct_const_JPH_DVec3_ref", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Construct_const_JPH_DVec3_ref", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_Construct_const_JPH_DVec3_ref(JPH.Const_DVec3._Underlying *inMin, JPH.Const_DVec3._Underlying *inMax);
            _UnderlyingPtr = __JPH_AABox_Construct_const_JPH_DVec3_ref(inMin._UnderlyingPtr, inMax._UnderlyingPtr);
        }

        /// Generated from constructor `JPH::AABox::AABox`.
        public unsafe Const_AABox(JPH.Const_Vec3 inCenter, float inRadius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Construct_const_JPH_Vec3_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Construct_const_JPH_Vec3_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_Construct_const_JPH_Vec3_float(JPH.Vec3._Underlying *inCenter, float inRadius);
            _UnderlyingPtr = __JPH_AABox_Construct_const_JPH_Vec3_float(inCenter._UnderlyingPtr, inRadius);
        }

        /// Generated from method `JPH::AABox::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_AABox_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_AABox_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_AABox_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_AABox_size_t(inCount);
        }

        /// Generated from method `JPH::AABox::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_AABox_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_AABox_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_AABox_void_ptr(void *inPointer);
            __Jolt_delete_JPH_AABox_void_ptr(inPointer);
        }

        /// Generated from method `JPH::AABox::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_AABox_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_AABox_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_AABox_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_AABox_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::AABox::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_AABox_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_AABox_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_AABox_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_AABox_size_t(inCount);
        }

        /// Generated from method `JPH::AABox::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_AABox_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_AABox_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_AABox_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_AABox_void_ptr(inPointer);
        }

        /// Generated from method `JPH::AABox::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_AABox_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_AABox_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_AABox_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_AABox_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::AABox::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_AABox_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_AABox_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_AABox_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_AABox_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::AABox::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_AABox_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_AABox_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_AABox_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_AABox_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::AABox::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_AABox_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_AABox_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_AABox_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_AABox_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::AABox::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_AABox_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_AABox_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_AABox_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_AABox_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Create box from 2 points
        /// Generated from method `JPH::AABox::sFromTwoPoints`.
        public static unsafe JPH.AABox SFromTwoPoints(JPH.Const_Vec3 inP1, JPH.Const_Vec3 inP2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_sFromTwoPoints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_sFromTwoPoints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_sFromTwoPoints(JPH.Vec3._Underlying *inP1, JPH.Vec3._Underlying *inP2);
            return new(__JPH_AABox_sFromTwoPoints(inP1._UnderlyingPtr, inP2._UnderlyingPtr), is_owning: true);
        }

        /// Get bounding box of size FLT_MAX
        /// Generated from method `JPH::AABox::sBiggest`.
        public static unsafe JPH.AABox SBiggest()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_sBiggest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_sBiggest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_sBiggest();
            return new(__JPH_AABox_sBiggest(), is_owning: true);
        }

        /// Comparison operators
        /// Generated from method `JPH::AABox::operator==`.
        public static unsafe bool operator==(JPH.Const_AABox _this, JPH.Const_AABox inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_equal_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_equal_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_equal_JPH_AABox(JPH.Const_AABox._Underlying *_this, JPH.Const_AABox._Underlying *inRHS);
            return __Jolt_equal_JPH_AABox(_this._UnderlyingPtr, inRHS._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(JPH.Const_AABox _this, JPH.Const_AABox inRHS)
        {
            return !(_this == inRHS);
        }

        /// Check if the bounding box is valid (max >= min)
        /// Generated from method `JPH::AABox::IsValid`.
        public unsafe bool IsValid()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_IsValid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_AABox_IsValid(_Underlying *_this);
            return __JPH_AABox_IsValid(_UnderlyingPtr) != 0;
        }

        /// Intersect this bounding box with inOther, returns the intersection
        /// Generated from method `JPH::AABox::Intersect`.
        public unsafe JPH.AABox Intersect(JPH.Const_AABox inOther)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Intersect", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Intersect", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_Intersect(_Underlying *_this, JPH.Const_AABox._Underlying *inOther);
            return new(__JPH_AABox_Intersect(_UnderlyingPtr, inOther._UnderlyingPtr), is_owning: true);
        }

        /// Get center of bounding box
        /// Generated from method `JPH::AABox::GetCenter`.
        public unsafe JPH.Vec3 GetCenter()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_GetCenter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_GetCenter", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_AABox_GetCenter(_Underlying *_this);
            return new(__JPH_AABox_GetCenter(_UnderlyingPtr), is_owning: true);
        }

        /// Get extent of bounding box (half of the size)
        /// Generated from method `JPH::AABox::GetExtent`.
        public unsafe JPH.Vec3 GetExtent()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_GetExtent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_GetExtent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_AABox_GetExtent(_Underlying *_this);
            return new(__JPH_AABox_GetExtent(_UnderlyingPtr), is_owning: true);
        }

        /// Get size of bounding box
        /// Generated from method `JPH::AABox::GetSize`.
        public unsafe JPH.Vec3 GetSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_GetSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_GetSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_AABox_GetSize(_Underlying *_this);
            return new(__JPH_AABox_GetSize(_UnderlyingPtr), is_owning: true);
        }

        /// Get surface area of bounding box
        /// Generated from method `JPH::AABox::GetSurfaceArea`.
        public unsafe float GetSurfaceArea()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_GetSurfaceArea", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_GetSurfaceArea", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_AABox_GetSurfaceArea(_Underlying *_this);
            return __JPH_AABox_GetSurfaceArea(_UnderlyingPtr);
        }

        /// Get volume of bounding box
        /// Generated from method `JPH::AABox::GetVolume`.
        public unsafe float GetVolume()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_GetVolume", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_AABox_GetVolume(_Underlying *_this);
            return __JPH_AABox_GetVolume(_UnderlyingPtr);
        }

        /// Check if this box contains another box
        /// Generated from method `JPH::AABox::Contains`.
        public unsafe bool Contains(JPH.Const_AABox inOther)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Contains_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Contains_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_AABox_Contains_JPH_AABox(_Underlying *_this, JPH.Const_AABox._Underlying *inOther);
            return __JPH_AABox_Contains_JPH_AABox(_UnderlyingPtr, inOther._UnderlyingPtr) != 0;
        }

        /// Check if this box contains a point
        /// Generated from method `JPH::AABox::Contains`.
        public unsafe bool Contains(JPH.Const_Vec3 inOther)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Contains_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Contains_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_AABox_Contains_JPH_Vec3(_Underlying *_this, JPH.Vec3._Underlying *inOther);
            return __JPH_AABox_Contains_JPH_Vec3(_UnderlyingPtr, inOther._UnderlyingPtr) != 0;
        }

        /// Check if this box contains a point
        /// Generated from method `JPH::AABox::Contains`.
        public unsafe bool Contains(JPH.Const_DVec3 inOther)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Contains_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Contains_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_AABox_Contains_JPH_DVec3(_Underlying *_this, JPH.Const_DVec3._Underlying *inOther);
            return __JPH_AABox_Contains_JPH_DVec3(_UnderlyingPtr, inOther._UnderlyingPtr) != 0;
        }

        /// Check if this box overlaps with another box
        /// Generated from method `JPH::AABox::Overlaps`.
        public unsafe bool Overlaps(JPH.Const_AABox inOther)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Overlaps_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Overlaps_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_AABox_Overlaps_JPH_AABox(_Underlying *_this, JPH.Const_AABox._Underlying *inOther);
            return __JPH_AABox_Overlaps_JPH_AABox(_UnderlyingPtr, inOther._UnderlyingPtr) != 0;
        }

        /// Check if this box overlaps with a plane
        /// Generated from method `JPH::AABox::Overlaps`.
        public unsafe bool Overlaps(JPH.Const_Plane inPlane)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Overlaps_JPH_Plane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Overlaps_JPH_Plane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_AABox_Overlaps_JPH_Plane(_Underlying *_this, JPH.Const_Plane._Underlying *inPlane);
            return __JPH_AABox_Overlaps_JPH_Plane(_UnderlyingPtr, inPlane._UnderlyingPtr) != 0;
        }

        /// Transform bounding box
        /// Generated from method `JPH::AABox::Transformed`.
        public unsafe JPH.AABox Transformed(JPH.Const_Mat44 inMatrix)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Transformed_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Transformed_JPH_Mat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_Transformed_JPH_Mat44(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix);
            return new(__JPH_AABox_Transformed_JPH_Mat44(_UnderlyingPtr, inMatrix._UnderlyingPtr), is_owning: true);
        }

        /// Transform bounding box
        /// Generated from method `JPH::AABox::Transformed`.
        public unsafe JPH.AABox Transformed(JPH.Const_DMat44 inMatrix)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Transformed_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Transformed_JPH_DMat44", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_Transformed_JPH_DMat44(_Underlying *_this, JPH.Const_DMat44._Underlying *inMatrix);
            return new(__JPH_AABox_Transformed_JPH_DMat44(_UnderlyingPtr, inMatrix._UnderlyingPtr), is_owning: true);
        }

        /// Scale this bounding box, can handle non-uniform and negative scaling
        /// Generated from method `JPH::AABox::Scaled`.
        public unsafe JPH.AABox Scaled(JPH.Const_Vec3 inScale)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Scaled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Scaled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_Scaled(_Underlying *_this, JPH.Vec3._Underlying *inScale);
            return new(__JPH_AABox_Scaled(_UnderlyingPtr, inScale._UnderlyingPtr), is_owning: true);
        }

        /// Calculate the support vector for this convex shape.
        /// Generated from method `JPH::AABox::GetSupport`.
        public unsafe JPH.Vec3 GetSupport(JPH.Const_Vec3 inDirection)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_GetSupport", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_GetSupport", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_AABox_GetSupport(_Underlying *_this, JPH.Vec3._Underlying *inDirection);
            return new(__JPH_AABox_GetSupport(_UnderlyingPtr, inDirection._UnderlyingPtr), is_owning: true);
        }

        /// Get the closest point on or in this box to inPoint
        /// Generated from method `JPH::AABox::GetClosestPoint`.
        public unsafe JPH.Vec3 GetClosestPoint(JPH.Const_Vec3 inPoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_GetClosestPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_GetClosestPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Vec3._Underlying *__JPH_AABox_GetClosestPoint(_Underlying *_this, JPH.Vec3._Underlying *inPoint);
            return new(__JPH_AABox_GetClosestPoint(_UnderlyingPtr, inPoint._UnderlyingPtr), is_owning: true);
        }

        /// Get the squared distance between inPoint and this box (will be 0 if in Point is inside the box)
        /// Generated from method `JPH::AABox::GetSqDistanceTo`.
        public unsafe float GetSqDistanceTo(JPH.Const_Vec3 inPoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_GetSqDistanceTo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_GetSqDistanceTo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_AABox_GetSqDistanceTo(_Underlying *_this, JPH.Vec3._Underlying *inPoint);
            return __JPH_AABox_GetSqDistanceTo(_UnderlyingPtr, inPoint._UnderlyingPtr);
        }

        // IEquatable:

        public bool Equals(JPH.Const_AABox? inRHS)
        {
            if (inRHS is null)
                return false;
            return this == inRHS;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is JPH.Const_AABox)
                return this == (JPH.Const_AABox)other;
            return false;
        }
    }

    /// Axis aligned box
    /// Generated from class `JPH::AABox`.
    /// This is the non-const half of the class.
    public class AABox : Const_AABox
    {
        /// Bounding box min and max
        public new unsafe JPH.Vec3 mMin
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_GetMutable_mMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_GetMutable_mMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_AABox_GetMutable_mMin(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_AABox_GetMutable_mMin(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe JPH.Vec3 mMax
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_GetMutable_mMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_GetMutable_mMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__JPH_AABox_GetMutable_mMax(_Underlying *_this);
                JPH.Vec3 __ret;
                __ret = new(__JPH_AABox_GetMutable_mMax(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe AABox(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe AABox() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_DefaultConstruct();
            _UnderlyingPtr = __JPH_AABox_DefaultConstruct();
        }

        /// Generated from constructor `JPH::AABox::AABox`.
        public unsafe AABox(JPH.Const_AABox _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_ConstructFromAnother(JPH.AABox._Underlying *_other);
            _UnderlyingPtr = __JPH_AABox_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::AABox::AABox`.
        public AABox(AABox _other) : this((Const_AABox)_other) {}

        /// Generated from constructor `JPH::AABox::AABox`.
        public unsafe AABox(JPH.Const_Vec3 inMin, JPH.Const_Vec3 inMax) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Construct_const_JPH_Vec3_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Construct_const_JPH_Vec3_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_Construct_const_JPH_Vec3_JPH_Vec3(JPH.Vec3._Underlying *inMin, JPH.Vec3._Underlying *inMax);
            _UnderlyingPtr = __JPH_AABox_Construct_const_JPH_Vec3_JPH_Vec3(inMin._UnderlyingPtr, inMax._UnderlyingPtr);
        }

        /// Generated from constructor `JPH::AABox::AABox`.
        public unsafe AABox(JPH.Const_DVec3 inMin, JPH.Const_DVec3 inMax) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Construct_const_JPH_DVec3_ref", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Construct_const_JPH_DVec3_ref", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_Construct_const_JPH_DVec3_ref(JPH.Const_DVec3._Underlying *inMin, JPH.Const_DVec3._Underlying *inMax);
            _UnderlyingPtr = __JPH_AABox_Construct_const_JPH_DVec3_ref(inMin._UnderlyingPtr, inMax._UnderlyingPtr);
        }

        /// Generated from constructor `JPH::AABox::AABox`.
        public unsafe AABox(JPH.Const_Vec3 inCenter, float inRadius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Construct_const_JPH_Vec3_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Construct_const_JPH_Vec3_float", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_Construct_const_JPH_Vec3_float(JPH.Vec3._Underlying *inCenter, float inRadius);
            _UnderlyingPtr = __JPH_AABox_Construct_const_JPH_Vec3_float(inCenter._UnderlyingPtr, inRadius);
        }

        /// Generated from method `JPH::AABox::operator=`.
        public unsafe JPH.AABox Assign(JPH.Const_AABox _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_AABox_AssignFromAnother(_Underlying *_this, JPH.AABox._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_AABox_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /// Reset the bounding box to an empty bounding box
        /// Generated from method `JPH::AABox::SetEmpty`.
        public unsafe void SetEmpty()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_SetEmpty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_SetEmpty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_AABox_SetEmpty(_Underlying *_this);
            __JPH_AABox_SetEmpty(_UnderlyingPtr);
        }

        /// Encapsulate point in bounding box
        /// Generated from method `JPH::AABox::Encapsulate`.
        public unsafe void Encapsulate(JPH.Const_Vec3 inPos)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Encapsulate_1_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Encapsulate_1_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_AABox_Encapsulate_1_JPH_Vec3(_Underlying *_this, JPH.Vec3._Underlying *inPos);
            __JPH_AABox_Encapsulate_1_JPH_Vec3(_UnderlyingPtr, inPos._UnderlyingPtr);
        }

        /// Encapsulate bounding box in bounding box
        /// Generated from method `JPH::AABox::Encapsulate`.
        public unsafe void Encapsulate(JPH.Const_AABox inRHS)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Encapsulate_1_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Encapsulate_1_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_AABox_Encapsulate_1_JPH_AABox(_Underlying *_this, JPH.Const_AABox._Underlying *inRHS);
            __JPH_AABox_Encapsulate_1_JPH_AABox(_UnderlyingPtr, inRHS._UnderlyingPtr);
        }

        /// Make sure that each edge of the bounding box has a minimal length
        /// Generated from method `JPH::AABox::EnsureMinimalEdgeLength`.
        public unsafe void EnsureMinimalEdgeLength(float inMinEdgeLength)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_EnsureMinimalEdgeLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_EnsureMinimalEdgeLength", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_AABox_EnsureMinimalEdgeLength(_Underlying *_this, float inMinEdgeLength);
            __JPH_AABox_EnsureMinimalEdgeLength(_UnderlyingPtr, inMinEdgeLength);
        }

        /// Widen the box on both sides by inVector
        /// Generated from method `JPH::AABox::ExpandBy`.
        public unsafe void ExpandBy(JPH.Const_Vec3 inVector)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_ExpandBy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_ExpandBy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_AABox_ExpandBy(_Underlying *_this, JPH.Vec3._Underlying *inVector);
            __JPH_AABox_ExpandBy(_UnderlyingPtr, inVector._UnderlyingPtr);
        }

        /// Translate bounding box
        /// Generated from method `JPH::AABox::Translate`.
        public unsafe void Translate(JPH.Const_Vec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Translate_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Translate_JPH_Vec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_AABox_Translate_JPH_Vec3(_Underlying *_this, JPH.Vec3._Underlying *inTranslation);
            __JPH_AABox_Translate_JPH_Vec3(_UnderlyingPtr, inTranslation._UnderlyingPtr);
        }

        /// Translate bounding box
        /// Generated from method `JPH::AABox::Translate`.
        public unsafe void Translate(JPH.Const_DVec3 inTranslation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_AABox_Translate_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_AABox_Translate_JPH_DVec3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_AABox_Translate_JPH_DVec3(_Underlying *_this, JPH.Const_DVec3._Underlying *inTranslation);
            __JPH_AABox_Translate_JPH_DVec3(_UnderlyingPtr, inTranslation._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `AABox` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_AABox`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `AABox`/`Const_AABox` directly.
    public class _InOptMut_AABox
    {
        public AABox? Opt;

        public _InOptMut_AABox() {}
        public _InOptMut_AABox(AABox value) {Opt = value;}
        public static implicit operator _InOptMut_AABox(AABox value) {return new(value);}
    }

    /// This is used for optional parameters of class `AABox` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_AABox`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `AABox`/`Const_AABox` to pass it to the function.
    public class _InOptConst_AABox
    {
        public Const_AABox? Opt;

        public _InOptConst_AABox() {}
        public _InOptConst_AABox(Const_AABox value) {Opt = value;}
        public static implicit operator _InOptConst_AABox(Const_AABox value) {return new(value);}
    }
}
