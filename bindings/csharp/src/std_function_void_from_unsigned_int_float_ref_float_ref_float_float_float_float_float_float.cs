// machine generated, do not edit
public static partial class JPH
{
    public static partial class Std
    {
        /// Stores a functor of type: `void(unsigned int, float &, float &, float, float, float, float, float, float)`. Possibly stateful.
        /// This is the const half of the class.
        public class Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float : JPH.Object<Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_Destroy(_Underlying *_this);
                __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float() {Dispose(false);}

            internal unsafe Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float._Underlying *__Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_DefaultConstruct();
                _UnderlyingPtr = __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_DefaultConstruct();
            }

            /// Constructs a copy of another instance. The source remains alive.
            public unsafe Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(JPH.Std._ByValue_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float._Underlying *__Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Std.Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float._Underlying *other);
                _UnderlyingPtr = __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
                if (other.Value is not null) _KeepAlive(other.Value);
            }

            /// Constructs a copy of another instance. The source remains alive.
            public Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float other) : this(new _ByValue_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(other)) {}

            /// Constructs a copy of another instance. The source remains alive.
            public Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float other) : this((Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float)other) {}

            /// Returns true if this instance stores a callable, as opposed to being null.
            public static unsafe implicit operator bool(JPH.Std.Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float _this)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_has_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_has_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_has_value(JPH.Std.Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float._Underlying *_this);
                return __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_has_value(_this._UnderlyingPtr) != 0;
            }

            /// Calls the stored callable.
            public unsafe void Call(uint _1, ref float _2, ref float _3, float _4, float _5, float _6, float _7, float _8, float _9)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_call(_Underlying *_this, uint _1, float *_2, float *_3, float _4, float _5, float _6, float _7, float _8, float _9);
                fixed (float *__ptr__2 = &_2)
                {
                    fixed (float *__ptr__3 = &_3)
                    {
                        __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_call(_UnderlyingPtr, _1, __ptr__2, __ptr__3, _4, _5, _6, _7, _8, _9);
                    }
                }
            }

            // Custom extras:

            public delegate void Delegate(uint _1, ref float _2, ref float _3, float _4, float _5, float _6, float _7, float _8, float _9);

            private protected unsafe delegate void _CDelegate(uint _1, float *_2, float *_3, float _4, float _5, float _6, float _7, float _8, float _9, void *_userdata, void **_cleanup_value);

            private protected unsafe void _CCallWrapper(uint _1, float *_2, float *_3, float _4, float _5, float _6, float _7, float _8, float _9, void *_userdata, void **_cleanup_value)
            {
                uint _arg_1;
                _arg_1 = _1;
                ref float _arg_2 = ref *(float *)sizeof(float); // Uninitialized ref.
                _arg_2 = ref *_2;
                ref float _arg_3 = ref *(float *)sizeof(float); // Uninitialized ref.
                _arg_3 = ref *_3;
                float _arg_4;
                _arg_4 = _4;
                float _arg_5;
                _arg_5 = _5;
                float _arg_6;
                _arg_6 = _6;
                float _arg_7;
                _arg_7 = _7;
                float _arg_8;
                _arg_8 = _8;
                float _arg_9;
                _arg_9 = _9;
                ((Delegate)System.Runtime.InteropServices.GCHandle.FromIntPtr((nint)_userdata).Target!)(_arg_1, ref _arg_2, ref _arg_3, _arg_4, _arg_5, _arg_6, _arg_7, _arg_8, _arg_9);
            }

            /// Construct from a delegate.
            public unsafe Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(Delegate func) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float._Underlying *__Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructEx(_CDelegate func, void *userdata, JPH.StdFunctionPostCallCallbackDelegate postcall_callback, JPH.StdFunctionUserdataCallbackDelegate userdata_callback);
                _UnderlyingPtr = __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructEx(_CCallWrapper, (void *)System.Runtime.InteropServices.GCHandle.ToIntPtr(System.Runtime.InteropServices.GCHandle.Alloc(func)), JPH.StdFunctionPostCallCallback, JPH.StdFunctionUserdataCallback);
            }

            public static unsafe implicit operator Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(JPH.Std.Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float.Delegate func) {return new(func);}
        }

        /// Stores a functor of type: `void(unsigned int, float &, float &, float, float, float, float, float, float)`. Possibly stateful.
        /// This is the non-const half of the class.
        public class Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float : Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float
        {
            internal unsafe Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float._Underlying *__Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_DefaultConstruct();
                _UnderlyingPtr = __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_DefaultConstruct();
            }

            /// Constructs a copy of another instance. The source remains alive.
            public unsafe Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(JPH.Std._ByValue_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float._Underlying *__Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Std.Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float._Underlying *other);
                _UnderlyingPtr = __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
                if (other.Value is not null) _KeepAlive(other.Value);
            }

            /// Constructs a copy of another instance. The source remains alive.
            public Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float other) : this(new _ByValue_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(other)) {}

            /// Constructs a copy of another instance. The source remains alive.
            public Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float other) : this((Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float)other) {}

            /// Assigns the contents from another instance. Both objects remain alive after the call.
            public unsafe void Assign(JPH.Std._ByValue_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_AssignFromAnother(_Underlying *_this, JPH._PassBy other_pass_by, JPH.Std.Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float._Underlying *other);
                _DiscardKeepAlive();
                if (other.Value is not null) _KeepAlive(other.Value);
                __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_AssignFromAnother(_UnderlyingPtr, other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            }

            /// Destroys the stored callable, making this instance null.
            public unsafe void Reset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_reset(_Underlying *_this);
                __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_reset(_UnderlyingPtr);
            }

            // Custom extras:

            /// Construct from a delegate.
            public unsafe Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(Delegate func) : base(func) {}

            /// Assign from a delegate.
            public unsafe void Assign(Delegate func)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_AssignEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_AssignEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_AssignEx(Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float._Underlying *_this, _CDelegate func, void *userdata, JPH.StdFunctionPostCallCallbackDelegate postcall_callback, JPH.StdFunctionUserdataCallbackDelegate userdata_callback);
                __Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_AssignEx(_UnderlyingPtr, _CCallWrapper, (void *)System.Runtime.InteropServices.GCHandle.ToIntPtr(System.Runtime.InteropServices.GCHandle.Alloc(func)), JPH.StdFunctionPostCallCallback, JPH.StdFunctionUserdataCallback);
            }
        }

        /// This is used as a function parameter when the underlying function receives `Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float`/`Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float
        {
            #pragma warning disable CS0649
            internal readonly Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float? Value;
            #pragma warning restore CS0649
            internal readonly JPH._PassBy PassByMode;
            public _ByValue_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float() {PassByMode = JPH._PassBy.default_construct;}
            public _ByValue_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
            public static implicit operator _ByValue_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float arg) {return new(arg);}
            public _ByValue_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(JPH._Moved<Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
            public static implicit operator _ByValue_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(JPH._Moved<Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float> arg) {return new(arg);}

            public static unsafe implicit operator _ByValue_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(JPH.Std.Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float.Delegate func) {return new Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(func);}}

        /// This is used for optional parameters of class `Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float`/`Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float` directly.
        public class _InOptMut_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float
        {
            public Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float? Opt;

            public _InOptMut_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float() {}
            public _InOptMut_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float value) {Opt = value;}
            public static implicit operator _InOptMut_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float value) {return new(value);}
        }

        /// This is used for optional parameters of class `Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float`/`Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float` to pass it to the function.
        public class _InOptConst_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float
        {
            public Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float? Opt;

            public _InOptConst_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float() {}
            public _InOptConst_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float value) {Opt = value;}
            public static implicit operator _InOptConst_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(Const_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float value) {return new(value);}

            public static unsafe implicit operator _InOptConst_Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(JPH.Std.Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float.Delegate func) {return new Function_Void_From_UnsignedInt_FloatRef_FloatRef_Float_Float_Float_Float_Float_Float(func);}}
    }
}
