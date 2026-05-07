// machine generated, do not edit
public static partial class JPH
{
    /// Generated from C++ container `JPH::Array<JPH::VehicleDifferentialSettings>`.
    /// This is the const half of the class.
    public class Const_Array_JPHVehicleDifferentialSettings : JPH.Object<Const_Array_JPHVehicleDifferentialSettings>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_Destroy(_Underlying *_this);
            __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Array_JPHVehicleDifferentialSettings() {Dispose(false);}

        internal unsafe Const_Array_JPHVehicleDifferentialSettings(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Array_JPHVehicleDifferentialSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHVehicleDifferentialSettings._Underlying *__Jolt_JPH_Array_JPH_VehicleDifferentialSettings_DefaultConstruct();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_DefaultConstruct();
        }

        /// Constructs a copy of another instance. The source remains alive.
        public unsafe Const_Array_JPHVehicleDifferentialSettings(JPH._ByValue_Array_JPHVehicleDifferentialSettings other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHVehicleDifferentialSettings._Underlying *__Jolt_JPH_Array_JPH_VehicleDifferentialSettings_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Array_JPHVehicleDifferentialSettings._Underlying *other);
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /// Constructs a copy of another instance. The source remains alive.
        public Const_Array_JPHVehicleDifferentialSettings(Const_Array_JPHVehicleDifferentialSettings other) : this(new _ByValue_Array_JPHVehicleDifferentialSettings(other)) {}

        /// Constructs a copy of another instance. The source remains alive.
        public Const_Array_JPHVehicleDifferentialSettings(Array_JPHVehicleDifferentialSettings other) : this((Const_Array_JPHVehicleDifferentialSettings)other) {}

        /// The number of elements.
        public unsafe UIntPtr Size()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_size(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_size(_UnderlyingPtr);
        }

        /// Returns true if the size is zero.
        public unsafe bool Empty()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_empty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_empty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_empty(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_empty(_UnderlyingPtr) != 0;
        }

        /// The memory capacity, measued in the number of elements.
        public unsafe UIntPtr Capacity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_capacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_capacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_capacity(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_capacity(_UnderlyingPtr);
        }

        /// The element at a specific index, read-only.
        public unsafe JPH.Const_VehicleDifferentialSettings this[UIntPtr i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_at", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_at", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Const_VehicleDifferentialSettings._Underlying *__Jolt_JPH_Array_JPH_VehicleDifferentialSettings_at(_Underlying *_this, UIntPtr i);
                JPH.Const_VehicleDifferentialSettings __ret;
                __ret = new(__Jolt_JPH_Array_JPH_VehicleDifferentialSettings_at(_UnderlyingPtr, i), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// The first element or null if empty, read-only.
        public unsafe JPH.Const_VehicleDifferentialSettings? Front()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_front", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_front", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleDifferentialSettings._Underlying *__Jolt_JPH_Array_JPH_VehicleDifferentialSettings_front(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_front(_UnderlyingPtr);
            JPH.Const_VehicleDifferentialSettings? __ret;
            __ret = __c_ret is not null ? new JPH.Const_VehicleDifferentialSettings(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// The last element or null if empty, read-only.
        public unsafe JPH.Const_VehicleDifferentialSettings? Back()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Const_VehicleDifferentialSettings._Underlying *__Jolt_JPH_Array_JPH_VehicleDifferentialSettings_back(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_back(_UnderlyingPtr);
            JPH.Const_VehicleDifferentialSettings? __ret;
            __ret = __c_ret is not null ? new JPH.Const_VehicleDifferentialSettings(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }
    }

    /// Generated from C++ container `JPH::Array<JPH::VehicleDifferentialSettings>`.
    /// This is the non-const half of the class.
    public class Array_JPHVehicleDifferentialSettings : Const_Array_JPHVehicleDifferentialSettings
    {
        internal unsafe Array_JPHVehicleDifferentialSettings(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Array_JPHVehicleDifferentialSettings() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHVehicleDifferentialSettings._Underlying *__Jolt_JPH_Array_JPH_VehicleDifferentialSettings_DefaultConstruct();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_DefaultConstruct();
        }

        /// Constructs a copy of another instance. The source remains alive.
        public unsafe Array_JPHVehicleDifferentialSettings(JPH._ByValue_Array_JPHVehicleDifferentialSettings other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHVehicleDifferentialSettings._Underlying *__Jolt_JPH_Array_JPH_VehicleDifferentialSettings_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Array_JPHVehicleDifferentialSettings._Underlying *other);
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /// Constructs a copy of another instance. The source remains alive.
        public Array_JPHVehicleDifferentialSettings(Const_Array_JPHVehicleDifferentialSettings other) : this(new _ByValue_Array_JPHVehicleDifferentialSettings(other)) {}

        /// Constructs a copy of another instance. The source remains alive.
        public Array_JPHVehicleDifferentialSettings(Array_JPHVehicleDifferentialSettings other) : this((Const_Array_JPHVehicleDifferentialSettings)other) {}

        /// Assigns the contents from another instance. Both objects remain alive after the call.
        public unsafe void Assign(JPH._ByValue_Array_JPHVehicleDifferentialSettings other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_AssignFromAnother(_Underlying *_this, JPH._PassBy other_pass_by, JPH.Array_JPHVehicleDifferentialSettings._Underlying *other);
            _DiscardKeepAlive();
            if (other.Value is not null) _KeepAlive(other.Value);
            __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_AssignFromAnother(_UnderlyingPtr, other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
        }

        /// Resizes the container. The new elements if any are zeroed.
        public unsafe void Resize(UIntPtr new_size)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_resize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_resize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_resize(_Underlying *_this, UIntPtr new_size);
            __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_resize(_UnderlyingPtr, new_size);
        }

        /// Resizes the container. The new elements if any are set to the specified value.
        public unsafe void ResizeWithDefaultValue(UIntPtr new_size, JPH.Const_VehicleDifferentialSettings value)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_resize_with_default_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_resize_with_default_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_resize_with_default_value(_Underlying *_this, UIntPtr new_size, JPH.Const_VehicleDifferentialSettings._Underlying *value);
            __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_resize_with_default_value(_UnderlyingPtr, new_size, value._UnderlyingPtr);
        }

        /// Removes all elements from the container.
        public unsafe void Clear()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_clear(_Underlying *_this);
            _DiscardKeepAlive();
            __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_clear(_UnderlyingPtr);
        }

        /// Reserves memory for a certain number of elements. Never shrinks the memory.
        public unsafe void Reserve(UIntPtr new_capacity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_reserve(_Underlying *_this, UIntPtr new_capacity);
            __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_reserve(_UnderlyingPtr, new_capacity);
        }

        /// Shrinks the capacity to match the size.
        public unsafe void ShrinkToFit()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_shrink_to_fit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_shrink_to_fit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_shrink_to_fit(_Underlying *_this);
            __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_shrink_to_fit(_UnderlyingPtr);
        }

        /// The element at a specific index, mutable.
        public unsafe new JPH.VehicleDifferentialSettings this[UIntPtr i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_at_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_at_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.VehicleDifferentialSettings._Underlying *__Jolt_JPH_Array_JPH_VehicleDifferentialSettings_at_mut(_Underlying *_this, UIntPtr i);
                JPH.VehicleDifferentialSettings __ret;
                __ret = new(__Jolt_JPH_Array_JPH_VehicleDifferentialSettings_at_mut(_UnderlyingPtr, i), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// The first element or null if empty, mutable.
        public unsafe new JPH.VehicleDifferentialSettings? Front()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_front_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_front_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleDifferentialSettings._Underlying *__Jolt_JPH_Array_JPH_VehicleDifferentialSettings_front_mut(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_front_mut(_UnderlyingPtr);
            JPH.VehicleDifferentialSettings? __ret;
            __ret = __c_ret is not null ? new JPH.VehicleDifferentialSettings(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// The last element or null if empty, mutable.
        public unsafe new JPH.VehicleDifferentialSettings? Back()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_back_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_back_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.VehicleDifferentialSettings._Underlying *__Jolt_JPH_Array_JPH_VehicleDifferentialSettings_back_mut(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_back_mut(_UnderlyingPtr);
            JPH.VehicleDifferentialSettings? __ret;
            __ret = __c_ret is not null ? new JPH.VehicleDifferentialSettings(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// Inserts a new element at the end.
        public unsafe void PushBack(JPH.Const_VehicleDifferentialSettings new_elem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_push_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_push_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_push_back(_Underlying *_this, JPH.VehicleDifferentialSettings._Underlying *new_elem);
            _KeepAlive(new_elem);
            __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_push_back(_UnderlyingPtr, new_elem._UnderlyingPtr);
        }

        /// Removes one element from the end.
        public unsafe void PopBack()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_pop_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_pop_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_pop_back(_Underlying *_this);
            __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_pop_back(_UnderlyingPtr);
        }

        /// Inserts a new element right before the specified position.
        public unsafe void Insert(UIntPtr position, JPH.Const_VehicleDifferentialSettings new_elem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_insert(_Underlying *_this, UIntPtr position, JPH.VehicleDifferentialSettings._Underlying *new_elem);
            _KeepAlive(new_elem);
            __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_insert(_UnderlyingPtr, position, new_elem._UnderlyingPtr);
        }

        /// Erases the element at the specified position.
        public unsafe void Erase(UIntPtr position)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_erase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_VehicleDifferentialSettings_erase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_erase(_Underlying *_this, UIntPtr position);
            __Jolt_JPH_Array_JPH_VehicleDifferentialSettings_erase(_UnderlyingPtr, position);
        }
    }

    /// This is used as a function parameter when the underlying function receives `Array_JPHVehicleDifferentialSettings` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `Array_JPHVehicleDifferentialSettings`/`Const_Array_JPHVehicleDifferentialSettings` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_Array_JPHVehicleDifferentialSettings
    {
        #pragma warning disable CS0649
        internal readonly Const_Array_JPHVehicleDifferentialSettings? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_Array_JPHVehicleDifferentialSettings() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_Array_JPHVehicleDifferentialSettings(Const_Array_JPHVehicleDifferentialSettings new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_Array_JPHVehicleDifferentialSettings(Const_Array_JPHVehicleDifferentialSettings arg) {return new(arg);}
        public _ByValue_Array_JPHVehicleDifferentialSettings(JPH._Moved<Array_JPHVehicleDifferentialSettings> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_Array_JPHVehicleDifferentialSettings(JPH._Moved<Array_JPHVehicleDifferentialSettings> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `Array_JPHVehicleDifferentialSettings` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Array_JPHVehicleDifferentialSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Array_JPHVehicleDifferentialSettings`/`Const_Array_JPHVehicleDifferentialSettings` directly.
    public class _InOptMut_Array_JPHVehicleDifferentialSettings
    {
        public Array_JPHVehicleDifferentialSettings? Opt;

        public _InOptMut_Array_JPHVehicleDifferentialSettings() {}
        public _InOptMut_Array_JPHVehicleDifferentialSettings(Array_JPHVehicleDifferentialSettings value) {Opt = value;}
        public static implicit operator _InOptMut_Array_JPHVehicleDifferentialSettings(Array_JPHVehicleDifferentialSettings value) {return new(value);}
    }

    /// This is used for optional parameters of class `Array_JPHVehicleDifferentialSettings` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Array_JPHVehicleDifferentialSettings`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Array_JPHVehicleDifferentialSettings`/`Const_Array_JPHVehicleDifferentialSettings` to pass it to the function.
    public class _InOptConst_Array_JPHVehicleDifferentialSettings
    {
        public Const_Array_JPHVehicleDifferentialSettings? Opt;

        public _InOptConst_Array_JPHVehicleDifferentialSettings() {}
        public _InOptConst_Array_JPHVehicleDifferentialSettings(Const_Array_JPHVehicleDifferentialSettings value) {Opt = value;}
        public static implicit operator _InOptConst_Array_JPHVehicleDifferentialSettings(Const_Array_JPHVehicleDifferentialSettings value) {return new(value);}
    }
}
