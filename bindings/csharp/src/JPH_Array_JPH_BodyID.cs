// machine generated, do not edit
public static partial class JPH
{
    /// Generated from C++ container `JPH::Array<JPH::BodyID>`.
    /// This is the const half of the class.
    public class Const_Array_JPHBodyID : JPH.Object<Const_Array_JPHBodyID>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_BodyID_Destroy(_Underlying *_this);
            __Jolt_JPH_Array_JPH_BodyID_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Array_JPHBodyID() {Dispose(false);}

        internal unsafe Const_Array_JPHBodyID(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Array_JPHBodyID() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHBodyID._Underlying *__Jolt_JPH_Array_JPH_BodyID_DefaultConstruct();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_BodyID_DefaultConstruct();
        }

        /// Constructs a copy of another instance. The source remains alive.
        public unsafe Const_Array_JPHBodyID(JPH._ByValue_Array_JPHBodyID other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHBodyID._Underlying *__Jolt_JPH_Array_JPH_BodyID_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Array_JPHBodyID._Underlying *other);
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_BodyID_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /// Constructs a copy of another instance. The source remains alive.
        public Const_Array_JPHBodyID(Const_Array_JPHBodyID other) : this(new _ByValue_Array_JPHBodyID(other)) {}

        /// Constructs a copy of another instance. The source remains alive.
        public Const_Array_JPHBodyID(Array_JPHBodyID other) : this((Const_Array_JPHBodyID)other) {}

        /// Construct from a range of elements.
        public unsafe Const_Array_JPHBodyID(JPH.BodyID? ptr, UIntPtr size) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_ConstructFromRange", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_ConstructFromRange", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHBodyID._Underlying *__Jolt_JPH_Array_JPH_BodyID_ConstructFromRange(JPH.BodyID *ptr, UIntPtr size);
            JPH.BodyID __deref_ptr = ptr.GetValueOrDefault();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_BodyID_ConstructFromRange(ptr.HasValue ? &__deref_ptr : null, size);
        }

        /// The number of elements.
        public unsafe UIntPtr Size()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __Jolt_JPH_Array_JPH_BodyID_size(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_BodyID_size(_UnderlyingPtr);
        }

        /// Returns true if the size is zero.
        public unsafe bool Empty()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_empty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_empty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_JPH_Array_JPH_BodyID_empty(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_BodyID_empty(_UnderlyingPtr) != 0;
        }

        /// The memory capacity, measued in the number of elements.
        public unsafe UIntPtr Capacity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_capacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_capacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __Jolt_JPH_Array_JPH_BodyID_capacity(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_BodyID_capacity(_UnderlyingPtr);
        }

        /// The element at a specific index, read-only.
        public unsafe ref readonly JPH.BodyID this[UIntPtr i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_at", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_at", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__Jolt_JPH_Array_JPH_BodyID_at(_Underlying *_this, UIntPtr i);
                return ref *__Jolt_JPH_Array_JPH_BodyID_at(_UnderlyingPtr, i);
            }
        }

        /// The first element or null if empty, read-only.
        public unsafe JPH.BodyID? Front()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_front", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_front", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID *__Jolt_JPH_Array_JPH_BodyID_front(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_BodyID_front(_UnderlyingPtr);
            if (__c_ret is not null) return *__c_ret; else return null;
        }

        /// The last element or null if empty, read-only.
        public unsafe JPH.BodyID? Back()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID *__Jolt_JPH_Array_JPH_BodyID_back(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_BodyID_back(_UnderlyingPtr);
            if (__c_ret is not null) return *__c_ret; else return null;
        }

        /// Returns a pointer to the continuous storage that holds all elements, read-only.
        public unsafe JPH.ConstPtrBodyID Data()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_data", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_data", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID *__Jolt_JPH_Array_JPH_BodyID_data(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_BodyID_data(_UnderlyingPtr);
            return new(__c_ret);
        }
    }

    /// Generated from C++ container `JPH::Array<JPH::BodyID>`.
    /// This is the non-const half of the class.
    public class Array_JPHBodyID : Const_Array_JPHBodyID
    {
        internal unsafe Array_JPHBodyID(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Array_JPHBodyID() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHBodyID._Underlying *__Jolt_JPH_Array_JPH_BodyID_DefaultConstruct();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_BodyID_DefaultConstruct();
        }

        /// Constructs a copy of another instance. The source remains alive.
        public unsafe Array_JPHBodyID(JPH._ByValue_Array_JPHBodyID other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHBodyID._Underlying *__Jolt_JPH_Array_JPH_BodyID_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Array_JPHBodyID._Underlying *other);
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_BodyID_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /// Constructs a copy of another instance. The source remains alive.
        public Array_JPHBodyID(Const_Array_JPHBodyID other) : this(new _ByValue_Array_JPHBodyID(other)) {}

        /// Constructs a copy of another instance. The source remains alive.
        public Array_JPHBodyID(Array_JPHBodyID other) : this((Const_Array_JPHBodyID)other) {}

        /// Assigns the contents from another instance. Both objects remain alive after the call.
        public unsafe void Assign(JPH._ByValue_Array_JPHBodyID other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_BodyID_AssignFromAnother(_Underlying *_this, JPH._PassBy other_pass_by, JPH.Array_JPHBodyID._Underlying *other);
            _DiscardKeepAlive();
            if (other.Value is not null) _KeepAlive(other.Value);
            __Jolt_JPH_Array_JPH_BodyID_AssignFromAnother(_UnderlyingPtr, other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
        }

        /// Construct from a range of elements.
        public unsafe Array_JPHBodyID(JPH.BodyID? ptr, UIntPtr size) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_ConstructFromRange", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_ConstructFromRange", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHBodyID._Underlying *__Jolt_JPH_Array_JPH_BodyID_ConstructFromRange(JPH.BodyID *ptr, UIntPtr size);
            JPH.BodyID __deref_ptr = ptr.GetValueOrDefault();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_BodyID_ConstructFromRange(ptr.HasValue ? &__deref_ptr : null, size);
        }

        /// Assign from a range of elements, overwriting previous contents.
        public unsafe void Assign(JPH.BodyID? ptr, UIntPtr size)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_AssignFromRange", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_AssignFromRange", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_BodyID_AssignFromRange(_Underlying *_this, JPH.BodyID *ptr, UIntPtr size);
            JPH.BodyID __deref_ptr = ptr.GetValueOrDefault();
            __Jolt_JPH_Array_JPH_BodyID_AssignFromRange(_UnderlyingPtr, ptr.HasValue ? &__deref_ptr : null, size);
        }

        /// Resizes the container. The new elements if any are zeroed.
        public unsafe void Resize(UIntPtr new_size)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_resize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_resize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_BodyID_resize(_Underlying *_this, UIntPtr new_size);
            __Jolt_JPH_Array_JPH_BodyID_resize(_UnderlyingPtr, new_size);
        }

        /// Resizes the container. The new elements if any are set to the specified value.
        public unsafe void ResizeWithDefaultValue(UIntPtr new_size, in JPH.BodyID value)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_resize_with_default_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_resize_with_default_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_BodyID_resize_with_default_value(_Underlying *_this, UIntPtr new_size, JPH.BodyID *value);
            fixed (JPH.BodyID *__ptr_value = &value)
            {
                __Jolt_JPH_Array_JPH_BodyID_resize_with_default_value(_UnderlyingPtr, new_size, __ptr_value);
            }
        }

        /// Removes all elements from the container.
        public unsafe void Clear()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_BodyID_clear(_Underlying *_this);
            _DiscardKeepAlive();
            __Jolt_JPH_Array_JPH_BodyID_clear(_UnderlyingPtr);
        }

        /// Reserves memory for a certain number of elements. Never shrinks the memory.
        public unsafe void Reserve(UIntPtr new_capacity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_BodyID_reserve(_Underlying *_this, UIntPtr new_capacity);
            __Jolt_JPH_Array_JPH_BodyID_reserve(_UnderlyingPtr, new_capacity);
        }

        /// Shrinks the capacity to match the size.
        public unsafe void ShrinkToFit()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_shrink_to_fit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_shrink_to_fit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_BodyID_shrink_to_fit(_Underlying *_this);
            __Jolt_JPH_Array_JPH_BodyID_shrink_to_fit(_UnderlyingPtr);
        }

        /// The element at a specific index, mutable.
        public unsafe new ref JPH.BodyID this[UIntPtr i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_at_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_at_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.BodyID *__Jolt_JPH_Array_JPH_BodyID_at_mut(_Underlying *_this, UIntPtr i);
                return ref *__Jolt_JPH_Array_JPH_BodyID_at_mut(_UnderlyingPtr, i);
            }
        }

        /// The first element or null if empty, mutable.
        public unsafe new JPH.Ref<JPH.BodyID>? Front()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_front_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_front_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID *__Jolt_JPH_Array_JPH_BodyID_front_mut(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_BodyID_front_mut(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Ref<JPH.BodyID>(__c_ret) : null;
        }

        /// The last element or null if empty, mutable.
        public unsafe new JPH.Ref<JPH.BodyID>? Back()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_back_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_back_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID *__Jolt_JPH_Array_JPH_BodyID_back_mut(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_BodyID_back_mut(_UnderlyingPtr);
            return __c_ret is not null ? new JPH.Ref<JPH.BodyID>(__c_ret) : null;
        }

        /// Returns a pointer to the continuous storage that holds all elements, mutable.
        public unsafe new JPH.PtrBodyID Data()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_data_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_data_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.BodyID *__Jolt_JPH_Array_JPH_BodyID_data_mut(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_BodyID_data_mut(_UnderlyingPtr);
            return new(__c_ret);
        }

        /// Inserts a new element at the end.
        public unsafe void PushBack(JPH.BodyID new_elem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_push_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_push_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_BodyID_push_back(_Underlying *_this, JPH.BodyID new_elem);
            __Jolt_JPH_Array_JPH_BodyID_push_back(_UnderlyingPtr, new_elem);
        }

        /// Removes one element from the end.
        public unsafe void PopBack()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_pop_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_pop_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_BodyID_pop_back(_Underlying *_this);
            __Jolt_JPH_Array_JPH_BodyID_pop_back(_UnderlyingPtr);
        }

        /// Inserts a new element right before the specified position.
        public unsafe void Insert(UIntPtr position, JPH.BodyID new_elem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_BodyID_insert(_Underlying *_this, UIntPtr position, JPH.BodyID new_elem);
            __Jolt_JPH_Array_JPH_BodyID_insert(_UnderlyingPtr, position, new_elem);
        }

        /// Erases the element at the specified position.
        public unsafe void Erase(UIntPtr position)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_erase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_BodyID_erase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_BodyID_erase(_Underlying *_this, UIntPtr position);
            __Jolt_JPH_Array_JPH_BodyID_erase(_UnderlyingPtr, position);
        }
    }

    /// This is used as a function parameter when the underlying function receives `Array_JPHBodyID` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `Array_JPHBodyID`/`Const_Array_JPHBodyID` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_Array_JPHBodyID
    {
        #pragma warning disable CS0649
        internal readonly Const_Array_JPHBodyID? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_Array_JPHBodyID() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_Array_JPHBodyID(Const_Array_JPHBodyID new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_Array_JPHBodyID(Const_Array_JPHBodyID arg) {return new(arg);}
        public _ByValue_Array_JPHBodyID(JPH._Moved<Array_JPHBodyID> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_Array_JPHBodyID(JPH._Moved<Array_JPHBodyID> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `Array_JPHBodyID` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Array_JPHBodyID`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Array_JPHBodyID`/`Const_Array_JPHBodyID` directly.
    public class _InOptMut_Array_JPHBodyID
    {
        public Array_JPHBodyID? Opt;

        public _InOptMut_Array_JPHBodyID() {}
        public _InOptMut_Array_JPHBodyID(Array_JPHBodyID value) {Opt = value;}
        public static implicit operator _InOptMut_Array_JPHBodyID(Array_JPHBodyID value) {return new(value);}
    }

    /// This is used for optional parameters of class `Array_JPHBodyID` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Array_JPHBodyID`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Array_JPHBodyID`/`Const_Array_JPHBodyID` to pass it to the function.
    public class _InOptConst_Array_JPHBodyID
    {
        public Const_Array_JPHBodyID? Opt;

        public _InOptConst_Array_JPHBodyID() {}
        public _InOptConst_Array_JPHBodyID(Const_Array_JPHBodyID value) {Opt = value;}
        public static implicit operator _InOptConst_Array_JPHBodyID(Const_Array_JPHBodyID value) {return new(value);}
    }
}
