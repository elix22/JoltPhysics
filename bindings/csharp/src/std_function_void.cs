// machine generated, do not edit
public static partial class JPH
{
    public static partial class Std
    {
        /// Stores a functor of type: `void(void)`. Possibly stateful.
        /// This is the const half of the class.
        public class Const_Function_Void : JPH.Object<Const_Function_Void>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_Destroy(_Underlying *_this);
                __Jolt_std_function_void_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Function_Void() {Dispose(false);}

            internal unsafe Const_Function_Void(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Function_Void() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_Void._Underlying *__Jolt_std_function_void_DefaultConstruct();
                _UnderlyingPtr = __Jolt_std_function_void_DefaultConstruct();
            }

            /// Constructs a copy of another instance. The source remains alive.
            public unsafe Const_Function_Void(JPH.Std._ByValue_Function_Void other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_Void._Underlying *__Jolt_std_function_void_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Std.Function_Void._Underlying *other);
                _UnderlyingPtr = __Jolt_std_function_void_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
                if (other.Value is not null) _KeepAlive(other.Value);
            }

            /// Constructs a copy of another instance. The source remains alive.
            public Const_Function_Void(Const_Function_Void other) : this(new _ByValue_Function_Void(other)) {}

            /// Constructs a copy of another instance. The source remains alive.
            public Const_Function_Void(Function_Void other) : this((Const_Function_Void)other) {}

            /// Returns true if this instance stores a callable, as opposed to being null.
            public static unsafe implicit operator bool(JPH.Std.Const_Function_Void _this)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_has_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_has_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_std_function_void_has_value(JPH.Std.Const_Function_Void._Underlying *_this);
                return __Jolt_std_function_void_has_value(_this._UnderlyingPtr) != 0;
            }

            /// Calls the stored callable.
            public unsafe void Call()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_call(_Underlying *_this);
                __Jolt_std_function_void_call(_UnderlyingPtr);
            }

            // Custom extras:

            public delegate void Delegate();

            private protected unsafe delegate void _CDelegate(void *_userdata, void **_cleanup_value);

            private protected unsafe void _CCallWrapper(void *_userdata, void **_cleanup_value)
            {
                ((Delegate)System.Runtime.InteropServices.GCHandle.FromIntPtr((nint)_userdata).Target!)();
            }

            /// Construct from a delegate.
            public unsafe Const_Function_Void(Delegate func) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_ConstructEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_ConstructEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Const_Function_Void._Underlying *__Jolt_std_function_void_ConstructEx(_CDelegate func, void *userdata, JPH.StdFunctionPostCallCallbackDelegate postcall_callback, JPH.StdFunctionUserdataCallbackDelegate userdata_callback);
                _UnderlyingPtr = __Jolt_std_function_void_ConstructEx(_CCallWrapper, (void *)System.Runtime.InteropServices.GCHandle.ToIntPtr(System.Runtime.InteropServices.GCHandle.Alloc(func)), JPH.StdFunctionPostCallCallback, JPH.StdFunctionUserdataCallback);
            }

            public static unsafe implicit operator Const_Function_Void(JPH.Std.Function_Void.Delegate func) {return new(func);}
        }

        /// Stores a functor of type: `void(void)`. Possibly stateful.
        /// This is the non-const half of the class.
        public class Function_Void : Const_Function_Void
        {
            internal unsafe Function_Void(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Function_Void() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_Void._Underlying *__Jolt_std_function_void_DefaultConstruct();
                _UnderlyingPtr = __Jolt_std_function_void_DefaultConstruct();
            }

            /// Constructs a copy of another instance. The source remains alive.
            public unsafe Function_Void(JPH.Std._ByValue_Function_Void other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_Void._Underlying *__Jolt_std_function_void_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Std.Function_Void._Underlying *other);
                _UnderlyingPtr = __Jolt_std_function_void_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
                if (other.Value is not null) _KeepAlive(other.Value);
            }

            /// Constructs a copy of another instance. The source remains alive.
            public Function_Void(Const_Function_Void other) : this(new _ByValue_Function_Void(other)) {}

            /// Constructs a copy of another instance. The source remains alive.
            public Function_Void(Function_Void other) : this((Const_Function_Void)other) {}

            /// Assigns the contents from another instance. Both objects remain alive after the call.
            public unsafe void Assign(JPH.Std._ByValue_Function_Void other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_AssignFromAnother(_Underlying *_this, JPH._PassBy other_pass_by, JPH.Std.Function_Void._Underlying *other);
                _DiscardKeepAlive();
                if (other.Value is not null) _KeepAlive(other.Value);
                __Jolt_std_function_void_AssignFromAnother(_UnderlyingPtr, other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            }

            /// Destroys the stored callable, making this instance null.
            public unsafe void Reset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_reset(_Underlying *_this);
                __Jolt_std_function_void_reset(_UnderlyingPtr);
            }

            // Custom extras:

            /// Construct from a delegate.
            public unsafe Function_Void(Delegate func) : base(func) {}

            /// Assign from a delegate.
            public unsafe void Assign(Delegate func)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_AssignEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_AssignEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_AssignEx(Function_Void._Underlying *_this, _CDelegate func, void *userdata, JPH.StdFunctionPostCallCallbackDelegate postcall_callback, JPH.StdFunctionUserdataCallbackDelegate userdata_callback);
                __Jolt_std_function_void_AssignEx(_UnderlyingPtr, _CCallWrapper, (void *)System.Runtime.InteropServices.GCHandle.ToIntPtr(System.Runtime.InteropServices.GCHandle.Alloc(func)), JPH.StdFunctionPostCallCallback, JPH.StdFunctionUserdataCallback);
            }
        }

        /// This is used as a function parameter when the underlying function receives `Function_Void` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `Function_Void`/`Const_Function_Void` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_Function_Void
        {
            #pragma warning disable CS0649
            internal readonly Const_Function_Void? Value;
            #pragma warning restore CS0649
            internal readonly JPH._PassBy PassByMode;
            public _ByValue_Function_Void() {PassByMode = JPH._PassBy.default_construct;}
            public _ByValue_Function_Void(Const_Function_Void new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
            public static implicit operator _ByValue_Function_Void(Const_Function_Void arg) {return new(arg);}
            public _ByValue_Function_Void(JPH._Moved<Function_Void> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
            public static implicit operator _ByValue_Function_Void(JPH._Moved<Function_Void> arg) {return new(arg);}

            public static unsafe implicit operator _ByValue_Function_Void(JPH.Std.Function_Void.Delegate func) {return new Function_Void(func);}}

        /// This is used for optional parameters of class `Function_Void` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Function_Void`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Function_Void`/`Const_Function_Void` directly.
        public class _InOptMut_Function_Void
        {
            public Function_Void? Opt;

            public _InOptMut_Function_Void() {}
            public _InOptMut_Function_Void(Function_Void value) {Opt = value;}
            public static implicit operator _InOptMut_Function_Void(Function_Void value) {return new(value);}
        }

        /// This is used for optional parameters of class `Function_Void` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Function_Void`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Function_Void`/`Const_Function_Void` to pass it to the function.
        public class _InOptConst_Function_Void
        {
            public Const_Function_Void? Opt;

            public _InOptConst_Function_Void() {}
            public _InOptConst_Function_Void(Const_Function_Void value) {Opt = value;}
            public static implicit operator _InOptConst_Function_Void(Const_Function_Void value) {return new(value);}

            public static unsafe implicit operator _InOptConst_Function_Void(JPH.Std.Function_Void.Delegate func) {return new Function_Void(func);}}
    }
}
