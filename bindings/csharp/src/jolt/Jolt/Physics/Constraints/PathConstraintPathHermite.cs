// machine generated, do not edit
public static partial class JPH
{
    /// A path that follows a Hermite spline
    /// Generated from class `JPH::PathConstraintPathHermite`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::PathConstraintPath`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::PathConstraintPath>`
    /// This is the const half of the class.
    public class Const_PathConstraintPathHermite : JPH.Object<Const_PathConstraintPathHermite>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PathConstraintPath_Release(void *_this);
            __JPH_RefTarget_JPH_PathConstraintPath_Release(__JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_PathConstraintPathHermite() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_PathConstraintPathHermite self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_PathConstraintPathHermite_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_PathConstraintPathHermite_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHPathConstraintPath(Const_PathConstraintPathHermite self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHPathConstraintPath._Underlying *__JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_Underlying *_this);
            JPH.Const_RefTarget_JPHPathConstraintPath ret = new(__JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_PathConstraintPath(Const_PathConstraintPathHermite self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_PathConstraintPath._Underlying *__JPH_PathConstraintPathHermite_UpcastTo_JPH_PathConstraintPath(_Underlying *_this);
            JPH.Const_PathConstraintPath ret = new(__JPH_PathConstraintPathHermite_UpcastTo_JPH_PathConstraintPath(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe Const_PathConstraintPathHermite(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_PathConstraintPathHermite() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PathConstraintPathHermite._Underlying *__JPH_PathConstraintPathHermite_DefaultConstruct();
            _UnderlyingPtr = __JPH_PathConstraintPathHermite_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PathConstraintPath_AddRef(void *_this);
            __JPH_RefTarget_JPH_PathConstraintPath_AddRef(__JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::PathConstraintPathHermite::PathConstraintPathHermite`.
        public unsafe Const_PathConstraintPathHermite(JPH._ByValue_PathConstraintPathHermite _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PathConstraintPathHermite._Underlying *__JPH_PathConstraintPathHermite_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.PathConstraintPathHermite._Underlying *_other);
            _UnderlyingPtr = __JPH_PathConstraintPathHermite_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PathConstraintPath_AddRef(void *_this);
            __JPH_RefTarget_JPH_PathConstraintPath_AddRef(__JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::PathConstraintPathHermite::PathConstraintPathHermite`.
        public Const_PathConstraintPathHermite(Const_PathConstraintPathHermite _other) : this(new _ByValue_PathConstraintPathHermite(_other)) {}

        /// Generated from constructor `JPH::PathConstraintPathHermite::PathConstraintPathHermite`.
        public Const_PathConstraintPathHermite(PathConstraintPathHermite _other) : this((Const_PathConstraintPathHermite)_other) {}

        /// Generated from method `JPH::PathConstraintPathHermite::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PathConstraintPathHermite_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PathConstraintPathHermite_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PathConstraintPathHermite_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_PathConstraintPathHermite_size_t(inCount);
        }

        /// Generated from method `JPH::PathConstraintPathHermite::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPathHermite_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPathHermite_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PathConstraintPathHermite_void_ptr(void *inPointer);
            __Jolt_delete_JPH_PathConstraintPathHermite_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PathConstraintPathHermite::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPathHermite_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPathHermite_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PathConstraintPathHermite_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_PathConstraintPathHermite_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PathConstraintPathHermite::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PathConstraintPathHermite_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PathConstraintPathHermite_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PathConstraintPathHermite_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_PathConstraintPathHermite_size_t(inCount);
        }

        /// Generated from method `JPH::PathConstraintPathHermite::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PathConstraintPathHermite::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PathConstraintPathHermite::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PathConstraintPathHermite_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PathConstraintPathHermite_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PathConstraintPathHermite_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_PathConstraintPathHermite_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PathConstraintPathHermite::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPathHermite_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPathHermite_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PathConstraintPathHermite_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_PathConstraintPathHermite_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::PathConstraintPathHermite::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PathConstraintPathHermite_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PathConstraintPathHermite_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PathConstraintPathHermite_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_PathConstraintPathHermite_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PathConstraintPathHermite::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_PathConstraintPathHermite_void_ptr_void_ptr(inPointer, inPlace);
        }

        // See PathConstraintPath::GetPathMaxFraction
        /// Generated from method `JPH::PathConstraintPathHermite::GetPathMaxFraction`.
        public unsafe float GetPathMaxFraction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_GetPathMaxFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_GetPathMaxFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_PathConstraintPathHermite_GetPathMaxFraction(_Underlying *_this);
            return __JPH_PathConstraintPathHermite_GetPathMaxFraction(_UnderlyingPtr);
        }

        // See PathConstraintPath::GetClosestPoint
        /// Generated from method `JPH::PathConstraintPathHermite::GetClosestPoint`.
        public unsafe float GetClosestPoint(JPH.Const_Vec3 inPosition, float inFractionHint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_GetClosestPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_GetClosestPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_PathConstraintPathHermite_GetClosestPoint(_Underlying *_this, JPH.Vec3._Underlying *inPosition, float inFractionHint);
            return __JPH_PathConstraintPathHermite_GetClosestPoint(_UnderlyingPtr, inPosition._UnderlyingPtr, inFractionHint);
        }

        // See PathConstraintPath::GetPointOnPath
        /// Generated from method `JPH::PathConstraintPathHermite::GetPointOnPath`.
        public unsafe void GetPointOnPath(float inFraction, JPH.Vec3 outPathPosition, JPH.Vec3 outPathTangent, JPH.Vec3 outPathNormal, JPH.Vec3 outPathBinormal)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_GetPointOnPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_GetPointOnPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PathConstraintPathHermite_GetPointOnPath(_Underlying *_this, float inFraction, JPH.Vec3._Underlying *outPathPosition, JPH.Vec3._Underlying *outPathTangent, JPH.Vec3._Underlying *outPathNormal, JPH.Vec3._Underlying *outPathBinormal);
            __JPH_PathConstraintPathHermite_GetPointOnPath(_UnderlyingPtr, inFraction, outPathPosition._UnderlyingPtr, outPathTangent._UnderlyingPtr, outPathNormal._UnderlyingPtr, outPathBinormal._UnderlyingPtr);
        }

        /// Generated from method `JPH::PathConstraintPathHermite::IsLooping`.
        public unsafe bool IsLooping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_IsLooping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_IsLooping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_PathConstraintPathHermite_IsLooping(_Underlying *_this);
            return __JPH_PathConstraintPathHermite_IsLooping(_UnderlyingPtr) != 0;
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::PathConstraintPathHermite::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PathConstraintPathHermite_SetEmbedded(_Underlying *_this);
            __JPH_PathConstraintPathHermite_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::PathConstraintPathHermite::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_PathConstraintPathHermite_GetRefCount(_Underlying *_this);
            return __JPH_PathConstraintPathHermite_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::PathConstraintPathHermite::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PathConstraintPathHermite_AddRef(_Underlying *_this);
            __JPH_PathConstraintPathHermite_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::PathConstraintPathHermite::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PathConstraintPathHermite_Release(_Underlying *_this);
            __JPH_PathConstraintPathHermite_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::PathConstraintPathHermite::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_PathConstraintPathHermite_sInternalGetRefCountOffset();
            return __JPH_PathConstraintPathHermite_sInternalGetRefCountOffset();
        }

        /// Generated from class `JPH::PathConstraintPathHermite::Point`.
        /// This is the const half of the class.
        public class Const_Point : JPH.Object<Const_Point>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_PathConstraintPathHermite_Point_Destroy(_Underlying *_this);
                __JPH_PathConstraintPathHermite_Point_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Point() {Dispose(false);}

            ///< Position on the path
            public unsafe JPH.Const_Vec3 mPosition
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Vec3._Underlying *__JPH_PathConstraintPathHermite_Point_Get_mPosition(_Underlying *_this);
                    JPH.Const_Vec3 __ret;
                    __ret = new(__JPH_PathConstraintPathHermite_Point_Get_mPosition(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Tangent of the path, does not need to be normalized (in the direction of the path)
            public unsafe JPH.Const_Vec3 mTangent
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_Get_mTangent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_Get_mTangent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Vec3._Underlying *__JPH_PathConstraintPathHermite_Point_Get_mTangent(_Underlying *_this);
                    JPH.Const_Vec3 __ret;
                    __ret = new(__JPH_PathConstraintPathHermite_Point_Get_mTangent(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Normal of the path (together with the tangent along the curve this forms a basis for the constraint)
            public unsafe JPH.Const_Vec3 mNormal
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_Get_mNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_Get_mNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Vec3._Underlying *__JPH_PathConstraintPathHermite_Point_Get_mNormal(_Underlying *_this);
                    JPH.Const_Vec3 __ret;
                    __ret = new(__JPH_PathConstraintPathHermite_Point_Get_mNormal(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Const_Point(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Point() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.PathConstraintPathHermite.Point._Underlying *__JPH_PathConstraintPathHermite_Point_DefaultConstruct();
                _UnderlyingPtr = __JPH_PathConstraintPathHermite_Point_DefaultConstruct();
            }

            /// Constructs `JPH::PathConstraintPathHermite::Point` elementwise.
            public unsafe Const_Point(JPH.Const_Vec3 mPosition, JPH.Const_Vec3 mTangent, JPH.Const_Vec3 mNormal) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.PathConstraintPathHermite.Point._Underlying *__JPH_PathConstraintPathHermite_Point_ConstructFrom(JPH.Vec3._Underlying *mPosition, JPH.Vec3._Underlying *mTangent, JPH.Vec3._Underlying *mNormal);
                _UnderlyingPtr = __JPH_PathConstraintPathHermite_Point_ConstructFrom(mPosition._UnderlyingPtr, mTangent._UnderlyingPtr, mNormal._UnderlyingPtr);
                _KeepAlive(mPosition);
                _KeepAlive(mTangent);
                _KeepAlive(mNormal);
            }

            /// Generated from constructor `JPH::PathConstraintPathHermite::Point::Point`.
            public unsafe Const_Point(JPH.PathConstraintPathHermite.Const_Point _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.PathConstraintPathHermite.Point._Underlying *__JPH_PathConstraintPathHermite_Point_ConstructFromAnother(JPH.PathConstraintPathHermite.Point._Underlying *_other);
                _UnderlyingPtr = __JPH_PathConstraintPathHermite_Point_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::PathConstraintPathHermite::Point::Point`.
            public Const_Point(Point _other) : this((Const_Point)_other) {}

            /// Generated from method `JPH::PathConstraintPathHermite::Point::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PathConstraintPathHermite_Point_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PathConstraintPathHermite_Point_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_PathConstraintPathHermite_Point_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_PathConstraintPathHermite_Point_size_t(inCount);
            }

            /// Generated from method `JPH::PathConstraintPathHermite::Point::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr(void *inPointer);
                __Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr(inPointer);
            }

            /// Generated from method `JPH::PathConstraintPathHermite::Point::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::PathConstraintPathHermite::Point::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PathConstraintPathHermite_Point_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PathConstraintPathHermite_Point_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_PathConstraintPathHermite_Point_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_PathConstraintPathHermite_Point_size_t(inCount);
            }

            /// Generated from method `JPH::PathConstraintPathHermite::Point::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr(inPointer);
            }

            /// Generated from method `JPH::PathConstraintPathHermite::Point::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::PathConstraintPathHermite::Point::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PathConstraintPathHermite_Point_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PathConstraintPathHermite_Point_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_PathConstraintPathHermite_Point_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_PathConstraintPathHermite_Point_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::PathConstraintPathHermite::Point::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_PathConstraintPathHermite_Point_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::PathConstraintPathHermite::Point::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PathConstraintPathHermite_Point_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PathConstraintPathHermite_Point_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_PathConstraintPathHermite_Point_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_PathConstraintPathHermite_Point_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::PathConstraintPathHermite::Point::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_PathConstraintPathHermite_Point_void_ptr_void_ptr(inPointer, inPlace);
            }
        }

        /// Generated from class `JPH::PathConstraintPathHermite::Point`.
        /// This is the non-const half of the class.
        public class Point : Const_Point
        {
            ///< Position on the path
            public new unsafe JPH.Vec3 mPosition
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Vec3._Underlying *__JPH_PathConstraintPathHermite_Point_GetMutable_mPosition(_Underlying *_this);
                    JPH.Vec3 __ret;
                    __ret = new(__JPH_PathConstraintPathHermite_Point_GetMutable_mPosition(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Tangent of the path, does not need to be normalized (in the direction of the path)
            public new unsafe JPH.Vec3 mTangent
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_GetMutable_mTangent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_GetMutable_mTangent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Vec3._Underlying *__JPH_PathConstraintPathHermite_Point_GetMutable_mTangent(_Underlying *_this);
                    JPH.Vec3 __ret;
                    __ret = new(__JPH_PathConstraintPathHermite_Point_GetMutable_mTangent(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            ///< Normal of the path (together with the tangent along the curve this forms a basis for the constraint)
            public new unsafe JPH.Vec3 mNormal
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_GetMutable_mNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_GetMutable_mNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Vec3._Underlying *__JPH_PathConstraintPathHermite_Point_GetMutable_mNormal(_Underlying *_this);
                    JPH.Vec3 __ret;
                    __ret = new(__JPH_PathConstraintPathHermite_Point_GetMutable_mNormal(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Point(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Point() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.PathConstraintPathHermite.Point._Underlying *__JPH_PathConstraintPathHermite_Point_DefaultConstruct();
                _UnderlyingPtr = __JPH_PathConstraintPathHermite_Point_DefaultConstruct();
            }

            /// Constructs `JPH::PathConstraintPathHermite::Point` elementwise.
            public unsafe Point(JPH.Const_Vec3 mPosition, JPH.Const_Vec3 mTangent, JPH.Const_Vec3 mNormal) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.PathConstraintPathHermite.Point._Underlying *__JPH_PathConstraintPathHermite_Point_ConstructFrom(JPH.Vec3._Underlying *mPosition, JPH.Vec3._Underlying *mTangent, JPH.Vec3._Underlying *mNormal);
                _UnderlyingPtr = __JPH_PathConstraintPathHermite_Point_ConstructFrom(mPosition._UnderlyingPtr, mTangent._UnderlyingPtr, mNormal._UnderlyingPtr);
                _KeepAlive(mPosition);
                _KeepAlive(mTangent);
                _KeepAlive(mNormal);
            }

            /// Generated from constructor `JPH::PathConstraintPathHermite::Point::Point`.
            public unsafe Point(JPH.PathConstraintPathHermite.Const_Point _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.PathConstraintPathHermite.Point._Underlying *__JPH_PathConstraintPathHermite_Point_ConstructFromAnother(JPH.PathConstraintPathHermite.Point._Underlying *_other);
                _UnderlyingPtr = __JPH_PathConstraintPathHermite_Point_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::PathConstraintPathHermite::Point::Point`.
            public Point(Point _other) : this((Const_Point)_other) {}

            /// Generated from method `JPH::PathConstraintPathHermite::Point::operator=`.
            public unsafe JPH.PathConstraintPathHermite.Point Assign(JPH.PathConstraintPathHermite.Const_Point _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_Point_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.PathConstraintPathHermite.Point._Underlying *__JPH_PathConstraintPathHermite_Point_AssignFromAnother(_Underlying *_this, JPH.PathConstraintPathHermite.Point._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_PathConstraintPathHermite_Point_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `Point` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Point`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Point`/`Const_Point` directly.
        public class _InOptMut_Point
        {
            public Point? Opt;

            public _InOptMut_Point() {}
            public _InOptMut_Point(Point value) {Opt = value;}
            public static implicit operator _InOptMut_Point(Point value) {return new(value);}
        }

        /// This is used for optional parameters of class `Point` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Point`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Point`/`Const_Point` to pass it to the function.
        public class _InOptConst_Point
        {
            public Const_Point? Opt;

            public _InOptConst_Point() {}
            public _InOptConst_Point(Const_Point value) {Opt = value;}
            public static implicit operator _InOptConst_Point(Const_Point value) {return new(value);}
        }
    }

    /// A path that follows a Hermite spline
    /// Generated from class `JPH::PathConstraintPathHermite`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::PathConstraintPath`
    ///   Indirect: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::PathConstraintPath>`
    /// This is the non-const half of the class.
    public class PathConstraintPathHermite : Const_PathConstraintPathHermite
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(PathConstraintPathHermite self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_PathConstraintPathHermite_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_PathConstraintPathHermite_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.RefTarget_JPHPathConstraintPath(PathConstraintPathHermite self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHPathConstraintPath._Underlying *__JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_Underlying *_this);
            JPH.RefTarget_JPHPathConstraintPath ret = new(__JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.PathConstraintPath(PathConstraintPathHermite self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PathConstraintPath._Underlying *__JPH_PathConstraintPathHermite_UpcastTo_JPH_PathConstraintPath(_Underlying *_this);
            JPH.PathConstraintPath ret = new(__JPH_PathConstraintPathHermite_UpcastTo_JPH_PathConstraintPath(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe PathConstraintPathHermite(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe PathConstraintPathHermite() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PathConstraintPathHermite._Underlying *__JPH_PathConstraintPathHermite_DefaultConstruct();
            _UnderlyingPtr = __JPH_PathConstraintPathHermite_DefaultConstruct();
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PathConstraintPath_AddRef(void *_this);
            __JPH_RefTarget_JPH_PathConstraintPath_AddRef(__JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_UnderlyingPtr));
        }

        /// Generated from constructor `JPH::PathConstraintPathHermite::PathConstraintPathHermite`.
        public unsafe PathConstraintPathHermite(JPH._ByValue_PathConstraintPathHermite _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PathConstraintPathHermite._Underlying *__JPH_PathConstraintPathHermite_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.PathConstraintPathHermite._Underlying *_other);
            _UnderlyingPtr = __JPH_PathConstraintPathHermite_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PathConstraintPath_AddRef(void *_this);
            __JPH_RefTarget_JPH_PathConstraintPath_AddRef(__JPH_PathConstraintPathHermite_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_UnderlyingPtr));
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `JPH::PathConstraintPathHermite::PathConstraintPathHermite`.
        public PathConstraintPathHermite(Const_PathConstraintPathHermite _other) : this(new _ByValue_PathConstraintPathHermite(_other)) {}

        /// Generated from constructor `JPH::PathConstraintPathHermite::PathConstraintPathHermite`.
        public PathConstraintPathHermite(PathConstraintPathHermite _other) : this((Const_PathConstraintPathHermite)_other) {}

        /// Generated from method `JPH::PathConstraintPathHermite::operator=`.
        public unsafe JPH.PathConstraintPathHermite Assign(JPH._ByValue_PathConstraintPathHermite _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.PathConstraintPathHermite._Underlying *__JPH_PathConstraintPathHermite_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.PathConstraintPathHermite._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__JPH_PathConstraintPathHermite_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Adds a point to the path
        /// Generated from method `JPH::PathConstraintPathHermite::AddPoint`.
        public unsafe void AddPoint(JPH.Const_Vec3 inPosition, JPH.Const_Vec3 inTangent, JPH.Const_Vec3 inNormal)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_AddPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_AddPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PathConstraintPathHermite_AddPoint(_Underlying *_this, JPH.Vec3._Underlying *inPosition, JPH.Vec3._Underlying *inTangent, JPH.Vec3._Underlying *inNormal);
            __JPH_PathConstraintPathHermite_AddPoint(_UnderlyingPtr, inPosition._UnderlyingPtr, inTangent._UnderlyingPtr, inNormal._UnderlyingPtr);
        }

        /// If the path is looping or not. If a path is looping, the first and last point are automatically connected to each other. They should not be the same points.
        /// Generated from method `JPH::PathConstraintPathHermite::SetIsLooping`.
        public unsafe void SetIsLooping(bool inIsLooping)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPathHermite_SetIsLooping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPathHermite_SetIsLooping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PathConstraintPathHermite_SetIsLooping(_Underlying *_this, byte inIsLooping);
            __JPH_PathConstraintPathHermite_SetIsLooping(_UnderlyingPtr, inIsLooping ? (byte)1 : (byte)0);
        }
    }

    /// This is used as a function parameter when the underlying function receives `PathConstraintPathHermite` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `PathConstraintPathHermite`/`Const_PathConstraintPathHermite` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_PathConstraintPathHermite
    {
        #pragma warning disable CS0649
        internal readonly Const_PathConstraintPathHermite? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_PathConstraintPathHermite() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_PathConstraintPathHermite(Const_PathConstraintPathHermite new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_PathConstraintPathHermite(Const_PathConstraintPathHermite arg) {return new(arg);}
        public _ByValue_PathConstraintPathHermite(JPH._Moved<PathConstraintPathHermite> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_PathConstraintPathHermite(JPH._Moved<PathConstraintPathHermite> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `PathConstraintPathHermite` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_PathConstraintPathHermite`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PathConstraintPathHermite`/`Const_PathConstraintPathHermite` directly.
    public class _InOptMut_PathConstraintPathHermite
    {
        public PathConstraintPathHermite? Opt;

        public _InOptMut_PathConstraintPathHermite() {}
        public _InOptMut_PathConstraintPathHermite(PathConstraintPathHermite value) {Opt = value;}
        public static implicit operator _InOptMut_PathConstraintPathHermite(PathConstraintPathHermite value) {return new(value);}
    }

    /// This is used for optional parameters of class `PathConstraintPathHermite` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_PathConstraintPathHermite`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PathConstraintPathHermite`/`Const_PathConstraintPathHermite` to pass it to the function.
    public class _InOptConst_PathConstraintPathHermite
    {
        public Const_PathConstraintPathHermite? Opt;

        public _InOptConst_PathConstraintPathHermite() {}
        public _InOptConst_PathConstraintPathHermite(Const_PathConstraintPathHermite value) {Opt = value;}
        public static implicit operator _InOptConst_PathConstraintPathHermite(Const_PathConstraintPathHermite value) {return new(value);}
    }
}
