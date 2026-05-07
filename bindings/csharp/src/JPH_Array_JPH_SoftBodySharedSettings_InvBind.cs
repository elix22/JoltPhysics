// machine generated, do not edit
public static partial class JPH
{
    /// Generated from C++ container `JPH::Array<JPH::SoftBodySharedSettings::InvBind>`.
    /// This is the const half of the class.
    public class Const_Array_JPHSoftBodySharedSettingsInvBind : JPH.Object<Const_Array_JPHSoftBodySharedSettingsInvBind>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_Destroy(_Underlying *_this);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Array_JPHSoftBodySharedSettingsInvBind() {Dispose(false);}

        internal unsafe Const_Array_JPHSoftBodySharedSettingsInvBind(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Array_JPHSoftBodySharedSettingsInvBind() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSoftBodySharedSettingsInvBind._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_DefaultConstruct();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_DefaultConstruct();
        }

        /// Constructs a copy of another instance. The source remains alive.
        public unsafe Const_Array_JPHSoftBodySharedSettingsInvBind(JPH._ByValue_Array_JPHSoftBodySharedSettingsInvBind other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSoftBodySharedSettingsInvBind._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Array_JPHSoftBodySharedSettingsInvBind._Underlying *other);
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /// Constructs a copy of another instance. The source remains alive.
        public Const_Array_JPHSoftBodySharedSettingsInvBind(Const_Array_JPHSoftBodySharedSettingsInvBind other) : this(new _ByValue_Array_JPHSoftBodySharedSettingsInvBind(other)) {}

        /// Constructs a copy of another instance. The source remains alive.
        public Const_Array_JPHSoftBodySharedSettingsInvBind(Array_JPHSoftBodySharedSettingsInvBind other) : this((Const_Array_JPHSoftBodySharedSettingsInvBind)other) {}

        /// The number of elements.
        public unsafe UIntPtr Size()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_size(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_size(_UnderlyingPtr);
        }

        /// Returns true if the size is zero.
        public unsafe bool Empty()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_empty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_empty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_empty(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_empty(_UnderlyingPtr) != 0;
        }

        /// The memory capacity, measued in the number of elements.
        public unsafe UIntPtr Capacity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_capacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_capacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_capacity(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_capacity(_UnderlyingPtr);
        }

        /// The element at a specific index, read-only.
        public unsafe JPH.SoftBodySharedSettings.Const_InvBind this[UIntPtr i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_at", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_at", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Const_InvBind._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_at(_Underlying *_this, UIntPtr i);
                JPH.SoftBodySharedSettings.Const_InvBind __ret;
                __ret = new(__Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_at(_UnderlyingPtr, i), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// The first element or null if empty, read-only.
        public unsafe JPH.SoftBodySharedSettings.Const_InvBind? Front()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_front", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_front", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings.Const_InvBind._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_front(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_front(_UnderlyingPtr);
            JPH.SoftBodySharedSettings.Const_InvBind? __ret;
            __ret = __c_ret is not null ? new JPH.SoftBodySharedSettings.Const_InvBind(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// The last element or null if empty, read-only.
        public unsafe JPH.SoftBodySharedSettings.Const_InvBind? Back()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings.Const_InvBind._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_back(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_back(_UnderlyingPtr);
            JPH.SoftBodySharedSettings.Const_InvBind? __ret;
            __ret = __c_ret is not null ? new JPH.SoftBodySharedSettings.Const_InvBind(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }
    }

    /// Generated from C++ container `JPH::Array<JPH::SoftBodySharedSettings::InvBind>`.
    /// This is the non-const half of the class.
    public class Array_JPHSoftBodySharedSettingsInvBind : Const_Array_JPHSoftBodySharedSettingsInvBind
    {
        internal unsafe Array_JPHSoftBodySharedSettingsInvBind(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Array_JPHSoftBodySharedSettingsInvBind() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSoftBodySharedSettingsInvBind._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_DefaultConstruct();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_DefaultConstruct();
        }

        /// Constructs a copy of another instance. The source remains alive.
        public unsafe Array_JPHSoftBodySharedSettingsInvBind(JPH._ByValue_Array_JPHSoftBodySharedSettingsInvBind other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSoftBodySharedSettingsInvBind._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Array_JPHSoftBodySharedSettingsInvBind._Underlying *other);
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /// Constructs a copy of another instance. The source remains alive.
        public Array_JPHSoftBodySharedSettingsInvBind(Const_Array_JPHSoftBodySharedSettingsInvBind other) : this(new _ByValue_Array_JPHSoftBodySharedSettingsInvBind(other)) {}

        /// Constructs a copy of another instance. The source remains alive.
        public Array_JPHSoftBodySharedSettingsInvBind(Array_JPHSoftBodySharedSettingsInvBind other) : this((Const_Array_JPHSoftBodySharedSettingsInvBind)other) {}

        /// Assigns the contents from another instance. Both objects remain alive after the call.
        public unsafe void Assign(JPH._ByValue_Array_JPHSoftBodySharedSettingsInvBind other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_AssignFromAnother(_Underlying *_this, JPH._PassBy other_pass_by, JPH.Array_JPHSoftBodySharedSettingsInvBind._Underlying *other);
            _DiscardKeepAlive();
            if (other.Value is not null) _KeepAlive(other.Value);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_AssignFromAnother(_UnderlyingPtr, other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
        }

        /// Resizes the container. The new elements if any are zeroed.
        public unsafe void Resize(UIntPtr new_size)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_resize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_resize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_resize(_Underlying *_this, UIntPtr new_size);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_resize(_UnderlyingPtr, new_size);
        }

        /// Resizes the container. The new elements if any are set to the specified value.
        public unsafe void ResizeWithDefaultValue(UIntPtr new_size, JPH.SoftBodySharedSettings.Const_InvBind value)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_resize_with_default_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_resize_with_default_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_resize_with_default_value(_Underlying *_this, UIntPtr new_size, JPH.SoftBodySharedSettings.Const_InvBind._Underlying *value);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_resize_with_default_value(_UnderlyingPtr, new_size, value._UnderlyingPtr);
        }

        /// Removes all elements from the container.
        public unsafe void Clear()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_clear(_Underlying *_this);
            _DiscardKeepAlive();
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_clear(_UnderlyingPtr);
        }

        /// Reserves memory for a certain number of elements. Never shrinks the memory.
        public unsafe void Reserve(UIntPtr new_capacity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_reserve(_Underlying *_this, UIntPtr new_capacity);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_reserve(_UnderlyingPtr, new_capacity);
        }

        /// Shrinks the capacity to match the size.
        public unsafe void ShrinkToFit()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_shrink_to_fit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_shrink_to_fit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_shrink_to_fit(_Underlying *_this);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_shrink_to_fit(_UnderlyingPtr);
        }

        /// The element at a specific index, mutable.
        public unsafe new JPH.SoftBodySharedSettings.InvBind this[UIntPtr i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_at_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_at_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.InvBind._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_at_mut(_Underlying *_this, UIntPtr i);
                JPH.SoftBodySharedSettings.InvBind __ret;
                __ret = new(__Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_at_mut(_UnderlyingPtr, i), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// The first element or null if empty, mutable.
        public unsafe new JPH.SoftBodySharedSettings.InvBind? Front()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_front_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_front_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings.InvBind._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_front_mut(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_front_mut(_UnderlyingPtr);
            JPH.SoftBodySharedSettings.InvBind? __ret;
            __ret = __c_ret is not null ? new JPH.SoftBodySharedSettings.InvBind(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// The last element or null if empty, mutable.
        public unsafe new JPH.SoftBodySharedSettings.InvBind? Back()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_back_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_back_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings.InvBind._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_back_mut(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_back_mut(_UnderlyingPtr);
            JPH.SoftBodySharedSettings.InvBind? __ret;
            __ret = __c_ret is not null ? new JPH.SoftBodySharedSettings.InvBind(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// Inserts a new element at the end.
        public unsafe void PushBack(JPH.SoftBodySharedSettings.Const_InvBind new_elem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_push_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_push_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_push_back(_Underlying *_this, JPH.SoftBodySharedSettings.InvBind._Underlying *new_elem);
            _KeepAlive(new_elem);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_push_back(_UnderlyingPtr, new_elem._UnderlyingPtr);
        }

        /// Removes one element from the end.
        public unsafe void PopBack()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_pop_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_pop_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_pop_back(_Underlying *_this);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_pop_back(_UnderlyingPtr);
        }

        /// Inserts a new element right before the specified position.
        public unsafe void Insert(UIntPtr position, JPH.SoftBodySharedSettings.Const_InvBind new_elem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_insert(_Underlying *_this, UIntPtr position, JPH.SoftBodySharedSettings.InvBind._Underlying *new_elem);
            _KeepAlive(new_elem);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_insert(_UnderlyingPtr, position, new_elem._UnderlyingPtr);
        }

        /// Erases the element at the specified position.
        public unsafe void Erase(UIntPtr position)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_erase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_erase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_erase(_Underlying *_this, UIntPtr position);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_InvBind_erase(_UnderlyingPtr, position);
        }
    }

    /// This is used as a function parameter when the underlying function receives `Array_JPHSoftBodySharedSettingsInvBind` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `Array_JPHSoftBodySharedSettingsInvBind`/`Const_Array_JPHSoftBodySharedSettingsInvBind` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_Array_JPHSoftBodySharedSettingsInvBind
    {
        #pragma warning disable CS0649
        internal readonly Const_Array_JPHSoftBodySharedSettingsInvBind? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_Array_JPHSoftBodySharedSettingsInvBind() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_Array_JPHSoftBodySharedSettingsInvBind(Const_Array_JPHSoftBodySharedSettingsInvBind new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_Array_JPHSoftBodySharedSettingsInvBind(Const_Array_JPHSoftBodySharedSettingsInvBind arg) {return new(arg);}
        public _ByValue_Array_JPHSoftBodySharedSettingsInvBind(JPH._Moved<Array_JPHSoftBodySharedSettingsInvBind> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_Array_JPHSoftBodySharedSettingsInvBind(JPH._Moved<Array_JPHSoftBodySharedSettingsInvBind> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `Array_JPHSoftBodySharedSettingsInvBind` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Array_JPHSoftBodySharedSettingsInvBind`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Array_JPHSoftBodySharedSettingsInvBind`/`Const_Array_JPHSoftBodySharedSettingsInvBind` directly.
    public class _InOptMut_Array_JPHSoftBodySharedSettingsInvBind
    {
        public Array_JPHSoftBodySharedSettingsInvBind? Opt;

        public _InOptMut_Array_JPHSoftBodySharedSettingsInvBind() {}
        public _InOptMut_Array_JPHSoftBodySharedSettingsInvBind(Array_JPHSoftBodySharedSettingsInvBind value) {Opt = value;}
        public static implicit operator _InOptMut_Array_JPHSoftBodySharedSettingsInvBind(Array_JPHSoftBodySharedSettingsInvBind value) {return new(value);}
    }

    /// This is used for optional parameters of class `Array_JPHSoftBodySharedSettingsInvBind` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Array_JPHSoftBodySharedSettingsInvBind`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Array_JPHSoftBodySharedSettingsInvBind`/`Const_Array_JPHSoftBodySharedSettingsInvBind` to pass it to the function.
    public class _InOptConst_Array_JPHSoftBodySharedSettingsInvBind
    {
        public Const_Array_JPHSoftBodySharedSettingsInvBind? Opt;

        public _InOptConst_Array_JPHSoftBodySharedSettingsInvBind() {}
        public _InOptConst_Array_JPHSoftBodySharedSettingsInvBind(Const_Array_JPHSoftBodySharedSettingsInvBind value) {Opt = value;}
        public static implicit operator _InOptConst_Array_JPHSoftBodySharedSettingsInvBind(Const_Array_JPHSoftBodySharedSettingsInvBind value) {return new(value);}
    }
}
