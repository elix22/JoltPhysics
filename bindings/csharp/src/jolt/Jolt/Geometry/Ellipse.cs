// machine generated, do not edit
public static partial class JPH
{
    /// Ellipse centered around the origin
    /// @see https://en.wikipedia.org/wiki/Ellipse
    /// Generated from class `JPH::Ellipse`.
    /// This is the const half of the class.
    public class Const_Ellipse : JPH.Object<Const_Ellipse>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ellipse_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ellipse_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_Ellipse_Destroy(_Underlying *_this);
            __JPH_Ellipse_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Ellipse() {Dispose(false);}

        internal unsafe Const_Ellipse(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `JPH::Ellipse::Ellipse`.
        public unsafe Const_Ellipse(JPH.Const_Ellipse _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ellipse_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ellipse_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Ellipse._Underlying *__JPH_Ellipse_ConstructFromAnother(JPH.Ellipse._Underlying *_other);
            _UnderlyingPtr = __JPH_Ellipse_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::Ellipse::Ellipse`.
        public Const_Ellipse(Ellipse _other) : this((Const_Ellipse)_other) {}

        /// Construct ellipse with radius A along the X-axis and B along the Y-axis
        /// Generated from constructor `JPH::Ellipse::Ellipse`.
        public unsafe Const_Ellipse(float inA, float inB) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ellipse_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ellipse_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Ellipse._Underlying *__JPH_Ellipse_Construct(float inA, float inB);
            _UnderlyingPtr = __JPH_Ellipse_Construct(inA, inB);
        }

        /// Generated from method `JPH::Ellipse::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Ellipse_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Ellipse_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Ellipse_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_Ellipse_size_t(inCount);
        }

        /// Generated from method `JPH::Ellipse::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Ellipse_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Ellipse_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Ellipse_void_ptr(void *inPointer);
            __Jolt_delete_JPH_Ellipse_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Ellipse::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Ellipse_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Ellipse_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Ellipse_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_Ellipse_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Ellipse::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Ellipse_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Ellipse_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Ellipse_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_Ellipse_size_t(inCount);
        }

        /// Generated from method `JPH::Ellipse::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Ellipse_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Ellipse_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Ellipse_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_Ellipse_void_ptr(inPointer);
        }

        /// Generated from method `JPH::Ellipse::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Ellipse_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Ellipse_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Ellipse_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_Ellipse_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::Ellipse::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_Ellipse_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_Ellipse_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_Ellipse_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_Ellipse_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Ellipse::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_Ellipse_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_Ellipse_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_Ellipse_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_Ellipse_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::Ellipse::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_Ellipse_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_Ellipse_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_Ellipse_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_Ellipse_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::Ellipse::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_Ellipse_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_Ellipse_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_Ellipse_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_Ellipse_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Check if inPoint is inside the ellipse
        /// Generated from method `JPH::Ellipse::IsInside`.
        public unsafe bool IsInside(JPH.Const_Float2 inPoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ellipse_IsInside", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ellipse_IsInside", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_Ellipse_IsInside(_Underlying *_this, JPH.Const_Float2._Underlying *inPoint);
            return __JPH_Ellipse_IsInside(_UnderlyingPtr, inPoint._UnderlyingPtr) != 0;
        }

        /// Get the closest point on the ellipse to inPoint
        /// Assumes inPoint is outside the ellipse
        /// @see Rotation Joint Limits in Quaternion Space by Gino van den Bergen, section 10.1 in Game Engine Gems 3.
        /// Generated from method `JPH::Ellipse::GetClosestPoint`.
        public unsafe JPH.Float2 GetClosestPoint(JPH.Const_Float2 inPoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ellipse_GetClosestPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ellipse_GetClosestPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Float2._Underlying *__JPH_Ellipse_GetClosestPoint(_Underlying *_this, JPH.Const_Float2._Underlying *inPoint);
            return new(__JPH_Ellipse_GetClosestPoint(_UnderlyingPtr, inPoint._UnderlyingPtr), is_owning: true);
        }

        /// Get normal at point inPoint (non-normalized vector)
        /// Generated from method `JPH::Ellipse::GetNormal`.
        public unsafe JPH.Float2 GetNormal(JPH.Const_Float2 inPoint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ellipse_GetNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ellipse_GetNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Float2._Underlying *__JPH_Ellipse_GetNormal(_Underlying *_this, JPH.Const_Float2._Underlying *inPoint);
            return new(__JPH_Ellipse_GetNormal(_UnderlyingPtr, inPoint._UnderlyingPtr), is_owning: true);
        }
    }

    /// Ellipse centered around the origin
    /// @see https://en.wikipedia.org/wiki/Ellipse
    /// Generated from class `JPH::Ellipse`.
    /// This is the non-const half of the class.
    public class Ellipse : Const_Ellipse
    {
        internal unsafe Ellipse(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `JPH::Ellipse::Ellipse`.
        public unsafe Ellipse(JPH.Const_Ellipse _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ellipse_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ellipse_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Ellipse._Underlying *__JPH_Ellipse_ConstructFromAnother(JPH.Ellipse._Underlying *_other);
            _UnderlyingPtr = __JPH_Ellipse_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JPH::Ellipse::Ellipse`.
        public Ellipse(Ellipse _other) : this((Const_Ellipse)_other) {}

        /// Construct ellipse with radius A along the X-axis and B along the Y-axis
        /// Generated from constructor `JPH::Ellipse::Ellipse`.
        public unsafe Ellipse(float inA, float inB) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ellipse_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ellipse_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Ellipse._Underlying *__JPH_Ellipse_Construct(float inA, float inB);
            _UnderlyingPtr = __JPH_Ellipse_Construct(inA, inB);
        }

        /// Generated from method `JPH::Ellipse::operator=`.
        public unsafe JPH.Ellipse Assign(JPH.Const_Ellipse _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_Ellipse_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_Ellipse_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Ellipse._Underlying *__JPH_Ellipse_AssignFromAnother(_Underlying *_this, JPH.Ellipse._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JPH_Ellipse_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `Ellipse` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Ellipse`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Ellipse`/`Const_Ellipse` directly.
    public class _InOptMut_Ellipse
    {
        public Ellipse? Opt;

        public _InOptMut_Ellipse() {}
        public _InOptMut_Ellipse(Ellipse value) {Opt = value;}
        public static implicit operator _InOptMut_Ellipse(Ellipse value) {return new(value);}
    }

    /// This is used for optional parameters of class `Ellipse` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Ellipse`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Ellipse`/`Const_Ellipse` to pass it to the function.
    public class _InOptConst_Ellipse
    {
        public Const_Ellipse? Opt;

        public _InOptConst_Ellipse() {}
        public _InOptConst_Ellipse(Const_Ellipse value) {Opt = value;}
        public static implicit operator _InOptConst_Ellipse(Const_Ellipse value) {return new(value);}
    }
}
