// machine generated, do not edit
public static partial class JPH
{
    /// Inherit from this class to simplify implementing a debug renderer, start with this implementation:
    ///
    ///		class MyDebugRenderer : public JPH::DebugRendererSimple
    ///		{
    ///		public:
    ///			virtual void DrawLine(JPH::RVec3Arg inFrom, JPH::RVec3Arg inTo, JPH::ColorArg inColor) override
    ///			{
    ///				// Implement
    ///			}
    ///
    ///			virtual void DrawTriangle(JPH::RVec3Arg inV1, JPH::RVec3Arg inV2, JPH::RVec3Arg inV3, JPH::ColorArg inColor, ECastShadow inCastShadow) override
    ///			{
    ///				// Implement
    ///			}
    ///
    ///			virtual void DrawText3D(JPH::RVec3Arg inPosition, const string_view &inString, JPH::ColorArg inColor, float inHeight) override
    ///			{
    ///				// Implement
    ///			}
    ///		};
    ///
    /// Note that this class is meant to be a quick start for implementing a debug renderer, it is not the most efficient way to implement a debug renderer.
    /// Generated from class `JPH::DebugRendererSimple`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DebugRenderer`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `RecordingDebugRenderer`
    /// This is the const half of the class.
    public class Const_DebugRendererSimple : JPH.Object<Const_DebugRendererSimple>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_Destroy(_Underlying *_this);
            __JPH_DebugRendererSimple_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_DebugRendererSimple() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_DebugRendererSimple self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_DebugRendererSimple_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_DebugRendererSimple_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.Const_DebugRenderer(Const_DebugRendererSimple self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_UpcastTo_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_UpcastTo_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_DebugRenderer._Underlying *__JPH_DebugRendererSimple_UpcastTo_JPH_DebugRenderer(_Underlying *_this);
            JPH.Const_DebugRenderer ret = new(__JPH_DebugRendererSimple_UpcastTo_JPH_DebugRenderer(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_DebugRendererSimple(JPH.Const_NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_DebugRendererSimple_StaticDowncastFrom_JPH_NonCopyable(JPH.Const_NonCopyable._Underlying *_this);
            Const_DebugRendererSimple ret = new(__JPH_DebugRendererSimple_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_DebugRendererSimple(JPH.Const_DebugRenderer parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_StaticDowncastFrom_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_StaticDowncastFrom_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_DebugRendererSimple_StaticDowncastFrom_JPH_DebugRenderer(JPH.Const_DebugRenderer._Underlying *_this);
            Const_DebugRendererSimple ret = new(__JPH_DebugRendererSimple_StaticDowncastFrom_JPH_DebugRenderer(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        /// Singleton instance
        public static unsafe JPH.DebugRenderer? SInstance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_Get_sInstance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_Get_sInstance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer._Underlying **__JPH_DebugRendererSimple_Get_sInstance();
                var ptr = __JPH_DebugRendererSimple_Get_sInstance();
                JPH.DebugRenderer? value = null;
                if (*ptr is not null)
                    value = new(*ptr, is_owning: false);
                return value;
            }
        }

        internal unsafe Const_DebugRendererSimple(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `JPH::DebugRendererSimple::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_DebugRendererSimple_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_DebugRendererSimple_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_DebugRendererSimple_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_DebugRendererSimple_size_t(inCount);
        }

        /// Generated from method `JPH::DebugRendererSimple::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DebugRendererSimple_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DebugRendererSimple_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_DebugRendererSimple_void_ptr(void *inPointer);
            __Jolt_delete_JPH_DebugRendererSimple_void_ptr(inPointer);
        }

        /// Generated from method `JPH::DebugRendererSimple::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DebugRendererSimple_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DebugRendererSimple_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_DebugRendererSimple_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_DebugRendererSimple_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::DebugRendererSimple::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_DebugRendererSimple_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_DebugRendererSimple_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_DebugRendererSimple_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_DebugRendererSimple_size_t(inCount);
        }

        /// Generated from method `JPH::DebugRendererSimple::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRendererSimple_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRendererSimple_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_DebugRendererSimple_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_DebugRendererSimple_void_ptr(inPointer);
        }

        /// Generated from method `JPH::DebugRendererSimple::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRendererSimple_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRendererSimple_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_DebugRendererSimple_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_DebugRendererSimple_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::DebugRendererSimple::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_DebugRendererSimple_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_DebugRendererSimple_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_DebugRendererSimple_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_DebugRendererSimple_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::DebugRendererSimple::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DebugRendererSimple_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DebugRendererSimple_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_DebugRendererSimple_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_DebugRendererSimple_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::DebugRendererSimple::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_DebugRendererSimple_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_DebugRendererSimple_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_DebugRendererSimple_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_DebugRendererSimple_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::DebugRendererSimple::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRendererSimple_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRendererSimple_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_DebugRendererSimple_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_DebugRendererSimple_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Calculate bounding box for a batch of triangles
        /// Generated from method `JPH::DebugRendererSimple::sCalculateBounds`.
        public static unsafe JPH.AABox SCalculateBounds(JPH.DebugRenderer.Const_Vertex? inVertices, int inVertexCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_sCalculateBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_sCalculateBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_DebugRendererSimple_sCalculateBounds(JPH.DebugRenderer.Const_Vertex._Underlying *inVertices, int inVertexCount);
            return new(__JPH_DebugRendererSimple_sCalculateBounds(inVertices is not null ? inVertices._UnderlyingPtr : null, inVertexCount), is_owning: true);
        }
    }

    /// Inherit from this class to simplify implementing a debug renderer, start with this implementation:
    ///
    ///		class MyDebugRenderer : public JPH::DebugRendererSimple
    ///		{
    ///		public:
    ///			virtual void DrawLine(JPH::RVec3Arg inFrom, JPH::RVec3Arg inTo, JPH::ColorArg inColor) override
    ///			{
    ///				// Implement
    ///			}
    ///
    ///			virtual void DrawTriangle(JPH::RVec3Arg inV1, JPH::RVec3Arg inV2, JPH::RVec3Arg inV3, JPH::ColorArg inColor, ECastShadow inCastShadow) override
    ///			{
    ///				// Implement
    ///			}
    ///
    ///			virtual void DrawText3D(JPH::RVec3Arg inPosition, const string_view &inString, JPH::ColorArg inColor, float inHeight) override
    ///			{
    ///				// Implement
    ///			}
    ///		};
    ///
    /// Note that this class is meant to be a quick start for implementing a debug renderer, it is not the most efficient way to implement a debug renderer.
    /// Generated from class `JPH::DebugRendererSimple`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DebugRenderer`
    ///   Indirect: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `RecordingDebugRenderer`
    /// This is the non-const half of the class.
    public class DebugRendererSimple : Const_DebugRendererSimple
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(DebugRendererSimple self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_DebugRendererSimple_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_DebugRendererSimple_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator JPH.DebugRenderer(DebugRendererSimple self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_UpcastTo_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_UpcastTo_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugRenderer._Underlying *__JPH_DebugRendererSimple_UpcastTo_JPH_DebugRenderer(_Underlying *_this);
            JPH.DebugRenderer ret = new(__JPH_DebugRendererSimple_UpcastTo_JPH_DebugRenderer(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator DebugRendererSimple(JPH.NonCopyable parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_StaticDowncastFrom_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_DebugRendererSimple_StaticDowncastFrom_JPH_NonCopyable(JPH.NonCopyable._Underlying *_this);
            DebugRendererSimple ret = new(__JPH_DebugRendererSimple_StaticDowncastFrom_JPH_NonCopyable(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator DebugRendererSimple(JPH.DebugRenderer parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_StaticDowncastFrom_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_StaticDowncastFrom_JPH_DebugRenderer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__JPH_DebugRendererSimple_StaticDowncastFrom_JPH_DebugRenderer(JPH.DebugRenderer._Underlying *_this);
            DebugRendererSimple ret = new(__JPH_DebugRendererSimple_StaticDowncastFrom_JPH_DebugRenderer(parent._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe DebugRendererSimple(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Should be called every frame by the application to provide the camera position.
        /// This is used to determine the correct LOD for rendering.
        /// Generated from method `JPH::DebugRendererSimple::SetCameraPos`.
        public unsafe void SetCameraPos(JPH.Const_Vec3 inCameraPos)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_SetCameraPos", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_SetCameraPos", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_SetCameraPos(_Underlying *_this, JPH.Vec3._Underlying *inCameraPos);
            __JPH_DebugRendererSimple_SetCameraPos(_UnderlyingPtr, inCameraPos._UnderlyingPtr);
        }

        /// Fallback implementation that uses DrawLine to draw a triangle (override this if you have a version that renders solid triangles)
        /// Generated from method `JPH::DebugRendererSimple::DrawTriangle`.
        public unsafe void DrawTriangle(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow inCastShadow)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawTriangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawTriangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawTriangle(_Underlying *_this, JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow inCastShadow);
            __JPH_DebugRendererSimple_DrawTriangle(_UnderlyingPtr, inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr, inColor._UnderlyingPtr, inCastShadow);
        }

        /// Call once after frame is complete. Releases unused dynamically generated geometry assets.
        /// Generated from method `JPH::DebugRendererSimple::NextFrame`.
        public unsafe void NextFrame()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_NextFrame", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_NextFrame", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_NextFrame(_Underlying *_this);
            __JPH_DebugRendererSimple_NextFrame(_UnderlyingPtr);
        }

        /// Draw line
        /// Generated from method `JPH::DebugRendererSimple::DrawLine`.
        public unsafe void DrawLine(JPH.Const_Vec3 inFrom, JPH.Const_Vec3 inTo, JPH.Const_Color inColor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawLine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawLine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawLine(_Underlying *_this, JPH.Vec3._Underlying *inFrom, JPH.Vec3._Underlying *inTo, JPH.Color._Underlying *inColor);
            __JPH_DebugRendererSimple_DrawLine(_UnderlyingPtr, inFrom._UnderlyingPtr, inTo._UnderlyingPtr, inColor._UnderlyingPtr);
        }

        /// Draw a marker on a position
        /// Generated from method `JPH::DebugRendererSimple::DrawMarker`.
        public unsafe void DrawMarker(JPH.Const_Vec3 inPosition, JPH.Const_Color inColor, float inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawMarker", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawMarker", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawMarker(_Underlying *_this, JPH.Vec3._Underlying *inPosition, JPH.Color._Underlying *inColor, float inSize);
            __JPH_DebugRendererSimple_DrawMarker(_UnderlyingPtr, inPosition._UnderlyingPtr, inColor._UnderlyingPtr, inSize);
        }

        /// Draw an arrow
        /// Generated from method `JPH::DebugRendererSimple::DrawArrow`.
        public unsafe void DrawArrow(JPH.Const_Vec3 inFrom, JPH.Const_Vec3 inTo, JPH.Const_Color inColor, float inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawArrow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawArrow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawArrow(_Underlying *_this, JPH.Vec3._Underlying *inFrom, JPH.Vec3._Underlying *inTo, JPH.Color._Underlying *inColor, float inSize);
            __JPH_DebugRendererSimple_DrawArrow(_UnderlyingPtr, inFrom._UnderlyingPtr, inTo._UnderlyingPtr, inColor._UnderlyingPtr, inSize);
        }

        /// Draw coordinate system (3 arrows, x = red, y = green, z = blue)
        /// Generated from method `JPH::DebugRendererSimple::DrawCoordinateSystem`.
        /// Parameter `inSize` defaults to `1.0f`.
        public unsafe void DrawCoordinateSystem(JPH.Const_Mat44 inTransform, float? inSize = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawCoordinateSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawCoordinateSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawCoordinateSystem(_Underlying *_this, JPH.Const_Mat44._Underlying *inTransform, float *inSize);
            float __deref_inSize = inSize.GetValueOrDefault();
            __JPH_DebugRendererSimple_DrawCoordinateSystem(_UnderlyingPtr, inTransform._UnderlyingPtr, inSize.HasValue ? &__deref_inSize : null);
        }

        /// Draw a plane through inPoint with normal inNormal
        /// Generated from method `JPH::DebugRendererSimple::DrawPlane`.
        public unsafe void DrawPlane(JPH.Const_Vec3 inPoint, JPH.Const_Vec3 inNormal, JPH.Const_Color inColor, float inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawPlane(_Underlying *_this, JPH.Vec3._Underlying *inPoint, JPH.Vec3._Underlying *inNormal, JPH.Color._Underlying *inColor, float inSize);
            __JPH_DebugRendererSimple_DrawPlane(_UnderlyingPtr, inPoint._UnderlyingPtr, inNormal._UnderlyingPtr, inColor._UnderlyingPtr, inSize);
        }

        /// Draw wireframe triangle
        /// Generated from method `JPH::DebugRendererSimple::DrawWireTriangle`.
        public unsafe void DrawWireTriangle(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3, JPH.Const_Color inColor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawWireTriangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawWireTriangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawWireTriangle(_Underlying *_this, JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3, JPH.Color._Underlying *inColor);
            __JPH_DebugRendererSimple_DrawWireTriangle(_UnderlyingPtr, inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr, inColor._UnderlyingPtr);
        }

        /// Draw wireframe sphere
        /// Generated from method `JPH::DebugRendererSimple::DrawWireSphere`.
        /// Parameter `inLevel` defaults to `3`.
        public unsafe void DrawWireSphere(JPH.Const_Vec3 inCenter, float inRadius, JPH.Const_Color inColor, int? inLevel = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawWireSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawWireSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawWireSphere(_Underlying *_this, JPH.Vec3._Underlying *inCenter, float inRadius, JPH.Color._Underlying *inColor, int *inLevel);
            int __deref_inLevel = inLevel.GetValueOrDefault();
            __JPH_DebugRendererSimple_DrawWireSphere(_UnderlyingPtr, inCenter._UnderlyingPtr, inRadius, inColor._UnderlyingPtr, inLevel.HasValue ? &__deref_inLevel : null);
        }

        /// Generated from method `JPH::DebugRendererSimple::DrawWireUnitSphere`.
        /// Parameter `inLevel` defaults to `3`.
        public unsafe void DrawWireUnitSphere(JPH.Const_Mat44 inMatrix, JPH.Const_Color inColor, int? inLevel = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawWireUnitSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawWireUnitSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawWireUnitSphere(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, JPH.Color._Underlying *inColor, int *inLevel);
            int __deref_inLevel = inLevel.GetValueOrDefault();
            __JPH_DebugRendererSimple_DrawWireUnitSphere(_UnderlyingPtr, inMatrix._UnderlyingPtr, inColor._UnderlyingPtr, inLevel.HasValue ? &__deref_inLevel : null);
        }

        /// Draw a sphere
        /// Generated from method `JPH::DebugRendererSimple::DrawSphere`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawSphere(JPH.Const_Vec3 inCenter, float inRadius, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawSphere(_Underlying *_this, JPH.Vec3._Underlying *inCenter, float inRadius, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRendererSimple_DrawSphere(_UnderlyingPtr, inCenter._UnderlyingPtr, inRadius, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Generated from method `JPH::DebugRendererSimple::DrawUnitSphere`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawUnitSphere(JPH.Const_Mat44 inMatrix, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawUnitSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawUnitSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawUnitSphere(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRendererSimple_DrawUnitSphere(_UnderlyingPtr, inMatrix._UnderlyingPtr, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draw a capsule with one half sphere at (0, -inHalfHeightOfCylinder, 0) and the other half sphere at (0, inHalfHeightOfCylinder, 0) and radius inRadius.
        /// The capsule will be transformed by inMatrix.
        /// Generated from method `JPH::DebugRendererSimple::DrawCapsule`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawCapsule(JPH.Const_Mat44 inMatrix, float inHalfHeightOfCylinder, float inRadius, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawCapsule", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawCapsule", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawCapsule(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inHalfHeightOfCylinder, float inRadius, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRendererSimple_DrawCapsule(_UnderlyingPtr, inMatrix._UnderlyingPtr, inHalfHeightOfCylinder, inRadius, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draw a cylinder with top (0, inHalfHeight, 0) and bottom (0, -inHalfHeight, 0) and radius inRadius.
        /// The cylinder will be transformed by inMatrix
        /// Generated from method `JPH::DebugRendererSimple::DrawCylinder`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawCylinder(JPH.Const_Mat44 inMatrix, float inHalfHeight, float inRadius, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawCylinder(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inHalfHeight, float inRadius, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRendererSimple_DrawCylinder(_UnderlyingPtr, inMatrix._UnderlyingPtr, inHalfHeight, inRadius, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draw a bottomless cone.
        /// @param inTop Top of cone, center of base is at inTop + inAxis.
        /// @param inAxis Height and direction of cone
        /// @param inPerpendicular Perpendicular vector to inAxis.
        /// @param inHalfAngle Specifies the cone angle in radians (angle measured between inAxis and cone surface).
        /// @param inLength The length of the cone.
        /// @param inColor Color to use for drawing the cone.
        /// @param inCastShadow determines if this geometry should cast a shadow or not.
        /// @param inDrawMode determines if we draw the geometry solid or in wireframe.
        /// Generated from method `JPH::DebugRendererSimple::DrawOpenCone`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawOpenCone(JPH.Const_Vec3 inTop, JPH.Const_Vec3 inAxis, JPH.Const_Vec3 inPerpendicular, float inHalfAngle, float inLength, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawOpenCone", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawOpenCone", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawOpenCone(_Underlying *_this, JPH.Vec3._Underlying *inTop, JPH.Vec3._Underlying *inAxis, JPH.Vec3._Underlying *inPerpendicular, float inHalfAngle, float inLength, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRendererSimple_DrawOpenCone(_UnderlyingPtr, inTop._UnderlyingPtr, inAxis._UnderlyingPtr, inPerpendicular._UnderlyingPtr, inHalfAngle, inLength, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draws cone rotation limits as used by the SwingTwistConstraintPart.
        /// @param inMatrix Matrix that transforms from constraint space to world space
        /// @param inSwingYHalfAngle See SwingTwistConstraintPart
        /// @param inSwingZHalfAngle See SwingTwistConstraintPart
        /// @param inEdgeLength Size of the edge of the cone shape
        /// @param inColor Color to use for drawing the cone.
        /// @param inCastShadow determines if this geometry should cast a shadow or not.
        /// @param inDrawMode determines if we draw the geometry solid or in wireframe.
        /// Generated from method `JPH::DebugRendererSimple::DrawSwingConeLimits`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawSwingConeLimits(JPH.Const_Mat44 inMatrix, float inSwingYHalfAngle, float inSwingZHalfAngle, float inEdgeLength, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawSwingConeLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawSwingConeLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawSwingConeLimits(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inSwingYHalfAngle, float inSwingZHalfAngle, float inEdgeLength, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRendererSimple_DrawSwingConeLimits(_UnderlyingPtr, inMatrix._UnderlyingPtr, inSwingYHalfAngle, inSwingZHalfAngle, inEdgeLength, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draws rotation limits as used by the SwingTwistConstraintPart.
        /// @param inMatrix Matrix that transforms from constraint space to world space
        /// @param inMinSwingYAngle See SwingTwistConstraintPart
        /// @param inMaxSwingYAngle See SwingTwistConstraintPart
        /// @param inMinSwingZAngle See SwingTwistConstraintPart
        /// @param inMaxSwingZAngle See SwingTwistConstraintPart
        /// @param inEdgeLength Size of the edge of the cone shape
        /// @param inColor Color to use for drawing the cone.
        /// @param inCastShadow determines if this geometry should cast a shadow or not.
        /// @param inDrawMode determines if we draw the geometry solid or in wireframe.
        /// Generated from method `JPH::DebugRendererSimple::DrawSwingPyramidLimits`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawSwingPyramidLimits(JPH.Const_Mat44 inMatrix, float inMinSwingYAngle, float inMaxSwingYAngle, float inMinSwingZAngle, float inMaxSwingZAngle, float inEdgeLength, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawSwingPyramidLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawSwingPyramidLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawSwingPyramidLimits(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inMinSwingYAngle, float inMaxSwingYAngle, float inMinSwingZAngle, float inMaxSwingZAngle, float inEdgeLength, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRendererSimple_DrawSwingPyramidLimits(_UnderlyingPtr, inMatrix._UnderlyingPtr, inMinSwingYAngle, inMaxSwingYAngle, inMinSwingZAngle, inMaxSwingZAngle, inEdgeLength, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draw a pie (part of a circle).
        /// @param inCenter The center of the circle.
        /// @param inRadius Radius of the circle.
        /// @param inNormal The plane normal in which the pie resides.
        /// @param inAxis The axis that defines an angle of 0 radians.
        /// @param inMinAngle The pie will be drawn between [inMinAngle, inMaxAngle] (in radians).
        /// @param inMaxAngle The pie will be drawn between [inMinAngle, inMaxAngle] (in radians).
        /// @param inColor Color to use for drawing the pie.
        /// @param inCastShadow determines if this geometry should cast a shadow or not.
        /// @param inDrawMode determines if we draw the geometry solid or in wireframe.
        /// Generated from method `JPH::DebugRendererSimple::DrawPie`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawPie(JPH.Const_Vec3 inCenter, float inRadius, JPH.Const_Vec3 inNormal, JPH.Const_Vec3 inAxis, float inMinAngle, float inMaxAngle, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawPie", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawPie", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawPie(_Underlying *_this, JPH.Vec3._Underlying *inCenter, float inRadius, JPH.Vec3._Underlying *inNormal, JPH.Vec3._Underlying *inAxis, float inMinAngle, float inMaxAngle, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRendererSimple_DrawPie(_UnderlyingPtr, inCenter._UnderlyingPtr, inRadius, inNormal._UnderlyingPtr, inAxis._UnderlyingPtr, inMinAngle, inMaxAngle, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draw a tapered cylinder
        /// @param inMatrix Matrix that transforms the cylinder to world space.
        /// @param inTop Top of cylinder (along Y axis)
        /// @param inBottom Bottom of cylinder (along Y axis)
        /// @param inTopRadius Radius at the top
        /// @param inBottomRadius Radius at the bottom
        /// @param inColor Color to use for drawing the pie.
        /// @param inCastShadow determines if this geometry should cast a shadow or not.
        /// @param inDrawMode determines if we draw the geometry solid or in wireframe.
        /// Generated from method `JPH::DebugRendererSimple::DrawTaperedCylinder`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawTaperedCylinder(JPH.Const_Mat44 inMatrix, float inTop, float inBottom, float inTopRadius, float inBottomRadius, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawTaperedCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRendererSimple_DrawTaperedCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRendererSimple_DrawTaperedCylinder(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inTop, float inBottom, float inTopRadius, float inBottomRadius, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRendererSimple_DrawTaperedCylinder(_UnderlyingPtr, inMatrix._UnderlyingPtr, inTop, inBottom, inTopRadius, inBottomRadius, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }
    }

    /// This is used for optional parameters of class `DebugRendererSimple` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_DebugRendererSimple`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `DebugRendererSimple`/`Const_DebugRendererSimple` directly.
    public class _InOptMut_DebugRendererSimple
    {
        public DebugRendererSimple? Opt;

        public _InOptMut_DebugRendererSimple() {}
        public _InOptMut_DebugRendererSimple(DebugRendererSimple value) {Opt = value;}
        public static implicit operator _InOptMut_DebugRendererSimple(DebugRendererSimple value) {return new(value);}
    }

    /// This is used for optional parameters of class `DebugRendererSimple` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_DebugRendererSimple`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `DebugRendererSimple`/`Const_DebugRendererSimple` to pass it to the function.
    public class _InOptConst_DebugRendererSimple
    {
        public Const_DebugRendererSimple? Opt;

        public _InOptConst_DebugRendererSimple() {}
        public _InOptConst_DebugRendererSimple(Const_DebugRendererSimple value) {Opt = value;}
        public static implicit operator _InOptConst_DebugRendererSimple(Const_DebugRendererSimple value) {return new(value);}
    }
}
