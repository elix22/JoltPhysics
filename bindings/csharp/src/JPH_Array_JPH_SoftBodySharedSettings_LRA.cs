// machine generated, do not edit
public static partial class JPH
{
    /// Generated from C++ container `JPH::Array<JPH::SoftBodySharedSettings::LRA>`.
    /// This is the const half of the class.
    public class Const_Array_JPHSoftBodySharedSettingsLRA : JPH.Object<Const_Array_JPHSoftBodySharedSettingsLRA>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_Destroy(_Underlying *_this);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_Array_JPHSoftBodySharedSettingsLRA() {Dispose(false);}

        internal unsafe Const_Array_JPHSoftBodySharedSettingsLRA(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_Array_JPHSoftBodySharedSettingsLRA() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSoftBodySharedSettingsLRA._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_DefaultConstruct();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_DefaultConstruct();
        }

        /// Constructs a copy of another instance. The source remains alive.
        public unsafe Const_Array_JPHSoftBodySharedSettingsLRA(JPH._ByValue_Array_JPHSoftBodySharedSettingsLRA other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSoftBodySharedSettingsLRA._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Array_JPHSoftBodySharedSettingsLRA._Underlying *other);
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /// Constructs a copy of another instance. The source remains alive.
        public Const_Array_JPHSoftBodySharedSettingsLRA(Const_Array_JPHSoftBodySharedSettingsLRA other) : this(new _ByValue_Array_JPHSoftBodySharedSettingsLRA(other)) {}

        /// Constructs a copy of another instance. The source remains alive.
        public Const_Array_JPHSoftBodySharedSettingsLRA(Array_JPHSoftBodySharedSettingsLRA other) : this((Const_Array_JPHSoftBodySharedSettingsLRA)other) {}

        /// The number of elements.
        public unsafe UIntPtr Size()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_size", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_size(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_size(_UnderlyingPtr);
        }

        /// Returns true if the size is zero.
        public unsafe bool Empty()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_empty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_empty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_empty(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_empty(_UnderlyingPtr) != 0;
        }

        /// The memory capacity, measued in the number of elements.
        public unsafe UIntPtr Capacity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_capacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_capacity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static UIntPtr __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_capacity(_Underlying *_this);
            return __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_capacity(_UnderlyingPtr);
        }

        /// The element at a specific index, read-only.
        public unsafe JPH.SoftBodySharedSettings.Const_LRA this[UIntPtr i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_at", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_at", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.Const_LRA._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_at(_Underlying *_this, UIntPtr i);
                JPH.SoftBodySharedSettings.Const_LRA __ret;
                __ret = new(__Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_at(_UnderlyingPtr, i), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// The first element or null if empty, read-only.
        public unsafe JPH.SoftBodySharedSettings.Const_LRA? Front()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_front", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_front", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings.Const_LRA._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_front(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_front(_UnderlyingPtr);
            JPH.SoftBodySharedSettings.Const_LRA? __ret;
            __ret = __c_ret is not null ? new JPH.SoftBodySharedSettings.Const_LRA(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// The last element or null if empty, read-only.
        public unsafe JPH.SoftBodySharedSettings.Const_LRA? Back()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings.Const_LRA._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_back(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_back(_UnderlyingPtr);
            JPH.SoftBodySharedSettings.Const_LRA? __ret;
            __ret = __c_ret is not null ? new JPH.SoftBodySharedSettings.Const_LRA(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }
    }

    /// Generated from C++ container `JPH::Array<JPH::SoftBodySharedSettings::LRA>`.
    /// This is the non-const half of the class.
    public class Array_JPHSoftBodySharedSettingsLRA : Const_Array_JPHSoftBodySharedSettingsLRA
    {
        internal unsafe Array_JPHSoftBodySharedSettingsLRA(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Array_JPHSoftBodySharedSettingsLRA() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSoftBodySharedSettingsLRA._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_DefaultConstruct();
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_DefaultConstruct();
        }

        /// Constructs a copy of another instance. The source remains alive.
        public unsafe Array_JPHSoftBodySharedSettingsLRA(JPH._ByValue_Array_JPHSoftBodySharedSettingsLRA other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.Array_JPHSoftBodySharedSettingsLRA._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Array_JPHSoftBodySharedSettingsLRA._Underlying *other);
            _UnderlyingPtr = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /// Constructs a copy of another instance. The source remains alive.
        public Array_JPHSoftBodySharedSettingsLRA(Const_Array_JPHSoftBodySharedSettingsLRA other) : this(new _ByValue_Array_JPHSoftBodySharedSettingsLRA(other)) {}

        /// Constructs a copy of another instance. The source remains alive.
        public Array_JPHSoftBodySharedSettingsLRA(Array_JPHSoftBodySharedSettingsLRA other) : this((Const_Array_JPHSoftBodySharedSettingsLRA)other) {}

        /// Assigns the contents from another instance. Both objects remain alive after the call.
        public unsafe void Assign(JPH._ByValue_Array_JPHSoftBodySharedSettingsLRA other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_AssignFromAnother(_Underlying *_this, JPH._PassBy other_pass_by, JPH.Array_JPHSoftBodySharedSettingsLRA._Underlying *other);
            _DiscardKeepAlive();
            if (other.Value is not null) _KeepAlive(other.Value);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_AssignFromAnother(_UnderlyingPtr, other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
        }

        /// Resizes the container. The new elements if any are zeroed.
        public unsafe void Resize(UIntPtr new_size)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_resize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_resize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_resize(_Underlying *_this, UIntPtr new_size);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_resize(_UnderlyingPtr, new_size);
        }

        /// Resizes the container. The new elements if any are set to the specified value.
        public unsafe void ResizeWithDefaultValue(UIntPtr new_size, JPH.SoftBodySharedSettings.Const_LRA value)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_resize_with_default_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_resize_with_default_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_resize_with_default_value(_Underlying *_this, UIntPtr new_size, JPH.SoftBodySharedSettings.Const_LRA._Underlying *value);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_resize_with_default_value(_UnderlyingPtr, new_size, value._UnderlyingPtr);
        }

        /// Removes all elements from the container.
        public unsafe void Clear()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_clear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_clear(_Underlying *_this);
            _DiscardKeepAlive();
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_clear(_UnderlyingPtr);
        }

        /// Reserves memory for a certain number of elements. Never shrinks the memory.
        public unsafe void Reserve(UIntPtr new_capacity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_reserve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_reserve(_Underlying *_this, UIntPtr new_capacity);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_reserve(_UnderlyingPtr, new_capacity);
        }

        /// Shrinks the capacity to match the size.
        public unsafe void ShrinkToFit()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_shrink_to_fit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_shrink_to_fit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_shrink_to_fit(_Underlying *_this);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_shrink_to_fit(_UnderlyingPtr);
        }

        /// The element at a specific index, mutable.
        public unsafe new JPH.SoftBodySharedSettings.LRA this[UIntPtr i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_at_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_at_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.SoftBodySharedSettings.LRA._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_at_mut(_Underlying *_this, UIntPtr i);
                JPH.SoftBodySharedSettings.LRA __ret;
                __ret = new(__Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_at_mut(_UnderlyingPtr, i), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        /// The first element or null if empty, mutable.
        public unsafe new JPH.SoftBodySharedSettings.LRA? Front()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_front_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_front_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings.LRA._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_front_mut(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_front_mut(_UnderlyingPtr);
            JPH.SoftBodySharedSettings.LRA? __ret;
            __ret = __c_ret is not null ? new JPH.SoftBodySharedSettings.LRA(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// The last element or null if empty, mutable.
        public unsafe new JPH.SoftBodySharedSettings.LRA? Back()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_back_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_back_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static JPH.SoftBodySharedSettings.LRA._Underlying *__Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_back_mut(_Underlying *_this);
            var __c_ret = __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_back_mut(_UnderlyingPtr);
            JPH.SoftBodySharedSettings.LRA? __ret;
            __ret = __c_ret is not null ? new JPH.SoftBodySharedSettings.LRA(__c_ret, is_owning: false) : null;
            if (__ret is not null) __ret._KeepAliveEnclosingObject = this;
            return __ret;
        }

        /// Inserts a new element at the end.
        public unsafe void PushBack(JPH.SoftBodySharedSettings.Const_LRA new_elem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_push_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_push_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_push_back(_Underlying *_this, JPH.SoftBodySharedSettings.LRA._Underlying *new_elem);
            _KeepAlive(new_elem);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_push_back(_UnderlyingPtr, new_elem._UnderlyingPtr);
        }

        /// Removes one element from the end.
        public unsafe void PopBack()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_pop_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_pop_back", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_pop_back(_Underlying *_this);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_pop_back(_UnderlyingPtr);
        }

        /// Inserts a new element right before the specified position.
        public unsafe void Insert(UIntPtr position, JPH.SoftBodySharedSettings.Const_LRA new_elem)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_insert", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_insert(_Underlying *_this, UIntPtr position, JPH.SoftBodySharedSettings.LRA._Underlying *new_elem);
            _KeepAlive(new_elem);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_insert(_UnderlyingPtr, position, new_elem._UnderlyingPtr);
        }

        /// Erases the element at the specified position.
        public unsafe void Erase(UIntPtr position)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_erase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_erase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_erase(_Underlying *_this, UIntPtr position);
            __Jolt_JPH_Array_JPH_SoftBodySharedSettings_LRA_erase(_UnderlyingPtr, position);
        }
    }

    /// This is used as a function parameter when the underlying function receives `Array_JPHSoftBodySharedSettingsLRA` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `Array_JPHSoftBodySharedSettingsLRA`/`Const_Array_JPHSoftBodySharedSettingsLRA` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_Array_JPHSoftBodySharedSettingsLRA
    {
        #pragma warning disable CS0649
        internal readonly Const_Array_JPHSoftBodySharedSettingsLRA? Value;
        #pragma warning restore CS0649
        internal readonly JPH._PassBy PassByMode;
        public _ByValue_Array_JPHSoftBodySharedSettingsLRA() {PassByMode = JPH._PassBy.default_construct;}
        public _ByValue_Array_JPHSoftBodySharedSettingsLRA(Const_Array_JPHSoftBodySharedSettingsLRA new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
        public static implicit operator _ByValue_Array_JPHSoftBodySharedSettingsLRA(Const_Array_JPHSoftBodySharedSettingsLRA arg) {return new(arg);}
        public _ByValue_Array_JPHSoftBodySharedSettingsLRA(JPH._Moved<Array_JPHSoftBodySharedSettingsLRA> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
        public static implicit operator _ByValue_Array_JPHSoftBodySharedSettingsLRA(JPH._Moved<Array_JPHSoftBodySharedSettingsLRA> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `Array_JPHSoftBodySharedSettingsLRA` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_Array_JPHSoftBodySharedSettingsLRA`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Array_JPHSoftBodySharedSettingsLRA`/`Const_Array_JPHSoftBodySharedSettingsLRA` directly.
    public class _InOptMut_Array_JPHSoftBodySharedSettingsLRA
    {
        public Array_JPHSoftBodySharedSettingsLRA? Opt;

        public _InOptMut_Array_JPHSoftBodySharedSettingsLRA() {}
        public _InOptMut_Array_JPHSoftBodySharedSettingsLRA(Array_JPHSoftBodySharedSettingsLRA value) {Opt = value;}
        public static implicit operator _InOptMut_Array_JPHSoftBodySharedSettingsLRA(Array_JPHSoftBodySharedSettingsLRA value) {return new(value);}
    }

    /// This is used for optional parameters of class `Array_JPHSoftBodySharedSettingsLRA` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_Array_JPHSoftBodySharedSettingsLRA`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `Array_JPHSoftBodySharedSettingsLRA`/`Const_Array_JPHSoftBodySharedSettingsLRA` to pass it to the function.
    public class _InOptConst_Array_JPHSoftBodySharedSettingsLRA
    {
        public Const_Array_JPHSoftBodySharedSettingsLRA? Opt;

        public _InOptConst_Array_JPHSoftBodySharedSettingsLRA() {}
        public _InOptConst_Array_JPHSoftBodySharedSettingsLRA(Const_Array_JPHSoftBodySharedSettingsLRA value) {Opt = value;}
        public static implicit operator _InOptConst_Array_JPHSoftBodySharedSettingsLRA(Const_Array_JPHSoftBodySharedSettingsLRA value) {return new(value);}
    }
}
