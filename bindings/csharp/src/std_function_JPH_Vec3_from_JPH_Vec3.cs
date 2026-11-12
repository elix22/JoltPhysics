// machine generated, do not edit
public static partial class JPH
{
    public static partial class Std
    {
        /// Stores a functor of type: `JPH::Vec3(JPH::Vec3)`. Possibly stateful.
        /// This is the const half of the class.
        public class Const_Function_JPHVec3_From_JPHVec3 : JPH.Object<Const_Function_JPHVec3_From_JPHVec3>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_Destroy(_Underlying *_this);
                __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Function_JPHVec3_From_JPHVec3() {Dispose(false);}

            internal unsafe Const_Function_JPHVec3_From_JPHVec3(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Function_JPHVec3_From_JPHVec3() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_JPHVec3_From_JPHVec3._Underlying *__Jolt_std_function_JPH_Vec3_from_JPH_Vec3_DefaultConstruct();
                _UnderlyingPtr = __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_DefaultConstruct();
            }

            /// Constructs a copy of another instance. The source remains alive.
            public unsafe Const_Function_JPHVec3_From_JPHVec3(JPH.Std._ByValue_Function_JPHVec3_From_JPHVec3 other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_JPHVec3_From_JPHVec3._Underlying *__Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Std.Function_JPHVec3_From_JPHVec3._Underlying *other);
                _UnderlyingPtr = __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
                if (other.Value is not null) _KeepAlive(other.Value);
            }

            /// Constructs a copy of another instance. The source remains alive.
            public Const_Function_JPHVec3_From_JPHVec3(Const_Function_JPHVec3_From_JPHVec3 other) : this(new _ByValue_Function_JPHVec3_From_JPHVec3(other)) {}

            /// Constructs a copy of another instance. The source remains alive.
            public Const_Function_JPHVec3_From_JPHVec3(Function_JPHVec3_From_JPHVec3 other) : this((Const_Function_JPHVec3_From_JPHVec3)other) {}

            /// Returns true if this instance stores a callable, as opposed to being null.
            public static unsafe implicit operator bool(JPH.Std.Const_Function_JPHVec3_From_JPHVec3 _this)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_has_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_has_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_has_value(JPH.Std.Const_Function_JPHVec3_From_JPHVec3._Underlying *_this);
                return __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_has_value(_this._UnderlyingPtr) != 0;
            }

            /// Calls the stored callable.
            public unsafe JPH.Vec3 Call(JPH.Const_Vec3 _1)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Vec3._Underlying *__Jolt_std_function_JPH_Vec3_from_JPH_Vec3_call(_Underlying *_this, JPH.Vec3._Underlying *_1);
                return new(__Jolt_std_function_JPH_Vec3_from_JPH_Vec3_call(_UnderlyingPtr, _1._UnderlyingPtr), is_owning: true);
            }

            // Custom extras:

            public delegate JPH.Const_Vec3 Delegate(JPH.Vec3 _1);

            private protected unsafe delegate JPH.Vec3._Underlying *_CDelegate(JPH.Vec3._Underlying *_1, void *_userdata, void **_cleanup_value);

            private protected unsafe JPH.Vec3._Underlying *_CCallWrapper(JPH.Vec3._Underlying *_1, void *_userdata, void **_cleanup_value)
            {
                JPH.Vec3 _arg_1;
                _arg_1 = new(_1, is_owning: false);
                JPH.Const_Vec3 _ret = ((Delegate)System.Runtime.InteropServices.GCHandle.FromIntPtr((nint)_userdata).Target!)(_arg_1);
                *_cleanup_value = (void *)System.Runtime.InteropServices.GCHandle.ToIntPtr(System.Runtime.InteropServices.GCHandle.Alloc(_ret));
                return _ret._UnderlyingPtr;
            }

            /// Construct from a delegate.
            public unsafe Const_Function_JPHVec3_From_JPHVec3(Delegate func) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Const_Function_JPHVec3_From_JPHVec3._Underlying *__Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructEx(_CDelegate func, void *userdata, JPH.StdFunctionPostCallCallbackDelegate postcall_callback, JPH.StdFunctionUserdataCallbackDelegate userdata_callback);
                _UnderlyingPtr = __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructEx(_CCallWrapper, (void *)System.Runtime.InteropServices.GCHandle.ToIntPtr(System.Runtime.InteropServices.GCHandle.Alloc(func)), JPH.StdFunctionPostCallCallback, JPH.StdFunctionUserdataCallback);
            }

            public static unsafe implicit operator Const_Function_JPHVec3_From_JPHVec3(JPH.Std.Function_JPHVec3_From_JPHVec3.Delegate func) {return new(func);}
        }

        /// Stores a functor of type: `JPH::Vec3(JPH::Vec3)`. Possibly stateful.
        /// This is the non-const half of the class.
        public class Function_JPHVec3_From_JPHVec3 : Const_Function_JPHVec3_From_JPHVec3
        {
            internal unsafe Function_JPHVec3_From_JPHVec3(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Function_JPHVec3_From_JPHVec3() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_JPHVec3_From_JPHVec3._Underlying *__Jolt_std_function_JPH_Vec3_from_JPH_Vec3_DefaultConstruct();
                _UnderlyingPtr = __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_DefaultConstruct();
            }

            /// Constructs a copy of another instance. The source remains alive.
            public unsafe Function_JPHVec3_From_JPHVec3(JPH.Std._ByValue_Function_JPHVec3_From_JPHVec3 other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_JPHVec3_From_JPHVec3._Underlying *__Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Std.Function_JPHVec3_From_JPHVec3._Underlying *other);
                _UnderlyingPtr = __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
                if (other.Value is not null) _KeepAlive(other.Value);
            }

            /// Constructs a copy of another instance. The source remains alive.
            public Function_JPHVec3_From_JPHVec3(Const_Function_JPHVec3_From_JPHVec3 other) : this(new _ByValue_Function_JPHVec3_From_JPHVec3(other)) {}

            /// Constructs a copy of another instance. The source remains alive.
            public Function_JPHVec3_From_JPHVec3(Function_JPHVec3_From_JPHVec3 other) : this((Const_Function_JPHVec3_From_JPHVec3)other) {}

            /// Assigns the contents from another instance. Both objects remain alive after the call.
            public unsafe void Assign(JPH.Std._ByValue_Function_JPHVec3_From_JPHVec3 other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_AssignFromAnother(_Underlying *_this, JPH._PassBy other_pass_by, JPH.Std.Function_JPHVec3_From_JPHVec3._Underlying *other);
                _DiscardKeepAlive();
                if (other.Value is not null) _KeepAlive(other.Value);
                __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_AssignFromAnother(_UnderlyingPtr, other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            }

            /// Destroys the stored callable, making this instance null.
            public unsafe void Reset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_reset(_Underlying *_this);
                __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_reset(_UnderlyingPtr);
            }

            // Custom extras:

            /// Construct from a delegate.
            public unsafe Function_JPHVec3_From_JPHVec3(Delegate func) : base(func) {}

            /// Assign from a delegate.
            public unsafe void Assign(Delegate func)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_AssignEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_JPH_Vec3_from_JPH_Vec3_AssignEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_AssignEx(Function_JPHVec3_From_JPHVec3._Underlying *_this, _CDelegate func, void *userdata, JPH.StdFunctionPostCallCallbackDelegate postcall_callback, JPH.StdFunctionUserdataCallbackDelegate userdata_callback);
                __Jolt_std_function_JPH_Vec3_from_JPH_Vec3_AssignEx(_UnderlyingPtr, _CCallWrapper, (void *)System.Runtime.InteropServices.GCHandle.ToIntPtr(System.Runtime.InteropServices.GCHandle.Alloc(func)), JPH.StdFunctionPostCallCallback, JPH.StdFunctionUserdataCallback);
            }
        }

        /// This is used as a function parameter when the underlying function receives `Function_JPHVec3_From_JPHVec3` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `Function_JPHVec3_From_JPHVec3`/`Const_Function_JPHVec3_From_JPHVec3` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_Function_JPHVec3_From_JPHVec3
        {
            #pragma warning disable CS0649
            internal readonly Const_Function_JPHVec3_From_JPHVec3? Value;
            #pragma warning restore CS0649
            internal readonly JPH._PassBy PassByMode;
            public _ByValue_Function_JPHVec3_From_JPHVec3() {PassByMode = JPH._PassBy.default_construct;}
            public _ByValue_Function_JPHVec3_From_JPHVec3(Const_Function_JPHVec3_From_JPHVec3 new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
            public static implicit operator _ByValue_Function_JPHVec3_From_JPHVec3(Const_Function_JPHVec3_From_JPHVec3 arg) {return new(arg);}
            public _ByValue_Function_JPHVec3_From_JPHVec3(JPH._Moved<Function_JPHVec3_From_JPHVec3> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
            public static implicit operator _ByValue_Function_JPHVec3_From_JPHVec3(JPH._Moved<Function_JPHVec3_From_JPHVec3> arg) {return new(arg);}

            public static unsafe implicit operator _ByValue_Function_JPHVec3_From_JPHVec3(JPH.Std.Function_JPHVec3_From_JPHVec3.Delegate func) {return new Function_JPHVec3_From_JPHVec3(func);}}

        /// This is used for optional parameters of class `Function_JPHVec3_From_JPHVec3` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Function_JPHVec3_From_JPHVec3`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Function_JPHVec3_From_JPHVec3`/`Const_Function_JPHVec3_From_JPHVec3` directly.
        public class _InOptMut_Function_JPHVec3_From_JPHVec3
        {
            public Function_JPHVec3_From_JPHVec3? Opt;

            public _InOptMut_Function_JPHVec3_From_JPHVec3() {}
            public _InOptMut_Function_JPHVec3_From_JPHVec3(Function_JPHVec3_From_JPHVec3 value) {Opt = value;}
            public static implicit operator _InOptMut_Function_JPHVec3_From_JPHVec3(Function_JPHVec3_From_JPHVec3 value) {return new(value);}
        }

        /// This is used for optional parameters of class `Function_JPHVec3_From_JPHVec3` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Function_JPHVec3_From_JPHVec3`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Function_JPHVec3_From_JPHVec3`/`Const_Function_JPHVec3_From_JPHVec3` to pass it to the function.
        public class _InOptConst_Function_JPHVec3_From_JPHVec3
        {
            public Const_Function_JPHVec3_From_JPHVec3? Opt;

            public _InOptConst_Function_JPHVec3_From_JPHVec3() {}
            public _InOptConst_Function_JPHVec3_From_JPHVec3(Const_Function_JPHVec3_From_JPHVec3 value) {Opt = value;}
            public static implicit operator _InOptConst_Function_JPHVec3_From_JPHVec3(Const_Function_JPHVec3_From_JPHVec3 value) {return new(value);}

            public static unsafe implicit operator _InOptConst_Function_JPHVec3_From_JPHVec3(JPH.Std.Function_JPHVec3_From_JPHVec3.Delegate func) {return new Function_JPHVec3_From_JPHVec3(func);}}
    }
}
