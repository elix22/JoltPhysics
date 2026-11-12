// machine generated, do not edit
public static partial class JPH
{
    /// The path for a path constraint. It allows attaching two bodies to each other while giving the second body the freedom to move along a path relative to the first.
    /// Generated from class `JPH::PathConstraintPath`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::PathConstraintPath>`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::PathConstraintPathHermite`
    /// This is the const half of the class.
    public class Const_PathConstraintPath : JPH.Object<Const_PathConstraintPath>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__JPH_PathConstraintPath_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_Underlying *_this);
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_PathConstraintPath_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_RefTarget_JPH_PathConstraintPath_Release(void *_this);
            __JPH_RefTarget_JPH_PathConstraintPath_Release(__JPH_PathConstraintPath_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_UnderlyingPtr));
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_PathConstraintPath() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_SerializableObject(Const_PathConstraintPath self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_SerializableObject._Underlying *__JPH_PathConstraintPath_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.Const_SerializableObject ret = new(__JPH_PathConstraintPath_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHPathConstraintPath(Const_PathConstraintPath self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_RefTarget_JPHPathConstraintPath._Underlying *__JPH_PathConstraintPath_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_Underlying *_this);
            JPH.Const_RefTarget_JPHPathConstraintPath ret = new(__JPH_PathConstraintPath_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_PathConstraintPath(JPH.Const_SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_PathConstraintPath_StaticDowncastFrom_JPH_SerializableObject(JPH.Const_SerializableObject._Underlying *_this);
            Const_PathConstraintPath ret = new(__JPH_PathConstraintPath_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_PathConstraintPath(JPH.Const_RefTarget_JPHPathConstraintPath parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_StaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_StaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_PathConstraintPath_StaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath(JPH.Const_RefTarget_JPHPathConstraintPath._Underlying *_this);
            Const_PathConstraintPath ret = new(__JPH_PathConstraintPath_StaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_PathConstraintPath(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `JPH::PathConstraintPath::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PathConstraintPath_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PathConstraintPath_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PathConstraintPath_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_PathConstraintPath_size_t(inCount);
        }

        /// Generated from method `JPH::PathConstraintPath::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPath_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPath_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PathConstraintPath_void_ptr(void *inPointer);
            __Jolt_delete_JPH_PathConstraintPath_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PathConstraintPath::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPath_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPath_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PathConstraintPath_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_PathConstraintPath_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PathConstraintPath::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PathConstraintPath_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PathConstraintPath_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PathConstraintPath_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_PathConstraintPath_size_t(inCount);
        }

        /// Generated from method `JPH::PathConstraintPath::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPath_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPath_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PathConstraintPath_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_PathConstraintPath_void_ptr(inPointer);
        }

        /// Generated from method `JPH::PathConstraintPath::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPath_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPath_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PathConstraintPath_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_PathConstraintPath_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::PathConstraintPath::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_PathConstraintPath_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_PathConstraintPath_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_PathConstraintPath_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_PathConstraintPath_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PathConstraintPath::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPath_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_PathConstraintPath_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_PathConstraintPath_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_PathConstraintPath_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::PathConstraintPath::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_PathConstraintPath_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_PathConstraintPath_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_PathConstraintPath_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_PathConstraintPath_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::PathConstraintPath::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPath_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_PathConstraintPath_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_PathConstraintPath_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_PathConstraintPath_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Gets the max fraction along the path. I.e. sort of the length of the path.
        /// Generated from method `JPH::PathConstraintPath::GetPathMaxFraction`.
        public unsafe float GetPathMaxFraction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_GetPathMaxFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_GetPathMaxFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_PathConstraintPath_GetPathMaxFraction(_Underlying *_this);
            return __JPH_PathConstraintPath_GetPathMaxFraction(_UnderlyingPtr);
        }

        /// Get the globally closest point on the curve (Could be slow!)
        /// @param inPosition Position to find closest point for
        /// @param inFractionHint Last known fraction along the path (can be used to speed up the search)
        /// @return Fraction of closest point along the path
        /// Generated from method `JPH::PathConstraintPath::GetClosestPoint`.
        public unsafe float GetClosestPoint(JPH.Const_Vec3 inPosition, float inFractionHint)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_GetClosestPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_GetClosestPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static float __JPH_PathConstraintPath_GetClosestPoint(_Underlying *_this, JPH.Vec3._Underlying *inPosition, float inFractionHint);
            return __JPH_PathConstraintPath_GetClosestPoint(_UnderlyingPtr, inPosition._UnderlyingPtr, inFractionHint);
        }

        /// Given the fraction along the path, get the point, tangent and normal.
        /// @param inFraction Fraction along the path [0, GetPathMaxFraction()].
        /// @param outPathPosition Returns the closest position to inSearchPosition on the path.
        /// @param outPathTangent Returns the tangent to the path at outPathPosition (the vector that follows the direction of the path)
        /// @param outPathNormal Return the normal to the path at outPathPosition (a vector that's perpendicular to outPathTangent)
        /// @param outPathBinormal Returns the binormal to the path at outPathPosition (a vector so that normal cross tangent = binormal)
        /// Generated from method `JPH::PathConstraintPath::GetPointOnPath`.
        public unsafe void GetPointOnPath(float inFraction, JPH.Vec3 outPathPosition, JPH.Vec3 outPathTangent, JPH.Vec3 outPathNormal, JPH.Vec3 outPathBinormal)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_GetPointOnPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_GetPointOnPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PathConstraintPath_GetPointOnPath(_Underlying *_this, float inFraction, JPH.Vec3._Underlying *outPathPosition, JPH.Vec3._Underlying *outPathTangent, JPH.Vec3._Underlying *outPathNormal, JPH.Vec3._Underlying *outPathBinormal);
            __JPH_PathConstraintPath_GetPointOnPath(_UnderlyingPtr, inFraction, outPathPosition._UnderlyingPtr, outPathTangent._UnderlyingPtr, outPathNormal._UnderlyingPtr, outPathBinormal._UnderlyingPtr);
        }

        /// Generated from method `JPH::PathConstraintPath::IsLooping`.
        public unsafe bool IsLooping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_IsLooping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_IsLooping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __JPH_PathConstraintPath_IsLooping(_Underlying *_this);
            return __JPH_PathConstraintPath_IsLooping(_UnderlyingPtr) != 0;
        }

        /// Draw the path relative to inBaseTransform. Used for debug purposes.
        /// Generated from method `JPH::PathConstraintPath::DrawPath`.
        public unsafe void DrawPath(JPH.DebugRenderer? inRenderer, JPH.Const_Mat44 inBaseTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_DrawPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_DrawPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PathConstraintPath_DrawPath(_Underlying *_this, JPH.DebugRenderer._Underlying *inRenderer, JPH.Const_Mat44._Underlying *inBaseTransform);
            __JPH_PathConstraintPath_DrawPath(_UnderlyingPtr, inRenderer is not null ? inRenderer._UnderlyingPtr : null, inBaseTransform._UnderlyingPtr);
        }

        /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
        /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
        /// the object and at that point in time it is checked that no references are left to the structure.
        /// Generated from method `JPH::PathConstraintPath::SetEmbedded`.
        public unsafe void SetEmbedded()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PathConstraintPath_SetEmbedded(_Underlying *_this);
            __JPH_PathConstraintPath_SetEmbedded(_UnderlyingPtr);
        }

        /// Get current refcount of this object
        /// Generated from method `JPH::PathConstraintPath::GetRefCount`.
        public unsafe uint GetRefCount()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static uint __JPH_PathConstraintPath_GetRefCount(_Underlying *_this);
            return __JPH_PathConstraintPath_GetRefCount(_UnderlyingPtr);
        }

        /// Add or release a reference to this object
        /// Generated from method `JPH::PathConstraintPath::AddRef`.
        public unsafe void AddRef()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PathConstraintPath_AddRef(_Underlying *_this);
            __JPH_PathConstraintPath_AddRef(_UnderlyingPtr);
        }

        /// Generated from method `JPH::PathConstraintPath::Release`.
        public unsafe void Release()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PathConstraintPath_Release(_Underlying *_this);
            __JPH_PathConstraintPath_Release(_UnderlyingPtr);
        }

        /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
        /// Generated from method `JPH::PathConstraintPath::sInternalGetRefCountOffset`.
        public static int SInternalGetRefCountOffset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __JPH_PathConstraintPath_sInternalGetRefCountOffset();
            return __JPH_PathConstraintPath_sInternalGetRefCountOffset();
        }
    }

    /// The path for a path constraint. It allows attaching two bodies to each other while giving the second body the freedom to move along a path relative to the first.
    /// Generated from class `JPH::PathConstraintPath`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::SerializableObject`
    ///     `JPH::RefTarget<JPH::PathConstraintPath>`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::PathConstraintPathHermite`
    /// This is the non-const half of the class.
    public class PathConstraintPath : Const_PathConstraintPath
    {
        // Upcasts:
        public static unsafe implicit operator JPH.SerializableObject(PathConstraintPath self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_UpcastTo_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SerializableObject._Underlying *__JPH_PathConstraintPath_UpcastTo_JPH_SerializableObject(_Underlying *_this);
            JPH.SerializableObject ret = new(__JPH_PathConstraintPath_UpcastTo_JPH_SerializableObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_SerializableObject(PathConstraintPath self)
            => (JPH.Const_SerializableObject)(JPH.Const_PathConstraintPath)self;
        public static unsafe implicit operator JPH.RefTarget_JPHPathConstraintPath(PathConstraintPath self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.RefTarget_JPHPathConstraintPath._Underlying *__JPH_PathConstraintPath_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(_Underlying *_this);
            JPH.RefTarget_JPHPathConstraintPath ret = new(__JPH_PathConstraintPath_UpcastTo_JPH_RefTarget_JPH_PathConstraintPath(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_RefTarget_JPHPathConstraintPath(PathConstraintPath self)
            => (JPH.Const_RefTarget_JPHPathConstraintPath)(JPH.Const_PathConstraintPath)self;

        // Downcasts:
        public static unsafe explicit operator PathConstraintPath(JPH.SerializableObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_StaticDowncastFrom_JPH_SerializableObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_PathConstraintPath_StaticDowncastFrom_JPH_SerializableObject(JPH.SerializableObject._Underlying *_this);
            PathConstraintPath ret = new(__JPH_PathConstraintPath_StaticDowncastFrom_JPH_SerializableObject(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator PathConstraintPath(JPH.RefTarget_JPHPathConstraintPath parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_StaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_StaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_PathConstraintPath_StaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath(JPH.RefTarget_JPHPathConstraintPath._Underlying *_this);
            PathConstraintPath ret = new(__JPH_PathConstraintPath_StaticDowncastFrom_JPH_RefTarget_JPH_PathConstraintPath(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe PathConstraintPath(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// If the path is looping or not. If a path is looping, the first and last point are automatically connected to each other. They should not be the same points.
        /// Generated from method `JPH::PathConstraintPath::SetIsLooping`.
        public unsafe void SetIsLooping(bool inIsLooping)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_PathConstraintPath_SetIsLooping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_PathConstraintPath_SetIsLooping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_PathConstraintPath_SetIsLooping(_Underlying *_this, byte inIsLooping);
            __JPH_PathConstraintPath_SetIsLooping(_UnderlyingPtr, inIsLooping ? (byte)1 : (byte)0);
        }
    }

    /// This is used for optional parameters of class `PathConstraintPath` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_PathConstraintPath`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PathConstraintPath`/`Const_PathConstraintPath` directly.
    public class _InOptMut_PathConstraintPath
    {
        public PathConstraintPath? Opt;

        public _InOptMut_PathConstraintPath() {}
        public _InOptMut_PathConstraintPath(PathConstraintPath value) {Opt = value;}
        public static implicit operator _InOptMut_PathConstraintPath(PathConstraintPath value) {return new(value);}
    }

    /// This is used for optional parameters of class `PathConstraintPath` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_PathConstraintPath`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `PathConstraintPath`/`Const_PathConstraintPath` to pass it to the function.
    public class _InOptConst_PathConstraintPath
    {
        public Const_PathConstraintPath? Opt;

        public _InOptConst_PathConstraintPath() {}
        public _InOptConst_PathConstraintPath(Const_PathConstraintPath value) {Opt = value;}
        public static implicit operator _InOptConst_PathConstraintPath(Const_PathConstraintPath value) {return new(value);}
    }
}
