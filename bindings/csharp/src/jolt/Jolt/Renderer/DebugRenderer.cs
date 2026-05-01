// machine generated, do not edit
public static partial class JPH
{
    /// Simple triangle renderer for debugging purposes.
    ///
    /// Inherit from this class to provide your own implementation.
    ///
    /// Implement the following virtual functions:
    /// - DrawLine
    /// - DrawTriangle
    /// - DrawText3D
    /// - CreateTriangleBatch
    /// - DrawGeometry
    ///
    /// Make sure you call Initialize() from the constructor of your implementation.
    ///
    /// The CreateTriangleBatch is used to prepare a batch of triangles to be drawn by a single DrawGeometry call,
    /// which means that Jolt can render a complex scene much more efficiently than when each triangle in that scene would have been drawn through DrawTriangle.
    ///
    /// Note that an implementation that implements CreateTriangleBatch and DrawGeometry is provided by DebugRendererSimple which can be used to start quickly.
    /// Generated from class `JPH::DebugRenderer`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DebugRendererSimple`
    ///   Indirect: (non-virtual)
    ///     `RecordingDebugRenderer`
    /// This is the const half of the class.
    public class Const_DebugRenderer : JPH.Object<Const_DebugRenderer>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_Destroy(_Underlying *_this);
            __JPH_DebugRenderer_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_DebugRenderer() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator JPH.Const_NonCopyable(Const_DebugRenderer self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_NonCopyable._Underlying *__JPH_DebugRenderer_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.Const_NonCopyable ret = new(__JPH_DebugRenderer_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        /// Singleton instance
        public static unsafe JPH.DebugRenderer? SInstance
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Get_sInstance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Get_sInstance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer._Underlying **__JPH_DebugRenderer_Get_sInstance();
                var ptr = __JPH_DebugRenderer_Get_sInstance();
                JPH.DebugRenderer? value = null;
                if (*ptr is not null)
                    value = new(*ptr, is_owning: false);
                return value;
            }
        }

        internal unsafe Const_DebugRenderer(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `JPH::DebugRenderer::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_DebugRenderer_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_DebugRenderer_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_DebugRenderer_size_t(UIntPtr inCount);
            return __Jolt_new_JPH_DebugRenderer_size_t(inCount);
        }

        /// Generated from method `JPH::DebugRenderer::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DebugRenderer_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DebugRenderer_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_DebugRenderer_void_ptr(void *inPointer);
            __Jolt_delete_JPH_DebugRenderer_void_ptr(inPointer);
        }

        /// Generated from method `JPH::DebugRenderer::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DebugRenderer_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DebugRenderer_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_DebugRenderer_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_JPH_DebugRenderer_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::DebugRenderer::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_DebugRenderer_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_DebugRenderer_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_DebugRenderer_size_t(UIntPtr inCount);
            return __Jolt_new_array_JPH_DebugRenderer_size_t(inCount);
        }

        /// Generated from method `JPH::DebugRenderer::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRenderer_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRenderer_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_DebugRenderer_void_ptr(void *inPointer);
            __Jolt_delete_array_JPH_DebugRenderer_void_ptr(inPointer);
        }

        /// Generated from method `JPH::DebugRenderer::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRenderer_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRenderer_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_DebugRenderer_void_ptr_size_t(void *inPointer, UIntPtr inSize);
            __Jolt_delete_array_JPH_DebugRenderer_void_ptr_size_t(inPointer, inSize);
        }

        /// Generated from method `JPH::DebugRenderer::operator new`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_DebugRenderer_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_DebugRenderer_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_JPH_DebugRenderer_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_JPH_DebugRenderer_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::DebugRenderer::operator delete`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void Delete(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DebugRenderer_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DebugRenderer_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_JPH_DebugRenderer_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_JPH_DebugRenderer_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Generated from method `JPH::DebugRenderer::operator new[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_DebugRenderer_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_DebugRenderer_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Jolt_new_array_JPH_DebugRenderer_size_t_void_ptr(UIntPtr inCount, void *inPointer);
            return __Jolt_new_array_JPH_DebugRenderer_size_t_void_ptr(inCount, inPointer);
        }

        /// Generated from method `JPH::DebugRenderer::operator delete[]`.
        /// Parameter `inPointer` is a mutable pointer.
        /// Parameter `inPlace` is a mutable pointer.
        public static unsafe void DeleteArray(void *inPointer, void *inPlace)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRenderer_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRenderer_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_delete_array_JPH_DebugRenderer_void_ptr_void_ptr(void *inPointer, void *inPlace);
            __Jolt_delete_array_JPH_DebugRenderer_void_ptr_void_ptr(inPointer, inPlace);
        }

        /// Calculate bounding box for a batch of triangles
        /// Generated from method `JPH::DebugRenderer::sCalculateBounds`.
        public static unsafe JPH.AABox SCalculateBounds(JPH.DebugRenderer.Const_Vertex? inVertices, int inVertexCount)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_sCalculateBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_sCalculateBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.AABox._Underlying *__JPH_DebugRenderer_sCalculateBounds(JPH.DebugRenderer.Const_Vertex._Underlying *inVertices, int inVertexCount);
            return new(__JPH_DebugRenderer_sCalculateBounds(inVertices is not null ? inVertices._UnderlyingPtr : null, inVertexCount), is_owning: true);
        }

        /// Enum that determines if a shadow should be cast or not
        public enum ECastShadow : int
        {
            ///< This shape should cast a shadow
            On = 0,
            ///< This shape should not cast a shadow
            Off = 1,
        }

        /// Determines which polygons are culled
        public enum ECullMode : int
        {
            ///< Don't draw backfacing polygons
            CullBackFace = 0,
            ///< Don't draw front facing polygons
            CullFrontFace = 1,
            ///< Don't do culling and draw both sides
            Off = 2,
        }

        /// Determines how triangles are drawn
        public enum EDrawMode : int
        {
            ///< Draw as a solid shape
            Solid = 0,
            ///< Draw as wireframe
            Wireframe = 1,
        }

        /// A geometry primitive containing triangle batches for various lods
        /// Generated from class `JPH::DebugRenderer::Geometry`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::RefTarget<JPH::DebugRenderer::Geometry>`
        /// This is the const half of the class.
        public class Const_Geometry : JPH.Object<Const_Geometry>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(_Underlying *_this);
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RefTarget_JPH_DebugRenderer_Geometry_Release(void *_this);
                __JPH_RefTarget_JPH_DebugRenderer_Geometry_Release(__JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(_UnderlyingPtr));
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Geometry() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator JPH.Const_RefTarget_JPHDebugRendererGeometry(Const_Geometry self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_RefTarget_JPHDebugRendererGeometry._Underlying *__JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(_Underlying *_this);
                JPH.Const_RefTarget_JPHDebugRendererGeometry ret = new(__JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            /// Bounding box that encapsulates all LODs
            public unsafe JPH.Const_AABox mBounds
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_Get_mBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_Get_mBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_AABox._Underlying *__JPH_DebugRenderer_Geometry_Get_mBounds(_Underlying *_this);
                    JPH.Const_AABox __ret;
                    __ret = new(__JPH_DebugRenderer_Geometry_Get_mBounds(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Const_Geometry(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from constructor `JPH::DebugRenderer::Geometry::Geometry`.
            public unsafe Const_Geometry(JPH.DebugRenderer._ByValue_Geometry _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Geometry._Underlying *__JPH_DebugRenderer_Geometry_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.DebugRenderer.Geometry._Underlying *_other);
                _UnderlyingPtr = __JPH_DebugRenderer_Geometry_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(_Underlying *_this);
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef(void *_this);
                __JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef(__JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(_UnderlyingPtr));
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::DebugRenderer::Geometry::Geometry`.
            public Const_Geometry(Const_Geometry _other) : this(new _ByValue_Geometry(_other)) {}

            /// Generated from constructor `JPH::DebugRenderer::Geometry::Geometry`.
            public Const_Geometry(Geometry _other) : this((Const_Geometry)_other) {}

            /// Constructor
            /// Generated from constructor `JPH::DebugRenderer::Geometry::Geometry`.
            public unsafe Const_Geometry(JPH.Const_AABox inBounds) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Geometry._Underlying *__JPH_DebugRenderer_Geometry_Construct_1(JPH.Const_AABox._Underlying *inBounds);
                _UnderlyingPtr = __JPH_DebugRenderer_Geometry_Construct_1(inBounds._UnderlyingPtr);
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(_Underlying *_this);
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef(void *_this);
                __JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef(__JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(_UnderlyingPtr));
            }

            /// Constructor
            /// Generated from constructor `JPH::DebugRenderer::Geometry::Geometry`.
            public static unsafe implicit operator Const_Geometry(JPH.Const_AABox inBounds) {return new(inBounds);}

            /// Generated from method `JPH::DebugRenderer::Geometry::operator new`.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_DebugRenderer_Geometry_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_DebugRenderer_Geometry_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_DebugRenderer_Geometry_size_t(UIntPtr inCount);
                return __Jolt_new_JPH_DebugRenderer_Geometry_size_t(inCount);
            }

            /// Generated from method `JPH::DebugRenderer::Geometry::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr(void *inPointer);
                __Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr(inPointer);
            }

            /// Generated from method `JPH::DebugRenderer::Geometry::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::DebugRenderer::Geometry::operator new[]`.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_DebugRenderer_Geometry_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_DebugRenderer_Geometry_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_DebugRenderer_Geometry_size_t(UIntPtr inCount);
                return __Jolt_new_array_JPH_DebugRenderer_Geometry_size_t(inCount);
            }

            /// Generated from method `JPH::DebugRenderer::Geometry::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr(void *inPointer);
                __Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr(inPointer);
            }

            /// Generated from method `JPH::DebugRenderer::Geometry::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, UIntPtr inSize)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr_size_t", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr_size_t(void *inPointer, UIntPtr inSize);
                __Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr_size_t(inPointer, inSize);
            }

            /// Generated from method `JPH::DebugRenderer::Geometry::operator new`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *New(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_JPH_DebugRenderer_Geometry_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_JPH_DebugRenderer_Geometry_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_JPH_DebugRenderer_Geometry_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_JPH_DebugRenderer_Geometry_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::DebugRenderer::Geometry::operator delete`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void Delete(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_JPH_DebugRenderer_Geometry_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Generated from method `JPH::DebugRenderer::Geometry::operator new[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Returns a mutable pointer.
            public static unsafe void *NewArray(UIntPtr inCount, void *inPointer)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_new_array_JPH_DebugRenderer_Geometry_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_new_array_JPH_DebugRenderer_Geometry_size_t_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__Jolt_new_array_JPH_DebugRenderer_Geometry_size_t_void_ptr(UIntPtr inCount, void *inPointer);
                return __Jolt_new_array_JPH_DebugRenderer_Geometry_size_t_void_ptr(inCount, inPointer);
            }

            /// Generated from method `JPH::DebugRenderer::Geometry::operator delete[]`.
            /// Parameter `inPointer` is a mutable pointer.
            /// Parameter `inPlace` is a mutable pointer.
            public static unsafe void DeleteArray(void *inPointer, void *inPlace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr_void_ptr(void *inPointer, void *inPlace);
                __Jolt_delete_array_JPH_DebugRenderer_Geometry_void_ptr_void_ptr(inPointer, inPlace);
            }

            /// Determine which LOD to render
            /// @param inCameraPosition Current position of the camera
            /// @param inWorldSpaceBounds World space bounds for this geometry (transform mBounds by model space matrix)
            /// @param inLODScaleSq is the squared scale of the model matrix, it is multiplied with the LOD distances in inGeometry to calculate the real LOD distance (so a number > 1 will force a higher LOD).
            /// @return The selected LOD.
            /// Generated from method `JPH::DebugRenderer::Geometry::GetLOD`.
            public unsafe JPH.DebugRenderer.Const_LOD GetLOD(JPH.Const_Vec3 inCameraPosition, JPH.Const_AABox inWorldSpaceBounds, float inLODScaleSq)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_GetLOD", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_GetLOD", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Const_LOD._Underlying *__JPH_DebugRenderer_Geometry_GetLOD(_Underlying *_this, JPH.Vec3._Underlying *inCameraPosition, JPH.Const_AABox._Underlying *inWorldSpaceBounds, float inLODScaleSq);
                return new(__JPH_DebugRenderer_Geometry_GetLOD(_UnderlyingPtr, inCameraPosition._UnderlyingPtr, inWorldSpaceBounds._UnderlyingPtr, inLODScaleSq), is_owning: false);
            }

            /// Mark this class as embedded, this means the type can be used in a compound or constructed on the stack.
            /// The Release function will never destruct the object, it is assumed the destructor will be called by whoever allocated
            /// the object and at that point in time it is checked that no references are left to the structure.
            /// Generated from method `JPH::DebugRenderer::Geometry::SetEmbedded`.
            public unsafe void SetEmbedded()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_SetEmbedded", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DebugRenderer_Geometry_SetEmbedded(_Underlying *_this);
                __JPH_DebugRenderer_Geometry_SetEmbedded(_UnderlyingPtr);
            }

            /// Get current refcount of this object
            /// Generated from method `JPH::DebugRenderer::Geometry::GetRefCount`.
            public unsafe uint GetRefCount()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_GetRefCount", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint __JPH_DebugRenderer_Geometry_GetRefCount(_Underlying *_this);
                return __JPH_DebugRenderer_Geometry_GetRefCount(_UnderlyingPtr);
            }

            /// Add or release a reference to this object
            /// Generated from method `JPH::DebugRenderer::Geometry::AddRef`.
            public unsafe void AddRef()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DebugRenderer_Geometry_AddRef(_Underlying *_this);
                __JPH_DebugRenderer_Geometry_AddRef(_UnderlyingPtr);
            }

            /// Generated from method `JPH::DebugRenderer::Geometry::Release`.
            public unsafe void Release()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_Release", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DebugRenderer_Geometry_Release(_Underlying *_this);
                __JPH_DebugRenderer_Geometry_Release(_UnderlyingPtr);
            }

            /// INTERNAL HELPER FUNCTION USED BY SERIALIZATION
            /// Generated from method `JPH::DebugRenderer::Geometry::sInternalGetRefCountOffset`.
            public static int SInternalGetRefCountOffset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_sInternalGetRefCountOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int __JPH_DebugRenderer_Geometry_sInternalGetRefCountOffset();
                return __JPH_DebugRenderer_Geometry_sInternalGetRefCountOffset();
            }
        }

        /// A geometry primitive containing triangle batches for various lods
        /// Generated from class `JPH::DebugRenderer::Geometry`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `JPH::RefTarget<JPH::DebugRenderer::Geometry>`
        /// This is the non-const half of the class.
        public class Geometry : Const_Geometry
        {
            // Upcasts:
            public static unsafe implicit operator JPH.RefTarget_JPHDebugRendererGeometry(Geometry self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.RefTarget_JPHDebugRendererGeometry._Underlying *__JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(_Underlying *_this);
                JPH.RefTarget_JPHDebugRendererGeometry ret = new(__JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            /// Bounding box that encapsulates all LODs
            public new unsafe JPH.AABox mBounds
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_GetMutable_mBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_GetMutable_mBounds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.AABox._Underlying *__JPH_DebugRenderer_Geometry_GetMutable_mBounds(_Underlying *_this);
                    JPH.AABox __ret;
                    __ret = new(__JPH_DebugRenderer_Geometry_GetMutable_mBounds(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Geometry(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Generated from constructor `JPH::DebugRenderer::Geometry::Geometry`.
            public unsafe Geometry(JPH.DebugRenderer._ByValue_Geometry _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Geometry._Underlying *__JPH_DebugRenderer_Geometry_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.DebugRenderer.Geometry._Underlying *_other);
                _UnderlyingPtr = __JPH_DebugRenderer_Geometry_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(_Underlying *_this);
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef(void *_this);
                __JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef(__JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(_UnderlyingPtr));
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::DebugRenderer::Geometry::Geometry`.
            public Geometry(Const_Geometry _other) : this(new _ByValue_Geometry(_other)) {}

            /// Generated from constructor `JPH::DebugRenderer::Geometry::Geometry`.
            public Geometry(Geometry _other) : this((Const_Geometry)_other) {}

            /// Constructor
            /// Generated from constructor `JPH::DebugRenderer::Geometry::Geometry`.
            public unsafe Geometry(JPH.Const_AABox inBounds) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Geometry._Underlying *__JPH_DebugRenderer_Geometry_Construct_1(JPH.Const_AABox._Underlying *inBounds);
                _UnderlyingPtr = __JPH_DebugRenderer_Geometry_Construct_1(inBounds._UnderlyingPtr);
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void *__JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(_Underlying *_this);
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef(void *_this);
                __JPH_RefTarget_JPH_DebugRenderer_Geometry_AddRef(__JPH_DebugRenderer_Geometry_UpcastTo_JPH_RefTarget_JPH_DebugRenderer_Geometry(_UnderlyingPtr));
            }

            /// Constructor
            /// Generated from constructor `JPH::DebugRenderer::Geometry::Geometry`.
            public static unsafe implicit operator Geometry(JPH.Const_AABox inBounds) {return new(inBounds);}

            /// Generated from method `JPH::DebugRenderer::Geometry::operator=`.
            public unsafe JPH.DebugRenderer.Geometry Assign(JPH.DebugRenderer._ByValue_Geometry _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Geometry_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Geometry._Underlying *__JPH_DebugRenderer_Geometry_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.DebugRenderer.Geometry._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_DebugRenderer_Geometry_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }
        }

        /// This is used as a function parameter when the underlying function receives `Geometry` by value.
        /// Usage:
        /// * Pass an instance of `Geometry`/`Const_Geometry` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_Geometry
        {
            #pragma warning disable CS0649
            internal readonly Const_Geometry? Value;
            #pragma warning restore CS0649
            internal readonly JPH._PassBy PassByMode;
            public _ByValue_Geometry(Const_Geometry new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
            public static implicit operator _ByValue_Geometry(Const_Geometry arg) {return new(arg);}
            public _ByValue_Geometry(JPH._Moved<Geometry> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
            public static implicit operator _ByValue_Geometry(JPH._Moved<Geometry> arg) {return new(arg);}

            /// Constructor
            /// Generated from constructor `JPH::DebugRenderer::Geometry::Geometry`.
            public static unsafe implicit operator _ByValue_Geometry(JPH.Const_AABox inBounds) {return new JPH._Moved<JPH.DebugRenderer.Geometry>(inBounds);}
        }

        /// This is used for optional parameters of class `Geometry` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Geometry`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Geometry`/`Const_Geometry` directly.
        public class _InOptMut_Geometry
        {
            public Geometry? Opt;

            public _InOptMut_Geometry() {}
            public _InOptMut_Geometry(Geometry value) {Opt = value;}
            public static implicit operator _InOptMut_Geometry(Geometry value) {return new(value);}
        }

        /// This is used for optional parameters of class `Geometry` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Geometry`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Geometry`/`Const_Geometry` to pass it to the function.
        public class _InOptConst_Geometry
        {
            public Const_Geometry? Opt;

            public _InOptConst_Geometry() {}
            public _InOptConst_Geometry(Const_Geometry value) {Opt = value;}
            public static implicit operator _InOptConst_Geometry(Const_Geometry value) {return new(value);}

            /// Constructor
            /// Generated from constructor `JPH::DebugRenderer::Geometry::Geometry`.
            public static unsafe implicit operator _InOptConst_Geometry(JPH.Const_AABox inBounds) {return new Const_Geometry(inBounds);}
        }

        /// A single level of detail
        /// Generated from class `JPH::DebugRenderer::LOD`.
        /// This is the const half of the class.
        public class Const_LOD : JPH.Object<Const_LOD>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_LOD_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_LOD_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DebugRenderer_LOD_Destroy(_Underlying *_this);
                __JPH_DebugRenderer_LOD_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_LOD() {Dispose(false);}

            public unsafe float mDistance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_LOD_Get_mDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_LOD_Get_mDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_DebugRenderer_LOD_Get_mDistance(_Underlying *_this);
                    return *__JPH_DebugRenderer_LOD_Get_mDistance(_UnderlyingPtr);
                }
            }

            internal unsafe Const_LOD(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_LOD() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_LOD_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_LOD_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.LOD._Underlying *__JPH_DebugRenderer_LOD_DefaultConstruct();
                _UnderlyingPtr = __JPH_DebugRenderer_LOD_DefaultConstruct();
            }

            /// Generated from constructor `JPH::DebugRenderer::LOD::LOD`.
            public unsafe Const_LOD(JPH.DebugRenderer._ByValue_LOD _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_LOD_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_LOD_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.LOD._Underlying *__JPH_DebugRenderer_LOD_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.DebugRenderer.LOD._Underlying *_other);
                _UnderlyingPtr = __JPH_DebugRenderer_LOD_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::DebugRenderer::LOD::LOD`.
            public Const_LOD(Const_LOD _other) : this(new _ByValue_LOD(_other)) {}

            /// Generated from constructor `JPH::DebugRenderer::LOD::LOD`.
            public Const_LOD(LOD _other) : this((Const_LOD)_other) {}
        }

        /// A single level of detail
        /// Generated from class `JPH::DebugRenderer::LOD`.
        /// This is the non-const half of the class.
        public class LOD : Const_LOD
        {
            public new unsafe ref float mDistance
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_LOD_GetMutable_mDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_LOD_GetMutable_mDistance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static float *__JPH_DebugRenderer_LOD_GetMutable_mDistance(_Underlying *_this);
                    return ref *__JPH_DebugRenderer_LOD_GetMutable_mDistance(_UnderlyingPtr);
                }
            }

            internal unsafe LOD(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe LOD() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_LOD_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_LOD_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.LOD._Underlying *__JPH_DebugRenderer_LOD_DefaultConstruct();
                _UnderlyingPtr = __JPH_DebugRenderer_LOD_DefaultConstruct();
            }

            /// Generated from constructor `JPH::DebugRenderer::LOD::LOD`.
            public unsafe LOD(JPH.DebugRenderer._ByValue_LOD _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_LOD_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_LOD_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.LOD._Underlying *__JPH_DebugRenderer_LOD_ConstructFromAnother(JPH._PassBy _other_pass_by, JPH.DebugRenderer.LOD._Underlying *_other);
                _UnderlyingPtr = __JPH_DebugRenderer_LOD_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `JPH::DebugRenderer::LOD::LOD`.
            public LOD(Const_LOD _other) : this(new _ByValue_LOD(_other)) {}

            /// Generated from constructor `JPH::DebugRenderer::LOD::LOD`.
            public LOD(LOD _other) : this((Const_LOD)_other) {}

            /// Generated from method `JPH::DebugRenderer::LOD::operator=`.
            public unsafe JPH.DebugRenderer.LOD Assign(JPH.DebugRenderer._ByValue_LOD _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_LOD_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_LOD_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.LOD._Underlying *__JPH_DebugRenderer_LOD_AssignFromAnother(_Underlying *_this, JPH._PassBy _other_pass_by, JPH.DebugRenderer.LOD._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__JPH_DebugRenderer_LOD_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }
        }

        /// This is used as a function parameter when the underlying function receives `LOD` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `LOD`/`Const_LOD` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_LOD
        {
            #pragma warning disable CS0649
            internal readonly Const_LOD? Value;
            #pragma warning restore CS0649
            internal readonly JPH._PassBy PassByMode;
            public _ByValue_LOD() {PassByMode = JPH._PassBy.default_construct;}
            public _ByValue_LOD(Const_LOD new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
            public static implicit operator _ByValue_LOD(Const_LOD arg) {return new(arg);}
            public _ByValue_LOD(JPH._Moved<LOD> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
            public static implicit operator _ByValue_LOD(JPH._Moved<LOD> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `LOD` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_LOD`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `LOD`/`Const_LOD` directly.
        public class _InOptMut_LOD
        {
            public LOD? Opt;

            public _InOptMut_LOD() {}
            public _InOptMut_LOD(LOD value) {Opt = value;}
            public static implicit operator _InOptMut_LOD(LOD value) {return new(value);}
        }

        /// This is used for optional parameters of class `LOD` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_LOD`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `LOD`/`Const_LOD` to pass it to the function.
        public class _InOptConst_LOD
        {
            public Const_LOD? Opt;

            public _InOptConst_LOD() {}
            public _InOptConst_LOD(Const_LOD value) {Opt = value;}
            public static implicit operator _InOptConst_LOD(Const_LOD value) {return new(value);}
        }

        /// A single triangle
        /// Generated from class `JPH::DebugRenderer::Triangle`.
        /// This is the const half of the class.
        public class Const_Triangle : JPH.Object<Const_Triangle>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DebugRenderer_Triangle_Destroy(_Underlying *_this);
                __JPH_DebugRenderer_Triangle_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Triangle() {Dispose(false);}

            public unsafe JPH.ArrayDebugRendererVertex3 mv
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_Get_mV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_Get_mV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.DebugRenderer.Vertex._Underlying *__JPH_DebugRenderer_Triangle_Get_mV(_Underlying *_this);
                    return new(__JPH_DebugRenderer_Triangle_Get_mV(_UnderlyingPtr));
                }
            }

            internal unsafe Const_Triangle(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Triangle() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Triangle._Underlying *__JPH_DebugRenderer_Triangle_DefaultConstruct();
                _UnderlyingPtr = __JPH_DebugRenderer_Triangle_DefaultConstruct();
            }

            /// Generated from constructor `JPH::DebugRenderer::Triangle::Triangle`.
            public unsafe Const_Triangle(JPH.DebugRenderer.Const_Triangle _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Triangle._Underlying *__JPH_DebugRenderer_Triangle_ConstructFromAnother(JPH.DebugRenderer.Triangle._Underlying *_other);
                _UnderlyingPtr = __JPH_DebugRenderer_Triangle_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::DebugRenderer::Triangle::Triangle`.
            public Const_Triangle(Triangle _other) : this((Const_Triangle)_other) {}

            /// Generated from constructor `JPH::DebugRenderer::Triangle::Triangle`.
            public unsafe Const_Triangle(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3, JPH.Const_Color inColor) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Triangle._Underlying *__JPH_DebugRenderer_Triangle_Construct_4(JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3, JPH.Color._Underlying *inColor);
                _UnderlyingPtr = __JPH_DebugRenderer_Triangle_Construct_4(inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr, inColor._UnderlyingPtr);
            }

            /// Generated from constructor `JPH::DebugRenderer::Triangle::Triangle`.
            public unsafe Const_Triangle(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3, JPH.Const_Color inColor, JPH.Const_Vec3 inUVOrigin, JPH.Const_Vec3 inUVDirection) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_Construct_6", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_Construct_6", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Triangle._Underlying *__JPH_DebugRenderer_Triangle_Construct_6(JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3, JPH.Color._Underlying *inColor, JPH.Vec3._Underlying *inUVOrigin, JPH.Vec3._Underlying *inUVDirection);
                _UnderlyingPtr = __JPH_DebugRenderer_Triangle_Construct_6(inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr, inColor._UnderlyingPtr, inUVOrigin._UnderlyingPtr, inUVDirection._UnderlyingPtr);
            }
        }

        /// A single triangle
        /// Generated from class `JPH::DebugRenderer::Triangle`.
        /// This is the non-const half of the class.
        public class Triangle : Const_Triangle
        {
            new public unsafe JPH.ArrayDebugRendererVertex3 mv
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_GetMutable_mV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_GetMutable_mV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.DebugRenderer.Vertex._Underlying *__JPH_DebugRenderer_Triangle_GetMutable_mV(_Underlying *_this);
                    return new(__JPH_DebugRenderer_Triangle_GetMutable_mV(_UnderlyingPtr));
                }
            }

            internal unsafe Triangle(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Triangle() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Triangle._Underlying *__JPH_DebugRenderer_Triangle_DefaultConstruct();
                _UnderlyingPtr = __JPH_DebugRenderer_Triangle_DefaultConstruct();
            }

            /// Generated from constructor `JPH::DebugRenderer::Triangle::Triangle`.
            public unsafe Triangle(JPH.DebugRenderer.Const_Triangle _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Triangle._Underlying *__JPH_DebugRenderer_Triangle_ConstructFromAnother(JPH.DebugRenderer.Triangle._Underlying *_other);
                _UnderlyingPtr = __JPH_DebugRenderer_Triangle_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::DebugRenderer::Triangle::Triangle`.
            public Triangle(Triangle _other) : this((Const_Triangle)_other) {}

            /// Generated from constructor `JPH::DebugRenderer::Triangle::Triangle`.
            public unsafe Triangle(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3, JPH.Const_Color inColor) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Triangle._Underlying *__JPH_DebugRenderer_Triangle_Construct_4(JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3, JPH.Color._Underlying *inColor);
                _UnderlyingPtr = __JPH_DebugRenderer_Triangle_Construct_4(inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr, inColor._UnderlyingPtr);
            }

            /// Generated from constructor `JPH::DebugRenderer::Triangle::Triangle`.
            public unsafe Triangle(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3, JPH.Const_Color inColor, JPH.Const_Vec3 inUVOrigin, JPH.Const_Vec3 inUVDirection) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_Construct_6", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_Construct_6", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Triangle._Underlying *__JPH_DebugRenderer_Triangle_Construct_6(JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3, JPH.Color._Underlying *inColor, JPH.Vec3._Underlying *inUVOrigin, JPH.Vec3._Underlying *inUVDirection);
                _UnderlyingPtr = __JPH_DebugRenderer_Triangle_Construct_6(inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr, inColor._UnderlyingPtr, inUVOrigin._UnderlyingPtr, inUVDirection._UnderlyingPtr);
            }

            /// Generated from method `JPH::DebugRenderer::Triangle::operator=`.
            public unsafe JPH.DebugRenderer.Triangle Assign(JPH.DebugRenderer.Const_Triangle _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Triangle_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Triangle._Underlying *__JPH_DebugRenderer_Triangle_AssignFromAnother(_Underlying *_this, JPH.DebugRenderer.Triangle._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_DebugRenderer_Triangle_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `Triangle` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Triangle`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Triangle`/`Const_Triangle` directly.
        public class _InOptMut_Triangle
        {
            public Triangle? Opt;

            public _InOptMut_Triangle() {}
            public _InOptMut_Triangle(Triangle value) {Opt = value;}
            public static implicit operator _InOptMut_Triangle(Triangle value) {return new(value);}
        }

        /// This is used for optional parameters of class `Triangle` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Triangle`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Triangle`/`Const_Triangle` to pass it to the function.
        public class _InOptConst_Triangle
        {
            public Const_Triangle? Opt;

            public _InOptConst_Triangle() {}
            public _InOptConst_Triangle(Const_Triangle value) {Opt = value;}
            public static implicit operator _InOptConst_Triangle(Const_Triangle value) {return new(value);}
        }

        /// Vertex format used by the triangle renderer
        /// Generated from class `JPH::DebugRenderer::Vertex`.
        /// This is the const half of the class.
        public class Const_Vertex : JPH.Object<Const_Vertex>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __JPH_DebugRenderer_Vertex_Destroy(_Underlying *_this);
                __JPH_DebugRenderer_Vertex_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Vertex() {Dispose(false);}

            public unsafe JPH.Const_Float3 mPosition
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_Get_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Float3._Underlying *__JPH_DebugRenderer_Vertex_Get_mPosition(_Underlying *_this);
                    JPH.Const_Float3 __ret;
                    __ret = new(__JPH_DebugRenderer_Vertex_Get_mPosition(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe JPH.Const_Float3 mNormal
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_Get_mNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_Get_mNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Float3._Underlying *__JPH_DebugRenderer_Vertex_Get_mNormal(_Underlying *_this);
                    JPH.Const_Float3 __ret;
                    __ret = new(__JPH_DebugRenderer_Vertex_Get_mNormal(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe JPH.Const_Float2 muv
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_Get_mUV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_Get_mUV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Float2._Underlying *__JPH_DebugRenderer_Vertex_Get_mUV(_Underlying *_this);
                    JPH.Const_Float2 __ret;
                    __ret = new(__JPH_DebugRenderer_Vertex_Get_mUV(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe JPH.Const_Color mColor
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_Get_mColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_Get_mColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Const_Color._Underlying *__JPH_DebugRenderer_Vertex_Get_mColor(_Underlying *_this);
                    JPH.Const_Color __ret;
                    __ret = new(__JPH_DebugRenderer_Vertex_Get_mColor(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Const_Vertex(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Vertex() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Vertex._Underlying *__JPH_DebugRenderer_Vertex_DefaultConstruct();
                _UnderlyingPtr = __JPH_DebugRenderer_Vertex_DefaultConstruct();
            }

            /// Constructs `JPH::DebugRenderer::Vertex` elementwise.
            public unsafe Const_Vertex(JPH.Const_Float3 mPosition, JPH.Const_Float3 mNormal, JPH.Const_Float2 mUV, JPH.Const_Color mColor) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Vertex._Underlying *__JPH_DebugRenderer_Vertex_ConstructFrom(JPH.Float3._Underlying *mPosition, JPH.Float3._Underlying *mNormal, JPH.Float2._Underlying *mUV, JPH.Color._Underlying *mColor);
                _UnderlyingPtr = __JPH_DebugRenderer_Vertex_ConstructFrom(mPosition._UnderlyingPtr, mNormal._UnderlyingPtr, mUV._UnderlyingPtr, mColor._UnderlyingPtr);
                _KeepAlive(mPosition);
                _KeepAlive(mNormal);
                _KeepAlive(mUV);
                _KeepAlive(mColor);
            }

            /// Generated from constructor `JPH::DebugRenderer::Vertex::Vertex`.
            public unsafe Const_Vertex(JPH.DebugRenderer.Const_Vertex _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Vertex._Underlying *__JPH_DebugRenderer_Vertex_ConstructFromAnother(JPH.DebugRenderer.Vertex._Underlying *_other);
                _UnderlyingPtr = __JPH_DebugRenderer_Vertex_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::DebugRenderer::Vertex::Vertex`.
            public Const_Vertex(Vertex _other) : this((Const_Vertex)_other) {}
        }

        /// Vertex format used by the triangle renderer
        /// Generated from class `JPH::DebugRenderer::Vertex`.
        /// This is the non-const half of the class.
        public class Vertex : Const_Vertex
        {
            public new unsafe JPH.Float3 mPosition
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_GetMutable_mPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Float3._Underlying *__JPH_DebugRenderer_Vertex_GetMutable_mPosition(_Underlying *_this);
                    JPH.Float3 __ret;
                    __ret = new(__JPH_DebugRenderer_Vertex_GetMutable_mPosition(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe JPH.Float3 mNormal
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_GetMutable_mNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_GetMutable_mNormal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Float3._Underlying *__JPH_DebugRenderer_Vertex_GetMutable_mNormal(_Underlying *_this);
                    JPH.Float3 __ret;
                    __ret = new(__JPH_DebugRenderer_Vertex_GetMutable_mNormal(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe JPH.Float2 muv
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_GetMutable_mUV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_GetMutable_mUV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Float2._Underlying *__JPH_DebugRenderer_Vertex_GetMutable_mUV(_Underlying *_this);
                    JPH.Float2 __ret;
                    __ret = new(__JPH_DebugRenderer_Vertex_GetMutable_mUV(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe JPH.Color mColor
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_GetMutable_mColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_GetMutable_mColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static JPH.Color._Underlying *__JPH_DebugRenderer_Vertex_GetMutable_mColor(_Underlying *_this);
                    JPH.Color __ret;
                    __ret = new(__JPH_DebugRenderer_Vertex_GetMutable_mColor(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            internal unsafe Vertex(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Vertex() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Vertex._Underlying *__JPH_DebugRenderer_Vertex_DefaultConstruct();
                _UnderlyingPtr = __JPH_DebugRenderer_Vertex_DefaultConstruct();
            }

            /// Constructs `JPH::DebugRenderer::Vertex` elementwise.
            public unsafe Vertex(JPH.Const_Float3 mPosition, JPH.Const_Float3 mNormal, JPH.Const_Float2 mUV, JPH.Const_Color mColor) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Vertex._Underlying *__JPH_DebugRenderer_Vertex_ConstructFrom(JPH.Float3._Underlying *mPosition, JPH.Float3._Underlying *mNormal, JPH.Float2._Underlying *mUV, JPH.Color._Underlying *mColor);
                _UnderlyingPtr = __JPH_DebugRenderer_Vertex_ConstructFrom(mPosition._UnderlyingPtr, mNormal._UnderlyingPtr, mUV._UnderlyingPtr, mColor._UnderlyingPtr);
                _KeepAlive(mPosition);
                _KeepAlive(mNormal);
                _KeepAlive(mUV);
                _KeepAlive(mColor);
            }

            /// Generated from constructor `JPH::DebugRenderer::Vertex::Vertex`.
            public unsafe Vertex(JPH.DebugRenderer.Const_Vertex _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Vertex._Underlying *__JPH_DebugRenderer_Vertex_ConstructFromAnother(JPH.DebugRenderer.Vertex._Underlying *_other);
                _UnderlyingPtr = __JPH_DebugRenderer_Vertex_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `JPH::DebugRenderer::Vertex::Vertex`.
            public Vertex(Vertex _other) : this((Const_Vertex)_other) {}

            /// Generated from method `JPH::DebugRenderer::Vertex::operator=`.
            public unsafe JPH.DebugRenderer.Vertex Assign(JPH.DebugRenderer.Const_Vertex _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_Vertex_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Vertex._Underlying *__JPH_DebugRenderer_Vertex_AssignFromAnother(_Underlying *_this, JPH.DebugRenderer.Vertex._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__JPH_DebugRenderer_Vertex_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `Vertex` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Vertex`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Vertex`/`Const_Vertex` directly.
        public class _InOptMut_Vertex
        {
            public Vertex? Opt;

            public _InOptMut_Vertex() {}
            public _InOptMut_Vertex(Vertex value) {Opt = value;}
            public static implicit operator _InOptMut_Vertex(Vertex value) {return new(value);}
        }

        /// This is used for optional parameters of class `Vertex` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Vertex`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Vertex`/`Const_Vertex` to pass it to the function.
        public class _InOptConst_Vertex
        {
            public Const_Vertex? Opt;

            public _InOptConst_Vertex() {}
            public _InOptConst_Vertex(Const_Vertex value) {Opt = value;}
            public static implicit operator _InOptConst_Vertex(Const_Vertex value) {return new(value);}
        }
    }

    /// Simple triangle renderer for debugging purposes.
    ///
    /// Inherit from this class to provide your own implementation.
    ///
    /// Implement the following virtual functions:
    /// - DrawLine
    /// - DrawTriangle
    /// - DrawText3D
    /// - CreateTriangleBatch
    /// - DrawGeometry
    ///
    /// Make sure you call Initialize() from the constructor of your implementation.
    ///
    /// The CreateTriangleBatch is used to prepare a batch of triangles to be drawn by a single DrawGeometry call,
    /// which means that Jolt can render a complex scene much more efficiently than when each triangle in that scene would have been drawn through DrawTriangle.
    ///
    /// Note that an implementation that implements CreateTriangleBatch and DrawGeometry is provided by DebugRendererSimple which can be used to start quickly.
    /// Generated from class `JPH::DebugRenderer`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `JPH::NonCopyable`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `JPH::DebugRendererSimple`
    ///   Indirect: (non-virtual)
    ///     `RecordingDebugRenderer`
    /// This is the non-const half of the class.
    public class DebugRenderer : Const_DebugRenderer
    {
        // Upcasts:
        public static unsafe implicit operator JPH.NonCopyable(DebugRenderer self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_UpcastTo_JPH_NonCopyable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.NonCopyable._Underlying *__JPH_DebugRenderer_UpcastTo_JPH_NonCopyable(_Underlying *_this);
            JPH.NonCopyable ret = new(__JPH_DebugRenderer_UpcastTo_JPH_NonCopyable(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe DebugRenderer(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Call once after frame is complete. Releases unused dynamically generated geometry assets.
        /// Generated from method `JPH::DebugRenderer::NextFrame`.
        public unsafe void NextFrame()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_NextFrame", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_NextFrame", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_NextFrame(_Underlying *_this);
            __JPH_DebugRenderer_NextFrame(_UnderlyingPtr);
        }

        /// Draw line
        /// Generated from method `JPH::DebugRenderer::DrawLine`.
        public unsafe void DrawLine(JPH.Const_Vec3 inFrom, JPH.Const_Vec3 inTo, JPH.Const_Color inColor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawLine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawLine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawLine(_Underlying *_this, JPH.Vec3._Underlying *inFrom, JPH.Vec3._Underlying *inTo, JPH.Color._Underlying *inColor);
            __JPH_DebugRenderer_DrawLine(_UnderlyingPtr, inFrom._UnderlyingPtr, inTo._UnderlyingPtr, inColor._UnderlyingPtr);
        }

        /// Draw wireframe box
        /// Generated from method `JPH::DebugRenderer::DrawWireBox`.
        public unsafe void DrawWireBox(JPH.Const_AABox inBox, JPH.Const_Color inColor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawWireBox_2_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawWireBox_2_JPH_AABox", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawWireBox_2_JPH_AABox(_Underlying *_this, JPH.Const_AABox._Underlying *inBox, JPH.Color._Underlying *inColor);
            __JPH_DebugRenderer_DrawWireBox_2_JPH_AABox(_UnderlyingPtr, inBox._UnderlyingPtr, inColor._UnderlyingPtr);
        }

        /// Generated from method `JPH::DebugRenderer::DrawWireBox`.
        public unsafe void DrawWireBox(JPH.Const_Mat44 inMatrix, JPH.Const_AABox inBox, JPH.Const_Color inColor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawWireBox_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawWireBox_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawWireBox_3(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, JPH.Const_AABox._Underlying *inBox, JPH.Color._Underlying *inColor);
            __JPH_DebugRenderer_DrawWireBox_3(_UnderlyingPtr, inMatrix._UnderlyingPtr, inBox._UnderlyingPtr, inColor._UnderlyingPtr);
        }

        /// Draw a marker on a position
        /// Generated from method `JPH::DebugRenderer::DrawMarker`.
        public unsafe void DrawMarker(JPH.Const_Vec3 inPosition, JPH.Const_Color inColor, float inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawMarker", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawMarker", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawMarker(_Underlying *_this, JPH.Vec3._Underlying *inPosition, JPH.Color._Underlying *inColor, float inSize);
            __JPH_DebugRenderer_DrawMarker(_UnderlyingPtr, inPosition._UnderlyingPtr, inColor._UnderlyingPtr, inSize);
        }

        /// Draw an arrow
        /// Generated from method `JPH::DebugRenderer::DrawArrow`.
        public unsafe void DrawArrow(JPH.Const_Vec3 inFrom, JPH.Const_Vec3 inTo, JPH.Const_Color inColor, float inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawArrow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawArrow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawArrow(_Underlying *_this, JPH.Vec3._Underlying *inFrom, JPH.Vec3._Underlying *inTo, JPH.Color._Underlying *inColor, float inSize);
            __JPH_DebugRenderer_DrawArrow(_UnderlyingPtr, inFrom._UnderlyingPtr, inTo._UnderlyingPtr, inColor._UnderlyingPtr, inSize);
        }

        /// Draw coordinate system (3 arrows, x = red, y = green, z = blue)
        /// Generated from method `JPH::DebugRenderer::DrawCoordinateSystem`.
        /// Parameter `inSize` defaults to `1.0f`.
        public unsafe void DrawCoordinateSystem(JPH.Const_Mat44 inTransform, float? inSize = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawCoordinateSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawCoordinateSystem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawCoordinateSystem(_Underlying *_this, JPH.Const_Mat44._Underlying *inTransform, float *inSize);
            float __deref_inSize = inSize.GetValueOrDefault();
            __JPH_DebugRenderer_DrawCoordinateSystem(_UnderlyingPtr, inTransform._UnderlyingPtr, inSize.HasValue ? &__deref_inSize : null);
        }

        /// Draw a plane through inPoint with normal inNormal
        /// Generated from method `JPH::DebugRenderer::DrawPlane`.
        public unsafe void DrawPlane(JPH.Const_Vec3 inPoint, JPH.Const_Vec3 inNormal, JPH.Const_Color inColor, float inSize)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawPlane(_Underlying *_this, JPH.Vec3._Underlying *inPoint, JPH.Vec3._Underlying *inNormal, JPH.Color._Underlying *inColor, float inSize);
            __JPH_DebugRenderer_DrawPlane(_UnderlyingPtr, inPoint._UnderlyingPtr, inNormal._UnderlyingPtr, inColor._UnderlyingPtr, inSize);
        }

        /// Draw wireframe triangle
        /// Generated from method `JPH::DebugRenderer::DrawWireTriangle`.
        public unsafe void DrawWireTriangle(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3, JPH.Const_Color inColor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawWireTriangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawWireTriangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawWireTriangle(_Underlying *_this, JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3, JPH.Color._Underlying *inColor);
            __JPH_DebugRenderer_DrawWireTriangle(_UnderlyingPtr, inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr, inColor._UnderlyingPtr);
        }

        /// Draw wireframe sphere
        /// Generated from method `JPH::DebugRenderer::DrawWireSphere`.
        /// Parameter `inLevel` defaults to `3`.
        public unsafe void DrawWireSphere(JPH.Const_Vec3 inCenter, float inRadius, JPH.Const_Color inColor, int? inLevel = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawWireSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawWireSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawWireSphere(_Underlying *_this, JPH.Vec3._Underlying *inCenter, float inRadius, JPH.Color._Underlying *inColor, int *inLevel);
            int __deref_inLevel = inLevel.GetValueOrDefault();
            __JPH_DebugRenderer_DrawWireSphere(_UnderlyingPtr, inCenter._UnderlyingPtr, inRadius, inColor._UnderlyingPtr, inLevel.HasValue ? &__deref_inLevel : null);
        }

        /// Generated from method `JPH::DebugRenderer::DrawWireUnitSphere`.
        /// Parameter `inLevel` defaults to `3`.
        public unsafe void DrawWireUnitSphere(JPH.Const_Mat44 inMatrix, JPH.Const_Color inColor, int? inLevel = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawWireUnitSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawWireUnitSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawWireUnitSphere(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, JPH.Color._Underlying *inColor, int *inLevel);
            int __deref_inLevel = inLevel.GetValueOrDefault();
            __JPH_DebugRenderer_DrawWireUnitSphere(_UnderlyingPtr, inMatrix._UnderlyingPtr, inColor._UnderlyingPtr, inLevel.HasValue ? &__deref_inLevel : null);
        }

        /// Draw a single back face culled triangle
        /// Generated from method `JPH::DebugRenderer::DrawTriangle`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::Off`.
        public unsafe void DrawTriangle(JPH.Const_Vec3 inV1, JPH.Const_Vec3 inV2, JPH.Const_Vec3 inV3, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawTriangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawTriangle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawTriangle(_Underlying *_this, JPH.Vec3._Underlying *inV1, JPH.Vec3._Underlying *inV2, JPH.Vec3._Underlying *inV3, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            __JPH_DebugRenderer_DrawTriangle(_UnderlyingPtr, inV1._UnderlyingPtr, inV2._UnderlyingPtr, inV3._UnderlyingPtr, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null);
        }

        /// Draw a box
        /// Generated from method `JPH::DebugRenderer::DrawBox`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawBox(JPH.Const_AABox inBox, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawBox_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawBox_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawBox_4(_Underlying *_this, JPH.Const_AABox._Underlying *inBox, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRenderer_DrawBox_4(_UnderlyingPtr, inBox._UnderlyingPtr, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Generated from method `JPH::DebugRenderer::DrawBox`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawBox(JPH.Const_Mat44 inMatrix, JPH.Const_AABox inBox, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawBox_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawBox_5", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawBox_5(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, JPH.Const_AABox._Underlying *inBox, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRenderer_DrawBox_5(_UnderlyingPtr, inMatrix._UnderlyingPtr, inBox._UnderlyingPtr, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draw a sphere
        /// Generated from method `JPH::DebugRenderer::DrawSphere`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawSphere(JPH.Const_Vec3 inCenter, float inRadius, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawSphere(_Underlying *_this, JPH.Vec3._Underlying *inCenter, float inRadius, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRenderer_DrawSphere(_UnderlyingPtr, inCenter._UnderlyingPtr, inRadius, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Generated from method `JPH::DebugRenderer::DrawUnitSphere`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawUnitSphere(JPH.Const_Mat44 inMatrix, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawUnitSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawUnitSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawUnitSphere(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRenderer_DrawUnitSphere(_UnderlyingPtr, inMatrix._UnderlyingPtr, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draw a capsule with one half sphere at (0, -inHalfHeightOfCylinder, 0) and the other half sphere at (0, inHalfHeightOfCylinder, 0) and radius inRadius.
        /// The capsule will be transformed by inMatrix.
        /// Generated from method `JPH::DebugRenderer::DrawCapsule`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawCapsule(JPH.Const_Mat44 inMatrix, float inHalfHeightOfCylinder, float inRadius, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawCapsule", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawCapsule", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawCapsule(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inHalfHeightOfCylinder, float inRadius, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRenderer_DrawCapsule(_UnderlyingPtr, inMatrix._UnderlyingPtr, inHalfHeightOfCylinder, inRadius, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draw a cylinder with top (0, inHalfHeight, 0) and bottom (0, -inHalfHeight, 0) and radius inRadius.
        /// The cylinder will be transformed by inMatrix
        /// Generated from method `JPH::DebugRenderer::DrawCylinder`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawCylinder(JPH.Const_Mat44 inMatrix, float inHalfHeight, float inRadius, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawCylinder(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inHalfHeight, float inRadius, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRenderer_DrawCylinder(_UnderlyingPtr, inMatrix._UnderlyingPtr, inHalfHeight, inRadius, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
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
        /// Generated from method `JPH::DebugRenderer::DrawOpenCone`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawOpenCone(JPH.Const_Vec3 inTop, JPH.Const_Vec3 inAxis, JPH.Const_Vec3 inPerpendicular, float inHalfAngle, float inLength, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawOpenCone", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawOpenCone", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawOpenCone(_Underlying *_this, JPH.Vec3._Underlying *inTop, JPH.Vec3._Underlying *inAxis, JPH.Vec3._Underlying *inPerpendicular, float inHalfAngle, float inLength, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRenderer_DrawOpenCone(_UnderlyingPtr, inTop._UnderlyingPtr, inAxis._UnderlyingPtr, inPerpendicular._UnderlyingPtr, inHalfAngle, inLength, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }

        /// Draws cone rotation limits as used by the SwingTwistConstraintPart.
        /// @param inMatrix Matrix that transforms from constraint space to world space
        /// @param inSwingYHalfAngle See SwingTwistConstraintPart
        /// @param inSwingZHalfAngle See SwingTwistConstraintPart
        /// @param inEdgeLength Size of the edge of the cone shape
        /// @param inColor Color to use for drawing the cone.
        /// @param inCastShadow determines if this geometry should cast a shadow or not.
        /// @param inDrawMode determines if we draw the geometry solid or in wireframe.
        /// Generated from method `JPH::DebugRenderer::DrawSwingConeLimits`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawSwingConeLimits(JPH.Const_Mat44 inMatrix, float inSwingYHalfAngle, float inSwingZHalfAngle, float inEdgeLength, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawSwingConeLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawSwingConeLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawSwingConeLimits(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inSwingYHalfAngle, float inSwingZHalfAngle, float inEdgeLength, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRenderer_DrawSwingConeLimits(_UnderlyingPtr, inMatrix._UnderlyingPtr, inSwingYHalfAngle, inSwingZHalfAngle, inEdgeLength, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
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
        /// Generated from method `JPH::DebugRenderer::DrawSwingPyramidLimits`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawSwingPyramidLimits(JPH.Const_Mat44 inMatrix, float inMinSwingYAngle, float inMaxSwingYAngle, float inMinSwingZAngle, float inMaxSwingZAngle, float inEdgeLength, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawSwingPyramidLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawSwingPyramidLimits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawSwingPyramidLimits(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inMinSwingYAngle, float inMaxSwingYAngle, float inMinSwingZAngle, float inMaxSwingZAngle, float inEdgeLength, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRenderer_DrawSwingPyramidLimits(_UnderlyingPtr, inMatrix._UnderlyingPtr, inMinSwingYAngle, inMaxSwingYAngle, inMinSwingZAngle, inMaxSwingZAngle, inEdgeLength, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
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
        /// Generated from method `JPH::DebugRenderer::DrawPie`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawPie(JPH.Const_Vec3 inCenter, float inRadius, JPH.Const_Vec3 inNormal, JPH.Const_Vec3 inAxis, float inMinAngle, float inMaxAngle, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawPie", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawPie", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawPie(_Underlying *_this, JPH.Vec3._Underlying *inCenter, float inRadius, JPH.Vec3._Underlying *inNormal, JPH.Vec3._Underlying *inAxis, float inMinAngle, float inMaxAngle, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRenderer_DrawPie(_UnderlyingPtr, inCenter._UnderlyingPtr, inRadius, inNormal._UnderlyingPtr, inAxis._UnderlyingPtr, inMinAngle, inMaxAngle, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
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
        /// Generated from method `JPH::DebugRenderer::DrawTaperedCylinder`.
        /// Parameter `inCastShadow` defaults to `ECastShadow::On`.
        /// Parameter `inDrawMode` defaults to `EDrawMode::Solid`.
        public unsafe void DrawTaperedCylinder(JPH.Const_Mat44 inMatrix, float inTop, float inBottom, float inTopRadius, float inBottomRadius, JPH.Const_Color inColor, JPH.DebugRenderer.ECastShadow? inCastShadow = null, JPH.DebugRenderer.EDrawMode? inDrawMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JPH_DebugRenderer_DrawTaperedCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JPH_DebugRenderer_DrawTaperedCylinder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JPH_DebugRenderer_DrawTaperedCylinder(_Underlying *_this, JPH.Const_Mat44._Underlying *inMatrix, float inTop, float inBottom, float inTopRadius, float inBottomRadius, JPH.Color._Underlying *inColor, JPH.DebugRenderer.ECastShadow *inCastShadow, JPH.DebugRenderer.EDrawMode *inDrawMode);
            JPH.DebugRenderer.ECastShadow __deref_inCastShadow = inCastShadow.GetValueOrDefault();
            JPH.DebugRenderer.EDrawMode __deref_inDrawMode = inDrawMode.GetValueOrDefault();
            __JPH_DebugRenderer_DrawTaperedCylinder(_UnderlyingPtr, inMatrix._UnderlyingPtr, inTop, inBottom, inTopRadius, inBottomRadius, inColor._UnderlyingPtr, inCastShadow.HasValue ? &__deref_inCastShadow : null, inDrawMode.HasValue ? &__deref_inDrawMode : null);
        }
    }

    /// This is used for optional parameters of class `DebugRenderer` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_DebugRenderer`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `DebugRenderer`/`Const_DebugRenderer` directly.
    public class _InOptMut_DebugRenderer
    {
        public DebugRenderer? Opt;

        public _InOptMut_DebugRenderer() {}
        public _InOptMut_DebugRenderer(DebugRenderer value) {Opt = value;}
        public static implicit operator _InOptMut_DebugRenderer(DebugRenderer value) {return new(value);}
    }

    /// This is used for optional parameters of class `DebugRenderer` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_DebugRenderer`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `DebugRenderer`/`Const_DebugRenderer` to pass it to the function.
    public class _InOptConst_DebugRenderer
    {
        public Const_DebugRenderer? Opt;

        public _InOptConst_DebugRenderer() {}
        public _InOptConst_DebugRenderer(Const_DebugRenderer value) {Opt = value;}
        public static implicit operator _InOptConst_DebugRenderer(Const_DebugRenderer value) {return new(value);}
    }
}
