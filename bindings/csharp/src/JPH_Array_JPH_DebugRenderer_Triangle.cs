// machine generated, do not edit
public static partial class JPH
{
    /// Generated from C++ container `JPH::Array<JPH::DebugRenderer::Triangle>`.
    /// This is the const half of the class.
    public class Const_Array_JPHDebugRendererTriangle : JPH.Object<Const_Array_JPHDebugRendererTriangle>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_Destroy(_Underlying *_this);
            __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Array_JPHDebugRendererTriangle() {Dispose(false);}

        internal unsafe Const_Array_JPHDebugRendererTriangle(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Array_JPHDebugRendererTriangle() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHDebugRendererTriangle._Underlying *__Jolt_JPH_Array_JPH_DebugRenderer_Triangle_DefaultConstruct();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_DefaultConstruct();
        }

        /// Constructs a copy of another instance. The source remains alive.
        public unsafe Const_Array_JPHDebugRendererTriangle(JPH._ByValue_Array_JPHDebugRendererTriangle other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHDebugRendererTriangle._Underlying *__Jolt_JPH_Array_JPH_DebugRenderer_Triangle_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Array_JPHDebugRendererTriangle._Underlying *other);
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /// Constructs a copy of another instance. The source remains alive.
        public Const_Array_JPHDebugRendererTriangle(Const_Array_JPHDebugRendererTriangle other) : this(new _ByValue_Array_JPHDebugRendererTriangle(other)) {}

        /// Constructs a copy of another instance. The source remains alive.
        public Const_Array_JPHDebugRendererTriangle(Array_JPHDebugRendererTriangle other) : this((Const_Array_JPHDebugRendererTriangle)other) {}

        /// The number of elements.
        public unsafe UIntPtr Size()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_size(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_size(_UnderlyingPtr);
        }

        /// Returns true if the size is zero.
        public unsafe bool Empty()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_empty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_empty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_empty(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_empty(_UnderlyingPtr) != 0;
        }

        /// The memory capacity, measued in the number of elements.
        public unsafe UIntPtr Capacity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_capacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_capacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_capacity(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_capacity(_UnderlyingPtr);
        }

        /// The element at a specific index, read-only.
        public unsafe JPH.DebugRenderer.Const_Triangle this[UIntPtr i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_at", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_at", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Const_Triangle._Underlying *__Jolt_JPH_Array_JPH_DebugRenderer_Triangle_at(_Underlying *_this, UIntPtr i);
                JPH.DebugRenderer.Const_Triangle __ret;
                __ret = new(__Jolt_JPH_Array_JPH_DebugRenderer_Triangle_at(_UnderlyingPtr, i), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// The first element or null if empty, read-only.
        public unsafe JPH.DebugRenderer.Const_Triangle? Front()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_front", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_front", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugRenderer.Const_Triangle._Underlying *__Jolt_JPH_Array_JPH_DebugRenderer_Triangle_front(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_front(_UnderlyingPtr);
            JPH.DebugRenderer.Const_Triangle? __ret;
            __ret = __c_ret is not null ? new JPH.DebugRenderer.Const_Triangle(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// The last element or null if empty, read-only.
        public unsafe JPH.DebugRenderer.Const_Triangle? Back()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugRenderer.Const_Triangle._Underlying *__Jolt_JPH_Array_JPH_DebugRenderer_Triangle_back(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_back(_UnderlyingPtr);
            JPH.DebugRenderer.Const_Triangle? __ret;
            __ret = __c_ret is not null ? new JPH.DebugRenderer.Const_Triangle(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }
    }

    /// Generated from C++ container `JPH::Array<JPH::DebugRenderer::Triangle>`.
    /// This is the non-const half of the class.
    public class Array_JPHDebugRendererTriangle : Const_Array_JPHDebugRendererTriangle
    {
        internal unsafe Array_JPHDebugRendererTriangle(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Array_JPHDebugRendererTriangle() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHDebugRendererTriangle._Underlying *__Jolt_JPH_Array_JPH_DebugRenderer_Triangle_DefaultConstruct();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_DefaultConstruct();
        }

        /// Constructs a copy of another instance. The source remains alive.
        public unsafe Array_JPHDebugRendererTriangle(JPH._ByValue_Array_JPHDebugRendererTriangle other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHDebugRendererTriangle._Underlying *__Jolt_JPH_Array_JPH_DebugRenderer_Triangle_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Array_JPHDebugRendererTriangle._Underlying *other);
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /// Constructs a copy of another instance. The source remains alive.
        public Array_JPHDebugRendererTriangle(Const_Array_JPHDebugRendererTriangle other) : this(new _ByValue_Array_JPHDebugRendererTriangle(other)) {}

        /// Constructs a copy of another instance. The source remains alive.
        public Array_JPHDebugRendererTriangle(Array_JPHDebugRendererTriangle other) : this((Const_Array_JPHDebugRendererTriangle)other) {}

        /// Assigns the contents from another instance. Both objects remain alive after the call.
        public unsafe void Assign(JPH._ByValue_Array_JPHDebugRendererTriangle other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_AssignFromAnother(_Underlying *_this, JPH._PassBy other_pass_by, JPH.Array_JPHDebugRendererTriangle._Underlying *other);
            _DiscardKeepAlive();
            if (other.Value is not null) _KeepAlive(other.Value);
            __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_AssignFromAnother(_UnderlyingPtr, other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
        }

        /// Resizes the container. The new elements if any are zeroed.
        public unsafe void Resize(UIntPtr new_size)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_resize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_resize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_resize(_Underlying *_this, UIntPtr new_size);
            __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_resize(_UnderlyingPtr, new_size);
        }

        /// Resizes the container. The new elements if any are set to the specified value.
        public unsafe void ResizeWithDefaultValue(UIntPtr new_size, JPH.DebugRenderer.Const_Triangle value)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_resize_with_default_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_resize_with_default_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_resize_with_default_value(_Underlying *_this, UIntPtr new_size, JPH.DebugRenderer.Const_Triangle._Underlying *value);
            __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_resize_with_default_value(_UnderlyingPtr, new_size, value._UnderlyingPtr);
        }

        /// Removes all elements from the container.
        public unsafe void Clear()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_clear(_Underlying *_this);
            _DiscardKeepAlive();
            __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_clear(_UnderlyingPtr);
        }

        /// Reserves memory for a certain number of elements. Never shrinks the memory.
        public unsafe void Reserve(UIntPtr new_capacity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_reserve(_Underlying *_this, UIntPtr new_capacity);
            __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_reserve(_UnderlyingPtr, new_capacity);
        }

        /// Shrinks the capacity to match the size.
        public unsafe void ShrinkToFit()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_shrink_to_fit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_shrink_to_fit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_shrink_to_fit(_Underlying *_this);
            __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_shrink_to_fit(_UnderlyingPtr);
        }

        /// The element at a specific index, mutable.
        public unsafe new JPH.DebugRenderer.Triangle this[UIntPtr i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_at_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_at_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.DebugRenderer.Triangle._Underlying *__Jolt_JPH_Array_JPH_DebugRenderer_Triangle_at_mut(_Underlying *_this, UIntPtr i);
                JPH.DebugRenderer.Triangle __ret;
                __ret = new(__Jolt_JPH_Array_JPH_DebugRenderer_Triangle_at_mut(_UnderlyingPtr, i), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// The first element or null if empty, mutable.
        public unsafe new JPH.DebugRenderer.Triangle? Front()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_front_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_front_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugRenderer.Triangle._Underlying *__Jolt_JPH_Array_JPH_DebugRenderer_Triangle_front_mut(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_front_mut(_UnderlyingPtr);
            JPH.DebugRenderer.Triangle? __ret;
            __ret = __c_ret is not null ? new JPH.DebugRenderer.Triangle(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// The last element or null if empty, mutable.
        public unsafe new JPH.DebugRenderer.Triangle? Back()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_back_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_back_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.DebugRenderer.Triangle._Underlying *__Jolt_JPH_Array_JPH_DebugRenderer_Triangle_back_mut(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_back_mut(_UnderlyingPtr);
            JPH.DebugRenderer.Triangle? __ret;
            __ret = __c_ret is not null ? new JPH.DebugRenderer.Triangle(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// Inserts a new element at the end.
        public unsafe void PushBack(JPH.DebugRenderer.Const_Triangle new_elem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_push_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_push_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_push_back(_Underlying *_this, JPH.DebugRenderer.Triangle._Underlying *new_elem);
            _KeepAlive(new_elem);
            __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_push_back(_UnderlyingPtr, new_elem._UnderlyingPtr);
        }

        /// Removes one element from the end.
        public unsafe void PopBack()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_pop_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_pop_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_pop_back(_Underlying *_this);
            __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_pop_back(_UnderlyingPtr);
        }

        /// Inserts a new element right before the specified position.
        public unsafe void Insert(UIntPtr position, JPH.DebugRenderer.Const_Triangle new_elem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_insert(_Underlying *_this, UIntPtr position, JPH.DebugRenderer.Triangle._Underlying *new_elem);
            _KeepAlive(new_elem);
            __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_insert(_UnderlyingPtr, position, new_elem._UnderlyingPtr);
        }

        /// Erases the element at the specified position.
        public unsafe void Erase(UIntPtr position)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_erase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_DebugRenderer_Triangle_erase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_erase(_Underlying *_this, UIntPtr position);
            __Jolt_JPH_Array_JPH_DebugRenderer_Triangle_erase(_UnderlyingPtr, position);
        }
    }

    /// This is used as a function parameter when the underlying function receives `Array_JPHDebugRendererTriangle` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `Array_JPHDebugRendererTriangle`/`Const_Array_JPHDebugRendererTriangle` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_Array_JPHDebugRendererTriangle
    {
        #pragma warning disable CS0649
        internal readonly Const_Array_JPHDebugRendererTriangle? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_Array_JPHDebugRendererTriangle() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_Array_JPHDebugRendererTriangle(Const_Array_JPHDebugRendererTriangle new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_Array_JPHDebugRendererTriangle(Const_Array_JPHDebugRendererTriangle arg) {return new(arg);}
        public _ByValue_Array_JPHDebugRendererTriangle(JPH._Moved<Array_JPHDebugRendererTriangle> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_Array_JPHDebugRendererTriangle(JPH._Moved<Array_JPHDebugRendererTriangle> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `Array_JPHDebugRendererTriangle` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Array_JPHDebugRendererTriangle`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Array_JPHDebugRendererTriangle`/`Const_Array_JPHDebugRendererTriangle` directly.
    public class _InOptMut_Array_JPHDebugRendererTriangle
    {
        public Array_JPHDebugRendererTriangle? Opt;

        public _InOptMut_Array_JPHDebugRendererTriangle() {}
        public _InOptMut_Array_JPHDebugRendererTriangle(Array_JPHDebugRendererTriangle value) {Opt = value;}
        public static implicit operator _InOptMut_Array_JPHDebugRendererTriangle(Array_JPHDebugRendererTriangle value) {return new(value);}
    }

    /// This is used for optional parameters of class `Array_JPHDebugRendererTriangle` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Array_JPHDebugRendererTriangle`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Array_JPHDebugRendererTriangle`/`Const_Array_JPHDebugRendererTriangle` to pass it to the function.
    public class _InOptConst_Array_JPHDebugRendererTriangle
    {
        public Const_Array_JPHDebugRendererTriangle? Opt;

        public _InOptConst_Array_JPHDebugRendererTriangle() {}
        public _InOptConst_Array_JPHDebugRendererTriangle(Const_Array_JPHDebugRendererTriangle value) {Opt = value;}
        public static implicit operator _InOptConst_Array_JPHDebugRendererTriangle(Const_Array_JPHDebugRendererTriangle value) {return new(value);}
    }
}
