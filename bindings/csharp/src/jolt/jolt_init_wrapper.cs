// machine generated, do not edit
public static partial class Jolt
{
    /// Minimal helpers for Jolt global lifecycle.
    /// These are the only hand-implemented methods; their C/C# bindings are machine-generated.
    /// Generated from class `JoltHelpers`.
    /// This is the const half of the class.
    public class Const_JoltHelpers : Jolt.Object<Const_JoltHelpers>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_Destroy(_Underlying *_this);
            __JoltHelpers_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_JoltHelpers() {Dispose(false);}

        internal unsafe Const_JoltHelpers(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_JoltHelpers() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltHelpers._Underlying *__JoltHelpers_DefaultConstruct();
            _UnderlyingPtr = __JoltHelpers_DefaultConstruct();
        }

        /// Generated from constructor `JoltHelpers::JoltHelpers`.
        public unsafe Const_JoltHelpers(Jolt.Const_JoltHelpers _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltHelpers._Underlying *__JoltHelpers_ConstructFromAnother(Jolt.JoltHelpers._Underlying *_other);
            _UnderlyingPtr = __JoltHelpers_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltHelpers::JoltHelpers`.
        public Const_JoltHelpers(JoltHelpers _other) : this((Const_JoltHelpers)_other) {}

        /// Initialize Jolt: set Trace, RegisterDefaultAllocator, create Factory, RegisterTypes.
        /// Generated from method `JoltHelpers::Init`.
        public static void Init()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_Init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_Init", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_Init();
            __JoltHelpers_Init();
        }

        /// Generated from method `JoltHelpers::Shutdown`.
        public static void Shutdown()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_Shutdown", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_Shutdown", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __JoltHelpers_Shutdown();
            __JoltHelpers_Shutdown();
        }
    }

    /// Minimal helpers for Jolt global lifecycle.
    /// These are the only hand-implemented methods; their C/C# bindings are machine-generated.
    /// Generated from class `JoltHelpers`.
    /// This is the non-const half of the class.
    public class JoltHelpers : Const_JoltHelpers
    {
        internal unsafe JoltHelpers(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe JoltHelpers() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltHelpers._Underlying *__JoltHelpers_DefaultConstruct();
            _UnderlyingPtr = __JoltHelpers_DefaultConstruct();
        }

        /// Generated from constructor `JoltHelpers::JoltHelpers`.
        public unsafe JoltHelpers(Jolt.Const_JoltHelpers _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltHelpers._Underlying *__JoltHelpers_ConstructFromAnother(Jolt.JoltHelpers._Underlying *_other);
            _UnderlyingPtr = __JoltHelpers_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `JoltHelpers::JoltHelpers`.
        public JoltHelpers(JoltHelpers _other) : this((Const_JoltHelpers)_other) {}

        /// Generated from method `JoltHelpers::operator=`.
        public unsafe Jolt.JoltHelpers Assign(Jolt.Const_JoltHelpers _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cjolt.framework/cjolt", EntryPoint = "JoltHelpers_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cjolt", EntryPoint = "JoltHelpers_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Jolt.JoltHelpers._Underlying *__JoltHelpers_AssignFromAnother(_Underlying *_this, Jolt.JoltHelpers._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__JoltHelpers_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }
    }

    /// This is used for optional parameters of class `JoltHelpers` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_JoltHelpers`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltHelpers`/`Const_JoltHelpers` directly.
    public class _InOptMut_JoltHelpers
    {
        public JoltHelpers? Opt;

        public _InOptMut_JoltHelpers() {}
        public _InOptMut_JoltHelpers(JoltHelpers value) {Opt = value;}
        public static implicit operator _InOptMut_JoltHelpers(JoltHelpers value) {return new(value);}
    }

    /// This is used for optional parameters of class `JoltHelpers` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_JoltHelpers`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `JoltHelpers`/`Const_JoltHelpers` to pass it to the function.
    public class _InOptConst_JoltHelpers
    {
        public Const_JoltHelpers? Opt;

        public _InOptConst_JoltHelpers() {}
        public _InOptConst_JoltHelpers(Const_JoltHelpers value) {Opt = value;}
        public static implicit operator _InOptConst_JoltHelpers(Const_JoltHelpers value) {return new(value);}
    }
}
