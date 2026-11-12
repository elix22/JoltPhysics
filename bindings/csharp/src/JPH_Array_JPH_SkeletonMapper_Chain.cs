// machine generated, do not edit
public static partial class JPH
{
    /// Generated from C++ container `JPH::Array<JPH::SkeletonMapper::Chain>`.
    /// This is the const half of the class.
    public class Const_Array_JPHSkeletonMapperChain : JPH.Object<Const_Array_JPHSkeletonMapperChain>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_Destroy(_Underlying *_this);
            __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Array_JPHSkeletonMapperChain() {Dispose(false);}

        internal unsafe Const_Array_JPHSkeletonMapperChain(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Array_JPHSkeletonMapperChain() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSkeletonMapperChain._Underlying *__Jolt_JPH_Array_JPH_SkeletonMapper_Chain_DefaultConstruct();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_DefaultConstruct();
        }

        /// Constructs a copy of another instance. The source remains alive.
        public unsafe Const_Array_JPHSkeletonMapperChain(JPH._ByValue_Array_JPHSkeletonMapperChain other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSkeletonMapperChain._Underlying *__Jolt_JPH_Array_JPH_SkeletonMapper_Chain_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Array_JPHSkeletonMapperChain._Underlying *other);
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /// Constructs a copy of another instance. The source remains alive.
        public Const_Array_JPHSkeletonMapperChain(Const_Array_JPHSkeletonMapperChain other) : this(new _ByValue_Array_JPHSkeletonMapperChain(other)) {}

        /// Constructs a copy of another instance. The source remains alive.
        public Const_Array_JPHSkeletonMapperChain(Array_JPHSkeletonMapperChain other) : this((Const_Array_JPHSkeletonMapperChain)other) {}

        /// The number of elements.
        public unsafe UIntPtr Size()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_size(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_size(_UnderlyingPtr);
        }

        /// Returns true if the size is zero.
        public unsafe bool Empty()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_empty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_empty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_empty(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_empty(_UnderlyingPtr) != 0;
        }

        /// The memory capacity, measued in the number of elements.
        public unsafe UIntPtr Capacity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_capacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_capacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_capacity(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_capacity(_UnderlyingPtr);
        }

        /// The element at a specific index, read-only.
        public unsafe JPH.SkeletonMapper.Const_Chain this[UIntPtr i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_at", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_at", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Const_Chain._Underlying *__Jolt_JPH_Array_JPH_SkeletonMapper_Chain_at(_Underlying *_this, UIntPtr i);
                JPH.SkeletonMapper.Const_Chain __ret;
                __ret = new(__Jolt_JPH_Array_JPH_SkeletonMapper_Chain_at(_UnderlyingPtr, i), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// The first element or null if empty, read-only.
        public unsafe JPH.SkeletonMapper.Const_Chain? Front()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_front", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_front", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletonMapper.Const_Chain._Underlying *__Jolt_JPH_Array_JPH_SkeletonMapper_Chain_front(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_front(_UnderlyingPtr);
            JPH.SkeletonMapper.Const_Chain? __ret;
            __ret = __c_ret is not null ? new JPH.SkeletonMapper.Const_Chain(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// The last element or null if empty, read-only.
        public unsafe JPH.SkeletonMapper.Const_Chain? Back()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletonMapper.Const_Chain._Underlying *__Jolt_JPH_Array_JPH_SkeletonMapper_Chain_back(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_back(_UnderlyingPtr);
            JPH.SkeletonMapper.Const_Chain? __ret;
            __ret = __c_ret is not null ? new JPH.SkeletonMapper.Const_Chain(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }
    }

    /// Generated from C++ container `JPH::Array<JPH::SkeletonMapper::Chain>`.
    /// This is the non-const half of the class.
    public class Array_JPHSkeletonMapperChain : Const_Array_JPHSkeletonMapperChain
    {
        internal unsafe Array_JPHSkeletonMapperChain(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Array_JPHSkeletonMapperChain() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSkeletonMapperChain._Underlying *__Jolt_JPH_Array_JPH_SkeletonMapper_Chain_DefaultConstruct();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_DefaultConstruct();
        }

        /// Constructs a copy of another instance. The source remains alive.
        public unsafe Array_JPHSkeletonMapperChain(JPH._ByValue_Array_JPHSkeletonMapperChain other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSkeletonMapperChain._Underlying *__Jolt_JPH_Array_JPH_SkeletonMapper_Chain_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Array_JPHSkeletonMapperChain._Underlying *other);
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /// Constructs a copy of another instance. The source remains alive.
        public Array_JPHSkeletonMapperChain(Const_Array_JPHSkeletonMapperChain other) : this(new _ByValue_Array_JPHSkeletonMapperChain(other)) {}

        /// Constructs a copy of another instance. The source remains alive.
        public Array_JPHSkeletonMapperChain(Array_JPHSkeletonMapperChain other) : this((Const_Array_JPHSkeletonMapperChain)other) {}

        /// Assigns the contents from another instance. Both objects remain alive after the call.
        public unsafe void Assign(JPH._ByValue_Array_JPHSkeletonMapperChain other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_AssignFromAnother(_Underlying *_this, JPH._PassBy other_pass_by, JPH.Array_JPHSkeletonMapperChain._Underlying *other);
            _DiscardKeepAlive();
            if (other.Value is not null) _KeepAlive(other.Value);
            __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_AssignFromAnother(_UnderlyingPtr, other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
        }

        /// Resizes the container. The new elements if any are zeroed.
        public unsafe void Resize(UIntPtr new_size)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_resize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_resize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_resize(_Underlying *_this, UIntPtr new_size);
            __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_resize(_UnderlyingPtr, new_size);
        }

        /// Resizes the container. The new elements if any are set to the specified value.
        public unsafe void ResizeWithDefaultValue(UIntPtr new_size, JPH.SkeletonMapper.Const_Chain value)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_resize_with_default_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_resize_with_default_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_resize_with_default_value(_Underlying *_this, UIntPtr new_size, JPH.SkeletonMapper.Const_Chain._Underlying *value);
            __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_resize_with_default_value(_UnderlyingPtr, new_size, value._UnderlyingPtr);
        }

        /// Removes all elements from the container.
        public unsafe void Clear()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_clear(_Underlying *_this);
            _DiscardKeepAlive();
            __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_clear(_UnderlyingPtr);
        }

        /// Reserves memory for a certain number of elements. Never shrinks the memory.
        public unsafe void Reserve(UIntPtr new_capacity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_reserve(_Underlying *_this, UIntPtr new_capacity);
            __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_reserve(_UnderlyingPtr, new_capacity);
        }

        /// Shrinks the capacity to match the size.
        public unsafe void ShrinkToFit()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_shrink_to_fit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_shrink_to_fit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_shrink_to_fit(_Underlying *_this);
            __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_shrink_to_fit(_UnderlyingPtr);
        }

        /// The element at a specific index, mutable.
        public unsafe new JPH.SkeletonMapper.Chain this[UIntPtr i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_at_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_at_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SkeletonMapper.Chain._Underlying *__Jolt_JPH_Array_JPH_SkeletonMapper_Chain_at_mut(_Underlying *_this, UIntPtr i);
                JPH.SkeletonMapper.Chain __ret;
                __ret = new(__Jolt_JPH_Array_JPH_SkeletonMapper_Chain_at_mut(_UnderlyingPtr, i), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// The first element or null if empty, mutable.
        public unsafe new JPH.SkeletonMapper.Chain? Front()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_front_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_front_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletonMapper.Chain._Underlying *__Jolt_JPH_Array_JPH_SkeletonMapper_Chain_front_mut(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_front_mut(_UnderlyingPtr);
            JPH.SkeletonMapper.Chain? __ret;
            __ret = __c_ret is not null ? new JPH.SkeletonMapper.Chain(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// The last element or null if empty, mutable.
        public unsafe new JPH.SkeletonMapper.Chain? Back()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_back_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_back_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SkeletonMapper.Chain._Underlying *__Jolt_JPH_Array_JPH_SkeletonMapper_Chain_back_mut(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_back_mut(_UnderlyingPtr);
            JPH.SkeletonMapper.Chain? __ret;
            __ret = __c_ret is not null ? new JPH.SkeletonMapper.Chain(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// Inserts a new element at the end.
        public unsafe void PushBack(JPH.SkeletonMapper._ByValue_Chain new_elem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_push_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_push_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_push_back(_Underlying *_this, JPH._PassBy new_elem_pass_by, JPH.SkeletonMapper.Chain._Underlying *new_elem);
            if (new_elem.Value is not null) _KeepAlive(new_elem.Value);
            __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_push_back(_UnderlyingPtr, new_elem.PassByMode, new_elem.Value is not null ? new_elem.Value._UnderlyingPtr : null);
        }

        /// Removes one element from the end.
        public unsafe void PopBack()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_pop_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_pop_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_pop_back(_Underlying *_this);
            __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_pop_back(_UnderlyingPtr);
        }

        /// Inserts a new element right before the specified position.
        public unsafe void Insert(UIntPtr position, JPH.SkeletonMapper._ByValue_Chain new_elem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_insert(_Underlying *_this, UIntPtr position, JPH._PassBy new_elem_pass_by, JPH.SkeletonMapper.Chain._Underlying *new_elem);
            if (new_elem.Value is not null) _KeepAlive(new_elem.Value);
            __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_insert(_UnderlyingPtr, position, new_elem.PassByMode, new_elem.Value is not null ? new_elem.Value._UnderlyingPtr : null);
        }

        /// Erases the element at the specified position.
        public unsafe void Erase(UIntPtr position)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_erase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SkeletonMapper_Chain_erase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_erase(_Underlying *_this, UIntPtr position);
            __Jolt_JPH_Array_JPH_SkeletonMapper_Chain_erase(_UnderlyingPtr, position);
        }
    }

    /// This is used as a function parameter when the underlying function receives `Array_JPHSkeletonMapperChain` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `Array_JPHSkeletonMapperChain`/`Const_Array_JPHSkeletonMapperChain` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_Array_JPHSkeletonMapperChain
    {
        #pragma warning disable CS0649
        internal readonly Const_Array_JPHSkeletonMapperChain? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_Array_JPHSkeletonMapperChain() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_Array_JPHSkeletonMapperChain(Const_Array_JPHSkeletonMapperChain new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_Array_JPHSkeletonMapperChain(Const_Array_JPHSkeletonMapperChain arg) {return new(arg);}
        public _ByValue_Array_JPHSkeletonMapperChain(JPH._Moved<Array_JPHSkeletonMapperChain> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_Array_JPHSkeletonMapperChain(JPH._Moved<Array_JPHSkeletonMapperChain> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `Array_JPHSkeletonMapperChain` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Array_JPHSkeletonMapperChain`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Array_JPHSkeletonMapperChain`/`Const_Array_JPHSkeletonMapperChain` directly.
    public class _InOptMut_Array_JPHSkeletonMapperChain
    {
        public Array_JPHSkeletonMapperChain? Opt;

        public _InOptMut_Array_JPHSkeletonMapperChain() {}
        public _InOptMut_Array_JPHSkeletonMapperChain(Array_JPHSkeletonMapperChain value) {Opt = value;}
        public static implicit operator _InOptMut_Array_JPHSkeletonMapperChain(Array_JPHSkeletonMapperChain value) {return new(value);}
    }

    /// This is used for optional parameters of class `Array_JPHSkeletonMapperChain` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Array_JPHSkeletonMapperChain`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Array_JPHSkeletonMapperChain`/`Const_Array_JPHSkeletonMapperChain` to pass it to the function.
    public class _InOptConst_Array_JPHSkeletonMapperChain
    {
        public Const_Array_JPHSkeletonMapperChain? Opt;

        public _InOptConst_Array_JPHSkeletonMapperChain() {}
        public _InOptConst_Array_JPHSkeletonMapperChain(Const_Array_JPHSkeletonMapperChain value) {Opt = value;}
        public static implicit operator _InOptConst_Array_JPHSkeletonMapperChain(Const_Array_JPHSkeletonMapperChain value) {return new(value);}
    }
}
