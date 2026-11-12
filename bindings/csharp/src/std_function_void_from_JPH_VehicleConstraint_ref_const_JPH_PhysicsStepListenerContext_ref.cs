// machine generated, do not edit
public static partial class JPH
{
    public static partial class Std
    {
        /// Stores a functor of type: `void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)`. Possibly stateful.
        /// This is the const half of the class.
        public class Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef : JPH.Object<Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_Destroy(_Underlying *_this);
                __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef() {Dispose(false);}

            internal unsafe Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *__Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_DefaultConstruct();
                _UnderlyingPtr = __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_DefaultConstruct();
            }

            /// Constructs a copy of another instance. The source remains alive.
            public unsafe Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(JPH.Std._ByValue_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *__Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Std.Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *other);
                _UnderlyingPtr = __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
                if (other.Value is not null) _KeepAlive(other.Value);
            }

            /// Constructs a copy of another instance. The source remains alive.
            public Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef other) : this(new _ByValue_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(other)) {}

            /// Constructs a copy of another instance. The source remains alive.
            public Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef other) : this((Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef)other) {}

            /// Returns true if this instance stores a callable, as opposed to being null.
            public static unsafe implicit operator bool(JPH.Std.Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef _this)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_has_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_has_value", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_has_value(JPH.Std.Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *_this);
                return __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_has_value(_this._UnderlyingPtr) != 0;
            }

            /// Calls the stored callable.
            public unsafe void Call(JPH.VehicleConstraint _1, JPH.Const_PhysicsStepListenerContext _2)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_call(_Underlying *_this, JPH.VehicleConstraint._Underlying *_1, JPH.Const_PhysicsStepListenerContext._Underlying *_2);
                __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_call(_UnderlyingPtr, _1._UnderlyingPtr, _2._UnderlyingPtr);
            }

            // Custom extras:

            public delegate void Delegate(JPH.VehicleConstraint _1, JPH.Const_PhysicsStepListenerContext _2);

            private protected unsafe delegate void _CDelegate(JPH.VehicleConstraint._Underlying *_1, JPH.Const_PhysicsStepListenerContext._Underlying *_2, void *_userdata, void **_cleanup_value);

            private protected unsafe void _CCallWrapper(JPH.VehicleConstraint._Underlying *_1, JPH.Const_PhysicsStepListenerContext._Underlying *_2, void *_userdata, void **_cleanup_value)
            {
                JPH.VehicleConstraint _arg_1;
                _arg_1 = new(_1, is_owning: false);
                JPH.Const_PhysicsStepListenerContext _arg_2;
                _arg_2 = new(_2, is_owning: false);
                ((Delegate)System.Runtime.InteropServices.GCHandle.FromIntPtr((nint)_userdata).Target!)(_arg_1, _arg_2);
            }

            /// Construct from a delegate.
            public unsafe Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(Delegate func) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *__Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructEx(_CDelegate func, void *userdata, JPH.StdFunctionPostCallCallbackDelegate postcall_callback, JPH.StdFunctionUserdataCallbackDelegate userdata_callback);
                _UnderlyingPtr = __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructEx(_CCallWrapper, (void *)System.Runtime.InteropServices.GCHandle.ToIntPtr(System.Runtime.InteropServices.GCHandle.Alloc(func)), JPH.StdFunctionPostCallCallback, JPH.StdFunctionUserdataCallback);
            }

            public static unsafe implicit operator Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(JPH.Std.Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef.Delegate func) {return new(func);}
        }

        /// Stores a functor of type: `void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)`. Possibly stateful.
        /// This is the non-const half of the class.
        public class Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef : Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef
        {
            internal unsafe Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *__Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_DefaultConstruct();
                _UnderlyingPtr = __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_DefaultConstruct();
            }

            /// Constructs a copy of another instance. The source remains alive.
            public unsafe Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(JPH.Std._ByValue_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *__Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructFromAnother(JPH._PassBy other_pass_by, JPH.Std.Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *other);
                _UnderlyingPtr = __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
                if (other.Value is not null) _KeepAlive(other.Value);
            }

            /// Constructs a copy of another instance. The source remains alive.
            public Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef other) : this(new _ByValue_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(other)) {}

            /// Constructs a copy of another instance. The source remains alive.
            public Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef other) : this((Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef)other) {}

            /// Assigns the contents from another instance. Both objects remain alive after the call.
            public unsafe void Assign(JPH.Std._ByValue_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_AssignFromAnother(_Underlying *_this, JPH._PassBy other_pass_by, JPH.Std.Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *other);
                _DiscardKeepAlive();
                if (other.Value is not null) _KeepAlive(other.Value);
                __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_AssignFromAnother(_UnderlyingPtr, other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            }

            /// Destroys the stored callable, making this instance null.
            public unsafe void Reset()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_reset(_Underlying *_this);
                __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_reset(_UnderlyingPtr);
            }

            // Custom extras:

            /// Construct from a delegate.
            public unsafe Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(Delegate func) : base(func) {}

            /// Assign from a delegate.
            public unsafe void Assign(Delegate func)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_AssignEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_AssignEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_AssignEx(Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef._Underlying *_this, _CDelegate func, void *userdata, JPH.StdFunctionPostCallCallbackDelegate postcall_callback, JPH.StdFunctionUserdataCallbackDelegate userdata_callback);
                __Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_AssignEx(_UnderlyingPtr, _CCallWrapper, (void *)System.Runtime.InteropServices.GCHandle.ToIntPtr(System.Runtime.InteropServices.GCHandle.Alloc(func)), JPH.StdFunctionPostCallCallback, JPH.StdFunctionUserdataCallback);
            }
        }

        /// This is used as a function parameter when the underlying function receives `Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef` by value.
        /// Usage:
        /// * Pass `new()` to default-construct the instance.
        /// * Pass an instance of `Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef`/`Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef
        {
            #pragma warning disable CS0649
            internal readonly Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef? Value;
            #pragma warning restore CS0649
            internal readonly JPH._PassBy PassByMode;
            public _ByValue_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef() {PassByMode = JPH._PassBy.default_construct;}
            public _ByValue_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef new_value) {Value = new_value; PassByMode = JPH._PassBy.copy;}
            public static implicit operator _ByValue_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef arg) {return new(arg);}
            public _ByValue_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(JPH._Moved<Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef> moved) {Value = moved.Value; PassByMode = JPH._PassBy.move;}
            public static implicit operator _ByValue_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(JPH._Moved<Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef> arg) {return new(arg);}

            public static unsafe implicit operator _ByValue_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(JPH.Std.Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef.Delegate func) {return new Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(func);}}

        /// This is used for optional parameters of class `Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef`/`Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef` directly.
        public class _InOptMut_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef
        {
            public Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef? Opt;

            public _InOptMut_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef() {}
            public _InOptMut_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef value) {Opt = value;}
            public static implicit operator _InOptMut_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef value) {return new(value);}
        }

        /// This is used for optional parameters of class `Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef`/`Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef` to pass it to the function.
        public class _InOptConst_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef
        {
            public Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef? Opt;

            public _InOptConst_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef() {}
            public _InOptConst_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef value) {Opt = value;}
            public static implicit operator _InOptConst_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(Const_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef value) {return new(value);}

            public static unsafe implicit operator _InOptConst_Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(JPH.Std.Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef.Delegate func) {return new Function_Void_From_JPHVehicleConstraintRef_ConstJPHPhysicsStepListenerContextRef(func);}}
    }
}
