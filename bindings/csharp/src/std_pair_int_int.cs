// machine generated, do not edit
public static partial class JPH
{
    public static partial class Std
    {
        /// Stores two objects: `int` and `int`.
        /// This is the const half of the class.
        public class Const_Pair_Int_Int : JPH.Object<Const_Pair_Int_Int>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_pair_int_int_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_pair_int_int_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_pair_int_int_Destroy(_Underlying *_this);
                __Jolt_std_pair_int_int_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_Pair_Int_Int() {Dispose(false);}

            internal unsafe Const_Pair_Int_Int(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_Pair_Int_Int() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_pair_int_int_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_pair_int_int_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Pair_Int_Int._Underlying *__Jolt_std_pair_int_int_DefaultConstruct();
                _UnderlyingPtr = __Jolt_std_pair_int_int_DefaultConstruct();
            }

            /// Constructs a copy of another instance. The source remains alive.
            public unsafe Const_Pair_Int_Int(JPH.Std.Const_Pair_Int_Int other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_pair_int_int_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_pair_int_int_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Pair_Int_Int._Underlying *__Jolt_std_pair_int_int_ConstructFromAnother(JPH.Std.Pair_Int_Int._Underlying *other);
                _UnderlyingPtr = __Jolt_std_pair_int_int_ConstructFromAnother(other._UnderlyingPtr);
                _KeepAlive(other);
            }

            /// Constructs a copy of another instance. The source remains alive.
            public Const_Pair_Int_Int(Pair_Int_Int other) : this((Const_Pair_Int_Int)other) {}

            /// Constructs the pair elementwise.
            public unsafe Const_Pair_Int_Int(int first, int second) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_pair_int_int_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_pair_int_int_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Pair_Int_Int._Underlying *__Jolt_std_pair_int_int_Construct(int first, int second);
                _UnderlyingPtr = __Jolt_std_pair_int_int_Construct(first, second);
            }

            /// The first of the two elements, read-only.
            public unsafe int First()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_pair_int_int_first", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_pair_int_int_first", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__Jolt_std_pair_int_int_first(_Underlying *_this);
                return *__Jolt_std_pair_int_int_first(_UnderlyingPtr);
            }

            /// The second of the two elements, read-only.
            public unsafe int Second()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_pair_int_int_second", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_pair_int_int_second", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__Jolt_std_pair_int_int_second(_Underlying *_this);
                return *__Jolt_std_pair_int_int_second(_UnderlyingPtr);
            }

            // Custom extras:

            public void Deconstruct(out int _1, out int _2)
            {
                _1 = First();
                _2 = Second();
            }
        }

        /// Stores two objects: `int` and `int`.
        /// This is the non-const half of the class.
        public class Pair_Int_Int : Const_Pair_Int_Int
        {
            internal unsafe Pair_Int_Int(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Pair_Int_Int() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_pair_int_int_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_pair_int_int_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Pair_Int_Int._Underlying *__Jolt_std_pair_int_int_DefaultConstruct();
                _UnderlyingPtr = __Jolt_std_pair_int_int_DefaultConstruct();
            }

            /// Constructs a copy of another instance. The source remains alive.
            public unsafe Pair_Int_Int(JPH.Std.Const_Pair_Int_Int other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_pair_int_int_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_pair_int_int_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Pair_Int_Int._Underlying *__Jolt_std_pair_int_int_ConstructFromAnother(JPH.Std.Pair_Int_Int._Underlying *other);
                _UnderlyingPtr = __Jolt_std_pair_int_int_ConstructFromAnother(other._UnderlyingPtr);
                _KeepAlive(other);
            }

            /// Constructs a copy of another instance. The source remains alive.
            public Pair_Int_Int(Pair_Int_Int other) : this((Const_Pair_Int_Int)other) {}

            /// Assigns the contents from another instance. Both objects remain alive after the call.
            public unsafe void Assign(JPH.Std.Const_Pair_Int_Int other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_pair_int_int_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_pair_int_int_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __Jolt_std_pair_int_int_AssignFromAnother(_Underlying *_this, JPH.Std.Pair_Int_Int._Underlying *other);
                _DiscardKeepAlive();
                _KeepAlive(other);
                __Jolt_std_pair_int_int_AssignFromAnother(_UnderlyingPtr, other._UnderlyingPtr);
            }

            /// Constructs the pair elementwise.
            public unsafe Pair_Int_Int(int first, int second) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_pair_int_int_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_pair_int_int_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static JPH.Std.Pair_Int_Int._Underlying *__Jolt_std_pair_int_int_Construct(int first, int second);
                _UnderlyingPtr = __Jolt_std_pair_int_int_Construct(first, second);
            }

            /// The first of the two elements, mutable.
            public unsafe new ref int First()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_pair_int_int_first_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_pair_int_int_first_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__Jolt_std_pair_int_int_first_mut(_Underlying *_this);
                return ref *__Jolt_std_pair_int_int_first_mut(_UnderlyingPtr);
            }

            /// The second of the two elements, mutable.
            public unsafe new ref int Second()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "Jolt_std_pair_int_int_second_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "Jolt_std_pair_int_int_second_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__Jolt_std_pair_int_int_second_mut(_Underlying *_this);
                return ref *__Jolt_std_pair_int_int_second_mut(_UnderlyingPtr);
            }

            // Custom extras:

            public void Deconstruct(out JPH.Ref<int> _1, out JPH.Ref<int> _2)
            {
                _1 = new(ref First());
                _2 = new(ref Second());
            }
        }

        /// This is used for optional parameters of class `Pair_Int_Int` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_Pair_Int_Int`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Pair_Int_Int`/`Const_Pair_Int_Int` directly.
        public class _InOptMut_Pair_Int_Int
        {
            public Pair_Int_Int? Opt;

            public _InOptMut_Pair_Int_Int() {}
            public _InOptMut_Pair_Int_Int(Pair_Int_Int value) {Opt = value;}
            public static implicit operator _InOptMut_Pair_Int_Int(Pair_Int_Int value) {return new(value);}
        }

        /// This is used for optional parameters of class `Pair_Int_Int` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_Pair_Int_Int`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `Pair_Int_Int`/`Const_Pair_Int_Int` to pass it to the function.
        public class _InOptConst_Pair_Int_Int
        {
            public Const_Pair_Int_Int? Opt;

            public _InOptConst_Pair_Int_Int() {}
            public _InOptConst_Pair_Int_Int(Const_Pair_Int_Int value) {Opt = value;}
            public static implicit operator _InOptConst_Pair_Int_Int(Const_Pair_Int_Int value) {return new(value);}
        }
    }
}
