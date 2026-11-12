// machine generated, do not edit
public static partial class JPH
{
    /// Generated from C++ container `JPH::Array<JPH::Wheel *>`.
    /// This is the const half of the class.
    public class Const_Array_JPHWheelPtr : JPH.Object<Const_Array_JPHWheelPtr>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_Wheel_ptr_Destroy(_Underlying *_this);
            __Jolt_JPH_Array_JPH_Wheel_ptr_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Array_JPHWheelPtr() {Dispose(false);}

        internal unsafe Const_Array_JPHWheelPtr(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Array_JPHWheelPtr() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHWheelPtr._Underlying *__Jolt_JPH_Array_JPH_Wheel_ptr_DefaultConstruct();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_Wheel_ptr_DefaultConstruct();
        }

        /// Constructs a copy of another instance. The source remains alive.
        public unsafe Const_Array_JPHWheelPtr(JPH._ByValue_Array_JPHWheelPtr other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHWheelPtr._Underlying *__Jolt_JPH_Array_JPH_Wheel_ptr_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Array_JPHWheelPtr._Underlying *other);
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_Wheel_ptr_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /// Constructs a copy of another instance. The source remains alive.
        public Const_Array_JPHWheelPtr(Const_Array_JPHWheelPtr other) : this(new _ByValue_Array_JPHWheelPtr(other)) {}

        /// Constructs a copy of another instance. The source remains alive.
        public Const_Array_JPHWheelPtr(Array_JPHWheelPtr other) : this((Const_Array_JPHWheelPtr)other) {}

        /// The number of elements.
        public unsafe UIntPtr Size()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __Jolt_JPH_Array_JPH_Wheel_ptr_size(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_Wheel_ptr_size(_UnderlyingPtr);
        }

        /// Returns true if the size is zero.
        public unsafe bool Empty()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_empty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_empty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_JPH_Array_JPH_Wheel_ptr_empty(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_Wheel_ptr_empty(_UnderlyingPtr) != 0;
        }

        /// The memory capacity, measued in the number of elements.
        public unsafe UIntPtr Capacity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_capacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_capacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __Jolt_JPH_Array_JPH_Wheel_ptr_capacity(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_Wheel_ptr_capacity(_UnderlyingPtr);
        }

        /// The element at a specific index, read-only.
        /// In C++ this function returns an rvalue reference.
        public unsafe ref readonly void *this[UIntPtr i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_at", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_at", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void **__Jolt_JPH_Array_JPH_Wheel_ptr_at(_Underlying *_this, UIntPtr i);
                return ref *__Jolt_JPH_Array_JPH_Wheel_ptr_at(_UnderlyingPtr, i);
            }
        }

        /// The first element or null if empty, read-only.
        public unsafe void **Front()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_front", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_front", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void **__Jolt_JPH_Array_JPH_Wheel_ptr_front(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_Wheel_ptr_front(_UnderlyingPtr);
        }

        /// The last element or null if empty, read-only.
        public unsafe void **Back()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void **__Jolt_JPH_Array_JPH_Wheel_ptr_back(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_Wheel_ptr_back(_UnderlyingPtr);
        }
    }

    /// Generated from C++ container `JPH::Array<JPH::Wheel *>`.
    /// This is the non-const half of the class.
    public class Array_JPHWheelPtr : Const_Array_JPHWheelPtr
    {
        internal unsafe Array_JPHWheelPtr(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Array_JPHWheelPtr() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHWheelPtr._Underlying *__Jolt_JPH_Array_JPH_Wheel_ptr_DefaultConstruct();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_Wheel_ptr_DefaultConstruct();
        }

        /// Constructs a copy of another instance. The source remains alive.
        public unsafe Array_JPHWheelPtr(JPH._ByValue_Array_JPHWheelPtr other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHWheelPtr._Underlying *__Jolt_JPH_Array_JPH_Wheel_ptr_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Array_JPHWheelPtr._Underlying *other);
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_Wheel_ptr_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /// Constructs a copy of another instance. The source remains alive.
        public Array_JPHWheelPtr(Const_Array_JPHWheelPtr other) : this(new _ByValue_Array_JPHWheelPtr(other)) {}

        /// Constructs a copy of another instance. The source remains alive.
        public Array_JPHWheelPtr(Array_JPHWheelPtr other) : this((Const_Array_JPHWheelPtr)other) {}

        /// Assigns the contents from another instance. Both objects remain alive after the call.
        public unsafe void Assign(JPH._ByValue_Array_JPHWheelPtr other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_Wheel_ptr_AssignFromAnother(_Underlying *_this, JPH._PassBy other_pass_by, JPH.Array_JPHWheelPtr._Underlying *other);
            _DiscardKeepAlive();
            if (other.Value is not null) _KeepAlive(other.Value);
            __Jolt_JPH_Array_JPH_Wheel_ptr_AssignFromAnother(_UnderlyingPtr, other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
        }

        /// Resizes the container. The new elements if any are zeroed.
        public unsafe void Resize(UIntPtr new_size)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_resize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_resize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_Wheel_ptr_resize(_Underlying *_this, UIntPtr new_size);
            __Jolt_JPH_Array_JPH_Wheel_ptr_resize(_UnderlyingPtr, new_size);
        }

        /// Resizes the container. The new elements if any are set to the specified value.
        public unsafe void ResizeWithDefaultValue(UIntPtr new_size, JPH.Wheel? value)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_resize_with_default_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_resize_with_default_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_Wheel_ptr_resize_with_default_value(_Underlying *_this, UIntPtr new_size, JPH.Wheel._Underlying *value);
            __Jolt_JPH_Array_JPH_Wheel_ptr_resize_with_default_value(_UnderlyingPtr, new_size, value is not null ? value._UnderlyingPtr : null);
        }

        /// Removes all elements from the container.
        public unsafe void Clear()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_Wheel_ptr_clear(_Underlying *_this);
            _DiscardKeepAlive();
            __Jolt_JPH_Array_JPH_Wheel_ptr_clear(_UnderlyingPtr);
        }

        /// Reserves memory for a certain number of elements. Never shrinks the memory.
        public unsafe void Reserve(UIntPtr new_capacity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_Wheel_ptr_reserve(_Underlying *_this, UIntPtr new_capacity);
            __Jolt_JPH_Array_JPH_Wheel_ptr_reserve(_UnderlyingPtr, new_capacity);
        }

        /// Shrinks the capacity to match the size.
        public unsafe void ShrinkToFit()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_shrink_to_fit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_shrink_to_fit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_Wheel_ptr_shrink_to_fit(_Underlying *_this);
            __Jolt_JPH_Array_JPH_Wheel_ptr_shrink_to_fit(_UnderlyingPtr);
        }

        /// The element at a specific index, mutable.
        /// In C++ this function returns an rvalue reference.
        public unsafe new ref void *this[UIntPtr i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_at_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_at_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void **__Jolt_JPH_Array_JPH_Wheel_ptr_at_mut(_Underlying *_this, UIntPtr i);
                return ref *__Jolt_JPH_Array_JPH_Wheel_ptr_at_mut(_UnderlyingPtr, i);
            }
        }

        /// The first element or null if empty, mutable.
        public unsafe new void **Front()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_front_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_front_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void **__Jolt_JPH_Array_JPH_Wheel_ptr_front_mut(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_Wheel_ptr_front_mut(_UnderlyingPtr);
        }

        /// The last element or null if empty, mutable.
        public unsafe new void **Back()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_back_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_back_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void **__Jolt_JPH_Array_JPH_Wheel_ptr_back_mut(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_Wheel_ptr_back_mut(_UnderlyingPtr);
        }

        /// Inserts a new element at the end.
        public unsafe void PushBack(JPH.Wheel? new_elem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_push_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_push_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_Wheel_ptr_push_back(_Underlying *_this, JPH.Wheel._Underlying *new_elem);
            if (new_elem is not null) _KeepAlive(new_elem);
            __Jolt_JPH_Array_JPH_Wheel_ptr_push_back(_UnderlyingPtr, new_elem is not null ? new_elem._UnderlyingPtr : null);
        }

        /// Removes one element from the end.
        public unsafe void PopBack()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_pop_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_pop_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_Wheel_ptr_pop_back(_Underlying *_this);
            __Jolt_JPH_Array_JPH_Wheel_ptr_pop_back(_UnderlyingPtr);
        }

        /// Inserts a new element right before the specified position.
        public unsafe void Insert(UIntPtr position, JPH.Wheel? new_elem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_Wheel_ptr_insert(_Underlying *_this, UIntPtr position, JPH.Wheel._Underlying *new_elem);
            if (new_elem is not null) _KeepAlive(new_elem);
            __Jolt_JPH_Array_JPH_Wheel_ptr_insert(_UnderlyingPtr, position, new_elem is not null ? new_elem._UnderlyingPtr : null);
        }

        /// Erases the element at the specified position.
        public unsafe void Erase(UIntPtr position)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_erase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_Wheel_ptr_erase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_Wheel_ptr_erase(_Underlying *_this, UIntPtr position);
            __Jolt_JPH_Array_JPH_Wheel_ptr_erase(_UnderlyingPtr, position);
        }
    }

    /// This is used as a function parameter when the underlying function receives `Array_JPHWheelPtr` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `Array_JPHWheelPtr`/`Const_Array_JPHWheelPtr` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_Array_JPHWheelPtr
    {
        #pragma warning disable CS0649
        internal readonly Const_Array_JPHWheelPtr? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_Array_JPHWheelPtr() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_Array_JPHWheelPtr(Const_Array_JPHWheelPtr new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_Array_JPHWheelPtr(Const_Array_JPHWheelPtr arg) {return new(arg);}
        public _ByValue_Array_JPHWheelPtr(JPH._Moved<Array_JPHWheelPtr> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_Array_JPHWheelPtr(JPH._Moved<Array_JPHWheelPtr> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `Array_JPHWheelPtr` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Array_JPHWheelPtr`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Array_JPHWheelPtr`/`Const_Array_JPHWheelPtr` directly.
    public class _InOptMut_Array_JPHWheelPtr
    {
        public Array_JPHWheelPtr? Opt;

        public _InOptMut_Array_JPHWheelPtr() {}
        public _InOptMut_Array_JPHWheelPtr(Array_JPHWheelPtr value) {Opt = value;}
        public static implicit operator _InOptMut_Array_JPHWheelPtr(Array_JPHWheelPtr value) {return new(value);}
    }

    /// This is used for optional parameters of class `Array_JPHWheelPtr` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Array_JPHWheelPtr`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Array_JPHWheelPtr`/`Const_Array_JPHWheelPtr` to pass it to the function.
    public class _InOptConst_Array_JPHWheelPtr
    {
        public Const_Array_JPHWheelPtr? Opt;

        public _InOptConst_Array_JPHWheelPtr() {}
        public _InOptConst_Array_JPHWheelPtr(Const_Array_JPHWheelPtr value) {Opt = value;}
        public static implicit operator _InOptConst_Array_JPHWheelPtr(Const_Array_JPHWheelPtr value) {return new(value);}
    }
}
